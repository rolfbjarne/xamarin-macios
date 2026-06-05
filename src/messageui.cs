//
// MessageUI.cs: This file describes the API that the generator will produce for MessageUI
//
// Authors:
//   Miguel de Icaza
//
// Copyright 2009, Novell, Inc.
// Copyright 2011, 2013 Xamarin, Inc.
//

using CoreFoundation;
using Messages;
using UIKit;

namespace MessageUI {

	[iOS (18, 0), MacCatalyst (18, 0)]
	[Native]
	enum MFMailComposeControllerDeferredAction : long {
		None,
		AdjustInsertionPoint,
		AddMissingRecipients,
	}

	/// <summary>Provides a user interface for composing and sending email messages.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MessageUI/Reference/MFMailComposeViewController_class/index.html">Apple documentation for <c>MFMailComposeViewController</c></related>
	[BaseType (typeof (UINavigationController))]
	interface MFMailComposeViewController : UIAppearance {
		/// <summary>Gets a value that indicates whether the device can send mail.</summary>
		/// <value><see langword="true" /> if the device can send mail; otherwise, <see langword="false" />.</value>
		
		[Static, Export ("canSendMail")]
		bool CanSendMail { get; }

		/// <summary>Gets or sets the weak delegate for mail compose events.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		
		[Export ("mailComposeDelegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakMailComposeDelegate { get; set; }

		/// <summary>Gets or sets the strongly-typed delegate for mail compose events.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		
		[Wrap ("WeakMailComposeDelegate")]
		IMFMailComposeViewControllerDelegate MailComposeDelegate { get; set; }

		/// <param name="subject">The subject of the email.</param>
		/// <summary>Sets the subject of the email message.</summary>
		
		[Export ("setSubject:")]
		void SetSubject (string subject);

		/// <param name="recipients">
		///   <para>An array of email address strings, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Sets the To recipients of the email message.</summary>
		
		[Export ("setToRecipients:")]
		void SetToRecipients ([NullAllowed] string [] recipients);

		/// <param name="ccRecipients">
		///   <para>An array of email address strings, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Sets the CC recipients of the email message.</summary>
		
		[Export ("setCcRecipients:")]
		void SetCcRecipients ([NullAllowed] string [] ccRecipients);

		/// <param name="bccRecipients">
		///   <para>An array of email address strings, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Sets the BCC recipients of the email message.</summary>
		
		[Export ("setBccRecipients:")]
		void SetBccRecipients ([NullAllowed] string [] bccRecipients);

		/// <param name="body">The body of the message.</param>
		/// <param name="isHtml">Whether the body is HTML.</param>
		/// <summary>Sets the body of the email message.</summary>
		
		[Export ("setMessageBody:isHTML:")]
		void SetMessageBody (string body, bool isHtml);

		/// <param name="attachment">The attachment data.</param>
		/// <param name="mimeType">The MIME type of the attachment.</param>
		/// <param name="fileName">The filename for the attachment.</param>
		/// <summary>Adds an attachment to the email message.</summary>
		
		[Export ("addAttachmentData:mimeType:fileName:")]
		void AddAttachmentData (NSData attachment, string mimeType, string fileName);

		/// <param name="emailAddress">The preferred email address to send from.</param>
		/// <summary>Sets the preferred sending email address.</summary>
		
		[MacCatalyst (13, 1)]
		[Export ("setPreferredSendingEmailAddress:")]
		void SetPreferredSendingEmailAddress (string emailAddress);

		[MacCatalyst (18, 4), iOS (18, 4)]
		[Export ("insertCollaborationItemProvider:completionHandler:")]
		[Async]
		void InsertCollaborationItemProvider (NSItemProvider itemProvider, Action<bool> completionHandler);
	}

	interface IMFMailComposeViewControllerDelegate { }

	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface MFMailComposeViewControllerDelegate {
		/// <param name="controller">The mail compose view controller.</param>
		/// <param name="result">The result of the compose operation.</param>
		/// <param name="error">The error, or <see langword="null" /> if no error occurred.</param>
		/// <summary>Called when the user finishes or cancels the mail compose operation.</summary>
		
		[Export ("mailComposeController:didFinishWithResult:error:")]
		void Finished (MFMailComposeViewController controller, MFMailComposeResult result, [NullAllowed] NSError error);
	}

	/// <summary>Provides data for the  event.</summary>
	interface MFMessageAvailabilityChangedEventArgs {
		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		///         <remarks>To be added.</remarks>
		[Export ("MFMessageComposeViewControllerTextMessageAvailabilityKey")]
		bool TextMessageAvailability { get; }
	}

	/// <summary>Provides a user interface for composing and sending messages.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MessageUI/Reference/MFMessageComposeViewController_class/index.html">Apple documentation for <c>MFMessageComposeViewController</c></related>
	[BaseType (typeof (UINavigationController))]
	interface MFMessageComposeViewController : UIAppearance {
		/// <summary>To be added.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		///         <remarks>To be added.</remarks>
		[Export ("messageComposeDelegate", ArgumentSemantic.Weak), NullAllowed]
		NSObject WeakMessageComposeDelegate { get; set; }

		/// <summary>To be added.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		///         <remarks>To be added.</remarks>
		[Wrap ("WeakMessageComposeDelegate")]
		IMFMessageComposeViewControllerDelegate MessageComposeDelegate { get; set; }

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		///         <remarks>To be added.</remarks>
		[NullAllowed]
		[Export ("recipients", ArgumentSemantic.Copy)]
		string [] Recipients { get; set; }

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		///         <remarks>To be added.</remarks>
		[NullAllowed]
		[Export ("body", ArgumentSemantic.Copy)]
		string Body { get; set; }

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		///         <remarks>To be added.</remarks>
		[Static]
		[Export ("canSendText")]
		bool CanSendText { get; }

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		///         <remarks>To be added.</remarks>
		[Static]
		[Export ("canSendAttachments")]
		bool CanSendAttachments { get; }

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		///         <remarks>To be added.</remarks>
		[Static]
		[Export ("canSendSubject")]
		bool CanSendSubject { get; }

		/// <param name="uti">To be added.</param>
		///         <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		///         <remarks>To be added.</remarks>
		[Static]
		[Export ("isSupportedAttachmentUTI:")]
		bool IsSupportedAttachment (string uti);

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		///         <remarks>To be added.</remarks>
		[NullAllowed]
		[Export ("subject", ArgumentSemantic.Copy)]
		string Subject { get; set; }

		/// <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		///         <remarks>To be added.</remarks>
		[return: NullAllowed]
		[Export ("attachments")]
		NSDictionary [] GetAttachments ();

		/// <summary>To be added.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		///         <remarks>To be added.</remarks>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("message", ArgumentSemantic.Copy)]
		MSMessage Message { get; set; }

		/// <param name="attachmentURL">To be added.</param>
		///         <param name="alternateFilename">
		///           <para>To be added.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		///         <remarks>To be added.</remarks>
		[Export ("addAttachmentURL:withAlternateFilename:")]
		bool AddAttachment (NSUrl attachmentURL, [NullAllowed] string alternateFilename);

		/// <param name="attachmentData">To be added.</param>
		///         <param name="uti">To be added.</param>
		///         <param name="filename">
		///           <para>To be added.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		///         <remarks>To be added.</remarks>
		[Export ("addAttachmentData:typeIdentifier:filename:")]
		bool AddAttachment (NSData attachmentData, string uti, string filename);

		[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), NoTV]
		[Export ("insertCollaborationItemProvider:")]
		bool InsertCollaboration (NSItemProvider itemProvider);

		/// <summary>To be added.</summary>
		///         <remarks>To be added.</remarks>
		[Export ("disableUserAttachments")]
		void DisableUserAttachments ();

		[Field ("MFMessageComposeViewControllerTextMessageAvailabilityDidChangeNotification")]
		[Notification (typeof (MFMessageAvailabilityChangedEventArgs))]
		NSString TextMessageAvailabilityDidChangeNotification { get; }

		/// <summary>Represents the value associated with the constant MFMessageComposeViewControllerTextMessageAvailabilityKey</summary>
		///         <value>
		///         </value>
		///         <remarks>To be added.</remarks>
		[Field ("MFMessageComposeViewControllerTextMessageAvailabilityKey")]
		NSString TextMessageAvailabilityKey { get; }

		/// <summary>Represents the value associated with the constant MFMessageComposeViewControllerAttachmentAlternateFilename</summary>
		///         <value>
		///         </value>
		///         <remarks>To be added.</remarks>
		[Field ("MFMessageComposeViewControllerAttachmentAlternateFilename")]
		NSString AttachmentAlternateFilename { get; }

		/// <summary>Represents the value associated with the constant MFMessageComposeViewControllerAttachmentURL</summary>
		///         <value>
		///         </value>
		///         <remarks>To be added.</remarks>
		[Field ("MFMessageComposeViewControllerAttachmentURL")]
		NSString AttachmentURL { get; }

		[Async]
		[iOS (17, 0), NoMacCatalyst, NoTV]
		[Export ("setUPIVerificationCodeSendCompletion:")]
		void SetUpiVerificationCodeSendCompletion (Action<bool> completion);
	}

	interface IMFMessageComposeViewControllerDelegate { }

	/// <summary>Used to receive notifications from the MFMessageComposeViewController class.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MessageUI/Reference/MFMessageComposeViewControllerDelegate_protocol/index.html">Apple documentation for <c>MFMessageComposeViewControllerDelegate</c></related>
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface MFMessageComposeViewControllerDelegate {
		/// <param name="controller">To be added.</param>
		///         <param name="result">To be added.</param>
		///         <summary>To be added.</summary>
		///         <remarks>To be added.</remarks>
		[Abstract]
		[Export ("messageComposeViewController:didFinishWithResult:")]
		void Finished (MFMessageComposeViewController controller, MessageComposeResult result);
	}
}
