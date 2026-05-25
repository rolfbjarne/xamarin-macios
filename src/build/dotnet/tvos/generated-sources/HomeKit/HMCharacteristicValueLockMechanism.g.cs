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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace HomeKit {
	/// <summary>Enumerates values that describe the last known action that was taken on a lock.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native ("HMCharacteristicValueLockMechanismLastKnownAction")]
	public enum HMCharacteristicValueLockMechanism : long {
		/// <summary>According to the most recent recorded activity, the lock was locked by physical manipulation from the inside.</summary>
		LastKnownActionSecuredUsingPhysicalMovementInterior = 0,
		/// <summary>According to the most recent recorded activity, the lock was unlocked by physical manipulation from the inside.</summary>
		LastKnownActionUnsecuredUsingPhysicalMovementInterior = 1,
		/// <summary>According to the most recent recorded activity, the lock was locked by physical manipulation from the outside.</summary>
		LastKnownActionSecuredUsingPhysicalMovementExterior = 2,
		/// <summary>According to the most recent recorded activity, the lock was unlocked by physical manipulation from the outside.</summary>
		LastKnownActionUnsecuredUsingPhysicalMovementExterior = 3,
		/// <summary>According to the most recent recorded activity, the lock was locked with a keypad.</summary>
		LastKnownActionSecuredWithKeypad = 4,
		/// <summary>According to the most recent recorded activity, the lock was unlocked with a keypad.</summary>
		LastKnownActionUnsecuredWithKeypad = 5,
		/// <summary>According to the most recent recorded activity, the lock was locked remotely.</summary>
		LastKnownActionSecuredRemotely = 6,
		/// <summary>According to the most recent recorded activity, the lock was unlocked remotely.</summary>
		LastKnownActionUnsecuredRemotely = 7,
		/// <summary>According to the most recent recorded activity, the lock was locked when a timeout expired.</summary>
		LastKnownActionSecuredWithAutomaticSecureTimeout = 8,
		/// <summary>The lock was physically locked.</summary>
		LastKnownActionSecuredUsingPhysicalMovement = 9,
		/// <summary>The lock was physically unlocked.</summary>
		LastKnownActionUnsecuredUsingPhysicalMovement = 10,
	}
}
