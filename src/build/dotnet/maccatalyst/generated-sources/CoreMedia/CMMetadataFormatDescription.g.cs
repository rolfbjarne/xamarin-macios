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
namespace CoreMedia {
	public partial class CMMetadataFormatDescription : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CMMetadataFormatDescription" /> with default (empty) values.</summary>
		public CMMetadataFormatDescription () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CMMetadataFormatDescription" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CMMetadataFormatDescription (NSDictionary? dictionary) : base (dictionary) {}
		public uint? Namespace {
			get {
				return  GetUInt32Value (CMMetadataFormatDescriptionKeys.Namespace!);
			}
		}
		public NSData? Value {
			get {
				return Dictionary [CMMetadataFormatDescriptionKeys.Value!] as Foundation.NSData;
			}
		}
		public uint? LocalId {
			get {
				return  GetUInt32Value (CMMetadataFormatDescriptionKeys.LocalId!);
			}
		}
		public NSData? DataType {
			get {
				return Dictionary [CMMetadataFormatDescriptionKeys.DataType!] as Foundation.NSData;
			}
		}
		public int? DataTypeNamespace {
			get {
				return  GetInt32Value (CMMetadataFormatDescriptionKeys.DataTypeNamespace!);
			}
		}
		public NSObject? ConformingDataTypes {
			get {
				return GetNativeValue<Foundation.NSObject> (CMMetadataFormatDescriptionKeys.ConformingDataTypes!);
			}
		}
		public string? LanguageTag {
			get {
				return GetStringValue (CMMetadataFormatDescriptionKeys.LanguageTag!);
			}
		}
		public NSDictionary? StructuralDependency {
			get {
				return GetNSDictionary (CMMetadataFormatDescriptionKeys.StructuralDependency!);
			}
		}
		public NSData? SetupData {
			get {
				return Dictionary [CMMetadataFormatDescriptionKeys.SetupData!] as Foundation.NSData;
			}
		}
#endif
	}
}
