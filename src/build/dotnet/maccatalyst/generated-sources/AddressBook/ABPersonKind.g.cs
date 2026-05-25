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
namespace AddressBook {
	/// <summary>
	/// Specifies whether a <see cref="T:AddressBook.ABPerson" />
	/// represents a human being or an organization.
	/// </summary>
	[ObsoletedOSPlatform ("ios9.0", "Use the 'Contacts' API instead.")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'Contacts' API instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum ABPersonKind : int {
		/// <summary>
		/// It's unknown whether the
		/// <see cref="T:AddressBook.ABPerson" /> is a person or
		/// an organization.
		/// </summary>
		None = 0,
		/// <summary>
		/// The <see cref="T:AddressBook.ABPerson" /> is an organization.
		/// </summary>
		Organization = 1,
		/// <summary>
		/// The <see cref="T:AddressBook.ABPerson" /> is a person.
		/// </summary>
		Person = 2,
	}
}
