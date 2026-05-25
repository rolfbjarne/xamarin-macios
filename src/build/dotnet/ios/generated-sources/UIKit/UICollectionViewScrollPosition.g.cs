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
	/// <summary>An enumeration of values used to specify to where a <see cref="T:UIKit.UIView" /> should end up after a scroll into a <see cref="T:UIKit.UICollectionView" />.</summary><remarks>To be added.</remarks><!--TODO : Confirm that it's UIView and not a specialized type --><altmember cref="T:UIKit.UICollectionView" />
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native]
	public enum UICollectionViewScrollPosition : ulong {
		/// <summary>Do not scroll the item into the view.</summary>
		None = 0,
		/// <summary>Scrolls so that the item is positioned at the top of the view's bounds.</summary>
		Top = 1,
		/// <summary>Scrolls so that the item is centered vertically in the collection view.</summary>
		CenteredVertically = 2,
		/// <summary>Scrolls so that the item is positioned at the bottom of the collection view.</summary>
		Bottom = 4,
		/// <summary>Scrolls so that the item is positioned at the left edge of the collection view.</summary>
		Left = 8,
		/// <summary>Scrolls so that the item is centered horizontally in the collection view.</summary>
		CenteredHorizontally = 16,
		/// <summary>Scrolls so that the item is positioned at the right edge of the collection view.</summary>
		Right = 32,
	}
}
