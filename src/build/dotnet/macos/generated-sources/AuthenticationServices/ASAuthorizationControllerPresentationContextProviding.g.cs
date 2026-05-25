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
	/// <summary>This interface represents the Objective-C protocol <c>ASAuthorizationControllerPresentationContextProviding</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "ASAuthorizationControllerPresentationContextProviding", WrapperType = typeof (ASAuthorizationControllerPresentationContextProvidingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPresentationAnchor", Selector = "presentationAnchorForAuthorizationController:", ReturnType = typeof (NSWindow), ParameterType = new Type [] { typeof (AuthenticationServices.ASAuthorizationController) }, ParameterByRef = new bool [] { false })]
	public partial interface IASAuthorizationControllerPresentationContextProviding : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("presentationAnchorForAuthorizationController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSWindow GetPresentationAnchor (ASAuthorizationController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::AppKit.NSWindow _GetPresentationAnchor (IASAuthorizationControllerPresentationContextProviding This, ASAuthorizationController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::AppKit.NSWindow? ret;
			ret =  Runtime.GetNSObject<global::AppKit.NSWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentationAnchorForAuthorizationController:"), controller__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetPresentationAnchor(AuthenticationServices.ASAuthorizationController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAuthorizationControllerPresentationContextProvidingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IASAuthorizationControllerPresentationContextProviding ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ASAuthorizationControllerPresentationContextProvidingWrapper : BaseWrapper, IASAuthorizationControllerPresentationContextProviding {
		public ASAuthorizationControllerPresentationContextProvidingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAuthorizationControllerPresentationContextProvidingWrapper))]
		static ASAuthorizationControllerPresentationContextProvidingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("presentationAnchorForAuthorizationController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::AppKit.NSWindow GetPresentationAnchor (ASAuthorizationController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::AppKit.NSWindow? ret;
			ret =  Runtime.GetNSObject<global::AppKit.NSWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("presentationAnchorForAuthorizationController:"), controller__handle__), false)!;
			GC.KeepAlive (controller);
			return ret!;
		}
	}
}
