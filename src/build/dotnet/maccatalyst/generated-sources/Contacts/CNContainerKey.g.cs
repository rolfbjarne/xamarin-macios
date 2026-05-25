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
namespace Contacts {
	/// <summary>Provides string constants whose values should be used as keys when referencing properties of <see cref="T:Contacts.CNContainer" /> objects.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public unsafe static partial class CNContainerKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Identifier;
		/// <summary>The key for the <see cref="P:Contacts.CNContainer.Identifier" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContainerIdentifierKey",  "Contacts")]
		public static NSString Identifier {
			get {
				if (_Identifier is null)
					_Identifier = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContainerIdentifierKey")!;
				return _Identifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Name;
		/// <summary>The key for the <see cref="P:Contacts.CNContainer.Name" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContainerNameKey",  "Contacts")]
		public static NSString Name {
			get {
				if (_Name is null)
					_Name = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContainerNameKey")!;
				return _Name;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Type;
		/// <summary>The key for the <see cref="P:Contacts.CNContainer.ContainerType" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContainerTypeKey",  "Contacts")]
		public static NSString Type {
			get {
				if (_Type is null)
					_Type = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContainerTypeKey")!;
				return _Type;
			}
		}
	} /* class CNContainerKey */
}
