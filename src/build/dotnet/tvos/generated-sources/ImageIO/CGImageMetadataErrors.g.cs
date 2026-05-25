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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace ImageIO {
	/// <summary>Enumeration of errors relating to metadata manipulation.</summary>
	public enum CGImageMetadataErrors : int {
		/// <summary>To be added.</summary>
		Unknown = 0,
		/// <summary>To be added.</summary>
		UnsupportedFormat = 1,
		/// <summary>To be added.</summary>
		BadArgument = 2,
		/// <summary>To be added.</summary>
		ConflictingArguments = 3,
		/// <summary>To be added.</summary>
		PrefixConflict = 4,
	}
	/// <summary>Extension methods for the <see cref="global::ImageIO.CGImageMetadataErrors" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::ImageIO.CGImageMetadataErrors" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CGImageMetadataErrorsExtensions {
		[Field ("kCFErrorDomainCGImageMetadata", "ImageIO")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the ImageIO.CGImageMetadataErrors value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this CGImageMetadataErrors self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCFErrorDomainCGImageMetadata");
			return _domain;
		}
	}
}
