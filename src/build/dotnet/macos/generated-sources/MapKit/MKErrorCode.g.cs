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
namespace MapKit {
	/// <summary>An enumeration whose values represent various errors that can occur with <see cref="M:MapKit.MKDirections.CalculateDirections(MapKit.MKDirectionsHandler)" /> and <see cref="M:MapKit.MKDirections.CalculateETA(MapKit.MKETAHandler)" />.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum MKErrorCode : ulong {
		/// <summary>To be added.</summary>
		Unknown = 1,
		/// <summary>To be added.</summary>
		ServerFailure = 2,
		/// <summary>To be added.</summary>
		LoadingThrottled = 3,
		/// <summary>To be added.</summary>
		PlacemarkNotFound = 4,
		/// <summary>To be added.</summary>
		DirectionsNotFound = 5,
		DecodingFailed = 6,
	}
	/// <summary>Extension methods for the <see cref="global::MapKit.MKErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::MapKit.MKErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class MKErrorCodeExtensions {
		[Field ("MKErrorDomain", "MapKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the MapKit.MKErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this MKErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.MapKit.Handle, "MKErrorDomain");
			return _domain;
		}
	}
}
