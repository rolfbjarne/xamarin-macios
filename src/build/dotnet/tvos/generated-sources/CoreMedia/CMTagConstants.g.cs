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
namespace CoreMedia {
	[SupportedOSPlatform ("maccatalyst17.0")]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	internal unsafe partial class CMTagConstants  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CategoryKey;
		/// <summary>Represents the value associated with the constant 'kCMTagCategoryKey'.</summary>
		[Field ("kCMTagCategoryKey",  "CoreMedia")]
		public static NSString CategoryKey {
			get {
				if (_CategoryKey is null)
					_CategoryKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMTagCategoryKey")!;
				return _CategoryKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DataTypeKey;
		/// <summary>Represents the value associated with the constant 'kCMTagDataTypeKey'.</summary>
		[Field ("kCMTagDataTypeKey",  "CoreMedia")]
		public static NSString DataTypeKey {
			get {
				if (_DataTypeKey is null)
					_DataTypeKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMTagDataTypeKey")!;
				return _DataTypeKey;
			}
		}
		/// <summary>Represents the value associated with the constant 'kCMTagInvalid'.</summary>
		[Field ("kCMTagInvalid",  "CoreMedia")]
		public static CMTag Invalid {
			get {
				return Dlfcn.GetStruct<CoreMedia.CMTag> (Libraries.CoreMedia.Handle, "kCMTagInvalid");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCMTagMediaSubTypeMebx'.</summary>
		[Field ("kCMTagMediaSubTypeMebx",  "CoreMedia")]
		public static CMTag MediaSubTypeMebx {
			get {
				return Dlfcn.GetStruct<CoreMedia.CMTag> (Libraries.CoreMedia.Handle, "kCMTagMediaSubTypeMebx");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCMTagMediaTypeAudio'.</summary>
		[Field ("kCMTagMediaTypeAudio",  "CoreMedia")]
		public static CMTag MediaTypeAudio {
			get {
				return Dlfcn.GetStruct<CoreMedia.CMTag> (Libraries.CoreMedia.Handle, "kCMTagMediaTypeAudio");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCMTagMediaTypeMetadata'.</summary>
		[Field ("kCMTagMediaTypeMetadata",  "CoreMedia")]
		public static CMTag MediaTypeMetadata {
			get {
				return Dlfcn.GetStruct<CoreMedia.CMTag> (Libraries.CoreMedia.Handle, "kCMTagMediaTypeMetadata");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCMTagMediaTypeVideo'.</summary>
		[Field ("kCMTagMediaTypeVideo",  "CoreMedia")]
		public static CMTag MediaTypeVideo {
			get {
				return Dlfcn.GetStruct<CoreMedia.CMTag> (Libraries.CoreMedia.Handle, "kCMTagMediaTypeVideo");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCMTagPackingTypeNone'.</summary>
		[Field ("kCMTagPackingTypeNone",  "CoreMedia")]
		public static CMTag PackingTypeNone {
			get {
				return Dlfcn.GetStruct<CoreMedia.CMTag> (Libraries.CoreMedia.Handle, "kCMTagPackingTypeNone");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCMTagPackingTypeOverUnder'.</summary>
		[Field ("kCMTagPackingTypeOverUnder",  "CoreMedia")]
		public static CMTag PackingTypeOverUnder {
			get {
				return Dlfcn.GetStruct<CoreMedia.CMTag> (Libraries.CoreMedia.Handle, "kCMTagPackingTypeOverUnder");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCMTagPackingTypeSideBySide'.</summary>
		[Field ("kCMTagPackingTypeSideBySide",  "CoreMedia")]
		public static CMTag PackingTypeSideBySide {
			get {
				return Dlfcn.GetStruct<CoreMedia.CMTag> (Libraries.CoreMedia.Handle, "kCMTagPackingTypeSideBySide");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCMTagProjectionTypeEquirectangular'.</summary>
		[Field ("kCMTagProjectionTypeEquirectangular",  "CoreMedia")]
		public static CMTag ProjectionTypeEquirectangular {
			get {
				return Dlfcn.GetStruct<CoreMedia.CMTag> (Libraries.CoreMedia.Handle, "kCMTagProjectionTypeEquirectangular");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCMTagProjectionTypeFisheye'.</summary>
		[Field ("kCMTagProjectionTypeFisheye",  "CoreMedia")]
		public static CMTag ProjectionTypeFisheye {
			get {
				return Dlfcn.GetStruct<CoreMedia.CMTag> (Libraries.CoreMedia.Handle, "kCMTagProjectionTypeFisheye");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCMTagProjectionTypeHalfEquirectangular'.</summary>
		[Field ("kCMTagProjectionTypeHalfEquirectangular",  "CoreMedia")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		public static CMTag ProjectionTypeHalfEquirectangular {
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			[SupportedOSPlatform ("macos15.0")]
			get {
				return Dlfcn.GetStruct<CoreMedia.CMTag> (Libraries.CoreMedia.Handle, "kCMTagProjectionTypeHalfEquirectangular");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCMTagProjectionTypeParametricImmersive'.</summary>
		[Field ("kCMTagProjectionTypeParametricImmersive",  "CoreMedia")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static CMTag ProjectionTypeParametricImmersive {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				return Dlfcn.GetStruct<CoreMedia.CMTag> (Libraries.CoreMedia.Handle, "kCMTagProjectionTypeParametricImmersive");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCMTagProjectionTypeRectangular'.</summary>
		[Field ("kCMTagProjectionTypeRectangular",  "CoreMedia")]
		public static CMTag ProjectionTypeRectangular {
			get {
				return Dlfcn.GetStruct<CoreMedia.CMTag> (Libraries.CoreMedia.Handle, "kCMTagProjectionTypeRectangular");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCMTagStereoInterpretationOrderReversed'.</summary>
		[Field ("kCMTagStereoInterpretationOrderReversed",  "CoreMedia")]
		public static CMTag StereoInterpretationOrderReversed {
			get {
				return Dlfcn.GetStruct<CoreMedia.CMTag> (Libraries.CoreMedia.Handle, "kCMTagStereoInterpretationOrderReversed");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCMTagStereoLeftAndRightEye'.</summary>
		[Field ("kCMTagStereoLeftAndRightEye",  "CoreMedia")]
		public static CMTag StereoLeftAndRightEye {
			get {
				return Dlfcn.GetStruct<CoreMedia.CMTag> (Libraries.CoreMedia.Handle, "kCMTagStereoLeftAndRightEye");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCMTagStereoLeftEye'.</summary>
		[Field ("kCMTagStereoLeftEye",  "CoreMedia")]
		public static CMTag StereoLeftEye {
			get {
				return Dlfcn.GetStruct<CoreMedia.CMTag> (Libraries.CoreMedia.Handle, "kCMTagStereoLeftEye");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCMTagStereoNone'.</summary>
		[Field ("kCMTagStereoNone",  "CoreMedia")]
		public static CMTag StereoNone {
			get {
				return Dlfcn.GetStruct<CoreMedia.CMTag> (Libraries.CoreMedia.Handle, "kCMTagStereoNone");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCMTagStereoRightEye'.</summary>
		[Field ("kCMTagStereoRightEye",  "CoreMedia")]
		public static CMTag StereoRightEye {
			get {
				return Dlfcn.GetStruct<CoreMedia.CMTag> (Libraries.CoreMedia.Handle, "kCMTagStereoRightEye");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ValueKey;
		/// <summary>Represents the value associated with the constant 'kCMTagValueKey'.</summary>
		[Field ("kCMTagValueKey",  "CoreMedia")]
		public static NSString ValueKey {
			get {
				if (_ValueKey is null)
					_ValueKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMTagValueKey")!;
				return _ValueKey;
			}
		}
	} /* class CMTagConstants */
}
