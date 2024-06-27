//
// coremidi.cs: API definition for CoreMidi's Foundation based types
//
// Authors:
//   Miguel de Icaza
//
// Copyright 2012 Xamarin Inc
//
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using System;
using Foundation;
using CoreGraphics;
using ObjCRuntime;

using MidiObjectRef = System.Int32;
using MidiEndpointRef = System.Int32;
using MidiUmpFunctionBlockId = System.Byte;
using MidiUmpGroupNumber = System.Byte;
using MidiChannelNumber = System.Byte;

#if !NET
using NativeHandle = System.IntPtr;
#endif

#if TVOS || WATCH
using MidiEndpoint = System.Object;
using MidiCIDeviceIdentification = System.Object;
using MidiCIDeviceIdentification_Blittable = System.Object;
using MidiCIProfileId = System.Object;
using Midi2DeviceManufacturer = System.Object;
using Midi2DeviceRevisionLevel = System.Object;
#endif

namespace CoreMidi {


	[Watch (8, 0)]
	[TV (15, 0)]
	[MacCatalyst (13, 1)]
	// NSUInteger -> MIDINetworkSession.h
	[Native]
	public enum MidiNetworkConnectionPolicy : ulong {
		NoOne,
		HostsInContactsList,
		Anyone,
	}

	[Mac (11, 0), iOS (14, 0), TV (15, 0), Watch (8, 0)]
	[MacCatalyst (14, 0)]
	[NativeName ("MIDIProtocolID")]
	public enum MidiProtocolId {
		Protocol_1_0 = 1,
		Protocol_2_0 = 2,
	}

	[Mac (11, 0), iOS (14, 0), TV (15, 0), Watch (8, 0)]
	[MacCatalyst (14, 0)]
	[NativeName ("MIDICVStatus")]
	public enum MidiCVStatus : uint {
		RegisteredPnc = 0,
		AssignablePnc = 1,
		RegisteredControl = 2,
		AssignableControl = 3,
		RelRegisteredControl = 4,
		RelAssignableControl = 5,
		PerNotePitchBend = 6,
		// 7 is not present in the headers..
		NoteOff = 8,
		NoteOn = 9,
		PolyPressure = 10,
		ControlChange = 11,
		ProgramChange = 12,
		ChannelPressure = 13,
		PitchBend = 14,
		PerNoteMgmt = 15,
	}

	[Mac (11, 0), iOS (14, 0), TV (15, 0), Watch (8, 0)]
	[MacCatalyst (14, 0)]
	[NativeName ("MIDIMessageType")]
	public enum MidiMessageType : uint {
		Utility = 0,
		System = 1,
		ChannelVoice1 = 2,
		SysEx = 3,
		ChannelVoice2 = 4,
		Data128 = 5,
		FlexData = 0xD,
#if !XAMCORE_5_0
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Stream' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Stream' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Stream' instead.")]
		[Deprecated (PlatformName.WatchOS, 11, 0, message: "Use 'Stream' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Stream' instead.")]
		UnknownF = Stream,
#endif
		Stream = 0xF,
		Invalid = 0xFF,
	}

	[Mac (11, 0), iOS (14, 0), TV (15, 0), Watch (8, 0)]
	[MacCatalyst (14, 0)]
	[NativeName ("MIDISysExStatus")]
	public enum MidiSysExStatus : uint {
		Complete = 0,
		Start = 1,
		Continue = 2,
		End = 3,
		MixedDataSetHeader = 8,
		MixedDataSetPayload = 9,
	}

	[Mac (11, 0), iOS (14, 0), TV (15, 0), Watch (8, 0)]
	[MacCatalyst (14, 0)]
	[NativeName ("MIDISystemStatus")]
	public enum MidiSystemStatus : uint {
		StartOfExclusive = 240,
		EndOfExclusive = 247,
		Mtc = 241,
		SongPosPointer = 242,
		SongSelect = 243,
		TuneRequest = 246,
		TimingClock = 248,
		Start = 250,
		Continue = 251,
		Stop = 252,
		ActiveSending = 254,
		SystemReset = 255,
	}

	[iOS (16, 0), Mac (13, 0), MacCatalyst (16, 0), TV (15, 0), Watch (8, 0)]
	[NativeName ("MIDINoteAttribute")]
	public enum MidiNoteAttribute : byte {
		None = 0,
		ManufacturerSpecific = 1,
		ProfileSpecific = 2,
		Pitch = 3,
	}

	[iOS (16, 0), Mac (13, 0), MacCatalyst (16, 0), TV (15, 0), Watch (8, 0)]
	[NativeName ("MIDIPerNoteManagementOptions")]
	[Flags]
	public enum MidiPerNoteManagementOptions : byte {
		Reset = 1 << 0,
		Detach = 1 << 1,
	}

	[iOS (16, 0), Mac (13, 0), MacCatalyst (16, 0), TV (15, 0), Watch (8, 0)]
	[NativeName ("MIDIProgramChangeOptions")]
	[Flags]
	public enum MidiProgramChangeOptions : byte {
		BankValid = 1 << 0,
	}

	[iOS (16, 0), Mac (13, 0), MacCatalyst (16, 0), TV (15, 0), Watch (8, 0)]
	[NativeName ("MIDIUtilityStatus")]
	public enum MidiUtilityStatus : uint {
		Noop = 0,
		JitterReductionClock = 1,
		JitterReductionTimestamp = 2,
		[Watch (11, 0), TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		DeltaClockstampTicksPerQuarterNote = 0x3,
		[Watch (11, 0), TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		TicksSinceLastEvent = 0x4
	}

	[Watch (11, 0), TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[NativeName ("UMPStreamMessageStatus")]
	public enum UmpStreamMessageStatus : uint {
		EndpointDiscovery = 0x00,
		EndpointInfoNotification = 0x01,
		DeviceIdentityNotification = 0x02,
		EndpointNameNotification = 0x03,
		ProductInstanceIDNotification = 0x04,
		StreamConfigurationRequest = 0x05,
		StreamConfigurationNotification = 0x06,
		FunctionBlockDiscovery = 0x10,
		FunctionBlockInfoNotification = 0x11,
		FunctionBlockNameNotification = 0x12,
		StartOfClip = 0x20,
		EndOfClip = 0x21,
	}

	[Watch (11, 0), TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[NativeName ("MIDIUMPFunctionBlockMIDI1Info")]
	public enum MidiUmpFunctionBlockMidi1Info {
		NotMidi1 = 0,
		UnrestrictedBandwidth = 1,
		RestrictedBandwidth = 2
	}

	[Watch (11, 0), TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[NativeName ("MIDIUMPFunctionBlockUIHint")]
	public enum MidiUmpFunctionBlockUIHint {
		Unknown = 0,
		Receiver = 1,
		Sender = 2,
		SenderReceiver = 3
	}

	[Watch (11, 0), TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[NativeName ("MIDIUMPFunctionBlockDirection")]
	public enum MidiUmpFunctionBlockDirection {
		Unknown = 0,
		Input = 1,
		Output = 2,
		Bidirectional = 3
	}

	[Watch (11, 0), TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[NativeName ("UMPStreamMessageFormat")]
	public enum UmpStreamMessageFormat : byte {
		Complete = 0x00,
		Start = 0x01,
		Continuing = 0x02,
		End = 0x03
	}

	[Watch (11, 0), TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[NativeName ("MIDICICategoryOptions")]
	public enum MidiCICategoryOptions : byte /* MIDIUInteger7 = typedef UInt8 MIDIUInteger7;   //! 7  bits usable; allowed values 0x0~0x7F */ {
		ProtocolNegotiation = (1 << 1),
		ProfileConfigurationSupported = (1 << 2),
		PropertyExchangeSupported = (1 << 3),
		ProcessInquirySupported = (1 << 4),
	}

	[Watch (11, 0), TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[NativeName ("MIDICIDeviceType")]
	public enum MidiCIDeviceType : byte /* UInt8 */ {
		Unknown = 0,
		LegacyMidi1,
		Virtual,
		UsbMidi,
	}

	[Watch (11, 0), TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[NativeName ("MIDICIProfileMessageType")]
	public enum MidiCIProfileMessageType : byte /* MIDIUInteger7 = typedef UInt8 MIDIUInteger7;   //! 7  bits usable; allowed values 0x0~0x7F */ {
		ProfileInquiry = 0x20,
		ReplyToProfileInquiry = 0x21,
		SetProfileOn = 0x22,
		SetProfileOff = 0x23,
		ProfileEnabledReport = 0x24,
		ProfileDisabledReport = 0x25,
		ProfileAdded = 0x26,
		ProfileRemoved = 0x27,
		DetailsInquiry = 0x28,
		ReplyToDetailsInquiry = 0x29,
		ProfileSpecificData = 0x2F,
	}

	[Watch (11, 0), TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[NativeName ("MIDICIPropertyExchangeMessageType")]
	public enum MidiCIPropertyExchangeMessageType : byte /* MIDIUInteger7 = typedef UInt8 MIDIUInteger7;   //! 7  bits usable; allowed values 0x0~0x7F */ {
		InquiryPropertyExchangeCapabilities = 0x30,
		ReplyToPropertyExchangeCapabilities = 0x31,
		InquiryHasPropertyData_Reserved = 0x32,
		InquiryReplyToHasPropertyData_Reserved = 0x33,
		InquiryGetPropertyData = 0x34,
		ReplyToGetProperty = 0x35,
		InquirySetPropertyData = 0x36,
		ReplyToSetPropertyData = 0x37,
		Subscription = 0x38,
		ReplyToSubscription = 0x39,
		Notify = 0x3F,
	}

	[Watch (11, 0), TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[NativeName ("MIDICIProcessInquiryMessageType")]
	public enum MidiCIProcessInquiryMessageType : byte /* MIDIUInteger7 = typedef UInt8 MIDIUInteger7;   //! 7  bits usable; allowed values 0x0~0x7F */ {
		InquiryProcessInquiryCapabilities = 0x40,
		ReplyToProcessInquiryCapabilities = 0x41,
		InquiryMidiMessageReport = 0x42,
		ReplyToMidiMessageReport = 0x43,
		EndOfMidiMessageReport = 0x44,
	}

	[Watch (11, 0), TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[NativeName ("MIDICIManagementMessageType")]
	public enum MidiCIManagementMessageType : byte /* MIDIUInteger7 = typedef UInt8 MIDIUInteger7;   //! 7  bits usable; allowed values 0x0~0x7F */ {
		Discovery = 0x70,
		ReplyToDiscovery = 0x71,
		InquiryEndpointInformation = 0x72,
		ReplyToEndpointInformation = 0x73,
		MIDICIACK = 0x7D,
		InvalidateMUID = 0x7E,
		MIDICINAK = 0x7F,
	}

	[Watch (11, 0), TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[NativeName ("MIDICIProfileType")]
	public enum MidiCIProfileType : byte /* UInt8  */ {
		SingleChannel = 1,
		Group = 2,
		FunctionBlock = 3,
		Multichannel = 4,
	}

	[Watch (11, 0), TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[NativeName ("MIDIUMPCIObjectBackingType")]
	public enum MidiUmpCIObjectBackingType : byte /* UInt8  */ {
		Unknown = 0,
		Virtual,
		DriverDevice,
		UsbMidi,
	}

	[Watch (11, 0), TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[NativeName ("MIDICIPropertyExchangeRequestID")]
	public enum MidiCIPropertyExchangeRequestID : byte /* UInt8  */ {
		BadRequest = 0xFF,
	}

	/// <summary>A remote MIDI host.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreMidi/Reference/MIDINetworkHost_ClassReference/index.html">Apple documentation for <c>MIDINetworkHost</c></related>
	[NoTV]
	[NoWatch]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject), Name = "MIDINetworkHost")]
	[DisableDefaultCtor]
	interface MidiNetworkHost {
		[Export ("name", ArgumentSemantic.Retain)]
		string Name { get; }

		[Export ("address", ArgumentSemantic.Retain)]
		string Address { get; }

		[Export ("port")]
		nint Port { get; }

		[NullAllowed]
		[Export ("netServiceName", ArgumentSemantic.Retain)]
		string NetServiceName { get; }

		[NullAllowed]
		[Export ("netServiceDomain", ArgumentSemantic.Retain)]
		string NetServiceDomain { get; }

		[Static]
		[Export ("hostWithName:netService:")]
		MidiNetworkHost Create (string hostName, NSNetService netService);

		[Static]
		[Export ("hostWithName:netServiceName:netServiceDomain:")]
		MidiNetworkHost Create (string hostName, string netServiceName, string netServiceDomain);

		[Static]
		[Export ("hostWithName:address:port:")]
		MidiNetworkHost Create (string hostName, string address, nint port);

		[Export ("hasSameAddressAs:")]
		bool HasSameAddressAs (MidiNetworkHost other);
	}

	/// <summary>Global methods and constants for using CoreMidi.</summary>
	[NoTV]
	[NoWatch]
	[MacCatalyst (13, 1)]
	[Static]
	interface Midi {
		[Field ("MIDINetworkNotificationContactsDidChange")]
		[Notification]
		NSString NetworkNotificationContactsDidChange { get; }

		[Field ("MIDINetworkNotificationSessionDidChange")]
		[Notification]
		NSString NetworkNotificationSessionDidChange { get; }

		[Field ("MIDINetworkBonjourServiceType")]
		NSString NetworkBonjourServiceType { get; }
	}

	/// <summary>A connection to a MIDI network host, using a <see cref="T:CoreMidi.MidiNetworkSession" />.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreMidi/Reference/MIDINetworkConnection_ClassReference/index.html">Apple documentation for <c>MIDINetworkConnection</c></related>
	[NoTV]
	[NoWatch]
	[MacCatalyst (13, 1)]
	[DisableDefaultCtor]
	[BaseType (typeof (NSObject), Name = "MIDINetworkConnection")]
	interface MidiNetworkConnection {
		[Export ("host", ArgumentSemantic.Retain)]
		MidiNetworkHost Host { get; }

		[Static, Export ("connectionWithHost:")]
		MidiNetworkConnection FromHost (MidiNetworkHost host);
	}

	/// <summary>A singleton class that maintains the <see cref="T:CoreMidi.MidiNetworkConnection" />s between various MIDI entities.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreMidi/Reference/MIDINetworkSession_ClassReference/index.html">Apple documentation for <c>MIDINetworkSession</c></related>
	[NoTV]
	[NoWatch]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject), Name = "MIDINetworkSession")]
	// default 'init' crash the application
	[DisableDefaultCtor]
	interface MidiNetworkSession {
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		[Export ("networkPort")]
		nint NetworkPort { get; }

		[Export ("networkName")]
		string NetworkName { get; }

		[Export ("localName")]
		string LocalName { get; }

		[Export ("connectionPolicy")]
		MidiNetworkConnectionPolicy ConnectionPolicy { get; set; }

		[Static]
		[Export ("defaultSession")]
		MidiNetworkSession DefaultSession { get; }

		[Export ("contacts")]
		NSSet Contacts { get; }

		[Export ("addContact:")]
		bool AddContact (MidiNetworkHost contact);

		[Export ("removeContact:")]
		bool RemoveContact (MidiNetworkHost contact);

		[Export ("connections")]
		NSSet Connections { get; }

		[Export ("addConnection:")]
		bool AddConnection (MidiNetworkConnection connection);

		[Export ("removeConnection:")]
		bool RemoveConnection (MidiNetworkConnection connection);

		[Export ("sourceEndpoint")]
		[Internal]
		int /* MIDIObjectRef = UInt32 */ _SourceEndpoint { get; }

#if NET
		[Wrap ("new MidiEndpoint (_SourceEndpoint)")]
		MidiEndpoint GetSourceEndpoint ();
#else
		[Wrap ("new MidiEndpoint (_SourceEndpoint)")]
		MidiEndpoint SourceEndpoint { get; }
#endif

		[Export ("destinationEndpoint")]
		[Internal]
		int /* MIDIObjectRef = UInt32 */ _DestinationEndpoint { get; }

#if NET
		[Wrap ("new MidiEndpoint (_DestinationEndpoint)")]
		MidiEndpoint GetDestinationEndPoint ();
#else
		[Wrap ("new MidiEndpoint (_DestinationEndpoint)")]
		MidiEndpoint DestinationEndPoint { get; }
#endif

	}

	[NoWatch, NoTV, iOS (12, 0)]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject), Name = "MIDICIProfile")]
	[DisableDefaultCtor]
	interface MidiCIProfile : NSSecureCoding {
		[Export ("name")]
		string Name { get; }

		[Export ("profileID")]
		NSData ProfileId { get; }

		[Export ("initWithData:name:")]
		NativeHandle Constructor (NSData data, string inName);

		[Mac (11, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("initWithData:")]
		NativeHandle Constructor (NSData data);

		/* Notifications */
		[NoWatch, NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("MIDICIProfileStateChangedNotification")]
		[Notification]
		NSString StateChangedNotification { get; }

		[NoWatch, NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("MIDICIProfileWasRemovedNotification")]
		[Notification]
		NSString WasRemovedNotification { get; }
	}

	[NoWatch, NoTV, iOS (12, 0)]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject), Name = "MIDICIProfileState")]
	[DisableDefaultCtor]
	interface MidiCIProfileState : NSSecureCoding {
		[Export ("enabledProfiles")]
		MidiCIProfile [] EnabledProfiles { get; }

		[Export ("disabledProfiles")]
		MidiCIProfile [] DisabledProfiles { get; }

		[Deprecated (PlatformName.iOS, 14, 0, message: "Use the '(byte midiChannel, MidiCIProfile[] enabled, MidiCIProfile[] disabled)' constructor instead.")]
		[Deprecated (PlatformName.MacOSX, 11, 0, message: "Use the '(byte midiChannel, MidiCIProfile[] enabled, MidiCIProfile[] disabled)' constructor instead.")]
		[Deprecated (PlatformName.MacCatalyst, 14, 0, message: "Use the '(byte midiChannel, MidiCIProfile[] enabled, MidiCIProfile[] disabled)' constructor instead.")]
		[Export ("initWithEnabledProfiles:disabledProfiles:")]
		NativeHandle Constructor (MidiCIProfile [] enabled, MidiCIProfile [] disabled);

		[Mac (11, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("initWithChannel:enabledProfiles:disabledProfiles:")]
		NativeHandle Constructor (byte midiChannelNumber, MidiCIProfile [] enabled, MidiCIProfile [] disabled);

		[Mac (11, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("midiChannel")]
		byte MidiChannel { get; }
	}

	delegate void MidiCIProfileChangedHandler (MidiCISession session, byte channel, MidiCIProfile profile, bool enabled);
	delegate void MidiCIProfileSpecificDataHandler (MidiCISession session, byte channel, MidiCIProfile profile, NSData data);
	delegate void MidiCISessionDisconnectHandler (MidiCISession session, NSError error);

	[NoWatch, NoTV, iOS (12, 0)]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject), Name = "MIDICISession")]
	[DisableDefaultCtor]
	interface MidiCISession {
		[Export ("entity")]
		uint Entity { get; }

		[Export ("supportsProfileCapability")]
		bool SupportsProfileCapability { get; }

		[Export ("supportsPropertyCapability")]
		bool SupportsPropertyCapability { get; }

#if XAMCORE_5_0
		[Export ("deviceIdentification")]
		MidiCIDeviceIdentification DeviceIdentification { get; }
#else
		[Internal]
		[Export ("deviceIdentification")]
		MidiCIDeviceIdentification_Blittable _DeviceIdentification { get; }

		[Wrap ("_DeviceIdentification.ToMidiCIDeviceIdentification ()", IsVirtual = true)]
		MidiCIDeviceIdentification DeviceIdentification { get; }
#endif

		[Export ("profileStateForChannel:")]
		MidiCIProfileState GetProfileState (byte channel);

		[Export ("enableProfile:onChannel:error:")]
		bool EnableProfile (MidiCIProfile profile, byte channel, [NullAllowed] out NSError outError);

		[Export ("disableProfile:onChannel:error:")]
		bool DisableProfile (MidiCIProfile profile, byte channel, [NullAllowed] out NSError outError);

		[NullAllowed, Export ("profileChangedCallback", ArgumentSemantic.Assign)]
		MidiCIProfileChangedHandler ProfileChangedCallback { get; set; }

		[Mac (11, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("initWithDiscoveredNode:dataReadyHandler:disconnectHandler:")]
		NativeHandle Constructor (MidiCIDiscoveredNode discoveredNode, Action dataReadyHandler, MidiCISessionDisconnectHandler disconnectHandler);

		[Mac (11, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("sendProfile:onChannel:profileData:")]
		bool SendProfile (MidiCIProfile profile, byte channel, NSData profileSpecificData);

		[Mac (11, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("deviceInfo")]
		MidiCIDeviceInfo DeviceInfo { get; }

		[Mac (11, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[BindAs (typeof (ulong))]
		[Export ("maxSysExSize")]
		NSNumber MaxSysExSize { get; }

		[Mac (11, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[BindAs (typeof (int))]
		[Export ("maxPropertyRequests")]
		NSNumber MaxPropertyRequests { get; }

		[Internal]
		[Mac (11, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("midiDestination")]
		MidiObjectRef _MidiDestination { get; }

		[Mac (11, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[NullAllowed, Export ("profileSpecificDataHandler", ArgumentSemantic.Copy)]
		MidiCIProfileSpecificDataHandler ProfileSpecificDataHandler { get; set; }
	}

	[Mac (11, 0), iOS (14, 0), NoTV, NoWatch]
	[MacCatalyst (14, 0)]
	[BaseType (typeof (NSObject), Name = "MIDICIDeviceInfo")]
	[DisableDefaultCtor]
	interface MidiCIDeviceInfo : NSSecureCoding {
		[Export ("manufacturerID")]
		NSData ManufacturerId { get; }

		[Export ("family")]
		NSData Family { get; }

		[Export ("modelNumber")]
		NSData ModelNumber { get; }

		[Export ("revisionLevel")]
		NSData RevisionLevel { get; }

		[Internal]
		[Export ("midiDestination")]
		MidiObjectRef _MidiDestination { get; }

		[Wrap ("new MidiEndpoint (_MidiDestination)")]
		MidiEndpoint GetMidiDestination ();

		[Internal]
		[Export ("initWithDestination:manufacturer:family:model:revision:")]
		NativeHandle Constructor (MidiObjectRef midiDestination, NSData manufacturer, NSData family, NSData modelNumber, NSData revisionLevel);

		[Wrap ("this (midiDestination?.Handle ?? throw new ArgumentNullException (nameof (midiDestination)), manufacturer, family, modelNumber, revisionLevel)")]
		NativeHandle Constructor (MidiEndpoint midiDestination, NSData manufacturer, NSData family, NSData modelNumber, NSData revisionLevel);
	}

	[Mac (11, 0), iOS (14, 0), NoTV, NoWatch]
	[MacCatalyst (14, 0)]
	[BaseType (typeof (NSObject), Name = "MIDICIDiscoveredNode")]
	[DisableDefaultCtor]
	interface MidiCIDiscoveredNode : NSSecureCoding {
		[Internal]
		[Export ("destination")]
		MidiObjectRef _Destination { get; }

		[Wrap ("new MidiEndpoint (_Destination)")]
		MidiEndpoint GetDestination ();

		[Export ("deviceInfo")]
		MidiCIDeviceInfo DeviceInfo { get; }

		[Export ("supportsProfiles")]
		bool SupportsProfiles { get; }

		[Export ("supportsProperties")]
		bool SupportsProperties { get; }

		[Export ("maximumSysExSize")]
		[BindAs (typeof (ulong))]
		NSNumber MaximumSysExSize { get; }
	}

	delegate void MidiCIDiscoveryResponseDelegate (MidiCIDiscoveredNode [] discoveredNodes);

	[Mac (11, 0), iOS (14, 0), NoTV, NoWatch]
	[MacCatalyst (14, 0)]
	[DisableDefaultCtor]
	[BaseType (typeof (NSObject), Name = "MIDICIDiscoveryManager")]
	interface MidiCIDiscoveryManager {
		[Static]
		[Export ("sharedInstance")]
		MidiCIDiscoveryManager SharedInstance { get; }

		[Export ("discoverWithHandler:")]
		void Discover (MidiCIDiscoveryResponseDelegate completedHandler);
	}

	interface IMidiCIProfileResponderDelegate { }

	[Mac (11, 0), iOS (14, 0), NoTV, NoWatch]
	[MacCatalyst (14, 0)]
#if NET
	[Protocol, Model]
#else
	[Protocol, Model (AutoGeneratedName = true)]
#endif
	[BaseType (typeof (NSObject), Name = "MIDICIProfileResponderDelegate")]
	interface MidiCIProfileResponderDelegate {
		[Abstract]
		[Export ("connectInitiator:withDeviceInfo:")]
		bool ConnectInitiator (NSNumber initiatorMuid, MidiCIDeviceInfo deviceInfo);

		[Abstract]
		[Export ("initiatorDisconnected:")]
		void InitiatorDisconnected (NSNumber initiatorMuid);

		[Export ("willSetProfile:onChannel:enabled:")]
		bool WillSetProfile (MidiCIProfile profile, byte channel, bool shouldEnable);

		[Export ("handleDataForProfile:onChannel:data:")]
		void HandleData (MidiCIProfile profile, byte channel, NSData inData);
	}

	[Mac (11, 0), iOS (14, 0), NoTV, NoWatch]
	[MacCatalyst (14, 0)]
	[BaseType (typeof (NSObject), Name = "MIDICIResponder")]
	[DisableDefaultCtor]
	interface MidiCIResponder {
		[BindAs (typeof (int []))]
		[Export ("initiators")]
		NSNumber [] Initiators { get; }

		[Wrap ("WeakProfileDelegate")]
		IMidiCIProfileResponderDelegate ProfileDelegate { get; }

		[Export ("profileDelegate", ArgumentSemantic.Retain)]
		NSObject WeakProfileDelegate { get; }

		[Export ("deviceInfo")]
		MidiCIDeviceInfo DeviceInfo { get; }

		[Export ("initWithDeviceInfo:profileDelegate:profileStates:supportProperties:")]
		NativeHandle Constructor (MidiCIDeviceInfo deviceInfo, IMidiCIProfileResponderDelegate @delegate, MidiCIProfileState [] profileList, bool propertiesSupported);

		[Export ("notifyProfile:onChannel:isEnabled:")]
		bool NotifyProfile (MidiCIProfile profile, byte channel, bool enabledState);

		[Export ("sendProfile:onChannel:profileData:")]
		bool SendProfile (MidiCIProfile profile, byte channel, NSData profileSpecificData);

		[Export ("start")]
		bool Start ();

		[Export ("stop")]
		void Stop ();
	}

	[NoWatch, NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[BaseType (typeof (NSObject), Name = "MIDICIDevice")]
	[DisableDefaultCtor]
	interface MidiCIDevice {
		[Export ("deviceInfo")]
		Midi2DeviceInfo deviceInfo { get; }

		[Export ("MUID")]
		/* MIDICIMUID -> MIDIUInteger28 -> UInt32 */
		uint Muid { get; }

		[Export ("supportsProtocolNegotiation")]
		bool SupportsProtocolNegotiation { get; }

		[Export ("supportsProfileConfiguration")]
		bool SupportsProfileConfiguration { get; }

		[Export ("supportsPropertyExchange")]
		bool SupportsPropertyExchange { get; }

		[Export ("supportsProcessInquiry")]
		bool SupportsProcessInquiry { get; }

		[Export ("maxSysExSize")]
		nuint MaxSysExSize { get; }

		[Export ("maxPropertyExchangeRequests")]
		nuint MaxPropertyExchangeRequests { get; }

		[Export ("deviceType")]
		MidiCIDeviceType deviceType { get; }

		[Export ("profiles")]
		MidiUmpCIProfile [] profiles { get; }

		/* Notifications */
		[Field ("MIDICIDeviceWasAddedNotification")]
		[Notification]
		NSString WasAddedNotification { get; }

		[Field ("MIDICIDeviceWasRemovedNotification")]
		[Notification]
		NSString WasRemovedNotification { get; }

	}

	[NoWatch, NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[BaseType (typeof (NSObject), Name = "MIDICIDeviceManager")]
	[DisableDefaultCtor]
	interface MidiCIDeviceManager {
		[Static]
		[Export ("sharedInstance")]
		MidiCIDeviceManager SharedInstance { get; }

		[Export ("discoveredCIDevices", ArgumentSemantic.Copy)]
		MidiCIDevice [] DiscoveredCIDevices { get; }

	}

	[Internal]
	enum MidiProperty {
		[Field ("kMIDIPropertyName")]
		Name,
		[Field ("kMIDIPropertyManufacturer")]
		Manufacturer,
		[Field ("kMIDIPropertyModel")]
		Model,
		[Field ("kMIDIPropertyUniqueID")]
		UniqueId,
		[Field ("kMIDIPropertyDeviceID")]
		DeviceId,
		[Field ("kMIDIPropertyReceiveChannels")]
		ReceiveChannels,
		[Field ("kMIDIPropertyTransmitChannels")]
		TransmitChannels,
		[Field ("kMIDIPropertyMaxSysExSpeed")]
		MaxSysExSpeed,
		[Field ("kMIDIPropertyAdvanceScheduleTimeMuSec")]
		AdvanceScheduleTimeMuSec,
		[Field ("kMIDIPropertyIsEmbeddedEntity")]
		IsEmbeddedEntity,
		[Field ("kMIDIPropertyIsBroadcast")]
		IsBroadcast,
		[Field ("kMIDIPropertySingleRealtimeEntity")]
		SingleRealtimeEntity,
		[Field ("kMIDIPropertyConnectionUniqueID")]
		ConnectionUniqueId,
		[Field ("kMIDIPropertyOffline")]
		Offline,
		[Field ("kMIDIPropertyPrivate")]
		Private,
		[Field ("kMIDIPropertyDriverOwner")]
		DriverOwner,
		[Field ("kMIDIPropertyFactoryPatchNameFile")]
		FactoryPatchNameFile,
		[Field ("kMIDIPropertyUserPatchNameFile")]
		UserPatchNameFile,
		[Field ("kMIDIPropertyNameConfiguration")]
		NameConfiguration,
		[Field ("kMIDIPropertyNameConfigurationDictionary")]
		NameConfigurationDictionary,
		[Field ("kMIDIPropertyImage")]
		Image,
		[Field ("kMIDIPropertyDriverVersion")]
		DriverVersion,
		[Field ("kMIDIPropertySupportsGeneralMIDI")]
		SupportsGeneralMidi,
		[Field ("kMIDIPropertySupportsMMC")]
		SupportsMmc,
		[Field ("kMIDIPropertyCanRoute")]
		CanRoute,
		[Field ("kMIDIPropertyReceivesClock")]
		ReceivesClock,
		[Field ("kMIDIPropertyReceivesMTC")]
		ReceivesMtc,
		[Field ("kMIDIPropertyReceivesNotes")]
		ReceivesNotes,
		[Field ("kMIDIPropertyReceivesProgramChanges")]
		ReceivesProgramChanges,
		[Field ("kMIDIPropertyReceivesBankSelectMSB")]
		ReceivesBankSelectMsb,
		[Field ("kMIDIPropertyReceivesBankSelectLSB")]
		ReceivesBankSelectLsb,
		[Field ("kMIDIPropertyTransmitsClock")]
		TransmitsClock,
		[Field ("kMIDIPropertyTransmitsMTC")]
		TransmitsMtc,
		[Field ("kMIDIPropertyTransmitsNotes")]
		TransmitsNotes,
		[Field ("kMIDIPropertyTransmitsProgramChanges")]
		TransmitsProgramChanges,
		[Field ("kMIDIPropertyTransmitsBankSelectMSB")]
		TransmitsBankSelectMsb,
		[Field ("kMIDIPropertyTransmitsBankSelectLSB")]
		TransmitsBankSelectLsb,
		[Field ("kMIDIPropertyPanDisruptsStereo")]
		PanDisruptsStereo,
		[Field ("kMIDIPropertyIsSampler")]
		IsSampler,
		[Field ("kMIDIPropertyIsDrumMachine")]
		IsDrumMachine,
		[Field ("kMIDIPropertyIsMixer")]
		IsMixer,
		[Field ("kMIDIPropertyIsEffectUnit")]
		IsEffectUnit,
		[Field ("kMIDIPropertyMaxReceiveChannels")]
		MaxReceiveChannels,
		[Field ("kMIDIPropertyMaxTransmitChannels")]
		MaxTransmitChannels,
		[Field ("kMIDIPropertyDriverDeviceEditorApp")]
		DriverDeviceEditorApp,
		[Field ("kMIDIPropertySupportsShowControl")]
		SupportsShowControl,
		[Field ("kMIDIPropertyDisplayName")]
		DisplayName,
		[Field ("kMIDIPropertyProtocolID")]
		ProtocolId,
		[Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0), NoTV, NoWatch]
		[Field ("kMIDIPropertyUMPActiveGroupBitmap")]
		UmpActiveGroupBitmap,
		[Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0), NoTV, NoWatch]
		[Field ("kMIDIPropertyUMPCanTransmitGroupless")]
		UmpCanTransmitGroupless,
		[Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0), NoTV, NoWatch]
		[Field ("kMIDIPropertyAssociatedEndpoint")]
		AssociatedEndpoint,
	}

	[NoWatch, NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[BaseType (typeof (NSObject), Name = "MIDIUMPCIProfile")]
	[DisableDefaultCtor]
	interface MidiUmpCIProfile {
		[Export ("name")]
		string Name { get; }

		[Export ("profileID")]
		MidiCIProfileId ProfileId { get; }

		[Export ("profileType")]
		MidiCIProfileType ProfileType { get; }

		[Export ("groupOffset")]
		MidiUmpGroupNumber GroupOffset { get; }

		[Export ("firstChannel")]
		MidiChannelNumber FirstChannel { get; }

		[Export ("enabledChannelCount")]
		ushort /* MIDIUInteger14 */ EnabledChannelCount { get; }

		[Export ("totalChannelCount")]
		ushort /* MIDIUInteger14 */ TotalChannelCount { get; }

		[Export ("isEnabled")]
		bool isEnabled { get; }

		[Export ("setProfileState:enabledChannelCount:error:")]
		bool SetProfileState (bool isEnabled, ushort enabledChannelCount, out NSError error);
	}

	[NoWatch, NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[BaseType (typeof (NSObject), Name = "MIDI2DeviceInfo")]
	[DisableDefaultCtor]
	interface Midi2DeviceInfo {
		[Export ("manufacturerID")]
		Midi2DeviceManufacturer ManufacturerId { get; }

		[Export ("family")]
		ushort /* MIDIUInteger14 */ Family { get; }

		[Export ("modelNumber")]
		ushort /* MIDIUInteger14 */ ModelNumber { get; }

		[Export ("revisionLevel")]
		Midi2DeviceRevisionLevel RevisionLevel { get; }

		[Export ("initWithManufacturerID:family:modelNumber:revisionLevel:")]
		NativeHandle Constructor (Midi2DeviceManufacturer manufacturerId, ushort family, ushort modelNumber, Midi2DeviceRevisionLevel revisionLevel);
	}

	[Flags]
	[NoWatch, NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[NativeName ("MIDIUMPProtocolOptions")]
	public enum MidiUmpProtocolOptions : byte /* MIDIUInteger4 */ {
		SupportedProtocolMidi1 = 1,
		SupportedProtocolMidi2 = 1 << 1,
	}

	[NoWatch, NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[BaseType (typeof (NSObject), Name = "MIDIUMPEndpoint")]
	[DisableDefaultCtor]
	interface MidiUmpEndpoint {
		[Export ("name")]
		string Name { get; }

		[Export ("MIDIProtocol")]
		MidiProtocolId MidiProtocol { get; }

		[Export ("supportedMIDIProtocols")]
		MidiUmpProtocolOptions SupportedMidiProtocols { get; }

		[Export ("MIDIDestination")]
		MidiEndpointRef MidiDestination { get; }

		[Export ("MIDISource")]
		MidiEndpointRef MidiSource { get; }

		[Export ("deviceInfo")]
		Midi2DeviceInfo DeviceInfo { get; }

		[Export ("productInstanceID")]
		string ProductInstanceId { get; }

		[Export ("hasStaticFunctionBlocks")]
		bool HasStaticFunctionBlocks { get; }

		[Export ("hasJRTSReceiveCapability")]
		bool HasJrtsReceiveCapability { get; }

		[Export ("hasJRTSTransmitCapability")]
		bool HasJrtsTransmitCapability { get; }

		[Export ("endpointType")]
		MidiUmpCIObjectBackingType EndpointType { get; }

		[Export ("functionBlocks", ArgumentSemantic.Copy)]
		MidiUmpFunctionBlock [] FunctionBlocks { get; set; }

		/* Notifications */
		[Notification]
		[Field ("MIDIUMPEndpointWasAddedNotification")]
		NSString WasAddedNotification { get; }

		[Notification]
		[Field ("MIDIUMPEndpointWasRemovedNotification")]
		NSString WasRemovedNotification { get; }

		[Notification]
		[Field ("MIDIUMPEndpointWasUpdatedNotification")]
		NSString WasUpdatedNotification { get; }
	}

	[NoWatch, NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[BaseType (typeof (NSObject), Name = "MIDIUMPFunctionBlock")]
	[DisableDefaultCtor]
	interface MidiUmpFunctionBlock {
		[Export ("name")]
		string Name { get; }

		[Export ("functionBlockID")]
		MidiUmpFunctionBlockId FunctionBlockId { get; }

		[Export ("direction")]
		MidiUmpFunctionBlockDirection Direction { get; }

		[Export ("firstGroup")]
		MidiUmpGroupNumber FirstGroup { get; }

		[Export ("totalGroupsSpanned")]
		byte /* MIDIUInteger7 */ TotalGroupsSpanned { get; }

		[Export ("maxSysEx8Streams")]
		byte MaxSysEx8Streams { get; }

		[Export ("MIDI1Info")]
		MidiUmpFunctionBlockMidi1Info Midi1Info { get; }

		[Export ("UIHint")]
		MidiUmpFunctionBlockUIHint UIHint { get; }

		[Export ("UMPEndpoint", ArgumentSemantic.Weak), NullAllowed]
		MidiUmpEndpoint UmpEndpoint { get; }

		[Export ("midiCIDevice", ArgumentSemantic.Weak), NullAllowed]
		MidiCIDevice MidiCIDevice { get; }

		[Export ("isEnabled")]
		bool IsEnabled { get; }

		/* Notifications */
		[Notification]
		[Field ("MIDIUMPFunctionBlockWasUpdatedNotification")]
		NSString WasUpdatedNotification { get; }
	}

	[NoWatch, NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[Static]
	interface MidiCIDeviceManagerDictionaryKey {
		[Field ("MIDICIDeviceObjectKey")]
		NSString CIDeviceObject { get; }

		[Field ("MIDICIDeviceManagerDictionaryKey")]
		NSString CIDeviceManagerDictionary { get; }
	}

	[NoWatch, NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[Static]
	interface MidiUmpEndpointManagerDictionaryKey {
		[Field ("MIDIUMPEndpointObjectKey")]
		NSString UmpEndpointObject { get; }

		[Field ("MIDIUMPFunctionBlockObjectKey")]
		NSString UmpFunctionBlockObject { get; }
	}

	[NoWatch, NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[BaseType (typeof (NSObject), Name = "MIDIUMPEndpointManager")]
	[DisableDefaultCtor]
	interface MidiUmpEndpointManager {
		[Static]
		[Export ("sharedInstance")]
		MidiUmpEndpointManager SharedInstance { get; }

		[Export ("UMPEndpoints", ArgumentSemantic.Copy)]
		MidiUmpEndpoint [] UmpEndpoints { get; }
	}

	delegate void MidiReceiveBlock (IntPtr eventList, IntPtr srcConnRefCon);

	[NoWatch, NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[BaseType (typeof (NSObject), Name = "MIDIUMPMutableEndpoint")]
	[DisableDefaultCtor]
	interface MidiUmpMutableEndpoint {
		[Export ("mutableFunctionBlocks", ArgumentSemantic.Copy)]
		MidiUmpMutableFunctionBlock[] MutableFunctionBlocks { get; set; }

		[Export ("isEnabled")]
		bool IsEnabled { get; }

		[Export ("initWithName:deviceInfo:productInstanceID:MIDIProtocol:destinationCallback:")]
		NativeHandle Constructor (string name, Midi2DeviceInfo deviceInfo, string productInstanceId, MidiProtocolId midiProtocol, MidiReceiveBlock destinationCallback);

		[Export ("setName:error:")]
		bool SetName (string name, out NSError error);

		[Export ("registerFunctionBlocks:markAsStatic:error:")]
		bool RegisterFunctionBlocks (MidiUmpMutableFunctionBlock [] functionBlocks, bool markAsStatic, out NSError error);

		[Export ("setEnabled:error:")]
		bool SetEnabled (bool isEnabled, out NSError error);
	}

	[NoWatch, NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[BaseType (typeof (MidiUmpFunctionBlock), Name = "MIDIUMPMutableFunctionBlock")]
	[DisableDefaultCtor]
	interface MidiUmpMutableFunctionBlock {
		[Export ("UMPEndpoint", ArgumentSemantic.Weak), NullAllowed]
		MidiUmpMutableEndpoint UmpEndpoint { get; }

		[Export ("initWithName:direction:firstGroup:totalGroupsSpanned:maxSysEx8Streams:MIDI1Info:UIHint:isEnabled:")]
		NativeHandle Constructor (string name, MidiUmpFunctionBlockDirection direction, MidiUmpGroupNumber firstGroup, byte /* MIDIUInteger7 */ totalGroupsSpanned, byte /* MIDIUInteger7 */ maxSysEx8Streams, MidiUmpFunctionBlockMidi1Info midi1Info, MidiUmpFunctionBlockUIHint uiHint, bool isEnabled);

		[Export ("setEnabled:error:")]
		bool SetEnabled (bool isEnabled, out NSError error);

		[Export ("setName:error:")]
		bool SetName (string name, out NSError error);

		[Export ("reconfigureWithFirstGroup:direction:MIDI1Info:UIHint:error:")]
		bool ReconfigureWithFirstGroup (MidiUmpGroupNumber firstGroup, MidiUmpFunctionBlockDirection direction, MidiUmpFunctionBlockMidi1Info midi1Info, MidiUmpFunctionBlockUIHint uiHint, out NSError error);
	}
}
