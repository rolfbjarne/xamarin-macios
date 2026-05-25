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
namespace CoreText {
	/// <summary>An enumeration whose values specify errors relating to operations on <see cref="T:CoreText.CTFontManager" />.</summary>
	[Native]
	public enum CTFontManagerError : long {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		FileNotFount = 101,
		/// <summary>To be added.</summary>
		InsufficientPermissions = 102,
		/// <summary>To be added.</summary>
		UnrecognizedFormat = 103,
		/// <summary>To be added.</summary>
		InvalidFontData = 104,
		/// <summary>To be added.</summary>
		AlreadyRegistered = 105,
		ExceededResourceLimit = 106,
		AssetNotFound = 107,
		/// <summary>To be added.</summary>
		NotRegistered = 201,
		/// <summary>To be added.</summary>
		InUse = 202,
		/// <summary>To be added.</summary>
		SystemRequired = 203,
		RegistrationFailed = 301,
		MissingEntitlement = 302,
		InsufficientInfo = 303,
		CancelledByUser = 304,
		DuplicatedName = 305,
		InvalidFilePath = 306,
		UnsupportedScope = 307,
	}
	/// <summary>Extension methods for the <see cref="global::CoreText.CTFontManagerError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::CoreText.CTFontManagerError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CTFontManagerErrorExtensions {
		[Field ("kCTFontManagerErrorDomain", "CoreText")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the CoreText.CTFontManagerError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this CTFontManagerError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontManagerErrorDomain");
			return _domain;
		}
	}
}
