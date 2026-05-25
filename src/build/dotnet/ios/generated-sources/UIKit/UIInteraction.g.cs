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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>Interface for adding drag-and-drop and spring-loaded operations.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIInteraction", WrapperType = typeof (UIInteractionWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WillMoveToView", Selector = "willMoveToView:", ParameterType = new Type [] { typeof (UIView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidMoveToView", Selector = "didMoveToView:", ParameterType = new Type [] { typeof (UIView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "View", Selector = "view", PropertyType = typeof (UIView), GetterSelector = "view", ArgumentSemantic = ArgumentSemantic.Weak)]
	public partial interface IUIInteraction : INativeObject, IDisposable
	{
		/// <param name="view">The view that will contain the interaction.</param><summary>Method that is called just before the interaction is added to the provided <paramref name="view" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("willMoveToView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillMoveToView (UIView? view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="view">The view that will contain the interaction.</param><summary>Method that is called just before the interaction is added to the provided <paramref name="view" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillMoveToView (IUIInteraction This, UIView? view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("willMoveToView:"), view__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
		}
		/// <param name="view">The view that now contains the interaction.</param><summary>Method that is called after the interaction is added to the provided <paramref name="view" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("didMoveToView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidMoveToView (UIView? view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="view">The view that now contains the interaction.</param><summary>Method that is called after the interaction is added to the provided <paramref name="view" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidMoveToView (IUIInteraction This, UIView? view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didMoveToView:"), view__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
		}
		[DynamicDependencyAttribute ("DidMoveToView(UIKit.UIView)")]
		[DynamicDependencyAttribute ("View")]
		[DynamicDependencyAttribute ("WillMoveToView(UIKit.UIView)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIInteractionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIInteraction ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the view that owns the interaction.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIView View {
			[Export ("view", ArgumentSemantic.Weak)]
			get {
				return _GetView (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIView _GetView (IUIInteraction This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIView ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("view")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIInteractionWrapper : BaseWrapper, IUIInteraction {
		public UIInteractionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIInteractionWrapper))]
		static UIInteractionWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="view">The view that will contain the interaction.</param><summary>Method that is called just before the interaction is added to the provided <paramref name="view" />.</summary><remarks>To be added.</remarks>
		[Export ("willMoveToView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WillMoveToView (UIView? view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("willMoveToView:"), view__handle__);
			GC.KeepAlive (view);
		}
		/// <param name="view">The view that now contains the interaction.</param><summary>Method that is called after the interaction is added to the provided <paramref name="view" />.</summary><remarks>To be added.</remarks>
		[Export ("didMoveToView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidMoveToView (UIView? view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didMoveToView:"), view__handle__);
			GC.KeepAlive (view);
		}
		/// <summary>Gets the view that owns the interaction.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIView View {
			[Export ("view", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView ret;
				ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("view")), false)!;
				return ret;
			}
		}
	}
}
