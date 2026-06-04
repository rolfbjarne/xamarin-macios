//
// Copyright 2010, 2011 Novell, Inc.
// Copyright 2011, Xamarin, Inc.
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
using System.ComponentModel;

#nullable enable

namespace AppKit {

	[NoMacCatalyst]
	[Native]
	public enum NSRunResponse : long {
		/// <summary>Stopped.</summary>
		Stopped = -1000,
		/// <summary>Aborted.</summary>
		Aborted = -1001,
		/// <summary>Continues.</summary>
		Continues = -1002,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSApplicationActivationOptions : ulong {
		/// <summary>Default.</summary>
		Default = 0,
		/// <summary>Activate All Windows.</summary>
		ActivateAllWindows = 1,
		/// <summary>Activate Ignoring Other Windows.</summary>
		ActivateIgnoringOtherWindows = 2,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSApplicationActivationPolicy : long {
		/// <summary>Regular.</summary>
		Regular,
		/// <summary>Accessory.</summary>
		Accessory,
		/// <summary>Prohibited.</summary>
		Prohibited,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSApplicationPresentationOptions : ulong {
		/// <summary>Default.</summary>
		Default = 0,
		/// <summary>Auto Hide Dock.</summary>
		AutoHideDock = (1 << 0),
		/// <summary>Hide Dock.</summary>
		HideDock = (1 << 1),

		/// <summary>Auto Hide Menu Bar.</summary>
		AutoHideMenuBar = (1 << 2),
		/// <summary>Hide Menu Bar.</summary>
		HideMenuBar = (1 << 3),

		/// <summary>Disable Apple Menu.</summary>
		DisableAppleMenu = (1 << 4),
		/// <summary>Disable Process Switching.</summary>
		DisableProcessSwitching = (1 << 5),
		/// <summary>Disable Force Quit.</summary>
		DisableForceQuit = (1 << 6),
		/// <summary>Disable Session Termination.</summary>
		DisableSessionTermination = (1 << 7),
		/// <summary>Disable Hide Application.</summary>
		DisableHideApplication = (1 << 8),
		/// <summary>Disable Menu Bar Transparency.</summary>
		DisableMenuBarTransparency = (1 << 9),

		/// <summary>Full Screen.</summary>
		FullScreen = (1 << 10),
		/// <summary>Auto Hide Toolbar.</summary>
		AutoHideToolbar = (1 << 11),
		DisableCursorLocationAssistance = (1 << 12),
	}

	[NoMacCatalyst]
	[Native]
	public enum NSApplicationDelegateReply : ulong {
		/// <summary>Success.</summary>
		Success,
		/// <summary>Cancel.</summary>
		Cancel,
		/// <summary>Failure.</summary>
		Failure,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSRequestUserAttentionType : ulong {
		/// <summary>Critical Request.</summary>
		CriticalRequest = 0,
		/// <summary>Informational Request.</summary>
		InformationalRequest = 10,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSApplicationTerminateReply : ulong {
		/// <summary>Cancel.</summary>
		Cancel,
		/// <summary>Now.</summary>
		Now,
		/// <summary>Later.</summary>
		Later,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSApplicationPrintReply : ulong {
		/// <summary>Cancelled.</summary>
		Cancelled,
		/// <summary>Success.</summary>
		Success,
		/// <summary>Failure.</summary>
		Failure,
		/// <summary>Reply Later.</summary>
		ReplyLater,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSImageInterpolation : ulong {
		/// <summary>Default.</summary>
		Default,
		/// <summary>None.</summary>
		None,
		/// <summary>Low.</summary>
		Low,
		/// <summary>Medium.</summary>
		Medium,
		/// <summary>High.</summary>
		High,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSComposite : ulong {
		/// <summary>Clear.</summary>
		Clear,
		/// <summary>Copy.</summary>
		Copy,
		/// <summary>Source Over.</summary>
		SourceOver,
		/// <summary>Source In.</summary>
		SourceIn,
		/// <summary>Source Out.</summary>
		SourceOut,
		/// <summary>Source Atop.</summary>
		SourceAtop,
		/// <summary>Destination Over.</summary>
		DestinationOver,
		/// <summary>Destination In.</summary>
		DestinationIn,
		/// <summary>Destination Out.</summary>
		DestinationOut,
		/// <summary>Destination Atop.</summary>
		DestinationAtop,
		/// <summary>X O R.</summary>
		XOR,
		/// <summary>Plus Darker.</summary>
		PlusDarker,
		/// <summary>Highlight.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use NSCompositeSourceOver instead.")]
		Highlight,
		/// <summary>Plus Lighter.</summary>
		PlusLighter,
		/// <summary>Multiply.</summary>
		Multiply,
		/// <summary>Screen.</summary>
		Screen,
		/// <summary>Overlay.</summary>
		Overlay,
		/// <summary>Darken.</summary>
		Darken,
		/// <summary>Lighten.</summary>
		Lighten,
		/// <summary>Color Dodge.</summary>
		ColorDodge,
		/// <summary>Color Burn.</summary>
		ColorBurn,
		/// <summary>Soft Light.</summary>
		SoftLight,
		/// <summary>Hard Light.</summary>
		HardLight,
		/// <summary>Difference.</summary>
		Difference,
		/// <summary>Exclusion.</summary>
		Exclusion,
		/// <summary>Hue.</summary>
		Hue,
		/// <summary>Saturation.</summary>
		Saturation,
		/// <summary>Color.</summary>
		Color,
		/// <summary>Luminosity.</summary>
		Luminosity,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSBackingStore : ulong {
		/// <summary>Retained.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 13, message: "Use 'Buffered' instead.")]
		Retained,
		/// <summary>Nonretained.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 13, message: "Use 'Buffered' instead.")]
		Nonretained,
		/// <summary>Buffered.</summary>
		Buffered,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSWindowOrderingMode : long {
		/// <summary>Below.</summary>
		Below = -1,
		/// <summary>Out.</summary>
		Out,
		/// <summary>Above.</summary>
		Above,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSFocusRingPlacement : ulong {
		/// <summary>Ring Only.</summary>
		RingOnly,
		/// <summary>Ring Below.</summary>
		RingBelow,
		/// <summary>Ring Above.</summary>
		RingAbove,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSFocusRingType : ulong {
		/// <summary>Default.</summary>
		Default,
		/// <summary>None.</summary>
		None,
		/// <summary>Exterior.</summary>
		Exterior,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSColorRenderingIntent : long {
		/// <summary>Default.</summary>
		Default,
		/// <summary>Absolute Colorimetric.</summary>
		AbsoluteColorimetric,
		/// <summary>Relative Colorimetric.</summary>
		RelativeColorimetric,
		/// <summary>Perceptual.</summary>
		Perceptual,
		/// <summary>Saturation.</summary>
		Saturation,

	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum NSRectEdge : ulong {
		/// <summary>Min X Edge.</summary>
		MinXEdge,
		/// <summary>Min Y Edge.</summary>
		MinYEdge,
		/// <summary>Max X Edge.</summary>
		MaxXEdge,
		/// <summary>Max Y Edge.</summary>
		MaxYEdge,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSUserInterfaceLayoutDirection : long {
		/// <summary>Left To Right.</summary>
		LeftToRight,
		/// <summary>Right To Left.</summary>
		RightToLeft,
	}

	#region NSColorSpace
	[NoMacCatalyst]
	[Native]
	public enum NSColorSpaceModel : long {
		/// <summary>Unknown.</summary>
		Unknown = -1,
		/// <summary>Gray.</summary>
		Gray,
		/// <summary>R G B.</summary>
		RGB,
		/// <summary>C M Y K.</summary>
		CMYK,
		/// <summary>L A B.</summary>
		LAB,
		/// <summary>Device N.</summary>
		DeviceN,
		/// <summary>Indexed.</summary>
		Indexed,
		/// <summary>Pattern.</summary>
		Pattern,
	}
	#endregion

	#region NSFileWrapper
	#endregion

	#region NSParagraphStyle
	[NoMacCatalyst]
	[Native]
	public enum NSTextTabType : ulong {
		/// <summary>Left.</summary>
		Left,
		/// <summary>Right.</summary>
		Right,
		/// <summary>Center.</summary>
		Center,
		/// <summary>Decimal.</summary>
		Decimal,
	}

	[Native]
	[NoMacCatalyst]
	public enum NSLineBreakMode : ulong {
		/// <summary>By Word Wrapping.</summary>
		ByWordWrapping,
		/// <summary>Char Wrapping.</summary>
		CharWrapping,
		/// <summary>Clipping.</summary>
		Clipping,
		/// <summary>Truncating Head.</summary>
		TruncatingHead,
		/// <summary>Truncating Tail.</summary>
		TruncatingTail,
		/// <summary>Truncating Middle.</summary>
		TruncatingMiddle,
	}

	#endregion

	#region NSCell Defines 

	[NoMacCatalyst]
	[Native]
	public enum NSCellType : ulong {
		/// <summary>Null.</summary>
		Null,
		/// <summary>Text.</summary>
		Text,
		/// <summary>Image.</summary>
		Image,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSCellAttribute : ulong {
		/// <summary>Cell Disabled.</summary>
		CellDisabled,
		/// <summary>Cell State.</summary>
		CellState,
		/// <summary>Push In Cell.</summary>
		PushInCell,
		/// <summary>Cell Editable.</summary>
		CellEditable,
		/// <summary>Change Gray Cell.</summary>
		ChangeGrayCell,
		/// <summary>Cell Highlighted.</summary>
		CellHighlighted,
		/// <summary>Cell Lights By Contents.</summary>
		CellLightsByContents,
		/// <summary>Cell Lights By Gray.</summary>
		CellLightsByGray,
		/// <summary>Change Background Cell.</summary>
		ChangeBackgroundCell,
		/// <summary>Cell Lights By Background.</summary>
		CellLightsByBackground,
		/// <summary>Cell Is Bordered.</summary>
		CellIsBordered,
		/// <summary>Cell Has Overlapping Image.</summary>
		CellHasOverlappingImage,
		/// <summary>Cell Has Image Horizontal.</summary>
		CellHasImageHorizontal,
		/// <summary>Cell Has Image On Left Or Bottom.</summary>
		CellHasImageOnLeftOrBottom,
		/// <summary>Cell Changes Contents.</summary>
		CellChangesContents,
		/// <summary>Cell Is Inset Button.</summary>
		CellIsInsetButton,
		/// <summary>Cell Allows Mixed State.</summary>
		CellAllowsMixedState,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSCellImagePosition : ulong {
		/// <summary>No Image.</summary>
		NoImage,
		/// <summary>Image Only.</summary>
		ImageOnly,
		/// <summary>Image Left.</summary>
		ImageLeft,
		/// <summary>Image Right.</summary>
		ImageRight,
		/// <summary>Image Below.</summary>
		ImageBelow,
		/// <summary>Image Above.</summary>
		ImageAbove,
		/// <summary>Image Overlaps.</summary>
		ImageOverlaps,
		/// <summary>Image Leading.</summary>
		ImageLeading,
		/// <summary>Image Trailing.</summary>
		ImageTrailing,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSImageScale : ulong {
		/// <summary>Proportionally Down.</summary>
		ProportionallyDown = 0,
		/// <summary>Axes Independently.</summary>
		AxesIndependently,
		/// <summary>None.</summary>
		None,
		/// <summary>Proportionally Up Or Down.</summary>
		ProportionallyUpOrDown,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSCellStateValue : long {
		/// <summary>Mixed.</summary>
		Mixed = -1,
		/// <summary>Off.</summary>
		Off,
		/// <summary>On.</summary>
		On,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSCellStyleMask : ulong {
		/// <summary>No Cell.</summary>
		NoCell = 0,
		/// <summary>Contents Cell.</summary>
		ContentsCell = 1 << 0,
		/// <summary>Push In Cell.</summary>
		PushInCell = 1 << 1,
		/// <summary>Change Gray Cell.</summary>
		ChangeGrayCell = 1 << 2,
		/// <summary>Change Background Cell.</summary>
		ChangeBackgroundCell = 1 << 3,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSCellHit : ulong {
		/// <summary>None.</summary>
		None,
		/// <summary>Content Area.</summary>
		ContentArea = 1,
		/// <summary>Editable Text Area.</summary>
		EditableTextArea = 2,
		/// <summary>Trackable Arae.</summary>
		TrackableArae = 4,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSControlTint : ulong {
		/// <summary>Default.</summary>
		Default = 0,    // system 'default'
		/// <summary>Blue.</summary>
		Blue = 1,
		/// <summary>Graphite.</summary>
		Graphite = 6,
		/// <summary>Clear.</summary>
		Clear = 7,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSControlSize : ulong {
		/// <summary>Regular.</summary>
		Regular = 0,
		/// <summary>Small.</summary>
		Small = 1,
		/// <summary>Mini.</summary>
		Mini = 2,
		Large = 3,
		[Mac (26, 0)]
		ExtraLarge = 4,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSBackgroundStyle : long {
		/// <summary>Normal.</summary>
		Normal = 0,
		/// <summary>Light.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Normal' instead.")]
		Light = Normal,
		/// <summary>Emphasized.</summary>
		Emphasized,
		/// <summary>Dark.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Emphasized' instead.")]
		Dark = Emphasized,
		/// <summary>Raised.</summary>
		Raised,
		/// <summary>Lowered.</summary>
		Lowered,
	}
	#endregion

	#region NSImage

	[NoMacCatalyst]
	[Native]
	public enum NSImageLoadStatus : ulong {
		/// <summary>Completed.</summary>
		Completed,
		/// <summary>Cancelled.</summary>
		Cancelled,
		/// <summary>Invalid Data.</summary>
		InvalidData,
		/// <summary>Unexpected E O F.</summary>
		UnexpectedEOF,
		/// <summary>Read Error.</summary>
		ReadError,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSImageCacheMode : ulong {
		/// <summary>Default.</summary>
		Default,
		/// <summary>Always.</summary>
		Always,
		/// <summary>By Size.</summary>
		BySize,
		/// <summary>Never.</summary>
		Never,
	}

	[NoMacCatalyst]
	[Native (ConvertToNative = "NSImageResizingModeExtensions.ToNative", ConvertToManaged = "NSImageResizingModeExtensions.ToManaged")]
	public enum NSImageResizingMode : long {
		/// <summary>Stretch.</summary>
		Stretch,
		/// <summary>Tile.</summary>
		Tile,
	}

	#endregion

	#region NSAlert
	[NoMacCatalyst]
	[Native]
	public enum NSAlertStyle : ulong {
		/// <summary>Warning.</summary>
		Warning,
		/// <summary>Informational.</summary>
		Informational,
		/// <summary>Critical.</summary>
		Critical,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSModalResponse : long {
		/// <summary>O K.</summary>
		OK = 1,
		/// <summary>Cancel.</summary>
		Cancel = 0,
		/// <summary>Stop.</summary>
		Stop = -1000,
		/// <summary>Abort.</summary>
		Abort = -1001,
		/// <summary>Continue.</summary>
		Continue = -1002,
	}
	#endregion

	#region NSEvent
	[NoMacCatalyst]
	[Native]
	public enum NSEventType : ulong {
		/// <summary>Left Mouse Down.</summary>
		LeftMouseDown = 1,
		/// <summary>Left Mouse Up.</summary>
		LeftMouseUp = 2,
		/// <summary>Right Mouse Down.</summary>
		RightMouseDown = 3,
		/// <summary>Right Mouse Up.</summary>
		RightMouseUp = 4,
		/// <summary>Mouse Moved.</summary>
		MouseMoved = 5,
		/// <summary>Left Mouse Dragged.</summary>
		LeftMouseDragged = 6,
		/// <summary>Right Mouse Dragged.</summary>
		RightMouseDragged = 7,
		/// <summary>Mouse Entered.</summary>
		MouseEntered = 8,
		/// <summary>Mouse Exited.</summary>
		MouseExited = 9,
		/// <summary>Key Down.</summary>
		KeyDown = 10,
		/// <summary>Key Up.</summary>
		KeyUp = 11,
		/// <summary>Flags Changed.</summary>
		FlagsChanged = 12,
		/// <summary>App Kit Defined.</summary>
		AppKitDefined = 13,
		/// <summary>System Defined.</summary>
		SystemDefined = 14,
		/// <summary>Application Defined.</summary>
		ApplicationDefined = 15,
		/// <summary>Periodic.</summary>
		Periodic = 16,
		/// <summary>Cursor Update.</summary>
		CursorUpdate = 17,

		/// <summary>Scroll Wheel.</summary>
		ScrollWheel = 22,

		/// <summary>Tablet Point.</summary>
		TabletPoint = 23,
		/// <summary>Tablet Proximity.</summary>
		TabletProximity = 24,

		/// <summary>Other Mouse Down.</summary>
		OtherMouseDown = 25,
		/// <summary>Other Mouse Up.</summary>
		OtherMouseUp = 26,
		/// <summary>Other Mouse Dragged.</summary>
		OtherMouseDragged = 27,

		/// <summary>Gesture.</summary>
		Gesture = 29,
		/// <summary>Magnify.</summary>
		Magnify = 30,
		/// <summary>Swipe.</summary>
		Swipe = 31,
		/// <summary>Rotate.</summary>
		Rotate = 18,
		/// <summary>Begin Gesture.</summary>
		BeginGesture = 19,
		/// <summary>End Gesture.</summary>
		EndGesture = 20,

		/// <summary>Smart Magnify.</summary>
		SmartMagnify = 32,
		/// <summary>Quick Look.</summary>
		QuickLook = 33,
		/// <summary>Pressure.</summary>
		Pressure = 34, // 10.10.3, 64-bit-only
		/// <summary>Direct Touch.</summary>
		DirectTouch = 37, // 10.10
		ChangeMode = 38,
		[Mac (26, 0)]
		MouseCancelled = 40,
	}

	[NoMacCatalyst]
	[Flags]
	public enum NSEventMask : ulong {
		/// <summary>Left Mouse Down.</summary>
		LeftMouseDown = 1UL << (int) NSEventType.LeftMouseDown,
		/// <summary>Left Mouse Up.</summary>
		LeftMouseUp = 1UL << (int) NSEventType.LeftMouseUp,
		/// <summary>Right Mouse Down.</summary>
		RightMouseDown = 1UL << (int) NSEventType.RightMouseDown,
		/// <summary>Right Mouse Up.</summary>
		RightMouseUp = 1UL << (int) NSEventType.RightMouseUp,
		/// <summary>Mouse Moved.</summary>
		MouseMoved = 1UL << (int) NSEventType.MouseMoved,
		/// <summary>Left Mouse Dragged.</summary>
		LeftMouseDragged = 1UL << (int) NSEventType.LeftMouseDragged,
		/// <summary>Right Mouse Dragged.</summary>
		RightMouseDragged = 1UL << (int) NSEventType.RightMouseDragged,
		/// <summary>Mouse Entered.</summary>
		MouseEntered = 1UL << (int) NSEventType.MouseEntered,
		/// <summary>Mouse Exited.</summary>
		MouseExited = 1UL << (int) NSEventType.MouseExited,
		/// <summary>Key Down.</summary>
		KeyDown = 1UL << (int) NSEventType.KeyDown,
		/// <summary>Key Up.</summary>
		KeyUp = 1UL << (int) NSEventType.KeyUp,
		/// <summary>Flags Changed.</summary>
		FlagsChanged = 1UL << (int) NSEventType.FlagsChanged,
		/// <summary>App Kit Defined.</summary>
		AppKitDefined = 1UL << (int) NSEventType.AppKitDefined,
		/// <summary>System Defined.</summary>
		SystemDefined = 1UL << (int) NSEventType.SystemDefined,
		/// <summary>Application Defined.</summary>
		ApplicationDefined = 1UL << (int) NSEventType.ApplicationDefined,
		/// <summary>Periodic.</summary>
		Periodic = 1UL << (int) NSEventType.Periodic,
		/// <summary>Cursor Update.</summary>
		CursorUpdate = 1UL << (int) NSEventType.CursorUpdate,
		/// <summary>Scroll Wheel.</summary>
		ScrollWheel = 1UL << (int) NSEventType.ScrollWheel,
		/// <summary>Tablet Point.</summary>
		TabletPoint = 1UL << (int) NSEventType.TabletPoint,
		/// <summary>Tablet Proximity.</summary>
		TabletProximity = 1UL << (int) NSEventType.TabletProximity,
		/// <summary>Other Mouse Down.</summary>
		OtherMouseDown = 1UL << (int) NSEventType.OtherMouseDown,
		/// <summary>Other Mouse Up.</summary>
		OtherMouseUp = 1UL << (int) NSEventType.OtherMouseUp,
		/// <summary>Other Mouse Dragged.</summary>
		OtherMouseDragged = 1UL << (int) NSEventType.OtherMouseDragged,
		/// <summary>Event Gesture.</summary>
		EventGesture = 1UL << (int) NSEventType.Gesture,
		/// <summary>Event Magnify.</summary>
		EventMagnify = 1UL << (int) NSEventType.Magnify,
		/// <summary>Event Swipe.</summary>
		EventSwipe = 1UL << (int) NSEventType.Swipe,
		/// <summary>Event Rotate.</summary>
		EventRotate = 1UL << (int) NSEventType.Rotate,
		/// <summary>Event Begin Gesture.</summary>
		EventBeginGesture = 1UL << (int) NSEventType.BeginGesture,
		/// <summary>Event End Gesture.</summary>
		EventEndGesture = 1UL << (int) NSEventType.EndGesture,
		/// <summary>Smart Magnify.</summary>
		SmartMagnify = 1UL << (int) NSEventType.SmartMagnify,
		/// <summary>Pressure.</summary>
		Pressure = 1UL << (int) NSEventType.Pressure, // 10.10.3, 64-bit-only
		/// <summary>Direct Touch.</summary>
		DirectTouch = 1UL << (int) NSEventType.DirectTouch, // 10.10
		ChangeMode = 1UL << (int) NSEventType.ChangeMode,
		[Mac (26, 0)]
		MouseCancelled = 1UL << (int) NSEventType.MouseCancelled,
		/// <summary>Any Event.</summary>
		AnyEvent = unchecked((ulong) UInt64.MaxValue),
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSEventModifierMask : ulong {
		/// <summary>Alpha Shift Key Mask.</summary>
		AlphaShiftKeyMask = 1 << 16,
		/// <summary>Shift Key Mask.</summary>
		ShiftKeyMask = 1 << 17,
		/// <summary>Control Key Mask.</summary>
		ControlKeyMask = 1 << 18,
		/// <summary>Alternate Key Mask.</summary>
		AlternateKeyMask = 1 << 19,
		/// <summary>Command Key Mask.</summary>
		CommandKeyMask = 1 << 20,
		/// <summary>Numeric Pad Key Mask.</summary>
		NumericPadKeyMask = 1 << 21,
		/// <summary>Help Key Mask.</summary>
		HelpKeyMask = 1 << 22,
		/// <summary>Function Key Mask.</summary>
		FunctionKeyMask = 1 << 23,
		/// <summary>Device Independent Modifier Flags Mask.</summary>
		DeviceIndependentModifierFlagsMask = 0xffff0000,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSPointingDeviceType : ulong {
		/// <summary>Unknown.</summary>
		Unknown,
		/// <summary>Pen.</summary>
		Pen,
		/// <summary>Cursor.</summary>
		Cursor,
		/// <summary>Eraser.</summary>
		Eraser,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSEventButtonMask : ulong {
		/// <summary>Pen.</summary>
		Pen = 1,
		/// <summary>Pen Lower.</summary>
		PenLower = 2,
		/// <summary>Pen Upper.</summary>
		PenUpper = 4,
	}

	// This enum is defined as an untyped enum in MacOSX.sdk/System/Library/Frameworks/Carbon.framework/Versions/A/Frameworks/HIToolbox.framework/Versions/A/Headers/Events.h
	// It represents values that may be returned by NSEvent.KeyCode (which isn't typed as 'NSKey' because it may be many other values as well).
	[NoMacCatalyst]
	public enum NSKey {
		/// <summary>A.</summary>
		A = 0x00,
		/// <summary>S.</summary>
		S = 0x01,
		/// <summary>D.</summary>
		D = 0x02,
		/// <summary>F.</summary>
		F = 0x03,
		/// <summary>H.</summary>
		H = 0x04,
		/// <summary>G.</summary>
		G = 0x05,
		/// <summary>Z.</summary>
		Z = 0x06,
		/// <summary>X.</summary>
		X = 0x07,
		/// <summary>C.</summary>
		C = 0x08,
		/// <summary>V.</summary>
		V = 0x09,
		/// <summary>B.</summary>
		B = 0x0B,
		/// <summary>Q.</summary>
		Q = 0x0C,
		/// <summary>W.</summary>
		W = 0x0D,
		/// <summary>E.</summary>
		E = 0x0E,
		/// <summary>R.</summary>
		R = 0x0F,
		/// <summary>Y.</summary>
		Y = 0x10,
		/// <summary>T.</summary>
		T = 0x11,
		/// <summary>D1.</summary>
		D1 = 0x12,
		/// <summary>D2.</summary>
		D2 = 0x13,
		/// <summary>D3.</summary>
		D3 = 0x14,
		/// <summary>D4.</summary>
		D4 = 0x15,
		/// <summary>D6.</summary>
		D6 = 0x16,
		/// <summary>D5.</summary>
		D5 = 0x17,
		/// <summary>Equal.</summary>
		Equal = 0x18,
		/// <summary>D9.</summary>
		D9 = 0x19,
		/// <summary>D7.</summary>
		D7 = 0x1A,
		/// <summary>Minus.</summary>
		Minus = 0x1B,
		/// <summary>D8.</summary>
		D8 = 0x1C,
		/// <summary>D0.</summary>
		D0 = 0x1D,
		/// <summary>Right Bracket.</summary>
		RightBracket = 0x1E,
		/// <summary>O.</summary>
		O = 0x1F,
		/// <summary>U.</summary>
		U = 0x20,
		/// <summary>Left Bracket.</summary>
		LeftBracket = 0x21,
		/// <summary>I.</summary>
		I = 0x22,
		/// <summary>P.</summary>
		P = 0x23,
		/// <summary>L.</summary>
		L = 0x25,
		/// <summary>J.</summary>
		J = 0x26,
		/// <summary>Quote.</summary>
		Quote = 0x27,
		/// <summary>K.</summary>
		K = 0x28,
		/// <summary>Semicolon.</summary>
		Semicolon = 0x29,
		/// <summary>Backslash.</summary>
		Backslash = 0x2A,
		/// <summary>Comma.</summary>
		Comma = 0x2B,
		/// <summary>Slash.</summary>
		Slash = 0x2C,
		/// <summary>N.</summary>
		N = 0x2D,
		/// <summary>M.</summary>
		M = 0x2E,
		/// <summary>Period.</summary>
		Period = 0x2F,
		/// <summary>Grave.</summary>
		Grave = 0x32,
		/// <summary>Keypad Decimal.</summary>
		KeypadDecimal = 0x41,
		/// <summary>Keypad Multiply.</summary>
		KeypadMultiply = 0x43,
		/// <summary>Keypad Plus.</summary>
		KeypadPlus = 0x45,
		/// <summary>Keypad Clear.</summary>
		KeypadClear = 0x47,
		/// <summary>Keypad Divide.</summary>
		KeypadDivide = 0x4B,
		/// <summary>Keypad Enter.</summary>
		KeypadEnter = 0x4C,
		/// <summary>Keypad Minus.</summary>
		KeypadMinus = 0x4E,
		/// <summary>Keypad Equals.</summary>
		KeypadEquals = 0x51,
		/// <summary>Keypad0.</summary>
		Keypad0 = 0x52,
		/// <summary>Keypad1.</summary>
		Keypad1 = 0x53,
		/// <summary>Keypad2.</summary>
		Keypad2 = 0x54,
		/// <summary>Keypad3.</summary>
		Keypad3 = 0x55,
		/// <summary>Keypad4.</summary>
		Keypad4 = 0x56,
		/// <summary>Keypad5.</summary>
		Keypad5 = 0x57,
		/// <summary>Keypad6.</summary>
		Keypad6 = 0x58,
		/// <summary>Keypad7.</summary>
		Keypad7 = 0x59,
		/// <summary>Keypad8.</summary>
		Keypad8 = 0x5B,
		/// <summary>Keypad9.</summary>
		Keypad9 = 0x5C,
		/// <summary>Return.</summary>
		Return = 0x24,
		/// <summary>Tab.</summary>
		Tab = 0x30,
		/// <summary>Space.</summary>
		Space = 0x31,
		/// <summary>Delete.</summary>
		Delete = 0x33,
		/// <summary>Escape.</summary>
		Escape = 0x35,
		/// <summary>Command.</summary>
		Command = 0x37,
		/// <summary>Shift.</summary>
		Shift = 0x38,
		/// <summary>Caps Lock.</summary>
		CapsLock = 0x39,
		/// <summary>Option.</summary>
		Option = 0x3A,
		/// <summary>Control.</summary>
		Control = 0x3B,
		RightCommand = 0x36,
		/// <summary>Right Shift.</summary>
		RightShift = 0x3C,
		/// <summary>Right Option.</summary>
		RightOption = 0x3D,
		/// <summary>Right Control.</summary>
		RightControl = 0x3E,
		/// <summary>Function.</summary>
		Function = 0x3F,
		F17 = 0x40,
		/// <summary>Volume Up.</summary>
		VolumeUp = 0x48,
		/// <summary>Volume Down.</summary>
		VolumeDown = 0x49,
		/// <summary>Mute.</summary>
		Mute = 0x4A,
		/// <summary>Forward Delete.</summary>
		ForwardDelete = 0x75,
		/// <summary>I S O Section.</summary>
		ISOSection = 0x0A,
		/// <summary>J I S Yen.</summary>
		JISYen = 0x5D,
		/// <summary>J I S Underscore.</summary>
		JISUnderscore = 0x5E,
		/// <summary>J I S Keypad Comma.</summary>
		JISKeypadComma = 0x5F,
		/// <summary>J I S Eisu.</summary>
		JISEisu = 0x66,
		/// <summary>J I S Kana.</summary>
		JISKana = 0x68,
		/// <summary>F18.</summary>
		F18 = 0x4F,
		/// <summary>F19.</summary>
		F19 = 0x50,
		/// <summary>F20.</summary>
		F20 = 0x5A,
		/// <summary>F5.</summary>
		F5 = 0x60,
		/// <summary>F6.</summary>
		F6 = 0x61,
		/// <summary>F7.</summary>
		F7 = 0x62,
		/// <summary>F3.</summary>
		F3 = 0x63,
		/// <summary>F8.</summary>
		F8 = 0x64,
		/// <summary>F9.</summary>
		F9 = 0x65,
		/// <summary>F11.</summary>
		F11 = 0x67,
		/// <summary>F13.</summary>
		F13 = 0x69,
		/// <summary>F16.</summary>
		F16 = 0x6A,
		/// <summary>F14.</summary>
		F14 = 0x6B,
		/// <summary>F10.</summary>
		F10 = 0x6D,
		/// <summary>F12.</summary>
		F12 = 0x6F,
		/// <summary>F15.</summary>
		F15 = 0x71,
		/// <summary>Help.</summary>
		Help = 0x72,
		/// <summary>Home.</summary>
		Home = 0x73,
		/// <summary>Page Up.</summary>
		PageUp = 0x74,
		/// <summary>F4.</summary>
		F4 = 0x76,
		/// <summary>End.</summary>
		End = 0x77,
		/// <summary>F2.</summary>
		F2 = 0x78,
		/// <summary>Page Down.</summary>
		PageDown = 0x79,
		/// <summary>F1.</summary>
		F1 = 0x7A,
		/// <summary>Left Arrow.</summary>
		LeftArrow = 0x7B,
		/// <summary>Right Arrow.</summary>
		RightArrow = 0x7C,
		/// <summary>Down Arrow.</summary>
		DownArrow = 0x7D,
		/// <summary>Up Arrow.</summary>
		UpArrow = 0x7E,
	}

	// This is an untyped enum in AppKit's NSEvent.h
	[NoMacCatalyst]
	public enum NSFunctionKey : int {
		/// <summary>Up Arrow.</summary>
		UpArrow = 0xF700,
		/// <summary>Down Arrow.</summary>
		DownArrow = 0xF701,
		/// <summary>Left Arrow.</summary>
		LeftArrow = 0xF702,
		/// <summary>Right Arrow.</summary>
		RightArrow = 0xF703,
		/// <summary>F1.</summary>
		F1 = 0xF704,
		/// <summary>F2.</summary>
		F2 = 0xF705,
		/// <summary>F3.</summary>
		F3 = 0xF706,
		/// <summary>F4.</summary>
		F4 = 0xF707,
		/// <summary>F5.</summary>
		F5 = 0xF708,
		/// <summary>F6.</summary>
		F6 = 0xF709,
		/// <summary>F7.</summary>
		F7 = 0xF70A,
		/// <summary>F8.</summary>
		F8 = 0xF70B,
		/// <summary>F9.</summary>
		F9 = 0xF70C,
		/// <summary>F10.</summary>
		F10 = 0xF70D,
		/// <summary>F11.</summary>
		F11 = 0xF70E,
		/// <summary>F12.</summary>
		F12 = 0xF70F,
		/// <summary>F13.</summary>
		F13 = 0xF710,
		/// <summary>F14.</summary>
		F14 = 0xF711,
		/// <summary>F15.</summary>
		F15 = 0xF712,
		/// <summary>F16.</summary>
		F16 = 0xF713,
		/// <summary>F17.</summary>
		F17 = 0xF714,
		/// <summary>F18.</summary>
		F18 = 0xF715,
		/// <summary>F19.</summary>
		F19 = 0xF716,
		/// <summary>F20.</summary>
		F20 = 0xF717,
		/// <summary>F21.</summary>
		F21 = 0xF718,
		/// <summary>F22.</summary>
		F22 = 0xF719,
		/// <summary>F23.</summary>
		F23 = 0xF71A,
		/// <summary>F24.</summary>
		F24 = 0xF71B,
		/// <summary>F25.</summary>
		F25 = 0xF71C,
		/// <summary>F26.</summary>
		F26 = 0xF71D,
		/// <summary>F27.</summary>
		F27 = 0xF71E,
		/// <summary>F28.</summary>
		F28 = 0xF71F,
		/// <summary>F29.</summary>
		F29 = 0xF720,
		/// <summary>F30.</summary>
		F30 = 0xF721,
		/// <summary>F31.</summary>
		F31 = 0xF722,
		/// <summary>F32.</summary>
		F32 = 0xF723,
		/// <summary>F33.</summary>
		F33 = 0xF724,
		/// <summary>F34.</summary>
		F34 = 0xF725,
		/// <summary>F35.</summary>
		F35 = 0xF726,
		/// <summary>Insert.</summary>
		Insert = 0xF727,
		/// <summary>Delete.</summary>
		Delete = 0xF728,
		/// <summary>Home.</summary>
		Home = 0xF729,
		/// <summary>Begin.</summary>
		Begin = 0xF72A,
		/// <summary>End.</summary>
		End = 0xF72B,
		/// <summary>Page Up.</summary>
		PageUp = 0xF72C,
		/// <summary>Page Down.</summary>
		PageDown = 0xF72D,
		/// <summary>Print Screen.</summary>
		PrintScreen = 0xF72E,
		/// <summary>Scroll Lock.</summary>
		ScrollLock = 0xF72F,
		/// <summary>Pause.</summary>
		Pause = 0xF730,
		/// <summary>Sys Req.</summary>
		SysReq = 0xF731,
		/// <summary>Break.</summary>
		Break = 0xF732,
		/// <summary>Reset.</summary>
		Reset = 0xF733,
		/// <summary>Stop.</summary>
		Stop = 0xF734,
		/// <summary>Menu.</summary>
		Menu = 0xF735,
		/// <summary>User.</summary>
		User = 0xF736,
		/// <summary>System.</summary>
		System = 0xF737,
		/// <summary>Print.</summary>
		Print = 0xF738,
		/// <summary>Clear Line.</summary>
		ClearLine = 0xF739,
		/// <summary>Clear Display.</summary>
		ClearDisplay = 0xF73A,
		/// <summary>Insert Line.</summary>
		InsertLine = 0xF73B,
		/// <summary>Delete Line.</summary>
		DeleteLine = 0xF73C,
		/// <summary>Insert Char.</summary>
		InsertChar = 0xF73D,
		/// <summary>Delete Char.</summary>
		DeleteChar = 0xF73E,
		/// <summary>Prev.</summary>
		Prev = 0xF73F,
		/// <summary>Next.</summary>
		Next = 0xF740,
		/// <summary>Select.</summary>
		Select = 0xF741,
		/// <summary>Execute.</summary>
		Execute = 0xF742,
		/// <summary>Undo.</summary>
		Undo = 0xF743,
		/// <summary>Redo.</summary>
		Redo = 0xF744,
		/// <summary>Find.</summary>
		Find = 0xF745,
		/// <summary>Help.</summary>
		Help = 0xF746,
		/// <summary>Mode Switch.</summary>
		ModeSwitch = 0xF747,
	}

	[NoMacCatalyst]
	public enum NSEventSubtype : short {
		/* event subtypes for NSEventTypeAppKitDefined events */
		/// <summary>Window Exposed.</summary>
		WindowExposed = 0,
		/// <summary>Application Activated.</summary>
		ApplicationActivated = 1,
		/// <summary>Application Deactivated.</summary>
		ApplicationDeactivated = 2,
		/// <summary>Window Moved.</summary>
		WindowMoved = 4,
		/// <summary>Screen Changed.</summary>
		ScreenChanged = 8,
		/* event subtypes for NSEventTypeSystemDefined events */
		/* the value is repeated from above */
		PowerOff = 1,

		/* event subtypes for mouse events */
		/* the values are repeated from above */
		MouseEvent = 0, /* NX_SUBTYPE_DEFAULT */
		TabletPoint = 1, /* NX_SUBTYPE_TABLET_POINT */
		TabletProximity = 2, /* NX_SUBTYPE_TABLET_PROXIMITY */
		Touch = 3, /* NX_SUBTYPE_MOUSE_TOUCH */
	}

	#endregion

	#region NSView
	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSViewResizingMask : ulong {
		/// <summary>Not Sizable.</summary>
		NotSizable = 0,
		/// <summary>Min X Margin.</summary>
		MinXMargin = 1,
		/// <summary>Width Sizable.</summary>
		WidthSizable = 2,
		/// <summary>Max X Margin.</summary>
		MaxXMargin = 4,
		/// <summary>Min Y Margin.</summary>
		MinYMargin = 8,
		/// <summary>Height Sizable.</summary>
		HeightSizable = 16,
		/// <summary>Max Y Margin.</summary>
		MaxYMargin = 32,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSBorderType : ulong {
		/// <summary>No Border.</summary>
		NoBorder,
		/// <summary>Line Border.</summary>
		LineBorder,
		/// <summary>Bezel Border.</summary>
		BezelBorder,
		/// <summary>Groove Border.</summary>
		GrooveBorder,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTextFieldBezelStyle : ulong {
		/// <summary>Square.</summary>
		Square,
		/// <summary>Rounded.</summary>
		Rounded,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSViewLayerContentsRedrawPolicy : long {
		/// <summary>Never.</summary>
		Never,
		/// <summary>On Set Needs Display.</summary>
		OnSetNeedsDisplay,
		/// <summary>During View Resize.</summary>
		DuringViewResize,
		/// <summary>Before View Resize.</summary>
		BeforeViewResize,
		Crossfade = 4,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSViewLayerContentsPlacement : long {
		/// <summary>Scale Axes Independently.</summary>
		ScaleAxesIndependently,
		/// <summary>Scale Proportionally To Fit.</summary>
		ScaleProportionallyToFit,
		/// <summary>Scale Proportionally To Fill.</summary>
		ScaleProportionallyToFill,
		/// <summary>Center.</summary>
		Center,
		/// <summary>Top.</summary>
		Top,
		/// <summary>Top Right.</summary>
		TopRight,
		/// <summary>Right.</summary>
		Right,
		/// <summary>Bottom Right.</summary>
		BottomRight,
		/// <summary>Bottom.</summary>
		Bottom,
		/// <summary>Bottom Left.</summary>
		BottomLeft,
		/// <summary>Left.</summary>
		Left,
		/// <summary>Top Left.</summary>
		TopLeft,
	}

	#endregion

	#region NSWindow
	[NoMacCatalyst]
	[Flags]
	[Native ("NSWindowStyleMask")]
	public enum NSWindowStyle : ulong {
		/// <summary>Borderless.</summary>
		Borderless = 0 << 0,
		/// <summary>Titled.</summary>
		Titled = 1 << 0,
		/// <summary>Closable.</summary>
		Closable = 1 << 1,
		/// <summary>Miniaturizable.</summary>
		Miniaturizable = 1 << 2,
		/// <summary>Resizable.</summary>
		Resizable = 1 << 3,
		/// <summary>Utility.</summary>
		Utility = 1 << 4,
		/// <summary>Doc Modal.</summary>
		DocModal = 1 << 6,
		/// <summary>Nonactivating Panel.</summary>
		NonactivatingPanel = 1 << 7,
		/// <summary>Textured Background.</summary>
		[Deprecated (PlatformName.MacOSX, 11, 0, message: "Don't use 'TexturedBackground' anymore.")]
		TexturedBackground = 1 << 8,
		/// <summary>Unified Title And Toolbar.</summary>
		UnifiedTitleAndToolbar = 1 << 12,
		/// <summary>Hud.</summary>
		Hud = 1 << 13,
		/// <summary>Full Screen Window.</summary>
		FullScreenWindow = 1 << 14,
		/// <summary>Full Size Content View.</summary>
		FullSizeContentView = 1 << 15,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSWindowSharingType : ulong {
		/// <summary>None.</summary>
		None,
		/// <summary>Read Only.</summary>
		ReadOnly,
		/// <summary>Read Write.</summary>
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'ReadOnly' instead.")]
		ReadWrite,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSWindowBackingLocation : ulong {
		/// <summary>Default.</summary>
		Default,
		/// <summary>Video Memory.</summary>
		VideoMemory,
		/// <summary>Main Memory.</summary>
		MainMemory,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSWindowCollectionBehavior : ulong {
		/// <summary>Default.</summary>
		Default = 0,
		/// <summary>Can Join All Spaces.</summary>
		CanJoinAllSpaces = 1 << 0,
		/// <summary>Move To Active Space.</summary>
		MoveToActiveSpace = 1 << 1,
		/// <summary>Managed.</summary>
		Managed = 1 << 2,
		/// <summary>Transient.</summary>
		Transient = 1 << 3,
		/// <summary>Stationary.</summary>
		Stationary = 1 << 4,
		/// <summary>Participates In Cycle.</summary>
		ParticipatesInCycle = 1 << 5,
		/// <summary>Ignores Cycle.</summary>
		IgnoresCycle = 1 << 6,
		/// <summary>Full Screen Primary.</summary>
		FullScreenPrimary = 1 << 7,
		/// <summary>Full Screen Auxiliary.</summary>
		FullScreenAuxiliary = 1 << 8,
		/// <summary>Full Screen None.</summary>
		FullScreenNone = 1 << 9,
		/// <summary>Full Screen Allows Tiling.</summary>
		FullScreenAllowsTiling = 1 << 11,
		/// <summary>Full Screen Disallows Tiling.</summary>
		FullScreenDisallowsTiling = 1 << 12,
		Primary = 1 << 16,
		Auxiliary = 1 << 17,
		CanJoinAllApplications = 1 << 18,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSWindowNumberListOptions : ulong {
		/// <summary>All Application.</summary>
		AllApplication = 1 << 0,
		/// <summary>All Spaces.</summary>
		AllSpaces = 1 << 4,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSSelectionDirection : ulong {
		/// <summary>Direct.</summary>
		Direct = 0,
		/// <summary>Next.</summary>
		Next,
		/// <summary>Previous.</summary>
		Previous,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSWindowButton : ulong {
		/// <summary>Close Button.</summary>
		CloseButton,
		/// <summary>Miniaturize Button.</summary>
		MiniaturizeButton,
		/// <summary>Zoom Button.</summary>
		ZoomButton,
		/// <summary>Toolbar Button.</summary>
		ToolbarButton,
		/// <summary>Document Icon Button.</summary>
		DocumentIconButton,
		/// <summary>Document Versions Button.</summary>
		DocumentVersionsButton = 6,
		/// <summary>Full Screen Button.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 12, message: "The standard window button for FullScreenButton is always null; use ZoomButton instead.")]
		FullScreenButton,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSTouchPhase : ulong {
		/// <summary>Began.</summary>
		Began = 1 << 0,
		/// <summary>Moved.</summary>
		Moved = 1 << 1,
		/// <summary>Stationary.</summary>
		Stationary = 1 << 2,
		/// <summary>Ended.</summary>
		Ended = 1 << 3,
		/// <summary>Cancelled.</summary>
		Cancelled = 1 << 4,

		/// <summary>Touching.</summary>
		Touching = Began | Moved | Stationary,
		/// <summary>Any.</summary>
		Any = unchecked((ulong) UInt64.MaxValue),
	}
	#endregion
	#region NSAnimation

	[NoMacCatalyst]
	[Native]
	public enum NSAnimationCurve : ulong {
		/// <summary>Ease In Out.</summary>
		EaseInOut,
		/// <summary>Ease In.</summary>
		EaseIn,
		/// <summary>Ease Out.</summary>
		EaseOut,
		/// <summary>Linear.</summary>
		Linear,
	};

	[NoMacCatalyst]
	[Native]
	public enum NSAnimationBlockingMode : ulong {
		/// <summary>Blocking.</summary>
		Blocking,
		/// <summary>Nonblocking.</summary>
		Nonblocking,
		/// <summary>Nonblocking Threaded.</summary>
		NonblockingThreaded,
	};
	#endregion

	#region NSBox

	[NoMacCatalyst]
	[Native]
	public enum NSTitlePosition : ulong {
		/// <summary>No Title.</summary>
		NoTitle,
		/// <summary>Above Top.</summary>
		AboveTop,
		/// <summary>At Top.</summary>
		AtTop,
		/// <summary>Below Top.</summary>
		BelowTop,
		/// <summary>Above Bottom.</summary>
		AboveBottom,
		/// <summary>At Bottom.</summary>
		AtBottom,
		/// <summary>Below Bottom.</summary>
		BelowBottom,
	};

	[NoMacCatalyst]
	[Native]
	public enum NSBoxType : ulong {
		/// <summary>N S Box Primary.</summary>
		NSBoxPrimary,
		/// <summary>N S Box Secondary.</summary>
		[Obsoleted (PlatformName.MacOSX, 10, 15, message: "Identical to 'NSBoxPrimary'.")]
		NSBoxSecondary,
		/// <summary>N S Box Separator.</summary>
		NSBoxSeparator,
		/// <summary>N S Box Old Style.</summary>
		[Obsoleted (PlatformName.MacOSX, 10, 15, message: "'NSBoxOldStyle' is discouraged. Use 'NSBoxPrimary' or 'NSBoxCustom'.")]
		NSBoxOldStyle,
		/// <summary>N S Box Custom.</summary>
		NSBoxCustom,
	};
	#endregion

	#region NSButtonCell
	[NoMacCatalyst]
	[Native]
	public enum NSButtonType : ulong {
		/// <summary>Momentary Light Button.</summary>
		MomentaryLightButton,
		/// <summary>Push On Push Off.</summary>
		PushOnPushOff,
		/// <summary>Toggle.</summary>
		Toggle,
		/// <summary>Switch.</summary>
		Switch,
		/// <summary>Radio.</summary>
		Radio,
		/// <summary>Momentary Change.</summary>
		MomentaryChange,
		/// <summary>On Off.</summary>
		OnOff,
		/// <summary>Momentary Push In.</summary>
		MomentaryPushIn,
		/// <summary>Accelerator, // 10.10.3.</summary>
		Accelerator, // 10.10.3
		/// <summary>Multi Level Accelerator, // 10.10.3.</summary>
		MultiLevelAccelerator, // 10.10.3
	}

	[NoMacCatalyst]
	[Native]
	public enum NSBezelStyle : ulong {
		Automatic = 0,
		Push = 1,
		FlexiblePush = 2,
		/// <summary>Disclosure.</summary>
		Disclosure = 5,
		/// <summary>Circular.</summary>
		Circular = 7,
		/// <summary>Help Button.</summary>
		HelpButton = 9,
		/// <summary>Small Square.</summary>
		SmallSquare = 10,
		Toolbar = 11,
		AccessoryBarAction = 12,
		AccessoryBar = 13,
		PushDisclosure = 14,
		Badge = 15,
		[Mac (20, 0)]
		Glass = 16,
#if !XAMCORE_5_0
		/// <summary>Rounded.</summary>
		[Obsoleted (PlatformName.MacOSX, 10, 14, message: "Use 'Push' instead.")]
		Rounded = 1,
		/// <summary>Regular Square.</summary>
		[Obsoleted (PlatformName.MacOSX, 10, 14, message: "Use 'FlexiblePush' instead.")]
		RegularSquare = 2,
		/// <summary>Thick Square.</summary>
		[Obsoleted (PlatformName.MacOSX, 10, 12, message: "Use 'FlexiblePush' instead.")]
		ThickSquare = 3,
		/// <summary>Thicker Square.</summary>
		[Obsoleted (PlatformName.MacOSX, 10, 12, message: "Use 'FlexiblePush' instead.")]
		ThickerSquare = 4,
		/// <summary>Shadowless Square.</summary>
		[Obsoleted (PlatformName.MacOSX, 10, 14, message: "Use 'SmallSquare' instead.")]
		ShadowlessSquare = 6,
		/// <summary>Textured Square.</summary>
		[Obsoleted (PlatformName.MacOSX, 10, 14, message: "Use 'SmallSquare' instead.")]
		TexturedSquare = 8,
		/// <summary>Textured Rounded.</summary>
		[Obsoleted (PlatformName.MacOSX, 10, 14, message: "Use 'Toolbar' instead.")]
		TexturedRounded = 11,
		/// <summary>Round Rect.</summary>
		[Obsoleted (PlatformName.MacOSX, 10, 14, message: "Use 'AccessoryBarAction' instead.")]
		RoundRect = 12,
		/// <summary>Recessed.</summary>
		[Obsoleted (PlatformName.MacOSX, 10, 14, message: "Use 'AccessoryBar' instead.")]
		Recessed = 13,
		/// <summary>Rounded Disclosure.</summary>
		[Obsoleted (PlatformName.MacOSX, 10, 14, message: "Use 'PushDisclosure' instead.")]
		RoundedDisclosure = 14,
		/// <summary>Inline.</summary>
		[Obsoleted (PlatformName.MacOSX, 10, 14, message: "Use 'Badge' instead.")]
		Inline = 15,
#endif // !XAMCORE_5_0
	}

	[NoMacCatalyst]
	[Native]
	[Deprecated (PlatformName.MacOSX, 10, 12, message: "The GradientType property is unused, and setting it has no effect.")]
	public enum NSGradientType : ulong {
		/// <summary>None.</summary>
		None,
		/// <summary>Concave Weak.</summary>
		ConcaveWeak,
		/// <summary>Concave Strong.</summary>
		ConcaveStrong,
		/// <summary>Convex Weak.</summary>
		ConvexWeak,
		/// <summary>Convex Strong.</summary>
		ConvexStrong,
	}

	#endregion

	#region NSGraphics
	[NoMacCatalyst]
	// NSGraphics.h:typedef int NSWindowDepth;
	public enum NSWindowDepth : int {
		/// <summary>Twentyfour Bit Rgb.</summary>
		TwentyfourBitRgb = 0x208,
		/// <summary>Sixtyfour Bit Rgb.</summary>
		SixtyfourBitRgb = 0x210,
		/// <summary>One Hundred Twenty Eight Bit Rgb.</summary>
		OneHundredTwentyEightBitRgb = 0x220,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSCompositingOperation : ulong {
		/// <summary>Clear.</summary>
		Clear,
		/// <summary>Copy.</summary>
		Copy,
		/// <summary>Source Over.</summary>
		SourceOver,
		/// <summary>Source In.</summary>
		SourceIn,
		/// <summary>Source Out.</summary>
		SourceOut,
		/// <summary>Source Atop.</summary>
		SourceAtop,
		/// <summary>Destination Over.</summary>
		DestinationOver,
		/// <summary>Destination In.</summary>
		DestinationIn,
		/// <summary>Destination Out.</summary>
		DestinationOut,
		/// <summary>Destination Atop.</summary>
		DestinationAtop,
		/// <summary>Xor.</summary>
		Xor,
		/// <summary>Plus Darker.</summary>
		PlusDarker,
		/// <summary>Highlight.</summary>
		Highlight,
		/// <summary>Plus Lighter.</summary>
		PlusLighter,

		/// <summary>Multiply.</summary>
		Multiply,
		/// <summary>Screen.</summary>
		Screen,
		/// <summary>Overlay.</summary>
		Overlay,
		/// <summary>Darken.</summary>
		Darken,
		/// <summary>Lighten.</summary>
		Lighten,
		/// <summary>Color Dodge.</summary>
		ColorDodge,
		/// <summary>Color Burn.</summary>
		ColorBurn,
		/// <summary>Soft Light.</summary>
		SoftLight,
		/// <summary>Hard Light.</summary>
		HardLight,
		/// <summary>Difference.</summary>
		Difference,
		/// <summary>Exclusion.</summary>
		Exclusion,
		/// <summary>Hue.</summary>
		Hue,
		/// <summary>Saturation.</summary>
		Saturation,
		/// <summary>Color.</summary>
		Color,
		/// <summary>Luminosity.</summary>
		Luminosity,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSAnimationEffect : ulong {
		/// <summary>Dissapearing Item Default.</summary>
		DissapearingItemDefault = 0,
		/// <summary>Effect Poof.</summary>
		EffectPoof = 10,
	}
	#endregion

	#region NSMatrix
	[NoMacCatalyst]
	[Native]
	public enum NSMatrixMode : ulong {
		/// <summary>Radio.</summary>
		Radio,
		/// <summary>Highlight.</summary>
		Highlight,
		/// <summary>List.</summary>
		List,
		/// <summary>Track.</summary>
		Track,
	}
	#endregion

	#region NSBrowser
	[NoMacCatalyst]
	[Native]
	public enum NSBrowserColumnResizingType : ulong {
		/// <summary>None.</summary>
		None,
		/// <summary>Auto.</summary>
		Auto,
		/// <summary>User.</summary>
		User,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSBrowserDropOperation : ulong {
		/// <summary>On.</summary>
		On,
		/// <summary>Above.</summary>
		Above,
	}
	#endregion

	#region NSColorPanel
	[NoMacCatalyst]
	[Native]
	public enum NSColorPanelMode : long {
		/// <summary>None.</summary>
		None = -1,
		/// <summary>Gray.</summary>
		Gray = 0,
		/// <summary>R G B.</summary>
		RGB,
		/// <summary>C M Y K.</summary>
		CMYK,
		/// <summary>H S B.</summary>
		HSB,
		/// <summary>Custom Palette.</summary>
		CustomPalette,
		/// <summary>Color List.</summary>
		ColorList,
		/// <summary>Wheel.</summary>
		Wheel,
		/// <summary>Crayon.</summary>
		Crayon,
	};

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSColorPanelFlags : ulong {
		/// <summary>Gray.</summary>
		Gray = 0x00000001,
		/// <summary>R G B.</summary>
		RGB = 0x00000002,
		/// <summary>C M Y K.</summary>
		CMYK = 0x00000004,
		/// <summary>H S B.</summary>
		HSB = 0x00000008,
		/// <summary>Custom Palette.</summary>
		CustomPalette = 0x00000010,
		/// <summary>Color List.</summary>
		ColorList = 0x00000020,
		/// <summary>Wheel.</summary>
		Wheel = 0x00000040,
		/// <summary>Crayon.</summary>
		Crayon = 0x00000080,
		/// <summary>All.</summary>
		All = 0x0000ffff,
	}


	#endregion
	#region NSDocument

	[NoMacCatalyst]
	[Native]
	public enum NSDocumentChangeType : ulong {
		/// <summary>Done.</summary>
		Done,
		/// <summary>Undone.</summary>
		Undone,
		/// <summary>Cleared.</summary>
		Cleared,
		/// <summary>Read Other Contents.</summary>
		ReadOtherContents,
		/// <summary>Autosaved.</summary>
		Autosaved,
		/// <summary>Redone.</summary>
		Redone,
		/// <summary>Discardable.</summary>
		Discardable = 256, /* New in Lion */
	}

	[NoMacCatalyst]
	[Native]
	public enum NSSaveOperationType : ulong {
		/// <summary>Save.</summary>
		Save,
		/// <summary>Save As.</summary>
		SaveAs,
		/// <summary>Save To.</summary>
		SaveTo,
		/// <summary>Autosave.</summary>
		Autosave = 3,   /* Deprecated name in Lion */
		/// <summary>Elsewhere.</summary>
		Elsewhere = 3,  /* New Lion name */
		/// <summary>In Place.</summary>
		InPlace = 4,    /* New in Lion */
		/// <summary>Auto Save As.</summary>
		AutoSaveAs = 5, /* New in Mountain Lion */
	}

	#endregion

	#region NSBezelPath

	[NoMacCatalyst]
	[Native]
	public enum NSLineCapStyle : ulong {
		/// <summary>Butt.</summary>
		Butt,
		/// <summary>Round.</summary>
		Round,
		/// <summary>Square.</summary>
		Square,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSLineJoinStyle : ulong {
		/// <summary>Miter.</summary>
		Miter,
		/// <summary>Round.</summary>
		Round,
		/// <summary>Bevel.</summary>
		Bevel,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSWindingRule : ulong {
		/// <summary>Non Zero.</summary>
		NonZero,
		/// <summary>Even Odd.</summary>
		EvenOdd,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSBezierPathElement : ulong {
		/// <summary>Move To.</summary>
		MoveTo,
		/// <summary>Line To.</summary>
		LineTo,
		/// <summary>Curve To.</summary>
		CurveTo,
		/// <summary>Close Path.</summary>
		ClosePath,
		[Mac (14, 0)]
		QuadraticCurveTo,
	}
	#endregion

	#region NSRulerView
	[NoMacCatalyst]
	[Native]
	public enum NSRulerOrientation : ulong {
		/// <summary>Horizontal.</summary>
		Horizontal,
		/// <summary>Vertical.</summary>
		Vertical,
	}
	#endregion

	#region NSGestureRecognizer
	[NoMacCatalyst]
	[Native]
	public enum NSGestureRecognizerState : long {
		/// <summary>Possible.</summary>
		Possible,
		/// <summary>Began.</summary>
		Began,
		/// <summary>Changed.</summary>
		Changed,
		/// <summary>Ended.</summary>
		Ended,
		/// <summary>Cancelled.</summary>
		Cancelled,
		/// <summary>Failed.</summary>
		Failed,
		/// <summary>Recognized.</summary>
		Recognized = NSGestureRecognizerState.Ended,
	}
	#endregion

	#region NSStackLayout
	[NoMacCatalyst]
	[Native]
	public enum NSUserInterfaceLayoutOrientation : long {
		/// <summary>Horizontal.</summary>
		Horizontal = 0,
		/// <summary>Vertical.</summary>
		Vertical = 1,
	}

	// NSStackView.h:typedef float NSStackViewVisibilityPriority
	[NoMacCatalyst]
	public enum NSStackViewVisibilityPriority : int {
		/// <summary>Must Hold.</summary>
		MustHold = 1000,
		/// <summary>Detach Only If Necessary.</summary>
		DetachOnlyIfNecessary = 900,
		/// <summary>Not Visible.</summary>
		NotVisible = 0,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSStackViewGravity : long {
		/// <summary>Top.</summary>
		Top = 1,
		/// <summary>Leading.</summary>
		Leading = 1,
		/// <summary>Center.</summary>
		Center = 2,
		/// <summary>Bottom.</summary>
		Bottom = 3,
		/// <summary>Trailing.</summary>
		Trailing = 3,
	}
	#endregion

	[NoMacCatalyst]
	[Native]
	public enum NSStackViewDistribution : long {
		/// <summary>Gravity Areas.</summary>
		GravityAreas = -1,
		/// <summary>Fill.</summary>
		Fill = 0,
		/// <summary>Fill Equally.</summary>
		FillEqually,
		/// <summary>Fill Proportionally.</summary>
		FillProportionally,
		/// <summary>Equal Spacing.</summary>
		EqualSpacing,
		/// <summary>Equal Centering.</summary>
		EqualCentering,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSDragOperation : ulong {
		/// <summary>None.</summary>
		None,
		/// <summary>Copy.</summary>
		Copy = 1,
		/// <summary>Link.</summary>
		Link = 2,
		/// <summary>Generic.</summary>
		Generic = 4,
		/// <summary>Private.</summary>
		Private = 8,
		/// <summary>All Obsolete.</summary>
		AllObsolete = 15,
		/// <summary>Move.</summary>
		Move = 16,
		/// <summary>Delete.</summary>
		Delete = 32,
		/// <summary>All.</summary>
		All = ulong.MaxValue,
	}

	[NoMacCatalyst]
	[Native (ConvertToNative = "NSTextAlignmentExtensions.ToNative", ConvertToManaged = "NSTextAlignmentExtensions.ToManaged")]
	public enum NSTextAlignment : ulong {
		/// <summary>Left.</summary>
		Left = 0,
		/// <summary>Right.</summary>
		Right = 1,
		/// <summary>Center.</summary>
		Center = 2,
		/// <summary>Justified.</summary>
		Justified = 3,
		/// <summary>Natural.</summary>
		Natural = 4,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTextMovement : long {
		/// <summary>Other.</summary>
		Other = 0,
		/// <summary>Return.</summary>
		Return = 0x10,
		/// <summary>Tab.</summary>
		Tab = 0x11,
		/// <summary>Backtab.</summary>
		Backtab = 0x12,
		/// <summary>Left.</summary>
		Left = 0x13,
		/// <summary>Right.</summary>
		Right = 0x14,
		/// <summary>Up.</summary>
		Up = 0x15,
		/// <summary>Down.</summary>
		Down = 0x16,
		/// <summary>Cancel.</summary>
		Cancel = 0x17,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSMenuProperty : ulong {
		/// <summary>Title.</summary>
		Title = 1 << 0,
		/// <summary>Attributed Title.</summary>
		AttributedTitle = 1 << 1,
		/// <summary>Key Equivalent.</summary>
		KeyEquivalent = 1 << 2,
		/// <summary>Image.</summary>
		Image = 1 << 3,
		/// <summary>Enabled.</summary>
		Enabled = 1 << 4,
		/// <summary>Accessibility Description.</summary>
		AccessibilityDescription = 1 << 5,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSFontRenderingMode : ulong {
		/// <summary>Default.</summary>
		Default,
		/// <summary>Antialiased.</summary>
		Antialiased,
		/// <summary>Integer Advancements.</summary>
		IntegerAdvancements,
		/// <summary>Antialiased Integer Advancements.</summary>
		AntialiasedIntegerAdvancements,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSPasteboardReadingOptions : ulong {
		/// <summary>As Data.</summary>
		AsData = 0,
		/// <summary>As String.</summary>
		AsString = 1,
		/// <summary>As Property List.</summary>
		AsPropertyList = 2,
		/// <summary>As Keyed Archive.</summary>
		AsKeyedArchive = 4,
	}

	// Convenience enum, untyped in ObjC
	[NoMacCatalyst]
	public enum NSUnderlinePattern : int {
		/// <summary>Solid.</summary>
		Solid = 0x0000,
		/// <summary>Dot.</summary>
		Dot = 0x0100,
		/// <summary>Dash.</summary>
		Dash = 0x0200,
		/// <summary>Dash Dot.</summary>
		DashDot = 0x0300,
		/// <summary>Dash Dot Dot.</summary>
		DashDotDot = 0x0400,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSSelectionAffinity : ulong {
		/// <summary>Upstream.</summary>
		Upstream,
		/// <summary>Downstream.</summary>
		Downstream,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSSelectionGranularity : ulong {
		/// <summary>Character.</summary>
		Character,
		/// <summary>Word.</summary>
		Word,
		/// <summary>Paragraph.</summary>
		Paragraph,
	}

	#region NSTrackingArea
	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSTrackingAreaOptions : ulong {
		/// <summary>Mouse Entered And Exited.</summary>
		MouseEnteredAndExited = 0x01,
		/// <summary>Mouse Moved.</summary>
		MouseMoved = 0x02,
		/// <summary>Cursor Update.</summary>
		CursorUpdate = 0x04,
		/// <summary>Active When First Responder.</summary>
		ActiveWhenFirstResponder = 0x10,
		/// <summary>Active In Key Window.</summary>
		ActiveInKeyWindow = 0x20,
		/// <summary>Active In Active App.</summary>
		ActiveInActiveApp = 0x40,
		/// <summary>Active Always.</summary>
		ActiveAlways = 0x80,
		/// <summary>Assume Inside.</summary>
		AssumeInside = 0x100,
		/// <summary>In Visible Rect.</summary>
		InVisibleRect = 0x200,
		/// <summary>Enabled During Mouse Drag.</summary>
		EnabledDuringMouseDrag = 0x400,
	}
	#endregion

	[NoMacCatalyst]
	[Native]
	public enum NSLineSweepDirection : ulong {
		/// <summary>N S Line Sweep Left.</summary>
		NSLineSweepLeft,
		/// <summary>N S Line Sweep Right.</summary>
		NSLineSweepRight,
		/// <summary>N S Line Sweep Down.</summary>
		NSLineSweepDown,
		/// <summary>N S Line Sweep Up.</summary>
		NSLineSweepUp,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSLineMovementDirection : ulong {
		/// <summary>None.</summary>
		None,
		/// <summary>Left.</summary>
		Left,
		/// <summary>Right.</summary>
		Right,
		/// <summary>Down.</summary>
		Down,
		/// <summary>Up.</summary>
		Up,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTiffCompression : ulong {
		/// <summary>None.</summary>
		None = 1,
		/// <summary>Ccitt Fax3.</summary>
		CcittFax3 = 3,
		/// <summary>Ccitt Fax4.</summary>
		CcittFax4 = 4,
		/// <summary>Lzw.</summary>
		Lzw = 5,

		/// <summary>Jpeg.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 7)]
		Jpeg = 6,
		/// <summary>Next.</summary>
		Next = 32766,
		/// <summary>Pack Bits.</summary>
		PackBits = 32773,

		/// <summary>Old Jpeg.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 7)]
		OldJpeg = 32865,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSBitmapImageFileType : ulong {
		/// <summary>Tiff.</summary>
		Tiff,
		/// <summary>Bmp.</summary>
		Bmp,
		/// <summary>Gif.</summary>
		Gif,
		/// <summary>Jpeg.</summary>
		Jpeg,
		/// <summary>Png.</summary>
		Png,
		/// <summary>Jpeg2000.</summary>
		Jpeg2000,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSImageRepLoadStatus : long {
		/// <summary>Unknown Type.</summary>
		UnknownType = -1,
		/// <summary>Reading Header.</summary>
		ReadingHeader = -2,
		/// <summary>Will Need All Data.</summary>
		WillNeedAllData = -3,
		/// <summary>Invalid Data.</summary>
		InvalidData = -4,
		/// <summary>Unexpected E O F.</summary>
		UnexpectedEOF = -5,
		/// <summary>Completed.</summary>
		Completed = -6,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSBitmapFormat : ulong {
		/// <summary>Alpha First.</summary>
		AlphaFirst = 1,
		/// <summary>Alpha Nonpremultiplied.</summary>
		AlphaNonpremultiplied = 2,
		/// <summary>Floating Point Samples.</summary>
		FloatingPointSamples = 4,

		/// <summary>Little Endian16 Bit.</summary>
		LittleEndian16Bit = 1 << 8,
		/// <summary>Little Endian32 Bit.</summary>
		LittleEndian32Bit = 1 << 9,
		/// <summary>Big Endian16 Bit.</summary>
		BigEndian16Bit = 1 << 10,
		/// <summary>Big Endian32 Bit.</summary>
		BigEndian32Bit = 1 << 11,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSPrintingOrientation : ulong {
		/// <summary>Portrait.</summary>
		Portrait,
		/// <summary>Landscape.</summary>
		Landscape,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSPrintingPaginationMode : ulong {
		/// <summary>Auto.</summary>
		Auto,
		/// <summary>Fit.</summary>
		Fit,
		/// <summary>Clip.</summary>
		Clip,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSPrinterTableStatus : ulong {
		/// <summary>Ok.</summary>
		Ok,
		/// <summary>Not Found.</summary>
		NotFound,
		/// <summary>Error.</summary>
		Error,
	}

	[NoMacCatalyst]
	[Native]
	[Deprecated (PlatformName.MacOSX, 10, 14)]
	public enum NSScrollArrowPosition : ulong {
		/// <summary>Max End.</summary>
		MaxEnd = 0,
		/// <summary>Min End.</summary>
		MinEnd = 1,
		/// <summary>Default Setting.</summary>
		DefaultSetting = 0,
		/// <summary>None.</summary>
		None = 2,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSUsableScrollerParts : ulong {
		/// <summary>No Scroller.</summary>
		NoScroller,
		/// <summary>Only Arrows.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 14)]
		OnlyArrows,
		/// <summary>All.</summary>
		All,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSScrollerPart : ulong {
		/// <summary>None.</summary>
		None,
		/// <summary>Decrement Page.</summary>
		DecrementPage,
		/// <summary>Knob.</summary>
		Knob,
		/// <summary>Increment Page.</summary>
		IncrementPage,
		/// <summary>Decrement Line.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 14)]
		DecrementLine,
		/// <summary>Increment Line.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 14)]
		IncrementLine,
		/// <summary>Knob Slot.</summary>
		KnobSlot,
	}

	[NoMacCatalyst]
	[Native]
	[Deprecated (PlatformName.MacOSX, 10, 14)]
	public enum NSScrollerArrow : ulong {
		/// <summary>Increment Arrow.</summary>
		IncrementArrow,
		/// <summary>Decrement Arrow.</summary>
		DecrementArrow,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSPrintingPageOrder : long {
		/// <summary>Descending.</summary>
		Descending = -1,
		/// <summary>Special.</summary>
		Special,
		/// <summary>Ascending.</summary>
		Ascending,
		/// <summary>Unknown.</summary>
		Unknown,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSPrintPanelOptions : long {
		/// <summary>Shows Copies.</summary>
		ShowsCopies = 1,
		/// <summary>Shows Page Range.</summary>
		ShowsPageRange = 2,
		/// <summary>Shows Paper Size.</summary>
		ShowsPaperSize = 4,
		/// <summary>Shows Orientation.</summary>
		ShowsOrientation = 8,
		/// <summary>Shows Scaling.</summary>
		ShowsScaling = 16,
		/// <summary>Shows Print Selection.</summary>
		ShowsPrintSelection = 32,
		/// <summary>Shows Page Setup Accessory.</summary>
		ShowsPageSetupAccessory = 256,
		/// <summary>Shows Preview.</summary>
		ShowsPreview = 131072,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTextBlockValueType : ulong {
		/// <summary>Absolute.</summary>
		Absolute,
		/// <summary>Percentage.</summary>
		Percentage,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTextBlockDimension : ulong {
		/// <summary>Width.</summary>
		Width = 0,
		/// <summary>Minimum Width.</summary>
		MinimumWidth = 1,
		/// <summary>Maximum Width.</summary>
		MaximumWidth = 2,
		/// <summary>Height.</summary>
		Height = 4,
		/// <summary>Minimum Height.</summary>
		MinimumHeight = 5,
		/// <summary>Maximum Height.</summary>
		MaximumHeight = 6,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTextBlockLayer : long {
		/// <summary>Padding.</summary>
		Padding = -1,
		/// <summary>Border.</summary>
		Border,
		/// <summary>Margin.</summary>
		Margin,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTextBlockVerticalAlignment : ulong {
		/// <summary>Top.</summary>
		Top,
		/// <summary>Middle.</summary>
		Middle,
		/// <summary>Bottom.</summary>
		Bottom,
		/// <summary>Baseline.</summary>
		Baseline,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTextTableLayoutAlgorithm : ulong {
		/// <summary>Automatic.</summary>
		Automatic,
		/// <summary>Fixed.</summary>
		Fixed,
	}

	[NoMacCatalyst]
	[Flags]
	public enum NSFontSymbolicTraits : int { // uint32_t NSFontSymbolicTraits
		/// <summary>Italic Trait.</summary>
		ItalicTrait = (1 << 0),
		/// <summary>Bold Trait.</summary>
		BoldTrait = (1 << 1),
		/// <summary>Expanded Trait.</summary>
		ExpandedTrait = (1 << 5),
		/// <summary>Condensed Trait.</summary>
		CondensedTrait = (1 << 6),
		/// <summary>Mono Space Trait.</summary>
		MonoSpaceTrait = (1 << 10),
		/// <summary>Vertical Trait.</summary>
		VerticalTrait = (1 << 11),
		/// <summary>U I Optimized Trait.</summary>
		UIOptimizedTrait = (1 << 12),
		/// <summary>Trait Tight Leading.</summary>
		TraitTightLeading = 1 << 15,
		/// <summary>Trait Loose Leading.</summary>
		TraitLooseLeading = 1 << 16,
		TraitEmphasized = BoldTrait,
		/// <summary>Unknown Class.</summary>
		UnknownClass = 0 << 28,
		/// <summary>Old Style Serifs Class.</summary>
		OldStyleSerifsClass = 1 << 28,
		/// <summary>Transitional Serifs Class.</summary>
		TransitionalSerifsClass = 2 << 28,
		/// <summary>Modern Serifs Class.</summary>
		ModernSerifsClass = 3 << 28,
		/// <summary>Clarendon Serifs Class.</summary>
		ClarendonSerifsClass = 4 << 28,
		/// <summary>Slab Serifs Class.</summary>
		SlabSerifsClass = 5 << 28,
		/// <summary>Freeform Serifs Class.</summary>
		FreeformSerifsClass = 7 << 28,
		/// <summary>Sans Serif Class.</summary>
		SansSerifClass = 8 << 28,
		/// <summary>Ornamentals Class.</summary>
		OrnamentalsClass = 9 << 28,
		/// <summary>Scripts Class.</summary>
		ScriptsClass = 10 << 28,
		/// <summary>Symbolic Class.</summary>
		SymbolicClass = 12 << 28,

		/// <summary>Family Class Mask.</summary>
		FamilyClassMask = (int) -268435456,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSFontTraitMask : ulong {
		/// <summary>Italic.</summary>
		Italic = 1,
		/// <summary>Bold.</summary>
		Bold = 2,
		/// <summary>Unbold.</summary>
		Unbold = 4,
		/// <summary>Non Standard Character Set.</summary>
		NonStandardCharacterSet = 8,
		/// <summary>Narrow.</summary>
		Narrow = 0x10,
		/// <summary>Expanded.</summary>
		Expanded = 0x20,
		/// <summary>Condensed.</summary>
		Condensed = 0x40,
		/// <summary>Small Caps.</summary>
		SmallCaps = 0x80,
		/// <summary>Poster.</summary>
		Poster = 0x100,
		/// <summary>Compressed.</summary>
		Compressed = 0x200,
		/// <summary>Fixed Pitch.</summary>
		FixedPitch = 0x400,
		/// <summary>Unitalic.</summary>
		Unitalic = 0x1000000,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSPasteboardWritingOptions : ulong {
		/// <summary>Writing Promised.</summary>
		WritingPromised = 1 << 9,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum NSToolbarDisplayMode : ulong {
		/// <summary>Default.</summary>
		Default,
		/// <summary>Icon And Label.</summary>
		IconAndLabel,
		/// <summary>Icon.</summary>
		Icon,
		/// <summary>Label.</summary>
		Label,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum NSToolbarSizeMode : ulong {
		/// <summary>Default.</summary>
		Default,
		/// <summary>Regular.</summary>
		Regular,
		/// <summary>Small.</summary>
		Small,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTableViewColumnAutoresizingStyle : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Uniform.</summary>
		Uniform,
		/// <summary>Sequential.</summary>
		Sequential,
		/// <summary>Reverse Sequential.</summary>
		ReverseSequential,
		/// <summary>Last Column Only.</summary>
		LastColumnOnly,
		/// <summary>First Column Only.</summary>
		FirstColumnOnly,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTableViewSelectionHighlightStyle : long {
		/// <summary>None.</summary>
		None = -1,
		/// <summary>Regular.</summary>
		Regular = 0,
		/// <summary>Source List.</summary>
		[Deprecated (PlatformName.MacOSX, 11, 0, message: "Set 'NSTableView.Style' to 'NSTableViewStyle.SourceList' instead.")]
		SourceList = 1,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTableViewDraggingDestinationFeedbackStyle : long {
		/// <summary>None.</summary>
		None = -1,
		/// <summary>Regular.</summary>
		Regular = 0,
		/// <summary>Source List.</summary>
		SourceList = 1,
		FeedbackStyleGap = 2,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTableViewDropOperation : ulong {
		/// <summary>On.</summary>
		On,
		/// <summary>Above.</summary>
		Above,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSTableColumnResizing : long {
		/// <summary>None.</summary>
		None = -1,
		/// <summary>Autoresizing.</summary>
		Autoresizing = (1 << 0),
		/// <summary>User Resizing Mask.</summary>
		UserResizingMask = (1 << 1),
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSTableViewGridStyle : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Solid Vertical Line.</summary>
		SolidVerticalLine = 1 << 0,
		/// <summary>Solid Horizontal Line.</summary>
		SolidHorizontalLine = 1 << 1,
		/// <summary>Dashed Horizontal Grid Line.</summary>
		DashedHorizontalGridLine = 1 << 3,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSGradientDrawingOptions : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Before Starting Location.</summary>
		BeforeStartingLocation = (1 << 0),
		/// <summary>After Ending Location.</summary>
		AfterEndingLocation = (1 << 1),
	}

	[NoMacCatalyst]
	[Native]
	public enum NSImageAlignment : ulong {
		/// <summary>Center.</summary>
		Center = 0,
		/// <summary>Top.</summary>
		Top,
		/// <summary>Top Left.</summary>
		TopLeft,
		/// <summary>Top Right.</summary>
		TopRight,
		/// <summary>Left.</summary>
		Left,
		/// <summary>Bottom.</summary>
		Bottom,
		/// <summary>Bottom Left.</summary>
		BottomLeft,
		/// <summary>Bottom Right.</summary>
		BottomRight,
		/// <summary>Right.</summary>
		Right,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSImageFrameStyle : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Photo.</summary>
		Photo,
		/// <summary>Gray Bezel.</summary>
		GrayBezel,
		/// <summary>Groove.</summary>
		Groove,
		/// <summary>Button.</summary>
		Button,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSSpeechBoundary : ulong {
		/// <summary>Immediate.</summary>
		Immediate = 0,
		/// <summary>Word.</summary>
		Word = 1,
		/// <summary>Sentence.</summary>
		Sentence,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSSplitViewDividerStyle : long {
		/// <summary>Thick.</summary>
		Thick = 1,
		/// <summary>Thin.</summary>
		Thin = 2,
		/// <summary>Pane Splitter.</summary>
		PaneSplitter = 3,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSSplitViewItemBehavior : long {
		/// <summary>Default.</summary>
		Default,
		/// <summary>Sidebar.</summary>
		Sidebar,
		/// <summary>Content List.</summary>
		ContentList,
		[Mac (14, 0)]
		Inspector,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSImageScaling : ulong {
		/// <summary>Proportionally Down.</summary>
		ProportionallyDown = 0,
		/// <summary>Axes Independently.</summary>
		AxesIndependently,
		/// <summary>None.</summary>
		None,
		/// <summary>Proportionally Up Or Down.</summary>
		ProportionallyUpOrDown,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSSegmentStyle : long {
		/// <summary>Automatic.</summary>
		Automatic = 0,
		/// <summary>Rounded.</summary>
		Rounded = 1,
		/// <summary>Textured Rounded.</summary>
		TexturedRounded = 2,
		/// <summary>Round Rect.</summary>
		RoundRect = 3,
		/// <summary>Textured Square.</summary>
		TexturedSquare = 4,
		/// <summary>Capsule.</summary>
		Capsule = 5,
		/// <summary>Small Square.</summary>
		SmallSquare = 6,
		/// <summary>Separated.</summary>
		Separated = 8,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSSegmentSwitchTracking : ulong {
		/// <summary>Select One.</summary>
		SelectOne = 0,
		/// <summary>Select Any.</summary>
		SelectAny = 1,
		/// <summary>Momentary.</summary>
		Momentary = 2,
		/// <summary>Momentary Accelerator, // 10.10.3.</summary>
		MomentaryAccelerator, // 10.10.3
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTickMarkPosition : ulong {
		/// <summary>Below.</summary>
		Below,
		/// <summary>Above.</summary>
		Above,
		/// <summary>Left.</summary>
		Left,
		/// <summary>Right.</summary>
		Right,
		/// <summary>Leading.</summary>
		Leading = Left,
		/// <summary>Trailing.</summary>
		Trailing = Right,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSSliderType : ulong {
		/// <summary>Linear.</summary>
		Linear = 0,
		/// <summary>Circular.</summary>
		Circular = 1,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTokenStyle : ulong {
		/// <summary>Default.</summary>
		Default,
		/// <summary>Plain Text.</summary>
		PlainText,
		/// <summary>Rounded.</summary>
		Rounded,
		Squared = 3,
		PlainSquared = 4,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	[Deprecated (PlatformName.MacOSX, 11, 0)]
	public enum NSWorkspaceLaunchOptions : ulong {
		/// <summary>Print.</summary>
		Print = 2,
		WithErrorPresentation = 0x40,
		/// <summary>Inhibiting Background Only.</summary>
		InhibitingBackgroundOnly = 0x80,
		/// <summary>Without Adding To Recents.</summary>
		WithoutAddingToRecents = 0x100,
		/// <summary>Without Activation.</summary>
		WithoutActivation = 0x200,
		/// <summary>Async.</summary>
		Async = 0x10000,
		/// <summary>Allowing Classic Startup.</summary>
		AllowingClassicStartup = 0x20000,
		/// <summary>Preferring Classic.</summary>
		PreferringClassic = 0x40000,
		/// <summary>New Instance.</summary>
		NewInstance = 0x80000,
		/// <summary>Hide.</summary>
		Hide = 0x100000,
		/// <summary>Hide Others.</summary>
		HideOthers = 0x200000,
		/// <summary>Default.</summary>
		Default = Async | AllowingClassicStartup,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSWorkspaceIconCreationOptions : ulong {
		/// <summary>N S Exclude Quick Draw Elements.</summary>
		NSExcludeQuickDrawElements = 1 << 1,
		/// <summary>N S Exclude10_4 Elements.</summary>
		NSExclude10_4Elements = 1 << 2,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSPathStyle : long {
		/// <summary>Standard.</summary>
		Standard,
		/// <summary>Navigation Bar.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 7)]
		NavigationBar,
		/// <summary>Pop Up.</summary>
		PopUp,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTabViewType : ulong {
		/// <summary>N S Top Tabs Bezel Border.</summary>
		NSTopTabsBezelBorder,
		/// <summary>N S Left Tabs Bezel Border.</summary>
		NSLeftTabsBezelBorder,
		/// <summary>N S Bottom Tabs Bezel Border.</summary>
		NSBottomTabsBezelBorder,
		/// <summary>N S Right Tabs Bezel Border.</summary>
		NSRightTabsBezelBorder,
		/// <summary>N S No Tabs Bezel Border.</summary>
		NSNoTabsBezelBorder,
		/// <summary>N S No Tabs Line Border.</summary>
		NSNoTabsLineBorder,
		/// <summary>N S No Tabs No Border.</summary>
		NSNoTabsNoBorder,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTabState : ulong {
		/// <summary>Selected.</summary>
		Selected,
		/// <summary>Background.</summary>
		Background,
		/// <summary>Pressed.</summary>
		Pressed,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTabViewControllerTabStyle : long {
		/// <summary>Segmented Control On Top.</summary>
		SegmentedControlOnTop = 0,
		/// <summary>Segmented Control On Bottom.</summary>
		SegmentedControlOnBottom,
		/// <summary>Toolbar.</summary>
		Toolbar,
		/// <summary>Unspecified.</summary>
		Unspecified = -1,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSLevelIndicatorStyle : ulong {
		/// <summary>Relevancy.</summary>
		Relevancy,
		/// <summary>Continuous Capacity.</summary>
		ContinuousCapacity,
		/// <summary>Discrete Capacity.</summary>
		DiscreteCapacity,
		/// <summary>Rating Level.</summary>
		RatingLevel,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSFontCollectionOptions : long {
		/// <summary>Application Only Mask.</summary>
		ApplicationOnlyMask = 1,
	}

#if XAMCORE_5_0
	[NoMacCatalyst]
#else
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "This enum doesn't exist on this platform.")]
#if __MACCATALYST__
	[EditorBrowsable (EditorBrowsableState.Never)]
#endif
#endif
	[Native]
	public enum NSCollectionViewDropOperation : long {
		/// <summary>On.</summary>
		On = 0,
		/// <summary>Before.</summary>
		Before = 1,
	}

#if XAMCORE_5_0
	[NoMacCatalyst]
#else
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "This enum doesn't exist on this platform.")]
#if __MACCATALYST__
	[EditorBrowsable (EditorBrowsableState.Never)]
#endif
#endif
	[Native]
	public enum NSCollectionViewItemHighlightState : long {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>For Selection.</summary>
		ForSelection = 1,
		/// <summary>For Deselection.</summary>
		ForDeselection = 2,
		/// <summary>As Drop Target.</summary>
		AsDropTarget = 3,
	}

#if XAMCORE_5_0
	[NoMacCatalyst]
#else
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "This enum doesn't exist on this platform.")]
#if __MACCATALYST__
	[EditorBrowsable (EditorBrowsableState.Never)]
#endif
#endif
	[Native]
	[Flags]
	public enum NSCollectionViewScrollPosition : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Top.</summary>
		Top = 1 << 0,
		/// <summary>Centered Vertically.</summary>
		CenteredVertically = 1 << 1,
		/// <summary>Bottom.</summary>
		Bottom = 1 << 2,
		/// <summary>Nearest Horizontal Edge.</summary>
		NearestHorizontalEdge = 1 << 9,
		/// <summary>Left.</summary>
		Left = 1 << 3,
		/// <summary>Centered Horizontally.</summary>
		CenteredHorizontally = 1 << 4,
		/// <summary>Right.</summary>
		Right = 1 << 5,
		/// <summary>Leading Edge.</summary>
		LeadingEdge = 1 << 6,
		/// <summary>Trailing Edge.</summary>
		TrailingEdge = 1 << 7,
		/// <summary>Nearest Vertical Edge.</summary>
		NearestVerticalEdge = 1 << 8,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum NSCollectionElementCategory : long {
		/// <summary>Item.</summary>
		Item,
		/// <summary>Supplementary View.</summary>
		SupplementaryView,
		/// <summary>Decoration View.</summary>
		DecorationView,
		/// <summary>Inter Item Gap.</summary>
		InterItemGap,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSCollectionUpdateAction : long {
		/// <summary>Insert.</summary>
		Insert,
		/// <summary>Delete.</summary>
		Delete,
		/// <summary>Reload.</summary>
		Reload,
		/// <summary>Move.</summary>
		Move,
		/// <summary>None.</summary>
		None,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum NSCollectionViewScrollDirection : long {
		/// <summary>Vertical.</summary>
		Vertical,
		/// <summary>Horizontal.</summary>
		Horizontal,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSDatePickerStyle : ulong {
		/// <summary>Text Field And Stepper.</summary>
		TextFieldAndStepper,
		/// <summary>Clock And Calendar.</summary>
		ClockAndCalendar,
		/// <summary>Text Field.</summary>
		TextField,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSDatePickerMode : ulong {
		/// <summary>Single.</summary>
		Single,
		/// <summary>Range.</summary>
		Range,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSDatePickerElementFlags : ulong {
		/// <summary>Hour Minute.</summary>
		HourMinute = 0xc,
		/// <summary>Hour Minute Second.</summary>
		HourMinuteSecond = 0xe,
		/// <summary>Time Zone.</summary>
		TimeZone = 0x10,

		/// <summary>Year Month Date.</summary>
		YearMonthDate = 0xc0,
		/// <summary>Year Month Date Day.</summary>
		YearMonthDateDay = 0xe0,
		/// <summary>Era.</summary>
		Era = 0x100,
	}

	[NoMacCatalyst]
	[Native]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' Framework instead.")]
	public enum NSOpenGLContextParameter : ulong {
		/// <summary>Swap Rectangle.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 7)]
		SwapRectangle = 200,
		/// <summary>Swap Rectangle Enable.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 7)]
		SwapRectangleEnable = 201,
		/// <summary>Rasterization Enable.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 7)]
		RasterizationEnable = 221,
		/// <summary>State Validation.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 7)]
		StateValidation = 301,
		/// <summary>Surface Surface Volatile.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 7)]
		SurfaceSurfaceVolatile = 306,

		/// <summary>Swap Interval.</summary>
		SwapInterval = 222,
		/// <summary>Surface Order.</summary>
		SurfaceOrder = 235,
		/// <summary>Surface Opacity.</summary>
		SurfaceOpacity = 236,

		/// <summary>Surface Backing Size.</summary>
		SurfaceBackingSize = 304,
		/// <summary>Reclaim Resources.</summary>
		ReclaimResources = 308,
		/// <summary>Current Renderer I D.</summary>
		CurrentRendererID = 309,
		/// <summary>Gpu Vertex Processing.</summary>
		GpuVertexProcessing = 310,
		/// <summary>Gpu Fragment Processing.</summary>
		GpuFragmentProcessing = 311,
		/// <summary>Has Drawable.</summary>
		HasDrawable = 314,
		/// <summary>Mps Swaps In Flight.</summary>
		MpsSwapsInFlight = 315,
	}

	[NoMacCatalyst]
	public enum NSSurfaceOrder {
		/// <summary>Above Window.</summary>
		AboveWindow = 1,
		/// <summary>Below Window.</summary>
		BelowWindow = -1,
	}

	[NoMacCatalyst]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' Framework instead.")]
	public enum NSOpenGLPixelFormatAttribute : uint { // uint32_t NSOpenGLPixelFormatAttribute
		/// <summary>All Renderers.</summary>
		AllRenderers = 1,
		/// <summary>Double Buffer.</summary>
		DoubleBuffer = 5,
		/// <summary>Triple Buffer.</summary>
		TripleBuffer = 3,
		/// <summary>Stereo.</summary>
		Stereo = 6,
		/// <summary>Aux Buffers.</summary>
		AuxBuffers = 7,
		/// <summary>Color Size.</summary>
		ColorSize = 8,
		/// <summary>Alpha Size.</summary>
		AlphaSize = 11,
		/// <summary>Depth Size.</summary>
		DepthSize = 12,
		/// <summary>Stencil Size.</summary>
		StencilSize = 13,
		/// <summary>Accum Size.</summary>
		AccumSize = 14,
		/// <summary>Minimum Policy.</summary>
		MinimumPolicy = 51,
		/// <summary>Maximum Policy.</summary>
		MaximumPolicy = 52,
		/// <summary>Off Screen.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 7)]
		OffScreen = 53,
		/// <summary>Full Screen.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 6)]
		FullScreen = 54,
		/// <summary>Sample Buffers.</summary>
		SampleBuffers = 55,
		/// <summary>Samples.</summary>
		Samples = 56,
		/// <summary>Aux Depth Stencil.</summary>
		AuxDepthStencil = 57,
		/// <summary>Color Float.</summary>
		ColorFloat = 58,
		/// <summary>Multisample.</summary>
		Multisample = 59,
		/// <summary>Supersample.</summary>
		Supersample = 60,
		/// <summary>Sample Alpha.</summary>
		SampleAlpha = 61,
		/// <summary>Renderer I D.</summary>
		RendererID = 70,
		/// <summary>Single Renderer.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 9)]
		SingleRenderer = 71,
		/// <summary>No Recovery.</summary>
		NoRecovery = 72,
		/// <summary>Accelerated.</summary>
		Accelerated = 73,
		/// <summary>Closest Policy.</summary>
		ClosestPolicy = 74,
		/// <summary>Backing Store.</summary>
		BackingStore = 76,
		/// <summary>Window.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 9)]
		Window = 80,
		/// <summary>Compliant.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 9)]
		Compliant = 83,
		/// <summary>Screen Mask.</summary>
		ScreenMask = 84,
		/// <summary>Pixel Buffer.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 7)]
		PixelBuffer = 90,
		/// <summary>Remote Pixel Buffer.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 7)]
		RemotePixelBuffer = 91,
		/// <summary>Allow Offline Renderers.</summary>
		AllowOfflineRenderers = 96,
		/// <summary>Accelerated Compute.</summary>
		AcceleratedCompute = 97,

		// Specify the profile
		/// <summary>Open G L Profile.</summary>
		OpenGLProfile = 99,
		/// <summary>Virtual Screen Count.</summary>
		VirtualScreenCount = 128,

		/// <summary>Robust.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 5)]
		Robust = 75,
		/// <summary>M P Safe.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 5)]
		MPSafe = 78,
		/// <summary>Multi Screen.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 5)]
		MultiScreen = 81,
	}

	[NoMacCatalyst]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' Framework instead.")]
	public enum NSOpenGLProfile : int {
		/// <summary>Version Legacy.</summary>
		VersionLegacy = 0x1000, // Legacy
		/// <summary>Version3_2 Core.</summary>
		Version3_2Core = 0x3200,  // 3.2 or better
		/// <summary>Version4_1 Core.</summary>
		Version4_1Core = 0x4100,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSAlertButtonReturn : long {
		/// <summary>First.</summary>
		First = 1000,
		/// <summary>Second.</summary>
		Second = 1001,
		/// <summary>Third.</summary>
		Third = 1002,
	}

	[NoMacCatalyst]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' Framework instead.")]
	public enum NSOpenGLGlobalOption : uint {
		/// <summary>Format Cache Size.</summary>
		FormatCacheSize = 501,
		/// <summary>Clear Format Cache.</summary>
		ClearFormatCache = 502,
		/// <summary>Retain Renderers.</summary>
		RetainRenderers = 503,
		/// <summary>Use Build Cache.</summary>
		UseBuildCache = 506,
		/// <summary>Reset Library.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 4)]
		ResetLibrary = 504,
	}

	[NoMacCatalyst]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' Framework instead.")]
	public enum NSGLTextureTarget : uint {
		/// <summary>T2 D.</summary>
		T2D = 0x0de1,
		/// <summary>Cube Map.</summary>
		CubeMap = 0x8513,
		/// <summary>Rectangle Ext.</summary>
		RectangleExt = 0x84F5,
	}

	[NoMacCatalyst]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' Framework instead.")]
	public enum NSGLFormat : uint {
		/// <summary>R G B.</summary>
		RGB = 0x1907,
		/// <summary>R G B A.</summary>
		RGBA = 0x1908,
		/// <summary>Depth Component.</summary>
		DepthComponent = 0x1902,
	}

	[NoMacCatalyst]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' Framework instead.")]
	public enum NSGLTextureCubeMap : uint {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Positive X.</summary>
		PositiveX = 0x8515,
		/// <summary>Positive Y.</summary>
		PositiveY = 0x8517,
		/// <summary>Positive Z.</summary>
		PositiveZ = 0x8519,
		/// <summary>Negative X.</summary>
		NegativeX = 0x8516,
		/// <summary>Negative Y.</summary>
		NegativeY = 0x8517,
		/// <summary>Negative Z.</summary>
		NegativeZ = 0x851A,
	}

	[NoMacCatalyst]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' Framework instead.")]
	public enum NSGLColorBuffer : uint {
		/// <summary>Front.</summary>
		Front = 0x0404,
		/// <summary>Back.</summary>
		Back = 0x0405,
		/// <summary>Aux0.</summary>
		Aux0 = 0x0409,
	}

	[NoMacCatalyst]
	[Native]
	[Deprecated (PlatformName.MacOSX, 10, 14)]
	public enum NSProgressIndicatorThickness : ulong {
		/// <summary>Small.</summary>
		Small = 10,
		/// <summary>Regular.</summary>
		Regular = 14,
		/// <summary>Aqua.</summary>
		Aqua = 12,
		/// <summary>Large.</summary>
		Large = 18,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSProgressIndicatorStyle : ulong {
		/// <summary>Bar.</summary>
		Bar,
		/// <summary>Spinning.</summary>
		Spinning,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSPopUpArrowPosition : ulong {
		/// <summary>None.</summary>
		None,
		/// <summary>Center.</summary>
		Center,
		/// <summary>Bottom.</summary>
		Bottom,
	}

	// FileType 4cc values to use with NSFileTypeForHFSTypeCode.
	[MacCatalyst (15, 0)]
	public enum HfsTypeCode : uint {
		/* Generic Finder icons */
		ClipboardIcon = 0x434C4950,   //'CLIP'
		ClippingUnknownTypeIcon = 0x636C7075,   //'clpu'
		ClippingPictureTypeIcon = 0x636C7070,   //'clpp'
		ClippingTextTypeIcon = 0x636C7074,   //'clpt'
		ClippingSoundTypeIcon = 0x636C7073,   //'clps'
		DesktopIcon = 0x6465736B,   //'desk'
		FinderIcon = 0x464E4452,   //'FNDR'
		ComputerIcon = 0x726F6F74,   //'root'
		FontSuitcaseIcon = 0x4646494C,   //'FFIL'
		FullTrashIcon = 0x66747268,   //'ftrh'
		GenericApplicationIcon = 0x4150504C,   //'APPL'
		GenericCdromIcon = 0x63646472,   //'cddr'
		GenericControlPanelIcon = 0x41505043,   //'APPC'
		GenericControlStripModuleIcon = 0x73646576,   //'sdev'
		GenericComponentIcon = 0x74686E67,   //'thng'
		GenericDeskAccessoryIcon = 0x41505044,   //'APPD'
		GenericDocumentIcon = 0x646F6375,   //'docu'
		GenericEditionFileIcon = 0x65647466,   //'edtf'
		GenericExtensionIcon = 0x494E4954,   //'INIT'
		GenericFileServerIcon = 0x73727672,   //'srvr'
		GenericFontIcon = 0x6666696C,   //'ffil'
		GenericFontScalerIcon = 0x73636C72,   //'sclr'
		GenericFloppyIcon = 0x666C7079,   //'flpy'
		GenericHardDiskIcon = 0x6864736B,   //'hdsk'
		GenericIDiskIcon = 0x6964736B,   //'idsk'
		GenericRemovableMediaIcon = 0x726D6F76,   //'rmov'
		GenericMoverObjectIcon = 0x6D6F7672,   //'movr'
		GenericPCCardIcon = 0x70636D63,   //'pcmc'
		GenericPreferencesIcon = 0x70726566,   //'pref'
		GenericQueryDocumentIcon = 0x71657279,   //'qery'
		GenericRamDiskIcon = 0x72616D64,   //'ramd'
		GenericSharedLibraryIcon = 0x73686C62,   //'shlb'
		GenericStationeryIcon = 0x73646F63,   //'sdoc'
		GenericSuitcaseIcon = 0x73756974,   //'suit'
		GenericUrlIcon = 0x6775726C,   //'gurl'
		GenericWormIcon = 0x776F726D,   //'worm'
		InternationalResourcesIcon = 0x6966696C,   //'ifil'
		KeyboardLayoutIcon = 0x6B66696C,   //'kfil'
		SoundFileIcon = 0x7366696C,   //'sfil'
		SystemSuitcaseIcon = 0x7A737973,   //'zsys'
		TrashIcon = 0x74727368,   //'trsh'
		TrueTypeFontIcon = 0x7466696C,   //'tfil'
		TrueTypeFlatFontIcon = 0x73666E74,   //'sfnt'
		TrueTypeMultiFlatFontIcon = 0x74746366,   //'ttcf'
		UserIDiskIcon = 0x7564736B,   //'udsk'
		UnknownFSObjectIcon = 0x756E6673,   //'unfs'

		/* Internet locations */
		InternetLocationHttpIcon = 0x696C6874,   //'ilht'
		InternetLocationFtpIcon = 0x696C6674,   //'ilft'
		InternetLocationAppleShareIcon = 0x696C6166,   //'ilaf'
		InternetLocationAppleTalkZoneIcon = 0x696C6174,   //'ilat'
		InternetLocationFileIcon = 0x696C6669,   //'ilfi'
		InternetLocationMailIcon = 0x696C6D61,   //'ilma'
		InternetLocationNewsIcon = 0x696C6E77,   //'ilnw'
		InternetLocationNslNeighborhoodIcon = 0x696C6E73,   //'ilns'
		InternetLocationGenericIcon = 0x696C6765,   //'ilge'

		/* Folders */
		GenericFolderIcon = 0x666C6472,   //'fldr'
		DropFolderIcon = 0x64626F78,   //'dbox'
		MountedFolderIcon = 0x6D6E7464,   //'mntd'
		OpenFolderIcon = 0x6F666C64,   //'ofld'
		OwnedFolderIcon = 0x6F776E64,   //'ownd'
		PrivateFolderIcon = 0x70727666,   //'prvf'
		SharedFolderIcon = 0x7368666C,   //'shfl'

		/* Sharingprivileges icons */
		SharingPrivsNotApplicableIcon = 0x73686E61,   //'shna'
		SharingPrivsReadOnlyIcon = 0x7368726F,   //'shro'
		SharingPrivsReadWriteIcon = 0x73687277,   //'shrw'
		SharingPrivsUnknownIcon = 0x7368756B,   //'shuk'
		SharingPrivsWritableIcon = 0x77726974,   //'writ'

		/* Users and Groups icons */
		UserFolderIcon = 0x75666C64,   //'ufld'
		WorkgroupFolderIcon = 0x77666C64,   //'wfld'
		GuestUserIcon = 0x67757372,   //'gusr'
		UserIcon = 0x75736572,   //'user'
		OwnerIcon = 0x73757372,   //'susr'
		GroupIcon = 0x67727570,   //'grup'

		/* Special folders */
		AppearanceFolderIcon = 0x61707072,   //'appr'
		AppleMenuFolderIcon = 0x616D6E75,   //'amnu'
		ApplicationsFolderIcon = 0x61707073,   //'apps'
		ApplicationSupportFolderIcon = 0x61737570,   //'asup'
		ColorSyncFolderIcon = 0x70726F66,   //'prof'
		ContextualMenuItemsFolderIcon = 0x636D6E75,   //'cmnu'
		ControlPanelDisabledFolderIcon = 0x63747244,   //'ctrD'
		ControlPanelFolderIcon = 0x6374726C,   //'ctrl'
		DocumentsFolderIcon = 0x646F6373,   //'docs'
		ExtensionsDisabledFolderIcon = 0x65787444,   //'extD'
		ExtensionsFolderIcon = 0x6578746E,   //'extn'
		FavoritesFolderIcon = 0x66617673,   //'favs'
		FontsFolderIcon = 0x666F6E74,   //'font'
		InternetSearchSitesFolderIcon = 0x69737366,   //'issf'
		PublicFolderIcon = 0x70756266,   //'pubf'
		PrinterDescriptionFolderIcon = 0x70706466,   //'ppdf'
		PrintMonitorFolderIcon = 0x70726E74,   //'prnt'
		RecentApplicationsFolderIcon = 0x72617070,   //'rapp'
		RecentDocumentsFolderIcon = 0x72646F63,   //'rdoc'
		RecentServersFolderIcon = 0x72737276,   //'rsrv'
		ShutdownItemsDisabledFolderIcon = 0x73686444,   //'shdD'
		ShutdownItemsFolderIcon = 0x73686466,   //'shdf'
		SpeakableItemsFolder = 0x73706B69,   //'spki'
		StartupItemsDisabledFolderIcon = 0x73747244,   //'strD'
		StartupItemsFolderIcon = 0x73747274,   //'strt'
		SystemExtensionDisabledFolderIcon = 0x6D616344,   //'macD'
		SystemFolderIcon = 0x6D616373,   //'macs'
		VoicesFolderIcon = 0x66766F63,   //'fvoc'

		/* Badges */
		AppleScriptBadgeIcon = 0x73637270,   //'scrp'
		LockedBadgeIcon = 0x6C626467,   //'lbdg'
		MountedBadgeIcon = 0x6D626467,   //'mbdg'
		SharedBadgeIcon = 0x73626467,   //'sbdg'
		AliasBadgeIcon = 0x61626467,   //'abdg'
		AlertCautionBadgeIcon = 0x63626467,   //'cbdg'

		/* Alert icons */
		AlertNoteIcon = 0x6E6F7465,   //'note'
		AlertCautionIcon = 0x63617574,   //'caut'
		AlertStopIcon = 0x73746F70,   //'stop'

		/* Networking icons */
		AppleTalkIcon = 0x61746C6B,   //'atlk'
		AppleTalkZoneIcon = 0x61747A6E,   //'atzn'
		AfpServerIcon = 0x61667073,   //'afps'
		FtpServerIcon = 0x66747073,   //'ftps'
		HttpServerIcon = 0x68747073,   //'htps'
		GenericNetworkIcon = 0x676E6574,   //'gnet'
		IPFileServerIcon = 0x69737276,   //'isrv'

		/* Toolbar icons */
		ToolbarCustomizeIcon = 0x74637573,   //'tcus'
		ToolbarDeleteIcon = 0x7464656C,   //'tdel'
		ToolbarFavoritesIcon = 0x74666176,   //'tfav'
		ToolbarHomeIcon = 0x74686F6D,   //'thom'
		ToolbarAdvancedIcon = 0x74626176,   //'tbav'
		ToolbarInfoIcon = 0x7462696E,   //'tbin'
		ToolbarLabelsIcon = 0x74626C62,   //'tblb'
		ToolbarApplicationsFolderIcon = 0x74417073,   //'tAps'
		ToolbarDocumentsFolderIcon = 0x74446F63,   //'tDoc'
		ToolbarMovieFolderIcon = 0x744D6F76,   //'tMov'
		ToolbarMusicFolderIcon = 0x744D7573,   //'tMus'
		ToolbarPicturesFolderIcon = 0x74506963,   //'tPic'
		ToolbarPublicFolderIcon = 0x74507562,   //'tPub'
		ToolbarDesktopFolderIcon = 0x7444736B,   //'tDsk'
		ToolbarDownloadsFolderIcon = 0x7444776E,   //'tDwn'
		ToolbarLibraryFolderIcon = 0x744C6962,   //'tLib'
		ToolbarUtilitiesFolderIcon = 0x7455746C,   //'tUtl'
		ToolbarSitesFolderIcon = 0x74537473,   //'tSts'

		/* Other icons */
		AppleLogoIcon = 0x6361706C,   //'capl'
		AppleMenuIcon = 0x7361706C,   //'sapl'
		BackwardArrowIcon = 0x6261726F,   //'baro'
		FavoriteItemsIcon = 0x66617672,   //'favr'
		ForwardArrowIcon = 0x6661726F,   //'faro'
		GridIcon = 0x67726964,   //'grid'
		HelpIcon = 0x68656C70,   //'help'
		KeepArrangedIcon = 0x61726E67,   //'arng'
		LockedIcon = 0x6C6F636B,   //'lock'
		NoFilesIcon = 0x6E66696C,   //'nfil'
		NoFolderIcon = 0x6E666C64,   //'nfld'
		NoWriteIcon = 0x6E777274,   //'nwrt'
		ProtectedApplicationFolderIcon = 0x70617070,   //'papp'
		ProtectedSystemFolderIcon = 0x70737973,   //'psys'
		RecentItemsIcon = 0x72636E74,   //'rcnt'
		ShortcutIcon = 0x73687274,   //'shrt'
		SortAscendingIcon = 0x61736E64,   //'asnd'
		SortDescendingIcon = 0x64736E64,   //'dsnd'
		UnlockedIcon = 0x756C636B,   //'ulck'
		ConnectToIcon = 0x636E6374,   //'cnct'
		GenericWindowIcon = 0x6777696E,   //'gwin'
		QuestionMarkIcon = 0x71756573,   //'ques'
		DeleteAliasIcon = 0x64616C69,   //'dali'
		EjectMediaIcon = 0x656A6563,   //'ejec'
		BurningIcon = 0x6275726E,   //'burn'
		RightContainerArrowIcon = 0x72636172,   //'rcar'
	}

	// These constants specify the possible states of a drawer.
	[NoMacCatalyst]
	[Native]
	[Deprecated (PlatformName.MacOSX, 10, 13, message: "Use 'NSSplitViewController' instead.")]
	public enum NSDrawerState : ulong {
		/// <summary>Closed.</summary>
		Closed = 0,
		/// <summary>Opening.</summary>
		Opening = 1,
		/// <summary>Open.</summary>
		Open = 2,
		/// <summary>Closing.</summary>
		Closing = 3,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSWindowLevel : long {
		/// <summary>Normal.</summary>
		Normal = 0,
		/// <summary>Dock.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 13)]
		Dock = 20,
		/// <summary>Floating.</summary>
		Floating = 3,
		/// <summary>Main Menu.</summary>
		MainMenu = 24,
		/// <summary>Modal Panel.</summary>
		ModalPanel = 8,
		/// <summary>Pop Up Menu.</summary>
		PopUpMenu = 101,
		/// <summary>Screen Saver.</summary>
		ScreenSaver = 1000,
		/// <summary>Status.</summary>
		Status = 25,
		/// <summary>Submenu.</summary>
		Submenu = 3,
		/// <summary>Torn Off Menu.</summary>
		TornOffMenu = 3,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSRuleEditorRowType : ulong {
		/// <summary>Simple.</summary>
		Simple = 0,
		/// <summary>Compound.</summary>
		Compound,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSRuleEditorNestingMode : ulong {
		/// <summary>Single.</summary>
		Single,
		/// <summary>List.</summary>
		List,
		/// <summary>Compound.</summary>
		Compound,
		/// <summary>Simple.</summary>
		Simple,
	}

	[NoMacCatalyst]
	[Native]
	[Deprecated (PlatformName.MacOSX, 10, 11, message: "Use 'NSGlyphProperty' instead.")]
	public enum NSGlyphInscription : ulong {
		/// <summary>Base.</summary>
		Base,
		/// <summary>Below.</summary>
		Below,
		/// <summary>Above.</summary>
		Above,
		/// <summary>Overstrike.</summary>
		Overstrike,
		/// <summary>Over Below.</summary>
		OverBelow,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTypesetterBehavior : long {
		/// <summary>Latest.</summary>
		Latest = -1,
		/// <summary>Original.</summary>
		Original = 0,
		/// <summary>Specific_10_2_ With Compatibility.</summary>
		Specific_10_2_WithCompatibility = 1,
		/// <summary>Specific_10_2.</summary>
		Specific_10_2 = 2,
		/// <summary>Specific_10_3.</summary>
		Specific_10_3 = 3,
		/// <summary>Specific_10_4.</summary>
		Specific_10_4 = 4,

	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSRemoteNotificationType : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Badge.</summary>
		Badge = 1 << 0,
		/// <summary>Sound.</summary>
		Sound = 1 << 1,
		/// <summary>Alert.</summary>
		Alert = 1 << 2,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSScrollViewFindBarPosition : long {
		/// <summary>Above Horizontal Ruler.</summary>
		AboveHorizontalRuler = 0,
		/// <summary>Above Content.</summary>
		AboveContent,
		/// <summary>Below Content.</summary>
		BelowContent,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSScrollerStyle : long {
		/// <summary>Legacy.</summary>
		Legacy = 0,
		/// <summary>Overlay.</summary>
		Overlay,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSScrollElasticity : long {
		/// <summary>Automatic.</summary>
		Automatic = 0,
		/// <summary>None.</summary>
		None,
		/// <summary>Allowed.</summary>
		Allowed,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSScrollerKnobStyle : long {
		/// <summary>Default.</summary>
		Default = 0,
		/// <summary>Dark.</summary>
		Dark = 1,
		/// <summary>Light.</summary>
		Light = 2,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSEventPhase : ulong {
		/// <summary>None.</summary>
		None,
		/// <summary>Began.</summary>
		Began = 1,
		/// <summary>Stationary.</summary>
		Stationary = 2,
		/// <summary>Changed.</summary>
		Changed = 4,
		/// <summary>Ended.</summary>
		Ended = 8,
		/// <summary>Cancelled.</summary>
		Cancelled = 16,
		/// <summary>May Begin.</summary>
		MayBegin = 32,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSEventSwipeTrackingOptions : ulong {
		/// <summary>Lock Direction.</summary>
		LockDirection = 1,
		/// <summary>Clamp Gesture Amount.</summary>
		ClampGestureAmount = 2,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSEventGestureAxis : long {
		/// <summary>None.</summary>
		None,
		/// <summary>Horizontal.</summary>
		Horizontal,
		/// <summary>Vertical.</summary>
		Vertical,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSLayoutConstraintOrientation : long {
		/// <summary>Horizontal.</summary>
		Horizontal,
		/// <summary>Vertical.</summary>
		Vertical,
	}

	[NoMacCatalyst]
	public enum NSLayoutPriority : int /*float*/ {
		/// <summary>Required.</summary>
		Required = 1000,
		/// <summary>Default High.</summary>
		DefaultHigh = 750,
		/// <summary>Drag That Can Resize Window.</summary>
		DragThatCanResizeWindow = 510,
		/// <summary>Window Size Stay Put.</summary>
		WindowSizeStayPut = 500,
		/// <summary>Drag That Cannot Resize Window.</summary>
		DragThatCannotResizeWindow = 490,
		/// <summary>Default Low.</summary>
		DefaultLow = 250,
		/// <summary>Fitting Size Compression.</summary>
		FittingSizeCompression = 50,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSPopoverAppearance : long {
		/// <summary>Minimal.</summary>
		Minimal,
		/// <summary>H U D.</summary>
		HUD,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSPopoverBehavior : long {
		/// <summary>Application Defined.</summary>
		ApplicationDefined,
		/// <summary>Transient.</summary>
		Transient,
		/// <summary>Semitransient.</summary>
		Semitransient,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTableViewRowSizeStyle : long {
		/// <summary>Default.</summary>
		Default = -1,
		/// <summary>Custom.</summary>
		Custom = 0,
		/// <summary>Small.</summary>
		Small,
		/// <summary>Medium.</summary>
		Medium,
		/// <summary>Large.</summary>
		Large,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTableRowActionEdge : long {
		/// <summary>Leading.</summary>
		Leading,
		/// <summary>Trailing.</summary>
		Trailing,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTableViewRowActionStyle : long {
		/// <summary>Regular.</summary>
		Regular,
		/// <summary>Destructive.</summary>
		Destructive,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSTableViewAnimation : ulong {
		/// <summary>None.</summary>
		None,
		/// <summary>Fade.</summary>
		Fade = 1,
		/// <summary>Gap.</summary>
		Gap = 2,
		/// <summary>Slide Up.</summary>
		SlideUp = 0x10,
		/// <summary>Slide Down.</summary>
		SlideDown = 0x20,
		/// <summary>Slide Left.</summary>
		SlideLeft = 0x30,
		/// <summary>Slide Right.</summary>
		SlideRight = 0x40,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSDraggingItemEnumerationOptions : ulong {
		/// <summary>Concurrent.</summary>
		Concurrent = 1 << 0,
		/// <summary>Clear Nonenumerated Images.</summary>
		ClearNonenumeratedImages = 1 << 16,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSDraggingFormation : long {
		/// <summary>Default.</summary>
		Default,
		/// <summary>None.</summary>
		None,
		/// <summary>Pile.</summary>
		Pile,
		/// <summary>List.</summary>
		List,
		/// <summary>Stack.</summary>
		Stack,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSDraggingContext : long {
		/// <summary>Outside Application.</summary>
		OutsideApplication,
		/// <summary>Within Application.</summary>
		WithinApplication,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSWindowAnimationBehavior : long {
		/// <summary>Default.</summary>
		Default = 0,
		/// <summary>None.</summary>
		None = 2,
		/// <summary>Document Window.</summary>
		DocumentWindow,
		/// <summary>Utility Window.</summary>
		UtilityWindow,
		/// <summary>Alert Panel.</summary>
		AlertPanel,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTextFinderAction : long {
		/// <summary>Show Find Interface.</summary>
		ShowFindInterface = 1,
		/// <summary>Next Match.</summary>
		NextMatch = 2,
		/// <summary>Previous Match.</summary>
		PreviousMatch = 3,
		/// <summary>Replace All.</summary>
		ReplaceAll = 4,
		/// <summary>Replace.</summary>
		Replace = 5,
		/// <summary>Replace And Find.</summary>
		ReplaceAndFind = 6,
		/// <summary>Set Search String.</summary>
		SetSearchString = 7,
		/// <summary>Replace All In Selection.</summary>
		ReplaceAllInSelection = 8,
		/// <summary>Select All.</summary>
		SelectAll = 9,
		/// <summary>Select All In Selection.</summary>
		SelectAllInSelection = 10,
		/// <summary>Hide Find Interface.</summary>
		HideFindInterface = 11,
		/// <summary>Show Replace Interface.</summary>
		ShowReplaceInterface = 12,
		/// <summary>Hide Replace Interface.</summary>
		HideReplaceInterface = 13,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSFontPanelMode : ulong {
		/// <summary>Face Mask.</summary>
		FaceMask = 1 << 0,
		/// <summary>Size Mask.</summary>
		SizeMask = 1 << 1,
		/// <summary>Collection Mask.</summary>
		CollectionMask = 1 << 2,
		/// <summary>Underline Effect Mask.</summary>
		UnderlineEffectMask = 1 << 8,
		/// <summary>Strikethrough Effect Mask.</summary>
		StrikethroughEffectMask = 1 << 9,
		/// <summary>Text Color Effect Mask.</summary>
		TextColorEffectMask = 1 << 10,
		/// <summary>Document Color Effect Mask.</summary>
		DocumentColorEffectMask = 1 << 11,
		/// <summary>Shadow Effect Mask.</summary>
		ShadowEffectMask = 1 << 12,
		/// <summary>All Effects Mask.</summary>
		AllEffectsMask = 0XFFF00,
		/// <summary>Standard Mask.</summary>
		StandardMask = 0xFFFF,
		/// <summary>All Modes Mask.</summary>
		AllModesMask = unchecked((ulong) UInt32.MaxValue),
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSFontCollectionVisibility : ulong {
		/// <summary>Process.</summary>
		Process = 1 << 0,
		/// <summary>User.</summary>
		User = 1 << 1,
		/// <summary>Computer.</summary>
		Computer = 1 << 2,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSSharingContentScope : long {
		/// <summary>Item.</summary>
		Item,
		/// <summary>Partial.</summary>
		Partial,
		/// <summary>Full.</summary>
		Full,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSTypesetterControlCharacterAction : ulong {
		/// <summary>Zero Advancement.</summary>
		ZeroAdvancement = 1 << 0,
		/// <summary>Whitespace.</summary>
		Whitespace = 1 << 1,
		/// <summary>Horizontal Tab.</summary>
		HorizontalTab = 1 << 2,
		/// <summary>Line Break.</summary>
		LineBreak = 1 << 3,
		/// <summary>Paragraph Break.</summary>
		ParagraphBreak = 1 << 4,
		/// <summary>Container Break.</summary>
		ContainerBreak = 1 << 5,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSPageControllerTransitionStyle : long {
		/// <summary>Stack History.</summary>
		StackHistory,
		/// <summary>Stack Book.</summary>
		StackBook,
		/// <summary>Horizontal Strip.</summary>
		HorizontalStrip,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSWindowTitleVisibility : long {
		/// <summary>Visible.</summary>
		Visible = 0,
		/// <summary>Hidden.</summary>
		Hidden = 1,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSViewControllerTransitionOptions : ulong {
		/// <summary>None.</summary>
		None = 0x0,
		/// <summary>Crossfade.</summary>
		Crossfade = 0x1,
		/// <summary>Slide Up.</summary>
		SlideUp = 0x10,
		/// <summary>Slide Down.</summary>
		SlideDown = 0x20,
		/// <summary>Slide Left.</summary>
		SlideLeft = 0x40,
		/// <summary>Slide Right.</summary>
		SlideRight = 0x80,
		/// <summary>Slide Forward.</summary>
		SlideForward = 0x140,
		/// <summary>Slide Backward.</summary>
		SlideBackward = 0x180,
		/// <summary>Allow User Interaction.</summary>
		AllowUserInteraction = 0x1000,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSApplicationOcclusionState : ulong {
		/// <summary>Visible.</summary>
		Visible = 1 << 1,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSWindowOcclusionState : ulong {
		/// <summary>Visible.</summary>
		Visible = 1 << 1,
	}



	#region NSVisualEffectView
	[NoMacCatalyst]
	[Native]
	public enum NSVisualEffectMaterial : long {
		/// <summary>Appearance Based.</summary>
		[Advice ("Use a specific material instead.")]
		AppearanceBased,
		/// <summary>Light.</summary>
		[Advice ("Use a semantic material instead.")]
		Light,
		/// <summary>Dark.</summary>
		[Advice ("Use a semantic material instead.")]
		Dark,
		/// <summary>Titlebar.</summary>
		Titlebar,
		/// <summary>Selection.</summary>
		Selection,
		/// <summary>Menu.</summary>
		Menu,
		/// <summary>Popover.</summary>
		Popover,
		/// <summary>Sidebar.</summary>
		Sidebar,
		/// <summary>Medium Light.</summary>
		[Advice ("Use a semantic material instead.")]
		MediumLight,
		/// <summary>Ultra Dark.</summary>
		[Advice ("Use a semantic material instead.")]
		UltraDark,
		/// <summary>Header View.</summary>
		HeaderView = 10,
		/// <summary>Sheet.</summary>
		Sheet = 11,
		/// <summary>Window Background.</summary>
		WindowBackground = 12,
		/// <summary>Hud Window.</summary>
		HudWindow = 13,
		/// <summary>Full Screen U I.</summary>
		FullScreenUI = 15,
		/// <summary>Tool Tip.</summary>
		ToolTip = 17,
		/// <summary>Content Background.</summary>
		ContentBackground = 18,
		/// <summary>Under Window Background.</summary>
		UnderWindowBackground = 21,
		/// <summary>Under Page Background.</summary>
		UnderPageBackground = 22,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSVisualEffectBlendingMode : long {
		/// <summary>Behind Window.</summary>
		BehindWindow,
		/// <summary>Within Window.</summary>
		WithinWindow,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSVisualEffectState : long {
		/// <summary>Follows Window Active State.</summary>
		FollowsWindowActiveState,
		/// <summary>Active.</summary>
		Active,
		/// <summary>Inactive.</summary>
		Inactive,
	}
	#endregion

	[NoMacCatalyst]
	[Native]
	public enum NSPressureBehavior : long {
		/// <summary>Unknown.</summary>
		Unknown = -1,
		/// <summary>Primary Default.</summary>
		PrimaryDefault = 0,
		/// <summary>Primary Click.</summary>
		PrimaryClick = 1,
		/// <summary>Primary Generic.</summary>
		PrimaryGeneric = 2,
		/// <summary>Primary Accelerator.</summary>
		PrimaryAccelerator = 3,
		/// <summary>Primary Deep Click.</summary>
		PrimaryDeepClick = 5,
		/// <summary>Primary Deep Drag.</summary>
		PrimaryDeepDrag = 6,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSHapticFeedbackPattern : long {
		/// <summary>Generic.</summary>
		Generic = 0,
		/// <summary>Alignment.</summary>
		Alignment,
		/// <summary>Level Change.</summary>
		LevelChange,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSHapticFeedbackPerformanceTime : ulong {
		/// <summary>Default.</summary>
		Default = 0,
		/// <summary>Now.</summary>
		Now,
		/// <summary>Draw Completed.</summary>
		DrawCompleted,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSSpringLoadingHighlight : long {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Standard.</summary>
		Standard,
		/// <summary>Emphasized.</summary>
		Emphasized,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSSpringLoadingOptions : ulong {
		/// <summary>Disabled.</summary>
		Disabled = 0,
		/// <summary>Enabled.</summary>
		Enabled = 1 << 0,
		/// <summary>Continuous Activation.</summary>
		ContinuousActivation = 1 << 1,
		/// <summary>No Hover.</summary>
		NoHover = 1 << 3,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSWindowListOptions : long {
		/// <summary>Ordered Front To Back.</summary>
		OrderedFrontToBack = (1 << 0),
	}

	[NoMacCatalyst]
	[Native]
	public enum NSStatusItemBehavior : ulong {
		/// <summary>Removal Allowed.</summary>
		RemovalAllowed = (1 << 1),
		/// <summary>Termination On Removal.</summary>
		TerminationOnRemoval = (1 << 2),
	}

	[NoMacCatalyst]
	[Native]
	public enum NSWindowTabbingMode : long {
		/// <summary>Automatic.</summary>
		Automatic,
		/// <summary>Preferred.</summary>
		Preferred,
		/// <summary>Disallowed.</summary>
		Disallowed,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSWindowUserTabbingPreference : long {
		/// <summary>Manual.</summary>
		Manual,
		/// <summary>Always.</summary>
		Always,
		/// <summary>In Full Screen.</summary>
		InFullScreen,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSGridCellPlacement : long {
		/// <summary>Inherited.</summary>
		Inherited = 0,
		/// <summary>None.</summary>
		None,
		/// <summary>Leading.</summary>
		Leading,
		/// <summary>Top.</summary>
		Top = Leading,
		/// <summary>Trailing.</summary>
		Trailing,
		/// <summary>Bottom.</summary>
		Bottom = Trailing,
		/// <summary>Center.</summary>
		Center,
		/// <summary>Fill.</summary>
		Fill,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSGridRowAlignment : long {
		/// <summary>Inherited.</summary>
		Inherited = 0,
		/// <summary>None.</summary>
		None,
		/// <summary>First Baseline.</summary>
		FirstBaseline,
		/// <summary>Last Baseline.</summary>
		LastBaseline,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSImageLayoutDirection : long {
		/// <summary>Unspecified.</summary>
		Unspecified = -1,
		/// <summary>Left To Right.</summary>
		LeftToRight = 2,
		/// <summary>Right To Left.</summary>
		RightToLeft = 3,
	}

	[NoMacCatalyst]
	[Native]
	[Flags]
	public enum NSCloudKitSharingServiceOptions : ulong {
		/// <summary>Standard.</summary>
		Standard = 0,
		/// <summary>Allow Public.</summary>
		AllowPublic = 1 << 0,
		/// <summary>Allow Private.</summary>
		AllowPrivate = 1 << 1,
		/// <summary>Allow Read Only.</summary>
		AllowReadOnly = 1 << 4,
		/// <summary>Allow Read Write.</summary>
		AllowReadWrite = 1 << 5,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSDisplayGamut : long {
		/// <summary>Srgb.</summary>
		Srgb = 1,
		/// <summary>P3.</summary>
		P3,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTabPosition : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Top.</summary>
		Top,
		/// <summary>Left.</summary>
		Left,
		/// <summary>Bottom.</summary>
		Bottom,
		/// <summary>Right.</summary>
		Right,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTabViewBorderType : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Line.</summary>
		Line,
		/// <summary>Bezel.</summary>
		Bezel,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSPasteboardContentsOptions : ulong {
		/// <summary>Current Host Only.</summary>
		CurrentHostOnly = 1,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTouchType : long {
		/// <summary>Direct.</summary>
		Direct,
		/// <summary>Indirect.</summary>
		Indirect,
	}

	[NoMacCatalyst]
	[Native]
	[Flags]
	public enum NSTouchTypeMask : ulong {
		/// <summary>Direct.</summary>
		Direct = (1 << (int) NSTouchType.Direct),
		/// <summary>Indirect.</summary>
		Indirect = (1 << (int) NSTouchType.Indirect),
	}

	[NoMacCatalyst]
	[Native]
	public enum NSScrubberMode : long {
		/// <summary>Fixed.</summary>
		Fixed = 0,
		/// <summary>Free.</summary>
		Free,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSScrubberAlignment : long {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Leading.</summary>
		Leading,
		/// <summary>Trailing.</summary>
		Trailing,
		/// <summary>Center.</summary>
		Center,
	}

	[NoMacCatalyst]
	public enum NSFontError : int {
		/// <summary>Asset Download Error.</summary>
		AssetDownloadError = 66304,
		/// <summary>Error Minimum.</summary>
		ErrorMinimum = 66304,
		/// <summary>Error Maximum.</summary>
		ErrorMaximum = 66335,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSAccessibilityAnnotationPosition : long {
		/// <summary>Full Range.</summary>
		FullRange,
		/// <summary>Start.</summary>
		Start,
		/// <summary>End.</summary>
		End,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSAccessibilityCustomRotorSearchDirection : long {
		/// <summary>Previous.</summary>
		Previous,
		/// <summary>Next.</summary>
		Next,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSAccessibilityCustomRotorType : long {
		/// <summary>Custom.</summary>
		Custom = 0,
		/// <summary>Any.</summary>
		Any = 1,
		/// <summary>Annotation.</summary>
		Annotation,
		/// <summary>Bold Text.</summary>
		BoldText,
		/// <summary>Heading.</summary>
		Heading,
		/// <summary>Heading Level1.</summary>
		HeadingLevel1,
		/// <summary>Heading Level2.</summary>
		HeadingLevel2,
		/// <summary>Heading Level3.</summary>
		HeadingLevel3,
		/// <summary>Heading Level4.</summary>
		HeadingLevel4,
		/// <summary>Heading Level5.</summary>
		HeadingLevel5,
		/// <summary>Heading Level6.</summary>
		HeadingLevel6,
		/// <summary>Image.</summary>
		Image,
		/// <summary>Italic Text.</summary>
		ItalicText,
		/// <summary>Landmark.</summary>
		Landmark,
		/// <summary>Link.</summary>
		Link,
		/// <summary>List.</summary>
		List,
		/// <summary>Misspelled Word.</summary>
		MisspelledWord,
		/// <summary>Table.</summary>
		Table,
		/// <summary>Text Field.</summary>
		TextField,
		/// <summary>Underlined Text.</summary>
		UnderlinedText,
		/// <summary>Visited Link.</summary>
		VisitedLink,
		Audiograph,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSColorType : long {
		/// <summary>Component Based.</summary>
		ComponentBased,
		/// <summary>Pattern.</summary>
		Pattern,
		/// <summary>Catalog.</summary>
		Catalog,
	}

	[NoMacCatalyst]
	[Native]
	[Flags]
	public enum NSFontAssetRequestOptions : ulong {
		/// <summary>Uses Standard U I.</summary>
		UsesStandardUI = 1 << 0,
	}

	[NoMacCatalyst]
	[Native]
	[Flags]
	public enum NSFontPanelModeMask : ulong {
		/// <summary>Face.</summary>
		Face = 1 << 0,
		/// <summary>Size.</summary>
		Size = 1 << 1,
		/// <summary>Collection.</summary>
		Collection = 1 << 2,
		/// <summary>Underline Effect.</summary>
		UnderlineEffect = 1 << 8,
		/// <summary>Strikethrough Effect.</summary>
		StrikethroughEffect = 1 << 9,
		/// <summary>Text Color Effect.</summary>
		TextColorEffect = 1 << 10,
		/// <summary>Document Color Effect.</summary>
		DocumentColorEffect = 1 << 11,
		/// <summary>Shadow Effect.</summary>
		ShadowEffect = 1 << 12,
		/// <summary>All Effects.</summary>
		AllEffects = (ulong) 0XFFF00,
		/// <summary>Standard Modes.</summary>
		StandardModes = (ulong) 0XFFFF,
		/// <summary>All Modes.</summary>
		AllModes = (ulong) 0XFFFFFFFF,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSLevelIndicatorPlaceholderVisibility : long {
		/// <summary>Automatic.</summary>
		Automatic = 0,
		/// <summary>Always.</summary>
		Always = 1,
		/// <summary>While Editing.</summary>
		WhileEditing = 2,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSSegmentDistribution : long {
		/// <summary>Fit.</summary>
		Fit = 0,
		/// <summary>Fill.</summary>
		Fill,
		/// <summary>Fill Equally.</summary>
		FillEqually,
		/// <summary>Fill Proportionally.</summary>
		FillProportionally,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSColorSystemEffect : long {
		/// <summary>None.</summary>
		None,
		/// <summary>Pressed.</summary>
		Pressed,
		/// <summary>Deep Pressed.</summary>
		DeepPressed,
		/// <summary>Disabled.</summary>
		Disabled,
		/// <summary>Rollover.</summary>
		Rollover,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSWorkspaceAuthorizationType : long {
		/// <summary>Create Symbolic Link.</summary>
		CreateSymbolicLink,
		/// <summary>Set Attributes.</summary>
		SetAttributes,
		/// <summary>Replace File.</summary>
		ReplaceFile,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTableViewStyle : long {
		Automatic,
		FullWidth,
		Inset,
		SourceList,
		Plain,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTitlebarSeparatorStyle : long {
		Automatic,
		None,
		Line,
		Shadow,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSWindowToolbarStyle : long {
		Automatic,
		Expanded,
		Preference,
		Unified,
		UnifiedCompact,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSTableViewAnimationOptions : ulong {
		EffectNone = 0x0,
		EffectFade = 0x1,
		EffectGap = 0x2,
		SlideUp = 0x10,
		SlideDown = 0x20,
		SlideLeft = 0x30,
		SlideRight = 0x40,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSImageSymbolScale : long {
		Small = 1,
		Medium = 2,
		Large = 3,
	}

	[NoMacCatalyst, Mac (13, 0)]
	[Native]
	public enum NSColorWellStyle : long {
		Default = 0,
		Minimal,
		Expanded,
	}

	[NoMacCatalyst, Mac (13, 0)]
	[Native]
	public enum NSComboButtonStyle : long {
		Split = 0,
		Unified = 1,
	}

	[NoMacCatalyst, Mac (14, 0)]
	[Native]
	public enum NSImageDynamicRange : long {
		Unspecified = -1,
		Standard = 0,
		ConstrainedHigh = 1,
		High = 2,
	}

	[NoMacCatalyst, Mac (14, 0)]
	[Native]
	public enum NSMenuItemBadgeType : long {
		None = 0,
		Updates,
		NewItems,
		Alerts,
	}

	[NoMacCatalyst, Mac (14, 0)]
	[Native]
	public enum NSMenuPresentationStyle : long {
		Regular = 0,
		Palette = 1,
	}

	[NoMacCatalyst, Mac (14, 0)]
	[Native]
	public enum NSMenuSelectionMode : long {
		Automatic = 0,
		SelectOne = 1,
		SelectAny = 2,
	}

	[NoMacCatalyst, Mac (14, 0)]
	[Native]
	public enum NSPageLayoutResult : long {
		Cancelled = 0,
		Changed,
	}

	[NoMacCatalyst, Mac (14, 0)]
	[Native]
	public enum NSPrintPanelResult : long {
		Cancelled = 0,
		Printed,
	}

	[NoMacCatalyst, Mac (14, 0)]
	[Native]
	public enum NSTextCursorAccessoryPlacement : long {
		Unspecified,
		Backward,
		Forward,
		Invisible,
		Center,
		OffscreenLeft,
		OffscreenTop,
		OffscreenRight,
		OffscreenBottom,
	}

	[NoMacCatalyst, Mac (14, 0)]
	[Native]
	[Flags]
	public enum NSTextInsertionIndicatorAutomaticModeOptions : long {
		EffectsView = 1L << 0,
		WhileTracking = 1L << 1,
	}

	[NoMacCatalyst, Mac (14, 0)]
	[Native]
	public enum NSTextInsertionIndicatorDisplayMode : long {
		Automatic = 0,
		Hidden,
		Visible,
	}

	[Native]
	[Mac (15, 4), NoMacCatalyst]
	public enum NSPasteboardAccessBehavior : ulong {
		Default = 0,
		Ask = 1,
		AlwaysAllow = 2,
		AlwaysDeny = 3,
	}

	[Mac (15, 4), NoMacCatalyst]
	enum NSPasteboardDetectionPattern {
		[Field ("NSPasteboardDetectionPatternProbableWebURL")]
		ProbableWebUrl,

		[Field ("NSPasteboardDetectionPatternProbableWebSearch")]
		ProbableWebSearch,

		[Field ("NSPasteboardDetectionPatternNumber")]
		Number,

		[Field ("NSPasteboardDetectionPatternLink")]
		Link,

		[Field ("NSPasteboardDetectionPatternPhoneNumber")]
		PhoneNumber,

		[Field ("NSPasteboardDetectionPatternEmailAddress")]
		EmailAddress,

		[Field ("NSPasteboardDetectionPatternPostalAddress")]
		PostalAddress,

		[Field ("NSPasteboardDetectionPatternCalendarEvent")]
		CalendarEvent,

		[Field ("NSPasteboardDetectionPatternShipmentTrackingNumber")]
		ShipmentTrackingNumber,

		[Field ("NSPasteboardDetectionPatternFlightNumber")]
		FlightNumber,

		[Field ("NSPasteboardDetectionPatternMoneyAmount")]
		MoneyAmount,
	}

	[Mac (15, 4), NoMacCatalyst]
	enum NSPasteboardMetadataType {
		[Field ("NSPasteboardMetadataTypeContentType")]
		ContentType,
	}

	[MacCatalyst (26, 0), Mac (26, 0)]
	[Native]
	public enum NSToolbarItemStyle : long {
		Plain,
		Prominent,
	}

	[NoMacCatalyst, Mac (26, 0)]
	[Native]
	public enum NSImageSymbolColorRenderingMode : long {
		Automatic = 0,
		Flat,
		Gradient,
	}

	[NoMacCatalyst, Mac (26, 0)]
	[Native]
	public enum NSImageSymbolVariableValueMode : long {
		Automatic = 0,
		Color,
		Draw,
	}

	[NoMacCatalyst, Mac (26, 0)]
	[Native]
	public enum NSTintProminence : long {
		Automatic = 0,
		None,
		Primary,
		Secondary,
	}

	[NoMacCatalyst, Mac (26, 0)]
	[Native]
	public enum NSControlBorderShape : long {
		Automatic,
		Capsule,
		RoundedRectangle,
		Circle,
	}
}
