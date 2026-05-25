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
	/// <summary>An enumeration whose values specify text effects (e.g., Letterpress). Used with <see cref="UIKit.UIStringAttributes.TextEffect" />.</summary><remarks>To be added.</remarks>
	public enum NSTextEffect : int {
		/// <summary>No style.</summary>
		None = 0,
		/// <summary>A style that looks like paper that has been layered and pressed onto the page.</summary>
		LetterPressStyle = 1,
		/// <summary>This value is returned when the underlying <see cref="UIKit.UIStringAttributes.WeakTextEffect" />
		/// 	can not be mapped to one of the strongly typed known
		/// 	enumeration values.   In that case use the <see cref="UIKit.UIStringAttributes.WeakTextEffect" />
		/// 	value to determine what kind of effect is being applied. </summary>
		UnknownUseWeakEffect = 2,
	}
}
