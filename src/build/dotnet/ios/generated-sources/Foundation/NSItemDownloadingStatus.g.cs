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
namespace Foundation {
	/// <summary>Enumerates download status values.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum NSItemDownloadingStatus : int {
		/// <summary>To be added.</summary>
		Unknown = -1,
		/// <summary>To be added.</summary>
		Current = 0,
		/// <summary>To be added.</summary>
		Downloaded = 1,
		/// <summary>To be added.</summary>
		NotDownloaded = 2,
	}
	/// <summary>Extension methods for the <see cref="global::Foundation.NSItemDownloadingStatus" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSItemDownloadingStatusExtensions {
		static IntPtr[] values = new IntPtr [3];
		[Field ("NSMetadataUbiquitousItemDownloadingStatusCurrent", "Foundation")]
		internal unsafe static IntPtr NSMetadataUbiquitousItemDownloadingStatusCurrent {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSMetadataUbiquitousItemDownloadingStatusCurrent", storage);
			}
		}
		[Field ("NSMetadataUbiquitousItemDownloadingStatusDownloaded", "Foundation")]
		internal unsafe static IntPtr NSMetadataUbiquitousItemDownloadingStatusDownloaded {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSMetadataUbiquitousItemDownloadingStatusDownloaded", storage);
			}
		}
		[Field ("NSMetadataUbiquitousItemDownloadingStatusNotDownloaded", "Foundation")]
		internal unsafe static IntPtr NSMetadataUbiquitousItemDownloadingStatusNotDownloaded {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSMetadataUbiquitousItemDownloadingStatusNotDownloaded", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSItemDownloadingStatus self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSItemDownloadingStatus.Current
				ptr = NSMetadataUbiquitousItemDownloadingStatusCurrent;
				break;
			case 1: // NSItemDownloadingStatus.Downloaded
				ptr = NSMetadataUbiquitousItemDownloadingStatusDownloaded;
				break;
			case 2: // NSItemDownloadingStatus.NotDownloaded
				ptr = NSMetadataUbiquitousItemDownloadingStatusNotDownloaded;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSItemDownloadingStatus" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSItemDownloadingStatus GetValue (NSString? constant)
		{
			if (constant is null)
				return NSItemDownloadingStatus.Unknown;
			if (constant.IsEqualTo (NSMetadataUbiquitousItemDownloadingStatusCurrent))
				return NSItemDownloadingStatus.Current;
			if (constant.IsEqualTo (NSMetadataUbiquitousItemDownloadingStatusDownloaded))
				return NSItemDownloadingStatus.Downloaded;
			if (constant.IsEqualTo (NSMetadataUbiquitousItemDownloadingStatusNotDownloaded))
				return NSItemDownloadingStatus.NotDownloaded;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSItemDownloadingStatus" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSItemDownloadingStatus GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSItemDownloadingStatus" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSItemDownloadingStatus? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Foundation.NSItemDownloadingStatus" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSItemDownloadingStatus[]? values)
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
		internal static NSItemDownloadingStatus[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSItemDownloadingStatus> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
