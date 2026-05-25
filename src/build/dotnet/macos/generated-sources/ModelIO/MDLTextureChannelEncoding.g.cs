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
namespace ModelIO {
	/// <summary>Enumerates values that specify data types and sizes for texel channels.</summary>
	[Native]
	public enum MDLTextureChannelEncoding : long {
		/// <summary>Indicates that each channel is an unsigned 8-bit integer.</summary>
		UInt8 = 1,
		/// <summary>Indicates that each channel is an unsigned 16-bit integer.</summary>
		UInt16 = 2,
		/// <summary>Indicates that each channel is an unsigned 24-bit integer.</summary>
		UInt24 = 3,
		/// <summary>Indicates that each channel is an unsigned 32-bit integer.</summary>
		UInt32 = 4,
		/// <summary>Indicates that each channel is a 16-bit floating-point number.</summary>
		Float16 = 258,
		/// <summary>To be added.</summary>
		Float16SR = 770,
		/// <summary>Indicates that each channel is a 32-bit floating-point number.</summary>
		Float32 = 260,
	}
}
