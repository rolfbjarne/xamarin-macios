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
namespace NaturalLanguage {
	/// <summary>Enumerates languages for which recognition is supported.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum NLLanguage : int {
		/// <summary>To be added.</summary>
		Unevaluated = 0,
		/// <summary>Indicates that the language was not recognized.</summary>
		Undetermined = 1,
		/// <summary>Indicates the Amharic language.</summary>
		Amharic = 2,
		/// <summary>Indicates the Arabic language.</summary>
		Arabic = 3,
		/// <summary>Indicates the Armenian language.</summary>
		Armenian = 4,
		/// <summary>Indicates the Bengali language.</summary>
		Bengali = 5,
		/// <summary>Indicates the Bulgarian language.</summary>
		Bulgarian = 6,
		/// <summary>Indicates the Burmese language.</summary>
		Burmese = 7,
		/// <summary>Indicates the Catalan language.</summary>
		Catalan = 8,
		/// <summary>Indicates the Cherokee language.</summary>
		Cherokee = 9,
		/// <summary>Indicates the Croatian language.</summary>
		Croatian = 10,
		/// <summary>Indicates the Czech language.</summary>
		Czech = 11,
		/// <summary>Indicates the Danish language.</summary>
		Danish = 12,
		/// <summary>Indicates the Dutch language.</summary>
		Dutch = 13,
		/// <summary>Indicates the English language.</summary>
		English = 14,
		/// <summary>Indicates the Finnish language.</summary>
		Finnish = 15,
		/// <summary>Indicates the French language.</summary>
		French = 16,
		/// <summary>Indicates the Georgian language.</summary>
		Georgian = 17,
		/// <summary>Indicates the German language.</summary>
		German = 18,
		/// <summary>Indicates the Greek language.</summary>
		Greek = 19,
		/// <summary>Indicates the Gujarati language.</summary>
		Gujarati = 20,
		/// <summary>Indicates the Hebrew language.</summary>
		Hebrew = 21,
		/// <summary>Indicates the Hindi language.</summary>
		Hindi = 22,
		/// <summary>Indicates the Hungarian language.</summary>
		Hungarian = 23,
		/// <summary>Indicates the Icelandic language.</summary>
		Icelandic = 24,
		/// <summary>Indicates the Indonesian language.</summary>
		Indonesian = 25,
		/// <summary>Indicates the Italian language.</summary>
		Italian = 26,
		/// <summary>Indicates the Japanese language.</summary>
		Japanese = 27,
		/// <summary>Indicates the Kannada language.</summary>
		Kannada = 28,
		/// <summary>Indicates the Khmer language.</summary>
		Khmer = 29,
		/// <summary>Indicates the Korean language.</summary>
		Korean = 30,
		/// <summary>Indicates the Lao language.</summary>
		Lao = 31,
		/// <summary>Indicates the Malay language.</summary>
		Malay = 32,
		/// <summary>Indicates the Malayalam language.</summary>
		Malayalam = 33,
		/// <summary>Indicates the Marathi language.</summary>
		Marathi = 34,
		/// <summary>Indicates the Mongolian language.</summary>
		Mongolian = 35,
		/// <summary>Indicates the Norwegian language.</summary>
		Norwegian = 36,
		/// <summary>Indicates the Oriya language.</summary>
		Oriya = 37,
		/// <summary>Indicates the Persian language.</summary>
		Persian = 38,
		/// <summary>Indicates the Polish language.</summary>
		Polish = 39,
		/// <summary>Indicates the Portuguese language.</summary>
		Portuguese = 40,
		/// <summary>Indicates the Punjabi language.</summary>
		Punjabi = 41,
		/// <summary>Indicates the Romanian language.</summary>
		Romanian = 42,
		/// <summary>Indicates the Russian language.</summary>
		Russian = 43,
		/// <summary>Indicates the Simplified Chinese language character set.</summary>
		SimplifiedChinese = 44,
		/// <summary>Indicates the Sinhalese language.</summary>
		Sinhalese = 45,
		/// <summary>Indicates the Slovak language.</summary>
		Slovak = 46,
		/// <summary>Indicates the Spanish language.</summary>
		Spanish = 47,
		/// <summary>Indicates the Swedish language.</summary>
		Swedish = 48,
		/// <summary>Indicates the Tamil language.</summary>
		Tamil = 49,
		/// <summary>Indicates the Telugu language.</summary>
		Telugu = 50,
		/// <summary>Indicates the Thai language.</summary>
		Thai = 51,
		/// <summary>Indicates the Tibetan language.</summary>
		Tibetan = 52,
		/// <summary>Indicates the Traditional Chinese character set.</summary>
		TraditionalChinese = 53,
		/// <summary>Indicates the Turkish language.</summary>
		Turkish = 54,
		/// <summary>Indicates the Ukrainian language.</summary>
		Ukrainian = 55,
		/// <summary>Indicates the Urdu language.</summary>
		Urdu = 56,
		/// <summary>Indicates the Vietnamese language.</summary>
		Vietnamese = 57,
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		Kazakh = 58,
	}
	/// <summary>Extension methods for the <see cref="global::NaturalLanguage.NLLanguage" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NLLanguageExtensions {
		static IntPtr[] values = new IntPtr [58];
		[Field ("NLLanguageUndetermined", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageUndetermined {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageUndetermined", storage);
			}
		}
		[Field ("NLLanguageAmharic", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageAmharic {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageAmharic", storage);
			}
		}
		[Field ("NLLanguageArabic", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageArabic {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageArabic", storage);
			}
		}
		[Field ("NLLanguageArmenian", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageArmenian {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageArmenian", storage);
			}
		}
		[Field ("NLLanguageBengali", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageBengali {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageBengali", storage);
			}
		}
		[Field ("NLLanguageBulgarian", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageBulgarian {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageBulgarian", storage);
			}
		}
		[Field ("NLLanguageBurmese", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageBurmese {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageBurmese", storage);
			}
		}
		[Field ("NLLanguageCatalan", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageCatalan {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageCatalan", storage);
			}
		}
		[Field ("NLLanguageCherokee", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageCherokee {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageCherokee", storage);
			}
		}
		[Field ("NLLanguageCroatian", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageCroatian {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageCroatian", storage);
			}
		}
		[Field ("NLLanguageCzech", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageCzech {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageCzech", storage);
			}
		}
		[Field ("NLLanguageDanish", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageDanish {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageDanish", storage);
			}
		}
		[Field ("NLLanguageDutch", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageDutch {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageDutch", storage);
			}
		}
		[Field ("NLLanguageEnglish", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageEnglish {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageEnglish", storage);
			}
		}
		[Field ("NLLanguageFinnish", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageFinnish {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageFinnish", storage);
			}
		}
		[Field ("NLLanguageFrench", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageFrench {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageFrench", storage);
			}
		}
		[Field ("NLLanguageGeorgian", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageGeorgian {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageGeorgian", storage);
			}
		}
		[Field ("NLLanguageGerman", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageGerman {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageGerman", storage);
			}
		}
		[Field ("NLLanguageGreek", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageGreek {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageGreek", storage);
			}
		}
		[Field ("NLLanguageGujarati", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageGujarati {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageGujarati", storage);
			}
		}
		[Field ("NLLanguageHebrew", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageHebrew {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageHebrew", storage);
			}
		}
		[Field ("NLLanguageHindi", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageHindi {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageHindi", storage);
			}
		}
		[Field ("NLLanguageHungarian", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageHungarian {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageHungarian", storage);
			}
		}
		[Field ("NLLanguageIcelandic", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageIcelandic {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageIcelandic", storage);
			}
		}
		[Field ("NLLanguageIndonesian", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageIndonesian {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageIndonesian", storage);
			}
		}
		[Field ("NLLanguageItalian", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageItalian {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageItalian", storage);
			}
		}
		[Field ("NLLanguageJapanese", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageJapanese {
			get {
				fixed (IntPtr *storage = &values [26])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageJapanese", storage);
			}
		}
		[Field ("NLLanguageKannada", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageKannada {
			get {
				fixed (IntPtr *storage = &values [27])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageKannada", storage);
			}
		}
		[Field ("NLLanguageKhmer", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageKhmer {
			get {
				fixed (IntPtr *storage = &values [28])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageKhmer", storage);
			}
		}
		[Field ("NLLanguageKorean", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageKorean {
			get {
				fixed (IntPtr *storage = &values [29])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageKorean", storage);
			}
		}
		[Field ("NLLanguageLao", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageLao {
			get {
				fixed (IntPtr *storage = &values [30])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageLao", storage);
			}
		}
		[Field ("NLLanguageMalay", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageMalay {
			get {
				fixed (IntPtr *storage = &values [31])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageMalay", storage);
			}
		}
		[Field ("NLLanguageMalayalam", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageMalayalam {
			get {
				fixed (IntPtr *storage = &values [32])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageMalayalam", storage);
			}
		}
		[Field ("NLLanguageMarathi", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageMarathi {
			get {
				fixed (IntPtr *storage = &values [33])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageMarathi", storage);
			}
		}
		[Field ("NLLanguageMongolian", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageMongolian {
			get {
				fixed (IntPtr *storage = &values [34])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageMongolian", storage);
			}
		}
		[Field ("NLLanguageNorwegian", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageNorwegian {
			get {
				fixed (IntPtr *storage = &values [35])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageNorwegian", storage);
			}
		}
		[Field ("NLLanguageOriya", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageOriya {
			get {
				fixed (IntPtr *storage = &values [36])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageOriya", storage);
			}
		}
		[Field ("NLLanguagePersian", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguagePersian {
			get {
				fixed (IntPtr *storage = &values [37])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguagePersian", storage);
			}
		}
		[Field ("NLLanguagePolish", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguagePolish {
			get {
				fixed (IntPtr *storage = &values [38])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguagePolish", storage);
			}
		}
		[Field ("NLLanguagePortuguese", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguagePortuguese {
			get {
				fixed (IntPtr *storage = &values [39])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguagePortuguese", storage);
			}
		}
		[Field ("NLLanguagePunjabi", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguagePunjabi {
			get {
				fixed (IntPtr *storage = &values [40])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguagePunjabi", storage);
			}
		}
		[Field ("NLLanguageRomanian", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageRomanian {
			get {
				fixed (IntPtr *storage = &values [41])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageRomanian", storage);
			}
		}
		[Field ("NLLanguageRussian", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageRussian {
			get {
				fixed (IntPtr *storage = &values [42])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageRussian", storage);
			}
		}
		[Field ("NLLanguageSimplifiedChinese", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageSimplifiedChinese {
			get {
				fixed (IntPtr *storage = &values [43])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageSimplifiedChinese", storage);
			}
		}
		[Field ("NLLanguageSinhalese", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageSinhalese {
			get {
				fixed (IntPtr *storage = &values [44])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageSinhalese", storage);
			}
		}
		[Field ("NLLanguageSlovak", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageSlovak {
			get {
				fixed (IntPtr *storage = &values [45])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageSlovak", storage);
			}
		}
		[Field ("NLLanguageSpanish", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageSpanish {
			get {
				fixed (IntPtr *storage = &values [46])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageSpanish", storage);
			}
		}
		[Field ("NLLanguageSwedish", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageSwedish {
			get {
				fixed (IntPtr *storage = &values [47])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageSwedish", storage);
			}
		}
		[Field ("NLLanguageTamil", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageTamil {
			get {
				fixed (IntPtr *storage = &values [48])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageTamil", storage);
			}
		}
		[Field ("NLLanguageTelugu", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageTelugu {
			get {
				fixed (IntPtr *storage = &values [49])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageTelugu", storage);
			}
		}
		[Field ("NLLanguageThai", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageThai {
			get {
				fixed (IntPtr *storage = &values [50])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageThai", storage);
			}
		}
		[Field ("NLLanguageTibetan", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageTibetan {
			get {
				fixed (IntPtr *storage = &values [51])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageTibetan", storage);
			}
		}
		[Field ("NLLanguageTraditionalChinese", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageTraditionalChinese {
			get {
				fixed (IntPtr *storage = &values [52])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageTraditionalChinese", storage);
			}
		}
		[Field ("NLLanguageTurkish", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageTurkish {
			get {
				fixed (IntPtr *storage = &values [53])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageTurkish", storage);
			}
		}
		[Field ("NLLanguageUkrainian", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageUkrainian {
			get {
				fixed (IntPtr *storage = &values [54])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageUkrainian", storage);
			}
		}
		[Field ("NLLanguageUrdu", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageUrdu {
			get {
				fixed (IntPtr *storage = &values [55])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageUrdu", storage);
			}
		}
		[Field ("NLLanguageVietnamese", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageVietnamese {
			get {
				fixed (IntPtr *storage = &values [56])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageVietnamese", storage);
			}
		}
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[Field ("NLLanguageKazakh", "NaturalLanguage")]
		internal unsafe static IntPtr NLLanguageKazakh {
			get {
				fixed (IntPtr *storage = &values [57])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLLanguageKazakh", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NLLanguage self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // NLLanguage.Undetermined
				ptr = NLLanguageUndetermined;
				break;
			case 2: // NLLanguage.Amharic
				ptr = NLLanguageAmharic;
				break;
			case 3: // NLLanguage.Arabic
				ptr = NLLanguageArabic;
				break;
			case 4: // NLLanguage.Armenian
				ptr = NLLanguageArmenian;
				break;
			case 5: // NLLanguage.Bengali
				ptr = NLLanguageBengali;
				break;
			case 6: // NLLanguage.Bulgarian
				ptr = NLLanguageBulgarian;
				break;
			case 7: // NLLanguage.Burmese
				ptr = NLLanguageBurmese;
				break;
			case 8: // NLLanguage.Catalan
				ptr = NLLanguageCatalan;
				break;
			case 9: // NLLanguage.Cherokee
				ptr = NLLanguageCherokee;
				break;
			case 10: // NLLanguage.Croatian
				ptr = NLLanguageCroatian;
				break;
			case 11: // NLLanguage.Czech
				ptr = NLLanguageCzech;
				break;
			case 12: // NLLanguage.Danish
				ptr = NLLanguageDanish;
				break;
			case 13: // NLLanguage.Dutch
				ptr = NLLanguageDutch;
				break;
			case 14: // NLLanguage.English
				ptr = NLLanguageEnglish;
				break;
			case 15: // NLLanguage.Finnish
				ptr = NLLanguageFinnish;
				break;
			case 16: // NLLanguage.French
				ptr = NLLanguageFrench;
				break;
			case 17: // NLLanguage.Georgian
				ptr = NLLanguageGeorgian;
				break;
			case 18: // NLLanguage.German
				ptr = NLLanguageGerman;
				break;
			case 19: // NLLanguage.Greek
				ptr = NLLanguageGreek;
				break;
			case 20: // NLLanguage.Gujarati
				ptr = NLLanguageGujarati;
				break;
			case 21: // NLLanguage.Hebrew
				ptr = NLLanguageHebrew;
				break;
			case 22: // NLLanguage.Hindi
				ptr = NLLanguageHindi;
				break;
			case 23: // NLLanguage.Hungarian
				ptr = NLLanguageHungarian;
				break;
			case 24: // NLLanguage.Icelandic
				ptr = NLLanguageIcelandic;
				break;
			case 25: // NLLanguage.Indonesian
				ptr = NLLanguageIndonesian;
				break;
			case 26: // NLLanguage.Italian
				ptr = NLLanguageItalian;
				break;
			case 27: // NLLanguage.Japanese
				ptr = NLLanguageJapanese;
				break;
			case 28: // NLLanguage.Kannada
				ptr = NLLanguageKannada;
				break;
			case 29: // NLLanguage.Khmer
				ptr = NLLanguageKhmer;
				break;
			case 30: // NLLanguage.Korean
				ptr = NLLanguageKorean;
				break;
			case 31: // NLLanguage.Lao
				ptr = NLLanguageLao;
				break;
			case 32: // NLLanguage.Malay
				ptr = NLLanguageMalay;
				break;
			case 33: // NLLanguage.Malayalam
				ptr = NLLanguageMalayalam;
				break;
			case 34: // NLLanguage.Marathi
				ptr = NLLanguageMarathi;
				break;
			case 35: // NLLanguage.Mongolian
				ptr = NLLanguageMongolian;
				break;
			case 36: // NLLanguage.Norwegian
				ptr = NLLanguageNorwegian;
				break;
			case 37: // NLLanguage.Oriya
				ptr = NLLanguageOriya;
				break;
			case 38: // NLLanguage.Persian
				ptr = NLLanguagePersian;
				break;
			case 39: // NLLanguage.Polish
				ptr = NLLanguagePolish;
				break;
			case 40: // NLLanguage.Portuguese
				ptr = NLLanguagePortuguese;
				break;
			case 41: // NLLanguage.Punjabi
				ptr = NLLanguagePunjabi;
				break;
			case 42: // NLLanguage.Romanian
				ptr = NLLanguageRomanian;
				break;
			case 43: // NLLanguage.Russian
				ptr = NLLanguageRussian;
				break;
			case 44: // NLLanguage.SimplifiedChinese
				ptr = NLLanguageSimplifiedChinese;
				break;
			case 45: // NLLanguage.Sinhalese
				ptr = NLLanguageSinhalese;
				break;
			case 46: // NLLanguage.Slovak
				ptr = NLLanguageSlovak;
				break;
			case 47: // NLLanguage.Spanish
				ptr = NLLanguageSpanish;
				break;
			case 48: // NLLanguage.Swedish
				ptr = NLLanguageSwedish;
				break;
			case 49: // NLLanguage.Tamil
				ptr = NLLanguageTamil;
				break;
			case 50: // NLLanguage.Telugu
				ptr = NLLanguageTelugu;
				break;
			case 51: // NLLanguage.Thai
				ptr = NLLanguageThai;
				break;
			case 52: // NLLanguage.Tibetan
				ptr = NLLanguageTibetan;
				break;
			case 53: // NLLanguage.TraditionalChinese
				ptr = NLLanguageTraditionalChinese;
				break;
			case 54: // NLLanguage.Turkish
				ptr = NLLanguageTurkish;
				break;
			case 55: // NLLanguage.Ukrainian
				ptr = NLLanguageUkrainian;
				break;
			case 56: // NLLanguage.Urdu
				ptr = NLLanguageUrdu;
				break;
			case 57: // NLLanguage.Vietnamese
				ptr = NLLanguageVietnamese;
				break;
			case 58: // NLLanguage.Kazakh
				ptr = NLLanguageKazakh;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::NaturalLanguage.NLLanguage" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NLLanguage GetValue (NSString? constant)
		{
			if (constant is null)
				return NLLanguage.Unevaluated;
			if (constant.IsEqualTo (NLLanguageUndetermined))
				return NLLanguage.Undetermined;
			if (constant.IsEqualTo (NLLanguageAmharic))
				return NLLanguage.Amharic;
			if (constant.IsEqualTo (NLLanguageArabic))
				return NLLanguage.Arabic;
			if (constant.IsEqualTo (NLLanguageArmenian))
				return NLLanguage.Armenian;
			if (constant.IsEqualTo (NLLanguageBengali))
				return NLLanguage.Bengali;
			if (constant.IsEqualTo (NLLanguageBulgarian))
				return NLLanguage.Bulgarian;
			if (constant.IsEqualTo (NLLanguageBurmese))
				return NLLanguage.Burmese;
			if (constant.IsEqualTo (NLLanguageCatalan))
				return NLLanguage.Catalan;
			if (constant.IsEqualTo (NLLanguageCherokee))
				return NLLanguage.Cherokee;
			if (constant.IsEqualTo (NLLanguageCroatian))
				return NLLanguage.Croatian;
			if (constant.IsEqualTo (NLLanguageCzech))
				return NLLanguage.Czech;
			if (constant.IsEqualTo (NLLanguageDanish))
				return NLLanguage.Danish;
			if (constant.IsEqualTo (NLLanguageDutch))
				return NLLanguage.Dutch;
			if (constant.IsEqualTo (NLLanguageEnglish))
				return NLLanguage.English;
			if (constant.IsEqualTo (NLLanguageFinnish))
				return NLLanguage.Finnish;
			if (constant.IsEqualTo (NLLanguageFrench))
				return NLLanguage.French;
			if (constant.IsEqualTo (NLLanguageGeorgian))
				return NLLanguage.Georgian;
			if (constant.IsEqualTo (NLLanguageGerman))
				return NLLanguage.German;
			if (constant.IsEqualTo (NLLanguageGreek))
				return NLLanguage.Greek;
			if (constant.IsEqualTo (NLLanguageGujarati))
				return NLLanguage.Gujarati;
			if (constant.IsEqualTo (NLLanguageHebrew))
				return NLLanguage.Hebrew;
			if (constant.IsEqualTo (NLLanguageHindi))
				return NLLanguage.Hindi;
			if (constant.IsEqualTo (NLLanguageHungarian))
				return NLLanguage.Hungarian;
			if (constant.IsEqualTo (NLLanguageIcelandic))
				return NLLanguage.Icelandic;
			if (constant.IsEqualTo (NLLanguageIndonesian))
				return NLLanguage.Indonesian;
			if (constant.IsEqualTo (NLLanguageItalian))
				return NLLanguage.Italian;
			if (constant.IsEqualTo (NLLanguageJapanese))
				return NLLanguage.Japanese;
			if (constant.IsEqualTo (NLLanguageKannada))
				return NLLanguage.Kannada;
			if (constant.IsEqualTo (NLLanguageKhmer))
				return NLLanguage.Khmer;
			if (constant.IsEqualTo (NLLanguageKorean))
				return NLLanguage.Korean;
			if (constant.IsEqualTo (NLLanguageLao))
				return NLLanguage.Lao;
			if (constant.IsEqualTo (NLLanguageMalay))
				return NLLanguage.Malay;
			if (constant.IsEqualTo (NLLanguageMalayalam))
				return NLLanguage.Malayalam;
			if (constant.IsEqualTo (NLLanguageMarathi))
				return NLLanguage.Marathi;
			if (constant.IsEqualTo (NLLanguageMongolian))
				return NLLanguage.Mongolian;
			if (constant.IsEqualTo (NLLanguageNorwegian))
				return NLLanguage.Norwegian;
			if (constant.IsEqualTo (NLLanguageOriya))
				return NLLanguage.Oriya;
			if (constant.IsEqualTo (NLLanguagePersian))
				return NLLanguage.Persian;
			if (constant.IsEqualTo (NLLanguagePolish))
				return NLLanguage.Polish;
			if (constant.IsEqualTo (NLLanguagePortuguese))
				return NLLanguage.Portuguese;
			if (constant.IsEqualTo (NLLanguagePunjabi))
				return NLLanguage.Punjabi;
			if (constant.IsEqualTo (NLLanguageRomanian))
				return NLLanguage.Romanian;
			if (constant.IsEqualTo (NLLanguageRussian))
				return NLLanguage.Russian;
			if (constant.IsEqualTo (NLLanguageSimplifiedChinese))
				return NLLanguage.SimplifiedChinese;
			if (constant.IsEqualTo (NLLanguageSinhalese))
				return NLLanguage.Sinhalese;
			if (constant.IsEqualTo (NLLanguageSlovak))
				return NLLanguage.Slovak;
			if (constant.IsEqualTo (NLLanguageSpanish))
				return NLLanguage.Spanish;
			if (constant.IsEqualTo (NLLanguageSwedish))
				return NLLanguage.Swedish;
			if (constant.IsEqualTo (NLLanguageTamil))
				return NLLanguage.Tamil;
			if (constant.IsEqualTo (NLLanguageTelugu))
				return NLLanguage.Telugu;
			if (constant.IsEqualTo (NLLanguageThai))
				return NLLanguage.Thai;
			if (constant.IsEqualTo (NLLanguageTibetan))
				return NLLanguage.Tibetan;
			if (constant.IsEqualTo (NLLanguageTraditionalChinese))
				return NLLanguage.TraditionalChinese;
			if (constant.IsEqualTo (NLLanguageTurkish))
				return NLLanguage.Turkish;
			if (constant.IsEqualTo (NLLanguageUkrainian))
				return NLLanguage.Ukrainian;
			if (constant.IsEqualTo (NLLanguageUrdu))
				return NLLanguage.Urdu;
			if (constant.IsEqualTo (NLLanguageVietnamese))
				return NLLanguage.Vietnamese;
			if (constant.IsEqualTo (NLLanguageKazakh))
				return NLLanguage.Kazakh;
			return NLLanguage.Unevaluated;
		}
		/// <summary>Retrieves the <see cref="global::NaturalLanguage.NLLanguage" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NLLanguage GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::NaturalLanguage.NLLanguage" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NLLanguage? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::NaturalLanguage.NLLanguage" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NLLanguage[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSString?> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (value.GetConstant ());
			}
			return rv.ToArray ();
		}
		/// <summary>Converts an array of <see cref="NSString" /> values into an array of their corresponding enum values.</summary>
		/// <param name="values">The array if <see cref="NSString" /> values to convert.</param>
		internal static NLLanguage[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NLLanguage> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
