// <auto-generated />

#nullable enable

using Foundation;
using ObjCBindings;
using ObjCRuntime;
using System;

namespace AVFoundation;

[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static partial class AVCaptureDeviceTypeExtensions
{

	static IntPtr[] values = new IntPtr [11];

	[Field ("AVCaptureDeviceTypeBuiltInMicrophone", "AVFoundation")]
	internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInMicrophone
	{
		get
		{
			fixed (IntPtr *storage = &values [0])
				return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInMicrophone", storage);
		}
	}

	[Field ("AVCaptureDeviceTypeBuiltInWideAngleCamera", "AVFoundation")]
	internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInWideAngleCamera
	{
		get
		{
			fixed (IntPtr *storage = &values [1])
				return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInWideAngleCamera", storage);
		}
	}

	[Field ("AVCaptureDeviceTypeBuiltInTelephotoCamera", "AVFoundation")]
	internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInTelephotoCamera
	{
		get
		{
			fixed (IntPtr *storage = &values [2])
				return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInTelephotoCamera", storage);
		}
	}

	[Field ("AVCaptureDeviceTypeBuiltInDuoCamera", "AVFoundation")]
	internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInDuoCamera
	{
		get
		{
			fixed (IntPtr *storage = &values [3])
				return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInDuoCamera", storage);
		}
	}

	[Field ("AVCaptureDeviceTypeBuiltInDualCamera", "AVFoundation")]
	internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInDualCamera
	{
		get
		{
			fixed (IntPtr *storage = &values [4])
				return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInDualCamera", storage);
		}
	}

	[Field ("AVCaptureDeviceTypeBuiltInTrueDepthCamera", "AVFoundation")]
	internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInTrueDepthCamera
	{
		get
		{
			fixed (IntPtr *storage = &values [5])
				return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInTrueDepthCamera", storage);
		}
	}

	[Field ("AVCaptureDeviceTypeBuiltInUltraWideCamera", "AVFoundation")]
	internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInUltraWideCamera
	{
		get
		{
			fixed (IntPtr *storage = &values [6])
				return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInUltraWideCamera", storage);
		}
	}

	[Field ("AVCaptureDeviceTypeBuiltInTripleCamera", "AVFoundation")]
	internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInTripleCamera
	{
		get
		{
			fixed (IntPtr *storage = &values [7])
				return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInTripleCamera", storage);
		}
	}

	[Field ("AVCaptureDeviceTypeBuiltInDualWideCamera", "AVFoundation")]
	internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInDualWideCamera
	{
		get
		{
			fixed (IntPtr *storage = &values [8])
				return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInDualWideCamera", storage);
		}
	}

	[Field ("AVCaptureDeviceTypeExternalUnknown", "AVFoundation")]
	internal unsafe static IntPtr AVCaptureDeviceTypeExternalUnknown
	{
		get
		{
			fixed (IntPtr *storage = &values [9])
				return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeExternalUnknown", storage);
		}
	}

	[Field ("AVCaptureDeviceTypeBuiltInLiDARDepthCamera", "AVFoundation")]
	internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInLiDARDepthCamera
	{
		get
		{
			fixed (IntPtr *storage = &values [10])
				return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInLiDARDepthCamera", storage);
		}
	}

	public static NSString? GetConstant (this AVCaptureDeviceType self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int) self)
		{
			case 0: // AVCaptureDeviceTypeBuiltInMicrophone
				ptr = AVCaptureDeviceTypeBuiltInMicrophone;
				break;
			case 1: // AVCaptureDeviceTypeBuiltInWideAngleCamera
				ptr = AVCaptureDeviceTypeBuiltInWideAngleCamera;
				break;
			case 2: // AVCaptureDeviceTypeBuiltInTelephotoCamera
				ptr = AVCaptureDeviceTypeBuiltInTelephotoCamera;
				break;
			case 3: // AVCaptureDeviceTypeBuiltInDuoCamera
				ptr = AVCaptureDeviceTypeBuiltInDuoCamera;
				break;
			case 4: // AVCaptureDeviceTypeBuiltInDualCamera
				ptr = AVCaptureDeviceTypeBuiltInDualCamera;
				break;
			case 5: // AVCaptureDeviceTypeBuiltInTrueDepthCamera
				ptr = AVCaptureDeviceTypeBuiltInTrueDepthCamera;
				break;
			case 6: // AVCaptureDeviceTypeBuiltInUltraWideCamera
				ptr = AVCaptureDeviceTypeBuiltInUltraWideCamera;
				break;
			case 7: // AVCaptureDeviceTypeBuiltInTripleCamera
				ptr = AVCaptureDeviceTypeBuiltInTripleCamera;
				break;
			case 8: // AVCaptureDeviceTypeBuiltInDualWideCamera
				ptr = AVCaptureDeviceTypeBuiltInDualWideCamera;
				break;
			case 9: // AVCaptureDeviceTypeExternalUnknown
				ptr = AVCaptureDeviceTypeExternalUnknown;
				break;
			case 10: // AVCaptureDeviceTypeBuiltInLiDARDepthCamera
				ptr = AVCaptureDeviceTypeBuiltInLiDARDepthCamera;
				break;
		}
		return (NSString?) Runtime.GetNSObject (ptr);
	}

	public static AVCaptureDeviceType GetValue (NSString constant)
	{
		if (constant is null)
			throw new ArgumentNullException (nameof (constant));
		if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInMicrophone))
			return AVCaptureDeviceType.BuiltInMicrophone;
		if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInWideAngleCamera))
			return AVCaptureDeviceType.BuiltInWideAngleCamera;
		if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInTelephotoCamera))
			return AVCaptureDeviceType.BuiltInTelephotoCamera;
		if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInDuoCamera))
			return AVCaptureDeviceType.BuiltInDuoCamera;
		if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInDualCamera))
			return AVCaptureDeviceType.BuiltInDualCamera;
		if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInTrueDepthCamera))
			return AVCaptureDeviceType.BuiltInTrueDepthCamera;
		if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInUltraWideCamera))
			return AVCaptureDeviceType.BuiltInUltraWideCamera;
		if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInTripleCamera))
			return AVCaptureDeviceType.BuiltInTripleCamera;
		if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInDualWideCamera))
			return AVCaptureDeviceType.BuiltInDualWideCamera;
		if (constant.IsEqualTo (AVCaptureDeviceTypeExternalUnknown))
			return AVCaptureDeviceType.ExternalUnknown;
		if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInLiDARDepthCamera))
			return AVCaptureDeviceType.BuiltInLiDarDepthCamera;
		throw new NotSupportedException ($"The constant {constant} has no associated enum value on this platform.");
	}

	internal static NSString?[]? ToConstantArray (this AVCaptureDeviceType[]? values)
	{
		if (values is null)
			return null;
		var rv = new global::System.Collections.Generic.List<NSString?> ();
		for (var i = 0; i < values.Length; i++) {
			var value = values [i];
			rv.Add (value.GetConstant ());
		}
		return rv.ToArray ();
	}

	internal static AVCaptureDeviceType[]? ToEnumArray (this NSString[]? values)
	{
		if (values is null)
			return null;
		var rv = new global::System.Collections.Generic.List<AVCaptureDeviceType> ();
		for (var i = 0; i < values.Length; i++) {
			var value = values [i];
			rv.Add (GetValue (value));
		}
		return rv.ToArray ();
	}
}