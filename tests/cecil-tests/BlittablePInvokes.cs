using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Mono.Cecil;
using Mono.Cecil.Cil;

using ObjCRuntime;

using Xamarin.Tests;
using Xamarin.Utils;

#nullable enable

namespace Cecil.Tests {

	[TestFixture]
	public class BlittablePInvokes {
		struct MethodBlitResult {
			public MethodBlitResult (bool isBlittable)
			{
				IsBlittable = isBlittable;
				Result = new StringBuilder ();
			}
			public bool IsBlittable;
			public StringBuilder Result;
		}

		struct TypeAndIndex {
			public TypeAndIndex (TypeReference type, int index)
			{
				Type = type;
				Index = index;
			}
			public TypeReference Type;
			public int Index;
		}
		struct BlitAndReason {
			public BlitAndReason (bool isBlittable, string reason)
			{
				IsBlittable = isBlittable;
				Reason = reason;
			}
			public bool IsBlittable;
			public string Reason;
		}

		[Ignore ("work in progress - there are 17 failures in mac version, mostly due to delegates and strings")]
		[TestCaseSource (typeof (Helper), nameof (Helper.NetPlatformImplementationAssemblyDefinitions))]
		public void CheckForNonBlittablePInvokes (AssemblyInfo info)
		{
			var assembly = info.Assembly;
			var pinvokes = AllPInvokes (assembly).Where (IsPInvokeOK);
			Assert.IsTrue (pinvokes.Count () > 0);

			var blitCache = new Dictionary<string, BlitAndReason> ();
			var results = pinvokes.Select (pi => IsMethodBlittable (assembly, pi, blitCache)).Where (r => !r.IsBlittable);
			if (results.Count () > 0) {
				var failString = new StringBuilder ();
				failString.Append ($"There is an issue with {results.Count ()} pinvokes in {assembly.Name} ({info.Path}):\n");
				foreach (var sb in results.Select (r => r.Result)) {
					failString.Append (sb.ToString ());
				}
				Assert.Fail (failString.ToString ());
			}

		}

		MethodBlitResult IsMethodBlittable (AssemblyDefinition assembly, MethodReference method, Dictionary<string, BlitAndReason> blitCache)
		{
			var result = new MethodBlitResult (true);
			var localResult = new StringBuilder ();
			var types = TypesFromMethod (method);
			foreach (var typeIndex in types) {
				if (!IsTypeBlittable (assembly, typeIndex.Type, localResult, blitCache)) {
					if (result.IsBlittable) {
						result.IsBlittable = false;
						result.Result.Append ($"    The P/Invoke {method.FullName} has been marked as non-blittable for the following reasons:\n");
					}
					if (typeIndex.Index < 0) {
						result.Result.Append ($"        The return type is");
					} else {
						result.Result.Append ($"        Parameter index {typeIndex.Index} is");
					}
					result.Result.Append ($" {typeIndex.Type}: {localResult.ToString ()}\n");
				}
			}
			return result;
		}

		IEnumerable<TypeAndIndex> TypesFromMethod (MethodReference method)
		{
			if (method.ReturnType is not null)
				yield return new TypeAndIndex (method.ReturnType, -1);
			var i = 0;
			foreach (var parameter in method.Parameters)
				yield return new TypeAndIndex (parameter.ParameterType, i++);
		}

		bool IsTypeBlittable (AssemblyDefinition assembly, TypeReference type, StringBuilder result, Dictionary<string, BlitAndReason> blitCache)
		{
			if (blitCache.TryGetValue (type.Name, out var cachedResult)) {
				if (!cachedResult.IsBlittable)
					result.Append ($" {cachedResult.Reason}");
				return cachedResult.IsBlittable;
			}
			if (IsBlittableTypesWeLike (type)) {
				blitCache [type.Name] = new BlitAndReason (true, "");
				return true;
			}
			if (IsBlittablePointer (type)) {
				blitCache [type.Name] = new BlitAndReason (true, "");
				return true;
			}
			var localResult = new StringBuilder ();
			if (IsBlittableValueType (assembly, type, localResult, blitCache)) {
				blitCache [type.Name] = new BlitAndReason (true, "");
				return true;
			}
			result.Append (localResult);
			blitCache [type.Name] = new BlitAndReason (false, result.ToString ());
			return false;
		}


		static HashSet<string> typesWeLike = new HashSet<string> () {
			"System.Void",
			"System.IntPtr",
			"System.UIntPtr",
			"ObjCRuntime.NativeHandle",
			"System.Byte",
			"System.SByte",
			"System.Int16",
			"System.UInt16",
			"System.Int32",
			"System.UInt32",
			"System.Int64",
			"System.UInt64",
			"System.Single",
			"System.Double",
			"System.Runtime.InteropServices.NFloat",
			"System.Runtime.InteropServices.NFloat&",
		};

		bool IsBlittableTypesWeLike (TypeReference t)
		{
			return typesWeLike.Contains (t.ToString ());
		}

		bool IsBlittablePointer (TypeReference type)
		{
			return type.IsPointer || type.IsFunctionPointer;
		}


		bool IsBlittableValueType (AssemblyDefinition assembly, TypeReference type, StringBuilder result, Dictionary<string, BlitAndReason> blitCache)
		{
			TypeDefinition? typeDefinition = type.Resolve ();
			if (typeDefinition is null) {
				result.Append ($" {type.FullName}: Unable to load type.");
				return false;
			}
			if (!typeDefinition.IsValueType) {
				// handy for debugging
				// change the true to false to get more information
				// than you'll probably need about the typeDefinition
				var other = true ? "" : $"IsByReference {typeDefinition.IsByReference} IsPointer {typeDefinition.IsPointer} IsSentinel {typeDefinition.IsSentinel} IsArray {typeDefinition.IsArray} IsGenericParameter {typeDefinition.IsGenericParameter} IsRequiredModifier {typeDefinition.IsRequiredModifier} IsOptionalModifier {typeDefinition.IsOptionalModifier} IsPinned {typeDefinition.IsPinned} IsFunctionPointer {typeDefinition.IsFunctionPointer} IsPrimitive {typeDefinition.IsPrimitive}";
				result.Append ($" {type.Name}: Type is not a value type.\n{other}\n");
				return false;
			}
			if (typeDefinition.IsEnum) {
				return true;
			}
			var allBlittable = true;
			// if we get here then this is a struct. We can presume
			// that a struct will be blittable until we know otherwise
			// this will prevent infinite recursion
			blitCache [type.Name] = new BlitAndReason (true, "");
			var fieldsResult = new StringBuilder ();

			// if we're here, this is a struct
			// a struct is blittable if and only if all the
			// non-static fields are blittable.
			foreach (var f in typeDefinition.Fields) {
				if (f.IsStatic)
					continue;
				var localResult = new StringBuilder ();
				if (!IsTypeBlittable (assembly, f.FieldType, localResult, blitCache)) {
					if (!allBlittable)
						fieldsResult.Append ($" {type.Name}:");
					fieldsResult.Append ($" ({f.Name}: {localResult})");
					allBlittable = false;
				}
			}
			if (!allBlittable) {
				result.Append (fieldsResult);
				blitCache [type.Name] = new BlitAndReason (false, fieldsResult.ToString ());
			}
			return allBlittable;
		}

		IEnumerable<MethodDefinition> AllPInvokes (AssemblyDefinition assembly)
		{
			return assembly.EnumerateMethods (method =>
				(method.Attributes & MethodAttributes.PInvokeImpl) != 0);
		}

		static bool IsPInvokeOK (MethodDefinition method)
		{
			var fullName = method.FullName;
			switch (fullName) {
			case "System.IntPtr ObjCRuntime.Selector::GetHandle(System.String)":
#if !NET8_0_OR_GREATER
			case "System.Boolean CoreFoundation.CFReadStream::CFReadStreamSetClient(System.IntPtr,System.IntPtr,CoreFoundation.CFStream/CFStreamCallback,System.IntPtr)":
			case "System.Boolean CoreFoundation.CFWriteStream::CFWriteStreamSetClient(System.IntPtr,System.IntPtr,CoreFoundation.CFStream/CFStreamCallback,System.IntPtr)":
#endif
				return false;
			default:
				return true;
			}
		}

		[Test]
		public void CheckForBlockLiterals ()
		{
			var failures = new HashSet<(string Message, string Location)> ();

			foreach (var info in Helper.NetPlatformImplementationAssemblyDefinitions) {
				var assembly = info.Assembly;
				foreach (var type in assembly.EnumerateTypes ()) {
					foreach (var method in type.EnumerateMethods (m => m.HasBody)) {
						var body = method.Body;
						foreach (var instr in body.Instructions) {
							switch (instr.OpCode.Code) {
							case Code.Call:
							case Code.Calli:
							case Code.Callvirt:
								break;
							default:
								continue;
							}

							var targetMethod = (MethodReference) instr.Operand;
							if (targetMethod is null) {
								Console.WriteLine ("HUH");
								continue;
							}

							if (!targetMethod.DeclaringType.Is ("ObjCRuntime", "BlockLiteral"))
								continue;

							switch (targetMethod.Name) {
							case "SetupBlock":
							case "SetupBlockUnsafe":
								break;
							default:
								continue;
							}

							var location = method.RenderLocation (instr);
							var message = $"The call to {targetMethod.Name} in {method.AsFullName ()} must be converted to new Block syntax.";
							failures.Add (new (message, location));
						}
					}
				}
			}

			var newFailures = failures.Where (v => !knownFailuresBlockLiterals.Contains (v.Message)).ToArray ();
			var fixedFailures = knownFailuresBlockLiterals.Except (failures.Select (v => v.Message).ToHashSet ());

			var printKnownFailures = newFailures.Any () || fixedFailures.Any ();
			if (printKnownFailures) {
				Console.WriteLine ("Printing all failures as known failures because they seem out of date:");
				Console.WriteLine ("\t\tstatic HashSet<string> knownFailuresBlockLiterals = new HashSet<string> {");
				foreach (var failure in failures.OrderBy (v => v))
					Console.WriteLine ($"\t\t\t\"{failure.Message}\",");
				Console.WriteLine ("\t\t};");
			}

			if (newFailures.Any ()) {
				// Print any new failures with the local path for easy navigation (depending on the terminal and/or IDE you might just click on the path to open the corresponding file).
				Console.WriteLine ($"Printing {newFailures.Count ()} new failures with local paths for easy navigation:");
				foreach (var failure in newFailures.OrderBy (v => v))
					Console.WriteLine ($"    {failure.Location}: {failure.Message}");
			}

			Assert.IsEmpty (newFailures, "Failures");
			Assert.IsEmpty (fixedFailures, "Known failures that aren't failing anymore - remove these from the list of known failures");
		}

		static HashSet<string> knownFailuresBlockLiterals = new HashSet<string> {
			"The call to SetupBlock in ObjCRuntime.BlockLiteral.GetBlockForDelegate(System.Reflection.MethodInfo, System.Object, System.UInt32, System.String) must be converted to new Block syntax.",
			"The call to SetupBlock in ObjCRuntime.BlockLiteral.SetupBlock(System.Delegate, System.Delegate) must be converted to new Block syntax.",
			"The call to SetupBlock in ObjCRuntime.BlockLiteral.SetupBlockUnsafe(System.Delegate, System.Delegate) must be converted to new Block syntax.",
		};

		[Test]
		public void CheckForMonoPInvokeCallback ()
		{
			var failures = new HashSet<(string Message, string Location)> ();

			foreach (var info in Helper.NetPlatformImplementationAssemblyDefinitions) {
				var assembly = info.Assembly;
				foreach (var type in assembly.EnumerateTypes ()) {
					foreach (var method in type.EnumerateMethods (m => m.HasCustomAttributes)) {
						foreach (var ca in method.CustomAttributes) {
							if (ca.AttributeType.Name != "MonoPInvokeCallbackAttribute")
								continue;

							var location = method.RenderLocation ();
							var message = $"The method {method.AsFullName ()} has a MonoPInvokeCallback attribute and must be converted to an UnmanagedCallersOnly method.";
							failures.Add (new (message, location));

							break;
						}
					}
				}
			}

			var newFailures = failures.Where (v => !knownFailuresMonoPInvokeCallback.Contains (v.Message)).ToArray ();
			var fixedFailures = knownFailuresMonoPInvokeCallback.Except (failures.Select (v => v.Message).ToHashSet ());

			if (newFailures.Any ()) {
				// Print any new failures with the local path for easy navigation (depending on the terminal and/or IDE you might just click on the path to open the corresponding file).
				Console.WriteLine ($"Printing {newFailures.Count ()} failures with local path for easy navigation:");
				foreach (var failure in newFailures.OrderBy (v => v))
					Console.WriteLine ($"    {failure.Location}: {failure.Message}");
			}

			Assert.IsEmpty (newFailures, "New Failures");
			Assert.IsEmpty (fixedFailures, "Known failures that aren't failing anymore - remove these from the list of known failures");
		}

		static HashSet<string> knownFailuresMonoPInvokeCallback = new HashSet<string> {
#if !NET8_0_OR_GREATER
			"The method CoreFoundation.CFStream.NativeCallback(System.IntPtr, System.IntPtr, System.IntPtr) has a MonoPInvokeCallback attribute and must be converted to an UnmanagedCallersOnly method.",
#endif
		};
	}
}
