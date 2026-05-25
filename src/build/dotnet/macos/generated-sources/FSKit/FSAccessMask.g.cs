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
namespace FSKit {
	[SupportedOSPlatform ("macos15.4")]
	[Experimental ("APL0002")]
	[Flags]
	[Native]
	public enum FSAccessMask : ulong {
		ReadData = 2,
		ListDirectory = 2,
		WriteData = 4,
		AddFile = 4,
		Execute = 8,
		Search = 8,
		Delete = 16,
		AppendData = 32,
		AddSubdirectory = 32,
		DeleteChild = 64,
		ReadAttributes = 128,
		WriteAttributes = 256,
		ReadXattr = 512,
		WriteXattr = 1024,
		ReadSecurity = 2048,
		WriteSecurity = 4096,
		TakeOwnership = 8192,
	}
}
