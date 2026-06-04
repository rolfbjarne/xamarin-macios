/*
 * CGEvenTypes.cs: bindings to the ApplicationServices framework's CoreGraphics APIs
 * 
 * Copyright 2013, 2014 Xamarin Inc
 * All Rights Reserved
 * 
 * Authors:
 *    Miguel de Icaza
 */

#nullable enable

#if MONOMAC || __MACCATALYST__

using System.Drawing;

using CoreFoundation;

namespace CoreGraphics {

	// CGEventTypes.h:typedef uint32_t CGEventTapLocation;
	/// <summary>Specifies the location of an event tap in the system.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum CGEventTapLocation : int {
		/// <summary>Events are tapped at the HID (hardware interface device) level.</summary>
		HID,
		/// <summary>Events are tapped at the session level.</summary>
		Session,
		/// <summary>Events are tapped at the annotated session level.</summary>
		AnnotatedSession,
	}

	// CGEventTypes.h:typedef uint32_t CGEventTapPlacement;
	/// <summary>Specifies the placement of an event tap relative to other taps.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum CGEventTapPlacement : uint {
		/// <summary>The tap is placed before any existing taps.</summary>
		HeadInsert,
		/// <summary>The tap is placed after any existing taps.</summary>
		TailAppend,
	}

	// CGEventTypes.h:typedef uint32_t CGEventTapOptions;
	/// <summary>Specifies the behavior of an event tap.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum CGEventTapOptions : uint {
		/// <summary>The tap is an active filter that can modify events.</summary>
		Default,
		/// <summary>The tap is a passive listener that cannot modify events.</summary>
		ListenOnly,
	}

	// CGEventTypes.h:typedef uint32_t CGMouseButton;
	/// <summary>Specifies mouse button constants.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum CGMouseButton : uint {
		/// <summary>The left mouse button.</summary>
		Left,
		/// <summary>The right mouse button.</summary>
		Right,
		/// <summary>The center mouse button.</summary>
		Center,
	}

	// CGEventTypes.h:typedef uint32_t CGScrollEventUnit;
	/// <summary>Specifies the unit of measurement for scroll events.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum CGScrollEventUnit : uint {
		/// <summary>Scroll distance is measured in pixels.</summary>
		Pixel,
		/// <summary>Scroll distance is measured in lines.</summary>
		Line,
	}

	// CGEventTypes.h:typedef uint64_t CGEventMask;
	/// <summary>A bitmask that specifies which event types to listen for.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Flags]
	public enum CGEventMask : ulong {
		/// <summary>The null event mask.</summary>
		Null = 0x00000001,
		/// <summary>The left mouse down event mask.</summary>
		LeftMouseDown = 0x00000002,
		/// <summary>The left mouse up event mask.</summary>
		LeftMouseUp = 0x00000004,
		/// <summary>The right mouse down event mask.</summary>
		RightMouseDown = 0x00000008,
		/// <summary>The right mouse up event mask.</summary>
		RightMouseUp = 0x00000010,
		/// <summary>The mouse moved event mask.</summary>
		MouseMoved = 0x00000020,
		/// <summary>The left mouse dragged event mask.</summary>
		LeftMouseDragged = 0x00000040,
		/// <summary>The right mouse dragged event mask.</summary>
		RightMouseDragged = 0x00000080,
		/// <summary>The key down event mask.</summary>
		KeyDown = 0x00000400,
		/// <summary>The key up event mask.</summary>
		KeyUp = 0x00000800,
		/// <summary>The flags changed event mask.</summary>
		FlagsChanged = 0x00001000,
		/// <summary>The scroll wheel event mask.</summary>
		ScrollWheel = 0x00400000,
		/// <summary>The tablet pointer event mask.</summary>
		TabletPointer = 0x00800000,
		/// <summary>The tablet proximity event mask.</summary>
		TabletProximity = 0x01000000,
		/// <summary>The other mouse down event mask.</summary>
		OtherMouseDown = 0x02000000,
		/// <summary>The other mouse up event mask.</summary>
		OtherMouseUp = 0x04000000,
		/// <summary>The other mouse dragged event mask.</summary>
		OtherMouseDragged = 0x08000000,
	}

	// CGEventTypes.h:typedef uint64_t CGEventFlags;
	/// <summary>Specifies modifier key flags for events.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Flags]
	public enum CGEventFlags : ulong {
		/// <summary>The event is non-coalesced.</summary>
		NonCoalesced = 0x00000100,
		/// <summary>The Caps Lock key is active.</summary>
		AlphaShift = 0x00010000,
		/// <summary>The Shift key is held down.</summary>
		Shift = 0x00020000,
		/// <summary>The Control key is held down.</summary>
		Control = 0x00040000,
		/// <summary>The Option (Alternate) key is held down.</summary>
		Alternate = 0x00080000,
		/// <summary>The Command key is held down.</summary>
		Command = 0x00100000,
		/// <summary>A key on the numeric pad is held down.</summary>
		NumericPad = 0x00200000,
		/// <summary>The Help key is held down.</summary>
		Help = 0x00400000,
		/// <summary>The Function (Fn) key is held down.</summary>
		SecondaryFn = 0x00800000,
	}

	// CGEventTypes.h:typedef uint32_t CGEventField;
	/// <summary>This enum represents constants used to access specialized fields in low-level events.</summary>
	/// <remarks>Call <see cref="CGEvent.GetLongValueField" /> or <see cref="CGEvent.GetDoubleValueField" /> to fetch the field values, and <see cref="CGEvent.SetValueField(CGEventField,long)" /> or <see cref="CGEvent.SetValueField(CGEventField,double)" /> to set the field values represented by the constants in this enum.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum CGEventField : int {
		/// <summary>The mouse button event number. This is an integer field. Matching mouse-down and mouse-up events will have the same event number.</summary>
		MouseEventNumber = 0,

		/// <summary>The mouse button click state. This is an integer field. A value of 1 is a single click, a value of 2 is a double click, and so on.</summary>
		MouseEventClickState = 1,

		/// <summary>The mouse button pressure state, ranging from 0 (mouse being up) to 1. This is an integer field.</summary>
		MouseEventPressure = 2,

		/// <summary>The mouse button number. This is an integer field.</summary>
		MouseEventButtonNumber = 3,

		/// <summary>The horizontal delta since the last mouse movement event. This is an integer field.</summary>
		MouseEventDeltaX = 4,

		/// <summary>The vertical delta since the last mouse movement event. This is an integer field.</summary>
		MouseEventDeltaY = 5,

		/// <summary>A value indicating whether the event should be ignored by the Inkwell subsystem. This is an integer field. A non-zero indicates the event should be ignored.</summary>
		MouseEventInstantMouser = 6,

		/// <summary>The mouse event subtype. This is an integer field.</summary>
		MouseEventSubtype = 7,

		/// <summary>A value indicating whether the key-down event is an autorepeat of APrevious key-down event. This is an integer field. Zero indicates not an autorepeat, non-zero not an autorepeat.</summary>
		KeyboardEventAutorepeat = 8,

		/// <summary>The virtual keycode of the key-down or key-up event. This is an integer field.</summary>
		KeyboardEventKeycode = 9,

		/// <summary>The keyboard ype identifier This is an integer field.</summary>
		KeyboardEventKeyboardType = 10,

		/// <summary>A value that represents scrolling data. Typically this is the vertical position change since the last scrolling event. This is an integer field.</summary>
		ScrollWheelEventDeltaAxis1 = 11,

		/// <summary>A value that represents scrolling data. Typically this is the horizontal position change since the last scrolling event. This is an integer field.</summary>
		ScrollWheelEventDeltaAxis2 = 12,

		/// <summary>This value is unused.</summary>
		ScrollWheelEventDeltaAxis3 = 13,

		/// <summary>A value that represents scrolling data. Typically this is the line-based or pixel-based vertical position change since the last scrolling event. This field is a fixed-point 16.16 signed integer, but can also be retrieved as a double and will be automatically converted.</summary>
		ScrollWheelEventFixedPtDeltaAxis1 = 93,

		/// <summary>A value that represents scrolling data. Typically this is the line-based or pixel-based horizontal position change since the last scrolling event. This field is a fixed-point 16.16 signed integer, but can also be retrieved as a double and will be automatically converted.</summary>
		ScrollWheelEventFixedPtDeltaAxis2 = 94,

		/// <summary>This value is unused.</summary>
		ScrollWheelEventFixedPtDeltaAxis3 = 95,

		/// <summary>A value that represents pixel-based scrolling data. Typically this is the vertical position change since the last scrolling event. This is an integer field.</summary>
		ScrollWheelEventPointDeltaAxis1 = 96,

		/// <summary>A value that represents pixel-based scrolling data. Typically this is the horizontal position change since the last scrolling event. This is an integer field.</summary>
		ScrollWheelEventPointDeltaAxis2 = 97,

		/// <summary>This value is unused.</summary>
		ScrollWheelEventPointDeltaAxis3 = 98,

		/// <summary>A value indicating whether the event should be ignored by the Inkwell subsystem. This is an integer field. A non-zero indicates the event should be ignored.</summary>
		ScrollWheelEventInstantMouser = 14,

		/// <summary>A value that represents the absolute X coordinate in table space at full tablet resolution. This is an integer field.</summary>
		TabletEventPointX = 15,

		/// <summary>A value that represents the absolute Y coordinate in table space at full tablet resolution. This is an integer field.</summary>
		TabletEventPointY = 16,

		/// <summary>A value that represents the absolute Z coordinate in table space at full tablet resolution. This is an integer field.</summary>
		TabletEventPointZ = 17,

		/// <summary>A value that represents the tablet button state. This is a bitfield represented by an integer field. Bit 0 is the first button, and a set bit represents a closed or pressed button. A maximum of 16 buttons are supported.</summary>
		TabletEventPointButtons = 18,

		/// <summary>A value that represents the tablet pen pressure. This is a double field, with values ranging from 0.0 (no pressure) and 1.0 (maximum pressure).</summary>
		TabletEventPointPressure = 19,

		/// <summary>A value that represents the horizontal tablet pen tilt. This is a double field, with values ranging from 0.0 (no tilt) and 1.0 (maximum tilt).</summary>
		TabletEventTiltX = 20,

		/// <summary>A value that represents the vertical tablet pen tilt. This is a double field, with values ranging from 0.0 (no tilt) and 1.0 (maximum tilt).</summary>
		TabletEventTiltY = 21,

		/// <summary>A value that represents the tablet pen rotation. This is a double field.</summary>
		TabletEventRotation = 22,

		/// <summary>A value that represents the tangential pressure on a device. This is a double field, with values ranging from 0.0 (no pressure) and 1.0 (maximum pressure).</summary>
		TabletEventTangentialPressure = 23,

		/// <summary>A value that represents the system-assigned unique device id. This is an integer field.</summary>
		TabletEventDeviceId = 24,

		/// <summary>This is a vendor-specific value. This is an integer field.</summary>
		TabletEventVendor1 = 25,

		/// <summary>This is a vendor-specific value. This is an integer field.</summary>
		TabletEventVendor2 = 26,

		/// <summary>This is a vendor-specific value. This is an integer field.</summary>
		TabletEventVendor3 = 27,

		/// <summary>A value that represents the vendor-defined id, typically the USB vendor id. This is an integer field.</summary>
		TabletProximityEventVendorId = 28,

		/// <summary>A value that represents the vendor-defined tabled id, typically the USB product id. This is an integer field.</summary>
		TabletProximityEventTabletId = 29,

		/// <summary>A value that represents the vendor-defined id the pointing device. This is an integer field.</summary>
		TabletProximityEventPointerId = 30,

		/// <summary>A system-assigned device id for the device. This is an integer field.</summary>
		TabletProximityEventDeviceId = 31,

		/// <summary>A system-assigned unique tablet id for the device. This is an integer field.</summary>
		TabletProximityEventSystemTabletId = 32,

		/// <summary>The vendor-assigned pointer type. This is an integer field.</summary>
		TabletProximityEventVendorPointerType = 33,

		/// <summary>The vendor-defined pointer serial number. This is an integer field.</summary>
		TabletProximityEventVendorPointerSerialNumber = 34,

		/// <summary>The vendor-defined unique id. This is an integer field.</summary>
		TabletProximityEventVendorUniqueId = 35,

		/// <summary>A value that represents the device capabilities mask. This is an integer field.</summary>
		TabletProximityEventCapabilityMask = 36,

		/// <summary>A value that represents the pointer type. This is an integer field.</summary>
		TabletProximityEventPointerType = 37,

		/// <summary>A value that indicates whether the pen is in proximity to the tablet. This is an integer field. The value is non-zero if the pen is in proximity to the tablet, and zero otherwise.</summary>
		TabletProximityEventEnterProximity = 38,

		/// <summary>The process serial number for the target process. This is an integer field.</summary>
		EventTargetProcessSerialNumber = 39,

		/// <summary>The process id (pid) of the target process. This is an integer field.</summary>
		EventTargetUnixProcessId = 40,

		/// <summary>The process id (pid) of the target process. This is an integer field.</summary>
		EventSourceUnixProcessId = 41,

		/// <summary>User-supplied data. This is an integer field.</summary>
		EventSourceUserData = 42,

		/// <summary>The Unix effective UID for the event source. This is an integer field.</summary>
		EventSourceUserId = 43,

		/// <summary>The Unix effective GID for the event source. This is an integer field.</summary>
		EventSourceGroupId = 44,

		/// <summary>The state id for the event source used to create this event. This is an integer field.</summary>
		EventSourceStateId = 45,

		/// <summary>A value that indicates whether a scrolling event contains continuous, pixel-based scrolling data. This is an integer field. The value is non-zero when the scrolling data is continuous and pixel-based, and zero otherwise (when the scrolling data is line-based).</summary>
		ScrollWheelEventIsContinuous = 88,

		// no documentation for this value in the header file.
		/// <summary>A value that represents the event window under the mouse pointer.</summary>
		EventWindowUnderMousePointer = 91,

		// no documentation for this value in the header file.
		/// <summary>A value that represents the event window under the mouse pointer that can handle this event.</summary>
		EventWindowUnderMousePointerThatCanHandleThisEvent = 92,

		// no documentation for this value in the header file.
		/// <summary>A value that represents the scroll wheel's scroll phase.</summary>
		ScrollWheelEventScrollPhase = 99,

		// no documentation for this value in the header file.
		/// <summary>A value that represents the scroll wheel's scroll count.</summary>
		ScrollWheelEventScrollCount = 100,

		// no documentation for this value in the header file.
		/// <summary>A value that represents the scroll wheel's scroll momentum.</summary>
		ScrollWheelEventMomentumPhase = 123,

		// the header file doesn't say whether this is an integer or a double
		/// <summary>The unaccelerated pointer movement for the X axis.</summary>
		EventUnacceleratedPointerMovementX = 170,

		// the header file doesn't say whether this is an integer or a double
		/// <summary>The unaccelerated pointer movement for the Y axis.</summary>
		EventUnacceleratedPointerMovementY = 171,

		// no documentation for this value in the header file.
		/// <summary>A value that represents the scroll wheel's scroll momentum.</summary>
		ScrollWheelEventMomentumOptionPhase = 173,

		// no documentation for this value in the header file.
		/// <summary>A value that represents the accelerated delta value for axis 1.</summary>
		ScrollWheelEventAcceleratedDeltaAxis1 = 176,

		// no documentation for this value in the header file.
		/// <summary>A value that represents the accelerated delta value for axis 2.</summary>
		ScrollWheelEventAcceleratedDeltaAxis2 = 175,

		// no documentation for this value in the header file.
		/// <summary>A value that represents the raw delta value for axis 1.</summary>
		ScrollWheelEventRawDeltaAxis1 = 178,

		// no documentation for this value in the header file.
		/// <summary>A value that represents the raw delta value for axis 2.</summary>
		ScrollWheelEventRawDeltaAxis2 = 177,
	}

	// CGEventTypes.h:typedef uint32_t CGEventType;
	/// <summary>Specifies the type of a Quartz event.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum CGEventType : uint {
		/// <summary>A null event.</summary>
		Null = 0x0,
		/// <summary>A left mouse button down event.</summary>
		LeftMouseDown = 0x1,
		/// <summary>A left mouse button up event.</summary>
		LeftMouseUp = 0x2,
		/// <summary>A right mouse button down event.</summary>
		RightMouseDown = 0x3,
		/// <summary>A right mouse button up event.</summary>
		RightMouseUp = 0x4,
		/// <summary>A mouse moved event.</summary>
		MouseMoved = 0x5,
		/// <summary>A left mouse button dragged event.</summary>
		LeftMouseDragged = 0x6,
		/// <summary>A right mouse button dragged event.</summary>
		RightMouseDragged = 0x7,
		/// <summary>A key down event.</summary>
		KeyDown = 0xa,
		/// <summary>A key up event.</summary>
		KeyUp = 0xb,
		/// <summary>A modifier key flags changed event.</summary>
		FlagsChanged = 0xc,
		/// <summary>A scroll wheel event.</summary>
		ScrollWheel = 0x16,
		/// <summary>A tablet pointer event.</summary>
		TabletPointer = 0x17,
		/// <summary>A tablet proximity event.</summary>
		TabletProximity = 0x18,
		/// <summary>An other mouse button down event.</summary>
		OtherMouseDown = 0x19,
		/// <summary>An other mouse button up event.</summary>
		OtherMouseUp = 0x1a,
		/// <summary>An other mouse button dragged event.</summary>
		OtherMouseDragged = 0x1b,
		TapDisabledByTimeout = 4294967294,
		TapDisabledByUserInput = 4294967295,
	}

	// CGEventTypes.h:typedef uint32_t CGEventMouseSubtype;
	/// <summary>Specifies the mouse event subtype.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum CGEventMouseSubtype : uint {
		/// <summary>The default mouse subtype.</summary>
		Default,
		/// <summary>A tablet point subtype.</summary>
		TabletPoint,
		/// <summary>A tablet proximity subtype.</summary>
		TabletProximity,
	}

	// CGEventTypes.h:typedef uint32_t CGEventSourceStateID;
	/// <summary>Specifies the state of an event source.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum CGEventSourceStateID : int {
		/// <summary>A private event source state.</summary>
		Private = -1,
		/// <summary>The combined session event source state.</summary>
		CombinedSession = 0,
		/// <summary>The HID system event source state.</summary>
		HidSystem = 1,
	}

	// CGRemoteOperation.h:typedef uint32_t CGEventFilterMask;
	/// <summary>Specifies event filter masks for event suppression.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Flags]
	public enum CGEventFilterMask : uint {
		/// <summary>Permit local mouse events during suppression.</summary>
		PermitLocalMouseEvents = 1,
		/// <summary>Permit local keyboard events during suppression.</summary>
		PermitLocalKeyboardEvents = 2,
		/// <summary>Permit system-defined events during suppression.</summary>
		PermitSystemDefinedEvents = 4,
	}

	// CGRemoteOperation.h:typedef uint32_t CGEventSuppressionState;
	/// <summary>Specifies the event suppression state.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum CGEventSuppressionState : int {
		/// <summary>The suppression interval state.</summary>
		SuppressionInterval,
		/// <summary>The remote mouse drag state.</summary>
		RemoteMouseDrag,
		NumberOfEventSuppressionStates,
	}

}

#endif // MONOMAC
