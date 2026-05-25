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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	/// <summary>An enumeration that specifies the relation between two attributes in a <see cref="T:UIKit.NSLayoutConstraint" /></summary><remarks>
	/// Constraint-based layouts are based on relationships between the values of two <see cref="T:UIKit.NSLayoutAttribute" />s.
	/// Constraints can be made more flexible by allowing relationships other than strict equality, that is,
	/// <see cref="F:UIKit.NSLayoutRelation.GreaterThanOrEqual" /> or <see cref="F:UIKit.NSLayoutRelation.LessThanOrEqual" />. With relations
	/// other than <see cref="F:UIKit.NSLayoutRelation.Equal" /> the constraint solver will attempt to minimize the difference
	/// in attributes. If <see cref="F:UIKit.NSLayoutRelation.Equal" /> is specified and the constraint solver cannot solve the
	/// system of constraints, the constraint solver will throw an exception.
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum NSLayoutRelation : long {
		/// <summary>A less-than-or-equal relationship.</summary>
		LessThanOrEqual = -1,
		/// <summary>An equality relationship.</summary>
		Equal = 0,
		/// <summary>A greater-than-or-equal relationship.</summary>
		GreaterThanOrEqual = 1,
	}
}
