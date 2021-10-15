//
// CGMutableImageMetadata.cs
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

using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace ImageIO {

#if !NET
	[iOS (7,0)]
#endif
	public class CGMutableImageMetadata : CGImageMetadata {

		[DllImport (Constants.ImageIOLibrary)]
		extern static /* CGMutableImageMetadataRef __nonnull */ IntPtr CGImageMetadataCreateMutable ();

		public CGMutableImageMetadata ()
			: base (CGImageMetadataCreateMutable (), true)
		{
		}

		[DllImport (Constants.ImageIOLibrary)]
		extern static /* CGMutableImageMetadataRef __nullable */ IntPtr CGImageMetadataCreateMutableCopy (
			/* CGImageMetadataRef __nonnull */ IntPtr metadata);

		public CGMutableImageMetadata (CGImageMetadata metadata)
			: base (CGImageMetadataCreateMutableCopy (ObjCRuntime.ThrowHelper.ThrowArgumentNullExceptionIfNeeded (metadata, nameof (metadata)).Handle), true)
		{
			if (metadata is null)
				throw new ArgumentNullException (nameof (metadata));
		}

		[DllImport (Constants.ImageIOLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		extern static bool CGImageMetadataRegisterNamespaceForPrefix (
			/* CGMutableImageMetadataRef __nonnull */ IntPtr metadata, /* CFStringRef __nonnull */ IntPtr xmlns,
			/* CFStringRef __nonnull */ IntPtr prefix, /* CFErrorRef __nullable */ out IntPtr error);

		public bool RegisterNamespace (NSString xmlns, NSString prefix, out NSError? error)
		{
			if (xmlns is null)
				throw new ArgumentNullException (nameof (xmlns));
			if (prefix is null)
				throw new ArgumentNullException (nameof (prefix));
			IntPtr err;
			bool result = CGImageMetadataRegisterNamespaceForPrefix (Handle, xmlns.Handle, prefix.Handle, out err);
			error = Runtime.GetNSObject<NSError> (err);
			return result;
		}

		[DllImport (Constants.ImageIOLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		extern static bool CGImageMetadataSetTagWithPath (/* CGMutableImageMetadataRef __nonnull */ IntPtr metadata,
			/* CGImageMetadataTagRef __nullable */ IntPtr parent, /* CFStringRef __nonnull */ IntPtr path,
			/* CGImageMetadataTagRef __nonnull */ IntPtr tag);

		public bool SetTag (CGImageMetadataTag? parent, NSString path, CGImageMetadataTag tag)
		{
			if (path is null)
				throw new ArgumentNullException (nameof (path));
			if (tag is null)
				throw new ArgumentNullException (nameof (tag));
			return CGImageMetadataSetTagWithPath (Handle, parent.GetHandle (), path.Handle, tag.Handle);
		}

		[DllImport (Constants.ImageIOLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		extern static bool CGImageMetadataSetValueWithPath (/* CGMutableImageMetadataRef __nonnull */ IntPtr metadata,
			/* CGImageMetadataTagRef __nullable */ IntPtr parent, /* CFStringRef __nonnull */ IntPtr path,
			/* CFTypeRef __nonnull */ IntPtr value);

		public bool SetValue (CGImageMetadataTag? parent, NSString path, NSObject value)
		{
			if (value is null)
				throw new ArgumentNullException (nameof (value));
			return SetValue (parent, path, value.Handle);
		}

		public bool SetValue (CGImageMetadataTag? parent, NSString path, bool value)
		{
			return SetValue (parent, path, value ? CFBoolean.TrueHandle : CFBoolean.FalseHandle);
		}

		bool SetValue (CGImageMetadataTag? parent, NSString path, IntPtr value)
		{
			if (path is null)
				throw new ArgumentNullException (nameof (path));
			return CGImageMetadataSetValueWithPath (Handle, parent.GetHandle (), path.Handle, value);
		}

		[DllImport (Constants.ImageIOLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		extern static bool CGImageMetadataRemoveTagWithPath (/* CGMutableImageMetadataRef __nonnull */ IntPtr metadata,
			/* CGImageMetadataTagRef __nullable */ IntPtr parent, /* CFStringRef __nonnull */ IntPtr path);

		public bool RemoveTag (CGImageMetadataTag? parent, NSString path)
		{
			if (path is null)
				throw new ArgumentNullException (nameof (path));
			return CGImageMetadataRemoveTagWithPath (Handle, parent.GetHandle (), path.Handle);
		}

		[DllImport (Constants.ImageIOLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		extern static bool CGImageMetadataSetValueMatchingImageProperty (
			/* CGMutableImageMetadataRef __nonnull */ IntPtr metadata,
			/* CFStringRef __nonnull */ IntPtr dictionaryName, /* CFStringRef __nonnull */ IntPtr propertyName,
			/* CFTypeRef __nonnull */ IntPtr value);

		public bool SetValueMatchingImageProperty (NSString dictionaryName, NSString propertyName, NSObject value)
		{
			if (value is null)
				throw new ArgumentNullException (nameof (value));
			return SetValueMatchingImageProperty (dictionaryName, propertyName, value.Handle);
		}

		public bool SetValueMatchingImageProperty (NSString dictionaryName, NSString propertyName, bool value)
		{
			return SetValueMatchingImageProperty (dictionaryName, propertyName, value ? CFBoolean.TrueHandle : CFBoolean.FalseHandle);
		}

		bool SetValueMatchingImageProperty (NSString dictionaryName, NSString propertyName, IntPtr value)
		{
			if (dictionaryName is null)
				throw new ArgumentNullException (nameof (dictionaryName));
			if (propertyName is null)
				throw new ArgumentNullException (nameof (propertyName));
			return CGImageMetadataSetValueMatchingImageProperty (Handle, dictionaryName.Handle, propertyName.Handle, value);
		}
	}
}
