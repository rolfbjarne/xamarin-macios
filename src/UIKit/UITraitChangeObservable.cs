//
// UITraitChangeObservable.cs: support for IUITraitChangeObservable
//
// Authors:
//   Rolf Bjarne Kvinge
//
// Copyright 2023 Microsoft Corp. All rights reserved.
//

#if !__WATCHOS__

using System;
using System.Runtime.InteropServices;

using Foundation;
using ObjCRuntime;

#nullable enable

namespace UIKit {
	public partial interface IUITraitChangeObservable {
		static Class [] ToClasses (params Type [] traits)
		{
			if (traits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traits));
			var traitsClasses = new Class [traits.Length];
			for (var i = 0; i < traits.Length; i++)
				traitsClasses [i] = new Class (traits [i]);
			return traitsClasses;
		}

		public IUITraitChangeRegistration RegisterForTraitChanges (Type [] traits, Action<IUITraitEnvironment, UITraitCollection> handler)
		{
			return RegisterForTraitChanges (ToClasses (traits), handler);
		}

		// Add an override with 'params', unfortunately this means reordering the parameters.
		public unsafe IUITraitChangeRegistration RegisterForTraitChanges (Action<IUITraitEnvironment, UITraitCollection> handler, params Type [] traits)
		{
			return RegisterForTraitChanges (ToClasses (traits), handler);
		}

		public unsafe IUITraitChangeRegistration RegisterForTraitChanges<T> (Action<IUITraitEnvironment, UITraitCollection> handler)
			where T : IUITraitDefinition
		{
			return RegisterForTraitChanges (ToClasses (typeof (T)), handler);
		}

		public unsafe IUITraitChangeRegistration RegisterForTraitChanges<T1, T2> (Action<IUITraitEnvironment, UITraitCollection> handler)
			where T1 : IUITraitDefinition
			where T2 : IUITraitDefinition
		{
			return RegisterForTraitChanges (ToClasses (typeof (T1), typeof (T2)), handler);
		}

		public unsafe IUITraitChangeRegistration RegisterForTraitChanges<T1, T2, T3> (Action<IUITraitEnvironment, UITraitCollection> handler)
			where T1 : IUITraitDefinition
			where T2 : IUITraitDefinition
			where T3 : IUITraitDefinition
		{
			return RegisterForTraitChanges (ToClasses (typeof (T1), typeof (T2), typeof (T3)), handler);
		}

		public unsafe IUITraitChangeRegistration RegisterForTraitChanges<T1, T2, T3, T4> (Action<IUITraitEnvironment, UITraitCollection> handler)
			where T1 : IUITraitDefinition
			where T2 : IUITraitDefinition
			where T3 : IUITraitDefinition
			where T4 : IUITraitDefinition
		{
			return RegisterForTraitChanges (ToClasses (typeof (T1), typeof (T2), typeof (T3), typeof (T4)), handler);
		}

		public IUITraitChangeRegistration RegisterForTraitChanges (Type [] traits, NSObject target, Selector action)
		{
			return RegisterForTraitChanges (ToClasses (traits), target, action);
		}

		public IUITraitChangeRegistration RegisterForTraitChanges (Type [] traits, Selector action)
		{
			return RegisterForTraitChanges (ToClasses (traits), action);
		}

#if !XAMCORE_5_0
		[BindingImpl (BindingImplOptions.Optimizable)]
		public unsafe IUITraitChangeRegistration RegisterForTraitChanges (Class [] traits, [BlockProxy (typeof (ObjCRuntime.Trampolines.IUITraitChangeObservable_RegisterForTraitChanges_NIDAction))] global::System.Action<IUITraitEnvironment, UITraitCollection> handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (traits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traits));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			var nsa_traits = NSArray.FromNSObjects (traits);
			using var block_handler = Trampolines.IUITraitChangeObservable_RegisterForTraitChanges_SDAction.CreateBlock (handler);
			BlockLiteral* block_ptr_handler = &block_handler;
			IUITraitChangeRegistration? ret;
			ret = Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("registerForTraitChanges:withHandler:"), nsa_traits.Handle, (IntPtr) block_ptr_handler), false)!;
			nsa_traits.Dispose ();
			return ret!;
		}

		[BindingImpl (BindingImplOptions.Optimizable)]
		public IUITraitChangeRegistration RegisterForTraitChanges (Class [] traits, NSObject target, Selector action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (traits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traits));
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var nsa_traits = NSArray.FromNSObjects (traits);
			IUITraitChangeRegistration? ret;
			ret = Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("registerForTraitChanges:withTarget:action:"), nsa_traits.Handle, target__handle__, action.Handle), false)!;
			nsa_traits.Dispose ();
			return ret!;
		}

		[BindingImpl (BindingImplOptions.Optimizable)]
		public IUITraitChangeRegistration RegisterForTraitChanges (Class [] traits, Selector action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (traits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traits));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var nsa_traits = NSArray.FromNSObjects (traits);
			IUITraitChangeRegistration? ret;
			ret = Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("registerForTraitChanges:withAction:"), nsa_traits.Handle, action.Handle), false)!;
			nsa_traits.Dispose ();
			return ret!;
		}
#endif // !XAMCORE_5_0
	}
}

#if !XAMCORE_5_0
namespace ObjCRuntime {
	using UIKit;
	static partial class Trampolines {
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::UIKit.IUITraitEnvironment, global::UIKit.UITraitCollection>))]
		unsafe internal delegate void IUITraitChangeObservable_RegisterForTraitChanges_Callback (IntPtr block, NativeHandle arg1, NativeHandle arg2);

		static internal class IUITraitChangeObservable_RegisterForTraitChanges_SDAction {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg1, NativeHandle arg2)
			{
				var del = BlockLiteral.GetTarget<global::System.Action<global::UIKit.IUITraitEnvironment, global::UIKit.UITraitCollection>> (block);
				if (del is not null) {
					del (Runtime.GetINativeObject<UIKit.IUITraitEnvironment> (arg1, false)!, Runtime.GetNSObject<UITraitCollection> (arg2)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action<global::UIKit.IUITraitEnvironment, global::UIKit.UITraitCollection>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action<global::UIKit.IUITraitEnvironment, global::UIKit.UITraitCollection> callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (IUITraitChangeObservable_RegisterForTraitChanges_SDAction), nameof (Invoke));
			}
		}

		internal sealed class IUITraitChangeObservable_RegisterForTraitChanges_NIDAction : TrampolineBlockBase {
			IUITraitChangeObservable_RegisterForTraitChanges_Callback invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe IUITraitChangeObservable_RegisterForTraitChanges_NIDAction (BlockLiteral* block) : base (block)
			{
				invoker = block->GetDelegateForBlock<IUITraitChangeObservable_RegisterForTraitChanges_Callback> ();
			}
			[Preserve (Conditional = true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<global::UIKit.IUITraitEnvironment, global::UIKit.UITraitCollection>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<global::UIKit.IUITraitEnvironment, global::UIKit.UITraitCollection>) GetExistingManagedDelegate (block);
				return del ?? new IUITraitChangeObservable_RegisterForTraitChanges_NIDAction ((BlockLiteral*) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::UIKit.IUITraitEnvironment arg1, global::UIKit.UITraitCollection arg2)
			{
				var arg1__handle__ = arg1.GetHandle ();
				var arg2__handle__ = arg2.GetHandle ();
				invoker (BlockPointer, arg1__handle__, arg2__handle__);
			}
		}
	}
}
#endif // !XAMCORE_5_0

#endif // !__WATCHOS__
