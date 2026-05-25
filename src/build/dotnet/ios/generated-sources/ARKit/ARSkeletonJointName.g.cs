//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace ARKit {
	[SupportedOSPlatform ("ios13.0")]
	public enum ARSkeletonJointName : int {
		Root = 0,
		Head = 1,
		LeftHand = 2,
		RightHand = 3,
		LeftFoot = 4,
		RightFoot = 5,
		LeftShoulder = 6,
		RightShoulder = 7,
	}
	/// <summary>Extension methods for the <see cref="global::ARKit.ARSkeletonJointName" /> enumeration.</summary>
	[SupportedOSPlatform ("ios13.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class ARSkeletonJointNameExtensions {
		static IntPtr[] values = new IntPtr [8];
		[Field ("ARSkeletonJointNameRoot", "ARKit")]
		internal unsafe static IntPtr ARSkeletonJointNameRoot {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.ARKit.Handle, "ARSkeletonJointNameRoot", storage);
			}
		}
		[Field ("ARSkeletonJointNameHead", "ARKit")]
		internal unsafe static IntPtr ARSkeletonJointNameHead {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.ARKit.Handle, "ARSkeletonJointNameHead", storage);
			}
		}
		[Field ("ARSkeletonJointNameLeftHand", "ARKit")]
		internal unsafe static IntPtr ARSkeletonJointNameLeftHand {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.ARKit.Handle, "ARSkeletonJointNameLeftHand", storage);
			}
		}
		[Field ("ARSkeletonJointNameRightHand", "ARKit")]
		internal unsafe static IntPtr ARSkeletonJointNameRightHand {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.ARKit.Handle, "ARSkeletonJointNameRightHand", storage);
			}
		}
		[Field ("ARSkeletonJointNameLeftFoot", "ARKit")]
		internal unsafe static IntPtr ARSkeletonJointNameLeftFoot {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.ARKit.Handle, "ARSkeletonJointNameLeftFoot", storage);
			}
		}
		[Field ("ARSkeletonJointNameRightFoot", "ARKit")]
		internal unsafe static IntPtr ARSkeletonJointNameRightFoot {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.ARKit.Handle, "ARSkeletonJointNameRightFoot", storage);
			}
		}
		[Field ("ARSkeletonJointNameLeftShoulder", "ARKit")]
		internal unsafe static IntPtr ARSkeletonJointNameLeftShoulder {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.ARKit.Handle, "ARSkeletonJointNameLeftShoulder", storage);
			}
		}
		[Field ("ARSkeletonJointNameRightShoulder", "ARKit")]
		internal unsafe static IntPtr ARSkeletonJointNameRightShoulder {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.ARKit.Handle, "ARSkeletonJointNameRightShoulder", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this ARSkeletonJointName self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // ARSkeletonJointName.Root
				ptr = ARSkeletonJointNameRoot;
				break;
			case 1: // ARSkeletonJointName.Head
				ptr = ARSkeletonJointNameHead;
				break;
			case 2: // ARSkeletonJointName.LeftHand
				ptr = ARSkeletonJointNameLeftHand;
				break;
			case 3: // ARSkeletonJointName.RightHand
				ptr = ARSkeletonJointNameRightHand;
				break;
			case 4: // ARSkeletonJointName.LeftFoot
				ptr = ARSkeletonJointNameLeftFoot;
				break;
			case 5: // ARSkeletonJointName.RightFoot
				ptr = ARSkeletonJointNameRightFoot;
				break;
			case 6: // ARSkeletonJointName.LeftShoulder
				ptr = ARSkeletonJointNameLeftShoulder;
				break;
			case 7: // ARSkeletonJointName.RightShoulder
				ptr = ARSkeletonJointNameRightShoulder;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::ARKit.ARSkeletonJointName" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static ARSkeletonJointName GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (ARSkeletonJointNameRoot))
				return ARSkeletonJointName.Root;
			if (constant.IsEqualTo (ARSkeletonJointNameHead))
				return ARSkeletonJointName.Head;
			if (constant.IsEqualTo (ARSkeletonJointNameLeftHand))
				return ARSkeletonJointName.LeftHand;
			if (constant.IsEqualTo (ARSkeletonJointNameRightHand))
				return ARSkeletonJointName.RightHand;
			if (constant.IsEqualTo (ARSkeletonJointNameLeftFoot))
				return ARSkeletonJointName.LeftFoot;
			if (constant.IsEqualTo (ARSkeletonJointNameRightFoot))
				return ARSkeletonJointName.RightFoot;
			if (constant.IsEqualTo (ARSkeletonJointNameLeftShoulder))
				return ARSkeletonJointName.LeftShoulder;
			if (constant.IsEqualTo (ARSkeletonJointNameRightShoulder))
				return ARSkeletonJointName.RightShoulder;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::ARKit.ARSkeletonJointName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static ARSkeletonJointName GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::ARKit.ARSkeletonJointName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static ARSkeletonJointName? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::ARKit.ARSkeletonJointName" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this ARSkeletonJointName[]? values)
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
		/// <summary>Converts an array of <see cref="NSString" /> values into an array of their corresponding enum values.</summary>
		/// <param name="values">The array if <see cref="NSString" /> values to convert.</param>
		internal static ARSkeletonJointName[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<ARSkeletonJointName> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
