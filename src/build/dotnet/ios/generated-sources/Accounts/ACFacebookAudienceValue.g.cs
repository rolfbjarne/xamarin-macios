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
namespace Accounts {
	/// <summary>An enumeration whose values specify the visibility of a post to Facebook.</summary>
	[ObsoletedOSPlatform ("ios11.0", "Use Facebook SDK instead.")]
	[ObsoletedOSPlatform ("macos10.13", "Use Facebook SDK instead.")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use Facebook SDK instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe static partial class ACFacebookAudienceValue  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Everyone;
		/// <summary>Represents the value associated with the constant ACFacebookAudienceEveryone</summary><value></value><remarks>To be added.</remarks>
		[Field ("ACFacebookAudienceEveryone",  "Accounts")]
		public static NSString Everyone {
			get {
				if (_Everyone is null)
					_Everyone = Dlfcn.GetStringConstant (Libraries.Accounts.Handle, "ACFacebookAudienceEveryone")!;
				return _Everyone;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Friends;
		/// <summary>Represents the value associated with the constant ACFacebookAudienceFriends</summary><value></value><remarks>To be added.</remarks>
		[Field ("ACFacebookAudienceFriends",  "Accounts")]
		public static NSString Friends {
			get {
				if (_Friends is null)
					_Friends = Dlfcn.GetStringConstant (Libraries.Accounts.Handle, "ACFacebookAudienceFriends")!;
				return _Friends;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OnlyMe;
		/// <summary>Represents the value associated with the constant ACFacebookAudienceOnlyMe</summary><value></value><remarks>To be added.</remarks>
		[Field ("ACFacebookAudienceOnlyMe",  "Accounts")]
		public static NSString OnlyMe {
			get {
				if (_OnlyMe is null)
					_OnlyMe = Dlfcn.GetStringConstant (Libraries.Accounts.Handle, "ACFacebookAudienceOnlyMe")!;
				return _OnlyMe;
			}
		}
	} /* class ACFacebookAudienceValue */
}
