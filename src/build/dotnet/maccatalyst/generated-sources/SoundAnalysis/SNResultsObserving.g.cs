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
namespace SoundAnalysis {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>SNResultsObserving</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "SNResultsObserving", WrapperType = typeof (SNResultsObservingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidProduceResult", Selector = "request:didProduceResult:", ParameterType = new Type [] { typeof (SoundAnalysis.ISNRequest), typeof (SoundAnalysis.ISNResult) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFail", Selector = "request:didFailWithError:", ParameterType = new Type [] { typeof (SoundAnalysis.ISNRequest), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidComplete", Selector = "requestDidComplete:", ParameterType = new Type [] { typeof (SoundAnalysis.ISNRequest) }, ParameterByRef = new bool [] { false })]
	public partial interface ISNResultsObserving : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("request:didProduceResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidProduceResult (ISNRequest request, ISNResult result)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidProduceResult (ISNResultsObserving This, ISNRequest request, ISNResult result)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var result__handle__ = result!.GetNonNullHandle (nameof (result));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("request:didProduceResult:"), request__handle__, result__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (request);
			GC.KeepAlive (result);
		}
		[global::Foundation.OptionalMember]
		[Export ("request:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFail (ISNRequest request, NSError error)
		{
			_DidFail (this, request, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFail (ISNResultsObserving This, ISNRequest request, NSError error)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("request:didFailWithError:"), request__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (request);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("requestDidComplete:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidComplete (ISNRequest request)
		{
			_DidComplete (this, request);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidComplete (ISNResultsObserving This, ISNRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("requestDidComplete:"), request__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (request);
		}
		[DynamicDependencyAttribute ("DidComplete(SoundAnalysis.ISNRequest)")]
		[DynamicDependencyAttribute ("DidFail(SoundAnalysis.ISNRequest,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidProduceResult(SoundAnalysis.ISNRequest,SoundAnalysis.ISNResult)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SNResultsObservingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISNResultsObserving ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ISNResultsObserving" /> interface to support all the methods from the SNResultsObserving protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ISNResultsObserving" /> interface allow developers to treat instances of the interface as having all the optional methods of the original SNResultsObserving protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class SNResultsObserving_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFail (this ISNResultsObserving This, ISNRequest request, NSError error)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("request:didFailWithError:"), request__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (request);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidComplete (this ISNResultsObserving This, ISNRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("requestDidComplete:"), request__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (request);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SNResultsObservingWrapper : BaseWrapper, ISNResultsObserving {
		public SNResultsObservingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SNResultsObservingWrapper))]
		static SNResultsObservingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("request:didProduceResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidProduceResult (ISNRequest request, ISNResult result)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var result__handle__ = result!.GetNonNullHandle (nameof (result));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("request:didProduceResult:"), request__handle__, result__handle__);
			GC.KeepAlive (request);
			GC.KeepAlive (result);
		}
	}
}
