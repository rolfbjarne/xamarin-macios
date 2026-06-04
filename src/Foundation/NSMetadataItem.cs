//
// Convenience methods for NSMetadataItem
//
// Copyright 2014, 2016 Xamarin Inc
//
// Author:
//   Miguel de Icaza
//
using CoreFoundation;

#nullable enable

namespace Foundation {
	public partial class NSMetadataItem {
		bool? GetNullableBool (NSString key)
		{
			var n = Runtime.GetNSObject<NSNumber> (GetHandle (key));
			return n?.BoolValue;
		}

		double GetDouble (NSString key)
		{
			var n = Runtime.GetNSObject<NSNumber> (GetHandle (key));
			return n is null ? 0 : n.DoubleValue;
		}

		double? GetNullableDouble (NSString key)
		{
			var n = Runtime.GetNSObject<NSNumber> (GetHandle (key));
			return n?.DoubleValue;
		}

		nint? GetNInt (NSString key)
		{
			var n = Runtime.GetNSObject<NSNumber> (GetHandle (key));
			return n?.NIntValue;
		}

		// same order as NSMetadataAttributes.h

		/// <summary>Gets the file system name.</summary>
		public NSString? FileSystemName {
			get {
				return Runtime.GetNSObject<NSString> (GetHandle (NSMetadataQuery.ItemFSNameKey));
			}
		}

		/// <summary>Gets the display name.</summary>
		public NSString? DisplayName {
			get {
				return Runtime.GetNSObject<NSString> (GetHandle (NSMetadataQuery.ItemDisplayNameKey));
			}
		}

		/// <summary>Gets the url.</summary>
		public NSUrl? Url {
			get {
				return Runtime.GetNSObject<NSUrl> (GetHandle (NSMetadataQuery.ItemURLKey));
			}
		}

		/// <summary>Gets the path.</summary>
		public NSString? Path {
			get {
				return Runtime.GetNSObject<NSString> (GetHandle (NSMetadataQuery.ItemPathKey));
			}
		}

		/// <summary>Gets the file system size.</summary>
		public NSNumber? FileSystemSize {
			get {
				return Runtime.GetNSObject<NSNumber> (GetHandle (NSMetadataQuery.ItemFSSizeKey));
			}
		}

		/// <summary>Gets the file system creation date.</summary>
		public NSDate? FileSystemCreationDate {
			get {
				return Runtime.GetNSObject<NSDate> (GetHandle (NSMetadataQuery.ItemFSCreationDateKey));
			}
		}

		/// <summary>Gets the file system content change date.</summary>
		public NSDate? FileSystemContentChangeDate {
			get {
				return Runtime.GetNSObject<NSDate> (GetHandle (NSMetadataQuery.ItemFSContentChangeDateKey));
			}
		}

		/// <summary>Gets the content type.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		public NSString? ContentType {
			get {
				return Runtime.GetNSObject<NSString> (GetHandle (NSMetadataQuery.ContentTypeKey));
			}
		}

		/// <summary>Gets the content type tree.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		public NSString? []? ContentTypeTree {
			get {
				using (var a = Runtime.GetNSObject<NSArray> (GetHandle (NSMetadataQuery.ContentTypeTreeKey)))
					return NSArray.FromArray<NSString> (a);
			}
		}

		/// <summary>Gets the is ubiquitous.</summary>
		public bool? IsUbiquitous {
			get {
				return GetNullableBool (NSMetadataQuery.ItemIsUbiquitousKey);
			}
		}

		/// <summary>Gets the ubiquitous item has unresolved conflicts.</summary>
		public bool? UbiquitousItemHasUnresolvedConflicts {
			get {
				return GetNullableBool (NSMetadataQuery.UbiquitousItemHasUnresolvedConflictsKey);
			}
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		public NSItemDownloadingStatus UbiquitousItemDownloadingStatus {
			get {
				return NSItemDownloadingStatusExtensions.GetValue (Runtime.GetNSObject<NSString> (GetHandle (NSMetadataQuery.UbiquitousItemDownloadingStatusKey)));
			}
		}

		/// <summary>Gets the ubiquitous item is downloading.</summary>
		public bool? UbiquitousItemIsDownloading {
			get {
				return GetNullableBool (NSMetadataQuery.UbiquitousItemIsDownloadingKey);
			}
		}

		/// <summary>Gets the ubiquitous item is uploaded.</summary>
		public bool? UbiquitousItemIsUploaded {
			get {
				return GetNullableBool (NSMetadataQuery.UbiquitousItemIsUploadedKey);
			}
		}

		/// <summary>Gets the ubiquitous item is uploading.</summary>
		public bool? UbiquitousItemIsUploading {
			get {
				return GetNullableBool (NSMetadataQuery.UbiquitousItemIsUploadingKey);
			}
		}

		/// <summary>Gets the ubiquitous item percent downloaded.</summary>
		public double? UbiquitousItemPercentDownloaded {
			get {
				return GetNullableDouble (NSMetadataQuery.UbiquitousItemPercentDownloadedKey);
			}
		}

		/// <summary>Gets the ubiquitous item percent uploaded.</summary>
		public double? UbiquitousItemPercentUploaded {
			get {
				return GetNullableDouble (NSMetadataQuery.UbiquitousItemPercentUploadedKey);
			}
		}

		/// <summary>Gets the ubiquitous item downloading error.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		public NSError? UbiquitousItemDownloadingError {
			get {
				return Runtime.GetNSObject<NSError> (GetHandle (NSMetadataQuery.UbiquitousItemDownloadingErrorKey));
			}
		}

		/// <summary>Gets the ubiquitous item uploading error.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		public NSError? UbiquitousItemUploadingError {
			get {
				return Runtime.GetNSObject<NSError> (GetHandle (NSMetadataQuery.UbiquitousItemUploadingErrorKey));
			}
		}

		/// <summary>Gets the ubiquitous item download requested.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		public bool? UbiquitousItemDownloadRequested {
			get {
				return GetNullableBool (NSMetadataQuery.UbiquitousItemDownloadRequestedKey);
			}
		}

		/// <summary>Gets the ubiquitous item is external document.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		public bool? UbiquitousItemIsExternalDocument {
			get {
				return GetNullableBool (NSMetadataQuery.UbiquitousItemIsExternalDocumentKey);
			}
		}

		/// <summary>Gets the ubiquitous item container display name.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		public NSString? UbiquitousItemContainerDisplayName {
			get {
				return Runtime.GetNSObject<NSString> (GetHandle (NSMetadataQuery.UbiquitousItemContainerDisplayNameKey));
			}
		}

		/// <summary>Gets the ubiquitous item url in local container.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		public NSUrl? UbiquitousItemUrlInLocalContainer {
			get {
				return Runtime.GetNSObject<NSUrl> (GetHandle (NSMetadataQuery.UbiquitousItemURLInLocalContainerKey));
			}
		}

#if MONOMAC
		/// <summary>Gets the metadata key for keywords.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? Keywords {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.KeywordsKey));
			}
		}

		/// <summary>Gets the title.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Title {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.TitleKey));
			}
		}

		/// <summary>Gets the authors.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? Authors {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.AuthorsKey));
			}
		}

		/// <summary>Gets the editors.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? Editors {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.EditorsKey));
			}
		}

		/// <summary>Gets the participants.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? Participants {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.ParticipantsKey));
			}
		}

		/// <summary>Gets the projects.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? Projects {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.ProjectsKey));
			}
		}

		/// <summary>Gets the downloaded date.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public NSDate? DownloadedDate {
			get {
				return Runtime.GetNSObject<NSDate> (GetHandle (NSMetadataQuery.DownloadedDateKey));
			}
		}

		/// <summary>Gets the where froms.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? WhereFroms {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.WhereFromsKey));
			}
		}

		/// <summary>Gets the comment.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Comment {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.CommentKey));
			}
		}

		/// <summary>Gets the copyright.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Copyright {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.CopyrightKey));
			}
		}

		/// <summary>Gets the last used date.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public NSDate? LastUsedDate {
			get {
				return Runtime.GetNSObject<NSDate> (GetHandle (NSMetadataQuery.LastUsedDateKey));
			}
		}

		/// <summary>Gets the content creation date.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public NSDate? ContentCreationDate {
			get {
				return Runtime.GetNSObject<NSDate> (GetHandle (NSMetadataQuery.ContentCreationDateKey));
			}
		}

		/// <summary>Gets the content modification date.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public NSDate? ContentModificationDate {
			get {
				return Runtime.GetNSObject<NSDate> (GetHandle (NSMetadataQuery.ContentModificationDateKey));
			}
		}

		/// <summary>Gets the date added.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public NSDate? DateAdded {
			get {
				return Runtime.GetNSObject<NSDate> (GetHandle (NSMetadataQuery.DateAddedKey));
			}
		}

		/// <summary>Gets the duration seconds.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? DurationSeconds {
			get {
				return GetNullableDouble (NSMetadataQuery.DurationSecondsKey);
			}
		}

		/// <summary>Gets the metadata key for contactwords.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? ContactKeywords {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.ContactKeywordsKey));
			}
		}

		/// <summary>Gets the version.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Version {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.VersionKey));
			}
		}

		/// <summary>Gets the pixel height.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public nint? PixelHeight {
			get {
				return GetNInt (NSMetadataQuery.PixelHeightKey);
			}
		}

		/// <summary>Gets the pixel width.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public nint? PixelWidth {
			get {
				return GetNInt (NSMetadataQuery.PixelWidthKey);
			}
		}

		/// <summary>Gets the pixel count.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public nint? PixelCount {
			get {
				return GetNInt (NSMetadataQuery.PixelCountKey);
			}
		}

		/// <summary>Gets the color space.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? ColorSpace {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.ColorSpaceKey));
			}
		}

		/// <summary>Gets the bits per sample.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public nint? BitsPerSample {
			get {
				return GetNInt (NSMetadataQuery.BitsPerSampleKey);
			}
		}

		/// <summary>Gets the flash on off.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public bool? FlashOnOff {
			get {
				return GetNullableBool (NSMetadataQuery.FlashOnOffKey);
			}
		}

		/// <summary>Gets the focal length.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? FocalLength {
			get {
				return GetNullableDouble (NSMetadataQuery.FocalLengthKey);
			}
		}

		/// <summary>Gets the acquisition make.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? AcquisitionMake {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.AcquisitionMakeKey));
			}
		}

		/// <summary>Gets the acquisition model.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? AcquisitionModel {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.AcquisitionModelKey));
			}
		}

		/// <summary>Gets the iso speed.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? IsoSpeed {
			get {
				return GetNullableDouble (NSMetadataQuery.IsoSpeedKey);
			}
		}

		/// <summary>Gets the orientation.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public nint? Orientation {
			get {
				return GetNInt (NSMetadataQuery.OrientationKey);
			}
		}

		/// <summary>Gets the layer names.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? LayerNames {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.LayerNamesKey));
			}
		}

		/// <summary>Gets the white balance.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? WhiteBalance {
			get {
				return GetNullableDouble (NSMetadataQuery.WhiteBalanceKey);
			}
		}

		/// <summary>Gets the aperture.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? Aperture {
			get {
				return GetNullableDouble (NSMetadataQuery.ApertureKey);
			}
		}

		/// <summary>Gets the profile name.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? ProfileName {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.ProfileNameKey));
			}
		}

		/// <summary>Gets the resolution width dpi.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public nint? ResolutionWidthDpi {
			get {
				return GetNInt (NSMetadataQuery.ResolutionWidthDpiKey);
			}
		}

		/// <summary>Gets the resolution height dpi.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public nint? ResolutionHeightDpi {
			get {
				return GetNInt (NSMetadataQuery.ResolutionHeightDpiKey);
			}
		}

		/// <summary>Gets the exposure mode.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public nint? ExposureMode {
			get {
				return GetNInt (NSMetadataQuery.ExposureModeKey);
			}
		}

		/// <summary>Gets the exposure time seconds.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? ExposureTimeSeconds {
			get {
				return GetNullableDouble (NSMetadataQuery.ExposureTimeSecondsKey);
			}
		}

		/// <summary>Gets the exif version.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? ExifVersion {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.ExifVersionKey));
			}
		}

		/// <summary>Gets the camera owner.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? CameraOwner {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.CameraOwnerKey));
			}
		}

		/// <summary>Gets the focal length35mm.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public nint? FocalLength35mm {
			get {
				return GetNInt (NSMetadataQuery.FocalLength35mmKey);
			}
		}

		/// <summary>Gets the lens model.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? LensModel {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.LensModelKey));
			}
		}

		/// <summary>Gets the exif gps version.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? ExifGpsVersion {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.ExifGpsVersionKey));
			}
		}

		/// <summary>Gets the altitude.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? Altitude {
			get {
				return GetNullableDouble (NSMetadataQuery.AltitudeKey);
			}
		}

		/// <summary>Gets the latitude.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? Latitude {
			get {
				return GetNullableDouble (NSMetadataQuery.LatitudeKey);
			}
		}

		/// <summary>Gets the longitude.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? Longitude {
			get {
				return GetNullableDouble (NSMetadataQuery.LongitudeKey);
			}
		}

		/// <summary>Gets the speed.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? Speed {
			get {
				return GetNullableDouble (NSMetadataQuery.SpeedKey);
			}
		}

		/// <summary>Gets the timestamp.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public NSDate? Timestamp {
			get {
				return Runtime.GetNSObject<NSDate> (GetHandle (NSMetadataQuery.TimestampKey));
			}
		}

		/// <summary>Gets the gps track.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? GpsTrack {
			get {
				return GetNullableDouble (NSMetadataQuery.GpsTrackKey);
			}
		}

		/// <summary>Gets the image direction.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? ImageDirection {
			get {
				return GetNullableDouble (NSMetadataQuery.ImageDirectionKey);
			}
		}

		/// <summary>Gets the named location.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? NamedLocation {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.NamedLocationKey));
			}
		}

		/// <summary>Gets the gps status.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? GpsStatus {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.GpsStatusKey));
			}
		}

		/// <summary>Gets the gps measure mode.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? GpsMeasureMode {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.GpsMeasureModeKey));
			}
		}

		/// <summary>Gets the gps dop.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? GpsDop {
			get {
				return GetNullableDouble (NSMetadataQuery.GpsDopKey);
			}
		}

		/// <summary>Gets the gps map datum.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? GpsMapDatum {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.GpsMapDatumKey));
			}
		}

		/// <summary>Gets the gps dest latitude.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? GpsDestLatitude {
			get {
				return GetNullableDouble (NSMetadataQuery.GpsDestLatitudeKey);
			}
		}

		/// <summary>Gets the gps dest longitude.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? GpsDestLongitude {
			get {
				return GetNullableDouble (NSMetadataQuery.GpsDestLongitudeKey);
			}
		}

		/// <summary>Gets the gps dest bearing.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? GpsDestBearing {
			get {
				return GetNullableDouble (NSMetadataQuery.GpsDestBearingKey);
			}
		}

		/// <summary>Gets the gps dest distance.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? GpsDestDistance {
			get {
				return GetNullableDouble (NSMetadataQuery.GpsDestDistanceKey);
			}
		}

		/// <summary>Gets the gps processing method.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? GpsProcessingMethod {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.GpsProcessingMethodKey));
			}
		}

		/// <summary>Gets the gps area information.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? GpsAreaInformation {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.GpsAreaInformationKey));
			}
		}

		/// <summary>Gets the gps date stamp.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public NSDate? GpsDateStamp {
			get {
				return Runtime.GetNSObject<NSDate> (GetHandle (NSMetadataQuery.GpsDateStampKey));
			}
		}

		/// <summary>Gets the gps differental.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? GpsDifferental {
			get {
				return GetNullableDouble (NSMetadataQuery.GpsDifferentalKey);
			}
		}

		/// <summary>Gets the codecs.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? Codecs {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.CodecsKey));
			}
		}

		/// <summary>Gets the media types.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? MediaTypes {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.MediaTypesKey));
			}
		}

		/// <summary>Gets the streamable.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public bool? Streamable {
			get {
				return GetNullableBool (NSMetadataQuery.StreamableKey);
			}
		}

		/// <summary>Gets the total bit rate.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public nint? TotalBitRate {
			get {
				return GetNInt (NSMetadataQuery.TotalBitRateKey);
			}
		}

		/// <summary>Gets the video bit rate.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public nint? VideoBitRate {
			get {
				return GetNInt (NSMetadataQuery.VideoBitRateKey);
			}
		}

		/// <summary>Gets the audio bit rate.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public nint? AudioBitRate {
			get {
				return GetNInt (NSMetadataQuery.AudioBitRateKey);
			}
		}

		/// <summary>Gets the delivery type.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? DeliveryType {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.DeliveryTypeKey));
			}
		}

		/// <summary>Gets the album.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Album {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.AlbumKey));
			}
		}


		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public bool? HasAlphaChannel {
			get {
				return GetNullableBool (NSMetadataQuery.HasAlphaChannelKey);
			}
		}

		/// <summary>Gets the red eye on off.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public bool? RedEyeOnOff {
			get {
				return GetNullableBool (NSMetadataQuery.RedEyeOnOffKey);
			}
		}

		/// <summary>Gets the metering mode.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? MeteringMode {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.MeteringModeKey));
			}
		}

		/// <summary>Gets the max aperture.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? MaxAperture {
			get {
				return GetNullableDouble (NSMetadataQuery.MaxApertureKey);
			}
		}

		/// <summary>Gets the f number.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public nint? FNumber {
			get {
				return GetNInt (NSMetadataQuery.FNumberKey);
			}
		}

		/// <summary>Gets the exposure program.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? ExposureProgram {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.ExposureProgramKey));
			}
		}

		/// <summary>Gets the exposure time string.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? ExposureTimeString {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.ExposureTimeStringKey));
			}
		}

		/// <summary>Gets the headline.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Headline {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.HeadlineKey));
			}
		}

		/// <summary>Gets the instructions.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Instructions {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.InstructionsKey));
			}
		}

		/// <summary>Gets the city.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? City {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.CityKey));
			}
		}

		/// <summary>Gets the state or province.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? StateOrProvince {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.StateOrProvinceKey));
			}
		}

		/// <summary>Gets the country.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Country {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.CountryKey));
			}
		}

		/// <summary>Gets the text content.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? TextContent {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.TextContentKey));
			}
		}

		/// <summary>Gets the audio sample rate.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public nint? AudioSampleRate {
			get {
				return GetNInt (NSMetadataQuery.AudioSampleRateKey);
			}
		}

		/// <summary>Gets the audio channel count.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public nint? AudioChannelCount {
			get {
				return GetNInt (NSMetadataQuery.AudioChannelCountKey);
			}
		}

		/// <summary>Gets the tempo.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? Tempo {
			get {
				return GetNullableDouble (NSMetadataQuery.TempoKey);
			}
		}

		/// <summary>Gets the metadata key for key signature.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? KeySignature {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.KeySignatureKey));
			}
		}

		/// <summary>Gets the time signature.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? TimeSignature {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.TimeSignatureKey));
			}
		}

		/// <summary>Gets the audio encoding application.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? AudioEncodingApplication {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.AudioEncodingApplicationKey));
			}
		}

		/// <summary>Gets the composer.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Composer {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.ComposerKey));
			}
		}

		/// <summary>Gets the lyricist.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Lyricist {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.LyricistKey));
			}
		}

		/// <summary>Gets the audio track number.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public nint? AudioTrackNumber {
			get {
				return GetNInt (NSMetadataQuery.AudioTrackNumberKey);
			}
		}

		/// <summary>Gets the recording date.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public NSDate? RecordingDate {
			get {
				return Runtime.GetNSObject<NSDate> (GetHandle (NSMetadataQuery.RecordingDateKey));
			}
		}

		/// <summary>Gets the musical genre.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? MusicalGenre {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.MusicalGenreKey));
			}
		}

		/// <summary>Gets the is general midi sequence.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public bool? IsGeneralMidiSequence {
			get {
				return GetNullableBool (NSMetadataQuery.IsGeneralMidiSequenceKey);
			}
		}

		/// <summary>Gets the recording year.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public nint? RecordingYear {
			get {
				return GetNInt (NSMetadataQuery.RecordingYearKey);
			}
		}

		/// <summary>Gets the organizations.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? Organizations {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.OrganizationsKey));
			}
		}

		/// <summary>Gets the languages.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? Languages {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.LanguagesKey));
			}
		}

		/// <summary>Gets the rights.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Rights {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.RightsKey));
			}
		}

		/// <summary>Gets the publishers.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? Publishers {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.PublishersKey));
			}
		}

		/// <summary>Gets the contributors.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? Contributors {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.ContributorsKey));
			}
		}

		/// <summary>Gets the coverage.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? Coverage {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.CoverageKey));
			}
		}

		/// <summary>Gets the subject.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Subject {
			get {
				return Runtime.GetNSObject<NSString> (GetHandle (NSMetadataQuery.SubjectKey));
			}
		}

		/// <summary>Gets the theme.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Theme {
			get {
				return Runtime.GetNSObject<NSString> (GetHandle (NSMetadataQuery.ThemeKey));
			}
		}

		/// <summary>Gets the description.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Description {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.DescriptionKey));
			}
		}

		/// <summary>Gets the identifier.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Identifier {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.IdentifierKey));
			}
		}

		/// <summary>Gets the audiences.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? Audiences {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.AudiencesKey));
			}
		}

		/// <summary>Gets the number of pages.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public nint? NumberOfPages {
			get {
				return GetNInt (NSMetadataQuery.NumberOfPagesKey);
			}
		}

		/// <summary>Gets the page width.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? PageWidth {
			get {
				return GetNullableDouble (NSMetadataQuery.PageWidthKey);
			}
		}

		/// <summary>Gets the page height.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? PageHeight {
			get {
				return GetNullableDouble (NSMetadataQuery.PageHeightKey);
			}
		}

		/// <summary>Gets the security method.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? SecurityMethod {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.SecurityMethodKey));
			}
		}

		/// <summary>Gets the creator.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Creator {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.CreatorKey));
			}
		}

		/// <summary>Gets the encoding applications.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? EncodingApplications {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.EncodingApplicationsKey));
			}
		}

		/// <summary>Gets the due date.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public NSDate? DueDate {
			get {
				return Runtime.GetNSObject<NSDate> (GetHandle (NSMetadataQuery.DueDateKey));
			}
		}

		/// <summary>Gets the star rating.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public double? StarRating {
			get {
				return GetNullableDouble (NSMetadataQuery.StarRatingKey);
			}
		}

		/// <summary>Gets the phone numbers.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? PhoneNumbers {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.PhoneNumbersKey));
			}
		}

		/// <summary>Gets the email addresses.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? EmailAddresses {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.EmailAddressesKey));
			}
		}

		/// <summary>Gets the instant message addresses.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? InstantMessageAddresses {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.InstantMessageAddressesKey));
			}
		}

		/// <summary>Gets the kind.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Kind {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.KindKey));
			}
		}

		/// <summary>Gets the recipients.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? Recipients {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.RecipientsKey));
			}
		}

		/// <summary>Gets the finder comment.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? FinderComment {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.FinderCommentKey));
			}
		}

		/// <summary>Gets the fonts.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? Fonts {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.FontsKey));
			}
		}

		/// <summary>Gets the apple loops root.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? AppleLoopsRoot {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.AppleLoopsRootKeyKey));
			}
		}

		/// <summary>Gets the metadata key for apple loops filter type.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? AppleLoopsKeyFilterType {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.AppleLoopsKeyFilterTypeKey));
			}
		}

		/// <summary>Gets the apple loops loop mode.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? AppleLoopsLoopMode {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.AppleLoopsLoopModeKey));
			}
		}

		/// <summary>Gets the apple loop descriptors.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? AppleLoopDescriptors {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.AppleLoopDescriptorsKey));
			}
		}

		/// <summary>Gets the musical instrument category.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? MusicalInstrumentCategory {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.MusicalInstrumentCategoryKey));
			}
		}

		/// <summary>Gets the musical instrument name.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? MusicalInstrumentName {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.MusicalInstrumentNameKey));
			}
		}

		/// <summary>Gets the c f bundle identifier.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? CFBundleIdentifier {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.CFBundleIdentifierKey));
			}
		}

		/// <summary>Gets the information.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Information {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.InformationKey));
			}
		}

		/// <summary>Gets the director.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Director {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.DirectorKey));
			}
		}

		/// <summary>Gets the producer.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Producer {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.ProducerKey));
			}
		}

		/// <summary>Gets the genre.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? Genre {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.GenreKey));
			}
		}

		/// <summary>Gets the performers.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? Performers {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.PerformersKey));
			}
		}

		/// <summary>Gets the original format.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? OriginalFormat {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.OriginalFormatKey));
			}
		}

		/// <summary>Gets the original source.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? OriginalSource {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.OriginalSourceKey));
			}
		}

		/// <summary>Gets the author email addresses.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? AuthorEmailAddresses {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.AuthorEmailAddressesKey));
			}
		}

		/// <summary>Gets the recipient email addresses.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? RecipientEmailAddresses {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.RecipientEmailAddressesKey));
			}
		}

		/// <summary>Gets the author addresses.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? AuthorAddresses {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.AuthorAddressesKey));
			}
		}

		/// <summary>Gets the recipient addresses.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? RecipientAddresses {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.RecipientAddressesKey));
			}
		}

		/// <summary>Gets the is likely junk.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public bool? IsLikelyJunk {
			get {
				return GetNullableBool (NSMetadataQuery.IsLikelyJunkKey);
			}
		}

		/// <summary>Gets the executable architectures.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? ExecutableArchitectures {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.ExecutableArchitecturesKey));
			}
		}

		/// <summary>Gets the executable platform.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? ExecutablePlatform {
			get {
				return CFString.FromHandle (GetHandle (NSMetadataQuery.ExecutablePlatformKey));
			}
		}

		/// <summary>Gets the application categories.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public string? []? ApplicationCategories {
			get {
				return CFArray.StringArrayFromHandle (GetHandle (NSMetadataQuery.ApplicationCategoriesKey));
			}
		}

		/// <summary>Gets the is application managed.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public bool? IsApplicationManaged {
			get {
				return GetNullableBool (NSMetadataQuery.IsApplicationManagedKey);
			}
		}
#endif
	}
}
