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
	/// <summary>An enumeration of valid <see cref="P:UIKit.UICollectionViewUpdateItem.UpdateAction" /> properties.</summary><remarks>To be added.</remarks><altmember cref="P:UIKit.UICollectionViewUpdateItem.UpdateAction" />
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UICollectionUpdateAction : long {
		/// <summary>Inserts the item into the collection view.</summary>
		Insert = 0,
		/// <summary>Removes the item from the collection view.</summary>
		Delete = 1,
		/// <summary>Reloads the item by deleting and then inserting it into the collection view.</summary>
		Reload = 2,
		/// <summary>Moves the item to a new location.</summary>
		Move = 3,
		/// <summary>Take no action on the item.</summary>
		None = 4,
	}
}
