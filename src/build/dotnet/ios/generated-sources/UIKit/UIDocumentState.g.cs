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
namespace UIKit {
	/// <summary>An enumeration indicating the editing/saving state of a <see cref="T:UIKit.UIDocument" />.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Flags]
	[Native]
	public enum UIDocumentState : ulong {
		/// <summary>The <see cref="T:UIKit.UIDocument" /> is open, editing is allowed, and there are no detected conflicts.</summary>
		Normal = 0,
		/// <summary>Either the document did not open successfully or has been closed.</summary>
		Closed = 1,
		/// <summary>A conflict exists. The application developer should resolve these by examining the results of <see cref="M:Foundation.NSFileVersion.GetOtherVersions(Foundation.NSUrl)" />.</summary>
		InConflict = 2,
		/// <summary>Something has interfered with the proper saving of the <see cref="T:UIKit.UIDocument" />.</summary>
		SavingError = 4,
		/// <summary>The document is busy and the application developer must not allow the application user to introduce changes.</summary>
		EditingDisabled = 8,
		/// <summary>Indicates the progress information is available for the downloading document.</summary>
		ProgressAvailable = 16,
	}
}
