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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CallKit {
	/// <summary>Enumerates transaction request errors.</summary>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum CXErrorCodeRequestTransactionError : long {
		/// <summary>An unknown error occurred.</summary>
		Unknown = 0,
		/// <summary>To be added.</summary>
		Unentitled = 1,
		/// <summary>The call provider was unknown.</summary>
		UnknownCallProvider = 2,
		/// <summary>The transaction was empty.</summary>
		EmptyTransaction = 3,
		/// <summary>The call UUID was unknown.</summary>
		UnknownCallUuid = 4,
		/// <summary>To be added.</summary>
		CallUuidAlreadyExists = 5,
		/// <summary>The action was invalid.</summary>
		InvalidAction = 6,
		/// <summary>The maximum number of call groups was reached.</summary>
		MaximumCallGroupsReached = 7,
		CallIsProtected = 8,
	}
	/// <summary>Extension methods for the <see cref="global::CallKit.CXErrorCodeRequestTransactionError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::CallKit.CXErrorCodeRequestTransactionError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CXErrorCodeRequestTransactionErrorExtensions {
		[Field ("CXErrorDomainRequestTransaction", "CallKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the CallKit.CXErrorCodeRequestTransactionError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this CXErrorCodeRequestTransactionError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.CallKit.Handle, "CXErrorDomainRequestTransaction");
			return _domain;
		}
	}
}
