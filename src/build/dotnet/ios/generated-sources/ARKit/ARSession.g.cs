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
	/// <summary>Manages the camera capture, motion processing, and image analysis necessary to create a mixed-reality experience.</summary><remarks><para>
	/// An <see cref="T:ARKit.ARSession" /> object represents the system resources required for a mixed-reality experience.
	/// The <see cref="M:ARKit.ARSession.Run(ARKit.ARConfiguration,ARKit.ARSessionRunOptions)" /> method must be passed an
	/// <see cref="T:ARKit.ARConfiguration" /> object that controls specific behaviors.
	/// </para><para>
	/// Developers who use the <see cref="T:ARKit.ARSCNView" /> to present their AR imagery do not need to instantiate their
	/// own <see cref="T:ARKit.ARSession" /> object but instead should call <see cref="M:ARKit.ARSession.Run(ARKit.ARConfiguration,ARKit.ARSessionRunOptions)" />
	/// on the <see cref="P:ARKit.ARSCNView.Session" /> property. For example:
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// var arView = new ARSCNView();
	/// var arConfig = new ARWorldTrackingSessionConfiguration { PlaneDetection = ARPlaneDetection.Horizontal };
	/// arView.Session.Run (arConfig);
	/// ]]></code></example></remarks>
	[Register("ARSession", true)]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class ARSession : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ARSession");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="ARSession" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ARSession () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
				GC.KeepAlive (this);
				}
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
		protected ARSession (NSObjectFlag t) : base (t)
		{
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
		protected internal ARSession (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnchor (ARAnchor anchor)
		{
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addAnchor:"), anchor__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addAnchor:"), anchor__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anchor);
		}
		[Export ("captureHighResolutionFrameWithCompletion:")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CaptureHighResolutionFrame ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V1))]global::System.Action<ARFrame, NSError> handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity2V1.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("captureHighResolutionFrameWithCompletion:"), (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("captureHighResolutionFrameWithCompletion:"), (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<ARFrame> CaptureHighResolutionFrameAsync ()
		{
			var tcs = new TaskCompletionSource<ARFrame> ();
			CaptureHighResolutionFrame((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("captureHighResolutionFrameUsingPhotoSettings:completion:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CaptureHighResolutionFrame (global::AVFoundation.AVCapturePhotoSettings? photoSettings, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDARSessionCaptureHighResolutionFrame))]ARSessionCaptureHighResolutionFrame completion)
		{
			var photoSettings__handle__ = photoSettings.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDARSessionCaptureHighResolutionFrame.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("captureHighResolutionFrameUsingPhotoSettings:completion:"), photoSettings__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("captureHighResolutionFrameUsingPhotoSettings:completion:"), photoSettings__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (photoSettings);
		}
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<ARFrame> CaptureHighResolutionFrameAsync (global::AVFoundation.AVCapturePhotoSettings? photoSettings)
		{
			var tcs = new TaskCompletionSource<ARFrame> ();
			CaptureHighResolutionFrame(photoSettings, (frame_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (frame_!);
			});
			return tcs.Task;
		}
		[Export ("createReferenceObjectWithTransform:center:extent:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateReferenceObject (NMatrix4 transform, NVector3 center, NVector3 extent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V2))]global::System.Action<ARReferenceObject, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V2.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix4_NVector3_NVector3_NativeHandle (this.Handle, Selector.GetHandle ("createReferenceObjectWithTransform:center:extent:completionHandler:"), transform, center, extent, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix4_NVector3_NVector3_NativeHandle (&__objc_super__, Selector.GetHandle ("createReferenceObjectWithTransform:center:extent:completionHandler:"), transform, center, extent, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="transform">The transform to the position and orientation of the region from which to create a reference object.</param>
		/// <param name="center">The center of the region.</param>
		/// <param name="extent">The exent of the region, in the <paramref name="transform" /> coordinate space.</param>
		/// <summary>Asynchronously creates a reference object from a region in space and returns a task that contains the resulting object.</summary>
		/// <returns>A task that receives the created object, if present.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<ARReferenceObject> CreateReferenceObjectAsync (NMatrix4 transform, NVector3 center, NVector3 extent)
		{
			var tcs = new TaskCompletionSource<ARReferenceObject> ();
			CreateReferenceObject(transform, center, extent, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("getCurrentWorldMapWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetCurrentWorldMap ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<ARWorldMap, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V3.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("getCurrentWorldMapWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("getCurrentWorldMapWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Asynchronously returns a task that contains the current world map.</summary>
		/// <returns>A task that contains the current world map.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<ARWorldMap> GetCurrentWorldMapAsync ()
		{
			var tcs = new TaskCompletionSource<ARWorldMap> ();
			GetCurrentWorldMap((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("getGeoLocationForPoint:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetGeoLocation (NVector3 position, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGetGeolocationCallback))]GetGeolocationCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDGetGeolocationCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NVector3_NativeHandle (this.Handle, Selector.GetHandle ("getGeoLocationForPoint:completionHandler:"), position, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_NVector3_NativeHandle (&__objc_super__, Selector.GetHandle ("getGeoLocationForPoint:completionHandler:"), position, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GeoLocationForPoint> GetGeoLocationAsync (NVector3 position)
		{
			var tcs = new TaskCompletionSource<GeoLocationForPoint> ();
			GetGeoLocation(position, (coordinate_, altitude_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new GeoLocationForPoint (coordinate_!, altitude_!));
			});
			return tcs.Task;
		}
		[Export ("pause")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Pause ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("pause"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("pause"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("raycast:")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ARRaycastResult[] Raycast (ARRaycastQuery query)
		{
			var query__handle__ = query!.GetNonNullHandle (nameof (query));
			ARRaycastResult[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<ARRaycastResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("raycast:"), query__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<ARRaycastResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("raycast:"), query__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (query);
			return ret!;
		}
		[Export ("removeAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnchor (ARAnchor anchor)
		{
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeAnchor:"), anchor__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeAnchor:"), anchor__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anchor);
		}
		[Export ("runWithConfiguration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Run (ARConfiguration configuration)
		{
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("runWithConfiguration:"), configuration__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("runWithConfiguration:"), configuration__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (configuration);
		}
		[Export ("runWithConfiguration:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Run (ARConfiguration configuration, ARSessionRunOptions options)
		{
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("runWithConfiguration:options:"), configuration__handle__, (UIntPtr) (ulong) options);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("runWithConfiguration:options:"), configuration__handle__, (UIntPtr) (ulong) options);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (configuration);
		}
		[Export ("setWorldOrigin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetWorldOrigin (NMatrix4 relativeTransform)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix4 (this.Handle, Selector.GetHandle ("setWorldOrigin:"), relativeTransform);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix4 (&__objc_super__, Selector.GetHandle ("setWorldOrigin:"), relativeTransform);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("trackedRaycast:updateHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual ARTrackedRaycast? TrackedRaycast (ARRaycastQuery query, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<ARRaycastResult[]> updateHandler)
		{
			var query__handle__ = query!.GetNonNullHandle (nameof (query));
			if (updateHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (updateHandler));
			using var block_updateHandler = Trampolines.SDActionArity1V1.CreateBlock (updateHandler);
			BlockLiteral *block_ptr_updateHandler = &block_updateHandler;
			ARTrackedRaycast? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<ARTrackedRaycast> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("trackedRaycast:updateHandler:"), query__handle__, (IntPtr) block_ptr_updateHandler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<ARTrackedRaycast> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("trackedRaycast:updateHandler:"), query__handle__, (IntPtr) block_ptr_updateHandler), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (query);
			return ret!;
		}
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<ARRaycastResult[]> TrackedRaycastAsync (ARRaycastQuery query)
		{
			var tcs = new TaskCompletionSource<ARRaycastResult[]> ();
			TrackedRaycast(query, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<ARRaycastResult[]> TrackedRaycastAsync (ARRaycastQuery query, out ARTrackedRaycast result)
		{
			var tcs = new TaskCompletionSource<ARRaycastResult[]> ();
			result = TrackedRaycast(query, (obj_) => {
				tcs.SetResult (obj_!);
			})!;
			return tcs.Task;
		}
		[Export ("updateWithCollaborationData:")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update (ARCollaborationData collaborationData)
		{
			var collaborationData__handle__ = collaborationData!.GetNonNullHandle (nameof (collaborationData));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("updateWithCollaborationData:"), collaborationData__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("updateWithCollaborationData:"), collaborationData__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collaborationData);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ARConfiguration? Configuration {
			[Export ("configuration", ArgumentSemantic.Copy)]
			get {
				ARConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<ARConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("configuration")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<ARConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("configuration")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ARFrame? CurrentFrame {
			[Export ("currentFrame", ArgumentSemantic.Copy)]
			get {
				ARFrame? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<ARFrame> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("currentFrame")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<ARFrame> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("currentFrame")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Delegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IARSessionDelegate? Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IARSessionDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IARSessionDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IARSessionDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("delegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreFoundation.DispatchQueue? DelegateQueue {
			[Export ("delegateQueue", ArgumentSemantic.Retain)]
			get {
				global::CoreFoundation.DispatchQueue ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreFoundation.DispatchQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("delegateQueue")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreFoundation.DispatchQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("delegateQueue")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDelegateQueue:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDelegateQueue:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setDelegateQueue:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		public virtual NSUuid Identifier {
			[Export ("identifier", ArgumentSemantic.Retain)]
			get {
				NSUuid? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUuid> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("identifier")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUuid> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("identifier")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
			}
		}
	} /* class ARSession */
	//
	// Async result classes
	//
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class GeoLocationForPoint {
		/// <summary>The result value from the asynchronous operation.</summary>
		public global::CoreLocation.CLLocationCoordinate2D Coordinate { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public double Altitude { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="coordinate">Result value from an asynchronous operation.</param>
		/// <param name="altitude">Result value from an asynchronous operation.</param>
		public GeoLocationForPoint (global::CoreLocation.CLLocationCoordinate2D coordinate, double altitude) {
			this.Coordinate = coordinate;
			this.Altitude = altitude;
			Initialize ();
		}
	}
}
