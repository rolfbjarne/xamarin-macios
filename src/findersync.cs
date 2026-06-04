using AppKit;

namespace FinderSync {
	delegate void GetValuesCompletionHandler (NSDictionary<NSString, NSObject> values, NSError error);

	[BaseType (typeof (NSExtensionContext))]
	interface FIFinderSyncController : NSSecureCoding, NSCopying {
		/// <summary>Gets the default Finder Sync controller.</summary>
		/// <value>The default controller instance.</value>
		[Static]
		[Export ("defaultController")]
		FIFinderSyncController DefaultController { get; }

		/// <summary>Gets or sets the set of directory URLs to observe.</summary>
		/// <value>The set of observed directory URLs, or <see langword="null" />.</value>
		[NullAllowed] // null_resettable
		[Export ("directoryURLs", ArgumentSemantic.Copy)]
		NSSet DirectoryUrls { get; set; }

		/// <param name="image">The image.</param>
		///         <param name="label">The label.</param>
		///         <param name="badgeID">The badge i d.</param>
		/// <summary>Sets a badge image and label for the specified badge identifier.</summary>
		[Export ("setBadgeImage:label:forBadgeIdentifier:")]
		void SetBadgeImage (NSImage image, [NullAllowed] string label, string badgeID);

		/// <param name="badgeID">The badge i d.</param>
		///         <param name="url">The URL to use.</param>
		/// <summary>Sets the badge identifier for the item at the specified URL.</summary>
		[Export ("setBadgeIdentifier:forURL:")]
		void SetBadgeIdentifier (string badgeID, NSUrl url);

		/// <summary>Gets the targeted URL.</summary>
		/// <value>The targeted URL, or <see langword="null" />.</value>
		[NullAllowed, Export ("targetedURL")]
		NSUrl TargetedURL { get; }

		/// <summary>Gets the selected item URLs.</summary>
		/// <value>The selected item URLs, or <see langword="null" />.</value>
		[NullAllowed, Export ("selectedItemURLs")]
		NSUrl [] SelectedItemURLs { get; }

		/// <param name="itemUrl">The item url.</param>
		/// <summary>Returns the last used date for the item at the specified URL.</summary>
		/// <returns>The last used date, or <see langword="null" />.</returns>
		[Export ("lastUsedDateForItemWithURL:")]
		[return: NullAllowed]
		NSDate GetLastUsedDate (NSUrl itemUrl);

		/// <param name="lastUsedDate">The last used date.</param>
		///         <param name="itemUrl">The item url.</param>
		///         <param name="completion">The completion.</param>
		/// <summary>Sets the last used date for the item at the specified URL.</summary>
		[Async (XmlDocs = """
			<param name="lastUsedDate">The date to set.</param>
			<param name="itemUrl">The URL of the item.</param>
			<summary>Asynchronously sets the last used date.</summary>
			
			"""), Export ("setLastUsedDate:forItemWithURL:completion:")]
		void SetLastUsedDate (NSDate lastUsedDate, NSUrl itemUrl, Action<NSError> completion);

		/// <param name="itemUrl">The item url.</param>
		/// <summary>Returns the tag data for the item at the specified URL.</summary>
		/// <returns>The tag data, or <see langword="null" />.</returns>
		[Export ("tagDataForItemWithURL:")]
		[return: NullAllowed]
		NSData GetTagData (NSUrl itemUrl);

		/// <param name="tagData">The tag data.</param>
		///         <param name="itemUrl">The item url.</param>
		///         <param name="completion">The completion.</param>
		/// <summary>Sets the tag data for the item at the specified URL.</summary>
		[Async (XmlDocs = """
			<param name="tagData">The tag data to set.</param>
			<param name="itemUrl">The URL of the item.</param>
			<summary>Asynchronously sets the tag data.</summary>
			
			""")]
		[Export ("setTagData:forItemWithURL:completion:")]
		void SetTagData ([NullAllowed] NSData tagData, NSUrl itemUrl, Action<NSError> completion);

		/// <summary>Gets a value that indicates whether the Finder Sync extension is enabled.</summary>
		/// <value><see langword="true" /> if the extension is enabled; otherwise, <see langword="false" />.</value>
		[Static]
		[Export ("extensionEnabled")]
		bool ExtensionEnabled { [Bind ("isExtensionEnabled")] get; }

		/// <summary>Shows the extension management interface.</summary>
		[Static]
		[Export ("showExtensionManagementInterface")]
		void ShowExtensionManagementInterface ();
	}

	[Protocol (Name = "FIFinderSync")]
	interface FIFinderSyncProtocol {
		/// <param name="menuKind">The menu kind.</param>
		/// <summary>Returns the menu for the specified menu kind.</summary>
		/// <returns>The menu, or <see langword="null" />.</returns>
		[Export ("menuForMenuKind:")]
		[return: NullAllowed]
		NSMenu GetMenu (FIMenuKind menuKind);

		/// <param name="url">The URL to use.</param>
		/// <summary>Called when the extension begins observing the directory at the specified URL.</summary>
		[Export ("beginObservingDirectoryAtURL:")]
		void BeginObservingDirectory (NSUrl url);

		/// <param name="url">The URL to use.</param>
		/// <summary>Called when the extension stops observing the directory at the specified URL.</summary>
		[Export ("endObservingDirectoryAtURL:")]
		void EndObservingDirectory (NSUrl url);

		/// <param name="url">The URL to use.</param>
		/// <summary>Requests a badge identifier for the item at the specified URL.</summary>
		[Export ("requestBadgeIdentifierForURL:")]
		void RequestBadgeIdentifier (NSUrl url);

		/// <summary>Gets the toolbar item name.</summary>
		/// <value>The name of the toolbar item.</value>
		[Export ("toolbarItemName")]
		string ToolbarItemName { get; }

		/// <summary>Gets the toolbar item image.</summary>
		/// <value>The image of the toolbar item.</value>
		[Export ("toolbarItemImage", ArgumentSemantic.Copy)]
		NSImage ToolbarItemImage { get; }

		/// <summary>Gets the toolbar item tooltip.</summary>
		/// <value>The tooltip of the toolbar item.</value>
		[Export ("toolbarItemToolTip")]
		string ToolbarItemToolTip { get; }

		/// <param name="itemUrl">The item url.</param>
		/// <summary>Returns the supported service names for the item at the specified URL.</summary>
		/// <returns>An array of supported service names.</returns>
		[Export ("supportedServiceNamesForItemWithURL:")]
		string [] SupportedServiceNames (NSUrl itemUrl);

#if FALSE // TODO: Activate after 10.13 foundation APIs have been merged.  Bug 57800
		[Export ("makeListenerEndpointForServiceName:andReturnError:")]
		[return: NullAllowed]
		NSXpcListenerEndpoint MakeListenerEndpoint (string serviceName, [NullAllowed] out NSError error);
#endif
		/// <param name="attributes">The attributes.</param>
		/// <param name="itemUrl">The item url.</param>
		/// <param name="completion">The completion.</param>
		/// <summary>Gets the values for the specified attributes of the item at the specified URL.</summary>
		[Async, Export ("valuesForAttributes:forItemWithURL:completion:")]
		void GetValues (string [] attributes, NSUrl itemUrl, GetValuesCompletionHandler completion);
	}

	[BaseType (typeof (NSObject))]
	interface FIFinderSync : NSExtensionRequestHandling, FIFinderSyncProtocol {
	}
}
