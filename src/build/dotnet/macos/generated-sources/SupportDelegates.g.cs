//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AVFoundation {
	#nullable enable
	public delegate void AVAssetImageGenerateAsynchronouslyForTimeCompletionHandler (CGImage? imageRef, CMTime actualTime, NSError? error);
	/// <param name="requestedTime">To be added.</param><param name="imageRef">To be added.</param><param name="actualTime">To be added.</param><param name="result">To be added.</param><param name="error">To be added.</param><summary>A delegate that defines the handler for <see cref="M:AVFoundation.AVAssetImageGenerator.GenerateCGImagesAsynchronously(Foundation.NSValue[],AVFoundation.AVAssetImageGeneratorCompletionHandler)" />.</summary><remarks>To be added.</remarks>
	public delegate void AVAssetImageGeneratorCompletionHandler (CMTime requestedTime, IntPtr imageRef, CMTime actualTime, AVAssetImageGeneratorResult result, NSError? error);
	public delegate void AVAssetImageGeneratorCompletionHandler2 (CMTime requestedTime, CGImage? imageRef, CMTime actualTime, AVAssetImageGeneratorResult result, NSError? error);
	public delegate void AVAssetPlaybackAssistantLoadPlaybackConfigurationOptionsHandler (String[] playbackConfigurationOptions);
	public delegate bool AVAudioApplicationSetInputMuteStateChangeHandler (bool inputShouldBeMuted);
	public delegate AVAudioBuffer AVAudioConverterInputHandler (uint inNumberOfPackets, out AVAudioConverterInputStatus outStatus);
	public delegate AVAudioEngineManualRenderingStatus AVAudioEngineManualRenderingBlock (uint numberOfFrames, AudioToolbox.AudioBuffers outBuffer, ref int outError);
	public delegate AudioToolbox.AudioBuffers AVAudioIONodeInputBlock (uint frameCount);
	public delegate void AVAudioInputNodeMutedSpeechEventListener (AVAudioVoiceProcessingSpeechActivityEvent @event);
	/// <param name="buffer">To be added.</param><param name="when">To be added.</param><summary>Delegate that receives copies of the output of a <see cref="T:AVFoundation.AVAudioNode" /></summary><remarks>To be added.</remarks>
	public delegate void AVAudioNodeTapBlock (AVAudioPcmBuffer buffer, AVAudioTime when);
	public delegate void AVAudioSequencerUserCallback (AVMusicTrack track, NSData userData, double timeStamp);
	public delegate int AVAudioSinkNodeReceiverHandlerRaw (IntPtr timestamp, uint frameCount, IntPtr inputData);
	/// <summary>The delegate that will be called in a callback from <see cref="T:AVFoundation.AVAudioSourceNode" />.</summary><returns>An OSStatus result code. Return 0 to indicate success.</returns><param name="isSilence">Indicates whether the supplied audio data only contains silence. This is a pointer to a <see cref="T:System.Byte" /> value.</param><param name="timestamp">The timestamp the audio renders (HAL time). This is a pointer to an <see cref="T:AudioToolbox.AudioTimeStamp" /> value.</param><param name="frameCount">The number of frames of audio to supply.</param><param name="outputData">The <see cref="T:AudioToolbox.AudioBuffers" /> that contains the supplied audio data when the callback returns. This is a handle for an <see cref="T:AudioToolbox.AudioBuffers" /> value.</param>
	public delegate int AVAudioSourceNodeRenderHandlerRaw (IntPtr isSilence, IntPtr timestamp, uint frameCount, IntPtr outputData);
	public delegate bool AVAudioUnitComponentFilter (AVAudioUnitComponent comp, ref bool stop);
	/// <summary>A delegate for the completion handler of <see cref="M:AVFoundation.AVCaptureStillImageOutput.CaptureStillImageAsynchronously(AVFoundation.AVCaptureConnection,AVFoundation.AVCaptureCompletionHandler)" />.</summary>
	public delegate void AVCaptureCompletionHandler (CMSampleBuffer imageDataSampleBuffer, NSError? error);
	public delegate void AVCaptureDeskViewApplicationPresentHandler (NSError? error);
	public delegate void AVCaptureIndexPickerCallback (IntPtr newValue);
	public delegate string AVCaptureIndexPickerTitleTransform (IntPtr index);
	public delegate void AVCaptureSliderCallback (float newValue);
	public delegate void AVCaptureSystemExposureBiasSliderCallback (NFloat exposureTargetBias);
	public delegate void AVCaptureSystemZoomSliderCallback (NFloat videoZoomFactor);
	/// <param name="finished">To be added.</param><summary>A delegate that defines the completion handler for various methods in <see cref="T:AVFoundation.AVPlayer" /> and <see cref="T:AVFoundation.AVPlayerItem" /></summary><remarks>To be added.</remarks>
	public delegate void AVCompletion (bool finished);
	public delegate void AVExternalStorageDeviceRequestAccessCallback (bool granted);
	public delegate void AVMusicEventEnumerationBlock (AVMusicEvent @event, out double timeStamp, out bool removeEvent);
	public delegate void AVMutableCompositionInsertHandler (NSError? error);
	public delegate void AVMutableVideoCompositionCreateApplier (AVAsynchronousCIImageFilteringRequest request);
	public delegate void AVMutableVideoCompositionCreateCallback (AVMutableVideoComposition? videoComposition, NSError? error);
	public delegate void AVPlayerItemIntegratedTimelineAddBoundaryTimeObserverCallback (bool success);
	public delegate void AVPlayerItemIntegratedTimelineAddPeriodicTimeObserverCallback (CMTime time);
	public delegate void AVPlayerItemIntegratedTimelineSeekCallback (bool success);
	/// <summary>The delegate for <see cref="AVFoundation.AVCaptureDevice.RequestAccessForMediaTypeAsync(Foundation.NSString)" />.</summary>
	public delegate void AVRequestAccessStatus (bool accessGranted);
	public delegate void AVSampleBufferGeneratorBatchMakeReadyCallback (NSError? error);
	public delegate void AVSampleBufferVideoRendererLoadVideoPerformanceMetricsCallback (AVVideoPerformanceMetrics? videoPerformanceMetrics);
	public delegate void AVSpeechSynthesisProviderOutputBlock (AVSpeechSynthesisMarker[] markers, AVSpeechSynthesisProviderRequest request);
	public delegate void AVSpeechSynthesizerBufferCallback (AVAudioBuffer buffer);
	public delegate void AVSpeechSynthesizerMarkerCallback (AVSpeechSynthesisMarker[] markers);
	public delegate void AVSpeechSynthesizerRequestPersonalVoiceAuthorizationCallback (AVSpeechSynthesisPersonalVoiceAuthorizationStatus status);
	public delegate void AVVideoCompositionCreateApplier (AVAsynchronousCIImageFilteringRequest applier);
	public delegate void AVVideoCompositionCreateCallback (AVVideoComposition? videoComposition, NSError? error);
	public delegate void AVVideoCompositionDetermineValidityCallback (bool isValid, NSError? error);
}
namespace Accessibility {
	#nullable enable
	public delegate NSString ValueDescriptionProviderHandler (double dataValue);
}
namespace Accounts {
	#nullable enable
	/// <param name="success"><see langword="true" /> if the account was removed. Otherwise, <see langword="false" />.</param><param name="error">The error that was encountered, or <see langword="null" /> if no error was encountered.</param><summary>A handler to be run when an attempt is made to remove an account from the store.</summary>
	public delegate void ACAccountStoreRemoveCompletionHandler (bool success, NSError? error);
	/// <summary>A delegate that specifies the completion handler in calls to the <see cref="M:Accounts.ACAccountStore.SaveAccount(Accounts.ACAccount,Accounts.ACAccountStoreSaveCompletionHandler)" /> method.</summary>
	public delegate void ACAccountStoreSaveCompletionHandler (bool success, NSError? error);
	/// <summary>A delegate that specifies the handler executed at the completion of calls to <see cref="Accounts.ACAccountStore.RequestAccessAsync(Accounts.ACAccountType,Foundation.NSDictionary)" />s.</summary>
	public delegate void ACRequestCompletionHandler (bool granted, NSError? error);
}
namespace AppKit {
	#nullable enable
	public delegate NSAttributedString AttributedStringForCandidateHandler (NSObject candidate, IntPtr index);
	public delegate void ContinueUserActivityRestorationHandler (INSUserActivityRestoring[] restorableObjects);
	public delegate bool DownloadFontAssetsRequestCompletionHandler (NSError error);
	public delegate bool DrawerShouldCloseDelegate (NSDrawer sender);
	public delegate bool DrawerShouldOpenDelegate (NSDrawer sender);
	public delegate CGSize DrawerWillResizeContentsDelegate (NSDrawer sender, CGSize toSize);
	public delegate void GlobalEventHandler (NSEvent theEvent);
	public delegate NSEvent LocalEventHandler (NSEvent theEvent);
	public delegate bool NSAlertPredicate (NSAlert alert);
	public delegate bool NSAnimationPredicate (NSAnimation animation);
	public delegate float NSAnimationProgress (NSAnimation animation, float progress);
	public delegate bool NSApplicationContinueUserActivity (NSApplication application, NSUserActivity userActivity, ContinueUserActivityRestorationHandler restorationHandler);
	public delegate void NSApplicationEnumerateWindowsHandler (NSWindow window, ref bool stop);
	public delegate NSError NSApplicationError (NSApplication application, NSError error);
	public delegate bool NSApplicationFile (NSApplication sender, string filename);
	public delegate bool NSApplicationFileCommand (NSObject sender, string filename);
	public delegate bool NSApplicationHandlesKey (NSApplication sender, string key);
	public delegate NSMenu NSApplicationMenu (NSApplication sender);
	public delegate bool NSApplicationPredicate (NSApplication sender);
	public delegate NSApplicationPrintReply NSApplicationPrint (NSApplication application, String[] fileNames, NSDictionary printSettings, bool showPrintPanels);
	public delegate bool NSApplicationReopen (NSApplication sender, bool hasVisibleWindows);
	public delegate NSApplicationTerminateReply NSApplicationTermination (NSApplication sender);
	public delegate bool NSApplicationUserActivityType (NSApplication application, string userActivityType);
	public delegate NSCollectionLayoutGroupCustomItem[] NSCollectionLayoutGroupCustomItemProvider (INSCollectionLayoutEnvironment layoutEnvironment);
	public delegate void NSCollectionLayoutSectionVisibleItemsInvalidationHandler (INSCollectionLayoutVisibleItem[] visibleItems, CGPoint contentOffset, INSCollectionLayoutEnvironment layoutEnvironment);
	public delegate NSCollectionLayoutSection NSCollectionViewCompositionalLayoutSectionProvider (IntPtr section, INSCollectionLayoutEnvironment layout);
	public delegate NSCollectionViewItem NSCollectionViewDiffableDataSourceItemProvider (NSCollectionView collectionView, NSIndexPath indexPath, NSObject itemIdentifierType);
	public delegate NSView NSCollectionViewDiffableDataSourceSupplementaryViewProvider (NSCollectionView collectionView, string str, NSIndexPath indexPath);
	public delegate bool NSControlCommand (NSControl control, NSTextView textView, Selector commandSelector);
	public delegate bool NSControlText (NSControl control, NSText fieldEditor);
	public delegate bool NSControlTextError (NSControl control, string str, string error);
	public delegate String[] NSControlTextFilter (NSControl control, NSTextView textView, String[] words, NSRange charRange, ref IntPtr index);
	public delegate bool NSControlTextValidation (NSControl control, NSObject objectToValidate);
	public delegate bool NSCustomImageRepDrawingHandler (CGRect dstRect);
	public delegate void NSDocumentCompletionHandler (IntPtr nsErrorPointerOrZero);
	public delegate void NSDocumentControllerOpenPanelResultHandler (IntPtr result);
	public delegate void NSDocumentControllerOpenPanelWithCompletionHandler (NSArray urlsToOpen);
	public delegate void NSDocumentLockCompletionHandler (NSError error);
	public delegate void NSDocumentLockDocumentCompletionHandler (bool didLock);
	public delegate void NSDocumentMoveCompletionHandler (bool didMove);
	public delegate void NSDocumentMoveToUrlCompletionHandler (NSError error);
	public delegate void NSDocumentUnlockCompletionHandler (NSError error);
	public delegate void NSDocumentUnlockDocumentCompletionHandler (bool didUnlock);
	public delegate void NSDraggingEnumerator (NSDraggingItem draggingItem, IntPtr idx, ref bool stop);
	public delegate NSDraggingImageComponent[] NSDraggingItemImagesContentProvider ();
	public delegate void NSEventTrackHandler (NFloat gestureAmount, NSEventPhase eventPhase, bool isComplete, ref bool stop);
	public delegate bool NSGestureEvent (NSGestureRecognizer gestureRecognizer, NSEvent theEvent);
	public delegate bool NSGestureProbe (NSGestureRecognizer gestureRecognizer);
	public delegate bool NSGesturesProbe (NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer);
	public delegate NSImage NSImageRect (NSObject sender, CGRect aRect);
	public delegate bool NSObjectPredicate (NSObject sender);
	public delegate NSComparisonResult NSOpenSaveCompare (NSSavePanel panel, string name1, string name2, bool caseSensitive);
	public delegate bool NSOpenSaveFilename (NSSavePanel panel, string fileName);
	public delegate string NSOpenSaveFilenameConfirmation (NSSavePanel panel, string filename, bool confirmed);
	public delegate bool NSOpenSavePanelUrl (NSSavePanel panel, NSUrl url);
	public delegate bool NSOpenSavePanelValidate (NSSavePanel panel, NSUrl url, out NSError? outError);
	public delegate CGRect NSPageControllerGetFrame (NSPageController pageController, NSObject targetObject);
	public delegate string NSPageControllerGetIdentifier (NSPageController pageController, NSObject targetObject);
	public delegate NSViewController NSPageControllerGetViewController (NSPageController pageController, string identifier);
	public delegate void NSPasteboardDetectMetadataCompletionHandler (global::System.Collections.Generic.Dictionary<global::AppKit.NSPasteboardMetadataType, global::UniformTypeIdentifiers.UTType>? detectedMetadata, NSError? error);
	public delegate void NSPasteboardDetectMetadataHandler (global::Foundation.NSDictionary<NSString, NSObject>? detectedMetadata, NSError? error);
	public delegate void NSPasteboardDetectPatternsCompletionHandler (global::System.Collections.Generic.HashSet<global::AppKit.NSPasteboardDetectionPattern>? detectedPatterns, NSError? error);
	public delegate void NSPasteboardDetectPatternsHandler (global::Foundation.NSSet<NSString>? detectedPatterns, NSError? error);
	public delegate void NSPasteboardDetectValuesCompletionHandler (global::System.Collections.Generic.Dictionary<global::AppKit.NSPasteboardDetectionPattern, global::DataDetection.DDMatch[]>? detectedValues, NSError? error);
	public delegate void NSPasteboardDetectValuesHandler (global::Foundation.NSDictionary<NSString, NSObject>? detectedValues, NSError? error);
	public delegate IntPtr NSRuleEditorNumberOfChildren (NSRuleEditor editor, NSObject criterion, NSRuleEditorRowType rowType);
	public delegate NSObject NSRulerEditorChildCriterion (NSRuleEditor editor, IntPtr index, NSObject criterion, NSRuleEditorRowType rowType);
	public delegate NSObject NSRulerEditorDisplayValue (NSRuleEditor editor, NSObject criterion, IntPtr row);
	public delegate NSDictionary NSRulerEditorPredicateParts (NSRuleEditor editor, NSObject criterion, NSObject value, IntPtr row);
	public delegate void NSSavePanelComplete (IntPtr result);
	public delegate NSView? NSSharingServiceAnchoringViewForSharingService (NSSharingService sharingService, ref CGRect positioningRect, ref NSRectEdge preferredEdge);
	public delegate void NSSharingServiceHandler ();
	public delegate NSSharingCollaborationModeRestriction[]? NSSharingServicePickerDelegateCollaborationModeRestrictions (NSSharingServicePicker sharingServicePicker);
	public delegate INSSharingServiceDelegate NSSharingServicePickerDelegateForSharingService (NSSharingServicePicker sharingServicePicker, NSSharingService sharingService);
	public delegate NSSharingService[] NSSharingServicePickerSharingServicesForItems (NSSharingServicePicker sharingServicePicker, NSObject[] items, NSSharingService[] proposedServices);
	public delegate CGRect NSSharingServiceSourceFrameOnScreenForShareItem (NSSharingService sharingService, INSPasteboardWriting item);
	public delegate NSWindow NSSharingServiceSourceWindowForShareItems (NSSharingService sharingService, NSObject[] items, NSSharingContentScope sharingContentScope);
	public delegate NSImage NSSharingServiceTransitionImageForShareItem (NSSharingService sharingService, INSPasteboardWriting item, CGRect contentRect);
	public delegate void NSSpellCheckerShowCorrectionIndicatorOfTypeHandler (string acceptedString);
	public delegate NSObject NSStoryboardControllerCreator (NSCoder coder);
	public delegate bool NSTabViewPredicate (NSTabView tabView, NSTabViewItem item);
	public delegate bool NSTableReorder (NSTableView tableView, IntPtr columnIndex, IntPtr newColumnIndex);
	public delegate bool NSTableViewCell (NSTableView tableView, NSCell cell, NSTableColumn tableColumn, IntPtr row);
	public delegate NSCell NSTableViewCellGetter (NSTableView tableView, NSTableColumn tableColumn, IntPtr row);
	public delegate bool NSTableViewColumnPredicate (NSTableView tableView, NSTableColumn tableColumn);
	public delegate bool NSTableViewColumnRowPredicate (NSTableView tableView, NSTableColumn tableColumn, IntPtr row);
	public delegate string NSTableViewColumnRowString (NSTableView tableView, NSTableColumn tableColumn, IntPtr row);
	public delegate NFloat NSTableViewColumnWidth (NSTableView tableView, IntPtr column);
	public delegate NSView NSTableViewDiffableDataSourceCellProvider (NSTableView tableView, NSTableColumn column, IntPtr row, NSObject itemId);
	public delegate NSTableRowView NSTableViewDiffableDataSourceRowProvider (NSTableView tableView, IntPtr row, NSObject identifier);
	public delegate NSView NSTableViewDiffableDataSourceSectionHeaderViewProvider (NSTableView tableView, IntPtr row, NSObject sectionId);
	public delegate bool NSTableViewEventString (NSTableView tableView, NSEvent theEvent, string searchString);
	public delegate NSIndexSet NSTableViewIndexFilter (NSTableView tableView, NSIndexSet proposedSelectionIndexes);
	public delegate bool NSTableViewPredicate (NSTableView tableView);
	public delegate NSTableViewRowAction[] NSTableViewRowActionsGetter (NSTableView tableView, IntPtr row, NSTableRowActionEdge edge);
	public delegate NSTableRowView NSTableViewRowGetter (NSTableView tableView, IntPtr row);
	public delegate void NSTableViewRowHandler (NSTableRowView rowView, IntPtr row);
	public delegate NFloat NSTableViewRowHeight (NSTableView tableView, IntPtr row);
	public delegate bool NSTableViewRowPredicate (NSTableView tableView, IntPtr row);
	public delegate IntPtr NSTableViewSearchString (NSTableView tableView, IntPtr startRow, IntPtr endRow, string searchString);
	public delegate NSString NSTableViewToolTip (NSTableView tableView, NSCell cell, ref CGRect rect, NSTableColumn? tableColumn, IntPtr row, CGPoint mouseLocation);
	public delegate bool NSTableViewUserCanChangeColumnVisibility (NSTableView tableView, NSTableColumn column);
	public delegate NSView NSTableViewViewGetter (NSTableView tableView, NSTableColumn tableColumn, IntPtr row);
	public delegate NSObject[]? NSTextFieldGetCandidates (NSTextField textField, NSTextView textView, NSRange selectedRange);
	public delegate bool NSTextFieldSelectCandidate (NSTextField textField, NSTextView textView, UIntPtr index);
	public delegate NSTextCheckingResult[] NSTextFieldTextCheckingResults (NSTextField textField, NSTextView textView, NSTextCheckingResult[] candidates, NSRange selectedRange);
	/// <summary>A delegate used as the callback in <see cref="M:AppKit.NSLayoutManager.EnumerateEnclosingRects(Foundation.NSRange,Foundation.NSRange,AppKit.NSTextContainer,AppKit.NSTextLayoutEnumerateEnclosingRects)" />.</summary>
	public delegate void NSTextLayoutEnumerateEnclosingRects (CGRect rect, out bool stop);
	/// <summary>A delegate used as the callback in <see cref="M:AppKit.NSLayoutManager.EnumerateLineFragments(Foundation.NSRange,AppKit.NSTextLayoutEnumerateLineFragments)" />.</summary>
	public delegate void NSTextLayoutEnumerateLineFragments (CGRect rect, CGRect usedRectangle, NSTextContainer textContainer, NSRange glyphRange, out bool stop);
	public delegate bool NSTextLayoutManagerEnumerateRenderingAttributesDelegate (NSTextLayoutManager textLayoutManager, global::Foundation.NSDictionary<NSString, NSObject> attributes, NSTextRange textRange);
	public delegate bool NSTextLayoutManagerEnumerateTextSegmentsDelegate (NSTextRange? textSegmentRange, CGRect textSegmentFrame, NFloat baselinePosition, NSTextContainer textContainer);
	public delegate bool NSTextPredicate (NSText textObject);
	public delegate void NSTextSelectionDataSourceEnumerateCaretOffsetsDelegate (NFloat caretOffset, INSTextLocation location, bool leadingEdge, out bool stop);
	public delegate void NSTextSelectionDataSourceEnumerateContainerBoundariesDelegate (INSTextLocation location, out bool stop);
	public delegate void NSTextSelectionDataSourceEnumerateSubstringsDelegate (NSString? substring, NSTextRange substringRange, NSTextRange? enclodingRange, out bool stop);
	public delegate bool NSTextViewCellPasteboard (NSTextView view, NSTextAttachmentCell cell, UIntPtr charIndex, NSPasteboard pboard, string type);
	public delegate String[] NSTextViewCellPosition (NSTextView view, NSTextAttachmentCell forCell, UIntPtr charIndex);
	public delegate bool NSTextViewChangeText (NSTextView textView, NSRange affectedCharRange, string replacementString);
	public delegate String[] NSTextViewCompletion (NSTextView textView, String[] words, NSRange charRange, ref IntPtr index);
	public delegate NSMenu NSTextViewEventMenu (NSTextView view, NSMenu menu, NSEvent theEvent, UIntPtr charIndex);
	public delegate NSObject[]? NSTextViewGetCandidates (NSTextView textView, NSRange selectedRange);
	public delegate NSUndoManager NSTextViewGetUndoManager (NSTextView view);
	public delegate bool NSTextViewLink (NSTextView textView, NSObject link, UIntPtr charIndex);
	public delegate NSDictionary NSTextViewOnTextCheck (NSTextView view, NSRange range, NSDictionary options, NSTextCheckingTypes checkingTypes);
	public delegate NSValue[] NSTextViewRange (NSTextView textView, NSRange enclosingRange);
	public delegate bool NSTextViewSelectCandidate (NSTextView textView, UIntPtr index);
	public delegate NSRange NSTextViewSelectionChange (NSTextView textView, NSRange oldSelectedCharRange, NSRange newSelectedCharRange);
	public delegate bool NSTextViewSelectionShouldChange (NSTextView textView, NSValue[] affectedRanges, String[] replacementStrings);
	public delegate NSValue[] NSTextViewSelectionWillChange (NSTextView textView, NSValue[] oldSelectedCharRanges, NSValue[] newSelectedCharRanges);
	public delegate bool NSTextViewSelectorCommand (NSTextView textView, Selector commandSelector);
	public delegate IntPtr NSTextViewSpellingQuery (NSTextView textView, IntPtr value, NSRange affectedCharRange);
	public delegate NSTextCheckingResult[] NSTextViewTextChecked (NSTextView view, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options, NSTextCheckingResult[] results, NSOrthography orthography, IntPtr wordCount);
	public delegate NSTextCheckingResult[] NSTextViewTextCheckingResults (NSTextView textView, NSTextCheckingResult[] candidates, NSRange selectedRange);
	public delegate string? NSTextViewTooltip (NSTextView textView, string tooltip, UIntPtr characterIndex);
	public delegate NSDictionary NSTextViewTypeAttribute (NSTextView textView, NSDictionary oldTypingAttributes, NSDictionary newTypingAttributes);
	public delegate String[] NSTextViewUpdateTouchBarItemIdentifiers (NSTextView textView, String[] identifiers);
	public delegate bool NSToolbarCanInsert (NSToolbar toolbar, string itemIdentifier, IntPtr index);
	public delegate String[] NSToolbarIdentifiers (NSToolbar toolbar);
	public delegate global::Foundation.NSSet<NSString> NSToolbarImmovableItemIdentifiers (NSToolbar toolbar);
	public delegate NSToolbarItem? NSToolbarWillInsert (NSToolbar toolbar, string itemIdentifier, bool willBeInserted);
	public delegate NSTouchBarItem? NSTouchBarMakeItem (NSTouchBar touchBar, string identifier);
	public delegate bool NSTouchEvent (NSGestureRecognizer gestureRecognizer, NSTouch touch);
	public delegate NSApplicationPresentationOptions NSWindowApplicationPresentationOptions (NSWindow window, NSApplicationPresentationOptions proposedOptions);
	public delegate NSObject NSWindowClient (NSWindow sender, NSObject client);
	public delegate void NSWindowCompletionHandler (NSWindow window, NSError error);
	public delegate bool NSWindowDocumentDrag (NSWindow window, NSEvent theEvent, CGPoint dragImageLocation, NSPasteboard withPasteboard);
	public delegate CGRect NSWindowFrame (NSWindow window, CGRect newFrame);
	public delegate bool NSWindowFramePredicate (NSWindow window, CGRect newFrame);
	public delegate bool NSWindowMenu (NSWindow window, NSMenu menu);
	public delegate NSWindow? NSWindowNSWindow (NSWindow fromWindow);
	public delegate CGSize NSWindowResize (NSWindow sender, CGSize toFrameSize);
	public delegate CGRect NSWindowSheetRect (NSWindow window, NSWindow sheet, CGRect usingRect);
	public delegate CGSize NSWindowSize (NSWindow window, CGSize proposedSize);
	public delegate CGSize NSWindowSizeSize (NSWindow window, CGSize maxPreferredSize, CGSize maxAllowedSize);
	public delegate void NSWindowTrackEventsMatchingCompletionHandler (NSEvent evt, ref bool stop);
	public delegate NSUndoManager NSWindowUndoManager (NSWindow window);
	public delegate NSWindow[] NSWindowWindows (NSWindow window);
	public delegate void NSWorkspaceUrlHandler (NSDictionary newUrls, NSError error);
	public delegate void NSWritingToolsCoordinatorDelegateReplaceRangeCallback (NSAttributedString? replacementText);
	public delegate void NSWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback (NSBezierPath[] paths);
	public delegate void NSWritingToolsCoordinatorDelegateRequestsContextsCallback (NSWritingToolsCoordinatorContext[] contexts);
	public delegate void NSWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback (NSView view);
	public delegate void NSWritingToolsCoordinatorDelegateRequestsPreviewCallback (NSTextPreview? textPreview);
	public delegate void NSWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback (NSTextPreview[]? view);
	public delegate void NSWritingToolsCoordinatorDelegateRequestsRangeCallback (NSRange range, NSUuid contextId);
	public delegate void NSWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback (NSValue[] ranges);
	public delegate void NSWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback (NSBezierPath[] paths);
	public delegate string? NSopenSavePanelDisplayName (NSSavePanel panel, UniformTypeIdentifiers.UTType type);
	public delegate void OpenDocumentCompletionHandler (NSDocument document, bool documentWasAlreadyOpen, NSError error);
}
namespace AudioUnit {
	#nullable enable
	/// <param name="transportStateFlags">The state of the audio transport.</param><param name="currentSamplePosition">The host sample position, in audio unit samples.</param><param name="cycleStartBeatPosition">The starting beat position for the cycle. <see langword="null" /> if not cycling.</param><param name="cycleEndBeatPosition">The ending beat position for the cycle. <see langword="null" /> if not cycling.</param><summary>A delegate block that a host uses to provide information about its transport state.</summary><returns><para><see langword="true" /> if the state was successfully retrieved. Otherwise, <see langword="false" />.</para></returns><remarks><para>Developers may optionally assign an instance of this class to the <see cref="P:AudioUnit.AUAudioUnit.TransportStateBlock" /> property so that they can call it at the beginning of render cycles to get the transport state at the cycle start.</para></remarks>
	public delegate bool AUHostTransportStateBlock (ref AUHostTransportStateFlags transportStateFlags, ref double currentSamplePosition, ref double cycleStartBeatPosition, ref double cycleEndBeatPosition);
	/// <param name="node">The parameter node for which to get a possibly shortened name.</param><param name="desiredLength">The maximum desired length of the display name.</param><summary>A delegate that returns the display name, possibly shortened to <paramref name="desiredLength" /> characters.</summary><returns>The display name, possibly shortened to <paramref name="desiredLength" /> characters.</returns>
	public delegate string AUImplementorDisplayNameWithLengthCallback (AUParameterNode node, IntPtr desiredLength);
	public delegate string AUImplementorStringFromValueCallback (AUParameter param, ref global::System.Nullable<float> value);
	/// <param name="param">The parameter that will be assigned to the value that is converted from <paramref name="str" />.</param><param name="str">The string to convert.</param><summary>Converts <paramref name="str" /> to the appropriate type and assigns it to <paramref name="param" />.</summary><returns>The new audio unit value.</returns>
	public delegate float AUImplementorValueFromStringCallback (AUParameter param, string str);
	/// <param name="param">The parameter that changed.</param><param name="value">The new parameter value.</param><summary>A delegate that notifies the audio unit when a parameter value changes.</summary>
	public delegate void AUImplementorValueObserver (AUParameter param, float value);
	/// <param name="param">The parameter whose value to get.</param><summary>A delegate that retrieves a parameter value.</summary><returns>The value of the parameter that is identified by <paramref name="param" />.</returns>
	public delegate float AUImplementorValueProvider (AUParameter param);
	/// <param name="actionFlags">The action flags that configure the audio unit rendering process.</param><param name="timestamp">The unconverted, uncompressed HAL time when the input will render.</param><param name="frameCount">The number of available audio frames.</param><param name="inputBusNumber">The input bus index.</param><summary>Delegate that tells an I/O host when input is available.</summary>
	public delegate void AUInputHandler (ref AudioUnitRenderActionFlags actionFlags, ref AudioToolbox.AudioTimeStamp timestamp, uint frameCount, IntPtr inputBusNumber);
	public delegate AudioUnitStatus AUInternalRenderBlock (ref AudioUnitRenderActionFlags actionFlags, ref AudioToolbox.AudioTimeStamp timestamp, uint frameCount, IntPtr outputBusNumber, AudioToolbox.AudioBuffers outputData, AURenderEventEnumerator realtimeEventListHead, [BlockCallback] AURenderPullInputBlock? pullInputBlock);
	public delegate void AUMidiCIProfileChangedCallback (byte cable, byte channel, CoreMidi.MidiCIProfile profile, bool enabled);
	public delegate int AUMidiOutputEventBlock (long eventSampleTime, byte cable, IntPtr length, IntPtr midiBytes);
	public delegate void AUParameterAutomationObserver (ulong address, float value);
	/// <param name="address">The parameter address.</param><param name="value">The current parameter value.</param><summary>Observer that notifies an audio unit when a parameter value changes.</summary>
	public delegate void AUParameterObserver (ulong address, float value);
	/// <param name="numberOfEvents">The number of automation events.</param><param name="events">The delivered events.</param><summary>Delegate that records parameter changes as automation events.</summary>
	public delegate void AUParameterRecordingObserver (IntPtr numberOfEvents, ref AURecordedParameterEvent events);
	public delegate AudioUnitStatus AURenderBlock (ref AudioUnitRenderActionFlags actionFlags, ref AudioToolbox.AudioTimeStamp timestamp, uint frameCount, IntPtr outputBusNumber, AudioToolbox.AudioBuffers outputData, [BlockCallback] AURenderPullInputBlock? pullInputBlock);
	public delegate AudioUnitStatus AURenderPullInputBlock (ref AudioUnitRenderActionFlags actionFlags, ref AudioToolbox.AudioTimeStamp timestamp, uint frameCount, IntPtr inputBusNumber, AudioToolbox.AudioBuffers inputData);
	public delegate void AUScheduleParameterBlock (AUEventSampleTime eventSampleTime, uint rampDurationSampleFrames, ulong parameterAddress, float value);
}
namespace AuthenticationServices {
	#nullable enable
	public delegate void ASAuthorizationProviderExtensionLoginManagerAttestCallback (NSArray? attestationCertificates, NSError? error);
	public delegate void ASAuthorizationProviderExtensionRegistrationHandlerGetDisplayNamesCallback (global::Foundation.NSDictionary<NSString, NSString> fullNames);
	public delegate void ASAuthorizationProviderExtensionRegistrationHandlerGetProfilePictureForUserCallback (NSData jpegData);
	/// <summary>Delegate used in callbacks by <see cref="T:AuthenticationServices.ASCredentialIdentityStore" />.</summary>
	public delegate void ASCredentialIdentityStoreCompletionHandler (bool success, NSError? error);
	public delegate void ASCredentialIdentityStoreGetCredentialIdentitiesHandler (AuthenticationServices.IASCredentialIdentity[] credentialIdentities);
	/// <summary>Delegate object for completion handlers in methods within <see cref="T:AuthenticationServices.ASCredentialProviderExtensionContext" />.</summary>
	public delegate void ASCredentialProviderExtensionRequestCompletionHandler (bool expired);
	public delegate void ASSettingsHelperRequestToTurnOnCredentialProviderExtensionCallback (bool appWasEnabledForAutofill);
	/// <param name="callbackUrl">To be added.</param><param name="error">To be added.</param><summary>Delegate method used in <see cref="T:AuthenticationServices.ASWebAuthenticationSession" /> interactions.</summary><remarks>To be added.</remarks>
	public delegate void ASWebAuthenticationSessionCompletionHandler (NSUrl? callbackUrl, NSError? error);
}
namespace BackgroundAssets {
	#nullable enable
	public delegate void BAAssetPackManagerCheckForUpdatesCompletionHandler (global::Foundation.NSSet<NSString>? updatingIdentifiers, global::Foundation.NSSet<NSString>? removedIdentifiers, NSError? error);
	public delegate void BAAssetPackManagerEnsureLocalAvailabilityCompletionHandler (NSError? error);
	public delegate void BAAssetPackManagerGetAllAssetPacksCompletionHandler (global::Foundation.NSSet<global::BackgroundAssets.BAAssetPack>? assetPacks, NSError? error);
	public delegate void BAAssetPackManagerGetAssetPackCompletionHandler (BackgroundAssets.BAAssetPack? assetPack, NSError? error);
	/// <summary>Completion handler invoked with the local status of an asset pack.</summary><param name="status">The <see cref="T:BackgroundAssets.BAAssetPackStatus" /> of the asset pack on the local device.</param>
	public delegate void BAAssetPackManagerGetLocalStatusCompletionHandler (BackgroundAssets.BAAssetPackStatus status);
	public delegate void BAAssetPackManagerGetStatusCompletionHandler (BackgroundAssets.BAAssetPackStatus status, NSError? error);
	public delegate void BAAssetPackManagerRemoveAssetPackCompletionHandler (NSError? error);
}
namespace BrowserEngineKit {
	#nullable enable
	public delegate void BENetworkingProcessCreateCallback (BrowserEngineKit.BENetworkingProcess? proces, NSError? error);
	public delegate void BERenderingProcessCreateCallback (BrowserEngineKit.BERenderingProcess? proces, NSError? error);
	public delegate void BEWebContentProcessCreateCallback (BrowserEngineKit.BEWebContentProcess? proces, NSError? error);
}
namespace Cinematic {
	#nullable enable
	public delegate void CNAssetSpatialAudioInfoCheckIfContainsSpatialAudioCallback (bool result);
	public delegate void CNAssetSpatialAudioInfoLoadCallback (Cinematic.CNAssetSpatialAudioInfo? assetInfo, NSError? error);
}
namespace ClassKit {
	#nullable enable
	/// <summary>Completion handler for <see cref="M:ClassKit.CLSDataStore.CheckIsAssignedDocument(Foundation.NSUrl,ClassKit.CLSDataStoreCheckAssignedDocumentCompletionHandler)" />.</summary>
	public delegate void CLSDataStoreCheckAssignedDocumentCompletionHandler (bool isAssigned, NSError? error);
}
namespace CloudKit {
	#nullable enable
	public delegate void CKAcceptPerShareCompletionHandler (CKShareMetadata shareMetadata, CKShare? acceptedShare, NSError? error);
	/// <param name="subscriptionId">To be added.</param><param name="error">To be added.</param><summary>Completion handler for the <see cref="M:CloudKit.CKDatabase.DeleteSubscription(System.String,CloudKit.CKDatabaseDeleteSubscriptionHandler)" /> method.</summary><remarks>To be added.</remarks>
	public delegate void CKDatabaseDeleteSubscriptionHandler (string? subscriptionId, NSError? error);
	public delegate void CKFetchDatabaseChangesCompletionHandler (CKServerChangeToken? serverChangeToken, bool moreComing, NSError? operationError);
	public delegate void CKFetchPerShareMetadataHandler (NSUrl shareURL, CKShareMetadata? shareMetadata, NSError? error);
	/// <param name="serverChangeToken">To be added.</param><param name="clientChangeTokenData">To be added.</param><param name="operationError">To be added.</param><summary>Delegate for the <see cref="P:CloudKit.CKFetchRecordChangesOperation.AllChangesReported" /> property.</summary><remarks>To be added.</remarks>
	public delegate void CKFetchRecordChangesHandler (CKServerChangeToken? serverChangeToken, NSData? clientChangeTokenData, NSError? operationError);
	public delegate void CKFetchRecordZoneChangesFetchCompletedHandler (CKRecordZoneID? recordZoneID, CKServerChangeToken? serverChangeToken, NSData? clientChangeTokenData, bool moreComing, NSError? recordZoneError);
	public delegate void CKFetchRecordZoneChangesRecordWasChangedHandler (CKRecordID? recordId, CKRecord? record, NSError? error);
	public delegate void CKFetchRecordZoneChangesTokensUpdatedHandler (CKRecordZoneID? recordZoneID, CKServerChangeToken? serverChangeToken, NSData? clientChangeTokenData);
	public delegate void CKFetchRecordZoneChangesWithIDWasDeletedHandler (CKRecordID recordID, NSString recordType);
	/// <param name="recordsByRecordId">To be added.</param><param name="error">To be added.</param><summary>Delegate for the <see cref="P:CloudKit.CKFetchRecordsOperation.Completed" /> property.</summary><remarks>To be added.</remarks>
	public delegate void CKFetchRecordsCompletedHandler (NSDictionary? recordsByRecordId, NSError? error);
	public delegate void CKFetchShareParticipantsOperationPerShareParticipantCompletionHandler (CKUserIdentityLookupInfo? identityLookupInfo, CKShareParticipant? participant, NSError? error);
	/// <param name="subscriptionsBySubscriptionId">To be added.</param><param name="operationError">To be added.</param><summary>Delegate for the <see cref="P:CloudKit.CKFetchSubscriptionsOperation.Completed" /> property.</summary><remarks>To be added.</remarks>
	public delegate void CKFetchSubscriptionsCompleteHandler (NSDictionary? subscriptionsBySubscriptionId, NSError? operationError);
	public delegate void CKFetchSubscriptionsPerSubscriptionCompletionHandler (NSString? subscriptionId, CKSubscription? subscription, NSError? error);
	public delegate void CKFetchWebAuthTokenOperationHandler (string? webAuthToken, NSError? operationError);
	/// <param name="savedRecordZones">To be added.</param><param name="deletedRecordZoneIds">To be added.</param><param name="operationError">To be added.</param><summary>Delegate for the <see cref="P:CloudKit.CKModifyRecordZonesOperation.Completed" /> property.</summary><remarks>To be added.</remarks>
	public delegate void CKModifyRecordZonesHandler (CKRecordZone[]? savedRecordZones, CKRecordZoneID[]? deletedRecordZoneIds, NSError? operationError);
	public delegate void CKModifyRecordZonesPerRecordZoneDeleteHandler (CKRecordZoneID? zoneId, NSError? error);
	public delegate void CKModifyRecordZonesPerRecordZoneSaveHandler (CKRecordZoneID? zoneId, CKRecordZone? zone, NSError? error);
	/// <param name="savedRecords">To be added.</param><param name="deletedRecordIds">To be added.</param><param name="operationError">To be added.</param><summary>Delegate for the <see cref="P:CloudKit.CKModifyRecordsOperation.Completed" /> property.</summary><remarks>To be added.</remarks>
	public delegate void CKModifyRecordsOperationHandler (CKRecord[]? savedRecords, CKRecordID[]? deletedRecordIds, NSError? operationError);
	public delegate void CKModifyRecordsOperationPerRecordDeleteHandler (CKRecordID? recordId, NSError? error);
	public delegate void CKModifyRecordsOperationPerRecordSaveHandler (CKRecordID? recordId, CKRecord? record, NSError? error);
	/// <param name="savedSubscriptions">To be added.</param><param name="deletedSubscriptionIds">To be added.</param><param name="operationError">To be added.</param><summary>Delegate for the <see cref="P:CloudKit.CKModifySubscriptionsOperation.Completed" /> property.</summary><remarks>To be added.</remarks>
	public delegate void CKModifySubscriptionsHandler (CKSubscription[]? savedSubscriptions, String[]? deletedSubscriptionIds, NSError? operationError);
	public delegate void CKModifySubscriptionsPerSubscriptionDeleteHandler (NSString? subscriptionId, NSError? error);
	public delegate void CKModifySubscriptionsPerSubscriptionSaveHandler (NSString? subscriptionId, CKSubscription? subscription, NSError? error);
	public delegate void CKQueryOperationRecordMatchedHandler (CKRecordID? recordId, CKRecord? record, NSError? error);
	/// <param name="recordZonesByZoneId">To be added.</param><param name="operationError">To be added.</param><summary>Delegate for the <see cref="P:CloudKit.CKFetchRecordZonesOperation.Completed" /> property.</summary><remarks>To be added.</remarks>
	public delegate void CKRecordZoneCompleteHandler (NSDictionary? recordZonesByZoneId, NSError? operationError);
	public delegate void CKRecordZonePerRecordZoneCompletionHandler (CKRecordZoneID? recordZoneId, CKRecordZone? recordZone, NSError? error);
	public delegate void CKShareRequestAccessOperationPerShareAccessRequestCompletionHandler (NSUrl shareUrl, NSError? error);
	public delegate void CKShareRequestAccessOperationShareRequestAccessCompletionHandler (NSError? error);
}
namespace Contacts {
	#nullable enable
	public delegate void CNContactStoreListContactsHandler (CNContact contact, ref bool stop);
	/// <summary>Completion handler for calls to <see cref="M:Contacts.CNContactStore.RequestAccess(Contacts.CNEntityType,Contacts.CNContactStoreRequestAccessHandler)" /></summary>
	public delegate void CNContactStoreRequestAccessHandler (bool granted, NSError? error);
}
namespace CoreData {
	#nullable enable
	public delegate bool NSBatchInsertRequestDictionaryHandler (NSMutableDictionary dictionary);
	public delegate bool NSBatchInsertRequestManagedObjectHandler (CoreData.NSManagedObject managedObject);
	public delegate void NSPersistentCloudKitContainerAcceptShareInvitationsHandler (global::Foundation.NSArray<global::CloudKit.CKShareMetadata>? acceptedShareMetadatas, NSError? error);
	public delegate void NSPersistentCloudKitContainerFetchParticipantsMatchingLookupInfosHandler (global::Foundation.NSArray<global::CloudKit.CKShareParticipant>? fetchedParticipants, NSError? error);
	public delegate void NSPersistentCloudKitContainerPersistUpdatedShareHandler (CKShare? persistedShare, NSError? error);
	public delegate void NSPersistentCloudKitContainerPurgeObjectsAndRecordsInZoneHandler (CKRecordZoneID? purgedZoneId, NSError? error);
	public delegate void NSPersistentCloudKitContainerShareManagedObjectsHandler (global::Foundation.NSSet<global::CoreData.NSManagedObjectID>? sharedObjectIds, CKShare? share, CKContainer? container, NSError? error);
}
namespace CoreImage {
	#nullable enable
	/// <summary>Completion handler for deterimining a region of interest in the source image.</summary>
	public delegate CGRect CIKernelRoiCallback (int index, CGRect rect);
}
namespace CoreLocation {
	#nullable enable
	/// <summary>A delegate that is the <c>completionHandler</c> for various asynchronous methods in <see cref="T:CoreLocation.CLGeocoder" />.</summary><param name="placemarks">Returns null on error, otherwise the list of placemark locations.   Typically one, but could be more than one if the location is known by multiple names.</param><param name="error">Error information.</param>
	public delegate void CLGeocodeCompletionHandler (CLPlacemark[]? placemarks, NSError? error);
	public delegate bool CLLocationManagerEventArgs (CLLocationManager manager);
}
namespace CoreML {
	#nullable enable
	public delegate void MLModelAssetGetFunctionNamesCompletionHandler (String[]? functionNames, NSError? error);
	public delegate void MLModelAssetGetModelDescriptionCompletionHandler (MLModelDescription? modelDescription, NSError? error);
	public delegate void MLStateGetMultiArrayForStateHandler (MLMultiArray buffer);
	public delegate void MLStateGetPredictionCompletionHandler (IMLFeatureProvider? output, NSError? error);
}
namespace CoreMidi {
	#nullable enable
	public delegate void MidiCIDiscoveryResponseDelegate (CoreMidi.MidiCIDiscoveredNode[] discoveredNodes);
	public delegate void MidiCIProfileChangedHandler (CoreMidi.MidiCISession session, byte channel, CoreMidi.MidiCIProfile profile, bool enabled);
	public delegate void MidiCIProfileSpecificDataHandler (CoreMidi.MidiCISession session, byte channel, CoreMidi.MidiCIProfile profile, NSData data);
	public delegate void MidiCISessionDisconnectHandler (CoreMidi.MidiCISession? session, NSError? error);
	public delegate void MidiReceiveBlock (IntPtr eventList, IntPtr srcConnRefCon);
}
namespace CoreMotion {
	#nullable enable
	public delegate void CMHeadphoneActivityHandler (CoreMotion.CMMotionActivity? activity, NSError? error);
	public delegate void CMHeadphoneActivityStatusHandler (CoreMotion.CMHeadphoneActivityStatus status, NSError? error);
	public delegate void CMHeadphoneDeviceMotionHandler (CoreMotion.CMDeviceMotion? motion, NSError? error);
}
namespace CoreSpotlight {
	#nullable enable
	public delegate void CSSearchableIndexDelegateGetSearchableItemsHandler (CoreSpotlight.CSSearchableItem[] items);
	public delegate void CSSearchableIndexEndIndexHandler (NSError? error);
	/// <summary>Completion handler used in <see cref="CoreSpotlight.CSSearchableIndex_CSOptionalBatchingExtension.FetchLastClientState(CoreSpotlight.CSSearchableIndex,CoreSpotlight.CSSearchableIndexFetchHandler)" />.</summary>
	public delegate void CSSearchableIndexFetchHandler (NSData clientState, NSError? error);
}
namespace CryptoTokenKit {
	#nullable enable
	public delegate void TKGetSlotCallback (CryptoTokenKit.TKSmartCardSlot? slot);
	public delegate bool TKSmartCardExecuteCallback (out NSError? error);
	public delegate void TKSmartCardSendCallback (NSData? replyData, UInt16 sq, NSError? error);
}
namespace DeviceCheck {
	#nullable enable
	/// <param name="token">The generated token.</param><param name="error">The error that was encountered, or <see langword="null" /> if no error occurred.</param><summary>A completion handler for DeviceCheck token generation.</summary>
	public delegate void DCDeviceGenerateTokenCompletionHandler (NSData? token, NSError? error);
}
namespace EventKit {
	#nullable enable
	/// <param name="theEvent">The matching event.</param><param name="stop">If you set this ref value to true, the enumeration will stop.</param><summary>Delegate signature for the event enumeration method in <see cref="T:EventKit.EKEventStore" /></summary><remarks>The method will be invoked repeatedly, once for each event that matches the provided NSPredicate.</remarks>
	public delegate void EKEventSearchCallback (EventKit.EKEvent theEvent, ref bool stop);
	public delegate void EKEventStoreRequestAccessCompletionHandler (bool didRequestAccess, NSError? error);
	public delegate void VirtualConferenceHandler (EventKit.EKVirtualConferenceDescriptor? virtualConferenceDescriptor, NSError? error);
	public delegate void VirtualConferenceRoomTypeHandler (global::Foundation.NSArray<global::EventKit.EKVirtualConferenceRoomTypeDescriptor>? virtualConferenceRoomTypeDescriptor, NSError? error);
}
namespace FSKit {
	#nullable enable
	[Experimental ("APL0002")]
	public delegate void FSBlockDeviceResourceReadReplyHandler (UIntPtr actuallyRead, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSBlockDeviceResourceWriteReplyHandler (UIntPtr actuallyWritten, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSFileSystemBaseWipeResourceCompletionHandler (NSError? error);
	[Experimental ("APL0002")]
	public delegate NSError? FSTaskCancellationCallback ();
	[Experimental ("APL0002")]
	public delegate void FSUnaryFileSystemOperationsLoadResourceResult (FSKit.FSVolume? volume, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSUnaryFileSystemOperationsProbeResourceResult (FSKit.FSProbeResult? volume, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSUnaryFileSystemOperationsUnloadResourceResult (NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeAccessCheckOperationsCheckAccessHandler (bool shouldAllowAccess, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeItemDeactivationDeactivateItemHandler (NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeKernelOffloadedIoOperationsCreateFileHandler (FSKit.FSItem? newItem, FSKit.FSFileName? newItemName, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeKernelOffloadedIoOperationsHandler (NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeKernelOffloadedIoOperationsLookupItemHandler (FSKit.FSItem? newItem, FSKit.FSFileName? newItemName, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeKernelOffloadedIoOperationsPreallocateSpaceHandler (UIntPtr bytesAllocated, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeOpenCloseOperationsHandler (NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeOperationsActivateHandler (FSKit.FSItem? rootItem, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeOperationsAttributesHandler (FSKit.FSItemAttributes? attributes, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeOperationsCreateItemHandler (FSKit.FSItem? newItem, FSKit.FSFileName? newItemName, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeOperationsCreateLinkHandler (FSKit.FSFileName? newItemName, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeOperationsDeactivateHandler (NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeOperationsEnumerateDirectoryHandler (ulong currentVerifier, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeOperationsLookupItemHandler (FSKit.FSItem? item, FSKit.FSFileName? itemName, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeOperationsMountHandler (NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeOperationsReadSymbolicLinkHandler (FSKit.FSFileName? attributes, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeOperationsReclaimHandler (NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeOperationsRemoveItemHandler (NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeOperationsRenameItemHandler (FSKit.FSFileName? newName, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeOperationsSynchronizeHandler (NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumePreallocateOperationsHandler (UIntPtr bytesAllocated, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeReadWriteOperationsReadHandler (UIntPtr actuallyRead, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeReadWriteOperationsWriteHandler (UIntPtr actuallyWritten, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeRenameOperationsSetVolumeNameHandler (FSKit.FSFileName? newName, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeXattrOperationsGetHandler (NSData? value, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeXattrOperationsListHandler (FSKit.FSFileName[]? value, NSError? error);
	[Experimental ("APL0002")]
	public delegate void FSVolumeXattrOperationsSetHandler (NSError? error);
	[Experimental ("APL0002")]
	public delegate void FetchInstalledExtensionsCallback (FSKit.FSModuleIdentity[]? identities, NSError? error);
}
namespace FileProvider {
	#nullable enable
	public delegate void NSFileProviderCreateOrModifyItemCompletionHandler (INSFileProviderItem? item, NSFileProviderItemFields stillPendingFields, bool shouldFetchContent, NSError? error);
	public delegate void NSFileProviderExternalVolumeHandlingShouldConnectExternalDomainCallback (NSError? connectionError);
	public delegate void NSFileProviderFetchContentsCompletionHandler (NSUrl? fileContents, INSFileProviderItem? item, NSError? error);
	public delegate void NSFileProviderGetIdentifierHandler (NSString? itemIdentifier, NSString? domainIdentifier, NSError? error);
	public delegate void NSFileProviderKnownFolderLocationCallback (INSFileProviderKnownFolderSupporting result, NSError? error);
	public delegate void NSFileProviderManagerKnownFoldersCallback (NSError? error);
	public delegate void NSFileProviderManagerRequestDiagnosticCollectionCallback (NSError? error);
	public delegate void NSFileProviderPartialContentFetchingCompletionHandler (NSUrl fileContents, INSFileProviderItem item, NSRange retrievedRange, NSFileProviderMaterializationFlags flags, NSError error);
	public delegate void NSFileProviderPerThumbnailCompletionHandler (NSString identifier, NSData? imageData, NSError? error);
}
namespace FinderSync {
	#nullable enable
	public delegate void GetValuesCompletionHandler (global::Foundation.NSDictionary<NSString, NSObject> values, NSError error);
}
namespace Foundation {
	#nullable enable
	public delegate void CloudKitRegistrationPreparationAction ([BlockCallback] CloudKitRegistrationPreparationHandler handler);
	public delegate void CloudKitRegistrationPreparationHandler (CKShare share, CKContainer container, NSError error);
	/// <param name="date">To be added.</param><param name="exactMatch">To be added.</param><param name="stop">To be added.</param><summary>Completion handler for the <see cref="M:Foundation.NSCalendar.EnumerateDatesStartingAfterDate(Foundation.NSDate,Foundation.NSDateComponents,Foundation.NSCalendarOptions,Foundation.EnumerateDatesCallback)" /> method.</summary><remarks>To be added.</remarks>
	public delegate void EnumerateDatesCallback (NSDate date, bool exactMatch, ref bool stop);
	/// <param name="idx">To be added.</param><param name="stop">To be added.</param><summary>Defines the enumerator callback in calls to <see cref="M:Foundation.NSIndexSet.EnumerateIndexes(Foundation.NSRange,Foundation.NSEnumerationOptions,Foundation.EnumerateIndexSetCallback)" />.</summary><remarks>To be added.</remarks>
	public delegate void EnumerateIndexSetCallback (UIntPtr idx, ref bool stop);
	public delegate void ItemProviderDataCompletionHandler (NSData? data, NSError? error);
	public delegate void LinguisticTagEnumerator (string tag, NSRange tokenRange, bool stop);
	public delegate void LoadFileRepresentationHandler (NSUrl? fileUrl, bool openInPlace, NSError? error);
	public delegate void LoadInPlaceFileRepresentationHandler (NSUrl? fileUrl, bool isInPlace, NSError? error);
	/// <param name="attrs">To be added.</param><param name="range">To be added.</param><param name="stop">To be added.</param><summary>A delegate that specifies the callback for the <see cref="M:Foundation.NSAttributedString.EnumerateAttributes(Foundation.NSRange,Foundation.NSAttributedStringEnumeration,Foundation.NSAttributedRangeCallback)" /> method.</summary><remarks>To be added.</remarks>
	public delegate void NSAttributedRangeCallback (NSDictionary attrs, NSRange range, ref bool stop);
	/// <param name="value">To be added.</param><param name="range">To be added.</param><param name="stop">To be added.</param><summary>A delegate that specifies the callback for the <see cref="M:Foundation.NSAttributedString.EnumerateAttribute(Foundation.NSString,Foundation.NSRange,Foundation.NSAttributedStringEnumeration,Foundation.NSAttributedStringCallback)" /> method.</summary><remarks>To be added.</remarks>
	public delegate void NSAttributedStringCallback (NSObject value, NSRange range, ref bool stop);
	public delegate void NSAttributedStringCompletionHandler (NSAttributedString? attributedString, global::Foundation.NSDictionary<NSString, NSObject>? attributes, NSError? error);
	public delegate void NSBackgroundActivityCompletionAction ([BlockCallback] NSBackgroundActivityCompletionHandler handler);
	public delegate void NSBackgroundActivityCompletionHandler (NSBackgroundActivityResult result);
	/// <param name="obj1">To be added.</param><param name="obj2">To be added.</param><summary>A delegate that defines the comparison function to be used with functions such as <see cref="M:Foundation.NSArray.Sort(Foundation.NSComparator)" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
	public delegate NSComparisonResult NSComparator (NSObject obj1, NSObject obj2);
	/// <param name="bytes">To be added.</param><param name="range">To be added.</param><param name="stop">To be added.</param><summary>The delegate used to enumerate in calls to <see cref="M:Foundation.NSData.EnumerateByteRange(Foundation.NSDataByteRangeEnumerator)" />.</summary><remarks>To be added.</remarks>
	public delegate void NSDataByteRangeEnumerator (IntPtr bytes, NSRange range, ref bool stop);
	public delegate NSObject NSDecoderCallback (NSKeyedUnarchiver unarchiver, NSObject obj);
	public delegate Class NSDecoderHandler (NSKeyedUnarchiver unarchiver, string klass, String[] classes);
	public delegate void NSDictionaryEnumerator (NSObject key, NSObject obj, ref bool stop);
	public delegate bool NSDictionaryKeyFilter (NSObject key, NSObject obj, ref bool stop);
	public delegate NSObject NSEncodeHook (NSKeyedArchiver archiver, NSObject obj);
	/// <param name="url">To be added.</param><param name="error">To be added.</param><summary>A delegate that specifies the error handler for use in <see cref="M:Foundation.NSFileManager.GetEnumerator(Foundation.NSUrl,Foundation.NSString[],Foundation.NSDirectoryEnumerationOptions,Foundation.NSEnumerateErrorHandler)" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
	public delegate bool NSEnumerateErrorHandler (NSUrl url, NSError error);
	/// <param name="tag">To be added.</param><param name="tokenRange">To be added.</param><param name="sentenceRange">To be added.</param><param name="stop">To be added.</param><summary>An enumerator to pass to methods in the <see cref="T:Foundation.NSLinguisticAnalysis" /> class.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
	public delegate bool NSEnumerateLinguisticTagsEnumerator (NSString? tag, NSRange tokenRange, NSRange sentenceRange, ref bool stop);
	/// <param name="error">To be added.</param><param name="userInfoKey">To be added.</param><summary>Delegate returned by <see cref="M:Foundation.NSError.GetUserInfoValueProvider(System.String)" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
	public delegate NSObject NSErrorUserInfoValueProvider (NSError error, NSString userInfoKey);
	public delegate NSObject NSExpressionCallbackHandler (NSObject? evaluatedObject, NSExpression[] expressions, NSMutableDictionary? context);
	/// <param name="newReadingUrl">To be added.</param><param name="newWritingUrl">To be added.</param><summary>A delegate that used with a number of coordinated read-and-write functions in <see cref="T:Foundation.NSFileCoordinator" />.</summary><remarks>To be added.</remarks>
	public delegate void NSFileCoordinatorWorkerRW (NSUrl newReadingUrl, NSUrl newWritingUrl);
	public delegate void NSFileManagerFetchLatestRemoteVersionOfItemHandler (NSFileVersion? latestRemoteVersion, NSError? error);
	public delegate void NSFileManagerSyncForUbiquitousItemHandler (NSError? error);
	public delegate void NSFileManagerUploadLocalVersionOfUbiquitousItemHandler (NSFileVersion? uploadedVersion, NSError? error);
	/// <param name="reacquirer">To be added.</param><summary>Completion handler for relinquishing a file to a reader.</summary><remarks>To be added.</remarks>
	public delegate void NSFilePresenterReacquirer ([BlockCallback] Action reacquirer);
	public delegate void NSFileVersionNonlocalVersionsCompletionHandler (NSFileVersion[]? nonlocalFileVersions, NSError? error);
	/// <param name="itemBeingLoaded">To be added.</param><param name="error">To be added.</param><summary>The completion handler used with <see cref="T:Foundation.NSItemProviderLoadHandler" /> delegates.</summary><remarks>To be added.</remarks>
	public delegate void NSItemProviderCompletionHandler (INSSecureCoding itemBeingLoaded, NSError error);
	/// <param name="completionHandler">To be added.</param><param name="expectedValueClass">To be added.</param><param name="options">To be added.</param><summary>Defines the load handler for use with the <see cref="M:Foundation.NSItemProvider.RegisterItemForTypeIdentifier(System.String,Foundation.NSItemProviderLoadHandler)" /> and <see cref="M:Foundation.NSItemProvider.SetPreviewImageHandler(Foundation.NSItemProviderLoadHandler)" /> methods.</summary><remarks>To be added.</remarks>
	public delegate void NSItemProviderLoadHandler ([BlockCallback] NSItemProviderCompletionHandler? completionHandler, Class? expectedValueClass, NSDictionary? options);
	public delegate NSProgress NSItemProviderUTTypeLoadDelegate ([BlockCallback] ItemProviderDataCompletionHandler completionHandler);
	/// <param name="tag">To be added.</param><param name="tokenRange">To be added.</param><param name="sentenceRange">To be added.</param><param name="stop">To be added.</param><summary>A delegate that enumerates values for <see cref="M:Foundation.NSLinguisticTagger.EnumerateTagsInRange(Foundation.NSRange,Foundation.NSString,Foundation.NSLinguisticTaggerOptions,Foundation.NSLingusticEnumerator)" />.</summary><remarks>To be added.</remarks>
	public delegate void NSLingusticEnumerator (NSString? tag, NSRange tokenRange, NSRange sentenceRange, ref bool stop);
	/// <param name="result">To be added.</param><param name="flags">To be added.</param><param name="stop">To be added.</param><summary>Delegate applied to results in <see cref="M:Foundation.NSRegularExpression.EnumerateMatches(Foundation.NSString,Foundation.NSMatchingOptions,Foundation.NSRange,Foundation.NSMatchEnumerator)" />.</summary><remarks>To be added.</remarks>
	public delegate void NSMatchEnumerator (NSTextCheckingResult result, NSMatchingFlags flags, ref bool stop);
	/// <param name="result">To be added.</param><param name="idx">To be added.</param><param name="stop">To be added.</param><summary>The delegate used as the callback in calls to <see cref="M:Foundation.NSMetadataQuery.EnumerateResultsUsingBlock(Foundation.NSMetadataQueryEnumerationCallback)" /> and <see cref="M:Foundation.NSMetadataQuery.EnumerateResultsWithOptions(Foundation.NSEnumerationOptions,Foundation.NSMetadataQueryEnumerationCallback)" />.</summary><remarks>To be added.</remarks>
	public delegate void NSMetadataQueryEnumerationCallback (NSObject result, UIntPtr idx, ref bool stop);
	public delegate NSObject NSMetadataQueryObject (NSMetadataQuery query, NSMetadataItem result);
	public delegate NSObject NSMetadataQueryValue (NSMetadataQuery query, string attributeName, NSObject value);
	/// <param name="evaluatedObject">To be added.</param><param name="bindings">To be added.</param><summary>A delegate that represents the expression to use with <see cref="M:Foundation.NSPredicate.FromExpression(Foundation.NSPredicateEvaluator)" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
	public delegate bool NSPredicateEvaluator (NSObject? evaluatedObject, NSDictionary? bindings);
	/// <param name="range">To be added.</param><param name="stop">To be added.</param><summary>A delegate used to specify the iterator used by <see cref="M:Foundation.NSIndexSet.EnumerateRanges(Foundation.NSRange,Foundation.NSEnumerationOptions,Foundation.NSRangeIterator)" />.</summary><remarks>To be added.</remarks>
	public delegate void NSRangeIterator (NSRange range, ref bool stop);
	/// <param name="obj">To be added.</param><param name="stop">To be added.</param><summary>A delegate that specifies the enumerator used by <see cref="M:Foundation.NSSet.Enumerate(Foundation.NSSetEnumerator)" />.</summary><remarks>To be added.</remarks>
	public delegate void NSSetEnumerator (NSObject obj, ref bool stop);
	/// <param name="response">To be added.</param><param name="data">To be added.</param><param name="error">To be added.</param><summary>The delegate used as the completion handler for <see cref="M:Foundation.NSUrlConnection.SendAsynchronousRequest(Foundation.NSUrlRequest,Foundation.NSOperationQueue,Foundation.NSUrlConnectionDataResponse)" />.</summary><remarks>To be added.</remarks>
	public delegate void NSUrlConnectionDataResponse (NSUrlResponse? response, NSData? data, NSError? error);
	/// <param name="location">To be added.</param><param name="response">To be added.</param><param name="error">To be added.</param><summary>Completion handler for calls to <see cref="M:Foundation.NSUrlSession.CreateDownloadTask(Foundation.NSUrlRequest)" /> and <see cref="M:Foundation.NSUrlSession.CreateDownloadTaskFromResumeData(Foundation.NSData,Foundation.NSUrlDownloadSessionResponse)" />.</summary><remarks>To be added.</remarks>
	public delegate void NSUrlDownloadSessionResponse (NSUrl? location, NSUrlResponse? response, NSError? error);
	public delegate void NSUrlSessionAllPendingTasks (NSUrlSessionTask[] tasks);
	public delegate void NSUrlSessionDataRead (NSData? data, bool atEof, NSError? error);
	/// <param name="dataTasks">To be added.</param><param name="uploadTasks">To be added.</param><param name="downloadTasks">To be added.</param><summary>The delegate that serves as the completion handler for <see cref="M:Foundation.NSUrlSession.GetTasks(Foundation.NSUrlSessionPendingTasks)" />.</summary><remarks>To be added.</remarks>
	public delegate void NSUrlSessionPendingTasks (NSUrlSessionTask[] dataTasks, NSUrlSessionTask[] uploadTasks, NSUrlSessionTask[] downloadTasks);
	/// <param name="data">Data that was received.</param><param name="response">The object representing the response.</param><param name="error">Error code, if any.</param><summary>Signature for callbacks invoked by NSUrlSession for various background operations.</summary><remarks></remarks>
	public delegate void NSUrlSessionResponse (NSData? data, NSUrlResponse? response, NSError? error);
	public delegate NSProgress RegisterDataRepresentationLoadHandler ([BlockCallback] ItemProviderDataCompletionHandler completionHandler);
	public delegate void RegisterFileRepresentationCompletionHandler (NSUrl fileUrl, bool coordinated, NSError error);
	public delegate NSProgress RegisterFileRepresentationLoadHandler ([BlockCallback] RegisterFileRepresentationCompletionHandler completionHandler);
	public delegate void RegisterObjectRepresentationCompletionHandler (INSItemProviderWriting @object, NSError error);
	public delegate NSProgress RegisterObjectRepresentationLoadHandler ([BlockCallback] RegisterObjectRepresentationCompletionHandler completionHandler);
	public delegate bool UNCShouldPresentNotification (NSUserNotificationCenter center, NSUserNotification notification);
}
namespace GLKit {
	#nullable enable
	/// <param name="textureInfo">The information about the texture loaded, or null on error.</param><param name="error">On success, this value is null.   Otherwise it contains the error information.</param><summary>Signature used by the asynchrous texture loading methods in <see cref="T:GLKit.GLKTextureLoader" />.</summary>
	public delegate void GLKTextureLoaderCallback (GLKit.GLKTextureInfo? textureInfo, NSError? error);
}
namespace GameController {
	#nullable enable
	public delegate void ElementValueDidChangeHandler (GameController.IGCDevicePhysicalInput physicalInput, GameController.IGCPhysicalInputElement element);
	public delegate void GCAxis2DInputValueDidChangeCallback (GameController.IGCPhysicalInputElement element, GameController.IGCAxis2DInput input, GameController.GCPoint2 point);
	/// <summary>The delegate used as the value-changed handler for <see cref="P:GameController.GCControllerAxisInput.ValueChangedHandler" />.</summary>
	public delegate void GCControllerAxisValueChangedHandler (GameController.GCControllerAxisInput axis, float value);
	public delegate void GCControllerButtonTouchedChanged (GameController.GCControllerButtonInput button, float value, bool pressed, bool touched);
	/// <summary>Delegate for <see cref="P:GameController.GCControllerButtonInput.ValueChangedHandler" /> and <see cref="P:GameController.GCControllerButtonInput.PressedChangedHandler" />.</summary>
	public delegate void GCControllerButtonValueChanged (GameController.GCControllerButtonInput button, float buttonValue, bool pressed);
	/// <summary>The delegate used as the value-changed handler for <see cref="P:GameController.GCControllerDirectionPad.ValueChangedHandler" />.</summary>
	public delegate void GCControllerDirectionPadValueChangedHandler (GameController.GCControllerDirectionPad dpad, float xValue, float yValue);
	public delegate void GCControllerTouchpadHandler (GameController.GCControllerTouchpad touchpad, float xValue, float yValue, float buttonValue, bool buttonPressed);
	/// <summary>The delegate used as the value-changed handler for <see cref="P:GameController.GCExtendedGamepad.ValueChangedHandler" />.</summary>
	public delegate void GCExtendedGamepadValueChangedHandler (GameController.GCExtendedGamepad gamepad, GameController.GCControllerElement element);
	/// <summary>The delegate used as the value-changed handler for <see cref="P:GameController.GCGamepad.ValueChangedHandler" />.</summary>
	public delegate void GCGamepadValueChangedHandler (GameController.GCGamepad gamepad, GameController.GCControllerElement element);
	public delegate void GCKeyboardValueChangedHandler (GameController.GCKeyboardInput keyboard, GameController.GCControllerButtonInput key, IntPtr keyCode, bool pressed);
	/// <param name="gamepad">The profile that contains the changed element.</param><param name="element">The element that changed.</param><summary>A handler that is called whenever any single element of a controller changes.</summary><remarks><para>This handler is called once for each element change. It is only called for directly attached elements.</para></remarks>
	public delegate void GCMicroGamepadValueChangedHandler (GameController.GCMicroGamepad gamepad, GameController.GCControllerElement element);
	public delegate void GCMouseMoved (GameController.GCMouseInput mouse, float deltaX, float deltaY);
	public delegate void InputStateAvailableHandler (GameController.IGCDevicePhysicalInput physicalInput);
}
namespace GameKit {
	#nullable enable
	/// <param name="descriptions">To be added.</param><param name="error">To be added.</param><summary>A delegate that is called by <see cref="M:GameKit.GKAchievementDescription.LoadAchievementDescriptions(GameKit.GKAchievementDescriptionHandler)" />.</summary><remarks>To be added.</remarks>
	public delegate void GKAchievementDescriptionHandler (GameKit.GKAchievementDescription[]? descriptions, NSError? error);
	/// <summary>A delegate that is called by <see cref="M:GameKit.GKLeaderboard.LoadCategories(GameKit.GKCategoryHandler)" />.</summary>
	public delegate void GKCategoryHandler (String[]? categories, String[]? titles, NSError? error);
	public delegate void GKChallengeComposeHandler (NSViewController composeController, bool issuedChallenge, String[]? sentPlayerIDs);
	public delegate void GKChallengeComposeHandler2 (NSViewController composeController, bool issuedChallenge, GameKit.GKPlayer[]? sentPlayers);
	public delegate void GKChallengeDefinitionHasActiveChallengesHandler (bool hasActiveChallenges, NSError? error);
	public delegate void GKChallengeDefinitionLoadDefinitionsHandler (GameKit.GKChallengeDefinition[] definitions, NSError? error);
	public delegate void GKChallengeDefinitionLoadImageHandler (NSImage? image, NSError? error);
	public delegate bool GKChallengePredicate (GameKit.GKChallenge challenge);
	/// <param name="achivements">To be added.</param><param name="error">To be added.</param><summary>A delegate passed to <see cref="M:GameKit.GKAchievement.LoadAchievements(GameKit.GKCompletionHandler)" /> that specifies behavior after the downloading of achievements from Game Center is completed.</summary><remarks>To be added.</remarks>
	public delegate void GKCompletionHandler (GameKit.GKAchievement[]? achivements, NSError? error);
	public delegate void GKEntriesForPlayerScopeHandler (GameKit.GKLeaderboardEntry? localPlayerEntry, GameKit.GKLeaderboardEntry[]? entries, IntPtr totalPlayerCount, NSError? error);
	public delegate void GKEntriesForPlayersHandler (GameKit.GKLeaderboardEntry? localPlayerEntry, GameKit.GKLeaderboardEntry[]? entries, NSError? error);
	public delegate void GKFetchItemsForIdentityVerificationSignatureCompletionHandler (NSUrl? publicKeyUrl, NSData? signature, NSData? salt, ulong timestamp, NSError? error);
	/// <summary>A delegate used with <see cref="M:GameKit.GKLocalPlayer.LoadFriends(GameKit.GKFriendsHandler)" /> and <see cref="M:GameKit.GKMatchmaker.FindPlayers(GameKit.GKMatchRequest,GameKit.GKFriendsHandler)" /> that defines behavior after the request completes.</summary>
	public delegate void GKFriendsHandler (String[]? friends, NSError? error);
	public delegate void GKGameActivityCheckPendingGameActivityExistenceHandler (bool pendingGameActivityExists);
	public delegate void GKGameActivityDefinitionLoadAchievementDescriptionsHandler (GameKit.GKAchievementDescription[]? descriptions, NSError? error);
	public delegate void GKGameActivityDefinitionLoadGameActivityDefinitionsHandler (GameKit.GKGameActivityDefinition[]? definitions, NSError? error);
	public delegate void GKGameActivityDefinitionLoadImageHandler (NSImage? image, NSError? error);
	public delegate void GKGameActivityDefinitionLoadLeaderboardsHandler (GameKit.GKLeaderboard[]? leaderboards, NSError? error);
	public delegate void GKGameActivityFindMatchHandler (GameKit.GKMatch? match, NSError? error);
	public delegate void GKGameActivityFindPlayersForHostedMatchHandler (GameKit.GKPlayer? match, NSError? error);
	/// <param name="publicKeyUrl">To be added.</param><param name="signature">To be added.</param><param name="salt">To be added.</param><param name="timestamp">To be added.</param><param name="error">To be added.</param><summary>Completion handler for the <see cref="M:GameKit.GKLocalPlayer.GenerateIdentityVerificationSignature(GameKit.GKIdentityVerificationSignatureHandler)" /> method.</summary><remarks>To be added.</remarks>
	public delegate void GKIdentityVerificationSignatureHandler (NSUrl? publicKeyUrl, NSData? signature, NSData? salt, ulong timestamp, NSError? error);
	public delegate void GKImageLoadedHandler (NSImage? image, NSError? error);
	/// <summary>A delegate that is used to define behavior after a response to a <see cref="T:GameKit.GKInvite" />.</summary>
	public delegate void GKInviteHandler (GameKit.GKInvite invite, String[]? playerIDs);
	/// <param name="leaderboardSets">To be added.</param><param name="error">To be added.</param><summary>Completion handler for the <see cref="M:GameKit.GKLeaderboardSet.LoadLeaderboardSets(GameKit.GKLeaderboardSetsHandler)" /> method.</summary><remarks>To be added.</remarks>
	public delegate void GKLeaderboardSetsHandler (GameKit.GKLeaderboardSet[]? leaderboardSets, NSError? error);
	/// <param name="leaderboards">To be added.</param><param name="error">To be added.</param><summary>Completion handler for the <see cref="M:GameKit.GKLeaderboardSet.LoadLeaderboards(GameKit.GKLeaderboardsHandler)" /> method.</summary><remarks>To be added.</remarks>
	public delegate void GKLeaderboardsHandler (GameKit.GKLeaderboard[]? leaderboards, NSError? error);
	public delegate bool GKMatchReinvitation (GameKit.GKMatch match, string playerId);
	public delegate bool GKMatchReinvitationForDisconnectedPlayer (GameKit.GKMatch match, GameKit.GKPlayer player);
	/// <param name="match">To be added.</param><param name="error">To be added.</param><summary>A delegate used with <see cref="M:GameKit.GKMatchmaker.FindMatch(GameKit.GKMatchRequest,GameKit.GKNotificationMatch)" /> that specifies behavior after a match has been made.</summary><remarks>To be added.</remarks>
	public delegate void GKNotificationMatch (GameKit.GKMatch? match, NSError? error);
	public delegate void GKPlayerPhotoLoaded (NSImage? photo, NSError? error);
	/// <summary>A delegate used with <see cref="P:GameKit.GKVoiceChat.PlayerStateUpdateHandler" /> that specifies behavior when the player's <see cref="T:GameKit.GKVoiceChatPlayerState" /> changes.</summary>
	public delegate void GKPlayerStateUpdateHandler (string playerId, GameKit.GKVoiceChatPlayerState state);
	/// <param name="players">To be added.</param><param name="error">To be added.</param><summary>A delegate used with <see cref="M:GameKit.GKPlayer.LoadPlayersForIdentifiers(System.String[],GameKit.GKPlayersHandler)" /> to specify behavior to happen after the players are loaded.</summary><remarks>To be added.</remarks>
	public delegate void GKPlayersHandler (GameKit.GKPlayer[]? players, NSError? error);
	/// <param name="activity">To be added.</param><param name="error">To be added.</param><summary>A delegate used with <see cref="M:GameKit.GKMatchmaker.QueryActivity(GameKit.GKQueryHandler)" /> and <see cref="M:GameKit.GKMatchmaker.QueryPlayerGroupActivity(System.IntPtr,GameKit.GKQueryHandler)" /> to specify behavior after the query is completed.</summary><remarks>To be added.</remarks>
	public delegate void GKQueryHandler (IntPtr activity, NSError? error);
	/// <param name="scoreArray">To be added.</param><param name="error">To be added.</param><summary>A delegate used with <see cref="M:GameKit.GKLeaderboard.LoadScores(GameKit.GKScoresLoadedHandler)" /> that specifies behavior after the scores are loaded.</summary><remarks>To be added.</remarks>
	public delegate void GKScoresLoadedHandler (GameKit.GKScore[]? scoreArray, NSError? error);
	/// <param name="matchData">To be added.</param><param name="error">To be added.</param><summary>A delegate that is used with <see cref="M:GameKit.GKTurnBasedMatch.LoadMatchData(GameKit.GKTurnBasedMatchData)" /> to specify behavior after the data is loaded.</summary><remarks>To be added.</remarks>
	public delegate void GKTurnBasedMatchData (NSData? matchData, NSError? error);
	/// <param name="match">To be added.</param><param name="error">To be added.</param><summary>A delegate that specifies the completion handler for <see cref="M:GameKit.GKTurnBasedMatch.FindMatch(GameKit.GKMatchRequest,GameKit.GKTurnBasedMatchRequest)" />.</summary><remarks>To be added.</remarks>
	public delegate void GKTurnBasedMatchRequest (GameKit.GKTurnBasedMatch? match, NSError? error);
	/// <param name="matches">To be added.</param><param name="error">To be added.</param><summary>A delegate used with <see cref="M:GameKit.GKTurnBasedMatch.LoadMatches(GameKit.GKTurnBasedMatchesRequest)" /> to specify behavior after the matches have been loaded.</summary><remarks>To be added.</remarks>
	public delegate void GKTurnBasedMatchesRequest (GameKit.GKTurnBasedMatch[]? matches, NSError? error);
}
namespace HealthKit {
	#nullable enable
	/// <summary>The completion handler for <see cref="HealthKit.HKAnchoredObjectQuery.HKAnchoredObjectQuery(HealthKit.HKSampleType,Foundation.NSPredicate,System.UIntPtr,System.UIntPtr,HealthKit.HKAnchoredObjectResultHandler)" />.</summary><summary>Completion handler for anchored object queries.</summary>
	public delegate void HKAnchoredObjectResultHandler (HealthKit.HKAnchoredObjectQuery query, HealthKit.HKSample[]? results, UIntPtr newAnchor, NSError? error);
	public delegate void HKAnchoredObjectUpdateHandler (HealthKit.HKAnchoredObjectQuery query, HealthKit.HKSample[]? addedObjects, HealthKit.HKDeletedObject[]? deletedObjects, HealthKit.HKQueryAnchor? newAnchor, NSError? error);
	public delegate void HKAttachmentStoreCompletionHandler (bool success, NSError? error);
	public delegate void HKAttachmentStoreDataHandler (NSData? dataChunk, NSError? error, bool done);
	public delegate void HKAttachmentStoreGetAttachmentCompletionHandler (HealthKit.HKAttachment[]? attachments, NSError? error);
	/// <summary>Completion handler for <see cref="T:HealthKit.HKCorrelationQuery" />.</summary>
	public delegate void HKCorrelationQueryResultHandler (HealthKit.HKCorrelationQuery query, HealthKit.HKCorrelation[]? correlations, NSError? error);
	public delegate void HKElectrocardiogramQueryDataHandler (HealthKit.HKElectrocardiogramQuery query, HealthKit.HKElectrocardiogramVoltageMeasurement? voltageMeasurement, bool done, NSError? error);
	public delegate void HKHealthStoreCompletionHandler (bool success, NSError? error);
	/// <param name="requestStatus">The resulting request status.</param><param name="error">The error, if one occurred..</param><summary>Handler to pass to <see cref="M:HealthKit.HKHealthStore.GetRequestStatusForAuthorizationToShare(Foundation.NSSet{HealthKit.HKSampleType},Foundation.NSSet{HealthKit.HKObjectType},HealthKit.HKHealthStoreGetRequestStatusForAuthorizationToShareHandler)" />.</summary>
	public delegate void HKHealthStoreGetRequestStatusForAuthorizationToShareHandler (HealthKit.HKAuthorizationRequestStatus requestStatus, NSError? error);
	public delegate void HKHealthStoreRecoverActiveWorkoutSessionHandler (HealthKit.HKWorkoutSession session, NSError error);
	public delegate void HKHeartbeatSeriesBuilderCompletionHandler (bool success, NSError? error);
	public delegate void HKHeartbeatSeriesQueryDataHandler (HealthKit.HKHeartbeatSeriesQuery query, double timeSinceSeriesStart, bool precededByGap, bool done, NSError? error);
	public delegate void HKObserverQueryDescriptorUpdateHandler (HealthKit.HKObserverQuery query, global::Foundation.NSSet<global::HealthKit.HKSampleType>? samples, [BlockCallback] Action completion, NSError? error);
	/// <summary>Update handler for <see cref="T:HealthKit.HKObserverQuery" /> objects.</summary>
	public delegate void HKObserverQueryUpdateHandler (HealthKit.HKObserverQuery query, [BlockCallback] Action completion, NSError? error);
	/// <param name="samples">The samples that were added.</param><param name="error">The error, if one occurred.</param><summary>Completion handler for <see cref="M:HealthKit.HKQuantitySeriesSampleBuilder.FinishSeries(Foundation.NSDictionary,HealthKit.HKQuantitySeriesSampleBuilderFinishSeriesDelegate)" />.</summary>
	public delegate void HKQuantitySeriesSampleBuilderFinishSeriesDelegate (HealthKit.HKQuantitySample[]? samples, NSError? error);
	/// <summary>A handler to pass to <see cref="HealthKit.HKQuantitySeriesSampleQuery.HKQuantitySeriesSampleQuery(HealthKit.HKQuantitySample,HealthKit.HKQuantitySeriesSampleQueryQuantityDelegate)" />.</summary>
	public delegate void HKQuantitySeriesSampleQueryQuantityDelegate (HealthKit.HKQuantitySeriesSampleQuery query, HealthKit.HKQuantity? quantity, NSDate? date, bool done, NSError? error);
	public delegate void HKQuantitySeriesSampleQueryQuantityHandler (HealthKit.HKQuantitySeriesSampleQuery query, HealthKit.HKQuantity? quantity, NSDateInterval? date, bool done, NSError? error);
	/// <summary>Result handler for <see cref="T:HealthKit.HKSampleQuery" />.</summary>
	public delegate void HKSampleQueryResultsHandler (HealthKit.HKSampleQuery query, HealthKit.HKSample[]? results, NSError? error);
	/// <summary>Completion handler for <see cref="T:HealthKit.HKSourceQuery" />.</summary>
	public delegate void HKSourceQueryCompletionHandler (HealthKit.HKSourceQuery query, NSSet? sources, NSError? error);
	/// <summary>Delegate handler for <see cref="M:HealthKit.HKStatisticsCollection.EnumerateStatistics(Foundation.NSDate,Foundation.NSDate,HealthKit.HKStatisticsCollectionEnumerator)" />.</summary>
	public delegate void HKStatisticsCollectionEnumerator (HealthKit.HKStatistics result, bool stop);
	/// <summary>The delegate for <see cref="P:HealthKit.HKStatisticsCollectionQuery.InitialResultsHandler" />.</summary>
	public delegate void HKStatisticsCollectionQueryInitialResultsHandler (HealthKit.HKStatisticsCollectionQuery query, HealthKit.HKStatisticsCollection? result, NSError? error);
	/// <summary>The delegate for <see cref="P:HealthKit.HKStatisticsCollectionQuery.StatisticsUpdated" />.</summary>
	public delegate void HKStatisticsCollectionQueryStatisticsUpdateHandler (HealthKit.HKStatisticsCollectionQuery query, HealthKit.HKStatistics? statistics, HealthKit.HKStatisticsCollection? collection, NSError? error);
	/// <summary>Results handler for <see cref="T:HealthKit.HKStatisticsQuery" />.</summary>
	public delegate void HKStatisticsQueryHandler (HealthKit.HKStatisticsQuery query, HealthKit.HKStatistics? result, NSError? error);
	/// <summary>Completion handler for <see cref="M:HealthKit.HKHealthStore.AddSamples(HealthKit.HKSample[],HealthKit.HKWorkout,HealthKit.HKStoreSampleAddedCallback)" />.</summary>
	public delegate void HKStoreSampleAddedCallback (bool success, NSError? error);
	public delegate void HKUserAnnotatedMedicationQueryCallback (HealthKit.HKUserAnnotatedMedicationQuery query, HealthKit.HKUserAnnotatedMedication? userAnnotatedMedication, bool done, NSError? error);
	public delegate void HKVerifiableClinicalRecordQueryResultHandler (HealthKit.HKVerifiableClinicalRecordQuery query, global::Foundation.NSArray<global::HealthKit.HKVerifiableClinicalRecord>? records, NSError? error);
	/// <param name="success">Whether the operation succeeded.</param><param name="error">The error that occurred, if <paramref name="success" /> was <see langword="false" />.</param><summary>Completion handler for adding metadata with <see cref="HealthKit.HKWorkoutRouteQuery.HKWorkoutRouteQuery(HealthKit.HKWorkoutRoute,HealthKit.HKWorkoutRouteBuilderDataHandler)" />.</summary>
	public delegate void HKWorkoutBuilderCompletionHandler (bool success, NSError? error);
	public delegate void HKWorkoutEffortRelationshipQueryResultsHandler (HealthKit.HKWorkoutEffortRelationshipQuery query, HealthKit.HKWorkoutEffortRelationship[]? relationships, HealthKit.HKQueryAnchor? newAnchor, NSError? error);
	public delegate void HKWorkoutRelationshipCallback (bool success, NSError? error);
	/// <param name="success">Whether the operation succeeded.</param><param name="error">The error that occurred, if <paramref name="success" /> was <see langword="false" />.</param><summary>Completion handler for adding metadata with <see cref="HealthKit.HKWorkoutRouteQuery.HKWorkoutRouteQuery(HealthKit.HKWorkoutRoute,HealthKit.HKWorkoutRouteBuilderDataHandler)" />.</summary>
	public delegate void HKWorkoutRouteBuilderAddMetadataHandler (bool success, NSError? error);
	public delegate void HKWorkoutRouteBuilderDataHandler (HealthKit.HKWorkoutRouteQuery query, CLLocation[]? routeData, bool done, NSError? error);
	public delegate void HKWorkoutRouteQueryDataHandler (HealthKit.HKWorkoutRouteQuery query, CLLocation[]? routeData, bool done, NSError? error);
}
namespace ImageCaptureCore {
	#nullable enable
	/// <summary>Completion handler for <see cref="M:ImageCaptureCore.ICCameraFile.RequestFingerprint(ImageCaptureCore.ICCameraFileRequestFingerprintCompletionHandler)" />.</summary>
	public delegate void ICCameraFileRequestFingerprintCompletionHandler (string? fingerprint, NSError? error);
	/// <summary>Completion handler for <see cref="M:ImageCaptureCore.ICCameraFile.RequestSecurityScopedUrl(ImageCaptureCore.ICCameraFileRequestSecurityScopedUrlCompletionHandler)" />.</summary>
	public delegate void ICCameraFileRequestSecurityScopedUrlCompletionHandler (NSUrl? url, NSError? error);
}
namespace ImageKit {
	#nullable enable
	public delegate bool SaveOptionsShouldShowUTType (ImageKit.IKSaveOptions saveOptions, string imageUTType);
}
namespace Intents {
	#nullable enable
	public delegate void INVoiceShortcutCenterGetVoiceShortcutsHandler (Intents.INVoiceShortcut[]? voiceShortcuts, NSError? error);
}
namespace JavaScriptCore {
	#nullable enable
	/// <summary>The delegate that can be used as the <see cref="P:JavaScriptCore.JSContext.ExceptionHandler" />.</summary>
	public delegate void JSContextExceptionHandler (JavaScriptCore.JSContext? context, JavaScriptCore.JSValue? exception);
	public delegate void JSPromiseCreationExecutor (JavaScriptCore.JSValue? resolve, JavaScriptCore.JSValue? rejected);
}
namespace LocalAuthentication {
	#nullable enable
	/// <summary>Signature for a function to be invoked in response to a <see cref="M:LocalAuthentication.LAContext.EvaluatePolicy(LocalAuthentication.LAPolicy,System.String,LocalAuthentication.LAContextReplyHandler)" /> invocation.</summary><remarks>The method when invoked returns a boolean indicating if the policy evaluation was successful, and on failure a detailed description of the error in the error parameter.</remarks>
	public delegate void LAContextReplyHandler (bool success, NSError? error);
	public delegate void LAPrivateKeyCompletionHandler (NSData? data, NSError? error);
	public delegate void LAPublicKeyCompletionHandler (NSData? data, NSError? error);
	public delegate void LAPublicKeyVerifyDataCompletionHandler (NSError? error);
	public delegate void LARightAuthorizeCompletionHandler (NSError? error);
	public delegate void LARightStoreCompletionHandler (LocalAuthentication.LAPersistedRight? right, NSError? error);
	public delegate void LARightStoreRemoveRightCompletionHandler (NSError? error);
	public delegate void LASecretCompletionHandler (NSData? data, NSError? error);
}
namespace MLCompute {
	#nullable enable
	public delegate void MLCGraphCompletionHandler (MLCompute.MLCTensor? resultTensor, NSError? error, double executionTime);
}
namespace MapKit {
	#nullable enable
	public delegate MapKit.MKClusterAnnotation MKCreateClusterAnnotation (MapKit.MKMapView mapView, MapKit.IMKAnnotation[] memberAnnotations);
	/// <param name="response">Returned if the routing request was successful</param><param name="error">If not <see langword="null" />, an error occurred with the request.</param><summary>The completion handler for calls to <see cref="M:MapKit.MKDirections.CalculateDirections(MapKit.MKDirectionsHandler)" />.</summary><remarks>To be added.</remarks><altmember cref="T:MapKit.MKDirectionsRequest" />
	public delegate void MKDirectionsHandler (MapKit.MKDirectionsResponse? response, NSError? error);
	/// <param name="response">Returned if the request was successful.</param><param name="error">If not <see langword="null" />, an error occurred with the request.</param><summary>The completion handler for calls to <see cref="M:MapKit.MKDirections.CalculateETA(MapKit.MKETAHandler)" />.</summary><remarks>To be added.</remarks>
	public delegate void MKETAHandler (MapKit.MKETAResponse? response, NSError? error);
	public delegate void MKGeocodingRequestGetMapItemsCompletionHandler (MapKit.MKMapItem[]? mapItems, NSError? error);
	/// <param name="response">To be added.</param><param name="error">To be added.</param><summary>A delegate that is used to handle the results of a map-based search.</summary><remarks>To be added.</remarks><altmember cref="T:MapKit.MKLocalSearch" />
	public delegate void MKLocalSearchCompletionHandler (MapKit.MKLocalSearchResponse? response, NSError? error);
	/// <param name="snapshot">The newly-created <see cref="T:MapKit.MKMapSnapshot" /></param><param name="error">If not <see langword="null" />, an error occurred with the request.</param><summary>The completion handler for <see cref="MapKit.MKMapSnapshotter.StartAsync(CoreFoundation.DispatchQueue)" />.</summary><remarks>To be added.</remarks>
	public delegate void MKMapSnapshotCompletionHandler (MapKit.MKMapSnapshot? snapshot, NSError? error);
	public delegate MapKit.MKAnnotationView? MKMapViewAnnotation (MapKit.MKMapView mapView, MapKit.IMKAnnotation annotation);
	public delegate MapKit.MKSelectionAccessory? MKMapViewDelegateGetSelectionAccessory (MapKit.MKMapView mapView, MapKit.IMKAnnotation annotation);
	public delegate MapKit.MKOverlayRenderer MKRendererForOverlayDelegate (MapKit.MKMapView mapView, MapKit.IMKOverlay overlay);
	public delegate void MKReverseGeocodingRequestGetMapItemsCompletionHandler (MapKit.MKMapItem[]? mapItems, NSError? error);
	/// <param name="tileData">To be added.</param><param name="error">To be added.</param><summary>The completion handler for <see cref="M:MapKit.MKTileOverlay.LoadTileAtPath(MapKit.MKTileOverlayPath,MapKit.MKTileOverlayLoadTileCompletionHandler)" />.</summary><remarks>To be added.</remarks>
	public delegate void MKTileOverlayLoadTileCompletionHandler (NSData? tileData, NSError? error);
}
namespace MediaAccessibility {
	#nullable enable
	public delegate void MAMusicHapticTrackAvailabilityCallback (bool musicHapticsAvailable);
	public delegate void MAMusicHapticTrackStatusObserver (string internationalStandardRecordingCode, bool musicHapticsActive);
}
namespace MediaExtension {
	#nullable enable
	public delegate void MEByteSourceReadBytesCallback (UIntPtr bytesRead, NSError? error);
	public delegate void MEByteSourceReadDataCallback (NSData? data, NSError? error);
	public delegate void MEFormatReaderLoadFileInfoCallback (MediaExtension.MEFileInfo? fileInfo, NSError? error);
	public delegate void MEFormatReaderLoadMetadataCallback (AVMetadataItem[]? metadata, NSError? error);
	public delegate void MEFormatReaderLoadTrackReadersCallback (MediaExtension.IMETrackReader[]? trackReaders, NSError? error);
	public delegate void MEFormatReaderParseAdditionalFragmentsCallback (MediaExtension.MEFormatReaderParseAdditionalFragmentsStatus fragmentStatus, NSError? error);
	public delegate void MERawProcessorProcessFrameCallback (CVPixelBuffer? pixelBuffer, NSError? error);
	public delegate void MESampleCursorLoadPostDecodeProcessingMetadataCallback (global::Foundation.NSDictionary<NSString, NSObject>? postDecodeProcessingMetadata, NSError? error);
	public delegate void MESampleCursorLoadSampleBufferCallback (CMSampleBuffer? newSampleBuffer, NSError? error);
	public delegate void MESampleCursorStepByTimeCallback (CMTime actualDecodeTime, bool positionWasPinned, NSError? error);
	public delegate void MESampleCursorStepInOrderCallback (long stepCount, NSError? error);
	public delegate void METrackReaderGenerateSampleCursorCallback (MediaExtension.IMESampleCursor? trackInfo, NSError? error);
	public delegate void METrackReaderLoadEstimatedDataRateCallback (float estimatedDataRate, NSError? error);
	public delegate void METrackReaderLoadMetadataCallback (AVMetadataItem[]? metadata, NSError? error);
	public delegate void METrackReaderLoadTotalSampleDataLengthCallback (long totalSampleDataLength, NSError? error);
	public delegate void METrackReaderLoadTrackInfoCallback (MediaExtension.METrackInfo? trackInfo, NSError? error);
	public delegate void METrackReaderLoadUneditedDurationCallback (CMTime uneditedDuration, NSError? error);
	public delegate void MEVideoDecoderDecodeFrameCallback (CVImageBuffer? imageBuffer, MediaExtension.MEDecodeFrameStatus decodeStatus, NSError? error);
}
namespace MediaPlayer {
	#nullable enable
	public delegate void MPMediaItemAnimatedArtworkPreviewImageRequestCallback (NSImage? image);
	public delegate void MPMediaItemAnimatedArtworkPreviewImageRequestHandler (CGSize size, [BlockCallback] MPMediaItemAnimatedArtworkPreviewImageRequestCallback completionHandler);
	public delegate void MPMediaItemAnimatedArtworkVideoAssetFileUrlRequestCallback (NSUrl? image);
	public delegate void MPMediaItemAnimatedArtworkVideoAssetFileUrlRequestHandler (CGSize size, [BlockCallback] MPMediaItemAnimatedArtworkVideoAssetFileUrlRequestCallback completionHandler);
	/// <param name="property">The property kind.</param><param name="value">The value associated with the property</param><param name="stop">Reference value, can be used to stop the enumeration.</param><summary>The delegate to be used as the <c>enumerator</c> argument to <see cref="M:MediaPlayer.MPMediaItem.EnumerateValues(Foundation.NSSet,MediaPlayer.MPMediaItemEnumerator)" />.</summary>
	public delegate void MPMediaItemEnumerator (string property, NSObject value, ref bool stop);
}
namespace Metal {
	#nullable enable
	public delegate void MTL4CommitFeedbackHandler (IMTL4CommitFeedback commitFeedback);
	public delegate void MTL4CreateBinaryFunctionCompletionHandler (IMTL4BinaryFunction? function, NSError? error);
	public delegate void MTL4CreateMachineLearningPipelineStateCompletionHandler (IMTL4MachineLearningPipelineState? mlPipelineState, NSError? error);
	public delegate void MTLCreateComputePipelineStateCompletionHandler (IMTLComputePipelineState? computePipelineState, NSError? error);
	public delegate void MTLCreateDynamicLibraryCompletionHandler (IMTLDynamicLibrary? library, NSError? error);
	public delegate void MTLCreateLibraryCompletionHandler (IMTLLibrary? library, NSError? error);
	public delegate void MTLCreateRenderPipelineStateCompletionHandler (IMTLRenderPipelineState? renderPipelineState, NSError? error);
	/// <summary>Completion handler for deallocating a buffer.</summary>
	public delegate void MTLDeallocator (IntPtr pointer, UIntPtr length);
	public delegate void MTLLogStateLogHandler (string? subSystem, string? category, MTLLogLevel logLevel, string message);
	public delegate void MTLNewComputePipelineStateWithReflectionCompletionHandler (IMTLComputePipelineState? computePipelineState, MTLComputePipelineReflection? reflection, NSError? error);
	public delegate void MTLNewRenderPipelineStateWithReflectionCompletionHandler (IMTLRenderPipelineState? renderPipelineState, MTLRenderPipelineReflection? reflection, NSError? error);
	public delegate void MTLSharedEventNotificationBlock (IMTLSharedEvent @event, ulong value);
}
namespace MetalKit {
	#nullable enable
	public delegate void MTKTextureLoaderArrayCallback (IMTLTexture[] textures, NSError? error);
	/// <summary>Completion handler for textures loaded with <see cref="T:MetalKit.MTKTextureLoader" />.</summary>
	public delegate void MTKTextureLoaderCallback (IMTLTexture? texture, NSError? error);
}
namespace MetalPerformanceShaders {
	#nullable enable
	public delegate void MPSAccelerationStructureCompletionHandler (MetalPerformanceShaders.MPSAccelerationStructure? structure);
	public delegate void MPSGradientNodeHandler (MetalPerformanceShaders.MPSNNFilterNode gradientNode, MetalPerformanceShaders.MPSNNFilterNode inferenceNode, MetalPerformanceShaders.MPSNNImageNode inferenceSource, MetalPerformanceShaders.MPSNNImageNode gradientSource);
}
namespace MetalPerformanceShadersGraph {
	#nullable enable
	public delegate void MPSGraphCompilationCompletionHandler (MPSGraphExecutable executable, NSError? error);
	public delegate void MPSGraphCompletionHandler (global::Foundation.NSDictionary<global::MetalPerformanceShadersGraph.MPSGraphTensor, global::MetalPerformanceShadersGraph.MPSGraphTensorData> resultsDictionary, NSError? error);
	public delegate MPSGraphTensor[] MPSGraphControlFlowDependencyBlock ();
	public delegate void MPSGraphExecutableCompletionHandler (MPSGraphTensorData[] results, NSError? error);
	public delegate void MPSGraphExecutableScheduledHandler (MPSGraphTensorData[] results, NSError? error);
	public delegate MPSGraphTensor[] MPSGraphForLoopBodyBlock (MPSGraphTensor index, MPSGraphTensor[] iterationArguments);
	public delegate MPSGraphTensor[] MPSGraphIfThenElseBlock ();
	public delegate void MPSGraphScheduledHandler (global::Foundation.NSDictionary<global::MetalPerformanceShadersGraph.MPSGraphTensor, global::MetalPerformanceShadersGraph.MPSGraphTensorData> resultsDictionary, NSError? error);
	public delegate MPSGraphTensor[] MPSGraphWhileAfterBlock (MPSGraphTensor[] bodyBlockArguments);
	public delegate MPSGraphTensor MPSGraphWhileBeforeBlock (MPSGraphTensor[] inputTensors, global::Foundation.NSMutableArray<global::MetalPerformanceShadersGraph.MPSGraphTensor> resultTensors);
}
namespace ModelIO {
	#nullable enable
	public delegate void MDLObjectHandler (MDLObject mdlObject, ref bool stop);
}
namespace MultipeerConnectivity {
	#nullable enable
	/// <param name="accept"><see langword="true" /> if the invitation should be accepted.</param><param name="session">The session to which the peer shouldbe connected.</param><summary>The delegate that serves as the invitation handler in calls to <see cref="M:MultipeerConnectivity.MCNearbyServiceAdvertiserDelegate.DidReceiveInvitationFromPeer(MultipeerConnectivity.MCNearbyServiceAdvertiser,MultipeerConnectivity.MCPeerID,Foundation.NSData,MultipeerConnectivity.MCNearbyServiceAdvertiserInvitationHandler)" />.</summary>
	public delegate void MCNearbyServiceAdvertiserInvitationHandler (bool accept, MultipeerConnectivity.MCSession? session);
	/// <summary>A delegate that serves as the completion handler for <see cref="M:MultipeerConnectivity.MCSession.NearbyConnectionDataForPeer(MultipeerConnectivity.MCPeerID,MultipeerConnectivity.MCSessionNearbyConnectionDataForPeerCompletionHandler)" />.</summary>
	public delegate void MCSessionNearbyConnectionDataForPeerCompletionHandler (NSData? connectionData, NSError? error);
}
namespace NaturalLanguage {
	#nullable enable
	public delegate void NLEnumerateNeighborsHandler (string neighbor, double distance, ref bool stop);
	/// <param name="tag">The tag on which to operate.</param><param name="tokenRange">The token range to process.</param><param name="stop"><see langword="false" /> to stop enumerating.</param><summary>Delegate to apply to tokens as they are enumerated by <see cref="M:NaturalLanguage.NLTagger.EnumerateTags(Foundation.NSRange,NaturalLanguage.NLTokenUnit,NaturalLanguage.NLTagScheme,NaturalLanguage.NLTaggerOptions,NaturalLanguage.NLTaggerEnumerateTagsContinuationHandler)" />.</summary>
	public delegate void NLTaggerEnumerateTagsContinuationHandler (NSString tag, NSRange tokenRange, out bool stop);
	/// <param name="tokenRange">The range of tokens to which to apply the delegate.</param><param name="flags">Tokenizer hints.</param><param name="stop"><see langword="false" /> to stop enumerating.</param><summary>Delegate to apply to tokens as they are enumerated by <see cref="M:NaturalLanguage.NLTokenizer.EnumerateTokens(Foundation.NSRange,NaturalLanguage.NLTokenizerEnumerateContinuationHandler)" />.</summary>
	public delegate void NLTokenizerEnumerateContinuationHandler (NSRange tokenRange, NaturalLanguage.NLTokenizerAttributes flags, out bool stop);
	public delegate void TokenVectorEnumeratorHandler (global::Foundation.NSArray<NSNumber> tokenVector, NSRange tokenRange, out bool stop);
}
namespace NetworkExtension {
	#nullable enable
	public delegate void NEAppProxyFlowOpenCallback (NSError? completionHandler);
	public delegate void NEDatagramAndFlowEndpointsRead (NSData[]? datagrams, global::Network.NWEndpoint[]? remoteEndpoints, NSError? error);
	public delegate void NEDatagramRead (NSData[]? datagrams, global::NetworkExtension.NWEndpoint[]? remoteEndpoints, NSError? error);
	public delegate void NEDatagramWriteResult (NSError? error);
	public delegate NEFilterPacketProviderVerdict NEFilterPacketHandler (NEFilterPacketContext context, IntPtr @interface, NETrafficDirection directiom, IntPtr packetBytes, UIntPtr packetLength);
	public delegate void NERelayManagerGetLastClientErrorsCallback (NSError[]? errors);
}
namespace NotificationCenter {
	#nullable enable
	public delegate bool NCWidgetListViewControllerShouldRemoveRow (NotificationCenter.NCWidgetListViewController list, UIntPtr row);
	public delegate bool NCWidgetListViewControllerShouldReorderRow (NotificationCenter.NCWidgetListViewController list, UIntPtr row);
	public delegate NSViewController NCWidgetListViewGetController (NotificationCenter.NCWidgetListViewController list, UIntPtr row);
}
namespace PassKit {
	#nullable enable
	public delegate void PKAddIdentityDocumentConfigurationGetConfigurationCompletionHandler (PassKit.PKAddIdentityDocumentConfiguration? credentialConfiguration, NSError? error);
	public delegate void PKInformationRequestCompletionBlock (PassKit.PKBarcodeEventMetadataResponse response);
	public delegate void PKPassLibrarySignDataCompletionHandler (NSData? signedData, NSData? signature, NSError? error);
	public delegate void PKSignatureRequestCompletionBlock (PassKit.PKBarcodeEventSignatureResponse response);
}
namespace PdfKit {
	#nullable enable
	public delegate Class ClassForAnnotationClassDelegate (Class sender);
	public delegate Class ClassForAnnotationTypeDelegate (string annotationType);
	public delegate NFloat PdfViewScale (PdfKit.PdfView sender, NFloat scale);
	public delegate string PdfViewTitle (PdfKit.PdfView sender);
}
namespace PencilKit {
	#nullable enable
	public delegate void PKInterpolatedPointsEnumeratorHandler (PencilKit.PKStrokePoint strokePoint, out bool stop);
}
namespace Phase {
	#nullable enable
	/// <summary>This is a delegate to provide audio data to a <see cref="T:Phase.PhasePullStreamNode" />.</summary><param name="isSilence">It's possible to hint to the receiver of the buffer that the returned audio samples are silence. Note that since this is  just a hint, the returned audio samples should also be silence.</param><param name="timeStamp">The HAL time when the sample is to be rendered.</param><param name="frameCount">The number of sample frames requested.</param><param name="outputData"><para>The list of audio buffers where to store the returned audio samples.</para><para>
	/// The caller will provide the list of audio buffers, but the callback may replace the
	/// <see cref="F:AudioToolbox.AudioBuffer.Data" /> pointer (and update the <see cref="F:AudioToolbox.AudioBuffer.DataByteSize" /> value)
	/// with a pointer to a memory location that the callback owns, and which will be valid until
	/// the next render cycle.
	/// </para></param><returns>0 in case of success, otherwise an OSStatus error code. The audio data will be assumed to be invalid in case of an error.</returns>
	public unsafe delegate int PhasePullStreamRenderBlock (Byte* isSilence, AudioToolbox.AudioTimeStamp* timeStamp, uint frameCount, AudioToolbox.AudioBufferList* outputData);
}
namespace Photos {
	#nullable enable
	/// <summary>A continuation handler for that is called by the Photos application to show progress for an image request.</summary>
	public delegate void PHAssetImageProgressHandler (double progress, NSError? error, out bool stop, NSDictionary? info);
	/// <summary>Delegate type used with <see cref="P:Photos.PHVideoRequestOptions.ProgressHandler" />.</summary>
	public delegate void PHAssetVideoProgressHandler (double progress, NSError? error, out bool stop, NSDictionary? info);
	/// <summary>Enumerates differences between snapshots of the object at the specified indices.</summary>
	public delegate void PHChangeDetailEnumerator (UIntPtr fromIndex, UIntPtr toIndex);
	/// <summary>Completion handler for the <see cref="Photos.PHAssetContentEditingInputExtensions.RequestContentEditingInput(Photos.PHAsset,Photos.PHContentEditingInputRequestOptions,Photos.PHContentEditingHandler)" /> method.</summary>
	public delegate void PHContentEditingHandler (PHContentEditingInput? contentEditingInput, NSDictionary requestStatusInfo);
	/// <summary>Enumerates the assets in a fetch result.</summary>
	public delegate void PHFetchResultEnumerator (NSObject element, UIntPtr elementIndex, out bool stop);
	/// <summary>Completion handler for the <see cref="M:Photos.PHImageManager.RequestAVAsset(Photos.PHAsset,Photos.PHVideoRequestOptions,Photos.PHImageManagerRequestAVAssetHandler)" /> method.</summary>
	public delegate void PHImageManagerRequestAVAssetHandler (AVAsset? asset, AVAudioMix? audioMix, NSDictionary? info);
	/// <summary>Completion handler for the <see cref="M:Photos.PHImageManager.RequestExportSession(Photos.PHAsset,Photos.PHVideoRequestOptions,System.String,Photos.PHImageManagerRequestExportHandler)" /> method.</summary>
	public delegate void PHImageManagerRequestExportHandler (AVAssetExportSession? exportSession, NSDictionary? info);
	public delegate void PHImageManagerRequestImageDataHandler (NSData? imageData, string? dataUti, ImageIO.CGImagePropertyOrientation orientation, NSDictionary? info);
	/// <summary>The result handler delegate for calls to <see cref="M:Photos.PHImageManager.RequestLivePhoto(Photos.PHAsset,CoreGraphics.CGSize,Photos.PHImageContentMode,Photos.PHLivePhotoRequestOptions,Photos.PHImageManagerRequestLivePhoto)" />.</summary>
	public delegate void PHImageManagerRequestLivePhoto (PHLivePhoto? livePhoto, NSDictionary? info);
	/// <summary>Completion handler for the <see cref="M:Photos.PHImageManager.RequestPlayerItem(Photos.PHAsset,Photos.PHVideoRequestOptions,Photos.PHImageManagerRequestPlayerHandler)" /> method.</summary>
	public delegate void PHImageManagerRequestPlayerHandler (AVPlayerItem? playerItem, NSDictionary? info);
	public delegate void PHImageResultHandler (NSImage? result, NSDictionary? info);
	/// <param name="frame">The video frame to process.</param><param name="error">An error in which to record problems that occurred while processing the frame.</param><summary>Delegate that is called on every frame of a Live Photo as it is processed.</summary><returns>A processed image that represents the frame.</returns>
	public delegate CIImage PHLivePhotoFrameProcessingBlock (IPHLivePhotoFrame frame, ref NSError error);
	public delegate void PHPersistentChangeFetchResultEnumerator (PHPersistentChange change, ref bool stop);
	/// <summary>Continuation handler for tracking image operation progress.</summary>
	public delegate void PHProgressHandler (double progress, ref bool stop);
}
namespace QuickLookUI {
	#nullable enable
	public delegate NSData QLPreviewReplyDataCreationHandler (QuickLookUI.QLPreviewReply reply, out NSError error);
	public delegate bool QLPreviewReplyDrawingHandler (CGContext context, QuickLookUI.QLPreviewReply reply, out NSError error);
	public delegate CGPDFDocument QLPreviewReplyUIDocumentCreationHandler (QuickLookUI.QLPreviewReply reply, out NSError error);
}
namespace ReplayKit {
	#nullable enable
	/// <param name="bundleID">The bundle ID of the newly loaded broadcasting service.</param><param name="displayName">The display name of the newly loaded broadcasting service.</param><param name="appIcon">The application icon of the newly loaded broadcasting service.</param><summary>Delegate that specifies the signature of the completion handler in calls to the <see cref="ReplayKit.NSExtensionContext_RPBroadcastExtension.LoadBroadcastingApplicationInfo(Foundation.NSExtensionContext,ReplayKit.LoadBroadcastingHandler)" /> method.</summary>
	public delegate void LoadBroadcastingHandler (string bundleID, string displayName, NSImage? appIcon);
}
namespace SafariServices {
	#nullable enable
	public delegate void SFExtensionValidationHandler (bool shouldHide, NSString text);
}
namespace SafetyKit {
	#nullable enable
	public delegate void SACrashDetectionManagerRequestAuthorizationCompletionHandler (SafetyKit.SAAuthorizationStatus status, NSError? error);
	public delegate void SAEmergencyResponseManagerDialVoiceCallCompletionHandler (bool requestAccepted, NSError? error);
}
namespace SceneKit {
	#nullable enable
	/// <summary>Completion handler used with <see cref="M:SceneKit.SCNAction.CustomAction(System.Double,SceneKit.SCNActionNodeWithElapsedTimeHandler)" />.</summary>
	public delegate void SCNActionNodeWithElapsedTimeHandler (SCNNode node, NFloat elapsedTime);
	public delegate void SCNAnimationDidStartHandler (SCNAnimation animation, ISCNAnimatable receiver);
	public delegate void SCNAnimationDidStopHandler (SCNAnimation animation, ISCNAnimatable receiver, bool completed);
	/// <summary>Completion handler for use with <see cref="M:SceneKit.SCNAnimationEvent.Create(System.Runtime.InteropServices.NFloat,SceneKit.SCNAnimationEventHandler)" />.</summary>
	public delegate void SCNAnimationEventHandler (ISCNAnimationProtocol animation, NSObject animatedObject, bool playingBackward);
	/// <summary>Completion handler used with <see cref="M:SceneKit.SCNShadable.HandleBinding(System.String,SceneKit.SCNBindingHandler)" />.</summary>
	public delegate void SCNBindingHandler (uint programId, uint location, SCNNode? renderedNode, SCNRenderer renderer);
	public delegate void SCNBufferBindingHandler (ISCNBufferStream buffer, SCNNode node, ISCNShadable shadable, SCNRenderer renderer);
	/// <summary>Delegate for the <see cref="M:SceneKit.SCNPhysicsField.CustomField(SceneKit.SCNFieldForceEvaluator)" /> method.</summary>
	public delegate SCNVector3 SCNFieldForceEvaluator (SCNVector3 position, SCNVector3 velocity, float mass, float charge, double timeInSeconds);
	public delegate void SCNNodeHandler (SCNNode node, out bool stop);
	/// <param name="node">The current <see cref="T:SceneKit.SCNNode" />.</param><param name="stop">An <c>out</c> parameter that, when set to true, stops the enumeration.</param><summary>Delegate for use with <see cref="M:SceneKit.SCNNode.FindNodes(SceneKit.SCNNodePredicate)" />.</summary>
	public delegate bool SCNNodePredicate (SCNNode node, out bool stop);
	/// <summary>Completion handler for use with <see cref="M:SceneKit.SCNParticleSystem.HandleEvent(SceneKit.SCNParticleEvent,Foundation.NSString[],SceneKit.SCNParticleEventHandler)" />.</summary>
	public delegate void SCNParticleEventHandler (IntPtr data, IntPtr dataStride, IntPtr indices, IntPtr count);
	/// <summary>Delegate used as the <c>handler</c> in <see cref="M:SceneKit.SCNParticleSystem.AddModifier(Foundation.NSString[],SceneKit.SCNParticleModifierStage,SceneKit.SCNParticleModifierHandler)" />.</summary>
	public delegate void SCNParticleModifierHandler (IntPtr data, IntPtr dataStride, IntPtr start, IntPtr end, float deltaTime);
	/// <param name="totalProgress">A number in [0,1.0] that indicates the relative progress of the export operation.</param><param name="error">An error that occurred.</param><param name="stop">Developers set this to true to cancel processing.</param><summary>Continuation handler that SceneKit repeatedly calls when exporting a scene.</summary>
	public delegate void SCNSceneExportProgressHandler (float totalProgress, NSError? error, out bool stop);
	/// <summary>Delegate that tests objects in the scene for inclusion.</summary>
	public delegate bool SCNSceneSourceFilter (NSObject entry, NSString identifier, ref bool stop);
	/// <summary>Callback used to reflect progress during execution of <see cref="M:SceneKit.SCNSceneSource.SceneFromOptions(SceneKit.SCNSceneLoadingOptions,SceneKit.SCNSceneSourceStatusHandler)" />.</summary>
	public delegate void SCNSceneSourceStatusHandler (float totalProgress, SCNSceneSourceStatus status, NSError? error, ref bool stopLoading);
	/// <summary>Delegate used in calls to <see cref="M:SceneKit.SCNTransformConstraint.Create(System.Boolean,SceneKit.SCNTransformConstraintHandler)" />.</summary>
	public delegate SCNMatrix4 SCNTransformConstraintHandler (SCNNode node, SCNMatrix4 transform);
}
namespace ScreenCaptureKit {
	#nullable enable
	public delegate void SCScreenshotManagerCaptureImageCallback (CGImage? image, NSError? error);
	public delegate void SCScreenshotManagerCaptureScreenshotCallback (ScreenCaptureKit.SCScreenshotOutput? output, NSError? error);
}
namespace ScreenTime {
	#nullable enable
	public delegate void STWebHistoryFetchHistoryCallback (global::Foundation.NSSet<NSUrl>? urls, NSError? error);
}
namespace ScriptingBridge {
	#nullable enable
	public delegate NSObject SBApplicationError (IntPtr appleEvent, NSError error);
}
namespace Security {
	#nullable enable
	public delegate void SecProtocolChallenge (SecProtocolMetadata metadata, [BlockCallback] SecProtocolChallengeComplete challengeComplete);
	public delegate void SecProtocolChallengeComplete (SecIdentity2 identity);
	public delegate void SecProtocolKeyUpdate (SecProtocolMetadata metadata, [BlockCallback] Action complete);
	public delegate void SecProtocolPreSharedKeySelection (SecProtocolMetadata metadata, DispatchData? psk_identity_hint, [BlockCallback] SecProtocolPreSharedKeySelectionComplete complete);
	public delegate void SecProtocolPreSharedKeySelectionComplete (DispatchData? psk_identity);
	public delegate void SecProtocolVerify (SecProtocolMetadata metadata, SecTrust2 trust, [BlockCallback] SecProtocolVerifyComplete verifyComplete);
	public delegate void SecProtocolVerifyComplete (bool complete);
}
namespace SoundAnalysis {
	#nullable enable
	public delegate void SNAudioFileAnalyzerAnalyzeHandler (bool didReachEndOfFile);
}
namespace Speech {
	#nullable enable
	public delegate void SFSpeechLanguageModelPrepareCustomModelHandler (NSError? error);
}
namespace SpriteKit {
	#nullable enable
	/// <summary>The delegate for a custom action, used with <see cref="M:SpriteKit.SKAction.CustomActionWithDuration(System.Double,SpriteKit.SKActionDurationHandler)" />.</summary>
	public delegate void SKActionDurationHandler (SKNode node, NFloat elapsedTime);
	/// <summary>A method that maps <paramref name="time" />, a value between 0 and 1, to a return value between 0 snd 1.</summary><remarks>Application developers should assign this delegate to a method that returns 0 for a <paramref name="time" /> value of 0, and 1 for a <paramref name="time" /> value of 1.</remarks>
	public delegate float SKActionTimingFunction (float time);
	/// <summary>A method that maps <paramref name="time" />, a value between 0 and 1, to a return value between 0 snd 1.</summary><remarks>Application developers should assign this delegate to a method that returns 0 for a <paramref name="time" /> value of 0, and 1 for a <paramref name="time" /> value of 1.</remarks>
	public delegate float SKActionTimingFunction2 (float time);
	/// <summary>A method that derives a force by applying the physics of a field to a body that is within the field.</summary>
	public delegate System.Numerics.Vector3 SKFieldForceEvaluator (System.Numerics.Vector4 position, System.Numerics.Vector4 velocity, float mass, float charge, double time);
	/// <summary>The delegate that acts as the enumeration handler for <see cref="M:SpriteKit.SKNode.EnumerateChildNodes(System.String,SpriteKit.SKNodeChildEnumeratorHandler)" />.</summary>
	public delegate void SKNodeChildEnumeratorHandler (SKNode node, out bool stop);
	/// <summary>The delegate used for enumerating bodies that fall along a ray when used with <see cref="M:SpriteKit.SKPhysicsWorld.EnumerateBodies(CoreGraphics.CGPoint,CoreGraphics.CGPoint,SpriteKit.SKPhysicsWorldBodiesAlongRayStartEnumeratorHandler)" />.</summary>
	public delegate void SKPhysicsWorldBodiesAlongRayStartEnumeratorHandler (SKPhysicsBody body, CGPoint point, CGVector normal, out bool stop);
	/// <summary>The delegate used to enumerate <see cref="T:SpriteKit.SKPhysicsBody" />s with <see cref="M:SpriteKit.SKPhysicsWorld.EnumerateBodies(CoreGraphics.CGPoint,SpriteKit.SKPhysicsWorldBodiesEnumeratorHandler)" /> and <see cref="M:SpriteKit.SKPhysicsWorld.EnumerateBodies(CoreGraphics.CGRect,SpriteKit.SKPhysicsWorldBodiesEnumeratorHandler)" /></summary><remarks><para> Note that because <paramref name="stop" /> is an <c>out</c> parameter, this cannot be specified using lambda syntax.</para></remarks>
	public delegate void SKPhysicsWorldBodiesEnumeratorHandler (SKPhysicsBody body, out bool stop);
	public delegate void SKTextureAtlasLoadCallback (NSError? error, SKTextureAtlas foundAtlases);
	/// <summary>A method that modifies a texture in place.</summary>
	public delegate void SKTextureModify (IntPtr pixelData, UIntPtr lengthInBytes);
}
namespace StoreKit {
	#nullable enable
	public delegate void SKArcadeServiceRegisterHandler (NSData? randomFromFP, uint randomFromFPLength, NSData? cmacOfAppPid, uint cmacOfAppPidLength, NSError? error);
	public delegate void SKArcadeServiceSubscriptionHandler (NSData? subscriptionStatus, uint subscriptionStatusLength, NSData? cmacOfNonce, uint cmacOfNonceLength, NSError? error);
}
namespace VideoSubscriberAccount {
	#nullable enable
	public delegate void VSUserAccountManagerCallback (NSError? error);
	public delegate void VSUserAccountManagerQueryAutoSignInTokenCallback (VideoSubscriberAccount.VSAutoSignInToken? token, NSError? error);
}
namespace VideoToolbox {
	#nullable enable
	public delegate void VTFrameProcessorProcessFrameOutputHandler (VideoToolbox.IVTFrameProcessorParameters parameters, CMTime presentationTimeStamp, bool isFinalOutput, NSError? error);
	public delegate void VTFrameProcessorProcessHandler (VideoToolbox.IVTFrameProcessorParameters parameters, NSError? error);
	public delegate void VTSuperResolutionScalerConfigurationDownloadConfigurationModelCallback (NSError? error);
}
namespace Vision {
	#nullable enable
	/// <param name="request">The <see cref="T:Vision.VNRequest" /> for which this is the delegate.</param><param name="error">If not <see langword="null" />, an error that occurred during vision processing.</param><summary>A delegate that is called once for each feature detected in a <see cref="T:Vision.VNRequest" />.</summary><remarks><para>Developers will typically downcast the <paramref name="request" /> to the expected subtype and retrieve relevant data from the downcast value:</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// var findFacesRequest = new VNDetectFaceRectanglesRequest((request, error) =>
	/// {
	/// if (error is not null)
	/// {
	/// 	   HandleError(error);
	/// }
	/// else
	/// {
	/// 		var frs = request as VNDetectFaceRectanglesRequest;
	/// 		// Assert frs == findFacesRequest  
	/// 		var rs = frs.GetResults<VNFaceObservation>();
	/// 		foreach (var fo in rs)
	/// 		{ // ... etc ...
	/// ]]></code></example></remarks>
	public delegate void VNRequestCompletionHandler (Vision.VNRequest request, NSError? error);
	public delegate void VNRequestProgressHandler (Vision.VNRequest request, double fractionCompleted, NSError? error);
}
namespace WebKit {
	#nullable enable
	public delegate WebKit.WebView CreateWebViewFromRequest (WebKit.WebView sender, NSUrlRequest request);
	public delegate WebKit.WebDragDestinationAction DragDestinationGetActionMask (WebKit.WebView webView, INSDraggingInfo draggingInfo);
	public delegate WebKit.WebDragSourceAction DragSourceGetActionMask (WebKit.WebView webView, CGPoint point);
	public delegate void WKDownloadDelegateDecidePlaceholderPolicyCallback (WebKit.WKDownloadPlaceholderPolicy policy, NSUrl? url);
	/// <param name="result">The result of a successful evaluation. <see langword="null" /> if error occurred.</param><param name="error">The exception that occurred. <see langword="null" /> if evaluation succeeded.</param><summary>The result of evaluating JavaScript code.</summary><remarks><para>If evaluation was successful, <paramref name="error" /> will be <see langword="null" />. If an error occurred, <paramref name="result" /> will be <see langword="null" />.</para></remarks>
	public delegate void WKJavascriptEvaluationResult (NSObject? result, NSError? error);
	public delegate void WKNavigationDelegateShouldGoToBackForwardListItemCallback (bool shouldGoToItem);
	public delegate void WKWebExtensionContextCallback (NSError? error);
	public delegate void WKWebExtensionControllerDataRecordCallback (WebKit.WKWebExtensionDataRecord? dataRecord);
	public delegate void WKWebExtensionControllerDataRecordsCallback (WebKit.WKWebExtensionDataRecord[] dataRecords);
	public delegate void WKWebExtensionControllerDelegateConnectCallback (NSError? error);
	public delegate void WKWebExtensionControllerDelegateOpenNewTabCallback (WebKit.IWKWebExtensionTab? newWindow, NSError? error);
	public delegate void WKWebExtensionControllerDelegateOpenNewWindowCallback (WebKit.IWKWebExtensionWindow? newWindow, NSError? error);
	public delegate void WKWebExtensionControllerDelegateOpenOptionsCallback (NSError? error);
	public delegate void WKWebExtensionControllerDelegatePresentPopupForActionCallback (NSError? error);
	public delegate void WKWebExtensionControllerDelegatePromptForPermissionMatchPatternsCallback (global::Foundation.NSSet<global::WebKit.WKWebExtensionMatchPattern> allowedMatchPatterns, NSDate? expirationDate);
	public delegate void WKWebExtensionControllerDelegatePromptForPermissionsCallback (global::Foundation.NSSet<NSString> allowedPermissions, NSDate? expirationDate);
	public delegate void WKWebExtensionControllerDelegatePromptForPermissionsToAccessUrlsCallback (global::Foundation.NSSet<NSUrl> allowedUrls, NSDate? expirationDate);
	public delegate void WKWebExtensionControllerDelegateSendMessageCallback (NSObject? replyMessage, NSError? error);
	public delegate void WKWebExtensionCreateCallback (WebKit.WKWebExtension? extension, NSError? error);
	public delegate void WKWebExtensionMessagePortDisconnectHandlerCallback (NSError? error);
	public delegate void WKWebExtensionMessagePortMessageHandlerCallback (NSObject? message, NSError? error);
	public delegate void WKWebExtensionMessagePortSendMessageCallback (NSError? error);
	public delegate void WKWebExtensionTabCallback (NSError? error);
	public delegate void WKWebExtensionTabDetectLocaleCallback (NSLocale? locale, NSError? error);
	public delegate void WKWebExtensionTabDuplicateCallback (WebKit.IWKWebExtensionTab? duplicatedTab, NSError? error);
	public delegate void WKWebExtensionTabTakeSnapshotCallback (NSImage? webpageImage, NSError? error);
	public delegate void WKWebExtensionWindowCallback (NSError? error);
	public delegate void WKWebViewFetchDataHandler (NSData? data, NSError? error);
	public delegate void WKWebViewRestoreDataHandler (NSError? error);
	public delegate void WKWebsiteDataStoreFetchDataHandler (NSData? data, NSError? error);
	public delegate void WKWebsiteDataStoreRestoreDataHandler (NSError? error);
	public delegate NSWindow WebDownloadRequest (WebKit.WebDownload download);
	public delegate NSObject WebResourceIdentifierRequest (WebKit.WebView sender, NSUrlRequest request, WebKit.WebDataSource dataSource);
	public delegate NSUrlRequest WebResourceOnRequestSend (WebKit.WebView sender, NSObject identifier, NSUrlRequest request, NSUrlResponse redirectResponse, WebKit.WebDataSource dataSource);
	public delegate bool WebViewConfirmationPanel (WebKit.WebView sender, string withMessage, WebKit.WebFrame initiatedByFrame);
	public delegate WebKit.WebView WebViewCreate (WebKit.WebView sender, NSUrlRequest request);
	public delegate bool WebViewGetBool (WebKit.WebView sender);
	public delegate NSMenuItem[] WebViewGetContextMenuItems (WebKit.WebView sender, NSDictionary forElement, NSMenuItem[] defaultMenuItems);
	public delegate float WebViewGetFloat (WebKit.WebView sender);
	public delegate CGRect WebViewGetRectangle (WebKit.WebView sender);
	public delegate NSResponder WebViewGetResponder (WebKit.WebView sender);
	public delegate string WebViewGetString (WebKit.WebView sender);
	public delegate bool WebViewJavaScriptFrame (WebKit.WebView sender, string message, WebKit.WebFrame initiatedByFrame);
	public delegate string WebViewJavaScriptInput (WebKit.WebView sender, string prompt, string defaultText);
	public delegate bool WebViewPerformAction (WebKit.WebView webView, Selector action, NSObject sender);
	public delegate bool WebViewPrompt (WebKit.WebView sender, string message);
	public delegate string WebViewPromptPanel (WebKit.WebView sender, string prompt, string defaultText, WebKit.WebFrame initiatedByFrame);
	public delegate bool WebViewValidateUserInterface (WebKit.WebView webView, NSObject validatedUserInterfaceItem, bool defaultValidation);
}
namespace iTunesLibrary {
	#nullable enable
	public delegate void ITLibMediaEntityEnumerateValuesHandler (NSString property, NSObject value, out bool stop);
}
