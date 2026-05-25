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
namespace UIKit {
	/// <summary>A <see cref="T:Foundation.DictionaryContainer" /> that holds options for use with calls to <see cref="M:UIKit.UIApplication.OpenUrl(Foundation.NSUrl)" /> or <see cref="M:UIKit.UIApplication.OpenUrl(Foundation.NSUrl,Foundation.NSDictionary,System.Action{System.Boolean})" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public partial class UIApplicationOpenUrlOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="UIApplicationOpenUrlOptions" /> with default (empty) values.</summary>
		public UIApplicationOpenUrlOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="UIApplicationOpenUrlOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public UIApplicationOpenUrlOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>A property-list object.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSObject? Annotation {
			get {
				return GetNativeValue<Foundation.NSObject> (UIApplicationOpenUrlOptionKeys.AnnotationKey!);
			}
			set {
				SetNativeValue (UIApplicationOpenUrlOptionKeys.AnnotationKey!, value);
			}
		}
		/// <summary>The application that generated the open request.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? SourceApplication {
			get {
				return GetStringValue (UIApplicationOpenUrlOptionKeys.SourceApplicationKey!);
			}
			set {
				SetStringValue (UIApplicationOpenUrlOptionKeys.SourceApplicationKey!, value);
			}
		}
		/// <summary>Whether the URL should be opened in place.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? OpenInPlace {
			get {
				return  GetBoolValue (UIApplicationOpenUrlOptionKeys.OpenInPlaceKey!);
			}
			set {
				SetBooleanValue (UIApplicationOpenUrlOptionKeys.OpenInPlaceKey!, value);
			}
		}
		/// <summary>Gets or sets whether URLs must be universal links.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public bool? UniversalLinksOnly {
			get {
				return  GetBoolValue (UIApplicationOpenUrlOptionKeys.UniversalLinksOnlyKey!);
			}
			set {
				SetBooleanValue (UIApplicationOpenUrlOptionKeys.UniversalLinksOnlyKey!, value);
			}
		}
#endif
	}
}
