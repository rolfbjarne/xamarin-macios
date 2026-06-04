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
	/// <summary>Audio conversion priming information.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct AVAudioConverterPrimeInfo {
		/// <summary>The leading frames.</summary>
		public uint LeadingFrames;
		/// <summary>The trailing frames.</summary>
		public uint TrailingFrames;

		/// <param name="leadingFrames">The leading frames.</param>
		///         <param name="trailingFrames">The trailing frames.</param>
		///         <summary>Creates a new <see cref="AVAudioConverterPrimeInfo" /> instance.</summary>
		public AVAudioConverterPrimeInfo (uint leadingFrames, uint trailingFrames)
		{
			LeadingFrames = leadingFrames;
			TrailingFrames = trailingFrames;
		}

		/// <summary>To be added.</summary>
		public override string ToString ()
		{
			return $"({LeadingFrames}:{TrailingFrames})";
		}

		public static bool operator == (AVAudioConverterPrimeInfo left, AVAudioConverterPrimeInfo right)
		{
			return left.Equals (right);
		}

		public static bool operator != (AVAudioConverterPrimeInfo left, AVAudioConverterPrimeInfo right)
		{
			return !left.Equals (right);
		}

		/// <param name="obj">The obj.</param>
		///         <summary>To be added.</summary>
		public override bool Equals (object? obj)
		{
			if (!(obj is AVAudioConverterPrimeInfo))
				return false;

			return this.Equals ((AVAudioConverterPrimeInfo) obj);
		}

		/// <param name="other">The other.</param>
		///         <summary>Equals.</summary>
		public bool Equals (AVAudioConverterPrimeInfo other)
		{
			return LeadingFrames == other.LeadingFrames && TrailingFrames == other.TrailingFrames;
		}

		/// <summary>To be added.</summary>
		public override int GetHashCode ()
		{
			return HashCode.Combine (LeadingFrames, TrailingFrames);
		}
	}
}
