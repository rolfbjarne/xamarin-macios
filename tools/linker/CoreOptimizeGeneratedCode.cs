// Copyright 2012-2013, 2016 Xamarin Inc. All rights reserved.

using System;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Linker;
using Mono.Tuner;
using Xamarin.Bundler;

namespace Xamarin.Linker {

	public abstract class CoreOptimizeGeneratedCode : ExceptionalSubStep {

		protected override string Name { get; } = "Binding Optimizer";
		protected override int ErrorCode { get; } = 2020;

		protected bool HasGeneratedCode { get; private set; }
		protected bool IsExtensionType { get; private set; }
		protected bool ProcessMethods { get; private set; }

		public override SubStepTargets Targets {
			get { return SubStepTargets.Assembly | SubStepTargets.Type | SubStepTargets.Method; }
		}
		
		public override bool IsActiveFor (AssemblyDefinition assembly)
		{
			// we're sure "pure" SDK assemblies don't use XamMac.dll (i.e. they are the Product assemblies)
			if (Profile.IsSdkAssembly (assembly)) {
#if DEBUG
				Console.WriteLine ("Assembly {0} : skipped (SDK)", assembly);
#endif
				return false;
			}
			
			// process only assemblies where the linker is enabled (e.g. --linksdk, --linkskip) 
			AssemblyAction action = Annotations.GetAction (assembly);
			if (action != AssemblyAction.Link) {
#if DEBUG
				Console.WriteLine ("Assembly {0} : skipped ({1})", assembly, action);
#endif
				return false;
			}
			
			// if the assembly does not refer to [CompilerGeneratedAttribute] then there's not much we can do
			HasGeneratedCode = false;
			foreach (TypeReference tr in assembly.MainModule.GetTypeReferences ()) {
				if (tr.Is ("System.Runtime.CompilerServices", "CompilerGeneratedAttribute")) {
#if DEBUG
					Console.WriteLine ("Assembly {0} : processing", assembly);
#endif
					HasGeneratedCode = true;
					break;
				}
			}
#if DEBUG
			if (!HasGeneratedCode)
				Console.WriteLine ("Assembly {0} : no [CompilerGeneratedAttribute] present (applying basic optimizations)", assembly);
#endif
			// we always apply the step
			return true;
		}

		protected override void Process (TypeDefinition type)
		{
			// if 'type' inherits from NSObject inside an assembly that has [GeneratedCode]
			// or for static types used for optional members (using extensions methods), they can be optimized too
			IsExtensionType = type.IsSealed && type.IsAbstract && type.Name.EndsWith ("_Extensions", StringComparison.Ordinal);
			ProcessMethods = HasGeneratedCode || (!type.IsNSObject (LinkContext) && !IsExtensionType);
		}

		// [GeneratedCode] is not enough - e.g. it's used for anonymous delegates even if the 
		// code itself is not tool/compiler generated
		static protected bool IsExport (ICustomAttributeProvider provider)
		{
			return provider.HasCustomAttribute (Namespaces.Foundation, "ExportAttribute");
		}

		// less risky to nop-ify if branches are pointing to this instruction
		static protected void Nop (Instruction ins)
		{
			ins.OpCode = OpCodes.Nop;
			ins.Operand = null;
		}

		protected static bool ValidateInstruction (MethodDefinition caller, Instruction ins, string operation, Code expected)
		{
			if (ins.OpCode.Code != expected) {
				Driver.Log (1, "Could not {0} in {1} at offset {2}, expected {3} got {4}", operation, caller, ins.Offset, expected, ins);
				return false;
			}

			return true;
		}

		protected static bool ValidateInstruction (MethodDefinition caller, Instruction ins, string operation, params Code [] expected)
		{
			foreach (var code in expected) {
				if (ins.OpCode.Code == code)
					return true;
			}

			Driver.Log (1, "Could not {0} in {1} at offset {2}, expected any of [{3}] got {4}", operation, caller, ins.Offset, string.Join (", ", expected), ins);
			return false;
		}

		static int? GetConstantValue (Instruction ins)
		{
			if (ins == null)
				return null;
			
			switch (ins.OpCode.Code) {
			case Code.Ldc_I4_0:
				return 0;
			case Code.Ldc_I4_1:
				return 1;
			case Code.Ldc_I4_2:
				return 2;
			case Code.Ldc_I4_3:
				return 3;
			case Code.Ldc_I4_4:
				return 4;
			case Code.Ldc_I4_5:
				return 5;
			case Code.Ldc_I4_6:
				return 6;
			case Code.Ldc_I4_7:
				return 7;
			case Code.Ldc_I4_8:
				return 8;
			case Code.Ldc_I4:
			case Code.Ldc_I4_S:
				if (ins.Operand is int)
					return (int) ins.Operand;
				return null;
			case Code.Isinst: // We might be able to calculate a constant value here in the future
			case Code.Ldloc:
			case Code.Ldloca:
			case Code.Ldloc_0:
			case Code.Ldloc_1:
			case Code.Ldloc_2:
			case Code.Ldloc_3:
			case Code.Ldloc_S:
			case Code.Ldloca_S:
			case Code.Ldarg:
			case Code.Ldarg_0:
			case Code.Ldarg_1:
			case Code.Ldarg_2:
			case Code.Ldarg_3:
			case Code.Ldarg_S:
			case Code.Ldarga:
			case Code.Call:
			case Code.Calli:
			case Code.Callvirt:
			case Code.Box:
			case Code.Ldsfld:
				return null; // just to not hit the CWL below
			default:
				Driver.Log (9, "Unknown conditional instruction: {0}", ins);
				return null;
			}
		}

		static bool MarkAliveCode (MethodDefinition method, Mono.Collections.Generic.Collection<Instruction> instructions, bool [] alive, int start, int end)
		{
			for (int i = start; i < end; i++) {
				if (instructions [i].OpCode.Code != Code.Nop)
					alive [i] = true;

				var ins = instructions [i];
				switch (ins.OpCode.FlowControl) {
				case FlowControl.Branch:
					// Unconditional branch, we continue marking the instruction that we branched to.
					var br_target = (Instruction) ins.Operand;
					return MarkAliveCode (method, instructions, alive, instructions.IndexOf (br_target), end);
				case FlowControl.Cond_Branch:
					// Conditional instruction, we need to check if we can calculate a constant value for the condition
					var cond_target = (Instruction) ins.Operand;
					bool? branch = null; // did we get a constant value for the condition, and if so, did we branch or not?
					var cond_instruction_count = 0; // The number of instructions that compose the condition

					// FIXME:
					// This isn't foolproof, we check if the instruction(s) leading up to the conditional branch load a constant
					// value, but it's theoretically possible to branch straight to the branch instruction from somewhere else
					// in the method, bypassing this logic.

					switch (ins.OpCode.Code) {
					case Code.Brtrue:
					case Code.Brtrue_S: {
							var v = GetConstantValue (ins?.Previous);
							if (v.HasValue)
								branch = v.Value != 0;
							cond_instruction_count = 2;
							break;
						}
					case Code.Brfalse:
					case Code.Brfalse_S: {
							var v = GetConstantValue (ins?.Previous);
							if (v.HasValue)
								branch = v.Value == 0;
							cond_instruction_count = 2;
							break;
						}
					case Code.Beq:
					case Code.Beq_S: {
							var x1 = GetConstantValue (ins?.Previous?.Previous);
							var x2 = GetConstantValue (ins?.Previous);
							if (x1.HasValue && x2.HasValue)
								branch = x1.Value == x2.Value;
							cond_instruction_count = 3;
							break;
						}
					case Code.Bne_Un:
					case Code.Bne_Un_S: {
							var x1 = GetConstantValue (ins?.Previous?.Previous);
							var x2 = GetConstantValue (ins?.Previous);
							if (x1.HasValue && x2.HasValue)
								branch = x1.Value != x2.Value;
							cond_instruction_count = 3;
							break;
						}
					case Code.Ble: 
					case Code.Ble_S:
					case Code.Ble_Un:
					case Code.Ble_Un_S: {
							var x1 = GetConstantValue (ins?.Previous?.Previous);
							var x2 = GetConstantValue (ins?.Previous);
							if (x1.HasValue && x2.HasValue)
								branch = x1.Value <= x2.Value;
							cond_instruction_count = 3;
							break;
						}
					case Code.Blt:
					case Code.Blt_S:
					case Code.Blt_Un:
					case Code.Blt_Un_S: {
							var x1 = GetConstantValue (ins?.Previous?.Previous);
							var x2 = GetConstantValue (ins?.Previous);
							if (x1.HasValue && x2.HasValue)
								branch = x1.Value <= x2.Value;
							cond_instruction_count = 3;
							break;
						}
					case Code.Bge:
					case Code.Bge_S:
					case Code.Bge_Un:
					case Code.Bge_Un_S: {
							var x1 = GetConstantValue (ins?.Previous?.Previous);
							var x2 = GetConstantValue (ins?.Previous);
							if (x1.HasValue && x2.HasValue)
								branch = x1.Value >= x2.Value;
							cond_instruction_count = 3;
							break;
						}
					case Code.Bgt:
					case Code.Bgt_S:
					case Code.Bgt_Un:
					case Code.Bgt_Un_S: {
							var x1 = GetConstantValue (ins?.Previous?.Previous);
							var x2 = GetConstantValue (ins?.Previous);
							if (x1.HasValue && x2.HasValue)
								branch = x1.Value > x2.Value;
							cond_instruction_count = 3;
							break;
						}
					default:
						Driver.Log ($"Can't optimize {0} because of unknown branch instruction: {1}", method, ins);
						break;
					}

					if (!branch.HasValue) {
						// not constant, continue marking both this code sequence and the branched sequence
						if (!MarkAliveCode (method, instructions, alive, instructions.IndexOf (cond_target), end))
						    return false;
					} else {
						// we can remove the branch (and the code that loads the condition), so we mark those instructions as dead.
						for (int a = 0; a < cond_instruction_count; a++)
							alive [i - a] = false;

						// Now continue marking according to whether we branched or not
						if (branch.Value) {
							// branch always taken
							return MarkAliveCode (method, instructions, alive, instructions.IndexOf (cond_target), end);
						} else {
							// branch never taken
							// continue looping
						}
					}
					break;
				case FlowControl.Call:
				case FlowControl.Next:
					break;
				case FlowControl.Return:
				case FlowControl.Throw:
					return true;
				case FlowControl.Break:
				case FlowControl.Meta:
				case FlowControl.Phi:
				default:
					Driver.Log (4, "Can't optimize {0} because of unknown flow control for: {1}", method, ins);
					return false;
				}
			}

			return true;
		}

		protected static void EliminateDeadCode (MethodDefinition caller)
		{
			var instructions = caller.Body.Instructions;
			var alive = new bool [instructions.Count];

			if (!MarkAliveCode (caller, instructions, alive, 0, instructions.Count))
				return;

			if (caller.Body.HasExceptionHandlers) {
				foreach (var eh in caller.Body.ExceptionHandlers) {
					switch (eh.HandlerType) {
					case ExceptionHandlerType.Catch:
						// We don't need catch handlers if the protected region does not have alive instructions.
						var startI = instructions.IndexOf (eh.TryStart);
						var endI = instructions.IndexOf (eh.TryEnd);
						var anyAlive = false;
						for (int i = startI; i < endI; i++) {
							if (alive [i]) {
								anyAlive = true;
								break;
							}
						}
						if (anyAlive) {
							if (!MarkAliveCode (caller, instructions, alive, instructions.IndexOf (eh.HandlerStart), instructions.IndexOf (eh.HandlerEnd)))
								return;
						}
						break;
					case ExceptionHandlerType.Finally:
						// finally clauses are always executed, even if the protected region is empty
						if (!MarkAliveCode (caller, instructions, alive, instructions.IndexOf (eh.HandlerStart), instructions.IndexOf (eh.HandlerEnd)))
							return;
						break;
					case ExceptionHandlerType.Fault:
					case ExceptionHandlerType.Filter:
						// FIXME: and until fixed, exit gracefully without doing anything
						Driver.Log (4, "Unhandled exception handler: {0}, skipping dead code elimination for {1}", eh.HandlerType, caller);
						return;
					}
				}
			}

			if (Array.IndexOf (alive, false) == -1)
				return; // entire method is alive

			// Kill branch instructions when there are only dead instructions between the branch instruction and the target instruction
			for (int i = 0; i < instructions.Count; i++) {
				if (!alive [i])
				    continue;
				
				var ins = instructions [i];
				if (ins.OpCode.Code != Code.Br && ins.OpCode.Code != Code.Br_S)
					continue;
				var target = ins.Operand as Instruction;
				if (target == null)
					continue;
				if (target.Offset < ins.Offset)
					continue; // backwards branch, keep those

				var start = i + 1;
				var end = instructions.IndexOf (target);
				var any_alive = false;
				for (int k = start; k < end; k++) {
					if (alive [k]) {
						any_alive = true;
						break;
					}
				}
				if (!any_alive)
					alive [i] = false;
			}

			//Console.WriteLine ($"{caller.FullName}:");
			//for (int i = 0; i < alive.Length; i++) {
			//	Console.WriteLine ($"{(alive [i] ? "   " : "-  ")} {instructions [i]}");
			//	if (!alive [i])
			//		Nop (instructions [i]);
			//}
			//Console.WriteLine ();

			// Exterminate, exterminate, exterminate
			for (int i = 0; i < alive.Length; i++) {
				if (!alive [i])
					Nop (instructions [i]);
			}
		}

	}
}