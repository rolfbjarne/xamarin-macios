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
namespace Vision {
	/// <summary>Enumerates errors associated with Vision requests.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum VNErrorCode : long {
		TuriCore = -1,
		/// <summary>Indicates that no error occurred.</summary>
		Ok = 0,
		/// <summary>Indicates that the request was cancelled, either by the user or programmatically.</summary>
		RequestCancelled = 1,
		/// <summary>Indicates an error relating to the image format.</summary>
		InvalidFormat = 2,
		/// <summary>Indicates that the request failed in the underlying Core ML model.</summary>
		OperationFailed = 3,
		/// <summary>Indicates an error relating to either an array or normalized units.</summary>
		OutOfBoundsError = 4,
		/// <summary>Indicates an error relating to request options.</summary>
		InvalidOption = 5,
		/// <summary>Indicates an error relating to the IO of the image, images, or underlying Core ML model.</summary>
		IOError = 6,
		/// <summary>Indicates that a required option was not specified by the developer.</summary>
		MissingOption = 7,
		/// <summary>Indicates that the underlying model can not answer the request.</summary>
		NotImplemented = 8,
		/// <summary>An error occurred within the Vision system services.</summary>
		InternalError = 9,
		/// <summary>Indicates that the request cannot be completed with the memory available to the app.</summary>
		OutOfMemory = 10,
		/// <summary>Indicates an error of a non-determined type.</summary>
		UnknownError = 11,
		/// <summary>Indicates that the requested operation is not supported on this image or image sequence.</summary>
		InvalidOperation = 12,
		/// <summary>Indicates a non-specific error relating to the image.</summary>
		InvalidImage = 13,
		/// <summary>An incompatible argument was passed to a vision request.</summary>
		InvalidArgument = 14,
		/// <summary>Indicates that the underlying CoreML model is invalid or incompatible with the request.</summary>
		InvalidModel = 15,
		/// <summary>To be added.</summary>
		UnsupportedRevision = 16,
		DataUnavailable = 17,
		TimeStampNotFound = 18,
		UnsupportedRequest = 19,
		Timeout = 20,
		UnsupportedComputeStage = 21,
		UnsupportedComputeDevice = 22,
	}
	/// <summary>Extension methods for the <see cref="global::Vision.VNErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::Vision.VNErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class VNErrorCodeExtensions {
		[Field ("VNErrorDomain", "Vision")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the Vision.VNErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this VNErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.Vision.Handle, "VNErrorDomain");
			return _domain;
		}
	}
}
