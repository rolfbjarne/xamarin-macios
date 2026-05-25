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
namespace AppKit {
	[Register("NSDocument", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSDocument : NSObject, INSEditorRegistration, INSFilePresenter, INSMenuItemValidation, INSUserActivityRestoring, INSUserInterfaceValidations {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPDFPrintOperationX = "PDFPrintOperation";
		static readonly NativeHandle selPDFPrintOperationXHandle = Selector.GetHandle ("PDFPrintOperation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccommodatePresentedItemDeletionWithCompletionHandler_X = "accommodatePresentedItemDeletionWithCompletionHandler:";
		static readonly NativeHandle selAccommodatePresentedItemDeletionWithCompletionHandler_XHandle = Selector.GetHandle ("accommodatePresentedItemDeletionWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccommodatePresentedItemEvictionWithCompletionHandler_X = "accommodatePresentedItemEvictionWithCompletionHandler:";
		static readonly NativeHandle selAccommodatePresentedItemEvictionWithCompletionHandler_XHandle = Selector.GetHandle ("accommodatePresentedItemEvictionWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccommodatePresentedSubitemDeletionAtURL_CompletionHandler_X = "accommodatePresentedSubitemDeletionAtURL:completionHandler:";
		static readonly NativeHandle selAccommodatePresentedSubitemDeletionAtURL_CompletionHandler_XHandle = Selector.GetHandle ("accommodatePresentedSubitemDeletionAtURL:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddWindowController_X = "addWindowController:";
		static readonly NativeHandle selAddWindowController_XHandle = Selector.GetHandle ("addWindowController:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowedClassesForRestorableStateKeyPath_X = "allowedClassesForRestorableStateKeyPath:";
		static readonly NativeHandle selAllowedClassesForRestorableStateKeyPath_XHandle = Selector.GetHandle ("allowedClassesForRestorableStateKeyPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsDocumentSharingX = "allowsDocumentSharing";
		static readonly NativeHandle selAllowsDocumentSharingXHandle = Selector.GetHandle ("allowsDocumentSharing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutosaveDocumentWithDelegate_DidAutosaveSelector_ContextInfo_X = "autosaveDocumentWithDelegate:didAutosaveSelector:contextInfo:";
		static readonly NativeHandle selAutosaveDocumentWithDelegate_DidAutosaveSelector_ContextInfo_XHandle = Selector.GetHandle ("autosaveDocumentWithDelegate:didAutosaveSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutosaveWithImplicitCancellability_CompletionHandler_X = "autosaveWithImplicitCancellability:completionHandler:";
		static readonly NativeHandle selAutosaveWithImplicitCancellability_CompletionHandler_XHandle = Selector.GetHandle ("autosaveWithImplicitCancellability:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutosavedContentsFileURLX = "autosavedContentsFileURL";
		static readonly NativeHandle selAutosavedContentsFileURLXHandle = Selector.GetHandle ("autosavedContentsFileURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutosavesDraftsX = "autosavesDrafts";
		static readonly NativeHandle selAutosavesDraftsXHandle = Selector.GetHandle ("autosavesDrafts");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutosavesInPlaceX = "autosavesInPlace";
		static readonly NativeHandle selAutosavesInPlaceXHandle = Selector.GetHandle ("autosavesInPlace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutosavingFileTypeX = "autosavingFileType";
		static readonly NativeHandle selAutosavingFileTypeXHandle = Selector.GetHandle ("autosavingFileType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutosavingIsImplicitlyCancellableX = "autosavingIsImplicitlyCancellable";
		static readonly NativeHandle selAutosavingIsImplicitlyCancellableXHandle = Selector.GetHandle ("autosavingIsImplicitlyCancellable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackupFileURLX = "backupFileURL";
		static readonly NativeHandle selBackupFileURLXHandle = Selector.GetHandle ("backupFileURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBrowseDocumentVersions_X = "browseDocumentVersions:";
		static readonly NativeHandle selBrowseDocumentVersions_XHandle = Selector.GetHandle ("browseDocumentVersions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanAsynchronouslyWriteToURL_OfType_ForSaveOperation_X = "canAsynchronouslyWriteToURL:ofType:forSaveOperation:";
		static readonly NativeHandle selCanAsynchronouslyWriteToURL_OfType_ForSaveOperation_XHandle = Selector.GetHandle ("canAsynchronouslyWriteToURL:ofType:forSaveOperation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanCloseDocumentWithDelegate_ShouldCloseSelector_ContextInfo_X = "canCloseDocumentWithDelegate:shouldCloseSelector:contextInfo:";
		static readonly NativeHandle selCanCloseDocumentWithDelegate_ShouldCloseSelector_ContextInfo_XHandle = Selector.GetHandle ("canCloseDocumentWithDelegate:shouldCloseSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanConcurrentlyReadDocumentsOfType_X = "canConcurrentlyReadDocumentsOfType:";
		static readonly NativeHandle selCanConcurrentlyReadDocumentsOfType_XHandle = Selector.GetHandle ("canConcurrentlyReadDocumentsOfType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeCountTokenForSaveOperation_X = "changeCountTokenForSaveOperation:";
		static readonly NativeHandle selChangeCountTokenForSaveOperation_XHandle = Selector.GetHandle ("changeCountTokenForSaveOperation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckAutosavingSafetyAndReturnError_X = "checkAutosavingSafetyAndReturnError:";
		static readonly NativeHandle selCheckAutosavingSafetyAndReturnError_XHandle = Selector.GetHandle ("checkAutosavingSafetyAndReturnError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCloseX = "close";
		static readonly NativeHandle selCloseXHandle = Selector.GetHandle ("close");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContinueActivityUsingBlock_X = "continueActivityUsingBlock:";
		static readonly NativeHandle selContinueActivityUsingBlock_XHandle = Selector.GetHandle ("continueActivityUsingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContinueAsynchronousWorkOnMainThreadUsingBlock_X = "continueAsynchronousWorkOnMainThreadUsingBlock:";
		static readonly NativeHandle selContinueAsynchronousWorkOnMainThreadUsingBlock_XHandle = Selector.GetHandle ("continueAsynchronousWorkOnMainThreadUsingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataOfType_Error_X = "dataOfType:error:";
		static readonly NativeHandle selDataOfType_Error_XHandle = Selector.GetHandle ("dataOfType:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultDraftNameX = "defaultDraftName";
		static readonly NativeHandle selDefaultDraftNameXHandle = Selector.GetHandle ("defaultDraftName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplayNameX = "displayName";
		static readonly NativeHandle selDisplayNameXHandle = Selector.GetHandle ("displayName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDuplicateAndReturnError_X = "duplicateAndReturnError:";
		static readonly NativeHandle selDuplicateAndReturnError_XHandle = Selector.GetHandle ("duplicateAndReturnError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDuplicateDocument_X = "duplicateDocument:";
		static readonly NativeHandle selDuplicateDocument_XHandle = Selector.GetHandle ("duplicateDocument:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDuplicateDocumentWithDelegate_DidDuplicateSelector_ContextInfo_X = "duplicateDocumentWithDelegate:didDuplicateSelector:contextInfo:";
		static readonly NativeHandle selDuplicateDocumentWithDelegate_DidDuplicateSelector_ContextInfo_XHandle = Selector.GetHandle ("duplicateDocumentWithDelegate:didDuplicateSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeRestorableStateWithCoder_X = "encodeRestorableStateWithCoder:";
		static readonly NativeHandle selEncodeRestorableStateWithCoder_XHandle = Selector.GetHandle ("encodeRestorableStateWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeRestorableStateWithCoder_BackgroundQueue_X = "encodeRestorableStateWithCoder:backgroundQueue:";
		static readonly NativeHandle selEncodeRestorableStateWithCoder_BackgroundQueue_XHandle = Selector.GetHandle ("encodeRestorableStateWithCoder:backgroundQueue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileAttributesToWriteToURL_OfType_ForSaveOperation_OriginalContentsURL_Error_X = "fileAttributesToWriteToURL:ofType:forSaveOperation:originalContentsURL:error:";
		static readonly NativeHandle selFileAttributesToWriteToURL_OfType_ForSaveOperation_OriginalContentsURL_Error_XHandle = Selector.GetHandle ("fileAttributesToWriteToURL:ofType:forSaveOperation:originalContentsURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileModificationDateX = "fileModificationDate";
		static readonly NativeHandle selFileModificationDateXHandle = Selector.GetHandle ("fileModificationDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileNameExtensionForType_SaveOperation_X = "fileNameExtensionForType:saveOperation:";
		static readonly NativeHandle selFileNameExtensionForType_SaveOperation_XHandle = Selector.GetHandle ("fileNameExtensionForType:saveOperation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileNameExtensionWasHiddenInLastRunSavePanelX = "fileNameExtensionWasHiddenInLastRunSavePanel";
		static readonly NativeHandle selFileNameExtensionWasHiddenInLastRunSavePanelXHandle = Selector.GetHandle ("fileNameExtensionWasHiddenInLastRunSavePanel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileTypeX = "fileType";
		static readonly NativeHandle selFileTypeXHandle = Selector.GetHandle ("fileType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileTypeFromLastRunSavePanelX = "fileTypeFromLastRunSavePanel";
		static readonly NativeHandle selFileTypeFromLastRunSavePanelXHandle = Selector.GetHandle ("fileTypeFromLastRunSavePanel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileURLX = "fileURL";
		static readonly NativeHandle selFileURLXHandle = Selector.GetHandle ("fileURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileWrapperOfType_Error_X = "fileWrapperOfType:error:";
		static readonly NativeHandle selFileWrapperOfType_Error_XHandle = Selector.GetHandle ("fileWrapperOfType:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasUnautosavedChangesX = "hasUnautosavedChanges";
		static readonly NativeHandle selHasUnautosavedChangesXHandle = Selector.GetHandle ("hasUnautosavedChanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasUndoManagerX = "hasUndoManager";
		static readonly NativeHandle selHasUndoManagerXHandle = Selector.GetHandle ("hasUndoManager");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitForURL_WithContentsOfURL_OfType_Error_X = "initForURL:withContentsOfURL:ofType:error:";
		static readonly NativeHandle selInitForURL_WithContentsOfURL_OfType_Error_XHandle = Selector.GetHandle ("initForURL:withContentsOfURL:ofType:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithContentsOfURL_OfType_Error_X = "initWithContentsOfURL:ofType:error:";
		static readonly NativeHandle selInitWithContentsOfURL_OfType_Error_XHandle = Selector.GetHandle ("initWithContentsOfURL:ofType:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithType_Error_X = "initWithType:error:";
		static readonly NativeHandle selInitWithType_Error_XHandle = Selector.GetHandle ("initWithType:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidateRestorableStateX = "invalidateRestorableState";
		static readonly NativeHandle selInvalidateRestorableStateXHandle = Selector.GetHandle ("invalidateRestorableState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsBrowsingVersionsX = "isBrowsingVersions";
		static readonly NativeHandle selIsBrowsingVersionsXHandle = Selector.GetHandle ("isBrowsingVersions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDocumentEditedX = "isDocumentEdited";
		static readonly NativeHandle selIsDocumentEditedXHandle = Selector.GetHandle ("isDocumentEdited");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDraftX = "isDraft";
		static readonly NativeHandle selIsDraftXHandle = Selector.GetHandle ("isDraft");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEntireFileLoadedX = "isEntireFileLoaded";
		static readonly NativeHandle selIsEntireFileLoadedXHandle = Selector.GetHandle ("isEntireFileLoaded");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsInViewingModeX = "isInViewingMode";
		static readonly NativeHandle selIsInViewingModeXHandle = Selector.GetHandle ("isInViewingMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsLockedX = "isLocked";
		static readonly NativeHandle selIsLockedXHandle = Selector.GetHandle ("isLocked");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsNativeType_X = "isNativeType:";
		static readonly NativeHandle selIsNativeType_XHandle = Selector.GetHandle ("isNativeType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeepBackupFileX = "keepBackupFile";
		static readonly NativeHandle selKeepBackupFileXHandle = Selector.GetHandle ("keepBackupFile");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLockDocument_X = "lockDocument:";
		static readonly NativeHandle selLockDocument_XHandle = Selector.GetHandle ("lockDocument:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLockDocumentWithCompletionHandler_X = "lockDocumentWithCompletionHandler:";
		static readonly NativeHandle selLockDocumentWithCompletionHandler_XHandle = Selector.GetHandle ("lockDocumentWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLockWithCompletionHandler_X = "lockWithCompletionHandler:";
		static readonly NativeHandle selLockWithCompletionHandler_XHandle = Selector.GetHandle ("lockWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakeWindowControllersX = "makeWindowControllers";
		static readonly NativeHandle selMakeWindowControllersXHandle = Selector.GetHandle ("makeWindowControllers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveDocument_X = "moveDocument:";
		static readonly NativeHandle selMoveDocument_XHandle = Selector.GetHandle ("moveDocument:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveDocumentToUbiquityContainer_X = "moveDocumentToUbiquityContainer:";
		static readonly NativeHandle selMoveDocumentToUbiquityContainer_XHandle = Selector.GetHandle ("moveDocumentToUbiquityContainer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveDocumentWithCompletionHandler_X = "moveDocumentWithCompletionHandler:";
		static readonly NativeHandle selMoveDocumentWithCompletionHandler_XHandle = Selector.GetHandle ("moveDocumentWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveToURL_CompletionHandler_X = "moveToURL:completionHandler:";
		static readonly NativeHandle selMoveToURL_CompletionHandler_XHandle = Selector.GetHandle ("moveToURL:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectDidBeginEditing_X = "objectDidBeginEditing:";
		static readonly NativeHandle selObjectDidBeginEditing_XHandle = Selector.GetHandle ("objectDidBeginEditing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectDidEndEditing_X = "objectDidEndEditing:";
		static readonly NativeHandle selObjectDidEndEditing_XHandle = Selector.GetHandle ("objectDidEndEditing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObservedPresentedItemUbiquityAttributesX = "observedPresentedItemUbiquityAttributes";
		static readonly NativeHandle selObservedPresentedItemUbiquityAttributesXHandle = Selector.GetHandle ("observedPresentedItemUbiquityAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformActivityWithSynchronousWaiting_UsingBlock_X = "performActivityWithSynchronousWaiting:usingBlock:";
		static readonly NativeHandle selPerformActivityWithSynchronousWaiting_UsingBlock_XHandle = Selector.GetHandle ("performActivityWithSynchronousWaiting:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformAsynchronousFileAccessUsingBlock_X = "performAsynchronousFileAccessUsingBlock:";
		static readonly NativeHandle selPerformAsynchronousFileAccessUsingBlock_XHandle = Selector.GetHandle ("performAsynchronousFileAccessUsingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformSynchronousFileAccessUsingBlock_X = "performSynchronousFileAccessUsingBlock:";
		static readonly NativeHandle selPerformSynchronousFileAccessUsingBlock_XHandle = Selector.GetHandle ("performSynchronousFileAccessUsingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreparePageLayout_X = "preparePageLayout:";
		static readonly NativeHandle selPreparePageLayout_XHandle = Selector.GetHandle ("preparePageLayout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareSavePanel_X = "prepareSavePanel:";
		static readonly NativeHandle selPrepareSavePanel_XHandle = Selector.GetHandle ("prepareSavePanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareSharingServicePicker_X = "prepareSharingServicePicker:";
		static readonly NativeHandle selPrepareSharingServicePicker_XHandle = Selector.GetHandle ("prepareSharingServicePicker:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentError_X = "presentError:";
		static readonly NativeHandle selPresentError_XHandle = Selector.GetHandle ("presentError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_X = "presentError:modalForWindow:delegate:didPresentSelector:contextInfo:";
		static readonly NativeHandle selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_XHandle = Selector.GetHandle ("presentError:modalForWindow:delegate:didPresentSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentedItemDidChangeX = "presentedItemDidChange";
		static readonly NativeHandle selPresentedItemDidChangeXHandle = Selector.GetHandle ("presentedItemDidChange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentedItemDidChangeUbiquityAttributes_X = "presentedItemDidChangeUbiquityAttributes:";
		static readonly NativeHandle selPresentedItemDidChangeUbiquityAttributes_XHandle = Selector.GetHandle ("presentedItemDidChangeUbiquityAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentedItemDidGainVersion_X = "presentedItemDidGainVersion:";
		static readonly NativeHandle selPresentedItemDidGainVersion_XHandle = Selector.GetHandle ("presentedItemDidGainVersion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentedItemDidLoseVersion_X = "presentedItemDidLoseVersion:";
		static readonly NativeHandle selPresentedItemDidLoseVersion_XHandle = Selector.GetHandle ("presentedItemDidLoseVersion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentedItemDidMoveToURL_X = "presentedItemDidMoveToURL:";
		static readonly NativeHandle selPresentedItemDidMoveToURL_XHandle = Selector.GetHandle ("presentedItemDidMoveToURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentedItemDidResolveConflictVersion_X = "presentedItemDidResolveConflictVersion:";
		static readonly NativeHandle selPresentedItemDidResolveConflictVersion_XHandle = Selector.GetHandle ("presentedItemDidResolveConflictVersion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentedItemOperationQueueX = "presentedItemOperationQueue";
		static readonly NativeHandle selPresentedItemOperationQueueXHandle = Selector.GetHandle ("presentedItemOperationQueue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentedItemURLX = "presentedItemURL";
		static readonly NativeHandle selPresentedItemURLXHandle = Selector.GetHandle ("presentedItemURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentedSubitemAtURL_DidGainVersion_X = "presentedSubitemAtURL:didGainVersion:";
		static readonly NativeHandle selPresentedSubitemAtURL_DidGainVersion_XHandle = Selector.GetHandle ("presentedSubitemAtURL:didGainVersion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentedSubitemAtURL_DidLoseVersion_X = "presentedSubitemAtURL:didLoseVersion:";
		static readonly NativeHandle selPresentedSubitemAtURL_DidLoseVersion_XHandle = Selector.GetHandle ("presentedSubitemAtURL:didLoseVersion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentedSubitemAtURL_DidMoveToURL_X = "presentedSubitemAtURL:didMoveToURL:";
		static readonly NativeHandle selPresentedSubitemAtURL_DidMoveToURL_XHandle = Selector.GetHandle ("presentedSubitemAtURL:didMoveToURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentedSubitemAtURL_DidResolveConflictVersion_X = "presentedSubitemAtURL:didResolveConflictVersion:";
		static readonly NativeHandle selPresentedSubitemAtURL_DidResolveConflictVersion_XHandle = Selector.GetHandle ("presentedSubitemAtURL:didResolveConflictVersion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentedSubitemDidAppearAtURL_X = "presentedSubitemDidAppearAtURL:";
		static readonly NativeHandle selPresentedSubitemDidAppearAtURL_XHandle = Selector.GetHandle ("presentedSubitemDidAppearAtURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentedSubitemDidChangeAtURL_X = "presentedSubitemDidChangeAtURL:";
		static readonly NativeHandle selPresentedSubitemDidChangeAtURL_XHandle = Selector.GetHandle ("presentedSubitemDidChangeAtURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreservesVersionsX = "preservesVersions";
		static readonly NativeHandle selPreservesVersionsXHandle = Selector.GetHandle ("preservesVersions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreviewRepresentableActivityItemsX = "previewRepresentableActivityItems";
		static readonly NativeHandle selPreviewRepresentableActivityItemsXHandle = Selector.GetHandle ("previewRepresentableActivityItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrimaryPresentedItemURLX = "primaryPresentedItemURL";
		static readonly NativeHandle selPrimaryPresentedItemURLXHandle = Selector.GetHandle ("primaryPresentedItemURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrintDocument_X = "printDocument:";
		static readonly NativeHandle selPrintDocument_XHandle = Selector.GetHandle ("printDocument:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrintDocumentWithSettings_ShowPrintPanel_Delegate_DidPrintSelector_ContextInfo_X = "printDocumentWithSettings:showPrintPanel:delegate:didPrintSelector:contextInfo:";
		static readonly NativeHandle selPrintDocumentWithSettings_ShowPrintPanel_Delegate_DidPrintSelector_ContextInfo_XHandle = Selector.GetHandle ("printDocumentWithSettings:showPrintPanel:delegate:didPrintSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrintInfoX = "printInfo";
		static readonly NativeHandle selPrintInfoXHandle = Selector.GetHandle ("printInfo");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrintOperationWithSettings_Error_X = "printOperationWithSettings:error:";
		static readonly NativeHandle selPrintOperationWithSettings_Error_XHandle = Selector.GetHandle ("printOperationWithSettings:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadFromData_OfType_Error_X = "readFromData:ofType:error:";
		static readonly NativeHandle selReadFromData_OfType_Error_XHandle = Selector.GetHandle ("readFromData:ofType:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadFromFileWrapper_OfType_Error_X = "readFromFileWrapper:ofType:error:";
		static readonly NativeHandle selReadFromFileWrapper_OfType_Error_XHandle = Selector.GetHandle ("readFromFileWrapper:ofType:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadFromURL_OfType_Error_X = "readFromURL:ofType:error:";
		static readonly NativeHandle selReadFromURL_OfType_Error_XHandle = Selector.GetHandle ("readFromURL:ofType:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadableTypesX = "readableTypes";
		static readonly NativeHandle selReadableTypesXHandle = Selector.GetHandle ("readableTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRelinquishPresentedItemToReader_X = "relinquishPresentedItemToReader:";
		static readonly NativeHandle selRelinquishPresentedItemToReader_XHandle = Selector.GetHandle ("relinquishPresentedItemToReader:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRelinquishPresentedItemToWriter_X = "relinquishPresentedItemToWriter:";
		static readonly NativeHandle selRelinquishPresentedItemToWriter_XHandle = Selector.GetHandle ("relinquishPresentedItemToWriter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveWindowController_X = "removeWindowController:";
		static readonly NativeHandle selRemoveWindowController_XHandle = Selector.GetHandle ("removeWindowController:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenameDocument_X = "renameDocument:";
		static readonly NativeHandle selRenameDocument_XHandle = Selector.GetHandle ("renameDocument:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRestorableStateKeyPathsX = "restorableStateKeyPaths";
		static readonly NativeHandle selRestorableStateKeyPathsXHandle = Selector.GetHandle ("restorableStateKeyPaths");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRestoreDocumentWindowWithIdentifier_State_CompletionHandler_X = "restoreDocumentWindowWithIdentifier:state:completionHandler:";
		static readonly NativeHandle selRestoreDocumentWindowWithIdentifier_State_CompletionHandler_XHandle = Selector.GetHandle ("restoreDocumentWindowWithIdentifier:state:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRestoreStateWithCoder_X = "restoreStateWithCoder:";
		static readonly NativeHandle selRestoreStateWithCoder_XHandle = Selector.GetHandle ("restoreStateWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRestoreUserActivityState_X = "restoreUserActivityState:";
		static readonly NativeHandle selRestoreUserActivityState_XHandle = Selector.GetHandle ("restoreUserActivityState:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRevertDocumentToSaved_X = "revertDocumentToSaved:";
		static readonly NativeHandle selRevertDocumentToSaved_XHandle = Selector.GetHandle ("revertDocumentToSaved:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRevertToContentsOfURL_OfType_Error_X = "revertToContentsOfURL:ofType:error:";
		static readonly NativeHandle selRevertToContentsOfURL_OfType_Error_XHandle = Selector.GetHandle ("revertToContentsOfURL:ofType:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunModalPageLayoutWithPrintInfo_Delegate_DidRunSelector_ContextInfo_X = "runModalPageLayoutWithPrintInfo:delegate:didRunSelector:contextInfo:";
		static readonly NativeHandle selRunModalPageLayoutWithPrintInfo_Delegate_DidRunSelector_ContextInfo_XHandle = Selector.GetHandle ("runModalPageLayoutWithPrintInfo:delegate:didRunSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunModalPrintOperation_Delegate_DidRunSelector_ContextInfo_X = "runModalPrintOperation:delegate:didRunSelector:contextInfo:";
		static readonly NativeHandle selRunModalPrintOperation_Delegate_DidRunSelector_ContextInfo_XHandle = Selector.GetHandle ("runModalPrintOperation:delegate:didRunSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunModalSavePanelForSaveOperation_Delegate_DidSaveSelector_ContextInfo_X = "runModalSavePanelForSaveOperation:delegate:didSaveSelector:contextInfo:";
		static readonly NativeHandle selRunModalSavePanelForSaveOperation_Delegate_DidSaveSelector_ContextInfo_XHandle = Selector.GetHandle ("runModalSavePanelForSaveOperation:delegate:didSaveSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunPageLayout_X = "runPageLayout:";
		static readonly NativeHandle selRunPageLayout_XHandle = Selector.GetHandle ("runPageLayout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveDocument_X = "saveDocument:";
		static readonly NativeHandle selSaveDocument_XHandle = Selector.GetHandle ("saveDocument:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveDocumentAs_X = "saveDocumentAs:";
		static readonly NativeHandle selSaveDocumentAs_XHandle = Selector.GetHandle ("saveDocumentAs:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveDocumentTo_X = "saveDocumentTo:";
		static readonly NativeHandle selSaveDocumentTo_XHandle = Selector.GetHandle ("saveDocumentTo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveDocumentToPDF_X = "saveDocumentToPDF:";
		static readonly NativeHandle selSaveDocumentToPDF_XHandle = Selector.GetHandle ("saveDocumentToPDF:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveDocumentWithDelegate_DidSaveSelector_ContextInfo_X = "saveDocumentWithDelegate:didSaveSelector:contextInfo:";
		static readonly NativeHandle selSaveDocumentWithDelegate_DidSaveSelector_ContextInfo_XHandle = Selector.GetHandle ("saveDocumentWithDelegate:didSaveSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSavePanelShowsFileFormatsControlX = "savePanelShowsFileFormatsControl";
		static readonly NativeHandle selSavePanelShowsFileFormatsControlXHandle = Selector.GetHandle ("savePanelShowsFileFormatsControl");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSavePresentedItemChangesWithCompletionHandler_X = "savePresentedItemChangesWithCompletionHandler:";
		static readonly NativeHandle selSavePresentedItemChangesWithCompletionHandler_XHandle = Selector.GetHandle ("savePresentedItemChangesWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveToURL_OfType_ForSaveOperation_CompletionHandler_X = "saveToURL:ofType:forSaveOperation:completionHandler:";
		static readonly NativeHandle selSaveToURL_OfType_ForSaveOperation_CompletionHandler_XHandle = Selector.GetHandle ("saveToURL:ofType:forSaveOperation:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveToURL_OfType_ForSaveOperation_Delegate_DidSaveSelector_ContextInfo_X = "saveToURL:ofType:forSaveOperation:delegate:didSaveSelector:contextInfo:";
		static readonly NativeHandle selSaveToURL_OfType_ForSaveOperation_Delegate_DidSaveSelector_ContextInfo_XHandle = Selector.GetHandle ("saveToURL:ofType:forSaveOperation:delegate:didSaveSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveToURL_OfType_ForSaveOperation_Error_X = "saveToURL:ofType:forSaveOperation:error:";
		static readonly NativeHandle selSaveToURL_OfType_ForSaveOperation_Error_XHandle = Selector.GetHandle ("saveToURL:ofType:forSaveOperation:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScheduleAutosavingX = "scheduleAutosaving";
		static readonly NativeHandle selScheduleAutosavingXHandle = Selector.GetHandle ("scheduleAutosaving");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutosavedContentsFileURL_X = "setAutosavedContentsFileURL:";
		static readonly NativeHandle selSetAutosavedContentsFileURL_XHandle = Selector.GetHandle ("setAutosavedContentsFileURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDisplayName_X = "setDisplayName:";
		static readonly NativeHandle selSetDisplayName_XHandle = Selector.GetHandle ("setDisplayName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDraft_X = "setDraft:";
		static readonly NativeHandle selSetDraft_XHandle = Selector.GetHandle ("setDraft:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFileModificationDate_X = "setFileModificationDate:";
		static readonly NativeHandle selSetFileModificationDate_XHandle = Selector.GetHandle ("setFileModificationDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFileType_X = "setFileType:";
		static readonly NativeHandle selSetFileType_XHandle = Selector.GetHandle ("setFileType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFileURL_X = "setFileURL:";
		static readonly NativeHandle selSetFileURL_XHandle = Selector.GetHandle ("setFileURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHasUndoManager_X = "setHasUndoManager:";
		static readonly NativeHandle selSetHasUndoManager_XHandle = Selector.GetHandle ("setHasUndoManager:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreviewRepresentableActivityItems_X = "setPreviewRepresentableActivityItems:";
		static readonly NativeHandle selSetPreviewRepresentableActivityItems_XHandle = Selector.GetHandle ("setPreviewRepresentableActivityItems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrintInfo_X = "setPrintInfo:";
		static readonly NativeHandle selSetPrintInfo_XHandle = Selector.GetHandle ("setPrintInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUndoManager_X = "setUndoManager:";
		static readonly NativeHandle selSetUndoManager_XHandle = Selector.GetHandle ("setUndoManager:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUserActivity_X = "setUserActivity:";
		static readonly NativeHandle selSetUserActivity_XHandle = Selector.GetHandle ("setUserActivity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetWindow_X = "setWindow:";
		static readonly NativeHandle selSetWindow_XHandle = Selector.GetHandle ("setWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShareDocumentWithSharingService_CompletionHandler_X = "shareDocumentWithSharingService:completionHandler:";
		static readonly NativeHandle selShareDocumentWithSharingService_CompletionHandler_XHandle = Selector.GetHandle ("shareDocumentWithSharingService:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldChangePrintInfo_X = "shouldChangePrintInfo:";
		static readonly NativeHandle selShouldChangePrintInfo_XHandle = Selector.GetHandle ("shouldChangePrintInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldCloseWindowController_Delegate_ShouldCloseSelector_ContextInfo_X = "shouldCloseWindowController:delegate:shouldCloseSelector:contextInfo:";
		static readonly NativeHandle selShouldCloseWindowController_Delegate_ShouldCloseSelector_ContextInfo_XHandle = Selector.GetHandle ("shouldCloseWindowController:delegate:shouldCloseSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldRunSavePanelWithAccessoryViewX = "shouldRunSavePanelWithAccessoryView";
		static readonly NativeHandle selShouldRunSavePanelWithAccessoryViewXHandle = Selector.GetHandle ("shouldRunSavePanelWithAccessoryView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowWindowsX = "showWindows";
		static readonly NativeHandle selShowWindowsXHandle = Selector.GetHandle ("showWindows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopBrowsingVersionsWithCompletionHandler_X = "stopBrowsingVersionsWithCompletionHandler:";
		static readonly NativeHandle selStopBrowsingVersionsWithCompletionHandler_XHandle = Selector.GetHandle ("stopBrowsingVersionsWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnblockUserInteractionX = "unblockUserInteraction";
		static readonly NativeHandle selUnblockUserInteractionXHandle = Selector.GetHandle ("unblockUserInteraction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUndoManagerX = "undoManager";
		static readonly NativeHandle selUndoManagerXHandle = Selector.GetHandle ("undoManager");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnlockDocument_X = "unlockDocument:";
		static readonly NativeHandle selUnlockDocument_XHandle = Selector.GetHandle ("unlockDocument:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnlockDocumentWithCompletionHandler_X = "unlockDocumentWithCompletionHandler:";
		static readonly NativeHandle selUnlockDocumentWithCompletionHandler_XHandle = Selector.GetHandle ("unlockDocumentWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnlockWithCompletionHandler_X = "unlockWithCompletionHandler:";
		static readonly NativeHandle selUnlockWithCompletionHandler_XHandle = Selector.GetHandle ("unlockWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateChangeCount_X = "updateChangeCount:";
		static readonly NativeHandle selUpdateChangeCount_XHandle = Selector.GetHandle ("updateChangeCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateChangeCountWithToken_ForSaveOperation_X = "updateChangeCountWithToken:forSaveOperation:";
		static readonly NativeHandle selUpdateChangeCountWithToken_ForSaveOperation_XHandle = Selector.GetHandle ("updateChangeCountWithToken:forSaveOperation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateUserActivityState_X = "updateUserActivityState:";
		static readonly NativeHandle selUpdateUserActivityState_XHandle = Selector.GetHandle ("updateUserActivityState:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserActivityX = "userActivity";
		static readonly NativeHandle selUserActivityXHandle = Selector.GetHandle ("userActivity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesUbiquitousStorageX = "usesUbiquitousStorage";
		static readonly NativeHandle selUsesUbiquitousStorageXHandle = Selector.GetHandle ("usesUbiquitousStorage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateMenuItem_X = "validateMenuItem:";
		static readonly NativeHandle selValidateMenuItem_XHandle = Selector.GetHandle ("validateMenuItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateUserInterfaceItem_X = "validateUserInterfaceItem:";
		static readonly NativeHandle selValidateUserInterfaceItem_XHandle = Selector.GetHandle ("validateUserInterfaceItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWillNotPresentError_X = "willNotPresentError:";
		static readonly NativeHandle selWillNotPresentError_XHandle = Selector.GetHandle ("willNotPresentError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWillPresentError_X = "willPresentError:";
		static readonly NativeHandle selWillPresentError_XHandle = Selector.GetHandle ("willPresentError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWindowControllerDidLoadNib_X = "windowControllerDidLoadNib:";
		static readonly NativeHandle selWindowControllerDidLoadNib_XHandle = Selector.GetHandle ("windowControllerDidLoadNib:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWindowControllerWillLoadNib_X = "windowControllerWillLoadNib:";
		static readonly NativeHandle selWindowControllerWillLoadNib_XHandle = Selector.GetHandle ("windowControllerWillLoadNib:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWindowControllersX = "windowControllers";
		static readonly NativeHandle selWindowControllersXHandle = Selector.GetHandle ("windowControllers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWindowForSheetX = "windowForSheet";
		static readonly NativeHandle selWindowForSheetXHandle = Selector.GetHandle ("windowForSheet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWindowNibNameX = "windowNibName";
		static readonly NativeHandle selWindowNibNameXHandle = Selector.GetHandle ("windowNibName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWritableTypesX = "writableTypes";
		static readonly NativeHandle selWritableTypesXHandle = Selector.GetHandle ("writableTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWritableTypesForSaveOperation_X = "writableTypesForSaveOperation:";
		static readonly NativeHandle selWritableTypesForSaveOperation_XHandle = Selector.GetHandle ("writableTypesForSaveOperation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteSafelyToURL_OfType_ForSaveOperation_Error_X = "writeSafelyToURL:ofType:forSaveOperation:error:";
		static readonly NativeHandle selWriteSafelyToURL_OfType_ForSaveOperation_Error_XHandle = Selector.GetHandle ("writeSafelyToURL:ofType:forSaveOperation:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteToURL_OfType_Error_X = "writeToURL:ofType:error:";
		static readonly NativeHandle selWriteToURL_OfType_Error_XHandle = Selector.GetHandle ("writeToURL:ofType:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteToURL_OfType_ForSaveOperation_OriginalContentsURL_Error_X = "writeToURL:ofType:forSaveOperation:originalContentsURL:error:";
		static readonly NativeHandle selWriteToURL_OfType_ForSaveOperation_OriginalContentsURL_Error_XHandle = Selector.GetHandle ("writeToURL:ofType:forSaveOperation:originalContentsURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSDocument");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSDocument" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSDocument () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
			}
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NSDocument (NSObjectFlag t) : base (t)
		{
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NSDocument (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSDocument (string typeName, out NSError? outError)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeName = CFString.CreateNative (typeName);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selInitWithType_Error_XHandle, nstypeName, &outErrorValue), "initWithType:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithType_Error_XHandle, nstypeName, &outErrorValue), "initWithType:error:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeName);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
		}
		[Export ("initWithContentsOfURL:ofType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSDocument (NSUrl url, string typeName, out NSError? outError)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeName = CFString.CreateNative (typeName);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInitWithContentsOfURL_OfType_Error_XHandle, url__handle__, nstypeName, &outErrorValue), "initWithContentsOfURL:ofType:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithContentsOfURL_OfType_Error_XHandle, url__handle__, nstypeName, &outErrorValue), "initWithContentsOfURL:ofType:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			CFString.ReleaseNative (nstypeName);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
		}
		[Export ("initForURL:withContentsOfURL:ofType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSDocument (NSUrl? documentUrl, NSUrl documentContentsUrl, string typeName, out NSError? outError)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var documentUrl__handle__ = documentUrl.GetHandle ();
			var documentContentsUrl__handle__ = documentContentsUrl!.GetNonNullHandle (nameof (documentContentsUrl));
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeName = CFString.CreateNative (typeName);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInitForURL_WithContentsOfURL_OfType_Error_XHandle, documentUrl__handle__, documentContentsUrl__handle__, nstypeName, &outErrorValue), "initForURL:withContentsOfURL:ofType:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selInitForURL_WithContentsOfURL_OfType_Error_XHandle, documentUrl__handle__, documentContentsUrl__handle__, nstypeName, &outErrorValue), "initForURL:withContentsOfURL:ofType:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (documentUrl);
			GC.KeepAlive (documentContentsUrl);
			CFString.ReleaseNative (nstypeName);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
		}
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("accommodatePresentedItemDeletionWithCompletionHandler:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AccommodatePresentedItemDeletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAccommodatePresentedItemDeletionWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAccommodatePresentedItemDeletionWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("accommodatePresentedItemEvictionWithCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AccommodatePresentedItemEviction ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAccommodatePresentedItemEvictionWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAccommodatePresentedItemEvictionWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="url">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("accommodatePresentedSubitemDeletionAtURL:completionHandler:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AccommodatePresentedSubitemDeletion (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAccommodatePresentedSubitemDeletionAtURL_CompletionHandler_XHandle, url__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAccommodatePresentedSubitemDeletionAtURL_CompletionHandler_XHandle, url__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		[Export ("addWindowController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddWindowController (NSWindowController windowController)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var windowController__handle__ = windowController!.GetNonNullHandle (nameof (windowController));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddWindowController_XHandle, windowController__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddWindowController_XHandle, windowController__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (windowController);
		}
		[Export ("autosaveWithImplicitCancellability:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Autosave (bool autosavingIsImplicitlyCancellable, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDocumentCompletionHandler))]NSDocumentCompletionHandler completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSDocumentCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NativeHandle (this.Handle, selAutosaveWithImplicitCancellability_CompletionHandler_XHandle, autosavingIsImplicitlyCancellable ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_NativeHandle (&__objc_super__, selAutosaveWithImplicitCancellability_CompletionHandler_XHandle, autosavingIsImplicitlyCancellable ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("autosaveDocumentWithDelegate:didAutosaveSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AutosaveDocument (NSObject? delegateObject, Selector? didAutosaveSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var delegateObject__handle__ = delegateObject.GetHandle ();
			var didAutosaveSelector__handle__ = didAutosaveSelector.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, selAutosaveDocumentWithDelegate_DidAutosaveSelector_ContextInfo_XHandle, delegateObject__handle__, didAutosaveSelector__handle__, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selAutosaveDocumentWithDelegate_DidAutosaveSelector_ContextInfo_XHandle, delegateObject__handle__, didAutosaveSelector__handle__, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (delegateObject);
			GC.KeepAlive (didAutosaveSelector);
		}
		[Export ("autosavesInPlace")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AutosavesInPlace ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selAutosavesInPlaceXHandle);
			return ret != 0;
		}
		[Export ("browseDocumentVersions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BrowseDocumentVersions (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selBrowseDocumentVersions_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selBrowseDocumentVersions_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("canCloseDocumentWithDelegate:shouldCloseSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CanCloseDocument (NSObject delegateObject, Selector? shouldCloseSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var delegateObject__handle__ = delegateObject!.GetNonNullHandle (nameof (delegateObject));
			var shouldCloseSelector__handle__ = shouldCloseSelector.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, selCanCloseDocumentWithDelegate_ShouldCloseSelector_ContextInfo_XHandle, delegateObject__handle__, shouldCloseSelector__handle__, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selCanCloseDocumentWithDelegate_ShouldCloseSelector_ContextInfo_XHandle, delegateObject__handle__, shouldCloseSelector__handle__, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (delegateObject);
			GC.KeepAlive (shouldCloseSelector);
		}
		[Export ("canConcurrentlyReadDocumentsOfType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanConcurrentlyReadDocumentsOfType (string typeName)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			var nstypeName = CFString.CreateNative (typeName);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, selCanConcurrentlyReadDocumentsOfType_XHandle, nstypeName);
			CFString.ReleaseNative (nstypeName);
			return ret != 0;
		}
		[Export ("canAsynchronouslyWriteToURL:ofType:forSaveOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanWriteAsynchronously (NSUrl toUrl, string typeName, NSSaveOperationType saveOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var toUrl__handle__ = toUrl!.GetNonNullHandle (nameof (toUrl));
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			var nstypeName = CFString.CreateNative (typeName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, selCanAsynchronouslyWriteToURL_OfType_ForSaveOperation_XHandle, toUrl__handle__, nstypeName, (UIntPtr) (ulong) saveOperation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr (&__objc_super__, selCanAsynchronouslyWriteToURL_OfType_ForSaveOperation_XHandle, toUrl__handle__, nstypeName, (UIntPtr) (ulong) saveOperation);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (toUrl);
			CFString.ReleaseNative (nstypeName);
			return ret != 0;
		}
		[Export ("changeCountTokenForSaveOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ChangeCountToken (NSSaveOperationType saveOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selChangeCountTokenForSaveOperation_XHandle, (UIntPtr) (ulong) saveOperation), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selChangeCountTokenForSaveOperation_XHandle, (UIntPtr) (ulong) saveOperation), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("checkAutosavingSafetyAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool CheckAutosavingSafety (out NSError? outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, selCheckAutosavingSafetyAndReturnError_XHandle, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selCheckAutosavingSafetyAndReturnError_XHandle, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[Export ("close")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Close ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCloseXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCloseXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("continueActivityUsingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ContinueActivity ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action resume)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (resume is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resume));
			using var block_resume = Trampolines.SDAction.CreateBlock (resume);
			BlockLiteral *block_ptr_resume = &block_resume;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selContinueActivityUsingBlock_XHandle, (IntPtr) block_ptr_resume);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selContinueActivityUsingBlock_XHandle, (IntPtr) block_ptr_resume);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("continueAsynchronousWorkOnMainThreadUsingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ContinueAsynchronousWorkOnMainThread ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action work)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (work is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (work));
			using var block_work = Trampolines.SDAction.CreateBlock (work);
			BlockLiteral *block_ptr_work = &block_work;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selContinueAsynchronousWorkOnMainThreadUsingBlock_XHandle, (IntPtr) block_ptr_work);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selContinueAsynchronousWorkOnMainThreadUsingBlock_XHandle, (IntPtr) block_ptr_work);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("duplicateAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDocument Duplicate (out NSError? outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NativeHandle outErrorValue = IntPtr.Zero;
			NSDocument? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (this.Handle, selDuplicateAndReturnError_XHandle, &outErrorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selDuplicateAndReturnError_XHandle, &outErrorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[Export ("duplicateDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DuplicateDocument (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDuplicateDocument_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDuplicateDocument_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("encodeRestorableStateWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeRestorableState (NSCoder coder)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeRestorableStateWithCoder_XHandle, coder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeRestorableStateWithCoder_XHandle, coder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
		}
		[Export ("encodeRestorableStateWithCoder:backgroundQueue:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeRestorableState (NSCoder coder, NSOperationQueue queue)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selEncodeRestorableStateWithCoder_BackgroundQueue_XHandle, coder__handle__, queue__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selEncodeRestorableStateWithCoder_BackgroundQueue_XHandle, coder__handle__, queue__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
			GC.KeepAlive (queue);
		}
		[Export ("fileAttributesToWriteToURL:ofType:forSaveOperation:originalContentsURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDictionary FileAttributesToWrite (NSUrl toUrl, string typeName, NSSaveOperationType saveOperation, NSUrl? absoluteOriginalContentsUrl, out NSError? outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var toUrl__handle__ = toUrl!.GetNonNullHandle (nameof (toUrl));
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			var absoluteOriginalContentsUrl__handle__ = absoluteOriginalContentsUrl.GetHandle ();
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeName = CFString.CreateNative (typeName);
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle_ref_NativeHandle (this.Handle, selFileAttributesToWriteToURL_OfType_ForSaveOperation_OriginalContentsURL_Error_XHandle, toUrl__handle__, nstypeName, (UIntPtr) (ulong) saveOperation, absoluteOriginalContentsUrl__handle__, &outErrorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_NativeHandle_ref_NativeHandle (&__objc_super__, selFileAttributesToWriteToURL_OfType_ForSaveOperation_OriginalContentsURL_Error_XHandle, toUrl__handle__, nstypeName, (UIntPtr) (ulong) saveOperation, absoluteOriginalContentsUrl__handle__, &outErrorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (toUrl);
			GC.KeepAlive (absoluteOriginalContentsUrl);
			CFString.ReleaseNative (nstypeName);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[Export ("fileNameExtensionForType:saveOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FileNameExtensionForSaveOperation (string typeName, NSSaveOperationType saveOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			var nstypeName = CFString.CreateNative (typeName);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selFileNameExtensionForType_SaveOperation_XHandle, nstypeName, (UIntPtr) (ulong) saveOperation), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selFileNameExtensionForType_SaveOperation_XHandle, nstypeName, (UIntPtr) (ulong) saveOperation), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeName);
			return ret!;
		}
		[Export ("allowedClassesForRestorableStateKeyPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static Class[] GetAllowedClasses (string keyPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (keyPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keyPath));
			var nskeyPath = CFString.CreateNative (keyPath);
			Class[]? ret;
			ret = CFArray.ArrayFromHandle<Class>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selAllowedClassesForRestorableStateKeyPath_XHandle, nskeyPath), false)!;
			CFString.ReleaseNative (nskeyPath);
			return ret!;
		}
		[Export ("dataOfType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSData GetAsData (string typeName, out NSError? outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeName = CFString.CreateNative (typeName);
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selDataOfType_Error_XHandle, nstypeName, &outErrorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selDataOfType_Error_XHandle, nstypeName, &outErrorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeName);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[Export ("fileWrapperOfType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSFileWrapper GetAsFileWrapper (string typeName, out NSError? outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeName = CFString.CreateNative (typeName);
			NSFileWrapper? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFileWrapper> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selFileWrapperOfType_Error_XHandle, nstypeName, &outErrorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFileWrapper> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selFileWrapperOfType_Error_XHandle, nstypeName, &outErrorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeName);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[Export ("invalidateRestorableState")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateRestorableState ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selInvalidateRestorableStateXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selInvalidateRestorableStateXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("isNativeType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsNativeType (string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, selIsNativeType_XHandle, nstype);
			CFString.ReleaseNative (nstype);
			return ret != 0;
		}
		[Export ("keepBackupFile")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool KeepBackupFile ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selKeepBackupFileXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selKeepBackupFileXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("lockDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LockDocument (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLockDocument_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLockDocument_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("lockDocumentWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LockDocumentWithCompletionHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDocumentLockDocumentCompletionHandler))]NSDocumentLockDocumentCompletionHandler completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSDocumentLockDocumentCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLockDocumentWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLockDocumentWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("lockWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LockWithCompletionHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDocumentLockCompletionHandler))]NSDocumentLockCompletionHandler completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSDocumentLockCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLockWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLockWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("makeWindowControllers")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MakeWindowControllers ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selMakeWindowControllersXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selMakeWindowControllersXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("moveDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveDocument (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMoveDocument_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMoveDocument_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("moveDocumentToUbiquityContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveDocumentToUbiquityContainer (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMoveDocumentToUbiquityContainer_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMoveDocumentToUbiquityContainer_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("moveDocumentWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void MoveDocumentWithCompletionHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDocumentMoveCompletionHandler))]NSDocumentMoveCompletionHandler completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSDocumentMoveCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMoveDocumentWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMoveDocumentWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("moveToURL:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void MoveToUrl (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDocumentMoveToUrlCompletionHandler))]NSDocumentMoveToUrlCompletionHandler completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSDocumentMoveToUrlCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selMoveToURL_CompletionHandler_XHandle, url__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selMoveToURL_CompletionHandler_XHandle, url__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		/// <param name="editor">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("objectDidBeginEditing:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ObjectDidBeginEditing (INSEditor editor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selObjectDidBeginEditing_XHandle, editor__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectDidBeginEditing_XHandle, editor__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (editor);
		}
		/// <param name="editor">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("objectDidEndEditing:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ObjectDidEndEditing (INSEditor editor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selObjectDidEndEditing_XHandle, editor__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectDidEndEditing_XHandle, editor__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (editor);
		}
		[Export ("performActivityWithSynchronousWaiting:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PerformActivity (bool waitSynchronously, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action activityCompletionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (activityCompletionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (activityCompletionHandler));
			using var block_activityCompletionHandler = Trampolines.SDAction.CreateBlock (activityCompletionHandler);
			BlockLiteral *block_ptr_activityCompletionHandler = &block_activityCompletionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NativeHandle (this.Handle, selPerformActivityWithSynchronousWaiting_UsingBlock_XHandle, waitSynchronously ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_activityCompletionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_NativeHandle (&__objc_super__, selPerformActivityWithSynchronousWaiting_UsingBlock_XHandle, waitSynchronously ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_activityCompletionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("performAsynchronousFileAccessUsingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PerformAsynchronousFileAccess ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action ioCode)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (ioCode is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ioCode));
			using var block_ioCode = Trampolines.SDAction.CreateBlock (ioCode);
			BlockLiteral *block_ptr_ioCode = &block_ioCode;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPerformAsynchronousFileAccessUsingBlock_XHandle, (IntPtr) block_ptr_ioCode);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPerformAsynchronousFileAccessUsingBlock_XHandle, (IntPtr) block_ptr_ioCode);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("performSynchronousFileAccessUsingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PerformSynchronousFileAccess ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action fileAccessCallback)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (fileAccessCallback is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileAccessCallback));
			using var block_fileAccessCallback = Trampolines.SDAction.CreateBlock (fileAccessCallback);
			BlockLiteral *block_ptr_fileAccessCallback = &block_fileAccessCallback;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPerformSynchronousFileAccessUsingBlock_XHandle, (IntPtr) block_ptr_fileAccessCallback);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPerformSynchronousFileAccessUsingBlock_XHandle, (IntPtr) block_ptr_fileAccessCallback);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("prepareSharingServicePicker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Prepare (NSSharingServicePicker sharingServicePicker)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingServicePicker__handle__ = sharingServicePicker!.GetNonNullHandle (nameof (sharingServicePicker));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPrepareSharingServicePicker_XHandle, sharingServicePicker__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPrepareSharingServicePicker_XHandle, sharingServicePicker__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sharingServicePicker);
		}
		[Export ("preparePageLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PreparePageLayout (NSPageLayout pageLayout)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pageLayout__handle__ = pageLayout!.GetNonNullHandle (nameof (pageLayout));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selPreparePageLayout_XHandle, pageLayout__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selPreparePageLayout_XHandle, pageLayout__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pageLayout);
			return ret != 0;
		}
		[Export ("prepareSavePanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PrepareSavePanel (NSSavePanel savePanel)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var savePanel__handle__ = savePanel!.GetNonNullHandle (nameof (savePanel));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selPrepareSavePanel_XHandle, savePanel__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selPrepareSavePanel_XHandle, savePanel__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (savePanel);
			return ret != 0;
		}
		[Export ("presentError:modalForWindow:delegate:didPresentSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentError (NSError error, NSWindow window, NSObject? delegateObject, Selector? didPresentSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			var delegateObject__handle__ = delegateObject.GetHandle ();
			var didPresentSelector__handle__ = didPresentSelector.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_XHandle, error__handle__, window__handle__, delegateObject__handle__, didPresentSelector__handle__, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_XHandle, error__handle__, window__handle__, delegateObject__handle__, didPresentSelector__handle__, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (error);
			GC.KeepAlive (window);
			GC.KeepAlive (delegateObject);
			GC.KeepAlive (didPresentSelector);
		}
		[Export ("presentError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PresentError (NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selPresentError_XHandle, error__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selPresentError_XHandle, error__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (error);
			return ret != 0;
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedItemDidChange")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedItemChanged ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPresentedItemDidChangeXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selPresentedItemDidChangeXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="attributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedItemDidChangeUbiquityAttributes:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedItemChangedUbiquityAttributes (NSSet<NSString> attributes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPresentedItemDidChangeUbiquityAttributes_XHandle, attributes__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPresentedItemDidChangeUbiquityAttributes_XHandle, attributes__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributes);
		}
		/// <param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedItemDidGainVersion:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedItemGainedVersion (NSFileVersion version)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPresentedItemDidGainVersion_XHandle, version__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPresentedItemDidGainVersion_XHandle, version__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (version);
		}
		/// <param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedItemDidLoseVersion:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedItemLostVersion (NSFileVersion version)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPresentedItemDidLoseVersion_XHandle, version__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPresentedItemDidLoseVersion_XHandle, version__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (version);
		}
		/// <param name="newURL">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedItemDidMoveToURL:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedItemMoved (NSUrl newURL)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var newURL__handle__ = newURL!.GetNonNullHandle (nameof (newURL));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPresentedItemDidMoveToURL_XHandle, newURL__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPresentedItemDidMoveToURL_XHandle, newURL__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newURL);
		}
		/// <param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedItemDidResolveConflictVersion:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedItemResolveConflictVersion (NSFileVersion version)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPresentedItemDidResolveConflictVersion_XHandle, version__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPresentedItemDidResolveConflictVersion_XHandle, version__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (version);
		}
		/// <param name="atUrl">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedSubitemDidAppearAtURL:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedSubitemAppeared (NSUrl atUrl)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var atUrl__handle__ = atUrl!.GetNonNullHandle (nameof (atUrl));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPresentedSubitemDidAppearAtURL_XHandle, atUrl__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPresentedSubitemDidAppearAtURL_XHandle, atUrl__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (atUrl);
		}
		/// <param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedSubitemDidChangeAtURL:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedSubitemChanged (NSUrl url)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPresentedSubitemDidChangeAtURL_XHandle, url__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPresentedSubitemDidChangeAtURL_XHandle, url__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		/// <param name="url">To be added.</param><param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedSubitemAtURL:didGainVersion:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedSubitemGainedVersion (NSUrl url, NSFileVersion version)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPresentedSubitemAtURL_DidGainVersion_XHandle, url__handle__, version__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPresentedSubitemAtURL_DidGainVersion_XHandle, url__handle__, version__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (version);
		}
		/// <param name="url">To be added.</param><param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedSubitemAtURL:didLoseVersion:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedSubitemLostVersion (NSUrl url, NSFileVersion version)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPresentedSubitemAtURL_DidLoseVersion_XHandle, url__handle__, version__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPresentedSubitemAtURL_DidLoseVersion_XHandle, url__handle__, version__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (version);
		}
		/// <param name="oldURL">To be added.</param><param name="newURL">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedSubitemAtURL:didMoveToURL:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedSubitemMoved (NSUrl oldURL, NSUrl newURL)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var oldURL__handle__ = oldURL!.GetNonNullHandle (nameof (oldURL));
			var newURL__handle__ = newURL!.GetNonNullHandle (nameof (newURL));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPresentedSubitemAtURL_DidMoveToURL_XHandle, oldURL__handle__, newURL__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPresentedSubitemAtURL_DidMoveToURL_XHandle, oldURL__handle__, newURL__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (oldURL);
			GC.KeepAlive (newURL);
		}
		/// <param name="url">To be added.</param><param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedSubitemAtURL:didResolveConflictVersion:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedSubitemResolvedConflictVersion (NSUrl url, NSFileVersion version)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPresentedSubitemAtURL_DidResolveConflictVersion_XHandle, url__handle__, version__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPresentedSubitemAtURL_DidResolveConflictVersion_XHandle, url__handle__, version__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (version);
		}
		[Export ("preservesVersions")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool PreservesVersions ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selPreservesVersionsXHandle);
			return ret != 0;
		}
		[Export ("printDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrintDocument (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPrintDocument_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPrintDocument_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("printDocumentWithSettings:showPrintPanel:delegate:didPrintSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrintDocument (NSDictionary printSettings, bool showPrintPanel, NSObject? delegateObject, Selector? didPrintSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var printSettings__handle__ = printSettings!.GetNonNullHandle (nameof (printSettings));
			var delegateObject__handle__ = delegateObject.GetHandle ();
			var didPrintSelector__handle__ = didPrintSelector.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool_NativeHandle_NativeHandle_IntPtr (this.Handle, selPrintDocumentWithSettings_ShowPrintPanel_Delegate_DidPrintSelector_ContextInfo_XHandle, printSettings__handle__, showPrintPanel ? (byte) 1 : (byte) 0, delegateObject__handle__, didPrintSelector__handle__, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selPrintDocumentWithSettings_ShowPrintPanel_Delegate_DidPrintSelector_ContextInfo_XHandle, printSettings__handle__, showPrintPanel ? (byte) 1 : (byte) 0, delegateObject__handle__, didPrintSelector__handle__, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (printSettings);
			GC.KeepAlive (delegateObject);
			GC.KeepAlive (didPrintSelector);
		}
		[Export ("printOperationWithSettings:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSPrintOperation PrintOperation (NSDictionary printSettings, out NSError? outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var printSettings__handle__ = printSettings!.GetNonNullHandle (nameof (printSettings));
			NativeHandle outErrorValue = IntPtr.Zero;
			NSPrintOperation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSPrintOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selPrintOperationWithSettings_Error_XHandle, printSettings__handle__, &outErrorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSPrintOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selPrintOperationWithSettings_Error_XHandle, printSettings__handle__, &outErrorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (printSettings);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[Export ("readFromData:ofType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ReadFromData (NSData data, string typeName, out NSError? outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeName = CFString.CreateNative (typeName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selReadFromData_OfType_Error_XHandle, data__handle__, nstypeName, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selReadFromData_OfType_Error_XHandle, data__handle__, nstypeName, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			CFString.ReleaseNative (nstypeName);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[Export ("readFromFileWrapper:ofType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ReadFromFileWrapper (NSFileWrapper fileWrapper, string typeName, out NSError outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var fileWrapper__handle__ = fileWrapper!.GetNonNullHandle (nameof (fileWrapper));
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeName = CFString.CreateNative (typeName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selReadFromFileWrapper_OfType_Error_XHandle, fileWrapper__handle__, nstypeName, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selReadFromFileWrapper_OfType_Error_XHandle, fileWrapper__handle__, nstypeName, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fileWrapper);
			CFString.ReleaseNative (nstypeName);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[Export ("readFromURL:ofType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ReadFromUrl (NSUrl url, string typeName, out NSError? outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeName = CFString.CreateNative (typeName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selReadFromURL_OfType_Error_XHandle, url__handle__, nstypeName, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selReadFromURL_OfType_Error_XHandle, url__handle__, nstypeName, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			CFString.ReleaseNative (nstypeName);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		/// <param name="readerAction">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("relinquishPresentedItemToReader:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RelinquishPresentedItemToReader ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFilePresenterReacquirer))]NSFilePresenterReacquirer readerAction)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (readerAction is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (readerAction));
			using var block_readerAction = Trampolines.SDNSFilePresenterReacquirer.CreateBlock (readerAction);
			BlockLiteral *block_ptr_readerAction = &block_readerAction;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRelinquishPresentedItemToReader_XHandle, (IntPtr) block_ptr_readerAction);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRelinquishPresentedItemToReader_XHandle, (IntPtr) block_ptr_readerAction);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="writerAction">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("relinquishPresentedItemToWriter:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RelinquishPresentedItemToWriter ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFilePresenterReacquirer))]NSFilePresenterReacquirer writerAction)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (writerAction is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (writerAction));
			using var block_writerAction = Trampolines.SDNSFilePresenterReacquirer.CreateBlock (writerAction);
			BlockLiteral *block_ptr_writerAction = &block_writerAction;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRelinquishPresentedItemToWriter_XHandle, (IntPtr) block_ptr_writerAction);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRelinquishPresentedItemToWriter_XHandle, (IntPtr) block_ptr_writerAction);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeWindowController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveWindowController (NSWindowController windowController)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var windowController__handle__ = windowController!.GetNonNullHandle (nameof (windowController));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveWindowController_XHandle, windowController__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveWindowController_XHandle, windowController__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (windowController);
		}
		[Export ("renameDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RenameDocument (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRenameDocument_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRenameDocument_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("restorableStateKeyPaths")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] RestorableStateKeyPaths ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selRestorableStateKeyPathsXHandle), false)!;
			return ret;
		}
		[Export ("restoreDocumentWindowWithIdentifier:state:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RestoreDocumentWindow (string identifier, NSCoder state, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWindowCompletionHandler))]NSWindowCompletionHandler completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var state__handle__ = state!.GetNonNullHandle (nameof (state));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsidentifier = CFString.CreateNative (identifier);
			using var block_completionHandler = Trampolines.SDNSWindowCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selRestoreDocumentWindowWithIdentifier_State_CompletionHandler_XHandle, nsidentifier, state__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selRestoreDocumentWindowWithIdentifier_State_CompletionHandler_XHandle, nsidentifier, state__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (state);
			CFString.ReleaseNative (nsidentifier);
		}
		[Export ("restoreStateWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RestoreState (NSCoder coder)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRestoreStateWithCoder_XHandle, coder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRestoreStateWithCoder_XHandle, coder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
		}
		[Export ("restoreUserActivityState:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RestoreUserActivityState (NSUserActivity userActivity)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRestoreUserActivityState_XHandle, userActivity__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRestoreUserActivityState_XHandle, userActivity__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (userActivity);
		}
		[Export ("revertDocumentToSaved:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RevertDocumentToSaved (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRevertDocumentToSaved_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRevertDocumentToSaved_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("revertToContentsOfURL:ofType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool RevertToContentsOfUrl (NSUrl url, string typeName, out NSError? outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeName = CFString.CreateNative (typeName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selRevertToContentsOfURL_OfType_Error_XHandle, url__handle__, nstypeName, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selRevertToContentsOfURL_OfType_Error_XHandle, url__handle__, nstypeName, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			CFString.ReleaseNative (nstypeName);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[Export ("runModalPageLayoutWithPrintInfo:delegate:didRunSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RunModalPageLayout (NSPrintInfo printInfo, NSObject? delegateObject, Selector? didRunSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var printInfo__handle__ = printInfo!.GetNonNullHandle (nameof (printInfo));
			var delegateObject__handle__ = delegateObject.GetHandle ();
			var didRunSelector__handle__ = didRunSelector.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selRunModalPageLayoutWithPrintInfo_Delegate_DidRunSelector_ContextInfo_XHandle, printInfo__handle__, delegateObject__handle__, didRunSelector__handle__, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selRunModalPageLayoutWithPrintInfo_Delegate_DidRunSelector_ContextInfo_XHandle, printInfo__handle__, delegateObject__handle__, didRunSelector__handle__, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (printInfo);
			GC.KeepAlive (delegateObject);
			GC.KeepAlive (didRunSelector);
		}
		[Export ("runModalPrintOperation:delegate:didRunSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RunModalPrintOperation (NSPrintOperation printOperation, NSObject? delegateObject, Selector? didRunSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var printOperation__handle__ = printOperation!.GetNonNullHandle (nameof (printOperation));
			var delegateObject__handle__ = delegateObject.GetHandle ();
			var didRunSelector__handle__ = didRunSelector.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selRunModalPrintOperation_Delegate_DidRunSelector_ContextInfo_XHandle, printOperation__handle__, delegateObject__handle__, didRunSelector__handle__, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selRunModalPrintOperation_Delegate_DidRunSelector_ContextInfo_XHandle, printOperation__handle__, delegateObject__handle__, didRunSelector__handle__, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (printOperation);
			GC.KeepAlive (delegateObject);
			GC.KeepAlive (didRunSelector);
		}
		[Export ("runModalSavePanelForSaveOperation:delegate:didSaveSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RunModalSavePanelForSaveOperation (NSSaveOperationType saveOperation, NSObject? delegateObject, Selector? didSaveSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var delegateObject__handle__ = delegateObject.GetHandle ();
			var didSaveSelector__handle__ = didSaveSelector.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle_NativeHandle_IntPtr (this.Handle, selRunModalSavePanelForSaveOperation_Delegate_DidSaveSelector_ContextInfo_XHandle, (UIntPtr) (ulong) saveOperation, delegateObject__handle__, didSaveSelector__handle__, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selRunModalSavePanelForSaveOperation_Delegate_DidSaveSelector_ContextInfo_XHandle, (UIntPtr) (ulong) saveOperation, delegateObject__handle__, didSaveSelector__handle__, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (delegateObject);
			GC.KeepAlive (didSaveSelector);
		}
		[Export ("runPageLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RunPageLayout (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRunPageLayout_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRunPageLayout_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("saveDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SaveDocument (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSaveDocument_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSaveDocument_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("saveDocumentWithDelegate:didSaveSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SaveDocument (NSObject? delegateObject, Selector? didSaveSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var delegateObject__handle__ = delegateObject.GetHandle ();
			var didSaveSelector__handle__ = didSaveSelector.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, selSaveDocumentWithDelegate_DidSaveSelector_ContextInfo_XHandle, delegateObject__handle__, didSaveSelector__handle__, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selSaveDocumentWithDelegate_DidSaveSelector_ContextInfo_XHandle, delegateObject__handle__, didSaveSelector__handle__, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (delegateObject);
			GC.KeepAlive (didSaveSelector);
		}
		[Export ("saveDocumentAs:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SaveDocumentAs (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSaveDocumentAs_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSaveDocumentAs_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("saveDocumentToPDF:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SaveDocumentAsPdf (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSaveDocumentToPDF_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSaveDocumentToPDF_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("saveDocumentTo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SaveDocumentTo (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSaveDocumentTo_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSaveDocumentTo_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("savePresentedItemChangesWithCompletionHandler:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SavePresentedItemChanges ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSavePresentedItemChangesWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSavePresentedItemChangesWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("saveToURL:ofType:forSaveOperation:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SaveTo (NSUrl url, string typeName, NSSaveOperationType saveOperation, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDocumentCompletionHandler))]NSDocumentCompletionHandler completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nstypeName = CFString.CreateNative (typeName);
			using var block_completionHandler = Trampolines.SDNSDocumentCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle (this.Handle, selSaveToURL_OfType_ForSaveOperation_CompletionHandler_XHandle, url__handle__, nstypeName, (UIntPtr) (ulong) saveOperation, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selSaveToURL_OfType_ForSaveOperation_CompletionHandler_XHandle, url__handle__, nstypeName, (UIntPtr) (ulong) saveOperation, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			CFString.ReleaseNative (nstypeName);
		}
		[Export ("saveToURL:ofType:forSaveOperation:delegate:didSaveSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SaveToUrl (NSUrl url, string typeName, NSSaveOperationType saveOperation, NSObject? delegateObject, Selector? didSaveSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			var delegateObject__handle__ = delegateObject.GetHandle ();
			var didSaveSelector__handle__ = didSaveSelector.GetHandle ();
			var nstypeName = CFString.CreateNative (typeName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle_NativeHandle_IntPtr (this.Handle, selSaveToURL_OfType_ForSaveOperation_Delegate_DidSaveSelector_ContextInfo_XHandle, url__handle__, nstypeName, (UIntPtr) (ulong) saveOperation, delegateObject__handle__, didSaveSelector__handle__, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selSaveToURL_OfType_ForSaveOperation_Delegate_DidSaveSelector_ContextInfo_XHandle, url__handle__, nstypeName, (UIntPtr) (ulong) saveOperation, delegateObject__handle__, didSaveSelector__handle__, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (delegateObject);
			GC.KeepAlive (didSaveSelector);
			CFString.ReleaseNative (nstypeName);
		}
		[Export ("saveToURL:ofType:forSaveOperation:error:")]
		[ObsoletedOSPlatform ("macos10.6", "Use a 'SaveToUrl' overload accepting a completion handler instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SaveToUrl (NSUrl url, string typeName, NSSaveOperationType saveOperation, out NSError? outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeName = CFString.CreateNative (typeName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_ref_NativeHandle (this.Handle, selSaveToURL_OfType_ForSaveOperation_Error_XHandle, url__handle__, nstypeName, (UIntPtr) (ulong) saveOperation, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_ref_NativeHandle (&__objc_super__, selSaveToURL_OfType_ForSaveOperation_Error_XHandle, url__handle__, nstypeName, (UIntPtr) (ulong) saveOperation, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			CFString.ReleaseNative (nstypeName);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[Export ("scheduleAutosaving")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScheduleAutosaving ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selScheduleAutosavingXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selScheduleAutosavingXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetWindow (NSWindow? window)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var window__handle__ = window.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetWindow_XHandle, window__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetWindow_XHandle, window__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (window);
		}
		[Export ("shareDocumentWithSharingService:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ShareDocument (NSSharingService sharingService, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool>? completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			using var block_completionHandler = Trampolines.SDActionArity1V2.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selShareDocumentWithSharingService_CompletionHandler_XHandle, sharingService__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selShareDocumentWithSharingService_CompletionHandler_XHandle, sharingService__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sharingService);
		}
		/// <param name="sharingService">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<bool> ShareDocumentAsync (NSSharingService sharingService)
		{
			var tcs = new TaskCompletionSource<bool> ();
			ShareDocument(sharingService, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("shouldChangePrintInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangePrintInfo (NSPrintInfo newPrintInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var newPrintInfo__handle__ = newPrintInfo!.GetNonNullHandle (nameof (newPrintInfo));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selShouldChangePrintInfo_XHandle, newPrintInfo__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selShouldChangePrintInfo_XHandle, newPrintInfo__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newPrintInfo);
			return ret != 0;
		}
		[Export ("shouldCloseWindowController:delegate:shouldCloseSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShouldCloseWindowController (NSWindowController windowController, NSObject? delegateObject, Selector? shouldCloseSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var windowController__handle__ = windowController!.GetNonNullHandle (nameof (windowController));
			var delegateObject__handle__ = delegateObject.GetHandle ();
			var shouldCloseSelector__handle__ = shouldCloseSelector.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selShouldCloseWindowController_Delegate_ShouldCloseSelector_ContextInfo_XHandle, windowController__handle__, delegateObject__handle__, shouldCloseSelector__handle__, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selShouldCloseWindowController_Delegate_ShouldCloseSelector_ContextInfo_XHandle, windowController__handle__, delegateObject__handle__, shouldCloseSelector__handle__, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (windowController);
			GC.KeepAlive (delegateObject);
			GC.KeepAlive (shouldCloseSelector);
		}
		[Export ("showWindows")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowWindows ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selShowWindowsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selShowWindowsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("stopBrowsingVersionsWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void StopBrowsingVersions ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStopBrowsingVersionsWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selStopBrowsingVersionsWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task StopBrowsingVersionsAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			StopBrowsingVersions(() => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("unblockUserInteraction")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnblockUserInteraction ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUnblockUserInteractionXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUnblockUserInteractionXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("unlockDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnlockDocument (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUnlockDocument_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUnlockDocument_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("unlockDocumentWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void UnlockDocumentWithCompletionHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDocumentUnlockDocumentCompletionHandler))]NSDocumentUnlockDocumentCompletionHandler completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSDocumentUnlockDocumentCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUnlockDocumentWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUnlockDocumentWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("unlockWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void UnlockWithCompletionHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDocumentUnlockCompletionHandler))]NSDocumentUnlockCompletionHandler completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSDocumentUnlockCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUnlockWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUnlockWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updateChangeCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateChangeCount (NSDocumentChangeType change)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selUpdateChangeCount_XHandle, (UIntPtr) (ulong) change);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selUpdateChangeCount_XHandle, (UIntPtr) (ulong) change);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updateChangeCountWithToken:forSaveOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateChangeCount (NSObject changeCountToken, NSSaveOperationType saveOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var changeCountToken__handle__ = changeCountToken!.GetNonNullHandle (nameof (changeCountToken));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selUpdateChangeCountWithToken_ForSaveOperation_XHandle, changeCountToken__handle__, (UIntPtr) (ulong) saveOperation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selUpdateChangeCountWithToken_ForSaveOperation_XHandle, changeCountToken__handle__, (UIntPtr) (ulong) saveOperation);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (changeCountToken);
		}
		[Export ("updateUserActivityState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateUserActivityState (NSUserActivity userActivity)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUpdateUserActivityState_XHandle, userActivity__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUpdateUserActivityState_XHandle, userActivity__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (userActivity);
		}
		/// <param name="menuItem">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("validateMenuItem:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ValidateMenuItem (NSMenuItem menuItem)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menuItem__handle__ = menuItem!.GetNonNullHandle (nameof (menuItem));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selValidateMenuItem_XHandle, menuItem__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selValidateMenuItem_XHandle, menuItem__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (menuItem);
			return ret != 0;
		}
		[Export ("validateUserInterfaceItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ValidateUserInterfaceItem (INSValidatedUserInterfaceItem anItem)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var anItem__handle__ = anItem!.GetNonNullHandle (nameof (anItem));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selValidateUserInterfaceItem_XHandle, anItem__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selValidateUserInterfaceItem_XHandle, anItem__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anItem);
			return ret != 0;
		}
		[Export ("willNotPresentError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillNotPresentError (NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selWillNotPresentError_XHandle, error__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selWillNotPresentError_XHandle, error__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (error);
		}
		[Export ("willPresentError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSError WillPresentError (NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			NSError? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selWillPresentError_XHandle, error__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selWillPresentError_XHandle, error__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (error);
			return ret!;
		}
		[Export ("windowControllerDidLoadNib:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WindowControllerDidLoadNib (NSWindowController windowController)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var windowController__handle__ = windowController!.GetNonNullHandle (nameof (windowController));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selWindowControllerDidLoadNib_XHandle, windowController__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selWindowControllerDidLoadNib_XHandle, windowController__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (windowController);
		}
		[Export ("windowControllerWillLoadNib:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WindowControllerWillLoadNib (NSWindowController windowController)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var windowController__handle__ = windowController!.GetNonNullHandle (nameof (windowController));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selWindowControllerWillLoadNib_XHandle, windowController__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selWindowControllerWillLoadNib_XHandle, windowController__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (windowController);
		}
		[Export ("writableTypes")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] WritableTypes ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selWritableTypesXHandle), false)!;
			return ret;
		}
		[Export ("writableTypesForSaveOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] WritableTypesForSaveOperation (NSSaveOperationType saveOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string[] ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selWritableTypesForSaveOperation_XHandle, (UIntPtr) (ulong) saveOperation), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selWritableTypesForSaveOperation_XHandle, (UIntPtr) (ulong) saveOperation), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("writeSafelyToURL:ofType:forSaveOperation:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool WriteSafelyToUrl (NSUrl url, string typeName, NSSaveOperationType saveOperation, out NSError? outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeName = CFString.CreateNative (typeName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_ref_NativeHandle (this.Handle, selWriteSafelyToURL_OfType_ForSaveOperation_Error_XHandle, url__handle__, nstypeName, (UIntPtr) (ulong) saveOperation, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_ref_NativeHandle (&__objc_super__, selWriteSafelyToURL_OfType_ForSaveOperation_Error_XHandle, url__handle__, nstypeName, (UIntPtr) (ulong) saveOperation, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			CFString.ReleaseNative (nstypeName);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[Export ("writeToURL:ofType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool WriteToUrl (NSUrl url, string typeName, out NSError? outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeName = CFString.CreateNative (typeName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selWriteToURL_OfType_Error_XHandle, url__handle__, nstypeName, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selWriteToURL_OfType_Error_XHandle, url__handle__, nstypeName, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			CFString.ReleaseNative (nstypeName);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[Export ("writeToURL:ofType:forSaveOperation:originalContentsURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool WriteToUrl (NSUrl url, string typeName, NSSaveOperationType saveOperation, NSUrl? absoluteOriginalContentsUrl, out NSError? outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			var absoluteOriginalContentsUrl__handle__ = absoluteOriginalContentsUrl.GetHandle ();
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeName = CFString.CreateNative (typeName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle_ref_NativeHandle (this.Handle, selWriteToURL_OfType_ForSaveOperation_OriginalContentsURL_Error_XHandle, url__handle__, nstypeName, (UIntPtr) (ulong) saveOperation, absoluteOriginalContentsUrl__handle__, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_NativeHandle_ref_NativeHandle (&__objc_super__, selWriteToURL_OfType_ForSaveOperation_OriginalContentsURL_Error_XHandle, url__handle__, nstypeName, (UIntPtr) (ulong) saveOperation, absoluteOriginalContentsUrl__handle__, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (absoluteOriginalContentsUrl);
			CFString.ReleaseNative (nstypeName);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[Export ("duplicateDocumentWithDelegate:didDuplicateSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _DuplicateDocument (NSObject? cbackobject, Selector? didDuplicateSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var cbackobject__handle__ = cbackobject.GetHandle ();
			var didDuplicateSelector__handle__ = didDuplicateSelector.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, selDuplicateDocumentWithDelegate_DidDuplicateSelector_ContextInfo_XHandle, cbackobject__handle__, didDuplicateSelector__handle__, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selDuplicateDocumentWithDelegate_DidDuplicateSelector_ContextInfo_XHandle, cbackobject__handle__, didDuplicateSelector__handle__, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cbackobject);
			GC.KeepAlive (didDuplicateSelector);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsDocumentSharing {
			[Export ("allowsDocumentSharing")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsDocumentSharingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsDocumentSharingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AutoSavesDrafts {
			[Export ("autosavesDrafts")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selAutosavesDraftsXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl AutosavedContentsFileUrl {
			[Export ("autosavedContentsFileURL", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAutosavedContentsFileURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAutosavedContentsFileURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAutosavedContentsFileURL:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAutosavedContentsFileURL_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAutosavedContentsFileURL_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AutosavingFileType {
			[Export ("autosavingFileType")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAutosavingFileTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAutosavingFileTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutosavingIsImplicitlyCancellable {
			[Export ("autosavingIsImplicitlyCancellable")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAutosavingIsImplicitlyCancellableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAutosavingIsImplicitlyCancellableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl BackupFileUrl {
			[Export ("backupFileURL")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBackupFileURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBackupFileURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DefaultDraftName {
			[Export ("defaultDraftName")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDefaultDraftNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDefaultDraftNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? DisplayName {
			[Export ("displayName")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDisplayNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDisplayNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDisplayName:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDisplayName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDisplayName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate FileModificationDate {
			[Export ("fileModificationDate", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFileModificationDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFileModificationDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFileModificationDate:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFileModificationDate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFileModificationDate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool FileNameExtensionWasHiddenInLastRunSavePanel {
			[Export ("fileNameExtensionWasHiddenInLastRunSavePanel")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selFileNameExtensionWasHiddenInLastRunSavePanelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selFileNameExtensionWasHiddenInLastRunSavePanelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FileType {
			[Export ("fileType")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFileTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFileTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFileType:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFileType_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFileType_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FileTypeFromLastRunSavePanel {
			[Export ("fileTypeFromLastRunSavePanel")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFileTypeFromLastRunSavePanelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFileTypeFromLastRunSavePanelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? FileUrl {
			[Export ("fileURL", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFileURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFileURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFileURL:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFileURL_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFileURL_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasUnautosavedChanges {
			[Export ("hasUnautosavedChanges")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasUnautosavedChangesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasUnautosavedChangesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasUndoManager {
			[Export ("hasUndoManager")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasUndoManagerXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasUndoManagerXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHasUndoManager:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHasUndoManager_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetHasUndoManager_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsBrowsingVersions {
			[Export ("isBrowsingVersions")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsBrowsingVersionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsBrowsingVersionsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsDocumentEdited {
			[Export ("isDocumentEdited")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDocumentEditedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsDocumentEditedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsDraft {
			[Export ("isDraft")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDraftXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsDraftXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDraft:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDraft_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDraft_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEntireFileLoaded {
			[Export ("isEntireFileLoaded")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEntireFileLoadedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsEntireFileLoadedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsInViewingMode {
			[Export ("isInViewingMode")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsInViewingModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsInViewingModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsLocked {
			[Export ("isLocked")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLockedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsLockedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual NSPrintOperation PDFPrintOperation {
			[Export ("PDFPrintOperation", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSPrintOperation? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSPrintOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPDFPrintOperationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSPrintOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPDFPrintOperationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the set of ubiquity attributes that will generate notifications if they are modified.</summary><value>To be added.</value><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		public virtual NSSet<NSString> PresentedItemObservedUbiquityAttributes {
			[Export ("observedPresentedItemUbiquityAttributes", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("ios")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSSet<NSString>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selObservedPresentedItemUbiquityAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selObservedPresentedItemUbiquityAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the <see cref="T:Foundation.NSOperationQueue" /> on which presenter-related methods are executed.</summary><value>The <see cref="T:Foundation.NSOperationQueue" /> on which methods are executed.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual NSOperationQueue PresentedItemOperationQueue {
			[Export ("presentedItemOperationQueue", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSOperationQueue? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSOperationQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPresentedItemOperationQueueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSOperationQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPresentedItemOperationQueueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets URL of presented item.</summary><value></value><remarks><para></para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual NSUrl? PresentedItemUrl {
			[Export ("presentedItemURL", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPresentedItemURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPresentedItemURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.2")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual INSPreviewRepresentableActivityItem[]? PreviewRepresentableActivityItems {
			[Export ("previewRepresentableActivityItems", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				INSPreviewRepresentableActivityItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<INSPreviewRepresentableActivityItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreviewRepresentableActivityItemsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<INSPreviewRepresentableActivityItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreviewRepresentableActivityItemsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPreviewRepresentableActivityItems:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPreviewRepresentableActivityItems_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPreviewRepresentableActivityItems_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSUrl? PrimaryPresentedItemUrl {
			[Export ("primaryPresentedItemURL")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPrimaryPresentedItemURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPrimaryPresentedItemURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPrintInfo PrintInfo {
			[Export ("printInfo", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSPrintInfo? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSPrintInfo> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPrintInfoXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSPrintInfo> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPrintInfoXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPrintInfo:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPrintInfo_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPrintInfo_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] ReadableTypes {
			[Export ("readableTypes", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selReadableTypesXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual bool SavePanelShowsFileFormatsControl {
			[Export ("savePanelShowsFileFormatsControl")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSavePanelShowsFileFormatsControlXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSavePanelShowsFileFormatsControlXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos15.0", "Use 'SavePanelShowsFileFormatsControl' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool ShouldRunSavePanelWithAccessoryView {
			[Export ("shouldRunSavePanelWithAccessoryView")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldRunSavePanelWithAccessoryViewXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShouldRunSavePanelWithAccessoryViewXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUndoManager UndoManager {
			[Export ("undoManager", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSUndoManager? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUndoManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUndoManagerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUndoManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUndoManagerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setUndoManager:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetUndoManager_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetUndoManager_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual NSUserActivity UserActivity {
			[Export ("userActivity", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSUserActivity? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUserActivity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUserActivityXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUserActivity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUserActivityXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setUserActivity:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetUserActivity_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetUserActivity_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool UsesUbiquitousStorage {
			[Export ("usesUbiquitousStorage")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selUsesUbiquitousStorageXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSWindowController[] WindowControllers {
			[Export ("windowControllers")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSWindowController[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSWindowController>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWindowControllersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSWindowController>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWindowControllersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSWindow WindowForSheet {
			[Export ("windowForSheet")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSWindow? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWindowForSheetXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWindowForSheetXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string WindowNibName {
			[Export ("windowNibName")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWindowNibNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWindowNibNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class NSDocument */
}
