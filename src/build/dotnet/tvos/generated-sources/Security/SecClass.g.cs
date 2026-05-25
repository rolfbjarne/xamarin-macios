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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Security {
	internal unsafe static partial class SecClass  {
		/// <summary>Represents the value associated with the constant 'kSecClassCertificate'.</summary>
		[Field ("kSecClassCertificate",  "Security")]
		public static nint Certificate {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecClassCertificate");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecClassGenericPassword'.</summary>
		[Field ("kSecClassGenericPassword",  "Security")]
		public static nint GenericPassword {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecClassGenericPassword");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecClassIdentity'.</summary>
		[Field ("kSecClassIdentity",  "Security")]
		public static nint Identity {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecClassIdentity");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecClassInternetPassword'.</summary>
		[Field ("kSecClassInternetPassword",  "Security")]
		public static nint InternetPassword {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecClassInternetPassword");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecClassKey'.</summary>
		[Field ("kSecClassKey",  "Security")]
		public static nint Key {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecClassKey");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecClass'.</summary>
		[Field ("kSecClass",  "Security")]
		public static nint SecClassKey {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecClass");
			}
		}
	} /* class SecClass */
}
