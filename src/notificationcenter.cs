using System.ComponentModel;
using CoreGraphics;

#if !MONOMAC
using UIKit;
using NSViewController = UIKit.UIViewController;
#else
using AppKit;
using UIEdgeInsets = AppKit.NSEdgeInsets;
using UIVibrancyEffect = Foundation.NSObject;
using UIVibrancyEffectStyle = Foundation.NSObject;
#endif

namespace NotificationCenter {
	/// <summary>Coordinates the display of a widget's content with its containing app.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NotificationCenter/Reference/NCWidgetController_Class/index.html">Apple documentation for <c>NCWidgetController</c></related>
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // not meant to be user created
	[Deprecated (PlatformName.iOS, 14, 0)]
	[Deprecated (PlatformName.MacOSX, 11, 0)]
	interface NCWidgetController {

		/// <summary>Gets the maximum size of the widget for a display mode.</summary>
		/// <returns>The maximum size for the widget.</returns>
		[Static]
		[Export ("widgetController")]
		NCWidgetController GetWidgetController ();

		/// <param name="flag">Whether the widget is enabled.</param>
		/// <param name="bundleID">The bundle identifier of the widget.</param>
		/// <summary>Sets whether a widget extension with the given bundle identifier is enabled.</summary>
		[Export ("setHasContent:forWidgetWithBundleIdentifier:")]
		void SetHasContent (bool flag, string bundleID);
	}

	/// <summary>Customizes the appearance and behavior of a widget.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NotificationCenter/Reference/NCWidgetProviding_Protocol/index.html">Apple documentation for <c>NCWidgetProviding</c></related>
	[Deprecated (PlatformName.iOS, 14, 0)]
	[Deprecated (PlatformName.MacOSX, 11, 0)]
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface NCWidgetProviding {

		/// <param name="completionHandler">The completion handler to call with the new content.</param>
		/// <summary>Called when the system needs updated content for the widget.</summary>
		[Export ("widgetPerformUpdateWithCompletionHandler:")]
		void WidgetPerformUpdate (Action<NCUpdateResult> completionHandler);

		/// <param name="defaultMarginInsets">The default margin insets.</param>
		/// <summary>Returns custom margin insets for the widget content.</summary>
		/// <returns>The custom margin insets to apply.</returns>
		[Export ("widgetMarginInsetsForProposedMarginInsets:"), DelegateName ("NCWidgetProvidingMarginInsets"), DefaultValueFromArgument ("defaultMarginInsets")]
		[Deprecated (PlatformName.iOS, 10, 0)]
		UIEdgeInsets GetWidgetMarginInsets (UIEdgeInsets defaultMarginInsets);

		/// <summary>Gets the active display mode for the widget.</summary>
		[NoiOS]
		[Export ("widgetAllowsEditing")]
		bool WidgetAllowsEditing {
			get;
		}

		/// <summary>Gets the largest available display mode for the widget.</summary>
		[NoiOS]
		[Export ("widgetDidBeginEditing")]
		void WidgetDidBeginEditing ();

		/// <summary>Gets the preferred content size for the widget.</summary>
		[NoiOS]
		[Export ("widgetDidEndEditing")]
		void WidgetDidEndEditing ();

		/// <param name="activeDisplayMode">The new active display mode.</param>
		/// <param name="maxSize">The maximum size for the display mode.</param>
		/// <summary>Called when the active display mode changes.</summary>
		[NoMac]
		[Export ("widgetActiveDisplayModeDidChange:withMaximumSize:")]
		void WidgetActiveDisplayModeDidChange (NCWidgetDisplayMode activeDisplayMode, CGSize maxSize);
	}

	/// <summary>Defines the appropriate vibrancy effect for widgets (extensions) displayed in the Today view.</summary>
	[NoMac]
	[BaseType (typeof (UIVibrancyEffect))]
	[Internal]
	[Category]
	interface UIVibrancyEffect_NotificationCenter {
		[Internal]
		[Deprecated (PlatformName.iOS, 10, 0, message: "Use 'UIVibrancyEffect.GetWidgetEffect' instead.")]
		[Static, Export ("notificationCenterVibrancyEffect")]
		UIVibrancyEffect NotificationCenterVibrancyEffect ();
	}

	/// <summary>Extension context methods and properties for an NDWidget.</summary>
	[NoMac]
	[Deprecated (PlatformName.iOS, 14, 0)]
	[Category]
	[BaseType (typeof (NSExtensionContext))]
	interface NSExtensionContext_NCWidgetAdditions {
		/// <summary>Returns the largest available display mode for the widget.</summary>
		/// <returns>The largest available display mode for the widget.</returns>
		
		[Export ("widgetLargestAvailableDisplayMode")]
		NCWidgetDisplayMode GetWidgetLargestAvailableDisplayMode ();

		/// <param name="mode">The display mode to set.</param>
		/// <summary>Sets the largest available display mode for the widget.</summary>
		
		[Export ("setWidgetLargestAvailableDisplayMode:")]
		void SetWidgetLargestAvailableDisplayMode (NCWidgetDisplayMode mode);

		/// <summary>Returns the current display mode for the widget.</summary>
		/// <returns>The current display mode for the widget.</returns>
		
		[Export ("widgetActiveDisplayMode")]
		NCWidgetDisplayMode GetWidgetActiveDisplayMode ();

		/// <param name="displayMode">The display mode to query.</param>
		/// <summary>Returns the maximum size of the widget for the specified display mode.</summary>
		/// <returns>The maximum size of the widget for the specified display mode.</returns>
		
		[Export ("widgetMaximumSizeForDisplayMode:")]
		CGSize GetWidgetMaximumSize (NCWidgetDisplayMode displayMode);
	}

	[NoMac]
	[Category]
	[Internal] // only static methods, which are not _nice_ to use as extension methods
	[Deprecated (PlatformName.iOS, 14, 0)]
	[BaseType (typeof (UIVibrancyEffect))]
	interface UIVibrancyEffect_NCWidgetAdditions {
		[Deprecated (PlatformName.iOS, 13, 0, message: "Use 'UIVibrancyEffect.GetWidgetEffect' instead.")]
		[Static]
		[Export ("widgetPrimaryVibrancyEffect")]
		UIVibrancyEffect GetWidgetPrimaryVibrancyEffect ();

		[Deprecated (PlatformName.iOS, 13, 0, message: "Use 'UIVibrancyEffect.GetWidgetEffect' instead.")]
		[Static]
		[Export ("widgetSecondaryVibrancyEffect")]
		UIVibrancyEffect GetWidgetSecondaryVibrancyEffect ();

		[iOS (13, 0)]
		[Static]
		[Export ("widgetEffectForVibrancyStyle:")]
		UIVibrancyEffect GetWidgetEffect (UIVibrancyEffectStyle vibrancyStyle);
	}

	[NoiOS]
	[Deprecated (PlatformName.MacOSX, 11, 0)]
	[BaseType (typeof (NSViewController), Delegates = new string [] { "Delegate" }, Events = new Type [] { typeof (NCWidgetListViewDelegate) })]
	interface NCWidgetListViewController {
		/// <param name="nibNameOrNull">The nib name, or <see langword="null" />.</param>
		/// <param name="nibBundleOrNull">The bundle, or <see langword="null" />.</param>
		/// <summary>Creates a new list view controller from the specified nib and bundle.</summary>
		
		[Export ("initWithNibName:bundle:")]
		NativeHandle Constructor ([NullAllowed] string nibNameOrNull, [NullAllowed] NSBundle nibBundleOrNull);

		/// <summary>Gets the notification content.</summary>
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		INCWidgetListViewDelegate Delegate { get; set; }

		/// <summary>Gets the content for the notification at the bottom.</summary>
		[Export ("contents", ArgumentSemantic.Copy)]
		NSViewController [] Contents { get; set; }

		/// <summary>Gets the content for the notification on the leading side.</summary>
		[Export ("minimumVisibleRowCount", ArgumentSemantic.Assign)]
		nuint MinimumVisibleRowCount { get; set; }

		/// <summary>Gets the content for the notification on the trailing side.</summary>
		[Export ("hasDividerLines")]
		bool HasDividerLines { get; set; }

		/// <summary>Gets the layout for the notification actions.</summary>
		[Export ("editing")]
		bool Editing { get; set; }

		/// <summary>Gets whether this list shows the More button.</summary>
		[Export ("showsAddButtonWhenEditing")]
		bool ShowsAddButtonWhenEditing { get; set; }

		/// <param name="row">The row index.</param>
		/// <param name="makeIfNecesary">Whether to create the view if necessary.</param>
		/// <summary>Gets the view at the specified row.</summary>
		/// <returns>The view at the specified row, or <see langword="null" />.</returns>
		
		[Export ("viewControllerAtRow:makeIfNecessary:")]
		NSViewController GetViewController (nuint row, bool makeIfNecesary);

		/// <param name="viewController">The view controller.</param>
		/// <summary>Sets the view controller for this list.</summary>
		/// <returns><see langword="true" /> if the view controller was set successfully; otherwise, <see langword="false" />.</returns>
		[Export ("rowForViewController:")]
		nuint GetRow (NSViewController viewController);
	}

	[NoiOS]
	interface INCWidgetListViewDelegate { }

	[NoiOS]
	[Deprecated (PlatformName.MacOSX, 11, 0)]
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface NCWidgetListViewDelegate {
		/// <param name="list">The list view controller.</param>
		/// <param name="row">The row index.</param>
		/// <summary>Gets the number of notifications at the specified row.</summary>
		/// <returns>The number of notifications.</returns>
		
		[EventArgs ("", XmlDocs = """
			<summary>Gets the number of notifications at the specified row.</summary>
			
			
			""")]
		[Abstract]
		[Export ("widgetList:viewControllerForRow:"), DelegateName ("NCWidgetListViewGetController"), DefaultValue (null)]
		NSViewController GetViewControllerForRow (NCWidgetListViewController list, nuint row);

		/// <param name="list">The list view controller.</param>
		/// <summary>Gets the number of sections in the list.</summary>
		[EventArgs ("", XmlDocs = """
			<summary>Gets the number of sections in the list.</summary>
			
			""")]
		[Export ("widgetListPerformAddAction:"), DelegateName ("NCWidgetListViewController")]
		void PerformAddAction (NCWidgetListViewController list);

		/// <param name="list">The list view controller.</param>
		/// <param name="row">The row index.</param>
		/// <summary>Returns whether to remove a notification at the specified row.</summary>
		/// <returns><see langword="true" /> to remove; otherwise, <see langword="false" />.</returns>
		
		[EventArgs ("", XmlDocs = """
			<summary>Returns whether to remove a notification at the specified row.</summary>
			
			
			""")]
		[Export ("widgetList:shouldReorderRow:"), DelegateName ("NCWidgetListViewControllerShouldReorderRow"), DefaultValue (false)]
		bool ShouldReorderRow (NCWidgetListViewController list, nuint row);

		/// <param name="list">The list view controller.</param>
		/// <param name="row">The row index.</param>
		/// <param name="newIndex">The new index for the notification.</param>
		/// <summary>Called when a notification is moved from one row to another.</summary>
		
		[Export ("widgetList:didReorderRow:toRow:"), EventArgs ("NCWidgetListViewControllerDidReorder", XmlDocs = """
			<summary>Called when a notification is moved from one row to another.</summary>
			
			"""), DefaultValue (false)]
		void DidReorderRow (NCWidgetListViewController list, nuint row, nuint newIndex);

		/// <param name="list">The list view controller.</param>
		/// <param name="row">The row index.</param>
		/// <summary>Determines whether the notification at the specified row should be removed upon user action.</summary>
		/// <returns><see langword="true" /> if the notification should be removed; otherwise, <see langword="false" />.</returns>
		
		[EventArgs ("", XmlDocs = """
			<summary>Determines whether the notification at the specified row should be removed upon user action.</summary>
			
			
			""")]
		[Export ("widgetList:shouldRemoveRow:"), DelegateName ("NCWidgetListViewControllerShouldRemoveRow"), DefaultValue (false)]
		bool ShouldRemoveRow (NCWidgetListViewController list, nuint row);

		/// <param name="list">The list view controller.</param>
		/// <param name="row">The row index.</param>
		/// <summary>Called when a notification at the specified row is tapped.</summary>
		
		[Export ("widgetList:didRemoveRow:"), EventArgs ("NCWidgetListViewControllerDidRemoveRow", XmlDocs = """
			<summary>Called when a notification at the specified row is tapped.</summary>
			
			"""), DefaultValue (false)]
		void DidRemoveRow (NCWidgetListViewController list, nuint row);
	}

	[NoiOS]
	[Deprecated (PlatformName.MacOSX, 11, 0)]
	[BaseType (typeof (NSViewController), Delegates = new string [] { "Delegate" }, Events = new Type [] { typeof (NCWidgetSearchViewDelegate) })]
	interface NCWidgetSearchViewController {
		/// <param name="nibNameOrNull">The nib name, or <see langword="null" />.</param>
		/// <param name="nibBundleOrNull">The bundle, or <see langword="null" />.</param>
		/// <summary>Creates a new service extension from the specified nib and bundle.</summary>
		
		[Export ("initWithNibName:bundle:")]
		NativeHandle Constructor ([NullAllowed] string nibNameOrNull, [NullAllowed] NSBundle nibBundleOrNull);

		/// <summary>Gets the notification request to be modified.</summary>
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		INCWidgetSearchViewDelegate Delegate { get; set; }

		/// <summary>Gets the best attempt notification content.</summary>
		[NullAllowed]
		[Export ("searchResults", ArgumentSemantic.Copy)]
		NSObject [] SearchResults { get; set; }

		/// <summary>Called with the notification request to modify.</summary>
		[NullAllowed]
		[Export ("searchDescription")]
		string SearchDescription { get; set; }

		/// <summary>Called when the time limit for modification expires.</summary>
		[NullAllowed]
		[Export ("searchResultsPlaceholderString")]
		string SearchResultsPlaceholderString { get; set; }

		/// <summary>Called when the notification is dismissed.</summary>
		[NullAllowed]
		[Export ("searchResultKeyPath")]
		string SearchResultKeyPath { get; set; }
	}

	[NoiOS]
	interface INCWidgetSearchViewDelegate { }

	[NoiOS]
	[Deprecated (PlatformName.MacOSX, 11, 0)]
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface NCWidgetSearchViewDelegate {
		/// <param name="controller">The notification content extension.</param>
		/// <param name="searchTerm">The search term.</param>
		/// <param name="max">The maximum number of results.</param>
		/// <summary>Called to get suggestions for the specified search term.</summary>
		
		[Abstract]
		[Export ("widgetSearch:searchForTerm:maxResults:"), EventArgs ("NSWidgetSearchForTerm", XmlDocs = """
			<summary>Called to get suggestions for the specified search term.</summary>
			
			"""), DefaultValue (false)]
		void SearchForTerm (NCWidgetSearchViewController controller, string searchTerm, nuint max);

		/// <param name="controller">The notification content extension.</param>
		/// <summary>Called when the list shows the More button.</summary>
		[Abstract]
		[Export ("widgetSearchTermCleared:"), EventArgs ("NSWidgetSearchViewController", XmlDocs = """
			<summary>Called when the list shows the More button.</summary>
			
			"""), DefaultValue (false)]
		void TermCleared (NCWidgetSearchViewController controller);

		/// <param name="controller">The notification content extension.</param>
		/// <param name="obj">The selected object.</param>
		/// <summary>Called when a notification object is selected.</summary>
		[Abstract]
		[Export ("widgetSearch:resultSelected:"), EventArgs ("NSWidgetSearchResultSelected", XmlDocs = """
			<summary>Called when a notification object is selected.</summary>
			
			"""), DefaultValue (false)]
		void ResultSelected (NCWidgetSearchViewController controller, NSObject obj);
	}
}
