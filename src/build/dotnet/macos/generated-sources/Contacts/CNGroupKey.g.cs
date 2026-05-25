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
namespace Contacts {
	/// <summary>Provides string constants whose values are the names of properties common to all <see cref="T:Contacts.CNGroup" /> objects.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public unsafe static partial class CNGroupKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Identifier;
		/// <summary>Key for the <see cref="P:Contacts.CNGroup.Identifier" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNGroupIdentifierKey",  "Contacts")]
		public static NSString Identifier {
			get {
				if (_Identifier is null)
					_Identifier = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNGroupIdentifierKey")!;
				return _Identifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Name;
		/// <summary>Key for the <see cref="P:Contacts.CNGroup.Name" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNGroupNameKey",  "Contacts")]
		public static NSString Name {
			get {
				if (_Name is null)
					_Name = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNGroupNameKey")!;
				return _Name;
			}
		}
	} /* class CNGroupKey */
}
