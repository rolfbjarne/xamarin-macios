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
	/// <summary>The link between capture input and capture output objects during a capture session.</summary><remarks><para>A <see cref="T:AVFoundation.AVCaptureConnection" /> encapsulates the link between an <see cref="T:AVFoundation.AVCaptureInput" /> (more specifically, between an individual <see cref="T:AVFoundation.AVCaptureInputPort" /> in the <see cref="P:AVFoundation.AVCaptureInput.Ports" /> property of the <see cref="T:AVFoundation.AVCaptureInput" /> and the <see cref="T:AVFoundation.AVCaptureOutput" />).</para><para><see cref="T:AVFoundation.AVCaptureConnection" />s are formed automatically when inputs and outputs are added via <see cref="M:AVFoundation.AVCaptureSession.AddInput(AVFoundation.AVCaptureInput)" /> and <see cref="M:AVFoundation.AVCaptureSession.AddOutput(AVFoundation.AVCaptureOutput)" />.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AVFoundation/Reference/AVCaptureConnection_Class/index.html">Apple documentation for <c>AVCaptureConnection</c></related>
	[Register("AVCaptureConnection", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AVCaptureConnection : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVCaptureConnection");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="AVCaptureConnection" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVCaptureConnection () : base (NSObjectFlag.Empty)
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
		protected AVCaptureConnection (NSObjectFlag t) : base (t)
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
		protected internal AVCaptureConnection (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithInputPorts:output:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVCaptureConnection (AVCaptureInputPort[] inputPorts, AVCaptureOutput output)
			: base (NSObjectFlag.Empty)
		{
			if (inputPorts is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inputPorts));
			var output__handle__ = output!.GetNonNullHandle (nameof (output));
			using var nsa_inputPorts = NSArray.FromNSObjects (inputPorts);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithInputPorts:output:"), nsa_inputPorts.Handle, output__handle__), "initWithInputPorts:output:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithInputPorts:output:"), nsa_inputPorts.Handle, output__handle__), "initWithInputPorts:output:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (output);
		}
		[Export ("initWithInputPort:videoPreviewLayer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVCaptureConnection (AVCaptureInputPort inputPort, AVCaptureVideoPreviewLayer layer)
			: base (NSObjectFlag.Empty)
		{
			var inputPort__handle__ = inputPort!.GetNonNullHandle (nameof (inputPort));
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithInputPort:videoPreviewLayer:"), inputPort__handle__, layer__handle__), "initWithInputPort:videoPreviewLayer:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithInputPort:videoPreviewLayer:"), inputPort__handle__, layer__handle__), "initWithInputPort:videoPreviewLayer:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inputPort);
			GC.KeepAlive (layer);
		}
		[Export ("connectionWithInputPort:videoPreviewLayer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVCaptureConnection FromInputPort (AVCaptureInputPort port, AVCaptureVideoPreviewLayer layer)
		{
			var port__handle__ = port!.GetNonNullHandle (nameof (port));
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			AVCaptureConnection? ret;
			ret =  Runtime.GetNSObject<AVCaptureConnection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("connectionWithInputPort:videoPreviewLayer:"), port__handle__, layer__handle__), false)!;
			GC.KeepAlive (port);
			GC.KeepAlive (layer);
			return ret!;
		}
		[Export ("connectionWithInputPorts:output:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVCaptureConnection FromInputPorts (AVCaptureInputPort[] ports, AVCaptureOutput output)
		{
			if (ports is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ports));
			var output__handle__ = output!.GetNonNullHandle (nameof (output));
			using var nsa_ports = NSArray.FromNSObjects (ports);
			AVCaptureConnection? ret;
			ret =  Runtime.GetNSObject<AVCaptureConnection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("connectionWithInputPorts:output:"), nsa_ports.Handle, output__handle__), false)!;
			GC.KeepAlive (output);
			return ret!;
		}
		[Export ("isVideoRotationAngleSupported:")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsVideoRotationAngleSupported (nfloat videoRotationAngle)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("isVideoRotationAngleSupported:"), videoRotationAngle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("isVideoRotationAngleSupported:"), videoRotationAngle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <summary>Whether the connection is active.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Active {
			[Export ("isActive")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isActive"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isActive"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual AVCaptureVideoStabilizationMode ActiveVideoStabilizationMode {
			[Export ("activeVideoStabilizationMode")]
			get {
				AVCaptureVideoStabilizationMode ret;
				if (IsDirectBinding) {
					ret = (AVCaptureVideoStabilizationMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("activeVideoStabilizationMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCaptureVideoStabilizationMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("activeVideoStabilizationMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutomaticallyAdjustsVideoMirroring {
			[Export ("automaticallyAdjustsVideoMirroring")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("automaticallyAdjustsVideoMirroring"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("automaticallyAdjustsVideoMirroring"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutomaticallyAdjustsVideoMirroring:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutomaticallyAdjustsVideoMirroring:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAutomaticallyAdjustsVideoMirroring:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVCaptureAudioChannel[] AvailableAudioChannels {
			[Export ("audioChannels")]
			get {
				AVCaptureAudioChannel[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVCaptureAudioChannel>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("audioChannels")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCaptureAudioChannel>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("audioChannels")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the connection will deliver camera intrinsics data.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool CameraIntrinsicMatrixDeliveryEnabled {
			[Export ("isCameraIntrinsicMatrixDeliveryEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isCameraIntrinsicMatrixDeliveryEnabled"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isCameraIntrinsicMatrixDeliveryEnabled"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setCameraIntrinsicMatrixDeliveryEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCameraIntrinsicMatrixDeliveryEnabled:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setCameraIntrinsicMatrixDeliveryEnabled:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the connection can deliver camera intrinsics data.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool CameraIntrinsicMatrixDeliverySupported {
			[Export ("isCameraIntrinsicMatrixDeliverySupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isCameraIntrinsicMatrixDeliverySupported"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isCameraIntrinsicMatrixDeliverySupported"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Whether the connection is enabled.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Enabled {
			[Export ("isEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEnabled"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isEnabled"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnabled:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setEnabled:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'PreferredVideoStabilizationMode' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'PreferredVideoStabilizationMode' instead.")]
		[SupportedOSPlatform ("ios")]
		public virtual bool EnablesVideoStabilizationWhenAvailable {
			[Export ("enablesVideoStabilizationWhenAvailable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enablesVideoStabilizationWhenAvailable"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("enablesVideoStabilizationWhenAvailable"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEnablesVideoStabilizationWhenAvailable:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnablesVideoStabilizationWhenAvailable:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setEnablesVideoStabilizationWhenAvailable:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVCaptureInputPort[] InputPorts {
			[Export ("inputPorts")]
			get {
				AVCaptureInputPort[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVCaptureInputPort>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("inputPorts")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCaptureInputPort>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("inputPorts")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVCaptureOutput? Output {
			[Export ("output")]
			get {
				AVCaptureOutput? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVCaptureOutput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("output")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVCaptureOutput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("output")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual AVCaptureVideoStabilizationMode PreferredVideoStabilizationMode {
			[Export ("preferredVideoStabilizationMode")]
			get {
				AVCaptureVideoStabilizationMode ret;
				if (IsDirectBinding) {
					ret = (AVCaptureVideoStabilizationMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("preferredVideoStabilizationMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCaptureVideoStabilizationMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredVideoStabilizationMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPreferredVideoStabilizationMode:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPreferredVideoStabilizationMode:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setPreferredVideoStabilizationMode:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>This method is deprecated in iOS 7. Whether the maximum interval allowed between frames can be set.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("maccatalyst14.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool SupportsVideoMaxFrameDuration {
			[Export ("isVideoMaxFrameDurationSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isVideoMaxFrameDurationSupported"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isVideoMaxFrameDurationSupported"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>This method is deprecated in iOS 7. Whether the minimum interval allowed between frames can be set.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("maccatalyst14.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool SupportsVideoMinFrameDuration {
			[Export ("isVideoMinFrameDurationSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isVideoMinFrameDurationSupported"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isVideoMinFrameDurationSupported"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Whether the video being captured can be automatically mirrored about its vertical axis.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SupportsVideoMirroring {
			[Export ("isVideoMirroringSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isVideoMirroringSupported"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isVideoMirroringSupported"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Whether the video capture buffers can be rotated.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos14.0", "Use 'IsVideoRotationAngleSupported' instead.")]
		[ObsoletedOSPlatform ("ios17.0", "Use 'IsVideoRotationAngleSupported' instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use 'IsVideoRotationAngleSupported' instead.")]
		[ObsoletedOSPlatform ("tvos17.0", "Use 'IsVideoRotationAngleSupported' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool SupportsVideoOrientation {
			[Export ("isVideoOrientationSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isVideoOrientationSupported"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isVideoOrientationSupported"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Whether the video can be automatically stabilized.</summary><value>To be added.</value><remarks><para>Application developers should consider the overhead of video stabilization, which may be significant.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool SupportsVideoStabilization {
			[Export ("isVideoStabilizationSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isVideoStabilizationSupported"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isVideoStabilizationSupported"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("maccatalyst14.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::CoreMedia.CMTime VideoMaxFrameDuration {
			[Export ("videoMaxFrameDuration")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, Selector.GetHandle ("videoMaxFrameDuration"));
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, Selector.GetHandle ("videoMaxFrameDuration"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("videoMaxFrameDuration"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("videoMaxFrameDuration"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setVideoMaxFrameDuration:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime (this.Handle, Selector.GetHandle ("setVideoMaxFrameDuration:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime (&__objc_super__, Selector.GetHandle ("setVideoMaxFrameDuration:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual nfloat VideoMaxScaleAndCropFactor {
			[Export ("videoMaxScaleAndCropFactor")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("videoMaxScaleAndCropFactor"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("videoMaxScaleAndCropFactor"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("maccatalyst14.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::CoreMedia.CMTime VideoMinFrameDuration {
			[Export ("videoMinFrameDuration")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, Selector.GetHandle ("videoMinFrameDuration"));
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, Selector.GetHandle ("videoMinFrameDuration"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("videoMinFrameDuration"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("videoMinFrameDuration"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setVideoMinFrameDuration:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime (this.Handle, Selector.GetHandle ("setVideoMinFrameDuration:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime (&__objc_super__, Selector.GetHandle ("setVideoMinFrameDuration:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether the captured video is being mirrored around its vertical axis.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool VideoMirrored {
			[Export ("isVideoMirrored")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isVideoMirrored"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isVideoMirrored"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setVideoMirrored:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setVideoMirrored:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setVideoMirrored:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios17.0", "Use VideoRotationAngle instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use VideoRotationAngle instead.")]
		[ObsoletedOSPlatform ("macos14.0", "Use VideoRotationAngle instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual AVCaptureVideoOrientation VideoOrientation {
			[Export ("videoOrientation", ArgumentSemantic.Assign)]
			get {
				AVCaptureVideoOrientation ret;
				if (IsDirectBinding) {
					ret = (AVCaptureVideoOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("videoOrientation"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCaptureVideoOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("videoOrientation"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setVideoOrientation:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setVideoOrientation:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setVideoOrientation:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVCaptureVideoPreviewLayer? VideoPreviewLayer {
			[Export ("videoPreviewLayer")]
			get {
				AVCaptureVideoPreviewLayer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVCaptureVideoPreviewLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("videoPreviewLayer")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVCaptureVideoPreviewLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("videoPreviewLayer")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual nfloat VideoRotationAngle {
			[Export ("videoRotationAngle")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("videoRotationAngle"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("videoRotationAngle"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setVideoRotationAngle:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setVideoRotationAngle:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setVideoRotationAngle:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual nfloat VideoScaleAndCropFactor {
			[Export ("videoScaleAndCropFactor")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("videoScaleAndCropFactor"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("videoScaleAndCropFactor"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setVideoScaleAndCropFactor:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setVideoScaleAndCropFactor:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setVideoScaleAndCropFactor:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether the video being captured is being automatically stabilized.</summary><value>The default value is <see langword="false" />.</value><remarks><para>Not every iOS device supports video stabilization and stabilization is not available for all capture settings.</para><para>Video stabilization is an expensive operation and may increase capture latency and increase power and CPU consumption. Application developers should consider the overhead when deciding whether or not to use stabilization.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'ActiveVideoStabilizationMode' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ActiveVideoStabilizationMode' instead.")]
		[SupportedOSPlatform ("ios")]
		public virtual bool VideoStabilizationEnabled {
			[Export ("isVideoStabilizationEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isVideoStabilizationEnabled"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isVideoStabilizationEnabled"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
	} /* class AVCaptureConnection */
}
