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
	/// <summary>Defines string constants whose values define various interpersonal relationships.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public unsafe static partial class CNLabelContactRelationKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Assistant;
		/// <summary>Professional assistant.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelContactRelationAssistant",  "Contacts")]
		public static NSString Assistant {
			get {
				if (_Assistant is null)
					_Assistant = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationAssistant")!;
				return _Assistant;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Aunt;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationAunt'.</summary>
		[Field ("CNLabelContactRelationAunt",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Aunt {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Aunt is null)
					_Aunt = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationAunt")!;
				return _Aunt;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuntFathersBrothersWife;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationAuntFathersBrothersWife'.</summary>
		[Field ("CNLabelContactRelationAuntFathersBrothersWife",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuntFathersBrothersWife {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuntFathersBrothersWife is null)
					_AuntFathersBrothersWife = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationAuntFathersBrothersWife")!;
				return _AuntFathersBrothersWife;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuntFathersElderBrothersWife;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationAuntFathersElderBrothersWife'.</summary>
		[Field ("CNLabelContactRelationAuntFathersElderBrothersWife",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuntFathersElderBrothersWife {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuntFathersElderBrothersWife is null)
					_AuntFathersElderBrothersWife = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationAuntFathersElderBrothersWife")!;
				return _AuntFathersElderBrothersWife;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuntFathersElderSister;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationAuntFathersElderSister'.</summary>
		[Field ("CNLabelContactRelationAuntFathersElderSister",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuntFathersElderSister {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuntFathersElderSister is null)
					_AuntFathersElderSister = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationAuntFathersElderSister")!;
				return _AuntFathersElderSister;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuntFathersSister;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationAuntFathersSister'.</summary>
		[Field ("CNLabelContactRelationAuntFathersSister",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuntFathersSister {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuntFathersSister is null)
					_AuntFathersSister = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationAuntFathersSister")!;
				return _AuntFathersSister;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuntFathersYoungerBrothersWife;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationAuntFathersYoungerBrothersWife'.</summary>
		[Field ("CNLabelContactRelationAuntFathersYoungerBrothersWife",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuntFathersYoungerBrothersWife {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuntFathersYoungerBrothersWife is null)
					_AuntFathersYoungerBrothersWife = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationAuntFathersYoungerBrothersWife")!;
				return _AuntFathersYoungerBrothersWife;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuntFathersYoungerSister;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationAuntFathersYoungerSister'.</summary>
		[Field ("CNLabelContactRelationAuntFathersYoungerSister",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuntFathersYoungerSister {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuntFathersYoungerSister is null)
					_AuntFathersYoungerSister = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationAuntFathersYoungerSister")!;
				return _AuntFathersYoungerSister;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuntMothersBrothersWife;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationAuntMothersBrothersWife'.</summary>
		[Field ("CNLabelContactRelationAuntMothersBrothersWife",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuntMothersBrothersWife {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuntMothersBrothersWife is null)
					_AuntMothersBrothersWife = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationAuntMothersBrothersWife")!;
				return _AuntMothersBrothersWife;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuntMothersElderSister;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationAuntMothersElderSister'.</summary>
		[Field ("CNLabelContactRelationAuntMothersElderSister",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuntMothersElderSister {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuntMothersElderSister is null)
					_AuntMothersElderSister = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationAuntMothersElderSister")!;
				return _AuntMothersElderSister;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuntMothersSister;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationAuntMothersSister'.</summary>
		[Field ("CNLabelContactRelationAuntMothersSister",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuntMothersSister {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuntMothersSister is null)
					_AuntMothersSister = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationAuntMothersSister")!;
				return _AuntMothersSister;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuntMothersYoungerSister;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationAuntMothersYoungerSister'.</summary>
		[Field ("CNLabelContactRelationAuntMothersYoungerSister",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuntMothersYoungerSister {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuntMothersYoungerSister is null)
					_AuntMothersYoungerSister = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationAuntMothersYoungerSister")!;
				return _AuntMothersYoungerSister;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuntParentsElderSister;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationAuntParentsElderSister'.</summary>
		[Field ("CNLabelContactRelationAuntParentsElderSister",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuntParentsElderSister {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuntParentsElderSister is null)
					_AuntParentsElderSister = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationAuntParentsElderSister")!;
				return _AuntParentsElderSister;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuntParentsSister;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationAuntParentsSister'.</summary>
		[Field ("CNLabelContactRelationAuntParentsSister",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuntParentsSister {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuntParentsSister is null)
					_AuntParentsSister = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationAuntParentsSister")!;
				return _AuntParentsSister;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuntParentsYoungerSister;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationAuntParentsYoungerSister'.</summary>
		[Field ("CNLabelContactRelationAuntParentsYoungerSister",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuntParentsYoungerSister {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuntParentsYoungerSister is null)
					_AuntParentsYoungerSister = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationAuntParentsYoungerSister")!;
				return _AuntParentsYoungerSister;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Boyfriend;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationBoyfriend'.</summary>
		[Field ("CNLabelContactRelationBoyfriend",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Boyfriend {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Boyfriend is null)
					_Boyfriend = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationBoyfriend")!;
				return _Boyfriend;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Brother;
		/// <summary>Brother.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelContactRelationBrother",  "Contacts")]
		public static NSString Brother {
			get {
				if (_Brother is null)
					_Brother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationBrother")!;
				return _Brother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BrotherInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationBrotherInLaw'.</summary>
		[Field ("CNLabelContactRelationBrotherInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString BrotherInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_BrotherInLaw is null)
					_BrotherInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationBrotherInLaw")!;
				return _BrotherInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BrotherInLawElderSistersHusband;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationBrotherInLawElderSistersHusband'.</summary>
		[Field ("CNLabelContactRelationBrotherInLawElderSistersHusband",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString BrotherInLawElderSistersHusband {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_BrotherInLawElderSistersHusband is null)
					_BrotherInLawElderSistersHusband = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationBrotherInLawElderSistersHusband")!;
				return _BrotherInLawElderSistersHusband;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BrotherInLawHusbandsBrother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationBrotherInLawHusbandsBrother'.</summary>
		[Field ("CNLabelContactRelationBrotherInLawHusbandsBrother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString BrotherInLawHusbandsBrother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_BrotherInLawHusbandsBrother is null)
					_BrotherInLawHusbandsBrother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationBrotherInLawHusbandsBrother")!;
				return _BrotherInLawHusbandsBrother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BrotherInLawHusbandsSistersHusband;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationBrotherInLawHusbandsSistersHusband'.</summary>
		[Field ("CNLabelContactRelationBrotherInLawHusbandsSistersHusband",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString BrotherInLawHusbandsSistersHusband {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_BrotherInLawHusbandsSistersHusband is null)
					_BrotherInLawHusbandsSistersHusband = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationBrotherInLawHusbandsSistersHusband")!;
				return _BrotherInLawHusbandsSistersHusband;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BrotherInLawSistersHusband;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationBrotherInLawSistersHusband'.</summary>
		[Field ("CNLabelContactRelationBrotherInLawSistersHusband",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString BrotherInLawSistersHusband {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_BrotherInLawSistersHusband is null)
					_BrotherInLawSistersHusband = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationBrotherInLawSistersHusband")!;
				return _BrotherInLawSistersHusband;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BrotherInLawSpousesBrother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationBrotherInLawSpousesBrother'.</summary>
		[Field ("CNLabelContactRelationBrotherInLawSpousesBrother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString BrotherInLawSpousesBrother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_BrotherInLawSpousesBrother is null)
					_BrotherInLawSpousesBrother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationBrotherInLawSpousesBrother")!;
				return _BrotherInLawSpousesBrother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BrotherInLawWifesBrother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationBrotherInLawWifesBrother'.</summary>
		[Field ("CNLabelContactRelationBrotherInLawWifesBrother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString BrotherInLawWifesBrother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_BrotherInLawWifesBrother is null)
					_BrotherInLawWifesBrother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationBrotherInLawWifesBrother")!;
				return _BrotherInLawWifesBrother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BrotherInLawWifesSistersHusband;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationBrotherInLawWifesSistersHusband'.</summary>
		[Field ("CNLabelContactRelationBrotherInLawWifesSistersHusband",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString BrotherInLawWifesSistersHusband {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_BrotherInLawWifesSistersHusband is null)
					_BrotherInLawWifesSistersHusband = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationBrotherInLawWifesSistersHusband")!;
				return _BrotherInLawWifesSistersHusband;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BrotherInLawYoungerSistersHusband;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationBrotherInLawYoungerSistersHusband'.</summary>
		[Field ("CNLabelContactRelationBrotherInLawYoungerSistersHusband",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString BrotherInLawYoungerSistersHusband {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_BrotherInLawYoungerSistersHusband is null)
					_BrotherInLawYoungerSistersHusband = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationBrotherInLawYoungerSistersHusband")!;
				return _BrotherInLawYoungerSistersHusband;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Child;
		/// <summary>Child.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelContactRelationChild",  "Contacts")]
		public static NSString Child {
			get {
				if (_Child is null)
					_Child = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationChild")!;
				return _Child;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChildInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationChildInLaw'.</summary>
		[Field ("CNLabelContactRelationChildInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ChildInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ChildInLaw is null)
					_ChildInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationChildInLaw")!;
				return _ChildInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CoBrotherInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCoBrotherInLaw'.</summary>
		[Field ("CNLabelContactRelationCoBrotherInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CoBrotherInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CoBrotherInLaw is null)
					_CoBrotherInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCoBrotherInLaw")!;
				return _CoBrotherInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CoFatherInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCoFatherInLaw'.</summary>
		[Field ("CNLabelContactRelationCoFatherInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CoFatherInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CoFatherInLaw is null)
					_CoFatherInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCoFatherInLaw")!;
				return _CoFatherInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CoMotherInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCoMotherInLaw'.</summary>
		[Field ("CNLabelContactRelationCoMotherInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CoMotherInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CoMotherInLaw is null)
					_CoMotherInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCoMotherInLaw")!;
				return _CoMotherInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CoParentInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCoParentInLaw'.</summary>
		[Field ("CNLabelContactRelationCoParentInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CoParentInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CoParentInLaw is null)
					_CoParentInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCoParentInLaw")!;
				return _CoParentInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CoSiblingInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCoSiblingInLaw'.</summary>
		[Field ("CNLabelContactRelationCoSiblingInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CoSiblingInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CoSiblingInLaw is null)
					_CoSiblingInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCoSiblingInLaw")!;
				return _CoSiblingInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CoSisterInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCoSisterInLaw'.</summary>
		[Field ("CNLabelContactRelationCoSisterInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CoSisterInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CoSisterInLaw is null)
					_CoSisterInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCoSisterInLaw")!;
				return _CoSisterInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Colleague;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationColleague'.</summary>
		[Field ("CNLabelContactRelationColleague",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Colleague {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Colleague is null)
					_Colleague = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationColleague")!;
				return _Colleague;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Cousin;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCousin'.</summary>
		[Field ("CNLabelContactRelationCousin",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Cousin {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Cousin is null)
					_Cousin = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCousin")!;
				return _Cousin;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CousinFathersBrothersDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCousinFathersBrothersDaughter'.</summary>
		[Field ("CNLabelContactRelationCousinFathersBrothersDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CousinFathersBrothersDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CousinFathersBrothersDaughter is null)
					_CousinFathersBrothersDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCousinFathersBrothersDaughter")!;
				return _CousinFathersBrothersDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CousinFathersBrothersSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCousinFathersBrothersSon'.</summary>
		[Field ("CNLabelContactRelationCousinFathersBrothersSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CousinFathersBrothersSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CousinFathersBrothersSon is null)
					_CousinFathersBrothersSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCousinFathersBrothersSon")!;
				return _CousinFathersBrothersSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CousinFathersSistersDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCousinFathersSistersDaughter'.</summary>
		[Field ("CNLabelContactRelationCousinFathersSistersDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CousinFathersSistersDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CousinFathersSistersDaughter is null)
					_CousinFathersSistersDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCousinFathersSistersDaughter")!;
				return _CousinFathersSistersDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CousinFathersSistersSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCousinFathersSistersSon'.</summary>
		[Field ("CNLabelContactRelationCousinFathersSistersSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CousinFathersSistersSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CousinFathersSistersSon is null)
					_CousinFathersSistersSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCousinFathersSistersSon")!;
				return _CousinFathersSistersSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CousinGrandparentsSiblingsChild;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCousinGrandparentsSiblingsChild'.</summary>
		[Field ("CNLabelContactRelationCousinGrandparentsSiblingsChild",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CousinGrandparentsSiblingsChild {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CousinGrandparentsSiblingsChild is null)
					_CousinGrandparentsSiblingsChild = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCousinGrandparentsSiblingsChild")!;
				return _CousinGrandparentsSiblingsChild;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CousinGrandparentsSiblingsDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCousinGrandparentsSiblingsDaughter'.</summary>
		[Field ("CNLabelContactRelationCousinGrandparentsSiblingsDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CousinGrandparentsSiblingsDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CousinGrandparentsSiblingsDaughter is null)
					_CousinGrandparentsSiblingsDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCousinGrandparentsSiblingsDaughter")!;
				return _CousinGrandparentsSiblingsDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CousinGrandparentsSiblingsSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCousinGrandparentsSiblingsSon'.</summary>
		[Field ("CNLabelContactRelationCousinGrandparentsSiblingsSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CousinGrandparentsSiblingsSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CousinGrandparentsSiblingsSon is null)
					_CousinGrandparentsSiblingsSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCousinGrandparentsSiblingsSon")!;
				return _CousinGrandparentsSiblingsSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CousinMothersBrothersDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCousinMothersBrothersDaughter'.</summary>
		[Field ("CNLabelContactRelationCousinMothersBrothersDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CousinMothersBrothersDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CousinMothersBrothersDaughter is null)
					_CousinMothersBrothersDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCousinMothersBrothersDaughter")!;
				return _CousinMothersBrothersDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CousinMothersBrothersSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCousinMothersBrothersSon'.</summary>
		[Field ("CNLabelContactRelationCousinMothersBrothersSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CousinMothersBrothersSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CousinMothersBrothersSon is null)
					_CousinMothersBrothersSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCousinMothersBrothersSon")!;
				return _CousinMothersBrothersSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CousinMothersSistersDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCousinMothersSistersDaughter'.</summary>
		[Field ("CNLabelContactRelationCousinMothersSistersDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CousinMothersSistersDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CousinMothersSistersDaughter is null)
					_CousinMothersSistersDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCousinMothersSistersDaughter")!;
				return _CousinMothersSistersDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CousinMothersSistersSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCousinMothersSistersSon'.</summary>
		[Field ("CNLabelContactRelationCousinMothersSistersSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CousinMothersSistersSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CousinMothersSistersSon is null)
					_CousinMothersSistersSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCousinMothersSistersSon")!;
				return _CousinMothersSistersSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CousinOrSiblingsChild;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCousinOrSiblingsChild'.</summary>
		[Field ("CNLabelContactRelationCousinOrSiblingsChild",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CousinOrSiblingsChild {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CousinOrSiblingsChild is null)
					_CousinOrSiblingsChild = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCousinOrSiblingsChild")!;
				return _CousinOrSiblingsChild;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CousinParentsSiblingsChild;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCousinParentsSiblingsChild'.</summary>
		[Field ("CNLabelContactRelationCousinParentsSiblingsChild",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CousinParentsSiblingsChild {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CousinParentsSiblingsChild is null)
					_CousinParentsSiblingsChild = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCousinParentsSiblingsChild")!;
				return _CousinParentsSiblingsChild;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CousinParentsSiblingsDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCousinParentsSiblingsDaughter'.</summary>
		[Field ("CNLabelContactRelationCousinParentsSiblingsDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CousinParentsSiblingsDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CousinParentsSiblingsDaughter is null)
					_CousinParentsSiblingsDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCousinParentsSiblingsDaughter")!;
				return _CousinParentsSiblingsDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CousinParentsSiblingsSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationCousinParentsSiblingsSon'.</summary>
		[Field ("CNLabelContactRelationCousinParentsSiblingsSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CousinParentsSiblingsSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CousinParentsSiblingsSon is null)
					_CousinParentsSiblingsSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationCousinParentsSiblingsSon")!;
				return _CousinParentsSiblingsSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Daughter;
		/// <summary>Daughter.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelContactRelationDaughter",  "Contacts")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString Daughter {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Daughter is null)
					_Daughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationDaughter")!;
				return _Daughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DaughterInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationDaughterInLaw'.</summary>
		[Field ("CNLabelContactRelationDaughterInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString DaughterInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DaughterInLaw is null)
					_DaughterInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationDaughterInLaw")!;
				return _DaughterInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DaughterInLawOrSisterInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationDaughterInLawOrSisterInLaw'.</summary>
		[Field ("CNLabelContactRelationDaughterInLawOrSisterInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString DaughterInLawOrSisterInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DaughterInLawOrSisterInLaw is null)
					_DaughterInLawOrSisterInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationDaughterInLawOrSisterInLaw")!;
				return _DaughterInLawOrSisterInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DaughterInLawOrStepdaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationDaughterInLawOrStepdaughter'.</summary>
		[Field ("CNLabelContactRelationDaughterInLawOrStepdaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString DaughterInLawOrStepdaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DaughterInLawOrStepdaughter is null)
					_DaughterInLawOrStepdaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationDaughterInLawOrStepdaughter")!;
				return _DaughterInLawOrStepdaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElderBrother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationElderBrother'.</summary>
		[Field ("CNLabelContactRelationElderBrother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ElderBrother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ElderBrother is null)
					_ElderBrother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationElderBrother")!;
				return _ElderBrother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElderBrotherInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationElderBrotherInLaw'.</summary>
		[Field ("CNLabelContactRelationElderBrotherInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ElderBrotherInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ElderBrotherInLaw is null)
					_ElderBrotherInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationElderBrotherInLaw")!;
				return _ElderBrotherInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElderCousin;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationElderCousin'.</summary>
		[Field ("CNLabelContactRelationElderCousin",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ElderCousin {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ElderCousin is null)
					_ElderCousin = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationElderCousin")!;
				return _ElderCousin;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElderCousinFathersBrothersDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationElderCousinFathersBrothersDaughter'.</summary>
		[Field ("CNLabelContactRelationElderCousinFathersBrothersDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ElderCousinFathersBrothersDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ElderCousinFathersBrothersDaughter is null)
					_ElderCousinFathersBrothersDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationElderCousinFathersBrothersDaughter")!;
				return _ElderCousinFathersBrothersDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElderCousinFathersBrothersSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationElderCousinFathersBrothersSon'.</summary>
		[Field ("CNLabelContactRelationElderCousinFathersBrothersSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ElderCousinFathersBrothersSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ElderCousinFathersBrothersSon is null)
					_ElderCousinFathersBrothersSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationElderCousinFathersBrothersSon")!;
				return _ElderCousinFathersBrothersSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElderCousinFathersSistersDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationElderCousinFathersSistersDaughter'.</summary>
		[Field ("CNLabelContactRelationElderCousinFathersSistersDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ElderCousinFathersSistersDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ElderCousinFathersSistersDaughter is null)
					_ElderCousinFathersSistersDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationElderCousinFathersSistersDaughter")!;
				return _ElderCousinFathersSistersDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElderCousinFathersSistersSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationElderCousinFathersSistersSon'.</summary>
		[Field ("CNLabelContactRelationElderCousinFathersSistersSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ElderCousinFathersSistersSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ElderCousinFathersSistersSon is null)
					_ElderCousinFathersSistersSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationElderCousinFathersSistersSon")!;
				return _ElderCousinFathersSistersSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElderCousinMothersBrothersDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationElderCousinMothersBrothersDaughter'.</summary>
		[Field ("CNLabelContactRelationElderCousinMothersBrothersDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ElderCousinMothersBrothersDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ElderCousinMothersBrothersDaughter is null)
					_ElderCousinMothersBrothersDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationElderCousinMothersBrothersDaughter")!;
				return _ElderCousinMothersBrothersDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElderCousinMothersBrothersSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationElderCousinMothersBrothersSon'.</summary>
		[Field ("CNLabelContactRelationElderCousinMothersBrothersSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ElderCousinMothersBrothersSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ElderCousinMothersBrothersSon is null)
					_ElderCousinMothersBrothersSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationElderCousinMothersBrothersSon")!;
				return _ElderCousinMothersBrothersSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElderCousinMothersSiblingsDaughterOrFathersSistersDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationElderCousinMothersSiblingsDaughterOrFathersSistersDaughter'.</summary>
		[Field ("CNLabelContactRelationElderCousinMothersSiblingsDaughterOrFathersSistersDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ElderCousinMothersSiblingsDaughterOrFathersSistersDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ElderCousinMothersSiblingsDaughterOrFathersSistersDaughter is null)
					_ElderCousinMothersSiblingsDaughterOrFathersSistersDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationElderCousinMothersSiblingsDaughterOrFathersSistersDaughter")!;
				return _ElderCousinMothersSiblingsDaughterOrFathersSistersDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElderCousinMothersSiblingsSonOrFathersSistersSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationElderCousinMothersSiblingsSonOrFathersSistersSon'.</summary>
		[Field ("CNLabelContactRelationElderCousinMothersSiblingsSonOrFathersSistersSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ElderCousinMothersSiblingsSonOrFathersSistersSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ElderCousinMothersSiblingsSonOrFathersSistersSon is null)
					_ElderCousinMothersSiblingsSonOrFathersSistersSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationElderCousinMothersSiblingsSonOrFathersSistersSon")!;
				return _ElderCousinMothersSiblingsSonOrFathersSistersSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElderCousinMothersSistersDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationElderCousinMothersSistersDaughter'.</summary>
		[Field ("CNLabelContactRelationElderCousinMothersSistersDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ElderCousinMothersSistersDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ElderCousinMothersSistersDaughter is null)
					_ElderCousinMothersSistersDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationElderCousinMothersSistersDaughter")!;
				return _ElderCousinMothersSistersDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElderCousinMothersSistersSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationElderCousinMothersSistersSon'.</summary>
		[Field ("CNLabelContactRelationElderCousinMothersSistersSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ElderCousinMothersSistersSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ElderCousinMothersSistersSon is null)
					_ElderCousinMothersSistersSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationElderCousinMothersSistersSon")!;
				return _ElderCousinMothersSistersSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElderCousinParentsSiblingsDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationElderCousinParentsSiblingsDaughter'.</summary>
		[Field ("CNLabelContactRelationElderCousinParentsSiblingsDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ElderCousinParentsSiblingsDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ElderCousinParentsSiblingsDaughter is null)
					_ElderCousinParentsSiblingsDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationElderCousinParentsSiblingsDaughter")!;
				return _ElderCousinParentsSiblingsDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElderCousinParentsSiblingsSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationElderCousinParentsSiblingsSon'.</summary>
		[Field ("CNLabelContactRelationElderCousinParentsSiblingsSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ElderCousinParentsSiblingsSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ElderCousinParentsSiblingsSon is null)
					_ElderCousinParentsSiblingsSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationElderCousinParentsSiblingsSon")!;
				return _ElderCousinParentsSiblingsSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElderSibling;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationElderSibling'.</summary>
		[Field ("CNLabelContactRelationElderSibling",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ElderSibling {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ElderSibling is null)
					_ElderSibling = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationElderSibling")!;
				return _ElderSibling;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElderSiblingInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationElderSiblingInLaw'.</summary>
		[Field ("CNLabelContactRelationElderSiblingInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ElderSiblingInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ElderSiblingInLaw is null)
					_ElderSiblingInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationElderSiblingInLaw")!;
				return _ElderSiblingInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElderSister;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationElderSister'.</summary>
		[Field ("CNLabelContactRelationElderSister",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ElderSister {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ElderSister is null)
					_ElderSister = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationElderSister")!;
				return _ElderSister;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElderSisterInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationElderSisterInLaw'.</summary>
		[Field ("CNLabelContactRelationElderSisterInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ElderSisterInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ElderSisterInLaw is null)
					_ElderSisterInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationElderSisterInLaw")!;
				return _ElderSisterInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EldestBrother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationEldestBrother'.</summary>
		[Field ("CNLabelContactRelationEldestBrother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString EldestBrother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_EldestBrother is null)
					_EldestBrother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationEldestBrother")!;
				return _EldestBrother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EldestSister;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationEldestSister'.</summary>
		[Field ("CNLabelContactRelationEldestSister",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString EldestSister {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_EldestSister is null)
					_EldestSister = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationEldestSister")!;
				return _EldestSister;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Father;
		/// <summary>Father.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelContactRelationFather",  "Contacts")]
		public static NSString Father {
			get {
				if (_Father is null)
					_Father = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationFather")!;
				return _Father;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FatherInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationFatherInLaw'.</summary>
		[Field ("CNLabelContactRelationFatherInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString FatherInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FatherInLaw is null)
					_FatherInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationFatherInLaw")!;
				return _FatherInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FatherInLawHusbandsFather;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationFatherInLawHusbandsFather'.</summary>
		[Field ("CNLabelContactRelationFatherInLawHusbandsFather",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString FatherInLawHusbandsFather {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FatherInLawHusbandsFather is null)
					_FatherInLawHusbandsFather = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationFatherInLawHusbandsFather")!;
				return _FatherInLawHusbandsFather;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FatherInLawOrStepfather;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationFatherInLawOrStepfather'.</summary>
		[Field ("CNLabelContactRelationFatherInLawOrStepfather",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString FatherInLawOrStepfather {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FatherInLawOrStepfather is null)
					_FatherInLawOrStepfather = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationFatherInLawOrStepfather")!;
				return _FatherInLawOrStepfather;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FatherInLawWifesFather;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationFatherInLawWifesFather'.</summary>
		[Field ("CNLabelContactRelationFatherInLawWifesFather",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString FatherInLawWifesFather {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FatherInLawWifesFather is null)
					_FatherInLawWifesFather = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationFatherInLawWifesFather")!;
				return _FatherInLawWifesFather;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FemaleCousin;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationFemaleCousin'.</summary>
		[Field ("CNLabelContactRelationFemaleCousin",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString FemaleCousin {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FemaleCousin is null)
					_FemaleCousin = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationFemaleCousin")!;
				return _FemaleCousin;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FemaleFriend;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationFemaleFriend'.</summary>
		[Field ("CNLabelContactRelationFemaleFriend",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString FemaleFriend {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FemaleFriend is null)
					_FemaleFriend = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationFemaleFriend")!;
				return _FemaleFriend;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FemalePartner;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationFemalePartner'.</summary>
		[Field ("CNLabelContactRelationFemalePartner",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString FemalePartner {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FemalePartner is null)
					_FemalePartner = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationFemalePartner")!;
				return _FemalePartner;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Friend;
		/// <summary>Just friends.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelContactRelationFriend",  "Contacts")]
		public static NSString Friend {
			get {
				if (_Friend is null)
					_Friend = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationFriend")!;
				return _Friend;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Girlfriend;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGirlfriend'.</summary>
		[Field ("CNLabelContactRelationGirlfriend",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Girlfriend {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Girlfriend is null)
					_Girlfriend = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGirlfriend")!;
				return _Girlfriend;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GirlfriendOrBoyfriend;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGirlfriendOrBoyfriend'.</summary>
		[Field ("CNLabelContactRelationGirlfriendOrBoyfriend",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GirlfriendOrBoyfriend {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GirlfriendOrBoyfriend is null)
					_GirlfriendOrBoyfriend = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGirlfriendOrBoyfriend")!;
				return _GirlfriendOrBoyfriend;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Grandaunt;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandaunt'.</summary>
		[Field ("CNLabelContactRelationGrandaunt",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Grandaunt {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Grandaunt is null)
					_Grandaunt = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandaunt")!;
				return _Grandaunt;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Grandchild;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandchild'.</summary>
		[Field ("CNLabelContactRelationGrandchild",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Grandchild {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Grandchild is null)
					_Grandchild = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandchild")!;
				return _Grandchild;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GrandchildOrSiblingsChild;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandchildOrSiblingsChild'.</summary>
		[Field ("CNLabelContactRelationGrandchildOrSiblingsChild",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GrandchildOrSiblingsChild {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GrandchildOrSiblingsChild is null)
					_GrandchildOrSiblingsChild = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandchildOrSiblingsChild")!;
				return _GrandchildOrSiblingsChild;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Granddaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGranddaughter'.</summary>
		[Field ("CNLabelContactRelationGranddaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Granddaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Granddaughter is null)
					_Granddaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGranddaughter")!;
				return _Granddaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GranddaughterDaughtersDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGranddaughterDaughtersDaughter'.</summary>
		[Field ("CNLabelContactRelationGranddaughterDaughtersDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GranddaughterDaughtersDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GranddaughterDaughtersDaughter is null)
					_GranddaughterDaughtersDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGranddaughterDaughtersDaughter")!;
				return _GranddaughterDaughtersDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GranddaughterOrNiece;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGranddaughterOrNiece'.</summary>
		[Field ("CNLabelContactRelationGranddaughterOrNiece",  "Contacts")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GranddaughterOrNiece {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GranddaughterOrNiece is null)
					_GranddaughterOrNiece = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGranddaughterOrNiece")!;
				return _GranddaughterOrNiece;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GranddaughterSonsDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGranddaughterSonsDaughter'.</summary>
		[Field ("CNLabelContactRelationGranddaughterSonsDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GranddaughterSonsDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GranddaughterSonsDaughter is null)
					_GranddaughterSonsDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGranddaughterSonsDaughter")!;
				return _GranddaughterSonsDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Grandfather;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandfather'.</summary>
		[Field ("CNLabelContactRelationGrandfather",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Grandfather {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Grandfather is null)
					_Grandfather = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandfather")!;
				return _Grandfather;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GrandfatherFathersFather;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandfatherFathersFather'.</summary>
		[Field ("CNLabelContactRelationGrandfatherFathersFather",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GrandfatherFathersFather {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GrandfatherFathersFather is null)
					_GrandfatherFathersFather = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandfatherFathersFather")!;
				return _GrandfatherFathersFather;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GrandfatherMothersFather;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandfatherMothersFather'.</summary>
		[Field ("CNLabelContactRelationGrandfatherMothersFather",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GrandfatherMothersFather {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GrandfatherMothersFather is null)
					_GrandfatherMothersFather = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandfatherMothersFather")!;
				return _GrandfatherMothersFather;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Grandmother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandmother'.</summary>
		[Field ("CNLabelContactRelationGrandmother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Grandmother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Grandmother is null)
					_Grandmother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandmother")!;
				return _Grandmother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GrandmotherFathersMother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandmotherFathersMother'.</summary>
		[Field ("CNLabelContactRelationGrandmotherFathersMother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GrandmotherFathersMother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GrandmotherFathersMother is null)
					_GrandmotherFathersMother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandmotherFathersMother")!;
				return _GrandmotherFathersMother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GrandmotherMothersMother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandmotherMothersMother'.</summary>
		[Field ("CNLabelContactRelationGrandmotherMothersMother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GrandmotherMothersMother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GrandmotherMothersMother is null)
					_GrandmotherMothersMother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandmotherMothersMother")!;
				return _GrandmotherMothersMother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Grandnephew;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandnephew'.</summary>
		[Field ("CNLabelContactRelationGrandnephew",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Grandnephew {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Grandnephew is null)
					_Grandnephew = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandnephew")!;
				return _Grandnephew;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GrandnephewBrothersGrandson;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandnephewBrothersGrandson'.</summary>
		[Field ("CNLabelContactRelationGrandnephewBrothersGrandson",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GrandnephewBrothersGrandson {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GrandnephewBrothersGrandson is null)
					_GrandnephewBrothersGrandson = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandnephewBrothersGrandson")!;
				return _GrandnephewBrothersGrandson;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GrandnephewSistersGrandson;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandnephewSistersGrandson'.</summary>
		[Field ("CNLabelContactRelationGrandnephewSistersGrandson",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GrandnephewSistersGrandson {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GrandnephewSistersGrandson is null)
					_GrandnephewSistersGrandson = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandnephewSistersGrandson")!;
				return _GrandnephewSistersGrandson;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Grandniece;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandniece'.</summary>
		[Field ("CNLabelContactRelationGrandniece",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Grandniece {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Grandniece is null)
					_Grandniece = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandniece")!;
				return _Grandniece;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GrandnieceBrothersGranddaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandnieceBrothersGranddaughter'.</summary>
		[Field ("CNLabelContactRelationGrandnieceBrothersGranddaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GrandnieceBrothersGranddaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GrandnieceBrothersGranddaughter is null)
					_GrandnieceBrothersGranddaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandnieceBrothersGranddaughter")!;
				return _GrandnieceBrothersGranddaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GrandnieceSistersGranddaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandnieceSistersGranddaughter'.</summary>
		[Field ("CNLabelContactRelationGrandnieceSistersGranddaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GrandnieceSistersGranddaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GrandnieceSistersGranddaughter is null)
					_GrandnieceSistersGranddaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandnieceSistersGranddaughter")!;
				return _GrandnieceSistersGranddaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Grandparent;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandparent'.</summary>
		[Field ("CNLabelContactRelationGrandparent",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Grandparent {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Grandparent is null)
					_Grandparent = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandparent")!;
				return _Grandparent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Grandson;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandson'.</summary>
		[Field ("CNLabelContactRelationGrandson",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Grandson {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Grandson is null)
					_Grandson = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandson")!;
				return _Grandson;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GrandsonDaughtersSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandsonDaughtersSon'.</summary>
		[Field ("CNLabelContactRelationGrandsonDaughtersSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GrandsonDaughtersSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GrandsonDaughtersSon is null)
					_GrandsonDaughtersSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandsonDaughtersSon")!;
				return _GrandsonDaughtersSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GrandsonOrNephew;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandsonOrNephew'.</summary>
		[Field ("CNLabelContactRelationGrandsonOrNephew",  "Contacts")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GrandsonOrNephew {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GrandsonOrNephew is null)
					_GrandsonOrNephew = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandsonOrNephew")!;
				return _GrandsonOrNephew;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GrandsonSonsSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGrandsonSonsSon'.</summary>
		[Field ("CNLabelContactRelationGrandsonSonsSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GrandsonSonsSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GrandsonSonsSon is null)
					_GrandsonSonsSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGrandsonSonsSon")!;
				return _GrandsonSonsSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Granduncle;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGranduncle'.</summary>
		[Field ("CNLabelContactRelationGranduncle",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Granduncle {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Granduncle is null)
					_Granduncle = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGranduncle")!;
				return _Granduncle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GreatGrandchild;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGreatGrandchild'.</summary>
		[Field ("CNLabelContactRelationGreatGrandchild",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GreatGrandchild {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GreatGrandchild is null)
					_GreatGrandchild = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGreatGrandchild")!;
				return _GreatGrandchild;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GreatGrandchildOrSiblingsGrandchild;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGreatGrandchildOrSiblingsGrandchild'.</summary>
		[Field ("CNLabelContactRelationGreatGrandchildOrSiblingsGrandchild",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GreatGrandchildOrSiblingsGrandchild {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GreatGrandchildOrSiblingsGrandchild is null)
					_GreatGrandchildOrSiblingsGrandchild = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGreatGrandchildOrSiblingsGrandchild")!;
				return _GreatGrandchildOrSiblingsGrandchild;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GreatGranddaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGreatGranddaughter'.</summary>
		[Field ("CNLabelContactRelationGreatGranddaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GreatGranddaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GreatGranddaughter is null)
					_GreatGranddaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGreatGranddaughter")!;
				return _GreatGranddaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GreatGrandfather;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGreatGrandfather'.</summary>
		[Field ("CNLabelContactRelationGreatGrandfather",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GreatGrandfather {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GreatGrandfather is null)
					_GreatGrandfather = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGreatGrandfather")!;
				return _GreatGrandfather;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GreatGrandmother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGreatGrandmother'.</summary>
		[Field ("CNLabelContactRelationGreatGrandmother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GreatGrandmother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GreatGrandmother is null)
					_GreatGrandmother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGreatGrandmother")!;
				return _GreatGrandmother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GreatGrandparent;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGreatGrandparent'.</summary>
		[Field ("CNLabelContactRelationGreatGrandparent",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GreatGrandparent {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GreatGrandparent is null)
					_GreatGrandparent = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGreatGrandparent")!;
				return _GreatGrandparent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GreatGrandson;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationGreatGrandson'.</summary>
		[Field ("CNLabelContactRelationGreatGrandson",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GreatGrandson {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GreatGrandson is null)
					_GreatGrandson = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationGreatGrandson")!;
				return _GreatGrandson;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Husband;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationHusband'.</summary>
		[Field ("CNLabelContactRelationHusband",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Husband {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Husband is null)
					_Husband = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationHusband")!;
				return _Husband;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaleCousin;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationMaleCousin'.</summary>
		[Field ("CNLabelContactRelationMaleCousin",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MaleCousin {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MaleCousin is null)
					_MaleCousin = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationMaleCousin")!;
				return _MaleCousin;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaleFriend;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationMaleFriend'.</summary>
		[Field ("CNLabelContactRelationMaleFriend",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MaleFriend {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MaleFriend is null)
					_MaleFriend = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationMaleFriend")!;
				return _MaleFriend;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MalePartner;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationMalePartner'.</summary>
		[Field ("CNLabelContactRelationMalePartner",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MalePartner {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MalePartner is null)
					_MalePartner = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationMalePartner")!;
				return _MalePartner;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Manager;
		/// <summary>Manager.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelContactRelationManager",  "Contacts")]
		public static NSString Manager {
			get {
				if (_Manager is null)
					_Manager = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationManager")!;
				return _Manager;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Mother;
		/// <summary>Mother.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelContactRelationMother",  "Contacts")]
		public static NSString Mother {
			get {
				if (_Mother is null)
					_Mother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationMother")!;
				return _Mother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MotherInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationMotherInLaw'.</summary>
		[Field ("CNLabelContactRelationMotherInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MotherInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MotherInLaw is null)
					_MotherInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationMotherInLaw")!;
				return _MotherInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MotherInLawHusbandsMother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationMotherInLawHusbandsMother'.</summary>
		[Field ("CNLabelContactRelationMotherInLawHusbandsMother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MotherInLawHusbandsMother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MotherInLawHusbandsMother is null)
					_MotherInLawHusbandsMother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationMotherInLawHusbandsMother")!;
				return _MotherInLawHusbandsMother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MotherInLawOrStepmother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationMotherInLawOrStepmother'.</summary>
		[Field ("CNLabelContactRelationMotherInLawOrStepmother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MotherInLawOrStepmother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MotherInLawOrStepmother is null)
					_MotherInLawOrStepmother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationMotherInLawOrStepmother")!;
				return _MotherInLawOrStepmother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MotherInLawWifesMother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationMotherInLawWifesMother'.</summary>
		[Field ("CNLabelContactRelationMotherInLawWifesMother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MotherInLawWifesMother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MotherInLawWifesMother is null)
					_MotherInLawWifesMother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationMotherInLawWifesMother")!;
				return _MotherInLawWifesMother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Nephew;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationNephew'.</summary>
		[Field ("CNLabelContactRelationNephew",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Nephew {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Nephew is null)
					_Nephew = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationNephew")!;
				return _Nephew;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NephewBrothersSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationNephewBrothersSon'.</summary>
		[Field ("CNLabelContactRelationNephewBrothersSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NephewBrothersSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NephewBrothersSon is null)
					_NephewBrothersSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationNephewBrothersSon")!;
				return _NephewBrothersSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NephewBrothersSonOrHusbandsSiblingsSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationNephewBrothersSonOrHusbandsSiblingsSon'.</summary>
		[Field ("CNLabelContactRelationNephewBrothersSonOrHusbandsSiblingsSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NephewBrothersSonOrHusbandsSiblingsSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NephewBrothersSonOrHusbandsSiblingsSon is null)
					_NephewBrothersSonOrHusbandsSiblingsSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationNephewBrothersSonOrHusbandsSiblingsSon")!;
				return _NephewBrothersSonOrHusbandsSiblingsSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NephewOrCousin;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationNephewOrCousin'.</summary>
		[Field ("CNLabelContactRelationNephewOrCousin",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NephewOrCousin {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NephewOrCousin is null)
					_NephewOrCousin = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationNephewOrCousin")!;
				return _NephewOrCousin;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NephewSistersSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationNephewSistersSon'.</summary>
		[Field ("CNLabelContactRelationNephewSistersSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NephewSistersSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NephewSistersSon is null)
					_NephewSistersSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationNephewSistersSon")!;
				return _NephewSistersSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NephewSistersSonOrWifesSiblingsSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationNephewSistersSonOrWifesSiblingsSon'.</summary>
		[Field ("CNLabelContactRelationNephewSistersSonOrWifesSiblingsSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NephewSistersSonOrWifesSiblingsSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NephewSistersSonOrWifesSiblingsSon is null)
					_NephewSistersSonOrWifesSiblingsSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationNephewSistersSonOrWifesSiblingsSon")!;
				return _NephewSistersSonOrWifesSiblingsSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Niece;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationNiece'.</summary>
		[Field ("CNLabelContactRelationNiece",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Niece {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Niece is null)
					_Niece = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationNiece")!;
				return _Niece;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NieceBrothersDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationNieceBrothersDaughter'.</summary>
		[Field ("CNLabelContactRelationNieceBrothersDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NieceBrothersDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NieceBrothersDaughter is null)
					_NieceBrothersDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationNieceBrothersDaughter")!;
				return _NieceBrothersDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NieceBrothersDaughterOrHusbandsSiblingsDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationNieceBrothersDaughterOrHusbandsSiblingsDaughter'.</summary>
		[Field ("CNLabelContactRelationNieceBrothersDaughterOrHusbandsSiblingsDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NieceBrothersDaughterOrHusbandsSiblingsDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NieceBrothersDaughterOrHusbandsSiblingsDaughter is null)
					_NieceBrothersDaughterOrHusbandsSiblingsDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationNieceBrothersDaughterOrHusbandsSiblingsDaughter")!;
				return _NieceBrothersDaughterOrHusbandsSiblingsDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NieceOrCousin;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationNieceOrCousin'.</summary>
		[Field ("CNLabelContactRelationNieceOrCousin",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NieceOrCousin {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NieceOrCousin is null)
					_NieceOrCousin = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationNieceOrCousin")!;
				return _NieceOrCousin;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NieceSistersDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationNieceSistersDaughter'.</summary>
		[Field ("CNLabelContactRelationNieceSistersDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NieceSistersDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NieceSistersDaughter is null)
					_NieceSistersDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationNieceSistersDaughter")!;
				return _NieceSistersDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NieceSistersDaughterOrWifesSiblingsDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationNieceSistersDaughterOrWifesSiblingsDaughter'.</summary>
		[Field ("CNLabelContactRelationNieceSistersDaughterOrWifesSiblingsDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NieceSistersDaughterOrWifesSiblingsDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NieceSistersDaughterOrWifesSiblingsDaughter is null)
					_NieceSistersDaughterOrWifesSiblingsDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationNieceSistersDaughterOrWifesSiblingsDaughter")!;
				return _NieceSistersDaughterOrWifesSiblingsDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Parent;
		/// <summary>Parent.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelContactRelationParent",  "Contacts")]
		public static NSString Parent {
			get {
				if (_Parent is null)
					_Parent = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationParent")!;
				return _Parent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParentInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationParentInLaw'.</summary>
		[Field ("CNLabelContactRelationParentInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ParentInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ParentInLaw is null)
					_ParentInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationParentInLaw")!;
				return _ParentInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParentsElderSibling;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationParentsElderSibling'.</summary>
		[Field ("CNLabelContactRelationParentsElderSibling",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ParentsElderSibling {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ParentsElderSibling is null)
					_ParentsElderSibling = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationParentsElderSibling")!;
				return _ParentsElderSibling;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParentsSibling;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationParentsSibling'.</summary>
		[Field ("CNLabelContactRelationParentsSibling",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ParentsSibling {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ParentsSibling is null)
					_ParentsSibling = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationParentsSibling")!;
				return _ParentsSibling;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParentsSiblingFathersElderSibling;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationParentsSiblingFathersElderSibling'.</summary>
		[Field ("CNLabelContactRelationParentsSiblingFathersElderSibling",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ParentsSiblingFathersElderSibling {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ParentsSiblingFathersElderSibling is null)
					_ParentsSiblingFathersElderSibling = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationParentsSiblingFathersElderSibling")!;
				return _ParentsSiblingFathersElderSibling;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParentsSiblingFathersSibling;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationParentsSiblingFathersSibling'.</summary>
		[Field ("CNLabelContactRelationParentsSiblingFathersSibling",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ParentsSiblingFathersSibling {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ParentsSiblingFathersSibling is null)
					_ParentsSiblingFathersSibling = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationParentsSiblingFathersSibling")!;
				return _ParentsSiblingFathersSibling;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParentsSiblingFathersYoungerSibling;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationParentsSiblingFathersYoungerSibling'.</summary>
		[Field ("CNLabelContactRelationParentsSiblingFathersYoungerSibling",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ParentsSiblingFathersYoungerSibling {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ParentsSiblingFathersYoungerSibling is null)
					_ParentsSiblingFathersYoungerSibling = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationParentsSiblingFathersYoungerSibling")!;
				return _ParentsSiblingFathersYoungerSibling;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParentsSiblingMothersElderSibling;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationParentsSiblingMothersElderSibling'.</summary>
		[Field ("CNLabelContactRelationParentsSiblingMothersElderSibling",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ParentsSiblingMothersElderSibling {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ParentsSiblingMothersElderSibling is null)
					_ParentsSiblingMothersElderSibling = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationParentsSiblingMothersElderSibling")!;
				return _ParentsSiblingMothersElderSibling;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParentsSiblingMothersSibling;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationParentsSiblingMothersSibling'.</summary>
		[Field ("CNLabelContactRelationParentsSiblingMothersSibling",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ParentsSiblingMothersSibling {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ParentsSiblingMothersSibling is null)
					_ParentsSiblingMothersSibling = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationParentsSiblingMothersSibling")!;
				return _ParentsSiblingMothersSibling;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParentsSiblingMothersYoungerSibling;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationParentsSiblingMothersYoungerSibling'.</summary>
		[Field ("CNLabelContactRelationParentsSiblingMothersYoungerSibling",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ParentsSiblingMothersYoungerSibling {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ParentsSiblingMothersYoungerSibling is null)
					_ParentsSiblingMothersYoungerSibling = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationParentsSiblingMothersYoungerSibling")!;
				return _ParentsSiblingMothersYoungerSibling;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParentsYoungerSibling;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationParentsYoungerSibling'.</summary>
		[Field ("CNLabelContactRelationParentsYoungerSibling",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ParentsYoungerSibling {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ParentsYoungerSibling is null)
					_ParentsYoungerSibling = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationParentsYoungerSibling")!;
				return _ParentsYoungerSibling;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Partner;
		/// <summary>Partner. (see also <see cref="P:Contacts.CNLabelContactRelationKey.Spouse" />)</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelContactRelationPartner",  "Contacts")]
		public static NSString Partner {
			get {
				if (_Partner is null)
					_Partner = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationPartner")!;
				return _Partner;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Sibling;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationSibling'.</summary>
		[Field ("CNLabelContactRelationSibling",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Sibling {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Sibling is null)
					_Sibling = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationSibling")!;
				return _Sibling;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SiblingInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationSiblingInLaw'.</summary>
		[Field ("CNLabelContactRelationSiblingInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SiblingInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SiblingInLaw is null)
					_SiblingInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationSiblingInLaw")!;
				return _SiblingInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SiblingsChild;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationSiblingsChild'.</summary>
		[Field ("CNLabelContactRelationSiblingsChild",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SiblingsChild {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SiblingsChild is null)
					_SiblingsChild = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationSiblingsChild")!;
				return _SiblingsChild;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Sister;
		/// <summary>Sister.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelContactRelationSister",  "Contacts")]
		public static NSString Sister {
			get {
				if (_Sister is null)
					_Sister = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationSister")!;
				return _Sister;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SisterInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationSisterInLaw'.</summary>
		[Field ("CNLabelContactRelationSisterInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SisterInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SisterInLaw is null)
					_SisterInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationSisterInLaw")!;
				return _SisterInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SisterInLawBrothersWife;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationSisterInLawBrothersWife'.</summary>
		[Field ("CNLabelContactRelationSisterInLawBrothersWife",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SisterInLawBrothersWife {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SisterInLawBrothersWife is null)
					_SisterInLawBrothersWife = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationSisterInLawBrothersWife")!;
				return _SisterInLawBrothersWife;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SisterInLawElderBrothersWife;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationSisterInLawElderBrothersWife'.</summary>
		[Field ("CNLabelContactRelationSisterInLawElderBrothersWife",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SisterInLawElderBrothersWife {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SisterInLawElderBrothersWife is null)
					_SisterInLawElderBrothersWife = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationSisterInLawElderBrothersWife")!;
				return _SisterInLawElderBrothersWife;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SisterInLawHusbandsBrothersWife;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationSisterInLawHusbandsBrothersWife'.</summary>
		[Field ("CNLabelContactRelationSisterInLawHusbandsBrothersWife",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SisterInLawHusbandsBrothersWife {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SisterInLawHusbandsBrothersWife is null)
					_SisterInLawHusbandsBrothersWife = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationSisterInLawHusbandsBrothersWife")!;
				return _SisterInLawHusbandsBrothersWife;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SisterInLawHusbandsSister;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationSisterInLawHusbandsSister'.</summary>
		[Field ("CNLabelContactRelationSisterInLawHusbandsSister",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SisterInLawHusbandsSister {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SisterInLawHusbandsSister is null)
					_SisterInLawHusbandsSister = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationSisterInLawHusbandsSister")!;
				return _SisterInLawHusbandsSister;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SisterInLawSpousesSister;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationSisterInLawSpousesSister'.</summary>
		[Field ("CNLabelContactRelationSisterInLawSpousesSister",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SisterInLawSpousesSister {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SisterInLawSpousesSister is null)
					_SisterInLawSpousesSister = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationSisterInLawSpousesSister")!;
				return _SisterInLawSpousesSister;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SisterInLawWifesBrothersWife;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationSisterInLawWifesBrothersWife'.</summary>
		[Field ("CNLabelContactRelationSisterInLawWifesBrothersWife",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SisterInLawWifesBrothersWife {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SisterInLawWifesBrothersWife is null)
					_SisterInLawWifesBrothersWife = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationSisterInLawWifesBrothersWife")!;
				return _SisterInLawWifesBrothersWife;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SisterInLawWifesSister;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationSisterInLawWifesSister'.</summary>
		[Field ("CNLabelContactRelationSisterInLawWifesSister",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SisterInLawWifesSister {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SisterInLawWifesSister is null)
					_SisterInLawWifesSister = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationSisterInLawWifesSister")!;
				return _SisterInLawWifesSister;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SisterInLawYoungerBrothersWife;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationSisterInLawYoungerBrothersWife'.</summary>
		[Field ("CNLabelContactRelationSisterInLawYoungerBrothersWife",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SisterInLawYoungerBrothersWife {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SisterInLawYoungerBrothersWife is null)
					_SisterInLawYoungerBrothersWife = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationSisterInLawYoungerBrothersWife")!;
				return _SisterInLawYoungerBrothersWife;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Son;
		/// <summary>Son.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelContactRelationSon",  "Contacts")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString Son {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Son is null)
					_Son = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationSon")!;
				return _Son;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SonInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationSonInLaw'.</summary>
		[Field ("CNLabelContactRelationSonInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SonInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SonInLaw is null)
					_SonInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationSonInLaw")!;
				return _SonInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SonInLawOrBrotherInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationSonInLawOrBrotherInLaw'.</summary>
		[Field ("CNLabelContactRelationSonInLawOrBrotherInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SonInLawOrBrotherInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SonInLawOrBrotherInLaw is null)
					_SonInLawOrBrotherInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationSonInLawOrBrotherInLaw")!;
				return _SonInLawOrBrotherInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SonInLawOrStepson;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationSonInLawOrStepson'.</summary>
		[Field ("CNLabelContactRelationSonInLawOrStepson",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SonInLawOrStepson {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SonInLawOrStepson is null)
					_SonInLawOrStepson = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationSonInLawOrStepson")!;
				return _SonInLawOrStepson;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Spouse;
		/// <summary>Spouse.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelContactRelationSpouse",  "Contacts")]
		public static NSString Spouse {
			get {
				if (_Spouse is null)
					_Spouse = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationSpouse")!;
				return _Spouse;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Stepbrother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationStepbrother'.</summary>
		[Field ("CNLabelContactRelationStepbrother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Stepbrother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Stepbrother is null)
					_Stepbrother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationStepbrother")!;
				return _Stepbrother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Stepchild;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationStepchild'.</summary>
		[Field ("CNLabelContactRelationStepchild",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Stepchild {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Stepchild is null)
					_Stepchild = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationStepchild")!;
				return _Stepchild;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Stepdaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationStepdaughter'.</summary>
		[Field ("CNLabelContactRelationStepdaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Stepdaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Stepdaughter is null)
					_Stepdaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationStepdaughter")!;
				return _Stepdaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Stepfather;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationStepfather'.</summary>
		[Field ("CNLabelContactRelationStepfather",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Stepfather {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Stepfather is null)
					_Stepfather = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationStepfather")!;
				return _Stepfather;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Stepmother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationStepmother'.</summary>
		[Field ("CNLabelContactRelationStepmother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Stepmother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Stepmother is null)
					_Stepmother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationStepmother")!;
				return _Stepmother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Stepparent;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationStepparent'.</summary>
		[Field ("CNLabelContactRelationStepparent",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Stepparent {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Stepparent is null)
					_Stepparent = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationStepparent")!;
				return _Stepparent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Stepsister;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationStepsister'.</summary>
		[Field ("CNLabelContactRelationStepsister",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Stepsister {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Stepsister is null)
					_Stepsister = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationStepsister")!;
				return _Stepsister;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Stepson;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationStepson'.</summary>
		[Field ("CNLabelContactRelationStepson",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Stepson {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Stepson is null)
					_Stepson = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationStepson")!;
				return _Stepson;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Teacher;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationTeacher'.</summary>
		[Field ("CNLabelContactRelationTeacher",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Teacher {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Teacher is null)
					_Teacher = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationTeacher")!;
				return _Teacher;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Uncle;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationUncle'.</summary>
		[Field ("CNLabelContactRelationUncle",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Uncle {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Uncle is null)
					_Uncle = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationUncle")!;
				return _Uncle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UncleFathersBrother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationUncleFathersBrother'.</summary>
		[Field ("CNLabelContactRelationUncleFathersBrother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString UncleFathersBrother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UncleFathersBrother is null)
					_UncleFathersBrother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationUncleFathersBrother")!;
				return _UncleFathersBrother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UncleFathersElderBrother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationUncleFathersElderBrother'.</summary>
		[Field ("CNLabelContactRelationUncleFathersElderBrother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString UncleFathersElderBrother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UncleFathersElderBrother is null)
					_UncleFathersElderBrother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationUncleFathersElderBrother")!;
				return _UncleFathersElderBrother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UncleFathersElderSistersHusband;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationUncleFathersElderSistersHusband'.</summary>
		[Field ("CNLabelContactRelationUncleFathersElderSistersHusband",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString UncleFathersElderSistersHusband {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UncleFathersElderSistersHusband is null)
					_UncleFathersElderSistersHusband = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationUncleFathersElderSistersHusband")!;
				return _UncleFathersElderSistersHusband;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UncleFathersSistersHusband;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationUncleFathersSistersHusband'.</summary>
		[Field ("CNLabelContactRelationUncleFathersSistersHusband",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString UncleFathersSistersHusband {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UncleFathersSistersHusband is null)
					_UncleFathersSistersHusband = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationUncleFathersSistersHusband")!;
				return _UncleFathersSistersHusband;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UncleFathersYoungerBrother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationUncleFathersYoungerBrother'.</summary>
		[Field ("CNLabelContactRelationUncleFathersYoungerBrother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString UncleFathersYoungerBrother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UncleFathersYoungerBrother is null)
					_UncleFathersYoungerBrother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationUncleFathersYoungerBrother")!;
				return _UncleFathersYoungerBrother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UncleFathersYoungerSistersHusband;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationUncleFathersYoungerSistersHusband'.</summary>
		[Field ("CNLabelContactRelationUncleFathersYoungerSistersHusband",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString UncleFathersYoungerSistersHusband {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UncleFathersYoungerSistersHusband is null)
					_UncleFathersYoungerSistersHusband = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationUncleFathersYoungerSistersHusband")!;
				return _UncleFathersYoungerSistersHusband;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UncleMothersBrother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationUncleMothersBrother'.</summary>
		[Field ("CNLabelContactRelationUncleMothersBrother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString UncleMothersBrother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UncleMothersBrother is null)
					_UncleMothersBrother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationUncleMothersBrother")!;
				return _UncleMothersBrother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UncleMothersElderBrother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationUncleMothersElderBrother'.</summary>
		[Field ("CNLabelContactRelationUncleMothersElderBrother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString UncleMothersElderBrother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UncleMothersElderBrother is null)
					_UncleMothersElderBrother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationUncleMothersElderBrother")!;
				return _UncleMothersElderBrother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UncleMothersSistersHusband;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationUncleMothersSistersHusband'.</summary>
		[Field ("CNLabelContactRelationUncleMothersSistersHusband",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString UncleMothersSistersHusband {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UncleMothersSistersHusband is null)
					_UncleMothersSistersHusband = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationUncleMothersSistersHusband")!;
				return _UncleMothersSistersHusband;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UncleMothersYoungerBrother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationUncleMothersYoungerBrother'.</summary>
		[Field ("CNLabelContactRelationUncleMothersYoungerBrother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString UncleMothersYoungerBrother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UncleMothersYoungerBrother is null)
					_UncleMothersYoungerBrother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationUncleMothersYoungerBrother")!;
				return _UncleMothersYoungerBrother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UncleParentsBrother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationUncleParentsBrother'.</summary>
		[Field ("CNLabelContactRelationUncleParentsBrother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString UncleParentsBrother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UncleParentsBrother is null)
					_UncleParentsBrother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationUncleParentsBrother")!;
				return _UncleParentsBrother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UncleParentsElderBrother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationUncleParentsElderBrother'.</summary>
		[Field ("CNLabelContactRelationUncleParentsElderBrother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString UncleParentsElderBrother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UncleParentsElderBrother is null)
					_UncleParentsElderBrother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationUncleParentsElderBrother")!;
				return _UncleParentsElderBrother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UncleParentsYoungerBrother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationUncleParentsYoungerBrother'.</summary>
		[Field ("CNLabelContactRelationUncleParentsYoungerBrother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString UncleParentsYoungerBrother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UncleParentsYoungerBrother is null)
					_UncleParentsYoungerBrother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationUncleParentsYoungerBrother")!;
				return _UncleParentsYoungerBrother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Wife;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationWife'.</summary>
		[Field ("CNLabelContactRelationWife",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Wife {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Wife is null)
					_Wife = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationWife")!;
				return _Wife;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungerBrother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungerBrother'.</summary>
		[Field ("CNLabelContactRelationYoungerBrother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungerBrother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungerBrother is null)
					_YoungerBrother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungerBrother")!;
				return _YoungerBrother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungerBrotherInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungerBrotherInLaw'.</summary>
		[Field ("CNLabelContactRelationYoungerBrotherInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungerBrotherInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungerBrotherInLaw is null)
					_YoungerBrotherInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungerBrotherInLaw")!;
				return _YoungerBrotherInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungerCousin;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungerCousin'.</summary>
		[Field ("CNLabelContactRelationYoungerCousin",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungerCousin {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungerCousin is null)
					_YoungerCousin = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungerCousin")!;
				return _YoungerCousin;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungerCousinFathersBrothersDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungerCousinFathersBrothersDaughter'.</summary>
		[Field ("CNLabelContactRelationYoungerCousinFathersBrothersDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungerCousinFathersBrothersDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungerCousinFathersBrothersDaughter is null)
					_YoungerCousinFathersBrothersDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungerCousinFathersBrothersDaughter")!;
				return _YoungerCousinFathersBrothersDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungerCousinFathersBrothersSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungerCousinFathersBrothersSon'.</summary>
		[Field ("CNLabelContactRelationYoungerCousinFathersBrothersSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungerCousinFathersBrothersSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungerCousinFathersBrothersSon is null)
					_YoungerCousinFathersBrothersSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungerCousinFathersBrothersSon")!;
				return _YoungerCousinFathersBrothersSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungerCousinFathersSistersDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungerCousinFathersSistersDaughter'.</summary>
		[Field ("CNLabelContactRelationYoungerCousinFathersSistersDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungerCousinFathersSistersDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungerCousinFathersSistersDaughter is null)
					_YoungerCousinFathersSistersDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungerCousinFathersSistersDaughter")!;
				return _YoungerCousinFathersSistersDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungerCousinFathersSistersSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungerCousinFathersSistersSon'.</summary>
		[Field ("CNLabelContactRelationYoungerCousinFathersSistersSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungerCousinFathersSistersSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungerCousinFathersSistersSon is null)
					_YoungerCousinFathersSistersSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungerCousinFathersSistersSon")!;
				return _YoungerCousinFathersSistersSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungerCousinMothersBrothersDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungerCousinMothersBrothersDaughter'.</summary>
		[Field ("CNLabelContactRelationYoungerCousinMothersBrothersDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungerCousinMothersBrothersDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungerCousinMothersBrothersDaughter is null)
					_YoungerCousinMothersBrothersDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungerCousinMothersBrothersDaughter")!;
				return _YoungerCousinMothersBrothersDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungerCousinMothersBrothersSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungerCousinMothersBrothersSon'.</summary>
		[Field ("CNLabelContactRelationYoungerCousinMothersBrothersSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungerCousinMothersBrothersSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungerCousinMothersBrothersSon is null)
					_YoungerCousinMothersBrothersSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungerCousinMothersBrothersSon")!;
				return _YoungerCousinMothersBrothersSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungerCousinMothersSiblingsDaughterOrFathersSistersDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungerCousinMothersSiblingsDaughterOrFathersSistersDaughter'.</summary>
		[Field ("CNLabelContactRelationYoungerCousinMothersSiblingsDaughterOrFathersSistersDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungerCousinMothersSiblingsDaughterOrFathersSistersDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungerCousinMothersSiblingsDaughterOrFathersSistersDaughter is null)
					_YoungerCousinMothersSiblingsDaughterOrFathersSistersDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungerCousinMothersSiblingsDaughterOrFathersSistersDaughter")!;
				return _YoungerCousinMothersSiblingsDaughterOrFathersSistersDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungerCousinMothersSiblingsSonOrFathersSistersSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungerCousinMothersSiblingsSonOrFathersSistersSon'.</summary>
		[Field ("CNLabelContactRelationYoungerCousinMothersSiblingsSonOrFathersSistersSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungerCousinMothersSiblingsSonOrFathersSistersSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungerCousinMothersSiblingsSonOrFathersSistersSon is null)
					_YoungerCousinMothersSiblingsSonOrFathersSistersSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungerCousinMothersSiblingsSonOrFathersSistersSon")!;
				return _YoungerCousinMothersSiblingsSonOrFathersSistersSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungerCousinMothersSistersDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungerCousinMothersSistersDaughter'.</summary>
		[Field ("CNLabelContactRelationYoungerCousinMothersSistersDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungerCousinMothersSistersDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungerCousinMothersSistersDaughter is null)
					_YoungerCousinMothersSistersDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungerCousinMothersSistersDaughter")!;
				return _YoungerCousinMothersSistersDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungerCousinMothersSistersSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungerCousinMothersSistersSon'.</summary>
		[Field ("CNLabelContactRelationYoungerCousinMothersSistersSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungerCousinMothersSistersSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungerCousinMothersSistersSon is null)
					_YoungerCousinMothersSistersSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungerCousinMothersSistersSon")!;
				return _YoungerCousinMothersSistersSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungerCousinParentsSiblingsDaughter;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungerCousinParentsSiblingsDaughter'.</summary>
		[Field ("CNLabelContactRelationYoungerCousinParentsSiblingsDaughter",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungerCousinParentsSiblingsDaughter {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungerCousinParentsSiblingsDaughter is null)
					_YoungerCousinParentsSiblingsDaughter = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungerCousinParentsSiblingsDaughter")!;
				return _YoungerCousinParentsSiblingsDaughter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungerCousinParentsSiblingsSon;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungerCousinParentsSiblingsSon'.</summary>
		[Field ("CNLabelContactRelationYoungerCousinParentsSiblingsSon",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungerCousinParentsSiblingsSon {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungerCousinParentsSiblingsSon is null)
					_YoungerCousinParentsSiblingsSon = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungerCousinParentsSiblingsSon")!;
				return _YoungerCousinParentsSiblingsSon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungerSibling;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungerSibling'.</summary>
		[Field ("CNLabelContactRelationYoungerSibling",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungerSibling {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungerSibling is null)
					_YoungerSibling = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungerSibling")!;
				return _YoungerSibling;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungerSiblingInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungerSiblingInLaw'.</summary>
		[Field ("CNLabelContactRelationYoungerSiblingInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungerSiblingInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungerSiblingInLaw is null)
					_YoungerSiblingInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungerSiblingInLaw")!;
				return _YoungerSiblingInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungerSister;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungerSister'.</summary>
		[Field ("CNLabelContactRelationYoungerSister",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungerSister {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungerSister is null)
					_YoungerSister = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungerSister")!;
				return _YoungerSister;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungerSisterInLaw;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungerSisterInLaw'.</summary>
		[Field ("CNLabelContactRelationYoungerSisterInLaw",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungerSisterInLaw {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungerSisterInLaw is null)
					_YoungerSisterInLaw = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungerSisterInLaw")!;
				return _YoungerSisterInLaw;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungestBrother;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungestBrother'.</summary>
		[Field ("CNLabelContactRelationYoungestBrother",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungestBrother {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungestBrother is null)
					_YoungestBrother = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungestBrother")!;
				return _YoungestBrother;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YoungestSister;
		/// <summary>Represents the value associated with the constant 'CNLabelContactRelationYoungestSister'.</summary>
		[Field ("CNLabelContactRelationYoungestSister",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString YoungestSister {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_YoungestSister is null)
					_YoungestSister = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelContactRelationYoungestSister")!;
				return _YoungestSister;
			}
		}
	} /* class CNLabelContactRelationKey */
}
