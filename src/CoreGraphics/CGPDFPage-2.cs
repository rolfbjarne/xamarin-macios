// 
// CGPDFPage.cs: Implements the managed CGPDFPage
//
// Authors: Mono Team
//     
// Copyright 2009 Novell, Inc
// Copyright 2011, 2012 Xamarin Inc
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

#nullable enable

namespace CoreGraphics {

	// untyped enum -> CGPDFPage.h
	/// <summary>Type of box in a PDF document.</summary>
	public enum CGPDFBox {
		/// <summary>Indicates media.</summary>
		Media = 0,
		/// <summary>Indicates crop.</summary>
		Crop = 1,
		/// <summary>Indicates bleed.</summary>
		Bleed = 2,
		/// <summary>Indicates trim.</summary>
		Trim = 3,
		/// <summary>Indicates art.</summary>
		Art = 4,
	}

	// CGPDFPage.h
	/// <summary>A PDF Page in a PDF Document.</summary>
	///     <related type="sample" href="https://github.com/xamarin/ios-samples/tree/master/QuartzSample/">QuartzSample</related>
	///     <related type="sample" href="https://github.com/xamarin/ios-samples/tree/master/ZoomingPdfViewer/">ZoomingPdfViewer</related>
	public partial class CGPDFPage {
#if !COREBUILD
		[Preserve (Conditional = true)]
		internal CGPDFPage (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static /* CGPDFDocumentRef */ IntPtr CGPDFPageGetDocument (/* CGPDFPageRef */ IntPtr page);

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public CGPDFDocument Document {
			get {
				return new CGPDFDocument (CGPDFPageGetDocument (Handle), false);
			}
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static /* size_t */ nint CGPDFPageGetPageNumber (/* CGPDFPageRef */ IntPtr page);

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public nint PageNumber {
			get {
				return CGPDFPageGetPageNumber (Handle);
			}
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static CGRect CGPDFPageGetBoxRect (/* CGPDFPageRef */ IntPtr page, CGPDFBox box);

		/// <param name="box">The box.</param>
		///         <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		public CGRect GetBoxRect (CGPDFBox box)
		{
			return CGPDFPageGetBoxRect (Handle, box);
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static /* int */ int CGPDFPageGetRotationAngle (/* CGPDFPageRef */ IntPtr page);

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public int RotationAngle {
			get {
				return CGPDFPageGetRotationAngle (Handle);
			}
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static CGAffineTransform CGPDFPageGetDrawingTransform (/* CGPDFPageRef */ IntPtr page, CGPDFBox box, CGRect rect, int rotate, byte preserveAspectRatio);

		/// <param name="box">The box.</param>
		///         <param name="rect">The rect.</param>
		///         <param name="rotate">The rotate.</param>
		///         <param name="preserveAspectRatio">The preserve aspect ratio.</param>
		///         <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		public CGAffineTransform GetDrawingTransform (CGPDFBox box, CGRect rect, int rotate, bool preserveAspectRatio)
		{
			return CGPDFPageGetDrawingTransform (Handle, box, rect, rotate, preserveAspectRatio.AsByte ());
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static /* CGPDFDictionaryRef */ IntPtr CGPDFPageGetDictionary (/* CGPDFPageRef */ IntPtr page);

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public CGPDFDictionary Dictionary {
			get {
				return new CGPDFDictionary (CGPDFPageGetDictionary (Handle));
			}
		}
#endif // !COREBUILD
	}
}
