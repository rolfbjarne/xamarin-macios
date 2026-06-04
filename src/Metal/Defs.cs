//
// API for the Metal framework
//
// Authors:
//   Miguel de Icaza
//
// Copyrigh 2014, Xamarin Inc.
//
using System.ComponentModel;

using ModelIO;

#nullable enable

namespace Metal {
	/// <summary>The location of APixel in an image or texture.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public struct MTLOrigin {
		/// <summary>The x.</summary>
		public nint X;
		/// <summary>The y.</summary>
		public nint Y;
		/// <summary>The z.</summary>
		public nint Z;

		public MTLOrigin (nint x, nint y, nint z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		/// <summary>Returns a string representation of this instance.</summary>
		public override string ToString ()
		{
			return String.Format ("({0},{1},{2})", X, Y, Z);
		}
	}

	/// <summary>The dimensions of a grid, image, texture, or threadgroup.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public struct MTLSize {
		/// <summary>The width.</summary>
		public nint Width;
		/// <summary>The height.</summary>
		public nint Height;
		/// <summary>The depth.</summary>
		public nint Depth;

		public MTLSize (nint width, nint height, nint depth)
		{
			Width = width;
			Height = height;
			Depth = depth;
		}
	}

#if !COREBUILD
	/// <summary>Extension methods for <see cref="Metal.MTLVertexFormat" />.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public static class MTLVertexFormatExtensions {

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[DllImport (Constants.MetalKitLibrary)]
		static extern /* MDLVertexFormat */ nuint MTKModelIOVertexFormatFromMetal (/* MTLVertexFormat */ nuint modelIODescriptor);

		/// <param name="vertexFormat">The target vertex format.</param>
		///         <summary>Converts from the current to the desired <paramref name="vertexFormat" />.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		public static MDLVertexFormat ToModelVertexFormat (this MTLVertexFormat vertexFormat)
		{
			nuint mdlVertexFormat = MTKModelIOVertexFormatFromMetal ((nuint) (ulong) vertexFormat);
			return (MDLVertexFormat) (ulong) mdlVertexFormat;
		}
	}
#endif

	/// <summary>The retangle used for the scissor fragment test.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public struct MTLScissorRect {
		/// <summary>The x.</summary>
		public nuint X;
		/// <summary>The y.</summary>
		public nuint Y;
		/// <summary>The width.</summary>
		public nuint Width;
		/// <summary>The height.</summary>
		public nuint Height;

		public MTLScissorRect (nuint x, nuint y, nuint width, nuint height)
		{
			X = x;
			Y = y;
			Width = width;
			Height = height;
		}

		/// <summary>Returns a string representation of this instance.</summary>
		public override string ToString ()
		{
			return String.Format ("({0},{1},{2},{3}", X, Y, Width, Height);
		}
	}

	/// <summary>Defines the clipping viewport.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public struct MTLViewport {
		/// <summary>The origin x.</summary>
		public double OriginX;
		/// <summary>The origin y.</summary>
		public double OriginY;
		/// <summary>The width.</summary>
		public double Width;
		/// <summary>The height.</summary>
		public double Height;
		/// <summary>The z near.</summary>
		public double ZNear;
		/// <summary>The z far.</summary>
		public double ZFar;

		/// <param name="originX">The x origin.</param>
		/// <param name="originY">The y origin.</param>
		/// <param name="width">The width.</param>
		/// <param name="height">The height.</param>
		/// <param name="znear">The near depth value.</param>
		/// <param name="zfar">The far depth value.</param>
		/// <summary>Creates a viewport with the specified dimensions.</summary>
		public MTLViewport (double originX, double originY, double width, double height, double znear, double zfar)
		{
			OriginX = originX;
			OriginY = originY;
			Width = width;
			Height = height;
			ZNear = znear;
			ZFar = zfar;
		}

		/// <summary>Returns a string representation of this instance.</summary>
		public override string ToString ()
		{
			return String.Format ("({0},{1},{2},{3} Znear={4} Zfar={5})", OriginX, OriginY, Width, Height, ZNear, ZFar);
		}
	}

	/// <summary>A sample position.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct MTLSamplePosition {
		/// <summary>The X value, in the range [0.0, 1.0).</summary>
		public float X;

		/// <summary>The Y value, in the range [0.0, 1.0).</summary>
		public float Y;

		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		///         <summary>Creates a new normalized sample position.</summary>
		public MTLSamplePosition (float x, float y)
		{
			this.X = x;
			this.Y = y;
		}
	}

	/// <summary>An RGBA color representing a clear pixel.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public struct MTLClearColor {
		/// <summary>The red.</summary>
		public double Red;
		/// <summary>The green.</summary>
		public double Green;
		/// <summary>The blue.</summary>
		public double Blue;
		/// <summary>The alpha.</summary>
		public double Alpha;

		/// <param name="red">The red component.</param>
		/// <param name="green">The green component.</param>
		/// <param name="blue">The blue component.</param>
		/// <param name="alpha">The alpha component.</param>
		/// <summary>Creates a clear color with the specified RGBA values.</summary>
		public MTLClearColor (double red, double green, double blue, double alpha)
		{
			Red = red;
			Green = green;
			Blue = blue;
			Alpha = alpha;
		}
	}

	/// <summary>A rectangle of pixels in an image or texture.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public struct MTLRegion {
		/// <summary>The origin of the region.</summary>
		public MTLOrigin Origin;
		/// <summary>The size of the region.</summary>
		public MTLSize Size;

		/// <param name="origin">The origin.</param>
		/// <param name="size">The size.</param>
		/// <summary>Creates a region with the specified origin and size.</summary>
		public MTLRegion (MTLOrigin origin, MTLSize size)
		{
			Origin = origin;
			Size = size;
		}

		public static MTLRegion Create1D (nuint x, nuint width)
		{
			return Create1D ((nint) x, (nint) width);
		}

		public static MTLRegion Create1D (nint x, nint width)
		{
			var region = new MTLRegion ();
			region.Origin.X = x;
			region.Origin.Y = 0;
			region.Origin.Z = 0;
			region.Size.Width = width;
			region.Size.Height = 1;
			region.Size.Depth = 1;
			return region;
		}

		public static MTLRegion Create2D (nuint x, nuint y, nuint width, nuint height)
		{
			return Create2D ((nint) x, (nint) y, (nint) width, (nint) height);
		}

		public static MTLRegion Create2D (nint x, nint y, nint width, nint height)
		{
			var region = new MTLRegion ();
			region.Origin.X = x;
			region.Origin.Y = y;
			region.Origin.Z = 0;
			region.Size.Width = width;
			region.Size.Height = height;
			region.Size.Depth = 1;
			return region;
		}

		public static MTLRegion Create3D (nuint x, nuint y, nuint z, nuint width, nuint height, nuint depth)
		{
			return Create3D ((nint) x, (nint) y, (nint) z, (nint) width, (nint) height, (nint) depth);
		}

		public static MTLRegion Create3D (nint x, nint y, nint z, nint width, nint height, nint depth)
		{
			var region = new MTLRegion ();
			region.Origin.X = x;
			region.Origin.Y = y;
			region.Origin.Z = z;
			region.Size.Width = width;
			region.Size.Height = height;
			region.Size.Depth = depth;
			return region;
		}
	}

	/// <summary>Struct that contains values that are used to clear various buffers and stencils.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[StructLayout (LayoutKind.Explicit)]
	public struct MTLClearValue {
		/// <summary>The clear color value.</summary>
		[FieldOffset (0)]
		public MTLClearColor Color;
		/// <summary>The depth.</summary>
		[FieldOffset (0)]
		public double Depth;
		/// <summary>The stencil clear value.</summary>
		[FieldOffset (0)]
		public ulong Stencil;

		/// <param name="color">The color.</param>
		/// <summary>Creates a clear value with the specified color.</summary>
		public MTLClearValue (MTLClearColor color)
		{
			Depth = 0;
			Stencil = 0;
			Color = color;
		}

		/// <param name="depth">The depth.</param>
		/// <summary>Creates a clear value with the specified depth.</summary>
		public MTLClearValue (double depth)
		{
			Color.Red = 0;
			Stencil = 0;

			Depth = depth;
			Color.Green = 0;
			Color.Blue = 0;
			Color.Alpha = 0;
		}

		/// <param name="stencil">The stencil.</param>
		/// <summary>Creates a clear value with the specified stencil.</summary>
		public MTLClearValue (ulong stencil)
		{
			Color.Red = 0;
			Depth = 0;

			Stencil = stencil;
			Color.Green = 0;
			Color.Blue = 0;
			Color.Alpha = 0;
		}
	}

	/// <summary>Represents the number of threadgroups in each grid dimension for indirectly dispatched threadgroups.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public struct MTLDispatchThreadgroupsIndirectArguments {
		/// <summary>Gets the threadgrops for the first dimension of the grid.</summary>
		public uint ThreadGroupsPerGrid1;
		/// <summary>Gets the threadgrops for the second dimension of the grid.</summary>
		public uint ThreadGroupsPerGrid2;
		/// <summary>Gets the threadgrops for the third dimension of the grid.</summary>
		public uint ThreadGroupsPerGrid3;
	}

	/// <summary>Represents a Metal stage in region indirect arguments.</summary>
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[StructLayout (LayoutKind.Sequential)]
	public struct MTLStageInRegionIndirectArguments {
		/// <summary>The stage in origin1.</summary>
		public uint StageInOrigin1;
		/// <summary>The stage in origin2.</summary>
		public uint StageInOrigin2;
		/// <summary>The stage in origin3.</summary>
		public uint StageInOrigin3;

		/// <summary>The stage in size1.</summary>
		public uint StageInSize1;
		/// <summary>The stage in size2.</summary>
		public uint StageInSize2;
		/// <summary>The stage in size3.</summary>
		public uint StageInSize3;
	}

	/// <summary>Represents the data layout needed to draw primitives.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public struct MTLDrawPrimitivesIndirectArguments {
		/// <summary>The number of vertices.</summary>
		public uint VertexCount;
		/// <summary>The number instances.</summary>
		public uint InstanceCount;
		/// <summary>The first vertex.</summary>
		public uint VertexStart;
		/// <summary>The first primitive.</summary>
		public uint BaseInstance;
	}

	/// <summary>Represents the data layout needed to draw indexed primitives.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public struct MTLDrawIndexedPrimitivesIndirectArguments {
		/// <summary>The number of indices to read from the index buffer for each instance.</summary>
		public uint IndexCount;
		/// <summary>The number of instances.</summary>
		public uint InstanceCount;
		/// <summary>The first index.</summary>
		public uint IndexStart;
		/// <summary>The first vertex.</summary>
		public uint BaseVertex;
		/// <summary>The first primitive.</summary>
		public uint BaseInstance;
	}

	/// <summary>Represents a Metal size and align.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[StructLayout (LayoutKind.Sequential)]
	public struct MTLSizeAndAlign {
		/// <summary>The size.</summary>
		public nuint Size;
		/// <summary>The align.</summary>
		public nuint Align;

		public MTLSizeAndAlign (nuint size, nuint align)
		{
			Size = size;
			Align = align;
		}

	}

	/// <summary>Represents a Metal draw patch indirect arguments.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[StructLayout (LayoutKind.Sequential)]
	public struct MTLDrawPatchIndirectArguments {
		/// <summary>The patch count.</summary>
		public uint PatchCount;
		/// <summary>The instance count.</summary>
		public uint InstanceCount;
		/// <summary>The patch start.</summary>
		public uint PatchStart;
		/// <summary>The base instance.</summary>
		public uint BaseInstance;

		/// <param name="pathCount">The pathCount.</param>
		/// <param name="instanceCount">The instanceCount.</param>
		/// <param name="patchStart">The patchStart.</param>
		/// <param name="baseInstance">The baseInstance.</param>
		/// <summary>Creates draw patch indirect arguments.</summary>
		public MTLDrawPatchIndirectArguments (uint pathCount, uint instanceCount, uint patchStart, uint baseInstance)
		{
			PatchCount = pathCount;
			InstanceCount = instanceCount;
			PatchStart = patchStart;
			BaseInstance = baseInstance;
		}

	}

	/// <summary>Represents a Metal quad tessellation factors half.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[StructLayout (LayoutKind.Sequential)]
	public struct MTLQuadTessellationFactorsHalf {
#if XAMCORE_5_0
		ushort edgeTessellationFactor0;
		ushort edgeTessellationFactor1;
		ushort edgeTessellationFactor2;
		ushort edgeTessellationFactor3;
		ushort insideTessellationFactor0;
		ushort insideTessellationFactor1;

		public ushort [] EdgeTessellationFactor {
			get => new ushort [] { edgeTessellationFactor0, edgeTessellationFactor1, edgeTessellationFactor2, edgeTessellationFactor3 };
			set {
				if (value.Length > 4)
					throw new ArgumentOutOfRangeException ($"The '{nameof (value)}' array length can't be greater than 4.");

				edgeTessellationFactor0 = value.Length >= 1 ? value [0] : 0;
				edgeTessellationFactor1 = value.Length >= 2 ? value [1] : 0;
				edgeTessellationFactor2 = value.Length >= 3 ? value [2] : 0;
				edgeTessellationFactor3 = value.Length >= 4 ? value [3] : 0;
			}
		}

		public ushort [] InsideTessellationFactor {
			get => new ushort [] { insideTessellationFactor0, insideTessellationFactor1 };
			set {
				if (value.Length > 2)
					throw new ArgumentOutOfRangeException ($"The '{nameof (value)}' array length can't be greater than 2.");

				insideTessellationFactor0 = value.Length >= 1 ? value [0] : 0;
				insideTessellationFactor1 = value.Length >= 2 ? value [1] : 0;
			}
		}
#else
		/// <summary>The edge tessellation factors.</summary>
		[MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
		public ushort [] EdgeTessellationFactor;
		/// <summary>The inside tessellation factors.</summary>
		[MarshalAs (UnmanagedType.ByValArray, SizeConst = 2)]
		public ushort [] InsideTessellationFactor;
#endif

		/// <param name="edgeTessellationFactor">The edgeTessellationFactor.</param>
		/// <param name="insideTessellationFactor">The insideTessellationFactor.</param>
		/// <summary>Creates quad tessellation factors with the specified values.</summary>
		public MTLQuadTessellationFactorsHalf (ushort [] edgeTessellationFactor, ushort [] insideTessellationFactor)
		{
			if (edgeTessellationFactor.Length > 4)
				throw new ArgumentOutOfRangeException ($"The '{nameof (edgeTessellationFactor)}' array length can't be greater than 4.");

			if (insideTessellationFactor.Length > 2)
				throw new ArgumentOutOfRangeException ($"The '{nameof (insideTessellationFactor)}' array length can't be greater than 2.");
#if XAMCORE_5_0
			edgeTessellationFactor0 = edgeTessellationFactor.Length >= 1 ? edgeTessellationFactor [0] : 0;
			edgeTessellationFactor1 = edgeTessellationFactor.Length >= 2 ? edgeTessellationFactor [1] : 0;
			edgeTessellationFactor2 = edgeTessellationFactor.Length >= 3 ? edgeTessellationFactor [2] : 0;
			edgeTessellationFactor3 = edgeTessellationFactor.Length >= 4 ? edgeTessellationFactor [3] : 0;
			insideTessellationFactor0 = insideTessellationFactor.Length >= 1 ? insideTessellationFactor [0] : 0;
			insideTessellationFactor1 = insideTessellationFactor.Length >= 2 ? insideTessellationFactor [1] : 0;
#else
			EdgeTessellationFactor = edgeTessellationFactor;
			InsideTessellationFactor = insideTessellationFactor;
#endif
		}

	}

	/// <summary>Represents a Metal triangle tessellation factors half.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[StructLayout (LayoutKind.Sequential)]
	public struct MTLTriangleTessellationFactorsHalf {
#if XAMCORE_5_0
		ushort edgeTessellationFactor0;
		ushort edgeTessellationFactor1;
		ushort edgeTessellationFactor2;

		public ushort [] EdgeTessellationFactor {
			get => new ushort [] { edgeTessellationFactor0, edgeTessellationFactor1, edgeTessellationFactor2 };
			set {
				if (value.Length > 3)
					throw new ArgumentOutOfRangeException ($"The '{nameof (value)}' array length can't be greater than 3.");
				edgeTessellationFactor0 = value.Length >= 1 ? value [0] : 0;
				edgeTessellationFactor1 = value.Length >= 2 ? value [1] : 0;
				edgeTessellationFactor2 = value.Length >= 3 ? value [2] : 0;
			}
		}
#else
		/// <summary>The edge tessellation factors.</summary>
		[MarshalAs (UnmanagedType.ByValArray, SizeConst = 3)]
		public ushort [] EdgeTessellationFactor;
#endif
		/// <summary>The inside tessellation factor.</summary>
		public ushort InsideTessellationFactor;

		/// <param name="edgeTessellationFactor">The edgeTessellationFactor.</param>
		/// <param name="insideTessellationFactor">The insideTessellationFactor.</param>
		/// <summary>Creates triangle tessellation factors with the specified values.</summary>
		public MTLTriangleTessellationFactorsHalf (ushort [] edgeTessellationFactor, ushort insideTessellationFactor)
		{
			if (edgeTessellationFactor.Length > 3)
				throw new ArgumentOutOfRangeException ($"The '{nameof (edgeTessellationFactor)}' array length can't be greater than 3.");
#if XAMCORE_5_0
			edgeTessellationFactor0 = edgeTessellationFactor.Length >= 1 ? edgeTessellationFactor [0] : 0;
			edgeTessellationFactor1 = edgeTessellationFactor.Length >= 2 ? edgeTessellationFactor [1] : 0;
			edgeTessellationFactor2 = edgeTessellationFactor.Length >= 3 ? edgeTessellationFactor [2] : 0;
#else
			EdgeTessellationFactor = edgeTessellationFactor;
#endif
			InsideTessellationFactor = insideTessellationFactor;
		}
	}

#if COREBUILD
	// IMTLCommandBuffer and IMTLTexture visibility are needed for MPSCopyAllocator - but they are generated later

	public partial interface IMTLCommandBuffer {
	}

	public partial interface IMTLTexture {
	}
#endif // COREBUILD
#if MONOMAC
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	public struct MTLIndirectCommandBufferExecutionRange {
		public uint Location;
		public uint Length;

		public MTLIndirectCommandBufferExecutionRange (uint location, uint length)
		{
			Location = location;
			Length = length;
		}
	}
#endif // MONOMAC

	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[StructLayout (LayoutKind.Sequential)]
	public struct MTLTextureSwizzleChannels {
#if COREBUILD
		// keep size identical
		byte Red;
		byte Green;
		byte Blue;
		byte Alpha;
#else
		public MTLTextureSwizzle Red;

		public MTLTextureSwizzle Green;

		public MTLTextureSwizzle Blue;

		public MTLTextureSwizzle Alpha;
#endif
	}

#if IOS || MONOMAC || COREBUILD || TVOS
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos16.0")]
	[StructLayout (LayoutKind.Sequential)]
	public struct MTLVertexAmplificationViewMapping {
		public uint ViewportArrayIndexOffset;

		public uint RenderTargetArrayIndexOffset;
	}

	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos17.0")]
	[StructLayout (LayoutKind.Sequential)]
	public struct MTLCoordinate2D {
		public float X;

		public float Y;
	}
#endif

	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos16.1")]
	[StructLayout (LayoutKind.Sequential)]
	public struct MTLAccelerationStructureSizes {
		public nuint AccelerationStructureSize;

		public nuint BuildScratchBufferSize;

		public nuint RefitScratchBufferSize;
	}

	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[NativeName ("MTLResourceID")]
	[StructLayout (LayoutKind.Sequential)]
	public struct MTLResourceId {
		public ulong Impl;
	}

	/// <summary>A struct that represents a range of a Metal buffer.</summary>
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	public struct MTL4BufferRange {
		ulong bufferAddress;
		ulong length;

		/// <summary>The address of the buffer, including any offsets.</summary>
		public ulong BufferAddress {
			get => bufferAddress;
			set => bufferAddress = value;
		}

		/// <summary>The length of the buffer. <see cref="ulong.MaxValue" /> specifies until the end of the buffer.</summary>
		public ulong Length {
			get => length;
			set => length = value;
		}

		/// <summary>Create a new <see cref="MTL4BufferRange" /> with the specified buffer address and length.</summary>
		/// <param name="bufferAddress">The buffer address, including any offest into the buffer.</param>
		/// <param name="length">The length of the buffer.</param>
		public MTL4BufferRange (ulong bufferAddress, ulong length)
		{
			this.bufferAddress = bufferAddress;
			this.length = length;
		}

		/// <summary>Create a new <see cref="MTL4BufferRange" /> with the specified buffer address and length until the end of the buffer.</summary>
		/// <param name="bufferAddress">The buffer address, including any offest into the buffer.</param>
		public MTL4BufferRange (ulong bufferAddress)
			: this (bufferAddress, ulong.MaxValue)
		{
		}

		/// <summary>Create a new <see cref="MTL4BufferRange" /> with all zero values.</summary>
		public MTL4BufferRange ()
		{
		}
	}
}
