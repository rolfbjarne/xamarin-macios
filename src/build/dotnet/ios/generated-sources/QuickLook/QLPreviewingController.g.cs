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
namespace QuickLook {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>QLPreviewingController</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "QLPreviewingController", WrapperType = typeof (QLPreviewingControllerWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PreparePreviewOfSearchableItem", Selector = "preparePreviewOfSearchableItemWithIdentifier:queryString:completionHandler:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PreparePreviewOfFile", Selector = "preparePreviewOfFileAtURL:completionHandler:", ParameterType = new Type [] { typeof (NSUrl), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProvidePreview", Selector = "providePreviewForFileRequest:completionHandler:", ParameterType = new Type [] { typeof (QLFilePreviewRequest), typeof (global::System.Action<global::QuickLook.QLPreviewReply, NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V150) })]
	public partial interface IQLPreviewingController : INativeObject, IDisposable
	{
		/// <param name="identifier">To be added.</param><param name="queryString">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("preparePreviewOfSearchableItemWithIdentifier:queryString:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PreparePreviewOfSearchableItem (string identifier, string? queryString, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> handler)
		{
			_PreparePreviewOfSearchableItem (this, identifier, queryString, handler);
		}
		/// <param name="identifier">To be added.</param><param name="queryString">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _PreparePreviewOfSearchableItem (IQLPreviewingController This, string identifier, string? queryString, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			var nsidentifier = CFString.CreateNative (identifier);
			var nsqueryString = CFString.CreateNative (queryString);
			using var block_handler = Trampolines.SDActionArity1V0.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("preparePreviewOfSearchableItemWithIdentifier:queryString:completionHandler:"), nsidentifier, nsqueryString, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsidentifier);
			CFString.ReleaseNative (nsqueryString);
		}
		/// <param name="url">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("preparePreviewOfFileAtURL:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PreparePreviewOfFile (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> handler)
		{
			_PreparePreviewOfFile (this, url, handler);
		}
		/// <param name="url">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _PreparePreviewOfFile (IQLPreviewingController This, NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity1V0.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("preparePreviewOfFileAtURL:completionHandler:"), url__handle__, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
		}
		[global::Foundation.OptionalMember]
		[Export ("providePreviewForFileRequest:completionHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ProvidePreview (QLFilePreviewRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V150))]global::System.Action<QLPreviewReply, NSError> handler)
		{
			_ProvidePreview (this, request, handler);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ProvidePreview (IQLPreviewingController This, QLFilePreviewRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V150))]global::System.Action<QLPreviewReply, NSError> handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity2V150.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("providePreviewForFileRequest:completionHandler:"), request__handle__, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
			GC.KeepAlive (request);
		}
		[DynamicDependencyAttribute ("PreparePreviewOfFile(Foundation.NSUrl,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("PreparePreviewOfSearchableItem(System.String,System.String,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("ProvidePreview(QuickLook.QLFilePreviewRequest,System.Action{QuickLook.QLPreviewReply,Foundation.NSError})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (QLPreviewingControllerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IQLPreviewingController ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IQLPreviewingController" /> interface to support all the methods from the QLPreviewingController protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IQLPreviewingController" /> interface allow developers to treat instances of the interface as having all the optional methods of the original QLPreviewingController protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class QLPreviewingController_Extensions {
		/// <param name="identifier">To be added.</param><param name="queryString">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PreparePreviewOfSearchableItem (this IQLPreviewingController This, string identifier, string? queryString, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			var nsidentifier = CFString.CreateNative (identifier);
			var nsqueryString = CFString.CreateNative (queryString);
			using var block_handler = Trampolines.SDActionArity1V0.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("preparePreviewOfSearchableItemWithIdentifier:queryString:completionHandler:"), nsidentifier, nsqueryString, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsidentifier);
			CFString.ReleaseNative (nsqueryString);
		}
		/// <param name="url">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PreparePreviewOfFile (this IQLPreviewingController This, NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity1V0.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("preparePreviewOfFileAtURL:completionHandler:"), url__handle__, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ProvidePreview (this IQLPreviewingController This, QLFilePreviewRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V150))]global::System.Action<QLPreviewReply, NSError> handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity2V150.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("providePreviewForFileRequest:completionHandler:"), request__handle__, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
			GC.KeepAlive (request);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class QLPreviewingControllerWrapper : BaseWrapper, IQLPreviewingController {
		public QLPreviewingControllerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (QLPreviewingControllerWrapper))]
		static QLPreviewingControllerWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
