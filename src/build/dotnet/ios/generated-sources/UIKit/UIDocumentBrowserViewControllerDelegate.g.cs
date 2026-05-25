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
	/// <summary>Handles user interactions with a document browser.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIDocumentBrowserViewControllerDelegate", WrapperType = typeof (UIDocumentBrowserViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPickDocumentUrls", Selector = "documentBrowser:didPickDocumentURLs:", ParameterType = new Type [] { typeof (UIDocumentBrowserViewController), typeof (NSUrl[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRequestDocumentCreation", Selector = "documentBrowser:didRequestDocumentCreationWithHandler:", ParameterType = new Type [] { typeof (UIDocumentBrowserViewController), typeof (global::System.Action<NSUrl, global::UIKit.UIDocumentBrowserImportMode>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V171) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidImportDocument", Selector = "documentBrowser:didImportDocumentAtURL:toDestinationURL:", ParameterType = new Type [] { typeof (UIDocumentBrowserViewController), typeof (NSUrl), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToImportDocument", Selector = "documentBrowser:failedToImportDocumentAtURL:error:", ParameterType = new Type [] { typeof (UIDocumentBrowserViewController), typeof (NSUrl), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetApplicationActivities", Selector = "documentBrowser:applicationActivitiesForDocumentURLs:", ReturnType = typeof (UIActivity[]), ParameterType = new Type [] { typeof (UIDocumentBrowserViewController), typeof (NSUrl[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresent", Selector = "documentBrowser:willPresentActivityViewController:", ParameterType = new Type [] { typeof (UIDocumentBrowserViewController), typeof (UIActivityViewController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPickDocumentsAtUrls", Selector = "documentBrowser:didPickDocumentsAtURLs:", ParameterType = new Type [] { typeof (UIDocumentBrowserViewController), typeof (NSUrl[]) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUIDocumentBrowserViewControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="controller">The controller in which the URLs were picked .</param><param name="documentUrls">The chosen URLs.</param><summary>Developers may implement this method to respond after the user selects document URLs.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentBrowser:didPickDocumentURLs:")]
		[ObsoletedOSPlatform ("ios12.0", "Use 'DidPickDocumentsAtUrls (UIDocumentBrowserViewController, NSUrl[])' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidPickDocumentsAtUrls (UIDocumentBrowserViewController, NSUrl[])' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPickDocumentUrls (UIDocumentBrowserViewController controller, NSUrl[] documentUrls)
		{
			_DidPickDocumentUrls (this, controller, documentUrls);
		}
		/// <param name="controller">The controller in which the URLs were picked .</param><param name="documentUrls">The chosen URLs.</param><summary>Developers may implement this method to respond after the user selects document URLs.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios12.0", "Use 'DidPickDocumentsAtUrls (UIDocumentBrowserViewController, NSUrl[])' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidPickDocumentsAtUrls (UIDocumentBrowserViewController, NSUrl[])' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidPickDocumentUrls (IUIDocumentBrowserViewControllerDelegate This, UIDocumentBrowserViewController controller, NSUrl[] documentUrls)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (documentUrls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (documentUrls));
			using var nsa_documentUrls = NSArray.FromNSObjects (documentUrls);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentBrowser:didPickDocumentURLs:"), controller__handle__, nsa_documentUrls.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">The controller that made the request.</param><param name="importHandler">The handler to run after the document is created.</param><summary>Developers may implement this method to respond to a request to create a new document.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentBrowser:didRequestDocumentCreationWithHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidRequestDocumentCreation (UIDocumentBrowserViewController controller, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V171))]global::System.Action<NSUrl, UIDocumentBrowserImportMode> importHandler)
		{
			_DidRequestDocumentCreation (this, controller, importHandler);
		}
		/// <param name="controller">The controller that made the request.</param><param name="importHandler">The handler to run after the document is created.</param><summary>Developers may implement this method to respond to a request to create a new document.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidRequestDocumentCreation (IUIDocumentBrowserViewControllerDelegate This, UIDocumentBrowserViewController controller, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V171))]global::System.Action<NSUrl, UIDocumentBrowserImportMode> importHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (importHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (importHandler));
			using var block_importHandler = Trampolines.SDActionArity2V171.CreateBlock (importHandler);
			BlockLiteral *block_ptr_importHandler = &block_importHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentBrowser:didRequestDocumentCreationWithHandler:"), controller__handle__, (IntPtr) block_ptr_importHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">The controller that imported the document.</param><param name="sourceUrl">The original document URL.</param><param name="destinationUrl">The imported document's URL.</param><summary>Developers may implement this method to respond after a document is imported.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentBrowser:didImportDocumentAtURL:toDestinationURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidImportDocument (UIDocumentBrowserViewController controller, NSUrl sourceUrl, NSUrl destinationUrl)
		{
			_DidImportDocument (this, controller, sourceUrl, destinationUrl);
		}
		/// <param name="controller">The controller that imported the document.</param><param name="sourceUrl">The original document URL.</param><param name="destinationUrl">The imported document's URL.</param><summary>Developers may implement this method to respond after a document is imported.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidImportDocument (IUIDocumentBrowserViewControllerDelegate This, UIDocumentBrowserViewController controller, NSUrl sourceUrl, NSUrl destinationUrl)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var sourceUrl__handle__ = sourceUrl!.GetNonNullHandle (nameof (sourceUrl));
			var destinationUrl__handle__ = destinationUrl!.GetNonNullHandle (nameof (destinationUrl));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentBrowser:didImportDocumentAtURL:toDestinationURL:"), controller__handle__, sourceUrl__handle__, destinationUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (sourceUrl);
			GC.KeepAlive (destinationUrl);
		}
		/// <param name="controller">The controller that failed to import the document.</param><param name="documentUrl">The document's original URL.</param><param name="error"><para>The error that occurred.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Developers may implement this method to respond when the application fails to import a document.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentBrowser:failedToImportDocumentAtURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToImportDocument (UIDocumentBrowserViewController controller, NSUrl documentUrl, NSError? error)
		{
			_FailedToImportDocument (this, controller, documentUrl, error);
		}
		/// <param name="controller">The controller that failed to import the document.</param><param name="documentUrl">The document's original URL.</param><param name="error"><para>The error that occurred.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Developers may implement this method to respond when the application fails to import a document.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedToImportDocument (IUIDocumentBrowserViewControllerDelegate This, UIDocumentBrowserViewController controller, NSUrl documentUrl, NSError? error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var documentUrl__handle__ = documentUrl!.GetNonNullHandle (nameof (documentUrl));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentBrowser:failedToImportDocumentAtURL:error:"), controller__handle__, documentUrl__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (documentUrl);
			GC.KeepAlive (error);
		}
		/// <param name="controller">The controller that is making the request.</param><param name="documentUrls">URLs to the documents to share.</param><summary>Returns an array of custom application activities for an activity view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentBrowser:applicationActivitiesForDocumentURLs:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIActivity[] GetApplicationActivities (UIDocumentBrowserViewController controller, NSUrl[] documentUrls)
		{
			return _GetApplicationActivities (this, controller, documentUrls);
		}
		/// <param name="controller">The controller that is making the request.</param><param name="documentUrls">URLs to the documents to share.</param><summary>Returns an array of custom application activities for an activity view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIActivity[] _GetApplicationActivities (IUIDocumentBrowserViewControllerDelegate This, UIDocumentBrowserViewController controller, NSUrl[] documentUrls)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (documentUrls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (documentUrls));
			using var nsa_documentUrls = NSArray.FromNSObjects (documentUrls);
			UIActivity[]? ret;
			ret = CFArray.ArrayFromHandle<UIActivity>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentBrowser:applicationActivitiesForDocumentURLs:"), controller__handle__, nsa_documentUrls.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			return ret!;
		}
		/// <param name="controller">The controller that is about to present the activity.</param><param name="activityViewController">The activity that will be presented.</param><summary>Developers may implement this method to prepare for the display of an activity view.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentBrowser:willPresentActivityViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresent (UIDocumentBrowserViewController controller, UIActivityViewController activityViewController)
		{
			_WillPresent (this, controller, activityViewController);
		}
		/// <param name="controller">The controller that is about to present the activity.</param><param name="activityViewController">The activity that will be presented.</param><summary>Developers may implement this method to prepare for the display of an activity view.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPresent (IUIDocumentBrowserViewControllerDelegate This, UIDocumentBrowserViewController controller, UIActivityViewController activityViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var activityViewController__handle__ = activityViewController!.GetNonNullHandle (nameof (activityViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentBrowser:willPresentActivityViewController:"), controller__handle__, activityViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (activityViewController);
		}
		/// <param name="controller">To be added.</param><param name="documentUrls">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentBrowser:didPickDocumentsAtURLs:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPickDocumentsAtUrls (UIDocumentBrowserViewController controller, NSUrl[] documentUrls)
		{
			_DidPickDocumentsAtUrls (this, controller, documentUrls);
		}
		/// <param name="controller">To be added.</param><param name="documentUrls">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidPickDocumentsAtUrls (IUIDocumentBrowserViewControllerDelegate This, UIDocumentBrowserViewController controller, NSUrl[] documentUrls)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (documentUrls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (documentUrls));
			using var nsa_documentUrls = NSArray.FromNSObjects (documentUrls);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentBrowser:didPickDocumentsAtURLs:"), controller__handle__, nsa_documentUrls.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		[DynamicDependencyAttribute ("DidImportDocument(UIKit.UIDocumentBrowserViewController,Foundation.NSUrl,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("DidPickDocumentsAtUrls(UIKit.UIDocumentBrowserViewController,Foundation.NSUrl[])")]
		[DynamicDependencyAttribute ("DidPickDocumentUrls(UIKit.UIDocumentBrowserViewController,Foundation.NSUrl[])")]
		[DynamicDependencyAttribute ("DidRequestDocumentCreation(UIKit.UIDocumentBrowserViewController,System.Action{Foundation.NSUrl,UIKit.UIDocumentBrowserImportMode})")]
		[DynamicDependencyAttribute ("FailedToImportDocument(UIKit.UIDocumentBrowserViewController,Foundation.NSUrl,Foundation.NSError)")]
		[DynamicDependencyAttribute ("GetApplicationActivities(UIKit.UIDocumentBrowserViewController,Foundation.NSUrl[])")]
		[DynamicDependencyAttribute ("WillPresent(UIKit.UIDocumentBrowserViewController,UIKit.UIActivityViewController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDocumentBrowserViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIDocumentBrowserViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIDocumentBrowserViewControllerDelegate" /> interface to support all the methods from the UIDocumentBrowserViewControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIDocumentBrowserViewControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIDocumentBrowserViewControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIDocumentBrowserViewControllerDelegate_Extensions {
		/// <param name="controller">The controller in which the URLs were picked .</param><param name="documentUrls">The chosen URLs.</param><summary>Developers may implement this method to respond after the user selects document URLs.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios12.0", "Use 'DidPickDocumentsAtUrls (UIDocumentBrowserViewController, NSUrl[])' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidPickDocumentsAtUrls (UIDocumentBrowserViewController, NSUrl[])' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPickDocumentUrls (this IUIDocumentBrowserViewControllerDelegate This, UIDocumentBrowserViewController controller, NSUrl[] documentUrls)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (documentUrls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (documentUrls));
			using var nsa_documentUrls = NSArray.FromNSObjects (documentUrls);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentBrowser:didPickDocumentURLs:"), controller__handle__, nsa_documentUrls.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">The controller that made the request.</param><param name="importHandler">The handler to run after the document is created.</param><summary>Developers may implement this method to respond to a request to create a new document.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidRequestDocumentCreation (this IUIDocumentBrowserViewControllerDelegate This, UIDocumentBrowserViewController controller, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V171))]global::System.Action<NSUrl, UIDocumentBrowserImportMode> importHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (importHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (importHandler));
			using var block_importHandler = Trampolines.SDActionArity2V171.CreateBlock (importHandler);
			BlockLiteral *block_ptr_importHandler = &block_importHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentBrowser:didRequestDocumentCreationWithHandler:"), controller__handle__, (IntPtr) block_ptr_importHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">The controller that imported the document.</param><param name="sourceUrl">The original document URL.</param><param name="destinationUrl">The imported document's URL.</param><summary>Developers may implement this method to respond after a document is imported.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidImportDocument (this IUIDocumentBrowserViewControllerDelegate This, UIDocumentBrowserViewController controller, NSUrl sourceUrl, NSUrl destinationUrl)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var sourceUrl__handle__ = sourceUrl!.GetNonNullHandle (nameof (sourceUrl));
			var destinationUrl__handle__ = destinationUrl!.GetNonNullHandle (nameof (destinationUrl));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentBrowser:didImportDocumentAtURL:toDestinationURL:"), controller__handle__, sourceUrl__handle__, destinationUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (sourceUrl);
			GC.KeepAlive (destinationUrl);
		}
		/// <param name="controller">The controller that failed to import the document.</param><param name="documentUrl">The document's original URL.</param><param name="error"><para>The error that occurred.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Developers may implement this method to respond when the application fails to import a document.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedToImportDocument (this IUIDocumentBrowserViewControllerDelegate This, UIDocumentBrowserViewController controller, NSUrl documentUrl, NSError? error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var documentUrl__handle__ = documentUrl!.GetNonNullHandle (nameof (documentUrl));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentBrowser:failedToImportDocumentAtURL:error:"), controller__handle__, documentUrl__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (documentUrl);
			GC.KeepAlive (error);
		}
		/// <param name="controller">The controller that is making the request.</param><param name="documentUrls">URLs to the documents to share.</param><summary>Returns an array of custom application activities for an activity view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIActivity[] GetApplicationActivities (this IUIDocumentBrowserViewControllerDelegate This, UIDocumentBrowserViewController controller, NSUrl[] documentUrls)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (documentUrls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (documentUrls));
			using var nsa_documentUrls = NSArray.FromNSObjects (documentUrls);
			UIActivity[]? ret;
			ret = CFArray.ArrayFromHandle<UIActivity>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentBrowser:applicationActivitiesForDocumentURLs:"), controller__handle__, nsa_documentUrls.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			return ret!;
		}
		/// <param name="controller">The controller that is about to present the activity.</param><param name="activityViewController">The activity that will be presented.</param><summary>Developers may implement this method to prepare for the display of an activity view.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresent (this IUIDocumentBrowserViewControllerDelegate This, UIDocumentBrowserViewController controller, UIActivityViewController activityViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var activityViewController__handle__ = activityViewController!.GetNonNullHandle (nameof (activityViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentBrowser:willPresentActivityViewController:"), controller__handle__, activityViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (activityViewController);
		}
		/// <param name="controller">To be added.</param><param name="documentUrls">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPickDocumentsAtUrls (this IUIDocumentBrowserViewControllerDelegate This, UIDocumentBrowserViewController controller, NSUrl[] documentUrls)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (documentUrls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (documentUrls));
			using var nsa_documentUrls = NSArray.FromNSObjects (documentUrls);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentBrowser:didPickDocumentsAtURLs:"), controller__handle__, nsa_documentUrls.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIDocumentBrowserViewControllerDelegateWrapper : BaseWrapper, IUIDocumentBrowserViewControllerDelegate {
		public UIDocumentBrowserViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDocumentBrowserViewControllerDelegateWrapper))]
		static UIDocumentBrowserViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>Handles user interactions with a document browser.</summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UIDocumentBrowserViewControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIDocumentBrowserViewControllerDelegate : NSObject, IUIDocumentBrowserViewControllerDelegate {
		/// <summary>Creates a new <see cref="UIDocumentBrowserViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIDocumentBrowserViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected UIDocumentBrowserViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIDocumentBrowserViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="controller">The controller that imported the document.</param><param name="sourceUrl">The original document URL.</param><param name="destinationUrl">The imported document's URL.</param><summary>Developers may implement this method to respond after a document is imported.</summary><remarks>To be added.</remarks>
		[Export ("documentBrowser:didImportDocumentAtURL:toDestinationURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidImportDocument (UIDocumentBrowserViewController controller, NSUrl sourceUrl, NSUrl destinationUrl)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">The controller in which the URLs were picked .</param><param name="documentUrls">The chosen URLs.</param><summary>Developers may implement this method to respond after the user selects document URLs.</summary><remarks>To be added.</remarks>
		[Export ("documentBrowser:didPickDocumentURLs:")]
		[ObsoletedOSPlatform ("ios12.0", "Use 'DidPickDocumentsAtUrls (UIDocumentBrowserViewController, NSUrl[])' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidPickDocumentsAtUrls (UIDocumentBrowserViewController, NSUrl[])' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPickDocumentUrls (UIDocumentBrowserViewController controller, NSUrl[] documentUrls)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="documentUrls">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("documentBrowser:didPickDocumentsAtURLs:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPickDocumentsAtUrls (UIDocumentBrowserViewController controller, NSUrl[] documentUrls)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">The controller that made the request.</param><param name="importHandler">The handler to run after the document is created.</param><summary>Developers may implement this method to respond to a request to create a new document.</summary><remarks>To be added.</remarks>
		[Export ("documentBrowser:didRequestDocumentCreationWithHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidRequestDocumentCreation (UIDocumentBrowserViewController controller, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V171))]global::System.Action<NSUrl, UIDocumentBrowserImportMode> importHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">The controller that failed to import the document.</param><param name="documentUrl">The document's original URL.</param><param name="error"><para>The error that occurred.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Developers may implement this method to respond when the application fails to import a document.</summary><remarks>To be added.</remarks>
		[Export ("documentBrowser:failedToImportDocumentAtURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToImportDocument (UIDocumentBrowserViewController controller, NSUrl documentUrl, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">The controller that is making the request.</param><param name="documentUrls">URLs to the documents to share.</param><summary>Returns an array of custom application activities for an activity view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("documentBrowser:applicationActivitiesForDocumentURLs:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIActivity[] GetApplicationActivities (UIDocumentBrowserViewController controller, NSUrl[] documentUrls)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">The controller that is about to present the activity.</param><param name="activityViewController">The activity that will be presented.</param><summary>Developers may implement this method to prepare for the display of an activity view.</summary><remarks>To be added.</remarks>
		[Export ("documentBrowser:willPresentActivityViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresent (UIDocumentBrowserViewController controller, UIActivityViewController activityViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIDocumentBrowserViewControllerDelegate */
}
