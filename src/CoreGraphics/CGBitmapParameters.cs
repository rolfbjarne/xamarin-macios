// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

#nullable enable

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

using ObjCRuntime;

namespace CoreGraphics {
	/// <summary>This struct contains values used when creating an adaptive bitmap context.</summary>
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[StructLayout (LayoutKind.Sequential)]
	public struct CGBitmapParameters {
		nuint width;
		nuint height;
		nuint bytesPerPixel;
		nuint alignedBytesPerRow; /* Rounded up to an appropriate value for bitmap data */
		CGComponent component;
		CGBitmapLayout layout;
		CGImagePixelFormatInfo format;
		IntPtr /* CGColorSpaceRef */ colorSpace;
		byte /* bool */ hasPremultipliedAlpha;
		nint /* CFByteOrder */ byteOrder;
		float edrTargetHeadroom;

		/// <summary>The width of the new <see cref="CGBitmapContext" />.</summary>
		public nuint Width {
			get => width;
			set => width = value;
		}

		/// <summary>The height of the new <see cref="CGBitmapContext" />.</summary>
		public nuint Height {
			get => height;
			set => height = value;
		}

		/// <summary>The number of bytes per pixel for the new <see cref="CGBitmapContext" />.</summary>
		public nuint BytesPerPixel {
			get => bytesPerPixel;
			set => bytesPerPixel = value;
		}

		/// <summary>The number of aligned bytes per row for the new <see cref="CGBitmapContext" />.</summary>
		public nuint AlignedBytesPerRow {
			get => alignedBytesPerRow;
			set => alignedBytesPerRow = value;
		}

		/// <summary>The <see cref="CGComponent" /> value for the new <see cref="CGBitmapContext" />.</summary>
		public CGComponent Component {
			get => component;
			set => component = value;
		}

		/// <summary>The <see cref="CGBitmapLayout" /> value for the new <see cref="CGBitmapContext" />.</summary>
		public CGBitmapLayout Layout {
			get => layout;
			set => layout = value;
		}

		/// <summary>The pixel format for the new <see cref="CGBitmapContext" />.</summary>
		public CGImagePixelFormatInfo Format {
			get => format;
			set => format = value;
		}

		/// <summary>The handle for the colorspace of the new <see cref="CGBitmapContext" />.</summary>
		public IntPtr ColorSpaceHandle {
			get => colorSpace;
			set => colorSpace = value;
		}

		/// <summary>The <see cref="CGColorSpace" /> for the new <see cref="CGBitmapContext" />.</summary>
		public CGColorSpace ColorSpace {
			get => Runtime.GetINativeObject<CGColorSpace> (colorSpace, false);
			set => colorSpace = value.GetNonNullHandle ();
		}

		/// <summary>Whether the new <see cref="CGBitmapContext" /> has premultiplied alpha values.</summary>
		public bool HasPremultipliedAlpha {
			get => hasPremultipliedAlpha != 0;
			set => hasPremultipliedAlpha = value.AsByte ();
		}

		/// <summary>The byte order for the new <see cref="CGBitmapContext" />.</summary>
		public CFByteOrder ByteOrder {
			get => (CFByteOrder) byteOrder;
			set => byteOrder = (nint) (long) value;
		}

		/// <summary>The EDR target headroom for the new <see cref="CGBitmapContext" />.</summary>
		public float EdrTargetHeadroom {
			get => edrTargetHeadroom;
			set => edrTargetHeadroom = value;
		}
	}
}
