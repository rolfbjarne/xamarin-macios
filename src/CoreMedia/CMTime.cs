// 
// CMTime.cs: API for creating and manipulating CMTime structs
//
// Authors: Mono Team
//
// Copyright 2010-2011 Novell Inc
// Copyright 2012-2014 Xamarin Inc. All rights reserved.
//

#nullable enable

using CoreFoundation;

namespace CoreMedia {

	/// <summary>A time value that represents a rational number <see cref="CoreMedia.CMTime.Value" />/<see cref="CoreMedia.CMTime.TimeScale" />.</summary>
	///     <related type="sample" href="https://github.com/xamarin/ios-samples/tree/master/AVCaptureFrames/">avcaptureframes</related>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[StructLayout (LayoutKind.Sequential)]
	public partial struct CMTime {
		// CMTimeFlags -> uint32_t -> CMTime.h
		/// <summary>An enumeration whose values are flags used by <see cref="CoreMedia.CMTime" />.</summary>
		[Flags]
		public enum Flags : uint {
			/// <summary>The time value is valid.</summary>
			Valid = 1,
			/// <summary>The time value has been rounded.</summary>
			HasBeenRounded = 2,
			/// <summary>The time represents positive infinity.</summary>
			PositiveInfinity = 4,
			/// <summary>The time represents negative infinity.</summary>
			NegativeInfinity = 8,
			/// <summary>The time is indefinite.</summary>
			Indefinite = 16,
			/// <summary>Mask for implied value flags.</summary>
			ImpliedValueFlagsMask = PositiveInfinity | NegativeInfinity | Indefinite,
		}
#if !COREBUILD

		/// <summary>Constant that contains an invalid CMTime.</summary>
		public readonly static CMTime Invalid = new CMTime (0);

		const Flags kIndefinite = Flags.Valid | Flags.Indefinite;
		/// <summary>Constant that contains an indefinite CMTime.</summary>
		public readonly static CMTime Indefinite = new CMTime (kIndefinite);

		const Flags kPositive = Flags.Valid | Flags.PositiveInfinity;
		/// <summary>Constant that contains APositive infinity CMTime.</summary>
		public readonly static CMTime PositiveInfinity = new CMTime (kPositive);

		const Flags kNegative = Flags.Valid | Flags.NegativeInfinity;
		/// <summary>Constant that contains a negative infinity CMTime.</summary>
		public readonly static CMTime NegativeInfinity = new CMTime (kNegative);

		/// <summary>Constant that contains a zero CMTime.</summary>
		public readonly static CMTime Zero = new CMTime (Flags.Valid, 1);

		/// <summary>Maximum supported time scale.</summary>
		public const int MaxTimeScale = 0x7fffffff;

#endif // !COREBUILD

		// CMTimeValue -> int64_t -> CMTime.h
		/// <summary>Value component of a CMTime (the numerator).</summary>
		public long Value;

		// CMTimeScale -> int32_t -> CMTime.h
		/// <summary>Timescale for the CMTime (the denominator).</summary>
		public int TimeScale;

		// CMTimeFlags -> uint32_t -> CMTime.h
		/// <summary>Flags set on the CMTime</summary>
		public Flags TimeFlags;

		// CMTimeEpoch -> int64_t -> CMTime.h
		/// <summary>The time epoch.</summary>
		public long TimeEpoch;

#if !COREBUILD
		CMTime (Flags f)
		{
			Value = 0;
			TimeScale = 0;
			TimeEpoch = 0;
			TimeFlags = f;
		}

		CMTime (Flags f, int timescale)
		{
			Value = 0;
			TimeScale = timescale;
			TimeEpoch = 0;
			TimeFlags = f;
		}

		/// <param name="value">The time value (numerator).</param>
		/// <param name="timescale">The timescale (denominator).</param>
		/// <summary>Creates a CMTime with the specified value and timescale.</summary>
		public CMTime (long value, int timescale)
		{
			Value = value;
			TimeScale = timescale;
			TimeFlags = Flags.Valid;
			TimeEpoch = 0;
		}

		/// <param name="value">The time value (numerator).</param>
		/// <param name="timescale">The timescale (denominator).</param>
		/// <param name="epoch">The epoch.</param>
		/// <summary>Creates a CMTime with the specified value, timescale, and epoch.</summary>
		public CMTime (long value, int timescale, long epoch)
		{
			Value = value;
			TimeScale = timescale;
			TimeFlags = Flags.Valid;
			TimeEpoch = epoch;
		}

		/// <summary>Indicates that the CMTime value stored is invalid.</summary>
		public bool IsInvalid {
			get {
				return (TimeFlags & Flags.Valid) == 0;
			}
		}

		/// <summary>Indicates if the CMTime is numeric.</summary>
		public bool IsNumeric {
			get {
				return ((TimeFlags & (Flags.Valid | Flags.ImpliedValueFlagsMask)) == Flags.Valid);
			}

		}

		/// <summary>Indicates that the CMTime was rounded.</summary>
		public bool HasBeenRounded {
			get {
				return IsNumeric && ((TimeFlags & Flags.HasBeenRounded) != 0);
			}
		}

		/// <summary>Indicates that the CMTime is indefinite.</summary>
		public bool IsIndefinite {
			get {
				return (TimeFlags & kIndefinite) == kIndefinite;
			}
		}

		/// <summary>Indicates if the CMTime represents positive infinity.</summary>
		public bool IsPositiveInfinity {
			get {
				return (TimeFlags & kPositive) == kPositive;
			}
		}

		/// <summary>Indicates if the CMTime represents negative infinity.</summary>
		public bool IsNegativeInfinity {
			get {
				return (TimeFlags & kNegative) == kNegative;
			}
		}

		[DllImport (Constants.CoreMediaLibrary)]
		extern static CMTime CMTimeAbsoluteValue (CMTime time);

		/// <summary>Gets the absolute value of this CMTime.</summary>
		public CMTime AbsoluteValue {
			get {
				return CMTimeAbsoluteValue (this);
			}
		}

		[DllImport (Constants.CoreMediaLibrary)]
		extern static /* int32_t */ int CMTimeCompare (CMTime time1, CMTime time2);

		/// <param name="time1">The first time value.</param>
		/// <param name="time2">The second time value.</param>
		/// <summary>Compares two CMTime values.</summary>
		public static int Compare (CMTime time1, CMTime time2)
		{
			return CMTimeCompare (time1, time2);
		}

		public static bool operator == (CMTime time1, CMTime time2)
		{
			return CMTimeCompare (time1, time2) == 0;
		}

		public static bool operator != (CMTime time1, CMTime time2)
		{
			return CMTimeCompare (time1, time2) != 0;
		}

		public static bool operator < (CMTime time1, CMTime time2)
		{
			return CMTimeCompare (time1, time2) == -1;
		}

		public static bool operator <= (CMTime time1, CMTime time2)
		{
			var comp = CMTimeCompare (time1, time2);
			return comp <= 0;
		}

		public static bool operator > (CMTime time1, CMTime time2)
		{
			return CMTimeCompare (time1, time2) == 1;
		}

		public static bool operator >= (CMTime time1, CMTime time2)
		{
			var comp = CMTimeCompare (time1, time2);
			return comp >= 0;
		}

		/// <param name="obj">The object to compare with.</param>
		/// <summary>Determines whether this instance equals the specified object.</summary>
		public override bool Equals (object? obj)
		{
			if (obj is CMTime time)
				return CMTimeCompare (this, time) == 0;
			return false;
		}

		/// <summary>Returns a hash code for this instance.</summary>
		public override int GetHashCode ()
		{
			return HashCode.Combine (Value, TimeScale, TimeFlags, TimeEpoch);
		}

		[DllImport (Constants.CoreMediaLibrary)]
		extern static CMTime CMTimeAdd (CMTime addend1, CMTime addend2);

		/// <param name="time1">The first time value.</param>
		/// <param name="time2">The second time value.</param>
		/// <summary>Adds two CMTime values.</summary>
		public static CMTime Add (CMTime time1, CMTime time2)
		{
			return CMTimeAdd (time1, time2);
		}

		[DllImport (Constants.CoreMediaLibrary)]
		extern static CMTime CMTimeSubtract (CMTime minuend, CMTime subtrahend);

		/// <param name="minuend">The time to subtract from.</param>
		/// <param name="subtraend">The time to subtract.</param>
		///         <summary>Substracts a CMTime from another CMTime.</summary>
		public static CMTime Subtract (CMTime minuend, CMTime subtraend)
		{
			return CMTimeSubtract (minuend, subtraend);
		}

		[DllImport (Constants.CoreMediaLibrary)]
		extern static CMTime CMTimeMultiply (CMTime time, /* int32_t */ int multiplier);

		/// <param name="time">The time value.</param>
		/// <param name="multiplier">The multiplier.</param>
		///         <summary>Multiples a CMTime by an integer value.</summary>
		public static CMTime Multiply (CMTime time, int multiplier)
		{
			return CMTimeMultiply (time, multiplier);
		}

		[DllImport (Constants.CoreMediaLibrary)]
		extern static CMTime CMTimeMultiplyByFloat64 (CMTime time, /* Float64 */ double multiplier);

		/// <param name="time">The time value.</param>
		/// <param name="multiplier">The multiplier.</param>
		///         <summary>Multiples a CMTime by a double value.</summary>
		public static CMTime Multiply (CMTime time, double multiplier)
		{
			return CMTimeMultiplyByFloat64 (time, multiplier);
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[DllImport (Constants.CoreMediaLibrary)]
		extern static CMTime CMTimeMultiplyByRatio (CMTime time, /* int32_t */ int multiplier, /* int32_t */ int divisor);

		/// <param name="time">The time value.</param>
		/// <param name="multiplier">The multiplier.</param>
		/// <param name="divisor">The divisor.</param>
		///         <summary>Multiples a CMTime by a fraction expressed as a multiplier and a divisor.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		public static CMTime Multiply (CMTime time, int multiplier, int divisor)
		{
			return CMTimeMultiplyByRatio (time, multiplier, divisor);
		}

		public static CMTime operator + (CMTime time1, CMTime time2)
		{
			return Add (time1, time2);
		}

		public static CMTime operator - (CMTime minuend, CMTime subtraend)
		{
			return Subtract (minuend, subtraend);
		}

		public static CMTime operator * (CMTime time, int multiplier)
		{
			return Multiply (time, multiplier);
		}

		public static CMTime operator * (CMTime time, double multiplier)
		{
			return Multiply (time, multiplier);
		}

		[DllImport (Constants.CoreMediaLibrary)]
		extern static CMTime CMTimeConvertScale (CMTime time, /* int32_t */ int newScale, CMTimeRoundingMethod method);

		/// <param name="newScale">The new timescale.</param>
		/// <param name="method">The rounding method.</param>
		/// <summary>Converts this time to a new timescale.</summary>
		public CMTime ConvertScale (int newScale, CMTimeRoundingMethod method)
		{
			return CMTimeConvertScale (this, newScale, method);
		}

		[DllImport (Constants.CoreMediaLibrary)]
		extern static /* Float64 */ double CMTimeGetSeconds (CMTime time);

		/// <summary>Number of seconds</summary>
		public double Seconds {
			get {
				return CMTimeGetSeconds (this);
			}
		}

		[DllImport (Constants.CoreMediaLibrary)]
		extern static CMTime CMTimeMakeWithSeconds (/* Float64 */ double seconds, /* int32_t */ int preferredTimeScale);

		/// <param name="seconds">The number of seconds.</param>
		/// <param name="preferredTimeScale">The preferred timescale.</param>
		///         <summary>Creates a new instance of CMTime from a second and timescale description.</summary>
		///         <returns>The constructed CMTime.</returns>
		///         <remarks>
		///         </remarks>
		public static CMTime FromSeconds (double seconds, int preferredTimeScale)
		{
			return CMTimeMakeWithSeconds (seconds, preferredTimeScale);
		}

		[DllImport (Constants.CoreMediaLibrary)]
		extern static CMTime CMTimeMaximum (CMTime time1, CMTime time2);

		/// <param name="time1">The first time value.</param>
		/// <param name="time2">The second time value.</param>
		/// <summary>Returns the maximum of two CMTime values.</summary>
		public static CMTime GetMaximum (CMTime time1, CMTime time2)
		{
			return CMTimeMaximum (time1, time2);
		}

		[DllImport (Constants.CoreMediaLibrary)]
		extern static CMTime CMTimeMinimum (CMTime time1, CMTime time2);

		/// <param name="time1">The first time value.</param>
		/// <param name="time2">The second time value.</param>
		/// <summary>Returns the minimum of two CMTime values.</summary>
		public static CMTime GetMinimum (CMTime time1, CMTime time2)
		{
			return CMTimeMinimum (time1, time2);
		}

		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[DllImport (Constants.CoreMediaLibrary)]
		extern static CMTime CMTimeFoldIntoRange (CMTime time, CMTimeRange foldRange);

		/// <param name="time">The time value.</param>
		/// <param name="foldRange">The time range to fold into.</param>
		///         <summary>Folds the time into the specified range.</summary>
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public static CMTime Fold (CMTime time, CMTimeRange foldRange)
		{
			return CMTimeFoldIntoRange (time, foldRange);
		}

		// FIXME: generated will need some changes to emit [Field] in partial struct (not class)
		/// <summary>Key that can be used in NSDictionary objects returned by CMTime to extract the Value property.</summary>
		public readonly static NSString? ValueKey;
		/// <summary>Key that can be used in NSDictionary objects returned by CMTime to extract the Scale property.</summary>
		public readonly static NSString? ScaleKey;
		/// <summary>Key that can be used in NSDictionary objects to extract the Epoch property.</summary>
		public readonly static NSString? EpochKey;
		/// <summary>Key that can be used in NSDictionary objects to extract the Flags property.</summary>
		public readonly static NSString? FlagsKey;

		static CMTime ()
		{
			var lib = Libraries.CoreMedia.Handle;
			ValueKey = Dlfcn.GetStringConstant (lib, "kCMTimeValueKey");
			ScaleKey = Dlfcn.GetStringConstant (lib, "kCMTimeScaleKey");
			EpochKey = Dlfcn.GetStringConstant (lib, "kCMTimeEpochKey");
			FlagsKey = Dlfcn.GetStringConstant (lib, "kCMTimeFlagsKey");
		}

		[DllImport (Constants.CoreMediaLibrary)]
		extern static /* CFDictionaryRef */ IntPtr CMTimeCopyAsDictionary (CMTime time, /* CFAllocatorRef */ IntPtr allocator);

		/// <summary>Converts this CMTime to a dictionary representation.</summary>
		public NSDictionary ToDictionary ()
		{
			return new NSDictionary (CMTimeCopyAsDictionary (this, IntPtr.Zero), true);
		}

		[DllImport (Constants.CoreMediaLibrary)]
		extern static /* CFStringRef */ IntPtr CMTimeCopyDescription (/* CFAllocatorRef */ IntPtr allocator, CMTime time);

		/// <summary>Gets a description string of this CMTime.</summary>
		public string? Description {
			get {
				return CFString.FromHandle (CMTimeCopyDescription (IntPtr.Zero, this), true);
			}
		}

		/// <summary>Human readable description of the CMTime.</summary>
		public override string? ToString ()
		{
			return Description;
		}

		[DllImport (Constants.CoreMediaLibrary)]
		extern static CMTime CMTimeMakeFromDictionary (/* CFDictionaryRef */ IntPtr dict);

		/// <param name="dict">The dictionary representation of the time.</param>
		///         <summary>Creates a CMTime from a dictionary representation.</summary>
		public static CMTime FromDictionary (NSDictionary dict)
		{
			if (dict is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dict));
			CMTime result = CMTimeMakeFromDictionary (dict.Handle);
			GC.KeepAlive (dict);
			return result;
		}
#endif // !COREBUILD
	}
}
