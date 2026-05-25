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
namespace GameKit {
	/// <summary>Errors returned by the GKVoiceChatService.</summary><remarks>To be added.</remarks>
	[UnsupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("ios7.0")]
	[ObsoletedOSPlatform ("tvos9.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public enum GKVoiceChatServiceError : int {
		/// <summary>An internal error occurred.</summary>
		Internal = 32000,
		/// <summary>Remote packets stopped.</summary>
		NoRemotePackets = 32001,
		/// <summary>The client was unable to connect to the service.</summary>
		UnableToConnect = 32002,
		/// <summary>The remote participant ended the voice chat.</summary>
		RemoteParticipantHangup = 32003,
		/// <summary>The call ID was not valid.</summary>
		InvalidCallID = 32004,
		/// <summary>The service cannot access audio hardware.</summary>
		AudioUnavailable = 32005,
		/// <summary>The client was not initialized.</summary>
		UninitializedClient = 32006,
		/// <summary>The client is missing a required method.</summary>
		ClientMissingRequiredMethods = 32007,
		/// <summary>The remote participant was already in a voice chat.</summary>
		RemoteParticipantBusy = 32008,
		/// <summary>The remote participant cancelled the call before it started.</summary>
		RemoteParticipantCancelled = 32009,
		/// <summary>An invalid response was received from the remote participant.</summary>
		RemoteParticipantResponseInvalid = 32010,
		/// <summary>The remote participant did not accept the invitation.</summary>
		RemoteParticipantDeclinedInvite = 32011,
		/// <summary>The specified method was not valid when it was called.</summary>
		MethodCurrentlyInvalid = 32012,
		/// <summary>The network could not be accessed.</summary>
		NetworkConfiguration = 32013,
		/// <summary>The remote client version was not supported.</summary>
		UnsupportedRemoteVersion = 32014,
		/// <summary>The client is out of memory.</summary>
		OutOfMemory = 32015,
		/// <summary>A parameter was not valid.</summary>
		InvalidParameter = 32016,
	}
	/// <summary>Extension methods for the <see cref="global::GameKit.GKVoiceChatServiceError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::GameKit.GKVoiceChatServiceError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("ios7.0")]
	[ObsoletedOSPlatform ("tvos9.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class GKVoiceChatServiceErrorExtensions {
		[Field ("GKVoiceChatServiceErrorDomain", "GameKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the GameKit.GKVoiceChatServiceError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this GKVoiceChatServiceError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.GameKit.Handle, "GKVoiceChatServiceErrorDomain");
			return _domain;
		}
	}
}
