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
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace PushKit {
	/// <summary>Holds the transports available for Push Kit (currently only Voice Over IP).</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class PKPushType  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Complication;
		/// <summary>Gets the WatchKit complication push type, <c>PKPushTypeComplication</c>.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPushTypeComplication",  "PushKit")]
		[ObsoletedOSPlatform ("ios13.0", "Use directly from watchOS instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use directly from watchOS instead.")]
		[SupportedOSPlatform ("ios")]
		public static NSString Complication {
			[ObsoletedOSPlatform ("ios13.0", "Use directly from watchOS instead.")]
			[UnsupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use directly from watchOS instead.")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_Complication is null)
					_Complication = Dlfcn.GetStringConstant (Libraries.PushKit.Handle, "PKPushTypeComplication")!;
				return _Complication;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileProvider;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPushTypeFileProvider",  "PushKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString FileProvider {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FileProvider is null)
					_FileProvider = Dlfcn.GetStringConstant (Libraries.PushKit.Handle, "PKPushTypeFileProvider")!;
				return _FileProvider;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Voip;
		/// <summary>Represents the value associated with the constant PKPushTypeVoIP</summary><value></value><remarks>To be added.</remarks>
		[Field ("PKPushTypeVoIP",  "PushKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		public static NSString Voip {
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_Voip is null)
					_Voip = Dlfcn.GetStringConstant (Libraries.PushKit.Handle, "PKPushTypeVoIP")!;
				return _Voip;
			}
		}
	} /* class PKPushType */
}
