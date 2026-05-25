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
namespace FileProvider {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSFileProviderIncrementalContentFetching</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSFileProviderIncrementalContentFetching", WrapperType = typeof (NSFileProviderIncrementalContentFetchingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FetchContents", Selector = "fetchContentsForItemWithIdentifier:version:usingExistingContentsAtURL:existingVersion:request:completionHandler:", ReturnType = typeof (NSProgress), ParameterType = new Type [] { typeof (string), typeof (NSFileProviderItemVersion), typeof (NSUrl), typeof (NSFileProviderItemVersion), typeof (NSFileProviderRequest), typeof (NSFileProviderFetchContentsCompletionHandler) }, ParameterByRef = new bool [] { false, false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDNSFileProviderFetchContentsCompletionHandler) })]
	public partial interface INSFileProviderIncrementalContentFetching : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("fetchContentsForItemWithIdentifier:version:usingExistingContentsAtURL:existingVersion:request:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress FetchContents (string itemIdentifier, NSFileProviderItemVersion? requestedVersion, NSUrl existingContents, NSFileProviderItemVersion existingVersion, NSFileProviderRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderFetchContentsCompletionHandler))]NSFileProviderFetchContentsCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSProgress _FetchContents (INSFileProviderIncrementalContentFetching This, string itemIdentifier, NSFileProviderItemVersion? requestedVersion, NSUrl existingContents, NSFileProviderItemVersion existingVersion, NSFileProviderRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderFetchContentsCompletionHandler))]NSFileProviderFetchContentsCompletionHandler completionHandler)
		{
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			var requestedVersion__handle__ = requestedVersion.GetHandle ();
			var existingContents__handle__ = existingContents!.GetNonNullHandle (nameof (existingContents));
			var existingVersion__handle__ = existingVersion!.GetNonNullHandle (nameof (existingVersion));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			using var block_completionHandler = Trampolines.SDNSFileProviderFetchContentsCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fetchContentsForItemWithIdentifier:version:usingExistingContentsAtURL:existingVersion:request:completionHandler:"), nsitemIdentifier, requestedVersion__handle__, existingContents__handle__, existingVersion__handle__, request__handle__, (IntPtr) block_ptr_completionHandler), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (requestedVersion);
			GC.KeepAlive (existingContents);
			GC.KeepAlive (existingVersion);
			GC.KeepAlive (request);
			CFString.ReleaseNative (nsitemIdentifier);
			return ret!;
		}
		[DynamicDependencyAttribute ("FetchContents(System.String,FileProvider.NSFileProviderItemVersion,Foundation.NSUrl,FileProvider.NSFileProviderItemVersion,FileProvider.NSFileProviderRequest,FileProvider.NSFileProviderFetchContentsCompletionHandler)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderIncrementalContentFetchingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderIncrementalContentFetching ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderIncrementalContentFetchingWrapper : BaseWrapper, INSFileProviderIncrementalContentFetching {
		public NSFileProviderIncrementalContentFetchingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderIncrementalContentFetchingWrapper))]
		static NSFileProviderIncrementalContentFetchingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("fetchContentsForItemWithIdentifier:version:usingExistingContentsAtURL:existingVersion:request:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSProgress FetchContents (string itemIdentifier, NSFileProviderItemVersion? requestedVersion, NSUrl existingContents, NSFileProviderItemVersion existingVersion, NSFileProviderRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderFetchContentsCompletionHandler))]NSFileProviderFetchContentsCompletionHandler completionHandler)
		{
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			var requestedVersion__handle__ = requestedVersion.GetHandle ();
			var existingContents__handle__ = existingContents!.GetNonNullHandle (nameof (existingContents));
			var existingVersion__handle__ = existingVersion!.GetNonNullHandle (nameof (existingVersion));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			using var block_completionHandler = Trampolines.SDNSFileProviderFetchContentsCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("fetchContentsForItemWithIdentifier:version:usingExistingContentsAtURL:existingVersion:request:completionHandler:"), nsitemIdentifier, requestedVersion__handle__, existingContents__handle__, existingVersion__handle__, request__handle__, (IntPtr) block_ptr_completionHandler), false)!;
			GC.KeepAlive (requestedVersion);
			GC.KeepAlive (existingContents);
			GC.KeepAlive (existingVersion);
			GC.KeepAlive (request);
			CFString.ReleaseNative (nsitemIdentifier);
			return ret!;
		}
	}
}
