using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

using Foundation;
using ObjCRuntime;

using MidiEndpointRef = System.Int32;
using MidiPortRef = System.Int32;

#nullable enable

namespace CoreMidi {
	/// <summary>This class represents the Objective-C struct MIDIEventList, which is a list of <see cref="MidiEventPacket" /> packets.</summary>
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	// [NativeName ("MIDIEventList")]
	public class MidiEventList : IEnumerable<MidiEventPacket> {
		/* This is a variable sized struct, so store all the data in a byte array.
		 * struct MIDIEventList
		 * {
		 *    MIDIProtocolID protocol;
		 *    UInt32 numPackets;
		 *    MIDIEventPacket packet[1];
		 * };
		 */

		// this struct is just used internally to avoid some manual pointer math
		struct MIDIEventList {
#pragma warning disable CS0649 // Field '...' is never assigned to, and will always have its default value
#pragma warning disable CS0169 // The field '...' is never used
			internal MidiProtocolId protocol;
			internal uint numPackets;
			internal MidiEventPacket packet;
#pragma warning restore CS0169
#pragma warning restore CS0649
		}

		byte[] midiData;
		unsafe MidiEventPacket* currentPacket;

		const int MinimumSize = 276; /* 4 + 4 + sizeof (MidiEventPacket) */

		/// <summary>The <see cref="MidiProtocolId" /> protocol for the packets in this list of packets.</summary>
		/// <returns>The <see cref="MidiProtocolId" /> protocol for the packets in this list of packets.</returns>
		public unsafe MidiProtocolId Protocol {
			get {
				fixed (byte* midiDataPtr = midiData)
					return ((MIDIEventList *) midiDataPtr)->protocol;
			}
		}

		/// <summary>The number of packets in this list.</summary>
		/// <returns>The number of packets in this list.</returns>
		public unsafe uint PacketCount {
			get {
				fixed (byte* midiDataPtr = midiData)
					return ((MIDIEventList *) midiDataPtr)->numPackets;
			}
		}

		internal byte[] MidiData { get => midiData; }

		/// <summary>Create a new <see cref="MidiEventList" /> list with the minimum size.</summary>
		/// <param name="protocol">The protocol for the packets in the created list.</param>
		/// <returns>A newly created <see cref="MidiEventList" />, or an exception in case of failure.</returns>
		public MidiEventList (MidiProtocolId protocol)
			: this (protocol, MinimumSize)
		{
		}

		/// <summary>Create a new <see cref="MidiEventList" /> for the specified protocol and size.</summary>
		/// <param name="protocol">The protocol for the event list.</param>
		/// <param name="size">The size, in number of bytes, of the event list. Minimum size is 276 bytes.</param>
		/// <returns>A newly created <see cref="MidiEventList" />, or an exception in case of failure.</returns>
		public MidiEventList (MidiProtocolId protocol, int size)
		{
			if (size < MinimumSize)
				throw new ArgumentOutOfRangeException ($"{nameof (size)} must be at least {MinimumSize}.");

			midiData = new byte [size];
			unsafe {
				fixed (byte* midiDataPtr = midiData)
					currentPacket = MIDIEventListInit (midiDataPtr, protocol);
				if (currentPacket is null)
					throw new Exception ($"Failed to create midi event list.");
			}
		}

#if !__TVOS__
		/// <summary>Send the packets in this list to the specified <paramref name="destination" />.</summary>
		/// <param name="port">The port through which the packets are sent.</param>
		/// <param name="destination">The destination where the packets are sent.</param>
		/// <returns>A non-zero error code in case of failure, otherwise zero (which indicates success).</returns>
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public unsafe int /* OSStatus */ Send (MidiPort port, MidiEndpoint destination)
		{
			fixed (byte* midiDataPtr = midiData)
				return MIDISendEventList (port.Handle, destination.Handle, midiDataPtr);
		}

		/// <summary>Distribute the packets from the specified <paramref name="source" />.</summary>
		/// <param name="source">The endpoint where the packates come from.</param>
		/// <returns>A non-zero error code in case of failure, otherwise zero (which indicates success).</returns>
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public unsafe int /* OSStatus */ Receive (MidiEndpoint source)
		{
			fixed (byte* midiDataPtr = midiData)
				return MIDIReceivedEventList (source.Handle, midiDataPtr);
		}
#endif

		/// <summary>Add a new <see cref="MidiEventPacket" /> to this lis.</summary>
		/// <param name="time">The timestamp for the new packet.</param>
		/// <param name="words">The data for the midi event to add.</param>
		/// <returns>True if successful, otherwise false (which typically means there's not enough space for the new packet).</returns>
		public unsafe bool Add (ulong time, uint [] words)
		{
			fixed (byte* midiDataPtr = midiData) {
				fixed (uint* wordsPtr = words) {
					var rv = MIDIEventListAdd (midiDataPtr, (ulong) midiData.Length, currentPacket, time, (ulong) words.Length, (byte *) wordsPtr);
					if (rv != null) {
						currentPacket = rv;
						return true;
					}
					return false;
				}
			}
		}

		[DllImport (Constants.CoreMidiLibrary)]
		unsafe static extern MidiEventPacket * MIDIEventListInit (byte* /* MIDIEventList * */ evtlist, MidiProtocolId /* MIDIProtocolID */ protocol);

		[DllImport (Constants.CoreMidiLibrary)]
		unsafe static extern MidiEventPacket * MIDIEventListAdd (
			byte* /* MIDIEventList * */ evtlist,
			ulong /* ByteCount = unsigned long */ listSize,
			MidiEventPacket * curPacket,
			ulong /* MIDITimeStamp */ time,
			ulong /* ByteCount = unsigned long */ wordCount,
			byte* /* const UInt32 * */ words);

#if !__TVOS__
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[DllImport (Constants.CoreMidiLibrary)]
		unsafe static extern int /* OSStatus */ MIDISendEventList (MidiPortRef port, MidiEndpointRef dest, byte* /* const MIDIEventList */ evtList);

		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[DllImport (Constants.CoreMidiLibrary)]
		unsafe static extern int /* OSStatus */ MIDIReceivedEventList (MidiEndpointRef src, byte* /* const MIDIEventList * */	evtlist);
#endif // !__TVOS__

		IEnumerator<MidiEventPacket> IEnumerable<MidiEventPacket>.GetEnumerator()
		{
			MidiEventPacket packetToYield;
			IntPtr packetPtr;

			if (PacketCount == 0)
				yield break;

			unsafe {
				fixed (byte* midiDataPtr = midiData) {
					MIDIEventList* list = (MIDIEventList *) midiDataPtr;
					MidiEventPacket* packet = &list->packet;
					packetToYield = *packet;
					packetPtr = (IntPtr) packet;
				}
			}
			yield return packetToYield;

			for (var i = 1; i < PacketCount; i++) {
				unsafe {
					MidiEventPacket* packet = (MidiEventPacket *) packetPtr;
					uint* wordPointer = &packet->word_00;
					packet = (MidiEventPacket *) wordPointer [packet->WordCount];
					packetToYield = *packet;
					packetPtr = (IntPtr) packet;
				}
				yield return packetToYield;
			}
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<MidiEventPacket>) this).GetEnumerator ();
		}

		/// <summary>Iterate over each <see cref="MidiEventPacket" /> in this list without allocating or copying memory.</summary>
		/// <param name="callback">The function to call for each packet.</param>
		public unsafe void Iterate (MidiEventListIterator callback)
		{
			if (PacketCount == 0)
				return;

			fixed (byte* midiDataPtr = midiData) {
				MIDIEventList* list = (MIDIEventList *) midiDataPtr;
				MidiEventPacket* packet = &list->packet;
				callback (ref Unsafe.AsRef<MidiEventPacket> (packet));
				for (var i = 1; i < PacketCount; i++) {
					uint* wordPointer = &packet->word_00;
					packet = (MidiEventPacket *) wordPointer [packet->WordCount];
					callback (ref Unsafe.AsRef<MidiEventPacket> (packet));
				}
			}
		}
	}

	/// <summary>The delegate type used by <see cref="MidiEventList.Iterate" />.</summary>
	/// <param name="packet">The current packet found when iterating.</param>
	public delegate void MidiEventListIterator (ref MidiEventPacket packet);
}
