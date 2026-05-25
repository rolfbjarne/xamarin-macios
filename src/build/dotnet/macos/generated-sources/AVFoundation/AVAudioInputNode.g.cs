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
	/// <summary>A <see cref="T:AVFoundation.AVAudioIONode" /> that connects to the device's audio input.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/documentation/avfaudio/avaudioinputnode">Apple documentation for <c>AVAudioInputNode</c></related>
	[Register("AVAudioInputNode", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVAudioInputNode : AVAudioIONode, IAVAudio3DMixing, IAVAudioMixing, IAVAudioStereoMixing {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationForMixer_Bus_X = "destinationForMixer:bus:";
		static readonly NativeHandle selDestinationForMixer_Bus_XHandle = Selector.GetHandle ("destinationForMixer:bus:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsVoiceProcessingAGCEnabledX = "isVoiceProcessingAGCEnabled";
		static readonly NativeHandle selIsVoiceProcessingAGCEnabledXHandle = Selector.GetHandle ("isVoiceProcessingAGCEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsVoiceProcessingBypassedX = "isVoiceProcessingBypassed";
		static readonly NativeHandle selIsVoiceProcessingBypassedXHandle = Selector.GetHandle ("isVoiceProcessingBypassed");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsVoiceProcessingInputMutedX = "isVoiceProcessingInputMuted";
		static readonly NativeHandle selIsVoiceProcessingInputMutedXHandle = Selector.GetHandle ("isVoiceProcessingInputMuted");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObstructionX = "obstruction";
		static readonly NativeHandle selObstructionXHandle = Selector.GetHandle ("obstruction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOcclusionX = "occlusion";
		static readonly NativeHandle selOcclusionXHandle = Selector.GetHandle ("occlusion");
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
		const string selSetManualRenderingInputPCMFormat_InputBlock_X = "setManualRenderingInputPCMFormat:inputBlock:";
		static readonly NativeHandle selSetManualRenderingInputPCMFormat_InputBlock_XHandle = Selector.GetHandle ("setManualRenderingInputPCMFormat:inputBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMutedSpeechActivityEventListener_X = "setMutedSpeechActivityEventListener:";
		static readonly NativeHandle selSetMutedSpeechActivityEventListener_XHandle = Selector.GetHandle ("setMutedSpeechActivityEventListener:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetObstruction_X = "setObstruction:";
		static readonly NativeHandle selSetObstruction_XHandle = Selector.GetHandle ("setObstruction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOcclusion_X = "setOcclusion:";
		static readonly NativeHandle selSetOcclusion_XHandle = Selector.GetHandle ("setOcclusion:");
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
		const string selSetVoiceProcessingAGCEnabled_X = "setVoiceProcessingAGCEnabled:";
		static readonly NativeHandle selSetVoiceProcessingAGCEnabled_XHandle = Selector.GetHandle ("setVoiceProcessingAGCEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVoiceProcessingBypassed_X = "setVoiceProcessingBypassed:";
		static readonly NativeHandle selSetVoiceProcessingBypassed_XHandle = Selector.GetHandle ("setVoiceProcessingBypassed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVoiceProcessingInputMuted_X = "setVoiceProcessingInputMuted:";
		static readonly NativeHandle selSetVoiceProcessingInputMuted_XHandle = Selector.GetHandle ("setVoiceProcessingInputMuted:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVoiceProcessingOtherAudioDuckingConfiguration_X = "setVoiceProcessingOtherAudioDuckingConfiguration:";
		static readonly NativeHandle selSetVoiceProcessingOtherAudioDuckingConfiguration_XHandle = Selector.GetHandle ("setVoiceProcessingOtherAudioDuckingConfiguration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVolume_X = "setVolume:";
		static readonly NativeHandle selSetVolume_XHandle = Selector.GetHandle ("setVolume:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceModeX = "sourceMode";
		static readonly NativeHandle selSourceModeXHandle = Selector.GetHandle ("sourceMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVoiceProcessingOtherAudioDuckingConfigurationX = "voiceProcessingOtherAudioDuckingConfiguration";
		static readonly NativeHandle selVoiceProcessingOtherAudioDuckingConfigurationXHandle = Selector.GetHandle ("voiceProcessingOtherAudioDuckingConfiguration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVolumeX = "volume";
		static readonly NativeHandle selVolumeXHandle = Selector.GetHandle ("volume");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVAudioInputNode");
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
		protected AVAudioInputNode (NSObjectFlag t) : base (t)
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
		protected internal AVAudioInputNode (NativeHandle handle) : base (handle)
		{
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
		/// <param name="format">To be added.</param><param name="block">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("setManualRenderingInputPCMFormat:inputBlock:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetManualRenderingInputPcmFormat (AVAudioFormat format, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVAudioIONodeInputBlock))]AVAudioIONodeInputBlock block)
		{
			var format__handle__ = format!.GetNonNullHandle (nameof (format));
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDAVAudioIONodeInputBlock.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetManualRenderingInputPCMFormat_InputBlock_XHandle, format__handle__, (IntPtr) block_ptr_block);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetManualRenderingInputPCMFormat_InputBlock_XHandle, format__handle__, (IntPtr) block_ptr_block);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (format);
			return ret != 0;
		}
		[Export ("setMutedSpeechActivityEventListener:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetMutedSpeechActivityEventListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVAudioInputNodeMutedSpeechEventListener))]AVAudioInputNodeMutedSpeechEventListener? listenerAction)
		{
			using var block_listenerAction = Trampolines.SDAVAudioInputNodeMutedSpeechEventListener.CreateNullableBlock (listenerAction);
			BlockLiteral *block_ptr_listenerAction = null;
			if (listenerAction is not null)
				block_ptr_listenerAction = &block_listenerAction;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selSetMutedSpeechActivityEventListener_XHandle, (IntPtr) block_ptr_listenerAction);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMutedSpeechActivityEventListener_XHandle, (IntPtr) block_ptr_listenerAction);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool VoiceProcessingAgcEnabled {
			[Export ("isVoiceProcessingAGCEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsVoiceProcessingAGCEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsVoiceProcessingAGCEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setVoiceProcessingAGCEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetVoiceProcessingAGCEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetVoiceProcessingAGCEnabled_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual bool VoiceProcessingBypassed {
			[Export ("isVoiceProcessingBypassed")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsVoiceProcessingBypassedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsVoiceProcessingBypassedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setVoiceProcessingBypassed:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetVoiceProcessingBypassed_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetVoiceProcessingBypassed_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual bool VoiceProcessingInputMuted {
			[Export ("isVoiceProcessingInputMuted")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsVoiceProcessingInputMutedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsVoiceProcessingInputMutedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setVoiceProcessingInputMuted:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetVoiceProcessingInputMuted_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetVoiceProcessingInputMuted_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual AVAudioVoiceProcessingOtherAudioDuckingConfiguration VoiceProcessingOtherAudioDuckingConfiguration {
			[Export ("voiceProcessingOtherAudioDuckingConfiguration", ArgumentSemantic.Assign)]
			get {
				AVAudioVoiceProcessingOtherAudioDuckingConfiguration ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.AVAudioVoiceProcessingOtherAudioDuckingConfiguration_objc_msgSend (this.Handle, selVoiceProcessingOtherAudioDuckingConfigurationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.AVAudioVoiceProcessingOtherAudioDuckingConfiguration_objc_msgSendSuper (&__objc_super__, selVoiceProcessingOtherAudioDuckingConfigurationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setVoiceProcessingOtherAudioDuckingConfiguration:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_AVAudioVoiceProcessingOtherAudioDuckingConfiguration (this.Handle, selSetVoiceProcessingOtherAudioDuckingConfiguration_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_AVAudioVoiceProcessingOtherAudioDuckingConfiguration (&__objc_super__, selSetVoiceProcessingOtherAudioDuckingConfiguration_XHandle, value);
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
	} /* class AVAudioInputNode */
}
