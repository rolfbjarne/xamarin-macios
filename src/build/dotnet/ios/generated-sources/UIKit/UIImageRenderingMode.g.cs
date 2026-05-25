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
	/// <summary>An enumeration whose values specify rendering modes for a <see cref="T:UIKit.UIImage" />.</summary><remarks><para>
	/// A template image is used as a mask to create the final image. A template image inherits the <see cref="P:UIKit.UIView.TintColor" />
	/// of its parent. Application developers who do not want this behavior should use <see cref="F:UIKit.UIImageRenderingMode.AlwaysOriginal" />.
	/// </para></remarks>
	[Native]
	public enum UIImageRenderingMode : long {
		/// <summary>The default rendering mode for the context.</summary>
		Automatic = 0,
		/// <summary>Always draws the original image, without treating it as a template.</summary>
		AlwaysOriginal = 1,
		/// <summary>Always draws the image as a template, ignoring its color information.</summary>
		AlwaysTemplate = 2,
	}
}
