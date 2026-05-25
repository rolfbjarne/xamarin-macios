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
	/// <summary>This interface represents the Objective-C protocol <c>UIViewControllerContextTransitioning</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIViewControllerContextTransitioning", WrapperType = typeof (UIViewControllerContextTransitioningWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdateInteractiveTransition", Selector = "updateInteractiveTransition:", ParameterType = new Type [] { typeof (NFloat) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishInteractiveTransition", Selector = "finishInteractiveTransition")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CancelInteractiveTransition", Selector = "cancelInteractiveTransition")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CompleteTransition", Selector = "completeTransition:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetViewControllerForKey", Selector = "viewControllerForKey:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (NSString) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetInitialFrameForViewController", Selector = "initialFrameForViewController:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (UIViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetFinalFrameForViewController", Selector = "finalFrameForViewController:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (UIViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetViewFor", Selector = "viewForKey:", ReturnType = typeof (UIView), ParameterType = new Type [] { typeof (NSString) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PauseInteractiveTransition", Selector = "pauseInteractiveTransition")]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ContainerView", Selector = "containerView", PropertyType = typeof (UIView), GetterSelector = "containerView", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IsAnimated", Selector = "isAnimated", PropertyType = typeof (bool), GetterSelector = "isAnimated", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IsInteractive", Selector = "isInteractive", PropertyType = typeof (bool), GetterSelector = "isInteractive", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TransitionWasCancelled", Selector = "transitionWasCancelled", PropertyType = typeof (bool), GetterSelector = "transitionWasCancelled", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PresentationStyle", Selector = "presentationStyle", PropertyType = typeof (UIModalPresentationStyle), GetterSelector = "presentationStyle", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TargetTransform", Selector = "targetTransform", PropertyType = typeof (CGAffineTransform), GetterSelector = "targetTransform", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIViewControllerContextTransitioning : INativeObject, IDisposable
	{
		/// <param name="percentComplete">To be added.</param><summary>Updates the completion percentage of the transition.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("updateInteractiveTransition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateInteractiveTransition (nfloat percentComplete)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="percentComplete">To be added.</param><summary>Updates the completion percentage of the transition.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdateInteractiveTransition (IUIViewControllerContextTransitioning This, nfloat percentComplete)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("updateInteractiveTransition:"), percentComplete);
			GC.KeepAlive (This);
		}
		/// <summary>User interactions have signaled the end of the transition.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("finishInteractiveTransition")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishInteractiveTransition ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>User interactions have signaled the end of the transition.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FinishInteractiveTransition (IUIViewControllerContextTransitioning This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("finishInteractiveTransition"));
			GC.KeepAlive (This);
		}
		/// <summary>Indicates that a user action canceled the transition.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("cancelInteractiveTransition")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelInteractiveTransition ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Indicates that a user action canceled the transition.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CancelInteractiveTransition (IUIViewControllerContextTransitioning This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("cancelInteractiveTransition"));
			GC.KeepAlive (This);
		}
		/// <param name="didComplete">To be added.</param><summary>Indicates the transition animation has completed.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("completeTransition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CompleteTransition (bool didComplete)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="didComplete">To be added.</param><summary>Indicates the transition animation has completed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CompleteTransition (IUIViewControllerContextTransitioning This, bool didComplete)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("completeTransition:"), didComplete ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <param name="uiTransitionKey">Should be a value from <see cref="T:UIKit.UITransitionContext" />.</param><summary>Retrieves the UIViewController associated with the specified uiTransitionKey.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("viewControllerForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetViewControllerForKey (NSString uiTransitionKey)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="uiTransitionKey">Should be a value from <see cref="T:UIKit.UITransitionContext" />.</param><summary>Retrieves the UIViewController associated with the specified uiTransitionKey.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIViewController _GetViewControllerForKey (IUIViewControllerContextTransitioning This, NSString uiTransitionKey)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var uiTransitionKey__handle__ = uiTransitionKey!.GetNonNullHandle (nameof (uiTransitionKey));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("viewControllerForKey:"), uiTransitionKey__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (uiTransitionKey);
			return ret!;
		}
		/// <param name="vc">To be added.</param><summary>The beginning RectangleF for the Frame of the specified UIViewController's UIView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("initialFrameForViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetInitialFrameForViewController (UIViewController vc)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="vc">To be added.</param><summary>The beginning RectangleF for the Frame of the specified UIViewController's UIView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetInitialFrameForViewController (IUIViewControllerContextTransitioning This, UIViewController vc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var vc__handle__ = vc!.GetNonNullHandle (nameof (vc));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("initialFrameForViewController:"), vc__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("initialFrameForViewController:"), vc__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (vc);
			return ret!;
		}
		/// <param name="vc">To be added.</param><summary>The ending RectangleF for the Frame of the specified UIViewController's UIView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("finalFrameForViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFinalFrameForViewController (UIViewController vc)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="vc">To be added.</param><summary>The ending RectangleF for the Frame of the specified UIViewController's UIView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetFinalFrameForViewController (IUIViewControllerContextTransitioning This, UIViewController vc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var vc__handle__ = vc!.GetNonNullHandle (nameof (vc));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("finalFrameForViewController:"), vc__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("finalFrameForViewController:"), vc__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (vc);
			return ret!;
		}
		/// <param name="uiTransitionContextToOrFromKey">To be added.</param><summary>Returns the to- or from-key for the transition.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("viewForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView GetViewFor (NSString uiTransitionContextToOrFromKey)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="uiTransitionContextToOrFromKey">To be added.</param><summary>Returns the to- or from-key for the transition.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIView _GetViewFor (IUIViewControllerContextTransitioning This, NSString uiTransitionContextToOrFromKey)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var uiTransitionContextToOrFromKey__handle__ = uiTransitionContextToOrFromKey!.GetNonNullHandle (nameof (uiTransitionContextToOrFromKey));
			UIView? ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("viewForKey:"), uiTransitionContextToOrFromKey__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (uiTransitionContextToOrFromKey);
			return ret!;
		}
		/// <summary>Pauses the animations.</summary>
		[global::Foundation.RequiredMember]
		[Export ("pauseInteractiveTransition")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PauseInteractiveTransition ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Pauses the animations.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PauseInteractiveTransition (IUIViewControllerContextTransitioning This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("pauseInteractiveTransition"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("CancelInteractiveTransition()")]
		[DynamicDependencyAttribute ("CompleteTransition(System.Boolean)")]
		[DynamicDependencyAttribute ("ContainerView")]
		[DynamicDependencyAttribute ("FinishInteractiveTransition()")]
		[DynamicDependencyAttribute ("GetFinalFrameForViewController(UIKit.UIViewController)")]
		[DynamicDependencyAttribute ("GetInitialFrameForViewController(UIKit.UIViewController)")]
		[DynamicDependencyAttribute ("GetViewControllerForKey(Foundation.NSString)")]
		[DynamicDependencyAttribute ("GetViewFor(Foundation.NSString)")]
		[DynamicDependencyAttribute ("IsAnimated")]
		[DynamicDependencyAttribute ("IsInteractive")]
		[DynamicDependencyAttribute ("PauseInteractiveTransition()")]
		[DynamicDependencyAttribute ("PresentationStyle")]
		[DynamicDependencyAttribute ("TargetTransform")]
		[DynamicDependencyAttribute ("TransitionWasCancelled")]
		[DynamicDependencyAttribute ("UpdateInteractiveTransition(System.Runtime.InteropServices.NFloat)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewControllerContextTransitioningWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIViewControllerContextTransitioning ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>The UIView that is the superview of the UIView's involved in the transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIView ContainerView {
			[Export ("containerView")]
			get {
				return _GetContainerView (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIView _GetContainerView (IUIViewControllerContextTransitioning This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIView ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("containerView")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Whether the transition is animated.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool IsAnimated {
			[Export ("isAnimated")]
			get {
				return _GetIsAnimated (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetIsAnimated (IUIViewControllerContextTransitioning This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAnimated"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Whether the transition is interactive.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool IsInteractive {
			[Export ("isInteractive")]
			get {
				return _GetIsInteractive (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetIsInteractive (IUIViewControllerContextTransitioning This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isInteractive"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Whether the transition was cancelled.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool TransitionWasCancelled {
			[Export ("transitionWasCancelled")]
			get {
				return _GetTransitionWasCancelled (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetTransitionWasCancelled (IUIViewControllerContextTransitioning This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("transitionWasCancelled"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>The presentation style of the transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIModalPresentationStyle PresentationStyle {
			[Export ("presentationStyle")]
			get {
				return _GetPresentationStyle (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIModalPresentationStyle _GetPresentationStyle (IUIViewControllerContextTransitioning This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIModalPresentationStyle ret;
			ret = (UIModalPresentationStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("presentationStyle"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Gets the transform that indicates the angle of the rotation that is applied during the transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGAffineTransform TargetTransform {
			[Export ("targetTransform")]
			get {
				return _GetTargetTransform (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGAffineTransform _GetTargetTransform (IUIViewControllerContextTransitioning This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGAffineTransform ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend (This.Handle, Selector.GetHandle ("targetTransform"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret (This.Handle, Selector.GetHandle ("targetTransform"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIViewControllerContextTransitioningWrapper : BaseWrapper, IUIViewControllerContextTransitioning {
		public UIViewControllerContextTransitioningWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewControllerContextTransitioningWrapper))]
		static UIViewControllerContextTransitioningWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="percentComplete">To be added.</param><summary>Updates the completion percentage of the transition.</summary><remarks>To be added.</remarks>
		[Export ("updateInteractiveTransition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UpdateInteractiveTransition (nfloat percentComplete)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("updateInteractiveTransition:"), percentComplete);
		}
		/// <summary>User interactions have signaled the end of the transition.</summary><remarks>To be added.</remarks>
		[Export ("finishInteractiveTransition")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FinishInteractiveTransition ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("finishInteractiveTransition"));
		}
		/// <summary>Indicates that a user action canceled the transition.</summary><remarks>To be added.</remarks>
		[Export ("cancelInteractiveTransition")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CancelInteractiveTransition ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancelInteractiveTransition"));
		}
		/// <param name="didComplete">To be added.</param><summary>Indicates the transition animation has completed.</summary><remarks>To be added.</remarks>
		[Export ("completeTransition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CompleteTransition (bool didComplete)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("completeTransition:"), didComplete ? (byte) 1 : (byte) 0);
		}
		/// <param name="uiTransitionKey">Should be a value from <see cref="T:UIKit.UITransitionContext" />.</param><summary>Retrieves the UIViewController associated with the specified uiTransitionKey.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("viewControllerForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIViewController GetViewControllerForKey (NSString uiTransitionKey)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var uiTransitionKey__handle__ = uiTransitionKey!.GetNonNullHandle (nameof (uiTransitionKey));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("viewControllerForKey:"), uiTransitionKey__handle__), false)!;
			GC.KeepAlive (uiTransitionKey);
			return ret!;
		}
		/// <param name="vc">To be added.</param><summary>The beginning RectangleF for the Frame of the specified UIViewController's UIView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("initialFrameForViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetInitialFrameForViewController (UIViewController vc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var vc__handle__ = vc!.GetNonNullHandle (nameof (vc));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initialFrameForViewController:"), vc__handle__);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("initialFrameForViewController:"), vc__handle__);
			}
			GC.KeepAlive (vc);
			return ret!;
		}
		/// <param name="vc">To be added.</param><summary>The ending RectangleF for the Frame of the specified UIViewController's UIView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("finalFrameForViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetFinalFrameForViewController (UIViewController vc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var vc__handle__ = vc!.GetNonNullHandle (nameof (vc));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("finalFrameForViewController:"), vc__handle__);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("finalFrameForViewController:"), vc__handle__);
			}
			GC.KeepAlive (vc);
			return ret!;
		}
		/// <param name="uiTransitionContextToOrFromKey">To be added.</param><summary>Returns the to- or from-key for the transition.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("viewForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIView GetViewFor (NSString uiTransitionContextToOrFromKey)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var uiTransitionContextToOrFromKey__handle__ = uiTransitionContextToOrFromKey!.GetNonNullHandle (nameof (uiTransitionContextToOrFromKey));
			UIView? ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("viewForKey:"), uiTransitionContextToOrFromKey__handle__), false)!;
			GC.KeepAlive (uiTransitionContextToOrFromKey);
			return ret!;
		}
		/// <summary>Pauses the animations.</summary>
		[Export ("pauseInteractiveTransition")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PauseInteractiveTransition ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("pauseInteractiveTransition"));
		}
		/// <summary>The UIView that is the superview of the UIView's involved in the transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIView ContainerView {
			[Export ("containerView")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView ret;
				ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("containerView")), false)!;
				return ret;
			}
		}
		/// <summary>Whether the transition is animated.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool IsAnimated {
			[Export ("isAnimated")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAnimated"));
				return ret != 0;
			}
		}
		/// <summary>Whether the transition is interactive.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool IsInteractive {
			[Export ("isInteractive")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isInteractive"));
				return ret != 0;
			}
		}
		/// <summary>Whether the transition was cancelled.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool TransitionWasCancelled {
			[Export ("transitionWasCancelled")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("transitionWasCancelled"));
				return ret != 0;
			}
		}
		/// <summary>The presentation style of the transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIModalPresentationStyle PresentationStyle {
			[Export ("presentationStyle")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIModalPresentationStyle ret;
				ret = (UIModalPresentationStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("presentationStyle"));
				return ret!;
			}
		}
		/// <summary>Gets the transform that indicates the angle of the rotation that is applied during the transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGAffineTransform TargetTransform {
			[Export ("targetTransform")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGAffineTransform ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend (this.Handle, Selector.GetHandle ("targetTransform"));
				} else {
					ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret (this.Handle, Selector.GetHandle ("targetTransform"));
				}
				return ret!;
			}
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIViewControllerContextTransitioning" /> (for the protocol <c>UIViewControllerContextTransitioning</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIViewControllerContextTransitioning" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UIViewControllerContextTransitioning", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class UIViewControllerContextTransitioning : NSObject, IUIViewControllerContextTransitioning {
		/// <summary>Creates a new <see cref="UIViewControllerContextTransitioning" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UIViewControllerContextTransitioning () : base (NSObjectFlag.Empty)
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
		protected UIViewControllerContextTransitioning (NSObjectFlag t) : base (t)
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
		protected internal UIViewControllerContextTransitioning (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <summary>Indicates that a user action canceled the transition.</summary><remarks>To be added.</remarks>
		[Export ("cancelInteractiveTransition")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelInteractiveTransition ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="didComplete">To be added.</param><summary>Indicates the transition animation has completed.</summary><remarks>To be added.</remarks>
		[Export ("completeTransition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CompleteTransition (bool didComplete)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>User interactions have signaled the end of the transition.</summary><remarks>To be added.</remarks>
		[Export ("finishInteractiveTransition")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishInteractiveTransition ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="vc">To be added.</param><summary>The ending RectangleF for the Frame of the specified UIViewController's UIView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("finalFrameForViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFinalFrameForViewController (UIViewController vc)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="vc">To be added.</param><summary>The beginning RectangleF for the Frame of the specified UIViewController's UIView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("initialFrameForViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetInitialFrameForViewController (UIViewController vc)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="uiTransitionKey">Should be a value from <see cref="T:UIKit.UITransitionContext" />.</param><summary>Retrieves the UIViewController associated with the specified uiTransitionKey.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("viewControllerForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetViewControllerForKey (NSString uiTransitionKey)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="uiTransitionContextToOrFromKey">To be added.</param><summary>Returns the to- or from-key for the transition.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("viewForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView GetViewFor (NSString uiTransitionContextToOrFromKey)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Pauses the animations.</summary>
		[Export ("pauseInteractiveTransition")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PauseInteractiveTransition ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="percentComplete">To be added.</param><summary>Updates the completion percentage of the transition.</summary><remarks>To be added.</remarks>
		[Export ("updateInteractiveTransition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateInteractiveTransition (nfloat percentComplete)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>The UIView that is the superview of the UIView's involved in the transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView ContainerView {
			[Export ("containerView")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>Whether the transition is animated.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAnimated {
			[Export ("isAnimated")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>Whether the transition is interactive.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsInteractive {
			[Export ("isInteractive")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>The presentation style of the transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIModalPresentationStyle PresentationStyle {
			[Export ("presentationStyle")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>Gets the transform that indicates the angle of the rotation that is applied during the transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGAffineTransform TargetTransform {
			[Export ("targetTransform")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>Whether the transition was cancelled.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TransitionWasCancelled {
			[Export ("transitionWasCancelled")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class UIViewControllerContextTransitioning */
}
