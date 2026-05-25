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
namespace MediaExtension {
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos15.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Native]
	public enum MEError : long {
		UnsupportedFeature = -19320,
		AllocationFailure = -19321,
		InvalidParameter = -19322,
		ParsingFailure = -19323,
		InternalFailure = -19324,
		PropertyNotSupported = -19325,
		NoSuchEdit = -19326,
		NoSamples = -19327,
		LocationNotAvailable = -19328,
		EndOfStream = -19329,
		PermissionDenied = -19330,
		ReferenceMissing = -19331,
	}
	/// <summary>Extension methods for the <see cref="global::MediaExtension.MEError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::MediaExtension.MEError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos15.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class MEErrorExtensions {
		[Field ("MediaExtensionErrorDomain", "MediaExtension")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the MediaExtension.MEError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this MEError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.MediaExtension.Handle, "MediaExtensionErrorDomain");
			return _domain;
		}
	}
}
