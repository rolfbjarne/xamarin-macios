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
namespace MetricKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MXMetricManagerSubscriber</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "MXMetricManagerSubscriber", WrapperType = typeof (MXMetricManagerSubscriberWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveMetricPayloads", Selector = "didReceiveMetricPayloads:", ParameterType = new Type [] { typeof (MetricKit.MXMetricPayload[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveDiagnosticPayloads", Selector = "didReceiveDiagnosticPayloads:", ParameterType = new Type [] { typeof (MetricKit.MXDiagnosticPayload[]) }, ParameterByRef = new bool [] { false })]
	public partial interface IMXMetricManagerSubscriber : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("didReceiveMetricPayloads:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveMetricPayloads (MXMetricPayload[] payloads)
		{
			_DidReceiveMetricPayloads (this, payloads);
		}
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveMetricPayloads (IMXMetricManagerSubscriber This, MXMetricPayload[] payloads)
		{
			if (payloads is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (payloads));
			using var nsa_payloads = NSArray.FromNSObjects (payloads);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didReceiveMetricPayloads:"), nsa_payloads.Handle);
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("didReceiveDiagnosticPayloads:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveDiagnosticPayloads (MXDiagnosticPayload[] payloads)
		{
			_DidReceiveDiagnosticPayloads (this, payloads);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveDiagnosticPayloads (IMXMetricManagerSubscriber This, MXDiagnosticPayload[] payloads)
		{
			if (payloads is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (payloads));
			using var nsa_payloads = NSArray.FromNSObjects (payloads);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didReceiveDiagnosticPayloads:"), nsa_payloads.Handle);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("DidReceiveDiagnosticPayloads(MetricKit.MXDiagnosticPayload[])")]
		[DynamicDependencyAttribute ("DidReceiveMetricPayloads(MetricKit.MXMetricPayload[])")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MXMetricManagerSubscriberWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMXMetricManagerSubscriber ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMXMetricManagerSubscriber" /> interface to support all the methods from the MXMetricManagerSubscriber protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMXMetricManagerSubscriber" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MXMetricManagerSubscriber protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MXMetricManagerSubscriber_Extensions {
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveMetricPayloads (this IMXMetricManagerSubscriber This, MXMetricPayload[] payloads)
		{
			if (payloads is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (payloads));
			using var nsa_payloads = NSArray.FromNSObjects (payloads);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didReceiveMetricPayloads:"), nsa_payloads.Handle);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveDiagnosticPayloads (this IMXMetricManagerSubscriber This, MXDiagnosticPayload[] payloads)
		{
			if (payloads is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (payloads));
			using var nsa_payloads = NSArray.FromNSObjects (payloads);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didReceiveDiagnosticPayloads:"), nsa_payloads.Handle);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MXMetricManagerSubscriberWrapper : BaseWrapper, IMXMetricManagerSubscriber {
		public MXMetricManagerSubscriberWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MXMetricManagerSubscriberWrapper))]
		static MXMetricManagerSubscriberWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
