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
namespace Photos {
	/// <summary>Enumerates values that describe the editing operations that can be performed on a collection.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum PHCollectionEditOperation : long {
		/// <summary>No capabilities are specified.</summary>
		None = 0,
		/// <summary>Content can be deleted from the collection.</summary>
		DeleteContent = 1,
		/// <summary>Content can be removed from the collection without being permanently deleted.</summary>
		RemoveContent = 2,
		/// <summary>Content can be added to the collection.</summary>
		AddContent = 3,
		/// <summary>The collection can create new content or duplicate existing content.</summary>
		CreateContent = 4,
		/// <summary>Content can be rearranged within the collection.</summary>
		RearrangeContent = 5,
		/// <summary>The collection can be deleted.</summary>
		Delete = 6,
		/// <summary>Content within the collection can be renamed.</summary>
		Rename = 7,
	}
}
