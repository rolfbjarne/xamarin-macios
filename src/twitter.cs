//
// ios5-twitter.cs: Twitter bindings
//
// Authors:
//   Miguel de Icaza
//

using UIKit;
using Twitter;
using Accounts;

namespace Twitter {

	/// <summary>A delegate that is used as the <c>handler</c> in calls to <see cref="Twitter.TWRequest.PerformRequest(Twitter.TWRequestHandler)" />.</summary>
	delegate void TWRequestHandler ([NullAllowed] NSData responseData, [NullAllowed] NSHttpUrlResponse urlResponse, [NullAllowed] NSError error);

	/// <summary>A Twitter request.</summary>
	[Deprecated (PlatformName.iOS, 6, 0, message: "Use the 'Social' framework.")]
	[BaseType (typeof (NSObject))]
	interface TWRequest {

		/// <summary>Gets or sets the account used for authentication.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("account")]
		ACAccount Account { get; set; }

		/// <summary>Gets the request method.</summary>
		/// <value>The HTTP request method.</value>
		[Export ("requestMethod")]
		TWRequestMethod RequestMethod { get; }

		/// <summary>Gets the request URL.</summary>
		/// <value>The URL for the request.</value>
		[Export ("URL")]
		NSUrl Url { get; }

		/// <summary>Gets the request parameters.</summary>
		/// <value>A dictionary of parameters.</value>
		[Export ("parameters")]
		NSDictionary Parameters { get; }

		/// <param name="url">The URL to use.</param>
		/// <param name="parameters">
		///           <para>HTTP parameters for this request.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="requestMethod">The request method.</param>
		/// <summary>Creates a new Twitter request with the specified URL, parameters, and method.</summary>
		[Export ("initWithURL:parameters:requestMethod:")]
		NativeHandle Constructor (NSUrl url, [NullAllowed] NSDictionary parameters, TWRequestMethod requestMethod);

		/// <param name="data">The data to use.</param>
		///         <param name="name">The name to use.</param>
		///         <param name="type">The type.</param>
		/// <summary>Adds multipart data with the specified name and type.</summary>
		[Export ("addMultiPartData:withName:type:")]
		void AddMultiPartData (NSData data, string name, string type);

		/// <summary>Gets the signed URL request.</summary>
		/// <value>The signed URL request.</value>
		[Export ("signedURLRequest")]
		NSUrlRequest SignedUrlRequest { get; }

		/// <param name="handler">The completion handler to call when the operation completes.</param>
		/// <summary>Performs the request asynchronously.</summary>
		[Export ("performRequestWithHandler:")]
		[Async (ResultTypeName = "TWRequestResult", XmlDocs = """
			<summary>Performs the request asynchronously.</summary>
			<returns>
			          <para>A task that represents the asynchronous PerformRequest operation.   The value of the TResult parameter is of type <c>Action&lt;Twitter.TWRequestResult&gt;</c>.</para>
			        </returns>
			<remarks>
			          <para copied="true">The PerformRequestAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para copied="true">Returns a task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		void PerformRequest (TWRequestHandler handler);
	}

	/// <summary>A <see cref="UIKit.UIViewController" /> that manages the user experience of composing a tweet.</summary>
	[Deprecated (PlatformName.iOS, 6, 0, message: "Use the 'Social' framework.")]
	[BaseType (typeof (UIViewController))]
	interface TWTweetComposeViewController {
		/// <param name="nibName">
		///   <para>The name of the nib file, or <see langword="null" />.</para>
		///   <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		/// </param>
		/// <param name="bundle">
		///   <para>The bundle in which to search for the nib file, or <see langword="null" />.</para>
		///   <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		/// </param>
		/// <summary>Creates a new <see cref="Twitter.TWTweetComposeViewController" /> with the specified nib name and bundle.</summary>
		[Export ("initWithNibName:bundle:")]
		[PostGet ("NibBundle")]
		NativeHandle Constructor ([NullAllowed] string nibName, [NullAllowed] NSBundle bundle);

		/// <summary>Gets or sets the completion handler.</summary>
		/// <value>The completion handler.</value>
		[Export ("completionHandler")]
		Action<TWTweetComposeViewControllerResult> CompletionHandler { get; set; }

		/// <summary>Gets a value that indicates whether the user can send a tweet.</summary>
		/// <value><see langword="true" /> if a tweet can be sent; otherwise, <see langword="false" />.</value>
		[Static]
		[Export ("canSendTweet")]
		bool CanSendTweet { get; }

		/// <param name="text">The text.</param>
		/// <summary>Sets the initial text of the tweet.</summary>
		/// <returns><see langword="true" /> if the text was set; otherwise, <see langword="false" />.</returns>
		[Export ("setInitialText:")]
		bool SetInitialText (string text);

		/// <param name="image">The image.</param>
		/// <summary>Adds an image to the tweet.</summary>
		/// <returns><see langword="true" /> if the image was added; otherwise, <see langword="false" />.</returns>
		[Export ("addImage:")]
		bool AddImage (UIImage image);

		/// <summary>Removes all images from the tweet.</summary>
		/// <returns><see langword="true" /> if the images were removed; otherwise, <see langword="false" />.</returns>
		[Export ("removeAllImages")]
		bool RemoveAllImages ();

		/// <param name="url">The URL to use.</param>
		/// <summary>Adds a URL to the tweet.</summary>
		/// <returns><see langword="true" /> if the URL was added; otherwise, <see langword="false" />.</returns>
		[Export ("addURL:")]
		bool AddUrl (NSUrl url);

		/// <summary>Removes all URLs from the tweet.</summary>
		/// <returns><see langword="true" /> if the URLs were removed; otherwise, <see langword="false" />.</returns>
		[Export ("removeAllURLs")]
		bool RemoveAllUrls ();
	}

}
