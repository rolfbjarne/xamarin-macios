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
	/// <summary>Constants for use with the <c>options</c> argument in <see cref="M:SceneKit.SCNNode.HitTest(SceneKit.SCNVector3,SceneKit.SCNVector3,SceneKit.SCNHitTestOptions)" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class SCNHitTest  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BackFaceCullingKey;
		/// <summary>Represents the value associated with the constant SCNHitTestBackFaceCullingKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNHitTestBackFaceCullingKey",  "SceneKit")]
		public static NSString BackFaceCullingKey {
			get {
				if (_BackFaceCullingKey is null)
					_BackFaceCullingKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNHitTestBackFaceCullingKey")!;
				return _BackFaceCullingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BoundingBoxOnlyKey;
		/// <summary>Represents the value associated with the constant SCNHitTestBoundingBoxOnlyKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNHitTestBoundingBoxOnlyKey",  "SceneKit")]
		public static NSString BoundingBoxOnlyKey {
			get {
				if (_BoundingBoxOnlyKey is null)
					_BoundingBoxOnlyKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNHitTestBoundingBoxOnlyKey")!;
				return _BoundingBoxOnlyKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ClipToZRangeKey;
		/// <summary>Represents the value associated with the constant SCNHitTestClipToZRangeKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNHitTestClipToZRangeKey",  "SceneKit")]
		public static NSString ClipToZRangeKey {
			get {
				if (_ClipToZRangeKey is null)
					_ClipToZRangeKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNHitTestClipToZRangeKey")!;
				return _ClipToZRangeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FirstFoundOnlyKey;
		/// <summary>Represents the value associated with the constant SCNHitTestFirstFoundOnlyKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNHitTestFirstFoundOnlyKey",  "SceneKit")]
		public static NSString FirstFoundOnlyKey {
			get {
				if (_FirstFoundOnlyKey is null)
					_FirstFoundOnlyKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNHitTestFirstFoundOnlyKey")!;
				return _FirstFoundOnlyKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IgnoreChildNodesKey;
		/// <summary>Represents the value associated with the constant SCNHitTestIgnoreChildNodesKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNHitTestIgnoreChildNodesKey",  "SceneKit")]
		public static NSString IgnoreChildNodesKey {
			get {
				if (_IgnoreChildNodesKey is null)
					_IgnoreChildNodesKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNHitTestIgnoreChildNodesKey")!;
				return _IgnoreChildNodesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IgnoreHiddenNodesKey;
		/// <summary>Represents the value associated with the constant SCNHitTestIgnoreHiddenNodesKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNHitTestIgnoreHiddenNodesKey",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IgnoreHiddenNodesKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IgnoreHiddenNodesKey is null)
					_IgnoreHiddenNodesKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNHitTestIgnoreHiddenNodesKey")!;
				return _IgnoreHiddenNodesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IgnoreLightAreaKey;
		/// <summary>Represents the value associated with the constant 'SCNHitTestOptionIgnoreLightArea'.</summary>
		[Field ("SCNHitTestOptionIgnoreLightArea",  "SceneKit")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString IgnoreLightAreaKey {
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_IgnoreLightAreaKey is null)
					_IgnoreLightAreaKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNHitTestOptionIgnoreLightArea")!;
				return _IgnoreLightAreaKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OptionCategoryBitMaskKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SCNHitTestOptionCategoryBitMask",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString OptionCategoryBitMaskKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_OptionCategoryBitMaskKey is null)
					_OptionCategoryBitMaskKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNHitTestOptionCategoryBitMask")!;
				return _OptionCategoryBitMaskKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RootNodeKey;
		/// <summary>Represents the value associated with the constant SCNHitTestRootNodeKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNHitTestRootNodeKey",  "SceneKit")]
		public static NSString RootNodeKey {
			get {
				if (_RootNodeKey is null)
					_RootNodeKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNHitTestRootNodeKey")!;
				return _RootNodeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SearchModeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SCNHitTestOptionSearchMode",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString SearchModeKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_SearchModeKey is null)
					_SearchModeKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNHitTestOptionSearchMode")!;
				return _SearchModeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SortResultsKey;
		/// <summary>Represents the value associated with the constant SCNHitTestSortResultsKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNHitTestSortResultsKey",  "SceneKit")]
		public static NSString SortResultsKey {
			get {
				if (_SortResultsKey is null)
					_SortResultsKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNHitTestSortResultsKey")!;
				return _SortResultsKey;
			}
		}
	} /* class SCNHitTest */
}
