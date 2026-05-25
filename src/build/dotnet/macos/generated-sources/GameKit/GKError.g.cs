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
	/// <summary>An enumeration whose values specify Game Kit errors.</summary><remarks>To be added.</remarks>
	[Native ("GKErrorCode")]
	public enum GKError : long {
		/// <summary>No error occurred.</summary>
		None = 0,
		/// <summary>An unknown error occurred.</summary>
		Unknown = 1,
		/// <summary>The user cancelled the operation.</summary>
		Cancelled = 2,
		/// <summary>There was an error in communicating with the game server.</summary>
		CommunicationsFailure = 3,
		/// <summary>The user denied an operation.</summary>
		UserDenied = 4,
		/// <summary>The user name or password was invalid.</summary>
		InvalidCredentials = 5,
		/// <summary>The player is not authenticated.</summary>
		NotAuthenticated = 6,
		/// <summary>The player is authenticating.</summary>
		AuthenticationInProgress = 7,
		/// <summary>The in-game representation of a player was invalid.</summary>
		InvalidPlayer = 8,
		/// <summary>The score is not set.</summary>
		ScoreNotSet = 9,
		/// <summary>The requested item or service is blocked.</summary>
		ParentalControlsBlocked = 10,
		/// <summary>The player's status message is longer than allowed.</summary>
		PlayerStatusExceedsMaximumLength = 11,
		/// <summary>The player's status message is not valid.</summary>
		PlayerStatusInvalid = 12,
		/// <summary>The match request is logically impossible.</summary>
		MatchRequestInvalid = 13,
		/// <summary>The player is not old enough to access the item or service.</summary>
		Underage = 14,
		/// <summary>The game center did not recognize the app or game. This can be caused by an invalid bundle identifier.</summary>
		GameUnrecognized = 15,
		/// <summary>The Game Center is not supported by the device.</summary>
		NotSupported = 16,
		/// <summary>A parameter was incorrect or miscategorized.</summary>
		InvalidParameter = 17,
		/// <summary>There was a connection from an unexpected player.</summary>
		UnexpectedConnection = 18,
		/// <summary>The challenge was invalid.</summary>
		ChallengeInvalid = 19,
		/// <summary>The match data was too large.</summary>
		TurnBasedMatchDataTooLarge = 20,
		/// <summary>The maximum number of sessions was reached before the operation was requested.</summary>
		TurnBasedTooManySessions = 21,
		/// <summary>The in-game representation of a player in a turn-based game was invalid.</summary>
		TurnBasedInvalidParticipant = 22,
		/// <summary>An attempt was made to play out of turn.</summary>
		TurnBasedInvalidTurn = 23,
		/// <summary>The session for a turn-based game was in an invalid state.</summary>
		TurnBasedInvalidState = 24,
		/// <summary>The receiver is not currently receiving invitations.</summary>
		InvitationsDisabled = 25,
		/// <summary>The player's photo could not be retrieved.</summary>
		PlayerPhotoFailure = 26,
		/// <summary>The iCloud container was unavailable.</summary>
		UbiquityContainerUnavailable = 27,
		/// <summary>The match is not connected.</summary>
		MatchNotConnected = 28,
		/// <summary>The session request was not valid.</summary>
		GameSessionRequestInvalid = 29,
		RestrictedToAutomatch = 30,
		ApiNotAvailable = 31,
		NotAuthorized = 32,
		ConnectionTimeout = 33,
		ApiObsolete = 34,
		ICloudUnavailable = 35,
		LockdownMode = 36,
		AppUnlisted = 37,
		DebugMode = 38,
		FriendListDescriptionMissing = 100,
		FriendListRestricted = 101,
		FriendListDenied = 102,
		FriendRequestNotAvailable = 103,
	}
	/// <summary>Extension methods for the <see cref="global::GameKit.GKError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::GameKit.GKError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class GKErrorExtensions {
		[Field ("GKErrorDomain", "GameKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the GameKit.GKError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this GKError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.GameKit.Handle, "GKErrorDomain");
			return _domain;
		}
	}
}
