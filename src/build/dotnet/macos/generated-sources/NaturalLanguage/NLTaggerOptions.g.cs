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
namespace NaturalLanguage {
	/// <summary>Enumerates preprocessing options for tags.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native]
	public enum NLTaggerOptions : ulong {
		/// <summary>Indicates that <see cref="P:NaturalLanguage.NLTag.OtherWord" /> will be omitted from the tag stream.</summary>
		OmitWords = 1,
		/// <summary>Indicates that <see cref="P:NaturalLanguage.NLTag.OtherPunctuation" /> will be omitted from the tag stream.</summary>
		OmitPunctuation = 2,
		/// <summary>Indicates that <see cref="P:NaturalLanguage.NLTag.OtherWhitespace" /> will be omitted from the tag stream.</summary>
		OmitWhitespace = 4,
		/// <summary>Indicates that <see cref="P:NaturalLanguage.NLTag.Other" /> will be omitted from the tag stream.</summary>
		OmitOther = 8,
		/// <summary>Indicates that tags for the parts of names should be joined into one tag for the underlying name.</summary>
		JoinNames = 16,
		/// <summary>Indicates that tags for parts of a contraction should be joined into one tag for the contraction.</summary>
		JoinContractions = 32,
	}
}
