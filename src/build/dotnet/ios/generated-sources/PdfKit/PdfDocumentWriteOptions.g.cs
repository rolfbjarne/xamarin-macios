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
namespace PdfKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public partial class PdfDocumentWriteOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="PdfDocumentWriteOptions" /> with default (empty) values.</summary>
		public PdfDocumentWriteOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="PdfDocumentWriteOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public PdfDocumentWriteOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? OwnerPassword {
			get {
				return GetStringValue (PdfDocumentWriteOptionKeys.OwnerPasswordKey!);
			}
			set {
				SetStringValue (PdfDocumentWriteOptionKeys.OwnerPasswordKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? UserPassword {
			get {
				return GetStringValue (PdfDocumentWriteOptionKeys.UserPasswordKey!);
			}
			set {
				SetStringValue (PdfDocumentWriteOptionKeys.UserPasswordKey!, value);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		public string? AccessPermissions {
			get {
				return GetStringValue (PdfDocumentWriteOptionKeys.AccessPermissionsKey!);
			}
			set {
				SetStringValue (PdfDocumentWriteOptionKeys.AccessPermissionsKey!, value);
			}
		}
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos18.2")]
		public bool? BurnInAnnotations {
			get {
				return  GetBoolValue (PdfDocumentWriteOptionKeys.BurnInAnnotationsKey!);
			}
			set {
				SetBooleanValue (PdfDocumentWriteOptionKeys.BurnInAnnotationsKey!, value);
			}
		}
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos18.2")]
		public bool? SaveTextFromOcr {
			get {
				return  GetBoolValue (PdfDocumentWriteOptionKeys.SaveTextFromOcrKey!);
			}
			set {
				SetBooleanValue (PdfDocumentWriteOptionKeys.SaveTextFromOcrKey!, value);
			}
		}
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[SupportedOSPlatform ("tvos18.2")]
		public bool? SaveImagesAsJpeg {
			get {
				return  GetBoolValue (PdfDocumentWriteOptionKeys.SaveImagesAsJpegKey!);
			}
			set {
				SetBooleanValue (PdfDocumentWriteOptionKeys.SaveImagesAsJpegKey!, value);
			}
		}
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[SupportedOSPlatform ("tvos18.2")]
		public bool? OptimizeImagesForScreen {
			get {
				return  GetBoolValue (PdfDocumentWriteOptionKeys.OptimizeImagesForScreenKey!);
			}
			set {
				SetBooleanValue (PdfDocumentWriteOptionKeys.OptimizeImagesForScreenKey!, value);
			}
		}
#endif
	}
}
