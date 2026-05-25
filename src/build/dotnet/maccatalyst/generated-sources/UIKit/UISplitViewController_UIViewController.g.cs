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
	/// <summary>Defines extension methods on <see cref="T:UIKit.UIViewController" /> relating to collapsing/expanding secondary view controllers.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class UISplitViewController_UIViewController  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIViewController");
		/// <param name="This">The instance on which this method operates.</param><param name="secondaryViewController">To be added.</param><param name="splitViewController">To be added.</param><summary>Collapses the secondary view controller on <paramref name="splitViewController" /></summary><remarks>To be added.</remarks>
		[Export ("collapseSecondaryViewController:forSplitViewController:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CollapseSecondaryViewController (this UIViewController This, UIViewController secondaryViewController, UISplitViewController splitViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var secondaryViewController__handle__ = secondaryViewController!.GetNonNullHandle (nameof (secondaryViewController));
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collapseSecondaryViewController:forSplitViewController:"), secondaryViewController__handle__, splitViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (secondaryViewController);
			GC.KeepAlive (splitViewController);
		}
		/// <summary>Returns te split view controller for the nested view controller.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("splitViewController")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UISplitViewController? GetSplitViewController (this UIViewController This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UISplitViewController ret;
			ret =  Runtime.GetNSObject<UISplitViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("splitViewController")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="splitViewController">To be added.</param><summary>Returns the separate secondary view controller for <paramref name="splitViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("separateSecondaryViewControllerForSplitViewController:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIViewController SeparateSecondaryViewControllerForSplitViewController (this UIViewController This, UISplitViewController splitViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var splitViewController__handle__ = splitViewController!.GetNonNullHandle (nameof (splitViewController));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("separateSecondaryViewControllerForSplitViewController:"), splitViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (splitViewController);
			return ret!;
		}
	} /* class UISplitViewController_UIViewController */
}
