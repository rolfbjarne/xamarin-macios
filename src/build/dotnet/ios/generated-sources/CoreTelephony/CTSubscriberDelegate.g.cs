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
namespace CoreTelephony {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CTSubscriberDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "CTSubscriberDelegate", WrapperType = typeof (CTSubscriberDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SubscriberTokenRefreshed", Selector = "subscriberTokenRefreshed:", ParameterType = new Type [] { typeof (CoreTelephony.CTSubscriber) }, ParameterByRef = new bool [] { false })]
	public partial interface ICTSubscriberDelegate : INativeObject, IDisposable
	{
		/// <param name="subscriber">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("subscriberTokenRefreshed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SubscriberTokenRefreshed (CTSubscriber subscriber)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="subscriber">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SubscriberTokenRefreshed (ICTSubscriberDelegate This, CTSubscriber subscriber)
		{
			var subscriber__handle__ = subscriber!.GetNonNullHandle (nameof (subscriber));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("subscriberTokenRefreshed:"), subscriber__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (subscriber);
		}
		[DynamicDependencyAttribute ("SubscriberTokenRefreshed(CoreTelephony.CTSubscriber)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CTSubscriberDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICTSubscriberDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CTSubscriberDelegateWrapper : BaseWrapper, ICTSubscriberDelegate {
		public CTSubscriberDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CTSubscriberDelegateWrapper))]
		static CTSubscriberDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="subscriber">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("subscriberTokenRefreshed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SubscriberTokenRefreshed (CTSubscriber subscriber)
		{
			var subscriber__handle__ = subscriber!.GetNonNullHandle (nameof (subscriber));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("subscriberTokenRefreshed:"), subscriber__handle__);
			GC.KeepAlive (subscriber);
		}
	}
}
