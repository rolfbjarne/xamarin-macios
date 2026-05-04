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
	protected override int ErrorCode { get; } = 2260;

	bool strictMode;
	bool? inlining_enabled;

	protected override void TryProcess ()
	{
		strictMode = Configuration.InlineClassGetHandle == InlineClassGetHandleMode.Strict;

		if (strictMode && Configuration.Application.Registrar == Bundler.RegistrarMode.Dynamic) {
			// Copilot: create new error code + update resx
			Report (ErrorHelper.CreateError (Configuration.Application, 9999 /* The 'InlineClassGetHandle' option is set to 'Strict', but we're using the dynamic registrar. This is not a supported configuration, because 'Strict' mode requires exported Objective-C classes to be available at compile time, but the dynamic registrar will create them at runtime. Please either change the 'InlineClassGetHandle' option to 'Disabled' or 'Compat', or switch to using the static registrar. */, null, Errors.MX2256));
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
				// Copilot: create new error code + update resx
				Report (ErrorHelper.CreateWarning (Configuration.Application, 9999 /* Unknown or unsupported pattern in call to Class.GetHandle in '{0}': the previous instructions before the call to Class.GetHandle isn't a 'ldstr', it's: '{1}'. The call will not be inlined. Please file an issue at https://github.com/dotnet/macios/issues/new. */, method, Errors.MX2255, FormatMethod (method), ldstr));
				continue;
			}
			if (ldstr.Operand is not string objectiveCClassName) {
				// Copilot: create new error code + update resx
				Report (ErrorHelper.CreateWarning (Configuration.Application, 9999 /* Unknown or unsupported pattern in call to Class.GetHandle in '{0}': the operand of the 'ldstr' instruction before the call to Class.GetHandle isn't a string, it's: '{1}'. The call will not be inlined. Please file an issue at https://github.com/dotnet/macios/issues/new. */, method, Errors.MX2255, FormatMethod (method), ldstr.Operand));
				continue;
			}

			if (!strictMode)  {
				if (ListExportedSymbols.TryGetRequiredObjectiveCType (DerivedLinkContext, method.DeclaringType, out var exportedName)) {
					if (exportedName != objectiveCClassName) {
						// Copilot: create new error code + update resx
						Report (ErrorHelper.CreateWarning (Configuration.Application, 9999 /* The call to Class.GetHandle in '{0}' is trying to get the handle for the Objective-C class '{1}', but we were unable to determine whether this class should be statically preserved or not. Since we're in compat mode, we're assuming the class should not be preserved. */, method, Errors.MX2255, FormatMethod (method), objectiveCClassName, exportedName));
						continue;
					}
				} else {
					// Copilot: create new error code + update resx
					Report (ErrorHelper.CreateWarning (Configuration.Application, 9999 /* The call to Class.GetHandle in '{0}' is trying to get the handle for the Objective-C class '{1}', but we couldn't determine whether this class should be statically preserved or not. Since we're in compat mode, we're assuming the class should not be preserved. */, method, Errors.MX2255, FormatMethod (method), objectiveCClassName));
					continue;
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
