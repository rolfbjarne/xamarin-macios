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
namespace Security {
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public partial class SecSharedCredentialInfo : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="SecSharedCredentialInfo" /> with default (empty) values.</summary>
		public SecSharedCredentialInfo () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="SecSharedCredentialInfo" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public SecSharedCredentialInfo (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Server {
			get {
				return GetStringValue (SecSharedCredentialKeys.ServerKey!);
			}
			set {
				SetStringValue (SecSharedCredentialKeys.ServerKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Account {
			get {
				return GetStringValue (SecSharedCredentialKeys.AccountKey!);
			}
			set {
				SetStringValue (SecSharedCredentialKeys.AccountKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? Password {
			get {
				return GetStringValue (SecSharedCredentialKeys.PasswordKey!);
			}
			set {
				SetStringValue (SecSharedCredentialKeys.PasswordKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public int? Port {
			get {
				return  GetInt32Value (SecSharedCredentialKeys.PortKey!);
			}
			set {
				SetNumberValue (SecSharedCredentialKeys.PortKey!, value);
			}
		}
#endif
	}
}
