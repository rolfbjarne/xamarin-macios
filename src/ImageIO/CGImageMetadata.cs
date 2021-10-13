//
// CGImageMetadata.cs
//
// Authors:
//	Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2013-2014, Xamarin Inc.
//

#nullable enable

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

using ObjCRuntime;
using Foundation;
using CoreFoundation;

namespace ImageIO {

#if !NET
	[iOS (7,0)]
#endif
	public partial class CGImageMetadataEnumerateOptions {

		public bool Recursive { get; set; }

		internal NSMutableDictionary ToDictionary ()
		{
			var dict = new NSMutableDictionary ();

			if (Recursive)
				dict.LowlevelSetObject (CFBoolean.TrueHandle, kCGImageMetadataEnumerateRecursively);

			return dict;
		}
	}

	[return: MarshalAs (UnmanagedType.I1)]
	public delegate bool CGImageMetadataTagBlock (NSString path, CGImageMetadataTag tag);

	// CGImageMetadata.h
#if !NET
	[iOS (7,0)]
#endif
	public partial class CGImageMetadata : NativeObject {
		[Obsolete ("FIXME", error: true)] // TEMPORARY
		public CGImageMetadata (IntPtr handle)
			: base (handle, false)
		{
		}

		[Preserve (Conditional = true)]
		internal CGImageMetadata (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}

		[DllImport (Constants.ImageIOLibrary)]
		static extern /* CGImageMetadataRef __nullable */ IntPtr CGImageMetadataCreateFromXMPData (
			/* CFDataRef __nonnull */ IntPtr data);

		public CGImageMetadata (NSData data)
			: base (CGImageMetadataCreateFromXMPData (ObjCRuntime.ThrowHelper.ThrowArgumentNullExceptionIfNeeded (data, nameof (data)).Handle), true, true)
		{
		}

		[DllImport (Constants.ImageIOLibrary, EntryPoint="CGImageMetadataGetTypeID")]
		public extern static /* CFTypeID */ nint GetTypeID ();


		[DllImport (Constants.ImageIOLibrary)]
		extern static /* CFStringRef __nullable */ IntPtr CGImageMetadataCopyStringValueWithPath (
			/* CGImageMetadataRef __nonnull */ IntPtr metadata, /* CGImageMetadataTagRef __nullable */ IntPtr parent,
			/* CFStringRef __nonnull*/ IntPtr path);

		public NSString? GetStringValue (CGImageMetadata parent, NSString path)
		{
			// parent may be null
			if (path is null)
				throw new ArgumentNullException (nameof (path));
			IntPtr result = CGImageMetadataCopyStringValueWithPath (Handle, parent.GetHandle (), path.Handle);
			return Runtime.GetNSObject<NSString> (result);
		}

		[DllImport (Constants.ImageIOLibrary)]
		extern static /* CFArrayRef __nullable */ IntPtr CGImageMetadataCopyTags (
			/* CGImageMetadataRef __nonnull */ IntPtr metadata);

		public CGImageMetadataTag []? GetTags ()
		{
			IntPtr result = CGImageMetadataCopyTags (Handle);
			if (result == IntPtr.Zero)
				return null;
			using (var a = new CFArray (result)) {
				CGImageMetadataTag[] tags = new CGImageMetadataTag [a.Count];
				for (int i = 0; i < a.Count; i++)
					tags [i] = new CGImageMetadataTag (a.GetValue (i), false);
				return tags;
			}
		}

		[DllImport (Constants.ImageIOLibrary)]
		extern static /* CGImageMetadataTagRef __nullable */ IntPtr CGImageMetadataCopyTagWithPath (
			/* CGImageMetadataRef __nonnull */ IntPtr metadata, /* CGImageMetadataTagRef __nullable */ IntPtr parent,
			/* CFStringRef __nonnull */ IntPtr path);

		public CGImageMetadataTag? GetTag (CGImageMetadata parent, NSString path)
		{
			// parent may be null
			if (path is null)
				throw new ArgumentNullException (nameof (path));
			IntPtr result = CGImageMetadataCopyTagWithPath (Handle, parent.GetHandle (), path.Handle);
			return (result == IntPtr.Zero) ? null : new CGImageMetadataTag (result, true);
		}

		[DllImport (Constants.ImageIOLibrary)]
		extern static void CGImageMetadataEnumerateTagsUsingBlock (/* CGImageMetadataRef __nonnull */ IntPtr metadata,
			/* CFStringRef __nullable */ IntPtr rootPath, /* CFDictionaryRef __nullable */ IntPtr options,
			/* __nonnull */ CGImageMetadataTagBlock block);

		public void EnumerateTags (NSString rootPath, CGImageMetadataEnumerateOptions options, CGImageMetadataTagBlock block)
		{
			using var o = options?.ToDictionary ();
			CGImageMetadataEnumerateTagsUsingBlock (Handle, rootPath.GetHandle (), o.GetHandle (), block);
		}

		[DllImport (Constants.ImageIOLibrary)]
		extern static /* CFDataRef __nullable */ IntPtr CGImageMetadataCreateXMPData (
			/* CGImageMetadataRef __nonnull */ IntPtr metadata, /* CFDictionaryRef __nullable */ IntPtr options);

		public NSData? CreateXMPData ()
		{
			// note: there's no options defined for iOS7 (needs to be null)
			// we'll need to add an overload if this change in the future
			IntPtr result = CGImageMetadataCreateXMPData (Handle, IntPtr.Zero);
			return Runtime.GetNSObject<NSData> (result, true);
		}

		[DllImport (Constants.ImageIOLibrary)]
		extern static /* CGImageMetadataTagRef __nullable */ IntPtr CGImageMetadataCopyTagMatchingImageProperty (
			/* CGImageMetadataRef __nonnull */ IntPtr metadata, /* CFStringRef __nonnull */ IntPtr dictionaryName,
			/* CFStringRef __nonnull */ IntPtr propertyName);

		public CGImageMetadataTag? CopyTagMatchingImageProperty (NSString dictionaryName, NSString propertyName)
		{
			if (dictionaryName is null)
				throw new ArgumentNullException (nameof (dictionaryName));
			if (propertyName is null)
				throw new ArgumentNullException (nameof (propertyName));
			IntPtr result = CGImageMetadataCopyTagMatchingImageProperty (Handle, dictionaryName.Handle, propertyName.Handle);
			return result == IntPtr.Zero ? null : new CGImageMetadataTag (result, true);
		}
	}
}
