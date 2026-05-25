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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreText {
	internal unsafe partial class CTFontNameKeyId  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Copyright;
		/// <summary>Represents the value associated with the constant 'kCTFontCopyrightNameKey'.</summary>
		[Field ("kCTFontCopyrightNameKey",  "CoreText")]
		public static NSString Copyright {
			get {
				if (_Copyright is null)
					_Copyright = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontCopyrightNameKey")!;
				return _Copyright;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Description;
		/// <summary>Represents the value associated with the constant 'kCTFontDescriptionNameKey'.</summary>
		[Field ("kCTFontDescriptionNameKey",  "CoreText")]
		public static NSString Description {
			get {
				if (_Description is null)
					_Description = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontDescriptionNameKey")!;
				return _Description;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Designer;
		/// <summary>Represents the value associated with the constant 'kCTFontDesignerNameKey'.</summary>
		[Field ("kCTFontDesignerNameKey",  "CoreText")]
		public static NSString Designer {
			get {
				if (_Designer is null)
					_Designer = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontDesignerNameKey")!;
				return _Designer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DesignerUrl;
		/// <summary>Represents the value associated with the constant 'kCTFontDesignerURLNameKey'.</summary>
		[Field ("kCTFontDesignerURLNameKey",  "CoreText")]
		public static NSString DesignerUrl {
			get {
				if (_DesignerUrl is null)
					_DesignerUrl = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontDesignerURLNameKey")!;
				return _DesignerUrl;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Family;
		/// <summary>Represents the value associated with the constant 'kCTFontFamilyNameKey'.</summary>
		[Field ("kCTFontFamilyNameKey",  "CoreText")]
		public static NSString Family {
			get {
				if (_Family is null)
					_Family = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontFamilyNameKey")!;
				return _Family;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Full;
		/// <summary>Represents the value associated with the constant 'kCTFontFullNameKey'.</summary>
		[Field ("kCTFontFullNameKey",  "CoreText")]
		public static NSString Full {
			get {
				if (_Full is null)
					_Full = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontFullNameKey")!;
				return _Full;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _License;
		/// <summary>Represents the value associated with the constant 'kCTFontLicenseNameKey'.</summary>
		[Field ("kCTFontLicenseNameKey",  "CoreText")]
		public static NSString License {
			get {
				if (_License is null)
					_License = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontLicenseNameKey")!;
				return _License;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LicenseUrl;
		/// <summary>Represents the value associated with the constant 'kCTFontLicenseURLNameKey'.</summary>
		[Field ("kCTFontLicenseURLNameKey",  "CoreText")]
		public static NSString LicenseUrl {
			get {
				if (_LicenseUrl is null)
					_LicenseUrl = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontLicenseURLNameKey")!;
				return _LicenseUrl;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Manufacturer;
		/// <summary>Represents the value associated with the constant 'kCTFontManufacturerNameKey'.</summary>
		[Field ("kCTFontManufacturerNameKey",  "CoreText")]
		public static NSString Manufacturer {
			get {
				if (_Manufacturer is null)
					_Manufacturer = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontManufacturerNameKey")!;
				return _Manufacturer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PostScript;
		/// <summary>Represents the value associated with the constant 'kCTFontPostScriptNameKey'.</summary>
		[Field ("kCTFontPostScriptNameKey",  "CoreText")]
		public static NSString PostScript {
			get {
				if (_PostScript is null)
					_PostScript = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontPostScriptNameKey")!;
				return _PostScript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PostscriptCid;
		/// <summary>Represents the value associated with the constant 'kCTFontPostScriptCIDNameKey'.</summary>
		[Field ("kCTFontPostScriptCIDNameKey",  "CoreText")]
		public static NSString PostscriptCid {
			get {
				if (_PostscriptCid is null)
					_PostscriptCid = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontPostScriptCIDNameKey")!;
				return _PostscriptCid;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SampleText;
		/// <summary>Represents the value associated with the constant 'kCTFontSampleTextNameKey'.</summary>
		[Field ("kCTFontSampleTextNameKey",  "CoreText")]
		public static NSString SampleText {
			get {
				if (_SampleText is null)
					_SampleText = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontSampleTextNameKey")!;
				return _SampleText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Style;
		/// <summary>Represents the value associated with the constant 'kCTFontStyleNameKey'.</summary>
		[Field ("kCTFontStyleNameKey",  "CoreText")]
		public static NSString Style {
			get {
				if (_Style is null)
					_Style = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontStyleNameKey")!;
				return _Style;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SubFamily;
		/// <summary>Represents the value associated with the constant 'kCTFontSubFamilyNameKey'.</summary>
		[Field ("kCTFontSubFamilyNameKey",  "CoreText")]
		public static NSString SubFamily {
			get {
				if (_SubFamily is null)
					_SubFamily = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontSubFamilyNameKey")!;
				return _SubFamily;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Trademark;
		/// <summary>Represents the value associated with the constant 'kCTFontTrademarkNameKey'.</summary>
		[Field ("kCTFontTrademarkNameKey",  "CoreText")]
		public static NSString Trademark {
			get {
				if (_Trademark is null)
					_Trademark = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontTrademarkNameKey")!;
				return _Trademark;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Unique;
		/// <summary>Represents the value associated with the constant 'kCTFontUniqueNameKey'.</summary>
		[Field ("kCTFontUniqueNameKey",  "CoreText")]
		public static NSString Unique {
			get {
				if (_Unique is null)
					_Unique = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontUniqueNameKey")!;
				return _Unique;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VendorUrl;
		/// <summary>Represents the value associated with the constant 'kCTFontVendorURLNameKey'.</summary>
		[Field ("kCTFontVendorURLNameKey",  "CoreText")]
		public static NSString VendorUrl {
			get {
				if (_VendorUrl is null)
					_VendorUrl = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontVendorURLNameKey")!;
				return _VendorUrl;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Version;
		/// <summary>Represents the value associated with the constant 'kCTFontVersionNameKey'.</summary>
		[Field ("kCTFontVersionNameKey",  "CoreText")]
		public static NSString Version {
			get {
				if (_Version is null)
					_Version = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontVersionNameKey")!;
				return _Version;
			}
		}
	} /* class CTFontNameKeyId */
}
