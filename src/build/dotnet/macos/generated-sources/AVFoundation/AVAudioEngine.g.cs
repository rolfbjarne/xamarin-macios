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
	/// <summary>A group of connected <see cref="T:AVFoundation.AVAudioNode" /> objects, each of which performs a processing or IO task.</summary><related type="externalDocumentation" href="https://developer.apple.com/documentation/avfaudio/avaudioengine">Apple documentation for <c>AVAudioEngine</c></related>
	[Register("AVAudioEngine", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVAudioEngine : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttachNode_X = "attachNode:";
		static readonly NativeHandle selAttachNode_XHandle = Selector.GetHandle ("attachNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttachedNodesX = "attachedNodes";
		static readonly NativeHandle selAttachedNodesXHandle = Selector.GetHandle ("attachedNodes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConnect_To_Format_X = "connect:to:format:";
		static readonly NativeHandle selConnect_To_Format_XHandle = Selector.GetHandle ("connect:to:format:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConnect_To_FromBus_ToBus_Format_X = "connect:to:fromBus:toBus:format:";
		static readonly NativeHandle selConnect_To_FromBus_ToBus_Format_XHandle = Selector.GetHandle ("connect:to:fromBus:toBus:format:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConnect_ToConnectionPoints_FromBus_Format_X = "connect:toConnectionPoints:fromBus:format:";
		static readonly NativeHandle selConnect_ToConnectionPoints_FromBus_Format_XHandle = Selector.GetHandle ("connect:toConnectionPoints:fromBus:format:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConnectMIDI_To_Format_Block_X = "connectMIDI:to:format:block:";
		static readonly NativeHandle selConnectMIDI_To_Format_Block_XHandle = Selector.GetHandle ("connectMIDI:to:format:block:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConnectMIDI_ToNodes_Format_Block_X = "connectMIDI:toNodes:format:block:";
		static readonly NativeHandle selConnectMIDI_ToNodes_Format_Block_XHandle = Selector.GetHandle ("connectMIDI:toNodes:format:block:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDetachNode_X = "detachNode:";
		static readonly NativeHandle selDetachNode_XHandle = Selector.GetHandle ("detachNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisableManualRenderingModeX = "disableManualRenderingMode";
		static readonly NativeHandle selDisableManualRenderingModeXHandle = Selector.GetHandle ("disableManualRenderingMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisconnectMIDI_From_X = "disconnectMIDI:from:";
		static readonly NativeHandle selDisconnectMIDI_From_XHandle = Selector.GetHandle ("disconnectMIDI:from:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisconnectMIDI_FromNodes_X = "disconnectMIDI:fromNodes:";
		static readonly NativeHandle selDisconnectMIDI_FromNodes_XHandle = Selector.GetHandle ("disconnectMIDI:fromNodes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisconnectMIDIInput_X = "disconnectMIDIInput:";
		static readonly NativeHandle selDisconnectMIDIInput_XHandle = Selector.GetHandle ("disconnectMIDIInput:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisconnectMIDIOutput_X = "disconnectMIDIOutput:";
		static readonly NativeHandle selDisconnectMIDIOutput_XHandle = Selector.GetHandle ("disconnectMIDIOutput:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisconnectNodeInput_X = "disconnectNodeInput:";
		static readonly NativeHandle selDisconnectNodeInput_XHandle = Selector.GetHandle ("disconnectNodeInput:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisconnectNodeInput_Bus_X = "disconnectNodeInput:bus:";
		static readonly NativeHandle selDisconnectNodeInput_Bus_XHandle = Selector.GetHandle ("disconnectNodeInput:bus:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisconnectNodeOutput_X = "disconnectNodeOutput:";
		static readonly NativeHandle selDisconnectNodeOutput_XHandle = Selector.GetHandle ("disconnectNodeOutput:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisconnectNodeOutput_Bus_X = "disconnectNodeOutput:bus:";
		static readonly NativeHandle selDisconnectNodeOutput_Bus_XHandle = Selector.GetHandle ("disconnectNodeOutput:bus:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnableManualRenderingMode_Format_MaximumFrameCount_Error_X = "enableManualRenderingMode:format:maximumFrameCount:error:";
		static readonly NativeHandle selEnableManualRenderingMode_Format_MaximumFrameCount_Error_XHandle = Selector.GetHandle ("enableManualRenderingMode:format:maximumFrameCount:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInputConnectionPointForNode_InputBus_X = "inputConnectionPointForNode:inputBus:";
		static readonly NativeHandle selInputConnectionPointForNode_InputBus_XHandle = Selector.GetHandle ("inputConnectionPointForNode:inputBus:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInputNodeX = "inputNode";
		static readonly NativeHandle selInputNodeXHandle = Selector.GetHandle ("inputNode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutoShutdownEnabledX = "isAutoShutdownEnabled";
		static readonly NativeHandle selIsAutoShutdownEnabledXHandle = Selector.GetHandle ("isAutoShutdownEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsInManualRenderingModeX = "isInManualRenderingMode";
		static readonly NativeHandle selIsInManualRenderingModeXHandle = Selector.GetHandle ("isInManualRenderingMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsRunningX = "isRunning";
		static readonly NativeHandle selIsRunningXHandle = Selector.GetHandle ("isRunning");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMainMixerNodeX = "mainMixerNode";
		static readonly NativeHandle selMainMixerNodeXHandle = Selector.GetHandle ("mainMixerNode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selManualRenderingBlockX = "manualRenderingBlock";
		static readonly NativeHandle selManualRenderingBlockXHandle = Selector.GetHandle ("manualRenderingBlock");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selManualRenderingFormatX = "manualRenderingFormat";
		static readonly NativeHandle selManualRenderingFormatXHandle = Selector.GetHandle ("manualRenderingFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selManualRenderingMaximumFrameCountX = "manualRenderingMaximumFrameCount";
		static readonly NativeHandle selManualRenderingMaximumFrameCountXHandle = Selector.GetHandle ("manualRenderingMaximumFrameCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selManualRenderingModeX = "manualRenderingMode";
		static readonly NativeHandle selManualRenderingModeXHandle = Selector.GetHandle ("manualRenderingMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selManualRenderingSampleTimeX = "manualRenderingSampleTime";
		static readonly NativeHandle selManualRenderingSampleTimeXHandle = Selector.GetHandle ("manualRenderingSampleTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMusicSequenceX = "musicSequence";
		static readonly NativeHandle selMusicSequenceXHandle = Selector.GetHandle ("musicSequence");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputConnectionPointsForNode_OutputBus_X = "outputConnectionPointsForNode:outputBus:";
		static readonly NativeHandle selOutputConnectionPointsForNode_OutputBus_XHandle = Selector.GetHandle ("outputConnectionPointsForNode:outputBus:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputNodeX = "outputNode";
		static readonly NativeHandle selOutputNodeXHandle = Selector.GetHandle ("outputNode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPauseX = "pause";
		static readonly NativeHandle selPauseXHandle = Selector.GetHandle ("pause");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareX = "prepare";
		static readonly NativeHandle selPrepareXHandle = Selector.GetHandle ("prepare");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderOffline_ToBuffer_Error_X = "renderOffline:toBuffer:error:";
		static readonly NativeHandle selRenderOffline_ToBuffer_Error_XHandle = Selector.GetHandle ("renderOffline:toBuffer:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResetX = "reset";
		static readonly NativeHandle selResetXHandle = Selector.GetHandle ("reset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutoShutdownEnabled_X = "setAutoShutdownEnabled:";
		static readonly NativeHandle selSetAutoShutdownEnabled_XHandle = Selector.GetHandle ("setAutoShutdownEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMusicSequence_X = "setMusicSequence:";
		static readonly NativeHandle selSetMusicSequence_XHandle = Selector.GetHandle ("setMusicSequence:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartAndReturnError_X = "startAndReturnError:";
		static readonly NativeHandle selStartAndReturnError_XHandle = Selector.GetHandle ("startAndReturnError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopX = "stop";
		static readonly NativeHandle selStopXHandle = Selector.GetHandle ("stop");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVAudioEngine");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="AVAudioEngine" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVAudioEngine () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected AVAudioEngine (NSObjectFlag t) : base (t)
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
		protected internal AVAudioEngine (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="node">To be added.</param><summary>Attaches <paramref name="node" /> to the audio engine.</summary><remarks>To be added.</remarks>
		[Export ("attachNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AttachNode (AVAudioNode node)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAttachNode_XHandle, node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAttachNode_XHandle, node__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
		}
		/// <param name="sourceNode">To be added.</param><param name="targetNode">To be added.</param><param name="sourceBus">To be added.</param><param name="targetBus">To be added.</param><param name="format"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("connect:to:fromBus:toBus:format:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Connect (AVAudioNode sourceNode, AVAudioNode targetNode, nuint sourceBus, nuint targetBus, AVAudioFormat? format)
		{
			var sourceNode__handle__ = sourceNode!.GetNonNullHandle (nameof (sourceNode));
			var targetNode__handle__ = targetNode!.GetNonNullHandle (nameof (targetNode));
			var format__handle__ = format.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr_NativeHandle (this.Handle, selConnect_To_FromBus_ToBus_Format_XHandle, sourceNode__handle__, targetNode__handle__, sourceBus, targetBus, format__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_UIntPtr_NativeHandle (&__objc_super__, selConnect_To_FromBus_ToBus_Format_XHandle, sourceNode__handle__, targetNode__handle__, sourceBus, targetBus, format__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceNode);
			GC.KeepAlive (targetNode);
			GC.KeepAlive (format);
		}
		/// <param name="sourceNode">To be added.</param><param name="targetNode">To be added.</param><param name="format"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Connects <paramref name="sourceNode" /> to <paramref name="targetNode" /> with the specified <paramref name="format" />.</summary><remarks>To be added.</remarks>
		[Export ("connect:to:format:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Connect (AVAudioNode sourceNode, AVAudioNode targetNode, AVAudioFormat? format)
		{
			var sourceNode__handle__ = sourceNode!.GetNonNullHandle (nameof (sourceNode));
			var targetNode__handle__ = targetNode!.GetNonNullHandle (nameof (targetNode));
			var format__handle__ = format.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selConnect_To_Format_XHandle, sourceNode__handle__, targetNode__handle__, format__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selConnect_To_Format_XHandle, sourceNode__handle__, targetNode__handle__, format__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceNode);
			GC.KeepAlive (targetNode);
			GC.KeepAlive (format);
		}
		/// <param name="sourceNode">To be added.</param><param name="destNodes">To be added.</param><param name="sourceBus">To be added.</param><param name="format"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("connect:toConnectionPoints:fromBus:format:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Connect (AVAudioNode sourceNode, AVAudioConnectionPoint[] destNodes, nuint sourceBus, AVAudioFormat? format)
		{
			var sourceNode__handle__ = sourceNode!.GetNonNullHandle (nameof (sourceNode));
			if (destNodes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (destNodes));
			var format__handle__ = format.GetHandle ();
			using var nsa_destNodes = NSArray.FromNSObjects (destNodes);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle (this.Handle, selConnect_ToConnectionPoints_FromBus_Format_XHandle, sourceNode__handle__, nsa_destNodes.Handle, sourceBus, format__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selConnect_ToConnectionPoints_FromBus_Format_XHandle, sourceNode__handle__, nsa_destNodes.Handle, sourceBus, format__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceNode);
			GC.KeepAlive (format);
		}
		/// <param name="sourceNode">To be added.</param><param name="destinationNode">To be added.</param><param name="format">To be added.</param><param name="tapHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("connectMIDI:to:format:block:")]
		[ObsoletedOSPlatform ("macos13.0")]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("maccatalyst13.0")]
		[ObsoletedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ConnectMidi (AVAudioNode sourceNode, AVAudioNode destinationNode, AVAudioFormat? format, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAUMidiOutputEventBlock))]global::AudioUnit.AUMidiOutputEventBlock? tapHandler)
		{
			var sourceNode__handle__ = sourceNode!.GetNonNullHandle (nameof (sourceNode));
			var destinationNode__handle__ = destinationNode!.GetNonNullHandle (nameof (destinationNode));
			var format__handle__ = format.GetHandle ();
			using var block_tapHandler = Trampolines.SDAUMidiOutputEventBlock.CreateNullableBlock (tapHandler);
			BlockLiteral *block_ptr_tapHandler = null;
			if (tapHandler is not null)
				block_ptr_tapHandler = &block_tapHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selConnectMIDI_To_Format_Block_XHandle, sourceNode__handle__, destinationNode__handle__, format__handle__, (IntPtr) block_ptr_tapHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selConnectMIDI_To_Format_Block_XHandle, sourceNode__handle__, destinationNode__handle__, format__handle__, (IntPtr) block_ptr_tapHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceNode);
			GC.KeepAlive (destinationNode);
			GC.KeepAlive (format);
		}
		/// <param name="sourceNode">To be added.</param><param name="destinationNodes">To be added.</param><param name="format">To be added.</param><param name="tapHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("connectMIDI:toNodes:format:block:")]
		[ObsoletedOSPlatform ("macos13.0")]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("maccatalyst9.0")]
		[ObsoletedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ConnectMidi (AVAudioNode sourceNode, AVAudioNode[] destinationNodes, AVAudioFormat? format, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAUMidiOutputEventBlock))]global::AudioUnit.AUMidiOutputEventBlock? tapHandler)
		{
			var sourceNode__handle__ = sourceNode!.GetNonNullHandle (nameof (sourceNode));
			if (destinationNodes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (destinationNodes));
			var format__handle__ = format.GetHandle ();
			using var nsa_destinationNodes = NSArray.FromNSObjects (destinationNodes);
			using var block_tapHandler = Trampolines.SDAUMidiOutputEventBlock.CreateNullableBlock (tapHandler);
			BlockLiteral *block_ptr_tapHandler = null;
			if (tapHandler is not null)
				block_ptr_tapHandler = &block_tapHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selConnectMIDI_ToNodes_Format_Block_XHandle, sourceNode__handle__, nsa_destinationNodes.Handle, format__handle__, (IntPtr) block_ptr_tapHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selConnectMIDI_ToNodes_Format_Block_XHandle, sourceNode__handle__, nsa_destinationNodes.Handle, format__handle__, (IntPtr) block_ptr_tapHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceNode);
			GC.KeepAlive (format);
		}
		/// <param name="node">To be added.</param><summary>Detaches <paramref name="node" /> from the audio engine.</summary><remarks>To be added.</remarks>
		[Export ("detachNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DetachNode (AVAudioNode node)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDetachNode_XHandle, node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDetachNode_XHandle, node__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("disableManualRenderingMode")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisableManualRenderingMode ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDisableManualRenderingModeXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDisableManualRenderingModeXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="sourceNode">To be added.</param><param name="destinationNode">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("disconnectMIDI:from:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisconnectMidi (AVAudioNode sourceNode, AVAudioNode destinationNode)
		{
			var sourceNode__handle__ = sourceNode!.GetNonNullHandle (nameof (sourceNode));
			var destinationNode__handle__ = destinationNode!.GetNonNullHandle (nameof (destinationNode));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDisconnectMIDI_From_XHandle, sourceNode__handle__, destinationNode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDisconnectMIDI_From_XHandle, sourceNode__handle__, destinationNode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceNode);
			GC.KeepAlive (destinationNode);
		}
		/// <param name="sourceNode">To be added.</param><param name="destinationNodes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("disconnectMIDI:fromNodes:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisconnectMidi (AVAudioNode sourceNode, AVAudioNode[] destinationNodes)
		{
			var sourceNode__handle__ = sourceNode!.GetNonNullHandle (nameof (sourceNode));
			if (destinationNodes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (destinationNodes));
			using var nsa_destinationNodes = NSArray.FromNSObjects (destinationNodes);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDisconnectMIDI_FromNodes_XHandle, sourceNode__handle__, nsa_destinationNodes.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDisconnectMIDI_FromNodes_XHandle, sourceNode__handle__, nsa_destinationNodes.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceNode);
		}
		/// <param name="node">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("disconnectMIDIInput:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisconnectMidiInput (AVAudioNode node)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDisconnectMIDIInput_XHandle, node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDisconnectMIDIInput_XHandle, node__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
		}
		/// <param name="node">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("disconnectMIDIOutput:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisconnectMidiOutput (AVAudioNode node)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDisconnectMIDIOutput_XHandle, node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDisconnectMIDIOutput_XHandle, node__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
		}
		/// <param name="node">To be added.</param><param name="bus">To be added.</param><summary>Disconnects all input connections on <paramref name="bus" /> from <paramref name="node" />.</summary><remarks>To be added.</remarks>
		[Export ("disconnectNodeInput:bus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisconnectNodeInput (AVAudioNode node, nuint bus)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selDisconnectNodeInput_Bus_XHandle, node__handle__, bus);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selDisconnectNodeInput_Bus_XHandle, node__handle__, bus);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
		}
		/// <param name="node">To be added.</param><summary>Disconnects all input connections from <paramref name="node" />.</summary><remarks>To be added.</remarks>
		[Export ("disconnectNodeInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisconnectNodeInput (AVAudioNode node)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDisconnectNodeInput_XHandle, node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDisconnectNodeInput_XHandle, node__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
		}
		/// <param name="node">To be added.</param><param name="bus">To be added.</param><summary>Disconnects all output connections on <paramref name="bus" /> from <paramref name="node" />.</summary><remarks>To be added.</remarks>
		[Export ("disconnectNodeOutput:bus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisconnectNodeOutput (AVAudioNode node, nuint bus)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selDisconnectNodeOutput_Bus_XHandle, node__handle__, bus);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selDisconnectNodeOutput_Bus_XHandle, node__handle__, bus);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
		}
		/// <param name="node">To be added.</param><summary>Disconnects all output connections from <paramref name="node" /></summary><remarks>To be added.</remarks>
		[Export ("disconnectNodeOutput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisconnectNodeOutput (AVAudioNode node)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDisconnectNodeOutput_XHandle, node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDisconnectNodeOutput_XHandle, node__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
		}
		/// <param name="mode">To be added.</param><param name="pcmFormat">To be added.</param><param name="maximumFrameCount">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("enableManualRenderingMode:format:maximumFrameCount:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool EnableManualRenderingMode (AVAudioEngineManualRenderingMode mode, AVAudioFormat pcmFormat, uint maximumFrameCount, out NSError outError)
		{
			var pcmFormat__handle__ = pcmFormat!.GetNonNullHandle (nameof (pcmFormat));
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_NativeHandle_UInt32_ref_NativeHandle (this.Handle, selEnableManualRenderingMode_Format_MaximumFrameCount_Error_XHandle, (IntPtr) (long) mode, pcmFormat__handle__, maximumFrameCount, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_NativeHandle_UInt32_ref_NativeHandle (&__objc_super__, selEnableManualRenderingMode_Format_MaximumFrameCount_Error_XHandle, (IntPtr) (long) mode, pcmFormat__handle__, maximumFrameCount, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pcmFormat);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		/// <param name="node">To be added.</param><param name="bus">To be added.</param><summary>Returns the audio connection input point for <paramref name="node" /> on <paramref name="bus" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("inputConnectionPointForNode:inputBus:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAudioConnectionPoint? InputConnectionPoint (AVAudioNode node, nuint bus)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			AVAudioConnectionPoint? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AVAudioConnectionPoint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selInputConnectionPointForNode_InputBus_XHandle, node__handle__, bus), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<AVAudioConnectionPoint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selInputConnectionPointForNode_InputBus_XHandle, node__handle__, bus), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
			return ret!;
		}
		/// <param name="node">To be added.</param><param name="bus">To be added.</param><summary>Gets an array that contains the output connection points of <paramref name="node" /> on <paramref name="bus" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outputConnectionPointsForNode:outputBus:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAudioConnectionPoint[] OutputConnectionPoints (AVAudioNode node, nuint bus)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			AVAudioConnectionPoint[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<AVAudioConnectionPoint>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selOutputConnectionPointsForNode_OutputBus_XHandle, node__handle__, bus), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<AVAudioConnectionPoint>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selOutputConnectionPointsForNode_OutputBus_XHandle, node__handle__, bus), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
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
		/// <summary>Prepares the audio engine for playing.</summary><remarks>To be added.</remarks>
		[Export ("prepare")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Prepare ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPrepareXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selPrepareXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="numberOfFrames">To be added.</param><param name="buffer">To be added.</param><param name="outError"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("renderOffline:toBuffer:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual AVAudioEngineManualRenderingStatus RenderOffline (uint numberOfFrames, AVAudioPcmBuffer buffer, out NSError? outError)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			NativeHandle outErrorValue = IntPtr.Zero;
			AVAudioEngineManualRenderingStatus ret;
			if (IsDirectBinding) {
				ret = (AVAudioEngineManualRenderingStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_NativeHandle_ref_NativeHandle (this.Handle, selRenderOffline_ToBuffer_Error_XHandle, numberOfFrames, buffer__handle__, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (AVAudioEngineManualRenderingStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32_NativeHandle_ref_NativeHandle (&__objc_super__, selRenderOffline_ToBuffer_Error_XHandle, numberOfFrames, buffer__handle__, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (buffer);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[Export ("reset")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Reset ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selResetXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selResetXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="outError">To be added.</param><summary>Starts the engine an stores an error, if one occurs, in <paramref name="outError" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("startAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool StartAndReturnError (out NSError outError)
		{
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, selStartAndReturnError_XHandle, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selStartAndReturnError_XHandle, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		/// <summary>Stops the audio engine.</summary><remarks>To be added.</remarks>
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSSet<AVAudioNode> AttachedNodes {
			[Export ("attachedNodes", ArgumentSemantic.Copy)]
			get {
				NSSet<AVAudioNode>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<AVAudioNode>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttachedNodesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<AVAudioNode>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttachedNodesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool AutoShutdownEnabled {
			[Export ("isAutoShutdownEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAutoShutdownEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAutoShutdownEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutoShutdownEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutoShutdownEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutoShutdownEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool InManualRenderingMode {
			[Export ("isInManualRenderingMode")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsInManualRenderingModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsInManualRenderingModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>An input node such as a built-in microphone.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks><para>Developers who access this node must have the <c>NSMicrophoneUsageDescription</c> key to their info.plist. If this key is not in info.plist, the application will immediately exit with no exception if the developer attempts to access the <see cref="P:AVFoundation.AVAudioEngine.InputNode" />.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual AVAudioInputNode InputNode {
			[Export ("inputNode")]
			get {
				AVAudioInputNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAudioInputNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInputNodeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAudioInputNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInputNodeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the optional main mixer mode singleton.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAudioMixerNode MainMixerNode {
			[Export ("mainMixerNode")]
			get {
				AVAudioMixerNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAudioMixerNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMainMixerNodeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAudioMixerNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMainMixerNodeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public unsafe virtual AVAudioEngineManualRenderingBlock ManualRenderingBlock {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDAVAudioEngineManualRenderingBlock))]
			[Export ("manualRenderingBlock")]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selManualRenderingBlockXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selManualRenderingBlockXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDAVAudioEngineManualRenderingBlock.Create (ret)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual AVAudioFormat ManualRenderingFormat {
			[Export ("manualRenderingFormat")]
			get {
				AVAudioFormat? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAudioFormat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selManualRenderingFormatXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAudioFormat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selManualRenderingFormatXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual uint ManualRenderingMaximumFrameCount {
			[Export ("manualRenderingMaximumFrameCount")]
			get {
				uint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selManualRenderingMaximumFrameCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selManualRenderingMaximumFrameCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual AVAudioEngineManualRenderingMode ManualRenderingMode {
			[Export ("manualRenderingMode")]
			get {
				AVAudioEngineManualRenderingMode ret;
				if (IsDirectBinding) {
					ret = (AVAudioEngineManualRenderingMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selManualRenderingModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVAudioEngineManualRenderingMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selManualRenderingModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual long ManualRenderingSampleTime {
			[Export ("manualRenderingSampleTime")]
			get {
				long ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, selManualRenderingSampleTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (&__objc_super__, selManualRenderingSampleTimeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets or sets the music sequence that is attached to the audio engine.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::AudioToolbox.MusicSequence? MusicSequence {
			[Export ("musicSequence")]
			get {
				global::AudioToolbox.MusicSequence ret;
				if (IsDirectBinding) {
					ret = global::AudioToolbox.MusicSequence.Lookup (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMusicSequenceXHandle), false);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::AudioToolbox.MusicSequence.Lookup (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMusicSequenceXHandle), false);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMusicSequence:")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMusicSequence_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMusicSequence_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets the audio engine's output node singleton.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAudioOutputNode OutputNode {
			[Export ("outputNode")]
			get {
				AVAudioOutputNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAudioOutputNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutputNodeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAudioOutputNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutputNodeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the engine is running.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Running {
			[Export ("isRunning")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRunningXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsRunningXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ConfigurationChangeNotification;
		/// <summary>Notification constant for ConfigurationChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveConfigurationChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveConfigurationChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = AVAudioEngine.Notifications.ObserveConfigurationChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, AVAudioEngine.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVAudioEngine.Notifications.ObserveConfigurationChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     AVAudioEngine.ConfigurationChangeNotification, (notification) => { Console.WriteLine ("Received the notification ConfigurationChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ConfigurationChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVAudioEngine.ConfigurationChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVAudioEngineConfigurationChangeNotification",  "AVFoundation")]
		[Advice ("Use AVAudioEngine.Notifications.ObserveConfigurationChange helper method instead.")]
		public static NSString ConfigurationChangeNotification {
			get {
				if (_ConfigurationChangeNotification is null)
					_ConfigurationChangeNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioEngineConfigurationChangeNotification")!;
				return _ConfigurationChangeNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AVFoundation.AVAudioEngine" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAudioEngine.ConfigurationChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAudioEngine.ConfigurationChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVAudioEngine.Notifications.ObserveConfigurationChange ((notification) => {
			///   Console.WriteLine ("Observed ConfigurationChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveConfigurationChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ConfigurationChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAudioEngine.ConfigurationChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAudioEngine.ConfigurationChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVAudioEngine.Notifications.ObserveConfigurationChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ConfigurationChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveConfigurationChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ConfigurationChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class AVAudioEngine */
}
