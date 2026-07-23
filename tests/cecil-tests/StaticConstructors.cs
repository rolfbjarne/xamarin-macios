// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Mono.Cecil;
using Mono.Cecil.Cil;

using NUnit.Framework;

using Xamarin.Tests;
using Xamarin.Utils;

#nullable enable

namespace Cecil.Tests {
	[TestFixture]
	public class StaticConstructors {
		[Test]
		public void VerifyNoMoreStaticConstructors ()
		{
			Configuration.IgnoreIfAnyIgnoredPlatforms ();

			var staticConstructors = new HashSet<string> ();
			foreach (var info in Helper.NetPlatformImplementationAssemblyDefinitions) {
				foreach (var type in info.Assembly.EnumerateTypes ()) {
					if (type.IsBeforeFieldInit)
						continue;

					var cctor = type.Methods.FirstOrDefault (v => v.IsConstructor && v.IsStatic);
					if (cctor is null)
						continue;

					staticConstructors.Add ($"{info.Platform.AsString ()}: {type.FullName} [{GetCategory (type, cctor)}]");
				}
			}

			var knownFailuresPath = Path.Combine (Configuration.SourceRoot, "tests", "cecil-tests", "StaticConstructors.KnownFailures.txt");
			var knownFailures = File.Exists (knownFailuresPath) ? File.ReadAllLines (knownFailuresPath) : [];
			var unknownFailures = staticConstructors.Except (knownFailures).OrderBy (v => v, StringComparer.Ordinal).ToList ();
			var fixedFailures = knownFailures.Except (staticConstructors).OrderBy (v => v, StringComparer.Ordinal).ToList ();

			if (unknownFailures.Count == 0 && fixedFailures.Count == 0)
				return;

			if (!string.IsNullOrEmpty (Environment.GetEnvironmentVariable ("WRITE_KNOWN_FAILURES")))
				File.WriteAllLines (knownFailuresPath, staticConstructors.OrderBy (v => v, StringComparer.Ordinal));

			PrintDifferences ("Types with new static constructors without beforefieldinit", unknownFailures);
			PrintDifferences ("Types that no longer have static constructors without beforefieldinit", fixedFailures);
			Assert.Multiple (() => {
				Assert.That (unknownFailures.Count, Is.Zero, "Number of types with new static constructors without beforefieldinit.");
				Assert.That (fixedFailures.Count, Is.Zero, "Number of types that no longer have static constructors without beforefieldinit; remove them from StaticConstructors.KnownFailures.txt.");
			});
		}

		static void PrintDifferences (string message, List<string> differences)
		{
			if (differences.Count == 0)
				return;

			Console.WriteLine ($"{message} ({differences.Count}, showing at most 10):");
			foreach (var difference in differences.Take (10))
				Console.WriteLine ($"    {difference}");
		}

		static bool IsClassHandleOnlyConstructor (MethodDefinition cctor)
		{
			if (!cctor.HasBody)
				return false;

			var instructions = cctor.Body.Instructions.Where (v => v.OpCode != OpCodes.Nop).ToArray ();
			return instructions.Length == 4 &&
				instructions [0].OpCode == OpCodes.Ldstr &&
				IsCall (instructions [1], "ObjCRuntime", "Class", "GetHandle") &&
				instructions [2].OpCode == OpCodes.Stsfld &&
				instructions [2].Operand is FieldReference field &&
				field.Name == "class_ptr" &&
				instructions [3].OpCode == OpCodes.Ret;
		}

		static bool IsProtocolInterfaceMarker (TypeDefinition type, MethodDefinition cctor)
		{
			if (!cctor.HasBody || !type.IsInterface || !HasAttribute (type, "Foundation", "ProtocolAttribute"))
				return false;

			var instructions = cctor.Body.Instructions.Where (v => v.OpCode != OpCodes.Nop).ToArray ();
			return instructions.Length == 3 &&
				instructions [0].OpCode == OpCodes.Ldnull &&
				IsCall (instructions [1], "System", "GC", "KeepAlive") &&
				instructions [2].OpCode == OpCodes.Ret;
		}

		static string GetCategory (TypeDefinition type, MethodDefinition cctor)
		{
			if (IsClassHandleOnlyConstructor (cctor))
				return "class handle only";

			if (IsProtocolInterfaceMarker (type, cctor))
				return "protocol marker";

			if (!cctor.HasBody)
				return "other";

			var instructions = cctor.Body.Instructions.Where (v => v.OpCode != OpCodes.Nop).ToArray ();
			if (instructions.Length == 3 &&
				instructions [0].OpCode == OpCodes.Ldnull &&
				IsCall (instructions [1], "System", "GC", "KeepAlive") &&
				instructions [2].OpCode == OpCodes.Ret)
				return "linker marker";

			if (IsCompilerCacheInitialization (type, instructions))
				return "compiler cache";

			if (IsSmartEnumInitialization (type, instructions))
				return "smart enum";

			if (IsLibraryHandleInitialization (type, instructions))
				return "library handle";

			if (instructions.All (IsBindingHandleInitialization))
				return "binding handles";

			return "other";
		}

		static bool IsCompilerCacheInitialization (TypeDefinition type, Instruction [] instructions)
		{
			return type.Name.StartsWith ("<>c", StringComparison.Ordinal) &&
				instructions.Length == 3 &&
				instructions [0].OpCode == OpCodes.Newobj &&
				instructions [0].Operand is MethodReference constructor &&
				constructor.Name == ".ctor" &&
				constructor.DeclaringType.Name == type.Name &&
				instructions [1].OpCode == OpCodes.Stsfld &&
				instructions [1].Operand is FieldReference field &&
				field.DeclaringType.Name == type.Name &&
				instructions [2].OpCode == OpCodes.Ret;
		}

		static bool IsSmartEnumInitialization (TypeDefinition type, Instruction [] instructions)
		{
			return type.Name.EndsWith ("Extensions", StringComparison.Ordinal) &&
				instructions.Length == 4 &&
				IsLoadInteger (instructions [0]) &&
				instructions [1].OpCode == OpCodes.Newarr &&
				instructions [2].OpCode == OpCodes.Stsfld &&
				instructions [2].Operand is FieldReference field &&
				field.Name == "values" &&
				instructions [3].OpCode == OpCodes.Ret;
		}

		static bool IsLibraryHandleInitialization (TypeDefinition type, Instruction [] instructions)
		{
			return type.FullName.StartsWith ("ObjCRuntime.Libraries/", StringComparison.Ordinal) &&
				instructions.Length == 5 &&
				instructions [0].OpCode == OpCodes.Ldstr &&
				IsLoadInteger (instructions [1]) &&
				IsCall (instructions [2], "ObjCRuntime", "Dlfcn", "_dlopen") &&
				instructions [3].OpCode == OpCodes.Stsfld &&
				instructions [3].Operand is FieldReference field &&
				field.Name == "Handle" &&
				instructions [4].OpCode == OpCodes.Ret;
		}

		static bool IsLoadInteger (Instruction instruction)
		{
			switch (instruction.OpCode.Code) {
			case Code.Ldc_I4:
			case Code.Ldc_I4_0:
			case Code.Ldc_I4_1:
			case Code.Ldc_I4_2:
			case Code.Ldc_I4_3:
			case Code.Ldc_I4_4:
			case Code.Ldc_I4_5:
			case Code.Ldc_I4_6:
			case Code.Ldc_I4_7:
			case Code.Ldc_I4_8:
			case Code.Ldc_I4_M1:
			case Code.Ldc_I4_S:
				return true;
			default:
				return false;
			}
		}

		static bool IsBindingHandleInitialization (Instruction instruction)
		{
			switch (instruction.OpCode.Code) {
			case Code.Ldstr:
			case Code.Ret:
				return true;
			case Code.Call:
				if (instruction.Operand is not MethodReference calledMethod)
					return false;
				return calledMethod.DeclaringType.Namespace == "ObjCRuntime" && calledMethod.DeclaringType.Name == "Class" && calledMethod.Name == "GetHandle" ||
					calledMethod.DeclaringType.Namespace == "ObjCRuntime" && calledMethod.DeclaringType.Name == "Selector" && calledMethod.Name == "GetHandle" ||
					calledMethod.DeclaringType.Namespace == "ObjCRuntime" && calledMethod.DeclaringType.Name == "NativeHandle" && calledMethod.Name == "op_Implicit";
			case Code.Stsfld:
				if (instruction.Operand is not FieldReference field)
					return false;
				return field.Name == "class_ptr" || field.Name.StartsWith ("sel", StringComparison.Ordinal);
			default:
				return false;
			}
		}

		static bool IsCall (Instruction instruction, string @namespace, string type, string method)
		{
			return instruction.OpCode == OpCodes.Call &&
				instruction.Operand is MethodReference calledMethod &&
				calledMethod.DeclaringType.Namespace == @namespace &&
				calledMethod.DeclaringType.Name == type &&
				calledMethod.Name == method;
		}

		static bool HasAttribute (ICustomAttributeProvider provider, string @namespace, string name)
		{
			return provider.HasCustomAttributes &&
				provider.CustomAttributes.Any (v => v.AttributeType.Namespace == @namespace && v.AttributeType.Name == name);
		}
	}
}
