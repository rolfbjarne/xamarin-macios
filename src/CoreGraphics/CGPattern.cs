// 
// CGPatterncs.cs: Implements the managed CGPattern
//
// Authors: Mono Team
//     
// Copyright 2009 Novell, Inc
// Copyright 2014 Xamarin Inc.
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
using System;
using System.Runtime.InteropServices;

using CoreFoundation;
using ObjCRuntime;
using Foundation;

namespace CoreGraphics {

	// untyped enum -> CGPattern.h
	public enum CGPatternTiling {
		NoDistortion,
		ConstantSpacingMinimalDistortion,
		ConstantSpacing
	}

	// CGPattern.h
	delegate void DrawPatternCallback (/* void* */ IntPtr info, /* CGContextRef */ IntPtr c);
	delegate void ReleaseInfoCallback (/* void* */ IntPtr info);

	[StructLayout (LayoutKind.Sequential)]
	struct CGPatternCallbacks {
		internal /* unsigned int */ uint version;
		internal DrawPatternCallback draw;
		internal ReleaseInfoCallback release;
	}

	// CGPattern.h
	public class CGPattern : NativeObject
	{
#if !COREBUILD
		/* invoked by marshallers */
		public CGPattern (IntPtr handle)
			: base (handle, false)
		{
		}

		[Preserve (Conditional=true)]
		internal CGPattern (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}

		protected override void Retain () => CGPatternRetain (Handle);
		protected override void Release () => CGPatternRelease (Handle);
		
		// This is what we expose on the API
		public delegate void DrawPattern (CGContext ctx);

		[DllImport(Constants.CoreGraphicsLibrary)]
		extern static IntPtr CGPatternCreate (/* void* */ IntPtr info, CGRect bounds, CGAffineTransform matrix,
			/* CGFloat */ nfloat xStep, /* CGFloat */ nfloat yStep, CGPatternTiling tiling, [MarshalAs (UnmanagedType.I1)] bool isColored,
			/* const CGPatternCallbacks* */ ref CGPatternCallbacks callbacks);

		static CGPatternCallbacks callbacks = new CGPatternCallbacks () {
			version = 0,
			draw = DrawCallback,
			release = ReleaseCallback,
		};
		GCHandle gch;
		
		public CGPattern (CGRect bounds, CGAffineTransform matrix, nfloat xStep, nfloat yStep, CGPatternTiling tiling, bool isColored, DrawPattern drawPattern)
		{
			if (drawPattern == null)
				throw new ArgumentNullException (nameof (drawPattern));

			gch = GCHandle.Alloc (drawPattern);
			Handle = CGPatternCreate (GCHandle.ToIntPtr (gch), bounds, matrix, xStep, yStep, tiling, isColored, ref callbacks);
		}

#if !MONOMAC
		[MonoPInvokeCallback (typeof (DrawPatternCallback))]
#endif
		static void DrawCallback (IntPtr voidptr, IntPtr cgcontextptr)
		{
			GCHandle gch = GCHandle.FromIntPtr (voidptr);
			DrawPattern draw_pattern = (DrawPattern) gch.Target;
			using (var ctx = new CGContext (cgcontextptr))
				draw_pattern (ctx);
		}

#if !MONOMAC
		[MonoPInvokeCallback (typeof (ReleaseInfoCallback))]
#endif
		static void ReleaseCallback (IntPtr voidptr)
		{
			GCHandle gch = GCHandle.FromIntPtr (voidptr);
			gch.Free ();
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static void CGPatternRelease (/* CGPatternRef */ IntPtr pattern);

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static /* CGPatternRef */ IntPtr CGPatternRetain (/* CGPatternRef */ IntPtr pattern);
#endif // !COREBUILD
	}
}
