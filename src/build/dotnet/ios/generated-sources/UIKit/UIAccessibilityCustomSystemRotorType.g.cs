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
	/// <summary>Enumerates the types of content that may be represented by a <see cref="T:UIKit.UIAccessibilityCustomRotor" /> object.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIAccessibilityCustomSystemRotorType : long {
		/// <summary>An unknown or non-specific type.</summary>
		None = 0,
		/// <summary>A non-visited link.</summary>
		Link = 1,
		/// <summary>A link that has been visited.</summary>
		VisitedLink = 2,
		/// <summary>Heading text of any level.</summary>
		Heading = 3,
		/// <summary>The highest heading level.</summary>
		HeadingLevel1 = 4,
		/// <summary>Heading level 2 text.</summary>
		HeadingLevel2 = 5,
		/// <summary>Heading level 3 text.</summary>
		HeadingLevel3 = 6,
		/// <summary>Heading level 4 text.</summary>
		HeadingLevel4 = 7,
		/// <summary>Heading level 5 text.</summary>
		HeadingLevel5 = 8,
		/// <summary>Heading level 5 text.</summary>
		HeadingLevel6 = 9,
		/// <summary>Text that is bolded.</summary>
		BoldText = 10,
		/// <summary>Italicized text.</summary>
		ItalicText = 11,
		/// <summary>Text that has been underlined.</summary>
		UnderlineText = 12,
		/// <summary>A word that has been misspelled.</summary>
		MisspelledWord = 13,
		/// <summary>A graphic element.</summary>
		Image = 14,
		/// <summary>A text field.</summary>
		TextField = 15,
		/// <summary>A table.</summary>
		Table = 16,
		/// <summary>A sequential list.</summary>
		List = 17,
		/// <summary>A landmark.</summary>
		Landmark = 18,
	}
}
