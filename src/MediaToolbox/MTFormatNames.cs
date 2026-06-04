// Copyright 2015 Xamarin Inc.

#nullable enable

using CoreFoundation;
using CoreMedia;

namespace MediaToolbox {
	/// <summary>Provides methods for getting localized format names for media types.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	static public class MTFormatNames {
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[DllImport (Constants.MediaToolboxLibrary)]
		static extern /* CFStringRef CM_NULLABLE */ IntPtr MTCopyLocalizedNameForMediaType (
			CMMediaType mediaType);

		/// <param name="mediaType">The media type.</param>
		/// <summary>Gets the localized name for the specified media type.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		static public string? GetLocalizedName (this CMMediaType mediaType)
		{
			return CFString.FromHandle (MTCopyLocalizedNameForMediaType (mediaType), releaseHandle: true);
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[DllImport (Constants.MediaToolboxLibrary)]
		static extern /* CFStringRef CM_NULLABLE */ IntPtr MTCopyLocalizedNameForMediaSubType (
			CMMediaType mediaType, uint mediaSubType);

		/// <param name="mediaType">The media type.</param>
		///         <param name="mediaSubType">The media sub type.</param>
		/// <summary>Gets the localized name for the specified media type and subtype.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		static public string? GetLocalizedName (this CMMediaType mediaType, uint mediaSubType)
		{
			return CFString.FromHandle (MTCopyLocalizedNameForMediaSubType (mediaType, mediaSubType), releaseHandle: true);
		}
	}
}
