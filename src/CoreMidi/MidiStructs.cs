#if !TVOS
#nullable enable

using System;
using System.Runtime.InteropServices;

using ObjCRuntime;
using CoreFoundation;
using Foundation;

using MidiObjectRef = System.Int32;
using MidiClientRef = System.Int32;
using MidiDeviceRef = System.Int32;
using MidiDeviceListRef = System.Int32;
using MidiPortRef = System.Int32;
using MidiEndpointRef = System.Int32;
using MidiEntityRef = System.Int32;

namespace CoreMidi {
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("tvos18.0")]
	[NativeName ("MIDI2DeviceManufacturer")]
	public struct Midi2DeviceManufacturer {
		// Byte sysExIDByte[3]; // 1-byte SysEx IDs are padded with trailing zeroes
		byte sysExIdByte0;
		byte sysExIdByte1;
		byte sysExIdByte2;

		public byte [] SysExIdByte {
			get {
				return new byte [] { sysExIdByte0, sysExIdByte1, sysExIdByte2 };
			}
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				if (value.Length != 3)
					ObjCRuntime.ThrowHelper.ThrowArgumentOutOfRangeException (nameof (value), "Length must be 3");

				sysExIdByte0 = value [0];
				sysExIdByte1 = value [1];
				sysExIdByte2 = value [2];
			}
		}
	}

	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("tvos18.0")]
	[NativeName ("MIDI2DeviceRevisionLevel")]
	public struct Midi2DeviceRevisionLevel {
		// Byte revisionLevel[4];
		byte revisionLevel0;
		byte revisionLevel1;
		byte revisionLevel2;
		byte revisionLevel3;

		public byte [] RevisionLevel {
			get {
				return new byte [] { revisionLevel0, revisionLevel1, revisionLevel2, revisionLevel3 };
			}
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				if (value.Length != 4)
					ObjCRuntime.ThrowHelper.ThrowArgumentOutOfRangeException (nameof (value), "Length must be 4");

				revisionLevel0 = value [0];
				revisionLevel1 = value [1];
				revisionLevel2 = value [2];
				revisionLevel3 = value [3];
			}
		}
	}

	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("tvos18.0")]
	[NativeName ("MIDICIProfileIDStandard")]
	public struct MidiCIProfileIdStandard {
		public byte /* MIDIUInteger7 */ ProfileIdByte1;
		public byte /* MIDIUInteger7 */ ProfileBank;
		public byte /* MIDIUInteger7 */ ProfileNumber;
		public byte /* MIDIUInteger7 */ ProfileVersion;
		public byte /* MIDIUInteger7 */ ProfileLevel;
	}

	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("tvos18.0")]
	[NativeName ("MIDICIProfileIDManufacturerSpecific")]
	public struct MidiCIProfileIdManufacturerSpecific {
		public byte /* MIDIUInteger7 */ SysExId1;
		public byte /* MIDIUInteger7 */ SysExId2;
		public byte /* MIDIUInteger7 */ SysExId3;
		public byte /* MIDIUInteger7 */ Info1;
		public byte /* MIDIUInteger7 */ Info2;
	}

	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("tvos18.0")]
	[NativeName ("MIDICIProfileID")]
	public struct MidiCIProfileId {
		// This is a union between MidiCIProfileIdStandard and MidiCIProfileIdManufacturerSpecific, each with the same size (5 bytes)
		// So declare a struct with 5 bytes, and then do some memory copies to convert to each element of the union.
		byte /* MIDIUInteger7 */ Value0;
		byte /* MIDIUInteger7 */ Value1;
		byte /* MIDIUInteger7 */ Value2;
		byte /* MIDIUInteger7 */ Value3;
		byte /* MIDIUInteger7 */ Value4;

		public unsafe MidiCIProfileIdStandard Standard {
			get {
				fixed (MidiCIProfileId* self = &this) {
					return *(MidiCIProfileIdStandard*) self;
				}
			}
			set {
				fixed (MidiCIProfileId* self = &this) {
					*self = *(MidiCIProfileId*) &value;
				}
			}
		}

		public unsafe MidiCIProfileIdManufacturerSpecific ManufacturerSpecific {
			get {
				fixed (MidiCIProfileId* self = &this) {
					return *(MidiCIProfileIdManufacturerSpecific*) self;
				}
			}
			set {
				fixed (MidiCIProfileId* self = &this) {
					*self = *(MidiCIProfileId*) &value;
				}
			}
		}
	}

	/// <summary>A struct that represents a request to transmit a single system-exclusive event.</summary>s
	[NativeName ("MIDISysexSendRequest")]
	public struct MidiSysexSendRequest
	{
		MidiEndpointRef                                                                  destination;
		IntPtr /* const Byte * */                                                        data;
		uint                                                                             bytesToSend;
		byte /* Boolean */                                                               complete;
		byte                                                                             reserved1;
		byte                                                                             reserved2;
		byte                                                                             reserved3;
		unsafe delegate* unmanaged<MidiSysexSendRequest*, void> /* MIDICompletionProc */ completionProc;
		IntPtr /* void * __nullable */                                                   completionRefCon;

		/// <summary>The endpoint where the request is sent.</summary>
		public MidiEndpointRef Destination {
			get => destination;
			set => destination = value;
		}

		/// <summary>A pointer to the data to send.</summary>
		/// <remarks>The MIDI system will update this value as the request progresses.</remarks>
		public IntPtr Data {
			get => data;
			set => data = value;
		}

		/// <summary>The number of bytes to send.</summary>
		/// <remarks>The MIDI system will update this value as the request progresses.</remarks>
		public uint BytesToSend {
			get => bytesToSend;
			set => bytesToSend = value;
		}

		/// <summary>The client can set true to immediately stop the request. The MIDI system will set it to true when the request is complete.</summary>
		public bool Complete {
			get => complete != 0;
			set => complete = value.AsByte ();
		}

		/// <summary>The callback that is called when all the data has been sent and the request is complete.</summary>
		/// <remarks>Also called if the client sets <see cref="Complete" /> to true before the request is complete.</remarks>
		public unsafe delegate* unmanaged<MidiSysexSendRequest*, void> CompletionProcedure {
			get => completionProc;
			set => completionProc = value;
		}

		/// <summary>A context value that's passed to the <see cref="CompletionProcedure" /> callback.</summary>
		public IntPtr Context {
			get => completionRefCon;
			set => completionRefCon = value;
		}
	};
}
#endif
