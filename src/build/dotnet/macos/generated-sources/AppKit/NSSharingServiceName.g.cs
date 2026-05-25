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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
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
namespace AppKit {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum NSSharingServiceName : int {
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		PostOnFacebook = 0,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		PostOnTwitter = 1,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		PostOnSinaWeibo = 2,
		/// <summary>To be added.</summary>
		ComposeEmail = 3,
		/// <summary>To be added.</summary>
		ComposeMessage = 4,
		/// <summary>To be added.</summary>
		SendViaAirDrop = 5,
		/// <summary>To be added.</summary>
		AddToSafariReadingList = 6,
		/// <summary>To be added.</summary>
		AddToIPhoto = 7,
		/// <summary>To be added.</summary>
		AddToAperture = 8,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		UseAsTwitterProfileImage = 9,
		/// <summary>To be added.</summary>
		UseAsDesktopPicture = 10,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		PostImageOnFlickr = 11,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		PostVideoOnVimeo = 12,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		PostVideoOnYouku = 13,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		PostVideoOnTudou = 14,
		/// <summary>To be added.</summary>
		CloudSharing = 15,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		PostOnTencentWeibo = 16,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		PostOnLinkedIn = 17,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		UseAsFacebookProfileImage = 18,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		UseAsLinkedInProfileImage = 19,
	}
	/// <summary>Extension methods for the <see cref="global::AppKit.NSSharingServiceName" /> enumeration.</summary>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSSharingServiceNameExtensions {
		static IntPtr[] values = new IntPtr [20];
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("NSSharingServiceNamePostOnFacebook", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNamePostOnFacebook {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNamePostOnFacebook", storage);
			}
		}
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("NSSharingServiceNamePostOnTwitter", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNamePostOnTwitter {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNamePostOnTwitter", storage);
			}
		}
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("NSSharingServiceNamePostOnSinaWeibo", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNamePostOnSinaWeibo {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNamePostOnSinaWeibo", storage);
			}
		}
		[Field ("NSSharingServiceNameComposeEmail", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNameComposeEmail {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNameComposeEmail", storage);
			}
		}
		[Field ("NSSharingServiceNameComposeMessage", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNameComposeMessage {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNameComposeMessage", storage);
			}
		}
		[Field ("NSSharingServiceNameSendViaAirDrop", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNameSendViaAirDrop {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNameSendViaAirDrop", storage);
			}
		}
		[Field ("NSSharingServiceNameAddToSafariReadingList", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNameAddToSafariReadingList {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNameAddToSafariReadingList", storage);
			}
		}
		[Field ("NSSharingServiceNameAddToIPhoto", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNameAddToIPhoto {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNameAddToIPhoto", storage);
			}
		}
		[Field ("NSSharingServiceNameAddToAperture", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNameAddToAperture {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNameAddToAperture", storage);
			}
		}
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("NSSharingServiceNameUseAsTwitterProfileImage", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNameUseAsTwitterProfileImage {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNameUseAsTwitterProfileImage", storage);
			}
		}
		[Field ("NSSharingServiceNameUseAsDesktopPicture", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNameUseAsDesktopPicture {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNameUseAsDesktopPicture", storage);
			}
		}
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("NSSharingServiceNamePostImageOnFlickr", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNamePostImageOnFlickr {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNamePostImageOnFlickr", storage);
			}
		}
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("NSSharingServiceNamePostVideoOnVimeo", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNamePostVideoOnVimeo {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNamePostVideoOnVimeo", storage);
			}
		}
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("NSSharingServiceNamePostVideoOnYouku", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNamePostVideoOnYouku {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNamePostVideoOnYouku", storage);
			}
		}
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("NSSharingServiceNamePostVideoOnTudou", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNamePostVideoOnTudou {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNamePostVideoOnTudou", storage);
			}
		}
		[Field ("NSSharingServiceNameCloudSharing", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNameCloudSharing {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNameCloudSharing", storage);
			}
		}
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("NSSharingServiceNamePostOnTencentWeibo", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNamePostOnTencentWeibo {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNamePostOnTencentWeibo", storage);
			}
		}
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("NSSharingServiceNamePostOnLinkedIn", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNamePostOnLinkedIn {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNamePostOnLinkedIn", storage);
			}
		}
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("NSSharingServiceNameUseAsFacebookProfileImage", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNameUseAsFacebookProfileImage {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNameUseAsFacebookProfileImage", storage);
			}
		}
		[ObsoletedOSPlatform ("macos10.14", "Use the proprietary SDK instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("NSSharingServiceNameUseAsLinkedInProfileImage", "AppKit")]
		internal unsafe static IntPtr NSSharingServiceNameUseAsLinkedInProfileImage {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSSharingServiceNameUseAsLinkedInProfileImage", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSSharingServiceName self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSSharingServiceName.PostOnFacebook
				ptr = NSSharingServiceNamePostOnFacebook;
				break;
			case 1: // NSSharingServiceName.PostOnTwitter
				ptr = NSSharingServiceNamePostOnTwitter;
				break;
			case 2: // NSSharingServiceName.PostOnSinaWeibo
				ptr = NSSharingServiceNamePostOnSinaWeibo;
				break;
			case 3: // NSSharingServiceName.ComposeEmail
				ptr = NSSharingServiceNameComposeEmail;
				break;
			case 4: // NSSharingServiceName.ComposeMessage
				ptr = NSSharingServiceNameComposeMessage;
				break;
			case 5: // NSSharingServiceName.SendViaAirDrop
				ptr = NSSharingServiceNameSendViaAirDrop;
				break;
			case 6: // NSSharingServiceName.AddToSafariReadingList
				ptr = NSSharingServiceNameAddToSafariReadingList;
				break;
			case 7: // NSSharingServiceName.AddToIPhoto
				ptr = NSSharingServiceNameAddToIPhoto;
				break;
			case 8: // NSSharingServiceName.AddToAperture
				ptr = NSSharingServiceNameAddToAperture;
				break;
			case 9: // NSSharingServiceName.UseAsTwitterProfileImage
				ptr = NSSharingServiceNameUseAsTwitterProfileImage;
				break;
			case 10: // NSSharingServiceName.UseAsDesktopPicture
				ptr = NSSharingServiceNameUseAsDesktopPicture;
				break;
			case 11: // NSSharingServiceName.PostImageOnFlickr
				ptr = NSSharingServiceNamePostImageOnFlickr;
				break;
			case 12: // NSSharingServiceName.PostVideoOnVimeo
				ptr = NSSharingServiceNamePostVideoOnVimeo;
				break;
			case 13: // NSSharingServiceName.PostVideoOnYouku
				ptr = NSSharingServiceNamePostVideoOnYouku;
				break;
			case 14: // NSSharingServiceName.PostVideoOnTudou
				ptr = NSSharingServiceNamePostVideoOnTudou;
				break;
			case 15: // NSSharingServiceName.CloudSharing
				ptr = NSSharingServiceNameCloudSharing;
				break;
			case 16: // NSSharingServiceName.PostOnTencentWeibo
				ptr = NSSharingServiceNamePostOnTencentWeibo;
				break;
			case 17: // NSSharingServiceName.PostOnLinkedIn
				ptr = NSSharingServiceNamePostOnLinkedIn;
				break;
			case 18: // NSSharingServiceName.UseAsFacebookProfileImage
				ptr = NSSharingServiceNameUseAsFacebookProfileImage;
				break;
			case 19: // NSSharingServiceName.UseAsLinkedInProfileImage
				ptr = NSSharingServiceNameUseAsLinkedInProfileImage;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSSharingServiceName" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSSharingServiceName GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (NSSharingServiceNamePostOnFacebook))
				return NSSharingServiceName.PostOnFacebook;
			if (constant.IsEqualTo (NSSharingServiceNamePostOnTwitter))
				return NSSharingServiceName.PostOnTwitter;
			if (constant.IsEqualTo (NSSharingServiceNamePostOnSinaWeibo))
				return NSSharingServiceName.PostOnSinaWeibo;
			if (constant.IsEqualTo (NSSharingServiceNameComposeEmail))
				return NSSharingServiceName.ComposeEmail;
			if (constant.IsEqualTo (NSSharingServiceNameComposeMessage))
				return NSSharingServiceName.ComposeMessage;
			if (constant.IsEqualTo (NSSharingServiceNameSendViaAirDrop))
				return NSSharingServiceName.SendViaAirDrop;
			if (constant.IsEqualTo (NSSharingServiceNameAddToSafariReadingList))
				return NSSharingServiceName.AddToSafariReadingList;
			if (constant.IsEqualTo (NSSharingServiceNameAddToIPhoto))
				return NSSharingServiceName.AddToIPhoto;
			if (constant.IsEqualTo (NSSharingServiceNameAddToAperture))
				return NSSharingServiceName.AddToAperture;
			if (constant.IsEqualTo (NSSharingServiceNameUseAsTwitterProfileImage))
				return NSSharingServiceName.UseAsTwitterProfileImage;
			if (constant.IsEqualTo (NSSharingServiceNameUseAsDesktopPicture))
				return NSSharingServiceName.UseAsDesktopPicture;
			if (constant.IsEqualTo (NSSharingServiceNamePostImageOnFlickr))
				return NSSharingServiceName.PostImageOnFlickr;
			if (constant.IsEqualTo (NSSharingServiceNamePostVideoOnVimeo))
				return NSSharingServiceName.PostVideoOnVimeo;
			if (constant.IsEqualTo (NSSharingServiceNamePostVideoOnYouku))
				return NSSharingServiceName.PostVideoOnYouku;
			if (constant.IsEqualTo (NSSharingServiceNamePostVideoOnTudou))
				return NSSharingServiceName.PostVideoOnTudou;
			if (constant.IsEqualTo (NSSharingServiceNameCloudSharing))
				return NSSharingServiceName.CloudSharing;
			if (constant.IsEqualTo (NSSharingServiceNamePostOnTencentWeibo))
				return NSSharingServiceName.PostOnTencentWeibo;
			if (constant.IsEqualTo (NSSharingServiceNamePostOnLinkedIn))
				return NSSharingServiceName.PostOnLinkedIn;
			if (constant.IsEqualTo (NSSharingServiceNameUseAsFacebookProfileImage))
				return NSSharingServiceName.UseAsFacebookProfileImage;
			if (constant.IsEqualTo (NSSharingServiceNameUseAsLinkedInProfileImage))
				return NSSharingServiceName.UseAsLinkedInProfileImage;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSSharingServiceName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSSharingServiceName GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSSharingServiceName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSSharingServiceName? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AppKit.NSSharingServiceName" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSSharingServiceName[]? values)
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
		internal static NSSharingServiceName[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSSharingServiceName> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
