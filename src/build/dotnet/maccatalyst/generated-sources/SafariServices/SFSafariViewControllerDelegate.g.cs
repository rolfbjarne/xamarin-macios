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
namespace SafariServices {
	#pragma warning disable CS1573
	/// <summary>Protocol for presenting a user interface for web browsing.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/SafariServices/SFSafariViewControllerDelegate">Apple documentation for <c>SFSafariViewControllerDelegate</c></related>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "SFSafariViewControllerDelegate", WrapperType = typeof (SFSafariViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetActivityItems", Selector = "safariViewController:activityItemsForURL:title:", ReturnType = typeof (UIActivity[]), ParameterType = new Type [] { typeof (SafariServices.SFSafariViewController), typeof (NSUrl), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinish", Selector = "safariViewControllerDidFinish:", ParameterType = new Type [] { typeof (SafariServices.SFSafariViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCompleteInitialLoad", Selector = "safariViewController:didCompleteInitialLoad:", ParameterType = new Type [] { typeof (SafariServices.SFSafariViewController), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetExcludedActivityTypes", Selector = "safariViewController:excludedActivityTypesForURL:title:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (SafariServices.SFSafariViewController), typeof (NSUrl), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InitialLoadDidRedirectToUrl", Selector = "safariViewController:initialLoadDidRedirectToURL:", ParameterType = new Type [] { typeof (SafariServices.SFSafariViewController), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillOpenInBrowser", Selector = "safariViewControllerWillOpenInBrowser:", ParameterType = new Type [] { typeof (SafariServices.SFSafariViewController) }, ParameterByRef = new bool [] { false })]
	public partial interface ISFSafariViewControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="controller">To be added.</param><param name="url">To be added.</param><param name="title"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called to retrieve the activity items for the requested action.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("safariViewController:activityItemsForURL:title:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIActivity[] GetActivityItems (SFSafariViewController controller, NSUrl url, string? title)
		{
			return _GetActivityItems (this, controller, url, title);
		}
		/// <param name="controller">To be added.</param><param name="url">To be added.</param><param name="title"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called to retrieve the activity items for the requested action.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIActivity[] _GetActivityItems (ISFSafariViewControllerDelegate This, SFSafariViewController controller, NSUrl url, string? title)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var nstitle = CFString.CreateNative (title);
			global::UIKit.UIActivity[]? ret;
			ret = CFArray.ArrayFromHandle<global::UIKit.UIActivity>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("safariViewController:activityItemsForURL:title:"), controller__handle__, url__handle__, nstitle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (url);
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
		/// <param name="controller">To be added.</param><summary>Method that is called when the user dismisses the view.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("safariViewControllerDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (SFSafariViewController controller)
		{
			_DidFinish (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>Method that is called when the user dismisses the view.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinish (ISFSafariViewControllerDelegate This, SFSafariViewController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("safariViewControllerDidFinish:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><param name="didLoadSuccessfully">To be added.</param><summary>Method that is called after the first URL is loaded.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("safariViewController:didCompleteInitialLoad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCompleteInitialLoad (SFSafariViewController controller, bool didLoadSuccessfully)
		{
			_DidCompleteInitialLoad (this, controller, didLoadSuccessfully);
		}
		/// <param name="controller">To be added.</param><param name="didLoadSuccessfully">To be added.</param><summary>Method that is called after the first URL is loaded.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCompleteInitialLoad (ISFSafariViewControllerDelegate This, SFSafariViewController controller, bool didLoadSuccessfully)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("safariViewController:didCompleteInitialLoad:"), controller__handle__, didLoadSuccessfully ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><param name="url">To be added.</param><param name="title"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("safariViewController:excludedActivityTypesForURL:title:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetExcludedActivityTypes (SFSafariViewController controller, NSUrl url, string? title)
		{
			return _GetExcludedActivityTypes (this, controller, url, title);
		}
		/// <param name="controller">To be added.</param><param name="url">To be added.</param><param name="title"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _GetExcludedActivityTypes (ISFSafariViewControllerDelegate This, SFSafariViewController controller, NSUrl url, string? title)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var nstitle = CFString.CreateNative (title);
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("safariViewController:excludedActivityTypesForURL:title:"), controller__handle__, url__handle__, nstitle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (url);
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
		/// <param name="controller">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("safariViewController:initialLoadDidRedirectToURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitialLoadDidRedirectToUrl (SFSafariViewController controller, NSUrl url)
		{
			_InitialLoadDidRedirectToUrl (this, controller, url);
		}
		/// <param name="controller">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InitialLoadDidRedirectToUrl (ISFSafariViewControllerDelegate This, SFSafariViewController controller, NSUrl url)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("safariViewController:initialLoadDidRedirectToURL:"), controller__handle__, url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (url);
		}
		[global::Foundation.OptionalMember]
		[Export ("safariViewControllerWillOpenInBrowser:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillOpenInBrowser (SFSafariViewController controller)
		{
			_WillOpenInBrowser (this, controller);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillOpenInBrowser (ISFSafariViewControllerDelegate This, SFSafariViewController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("safariViewControllerWillOpenInBrowser:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		[DynamicDependencyAttribute ("DidCompleteInitialLoad(SafariServices.SFSafariViewController,System.Boolean)")]
		[DynamicDependencyAttribute ("DidFinish(SafariServices.SFSafariViewController)")]
		[DynamicDependencyAttribute ("GetActivityItems(SafariServices.SFSafariViewController,Foundation.NSUrl,System.String)")]
		[DynamicDependencyAttribute ("GetExcludedActivityTypes(SafariServices.SFSafariViewController,Foundation.NSUrl,System.String)")]
		[DynamicDependencyAttribute ("InitialLoadDidRedirectToUrl(SafariServices.SFSafariViewController,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("WillOpenInBrowser(SafariServices.SFSafariViewController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SFSafariViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISFSafariViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ISFSafariViewControllerDelegate" /> interface to support all the methods from the SFSafariViewControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ISFSafariViewControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original SFSafariViewControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class SFSafariViewControllerDelegate_Extensions {
		/// <param name="controller">To be added.</param><param name="url">To be added.</param><param name="title"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called to retrieve the activity items for the requested action.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIActivity[] GetActivityItems (this ISFSafariViewControllerDelegate This, SFSafariViewController controller, NSUrl url, string? title)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var nstitle = CFString.CreateNative (title);
			global::UIKit.UIActivity[]? ret;
			ret = CFArray.ArrayFromHandle<global::UIKit.UIActivity>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("safariViewController:activityItemsForURL:title:"), controller__handle__, url__handle__, nstitle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (url);
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
		/// <param name="controller">To be added.</param><summary>Method that is called when the user dismisses the view.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinish (this ISFSafariViewControllerDelegate This, SFSafariViewController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("safariViewControllerDidFinish:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><param name="didLoadSuccessfully">To be added.</param><summary>Method that is called after the first URL is loaded.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCompleteInitialLoad (this ISFSafariViewControllerDelegate This, SFSafariViewController controller, bool didLoadSuccessfully)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("safariViewController:didCompleteInitialLoad:"), controller__handle__, didLoadSuccessfully ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><param name="url">To be added.</param><param name="title"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetExcludedActivityTypes (this ISFSafariViewControllerDelegate This, SFSafariViewController controller, NSUrl url, string? title)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var nstitle = CFString.CreateNative (title);
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("safariViewController:excludedActivityTypesForURL:title:"), controller__handle__, url__handle__, nstitle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (url);
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
		/// <param name="controller">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InitialLoadDidRedirectToUrl (this ISFSafariViewControllerDelegate This, SFSafariViewController controller, NSUrl url)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("safariViewController:initialLoadDidRedirectToURL:"), controller__handle__, url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (url);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillOpenInBrowser (this ISFSafariViewControllerDelegate This, SFSafariViewController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("safariViewControllerWillOpenInBrowser:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SFSafariViewControllerDelegateWrapper : BaseWrapper, ISFSafariViewControllerDelegate {
		public SFSafariViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SFSafariViewControllerDelegateWrapper))]
		static SFSafariViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace SafariServices {
	/// <summary>Protocol for presenting a user interface for web browsing.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/SafariServices/SFSafariViewControllerDelegate">Apple documentation for <c>SFSafariViewControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__SafariServices_SFSafariViewControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class SFSafariViewControllerDelegate : NSObject, ISFSafariViewControllerDelegate {
		/// <summary>Creates a new <see cref="SFSafariViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SFSafariViewControllerDelegate () : base (NSObjectFlag.Empty)
		{
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
		protected SFSafariViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal SFSafariViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="controller">To be added.</param><param name="didLoadSuccessfully">To be added.</param><summary>Method that is called after the first URL is loaded.</summary><remarks>To be added.</remarks>
		[Export ("safariViewController:didCompleteInitialLoad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCompleteInitialLoad (SFSafariViewController controller, bool didLoadSuccessfully)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>Method that is called when the user dismisses the view.</summary><remarks>To be added.</remarks>
		[Export ("safariViewControllerDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (SFSafariViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="url">To be added.</param><param name="title"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called to retrieve the activity items for the requested action.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("safariViewController:activityItemsForURL:title:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIActivity[] GetActivityItems (SFSafariViewController controller, NSUrl url, string? title)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="url">To be added.</param><param name="title"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("safariViewController:excludedActivityTypesForURL:title:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetExcludedActivityTypes (SFSafariViewController controller, NSUrl url, string? title)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("safariViewController:initialLoadDidRedirectToURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitialLoadDidRedirectToUrl (SFSafariViewController controller, NSUrl url)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("safariViewControllerWillOpenInBrowser:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillOpenInBrowser (SFSafariViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SFSafariViewControllerDelegate */
}
