//
// This file describes the API that the generator will produce
//
// Authors:
//   Miguel de Icaza
//
// Copyright 2009, Novell, Inc.
// Copyright 2011-2015, Xamarin Inc
//
using System.ComponentModel;
using AVFoundation;
using CoreFoundation;
using CoreGraphics;
using CoreLocation;
using CoreMedia;
#if MONOMAC
using AppKit;
#else
using UIKit;
#endif

#if MONOMAC
using UIControlState = Foundation.NSObject;
using UIImage = AppKit.NSImage;
using UIInterfaceOrientation = Foundation.NSObject;
using UIView = AppKit.NSView;
using UIViewAnimationCurve = Foundation.NSObject;
using UIViewController = AppKit.NSViewController;
#else
using NSImage = UIKit.UIImage;
#endif

namespace MediaPlayer {
	/// <summary>Abstract base class for <see cref="MediaPlayer.MPMediaItem" /> and <see cref="MediaPlayer.MPMediaItemCollection" /> classes.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPMediaEntity_ClassReference/index.html">Apple documentation for <c>MPMediaEntity</c></related>
	[BaseType (typeof (NSObject))]
#if !MONOMAC
	[TV (14, 0)]
	[MacCatalyst (13, 1)]
	interface MPMediaEntity : NSSecureCoding {
#else
	interface MPMediaItem : NSSecureCoding {
#endif // !MONOMAC
		/// <param name="property">The property name.</param>
		///         <summary>Returns a Boolean value that tells whether the specified <paramref name="property" /> can be used in a mediAProperty predicate.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("canFilterByProperty:")]
		bool CanFilterByProperty (NSString property);

		/// <param name="property">The property name.</param>
		///         <summary>Returns the value for the specified <paramref name="property" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("valueForProperty:")]
		[return: NullAllowed]
		NSObject ValueForProperty (NSString property);

		/// <param name="propertiesToEnumerate">The properties to enumerate.</param>
		///         <param name="enumerator">The block to call for each value.</param>
		///         <summary>Runs the provided <paramref name="enumerator" /> on the values for the specified properties.</summary>
		[Export ("enumerateValuesForProperties:usingBlock:")]
		void EnumerateValues (NSSet propertiesToEnumerate, MPMediaItemEnumerator enumerator);

		/// <param name="key">The key.</param>
		///         <summary>Performs the get object operation.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[return: NullAllowed]
		[Export ("objectForKeyedSubscript:")]
		NSObject GetObject (NSObject key);

		/// <summary>The value that is associated with the MPMediaEntityPropertyPersistentID constant.</summary>
		[MacCatalyst (13, 1)]
		[Field ("MPMediaEntityPropertyPersistentID")]
		NSString PropertyPersistentID { get; }

		[NoiOS, NoMac]
		[MacCatalyst (13, 1)]
		[Export ("persistentID")]
		ulong PersistentID { get; }

#if IOS || TVOS
	}
#if MONOMAC
	[Static]
#else
	[BaseType (typeof (MPMediaEntity))]
#endif
	interface MPMediaItem {
#endif
		/// <param name="groupingType">Grouping type.</param>
		///         <summary>Returns the persistent ID for the specified grouping type.</summary>
		///         <returns>
		///         </returns>
		///         <remarks>
		///         </remarks>
		[NoMac]
		[NoTV]
		[MacCatalyst (13, 1)]
		[Export ("persistentIDPropertyForGroupingType:")]
		[Static]
		string GetPersistentIDProperty (MPMediaGrouping groupingType);

		/// <param name="groupingType">Grouping type.</param>
		///         <summary>Returns the title for the specified grouping type</summary>
		///         <returns>
		///         </returns>
		///         <remarks>
		///         </remarks>
		[NoMac]
		[NoTV]
		[MacCatalyst (13, 1)]
		[Export ("titlePropertyForGroupingType:")]
		[Static]
		string GetTitleProperty (MPMediaGrouping groupingType);

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyPersistentID</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyPersistentID")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString PersistentIDProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyAlbumPersistentID</summary>
		///         <value>
		///         </value>
		///         <remarks>
		/// 	  Persistent IDs can be used as unique identifiers across
		/// 	  application launches and as long as the media item has not
		/// 	  been changed or synchronized again with the host computer.
		/// 	</remarks>
		[Field ("MPMediaItemPropertyAlbumPersistentID")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString AlbumPersistentIDProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyArtistPersistentID</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyArtistPersistentID")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString ArtistPersistentIDProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyAlbumArtistPersistentID</summary>
		///         <value>
		///         </value>
		///         <remarks>
		/// 	  Persistent IDs can be used as unique identifiers across
		/// 	  application launches and as long as the media item has not
		/// 	  been changed or synchronized again with the host computer.
		/// 	</remarks>
		[Field ("MPMediaItemPropertyAlbumArtistPersistentID")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString AlbumArtistPersistentIDProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyGenrePersistentID</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyGenrePersistentID")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString GenrePersistentIDProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyComposerPersistentID</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyComposerPersistentID")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString ComposerPersistentIDProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyPodcastPersistentID</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyPodcastPersistentID")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString PodcastPersistentIDProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyMediaType</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyMediaType")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString MediaTypeProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyTitle</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyTitle")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString TitleProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyAlbumTitle</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyAlbumTitle")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString AlbumTitleProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyArtist</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyArtist")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString ArtistProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyAlbumArtist</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyAlbumArtist")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString AlbumArtistProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyGenre</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyGenre")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString GenreProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyComposer</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyComposer")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString ComposerProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyPlaybackDuration</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyPlaybackDuration")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString PlaybackDurationProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyAlbumTrackNumber</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyAlbumTrackNumber")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString AlbumTrackNumberProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyAlbumTrackCount</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyAlbumTrackCount")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString AlbumTrackCountProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyDiscNumber</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyDiscNumber")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString DiscNumberProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyDiscCount</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyDiscCount")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString DiscCountProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyArtwork</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[MacCatalyst (13, 1)]
		[Field ("MPMediaItemPropertyArtwork")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString ArtworkProperty { get; }

		/// <summary>The value that is associated with the MPMediaItemPropertyIsExplicit constant.</summary>
		[Field ("MPMediaItemPropertyIsExplicit")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString IsExplicitProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyLyrics</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyLyrics")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString LyricsProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyIsCompilation</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyIsCompilation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString IsCompilationProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyReleaseDate</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyReleaseDate")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString ReleaseDateProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyBeatsPerMinute</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyBeatsPerMinute")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString BeatsPerMinuteProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyComments</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyComments")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString CommentsProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyAssetURL</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyAssetURL")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString AssetURLProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyPlayCount</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyPlayCount")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString PlayCountProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertySkipCount</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertySkipCount")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString SkipCountProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyRating</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyRating")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString RatingProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyLastPlayedDate</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyLastPlayedDate")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString LastPlayedDateProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyUserGrouping</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyUserGrouping")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString UserGroupingProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyPodcastTitle</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyPodcastTitle")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString PodcastTitleProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyBookmarkTime</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyBookmarkTime")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString BookmarkTimeProperty { get; }

		/// <summary>Represents the value associated with the constant MPMediaItemPropertyIsCloudItem</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("MPMediaItemPropertyIsCloudItem")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString IsCloudItemProperty { get; }

		/// <summary>The value that is associated with the MPMediaItemPropertyHasProtectedAsset constant.</summary>
		[MacCatalyst (13, 1)]
		[Field ("MPMediaItemPropertyHasProtectedAsset")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString HasProtectedAssetProperty { get; }

		/// <summary>The value that is associated with the MPMediaItemPropertyDateAdded constant.</summary>
		[MacCatalyst (13, 1)]
		[Field ("MPMediaItemPropertyDateAdded")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString DateAddedProperty { get; }

#if !__MACOS__
		/// <summary>Backing store for the <see cref="MPMediaItem.PlaybackStoreID" /> property.</summary>
#endif
		[MacCatalyst (13, 1)]
		[Field ("MPMediaItemPropertyPlaybackStoreID")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		NSString PlaybackStoreIDProperty { get; }

		[TV (14, 5), iOS (14, 5)]
		[MacCatalyst (14, 5)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Field ("MPMediaItemPropertyIsPreorder")]
		NSString IsPreorderProperty { get; }
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MPMediaItemArtwork {
		[MacCatalyst (13, 1)]
		[Export ("initWithBoundsSize:requestHandler:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGSize boundsSize, Func<CGSize, UIImage> requestHandler);

		[NoMac]
		[Deprecated (PlatformName.iOS, 10, 0)]
		[Deprecated (PlatformName.TvOS, 10, 0)]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Export ("initWithImage:")]
		NativeHandle Constructor (UIImage image);

		/// <summary>Get an image of a specific size for the artwork.</summary>
		/// <param name="size">The size of the returned image.</param>
		[Export ("imageWithSize:")]
		[return: NullAllowed]
		UIImage ImageWithSize (CGSize size);

		/// <summary>Gets the Bounds value.</summary>
		[Export ("bounds")]
		CGRect Bounds { get; }

		/// <summary>Gets the ImageCropRectangle value.</summary>
		[NoMac]
		[Deprecated (PlatformName.iOS, 10, 0)]
		[Deprecated (PlatformName.TvOS, 10, 0)]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Export ("imageCropRect")]
		CGRect ImageCropRectangle { get; }
	}

	/// <summary>A sorted set of <see cref="MediaPlayer.MPMediaItem" />s.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPMediaItemCollection_ClassReference/index.html">Apple documentation for <c>MPMediaItemCollection</c></related>
	[NoMac]
	[NoTV]
	[MacCatalyst (13, 1)]
	// Objective-C exception thrown.  Name: MPMediaItemCollectionInitException Reason: -init is not supported, use -initWithItems:
	[DisableDefaultCtor]
#if IOS
	// introduced in 4.2 - but the type was never added to classic
	[BaseType (typeof (MPMediaEntity))]
#else
	[BaseType (typeof (NSObject))]
#endif
	interface MPMediaItemCollection : NSSecureCoding {
		/// <param name="items">The array of media items.</param>
		///         <summary>Creates a new <see cref="MediaPlayer.MPMediaItemCollection" /> by copying the provided <paramref name="items" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("collectionWithItems:")]
		MPMediaItemCollection FromItems (MPMediaItem [] items);

		/// <param name="items">The array of media items.</param>
		/// <summary>Creates a new <see cref="MediaPlayer.MPMediaItemCollection" /> from the provided <paramref name="items" />.</summary>
		[DesignatedInitializer]
		[Export ("initWithItems:")]
		NativeHandle Constructor (MPMediaItem [] items);

		/// <summary>Gets an array that contains the items in the collection.</summary>
		[Export ("items")]
		MPMediaItem [] Items { get; }

		/// <summary>Gets a representative item.</summary>
		[Export ("representativeItem")]
		[NullAllowed]
		MPMediaItem RepresentativeItem { get; }

		/// <summary>Gets the number of items in the collection.</summary>
		[Export ("count")]
		nint Count { get; }

		/// <summary>Gets an array that contains the media types of the items in the collection.</summary>
		[Export ("mediaTypes")]
		MPMediaType MediaTypes { get; }
	}

	/// <summary>Represents the synced set of <see cref="MediaPlayer.MPMediaItem" />s on a device.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPMediaLibrary_ClassReference/index.html">Apple documentation for <c>MPMediaLibrary</c></related>
	[NoMac]
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MPMediaLibrary : NSSecureCoding {
		/// <summary>Gets the DefaultMediaLibrary value.</summary>
		[Static, Export ("defaultMediaLibrary")]
		MPMediaLibrary DefaultMediaLibrary { get; }

		/// <summary>Gets the LastModifiedDate value.</summary>
		[Export ("lastModifiedDate")]
		NSDate LastModifiedDate { get; }

		/// <summary>Performs the begin generating library change notifications operation.</summary>
		[Export ("beginGeneratingLibraryChangeNotifications")]
		void BeginGeneratingLibraryChangeNotifications ();

		/// <summary>Performs the end generating library change notifications operation.</summary>
		[Export ("endGeneratingLibraryChangeNotifications")]
		void EndGeneratingLibraryChangeNotifications ();

		[Field ("MPMediaLibraryDidChangeNotification")]
		[Notification]
		NSString DidChangeNotification { get; }

		/// <summary>Gets the AuthorizationStatus value.</summary>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("authorizationStatus")]
		MPMediaLibraryAuthorizationStatus AuthorizationStatus { get; }

		/// <param name="handler">The completion handler.</param>
		///         <summary>Performs the operation.</summary>
		[MacCatalyst (13, 1)]
		[Static]
		[Async (XmlDocs = """
			<summary>Performs the operation.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous RequestAuthorization operation.  The value of the TResult parameter is of type System.Action&lt;MediaPlayer.MPMediaLibraryAuthorizationStatus&gt;.</para>
			        </returns>
			""")]
		[Export ("requestAuthorization:")]
		void RequestAuthorization (Action<MPMediaLibraryAuthorizationStatus> handler);

		/// <param name="productID">The product identifier.</param>
		///         <param name="completionHandler">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("addItemWithProductID:completionHandler:")]
		[Async (XmlDocs = """
			<param name="productID">The product identifier.</param>
			<summary>Performs the operation.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous AddItem operation.  The value of the TResult parameter is of type System.Action&lt;MediaPlayer.MPMediaEntity[],Foundation.NSError&gt;.</para>
			        </returns>
			""")]
#if IOS
		void AddItem (string productID, [NullAllowed] Action<MPMediaEntity [], NSError> completionHandler);
#else
		void AddItem (string productID, [NullAllowed] Action<MPMediaItem [], NSError> completionHandler);
#endif

		/// <param name="uuid">The unique identifier.</param>
		///         <param name="creationMetadata">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Performs the operation.</summary>
		[MacCatalyst (13, 1)]
		[Async (XmlDocs = """
			<param name="uuid">The unique identifier.</param>
			<param name="creationMetadata">The creation metadata.</param>
			<summary>Performs the operation.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous GetPlaylist operation.  The value of the TResult parameter is of type System.Action&lt;MediaPlayer.MPMediaPlaylist,Foundation.NSError&gt;.</para>
			        </returns>
			<remarks>
			          <para copied="true">The GetPlaylistAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		[Export ("getPlaylistWithUUID:creationMetadata:completionHandler:")]
		void GetPlaylist (NSUuid uuid, [NullAllowed] MPMediaPlaylistCreationMetadata creationMetadata, Action<MPMediaPlaylist, NSError> completionHandler);
	}

	/// <summary>A <see cref="UIKit.UIViewController" /> that allows the application user to select a media item.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPMediaPickerController_ClassReference/index.html">Apple documentation for <c>MPMediaPickerController</c></related>
	[NoTV]
	[NoMac]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (UIViewController), Delegates = new string [] { "WeakDelegate" }, Events = new Type [] { typeof (MPMediaPickerControllerDelegate) })]
	interface MPMediaPickerController {
		/// <param name="mediaTypes">The media types to include.</param>
		/// <summary>Creates a new <see cref="MediaPlayer.MPMediaPickerController" /> for media with the specified <paramref name="mediaTypes" />.</summary>
		[DesignatedInitializer]
		[Export ("initWithMediaTypes:")]
		NativeHandle Constructor (MPMediaType mediaTypes);

		/// <summary>Gets the media types that the picker enables the user to pick.</summary>
		[Export ("mediaTypes")]
		MPMediaType MediaTypes { get; }

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Weak), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>An instance of the MediaPlayer.IMPMediaPickerControllerDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the MediaPlayer.IMPMediaPickerControllerDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		IMPMediaPickerControllerDelegate Delegate { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the user can pick multiple items.</summary>
		[Export ("allowsPickingMultipleItems")]
		bool AllowsPickingMultipleItems { get; set; }

		/// <summary>Gets or sets a string that appears above the picker.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("prompt", ArgumentSemantic.Copy)]
		string Prompt { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether items from the cloud are shown.</summary>
		[Export ("showsCloudItems")]
		bool ShowsCloudItems { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether items that have protected assets are shown.</summary>
		[MacCatalyst (13, 1)]
		[Export ("showsItemsWithProtectedAssets")]
		bool ShowsItemsWithProtectedAssets { get; set; }
	}

	interface IMPMediaPickerControllerDelegate { }

	/// <summary>A delegate object for the <see cref="MediaPlayer.MPMediaPickerController" /> class. Application developers can use this deelegate to respond to events relating to media-item selection.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPMediaPickerControllerDelegate_ProtocolReference/index.html">Apple documentation for <c>MPMediaPickerControllerDelegate</c></related>
	[NoTV]
	[NoMac]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface MPMediaPickerControllerDelegate {
		/// <param name="sender">The sender.</param>
		///         <param name="mediaItemCollection">The media item collection.</param>
		///         <summary>Performs the operation.</summary>
		[Export ("mediaPicker:didPickMediaItems:"), EventArgs ("ItemsPicked", XmlDocs = """
			<summary>Event that is raised when items are picked.</summary>
			"""), EventName ("ItemsPicked")]
		void MediaItemsPicked (MPMediaPickerController sender, MPMediaItemCollection mediaItemCollection);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the operation.</summary>
		[Export ("mediaPickerDidCancel:"), EventArgs ("MPMediaPickerController", XmlDocs = """
			<summary>Method that is called after the user dismisses the picker by canceling it.</summary>
			"""), EventName ("DidCancel")]
		void MediaPickerDidCancel (MPMediaPickerController sender);
	}

	/// <summary>A playable collection of <see cref="MediaPlayer.MPMediaItem" />s.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPMediaPlaylist_ClassReference/index.html">Apple documentation for <c>MPMediaPlaylist</c></related>
	[NoMac]
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPMediaItemCollection))]
	// Objective-C exception thrown.  Name: MPMediaItemCollectionInitException Reason: -init is not supported, use -initWithItems:
	[DisableDefaultCtor]
	interface MPMediaPlaylist : NSSecureCoding {
		/// <param name="items">The array of media items.</param>
		/// <summary>Creates a new <see cref="MediaPlayer.MPMediaPlaylist" /> from the specified <paramref name="items" />.</summary>
		[Export ("initWithItems:")]
		NativeHandle Constructor (MPMediaItem [] items);

		/// <param name="property">The property name.</param>
		///         <summary>Performs the can filter by property operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static, Export ("canFilterByProperty:")]
		bool CanFilterByProperty (string property);

		/// <param name="property">The property name.</param>
		///         <summary>Performs the value for property operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("valueForProperty:")]
		NSObject ValueForProperty (string property);

		/// <summary>Gets the PersistentID value.</summary>
		[Export ("persistentID")]
		ulong PersistentID { get; }

		/// <summary>Gets the Name value.</summary>
		[Export ("name")]
		[NullAllowed]
		string Name { get; }

		/// <summary>Gets the PlaylistAttributes value.</summary>
		[Export ("playlistAttributes")]
		MPMediaPlaylistAttribute PlaylistAttributes { get; }

		/// <summary>Gets the SeedItems value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("seedItems")]
		[NullAllowed]
		MPMediaItem [] SeedItems { get; }

		/// <summary>Gets the user-supplied playlist description.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("descriptionText")]
		string DescriptionText { get; }

		/// <summary>When overridden by the developer, gets the playlist display name. The default value is the application name.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("authorDisplayName")]
		string AuthorDisplayName { get; }

		/// <param name="productID">The product identifier.</param>
		///         <param name="completionHandler">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the operation.</summary>
		[MacCatalyst (13, 1)]
		[Async (XmlDocs = """
			<param name="productID">The product identifier.</param>
			<summary>Performs the operation.</summary>
			<returns>A task that represents the asynchronous AddItem operation</returns>
			""")]
		[Export ("addItemWithProductID:completionHandler:")]
		void AddItem (string productID, [NullAllowed] Action<NSError> completionHandler);

		/// <param name="mediaItems">The array of media items.</param>
		///         <param name="completionHandler">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the operation.</summary>
		[MacCatalyst (13, 1)]
		[Async (XmlDocs = """
			<param name="mediaItems">The array of media items.</param>
			<summary>Performs the operation.</summary>
			<returns>A task that represents the asynchronous AddMediaItems operation</returns>
			<remarks>
			          <para copied="true">The AddMediaItemsAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		[Export ("addMediaItems:completionHandler:")]
		void AddMediaItems (MPMediaItem [] mediaItems, [NullAllowed] Action<NSError> completionHandler);

		[iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[NullAllowed, Export ("cloudGlobalID")]
		string CloudGlobalId { get; }
	}

	/// <summary>Properties of a <see cref="MediaPlayer.MPMediaPlaylist" />, such as name, attributes, and seed items.</summary>
	[Mac (10, 16)]
	[MacCatalyst (13, 1)]
	[Static]
	interface MPMediaPlaylistProperty {
		/// <summary>Represents the value associated with the constant MPMediaPlaylistPropertyPersistentID</summary>
		///         <value>
		///         </value>
		[Field ("MPMediaPlaylistPropertyPersistentID")]
		NSString PersistentID { get; }

		/// <summary>Represents the value associated with the constant MPMediaPlaylistPropertyName</summary>
		///         <value>
		///         </value>
		[Field ("MPMediaPlaylistPropertyName")]
		NSString Name { get; }

		/// <summary>Represents the value associated with the constant MPMediaPlaylistPropertyPlaylistAttributes</summary>
		///         <value>
		///         </value>
		[Field ("MPMediaPlaylistPropertyPlaylistAttributes")]
		NSString PlaylistAttributes { get; }

		/// <summary>Represents the value associated with the constant MPMediaPlaylistPropertySeedItems</summary>
		///         <value>
		///         </value>
		[Field ("MPMediaPlaylistPropertySeedItems")]
		NSString SeedItems { get; }

		/// <summary>Gets the description text.</summary>
		[NoTV] // do not work on AppleTV devices (only in simulator)
		[MacCatalyst (13, 1)]
		[Field ("MPMediaPlaylistPropertyDescriptionText")]
		NSString DescriptionText { get; }

		/// <summary>Gets the display name for the author.</summary>
		[NoTV] // do not work on AppleTV devices (only in simulator)
		[MacCatalyst (13, 1)]
		[Field ("MPMediaPlaylistPropertyAuthorDisplayName")]
		NSString AuthorDisplayName { get; }

		[iOS (14, 0)]
		[TV (14, 0)]
		[MacCatalyst (14, 0)]
		[Field ("MPMediaPlaylistPropertyCloudGlobalID")]
		NSString CloudGlobalId { get; }
	}

	/// <summary>Allows the application developer to programmatically search an <see cref="MediaPlayer.MPMediaLibrary" /> by applying zero-or-more <see cref="MediaPlayer.MPMediaPredicate" />s and an optional <see cref="MediaPlayer.MPMediaGrouping" />.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPMediaQuery_ClassReference/index.html">Apple documentation for <c>MPMediaQuery</c></related>
	[NoMac]
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MPMediaQuery : NSSecureCoding, NSCopying {
		/// <param name="filterPredicates">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[DesignatedInitializer]
		[Export ("initWithFilterPredicates:")]
		NativeHandle Constructor ([NullAllowed] NSSet filterPredicates);

		/// <summary>Gets or sets the FilterPredicates value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("filterPredicates", ArgumentSemantic.Retain)]
		NSSet FilterPredicates { get; set; }

		/// <param name="predicate">The predicate.</param>
		///         <summary>Performs the add filter predicate operation.</summary>
		[Export ("addFilterPredicate:")]
		void AddFilterPredicate (MPMediaPredicate predicate);

		/// <param name="predicate">The predicate.</param>
		///         <summary>Performs the remove filter predicate operation.</summary>
		[Export ("removeFilterPredicate:")]
		void RemoveFilterPredicate (MPMediaPredicate predicate);

		/// <summary>Gets the Items value.</summary>
		[Export ("items")]
		[NullAllowed]
		MPMediaItem [] Items { get; }

		/// <summary>Gets the Collections value.</summary>
		[Export ("collections")]
		[NullAllowed]
		MPMediaItemCollection [] Collections { get; }

		/// <summary>Gets or sets the GroupingType value.</summary>
		[Export ("groupingType")]
		MPMediaGrouping GroupingType { get; set; }

		/// <summary>Gets the AlbumsQuery value.</summary>
		[Export ("albumsQuery")]
		[Static]
		MPMediaQuery AlbumsQuery { get; }

		/// <summary>Gets the ArtistsQuery value.</summary>
		[Export ("artistsQuery")]
		[Static]
		MPMediaQuery ArtistsQuery { get; }

		/// <summary>Gets the SongsQuery value.</summary>
		[Export ("songsQuery")]
		[Static]
		MPMediaQuery SongsQuery { get; }

		/// <summary>Gets the PlaylistsQuery value.</summary>
		[Export ("playlistsQuery")]
		[Static]
		MPMediaQuery PlaylistsQuery { get; }

		/// <summary>Gets the PodcastsQuery value.</summary>
		[Export ("podcastsQuery")]
		[Static]
		MPMediaQuery PodcastsQuery { get; }

		/// <summary>Gets the AudiobooksQuery value.</summary>
		[Export ("audiobooksQuery")]
		[Static]
		MPMediaQuery AudiobooksQuery { get; }

		/// <summary>Gets the CompilationsQuery value.</summary>
		[Export ("compilationsQuery")]
		[Static]
		MPMediaQuery CompilationsQuery { get; }

		/// <summary>Gets the ComposersQuery value.</summary>
		[Export ("composersQuery")]
		[Static]
		MPMediaQuery ComposersQuery { get; }

		/// <summary>Gets the GenresQuery value.</summary>
		[Export ("genresQuery")]
		[Static]
		MPMediaQuery GenresQuery { get; }

		/// <summary>Gets the CollectionSections value.</summary>
		[Export ("collectionSections")]
		[NullAllowed]
		MPMediaQuerySection [] CollectionSections { get; }

		/// <summary>Gets the ItemSections value.</summary>
		[Export ("itemSections")]
		[NullAllowed]
		MPMediaQuerySection [] ItemSections { get; }
	}

	/// <summary>A base class for types that specify filters for <see cref="MediaPlayer.MPMediaQuery" /> queries.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPMediaPredicate_ClassReference/index.html">Apple documentation for <c>MPMediaPredicate</c></related>
	[NoMac]
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MPMediaPredicate : NSSecureCoding {
	}

	/// <summary>A type of <see cref="MediaPlayer.MPMediaPredicate" /> that evaluates <see cref="MediaPlayer.MPMediaType" />s.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPMediaPropertyPredicate_ClassReference/index.html">Apple documentation for <c>MPMediaPropertyPredicate</c></related>
	[NoMac]
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPMediaPredicate))]
	interface MPMediaPropertyPredicate {
		/// <param name="value">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="property">The property name.</param>
		///         <summary>Performs the predicate with value operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static, Export ("predicateWithValue:forProperty:")]
		MPMediaPropertyPredicate PredicateWithValue ([NullAllowed] NSObject value, string property);

		/// <param name="value">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="property">The property name.</param>
		///         <param name="comparisonType">The comparison type.</param>
		///         <summary>Performs the predicate with value operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static, Export ("predicateWithValue:forProperty:comparisonType:")]
		MPMediaPropertyPredicate PredicateWithValue ([NullAllowed] NSObject value, string property, MPMediaPredicateComparison comparisonType);

		/// <summary>Gets the Property value.</summary>
		[Export ("property", ArgumentSemantic.Copy)]
		string Property { get; }

		/// <summary>Gets the Value value.</summary>
		[Export ("value", ArgumentSemantic.Copy)]
		[NullAllowed]
		NSObject Value { get; }

		/// <summary>Gets the ComparisonType value.</summary>
		[Export ("comparisonType")]
		MPMediaPredicateComparison ComparisonType { get; }
	}

	/// <summary>Logs metrics relating to streaming playback of a movie.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPMovieAccessLog_Class/index.html">Apple documentation for <c>MPMovieAccessLog</c></related>
	[NoMac]
	[NoTV]
	[Deprecated (PlatformName.iOS, 9, 0)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1)]
	[BaseType (typeof (NSObject))]
	interface MPMovieAccessLog : NSCopying {
		/// <summary>Gets the Events value.</summary>
		[Export ("events")]
		MPMovieAccessLogEvent [] Events { get; }

		/// <summary>Gets the ExtendedLogDataStringEncoding value.</summary>
		[Export ("extendedLogDataStringEncoding")]
		NSStringEncoding ExtendedLogDataStringEncoding { get; }

		/// <summary>Gets the ExtendedLogData value.</summary>
		[Export ("extendedLogData")]
		NSData ExtendedLogData { get; }
	}

	/// <summary>A log of errors that occurred during network resources.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPMovieErrorLog_Class/index.html">Apple documentation for <c>MPMovieErrorLog</c></related>
	[NoMac]
	[NoTV]
	[Deprecated (PlatformName.iOS, 9, 0)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1)]
	[BaseType (typeof (NSObject))]
	interface MPMovieErrorLog : NSCopying {
		/// <summary>Gets the Events value.</summary>
		[Export ("events")]
		MPMovieErrorLogEvent [] Events { get; }

		/// <summary>Gets the ExtendedLogDataStringEncoding value.</summary>
		[Export ("extendedLogDataStringEncoding")]
		NSStringEncoding ExtendedLogDataStringEncoding { get; }

		/// <summary>Gets the ExtendedLogData value.</summary>
		[Export ("extendedLogData")]
		NSData ExtendedLogData { get; }
	}

	/// <summary>Represents a specific metric or event that occurred during network playback of a movie.</summary>
	///     
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPMovieAccessLogEvent_Class/index.html">Apple documentation for <c>MPMovieAccessLogEvent</c></related>
	[NoMac]
	[NoTV]
	[Deprecated (PlatformName.iOS, 9, 0)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1)]
	[BaseType (typeof (NSObject))]
	interface MPMovieAccessLogEvent : NSCopying {
		/// <summary>Gets the SegmentedDownloadedCount value.</summary>
		[Export ("numberOfSegmentsDownloaded")]
		nint SegmentedDownloadedCount { get; }

		/// <summary>Gets the PlaybackStartDate value.</summary>
		[Export ("playbackStartDate")]
		NSData PlaybackStartDate { get; }

		/// <summary>Gets the Uri value.</summary>
		[Export ("URI")]
		string Uri { get; }

		/// <summary>Gets the ServerAddress value.</summary>
		[Export ("serverAddress")]
		string ServerAddress { get; }

		/// <summary>Gets the ServerAddressChangeCount value.</summary>
		[Export ("numberOfServerAddressChanges")]
		nint ServerAddressChangeCount { get; }

		/// <summary>Gets the PlaybackSessionID value.</summary>
		[Export ("playbackSessionID")]
		string PlaybackSessionID { get; }

		/// <summary>Gets the PlaybackStartOffset value.</summary>
		[Export ("playbackStartOffset")]
		double PlaybackStartOffset { get; }

		/// <summary>Gets the SegmentsDownloadedDuration value.</summary>
		[Export ("segmentsDownloadedDuration")]
		double SegmentsDownloadedDuration { get; }

		/// <summary>Gets the DurationWatched value.</summary>
		[Export ("durationWatched")]
		double DurationWatched { get; }

		/// <summary>Gets the StallCount value.</summary>
		[Export ("numberOfStalls")]
		nint StallCount { get; }

		/// <summary>Gets the BytesTransferred value.</summary>
		[Export ("numberOfBytesTransferred")]
		long BytesTransferred { get; }

		/// <summary>Gets the ObservedBitrate value.</summary>
		[Export ("observedBitrate")]
		double ObservedBitrate { get; }

		/// <summary>Gets the IndicatedBitrate value.</summary>
		[Export ("indicatedBitrate")]
		double IndicatedBitrate { get; }

		/// <summary>Gets the DroppedVideoFrameCount value.</summary>
		[Export ("numberOfDroppedVideoFrames")]
		nint DroppedVideoFrameCount { get; }
	}

	/// <summary>An event documenting a network playback error.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPMovieErrorLogEvent_Class/index.html">Apple documentation for <c>MPMovieErrorLogEvent</c></related>
	[NoMac]
	[NoTV]
	[Deprecated (PlatformName.iOS, 9, 0)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1)]
	[BaseType (typeof (NSObject))]
	interface MPMovieErrorLogEvent : NSCopying {
		/// <summary>Gets the Date value.</summary>
		[Export ("date")]
		NSDate Date { get; }

		/// <summary>Gets the Uri value.</summary>
		[Export ("URI")]
		string Uri { get; }

		/// <summary>Gets the ServerAddress value.</summary>
		[Export ("serverAddress")]
		string ServerAddress { get; }

		/// <summary>Gets the PlaybackSessionID value.</summary>
		[Export ("playbackSessionID")]
		string PlaybackSessionID { get; }

		/// <summary>Gets the ErrorStatusCode value.</summary>
		[Export ("errorStatusCode")]
		nint ErrorStatusCode { get; }

		/// <summary>Gets the ErrorDomain value.</summary>
		[Export ("errorDomain")]
		string ErrorDomain { get; }

		/// <summary>Gets the ErrorComment value.</summary>
		[Export ("errorComment")]
		string ErrorComment { get; }
	}

	/// <summary>Provides data for the  event.</summary>
	[NoMac]
	[Deprecated (PlatformName.iOS, 9, 0)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1)]
	interface MPMoviePlayerFinishedEventArgs {
		/// <summary>Gets the FinishReason value.</summary>
		[Export ("MPMoviePlayerPlaybackDidFinishReasonUserInfoKey")]
		MPMovieFinishReason FinishReason { get; }
	}

	/// <summary>Provides data for the  event.</summary>
	[NoMac]
	[Deprecated (PlatformName.iOS, 9, 0)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1)]
	interface MPMoviePlayerFullScreenEventArgs {
		/// <summary>Gets the AnimationDuration value.</summary>
		[Export ("MPMoviePlayerFullscreenAnimationDurationUserInfoKey")]
		double AnimationDuration { get; }

		/// <summary>Gets the AnimationCurve value.</summary>
		[Export ("MPMoviePlayerFullscreenAnimationCurveUserInfoKey")]
		UIViewAnimationCurve AnimationCurve { get; }
	}

	/// <summary>Provides data for the  event.</summary>
	[NoMac]
	[Deprecated (PlatformName.iOS, 9, 0)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1)]
	interface MPMoviePlayerThumbnailEventArgs {
		/// <summary>Gets the Image value.</summary>
		[Export ("MPMoviePlayerThumbnailImageKey")]
		UIImage Image { get; }

		/// <summary>Gets the Time value.</summary>
		[Export ("MPMoviePlayerThumbnailTimeKey")]
		double Time { get; }

		/// <summary>Gets the Error value.</summary>
		[Export ("MPMoviePlayerThumbnailErrorKey")]
		NSError Error { get; }
	}

	/// <summary>Provides data for the  event.</summary>
	[NoMac]
	[Deprecated (PlatformName.iOS, 9, 0)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1)]
	interface MPMoviePlayerTimedMetadataEventArgs {
		/// <summary>Gets the TimedMetadata value.</summary>
		[Export ("MPMoviePlayerTimedMetadataUserInfoKey")]
		MPTimedMetadata [] TimedMetadata { get; }
	}

	[NoMac]
	[TV (16, 0)]
	[MacCatalyst (13, 1)]
	[Protocol]
	interface MPMediaPlayback {
		/// <summary>Performs the play operation.</summary>
		[Abstract]
		[Export ("play")]
		void Play ();

		/// <summary>Performs the stop operation.</summary>
		[Abstract]
		[Export ("stop")]
		void Stop ();

		/// <summary>Performs the pause operation.</summary>
		[Abstract]
		[Export ("pause")]
		void Pause ();

		/// <summary>Performs the prepare to play operation.</summary>
		[Abstract]
		[Export ("prepareToPlay")]
		void PrepareToPlay ();

		/// <summary>Gets the IsPreparedToPlay value.</summary>
		[Abstract]
		[Export ("isPreparedToPlay")]
		bool IsPreparedToPlay { get; }

		/// <summary>Gets or sets the CurrentPlaybackTime value.</summary>
		[Abstract]
		[Export ("currentPlaybackTime")]
		double CurrentPlaybackTime { get; set; }

		/// <summary>Gets or sets the CurrentPlaybackRate value.</summary>
		[Abstract]
		[Export ("currentPlaybackRate")]
		float CurrentPlaybackRate { get; set; } // float, not CGFloat

		/// <summary>Performs the begin seeking forward operation.</summary>
		[Abstract]
		[Export ("beginSeekingForward")]
		void BeginSeekingForward ();

		/// <summary>Performs the begin seeking backward operation.</summary>
		[Abstract]
		[Export ("beginSeekingBackward")]
		void BeginSeekingBackward ();

		/// <summary>Performs the end seeking operation.</summary>
		[Abstract]
		[Export ("endSeeking")]
		void EndSeeking ();
	}

	/// <summary>A class that manages the playback of a movie from a file or via streaming.</summary>
	///     
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPMoviePlayerController_Class/index.html">Apple documentation for <c>MPMoviePlayerController</c></related>
	[NoMac]
	[NoTV]
	[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
	[Deprecated (PlatformName.MacCatalyst, 14, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
	[MacCatalyst (14, 0)] // docs says 13.0 but this throws: NSInvalidArgumentException Reason: MPMoviePlayerController is no longer available. Use AVPlayerViewController in AVKit.
	[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
	[BaseType (typeof (NSObject))]
	interface MPMoviePlayerController : MPMediaPlayback {
		/// <param name="url">The URL.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[MacCatalyst (13, 1)]
		[DesignatedInitializer]
		[Export ("initWithContentURL:")]
		NativeHandle Constructor (NSUrl url);

		/// <summary>Gets or sets the ScalingMode value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("scalingMode")]
		MPMovieScalingMode ScalingMode { get; set; }

		/// <summary>Gets or sets the InitialPlaybackTime value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("initialPlaybackTime")]
		double InitialPlaybackTime { get; set; }

		/// <summary>Gets or sets the ContentUrl value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed] // by default this property is null
		[Export ("contentURL", ArgumentSemantic.Copy)]
		NSUrl ContentUrl { get; set; }

		/// <summary>Gets the View value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("view")]
		UIView View { get; }

		/// <summary>Gets the BackgroundView value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("backgroundView")]
		UIView BackgroundView { get; }

		/// <summary>Gets the PlaybackState value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("playbackState")]
		MPMoviePlaybackState PlaybackState { get; }

		/// <summary>Gets the LoadState value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("loadState")]
		MPMovieLoadState LoadState { get; }

		/// <summary>Gets or sets the ControlStyle value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("controlStyle")]
		MPMovieControlStyle ControlStyle { get; set; }

		/// <summary>Gets or sets the RepeatMode value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("repeatMode")]
		MPMovieRepeatMode RepeatMode { get; set; }

		/// <summary>Gets or sets the ShouldAutoplay value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("shouldAutoplay")]
		bool ShouldAutoplay { get; set; }

		/// <summary>Gets or sets the UseApplicationAudioSession value.</summary>
		[Export ("useApplicationAudioSession")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		bool UseApplicationAudioSession { get; set; }

		/// <summary>Gets or sets the Fullscreen value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("fullscreen")]
		bool Fullscreen { [Bind ("isFullscreen")] get; set; }

		/// <param name="fullscreen">Whether to display in fullscreen.</param>
		///         <param name="animated">Whether to animate the transition.</param>
		///         <summary>Performs the set fullscreen operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("setFullscreen:animated:")]
		void SetFullscreen (bool fullscreen, bool animated);

		/// <summary>Gets or sets the AllowsAirPlay value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("allowsAirPlay")]
		bool AllowsAirPlay { get; set; }

		/// <summary>Gets the AirPlayVideoActive value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("airPlayVideoActive")]
		bool AirPlayVideoActive { [Bind ("isAirPlayVideoActive")] get; }

		/// <summary>Developers should not use this deprecated property. </summary>
		[Deprecated (PlatformName.iOS, 9, 0)]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Export ("accessLog")]
		MPMovieAccessLog AccessLog { get; }

		/// <summary>Gets the ErrorLog value.</summary>
		[Deprecated (PlatformName.iOS, 9, 0)]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Export ("errorLog")]
		MPMovieErrorLog ErrorLog { get; }

		// Brought it from the MPMediaPlayback.h

		/// <param name="time">The time.</param>
		///         <param name="timeOption">The time option.</param>
		///         <summary>Performs the thumbnail image at operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("thumbnailImageAtTime:timeOption:")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use 'RequestThumbnails' instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'RequestThumbnails' instead.")]
		UIImage ThumbnailImageAt (double time, MPMovieTimeOption timeOption);

		/// <param name="doubleNumbers">The array of time values.</param>
		///         <param name="timeOption">The time option.</param>
		///         <summary>Performs the request thumbnails operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("requestThumbnailImagesAtTimes:timeOption:")]
		void RequestThumbnails (NSNumber [] doubleNumbers, MPMovieTimeOption timeOption);

		/// <summary>Performs the cancel all thumbnail image requests operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("cancelAllThumbnailImageRequests")]
		void CancelAllThumbnailImageRequests ();

		//
		// From interface MPMovieProperties
		//
		/// <summary>Gets the MovieMediaTypes value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("movieMediaTypes")]
		MPMovieMediaType MovieMediaTypes { get; }

		/// <summary>Gets or sets the SourceType value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("movieSourceType")]
		MPMovieSourceType SourceType { get; set; }

		/// <summary>Gets the Duration value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("duration")]
		double Duration { get; }

		/// <summary>Gets the PlayableDuration value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("playableDuration")]
		double PlayableDuration { get; }

		/// <summary>Gets the NaturalSize value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("naturalSize")]
		CGSize NaturalSize { get; }

		/// <summary>Gets or sets the EndPlaybackTime value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("endPlaybackTime")]
		double EndPlaybackTime { get; set; }

		/// <summary>Gets the TimedMetadata value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("timedMetadata")]
		MPTimedMetadata [] TimedMetadata { get; }

		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerScalingModeDidChangeNotification")]
		[Notification]
		NSString ScalingModeDidChangeNotification { get; }

		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerPlaybackDidFinishNotification")]
		[Notification (typeof (MPMoviePlayerFinishedEventArgs))]
		NSString PlaybackDidFinishNotification { get; }

		/// <summary>Represents the value associated with the constant MPMoviePlayerPlaybackDidFinishReasonUserInfoKey</summary>
		///         <value>
		///         </value>
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerPlaybackDidFinishReasonUserInfoKey")] // NSNumber (MPMovieFinishReason)
		NSString PlaybackDidFinishReasonUserInfoKey { get; }

		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerPlaybackStateDidChangeNotification")]
		[Notification]
		NSString PlaybackStateDidChangeNotification { get; }

		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerLoadStateDidChangeNotification")]
		[Notification]
		NSString LoadStateDidChangeNotification { get; }

		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerNowPlayingMovieDidChangeNotification")]
		[Notification]
		NSString NowPlayingMovieDidChangeNotification { get; }

		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerWillEnterFullscreenNotification")]
		[Notification (typeof (MPMoviePlayerFullScreenEventArgs))]
		[Notification]
		NSString WillEnterFullscreenNotification { get; }

		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerDidEnterFullscreenNotification")]
		[Notification]
		NSString DidEnterFullscreenNotification { get; }

		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerWillExitFullscreenNotification")]
		[Notification (typeof (MPMoviePlayerFullScreenEventArgs))]
		NSString WillExitFullscreenNotification { get; }

		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerDidExitFullscreenNotification")]
		[Notification]
		NSString DidExitFullscreenNotification { get; }

		/// <summary>Represents the value associated with the constant MPMoviePlayerFullscreenAnimationDurationUserInfoKey</summary>
		///         <value>
		///         </value>
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerFullscreenAnimationDurationUserInfoKey")]
		NSString FullscreenAnimationDurationUserInfoKey { get; }

		/// <summary>Represents the value associated with the constant MPMoviePlayerFullscreenAnimationCurveUserInfoKey</summary>
		///         <value>
		///         </value>
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerFullscreenAnimationCurveUserInfoKey")]
		NSString FullscreenAnimationCurveUserInfoKey { get; }

		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMovieMediaTypesAvailableNotification")]
		[Notification]
		NSString TypesAvailableNotification { get; }

		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMovieSourceTypeAvailableNotification")]
		[Notification]
		NSString SourceTypeAvailableNotification { get; }

		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMovieDurationAvailableNotification")]
		[Notification]
		NSString DurationAvailableNotification { get; }

		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMovieNaturalSizeAvailableNotification")]
		[Notification]
		NSString NaturalSizeAvailableNotification { get; }

		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerThumbnailImageRequestDidFinishNotification")]
		[Notification (typeof (MPMoviePlayerThumbnailEventArgs))]
		NSString ThumbnailImageRequestDidFinishNotification { get; }

		/// <summary>Represents the value associated with the constant MPMoviePlayerThumbnailImageKey</summary>
		///         <value>
		///         </value>
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerThumbnailImageKey")]
		NSString ThumbnailImageKey { get; }

		/// <summary>Represents the value associated with the constant MPMoviePlayerThumbnailTimeKey</summary>
		///         <value>
		///         </value>
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerThumbnailTimeKey")]
		NSString ThumbnailTimeKey { get; }

		/// <summary>Represents the value associated with the constant MPMoviePlayerThumbnailErrorKey</summary>
		///         <value>
		///         </value>
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerThumbnailErrorKey")]
		NSString ThumbnailErrorKey { get; }

		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerTimedMetadataUpdatedNotification")]
		[Notification (typeof (MPMoviePlayerTimedMetadataEventArgs))]
		NSString TimedMetadataUpdatedNotification { get; }

		/// <summary>Represents the value associated with the constant MPMoviePlayerTimedMetadataUserInfoKey</summary>
		///         <value>
		///         </value>
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerTimedMetadataUserInfoKey")]
		NSString TimedMetadataUserInfoKey { get; }

		/// <summary>Represents the value associated with the constant MPMoviePlayerTimedMetadataKeyName</summary>
		///         <value>
		///         </value>
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerTimedMetadataKeyName")]
		NSString TimedMetadataKeyName { get; }

		/// <summary>Represents the value associated with the constant MPMoviePlayerTimedMetadataKeyInfo</summary>
		///         <value>
		///         </value>
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerTimedMetadataKeyInfo")]
		NSString TimedMetadataKeyInfo { get; }

		/// <summary>Represents the value associated with the constant MPMoviePlayerTimedMetadataKeyMIMEType</summary>
		///         <value>
		///         </value>
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerTimedMetadataKeyMIMEType")]
		NSString TimedMetadataKeyMIMEType { get; }

		/// <summary>Represents the value associated with the constant MPMoviePlayerTimedMetadataKeyDataType</summary>
		///         <value>
		///         </value>
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerTimedMetadataKeyDataType")]
		NSString TimedMetadataKeyDataType { get; }

		/// <summary>Represents the value associated with the constant MPMoviePlayerTimedMetadataKeyLanguageCode</summary>
		///         <value>
		///         </value>
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerTimedMetadataKeyLanguageCode")]
		NSString TimedMetadataKeyLanguageCode { get; }

		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMediaPlaybackIsPreparedToPlayDidChangeNotification")]
		[Notification]
		NSString MediaPlaybackIsPreparedToPlayDidChangeNotification { get; }

		/// <summary>Gets the ReadyForDisplay value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("readyForDisplay")]
		bool ReadyForDisplay { get; }

		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerReadyForDisplayDidChangeNotification")]
		[Notification]
		NSString MoviePlayerReadyForDisplayDidChangeNotification { get; }

		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
		[Field ("MPMoviePlayerIsAirPlayVideoActiveDidChangeNotification")]
		[Notification]
		NSString MPMoviePlayerIsAirPlayVideoActiveDidChangeNotification { get; }
	}

	/// <summary>Encapsulates timed metadata for use with time-based HTTP media streams.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPTimedMetadata_Class/index.html">Apple documentation for <c>MPTimedMetadata</c></related>
	[NoMac]
	[NoTV]
	[Deprecated (PlatformName.iOS, 9, 0)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1)]
	[BaseType (typeof (NSObject))]
	// Objective-C exception thrown.  Name: NSGenericException Reason: MPTimedMetadata cannot be created directly
	[DisableDefaultCtor]
	interface MPTimedMetadata {
		/// <summary>A key that identifies APiece of timed metadata.</summary>
		[Export ("key")]
		string Key { get; }

		/// <summary>The namespace of the <see cref="MediaPlayer.MPTimedMetadata" />.</summary>
		[Export ("keyspace")]
		string Keyspace { get; }

		/// <summary>The timed metadata.</summary>
		[Export ("value")]
		NSObject Value { get; }

		/// <summary>The timestamp of the metadata, in the timebase of the media.</summary>
		[Export ("timestamp")]
		double Timestamp { get; }

		/// <summary>All of the metadata.</summary>
		[Export ("allMetadata")]
		NSDictionary AllMetadata { get; }
	}

	/// <summary>A subclass of <see cref="UIKit.UIViewController" /> that can present and play a movie.</summary>
	///     
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPMoviePlayerViewController_class/index.html">Apple documentation for <c>MPMoviePlayerViewController</c></related>
	[NoTV]
	[NoMac]
	[BaseType (typeof (UIViewController))]
	[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
	[MacCatalyst (14, 0)] // docs says 13.0 but this throws: NSInvalidArgumentException Reason: MPMoviePlayerViewController is no longer available. Use AVPlayerViewController in AVKit.
	[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayerViewController' (AVKit) instead.")]
	interface MPMoviePlayerViewController {
		/// <param name="url">The URL.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[DesignatedInitializer]
		[Export ("initWithContentURL:")]
		NativeHandle Constructor (NSUrl url);

		/// <summary>Gets the MoviePlayer value.</summary>
		[Export ("moviePlayer")]
		MPMoviePlayerController MoviePlayer { get; }
	}

	/// <summary>A class that plays media items from the device's <see cref="MediaPlayer.MPMediaLibrary" />.</summary>
	/// <remarks>
	///       <para>This class may only be used from the application's main thread.</para>
	///     </remarks>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPMusicPlayerController_ClassReference/index.html">Apple documentation for <c>MPMusicPlayerController</c></related>
	[NoMac]
	[TV (14, 0)]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MPMusicPlayerController : MPMediaPlayback {

		/// <summary>Default constructor that initializes a new instance of this class with no parameters.</summary>
		/// <remarks>
		///         </remarks>
		[Export ("init")]
		[Deprecated (PlatformName.iOS, 11, 3)]
		[NoTV]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		NativeHandle Constructor ();

		/// <summary>Gets the music player for the application queue.</summary>
		[Static, Export ("applicationMusicPlayer")]
		MPMusicPlayerController ApplicationMusicPlayer { get; }

		/// <summary>Gets the music player for the application queue.</summary>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("applicationQueuePlayer")]
		MPMusicPlayerApplicationController ApplicationQueuePlayer { get; }

		/// <summary>Developers should not use this deprecated property. Developers should use 'SystemMusicPlayer' instead.</summary>
		[Static, Export ("iPodMusicPlayer")]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use 'SystemMusicPlayer' instead.")]
		[NoTV]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'SystemMusicPlayer' instead.")]
		MPMusicPlayerController iPodMusicPlayer { get; }

		/// <summary>Gets the SystemMusicPlayer value.</summary>
		[MacCatalyst (13, 1)]
		[Static, Export ("systemMusicPlayer")]
		MPMusicPlayerController SystemMusicPlayer { get; }

		/// <summary>Gets the PlaybackState value.</summary>
		[Export ("playbackState")]
		MPMusicPlaybackState PlaybackState { get; }

		/// <summary>Gets or sets the RepeatMode value.</summary>
		[Export ("repeatMode")]
		MPMusicRepeatMode RepeatMode { get; set; }

		/// <summary>Gets or sets the ShuffleMode value.</summary>
		[Export ("shuffleMode")]
		MPMusicShuffleMode ShuffleMode { get; set; }

		/// <summary>Gets or sets the Volume value.</summary>
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use 'MPVolumeView' for volume control instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use 'MPVolumeView' for volume control instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'MPVolumeView' for volume control instead.")]
		[Export ("volume")]
		float Volume { get; set; } // nfloat, not CGFloat

		/// <summary>Gets the index of the currently playing item.</summary>
		[Export ("indexOfNowPlayingItem")]
		nuint IndexOfNowPlayingItem { get; }

		/// <summary>Gets or sets the NowPlayingItem value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[ForcedType]
		[Export ("nowPlayingItem", ArgumentSemantic.Copy), NullAllowed]
		MPMediaItem NowPlayingItem { get; set; }

		/// <param name="query">The media query.</param>
		///         <summary>Performs the set queue operation.</summary>
		[NoTV]
		[MacCatalyst (13, 1)]
		[Export ("setQueueWithQuery:")]
		void SetQueue (MPMediaQuery query);

		/// <param name="collection">The media item collection.</param>
		///         <summary>Sets the queue to the provided <paramref name="collection" />.</summary>
		[NoTV]
		[MacCatalyst (13, 1)]
		[Export ("setQueueWithItemCollection:")]
		void SetQueue (MPMediaItemCollection collection);

		/// <param name="storeIDs">The store identifiers.</param>
		///         <summary>Assigns the player queue to <paramref name="storeIDs" />.</summary>
		[MacCatalyst (13, 1)]
		[Export ("setQueueWithStoreIDs:")]
		void SetQueue (string [] storeIDs);

		/// <param name="descriptor">The queue descriptor.</param>
		///         <summary>Performs the set queue operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("setQueueWithDescriptor:")]
		void SetQueue (MPMusicPlayerQueueDescriptor descriptor);

		/// <param name="descriptor">The queue with the items to prepend.</param>
		///         <summary>Inserts the items that are described by the supplied descriptor immediately after the currently playing item.</summary>
		[MacCatalyst (13, 1)]
		[Export ("prependQueueDescriptor:")]
		void Prepend (MPMusicPlayerQueueDescriptor descriptor);

		/// <param name="descriptor">The queue with the items to append.</param>
		///         <summary>Appends the items that are described by <paramref name="descriptor" /> to the current queue.</summary>
		[MacCatalyst (13, 1)]
		[Export ("appendQueueDescriptor:")]
		void Append (MPMusicPlayerQueueDescriptor descriptor);

		/// <param name="completionHandler">A handler to run after the first item in the queue is buffered.</param>
		///         <summary>Puts the first item in the queue into the buffer and runs a handler after the item has been buffered.</summary>
		[MacCatalyst (13, 1)]
		[Async (XmlDocs = """
			<summary>Puts the first item in the queue into the buffer and runs a handler after the item has been buffered.</summary>
			<returns>A task that represents the asynchronous PrepareToPlay operation</returns>
			<remarks>
			          <para copied="true">The PrepareToPlayAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		[Export ("prepareToPlayWithCompletionHandler:")]
		void PrepareToPlay (Action<NSError> completionHandler);

		/// <summary>Performs the skip to next item operation.</summary>
		[Export ("skipToNextItem")]
		void SkipToNextItem ();

		/// <summary>Performs the skip to beginning operation.</summary>
		[Export ("skipToBeginning")]
		void SkipToBeginning ();

		/// <summary>Performs the skip to previous item operation.</summary>
		[Export ("skipToPreviousItem")]
		void SkipToPreviousItem ();

		/// <summary>Performs the begin generating playback notifications operation.</summary>
		[Export ("beginGeneratingPlaybackNotifications")]
		void BeginGeneratingPlaybackNotifications ();

		/// <summary>Performs the end generating playback notifications operation.</summary>
		[Export ("endGeneratingPlaybackNotifications")]
		void EndGeneratingPlaybackNotifications ();

		[Field ("MPMusicPlayerControllerPlaybackStateDidChangeNotification")]
		[Notification]
		NSString PlaybackStateDidChangeNotification { get; }

		[Field ("MPMusicPlayerControllerNowPlayingItemDidChangeNotification")]
		[Notification]
		NSString NowPlayingItemDidChangeNotification { get; }

		[NoTV]
		[MacCatalyst (13, 1)]
		[Field ("MPMusicPlayerControllerVolumeDidChangeNotification")]
		[Notification]
		NSString VolumeDidChangeNotification { get; }
	}

	/// <summary>A <see cref="UIKit.UIView" /> that presents a slider control used to set the system output volume.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPVolumeView_Class/index.html">Apple documentation for <c>MPVolumeView</c></related>
	[NoMac]
	[TV (14, 0)]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (UIView))]
	interface MPVolumeView {
		/// <param name="frame">Frame used by the view, expressed in iOS points.</param>
		/// <summary>Initializes the MPVolumeView with the specified frame.</summary>
		/// <remarks>
		///           <para>This constructor is used to programmatically create a new instance of MPVolumeView with the specified dimension in the frame.   The object will only be displayed once it has been added to a view hierarchy by calling AddSubview in a containing view.</para>
		///           <para>This constructor is not invoked when deserializing objects from storyboards or XIB files; instead, the constructor that takes an NSCoder parameter is invoked.</para>
		///         </remarks>
		[Export ("initWithFrame:")]
		NativeHandle Constructor (CGRect frame);

		/// <summary>Gets or sets the ShowsRouteButton value.</summary>
		[Deprecated (PlatformName.iOS, 13, 0, message: "Use 'AVRoutePickerView' instead.")]
		[Deprecated (PlatformName.TvOS, 13, 0, message: "Use 'AVRoutePickerView' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVRoutePickerView' instead.")]
		[Export ("showsRouteButton")]
		bool ShowsRouteButton { get; set; }

		/// <summary>Gets or sets the ShowsVolumeSlider value.</summary>
		[Deprecated (PlatformName.iOS, 13, 0, message: "Use 'AVRouteDetector.MultipleRoutesDetected' instead.")]
		[Deprecated (PlatformName.TvOS, 13, 0, message: "Use 'AVRouteDetector.MultipleRoutesDetected' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVRouteDetector.MultipleRoutesDetected' instead.")]
		[Export ("showsVolumeSlider")]
		bool ShowsVolumeSlider { get; set; }

		/// <param name="image">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="state">The control state.</param>
		///         <summary>Performs the set minimum volume slider image operation.</summary>
		[Deprecated (PlatformName.iOS, 13, 0, message: "Use 'AVPlayer.ExternalPlaybackActive' instead.")]
		[Deprecated (PlatformName.TvOS, 13, 0, message: "Use 'AVPlayer.ExternalPlaybackActive' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayer.ExternalPlaybackActive' instead.")]
		[Export ("setMinimumVolumeSliderImage:forState:")]
		void SetMinimumVolumeSliderImage ([NullAllowed] UIImage image, UIControlState state);

		/// <param name="image">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="state">The control state.</param>
		///         <summary>Performs the set maximum volume slider image operation.</summary>
		[Export ("setMaximumVolumeSliderImage:forState:")]
		void SetMaximumVolumeSliderImage ([NullAllowed] UIImage image, UIControlState state);

		/// <param name="image">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="state">The control state.</param>
		///         <summary>Performs the set volume thumb image operation.</summary>
		[Export ("setVolumeThumbImage:forState:")]
		void SetVolumeThumbImage ([NullAllowed] UIImage image, UIControlState state);

		/// <param name="state">The control state.</param>
		///         <summary>Performs the get minimum volume slider image operation.</summary>
		///         <returns>The result of the operation.</returns>
		[return: NullAllowed]
		[Export ("minimumVolumeSliderImageForState:")]
		UIImage GetMinimumVolumeSliderImage (UIControlState state);

		/// <param name="state">The control state.</param>
		///         <summary>Performs the get maximum volume slider image operation.</summary>
		///         <returns>The result of the operation.</returns>
		[return: NullAllowed]
		[Export ("maximumVolumeSliderImageForState:")]
		UIImage GetMaximumVolumeSliderImage (UIControlState state);

		/// <param name="state">The control state.</param>
		///         <summary>Performs the get volume thumb image operation.</summary>
		///         <returns>The result of the operation.</returns>
		[return: NullAllowed]
		[Export ("volumeThumbImageForState:")]
		UIImage GetVolumeThumbImage (UIControlState state);

		/// <param name="bounds">The bounds rectangle.</param>
		///         <summary>Performs the get volume slider rect operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("volumeSliderRectForBounds:")]
		CGRect GetVolumeSliderRect (CGRect bounds);

		/// <param name="bounds">The bounds rectangle.</param>
		///         <param name="columeSliderRect">The volume slider rectangle.</param>
		///         <param name="value">The value.</param>
		///         <summary>Performs the get volume thumb rect operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("volumeThumbRectForBounds:volumeSliderRect:value:")]
		CGRect GetVolumeThumbRect (CGRect bounds, CGRect columeSliderRect, float /* float, not CGFloat */ value);

		/// <param name="image">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="state">The control state.</param>
		///         <summary>Performs the set route button image operation.</summary>
		[Deprecated (PlatformName.iOS, 13, 0, message: "Use 'AVRoutePickerView.RoutePickerButtonStyle' instead.")]
		[Deprecated (PlatformName.TvOS, 13, 0, message: "Use 'AVRoutePickerView.RoutePickerButtonStyle' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVRoutePickerView.RoutePickerButtonStyle' instead.")]
		[Export ("setRouteButtonImage:forState:")]
		void SetRouteButtonImage ([NullAllowed] UIImage image, UIControlState state);

		/// <param name="state">The control state.</param>
		///         <summary>Performs the get route button image operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Deprecated (PlatformName.iOS, 13, 0, message: "See 'AVRoutePickerView' for possible replacements.")]
		[Deprecated (PlatformName.TvOS, 13, 0, message: "See 'AVRoutePickerView' for possible replacements.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "See 'AVRoutePickerView' for possible replacements.")]
		[return: NullAllowed]
		[Export ("routeButtonImageForState:")]
		UIImage GetRouteButtonImage (UIControlState state);

		/// <param name="bounds">The bounds rectangle.</param>
		///         <summary>Performs the get route button rect operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Deprecated (PlatformName.iOS, 13, 0, message: "See 'AVRoutePickerView' for possible replacements.")]
		[Deprecated (PlatformName.TvOS, 13, 0, message: "See 'AVRoutePickerView' for possible replacements.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "See 'AVRoutePickerView' for possible replacements.")]
		[Export ("routeButtonRectForBounds:")]
		CGRect GetRouteButtonRect (CGRect bounds);

		/// <summary>Gets the AreWirelessRoutesAvailable value.</summary>
		[Deprecated (PlatformName.iOS, 13, 0, message: "Use 'AVRouteDetector.MultipleRoutesDetected' instead.")]
		[Deprecated (PlatformName.TvOS, 13, 0, message: "Use 'AVRouteDetector.MultipleRoutesDetected' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVRouteDetector.MultipleRoutesDetected' instead.")]
		[Export ("wirelessRoutesAvailable")]
		bool AreWirelessRoutesAvailable { [Bind ("areWirelessRoutesAvailable")] get; }

		/// <summary>Gets the IsWirelessRouteActive value.</summary>
		[Deprecated (PlatformName.iOS, 13, 0, message: "Use 'AVPlayer.ExternalPlaybackActive' instead.")]
		[Deprecated (PlatformName.TvOS, 13, 0, message: "Use 'AVPlayer.ExternalPlaybackActive' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayer.ExternalPlaybackActive' instead.")]
		[Export ("wirelessRouteActive")]
		bool IsWirelessRouteActive { [Bind ("isWirelessRouteActive")] get; }

		/// <summary>Gets or sets the VolumeWarningSliderImage value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Deprecated (PlatformName.iOS, 17, 0)]
		[Deprecated (PlatformName.TvOS, 17, 0)]
		[Deprecated (PlatformName.MacCatalyst, 17, 0)]
		[NullAllowed] // by default this property is null
		[Export ("volumeWarningSliderImage", ArgumentSemantic.Retain)]
		UIImage VolumeWarningSliderImage { get; set; }

		[Deprecated (PlatformName.iOS, 13, 0, message: "Use 'AVRouteDetector.MultipleRoutesDetectedDidChange' instead.")]
		[Deprecated (PlatformName.TvOS, 13, 0, message: "Use 'AVRouteDetector.MultipleRoutesDetectedDidChange' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVRouteDetector.MultipleRoutesDetectedDidChange' instead.")]
		[Notification]
		[Field ("MPVolumeViewWirelessRoutesAvailableDidChangeNotification")]
		NSString WirelessRoutesAvailableDidChangeNotification { get; }

		[Deprecated (PlatformName.iOS, 13, 0, message: "Use 'AVPlayer.ExternalPlaybackActive' KVO instead.")]
		[Deprecated (PlatformName.TvOS, 13, 0, message: "Use 'AVPlayer.ExternalPlaybackActive' KVO instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'AVPlayer.ExternalPlaybackActive' KVO instead.")]
		[Notification]
		[Field ("MPVolumeViewWirelessRouteActiveDidChangeNotification")]
		NSString WirelessRouteActiveDidChangeNotification { get; }
	}

	/// <include file="../docs/api/MediaPlayer/MPMediaQuerySection.xml" path="/Documentation/Docs[@DocId='T:MediaPlayer.MPMediaQuerySection']/*" />
	[NoMac]
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	// Objective-C exception thrown.  Name: NSInvalidArgumentException Reason: MPMediaQuerySection is a read-only object
	[DisableDefaultCtor]
	interface MPMediaQuerySection : NSSecureCoding, NSCopying {
		/// <summary>The location and length, inside the originating <see cref="MediaPlayer.MPMediaQuery" />, of this section.</summary>
		[Export ("range", ArgumentSemantic.Assign)]
		NSRange Range { get; }

		/// <summary>The identifier of this section.</summary>
		[Export ("title", ArgumentSemantic.Copy)]
		string Title { get; }
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	// Objective-C exception thrown.  Name: NSInvalidArgumentException Reason: -init is not supported, use +defaultCenter
	[DisableDefaultCtor]
	interface MPNowPlayingInfoCenter {
		[Export ("nowPlayingInfo", ArgumentSemantic.Copy), NullAllowed, Internal]
		NSDictionary _NowPlayingInfo { get; set; }

		/// <summary>Gets the DefaultCenter value.</summary>
		[Static]
		[Export ("defaultCenter")]
		MPNowPlayingInfoCenter DefaultCenter { get; }

		/// <summary>Gets or sets the PlaybackState value.</summary>
		[NoiOS]
		[NoTV]
		[NoMacCatalyst]
		[Export ("playbackState")]
		MPNowPlayingPlaybackState PlaybackState { get; set; }

		[MacCatalyst (26, 0), TV (26, 0), Mac (26, 0), iOS (26, 0)]
		[Static]
		[Export ("supportedAnimatedArtworkKeys")]
		string [] SupportedAnimatedArtworkKeys { get; }

		[Internal]
		[Field ("MPNowPlayingInfoPropertyElapsedPlaybackTime")]
		NSString PropertyElapsedPlaybackTime { get; }

		[Internal]
		[Field ("MPNowPlayingInfoPropertyPlaybackRate")]
		NSString PropertyPlaybackRate { get; }

		[Internal]
		[Field ("MPNowPlayingInfoPropertyPlaybackQueueIndex")]
		NSString PropertyPlaybackQueueIndex { get; }

		[Internal]
		[Field ("MPNowPlayingInfoPropertyPlaybackQueueCount")]
		NSString PropertyPlaybackQueueCount { get; }

		[Internal]
		[Field ("MPNowPlayingInfoPropertyChapterNumber")]
		NSString PropertyChapterNumber { get; }

		[Internal]
		[Field ("MPNowPlayingInfoPropertyChapterCount")]
		NSString PropertyChapterCount { get; }

		[MacCatalyst (13, 1)]
		[Internal]
		[Field ("MPNowPlayingInfoPropertyDefaultPlaybackRate")]
		NSString PropertyDefaultPlaybackRate { get; }

		[MacCatalyst (13, 1)]
		[Internal]
		[Field ("MPNowPlayingInfoPropertyAvailableLanguageOptions")]
		NSString PropertyAvailableLanguageOptions { get; }

		[MacCatalyst (13, 1)]
		[Internal]
		[Field ("MPNowPlayingInfoPropertyCurrentLanguageOptions")]
		NSString PropertyCurrentLanguageOptions { get; }

		/// <summary>Gets the PropertyCollectionIdentifier key constant.</summary>
		[MacCatalyst (13, 1)]
		[Field ("MPNowPlayingInfoCollectionIdentifier")]
		NSString PropertyCollectionIdentifier { get; }

		/// <summary>Gets the PropertyExternalContentIdentifier key constant.</summary>
		[MacCatalyst (13, 1)]
		[Field ("MPNowPlayingInfoPropertyExternalContentIdentifier")]
		NSString PropertyExternalContentIdentifier { get; }

		/// <summary>Gets the PropertyExternalUserProfileIdentifier key constant.</summary>
		[MacCatalyst (13, 1)]
		[Field ("MPNowPlayingInfoPropertyExternalUserProfileIdentifier")]
		NSString PropertyExternalUserProfileIdentifier { get; }

		/// <summary>Gets the identifier for the property that specifies the service provider for the currently playing item.</summary>
		[MacCatalyst (13, 1)]
		[Field ("MPNowPlayingInfoPropertyServiceIdentifier")]
		NSString PropertyServiceIdentifier { get; }

		/// <summary>Gets the PropertyPlaybackProgress key constant.</summary>
		[MacCatalyst (13, 1)]
		[Field ("MPNowPlayingInfoPropertyPlaybackProgress")]
		NSString PropertyPlaybackProgress { get; }

		/// <summary>Gets the PropertyMediaType key constant.</summary>
		[MacCatalyst (13, 1)]
		[Field ("MPNowPlayingInfoPropertyMediaType")]
		NSString PropertyMediaType { get; }

		/// <summary>Gets the PropertyIsLiveStream key constant.</summary>
		[MacCatalyst (13, 1)]
		[Field ("MPNowPlayingInfoPropertyIsLiveStream")]
		NSString PropertyIsLiveStream { get; }

		/// <summary>Represents the value that is associated with the MPNowPlayingInfoPropertyAssetURL constant.</summary>
		[MacCatalyst (13, 1)]
		[Field ("MPNowPlayingInfoPropertyAssetURL")]
		NSString PropertyAssetUrl { get; }

		[MacCatalyst (13, 1)]
		[Internal]
		[Field ("MPNowPlayingInfoPropertyCurrentPlaybackDate")]
		NSString PropertyCurrentPlaybackDate { get; }

		[TV (16, 0), Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0)]
		[Field ("MPNowPlayingInfoPropertyAdTimeRanges")]
		NSString PropertyAdTimeRanges { get; }

		[TV (16, 0), Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0)]
		[Field ("MPNowPlayingInfoPropertyCreditsStartTime")]
		NSString PropertyCreditsStartTime { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("MPNowPlayingInfoPropertyInternationalStandardRecordingCode")]
		NSString PropertyInternationalStandardRecordingCode { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("MPNowPlayingInfoPropertyExcludeFromSuggestions")]
		NSString PropertyExcludeFromSuggestions { get; }

		[MacCatalyst (26, 0), TV (26, 0), Mac (26, 0), iOS (26, 0)]
		[Field ("MPNowPlayingInfoProperty1x1AnimatedArtwork")]
		NSString Property1x1AnimatedArtwork { get; }

		[MacCatalyst (26, 0), TV (26, 0), Mac (26, 0), iOS (26, 0)]
		[Field ("MPNowPlayingInfoProperty3x4AnimatedArtwork")]
		NSString Property3x4AnimatedArtwork { get; }
	}

	/// <summary>User-meaningful information about an <see cref="MediaPlayer.MPMediaItem" />.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPContentItem_Ref/index.html">Apple documentation for <c>MPContentItem</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // crash if used
	interface MPContentItem {

		/// <param name="identifier">The identifier.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[DesignatedInitializer]
		[Export ("initWithIdentifier:")]
		NativeHandle Constructor (string identifier);

		/// <summary>Gets or sets the Artwork value.</summary>
		[NullAllowed]
		[Export ("artwork")]
		MPMediaItemArtwork Artwork { get; set; }

		/// <summary>Gets the Identifier value.</summary>
		[Export ("identifier")]
		string Identifier { get; }

		/// <summary>Gets or sets the PlaybackProgress value.</summary>
		[Export ("playbackProgress")]
		float PlaybackProgress { get; set; } // float, not CGFloat

		/// <summary>Gets or sets the Subtitle value.</summary>
		[NullAllowed]
		[Export ("subtitle")]
		string Subtitle { get; set; }

		/// <summary>Gets or sets the Title value.</summary>
		[NullAllowed]
		[Export ("title")]
		string Title { get; set; }

		/// <summary>Gets or sets the StreamingContent value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("streamingContent")]
		bool StreamingContent { [Bind ("isStreamingContent")] get; set; }

		/// <summary>Gets or sets the ExplicitContent value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("explicitContent")]
		bool ExplicitContent { [Bind ("isExplicitContent")] get; set; }

		/// <summary>Gets or sets the Container value.</summary>
		[Export ("container")]
		bool Container { [Bind ("isContainer")] get; set; }

		/// <summary>Gets or sets the Playable value.</summary>
		[Export ("playable")]
		bool Playable { [Bind ("isPlayable")] get; set; }
	}

	/// <summary>Provides media metadata information to external mediAPlayers.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPPlayableContentDataSource_Ref/index.html">Apple documentation for <c>MPPlayableContentDataSource</c></related>
	[NoMac]
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface MPPlayableContentDataSource {

		[Abstract]
		[Export ("contentItemAtIndexPath:")]
		[return: NullAllowed]
		MPContentItem GetContentItem (NSIndexPath indexPath);

		/// <param name="indexPath">The index path.</param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Performs the begin loading child items operation.</summary>
		[Export ("beginLoadingChildItemsAtIndexPath:completionHandler:")]
		void BeginLoadingChildItems (NSIndexPath indexPath, Action<NSError> completionHandler);

		/// <param name="indexPath">The index path.</param>
		///         <summary>Performs the child items display playback progress operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("childItemsDisplayPlaybackProgressAtIndexPath:")]
		bool ChildItemsDisplayPlaybackProgress (NSIndexPath indexPath);

		/// <param name="indexPath">The index path.</param>
		///         <summary>Performs the number of child items operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Abstract]
		[Export ("numberOfChildItemsAtIndexPath:")]
		nint NumberOfChildItems (NSIndexPath indexPath);

		/// <param name="identifier">The identifier.</param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Performs the operation.</summary>
		[NoMac]
		[Deprecated (PlatformName.iOS, 14, 0, message: "Use 'CarPlay' API instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 14, 0, message: "Use 'CarPlay' API instead.")]
		[Async (XmlDocs = """
			<param name="identifier">The identifier.</param>
			<summary>Performs the operation.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous GetContentItem operation.  The value of the TResult parameter is of type System.Action&lt;MediaPlayer.MPContentItem,Foundation.NSError&gt;.</para>
			        </returns>
			<remarks>
			          <para copied="true">The GetContentItemAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		[Export ("contentItemForIdentifier:completionHandler:")]
		void GetContentItem (string identifier, Action<MPContentItem, NSError> completionHandler);
	}

	interface IMPPlayableContentDataSource {
	}

	interface IMPPlayableContentDelegate { }

	/// <summary>Delegate object providing methods for external mediAPlayers to send playback commands to the app.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPPlayableContentDelegate_Ref/index.html">Apple documentation for <c>MPPlayableContentDelegate</c></related>
	[NoMac]
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface MPPlayableContentDelegate {

		/// <param name="contentManager">The content manager.</param>
		///         <param name="indexPath">The index path.</param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Method that is called to request item playback.</summary>
		[Deprecated (PlatformName.iOS, 14, 0, message: "Use 'CarPlay' API instead.")]
		[Deprecated (PlatformName.MacCatalyst, 14, 0, message: "Use 'CarPlay' API instead.")]
		[Export ("playableContentManager:initiatePlaybackOfContentItemAtIndexPath:completionHandler:")]
		void InitiatePlaybackOfContentItem (MPPlayableContentManager contentManager, NSIndexPath indexPath, Action<NSError> completionHandler);

		/// <param name="contentManager">The content manager.</param>
		///         <param name="context">The context.</param>
		///         <summary>Method that is called after the context changes.</summary>
		[Deprecated (PlatformName.iOS, 14, 0, message: "Use 'CarPlay' API instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 14, 0, message: "Use 'CarPlay' API instead.")]
		[Export ("playableContentManager:didUpdateContext:")]
		void ContextUpdated (MPPlayableContentManager contentManager, MPPlayableContentManagerContext context);

		/// <param name="contentManager">The content manager.</param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Developers should not use this deprecated method. Developers should use 'InitializePlaybackQueue (MPPlayableContentManager, MPContentItem[], Action&lt;NSError&gt;)' instead.</summary>
		[Deprecated (PlatformName.iOS, 9, 3, message: "Use 'InitializePlaybackQueue (MPPlayableContentManager, MPContentItem[], Action<NSError>)' instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'InitializePlaybackQueue (MPPlayableContentManager, MPContentItem[], Action<NSError>)' instead.")]
		[Export ("playableContentManager:initializePlaybackQueueWithCompletionHandler:")]
		void InitializePlaybackQueue (MPPlayableContentManager contentManager, Action<NSError> completionHandler);

		/// <param name="contentManager">The content manager.</param>
		///         <param name="contentItems">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Performs the initialize playback queue operation.</summary>
		[Deprecated (PlatformName.iOS, 12, 0, message: "Use the Intents framework API instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use the Intents framework API instead.")]
		[Export ("playableContentManager:initializePlaybackQueueWithContentItems:completionHandler:")]
		void InitializePlaybackQueue (MPPlayableContentManager contentManager, [NullAllowed] MPContentItem [] contentItems, Action<NSError> completionHandler);
	}

	/// <summary>Controls interactions between the app and external mediAPlayers.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPPlayableContentManager_Ref/index.html">Apple documentation for <c>MPPlayableContentManager</c></related>
	[NoMac]
	[NoTV]
	[Deprecated (PlatformName.iOS, 14, 0, message: "Use 'CarPlay' API instead.")]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 14, 0, message: "Use 'CarPlay' API instead.")]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // NSInvalidArgumentException Reason: -init is invalid. Use +sharedManager. <- [sic]
	interface MPPlayableContentManager {

		/// <summary>Gets the shared data source instance.</summary>
		[Static]
		[Export ("sharedContentManager")]
		MPPlayableContentManager Shared { get; }

		/// <summary>Gets or sets a weak reference to the application data source.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("dataSource", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDataSource { get; set; }

		/// <summary>Gets or sets the application data source.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Wrap ("WeakDataSource")]
		IMPPlayableContentDataSource DataSource { get; set; }

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>An instance of the MediaPlayer.IMPPlayableContentDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the MediaPlayer.IMPPlayableContentDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		IMPPlayableContentDelegate Delegate { get; set; }

		/// <summary>Begins simultanewously updating multiple Media Player content items.</summary>
		[Export ("beginUpdates")]
		void BeginUpdates ();

		/// <summary>Ends updates.</summary>
		[Export ("endUpdates")]
		void EndUpdates ();

		/// <summary>Reloads the source data.</summary>
		[Export ("reloadData")]
		void ReloadData ();

		/// <summary>Gets the Context value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("context")]
		MPPlayableContentManagerContext Context { get; }

		/// <summary>Gets or sets the NowPlayingIdentifiers value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("nowPlayingIdentifiers", ArgumentSemantic.Copy)]
		string [] NowPlayingIdentifiers { get; set; }
	}

	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/MediaPlayer/MPPlayableContentManagerContext">Apple documentation for <c>MPPlayableContentManagerContext</c></related>
	[NoMac]
	[NoTV]
	[Deprecated (PlatformName.iOS, 14, 0, message: "Use 'CarPlay' API instead.")]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 14, 0, message: "Use 'CarPlay' API instead.")]
	[BaseType (typeof (NSObject))]
	interface MPPlayableContentManagerContext {
		/// <summary>Gets the EnforcedContentItemsCount value.</summary>
		[Export ("enforcedContentItemsCount")]
		nint EnforcedContentItemsCount { get; }

		/// <summary>Gets the EnforcedContentTreeDepth value.</summary>
		[Export ("enforcedContentTreeDepth")]
		nint EnforcedContentTreeDepth { get; }

		// iOS 9 beta 2 changed this from contentLimitsEnabled - but the final iOS8.4 release used contentLimitsEnabled
		/// <summary>Gets the ContentLimitsEnforced value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("contentLimitsEnforced")]
		bool ContentLimitsEnforced { get; }

		/// <summary>Developers should not use this deprecated property. Replaced by 'ContentLimitsEnforced'.</summary>
		[Deprecated (PlatformName.iOS, 9, 0, message: "Replaced by 'ContentLimitsEnforced'.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Replaced by 'ContentLimitsEnforced'.")]
		[Export ("contentLimitsEnabled")]
		bool ContentLimitsEnabled { get; }

		/// <summary>Gets the EndpointAvailable value.</summary>
		[Export ("endpointAvailable")]
		bool EndpointAvailable { get; }
	}

	/// <summary>Class that app developers can use to add and remove actions (commands) on targets (players).</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPRemoteCommand_Ref/index.html">Apple documentation for <c>MPRemoteCommand</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // NSGenericException Reason: MPRemoteCommands cannot be initialized externally.
	interface MPRemoteCommand {

		/// <summary>Gets or sets the Enabled value.</summary>
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		/// <param name="target">The target object.</param>
		///         <param name="action">The action selector.</param>
		///         <summary>Performs the add target operation.</summary>
		[Export ("addTarget:action:")]
		void AddTarget (NSObject target, Selector action);

		/// <param name="handler">The completion handler.</param>
		///         <summary>Performs the add target operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("addTargetWithHandler:")]
		NSObject AddTarget (Func<MPRemoteCommandEvent, MPRemoteCommandHandlerStatus> handler);

		/// <param name="target">The target object.</param>
		///         <summary>Performs the remove target operation.</summary>
		[Export ("removeTarget:")]
		void RemoveTarget ([NullAllowed] NSObject target);

		/// <param name="target">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="action">The action selector.</param>
		///         <summary>Performs the remove target operation.</summary>
		[Export ("removeTarget:action:")]
		void RemoveTarget ([NullAllowed] NSObject target, [NullAllowed] Selector action);
	}

	/// <summary>A <see cref="MediaPlayer.MPRemoteCommand" /> that alters the playback rate.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPChangePlaybackRateCommand_Ref/index.html">Apple documentation for <c>MPChangePlaybackRateCommand</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPRemoteCommand))]
	[DisableDefaultCtor] // NSGenericException Reason: MPChangePlaybackRateCommands cannot be initialized externally.
	interface MPChangePlaybackRateCommand {

		/// <summary>Gets or sets the SupportedPlaybackRates value.</summary>
		[Export ("supportedPlaybackRates")]
		NSNumber [] SupportedPlaybackRates { get; set; }
	}

	/// <summary>Holds the current <see cref="MediaPlayer.MPShuffleType" />.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/MediaPlayer/MPChangeShuffleModeCommand">Apple documentation for <c>MPChangeShuffleModeCommand</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPRemoteCommand))]
	[DisableDefaultCtor] // NSGenericException Reason: MPChangeShuffleModeCommand cannot be initialized externally.
	interface MPChangeShuffleModeCommand {
		/// <summary>Gets or sets the CurrentShuffleType value.</summary>
		[Export ("currentShuffleType", ArgumentSemantic.Assign)]
		MPShuffleType CurrentShuffleType { get; set; }
	}

	/// <summary>Holds the current <see cref="MediaPlayer.MPRepeatType" />.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/MediaPlayer/MPChangeRepeatModeCommand">Apple documentation for <c>MPChangeRepeatModeCommand</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPRemoteCommand))]
	[DisableDefaultCtor] // NSGenericException Reason: MPChangeRepeatModeCommand cannot be initialized externally.
	interface MPChangeRepeatModeCommand {
		/// <summary>Gets or sets the CurrentRepeatType value.</summary>
		[Export ("currentRepeatType", ArgumentSemantic.Assign)]
		MPRepeatType CurrentRepeatType { get; set; }
	}

	/// <summary>Additional information for feedback commands defined in <see cref="MediaPlayer.MPRemoteCommandCenter" />.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPFeedbackCommand/index.html">Apple documentation for <c>MPFeedbackCommand</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPRemoteCommand))]
	[DisableDefaultCtor] // NSGenericException Reason: MPFeedbackCommands cannot be initialized externally.
	interface MPFeedbackCommand {

		/// <summary>Gets or sets the Active value.</summary>
		[Export ("active")]
		bool Active { [Bind ("isActive")] get; set; }

		/// <summary>Gets or sets the LocalizedTitle value.</summary>
		[Export ("localizedTitle")]
		string LocalizedTitle { get; set; }

		/// <summary>Gets or sets the LocalizedShortTitle value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("localizedShortTitle")]
		string LocalizedShortTitle { get; set; }
	}

	/// <summary>Additional information for rating commands defined in <see cref="MediaPlayer.MPRemoteCommandCenter" />.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPRatingCommand_Ref/index.html">Apple documentation for <c>MPRatingCommand</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPRemoteCommand))]
	[DisableDefaultCtor] // NSGenericException Reason: MPRatingCommands cannot be initialized externally.
	interface MPRatingCommand {

		/// <summary>Gets or sets the MaximumRating value.</summary>
		[Export ("maximumRating")]
		float MaximumRating { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the MinimumRating value.</summary>
		[Export ("minimumRating")]
		float MinimumRating { get; set; } /* float, not CGFloat */
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPRemoteCommand))]
	[DisableDefaultCtor] // NSGenericException Reason: MPSkipIntervalCommands cannot be initialized externally.
	interface MPSkipIntervalCommand {

		[Internal] // -> we can't do double[] for an NSArray of NSTimeInterval
		[Export ("preferredIntervals")]
		NSArray _PreferredIntervals { get; set; }
	}

	/// <summary>Class that handles events from external mediAPlayers.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPRemoteCommandCenter_Ref/index.html">Apple documentation for <c>MPRemoteCommandCenter</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MPRemoteCommandCenter {

		/// <summary>Gets the shared command center object.</summary>
		[Static]
		[Export ("sharedCommandCenter")]
		MPRemoteCommandCenter Shared { get; }

		/// <summary>Gets the bookmarking command.</summary>
		[Export ("bookmarkCommand")]
		MPFeedbackCommand BookmarkCommand { get; }

		/// <summary>Gets the command that is used to change the playback rate.</summary>
		[Export ("changePlaybackRateCommand")]
		MPChangePlaybackRateCommand ChangePlaybackRateCommand { get; }

		/// <summary>Gets the command that is used to change the repeat mode.</summary>
		[MacCatalyst (13, 1)]
		[Export ("changeRepeatModeCommand")]
		MPChangeRepeatModeCommand ChangeRepeatModeCommand { get; }

		/// <summary>Gets the command that is used to change the shuffle mode.</summary>
		[MacCatalyst (13, 1)]
		[Export ("changeShuffleModeCommand")]
		MPChangeShuffleModeCommand ChangeShuffleModeCommand { get; }

		/// <summary>Gets the command that is used to dislike the currently playing item.</summary>
		[Export ("dislikeCommand")]
		MPFeedbackCommand DislikeCommand { get; }

		/// <summary>Gets the command that is used to like the currently playing item.</summary>
		[Export ("likeCommand")]
		MPFeedbackCommand LikeCommand { get; }

		/// <summary>Gets the command that is used to play the next track.</summary>
		[Export ("nextTrackCommand")]
		MPRemoteCommand NextTrackCommand { get; }

		/// <summary>Gets the command that is used to pause playback.</summary>
		[Export ("pauseCommand")]
		MPRemoteCommand PauseCommand { get; }

		/// <summary>Gets the command that is used to begin or resume playback.</summary>
		[Export ("playCommand")]
		MPRemoteCommand PlayCommand { get; }

		/// <summary>Gets the command that is used to play the previous track.</summary>
		[Export ("previousTrackCommand")]
		MPRemoteCommand PreviousTrackCommand { get; }

		/// <summary>Gets the command that is used to rate the currently playing item.</summary>
		[Export ("ratingCommand")]
		MPRatingCommand RatingCommand { get; }

		/// <summary>Gets the command that is used to seek backward.</summary>
		[Export ("seekBackwardCommand")]
		MPRemoteCommand SeekBackwardCommand { get; }

		/// <summary>Gets the command that is used to seek forward.</summary>
		[Export ("seekForwardCommand")]
		MPRemoteCommand SeekForwardCommand { get; }

		/// <summary>Gets the command that is used to skip backward.</summary>
		[Export ("skipBackwardCommand")]
		MPSkipIntervalCommand SkipBackwardCommand { get; }

		/// <summary>Gets the command that is used to skip forward.</summary>
		[Export ("skipForwardCommand")]
		MPSkipIntervalCommand SkipForwardCommand { get; }

		/// <summary>Gets the command that is used to stop playback.</summary>
		[Export ("stopCommand")]
		MPRemoteCommand StopCommand { get; }

		/// <summary>Gets the command that is used to toggle the paused/playing state.</summary>
		[Export ("togglePlayPauseCommand")]
		MPRemoteCommand TogglePlayPauseCommand { get; }

		/// <summary>Gets the command that is used to enable language options.</summary>
		[MacCatalyst (13, 1)]
		[Export ("enableLanguageOptionCommand")]
		MPRemoteCommand EnableLanguageOptionCommand { get; }

		/// <summary>Gets the command that is used to disable language options.</summary>
		[MacCatalyst (13, 1)]
		[Export ("disableLanguageOptionCommand")]
		MPRemoteCommand DisableLanguageOptionCommand { get; }

		/// <summary>Gets the command that is used to change the playback position.</summary>
		[MacCatalyst (13, 1)]
		[Export ("changePlaybackPositionCommand")]
		MPChangePlaybackPositionCommand ChangePlaybackPositionCommand { get; }
	}

	/// <summary>Class that provides information about APlayer command.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPRemoteCommandEvent_Ref/index.html">Apple documentation for <c>MPRemoteCommandEvent</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // NSGenericException Reason: MPRemoteCommandEvents cannot be initialized externally.
	interface MPRemoteCommandEvent {

		/// <summary>Gets the Command value.</summary>
		[Export ("command")]
		MPRemoteCommand Command { get; }

		/// <summary>Gets the Timestamp value.</summary>
		[Export ("timestamp")]
		double /* NSTimeInterval */ Timestamp { get; }
	}

	/// <summary>Provides the playback rate for a media item.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPChangePlaybackRateCommandEvent_Ref/index.html">Apple documentation for <c>MPChangePlaybackRateCommandEvent</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPRemoteCommandEvent))]
	[DisableDefaultCtor] // NSGenericException Reason: MPChangePlaybackRateCommandEvents cannot be initialized externally.
	interface MPChangePlaybackRateCommandEvent {

		/// <summary>Gets the PlaybackRate value.</summary>
		[Export ("playbackRate")]
		float PlaybackRate { get; } // float, not CGFloat
	}

	/// <summary>Additional information for the rating properties defined in <see cref="MediaPlayer.MPRemoteCommandCenter" />.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPRatingCommandEvent_Ref/index.html">Apple documentation for <c>MPRatingCommandEvent</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPRemoteCommandEvent))]
	[DisableDefaultCtor] // NSGenericException Reason: MPRatingCommandEvents cannot be initialized externally.
	interface MPRatingCommandEvent {

		/// <summary>Gets the Rating value.</summary>
		[Export ("rating")]
		float Rating { get; } // float, not CGFloat
	}

	/// <summary>Additional information for the seek properties defined in <see cref="MediaPlayer.MPRemoteCommandCenter" />.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPSeekCommandEvent_Ref/index.html">Apple documentation for <c>MPSeekCommandEvent</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPRemoteCommandEvent))]
	[DisableDefaultCtor] // Name: NSGenericException Reason: MPSeekCommandEvents cannot be initialized externally.
	interface MPSeekCommandEvent {

		/// <summary>Gets the Type value.</summary>
		[Export ("type")]
		MPSeekCommandEventType Type { get; }
	}

	/// <summary>The time interval rate of an external mediAPlayer.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPSkipIntervalCommandEvent_Ref/index.html">Apple documentation for <c>MPSkipIntervalCommandEvent</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPRemoteCommandEvent))]
	[DisableDefaultCtor] // NSGenericException Reason: MPSkipIntervalCommandEvents cannot be initialized externally.
	interface MPSkipIntervalCommandEvent {

		/// <summary>Gets the Interval value.</summary>
		[Export ("interval")]
		double /* NSTimeInterval */ Interval { get; }
	}

	/// <summary>Additional information for the feedback properties defined in <see cref="MediaPlayer.MPRemoteCommandCenter" />.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPFeedbackCommandEvent_Ref/index.html">Apple documentation for <c>MPFeedbackCommandEvent</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPRemoteCommandEvent))]
	[DisableDefaultCtor]
	interface MPFeedbackCommandEvent {

		/// <summary>Gets the Negative value.</summary>
		[Export ("negative")]
		bool Negative { [Bind ("isNegative")] get; }
	}

	/// <summary>Performs the m p change language option command event operation.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/MediaPlayer/MPChangeLanguageOptionCommandEvent">Apple documentation for <c>MPChangeLanguageOptionCommandEvent</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPRemoteCommandEvent))]
	[DisableDefaultCtor] // NSGenericException Reason: MPChangeLanguageOptionCommandEvents cannot be initialized externally.
	interface MPChangeLanguageOptionCommandEvent {
		/// <summary>Gets the LanguageOption value.</summary>
		[Export ("languageOption")]
		MPNowPlayingInfoLanguageOption LanguageOption { get; }

		/// <summary>Gets the Setting value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("setting")]
		MPChangeLanguageOptionSetting Setting { get; }
	}

	/// <summary>Associates a <see cref="MediaPlayer.MPShuffleType" /> and a boolean specifying whether the shuffle mode should be preserved.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/MediaPlayer/MPChangeShuffleModeCommandEvent">Apple documentation for <c>MPChangeShuffleModeCommandEvent</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPRemoteCommandEvent))]
	[DisableDefaultCtor] // NSGenericException Reason: MPChangeShuffleModeCommandEvent cannot be initialized externally.
	interface MPChangeShuffleModeCommandEvent {
		/// <summary>Gets the ShuffleType value.</summary>
		[Export ("shuffleType")]
		MPShuffleType ShuffleType { get; }

		/// <summary>Gets the PreservesShuffleMode value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("preservesShuffleMode")]
		bool PreservesShuffleMode { get; }
	}

	/// <summary>Associates a <see cref="MediaPlayer.MPRepeatType" /> and a boolean specifying whether the repeat mode should be preserved.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/MediaPlayer/MPChangeRepeatModeCommandEvent">Apple documentation for <c>MPChangeRepeatModeCommandEvent</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPRemoteCommandEvent))]
	[DisableDefaultCtor] // NSGenericException Reason: MPChangeRepeatModeCommandEvent cannot be initialized externally.
	interface MPChangeRepeatModeCommandEvent {
		/// <summary>Gets the RepeatType value.</summary>
		[Export ("repeatType")]
		MPRepeatType RepeatType { get; }

		/// <summary>Gets the PreservesRepeatMode value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("preservesRepeatMode")]
		bool PreservesRepeatMode { get; }
	}

	/// <summary>Performs the m p now playing info language option operation.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/MediaPlayer/MPNowPlayingInfoLanguageOption">Apple documentation for <c>MPNowPlayingInfoLanguageOption</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // pre-emptive
	interface MPNowPlayingInfoLanguageOption {
		/// <param name="languageOptionType">The language option type.</param>
		/// <param name="languageTag">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="languageOptionCharacteristics">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="displayName">The display name.</param>
		/// <param name="identifier">The identifier.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithType:languageTag:characteristics:displayName:identifier:")]
		NativeHandle Constructor (MPNowPlayingInfoLanguageOptionType languageOptionType, string languageTag, [NullAllowed] NSString [] languageOptionCharacteristics, string displayName, string identifier);

		/// <summary>Gets the LanguageOptionType value.</summary>
		[Export ("languageOptionType")]
		MPNowPlayingInfoLanguageOptionType LanguageOptionType { get; }

		/// <summary>Gets the LanguageTag value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("languageTag")]
		string LanguageTag { get; }

		/// <summary>Gets the LanguageOptionCharacteristics value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("languageOptionCharacteristics")]
		NSString [] LanguageOptionCharacteristics { get; }

		/// <summary>Gets the DisplayName value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("displayName")]
		string DisplayName { get; }

		/// <summary>Gets the Identifier value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("identifier")]
		string Identifier { get; }

		/// <summary>Gets the IsAutomaticLegibleLanguageOption value.</summary>
		[Export ("isAutomaticLegibleLanguageOption")]
		bool IsAutomaticLegibleLanguageOption { get; }

		/// <summary>Gets the IsAutomaticAudibleLanguageOption value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("isAutomaticAudibleLanguageOption")]
		bool IsAutomaticAudibleLanguageOption { get; }
	}

	/// <summary>Performs the m p now playing info language option group operation.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/MediaPlayer/MPNowPlayingInfoLanguageOptionGroup">Apple documentation for <c>MPNowPlayingInfoLanguageOptionGroup</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // pre-emptive
	interface MPNowPlayingInfoLanguageOptionGroup {
		/// <param name="languageOptions">The language options.</param>
		/// <param name="defaultLanguageOption">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="allowEmptySelection">Whether to allow empty selection.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithLanguageOptions:defaultLanguageOption:allowEmptySelection:")]
		NativeHandle Constructor (MPNowPlayingInfoLanguageOption [] languageOptions, [NullAllowed] MPNowPlayingInfoLanguageOption defaultLanguageOption, bool allowEmptySelection);

		/// <summary>Gets the LanguageOptions value.</summary>
		[Export ("languageOptions")]
		MPNowPlayingInfoLanguageOption [] LanguageOptions { get; }

		/// <summary>Gets the DefaultLanguageOption value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("defaultLanguageOption")]
		MPNowPlayingInfoLanguageOption DefaultLanguageOption { get; }

		/// <summary>Gets the AllowEmptySelection value.</summary>
		[Export ("allowEmptySelection")]
		bool AllowEmptySelection { get; }
	}

	[MacCatalyst (13, 1)]
	[Static]
	// not [Internal] since they are exposed as an NSString[] property in MPNowPlayingInfoLanguageOption
	interface MPLanguageOptionCharacteristics {
		/// <summary>Gets the IsMainProgramContent key constant.</summary>
		[Field ("MPLanguageOptionCharacteristicIsMainProgramContent")]
		NSString IsMainProgramContent { get; }

		/// <summary>Gets the IsAuxiliaryContent key constant.</summary>
		[Field ("MPLanguageOptionCharacteristicIsAuxiliaryContent")]
		NSString IsAuxiliaryContent { get; }

		/// <summary>Gets the ContainsOnlyForcedSubtitles key constant.</summary>
		[Field ("MPLanguageOptionCharacteristicContainsOnlyForcedSubtitles")]
		NSString ContainsOnlyForcedSubtitles { get; }

		/// <summary>Gets the TranscribesSpokenDialog key constant.</summary>
		[Field ("MPLanguageOptionCharacteristicTranscribesSpokenDialog")]
		NSString TranscribesSpokenDialog { get; }

		/// <summary>Gets the DescribesMusicAndSound key constant.</summary>
		[Field ("MPLanguageOptionCharacteristicDescribesMusicAndSound")]
		NSString DescribesMusicAndSound { get; }

		/// <summary>Gets the EasyToRead key constant.</summary>
		[Field ("MPLanguageOptionCharacteristicEasyToRead")]
		NSString EasyToRead { get; }

		/// <summary>Gets the DescribesVideo key constant.</summary>
		[Field ("MPLanguageOptionCharacteristicDescribesVideo")]
		NSString DescribesVideo { get; }

		/// <summary>Gets the LanguageTranslation key constant.</summary>
		[Field ("MPLanguageOptionCharacteristicLanguageTranslation")]
		NSString LanguageTranslation { get; }

		/// <summary>Gets the DubbedTranslation key constant.</summary>
		[Field ("MPLanguageOptionCharacteristicDubbedTranslation")]
		NSString DubbedTranslation { get; }

		/// <summary>Gets the VoiceOverTranslation key constant.</summary>
		[Field ("MPLanguageOptionCharacteristicVoiceOverTranslation")]
		NSString VoiceOverTranslation { get; }
	}

	/// <summary>Performs the m p change playback position command operation.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/MediaPlayer/MPChangePlaybackPositionCommand">Apple documentation for <c>MPChangePlaybackPositionCommand</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPRemoteCommand))]
	[DisableDefaultCtor] // Objective-C exception thrown.  Name: NSGenericException Reason: MPChangePlaybackPositionCommands cannot be initialized externally.
	interface MPChangePlaybackPositionCommand {
	}

	/// <summary>Performs the m p change playback position command event operation.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/MediaPlayer/MPChangePlaybackPositionCommandEvent">Apple documentation for <c>MPChangePlaybackPositionCommandEvent</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPRemoteCommandEvent))]
	[DisableDefaultCtor] // Objective-C exception thrown.  Name: NSGenericException Reason: MPChangePlaybackPositionCommandEvents cannot be initialized externally.
	interface MPChangePlaybackPositionCommandEvent {
		/// <summary>Gets the PositionTime value.</summary>
		[Export ("positionTime")]
		double PositionTime { get; }
	}

	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/MediaPlayer/MPMediaPlaylistCreationMetadata">Apple documentation for <c>MPMediaPlaylistCreationMetadata</c></related>
	[NoMac]
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MPMediaPlaylistCreationMetadata {
		/// <param name="name">The name.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithName:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string name);

		/// <summary>Gets the Name value.</summary>
		[Export ("name")]
		string Name { get; }

		/// <summary>Gets or sets the AuthorDisplayName value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // null_resettable
		[Export ("authorDisplayName")]
		string AuthorDisplayName { get; set; }

		/// <summary>Gets or sets the DescriptionText value.</summary>
		[Export ("descriptionText")]
		string DescriptionText { get; set; }
	}

	/// <summary>Base class for descriptors for store and audio item queues.</summary>
	[NoMac]
	[TV (14, 0)]
	[MacCatalyst (13, 1)]
	[DisableDefaultCtor]
	[BaseType (typeof (NSObject))]
	interface MPMusicPlayerQueueDescriptor : NSSecureCoding {

		/// <summary>Default constructor, initializes a new instance of this class.</summary>
		/// <remarks />
		[Export ("init")]
		[Deprecated (PlatformName.iOS, 11, 3)]
		[Deprecated (PlatformName.TvOS, 11, 3)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		NativeHandle Constructor ();
	}

	/// <summary>Operates on mediAPlayer queues.</summary>
	[NoMac]
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPMusicPlayerQueueDescriptor))]
	interface MPMusicPlayerMediaItemQueueDescriptor {
		/// <param name="query">The media query.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithQuery:")]
		NativeHandle Constructor (MPMediaQuery query);

		/// <param name="itemCollection">The media item collection.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithItemCollection:")]
		NativeHandle Constructor (MPMediaItemCollection itemCollection);

		/// <summary>Gets a query that returns the items that were used to create this media item queue descriptor.</summary>
		[Export ("query", ArgumentSemantic.Copy)]
		MPMediaQuery Query { get; }

		/// <summary>Gets the collection of media items that was used to create this media item queue descriptor.</summary>
		[Export ("itemCollection", ArgumentSemantic.Strong)]
		MPMediaItemCollection ItemCollection { get; }

		/// <summary>Gets or sets which item will be played first.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("startItem", ArgumentSemantic.Strong)]
		MPMediaItem StartItem { get; set; }

		/// <param name="startTime">The time at which the media will start playing.</param>
		///         <param name="mediaItem">The media item to modify.</param>
		///         <summary>Sets the time that the media item will start playing.</summary>
		[Export ("setStartTime:forItem:")]
		void SetStartTime (double startTime, MPMediaItem mediaItem);

		/// <param name="endTime">The time at which the media will stop playing.</param>
		///         <param name="mediaItem">The media item to modify.</param>
		///         <summary>Sets the time that the media item will stop playing.</summary>
		[Export ("setEndTime:forItem:")]
		void SetEndTime (double endTime, MPMediaItem mediaItem);
	}

	/// <summary>Implements modification of media items in APlayer queue, selecting them by their store identifier.s</summary>
	[NoMac]
	[TV (14, 0)]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPMusicPlayerQueueDescriptor))]
	interface MPMusicPlayerStoreQueueDescriptor {
		/// <param name="storeIDs">The store identifiers.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithStoreIDs:")]
		NativeHandle Constructor (string [] storeIDs);

		/// <summary>Gets or sets the store identifiers for the items in the queue descriptor.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("storeIDs", ArgumentSemantic.Copy)]
		string [] StoreIDs { get; set; }

		/// <summary>Gets the ID of the start item.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("startItemID")]
		string StartItemID { get; set; }

		/// <param name="startTime">The time at which the item will start playing.</param>
		///         <param name="storeID">The store ID of the item to start.</param>
		///         <summary>Sets the time that the media item will start playing.</summary>
		[Export ("setStartTime:forItemWithStoreID:")]
		void SetStartTime (double startTime, string storeID);

		/// <param name="endTime">The time at which the item will stop playing.</param>
		///         <param name="storeID">The store ID of the item to stop.</param>
		///         <summary>Sets the time that the media item will stop playing.</summary>
		[Export ("setEndTime:forItemWithStoreID:")]
		void SetEndTime (double endTime, string storeID);
	}

	/// <summary>An immutable queue of media items for playing..</summary>
	[NoMac]
	[TV (14, 0)]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MPMusicPlayerControllerQueue {
		/// <summary>Gets the array of media items that are contained in the queue.</summary>
		[Export ("items", ArgumentSemantic.Copy)]
		MPMediaItem [] Items { get; }

		[Field ("MPMusicPlayerControllerQueueDidChangeNotification")]
		[Notification]
		NSString DidChangeNotification { get; }
	}

	/// <summary>A mutable queue of media items for playing.</summary>
	[NoMac]
	[TV (14, 0)]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPMusicPlayerControllerQueue))]
	interface MPMusicPlayerControllerMutableQueue {
		/// <param name="queueDescriptor">The queue descriptor with the items to insert.</param>
		///         <param name="item">The item after which to insert the queued items. May be <see langword="null" />.<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param>
		///         <summary>Inserts the queue that is identified by <paramref name="queueDescriptor" /> after <paramref name="item" />.</summary>
		[Export ("insertQueueDescriptor:afterItem:")]
		void InsertAfter (MPMusicPlayerQueueDescriptor queueDescriptor, [NullAllowed] MPMediaItem item);

		/// <param name="item">The item to remove.</param>
		///         <summary>Removes the specified <paramref name="item" /> from the queue.</summary>
		[Export ("removeItem:")]
		void RemoveItem (MPMediaItem item);
	}

	/// <summary>An application controller for changing the currently playing queue.</summary>
	[NoMac]
	[TV (14, 0)]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPMusicPlayerController))]
	interface MPMusicPlayerApplicationController {
		/// <param name="queueTransaction">The action to perform while the queue is created.</param>
		///         <param name="completionHandler">A handler to run when the operation completes.</param>
		///         <summary>Performs the requested queue transformation and runs a handler when the operation is complete.</summary>
		[Async (XmlDocs = """
			<param name="queueTransaction">The action to perform while the queue is created.</param>
			<summary>Performs the requested queue transformation and runs a handler when the operation is complete.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous Perform operation.  The value of the TResult parameter is of type System.Action&lt;MediaPlayer.MPMusicPlayerControllerQueue,Foundation.NSError&gt;.</para>
			        </returns>
			<remarks>
			          <para copied="true">The PerformAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		[Export ("performQueueTransaction:completionHandler:")]
		void Perform (Action<MPMusicPlayerControllerMutableQueue> queueTransaction, Action<MPMusicPlayerControllerQueue, NSError> completionHandler);
	}

	/// <summary>Contains a dictionary of Music Kit parameters for items to play.</summary>
	[NoMac]
	[TV (14, 0)]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MPMusicPlayerPlayParameters : NSSecureCoding {
		/// <param name="dictionary">The dictionary.</param>
		/// <summary>Creates a new music player play parameters object with the provided dictionary of parameters.</summary>
		[Export ("initWithDictionary:")]
		NativeHandle Constructor (NSDictionary dictionary);

		/// <summary>Gets the dictionary of parameters.</summary>
		[Export ("dictionary", ArgumentSemantic.Copy)]
		NSDictionary Dictionary { get; }
	}

	/// <summary>Class for manipulating start times and play order based on the play parameter results of MusicKit APIs.</summary>
	[NoMac]
	[TV (14, 0)]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MPMusicPlayerQueueDescriptor))]
	[DisableDefaultCtor]
	interface MPMusicPlayerPlayParametersQueueDescriptor {
		/// <param name="playParametersQueue">The play parameters queue.</param>
		/// <summary>Creates a new queue descriptor from the specified queue.</summary>
		[Export ("initWithPlayParametersQueue:")]
		NativeHandle Constructor (MPMusicPlayerPlayParameters [] playParametersQueue);

		/// <summary>Gets or sets the play parameters queue</summary>
		[Export ("playParametersQueue", ArgumentSemantic.Copy)]
		MPMusicPlayerPlayParameters [] PlayParametersQueue { get; set; }

		/// <summary>Gets or sets the the play parameters that identify the item that will be played first.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("startItemPlayParameters", ArgumentSemantic.Strong)]
		MPMusicPlayerPlayParameters StartItemPlayParameters { get; set; }

		/// <param name="startTime">The time at which the described item will start playing.</param>
		///         <param name="playParameters">The parameters that describe the item.</param>
		///         <summary>Sets the start time for the item that is described by the provided play parameters.</summary>
		[Export ("setStartTime:forItemWithPlayParameters:")]
		void SetStartTime (/* NSTimeInterval */ double startTime, MPMusicPlayerPlayParameters playParameters);

		/// <param name="endTime">The time at which the described item will stop playing.</param>
		///         <param name="playParameters">The parameters that describe the item.</param>
		///         <summary>Sets the end time for the item that is described by the provided play parameters.</summary>
		[Export ("setEndTime:forItemWithPlayParameters:")]
		void SetEndTime (/* NSTimeInterval */ double endTime, MPMusicPlayerPlayParameters playParameters);
	}

	interface IMPSystemMusicPlayerController { }

	/// <summary>Protocol for playing videos with the Music app.</summary>
	[NoTV]
	[NoMac] // headers have no availability macros on the protocol itself but the only member is not available on macOS
	[MacCatalyst (13, 1)]
	[Protocol]
	interface MPSystemMusicPlayerController {
		/// <param name="queueDescriptor">The queue descriptor for the media items to play.</param>
		/// <summary>Opens the Music app and plays the specified items.</summary>
		[MacCatalyst (13, 1)]
		[Abstract]
		[Export ("openToPlayQueueDescriptor:")]
		void OpenToPlay (MPMusicPlayerQueueDescriptor queueDescriptor);
	}

	[Category]
	[BaseType (typeof (NSUserActivity))]
	[NoMac]
	[MacCatalyst (13, 1)]
	interface NSUserActivity_MediaPlayerAdditions {
		/// <summary>Performs the get external media content identifier operation.</summary>
		/// <returns>The result of the operation.</returns>
		[return: NullAllowed]
		[Export ("externalMediaContentIdentifier")]
		NSString GetExternalMediaContentIdentifier ();

		/// <param name="identifier">The identifier.</param>
		/// <summary>Performs the set external media content identifier operation.</summary>
		[Export ("setExternalMediaContentIdentifier:")]
		void SetExternalMediaContentIdentifier ([NullAllowed] NSString identifier);
	}

	[MacCatalyst (13, 1)]
	[Category]
	[BaseType (typeof (AVMediaSelectionOption))]
	interface AVMediaSelectionOption_MPNowPlayingInfoLanguageOptionAdditions {
		/// <summary>Performs the create now playing info language option operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("makeNowPlayingInfoLanguageOption")]
		[return: NullAllowed]
		MPNowPlayingInfoLanguageOption CreateNowPlayingInfoLanguageOption ();
	}

	[MacCatalyst (13, 1)]
	[Category]
	[BaseType (typeof (AVMediaSelectionGroup))]
	interface AVMediaSelectionGroup_MPNowPlayingInfoLanguageOptionAdditions {
		/// <summary>Performs the create now playing info language option group operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("makeNowPlayingInfoLanguageOptionGroup")]
		MPNowPlayingInfoLanguageOptionGroup CreateNowPlayingInfoLanguageOptionGroup ();
	}

	interface IMPNowPlayingSessionDelegate { }

	[TV (14, 0), iOS (16, 0)]
	[NoMac, MacCatalyst (18, 4)]
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface MPNowPlayingSessionDelegate {

		[Export ("nowPlayingSessionDidChangeActive:")]
		void DidChangeActive (MPNowPlayingSession nowPlayingSession);

		[Export ("nowPlayingSessionDidChangeCanBecomeActive:")]
		void DidChangeCanBecomeActive (MPNowPlayingSession nowPlayingSession);
	}

	[TV (14, 0), iOS (16, 0)]
	[NoMac, MacCatalyst (18, 4)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MPNowPlayingSession {

		[Export ("initWithPlayers:")]
		NativeHandle Constructor (AVPlayer [] players);

		[Export ("players", ArgumentSemantic.Strong)]
		AVPlayer [] Players { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		IMPNowPlayingSessionDelegate Delegate { get; set; }

		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		[Export ("nowPlayingInfoCenter", ArgumentSemantic.Strong)]
		MPNowPlayingInfoCenter NowPlayingInfoCenter { get; }

		[Export ("remoteCommandCenter", ArgumentSemantic.Strong)]
		MPRemoteCommandCenter RemoteCommandCenter { get; }

		[Export ("canBecomeActive")]
		bool CanBecomeActive { get; }

		[Export ("active")]
		bool Active { [Bind ("isActive")] get; }

		[Async]
		[Export ("becomeActiveIfPossibleWithCompletion:")]
		void BecomeActiveIfPossible ([NullAllowed] Action<bool> completion);

		[Export ("addPlayer:")]
		void AddPlayer (AVPlayer player);

		[Export ("removePlayer:")]
		void RemovePlayer (AVPlayer player);

		[TV (16, 0), MacCatalyst (18, 4), NoMac]
		[Export ("automaticallyPublishesNowPlayingInfo")]
		bool AutomaticallyPublishesNowPlayingInfo { get; set; }
	}

	[TV (16, 0), MacCatalyst (18, 4), NoMac, iOS (16, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MPAdTimeRange : NSCopying {
		[Export ("timeRange", ArgumentSemantic.Assign)]
		CMTimeRange TimeRange { get; set; }

		[Export ("initWithTimeRange:")]
		NativeHandle Constructor (CMTimeRange timeRange);
	}

	[MacCatalyst (26, 0), TV (26, 0), Mac (26, 0), iOS (26, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MPMediaItemAnimatedArtwork {
		[Export ("initWithArtworkID:previewImageRequestHandler:videoAssetFileURLRequestHandler:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string artworkId, MPMediaItemAnimatedArtworkPreviewImageRequestHandler previewImageRequestHandler, MPMediaItemAnimatedArtworkVideoAssetFileUrlRequestHandler videoAssetFileUrlRequestHandler);
	}

	delegate void MPMediaItemAnimatedArtworkPreviewImageRequestCallback ([NullAllowed] UIImage image);
	delegate void MPMediaItemAnimatedArtworkPreviewImageRequestHandler (CGSize size, [BlockCallback] MPMediaItemAnimatedArtworkPreviewImageRequestCallback completionHandler);

	delegate void MPMediaItemAnimatedArtworkVideoAssetFileUrlRequestCallback ([NullAllowed] NSUrl image);
	delegate void MPMediaItemAnimatedArtworkVideoAssetFileUrlRequestHandler (CGSize size, [BlockCallback] MPMediaItemAnimatedArtworkVideoAssetFileUrlRequestCallback completionHandler);
}
