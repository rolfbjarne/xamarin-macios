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
	/// <summary>A <see cref="T:AVFoundation.AVAudioNode" /> that plays segments of audio files.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/documentation/avfaudio/avaudioplayernode">Apple documentation for <c>AVAudioPlayerNode</c></related>
	[Register("AVAudioPlayerNode", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVAudioPlayerNode : AVAudioNode, IAVAudio3DMixing, IAVAudioMixing, IAVAudioStereoMixing {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationForMixer_Bus_X = "destinationForMixer:bus:";
		static readonly NativeHandle selDestinationForMixer_Bus_XHandle = Selector.GetHandle ("destinationForMixer:bus:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitX = "init";
		static readonly NativeHandle selInitXHandle = Selector.GetHandle ("init");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPlayingX = "isPlaying";
		static readonly NativeHandle selIsPlayingXHandle = Selector.GetHandle ("isPlaying");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodeTimeForPlayerTime_X = "nodeTimeForPlayerTime:";
		static readonly NativeHandle selNodeTimeForPlayerTime_XHandle = Selector.GetHandle ("nodeTimeForPlayerTime:");
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
		const string selPauseX = "pause";
		static readonly NativeHandle selPauseXHandle = Selector.GetHandle ("pause");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlayX = "play";
		static readonly NativeHandle selPlayXHandle = Selector.GetHandle ("play");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlayAtTime_X = "playAtTime:";
		static readonly NativeHandle selPlayAtTime_XHandle = Selector.GetHandle ("playAtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlayerTimeForNodeTime_X = "playerTimeForNodeTime:";
		static readonly NativeHandle selPlayerTimeForNodeTime_XHandle = Selector.GetHandle ("playerTimeForNodeTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPointSourceInHeadModeX = "pointSourceInHeadMode";
		static readonly NativeHandle selPointSourceInHeadModeXHandle = Selector.GetHandle ("pointSourceInHeadMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPositionX = "position";
		static readonly NativeHandle selPositionXHandle = Selector.GetHandle ("position");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareWithFrameCount_X = "prepareWithFrameCount:";
		static readonly NativeHandle selPrepareWithFrameCount_XHandle = Selector.GetHandle ("prepareWithFrameCount:");
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
		const string selScheduleBuffer_AtTime_Options_CompletionCallbackType_CompletionHandler_X = "scheduleBuffer:atTime:options:completionCallbackType:completionHandler:";
		static readonly NativeHandle selScheduleBuffer_AtTime_Options_CompletionCallbackType_CompletionHandler_XHandle = Selector.GetHandle ("scheduleBuffer:atTime:options:completionCallbackType:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScheduleBuffer_AtTime_Options_CompletionHandler_X = "scheduleBuffer:atTime:options:completionHandler:";
		static readonly NativeHandle selScheduleBuffer_AtTime_Options_CompletionHandler_XHandle = Selector.GetHandle ("scheduleBuffer:atTime:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScheduleBuffer_CompletionCallbackType_CompletionHandler_X = "scheduleBuffer:completionCallbackType:completionHandler:";
		static readonly NativeHandle selScheduleBuffer_CompletionCallbackType_CompletionHandler_XHandle = Selector.GetHandle ("scheduleBuffer:completionCallbackType:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScheduleBuffer_CompletionHandler_X = "scheduleBuffer:completionHandler:";
		static readonly NativeHandle selScheduleBuffer_CompletionHandler_XHandle = Selector.GetHandle ("scheduleBuffer:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScheduleFile_AtTime_CompletionCallbackType_CompletionHandler_X = "scheduleFile:atTime:completionCallbackType:completionHandler:";
		static readonly NativeHandle selScheduleFile_AtTime_CompletionCallbackType_CompletionHandler_XHandle = Selector.GetHandle ("scheduleFile:atTime:completionCallbackType:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScheduleFile_AtTime_CompletionHandler_X = "scheduleFile:atTime:completionHandler:";
		static readonly NativeHandle selScheduleFile_AtTime_CompletionHandler_XHandle = Selector.GetHandle ("scheduleFile:atTime:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScheduleSegment_StartingFrame_FrameCount_AtTime_CompletionCallbackType_CompletionHandler_X = "scheduleSegment:startingFrame:frameCount:atTime:completionCallbackType:completionHandler:";
		static readonly NativeHandle selScheduleSegment_StartingFrame_FrameCount_AtTime_CompletionCallbackType_CompletionHandler_XHandle = Selector.GetHandle ("scheduleSegment:startingFrame:frameCount:atTime:completionCallbackType:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScheduleSegment_StartingFrame_FrameCount_AtTime_CompletionHandler_X = "scheduleSegment:startingFrame:frameCount:atTime:completionHandler:";
		static readonly NativeHandle selScheduleSegment_StartingFrame_FrameCount_AtTime_CompletionHandler_XHandle = Selector.GetHandle ("scheduleSegment:startingFrame:frameCount:atTime:completionHandler:");
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
		const string selSetVolume_X = "setVolume:";
		static readonly NativeHandle selSetVolume_XHandle = Selector.GetHandle ("setVolume:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceModeX = "sourceMode";
		static readonly NativeHandle selSourceModeXHandle = Selector.GetHandle ("sourceMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopX = "stop";
		static readonly NativeHandle selStopXHandle = Selector.GetHandle ("stop");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVolumeX = "volume";
		static readonly NativeHandle selVolumeXHandle = Selector.GetHandle ("volume");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVAudioPlayerNode");
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
		protected AVAudioPlayerNode (NSObjectFlag t) : base (t)
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
		protected internal AVAudioPlayerNode (NativeHandle handle) : base (handle)
		{
		}

		[Export ("init")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVAudioPlayerNode ()
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
		/// <param name="playerTime">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("nodeTimeForPlayerTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAudioTime? GetNodeTimeFromPlayerTime (AVAudioTime playerTime)
		{
			var playerTime__handle__ = playerTime!.GetNonNullHandle (nameof (playerTime));
			AVAudioTime? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AVAudioTime> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selNodeTimeForPlayerTime_XHandle, playerTime__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<AVAudioTime> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selNodeTimeForPlayerTime_XHandle, playerTime__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (playerTime);
			return ret!;
		}
		/// <param name="nodeTime">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("playerTimeForNodeTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAudioTime? GetPlayerTimeFromNodeTime (AVAudioTime nodeTime)
		{
			var nodeTime__handle__ = nodeTime!.GetNonNullHandle (nameof (nodeTime));
			AVAudioTime? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AVAudioTime> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPlayerTimeForNodeTime_XHandle, nodeTime__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<AVAudioTime> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPlayerTimeForNodeTime_XHandle, nodeTime__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (nodeTime);
			return ret!;
		}
		[Export ("pause")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Pause ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPauseXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selPauseXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("play")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Play ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPlayXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selPlayXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="when"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("playAtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PlayAtTime (AVAudioTime? when)
		{
			var when__handle__ = when.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPlayAtTime_XHandle, when__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPlayAtTime_XHandle, when__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (when);
		}
		/// <param name="frameCount">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("prepareWithFrameCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareWithFrameCount (uint frameCount)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selPrepareWithFrameCount_XHandle, frameCount);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (&__objc_super__, selPrepareWithFrameCount_XHandle, frameCount);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="buffer">To be added.</param><param name="completionHandler"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Schedules playback from <paramref name="buffer" />.</summary><remarks>To be added.</remarks>
		[Export ("scheduleBuffer:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ScheduleBuffer (AVAudioPcmBuffer buffer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selScheduleBuffer_CompletionHandler_XHandle, buffer__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selScheduleBuffer_CompletionHandler_XHandle, buffer__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (buffer);
		}
		/// <param name="buffer">The buffer to play.</param>
		/// <summary>To be added.</summary>
		/// <returns>A task that represents the asynchronous ScheduleBuffer operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task ScheduleBufferAsync (AVAudioPcmBuffer buffer)
		{
			var tcs = new TaskCompletionSource<bool> ();
			ScheduleBuffer(buffer, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <param name="buffer">To be added.</param><param name="when"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="options">To be added.</param><param name="completionHandler"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Schedules playback from <paramref name="buffer" />.</summary><remarks>To be added.</remarks>
		[Export ("scheduleBuffer:atTime:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ScheduleBuffer (AVAudioPcmBuffer buffer, AVAudioTime? when, AVAudioPlayerNodeBufferOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			var when__handle__ = when.GetHandle ();
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle (this.Handle, selScheduleBuffer_AtTime_Options_CompletionHandler_XHandle, buffer__handle__, when__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selScheduleBuffer_AtTime_Options_CompletionHandler_XHandle, buffer__handle__, when__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (buffer);
			GC.KeepAlive (when);
		}
		/// <param name="buffer">The buffer to play.</param>
		/// <param name="when">The time at which to play the buffer. May be <see langword="null" />.</param>
		/// <param name="options">Playback options, such as priority or whether to loop the playback.</param>
		/// <summary>Asynchronously schedules playback from <paramref name="buffer" />, returning a task that indicates success or failure.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task ScheduleBufferAsync (AVAudioPcmBuffer buffer, AVAudioTime? when, AVAudioPlayerNodeBufferOptions options)
		{
			var tcs = new TaskCompletionSource<bool> ();
			ScheduleBuffer(buffer, when, options, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <param name="buffer">To be added.</param><param name="callbackType">To be added.</param><param name="completionHandler"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("scheduleBuffer:completionCallbackType:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ScheduleBuffer (AVAudioPcmBuffer buffer, AVAudioPlayerNodeCompletionCallbackType callbackType, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V5))]global::System.Action<AVAudioPlayerNodeCompletionCallbackType>? completionHandler)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			using var block_completionHandler = Trampolines.SDActionArity1V5.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (this.Handle, selScheduleBuffer_CompletionCallbackType_CompletionHandler_XHandle, buffer__handle__, (IntPtr) (long) callbackType, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_NativeHandle (&__objc_super__, selScheduleBuffer_CompletionCallbackType_CompletionHandler_XHandle, buffer__handle__, (IntPtr) (long) callbackType, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (buffer);
		}
		/// <param name="buffer">The buffer to play.</param>
		/// <param name="callbackType">When to call the callback in the playback life cycle.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<AVAudioPlayerNodeCompletionCallbackType> ScheduleBufferAsync (AVAudioPcmBuffer buffer, AVAudioPlayerNodeCompletionCallbackType callbackType)
		{
			var tcs = new TaskCompletionSource<AVAudioPlayerNodeCompletionCallbackType> ();
			ScheduleBuffer(buffer, callbackType, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		/// <param name="buffer">The buffer to play.</param><param name="when">The time at which to play the buffer. May be <see langword="null" />.<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="options">Playback options, such as priority or whether to loop the playback.</param><param name="callbackType">When to call the callback in the playback life cycle.</param><param name="completionHandler">The handler to call during the playback life cycle. May be <see langword="null" />.<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("scheduleBuffer:atTime:options:completionCallbackType:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ScheduleBuffer (AVAudioPcmBuffer buffer, AVAudioTime? when, AVAudioPlayerNodeBufferOptions options, AVAudioPlayerNodeCompletionCallbackType callbackType, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V5))]global::System.Action<AVAudioPlayerNodeCompletionCallbackType>? completionHandler)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			var when__handle__ = when.GetHandle ();
			using var block_completionHandler = Trampolines.SDActionArity1V5.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_IntPtr_NativeHandle (this.Handle, selScheduleBuffer_AtTime_Options_CompletionCallbackType_CompletionHandler_XHandle, buffer__handle__, when__handle__, (UIntPtr) (ulong) options, (IntPtr) (long) callbackType, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_IntPtr_NativeHandle (&__objc_super__, selScheduleBuffer_AtTime_Options_CompletionCallbackType_CompletionHandler_XHandle, buffer__handle__, when__handle__, (UIntPtr) (ulong) options, (IntPtr) (long) callbackType, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (buffer);
			GC.KeepAlive (when);
		}
		/// <param name="buffer">The buffer to play.</param>
		/// <param name="when">The time at which to play the buffer. May be <see langword="null" />.</param>
		/// <param name="options">Playback options, such as priority or whether to loop the playback.</param>
		/// <param name="callbackType">When to call the callback in the playback life cycle.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<AVAudioPlayerNodeCompletionCallbackType> ScheduleBufferAsync (AVAudioPcmBuffer buffer, AVAudioTime? when, AVAudioPlayerNodeBufferOptions options, AVAudioPlayerNodeCompletionCallbackType callbackType)
		{
			var tcs = new TaskCompletionSource<AVAudioPlayerNodeCompletionCallbackType> ();
			ScheduleBuffer(buffer, when, options, callbackType, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		/// <param name="file">To be added.</param><param name="when"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="completionHandler"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Schedules the playing of the specified audio <paramref name="file" />.</summary><remarks>To be added.</remarks>
		[Export ("scheduleFile:atTime:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ScheduleFile (AVAudioFile file, AVAudioTime? when, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			var file__handle__ = file!.GetNonNullHandle (nameof (file));
			var when__handle__ = when.GetHandle ();
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selScheduleFile_AtTime_CompletionHandler_XHandle, file__handle__, when__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selScheduleFile_AtTime_CompletionHandler_XHandle, file__handle__, when__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (file);
			GC.KeepAlive (when);
		}
		/// <param name="file">To be added.</param>
		/// <param name="when">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>A task that represents the asynchronous ScheduleFile operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task ScheduleFileAsync (AVAudioFile file, AVAudioTime? when)
		{
			var tcs = new TaskCompletionSource<bool> ();
			ScheduleFile(file, when, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <param name="file">To be added.</param><param name="when"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="callbackType">To be added.</param><param name="completionHandler"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("scheduleFile:atTime:completionCallbackType:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ScheduleFile (AVAudioFile file, AVAudioTime? when, AVAudioPlayerNodeCompletionCallbackType callbackType, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V5))]global::System.Action<AVAudioPlayerNodeCompletionCallbackType>? completionHandler)
		{
			var file__handle__ = file!.GetNonNullHandle (nameof (file));
			var when__handle__ = when.GetHandle ();
			using var block_completionHandler = Trampolines.SDActionArity1V5.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (this.Handle, selScheduleFile_AtTime_CompletionCallbackType_CompletionHandler_XHandle, file__handle__, when__handle__, (IntPtr) (long) callbackType, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr_NativeHandle (&__objc_super__, selScheduleFile_AtTime_CompletionCallbackType_CompletionHandler_XHandle, file__handle__, when__handle__, (IntPtr) (long) callbackType, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (file);
			GC.KeepAlive (when);
		}
		/// <param name="file">To be added.</param>
		/// <param name="when">To be added.</param>
		/// <param name="callbackType">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<AVAudioPlayerNodeCompletionCallbackType> ScheduleFileAsync (AVAudioFile file, AVAudioTime? when, AVAudioPlayerNodeCompletionCallbackType callbackType)
		{
			var tcs = new TaskCompletionSource<AVAudioPlayerNodeCompletionCallbackType> ();
			ScheduleFile(file, when, callbackType, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		/// <param name="file">To be added.</param><param name="startFrame">To be added.</param><param name="numberFrames">To be added.</param><param name="when"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="completionHandler"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Schedules the playing of a portion of the audio <paramref name="file" />.</summary><remarks>To be added.</remarks>
		[Export ("scheduleSegment:startingFrame:frameCount:atTime:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ScheduleSegment (AVAudioFile file, long startFrame, uint numberFrames, AVAudioTime? when, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			var file__handle__ = file!.GetNonNullHandle (nameof (file));
			var when__handle__ = when.GetHandle ();
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Int64_UInt32_NativeHandle_NativeHandle (this.Handle, selScheduleSegment_StartingFrame_FrameCount_AtTime_CompletionHandler_XHandle, file__handle__, startFrame, numberFrames, when__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_Int64_UInt32_NativeHandle_NativeHandle (&__objc_super__, selScheduleSegment_StartingFrame_FrameCount_AtTime_CompletionHandler_XHandle, file__handle__, startFrame, numberFrames, when__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (file);
			GC.KeepAlive (when);
		}
		/// <param name="file">To be added.</param>
		/// <param name="startFrame">To be added.</param>
		/// <param name="numberFrames">To be added.</param>
		/// <param name="when">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>A task that represents the asynchronous ScheduleSegment operation</returns>
		/// <remarks>
		///           <para copied="true">The ScheduleSegmentAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task ScheduleSegmentAsync (AVAudioFile file, long startFrame, uint numberFrames, AVAudioTime? when)
		{
			var tcs = new TaskCompletionSource<bool> ();
			ScheduleSegment(file, startFrame, numberFrames, when, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <param name="file">To be added.</param><param name="startFrame">To be added.</param><param name="numberFrames">To be added.</param><param name="when"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="callbackType">To be added.</param><param name="completionHandler"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("scheduleSegment:startingFrame:frameCount:atTime:completionCallbackType:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ScheduleSegment (AVAudioFile file, long startFrame, uint numberFrames, AVAudioTime? when, AVAudioPlayerNodeCompletionCallbackType callbackType, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V5))]global::System.Action<AVAudioPlayerNodeCompletionCallbackType>? completionHandler)
		{
			var file__handle__ = file!.GetNonNullHandle (nameof (file));
			var when__handle__ = when.GetHandle ();
			using var block_completionHandler = Trampolines.SDActionArity1V5.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Int64_UInt32_NativeHandle_IntPtr_NativeHandle (this.Handle, selScheduleSegment_StartingFrame_FrameCount_AtTime_CompletionCallbackType_CompletionHandler_XHandle, file__handle__, startFrame, numberFrames, when__handle__, (IntPtr) (long) callbackType, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_Int64_UInt32_NativeHandle_IntPtr_NativeHandle (&__objc_super__, selScheduleSegment_StartingFrame_FrameCount_AtTime_CompletionCallbackType_CompletionHandler_XHandle, file__handle__, startFrame, numberFrames, when__handle__, (IntPtr) (long) callbackType, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (file);
			GC.KeepAlive (when);
		}
		/// <param name="file">To be added.</param>
		/// <param name="startFrame">To be added.</param>
		/// <param name="numberFrames">To be added.</param>
		/// <param name="when">To be added.</param>
		/// <param name="callbackType">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<AVAudioPlayerNodeCompletionCallbackType> ScheduleSegmentAsync (AVAudioFile file, long startFrame, uint numberFrames, AVAudioTime? when, AVAudioPlayerNodeCompletionCallbackType callbackType)
		{
			var tcs = new TaskCompletionSource<AVAudioPlayerNodeCompletionCallbackType> ();
			ScheduleSegment(file, startFrame, numberFrames, when, callbackType, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		/// <summary>Stops playback and clears all scheduled events.</summary><remarks>To be added.</remarks>
		[Export ("stop")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Stop ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopXHandle);
					GC.KeepAlive (this);
				}
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
		/// <summary>Gets whether the player is currently playing.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Playing {
			[Export ("isPlaying")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPlayingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsPlayingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
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
	} /* class AVAudioPlayerNode */
}
