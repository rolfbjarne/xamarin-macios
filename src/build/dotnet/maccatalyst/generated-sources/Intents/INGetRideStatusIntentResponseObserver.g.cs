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
namespace Intents {
	#pragma warning disable CS1573
	/// <summary>Receives periodic updates on ride status.</summary>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "INGetRideStatusIntentResponseObserver", WrapperType = typeof (INGetRideStatusIntentResponseObserverWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidUpdateRideStatus", Selector = "getRideStatusResponseDidUpdate:", ParameterType = new Type [] { typeof (Intents.INGetRideStatusIntentResponse) }, ParameterByRef = new bool [] { false })]
	public partial interface IINGetRideStatusIntentResponseObserver : INativeObject, IDisposable
	{
		/// <param name="response">To be added.</param><summary>Developers may override this method to respond to changes in the ride's status.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("getRideStatusResponseDidUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateRideStatus (INGetRideStatusIntentResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="response">To be added.</param><summary>Developers may override this method to respond to changes in the ride's status.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateRideStatus (IINGetRideStatusIntentResponseObserver This, INGetRideStatusIntentResponse response)
		{
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("getRideStatusResponseDidUpdate:"), response__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (response);
		}
		[DynamicDependencyAttribute ("DidUpdateRideStatus(Intents.INGetRideStatusIntentResponse)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INGetRideStatusIntentResponseObserverWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINGetRideStatusIntentResponseObserver ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INGetRideStatusIntentResponseObserverWrapper : BaseWrapper, IINGetRideStatusIntentResponseObserver {
		public INGetRideStatusIntentResponseObserverWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INGetRideStatusIntentResponseObserverWrapper))]
		static INGetRideStatusIntentResponseObserverWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="response">To be added.</param><summary>Developers may override this method to respond to changes in the ride's status.</summary><remarks>To be added.</remarks>
		[Export ("getRideStatusResponseDidUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidUpdateRideStatus (INGetRideStatusIntentResponse response)
		{
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("getRideStatusResponseDidUpdate:"), response__handle__);
			GC.KeepAlive (response);
		}
	}
}
