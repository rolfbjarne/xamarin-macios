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
namespace AuthenticationServices {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>ASWebAuthenticationPresentationContextProviding</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "ASWebAuthenticationPresentationContextProviding", WrapperType = typeof (ASWebAuthenticationPresentationContextProvidingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPresentationAnchor", Selector = "presentationAnchorForWebAuthenticationSession:", ReturnType = typeof (UIWindow), ParameterType = new Type [] { typeof (AuthenticationServices.ASWebAuthenticationSession) }, ParameterByRef = new bool [] { false })]
	public partial interface IASWebAuthenticationPresentationContextProviding : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("presentationAnchorForWebAuthenticationSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIWindow GetPresentationAnchor (ASWebAuthenticationSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIWindow _GetPresentationAnchor (IASWebAuthenticationPresentationContextProviding This, ASWebAuthenticationSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::UIKit.UIWindow? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentationAnchorForWebAuthenticationSession:"), session__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetPresentationAnchor(AuthenticationServices.ASWebAuthenticationSession)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASWebAuthenticationPresentationContextProvidingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IASWebAuthenticationPresentationContextProviding ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ASWebAuthenticationPresentationContextProvidingWrapper : BaseWrapper, IASWebAuthenticationPresentationContextProviding {
		public ASWebAuthenticationPresentationContextProvidingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASWebAuthenticationPresentationContextProvidingWrapper))]
		static ASWebAuthenticationPresentationContextProvidingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("presentationAnchorForWebAuthenticationSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::UIKit.UIWindow GetPresentationAnchor (ASWebAuthenticationSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::UIKit.UIWindow? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("presentationAnchorForWebAuthenticationSession:"), session__handle__), false)!;
			GC.KeepAlive (session);
			return ret!;
		}
	}
}
