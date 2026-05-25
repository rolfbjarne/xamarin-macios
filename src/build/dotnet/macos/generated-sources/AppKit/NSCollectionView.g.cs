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
	[Register("NSCollectionView", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSCollectionView : NSView, INSDraggingDestination, INSDraggingSource {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsEmptySelectionX = "allowsEmptySelection";
		static readonly NativeHandle selAllowsEmptySelectionXHandle = Selector.GetHandle ("allowsEmptySelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsMultipleSelectionX = "allowsMultipleSelection";
		static readonly NativeHandle selAllowsMultipleSelectionXHandle = Selector.GetHandle ("allowsMultipleSelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackgroundColorsX = "backgroundColors";
		static readonly NativeHandle selBackgroundColorsXHandle = Selector.GetHandle ("backgroundColors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackgroundViewX = "backgroundView";
		static readonly NativeHandle selBackgroundViewXHandle = Selector.GetHandle ("backgroundView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackgroundViewScrollsWithContentX = "backgroundViewScrollsWithContent";
		static readonly NativeHandle selBackgroundViewScrollsWithContentXHandle = Selector.GetHandle ("backgroundViewScrollsWithContent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCollectionViewLayoutX = "collectionViewLayout";
		static readonly NativeHandle selCollectionViewLayoutXHandle = Selector.GetHandle ("collectionViewLayout");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConcludeDragOperation_X = "concludeDragOperation:";
		static readonly NativeHandle selConcludeDragOperation_XHandle = Selector.GetHandle ("concludeDragOperation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentX = "content";
		static readonly NativeHandle selContentXHandle = Selector.GetHandle ("content");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataSourceX = "dataSource";
		static readonly NativeHandle selDataSourceXHandle = Selector.GetHandle ("dataSource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteItemsAtIndexPaths_X = "deleteItemsAtIndexPaths:";
		static readonly NativeHandle selDeleteItemsAtIndexPaths_XHandle = Selector.GetHandle ("deleteItemsAtIndexPaths:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteSections_X = "deleteSections:";
		static readonly NativeHandle selDeleteSections_XHandle = Selector.GetHandle ("deleteSections:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeselectAll_X = "deselectAll:";
		static readonly NativeHandle selDeselectAll_XHandle = Selector.GetHandle ("deselectAll:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeselectItemsAtIndexPaths_X = "deselectItemsAtIndexPaths:";
		static readonly NativeHandle selDeselectItemsAtIndexPaths_XHandle = Selector.GetHandle ("deselectItemsAtIndexPaths:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggedImage_BeganAt_X = "draggedImage:beganAt:";
		static readonly NativeHandle selDraggedImage_BeganAt_XHandle = Selector.GetHandle ("draggedImage:beganAt:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggedImage_EndedAt_Deposited_X = "draggedImage:endedAt:deposited:";
		static readonly NativeHandle selDraggedImage_EndedAt_Deposited_XHandle = Selector.GetHandle ("draggedImage:endedAt:deposited:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggedImage_EndedAt_Operation_X = "draggedImage:endedAt:operation:";
		static readonly NativeHandle selDraggedImage_EndedAt_Operation_XHandle = Selector.GetHandle ("draggedImage:endedAt:operation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggedImage_MovedTo_X = "draggedImage:movedTo:";
		static readonly NativeHandle selDraggedImage_MovedTo_XHandle = Selector.GetHandle ("draggedImage:movedTo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggingEnded_X = "draggingEnded:";
		static readonly NativeHandle selDraggingEnded_XHandle = Selector.GetHandle ("draggingEnded:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggingEntered_X = "draggingEntered:";
		static readonly NativeHandle selDraggingEntered_XHandle = Selector.GetHandle ("draggingEntered:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggingExited_X = "draggingExited:";
		static readonly NativeHandle selDraggingExited_XHandle = Selector.GetHandle ("draggingExited:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggingImageForItemsAtIndexPaths_WithEvent_Offset_X = "draggingImageForItemsAtIndexPaths:withEvent:offset:";
		static readonly NativeHandle selDraggingImageForItemsAtIndexPaths_WithEvent_Offset_XHandle = Selector.GetHandle ("draggingImageForItemsAtIndexPaths:withEvent:offset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggingSourceOperationMaskForLocal_X = "draggingSourceOperationMaskForLocal:";
		static readonly NativeHandle selDraggingSourceOperationMaskForLocal_XHandle = Selector.GetHandle ("draggingSourceOperationMaskForLocal:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggingUpdated_X = "draggingUpdated:";
		static readonly NativeHandle selDraggingUpdated_XHandle = Selector.GetHandle ("draggingUpdated:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameForItemAtIndex_X = "frameForItemAtIndex:";
		static readonly NativeHandle selFrameForItemAtIndex_XHandle = Selector.GetHandle ("frameForItemAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameForItemAtIndex_WithNumberOfItems_X = "frameForItemAtIndex:withNumberOfItems:";
		static readonly NativeHandle selFrameForItemAtIndex_WithNumberOfItems_XHandle = Selector.GetHandle ("frameForItemAtIndex:withNumberOfItems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIgnoreModifierKeysWhileDraggingX = "ignoreModifierKeysWhileDragging";
		static readonly NativeHandle selIgnoreModifierKeysWhileDraggingXHandle = Selector.GetHandle ("ignoreModifierKeysWhileDragging");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexPathForItem_X = "indexPathForItem:";
		static readonly NativeHandle selIndexPathForItem_XHandle = Selector.GetHandle ("indexPathForItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexPathForItemAtPoint_X = "indexPathForItemAtPoint:";
		static readonly NativeHandle selIndexPathForItemAtPoint_XHandle = Selector.GetHandle ("indexPathForItemAtPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexPathsForVisibleItemsX = "indexPathsForVisibleItems";
		static readonly NativeHandle selIndexPathsForVisibleItemsXHandle = Selector.GetHandle ("indexPathsForVisibleItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexPathsForVisibleSupplementaryElementsOfKind_X = "indexPathsForVisibleSupplementaryElementsOfKind:";
		static readonly NativeHandle selIndexPathsForVisibleSupplementaryElementsOfKind_XHandle = Selector.GetHandle ("indexPathsForVisibleSupplementaryElementsOfKind:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_X = "initWithFrame:";
		static readonly NativeHandle selInitWithFrame_XHandle = Selector.GetHandle ("initWithFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertItemsAtIndexPaths_X = "insertItemsAtIndexPaths:";
		static readonly NativeHandle selInsertItemsAtIndexPaths_XHandle = Selector.GetHandle ("insertItemsAtIndexPaths:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertSections_X = "insertSections:";
		static readonly NativeHandle selInsertSections_XHandle = Selector.GetHandle ("insertSections:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFirstResponderX = "isFirstResponder";
		static readonly NativeHandle selIsFirstResponderXHandle = Selector.GetHandle ("isFirstResponder");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSelectableX = "isSelectable";
		static readonly NativeHandle selIsSelectableXHandle = Selector.GetHandle ("isSelectable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemAtIndex_X = "itemAtIndex:";
		static readonly NativeHandle selItemAtIndex_XHandle = Selector.GetHandle ("itemAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemAtIndexPath_X = "itemAtIndexPath:";
		static readonly NativeHandle selItemAtIndexPath_XHandle = Selector.GetHandle ("itemAtIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemPrototypeX = "itemPrototype";
		static readonly NativeHandle selItemPrototypeXHandle = Selector.GetHandle ("itemPrototype");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutAttributesForItemAtIndexPath_X = "layoutAttributesForItemAtIndexPath:";
		static readonly NativeHandle selLayoutAttributesForItemAtIndexPath_XHandle = Selector.GetHandle ("layoutAttributesForItemAtIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutAttributesForSupplementaryElementOfKind_AtIndexPath_X = "layoutAttributesForSupplementaryElementOfKind:atIndexPath:";
		static readonly NativeHandle selLayoutAttributesForSupplementaryElementOfKind_AtIndexPath_XHandle = Selector.GetHandle ("layoutAttributesForSupplementaryElementOfKind:atIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakeItemWithIdentifier_ForIndexPath_X = "makeItemWithIdentifier:forIndexPath:";
		static readonly NativeHandle selMakeItemWithIdentifier_ForIndexPath_XHandle = Selector.GetHandle ("makeItemWithIdentifier:forIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakeSupplementaryViewOfKind_WithIdentifier_ForIndexPath_X = "makeSupplementaryViewOfKind:withIdentifier:forIndexPath:";
		static readonly NativeHandle selMakeSupplementaryViewOfKind_WithIdentifier_ForIndexPath_XHandle = Selector.GetHandle ("makeSupplementaryViewOfKind:withIdentifier:forIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxItemSizeX = "maxItemSize";
		static readonly NativeHandle selMaxItemSizeXHandle = Selector.GetHandle ("maxItemSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxNumberOfColumnsX = "maxNumberOfColumns";
		static readonly NativeHandle selMaxNumberOfColumnsXHandle = Selector.GetHandle ("maxNumberOfColumns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxNumberOfRowsX = "maxNumberOfRows";
		static readonly NativeHandle selMaxNumberOfRowsXHandle = Selector.GetHandle ("maxNumberOfRows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinItemSizeX = "minItemSize";
		static readonly NativeHandle selMinItemSizeXHandle = Selector.GetHandle ("minItemSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveItemAtIndexPath_ToIndexPath_X = "moveItemAtIndexPath:toIndexPath:";
		static readonly NativeHandle selMoveItemAtIndexPath_ToIndexPath_XHandle = Selector.GetHandle ("moveItemAtIndexPath:toIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveSection_ToSection_X = "moveSection:toSection:";
		static readonly NativeHandle selMoveSection_ToSection_XHandle = Selector.GetHandle ("moveSection:toSection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNamesOfPromisedFilesDroppedAtDestination_X = "namesOfPromisedFilesDroppedAtDestination:";
		static readonly NativeHandle selNamesOfPromisedFilesDroppedAtDestination_XHandle = Selector.GetHandle ("namesOfPromisedFilesDroppedAtDestination:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewItemForRepresentedObject_X = "newItemForRepresentedObject:";
		static readonly NativeHandle selNewItemForRepresentedObject_XHandle = Selector.GetHandle ("newItemForRepresentedObject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfItemsInSection_X = "numberOfItemsInSection:";
		static readonly NativeHandle selNumberOfItemsInSection_XHandle = Selector.GetHandle ("numberOfItemsInSection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfSectionsX = "numberOfSections";
		static readonly NativeHandle selNumberOfSectionsXHandle = Selector.GetHandle ("numberOfSections");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformBatchUpdates_CompletionHandler_X = "performBatchUpdates:completionHandler:";
		static readonly NativeHandle selPerformBatchUpdates_CompletionHandler_XHandle = Selector.GetHandle ("performBatchUpdates:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformDragOperation_X = "performDragOperation:";
		static readonly NativeHandle selPerformDragOperation_XHandle = Selector.GetHandle ("performDragOperation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrefetchDataSourceX = "prefetchDataSource";
		static readonly NativeHandle selPrefetchDataSourceXHandle = Selector.GetHandle ("prefetchDataSource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareForDragOperation_X = "prepareForDragOperation:";
		static readonly NativeHandle selPrepareForDragOperation_XHandle = Selector.GetHandle ("prepareForDragOperation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterClass_ForItemWithIdentifier_X = "registerClass:forItemWithIdentifier:";
		static readonly NativeHandle selRegisterClass_ForItemWithIdentifier_XHandle = Selector.GetHandle ("registerClass:forItemWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterClass_ForSupplementaryViewOfKind_WithIdentifier_X = "registerClass:forSupplementaryViewOfKind:withIdentifier:";
		static readonly NativeHandle selRegisterClass_ForSupplementaryViewOfKind_WithIdentifier_XHandle = Selector.GetHandle ("registerClass:forSupplementaryViewOfKind:withIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterNib_ForItemWithIdentifier_X = "registerNib:forItemWithIdentifier:";
		static readonly NativeHandle selRegisterNib_ForItemWithIdentifier_XHandle = Selector.GetHandle ("registerNib:forItemWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterNib_ForSupplementaryViewOfKind_WithIdentifier_X = "registerNib:forSupplementaryViewOfKind:withIdentifier:";
		static readonly NativeHandle selRegisterNib_ForSupplementaryViewOfKind_WithIdentifier_XHandle = Selector.GetHandle ("registerNib:forSupplementaryViewOfKind:withIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadDataX = "reloadData";
		static readonly NativeHandle selReloadDataXHandle = Selector.GetHandle ("reloadData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadItemsAtIndexPaths_X = "reloadItemsAtIndexPaths:";
		static readonly NativeHandle selReloadItemsAtIndexPaths_XHandle = Selector.GetHandle ("reloadItemsAtIndexPaths:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadSections_X = "reloadSections:";
		static readonly NativeHandle selReloadSections_XHandle = Selector.GetHandle ("reloadSections:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollToItemsAtIndexPaths_ScrollPosition_X = "scrollToItemsAtIndexPaths:scrollPosition:";
		static readonly NativeHandle selScrollToItemsAtIndexPaths_ScrollPosition_XHandle = Selector.GetHandle ("scrollToItemsAtIndexPaths:scrollPosition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectAll_X = "selectAll:";
		static readonly NativeHandle selSelectAll_XHandle = Selector.GetHandle ("selectAll:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectItemsAtIndexPaths_ScrollPosition_X = "selectItemsAtIndexPaths:scrollPosition:";
		static readonly NativeHandle selSelectItemsAtIndexPaths_ScrollPosition_XHandle = Selector.GetHandle ("selectItemsAtIndexPaths:scrollPosition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionIndexPathsX = "selectionIndexPaths";
		static readonly NativeHandle selSelectionIndexPathsXHandle = Selector.GetHandle ("selectionIndexPaths");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionIndexesX = "selectionIndexes";
		static readonly NativeHandle selSelectionIndexesXHandle = Selector.GetHandle ("selectionIndexes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsEmptySelection_X = "setAllowsEmptySelection:";
		static readonly NativeHandle selSetAllowsEmptySelection_XHandle = Selector.GetHandle ("setAllowsEmptySelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsMultipleSelection_X = "setAllowsMultipleSelection:";
		static readonly NativeHandle selSetAllowsMultipleSelection_XHandle = Selector.GetHandle ("setAllowsMultipleSelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBackgroundColors_X = "setBackgroundColors:";
		static readonly NativeHandle selSetBackgroundColors_XHandle = Selector.GetHandle ("setBackgroundColors:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBackgroundView_X = "setBackgroundView:";
		static readonly NativeHandle selSetBackgroundView_XHandle = Selector.GetHandle ("setBackgroundView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBackgroundViewScrollsWithContent_X = "setBackgroundViewScrollsWithContent:";
		static readonly NativeHandle selSetBackgroundViewScrollsWithContent_XHandle = Selector.GetHandle ("setBackgroundViewScrollsWithContent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCollectionViewLayout_X = "setCollectionViewLayout:";
		static readonly NativeHandle selSetCollectionViewLayout_XHandle = Selector.GetHandle ("setCollectionViewLayout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContent_X = "setContent:";
		static readonly NativeHandle selSetContent_XHandle = Selector.GetHandle ("setContent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDataSource_X = "setDataSource:";
		static readonly NativeHandle selSetDataSource_XHandle = Selector.GetHandle ("setDataSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDraggingSourceOperationMask_ForLocal_X = "setDraggingSourceOperationMask:forLocal:";
		static readonly NativeHandle selSetDraggingSourceOperationMask_ForLocal_XHandle = Selector.GetHandle ("setDraggingSourceOperationMask:forLocal:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetItemPrototype_X = "setItemPrototype:";
		static readonly NativeHandle selSetItemPrototype_XHandle = Selector.GetHandle ("setItemPrototype:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaxItemSize_X = "setMaxItemSize:";
		static readonly NativeHandle selSetMaxItemSize_XHandle = Selector.GetHandle ("setMaxItemSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaxNumberOfColumns_X = "setMaxNumberOfColumns:";
		static readonly NativeHandle selSetMaxNumberOfColumns_XHandle = Selector.GetHandle ("setMaxNumberOfColumns:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaxNumberOfRows_X = "setMaxNumberOfRows:";
		static readonly NativeHandle selSetMaxNumberOfRows_XHandle = Selector.GetHandle ("setMaxNumberOfRows:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMinItemSize_X = "setMinItemSize:";
		static readonly NativeHandle selSetMinItemSize_XHandle = Selector.GetHandle ("setMinItemSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrefetchDataSource_X = "setPrefetchDataSource:";
		static readonly NativeHandle selSetPrefetchDataSource_XHandle = Selector.GetHandle ("setPrefetchDataSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectable_X = "setSelectable:";
		static readonly NativeHandle selSetSelectable_XHandle = Selector.GetHandle ("setSelectable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectionIndexPaths_X = "setSelectionIndexPaths:";
		static readonly NativeHandle selSetSelectionIndexPaths_XHandle = Selector.GetHandle ("setSelectionIndexPaths:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectionIndexes_X = "setSelectionIndexes:";
		static readonly NativeHandle selSetSelectionIndexes_XHandle = Selector.GetHandle ("setSelectionIndexes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupplementaryViewForElementKind_AtIndexPath_X = "supplementaryViewForElementKind:atIndexPath:";
		static readonly NativeHandle selSupplementaryViewForElementKind_AtIndexPath_XHandle = Selector.GetHandle ("supplementaryViewForElementKind:atIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToggleSectionCollapse_X = "toggleSectionCollapse:";
		static readonly NativeHandle selToggleSectionCollapse_XHandle = Selector.GetHandle ("toggleSectionCollapse:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVisibleItemsX = "visibleItems";
		static readonly NativeHandle selVisibleItemsXHandle = Selector.GetHandle ("visibleItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVisibleSupplementaryViewsOfKind_X = "visibleSupplementaryViewsOfKind:";
		static readonly NativeHandle selVisibleSupplementaryViewsOfKind_XHandle = Selector.GetHandle ("visibleSupplementaryViewsOfKind:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWantsPeriodicDraggingUpdatesX = "wantsPeriodicDraggingUpdates";
		static readonly NativeHandle selWantsPeriodicDraggingUpdatesXHandle = Selector.GetHandle ("wantsPeriodicDraggingUpdates");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSCollectionView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSCollectionView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSCollectionView () : base (NSObjectFlag.Empty)
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

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public NSCollectionView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected NSCollectionView (NSObjectFlag t) : base (t)
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
		protected internal NSCollectionView (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSCollectionView (CGRect frameRect)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selInitWithFrame_XHandle, frameRect), "initWithFrame:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selInitWithFrame_XHandle, frameRect), "initWithFrame:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("concludeDragOperation:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual void ConcludeDragOperation (INSDraggingInfo? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selConcludeDragOperation_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selConcludeDragOperation_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("deleteItemsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeleteItems (NSSet<NSIndexPath> indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDeleteItemsAtIndexPaths_XHandle, indexPaths__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDeleteItemsAtIndexPaths_XHandle, indexPaths__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexPaths);
		}
		[Export ("deleteSections:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeleteSections (NSIndexSet sections)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sections__handle__ = sections!.GetNonNullHandle (nameof (sections));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDeleteSections_XHandle, sections__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDeleteSections_XHandle, sections__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sections);
		}
		[Export ("deselectAll:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeselectAll (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDeselectAll_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDeselectAll_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("deselectItemsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeselectItems (NSSet indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDeselectItemsAtIndexPaths_XHandle, indexPaths__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDeselectItemsAtIndexPaths_XHandle, indexPaths__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexPaths);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("draggedImage:beganAt:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageBeganAt (NSImage image, CGPoint screenPoint)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint (this.Handle, selDraggedImage_BeganAt_XHandle, image__handle__, screenPoint);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGPoint (&__objc_super__, selDraggedImage_BeganAt_XHandle, image__handle__, screenPoint);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><param name="deposited">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("draggedImage:endedAt:deposited:")]
		[ObsoletedOSPlatform ("macos10.1", "Use DraggedImageEndedAtOperation instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageEndedAtDeposited (NSImage image, CGPoint screenPoint, bool deposited)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_bool (this.Handle, selDraggedImage_EndedAt_Deposited_XHandle, image__handle__, screenPoint, deposited ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGPoint_bool (&__objc_super__, selDraggedImage_EndedAt_Deposited_XHandle, image__handle__, screenPoint, deposited ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><param name="operation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("draggedImage:endedAt:operation:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageEndedAtOperation (NSImage image, CGPoint screenPoint, NSDragOperation operation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_UIntPtr (this.Handle, selDraggedImage_EndedAt_Operation_XHandle, image__handle__, screenPoint, (UIntPtr) (ulong) operation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGPoint_UIntPtr (&__objc_super__, selDraggedImage_EndedAt_Operation_XHandle, image__handle__, screenPoint, (UIntPtr) (ulong) operation);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("draggedImage:movedTo:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageMovedTo (NSImage image, CGPoint screenPoint)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint (this.Handle, selDraggedImage_MovedTo_XHandle, image__handle__, screenPoint);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGPoint (&__objc_super__, selDraggedImage_MovedTo_XHandle, image__handle__, screenPoint);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		[Export ("draggingEnded:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual void DraggingEnded (INSDraggingInfo sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDraggingEnded_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDraggingEnded_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("draggingEntered:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual NSDragOperation DraggingEntered (INSDraggingInfo sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			NSDragOperation ret;
			if (IsDirectBinding) {
				ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (this.Handle, selDraggingEntered_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selDraggingEntered_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
			return ret!;
		}
		[Export ("draggingExited:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual void DraggingExited (INSDraggingInfo? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDraggingExited_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDraggingExited_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <param name="flag">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("draggingSourceOperationMaskForLocal:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDragOperation DraggingSourceOperationMaskForLocal (bool flag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSDragOperation ret;
			if (IsDirectBinding) {
				ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_bool (this.Handle, selDraggingSourceOperationMaskForLocal_XHandle, flag ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_bool (&__objc_super__, selDraggingSourceOperationMaskForLocal_XHandle, flag ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		[Export ("draggingUpdated:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual NSDragOperation DraggingUpdated (INSDraggingInfo sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			NSDragOperation ret;
			if (IsDirectBinding) {
				ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (this.Handle, selDraggingUpdated_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selDraggingUpdated_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
			return ret!;
		}
		[Export ("draggingImageForItemsAtIndexPaths:withEvent:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSImage GetDraggingImage (NSSet<NSIndexPath> indexPaths, NSEvent theEvent, ref CGPoint dragImageOffset)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			fixed (CGPoint* dragImageOffset__pointer = &dragImageOffset) {
			NSImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_CGPoint (this.Handle, selDraggingImageForItemsAtIndexPaths_WithEvent_Offset_XHandle, indexPaths__handle__, theEvent__handle__, dragImageOffset__pointer), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_CGPoint (&__objc_super__, selDraggingImageForItemsAtIndexPaths_WithEvent_Offset_XHandle, indexPaths__handle__, theEvent__handle__, dragImageOffset__pointer), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexPaths);
			GC.KeepAlive (theEvent);
			return ret!;
			}
		}
		[Export ("frameForItemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFrameForItem (nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_IntPtr (this.Handle, selFrameForItemAtIndex_XHandle, index);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_IntPtr (this.Handle, selFrameForItemAtIndex_XHandle, index);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_IntPtr (&__objc_super__, selFrameForItemAtIndex_XHandle, index);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_IntPtr (&__objc_super__, selFrameForItemAtIndex_XHandle, index);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("frameForItemAtIndex:withNumberOfItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFrameForItem (nint index, nint numberOfItems)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_IntPtr_IntPtr (this.Handle, selFrameForItemAtIndex_WithNumberOfItems_XHandle, index, numberOfItems);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_IntPtr_IntPtr (this.Handle, selFrameForItemAtIndex_WithNumberOfItems_XHandle, index, numberOfItems);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selFrameForItemAtIndex_WithNumberOfItems_XHandle, index, numberOfItems);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_IntPtr (&__objc_super__, selFrameForItemAtIndex_WithNumberOfItems_XHandle, index, numberOfItems);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("indexPathForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? GetIndexPath (NSCollectionViewItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSIndexPath? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selIndexPathForItem_XHandle, item__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selIndexPathForItem_XHandle, item__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
			return ret!;
		}
		[Export ("indexPathForItemAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? GetIndexPath (CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSIndexPath ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, selIndexPathForItemAtPoint_XHandle, point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint (&__objc_super__, selIndexPathForItemAtPoint_XHandle, point), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("indexPathsForVisibleSupplementaryElementsOfKind:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet GetIndexPaths (string elementKind)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (elementKind is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (elementKind));
			var nselementKind = CFString.CreateNative (elementKind);
			NSSet? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selIndexPathsForVisibleSupplementaryElementsOfKind_XHandle, nselementKind), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selIndexPathsForVisibleSupplementaryElementsOfKind_XHandle, nselementKind), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nselementKind);
			return ret!;
		}
		[Export ("itemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewItem? GetItem (nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSCollectionViewItem ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selItemAtIndex_XHandle, index), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selItemAtIndex_XHandle, index), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("itemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewItem? GetItem (NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			NSCollectionViewItem? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selItemAtIndexPath_XHandle, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selItemAtIndexPath_XHandle, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[Export ("layoutAttributesForItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewLayoutAttributes? GetLayoutAttributes (NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			NSCollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selLayoutAttributesForItemAtIndexPath_XHandle, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selLayoutAttributesForItemAtIndexPath_XHandle, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[Export ("layoutAttributesForSupplementaryElementOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewLayoutAttributes? GetLayoutAttributes (string kind, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (kind is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (kind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var nskind = CFString.CreateNative (kind);
			NSCollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLayoutAttributesForSupplementaryElementOfKind_AtIndexPath_XHandle, nskind, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLayoutAttributesForSupplementaryElementOfKind_AtIndexPath_XHandle, nskind, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexPath);
			CFString.ReleaseNative (nskind);
			return ret!;
		}
		[Export ("numberOfItemsInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetNumberOfItems (nint section)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selNumberOfItemsInSection_XHandle, section);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, selNumberOfItemsInSection_XHandle, section);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("supplementaryViewForElementKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSCollectionViewElement? GetSupplementaryView (NSString elementKind, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			INSCollectionViewElement? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<INSCollectionViewElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSupplementaryViewForElementKind_AtIndexPath_XHandle, elementKind__handle__, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<INSCollectionViewElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSupplementaryViewForElementKind_AtIndexPath_XHandle, elementKind__handle__, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (elementKind);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[Export ("visibleSupplementaryViewsOfKind:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSCollectionViewElement[] GetVisibleSupplementaryViews (NSString elementKind)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			INSCollectionViewElement[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<INSCollectionViewElement>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selVisibleSupplementaryViewsOfKind_XHandle, elementKind__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<INSCollectionViewElement>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selVisibleSupplementaryViewsOfKind_XHandle, elementKind__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (elementKind);
			return ret!;
		}
		[Export ("insertItemsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertItems (NSSet<NSIndexPath> indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selInsertItemsAtIndexPaths_XHandle, indexPaths__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selInsertItemsAtIndexPaths_XHandle, indexPaths__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexPaths);
		}
		[Export ("insertSections:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertSections (NSIndexSet sections)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sections__handle__ = sections!.GetNonNullHandle (nameof (sections));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selInsertSections_XHandle, sections__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selInsertSections_XHandle, sections__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sections);
		}
		[Export ("makeItemWithIdentifier:forIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewItem MakeItem (string identifier, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var nsidentifier = CFString.CreateNative (identifier);
			NSCollectionViewItem? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selMakeItemWithIdentifier_ForIndexPath_XHandle, nsidentifier, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selMakeItemWithIdentifier_ForIndexPath_XHandle, nsidentifier, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexPath);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("makeSupplementaryViewOfKind:withIdentifier:forIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView MakeSupplementaryView (NSString elementKind, string identifier, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var nsidentifier = CFString.CreateNative (identifier);
			NSView? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selMakeSupplementaryViewOfKind_WithIdentifier_ForIndexPath_XHandle, elementKind__handle__, nsidentifier, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selMakeSupplementaryViewOfKind_WithIdentifier_ForIndexPath_XHandle, elementKind__handle__, nsidentifier, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (elementKind);
			GC.KeepAlive (indexPath);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("moveItemAtIndexPath:toIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveItem (NSIndexPath indexPath, NSIndexPath newIndexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var newIndexPath__handle__ = newIndexPath!.GetNonNullHandle (nameof (newIndexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selMoveItemAtIndexPath_ToIndexPath_XHandle, indexPath__handle__, newIndexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selMoveItemAtIndexPath_ToIndexPath_XHandle, indexPath__handle__, newIndexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexPath);
			GC.KeepAlive (newIndexPath);
		}
		[Export ("moveSection:toSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveSection (nint section, nint newSection)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selMoveSection_ToSection_XHandle, section, newSection);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selMoveSection_ToSection_XHandle, section, newSection);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="dropDestination">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("namesOfPromisedFilesDroppedAtDestination:")]
		[ObsoletedOSPlatform ("macos10.13", "Use NSFilePromiseProvider objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] NamesOfPromisedFilesDroppedAtDestination (NSUrl dropDestination)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var dropDestination__handle__ = dropDestination!.GetNonNullHandle (nameof (dropDestination));
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selNamesOfPromisedFilesDroppedAtDestination_XHandle, dropDestination__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selNamesOfPromisedFilesDroppedAtDestination_XHandle, dropDestination__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dropDestination);
			return ret!;
		}
		[Export ("newItemForRepresentedObject:")]
		[return: ReleaseAttribute ()]
		[ObsoletedOSPlatform ("macos10.14", "Use 'NSCollectionViewDataSource.GetItem()' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewItem NewItemForRepresentedObject (NSObject obj)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			NSCollectionViewItem? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selNewItemForRepresentedObject_XHandle, obj__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selNewItemForRepresentedObject_XHandle, obj__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
			return ret!;
		}
		[Export ("performBatchUpdates:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PerformBatchUpdates ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action updates, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (updates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (updates));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_updates = Trampolines.SDAction.CreateBlock (updates);
			BlockLiteral *block_ptr_updates = &block_updates;
			using var block_completionHandler = Trampolines.SDActionArity1V2.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPerformBatchUpdates_CompletionHandler_XHandle, (IntPtr) block_ptr_updates, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPerformBatchUpdates_CompletionHandler_XHandle, (IntPtr) block_ptr_updates, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("performDragOperation:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual bool PerformDragOperation (INSDraggingInfo sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selPerformDragOperation_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selPerformDragOperation_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
			return ret != 0;
		}
		[Export ("prepareForDragOperation:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual bool PrepareForDragOperation (INSDraggingInfo sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selPrepareForDragOperation_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selPrepareForDragOperation_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
			return ret != 0;
		}
		[Export ("registerNib:forItemWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisterNib (NSNib? nib, string identifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nib__handle__ = nib.GetHandle ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRegisterNib_ForItemWithIdentifier_XHandle, nib__handle__, nsidentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRegisterNib_ForItemWithIdentifier_XHandle, nib__handle__, nsidentifier);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (nib);
			CFString.ReleaseNative (nsidentifier);
		}
		[Export ("registerNib:forSupplementaryViewOfKind:withIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisterNib (NSNib? nib, NSString kind, string identifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nib__handle__ = nib.GetHandle ();
			var kind__handle__ = kind!.GetNonNullHandle (nameof (kind));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selRegisterNib_ForSupplementaryViewOfKind_WithIdentifier_XHandle, nib__handle__, kind__handle__, nsidentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selRegisterNib_ForSupplementaryViewOfKind_WithIdentifier_XHandle, nib__handle__, kind__handle__, nsidentifier);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (nib);
			GC.KeepAlive (kind);
			CFString.ReleaseNative (nsidentifier);
		}
		[Export ("reloadData")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadData ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReloadDataXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selReloadDataXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("reloadItemsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadItems (NSSet<NSIndexPath> indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReloadItemsAtIndexPaths_XHandle, indexPaths__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReloadItemsAtIndexPaths_XHandle, indexPaths__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexPaths);
		}
		[Export ("reloadSections:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadSections (NSIndexSet sections)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sections__handle__ = sections!.GetNonNullHandle (nameof (sections));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReloadSections_XHandle, sections__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReloadSections_XHandle, sections__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sections);
		}
		[Export ("scrollToItemsAtIndexPaths:scrollPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollToItems (NSSet<NSIndexPath> indexPaths, NSCollectionViewScrollPosition scrollPosition)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selScrollToItemsAtIndexPaths_ScrollPosition_XHandle, indexPaths__handle__, (UIntPtr) (ulong) scrollPosition);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selScrollToItemsAtIndexPaths_ScrollPosition_XHandle, indexPaths__handle__, (UIntPtr) (ulong) scrollPosition);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexPaths);
		}
		[Export ("selectAll:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectAll (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSelectAll_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSelectAll_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("selectItemsAtIndexPaths:scrollPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectItems (NSSet indexPaths, NSCollectionViewScrollPosition scrollPosition)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexPaths__handle__ = indexPaths!.GetNonNullHandle (nameof (indexPaths));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selSelectItemsAtIndexPaths_ScrollPosition_XHandle, indexPaths__handle__, (UIntPtr) (ulong) scrollPosition);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selSelectItemsAtIndexPaths_ScrollPosition_XHandle, indexPaths__handle__, (UIntPtr) (ulong) scrollPosition);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexPaths);
		}
		[Export ("setDraggingSourceOperationMask:forLocal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDraggingSource (NSDragOperation dragOperationMask, bool localDestination)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_bool (this.Handle, selSetDraggingSourceOperationMask_ForLocal_XHandle, (UIntPtr) (ulong) dragOperationMask, localDestination ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_bool (&__objc_super__, selSetDraggingSourceOperationMask_ForLocal_XHandle, (UIntPtr) (ulong) dragOperationMask, localDestination ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("toggleSectionCollapse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleSectionCollapse (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToggleSectionCollapse_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToggleSectionCollapse_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("registerClass:forItemWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _RegisterClassForItem (nint itemClass, string identifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, selRegisterClass_ForItemWithIdentifier_XHandle, itemClass, nsidentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selRegisterClass_ForItemWithIdentifier_XHandle, itemClass, nsidentifier);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsidentifier);
		}
		[Export ("registerClass:forSupplementaryViewOfKind:withIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _RegisterClassForSupplementaryView (nint viewClass, NSString kind, string identifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var kind__handle__ = kind!.GetNonNullHandle (nameof (kind));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle (this.Handle, selRegisterClass_ForSupplementaryViewOfKind_WithIdentifier_XHandle, viewClass, kind__handle__, nsidentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle_NativeHandle (&__objc_super__, selRegisterClass_ForSupplementaryViewOfKind_WithIdentifier_XHandle, viewClass, kind__handle__, nsidentifier);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (kind);
			CFString.ReleaseNative (nsidentifier);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsEmptySelection {
			[Export ("allowsEmptySelection")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsEmptySelectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsEmptySelectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsEmptySelection:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsEmptySelection_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsEmptySelection_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsMultipleSelection {
			[Export ("allowsMultipleSelection")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsMultipleSelectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsMultipleSelectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsMultipleSelection:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsMultipleSelection_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsMultipleSelection_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColor[]? BackgroundColors {
			[Export ("backgroundColors", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSColor[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSColor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBackgroundColorsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSColor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBackgroundColorsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBackgroundColors:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetBackgroundColors_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetBackgroundColors_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView? BackgroundView {
			[Export ("backgroundView", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBackgroundViewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBackgroundViewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBackgroundView:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetBackgroundView_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetBackgroundView_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool BackgroundViewScrollsWithContent {
			[Export ("backgroundViewScrollsWithContent")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selBackgroundViewScrollsWithContentXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selBackgroundViewScrollsWithContentXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setBackgroundViewScrollsWithContent:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetBackgroundViewScrollsWithContent_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetBackgroundViewScrollsWithContent_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewLayout? CollectionViewLayout {
			[Export ("collectionViewLayout", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCollectionViewLayout? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSCollectionViewLayout> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCollectionViewLayoutXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSCollectionViewLayout> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCollectionViewLayoutXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCollectionViewLayout:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCollectionViewLayout_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCollectionViewLayout_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] Content {
			[Export ("content", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setContent:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetContent_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetContent_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_DataSource_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSCollectionViewDataSource? DataSource {
			[Export ("dataSource", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				INSCollectionViewDataSource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<INSCollectionViewDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDataSourceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<INSCollectionViewDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDataSourceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_DataSource_var = ret;
				return ret!;
			}
			[Export ("setDataSource:", ArgumentSemantic.Weak)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDataSource_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDataSource_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_DataSource_var = value;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSCollectionViewDelegate Delegate {
			get {
				return (WeakDelegate as INSCollectionViewDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool IgnoreModifierKeysWhileDragging {
			[Export ("ignoreModifierKeysWhileDragging")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIgnoreModifierKeysWhileDraggingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIgnoreModifierKeysWhileDraggingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<NSIndexPath> IndexPathsForVisibleItems {
			[Export ("indexPathsForVisibleItems")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSSet<NSIndexPath>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<NSIndexPath>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIndexPathsForVisibleItemsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<NSIndexPath>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIndexPathsForVisibleItemsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsFirstResponder {
			[Export ("isFirstResponder")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFirstResponderXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsFirstResponderXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.14", "Use 'RegisterNib' or 'RegisterClassForItem' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSCollectionViewItem ItemPrototype {
			[Export ("itemPrototype", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCollectionViewItem? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSCollectionViewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selItemPrototypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSCollectionViewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selItemPrototypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setItemPrototype:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetItemPrototype_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetItemPrototype_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.14", "Set a NSCollectionViewGridLayout on CollectionViewLayout and set its 'MaximumItemSize' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual CGSize MaxItemSize {
			[Export ("maxItemSize")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selMaxItemSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selMaxItemSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaxItemSize:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, selSetMaxItemSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, selSetMaxItemSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.14", "Set a NSCollectionViewGridLayout on CollectionViewLayout and set its 'MaximumNumberOfColumns' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual nint MaxNumberOfColumns {
			[Export ("maxNumberOfColumns")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMaxNumberOfColumnsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMaxNumberOfColumnsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaxNumberOfColumns:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMaxNumberOfColumns_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetMaxNumberOfColumns_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.14", "Set a NSCollectionViewGridLayout on CollectionViewLayout and set its 'MaximumNumberOfRows' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual nint MaxNumberOfRows {
			[Export ("maxNumberOfRows")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMaxNumberOfRowsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMaxNumberOfRowsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaxNumberOfRows:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMaxNumberOfRows_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetMaxNumberOfRows_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.14", "Set a NSCollectionViewGridLayout on CollectionViewLayout and set its 'MinimumItemSize' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual CGSize MinItemSize {
			[Export ("minItemSize")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selMinItemSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selMinItemSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinItemSize:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, selSetMinItemSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, selSetMinItemSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfSections {
			[Export ("numberOfSections")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfSectionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfSectionsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_PrefetchDataSource_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSCollectionViewPrefetching? PrefetchDataSource {
			[Export ("prefetchDataSource", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				INSCollectionViewPrefetching? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<INSCollectionViewPrefetching> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPrefetchDataSourceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<INSCollectionViewPrefetching> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPrefetchDataSourceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_PrefetchDataSource_var = ret;
				return ret!;
			}
			[Export ("setPrefetchDataSource:", ArgumentSemantic.Weak)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPrefetchDataSource_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPrefetchDataSource_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_PrefetchDataSource_var = value;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Selectable {
			[Export ("isSelectable")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSelectableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsSelectableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSelectable:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSelectable_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetSelectable_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet SelectionIndexPaths {
			[Export ("selectionIndexPaths", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectionIndexPathsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectionIndexPathsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSelectionIndexPaths:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSelectionIndexPaths_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSelectionIndexPaths_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexSet SelectionIndexes {
			[Export ("selectionIndexes", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSIndexSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectionIndexesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectionIndexesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSelectionIndexes:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSelectionIndexes_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSelectionIndexes_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewItem[] VisibleItems {
			[Export ("visibleItems")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCollectionViewItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSCollectionViewItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVisibleItemsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSCollectionViewItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVisibleItemsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool WantsPeriodicDraggingUpdates {
			[Export ("wantsPeriodicDraggingUpdates")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selWantsPeriodicDraggingUpdatesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selWantsPeriodicDraggingUpdatesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DataSource_var = null;
				__mt_PrefetchDataSource_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class NSCollectionView */
}
