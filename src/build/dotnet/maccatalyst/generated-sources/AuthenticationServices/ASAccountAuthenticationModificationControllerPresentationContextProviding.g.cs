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
	/// <summary>This interface represents the Objective-C protocol <c>ASAccountAuthenticationModificationControllerPresentationContextProviding</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios14.0")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[Protocol (Name = "ASAccountAuthenticationModificationControllerPresentationContextProviding", WrapperType = typeof (ASAccountAuthenticationModificationControllerPresentationContextProvidingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPresentationAnchor", Selector = "presentationAnchorForAccountAuthenticationModificationController:", ReturnType = typeof (UIWindow), ParameterType = new Type [] { typeof (AuthenticationServices.ASAccountAuthenticationModificationController) }, ParameterByRef = new bool [] { false })]
	public partial interface IASAccountAuthenticationModificationControllerPresentationContextProviding : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("presentationAnchorForAccountAuthenticationModificationController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIWindow GetPresentationAnchor (ASAccountAuthenticationModificationController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIWindow _GetPresentationAnchor (IASAccountAuthenticationModificationControllerPresentationContextProviding This, ASAccountAuthenticationModificationController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::UIKit.UIWindow? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentationAnchorForAccountAuthenticationModificationController:"), controller__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetPresentationAnchor(AuthenticationServices.ASAccountAuthenticationModificationController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAccountAuthenticationModificationControllerPresentationContextProvidingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IASAccountAuthenticationModificationControllerPresentationContextProviding ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ASAccountAuthenticationModificationControllerPresentationContextProvidingWrapper : BaseWrapper, IASAccountAuthenticationModificationControllerPresentationContextProviding {
		public ASAccountAuthenticationModificationControllerPresentationContextProvidingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAccountAuthenticationModificationControllerPresentationContextProvidingWrapper))]
		static ASAccountAuthenticationModificationControllerPresentationContextProvidingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("presentationAnchorForAccountAuthenticationModificationController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::UIKit.UIWindow GetPresentationAnchor (ASAccountAuthenticationModificationController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::UIKit.UIWindow? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("presentationAnchorForAccountAuthenticationModificationController:"), controller__handle__), false)!;
			GC.KeepAlive (controller);
			return ret!;
		}
	}
}
