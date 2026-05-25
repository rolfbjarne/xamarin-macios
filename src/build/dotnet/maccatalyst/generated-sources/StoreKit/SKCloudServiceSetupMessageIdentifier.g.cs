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
namespace StoreKit {
	/// <summary>Enumerates cloud service setup message identifiers.</summary><remarks>To be added.</remarks>
	[ObsoletedOSPlatform ("ios18.0")]
	[ObsoletedOSPlatform ("maccatalyst18.0")]
	[ObsoletedOSPlatform ("tvos18.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public enum SKCloudServiceSetupMessageIdentifier : int {
		/// <summary>Indicates a message for joining.</summary>
		Join = 0,
		/// <summary>Indicates a message for connecting.</summary>
		Connect = 1,
		/// <summary>Indicates a message for adding music</summary>
		AddMusic = 2,
		/// <summary>Indicates a message for playing.</summary>
		PlayMusic = 3,
	}
	/// <summary>Extension methods for the <see cref="global::StoreKit.SKCloudServiceSetupMessageIdentifier" /> enumeration.</summary>
	[ObsoletedOSPlatform ("ios18.0")]
	[ObsoletedOSPlatform ("maccatalyst18.0")]
	[ObsoletedOSPlatform ("tvos18.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class SKCloudServiceSetupMessageIdentifierExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("SKCloudServiceSetupMessageIdentifierJoin", "StoreKit")]
		internal unsafe static IntPtr SKCloudServiceSetupMessageIdentifierJoin {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.StoreKit.Handle, "SKCloudServiceSetupMessageIdentifierJoin", storage);
			}
		}
		[Field ("SKCloudServiceSetupMessageIdentifierConnect", "StoreKit")]
		internal unsafe static IntPtr SKCloudServiceSetupMessageIdentifierConnect {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.StoreKit.Handle, "SKCloudServiceSetupMessageIdentifierConnect", storage);
			}
		}
		[Field ("SKCloudServiceSetupMessageIdentifierAddMusic", "StoreKit")]
		internal unsafe static IntPtr SKCloudServiceSetupMessageIdentifierAddMusic {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.StoreKit.Handle, "SKCloudServiceSetupMessageIdentifierAddMusic", storage);
			}
		}
		[Field ("SKCloudServiceSetupMessageIdentifierPlayMusic", "StoreKit")]
		internal unsafe static IntPtr SKCloudServiceSetupMessageIdentifierPlayMusic {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.StoreKit.Handle, "SKCloudServiceSetupMessageIdentifierPlayMusic", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this SKCloudServiceSetupMessageIdentifier self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // SKCloudServiceSetupMessageIdentifier.Join
				ptr = SKCloudServiceSetupMessageIdentifierJoin;
				break;
			case 1: // SKCloudServiceSetupMessageIdentifier.Connect
				ptr = SKCloudServiceSetupMessageIdentifierConnect;
				break;
			case 2: // SKCloudServiceSetupMessageIdentifier.AddMusic
				ptr = SKCloudServiceSetupMessageIdentifierAddMusic;
				break;
			case 3: // SKCloudServiceSetupMessageIdentifier.PlayMusic
				ptr = SKCloudServiceSetupMessageIdentifierPlayMusic;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::StoreKit.SKCloudServiceSetupMessageIdentifier" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static SKCloudServiceSetupMessageIdentifier GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (SKCloudServiceSetupMessageIdentifierJoin))
				return SKCloudServiceSetupMessageIdentifier.Join;
			if (constant.IsEqualTo (SKCloudServiceSetupMessageIdentifierConnect))
				return SKCloudServiceSetupMessageIdentifier.Connect;
			if (constant.IsEqualTo (SKCloudServiceSetupMessageIdentifierAddMusic))
				return SKCloudServiceSetupMessageIdentifier.AddMusic;
			if (constant.IsEqualTo (SKCloudServiceSetupMessageIdentifierPlayMusic))
				return SKCloudServiceSetupMessageIdentifier.PlayMusic;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::StoreKit.SKCloudServiceSetupMessageIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static SKCloudServiceSetupMessageIdentifier GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::StoreKit.SKCloudServiceSetupMessageIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static SKCloudServiceSetupMessageIdentifier? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::StoreKit.SKCloudServiceSetupMessageIdentifier" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this SKCloudServiceSetupMessageIdentifier[]? values)
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
		internal static SKCloudServiceSetupMessageIdentifier[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<SKCloudServiceSetupMessageIdentifier> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
