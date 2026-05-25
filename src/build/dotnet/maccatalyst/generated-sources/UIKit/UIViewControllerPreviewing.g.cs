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
	/// <summary>This interface represents the Objective-C protocol <c>UIViewControllerPreviewing</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIViewControllerPreviewing", WrapperType = typeof (UIViewControllerPreviewingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PreviewingGestureRecognizerForFailureRelationship", Selector = "previewingGestureRecognizerForFailureRelationship", PropertyType = typeof (UIGestureRecognizer), GetterSelector = "previewingGestureRecognizerForFailureRelationship", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "WeakDelegate", Selector = "delegate", PropertyType = typeof (NSObject), GetterSelector = "delegate", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SourceView", Selector = "sourceView", PropertyType = typeof (UIView), GetterSelector = "sourceView", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SourceRect", Selector = "sourceRect", PropertyType = typeof (CGRect), GetterSelector = "sourceRect", SetterSelector = "setSourceRect:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIViewControllerPreviewing : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("PreviewingGestureRecognizerForFailureRelationship")]
		[DynamicDependencyAttribute ("SourceRect")]
		[DynamicDependencyAttribute ("SourceView")]
		[DynamicDependencyAttribute ("WeakDelegate")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewControllerPreviewingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIViewControllerPreviewing ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Developers override this method to return a <see cref="T:UIKit.UIGestureRecognizer" /> that can prevent the preview press from interfering with the app's other gesture recognizers.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("tvos13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[global::Foundation.RequiredMember]
		public virtual UIGestureRecognizer PreviewingGestureRecognizerForFailureRelationship {
			[Export ("previewingGestureRecognizerForFailureRelationship")]
			get {
				return _GetPreviewingGestureRecognizerForFailureRelationship (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIGestureRecognizer _GetPreviewingGestureRecognizerForFailureRelationship (IUIViewControllerPreviewing This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIGestureRecognizer ret;
			ret =  Runtime.GetNSObject<UIGestureRecognizer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("previewingGestureRecognizerForFailureRelationship")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>A weak reference to an object that responds to the delegate protocol for this type.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("tvos13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[global::Foundation.RequiredMember]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				return _GetWeakDelegate (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetWeakDelegate (IUIViewControllerPreviewing This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("delegate")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Developers override this method to return the <see cref="T:UIKit.UIView" /> that contains the <see cref="UIKit.IUIViewControllerPreviewing.SourceRect" /> that stays sharp during the previewing press.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("tvos13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[global::Foundation.RequiredMember]
		public virtual UIView SourceView {
			[Export ("sourceView")]
			get {
				return _GetSourceView (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIView _GetSourceView (IUIViewControllerPreviewing This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIView ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("sourceView")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Developers override this method to return the section of their view that stays sharp while the surrounding content blurs.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("tvos13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[global::Foundation.RequiredMember]
		public virtual CGRect SourceRect {
			[Export ("sourceRect")]
			get {
				return _GetSourceRect (this);
			}
			[Export ("setSourceRect:")]
			set {
				_SetSourceRect (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetSourceRect (IUIViewControllerPreviewing This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("sourceRect"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("sourceRect"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSourceRect (IUIViewControllerPreviewing This, CGRect value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (This.Handle, Selector.GetHandle ("setSourceRect:"), value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIViewControllerPreviewingWrapper : BaseWrapper, IUIViewControllerPreviewing {
		public UIViewControllerPreviewingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewControllerPreviewingWrapper))]
		static UIViewControllerPreviewingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Developers override this method to return a <see cref="T:UIKit.UIGestureRecognizer" /> that can prevent the preview press from interfering with the app's other gesture recognizers.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("tvos13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public UIGestureRecognizer PreviewingGestureRecognizerForFailureRelationship {
			[Export ("previewingGestureRecognizerForFailureRelationship")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIGestureRecognizer ret;
				ret =  Runtime.GetNSObject<UIGestureRecognizer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("previewingGestureRecognizerForFailureRelationship")), false)!;
				return ret;
			}
		}
		/// <summary>A weak reference to an object that responds to the delegate protocol for this type.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("tvos13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false)!;
				return ret;
			}
		}
		/// <summary>Developers override this method to return the <see cref="T:UIKit.UIView" /> that contains the <see cref="UIKit.IUIViewControllerPreviewing.SourceRect" /> that stays sharp during the previewing press.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("tvos13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public UIView SourceView {
			[Export ("sourceView")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView ret;
				ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sourceView")), false)!;
				return ret;
			}
		}
		/// <summary>Developers override this method to return the section of their view that stays sharp while the surrounding content blurs.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("tvos13.0", "Replaced by 'UIContextMenuInteraction'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'UIContextMenuInteraction'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public CGRect SourceRect {
			[Export ("sourceRect")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGRect ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("sourceRect"));
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("sourceRect"));
				}
				return ret!;
			}
			[Export ("setSourceRect:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("setSourceRect:"), value);
			}
		}
	}
}
