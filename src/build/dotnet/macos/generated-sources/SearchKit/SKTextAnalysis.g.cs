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
namespace SearchKit {
	public partial class SKTextAnalysis : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="SKTextAnalysis" /> with default (empty) values.</summary>
		public SKTextAnalysis () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="SKTextAnalysis" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public SKTextAnalysis (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public int? MinTermLength {
			get {
				return  GetInt32Value (SKTextAnalysisKeys.MinTermLengthKey!);
			}
			set {
				SetNumberValue (SKTextAnalysisKeys.MinTermLengthKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSSet? StopWords {
			get {
				return Dictionary [SKTextAnalysisKeys.StopWordsKey!] as Foundation.NSSet;
			}
			set {
				SetNativeValue (SKTextAnalysisKeys.StopWordsKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? Substitutions {
			get {
				return GetNSDictionary (SKTextAnalysisKeys.SubstitutionsKey!);
			}
			set {
				SetNativeValue (SKTextAnalysisKeys.SubstitutionsKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSNumber? MaximumTerms {
			get {
				return Dictionary [SKTextAnalysisKeys.MaximumTermsKey!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (SKTextAnalysisKeys.MaximumTermsKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? ProximityIndexing {
			get {
				return  GetBoolValue (SKTextAnalysisKeys.ProximityIndexingKey!);
			}
			set {
				SetBooleanValue (SKTextAnalysisKeys.ProximityIndexingKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? TermChars {
			get {
				return GetStringValue (SKTextAnalysisKeys.TermCharsKey!);
			}
			set {
				SetStringValue (SKTextAnalysisKeys.TermCharsKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? StartTermChars {
			get {
				return GetStringValue (SKTextAnalysisKeys.StartTermCharsKey!);
			}
			set {
				SetStringValue (SKTextAnalysisKeys.StartTermCharsKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? EndTermChars {
			get {
				return GetStringValue (SKTextAnalysisKeys.EndTermCharsKey!);
			}
			set {
				SetStringValue (SKTextAnalysisKeys.EndTermCharsKey!, value);
			}
		}
#endif
	}
}
