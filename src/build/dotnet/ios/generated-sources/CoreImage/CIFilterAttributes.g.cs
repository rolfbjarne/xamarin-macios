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
namespace CoreImage {
	/// <summary>Constants used for CIFilter's attributes</summary>
	public unsafe static partial class CIFilterAttributes  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Available_Mac;
		/// <summary>Represents the value associated with the constant kCIAttributeFilterAvailable_Mac</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIAttributeFilterAvailable_Mac",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Available_Mac {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Available_Mac is null)
					_Available_Mac = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeFilterAvailable_Mac")!;
				return _Available_Mac;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Available_iOS;
		/// <summary>Represents the value associated with the constant kCIAttributeFilterAvailable_iOS</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIAttributeFilterAvailable_iOS",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Available_iOS {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Available_iOS is null)
					_Available_iOS = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeFilterAvailable_iOS")!;
				return _Available_iOS;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Class;
		/// <summary>Represents the value associated with the constant kCIAttributeClass</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeClass",  "CoreImage")]
		public static NSString Class {
			get {
				if (_Class is null)
					_Class = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeClass")!;
				return _Class;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Default;
		/// <summary>Represents the value associated with the constant kCIAttributeDefault</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeDefault",  "CoreImage")]
		public static NSString Default {
			get {
				if (_Default is null)
					_Default = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeDefault")!;
				return _Default;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Description;
		/// <summary>Represents the value associated with the constant kCIAttributeDescription</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIAttributeDescription",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Description {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Description is null)
					_Description = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeDescription")!;
				return _Description;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisplayName;
		/// <summary>Represents the value associated with the constant kCIAttributeDisplayName</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeDisplayName",  "CoreImage")]
		public static NSString DisplayName {
			get {
				if (_DisplayName is null)
					_DisplayName = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeDisplayName")!;
				return _DisplayName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FilterCategories;
		/// <summary>Represents the value associated with the constant kCIAttributeFilterCategories</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeFilterCategories",  "CoreImage")]
		public static NSString FilterCategories {
			get {
				if (_FilterCategories is null)
					_FilterCategories = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeFilterCategories")!;
				return _FilterCategories;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FilterDisplayName;
		/// <summary>Represents the value associated with the constant kCIAttributeFilterDisplayName</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeFilterDisplayName",  "CoreImage")]
		public static NSString FilterDisplayName {
			get {
				if (_FilterDisplayName is null)
					_FilterDisplayName = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeFilterDisplayName")!;
				return _FilterDisplayName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FilterName;
		/// <summary>Represents the value associated with the constant kCIAttributeFilterName</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeFilterName",  "CoreImage")]
		public static NSString FilterName {
			get {
				if (_FilterName is null)
					_FilterName = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeFilterName")!;
				return _FilterName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Identity;
		/// <summary>Represents the value associated with the constant kCIAttributeIdentity</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeIdentity",  "CoreImage")]
		public static NSString Identity {
			get {
				if (_Identity is null)
					_Identity = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeIdentity")!;
				return _Identity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Max;
		/// <summary>Represents the value associated with the constant kCIAttributeMax</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeMax",  "CoreImage")]
		public static NSString Max {
			get {
				if (_Max is null)
					_Max = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeMax")!;
				return _Max;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Min;
		/// <summary>Represents the value associated with the constant kCIAttributeMin</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeMin",  "CoreImage")]
		public static NSString Min {
			get {
				if (_Min is null)
					_Min = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeMin")!;
				return _Min;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Name;
		/// <summary>Represents the value associated with the constant kCIAttributeName</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeName",  "CoreImage")]
		public static NSString Name {
			get {
				if (_Name is null)
					_Name = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeName")!;
				return _Name;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReferenceDocumentation;
		/// <summary>Represents the value associated with the constant kCIAttributeReferenceDocumentation</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIAttributeReferenceDocumentation",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ReferenceDocumentation {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ReferenceDocumentation is null)
					_ReferenceDocumentation = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeReferenceDocumentation")!;
				return _ReferenceDocumentation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SliderMax;
		/// <summary>Represents the value associated with the constant kCIAttributeSliderMax</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeSliderMax",  "CoreImage")]
		public static NSString SliderMax {
			get {
				if (_SliderMax is null)
					_SliderMax = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeSliderMax")!;
				return _SliderMax;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SliderMin;
		/// <summary>Represents the value associated with the constant kCIAttributeSliderMin</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeSliderMin",  "CoreImage")]
		public static NSString SliderMin {
			get {
				if (_SliderMin is null)
					_SliderMin = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeSliderMin")!;
				return _SliderMin;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Type;
		/// <summary>Represents the value associated with the constant kCIAttributeType</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeType",  "CoreImage")]
		public static NSString Type {
			get {
				if (_Type is null)
					_Type = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeType")!;
				return _Type;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeAngle;
		/// <summary>Represents the value associated with the constant kCIAttributeTypeAngle</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeTypeAngle",  "CoreImage")]
		public static NSString TypeAngle {
			get {
				if (_TypeAngle is null)
					_TypeAngle = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeTypeAngle")!;
				return _TypeAngle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeBoolean;
		/// <summary>Represents the value associated with the constant kCIAttributeTypeBoolean</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeTypeBoolean",  "CoreImage")]
		public static NSString TypeBoolean {
			get {
				if (_TypeBoolean is null)
					_TypeBoolean = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeTypeBoolean")!;
				return _TypeBoolean;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeColor;
		/// <summary>Represents the value associated with the constant kCIAttributeTypeColor</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIAttributeTypeColor",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TypeColor {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_TypeColor is null)
					_TypeColor = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeTypeColor")!;
				return _TypeColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeCount;
		/// <summary>Represents the value associated with the constant kCIAttributeTypeCount</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeTypeCount",  "CoreImage")]
		public static NSString TypeCount {
			get {
				if (_TypeCount is null)
					_TypeCount = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeTypeCount")!;
				return _TypeCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeDistance;
		/// <summary>Represents the value associated with the constant kCIAttributeTypeDistance</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeTypeDistance",  "CoreImage")]
		public static NSString TypeDistance {
			get {
				if (_TypeDistance is null)
					_TypeDistance = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeTypeDistance")!;
				return _TypeDistance;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeGradient;
		/// <summary>Represents the value associated with the constant kCIAttributeTypeGradient</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIAttributeTypeGradient",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TypeGradient {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_TypeGradient is null)
					_TypeGradient = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeTypeGradient")!;
				return _TypeGradient;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeImage;
		/// <summary>Represents the value associated with the constant kCIAttributeTypeImage</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeTypeImage",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TypeImage {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_TypeImage is null)
					_TypeImage = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeTypeImage")!;
				return _TypeImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeInteger;
		/// <summary>Represents the value associated with the constant kCIAttributeTypeInteger</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeTypeInteger",  "CoreImage")]
		public static NSString TypeInteger {
			get {
				if (_TypeInteger is null)
					_TypeInteger = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeTypeInteger")!;
				return _TypeInteger;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeOffset;
		/// <summary>Represents the value associated with the constant kCIAttributeTypeOffset</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeTypeOffset",  "CoreImage")]
		public static NSString TypeOffset {
			get {
				if (_TypeOffset is null)
					_TypeOffset = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeTypeOffset")!;
				return _TypeOffset;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeOpaqueColor;
		/// <summary>Represents the value associated with the constant kCIAttributeTypeOpaqueColor</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIAttributeTypeOpaqueColor",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TypeOpaqueColor {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_TypeOpaqueColor is null)
					_TypeOpaqueColor = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeTypeOpaqueColor")!;
				return _TypeOpaqueColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypePosition;
		/// <summary>Represents the value associated with the constant kCIAttributeTypePosition</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeTypePosition",  "CoreImage")]
		public static NSString TypePosition {
			get {
				if (_TypePosition is null)
					_TypePosition = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeTypePosition")!;
				return _TypePosition;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypePosition3;
		/// <summary>Represents the value associated with the constant kCIAttributeTypePosition3</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeTypePosition3",  "CoreImage")]
		public static NSString TypePosition3 {
			get {
				if (_TypePosition3 is null)
					_TypePosition3 = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeTypePosition3")!;
				return _TypePosition3;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeRectangle;
		/// <summary>Represents the value associated with the constant kCIAttributeTypeRectangle</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeTypeRectangle",  "CoreImage")]
		public static NSString TypeRectangle {
			get {
				if (_TypeRectangle is null)
					_TypeRectangle = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeTypeRectangle")!;
				return _TypeRectangle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeScalar;
		/// <summary>Represents the value associated with the constant kCIAttributeTypeScalar</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeTypeScalar",  "CoreImage")]
		public static NSString TypeScalar {
			get {
				if (_TypeScalar is null)
					_TypeScalar = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeTypeScalar")!;
				return _TypeScalar;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeTime;
		/// <summary>Represents the value associated with the constant kCIAttributeTypeTime</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeTypeTime",  "CoreImage")]
		public static NSString TypeTime {
			get {
				if (_TypeTime is null)
					_TypeTime = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeTypeTime")!;
				return _TypeTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeTransform;
		/// <summary>Represents the value associated with the constant kCIAttributeTypeTransform</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCIAttributeTypeTransform",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TypeTransform {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_TypeTransform is null)
					_TypeTransform = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIAttributeTypeTransform")!;
				return _TypeTransform;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UIParameterSet;
		/// <summary>Represents the value associated with the constant kCIUIParameterSet</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIUIParameterSet",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString UIParameterSet {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_UIParameterSet is null)
					_UIParameterSet = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIUIParameterSet")!;
				return _UIParameterSet;
			}
		}
	} /* class CIFilterAttributes */
}
