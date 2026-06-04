using CoreGraphics;
using AppKit;

using System.ComponentModel;
using UniformTypeIdentifiers;

namespace QuickLookUI {

	[Native]
	enum QLPreviewViewStyle : ulong {
		/// <summary>Indicates normal.</summary>
		Normal = 0,
		/// <summary>Indicates compact.</summary>
		Compact = 1,
	}

	interface IQLPreviewPanelDataSource { }

	[BaseType (typeof (NSObject))]
	[Protocol, Model]
	interface QLPreviewPanelDataSource {
		/// <param name="panel">The panel.</param>
		/// <summary>Returns the number of preview items in the panel.</summary>
		/// <returns>The number of preview items.</returns>
		[Export ("numberOfPreviewItemsInPreviewPanel:")]
		[Abstract]
		nint NumberOfPreviewItemsInPreviewPanel (QLPreviewPanel panel);

		/// <param name="panel">The panel.</param>
		/// <param name="index">The zero-based index.</param>
		/// <summary>Returns the preview item at the specified index.</summary>
		/// <returns>The preview item at the specified index.</returns>
		[Export ("previewPanel:previewItemAtIndex:")]
		[Abstract]
		IQLPreviewItem PreviewItemAtIndex (QLPreviewPanel panel, nint index);
	}

	interface IQLPreviewPanelDelegate { }

	[BaseType (typeof (NSObject))]
	[Protocol, Model]
	interface QLPreviewPanelDelegate : NSWindowDelegate {
		/// <param name="panel">The panel.</param>
		/// <param name="theEvent">The the event.</param>
		/// <summary>Called to determine whether the delegate handles the specified event.</summary>
		/// <returns><see langword="true" /> if the event was handled; otherwise, <see langword="false" />.</returns>
		[Export ("previewPanel:handleEvent:")]
		bool HandleEvent (QLPreviewPanel panel, NSEvent theEvent);

		/// <param name="panel">The panel.</param>
		/// <param name="item">The item.</param>
		/// <summary>Returns the source frame on screen for the specified preview item.</summary>
		/// <returns>The source frame rectangle on screen.</returns>
		[Export ("previewPanel:sourceFrameOnScreenForPreviewItem:")]
		CGRect SourceFrameOnScreenForPreviewItem (QLPreviewPanel panel, IQLPreviewItem item);

		/// <param name="panel">The panel.</param>
		/// <param name="item">The item.</param>
		/// <param name="contentRect">The content rect.</param>
		/// <summary>Returns the transition image for the specified preview item.</summary>
		/// <returns>The transition image.</returns>
		[Export ("previewPanel:transitionImageForPreviewItem:contentRect:")]
		NSObject TransitionImageForPreviewItem (QLPreviewPanel panel, IQLPreviewItem item, CGRect contentRect);
	}

	interface IQLPreviewItem { }

	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface QLPreviewItem {
		[Abstract]
		[Export ("previewItemURL")]
		NSUrl PreviewItemUrl { get; }

		[Export ("previewItemTitle")]
		string PreviewItemTitle { get; }

		/// <summary>Gets the display state for the preview item.</summary>
		/// <value>The display state object.</value>
		[Export ("previewItemDisplayState")]
		NSObject PreviewItemDisplayState { get; }
	}

	[Category]
	[BaseType (typeof (NSObject))]
	interface QLPreviewPanelController {

		/// <param name="panel">The panel.</param>
		/// <summary>Returns whether this object accepts control of the preview panel.</summary>
		/// <returns><see langword="true" /> if this object accepts control of the panel; otherwise, <see langword="false" />.</returns>
		[Export ("acceptsPreviewPanelControl:")]
		bool AcceptsPreviewPanelControl (QLPreviewPanel panel);

		/// <param name="panel">The panel.</param>
		/// <summary>Called when this object takes control of the preview panel.</summary>
		[Export ("beginPreviewPanelControl:")]
		void BeginPreviewPanelControl (QLPreviewPanel panel);

		/// <param name="panel">The panel.</param>
		/// <summary>Called when this object relinquishes control of the preview panel.</summary>
		[Export ("endPreviewPanelControl:")]
		void EndPreviewPanelControl (QLPreviewPanel panel);
	}

	[BaseType (typeof (NSPanel))]
	interface QLPreviewPanel {
		[Export ("currentController")]
		NSObject CurrentController { get; }

		[Export ("dataSource", ArgumentSemantic.Assign)]
		[NullAllowed]
		NSObject WeakDataSource { get; set; }

		/// <summary>Gets or sets the data source for the preview panel.</summary>
		/// <value>The data source, or <see langword="null" />.</value>
		[Wrap ("WeakDataSource")]
		[NullAllowed]
		IQLPreviewPanelDataSource DataSource { get; set; }

		[Export ("currentPreviewItemIndex")]
		nint CurrentPreviewItemIndex { get; set; }

		[Export ("currentPreviewItem")]
		IQLPreviewItem CurrentPreviewItem { get; }

		[Export ("displayState", ArgumentSemantic.Retain)]
		NSObject DisplayState { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>Gets or sets the delegate for the preview panel.</summary>
		/// <value>The delegate, or <see langword="null" />.</value>
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		IQLPreviewPanelDelegate Delegate { get; set; }

		/// <summary>Gets a value that indicates whether the panel is in full-screen mode.</summary>
		/// <value><see langword="true" /> if the panel is in full-screen mode; otherwise, <see langword="false" />.</value>
		[Export ("inFullScreenMode")]
		bool InFullScreenMode { [Bind ("isInFullScreenMode")] get; }

		[Static, Export ("sharedPreviewPanel")]
		QLPreviewPanel SharedPreviewPanel ();

		[Static, Export ("sharedPreviewPanelExists")]
		bool SharedPreviewPanelExists ();

		[Export ("updateController")]
		void UpdateController ();

		[Export ("reloadData")]
		void ReloadData ();

		[Export ("refreshCurrentPreviewItem")]
		void RefreshCurrentPreviewItem ();

		// @required - (BOOL)enterFullScreenMode:(NSScreen *)screen withOptions:(NSDictionary *)options;
		[Export ("enterFullScreenMode:withOptions:")]
		bool EnterFullScreenMode ([NullAllowed] NSScreen screen, [NullAllowed] NSDictionary options);

		// @required - (void)exitFullScreenModeWithOptions:(NSDictionary *)options;
		[Export ("exitFullScreenModeWithOptions:")]
		void ExitFullScreenModeWithOptions ([NullAllowed] NSDictionary options);
	}

	[BaseType (typeof (NSView))] // Mac 10.6
	interface QLPreviewView {

		[Export ("initWithFrame:style:")]
		NativeHandle Constructor (CGRect frame, QLPreviewViewStyle style);

		[Export ("initWithFrame:")]
		NativeHandle Constructor (CGRect frame);

		[Export ("previewItem", ArgumentSemantic.Retain)]
		IQLPreviewItem PreviewItem { get; set; }

		[Export ("refreshPreviewItem")]
		void RefreshPreviewItem ();

		[Export ("displayState", ArgumentSemantic.Retain)]
		NSObject DisplayState { get; set; }

		[Export ("close")]
		void Close ();

		[Export ("shouldCloseWithWindow")]
		bool ShouldCloseWithWindow { get; set; }

		[Export ("autostarts")]
		bool Autostarts { get; set; }
	}

	[Protocol]
	interface QLPreviewingController {
		/// <param name="identifier">The identifier to use.</param>
		/// <param name="queryString">The query string.</param>
		/// <param name="ItemLoadingHandler">The item loading handler.</param>
		/// <summary>To be added.</summary>
		[Export ("preparePreviewOfSearchableItemWithIdentifier:queryString:completionHandler:")]
#if XAMCORE_5_0
		void PreparePreviewOfSearchableItem (string identifier, string queryString, Action<NSError> itemLoadingHandler);
#else
		void PreparePreviewOfSearchableItem (string identifier, string queryString, Action<NSError> ItemLoadingHandler);
#endif

		[Export ("preparePreviewOfFileAtURL:completionHandler:")]
		void PreparePreviewOfFile (NSUrl url, Action<NSError> completionHandler);

		[iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("providePreviewForFileRequest:completionHandler:")]
		void ProvidePreview (QLFilePreviewRequest request, Action<QLPreviewReply, NSError> handler);
	}

	[NoTV, iOS (15, 0), MacCatalyst (15, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface QLFilePreviewRequest {
		[Export ("fileURL")]
		NSUrl FileUrl { get; }
	}

	[NoTV, iOS (15, 0), MacCatalyst (15, 0)]
	[DisableDefaultCtor]
	[BaseType (typeof (NSObject))]
	interface QLPreviewProvider : NSExtensionRequestHandling {
	}

	[NoTV, iOS (15, 0), MacCatalyst (15, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface QLPreviewReplyAttachment {
		[Export ("data")]
		NSData Data { get; }

		[Export ("contentType")]
		UTType ContentType { get; }

		[Export ("initWithData:contentType:")]
		NativeHandle Constructor (NSData data, UTType contentType);
	}

	delegate bool QLPreviewReplyDrawingHandler (CGContext context, QLPreviewReply reply, out NSError error);
	delegate NSData QLPreviewReplyDataCreationHandler (QLPreviewReply reply, out NSError error);
	delegate CGPDFDocument QLPreviewReplyUIDocumentCreationHandler (QLPreviewReply reply, out NSError error);

	[NoTV, iOS (15, 0), MacCatalyst (15, 0)]
	[BaseType (typeof (NSObject))]
	interface QLPreviewReply {
		[Export ("stringEncoding")]
		NSStringEncoding StringEncoding { get; set; }

		[Export ("attachments", ArgumentSemantic.Copy)]
		NSDictionary<NSString, QLPreviewReplyAttachment> Attachments { get; set; }

		[Export ("title")]
		string Title { get; set; }

		[Export ("initWithContextSize:isBitmap:drawingBlock:")]
		NativeHandle Constructor (CGSize contextSize, bool isBitmap, QLPreviewReplyDrawingHandler drawingHandler);

		[Export ("initWithFileURL:")]
		NativeHandle Constructor (NSUrl fileUrl);

		[Export ("initWithDataOfContentType:contentSize:dataCreationBlock:")]
		NativeHandle Constructor (UTType contentType, CGSize contentSize, QLPreviewReplyDataCreationHandler dataCreationHandler);

		// QLPreviewReply_UI
		[Export ("initForPDFWithPageSize:documentCreationBlock:")]
		NativeHandle Constructor (CGSize defaultPageSize, QLPreviewReplyUIDocumentCreationHandler documentCreationHandler);
	}
}
