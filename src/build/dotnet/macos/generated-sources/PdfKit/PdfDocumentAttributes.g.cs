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
namespace PdfKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public partial class PdfDocumentAttributes : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="PdfDocumentAttributes" /> with default (empty) values.</summary>
		public PdfDocumentAttributes () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="PdfDocumentAttributes" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public PdfDocumentAttributes (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Title {
			get {
				return GetStringValue (PdfDocumentAttributeKeys.TitleKey!);
			}
			set {
				SetStringValue (PdfDocumentAttributeKeys.TitleKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Author {
			get {
				return GetStringValue (PdfDocumentAttributeKeys.AuthorKey!);
			}
			set {
				SetStringValue (PdfDocumentAttributeKeys.AuthorKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Subject {
			get {
				return GetStringValue (PdfDocumentAttributeKeys.SubjectKey!);
			}
			set {
				SetStringValue (PdfDocumentAttributeKeys.SubjectKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Creator {
			get {
				return GetStringValue (PdfDocumentAttributeKeys.CreatorKey!);
			}
			set {
				SetStringValue (PdfDocumentAttributeKeys.CreatorKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Producer {
			get {
				return GetStringValue (PdfDocumentAttributeKeys.ProducerKey!);
			}
			set {
				SetStringValue (PdfDocumentAttributeKeys.ProducerKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDate? CreationDate {
			get {
				return Dictionary [PdfDocumentAttributeKeys.CreationDateKey!] as Foundation.NSDate;
			}
			set {
				SetNativeValue (PdfDocumentAttributeKeys.CreationDateKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDate? ModificationDate {
			get {
				return Dictionary [PdfDocumentAttributeKeys.ModificationDateKey!] as Foundation.NSDate;
			}
			set {
				SetNativeValue (PdfDocumentAttributeKeys.ModificationDateKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string[]? Keywords {
			get {
				return GetArray<string> (PdfDocumentAttributeKeys.KeywordsKey!, (ptr) => CFString.FromHandle (ptr)!);
			}
			set {
				SetArrayValue (PdfDocumentAttributeKeys.KeywordsKey!, value);
			}
		}
#endif
	}
}
