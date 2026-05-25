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
	/// <summary>Abstract class whose subtypes represent music or remote instruments.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/documentation/avfaudio/avaudiounitmidiinstrument">Apple documentation for <c>AVAudioUnitMIDIInstrument</c></related>
	[Register("AVAudioUnitMIDIInstrument", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVAudioUnitMidiInstrument : AVAudioUnit, IAVAudio3DMixing, IAVAudioMixing, IAVAudioStereoMixing {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationForMixer_Bus_X = "destinationForMixer:bus:";
		static readonly NativeHandle selDestinationForMixer_Bus_XHandle = Selector.GetHandle ("destinationForMixer:bus:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithAudioComponentDescription_X = "initWithAudioComponentDescription:";
		static readonly NativeHandle selInitWithAudioComponentDescription_XHandle = Selector.GetHandle ("initWithAudioComponentDescription:");
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
		const string selSendController_WithValue_OnChannel_X = "sendController:withValue:onChannel:";
		static readonly NativeHandle selSendController_WithValue_OnChannel_XHandle = Selector.GetHandle ("sendController:withValue:onChannel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendMIDIEvent_Data1_X = "sendMIDIEvent:data1:";
		static readonly NativeHandle selSendMIDIEvent_Data1_XHandle = Selector.GetHandle ("sendMIDIEvent:data1:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendMIDIEvent_Data1_Data2_X = "sendMIDIEvent:data1:data2:";
		static readonly NativeHandle selSendMIDIEvent_Data1_Data2_XHandle = Selector.GetHandle ("sendMIDIEvent:data1:data2:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendMIDISysExEvent_X = "sendMIDISysExEvent:";
		static readonly NativeHandle selSendMIDISysExEvent_XHandle = Selector.GetHandle ("sendMIDISysExEvent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendPitchBend_OnChannel_X = "sendPitchBend:onChannel:";
		static readonly NativeHandle selSendPitchBend_OnChannel_XHandle = Selector.GetHandle ("sendPitchBend:onChannel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendPressure_OnChannel_X = "sendPressure:onChannel:";
		static readonly NativeHandle selSendPressure_OnChannel_XHandle = Selector.GetHandle ("sendPressure:onChannel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendPressureForKey_WithValue_OnChannel_X = "sendPressureForKey:withValue:onChannel:";
		static readonly NativeHandle selSendPressureForKey_WithValue_OnChannel_XHandle = Selector.GetHandle ("sendPressureForKey:withValue:onChannel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendProgramChange_BankMSB_BankLSB_OnChannel_X = "sendProgramChange:bankMSB:bankLSB:onChannel:";
		static readonly NativeHandle selSendProgramChange_BankMSB_BankLSB_OnChannel_XHandle = Selector.GetHandle ("sendProgramChange:bankMSB:bankLSB:onChannel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendProgramChange_OnChannel_X = "sendProgramChange:onChannel:";
		static readonly NativeHandle selSendProgramChange_OnChannel_XHandle = Selector.GetHandle ("sendProgramChange:onChannel:");
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
		const string selStartNote_WithVelocity_OnChannel_X = "startNote:withVelocity:onChannel:";
		static readonly NativeHandle selStartNote_WithVelocity_OnChannel_XHandle = Selector.GetHandle ("startNote:withVelocity:onChannel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopNote_OnChannel_X = "stopNote:onChannel:";
		static readonly NativeHandle selStopNote_OnChannel_XHandle = Selector.GetHandle ("stopNote:onChannel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVolumeX = "volume";
		static readonly NativeHandle selVolumeXHandle = Selector.GetHandle ("volume");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVAudioUnitMIDIInstrument");
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
		protected AVAudioUnitMidiInstrument (NSObjectFlag t) : base (t)
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
		protected internal AVAudioUnitMidiInstrument (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="audioComponentDescription">To be added.</param><summary>Creates a new <see cref="T:AVFoundation.AVAudioUnitMidiInstrument" /> from the specified description.</summary><remarks>To be added.</remarks>
		[Export ("initWithAudioComponentDescription:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVAudioUnitMidiInstrument (global::AudioUnit.AudioComponentDescription audioComponentDescription)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_AudioComponentDescription (this.Handle, selInitWithAudioComponentDescription_XHandle, audioComponentDescription), "initWithAudioComponentDescription:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_AudioComponentDescription (&__objc_super__, selInitWithAudioComponentDescription_XHandle, audioComponentDescription), "initWithAudioComponentDescription:");
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
		/// <param name="controller">To be added.</param><param name="value">To be added.</param><param name="channel">To be added.</param><summary>Sends a MIDI controller event..</summary><remarks>To be added.</remarks>
		[Export ("sendController:withValue:onChannel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendController (byte controller, byte value, byte channel)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte_byte (this.Handle, selSendController_WithValue_OnChannel_XHandle, controller, value, channel);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_byte_byte_byte (&__objc_super__, selSendController_WithValue_OnChannel_XHandle, controller, value, channel);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="midiStatus">To be added.</param><param name="data1">To be added.</param><param name="data2">To be added.</param><summary>Sends a two-byte MIDI event.</summary><remarks>To be added.</remarks>
		[Export ("sendMIDIEvent:data1:data2:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendMidiEvent (byte midiStatus, byte data1, byte data2)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte_byte (this.Handle, selSendMIDIEvent_Data1_Data2_XHandle, midiStatus, data1, data2);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_byte_byte_byte (&__objc_super__, selSendMIDIEvent_Data1_Data2_XHandle, midiStatus, data1, data2);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="midiStatus">To be added.</param><param name="data1">To be added.</param><summary>Sends a one-byte MIDI event.</summary><remarks>To be added.</remarks>
		[Export ("sendMIDIEvent:data1:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendMidiEvent (byte midiStatus, byte data1)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte (this.Handle, selSendMIDIEvent_Data1_XHandle, midiStatus, data1);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_byte_byte (&__objc_super__, selSendMIDIEvent_Data1_XHandle, midiStatus, data1);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="midiData">To be added.</param><summary>Sends a MIDI system-exclusive event.</summary><remarks>To be added.</remarks>
		[Export ("sendMIDISysExEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendMidiSysExEvent (NSData midiData)
		{
			var midiData__handle__ = midiData!.GetNonNullHandle (nameof (midiData));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSendMIDISysExEvent_XHandle, midiData__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSendMIDISysExEvent_XHandle, midiData__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (midiData);
		}
		/// <param name="pitchbend">To be added.</param><param name="channel">To be added.</param><summary>Sends a MIDI pitch-bend event.</summary><remarks>To be added.</remarks>
		[Export ("sendPitchBend:onChannel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendPitchBend (ushort pitchbend, byte channel)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UInt16_byte (this.Handle, selSendPitchBend_OnChannel_XHandle, pitchbend, channel);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt16_byte (&__objc_super__, selSendPitchBend_OnChannel_XHandle, pitchbend, channel);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="pressure">To be added.</param><param name="channel">To be added.</param><summary>Sends a MIDI pressure event.</summary><remarks>To be added.</remarks>
		[Export ("sendPressure:onChannel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendPressure (byte pressure, byte channel)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte (this.Handle, selSendPressure_OnChannel_XHandle, pressure, channel);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_byte_byte (&__objc_super__, selSendPressure_OnChannel_XHandle, pressure, channel);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="key">To be added.</param><param name="value">To be added.</param><param name="channel">To be added.</param><summary>Sends a MIDI polyphonic key pressure event for the specified <paramref name="key" />.</summary><remarks>To be added.</remarks>
		[Export ("sendPressureForKey:withValue:onChannel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendPressureForKey (byte key, byte value, byte channel)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte_byte (this.Handle, selSendPressureForKey_WithValue_OnChannel_XHandle, key, value, channel);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_byte_byte_byte (&__objc_super__, selSendPressureForKey_WithValue_OnChannel_XHandle, key, value, channel);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="program">To be added.</param><param name="channel">To be added.</param><summary>Sends MIDI program change and bank select events.</summary><remarks>To be added.</remarks>
		[Export ("sendProgramChange:onChannel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendProgramChange (byte program, byte channel)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte (this.Handle, selSendProgramChange_OnChannel_XHandle, program, channel);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_byte_byte (&__objc_super__, selSendProgramChange_OnChannel_XHandle, program, channel);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="program">To be added.</param><param name="bankMSB">To be added.</param><param name="bankLSB">To be added.</param><param name="channel">To be added.</param><summary>Sends MIDI program change and bank select events.</summary><remarks>To be added.</remarks>
		[Export ("sendProgramChange:bankMSB:bankLSB:onChannel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendProgramChange (byte program, byte bankMSB, byte bankLSB, byte channel)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte_byte_byte (this.Handle, selSendProgramChange_BankMSB_BankLSB_OnChannel_XHandle, program, bankMSB, bankLSB, channel);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_byte_byte_byte_byte (&__objc_super__, selSendProgramChange_BankMSB_BankLSB_OnChannel_XHandle, program, bankMSB, bankLSB, channel);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="note">To be added.</param><param name="velocity">To be added.</param><param name="channel">To be added.</param><summary>Sends a start note event.</summary><remarks>To be added.</remarks>
		[Export ("startNote:withVelocity:onChannel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartNote (byte note, byte velocity, byte channel)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte_byte (this.Handle, selStartNote_WithVelocity_OnChannel_XHandle, note, velocity, channel);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_byte_byte_byte (&__objc_super__, selStartNote_WithVelocity_OnChannel_XHandle, note, velocity, channel);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="note">To be added.</param><param name="channel">To be added.</param><summary>Sends a stop note event.</summary><remarks>To be added.</remarks>
		[Export ("stopNote:onChannel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopNote (byte note, byte channel)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte (this.Handle, selStopNote_OnChannel_XHandle, note, channel);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_byte_byte (&__objc_super__, selStopNote_OnChannel_XHandle, note, channel);
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
	} /* class AVAudioUnitMidiInstrument */
}
