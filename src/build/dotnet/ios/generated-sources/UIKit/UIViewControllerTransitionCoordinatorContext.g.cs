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
	/// <summary>Interface that defines the context for coordination of a transition.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIViewControllerTransitionCoordinatorContext", WrapperType = typeof (UIViewControllerTransitionCoordinatorContextWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetViewControllerForKey", Selector = "viewControllerForKey:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (NSString) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "TargetTransform", Selector = "targetTransform", ReturnType = typeof (CGAffineTransform))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetTransitionViewControllerForKey", Selector = "viewForKey:", ReturnType = typeof (UIView), ParameterType = new Type [] { typeof (NSString) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IsAnimated", Selector = "isAnimated", PropertyType = typeof (bool), GetterSelector = "isAnimated", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PresentationStyle", Selector = "presentationStyle", PropertyType = typeof (UIModalPresentationStyle), GetterSelector = "presentationStyle", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InitiallyInteractive", Selector = "initiallyInteractive", PropertyType = typeof (bool), GetterSelector = "initiallyInteractive", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IsInteractive", Selector = "isInteractive", PropertyType = typeof (bool), GetterSelector = "isInteractive", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IsCancelled", Selector = "isCancelled", PropertyType = typeof (bool), GetterSelector = "isCancelled", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TransitionDuration", Selector = "transitionDuration", PropertyType = typeof (double), GetterSelector = "transitionDuration", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PercentComplete", Selector = "percentComplete", PropertyType = typeof (NFloat), GetterSelector = "percentComplete", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CompletionVelocity", Selector = "completionVelocity", PropertyType = typeof (NFloat), GetterSelector = "completionVelocity", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CompletionCurve", Selector = "completionCurve", PropertyType = typeof (UIViewAnimationCurve), GetterSelector = "completionCurve", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ContainerView", Selector = "containerView", PropertyType = typeof (UIView), GetterSelector = "containerView", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IsInterruptible", Selector = "isInterruptible", PropertyType = typeof (bool), GetterSelector = "isInterruptible", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIViewControllerTransitionCoordinatorContext : INativeObject, IDisposable
	{
		/// <param name="uiTransitionKey">To be added.</param><summary>The UIViewController for the specified uiTransitionKey.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("viewControllerForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetViewControllerForKey (NSString uiTransitionKey)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="uiTransitionKey">To be added.</param><summary>The UIViewController for the specified uiTransitionKey.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIViewController _GetViewControllerForKey (IUIViewControllerTransitionCoordinatorContext This, NSString uiTransitionKey)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var uiTransitionKey__handle__ = uiTransitionKey!.GetNonNullHandle (nameof (uiTransitionKey));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("viewControllerForKey:"), uiTransitionKey__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (uiTransitionKey);
			return ret!;
		}
		/// <summary>Returns the transform that describes the rotation of the transition.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("targetTransform")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGAffineTransform TargetTransform ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Returns the transform that describes the rotation of the transition.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGAffineTransform _TargetTransform (IUIViewControllerTransitionCoordinatorContext This)
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
		/// <param name="key">To be added.</param><summary>Gets the transition that is specified by <paramref name="key" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("viewForKey:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView GetTransitionViewControllerForKey (NSString key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="key">To be added.</param><summary>Gets the transition that is specified by <paramref name="key" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIView _GetTransitionViewControllerForKey (IUIViewControllerTransitionCoordinatorContext This, NSString key)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			UIView? ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("viewForKey:"), key__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (key);
			return ret!;
		}
		[DynamicDependencyAttribute ("CompletionCurve")]
		[DynamicDependencyAttribute ("CompletionVelocity")]
		[DynamicDependencyAttribute ("ContainerView")]
		[DynamicDependencyAttribute ("GetTransitionViewControllerForKey(Foundation.NSString)")]
		[DynamicDependencyAttribute ("GetViewControllerForKey(Foundation.NSString)")]
		[DynamicDependencyAttribute ("InitiallyInteractive")]
		[DynamicDependencyAttribute ("IsAnimated")]
		[DynamicDependencyAttribute ("IsCancelled")]
		[DynamicDependencyAttribute ("IsInteractive")]
		[DynamicDependencyAttribute ("IsInterruptible")]
		[DynamicDependencyAttribute ("PercentComplete")]
		[DynamicDependencyAttribute ("PresentationStyle")]
		[DynamicDependencyAttribute ("TargetTransform()")]
		[DynamicDependencyAttribute ("TransitionDuration")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewControllerTransitionCoordinatorContextWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIViewControllerTransitionCoordinatorContext ()
		{
			GC.KeepAlive (null);
		}
		/// <summary><see langword="true" /> if the transition is explicitly animated or uses <see cref="F:UIKit.UIModalPresentationStyle.Custom" /> presentation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool IsAnimated {
			[Export ("isAnimated")]
			get {
				return _GetIsAnimated (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetIsAnimated (IUIViewControllerTransitionCoordinatorContext This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAnimated"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>The presentation style whose transition is being modified.</summary><value>Use <see cref="F:UIKit.UIModalPresentationStyle.None" /> if the transition is not a modal presentation or dismissal.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIModalPresentationStyle PresentationStyle {
			[Export ("presentationStyle")]
			get {
				return _GetPresentationStyle (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIModalPresentationStyle _GetPresentationStyle (IUIViewControllerTransitionCoordinatorContext This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIModalPresentationStyle ret;
			ret = (UIModalPresentationStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("presentationStyle"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary><see langword="true" /> iff <see cref="UIKit.IUIViewControllerTransitionCoordinatorContext.IsAnimated" /> is <see langword="true" /> and the transition was initiated interactively.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool InitiallyInteractive {
			[Export ("initiallyInteractive")]
			get {
				return _GetInitiallyInteractive (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetInitiallyInteractive (IUIViewControllerTransitionCoordinatorContext This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("initiallyInteractive"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary><see langword="true" /> if the transition is currently interactive.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool IsInteractive {
			[Export ("isInteractive")]
			get {
				return _GetIsInteractive (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetIsInteractive (IUIViewControllerTransitionCoordinatorContext This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isInteractive"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary><see langword="true" /> if the interactive transition is ending and the user canceled the transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool IsCancelled {
			[Export ("isCancelled")]
			get {
				return _GetIsCancelled (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetIsCancelled (IUIViewControllerTransitionCoordinatorContext This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isCancelled"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>The expected duration, in seconds, of the transition, if it is noninteractive.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual double TransitionDuration {
			[Export ("transitionDuration")]
			get {
				return _GetTransitionDuration (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetTransitionDuration (IUIViewControllerTransitionCoordinatorContext This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("transitionDuration"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>The percent of completion of a transition when it moves to the noninteractive completion phase.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nfloat PercentComplete {
			[Export ("percentComplete")]
			get {
				return _GetPercentComplete (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetPercentComplete (IUIViewControllerTransitionCoordinatorContext This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("percentComplete"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>The completion velocity for the view controller transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nfloat CompletionVelocity {
			[Export ("completionVelocity")]
			get {
				return _GetCompletionVelocity (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetCompletionVelocity (IUIViewControllerTransitionCoordinatorContext This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("completionVelocity"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>The UIViewAnimationCurve for the view controller transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIViewAnimationCurve CompletionCurve {
			[Export ("completionCurve")]
			get {
				return _GetCompletionCurve (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIViewAnimationCurve _GetCompletionCurve (IUIViewControllerTransitionCoordinatorContext This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIViewAnimationCurve ret;
			ret = (UIViewAnimationCurve) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("completionCurve"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>The container UIView for the view controller transition animation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIView ContainerView {
			[Export ("containerView")]
			get {
				return _GetContainerView (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIView _GetContainerView (IUIViewControllerTransitionCoordinatorContext This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIView ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("containerView")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual bool IsInterruptible {
			[Export ("isInterruptible")]
			get {
				return _GetIsInterruptible (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetIsInterruptible (IUIViewControllerTransitionCoordinatorContext This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isInterruptible"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIViewControllerTransitionCoordinatorContextWrapper : BaseWrapper, IUIViewControllerTransitionCoordinatorContext {
		public UIViewControllerTransitionCoordinatorContextWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewControllerTransitionCoordinatorContextWrapper))]
		static UIViewControllerTransitionCoordinatorContextWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="uiTransitionKey">To be added.</param><summary>The UIViewController for the specified uiTransitionKey.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
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
		/// <summary>Returns the transform that describes the rotation of the transition.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("targetTransform")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGAffineTransform TargetTransform ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGAffineTransform ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend (this.Handle, Selector.GetHandle ("targetTransform"));
			} else {
				ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret (this.Handle, Selector.GetHandle ("targetTransform"));
			}
			return ret!;
		}
		/// <param name="key">To be added.</param><summary>Gets the transition that is specified by <paramref name="key" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("viewForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIView GetTransitionViewControllerForKey (NSString key)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			UIView? ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("viewForKey:"), key__handle__), false)!;
			GC.KeepAlive (key);
			return ret!;
		}
		/// <summary><see langword="true" /> if the transition is explicitly animated or uses <see cref="F:UIKit.UIModalPresentationStyle.Custom" /> presentation.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>The presentation style whose transition is being modified.</summary><value>Use <see cref="F:UIKit.UIModalPresentationStyle.None" /> if the transition is not a modal presentation or dismissal.</value><remarks>To be added.</remarks>
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
		/// <summary><see langword="true" /> iff <see cref="UIKit.IUIViewControllerTransitionCoordinatorContext.IsAnimated" /> is <see langword="true" /> and the transition was initiated interactively.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool InitiallyInteractive {
			[Export ("initiallyInteractive")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("initiallyInteractive"));
				return ret != 0;
			}
		}
		/// <summary><see langword="true" /> if the transition is currently interactive.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary><see langword="true" /> if the interactive transition is ending and the user canceled the transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool IsCancelled {
			[Export ("isCancelled")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isCancelled"));
				return ret != 0;
			}
		}
		/// <summary>The expected duration, in seconds, of the transition, if it is noninteractive.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public double TransitionDuration {
			[Export ("transitionDuration")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("transitionDuration"));
				return ret;
			}
		}
		/// <summary>The percent of completion of a transition when it moves to the noninteractive completion phase.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nfloat PercentComplete {
			[Export ("percentComplete")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("percentComplete"));
				return ret;
			}
		}
		/// <summary>The completion velocity for the view controller transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nfloat CompletionVelocity {
			[Export ("completionVelocity")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("completionVelocity"));
				return ret;
			}
		}
		/// <summary>The UIViewAnimationCurve for the view controller transition.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIViewAnimationCurve CompletionCurve {
			[Export ("completionCurve")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewAnimationCurve ret;
				ret = (UIViewAnimationCurve) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("completionCurve"));
				return ret!;
			}
		}
		/// <summary>The container UIView for the view controller transition animation.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public bool IsInterruptible {
			[Export ("isInterruptible")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isInterruptible"));
				return ret != 0;
			}
		}
	}
}
