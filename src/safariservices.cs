//
// safariservices.cs: binding for iOS (7+) SafariServices framework
//
// Authors:
//   Aaron Bockover (abock@xamarin.com)
//   Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2013 Xamarin Inc.
// Copyright 2019 Microsoft Corporation
//

#if HAS_BROWSERENGINEKIT
using BrowserEngineKit;
#else
using BEWebAppManifest = Foundation.NSObject;
#endif
#if !MONOMAC
using UIKit;
using NSRunningApplication = System.Object;
using NSImage = UIKit.UIImage;
using NSViewController = UIKit.UIViewController;
#else
using AppKit;
using UIImage = AppKit.NSImage;
using UIEventAttribution = Foundation.NSObject;
using UIColor = AppKit.NSColor;
using UIActivity = Foundation.NSObject;
using UIViewController = AppKit.NSViewController;
#endif

namespace SafariServices {
	delegate void SFExtensionValidationHandler (bool shouldHide, NSString text);

	/// <summary>Represents the enabled state of a content blocker extension.</summary>
	///     <remarks>
	///       <para>This class has one read-only property, <see cref="SafariServices.SFContentBlockerState.Enabled" />, which tells whether or not the associated content blocker extension is enabled.</para>
	///     </remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/reference/SafariServices/SFContentBlockerState">Apple documentation for <c>SFContentBlockerState</c></related>
	[Introduced (PlatformName.MacCatalyst, 13, 4)]
	[BaseType (typeof (NSObject))]
	interface SFContentBlockerState {
		/// <summary>Gets a value that tells whether or not the associated content blocker extension is enabled.</summary>
		///         <value>A value that tells whether or not the associated content blocker extension is enabled.</value>
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; }
	}

	/// <summary>Coordinates with Safari to load extension blocking rules.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/reference/SafariServices/SFContentBlockerManager">Apple documentation for <c>SFContentBlockerManager</c></related>
	[Introduced (PlatformName.MacCatalyst, 13, 4)]
	[DisableDefaultCtor]
	[BaseType (typeof (NSObject))]
	interface SFContentBlockerManager {

#if !XAMCORE_5_0
		/// <summary>Default constructor, initializes a new instance of this class.</summary>
		/// <remarks>
		///         </remarks>
		[Obsolete ("Constructor marked as unavailable.")]
		[Export ("init")]
		NativeHandle Constructor ();
#endif

		/// <param name="identifier">The content blocker identifier.</param>
		///         <param name="completionHandler">
		///   <para>The content blocker identifier to reload.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Reloads the specified content blocker and runs a completion handler when the operation completes.</summary>
		[Async (XmlDocs = """
			<param name="identifier">The content blocker identifier.</param>
			<summary>Relaods the specified content blocker and runs a completion handler when the operation completes.</summary>
			<returns>A task that represents the asynchronous ReloadContentBlocker operation</returns>
			
			""")]
		[Static, Export ("reloadContentBlockerWithIdentifier:completionHandler:")]
		void ReloadContentBlocker (string identifier, [NullAllowed] Action<NSError> completionHandler);

		/// <param name="identifier">The content blocker identifier.</param>
		/// <param name="completionHandler">The completion handler to call when done.</param>
		///         <summary>Passes the state of the specified content blocker to the provided <paramref name="completionHandler" />.</summary>
		[MacCatalyst (13, 4)]
		[Static]
		[Async (XmlDocs = """
			<param name="identifier">The content blocker identifier.</param>
			<summary>Asynchronously gets the state of the specified content blocker.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous GetStateOfContentBlocker operation.  The value of the TResult parameter is of type System.Action&lt;SafariServices.SFContentBlockerState,Foundation.NSError&gt;.</para>
			        </returns>
			<remarks>
			          <para copied="true">The GetStateOfContentBlockerAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          
			        </remarks>
			""")]
		[Export ("getStateOfContentBlockerWithIdentifier:completionHandler:")]
		void GetStateOfContentBlocker (string identifier, Action<SFContentBlockerState, NSError> completionHandler);
	}

	/// <summary>Provides write-access to the Safari Reading List.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/reference/SafariServices/SSReadingList">Apple documentation for <c>SSReadingList</c></related>
	[NoMac]
	[Introduced (PlatformName.MacCatalyst, 13, 4)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // NSGenericException Misuse of SSReadingList interface. Use class method defaultReadingList.
	partial interface SSReadingList {

		/// <summary>Gets or sets the preferred bar tint color.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Static, Export ("defaultReadingList")]
		SSReadingList DefaultReadingList { get; }

		/// <param name="url">
		///   <para>The URL to open.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a Safari view controller for the specified URL.</summary>
		/// <returns>A new Safari view controller.</returns>
		[Static, Export ("supportsURL:")]
		// Apple says it's __nonnull so let's be safe and maintain compatibility with our current behaviour
		[PreSnippet ("if (url is null) return false;", Optimizable = true)]
		bool SupportsUrl ([NullAllowed] NSUrl url);

		/// <param name="url">The URL to open.</param>
		///         <param name="title">
		///   <para>The URL to open.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="previewText">
		///   <para>The error that occurred, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="error">The error that occurred, or <see langword="null" />.</param>
		/// <summary>Creates a Safari view controller for the specified URL with readability preference.</summary>
		/// <returns>A new Safari view controller.</returns>
		[Export ("addReadingListItemWithURL:title:previewText:error:")]
		bool Add (NSUrl url, [NullAllowed] string title, [NullAllowed] string previewText, out NSError error);
	}

	/// <summary>User interface for web browsing.</summary>
	///     
	/// <related type="externalDocumentation" href="https://developer.apple.com/documentation/safariservices/sfsafariviewcontroller">Apple documentation for <c>SFSafariViewController</c></related>
	[NoMac]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (UIViewController))]
	[DisableDefaultCtor] // NSGenericException Reason: Misuse of SFSafariViewController interface. Use initWithURL:entersReaderIfAvailable:
	interface SFSafariViewController {
		/// <param name="nibName">
		///   <para>The URL to open.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="bundle">
		///   <para>The configuration options.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a Safari view controller with the specified URL and configuration.</summary>
		
		[Export ("initWithNibName:bundle:")]
		[PostGet ("NibBundle")]
		NativeHandle Constructor ([NullAllowed] string nibName, [NullAllowed] NSBundle bundle);

		/// <param name="url">The URL to open.</param>
		/// <param name="configuration">The configuration options.</param>
		/// <summary>Creates a new browsing interface with the provided URL and configuration.</summary>
		
		[MacCatalyst (13, 1)]
		[Export ("initWithURL:configuration:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSUrl url, SFSafariViewControllerConfiguration configuration);

		/// <param name="url">The URL to open.</param>
		/// <param name="entersReaderIfAvailable">Whether to enter reader mode if available.</param>
		/// <summary>Developers should not use this deprecated constructor. Developers should use '.ctor (NSUrl, SFSafariViewControllerConfiguration)' instead.</summary>
		
		[Deprecated (PlatformName.iOS, 11, 0, message: "Use '.ctor (NSUrl, SFSafariViewControllerConfiguration)' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use '.ctor (NSUrl, SFSafariViewControllerConfiguration)' instead.")]
		[DesignatedInitializer]
		[Export ("initWithURL:entersReaderIfAvailable:")]
		NativeHandle Constructor (NSUrl url, bool entersReaderIfAvailable);

		/// <param name="url">The URL to open.</param>
		/// <summary>Creates a new browsing interface with the provided URL.</summary>
		
		[Export ("initWithURL:")]
		NativeHandle Constructor (NSUrl url);

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[NullAllowed] // by default this property is null
		[Export ("delegate", ArgumentSemantic.Assign)]
		NSObject WeakDelegate { get; set; }

		/// <summary>An instance of the SafariServices.ISFSafariViewControllerDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the SafariServices.ISFSafariViewControllerDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		ISFSafariViewControllerDelegate Delegate { get; set; }

		[Deprecated (PlatformName.iOS, 26, 0, message: "Interferes with system-provided background effects")]
		[Deprecated (PlatformName.MacCatalyst, 26, 0, message: "Interferes with system-provided background effects")]
		[MacCatalyst (13, 1)]
		[NullAllowed]
		[Export ("preferredBarTintColor", ArgumentSemantic.Assign)]
		UIColor PreferredBarTintColor { get; set; }

		[MacCatalyst (13, 1)]
		[NullAllowed]
		[Deprecated (PlatformName.iOS, 26, 0, message: "Interferes with system-provided background effects")]
		[Deprecated (PlatformName.MacCatalyst, 26, 0, message: "Interferes with system-provided background effects")]
		[Export ("preferredControlTintColor", ArgumentSemantic.Assign)]
		UIColor PreferredControlTintColor { get; set; }

		/// <summary>Gets the configuration that was used when creating this view controller.</summary>
		[MacCatalyst (13, 1)]
		[Export ("configuration", ArgumentSemantic.Copy)]
		SFSafariViewControllerConfiguration Configuration { get; }

		/// <summary>Gets or sets a value that controls the style of the dismiss button.</summary>
		[MacCatalyst (13, 1)]
		[Export ("dismissButtonStyle", ArgumentSemantic.Assign)]
		SFSafariViewControllerDismissButtonStyle DismissButtonStyle { get; set; }

		[iOS (15, 0), MacCatalyst (15, 0)]
		[Static]
		[Export ("prewarmConnectionsToURLs:")]
		SFSafariViewControllerPrewarmingToken PrewarmConnections (NSUrl [] urls);
	}

	interface ISFSafariViewControllerDelegate { }

	/// <summary>Protocol for presenting a user interface for web browsing.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/reference/SafariServices/SFSafariViewControllerDelegate">Apple documentation for <c>SFSafariViewControllerDelegate</c></related>
	[NoMac]
	[MacCatalyst (13, 1)]
	[Model]
	[BaseType (typeof (NSObject))]
	[Protocol]
	partial interface SFSafariViewControllerDelegate {
		/// <param name="controller">The Safari view controller.</param>
		/// <param name="url">The URL being loaded.</param>
		///         <param name="title">
		///   <para>The activity items to add, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Method that is called to retrieve the activity items for the requested action.</summary>
		/// <returns>The activity items, or an empty array.</returns>
		[Export ("safariViewController:activityItemsForURL:title:")]
		UIActivity [] GetActivityItems (SFSafariViewController controller, NSUrl url, [NullAllowed] string title);

		/// <param name="controller">The Safari view controller.</param>
		///         <summary>Method that is called when the user dismisses the view.</summary>
		[Export ("safariViewControllerDidFinish:")]
		void DidFinish (SFSafariViewController controller);

		/// <param name="controller">The Safari view controller.</param>
		/// <param name="didLoadSuccessfully">Whether the page loaded successfully.</param>
		///         <summary>Method that is called after the first URL is loaded.</summary>
		[Export ("safariViewController:didCompleteInitialLoad:")]
		void DidCompleteInitialLoad (SFSafariViewController controller, bool didLoadSuccessfully);

		/// <param name="controller">The Safari view controller.</param>
		/// <param name="url">The initial URL.</param>
		///         <param name="title">
		///   <para>The redirected URL, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Called when the initial URL is redirected.</summary>
		/// <returns>The redirected URL.</returns>
		[MacCatalyst (13, 1)]
		[Export ("safariViewController:excludedActivityTypesForURL:title:")]
		string [] GetExcludedActivityTypes (SFSafariViewController controller, NSUrl url, [NullAllowed] string title);

		/// <param name="controller">The Safari view controller.</param>
		/// <param name="url">The URL of the page.</param>
		/// <summary>Called to get excluded activity types for the specified URL.</summary>
		[MacCatalyst (13, 1)]
		[Export ("safariViewController:initialLoadDidRedirectToURL:")]
		void InitialLoadDidRedirectToUrl (SFSafariViewController controller, NSUrl url);

		[iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("safariViewControllerWillOpenInBrowser:")]
		void WillOpenInBrowser (SFSafariViewController controller);
	}

	/// <summary>Configuration options for Safari view controllers.</summary>
	[NoMac]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface SFSafariViewControllerConfiguration : NSCopying {
		/// <summary>Gets or sets a Boolean value that controls whether the view controller will enter Reader mode if it is available.</summary>
		[Export ("entersReaderIfAvailable")]
		bool EntersReaderIfAvailable { get; set; }

		/// <summary>Gets the web page title.</summary>
		[Export ("barCollapsingEnabled")]
		bool BarCollapsingEnabled { get; set; }

		[NullAllowed]
		[iOS (15, 0), MacCatalyst (15, 0), NoMac, NoTV]
		[Export ("activityButton", ArgumentSemantic.Copy)]
		SFSafariViewControllerActivityButton ActivityButton { get; set; }

		[NullAllowed]
		[NoTV, iOS (15, 2), MacCatalyst (15, 2), NoMac]
		[Export ("eventAttribution", ArgumentSemantic.Copy)]
		UIEventAttribution EventAttribution { get; set; }
	}

	/// <param name="callbackUrl">A custom URL scheme.</param>
	///     <param name="error">The error object if an error occurred.</param>
	///     
	///     <summary>Delegate for handling the result of a user action in a <see cref="SafariServices.SFAuthenticationSession" />.</summary>
	[NoMac]
	[MacCatalyst (13, 1)]
	delegate void SFAuthenticationCompletionHandler ([NullAllowed] NSUrl callbackUrl, [NullAllowed] NSError error);

	/// <summary>A one-time web service login, shared between Safari, an app, and other associated apps.</summary>
	[NoMac]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'ASWebAuthenticationSession' instead.")]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'ASWebAuthenticationSession' instead.")]
	interface SFAuthenticationSession {
		/// <param name="url">The URL to pre-warm.</param>
		/// <param name="callbackUrlScheme">
		///   <para>The URL to pre-warm.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="completionHandler">The completion handler called when the URL is pre-warmed.</param>
		/// <summary>Creates a new authentication session for the resource at the specified URL.</summary>
		
		[Export ("initWithURL:callbackURLScheme:completionHandler:")]
		NativeHandle Constructor (NSUrl url, [NullAllowed] string callbackUrlScheme, SFAuthenticationCompletionHandler completionHandler);

		/// <summary>Starts authentication process, displaying an interface to the user.</summary>
		/// <returns>A pre-warmed connection token.</returns>
		[Export ("start")]
		bool Start ();

		/// <summary>Cancels the authentication session.</summary>
		[Export ("cancel")]
		void Cancel ();
	}

	[NoiOS]
	[NoTV]
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SFSafariApplication {
		/// <param name="completionHandler">The completion handler called with the extension state.</param>
		/// <summary>Gets the current state of the Safari extension.</summary>
		[Static]
		[Async]
		[Export ("getActiveWindowWithCompletionHandler:")]
		void GetActiveWindow (Action<SFSafariWindow> completionHandler);

		[Static]
		[Async]
		[Export ("getAllWindowsWithCompletionHandler:")]
		void GetAllWindows (Action<SFSafariWindow []> completionHandler);

		/// <param name="url">The URL to open.</param>
		/// <param name="completionHandler">The completion handler called when the tab is opened.</param>
		/// <summary>Opens a URL in a new Safari tab.</summary>
		[Static]
		[Async (XmlDocs = """
			<param name="url">The URL to open.</param>
			<summary>Opens a URL in a new Safari tab.</summary>
			<returns>A task representing the asynchronous operation.</returns>
			
			""")]
		[Export ("openWindowWithURL:completionHandler:")]
		void OpenWindow (NSUrl url, [NullAllowed] Action<SFSafariWindow> completionHandler);

		/// <summary>Gets all connected content blocker extensions.</summary>
		[Static]
		[Export ("setToolbarItemsNeedUpdate")]
		void SetToolbarItemsNeedUpdate ();

		/// <param name="identifier">The extension identifier.</param>
		/// <param name="completionHandler">The completion handler called with the content blocker state.</param>
		/// <summary>Gets the state of the specified content blocker extension.</summary>
		[Static]
		[Export ("showPreferencesForExtensionWithIdentifier:completionHandler:")]
		void ShowPreferencesForExtension (string identifier, [NullAllowed] Action<NSError> completionHandler);

		/// <param name="messageName">The name of the message to send.</param>
		/// <param name="identifier">The extension identifier.</param>
		/// <param name="userInfo">The message data to send.</param>
		/// <param name="completionHandler">The completion handler called with the response.</param>
		/// <summary>Sends a message to the specified extension.</summary>
		[Advice ("Unavailable to extensions.")]
		[Static]
		[Async (XmlDocs = """
			<param name="messageName">The name of the message to send.</param>
			<param name="identifier">The extension identifier.</param>
			<param name="userInfo">The message data to send.</param>
			<summary>Sends a message to the specified extension.</summary>
			<returns>A task representing the asynchronous operation.</returns>
			
			""")]
		[Export ("dispatchMessageWithName:toExtensionWithIdentifier:userInfo:completionHandler:")]
		void DispatchMessage (string messageName, string identifier, [NullAllowed] NSDictionary<NSString, NSObject> userInfo, [NullAllowed] Action<NSError> completionHandler);

		/// <param name="completionHandler">The completion handler called with all content blockers.</param>
		/// <summary>Gets all content blocker extensions.</summary>
		[Static]
		[Async]
		[Export ("getHostApplicationWithCompletionHandler:")]
		void GetHostApplication (Action<NSRunningApplication> completionHandler);
	}

	[NoiOS]
	[NoTV]
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SFSafariPage : NSSecureCoding, NSCopying {
		/// <param name="messageName">The name of the message.</param>
		/// <param name="userInfo">The message data.</param>
		/// <summary>Dispatches a message to the extension page.</summary>
		[Export ("dispatchMessageToScriptWithName:userInfo:")]
		void DispatchMessageToScript (string messageName, [NullAllowed] NSDictionary userInfo);

		/// <summary>Gets the containing tab for this page.</summary>
		[Export ("reload")]
		void Reload ();

		/// <param name="completionHandler">The completion handler called with the screenshot image.</param>
		/// <summary>Takes a screenshot of the visible page area.</summary>
		[Async]
		[Export ("getPagePropertiesWithCompletionHandler:")]
		void GetPageProperties (Action<SFSafariPageProperties> completionHandler);

		[Async]
		[Export ("getContainingTabWithCompletionHandler:")]
		void GetContainingTab (Action<SFSafariTab> completionHandler);

		[Async]
		[Export ("getScreenshotOfVisibleAreaWithCompletionHandler:")]
		void GetScreenshotOfVisibleArea (Action<NSImage> completionHandler);
	}

	[NoiOS]
	[NoTV]
	[NoMacCatalyst]
	[Protocol]
	interface SFSafariExtensionHandling {
		/// <param name="messageName">The name of the message.</param>
		/// <param name="page">The page that sent the message.</param>
		/// <param name="userInfo">The message data.</param>
		/// <summary>Called when a message is received from the extension page.</summary>
		
		[Export ("messageReceivedWithName:fromPage:userInfo:")]
		void MessageReceived (string messageName, SFSafariPage page, [NullAllowed] NSDictionary userInfo);

		/// <param name="window">The Safari window.</param>
		/// <summary>Called when the toolbar item is clicked in the specified window.</summary>
		
		[Export ("toolbarItemClickedInWindow:")]
		void ToolbarItemClicked (SFSafariWindow window);

		/// <param name="window">The Safari window.</param>
		/// <param name="validationHandler">The handler to call with the validation result.</param>
		/// <summary>Called to validate the toolbar item for the specified window.</summary>
		
		[Async (ResultTypeName = "SFValidationResult")]
		[Export ("validateToolbarItemInWindow:validationHandler:")]
		void ValidateToolbarItem (SFSafariWindow window, Action<bool, NSString> validationHandler);

		/// <param name="command">The context menu command.</param>
		/// <param name="page">The page where the context menu appeared.</param>
		/// <param name="userInfo">Additional information about the context.</param>
		/// <summary>Called when a context menu command is selected.</summary>
		
		[Export ("contextMenuItemSelectedWithCommand:inPage:userInfo:")]
		void ContextMenuItemSelected (string command, SFSafariPage page, [NullAllowed] NSDictionary userInfo);

		/// <param name="window">The Safari window to provide the popover view controller for.</param>
		/// <summary>Gets the base URI of the extension page.</summary>
		
		[Export ("popoverWillShowInWindow:")]
		void PopoverWillShow (SFSafariWindow window);

		/// <param name="window">The Safari window.</param>
		/// <summary>Gets the active page in the specified window.</summary>
		
		[Export ("popoverDidCloseInWindow:")]
		void PopoverDidClose (SFSafariWindow window);

		/// <summary>Gets the native window containing this extension page.</summary>
		
		
		[Export ("popoverViewController")]
		SFSafariExtensionViewController PopoverViewController { get; }

		/// <param name="command">The command name to validate.</param>
		/// <param name="page">The page where the command was invoked.</param>
		/// <param name="userInfo">Additional information about the command.</param>
		/// <param name="validationHandler">The handler to call with the validation result.</param>
		/// <summary>Validates a command before it is executed.</summary>
		
		[Async (ResultTypeName = "SFExtensionValidationResult")]
		[Export ("validateContextMenuItemWithCommand:inPage:userInfo:validationHandler:")]
		void ValidateContextMenuItem (string command, SFSafariPage page, [NullAllowed] NSDictionary<NSString, NSObject> userInfo, SFExtensionValidationHandler validationHandler);

		/// <param name="messageName">The name of the message.</param>
		/// <param name="userInfo">The message data.</param>
		/// <summary>Called when a message is received from the extension page.</summary>
		
		[Export ("messageReceivedFromContainingAppWithName:userInfo:")]
		void MessageReceivedFromContainingApp (string messageName, [NullAllowed] NSDictionary<NSString, NSObject> userInfo);

		/// <param name="url">The URL to navigate to.</param>
		/// <param name="completionHandler">The completion handler called when navigation completes.</param>
		/// <summary>Navigates the page to the specified URL.</summary>
		
		[Export ("additionalRequestHeadersForURL:completionHandler:")]
		void AdditionalRequestHeaders (NSUrl url, Action<NSDictionary<NSString, NSString>> completionHandler);

		[Export ("contentBlockerWithIdentifier:blockedResourcesWithURLs:onPage:")]
		void ContentBlocker (string contentBlockerIdentifier, NSUrl [] urls, SFSafariPage page);

		[Export ("page:willNavigateToURL:")]
		void WillNavigate (SFSafariPage page, [NullAllowed] NSUrl url);
	}

	[NoiOS]
	[NoTV]
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SFSafariExtension {

		[Static]
		[Async]
		[Export ("getBaseURIWithCompletionHandler:")]
		void GetBaseUri (Action<NSUrl> completionHandler);
	}

	[NoiOS]
	[NoTV]
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface SFSafariPageProperties {
		/// <summary>Gets the properties of the page.</summary>
		[NullAllowed]
		[Export ("url")]
		NSUrl Url { get; }

		/// <summary>Gets the properties of the tab.</summary>
		[NullAllowed]
		[Export ("title")]
		string Title { get; }

		/// <summary>Gets the active tab in the window.</summary>
		[Export ("usesPrivateBrowsing")]
		bool UsesPrivateBrowsing { get; }

		/// <summary>Gets all the visible tabs in the window.</summary>
		[Export ("active")]
		bool Active { [Bind ("isActive")] get; }
	}

	[NoiOS]
	[NoTV]
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SFSafariTab : NSSecureCoding, NSCopying {
		/// <param name="completionHandler">The completion handler called with the active window.</param>
		/// <summary>Gets the active Safari window.</summary>
		[Async]
		[Export ("getActivePageWithCompletionHandler:")]
		void GetActivePage (Action<SFSafariPage> completionHandler);

		/// <param name="completionHandler">The completion handler called with all windows.</param>
		/// <summary>Gets all Safari windows.</summary>
		[Async]
		[Export ("getPagesWithCompletionHandler:")]
		void GetPages (Action<SFSafariPage []> completionHandler);

		[Async]
		[Export ("getContainingWindowWithCompletionHandler:")]
		void GetContainingWindow (Action<SFSafariWindow> completionHandler);

		/// <param name="completionHandler">The completion handler called when the popover is shown.</param>
		/// <summary>Shows the Safari extension popover.</summary>
		[Async]
		[Export ("activateWithCompletionHandler:")]
		void Activate ([NullAllowed] Action completionHandler);

		[Export ("navigateToURL:")]
		void NavigateTo (NSUrl url);

		[Export ("close")]
		void Close ();
	}

	[NoiOS]
	[NoTV]
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SFSafariToolbarItem : NSSecureCoding, NSCopying {
		/// <param name="enabled">Whether the toolbar item is enabled.</param>
		/// <param name="badgeText">The badge text to display, or <see langword="null" />.</param>
		/// <summary>Sets the toolbar item enabled state and badge text.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 13, message: "Use 'SetEnabled (bool)' or 'SetBadgeText' instead.")]
		[Export ("setEnabled:withBadgeText:")]
		void SetEnabled (bool enabled, [NullAllowed] string badgeText);

		/// <param name="enabled">Whether the toolbar item is enabled.</param>
		/// <summary>Sets whether the toolbar item is enabled.</summary>
		[Export ("setEnabled:")]
		void SetEnabled (bool enabled);

		/// <param name="badgeText">The badge text to display, or <see langword="null" />.</param>
		/// <summary>Sets the badge text for the toolbar item.</summary>
		[Export ("setBadgeText:")]
		void SetBadgeText ([NullAllowed] string badgeText);

		/// <param name="image">The image to use for the toolbar item.</param>
		/// <summary>Sets the image for the toolbar item.</summary>
		[Export ("setImage:")]
		void SetImage ([NullAllowed] NSImage image);

		/// <param name="label">The label for the toolbar item.</param>
		/// <summary>Sets the label for the toolbar item.</summary>
		[Export ("setLabel:")]
		void SetLabel ([NullAllowed] string label);

		[Export ("showPopover")]
		void ShowPopover ();
	}

	[NoiOS]
	[NoTV]
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SFSafariWindow : NSSecureCoding, NSCopying {
		/// <param name="completionHandler">The completion handler called with the active page.</param>
		/// <summary>Gets the active page in the containing tab.</summary>
		[Async]
		[Export ("getActiveTabWithCompletionHandler:")]
		void GetActiveTab (Action<SFSafariTab> completionHandler);

		[Async]
		[Export ("getAllTabsWithCompletionHandler:")]
		void GetAllTabs (Action<SFSafariTab []> completionHandler);

		/// <param name="url">The URL to open in the new tab.</param>
		/// <param name="activateTab">Whether to activate the new tab.</param>
		/// <param name="completionHandler">The completion handler called with the new tab.</param>
		/// <summary>Opens a new tab with the specified URL.</summary>
		[Async (XmlDocs = """
			<param name="url">The URL to open in the new tab.</param>
			<param name="activateTab">Whether to activate the new tab.</param>
			<summary>Opens a new tab with the specified URL.</summary>
			<returns>A task representing the asynchronous operation.</returns>
			
			""")]
		[Export ("openTabWithURL:makeActiveIfPossible:completionHandler:")]
		void OpenTab (NSUrl url, bool activateTab, [NullAllowed] Action<SFSafariTab> completionHandler);

		/// <param name="completionHandler">The completion handler called with all pages.</param>
		/// <summary>Gets all pages in the containing tab.</summary>
		[Async]
		[Export ("getToolbarItemWithCompletionHandler:")]
		void GetToolbarItem (Action<SFSafariToolbarItem> completionHandler);

		[Export ("close")]
		void Close ();
	}

	[NoiOS]
	[NoTV]
	[NoMacCatalyst]
	[BaseType (typeof (NSViewController))]
	interface SFSafariExtensionViewController {
		/// <param name="nibNameOrNull">The nib name, or <see langword="null" />.</param>
		/// <param name="nibBundleOrNull">The bundle, or <see langword="null" />.</param>
		/// <summary>Creates the view controller from the specified nib and bundle.</summary>
		
		[Export ("initWithNibName:bundle:")]
		NativeHandle Constructor ([NullAllowed] string nibNameOrNull, [NullAllowed] NSBundle nibBundleOrNull);

		[Export ("dismissPopover")]
		void DismissPopover ();
	}

	[NoiOS]
	[NoTV]
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface SFSafariExtensionHandler : NSExtensionRequestHandling, SFSafariExtensionHandling {
	}

	//	TODO - Needs Safari Extension support to test
	// 	
	// 	[BaseType (typeof(NSObject))]
	// 	interface SFSafariExtensionManager
	// 	{
	// 		[Static]
	// 		[Export ("getStateOfSafariExtensionWithIdentifier:completionHandler:")]
	// 		void GetStateOfSafariExtension (string identifier, Action<SFSafariExtensionState, NSError> completionHandler);
	// 	}
	//
	// 	
	// 	[BaseType (typeof(NSObject))]
	// 	interface SFSafariExtensionState
	// 	{
	// 		[Export ("enabled")]
	// 		bool Enabled { [Bind ("isEnabled")] get; }
	// 	}

	[NoiOS]
	[NoTV]
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SFUniversalLink {

		[Export ("initWithWebpageURL:")]
		NativeHandle Constructor (NSUrl url);

		[Export ("webpageURL")]
		NSUrl WebpageUrl { get; }

		[Export ("applicationURL")]
		NSUrl ApplicationUrl { get; }

		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }
	}

	[Static]
	[iOS (15, 0), MacCatalyst (15, 0), NoTV]
	[DisableDefaultCtor]
	interface SFExtension {
		[Field ("SFExtensionMessageKey")]
		NSString MessageKey { get; }

		[iOS (17, 0), Mac (14, 0), MacCatalyst (17, 1)]
		[Field ("SFExtensionProfileKey")]
		NSString ProfileKey { get; }
	}

	[iOS (15, 0), MacCatalyst (15, 0), NoMac, NoTV]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SFSafariViewControllerActivityButton : NSCopying, NSSecureCoding {
		[Export ("initWithTemplateImage:extensionIdentifier:")]
		[DesignatedInitializer]
		NativeHandle Constructor (UIImage templateImage, string extensionIdentifier);

		[NullAllowed, Export ("templateImage", ArgumentSemantic.Copy)]
		UIImage TemplateImage { get; }

		[NullAllowed, Export ("extensionIdentifier")]
		string ExtensionIdentifier { get; }
	}

	[iOS (15, 0), MacCatalyst (15, 0), NoMac, NoTV]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SFSafariViewControllerPrewarmingToken /* Privately conforms to NSCoding and NSSecureCoding */
	{
		[Export ("invalidate")]
		void Invalidate ();
	}

	[iOS (16, 0), MacCatalyst (16, 0), NoMac, NoTV]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SFSafariViewControllerDataStore {
		[Static]
		[Export ("defaultDataStore", ArgumentSemantic.Strong)]
		SFSafariViewControllerDataStore DefaultDataStore { get; }

		[Async]
		[Export ("clearWebsiteDataWithCompletionHandler:")]
		void ClearWebsiteData ([NullAllowed] Action completion);
	}

	delegate void SFAddToHomeScreenActivityItemGetWebAppManifestCallback ([NullAllowed] BEWebAppManifest appManifest);
	delegate void SFAddToHomeScreenActivityItemGetHomeScreenWebAppInfoCallback ([NullAllowed] SFAddToHomeScreenInfo appManifest);

	[iOS (17, 4), MacCatalyst (17, 4), NoMac, NoTV]
	[Protocol (BackwardsCompatibleCodeGeneration = false)]
	interface SFAddToHomeScreenActivityItem {

		[Abstract]
		[Export ("URL")]
		NSUrl Url { get; }

		[Abstract]
		[Export ("title")]
		string Title { get; }

		[NullAllowed, Export ("iconItemProvider")]
		NSItemProvider IconItemProvider { get; }

		[NoMacCatalyst] // The BrowserEngineKit framework (the BEWebAppManifest type) isn't available on Mac Catalyst.
		[Deprecated (PlatformName.iOS, 18, 2, "Use 'GetHomeScreenWebAppInfo' instead.")]
		[Async]
		[Export ("getWebAppManifestWithCompletionHandler:")]
		void GetWebAppManifest (SFAddToHomeScreenActivityItemGetWebAppManifestCallback completionHandler);

		[iOS (18, 2), NoMacCatalyst]
		[Async]
		[Export ("getHomeScreenWebAppInfoWithCompletionHandler:")]
		void GetHomeScreenWebAppInfo (SFAddToHomeScreenActivityItemGetHomeScreenWebAppInfoCallback completionHandler);
	}

	[iOS (18, 2), NoMacCatalyst, NoMac]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SFAddToHomeScreenInfo : NSCopying {
		[NoMacCatalyst] // The BrowserEngineKit framework (the BEWebAppManifest type) isn't available on Mac Catalyst.
		[Export ("initWithManifest:")]
		[DesignatedInitializer]
		NativeHandle Constructor (BEWebAppManifest manifest);

		[Export ("manifest", ArgumentSemantic.Copy)]
		BEWebAppManifest Manifest { get; }

		[Export ("websiteCookies", ArgumentSemantic.Copy)]
		NSHttpCookie [] WebsiteCookies { get; set; }
	}

	delegate void SFSafariSettingsOpenExportBrowsingDataSettingsCompletionHandler ([NullAllowed] NSError error);

	[NoTV, NoMacCatalyst, iOS (26, 2), NoMac]
	delegate void SFSafariSettingsOpenExtensionsSettingsCompletionHandler ([NullAllowed] NSError error);

	[NoTV, NoMacCatalyst, iOS (26, 0), NoMac]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SFSafariSettings {
		[Async]
		[Static]
		[Export ("openExportBrowsingDataSettingsWithCompletionHandler:")]
		void OpenExportBrowsingDataSettings ([NullAllowed] SFSafariSettingsOpenExportBrowsingDataSettingsCompletionHandler completionHandler);

		[Async]
		[iOS (26, 2)]
		[Static]
		[Export ("openExtensionsSettingsForIdentifiers:completionHandler:")]
		void OpenExtensionsSettings (string [] extensionIdentifiers, [NullAllowed] SFSafariSettingsOpenExtensionsSettingsCompletionHandler completionHandler);
	}

	[NoTV, iOS (26, 2), MacCatalyst (26, 2), NoMac]
	delegate void SFSafariExtensionManagerHandler ([NullAllowed] SFSafariExtensionState state, [NullAllowed] NSError error);

	[NoTV, iOS (26, 2), MacCatalyst (26, 2), NoMac]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SFSafariExtensionManager {

		[Async]
		[Static]
		[Export ("getStateOfExtensionWithIdentifier:completionHandler:")]
		void GetState (string identifier, SFSafariExtensionManagerHandler completionHandler);
	}

	[NoTV, iOS (26, 2), MacCatalyst (26, 2), NoMac]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SFSafariExtensionState {

		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; }
	}

}
