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
namespace PdfKit {
	#pragma warning disable CS1573
	/// <summary>Delegate object for <see cref="T:PdfKit.PdfView" /> objects, allowing the developer to respond to navigation, printing, and linking events.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "PDFViewDelegate", WrapperType = typeof (PdfViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillClickOnLink", Selector = "PDFViewWillClickOnLink:withURL:", ParameterType = new Type [] { typeof (PdfKit.PdfView), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformFind", Selector = "PDFViewPerformFind:", ParameterType = new Type [] { typeof (PdfKit.PdfView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformGoToPage", Selector = "PDFViewPerformGoToPage:", ParameterType = new Type [] { typeof (PdfKit.PdfView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenPdf", Selector = "PDFViewOpenPDF:forRemoteGoToAction:", ParameterType = new Type [] { typeof (PdfKit.PdfView), typeof (PdfKit.PdfActionRemoteGoTo) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ParentViewController", Selector = "PDFViewParentViewController", PropertyType = typeof (UIViewController), GetterSelector = "PDFViewParentViewController", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IPdfViewDelegate : INativeObject, IDisposable
	{
		/// <param name="sender">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("PDFViewWillClickOnLink:withURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillClickOnLink (PdfView sender, NSUrl url)
		{
			_WillClickOnLink (this, sender, url);
		}
		/// <param name="sender">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillClickOnLink (IPdfViewDelegate This, PdfView sender, NSUrl url)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("PDFViewWillClickOnLink:withURL:"), sender__handle__, url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (url);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("PDFViewPerformFind:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformFind (PdfView sender)
		{
			_PerformFind (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformFind (IPdfViewDelegate This, PdfView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("PDFViewPerformFind:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("PDFViewPerformGoToPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformGoToPage (PdfView sender)
		{
			_PerformGoToPage (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformGoToPage (IPdfViewDelegate This, PdfView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("PDFViewPerformGoToPage:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="action">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("PDFViewOpenPDF:forRemoteGoToAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OpenPdf (PdfView sender, PdfActionRemoteGoTo action)
		{
			_OpenPdf (this, sender, action);
		}
		/// <param name="sender">To be added.</param><param name="action">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OpenPdf (IPdfViewDelegate This, PdfView sender, PdfActionRemoteGoTo action)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("PDFViewOpenPDF:forRemoteGoToAction:"), sender__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (action);
		}
		[DynamicDependencyAttribute ("OpenPdf(PdfKit.PdfView,PdfKit.PdfActionRemoteGoTo)")]
		[DynamicDependencyAttribute ("ParentViewController")]
		[DynamicDependencyAttribute ("PerformFind(PdfKit.PdfView)")]
		[DynamicDependencyAttribute ("PerformGoToPage(PdfKit.PdfView)")]
		[DynamicDependencyAttribute ("WillClickOnLink(PdfKit.PdfView,Foundation.NSUrl)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PdfViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPdfViewDelegate ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos18.2")]
		[global::Foundation.OptionalMember]
		public virtual global::UIKit.UIViewController ParentViewController {
			[Export ("PDFViewParentViewController")]
			get {
				return _GetParentViewController (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIViewController _GetParentViewController (IPdfViewDelegate This)
		{
			global::UIKit.UIViewController ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("PDFViewParentViewController")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IPdfViewDelegate" /> interface to support all the methods from the PDFViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IPdfViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original PDFViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class PdfViewDelegate_Extensions {
		/// <param name="sender">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillClickOnLink (this IPdfViewDelegate This, PdfView sender, NSUrl url)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("PDFViewWillClickOnLink:withURL:"), sender__handle__, url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (url);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PerformFind (this IPdfViewDelegate This, PdfView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("PDFViewPerformFind:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PerformGoToPage (this IPdfViewDelegate This, PdfView sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("PDFViewPerformGoToPage:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="action">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OpenPdf (this IPdfViewDelegate This, PdfView sender, PdfActionRemoteGoTo action)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("PDFViewOpenPDF:forRemoteGoToAction:"), sender__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (action);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIViewController GetParentViewController (this IPdfViewDelegate This)
		{
			global::UIKit.UIViewController ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("PDFViewParentViewController")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PdfViewDelegateWrapper : BaseWrapper, IPdfViewDelegate {
		public PdfViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PdfViewDelegateWrapper))]
		static PdfViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace PdfKit {
	/// <summary>Delegate object for <see cref="T:PdfKit.PdfView" /> objects, allowing the developer to respond to navigation, printing, and linking events.</summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__PdfKit_PdfViewDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class PdfViewDelegate : NSObject, IPdfViewDelegate {
		/// <summary>Creates a new <see cref="PdfViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PdfViewDelegate () : base (NSObjectFlag.Empty)
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
		protected PdfViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal PdfViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="sender">To be added.</param><param name="action">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("PDFViewOpenPDF:forRemoteGoToAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OpenPdf (PdfView sender, PdfActionRemoteGoTo action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("PDFViewPerformFind:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformFind (PdfView sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("PDFViewPerformGoToPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformGoToPage (PdfView sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("PDFViewWillClickOnLink:withURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillClickOnLink (PdfView sender, NSUrl url)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos18.2")]
		public virtual global::UIKit.UIViewController ParentViewController {
			[Export ("PDFViewParentViewController")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class PdfViewDelegate */
}
