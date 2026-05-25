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
namespace SafariServices {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>SFAddToHomeScreenActivityItem</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios17.4")]
	[SupportedOSPlatform ("maccatalyst17.4")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[Protocol (Name = "SFAddToHomeScreenActivityItem", WrapperType = typeof (SFAddToHomeScreenActivityItemWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetWebAppManifest", Selector = "getWebAppManifestWithCompletionHandler:", ParameterType = new Type [] { typeof (SafariServices.SFAddToHomeScreenActivityItemGetWebAppManifestCallback) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDSFAddToHomeScreenActivityItemGetWebAppManifestCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetHomeScreenWebAppInfo", Selector = "getHomeScreenWebAppInfoWithCompletionHandler:", ParameterType = new Type [] { typeof (SafariServices.SFAddToHomeScreenActivityItemGetHomeScreenWebAppInfoCallback) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDSFAddToHomeScreenActivityItemGetHomeScreenWebAppInfoCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Url", Selector = "URL", PropertyType = typeof (NSUrl), GetterSelector = "URL", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Title", Selector = "title", PropertyType = typeof (string), GetterSelector = "title", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "IconItemProvider", Selector = "iconItemProvider", PropertyType = typeof (NSItemProvider), GetterSelector = "iconItemProvider", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ISFAddToHomeScreenActivityItem : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("getWebAppManifestWithCompletionHandler:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios18.2", "Use 'GetHomeScreenWebAppInfo' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetWebAppManifest ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSFAddToHomeScreenActivityItemGetWebAppManifestCallback))]SFAddToHomeScreenActivityItemGetWebAppManifestCallback completionHandler)
		{
			_GetWebAppManifest (this, completionHandler);
		}
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios18.2", "Use 'GetHomeScreenWebAppInfo' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<global::BrowserEngineKit.BEWebAppManifest> GetWebAppManifestAsync ()
		{
			var tcs = new TaskCompletionSource<global::BrowserEngineKit.BEWebAppManifest> ();
			GetWebAppManifest((appManifest_) => {
				tcs.SetResult (appManifest_!);
			});
			return tcs.Task;
		}
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios18.2", "Use 'GetHomeScreenWebAppInfo' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GetWebAppManifest (ISFAddToHomeScreenActivityItem This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSFAddToHomeScreenActivityItemGetWebAppManifestCallback))]SFAddToHomeScreenActivityItemGetWebAppManifestCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDSFAddToHomeScreenActivityItemGetWebAppManifestCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("getWebAppManifestWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("getHomeScreenWebAppInfoWithCompletionHandler:")]
		[SupportedOSPlatform ("ios18.2")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetHomeScreenWebAppInfo ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSFAddToHomeScreenActivityItemGetHomeScreenWebAppInfoCallback))]SFAddToHomeScreenActivityItemGetHomeScreenWebAppInfoCallback completionHandler)
		{
			_GetHomeScreenWebAppInfo (this, completionHandler);
		}
		[SupportedOSPlatform ("ios18.2")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<SFAddToHomeScreenInfo> GetHomeScreenWebAppInfoAsync ()
		{
			var tcs = new TaskCompletionSource<SFAddToHomeScreenInfo> ();
			GetHomeScreenWebAppInfo((appManifest_) => {
				tcs.SetResult (appManifest_!);
			});
			return tcs.Task;
		}
		[SupportedOSPlatform ("ios18.2")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GetHomeScreenWebAppInfo (ISFAddToHomeScreenActivityItem This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSFAddToHomeScreenActivityItemGetHomeScreenWebAppInfoCallback))]SFAddToHomeScreenActivityItemGetHomeScreenWebAppInfoCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDSFAddToHomeScreenActivityItemGetHomeScreenWebAppInfoCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("getHomeScreenWebAppInfoWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("GetHomeScreenWebAppInfo(SafariServices.SFAddToHomeScreenActivityItemGetHomeScreenWebAppInfoCallback)")]
		[DynamicDependencyAttribute ("GetWebAppManifest(SafariServices.SFAddToHomeScreenActivityItemGetWebAppManifestCallback)")]
		[DynamicDependencyAttribute ("IconItemProvider")]
		[DynamicDependencyAttribute ("Title")]
		[DynamicDependencyAttribute ("Url")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SFAddToHomeScreenActivityItemWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISFAddToHomeScreenActivityItem ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSUrl Url {
			[Export ("URL")]
			get {
				return _GetUrl (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSUrl _GetUrl (ISFAddToHomeScreenActivityItem This)
		{
			NSUrl ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("URL")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string Title {
			[Export ("title")]
			get {
				return _GetTitle (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetTitle (ISFAddToHomeScreenActivityItem This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("title")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSItemProvider? IconItemProvider {
			[Export ("iconItemProvider")]
			get {
				return _GetIconItemProvider (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSItemProvider _GetIconItemProvider (ISFAddToHomeScreenActivityItem This)
		{
			NSItemProvider ret;
			ret =  Runtime.GetNSObject<NSItemProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("iconItemProvider")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SFAddToHomeScreenActivityItemWrapper : BaseWrapper, ISFAddToHomeScreenActivityItem {
		public SFAddToHomeScreenActivityItemWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SFAddToHomeScreenActivityItemWrapper))]
		static SFAddToHomeScreenActivityItemWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUrl Url {
			[Export ("URL")]
			get {
				NSUrl ret;
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("URL")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string Title {
			[Export ("title")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("title")), false)!;
				return ret;
			}
		}
	}
}
