// Copyright 2009, Novell, Inc.
// Copyright 2010, Novell, Inc.
// Copyright 2011, 2012, 2014-2015 Xamarin Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
//

#nullable enable

namespace AVFoundation {
	/// <summary>A class that encapsulates the edge-widths used by an <see cref="AVFoundation.AVVideoCompositionRenderContext" />.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct AVEdgeWidths {
		/// <summary>The left edge width.</summary>
		public nfloat /* CGFloat */ Left;
		/// <summary>The top edge width.</summary>
		public nfloat /* CGFloat */ Top;
		/// <summary>The right edge width.</summary>
		public nfloat /* CGFloat */ Right;
		/// <summary>The bottom edge width.</summary>
		public nfloat /* CGFloat */ Bottom;

		public AVEdgeWidths (nfloat left, nfloat top, nfloat right, nfloat bottom)
		{
			Left = left;
			Top = top;
			Right = right;
			Bottom = bottom;
		}

		/// <summary>Returns a string representation of this edge widths value.</summary>
		public override string ToString ()
		{
			return string.Format ("(left={0},top={1},right={2},bottom={3})", Left, Top, Right, Bottom);
		}

		public static bool operator == (AVEdgeWidths left, AVEdgeWidths right)
		{
			return
				left.Left == right.Left &&
				left.Top == right.Top &&
				left.Right == right.Right &&
				left.Bottom == right.Bottom;
		}

		public static bool operator != (AVEdgeWidths left, AVEdgeWidths right)
		{
			return
				left.Left != right.Left ||
				left.Top != right.Top ||
				left.Right != right.Right ||
				left.Bottom != right.Bottom;
		}

		/// <summary>Returns the hash code for this edge widths value.</summary>
		public override int GetHashCode ()
		{
			return HashCode.Combine (Left, Top, Right, Bottom);
		}

		/// <param name="other">The other.</param>
		/// <summary>Determines whether this instance is equal to the specified object.</summary>
		public override bool Equals (object? other)
		{
			if (other is AVEdgeWidths) {
				var o = (AVEdgeWidths) other;

				return this == o;
			}
			return false;
		}
	}
}
