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
namespace ClassKit {
	/// <summary>Enumerates topics for contexts.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public enum CLSContextTopic : int {
		/// <summary>Indicates mathematics.</summary>
		Math = 0,
		/// <summary>Indicates science.</summary>
		Science = 1,
		/// <summary>Indicates literacy and/or writing.</summary>
		LiteracyAndWriting = 2,
		/// <summary>Indicates world languages.</summary>
		WorldLanguage = 3,
		/// <summary>Indicates social sciences.</summary>
		SocialScience = 4,
		/// <summary>Indicates computer science and/or engineering.</summary>
		ComputerScienceAndEngineering = 5,
		/// <summary>Indicates arts and/or music.</summary>
		ArtsAndMusic = 6,
		/// <summary>Indicates health and fitness.</summary>
		HealthAndFitness = 7,
		None = 1000,
	}
	/// <summary>Extension methods for the <see cref="global::ClassKit.CLSContextTopic" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CLSContextTopicExtensions {
		static IntPtr[] values = new IntPtr [8];
		[Field ("CLSContextTopicMath", "ClassKit")]
		internal unsafe static IntPtr CLSContextTopicMath {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.ClassKit.Handle, "CLSContextTopicMath", storage);
			}
		}
		[Field ("CLSContextTopicScience", "ClassKit")]
		internal unsafe static IntPtr CLSContextTopicScience {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.ClassKit.Handle, "CLSContextTopicScience", storage);
			}
		}
		[Field ("CLSContextTopicLiteracyAndWriting", "ClassKit")]
		internal unsafe static IntPtr CLSContextTopicLiteracyAndWriting {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.ClassKit.Handle, "CLSContextTopicLiteracyAndWriting", storage);
			}
		}
		[Field ("CLSContextTopicWorldLanguage", "ClassKit")]
		internal unsafe static IntPtr CLSContextTopicWorldLanguage {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.ClassKit.Handle, "CLSContextTopicWorldLanguage", storage);
			}
		}
		[Field ("CLSContextTopicSocialScience", "ClassKit")]
		internal unsafe static IntPtr CLSContextTopicSocialScience {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.ClassKit.Handle, "CLSContextTopicSocialScience", storage);
			}
		}
		[Field ("CLSContextTopicComputerScienceAndEngineering", "ClassKit")]
		internal unsafe static IntPtr CLSContextTopicComputerScienceAndEngineering {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.ClassKit.Handle, "CLSContextTopicComputerScienceAndEngineering", storage);
			}
		}
		[Field ("CLSContextTopicArtsAndMusic", "ClassKit")]
		internal unsafe static IntPtr CLSContextTopicArtsAndMusic {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.ClassKit.Handle, "CLSContextTopicArtsAndMusic", storage);
			}
		}
		[Field ("CLSContextTopicHealthAndFitness", "ClassKit")]
		internal unsafe static IntPtr CLSContextTopicHealthAndFitness {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.ClassKit.Handle, "CLSContextTopicHealthAndFitness", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CLSContextTopic self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CLSContextTopic.Math
				ptr = CLSContextTopicMath;
				break;
			case 1: // CLSContextTopic.Science
				ptr = CLSContextTopicScience;
				break;
			case 2: // CLSContextTopic.LiteracyAndWriting
				ptr = CLSContextTopicLiteracyAndWriting;
				break;
			case 3: // CLSContextTopic.WorldLanguage
				ptr = CLSContextTopicWorldLanguage;
				break;
			case 4: // CLSContextTopic.SocialScience
				ptr = CLSContextTopicSocialScience;
				break;
			case 5: // CLSContextTopic.ComputerScienceAndEngineering
				ptr = CLSContextTopicComputerScienceAndEngineering;
				break;
			case 6: // CLSContextTopic.ArtsAndMusic
				ptr = CLSContextTopicArtsAndMusic;
				break;
			case 7: // CLSContextTopic.HealthAndFitness
				ptr = CLSContextTopicHealthAndFitness;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::ClassKit.CLSContextTopic" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CLSContextTopic GetValue (NSString? constant)
		{
			if (constant is null)
				return CLSContextTopic.None;
			if (constant.IsEqualTo (CLSContextTopicMath))
				return CLSContextTopic.Math;
			if (constant.IsEqualTo (CLSContextTopicScience))
				return CLSContextTopic.Science;
			if (constant.IsEqualTo (CLSContextTopicLiteracyAndWriting))
				return CLSContextTopic.LiteracyAndWriting;
			if (constant.IsEqualTo (CLSContextTopicWorldLanguage))
				return CLSContextTopic.WorldLanguage;
			if (constant.IsEqualTo (CLSContextTopicSocialScience))
				return CLSContextTopic.SocialScience;
			if (constant.IsEqualTo (CLSContextTopicComputerScienceAndEngineering))
				return CLSContextTopic.ComputerScienceAndEngineering;
			if (constant.IsEqualTo (CLSContextTopicArtsAndMusic))
				return CLSContextTopic.ArtsAndMusic;
			if (constant.IsEqualTo (CLSContextTopicHealthAndFitness))
				return CLSContextTopic.HealthAndFitness;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::ClassKit.CLSContextTopic" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CLSContextTopic GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::ClassKit.CLSContextTopic" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CLSContextTopic? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::ClassKit.CLSContextTopic" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CLSContextTopic[]? values)
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
		internal static CLSContextTopic[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CLSContextTopic> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
