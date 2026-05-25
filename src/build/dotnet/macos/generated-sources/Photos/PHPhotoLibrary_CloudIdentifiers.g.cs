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
namespace Photos {
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class PHPhotoLibrary_CloudIdentifiers  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCloudIdentifierMappingsForLocalIdentifiers_X = "cloudIdentifierMappingsForLocalIdentifiers:";
		static readonly NativeHandle selCloudIdentifierMappingsForLocalIdentifiers_XHandle = Selector.GetHandle ("cloudIdentifierMappingsForLocalIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCloudIdentifiersForLocalIdentifiers_X = "cloudIdentifiersForLocalIdentifiers:";
		static readonly NativeHandle selCloudIdentifiersForLocalIdentifiers_XHandle = Selector.GetHandle ("cloudIdentifiersForLocalIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalIdentifierMappingsForCloudIdentifiers_X = "localIdentifierMappingsForCloudIdentifiers:";
		static readonly NativeHandle selLocalIdentifierMappingsForCloudIdentifiers_XHandle = Selector.GetHandle ("localIdentifierMappingsForCloudIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalIdentifiersForCloudIdentifiers_X = "localIdentifiersForCloudIdentifiers:";
		static readonly NativeHandle selLocalIdentifiersForCloudIdentifiers_XHandle = Selector.GetHandle ("localIdentifiersForCloudIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PHPhotoLibrary");
		[Export ("cloudIdentifierMappingsForLocalIdentifiers:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary<NSString, PHCloudIdentifierMapping> GetCloudIdentifierMappings (this PHPhotoLibrary This, string[] localIdentifiers)
		{
			if (localIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localIdentifiers));
			using var nsa_localIdentifiers = NSArray.FromStrings (localIdentifiers);
			NSDictionary<NSString, PHCloudIdentifierMapping> ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, PHCloudIdentifierMapping>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, selCloudIdentifierMappingsForLocalIdentifiers_XHandle, nsa_localIdentifiers.Handle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="localIdentifiers">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("cloudIdentifiersForLocalIdentifiers:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'cloudIdentifierMappingsForCloudIdentifiers:' instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHCloudIdentifier[] GetCloudIdentifiers (this PHPhotoLibrary This, string[] localIdentifiers)
		{
			if (localIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localIdentifiers));
			using var nsa_localIdentifiers = NSArray.FromStrings (localIdentifiers);
			PHCloudIdentifier[] ret;
			ret = CFArray.ArrayFromHandle<PHCloudIdentifier>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, selCloudIdentifiersForLocalIdentifiers_XHandle, nsa_localIdentifiers.Handle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("localIdentifierMappingsForCloudIdentifiers:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary<PHCloudIdentifier, PHLocalIdentifierMapping> GetLocalIdentifierMappings (this PHPhotoLibrary This, PHCloudIdentifier[] cloudIdentifiers)
		{
			if (cloudIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cloudIdentifiers));
			using var nsa_cloudIdentifiers = NSArray.FromNSObjects (cloudIdentifiers);
			NSDictionary<PHCloudIdentifier, PHLocalIdentifierMapping> ret;
			ret =  Runtime.GetNSObject<NSDictionary<PHCloudIdentifier, PHLocalIdentifierMapping>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, selLocalIdentifierMappingsForCloudIdentifiers_XHandle, nsa_cloudIdentifiers.Handle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="cloudIdentifiers">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("localIdentifiersForCloudIdentifiers:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'localIdentifierMappingsForCloudIdentifiers:' instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetLocalIdentifiers (this PHPhotoLibrary This, PHCloudIdentifier[] cloudIdentifiers)
		{
			if (cloudIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cloudIdentifiers));
			using var nsa_cloudIdentifiers = NSArray.FromNSObjects (cloudIdentifiers);
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, selLocalIdentifiersForCloudIdentifiers_XHandle, nsa_cloudIdentifiers.Handle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LocalIdentifierNotFound;
		/// <summary>Represents the value associated with the constant 'PHLocalIdentifierNotFound'.</summary>
		[Field ("PHLocalIdentifierNotFound",  "Photos")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'PHPhotosError.IdentifierNotFound' instead.")]
		[SupportedOSPlatform ("macos")]
		public static NSString LocalIdentifierNotFound {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'PHPhotosError.IdentifierNotFound' instead.")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_LocalIdentifierNotFound is null)
					_LocalIdentifierNotFound = Dlfcn.GetStringConstant (Libraries.Photos.Handle, "PHLocalIdentifierNotFound")!;
				return _LocalIdentifierNotFound;
			}
		}
	} /* class PHPhotoLibrary_CloudIdentifiers */
}
