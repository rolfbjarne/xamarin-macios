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
	/// <summary>This interface represents the Objective-C protocol <c>INGetCarPowerLevelStatusIntentResponseObserver</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "INGetCarPowerLevelStatusIntentResponseObserver", WrapperType = typeof (INGetCarPowerLevelStatusIntentResponseObserverWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidUpdate", Selector = "getCarPowerLevelStatusResponseDidUpdate:", ParameterType = new Type [] { typeof (Intents.INGetCarPowerLevelStatusIntentResponse) }, ParameterByRef = new bool [] { false })]
	public partial interface IINGetCarPowerLevelStatusIntentResponseObserver : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("getCarPowerLevelStatusResponseDidUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdate (INGetCarPowerLevelStatusIntentResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdate (IINGetCarPowerLevelStatusIntentResponseObserver This, INGetCarPowerLevelStatusIntentResponse response)
		{
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("getCarPowerLevelStatusResponseDidUpdate:"), response__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (response);
		}
		[DynamicDependencyAttribute ("DidUpdate(Intents.INGetCarPowerLevelStatusIntentResponse)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INGetCarPowerLevelStatusIntentResponseObserverWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINGetCarPowerLevelStatusIntentResponseObserver ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INGetCarPowerLevelStatusIntentResponseObserverWrapper : BaseWrapper, IINGetCarPowerLevelStatusIntentResponseObserver {
		public INGetCarPowerLevelStatusIntentResponseObserverWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INGetCarPowerLevelStatusIntentResponseObserverWrapper))]
		static INGetCarPowerLevelStatusIntentResponseObserverWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("getCarPowerLevelStatusResponseDidUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidUpdate (INGetCarPowerLevelStatusIntentResponse response)
		{
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("getCarPowerLevelStatusResponseDidUpdate:"), response__handle__);
			GC.KeepAlive (response);
		}
	}
}
