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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace SceneKit {
	/// <summary>Metadata keys associated with a scene file. Used with <see cref="M:SceneKit.SCNSceneSource.GetProperty(Foundation.NSString)" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class SCNSceneSourceProperties  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AssetAuthorKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceAssetAuthorKey",  "SceneKit")]
		public static NSString AssetAuthorKey {
			get {
				if (_AssetAuthorKey is null)
					_AssetAuthorKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceAssetAuthorKey")!;
				return _AssetAuthorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AssetAuthoringToolKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceAssetAuthoringToolKey",  "SceneKit")]
		public static NSString AssetAuthoringToolKey {
			get {
				if (_AssetAuthoringToolKey is null)
					_AssetAuthoringToolKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceAssetAuthoringToolKey")!;
				return _AssetAuthoringToolKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AssetContributorsKey;
		/// <summary>Represents the value associated with the constant SCNSceneSourceAssetContributorsKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceAssetContributorsKey",  "SceneKit")]
		public static NSString AssetContributorsKey {
			get {
				if (_AssetContributorsKey is null)
					_AssetContributorsKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceAssetContributorsKey")!;
				return _AssetContributorsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AssetCreatedDateKey;
		/// <summary>Represents the value associated with the constant SCNSceneSourceAssetCreatedDateKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceAssetCreatedDateKey",  "SceneKit")]
		public static NSString AssetCreatedDateKey {
			get {
				if (_AssetCreatedDateKey is null)
					_AssetCreatedDateKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceAssetCreatedDateKey")!;
				return _AssetCreatedDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AssetModifiedDateKey;
		/// <summary>Represents the value associated with the constant SCNSceneSourceAssetModifiedDateKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceAssetModifiedDateKey",  "SceneKit")]
		public static NSString AssetModifiedDateKey {
			get {
				if (_AssetModifiedDateKey is null)
					_AssetModifiedDateKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceAssetModifiedDateKey")!;
				return _AssetModifiedDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AssetUnitKey;
		/// <summary>Represents the value associated with the constant SCNSceneSourceAssetUnitKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceAssetUnitKey",  "SceneKit")]
		public static NSString AssetUnitKey {
			get {
				if (_AssetUnitKey is null)
					_AssetUnitKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceAssetUnitKey")!;
				return _AssetUnitKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AssetUnitMeterKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceAssetUnitMeterKey",  "SceneKit")]
		public static NSString AssetUnitMeterKey {
			get {
				if (_AssetUnitMeterKey is null)
					_AssetUnitMeterKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceAssetUnitMeterKey")!;
				return _AssetUnitMeterKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AssetUnitNameKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceAssetUnitNameKey",  "SceneKit")]
		public static NSString AssetUnitNameKey {
			get {
				if (_AssetUnitNameKey is null)
					_AssetUnitNameKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceAssetUnitNameKey")!;
				return _AssetUnitNameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AssetUpAxisKey;
		/// <summary>Represents the value associated with the constant SCNSceneSourceAssetUpAxisKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceAssetUpAxisKey",  "SceneKit")]
		public static NSString AssetUpAxisKey {
			get {
				if (_AssetUpAxisKey is null)
					_AssetUpAxisKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceAssetUpAxisKey")!;
				return _AssetUpAxisKey;
			}
		}
	} /* class SCNSceneSourceProperties */
}
