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
namespace MapKit {
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum MKPointOfInterestCategory : int {
		Airport = 0,
		AmusementPark = 1,
		Aquarium = 2,
		Atm = 3,
		Bakery = 4,
		Bank = 5,
		Beach = 6,
		Brewery = 7,
		Cafe = 8,
		Campground = 9,
		CarRental = 10,
		EVCharger = 11,
		FireStation = 12,
		FitnessCenter = 13,
		FoodMarket = 14,
		GasStation = 15,
		Hospital = 16,
		Hotel = 17,
		Laundry = 18,
		Library = 19,
		Marina = 20,
		MovieTheater = 21,
		Museum = 22,
		NationalPark = 23,
		Nightlife = 24,
		Park = 25,
		Parking = 26,
		Pharmacy = 27,
		Police = 28,
		PostOffice = 29,
		PublicTransport = 30,
		Restaurant = 31,
		Restroom = 32,
		School = 33,
		Stadium = 34,
		Store = 35,
		Theater = 36,
		University = 37,
		Winery = 38,
		Zoo = 39,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		AnimalService = 40,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		AutomotiveRepair = 41,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Baseball = 42,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Basketball = 43,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Beauty = 44,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Bowling = 45,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Castle = 46,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		ConventionCenter = 47,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Distillery = 48,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Fairground = 49,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Fishing = 50,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Fortress = 51,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Golf = 52,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		GoKart = 53,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Hiking = 54,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Kayaking = 55,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Landmark = 56,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Mailbox = 57,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		MiniGolf = 58,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		MusicVenue = 59,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		NationalMonument = 60,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Planetarium = 61,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		RockClimbing = 62,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		RVPark = 63,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		SkatePark = 64,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Skating = 65,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Skiing = 66,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Soccer = 67,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Spa = 68,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Surfing = 69,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Swimming = 70,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Tennis = 71,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		Volleyball = 72,
	}
	/// <summary>Extension methods for the <see cref="global::MapKit.MKPointOfInterestCategory" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class MKPointOfInterestCategoryExtensions {
		static IntPtr[] values = new IntPtr [73];
		[Field ("MKPointOfInterestCategoryAirport", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryAirport {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryAirport", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryAmusementPark", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryAmusementPark {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryAmusementPark", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryAquarium", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryAquarium {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryAquarium", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryATM", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryATM {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryATM", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryBakery", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryBakery {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryBakery", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryBank", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryBank {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryBank", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryBeach", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryBeach {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryBeach", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryBrewery", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryBrewery {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryBrewery", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryCafe", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryCafe {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryCafe", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryCampground", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryCampground {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryCampground", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryCarRental", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryCarRental {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryCarRental", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryEVCharger", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryEVCharger {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryEVCharger", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryFireStation", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryFireStation {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryFireStation", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryFitnessCenter", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryFitnessCenter {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryFitnessCenter", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryFoodMarket", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryFoodMarket {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryFoodMarket", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryGasStation", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryGasStation {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryGasStation", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryHospital", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryHospital {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryHospital", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryHotel", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryHotel {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryHotel", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryLaundry", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryLaundry {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryLaundry", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryLibrary", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryLibrary {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryLibrary", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryMarina", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryMarina {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryMarina", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryMovieTheater", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryMovieTheater {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryMovieTheater", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryMuseum", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryMuseum {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryMuseum", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryNationalPark", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryNationalPark {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryNationalPark", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryNightlife", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryNightlife {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryNightlife", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryPark", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryPark {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryPark", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryParking", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryParking {
			get {
				fixed (IntPtr *storage = &values [26])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryParking", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryPharmacy", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryPharmacy {
			get {
				fixed (IntPtr *storage = &values [27])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryPharmacy", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryPolice", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryPolice {
			get {
				fixed (IntPtr *storage = &values [28])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryPolice", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryPostOffice", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryPostOffice {
			get {
				fixed (IntPtr *storage = &values [29])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryPostOffice", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryPublicTransport", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryPublicTransport {
			get {
				fixed (IntPtr *storage = &values [30])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryPublicTransport", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryRestaurant", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryRestaurant {
			get {
				fixed (IntPtr *storage = &values [31])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryRestaurant", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryRestroom", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryRestroom {
			get {
				fixed (IntPtr *storage = &values [32])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryRestroom", storage);
			}
		}
		[Field ("MKPointOfInterestCategorySchool", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategorySchool {
			get {
				fixed (IntPtr *storage = &values [33])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategorySchool", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryStadium", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryStadium {
			get {
				fixed (IntPtr *storage = &values [34])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryStadium", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryStore", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryStore {
			get {
				fixed (IntPtr *storage = &values [35])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryStore", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryTheater", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryTheater {
			get {
				fixed (IntPtr *storage = &values [36])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryTheater", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryUniversity", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryUniversity {
			get {
				fixed (IntPtr *storage = &values [37])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryUniversity", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryWinery", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryWinery {
			get {
				fixed (IntPtr *storage = &values [38])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryWinery", storage);
			}
		}
		[Field ("MKPointOfInterestCategoryZoo", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryZoo {
			get {
				fixed (IntPtr *storage = &values [39])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryZoo", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryAnimalService", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryAnimalService {
			get {
				fixed (IntPtr *storage = &values [40])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryAnimalService", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryAutomotiveRepair", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryAutomotiveRepair {
			get {
				fixed (IntPtr *storage = &values [41])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryAutomotiveRepair", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryBaseball", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryBaseball {
			get {
				fixed (IntPtr *storage = &values [42])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryBaseball", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryBasketball", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryBasketball {
			get {
				fixed (IntPtr *storage = &values [43])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryBasketball", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryBeauty", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryBeauty {
			get {
				fixed (IntPtr *storage = &values [44])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryBeauty", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryBowling", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryBowling {
			get {
				fixed (IntPtr *storage = &values [45])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryBowling", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryCastle", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryCastle {
			get {
				fixed (IntPtr *storage = &values [46])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryCastle", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryConventionCenter", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryConventionCenter {
			get {
				fixed (IntPtr *storage = &values [47])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryConventionCenter", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryDistillery", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryDistillery {
			get {
				fixed (IntPtr *storage = &values [48])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryDistillery", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryFairground", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryFairground {
			get {
				fixed (IntPtr *storage = &values [49])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryFairground", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryFishing", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryFishing {
			get {
				fixed (IntPtr *storage = &values [50])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryFishing", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryFortress", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryFortress {
			get {
				fixed (IntPtr *storage = &values [51])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryFortress", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryGolf", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryGolf {
			get {
				fixed (IntPtr *storage = &values [52])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryGolf", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryGoKart", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryGoKart {
			get {
				fixed (IntPtr *storage = &values [53])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryGoKart", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryHiking", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryHiking {
			get {
				fixed (IntPtr *storage = &values [54])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryHiking", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryKayaking", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryKayaking {
			get {
				fixed (IntPtr *storage = &values [55])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryKayaking", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryLandmark", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryLandmark {
			get {
				fixed (IntPtr *storage = &values [56])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryLandmark", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryMailbox", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryMailbox {
			get {
				fixed (IntPtr *storage = &values [57])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryMailbox", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryMiniGolf", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryMiniGolf {
			get {
				fixed (IntPtr *storage = &values [58])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryMiniGolf", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryMusicVenue", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryMusicVenue {
			get {
				fixed (IntPtr *storage = &values [59])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryMusicVenue", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryNationalMonument", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryNationalMonument {
			get {
				fixed (IntPtr *storage = &values [60])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryNationalMonument", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryPlanetarium", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryPlanetarium {
			get {
				fixed (IntPtr *storage = &values [61])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryPlanetarium", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryRockClimbing", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryRockClimbing {
			get {
				fixed (IntPtr *storage = &values [62])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryRockClimbing", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryRVPark", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryRVPark {
			get {
				fixed (IntPtr *storage = &values [63])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryRVPark", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategorySkatePark", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategorySkatePark {
			get {
				fixed (IntPtr *storage = &values [64])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategorySkatePark", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategorySkating", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategorySkating {
			get {
				fixed (IntPtr *storage = &values [65])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategorySkating", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategorySkiing", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategorySkiing {
			get {
				fixed (IntPtr *storage = &values [66])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategorySkiing", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategorySoccer", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategorySoccer {
			get {
				fixed (IntPtr *storage = &values [67])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategorySoccer", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategorySpa", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategorySpa {
			get {
				fixed (IntPtr *storage = &values [68])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategorySpa", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategorySurfing", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategorySurfing {
			get {
				fixed (IntPtr *storage = &values [69])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategorySurfing", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategorySwimming", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategorySwimming {
			get {
				fixed (IntPtr *storage = &values [70])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategorySwimming", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryTennis", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryTennis {
			get {
				fixed (IntPtr *storage = &values [71])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryTennis", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("MKPointOfInterestCategoryVolleyball", "MapKit")]
		internal unsafe static IntPtr MKPointOfInterestCategoryVolleyball {
			get {
				fixed (IntPtr *storage = &values [72])
					return Dlfcn.CachePointer (Libraries.MapKit.Handle, "MKPointOfInterestCategoryVolleyball", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this MKPointOfInterestCategory self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // MKPointOfInterestCategory.Airport
				ptr = MKPointOfInterestCategoryAirport;
				break;
			case 1: // MKPointOfInterestCategory.AmusementPark
				ptr = MKPointOfInterestCategoryAmusementPark;
				break;
			case 2: // MKPointOfInterestCategory.Aquarium
				ptr = MKPointOfInterestCategoryAquarium;
				break;
			case 3: // MKPointOfInterestCategory.Atm
				ptr = MKPointOfInterestCategoryATM;
				break;
			case 4: // MKPointOfInterestCategory.Bakery
				ptr = MKPointOfInterestCategoryBakery;
				break;
			case 5: // MKPointOfInterestCategory.Bank
				ptr = MKPointOfInterestCategoryBank;
				break;
			case 6: // MKPointOfInterestCategory.Beach
				ptr = MKPointOfInterestCategoryBeach;
				break;
			case 7: // MKPointOfInterestCategory.Brewery
				ptr = MKPointOfInterestCategoryBrewery;
				break;
			case 8: // MKPointOfInterestCategory.Cafe
				ptr = MKPointOfInterestCategoryCafe;
				break;
			case 9: // MKPointOfInterestCategory.Campground
				ptr = MKPointOfInterestCategoryCampground;
				break;
			case 10: // MKPointOfInterestCategory.CarRental
				ptr = MKPointOfInterestCategoryCarRental;
				break;
			case 11: // MKPointOfInterestCategory.EVCharger
				ptr = MKPointOfInterestCategoryEVCharger;
				break;
			case 12: // MKPointOfInterestCategory.FireStation
				ptr = MKPointOfInterestCategoryFireStation;
				break;
			case 13: // MKPointOfInterestCategory.FitnessCenter
				ptr = MKPointOfInterestCategoryFitnessCenter;
				break;
			case 14: // MKPointOfInterestCategory.FoodMarket
				ptr = MKPointOfInterestCategoryFoodMarket;
				break;
			case 15: // MKPointOfInterestCategory.GasStation
				ptr = MKPointOfInterestCategoryGasStation;
				break;
			case 16: // MKPointOfInterestCategory.Hospital
				ptr = MKPointOfInterestCategoryHospital;
				break;
			case 17: // MKPointOfInterestCategory.Hotel
				ptr = MKPointOfInterestCategoryHotel;
				break;
			case 18: // MKPointOfInterestCategory.Laundry
				ptr = MKPointOfInterestCategoryLaundry;
				break;
			case 19: // MKPointOfInterestCategory.Library
				ptr = MKPointOfInterestCategoryLibrary;
				break;
			case 20: // MKPointOfInterestCategory.Marina
				ptr = MKPointOfInterestCategoryMarina;
				break;
			case 21: // MKPointOfInterestCategory.MovieTheater
				ptr = MKPointOfInterestCategoryMovieTheater;
				break;
			case 22: // MKPointOfInterestCategory.Museum
				ptr = MKPointOfInterestCategoryMuseum;
				break;
			case 23: // MKPointOfInterestCategory.NationalPark
				ptr = MKPointOfInterestCategoryNationalPark;
				break;
			case 24: // MKPointOfInterestCategory.Nightlife
				ptr = MKPointOfInterestCategoryNightlife;
				break;
			case 25: // MKPointOfInterestCategory.Park
				ptr = MKPointOfInterestCategoryPark;
				break;
			case 26: // MKPointOfInterestCategory.Parking
				ptr = MKPointOfInterestCategoryParking;
				break;
			case 27: // MKPointOfInterestCategory.Pharmacy
				ptr = MKPointOfInterestCategoryPharmacy;
				break;
			case 28: // MKPointOfInterestCategory.Police
				ptr = MKPointOfInterestCategoryPolice;
				break;
			case 29: // MKPointOfInterestCategory.PostOffice
				ptr = MKPointOfInterestCategoryPostOffice;
				break;
			case 30: // MKPointOfInterestCategory.PublicTransport
				ptr = MKPointOfInterestCategoryPublicTransport;
				break;
			case 31: // MKPointOfInterestCategory.Restaurant
				ptr = MKPointOfInterestCategoryRestaurant;
				break;
			case 32: // MKPointOfInterestCategory.Restroom
				ptr = MKPointOfInterestCategoryRestroom;
				break;
			case 33: // MKPointOfInterestCategory.School
				ptr = MKPointOfInterestCategorySchool;
				break;
			case 34: // MKPointOfInterestCategory.Stadium
				ptr = MKPointOfInterestCategoryStadium;
				break;
			case 35: // MKPointOfInterestCategory.Store
				ptr = MKPointOfInterestCategoryStore;
				break;
			case 36: // MKPointOfInterestCategory.Theater
				ptr = MKPointOfInterestCategoryTheater;
				break;
			case 37: // MKPointOfInterestCategory.University
				ptr = MKPointOfInterestCategoryUniversity;
				break;
			case 38: // MKPointOfInterestCategory.Winery
				ptr = MKPointOfInterestCategoryWinery;
				break;
			case 39: // MKPointOfInterestCategory.Zoo
				ptr = MKPointOfInterestCategoryZoo;
				break;
			case 40: // MKPointOfInterestCategory.AnimalService
				ptr = MKPointOfInterestCategoryAnimalService;
				break;
			case 41: // MKPointOfInterestCategory.AutomotiveRepair
				ptr = MKPointOfInterestCategoryAutomotiveRepair;
				break;
			case 42: // MKPointOfInterestCategory.Baseball
				ptr = MKPointOfInterestCategoryBaseball;
				break;
			case 43: // MKPointOfInterestCategory.Basketball
				ptr = MKPointOfInterestCategoryBasketball;
				break;
			case 44: // MKPointOfInterestCategory.Beauty
				ptr = MKPointOfInterestCategoryBeauty;
				break;
			case 45: // MKPointOfInterestCategory.Bowling
				ptr = MKPointOfInterestCategoryBowling;
				break;
			case 46: // MKPointOfInterestCategory.Castle
				ptr = MKPointOfInterestCategoryCastle;
				break;
			case 47: // MKPointOfInterestCategory.ConventionCenter
				ptr = MKPointOfInterestCategoryConventionCenter;
				break;
			case 48: // MKPointOfInterestCategory.Distillery
				ptr = MKPointOfInterestCategoryDistillery;
				break;
			case 49: // MKPointOfInterestCategory.Fairground
				ptr = MKPointOfInterestCategoryFairground;
				break;
			case 50: // MKPointOfInterestCategory.Fishing
				ptr = MKPointOfInterestCategoryFishing;
				break;
			case 51: // MKPointOfInterestCategory.Fortress
				ptr = MKPointOfInterestCategoryFortress;
				break;
			case 52: // MKPointOfInterestCategory.Golf
				ptr = MKPointOfInterestCategoryGolf;
				break;
			case 53: // MKPointOfInterestCategory.GoKart
				ptr = MKPointOfInterestCategoryGoKart;
				break;
			case 54: // MKPointOfInterestCategory.Hiking
				ptr = MKPointOfInterestCategoryHiking;
				break;
			case 55: // MKPointOfInterestCategory.Kayaking
				ptr = MKPointOfInterestCategoryKayaking;
				break;
			case 56: // MKPointOfInterestCategory.Landmark
				ptr = MKPointOfInterestCategoryLandmark;
				break;
			case 57: // MKPointOfInterestCategory.Mailbox
				ptr = MKPointOfInterestCategoryMailbox;
				break;
			case 58: // MKPointOfInterestCategory.MiniGolf
				ptr = MKPointOfInterestCategoryMiniGolf;
				break;
			case 59: // MKPointOfInterestCategory.MusicVenue
				ptr = MKPointOfInterestCategoryMusicVenue;
				break;
			case 60: // MKPointOfInterestCategory.NationalMonument
				ptr = MKPointOfInterestCategoryNationalMonument;
				break;
			case 61: // MKPointOfInterestCategory.Planetarium
				ptr = MKPointOfInterestCategoryPlanetarium;
				break;
			case 62: // MKPointOfInterestCategory.RockClimbing
				ptr = MKPointOfInterestCategoryRockClimbing;
				break;
			case 63: // MKPointOfInterestCategory.RVPark
				ptr = MKPointOfInterestCategoryRVPark;
				break;
			case 64: // MKPointOfInterestCategory.SkatePark
				ptr = MKPointOfInterestCategorySkatePark;
				break;
			case 65: // MKPointOfInterestCategory.Skating
				ptr = MKPointOfInterestCategorySkating;
				break;
			case 66: // MKPointOfInterestCategory.Skiing
				ptr = MKPointOfInterestCategorySkiing;
				break;
			case 67: // MKPointOfInterestCategory.Soccer
				ptr = MKPointOfInterestCategorySoccer;
				break;
			case 68: // MKPointOfInterestCategory.Spa
				ptr = MKPointOfInterestCategorySpa;
				break;
			case 69: // MKPointOfInterestCategory.Surfing
				ptr = MKPointOfInterestCategorySurfing;
				break;
			case 70: // MKPointOfInterestCategory.Swimming
				ptr = MKPointOfInterestCategorySwimming;
				break;
			case 71: // MKPointOfInterestCategory.Tennis
				ptr = MKPointOfInterestCategoryTennis;
				break;
			case 72: // MKPointOfInterestCategory.Volleyball
				ptr = MKPointOfInterestCategoryVolleyball;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::MapKit.MKPointOfInterestCategory" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static MKPointOfInterestCategory GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (MKPointOfInterestCategoryAirport))
				return MKPointOfInterestCategory.Airport;
			if (constant.IsEqualTo (MKPointOfInterestCategoryAmusementPark))
				return MKPointOfInterestCategory.AmusementPark;
			if (constant.IsEqualTo (MKPointOfInterestCategoryAquarium))
				return MKPointOfInterestCategory.Aquarium;
			if (constant.IsEqualTo (MKPointOfInterestCategoryATM))
				return MKPointOfInterestCategory.Atm;
			if (constant.IsEqualTo (MKPointOfInterestCategoryBakery))
				return MKPointOfInterestCategory.Bakery;
			if (constant.IsEqualTo (MKPointOfInterestCategoryBank))
				return MKPointOfInterestCategory.Bank;
			if (constant.IsEqualTo (MKPointOfInterestCategoryBeach))
				return MKPointOfInterestCategory.Beach;
			if (constant.IsEqualTo (MKPointOfInterestCategoryBrewery))
				return MKPointOfInterestCategory.Brewery;
			if (constant.IsEqualTo (MKPointOfInterestCategoryCafe))
				return MKPointOfInterestCategory.Cafe;
			if (constant.IsEqualTo (MKPointOfInterestCategoryCampground))
				return MKPointOfInterestCategory.Campground;
			if (constant.IsEqualTo (MKPointOfInterestCategoryCarRental))
				return MKPointOfInterestCategory.CarRental;
			if (constant.IsEqualTo (MKPointOfInterestCategoryEVCharger))
				return MKPointOfInterestCategory.EVCharger;
			if (constant.IsEqualTo (MKPointOfInterestCategoryFireStation))
				return MKPointOfInterestCategory.FireStation;
			if (constant.IsEqualTo (MKPointOfInterestCategoryFitnessCenter))
				return MKPointOfInterestCategory.FitnessCenter;
			if (constant.IsEqualTo (MKPointOfInterestCategoryFoodMarket))
				return MKPointOfInterestCategory.FoodMarket;
			if (constant.IsEqualTo (MKPointOfInterestCategoryGasStation))
				return MKPointOfInterestCategory.GasStation;
			if (constant.IsEqualTo (MKPointOfInterestCategoryHospital))
				return MKPointOfInterestCategory.Hospital;
			if (constant.IsEqualTo (MKPointOfInterestCategoryHotel))
				return MKPointOfInterestCategory.Hotel;
			if (constant.IsEqualTo (MKPointOfInterestCategoryLaundry))
				return MKPointOfInterestCategory.Laundry;
			if (constant.IsEqualTo (MKPointOfInterestCategoryLibrary))
				return MKPointOfInterestCategory.Library;
			if (constant.IsEqualTo (MKPointOfInterestCategoryMarina))
				return MKPointOfInterestCategory.Marina;
			if (constant.IsEqualTo (MKPointOfInterestCategoryMovieTheater))
				return MKPointOfInterestCategory.MovieTheater;
			if (constant.IsEqualTo (MKPointOfInterestCategoryMuseum))
				return MKPointOfInterestCategory.Museum;
			if (constant.IsEqualTo (MKPointOfInterestCategoryNationalPark))
				return MKPointOfInterestCategory.NationalPark;
			if (constant.IsEqualTo (MKPointOfInterestCategoryNightlife))
				return MKPointOfInterestCategory.Nightlife;
			if (constant.IsEqualTo (MKPointOfInterestCategoryPark))
				return MKPointOfInterestCategory.Park;
			if (constant.IsEqualTo (MKPointOfInterestCategoryParking))
				return MKPointOfInterestCategory.Parking;
			if (constant.IsEqualTo (MKPointOfInterestCategoryPharmacy))
				return MKPointOfInterestCategory.Pharmacy;
			if (constant.IsEqualTo (MKPointOfInterestCategoryPolice))
				return MKPointOfInterestCategory.Police;
			if (constant.IsEqualTo (MKPointOfInterestCategoryPostOffice))
				return MKPointOfInterestCategory.PostOffice;
			if (constant.IsEqualTo (MKPointOfInterestCategoryPublicTransport))
				return MKPointOfInterestCategory.PublicTransport;
			if (constant.IsEqualTo (MKPointOfInterestCategoryRestaurant))
				return MKPointOfInterestCategory.Restaurant;
			if (constant.IsEqualTo (MKPointOfInterestCategoryRestroom))
				return MKPointOfInterestCategory.Restroom;
			if (constant.IsEqualTo (MKPointOfInterestCategorySchool))
				return MKPointOfInterestCategory.School;
			if (constant.IsEqualTo (MKPointOfInterestCategoryStadium))
				return MKPointOfInterestCategory.Stadium;
			if (constant.IsEqualTo (MKPointOfInterestCategoryStore))
				return MKPointOfInterestCategory.Store;
			if (constant.IsEqualTo (MKPointOfInterestCategoryTheater))
				return MKPointOfInterestCategory.Theater;
			if (constant.IsEqualTo (MKPointOfInterestCategoryUniversity))
				return MKPointOfInterestCategory.University;
			if (constant.IsEqualTo (MKPointOfInterestCategoryWinery))
				return MKPointOfInterestCategory.Winery;
			if (constant.IsEqualTo (MKPointOfInterestCategoryZoo))
				return MKPointOfInterestCategory.Zoo;
			if (constant.IsEqualTo (MKPointOfInterestCategoryAnimalService))
				return MKPointOfInterestCategory.AnimalService;
			if (constant.IsEqualTo (MKPointOfInterestCategoryAutomotiveRepair))
				return MKPointOfInterestCategory.AutomotiveRepair;
			if (constant.IsEqualTo (MKPointOfInterestCategoryBaseball))
				return MKPointOfInterestCategory.Baseball;
			if (constant.IsEqualTo (MKPointOfInterestCategoryBasketball))
				return MKPointOfInterestCategory.Basketball;
			if (constant.IsEqualTo (MKPointOfInterestCategoryBeauty))
				return MKPointOfInterestCategory.Beauty;
			if (constant.IsEqualTo (MKPointOfInterestCategoryBowling))
				return MKPointOfInterestCategory.Bowling;
			if (constant.IsEqualTo (MKPointOfInterestCategoryCastle))
				return MKPointOfInterestCategory.Castle;
			if (constant.IsEqualTo (MKPointOfInterestCategoryConventionCenter))
				return MKPointOfInterestCategory.ConventionCenter;
			if (constant.IsEqualTo (MKPointOfInterestCategoryDistillery))
				return MKPointOfInterestCategory.Distillery;
			if (constant.IsEqualTo (MKPointOfInterestCategoryFairground))
				return MKPointOfInterestCategory.Fairground;
			if (constant.IsEqualTo (MKPointOfInterestCategoryFishing))
				return MKPointOfInterestCategory.Fishing;
			if (constant.IsEqualTo (MKPointOfInterestCategoryFortress))
				return MKPointOfInterestCategory.Fortress;
			if (constant.IsEqualTo (MKPointOfInterestCategoryGolf))
				return MKPointOfInterestCategory.Golf;
			if (constant.IsEqualTo (MKPointOfInterestCategoryGoKart))
				return MKPointOfInterestCategory.GoKart;
			if (constant.IsEqualTo (MKPointOfInterestCategoryHiking))
				return MKPointOfInterestCategory.Hiking;
			if (constant.IsEqualTo (MKPointOfInterestCategoryKayaking))
				return MKPointOfInterestCategory.Kayaking;
			if (constant.IsEqualTo (MKPointOfInterestCategoryLandmark))
				return MKPointOfInterestCategory.Landmark;
			if (constant.IsEqualTo (MKPointOfInterestCategoryMailbox))
				return MKPointOfInterestCategory.Mailbox;
			if (constant.IsEqualTo (MKPointOfInterestCategoryMiniGolf))
				return MKPointOfInterestCategory.MiniGolf;
			if (constant.IsEqualTo (MKPointOfInterestCategoryMusicVenue))
				return MKPointOfInterestCategory.MusicVenue;
			if (constant.IsEqualTo (MKPointOfInterestCategoryNationalMonument))
				return MKPointOfInterestCategory.NationalMonument;
			if (constant.IsEqualTo (MKPointOfInterestCategoryPlanetarium))
				return MKPointOfInterestCategory.Planetarium;
			if (constant.IsEqualTo (MKPointOfInterestCategoryRockClimbing))
				return MKPointOfInterestCategory.RockClimbing;
			if (constant.IsEqualTo (MKPointOfInterestCategoryRVPark))
				return MKPointOfInterestCategory.RVPark;
			if (constant.IsEqualTo (MKPointOfInterestCategorySkatePark))
				return MKPointOfInterestCategory.SkatePark;
			if (constant.IsEqualTo (MKPointOfInterestCategorySkating))
				return MKPointOfInterestCategory.Skating;
			if (constant.IsEqualTo (MKPointOfInterestCategorySkiing))
				return MKPointOfInterestCategory.Skiing;
			if (constant.IsEqualTo (MKPointOfInterestCategorySoccer))
				return MKPointOfInterestCategory.Soccer;
			if (constant.IsEqualTo (MKPointOfInterestCategorySpa))
				return MKPointOfInterestCategory.Spa;
			if (constant.IsEqualTo (MKPointOfInterestCategorySurfing))
				return MKPointOfInterestCategory.Surfing;
			if (constant.IsEqualTo (MKPointOfInterestCategorySwimming))
				return MKPointOfInterestCategory.Swimming;
			if (constant.IsEqualTo (MKPointOfInterestCategoryTennis))
				return MKPointOfInterestCategory.Tennis;
			if (constant.IsEqualTo (MKPointOfInterestCategoryVolleyball))
				return MKPointOfInterestCategory.Volleyball;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::MapKit.MKPointOfInterestCategory" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static MKPointOfInterestCategory GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::MapKit.MKPointOfInterestCategory" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static MKPointOfInterestCategory? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::MapKit.MKPointOfInterestCategory" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this MKPointOfInterestCategory[]? values)
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
		internal static MKPointOfInterestCategory[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<MKPointOfInterestCategory> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
