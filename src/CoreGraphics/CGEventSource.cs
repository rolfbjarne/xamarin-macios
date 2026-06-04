/*
 * CGEventSource.cs: bindings to the ApplicationServices framework's CoreGraphics CGEventSource API
 * 
 * Copyright 2013, 2014 Xamarin Inc
 * All Rights Reserved
 * 
 * Authors:
 *    Miguel de Icaza
 */

#nullable enable

#if MONOMAC || __MACCATALYST__

using CoreFoundation;

namespace CoreGraphics {
/// <summary>Represents a source of Quartz events, used to create and manage event generation.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public sealed class CGEventSource : NativeObject {
		[Preserve (Conditional = true)]
		internal CGEventSource (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static IntPtr CGEventSourceCreate (CGEventSourceStateID stateID);

		/// <param name="stateID">The state i d.</param>
		/// <summary>Creates a new event source with the specified state ID.</summary>
		public CGEventSource (CGEventSourceStateID stateID)
			: base (CGEventSourceCreate (stateID), true)
		{
		}

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static int /* CGEventSourceKeyboardType = uint32_t */ CGEventSourceGetKeyboardType (IntPtr handle);

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static void CGEventSourceSetKeyboardType (IntPtr handle, int /* CGEventSourceKeyboardType = uint32_t */ keyboardType);

	/// <summary>Gets or sets the keyboard type associated with this event source.</summary>
		public int KeyboardType {
			get {
				return CGEventSourceGetKeyboardType (Handle);
			}
			set {
				CGEventSourceSetKeyboardType (Handle, value);
			}
		}

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static CGEventSourceStateID CGEventSourceGetSourceStateID (IntPtr handle);

	/// <summary>Gets the state ID of this event source.</summary>
		public CGEventSourceStateID StateID {
			get {
				return CGEventSourceGetSourceStateID (Handle);
			}
		}


		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static double CGEventSourceGetPixelsPerLine (IntPtr handle);

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static void CGEventSourceSetPixelsPerLine (IntPtr handle, double value);

	/// <summary>Gets or sets the number of pixels per scroll line for this event source.</summary>
		public double PixelsPerLine {
			get {
				return CGEventSourceGetPixelsPerLine (Handle);
			}
			set {
				CGEventSourceSetPixelsPerLine (Handle, value);
			}
		}

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static byte CGEventSourceButtonState (CGEventSourceStateID stateID, CGMouseButton button);

		/// <param name="stateID">The state i d.</param>
		///         <param name="button">The button.</param>
		/// <summary>Gets the current button state for the specified state ID and mouse button.</summary>
		public static bool GetButtonState (CGEventSourceStateID stateID, CGMouseButton button)
			=> CGEventSourceButtonState (stateID, button) != 0;

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static byte CGEventSourceKeyState (CGEventSourceStateID stateID, ushort keycode);

		/// <param name="stateID">The state i d.</param>
		///         <param name="keycode">The keycode.</param>
		/// <summary>Gets the current key state for the specified state ID and keycode.</summary>
		public static bool GetKeyState (CGEventSourceStateID stateID, ushort keycode)
			=> CGEventSourceKeyState (stateID, keycode) != 0;

		/// <param name="stateID">The state i d.</param>
		/// <summary>Gets the current modifier flags state for the specified state ID.</summary>
		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary, EntryPoint = "CGEventSourceFlagsState")]
		public extern static CGEventFlags GetFlagsState (CGEventSourceStateID stateID);

		/// <param name="stateID">The state i d.</param>
		///         <param name="eventType">The event type.</param>
		/// <summary>Gets the seconds since the last event of the specified type for the given state ID.</summary>
		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary, EntryPoint = "CGEventSourceSecondsSinceLastEventType")]
		public extern static double GetSecondsSinceLastEventType (CGEventSourceStateID stateID, CGEventType eventType);

		/// <param name="stateID">The state i d.</param>
		///         <param name="eventType">The event type.</param>
		/// <summary>Gets the event counter for the specified event type and state ID.</summary>
		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary, EntryPoint = "CGEventSourceCounterForEventType")]
		public extern static uint /* uint32_t */ GetCounterForEventType (CGEventSourceStateID stateID, CGEventType eventType);

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static void CGEventSourceSetUserData (IntPtr handle, long data);

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static long CGEventSourceGetUserData (IntPtr handle);

	/// <summary>Gets or sets the user data associated with this event source.</summary>
		public long UserData {
			get {
				return CGEventSourceGetUserData (Handle);
			}
			set {
				CGEventSourceSetUserData (Handle, value);
			}
		}


		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static void CGEventSourceSetLocalEventsFilterDuringSuppressionState (IntPtr handle, CGEventFilterMask filter, CGEventSuppressionState state);

		/// <param name="filter">The filter.</param>
		///         <param name="state">The state.</param>
		/// <summary>Sets the local events filter for the specified suppression state.</summary>
		public void SetLocalEventsFilterDuringSupressionState (CGEventFilterMask filter, CGEventSuppressionState state)
		{
			CGEventSourceSetLocalEventsFilterDuringSuppressionState (Handle, filter, state);
		}

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static CGEventFilterMask CGEventSourceGetLocalEventsFilterDuringSuppressionState (IntPtr handle, CGEventSuppressionState state);

		/// <param name="state">The state.</param>
		/// <summary>Gets the local events filter for the specified suppression state.</summary>
		public CGEventFilterMask GetLocalEventsFilterDuringSupressionState (CGEventSuppressionState state)
		{
			return CGEventSourceGetLocalEventsFilterDuringSuppressionState (Handle, state);
		}

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static void CGEventSourceSetLocalEventsSuppressionInterval (IntPtr handle, double seconds);

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static double CGEventSourceGetLocalEventsSuppressionInterval (IntPtr handle);

	/// <summary>Gets or sets the local events suppression interval.</summary>
		public double LocalEventsSupressionInterval {
			get {
				return CGEventSourceGetLocalEventsSuppressionInterval (Handle);
			}
			set {
				CGEventSourceSetLocalEventsSuppressionInterval (Handle, value);
			}
		}

	}
}

#endif // MONOMAC
