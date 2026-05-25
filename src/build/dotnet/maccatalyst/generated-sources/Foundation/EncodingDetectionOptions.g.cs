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
namespace Foundation {
	/// <summary>A <see cref="T:Foundation.DictionaryContainer" /> containing hints for detecting the encoding of an <see cref="T:Foundation.NSString" />.</summary><remarks>To be added.</remarks>
	public partial class EncodingDetectionOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="EncodingDetectionOptions" /> with default (empty) values.</summary>
		public EncodingDetectionOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="EncodingDetectionOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public EncodingDetectionOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSStringEncoding[]? EncodingDetectionSuggestedEncodings {
			get {
				return GetArray<NSStringEncoding> (NSString.EncodingDetectionSuggestedEncodingsKey!, (ptr) => (NSStringEncoding?) Runtime.GetNSObjectChecked<NSNumber> (ptr)?.UInt64Value ?? default (NSStringEncoding));
			}
			set {
				SetArrayValue<NSStringEncoding> (NSString.EncodingDetectionSuggestedEncodingsKey!, value, (element) => Runtime.RetainAndAutoreleaseNSObject (new NSNumber ((ulong) element)));
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSStringEncoding[]? EncodingDetectionDisallowedEncodings {
			get {
				return GetArray<NSStringEncoding> (NSString.EncodingDetectionDisallowedEncodingsKey!, (ptr) => (NSStringEncoding?) Runtime.GetNSObjectChecked<NSNumber> (ptr)?.UInt64Value ?? default (NSStringEncoding));
			}
			set {
				SetArrayValue<NSStringEncoding> (NSString.EncodingDetectionDisallowedEncodingsKey!, value, (element) => Runtime.RetainAndAutoreleaseNSObject (new NSNumber ((ulong) element)));
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? EncodingDetectionUseOnlySuggestedEncodings {
			get {
				return  GetBoolValue (NSString.EncodingDetectionUseOnlySuggestedEncodingsKey!);
			}
			set {
				SetBooleanValue (NSString.EncodingDetectionUseOnlySuggestedEncodingsKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? EncodingDetectionAllowLossy {
			get {
				return  GetBoolValue (NSString.EncodingDetectionAllowLossyKey!);
			}
			set {
				SetBooleanValue (NSString.EncodingDetectionAllowLossyKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? EncodingDetectionFromWindows {
			get {
				return  GetBoolValue (NSString.EncodingDetectionFromWindowsKey!);
			}
			set {
				SetBooleanValue (NSString.EncodingDetectionFromWindowsKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSString? EncodingDetectionLossySubstitution {
			get {
				return GetNSStringValue (NSString.EncodingDetectionLossySubstitutionKey!);
			}
			set {
				SetStringValue (NSString.EncodingDetectionLossySubstitutionKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSString? EncodingDetectionLikelyLanguage {
			get {
				return GetNSStringValue (NSString.EncodingDetectionLikelyLanguageKey!);
			}
			set {
				SetStringValue (NSString.EncodingDetectionLikelyLanguageKey!, value);
			}
		}
#endif
	}
}
