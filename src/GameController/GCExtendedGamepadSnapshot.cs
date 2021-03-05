//
// GCExtendedGamepadSnapshot.cs: extensions to GCExtendedGamepadSnapshot iOS API
//
// Authors:
//   Aaron Bockover (abock@xamarin.com)
//   TJ Lambert (t-anlamb@microsoft.com)
//
// Copyright 2013-2014 Xamarin Inc.
// Copyright 2019 Microsoft Corporation

using System;
using System.Runtime.InteropServices;

using ObjCRuntime;
using Foundation;

namespace GameController {
	// GCExtendedGamepadSnapshot.h
	// float_t are 4 bytes (at least for ARM64)
	[StructLayout (LayoutKind.Sequential, Pack = 1)]
	[iOS (7,0)]
	[Mac (10,9)]
	[Deprecated (PlatformName.iOS, 12, 2, message: "Use 'GCExtendedGamepadSnapshotData' instead.")]
	[Deprecated (PlatformName.MacOSX, 10, 14, 4, message: "Use 'GCExtendedGamepadSnapshotData' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 2, message: "Use 'GCExtendedGamepadSnapshotData' instead.")]
	public struct GCExtendedGamepadSnapShotDataV100 {

		// Standard information
		public ushort /* uint16_t */ Version; // 0x0100
		public ushort /* uint16_t */ Size;    // sizeof(GCExtendedGamepadSnapShotDataV100) or larger

		// Extended gamepad data
		// Axes in the range [-1.0, 1.0]
		public float /* float_t = float */ DPadX;
		public float /* float_t = float */ DPadY;

		// Buttons in the range [0.0, 1.0]
		public float /* float_t = float */ ButtonA;
		public float /* float_t = float */ ButtonB;
		public float /* float_t = float */ ButtonX;
		public float /* float_t = float */ ButtonY;
		public float /* float_t = float */ LeftShoulder;
		public float /* float_t = float */ RightShoulder;

		// Axes in the range [-1.0, 1.0]
		public float /* float_t = float */ LeftThumbstickX;
		public float /* float_t = float */ LeftThumbstickY;
		public float /* float_t = float */ RightThumbstickX;
		public float /* float_t = float */ RightThumbstickY;

		// Buttons in the range [0.0, 1.0]
		public float /* float_t = float */ LeftTrigger;
		public float /* float_t = float */ RightTrigger;

		// radar: https://trello.com/c/7FoGTORD (GCExtendedGamepadSnapShotDataV100 struct size / alignment not backward compatible)
		// [TV (12, 1), Mac (10, 14, 1), iOS (12, 1)]
		// public bool LeftThumbstickButton;
		// [TV (12, 1), Mac (10, 14, 1), iOS (12, 1)]
		// public bool RightThumbstickButton;

		[Deprecated (PlatformName.MacOSX, 10, 15, message: "Use 'GCController.GetExtendedGamepadController()' instead.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "Use 'GCController.GetExtendedGamepadController()' instead.")]
		[Deprecated (PlatformName.TvOS, 13, 0, message: "Use 'GCController.GetExtendedGamepadController()' instead.")]
		[DllImport (Constants.GameControllerLibrary)]
		static extern /* NSData * __nullable */ IntPtr NSDataFromGCExtendedGamepadSnapShotDataV100 (
			/* GCExtendedGamepadSnapShotDataV100 * __nullable */ ref GCExtendedGamepadSnapShotDataV100 snapshotData);

		public NSData ToNSData ()
		{
			var p = NSDataFromGCExtendedGamepadSnapShotDataV100 (ref this);
			return p == IntPtr.Zero ? null : new NSData (p);
		}
	}
	
	[Deprecated (PlatformName.MacOSX, 10, 15, message: "Use 'GCController.GetExtendedGamepadController()' instead.")]
	[Deprecated (PlatformName.iOS, 13, 0, message: "Use 'GCController.GetExtendedGamepadController()' instead.")]
	[Deprecated (PlatformName.TvOS, 13, 0, message: "Use 'GCController.GetExtendedGamepadController()' instead.")]
	// float_t are 4 bytes (at least for ARM64)
	[StructLayout (LayoutKind.Sequential, Pack = 1)]
	public struct GCExtendedGamepadSnapshotData {

		// Standard information
		public ushort /* uint16_t */ Version;
		public ushort /* uint16_t */ Size;

		// Extended gamepad data
		// Axes in the range [-1.0, 1.0]
		public float /* float_t = float */ DPadX;
		public float /* float_t = float */ DPadY;

		// Buttons in the range [0.0, 1.0]
		public float /* float_t = float */ ButtonA;
		public float /* float_t = float */ ButtonB;
		public float /* float_t = float */ ButtonX;
		public float /* float_t = float */ ButtonY;
		public float /* float_t = float */ LeftShoulder;
		public float /* float_t = float */ RightShoulder;

		// Axes in the range [-1.0, 1.0]
		public float /* float_t = float */ LeftThumbstickX;
		public float /* float_t = float */ LeftThumbstickY;
		public float /* float_t = float */ RightThumbstickX;
		public float /* float_t = float */ RightThumbstickY;

		// Buttons in the range [0.0, 1.0]
		public float /* float_t = float */ LeftTrigger;
		public float /* float_t = float */ RightTrigger;

		[iOS (12, 2), Mac (10, 14, 4), TV (12, 2)]
		public bool SupportsClickableThumbsticks;

		[TV (12, 2), Mac (10, 14, 4), iOS (12, 2)]
		bool LeftThumbstickButton;
		
		[TV (12, 2), Mac (10, 14, 4), iOS (12, 2)]
		bool RightThumbstickButton;

		[DllImport (Constants.GameControllerLibrary)]
		[TV (12, 2), Mac (10, 14, 4), iOS (12, 2)]
		static extern /* NSData * __nullable */ IntPtr NSDataFromGCExtendedGamepadSnapshotData (
			/* GCExtendedGamepadSnapshotData * __nullable */ ref GCExtendedGamepadSnapshotData snapshotData);

		[TV (12, 2), Mac (10, 14, 4), iOS (12, 2)]
		public NSData ToNSData ()
		{
			var p = NSDataFromGCExtendedGamepadSnapshotData (ref this);
			return p == IntPtr.Zero ? null : new NSData (p);
		}
	}

	public partial class GCExtendedGamepadSnapshot {
		
		// GCExtendedGamepadSnapshot.h
		[DllImport (Constants.GameControllerLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		static extern bool GCExtendedGamepadSnapShotDataV100FromNSData (
			/* GCExtendedGamepadSnapShotDataV100 * __nullable */ out GCExtendedGamepadSnapShotDataV100 snapshotData, 
			/* NSData * __nullable */ IntPtr data);
		
		[DllImport (Constants.GameControllerLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		[TV (12, 2), Mac (10, 14, 4), iOS (12, 2)]
		static extern bool GCExtendedGamepadSnapshotDataFromNSData (
			/* GCExtendedGamepadSnapshotData * __nullable */ out GCExtendedGamepadSnapshotData snapshotData, 
			/* NSData * __nullable */ IntPtr data);

		public static bool TryGetSnapShotData (NSData data, out GCExtendedGamepadSnapShotDataV100 snapshotData)
		{
			return GCExtendedGamepadSnapShotDataV100FromNSData (out snapshotData, data == null ? IntPtr.Zero : data.Handle);
		}
		
		[TV (12, 2), Mac (10, 14, 4), iOS (12, 2)]
		public static bool TryGetExtendedSnapShotData (NSData data, out GCExtendedGamepadSnapshotData snapshotData)
		{
			return GCExtendedGamepadSnapshotDataFromNSData (out snapshotData, data == null ? IntPtr.Zero : data.Handle);
		}
	}
}
