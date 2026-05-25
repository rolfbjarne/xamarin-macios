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
namespace WebKit {
	#pragma warning disable CS1573
	/// <summary>Interface that represents the required members of the WKHttpCookieStoreObserver protocol.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "WKHTTPCookieStoreObserver", WrapperType = typeof (WKHttpCookieStoreObserverWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CookiesDidChangeInCookieStore", Selector = "cookiesDidChangeInCookieStore:", ParameterType = new Type [] { typeof (WebKit.WKHttpCookieStore) }, ParameterByRef = new bool [] { false })]
	public partial interface IWKHttpCookieStoreObserver : INativeObject, IDisposable
	{
		/// <param name="cookieStore">The store that changed.</param><summary>Method that is called when a cookie changes in the cookie store.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("cookiesDidChangeInCookieStore:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CookiesDidChangeInCookieStore (WKHttpCookieStore cookieStore)
		{
			_CookiesDidChangeInCookieStore (this, cookieStore);
		}
		/// <param name="cookieStore">The store that changed.</param><summary>Method that is called when a cookie changes in the cookie store.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CookiesDidChangeInCookieStore (IWKHttpCookieStoreObserver This, WKHttpCookieStore cookieStore)
		{
			var cookieStore__handle__ = cookieStore!.GetNonNullHandle (nameof (cookieStore));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cookiesDidChangeInCookieStore:"), cookieStore__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cookieStore);
		}
		[DynamicDependencyAttribute ("CookiesDidChangeInCookieStore(WebKit.WKHttpCookieStore)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKHttpCookieStoreObserverWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IWKHttpCookieStoreObserver ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IWKHttpCookieStoreObserver" /> interface to support all the methods from the WKHTTPCookieStoreObserver protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IWKHttpCookieStoreObserver" /> interface allow developers to treat instances of the interface as having all the optional methods of the original WKHTTPCookieStoreObserver protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class WKHttpCookieStoreObserver_Extensions {
		/// <param name="cookieStore">The store that changed.</param><summary>Method that is called when a cookie changes in the cookie store.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CookiesDidChangeInCookieStore (this IWKHttpCookieStoreObserver This, WKHttpCookieStore cookieStore)
		{
			var cookieStore__handle__ = cookieStore!.GetNonNullHandle (nameof (cookieStore));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cookiesDidChangeInCookieStore:"), cookieStore__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cookieStore);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class WKHttpCookieStoreObserverWrapper : BaseWrapper, IWKHttpCookieStoreObserver {
		public WKHttpCookieStoreObserverWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKHttpCookieStoreObserverWrapper))]
		static WKHttpCookieStoreObserverWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
