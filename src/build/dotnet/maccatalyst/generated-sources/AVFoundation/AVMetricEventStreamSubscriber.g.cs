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
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AVMetricEventStreamSubscriber</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios18.0")]
	[Protocol (Name = "AVMetricEventStreamSubscriber", WrapperType = typeof (AVMetricEventStreamSubscriberWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveEvent", Selector = "publisher:didReceiveEvent:", ParameterType = new Type [] { typeof (IAVMetricEventStreamPublisher), typeof (AVMetricEvent) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IAVMetricEventStreamSubscriber : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("publisher:didReceiveEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveEvent (IAVMetricEventStreamPublisher publisher, AVMetricEvent @event)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveEvent (IAVMetricEventStreamSubscriber This, IAVMetricEventStreamPublisher publisher, AVMetricEvent @event)
		{
			var publisher__handle__ = publisher!.GetNonNullHandle (nameof (publisher));
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("publisher:didReceiveEvent:"), publisher__handle__, @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (publisher);
			GC.KeepAlive (@event);
		}
		[DynamicDependencyAttribute ("DidReceiveEvent(AVFoundation.IAVMetricEventStreamPublisher,AVFoundation.AVMetricEvent)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVMetricEventStreamSubscriberWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVMetricEventStreamSubscriber ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVMetricEventStreamSubscriberWrapper : BaseWrapper, IAVMetricEventStreamSubscriber {
		public AVMetricEventStreamSubscriberWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVMetricEventStreamSubscriberWrapper))]
		static AVMetricEventStreamSubscriberWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("publisher:didReceiveEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReceiveEvent (IAVMetricEventStreamPublisher publisher, AVMetricEvent @event)
		{
			var publisher__handle__ = publisher!.GetNonNullHandle (nameof (publisher));
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("publisher:didReceiveEvent:"), publisher__handle__, @event__handle__);
			GC.KeepAlive (publisher);
			GC.KeepAlive (@event);
		}
	}
}
