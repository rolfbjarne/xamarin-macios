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
	/// <summary>Delegate object for the <see cref="T:ARKit.ARSession" /> object, allowing the developer to respond to events relating to the augmented-reality session.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "ARSessionDelegate", WrapperType = typeof (ARSessionDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateFrame", Selector = "session:didUpdateFrame:", ParameterType = new Type [] { typeof (ARKit.ARSession), typeof (ARKit.ARFrame) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddAnchors", Selector = "session:didAddAnchors:", ParameterType = new Type [] { typeof (ARKit.ARSession), typeof (ARKit.ARAnchor[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateAnchors", Selector = "session:didUpdateAnchors:", ParameterType = new Type [] { typeof (ARKit.ARSession), typeof (ARKit.ARAnchor[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveAnchors", Selector = "session:didRemoveAnchors:", ParameterType = new Type [] { typeof (ARKit.ARSession), typeof (ARKit.ARAnchor[]) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IARSessionDelegate : INativeObject, IDisposable, 
		ARKit.IARSessionObserver
	{
		/// <param name="session">The session that is supplying the information for the event.</param><param name="frame">The frame that was updated.</param><summary>Indicates that <paramref name="frame" /> has been updated due to tracking.</summary><remarks><para>Developers who override this method must be sure to call <see cref="M:System.IDisposable.Dispose" /> on the <paramref name="frame" /> when they have finished processing. Internally, ARKit only generates a new <see cref="T:ARKit.ARFrame" /> object when there are no more references to an existing frame.
		/// If <see cref="M:System.IDisposable.Dispose" /> is not called, ARKit will not produce until the GC collects the <paramref name="frame" />. This typically appears as a frozen, non-responsive, or "severely stuttering" video feed.</para></remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didUpdateFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateFrame (ARSession session, ARFrame frame)
		{
			_DidUpdateFrame (this, session, frame);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="frame">The frame that was updated.</param><summary>Indicates that <paramref name="frame" /> has been updated due to tracking.</summary><remarks><para>Developers who override this method must be sure to call <see cref="M:System.IDisposable.Dispose" /> on the <paramref name="frame" /> when they have finished processing. Internally, ARKit only generates a new <see cref="T:ARKit.ARFrame" /> object when there are no more references to an existing frame.
		/// If <see cref="M:System.IDisposable.Dispose" /> is not called, ARKit will not produce until the GC collects the <paramref name="frame" />. This typically appears as a frozen, non-responsive, or "severely stuttering" video feed.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateFrame (IARSessionDelegate This, ARSession session, ARFrame frame)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didUpdateFrame:"), session__handle__, frame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (frame);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="anchors">The anchors that were added.</param><summary>Called when <paramref name="anchors" /> are added to the <paramref name="session" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didAddAnchors:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddAnchors (ARSession session, ARAnchor[] anchors)
		{
			_DidAddAnchors (this, session, anchors);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="anchors">The anchors that were added.</param><summary>Called when <paramref name="anchors" /> are added to the <paramref name="session" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddAnchors (IARSessionDelegate This, ARSession session, ARAnchor[] anchors)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (anchors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (anchors));
			using var nsa_anchors = NSArray.FromNSObjects (anchors);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didAddAnchors:"), session__handle__, nsa_anchors.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="anchors">The anchors that were updated.</param><summary>Indicates that <paramref name="anchors" /> have been updated due to tracking.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didUpdateAnchors:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateAnchors (ARSession session, ARAnchor[] anchors)
		{
			_DidUpdateAnchors (this, session, anchors);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="anchors">The anchors that were updated.</param><summary>Indicates that <paramref name="anchors" /> have been updated due to tracking.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateAnchors (IARSessionDelegate This, ARSession session, ARAnchor[] anchors)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (anchors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (anchors));
			using var nsa_anchors = NSArray.FromNSObjects (anchors);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didUpdateAnchors:"), session__handle__, nsa_anchors.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="anchors">The anchors that were removed.</param><summary>Called when <paramref name="anchors" /> have been removed from the <paramref name="session" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didRemoveAnchors:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveAnchors (ARSession session, ARAnchor[] anchors)
		{
			_DidRemoveAnchors (this, session, anchors);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="anchors">The anchors that were removed.</param><summary>Called when <paramref name="anchors" /> have been removed from the <paramref name="session" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveAnchors (IARSessionDelegate This, ARSession session, ARAnchor[] anchors)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (anchors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (anchors));
			using var nsa_anchors = NSArray.FromNSObjects (anchors);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didRemoveAnchors:"), session__handle__, nsa_anchors.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[DynamicDependencyAttribute ("DidAddAnchors(ARKit.ARSession,ARKit.ARAnchor[])")]
		[DynamicDependencyAttribute ("DidRemoveAnchors(ARKit.ARSession,ARKit.ARAnchor[])")]
		[DynamicDependencyAttribute ("DidUpdateAnchors(ARKit.ARSession,ARKit.ARAnchor[])")]
		[DynamicDependencyAttribute ("DidUpdateFrame(ARKit.ARSession,ARKit.ARFrame)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ARSessionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IARSessionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IARSessionDelegate" /> interface to support all the methods from the ARSessionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IARSessionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original ARSessionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class ARSessionDelegate_Extensions {
		/// <param name="session">The session that is supplying the information for the event.</param><param name="frame">The frame that was updated.</param><summary>Indicates that <paramref name="frame" /> has been updated due to tracking.</summary><remarks><para>Developers who override this method must be sure to call <see cref="M:System.IDisposable.Dispose" /> on the <paramref name="frame" /> when they have finished processing. Internally, ARKit only generates a new <see cref="T:ARKit.ARFrame" /> object when there are no more references to an existing frame.
		/// If <see cref="M:System.IDisposable.Dispose" /> is not called, ARKit will not produce until the GC collects the <paramref name="frame" />. This typically appears as a frozen, non-responsive, or "severely stuttering" video feed.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateFrame (this IARSessionDelegate This, ARSession session, ARFrame frame)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didUpdateFrame:"), session__handle__, frame__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (frame);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="anchors">The anchors that were added.</param><summary>Called when <paramref name="anchors" /> are added to the <paramref name="session" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddAnchors (this IARSessionDelegate This, ARSession session, ARAnchor[] anchors)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (anchors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (anchors));
			using var nsa_anchors = NSArray.FromNSObjects (anchors);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didAddAnchors:"), session__handle__, nsa_anchors.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="anchors">The anchors that were updated.</param><summary>Indicates that <paramref name="anchors" /> have been updated due to tracking.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateAnchors (this IARSessionDelegate This, ARSession session, ARAnchor[] anchors)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (anchors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (anchors));
			using var nsa_anchors = NSArray.FromNSObjects (anchors);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didUpdateAnchors:"), session__handle__, nsa_anchors.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="anchors">The anchors that were removed.</param><summary>Called when <paramref name="anchors" /> have been removed from the <paramref name="session" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemoveAnchors (this IARSessionDelegate This, ARSession session, ARAnchor[] anchors)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (anchors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (anchors));
			using var nsa_anchors = NSArray.FromNSObjects (anchors);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didRemoveAnchors:"), session__handle__, nsa_anchors.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ARSessionDelegateWrapper : BaseWrapper, IARSessionDelegate {
		public ARSessionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ARSessionDelegateWrapper))]
		static ARSessionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace ARKit {
	/// <summary>Delegate object for the <see cref="T:ARKit.ARSession" /> object, allowing the developer to respond to events relating to the augmented-reality session.</summary>
	[Protocol()]
	[Register("Microsoft_iOS__ARKit_ARSessionDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class ARSessionDelegate : NSObject, IARSessionDelegate, IARSessionObserver {
		/// <summary>Creates a new <see cref="ARSessionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ARSessionDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
			}
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ARSessionDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ARSessionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="session">The session that is supplying the information for the event.</param><param name="camera">The camera whose tracking state changed.</param><summary>Called when the <see cref="P:ARKit.ARCamera.TrackingState" /> changes, indicating a change in tracking quality.</summary><remarks>To be added.</remarks>
		[Export ("session:cameraDidChangeTrackingState:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CameraDidChangeTrackingState (ARSession session, ARCamera camera)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="anchors">The anchors that were added.</param><summary>Called when <paramref name="anchors" /> are added to the <paramref name="session" />.</summary><remarks>To be added.</remarks>
		[Export ("session:didAddAnchors:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddAnchors (ARSession session, ARAnchor[] anchors)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("session:didChangeGeoTrackingStatus:")]
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeGeoTrackingStatus (ARSession session, ARGeoTrackingStatus geoTrackingStatus)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="error">The error that occurred.</param><summary>Called when the <paramref name="session" /> stops running due to an error.</summary><remarks>To be added.</remarks>
		[Export ("session:didFailWithError:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFail (ARSession session, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="audioSampleBuffer">The audio buffer that was played.</param><summary>Developers may implement this method that is called shortly after an audio buffer has been played.</summary><remarks>To be added.</remarks>
		[Export ("session:didOutputAudioSampleBuffer:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOutputAudioSampleBuffer (ARSession session, global::CoreMedia.CMSampleBuffer audioSampleBuffer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("session:didOutputCollaborationData:")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOutputCollaborationData (ARSession session, ARCollaborationData data)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="anchors">The anchors that were removed.</param><summary>Called when <paramref name="anchors" /> have been removed from the <paramref name="session" />.</summary><remarks>To be added.</remarks>
		[Export ("session:didRemoveAnchors:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveAnchors (ARSession session, ARAnchor[] anchors)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="anchors">The anchors that were updated.</param><summary>Indicates that <paramref name="anchors" /> have been updated due to tracking.</summary><remarks>To be added.</remarks>
		[Export ("session:didUpdateAnchors:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateAnchors (ARSession session, ARAnchor[] anchors)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="frame">The frame that was updated.</param><summary>Indicates that <paramref name="frame" /> has been updated due to tracking.</summary><remarks><para>Developers who override this method must be sure to call <see cref="M:System.IDisposable.Dispose" /> on the <paramref name="frame" /> when they have finished processing. Internally, ARKit only generates a new <see cref="T:ARKit.ARFrame" /> object when there are no more references to an existing frame.
		/// If <see cref="M:System.IDisposable.Dispose" /> is not called, ARKit will not produce until the GC collects the <paramref name="frame" />. This typically appears as a frozen, non-responsive, or "severely stuttering" video feed.</para></remarks>
		[Export ("session:didUpdateFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateFrame (ARSession session, ARFrame frame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">The session that is supplying the information for the event.</param><summary>Developers may override this method to begin frame processing and device tracking after an interruption.</summary><remarks>To be added.</remarks>
		[Export ("sessionInterruptionEnded:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InterruptionEnded (ARSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">The session in question.</param><summary>Returns a Boolean value that tells whether the session should attempt to reorient after an interruption.</summary><returns>A Boolean value that tells whether the session should attempt to reorient after an interruption.</returns><remarks>To be added.</remarks>
		[Export ("sessionShouldAttemptRelocalization:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAttemptRelocalization (ARSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">The session that is supplying the information for the event.</param><summary>Developers may override this method to stop frame processing and device tracking when an interruption occurs.</summary><remarks>To be added.</remarks>
		[Export ("sessionWasInterrupted:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WasInterrupted (ARSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ARSessionDelegate */
}
