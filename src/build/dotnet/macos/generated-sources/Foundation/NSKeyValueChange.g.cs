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
	/// <summary>An enumeration indicating the type of change occurring in the <see cref="Foundation.NSObject.WillChangeValue(System.String)" /> and <see cref="Foundation.NSObject.DidChangeValue(System.String)" /> methods.</summary><remarks><para /></remarks>
	[Native]
	public enum NSKeyValueChange : ulong {
		/// <summary>The change is reported for setting a value in a property.</summary>
		Setting = 1,
		/// <summary>The change being reported is an insertion into a collection.</summary>
		Insertion = 2,
		/// <summary>The change being reported is a removal from a collection.</summary>
		Removal = 3,
		/// <summary>The change being reported is a set of changes in a collection.</summary>
		Replacement = 4,
	}
}
