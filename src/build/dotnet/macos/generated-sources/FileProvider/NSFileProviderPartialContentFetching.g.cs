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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
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
namespace FileProvider {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSFileProviderPartialContentFetching</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos12.3")]
	[Protocol (Name = "NSFileProviderPartialContentFetching", WrapperType = typeof (NSFileProviderPartialContentFetchingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FetchPartialContents", Selector = "fetchPartialContentsForItemWithIdentifier:version:request:minimalRange:aligningTo:options:completionHandler:", ReturnType = typeof (NSProgress), ParameterType = new Type [] { typeof (string), typeof (NSFileProviderItemVersion), typeof (NSFileProviderRequest), typeof (NSRange), typeof (UIntPtr), typeof (NSFileProviderFetchContentsOptions), typeof (NSFileProviderPartialContentFetchingCompletionHandler) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDNSFileProviderPartialContentFetchingCompletionHandler) })]
	public partial interface INSFileProviderPartialContentFetching : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("fetchPartialContentsForItemWithIdentifier:version:request:minimalRange:aligningTo:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress FetchPartialContents (string itemIdentifier, NSFileProviderItemVersion requestedVersion, NSFileProviderRequest request, NSRange requestedRange, nuint alignment, NSFileProviderFetchContentsOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderPartialContentFetchingCompletionHandler))]NSFileProviderPartialContentFetchingCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSProgress _FetchPartialContents (INSFileProviderPartialContentFetching This, string itemIdentifier, NSFileProviderItemVersion requestedVersion, NSFileProviderRequest request, NSRange requestedRange, nuint alignment, NSFileProviderFetchContentsOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderPartialContentFetchingCompletionHandler))]NSFileProviderPartialContentFetchingCompletionHandler completionHandler)
		{
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			var requestedVersion__handle__ = requestedVersion!.GetNonNullHandle (nameof (requestedVersion));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			using var block_completionHandler = Trampolines.SDNSFileProviderPartialContentFetchingCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NSRange_UIntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("fetchPartialContentsForItemWithIdentifier:version:request:minimalRange:aligningTo:options:completionHandler:"), nsitemIdentifier, requestedVersion__handle__, request__handle__, requestedRange, alignment, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (requestedVersion);
			GC.KeepAlive (request);
			CFString.ReleaseNative (nsitemIdentifier);
			return ret!;
		}
		[DynamicDependencyAttribute ("FetchPartialContents(System.String,FileProvider.NSFileProviderItemVersion,FileProvider.NSFileProviderRequest,Foundation.NSRange,System.UIntPtr,FileProvider.NSFileProviderFetchContentsOptions,FileProvider.NSFileProviderPartialContentFetchingCompletionHandler)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderPartialContentFetchingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderPartialContentFetching ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderPartialContentFetchingWrapper : BaseWrapper, INSFileProviderPartialContentFetching {
		public NSFileProviderPartialContentFetchingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderPartialContentFetchingWrapper))]
		static NSFileProviderPartialContentFetchingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("fetchPartialContentsForItemWithIdentifier:version:request:minimalRange:aligningTo:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSProgress FetchPartialContents (string itemIdentifier, NSFileProviderItemVersion requestedVersion, NSFileProviderRequest request, NSRange requestedRange, nuint alignment, NSFileProviderFetchContentsOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderPartialContentFetchingCompletionHandler))]NSFileProviderPartialContentFetchingCompletionHandler completionHandler)
		{
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			var requestedVersion__handle__ = requestedVersion!.GetNonNullHandle (nameof (requestedVersion));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			using var block_completionHandler = Trampolines.SDNSFileProviderPartialContentFetchingCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NSRange_UIntPtr_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("fetchPartialContentsForItemWithIdentifier:version:request:minimalRange:aligningTo:options:completionHandler:"), nsitemIdentifier, requestedVersion__handle__, request__handle__, requestedRange, alignment, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler), false)!;
			GC.KeepAlive (requestedVersion);
			GC.KeepAlive (request);
			CFString.ReleaseNative (nsitemIdentifier);
			return ret!;
		}
	}
}
