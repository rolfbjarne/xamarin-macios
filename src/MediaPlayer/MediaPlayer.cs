//
// This file contains definitions used in the MediaPlayer namespace
//
// Authors:
//   Miguel de Icaza
//
// Copyright 2009, Novell, Inc.
// Copyright 2011-2015 Xamarin, Inc.
//


#nullable enable

namespace MediaPlayer {
	// NSInteger -> MPMoviePlayerController.h
	/// <summary>An enumeration of possible states in which the <see cref="MediaPlayer.MPMoviePlayerController" /> may be. Used with the <see cref="MediaPlayer.MPMoviePlayerController.PlaybackState" /> property.</summary>
	[NoMac]
	[NoTV]
	[Deprecated (PlatformName.iOS, 9, 0)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1)]
	[Native]
	public enum MPMoviePlaybackState : long {
		/// <summary>Playback is stopped.</summary>
		Stopped,
		/// <summary>Playback is playing.</summary>
		Playing,
		/// <summary>Playback is paused.</summary>
		Paused,
		/// <summary>Playback was interrupted.</summary>
		Interrupted,
		/// <summary>Seeking forward.</summary>
		SeekingForward,
		/// <summary>Seeking backward.</summary>
		SeekingBackward,
	}

	// NSInteger -> MPMoviePlayerController.h
	/// <summary>An enumeration whose values reflect a movie's load state. Used in the <see cref="MediaPlayer.MPMoviePlayerController.LoadState" /> property.</summary>
	[NoMac]
	[NoTV]
	[Deprecated (PlatformName.iOS, 9, 0)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1)]
	[Native]
	public enum MPMovieLoadState : long {
		/// <summary>The load state is unknown.</summary>
		Unknown = 0,
		/// <summary>The media is playable.</summary>
		Playable = 1 << 0,
		/// <summary>The media can play through to the end.</summary>
		PlaythroughOK = 1 << 1,
		/// <summary>Loading has stalled.</summary>
		Stalled = 1 << 2,
	}

	// NSInteger -> MPMoviePlayerController.h
	/// <summary>An enumeration that specifies whether a movie should repeat or not. Used with the <see cref="MediaPlayer.MPMoviePlayerController.RepeatMode" /> property.</summary>
	[NoMac]
	[NoTV]
	[Deprecated (PlatformName.iOS, 9, 0)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1)]
	[Native]
	public enum MPMovieRepeatMode : long {
		/// <summary>No repeat.</summary>
		None,
		/// <summary>Repeat one.</summary>
		One,
	}

	// NSInteger -> MPMoviePlayerController.h
	/// <summary>An enumeration whose values specify various modes for the <see cref="MediaPlayer.MPMoviePlayerController.ControlStyle" /> property.</summary>
	[NoMac]
	[NoTV]
	[Deprecated (PlatformName.iOS, 9, 0)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1)]
	[Native]
	public enum MPMovieControlStyle : long {
		/// <summary>No repeat.</summary>
		None,
		/// <summary>Embedded controls.</summary>
		Embedded,
		/// <summary>Fullscreen controls.</summary>
		Fullscreen,
		/// <summary>Default controls.</summary>
		Default = Embedded,
	}

	// NSInteger -> MPMoviePlayerController.h
	/// <summary>An enumeration whose values specify various ways a movie may have finished.</summary>
	[NoMac]
	[NoTV]
	[Deprecated (PlatformName.iOS, 9, 0)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1)]
	[Native]
	public enum MPMovieFinishReason : long {
		/// <summary>Playback ended normally.</summary>
		PlaybackEnded,
		/// <summary>Playback ended due to an error.</summary>
		PlaybackError,
		/// <summary>The user exited playback.</summary>
		UserExited,
	}

	// NSInteger -> MPMoviePlayerController.h
	/// <summary>An enumeration that specifies the movie's media types. Used with the <see cref="MediaPlayer.MPMoviePlayerController.MovieMediaTypes" /> property.</summary>
	[NoMac]
	[NoTV]
	[Deprecated (PlatformName.iOS, 9, 0)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1)]
	[Native ("MPMovieMediaTypeMask")]
	[Flags]
	public enum MPMovieMediaType : long {
		/// <summary>No controls.</summary>
		None = 0,
		/// <summary>Video media.</summary>
		Video = 1 << 0,
		/// <summary>Audio media.</summary>
		Audio = 1 << 1,
	}

	// NSInteger -> MPMoviePlayerController.h
	/// <summary>An enumeration that specifies whether a movie's data is provided by a file or streaming. Used with the <see cref="MediaPlayer.MPMoviePlayerController.SourceType" /> property.</summary>
	[NoMac]
	[NoTV]
	[Deprecated (PlatformName.iOS, 9, 0)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1)]
	[Native]
	public enum MPMovieSourceType : long {
		/// <summary>The source type is unknown.</summary>
		Unknown,
		/// <summary>A file source.</summary>
		File,
		/// <summary>A streaming source.</summary>
		Streaming,
	}

	// NSInteger -> MPMoviePlayerController.h
	/// <summary>An enumeration that specifies which frame to use when generating thumbnails.</summary>
	[NoMac]
	[NoTV]
	[Deprecated (PlatformName.iOS, 9, 0)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1)]
	[Native]
	public enum MPMovieTimeOption : long {
		/// <summary>The nearest key frame.</summary>
		NearestKeyFrame,
		/// <summary>The exact time.</summary>
		Exact,
	}

	// NSUInteger -> MPMediaItem.h
	/// <summary>An enumeration whose values specify various types of media.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	[Flags]
	public enum MPMediaType : ulong {
		/// <summary>Music media.</summary>
		Music = 1 << 0,
		/// <summary>Podcast media.</summary>
		Podcast = 1 << 1,
		/// <summary>Audio media.</summary>
		AudioBook = 1 << 2,
		/// <summary>Audio media.</summary>
		AudioITunesU = 1 << 3,
		/// <summary>Any audio media type.</summary>
		AnyAudio = 0x00ff,

		/// <summary>Movie media.</summary>
		[MacCatalyst (13, 1)]
		Movie = 1 << 8,
		/// <summary>TV show media.</summary>
		[MacCatalyst (13, 1)]
		TVShow = 1 << 9,
		/// <summary>Video media.</summary>
		[MacCatalyst (13, 1)]
		VideoPodcast = 1 << 10,
		/// <summary>Music video media.</summary>
		[MacCatalyst (13, 1)]
		MusicVideo = 1 << 11,
		/// <summary>Video media.</summary>
		[MacCatalyst (13, 1)]
		VideoITunesU = 1 << 12,
		/// <summary>Home video media.</summary>
		[MacCatalyst (13, 1)]
		HomeVideo = 1 << 13,
		/// <summary>Any video media type.</summary>
		[MacCatalyst (13, 1)]
		TypeAnyVideo = 0xff00,
		/// <summary>Any media type.</summary>
		Any = 0xFFFFFFFFFFFFFFFF,
	}

	// NSInteger -> MPMediaPlaylist.h
	/// <summary>An enumeration whose values specify various types of playlist.</summary>
	[NoMac]
	[NoTV]
	[MacCatalyst (13, 1)]
	[Native]
	[Flags]
	public enum MPMediaPlaylistAttribute : long {
		/// <summary>No controls.</summary>
		None = 0,
		/// <summary>The playlist was created on the device.</summary>
		OnTheGo = (1 << 0), // if set, the playlist was created on a device rather than synced from iTunes
		/// <summary>A smart playlist.</summary>
		Smart = (1 << 1),
		/// <summary>A Genius playlist.</summary>
		Genius = (1 << 2),
	};

	// NSInteger -> MPMediaQuery.h
	/// <summary>An enumeration whose values specify various ways in which media can be logically grouped.</summary>
	[NoMac]
	[NoTV]
	[MacCatalyst (13, 1)]
	[Native]
	public enum MPMediaGrouping : long {
		/// <summary>Group by title.</summary>
		Title,
		/// <summary>Group by album.</summary>
		Album,
		/// <summary>Group by artist.</summary>
		Artist,
		/// <summary>Group by album artist.</summary>
		AlbumArtist,
		/// <summary>Group by composer.</summary>
		Composer,
		/// <summary>Group by genre.</summary>
		Genre,
		/// <summary>Group by playlist.</summary>
		Playlist,
		/// <summary>Group by podcast title.</summary>
		PodcastTitle,
	}

	// NSInteger -> MPMediaQuery.h
	/// <summary>An enumeration whose values specifies a comparison-type to be used with a <see cref="MediaPlayer.MPMediaPredicate" />.</summary>
	[NoMac]
	[NoTV]
	[MacCatalyst (13, 1)]
	[Native]
	public enum MPMediaPredicateComparison : long {
		/// <summary>Matches items equal to the value.</summary>
		EqualsTo,
		/// <summary>Matches items that contain the value.</summary>
		Contains,
	}

	// NSInteger -> MPMoviePlayerController.h
	/// <summary>An enumeration of video scaling modes. Used with the <see cref="MediaPlayer.MPMoviePlayerController.ScalingMode" /> property.</summary>
	[NoMac]
	[NoTV]
	[Deprecated (PlatformName.iOS, 9, 0)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1)]
	[Native]
	public enum MPMovieScalingMode : long {
		/// <summary>No repeat.</summary>
		None,
		/// <summary>Scale to fit within bounds, preserving aspect ratio.</summary>
		AspectFit,
		/// <summary>Scale to fill bounds, preserving aspect ratio.</summary>
		AspectFill,
		/// <summary>Scale to fill bounds, stretching if needed.</summary>
		Fill,
	}

	// untyped enum -> MPMoviePlayerController.h
	/// <summary>Application developers should not use this deprecated class, but instead use <see cref="MediaPlayer.MPMovieControlStyle" />.</summary>
	[NoMac]
	[MacCatalyst (13, 1)]
	public enum MPMovieControlMode {
		/// <summary>The default repeat mode.</summary>
		Default,
		/// <summary>Show only volume controls.</summary>
		VolumeOnly,
		/// <summary>Hide all controls.</summary>
		Hidden,
	}

	// NSInteger -> /MPMusicPlayerController.h
	/// <summary>An enumeration of states in which the <see cref="MediaPlayer.MPMusicPlayerController" /> may be. Used with the <see cref="MediaPlayer.MPMusicPlayerController.PlaybackState" /> property.</summary>
	[NoMac]
	[TV (14, 0)]
	[MacCatalyst (13, 1)]
	[Native]
	public enum MPMusicPlaybackState : long {
		/// <summary>Playback is stopped.</summary>
		Stopped,
		/// <summary>Playback is playing.</summary>
		Playing,
		/// <summary>Playback is paused.</summary>
		Paused,
		/// <summary>Playback was interrupted.</summary>
		Interrupted,
		/// <summary>Seeking forward.</summary>
		SeekingForward,
		/// <summary>Seeking backward.</summary>
		SeekingBackward,
	}

	// NSInteger -> /MPMusicPlayerController.h
	/// <summary>An enumeration of music repeat modes. Used with the <see cref="MediaPlayer.MPMusicPlayerController.RepeatMode" /> property.</summary>
	[NoMac]
	[TV (14, 0)]
	[MacCatalyst (13, 1)]
	[Native]
	public enum MPMusicRepeatMode : long {
		/// <summary>The default repeat mode.</summary>
		Default,
		/// <summary>No repeat.</summary>
		None,
		/// <summary>Repeat one.</summary>
		One,
		/// <summary>Repeat all tracks.</summary>
		All,
	}

	// NSInteger -> /MPMusicPlayerController.h
	/// <summary>An enumeration of shuffle modes for use with the <see cref="MediaPlayer.MPMusicPlayerController.ShuffleMode" /> property.</summary>
	[NoMac]
	[TV (14, 0)]
	[MacCatalyst (13, 1)]
	[Native]
	public enum MPMusicShuffleMode : long {
		/// <summary>The default repeat mode.</summary>
		Default,
		/// <summary>Shuffle is off.</summary>
		Off,
		/// <summary>Shuffle songs.</summary>
		Songs,
		/// <summary>Shuffle albums.</summary>
		Albums,
	}

#if !MONOMAC
	/// <param name="property">The property kind.</param>
	/// <param name="value">The value associated with the property</param>
	/// <param name="stop">Reference value, can be used to stop the enumeration.</param>
	/// <summary>The delegate to be used as the <c>enumerator</c> argument to <see cref="MPMediaEntity.EnumerateValues(Foundation.NSSet,MediaPlayer.MPMediaItemEnumerator)" />.</summary>
#else
	/// <param name="property">The property kind.</param>
	/// <param name="value">The value associated with the property</param>
	/// <param name="stop">Reference value, can be used to stop the enumeration.</param>
	/// <summary>The delegate to be used as the <c>enumerator</c> argument to <see cref="MPMediaItem.EnumerateValues(Foundation.NSSet,MediaPlayer.MPMediaItemEnumerator)" />.</summary>
#endif
	public delegate void MPMediaItemEnumerator (string property, NSObject value, ref bool stop);

	[MacCatalyst (13, 1)]
	[Native]
	public enum MPShuffleType : long {
		/// <summary>Shuffle is off.</summary>
		Off,
		/// <summary>Shuffle individual items.</summary>
		Items,
		/// <summary>Shuffle collections.</summary>
		Collections,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MPRepeatType : long {
		/// <summary>Shuffle is off.</summary>
		Off,
		/// <summary>Repeat one.</summary>
		One,
		/// <summary>Repeat all tracks.</summary>
		All,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MPChangeLanguageOptionSetting : long {
		/// <summary>No repeat.</summary>
		None,
		/// <summary>Apply to the now-playing item only.</summary>
		NowPlayingItemOnly,
		/// <summary>Apply permanently.</summary>
		Permanent,
	}

	// NSInteger -> MPRemoteCommand.h
	/// <summary>Enumerates values that indicate whether a command succeeded, failed, or cannot play the kind of media requested.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum MPRemoteCommandHandlerStatus : long {
		/// <summary>Indicates that the command succeeded.</summary>
		Success = 0,
		/// <summary>Indicates that there was no such content to play.</summary>
		NoSuchContent = 100,
		/// <summary>Indicates that no item was playing, so the command could not be meaningfuly received.</summary>
		[MacCatalyst (13, 1)]
		NoActionableNowPlayingItem = 110,
		/// <summary>The device was not found.</summary>
		[MacCatalyst (13, 1)]
		DeviceNotFound = 120,
		/// <summary>Indicates that the command failed.</summary>
		CommandFailed = 200,
	}

	// NSUInteger -> MPRemoteCommandEvent.h
	/// <summary>Enumerates values that indicate whether the command began or ended a seek operation.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum MPSeekCommandEventType : ulong {
		/// <summary>Seeking has begun.</summary>
		BeginSeeking,
		/// <summary>Seeking has ended.</summary>
		EndSeeking,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MPNowPlayingInfoLanguageOptionType : ulong {
		/// <summary>An audible language option.</summary>
		Audible,
		/// <summary>A legible (subtitle) language option.</summary>
		Legible,
	}

	/// <summary>Enumerates error codes in the Media Player domain.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	[ErrorDomain ("MPErrorDomain")]
	public enum MPErrorCode : long {
		/// <summary>An unknown error occurred.</summary>
		Unknown,
		/// <summary>Permission was denied.</summary>
		PermissionDenied,
		/// <summary>iCloud services were not enabled.</summary>
		CloudServiceCapabilityMissing,
		/// <summary>A connection to the network could not be established.</summary>
		NetworkConnectionFailed,
		/// <summary>The identifier was not found in the storefront.</summary>
		NotFound,
		/// <summary>The operation was not supported.</summary>
		NotSupported,
		/// <summary>The operation was cancelled.</summary>
		Cancelled,
		/// <summary>A request timed out.</summary>
		RequestTimedOut,
	}

	/// <summary>Enumerates the status of the application's permission to access the media library.</summary>
	[NoMac]
	[NoTV]
	[MacCatalyst (13, 1)]
	[Native]
	public enum MPMediaLibraryAuthorizationStatus : long {
		/// <summary>The user has not interacted with the permissions dialog.</summary>
		NotDetermined = 0,
		/// <summary>The user has denied permission.</summary>
		Denied,
		/// <summary>Access is denied and the user may not change permission.</summary>
		Restricted,
		/// <summary>The user has granted permission.</summary>
		Authorized,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MPNowPlayingInfoMediaType : ulong {
		/// <summary>No controls.</summary>
		None = 0,
		/// <summary>Audio media.</summary>
		Audio,
		/// <summary>Video media.</summary>
		Video,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MPNowPlayingPlaybackState : ulong {
		/// <summary>The load state is unknown.</summary>
		Unknown = 0,
		/// <summary>Playback is playing.</summary>
		Playing,
		/// <summary>Playback is paused.</summary>
		Paused,
		/// <summary>Playback is stopped.</summary>
		Stopped,
		/// <summary>Playback was interrupted.</summary>
		Interrupted,
	}
}
