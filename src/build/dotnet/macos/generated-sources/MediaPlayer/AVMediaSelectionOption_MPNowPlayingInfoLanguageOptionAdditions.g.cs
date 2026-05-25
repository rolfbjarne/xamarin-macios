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
namespace MediaPlayer {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AVMediaSelectionOption_MPNowPlayingInfoLanguageOptionAdditions  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakeNowPlayingInfoLanguageOptionX = "makeNowPlayingInfoLanguageOption";
		static readonly NativeHandle selMakeNowPlayingInfoLanguageOptionXHandle = Selector.GetHandle ("makeNowPlayingInfoLanguageOption");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVMediaSelectionOption");
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("makeNowPlayingInfoLanguageOption")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPNowPlayingInfoLanguageOption? CreateNowPlayingInfoLanguageOption (this global::AVFoundation.AVMediaSelectionOption This)
		{
			MPNowPlayingInfoLanguageOption ret;
			ret =  Runtime.GetNSObject<MPNowPlayingInfoLanguageOption> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, selMakeNowPlayingInfoLanguageOptionXHandle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	} /* class AVMediaSelectionOption_MPNowPlayingInfoLanguageOptionAdditions */
}
