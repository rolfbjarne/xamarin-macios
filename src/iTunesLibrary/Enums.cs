// Copyright 2018, Microsoft Corp.
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
//

namespace iTunesLibrary {

	[Native]
	public enum ITLibArtworkFormat : ulong {
		/// <summary>No artwork format.</summary>
		None = 0,
		/// <summary>Bitmap format.</summary>
		Bitmap = 1,
		/// <summary>JPEG format.</summary>
		Jpeg = 2,
		/// <summary>JPEG 2000 format.</summary>
		Jpeg2000 = 3,
		/// <summary>GIF format.</summary>
		Gif = 4,
		/// <summary>PNG format.</summary>
		Png = 5,
		/// <summary>BMP format.</summary>
		Bmp = 6,
		/// <summary>TIFF format.</summary>
		Tiff = 7,
		/// <summary>PICT format.</summary>
		Pict = 8,
	}

	[Native]
	public enum ITLibMediaItemMediaKind : ulong {
		/// <summary>An unknown media kind.</summary>
		Unknown = 1,
		/// <summary>A song.</summary>
		Song = 2,
		/// <summary>A movie.</summary>
		Movie = 3,
		/// <summary>A podcast.</summary>
		Podcast = 4,
		/// <summary>An audiobook.</summary>
		Audiobook = 5,
		/// <summary>A pdf booklet media item.</summary>
		PdfBooklet = 6,
		/// <summary>A music video.</summary>
		MusicVideo = 7,
		/// <summary>A TV show.</summary>
		TVShow = 8,
		/// <summary>An interactive booklet.</summary>
		InteractiveBooklet = 9,
		/// <summary>A home video.</summary>
		HomeVideo = 12,
		/// <summary>A ringtone.</summary>
		Ringtone = 14,
		/// <summary>A digital booklet.</summary>
		DigitalBooklet = 15,
		/// <summary>A i o s application media item.</summary>
		iOSApplication = 16,
		/// <summary>A voice memo.</summary>
		VoiceMemo = 17,
		/// <summary>A i tunes u media item.</summary>
		iTunesU = 18,
		/// <summary>A book.</summary>
		Book = 19,
		/// <summary>A pdf book media item.</summary>
		PdfBook = 20,
		/// <summary>An alert tone.</summary>
		AlertTone = 21,
	}

	[Native]
	public enum ITLibMediaItemLyricsContentRating : ulong {
		/// <summary>No content rating.</summary>
		None = 0,
		/// <summary>Explicit content.</summary>
		Explicit = 1,
		/// <summary>Clean content.</summary>
		Clean = 2,
	}

	[Native]
	public enum ITLibMediaItemLocationType : ulong {
		/// <summary>An unknown location type.</summary>
		Unknown = 0,
		/// <summary>A file location.</summary>
		File = 1,
		/// <summary>A url location.</summary>
		Url = 2,
		/// <summary>A remote location.</summary>
		Remote = 3,
	}

	[Native]
	public enum ITLibMediaItemPlayStatus : ulong {
		/// <summary>No play status.</summary>
		None = 0,
		/// <summary>Partially played.</summary>
		PartiallyPlayed = 1,
		/// <summary>Not yet played.</summary>
		Unplayed = 2,
	}

	[Native]
	public enum ITLibDistinguishedPlaylistKind : ulong {
		/// <summary>The none playlist kind.</summary>
		None = 0,
		/// <summary>The movies playlist kind.</summary>
		Movies = 1,
		/// <summary>The t v shows playlist kind.</summary>
		TVShows = 2,
		/// <summary>The music playlist kind.</summary>
		Music = 3,
		/// <summary>The audiobooks playlist kind.</summary>
		Audiobooks = 4,
		/// <summary>The books playlist kind.</summary>
		Books = Audiobooks,
		/// <summary>The ringtones playlist kind.</summary>
		Ringtones = 5,
		/// <summary>The podcasts playlist kind.</summary>
		Podcasts = 7,
		/// <summary>The voice memos playlist kind.</summary>
		VoiceMemos = 14,
		/// <summary>The purchases playlist kind.</summary>
		Purchases = 16,
		/// <summary>The i tunes u playlist kind.</summary>
		iTunesU = 26,
		/// <summary>The nighties music playlist kind.</summary>
		NightiesMusic = 42,
		/// <summary>The my top rated playlist kind.</summary>
		MyTopRated = 43,
		/// <summary>The top25 most played playlist kind.</summary>
		Top25MostPlayed = 44,
		/// <summary>The recently played playlist kind.</summary>
		RecentlyPlayed = 45,
		/// <summary>The recently added playlist kind.</summary>
		RecentlyAdded = 46,
		/// <summary>The music videos playlist kind.</summary>
		MusicVideos = 47,
		/// <summary>The classical music playlist kind.</summary>
		ClassicalMusic = 48,
		/// <summary>The library music videos playlist kind.</summary>
		LibraryMusicVideos = 49,
		/// <summary>The home videos playlist kind.</summary>
		HomeVideos = 50,
		/// <summary>The applications playlist kind.</summary>
		Applications = 51,
		/// <summary>The loved songs playlist kind.</summary>
		LovedSongs = 52,
		/// <summary>The music shows and movies playlist kind.</summary>
		MusicShowsAndMovies = 53,
	}

	[Native]
	public enum ITLibPlaylistKind : ulong {
		/// <summary>Regular.</summary>
		Regular,
		/// <summary>Smart.</summary>
		Smart,
		/// <summary>Genius.</summary>
		Genius,
		/// <summary>Folder.</summary>
		Folder,
		/// <summary>Genius Mix.</summary>
		GeniusMix,
	}

	[Native]
	public enum ITLibExportFeature : ulong {
		/// <summary>I T Lib Export Feature None.</summary>
		ITLibExportFeatureNone = 0,
	}

	[Native]
	public enum ITLibInitOptions : ulong {
		/// <summary>No initialization options.</summary>
		None = 0,
		/// <summary>Load data lazily on demand.</summary>
		LazyLoadData = 1,
	}

	public enum MediaItemProperty {
		/// <summary>Album Title.</summary>
		[Field ("ITLibMediaItemPropertyAlbumTitle")]
		AlbumTitle,
		/// <summary>Sort Album Title.</summary>
		[Field ("ITLibMediaItemPropertySortAlbumTitle")]
		SortAlbumTitle,
		/// <summary>Album Artist.</summary>
		[Field ("ITLibMediaItemPropertyAlbumArtist")]
		AlbumArtist,
		/// <summary>Album Rating.</summary>
		[Field ("ITLibMediaItemPropertyAlbumRating")]
		AlbumRating,
		/// <summary>Album Rating Computed.</summary>
		[Field ("ITLibMediaItemPropertyAlbumRatingComputed")]
		AlbumRatingComputed,
		/// <summary>Sort Album Artist.</summary>
		[Field ("ITLibMediaItemPropertySortAlbumArtist")]
		SortAlbumArtist,
		/// <summary>Album Is Gapless.</summary>
		[Field ("ITLibMediaItemPropertyAlbumIsGapless")]
		AlbumIsGapless,
		/// <summary>Album Is Compilation.</summary>
		[Field ("ITLibMediaItemPropertyAlbumIsCompilation")]
		AlbumIsCompilation,
		/// <summary>Album Disc Count.</summary>
		[Field ("ITLibMediaItemPropertyAlbumDiscCount")]
		AlbumDiscCount,
		/// <summary>Album Disc Number.</summary>
		[Field ("ITLibMediaItemPropertyAlbumDiscNumber")]
		AlbumDiscNumber,
		/// <summary>Album Track Count.</summary>
		[Field ("ITLibMediaItemPropertyAlbumTrackCount")]
		AlbumTrackCount,
		/// <summary>Artist Name.</summary>
		[Field ("ITLibMediaItemPropertyArtistName")]
		ArtistName,
		/// <summary>Sort Artist Name.</summary>
		[Field ("ITLibMediaItemPropertySortArtistName")]
		SortArtistName,
		/// <summary>Video Is H D.</summary>
		[Field ("ITLibMediaItemPropertyVideoIsHD")]
		VideoIsHD,
		/// <summary>Video Width.</summary>
		[Field ("ITLibMediaItemPropertyVideoWidth")]
		VideoWidth,
		/// <summary>Video Height.</summary>
		[Field ("ITLibMediaItemPropertyVideoHeight")]
		VideoHeight,
		/// <summary>Video Series.</summary>
		[Field ("ITLibMediaItemPropertyVideoSeries")]
		VideoSeries,
		/// <summary>Video Sort Series.</summary>
		[Field ("ITLibMediaItemPropertyVideoSortSeries")]
		VideoSortSeries,
		/// <summary>Video Season.</summary>
		[Field ("ITLibMediaItemPropertyVideoSeason")]
		VideoSeason,
		/// <summary>Video Episode.</summary>
		[Field ("ITLibMediaItemPropertyVideoEpisode")]
		VideoEpisode,
		/// <summary>Video Episode Order.</summary>
		[Field ("ITLibMediaItemPropertyVideoEpisodeOrder")]
		VideoEpisodeOrder,
		/// <summary>Has Artwork.</summary>
		[Field ("ITLibMediaItemPropertyHasArtwork")]
		HasArtwork,
		/// <summary>Bit Rate.</summary>
		[Field ("ITLibMediaItemPropertyBitRate")]
		BitRate,
		/// <summary>Beats Per Minute.</summary>
		[Field ("ITLibMediaItemPropertyBeatsPerMinute")]
		BeatsPerMinute,
		/// <summary>Category.</summary>
		[Field ("ITLibMediaItemPropertyCategory")]
		Category,
		/// <summary>Comments.</summary>
		[Field ("ITLibMediaItemPropertyComments")]
		Comments,
		/// <summary>Composer.</summary>
		[Field ("ITLibMediaItemPropertyComposer")]
		Composer,
		/// <summary>Sort Composer.</summary>
		[Field ("ITLibMediaItemPropertySortComposer")]
		SortComposer,
		/// <summary>Content Rating.</summary>
		[Field ("ITLibMediaItemPropertyContentRating")]
		ContentRating,
		/// <summary>Lyrics Content Rating.</summary>
		[Field ("ITLibMediaItemPropertyLyricsContentRating")]
		LyricsContentRating,
		/// <summary>Added Date.</summary>
		[Field ("ITLibMediaItemPropertyAddedDate")]
		AddedDate,
		/// <summary>Modified Date.</summary>
		[Field ("ITLibMediaItemPropertyModifiedDate")]
		ModifiedDate,
		/// <summary>Description.</summary>
		[Field ("ITLibMediaItemPropertyDescription")]
		Description,
		/// <summary>Is User Disabled.</summary>
		[Field ("ITLibMediaItemPropertyIsUserDisabled")]
		IsUserDisabled,
		/// <summary>File Type.</summary>
		[Field ("ITLibMediaItemPropertyFileType")]
		FileType,
		/// <summary>Genre.</summary>
		[Field ("ITLibMediaItemPropertyGenre")]
		Genre,
		/// <summary>Grouping.</summary>
		[Field ("ITLibMediaItemPropertyGrouping")]
		Grouping,
		/// <summary>Is Video.</summary>
		[Field ("ITLibMediaItemPropertyIsVideo")]
		IsVideo,
		/// <summary>Kind.</summary>
		[Field ("ITLibMediaItemPropertyKind")]
		Kind,
		/// <summary>Title.</summary>
		[Field ("ITLibMediaItemPropertyTitle")]
		Title,
		/// <summary>Sort Title.</summary>
		[Field ("ITLibMediaItemPropertySortTitle")]
		SortTitle,
		/// <summary>Volume Normalization Energy.</summary>
		[Field ("ITLibMediaItemPropertyVolumeNormalizationEnergy")]
		VolumeNormalizationEnergy,
		/// <summary>Play Count.</summary>
		[Field ("ITLibMediaItemPropertyPlayCount")]
		PlayCount,
		/// <summary>Last Play Date.</summary>
		[Field ("ITLibMediaItemPropertyLastPlayDate")]
		LastPlayDate,
		/// <summary>Play Status.</summary>
		[Field ("ITLibMediaItemPropertyPlayStatus")]
		PlayStatus,
		/// <summary>Is Drm Protected.</summary>
		[Field ("ITLibMediaItemPropertyIsDRMProtected")]
		IsDrmProtected,
		/// <summary>Is Purchased.</summary>
		[Field ("ITLibMediaItemPropertyIsPurchased")]
		IsPurchased,
		/// <summary>Movement Count.</summary>
		[Field ("ITLibMediaItemPropertyMovementCount")]
		MovementCount,
		/// <summary>Movement Name.</summary>
		[Field ("ITLibMediaItemPropertyMovementName")]
		MovementName,
		/// <summary>Movement Number.</summary>
		[Field ("ITLibMediaItemPropertyMovementNumber")]
		MovementNumber,
		/// <summary>Rating.</summary>
		[Field ("ITLibMediaItemPropertyRating")]
		Rating,
		/// <summary>Rating Computed.</summary>
		[Field ("ITLibMediaItemPropertyRatingComputed")]
		RatingComputed,
		/// <summary>Release Date.</summary>
		[Field ("ITLibMediaItemPropertyReleaseDate")]
		ReleaseDate,
		/// <summary>Sample Rate.</summary>
		[Field ("ITLibMediaItemPropertySampleRate")]
		SampleRate,
		/// <summary>Size.</summary>
		[Field ("ITLibMediaItemPropertySize")]
		Size,
		/// <summary>File Size.</summary>
		[Field ("ITLibMediaItemPropertyFileSize")]
		FileSize,
		/// <summary>User Skip Count.</summary>
		[Field ("ITLibMediaItemPropertyUserSkipCount")]
		UserSkipCount,
		/// <summary>Skip Date.</summary>
		[Field ("ITLibMediaItemPropertySkipDate")]
		SkipDate,
		/// <summary>Start Time.</summary>
		[Field ("ITLibMediaItemPropertyStartTime")]
		StartTime,
		/// <summary>Stop Time.</summary>
		[Field ("ITLibMediaItemPropertyStopTime")]
		StopTime,
		/// <summary>Total Time.</summary>
		[Field ("ITLibMediaItemPropertyTotalTime")]
		TotalTime,
		/// <summary>Track Number.</summary>
		[Field ("ITLibMediaItemPropertyTrackNumber")]
		TrackNumber,
		/// <summary>Location Type.</summary>
		[Field ("ITLibMediaItemPropertyLocationType")]
		LocationType,
		/// <summary>Voice Over Language.</summary>
		[Field ("ITLibMediaItemPropertyVoiceOverLanguage")]
		VoiceOverLanguage,
		/// <summary>Volume Adjustment.</summary>
		[Field ("ITLibMediaItemPropertyVolumeAdjustment")]
		VolumeAdjustment,
		/// <summary>Work.</summary>
		[Field ("ITLibMediaItemPropertyWork")]
		Work,
		/// <summary>Year.</summary>
		[Field ("ITLibMediaItemPropertyYear")]
		Year,
		/// <summary>Media Kind.</summary>
		[Field ("ITLibMediaItemPropertyMediaKind")]
		MediaKind,
		/// <summary>Location.</summary>
		[Field ("ITLibMediaItemPropertyLocation")]
		Location,
		/// <summary>Artwork.</summary>
		[Field ("ITLibMediaItemPropertyArtwork")]
		Artwork,
	}

	public enum ITLibPlaylistProperty {
		/// <summary>Name.</summary>
		[Field ("ITLibPlaylistPropertyName")]
		Name,
		/// <summary>All Items Playlist.</summary>
		[Field ("ITLibPlaylistPropertyAllItemsPlaylist")]
		AllItemsPlaylist,
		/// <summary>Distinguised Kind.</summary>
		[Field ("ITLibPlaylistPropertyDistinguisedKind")]
		DistinguisedKind,
		/// <summary>Master.</summary>
		[Deprecated (PlatformName.MacOSX, 12, 0, message: "Use 'Primary' instead.")]
		[Field ("ITLibPlaylistPropertyMaster")]
		Master,
		/// <summary>Parent Persistent Id.</summary>
		[Field ("ITLibPlaylistPropertyParentPersistentID")]
		ParentPersistentId,
		[Field ("ITLibPlaylistPropertyPrimary")]
		Primary,
		/// <summary>Visible.</summary>
		[Field ("ITLibPlaylistPropertyVisible")]
		Visible,
		/// <summary>Items.</summary>
		[Field ("ITLibPlaylistPropertyItems")]
		Items,
		/// <summary>Kind.</summary>
		[Field ("ITLibPlaylistPropertyKind")]
		Kind,
	}

	public enum ITLibMediaEntityProperty {
		/// <summary>Persistent Id.</summary>
		[Field ("ITLibMediaEntityPropertyPersistentID")]
		PersistentId,
	}
}
