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
namespace Foundation {
	/// <summary>Contains keys that identify text checking results.</summary><remarks>To be added.</remarks>
	public unsafe static partial class NSTextChecking  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AirlineKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingAirlineKey",  "Foundation")]
		public static NSString AirlineKey {
			get {
				if (_AirlineKey is null)
					_AirlineKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSTextCheckingAirlineKey")!;
				return _AirlineKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CityKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingCityKey",  "Foundation")]
		public static NSString CityKey {
			get {
				if (_CityKey is null)
					_CityKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSTextCheckingCityKey")!;
				return _CityKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CountryKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingCountryKey",  "Foundation")]
		public static NSString CountryKey {
			get {
				if (_CountryKey is null)
					_CountryKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSTextCheckingCountryKey")!;
				return _CountryKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FlightKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingFlightKey",  "Foundation")]
		public static NSString FlightKey {
			get {
				if (_FlightKey is null)
					_FlightKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSTextCheckingFlightKey")!;
				return _FlightKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _JobTitleKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingJobTitleKey",  "Foundation")]
		public static NSString JobTitleKey {
			get {
				if (_JobTitleKey is null)
					_JobTitleKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSTextCheckingJobTitleKey")!;
				return _JobTitleKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NameKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingNameKey",  "Foundation")]
		public static NSString NameKey {
			get {
				if (_NameKey is null)
					_NameKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSTextCheckingNameKey")!;
				return _NameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OrganizationKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingOrganizationKey",  "Foundation")]
		public static NSString OrganizationKey {
			get {
				if (_OrganizationKey is null)
					_OrganizationKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSTextCheckingOrganizationKey")!;
				return _OrganizationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PhoneKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingPhoneKey",  "Foundation")]
		public static NSString PhoneKey {
			get {
				if (_PhoneKey is null)
					_PhoneKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSTextCheckingPhoneKey")!;
				return _PhoneKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StateKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingStateKey",  "Foundation")]
		public static NSString StateKey {
			get {
				if (_StateKey is null)
					_StateKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSTextCheckingStateKey")!;
				return _StateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StreetKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingStreetKey",  "Foundation")]
		public static NSString StreetKey {
			get {
				if (_StreetKey is null)
					_StreetKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSTextCheckingStreetKey")!;
				return _StreetKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ZipKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingZIPKey",  "Foundation")]
		public static NSString ZipKey {
			get {
				if (_ZipKey is null)
					_ZipKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSTextCheckingZIPKey")!;
				return _ZipKey;
			}
		}
	} /* class NSTextChecking */
}
