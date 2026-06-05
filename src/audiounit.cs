//
// Authors:
//  Miguel de Icaza (miguel@xamarin.com)
//
// Copyright 2015 Xamarin, Inc.
//
//

using System.ComponentModel;

using AudioUnit;
using CoreFoundation;
using CoreAnimation;
using CoreGraphics;
#if IOS || MONOMAC
using CoreAudioKit;
using CoreMidi;
#endif
using AudioToolbox;
using AVFoundation;

#if MONOMAC
using AppKit;
using AUViewControllerBase = AppKit.NSViewController;
#else
using UIKit;
using MediaToolbox;
using AUViewControllerBase = UIKit.UIViewController;
#endif
#if TVOS
using MidiCIProfile = Foundation.NSObject;
using MidiCIProfileState = Foundation.NSObject;
#endif

namespace AudioUnit {
	delegate AudioUnitStatus AUInternalRenderBlock (ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint outputBusNumber, AudioBuffers outputData, AURenderEventEnumerator realtimeEventListHead, [BlockCallback][NullAllowed] AURenderPullInputBlock pullInputBlock);
	delegate AudioUnitStatus AURenderBlock (ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint outputBusNumber, AudioBuffers outputData, [BlockCallback][NullAllowed] AURenderPullInputBlock pullInputBlock);

	internal delegate AudioUnitStatus AURenderPullInputBlock (ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp,
			uint frameCount, nint inputBusNumber, AudioBuffers inputData);

	delegate void AUScheduleParameterBlock (AUEventSampleTime eventSampleTime, uint rampDurationSampleFrames, ulong parameterAddress, float value);
	[MacCatalyst (13, 1)]
	delegate int AUMidiOutputEventBlock (long eventSampleTime, byte cable, nint length, IntPtr midiBytes);
	/// <param name="param">The parameter that changed.</param>
	///     <param name="value">The new parameter value.</param>
	///     <summary>A delegate that notifies the audio unit when AParameter value changes.</summary>
	delegate void AUImplementorValueObserver (AUParameter param, float value);
	/// <param name="param">The parameter whose value to get.</param>
	///     <summary>A delegate that retrieves AParameter value.</summary>
	///     <returns>The value of the parameter that is identified by <paramref name="param" />.</returns>
	delegate float AUImplementorValueProvider (AUParameter param);

	/// <param name="address">The parameter address.</param>
	///     <param name="value">The current parameter value.</param>
	///     <summary>Observer that notifies an audio unit when AParameter value changes.</summary>
	delegate void AUParameterObserver (ulong address, float value);

	delegate void AUVoiceIOMutedSpeechActivityEventListener (AUVoiceIOSpeechActivityEvent activityEvent);

	// 	AUAudioTODO - We need testing for these bindings
	// 	delegate void AUScheduleMidiEventBlock (AUEventSampleTime eventSampleTime, byte cable, nint length, ref byte midiBytes);
	// 	delegate bool AUHostMusicalContextBlock (ref double currentTempo, ref double timeSignatureNumerator, ref nint timeSignatureDenominator, ref double currentBeatPosition, ref nint sampleOffsetToNextBeat, ref double currentMeasureDownbeatPosition);
	delegate string AUImplementorStringFromValueCallback (AUParameter param, ref float? value);

	/// <param name="node">The parameter node for which to get APossibly shortened name.</param>
	///     <param name="desiredLength">The maximum desired length of the display name.</param>
	///     <summary>A delegate that returns the display name, possibly shortened to <paramref name="desiredLength" /> characters.</summary>
	///     <returns>The display name, possibly shortened to <paramref name="desiredLength" /> characters.</returns>
	delegate string AUImplementorDisplayNameWithLengthCallback (AUParameterNode node, nint desiredLength);
	/// <param name="numberOfEvents">The number of automation events.</param>
	///     <param name="events">The delivered events.</param>
	///     <summary>Delegate that records parameter changes as automation events.</summary>
	delegate void AUParameterRecordingObserver (nint numberOfEvents, ref AURecordedParameterEvent events);
	/// <param name="actionFlags">The action flags that configure the audio unit rendering process.</param>
	///     <param name="timestamp">The unconverted, uncompressed HAL time when the input will render.</param>
	///     <param name="frameCount">The number of available audio frames.</param>
	///     <param name="inputBusNumber">The input bus index.</param>
	///     <summary>Delegate that tells an I/O host when input is available.</summary>
	delegate void AUInputHandler (ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint inputBusNumber);
	/// <param name="transportStateFlags">The state of the audio transport.</param>
	///     <param name="currentSamplePosition">The host sample position, in audio unit samples.</param>
	///     <param name="cycleStartBeatPosition">The starting beat position for the cycle. <see langword="null" /> if not cycling.</param>
	///     <param name="cycleEndBeatPosition">The ending beat position for the cycle. <see langword="null" /> if not cycling.</param>
	///     <summary>A delegate block that a host uses to provide information about its transport state.</summary>
	///     <returns>
	///       <para>
	///         <see langword="true" /> if the state was successfully retrieved. Otherwise, <see langword="false" />.</para>
	///     </returns>
	///     <remarks>
	///       <para>Developers may optionally assign an instance of this class to the <see cref="AUAudioUnit.TransportStateBlock" /> property so that they can call it at the beginning of render cycles to get the transport state at the cycle start.</para>
	///     </remarks>
	delegate bool AUHostTransportStateBlock (ref AUHostTransportStateFlags transportStateFlags, ref double currentSamplePosition, ref double cycleStartBeatPosition, ref double cycleEndBeatPosition);
	delegate void AURenderObserver (AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint outputBusNumber);
	/// <param name="param">The parameter that will be assigned to the value that is converted from <paramref name="str" />.</param>
	///     <param name="str">The string to convert.</param>
	///     <summary>Converts <paramref name="str" /> to the appropriate type and assigns it to <paramref name="param" />.</summary>
	///     <returns>The new audio unit value.</returns>
	delegate float AUImplementorValueFromStringCallback (AUParameter param, string str);
	[NoTV]
	[MacCatalyst (13, 1)]
	delegate void AUMidiCIProfileChangedCallback (byte cable, byte channel, MidiCIProfile profile, bool enabled);

	/// <summary>A subclass of <see cref="AVFoundation.AVAudioNode" /> whose subclasses process audio.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AudioUnit/Reference/AUAudioUnit_ClassReference/index.html">Apple documentation for <c>AUAudioUnit</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface AUAudioUnit {
		/// <param name="cls">The audio component type.</param>
		/// <param name="componentDescription">The component description.</param>
		/// <param name="name">The name of the audio component.</param>
		/// <param name="version">The version of the audio component.</param>
		///         <summary>Registers a component that has been implemented as a subclass of <see cref="AudioUnit" />.</summary>
		[Static]
		[Export ("registerSubclass:asComponentDescription:name:version:")] // AUAudioUnitImplementation
		void RegisterSubclass (Class cls, AudioComponentDescription componentDescription, string name, uint version);

		/// <param name="componentDescription">The audio component description.</param>
		/// <param name="options">The instantiation options.</param>
		/// <param name="outError">
		///   <para>On return, contains any error that occurred.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new <see cref="AUAudioUnit" /> with the specified values.</summary>
		
		[Export ("initWithComponentDescription:options:error:")]
		[DesignatedInitializer]
		NativeHandle Constructor (AudioComponentDescription componentDescription, AudioComponentInstantiationOptions options, [NullAllowed] out NSError outError);

		/// <param name="componentDescription">The audio component description.</param>
		/// <param name="outError">
		///   <para>On return, contains any error that occurred.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new <see cref="AUAudioUnit" /> with the specified values.</summary>
		
		[Export ("initWithComponentDescription:error:")]
		NativeHandle Constructor (AudioComponentDescription componentDescription, [NullAllowed] out NSError outError);

		/// <param name="componentDescription">The audio component description.</param>
		/// <param name="options">The instantiation options.</param>
		/// <param name="completionHandler">The completion handler called when instantiation finishes.</param>
		///         <summary>Asynchronously creates an <see cref="AUAudioUnit" />.</summary>
		[Static]
		[Export ("instantiateWithComponentDescription:options:completionHandler:")]
		[Async (XmlDocs = """
			<param name="componentDescription">The audio component description.</param>
			<param name="options">The instantiation options.</param>
			<summary>Asynchronously creates an <see cref="AUAudioUnit" />.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous FromComponentDescription operation.  The value of the TResult parameter is of type System.Action&lt;AudioUnit.AUAudioUnit,Foundation.NSError&gt;.</para>
			        </returns>
			
			""")]
		void FromComponentDescription (AudioComponentDescription componentDescription, AudioComponentInstantiationOptions options, Action<AUAudioUnit, NSError> completionHandler);

		/// <summary>Gets the component from the description with which the audio unit was created.</summary>
		[Export ("componentDescription")]
		AudioComponentDescription ComponentDescription { get; }

		/// <summary>Gets the render block that is used for rendering audio.</summary>
		[Export ("renderBlock")]
		AURenderBlock RenderBlock { get; }

		/// <summary>Gets the developer-provided block that performs audio rendering.</summary>
		[Export ("internalRenderBlock")]
		AUInternalRenderBlock InternalRenderBlock { get; }

		// @property (readonly, nonatomic) AudioComponent __nonnull component;
		/// <summary>Gets the component from the description with which the audio unit was created.</summary>
		[Export ("component")]
		unsafe AudioComponent Component { get; }

		/// <summary>Gets the audio units component name.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("componentName")]
		string ComponentName { get; }

		/// <summary>Gets the name of the audio unit.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("audioUnitName")]
		string AudioUnitName { get; }

		/// <summary>Gets the manufacturer name for the audio unit.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("manufacturerName")]
		string ManufacturerName { get; }

		/// <summary>Gets or sets the full state of the audio unit.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("audioUnitShortName")]
		string ShortName { get; }

		/// <summary>Gets the version of the audio unit.</summary>
		[Export ("componentVersion")]
		uint ComponentVersion { get; }

		/// <param name="outError">
		///   <para>The audio format, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Allocates the resources that are needed to render audio.</summary>
		/// <returns>An audio format override, or <see langword="null" /> to use the default.</returns>
		[Export ("allocateRenderResourcesAndReturnError:")]
		bool AllocateRenderResources ([NullAllowed] out NSError outError);

		/// <summary>Deallocates the resources that are needed to render audio.</summary>
		[Export ("deallocateRenderResources")]
		void DeallocateRenderResources ();

		/// <summary>Gets a Boolean value that tells whether rendering resources have been allocated.</summary>
		[Export ("renderResourcesAllocated")]
		bool RenderResourcesAllocated { get; }

		/// <summary>Resets rendering to its initial state.</summary>
		[Export ("reset")]
		void Reset ();

		/// <summary>Gets an array that contains the input connections for the audio unit.</summary>
		[Export ("inputBusses")]
		AUAudioUnitBusArray InputBusses { get; }

		/// <summary>Gets an array that contains the output connections for the audio unit.</summary>
		[Export ("outputBusses")]
		AUAudioUnitBusArray OutputBusses { get; }

		/// <summary>Block that schedules parameters.</summary>
		[Export ("scheduleParameterBlock")]
		AUScheduleParameterBlock ScheduleParameterBlock { get; }

		// TODO: https://github.com/dotnet/macios/issues/12489
		// [TV (15,0), iOS (15,0), MacCatalyst (15,0)]
		// [NullAllowed]
		// [Export ("scheduleMIDIEventListBlock")]
		// AUMidiEventListBlock ScheduleMidiEventListBlock { get; }

		// 		[Export ("tokenByAddingRenderObserver:")]
		// 		nint GetToken (AURenderObserver observer);

		// 		[NullAllowed, Export ("scheduleMIDIEventBlock")]
		// 		AUScheduleMidiEventBlock ScheduleMidiEventBlock { get; }

		// 		[NullAllowed, Export ("musicalContextBlock", ArgumentSemantic.Copy)]
		// 		AUHostMusicalContextBlock MusicalContextBlock { get; set; }

		/// <summary>Gets or sets the internal rendering block.</summary>
		[MacCatalyst (13, 1)]
		[Export ("MIDIOutputNames", ArgumentSemantic.Copy)]
		string [] MidiOutputNames { get; }

		// TODO: https://github.com/dotnet/macios/issues/12489
		// [TV (15,0), iOS (15,0), MacCatalyst (15,0)]
		// [NullAllowed]
		// [Export ("MIDIOutputEventListBlock", ArgumentSemantic.Copy)]
		// AUMidiEventListBlock MidiOutputEventListBlock { get; set; }

		// TODO: https://github.com/dotnet/macios/issues/12489
		// [TV (15,0), iOS (15,0), MacCatalyst (15,0)]
		// [Export ("AudioUnitMIDIProtocol")]
		// MIDIProtocolID AudioUnitMidiProtocol { get; }

		// TODO: https://github.com/dotnet/macios/issues/12489
		// [TV (15,0), iOS (15,0), MacCatalyst (15,0)]
		// [Export ("hostMIDIProtocol", ArgumentSemantic.Assign)]
		// MIDIProtocolID HostMIDIProtocol { get; set; }

		/// <summary>Gets the supported view configurations.</summary>
		[MacCatalyst (13, 1)]
		[Export ("providesUserInterface")]
		bool ProvidesUserInterface { get; }

		/// <summary>Selects the best view configuration from the available options.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("MIDIOutputEventBlock", ArgumentSemantic.Copy)]
		AUMidiOutputEventBlock MidiOutputEventBlock { get; set; }

		/// <summary>A delegate block that provides information about its transport state.</summary>
		///         <value>
		///           <para>Developers may optionally assign an instance of the <see cref="AUHostTransportStateBlock" /> delegate to thIProperty so that they can call it at the beginning of render cycles to get the transport state at the cycle start.</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("transportStateBlock", ArgumentSemantic.Copy)]
		AUHostTransportStateBlock TransportStateBlock { get; set; }

		/// <param name="token">The scheduling token.</param>
		/// <summary>Removes the observer block that is identified by <paramref name="token" />.</summary>
		
		[Export ("removeRenderObserver:")]
		void RemoveRenderObserver (nint token);

		/// <summary>Gets or sets the maximum number of audio frames to render simultaneously.</summary>
		[Export ("maximumFramesToRender")]
		uint MaximumFramesToRender { get; set; }

		/// <summary>Gets or sets the entire tree of output parameters.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("parameterTree")]

		AUParameterTree ParameterTree {
			get;
			[TV (13, 0), iOS (13, 0)]
			[MacCatalyst (13, 1)]
			set;
		}

		/// <param name="count">The maximum number of frames to render.</param>
		/// <summary>Returns the <paramref name="count" /> most important parameters.</summary>
		/// <returns><see langword="true" /> if the change was successful; otherwise, <see langword="false" />.</returns>
		
		[Export ("parametersForOverviewWithCount:")]
		NSNumber [] GetParametersForOverview (nint count);

		/// <summary>Gets a special value that is required for key-value observing notifications</summary>
		[Export ("allParameterValues")]
		bool AllParameterValues { get; }

		/// <summary>Gets a value that is <see langword="true" /> if the audio unit is either a music device or an effect.</summary>
		[Export ("musicDeviceOrEffect")]
		bool MusicDeviceOrEffect { [Bind ("isMusicDeviceOrEffect")] get; }

		/// <summary>Gets the number of virtual MIDI cables that are implemented by the device or effect.</summary>
		[Export ("virtualMIDICableCount")]
		nint VirtualMidiCableCount { get; }

		// @property (copy, nonatomic) NSDictionary<NSString * __nonnull,id __nonnull> * __nullable fullState;
		/// <summary>Gets or sets the snapshot of the audio unit's entire state, for saving presets.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("fullState", ArgumentSemantic.Copy)]
		NSDictionary FullState { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString * __nonnull,id __nonnull> * __nullable fullStateForDocument;
		/// <summary>Gets or sets the snapshot of the audio unit's entire state, for saving in a document.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("fullStateForDocument", ArgumentSemantic.Copy)]
		NSDictionary FullStateForDocument { get; set; }

		/// <summary>Gets the factory presets for the audio unit.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("factoryPresets", ArgumentSemantic.Copy)]
		AUAudioUnitPreset [] FactoryPresets { get; }

		/// <summary>Gets the most recently selected preset.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("currentPreset", ArgumentSemantic.Retain)]
		AUAudioUnitPreset CurrentPreset { get; set; }

		/// <summary>Gets the latency of the audio unit, in seconds</summary>
		[Export ("latency")]
		double Latency { get; }

		/// <summary>Gets the tail time, in seconds, of the audio unit.</summary>
		[Export ("tailTime")]
		double TailTime { get; }

		/// <summary>Gets or sets the rendering quality, a value in [0,127].</summary>
		[Export ("renderQuality", ArgumentSemantic.Assign)]
		nint RenderQuality { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether an effect should skip processing and go directly to the output.</summary>
		[Export ("shouldBypassEffect")]
		bool ShouldBypassEffect { get; set; }

		/// <summary>Gets a Boolean value that tells whether the audio unit can transform input to output without allocating a new buffer.</summary>
		[Export ("canProcessInPlace")]
		bool CanProcessInPlace { get; }

		/// <summary>Gets or sets a Boolean value that controls whether the audio unit is currently rendering offline.</summary>
		[Export ("renderingOffline")]
		bool RenderingOffline { [Bind ("isRenderingOffline")] get; set; }

		/// <summary>Gets an array that describes valid combinations of input and output channels.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("channelCapabilities", ArgumentSemantic.Copy)]
		NSNumber [] ChannelCapabilities { get; }

		/// <summary>Gets the name of the context to which the audio unit is connected.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("contextName")]
		string ContextName { get; set; }

		/// <summary>Gets a Boolean values that tells whether MPE audio is supported.</summary>
		[MacCatalyst (13, 1)]
		[Export ("supportsMPE")]
		bool SupportsMpe { get; }

		/// <summary>Gets or sets the channel map.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[Export ("channelMap"), NullAllowed]
		NSNumber [] ChannelMap { get; set; }

		/// <param name="completionHandler">The handler called with the parameter tree.</param>
		///         <summary>Requests the view controller for the audio unit and runs <paramref name="completionHandler" /> when finished.</summary>
		[NoTV]
		[MacCatalyst (13, 1)]
		[Export ("requestViewControllerWithCompletionHandler:")]
		[Async (XmlDocs = """
			<summary>Asynchronously requests the view controller for the audio unit.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous RequestViewController operation.  The result is of type System.Threading.Tasks.Task&lt;AppKit.NSViewController&gt; on MacOS and System.Threading.Tasks.Task&lt;AppKit.UIViewController&gt; on iOS.</para>
			        </returns>
			<remarks>
			          <para copied="true">The RequestViewControllerAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			        </remarks>
			""")]
		void RequestViewController (Action<AUViewControllerBase> completionHandler);

		// AUAudioUnitImplementation
		/// <param name="flag">Whether to indicate the parameter change will begin.</param>
		///         <summary>Sets the <see cref="AUAudioUnit.RenderResourcesAllocated" /> property.</summary>
		[Export ("setRenderResourcesAllocated:")]
		void SetRenderResourcesAllocated (bool flag);

		/// <param name="format">The audio format to set.</param>
		/// <param name="bus">The bus to set the format on.</param>
		///         <summary>Method that is called when the developer sets the bus format.</summary>
		/// <returns><see langword="true" /> if the format was set; otherwise, <see langword="false" />.</returns>
		[Export ("shouldChangeToFormat:forBus:")]
		bool ShouldChangeToFormat (AVAudioFormat format, AUAudioUnitBus bus);

		[Notification, Field ("kAudioComponentRegistrationsChangedNotification", "AudioToolbox")]
		NSString AudioComponentRegistrationsChangedNotification { get; }

		[Notification, Field ("kAudioComponentInstanceInvalidationNotification", "AudioToolbox")]
		NSString AudioComponentInstanceInvalidationNotification { get; }

		/// <summary>Gets the MIDI CI profile state for this audio unit.</summary>
		[MacCatalyst (13, 1)]
		[Export ("MIDIOutputBufferSizeHint")]
		nint MidiOutputBufferSizeHint { get; set; }

		/// <param name="cable">The MIDI cable number.</param>
		/// <param name="channel">The MIDI channel.</param>
		/// <summary>Gets the profile state for the specified cable and channel.</summary>
		/// <returns>The MIDI CI profile state.</returns>
		[NoTV]
		[MacCatalyst (13, 1)]
		[Export ("profileStateForCable:channel:")]
		MidiCIProfileState GetProfileState (byte cable, byte channel);

		/// <summary>Gets the delegate for MIDI CI profiles.</summary>
		[NoTV]
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("profileChangedBlock", ArgumentSemantic.Assign)]
		AUMidiCIProfileChangedCallback ProfileChangedCallback { get; set; }

		/// <param name="profile">The MIDI CI profile to enable.</param>
		/// <param name="cable">The MIDI cable number.</param>
		/// <param name="channel">The MIDI channel.</param>
		/// <param name="outError">On return, contains any error that occurred.</param>
		/// <summary>Enables the specified MIDI CI profile.</summary>
		/// <returns><see langword="true" /> if the profile was enabled; otherwise, <see langword="false" />.</returns>
		[NoTV]
		[MacCatalyst (13, 1)]
		[Export ("disableProfile:cable:onChannel:error:")]
		bool Disable (MidiCIProfile profile, byte cable, byte channel, [NullAllowed] out NSError outError);

		/// <param name="profile">The MIDI CI profile to disable.</param>
		/// <param name="cable">The MIDI cable number.</param>
		/// <param name="channel">The MIDI channel.</param>
		/// <param name="outError">On return, contains any error that occurred.</param>
		/// <summary>Disables the specified MIDI CI profile.</summary>
		/// <returns><see langword="true" /> if the profile was disabled; otherwise, <see langword="false" />.</returns>
		[NoTV]
		[MacCatalyst (13, 1)]
		[Export ("enableProfile:cable:onChannel:error:")]
		bool Enable (MidiCIProfile profile, byte cable, byte channel, [NullAllowed] out NSError outError);

		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("userPresets", ArgumentSemantic.Copy)]
		AUAudioUnitPreset [] UserPresets { get; }

		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("saveUserPreset:error:")]
		bool SaveUserPreset (AUAudioUnitPreset userPreset, [NullAllowed] out NSError outError);

		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("deleteUserPreset:error:")]
		bool DeleteUserPreset (AUAudioUnitPreset userPreset, [NullAllowed] out NSError outError);

		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("presetStateFor:error:")]
		[return: NullAllowed]
		NSDictionary<NSString, NSObject> GetPresetState (AUAudioUnitPreset userPreset, [NullAllowed] out NSError outError);

		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("supportsUserPresets")]
		bool SupportsUserPresets { get; }

		[Introduced (PlatformName.MacCatalyst, 13, 0)] // needed since it's not in iOS
		[NoTV, NoiOS]
		[Export ("isLoadedInProcess")]
		bool IsLoadedInProcess { get; }

		[TV (16, 0), Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0)]
		[Export ("migrateFromPlugin")]
		NSData [] MigrateFromPlugin { get; }
	}

	// kept separate from AUAudioUnit, quote:
	// These methods will fail if the audio unit is not an input/output audio unit.
	/// <summary>Defines the interface of a host to an audio unit.</summary>
	[MacCatalyst (13, 1)]
	[Category]
	[BaseType (typeof (AUAudioUnit))]
	interface AUAudioUnit_AUAudioInputOutputUnit {

		/// <summary>Gets the available input devices.</summary>
		/// <returns>An array of available input devices.</returns>
		
		[NoTV, NoiOS]
		[NoMacCatalyst]
		[Export ("deviceID")]
		uint GetDeviceId ();

		/// <param name="deviceID">The device identifier to set as input.</param>
		/// <param name="outError">On return, contains any error that occurred.</param>
		/// <summary>Sets the input device to use.</summary>
		/// <returns><see langword="true" /> if the device was set; otherwise, <see langword="false" />.</returns>
		
		[NoTV, NoiOS]
		[NoMacCatalyst]
		[Export ("setDeviceID:error:")]
		bool SetDeviceId (uint deviceID, out NSError outError);

		/// <summary>Returns a Boolean value that tells whether the audio unit can perform input operations.</summary>
		/// <returns><see langword="true" /> if input is enabled; otherwise, <see langword="false" />.</returns>
		
		[Export ("canPerformInput")]
		bool GetCanPerformInput ();

		/// <summary>Returns a Boolean value that tells whether the audio unit can perform output operations.</summary>
		/// <returns><see langword="true" /> if input is muted; otherwise, <see langword="false" />.</returns>
		
		[Export ("canPerformOutput")]
		bool CanPerformOutput ();

		/// <summary>Returns a Boolean value that tells whether input is currently enabled on the audio unit.</summary>
		/// <returns>The current input device identifier.</returns>
		
		[Export ("isInputEnabled")]
		bool IsInputEnabled ();

		/// <param name="enabled">Whether to enable or disable input.</param>
		/// <summary>Sets a Boolean value that controls whether input is enabled on the audio unit.</summary>
		/// <returns><see langword="true" /> if the change was successful; otherwise, <see langword="false" />.</returns>
		
		[Export ("setInputEnabled:")]
		bool SetInputEnabled (bool enabled);

		/// <summary>Returns a Boolean value that tells whether input is currently enabled on the audio unit.</summary>
		/// <returns><see langword="true" /> if input is enabled; otherwise, <see langword="false" />.</returns>
		
		[Export ("isOutputEnabled")]
		bool IsOutputEnabled ();

		/// <param name="enabled">Whether to enable or disable.</param>
		/// <summary>Sets a Boolean value that controls whether output is enabled on the audio unit..</summary>
		/// <returns><see langword="true" /> if the change was successful; otherwise, <see langword="false" />.</returns>
		
		[Export ("setOutputEnabled:")]
		bool SetOutputEnabled (bool enabled);

		/// <summary>Gets the input handler for this IO unit</summary>
		/// <returns><see langword="true" /> if muted; otherwise, <see langword="false" />.</returns>
		
		[return: NullAllowed]
		[Export ("inputHandler", ArgumentSemantic.Copy)]
		AUInputHandler GetInputHandler ();

		/// <param name="handler">The handler to set.</param>
		/// <summary>Sets the input handler to the specified value.</summary>
		
		[Export ("setInputHandler:")]
		void SetInputHandler ([NullAllowed] AUInputHandler handler);

		/// <param name="outError">
		///   <para>The error, or <see langword="null" /> on success.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Starts the audio unit's hardware.</summary>
		/// <returns><see langword="true" /> if the change was successful; otherwise, <see langword="false" />.</returns>
		
		[Export ("startHardwareAndReturnError:")]
		bool StartHardware ([NullAllowed] out NSError outError);

		/// <summary>Stops the audio unit's hardware.</summary>
		
		[Export ("stopHardware")]
		void StopHardware ();

		/// <summary>Gets the output provider for this IO unit.</summary>
		/// <returns><see langword="true" /> if running; otherwise, <see langword="false" />.</returns>
		
		[return: NullAllowed]
		[Export ("outputProvider", ArgumentSemantic.Copy)]
		AURenderPullInputBlock GetOutputProvider ();

		/// <param name="provider">The provider to set.</param>
		/// <summary>Sets the output provider to the specified value.</summary>
		
		[Export ("setOutputProvider:")]
		void SetOutputProvider ([NullAllowed] AURenderPullInputBlock provider);

		// the following are properties but we cannot have properties in Categories.
		/// <summary>Gets the available output devices.</summary>
		/// <returns>An array of available output devices.</returns>
		
		[NoiOS, NoTV]
		[NoMacCatalyst]
		[Export ("deviceInputLatency")]
		double GetDeviceInputLatency ();

		/// <summary>Gets the current output device identifier.</summary>
		/// <returns>The output device identifier.</returns>
		
		[NoiOS, NoTV]
		[NoMacCatalyst]
		[Export ("deviceOutputLatency")]
		double GetDeviceOutputLatency ();

		/// <summary>Sets the output device to use.</summary>
		/// <returns><see langword="true" /> if the device was set; otherwise, <see langword="false" />.</returns>
		
		[MacCatalyst (13, 1)]
		[Export ("running")]
		bool IsRunning ();
	}

	/// <summary>An input or output connection to an audio unit.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AudioUnit/Reference/AUAudioUnitBus_ClassReference/index.html">Apple documentation for <c>AUAudioUnitBus</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface AUAudioUnitBus {
		/// <param name="format">A value that provides a detailed description of the channels and formats of audio data.</param>
		/// <param name="outError">
		///           <para>A location to which to record success or failure.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new <see cref="AUAudioUnitBus" /> with the specified <paramref name="format" /> and reports success or failure to <paramref name="outError" />.</summary>
		
		[Export ("initWithFormat:error:")]
		NativeHandle Constructor (AVAudioFormat format, [NullAllowed] out NSError outError);

		/// <summary>Gets a value that provides a detailed description of the channels and formats of audio data.</summary>
		[Export ("format")]
		AVAudioFormat Format { get; }

		/// <param name="format">A description of the audio format for the bus.</param>
		///         <param name="outError">
		///           <para>A location to which to record success or failure.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Sets configuration details about the supported channels and formats of audio data on this bus.</summary>
		/// <returns>A new AUAudioUnit instance.</returns>
		[Export ("setFormat:error:")]
		bool SetFormat (AVAudioFormat format, [NullAllowed] out NSError outError);

		/// <summary>Gets or sets a value that determines whether the bus is active.</summary>
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		/// <summary>Gets or sets the name for the bus.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("name")]
		string Name { get; set; }

		/// <summary>Gets the zero-based location of this audio bus in the array that contains it.</summary>
		[Export ("index")]
		nuint Index { get; }

		/// <summary>Gets a value of type <see cref="AUAudioUnitBusType" /> that tells whether this is an input or output connection.</summary>
		[Export ("busType")]
		AUAudioUnitBusType BusType { get; }

		/// <summary>Gets the audio unit that owns this bus.</summary>
		[Export ("ownerAudioUnit", ArgumentSemantic.Assign)]
		AUAudioUnit OwnerAudioUnit { get; }

		/// <summary>Gets an array of audio channel layout tags that are supported by this bus.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("supportedChannelLayoutTags", ArgumentSemantic.Copy)]
		NSNumber [] SupportedChannelLayoutTags { get; }

		/// <summary>Gets or sets the latency of the processing context for the audio unit.</summary>
		///         <remarks>For input units, this is the time, in seconds, since the arriving audio was acquired. For output units, this is the delay, in seconds, until the output is presented.</remarks>
		[Export ("contextPresentationLatency")]
		double ContextPresentationLatency { get; set; }

		// AUAudioUnitImplementation
		/// <summary>Gets or sets an array that contains the allowable channel counts for this bus. <see langword="null" /> indicates that any number less than <see cref="AUAudioUnitBus.MaximumChannelCount" /> is supported.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("supportedChannelCounts", ArgumentSemantic.Retain)]
		NSNumber [] SupportedChannelCounts { get; set; }

		/// <summary>Gets or sets the maximum number of audio channels that the bus supports.</summary>
		[Export ("maximumChannelCount")]
		uint MaximumChannelCount { get; set; }

		/// <summary>Gets or sets the key path for the parameter.</summary>
		[MacCatalyst (13, 1)]
		[Export ("shouldAllocateBuffer")]
		bool ShouldAllocateBuffer { get; set; }
	}

	/// <summary>A container that holds <see cref="AUAudioUnitBus" /> objects for an audio unit.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AudioUnit/Reference/AUAudioUnitBusArray_ClassReference/index.html">Apple documentation for <c>AUAudioUnitBusArray</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface AUAudioUnitBusArray : INSFastEnumeration {
		/// <param name="owner">The owner of the bus array.</param>
		/// <param name="busType">Whether the bus array will be for input or output.</param>
		/// <param name="busArray">The bus array whose members to copy.</param>
		/// <summary>Creates a new <see cref="AUAudioUnitBusArray" />, with the specified owner ant type, by copying the buses in <paramref name="busArray" />.</summary>
		
		[Export ("initWithAudioUnit:busType:busses:")]
		[DesignatedInitializer]
		NativeHandle Constructor (AUAudioUnit owner, AUAudioUnitBusType busType, AUAudioUnitBus [] busArray);

		/// <param name="owner">The owner of the bus array.</param>
		/// <param name="busType">Whether the bus array will be for input or output.</param>
		/// <summary>Creates a new <see cref="AUAudioUnitBusArray" /> with the specified owner ant type.</summary>
		
		[Export ("initWithAudioUnit:busType:")]
		NativeHandle Constructor (AUAudioUnit owner, AUAudioUnitBusType busType);

		/// <summary>Gets the number of buses in the array.</summary>
		///         <value>The number of buses in the array.</value>
		[Export ("count")]
		nuint Count { get; }

		// -(AUAudioUnitBus * __nonnull)objectAtIndexedSubscript:(NSUInteger)index;
		/// <param name="index">The zero-based index into the bus array of the desired bus.</param>
		/// <summary>Returns the bus at the specified location in the array.</summary>
		/// <returns>The bus at the specified location in the array.</returns>
		
		[Export ("objectAtIndexedSubscript:")]
		AUAudioUnitBus GetObject (nuint index);

		/// <summary>Gets a Boolean value that tells whether buses can be added and removed from the array.</summary>
		///         <value>A Boolean value that tells whether buses can be added and removed from the array.</value>
		[Export ("countChangeable")]
		bool CountChangeable { [Bind ("isCountChangeable")] get; }

		/// <param name="count">The number of children in the group.</param>
		/// <param name="outError">
		///   <para>The children of this group.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a parameter group with the specified children.</summary>
		/// <returns>A new parameter group.</returns>
		
		[Export ("setBusCount:error:")]
		bool SetBusCount (nuint count, [NullAllowed] out NSError outError);

		// -(void)addObserverToAllBusses:(NSObject * __nonnull)observer forKeyPath:(NSString * __nonnull)keyPath options:(NSKeyValueObservingOptions)options context:(void * __nullable)context;
		/// <param name="observer">The KVO observer to add to all buses in the array.</param>
		///         <param name="keyPath">The object-relative keypath that identifies the property to observe.</param>
		///         <param name="options">The observing options for the observer.</param>
		///         <param name="context">An object or value that is used to disambiguate observer calls.</param>
		///         <summary>Adds a key-value observer to every bus in the array.</summary>
		[Export ("addObserverToAllBusses:forKeyPath:options:context:")]
		void AddObserver (NSObject observer, string keyPath, NSKeyValueObservingOptions options, /* void * */ IntPtr context);

		// -(void)removeObserverFromAllBusses:(NSObject * __nonnull)observer forKeyPath:(NSString * __nonnull)keyPath context:(void * __nullable)context;
		/// <param name="observer">The KVO observer to remove from all buses in the array.</param>
		///         <param name="keyPath">The object-relative keypath that identifies the observer to remove.</param>
		///         <param name="context">The object or value that was used to disambiguate observer calls.</param>
		///         <summary>Removes the specified key-value observer from every bus in the array.</summary>
		/// <summary>Creates a parameter node with the specified parameters.</summary>
		[Export ("removeObserverFromAllBusses:forKeyPath:context:")]
		void RemoveObserver (NSObject observer, string keyPath, /* void * */ IntPtr context);

		/// <summary>Gets the audio unit that owns this array.</summary>
		///         <value>The audio unit that owns this array.</value>
		[Export ("ownerAudioUnit", ArgumentSemantic.Assign)]
		AUAudioUnit OwnerAudioUnit { get; }

		/// <summary>Gets a value that tells whether this is an input or output bus array.</summary>
		///         <value>A value that tells whether this is an input or output bus array.</value>
		[Export ("busType")]
		AUAudioUnitBusType BusType { get; }

		//AUAudioUnitBusImplementation
		/// <param name="busArray">An array of buses to copy into this bus array.</param>
		///         <summary>Copies <paramref name="busArray" /> into this bus array, replacing the current buses in this array.</summary>
		///         <remarks>This method is applicable only to subclasses of <see cref="AUAudioUnit" />.</remarks>
		[Export ("replaceBusses:")]
		void ReplaceBusses (AUAudioUnitBus [] busArray);
	}

	/// <summary>A name and identifier for a custom parameter preset.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AudioUnit/Reference/AUAudioUnitPreset_ClassReference/index.html">Apple documentation for <c>AUAudioUnitPreset</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface AUAudioUnitPreset : NSSecureCoding {
		/// <summary>Gets or sets a unique identifier for the preset.</summary>
		///         <value>The unique identifier for the preset.</value>
		[Export ("number", ArgumentSemantic.Assign)]
		nint Number { get; set; }

		/// <summary>Gets or sets the name of the preset.</summary>
		///         <value>The name of the preset.</value>
		[Export ("name")]
		string Name { get; set; }
	}

	/// <summary>An audio unit parameter.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AudioUnit/Reference/AUParameter_ClassReference/index.html">Apple documentation for <c>AUParameter</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (AUParameterNode))]
	interface AUParameter : NSSecureCoding {
		/// <summary>Gets the parameter's minimum value.</summary>
		///         <value>The parameter's minimum value.</value>
		[Export ("minValue")]
		float MinValue { get; }

		/// <summary>Gets the parameter's maximum value.</summary>
		///         <value>The parameter's maximum value.</value>
		[Export ("maxValue")]
		float MaxValue { get; }

		/// <summary>Gets the unit of measurement for the value of the parameter.</summary>
		///         <value>The unit of measurement for the value of the parameter.</value>
		[Export ("unit")]
		AudioUnitParameterUnit Unit { get; }

		/// <summary>Gets the localized unit of measurement for the value of the parameter.</summary>
		///         <value>
		///           <para>The localized unit of measurement for the value of the parameter.</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("unitName")]
		string UnitName { get; }

		/// <summary>Gets the parameter option flags for this parameter.</summary>
		[Export ("flags")]
		AudioUnitParameterOptions Flags { get; }

		/// <summary>Gets the address (a non-persistent numerical identifier) for the parameter.</summary>
		///         <value>A non-persistent numeric identifier for the parameter.</value>
		[Export ("address")]
		ulong Address { get; }

		/// <summary>Gets an array that contains allowable localized value names for the parameter.</summary>
		///         <value>
		///           <para>An array that contains allowable localized value names for the parameter.</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("valueStrings", ArgumentSemantic.Copy)]
		string [] ValueStrings { get; }

		/// <summary>Gets an array of addresses for parameters that may be changed when the developer changes this parameter.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("dependentParameters", ArgumentSemantic.Copy)]
		NSNumber [] DependentParameters { get; }

		/// <summary>Gets the current value of the parameter.</summary>
		///         <value>The current value of the parameter.</value>
		[Export ("value")]
		float Value { get; set; }

		/// <param name="value">The value to set.</param>
		///         <param name="originator">The originator, whose notification should be skipped.</param>
		///         <summary>Sets the parameter's value without notifying <paramref name="originator" />.</summary>
		[Export ("setValue:originator:")]
		void SetValue (float value, IntPtr originator);

		/// <param name="value">The value to set.</param>
		///         <param name="originator">The originator, whose notification should be skipped.</param>
		///         <summary>Sets the parameter to <paramref name="value" />.</summary>
		[Wrap ("SetValue (value, originator.ObserverToken)")]
		void SetValue (float value, AUParameterObserverToken originator);

		/// <param name="value">The value to set.</param>
		///         <param name="originator">The originator, whose notification should be skipped.</param>
		///         <param name="hostTime">The time to apply the change.</param>
		///         <summary>Sets the parameter's value, without notifying <paramref name="originator" />, at the specified <paramref name="hostTime" />.</summary>
		[Export ("setValue:originator:atHostTime:")]
		void SetValue (float value, IntPtr originator, ulong hostTime);

		/// <param name="value">The value to set.</param>
		///         <param name="originator">The originator, whose notification should be skipped.</param>
		///         <param name="hostTime">The host time of the initiating gesture.</param>
		///         <summary>Sets the parameter to the specified value, and preserves the initiating gesture time.</summary>
		[Wrap ("SetValue (value, originator.ObserverToken, hostTime)")]
		void SetValue (float value, AUParameterObserverToken originator, ulong hostTime);

		// -(NSString * __nonnull)stringFromValue:(const AUValue * __nullable)value;
		/// <param name="value">The parameter value to represent as a string.</param>
		///         <summary>Returns the string representation of the parameter value that corresponds to <paramref name="value" />.</summary>
		/// <returns>A new parameter tree instance.</returns>
		[Export ("stringFromValue:")]
		string GetString (ref float value);

		[Internal]
		[Sealed]
		[Export ("stringFromValue:")]
		string _GetString (IntPtr value);

		/// <param name="str">The string representation for which to get AParameter value.</param>
		///         <summary>Returns the numeric value for the parameter in <paramref name="str" />.</summary>
		///         <returns>The numeric value for the parameter string.</returns>
		[Export ("valueFromString:")]
		float GetValue (string str);

		[MacCatalyst (13, 1)]
		[Internal]
		[Export ("setValue:originator:atHostTime:eventType:")]
		void SetValue (float value, IntPtr originator, ulong hostTime, AUParameterAutomationEventType eventType);

		/// <param name="value">The new parameter value.</param>
		/// <param name="originator">The originator of the value change.</param>
		/// <param name="hostTime">The host time of the change.</param>
		/// <param name="eventType">The type of parameter event.</param>
		///         <summary>Sets the parameter's value to <paramref name="value" />, with the specified <paramref name="hostTime" /> and <paramref name="eventType" />.</summary>
		[MacCatalyst (13, 1)]
		[Wrap ("SetValue (value, originator.ObserverToken, hostTime, eventType)")]
		void SetValue (float value, AUParameterObserverToken originator, ulong hostTime, AUParameterAutomationEventType eventType);
	}

	[MacCatalyst (13, 1)]
	delegate void AUParameterAutomationObserver (ulong address, float value);

	/// <summary>A node which represents AParameter or parameter group in an <see cref="AUParameterTree" />.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AudioUnit/Reference/AUParameterNode_ClassReference/index.html">Apple documentation for <c>AUParameterNode</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface AUParameterNode {
		/// <summary>Gets the permanent unique identifier for the node.</summary>
		///         <value>The unique identifier for the node.</value>
		///         <remarks>App developers must not change this property, as doing so will invalidate host documents between releases.</remarks>
		[Export ("identifier")]
		string Identifier { get; }

		/// <summary>Gets or sets the key path, the concatenation of the parameter's and its parents' identifiers.</summary>
		///         <value>The key path, the concatenation of the parameter's and its parents' identifiers.</value>
		[Export ("keyPath")]
		string KeyPath { get; }

		/// <summary>Gets the localized display name for the node.</summary>
		///         <value>The localized display name for the node.</value>
		[Export ("displayName")]
		string DisplayName { get; }

		/// <param name="maximumLength">The maximum length of the returned localized display name or display name fragment.</param>
		/// <summary>Returns the possibly truncated localized display name for the node.</summary>
		/// <returns>The possibly truncated localized display name for the node.</returns>
		
		[Export ("displayNameWithLength:")]
		string GetDisplayName (nint maximumLength);

		/// <param name="observer">The observer to add.</param>
		///         <summary>Adds an observer to AParameter or parameter group, and returns a token that identifies the observers for later removal.</summary>
		///         <returns>A token that identifies the observers for later removal.</returns>
		[Export ("tokenByAddingParameterObserver:")]
		/* void * */
		IntPtr TokenByAddingParameterObserver (AUParameterObserver observer);

		/// <param name="observer">The block that is called after the parameter changes.</param>
		///         <summary>Adds a observer for the parameter and returns a token that developers can use to identify it.</summary>
		///         <returns>A token that can be passed to the <see cref="RemoveParameterObserver" /> and <see cref="AUParameter.SetValue(System.Single,AUParameterObserverToken,System.UInt64,AUParameterAutomationEventType)" /> methods.</returns>
		[Wrap ("new AUParameterObserverToken { ObserverToken = TokenByAddingParameterObserver (observer) }")]
		AUParameterObserverToken CreateTokenByAddingParameterObserver (AUParameterObserver observer);

		/// <param name="observer">The observer to remove.</param>
		///         <summary>Adds a recording observer to AParameter or parameter group, and returns a token that identifies the observers for later removal.</summary>
		///         <returns>A token that identifies the observers for later removal.</returns>
		[Export ("tokenByAddingParameterRecordingObserver:")]
		/* void * */
		IntPtr TokenByAddingParameterRecordingObserver (AUParameterRecordingObserver observer);

		/// <param name="observer">The block that is called after the parameter changes.</param>
		///         <summary>Adds a recording observer for the parameter and returns a token that developers can use to identify it.</summary>
		///         <returns>A token that can be passed to the <see cref="AUParameterNode.RemoveParameterObserver(AUParameterObserverToken)" /> and <see cref="AUParameter.SetValue(System.Single,AUParameterObserverToken,System.UInt64,AUParameterAutomationEventType)" /> methods.</returns>
		[Wrap ("new AUParameterObserverToken { ObserverToken = TokenByAddingParameterRecordingObserver (observer) }")]
		AUParameterObserverToken CreateTokenByAddingParameterRecordingObserver (AUParameterRecordingObserver observer);

		/// <summary>Gets or sets the <see cref="AUImplementorValueObserver" /> that notifies the audio unit when AParameter value changes.</summary>
		///         <value>The <see cref="AUImplementorValueObserver" /> that notifies the audio unit when AParameter value changes.</value>
		[Export ("implementorValueObserver", ArgumentSemantic.Copy)]
		AUImplementorValueObserver ImplementorValueObserver { get; set; }

		/// <summary>Gets or sets the <see cref="AUImplementorValueObserver" /> that updates stale parameter values.</summary>
		///         <value>The <see cref="AUImplementorValueObserver" /> that updates stale parameter values.</value>
		[Export ("implementorValueProvider", ArgumentSemantic.Copy)]
		AUImplementorValueProvider ImplementorValueProvider { get; set; }

		/// <summary>Gets or sets the callback that provides AParameter value when provided with a string representation of the value of the parameter.</summary>
		///         <value>The callback that provides AParameter value when provided with a string representation of the value of the parameter.</value>
		[Export ("implementorValueFromStringCallback", ArgumentSemantic.Copy)]
		AUImplementorValueFromStringCallback ImplementorValueFromStringCallback { get; set; }

		/// <summary>Removes the parameter observer that is specified by <paramref name="token" />.</summary>
		/// <param name="token">An opaque pointer to the parameter observer to remove.</param>
		/// <remarks>Developers get valid <paramref name="token" /> instances by saving the value that is returned from <see cref="AUParameterNode.CreateTokenByAddingParameterRecordingObserver(AUParameterRecordingObserver)" />.</remarks>
		[Export ("removeParameterObserver:")]
		void RemoveParameterObserver (/* void * */ IntPtr token);

		/// <param name="token">An opaque pointer to the parameter observer to remove.</param>
		///         <summary>Removes the parameter observer that is identified by <paramref name="token" />.</summary>
		[Wrap ("RemoveParameterObserver (token.ObserverToken)")]
		void RemoveParameterObserver (AUParameterObserverToken token);

		/// <summary>Gets or sets the callback that provides a string representation of the value of the parameter.</summary>
		///         <value>The callback that provides the string representation of the value of the parameter.</value>
		[Export ("implementorStringFromValueCallback", ArgumentSemantic.Copy),]
		AUImplementorStringFromValueCallback ImplementorStringFromValueCallback { get; set; }

		/// <summary>Callback for retrieving an abbreviated display name.</summary>
		///         <value>The possibly abbreviated name.</value>
		[Export ("implementorDisplayNameWithLengthCallback", ArgumentSemantic.Copy)]
		AUImplementorDisplayNameWithLengthCallback ImplementorDisplayNameWithLengthCallback { get; set; }

		[MacCatalyst (13, 1)]
		[Internal]
		[Export ("tokenByAddingParameterAutomationObserver:")]
		IntPtr _GetToken (AUParameterAutomationObserver observer);

		/// <param name="observer">The observer token to remove.</param>
		///         <summary>Adds AParameter automation observer for the parameter and returns a token that developers can use to identify it.</summary>
		/// <returns>The parameter for the given address.</returns>
		[MacCatalyst (13, 1)]
		[Wrap ("new AUParameterObserverToken (_GetToken (observer))")]
		AUParameterObserverToken GetToken (AUParameterAutomationObserver observer);
	}

	/// <summary>A group of <see cref="AUParameter" /> objects for an audio unit.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AudioUnit/Reference/AUParameterGroup_ClassReference/index.html">Apple documentation for <c>AUParameterGroup</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (AUParameterNode))]
	interface AUParameterGroup : NSSecureCoding {
		/// <summary>Gets an array of the child nodes in the parameter group.</summary>
		///         <value>An array of the child nodes in the parameter group.</value>
		[Export ("children")]
		AUParameterNode [] Children { get; }

		/// <summary>Gets an array that contains all the parameters in the parameter group, including parameters in parameter group children.</summary>
		///         <value>An array that contains all the parameters in the parameter group, including parameters in parameter group children.</value>
		[Export ("allParameters")]
		AUParameter [] AllParameters { get; }
	}

	/// <summary>A tree that contains all of the audio unit parameters for an audio unit.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AudioUnit/Reference/AUParameterTree_ClassReference/index.html">Apple documentation for <c>AUParameterTree</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (AUParameterGroup))]
	interface AUParameterTree : NSSecureCoding {
		/// <param name="address">The address of the parameter to get.</param>
		///         <summary>Gets the parameter at the specified address.</summary>
		///         <returns>The parameter at the specified address.</returns>
		[Export ("parameterWithAddress:")]
		[return: NullAllowed]
		AUParameter GetParameter (ulong address);

		/// <param name="paramID">The parameter ID search parameter.</param>
		///         <param name="scope">The scope search parameter.</param>
		///         <param name="element">The element search parameter..</param>
		///         <summary>Gets the parameter at the specified <paramref name="paramID" />, in the specified <paramref name="scope" />, that corresponds to the specified <paramref name="element" />.</summary>
		///         <returns>The matching parameter, or <see langword="null" /> if no such parameter exists.</returns>
		[Export ("parameterWithID:scope:element:")]
		[return: NullAllowed]
		AUParameter GetParameter (uint paramID, uint scope, uint element);

		//Factory
		/// <include file="../docs/api/AudioUnit/AUParameterTree.xml" path="/Documentation/Docs[@DocId='M:AudioUnit.AUParameterTree.CreateParameter(System.String,System.String,System.UInt64,System.Single,System.Single,AudioUnit.AudioUnitParameterUnit,System.String,AudioUnit.AudioUnitParameterOptions,System.String[],Foundation.NSNumber[])']/*" />
		[Static]
		[Export ("createParameterWithIdentifier:name:address:min:max:unit:unitName:flags:valueStrings:dependentParameters:")]
		AUParameter CreateParameter (string identifier, string name, ulong address, float min, float max, AudioUnitParameterUnit unit, [NullAllowed] string unitName, AudioUnitParameterOptions flags, [NullAllowed] string [] valueStrings, [NullAllowed] NSNumber [] dependentParameters);

		/// <param name="identifier">A permanent non-localized name for the group.</param>
		///         <param name="name">A localized display name.</param>
		///         <param name="children">The array of parameter nodes that will become the group's children.</param>
		///         <summary>Creates AParameter group with the specified <paramref name="identifier" />, <paramref name="name" />, and <paramref name="children" />.</summary>
		///         <returns>A new parameter group.</returns>
		[Static]
		[Export ("createGroupWithIdentifier:name:children:")]
		AUParameterGroup CreateGroup (string identifier, string name, AUParameterNode [] children);

		/// <param name="children">The template group's children.</param>
		///         <summary>Creates APrototype parameter group for creating related classes of parameter groups.</summary>
		///         <returns>A prototype parameter group for creating related classes of parameter groups.</returns>
		///         <remarks>Template parameter groups can only appear in trees at the root.</remarks>
		[Static]
		[Export ("createGroupTemplate:")]
		AUParameterGroup CreateGroupTemplate (AUParameterNode [] children);

		/// <param name="templateGroup">The parameter group to copy.</param>
		///         <param name="identifier">A permanent non-localized name for the new group.</param>
		///         <param name="name">A localized display name for the new group.</param>
		///         <param name="addressOffset">The offset, relative to the template group, of the new group's parameters.</param>
		///         <summary>Copies a template parameter group and sets the <paramref name="identifier" />, <paramref name="name" />, and template-group-relative <paramref name="addressOffset" />.</summary>
		///         <returns>The copied parameter group.</returns>
		[Static]
		[Export ("createGroupFromTemplate:identifier:name:addressOffset:")]
		AUParameterGroup CreateGroup (AUParameterGroup templateGroup, string identifier, string name, ulong addressOffset);

		/// <param name="children">The children of the new tree.</param>
		///         <summary>Creates a new parameter tree.</summary>
		///         <returns>A new parameter tree.</returns>
		[Static]
		[Export ("createTreeWithChildren:")]
		AUParameterTree CreateTree (AUParameterNode [] children);
	}

#if __TVOS__
	/// <summary>Interface that version 3 Audio Unit extensions must implement.</summary>
#else
	/// <summary>Interface that version 3 Audio Unit extensions must implement.</summary>
	/// <remarks>
	///   <para>Developers who want to create a version 3 Audio Unit extension must implement this interface on a class that inherits from <see cref="NSObject" /> or <see cref="AUViewController" />.</para>
	/// </remarks>
#endif
	[Protocol]
	interface AUAudioUnitFactory : NSExtensionRequestHandling {
		/// <param name="desc">A description for the audio unit.</param>
		/// <param name="error">An <see langword="out" /> parameter into which any errors that are encountered are written.</param>
		/// <summary>Creates and returns an audio unit.</summary>
		/// <returns>An audio unit.</returns>
		
		[Abstract]
		[Export ("createAudioUnitWithComponentDescription:error:")]
		[return: NullAllowed]
		AUAudioUnit CreateAudioUnit (AudioComponentDescription desc, [NullAllowed] out NSError error);
	}
}
