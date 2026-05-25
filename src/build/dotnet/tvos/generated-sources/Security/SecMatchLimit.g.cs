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
	/// <summary>Keys used to control query results.</summary><remarks>You can use either an NSNumber or one of the values defined in this class when manually querying.</remarks>
	public unsafe static partial class SecMatchLimit  {
		/// <summary>Return all matches.</summary><value /><remarks>To be added.</remarks>
		[Field ("kSecMatchLimitAll",  "Security")]
		public static nint MatchLimitAll {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecMatchLimitAll");
			}
		}
		/// <summary>Return a single match.</summary><value /><remarks>To be added.</remarks>
		[Field ("kSecMatchLimitOne",  "Security")]
		public static nint MatchLimitOne {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecMatchLimitOne");
			}
		}
	} /* class SecMatchLimit */
}
