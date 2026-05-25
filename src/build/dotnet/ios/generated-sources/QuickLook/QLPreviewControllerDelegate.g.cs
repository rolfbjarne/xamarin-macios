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
namespace QuickLook {
	#pragma warning disable CS1573
	/// <summary>A delegate object that gives the application developer fine-grained control over events in the life-cycle of a <see cref="T:QuickLook.QLPreviewController" /> object.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkingInternet/Reference/QLPreviewControllerDelegate_Protocol/index.html">Apple documentation for <c>QLPreviewControllerDelegate</c></related>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "QLPreviewControllerDelegate", WrapperType = typeof (QLPreviewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDismiss", Selector = "previewControllerWillDismiss:", ParameterType = new Type [] { typeof (QLPreviewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismiss", Selector = "previewControllerDidDismiss:", ParameterType = new Type [] { typeof (QLPreviewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldOpenUrl", Selector = "previewController:shouldOpenURL:forPreviewItem:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (QLPreviewController), typeof (NSUrl), typeof (IQLPreviewItem) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FrameForPreviewItem", Selector = "previewController:frameForPreviewItem:inSourceView:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (QLPreviewController), typeof (IQLPreviewItem), typeof (UIView) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TransitionImageForPreviewItem", Selector = "previewController:transitionImageForPreviewItem:contentRect:", ReturnType = typeof (UIImage), ParameterType = new Type [] { typeof (QLPreviewController), typeof (IQLPreviewItem), typeof (CGRect) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TransitionViewForPreviewItem", Selector = "previewController:transitionViewForPreviewItem:", ReturnType = typeof (UIView), ParameterType = new Type [] { typeof (QLPreviewController), typeof (IQLPreviewItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetEditingMode", Selector = "previewController:editingModeForPreviewItem:", ReturnType = typeof (QLPreviewItemEditingMode), ParameterType = new Type [] { typeof (QLPreviewController), typeof (IQLPreviewItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateContents", Selector = "previewController:didUpdateContentsOfPreviewItem:", ParameterType = new Type [] { typeof (QLPreviewController), typeof (IQLPreviewItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSaveEditedCopy", Selector = "previewController:didSaveEditedCopyOfPreviewItem:atURL:", ParameterType = new Type [] { typeof (QLPreviewController), typeof (IQLPreviewItem), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IQLPreviewControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("previewControllerWillDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismiss (QLPreviewController controller)
		{
			_WillDismiss (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDismiss (IQLPreviewControllerDelegate This, QLPreviewController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("previewControllerWillDismiss:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("previewControllerDidDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismiss (QLPreviewController controller)
		{
			_DidDismiss (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDismiss (IQLPreviewControllerDelegate This, QLPreviewController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("previewControllerDidDismiss:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><param name="url">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("previewController:shouldOpenURL:forPreviewItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldOpenUrl (QLPreviewController controller, NSUrl url, IQLPreviewItem item)
		{
			return _ShouldOpenUrl (this, controller, url, item);
		}
		/// <param name="controller">To be added.</param><param name="url">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldOpenUrl (IQLPreviewControllerDelegate This, QLPreviewController controller, NSUrl url, IQLPreviewItem item)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("previewController:shouldOpenURL:forPreviewItem:"), controller__handle__, url__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (url);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="controller">To be added.</param><param name="item">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("previewController:frameForPreviewItem:inSourceView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual CGRect FrameForPreviewItem (QLPreviewController controller, IQLPreviewItem item, ref global::UIKit.UIView view)
		{
			return _FrameForPreviewItem (this, controller, item, ref view);
		}
		/// <param name="controller">To be added.</param><param name="item">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static CGRect _FrameForPreviewItem (IQLPreviewControllerDelegate This, QLPreviewController controller, IQLPreviewItem item, ref global::UIKit.UIView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var viewValue = Runtime.RetainAndAutoreleaseNativeObject (view);
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("previewController:frameForPreviewItem:inSourceView:"), controller__handle__, item__handle__, &viewValue);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("previewController:frameForPreviewItem:inSourceView:"), controller__handle__, item__handle__, &viewValue);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (controller);
			GC.KeepAlive (item);
			view = Runtime.GetNSObject<UIView> (viewValue)!;
			return ret!;
		}
		/// <param name="controller">To be added.</param><param name="item">To be added.</param><param name="contentRect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("previewController:transitionImageForPreviewItem:contentRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImage? TransitionImageForPreviewItem (QLPreviewController controller, IQLPreviewItem item, CGRect contentRect)
		{
			return _TransitionImageForPreviewItem (this, controller, item, contentRect);
		}
		/// <param name="controller">To be added.</param><param name="item">To be added.</param><param name="contentRect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIImage? _TransitionImageForPreviewItem (IQLPreviewControllerDelegate This, QLPreviewController controller, IQLPreviewItem item, CGRect contentRect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::UIKit.UIImage? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("previewController:transitionImageForPreviewItem:contentRect:"), controller__handle__, item__handle__, contentRect), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="controller">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("previewController:transitionViewForPreviewItem:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView? TransitionViewForPreviewItem (QLPreviewController controller, IQLPreviewItem item)
		{
			return _TransitionViewForPreviewItem (this, controller, item);
		}
		/// <param name="controller">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIView? _TransitionViewForPreviewItem (IQLPreviewControllerDelegate This, QLPreviewController controller, IQLPreviewItem item)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::UIKit.UIView? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("previewController:transitionViewForPreviewItem:"), controller__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (item);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("previewController:editingModeForPreviewItem:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual QLPreviewItemEditingMode GetEditingMode (QLPreviewController controller, IQLPreviewItem previewItem)
		{
			return _GetEditingMode (this, controller, previewItem);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static QLPreviewItemEditingMode _GetEditingMode (IQLPreviewControllerDelegate This, QLPreviewController controller, IQLPreviewItem previewItem)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var previewItem__handle__ = previewItem!.GetNonNullHandle (nameof (previewItem));
			QLPreviewItemEditingMode ret;
			ret = (QLPreviewItemEditingMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("previewController:editingModeForPreviewItem:"), controller__handle__, previewItem__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (previewItem);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("previewController:didUpdateContentsOfPreviewItem:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateContents (QLPreviewController controller, IQLPreviewItem previewItem)
		{
			_DidUpdateContents (this, controller, previewItem);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateContents (IQLPreviewControllerDelegate This, QLPreviewController controller, IQLPreviewItem previewItem)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var previewItem__handle__ = previewItem!.GetNonNullHandle (nameof (previewItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("previewController:didUpdateContentsOfPreviewItem:"), controller__handle__, previewItem__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (previewItem);
		}
		[global::Foundation.OptionalMember]
		[Export ("previewController:didSaveEditedCopyOfPreviewItem:atURL:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSaveEditedCopy (QLPreviewController controller, IQLPreviewItem previewItem, NSUrl modifiedContentsUrl)
		{
			_DidSaveEditedCopy (this, controller, previewItem, modifiedContentsUrl);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSaveEditedCopy (IQLPreviewControllerDelegate This, QLPreviewController controller, IQLPreviewItem previewItem, NSUrl modifiedContentsUrl)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var previewItem__handle__ = previewItem!.GetNonNullHandle (nameof (previewItem));
			var modifiedContentsUrl__handle__ = modifiedContentsUrl!.GetNonNullHandle (nameof (modifiedContentsUrl));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("previewController:didSaveEditedCopyOfPreviewItem:atURL:"), controller__handle__, previewItem__handle__, modifiedContentsUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (previewItem);
			GC.KeepAlive (modifiedContentsUrl);
		}
		[DynamicDependencyAttribute ("DidDismiss(QuickLook.QLPreviewController)")]
		[DynamicDependencyAttribute ("DidSaveEditedCopy(QuickLook.QLPreviewController,QuickLook.IQLPreviewItem,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("DidUpdateContents(QuickLook.QLPreviewController,QuickLook.IQLPreviewItem)")]
		[DynamicDependencyAttribute ("FrameForPreviewItem(QuickLook.QLPreviewController,QuickLook.IQLPreviewItem,UIKit.UIView@)")]
		[DynamicDependencyAttribute ("GetEditingMode(QuickLook.QLPreviewController,QuickLook.IQLPreviewItem)")]
		[DynamicDependencyAttribute ("ShouldOpenUrl(QuickLook.QLPreviewController,Foundation.NSUrl,QuickLook.IQLPreviewItem)")]
		[DynamicDependencyAttribute ("TransitionImageForPreviewItem(QuickLook.QLPreviewController,QuickLook.IQLPreviewItem,CoreGraphics.CGRect)")]
		[DynamicDependencyAttribute ("TransitionViewForPreviewItem(QuickLook.QLPreviewController,QuickLook.IQLPreviewItem)")]
		[DynamicDependencyAttribute ("WillDismiss(QuickLook.QLPreviewController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (QLPreviewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IQLPreviewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IQLPreviewControllerDelegate" /> interface to support all the methods from the QLPreviewControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IQLPreviewControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original QLPreviewControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class QLPreviewControllerDelegate_Extensions {
		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDismiss (this IQLPreviewControllerDelegate This, QLPreviewController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("previewControllerWillDismiss:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismiss (this IQLPreviewControllerDelegate This, QLPreviewController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("previewControllerDidDismiss:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><param name="url">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldOpenUrl (this IQLPreviewControllerDelegate This, QLPreviewController controller, NSUrl url, IQLPreviewItem item)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("previewController:shouldOpenURL:forPreviewItem:"), controller__handle__, url__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (url);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="controller">To be added.</param><param name="item">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CGRect FrameForPreviewItem (this IQLPreviewControllerDelegate This, QLPreviewController controller, IQLPreviewItem item, ref global::UIKit.UIView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var viewValue = Runtime.RetainAndAutoreleaseNativeObject (view);
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("previewController:frameForPreviewItem:inSourceView:"), controller__handle__, item__handle__, &viewValue);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("previewController:frameForPreviewItem:inSourceView:"), controller__handle__, item__handle__, &viewValue);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (controller);
			GC.KeepAlive (item);
			view = Runtime.GetNSObject<UIView> (viewValue)!;
			return ret!;
		}
		/// <param name="controller">To be added.</param><param name="item">To be added.</param><param name="contentRect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIImage? TransitionImageForPreviewItem (this IQLPreviewControllerDelegate This, QLPreviewController controller, IQLPreviewItem item, CGRect contentRect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::UIKit.UIImage? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("previewController:transitionImageForPreviewItem:contentRect:"), controller__handle__, item__handle__, contentRect), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="controller">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIView? TransitionViewForPreviewItem (this IQLPreviewControllerDelegate This, QLPreviewController controller, IQLPreviewItem item)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::UIKit.UIView? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("previewController:transitionViewForPreviewItem:"), controller__handle__, item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (item);
			return ret!;
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static QLPreviewItemEditingMode GetEditingMode (this IQLPreviewControllerDelegate This, QLPreviewController controller, IQLPreviewItem previewItem)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var previewItem__handle__ = previewItem!.GetNonNullHandle (nameof (previewItem));
			QLPreviewItemEditingMode ret;
			ret = (QLPreviewItemEditingMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("previewController:editingModeForPreviewItem:"), controller__handle__, previewItem__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (previewItem);
			return ret!;
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateContents (this IQLPreviewControllerDelegate This, QLPreviewController controller, IQLPreviewItem previewItem)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var previewItem__handle__ = previewItem!.GetNonNullHandle (nameof (previewItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("previewController:didUpdateContentsOfPreviewItem:"), controller__handle__, previewItem__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (previewItem);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSaveEditedCopy (this IQLPreviewControllerDelegate This, QLPreviewController controller, IQLPreviewItem previewItem, NSUrl modifiedContentsUrl)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var previewItem__handle__ = previewItem!.GetNonNullHandle (nameof (previewItem));
			var modifiedContentsUrl__handle__ = modifiedContentsUrl!.GetNonNullHandle (nameof (modifiedContentsUrl));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("previewController:didSaveEditedCopyOfPreviewItem:atURL:"), controller__handle__, previewItem__handle__, modifiedContentsUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (previewItem);
			GC.KeepAlive (modifiedContentsUrl);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class QLPreviewControllerDelegateWrapper : BaseWrapper, IQLPreviewControllerDelegate {
		public QLPreviewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (QLPreviewControllerDelegateWrapper))]
		static QLPreviewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace QuickLook {
	/// <summary>A delegate object that gives the application developer fine-grained control over events in the life-cycle of a <see cref="T:QuickLook.QLPreviewController" /> object.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkingInternet/Reference/QLPreviewControllerDelegate_Protocol/index.html">Apple documentation for <c>QLPreviewControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__QuickLook_QLPreviewControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class QLPreviewControllerDelegate : NSObject, IQLPreviewControllerDelegate {
		/// <summary>Creates a new <see cref="QLPreviewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QLPreviewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected QLPreviewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal QLPreviewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("previewControllerDidDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismiss (QLPreviewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("previewController:didSaveEditedCopyOfPreviewItem:atURL:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSaveEditedCopy (QLPreviewController controller, IQLPreviewItem previewItem, NSUrl modifiedContentsUrl)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("previewController:didUpdateContentsOfPreviewItem:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateContents (QLPreviewController controller, IQLPreviewItem previewItem)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="item">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("previewController:frameForPreviewItem:inSourceView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual CGRect FrameForPreviewItem (QLPreviewController controller, IQLPreviewItem item, ref global::UIKit.UIView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("previewController:editingModeForPreviewItem:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual QLPreviewItemEditingMode GetEditingMode (QLPreviewController controller, IQLPreviewItem previewItem)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="url">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("previewController:shouldOpenURL:forPreviewItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldOpenUrl (QLPreviewController controller, NSUrl url, IQLPreviewItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="item">To be added.</param><param name="contentRect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("previewController:transitionImageForPreviewItem:contentRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImage? TransitionImageForPreviewItem (QLPreviewController controller, IQLPreviewItem item, CGRect contentRect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("previewController:transitionViewForPreviewItem:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView? TransitionViewForPreviewItem (QLPreviewController controller, IQLPreviewItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("previewControllerWillDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismiss (QLPreviewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class QLPreviewControllerDelegate */
}
