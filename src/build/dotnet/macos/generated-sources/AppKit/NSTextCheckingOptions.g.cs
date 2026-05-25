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
namespace AppKit {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public partial class NSTextCheckingOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="NSTextCheckingOptions" /> with default (empty) values.</summary>
		public NSTextCheckingOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="NSTextCheckingOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public NSTextCheckingOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSOrthography? Orthography {
			get {
				return Dictionary [NSTextCheckingKey.OrthographyKey!] as Foundation.NSOrthography;
			}
			set {
				SetNativeValue (NSTextCheckingKey.OrthographyKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string[]? Quotes {
			get {
				return GetArray<string> (NSTextCheckingKey.QuotesKey!, (ptr) => CFString.FromHandle (ptr)!);
			}
			set {
				SetArrayValue (NSTextCheckingKey.QuotesKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? Replacements {
			get {
				return GetNSDictionary (NSTextCheckingKey.ReplacementsKey!);
			}
			set {
				SetNativeValue (NSTextCheckingKey.ReplacementsKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDate? ReferenceDate {
			get {
				return Dictionary [NSTextCheckingKey.ReferenceDateKey!] as Foundation.NSDate;
			}
			set {
				SetNativeValue (NSTextCheckingKey.ReferenceDateKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSTimeZone? ReferenceTimeZone {
			get {
				return Dictionary [NSTextCheckingKey.ReferenceTimeZoneKey!] as Foundation.NSTimeZone;
			}
			set {
				SetNativeValue (NSTextCheckingKey.ReferenceTimeZoneKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSUrl? DocumentUrl {
			get {
				return Dictionary [NSTextCheckingKey.DocumentUrlKey!] as Foundation.NSUrl;
			}
			set {
				SetNativeValue (NSTextCheckingKey.DocumentUrlKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? DocumentTitle {
			get {
				return GetStringValue (NSTextCheckingKey.DocumentTitleKey!);
			}
			set {
				SetStringValue (NSTextCheckingKey.DocumentTitleKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? DocumentAuthor {
			get {
				return GetStringValue (NSTextCheckingKey.DocumentAuthorKey!);
			}
			set {
				SetStringValue (NSTextCheckingKey.DocumentAuthorKey!, value);
			}
		}
#endif
	}
}
