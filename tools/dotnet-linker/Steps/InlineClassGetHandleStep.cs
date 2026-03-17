using System.Linq;
using System.Text;

using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Linker;
using Mono.Tuner;

using Xamarin.Bundler;

#nullable enable

namespace Xamarin.Linker.Steps;

// See docs/code/class-handles.md for an overview of class handle handling.

// Find all the references to Objective-C classes for each assembly.
// * If an assembly is trimmed, we replace calls to (inline) Class.GetHandle with a P/Invoke that fetches the class in question.
// * If an assembly is not trimmed, we do not inline Class.GetHandle, but we keep a list of all the Objective-C classes that are used, so that tell the native linker about them so they're not linked away by the native linker.
//
// The sticky problem is that we can't inspect the managed output from NativeAOT, which means
// we can't list the Objective-C classes NativeAOT-compiled assemblies using. To get around this
// problem, we convert calls to Class.GetHandle to a P/Invoke which fetches the native Objective-C
// class handle directly - because we _can_ list the P/Invoke calls from NativeAOT-compiled code.
//
// For non-trimmed assemblies, we don't need to do this, because we know nothing from the assembly
// will be trimmed away. This has the added advantage of being Hot Reload compatible, because we
// can't modify assemblies when we're doing Hot Reload.

public class InlineClassGetHandleStep : AssemblyModifierStep {

	protected override string Name { get; } = "Inline Class GetHandle";
	protected override int ErrorCode { get; } = 2262;

	bool strictMode;
	bool? inlining_enabled;

	Dictionary<string, Registrar.Registrar.ObjCType> objectiveCTypeMap = new ();

	protected override void TryProcess ()
	{
		strictMode = Configuration.InlineClassGetHandle == InlineClassGetHandleMode.Strict;

		if (strictMode && Configuration.Application.Registrar == Bundler.RegistrarMode.Dynamic) {
			Report (ErrorHelper.CreateError (Configuration.Application, 2262, null, Errors.MX2262));
		}

		objectiveCTypeMap = DerivedLinkContext.StaticRegistrar.Types.ToDictionary (v => v.Value.ExportedName, v => v.Value);

		if (!string.IsNullOrEmpty (Configuration.TypeMapFilePath)) {
			var sb = new StringBuilder ();
			foreach (var info in objectiveCTypeMap.Values.OrderBy (v => v.ExportedName)) {
				var td = info.Type.Resolve ();
				if (td is null)
					continue;
				var introduced = DerivedLinkContext.StaticRegistrar.GetSdkIntroducedVersion (td, out _);
				if (Frameworks.TryGetFramework (App, td, out string? framework))
					sb.AppendLine ($"Class={info.ExportedName}|Framework={framework}|Introduced={introduced}");
			}
			Driver.WriteIfDifferent (Configuration.TypeMapFilePath, sb.ToString ());
		}

		base.TryProcess ();
	}

	protected override bool IsActiveFor (AssemblyDefinition assembly)
	{
		if (!Configuration.Profile.IsOrReferencesProductAssembly (assembly))
			return false;

		// we have to process both trimmed and non-trimmed assemblies.

		return true;
	}

	protected override bool ModifyAssembly (AssemblyDefinition assembly)
	{
		inlining_enabled = Annotations.GetAction (assembly) == AssemblyAction.Link;
		var modified = base.ModifyAssembly (assembly);
		inlining_enabled = null;
		return modified;
	}

	protected override bool ProcessType (TypeDefinition type)
	{
		var modified = false;

		if (inlining_enabled == true) {
			modified |= ProcessMethods (type);
		} else {
			if (ListExportedSymbols.TryGetRequiredObjectiveCType (DerivedLinkContext, type, out var exportedName)) {
				DerivedLinkContext.RequiredSymbols.AddObjectiveCClass (exportedName).AddMember (type);
			}
		}
		return modified;
	}

	MethodDefinition GetOrCreatePInvokeMethod (MethodDefinition callingMethod, string objectiveCClassName)
	{
		// [DllImport ("__Internal")]
		// static extern IntPtr xamarin_Class_GetClassHandle_{objectiveCClassName}_Native ();

		return abr.CreateInternalPInvoke (callingMethod.Module, "ObjCRuntime", "Class", $"xamarin_Class_GetHandle_{objectiveCClassName}_Native", out _);
	}

	protected override bool ProcessMethod (MethodDefinition method)
	{
		var modified = false;

		if (!method.HasBody)
			return modified;

		if (method.DeclaringType.Name == "Class" && method.DeclaringType.Namespace == "ObjCRuntime")
			return modified; // don't process the Class methods themselves

		foreach (var instr in method.Body.Instructions) {
			if (instr.Operand is not MethodReference mr)
				continue;
			if (mr.DeclaringType.Name != "Class" || mr.DeclaringType.Namespace != "ObjCRuntime")
				continue;
			if (mr.Name != "GetHandle" && mr.Name != "GetHandleIntrinsic")
				continue;
			if (mr.Parameters.Count != 1)
				continue;
			if (!mr.Parameters [0].ParameterType.Is ("System", "String"))
				continue;
			if (!mr.ReturnType.Is ("ObjCRuntime", "NativeHandle"))
				continue;

			var ldstr = instr.Previous;
			if (ldstr.OpCode != OpCodes.Ldstr) {
				Report (ErrorHelper.CreateWarning (Configuration.Application, 2263, method, Errors.MX2263, FormatMethod (method), ldstr));
				continue;
			}
			if (ldstr.Operand is not string objectiveCClassName) {
				Report (ErrorHelper.CreateWarning (Configuration.Application, 2263, method, Errors.MX2263, FormatMethod (method), ldstr.Operand));
				continue;
			}

			if (!strictMode) {
				if (ListExportedSymbols.TryGetRequiredObjectiveCType (DerivedLinkContext, method.DeclaringType, out var exportedName)) {
					if (exportedName != objectiveCClassName) {
						Report (ErrorHelper.CreateWarning (Configuration.Application, 2264, method, Errors.MX2264, FormatMethod (method), objectiveCClassName, exportedName));
						continue;
					}
				} else {
					Report (ErrorHelper.CreateWarning (Configuration.Application, 2265, method, Errors.MX2265, FormatMethod (method), objectiveCClassName));
					continue;
				}
			}

			// Check if the Objective-C class is listed as a ReferenceNativeSymbol with Ignore mode, and if so, don't inline the call to Class.GetHandle (because the native symbol won't be available at link time)
			var existingSymbol = DerivedLinkContext.RequiredSymbols.Find (Symbol.ObjectiveCPrefix + objectiveCClassName);
			if (existingSymbol is not null && existingSymbol.Type == SymbolType.ObjectiveCClass && existingSymbol.Mode == SymbolMode.Ignore) {
				Driver.Log (3, "Not inlining the call to Class.GetHandle (\"{0}\") in method {1} because the class is listed as a ReferenceNativeSymbol with Ignore mode.", objectiveCClassName, FormatMethod (method));
				continue;
			}

			if (DerivedLinkContext.App.IsSimulatorBuild) {
				// Check if the Objective-C type is available in the simulator, and if not, don't inline the call to Class.GetHandle (because the app would fail to link)
				if (objectiveCTypeMap.TryGetValue (objectiveCClassName, out var objCType)) {
					if (DerivedLinkContext.HasAvailabilityAttributesShowingUnavailableInSimulator (objCType.Type.Resolve (), method)) {
						Driver.Log (3, "Not inlining the call to Class.GetHandle (\"{0}\") in method {1} because the type is marked with an attribute indicating it's not available in the simulator.", objectiveCClassName, FormatMethod (method));
						continue;
					}
				} else {
					Report (ErrorHelper.CreateWarning (Configuration.Application, 2266, method, Errors.MX2266, FormatMethod (method), objectiveCClassName));
				}
			}

			ldstr.OpCode = OpCodes.Call;
			ldstr.Operand = GetOrCreatePInvokeMethod (method, objectiveCClassName);

			instr.OpCode = OpCodes.Call;
			instr.Operand = abr.NativeObject_op_Implicit_NativeHandle;

			modified = true;
		}

		return modified;
	}

	static string FormatMethod (MethodReference method)
	{
		var rv = method.FullName;
		var idx = rv.IndexOf (' ');
		if (idx > 0)
			rv = rv.Substring (idx + 1);
		return rv;
	}
}
