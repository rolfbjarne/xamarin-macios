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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace VideoToolbox {
	[SupportedOSPlatform ("maccatalyst18.4")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("macos15.4")]
	[Native]
	public enum VTFrameProcessorError : long {
		UnknownError = -19730,
		UnsupportedResolution = -19731,
		SessionNotStarted = -19732,
		SessionAlreadyActive = -19733,
		FatalError = -19734,
		SessionLevelError = -19735,
		InitializationFailed = -19736,
		UnsupportedInput = -19737,
		MemoryAllocationFailure = -19738,
		RevisionNotSupported = -19739,
		ProcessingError = -19740,
		InvalidParameterError = -19741,
		InvalidFrameTiming = -19742,
		AssetDownloadFailed = -19743,
	}
	/// <summary>Extension methods for the <see cref="global::VideoToolbox.VTFrameProcessorError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::VideoToolbox.VTFrameProcessorError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst18.4")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("macos15.4")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class VTFrameProcessorErrorExtensions {
		[Field ("VTFrameProcessorErrorDomain", "VideoToolbox")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the VideoToolbox.VTFrameProcessorError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this VTFrameProcessorError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "VTFrameProcessorErrorDomain");
			return _domain;
		}
	}
}
