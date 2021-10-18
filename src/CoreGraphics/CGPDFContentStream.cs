// 
// CGPDFContentStream.cs: Implement the managed CGPDFContentStream bindings
//
// Authors:
//	Sebastien Pouliot  <sebastien@xamarin.com>
//     
// Copyright 2014 Xamarin Inc. All rights reserved.

#nullable enable

using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using CoreFoundation;

namespace CoreGraphics {

	// CGPDFContentStream.h
	public class CGPDFContentStream : NativeObject {

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static /* CGPDFContentStreamRef */ IntPtr CGPDFContentStreamCreateWithPage (/* CGPDFPageRef */ IntPtr page);

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static /* CGPDFContentStreamRef */ IntPtr CGPDFContentStreamCreateWithStream (/* CGPDFStreamRef */ IntPtr stream, 
			/* CGPDFDictionaryRef */ IntPtr streamResources, /* CGPDFContentStreamRef */ IntPtr parent);

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static /* CGPDFContentStreamRef */ IntPtr CGPDFContentStreamRetain (/* CGPDFContentStreamRef */ IntPtr cs);

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static void CGPDFContentStreamRelease (/* CGPDFContentStreamRef */ IntPtr cs);

		public CGPDFContentStream (IntPtr handle)
			: base (handle, false)
		{
		}

		[Preserve (Conditional=true)]
		internal CGPDFContentStream (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}

		public CGPDFContentStream (CGPDFPage page)
			: base (CGPDFContentStreamCreateWithPage (page == null ? throw new ArgumentNullException (nameof (page)) : page.Handle), true)
		{
		}

		static IntPtr Create (CGPDFStream stream, NSDictionary? streamResources = null, CGPDFContentStream? parent = null)
		{
			if (stream is null)
				throw new ArgumentNullException (nameof (stream));

			return CGPDFContentStreamCreateWithStream (stream.Handle, streamResources.GetHandle (), parent.GetHandle ());
		}

		public CGPDFContentStream (CGPDFStream stream, NSDictionary? streamResources = null, CGPDFContentStream? parent = null)
			: base (Create (stream, streamResources, parent), true)
		{
		}

		protected override void Retain ()
		{
			CGPDFContentStreamRetain (GetCheckedHandle ());
		}

		protected override void Release ()
		{
			CGPDFContentStreamRelease (GetCheckedHandle ());
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static /* CFArrayRef */ IntPtr CGPDFContentStreamGetStreams (/* CGPDFContentStreamRef */ IntPtr cs);

		public CGPDFStream[] GetStreams ()
		{
			using (CFArray a = new CFArray (CGPDFContentStreamGetStreams (Handle))) {
				var streams = new CGPDFStream [a.Count];
				for (int i = 0; i < a.Count; i++)
					streams [i] = new CGPDFStream (a.GetValue (i));
				return streams;
				// note: CGPDFStreamRef is weird because it has no retain/release calls unlike other CGPDF* types
			}
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static /* CGPDFObjectRef */ IntPtr CGPDFContentStreamGetResource (/* CGPDFContentStreamRef */ IntPtr cs, /* const char* */ string category, /* const char* */ string name);

		public CGPDFObject? GetResource (string category, string name)
		{
			if (category is null)
				throw new ArgumentNullException (nameof (category));
			if (name is null)
				throw new ArgumentNullException (nameof (name));

			var h = CGPDFContentStreamGetResource (Handle, category, name);
			return (h == IntPtr.Zero) ? null : new CGPDFObject (h);
		}
	}
}
