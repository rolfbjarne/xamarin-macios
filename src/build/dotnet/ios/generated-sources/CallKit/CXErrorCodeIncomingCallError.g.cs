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
namespace CallKit {
	/// <summary>Enumerates incoming call errors.</summary>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum CXErrorCodeIncomingCallError : long {
		/// <summary>An unknown error occurred.</summary>
		Unknown = 0,
		/// <summary>To be added.</summary>
		Unentitled = 1,
		/// <summary>The UUID for the call already exists.</summary>
		CallUuidAlreadyExists = 2,
		/// <summary>The device is in Do Not Disturb mode.</summary>
		FilteredByDoNotDisturb = 3,
		/// <summary>The caller is blocked.</summary>
		FilteredByBlockList = 4,
		FilteredDuringRestrictedSharingMode = 5,
		CallIsProtected = 6,
		FilteredBySensitiveParticipants = 7,
	}
	/// <summary>Extension methods for the <see cref="global::CallKit.CXErrorCodeIncomingCallError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::CallKit.CXErrorCodeIncomingCallError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CXErrorCodeIncomingCallErrorExtensions {
		[Field ("CXErrorDomainIncomingCall", "CallKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the CallKit.CXErrorCodeIncomingCallError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this CXErrorCodeIncomingCallError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.CallKit.Handle, "CXErrorDomainIncomingCall");
			return _domain;
		}
	}
}
