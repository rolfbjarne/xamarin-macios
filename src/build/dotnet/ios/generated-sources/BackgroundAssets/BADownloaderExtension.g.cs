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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace BackgroundAssets {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>BADownloaderExtension</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos18.4")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[Protocol (Name = "BADownloaderExtension", WrapperType = typeof (BADownloaderExtensionWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillTerminate", Selector = "extensionWillTerminate")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveChallenge", Selector = "backgroundDownload:didReceiveChallenge:completionHandler:", ParameterType = new Type [] { typeof (BackgroundAssets.BADownload), typeof (NSUrlAuthenticationChallenge), typeof (global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V11) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Failed", Selector = "backgroundDownload:failedWithError:", ParameterType = new Type [] { typeof (BackgroundAssets.BADownload), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Finished", Selector = "backgroundDownload:finishedWithFileURL:", ParameterType = new Type [] { typeof (BackgroundAssets.BADownload), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDownloads", Selector = "downloadsForRequest:manifestURL:extensionInfo:", ReturnType = typeof (global::Foundation.NSSet<global::BackgroundAssets.BADownload>), ParameterType = new Type [] { typeof (BackgroundAssets.BAContentRequest), typeof (NSUrl), typeof (BackgroundAssets.BAAppExtensionInfo) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IBADownloaderExtension : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("extensionWillTerminate")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios16.4", "'WillTerminate' will not be called in all applicable scenarios, do not rely on it.")]
		[ObsoletedOSPlatform ("macos13.3", "'WillTerminate' will not be invoked in all applicable scenarios, do not rely on it.")]
		[ObsoletedOSPlatform ("maccatalyst16.4", "'WillTerminate' will not be invoked in all applicable scenarios, do not rely on it.")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillTerminate ()
		{
			_WillTerminate (this);
		}
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios16.4", "'WillTerminate' will not be called in all applicable scenarios, do not rely on it.")]
		[ObsoletedOSPlatform ("macos13.3", "'WillTerminate' will not be invoked in all applicable scenarios, do not rely on it.")]
		[ObsoletedOSPlatform ("maccatalyst16.4", "'WillTerminate' will not be invoked in all applicable scenarios, do not rely on it.")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillTerminate (IBADownloaderExtension This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("extensionWillTerminate"));
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("backgroundDownload:didReceiveChallenge:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveChallenge (BADownload download, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V11))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			_DidReceiveChallenge (this, download, challenge, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidReceiveChallenge (IBADownloaderExtension This, BADownload download, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V11))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V11.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("backgroundDownload:didReceiveChallenge:completionHandler:"), download__handle__, challenge__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (challenge);
		}
		[global::Foundation.OptionalMember]
		[Export ("backgroundDownload:failedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Failed (BADownload download, NSError error)
		{
			_Failed (this, download, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Failed (IBADownloaderExtension This, BADownload download, NSError error)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("backgroundDownload:failedWithError:"), download__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("backgroundDownload:finishedWithFileURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Finished (BADownload download, NSUrl fileUrl)
		{
			_Finished (this, download, fileUrl);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Finished (IBADownloaderExtension This, BADownload download, NSUrl fileUrl)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var fileUrl__handle__ = fileUrl!.GetNonNullHandle (nameof (fileUrl));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("backgroundDownload:finishedWithFileURL:"), download__handle__, fileUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (fileUrl);
		}
		[global::Foundation.OptionalMember]
		[Export ("downloadsForRequest:manifestURL:extensionInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<BADownload> GetDownloads (BAContentRequest contentRequest, NSUrl manifestUrl, BAAppExtensionInfo extensionInfo)
		{
			return _GetDownloads (this, contentRequest, manifestUrl, extensionInfo);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSSet<BADownload> _GetDownloads (IBADownloaderExtension This, BAContentRequest contentRequest, NSUrl manifestUrl, BAAppExtensionInfo extensionInfo)
		{
			var manifestUrl__handle__ = manifestUrl!.GetNonNullHandle (nameof (manifestUrl));
			var extensionInfo__handle__ = extensionInfo!.GetNonNullHandle (nameof (extensionInfo));
			NSSet<BADownload>? ret;
			ret =  Runtime.GetNSObject<NSSet<BADownload>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("downloadsForRequest:manifestURL:extensionInfo:"), (IntPtr) (long) contentRequest, manifestUrl__handle__, extensionInfo__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (manifestUrl);
			GC.KeepAlive (extensionInfo);
			return ret!;
		}
		[DynamicDependencyAttribute ("DidReceiveChallenge(BackgroundAssets.BADownload,Foundation.NSUrlAuthenticationChallenge,System.Action{Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential})")]
		[DynamicDependencyAttribute ("Failed(BackgroundAssets.BADownload,Foundation.NSError)")]
		[DynamicDependencyAttribute ("Finished(BackgroundAssets.BADownload,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("GetDownloads(BackgroundAssets.BAContentRequest,Foundation.NSUrl,BackgroundAssets.BAAppExtensionInfo)")]
		[DynamicDependencyAttribute ("WillTerminate()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BADownloaderExtensionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IBADownloaderExtension ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IBADownloaderExtension" /> interface to support all the methods from the BADownloaderExtension protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IBADownloaderExtension" /> interface allow developers to treat instances of the interface as having all the optional methods of the original BADownloaderExtension protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class BADownloaderExtension_Extensions {
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios16.4", "'WillTerminate' will not be called in all applicable scenarios, do not rely on it.")]
		[ObsoletedOSPlatform ("macos13.3", "'WillTerminate' will not be invoked in all applicable scenarios, do not rely on it.")]
		[ObsoletedOSPlatform ("maccatalyst16.4", "'WillTerminate' will not be invoked in all applicable scenarios, do not rely on it.")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillTerminate (this IBADownloaderExtension This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("extensionWillTerminate"));
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidReceiveChallenge (this IBADownloaderExtension This, BADownload download, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V11))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V11.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("backgroundDownload:didReceiveChallenge:completionHandler:"), download__handle__, challenge__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (challenge);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Failed (this IBADownloaderExtension This, BADownload download, NSError error)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("backgroundDownload:failedWithError:"), download__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Finished (this IBADownloaderExtension This, BADownload download, NSUrl fileUrl)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var fileUrl__handle__ = fileUrl!.GetNonNullHandle (nameof (fileUrl));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("backgroundDownload:finishedWithFileURL:"), download__handle__, fileUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (fileUrl);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSSet<BADownload> GetDownloads (this IBADownloaderExtension This, BAContentRequest contentRequest, NSUrl manifestUrl, BAAppExtensionInfo extensionInfo)
		{
			var manifestUrl__handle__ = manifestUrl!.GetNonNullHandle (nameof (manifestUrl));
			var extensionInfo__handle__ = extensionInfo!.GetNonNullHandle (nameof (extensionInfo));
			NSSet<BADownload>? ret;
			ret =  Runtime.GetNSObject<NSSet<BADownload>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("downloadsForRequest:manifestURL:extensionInfo:"), (IntPtr) (long) contentRequest, manifestUrl__handle__, extensionInfo__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (manifestUrl);
			GC.KeepAlive (extensionInfo);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class BADownloaderExtensionWrapper : BaseWrapper, IBADownloaderExtension {
		public BADownloaderExtensionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BADownloaderExtensionWrapper))]
		static BADownloaderExtensionWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
