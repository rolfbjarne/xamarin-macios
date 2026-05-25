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
namespace BackgroundAssets {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>BAManagedDownloaderExtension</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[Protocol (Name = "BAManagedDownloaderExtension", WrapperType = typeof (BAManagedDownloaderExtensionWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldDownload", Selector = "shouldDownloadAssetPack:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (BackgroundAssets.BAAssetPack) }, ParameterByRef = new bool [] { false })]
	public partial interface IBAManagedDownloaderExtension : INativeObject, IDisposable, 
		BackgroundAssets.IBADownloaderExtension
	{
		[global::Foundation.OptionalMember]
		[Export ("shouldDownloadAssetPack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDownload (BAAssetPack assetPack)
		{
			return _ShouldDownload (this, assetPack);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldDownload (IBAManagedDownloaderExtension This, BAAssetPack assetPack)
		{
			var assetPack__handle__ = assetPack!.GetNonNullHandle (nameof (assetPack));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("shouldDownloadAssetPack:"), assetPack__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (assetPack);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("ShouldDownload(BackgroundAssets.BAAssetPack)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BAManagedDownloaderExtensionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IBAManagedDownloaderExtension ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class BAManagedDownloaderExtensionWrapper : BaseWrapper, IBAManagedDownloaderExtension {
		public BAManagedDownloaderExtensionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BAManagedDownloaderExtensionWrapper))]
		static BAManagedDownloaderExtensionWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
