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
namespace AuthenticationServices {
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("macos")]
	public enum ASAuthorizationProviderAuthorizationOperation : int {
		None = 0,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		ConfigurationRemoved = 1,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		DirectRequest = 2,
	}
	/// <summary>Extension methods for the <see cref="global::AuthenticationServices.ASAuthorizationProviderAuthorizationOperation" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class ASAuthorizationProviderAuthorizationOperationExtensions {
		static IntPtr[] values = new IntPtr [2];
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[Field ("ASAuthorizationProviderAuthorizationOperationConfigurationRemoved", "AuthenticationServices")]
		internal unsafe static IntPtr ASAuthorizationProviderAuthorizationOperationConfigurationRemoved {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AuthenticationServices.Handle, "ASAuthorizationProviderAuthorizationOperationConfigurationRemoved", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[Field ("ASAuthorizationProviderAuthorizationOperationDirectRequest", "AuthenticationServices")]
		internal unsafe static IntPtr ASAuthorizationProviderAuthorizationOperationDirectRequest {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AuthenticationServices.Handle, "ASAuthorizationProviderAuthorizationOperationDirectRequest", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this ASAuthorizationProviderAuthorizationOperation self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // ASAuthorizationProviderAuthorizationOperation.ConfigurationRemoved
				ptr = ASAuthorizationProviderAuthorizationOperationConfigurationRemoved;
				break;
			case 2: // ASAuthorizationProviderAuthorizationOperation.DirectRequest
				ptr = ASAuthorizationProviderAuthorizationOperationDirectRequest;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AuthenticationServices.ASAuthorizationProviderAuthorizationOperation" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static ASAuthorizationProviderAuthorizationOperation GetValue (NSString? constant)
		{
			if (constant is null)
				return ASAuthorizationProviderAuthorizationOperation.None;
			if (constant.IsEqualTo (ASAuthorizationProviderAuthorizationOperationConfigurationRemoved))
				return ASAuthorizationProviderAuthorizationOperation.ConfigurationRemoved;
			if (constant.IsEqualTo (ASAuthorizationProviderAuthorizationOperationDirectRequest))
				return ASAuthorizationProviderAuthorizationOperation.DirectRequest;
			return ASAuthorizationProviderAuthorizationOperation.None;
		}
		/// <summary>Retrieves the <see cref="global::AuthenticationServices.ASAuthorizationProviderAuthorizationOperation" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static ASAuthorizationProviderAuthorizationOperation GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AuthenticationServices.ASAuthorizationProviderAuthorizationOperation" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static ASAuthorizationProviderAuthorizationOperation? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AuthenticationServices.ASAuthorizationProviderAuthorizationOperation" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this ASAuthorizationProviderAuthorizationOperation[]? values)
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
		internal static ASAuthorizationProviderAuthorizationOperation[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<ASAuthorizationProviderAuthorizationOperation> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
