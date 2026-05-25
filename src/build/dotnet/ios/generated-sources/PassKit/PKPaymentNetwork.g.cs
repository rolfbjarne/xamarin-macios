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
namespace PassKit {
	/// <summary>Standard values returned by <see cref="P:PassKit.PKPaymentToken.PaymentNetwork" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class PKPaymentNetwork  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Amex;
		/// <summary>Represents the value associated with the constant PKPaymentNetworkAmex</summary><value></value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkAmex",  "PassKit")]
		public static NSString Amex {
			get {
				if (_Amex is null)
					_Amex = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkAmex")!;
				return _Amex;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Bancomat;
		/// <summary>Represents the value associated with the constant 'PKPaymentNetworkBancomat'.</summary>
		[Field ("PKPaymentNetworkBancomat",  "PassKit")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public static NSString Bancomat {
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				if (_Bancomat is null)
					_Bancomat = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkBancomat")!;
				return _Bancomat;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Bancontact;
		/// <summary>Represents the value associated with the constant 'PKPaymentNetworkBancontact'.</summary>
		[Field ("PKPaymentNetworkBancontact",  "PassKit")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public static NSString Bancontact {
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				if (_Bancontact is null)
					_Bancontact = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkBancontact")!;
				return _Bancontact;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BankAxept;
		/// <summary>Represents the value associated with the constant 'PKPaymentNetworkBankAxept'.</summary>
		[Field ("PKPaymentNetworkBankAxept",  "PassKit")]
		[SupportedOSPlatform ("macos14.5")]
		[SupportedOSPlatform ("ios17.5")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.5")]
		public static NSString BankAxept {
			[SupportedOSPlatform ("macos14.5")]
			[SupportedOSPlatform ("ios17.5")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst17.5")]
			get {
				if (_BankAxept is null)
					_BankAxept = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkBankAxept")!;
				return _BankAxept;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Barcode;
		/// <summary>Represents the value associated with the constant 'PKPaymentNetworkBarcode'.</summary>
		[Field ("PKPaymentNetworkBarcode",  "PassKit")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Barcode {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Barcode is null)
					_Barcode = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkBarcode")!;
				return _Barcode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CarteBancaire;
		/// <summary>Developers should not use this deprecated property. Developers should use 'CartesBancaires' instead.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkCarteBancaire",  "PassKit")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'CartesBancaires' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'CartesBancaires' instead.")]
		[SupportedOSPlatform ("ios")]
		public static NSString CarteBancaire {
			[UnsupportedOSPlatform ("macos")]
			[ObsoletedOSPlatform ("ios11.0", "Use 'CartesBancaires' instead.")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'CartesBancaires' instead.")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_CarteBancaire is null)
					_CarteBancaire = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkCarteBancaire")!;
				return _CarteBancaire;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CarteBancaires;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkCarteBancaires",  "PassKit")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.2", "Use 'CartesBancaires' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'CartesBancaires' instead.")]
		[SupportedOSPlatform ("ios")]
		public static NSString CarteBancaires {
			[UnsupportedOSPlatform ("macos")]
			[ObsoletedOSPlatform ("ios11.2", "Use 'CartesBancaires' instead.")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'CartesBancaires' instead.")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_CarteBancaires is null)
					_CarteBancaires = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkCarteBancaires")!;
				return _CarteBancaires;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CartesBancaires;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkCartesBancaires",  "PassKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString CartesBancaires {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CartesBancaires is null)
					_CartesBancaires = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkCartesBancaires")!;
				return _CartesBancaires;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChinaUnionPay;
		/// <summary>Represents the value associated with the constant PKPaymentNetworkChinaUnionPay.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkChinaUnionPay",  "PassKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString ChinaUnionPay {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ChinaUnionPay is null)
					_ChinaUnionPay = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkChinaUnionPay")!;
				return _ChinaUnionPay;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Conecs;
		/// <summary>Represents the value associated with the constant 'PKPaymentNetworkConecs'.</summary>
		[Field ("PKPaymentNetworkConecs",  "PassKit")]
		[SupportedOSPlatform ("macos26.2")]
		[SupportedOSPlatform ("ios26.2")]
		[SupportedOSPlatform ("maccatalyst26.2")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString Conecs {
			[SupportedOSPlatform ("macos26.2")]
			[SupportedOSPlatform ("ios26.2")]
			[SupportedOSPlatform ("maccatalyst26.2")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_Conecs is null)
					_Conecs = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkConecs")!;
				return _Conecs;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Dankort;
		/// <summary>Represents the value associated with the constant 'PKPaymentNetworkDankort'.</summary>
		[Field ("PKPaymentNetworkDankort",  "PassKit")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		public static NSString Dankort {
			[SupportedOSPlatform ("macos12.3")]
			[SupportedOSPlatform ("ios15.4")]
			[SupportedOSPlatform ("maccatalyst15.4")]
			get {
				if (_Dankort is null)
					_Dankort = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkDankort")!;
				return _Dankort;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Discover;
		/// <summary>The Discover payment network.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkDiscover",  "PassKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString Discover {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Discover is null)
					_Discover = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkDiscover")!;
				return _Discover;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Eftpos;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkEftpos",  "PassKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString Eftpos {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Eftpos is null)
					_Eftpos = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkEftpos")!;
				return _Eftpos;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElCorteIngles;
		/// <summary>Represents the value associated with the constant PKPaymentNetworkElCorteIngles.</summary>
		[Field ("PKPaymentNetworkElCorteIngles",  "PassKit")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString ElCorteIngles {
			[SupportedOSPlatform ("macos26.4")]
			[SupportedOSPlatform ("ios26.4")]
			[SupportedOSPlatform ("maccatalyst26.4")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_ElCorteIngles is null)
					_ElCorteIngles = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkElCorteIngles")!;
				return _ElCorteIngles;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Electron;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkElectron",  "PassKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString Electron {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Electron is null)
					_Electron = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkElectron")!;
				return _Electron;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Elo;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkElo",  "PassKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString Elo {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Elo is null)
					_Elo = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkElo")!;
				return _Elo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Girocard;
		/// <summary>Represents the value associated with the constant 'PKPaymentNetworkGirocard'.</summary>
		[Field ("PKPaymentNetworkGirocard",  "PassKit")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Girocard {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Girocard is null)
					_Girocard = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkGirocard")!;
				return _Girocard;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Himyan;
		/// <summary>Represents the value associated with the constant 'PKPaymentNetworkHimyan'.</summary>
		[Field ("PKPaymentNetworkHimyan",  "PassKit")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("ios18.4")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		public static NSString Himyan {
			[SupportedOSPlatform ("macos15.4")]
			[SupportedOSPlatform ("ios18.4")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst18.4")]
			get {
				if (_Himyan is null)
					_Himyan = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkHimyan")!;
				return _Himyan;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IDCredit;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkIDCredit",  "PassKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString IDCredit {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_IDCredit is null)
					_IDCredit = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkIDCredit")!;
				return _IDCredit;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Interac;
		/// <summary>Represents the value associated with the constant PKPaymentNetworkInterac.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkInterac",  "PassKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString Interac {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Interac is null)
					_Interac = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkInterac")!;
				return _Interac;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Jaywan;
		/// <summary>Represents the value associated with the constant 'PKPaymentNetworkJaywan'.</summary>
		[Field ("PKPaymentNetworkJaywan",  "PassKit")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("ios18.4")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		public static NSString Jaywan {
			[SupportedOSPlatform ("macos15.4")]
			[SupportedOSPlatform ("ios18.4")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst18.4")]
			get {
				if (_Jaywan is null)
					_Jaywan = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkJaywan")!;
				return _Jaywan;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Jcb;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkJCB",  "PassKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString Jcb {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Jcb is null)
					_Jcb = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkJCB")!;
				return _Jcb;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Mada;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkMada",  "PassKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString Mada {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Mada is null)
					_Mada = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkMada")!;
				return _Mada;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Maestro;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkMaestro",  "PassKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString Maestro {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Maestro is null)
					_Maestro = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkMaestro")!;
				return _Maestro;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MasterCard;
		/// <summary>Represents the value associated with the constant PKPaymentNetworkMasterCard</summary><value></value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkMasterCard",  "PassKit")]
		public static NSString MasterCard {
			get {
				if (_MasterCard is null)
					_MasterCard = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkMasterCard")!;
				return _MasterCard;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Meeza;
		/// <summary>Represents the value associated with the constant 'PKPaymentNetworkMeeza'.</summary>
		[Field ("PKPaymentNetworkMeeza",  "PassKit")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public static NSString Meeza {
			[SupportedOSPlatform ("macos14.4")]
			[SupportedOSPlatform ("ios17.4")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst17.4")]
			get {
				if (_Meeza is null)
					_Meeza = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkMeeza")!;
				return _Meeza;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Mir;
		/// <summary>Represents the value associated with the constant 'PKPaymentNetworkMir'.</summary>
		[Field ("PKPaymentNetworkMir",  "PassKit")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Mir {
			[SupportedOSPlatform ("ios14.5")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Mir is null)
					_Mir = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkMir")!;
				return _Mir;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MyDebit;
		/// <summary>Represents the value associated with the constant 'PKPaymentNetworkMyDebit'.</summary>
		[Field ("PKPaymentNetworkMyDebit",  "PassKit")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString MyDebit {
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_MyDebit is null)
					_MyDebit = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkMyDebit")!;
				return _MyDebit;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Nanaco;
		/// <summary>Represents the value associated with the constant 'PKPaymentNetworkNanaco'.</summary>
		[Field ("PKPaymentNetworkNanaco",  "PassKit")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Nanaco {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Nanaco is null)
					_Nanaco = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkNanaco")!;
				return _Nanaco;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Napas;
		/// <summary>Represents the value associated with the constant 'PKPaymentNetworkNAPAS'.</summary>
		[Field ("PKPaymentNetworkNAPAS",  "PassKit")]
		[SupportedOSPlatform ("macos14.5")]
		[SupportedOSPlatform ("ios17.5")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.5")]
		public static NSString Napas {
			[SupportedOSPlatform ("macos14.5")]
			[SupportedOSPlatform ("ios17.5")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst17.5")]
			get {
				if (_Napas is null)
					_Napas = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkNAPAS")!;
				return _Napas;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PKPaymentNetworkPostFinance;
		/// <summary>Represents the value associated with the constant 'PKPaymentNetworkPostFinance'.</summary>
		[Field ("PKPaymentNetworkPostFinance",  "PassKit")]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		public static NSString PKPaymentNetworkPostFinance {
			[SupportedOSPlatform ("macos13.3")]
			[SupportedOSPlatform ("ios16.4")]
			[SupportedOSPlatform ("maccatalyst16.4")]
			get {
				if (_PKPaymentNetworkPostFinance is null)
					_PKPaymentNetworkPostFinance = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkPostFinance")!;
				return _PKPaymentNetworkPostFinance;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PagoBancomat;
		/// <summary>Represents the value associated with the constant 'PKPaymentNetworkPagoBancomat'.</summary>
		[Field ("PKPaymentNetworkPagoBancomat",  "PassKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString PagoBancomat {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_PagoBancomat is null)
					_PagoBancomat = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkPagoBancomat")!;
				return _PagoBancomat;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PrivateLabel;
		/// <summary>Represents the value associated with the constant PKPaymentNetworkPrivateLabel.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkPrivateLabel",  "PassKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString PrivateLabel {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PrivateLabel is null)
					_PrivateLabel = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkPrivateLabel")!;
				return _PrivateLabel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuicPay;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkQuicPay",  "PassKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString QuicPay {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_QuicPay is null)
					_QuicPay = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkQuicPay")!;
				return _QuicPay;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Suica;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkSuica",  "PassKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString Suica {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Suica is null)
					_Suica = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkSuica")!;
				return _Suica;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Tmoney;
		/// <summary>Represents the value associated with the constant 'PKPaymentNetworkTmoney'.</summary>
		[Field ("PKPaymentNetworkTmoney",  "PassKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString Tmoney {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_Tmoney is null)
					_Tmoney = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkTmoney")!;
				return _Tmoney;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VPay;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkVPay",  "PassKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString VPay {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_VPay is null)
					_VPay = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkVPay")!;
				return _VPay;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Visa;
		/// <summary>Represents the value associated with the constant PKPaymentNetworkVisa</summary><value></value><remarks>To be added.</remarks>
		[Field ("PKPaymentNetworkVisa",  "PassKit")]
		public static NSString Visa {
			get {
				if (_Visa is null)
					_Visa = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkVisa")!;
				return _Visa;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Waon;
		/// <summary>Represents the value associated with the constant 'PKPaymentNetworkWaon'.</summary>
		[Field ("PKPaymentNetworkWaon",  "PassKit")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Waon {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Waon is null)
					_Waon = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPaymentNetworkWaon")!;
				return _Waon;
			}
		}
	} /* class PKPaymentNetwork */
}
