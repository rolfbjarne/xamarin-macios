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
	/// <summary>Defines string constants whose values define the names of various <see cref="T:Contacts.CNLabeledValue`1" /> objects.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public unsafe static partial class CNLabelKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DateAnniversary;
		/// <summary>A labeled anniversary.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelDateAnniversary",  "Contacts")]
		public static NSString DateAnniversary {
			get {
				if (_DateAnniversary is null)
					_DateAnniversary = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelDateAnniversary")!;
				return _DateAnniversary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EmailiCloud;
		/// <summary>An iCloud email.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelEmailiCloud",  "Contacts")]
		public static NSString EmailiCloud {
			get {
				if (_EmailiCloud is null)
					_EmailiCloud = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelEmailiCloud")!;
				return _EmailiCloud;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Home;
		/// <summary>The home of the user (as defined in the contact store).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelHome",  "Contacts")]
		public static NSString Home {
			get {
				if (_Home is null)
					_Home = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelHome")!;
				return _Home;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Other;
		/// <summary>A <see cref="T:Contacts.CNLabeledValue`1" /> with an unknown label.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelOther",  "Contacts")]
		public static NSString Other {
			get {
				if (_Other is null)
					_Other = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelOther")!;
				return _Other;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _School;
		/// <summary>Represents the value associated with the constant 'CNLabelSchool'.</summary>
		[Field ("CNLabelSchool",  "Contacts")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString School {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_School is null)
					_School = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelSchool")!;
				return _School;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UrlAddressHomePage;
		/// <summary>The user's home page.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelURLAddressHomePage",  "Contacts")]
		public static NSString UrlAddressHomePage {
			get {
				if (_UrlAddressHomePage is null)
					_UrlAddressHomePage = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelURLAddressHomePage")!;
				return _UrlAddressHomePage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Work;
		/// <summary>The user's work address (as defined in the contacts store).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNLabelWork",  "Contacts")]
		public static NSString Work {
			get {
				if (_Work is null)
					_Work = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNLabelWork")!;
				return _Work;
			}
		}
	} /* class CNLabelKey */
}
