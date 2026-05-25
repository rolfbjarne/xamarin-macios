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
namespace CoreImage {
	public partial class CIContextOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CIContextOptions" /> with default (empty) values.</summary>
		public CIContextOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CIContextOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CIContextOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>The desired CIColorSpace to be used for the CIContext rendering operation.</summary><remarks>This color space is used before the image is rendered into the output.</remarks>
		public CGColorSpace? OutputColorSpace {
			get {
				return GetNativeValue<CoreGraphics.CGColorSpace> (CIContextOptionKeys.OutputColorSpace!);
			}
			set {
				SetNativeValue (CIContextOptionKeys.OutputColorSpace!, value);
			}
		}
		/// <summary>The colorspace used by image processing operations, this is different than the colorspace used for the final rendering.</summary>
		public CGColorSpace? WorkingColorSpace {
			get {
				return GetNativeValue<CoreGraphics.CGColorSpace> (CIContextOptionKeys.WorkingColorSpace!);
			}
			set {
				SetNativeValue (CIContextOptionKeys.WorkingColorSpace!, value);
			}
		}
		/// <summary>Gets or sets the image format to use for storing intermediate rendering results.</summary>
		public CIFormat? WorkingFormatField {
			get {
				return (global::CoreImage.CIFormat?) GetInt32Value (CIContextOptionKeys.WorkingFormatField!);
			}
			set {
				SetNumberValue (CIContextOptionKeys.WorkingFormatField!, (int?) value);
			}
		}
		/// <summary><see langword="true" /> if downsampling should be higher quality at the expense of performance.</summary>
		public bool? HighQualityDownsample {
			get {
				return  GetBoolValue (CIContextOptionKeys.HighQualityDownsample!);
			}
			set {
				SetBooleanValue (CIContextOptionKeys.HighQualityDownsample!, value);
			}
		}
		/// <summary>If <see langword="true" />, the output should premultiply pixel values by their alpha values.</summary>
		public bool? OutputPremultiplied {
			get {
				return  GetBoolValue (CIContextOptionKeys.OutputPremultiplied!);
			}
			set {
				SetBooleanValue (CIContextOptionKeys.OutputPremultiplied!, value);
			}
		}
		/// <summary>If not <see langword="null" />, <see langword="true" /> indicates that intermediate images should be cached.</summary>
		public bool? CacheIntermediates {
			get {
				return  GetBoolValue (CIContextOptionKeys.CacheIntermediates!);
			}
			set {
				SetBooleanValue (CIContextOptionKeys.CacheIntermediates!, value);
			}
		}
		/// <summary>Setting this to true will force the CPU software rendered to be used and prevent the job to be offloaded to the GPU</summary><remarks><para>
		/// GPU contexts can be offloaded to the graphics processing
		/// unit and can run very fast and have the added advantage
		/// that they do not tax the main process with their task.
		/// GPU contexts have image sizes limits imposed by the
		/// underlying hardware, on some devices this can be 2048x2048
		/// and on devices like the iPad 2 this is 4096x4096.
		/// </para><para>
		/// CPU contexts have a few benefits, they can perform their
		/// tasks on the background, support larger input and output
		/// images (at the time of this writing, 8192x8192) and have
		/// improved fidelity due to the IEEE compliant floating point
		/// support.
		/// </para><para>
		/// You can check the actual limits for input and output image
		/// sizes by checking the <see cref="P:CoreImage.CIContext.InputImageMaximumSize" />
		/// and the <see cref="P:CoreImage.CIContext.OutputImageMaximumSize" />
		/// properties.
		/// </para><para>
		/// GPU contexts have one extra downside when interacting with
		/// background operations.  Consider the case where your
		/// application applies a number of filters and saves the
		/// result.  Typically, you will queue this work to take place
		/// even if the user suspends the application by pressing the
		/// home button.  The user might take a picture, and switch to
		/// another app.  If you chose to use a GPU context to process
		/// your image but you have been sent to the background, your
		/// application will be terminated when it tries to access the
		/// GPU, as the GPU is now in use by another application.
		/// </para></remarks>
		public bool? NullableUseSoftwareRenderer {
			get {
				return  GetBoolValue (CIContextOptionKeys.UseSoftwareRenderer!);
			}
		}
		/// <summary>Gets or sets whether to request low priority from the GPU.</summary>
		public bool? PriorityRequestLow {
			get {
				return  GetBoolValue (CIContextOptionKeys.PriorityRequestLow!);
			}
			set {
				SetBooleanValue (CIContextOptionKeys.PriorityRequestLow!, value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool? AllowLowPower {
			get {
				return  GetBoolValue (CIContextOptionKeys.AllowLowPower!);
			}
			set {
				SetBooleanValue (CIContextOptionKeys.AllowLowPower!, value);
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public string? Name {
			get {
				return GetStringValue (CIContextOptionKeys.Name!);
			}
			set {
				SetStringValue (CIContextOptionKeys.Name!, value);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public NSString? MemoryLimit {
			get {
				return GetNSStringValue (CIContextOptionKeys.MemoryLimit!);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public NSString? CVMetalTextureCache {
			get {
				return GetNSStringValue (CIContextOptionKeys.CVMetalTextureCache!);
			}
		}
#endif
	}
}
