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
namespace AppKit {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos26.0")]
	public unsafe static partial class NSAccessibilityForSearchPredicateKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CurrentElement;
		/// <summary>Represents the value associated with the constant 'NSAccessibilitySearchCurrentElementKey'.</summary>
		[Field ("NSAccessibilitySearchCurrentElementKey",  "AppKit")]
		public static NSString CurrentElement {
			get {
				if (_CurrentElement is null)
					_CurrentElement = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySearchCurrentElementKey")!;
				return _CurrentElement;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CurrentRange;
		/// <summary>Represents the value associated with the constant 'NSAccessibilitySearchCurrentRangeKey'.</summary>
		[Field ("NSAccessibilitySearchCurrentRangeKey",  "AppKit")]
		public static NSString CurrentRange {
			get {
				if (_CurrentRange is null)
					_CurrentRange = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySearchCurrentRangeKey")!;
				return _CurrentRange;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Direction;
		/// <summary>Represents the value associated with the constant 'NSAccessibilitySearchDirectionKey'.</summary>
		[Field ("NSAccessibilitySearchDirectionKey",  "AppKit")]
		public static NSString Direction {
			get {
				if (_Direction is null)
					_Direction = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySearchDirectionKey")!;
				return _Direction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DirectionNext;
		/// <summary>Represents the value associated with the constant 'NSAccessibilitySearchDirectionNext'.</summary>
		[Field ("NSAccessibilitySearchDirectionNext",  "AppKit")]
		public static NSString DirectionNext {
			get {
				if (_DirectionNext is null)
					_DirectionNext = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySearchDirectionNext")!;
				return _DirectionNext;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DirectionPrevious;
		/// <summary>Represents the value associated with the constant 'NSAccessibilitySearchDirectionPrevious'.</summary>
		[Field ("NSAccessibilitySearchDirectionPrevious",  "AppKit")]
		public static NSString DirectionPrevious {
			get {
				if (_DirectionPrevious is null)
					_DirectionPrevious = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySearchDirectionPrevious")!;
				return _DirectionPrevious;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Identifiers;
		/// <summary>Represents the value associated with the constant 'NSAccessibilitySearchIdentifiersKey'.</summary>
		[Field ("NSAccessibilitySearchIdentifiersKey",  "AppKit")]
		public static NSString Identifiers {
			get {
				if (_Identifiers is null)
					_Identifiers = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySearchIdentifiersKey")!;
				return _Identifiers;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ResultDescriptionOverride;
		/// <summary>Represents the value associated with the constant 'NSAccessibilitySearchResultDescriptionOverrideKey'.</summary>
		[Field ("NSAccessibilitySearchResultDescriptionOverrideKey",  "AppKit")]
		public static NSString ResultDescriptionOverride {
			get {
				if (_ResultDescriptionOverride is null)
					_ResultDescriptionOverride = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySearchResultDescriptionOverrideKey")!;
				return _ResultDescriptionOverride;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ResultElement;
		/// <summary>Represents the value associated with the constant 'NSAccessibilitySearchResultElementKey'.</summary>
		[Field ("NSAccessibilitySearchResultElementKey",  "AppKit")]
		public static NSString ResultElement {
			get {
				if (_ResultElement is null)
					_ResultElement = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySearchResultElementKey")!;
				return _ResultElement;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ResultLoader;
		/// <summary>Represents the value associated with the constant 'NSAccessibilitySearchResultLoaderKey'.</summary>
		[Field ("NSAccessibilitySearchResultLoaderKey",  "AppKit")]
		public static NSString ResultLoader {
			get {
				if (_ResultLoader is null)
					_ResultLoader = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySearchResultLoaderKey")!;
				return _ResultLoader;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ResultRange;
		/// <summary>Represents the value associated with the constant 'NSAccessibilitySearchResultRangeKey'.</summary>
		[Field ("NSAccessibilitySearchResultRangeKey",  "AppKit")]
		public static NSString ResultRange {
			get {
				if (_ResultRange is null)
					_ResultRange = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySearchResultRangeKey")!;
				return _ResultRange;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ResultsLimit;
		/// <summary>Represents the value associated with the constant 'NSAccessibilitySearchResultsLimitKey'.</summary>
		[Field ("NSAccessibilitySearchResultsLimitKey",  "AppKit")]
		public static NSString ResultsLimit {
			get {
				if (_ResultsLimit is null)
					_ResultsLimit = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySearchResultsLimitKey")!;
				return _ResultsLimit;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Text;
		/// <summary>Represents the value associated with the constant 'NSAccessibilitySearchTextKey'.</summary>
		[Field ("NSAccessibilitySearchTextKey",  "AppKit")]
		public static NSString Text {
			get {
				if (_Text is null)
					_Text = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySearchTextKey")!;
				return _Text;
			}
		}
	} /* class NSAccessibilityForSearchPredicateKey */
}
