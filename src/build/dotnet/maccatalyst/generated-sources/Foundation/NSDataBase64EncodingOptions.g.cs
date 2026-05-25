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
namespace Foundation {
	/// <summary>A flagging enumeration that can be used to specify options for <see cref="M:Foundation.NSData.GetBase64EncodedData(Foundation.NSDataBase64EncodingOptions)" /> and <see cref="M:Foundation.NSData.GetBase64EncodedString(Foundation.NSDataBase64EncodingOptions)" />.</summary><remarks>To be added.</remarks>
	[Flags]
	[Native]
	public enum NSDataBase64EncodingOptions : ulong {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		SixtyFourCharacterLineLength = 1,
		/// <summary>To be added.</summary>
		SeventySixCharacterLineLength = 2,
		/// <summary>To be added.</summary>
		EndLineWithCarriageReturn = 16,
		/// <summary>To be added.</summary>
		EndLineWithLineFeed = 32,
	}
}
