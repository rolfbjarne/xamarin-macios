#nullable enable

using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;

using CoreFoundation;

namespace CoreGraphics {

	/// <summary>Structure containing height and width values.</summary>
	[Serializable]
	public struct CGSize : IEquatable<CGSize> {
		nfloat width;
		nfloat height;

		/// <summary>Represents an empty size.</summary>
		public static readonly CGSize Empty;

#if !COREBUILD
		public static bool operator == (CGSize l, CGSize r)
		{
			// the following version of Equals cannot be removed by the linker, while == can be
			return l.Equals (r);
		}

		public static bool operator != (CGSize l, CGSize r)
		{
			return l.width != r.width || l.height != r.height;
		}

		public static CGSize operator + (CGSize l, CGSize r)
		{
			return new CGSize (l.width + r.Width, l.height + r.Height);
		}

		public static CGSize operator - (CGSize l, CGSize r)
		{
			return new CGSize (l.width - r.Width, l.height - r.Height);
		}

		public static implicit operator CGSize (SizeF size)
		{
			return new CGSize (size.Width, size.Height);
		}

		public static implicit operator CGSize (Size size)
		{
			return new CGSize (size.Width, size.Height);
		}

		public static explicit operator SizeF (CGSize size)
		{
			return new SizeF ((float) size.Width, (float) size.Height);
		}

		public static explicit operator Size (CGSize size)
		{
			return new Size ((int) size.Width, (int) size.Height);
		}

		public static explicit operator CGPoint (CGSize size)
		{
			return new CGPoint (size.Width, size.Height);
		}

		/// <param name="size1">The size1.</param>
		///         <param name="size2">The size2.</param>
		///         <summary>Adds two CGSize objects and returns the result.</summary>
		public static CGSize Add (CGSize size1, CGSize size2)
		{
			return size1 + size2;
		}

		/// <param name="size1">The size1.</param>
		///         <param name="size2">The size2.</param>
		///         <summary>Subtract.</summary>
		public static CGSize Subtract (CGSize size1, CGSize size2)
		{
			return size1 - size2;
		}

		/// <summary>The Width component of the CGSize.</summary>
		public nfloat Width {
			get { return width; }
			set { width = value; }
		}

		/// <summary>The height component of the CGSize.</summary>
		public nfloat Height {
			get { return height; }
			set { height = value; }
		}

		/// <summary>Returns true if the size is empty</summary>
		public bool IsEmpty {
			get { return width == 0.0 && height == 0.0; }
		}
#endif // !COREBUILD

		public CGSize (nfloat width, nfloat height)
		{
			this.width = width;
			this.height = height;
		}

#if !COREBUILD
		/// <param name="width">The width.</param>
		///         <param name="height">The height.</param>
		///         <summary>Creates a new <see cref="CGSize" /> instance.</summary>
		public CGSize (double width, double height)
		{
			this.width = (nfloat) width;
			this.height = (nfloat) height;
		}

		/// <param name="width">The width.</param>
		///         <param name="height">The height.</param>
		///         <summary>Creates a new <see cref="CGSize" /> instance.</summary>
		public CGSize (float width, float height)
		{
			this.width = width;
			this.height = height;
		}

		/// <param name="size">The size.</param>
		///         <summary>Initializes a CGSize object from another CGSize.</summary>
		public CGSize (CGSize size)
		{
			this.width = size.width;
			this.height = size.height;
		}

		/// <summary>Attempts to parse the contents of an <see cref="NSDictionary" /> with a serialized <see cref="CGSize" /> into a <see cref="CGSize" />.</summary>
		/// <param name="dictionaryRepresentation">The dictionary to parse.</param>
		/// <param name="size">If successful, the resulting <see cref="CGSize" /> value.</param>
		/// <returns><see langword="true" /> if the dictionary was serialized successfully, <see langword="false" /> otherwise.</returns>
		public static bool TryParse (NSDictionary? dictionaryRepresentation, out CGSize size)
		{
			if (dictionaryRepresentation is null) {
				size = Empty;
				return false;
			}
			unsafe {
				size = default;
				fixed (CGSize* sizePtr = &size) {
					bool result = NativeDrawingMethods.CGSizeMakeWithDictionaryRepresentation (dictionaryRepresentation.Handle, sizePtr) != 0;
					GC.KeepAlive (dictionaryRepresentation);
					return result;
				}
			}
		}

		/// <summary>Serializes a <see cref="CGSize" /> into an <see cref="Foundation.NSDictionary" />.</summary>
		/// <returns>A <see cref="Foundation.NSDictionary" /> with the values from this <see cref="CGSize" />.</returns>
		/// <remarks>
		///   <para>
		///     The returned dictionary conforms to the serialization
		///     standard of Cocoa and CocoaTouch and can be used to serialize
		///     the state into objects that can be parsed by other Apple APIs.
		///   </para>
		///   <para>
		///     It is possible to create a <see cref="CGSize" /> from an <see cref="NSDictionary" /> using
		///     the <see cref="TryParse(NSDictionary,out CGSize)" /> method.
		///   </para>
		/// </remarks>
		/// <seealso cref="ToCGSizeDictionary" />
		public NSDictionary ToDictionary ()
		{
			return new NSDictionary (NativeDrawingMethods.CGSizeCreateDictionaryRepresentation (this));
		}

		/// <summary>Serializes a <see cref="CGSize" /> into a <see cref="CGSizeDictionary" />.</summary>
		/// <returns>A <see cref="CGSizeDictionary" /> representing the values from this <see cref="CGSize" />.</returns>
		/// <seealso cref="ToDictionary" />
		public CGSizeDictionary ToCGSizeDictionary ()
		{
			return new CGSizeDictionary (ToDictionary ());
		}

		/// <param name="point">The point.</param>
		///         <summary>Initializes a CGSize object from a CGPoint.</summary>
		public CGSize (CGPoint point)
		{
			this.width = point.X;
			this.height = point.Y;
		}
#endif // !COREBUILD

		/// <param name="obj">The obj.</param>
		///         <summary>Compares the CGSize with another object.</summary>
		public override bool Equals (object? obj)
		{
			return (obj is CGSize t) && Equals (t);
		}

		/// <param name="size">The size.</param>
		///         <summary>Compares the size with the specified size.</summary>
		public bool Equals (CGSize size)
		{
			return size.width == width && size.height == height;
		}

		/// <summary>To be added.</summary>
		public override int GetHashCode ()
		{
			return HashCode.Combine (width, height);
		}

#if !COREBUILD
		public void Deconstruct (out nfloat width, out nfloat height)
		{
			width = Width;
			height = Height;
		}

		/// <summary>Tos rounded c g size.</summary>
		public CGSize ToRoundedCGSize ()
		{
			return new CGSize ((nfloat) Math.Round (width), (nfloat) Math.Round (height));
		}

		/// <summary>Converts the CGSize to a CGPOint.</summary>
		public CGPoint ToCGPoint ()
		{
			return (CGPoint) this;
		}

		/// <summary>To be added.</summary>
		public override string? ToString ()
		{
			return CFString.FromHandle (NSStringFromCGSize (this));
		}

#if MONOMAC
		// <quote>When building for 64 bit systems, or building 32 bit like 64 bit, NSSize is typedef’d to CGSize.</quote>
		// https://developer.apple.com/documentation/foundation/nssize?language=objc
		[DllImport (Constants.FoundationLibrary, EntryPoint = "NSStringFromSize")]
		extern static /* NSString* */ IntPtr NSStringFromCGSize (/* NSRect */ CGSize size);
#else
		[DllImport (Constants.UIKitLibrary)]
		extern static /* NSString* */ IntPtr NSStringFromCGSize (CGSize size);
#endif // MONOMAC
#endif // !COREBUILD
	}
}
