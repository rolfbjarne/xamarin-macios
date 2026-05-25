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
	/// <summary>This interface represents the Objective-C protocol <c>MESampleCursor</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos15.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "MESampleCursor", WrapperType = typeof (MESampleCursorWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StepInDecodeOrder", Selector = "stepInDecodeOrderByCount:completionHandler:", ParameterType = new Type [] { typeof (long), typeof (MediaExtension.MESampleCursorStepInOrderCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDMESampleCursorStepInOrderCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StepInPresentationOrder", Selector = "stepInPresentationOrderByCount:completionHandler:", ParameterType = new Type [] { typeof (long), typeof (MediaExtension.MESampleCursorStepInOrderCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDMESampleCursorStepInOrderCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StepByDecodeTime", Selector = "stepByDecodeTime:completionHandler:", ParameterType = new Type [] { typeof (CMTime), typeof (MediaExtension.MESampleCursorStepByTimeCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDMESampleCursorStepByTimeCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StepByPresentationTime", Selector = "stepByPresentationTime:completionHandler:", ParameterType = new Type [] { typeof (CMTime), typeof (MediaExtension.MESampleCursorStepByTimeCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDMESampleCursorStepByTimeCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SamplesWithEarlierDtssMayHaveLaterPtssThanCursor", Selector = "samplesWithEarlierDTSsMayHaveLaterPTSsThanCursor:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MediaExtension.IMESampleCursor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SamplesWithLaterDtssMayHaveEarlierPtssThanCursor", Selector = "samplesWithLaterDTSsMayHaveEarlierPTSsThanCursor:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MediaExtension.IMESampleCursor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetChunkDetails", Selector = "chunkDetailsReturningError:", ReturnType = typeof (MediaExtension.MESampleCursorChunk), ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSampleLocation", Selector = "sampleLocationReturningError:", ReturnType = typeof (MediaExtension.MESampleLocation), ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetEstimatedSampleLocation", Selector = "estimatedSampleLocationReturningError:", ReturnType = typeof (MediaExtension.MEEstimatedSampleLocation), ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RefineSampleLocation", Selector = "refineSampleLocation:refinementData:refinementDataLength:refinedLocation:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (AVSampleCursorStorageRange), typeof (Byte*), typeof (UIntPtr), typeof (AVSampleCursorStorageRange), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, true, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LoadSampleBufferContainingSamples", Selector = "loadSampleBufferContainingSamplesToEndCursor:completionHandler:", ParameterType = new Type [] { typeof (MediaExtension.IMESampleCursor), typeof (MediaExtension.MESampleCursorLoadSampleBufferCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDMESampleCursorLoadSampleBufferCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LoadPostDecodeProcessingMetadata", Selector = "loadPostDecodeProcessingMetadataWithCompletionHandler:", ParameterType = new Type [] { typeof (MediaExtension.MESampleCursorLoadPostDecodeProcessingMetadataCallback) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDMESampleCursorLoadPostDecodeProcessingMetadataCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PresentationTimeStamp", Selector = "presentationTimeStamp", PropertyType = typeof (CMTime), GetterSelector = "presentationTimeStamp", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DecodeTimeStamp", Selector = "decodeTimeStamp", PropertyType = typeof (CMTime), GetterSelector = "decodeTimeStamp", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CurrentSampleDuration", Selector = "currentSampleDuration", PropertyType = typeof (CMTime), GetterSelector = "currentSampleDuration", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CurrentSampleFormatDescription", Selector = "currentSampleFormatDescription", PropertyType = typeof (CMFormatDescription), GetterSelector = "currentSampleFormatDescription", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SyncInfo_Blittable", Selector = "syncInfo", PropertyType = typeof (AVSampleCursorChunkInfo_Blittable), GetterSelector = "syncInfo", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DependencyInfo_Blittable", Selector = "dependencyInfo", PropertyType = typeof (AVSampleCursorDependencyInfo_Blittable), GetterSelector = "dependencyInfo", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "HevcDependencyInfo", Selector = "hevcDependencyInfo", PropertyType = typeof (MediaExtension.MEHevcDependencyInfo), GetterSelector = "hevcDependencyInfo", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DecodeTimeOfLastSampleReachableByForwardSteppingThatIsAlreadyLoadedByByteSource", Selector = "decodeTimeOfLastSampleReachableByForwardSteppingThatIsAlreadyLoadedByByteSource", PropertyType = typeof (CMTime), GetterSelector = "decodeTimeOfLastSampleReachableByForwardSteppingThatIsAlreadyLoadedByByteSource", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMESampleCursor : INativeObject, IDisposable, 
		Foundation.INSCopying
	{
		[global::Foundation.RequiredMember]
		[Export ("stepInDecodeOrderByCount:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void StepInDecodeOrder (long stepCount, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMESampleCursorStepInOrderCallback))]MESampleCursorStepInOrderCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _StepInDecodeOrder (IMESampleCursor This, long stepCount, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMESampleCursorStepInOrderCallback))]MESampleCursorStepInOrderCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMESampleCursorStepInOrderCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_Int64_NativeHandle (This.Handle, Selector.GetHandle ("stepInDecodeOrderByCount:completionHandler:"), stepCount, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("stepInPresentationOrderByCount:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void StepInPresentationOrder (long stepCount, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMESampleCursorStepInOrderCallback))]MESampleCursorStepInOrderCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _StepInPresentationOrder (IMESampleCursor This, long stepCount, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMESampleCursorStepInOrderCallback))]MESampleCursorStepInOrderCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMESampleCursorStepInOrderCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_Int64_NativeHandle (This.Handle, Selector.GetHandle ("stepInPresentationOrderByCount:completionHandler:"), stepCount, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("stepByDecodeTime:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void StepByDecodeTime (global::CoreMedia.CMTime deltaDecodeTime, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMESampleCursorStepByTimeCallback))]MESampleCursorStepByTimeCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _StepByDecodeTime (IMESampleCursor This, global::CoreMedia.CMTime deltaDecodeTime, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMESampleCursorStepByTimeCallback))]MESampleCursorStepByTimeCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMESampleCursorStepByTimeCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime_NativeHandle (This.Handle, Selector.GetHandle ("stepByDecodeTime:completionHandler:"), deltaDecodeTime, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("stepByPresentationTime:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void StepByPresentationTime (global::CoreMedia.CMTime deltaPresentationTime, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMESampleCursorStepByTimeCallback))]MESampleCursorStepByTimeCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _StepByPresentationTime (IMESampleCursor This, global::CoreMedia.CMTime deltaPresentationTime, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMESampleCursorStepByTimeCallback))]MESampleCursorStepByTimeCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMESampleCursorStepByTimeCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime_NativeHandle (This.Handle, Selector.GetHandle ("stepByPresentationTime:completionHandler:"), deltaPresentationTime, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("samplesWithEarlierDTSsMayHaveLaterPTSsThanCursor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SamplesWithEarlierDtssMayHaveLaterPtssThanCursor (IMESampleCursor cursor)
		{
			return _SamplesWithEarlierDtssMayHaveLaterPtssThanCursor (this, cursor);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _SamplesWithEarlierDtssMayHaveLaterPtssThanCursor (IMESampleCursor This, IMESampleCursor cursor)
		{
			var cursor__handle__ = cursor!.GetNonNullHandle (nameof (cursor));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("samplesWithEarlierDTSsMayHaveLaterPTSsThanCursor:"), cursor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cursor);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("samplesWithLaterDTSsMayHaveEarlierPTSsThanCursor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SamplesWithLaterDtssMayHaveEarlierPtssThanCursor (IMESampleCursor cursor)
		{
			return _SamplesWithLaterDtssMayHaveEarlierPtssThanCursor (this, cursor);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _SamplesWithLaterDtssMayHaveEarlierPtssThanCursor (IMESampleCursor This, IMESampleCursor cursor)
		{
			var cursor__handle__ = cursor!.GetNonNullHandle (nameof (cursor));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("samplesWithLaterDTSsMayHaveEarlierPTSsThanCursor:"), cursor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cursor);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("chunkDetailsReturningError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual MESampleCursorChunk? GetChunkDetails (out NSError? error)
		{
			return _GetChunkDetails (this, out error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static MESampleCursorChunk? _GetChunkDetails (IMESampleCursor This, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			MESampleCursorChunk? ret;
			ret =  Runtime.GetNSObject<MESampleCursorChunk> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (This.Handle, Selector.GetHandle ("chunkDetailsReturningError:"), &errorValue), false)!;
			GC.KeepAlive (This);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("sampleLocationReturningError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual MESampleLocation? GetSampleLocation (out NSError? error)
		{
			return _GetSampleLocation (this, out error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static MESampleLocation? _GetSampleLocation (IMESampleCursor This, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			MESampleLocation? ret;
			ret =  Runtime.GetNSObject<MESampleLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (This.Handle, Selector.GetHandle ("sampleLocationReturningError:"), &errorValue), false)!;
			GC.KeepAlive (This);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("estimatedSampleLocationReturningError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual MEEstimatedSampleLocation? GetEstimatedSampleLocation (out NSError? error)
		{
			return _GetEstimatedSampleLocation (this, out error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static MEEstimatedSampleLocation? _GetEstimatedSampleLocation (IMESampleCursor This, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			MEEstimatedSampleLocation? ret;
			ret =  Runtime.GetNSObject<MEEstimatedSampleLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (This.Handle, Selector.GetHandle ("estimatedSampleLocationReturningError:"), &errorValue), false)!;
			GC.KeepAlive (This);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("refineSampleLocation:refinementData:refinementDataLength:refinedLocation:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool RefineSampleLocation (global::AVFoundation.AVSampleCursorStorageRange estimatedSampleLocation, global::System.Byte* refinementData, nuint refinementDataLength, out global::AVFoundation.AVSampleCursorStorageRange refinedLocation, out NSError? error)
		{
			return _RefineSampleLocation (this, estimatedSampleLocation, refinementData, refinementDataLength, out refinedLocation, out error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _RefineSampleLocation (IMESampleCursor This, global::AVFoundation.AVSampleCursorStorageRange estimatedSampleLocation, global::System.Byte* refinementData, nuint refinementDataLength, out global::AVFoundation.AVSampleCursorStorageRange refinedLocation, out NSError? error)
		{
			if (refinementData is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (refinementData));
			fixed (global::AVFoundation.AVSampleCursorStorageRange* refinedLocation__pointer = &refinedLocation) {
			NativeHandle errorValue = IntPtr.Zero;
			refinedLocation = default;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_AVSampleCursorStorageRange_Byte__UIntPtr_out_AVSampleCursorStorageRange_ref_NativeHandle (This.Handle, Selector.GetHandle ("refineSampleLocation:refinementData:refinementDataLength:refinedLocation:error:"), estimatedSampleLocation, refinementData, refinementDataLength, refinedLocation__pointer, &errorValue);
			GC.KeepAlive (This);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
			}
		}
		[global::Foundation.OptionalMember]
		[Export ("loadSampleBufferContainingSamplesToEndCursor:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadSampleBufferContainingSamples (IMESampleCursor? endSampleCursor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMESampleCursorLoadSampleBufferCallback))]MESampleCursorLoadSampleBufferCallback completionHandler)
		{
			_LoadSampleBufferContainingSamples (this, endSampleCursor, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _LoadSampleBufferContainingSamples (IMESampleCursor This, IMESampleCursor? endSampleCursor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMESampleCursorLoadSampleBufferCallback))]MESampleCursorLoadSampleBufferCallback completionHandler)
		{
			var endSampleCursor__handle__ = endSampleCursor.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMESampleCursorLoadSampleBufferCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("loadSampleBufferContainingSamplesToEndCursor:completionHandler:"), endSampleCursor__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (endSampleCursor);
		}
		[global::Foundation.OptionalMember]
		[Export ("loadPostDecodeProcessingMetadataWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadPostDecodeProcessingMetadata ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMESampleCursorLoadPostDecodeProcessingMetadataCallback))]MESampleCursorLoadPostDecodeProcessingMetadataCallback completionHandler)
		{
			_LoadPostDecodeProcessingMetadata (this, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _LoadPostDecodeProcessingMetadata (IMESampleCursor This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMESampleCursorLoadPostDecodeProcessingMetadataCallback))]MESampleCursorLoadPostDecodeProcessingMetadataCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMESampleCursorLoadPostDecodeProcessingMetadataCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("loadPostDecodeProcessingMetadataWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("CurrentSampleDuration")]
		[DynamicDependencyAttribute ("CurrentSampleFormatDescription")]
		[DynamicDependencyAttribute ("DecodeTimeOfLastSampleReachableByForwardSteppingThatIsAlreadyLoadedByByteSource")]
		[DynamicDependencyAttribute ("DecodeTimeStamp")]
		[DynamicDependencyAttribute ("DependencyInfo_Blittable")]
		[DynamicDependencyAttribute ("GetChunkDetails(Foundation.NSError@)")]
		[DynamicDependencyAttribute ("GetEstimatedSampleLocation(Foundation.NSError@)")]
		[DynamicDependencyAttribute ("GetSampleLocation(Foundation.NSError@)")]
		[DynamicDependencyAttribute ("HevcDependencyInfo")]
		[DynamicDependencyAttribute ("LoadPostDecodeProcessingMetadata(MediaExtension.MESampleCursorLoadPostDecodeProcessingMetadataCallback)")]
		[DynamicDependencyAttribute ("LoadSampleBufferContainingSamples(MediaExtension.IMESampleCursor,MediaExtension.MESampleCursorLoadSampleBufferCallback)")]
		[DynamicDependencyAttribute ("PresentationTimeStamp")]
		[DynamicDependencyAttribute ("RefineSampleLocation(AVFoundation.AVSampleCursorStorageRange,System.Byte*,System.UIntPtr,AVFoundation.AVSampleCursorStorageRange@,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("SamplesWithEarlierDtssMayHaveLaterPtssThanCursor(MediaExtension.IMESampleCursor)")]
		[DynamicDependencyAttribute ("SamplesWithLaterDtssMayHaveEarlierPtssThanCursor(MediaExtension.IMESampleCursor)")]
		[DynamicDependencyAttribute ("StepByDecodeTime(CoreMedia.CMTime,MediaExtension.MESampleCursorStepByTimeCallback)")]
		[DynamicDependencyAttribute ("StepByPresentationTime(CoreMedia.CMTime,MediaExtension.MESampleCursorStepByTimeCallback)")]
		[DynamicDependencyAttribute ("StepInDecodeOrder(System.Int64,MediaExtension.MESampleCursorStepInOrderCallback)")]
		[DynamicDependencyAttribute ("StepInPresentationOrder(System.Int64,MediaExtension.MESampleCursorStepInOrderCallback)")]
		[DynamicDependencyAttribute ("SyncInfo_Blittable")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MESampleCursorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMESampleCursor ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::CoreMedia.CMTime PresentationTimeStamp {
			[Export ("presentationTimeStamp")]
			get {
				return _GetPresentationTimeStamp (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::CoreMedia.CMTime _GetPresentationTimeStamp (IMESampleCursor This)
		{
			global::CoreMedia.CMTime ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (This.Handle, Selector.GetHandle ("presentationTimeStamp"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (This.Handle, Selector.GetHandle ("presentationTimeStamp"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::CoreMedia.CMTime DecodeTimeStamp {
			[Export ("decodeTimeStamp")]
			get {
				return _GetDecodeTimeStamp (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::CoreMedia.CMTime _GetDecodeTimeStamp (IMESampleCursor This)
		{
			global::CoreMedia.CMTime ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (This.Handle, Selector.GetHandle ("decodeTimeStamp"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (This.Handle, Selector.GetHandle ("decodeTimeStamp"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::CoreMedia.CMTime CurrentSampleDuration {
			[Export ("currentSampleDuration")]
			get {
				return _GetCurrentSampleDuration (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::CoreMedia.CMTime _GetCurrentSampleDuration (IMESampleCursor This)
		{
			global::CoreMedia.CMTime ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (This.Handle, Selector.GetHandle ("currentSampleDuration"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (This.Handle, Selector.GetHandle ("currentSampleDuration"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::CoreMedia.CMFormatDescription? CurrentSampleFormatDescription {
			[Export ("currentSampleFormatDescription")]
			get {
				return _GetCurrentSampleFormatDescription (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::CoreMedia.CMFormatDescription _GetCurrentSampleFormatDescription (IMESampleCursor This)
		{
			global::CoreMedia.CMFormatDescription ret;
			ret = CMFormatDescription.Create (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("currentSampleFormatDescription")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		internal virtual global::AVFoundation.AVSampleCursorChunkInfo_Blittable SyncInfo_Blittable {
			[Export ("syncInfo")]
			get {
				return _GetSyncInfo_Blittable (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::AVFoundation.AVSampleCursorChunkInfo_Blittable _GetSyncInfo_Blittable (IMESampleCursor This)
		{
			global::AVFoundation.AVSampleCursorChunkInfo_Blittable ret;
			ret = global::ObjCRuntime.Messaging.AVSampleCursorChunkInfo_Blittable_objc_msgSend (This.Handle, Selector.GetHandle ("syncInfo"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		internal virtual global::AVFoundation.AVSampleCursorDependencyInfo_Blittable DependencyInfo_Blittable {
			[Export ("dependencyInfo")]
			get {
				return _GetDependencyInfo_Blittable (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::AVFoundation.AVSampleCursorDependencyInfo_Blittable _GetDependencyInfo_Blittable (IMESampleCursor This)
		{
			global::AVFoundation.AVSampleCursorDependencyInfo_Blittable ret;
			ret = global::ObjCRuntime.Messaging.AVSampleCursorDependencyInfo_Blittable_objc_msgSend (This.Handle, Selector.GetHandle ("dependencyInfo"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual MEHevcDependencyInfo HevcDependencyInfo {
			[Export ("hevcDependencyInfo", ArgumentSemantic.Copy)]
			get {
				return _GetHevcDependencyInfo (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MEHevcDependencyInfo _GetHevcDependencyInfo (IMESampleCursor This)
		{
			MEHevcDependencyInfo ret;
			ret =  Runtime.GetNSObject<MEHevcDependencyInfo> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("hevcDependencyInfo")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual global::CoreMedia.CMTime DecodeTimeOfLastSampleReachableByForwardSteppingThatIsAlreadyLoadedByByteSource {
			[Export ("decodeTimeOfLastSampleReachableByForwardSteppingThatIsAlreadyLoadedByByteSource")]
			get {
				return _GetDecodeTimeOfLastSampleReachableByForwardSteppingThatIsAlreadyLoadedByByteSource (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::CoreMedia.CMTime _GetDecodeTimeOfLastSampleReachableByForwardSteppingThatIsAlreadyLoadedByByteSource (IMESampleCursor This)
		{
			global::CoreMedia.CMTime ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (This.Handle, Selector.GetHandle ("decodeTimeOfLastSampleReachableByForwardSteppingThatIsAlreadyLoadedByByteSource"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (This.Handle, Selector.GetHandle ("decodeTimeOfLastSampleReachableByForwardSteppingThatIsAlreadyLoadedByByteSource"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MESampleCursorWrapper : BaseWrapper, IMESampleCursor {
		public MESampleCursorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MESampleCursorWrapper))]
		static MESampleCursorWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("stepInDecodeOrderByCount:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void StepInDecodeOrder (long stepCount, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMESampleCursorStepInOrderCallback))]MESampleCursorStepInOrderCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMESampleCursorStepInOrderCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_Int64_NativeHandle (this.Handle, Selector.GetHandle ("stepInDecodeOrderByCount:completionHandler:"), stepCount, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("stepInPresentationOrderByCount:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void StepInPresentationOrder (long stepCount, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMESampleCursorStepInOrderCallback))]MESampleCursorStepInOrderCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMESampleCursorStepInOrderCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_Int64_NativeHandle (this.Handle, Selector.GetHandle ("stepInPresentationOrderByCount:completionHandler:"), stepCount, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("stepByDecodeTime:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void StepByDecodeTime (global::CoreMedia.CMTime deltaDecodeTime, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMESampleCursorStepByTimeCallback))]MESampleCursorStepByTimeCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMESampleCursorStepByTimeCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime_NativeHandle (this.Handle, Selector.GetHandle ("stepByDecodeTime:completionHandler:"), deltaDecodeTime, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("stepByPresentationTime:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void StepByPresentationTime (global::CoreMedia.CMTime deltaPresentationTime, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMESampleCursorStepByTimeCallback))]MESampleCursorStepByTimeCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMESampleCursorStepByTimeCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime_NativeHandle (this.Handle, Selector.GetHandle ("stepByPresentationTime:completionHandler:"), deltaPresentationTime, (IntPtr) block_ptr_completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::CoreMedia.CMTime PresentationTimeStamp {
			[Export ("presentationTimeStamp")]
			get {
				global::CoreMedia.CMTime ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, Selector.GetHandle ("presentationTimeStamp"));
				} else {
					ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, Selector.GetHandle ("presentationTimeStamp"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::CoreMedia.CMTime DecodeTimeStamp {
			[Export ("decodeTimeStamp")]
			get {
				global::CoreMedia.CMTime ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, Selector.GetHandle ("decodeTimeStamp"));
				} else {
					ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, Selector.GetHandle ("decodeTimeStamp"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::CoreMedia.CMTime CurrentSampleDuration {
			[Export ("currentSampleDuration")]
			get {
				global::CoreMedia.CMTime ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, Selector.GetHandle ("currentSampleDuration"));
				} else {
					ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, Selector.GetHandle ("currentSampleDuration"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::CoreMedia.CMFormatDescription? CurrentSampleFormatDescription {
			[Export ("currentSampleFormatDescription")]
			get {
				global::CoreMedia.CMFormatDescription ret;
				ret = CMFormatDescription.Create (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("currentSampleFormatDescription")), false)!;
				return ret;
			}
		}
	}
}
