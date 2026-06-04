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

		/// <summary>To be added.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("account")]
		ACAccount Account { get; set; }

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		[Export ("requestMethod")]
		TWRequestMethod RequestMethod { get; }

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		[Export ("URL")]
		NSUrl Url { get; }

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		[Export ("parameters")]
		NSDictionary Parameters { get; }

		/// <param name="url">The URL to use.</param>
		/// <param name="parameters">
		///           <para>HTTP parameters for this request.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="requestMethod">The request method.</param>
		/// <summary>To be added.</summary>
		[Export ("initWithURL:parameters:requestMethod:")]
		NativeHandle Constructor (NSUrl url, [NullAllowed] NSDictionary parameters, TWRequestMethod requestMethod);

		/// <param name="data">The data to use.</param>
		///         <param name="name">The name to use.</param>
		///         <param name="type">The type.</param>
		///         <summary>To be added.</summary>
		[Export ("addMultiPartData:withName:type:")]
		void AddMultiPartData (NSData data, string name, string type);

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		[Export ("signedURLRequest")]
		NSUrlRequest SignedUrlRequest { get; }

		/// <param name="handler">The completion handler to call when the operation completes.</param>
		///         <summary>To be added.</summary>
		[Export ("performRequestWithHandler:")]
		[Async (ResultTypeName = "TWRequestResult", XmlDocs = """
			<summary>To be added.</summary>
			<returns>
			          <para>A task that represents the asynchronous PerformRequest operation.   The value of the TResult parameter is of type <c>Action&lt;Twitter.TWRequestResult&gt;</c>.</para>
			        </returns>
			<remarks>
			          <para copied="true">The PerformRequestAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para copied="true">To be added.</para>
			        </remarks>
			""")]
		void PerformRequest (TWRequestHandler handler);
	}

	/// <summary>A <see cref="UIKit.UIViewController" /> that manages the user experience of composing a tweet.</summary>
	[Deprecated (PlatformName.iOS, 6, 0, message: "Use the 'Social' framework.")]
	[BaseType (typeof (UIViewController))]
	interface TWTweetComposeViewController {
		/// <param name="nibName">
		///           <para>To be added.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="bundle">
		///           <para>To be added.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>To be added.</summary>
		[Export ("initWithNibName:bundle:")]
		[PostGet ("NibBundle")]
		NativeHandle Constructor ([NullAllowed] string nibName, [NullAllowed] NSBundle bundle);

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		[Export ("completionHandler")]
		Action<TWTweetComposeViewControllerResult> CompletionHandler { get; set; }

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		[Static]
		[Export ("canSendTweet")]
		bool CanSendTweet { get; }

		/// <param name="text">The text.</param>
		///         <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		[Export ("setInitialText:")]
		bool SetInitialText (string text);

		/// <param name="image">The image.</param>
		///         <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		[Export ("addImage:")]
		bool AddImage (UIImage image);

		/// <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		[Export ("removeAllImages")]
		bool RemoveAllImages ();

		/// <param name="url">The URL to use.</param>
		///         <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		[Export ("addURL:")]
		bool AddUrl (NSUrl url);

		/// <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		[Export ("removeAllURLs")]
		bool RemoveAllUrls ();
	}

}
