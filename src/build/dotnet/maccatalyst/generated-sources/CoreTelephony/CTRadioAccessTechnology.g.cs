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
namespace CoreTelephony {
	/// <summary>Defines constants describing various telephone radio technogies.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe static partial class CTRadioAccessTechnology  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CDMA1x;
		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyCDMA1x</summary><value></value><remarks>To be added.</remarks>
		[Field ("CTRadioAccessTechnologyCDMA1x",  "CoreTelephony")]
		public static NSString CDMA1x {
			get {
				if (_CDMA1x is null)
					_CDMA1x = Dlfcn.GetStringConstant (Libraries.CoreTelephony.Handle, "CTRadioAccessTechnologyCDMA1x")!;
				return _CDMA1x;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CDMAEVDORev0;
		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyCDMAEVDORev0</summary><value></value><remarks>To be added.</remarks>
		[Field ("CTRadioAccessTechnologyCDMAEVDORev0",  "CoreTelephony")]
		public static NSString CDMAEVDORev0 {
			get {
				if (_CDMAEVDORev0 is null)
					_CDMAEVDORev0 = Dlfcn.GetStringConstant (Libraries.CoreTelephony.Handle, "CTRadioAccessTechnologyCDMAEVDORev0")!;
				return _CDMAEVDORev0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CDMAEVDORevA;
		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyCDMAEVDORevA</summary><value></value><remarks>To be added.</remarks>
		[Field ("CTRadioAccessTechnologyCDMAEVDORevA",  "CoreTelephony")]
		public static NSString CDMAEVDORevA {
			get {
				if (_CDMAEVDORevA is null)
					_CDMAEVDORevA = Dlfcn.GetStringConstant (Libraries.CoreTelephony.Handle, "CTRadioAccessTechnologyCDMAEVDORevA")!;
				return _CDMAEVDORevA;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CDMAEVDORevB;
		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyCDMAEVDORevB</summary><value></value><remarks>To be added.</remarks>
		[Field ("CTRadioAccessTechnologyCDMAEVDORevB",  "CoreTelephony")]
		public static NSString CDMAEVDORevB {
			get {
				if (_CDMAEVDORevB is null)
					_CDMAEVDORevB = Dlfcn.GetStringConstant (Libraries.CoreTelephony.Handle, "CTRadioAccessTechnologyCDMAEVDORevB")!;
				return _CDMAEVDORevB;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EHRPD;
		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyeHRPD</summary><value></value><remarks>To be added.</remarks>
		[Field ("CTRadioAccessTechnologyeHRPD",  "CoreTelephony")]
		public static NSString EHRPD {
			get {
				if (_EHRPD is null)
					_EHRPD = Dlfcn.GetStringConstant (Libraries.CoreTelephony.Handle, "CTRadioAccessTechnologyeHRPD")!;
				return _EHRPD;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Edge;
		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyEdge</summary><value></value><remarks>To be added.</remarks>
		[Field ("CTRadioAccessTechnologyEdge",  "CoreTelephony")]
		public static NSString Edge {
			get {
				if (_Edge is null)
					_Edge = Dlfcn.GetStringConstant (Libraries.CoreTelephony.Handle, "CTRadioAccessTechnologyEdge")!;
				return _Edge;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPRS;
		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyGPRS</summary><value></value><remarks>To be added.</remarks>
		[Field ("CTRadioAccessTechnologyGPRS",  "CoreTelephony")]
		public static NSString GPRS {
			get {
				if (_GPRS is null)
					_GPRS = Dlfcn.GetStringConstant (Libraries.CoreTelephony.Handle, "CTRadioAccessTechnologyGPRS")!;
				return _GPRS;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HSDPA;
		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyHSDPA</summary><value></value><remarks>To be added.</remarks>
		[Field ("CTRadioAccessTechnologyHSDPA",  "CoreTelephony")]
		public static NSString HSDPA {
			get {
				if (_HSDPA is null)
					_HSDPA = Dlfcn.GetStringConstant (Libraries.CoreTelephony.Handle, "CTRadioAccessTechnologyHSDPA")!;
				return _HSDPA;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HSUPA;
		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyHSUPA</summary><value></value><remarks>To be added.</remarks>
		[Field ("CTRadioAccessTechnologyHSUPA",  "CoreTelephony")]
		public static NSString HSUPA {
			get {
				if (_HSUPA is null)
					_HSUPA = Dlfcn.GetStringConstant (Libraries.CoreTelephony.Handle, "CTRadioAccessTechnologyHSUPA")!;
				return _HSUPA;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LTE;
		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyLTE</summary><value></value><remarks>To be added.</remarks>
		[Field ("CTRadioAccessTechnologyLTE",  "CoreTelephony")]
		public static NSString LTE {
			get {
				if (_LTE is null)
					_LTE = Dlfcn.GetStringConstant (Libraries.CoreTelephony.Handle, "CTRadioAccessTechnologyLTE")!;
				return _LTE;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NR;
		/// <summary>Represents the value associated with the constant 'CTRadioAccessTechnologyNR'.</summary>
		[Field ("CTRadioAccessTechnologyNR",  "CoreTelephony")]
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString NR {
			[SupportedOSPlatform ("ios14.1")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_NR is null)
					_NR = Dlfcn.GetStringConstant (Libraries.CoreTelephony.Handle, "CTRadioAccessTechnologyNR")!;
				return _NR;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NRNsa;
		/// <summary>Represents the value associated with the constant 'CTRadioAccessTechnologyNRNSA'.</summary>
		[Field ("CTRadioAccessTechnologyNRNSA",  "CoreTelephony")]
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString NRNsa {
			[SupportedOSPlatform ("ios14.1")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_NRNsa is null)
					_NRNsa = Dlfcn.GetStringConstant (Libraries.CoreTelephony.Handle, "CTRadioAccessTechnologyNRNSA")!;
				return _NRNsa;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WCDMA;
		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyWCDMA</summary><value></value><remarks>To be added.</remarks>
		[Field ("CTRadioAccessTechnologyWCDMA",  "CoreTelephony")]
		public static NSString WCDMA {
			get {
				if (_WCDMA is null)
					_WCDMA = Dlfcn.GetStringConstant (Libraries.CoreTelephony.Handle, "CTRadioAccessTechnologyWCDMA")!;
				return _WCDMA;
			}
		}
	} /* class CTRadioAccessTechnology */
}
