//
// UNNotificationAttachment extensions & syntax sugar
//
// Authors:
//	Alex Soto  <alex.soto@xamarin.com>
//
// Copyright 2016 Xamarin Inc. All rights reserved.
//

#nullable enable

#if !TVOS

namespace UserNotifications {
	public partial class UNNotificationAttachment {

		/// <param name="identifier">The identifier to use.</param>
		///         <param name="url">The URL to use.</param>
		///         <param name="attachmentOptions">The attachment options.</param>
		/// <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		/// <summary>Creates a notification attachment from the specified identifier, URL, and options.</summary>
		/// <returns>A new notification attachment, or <see langword="null" /> if an error occurred.</returns>
		public static UNNotificationAttachment? FromIdentifier (string identifier, NSUrl url, UNNotificationAttachmentOptions attachmentOptions, out NSError? error)
		{
			return FromIdentifier (identifier, url, attachmentOptions?.Dictionary, out error);
		}
	}
}
#endif // !TVOS
