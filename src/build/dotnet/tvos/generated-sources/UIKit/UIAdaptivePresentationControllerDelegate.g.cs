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
	/// <summary>This interface represents the Objective-C protocol <c>UIAdaptivePresentationControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIAdaptivePresentationControllerDelegate", WrapperType = typeof (UIAdaptivePresentationControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAdaptivePresentationStyle", Selector = "adaptivePresentationStyleForPresentationController:", ReturnType = typeof (UIModalPresentationStyle), ParameterType = new Type [] { typeof (UIPresentationController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetViewControllerForAdaptivePresentation", Selector = "presentationController:viewControllerForAdaptivePresentationStyle:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (UIPresentationController), typeof (UIModalPresentationStyle) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAdaptivePresentationStyle", Selector = "adaptivePresentationStyleForPresentationController:traitCollection:", ReturnType = typeof (UIModalPresentationStyle), ParameterType = new Type [] { typeof (UIPresentationController), typeof (UITraitCollection) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PrepareAdaptivePresentationController", Selector = "presentationController:prepareAdaptivePresentationController:", ParameterType = new Type [] { typeof (UIPresentationController), typeof (UIPresentationController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresent", Selector = "presentationController:willPresentWithAdaptiveStyle:transitionCoordinator:", ParameterType = new Type [] { typeof (UIPresentationController), typeof (UIModalPresentationStyle), typeof (IUIViewControllerTransitionCoordinator) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldDismiss", Selector = "presentationControllerShouldDismiss:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIPresentationController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDismiss", Selector = "presentationControllerWillDismiss:", ParameterType = new Type [] { typeof (UIPresentationController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismiss", Selector = "presentationControllerDidDismiss:", ParameterType = new Type [] { typeof (UIPresentationController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAttemptToDismiss", Selector = "presentationControllerDidAttemptToDismiss:", ParameterType = new Type [] { typeof (UIPresentationController) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIAdaptivePresentationControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="forPresentationController">To be added.</param><summary>Returns the new presentation style to use after a change to the <paramref name="forPresentationController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("adaptivePresentationStyleForPresentationController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIModalPresentationStyle GetAdaptivePresentationStyle (UIPresentationController forPresentationController)
		{
			return _GetAdaptivePresentationStyle (this, forPresentationController);
		}
		/// <param name="forPresentationController">To be added.</param><summary>Returns the new presentation style to use after a change to the <paramref name="forPresentationController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIModalPresentationStyle _GetAdaptivePresentationStyle (IUIAdaptivePresentationControllerDelegate This, UIPresentationController forPresentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var forPresentationController__handle__ = forPresentationController!.GetNonNullHandle (nameof (forPresentationController));
			UIModalPresentationStyle ret;
			ret = (UIModalPresentationStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("adaptivePresentationStyleForPresentationController:"), forPresentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (forPresentationController);
			return ret!;
		}
		/// <param name="controller">To be added.</param><param name="style">To be added.</param><summary>The view controller to use for the specified <paramref name="style" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("presentationController:viewControllerForAdaptivePresentationStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetViewControllerForAdaptivePresentation (UIPresentationController controller, UIModalPresentationStyle style)
		{
			return _GetViewControllerForAdaptivePresentation (this, controller, style);
		}
		/// <param name="controller">To be added.</param><param name="style">To be added.</param><summary>The view controller to use for the specified <paramref name="style" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIViewController _GetViewControllerForAdaptivePresentation (IUIAdaptivePresentationControllerDelegate This, UIPresentationController controller, UIModalPresentationStyle style)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("presentationController:viewControllerForAdaptivePresentationStyle:"), controller__handle__, (IntPtr) (long) style), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			return ret!;
		}
		/// <param name="controller">To be added.</param><param name="traitCollection">To be added.</param><summary>The presentation style to use for the specified <paramref name="controller" /> and <paramref name="traitCollection" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("adaptivePresentationStyleForPresentationController:traitCollection:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIModalPresentationStyle GetAdaptivePresentationStyle (UIPresentationController controller, UITraitCollection traitCollection)
		{
			return _GetAdaptivePresentationStyle (this, controller, traitCollection);
		}
		/// <param name="controller">To be added.</param><param name="traitCollection">To be added.</param><summary>The presentation style to use for the specified <paramref name="controller" /> and <paramref name="traitCollection" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIModalPresentationStyle _GetAdaptivePresentationStyle (IUIAdaptivePresentationControllerDelegate This, UIPresentationController controller, UITraitCollection traitCollection)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var traitCollection__handle__ = traitCollection!.GetNonNullHandle (nameof (traitCollection));
			UIModalPresentationStyle ret;
			ret = (UIModalPresentationStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("adaptivePresentationStyleForPresentationController:traitCollection:"), controller__handle__, traitCollection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (traitCollection);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("presentationController:prepareAdaptivePresentationController:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareAdaptivePresentationController (UIPresentationController presentationController, UIPresentationController adaptivePresentationController)
		{
			_PrepareAdaptivePresentationController (this, presentationController, adaptivePresentationController);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PrepareAdaptivePresentationController (IUIAdaptivePresentationControllerDelegate This, UIPresentationController presentationController, UIPresentationController adaptivePresentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var presentationController__handle__ = presentationController!.GetNonNullHandle (nameof (presentationController));
			var adaptivePresentationController__handle__ = adaptivePresentationController!.GetNonNullHandle (nameof (adaptivePresentationController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("presentationController:prepareAdaptivePresentationController:"), presentationController__handle__, adaptivePresentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (presentationController);
			GC.KeepAlive (adaptivePresentationController);
		}
		/// <param name="presentationController">To be added.</param><param name="style">To be added.</param><param name="transitionCoordinator">To be added.</param><summary>Called prior to presentation.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("presentationController:willPresentWithAdaptiveStyle:transitionCoordinator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresent (UIPresentationController presentationController, UIModalPresentationStyle style, IUIViewControllerTransitionCoordinator? transitionCoordinator)
		{
			_WillPresent (this, presentationController, style, transitionCoordinator);
		}
		/// <param name="presentationController">To be added.</param><param name="style">To be added.</param><param name="transitionCoordinator">To be added.</param><summary>Called prior to presentation.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPresent (IUIAdaptivePresentationControllerDelegate This, UIPresentationController presentationController, UIModalPresentationStyle style, IUIViewControllerTransitionCoordinator? transitionCoordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var presentationController__handle__ = presentationController!.GetNonNullHandle (nameof (presentationController));
			var transitionCoordinator__handle__ = transitionCoordinator.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("presentationController:willPresentWithAdaptiveStyle:transitionCoordinator:"), presentationController__handle__, (IntPtr) (long) style, transitionCoordinator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (presentationController);
			GC.KeepAlive (transitionCoordinator);
		}
		[global::Foundation.OptionalMember]
		[Export ("presentationControllerShouldDismiss:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDismiss (UIPresentationController presentationController)
		{
			return _ShouldDismiss (this, presentationController);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldDismiss (IUIAdaptivePresentationControllerDelegate This, UIPresentationController presentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var presentationController__handle__ = presentationController!.GetNonNullHandle (nameof (presentationController));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentationControllerShouldDismiss:"), presentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (presentationController);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("presentationControllerWillDismiss:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismiss (UIPresentationController presentationController)
		{
			_WillDismiss (this, presentationController);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDismiss (IUIAdaptivePresentationControllerDelegate This, UIPresentationController presentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var presentationController__handle__ = presentationController!.GetNonNullHandle (nameof (presentationController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentationControllerWillDismiss:"), presentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (presentationController);
		}
		[global::Foundation.OptionalMember]
		[Export ("presentationControllerDidDismiss:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismiss (UIPresentationController presentationController)
		{
			_DidDismiss (this, presentationController);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDismiss (IUIAdaptivePresentationControllerDelegate This, UIPresentationController presentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var presentationController__handle__ = presentationController!.GetNonNullHandle (nameof (presentationController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentationControllerDidDismiss:"), presentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (presentationController);
		}
		[global::Foundation.OptionalMember]
		[Export ("presentationControllerDidAttemptToDismiss:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAttemptToDismiss (UIPresentationController presentationController)
		{
			_DidAttemptToDismiss (this, presentationController);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAttemptToDismiss (IUIAdaptivePresentationControllerDelegate This, UIPresentationController presentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var presentationController__handle__ = presentationController!.GetNonNullHandle (nameof (presentationController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentationControllerDidAttemptToDismiss:"), presentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (presentationController);
		}
		[DynamicDependencyAttribute ("DidAttemptToDismiss(UIKit.UIPresentationController)")]
		[DynamicDependencyAttribute ("DidDismiss(UIKit.UIPresentationController)")]
		[DynamicDependencyAttribute ("GetAdaptivePresentationStyle(UIKit.UIPresentationController,UIKit.UITraitCollection)")]
		[DynamicDependencyAttribute ("GetAdaptivePresentationStyle(UIKit.UIPresentationController)")]
		[DynamicDependencyAttribute ("GetViewControllerForAdaptivePresentation(UIKit.UIPresentationController,UIKit.UIModalPresentationStyle)")]
		[DynamicDependencyAttribute ("PrepareAdaptivePresentationController(UIKit.UIPresentationController,UIKit.UIPresentationController)")]
		[DynamicDependencyAttribute ("ShouldDismiss(UIKit.UIPresentationController)")]
		[DynamicDependencyAttribute ("WillDismiss(UIKit.UIPresentationController)")]
		[DynamicDependencyAttribute ("WillPresent(UIKit.UIPresentationController,UIKit.UIModalPresentationStyle,UIKit.IUIViewControllerTransitionCoordinator)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIAdaptivePresentationControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIAdaptivePresentationControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIAdaptivePresentationControllerDelegate" /> interface to support all the methods from the UIAdaptivePresentationControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIAdaptivePresentationControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIAdaptivePresentationControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIAdaptivePresentationControllerDelegate_Extensions {
		/// <param name="forPresentationController">To be added.</param><summary>Returns the new presentation style to use after a change to the <paramref name="forPresentationController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIModalPresentationStyle GetAdaptivePresentationStyle (this IUIAdaptivePresentationControllerDelegate This, UIPresentationController forPresentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var forPresentationController__handle__ = forPresentationController!.GetNonNullHandle (nameof (forPresentationController));
			UIModalPresentationStyle ret;
			ret = (UIModalPresentationStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("adaptivePresentationStyleForPresentationController:"), forPresentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (forPresentationController);
			return ret!;
		}
		/// <param name="controller">To be added.</param><param name="style">To be added.</param><summary>The view controller to use for the specified <paramref name="style" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIViewController GetViewControllerForAdaptivePresentation (this IUIAdaptivePresentationControllerDelegate This, UIPresentationController controller, UIModalPresentationStyle style)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("presentationController:viewControllerForAdaptivePresentationStyle:"), controller__handle__, (IntPtr) (long) style), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			return ret!;
		}
		/// <param name="controller">To be added.</param><param name="traitCollection">To be added.</param><summary>The presentation style to use for the specified <paramref name="controller" /> and <paramref name="traitCollection" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIModalPresentationStyle GetAdaptivePresentationStyle (this IUIAdaptivePresentationControllerDelegate This, UIPresentationController controller, UITraitCollection traitCollection)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var traitCollection__handle__ = traitCollection!.GetNonNullHandle (nameof (traitCollection));
			UIModalPresentationStyle ret;
			ret = (UIModalPresentationStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("adaptivePresentationStyleForPresentationController:traitCollection:"), controller__handle__, traitCollection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (traitCollection);
			return ret!;
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PrepareAdaptivePresentationController (this IUIAdaptivePresentationControllerDelegate This, UIPresentationController presentationController, UIPresentationController adaptivePresentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var presentationController__handle__ = presentationController!.GetNonNullHandle (nameof (presentationController));
			var adaptivePresentationController__handle__ = adaptivePresentationController!.GetNonNullHandle (nameof (adaptivePresentationController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("presentationController:prepareAdaptivePresentationController:"), presentationController__handle__, adaptivePresentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (presentationController);
			GC.KeepAlive (adaptivePresentationController);
		}
		/// <param name="presentationController">To be added.</param><param name="style">To be added.</param><param name="transitionCoordinator">To be added.</param><summary>Called prior to presentation.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresent (this IUIAdaptivePresentationControllerDelegate This, UIPresentationController presentationController, UIModalPresentationStyle style, IUIViewControllerTransitionCoordinator? transitionCoordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var presentationController__handle__ = presentationController!.GetNonNullHandle (nameof (presentationController));
			var transitionCoordinator__handle__ = transitionCoordinator.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("presentationController:willPresentWithAdaptiveStyle:transitionCoordinator:"), presentationController__handle__, (IntPtr) (long) style, transitionCoordinator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (presentationController);
			GC.KeepAlive (transitionCoordinator);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldDismiss (this IUIAdaptivePresentationControllerDelegate This, UIPresentationController presentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var presentationController__handle__ = presentationController!.GetNonNullHandle (nameof (presentationController));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentationControllerShouldDismiss:"), presentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (presentationController);
			return ret != 0;
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDismiss (this IUIAdaptivePresentationControllerDelegate This, UIPresentationController presentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var presentationController__handle__ = presentationController!.GetNonNullHandle (nameof (presentationController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentationControllerWillDismiss:"), presentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (presentationController);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismiss (this IUIAdaptivePresentationControllerDelegate This, UIPresentationController presentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var presentationController__handle__ = presentationController!.GetNonNullHandle (nameof (presentationController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentationControllerDidDismiss:"), presentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (presentationController);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAttemptToDismiss (this IUIAdaptivePresentationControllerDelegate This, UIPresentationController presentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var presentationController__handle__ = presentationController!.GetNonNullHandle (nameof (presentationController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentationControllerDidAttemptToDismiss:"), presentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (presentationController);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIAdaptivePresentationControllerDelegateWrapper : BaseWrapper, IUIAdaptivePresentationControllerDelegate {
		public UIAdaptivePresentationControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIAdaptivePresentationControllerDelegateWrapper))]
		static UIAdaptivePresentationControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIAdaptivePresentationControllerDelegate" /> (for the protocol <c>UIAdaptivePresentationControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIAdaptivePresentationControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UIAdaptivePresentationControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UIAdaptivePresentationControllerDelegate : NSObject, IUIAdaptivePresentationControllerDelegate {
		/// <summary>Creates a new <see cref="UIAdaptivePresentationControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIAdaptivePresentationControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected UIAdaptivePresentationControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIAdaptivePresentationControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("presentationControllerDidAttemptToDismiss:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAttemptToDismiss (UIPresentationController presentationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("presentationControllerDidDismiss:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismiss (UIPresentationController presentationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="forPresentationController">To be added.</param><summary>Returns the new presentation style to use after a change to the <paramref name="forPresentationController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("adaptivePresentationStyleForPresentationController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIModalPresentationStyle GetAdaptivePresentationStyle (UIPresentationController forPresentationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="traitCollection">To be added.</param><summary>The presentation style to use for the specified <paramref name="controller" /> and <paramref name="traitCollection" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("adaptivePresentationStyleForPresentationController:traitCollection:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIModalPresentationStyle GetAdaptivePresentationStyle (UIPresentationController controller, UITraitCollection traitCollection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="style">To be added.</param><summary>The view controller to use for the specified <paramref name="style" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("presentationController:viewControllerForAdaptivePresentationStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetViewControllerForAdaptivePresentation (UIPresentationController controller, UIModalPresentationStyle style)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("presentationController:prepareAdaptivePresentationController:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareAdaptivePresentationController (UIPresentationController presentationController, UIPresentationController adaptivePresentationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("presentationControllerShouldDismiss:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDismiss (UIPresentationController presentationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("presentationControllerWillDismiss:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismiss (UIPresentationController presentationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="presentationController">To be added.</param><param name="style">To be added.</param><param name="transitionCoordinator">To be added.</param><summary>Called prior to presentation.</summary><remarks>To be added.</remarks>
		[Export ("presentationController:willPresentWithAdaptiveStyle:transitionCoordinator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresent (UIPresentationController presentationController, UIModalPresentationStyle style, IUIViewControllerTransitionCoordinator? transitionCoordinator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIAdaptivePresentationControllerDelegate */
}
