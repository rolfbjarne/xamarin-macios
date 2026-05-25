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
namespace SensorKit {
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum SRDeviceUsageCategory : int {
		Games = 0,
		Business = 1,
		Weather = 2,
		Utilities = 3,
		Travel = 4,
		Sports = 5,
		SocialNetworking = 6,
		Reference = 7,
		Productivity = 8,
		PhotoAndVideo = 9,
		News = 10,
		Navigation = 11,
		Music = 12,
		Lifestyle = 13,
		HealthAndFitness = 14,
		Finance = 15,
		Entertainment = 16,
		Education = 17,
		Books = 18,
		Medical = 19,
		Newsstand = 20,
		Catalogs = 21,
		Kids = 22,
		Miscellaneous = 23,
		FoodAndDrink = 24,
		DeveloperTools = 25,
		GraphicsAndDesign = 26,
		Shopping = 27,
		Stickers = 28,
	}
	/// <summary>Extension methods for the <see cref="global::SensorKit.SRDeviceUsageCategory" /> enumeration.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class SRDeviceUsageCategoryExtensions {
		static IntPtr[] values = new IntPtr [29];
		[Field ("SRDeviceUsageCategoryGames", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryGames {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryGames", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryBusiness", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryBusiness {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryBusiness", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryWeather", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryWeather {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryWeather", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryUtilities", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryUtilities {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryUtilities", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryTravel", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryTravel {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryTravel", storage);
			}
		}
		[Field ("SRDeviceUsageCategorySports", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategorySports {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategorySports", storage);
			}
		}
		[Field ("SRDeviceUsageCategorySocialNetworking", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategorySocialNetworking {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategorySocialNetworking", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryReference", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryReference {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryReference", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryProductivity", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryProductivity {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryProductivity", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryPhotoAndVideo", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryPhotoAndVideo {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryPhotoAndVideo", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryNews", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryNews {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryNews", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryNavigation", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryNavigation {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryNavigation", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryMusic", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryMusic {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryMusic", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryLifestyle", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryLifestyle {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryLifestyle", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryHealthAndFitness", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryHealthAndFitness {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryHealthAndFitness", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryFinance", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryFinance {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryFinance", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryEntertainment", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryEntertainment {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryEntertainment", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryEducation", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryEducation {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryEducation", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryBooks", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryBooks {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryBooks", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryMedical", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryMedical {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryMedical", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryNewsstand", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryNewsstand {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryNewsstand", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryCatalogs", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryCatalogs {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryCatalogs", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryKids", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryKids {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryKids", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryMiscellaneous", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryMiscellaneous {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryMiscellaneous", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryFoodAndDrink", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryFoodAndDrink {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryFoodAndDrink", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryDeveloperTools", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryDeveloperTools {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryDeveloperTools", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryGraphicsAndDesign", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryGraphicsAndDesign {
			get {
				fixed (IntPtr *storage = &values [26])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryGraphicsAndDesign", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryShopping", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryShopping {
			get {
				fixed (IntPtr *storage = &values [27])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryShopping", storage);
			}
		}
		[Field ("SRDeviceUsageCategoryStickers", "SensorKit")]
		internal unsafe static IntPtr SRDeviceUsageCategoryStickers {
			get {
				fixed (IntPtr *storage = &values [28])
					return Dlfcn.CachePointer (Libraries.SensorKit.Handle, "SRDeviceUsageCategoryStickers", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this SRDeviceUsageCategory self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // SRDeviceUsageCategory.Games
				ptr = SRDeviceUsageCategoryGames;
				break;
			case 1: // SRDeviceUsageCategory.Business
				ptr = SRDeviceUsageCategoryBusiness;
				break;
			case 2: // SRDeviceUsageCategory.Weather
				ptr = SRDeviceUsageCategoryWeather;
				break;
			case 3: // SRDeviceUsageCategory.Utilities
				ptr = SRDeviceUsageCategoryUtilities;
				break;
			case 4: // SRDeviceUsageCategory.Travel
				ptr = SRDeviceUsageCategoryTravel;
				break;
			case 5: // SRDeviceUsageCategory.Sports
				ptr = SRDeviceUsageCategorySports;
				break;
			case 6: // SRDeviceUsageCategory.SocialNetworking
				ptr = SRDeviceUsageCategorySocialNetworking;
				break;
			case 7: // SRDeviceUsageCategory.Reference
				ptr = SRDeviceUsageCategoryReference;
				break;
			case 8: // SRDeviceUsageCategory.Productivity
				ptr = SRDeviceUsageCategoryProductivity;
				break;
			case 9: // SRDeviceUsageCategory.PhotoAndVideo
				ptr = SRDeviceUsageCategoryPhotoAndVideo;
				break;
			case 10: // SRDeviceUsageCategory.News
				ptr = SRDeviceUsageCategoryNews;
				break;
			case 11: // SRDeviceUsageCategory.Navigation
				ptr = SRDeviceUsageCategoryNavigation;
				break;
			case 12: // SRDeviceUsageCategory.Music
				ptr = SRDeviceUsageCategoryMusic;
				break;
			case 13: // SRDeviceUsageCategory.Lifestyle
				ptr = SRDeviceUsageCategoryLifestyle;
				break;
			case 14: // SRDeviceUsageCategory.HealthAndFitness
				ptr = SRDeviceUsageCategoryHealthAndFitness;
				break;
			case 15: // SRDeviceUsageCategory.Finance
				ptr = SRDeviceUsageCategoryFinance;
				break;
			case 16: // SRDeviceUsageCategory.Entertainment
				ptr = SRDeviceUsageCategoryEntertainment;
				break;
			case 17: // SRDeviceUsageCategory.Education
				ptr = SRDeviceUsageCategoryEducation;
				break;
			case 18: // SRDeviceUsageCategory.Books
				ptr = SRDeviceUsageCategoryBooks;
				break;
			case 19: // SRDeviceUsageCategory.Medical
				ptr = SRDeviceUsageCategoryMedical;
				break;
			case 20: // SRDeviceUsageCategory.Newsstand
				ptr = SRDeviceUsageCategoryNewsstand;
				break;
			case 21: // SRDeviceUsageCategory.Catalogs
				ptr = SRDeviceUsageCategoryCatalogs;
				break;
			case 22: // SRDeviceUsageCategory.Kids
				ptr = SRDeviceUsageCategoryKids;
				break;
			case 23: // SRDeviceUsageCategory.Miscellaneous
				ptr = SRDeviceUsageCategoryMiscellaneous;
				break;
			case 24: // SRDeviceUsageCategory.FoodAndDrink
				ptr = SRDeviceUsageCategoryFoodAndDrink;
				break;
			case 25: // SRDeviceUsageCategory.DeveloperTools
				ptr = SRDeviceUsageCategoryDeveloperTools;
				break;
			case 26: // SRDeviceUsageCategory.GraphicsAndDesign
				ptr = SRDeviceUsageCategoryGraphicsAndDesign;
				break;
			case 27: // SRDeviceUsageCategory.Shopping
				ptr = SRDeviceUsageCategoryShopping;
				break;
			case 28: // SRDeviceUsageCategory.Stickers
				ptr = SRDeviceUsageCategoryStickers;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::SensorKit.SRDeviceUsageCategory" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static SRDeviceUsageCategory GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (SRDeviceUsageCategoryGames))
				return SRDeviceUsageCategory.Games;
			if (constant.IsEqualTo (SRDeviceUsageCategoryBusiness))
				return SRDeviceUsageCategory.Business;
			if (constant.IsEqualTo (SRDeviceUsageCategoryWeather))
				return SRDeviceUsageCategory.Weather;
			if (constant.IsEqualTo (SRDeviceUsageCategoryUtilities))
				return SRDeviceUsageCategory.Utilities;
			if (constant.IsEqualTo (SRDeviceUsageCategoryTravel))
				return SRDeviceUsageCategory.Travel;
			if (constant.IsEqualTo (SRDeviceUsageCategorySports))
				return SRDeviceUsageCategory.Sports;
			if (constant.IsEqualTo (SRDeviceUsageCategorySocialNetworking))
				return SRDeviceUsageCategory.SocialNetworking;
			if (constant.IsEqualTo (SRDeviceUsageCategoryReference))
				return SRDeviceUsageCategory.Reference;
			if (constant.IsEqualTo (SRDeviceUsageCategoryProductivity))
				return SRDeviceUsageCategory.Productivity;
			if (constant.IsEqualTo (SRDeviceUsageCategoryPhotoAndVideo))
				return SRDeviceUsageCategory.PhotoAndVideo;
			if (constant.IsEqualTo (SRDeviceUsageCategoryNews))
				return SRDeviceUsageCategory.News;
			if (constant.IsEqualTo (SRDeviceUsageCategoryNavigation))
				return SRDeviceUsageCategory.Navigation;
			if (constant.IsEqualTo (SRDeviceUsageCategoryMusic))
				return SRDeviceUsageCategory.Music;
			if (constant.IsEqualTo (SRDeviceUsageCategoryLifestyle))
				return SRDeviceUsageCategory.Lifestyle;
			if (constant.IsEqualTo (SRDeviceUsageCategoryHealthAndFitness))
				return SRDeviceUsageCategory.HealthAndFitness;
			if (constant.IsEqualTo (SRDeviceUsageCategoryFinance))
				return SRDeviceUsageCategory.Finance;
			if (constant.IsEqualTo (SRDeviceUsageCategoryEntertainment))
				return SRDeviceUsageCategory.Entertainment;
			if (constant.IsEqualTo (SRDeviceUsageCategoryEducation))
				return SRDeviceUsageCategory.Education;
			if (constant.IsEqualTo (SRDeviceUsageCategoryBooks))
				return SRDeviceUsageCategory.Books;
			if (constant.IsEqualTo (SRDeviceUsageCategoryMedical))
				return SRDeviceUsageCategory.Medical;
			if (constant.IsEqualTo (SRDeviceUsageCategoryNewsstand))
				return SRDeviceUsageCategory.Newsstand;
			if (constant.IsEqualTo (SRDeviceUsageCategoryCatalogs))
				return SRDeviceUsageCategory.Catalogs;
			if (constant.IsEqualTo (SRDeviceUsageCategoryKids))
				return SRDeviceUsageCategory.Kids;
			if (constant.IsEqualTo (SRDeviceUsageCategoryMiscellaneous))
				return SRDeviceUsageCategory.Miscellaneous;
			if (constant.IsEqualTo (SRDeviceUsageCategoryFoodAndDrink))
				return SRDeviceUsageCategory.FoodAndDrink;
			if (constant.IsEqualTo (SRDeviceUsageCategoryDeveloperTools))
				return SRDeviceUsageCategory.DeveloperTools;
			if (constant.IsEqualTo (SRDeviceUsageCategoryGraphicsAndDesign))
				return SRDeviceUsageCategory.GraphicsAndDesign;
			if (constant.IsEqualTo (SRDeviceUsageCategoryShopping))
				return SRDeviceUsageCategory.Shopping;
			if (constant.IsEqualTo (SRDeviceUsageCategoryStickers))
				return SRDeviceUsageCategory.Stickers;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::SensorKit.SRDeviceUsageCategory" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static SRDeviceUsageCategory GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::SensorKit.SRDeviceUsageCategory" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static SRDeviceUsageCategory? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::SensorKit.SRDeviceUsageCategory" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this SRDeviceUsageCategory[]? values)
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
		internal static SRDeviceUsageCategory[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<SRDeviceUsageCategory> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
