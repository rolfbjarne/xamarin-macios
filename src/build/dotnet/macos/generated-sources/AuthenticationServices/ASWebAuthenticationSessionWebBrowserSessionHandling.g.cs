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
namespace AuthenticationServices {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>ASWebAuthenticationSessionWebBrowserSessionHandling</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "ASWebAuthenticationSessionWebBrowserSessionHandling", WrapperType = typeof (ASWebAuthenticationSessionWebBrowserSessionHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BeginHandlingWebAuthenticationSessionRequest", Selector = "beginHandlingWebAuthenticationSessionRequest:", ParameterType = new Type [] { typeof (AuthenticationServices.ASWebAuthenticationSessionRequest) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CancelWebAuthenticationSessionRequest", Selector = "cancelWebAuthenticationSessionRequest:", ParameterType = new Type [] { typeof (AuthenticationServices.ASWebAuthenticationSessionRequest) }, ParameterByRef = new bool [] { false })]
	public partial interface IASWebAuthenticationSessionWebBrowserSessionHandling : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("beginHandlingWebAuthenticationSessionRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginHandlingWebAuthenticationSessionRequest (ASWebAuthenticationSessionRequest request)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BeginHandlingWebAuthenticationSessionRequest (IASWebAuthenticationSessionWebBrowserSessionHandling This, ASWebAuthenticationSessionRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("beginHandlingWebAuthenticationSessionRequest:"), request__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (request);
		}
		[global::Foundation.RequiredMember]
		[Export ("cancelWebAuthenticationSessionRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelWebAuthenticationSessionRequest (ASWebAuthenticationSessionRequest request)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CancelWebAuthenticationSessionRequest (IASWebAuthenticationSessionWebBrowserSessionHandling This, ASWebAuthenticationSessionRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cancelWebAuthenticationSessionRequest:"), request__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (request);
		}
		[DynamicDependencyAttribute ("BeginHandlingWebAuthenticationSessionRequest(AuthenticationServices.ASWebAuthenticationSessionRequest)")]
		[DynamicDependencyAttribute ("CancelWebAuthenticationSessionRequest(AuthenticationServices.ASWebAuthenticationSessionRequest)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASWebAuthenticationSessionWebBrowserSessionHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IASWebAuthenticationSessionWebBrowserSessionHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ASWebAuthenticationSessionWebBrowserSessionHandlingWrapper : BaseWrapper, IASWebAuthenticationSessionWebBrowserSessionHandling {
		public ASWebAuthenticationSessionWebBrowserSessionHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASWebAuthenticationSessionWebBrowserSessionHandlingWrapper))]
		static ASWebAuthenticationSessionWebBrowserSessionHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("beginHandlingWebAuthenticationSessionRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BeginHandlingWebAuthenticationSessionRequest (ASWebAuthenticationSessionRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("beginHandlingWebAuthenticationSessionRequest:"), request__handle__);
			GC.KeepAlive (request);
		}
		[Export ("cancelWebAuthenticationSessionRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CancelWebAuthenticationSessionRequest (ASWebAuthenticationSessionRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("cancelWebAuthenticationSessionRequest:"), request__handle__);
			GC.KeepAlive (request);
		}
	}
}
