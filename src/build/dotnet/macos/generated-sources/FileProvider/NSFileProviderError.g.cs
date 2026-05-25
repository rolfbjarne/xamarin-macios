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
namespace FileProvider {
	/// <summary>Enumerates errors relating to providing files.</summary>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native ("NSFileProviderErrorCode")]
	public enum NSFileProviderError : long {
		/// <summary>To be added.</summary>
		NotAuthenticated = -1000,
		/// <summary>To be added.</summary>
		FilenameCollision = -1001,
		/// <summary>To be added.</summary>
		SyncAnchorExpired = -1002,
		/// <summary>To be added.</summary>
		PageExpired = -1002,
		/// <summary>To be added.</summary>
		InsufficientQuota = -1003,
		/// <summary>To be added.</summary>
		ServerUnreachable = -1004,
		/// <summary>To be added.</summary>
		NoSuchItem = -1005,
		VersionOutOfDate = -1006,
		DirectoryNotEmpty = -1007,
		ProviderNotFound = -2001,
		ProviderTranslocated = -2002,
		OlderExtensionVersionRunning = -2003,
		NewerExtensionVersionFound = -2004,
		CannotSynchronize = -2005,
		NonEvictableChildren = -2006,
		UnsyncedEdits = -2007,
		NonEvictable = -2008,
		VersionNoLongerAvailable = -2009,
		ExcludedFromSync = -2010,
		DomainDisabled = -2011,
		ProviderDomainTemporarilyUnavailable = -2012,
		ProviderDomainNotFound = -2013,
		ApplicationExtensionNotFound = -2014,
		LocalVersionConflictingWithServer = -2015,
	}
	/// <summary>Extension methods for the <see cref="global::FileProvider.NSFileProviderError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::FileProvider.NSFileProviderError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSFileProviderErrorExtensions {
		[Field ("NSFileProviderErrorDomain", "FileProvider")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the FileProvider.NSFileProviderError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this NSFileProviderError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.FileProvider.Handle, "NSFileProviderErrorDomain");
			return _domain;
		}
	}
}
