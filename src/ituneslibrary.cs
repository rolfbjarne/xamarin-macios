// Copyright 2018-2019, Microsoft, Corp.
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
using AppKit;

namespace iTunesLibrary {

	[BaseType (typeof (NSObject))]
	interface ITLibAlbum {
		/// <summary>Gets the album title.</summary>
		[NullAllowed, Export ("title")]
		string Title { get; }

		/// <summary>Gets the sort title for the album.</summary>
		[NullAllowed, Export ("sortTitle")]
		string SortTitle { get; }

		/// <summary>Gets whether the album is a compilation.</summary>
		[Export ("compilation")]
		bool Compilation { [Bind ("isCompilation")] get; }

		/// <summary>Gets the album artist.</summary>
		[NullAllowed, Export ("artist", ArgumentSemantic.Retain)]
		ITLibArtist Artist { get; }

		/// <summary>Gets the total number of discs in the album.</summary>
		[Export ("discCount")]
		nuint DiscCount { get; }

		/// <summary>Gets the disc number of this album.</summary>
		[Export ("discNumber")]
		nuint DiscNumber { get; }

		/// <summary>Gets the album rating.</summary>
		[Export ("rating")]
		nint Rating { get; }

		/// <summary>Gets whether the rating is computed.</summary>
		[Export ("ratingComputed")]
		bool RatingComputed { [Bind ("isRatingComputed")] get; }

		/// <summary>Gets whether the album is gapless.</summary>
		[Export ("gapless")]
		bool Gapless { [Bind ("isGapless")] get; }

		/// <summary>Gets the total number of tracks in the album.</summary>
		[Export ("trackCount")]
		nuint TrackCount { get; }

		/// <summary>Gets the album artist name.</summary>
		[NullAllowed, Export ("albumArtist")]
		string AlbumArtist { get; }

		/// <summary>Gets the sort name for the album artist.</summary>
		[NullAllowed, Export ("sortAlbumArtist")]
		string SortAlbumArtist { get; }

		/// <summary>Gets the persistent identifier for the album.</summary>
		[Export ("persistentID", ArgumentSemantic.Retain)]
		NSNumber PersistentId { get; }
	}

	[BaseType (typeof (NSObject))]
	interface ITLibArtist {
		/// <summary>Gets the artist name.</summary>
		[NullAllowed, Export ("name")]
		string Name { get; }

		/// <summary>Gets the sort name for the artist.</summary>
		[NullAllowed, Export ("sortName")]
		string SortName { get; }

		/// <summary>Gets the persistent identifier for the artist.</summary>
		[Export ("persistentID", ArgumentSemantic.Retain)]
		NSNumber PersistentId { get; }
	}

	[BaseType (typeof (NSObject))]
	interface ITLibArtwork {
		/// <summary>Gets the artwork image.</summary>
		[NullAllowed, Export ("image", ArgumentSemantic.Retain)]
		NSImage Image { get; }

		/// <summary>Gets the raw image data.</summary>
		[NullAllowed, Export ("imageData", ArgumentSemantic.Retain)]
		NSData ImageData { get; }

		/// <summary>Gets the format of the image data.</summary>
		[Export ("imageDataFormat", ArgumentSemantic.Assign)]
		ITLibArtworkFormat ImageDataFormat { get; }
	}

	delegate void ITLibMediaEntityEnumerateValuesHandler (NSString property, NSObject value, out bool stop);

	[BaseType (typeof (NSObject))]
	interface ITLibMediaEntity {
		/// <summary>Gets the persistent identifier for the media entity.</summary>
		[Export ("persistentID", ArgumentSemantic.Retain)]
		NSNumber PersistentId { get; }

		/// <param name="property">The property name to retrieve.</param>
		/// <summary>Gets the value for the specified property.</summary>
		/// <returns>The value of the property, or <see langword="null" /> if not found.</returns>
		[Export ("valueForProperty:")]
		[return: NullAllowed]
		NSObject GetValue (string property);

		/// <param name="properties">The set of property names to enumerate, or <see langword="null" /> for all.</param>
		/// <param name="handler">The handler to call for each property value.</param>
		/// <summary>Enumerates values for the specified properties.</summary>
		[Export ("enumerateValuesForProperties:usingBlock:")]
		void EnumerateValues ([NullAllowed] NSSet<NSString> properties, ITLibMediaEntityEnumerateValuesHandler handler);

		/// <param name="properties">The set of property names to exclude, or <see langword="null" /> for none.</param>
		/// <param name="handler">The handler to call for each property value.</param>
		/// <summary>Enumerates values for all properties except those specified.</summary>
		[Export ("enumerateValuesExceptForProperties:usingBlock:")]
		void EnumerateValuesExcept ([NullAllowed] NSSet<NSString> properties, ITLibMediaEntityEnumerateValuesHandler handler);
	}

	[BaseType (typeof (ITLibMediaEntity))]
	interface ITLibMediaItem {
		/// <summary>Gets the media item title.</summary>
		[Export ("title")]
		string Title { get; }

		/// <summary>Gets the sort title for the media item.</summary>
		[NullAllowed, Export ("sortTitle")]
		string SortTitle { get; }

		/// <summary>Gets the artist for the media item.</summary>
		[NullAllowed, Export ("artist", ArgumentSemantic.Retain)]
		ITLibArtist Artist { get; }

		/// <summary>Gets the composer name.</summary>
		[Export ("composer")]
		string Composer { get; }

		/// <summary>Gets the sort name for the composer.</summary>
		[NullAllowed, Export ("sortComposer")]
		string SortComposer { get; }

		/// <summary>Gets the user-assigned rating.</summary>
		[Export ("rating")]
		nint Rating { get; }

		/// <summary>Gets whether the rating is computed.</summary>
		[Export ("ratingComputed")]
		bool RatingComputed { [Bind ("isRatingComputed")] get; }

		/// <summary>Gets the start time offset in milliseconds.</summary>
		[Export ("startTime")]
		nuint StartTime { get; }

		/// <summary>Gets the stop time offset in milliseconds.</summary>
		[Export ("stopTime")]
		nuint StopTime { get; }

		/// <summary>Gets the album information for the media item.</summary>
		[Export ("album", ArgumentSemantic.Retain)]
		ITLibAlbum Album { get; }

		/// <summary>Gets the genre of the media item.</summary>
		[Export ("genre")]
		string Genre { get; }

		/// <summary>Gets the kind description.</summary>
		[NullAllowed, Export ("kind")]
		string Kind { get; }

		/// <summary>Gets the media kind (song, movie, podcast, etc.).</summary>
		[Export ("mediaKind", ArgumentSemantic.Assign)]
		ITLibMediaItemMediaKind MediaKind { get; }

		/// <summary>Gets the file size in bytes.</summary>
		[Export ("fileSize")]
		ulong FileSize { get; }

		/// <summary>Gets the size in bytes.</summary>
		[Export ("size")]
		nuint Size { get; }

		/// <summary>Gets the total duration in milliseconds.</summary>
		[Export ("totalTime")]
		nuint TotalTime { get; }

		/// <summary>Gets the track number.</summary>
		[Export ("trackNumber")]
		nuint TrackNumber { get; }

		/// <summary>Gets the category of the media item.</summary>
		[NullAllowed, Export ("category")]
		string Category { get; }

		/// <summary>Gets the description of the media item.</summary>
		[NullAllowed, Export ("description")]
		string Description { get; }

		/// <summary>Gets the lyrics content rating.</summary>
		[Export ("lyricsContentRating", ArgumentSemantic.Assign)]
		ITLibMediaItemLyricsContentRating LyricsContentRating { get; }

		/// <summary>Gets the content rating string.</summary>
		[NullAllowed, Export ("contentRating")]
		string ContentRating { get; }

		/// <summary>Gets the date the item was last modified.</summary>
		[NullAllowed, Export ("modifiedDate", ArgumentSemantic.Retain)]
		NSDate ModifiedDate { get; }

		/// <summary>Gets the date the item was added to the library.</summary>
		[NullAllowed, Export ("addedDate", ArgumentSemantic.Retain)]
		NSDate AddedDate { get; }

		/// <summary>Gets the bit rate in kbps.</summary>
		[Export ("bitrate")]
		nuint Bitrate { get; }

		/// <summary>Gets the sample rate in Hz.</summary>
		[Export ("sampleRate")]
		nuint SampleRate { get; }

		/// <summary>Gets the beats per minute.</summary>
		[Export ("beatsPerMinute")]
		nuint BeatsPerMinute { get; }

		/// <summary>Gets the number of times the item has been played.</summary>
		[Export ("playCount")]
		nuint PlayCount { get; }

		/// <summary>Gets the date the item was last played.</summary>
		[NullAllowed, Export ("lastPlayedDate", ArgumentSemantic.Retain)]
		NSDate LastPlayedDate { get; }

		/// <summary>Gets the play status of the item.</summary>
		[Export ("playStatus", ArgumentSemantic.Assign)]
		ITLibMediaItemPlayStatus PlayStatus { get; }

		/// <summary>Gets the file location URL.</summary>
		[NullAllowed, Export ("location", ArgumentSemantic.Retain)]
		NSUrl Location { get; }

		/// <summary>Gets whether artwork is available.</summary>
		[Export ("artworkAvailable")]
		bool ArtworkAvailable { [Bind ("hasArtworkAvailable")] get; }

		/// <summary>Gets the artwork for the media item.</summary>
		[NullAllowed, Export ("artwork", ArgumentSemantic.Retain)]
		ITLibArtwork Artwork { get; }

		/// <summary>Gets user comments.</summary>
		[NullAllowed, Export ("comments")]
		string Comments { get; }

		/// <summary>Gets whether the item was purchased from the iTunes Store.</summary>
		[Export ("purchased")]
		bool Purchased { [Bind ("isPurchased")] get; }

		/// <summary>Gets whether the item is stored in the cloud.</summary>
		[Export ("cloud")]
		bool Cloud { [Bind ("isCloud")] get; }

		/// <summary>Gets whether the item is DRM protected.</summary>
		[Export ("drmProtected")]
		bool DrmProtected { [Bind ("isDRMProtected")] get; }

		/// <summary>Gets whether the item is a video.</summary>
		[Export ("video")]
		bool Video { [Bind ("isVideo")] get; }

		/// <summary>Gets the video information for the item.</summary>
		[NullAllowed, Export ("videoInfo", ArgumentSemantic.Retain)]
		ITLibMediaItemVideoInfo VideoInfo { get; }

		/// <summary>Gets the release date.</summary>
		[NullAllowed, Export ("releaseDate", ArgumentSemantic.Retain)]
		NSDate ReleaseDate { get; }

		/// <summary>Gets the release year.</summary>
		[Export ("year")]
		nuint Year { get; }

		/// <summary>Gets the file type code.</summary>
		[Export ("fileType")]
		nuint FileType { get; }

		/// <summary>Gets the number of times the item was skipped.</summary>
		[Export ("skipCount")]
		nuint SkipCount { get; }

		/// <summary>Gets the date the item was last skipped.</summary>
		[NullAllowed, Export ("skipDate", ArgumentSemantic.Retain)]
		NSDate SkipDate { get; }

		/// <summary>Gets the VoiceOver language.</summary>
		[NullAllowed, Export ("voiceOverLanguage")]
		string VoiceOverLanguage { get; }

		/// <summary>Gets the volume adjustment in percentage.</summary>
		[Export ("volumeAdjustment")]
		nint VolumeAdjustment { get; }

		/// <summary>Gets the volume normalization energy.</summary>
		[Export ("volumeNormalizationEnergy")]
		nuint VolumeNormalizationEnergy { get; }

		/// <summary>Gets whether the item is disabled by the user.</summary>
		[Export ("userDisabled")]
		bool UserDisabled { [Bind ("isUserDisabled")] get; }

		/// <summary>Gets the grouping string.</summary>
		[NullAllowed, Export ("grouping")]
		string Grouping { get; }

		/// <summary>Gets the location type.</summary>
		[Export ("locationType", ArgumentSemantic.Assign)]
		ITLibMediaItemLocationType LocationType { get; }
	}

	[BaseType (typeof (NSObject))]
	interface ITLibMediaItemVideoInfo {
		/// <summary>Gets the series name.</summary>
		[NullAllowed, Export ("series")]
		string Series { get; }

		/// <summary>Gets the sort name for the series.</summary>
		[NullAllowed, Export ("sortSeries")]
		string SortSeries { get; }

		/// <summary>Gets the season number.</summary>
		[Export ("season")]
		nuint Season { get; }

		/// <summary>Gets the episode identifier.</summary>
		[NullAllowed, Export ("episode")]
		string Episode { get; }

		/// <summary>Gets the episode sort order.</summary>
		[Export ("episodeOrder")]
		nint EpisodeOrder { get; }

		/// <summary>Gets whether the video is HD.</summary>
		[Export ("hd")]
		bool HD { [Bind ("isHD")] get; }

		/// <summary>Gets the video width in pixels.</summary>
		[Export ("videoWidth")]
		nuint VideoWidth { get; }

		/// <summary>Gets the video height in pixels.</summary>
		[Export ("videoHeight")]
		nuint VideoHeight { get; }
	}

	[BaseType (typeof (ITLibMediaEntity))]
	interface ITLibPlaylist {
		/// <summary>Gets the playlist name.</summary>
		[Export ("name")]
		string Name { get; }

		/// <summary>Gets whether this is the master playlist.</summary>
		[Deprecated (PlatformName.MacOSX, 12, 0, message: "Use 'Primary' instead.")]
		[Export ("master")]
		bool Master { [Bind ("isMaster")] get; }

		[Export ("primary")]
		bool Primary { [Bind ("isPrimary")] get; }

		/// <summary>Gets the persistent identifier of the parent playlist.</summary>
		[NullAllowed, Export ("parentID", ArgumentSemantic.Retain)]
		NSNumber ParentId { get; }

		/// <summary>Gets whether the playlist is visible.</summary>
		[Export ("visible")]
		bool Visible { [Bind ("isVisible")] get; }

		/// <summary>Gets whether this is the all-items playlist.</summary>
		[Export ("allItemsPlaylist")]
		bool AllItemsPlaylist { [Bind ("isAllItemsPlaylist")] get; }

		/// <summary>Gets the media items in the playlist.</summary>
		[Export ("items", ArgumentSemantic.Retain)]
		ITLibMediaItem [] Items { get; }

		/// <summary>Gets the distinguished playlist kind.</summary>
		[Export ("distinguishedKind", ArgumentSemantic.Assign)]
		ITLibDistinguishedPlaylistKind DistinguishedKind { get; }

		/// <summary>Gets the playlist kind.</summary>
		[Export ("kind", ArgumentSemantic.Assign)]
		ITLibPlaylistKind Kind { get; }
	}

	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface ITLibrary {
		/// <summary>Gets the application version.</summary>
		[Export ("applicationVersion")]
		string ApplicationVersion { get; }

		/// <summary>Gets the supported export features.</summary>
		[Export ("features", ArgumentSemantic.Assign)]
		ITLibExportFeature Features { get; }

		/// <summary>Gets the API major version number.</summary>
		[Export ("apiMajorVersion")]
		nuint ApiMajorVersion { get; }

		/// <summary>Gets the API minor version number.</summary>
		[Export ("apiMinorVersion")]
		nuint ApiMinorVersion { get; }

		/// <summary>Gets the media folder location.</summary>
		[NullAllowed, Export ("mediaFolderLocation", ArgumentSemantic.Copy)]
		NSUrl MediaFolderLocation { get; }

		/// <summary>Gets the music folder location.</summary>
		[NullAllowed, Export ("musicFolderLocation", ArgumentSemantic.Copy)]
		NSUrl MusicFolderLocation { get; }

		/// <summary>Gets whether content ratings should be shown.</summary>
		[Export ("showContentRating")]
		bool ShowContentRating { [Bind ("shouldShowContentRating")] get; }

		/// <summary>Gets all media items in the library.</summary>
		[Export ("allMediaItems", ArgumentSemantic.Retain)]
		ITLibMediaItem [] AllMediaItems { get; }

		/// <summary>Gets all playlists in the library.</summary>
		[Export ("allPlaylists", ArgumentSemantic.Retain)]
		ITLibPlaylist [] AllPlaylists { get; }

		/// <param name="requestedAPIVersion">The API version to request.</param>
		/// <param name="error">On return, contains any error that occurred.</param>
		/// <summary>Gets a library instance for the specified API version.</summary>
		/// <returns>The library instance, or <see langword="null" /> on error.</returns>
		[Static]
		[Export ("libraryWithAPIVersion:error:")]
		[return: NullAllowed]
		ITLibrary GetLibrary (string requestedAPIVersion, [NullAllowed] out NSError error);

		/// <param name="requestedAPIVersion">The API version to request.</param>
		/// <param name="options">The initialization options.</param>
		/// <param name="error">On return, contains any error that occurred.</param>
		/// <summary>Gets a library instance with the specified API version and options.</summary>
		/// <returns>The library instance, or <see langword="null" /> on error.</returns>
		[Static]
		[Export ("libraryWithAPIVersion:options:error:")]
		[return: NullAllowed]
		ITLibrary GetLibrary (string requestedAPIVersion, ITLibInitOptions options, [NullAllowed] out NSError error);

		/// <param name="requestedAPIVersion">The API version to request.</param>
		/// <param name="error">On return, contains any error that occurred.</param>
		/// <summary>Creates a library instance for the specified API version.</summary>
		
		[Export ("initWithAPIVersion:error:")]
		NativeHandle Constructor (string requestedAPIVersion, [NullAllowed] out NSError error);

		/// <param name="requestedAPIVersion">The API version to request.</param>
		/// <param name="options">The initialization options.</param>
		/// <param name="error">On return, contains any error that occurred.</param>
		/// <summary>Creates a library instance with the specified API version and options.</summary>
		
		[DesignatedInitializer]
		[Export ("initWithAPIVersion:options:error:")]
		NativeHandle Constructor (string requestedAPIVersion, ITLibInitOptions options, [NullAllowed] out NSError error);

		/// <param name="mediaFileUrl">The URL of the media file.</param>
		/// <summary>Gets the artwork for the specified media file.</summary>
		/// <returns>The artwork, or <see langword="null" /> if none is available.</returns>
		[Export ("artworkForMediaFile:")]
		[return: NullAllowed]
		ITLibArtwork GetArtwork (NSUrl mediaFileUrl);

		/// <summary>Reloads the library data from disk.</summary>
		/// <returns><see langword="true" /> if the data was reloaded; otherwise, <see langword="false" />.</returns>
		[Export ("reloadData")]
		bool ReloadData ();

		/// <summary>Unloads the library data from memory.</summary>
		[Export ("unloadData")]
		void UnloadData ();
	}

	[Mac (13, 0), NoiOS, NoMacCatalyst, NoTV]
	[Static]
	interface ITLibraryNotifications {
		[Field ("ITLibraryDidChangeNotification")]
		[Notification]
		NSString DidChangeNotification { get; }
	}
}
