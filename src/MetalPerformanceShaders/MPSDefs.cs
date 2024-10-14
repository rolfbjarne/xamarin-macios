#nullable enable

using System;
using System.Runtime.InteropServices;

using Foundation;
using ObjCRuntime;
using Metal;

#if NET
using Vector3 = global::System.Numerics.Vector3;
using Vector4 = global::System.Numerics.Vector4;
#else
using Vector3 = global::OpenTK.Vector3;
using Vector4 = global::OpenTK.Vector4;
#endif

namespace MetalPerformanceShaders {

	// uses NSInteger
#if NET
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
#endif
	public struct MPSOffset {
		public nint X;
		public nint Y;
		public nint Z;
	}

	// really use double, not CGFloat
#if NET
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
#endif
	public struct MPSOrigin {
		public double X;
		public double Y;
		public double Z;
	}

	// really use double, not CGFloat
#if NET
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
#endif
	public struct MPSSize {
		public double Width;
		public double Height;
		public double Depth;
	}

	// uses NSUInteger
#if NET
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
#else
	[iOS (13, 0)]
	[TV (13, 0)]
#endif
	public struct MPSDimensionSlice {
		public nuint Start;
		public nuint Length;
	}

#if NET
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
#endif
	public struct MPSRegion {
		public MPSOrigin Origin;
		public MPSSize Size;
	}

	// really use double, not CGFloat
#if NET
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
#endif
	public struct MPSScaleTransform {
		public double ScaleX;
		public double ScaleY;
		public double TranslateX;
		public double TranslateY;
	}

#if NET
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
#endif
	public struct MPSImageCoordinate {
		public nuint X;
		public nuint Y;
		public nuint Channel;
	}

#if NET
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
#endif
	public struct MPSImageRegion {
		public MPSImageCoordinate Offset;
		public MPSImageCoordinate Size;
	}

	// MPSImageHistogram.h
#if NET
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
#endif
	[StructLayout (LayoutKind.Explicit)]
	public struct MPSImageHistogramInfo {
		[FieldOffset (0)]
		public nuint NumberOfHistogramEntries;
		[FieldOffset (8)]
		public bool HistogramForAlpha;
		[FieldOffset (16)]
		public Vector4 MinPixelValue;
		[FieldOffset (32)]
		public Vector4 MaxPixelValue;
	}

	// MPSTypes.h
	// FIXME: public delegate IMTLTexture MPSCopyAllocator (MPSKernel filter, IMTLCommandBuffer commandBuffer, IMTLTexture sourceTexture);
	public delegate NSObject MPSCopyAllocator (MPSKernel filter, NSObject commandBuffer, NSObject sourceTexture);
	// https://trello.com/c/GqtNId1C/517-generator-our-block-delegates-needs-to-use-wrapper-for-protocols

#if NET
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
#endif
	public struct MPSMatrixCopyOffsets {
		public uint SourceRowOffset;
		public uint SourceColumnOffset;
		public uint DestinationRowOffset;
		public uint DestinationColumnOffset;
	}

#if NET
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
#endif
	public struct MPSImageReadWriteParams {
		public nuint FeatureChannelOffset;
		public nuint NumberOfFeatureChannelsToReadWrite;
	}

#if NET
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
#endif
	public struct MPSImageKeypointRangeInfo {
		public nuint MaximumKeypoints;
		public float MinimumThresholdValue;
	}

#if NET
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
#endif
	public struct MPSStateTextureInfo {
		public nuint Width;
		public nuint Height;
		public nuint Depth;
		public nuint ArrayLength;

#pragma warning disable 0169 // Avoid warning when building core.dll and the unused reserved fields
		nuint _PixelFormat;
		nuint _TextureType;
		nuint _TextureUsage;

		//NSUInteger _reserved [4];
		nuint Reserved0;
		nuint Reserved1;
		nuint Reserved2;
		nuint Reserved3;
#pragma warning restore 0169
#if !COREBUILD
		public MTLPixelFormat PixelFormat {
			get => (MTLPixelFormat) (ulong) _PixelFormat;
			set => _PixelFormat = (nuint) (ulong) value;
		}

		public MTLTextureType TextureType {
			get => (MTLTextureType) (ulong) _TextureType;
			set => _TextureType = (nuint) (ulong) value;
		}

		public MTLTextureUsage TextureUsage {
			get => (MTLTextureUsage) (ulong) _TextureUsage;
			set => _TextureUsage = (nuint) (ulong) value;
		}
#endif
	}

#if NET
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
#endif
	[StructLayout (LayoutKind.Sequential)]
	public struct MPSAxisAlignedBoundingBox {
		public Vector3 Min;
		public Vector3 Max;
	}

#if NET
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
#endif
	public static class MPSConstants {
		public const uint FunctionConstantIndex = 127;
		public const uint BatchSizeIndex = 126;
		public const uint UserConstantIndex = 125;
		public const uint NDArrayConstantIndex = 124;
		// Maximum number of textures depends on the platform
		// MaxTextures = 128 or 32,
	}

#if NET
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
#endif
	[StructLayout (LayoutKind.Sequential)]
	public struct MPSMatrixOffset {
		public uint RowOffset;
		public uint ColumnOffset;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct MPSNDArrayOffsets {
		// NSInteger dimensions[16];
		nint dimension0;
		nint dimension1;
		nint dimension2;
		nint dimension3;
		nint dimension4;
		nint dimension5;
		nint dimension6;
		nint dimension7;
		nint dimension8;
		nint dimension9;
		nint dimension10;
		nint dimension11;
		nint dimension12;
		nint dimension13;
		nint dimension14;
		nint dimension15;

		public nint [] Dimensions {
			get => new nint [] {
						dimension0,
						dimension1,
						dimension2,
						dimension3,
						dimension4,
						dimension5,
						dimension6,
						dimension7,
						dimension8,
						dimension9,
						dimension10,
						dimension11,
						dimension12,
						dimension13,
						dimension14,
						dimension15,
					};
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				if (value.Length != 16)
					ObjCRuntime.ThrowHelper.ThrowArgumentOutOfRangeException (nameof (value), "Length must be 16.");

				dimension0 = value [0];
				dimension1 = value [1];
				dimension2 = value [2];
				dimension3 = value [3];
				dimension4 = value [4];
				dimension5 = value [5];
				dimension6 = value [6];
				dimension7 = value [7];
				dimension8 = value [8];
				dimension9 = value [9];
				dimension10 = value [10];
				dimension11 = value [11];
				dimension12 = value [12];
				dimension13 = value [13];
				dimension14 = value [14];
				dimension15 = value [15];
			}
		}
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct MPSNDArraySizes {
		// NSUInteger dimensions[16];
		nuint dimension0;
		nuint dimension1;
		nuint dimension2;
		nuint dimension3;
		nuint dimension4;
		nuint dimension5;
		nuint dimension6;
		nuint dimension7;
		nuint dimension8;
		nuint dimension9;
		nuint dimension10;
		nuint dimension11;
		nuint dimension12;
		nuint dimension13;
		nuint dimension14;
		nuint dimension15;

		public nuint [] Dimensions {
			get => new nuint [] {
						dimension0,
						dimension1,
						dimension2,
						dimension3,
						dimension4,
						dimension5,
						dimension6,
						dimension7,
						dimension8,
						dimension9,
						dimension10,
						dimension11,
						dimension12,
						dimension13,
						dimension14,
						dimension15,
					};
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				if (value.Length != 16)
					ObjCRuntime.ThrowHelper.ThrowArgumentOutOfRangeException (nameof (value), "Length must be 16.");

				dimension0 = value [0];
				dimension1 = value [1];
				dimension2 = value [2];
				dimension3 = value [3];
				dimension4 = value [4];
				dimension5 = value [5];
				dimension6 = value [6];
				dimension7 = value [7];
				dimension8 = value [8];
				dimension9 = value [9];
				dimension10 = value [10];
				dimension11 = value [11];
				dimension12 = value [12];
				dimension13 = value [13];
				dimension14 = value [14];
				dimension15 = value [15];
			}
		}
	}
}
