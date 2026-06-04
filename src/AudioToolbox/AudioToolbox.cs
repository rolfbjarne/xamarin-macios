// 
// AudioToolbox.cs: functions defined in AudioToolbox.h
//
// Copyright 2013-2014 Xamarin Inc.
//

#nullable enable

using CoreFoundation;

namespace AudioToolbox {
	/// <summary>Information on an instrument. Returned by <see cref="AudioToolbox.SoundBank.GetInstrumentInfo(Foundation.NSUrl)" />.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class InstrumentInfo {

		// defines, not NSString, are used for the key names
		/// <summary>The key for the instrument name.</summary>
		public const string NameKey = "name";
		/// <summary>The key for the most significant byte.</summary>
		public const string MSBKey = "MSB";
		/// <summary>The key for the least significant byte.</summary>
		public const string LSBKey = "LSB";
		/// <summary>The key for the program number.</summary>
		public const string ProgramKey = "program";

		internal InstrumentInfo (NSDictionary d)
		{
			Dictionary = d;
		}

		/// <summary>Gets or sets the name.</summary>
		public string? Name {
			get { return Dictionary [NameKey]?.ToString (); }
		}

		/// <summary>Gets or sets the m s b.</summary>
		public int MSB {
			get { return (Dictionary [MSBKey] as NSNumber)!.Int32Value; }
		}

		/// <summary>Gets or sets the l s b.</summary>
		public int LSB {
			get { return (Dictionary [LSBKey] as NSNumber)!.Int32Value; }
		}

		/// <summary>Gets or sets the program.</summary>
		public int Program {
			get { return (Dictionary [ProgramKey] as NSNumber)!.Int32Value; }
		}

		// some API likely wants the [CF|NS]Dictionary
		/// <summary>Gets or sets the dictionary.</summary>
		public NSDictionary Dictionary { get; private set; }
	}

	/// <summary>A MIDI sound bank.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public static class SoundBank {

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[DllImport (Constants.AudioToolboxLibrary)]
		unsafe extern static OSStatus CopyNameFromSoundBank (/* CFURLRef */ IntPtr inURL, /* CFStringRef */ IntPtr* outName);

		/// <param name="url">The URL to use.</param>
		///         <summary>Gets name.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static string? GetName (NSUrl url)
		{
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));

			IntPtr name = IntPtr.Zero;
			OSStatus error;
			unsafe {
				error = CopyNameFromSoundBank (url.Handle, &name);
				GC.KeepAlive (url);
			}
			var result = CFString.FromHandle (name);
			return (error != 0) ? null : result;
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[DllImport (Constants.AudioToolboxLibrary)]
		unsafe extern static OSStatus CopyInstrumentInfoFromSoundBank (/* CFURLRef */ IntPtr inURL, /* CFSArrayRef */ IntPtr* outInstrumentInfo);

		/// <param name="url">The URL to use.</param>
		/// <summary>Gets the instrument information from the specified sound bank URL.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		public static InstrumentInfo []? GetInstrumentInfo (NSUrl url)
		{
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));

			IntPtr array = IntPtr.Zero;
			unsafe {
				var error = CopyInstrumentInfoFromSoundBank (url.Handle, &array);
				GC.KeepAlive (url);
				if (error != 0)
					return null;
			}
			return NSArray.DictionaryArrayFromHandleDropNullElements<InstrumentInfo> (array, dict => new InstrumentInfo (dict), releaseHandle: true);
		}
	}
}
