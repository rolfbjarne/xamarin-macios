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
namespace CoreGraphics {
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public partial class CGPdfTagProperties : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CGPdfTagProperties" /> with default (empty) values.</summary>
		public CGPdfTagProperties () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CGPdfTagProperties" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CGPdfTagProperties (NSDictionary? dictionary) : base (dictionary) {}
		public string? ActualText {
			get {
				return GetStringValue (CGPdfTagPropertyKeys.ActualTextKey!);
			}
			set {
				SetStringValue (CGPdfTagPropertyKeys.ActualTextKey!, value);
			}
		}
		public string? AlternativeText {
			get {
				return GetStringValue (CGPdfTagPropertyKeys.AlternativeTextKey!);
			}
			set {
				SetStringValue (CGPdfTagPropertyKeys.AlternativeTextKey!, value);
			}
		}
		public string? TitleText {
			get {
				return GetStringValue (CGPdfTagPropertyKeys.TitleTextKey!);
			}
			set {
				SetStringValue (CGPdfTagPropertyKeys.TitleTextKey!, value);
			}
		}
		public string? LanguageText {
			get {
				return GetStringValue (CGPdfTagPropertyKeys.LanguageTextKey!);
			}
			set {
				SetStringValue (CGPdfTagPropertyKeys.LanguageTextKey!, value);
			}
		}
#endif
	}
}
