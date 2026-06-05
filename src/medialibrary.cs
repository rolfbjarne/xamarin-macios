// Copyright 2016 Xamarin, Inc.
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

using AppKit;

namespace MediaLibrary {
	[Static]
	[Deprecated (PlatformName.MacOSX, 10, 15)]
	interface MediaLibraryTypeIdentifierKey {
		/// <summary>The type identifier for the folder root group.</summary>
		[Field ("MLFolderRootGroupTypeIdentifier")]
		NSString FolderRootGroupTypeIdentifier { get; }

		/// <summary>The type identifier for a folder group.</summary>
		[Field ("MLFolderGroupTypeIdentifier")]
		NSString FolderGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the iTunes root group.</summary>
		[Field ("MLiTunesRootGroupTypeIdentifier")]
		NSString ITunesRootGroupTypeIdentifier { get; }

		/// <summary>The type identifier for an iTunes playlist.</summary>
		[Field ("MLiTunesPlaylistTypeIdentifier")]
		NSString ITunesPlaylistTypeIdentifier { get; }

		/// <summary>The type identifier for the iTunes purchased playlist.</summary>
		[Field ("MLiTunesPurchasedPlaylistTypeIdentifier")]
		NSString ITunesPurchasedPlaylistTypeIdentifier { get; }

		/// <summary>The type identifier for the iTunes podcast playlist.</summary>
		[Field ("MLiTunesPodcastPlaylistTypeIdentifier")]
		NSString ITunesPodcastPlaylistTypeIdentifier { get; }

		/// <summary>The type identifier for the iTunes video playlist.</summary>
		[Field ("MLiTunesVideoPlaylistTypeIdentifier")]
		NSString ITunesVideoPlaylistTypeIdentifier { get; }

		/// <summary>The type identifier for an iTunes smart playlist.</summary>
		[Field ("MLiTunesSmartPlaylistTypeIdentifier")]
		NSString ITunesSmartPlaylistTypeIdentifier { get; }

		/// <summary>The type identifier for an iTunes folder playlist.</summary>
		[Field ("MLiTunesFolderPlaylistTypeIdentifier")]
		NSString ITunesFolderPlaylistTypeIdentifier { get; }

		/// <summary>The type identifier for the iTunes movies playlist.</summary>
		[Field ("MLiTunesMoviesPlaylistTypeIdentifier")]
		NSString ITunesMoviesPlaylistTypeIdentifier { get; }

		/// <summary>The type identifier for the iTunes TV shows playlist.</summary>
		[Field ("MLiTunesTVShowsPlaylistTypeIdentifier")]
		NSString ITunesTVShowsPlaylistTypeIdentifier { get; }

		/// <summary>The type identifier for the iTunes audiobooks playlist.</summary>
		[Field ("MLiTunesAudioBooksPlaylistTypeIdentifier")]
		NSString ITunesAudioBooksPlaylistTypeIdentifier { get; }

		/// <summary>The type identifier for the iTunes music playlist.</summary>
		[Field ("MLiTunesMusicPlaylistTypeIdentifier")]
		NSString ITunesMusicPlaylistTypeIdentifier { get; }

		/// <summary>The type identifier for the iTunes music videos playlist.</summary>
		[Field ("MLiTunesMusicVideosPlaylistTypeIdentifier")]
		NSString ITunesMusicVideosPlaylistTypeIdentifier { get; }

		/// <summary>The type identifier for the iTunes Genius playlist.</summary>
		[Field ("MLiTunesGeniusPlaylistTypeIdentifier")]
		NSString ITunesGeniusPlaylistTypeIdentifier { get; }

		/// <summary>The type identifier for the iTunes saved Genius playlist.</summary>
		[Field ("MLiTunesSavedGeniusPlaylistTypeIdentifier")]
		NSString ITunesSavedGeniusPlaylistTypeIdentifier { get; }

		/// <summary>The type identifier for the iTunes U playlist.</summary>
		[Field ("MLiTunesiTunesUPlaylistTypeIdentifier")]
		NSString ITunesiTunesUPlaylistTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos root group.</summary>
		[Field ("MLPhotosRootGroupTypeIdentifier")]
		NSString PhotosRootGroupTypeIdentifier { get; }

		/// <summary>The type identifier for a Photos shared group.</summary>
		[Field ("MLPhotosSharedGroupTypeIdentifier")]
		NSString PhotosSharedGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos albums group.</summary>
		[Field ("MLPhotosAlbumsGroupTypeIdentifier")]
		NSString PhotosAlbumsGroupTypeIdentifier { get; }

		/// <summary>The type identifier for a Photos album.</summary>
		[Field ("MLPhotosAlbumTypeIdentifier")]
		NSString PhotosAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for a Photos folder.</summary>
		[Field ("MLPhotosFolderTypeIdentifier")]
		NSString PhotosFolderTypeIdentifier { get; }

		/// <summary>The type identifier for a Photos smart album.</summary>
		[Field ("MLPhotosSmartAlbumTypeIdentifier")]
		NSString PhotosSmartAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for a Photos published album.</summary>
		[Field ("MLPhotosPublishedAlbumTypeIdentifier")]
		NSString PhotosPublishedAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos all moments group.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 15)]
		[Field ("MLPhotosAllMomentsGroupTypeIdentifier")]
		NSString PhotosAllMomentsGroupTypeIdentifier { get; }

		/// <summary>The type identifier for a Photos moment group.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 15)]
		[Field ("MLPhotosMomentGroupTypeIdentifier")]
		NSString PhotosMomentGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos all collections group.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 15)]
		[Field ("MLPhotosAllCollectionsGroupTypeIdentifier")]
		NSString PhotosAllCollectionsGroupTypeIdentifier { get; }

		/// <summary>The type identifier for a Photos collection group.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 15)]
		[Field ("MLPhotosCollectionGroupTypeIdentifier")]
		NSString PhotosCollectionGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos all years group.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 15)]
		[Field ("MLPhotosAllYearsGroupTypeIdentifier")]
		NSString PhotosAllYearsGroupTypeIdentifier { get; }

		/// <summary>The type identifier for a Photos year group.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 15)]
		[Field ("MLPhotosYearGroupTypeIdentifier")]
		NSString PhotosYearGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos last import group.</summary>
		[Field ("MLPhotosLastImportGroupTypeIdentifier")]
		NSString PhotosLastImportGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the My Photo Stream group.</summary>
		[Field ("MLPhotosMyPhotoStreamTypeIdentifier")]
		NSString PhotosMyPhotoStreamTypeIdentifier { get; }

		/// <summary>The type identifier for a shared photo stream.</summary>
		[Field ("MLPhotosSharedPhotoStreamTypeIdentifier")]
		NSString PhotosSharedPhotoStreamTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos favorites group.</summary>
		[Field ("MLPhotosFavoritesGroupTypeIdentifier")]
		NSString PhotosFavoritesGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos front camera group.</summary>
		[Field ("MLPhotosFrontCameraGroupTypeIdentifier")]
		NSString PhotosFrontCameraGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos live photos group.</summary>
		[Field ("MLPhotosLivePhotosGroupTypeIdentifier")]
		NSString PhotosLivePhotosGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos long exposure group.</summary>
		[Field ("MLPhotosLongExposureGroupTypeIdentifier")]
		NSString PhotosLongExposureGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos animated group.</summary>
		[Field ("MLPhotosAnimatedGroupTypeIdentifier")]
		NSString PhotosAnimatedGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos panoramas group.</summary>
		[Field ("MLPhotosPanoramasGroupTypeIdentifier")]
		NSString PhotosPanoramasGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos videos group.</summary>
		[Field ("MLPhotosVideosGroupTypeIdentifier")]
		NSString PhotosVideosGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos slow motion group.</summary>
		[Field ("MLPhotosSloMoGroupTypeIdentifier")]
		NSString PhotosSloMoGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos timelapse group.</summary>
		[Field ("MLPhotosTimelapseGroupTypeIdentifier")]
		NSString PhotosTimelapseGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos burst group.</summary>
		[Field ("MLPhotosBurstGroupTypeIdentifier")]
		NSString PhotosBurstGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos screenshot group.</summary>
		[Field ("MLPhotosScreenshotGroupTypeIdentifier")]
		NSString PhotosScreenshotGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos faces album.</summary>
		[Field ("MLPhotosFacesAlbumTypeIdentifier")]
		NSString PhotosFacesAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos all photos album.</summary>
		[Field ("MLPhotosAllPhotosAlbumTypeIdentifier")]
		NSString PhotosAllPhotosAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the Photos depth effect group.</summary>
		[Field ("MLPhotosDepthEffectGroupTypeIdentifier")]
		NSString PhotosDepthEffectGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the iPhoto root group.</summary>
		[Field ("MLiPhotoRootGroupTypeIdentifier")]
		NSString IPhotoRootGroupTypeIdentifier { get; }

		/// <summary>The type identifier for an iPhoto album.</summary>
		[Field ("MLiPhotoAlbumTypeIdentifier")]
		NSString IPhotoAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the iPhoto library album.</summary>
		[Field ("MLiPhotoLibraryAlbumTypeIdentifier")]
		NSString IPhotoLibraryAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the iPhoto events folder.</summary>
		[Field ("MLiPhotoEventsFolderTypeIdentifier")]
		NSString IPhotoEventsFolderTypeIdentifier { get; }

		/// <summary>The type identifier for an iPhoto smart album.</summary>
		[Field ("MLiPhotoSmartAlbumTypeIdentifier")]
		NSString IPhotoSmartAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for an iPhoto event album.</summary>
		[Field ("MLiPhotoEventAlbumTypeIdentifier")]
		NSString IPhotoEventAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the iPhoto last import album.</summary>
		[Field ("MLiPhotoLastImportAlbumTypeIdentifier")]
		NSString IPhotoLastImportAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the iPhoto last N months album.</summary>
		[Field ("MLiPhotoLastNMonthsAlbumTypeIdentifier")]
		NSString IPhotoLastNMonthsAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the iPhoto flagged album.</summary>
		[Field ("MLiPhotoFlaggedAlbumTypeIdentifier")]
		NSString IPhotoFlaggedAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for an iPhoto folder album.</summary>
		[Field ("MLiPhotoFolderAlbumTypeIdentifier")]
		NSString IPhotoFolderAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for an iPhoto subscribed album.</summary>
		[Field ("MLiPhotoSubscribedAlbumTypeIdentifier")]
		NSString IPhotoSubscribedAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the iPhoto faces album.</summary>
		[Field ("MLiPhotoFacesAlbumTypeIdentifier")]
		NSString IPhotoFacesAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the iPhoto places album.</summary>
		[Field ("MLiPhotoPlacesAlbumTypeIdentifier")]
		NSString IPhotoPlacesAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the iPhoto places country album.</summary>
		[Field ("MLiPhotoPlacesCountryAlbumTypeIdentifier")]
		NSString IPhotoPlacesCountryAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the iPhoto places province album.</summary>
		[Field ("MLiPhotoPlacesProvinceAlbumTypeIdentifier")]
		NSString IPhotoPlacesProvinceAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the iPhoto places city album.</summary>
		[Field ("MLiPhotoPlacesCityAlbumTypeIdentifier")]
		NSString IPhotoPlacesCityAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the iPhoto places point-of-interest album.</summary>
		[Field ("MLiPhotoPlacesPointOfInterestAlbumTypeIdentifier")]
		NSString IPhotoPlacesPointOfInterestAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the iPhoto Facebook album.</summary>
		[Field ("MLiPhotoFacebookAlbumTypeIdentifier")]
		NSString IPhotoFacebookAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the iPhoto Flickr album.</summary>
		[Field ("MLiPhotoFlickrAlbumTypeIdentifier")]
		NSString IPhotoFlickrAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the iPhoto Facebook group.</summary>
		[Field ("MLiPhotoFacebookGroupTypeIdentifier")]
		NSString IPhotoFacebookGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the iPhoto Flickr group.</summary>
		[Field ("MLiPhotoFlickrGroupTypeIdentifier")]
		NSString IPhotoFlickrGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the iPhoto slideshow album.</summary>
		[Field ("MLiPhotoSlideShowAlbumTypeIdentifier")]
		NSString IPhotoSlideShowAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the iPhoto last viewed event album.</summary>
		[Field ("MLiPhotoLastViewedEventAlbumTypeIdentifier")]
		NSString IPhotoLastViewedEventAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the iPhoto Photo Stream album.</summary>
		[Field ("MLiPhotoPhotoStreamAlbumTypeIdentifier")]
		NSString IPhotoPhotoStreamAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the Aperture root group.</summary>
		[Field ("MLApertureRootGroupTypeIdentifier")]
		NSString ApertureRootGroupTypeIdentifier { get; }

		/// <summary>The type identifier for an Aperture user album.</summary>
		[Field ("MLApertureUserAlbumTypeIdentifier")]
		NSString ApertureUserAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for an Aperture user smart album.</summary>
		[Field ("MLApertureUserSmartAlbumTypeIdentifier")]
		NSString ApertureUserSmartAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for an Aperture project album.</summary>
		[Field ("MLApertureProjectAlbumTypeIdentifier")]
		NSString ApertureProjectAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for an Aperture folder album.</summary>
		[Field ("MLApertureFolderAlbumTypeIdentifier")]
		NSString ApertureFolderAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for an Aperture project folder album.</summary>
		[Field ("MLApertureProjectFolderAlbumTypeIdentifier")]
		NSString ApertureProjectFolderAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for an Aperture light table.</summary>
		[Field ("MLApertureLightTableTypeIdentifier")]
		NSString ApertureLightTableTypeIdentifier { get; }

		/// <summary>The type identifier for the Aperture Flickr group.</summary>
		[Field ("MLApertureFlickrGroupTypeIdentifier")]
		NSString ApertureFlickrGroupTypeIdentifier { get; }

		/// <summary>The type identifier for an Aperture Flickr album.</summary>
		[Field ("MLApertureFlickrAlbumTypeIdentifier")]
		NSString ApertureFlickrAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the Aperture Facebook group.</summary>
		[Field ("MLApertureFacebookGroupTypeIdentifier")]
		NSString ApertureFacebookGroupTypeIdentifier { get; }

		/// <summary>The type identifier for an Aperture Facebook album.</summary>
		[Field ("MLApertureFacebookAlbumTypeIdentifier")]
		NSString ApertureFacebookAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the Aperture SmugMug group.</summary>
		[Field ("MLApertureSmugMugGroupTypeIdentifier")]
		NSString ApertureSmugMugGroupTypeIdentifier { get; }

		/// <summary>The type identifier for an Aperture SmugMug album.</summary>
		[Field ("MLApertureSmugMugAlbumTypeIdentifier")]
		NSString ApertureSmugMugAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for an Aperture slideshow.</summary>
		[Field ("MLApertureSlideShowTypeIdentifier")]
		NSString ApertureSlideShowTypeIdentifier { get; }

		/// <summary>The type identifier for the Aperture all photos group.</summary>
		[Field ("MLApertureAllPhotosTypeIdentifier")]
		NSString ApertureAllPhotosTypeIdentifier { get; }

		/// <summary>The type identifier for the Aperture flagged group.</summary>
		[Field ("MLApertureFlaggedTypeIdentifier")]
		NSString ApertureFlaggedTypeIdentifier { get; }

		/// <summary>The type identifier for the Aperture all projects group.</summary>
		[Field ("MLApertureAllProjectsTypeIdentifier")]
		NSString ApertureAllProjectsTypeIdentifier { get; }

		/// <summary>The type identifier for the Aperture faces album.</summary>
		[Field ("MLApertureFacesAlbumTypeIdentifier")]
		NSString ApertureFacesAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the Aperture places album.</summary>
		[Field ("MLAperturePlacesAlbumTypeIdentifier")]
		NSString AperturePlacesAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the Aperture places country album.</summary>
		[Field ("MLAperturePlacesCountryAlbumTypeIdentifier")]
		NSString AperturePlacesCountryAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the Aperture places province album.</summary>
		[Field ("MLAperturePlacesProvinceAlbumTypeIdentifier")]
		NSString AperturePlacesProvinceAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the Aperture places city album.</summary>
		[Field ("MLAperturePlacesCityAlbumTypeIdentifier")]
		NSString AperturePlacesCityAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the Aperture places point-of-interest album.</summary>
		[Field ("MLAperturePlacesPointOfInterestAlbumTypeIdentifier")]
		NSString AperturePlacesPointOfInterestAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the Aperture last import album.</summary>
		[Field ("MLApertureLastImportAlbumTypeIdentifier")]
		NSString ApertureLastImportAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the Aperture last N months album.</summary>
		[Field ("MLApertureLastNMonthsAlbumTypeIdentifier")]
		NSString ApertureLastNMonthsAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the Aperture last viewed event album.</summary>
		[Field ("MLApertureLastViewedEventAlbumTypeIdentifier")]
		NSString ApertureLastViewedEventAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the Aperture Photo Stream album.</summary>
		[Field ("MLAperturePhotoStreamAlbumTypeIdentifier")]
		NSString AperturePhotoStreamAlbumTypeIdentifier { get; }

		/// <summary>The type identifier for the GarageBand root group.</summary>
		[Field ("MLGarageBandRootGroupTypeIdentifier")]
		NSString GarageBandRootGroupTypeIdentifier { get; }

		/// <summary>The type identifier for a GarageBand folder group.</summary>
		[Field ("MLGarageBandFolderGroupTypeIdentifier")]
		NSString GarageBandFolderGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Logic root group.</summary>
		[Field ("MLLogicRootGroupTypeIdentifier")]
		NSString LogicRootGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Logic bounces group.</summary>
		[Field ("MLLogicBouncesGroupTypeIdentifier")]
		NSString LogicBouncesGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Logic projects group.</summary>
		[Field ("MLLogicProjectsGroupTypeIdentifier")]
		NSString LogicProjectsGroupTypeIdentifier { get; }

		/// <summary>The type identifier for a Logic project.</summary>
		[Field ("MLLogicProjectTypeIdentifier")]
		NSString LogicProjectTypeIdentifier { get; }

		/// <summary>The type identifier for the iMovie root group.</summary>
		[Field ("MLiMovieRootGroupTypeIdentifier")]
		NSString IMovieRootGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the iMovie event group.</summary>
		[Field ("MLiMovieEventGroupTypeIdentifier")]
		NSString IMovieEventGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the iMovie project group.</summary>
		[Field ("MLiMovieProjectGroupTypeIdentifier")]
		NSString IMovieProjectGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the iMovie event library group.</summary>
		[Field ("MLiMovieEventLibraryGroupTypeIdentifier")]
		NSString IMovieEventLibraryGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the iMovie event calendar group.</summary>
		[Field ("MLiMovieEventCalendarGroupTypeIdentifier")]
		NSString IMovieEventCalendarGroupTypeIdentifier { get; }

		/// <summary>The type identifier for an iMovie folder group.</summary>
		[Field ("MLiMovieFolderGroupTypeIdentifier")]
		NSString IMovieFolderGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Final Cut Pro root group.</summary>
		[Field ("MLFinalCutRootGroupTypeIdentifier")]
		NSString FinalCutRootGroupTypeIdentifier { get; }

		/// <summary>The type identifier for a Final Cut Pro event group.</summary>
		[Field ("MLFinalCutEventGroupTypeIdentifier")]
		NSString FinalCutEventGroupTypeIdentifier { get; }

		/// <summary>The type identifier for a Final Cut Pro project group.</summary>
		[Field ("MLFinalCutProjectGroupTypeIdentifier")]
		NSString FinalCutProjectGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Final Cut Pro event library group.</summary>
		[Field ("MLFinalCutEventLibraryGroupTypeIdentifier")]
		NSString FinalCutEventLibraryGroupTypeIdentifier { get; }

		/// <summary>The type identifier for the Final Cut Pro event calendar group.</summary>
		[Field ("MLFinalCutEventCalendarGroupTypeIdentifier")]
		NSString FinalCutEventCalendarGroupTypeIdentifier { get; }

		/// <summary>The type identifier for a Final Cut Pro folder group.</summary>
		[Field ("MLFinalCutFolderGroupTypeIdentifier")]
		NSString FinalCutFolderGroupTypeIdentifier { get; }
	}

	[Deprecated (PlatformName.MacOSX, 10, 15)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MLMediaLibrary {
		/// <param name="options">The library loading options dictionary.</param>
		/// <summary>Creates a media library with the specified options.</summary>
		[Export ("initWithOptions:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSDictionary<NSString, NSObject> options);

		/// <summary>Gets the MediaSources type identifier key.</summary>
		[NullAllowed, Export ("mediaSources", ArgumentSemantic.Copy)]
		NSDictionary<NSString, MLMediaSource> MediaSources { get; }

		/// <summary>Gets the MediaLoadSourceTypesKey type identifier key.</summary>
		[Field ("MLMediaLoadSourceTypesKey")]
		NSString MediaLoadSourceTypesKey { get; }

		/// <summary>Gets the MediaLoadIncludeSourcesKey type identifier key.</summary>
		[Field ("MLMediaLoadIncludeSourcesKey")]
		NSString MediaLoadIncludeSourcesKey { get; }

		/// <summary>Gets the MediaLoadExcludeSourcesKey type identifier key.</summary>
		[Field ("MLMediaLoadExcludeSourcesKey")]
		NSString MediaLoadExcludeSourcesKey { get; }

		/// <summary>Gets the MediaLoadFoldersKey type identifier key.</summary>
		[Field ("MLMediaLoadFoldersKey")]
		NSString MediaLoadFoldersKey { get; }

		/// <summary>Gets the MediaLoadAppleLoops type identifier key.</summary>
		[Field ("MLMediaLoadAppleLoops")]
		NSString MediaLoadAppleLoops { get; }

		/// <summary>Gets the MediaLoadMoviesFolder type identifier key.</summary>
		[Field ("MLMediaLoadMoviesFolder")]
		NSString MediaLoadMoviesFolder { get; }

		/// <summary>Gets the MediaLoadAppFoldersKey type identifier key.</summary>
		[Field ("MLMediaLoadAppFoldersKey")]
		NSString MediaLoadAppFoldersKey { get; }
	}

	[Deprecated (PlatformName.MacOSX, 10, 15)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MLMediaSource {
		/// <summary>Gets the media library.</summary>
		[NullAllowed, Export ("mediaLibrary", ArgumentSemantic.Assign)]
		MLMediaLibrary MediaLibrary { get; }

		/// <summary>Gets the MediaSourceIdentifier type identifier key.</summary>
		[Export ("mediaSourceIdentifier")]
		NSString MediaSourceIdentifier { get; }

		/// <summary>Gets the Attributes type identifier key.</summary>
		[Export ("attributes", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Attributes { get; }

		/// <summary>Gets the root media group.</summary>
		[NullAllowed, Export ("rootMediaGroup", ArgumentSemantic.Retain)]
		MLMediaGroup RootMediaGroup { get; }

		/// <param name="mediaGroupIdentifier">The identifier of the media group to retrieve.</param>
		///         <summary>Returns the media group with the specified identifier.</summary>
		///         <returns>The media group, or <see langword="null" /> if not found.</returns>
		[Export ("mediaGroupForIdentifier:")]
		[return: NullAllowed]
		MLMediaGroup MediaGroupForIdentifier (NSString mediaGroupIdentifier);

		/// <param name="mediaGroupIdentifiers">The identifiers of the media groups to retrieve.</param>
		///         <summary>Returns the media groups with the specified identifiers.</summary>
		///         <returns>A dictionary mapping identifiers to media groups.</returns>
		[Export ("mediaGroupsForIdentifiers:")]
		NSDictionary<NSString, MLMediaGroup> MediaGroupsForIdentifiers (NSString [] mediaGroupIdentifiers);

		/// <param name="mediaObjectIdentifier">The identifier of the media object to retrieve.</param>
		///         <summary>Returns the media object with the specified identifier.</summary>
		///         <returns>The media object, or <see langword="null" /> if not found.</returns>
		[Export ("mediaObjectForIdentifier:")]
		[return: NullAllowed]
		MLMediaObject MediaObjectForIdentifier (NSString mediaObjectIdentifier);

		/// <param name="mediaObjectIdentifiers">The identifiers of the media objects to retrieve.</param>
		///         <summary>Returns the media objects with the specified identifiers.</summary>
		///         <returns>A dictionary mapping identifiers to media objects.</returns>
		[Export ("mediaObjectsForIdentifiers:")]
		NSDictionary<NSString, MLMediaObject> MediaObjectsForIdentifiers (NSString [] mediaObjectIdentifiers);

		/// <summary>Gets the MediaSourcePhotosIdentifier type identifier key.</summary>
		[Field ("MLMediaSourcePhotosIdentifier")]
		NSString MediaSourcePhotosIdentifier { get; }

		/// <summary>Gets the MediaSourceiPhotoIdentifier type identifier key.</summary>
		[Field ("MLMediaSourceiPhotoIdentifier")]
		NSString MediaSourceiPhotoIdentifier { get; }

		/// <summary>Gets the MediaSourceiTunesIdentifier type identifier key.</summary>
		[Field ("MLMediaSourceiTunesIdentifier")]
		NSString MediaSourceiTunesIdentifier { get; }

		/// <summary>Gets the MediaSourceApertureIdentifier type identifier key.</summary>
		[Field ("MLMediaSourceApertureIdentifier")]
		NSString MediaSourceApertureIdentifier { get; }

		/// <summary>Gets the MediaSourceiMovieIdentifier type identifier key.</summary>
		[Field ("MLMediaSourceiMovieIdentifier")]
		NSString MediaSourceiMovieIdentifier { get; }

		/// <summary>Gets the MediaSourceFinalCutIdentifier type identifier key.</summary>
		[Field ("MLMediaSourceFinalCutIdentifier")]
		NSString MediaSourceFinalCutIdentifier { get; }

		/// <summary>Gets the MediaSourceGarageBandIdentifier type identifier key.</summary>
		[Field ("MLMediaSourceGarageBandIdentifier")]
		NSString MediaSourceGarageBandIdentifier { get; }

		/// <summary>Gets the MediaSourceLogicIdentifier type identifier key.</summary>
		[Field ("MLMediaSourceLogicIdentifier")]
		NSString MediaSourceLogicIdentifier { get; }

		/// <summary>Gets the MediaSourcePhotoBoothIdentifier type identifier key.</summary>
		[Field ("MLMediaSourcePhotoBoothIdentifier")]
		NSString MediaSourcePhotoBoothIdentifier { get; }

		/// <summary>Gets the MediaSourceCustomFoldersIdentifier type identifier key.</summary>
		[Field ("MLMediaSourceCustomFoldersIdentifier")]
		NSString MediaSourceCustomFoldersIdentifier { get; }

		/// <summary>Gets the MediaSourceMoviesFolderIdentifier type identifier key.</summary>
		[Field ("MLMediaSourceMoviesFolderIdentifier")]
		NSString MediaSourceMoviesFolderIdentifier { get; }

		/// <summary>Gets the MediaSourceAppDefinedFoldersIdentifier type identifier key.</summary>
		[Field ("MLMediaSourceAppDefinedFoldersIdentifier")]
		NSString MediaSourceAppDefinedFoldersIdentifier { get; }
	}

	[Deprecated (PlatformName.MacOSX, 10, 15)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MLMediaGroup {
		/// <summary>Gets the media library.</summary>
		[NullAllowed, Export ("mediaLibrary", ArgumentSemantic.Assign)]
		MLMediaLibrary MediaLibrary { get; }

		/// <summary>Gets the parent.</summary>
		[NullAllowed, Export ("parent", ArgumentSemantic.Assign)]
		MLMediaGroup Parent { get; }

		/// <summary>Gets the MediaSourceIdentifier type identifier key.</summary>
		[Export ("mediaSourceIdentifier")]
		NSString MediaSourceIdentifier { get; }

		/// <summary>Gets the name of the media group.</summary>
		[NullAllowed, Export ("name")]
		string Name { get; }

		/// <summary>Gets the Identifier type identifier key.</summary>
		[Export ("identifier")]
		NSString Identifier { get; }

		/// <summary>Gets the TypeIdentifier type identifier key.</summary>
		[Export ("typeIdentifier")]
		NSString TypeIdentifier { get; }

		/// <summary>Gets the Attributes type identifier key.</summary>
		[Export ("attributes", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Attributes { get; }

		/// <summary>Gets the child groups.</summary>
		[NullAllowed, Export ("childGroups", ArgumentSemantic.Copy)]
		MLMediaGroup [] ChildGroups { get; }

		/// <summary>Gets the URL of the media group.</summary>
		[NullAllowed, Export ("URL", ArgumentSemantic.Copy)]
		NSUrl Url { get; }

		/// <summary>Gets the modification date of the media group.</summary>
		[NullAllowed, Export ("modificationDate", ArgumentSemantic.Copy)]
		NSDate ModificationDate { get; }

		/// <summary>Gets the icon image for the media group.</summary>
		[NullAllowed, Export ("iconImage", ArgumentSemantic.Copy)]
		NSImage IconImage { get; }

		/// <summary>Gets the media objects.</summary>
		[NullAllowed, Export ("mediaObjects", ArgumentSemantic.Copy)]
		MLMediaObject [] MediaObjects { get; }
	}

	[Deprecated (PlatformName.MacOSX, 10, 15)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MLMediaObject {
		/// <summary>Gets the media library.</summary>
		[NullAllowed, Export ("mediaLibrary", ArgumentSemantic.Assign)]
		MLMediaLibrary MediaLibrary { get; }

		/// <summary>Gets the Identifier type identifier key.</summary>
		[Export ("identifier")]
		NSString Identifier { get; }

		/// <summary>Gets the MediaSourceIdentifier type identifier key.</summary>
		[Export ("mediaSourceIdentifier")]
		NSString MediaSourceIdentifier { get; }

		/// <summary>Gets the Attributes type identifier key.</summary>
		[Export ("attributes", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Attributes { get; }

		/// <summary>Gets the media type of the object.</summary>
		[Export ("mediaType", ArgumentSemantic.Assign)]
		MLMediaType MediaType { get; }

		/// <summary>Gets the content type of the media object.</summary>
		[NullAllowed, Export ("contentType")]
		string ContentType { get; }

		/// <summary>Gets the name of the media object.</summary>
		[NullAllowed, Export ("name")]
		string Name { get; }

		/// <summary>Gets the URL of the media object.</summary>
		[NullAllowed, Export ("URL", ArgumentSemantic.Copy)]
		NSUrl Url { get; }

		/// <summary>Gets the original URL of the media object.</summary>
		[NullAllowed, Export ("originalURL", ArgumentSemantic.Copy)]
		NSUrl OriginalUrl { get; }

		/// <summary>Gets the file size in bytes.</summary>
		[Export ("fileSize")]
		nuint FileSize { get; }

		/// <summary>Gets the modification date of the media object.</summary>
		[NullAllowed, Export ("modificationDate", ArgumentSemantic.Copy)]
		NSDate ModificationDate { get; }

		/// <summary>Gets the thumbnail URL for the media object.</summary>
		[NullAllowed, Export ("thumbnailURL", ArgumentSemantic.Copy)]
		NSUrl ThumbnailUrl { get; }

		/// <summary>Gets the artwork image for the media object.</summary>
		[NullAllowed, Export ("artworkImage", ArgumentSemantic.Copy)]
		NSImage ArtworkImage { get; }

		/// <summary>Gets the MediaObjectDurationKey type identifier key.</summary>
		[Field ("MLMediaObjectDurationKey")]
		NSString MediaObjectDurationKey { get; }

		/// <summary>Gets the MediaObjectArtistKey type identifier key.</summary>
		[Field ("MLMediaObjectArtistKey")]
		NSString MediaObjectArtistKey { get; }

		/// <summary>Gets the MediaObjectAlbumKey type identifier key.</summary>
		[Field ("MLMediaObjectAlbumKey")]
		NSString MediaObjectAlbumKey { get; }

		/// <summary>Gets the MediaObjectGenreKey type identifier key.</summary>
		[Field ("MLMediaObjectGenreKey")]
		NSString MediaObjectGenreKey { get; }

		/// <summary>Gets the MediaObjectKindKey type identifier key.</summary>
		[Field ("MLMediaObjectKindKey")]
		NSString MediaObjectKindKey { get; }

		/// <summary>Gets the MediaObjectTrackNumberKey type identifier key.</summary>
		[Field ("MLMediaObjectTrackNumberKey")]
		NSString MediaObjectTrackNumberKey { get; }

		/// <summary>Gets the MediaObjectBitRateKey type identifier key.</summary>
		[Field ("MLMediaObjectBitRateKey")]
		NSString MediaObjectBitRateKey { get; }

		/// <summary>Gets the MediaObjectSampleRateKey type identifier key.</summary>
		[Field ("MLMediaObjectSampleRateKey")]
		NSString MediaObjectSampleRateKey { get; }

		/// <summary>Gets the MediaObjectChannelCountKey type identifier key.</summary>
		[Field ("MLMediaObjectChannelCountKey")]
		NSString MediaObjectChannelCountKey { get; }

		/// <summary>Gets the MediaObjectResolutionStringKey type identifier key.</summary>
		[Field ("MLMediaObjectResolutionStringKey")]
		NSString MediaObjectResolutionStringKey { get; }

		/// <summary>Gets the MediaObjectCommentsKey type identifier key.</summary>
		[Field ("MLMediaObjectCommentsKey")]
		NSString MediaObjectCommentsKey { get; }

		/// <summary>Gets the MediaObjectKeywordsKey type identifier key.</summary>
		[Field ("MLMediaObjectKeywordsKey")]
		NSString MediaObjectKeywordsKey { get; }

		/// <summary>Gets the MediaObjectProtectedKey type identifier key.</summary>
		[Field ("MLMediaObjectProtectedKey")]
		NSString MediaObjectProtectedKey { get; }
	}
}
