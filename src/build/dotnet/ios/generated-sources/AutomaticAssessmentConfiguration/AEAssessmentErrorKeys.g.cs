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
namespace AutomaticAssessmentConfiguration {
	public unsafe static partial class AEAssessmentErrorKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NotInstalledParticipants;
		/// <summary>Represents the value associated with the constant 'AENotInstalledParticipantsKey'.</summary>
		[Field ("AENotInstalledParticipantsKey",  "AutomaticAssessmentConfiguration")]
		public static NSString NotInstalledParticipants {
			get {
				if (_NotInstalledParticipants is null)
					_NotInstalledParticipants = Dlfcn.GetStringConstant (Libraries.AutomaticAssessmentConfiguration.Handle, "AENotInstalledParticipantsKey")!;
				return _NotInstalledParticipants;
			}
			set {
				Dlfcn.SetString (Libraries.AutomaticAssessmentConfiguration.Handle, "AENotInstalledParticipantsKey", value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RestrictedSystemParticipants;
		/// <summary>Represents the value associated with the constant 'AERestrictedSystemParticipantsKey'.</summary>
		[Field ("AERestrictedSystemParticipantsKey",  "AutomaticAssessmentConfiguration")]
		public static NSString RestrictedSystemParticipants {
			get {
				if (_RestrictedSystemParticipants is null)
					_RestrictedSystemParticipants = Dlfcn.GetStringConstant (Libraries.AutomaticAssessmentConfiguration.Handle, "AERestrictedSystemParticipantsKey")!;
				return _RestrictedSystemParticipants;
			}
			set {
				Dlfcn.SetString (Libraries.AutomaticAssessmentConfiguration.Handle, "AERestrictedSystemParticipantsKey", value);
			}
		}
	} /* class AEAssessmentErrorKeys */
}
