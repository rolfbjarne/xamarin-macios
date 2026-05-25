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
	/// <summary>This interface represents the Objective-C protocol <c>UISplitViewControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UISplitViewControllerDelegate", WrapperType = typeof (UISplitViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SupportedInterfaceOrientations", Selector = "splitViewControllerSupportedInterfaceOrientations:", ReturnType = typeof (UIInterfaceOrientationMask), ParameterType = new Type [] { typeof (UISplitViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPreferredInterfaceOrientationForPresentation", Selector = "splitViewControllerPreferredInterfaceOrientationForPresentation:", ReturnType = typeof (UIInterfaceOrientation), ParameterType = new Type [] { typeof (UISplitViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentViewController", Selector = "splitViewController:popoverController:willPresentViewController:", ParameterType = new Type [] { typeof (UISplitViewController), typeof (UIPopoverController), typeof (UIViewController) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillHideViewController", Selector = "splitViewController:willHideViewController:withBarButtonItem:forPopoverController:", ParameterType = new Type [] { typeof (UISplitViewController), typeof (UIViewController), typeof (UIBarButtonItem), typeof (UIPopoverController) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillShowViewController", Selector = "splitViewController:willShowViewController:invalidatingBarButtonItem:", ParameterType = new Type [] { typeof (UISplitViewController), typeof (UIViewController), typeof (UIBarButtonItem) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldHideViewController", Selector = "splitViewController:shouldHideViewController:inOrientation:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UISplitViewController), typeof (UIViewController), typeof (UIInterfaceOrientation) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillChangeDisplayMode", Selector = "splitViewController:willChangeToDisplayMode:", ParameterType = new Type [] { typeof (UISplitViewController), typeof (UISplitViewControllerDisplayMode) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTargetDisplayModeForAction", Selector = "targetDisplayModeForActionInSplitViewController:", ReturnType = typeof (UISplitViewControllerDisplayMode), ParameterType = new Type [] { typeof (UISplitViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EventShowViewController", Selector = "splitViewController:showViewController:sender:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UISplitViewController), typeof (UIViewController), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EventShowDetailViewController", Selector = "splitViewController:showDetailViewController:sender:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UISplitViewController), typeof (UIViewController), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPrimaryViewControllerForCollapsingSplitViewController", Selector = "primaryViewControllerForCollapsingSplitViewController:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (UISplitViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPrimaryViewControllerForExpandingSplitViewController", Selector = "primaryViewControllerForExpandingSplitViewController:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (UISplitViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CollapseSecondViewController", Selector = "splitViewController:collapseSecondaryViewController:ontoPrimaryViewController:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UISplitViewController), typeof (UIViewController), typeof (UIViewController) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SeparateSecondaryViewController", Selector = "splitViewController:separateSecondaryViewControllerFromPrimaryViewController:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (UISplitViewController), typeof (UIViewController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTopColumnForCollapsing", Selector = "splitViewController:topColumnForCollapsingToProposedTopColumn:", ReturnType = typeof (UISplitViewControllerColumn), ParameterType = new Type [] { typeof (UISplitViewController), typeof (UISplitViewControllerColumn) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDisplayModeForExpanding", Selector = "splitViewController:displayModeForExpandingToProposedDisplayMode:", ReturnType = typeof (UISplitViewControllerDisplayMode), ParameterType = new Type [] { typeof (UISplitViewController), typeof (UISplitViewControllerDisplayMode) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCollapse", Selector = "splitViewControllerDidCollapse:", ParameterType = new Type [] { typeof (UISplitViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidExpand", Selector = "splitViewControllerDidExpand:", ParameterType = new Type [] { typeof (UISplitViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillShowColumn", Selector = "splitViewController:willShowColumn:", ParameterType = new Type [] { typeof (UISplitViewController), typeof (UISplitViewControllerColumn) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillHideColumn", Selector = "splitViewController:willHideColumn:", ParameterType = new Type [] { typeof (UISplitViewController), typeof (UISplitViewControllerColumn) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InteractivePresentationGestureWillBegin", Selector = "splitViewControllerInteractivePresentationGestureWillBegin:", ParameterType = new Type [] { typeof (UISplitViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InteractivePresentationGestureDidEnd", Selector = "splitViewControllerInteractivePresentationGestureDidEnd:", ParameterType = new Type [] { typeof (UISplitViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidShowColumn", Selector = "splitViewController:didShowColumn:", ParameterType = new Type [] { typeof (UISplitViewController), typeof (UISplitViewControllerColumn) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidHideColumn", Selector = "splitViewController:didHideColumn:", ParameterType = new Type [] { typeof (UISplitViewController), typeof (UISplitViewControllerColumn) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUISplitViewControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="splitViewController">The split view controller.</param><summary>Returns the supported interface orientations for <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitViewControllerSupportedInterfaceOrientations:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIInterfaceOrientationMask SupportedInterfaceOrientations (UISplitViewController splitViewController)
		{
			return _SupportedInterfaceOrientations (this, splitViewController);
		}
		/// <param name="splitViewController">The split view controller.</param><summary>Returns the supported interface orientations for <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIInterfaceOrientationMask _SupportedInterfaceOrientations (IUISplitViewControllerDelegate This, UISplitViewController splitViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			UIInterfaceOrientationMask ret;
			ret = (UIInterfaceOrientationMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("splitViewControllerSupportedInterfaceOrientations:"), splitViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			return ret!;
		}
		/// <param name="splitViewController">Designates the split view controller that will be presented onscreen.</param><summary>Returns the preferred user interface orientation to use when presenting <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitViewControllerPreferredInterfaceOrientationForPresentation:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIInterfaceOrientation GetPreferredInterfaceOrientationForPresentation (UISplitViewController splitViewController)
		{
			return _GetPreferredInterfaceOrientationForPresentation (this, splitViewController);
		}
		/// <param name="splitViewController">Designates the split view controller that will be presented onscreen.</param><summary>Returns the preferred user interface orientation to use when presenting <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIInterfaceOrientation _GetPreferredInterfaceOrientationForPresentation (IUISplitViewControllerDelegate This, UISplitViewController splitViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			UIInterfaceOrientation ret;
			ret = (UIInterfaceOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("splitViewControllerPreferredInterfaceOrientationForPresentation:"), splitViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			return ret!;
		}
		/// <param name="svc">The split view controller whose display mode is changing.</param><param name="pc">Specified popover controller.</param><param name="aViewController">Specified view controller.</param><summary>Indicates that the UISplitViewController is about to be presented.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitViewController:popoverController:willPresentViewController:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentViewController (UISplitViewController svc, UIPopoverController pc, UIViewController aViewController)
		{
			_WillPresentViewController (this, svc, pc, aViewController);
		}
		/// <param name="svc">The split view controller whose display mode is changing.</param><param name="pc">Specified popover controller.</param><param name="aViewController">Specified view controller.</param><summary>Indicates that the UISplitViewController is about to be presented.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPresentViewController (IUISplitViewControllerDelegate This, UISplitViewController svc, UIPopoverController pc, UIViewController aViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			var pc__handle__ = pc!.GetNonNullHandle (nameof (pc));
			var aViewController__handle__ = aViewController!.GetNonNullHandle (nameof (aViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("splitViewController:popoverController:willPresentViewController:"), svc__handle__, pc__handle__, aViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
			GC.KeepAlive (pc);
			GC.KeepAlive (aViewController);
		}
		/// <param name="svc">The split view controller whose display mode is changing.</param><param name="aViewController">Specified view controller.</param><param name="barButtonItem">An enumeration of the predefined <see cref="T:UIKit.UIBarButtonItem" />s.</param><param name="pc">Specified popover controller.</param><summary>Indicates that the UISplitViewController is about to be hidden.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitViewController:willHideViewController:withBarButtonItem:forPopoverController:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillHideViewController (UISplitViewController svc, UIViewController aViewController, UIBarButtonItem barButtonItem, UIPopoverController pc)
		{
			_WillHideViewController (this, svc, aViewController, barButtonItem, pc);
		}
		/// <param name="svc">The split view controller whose display mode is changing.</param><param name="aViewController">Specified view controller.</param><param name="barButtonItem">An enumeration of the predefined <see cref="T:UIKit.UIBarButtonItem" />s.</param><param name="pc">Specified popover controller.</param><summary>Indicates that the UISplitViewController is about to be hidden.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillHideViewController (IUISplitViewControllerDelegate This, UISplitViewController svc, UIViewController aViewController, UIBarButtonItem barButtonItem, UIPopoverController pc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			var aViewController__handle__ = aViewController!.GetNonNullHandle (nameof (aViewController));
			var barButtonItem__handle__ = barButtonItem!.GetNonNullHandle (nameof (barButtonItem));
			var pc__handle__ = pc!.GetNonNullHandle (nameof (pc));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("splitViewController:willHideViewController:withBarButtonItem:forPopoverController:"), svc__handle__, aViewController__handle__, barButtonItem__handle__, pc__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
			GC.KeepAlive (aViewController);
			GC.KeepAlive (barButtonItem);
			GC.KeepAlive (pc);
		}
		/// <param name="svc">The split view controller whose display mode is changing.</param><param name="aViewController">Specified view controller.</param><param name="button">An enumeration of the predefined <see cref="T:UIKit.UIBarButtonItem" />s.</param><summary>Indicates that the UISplitViewController is about to be shown.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitViewController:willShowViewController:invalidatingBarButtonItem:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillShowViewController (UISplitViewController svc, UIViewController aViewController, UIBarButtonItem button)
		{
			_WillShowViewController (this, svc, aViewController, button);
		}
		/// <param name="svc">The split view controller whose display mode is changing.</param><param name="aViewController">Specified view controller.</param><param name="button">An enumeration of the predefined <see cref="T:UIKit.UIBarButtonItem" />s.</param><summary>Indicates that the UISplitViewController is about to be shown.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillShowViewController (IUISplitViewControllerDelegate This, UISplitViewController svc, UIViewController aViewController, UIBarButtonItem button)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			var aViewController__handle__ = aViewController!.GetNonNullHandle (nameof (aViewController));
			var button__handle__ = button!.GetNonNullHandle (nameof (button));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("splitViewController:willShowViewController:invalidatingBarButtonItem:"), svc__handle__, aViewController__handle__, button__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
			GC.KeepAlive (aViewController);
			GC.KeepAlive (button);
		}
		/// <param name="svc">The designated split view controller whose action might be triggered.</param><param name="viewController">The specified view controller.</param><param name="inOrientation">The specified orientation.</param><summary>Developers should not use this deprecated method. Developers should use 'UISearchController' instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitViewController:shouldHideViewController:inOrientation:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldHideViewController (UISplitViewController svc, UIViewController viewController, UIInterfaceOrientation inOrientation)
		{
			return _ShouldHideViewController (this, svc, viewController, inOrientation);
		}
		/// <param name="svc">The designated split view controller whose action might be triggered.</param><param name="viewController">The specified view controller.</param><param name="inOrientation">The specified orientation.</param><summary>Developers should not use this deprecated method. Developers should use 'UISearchController' instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldHideViewController (IUISplitViewControllerDelegate This, UISplitViewController svc, UIViewController viewController, UIInterfaceOrientation inOrientation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitViewController:shouldHideViewController:inOrientation:"), svc__handle__, viewController__handle__, (IntPtr) (long) inOrientation);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
			GC.KeepAlive (viewController);
			return ret != 0;
		}
		/// <param name="svc">The split view controller whose display mode is changing.</param><param name="displayMode">TThe new display mode that will be applied.</param><summary>The split view controller <paramref name="svc" /> will change its display mode to <paramref name="displayMode" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitViewController:willChangeToDisplayMode:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillChangeDisplayMode (UISplitViewController svc, UISplitViewControllerDisplayMode displayMode)
		{
			_WillChangeDisplayMode (this, svc, displayMode);
		}
		/// <param name="svc">The split view controller whose display mode is changing.</param><param name="displayMode">TThe new display mode that will be applied.</param><summary>The split view controller <paramref name="svc" /> will change its display mode to <paramref name="displayMode" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillChangeDisplayMode (IUISplitViewControllerDelegate This, UISplitViewController svc, UISplitViewControllerDisplayMode displayMode)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitViewController:willChangeToDisplayMode:"), svc__handle__, (IntPtr) (long) displayMode);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
		}
		/// <param name="svc">Split view controller whose action might be triggered.</param><summary>Returns the display mode for the <paramref name="svc" /> action.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("targetDisplayModeForActionInSplitViewController:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISplitViewControllerDisplayMode GetTargetDisplayModeForAction (UISplitViewController svc)
		{
			return _GetTargetDisplayModeForAction (this, svc);
		}
		/// <param name="svc">Split view controller whose action might be triggered.</param><summary>Returns the display mode for the <paramref name="svc" /> action.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UISplitViewControllerDisplayMode _GetTargetDisplayModeForAction (IUISplitViewControllerDelegate This, UISplitViewController svc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			UISplitViewControllerDisplayMode ret;
			ret = (UISplitViewControllerDisplayMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("targetDisplayModeForActionInSplitViewController:"), svc__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
			return ret!;
		}
		/// <param name="splitViewController">Designates the split view controller that has its primary view being updated.</param><param name="vc">The view controller that is being displayed in the primary position.</param><param name="sender">The action making the request.</param><summary>Shows <paramref name="vc" /> in the primary position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitViewController:showViewController:sender:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool EventShowViewController (UISplitViewController splitViewController, UIViewController vc, NSObject sender)
		{
			return _EventShowViewController (this, splitViewController, vc, sender);
		}
		/// <param name="splitViewController">Designates the split view controller that has its primary view being updated.</param><param name="vc">The view controller that is being displayed in the primary position.</param><param name="sender">The action making the request.</param><summary>Shows <paramref name="vc" /> in the primary position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _EventShowViewController (IUISplitViewControllerDelegate This, UISplitViewController splitViewController, UIViewController vc, NSObject sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			var vc__handle__ = vc!.GetNonNullHandle (nameof (vc));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("splitViewController:showViewController:sender:"), splitViewController__handle__, vc__handle__, sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			GC.KeepAlive (vc);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="splitViewController">Designates the split view controller that has its secondary view being updated.</param><param name="vc">The view controller that is being displayed in the secondary position.</param><param name="sender">The action making the request.</param><summary>Returns true if the delegate will display the detail view itself, rather than relying on <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitViewController:showDetailViewController:sender:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool EventShowDetailViewController (UISplitViewController splitViewController, UIViewController vc, NSObject sender)
		{
			return _EventShowDetailViewController (this, splitViewController, vc, sender);
		}
		/// <param name="splitViewController">Designates the split view controller that has its secondary view being updated.</param><param name="vc">The view controller that is being displayed in the secondary position.</param><param name="sender">The action making the request.</param><summary>Returns true if the delegate will display the detail view itself, rather than relying on <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _EventShowDetailViewController (IUISplitViewControllerDelegate This, UISplitViewController splitViewController, UIViewController vc, NSObject sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			var vc__handle__ = vc!.GetNonNullHandle (nameof (vc));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("splitViewController:showDetailViewController:sender:"), splitViewController__handle__, vc__handle__, sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			GC.KeepAlive (vc);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="splitViewController">Designates the split view controller whose interface is collapsing.</param><summary>Returns the primary view controller for the collapsing view controller <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("primaryViewControllerForCollapsingSplitViewController:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetPrimaryViewControllerForCollapsingSplitViewController (UISplitViewController splitViewController)
		{
			return _GetPrimaryViewControllerForCollapsingSplitViewController (this, splitViewController);
		}
		/// <param name="splitViewController">Designates the split view controller whose interface is collapsing.</param><summary>Returns the primary view controller for the collapsing view controller <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIViewController _GetPrimaryViewControllerForCollapsingSplitViewController (IUISplitViewControllerDelegate This, UISplitViewController splitViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("primaryViewControllerForCollapsingSplitViewController:"), splitViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			return ret!;
		}
		/// <param name="splitViewController">To be added.</param><summary>Returns the primary view controller for the expanding view controller <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("primaryViewControllerForExpandingSplitViewController:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetPrimaryViewControllerForExpandingSplitViewController (UISplitViewController splitViewController)
		{
			return _GetPrimaryViewControllerForExpandingSplitViewController (this, splitViewController);
		}
		/// <param name="splitViewController">To be added.</param><summary>Returns the primary view controller for the expanding view controller <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIViewController _GetPrimaryViewControllerForExpandingSplitViewController (IUISplitViewControllerDelegate This, UISplitViewController splitViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("primaryViewControllerForExpandingSplitViewController:"), splitViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			return ret!;
		}
		/// <param name="splitViewController">Designates the split view controller with the collapsing interface.</param><param name="secondaryViewController">Designates the secondary view controller for the split view interface.</param><param name="primaryViewController">Designates the primary view controller for the split view interface.</param><summary>Collapses the secondary view controller on <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitViewController:collapseSecondaryViewController:ontoPrimaryViewController:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CollapseSecondViewController (UISplitViewController splitViewController, UIViewController secondaryViewController, UIViewController primaryViewController)
		{
			return _CollapseSecondViewController (this, splitViewController, secondaryViewController, primaryViewController);
		}
		/// <param name="splitViewController">Designates the split view controller with the collapsing interface.</param><param name="secondaryViewController">Designates the secondary view controller for the split view interface.</param><param name="primaryViewController">Designates the primary view controller for the split view interface.</param><summary>Collapses the secondary view controller on <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CollapseSecondViewController (IUISplitViewControllerDelegate This, UISplitViewController splitViewController, UIViewController secondaryViewController, UIViewController primaryViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			var secondaryViewController__handle__ = secondaryViewController!.GetNonNullHandle (nameof (secondaryViewController));
			var primaryViewController__handle__ = primaryViewController!.GetNonNullHandle (nameof (primaryViewController));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("splitViewController:collapseSecondaryViewController:ontoPrimaryViewController:"), splitViewController__handle__, secondaryViewController__handle__, primaryViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			GC.KeepAlive (secondaryViewController);
			GC.KeepAlive (primaryViewController);
			return ret != 0;
		}
		/// <param name="splitViewController">The split view controller with the expanding interface.</param><param name="primaryViewController">Primary view controller specified for the expanded split view interface.</param><summary>Returns a new secondary view controller to use in split-view mode, or nil to use the default.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitViewController:separateSecondaryViewControllerFromPrimaryViewController:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController SeparateSecondaryViewController (UISplitViewController splitViewController, UIViewController primaryViewController)
		{
			return _SeparateSecondaryViewController (this, splitViewController, primaryViewController);
		}
		/// <param name="splitViewController">The split view controller with the expanding interface.</param><param name="primaryViewController">Primary view controller specified for the expanded split view interface.</param><summary>Returns a new secondary view controller to use in split-view mode, or nil to use the default.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIViewController _SeparateSecondaryViewController (IUISplitViewControllerDelegate This, UISplitViewController splitViewController, UIViewController primaryViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			var primaryViewController__handle__ = primaryViewController!.GetNonNullHandle (nameof (primaryViewController));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("splitViewController:separateSecondaryViewControllerFromPrimaryViewController:"), splitViewController__handle__, primaryViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			GC.KeepAlive (primaryViewController);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("splitViewController:topColumnForCollapsingToProposedTopColumn:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISplitViewControllerColumn GetTopColumnForCollapsing (UISplitViewController splitViewController, UISplitViewControllerColumn proposedTopColumn)
		{
			return _GetTopColumnForCollapsing (this, splitViewController, proposedTopColumn);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UISplitViewControllerColumn _GetTopColumnForCollapsing (IUISplitViewControllerDelegate This, UISplitViewController splitViewController, UISplitViewControllerColumn proposedTopColumn)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			UISplitViewControllerColumn ret;
			ret = (UISplitViewControllerColumn) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitViewController:topColumnForCollapsingToProposedTopColumn:"), splitViewController__handle__, (IntPtr) (long) proposedTopColumn);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("splitViewController:displayModeForExpandingToProposedDisplayMode:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISplitViewControllerDisplayMode GetDisplayModeForExpanding (UISplitViewController splitViewController, UISplitViewControllerDisplayMode proposedDisplayMode)
		{
			return _GetDisplayModeForExpanding (this, splitViewController, proposedDisplayMode);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UISplitViewControllerDisplayMode _GetDisplayModeForExpanding (IUISplitViewControllerDelegate This, UISplitViewController splitViewController, UISplitViewControllerDisplayMode proposedDisplayMode)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			UISplitViewControllerDisplayMode ret;
			ret = (UISplitViewControllerDisplayMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitViewController:displayModeForExpandingToProposedDisplayMode:"), splitViewController__handle__, (IntPtr) (long) proposedDisplayMode);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("splitViewControllerDidCollapse:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCollapse (UISplitViewController splitViewController)
		{
			_DidCollapse (this, splitViewController);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCollapse (IUISplitViewControllerDelegate This, UISplitViewController splitViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("splitViewControllerDidCollapse:"), splitViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
		}
		[global::Foundation.OptionalMember]
		[Export ("splitViewControllerDidExpand:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidExpand (UISplitViewController splitViewController)
		{
			_DidExpand (this, splitViewController);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidExpand (IUISplitViewControllerDelegate This, UISplitViewController splitViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("splitViewControllerDidExpand:"), splitViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
		}
		[global::Foundation.OptionalMember]
		[Export ("splitViewController:willShowColumn:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillShowColumn (UISplitViewController splitViewController, UISplitViewControllerColumn column)
		{
			_WillShowColumn (this, splitViewController, column);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillShowColumn (IUISplitViewControllerDelegate This, UISplitViewController splitViewController, UISplitViewControllerColumn column)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitViewController:willShowColumn:"), splitViewController__handle__, (IntPtr) (long) column);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
		}
		[global::Foundation.OptionalMember]
		[Export ("splitViewController:willHideColumn:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillHideColumn (UISplitViewController splitViewController, UISplitViewControllerColumn column)
		{
			_WillHideColumn (this, splitViewController, column);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillHideColumn (IUISplitViewControllerDelegate This, UISplitViewController splitViewController, UISplitViewControllerColumn column)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitViewController:willHideColumn:"), splitViewController__handle__, (IntPtr) (long) column);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
		}
		[global::Foundation.OptionalMember]
		[Export ("splitViewControllerInteractivePresentationGestureWillBegin:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InteractivePresentationGestureWillBegin (UISplitViewController svc)
		{
			_InteractivePresentationGestureWillBegin (this, svc);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InteractivePresentationGestureWillBegin (IUISplitViewControllerDelegate This, UISplitViewController svc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("splitViewControllerInteractivePresentationGestureWillBegin:"), svc__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
		}
		[global::Foundation.OptionalMember]
		[Export ("splitViewControllerInteractivePresentationGestureDidEnd:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InteractivePresentationGestureDidEnd (UISplitViewController svc)
		{
			_InteractivePresentationGestureDidEnd (this, svc);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InteractivePresentationGestureDidEnd (IUISplitViewControllerDelegate This, UISplitViewController svc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("splitViewControllerInteractivePresentationGestureDidEnd:"), svc__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
		}
		[global::Foundation.OptionalMember]
		[Export ("splitViewController:didShowColumn:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidShowColumn (UISplitViewController svc, UISplitViewControllerColumn column)
		{
			_DidShowColumn (this, svc, column);
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidShowColumn (IUISplitViewControllerDelegate This, UISplitViewController svc, UISplitViewControllerColumn column)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitViewController:didShowColumn:"), svc__handle__, (IntPtr) (long) column);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
		}
		[global::Foundation.OptionalMember]
		[Export ("splitViewController:didHideColumn:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidHideColumn (UISplitViewController svc, UISplitViewControllerColumn column)
		{
			_DidHideColumn (this, svc, column);
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidHideColumn (IUISplitViewControllerDelegate This, UISplitViewController svc, UISplitViewControllerColumn column)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitViewController:didHideColumn:"), svc__handle__, (IntPtr) (long) column);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
		}
		[DynamicDependencyAttribute ("CollapseSecondViewController(UIKit.UISplitViewController,UIKit.UIViewController,UIKit.UIViewController)")]
		[DynamicDependencyAttribute ("DidCollapse(UIKit.UISplitViewController)")]
		[DynamicDependencyAttribute ("DidExpand(UIKit.UISplitViewController)")]
		[DynamicDependencyAttribute ("DidHideColumn(UIKit.UISplitViewController,UIKit.UISplitViewControllerColumn)")]
		[DynamicDependencyAttribute ("DidShowColumn(UIKit.UISplitViewController,UIKit.UISplitViewControllerColumn)")]
		[DynamicDependencyAttribute ("EventShowDetailViewController(UIKit.UISplitViewController,UIKit.UIViewController,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("EventShowViewController(UIKit.UISplitViewController,UIKit.UIViewController,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("GetDisplayModeForExpanding(UIKit.UISplitViewController,UIKit.UISplitViewControllerDisplayMode)")]
		[DynamicDependencyAttribute ("GetPreferredInterfaceOrientationForPresentation(UIKit.UISplitViewController)")]
		[DynamicDependencyAttribute ("GetPrimaryViewControllerForCollapsingSplitViewController(UIKit.UISplitViewController)")]
		[DynamicDependencyAttribute ("GetPrimaryViewControllerForExpandingSplitViewController(UIKit.UISplitViewController)")]
		[DynamicDependencyAttribute ("GetTargetDisplayModeForAction(UIKit.UISplitViewController)")]
		[DynamicDependencyAttribute ("GetTopColumnForCollapsing(UIKit.UISplitViewController,UIKit.UISplitViewControllerColumn)")]
		[DynamicDependencyAttribute ("InteractivePresentationGestureDidEnd(UIKit.UISplitViewController)")]
		[DynamicDependencyAttribute ("InteractivePresentationGestureWillBegin(UIKit.UISplitViewController)")]
		[DynamicDependencyAttribute ("SeparateSecondaryViewController(UIKit.UISplitViewController,UIKit.UIViewController)")]
		[DynamicDependencyAttribute ("ShouldHideViewController(UIKit.UISplitViewController,UIKit.UIViewController,UIKit.UIInterfaceOrientation)")]
		[DynamicDependencyAttribute ("SupportedInterfaceOrientations(UIKit.UISplitViewController)")]
		[DynamicDependencyAttribute ("WillChangeDisplayMode(UIKit.UISplitViewController,UIKit.UISplitViewControllerDisplayMode)")]
		[DynamicDependencyAttribute ("WillHideColumn(UIKit.UISplitViewController,UIKit.UISplitViewControllerColumn)")]
		[DynamicDependencyAttribute ("WillHideViewController(UIKit.UISplitViewController,UIKit.UIViewController,UIKit.UIBarButtonItem,UIKit.UIPopoverController)")]
		[DynamicDependencyAttribute ("WillPresentViewController(UIKit.UISplitViewController,UIKit.UIPopoverController,UIKit.UIViewController)")]
		[DynamicDependencyAttribute ("WillShowColumn(UIKit.UISplitViewController,UIKit.UISplitViewControllerColumn)")]
		[DynamicDependencyAttribute ("WillShowViewController(UIKit.UISplitViewController,UIKit.UIViewController,UIKit.UIBarButtonItem)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISplitViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUISplitViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUISplitViewControllerDelegate" /> interface to support all the methods from the UISplitViewControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUISplitViewControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UISplitViewControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UISplitViewControllerDelegate_Extensions {
		/// <param name="splitViewController">The split view controller.</param><summary>Returns the supported interface orientations for <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIInterfaceOrientationMask SupportedInterfaceOrientations (this IUISplitViewControllerDelegate This, UISplitViewController splitViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			UIInterfaceOrientationMask ret;
			ret = (UIInterfaceOrientationMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("splitViewControllerSupportedInterfaceOrientations:"), splitViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			return ret!;
		}
		/// <param name="splitViewController">Designates the split view controller that will be presented onscreen.</param><summary>Returns the preferred user interface orientation to use when presenting <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIInterfaceOrientation GetPreferredInterfaceOrientationForPresentation (this IUISplitViewControllerDelegate This, UISplitViewController splitViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			UIInterfaceOrientation ret;
			ret = (UIInterfaceOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("splitViewControllerPreferredInterfaceOrientationForPresentation:"), splitViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			return ret!;
		}
		/// <param name="svc">The split view controller whose display mode is changing.</param><param name="pc">Specified popover controller.</param><param name="aViewController">Specified view controller.</param><summary>Indicates that the UISplitViewController is about to be presented.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresentViewController (this IUISplitViewControllerDelegate This, UISplitViewController svc, UIPopoverController pc, UIViewController aViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			var pc__handle__ = pc!.GetNonNullHandle (nameof (pc));
			var aViewController__handle__ = aViewController!.GetNonNullHandle (nameof (aViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("splitViewController:popoverController:willPresentViewController:"), svc__handle__, pc__handle__, aViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
			GC.KeepAlive (pc);
			GC.KeepAlive (aViewController);
		}
		/// <param name="svc">The split view controller whose display mode is changing.</param><param name="aViewController">Specified view controller.</param><param name="barButtonItem">An enumeration of the predefined <see cref="T:UIKit.UIBarButtonItem" />s.</param><param name="pc">Specified popover controller.</param><summary>Indicates that the UISplitViewController is about to be hidden.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillHideViewController (this IUISplitViewControllerDelegate This, UISplitViewController svc, UIViewController aViewController, UIBarButtonItem barButtonItem, UIPopoverController pc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			var aViewController__handle__ = aViewController!.GetNonNullHandle (nameof (aViewController));
			var barButtonItem__handle__ = barButtonItem!.GetNonNullHandle (nameof (barButtonItem));
			var pc__handle__ = pc!.GetNonNullHandle (nameof (pc));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("splitViewController:willHideViewController:withBarButtonItem:forPopoverController:"), svc__handle__, aViewController__handle__, barButtonItem__handle__, pc__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
			GC.KeepAlive (aViewController);
			GC.KeepAlive (barButtonItem);
			GC.KeepAlive (pc);
		}
		/// <param name="svc">The split view controller whose display mode is changing.</param><param name="aViewController">Specified view controller.</param><param name="button">An enumeration of the predefined <see cref="T:UIKit.UIBarButtonItem" />s.</param><summary>Indicates that the UISplitViewController is about to be shown.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillShowViewController (this IUISplitViewControllerDelegate This, UISplitViewController svc, UIViewController aViewController, UIBarButtonItem button)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			var aViewController__handle__ = aViewController!.GetNonNullHandle (nameof (aViewController));
			var button__handle__ = button!.GetNonNullHandle (nameof (button));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("splitViewController:willShowViewController:invalidatingBarButtonItem:"), svc__handle__, aViewController__handle__, button__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
			GC.KeepAlive (aViewController);
			GC.KeepAlive (button);
		}
		/// <param name="svc">The designated split view controller whose action might be triggered.</param><param name="viewController">The specified view controller.</param><param name="inOrientation">The specified orientation.</param><summary>Developers should not use this deprecated method. Developers should use 'UISearchController' instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldHideViewController (this IUISplitViewControllerDelegate This, UISplitViewController svc, UIViewController viewController, UIInterfaceOrientation inOrientation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitViewController:shouldHideViewController:inOrientation:"), svc__handle__, viewController__handle__, (IntPtr) (long) inOrientation);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
			GC.KeepAlive (viewController);
			return ret != 0;
		}
		/// <param name="svc">The split view controller whose display mode is changing.</param><param name="displayMode">TThe new display mode that will be applied.</param><summary>The split view controller <paramref name="svc" /> will change its display mode to <paramref name="displayMode" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillChangeDisplayMode (this IUISplitViewControllerDelegate This, UISplitViewController svc, UISplitViewControllerDisplayMode displayMode)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitViewController:willChangeToDisplayMode:"), svc__handle__, (IntPtr) (long) displayMode);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
		}
		/// <param name="svc">Split view controller whose action might be triggered.</param><summary>Returns the display mode for the <paramref name="svc" /> action.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UISplitViewControllerDisplayMode GetTargetDisplayModeForAction (this IUISplitViewControllerDelegate This, UISplitViewController svc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			UISplitViewControllerDisplayMode ret;
			ret = (UISplitViewControllerDisplayMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("targetDisplayModeForActionInSplitViewController:"), svc__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
			return ret!;
		}
		/// <param name="splitViewController">Designates the split view controller that has its primary view being updated.</param><param name="vc">The view controller that is being displayed in the primary position.</param><param name="sender">The action making the request.</param><summary>Shows <paramref name="vc" /> in the primary position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool EventShowViewController (this IUISplitViewControllerDelegate This, UISplitViewController splitViewController, UIViewController vc, NSObject sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			var vc__handle__ = vc!.GetNonNullHandle (nameof (vc));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("splitViewController:showViewController:sender:"), splitViewController__handle__, vc__handle__, sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			GC.KeepAlive (vc);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="splitViewController">Designates the split view controller that has its secondary view being updated.</param><param name="vc">The view controller that is being displayed in the secondary position.</param><param name="sender">The action making the request.</param><summary>Returns true if the delegate will display the detail view itself, rather than relying on <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool EventShowDetailViewController (this IUISplitViewControllerDelegate This, UISplitViewController splitViewController, UIViewController vc, NSObject sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			var vc__handle__ = vc!.GetNonNullHandle (nameof (vc));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("splitViewController:showDetailViewController:sender:"), splitViewController__handle__, vc__handle__, sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			GC.KeepAlive (vc);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="splitViewController">Designates the split view controller whose interface is collapsing.</param><summary>Returns the primary view controller for the collapsing view controller <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIViewController GetPrimaryViewControllerForCollapsingSplitViewController (this IUISplitViewControllerDelegate This, UISplitViewController splitViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("primaryViewControllerForCollapsingSplitViewController:"), splitViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			return ret!;
		}
		/// <param name="splitViewController">To be added.</param><summary>Returns the primary view controller for the expanding view controller <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIViewController GetPrimaryViewControllerForExpandingSplitViewController (this IUISplitViewControllerDelegate This, UISplitViewController splitViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("primaryViewControllerForExpandingSplitViewController:"), splitViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			return ret!;
		}
		/// <param name="splitViewController">Designates the split view controller with the collapsing interface.</param><param name="secondaryViewController">Designates the secondary view controller for the split view interface.</param><param name="primaryViewController">Designates the primary view controller for the split view interface.</param><summary>Collapses the secondary view controller on <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CollapseSecondViewController (this IUISplitViewControllerDelegate This, UISplitViewController splitViewController, UIViewController secondaryViewController, UIViewController primaryViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			var secondaryViewController__handle__ = secondaryViewController!.GetNonNullHandle (nameof (secondaryViewController));
			var primaryViewController__handle__ = primaryViewController!.GetNonNullHandle (nameof (primaryViewController));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("splitViewController:collapseSecondaryViewController:ontoPrimaryViewController:"), splitViewController__handle__, secondaryViewController__handle__, primaryViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			GC.KeepAlive (secondaryViewController);
			GC.KeepAlive (primaryViewController);
			return ret != 0;
		}
		/// <param name="splitViewController">The split view controller with the expanding interface.</param><param name="primaryViewController">Primary view controller specified for the expanded split view interface.</param><summary>Returns a new secondary view controller to use in split-view mode, or nil to use the default.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIViewController SeparateSecondaryViewController (this IUISplitViewControllerDelegate This, UISplitViewController splitViewController, UIViewController primaryViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			var primaryViewController__handle__ = primaryViewController!.GetNonNullHandle (nameof (primaryViewController));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("splitViewController:separateSecondaryViewControllerFromPrimaryViewController:"), splitViewController__handle__, primaryViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			GC.KeepAlive (primaryViewController);
			return ret!;
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UISplitViewControllerColumn GetTopColumnForCollapsing (this IUISplitViewControllerDelegate This, UISplitViewController splitViewController, UISplitViewControllerColumn proposedTopColumn)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			UISplitViewControllerColumn ret;
			ret = (UISplitViewControllerColumn) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitViewController:topColumnForCollapsingToProposedTopColumn:"), splitViewController__handle__, (IntPtr) (long) proposedTopColumn);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			return ret!;
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UISplitViewControllerDisplayMode GetDisplayModeForExpanding (this IUISplitViewControllerDelegate This, UISplitViewController splitViewController, UISplitViewControllerDisplayMode proposedDisplayMode)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			UISplitViewControllerDisplayMode ret;
			ret = (UISplitViewControllerDisplayMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitViewController:displayModeForExpandingToProposedDisplayMode:"), splitViewController__handle__, (IntPtr) (long) proposedDisplayMode);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			return ret!;
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCollapse (this IUISplitViewControllerDelegate This, UISplitViewController splitViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("splitViewControllerDidCollapse:"), splitViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidExpand (this IUISplitViewControllerDelegate This, UISplitViewController splitViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("splitViewControllerDidExpand:"), splitViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillShowColumn (this IUISplitViewControllerDelegate This, UISplitViewController splitViewController, UISplitViewControllerColumn column)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitViewController:willShowColumn:"), splitViewController__handle__, (IntPtr) (long) column);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillHideColumn (this IUISplitViewControllerDelegate This, UISplitViewController splitViewController, UISplitViewControllerColumn column)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitViewController:willHideColumn:"), splitViewController__handle__, (IntPtr) (long) column);
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InteractivePresentationGestureWillBegin (this IUISplitViewControllerDelegate This, UISplitViewController svc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("splitViewControllerInteractivePresentationGestureWillBegin:"), svc__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InteractivePresentationGestureDidEnd (this IUISplitViewControllerDelegate This, UISplitViewController svc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("splitViewControllerInteractivePresentationGestureDidEnd:"), svc__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidShowColumn (this IUISplitViewControllerDelegate This, UISplitViewController svc, UISplitViewControllerColumn column)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitViewController:didShowColumn:"), svc__handle__, (IntPtr) (long) column);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidHideColumn (this IUISplitViewControllerDelegate This, UISplitViewController svc, UISplitViewControllerColumn column)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var svc__handle__ = svc!.GetNonNullHandle (nameof (svc));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitViewController:didHideColumn:"), svc__handle__, (IntPtr) (long) column);
			GC.KeepAlive (This);
			GC.KeepAlive (svc);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UISplitViewControllerDelegateWrapper : BaseWrapper, IUISplitViewControllerDelegate {
		public UISplitViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISplitViewControllerDelegateWrapper))]
		static UISplitViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUISplitViewControllerDelegate" /> (for the protocol <c>UISplitViewControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUISplitViewControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UISplitViewControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UISplitViewControllerDelegate : NSObject, IUISplitViewControllerDelegate {
		/// <summary>Creates a new <see cref="UISplitViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UISplitViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected UISplitViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal UISplitViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="splitViewController">Designates the split view controller with the collapsing interface.</param><param name="secondaryViewController">Designates the secondary view controller for the split view interface.</param><param name="primaryViewController">Designates the primary view controller for the split view interface.</param><summary>Collapses the secondary view controller on <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitViewController:collapseSecondaryViewController:ontoPrimaryViewController:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CollapseSecondViewController (UISplitViewController splitViewController, UIViewController secondaryViewController, UIViewController primaryViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("splitViewControllerDidCollapse:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCollapse (UISplitViewController splitViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("splitViewControllerDidExpand:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidExpand (UISplitViewController splitViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("splitViewController:didHideColumn:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidHideColumn (UISplitViewController svc, UISplitViewControllerColumn column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("splitViewController:didShowColumn:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidShowColumn (UISplitViewController svc, UISplitViewControllerColumn column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="splitViewController">Designates the split view controller that has its secondary view being updated.</param><param name="vc">The view controller that is being displayed in the secondary position.</param><param name="sender">The action making the request.</param><summary>Returns true if the delegate will display the detail view itself, rather than relying on <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitViewController:showDetailViewController:sender:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool EventShowDetailViewController (UISplitViewController splitViewController, UIViewController vc, NSObject sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="splitViewController">Designates the split view controller that has its primary view being updated.</param><param name="vc">The view controller that is being displayed in the primary position.</param><param name="sender">The action making the request.</param><summary>Shows <paramref name="vc" /> in the primary position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitViewController:showViewController:sender:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool EventShowViewController (UISplitViewController splitViewController, UIViewController vc, NSObject sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("splitViewController:displayModeForExpandingToProposedDisplayMode:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISplitViewControllerDisplayMode GetDisplayModeForExpanding (UISplitViewController splitViewController, UISplitViewControllerDisplayMode proposedDisplayMode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="splitViewController">Designates the split view controller that will be presented onscreen.</param><summary>Returns the preferred user interface orientation to use when presenting <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitViewControllerPreferredInterfaceOrientationForPresentation:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIInterfaceOrientation GetPreferredInterfaceOrientationForPresentation (UISplitViewController splitViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="splitViewController">Designates the split view controller whose interface is collapsing.</param><summary>Returns the primary view controller for the collapsing view controller <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("primaryViewControllerForCollapsingSplitViewController:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetPrimaryViewControllerForCollapsingSplitViewController (UISplitViewController splitViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="splitViewController">To be added.</param><summary>Returns the primary view controller for the expanding view controller <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("primaryViewControllerForExpandingSplitViewController:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetPrimaryViewControllerForExpandingSplitViewController (UISplitViewController splitViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="svc">Split view controller whose action might be triggered.</param><summary>Returns the display mode for the <paramref name="svc" /> action.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("targetDisplayModeForActionInSplitViewController:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISplitViewControllerDisplayMode GetTargetDisplayModeForAction (UISplitViewController svc)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("splitViewController:topColumnForCollapsingToProposedTopColumn:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISplitViewControllerColumn GetTopColumnForCollapsing (UISplitViewController splitViewController, UISplitViewControllerColumn proposedTopColumn)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("splitViewControllerInteractivePresentationGestureDidEnd:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InteractivePresentationGestureDidEnd (UISplitViewController svc)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("splitViewControllerInteractivePresentationGestureWillBegin:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InteractivePresentationGestureWillBegin (UISplitViewController svc)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="splitViewController">The split view controller with the expanding interface.</param><param name="primaryViewController">Primary view controller specified for the expanded split view interface.</param><summary>Returns a new secondary view controller to use in split-view mode, or nil to use the default.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitViewController:separateSecondaryViewControllerFromPrimaryViewController:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController SeparateSecondaryViewController (UISplitViewController splitViewController, UIViewController primaryViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="svc">The designated split view controller whose action might be triggered.</param><param name="viewController">The specified view controller.</param><param name="inOrientation">The specified orientation.</param><summary>Developers should not use this deprecated method. Developers should use 'UISearchController' instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitViewController:shouldHideViewController:inOrientation:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldHideViewController (UISplitViewController svc, UIViewController viewController, UIInterfaceOrientation inOrientation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="splitViewController">The split view controller.</param><summary>Returns the supported interface orientations for <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitViewControllerSupportedInterfaceOrientations:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIInterfaceOrientationMask SupportedInterfaceOrientations (UISplitViewController splitViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="svc">The split view controller whose display mode is changing.</param><param name="displayMode">TThe new display mode that will be applied.</param><summary>The split view controller <paramref name="svc" /> will change its display mode to <paramref name="displayMode" />.</summary><remarks>To be added.</remarks>
		[Export ("splitViewController:willChangeToDisplayMode:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillChangeDisplayMode (UISplitViewController svc, UISplitViewControllerDisplayMode displayMode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("splitViewController:willHideColumn:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillHideColumn (UISplitViewController splitViewController, UISplitViewControllerColumn column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="svc">The split view controller whose display mode is changing.</param><param name="aViewController">Specified view controller.</param><param name="barButtonItem">An enumeration of the predefined <see cref="T:UIKit.UIBarButtonItem" />s.</param><param name="pc">Specified popover controller.</param><summary>Indicates that the UISplitViewController is about to be hidden.</summary><remarks>To be added.</remarks>
		[Export ("splitViewController:willHideViewController:withBarButtonItem:forPopoverController:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillHideViewController (UISplitViewController svc, UIViewController aViewController, UIBarButtonItem barButtonItem, UIPopoverController pc)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="svc">The split view controller whose display mode is changing.</param><param name="pc">Specified popover controller.</param><param name="aViewController">Specified view controller.</param><summary>Indicates that the UISplitViewController is about to be presented.</summary><remarks>To be added.</remarks>
		[Export ("splitViewController:popoverController:willPresentViewController:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentViewController (UISplitViewController svc, UIPopoverController pc, UIViewController aViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("splitViewController:willShowColumn:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillShowColumn (UISplitViewController splitViewController, UISplitViewControllerColumn column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="svc">The split view controller whose display mode is changing.</param><param name="aViewController">Specified view controller.</param><param name="button">An enumeration of the predefined <see cref="T:UIKit.UIBarButtonItem" />s.</param><summary>Indicates that the UISplitViewController is about to be shown.</summary><remarks>To be added.</remarks>
		[Export ("splitViewController:willShowViewController:invalidatingBarButtonItem:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UISearchController' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillShowViewController (UISplitViewController svc, UIViewController aViewController, UIBarButtonItem button)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UISplitViewControllerDelegate */
}
