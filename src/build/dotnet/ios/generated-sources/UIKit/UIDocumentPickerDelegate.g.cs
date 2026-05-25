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
	/// <summary>Delegate object for <see cref="T:UIKit.UIDocumentPickerViewController" /> object. Defines methods called when the user picks a document or cancels.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIDocumentPickerDelegate/index.html">Apple documentation for <c>UIDocumentPickerDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIDocumentPickerDelegate", WrapperType = typeof (UIDocumentPickerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPickDocument", Selector = "documentPicker:didPickDocumentAtURL:", ParameterType = new Type [] { typeof (UIDocumentPickerViewController), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPickDocument", Selector = "documentPicker:didPickDocumentsAtURLs:", ParameterType = new Type [] { typeof (UIDocumentPickerViewController), typeof (NSUrl[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WasCancelled", Selector = "documentPickerWasCancelled:", ParameterType = new Type [] { typeof (UIDocumentPickerViewController) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIDocumentPickerDelegate : INativeObject, IDisposable
	{
		/// <param name="controller">The controller that made the request.</param><param name="url">The URLS that was picked.</param><summary>Developers should not use this deprecated method. Implement 'DidPickDocument (UIDocumentPickerViewController, NSUrl[])' instead.</summary><remarks>The meaning will differ dependent upon the mode of the document picker.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentPicker:didPickDocumentAtURL:")]
		[ObsoletedOSPlatform ("ios11.0", "Implement 'DidPickDocument (UIDocumentPickerViewController, NSUrl[])' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Implement 'DidPickDocument (UIDocumentPickerViewController, NSUrl[])' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPickDocument (UIDocumentPickerViewController controller, NSUrl url)
		{
			_DidPickDocument (this, controller, url);
		}
		/// <param name="controller">The controller that made the request.</param><param name="url">The URLS that was picked.</param><summary>Developers should not use this deprecated method. Implement 'DidPickDocument (UIDocumentPickerViewController, NSUrl[])' instead.</summary><remarks>The meaning will differ dependent upon the mode of the document picker.</remarks>
		[ObsoletedOSPlatform ("ios11.0", "Implement 'DidPickDocument (UIDocumentPickerViewController, NSUrl[])' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Implement 'DidPickDocument (UIDocumentPickerViewController, NSUrl[])' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidPickDocument (IUIDocumentPickerDelegate This, UIDocumentPickerViewController controller, NSUrl url)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentPicker:didPickDocumentAtURL:"), controller__handle__, url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (url);
		}
		/// <param name="controller">The controller that made the request.</param><param name="urls">The URLS that were picked.</param><summary>Developers may implement this method to respond after the user selects documents.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentPicker:didPickDocumentsAtURLs:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPickDocument (UIDocumentPickerViewController controller, NSUrl[] urls)
		{
			_DidPickDocument (this, controller, urls);
		}
		/// <param name="controller">The controller that made the request.</param><param name="urls">The URLS that were picked.</param><summary>Developers may implement this method to respond after the user selects documents.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidPickDocument (IUIDocumentPickerDelegate This, UIDocumentPickerViewController controller, NSUrl[] urls)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (urls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urls));
			using var nsa_urls = NSArray.FromNSObjects (urls);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentPicker:didPickDocumentsAtURLs:"), controller__handle__, nsa_urls.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>The user dismissed the picker.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentPickerWasCancelled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WasCancelled (UIDocumentPickerViewController controller)
		{
			_WasCancelled (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>The user dismissed the picker.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WasCancelled (IUIDocumentPickerDelegate This, UIDocumentPickerViewController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentPickerWasCancelled:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		[DynamicDependencyAttribute ("DidPickDocument(UIKit.UIDocumentPickerViewController,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("DidPickDocument(UIKit.UIDocumentPickerViewController,Foundation.NSUrl[])")]
		[DynamicDependencyAttribute ("WasCancelled(UIKit.UIDocumentPickerViewController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDocumentPickerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIDocumentPickerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIDocumentPickerDelegate" /> interface to support all the methods from the UIDocumentPickerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIDocumentPickerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIDocumentPickerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIDocumentPickerDelegate_Extensions {
		/// <param name="controller">The controller that made the request.</param><param name="url">The URLS that was picked.</param><summary>Developers should not use this deprecated method. Implement 'DidPickDocument (UIDocumentPickerViewController, NSUrl[])' instead.</summary><remarks>The meaning will differ dependent upon the mode of the document picker.</remarks>
		[ObsoletedOSPlatform ("ios11.0", "Implement 'DidPickDocument (UIDocumentPickerViewController, NSUrl[])' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Implement 'DidPickDocument (UIDocumentPickerViewController, NSUrl[])' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPickDocument (this IUIDocumentPickerDelegate This, UIDocumentPickerViewController controller, NSUrl url)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentPicker:didPickDocumentAtURL:"), controller__handle__, url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (url);
		}
		/// <param name="controller">The controller that made the request.</param><param name="urls">The URLS that were picked.</param><summary>Developers may implement this method to respond after the user selects documents.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPickDocument (this IUIDocumentPickerDelegate This, UIDocumentPickerViewController controller, NSUrl[] urls)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (urls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urls));
			using var nsa_urls = NSArray.FromNSObjects (urls);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentPicker:didPickDocumentsAtURLs:"), controller__handle__, nsa_urls.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>The user dismissed the picker.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WasCancelled (this IUIDocumentPickerDelegate This, UIDocumentPickerViewController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentPickerWasCancelled:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIDocumentPickerDelegateWrapper : BaseWrapper, IUIDocumentPickerDelegate {
		public UIDocumentPickerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDocumentPickerDelegateWrapper))]
		static UIDocumentPickerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>Delegate object for <see cref="T:UIKit.UIDocumentPickerViewController" /> object. Defines methods called when the user picks a document or cancels.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIDocumentPickerDelegate/index.html">Apple documentation for <c>UIDocumentPickerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UIDocumentPickerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIDocumentPickerDelegate : NSObject, IUIDocumentPickerDelegate {
		/// <summary>Creates a new <see cref="UIDocumentPickerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIDocumentPickerDelegate () : base (NSObjectFlag.Empty)
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
		protected UIDocumentPickerDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIDocumentPickerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="controller">The controller that made the request.</param><param name="url">The URLS that was picked.</param><summary>Developers should not use this deprecated method. Implement 'DidPickDocument (UIDocumentPickerViewController, NSUrl[])' instead.</summary><remarks>The meaning will differ dependent upon the mode of the document picker.</remarks>
		[Export ("documentPicker:didPickDocumentAtURL:")]
		[ObsoletedOSPlatform ("ios11.0", "Implement 'DidPickDocument (UIDocumentPickerViewController, NSUrl[])' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Implement 'DidPickDocument (UIDocumentPickerViewController, NSUrl[])' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPickDocument (UIDocumentPickerViewController controller, NSUrl url)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">The controller that made the request.</param><param name="urls">The URLS that were picked.</param><summary>Developers may implement this method to respond after the user selects documents.</summary><remarks>To be added.</remarks>
		[Export ("documentPicker:didPickDocumentsAtURLs:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPickDocument (UIDocumentPickerViewController controller, NSUrl[] urls)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>The user dismissed the picker.</summary><remarks>To be added.</remarks>
		[Export ("documentPickerWasCancelled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WasCancelled (UIDocumentPickerViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIDocumentPickerDelegate */
}
