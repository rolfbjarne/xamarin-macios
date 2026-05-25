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
namespace MediaExtension {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>METrackReader</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos15.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "METrackReader", WrapperType = typeof (METrackReaderWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LoadTrackInfo", Selector = "loadTrackInfoWithCompletionHandler:", ParameterType = new Type [] { typeof (MediaExtension.METrackReaderLoadTrackInfoCallback) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDMETrackReaderLoadTrackInfoCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GenerateSampleCursorAtPresentationTimeStamp", Selector = "generateSampleCursorAtPresentationTimeStamp:completionHandler:", ParameterType = new Type [] { typeof (CMTime), typeof (MediaExtension.METrackReaderGenerateSampleCursorCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDMETrackReaderGenerateSampleCursorCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GenerateSampleCursorAtFirstSampleInDecodeOrder", Selector = "generateSampleCursorAtFirstSampleInDecodeOrderWithCompletionHandler:", ParameterType = new Type [] { typeof (MediaExtension.METrackReaderGenerateSampleCursorCallback) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDMETrackReaderGenerateSampleCursorCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GenerateSampleCursorAtLastSampleInDecodeOrder", Selector = "generateSampleCursorAtLastSampleInDecodeOrderWithCompletionHandler:", ParameterType = new Type [] { typeof (MediaExtension.METrackReaderGenerateSampleCursorCallback) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDMETrackReaderGenerateSampleCursorCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LoadUneditedDuration", Selector = "loadUneditedDurationWithCompletionHandler:", ParameterType = new Type [] { typeof (MediaExtension.METrackReaderLoadUneditedDurationCallback) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDMETrackReaderLoadUneditedDurationCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LoadTotalSampleDataLength", Selector = "loadTotalSampleDataLengthWithCompletionHandler:", ParameterType = new Type [] { typeof (MediaExtension.METrackReaderLoadTotalSampleDataLengthCallback) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDMETrackReaderLoadTotalSampleDataLengthCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LoadEstimatedDataRate", Selector = "loadEstimatedDataRateWithCompletionHandler:", ParameterType = new Type [] { typeof (MediaExtension.METrackReaderLoadEstimatedDataRateCallback) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDMETrackReaderLoadEstimatedDataRateCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LoadMetadata", Selector = "loadMetadataWithCompletionHandler:", ParameterType = new Type [] { typeof (MediaExtension.METrackReaderLoadMetadataCallback) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDMETrackReaderLoadMetadataCallback) })]
	public partial interface IMETrackReader : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("loadTrackInfoWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadTrackInfo ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderLoadTrackInfoCallback))]METrackReaderLoadTrackInfoCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _LoadTrackInfo (IMETrackReader This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderLoadTrackInfoCallback))]METrackReaderLoadTrackInfoCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMETrackReaderLoadTrackInfoCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("loadTrackInfoWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("generateSampleCursorAtPresentationTimeStamp:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GenerateSampleCursorAtPresentationTimeStamp (global::CoreMedia.CMTime presentationTimeStamp, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderGenerateSampleCursorCallback))]METrackReaderGenerateSampleCursorCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GenerateSampleCursorAtPresentationTimeStamp (IMETrackReader This, global::CoreMedia.CMTime presentationTimeStamp, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderGenerateSampleCursorCallback))]METrackReaderGenerateSampleCursorCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMETrackReaderGenerateSampleCursorCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime_NativeHandle (This.Handle, Selector.GetHandle ("generateSampleCursorAtPresentationTimeStamp:completionHandler:"), presentationTimeStamp, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("generateSampleCursorAtFirstSampleInDecodeOrderWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GenerateSampleCursorAtFirstSampleInDecodeOrder ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderGenerateSampleCursorCallback))]METrackReaderGenerateSampleCursorCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GenerateSampleCursorAtFirstSampleInDecodeOrder (IMETrackReader This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderGenerateSampleCursorCallback))]METrackReaderGenerateSampleCursorCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMETrackReaderGenerateSampleCursorCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("generateSampleCursorAtFirstSampleInDecodeOrderWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("generateSampleCursorAtLastSampleInDecodeOrderWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GenerateSampleCursorAtLastSampleInDecodeOrder ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderGenerateSampleCursorCallback))]METrackReaderGenerateSampleCursorCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GenerateSampleCursorAtLastSampleInDecodeOrder (IMETrackReader This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderGenerateSampleCursorCallback))]METrackReaderGenerateSampleCursorCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMETrackReaderGenerateSampleCursorCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("generateSampleCursorAtLastSampleInDecodeOrderWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("loadUneditedDurationWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadUneditedDuration ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderLoadUneditedDurationCallback))]METrackReaderLoadUneditedDurationCallback completionHandler)
		{
			_LoadUneditedDuration (this, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _LoadUneditedDuration (IMETrackReader This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderLoadUneditedDurationCallback))]METrackReaderLoadUneditedDurationCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMETrackReaderLoadUneditedDurationCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("loadUneditedDurationWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("loadTotalSampleDataLengthWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadTotalSampleDataLength ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderLoadTotalSampleDataLengthCallback))]METrackReaderLoadTotalSampleDataLengthCallback completionHandler)
		{
			_LoadTotalSampleDataLength (this, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _LoadTotalSampleDataLength (IMETrackReader This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderLoadTotalSampleDataLengthCallback))]METrackReaderLoadTotalSampleDataLengthCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMETrackReaderLoadTotalSampleDataLengthCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("loadTotalSampleDataLengthWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("loadEstimatedDataRateWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadEstimatedDataRate ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderLoadEstimatedDataRateCallback))]METrackReaderLoadEstimatedDataRateCallback completionHandler)
		{
			_LoadEstimatedDataRate (this, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _LoadEstimatedDataRate (IMETrackReader This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderLoadEstimatedDataRateCallback))]METrackReaderLoadEstimatedDataRateCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMETrackReaderLoadEstimatedDataRateCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("loadEstimatedDataRateWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("loadMetadataWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadMetadata ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderLoadMetadataCallback))]METrackReaderLoadMetadataCallback completionHandler)
		{
			_LoadMetadata (this, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _LoadMetadata (IMETrackReader This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderLoadMetadataCallback))]METrackReaderLoadMetadataCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMETrackReaderLoadMetadataCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("loadMetadataWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("GenerateSampleCursorAtFirstSampleInDecodeOrder(MediaExtension.METrackReaderGenerateSampleCursorCallback)")]
		[DynamicDependencyAttribute ("GenerateSampleCursorAtLastSampleInDecodeOrder(MediaExtension.METrackReaderGenerateSampleCursorCallback)")]
		[DynamicDependencyAttribute ("GenerateSampleCursorAtPresentationTimeStamp(CoreMedia.CMTime,MediaExtension.METrackReaderGenerateSampleCursorCallback)")]
		[DynamicDependencyAttribute ("LoadEstimatedDataRate(MediaExtension.METrackReaderLoadEstimatedDataRateCallback)")]
		[DynamicDependencyAttribute ("LoadMetadata(MediaExtension.METrackReaderLoadMetadataCallback)")]
		[DynamicDependencyAttribute ("LoadTotalSampleDataLength(MediaExtension.METrackReaderLoadTotalSampleDataLengthCallback)")]
		[DynamicDependencyAttribute ("LoadTrackInfo(MediaExtension.METrackReaderLoadTrackInfoCallback)")]
		[DynamicDependencyAttribute ("LoadUneditedDuration(MediaExtension.METrackReaderLoadUneditedDurationCallback)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (METrackReaderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMETrackReader ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class METrackReaderWrapper : BaseWrapper, IMETrackReader {
		public METrackReaderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (METrackReaderWrapper))]
		static METrackReaderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("loadTrackInfoWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void LoadTrackInfo ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderLoadTrackInfoCallback))]METrackReaderLoadTrackInfoCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMETrackReaderLoadTrackInfoCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("loadTrackInfoWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
		[Export ("generateSampleCursorAtPresentationTimeStamp:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void GenerateSampleCursorAtPresentationTimeStamp (global::CoreMedia.CMTime presentationTimeStamp, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderGenerateSampleCursorCallback))]METrackReaderGenerateSampleCursorCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMETrackReaderGenerateSampleCursorCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime_NativeHandle (this.Handle, Selector.GetHandle ("generateSampleCursorAtPresentationTimeStamp:completionHandler:"), presentationTimeStamp, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("generateSampleCursorAtFirstSampleInDecodeOrderWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void GenerateSampleCursorAtFirstSampleInDecodeOrder ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderGenerateSampleCursorCallback))]METrackReaderGenerateSampleCursorCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMETrackReaderGenerateSampleCursorCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("generateSampleCursorAtFirstSampleInDecodeOrderWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
		[Export ("generateSampleCursorAtLastSampleInDecodeOrderWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void GenerateSampleCursorAtLastSampleInDecodeOrder ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMETrackReaderGenerateSampleCursorCallback))]METrackReaderGenerateSampleCursorCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMETrackReaderGenerateSampleCursorCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("generateSampleCursorAtLastSampleInDecodeOrderWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
	}
}
