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
	/// <summary>Interface defining the focus environment.</summary><remarks>To be added.</remarks>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIFocusEnvironment", WrapperType = typeof (UIFocusEnvironmentWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetNeedsFocusUpdate", Selector = "setNeedsFocusUpdate")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdateFocusIfNeeded", Selector = "updateFocusIfNeeded")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ShouldUpdateFocus", Selector = "shouldUpdateFocusInContext:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIFocusUpdateContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidUpdateFocus", Selector = "didUpdateFocusInContext:withAnimationCoordinator:", ParameterType = new Type [] { typeof (UIFocusUpdateContext), typeof (UIFocusAnimationCoordinator) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "PreferredFocusedView", Selector = "preferredFocusedView", PropertyType = typeof (UIView), GetterSelector = "preferredFocusedView", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PreferredFocusEnvironments", Selector = "preferredFocusEnvironments", PropertyType = typeof (IUIFocusEnvironment[]), GetterSelector = "preferredFocusEnvironments", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ParentFocusEnvironment", Selector = "parentFocusEnvironment", PropertyType = typeof (IUIFocusEnvironment), GetterSelector = "parentFocusEnvironment", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "FocusItemContainer", Selector = "focusItemContainer", PropertyType = typeof (IUIFocusItemContainer), GetterSelector = "focusItemContainer", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "FocusGroupIdentifier", Selector = "focusGroupIdentifier", PropertyType = typeof (string), GetterSelector = "focusGroupIdentifier", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIFocusEnvironment : INativeObject, IDisposable
	{
		/// <summary>When <c>this</c> is the active focus environment, requests a focus update, which can potentially change the <see cref="UIKit.UIViewController.PreferredFocusedView" />. (See also <see cref="UIKit.UIViewController.UpdateFocusIfNeeded" />.)</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setNeedsFocusUpdate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsFocusUpdate ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>When <c>this</c> is the active focus environment, requests a focus update, which can potentially change the <see cref="UIKit.UIViewController.PreferredFocusedView" />. (See also <see cref="UIKit.UIViewController.UpdateFocusIfNeeded" />.)</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetNeedsFocusUpdate (IUIFocusEnvironment This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("setNeedsFocusUpdate"));
			GC.KeepAlive (This);
		}
		/// <summary>If any focus environment has a pending update, this method forces an immediate focus update. Unlike <see cref="UIKit.IUIFocusEnvironment.SetNeedsFocusUpdate" />, this method may be called by any <see cref="T:UIKit.IUIFocusEnvironment" />, whether it currently contains focus or not.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("updateFocusIfNeeded")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateFocusIfNeeded ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>If any focus environment has a pending update, this method forces an immediate focus update. Unlike <see cref="UIKit.IUIFocusEnvironment.SetNeedsFocusUpdate" />, this method may be called by any <see cref="T:UIKit.IUIFocusEnvironment" />, whether it currently contains focus or not.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdateFocusIfNeeded (IUIFocusEnvironment This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("updateFocusIfNeeded"));
			GC.KeepAlive (This);
		}
		/// <param name="context">To be added.</param><summary>Called prior to the current object either losing or receiving focus. If either focus environment returns <see langword="false" />, the focus update is canceled.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("shouldUpdateFocusInContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldUpdateFocus (UIFocusUpdateContext context)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="context">To be added.</param><summary>Called prior to the current object either losing or receiving focus. If either focus environment returns <see langword="false" />, the focus update is canceled.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldUpdateFocus (IUIFocusEnvironment This, UIFocusUpdateContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("shouldUpdateFocusInContext:"), context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret != 0;
		}
		/// <param name="context">Metadata for the focus change.</param><param name="coordinator">The <see cref="T:UIKit.UIFocusAnimationCoordinator" /> coordinating the focus-change animations.</param><summary>Delegate method called shortly after focus has changed to a new <see cref="T:UIKit.UIView" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("didUpdateFocusInContext:withAnimationCoordinator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateFocus (UIFocusUpdateContext context, UIFocusAnimationCoordinator coordinator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="context">Metadata for the focus change.</param><param name="coordinator">The <see cref="T:UIKit.UIFocusAnimationCoordinator" /> coordinating the focus-change animations.</param><summary>Delegate method called shortly after focus has changed to a new <see cref="T:UIKit.UIView" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateFocus (IUIFocusEnvironment This, UIFocusUpdateContext context, UIFocusAnimationCoordinator coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didUpdateFocusInContext:withAnimationCoordinator:"), context__handle__, coordinator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			GC.KeepAlive (coordinator);
		}
		[DynamicDependencyAttribute ("DidUpdateFocus(UIKit.UIFocusUpdateContext,UIKit.UIFocusAnimationCoordinator)")]
		[DynamicDependencyAttribute ("FocusGroupIdentifier")]
		[DynamicDependencyAttribute ("FocusItemContainer")]
		[DynamicDependencyAttribute ("ParentFocusEnvironment")]
		[DynamicDependencyAttribute ("PreferredFocusedView")]
		[DynamicDependencyAttribute ("PreferredFocusEnvironments")]
		[DynamicDependencyAttribute ("SetNeedsFocusUpdate()")]
		[DynamicDependencyAttribute ("ShouldUpdateFocus(UIKit.UIFocusUpdateContext)")]
		[DynamicDependencyAttribute ("UpdateFocusIfNeeded()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIFocusEnvironmentWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIFocusEnvironment ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>If not <see langword="null" />, indicates the child <see cref="T:UIKit.UIView" /> that should receive focus by default.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios10.0", "Use 'PreferredFocusEnvironments' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use 'PreferredFocusEnvironments' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'PreferredFocusEnvironments' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.OptionalMember]
		public virtual UIView? PreferredFocusedView {
			[Export ("preferredFocusedView", ArgumentSemantic.Weak)]
			get {
				return _GetPreferredFocusedView (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIView _GetPreferredFocusedView (IUIFocusEnvironment This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIView ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("preferredFocusedView")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the list of focus environments, ordered by priority, that the environment prefers when updating the focus.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual IUIFocusEnvironment[] PreferredFocusEnvironments {
			[Export ("preferredFocusEnvironments", ArgumentSemantic.Copy)]
			get {
				return _GetPreferredFocusEnvironments (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIFocusEnvironment[] _GetPreferredFocusEnvironments (IUIFocusEnvironment This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIFocusEnvironment[] ret;
			ret = CFArray.ArrayFromHandle<IUIFocusEnvironment>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("preferredFocusEnvironments")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the parent focus environment.</summary><value>The parent focus environment.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual IUIFocusEnvironment? ParentFocusEnvironment {
			[Export ("parentFocusEnvironment", ArgumentSemantic.Weak)]
			get {
				return _GetParentFocusEnvironment (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIFocusEnvironment _GetParentFocusEnvironment (IUIFocusEnvironment This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIFocusEnvironment ret;
			ret =  Runtime.GetINativeObject<IUIFocusEnvironment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("parentFocusEnvironment")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the container that manages focus information for child focus items.</summary><value>The container that manages focus information for child focus items.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual IUIFocusItemContainer? FocusItemContainer {
			[Export ("focusItemContainer")]
			get {
				return _GetFocusItemContainer (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIFocusItemContainer _GetFocusItemContainer (IUIFocusEnvironment This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIFocusItemContainer ret;
			ret =  Runtime.GetINativeObject<IUIFocusItemContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("focusItemContainer")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[global::Foundation.OptionalMember]
		public virtual string? FocusGroupIdentifier {
			[Export ("focusGroupIdentifier")]
			get {
				return _GetFocusGroupIdentifier (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetFocusGroupIdentifier (IUIFocusEnvironment This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("focusGroupIdentifier")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIFocusEnvironment" /> interface to support all the methods from the UIFocusEnvironment protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIFocusEnvironment" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIFocusEnvironment protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIFocusEnvironment_Extensions {
		/// <summary>If not <see langword="null" />, indicates the child <see cref="T:UIKit.UIView" /> that should receive focus by default.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIView GetPreferredFocusedView (this IUIFocusEnvironment This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIView ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("preferredFocusedView")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetFocusGroupIdentifier (this IUIFocusEnvironment This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("focusGroupIdentifier")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIFocusEnvironmentWrapper : BaseWrapper, IUIFocusEnvironment {
		public UIFocusEnvironmentWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIFocusEnvironmentWrapper))]
		static UIFocusEnvironmentWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>When <c>this</c> is the active focus environment, requests a focus update, which can potentially change the <see cref="UIKit.UIViewController.PreferredFocusedView" />. (See also <see cref="UIKit.UIViewController.UpdateFocusIfNeeded" />.)</summary><remarks>To be added.</remarks>
		[Export ("setNeedsFocusUpdate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetNeedsFocusUpdate ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsFocusUpdate"));
		}
		/// <summary>If any focus environment has a pending update, this method forces an immediate focus update. Unlike <see cref="UIKit.IUIFocusEnvironment.SetNeedsFocusUpdate" />, this method may be called by any <see cref="T:UIKit.IUIFocusEnvironment" />, whether it currently contains focus or not.</summary><remarks>To be added.</remarks>
		[Export ("updateFocusIfNeeded")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UpdateFocusIfNeeded ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateFocusIfNeeded"));
		}
		/// <param name="context">To be added.</param><summary>Called prior to the current object either losing or receiving focus. If either focus environment returns <see langword="false" />, the focus update is canceled.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shouldUpdateFocusInContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ShouldUpdateFocus (UIFocusUpdateContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("shouldUpdateFocusInContext:"), context__handle__);
			GC.KeepAlive (context);
			return ret != 0;
		}
		/// <param name="context">Metadata for the focus change.</param><param name="coordinator">The <see cref="T:UIKit.UIFocusAnimationCoordinator" /> coordinating the focus-change animations.</param><summary>Delegate method called shortly after focus has changed to a new <see cref="T:UIKit.UIView" />.</summary><remarks>To be added.</remarks>
		[Export ("didUpdateFocusInContext:withAnimationCoordinator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidUpdateFocus (UIFocusUpdateContext context, UIFocusAnimationCoordinator coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("didUpdateFocusInContext:withAnimationCoordinator:"), context__handle__, coordinator__handle__);
			GC.KeepAlive (context);
			GC.KeepAlive (coordinator);
		}
		/// <summary>Gets the list of focus environments, ordered by priority, that the environment prefers when updating the focus.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public IUIFocusEnvironment[] PreferredFocusEnvironments {
			[Export ("preferredFocusEnvironments", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUIFocusEnvironment[] ret;
				ret = CFArray.ArrayFromHandle<IUIFocusEnvironment>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("preferredFocusEnvironments")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the parent focus environment.</summary><value>The parent focus environment.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public IUIFocusEnvironment? ParentFocusEnvironment {
			[Export ("parentFocusEnvironment", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUIFocusEnvironment ret;
				ret =  Runtime.GetINativeObject<IUIFocusEnvironment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("parentFocusEnvironment")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the container that manages focus information for child focus items.</summary><value>The container that manages focus information for child focus items.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public IUIFocusItemContainer? FocusItemContainer {
			[Export ("focusItemContainer")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUIFocusItemContainer ret;
				ret =  Runtime.GetINativeObject<IUIFocusItemContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("focusItemContainer")), false)!;
				return ret;
			}
		}
	}
}
