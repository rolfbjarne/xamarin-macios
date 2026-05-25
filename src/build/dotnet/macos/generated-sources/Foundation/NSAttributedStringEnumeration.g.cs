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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
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
	/// <summary>An enumeration whose values specify the options to be used in the <see cref="M:Foundation.NSAttributedString.EnumerateAttribute(Foundation.NSString,Foundation.NSRange,Foundation.NSAttributedStringEnumeration,Foundation.NSAttributedStringCallback)" /> and <see cref="M:Foundation.NSAttributedString.EnumerateAttributes(Foundation.NSRange,Foundation.NSAttributedStringEnumeration,Foundation.NSAttributedRangeCallback)" /> methods.</summary><remarks>To be added.</remarks>
	[Flags]
	[Native ("NSAttributedStringEnumerationOptions")]
	public enum NSAttributedStringEnumeration : ulong {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		Reverse = 2,
		/// <summary>To be added.</summary>
		LongestEffectiveRangeNotRequired = 1048576,
	}
}
