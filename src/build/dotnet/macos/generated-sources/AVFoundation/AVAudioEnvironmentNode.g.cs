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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
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
	/// <summary>A <see cref="T:AVFoundation.AVAudioNode" /> that simulates a 3D audio environment.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/documentation/avfaudio/avaudioenvironmentnode">Apple documentation for <c>AVAudioEnvironmentNode</c></related>
	[Register("AVAudioEnvironmentNode", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVAudioEnvironmentNode : AVAudioNode, IAVAudio3DMixing, IAVAudioMixing, IAVAudioStereoMixing {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplicableRenderingAlgorithmsX = "applicableRenderingAlgorithms";
		static readonly NativeHandle selApplicableRenderingAlgorithmsXHandle = Selector.GetHandle ("applicableRenderingAlgorithms");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationForMixer_Bus_X = "destinationForMixer:bus:";
		static readonly NativeHandle selDestinationForMixer_Bus_XHandle = Selector.GetHandle ("destinationForMixer:bus:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDistanceAttenuationParametersX = "distanceAttenuationParameters";
		static readonly NativeHandle selDistanceAttenuationParametersXHandle = Selector.GetHandle ("distanceAttenuationParameters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitX = "init";
		static readonly NativeHandle selInitXHandle = Selector.GetHandle ("init");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsListenerHeadTrackingEnabledX = "isListenerHeadTrackingEnabled";
		static readonly NativeHandle selIsListenerHeadTrackingEnabledXHandle = Selector.GetHandle ("isListenerHeadTrackingEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selListenerAngularOrientationX = "listenerAngularOrientation";
		static readonly NativeHandle selListenerAngularOrientationXHandle = Selector.GetHandle ("listenerAngularOrientation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selListenerPositionX = "listenerPosition";
		static readonly NativeHandle selListenerPositionXHandle = Selector.GetHandle ("listenerPosition");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selListenerVectorOrientationX = "listenerVectorOrientation";
		static readonly NativeHandle selListenerVectorOrientationXHandle = Selector.GetHandle ("listenerVectorOrientation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNextAvailableInputBusX = "nextAvailableInputBus";
		static readonly NativeHandle selNextAvailableInputBusXHandle = Selector.GetHandle ("nextAvailableInputBus");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObstructionX = "obstruction";
		static readonly NativeHandle selObstructionXHandle = Selector.GetHandle ("obstruction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOcclusionX = "occlusion";
		static readonly NativeHandle selOcclusionXHandle = Selector.GetHandle ("occlusion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputTypeX = "outputType";
		static readonly NativeHandle selOutputTypeXHandle = Selector.GetHandle ("outputType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputVolumeX = "outputVolume";
		static readonly NativeHandle selOutputVolumeXHandle = Selector.GetHandle ("outputVolume");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPanX = "pan";
		static readonly NativeHandle selPanXHandle = Selector.GetHandle ("pan");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPointSourceInHeadModeX = "pointSourceInHeadMode";
		static readonly NativeHandle selPointSourceInHeadModeXHandle = Selector.GetHandle ("pointSourceInHeadMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPositionX = "position";
		static readonly NativeHandle selPositionXHandle = Selector.GetHandle ("position");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRateX = "rate";
		static readonly NativeHandle selRateXHandle = Selector.GetHandle ("rate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderingAlgorithmX = "renderingAlgorithm";
		static readonly NativeHandle selRenderingAlgorithmXHandle = Selector.GetHandle ("renderingAlgorithm");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReverbBlendX = "reverbBlend";
		static readonly NativeHandle selReverbBlendXHandle = Selector.GetHandle ("reverbBlend");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReverbParametersX = "reverbParameters";
		static readonly NativeHandle selReverbParametersXHandle = Selector.GetHandle ("reverbParameters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetListenerAngularOrientation_X = "setListenerAngularOrientation:";
		static readonly NativeHandle selSetListenerAngularOrientation_XHandle = Selector.GetHandle ("setListenerAngularOrientation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetListenerHeadTrackingEnabled_X = "setListenerHeadTrackingEnabled:";
		static readonly NativeHandle selSetListenerHeadTrackingEnabled_XHandle = Selector.GetHandle ("setListenerHeadTrackingEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetListenerPosition_X = "setListenerPosition:";
		static readonly NativeHandle selSetListenerPosition_XHandle = Selector.GetHandle ("setListenerPosition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetListenerVectorOrientation_X = "setListenerVectorOrientation:";
		static readonly NativeHandle selSetListenerVectorOrientation_XHandle = Selector.GetHandle ("setListenerVectorOrientation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetObstruction_X = "setObstruction:";
		static readonly NativeHandle selSetObstruction_XHandle = Selector.GetHandle ("setObstruction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOcclusion_X = "setOcclusion:";
		static readonly NativeHandle selSetOcclusion_XHandle = Selector.GetHandle ("setOcclusion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOutputType_X = "setOutputType:";
		static readonly NativeHandle selSetOutputType_XHandle = Selector.GetHandle ("setOutputType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOutputVolume_X = "setOutputVolume:";
		static readonly NativeHandle selSetOutputVolume_XHandle = Selector.GetHandle ("setOutputVolume:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPan_X = "setPan:";
		static readonly NativeHandle selSetPan_XHandle = Selector.GetHandle ("setPan:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPointSourceInHeadMode_X = "setPointSourceInHeadMode:";
		static readonly NativeHandle selSetPointSourceInHeadMode_XHandle = Selector.GetHandle ("setPointSourceInHeadMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPosition_X = "setPosition:";
		static readonly NativeHandle selSetPosition_XHandle = Selector.GetHandle ("setPosition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRate_X = "setRate:";
		static readonly NativeHandle selSetRate_XHandle = Selector.GetHandle ("setRate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRenderingAlgorithm_X = "setRenderingAlgorithm:";
		static readonly NativeHandle selSetRenderingAlgorithm_XHandle = Selector.GetHandle ("setRenderingAlgorithm:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetReverbBlend_X = "setReverbBlend:";
		static readonly NativeHandle selSetReverbBlend_XHandle = Selector.GetHandle ("setReverbBlend:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSourceMode_X = "setSourceMode:";
		static readonly NativeHandle selSetSourceMode_XHandle = Selector.GetHandle ("setSourceMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVolume_X = "setVolume:";
		static readonly NativeHandle selSetVolume_XHandle = Selector.GetHandle ("setVolume:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceModeX = "sourceMode";
		static readonly NativeHandle selSourceModeXHandle = Selector.GetHandle ("sourceMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVolumeX = "volume";
		static readonly NativeHandle selVolumeXHandle = Selector.GetHandle ("volume");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVAudioEnvironmentNode");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected AVAudioEnvironmentNode (NSObjectFlag t) : base (t)
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
		protected internal AVAudioEnvironmentNode (NativeHandle handle) : base (handle)
		{
		}

		[Export ("init")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVAudioEnvironmentNode ()
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInitXHandle), "init");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInitXHandle), "init");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="mixer">To be added.</param><param name="bus">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("destinationForMixer:bus:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAudioMixingDestination? DestinationForMixer (AVAudioNode mixer, nuint bus)
		{
			var mixer__handle__ = mixer!.GetNonNullHandle (nameof (mixer));
			AVAudioMixingDestination? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AVAudioMixingDestination> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selDestinationForMixer_Bus_XHandle, mixer__handle__, bus), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<AVAudioMixingDestination> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selDestinationForMixer_Bus_XHandle, mixer__handle__, bus), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mixer);
			return ret!;
		}
		/// <summary>Returns an array of rendering algorithms that can be meaningfully applied to the node.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber[] ApplicableRenderingAlgorithms {
			[Export ("applicableRenderingAlgorithms")]
			get {
				NSNumber[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selApplicableRenderingAlgorithmsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selApplicableRenderingAlgorithmsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the parameters that control the attenuation of sound over distance in the environment.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAudioEnvironmentDistanceAttenuationParameters DistanceAttenuationParameters {
			[Export ("distanceAttenuationParameters")]
			get {
				AVAudioEnvironmentDistanceAttenuationParameters? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAudioEnvironmentDistanceAttenuationParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDistanceAttenuationParametersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAudioEnvironmentDistanceAttenuationParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDistanceAttenuationParametersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets the direction in which the listener is facing.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAudio3DAngularOrientation ListenerAngularOrientation {
			[Export ("listenerAngularOrientation", ArgumentSemantic.Assign)]
			get {
				AVAudio3DAngularOrientation ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.AVAudio3DAngularOrientation_objc_msgSend (this.Handle, selListenerAngularOrientationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.AVAudio3DAngularOrientation_objc_msgSendSuper (&__objc_super__, selListenerAngularOrientationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setListenerAngularOrientation:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_AVAudio3DAngularOrientation (this.Handle, selSetListenerAngularOrientation_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_AVAudio3DAngularOrientation (&__objc_super__, selSetListenerAngularOrientation_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual bool ListenerHeadTrackingEnabled {
			[Export ("isListenerHeadTrackingEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsListenerHeadTrackingEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsListenerHeadTrackingEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setListenerHeadTrackingEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetListenerHeadTrackingEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetListenerHeadTrackingEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the position of the listener.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector3 ListenerPosition {
			[Export ("listenerPosition", ArgumentSemantic.Assign)]
			get {
				global::System.Numerics.Vector3 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Vector3_objc_msgSend (this.Handle, selListenerPositionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Vector3_objc_msgSendSuper (&__objc_super__, selListenerPositionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setListenerPosition:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Vector3 (this.Handle, selSetListenerPosition_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Vector3 (&__objc_super__, selSetListenerPosition_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a vector that represents direction in which the listener is facing.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAudio3DVectorOrientation ListenerVectorOrientation {
			[Export ("listenerVectorOrientation", ArgumentSemantic.Assign)]
			get {
				AVAudio3DVectorOrientation ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.AVAudio3DVectorOrientation_objc_msgSend (this.Handle, selListenerVectorOrientationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.AVAudio3DVectorOrientation_objc_msgSendSuper (&__objc_super__, selListenerVectorOrientationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setListenerVectorOrientation:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_AVAudio3DVectorOrientation (this.Handle, selSetListenerVectorOrientation_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_AVAudio3DVectorOrientation (&__objc_super__, selSetListenerVectorOrientation_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the next available input bus.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint NextAvailableInputBus {
			[Export ("nextAvailableInputBus")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selNextAvailableInputBusXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selNextAvailableInputBusXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual float Obstruction {
			[Export ("obstruction")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selObstructionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selObstructionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setObstruction:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetObstruction_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetObstruction_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual float Occlusion {
			[Export ("occlusion")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selOcclusionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selOcclusionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setOcclusion:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetOcclusion_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetOcclusion_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual AVAudioEnvironmentOutputType OutputType {
			[Export ("outputType", ArgumentSemantic.Assign)]
			get {
				AVAudioEnvironmentOutputType ret;
				if (IsDirectBinding) {
					ret = (AVAudioEnvironmentOutputType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOutputTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVAudioEnvironmentOutputType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selOutputTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOutputType:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetOutputType_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetOutputType_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float OutputVolume {
			[Export ("outputVolume")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selOutputVolumeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selOutputVolumeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setOutputVolume:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetOutputVolume_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetOutputVolume_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual float Pan {
			[Export ("pan")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selPanXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selPanXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPan:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetPan_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetPan_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual AVAudio3DMixingPointSourceInHeadMode PointSourceInHeadMode {
			[Export ("pointSourceInHeadMode", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				AVAudio3DMixingPointSourceInHeadMode ret;
				if (IsDirectBinding) {
					ret = (AVAudio3DMixingPointSourceInHeadMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPointSourceInHeadModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVAudio3DMixingPointSourceInHeadMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selPointSourceInHeadModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPointSourceInHeadMode:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPointSourceInHeadMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetPointSourceInHeadMode_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::System.Numerics.Vector3 Position {
			[Export ("position")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::System.Numerics.Vector3 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Vector3_objc_msgSend (this.Handle, selPositionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Vector3_objc_msgSendSuper (&__objc_super__, selPositionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPosition:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Vector3 (this.Handle, selSetPosition_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Vector3 (&__objc_super__, selSetPosition_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual float Rate {
			[Export ("rate")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selRateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRate:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetRate_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetRate_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual AVAudio3DMixingRenderingAlgorithm RenderingAlgorithm {
			[Export ("renderingAlgorithm")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				AVAudio3DMixingRenderingAlgorithm ret;
				if (IsDirectBinding) {
					ret = (AVAudio3DMixingRenderingAlgorithm) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRenderingAlgorithmXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVAudio3DMixingRenderingAlgorithm) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selRenderingAlgorithmXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setRenderingAlgorithm:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRenderingAlgorithm_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetRenderingAlgorithm_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual float ReverbBlend {
			[Export ("reverbBlend")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selReverbBlendXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selReverbBlendXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setReverbBlend:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetReverbBlend_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetReverbBlend_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the reverb parameters for the environment.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAudioEnvironmentReverbParameters ReverbParameters {
			[Export ("reverbParameters")]
			get {
				AVAudioEnvironmentReverbParameters? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAudioEnvironmentReverbParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selReverbParametersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAudioEnvironmentReverbParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selReverbParametersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual AVAudio3DMixingSourceMode SourceMode {
			[Export ("sourceMode", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				AVAudio3DMixingSourceMode ret;
				if (IsDirectBinding) {
					ret = (AVAudio3DMixingSourceMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSourceModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVAudio3DMixingSourceMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selSourceModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSourceMode:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSourceMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetSourceMode_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual float Volume {
			[Export ("volume")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selVolumeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selVolumeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setVolume:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetVolume_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetVolume_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class AVAudioEnvironmentNode */
}
