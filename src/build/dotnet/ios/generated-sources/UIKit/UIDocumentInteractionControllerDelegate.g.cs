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
	/// <summary>A class used to receive notifications from the <see cref="T:UIKit.UIDocumentInteractionController" /> class.</summary><remarks>Application developers can override methods in this class in order to support different types of interaction with files on the device.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIDocumentInteractionControllerDelegate_protocol/index.html">Apple documentation for <c>UIDocumentInteractionControllerDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIDocumentInteractionControllerDelegate", WrapperType = typeof (UIDocumentInteractionControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanPerformAction", Selector = "documentInteractionController:canPerformAction:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIDocumentInteractionController), typeof (Selector) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformAction", Selector = "documentInteractionController:performAction:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIDocumentInteractionController), typeof (Selector) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndSendingToApplication", Selector = "documentInteractionController:didEndSendingToApplication:", ParameterType = new Type [] { typeof (UIDocumentInteractionController), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginSendingToApplication", Selector = "documentInteractionController:willBeginSendingToApplication:", ParameterType = new Type [] { typeof (UIDocumentInteractionController), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismissOpenInMenu", Selector = "documentInteractionControllerDidDismissOpenInMenu:", ParameterType = new Type [] { typeof (UIDocumentInteractionController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismissOptionsMenu", Selector = "documentInteractionControllerDidDismissOptionsMenu:", ParameterType = new Type [] { typeof (UIDocumentInteractionController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndPreview", Selector = "documentInteractionControllerDidEndPreview:", ParameterType = new Type [] { typeof (UIDocumentInteractionController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RectangleForPreview", Selector = "documentInteractionControllerRectForPreview:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (UIDocumentInteractionController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ViewControllerForPreview", Selector = "documentInteractionControllerViewControllerForPreview:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (UIDocumentInteractionController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ViewForPreview", Selector = "documentInteractionControllerViewForPreview:", ReturnType = typeof (UIView), ParameterType = new Type [] { typeof (UIDocumentInteractionController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginPreview", Selector = "documentInteractionControllerWillBeginPreview:", ParameterType = new Type [] { typeof (UIDocumentInteractionController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentOpenInMenu", Selector = "documentInteractionControllerWillPresentOpenInMenu:", ParameterType = new Type [] { typeof (UIDocumentInteractionController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentOptionsMenu", Selector = "documentInteractionControllerWillPresentOptionsMenu:", ParameterType = new Type [] { typeof (UIDocumentInteractionController) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIDocumentInteractionControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="controller">To be added.</param><param name="action"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Developers should not use this deprecated method, which determines whether the specified controller should support the specified action.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentInteractionController:canPerformAction:")]
		[ObsoletedOSPlatform ("ios6.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPerformAction (UIDocumentInteractionController controller, Selector? action)
		{
			return _CanPerformAction (this, controller, action);
		}
		/// <param name="controller">To be added.</param><param name="action"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Developers should not use this deprecated method, which determines whether the specified controller should support the specified action.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios6.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanPerformAction (IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller, Selector? action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var action__handle__ = action.GetHandle ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionController:canPerformAction:"), controller__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (action);
			return ret != 0;
		}
		/// <param name="controller">To be added.</param><param name="action"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Developers should not use this deprecated method. </summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentInteractionController:performAction:")]
		[ObsoletedOSPlatform ("ios6.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PerformAction (UIDocumentInteractionController controller, Selector? action)
		{
			return _PerformAction (this, controller, action);
		}
		/// <param name="controller">To be added.</param><param name="action"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Developers should not use this deprecated method. </summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios6.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _PerformAction (IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller, Selector? action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var action__handle__ = action.GetHandle ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionController:performAction:"), controller__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (action);
			return ret != 0;
		}
		/// <param name="controller">To be added.</param><param name="application"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that the controller's document has been handed off to the specified application.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentInteractionController:didEndSendingToApplication:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndSendingToApplication (UIDocumentInteractionController controller, string? application)
		{
			_DidEndSendingToApplication (this, controller, application);
		}
		/// <param name="controller">To be added.</param><param name="application"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that the controller's document has been handed off to the specified application.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEndSendingToApplication (IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller, string? application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var nsapplication = CFString.CreateNative (application);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionController:didEndSendingToApplication:"), controller__handle__, nsapplication);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			CFString.ReleaseNative (nsapplication);
		}
		/// <param name="controller">To be added.</param><param name="application"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that the controller's document is about to be handed off to the specified application.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentInteractionController:willBeginSendingToApplication:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginSendingToApplication (UIDocumentInteractionController controller, string? application)
		{
			_WillBeginSendingToApplication (this, controller, application);
		}
		/// <param name="controller">To be added.</param><param name="application"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that the controller's document is about to be handed off to the specified application.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillBeginSendingToApplication (IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller, string? application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var nsapplication = CFString.CreateNative (application);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionController:willBeginSendingToApplication:"), controller__handle__, nsapplication);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			CFString.ReleaseNative (nsapplication);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the controller has dismissed its "Open In..." menu.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentInteractionControllerDidDismissOpenInMenu:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissOpenInMenu (UIDocumentInteractionController controller)
		{
			_DidDismissOpenInMenu (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the controller has dismissed its "Open In..." menu.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDismissOpenInMenu (IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerDidDismissOpenInMenu:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the controller has dismissed its "Options" menu.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentInteractionControllerDidDismissOptionsMenu:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissOptionsMenu (UIDocumentInteractionController controller)
		{
			_DidDismissOptionsMenu (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the controller has dismissed its "Options" menu.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDismissOptionsMenu (IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerDidDismissOptionsMenu:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the controller has ended its document preview.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentInteractionControllerDidEndPreview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndPreview (UIDocumentInteractionController controller)
		{
			_DidEndPreview (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the controller has ended its document preview.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEndPreview (IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerDidEndPreview:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>The RectangleF used as the starting point for animating the display of a document preview.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentInteractionControllerRectForPreview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect RectangleForPreview (UIDocumentInteractionController controller)
		{
			return _RectangleForPreview (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>The RectangleF used as the starting point for animating the display of a document preview.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _RectangleForPreview (IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerRectForPreview:"), controller__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerRectForPreview:"), controller__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (controller);
			return ret!;
		}
		/// <param name="controller">To be added.</param><summary>The UIViewController that provides the document preview.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentInteractionControllerViewControllerForPreview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController ViewControllerForPreview (UIDocumentInteractionController controller)
		{
			return _ViewControllerForPreview (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>The UIViewController that provides the document preview.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIViewController _ViewControllerForPreview (IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerViewControllerForPreview:"), controller__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			return ret!;
		}
		/// <param name="controller">To be added.</param><summary>The UIView to use as the starting point for the animation preview. If null, the preview fades into place.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentInteractionControllerViewForPreview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView ViewForPreview (UIDocumentInteractionController controller)
		{
			return _ViewForPreview (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>The UIView to use as the starting point for the animation preview. If null, the preview fades into place.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIView _ViewForPreview (IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			UIView? ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerViewForPreview:"), controller__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			return ret!;
		}
		/// <param name="controller">To be added.</param><summary>Indicates that document preview is about to start.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentInteractionControllerWillBeginPreview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginPreview (UIDocumentInteractionController controller)
		{
			_WillBeginPreview (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that document preview is about to start.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillBeginPreview (IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerWillBeginPreview:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the "Open In..." menu is about to be presented to the app user.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentInteractionControllerWillPresentOpenInMenu:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentOpenInMenu (UIDocumentInteractionController controller)
		{
			_WillPresentOpenInMenu (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the "Open In..." menu is about to be presented to the app user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPresentOpenInMenu (IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerWillPresentOpenInMenu:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the "Options" menu is about to be presented to the app user.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentInteractionControllerWillPresentOptionsMenu:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentOptionsMenu (UIDocumentInteractionController controller)
		{
			_WillPresentOptionsMenu (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the "Options" menu is about to be presented to the app user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPresentOptionsMenu (IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerWillPresentOptionsMenu:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		[DynamicDependencyAttribute ("CanPerformAction(UIKit.UIDocumentInteractionController,ObjCRuntime.Selector)")]
		[DynamicDependencyAttribute ("DidDismissOpenInMenu(UIKit.UIDocumentInteractionController)")]
		[DynamicDependencyAttribute ("DidDismissOptionsMenu(UIKit.UIDocumentInteractionController)")]
		[DynamicDependencyAttribute ("DidEndPreview(UIKit.UIDocumentInteractionController)")]
		[DynamicDependencyAttribute ("DidEndSendingToApplication(UIKit.UIDocumentInteractionController,System.String)")]
		[DynamicDependencyAttribute ("PerformAction(UIKit.UIDocumentInteractionController,ObjCRuntime.Selector)")]
		[DynamicDependencyAttribute ("RectangleForPreview(UIKit.UIDocumentInteractionController)")]
		[DynamicDependencyAttribute ("ViewControllerForPreview(UIKit.UIDocumentInteractionController)")]
		[DynamicDependencyAttribute ("ViewForPreview(UIKit.UIDocumentInteractionController)")]
		[DynamicDependencyAttribute ("WillBeginPreview(UIKit.UIDocumentInteractionController)")]
		[DynamicDependencyAttribute ("WillBeginSendingToApplication(UIKit.UIDocumentInteractionController,System.String)")]
		[DynamicDependencyAttribute ("WillPresentOpenInMenu(UIKit.UIDocumentInteractionController)")]
		[DynamicDependencyAttribute ("WillPresentOptionsMenu(UIKit.UIDocumentInteractionController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDocumentInteractionControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIDocumentInteractionControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIDocumentInteractionControllerDelegate" /> interface to support all the methods from the UIDocumentInteractionControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIDocumentInteractionControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIDocumentInteractionControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIDocumentInteractionControllerDelegate_Extensions {
		/// <param name="controller">To be added.</param><param name="action"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Developers should not use this deprecated method, which determines whether the specified controller should support the specified action.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios6.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanPerformAction (this IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller, Selector? action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var action__handle__ = action.GetHandle ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionController:canPerformAction:"), controller__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (action);
			return ret != 0;
		}
		/// <param name="controller">To be added.</param><param name="action"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Developers should not use this deprecated method. </summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios6.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool PerformAction (this IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller, Selector? action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var action__handle__ = action.GetHandle ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionController:performAction:"), controller__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (action);
			return ret != 0;
		}
		/// <param name="controller">To be added.</param><param name="application"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that the controller's document has been handed off to the specified application.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEndSendingToApplication (this IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller, string? application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var nsapplication = CFString.CreateNative (application);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionController:didEndSendingToApplication:"), controller__handle__, nsapplication);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			CFString.ReleaseNative (nsapplication);
		}
		/// <param name="controller">To be added.</param><param name="application"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that the controller's document is about to be handed off to the specified application.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillBeginSendingToApplication (this IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller, string? application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var nsapplication = CFString.CreateNative (application);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionController:willBeginSendingToApplication:"), controller__handle__, nsapplication);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			CFString.ReleaseNative (nsapplication);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the controller has dismissed its "Open In..." menu.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismissOpenInMenu (this IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerDidDismissOpenInMenu:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the controller has dismissed its "Options" menu.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismissOptionsMenu (this IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerDidDismissOptionsMenu:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the controller has ended its document preview.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEndPreview (this IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerDidEndPreview:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>The RectangleF used as the starting point for animating the display of a document preview.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect RectangleForPreview (this IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerRectForPreview:"), controller__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerRectForPreview:"), controller__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (controller);
			return ret!;
		}
		/// <param name="controller">To be added.</param><summary>The UIViewController that provides the document preview.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIViewController ViewControllerForPreview (this IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerViewControllerForPreview:"), controller__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			return ret!;
		}
		/// <param name="controller">To be added.</param><summary>The UIView to use as the starting point for the animation preview. If null, the preview fades into place.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIView ViewForPreview (this IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			UIView? ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerViewForPreview:"), controller__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			return ret!;
		}
		/// <param name="controller">To be added.</param><summary>Indicates that document preview is about to start.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillBeginPreview (this IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerWillBeginPreview:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the "Open In..." menu is about to be presented to the app user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresentOpenInMenu (this IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerWillPresentOpenInMenu:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the "Options" menu is about to be presented to the app user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresentOptionsMenu (this IUIDocumentInteractionControllerDelegate This, UIDocumentInteractionController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentInteractionControllerWillPresentOptionsMenu:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIDocumentInteractionControllerDelegateWrapper : BaseWrapper, IUIDocumentInteractionControllerDelegate {
		public UIDocumentInteractionControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDocumentInteractionControllerDelegateWrapper))]
		static UIDocumentInteractionControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>A class used to receive notifications from the <see cref="T:UIKit.UIDocumentInteractionController" /> class.</summary><remarks>Application developers can override methods in this class in order to support different types of interaction with files on the device.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIDocumentInteractionControllerDelegate_protocol/index.html">Apple documentation for <c>UIDocumentInteractionControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UIDocumentInteractionControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIDocumentInteractionControllerDelegate : NSObject, IUIDocumentInteractionControllerDelegate {
		/// <summary>Creates a new <see cref="UIDocumentInteractionControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIDocumentInteractionControllerDelegate () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
			}
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected UIDocumentInteractionControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal UIDocumentInteractionControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="controller">To be added.</param><param name="action"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Developers should not use this deprecated method, which determines whether the specified controller should support the specified action.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("documentInteractionController:canPerformAction:")]
		[ObsoletedOSPlatform ("ios6.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPerformAction (UIDocumentInteractionController controller, Selector? action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the controller has dismissed its "Open In..." menu.</summary><remarks>To be added.</remarks>
		[Export ("documentInteractionControllerDidDismissOpenInMenu:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissOpenInMenu (UIDocumentInteractionController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the controller has dismissed its "Options" menu.</summary><remarks>To be added.</remarks>
		[Export ("documentInteractionControllerDidDismissOptionsMenu:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissOptionsMenu (UIDocumentInteractionController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the controller has ended its document preview.</summary><remarks>To be added.</remarks>
		[Export ("documentInteractionControllerDidEndPreview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndPreview (UIDocumentInteractionController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="application"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that the controller's document has been handed off to the specified application.</summary><remarks>To be added.</remarks>
		[Export ("documentInteractionController:didEndSendingToApplication:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndSendingToApplication (UIDocumentInteractionController controller, string? application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="action"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Developers should not use this deprecated method. </summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("documentInteractionController:performAction:")]
		[ObsoletedOSPlatform ("ios6.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PerformAction (UIDocumentInteractionController controller, Selector? action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>The RectangleF used as the starting point for animating the display of a document preview.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("documentInteractionControllerRectForPreview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect RectangleForPreview (UIDocumentInteractionController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>The UIViewController that provides the document preview.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("documentInteractionControllerViewControllerForPreview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController ViewControllerForPreview (UIDocumentInteractionController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>The UIView to use as the starting point for the animation preview. If null, the preview fades into place.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("documentInteractionControllerViewForPreview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView ViewForPreview (UIDocumentInteractionController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>Indicates that document preview is about to start.</summary><remarks>To be added.</remarks>
		[Export ("documentInteractionControllerWillBeginPreview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginPreview (UIDocumentInteractionController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="application"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that the controller's document is about to be handed off to the specified application.</summary><remarks>To be added.</remarks>
		[Export ("documentInteractionController:willBeginSendingToApplication:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginSendingToApplication (UIDocumentInteractionController controller, string? application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the "Open In..." menu is about to be presented to the app user.</summary><remarks>To be added.</remarks>
		[Export ("documentInteractionControllerWillPresentOpenInMenu:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentOpenInMenu (UIDocumentInteractionController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>Indicates that the "Options" menu is about to be presented to the app user.</summary><remarks>To be added.</remarks>
		[Export ("documentInteractionControllerWillPresentOptionsMenu:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentOptionsMenu (UIDocumentInteractionController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIDocumentInteractionControllerDelegate */
}
