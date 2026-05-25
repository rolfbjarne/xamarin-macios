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
	/// <summary>This interface represents the Objective-C protocol <c>NSFileProviderThumbnailing</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSFileProviderThumbnailing", WrapperType = typeof (NSFileProviderThumbnailingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FetchThumbnails", Selector = "fetchThumbnailsForItemIdentifiers:requestedSize:perThumbnailCompletionHandler:completionHandler:", ReturnType = typeof (NSProgress), ParameterType = new Type [] { typeof (String[]), typeof (CGSize), typeof (NSFileProviderPerThumbnailCompletionHandler), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDNSFileProviderPerThumbnailCompletionHandler), typeof (ObjCRuntime.Trampolines.NIDActionArity1V16) })]
	public partial interface INSFileProviderThumbnailing : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("fetchThumbnailsForItemIdentifiers:requestedSize:perThumbnailCompletionHandler:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress FetchThumbnails (string[] itemIdentifiers, CGSize size, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderPerThumbnailCompletionHandler))]NSFileProviderPerThumbnailCompletionHandler perThumbnailCompletionHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSProgress _FetchThumbnails (INSFileProviderThumbnailing This, string[] itemIdentifiers, CGSize size, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderPerThumbnailCompletionHandler))]NSFileProviderPerThumbnailCompletionHandler perThumbnailCompletionHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			if (itemIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifiers));
			if (perThumbnailCompletionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (perThumbnailCompletionHandler));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_itemIdentifiers = NSArray.FromStrings (itemIdentifiers);
			using var block_perThumbnailCompletionHandler = Trampolines.SDNSFileProviderPerThumbnailCompletionHandler.CreateBlock (perThumbnailCompletionHandler);
			BlockLiteral *block_ptr_perThumbnailCompletionHandler = &block_perThumbnailCompletionHandler;
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGSize_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fetchThumbnailsForItemIdentifiers:requestedSize:perThumbnailCompletionHandler:completionHandler:"), nsa_itemIdentifiers.Handle, size, (IntPtr) block_ptr_perThumbnailCompletionHandler, (IntPtr) block_ptr_completionHandler), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("FetchThumbnails(System.String[],CoreGraphics.CGSize,FileProvider.NSFileProviderPerThumbnailCompletionHandler,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderThumbnailingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderThumbnailing ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderThumbnailingWrapper : BaseWrapper, INSFileProviderThumbnailing {
		public NSFileProviderThumbnailingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderThumbnailingWrapper))]
		static NSFileProviderThumbnailingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("fetchThumbnailsForItemIdentifiers:requestedSize:perThumbnailCompletionHandler:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSProgress FetchThumbnails (string[] itemIdentifiers, CGSize size, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderPerThumbnailCompletionHandler))]NSFileProviderPerThumbnailCompletionHandler perThumbnailCompletionHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			if (itemIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifiers));
			if (perThumbnailCompletionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (perThumbnailCompletionHandler));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_itemIdentifiers = NSArray.FromStrings (itemIdentifiers);
			using var block_perThumbnailCompletionHandler = Trampolines.SDNSFileProviderPerThumbnailCompletionHandler.CreateBlock (perThumbnailCompletionHandler);
			BlockLiteral *block_ptr_perThumbnailCompletionHandler = &block_perThumbnailCompletionHandler;
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGSize_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("fetchThumbnailsForItemIdentifiers:requestedSize:perThumbnailCompletionHandler:completionHandler:"), nsa_itemIdentifiers.Handle, size, (IntPtr) block_ptr_perThumbnailCompletionHandler, (IntPtr) block_ptr_completionHandler), false)!;
			return ret;
		}
	}
}
