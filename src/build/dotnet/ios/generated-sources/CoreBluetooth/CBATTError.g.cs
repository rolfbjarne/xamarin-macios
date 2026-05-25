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
namespace CoreBluetooth {
	/// <summary>Errors returned by a GATT server.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum CBATTError : long {
		/// <summary>To be added.</summary>
		Success = 0,
		/// <summary>To be added.</summary>
		InvalidHandle = 1,
		/// <summary>To be added.</summary>
		ReadNotPermitted = 2,
		/// <summary>To be added.</summary>
		WriteNotPermitted = 3,
		/// <summary>To be added.</summary>
		InvalidPdu = 4,
		/// <summary>To be added.</summary>
		InsufficientAuthentication = 5,
		/// <summary>To be added.</summary>
		RequestNotSupported = 6,
		/// <summary>To be added.</summary>
		InvalidOffset = 7,
		/// <summary>To be added.</summary>
		InsufficientAuthorization = 8,
		/// <summary>To be added.</summary>
		PrepareQueueFull = 9,
		/// <summary>To be added.</summary>
		AttributeNotFound = 10,
		/// <summary>To be added.</summary>
		AttributeNotLong = 11,
		/// <summary>To be added.</summary>
		InsufficientEncryptionKeySize = 12,
		/// <summary>To be added.</summary>
		InvalidAttributeValueLength = 13,
		/// <summary>To be added.</summary>
		UnlikelyError = 14,
		/// <summary>To be added.</summary>
		InsufficientEncryption = 15,
		/// <summary>To be added.</summary>
		UnsupportedGroupType = 16,
		/// <summary>To be added.</summary>
		InsufficientResources = 17,
	}
	/// <summary>Extension methods for the <see cref="global::CoreBluetooth.CBATTError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::CoreBluetooth.CBATTError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CBATTErrorExtensions {
		[Field ("CBATTErrorDomain", "CoreBluetooth")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the CoreBluetooth.CBATTError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this CBATTError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBATTErrorDomain");
			return _domain;
		}
	}
}
