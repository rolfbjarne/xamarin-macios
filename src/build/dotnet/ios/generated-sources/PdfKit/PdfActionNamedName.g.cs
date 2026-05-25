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
namespace PdfKit {
	/// <summary>Enumerates named PDF action names.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[Native]
	public enum PdfActionNamedName : long {
		/// <summary>Indicates an action that has no name, or is not yet named.</summary>
		None = 0,
		/// <summary>Indicates an action that goes to the next page in a document.</summary>
		NextPage = 1,
		/// <summary>Indicates an action that goes to the previous page in a document.</summary>
		PreviousPage = 2,
		/// <summary>Indicates an action that goes to the first page of the document.</summary>
		FirstPage = 3,
		/// <summary>Indicates an action that goes to the last page of a document.</summary>
		LastPage = 4,
		/// <summary>Indicates an action that goes back one location in a navigation list.</summary>
		GoBack = 5,
		/// <summary>Indicates an action that goes forward one location in a navigation list.</summary>
		GoForward = 6,
		/// <summary>Indicates an action that goes to a specific page in a document.</summary>
		GoToPage = 7,
		/// <summary>Indicates the Find action.</summary>
		Find = 8,
		/// <summary>Indicates an action that prints a document.</summary>
		Print = 9,
		/// <summary>Indicates an action that zooms in.</summary>
		ZoomIn = 10,
		/// <summary>Indicates an action that zooms out.</summary>
		ZoomOut = 11,
	}
}
