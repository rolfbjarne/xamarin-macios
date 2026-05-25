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
	[Native]
	public enum FSItemAttribute : long {
		Type = 1,
		Mode = 2,
		LinkCount = 4,
		Uid = 8,
		Gid = 16,
		Flags = 32,
		Size = 64,
		AllocSize = 128,
		FileId = 256,
		ParentId = 512,
		AccessTime = 1024,
		ModifyTime = 2048,
		ChangeTime = 4096,
		BirthTime = 8192,
		BackupTime = 16384,
		AddedTime = 32768,
		SupportsLimitedXAttrs = 65536,
		InhibitKernelOffloadedIo = 131072,
	}
}
