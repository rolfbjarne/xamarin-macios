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
namespace UserNotifications {
	/// <summary>Enumerates attached file errors that can occur when making a notification request.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UNErrorCode : long {
		/// <summary>The app is not allowed to submit notification requests.</summary>
		NotificationsNotAllowed = 1,
		/// <summary>The URL for the file is not valid.</summary>
		AttachmentInvalidUrl = 100,
		/// <summary>The type of the attached file was not recognized.</summary>
		AttachmentUnrecognizedType = 101,
		/// <summary>The attached file is too big.</summary>
		AttachmentInvalidFileSize = 102,
		/// <summary>The local attached file was not present.</summary>
		AttachmentNotInDataStore = 103,
		/// <summary>The attachment could not be moved onto the system data store.</summary>
		AttachmentMoveIntoDataStoreFailed = 104,
		/// <summary>The attached file is corrupt.</summary>
		AttachmentCorrupt = 105,
		/// <summary>To be added.</summary>
		NotificationInvalidNoDate = 1400,
		/// <summary>To be added.</summary>
		NotificationInvalidNoContent = 1401,
		ContentProvidingObjectNotAllowed = 1500,
		ContentProvidingInvalid = 1501,
		BadgeInputInvalid = 1600,
	}
	/// <summary>Extension methods for the <see cref="global::UserNotifications.UNErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::UserNotifications.UNErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class UNErrorCodeExtensions {
		[Field ("UNErrorDomain", "UserNotifications")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the UserNotifications.UNErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this UNErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.UserNotifications.Handle, "UNErrorDomain");
			return _domain;
		}
	}
}
