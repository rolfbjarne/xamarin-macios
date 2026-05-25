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
namespace HealthKit {
	/// <summary>Enumerates various activities that are considered workouts.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum HKWorkoutActivityType : ulong {
		/// <summary>American football.</summary>
		AmericanFootball = 1,
		/// <summary>Archery.</summary>
		Archery = 2,
		/// <summary>Australian football.</summary>
		AustralianFootball = 3,
		/// <summary>Badminton.</summary>
		Badminton = 4,
		/// <summary>Baseball.</summary>
		Baseball = 5,
		/// <summary>Basketball.</summary>
		Basketball = 6,
		/// <summary>Bowling.</summary>
		Bowling = 7,
		/// <summary>Boxing.</summary>
		Boxing = 8,
		/// <summary>Climbing.</summary>
		Climbing = 9,
		/// <summary>Cricket.</summary>
		Cricket = 10,
		/// <summary>Cross training.</summary>
		CrossTraining = 11,
		/// <summary>Curling.</summary>
		Curling = 12,
		/// <summary>Cycling.</summary>
		Cycling = 13,
		/// <summary>Dance.</summary>
		Dance = 14,
		/// <summary>Developers should not use this deprecated field. Developers should use 'HKWorkoutActivityType.Dance', 'HKWorkoutActivityType.Barre', or 'HKWorkoutActivityType.Pilates'.</summary>
		[ObsoletedOSPlatform ("ios10.0", "Use 'HKWorkoutActivityType.Dance', 'HKWorkoutActivityType.Barre', or 'HKWorkoutActivityType.Pilates'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'HKWorkoutActivityType.Dance', 'HKWorkoutActivityType.Barre', or 'HKWorkoutActivityType.Pilates'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		DanceInspiredTraining = 15,
		/// <summary>Elliptical machine training.</summary>
		Elliptical = 16,
		/// <summary>Equestrian sports.</summary>
		EquestrianSports = 17,
		/// <summary>Fencing.</summary>
		Fencing = 18,
		/// <summary>Fishing.</summary>
		Fishing = 19,
		/// <summary>Functional strength training.</summary>
		FunctionalStrengthTraining = 20,
		/// <summary>Golf.</summary>
		Golf = 21,
		/// <summary>Gymnastics.</summary>
		Gymnastics = 22,
		/// <summary>Handball.</summary>
		Handball = 23,
		/// <summary>Hiking.</summary>
		Hiking = 24,
		/// <summary>Hockey.</summary>
		Hockey = 25,
		/// <summary>Hunting.</summary>
		Hunting = 26,
		/// <summary>Lacrosse.</summary>
		Lacrosse = 27,
		/// <summary>Martial arts.</summary>
		MartialArts = 28,
		/// <summary>Mind and body training.</summary>
		MindAndBody = 29,
		/// <summary>Mixed metabolic cardio training.</summary>
		[ObsoletedOSPlatform ("ios11.0", "Use 'MixedCardio' or 'HighIntensityIntervalTraining' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'MixedCardio' or 'HighIntensityIntervalTraining' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		MixedMetabolicCardioTraining = 30,
		/// <summary>Paddle sports.</summary>
		PaddleSports = 31,
		/// <summary>Play.</summary>
		Play = 32,
		/// <summary>Preparation and recovery.</summary>
		PreparationAndRecovery = 33,
		/// <summary>Racquetball.</summary>
		Racquetball = 34,
		/// <summary>Rowing.</summary>
		Rowing = 35,
		/// <summary>Rugby.</summary>
		Rugby = 36,
		/// <summary>Running.</summary>
		Running = 37,
		/// <summary>Sailing.</summary>
		Sailing = 38,
		/// <summary>Skating sports.</summary>
		SkatingSports = 39,
		/// <summary>Snow sports.</summary>
		SnowSports = 40,
		/// <summary>Soccer.</summary>
		Soccer = 41,
		/// <summary>Softball.</summary>
		Softball = 42,
		/// <summary>Squash.</summary>
		Squash = 43,
		/// <summary>Stair climbing.</summary>
		StairClimbing = 44,
		/// <summary>Surfing sports.</summary>
		SurfingSports = 45,
		/// <summary>Swimming.</summary>
		Swimming = 46,
		/// <summary>Table tennis.</summary>
		TableTennis = 47,
		/// <summary>Tennis.</summary>
		Tennis = 48,
		/// <summary>Track and field.</summary>
		TrackAndField = 49,
		/// <summary>Traditional strength training.</summary>
		TraditionalStrengthTraining = 50,
		/// <summary>Volleyball.</summary>
		Volleyball = 51,
		/// <summary>Walking.</summary>
		Walking = 52,
		/// <summary>Water fitness.</summary>
		WaterFitness = 53,
		/// <summary>Water polo.</summary>
		WaterPolo = 54,
		/// <summary>Water sports.</summary>
		WaterSports = 55,
		/// <summary>Wrestling.</summary>
		Wrestling = 56,
		/// <summary>Yoga.</summary>
		Yoga = 57,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		Barre = 58,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		CoreTraining = 59,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		CrossCountrySkiing = 60,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		DownhillSkiing = 61,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		Flexibility = 62,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		HighIntensityIntervalTraining = 63,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		JumpRope = 64,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		Kickboxing = 65,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		Pilates = 66,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		Snowboarding = 67,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		Stairs = 68,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		StepTraining = 69,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		WheelchairWalkPace = 70,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		WheelchairRunPace = 71,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		TaiChi = 72,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		MixedCardio = 73,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		HandCycling = 74,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		DiscSports = 75,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		FitnessGaming = 76,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		CardioDance = 77,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		SocialDance = 78,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Pickleball = 79,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Cooldown = 80,
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		SwimBikeRun = 82,
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		Transition = 83,
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		UnderwaterDiving = 84,
		/// <summary>Another kind of workout.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		Other = 3000,
	}
}
