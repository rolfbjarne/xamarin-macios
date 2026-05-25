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
	/// <summary>This interface represents the Objective-C protocol <c>ASAuthorizationProviderExtensionAuthorizationRequestHandler</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "ASAuthorizationProviderExtensionAuthorizationRequestHandler", WrapperType = typeof (ASAuthorizationProviderExtensionAuthorizationRequestHandlerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BeginAuthorization", Selector = "beginAuthorizationWithRequest:", ParameterType = new Type [] { typeof (AuthenticationServices.ASAuthorizationProviderExtensionAuthorizationRequest) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CancelAuthorization", Selector = "cancelAuthorizationWithRequest:", ParameterType = new Type [] { typeof (AuthenticationServices.ASAuthorizationProviderExtensionAuthorizationRequest) }, ParameterByRef = new bool [] { false })]
	public partial interface IASAuthorizationProviderExtensionAuthorizationRequestHandler : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("beginAuthorizationWithRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginAuthorization (ASAuthorizationProviderExtensionAuthorizationRequest request)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BeginAuthorization (IASAuthorizationProviderExtensionAuthorizationRequestHandler This, ASAuthorizationProviderExtensionAuthorizationRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("beginAuthorizationWithRequest:"), request__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (request);
		}
		[global::Foundation.OptionalMember]
		[Export ("cancelAuthorizationWithRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelAuthorization (ASAuthorizationProviderExtensionAuthorizationRequest request)
		{
			_CancelAuthorization (this, request);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CancelAuthorization (IASAuthorizationProviderExtensionAuthorizationRequestHandler This, ASAuthorizationProviderExtensionAuthorizationRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cancelAuthorizationWithRequest:"), request__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (request);
		}
		[DynamicDependencyAttribute ("BeginAuthorization(AuthenticationServices.ASAuthorizationProviderExtensionAuthorizationRequest)")]
		[DynamicDependencyAttribute ("CancelAuthorization(AuthenticationServices.ASAuthorizationProviderExtensionAuthorizationRequest)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAuthorizationProviderExtensionAuthorizationRequestHandlerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IASAuthorizationProviderExtensionAuthorizationRequestHandler ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IASAuthorizationProviderExtensionAuthorizationRequestHandler" /> interface to support all the methods from the ASAuthorizationProviderExtensionAuthorizationRequestHandler protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IASAuthorizationProviderExtensionAuthorizationRequestHandler" /> interface allow developers to treat instances of the interface as having all the optional methods of the original ASAuthorizationProviderExtensionAuthorizationRequestHandler protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class ASAuthorizationProviderExtensionAuthorizationRequestHandler_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CancelAuthorization (this IASAuthorizationProviderExtensionAuthorizationRequestHandler This, ASAuthorizationProviderExtensionAuthorizationRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cancelAuthorizationWithRequest:"), request__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (request);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ASAuthorizationProviderExtensionAuthorizationRequestHandlerWrapper : BaseWrapper, IASAuthorizationProviderExtensionAuthorizationRequestHandler {
		public ASAuthorizationProviderExtensionAuthorizationRequestHandlerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAuthorizationProviderExtensionAuthorizationRequestHandlerWrapper))]
		static ASAuthorizationProviderExtensionAuthorizationRequestHandlerWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("beginAuthorizationWithRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BeginAuthorization (ASAuthorizationProviderExtensionAuthorizationRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("beginAuthorizationWithRequest:"), request__handle__);
			GC.KeepAlive (request);
		}
	}
}
