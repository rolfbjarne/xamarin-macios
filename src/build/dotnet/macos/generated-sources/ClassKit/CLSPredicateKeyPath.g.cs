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
namespace ClassKit {
	/// <summary>Enumerates key paths for retrieving ClassKit contexts.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class CLSPredicateKeyPath  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DateCreated;
		/// <summary>Gets the key path for retrieving contexts by their creation date.</summary><value>The key path for retrieving contexts by their creation date.</value><remarks>To be added.</remarks>
		[Field ("CLSPredicateKeyPathDateCreated",  "ClassKit")]
		public static NSString DateCreated {
			get {
				if (_DateCreated is null)
					_DateCreated = Dlfcn.GetStringConstant (Libraries.ClassKit.Handle, "CLSPredicateKeyPathDateCreated")!;
				return _DateCreated;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Identifier;
		/// <summary>Gets the key path for retrieving contexts by their identifier.</summary><value>The key path for retrieving contexts by their identifier.</value><remarks>To be added.</remarks>
		[Field ("CLSPredicateKeyPathIdentifier",  "ClassKit")]
		public static NSString Identifier {
			get {
				if (_Identifier is null)
					_Identifier = Dlfcn.GetStringConstant (Libraries.ClassKit.Handle, "CLSPredicateKeyPathIdentifier")!;
				return _Identifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Parent;
		/// <summary>Gets the key path for retrieving contexts by their parent.</summary><value>The key path for retrieving contexts by their parent.</value><remarks>To be added.</remarks>
		[Field ("CLSPredicateKeyPathParent",  "ClassKit")]
		public static NSString Parent {
			get {
				if (_Parent is null)
					_Parent = Dlfcn.GetStringConstant (Libraries.ClassKit.Handle, "CLSPredicateKeyPathParent")!;
				return _Parent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Title;
		/// <summary>Gets the key path for retrieving contexts by their title.</summary><value>The key path for retrieving contexts by their title.</value><remarks>To be added.</remarks>
		[Field ("CLSPredicateKeyPathTitle",  "ClassKit")]
		public static NSString Title {
			get {
				if (_Title is null)
					_Title = Dlfcn.GetStringConstant (Libraries.ClassKit.Handle, "CLSPredicateKeyPathTitle")!;
				return _Title;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Topic;
		/// <summary>Gets the key path for retrieving contexts by topic.</summary><value>The key path for retrieving contexts by topic.</value><remarks>To be added.</remarks>
		[Field ("CLSPredicateKeyPathTopic",  "ClassKit")]
		public static NSString Topic {
			get {
				if (_Topic is null)
					_Topic = Dlfcn.GetStringConstant (Libraries.ClassKit.Handle, "CLSPredicateKeyPathTopic")!;
				return _Topic;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UniversalLinkUrl;
		/// <summary>Gets the key path for retrieving contexts by universal link URL.</summary><value>The key path for retrieving contexts by universal link URL.</value><remarks>To be added.</remarks>
		[Field ("CLSPredicateKeyPathUniversalLinkURL",  "ClassKit")]
		public static NSString UniversalLinkUrl {
			get {
				if (_UniversalLinkUrl is null)
					_UniversalLinkUrl = Dlfcn.GetStringConstant (Libraries.ClassKit.Handle, "CLSPredicateKeyPathUniversalLinkURL")!;
				return _UniversalLinkUrl;
			}
		}
	} /* class CLSPredicateKeyPath */
}
