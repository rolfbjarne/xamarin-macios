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
namespace CoreData {
	/// <summary>Enumerates errors that can be encountered during validation.</summary>
	[Native]
	public enum ValidationErrorType : ulong {
		/// <summary>Indicates an error with a managed object.</summary>
		ManagedObjectValidation = 1550,
		/// <summary>Indicates that multiple errors occurred.</summary>
		MultipleErrors = 1560,
		/// <summary>Indicates that a mandatory property was missing.</summary>
		MissingMandatoryProperty = 1570,
		/// <summary>Indicates that a to-many relationship was bound to too few objects.</summary>
		RelationshipLacksMinimumCount = 1580,
		/// <summary>Indicates that a to-many relationship was bound to too many objects.</summary>
		RelationshipExceedsMaximumCount = 1590,
		/// <summary>Indicates that an attempt was made to delete a relationship that has a delete rule that denies deletion.</summary>
		RelationshipDeniedDelete = 1600,
		/// <summary>Indicates that a number was too large.</summary>
		NumberTooLarge = 1610,
		/// <summary>Indicates that a number was too small.</summary>
		NumberTooSmall = 1620,
		/// <summary>Indicates that a date was too late.</summary>
		DateTooLate = 1630,
		/// <summary>Indicates that a date was too soon.</summary>
		DateTooSoon = 1640,
		/// <summary>Indicates that a date was invalid.</summary>
		InvalidDate = 1650,
		/// <summary>Indicates that a string was too long.</summary>
		StringTooLong = 1660,
		/// <summary>Indicates that a string was too short.</summary>
		StringTooShort = 1670,
		/// <summary>Indicates that a pattern failed to match a string.</summary>
		StringPatternMatching = 1680,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		InvalidUri = 1690,
	}
}
