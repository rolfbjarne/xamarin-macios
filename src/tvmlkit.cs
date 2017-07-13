// Copyright 2015 Xamarin Inc.

using System;
using XamCore.Foundation;
using XamCore.JavaScriptCore;
using XamCore.ObjCRuntime;
using XamCore.UIKit;

namespace XamCore.TVMLKit {

	[TV (9,0)]
	[Native]
	public enum TVColorType : nint {
		None,
		Plain,
		LinearGradientTopToBottom,
		LinearGradientLeftToRight
	}

	[TV (9,0)]
	[Native]
	public enum TVElementAlignment : nint {
		Undefined,
		Left,
		Center,
		Right
	}

	[TV (9,0)]
	[Native]
	public enum TVElementContentAlignment : nint {
		Undefined,
		Top,
		Center,
		Bottom
	}

	[TV (9,0)]
	[Native]
	public enum TVElementPosition : nint {
		Undefined,
		Center,
		Top,
		Bottom,
		Left,
		Right,
		TopLeft,
		TopRight,
		BottomLeft,
		BottomRight,
		Header,
		Footer
	}

	[TV (9,0)]
	[Native]
	public enum TVElementEventType : nint {
		Play = 1,
		Select,
		HoldSelect,
		Highlight,
		Change
	}

	[TV (9,0)]
	[Native]
	public enum TVElementUpdateType : nint {
		None,
		Subtree,
		Children,
		Self,
		[TV (10,0)]
		Styles,
	}

	[TV (9,0)]
	[Native]
	public enum TVElementResettableProperty : nint {
		UpdateType,
		AutoHighlightIdentifier
	}

	[TV (9,0)]
	[Native]
	public enum TVImageType : nint {
		Image,
		Fullscreen,
		Decoration,
		Hero
	}

	[TV (9,0)]
	[Native]
	[ErrorDomain ("TVMLKitErrorDomain")]
	public enum TVMLKitError : nint {
		Unknown = 1,
		InternetUnavailable,
		FailedToLaunch,
		Last
	}

	[TV (9,0)]
	[Native]
	public enum TVViewElementStyleType : nint {
		Integer = 1,
		Double,
		Point,
		String,
		Color,
		Url,
		Transform,
		EdgeInsets
	}

	[TV (9,0)]
	[Native]
	public enum TVTextElementStyle : nint {
		None,
		Title,
		Subtitle,
		Description,
		Decoration
	}

	[TV (9,0)]
	[BaseType (typeof (NSObject))]
	interface TVApplicationControllerContext : NSCopying {
		[Export ("javaScriptApplicationURL", ArgumentSemantic.Copy)]
		NSUrl JavaScriptApplicationUrl { get; set; }

		[NullAllowed, Export ("storageIdentifier")]
		string StorageIdentifier { get; set; }

		[Export ("launchOptions", ArgumentSemantic.Copy)]
		NSDictionary<NSString,NSObject> LaunchOptions { get; set; }
	}

	[TV (9,0)]
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface TVApplicationControllerDelegate {
		[Export ("appController:evaluateAppJavaScriptInContext:")]
		void EvaluateAppJavaScript (TVApplicationController appController, JSContext jsContext);

		[Export ("appController:didFinishLaunchingWithOptions:")]
		void DidFinishLaunching (TVApplicationController appController, [NullAllowed] NSDictionary<NSString, NSObject> options);

		[Export ("appController:didFailWithError:")]
		void DidFail (TVApplicationController appController, NSError error);

		[Export ("appController:didStopWithOptions:")]
		void DidStop (TVApplicationController appController, [NullAllowed] NSDictionary<NSString, NSObject> options);
	}

	interface ITVApplicationControllerDelegate {}
	
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface TVApplicationController {
		[Export ("initWithContext:window:delegate:")]
		[DesignatedInitializer]
		IntPtr Constructor (TVApplicationControllerContext context, [NullAllowed] UIWindow window, [NullAllowed] ITVApplicationControllerDelegate @delegate);

		[NullAllowed, Export ("window")]
		UIWindow Window { get; }

		[Export ("context")]
		TVApplicationControllerContext Context { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		ITVApplicationControllerDelegate Delegate { get; }

		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; }

		[Export ("navigationController")]
		UINavigationController NavigationController { get; }

		[Export ("evaluateInJavaScriptContext:completion:")]
		[Async]
		void Evaluate (Action<JSContext> evaluation, [NullAllowed] Action<bool> completion);

		[Export ("stop")]
		void Stop ();
	}

	[TV (9,0)]
	[BaseType (typeof(NSObject))]
	interface TVColor : NSCopying {
		[Export ("colorType")]
		TVColorType ColorType { get; }

		[NullAllowed, Export ("color")]
		UIColor Color { get; }

		[NullAllowed, Export ("gradientColors")]
		UIColor[] GradientColors { get; }

		[NullAllowed, Export ("gradientPoints")]
		NSNumber[] GradientPoints { get; }
	}

#if false // TVMLKit/TVElementTypes.h was removed from Xcode 7.1 beta 3 (mistake?)
	[TV (9,0)]
	[Static]
	interface TVAttributeKey {
		// FIXME: does it fit here ?
		[Field ("TVAttributeCanonicalIdentifier")]
		NSString CanonicalIdentifier { get; }

		[Field ("TVAttributeKeyAccessibility")]
		NSString Accessibility { get; }

		[Field ("TVAttributeKeyAllowsZooming")]
		NSString AllowsZooming { get; }

		[Field ("TVAttributeKeyAspectFill")]
		NSString AspectFill { get; }

		[Field ("TVAttributeKeyAutoHighlight")]
		NSString AutoHighlight { get; }

		[Field ("TVAttributeKeyCentered")]
		NSString Centered { get; }

		[Field ("TVAttributeKeyDataMetrics")]
		NSString DataMetrics { get; }

		[Field ("TVAttributeKeyDisabled")]
		NSString Disabled { get; }

		[Field ("TVAttributeKeyFirstItem")]
		NSString FirstItem { get; }

		[Field ("TVAttributeKeyFirstName")]
		NSString FirstName { get; }

		[Field ("TVAttributeKeyFocusEnabled")]
		NSString FocusEnabled { get; }

		[Field ("TVAttributeKeyImg_Height")]
		NSString Img_Height { get; }

		[Field ("TVAttributeKeyImg_Src")]
		NSString Img_Src { get; }

		[Field ("TVAttributeKeyImg_Srcset")]
		NSString Img_Srcset { get; }

		[Field ("TVAttributeKeyImg_Width")]
		NSString Img_Width { get; }

		[Field ("TVAttributeKeyImpressionViewableThreshold")]
		NSString ImpressionViewableThreshold { get; }

		[Field ("TVAttributeKeyIndex")]
		NSString Index { get; }

		[Field ("TVAttributeKeyLastName")]
		NSString LastName { get; }

		[Field ("TVAttributeKeyMinLength")]
		NSString MinLength { get; }

		[Field ("TVAttributeKeyMode")]
		NSString Mode { get; }

		[Field ("TVAttributeKeyShowsScrollIndicator")]
		NSString ShowsScrollIndicator { get; }

		[Field ("TVAttributeKeyTextInput_KeyboardType")]
		NSString TextInput_KeyboardType { get; }

		[Field ("TVAttributeKeyTextInput_Secure")]
		NSString TextInput_Secure { get; }

		[Field ("TVAttributeKeyTheme")]
		NSString Theme { get; }

		[Field ("TVAttributeKeyType")]
		NSString Type { get; }

		[Field ("TVAttributeKeyValue")]
		NSString Value { get; }

		[Field ("TVAttributeMappedIndexPaths")]
		NSString TVAttributeMappedIndexPaths { get; }

		[Field ("TVAttributeNumStars")]
		NSString TVAttributeNumStars { get; }

		[Field ("TVAttributePageControl")]
		NSString TVAttributePageControl { get; }

		[Field ("TVAttributeSearchIdentifier")]
		NSString TVAttributeSearchIdentifier { get; }

		[Field ("TVAttributeSiriData")]
		NSString TVAttributeSiriData { get; }
	}

	[TV (9,0)]
	[Static]
	interface TVElementKey {
		[Field ("TVElementKeyActivityIndicator")]
		NSString ActivityIndicator { get; }

		[Field ("TVElementKeyAsset")]
		NSString Asset { get; }

		[Field ("TVElementKeyAudio")]
		NSString Audio { get; }

		[Field ("TVElementKeyBackground")]
		NSString Background { get; }

		[Field ("TVElementKeyAlertTemplate")]
		NSString AlertTemplate { get; }

		[Field ("TVElementKeyAppInfoCard")]
		NSString AppInfoCard { get; }

		[Field ("TVElementKeyAppProductTemplate")]
		NSString AppProductTemplate { get; }

		[Field ("TVElementKeyBadge")]
		NSString Badge { get; }

		[Field ("TVElementKeyButton")]
		NSString Button { get; }

		[Field ("TVElementKeyButtonLockup")]
		NSString ButtonLockup { get; }

		[Field ("TVElementKeyCard")]
		NSString Card { get; }

		[Field ("TVElementKeyCarousel")]
		NSString Carousel { get; }

		[Field ("TVElementKeyCatalogTemplate")]
		NSString CatalogTemplate { get; }

		[Field ("TVElementKeyCollectionList")]
		NSString CollectionList { get; }

		[Field ("TVElementKeyColumnList")]
		NSString ColumnList { get; }

		[Field ("TVElementKeyCommonSenseTemplate")]
		NSString CommonSenseTemplate { get; }

		[Field ("TVElementKeyCompilationTemplate")]
		NSString CompilationTemplate { get; }

		[Field ("TVElementKeyCuratedPlaylistImg")]
		NSString CuratedPlaylistImg { get; }

		[Field ("TVElementKeyDecorationImage")]
		NSString DecorationImage { get; }

		[Field ("TVElementKeyDecorationLabel")]
		NSString DecorationLabel { get; }

		[Field ("TVElementKeyDescription")]
		NSString Description { get; }

		[Field ("TVElementKeyDescriptiveAlertTemplate")]
		NSString DescriptiveAlertTemplate { get; }

		[Field ("TVElementKeyDialogTemplate")]
		NSString DialogTemplate { get; }

		[Field ("TVElementKeyDivTemplate")]
		NSString DivTemplate { get; }

		[Field ("TVElementKeyDocumentBanner")]
		NSString DocumentBanner { get; }

		[Field ("TVElementKeyFooter")]
		NSString Footer { get; }

		[Field ("TVElementKeyFormTemplate")]
		NSString FormTemplate { get; }

		[Field ("TVElementKeyFullscreenImg")]
		NSString FullscreenImg { get; }

		[Field ("TVElementKeyGalleryTemplate")]
		NSString GalleryTemplate { get; }

		[Field ("TVElementKeyGrid")]
		NSString Grid { get; }

		[Field ("TVElementKeyHead")]
		NSString Head { get; }

		[Field ("TVElementKeyHeader")]
		NSString Header { get; }

		[Field ("TVElementKeyHeroImage")]
		NSString HeroImage { get; }

		[Field ("TVElementKeyIdentityBanner")]
		NSString IdentityBanner { get; }

		[Field ("TVElementKeyImageDeck")]
		NSString ImageDeck { get; }

		[Field ("TVElementKeyImg")]
		NSString Img { get; }

		[Field ("TVElementKeyInfo")]
		NSString Info { get; }

		[Field ("TVElementKeyInfoList")]
		NSString InfoList { get; }

		[Field ("TVElementKeyInfoTable")]
		NSString InfoTable { get; }

		[Field ("TVElementKeyItemBanner")]
		NSString ItemBanner { get; }

		[Field ("TVElementKeyList")]
		NSString List { get; }

		[Field ("TVElementKeyListAltTemplate")]
		NSString ListAltTemplate { get; }

		[Field ("TVElementKeyListItemLockup")]
		NSString ListItemLockup { get; }

		[Field ("TVElementKeyListTemplate")]
		NSString ListTemplate { get; }

		[Field ("TVElementKeyLoadingTemplate")]
		NSString LoadingTemplate { get; }

		[Field ("TVElementKeyLockup")]
		NSString Lockup { get; }

		[Field ("TVElementKeyMainTemplate")]
		NSString MainTemplate { get; }

		[Field ("TVElementKeyMenuBar")]
		NSString MenuBar { get; }

		[Field ("TVElementKeyMenuBarTemplate")]
		NSString MenuBarTemplate { get; }

		[Field ("TVElementKeyMenuItem")]
		NSString MenuItem { get; }

		[Field ("TVElementKeyMonogram")]
		NSString Monogram { get; }

		[Field ("TVElementKeyMonogramLockup")]
		NSString MonogramLockup { get; }

		[Field ("TVElementKeyMusicVideoProductTemplate")]
		NSString MusicVideoProductTemplate { get; }

		[Field ("TVElementKeyOneupTemplate")]
		NSString OneupTemplate { get; }

		[Field ("TVElementKeyOrdinal")]
		NSString Ordinal { get; }

		[Field ("TVElementKeyOverlay")]
		NSString Overlay { get; }

		[Field ("TVElementKeyParadeTemplate")]
		NSString ParadeTemplate { get; }

		[Field ("TVElementKeyPhotoAlbumTemplate")]
		NSString PhotoAlbumTemplate { get; }

		[Field ("TVElementKeyPhotoLibraryTemplate")]
		NSString PhotoLibraryTemplate { get; }

		[Field ("TVElementKeyPlaceholder")]
		NSString Placeholder { get; }

		[Field ("TVElementKeyPlaylistFolderImg")]
		NSString PlaylistFolderImg { get; }

		[Field ("TVElementKeyPlaylistImg")]
		NSString PlaylistImg { get; }

		[Field ("TVElementKeyProductBundleTemplate")]
		NSString ProductBundleTemplate { get; }

		[Field ("TVElementKeyProductInfo")]
		NSString ProductInfo { get; }

		[Field ("TVElementKeyProductTemplate")]
		NSString ProductTemplate { get; }

		[Field ("TVElementKeyProgressBar")]
		NSString ProgressBar { get; }

		[Field ("TVElementKeyRatingBadge")]
		NSString RatingBadge { get; }

		[Field ("TVElementKeyRatingButton")]
		NSString RatingButton { get; }

		[Field ("TVElementKeyRatingCard")]
		NSString RatingCard { get; }

		[Field ("TVElementKeyRatingTemplate")]
		NSString RatingTemplate { get; }

		[Field ("TVElementKeyRelatedContent")]
		NSString TVElementKeyRelatedContent { get; }

		[Field ("TVElementKeyReviewCard")]
		NSString ReviewCard { get; }

		[Field ("TVElementKeyRow")]
		NSString Row { get; }

		[Field ("TVElementKeySearchField")]
		NSString SearchField { get; }

		[Field ("TVElementKeySearchTemplate")]
		NSString SearchTemplate { get; }

		[Field ("TVElementKeySeasonBadge")]
		NSString SeasonBadge { get; }

		[Field ("TVElementKeySection")]
		NSString Section { get; }

		[Field ("TVElementKeySegmentBar")]
		NSString SegmentBar { get; }

		[Field ("TVElementKeySegmentBarHeader")]
		NSString SegmentBarHeader { get; }

		[Field ("TVElementKeySegmentBarItem")]
		NSString SegmentBarItem { get; }

		[Field ("TVElementKeySeparator")]
		NSString Separator { get; }

		[Field ("TVElementKeyShelf")]
		NSString Shelf { get; }

		[Field ("TVElementKeyShowcaseTemplate")]
		NSString ShowcaseTemplate { get; }

		[Field ("TVElementKeySlideshow")]
		NSString Slideshow { get; }

		[Field ("TVElementKeySpriteLockup")]
		NSString SpriteLockup { get; }

		[Field ("TVElementKeyStack")]
		NSString Stack { get; }

		[Field ("TVElementKeyStackTemplate")]
		NSString StackTemplate { get; }

		[Field ("TVElementKeyStarBar")]
		NSString StarBar { get; }

		[Field ("TVElementKeyStarHistogram")]
		NSString StarHistogram { get; }

		[Field ("TVElementKeySubtitle")]
		NSString Subtitle { get; }

		[Field ("TVElementKeyText")]
		NSString Text { get; }

		[Field ("TVElementKeyTextBadge")]
		NSString TextBadge { get; }

		[Field ("TVElementKeyTextField")]
		NSString TextField { get; }

		[Field ("TVElementKeyTitle")]
		NSString Title { get; }

		[Field ("TVElementKeyTumblerBar")]
		NSString TumblerBar { get; }

		[Field ("TVElementKeyTumblerItem")]
		NSString TumblerItem { get; }

		[Field ("TVElementKeyVideo")]
		NSString Video { get; }
	}

	// FIXME: enum'ify ?
	[TV (9,0)]
	[Static]
	interface TVKeyboardType {
		[Field ("TVKeyboardTypeEmailAddress")]
		NSString EmailAddress { get; }

		[Field ("TVKeyboardTypeNumberPad")]
		NSString NumberPad { get; }

		[Field ("TVKeyboardTypeURL")]
		NSString TypeURL { get; }
	}
#endif

	[TV (9,0)]
	[BaseType (typeof (NSObject))]
	interface TVElementFactory {
		// FIXME: provide System.Type overload
		[Static]
		[Export ("registerViewElementClass:forElementName:")]
		void RegisterViewElementClass (Class elementClass, string elementName);
	}

	[TV (9,0)]
	[BaseType (typeof(NSObject))]
	interface TVViewElementStyle : NSCopying {
		// FIXME: badly named, unsure of return value
		[Export ("valueForStyleProperty:")]
		[return: NullAllowed]
		NSObject ValueForStyleProperty (string name);

		[NullAllowed, Export ("backgroundColor")]
		TVColor BackgroundColor { get; }

		[NullAllowed, Export ("color")]
		TVColor Color { get; }

		[Export ("fontSize")]
		nfloat FontSize { get; }

		// FIXME: that's likely an (existing?) set of constants
		[NullAllowed, Export ("fontWeight")]
		NSString FontWeight { get; }

		[Export ("height")]
		nfloat Height { get; }

		[Export ("margin")]
		UIEdgeInsets Margin { get; }

		[TV (10,0)]
		[Export ("focusMargin")]
		UIEdgeInsets FocusMargin { get; }

		[Export ("maxHeight")]
		nfloat MaxHeight { get; }

		[Export ("maxWidth")]
		nfloat MaxWidth { get; }

		[Export ("minHeight")]
		nfloat MinHeight { get; }

		[Export ("minWidth")]
		nfloat MinWidth { get; }

		[Export ("padding")]
		UIEdgeInsets Padding { get; }

		[Export ("textAlignment")]
		UITextAlignment TextAlignment { get; }

		[Export ("width")]
		nfloat Width { get; }

		[Export ("alignment")]
		TVElementAlignment Alignment { get; }

		[Export ("contentAlignment")]
		TVElementContentAlignment ContentAlignment { get; }

		[NullAllowed, Export ("highlightColor")]
		TVColor HighlightColor { get; }

		[NullAllowed, Export ("imageTreatmentName")]
		string ImageTreatmentName { get; }

		[Export ("interitemSpacing")]
		nfloat InteritemSpacing { get; }

		[NullAllowed, Export ("textHighlightStyle")]
		string TextHighlightStyle { get; }

		[Export ("textMinimumScaleFactor")]
		nfloat TextMinimumScaleFactor { get; }

		[Export ("position")]
		TVElementPosition Position { get; }

		[NullAllowed, Export ("ratingStyle")]
		string RatingStyle { get; }

		[Export ("maxTextLines")]
		nuint MaxTextLines { get; }

		[NullAllowed, Export ("textStyle")]
		string TextStyle { get; }

		[NullAllowed, Export ("tintColor")]
		TVColor TintColor { get; }
	}

	[TV (9,0)]
	[BaseType (typeof (NSObject))]
	interface TVViewElement : NSCopying {
		[Export ("elementIdentifier")]
		string ElementIdentifier { get; }

		[Export ("elementName")]
		string ElementName { get; }

		[NullAllowed, Export ("parentViewElement", ArgumentSemantic.Weak)]
		TVViewElement ParentViewElement { get; }

		[NullAllowed, Export ("childViewElements")]
		TVViewElement[] ChildViewElements { get; }

		[NullAllowed, Export ("attributes")]
		NSDictionary<NSString, NSString> Attributes { get; }

		[NullAllowed, Export ("style")]
		TVViewElementStyle Style { get; }

		[NullAllowed, Export ("autoHighlightIdentifier")]
		string AutoHighlightIdentifier { get; }

		[Export ("disabled")]
		bool Disabled {
			[Bind ("isDisabled")] get;
			set;
		}

		[Export ("updateType")]
		TVElementUpdateType UpdateType { get; }

		[Export ("resetProperty:")]
		void Reset (TVElementResettableProperty resettableProperty);

		[Export ("dispatchEventOfType:canBubble:cancellable:extraInfo:completion:")]
		[Async (ResultType = typeof (TVViewElementDispatchResult))]
		void DispatchEvent (TVElementEventType type, bool canBubble, bool isCancellable, [NullAllowed] NSDictionary<NSString, NSObject> extraInfo, [NullAllowed] Action<bool, bool> completion);

		[Export ("dispatchEventWithName:canBubble:cancellable:extraInfo:completion:")]
		[Async (ResultType = typeof (TVViewElementDispatchResult))]
		void DispatchEvent (string eventName, bool canBubble, bool isCancellable, [NullAllowed] NSDictionary<NSString, NSObject> extraInfo, [NullAllowed] Action<bool, bool> completion);
	}

	[TV (9,0)]
	[BaseType (typeof(TVViewElement))]
	interface TVImageElement {
		[NullAllowed, Export ("URL")]
		NSUrl Url { get; }

		[NullAllowed, Export ("srcset")]
		NSDictionary<NSString, NSUrl> SourceSet { get; }

		[Export ("imageType")]
		TVImageType ImageType { get; }
	}

	[TV (9,0)]
	[Protocol]
	interface TVInterfaceCreating {
		[Export ("viewForElement:existingView:")]
		[return: NullAllowed]
		UIView GetViewForElement (TVViewElement element, [NullAllowed] UIView existingView);

		[Export ("viewControllerForElement:existingViewController:")]
		[return: NullAllowed]
		UIViewController GetViewControllerForElement (TVViewElement element, [NullAllowed] UIViewController existingViewController);

		[Export ("URLForResource:")]
		[return: NullAllowed]
		NSUrl GetUrlForResource (string resourceName);

		[TV (9,2)]
		[Export ("imageForResource:")]
		[return: NullAllowed]
		UIImage GetImageForResource (string resourceName);

		[TV (10,0)]
		[Export ("collectionViewCellClassForElement:")]
		[return: NullAllowed]
		Class GetCollectionViewCellClass (TVViewElement element);
	}

	interface ITVInterfaceCreating {}

	[TV (9,0)]
	[BaseType (typeof (NSObject))]
	interface TVInterfaceFactory : TVInterfaceCreating {
		[Static]
		[Export ("sharedInterfaceFactory")]
		TVInterfaceFactory SharedInterfaceFactory { get; }

		[NullAllowed, Export ("extendedInterfaceCreator", ArgumentSemantic.Strong)]
		ITVInterfaceCreating ExtendedInterfaceCreator { get; set; }
	}

	[TV (9,0)]
	[BaseType (typeof (NSObject))]
	interface TVStyleFactory {
		[Static]
		[Export ("registerStyle:withType:inherited:")]
		void RegisterStyle (string styleName, TVViewElementStyleType type, bool inherited);
	}

	[TV (9,0)]
	[BaseType (typeof (TVViewElement))]
	interface TVTextElement {
		[NullAllowed, Export ("attributedText")]
		NSAttributedString AttributedText { get; }

		[Export ("textStyle")]
		TVTextElementStyle TextStyle { get; }

		[Export ("attributedStringWithFont:")]
		NSAttributedString GetAttributedString (UIFont font);

		[Export ("attributedStringWithFont:foregroundColor:textAlignment:")]
		NSAttributedString GetAttributedString (UIFont font, [NullAllowed] UIColor foregroundColor, UITextAlignment alignment);
	}
}
