//
// MusicTrack.cs: Bindings to the AudioToolbox's MusicPlayers APIs
//
// Authors:
//   Miguel de Icaza
//
// Copyright 2012-2014 Xamarin Inc.
//
// MISSING:
//       MusicTrackNewParameterEvent
//       MusicTrackNewAUPresetEvent
//

#nullable enable

#if IOS
using CoreMidi;
#endif

using MidiEndpointRef = System.Int32;

namespace AudioToolbox {

	// MusicPlayer.h
	/// <summary>Encapsulates a MIDI musical note.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct MidiNoteMessage {
		/// <summary>The MIDI channel.</summary>
		public byte Channel;
		/// <summary>The MIDI note number.</summary>
		public byte Note;
		/// <summary>The note velocity.</summary>
		public byte Velocity;
		/// <summary>The release velocity.</summary>
		public byte ReleaseVelocity;
		/// <summary>The note duration in beats.</summary>
		public /* Float32 */ float Duration;

		/// <param name="channel">The channel.</param>
		/// <param name="note">The note.</param>
		/// <param name="velocity">The velocity.</param>
		/// <param name="releaseVelocity">The releaseVelocity.</param>
		/// <param name="duration">The duration.</param>
		/// <summary>Creates a MIDI note message with the specified parameters.</summary>
		public MidiNoteMessage (byte channel, byte note, byte velocity, byte releaseVelocity, float duration)
		{
			Channel = channel;
			Note = note;
			Velocity = velocity;
			ReleaseVelocity = releaseVelocity;
			Duration = duration;
		}
	}

	// MusicPlayer.h
	/// <summary>A struct describing a MIDI channel message. Used by the <see cref="AudioToolbox.MusicTrack.AddMidiChannelEvent(System.Double,AudioToolbox.MidiChannelMessage)" /> method.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct MidiChannelMessage {
		/// <summary>The MIDI status byte.</summary>
		public byte Status;
		/// <summary>The first data byte.</summary>
		public byte Data1;
		/// <summary>The second data byte.</summary>
		public byte Data2;
		/// <summary>Reserved for future use.</summary>
		public byte Reserved;

		/// <param name="status">The status.</param>
		/// <param name="data1">The data1.</param>
		/// <param name="data2">The data2.</param>
		/// <summary>Creates a MIDI channel message with the specified parameters.</summary>
		public MidiChannelMessage (byte status, byte data1, byte data2)
		{
			Status = status;
			Data1 = data1;
			Data2 = data2;
			Reserved = 0;
		}
	}

	//
	// Since we can not express this in the way that C does, we expose a
	// high level API, and we provide a ToUnmanaged that returns an allocated
	// IntPtr buffer with the data
	//
	/// <summary>An abstract base class for <see cref="AudioToolbox.MidiMetaEvent" /> and <see cref="AudioToolbox.MidiRawData" />.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public abstract class MidiData {
		protected int len;
		protected int start;
		protected byte []? data;
		protected IntPtr buffer;

		public void SetData (byte [] Data)
		{
			len = Data.Length;
			start = 0;
			data = Data;
			buffer = IntPtr.Zero;
		}

		public void SetData (int len, int start, byte [] Data)
		{
			if (len + start > Data.Length)
				throw new ArgumentException ("len+start go beyond the end of Data");
			if (len < 0 || start < 0)
				throw new ArgumentException ("len||start are negative");
			this.len = len;
			this.start = start;
			this.data = Data;
			buffer = IntPtr.Zero;
		}

		public void SetData (int len, IntPtr buffer)
		{
			this.len = len;
			this.buffer = buffer;
			this.data = null;
		}

		//
		// Converts our high-level representations to a buffer that
		// we can pass to unmanaged functions that take a MidiRawData
		//
		internal abstract IntPtr ToUnmanaged ();
	}

#if !COREBUILD
	/// <summary>Encapsulates a MIDI System-Exclusive (SysEx) message.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class MidiRawData : MidiData {
		/// <summary>Creates a new empty MIDI raw data instance.</summary>
		public MidiRawData () { }

		internal override IntPtr ToUnmanaged ()
		{
			unsafe {
				// Length (UInt32) + length (UInt8 for each)
				var target = (byte*) Marshal.AllocHGlobal (4 + len);
				*((int*) target) = len;
				var rdata = target + 4;

				if (data is not null)
					Marshal.Copy (data, start, (IntPtr) rdata, len);
				else
					Buffer.MemoryCopy ((void*) buffer, (void*) rdata, len, len);
				return (IntPtr) target;
			}
		}
	}

	/// <summary>A subclass of <see cref="AudioToolbox.MidiRawData" /> that describes a user-defined event.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class MusicEventUserData : MidiRawData {
		/// <summary>Creates a new empty user data event.</summary>
		public MusicEventUserData () { }

		internal MusicEventUserData (IntPtr handle)
		{
			if (handle == IntPtr.Zero)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handle));

			int length = Marshal.ReadInt32 (handle);

			var buffer = new byte [length];
			Marshal.Copy (handle + 4, buffer, 0, length);

			len = length;
			data = buffer;
		}
	}

	//
	// Since we can not express this in the way that C does, we expose a
	// high level API, and we provide a ToUnmanaged that returns an allocated
	// IntPtr buffer with the data
	//
	/// <summary>Encapsulates a MIDI meta-event such as a time signature, lyrics, etc.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class MidiMetaEvent : MidiData {
		/// <summary>The meta event type.</summary>
		public byte MetaEventType;

		internal override IntPtr ToUnmanaged ()
		{
			unsafe {
				// MetaEventType (UInt8) + 3 x unused (UInt8) + length (UInt32) + length (UInt8 for each)
				var target = (byte*) Marshal.AllocHGlobal (8 + len);
				*target = MetaEventType;
				var plen = (int*) (target + 4);
				*plen = len;
				var rdata = target + 8;

				if (data is not null)
					Marshal.Copy (data, start, (IntPtr) rdata, len);
				else
					Buffer.MemoryCopy ((void*) buffer, (void*) rdata, len, len);
				return (IntPtr) target;
			}
		}
	}

	// MusicPlayer.h
	/// <summary>A struct that describes a note-on event with extended parameters.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct ExtendedNoteOnEvent {
		/// <summary>The instrument identifier.</summary>
		public /* MusicDeviceInstrumentID */ uint InstrumentID;
		/// <summary>The device group identifier.</summary>
		public /* MusicDeviceGroupID */ uint DeviceGroupID;
		/// <summary>The note duration.</summary>
		public /* Float32 */ float Duration;

		// MusicDeviceNoteParams extendedParams

		// Documented as having to be 2
#pragma warning disable 169
		int argCount;
#pragma warning restore 169
		/// <summary>The pitch value.</summary>
		public float Pitch;
		/// <summary>The velocity value.</summary>
		public float Velocity;
	}
#endif

	/// <summary>A music track is a series of time-stamped music events and is a component of a <see cref="AudioToolbox.MusicSequence" />.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class MusicTrack : DisposableObject {
#if !COREBUILD
		MusicSequence? sequence;

		internal MusicTrack (MusicSequence sequence, IntPtr handle, bool owns)
			: base (handle, owns)
		{
			this.sequence = sequence;
		}

		/// <inheritdoc />
		protected override void Dispose (bool disposing)
		{
			if (Handle != IntPtr.Zero && Owns) {
				if (sequence is not null)
					MusicSequenceDisposeTrack (sequence.Handle, Handle);
			}
			sequence = null;
			base.Dispose (disposing);
		}

		[DllImport (Constants.AudioToolboxLibrary)]
		extern static /* OSStatus */ MusicPlayerStatus MusicSequenceDisposeTrack (/* MusicSequence */ IntPtr inSequence, /* MusicTrack */ IntPtr inTrack);

		/// <param name="sequence">The music sequence.</param>
		/// <summary>Creates a music track from the specified sequence.</summary>
		public static MusicTrack? FromSequence (MusicSequence sequence)
		{
			if (sequence is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sequence));
			return sequence.CreateTrack ();
		}

		[DllImport (Constants.AudioToolboxLibrary)]
		unsafe extern static /* OSStatus */ MusicPlayerStatus MusicTrackGetSequence (/* MusicTrack */ IntPtr inTrack, /* MusicSequence* */ IntPtr* outSequence);

		/// <summary>Gets the music sequence that owns this track.</summary>
		public MusicSequence? Sequence {
			get {
				IntPtr seqHandle;
				unsafe {
					if (MusicTrackGetSequence (Handle, &seqHandle) == MusicPlayerStatus.Success)
						return MusicSequence.Lookup (seqHandle);
				}
				return null;
			}
		}

#if IOS
		[DllImport (Constants.AudioToolboxLibrary)]
		extern static /* OSStatus */ MusicPlayerStatus MusicTrackSetDestMIDIEndpoint (/* MusicTrack */ IntPtr inTrack, MidiEndpointRef inEndpoint);

		/// <param name="endpoint">The endpoint.</param>
		/// <summary>Sets the destination MIDI endpoint for this track.</summary>
		public MusicPlayerStatus SetDestMidiEndpoint (MidiEndpoint endpoint)
		{
			return MusicTrackSetDestMIDIEndpoint (Handle, endpoint is null ? MidiObject.InvalidRef : endpoint.MidiHandle);
		}

		[DllImport (Constants.AudioToolboxLibrary)]
		unsafe extern static /* OSStatus */ MusicPlayerStatus MusicTrackGetDestMIDIEndpoint (/* MusicTrack */ IntPtr inTrack, MidiEndpointRef* outEndpoint);

		public MusicPlayerStatus GetDestMidiEndpoint (out MidiEndpoint? outEndpoint)
		{
			MidiEndpointRef midiHandle;
			MusicPlayerStatus result;
			unsafe {
				result = MusicTrackGetDestMIDIEndpoint (Handle, &midiHandle);
			}
			outEndpoint = (result == MusicPlayerStatus.Success) ? new MidiEndpoint (midiHandle) : null;
			return result;
		}
#endif

		[DllImport (Constants.AudioToolboxLibrary)]
		extern static /* OSStatus */ MusicPlayerStatus MusicTrackSetDestNode (/* MusicTrack */ IntPtr inTrack, /* AUNode */ int inNode);

		/// <param name="node">The node.</param>
		/// <summary>Sets the destination Audio Unit node for this track.</summary>
		public MusicPlayerStatus SetDestNode (int node)
		{
			return MusicTrackSetDestNode (Handle, node);
		}

		[DllImport (Constants.AudioToolboxLibrary)]
		extern unsafe static /* OSStatus */ MusicPlayerStatus MusicTrackSetProperty (/* MusicTrack */ IntPtr inTrack, /* UInt32 */ SequenceTrackProperty propertyId, byte* inData, /* UInt32 */ int inLength);

		[DllImport (Constants.AudioToolboxLibrary)]
		unsafe extern static /* OSStatus */ MusicPlayerStatus MusicTrackSetProperty (/* MusicTrack */ IntPtr inTrack, /* UInt32 */ SequenceTrackProperty propertyId, double* inData, /* UInt32 */ int inLength);

		[DllImport (Constants.AudioToolboxLibrary)]
		extern unsafe static /* OSStatus */ MusicPlayerStatus MusicTrackGetProperty (/* MusicTrack */ IntPtr inTrack, /* UInt32 */ SequenceTrackProperty propertyId, byte* outData, /* UInt32* */ int* ioLength);

		[DllImport (Constants.AudioToolboxLibrary)]
		unsafe extern static /* OSStatus */ MusicPlayerStatus MusicTrackGetProperty (/* MusicTrack */ IntPtr inTrack, /* UInt32 */ SequenceTrackProperty propertyId, double* outData, /* UInt32* */ int* ioLength);

		// internal use only - it's a UInt32 in the API
		enum SequenceTrackProperty {
			LoopInfo,
			OffsetTime,
			MuteStatus,
			SoloStatus,
			AutomatedParameters,
			TrackLength,
			TimeResolution,
		}

		/// <summary>Gets or sets whether this track is muted.</summary>
		public bool MuteStatus {
			get {
				byte val;
				unsafe {
					int len = 1;
					MusicTrackGetProperty (Handle, SequenceTrackProperty.MuteStatus, &val, &len);
					return val != 0;
				}
			}
			set {
				unsafe {
					var val = value ? (byte) 1 : (byte) 0;
					MusicTrackSetProperty (Handle, SequenceTrackProperty.MuteStatus, &val, 1);
				}
			}
		}

		/// <summary>Gets or sets whether this track is soloed.</summary>
		public bool SoloStatus {
			get {
				byte val;
				unsafe {
					int len = 1;
					MusicTrackGetProperty (Handle, SequenceTrackProperty.SoloStatus, &val, &len);
					return val != 0;
				}
			}
			set {
				unsafe {
					var val = value ? (byte) 1 : (byte) 0;
					MusicTrackSetProperty (Handle, SequenceTrackProperty.SoloStatus, &val, 1);
				}
			}
		}

		/// <summary>Gets or sets the track length in beats.</summary>
		public double TrackLength {
			get {
				double value = 0;
				int len = sizeof (double);
				unsafe {
					MusicTrackGetProperty (Handle, SequenceTrackProperty.TrackLength, &value, &len);
				}
				return value;
			}
			set {
				unsafe {
					MusicTrackSetProperty (Handle, SequenceTrackProperty.TrackLength, &value, sizeof (double));
				}
			}
		}

		[DllImport (Constants.AudioToolboxLibrary)]
		unsafe extern static /* OSStatus */ MusicPlayerStatus MusicTrackNewMIDINoteEvent (/* MusicTrack */ IntPtr inTrack, /* MusicTimeStamp */ double inTimeStamp, MidiNoteMessage* inMessage);

		/// <param name="timeStamp">The timestamp in beats.</param>
		/// <param name="message">The MIDI channel message.</param>
		/// <summary>Adds a MIDI note event to the track.</summary>
		public unsafe MusicPlayerStatus AddMidiNoteEvent (double timeStamp, MidiNoteMessage message)
		{
			return MusicTrackNewMIDINoteEvent (Handle, timeStamp, &message);
		}

		[DllImport (Constants.AudioToolboxLibrary)]
		unsafe extern static /* OSStatus */ MusicPlayerStatus MusicTrackNewMIDIChannelEvent (/* MusicTrack */ IntPtr inTrack, /* MusicTimeStamp */ double inTimeStamp, MidiChannelMessage* inMessage);

		/// <param name="timestamp">The timestamp in beats.</param>
		/// <param name="channelMessage">The channelMessage.</param>
		/// <summary>Adds a MIDI channel event to the track.</summary>
		public unsafe MusicPlayerStatus AddMidiChannelEvent (double timestamp, MidiChannelMessage channelMessage)
		{
			return MusicTrackNewMIDIChannelEvent (Handle, timestamp, &channelMessage);
		}

		[DllImport (Constants.AudioToolboxLibrary)]
		extern static /* OSStatus */ MusicPlayerStatus MusicTrackNewMIDIRawDataEvent (/* MusicTrack */ IntPtr inTrack, /* MusicTimeStamp */ double inTimestamp, /* MIDIRawData* */ IntPtr inRawData);

		/// <param name="timestamp">The timestamp in beats.</param>
		/// <param name="rawData">The rawData.</param>
		/// <summary>Adds raw MIDI data to the track.</summary>
		public MusicPlayerStatus AddMidiRawDataEvent (double timestamp, MidiRawData rawData)
		{
			if (rawData is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (rawData));

			var native = rawData.ToUnmanaged ();
			var r = MusicTrackNewMIDIRawDataEvent (Handle, timestamp, native);
			Marshal.FreeHGlobal (native);
			return r;
		}

		[DllImport (Constants.AudioToolboxLibrary)]
		unsafe extern static /* OSStatus */ MusicPlayerStatus MusicTrackNewExtendedNoteEvent (/* MusicTrack */ IntPtr inTrack, /* MusicTimeStamp */ double inTimeStamp, ExtendedNoteOnEvent* inInfo);

		/// <param name="timestamp">The timestamp in beats.</param>
		/// <param name="evt">The evt.</param>
		/// <summary>Adds an extended note event to the track.</summary>
		public MusicPlayerStatus AddNewExtendedNoteEvent (double timestamp, ExtendedNoteOnEvent evt)
		{
			unsafe {
				return MusicTrackNewExtendedNoteEvent (Handle, timestamp, &evt);
			}
		}

		[DllImport (Constants.AudioToolboxLibrary)]
		extern static /* OSStatus */ MusicPlayerStatus MusicTrackNewExtendedTempoEvent (/* MusicTrack */ IntPtr inTrack, /* MusicTimeStamp */ double inTimeStamp, /* Float64 */ double bpm);

		/// <param name="timestamp">The timestamp in beats.</param>
		/// <param name="bmp">The bmp.</param>
		/// <summary>Adds an extended tempo event at the specified timestamp.</summary>
		public MusicPlayerStatus AddExtendedTempoEvent (double timestamp, double bmp)
		{
			return MusicTrackNewExtendedTempoEvent (Handle, timestamp, bmp);
		}

		[DllImport (Constants.AudioToolboxLibrary)]
		extern static /* OSStatus */ MusicPlayerStatus MusicTrackNewMetaEvent (/* MusicTrack */ IntPtr inTrack, /* MusicTimeStamp */ double inTimeStamp, /* MIDIMetaEvent* */ IntPtr inMetaEvent);

		/// <param name="timestamp">The timestamp in beats.</param>
		/// <param name="metaEvent">The metaEvent.</param>
		/// <summary>Adds a meta event at the specified timestamp.</summary>
		public MusicPlayerStatus AddMetaEvent (double timestamp, MidiMetaEvent metaEvent)
		{
			if (metaEvent is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (metaEvent));

			var ptr = metaEvent.ToUnmanaged ();
			var ret = MusicTrackNewMetaEvent (Handle, timestamp, ptr);
			Marshal.FreeHGlobal (ptr);
			return ret;
		}

		[DllImport (Constants.AudioToolboxLibrary)]
		extern static /* OSStatus */ MusicPlayerStatus MusicTrackNewUserEvent (/* MusicTrack */ IntPtr inTrack, /* MusicTimeStamp */ double inTimeStamp, /* MusicEventUserData* */ IntPtr inUserData);

		/// <param name="timestamp">The timestamp in beats.</param>
		/// <param name="userData">The userData.</param>
		/// <summary>Adds a user event at the specified timestamp.</summary>
		public MusicPlayerStatus AddUserEvent (double timestamp, MusicEventUserData userData)
		{
			if (userData is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userData));
			var ptr = userData.ToUnmanaged ();
			var ret = MusicTrackNewUserEvent (Handle, timestamp, ptr);
			Marshal.FreeHGlobal (ptr);
			return ret;
		}

		[DllImport (Constants.AudioToolboxLibrary)]
		extern static /* OSStatus */ MusicPlayerStatus MusicTrackMoveEvents (/* MusicTrack */ IntPtr inTrack, /* MusicTimeStamp */ double inStartTime, /* MusicTimeStamp */ double inEndTime, /* MusicTimeStamp */ double inMoveTime);

		/// <param name="startTime">The start time in beats.</param>
		/// <param name="endTime">The end time in beats.</param>
		/// <param name="moveTime">The amount to move in beats.</param>
		/// <summary>Moves events within a time range by the specified amount.</summary>
		public MusicPlayerStatus MoveEvents (double startTime, double endTime, double moveTime)
		{
			return MusicTrackMoveEvents (Handle, startTime, endTime, moveTime);
		}

		[DllImport (Constants.AudioToolboxLibrary)]
		extern static /* OSStatus */ MusicPlayerStatus MusicTrackClear (/* MusicTrack */ IntPtr inTrack, /* MusicTimeStamp */ double inStartTime, /* MusicTimeStamp */ double inEndTime);

		/// <param name="startTime">The start time in beats.</param>
		/// <param name="endTime">The end time in beats.</param>
		/// <summary>Clears events within the specified time range.</summary>
		public MusicPlayerStatus Clear (double startTime, double endTime)
		{
			return MusicTrackClear (Handle, startTime, endTime);
		}

		[DllImport (Constants.AudioToolboxLibrary)]
		extern static /* OSStatus */ MusicPlayerStatus MusicTrackCut (/* MusicTrack */ IntPtr inTrack, /* MusicTimeStamp */ double inStartTime, /* MusicTimeStamp */ double inEndTime);

		/// <param name="startTime">The start time in beats.</param>
		/// <param name="endTime">The end time in beats.</param>
		/// <summary>Cuts events within the specified time range.</summary>
		public MusicPlayerStatus Cut (double startTime, double endTime)
		{
			return MusicTrackCut (Handle, startTime, endTime);
		}

		[DllImport (Constants.AudioToolboxLibrary)]
		extern static /* OSStatus */ MusicPlayerStatus MusicTrackCopyInsert (/* MusicTrack */ IntPtr inSourceTrack, /* MusicTimeStamp */ double inSourceStartTime, double /* MusicTimeStamp */ inSourceEndTime, /* MusicTrack */ IntPtr inDestTrack, /* MusicTimeStamp */ double inDestInsertTime);

		/// <param name="sourceStartTime">The sourceStartTime.</param>
		/// <param name="sourceEndTime">The sourceEndTime.</param>
		/// <param name="targetTrack">The targetTrack.</param>
		/// <param name="targetInsertTime">The targetInsertTime.</param>
		/// <summary>Copies events from a source track and inserts them.</summary>
		public MusicPlayerStatus CopyInsert (double sourceStartTime, double sourceEndTime, MusicTrack targetTrack, double targetInsertTime)
		{
			if (targetTrack is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (targetTrack));
			MusicPlayerStatus status = MusicTrackCopyInsert (Handle, sourceStartTime, sourceEndTime, targetTrack.Handle, targetInsertTime);
			GC.KeepAlive (targetTrack);
			return status;
		}

		[DllImport (Constants.AudioToolboxLibrary)]
		extern static /* OSStatus */ MusicPlayerStatus MusicTrackMerge (/* MusicTrack */ IntPtr inSourceTrack, /* MusicTimeStamp */ double inSourceStartTime, double /* MusicTimeStamp */ inSourceEndTime, /* MusicTrack */ IntPtr inDestTrack, /* MusicTimeStamp */ double inDestInsertTime);

		/// <param name="sourceStartTime">The sourceStartTime.</param>
		/// <param name="sourceEndTime">The sourceEndTime.</param>
		/// <param name="targetTrack">The targetTrack.</param>
		/// <param name="targetInsertTime">The targetInsertTime.</param>
		/// <summary>Merges events from a source track into this track.</summary>
		public MusicPlayerStatus Merge (double sourceStartTime, double sourceEndTime, MusicTrack targetTrack, double targetInsertTime)
		{
			if (targetTrack is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (targetTrack));
			MusicPlayerStatus status = MusicTrackMerge (Handle, sourceStartTime, sourceEndTime, targetTrack.Handle, targetInsertTime);
			GC.KeepAlive (targetTrack);
			return status;
		}
#endif // !COREBUILD
	}
}
