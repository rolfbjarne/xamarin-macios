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
namespace PassKit {
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public unsafe static partial class PKDirbursementError  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContactFieldUserInfoKey;
		/// <summary>Represents the value associated with the constant 'PKDisbursementErrorContactFieldUserInfoKey'.</summary>
		[Field ("PKDisbursementErrorContactFieldUserInfoKey",  "PassKit")]
		public static NSString ContactFieldUserInfoKey {
			get {
				if (_ContactFieldUserInfoKey is null)
					_ContactFieldUserInfoKey = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKDisbursementErrorContactFieldUserInfoKey")!;
				return _ContactFieldUserInfoKey;
			}
		}
	} /* class PKDirbursementError */
}
