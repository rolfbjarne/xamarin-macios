// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

#nullable enable

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[SupportedOSPlatform ("ios26.0")]
[SupportedOSPlatform ("tvos26.0")]
[SupportedOSPlatform ("macos26.0")]
[SupportedOSPlatform ("maccatalyst26.0")]
public class VTMotionEstimationSession : VTSession {

		[Preserve (Conditional = true)]
		internal VTMotionEstimationSession (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}

		[DllImport (Constants.VideoToolboxLibrary)]
		static extern unsafe VTStatus VTMotionEstimationSessionCreate (
			IntPtr /* CM_NULLABLE CFAllocatorRef */  allocator,
			IntPtr /* CM_NULLABLE CFDictionaryRef */  motionVectorProcessorSelectionOptions,
			uint width,
			uint height,
			IntPtr* /* CM_RETURNS_RETAINED_PARAMETER CM_NULLABLE VTMotionEstimationSessionRef * CM_NONNULL */ motionEstimationSessionOut);

		public static VTMotionEstimationSession? Create (NSDictionary? options, uint width, uint height, out VTStatus status)
		{
			IntPtr handle;
			unsafe {
				status = VTMotionEstimationSessionCreate (IntPtr.Zero, options.GetHandle (), width, height, &handle);
				GC.KeepAlive (options);
			}
			if (handle == IntPtr.Zero)
				return null;

			return new VTMotionEstimationSession (handle, true);
		}

		[DllImport (Constants.VideoToolboxLibrary)]
		static extern unsafe VTStatus /* OSStatus */ VTMotionEstimationSessionCopySourcePixelBufferAttributes (
			IntPtr /* CM_NONNULL VTMotionEstimationSessionRef */  motionEstimationSession,
			IntPtr* /* CM_RETURNS_RETAINED_PARAMETER CM_NULLABLE CFDictionaryRef * CM_NONNULL */ attributesOut);

		public unsafe bool TryGetPixelBufferAttributes ([NotNullWhen (true)] out NSDictionary? pixelBufferAttributes, out VTStatus status)
		{
			IntPtr handle;
			status = VTMotionEstimationSessionCopySourcePixelBufferAttributes (GetCheckedHandle (), &handle);
			pixelBufferAttributes = Runtime.GetNSObject<NSDictionary> (handle, owns: true);
			return status == 0 && pixelBufferAttributes is not null;
		}

		public CVPixelBufferAttributes? PixelBufferAttributes {
			get {
				if (TryGetPixelBufferAttributes (out var dict, out var _))
					return new CVPixelBufferAttributes (dict);
				return null;
			}
		}

		[DllImport (Constants.VideoToolboxLibrary)]
		static extern void VTMotionEstimationSessionInvalidate (
			IntPtr /* CM_NONNULL VTMotionEstimationSessionRef */  session);

		public void Invalidate ()
		{
			VTMotionEstimationSessionInvalidate (GetCheckedHandle ());
		}

		[DllImport (Constants.VideoToolboxLibrary)]
		static extern unsafe VTStatus /* OSStatus */ VTMotionEstimationSessionEstimateMotionVectors (
			IntPtr /* CM_NONNULL VTMotionEstimationSessionRef */  session,
			IntPtr /* CM_NONNULL CVPixelBufferRef */ referenceImage,
			IntPtr /* CM_NONNULL CVPixelBufferRef */ currentImage,
			VTMotionEstimationFrameFlags motionEstimationFrameFlags,
			IntPtr /* CM_NULLABLE CFDictionaryRef */ additionalFrameOptions,
			BlockLiteral* /* CM_NONNULL VTMotionEstimationOutputHandler */ outputHandler);

		[BindingImpl (BindingImplOptions.Optimizable)]
		public unsafe VTStatus EstimateMotionVectors (CVPixelBuffer referenceImage, CVPixelBuffer currentImage, VTMotionEstimationFrameFlags motionEstimationFrameFlags, NSDictionary? additionalFrameOptions, VTMotionEstimationOutputHandler outputHandler)
		{
			delegate* unmanaged<BlockLiteral*, VTStatus, VTMotionEstimationInfoFlags, IntPtr, IntPtr, void> trampoline = &OutputHandlerTrampoline;
			using var outputBlock = new BlockLiteral (trampoline, outputHandler, typeof (VTMotionEstimationSession), nameof (OutputHandlerTrampoline));

			var rv = VTMotionEstimationSessionEstimateMotionVectors (
						GetCheckedHandle (),
						referenceImage.GetNonNullHandle (nameof (referenceImage)),
						currentImage.GetNonNullHandle (nameof (currentImage)),
						motionEstimationFrameFlags,
						additionalFrameOptions.GetHandle (),
						&outputBlock);

			GC.KeepAlive (referenceImage);
			GC.KeepAlive (currentImage);
			GC.KeepAlive (additionalFrameOptions);

			return rv;
		}

		[UnmanagedCallersOnly]
		unsafe static void OutputHandlerTrampoline (BlockLiteral* block, VTStatus status, VTMotionEstimationInfoFlags infoFlags, IntPtr additionalInfo, IntPtr motionVectors)
		{
			var del = BlockLiteral.GetTarget<VTMotionEstimationOutputHandler> ((IntPtr) block);
			if (del is not null) {
				var motionVectorObj = motionVectors == IntPtr.Zero ? null : new CVPixelBuffer (motionVectors, false);
				del (status, infoFlags, Runtime.GetNSObject<NSDictionary> (additionalInfo, false), motionVectorObj);
			}
		}

		[DllImport (Constants.VideoToolboxLibrary)]
		static extern unsafe VTStatus /* OSStatus */ VTMotionEstimationSessionCompleteFrames (
			IntPtr /* CM_NONNULL VTMotionEstimationSessionRef */ session);

		public VTStatus CompleteFrames ()
		{
			return VTMotionEstimationSessionCompleteFrames (GetCheckedHandle ());
		}

		[DllImport (Constants.VideoToolboxLibrary)]
		static extern nuint VTMotionEstimationSessionGetTypeID ();

		/// <summary>Get this type's CFTypeID.</summary>
		public static nuint GetTypeId ()
		{
			return VTMotionEstimationSessionGetTypeID ();
		}
}

public delegate void VTMotionEstimationOutputHandler (
	VTStatus /* OSStatus */ status,
	VTMotionEstimationInfoFlags infoFlags,
	NSDictionary? additionalInfo,
	CVPixelBuffer? motionVectors);
