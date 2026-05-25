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
namespace CoreMotion {
	/// <summary>Type for CoreMotion errors.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public enum CMError : int {
		/// <summary>No error.</summary>
		Null = 100,
		/// <summary>The device must move to generate motion data.</summary>
		DeviceRequiresMovement = 101,
		/// <summary>The device does not know the direction to true north.</summary>
		TrueNorthNotAvailable = 102,
		/// <summary>An error of unknown type.</summary>
		Unknown = 103,
		/// <summary>Motion data is not available on this device.</summary>
		MotionActivityNotAvailable = 104,
		/// <summary>The user has not authorized the app to access motion data.</summary>
		MotionActivityNotAuthorized = 105,
		/// <summary>The app does not have a properly-configured entitlements file.</summary>
		MotionActivityNotEntitled = 106,
		/// <summary>An invalid parameter was specified.</summary>
		InvalidParameter = 107,
		/// <summary>An invalid action was specified.</summary>
		InvalidAction = 108,
		/// <summary>The requested data are not available.</summary>
		NotAvailable = 109,
		/// <summary>The app does not have the proper entitlements file.</summary>
		NotEntitled = 110,
		/// <summary>The app is not currently authorized to access motion data.</summary>
		NotAuthorized = 111,
		NilData = 112,
		Size = 113,
	}
	/// <summary>Extension methods for the <see cref="global::CoreMotion.CMError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::CoreMotion.CMError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CMErrorExtensions {
		[Field ("CMErrorDomain", "CoreMotion")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the CoreMotion.CMError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this CMError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.CoreMotion.Handle, "CMErrorDomain");
			return _domain;
		}
	}
}
