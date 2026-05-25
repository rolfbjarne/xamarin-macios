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
	/// <summary>A class used to receive notifications from the UISearchDisplayController.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UISearchDisplayDelegate_Protocol/index.html">Apple documentation for <c>UISearchDisplayDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UISearchDisplayDelegate", WrapperType = typeof (UISearchDisplayDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginSearch", Selector = "searchDisplayControllerWillBeginSearch:", ParameterType = new Type [] { typeof (UISearchDisplayController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBeginSearch", Selector = "searchDisplayControllerDidBeginSearch:", ParameterType = new Type [] { typeof (UISearchDisplayController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEndSearch", Selector = "searchDisplayControllerWillEndSearch:", ParameterType = new Type [] { typeof (UISearchDisplayController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndSearch", Selector = "searchDisplayControllerDidEndSearch:", ParameterType = new Type [] { typeof (UISearchDisplayController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidLoadSearchResults", Selector = "searchDisplayController:didLoadSearchResultsTableView:", ParameterType = new Type [] { typeof (UISearchDisplayController), typeof (UITableView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillUnloadSearchResults", Selector = "searchDisplayController:willUnloadSearchResultsTableView:", ParameterType = new Type [] { typeof (UISearchDisplayController), typeof (UITableView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillShowSearchResults", Selector = "searchDisplayController:willShowSearchResultsTableView:", ParameterType = new Type [] { typeof (UISearchDisplayController), typeof (UITableView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidShowSearchResults", Selector = "searchDisplayController:didShowSearchResultsTableView:", ParameterType = new Type [] { typeof (UISearchDisplayController), typeof (UITableView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillHideSearchResults", Selector = "searchDisplayController:willHideSearchResultsTableView:", ParameterType = new Type [] { typeof (UISearchDisplayController), typeof (UITableView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidHideSearchResults", Selector = "searchDisplayController:didHideSearchResultsTableView:", ParameterType = new Type [] { typeof (UISearchDisplayController), typeof (UITableView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReloadForSearchString", Selector = "searchDisplayController:shouldReloadTableForSearchString:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UISearchDisplayController), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReloadForSearchScope", Selector = "searchDisplayController:shouldReloadTableForSearchScope:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UISearchDisplayController), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUISearchDisplayDelegate : INativeObject, IDisposable
	{
		/// <param name="controller">To be added.</param><summary>Indicates that searching is about to start.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchDisplayControllerWillBeginSearch:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginSearch (UISearchDisplayController controller)
		{
			_WillBeginSearch (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that searching is about to start.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillBeginSearch (IUISearchDisplayDelegate This, UISearchDisplayController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayControllerWillBeginSearch:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchDisplayControllerDidBeginSearch:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginSearch (UISearchDisplayController controller)
		{
			_DidBeginSearch (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBeginSearch (IUISearchDisplayDelegate This, UISearchDisplayController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayControllerDidBeginSearch:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that search is about to finish.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchDisplayControllerWillEndSearch:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEndSearch (UISearchDisplayController controller)
		{
			_WillEndSearch (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that search is about to finish.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillEndSearch (IUISearchDisplayDelegate This, UISearchDisplayController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayControllerWillEndSearch:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that searching has ended.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchDisplayControllerDidEndSearch:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndSearch (UISearchDisplayController controller)
		{
			_DidEndSearch (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that searching has ended.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEndSearch (IUISearchDisplayDelegate This, UISearchDisplayController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayControllerDidEndSearch:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller has loaded its UITableView of results.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchDisplayController:didLoadSearchResultsTableView:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoadSearchResults (UISearchDisplayController controller, UITableView tableView)
		{
			_DidLoadSearchResults (this, controller, tableView);
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller has loaded its UITableView of results.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidLoadSearchResults (IUISearchDisplayDelegate This, UISearchDisplayController controller, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayController:didLoadSearchResultsTableView:"), controller__handle__, tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (tableView);
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller is about to unload its UITableView of results.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchDisplayController:willUnloadSearchResultsTableView:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillUnloadSearchResults (UISearchDisplayController controller, UITableView tableView)
		{
			_WillUnloadSearchResults (this, controller, tableView);
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller is about to unload its UITableView of results.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillUnloadSearchResults (IUISearchDisplayDelegate This, UISearchDisplayController controller, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayController:willUnloadSearchResultsTableView:"), controller__handle__, tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (tableView);
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller is about to show its UITableView of results.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchDisplayController:willShowSearchResultsTableView:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillShowSearchResults (UISearchDisplayController controller, UITableView tableView)
		{
			_WillShowSearchResults (this, controller, tableView);
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller is about to show its UITableView of results.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillShowSearchResults (IUISearchDisplayDelegate This, UISearchDisplayController controller, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayController:willShowSearchResultsTableView:"), controller__handle__, tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (tableView);
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller has begun displayed its UITableView of results.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchDisplayController:didShowSearchResultsTableView:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidShowSearchResults (UISearchDisplayController controller, UITableView tableView)
		{
			_DidShowSearchResults (this, controller, tableView);
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller has begun displayed its UITableView of results.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidShowSearchResults (IUISearchDisplayDelegate This, UISearchDisplayController controller, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayController:didShowSearchResultsTableView:"), controller__handle__, tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (tableView);
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller is about to hide its UITableView of results.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchDisplayController:willHideSearchResultsTableView:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillHideSearchResults (UISearchDisplayController controller, UITableView tableView)
		{
			_WillHideSearchResults (this, controller, tableView);
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller is about to hide its UITableView of results.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillHideSearchResults (IUISearchDisplayDelegate This, UISearchDisplayController controller, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayController:willHideSearchResultsTableView:"), controller__handle__, tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (tableView);
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller hid its table view of results.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchDisplayController:didHideSearchResultsTableView:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidHideSearchResults (UISearchDisplayController controller, UITableView tableView)
		{
			_DidHideSearchResults (this, controller, tableView);
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller hid its table view of results.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidHideSearchResults (IUISearchDisplayDelegate This, UISearchDisplayController controller, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayController:didHideSearchResultsTableView:"), controller__handle__, tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (tableView);
		}
		/// <param name="controller">To be added.</param><param name="forSearchString">To be added.</param><summary>Whether data should be reloaded, given the change in search string.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchDisplayController:shouldReloadTableForSearchString:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReloadForSearchString (UISearchDisplayController controller, string forSearchString)
		{
			return _ShouldReloadForSearchString (this, controller, forSearchString);
		}
		/// <param name="controller">To be added.</param><param name="forSearchString">To be added.</param><summary>Whether data should be reloaded, given the change in search string.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldReloadForSearchString (IUISearchDisplayDelegate This, UISearchDisplayController controller, string forSearchString)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (forSearchString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forSearchString));
			var nsforSearchString = CFString.CreateNative (forSearchString);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayController:shouldReloadTableForSearchString:"), controller__handle__, nsforSearchString);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			CFString.ReleaseNative (nsforSearchString);
			return ret != 0;
		}
		/// <param name="controller">To be added.</param><param name="forSearchOption">To be added.</param><summary>Whether the results table view should be reloaded for a given scope.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchDisplayController:shouldReloadTableForSearchScope:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReloadForSearchScope (UISearchDisplayController controller, nint forSearchOption)
		{
			return _ShouldReloadForSearchScope (this, controller, forSearchOption);
		}
		/// <param name="controller">To be added.</param><param name="forSearchOption">To be added.</param><summary>Whether the results table view should be reloaded for a given scope.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldReloadForSearchScope (IUISearchDisplayDelegate This, UISearchDisplayController controller, nint forSearchOption)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("searchDisplayController:shouldReloadTableForSearchScope:"), controller__handle__, forSearchOption);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("DidBeginSearch(UIKit.UISearchDisplayController)")]
		[DynamicDependencyAttribute ("DidEndSearch(UIKit.UISearchDisplayController)")]
		[DynamicDependencyAttribute ("DidHideSearchResults(UIKit.UISearchDisplayController,UIKit.UITableView)")]
		[DynamicDependencyAttribute ("DidLoadSearchResults(UIKit.UISearchDisplayController,UIKit.UITableView)")]
		[DynamicDependencyAttribute ("DidShowSearchResults(UIKit.UISearchDisplayController,UIKit.UITableView)")]
		[DynamicDependencyAttribute ("ShouldReloadForSearchScope(UIKit.UISearchDisplayController,System.IntPtr)")]
		[DynamicDependencyAttribute ("ShouldReloadForSearchString(UIKit.UISearchDisplayController,System.String)")]
		[DynamicDependencyAttribute ("WillBeginSearch(UIKit.UISearchDisplayController)")]
		[DynamicDependencyAttribute ("WillEndSearch(UIKit.UISearchDisplayController)")]
		[DynamicDependencyAttribute ("WillHideSearchResults(UIKit.UISearchDisplayController,UIKit.UITableView)")]
		[DynamicDependencyAttribute ("WillShowSearchResults(UIKit.UISearchDisplayController,UIKit.UITableView)")]
		[DynamicDependencyAttribute ("WillUnloadSearchResults(UIKit.UISearchDisplayController,UIKit.UITableView)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISearchDisplayDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUISearchDisplayDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUISearchDisplayDelegate" /> interface to support all the methods from the UISearchDisplayDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUISearchDisplayDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UISearchDisplayDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UISearchDisplayDelegate_Extensions {
		/// <param name="controller">To be added.</param><summary>Indicates that searching is about to start.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillBeginSearch (this IUISearchDisplayDelegate This, UISearchDisplayController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayControllerWillBeginSearch:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBeginSearch (this IUISearchDisplayDelegate This, UISearchDisplayController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayControllerDidBeginSearch:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that search is about to finish.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillEndSearch (this IUISearchDisplayDelegate This, UISearchDisplayController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayControllerWillEndSearch:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>Indicates that searching has ended.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEndSearch (this IUISearchDisplayDelegate This, UISearchDisplayController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayControllerDidEndSearch:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller has loaded its UITableView of results.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidLoadSearchResults (this IUISearchDisplayDelegate This, UISearchDisplayController controller, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayController:didLoadSearchResultsTableView:"), controller__handle__, tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (tableView);
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller is about to unload its UITableView of results.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillUnloadSearchResults (this IUISearchDisplayDelegate This, UISearchDisplayController controller, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayController:willUnloadSearchResultsTableView:"), controller__handle__, tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (tableView);
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller is about to show its UITableView of results.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillShowSearchResults (this IUISearchDisplayDelegate This, UISearchDisplayController controller, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayController:willShowSearchResultsTableView:"), controller__handle__, tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (tableView);
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller has begun displayed its UITableView of results.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidShowSearchResults (this IUISearchDisplayDelegate This, UISearchDisplayController controller, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayController:didShowSearchResultsTableView:"), controller__handle__, tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (tableView);
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller is about to hide its UITableView of results.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillHideSearchResults (this IUISearchDisplayDelegate This, UISearchDisplayController controller, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayController:willHideSearchResultsTableView:"), controller__handle__, tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (tableView);
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller hid its table view of results.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidHideSearchResults (this IUISearchDisplayDelegate This, UISearchDisplayController controller, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayController:didHideSearchResultsTableView:"), controller__handle__, tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (tableView);
		}
		/// <param name="controller">To be added.</param><param name="forSearchString">To be added.</param><summary>Whether data should be reloaded, given the change in search string.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldReloadForSearchString (this IUISearchDisplayDelegate This, UISearchDisplayController controller, string forSearchString)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (forSearchString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forSearchString));
			var nsforSearchString = CFString.CreateNative (forSearchString);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchDisplayController:shouldReloadTableForSearchString:"), controller__handle__, nsforSearchString);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			CFString.ReleaseNative (nsforSearchString);
			return ret != 0;
		}
		/// <param name="controller">To be added.</param><param name="forSearchOption">To be added.</param><summary>Whether the results table view should be reloaded for a given scope.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldReloadForSearchScope (this IUISearchDisplayDelegate This, UISearchDisplayController controller, nint forSearchOption)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("searchDisplayController:shouldReloadTableForSearchScope:"), controller__handle__, forSearchOption);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UISearchDisplayDelegateWrapper : BaseWrapper, IUISearchDisplayDelegate {
		public UISearchDisplayDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISearchDisplayDelegateWrapper))]
		static UISearchDisplayDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>A class used to receive notifications from the UISearchDisplayController.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UISearchDisplayDelegate_Protocol/index.html">Apple documentation for <c>UISearchDisplayDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UISearchDisplayDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UISearchDisplayDelegate : NSObject, IUISearchDisplayDelegate {
		/// <summary>Creates a new <see cref="UISearchDisplayDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UISearchDisplayDelegate () : base (NSObjectFlag.Empty)
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
		protected UISearchDisplayDelegate (NSObjectFlag t) : base (t)
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
		protected internal UISearchDisplayDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="controller">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[Export ("searchDisplayControllerDidBeginSearch:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginSearch (UISearchDisplayController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>Indicates that searching has ended.</summary><remarks>To be added.</remarks>
		[Export ("searchDisplayControllerDidEndSearch:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndSearch (UISearchDisplayController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller hid its table view of results.</summary><remarks>To be added.</remarks>
		[Export ("searchDisplayController:didHideSearchResultsTableView:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidHideSearchResults (UISearchDisplayController controller, UITableView tableView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller has loaded its UITableView of results.</summary><remarks>To be added.</remarks>
		[Export ("searchDisplayController:didLoadSearchResultsTableView:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoadSearchResults (UISearchDisplayController controller, UITableView tableView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller has begun displayed its UITableView of results.</summary><remarks>To be added.</remarks>
		[Export ("searchDisplayController:didShowSearchResultsTableView:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidShowSearchResults (UISearchDisplayController controller, UITableView tableView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="forSearchOption">To be added.</param><summary>Whether the results table view should be reloaded for a given scope.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("searchDisplayController:shouldReloadTableForSearchScope:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReloadForSearchScope (UISearchDisplayController controller, nint forSearchOption)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="forSearchString">To be added.</param><summary>Whether data should be reloaded, given the change in search string.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("searchDisplayController:shouldReloadTableForSearchString:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReloadForSearchString (UISearchDisplayController controller, string forSearchString)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>Indicates that searching is about to start.</summary><remarks>To be added.</remarks>
		[Export ("searchDisplayControllerWillBeginSearch:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginSearch (UISearchDisplayController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>Indicates that search is about to finish.</summary><remarks>To be added.</remarks>
		[Export ("searchDisplayControllerWillEndSearch:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEndSearch (UISearchDisplayController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller is about to hide its UITableView of results.</summary><remarks>To be added.</remarks>
		[Export ("searchDisplayController:willHideSearchResultsTableView:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillHideSearchResults (UISearchDisplayController controller, UITableView tableView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller is about to show its UITableView of results.</summary><remarks>To be added.</remarks>
		[Export ("searchDisplayController:willShowSearchResultsTableView:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillShowSearchResults (UISearchDisplayController controller, UITableView tableView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="tableView">To be added.</param><summary>Indicates that the controller is about to unload its UITableView of results.</summary><remarks>To be added.</remarks>
		[Export ("searchDisplayController:willUnloadSearchResultsTableView:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillUnloadSearchResults (UISearchDisplayController controller, UITableView tableView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UISearchDisplayDelegate */
}
