//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UITraitChangeObservable</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[Protocol (Name = "UITraitChangeObservable", WrapperType = typeof (UITraitChangeObservableWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RegisterForTraitChanges", Selector = "registerForTraitChanges:withHandler:", ReturnType = typeof (IUITraitChangeRegistration), ParameterType = new Type [] { typeof (Class[]), typeof (global::System.Action<global::UIKit.IUITraitEnvironment, global::UIKit.UITraitCollection>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V100) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RegisterForTraitChanges", Selector = "registerForTraitChanges:withTarget:action:", ReturnType = typeof (IUITraitChangeRegistration), ParameterType = new Type [] { typeof (Class[]), typeof (NSObject), typeof (Selector) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RegisterForTraitChanges", Selector = "registerForTraitChanges:withAction:", ReturnType = typeof (IUITraitChangeRegistration), ParameterType = new Type [] { typeof (Class[]), typeof (Selector) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UnregisterForTraitChanges", Selector = "unregisterForTraitChanges:", ParameterType = new Type [] { typeof (IUITraitChangeRegistration) }, ParameterByRef = new bool [] { false })]
	public partial interface IUITraitChangeObservable : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("registerForTraitChanges:withHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IUITraitChangeRegistration RegisterForTraitChanges (Class[] traits, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V100))]global::System.Action<IUITraitEnvironment, UITraitCollection> handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IUITraitChangeRegistration _RegisterForTraitChanges (IUITraitChangeObservable This, Class[] traits, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V100))]global::System.Action<IUITraitEnvironment, UITraitCollection> handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (traits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traits));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var nsa_traits = NSArray.FromNSObjects (traits);
			using var block_handler = Trampolines.SDActionArity2V100.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			IUITraitChangeRegistration ret;
			ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("registerForTraitChanges:withHandler:"), nsa_traits.Handle, (IntPtr) block_ptr_handler), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("registerForTraitChanges:withTarget:action:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUITraitChangeRegistration RegisterForTraitChanges (Class[] traits, NSObject target, Selector action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUITraitChangeRegistration _RegisterForTraitChanges (IUITraitChangeObservable This, Class[] traits, NSObject target, Selector action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (traits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traits));
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			using var nsa_traits = NSArray.FromNSObjects (traits);
			IUITraitChangeRegistration? ret;
			ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("registerForTraitChanges:withTarget:action:"), nsa_traits.Handle, target__handle__, action.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (target);
			GC.KeepAlive (action);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("registerForTraitChanges:withAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUITraitChangeRegistration RegisterForTraitChanges (Class[] traits, Selector action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUITraitChangeRegistration _RegisterForTraitChanges (IUITraitChangeObservable This, Class[] traits, Selector action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (traits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traits));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			using var nsa_traits = NSArray.FromNSObjects (traits);
			IUITraitChangeRegistration? ret;
			ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("registerForTraitChanges:withAction:"), nsa_traits.Handle, action.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (action);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("unregisterForTraitChanges:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnregisterForTraitChanges (IUITraitChangeRegistration registration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UnregisterForTraitChanges (IUITraitChangeObservable This, IUITraitChangeRegistration registration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var registration__handle__ = registration!.GetNonNullHandle (nameof (registration));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("unregisterForTraitChanges:"), registration__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (registration);
		}
		[DynamicDependencyAttribute ("RegisterForTraitChanges(ObjCRuntime.Class[],Foundation.NSObject,ObjCRuntime.Selector)")]
		[DynamicDependencyAttribute ("RegisterForTraitChanges(ObjCRuntime.Class[],ObjCRuntime.Selector)")]
		[DynamicDependencyAttribute ("RegisterForTraitChanges(ObjCRuntime.Class[],System.Action{UIKit.IUITraitEnvironment,UIKit.UITraitCollection})")]
		[DynamicDependencyAttribute ("UnregisterForTraitChanges(UIKit.IUITraitChangeRegistration)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITraitChangeObservableWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITraitChangeObservable ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUITraitChangeObservable" /> interface to support all the methods from the UITraitChangeObservable protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUITraitChangeObservable" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UITraitChangeObservable protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UITraitChangeObservable_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static IUITraitChangeRegistration RegisterForTraitChanges (this IUITraitChangeObservable This, Class[] traits, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V100))]global::System.Action<IUITraitEnvironment, UITraitCollection> handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (traits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traits));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var nsa_traits = NSArray.FromNSObjects (traits);
			using var block_handler = Trampolines.SDActionArity2V100.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			IUITraitChangeRegistration ret;
			ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("registerForTraitChanges:withHandler:"), nsa_traits.Handle, (IntPtr) block_ptr_handler), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IUITraitChangeRegistration RegisterForTraitChanges (this IUITraitChangeObservable This, Class[] traits, NSObject target, Selector action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (traits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traits));
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			using var nsa_traits = NSArray.FromNSObjects (traits);
			IUITraitChangeRegistration? ret;
			ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("registerForTraitChanges:withTarget:action:"), nsa_traits.Handle, target__handle__, action.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (target);
			GC.KeepAlive (action);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IUITraitChangeRegistration RegisterForTraitChanges (this IUITraitChangeObservable This, Class[] traits, Selector action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (traits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traits));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			using var nsa_traits = NSArray.FromNSObjects (traits);
			IUITraitChangeRegistration? ret;
			ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("registerForTraitChanges:withAction:"), nsa_traits.Handle, action.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (action);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITraitChangeObservableWrapper : BaseWrapper, IUITraitChangeObservable {
		public UITraitChangeObservableWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITraitChangeObservableWrapper))]
		static UITraitChangeObservableWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("registerForTraitChanges:withHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IUITraitChangeRegistration RegisterForTraitChanges (Class[] traits, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V100))]global::System.Action<IUITraitEnvironment, UITraitCollection> handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (traits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traits));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var nsa_traits = NSArray.FromNSObjects (traits);
			using var block_handler = Trampolines.SDActionArity2V100.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			IUITraitChangeRegistration ret;
			ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("registerForTraitChanges:withHandler:"), nsa_traits.Handle, (IntPtr) block_ptr_handler), false)!;
			return ret;
		}
		[Export ("registerForTraitChanges:withTarget:action:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUITraitChangeRegistration RegisterForTraitChanges (Class[] traits, NSObject target, Selector action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (traits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traits));
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			using var nsa_traits = NSArray.FromNSObjects (traits);
			IUITraitChangeRegistration? ret;
			ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("registerForTraitChanges:withTarget:action:"), nsa_traits.Handle, target__handle__, action.Handle), false)!;
			GC.KeepAlive (target);
			GC.KeepAlive (action);
			return ret!;
		}
		[Export ("registerForTraitChanges:withAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUITraitChangeRegistration RegisterForTraitChanges (Class[] traits, Selector action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (traits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traits));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			using var nsa_traits = NSArray.FromNSObjects (traits);
			IUITraitChangeRegistration? ret;
			ret =  Runtime.GetINativeObject<IUITraitChangeRegistration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("registerForTraitChanges:withAction:"), nsa_traits.Handle, action.Handle), false)!;
			GC.KeepAlive (action);
			return ret!;
		}
		[Export ("unregisterForTraitChanges:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UnregisterForTraitChanges (IUITraitChangeRegistration registration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var registration__handle__ = registration!.GetNonNullHandle (nameof (registration));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("unregisterForTraitChanges:"), registration__handle__);
			GC.KeepAlive (registration);
		}
	}
}
