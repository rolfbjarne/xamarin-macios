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
namespace Intents {
	/// <summary>Enumerates known training types.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public enum INWorkoutNameIdentifier : int {
		/// <summary>Indicates an outdoor run.</summary>
		Run = 0,
		/// <summary>Indicates not much of a workout.</summary>
		Sit = 1,
		/// <summary>Indicates a step-walking workout.</summary>
		Steps = 2,
		/// <summary>Indicates a workout that's somewhat better than <see cref="F:Intents.INWorkoutNameIdentifier.Sit" />.</summary>
		Stand = 3,
		/// <summary>Indicates a general movement workout.</summary>
		Move = 4,
		/// <summary>Indicates an outdoor walk.</summary>
		Walk = 5,
		/// <summary>Indicates a yoga workout.</summary>
		Yoga = 6,
		/// <summary>Indicates a dance workout.</summary>
		Dance = 7,
		/// <summary>Indicates a cross-training workout.</summary>
		Crosstraining = 8,
		/// <summary>Indicates a elliptical workout.</summary>
		Elliptical = 9,
		/// <summary>Indicates a rowing workout.</summary>
		Rower = 10,
		/// <summary>Indicates an outdoor cycling workout.</summary>
		Cycle = 11,
		/// <summary>Indicates a stair-walking workout.</summary>
		Stairs = 12,
		/// <summary>Indicates an unknown workout.</summary>
		Other = 13,
		/// <summary>Indicates an indoor run.</summary>
		Indoorrun = 14,
		/// <summary>Indicates an indoor cycling workout.</summary>
		Indoorcycle = 15,
		/// <summary>Indicates an indoor walking workout.</summary>
		Indoorwalk = 16,
		/// <summary>Indicates a workout of general exercise.</summary>
		Exercise = 17,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		Hike = 18,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		HighIntensityIntervalTraining = 19,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		Swim = 20,
	}
	/// <summary>Extension methods for the <see cref="global::Intents.INWorkoutNameIdentifier" /> enumeration.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class INWorkoutNameIdentifierExtensions {
		static IntPtr[] values = new IntPtr [21];
		[Field ("INWorkoutNameIdentifierRun", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierRun {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierRun", storage);
			}
		}
		[Field ("INWorkoutNameIdentifierSit", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierSit {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierSit", storage);
			}
		}
		[Field ("INWorkoutNameIdentifierSteps", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierSteps {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierSteps", storage);
			}
		}
		[Field ("INWorkoutNameIdentifierStand", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierStand {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierStand", storage);
			}
		}
		[Field ("INWorkoutNameIdentifierMove", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierMove {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierMove", storage);
			}
		}
		[Field ("INWorkoutNameIdentifierWalk", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierWalk {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierWalk", storage);
			}
		}
		[Field ("INWorkoutNameIdentifierYoga", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierYoga {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierYoga", storage);
			}
		}
		[Field ("INWorkoutNameIdentifierDance", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierDance {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierDance", storage);
			}
		}
		[Field ("INWorkoutNameIdentifierCrosstraining", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierCrosstraining {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierCrosstraining", storage);
			}
		}
		[Field ("INWorkoutNameIdentifierElliptical", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierElliptical {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierElliptical", storage);
			}
		}
		[Field ("INWorkoutNameIdentifierRower", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierRower {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierRower", storage);
			}
		}
		[Field ("INWorkoutNameIdentifierCycle", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierCycle {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierCycle", storage);
			}
		}
		[Field ("INWorkoutNameIdentifierStairs", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierStairs {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierStairs", storage);
			}
		}
		[Field ("INWorkoutNameIdentifierOther", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierOther {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierOther", storage);
			}
		}
		[Field ("INWorkoutNameIdentifierIndoorrun", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierIndoorrun {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierIndoorrun", storage);
			}
		}
		[Field ("INWorkoutNameIdentifierIndoorcycle", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierIndoorcycle {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierIndoorcycle", storage);
			}
		}
		[Field ("INWorkoutNameIdentifierIndoorwalk", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierIndoorwalk {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierIndoorwalk", storage);
			}
		}
		[Field ("INWorkoutNameIdentifierExercise", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierExercise {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierExercise", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[Field ("INWorkoutNameIdentifierHike", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierHike {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierHike", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[Field ("INWorkoutNameIdentifierHighIntensityIntervalTraining", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierHighIntensityIntervalTraining {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierHighIntensityIntervalTraining", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[Field ("INWorkoutNameIdentifierSwim", "Intents")]
		internal unsafe static IntPtr INWorkoutNameIdentifierSwim {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INWorkoutNameIdentifierSwim", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this INWorkoutNameIdentifier self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // INWorkoutNameIdentifier.Run
				ptr = INWorkoutNameIdentifierRun;
				break;
			case 1: // INWorkoutNameIdentifier.Sit
				ptr = INWorkoutNameIdentifierSit;
				break;
			case 2: // INWorkoutNameIdentifier.Steps
				ptr = INWorkoutNameIdentifierSteps;
				break;
			case 3: // INWorkoutNameIdentifier.Stand
				ptr = INWorkoutNameIdentifierStand;
				break;
			case 4: // INWorkoutNameIdentifier.Move
				ptr = INWorkoutNameIdentifierMove;
				break;
			case 5: // INWorkoutNameIdentifier.Walk
				ptr = INWorkoutNameIdentifierWalk;
				break;
			case 6: // INWorkoutNameIdentifier.Yoga
				ptr = INWorkoutNameIdentifierYoga;
				break;
			case 7: // INWorkoutNameIdentifier.Dance
				ptr = INWorkoutNameIdentifierDance;
				break;
			case 8: // INWorkoutNameIdentifier.Crosstraining
				ptr = INWorkoutNameIdentifierCrosstraining;
				break;
			case 9: // INWorkoutNameIdentifier.Elliptical
				ptr = INWorkoutNameIdentifierElliptical;
				break;
			case 10: // INWorkoutNameIdentifier.Rower
				ptr = INWorkoutNameIdentifierRower;
				break;
			case 11: // INWorkoutNameIdentifier.Cycle
				ptr = INWorkoutNameIdentifierCycle;
				break;
			case 12: // INWorkoutNameIdentifier.Stairs
				ptr = INWorkoutNameIdentifierStairs;
				break;
			case 13: // INWorkoutNameIdentifier.Other
				ptr = INWorkoutNameIdentifierOther;
				break;
			case 14: // INWorkoutNameIdentifier.Indoorrun
				ptr = INWorkoutNameIdentifierIndoorrun;
				break;
			case 15: // INWorkoutNameIdentifier.Indoorcycle
				ptr = INWorkoutNameIdentifierIndoorcycle;
				break;
			case 16: // INWorkoutNameIdentifier.Indoorwalk
				ptr = INWorkoutNameIdentifierIndoorwalk;
				break;
			case 17: // INWorkoutNameIdentifier.Exercise
				ptr = INWorkoutNameIdentifierExercise;
				break;
			case 18: // INWorkoutNameIdentifier.Hike
				ptr = INWorkoutNameIdentifierHike;
				break;
			case 19: // INWorkoutNameIdentifier.HighIntensityIntervalTraining
				ptr = INWorkoutNameIdentifierHighIntensityIntervalTraining;
				break;
			case 20: // INWorkoutNameIdentifier.Swim
				ptr = INWorkoutNameIdentifierSwim;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Intents.INWorkoutNameIdentifier" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static INWorkoutNameIdentifier GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (INWorkoutNameIdentifierRun))
				return INWorkoutNameIdentifier.Run;
			if (constant.IsEqualTo (INWorkoutNameIdentifierSit))
				return INWorkoutNameIdentifier.Sit;
			if (constant.IsEqualTo (INWorkoutNameIdentifierSteps))
				return INWorkoutNameIdentifier.Steps;
			if (constant.IsEqualTo (INWorkoutNameIdentifierStand))
				return INWorkoutNameIdentifier.Stand;
			if (constant.IsEqualTo (INWorkoutNameIdentifierMove))
				return INWorkoutNameIdentifier.Move;
			if (constant.IsEqualTo (INWorkoutNameIdentifierWalk))
				return INWorkoutNameIdentifier.Walk;
			if (constant.IsEqualTo (INWorkoutNameIdentifierYoga))
				return INWorkoutNameIdentifier.Yoga;
			if (constant.IsEqualTo (INWorkoutNameIdentifierDance))
				return INWorkoutNameIdentifier.Dance;
			if (constant.IsEqualTo (INWorkoutNameIdentifierCrosstraining))
				return INWorkoutNameIdentifier.Crosstraining;
			if (constant.IsEqualTo (INWorkoutNameIdentifierElliptical))
				return INWorkoutNameIdentifier.Elliptical;
			if (constant.IsEqualTo (INWorkoutNameIdentifierRower))
				return INWorkoutNameIdentifier.Rower;
			if (constant.IsEqualTo (INWorkoutNameIdentifierCycle))
				return INWorkoutNameIdentifier.Cycle;
			if (constant.IsEqualTo (INWorkoutNameIdentifierStairs))
				return INWorkoutNameIdentifier.Stairs;
			if (constant.IsEqualTo (INWorkoutNameIdentifierOther))
				return INWorkoutNameIdentifier.Other;
			if (constant.IsEqualTo (INWorkoutNameIdentifierIndoorrun))
				return INWorkoutNameIdentifier.Indoorrun;
			if (constant.IsEqualTo (INWorkoutNameIdentifierIndoorcycle))
				return INWorkoutNameIdentifier.Indoorcycle;
			if (constant.IsEqualTo (INWorkoutNameIdentifierIndoorwalk))
				return INWorkoutNameIdentifier.Indoorwalk;
			if (constant.IsEqualTo (INWorkoutNameIdentifierExercise))
				return INWorkoutNameIdentifier.Exercise;
			if (constant.IsEqualTo (INWorkoutNameIdentifierHike))
				return INWorkoutNameIdentifier.Hike;
			if (constant.IsEqualTo (INWorkoutNameIdentifierHighIntensityIntervalTraining))
				return INWorkoutNameIdentifier.HighIntensityIntervalTraining;
			if (constant.IsEqualTo (INWorkoutNameIdentifierSwim))
				return INWorkoutNameIdentifier.Swim;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Intents.INWorkoutNameIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static INWorkoutNameIdentifier GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Intents.INWorkoutNameIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static INWorkoutNameIdentifier? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Intents.INWorkoutNameIdentifier" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this INWorkoutNameIdentifier[]? values)
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
		internal static INWorkoutNameIdentifier[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<INWorkoutNameIdentifier> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
