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
namespace GameKit {
	[ObsoletedOSPlatform ("macos10.14")]
	[ObsoletedOSPlatform ("tvos12.0")]
	[ObsoletedOSPlatform ("ios12.0")]
	[ObsoletedOSPlatform ("maccatalyst13.1")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[Native]
	public enum GKGameSessionErrorCode : long {
		/// <summary>To be added.</summary>
		Unknown = 1,
		/// <summary>To be added.</summary>
		NotAuthenticated = 2,
		/// <summary>To be added.</summary>
		SessionConflict = 3,
		/// <summary>To be added.</summary>
		SessionNotShared = 4,
		/// <summary>To be added.</summary>
		ConnectionCancelledByUser = 5,
		/// <summary>To be added.</summary>
		ConnectionFailed = 6,
		/// <summary>To be added.</summary>
		SessionHasMaxConnectedPlayers = 7,
		/// <summary>To be added.</summary>
		SendDataNotConnected = 8,
		/// <summary>To be added.</summary>
		SendDataNoRecipients = 9,
		/// <summary>To be added.</summary>
		SendDataNotReachable = 10,
		/// <summary>To be added.</summary>
		SendRateLimitReached = 11,
		/// <summary>To be added.</summary>
		BadContainer = 12,
		/// <summary>To be added.</summary>
		CloudQuotaExceeded = 13,
		/// <summary>To be added.</summary>
		NetworkFailure = 14,
		/// <summary>To be added.</summary>
		CloudDriveDisabled = 15,
		/// <summary>To be added.</summary>
		InvalidSession = 16,
	}
	/// <summary>Extension methods for the <see cref="global::GameKit.GKGameSessionErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::GameKit.GKGameSessionErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[ObsoletedOSPlatform ("macos10.14")]
	[ObsoletedOSPlatform ("tvos12.0")]
	[ObsoletedOSPlatform ("ios12.0")]
	[ObsoletedOSPlatform ("maccatalyst13.1")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class GKGameSessionErrorCodeExtensions {
		[Field ("GKGameSessionErrorDomain", "GameKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the GameKit.GKGameSessionErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this GKGameSessionErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.GameKit.Handle, "GKGameSessionErrorDomain");
			return _domain;
		}
	}
}
