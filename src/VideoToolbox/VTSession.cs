// 
// VTSession.cs: Property setting/reading
//
// Authors: Miguel de Icaza (miguel@xamarin.com)
//     
// Copyright 2014-2015 Xamarin Inc.
//
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

using CoreFoundation;
using ObjCRuntime;
using Foundation;
using CoreMedia;
using CoreVideo;

namespace VideoToolbox {		

#if NET
	[SupportedOSPlatform ("tvos10.2")]
#else
	[iOS (8,0), TV (10,2)]
#endif
	public class VTSession : NativeObject {
		protected internal VTSession (IntPtr handle)
			: base (handle, false)
		{
		}

		[Preserve (Conditional=true)]
		internal VTSession (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}

		// All of them returns OSStatus mapped to VTStatus enum

		[DllImport (Constants.VideoToolboxLibrary)]
		extern static VTStatus VTSessionSetProperty (IntPtr handle, IntPtr propertyKey, IntPtr value);

		[DllImport (Constants.VideoToolboxLibrary)]
		extern static VTStatus VTSessionCopyProperty (IntPtr handle, IntPtr propertyKey, /* CFAllocator */ IntPtr allocator, out IntPtr propertyValueOut);

		[DllImport (Constants.VideoToolboxLibrary)]
		internal extern static VTStatus VTSessionSetProperties (IntPtr handle, IntPtr propertyDictionary);

		[DllImport (Constants.VideoToolboxLibrary)]
		extern static VTStatus VTSessionCopySerializableProperties (IntPtr handle, /* CFAllocator */ IntPtr allocator, out IntPtr dictionaryOut);

		[DllImport (Constants.VideoToolboxLibrary)]
		extern static VTStatus VTSessionCopySupportedPropertyDictionary (/* VTSessionRef */ IntPtr session, /* CFDictionaryRef* */ out IntPtr supportedPropertyDictionaryOut);

		public VTStatus SetProperties (VTPropertyOptions options)
		{
			if (options == null)
				throw new ArgumentNullException (nameof (options));

			return VTSessionSetProperties (Handle, options.Dictionary.Handle);
		}

		public VTStatus SetProperty (NSString propertyKey, NSObject value)
		{
			if (propertyKey == null)
				throw new ArgumentNullException (nameof (propertyKey));

			return VTSessionSetProperty (Handle, propertyKey.Handle, value != null ? value.Handle : IntPtr.Zero);
		}

		public VTPropertyOptions GetProperties ()
		{
			IntPtr ret;
			var result = VTSessionCopySerializableProperties (Handle, IntPtr.Zero, out ret);
			if (result != VTStatus.Ok || ret == IntPtr.Zero)
				return null;

			var dict = Runtime.GetNSObject<NSDictionary> (ret);
			return new VTPropertyOptions (dict);
		}

		public NSObject GetProperty (NSString propertyKey)
		{
			if (propertyKey == null)
				throw new ArgumentNullException (nameof (propertyKey));

			IntPtr ret;
			if (VTSessionCopyProperty (Handle, propertyKey.Handle, IntPtr.Zero, out ret) != VTStatus.Ok || ret == IntPtr.Zero)
				return null;
			var obj = Runtime.GetNSObject (ret);
			obj.DangerousRelease ();
			return obj;
		}

		public NSDictionary GetSerializableProperties ()
		{
			IntPtr ret;
			var result = VTSessionCopySerializableProperties (Handle, IntPtr.Zero, out ret);
			if (result != VTStatus.Ok || ret == IntPtr.Zero)
				return null;

			var dict = Runtime.GetNSObject<NSDictionary> (ret);
			dict.DangerousRelease ();
			return dict;
		}

		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public NSDictionary GetSupportedProperties ()
		{
			IntPtr ret;
			var result = VTSessionCopySupportedPropertyDictionary (Handle, out ret);
			if (result != VTStatus.Ok || ret == IntPtr.Zero)
				return null;
			
			var dict = Runtime.GetNSObject<NSDictionary> (ret);
			dict.DangerousRelease ();
			return dict;
		}
	}
}
