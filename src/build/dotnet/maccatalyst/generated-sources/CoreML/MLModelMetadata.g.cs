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
namespace CoreML {
	/// <summary>A <see cref="T:Foundation.DictionaryContainer" /> that holds metadata related to a <see cref="T:CoreML.MLModel" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class MLModelMetadata : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="MLModelMetadata" /> with default (empty) values.</summary>
		public MLModelMetadata () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="MLModelMetadata" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public MLModelMetadata (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>A developer-meaningful description of the <see cref="T:CoreML.MLModel" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Description {
			get {
				return GetStringValue (MLModelMetadataKeys.DescriptionKey!);
			}
		}
		/// <summary>A developer-meaningful identifier of the version of the <see cref="T:CoreML.MLModel" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? VersionString {
			get {
				return GetStringValue (MLModelMetadataKeys.VersionStringKey!);
			}
		}
		/// <summary>The author of the <see cref="T:CoreML.MLModel" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Author {
			get {
				return GetStringValue (MLModelMetadataKeys.AuthorKey!);
			}
		}
		/// <summary>A name or short description of the license and link to a complete definition.</summary><value>To be added.</value><remarks><para>This value should identify the license and provide a resource for the license's complete definition. For instance, "Creative Common License. More information available at http://places.csail.mit.edu"	.</para></remarks>
		public string? License {
			get {
				return GetStringValue (MLModelMetadataKeys.LicenseKey!);
			}
		}
		/// <summary>Additional metadata defined by the model's creator.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? CreatorDefined {
			get {
				return GetStringValue (MLModelMetadataKeys.CreatorDefinedKey!);
			}
		}
#endif
	}
}
