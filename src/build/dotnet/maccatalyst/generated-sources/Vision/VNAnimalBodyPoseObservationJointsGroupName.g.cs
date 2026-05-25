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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Vision {
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public enum VNAnimalBodyPoseObservationJointsGroupName : int {
		None = 0,
		Head = 1,
		Trunk = 2,
		Forelegs = 3,
		Hindlegs = 4,
		Tail = 5,
		All = 6,
	}
	/// <summary>Extension methods for the <see cref="global::Vision.VNAnimalBodyPoseObservationJointsGroupName" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class VNAnimalBodyPoseObservationJointsGroupNameExtensions {
		static IntPtr[] values = new IntPtr [6];
		[Field ("VNAnimalBodyPoseObservationJointsGroupNameHead", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointsGroupNameHead {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointsGroupNameHead", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointsGroupNameTrunk", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointsGroupNameTrunk {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointsGroupNameTrunk", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointsGroupNameForelegs", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointsGroupNameForelegs {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointsGroupNameForelegs", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointsGroupNameHindlegs", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointsGroupNameHindlegs {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointsGroupNameHindlegs", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointsGroupNameTail", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointsGroupNameTail {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointsGroupNameTail", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointsGroupNameAll", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointsGroupNameAll {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointsGroupNameAll", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this VNAnimalBodyPoseObservationJointsGroupName self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // VNAnimalBodyPoseObservationJointsGroupName.Head
				ptr = VNAnimalBodyPoseObservationJointsGroupNameHead;
				break;
			case 2: // VNAnimalBodyPoseObservationJointsGroupName.Trunk
				ptr = VNAnimalBodyPoseObservationJointsGroupNameTrunk;
				break;
			case 3: // VNAnimalBodyPoseObservationJointsGroupName.Forelegs
				ptr = VNAnimalBodyPoseObservationJointsGroupNameForelegs;
				break;
			case 4: // VNAnimalBodyPoseObservationJointsGroupName.Hindlegs
				ptr = VNAnimalBodyPoseObservationJointsGroupNameHindlegs;
				break;
			case 5: // VNAnimalBodyPoseObservationJointsGroupName.Tail
				ptr = VNAnimalBodyPoseObservationJointsGroupNameTail;
				break;
			case 6: // VNAnimalBodyPoseObservationJointsGroupName.All
				ptr = VNAnimalBodyPoseObservationJointsGroupNameAll;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNAnimalBodyPoseObservationJointsGroupName" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static VNAnimalBodyPoseObservationJointsGroupName GetValue (NSString? constant)
		{
			if (constant is null)
				return VNAnimalBodyPoseObservationJointsGroupName.None;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointsGroupNameHead))
				return VNAnimalBodyPoseObservationJointsGroupName.Head;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointsGroupNameTrunk))
				return VNAnimalBodyPoseObservationJointsGroupName.Trunk;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointsGroupNameForelegs))
				return VNAnimalBodyPoseObservationJointsGroupName.Forelegs;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointsGroupNameHindlegs))
				return VNAnimalBodyPoseObservationJointsGroupName.Hindlegs;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointsGroupNameTail))
				return VNAnimalBodyPoseObservationJointsGroupName.Tail;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointsGroupNameAll))
				return VNAnimalBodyPoseObservationJointsGroupName.All;
			return VNAnimalBodyPoseObservationJointsGroupName.None;
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNAnimalBodyPoseObservationJointsGroupName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VNAnimalBodyPoseObservationJointsGroupName GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNAnimalBodyPoseObservationJointsGroupName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VNAnimalBodyPoseObservationJointsGroupName? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Vision.VNAnimalBodyPoseObservationJointsGroupName" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this VNAnimalBodyPoseObservationJointsGroupName[]? values)
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
		internal static VNAnimalBodyPoseObservationJointsGroupName[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<VNAnimalBodyPoseObservationJointsGroupName> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
