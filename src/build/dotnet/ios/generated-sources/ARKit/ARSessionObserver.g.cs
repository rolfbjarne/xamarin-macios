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
namespace ARKit {
	#pragma warning disable CS1573
	/// <summary>Interface defining methods that respond to events in an <see cref="T:ARKit.ARSession" />.</summary><remarks>To be added.</remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "ARSessionObserver", WrapperType = typeof (ARSessionObserverWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFail", Selector = "session:didFailWithError:", ParameterType = new Type [] { typeof (ARKit.ARSession), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CameraDidChangeTrackingState", Selector = "session:cameraDidChangeTrackingState:", ParameterType = new Type [] { typeof (ARKit.ARSession), typeof (ARKit.ARCamera) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WasInterrupted", Selector = "sessionWasInterrupted:", ParameterType = new Type [] { typeof (ARKit.ARSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InterruptionEnded", Selector = "sessionInterruptionEnded:", ParameterType = new Type [] { typeof (ARKit.ARSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAttemptRelocalization", Selector = "sessionShouldAttemptRelocalization:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (ARKit.ARSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOutputAudioSampleBuffer", Selector = "session:didOutputAudioSampleBuffer:", ParameterType = new Type [] { typeof (ARKit.ARSession), typeof (CMSampleBuffer) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOutputCollaborationData", Selector = "session:didOutputCollaborationData:", ParameterType = new Type [] { typeof (ARKit.ARSession), typeof (ARKit.ARCollaborationData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeGeoTrackingStatus", Selector = "session:didChangeGeoTrackingStatus:", ParameterType = new Type [] { typeof (ARKit.ARSession), typeof (ARKit.ARGeoTrackingStatus) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IARSessionObserver : INativeObject, IDisposable
	{
		/// <param name="session">The session that is supplying the information for the event.</param><param name="error">The error that occurred.</param><summary>Called when the <paramref name="session" /> stops running due to an error.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFail (ARSession session, NSError error)
		{
			_DidFail (this, session, error);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="error">The error that occurred.</param><summary>Called when the <paramref name="session" /> stops running due to an error.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFail (IARSessionObserver This, ARSession session, NSError error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didFailWithError:"), session__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (error);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="camera">The camera whose tracking state changed.</param><summary>Called when the <see cref="P:ARKit.ARCamera.TrackingState" /> changes, indicating a change in tracking quality.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:cameraDidChangeTrackingState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CameraDidChangeTrackingState (ARSession session, ARCamera camera)
		{
			_CameraDidChangeTrackingState (this, session, camera);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="camera">The camera whose tracking state changed.</param><summary>Called when the <see cref="P:ARKit.ARCamera.TrackingState" /> changes, indicating a change in tracking quality.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CameraDidChangeTrackingState (IARSessionObserver This, ARSession session, ARCamera camera)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:cameraDidChangeTrackingState:"), session__handle__, camera__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (camera);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><summary>Developers may override this method to stop frame processing and device tracking when an interruption occurs.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("sessionWasInterrupted:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WasInterrupted (ARSession session)
		{
			_WasInterrupted (this, session);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><summary>Developers may override this method to stop frame processing and device tracking when an interruption occurs.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WasInterrupted (IARSessionObserver This, ARSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sessionWasInterrupted:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><summary>Developers may override this method to begin frame processing and device tracking after an interruption.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("sessionInterruptionEnded:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InterruptionEnded (ARSession session)
		{
			_InterruptionEnded (this, session);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><summary>Developers may override this method to begin frame processing and device tracking after an interruption.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InterruptionEnded (IARSessionObserver This, ARSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sessionInterruptionEnded:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		/// <param name="session">The session in question.</param><summary>Returns a Boolean value that tells whether the session should attempt to reorient after an interruption.</summary><returns>A Boolean value that tells whether the session should attempt to reorient after an interruption.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("sessionShouldAttemptRelocalization:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAttemptRelocalization (ARSession session)
		{
			return _ShouldAttemptRelocalization (this, session);
		}
		/// <param name="session">The session in question.</param><summary>Returns a Boolean value that tells whether the session should attempt to reorient after an interruption.</summary><returns>A Boolean value that tells whether the session should attempt to reorient after an interruption.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldAttemptRelocalization (IARSessionObserver This, ARSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sessionShouldAttemptRelocalization:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			return ret != 0;
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="audioSampleBuffer">The audio buffer that was played.</param><summary>Developers may implement this method that is called shortly after an audio buffer has been played.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didOutputAudioSampleBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOutputAudioSampleBuffer (ARSession session, global::CoreMedia.CMSampleBuffer audioSampleBuffer)
		{
			_DidOutputAudioSampleBuffer (this, session, audioSampleBuffer);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="audioSampleBuffer">The audio buffer that was played.</param><summary>Developers may implement this method that is called shortly after an audio buffer has been played.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidOutputAudioSampleBuffer (IARSessionObserver This, ARSession session, global::CoreMedia.CMSampleBuffer audioSampleBuffer)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var audioSampleBuffer__handle__ = audioSampleBuffer!.GetNonNullHandle (nameof (audioSampleBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didOutputAudioSampleBuffer:"), session__handle__, audioSampleBuffer.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (audioSampleBuffer);
		}
		[global::Foundation.OptionalMember]
		[Export ("session:didOutputCollaborationData:")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOutputCollaborationData (ARSession session, ARCollaborationData data)
		{
			_DidOutputCollaborationData (this, session, data);
		}
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidOutputCollaborationData (IARSessionObserver This, ARSession session, ARCollaborationData data)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didOutputCollaborationData:"), session__handle__, data__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (data);
		}
		[global::Foundation.OptionalMember]
		[Export ("session:didChangeGeoTrackingStatus:")]
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeGeoTrackingStatus (ARSession session, ARGeoTrackingStatus geoTrackingStatus)
		{
			_DidChangeGeoTrackingStatus (this, session, geoTrackingStatus);
		}
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeGeoTrackingStatus (IARSessionObserver This, ARSession session, ARGeoTrackingStatus geoTrackingStatus)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var geoTrackingStatus__handle__ = geoTrackingStatus!.GetNonNullHandle (nameof (geoTrackingStatus));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didChangeGeoTrackingStatus:"), session__handle__, geoTrackingStatus__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (geoTrackingStatus);
		}
		[DynamicDependencyAttribute ("CameraDidChangeTrackingState(ARKit.ARSession,ARKit.ARCamera)")]
		[DynamicDependencyAttribute ("DidChangeGeoTrackingStatus(ARKit.ARSession,ARKit.ARGeoTrackingStatus)")]
		[DynamicDependencyAttribute ("DidFail(ARKit.ARSession,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidOutputAudioSampleBuffer(ARKit.ARSession,CoreMedia.CMSampleBuffer)")]
		[DynamicDependencyAttribute ("DidOutputCollaborationData(ARKit.ARSession,ARKit.ARCollaborationData)")]
		[DynamicDependencyAttribute ("InterruptionEnded(ARKit.ARSession)")]
		[DynamicDependencyAttribute ("ShouldAttemptRelocalization(ARKit.ARSession)")]
		[DynamicDependencyAttribute ("WasInterrupted(ARKit.ARSession)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ARSessionObserverWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IARSessionObserver ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IARSessionObserver" /> interface to support all the methods from the ARSessionObserver protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IARSessionObserver" /> interface allow developers to treat instances of the interface as having all the optional methods of the original ARSessionObserver protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class ARSessionObserver_Extensions {
		/// <param name="session">The session that is supplying the information for the event.</param><param name="error">The error that occurred.</param><summary>Called when the <paramref name="session" /> stops running due to an error.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFail (this IARSessionObserver This, ARSession session, NSError error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didFailWithError:"), session__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (error);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="camera">The camera whose tracking state changed.</param><summary>Called when the <see cref="P:ARKit.ARCamera.TrackingState" /> changes, indicating a change in tracking quality.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CameraDidChangeTrackingState (this IARSessionObserver This, ARSession session, ARCamera camera)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:cameraDidChangeTrackingState:"), session__handle__, camera__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (camera);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><summary>Developers may override this method to stop frame processing and device tracking when an interruption occurs.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WasInterrupted (this IARSessionObserver This, ARSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sessionWasInterrupted:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><summary>Developers may override this method to begin frame processing and device tracking after an interruption.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InterruptionEnded (this IARSessionObserver This, ARSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sessionInterruptionEnded:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		/// <param name="session">The session in question.</param><summary>Returns a Boolean value that tells whether the session should attempt to reorient after an interruption.</summary><returns>A Boolean value that tells whether the session should attempt to reorient after an interruption.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldAttemptRelocalization (this IARSessionObserver This, ARSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sessionShouldAttemptRelocalization:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			return ret != 0;
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="audioSampleBuffer">The audio buffer that was played.</param><summary>Developers may implement this method that is called shortly after an audio buffer has been played.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidOutputAudioSampleBuffer (this IARSessionObserver This, ARSession session, global::CoreMedia.CMSampleBuffer audioSampleBuffer)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var audioSampleBuffer__handle__ = audioSampleBuffer!.GetNonNullHandle (nameof (audioSampleBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didOutputAudioSampleBuffer:"), session__handle__, audioSampleBuffer.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (audioSampleBuffer);
		}
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidOutputCollaborationData (this IARSessionObserver This, ARSession session, ARCollaborationData data)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didOutputCollaborationData:"), session__handle__, data__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (data);
		}
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeGeoTrackingStatus (this IARSessionObserver This, ARSession session, ARGeoTrackingStatus geoTrackingStatus)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var geoTrackingStatus__handle__ = geoTrackingStatus!.GetNonNullHandle (nameof (geoTrackingStatus));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didChangeGeoTrackingStatus:"), session__handle__, geoTrackingStatus__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (geoTrackingStatus);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ARSessionObserverWrapper : BaseWrapper, IARSessionObserver {
		public ARSessionObserverWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ARSessionObserverWrapper))]
		static ARSessionObserverWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
