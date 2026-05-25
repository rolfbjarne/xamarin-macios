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
namespace Messages {
	/// <summary>Enumerates errors associated with Messages.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum MSMessageErrorCode : long {
		/// <summary>To be added.</summary>
		Unknown = -1,
		/// <summary>A resource file was not found.</summary>
		FileNotFound = 1,
		/// <summary>A resource file could not be interpreted.</summary>
		FileUnreadable = 2,
		/// <summary>A resource file was for a different type of resource.</summary>
		ImproperFileType = 3,
		/// <summary>An error in the format of the File URL for a resource file.</summary>
		ImproperFileUrl = 4,
		/// <summary>To be added.</summary>
		StickerFileImproperFileAttributes = 5,
		/// <summary>A sticker file was not properly sized.</summary>
		StickerFileImproperFileSize = 6,
		/// <summary>A sticker file had an improper format.</summary>
		StickerFileImproperFileFormat = 7,
		/// <summary>To be added.</summary>
		UrlExceedsMaxSize = 8,
		/// <summary>To be added.</summary>
		SendWithoutRecentInteraction = 9,
		/// <summary>To be added.</summary>
		SendWhileNotVisible = 10,
		/// <summary>Indicates that an attempt was made to use an API that cannot be used in the current presentation context.</summary>
		APIUnavailableInPresentationContext = 11,
	}
	/// <summary>Extension methods for the <see cref="global::Messages.MSMessageErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::Messages.MSMessageErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class MSMessageErrorCodeExtensions {
		[Field ("MSMessagesErrorDomain", "Messages")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the Messages.MSMessageErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this MSMessageErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.Messages.Handle, "MSMessagesErrorDomain");
			return _domain;
		}
	}
}
