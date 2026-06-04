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
	/// <summary>To be added.</summary>
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
		///         <summary>To be added.</summary>
		public CGEventSource (CGEventSourceStateID stateID)
			: base (CGEventSourceCreate (stateID), true)
		{
		}

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static int /* CGEventSourceKeyboardType = uint32_t */ CGEventSourceGetKeyboardType (IntPtr handle);

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static void CGEventSourceSetKeyboardType (IntPtr handle, int /* CGEventSourceKeyboardType = uint32_t */ keyboardType);

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
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

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public CGEventSourceStateID StateID {
			get {
				return CGEventSourceGetSourceStateID (Handle);
			}
		}


		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static double CGEventSourceGetPixelsPerLine (IntPtr handle);

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static void CGEventSourceSetPixelsPerLine (IntPtr handle, double value);

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
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
		///         <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		public static bool GetButtonState (CGEventSourceStateID stateID, CGMouseButton button)
			=> CGEventSourceButtonState (stateID, button) != 0;

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static byte CGEventSourceKeyState (CGEventSourceStateID stateID, ushort keycode);

		/// <param name="stateID">The state i d.</param>
		///         <param name="keycode">The keycode.</param>
		///         <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		public static bool GetKeyState (CGEventSourceStateID stateID, ushort keycode)
			=> CGEventSourceKeyState (stateID, keycode) != 0;

		/// <param name="stateID">The state i d.</param>
		///         <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary, EntryPoint = "CGEventSourceFlagsState")]
		public extern static CGEventFlags GetFlagsState (CGEventSourceStateID stateID);

		/// <param name="stateID">The state i d.</param>
		///         <param name="eventType">The event type.</param>
		///         <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary, EntryPoint = "CGEventSourceSecondsSinceLastEventType")]
		public extern static double GetSecondsSinceLastEventType (CGEventSourceStateID stateID, CGEventType eventType);

		/// <param name="stateID">The state i d.</param>
		///         <param name="eventType">The event type.</param>
		///         <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary, EntryPoint = "CGEventSourceCounterForEventType")]
		public extern static uint /* uint32_t */ GetCounterForEventType (CGEventSourceStateID stateID, CGEventType eventType);

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static void CGEventSourceSetUserData (IntPtr handle, long data);

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static long CGEventSourceGetUserData (IntPtr handle);

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
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
		///         <summary>To be added.</summary>
		public void SetLocalEventsFilterDuringSupressionState (CGEventFilterMask filter, CGEventSuppressionState state)
		{
			CGEventSourceSetLocalEventsFilterDuringSuppressionState (Handle, filter, state);
		}

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static CGEventFilterMask CGEventSourceGetLocalEventsFilterDuringSuppressionState (IntPtr handle, CGEventSuppressionState state);

		/// <param name="state">The state.</param>
		///         <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		public CGEventFilterMask GetLocalEventsFilterDuringSupressionState (CGEventSuppressionState state)
		{
			return CGEventSourceGetLocalEventsFilterDuringSuppressionState (Handle, state);
		}

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static void CGEventSourceSetLocalEventsSuppressionInterval (IntPtr handle, double seconds);

		[DllImport (Constants.ApplicationServicesCoreGraphicsLibrary)]
		extern static double CGEventSourceGetLocalEventsSuppressionInterval (IntPtr handle);

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
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
