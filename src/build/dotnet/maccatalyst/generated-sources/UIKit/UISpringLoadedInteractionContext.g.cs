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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>Contains information about spring-loaded interaction behavior.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UISpringLoadedInteractionContext", WrapperType = typeof (UISpringLoadedInteractionContextWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LocationInView", Selector = "locationInView:", ReturnType = typeof (CGPoint), ParameterType = new Type [] { typeof (UIView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "State", Selector = "state", PropertyType = typeof (UISpringLoadedInteractionEffectState), GetterSelector = "state", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TargetView", Selector = "targetView", PropertyType = typeof (UIView), GetterSelector = "targetView", SetterSelector = "setTargetView:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TargetItem", Selector = "targetItem", PropertyType = typeof (NSObject), GetterSelector = "targetItem", SetterSelector = "setTargetItem:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IUISpringLoadedInteractionContext : INativeObject, IDisposable
	{
		/// <param name="view">The view whose coordinate system to use.</param><summary>Method that is called to get the location of the drag activity in the <paramref name="view" /> coordinate system.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("locationInView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint LocationInView (UIView? view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="view">The view whose coordinate system to use.</param><summary>Method that is called to get the location of the drag activity in the <paramref name="view" /> coordinate system.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _LocationInView (IUISpringLoadedInteractionContext This, UIView? view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view.GetHandle ();
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("locationInView:"), view__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			return ret!;
		}
		[DynamicDependencyAttribute ("LocationInView(UIKit.UIView)")]
		[DynamicDependencyAttribute ("State")]
		[DynamicDependencyAttribute ("TargetItem")]
		[DynamicDependencyAttribute ("TargetView")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISpringLoadedInteractionContextWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUISpringLoadedInteractionContext ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the current state of the spring-loaded interaction.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UISpringLoadedInteractionEffectState State {
			[Export ("state")]
			get {
				return _GetState (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UISpringLoadedInteractionEffectState _GetState (IUISpringLoadedInteractionContext This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UISpringLoadedInteractionEffectState ret;
			ret = (UISpringLoadedInteractionEffectState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("state"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Gets or sets the target view to which the spring-loaded interaction is being applied.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIView? TargetView {
			[Export ("targetView", ArgumentSemantic.Retain)]
			get {
				return _GetTargetView (this);
			}
			[Export ("setTargetView:", ArgumentSemantic.Retain)]
			set {
				_SetTargetView (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIView _GetTargetView (IUISpringLoadedInteractionContext This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIView ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("targetView")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTargetView (IUISpringLoadedInteractionContext This, UIView? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setTargetView:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Gets or sets the target item of the spring-loaded interaction.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? TargetItem {
			[Export ("targetItem", ArgumentSemantic.Retain)]
			get {
				return _GetTargetItem (this);
			}
			[Export ("setTargetItem:", ArgumentSemantic.Retain)]
			set {
				_SetTargetItem (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetTargetItem (IUISpringLoadedInteractionContext This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("targetItem")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTargetItem (IUISpringLoadedInteractionContext This, NSObject? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setTargetItem:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UISpringLoadedInteractionContextWrapper : BaseWrapper, IUISpringLoadedInteractionContext {
		public UISpringLoadedInteractionContextWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISpringLoadedInteractionContextWrapper))]
		static UISpringLoadedInteractionContextWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="view">The view whose coordinate system to use.</param><summary>Method that is called to get the location of the drag activity in the <paramref name="view" /> coordinate system.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("locationInView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint LocationInView (UIView? view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view.GetHandle ();
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("locationInView:"), view__handle__);
			GC.KeepAlive (view);
			return ret!;
		}
		/// <summary>Gets the current state of the spring-loaded interaction.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UISpringLoadedInteractionEffectState State {
			[Export ("state")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UISpringLoadedInteractionEffectState ret;
				ret = (UISpringLoadedInteractionEffectState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
				return ret!;
			}
		}
		/// <summary>Gets or sets the target view to which the spring-loaded interaction is being applied.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIView? TargetView {
			[Export ("targetView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView ret;
				ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("targetView")), false)!;
				return ret;
			}
			[Export ("setTargetView:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTargetView:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets the target item of the spring-loaded interaction.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? TargetItem {
			[Export ("targetItem", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("targetItem")), false)!;
				return ret;
			}
			[Export ("setTargetItem:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTargetItem:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
	}
}
