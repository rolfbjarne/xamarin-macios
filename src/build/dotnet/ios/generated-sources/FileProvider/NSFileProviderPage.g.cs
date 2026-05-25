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
namespace FileProvider {
	/// <summary>A batch of data to return from an enumerator.</summary>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSFileProviderPage  {
		/// <summary>Gets the first page in date order.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData InitialPageSortedByDate {
			get {
				return (Runtime.GetNSObject<NSData> (_InitialPageSortedByDate) as NSData)!;
			}
		}
		/// <summary>Gets the first page in name order.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData InitialPageSortedByName {
			get {
				return (Runtime.GetNSObject<NSData> (_InitialPageSortedByName) as NSData)!;
			}
		}
		/// <summary>Represents the value associated with the constant 'NSFileProviderInitialPageSortedByDate'.</summary>
		[Field ("NSFileProviderInitialPageSortedByDate",  "FileProvider")]
		internal static nint _InitialPageSortedByDate {
			get {
				return Dlfcn.GetIntPtr (Libraries.FileProvider.Handle, "NSFileProviderInitialPageSortedByDate");
			}
		}
		/// <summary>Represents the value associated with the constant 'NSFileProviderInitialPageSortedByName'.</summary>
		[Field ("NSFileProviderInitialPageSortedByName",  "FileProvider")]
		internal static nint _InitialPageSortedByName {
			get {
				return Dlfcn.GetIntPtr (Libraries.FileProvider.Handle, "NSFileProviderInitialPageSortedByName");
			}
		}
	} /* class NSFileProviderPage */
}
