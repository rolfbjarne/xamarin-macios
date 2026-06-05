//
// Copyright 2011, Novell, Inc.
// Copyright 2011, Regan Sarwas
//
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

//
// imagekit.cs: Bindings for the Image Kit API
//
using AppKit;
using CoreImage;
using ImageCaptureCore;
using CoreGraphics;
using CoreAnimation;

namespace ImageKit {

	enum IKToolMode { // Constants introduced in 10.5 and 10.6
		/// <summary>The annotation tool mode.</summary>
		[Field ("IKToolModeAnnotate")]
		Annotate,

		/// <summary>The crop tool mode.</summary>
		[Field ("IKToolModeCrop")]
		Crop,

		/// <summary>The move tool mode.</summary>
		[Field ("IKToolModeMove")]
		Move,

		/// <summary>No tool mode.</summary>
		[Field ("IKToolModeNone")]
		None,

		/// <summary>The rotation tool mode.</summary>
		[Field ("IKToolModeRotate")]
		Rotate,

		/// <summary>The selection tool mode.</summary>
		[Field ("IKToolModeSelect")]
		Select,

		/// <summary>The ellipse selection tool mode.</summary>
		[Field ("IKToolModeSelectEllipse")]
		SelectEllipse,

		/// <summary>The lasso selection tool mode.</summary>
		[Field ("IKToolModeSelectLasso")]
		SelectLasso,

		/// <summary>The rectangle selection tool mode.</summary>
		[Field ("IKToolModeSelectRect")]
		SelectRect,
	}

	enum IKOverlayType { // Constants introduced in 10.5
		/// <summary>The background overlay type.</summary>
		[Field ("IKOverlayTypeBackground")]
		Background,

		/// <summary>The image overlay type.</summary>
		[Field ("IKOverlayTypeImage")]
		Image,
	}

	[BaseType (typeof (NSView), Delegates = new string [] { "WeakDelegate" }, Events = new Type [] { typeof (IKCameraDeviceViewDelegate) })]
	interface IKCameraDeviceView {
		/// <param name="frameRect">The frame rectangle.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithFrame:")]
		NativeHandle Constructor (CGRect frameRect);

		/// <summary>Gets or sets the WeakDelegate value.</summary>
		[Export ("delegate", ArgumentSemantic.Assign), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>Gets or sets the Delegate value.</summary>
		[Wrap ("WeakDelegate")]
		IIKCameraDeviceViewDelegate Delegate { get; set; }

		[Export ("cameraDevice", ArgumentSemantic.Assign)]
		ICCameraDevice CameraDevice { get; set; }

		/// <summary>Gets or sets the HasDisplayModeTable value.</summary>
		[Export ("hasDisplayModeTable")]
		bool HasDisplayModeTable { get; set; }

		/// <summary>Gets or sets the HasDisplayModeIcon value.</summary>
		[Export ("hasDisplayModeIcon")]
		bool HasDisplayModeIcon { get; set; }

		/// <summary>Gets or sets the DownloadAllControlLabel value.</summary>
		[Export ("downloadAllControlLabel", ArgumentSemantic.Copy)]
		string DownloadAllControlLabel { get; set; }

		/// <summary>Gets or sets the DownloadSelectedControlLabel value.</summary>
		[Export ("downloadSelectedControlLabel", ArgumentSemantic.Copy)]
		string DownloadSelectedControlLabel { get; set; }

		/// <summary>Gets or sets the IconSize value.</summary>
		[Export ("iconSize")]
		nint IconSize { get; set; }

		/// <summary>Gets or sets the TransferMode value.</summary>
		[Export ("transferMode")]
		IKCameraDeviceViewTransferMode TransferMode { get; set; }

		/// <summary>Gets or sets the DisplaysDownloadsDirectoryControl value.</summary>
		[Export ("displaysDownloadsDirectoryControl")]
		bool DisplaysDownloadsDirectoryControl { get; set; }

		/// <summary>Gets or sets the DownloadsDirectory value.</summary>
		[Export ("downloadsDirectory", ArgumentSemantic.Retain)]
		NSUrl DownloadsDirectory { get; set; }

		/// <summary>Gets or sets the DisplaysPostProcessApplicationControl value.</summary>
		[Export ("displaysPostProcessApplicationControl")]
		bool DisplaysPostProcessApplicationControl { get; set; }

		/// <summary>Gets or sets the PostProcessApplication value.</summary>
		[Export ("postProcessApplication", ArgumentSemantic.Retain)]
		NSUrl PostProcessApplication { get; set; }

		/// <summary>Gets the CanRotateSelectedItemsLeft value.</summary>
		[Export ("canRotateSelectedItemsLeft")]
		bool CanRotateSelectedItemsLeft { get; }

		/// <summary>Gets the CanRotateSelectedItemsRight value.</summary>
		[Export ("canRotateSelectedItemsRight")]
		bool CanRotateSelectedItemsRight { get; }

		/// <summary>Gets the CanDeleteSelectedItems value.</summary>
		[Export ("canDeleteSelectedItems")]
		bool CanDeleteSelectedItems { get; }

		/// <summary>Gets the CanDownloadSelectedItems value.</summary>
		[Export ("canDownloadSelectedItems")]
		bool CanDownloadSelectedItems { get; }

		/// <summary>Gets the SelectedIndexes value.</summary>
		[Export ("selectedIndexes")]
		NSIndexSet SelectedIndexes { get; }

		/// <param name="indexes">The indexes to select.</param>
		///         <param name="extendSelection">Whether to extend the current selection.</param>
		///         <summary>Performs the select items at operation.</summary>
		[Export ("selectIndexes:byExtendingSelection:")]
		void SelectItemsAt (NSIndexSet indexes, bool extendSelection);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the rotate left operation.</summary>
		[Export ("rotateLeft:")]
		void RotateLeft (NSObject sender);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the rotate right operation.</summary>
		[Export ("rotateRight:")]
		void RotateRight (NSObject sender);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the delete selected items operation.</summary>
		[Export ("deleteSelectedItems:")]
		void DeleteSelectedItems (NSObject sender);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the download selected items operation.</summary>
		[Export ("downloadSelectedItems:")]
		void DownloadSelectedItems (NSObject sender);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the download all items operation.</summary>
		[Export ("downloadAllItems:")]
		void DownloadAllItems (NSObject sender);

		/// <summary>Gets or sets the Mode value.</summary>
		[Export ("mode", ArgumentSemantic.Assign)]
		IKCameraDeviceViewDisplayMode Mode { get; set; }

		[Export ("setCustomActionControl:")]
		void SetCustomActionControl (NSSegmentedControl control);

		[Export ("setCustomDeleteControl:")]
		void SetCustomDelete (NSSegmentedControl control);

		[Export ("setCustomIconSizeSlider:")]
		void SetCustomIconSizeSlider (NSSlider slider);

		[Export ("setCustomModeControl:")]
		void SetCustomModeControl (NSSegmentedControl control);

		[Export ("setCustomRotateControl:")]
		void SetCustomRotateControl (NSSegmentedControl control);

		[Export ("setShowStatusInfoAsWindowSubtitle:")]
		void SetShowStatusInfoAsWindowSubtitle (bool value);
	}

	interface IIKCameraDeviceViewDelegate { }

	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface IKCameraDeviceViewDelegate {
		/// <param name="cameraDeviceView">The camera device view.</param>
		///         <summary>Performs the asynchronous operation.</summary>
		[Export ("cameraDeviceViewSelectionDidChange:"), EventArgs ("IKCameraDeviceView", XmlDocs = """
			<summary>Performs the asynchronous operation.</summary>
			""")]
		void SelectionDidChange (IKCameraDeviceView cameraDeviceView);

		[Export ("cameraDeviceView:didDownloadFile:location:fileData:error:"), EventArgs ("IKCameraDeviceViewICCameraFileNSUrlNSDataNSError")]
		void DidDownloadFile (IKCameraDeviceView cameraDeviceView, ICCameraFile file, NSUrl url, NSData data, NSError error);

		/// <param name="cameraDeviceView">The camera device view.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Performs the asynchronous operation.</summary>
		[Export ("cameraDeviceView:didEncounterError:"), EventArgs ("IKCameraDeviceViewNSError", XmlDocs = """
			<summary>Performs the asynchronous operation.</summary>
			""")]
		void DidEncounterError (IKCameraDeviceView cameraDeviceView, NSError error);
	}

	[BaseType (typeof (NSView), Delegates = new string [] { "WeakDelegate" }, Events = new Type [] { typeof (IKDeviceBrowserViewDelegate) })]
	interface IKDeviceBrowserView {
		/// <param name="frameRect">The frame rectangle.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithFrame:")]
		NativeHandle Constructor (CGRect frameRect);

		/// <summary>Gets or sets the WeakDelegate value.</summary>
		[Export ("delegate", ArgumentSemantic.Assign), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>Gets or sets the Delegate value.</summary>
		[Wrap ("WeakDelegate")]
		IIKDeviceBrowserViewDelegate Delegate { get; set; }

		/// <summary>Gets or sets the DisplaysLocalCameras value.</summary>
		[Export ("displaysLocalCameras")]
		bool DisplaysLocalCameras { get; set; }

		/// <summary>Gets or sets the DisplaysNetworkCameras value.</summary>
		[Export ("displaysNetworkCameras")]
		bool DisplaysNetworkCameras { get; set; }

		/// <summary>Gets or sets the DisplaysLocalScanners value.</summary>
		[Export ("displaysLocalScanners")]
		bool DisplaysLocalScanners { get; set; }

		/// <summary>Gets or sets the DisplaysNetworkScanners value.</summary>
		[Export ("displaysNetworkScanners")]
		bool DisplaysNetworkScanners { get; set; }

		/// <summary>Gets or sets the Mode value.</summary>
		[Export ("mode")]
		IKDeviceBrowserViewDisplayMode Mode { get; set; }

		[Export ("selectedDevice")]
		ICDevice SelectedDevice { get; }
	}

	interface IIKDeviceBrowserViewDelegate { }

	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface IKDeviceBrowserViewDelegate {
		[Abstract]
		[Export ("deviceBrowserView:selectionDidChange:"), EventArgs ("IKDeviceBrowserViewICDevice")]
		void SelectionDidChange (IKDeviceBrowserView deviceBrowserView, ICDevice device);

		/// <param name="deviceBrowserView">The device browser view.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Performs the asynchronous operation.</summary>
		[Export ("deviceBrowserView:didEncounterError:"), EventArgs ("IKDeviceBrowserViewNSError", XmlDocs = """
			<summary>Performs the asynchronous operation.</summary>
			""")]
		void DidEncounterError (IKDeviceBrowserView deviceBrowserView, NSError error);
	}

	[BaseType (typeof (NSPanel))]
	interface IKFilterBrowserPanel {
		/// <param name="styleMask">The style mask.</param>
		///         <summary>Performs the create operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("filterBrowserPanelWithStyleMask:")]
		IKFilterBrowserPanel Create (IKFilterBrowserPanelStyleMask styleMask);

		/// <summary>Gets the FilterName value.</summary>
		[Export ("filterName")]
		string FilterName { get; }

		//FIXME - can we do this in a more C#ish way.
		/// <param name="options">The options.</param>
		///         <param name="modelessDelegate">The modeless delegate.</param>
		///         <param name="didEndSelector">The selector to call when the sheet ends.</param>
		///         <param name="contextInfo">The context info.</param>
		///         <summary>Performs the begin operation.</summary>
		[Export ("beginWithOptions:modelessDelegate:didEndSelector:contextInfo:")]
		void Begin (NSDictionary options, NSObject modelessDelegate, Selector didEndSelector, IntPtr contextInfo);

		/// <param name="options">The options.</param>
		///         <param name="docWindow">The document window.</param>
		///         <param name="modalDelegate">The modal delegate.</param>
		///         <param name="didEndSelector">The selector to call when the sheet ends.</param>
		///         <param name="contextInfo">The context info.</param>
		///         <summary>Performs the begin sheet operation.</summary>
		[Export ("beginSheetWithOptions:modalForWindow:modalDelegate:didEndSelector:contextInfo:")]
		void BeginSheet (NSDictionary options, NSWindow docWindow, NSObject modalDelegate, Selector didEndSelector, IntPtr contextInfo);

		/// <param name="options">The options.</param>
		///         <summary>Performs the run modal operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("runModalWithOptions:")]
		int RunModal (NSDictionary options); /* int, not NSInteger */

		/// <param name="options">The options.</param>
		///         <summary>Performs the filter browser view operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("filterBrowserViewWithOptions:")]
		IKFilterBrowserView FilterBrowserView (NSDictionary options);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the finish operation.</summary>
		[Export ("finish:")]
		void Finish (NSObject sender);

		//Check - Do we need Notifications strings?
		[Notification]
		[Field ("IKFilterBrowserFilterSelectedNotification")]
		NSString FilterSelectedNotification { get; }

		[Notification]
		[Field ("IKFilterBrowserFilterDoubleClickNotification")]
		NSString FilterDoubleClickNotification { get; }

		[Notification]
		[Field ("IKFilterBrowserWillPreviewFilterNotification")]
		NSString WillPreviewFilterNotification { get; }

		//Dictionary Keys
		/// <summary>Gets the ShowCategories key constant.</summary>
		[Field ("IKFilterBrowserShowCategories")]
		NSString ShowCategories { get; }

		/// <summary>Gets the ShowPreview key constant.</summary>
		[Field ("IKFilterBrowserShowPreview")]
		NSString ShowPreview { get; }

		/// <summary>Gets the ExcludeCategories key constant.</summary>
		[Field ("IKFilterBrowserExcludeCategories")]
		NSString ExcludeCategories { get; }

		/// <summary>Gets the ExcludeFilters key constant.</summary>
		[Field ("IKFilterBrowserExcludeFilters")]
		NSString ExcludeFilters { get; }

		/// <summary>Gets the DefaultInputImage key constant.</summary>
		[Field ("IKFilterBrowserDefaultInputImage")]
		NSString DefaultInputImage { get; }
	}

	[BaseType (typeof (NSView))]
	interface IKFilterBrowserView {
		/// <param name="frameRect">The frame rectangle.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithFrame:")]
		NativeHandle Constructor (CGRect frameRect);

		/// <param name="showPreview">Whether to show a preview.</param>
		///         <summary>Performs the set preview state operation.</summary>
		[Export ("setPreviewState:")]
		void SetPreviewState (bool showPreview);

		/// <summary>Gets the FilterName value.</summary>
		[Export ("filterName")]
		string FilterName { get; }
	}

	//This protocol is an addition to CIFilter.  It is implemented by any filter that provides its own user interface.
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface IKFilterCustomUIProvider {
		// The Apple documentation says the native implementation of CIFilter.GetFilterUIView will call
		// this method (if it exists). This means that This method should not be called GetFilterUIView
		// (because it seems like you shouldn't override CIFilter.GetFilterUIView, and implementing
		// IIKFilterCustomUIProvider.GetFilterUIView in a CIFilter subclass without overriding CIFilter.GetFilterUIView
		// just turns ugly). So rename this for new-style assemblies to ProvideFilterUIView.
		/// <param name="configurationOptions">The configuration options.</param>
		///         <param name="excludedKeys">The keys to exclude.</param>
		///         <summary>Performs the provide filter u i view operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Abstract]
		[Export ("provideViewForUIConfiguration:excludedKeys:")]
		IKFilterUIView ProvideFilterUIView (NSDictionary configurationOptions, [NullAllowed] NSArray excludedKeys);

		//UIConfiguration keys for NSDictionary
		/// <summary>Gets the SizeFlavor key constant.</summary>
		[Field ("IKUISizeFlavor")]
		NSString SizeFlavor { get; }

		/// <summary>Gets the SizeMini key constant.</summary>
		[Field ("IKUISizeMini")]
		NSString SizeMini { get; }

		/// <summary>Gets the SizeSmall key constant.</summary>
		[Field ("IKUISizeSmall")]
		NSString SizeSmall { get; }

		/// <summary>Gets the SizeRegular key constant.</summary>
		[Field ("IKUISizeRegular")]
		NSString SizeRegular { get; }

		/// <summary>Gets the MaxSize key constant.</summary>
		[Field ("IKUImaxSize")]
		NSString MaxSize { get; }

		/// <summary>Gets the FlavorAllowFallback key constant.</summary>
		[Field ("IKUIFlavorAllowFallback")]
		NSString FlavorAllowFallback { get; }
	}

	[BaseType (typeof (NSView))]
	interface IKFilterUIView {
		/// <param name="frameRect">The frame rectangle.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithFrame:")]
		NativeHandle Constructor (CGRect frameRect);

		/// <param name="frame">The frame rectangle.</param>
		/// <param name="filter">The filter.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithFrame:filter:")]
		NativeHandle Constructor (CGRect frame, CIFilter filter);

		/// <summary>Gets the Filter value.</summary>
		[Export ("filter")]
		CIFilter Filter { get; }

		/// <summary>Gets the ObjectController value.</summary>
		[Export ("objectController")]
		NSObjectController ObjectController { get; }

		/// <param name="frame">The frame rectangle.</param>
		///         <param name="filter">The filter.</param>
		///         <summary>Performs the create operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("viewWithFrame:filter:")]
		IKFilterUIView Create (CGRect frame, CIFilter filter);
	}

	[BaseType (typeof (NSObject))]
	interface IKImageBrowserCell {
		/// <summary>Gets the ImageBrowserView value.</summary>
		[Export ("imageBrowserView")]
		IKImageBrowserView ImageBrowserView { get; }

		/// <summary>Gets the RepresentedItem value.</summary>
		[Export ("representedItem")]
		NSObject RepresentedItem { get; }

		/// <summary>Gets the IndexOfRepresentedItem value.</summary>
		[Export ("indexOfRepresentedItem")]
		nint IndexOfRepresentedItem { get; }

		/// <summary>Gets the Frame value.</summary>
		[Export ("frame")]
		CGRect Frame { get; }

		/// <summary>Gets the ImageContainerFrame value.</summary>
		[Export ("imageContainerFrame")]
		CGRect ImageContainerFrame { get; }

		/// <summary>Gets the ImageFrame value.</summary>
		[Export ("imageFrame")]
		CGRect ImageFrame { get; }

		/// <summary>Gets the SelectionFrame value.</summary>
		[Export ("selectionFrame")]
		CGRect SelectionFrame { get; }

		/// <summary>Gets the TitleFrame value.</summary>
		[Export ("titleFrame")]
		CGRect TitleFrame { get; }

		/// <summary>Gets the SubtitleFrame value.</summary>
		[Export ("subtitleFrame")]
		CGRect SubtitleFrame { get; }

		/// <summary>Gets the ImageAlignment value.</summary>
		[Export ("imageAlignment")]
		NSImageAlignment ImageAlignment { get; }

		/// <summary>Gets the IsSelected value.</summary>
		[Export ("isSelected")]
		bool IsSelected { get; }

		/// <summary>Gets the CellState value.</summary>
		[Export ("cellState")]
		IKImageBrowserCellState CellState { get; }

		/// <summary>Gets the Opacity value.</summary>
		[Export ("opacity")]
		nfloat Opacity { get; }

		/// <param name="layerType">The layer type.</param>
		///         <summary>Performs the layer operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("layerForType:")]
		CALayer Layer (string layerType);

		// layerType is one of the following
		/// <summary>Gets the BackgroundLayer key constant.</summary>
		[Field ("IKImageBrowserCellBackgroundLayer")]
		NSString BackgroundLayer { get; }

		/// <summary>Gets the ForegroundLayer key constant.</summary>
		[Field ("IKImageBrowserCellForegroundLayer")]
		NSString ForegroundLayer { get; }

		/// <summary>Gets the SelectionLayer key constant.</summary>
		[Field ("IKImageBrowserCellSelectionLayer")]
		NSString SelectionLayer { get; }

		/// <summary>Gets the PlaceHolderLayer key constant.</summary>
		[Field ("IKImageBrowserCellPlaceHolderLayer")]
		NSString PlaceHolderLayer { get; }
	}

	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'NSCollectionView' instead.")]
	[BaseType (typeof (NSView), Delegates = new string [] { "WeakDelegate" }, Events = new Type [] { typeof (IKImageBrowserDelegate) })]
	interface IKImageBrowserView : NSDraggingSource {
		//@category IKImageBrowserView (IKMainMethods)
		/// <param name="frame">The frame rectangle.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithFrame:")]
		NativeHandle Constructor (CGRect frame);

		//Having a weak and strong datasource seems to work.
		/// <summary>Gets or sets the WeakDataSource value.</summary>
		[Export ("dataSource", ArgumentSemantic.Assign), NullAllowed]
		NSObject WeakDataSource { get; set; }

		/// <summary>Gets or sets the DataSource value.</summary>
		[Wrap ("WeakDataSource")]
		IIKImageBrowserDataSource DataSource { get; set; }

		/// <summary>Performs the reload data operation.</summary>
		[Export ("reloadData")]
		void ReloadData ();

		/// <summary>Gets or sets the WeakDelegate value.</summary>
		[Export ("delegate", ArgumentSemantic.Assign), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>Gets or sets the Delegate value.</summary>
		[Wrap ("WeakDelegate")]
		IIKImageBrowserDelegate Delegate { get; set; }

		//@category IKImageBrowserView (IKAppearance)
		/// <summary>Gets or sets the CellsStyleMask value.</summary>
		[Export ("cellsStyleMask")]
		IKCellsStyle CellsStyleMask { get; set; }

		/// <summary>Gets or sets the ConstrainsToOriginalSize value.</summary>
		[Export ("constrainsToOriginalSize")]
		bool ConstrainsToOriginalSize { get; set; }

		/// <summary>Gets or sets the BackgroundLayer value.</summary>
		[Export ("backgroundLayer")]
		CALayer BackgroundLayer { get; set; }

		/// <summary>Gets or sets the ForegroundLayer value.</summary>
		[Export ("foregroundLayer")]
		CALayer ForegroundLayer { get; set; }

		/// <param name="representedItem">The represented item.</param>
		///         <summary>Performs the new cell operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("newCellForRepresentedItem:")]
		IKImageBrowserCell NewCell (IIKImageBrowserItem representedItem);

		/// <param name="itemIndex">The item index.</param>
		/// <summary>Performs the get cell at operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("cellForItemAtIndex:")]
		IKImageBrowserCell GetCellAt (nint itemIndex);

		//@category IKImageBrowserView (IKBrowsing)
		/// <summary>Gets or sets the ZoomValue value.</summary>
		[Export ("zoomValue")]
		float ZoomValue { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the ContentResizingMask value.</summary>
		[Export ("contentResizingMask")]
		NSViewResizingMask ContentResizingMask { get; set; }

		/// <param name="index">The index.</param>
		/// <summary>Performs the scroll index to visible operation.</summary>
		[Export ("scrollIndexToVisible:")]
		void ScrollIndexToVisible (nint index);

		/// <summary>Gets or sets the CellSize value.</summary>
		[Export ("cellSize")]
		CGSize CellSize { get; set; }

		/// <summary>Gets or sets the IntercellSpacing value.</summary>
		[Export ("intercellSpacing")]
		CGSize IntercellSpacing { get; set; }

		/// <param name="point">The point.</param>
		///         <summary>Performs the get index of item operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("indexOfItemAtPoint:")]
		nint GetIndexOfItem (CGPoint point);

		/// <param name="index">The index.</param>
		/// <summary>Performs the get item frame operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("itemFrameAtIndex:")]
		CGRect GetItemFrame (nint index);

		/// <summary>Performs the get visible item indexes operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("visibleItemIndexes")]
		NSIndexSet GetVisibleItemIndexes ();

		/// <param name="rect">The rectangle.</param>
		///         <summary>Performs the get row indexes operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("rowIndexesInRect:")]
		NSIndexSet GetRowIndexes (CGRect rect);

		/// <param name="rect">The rectangle.</param>
		///         <summary>Performs the get column indexes operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("columnIndexesInRect:")]
		NSIndexSet GetColumnIndexes (CGRect rect);

		/// <param name="columnIndex">The column index.</param>
		/// <summary>Performs the get rect of column operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("rectOfColumn:")]
		CGRect GetRectOfColumn (nint columnIndex);

		/// <param name="rowIndex">The row index.</param>
		/// <summary>Performs the get rect of row operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("rectOfRow:")]
		CGRect GetRectOfRow (nint rowIndex);

		/// <summary>Gets the RowCount value.</summary>
		[Export ("numberOfRows")]
		nint RowCount { get; }

		/// <summary>Gets the ColumnCount value.</summary>
		[Export ("numberOfColumns")]
		nint ColumnCount { get; }

		/// <summary>Gets or sets the CanControlQuickLookPanel value.</summary>
		[Export ("canControlQuickLookPanel")]
		bool CanControlQuickLookPanel { get; set; }

		//@category IKImageBrowserView (IKSelectionReorderingAndGrouping)
		/// <summary>Gets the SelectionIndexes value.</summary>
		[Export ("selectionIndexes")]
		NSIndexSet SelectionIndexes { get; }

		/// <param name="indexes">The indexes to select.</param>
		///         <param name="extendSelection">Whether to extend the current selection.</param>
		///         <summary>Performs the select items at operation.</summary>
		[Export ("setSelectionIndexes:byExtendingSelection:")]
		void SelectItemsAt (NSIndexSet indexes, bool extendSelection);

		/// <summary>Gets or sets the AllowsMultipleSelection value.</summary>
		[Export ("allowsMultipleSelection")]
		bool AllowsMultipleSelection { get; set; }

		/// <summary>Gets or sets the AllowsEmptySelection value.</summary>
		[Export ("allowsEmptySelection")]
		bool AllowsEmptySelection { get; set; }

		/// <summary>Gets or sets the AllowsReordering value.</summary>
		[Export ("allowsReordering")]
		bool AllowsReordering { get; set; }

		/// <summary>Gets or sets the Animates value.</summary>
		[Export ("animates")]
		bool Animates { get; set; }

		/// <param name="index">The index.</param>
		/// <summary>Performs the expand group operation.</summary>
		[Export ("expandGroupAtIndex:")]
		void ExpandGroup (nint index);

		/// <param name="index">The index.</param>
		/// <summary>Performs the collapse group operation.</summary>
		[Export ("collapseGroupAtIndex:")]
		void CollapseGroup (nint index);

		/// <param name="index">The index.</param>
		/// <summary>Performs the is group expanded operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("isGroupExpandedAtIndex:")]
		bool IsGroupExpanded (nint index);

		//@category IKImageBrowserView (IKDragNDrop)
		/// <summary>Gets or sets the DraggingDestinationDelegate value.</summary>
		[Export ("draggingDestinationDelegate", ArgumentSemantic.Weak)]
		INSDraggingDestination DraggingDestinationDelegate { get; set; }

		/// <summary>Performs the get index at location of dropped item operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("indexAtLocationOfDroppedItem")]
		nint GetIndexAtLocationOfDroppedItem ();

		/// <summary>Performs the drop operation operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("dropOperation")]
		IKImageBrowserDropOperation DropOperation ();

		/// <summary>Gets or sets the AllowsDroppingOnItems value.</summary>
		[Export ("allowsDroppingOnItems")]
		bool AllowsDroppingOnItems { get; set; }

		/// <param name="index">The index.</param>
		/// <param name="operation">The drag operation.</param>
		/// <summary>Performs the set drop index operation.</summary>
		[Export ("setDropIndex:dropOperation:")]
		void SetDropIndex (nint index, IKImageBrowserDropOperation operation);

		// Keys for the view options, set with base.setValue
		/// <summary>Gets the BackgroundColorKey key constant.</summary>
		[Field ("IKImageBrowserBackgroundColorKey")]
		NSString BackgroundColorKey { get; }

		/// <summary>Gets the SelectionColorKey key constant.</summary>
		[Field ("IKImageBrowserSelectionColorKey")]
		NSString SelectionColorKey { get; }

		/// <summary>Gets the CellsOutlineColorKey key constant.</summary>
		[Field ("IKImageBrowserCellsOutlineColorKey")]
		NSString CellsOutlineColorKey { get; }

		/// <summary>Gets the CellsTitleAttributesKey key constant.</summary>
		[Field ("IKImageBrowserCellsTitleAttributesKey")]
		NSString CellsTitleAttributesKey { get; }

		/// <summary>Gets the CellsHighlightedTitleAttributesKey key constant.</summary>
		[Field ("IKImageBrowserCellsHighlightedTitleAttributesKey")]
		NSString CellsHighlightedTitleAttributesKey { get; }

		/// <summary>Gets the CellsSubtitleAttributesKey key constant.</summary>
		[Field ("IKImageBrowserCellsSubtitleAttributesKey")]
		NSString CellsSubtitleAttributesKey { get; }
	}

	interface IIKImageBrowserDataSource { }

	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol (IsInformal = true)]
	interface IKImageBrowserDataSource {
		/// <param name="aBrowser">The image browser.</param>
		///         <summary>Performs the item count operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Abstract]
		[Export ("numberOfItemsInImageBrowser:")]
		nint ItemCount (IKImageBrowserView aBrowser);

		/// <param name="aBrowser">The image browser.</param>
		/// <param name="index">The index.</param>
		/// <summary>Performs the get item operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Abstract]
		[Export ("imageBrowser:itemAtIndex:")]
		IIKImageBrowserItem GetItem (IKImageBrowserView aBrowser, nint index);

		/// <param name="aBrowser">The image browser.</param>
		///         <param name="indexes">The indexes to select.</param>
		///         <summary>Performs the remove items operation.</summary>
		[Export ("imageBrowser:removeItemsAtIndexes:")]
		void RemoveItems (IKImageBrowserView aBrowser, NSIndexSet indexes);

		/// <param name="aBrowser">The image browser.</param>
		/// <param name="indexes">The indexes to select.</param>
		/// <param name="destinationIndex">The destination index.</param>
		/// <summary>Performs the move items operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("imageBrowser:moveItemsAtIndexes:toIndex:")]
		bool MoveItems (IKImageBrowserView aBrowser, NSIndexSet indexes, nint destinationIndex);

		/// <param name="aBrowser">The image browser.</param>
		///         <param name="itemIndexes">The item indexes.</param>
		///         <param name="pasteboard">The pasteboard.</param>
		///         <summary>Performs the write items to pasteboard operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("imageBrowser:writeItemsAtIndexes:toPasteboard:")]
		nint WriteItemsToPasteboard (IKImageBrowserView aBrowser, NSIndexSet itemIndexes, NSPasteboard pasteboard);

		/// <param name="aBrowser">The image browser.</param>
		///         <summary>Performs the group count operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("numberOfGroupsInImageBrowser:")]
		nint GroupCount (IKImageBrowserView aBrowser);

		/// <param name="aBrowser">The image browser.</param>
		/// <param name="index">The index.</param>
		/// <summary>Performs the get group operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("imageBrowser:groupAtIndex:")]
		NSDictionary GetGroup (IKImageBrowserView aBrowser, nint index);

		// Keys for Dictionary returned by GetGroup
		/// <summary>Gets the GroupRangeKey key constant.</summary>
		[Field ("IKImageBrowserGroupRangeKey")]
		NSString GroupRangeKey { get; }

		/// <summary>Gets the GroupBackgroundColorKey key constant.</summary>
		[Field ("IKImageBrowserGroupBackgroundColorKey")]
		NSString GroupBackgroundColorKey { get; }

		/// <summary>Gets the GroupTitleKey key constant.</summary>
		[Field ("IKImageBrowserGroupTitleKey")]
		NSString GroupTitleKey { get; }

		/// <summary>Gets the GroupStyleKey key constant.</summary>
		[Field ("IKImageBrowserGroupStyleKey")]
		NSString GroupStyleKey { get; }

		/// <summary>Gets the GroupHeaderLayer key constant.</summary>
		[Field ("IKImageBrowserGroupHeaderLayer")]
		NSString GroupHeaderLayer { get; }

		/// <summary>Gets the GroupFooterLayer key constant.</summary>
		[Field ("IKImageBrowserGroupFooterLayer")]
		NSString GroupFooterLayer { get; }
	}

	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol (IsInformal = true)]
	interface IKImageBrowserItem {
		/// <summary>Gets the ImageUID value.</summary>
		[Abstract]
		[Export ("imageUID")]
		string ImageUID { get; }

		/// <summary>Gets the ImageRepresentationType key constant.</summary>
		[Abstract]
		[Export ("imageRepresentationType")]
		NSString ImageRepresentationType { get; }

		//possible strings returned by ImageRepresentationType
		/// <summary>Gets the PathRepresentationType key constant.</summary>
		[Field ("IKImageBrowserPathRepresentationType")]
		NSString PathRepresentationType { get; }

		/// <summary>Gets the NSURLRepresentationType key constant.</summary>
		[Field ("IKImageBrowserNSURLRepresentationType")]
		NSString NSURLRepresentationType { get; }

		/// <summary>Gets the NSImageRepresentationType key constant.</summary>
		[Field ("IKImageBrowserNSImageRepresentationType")]
		NSString NSImageRepresentationType { get; }

		/// <summary>Gets the CGImageRepresentationType key constant.</summary>
		[Field ("IKImageBrowserCGImageRepresentationType")]
		NSString CGImageRepresentationType { get; }

		/// <summary>Gets the CGImageSourceRepresentationType key constant.</summary>
		[Field ("IKImageBrowserCGImageSourceRepresentationType")]
		NSString CGImageSourceRepresentationType { get; }

		/// <summary>Gets the NSDataRepresentationType key constant.</summary>
		[Field ("IKImageBrowserNSDataRepresentationType")]
		NSString NSDataRepresentationType { get; }

		/// <summary>Gets the NSBitmapImageRepresentationType key constant.</summary>
		[Field ("IKImageBrowserNSBitmapImageRepresentationType")]
		NSString NSBitmapImageRepresentationType { get; }

		/// <summary>Gets the QTMovieRepresentationType key constant.</summary>
		[Field ("IKImageBrowserQTMovieRepresentationType")]
		NSString QTMovieRepresentationType { get; }

		/// <summary>Gets the QTMoviePathRepresentationType key constant.</summary>
		[Field ("IKImageBrowserQTMoviePathRepresentationType")]
		NSString QTMoviePathRepresentationType { get; }

		/// <summary>Gets the QCCompositionRepresentationType key constant.</summary>
		[Field ("IKImageBrowserQCCompositionRepresentationType")]
		NSString QCCompositionRepresentationType { get; }

		/// <summary>Gets the QCCompositionPathRepresentationType key constant.</summary>
		[Field ("IKImageBrowserQCCompositionPathRepresentationType")]
		NSString QCCompositionPathRepresentationType { get; }

		/// <summary>Gets the QuickLookPathRepresentationType key constant.</summary>
		[Field ("IKImageBrowserQuickLookPathRepresentationType")]
		NSString QuickLookPathRepresentationType { get; }

		/// <summary>Gets the IconRefPathRepresentationType key constant.</summary>
		[Field ("IKImageBrowserIconRefPathRepresentationType")]
		NSString IconRefPathRepresentationType { get; }

		/// <summary>Gets the IconRefRepresentationType key constant.</summary>
		[Field ("IKImageBrowserIconRefRepresentationType")]
		NSString IconRefRepresentationType { get; }

		/// <summary>Gets the PDFPageRepresentationType key constant.</summary>
		[Field ("IKImageBrowserPDFPageRepresentationType")]
		NSString PDFPageRepresentationType { get; }

		/// <summary>Gets the ImageRepresentation value.</summary>
		[Abstract]
		[Export ("imageRepresentation")]
		NSObject ImageRepresentation { get; }

		/// <summary>Gets the ImageVersion value.</summary>
		[Export ("imageVersion")]
		nint ImageVersion { get; }

		/// <summary>Gets the ImageTitle value.</summary>
		[Export ("imageTitle")]
		string ImageTitle { get; }

		/// <summary>Gets the ImageSubtitle value.</summary>
		[Export ("imageSubtitle")]
		string ImageSubtitle { get; }

		/// <summary>Gets the IsSelectable value.</summary>
		[Export ("isSelectable")]
		bool IsSelectable { get; }
	}

	interface IIKImageBrowserItem { }

	interface IIKImageBrowserDelegate { }

	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol (IsInformal = true)]
	interface IKImageBrowserDelegate {
		/// <param name="browser">The image browser.</param>
		///         <summary>Performs the asynchronous operation.</summary>
		[Export ("imageBrowserSelectionDidChange:"), EventArgs ("IKImageBrowserView", XmlDocs = """
			<summary>Performs the asynchronous operation.</summary>
			""")]
		void SelectionDidChange (IKImageBrowserView browser);

		/// <param name="browser">The image browser.</param>
		/// <param name="index">The index.</param>
		/// <summary>Performs the be operation.</summary>
		[Export ("imageBrowser:cellWasDoubleClickedAtIndex:"), EventArgs ("IKImageBrowserViewIndex", XmlDocs = """
			<summary>Performs the asynchronous operation.</summary>
			""")]
		void CellWasDoubleClicked (IKImageBrowserView browser, nint index);

		/// <param name="browser">The image browser.</param>
		/// <param name="index">The index.</param>
		/// <param name="nsevent">The event.</param>
		/// <summary>Performs the be operation.</summary>
		[Export ("imageBrowser:cellWasRightClickedAtIndex:withEvent:"), EventArgs ("IKImageBrowserViewIndexEvent", XmlDocs = """
			<summary>Performs the asynchronous operation.</summary>
			""")]
		void CellWasRightClicked (IKImageBrowserView browser, nint index, NSEvent nsevent);

		/// <param name="browser">The image browser.</param>
		///         <param name="nsevent">The event.</param>
		///         <summary>Performs the asynchronous operation.</summary>
		[Export ("imageBrowser:backgroundWasRightClickedWithEvent:"), EventArgs ("IKImageBrowserViewEvent", XmlDocs = """
			<summary>Performs the asynchronous operation.</summary>
			""")]
		void BackgroundWasRightClicked (IKImageBrowserView browser, NSEvent nsevent);
	}

	[BaseType (typeof (NSPanel))]
	[DisableDefaultCtor] // crash when disposed, sharedImageEditPanel must be used
	interface IKImageEditPanel {
		/// <summary>Gets the SharedPanel value.</summary>
		[Static]
		[Export ("sharedImageEditPanel")]
		IKImageEditPanel SharedPanel { get; }

		/// <summary>Gets or sets the DataSource value.</summary>
		[Export ("dataSource", ArgumentSemantic.Assign), NullAllowed]
		IIKImageEditPanelDataSource DataSource { get; set; }

#if !XAMCORE_5_0
		/// <summary>Gets the filterArray value.</summary>
		[Obsolete ("Use the 'FilterArray' property instead.")]
		[Wrap ("FilterArray", IsVirtual = true)]
		NSArray filterArray { get; }
#endif

		[Export ("filterArray")]
		NSArray FilterArray { get; }

		/// <summary>Performs the reload data operation.</summary>
		[Export ("reloadData")]
		void ReloadData ();
	}

	interface IIKImageEditPanelDataSource { }

	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface IKImageEditPanelDataSource {
		/// <summary>Gets the Image value.</summary>
		[Abstract]
		[Export ("image")]
		CGImage Image { get; }

		/// <param name="image">The image.</param>
		///         <param name="metaData">The metadata dictionary.</param>
		///         <summary>Performs the set image and properties operation.</summary>
		[Abstract]
		[Export ("setImage:imageProperties:")]
		void SetImageAndProperties (CGImage image, NSDictionary metaData);

		/// <param name="maximumSize">The maximum size.</param>
		///         <summary>Performs the get thumbnail operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("thumbnailWithMaximumSize:")]
		CGImage GetThumbnail (CGSize maximumSize);

		/// <summary>Gets the ImageProperties value.</summary>
		[Export ("imageProperties")]
		NSDictionary ImageProperties { get; }

		/// <summary>Gets the HasAdjustMode value.</summary>
		[Export ("hasAdjustMode")]
		bool HasAdjustMode { get; }

		/// <summary>Gets the HasEffectsMode value.</summary>
		[Export ("hasEffectsMode")]
		bool HasEffectsMode { get; }

		/// <summary>Gets the HasDetailsMode value.</summary>
		[Export ("hasDetailsMode")]
		bool HasDetailsMode { get; }
	}

	[BaseType (typeof (NSView))]
	interface IKImageView {
		/// <param name="frameRect">The frame rectangle.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithFrame:")]
		NativeHandle Constructor (CGRect frameRect);

		//There is no protocol for this delegate.  used to respond to messages in the responder chain
		/// <summary>Gets or sets the Delegate value.</summary>
		[Export ("delegate", ArgumentSemantic.Assign), NullAllowed]
		NSObject Delegate { get; set; }

		/// <summary>Gets or sets the ZoomFactor value.</summary>
		[Export ("zoomFactor")]
		nfloat ZoomFactor { get; set; }

		/// <summary>Gets or sets the RotationAngle value.</summary>
		[Export ("rotationAngle")]
		nfloat RotationAngle { get; set; }

		/// <summary>Gets or sets the CurrentToolMode value.</summary>
		[Export ("currentToolMode")]
		string CurrentToolMode { get; set; }

		/// <summary>Gets or sets the Autoresizes value.</summary>
		[Export ("autoresizes")]
		bool Autoresizes { get; set; }

		/// <summary>Gets or sets the HasHorizontalScroller value.</summary>
		[Export ("hasHorizontalScroller")]
		bool HasHorizontalScroller { get; set; }

		/// <summary>Gets or sets the HasVerticalScroller value.</summary>
		[Export ("hasVerticalScroller")]
		bool HasVerticalScroller { get; set; }

		/// <summary>Gets or sets the AutohidesScrollers value.</summary>
		[Export ("autohidesScrollers")]
		bool AutohidesScrollers { get; set; }

		/// <summary>Gets or sets the SupportsDragAndDrop value.</summary>
		[Export ("supportsDragAndDrop")]
		bool SupportsDragAndDrop { get; set; }

		/// <summary>Gets or sets the Editable value.</summary>
		[Export ("editable")]
		bool Editable { get; set; }

		/// <summary>Gets or sets the DoubleClickOpensImageEditPanel value.</summary>
		[Export ("doubleClickOpensImageEditPanel")]
		bool DoubleClickOpensImageEditPanel { get; set; }

		/// <summary>Gets or sets the ImageCorrection value.</summary>
		[Export ("imageCorrection", ArgumentSemantic.Assign)]
		CIFilter ImageCorrection { get; set; }

		/// <summary>Gets or sets the BackgroundColor value.</summary>
		[Export ("backgroundColor", ArgumentSemantic.Assign)]
		NSColor BackgroundColor { get; set; }

		[Export ("setImage:imageProperties:")]
		void SetImage (CGImage image, NSDictionary metaData);

		/// <param name="url">The URL.</param>
		///         <summary>Performs the set image with u r l operation.</summary>
		[Export ("setImageWithURL:")]
		void SetImageWithURL (NSUrl url);

		/// <summary>Gets the Image value.</summary>
		[Export ("image")]
		CGImage Image { get; }

		/// <summary>Gets the ImageSize value.</summary>
		[Export ("imageSize")]
		CGSize ImageSize { get; }

		/// <summary>Gets the ImageProperties value.</summary>
		[Export ("imageProperties")]
		NSDictionary ImageProperties { get; }

		/// <param name="rotationAngle">The rotation angle.</param>
		/// <param name="centerPoint">The center point.</param>
		/// <summary>Performs the set rotation operation.</summary>
		[Export ("setRotationAngle:centerPoint:")]
		void SetRotation (nfloat rotationAngle, CGPoint centerPoint);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the rotate image left operation.</summary>
		[Export ("rotateImageLeft:")]
		void RotateImageLeft (NSObject sender);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the rotate image right operation.</summary>
		[Export ("rotateImageRight:")]
		void RotateImageRight (NSObject sender);

		/// <param name="zoomFactor">The zoom factor.</param>
		/// <param name="centerPoint">The center point.</param>
		/// <summary>Performs the set image zoom factor operation.</summary>
		[Export ("setImageZoomFactor:centerPoint:")]
		void SetImageZoomFactor (nfloat zoomFactor, CGPoint centerPoint);

		/// <param name="rect">The rectangle.</param>
		///         <summary>Performs the zoom image to rect operation.</summary>
		[Export ("zoomImageToRect:")]
		void ZoomImageToRect (CGRect rect);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the zoom image to fit operation.</summary>
		[Export ("zoomImageToFit:")]
		void ZoomImageToFit (NSObject sender);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the zoom image to actual size operation.</summary>
		[Export ("zoomImageToActualSize:")]
		void ZoomImageToActualSize (NSObject sender);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the zoom in operation.</summary>
		[Export ("zoomIn:")]
		void ZoomIn (NSObject sender);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the zoom out operation.</summary>
		[Export ("zoomOut:")]
		void ZoomOut (NSObject sender);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the flip image horizontal operation.</summary>
		[Export ("flipImageHorizontal:")]
		void FlipImageHorizontal (NSObject sender);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the flip image vertical operation.</summary>
		[Export ("flipImageVertical:")]
		void FlipImageVertical (NSObject sender);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the crop operation.</summary>
		[Export ("crop:")]
		void Crop (NSObject sender);

		/// <param name="layer">The layer.</param>
		///         <param name="layerType">The layer type.</param>
		///         <summary>Performs the set overlay operation.</summary>
		[Export ("setOverlay:forType:")]
		void SetOverlay (CALayer layer, string layerType);

		/// <param name="layerType">The layer type.</param>
		///         <summary>Performs the get overlay operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("overlayForType:")]
		CALayer GetOverlay (string layerType);

		/// <param name="point">The point.</param>
		///         <summary>Performs the scroll to operation.</summary>
		[Export ("scrollToPoint:")]
		void ScrollTo (CGPoint point);

		/// <param name="rect">The rectangle.</param>
		///         <summary>Performs the scroll to operation.</summary>
		[Export ("scrollToRect:")]
		void ScrollTo (CGRect rect);

		/// <param name="viewPoint">The point in view coordinates.</param>
		///         <summary>Performs the convert view point to image point operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("convertViewPointToImagePoint:")]
		CGPoint ConvertViewPointToImagePoint (CGPoint viewPoint);

		/// <param name="viewRect">The rectangle in view coordinates.</param>
		///         <summary>Performs the convert view rect to image rect operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("convertViewRectToImageRect:")]
		CGRect ConvertViewRectToImageRect (CGRect viewRect);

		/// <param name="imagePoint">The point in image coordinates.</param>
		///         <summary>Performs the convert image point to view point operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("convertImagePointToViewPoint:")]
		CGPoint ConvertImagePointToViewPoint (CGPoint imagePoint);

		/// <param name="imageRect">The rectangle in image coordinates.</param>
		///         <summary>Performs the convert image rect to view rect operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("convertImageRectToViewRect:")]
		CGRect ConvertImageRectToViewRect (CGRect imageRect);
	}

	[BaseType (typeof (NSPanel))]
	interface IKPictureTaker {
		/// <summary>Gets the SharedPictureTaker value.</summary>
		[Static]
		[Export ("pictureTaker")]
		IKPictureTaker SharedPictureTaker { get; }

		/// <summary>Performs the run modal operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("runModal")]
		nint RunModal ();

		//FIXME - Yuck.  What can I do to fix these three methods?
		/// <param name="aDelegate">The delegate.</param>
		///         <param name="didEndSelector">The selector to call when the sheet ends.</param>
		///         <param name="contextInfo">The context info.</param>
		///         <summary>Performs the begin picture taker operation.</summary>
		[Export ("beginPictureTakerWithDelegate:didEndSelector:contextInfo:")]
		void BeginPictureTaker (NSObject aDelegate, Selector didEndSelector, IntPtr contextInfo);

		/// <param name="aWindow">The window.</param>
		///         <param name="aDelegate">The delegate.</param>
		///         <param name="didEndSelector">The selector to call when the sheet ends.</param>
		///         <param name="contextInfo">The context info.</param>
		///         <summary>Performs the begin picture taker sheet operation.</summary>
		[Export ("beginPictureTakerSheetForWindow:withDelegate:didEndSelector:contextInfo:")]
		void BeginPictureTakerSheet (NSWindow aWindow, NSObject aDelegate, Selector didEndSelector, IntPtr contextInfo);

		/// <param name="aView">The view.</param>
		///         <param name="aDelegate">The delegate.</param>
		///         <param name="didEndSelector">The selector to call when the sheet ends.</param>
		///         <param name="contextInfo">The context info.</param>
		///         <summary>Performs the pop up recents menu operation.</summary>
		[Export ("popUpRecentsMenuForView:withDelegate:didEndSelector:contextInfo:")]
		void PopUpRecentsMenu (NSView aView, NSObject aDelegate, Selector didEndSelector, IntPtr contextInfo);

		/// <summary>Gets or sets the InputImage value.</summary>
		[Export ("inputImage")]
		NSImage InputImage { get; set; }

		/// <summary>Performs the get output image operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("outputImage")]
		NSImage GetOutputImage ();

		/// <summary>Gets or sets the Mirroring value.</summary>
		[Export ("mirroring")]
		bool Mirroring { get; set; }

		//Use with NSKeyValueCoding to customize the pictureTaker panel
		/// <summary>Gets the AllowsVideoCaptureKey key constant.</summary>
		[Field ("IKPictureTakerAllowsVideoCaptureKey")]
		NSString AllowsVideoCaptureKey { get; }

		/// <summary>Gets the AllowsFileChoosingKey key constant.</summary>
		[Field ("IKPictureTakerAllowsFileChoosingKey")]
		NSString AllowsFileChoosingKey { get; }

		/// <summary>Gets the ShowRecentPictureKey key constant.</summary>
		[Field ("IKPictureTakerShowRecentPictureKey")]
		NSString ShowRecentPictureKey { get; }

		/// <summary>Gets the UpdateRecentPictureKey key constant.</summary>
		[Field ("IKPictureTakerUpdateRecentPictureKey")]
		NSString UpdateRecentPictureKey { get; }

		/// <summary>Gets the AllowsEditingKey key constant.</summary>
		[Field ("IKPictureTakerAllowsEditingKey")]
		NSString AllowsEditingKey { get; }

		/// <summary>Gets the ShowEffectsKey key constant.</summary>
		[Field ("IKPictureTakerShowEffectsKey")]
		NSString ShowEffectsKey { get; }

		/// <summary>Gets the InformationalTextKey key constant.</summary>
		[Field ("IKPictureTakerInformationalTextKey")]
		NSString InformationalTextKey { get; }

		/// <summary>Gets the ImageTransformsKey key constant.</summary>
		[Field ("IKPictureTakerImageTransformsKey")]
		NSString ImageTransformsKey { get; }

		/// <summary>Gets the OutputImageMaxSizeKey key constant.</summary>
		[Field ("IKPictureTakerOutputImageMaxSizeKey")]
		NSString OutputImageMaxSizeKey { get; }

		/// <summary>Gets the CropAreaSizeKey key constant.</summary>
		[Field ("IKPictureTakerCropAreaSizeKey")]
		NSString CropAreaSizeKey { get; }

		/// <summary>Gets the ShowAddressBookPictureKey key constant.</summary>
		[Field ("IKPictureTakerShowAddressBookPictureKey")]
		NSString ShowAddressBookPictureKey { get; }

		/// <summary>Gets the ShowEmptyPictureKey key constant.</summary>
		[Field ("IKPictureTakerShowEmptyPictureKey")]
		NSString ShowEmptyPictureKey { get; }

		/// <summary>Gets the RemainOpenAfterValidateKey key constant.</summary>
		[Field ("IKPictureTakerRemainOpenAfterValidateKey")]
		NSString RemainOpenAfterValidateKey { get; }
	}

	[BaseType (typeof (NSObject), Delegates = new string [] { "WeakDelegate" }, Events = new Type [] { typeof (IKSaveOptionsDelegate) })]
	interface IKSaveOptions {
		/// <summary>Gets the ImageProperties value.</summary>
		[Export ("imageProperties")]
		NSDictionary ImageProperties { get; }

		/// <summary>Gets the ImageUTType value.</summary>
		[Export ("imageUTType")]
		string ImageUTType { get; }

		/// <summary>Gets the UserSelection value.</summary>
		[Export ("userSelection")]
		NSDictionary UserSelection { get; }

		/// <summary>Gets or sets the WeakDelegate value.</summary>
		[Export ("delegate", ArgumentSemantic.Assign), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>Gets or sets the Delegate value.</summary>
		[Wrap ("WeakDelegate")]
		IIKSaveOptionsDelegate Delegate { get; set; }

		/// <param name="imageProperties">The image properties.</param>
		/// <param name="imageUTType">The uniform type identifier for the image format.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithImageProperties:imageUTType:")]
		NativeHandle Constructor (NSDictionary imageProperties, string imageUTType);

		/// <param name="savePanel">The save panel.</param>
		///         <summary>Performs the add save options to panel operation.</summary>
		[Export ("addSaveOptionsAccessoryViewToSavePanel:")]
		void AddSaveOptionsToPanel (NSSavePanel savePanel);

		/// <param name="view">The view.</param>
		///         <summary>Performs the add save options to view operation.</summary>
		[Export ("addSaveOptionsToView:")]
		void AddSaveOptionsToView (NSView view);

		[Export ("rememberLastSetting")]
		bool RememberLastSetting { get; set; }
	}

	interface IIKSaveOptionsDelegate { }

	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol (IsInformal = true)]
	interface IKSaveOptionsDelegate {
		/// <param name="saveOptions">The save options.</param>
		///         <param name="imageUTType">The uniform type identifier for the image format.</param>
		///         <summary>Performs the asynchronous operation.</summary>
		///         <returns>The result of the operation.</returns>
		[EventArgs ("", XmlDocs = """
			<summary>Performs the asynchronous operation.</summary>
			""")]
		[Export ("saveOptions:shouldShowUTType:"), DelegateName ("SaveOptionsShouldShowUTType"), DefaultValue (false)]
		bool ShouldShowType (IKSaveOptions saveOptions, string imageUTType);
	}

	[BaseType (typeof (NSView), Delegates = new string [] { "WeakDelegate" }, Events = new Type [] { typeof (IKScannerDeviceViewDelegate) })]
	interface IKScannerDeviceView {
		/// <param name="frameRect">The frame rectangle.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithFrame:")]
		NativeHandle Constructor (CGRect frameRect);

		/// <summary>Gets or sets the WeakDelegate value.</summary>
		[Export ("delegate", ArgumentSemantic.Assign), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>Gets or sets the Delegate value.</summary>
		[Wrap ("WeakDelegate")]
		IIKScannerDeviceViewDelegate Delegate { get; set; }

		[Export ("scannerDevice", ArgumentSemantic.Assign)]
		ICScannerDevice ScannerDevice { get; set; }

		/// <summary>Gets or sets the DisplayMode value.</summary>
		[Export ("mode")]
		IKScannerDeviceViewDisplayMode DisplayMode { get; set; }

		/// <summary>Gets or sets the HasDisplayModeSimple value.</summary>
		[Export ("hasDisplayModeSimple")]
		bool HasDisplayModeSimple { get; set; }

		/// <summary>Gets or sets the HasDisplayModeAdvanced value.</summary>
		[Export ("hasDisplayModeAdvanced")]
		bool HasDisplayModeAdvanced { get; set; }

		/// <summary>Gets or sets the TransferMode value.</summary>
		[Export ("transferMode")]
		IKScannerDeviceViewTransferMode TransferMode { get; set; }

		/// <summary>Gets or sets the ScanControlLabel value.</summary>
		[Export ("scanControlLabel", ArgumentSemantic.Copy)]
		string ScanControlLabel { get; set; }

		/// <summary>Gets or sets the OverviewControlLabel value.</summary>
		[Export ("overviewControlLabel", ArgumentSemantic.Copy)]
		string OverviewControlLabel { get; set; }

		/// <summary>Gets or sets the DisplaysDownloadsDirectoryControl value.</summary>
		[Export ("displaysDownloadsDirectoryControl")]
		bool DisplaysDownloadsDirectoryControl { get; set; }

		/// <summary>Gets or sets the DownloadsDirectory value.</summary>
		[Export ("downloadsDirectory", ArgumentSemantic.Retain)]
		NSUrl DownloadsDirectory { get; set; }

		/// <summary>Gets or sets the DocumentName value.</summary>
		[Export ("documentName", ArgumentSemantic.Copy)]
		string DocumentName { get; set; }

		/// <summary>Gets or sets the DisplaysPostProcessApplicationControl value.</summary>
		[Export ("displaysPostProcessApplicationControl")]
		bool DisplaysPostProcessApplicationControl { get; set; }

		/// <summary>Gets or sets the PostProcessApplication value.</summary>
		[Export ("postProcessApplication", ArgumentSemantic.Retain)]
		NSUrl PostProcessApplication { get; set; }
	}

	interface IIKScannerDeviceViewDelegate { }

	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface IKScannerDeviceViewDelegate {
		/// <param name="scannerDeviceView">The scanner device view.</param>
		///         <param name="url">The URL.</param>
		///         <param name="data">The data.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Performs the asynchronous operation.</summary>
		[Export ("scannerDeviceView:didScanToURL:fileData:error:"), EventArgs ("IKScannerDeviceViewScan", XmlDocs = """
			<summary>Performs the asynchronous operation.</summary>
			""")]
		void DidScan (IKScannerDeviceView scannerDeviceView, NSUrl url, NSData data, NSError error);

		/// <param name="scannerDeviceView">The scanner device view.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Performs the asynchronous operation.</summary>
		[Export ("scannerDeviceView:didEncounterError:"), EventArgs ("IKScannerDeviceViewError", XmlDocs = """
			<summary>Performs the asynchronous operation.</summary>
			""")]
		void DidEncounterError (IKScannerDeviceView scannerDeviceView, NSError error);

		/// <param name="scannerDeviceView">The scanner device view.</param>
		///         <param name="url">The URL.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Performs the asynchronous operation.</summary>
		[Export ("scannerDeviceView:didScanToURL:error:"), EventArgs ("IKScannerDeviceViewScanUrl", XmlDocs = """
			<summary>Performs the asynchronous operation.</summary>
			""")]
		void DidScanToUrl (IKScannerDeviceView scannerDeviceView, NSUrl url, NSError error);

		[Export ("scannerDeviceView:didScanToBandData:scanInfo:error:"), EventArgs ("IKScannerDeviceViewScanBandData")]
		void DidScanToBandData (IKScannerDeviceView scannerDeviceView, ICScannerBandData data, NSDictionary scanInfo, NSError error);
	}

	[BaseType (typeof (NSObject))]
	interface IKSlideshow {
		/// <summary>Gets the SharedSlideshow value.</summary>
		[Static]
		[Export ("sharedSlideshow")]
		IKSlideshow SharedSlideshow { get; }

#if !XAMCORE_5_0
		/// <summary>Gets or sets the autoPlayDelay value.</summary>
		[Obsolete ("Use the 'AutoPlayDelay' property instead.")]
		[Wrap ("AutoPlayDelay", IsVirtual = true)]
		double autoPlayDelay { get; set; }
#endif

		[Export ("autoPlayDelay")]
		double AutoPlayDelay { get; set; }

		/// <param name="dataSource">The data source.</param>
		///         <param name="slideshowMode">The slideshow mode.</param>
		///         <param name="slideshowOptions">The slideshow options.</param>
		///         <summary>Performs the run slideshow operation.</summary>
		[Export ("runSlideshowWithDataSource:inMode:options:")]
		void RunSlideshow (IIKSlideshowDataSource dataSource, string slideshowMode, NSDictionary slideshowOptions);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the stop slideshow operation.</summary>
		[Export ("stopSlideshow:")]
		void StopSlideshow (NSObject sender);

		/// <summary>Performs the reload data operation.</summary>
		[Export ("reloadData")]
		void ReloadData ();

		/// <param name="index">The index.</param>
		/// <summary>Performs the reload slideshow item operation.</summary>
		[Export ("reloadSlideshowItemAtIndex:")]
		void ReloadSlideshowItem (nint index);

		/// <summary>Gets the IndexOfCurrentSlideshowItem value.</summary>
		[Export ("indexOfCurrentSlideshowItem")]
		nint IndexOfCurrentSlideshowItem { get; }

		/// <param name="applicationBundleIdentifier">The application bundle identifier.</param>
		///         <summary>Performs the can export to application operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("canExportToApplication:")]
		bool CanExportToApplication (string applicationBundleIdentifier);

		/// <param name="item">The item.</param>
		///         <param name="applicationBundleIdentifier">The application bundle identifier.</param>
		///         <summary>Performs the export slideshow itemto application operation.</summary>
		[Static]
		[Export ("exportSlideshowItem:toApplication:")]
		void ExportSlideshowItemtoApplication (NSObject item, string applicationBundleIdentifier);

		/// <summary>Gets the ModeImages key constant.</summary>
		[Field ("IKSlideshowModeImages")]
		NSString ModeImages { get; }

		/// <summary>Gets the ModePDF key constant.</summary>
		[Field ("IKSlideshowModePDF")]
		NSString ModePDF { get; }

		/// <summary>Gets the ModeOther key constant.</summary>
		[Field ("IKSlideshowModeOther")]
		NSString ModeOther { get; }

		/// <summary>Gets the WrapAround key constant.</summary>
		[Field ("IKSlideshowWrapAround")]
		NSString WrapAround { get; }

		/// <summary>Gets the StartPaused key constant.</summary>
		[Field ("IKSlideshowStartPaused")]
		NSString StartPaused { get; }

		/// <summary>Gets the StartIndex key constant.</summary>
		[Field ("IKSlideshowStartIndex")]
		NSString StartIndex { get; }

		/// <summary>Gets the Screen key constant.</summary>
		[Field ("IKSlideshowScreen")]
		NSString Screen { get; }

		/// <summary>Gets the AudioFile key constant.</summary>
		[Field ("IKSlideshowAudioFile")]
		NSString AudioFile { get; }

		/// <summary>Gets the PDFDisplayBox key constant.</summary>
		[Field ("IKSlideshowPDFDisplayBox")]
		NSString PDFDisplayBox { get; }

		/// <summary>Gets the PDFDisplayMode key constant.</summary>
		[Field ("IKSlideshowPDFDisplayMode")]
		NSString PDFDisplayMode { get; }

		/// <summary>Gets the PDFDisplaysAsBook key constant.</summary>
		[Field ("IKSlideshowPDFDisplaysAsBook")]
		NSString PDFDisplaysAsBook { get; }

		/// <summary>Gets the IPhotoBundleIdentifier key constant.</summary>
		[Field ("IK_iPhotoBundleIdentifier")]
		NSString IPhotoBundleIdentifier { get; }

		/// <summary>Gets the ApertureBundleIdentifier key constant.</summary>
		[Field ("IK_ApertureBundleIdentifier")]
		NSString ApertureBundleIdentifier { get; }

		/// <summary>Gets the MailBundleIdentifier key constant.</summary>
		[Field ("IK_MailBundleIdentifier")]
		NSString MailBundleIdentifier { get; }

		/// <summary>Gets the PhotosBundleIdentifier key constant.</summary>
		[Field ("IK_PhotosBundleIdentifier")]
		NSString PhotosBundleIdentifier { get; }
	}

	interface IIKSlideshowDataSource { }

	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface IKSlideshowDataSource {
		/// <summary>Gets the ItemCount value.</summary>
		[Abstract]
		[Export ("numberOfSlideshowItems")]
		nint ItemCount { get; }

		/// <param name="index">The index.</param>
		/// <summary>Performs the get item at operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Abstract]
		[Export ("slideshowItemAtIndex:")]
		NSObject GetItemAt (nint index);

		/// <param name="index">The index.</param>
		/// <summary>Performs the get name of item at operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("nameOfSlideshowItemAtIndex:")]
		string GetNameOfItemAt (nint index);

		/// <param name="index">The index.</param>
		/// <param name="applicationBundleIdentifier">The application bundle identifier.</param>
		/// <summary>Performs the can export item to application operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("canExportSlideshowItemAtIndex:toApplication:")]
		bool CanExportItemToApplication (nint index, string applicationBundleIdentifier);

		/// <summary>Performs the will start operation.</summary>
		[Export ("slideshowWillStart")]
		void WillStart ();

		/// <summary>Performs the did stop operation.</summary>
		[Export ("slideshowDidStop")]
		void DidStop ();

		/// <param name="newIndex">The new index.</param>
		/// <summary>Performs the did change operation.</summary>
		[Export ("slideshowDidChangeCurrentIndex:")]
		void DidChange (nint newIndex);
	}
}
