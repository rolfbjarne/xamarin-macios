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
namespace FileProviderUI {
	/// <summary>Enumerates file provider UI extension errors.</summary>
	[Native]
	public enum FPUIExtensionErrorCode : ulong {
		/// <summary>Indicates that the user cancelled an action.</summary>
		UserCancelled = 0,
		/// <summary>Indicates that a requested action failed.</summary>
		Failed = 1,
	}
	/// <summary>Extension methods for the <see cref="global::FileProviderUI.FPUIExtensionErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::FileProviderUI.FPUIExtensionErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class FPUIExtensionErrorCodeExtensions {
		[Field ("FPUIErrorDomain", "FileProviderUI")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the FileProviderUI.FPUIExtensionErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this FPUIExtensionErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.FileProviderUI.Handle, "FPUIErrorDomain");
			return _domain;
		}
	}
}
