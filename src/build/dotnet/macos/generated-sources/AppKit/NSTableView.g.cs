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
	[Register("NSTableView", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSTableView : NSControl, INSAccessibilityElementProtocol, INSAccessibilityGroup, INSAccessibilityTable, INSDraggingSource, INSUserInterfaceValidations {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityColumnHeaderUIElementsX = "accessibilityColumnHeaderUIElements";
		static readonly NativeHandle selAccessibilityColumnHeaderUIElementsXHandle = Selector.GetHandle ("accessibilityColumnHeaderUIElements");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityColumnsX = "accessibilityColumns";
		static readonly NativeHandle selAccessibilityColumnsXHandle = Selector.GetHandle ("accessibilityColumns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityFrameX = "accessibilityFrame";
		static readonly NativeHandle selAccessibilityFrameXHandle = Selector.GetHandle ("accessibilityFrame");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityHeaderGroupX = "accessibilityHeaderGroup";
		static readonly NativeHandle selAccessibilityHeaderGroupXHandle = Selector.GetHandle ("accessibilityHeaderGroup");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityIdentifierX = "accessibilityIdentifier";
		static readonly NativeHandle selAccessibilityIdentifierXHandle = Selector.GetHandle ("accessibilityIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityLabelX = "accessibilityLabel";
		static readonly NativeHandle selAccessibilityLabelXHandle = Selector.GetHandle ("accessibilityLabel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityParentX = "accessibilityParent";
		static readonly NativeHandle selAccessibilityParentXHandle = Selector.GetHandle ("accessibilityParent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityRowHeaderUIElementsX = "accessibilityRowHeaderUIElements";
		static readonly NativeHandle selAccessibilityRowHeaderUIElementsXHandle = Selector.GetHandle ("accessibilityRowHeaderUIElements");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityRowsX = "accessibilityRows";
		static readonly NativeHandle selAccessibilityRowsXHandle = Selector.GetHandle ("accessibilityRows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySelectedCellsX = "accessibilitySelectedCells";
		static readonly NativeHandle selAccessibilitySelectedCellsXHandle = Selector.GetHandle ("accessibilitySelectedCells");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySelectedColumnsX = "accessibilitySelectedColumns";
		static readonly NativeHandle selAccessibilitySelectedColumnsXHandle = Selector.GetHandle ("accessibilitySelectedColumns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySelectedRowsX = "accessibilitySelectedRows";
		static readonly NativeHandle selAccessibilitySelectedRowsXHandle = Selector.GetHandle ("accessibilitySelectedRows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityVisibleCellsX = "accessibilityVisibleCells";
		static readonly NativeHandle selAccessibilityVisibleCellsXHandle = Selector.GetHandle ("accessibilityVisibleCells");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityVisibleColumnsX = "accessibilityVisibleColumns";
		static readonly NativeHandle selAccessibilityVisibleColumnsXHandle = Selector.GetHandle ("accessibilityVisibleColumns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityVisibleRowsX = "accessibilityVisibleRows";
		static readonly NativeHandle selAccessibilityVisibleRowsXHandle = Selector.GetHandle ("accessibilityVisibleRows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddTableColumn_X = "addTableColumn:";
		static readonly NativeHandle selAddTableColumn_XHandle = Selector.GetHandle ("addTableColumn:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsColumnReorderingX = "allowsColumnReordering";
		static readonly NativeHandle selAllowsColumnReorderingXHandle = Selector.GetHandle ("allowsColumnReordering");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsColumnResizingX = "allowsColumnResizing";
		static readonly NativeHandle selAllowsColumnResizingXHandle = Selector.GetHandle ("allowsColumnResizing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsColumnSelectionX = "allowsColumnSelection";
		static readonly NativeHandle selAllowsColumnSelectionXHandle = Selector.GetHandle ("allowsColumnSelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsEmptySelectionX = "allowsEmptySelection";
		static readonly NativeHandle selAllowsEmptySelectionXHandle = Selector.GetHandle ("allowsEmptySelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsMultipleSelectionX = "allowsMultipleSelection";
		static readonly NativeHandle selAllowsMultipleSelectionXHandle = Selector.GetHandle ("allowsMultipleSelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsTypeSelectX = "allowsTypeSelect";
		static readonly NativeHandle selAllowsTypeSelectXHandle = Selector.GetHandle ("allowsTypeSelect");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutosaveNameX = "autosaveName";
		static readonly NativeHandle selAutosaveNameXHandle = Selector.GetHandle ("autosaveName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutosaveTableColumnsX = "autosaveTableColumns";
		static readonly NativeHandle selAutosaveTableColumnsXHandle = Selector.GetHandle ("autosaveTableColumns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackgroundColorX = "backgroundColor";
		static readonly NativeHandle selBackgroundColorXHandle = Selector.GetHandle ("backgroundColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginUpdatesX = "beginUpdates";
		static readonly NativeHandle selBeginUpdatesXHandle = Selector.GetHandle ("beginUpdates");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanDragRowsWithIndexes_AtPoint_X = "canDragRowsWithIndexes:atPoint:";
		static readonly NativeHandle selCanDragRowsWithIndexes_AtPoint_XHandle = Selector.GetHandle ("canDragRowsWithIndexes:atPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClickedColumnX = "clickedColumn";
		static readonly NativeHandle selClickedColumnXHandle = Selector.GetHandle ("clickedColumn");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClickedRowX = "clickedRow";
		static readonly NativeHandle selClickedRowXHandle = Selector.GetHandle ("clickedRow");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColumnAtPoint_X = "columnAtPoint:";
		static readonly NativeHandle selColumnAtPoint_XHandle = Selector.GetHandle ("columnAtPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColumnAutoresizingStyleX = "columnAutoresizingStyle";
		static readonly NativeHandle selColumnAutoresizingStyleXHandle = Selector.GetHandle ("columnAutoresizingStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColumnForView_X = "columnForView:";
		static readonly NativeHandle selColumnForView_XHandle = Selector.GetHandle ("columnForView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColumnIndexesInRect_X = "columnIndexesInRect:";
		static readonly NativeHandle selColumnIndexesInRect_XHandle = Selector.GetHandle ("columnIndexesInRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColumnWithIdentifier_X = "columnWithIdentifier:";
		static readonly NativeHandle selColumnWithIdentifier_XHandle = Selector.GetHandle ("columnWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCornerViewX = "cornerView";
		static readonly NativeHandle selCornerViewXHandle = Selector.GetHandle ("cornerView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataSourceX = "dataSource";
		static readonly NativeHandle selDataSourceXHandle = Selector.GetHandle ("dataSource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeselectAll_X = "deselectAll:";
		static readonly NativeHandle selDeselectAll_XHandle = Selector.GetHandle ("deselectAll:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeselectColumn_X = "deselectColumn:";
		static readonly NativeHandle selDeselectColumn_XHandle = Selector.GetHandle ("deselectColumn:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeselectRow_X = "deselectRow:";
		static readonly NativeHandle selDeselectRow_XHandle = Selector.GetHandle ("deselectRow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidAddRowView_ForRow_X = "didAddRowView:forRow:";
		static readonly NativeHandle selDidAddRowView_ForRow_XHandle = Selector.GetHandle ("didAddRowView:forRow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidRemoveRowView_ForRow_X = "didRemoveRowView:forRow:";
		static readonly NativeHandle selDidRemoveRowView_ForRow_XHandle = Selector.GetHandle ("didRemoveRowView:forRow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDoubleActionX = "doubleAction";
		static readonly NativeHandle selDoubleActionXHandle = Selector.GetHandle ("doubleAction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDragImageForRowsWithIndexes_TableColumns_Event_Offset_X = "dragImageForRowsWithIndexes:tableColumns:event:offset:";
		static readonly NativeHandle selDragImageForRowsWithIndexes_TableColumns_Event_Offset_XHandle = Selector.GetHandle ("dragImageForRowsWithIndexes:tableColumns:event:offset:");
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
		const string selDraggingDestinationFeedbackStyleX = "draggingDestinationFeedbackStyle";
		static readonly NativeHandle selDraggingDestinationFeedbackStyleXHandle = Selector.GetHandle ("draggingDestinationFeedbackStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggingSourceOperationMaskForLocal_X = "draggingSourceOperationMaskForLocal:";
		static readonly NativeHandle selDraggingSourceOperationMaskForLocal_XHandle = Selector.GetHandle ("draggingSourceOperationMaskForLocal:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawBackgroundInClipRect_X = "drawBackgroundInClipRect:";
		static readonly NativeHandle selDrawBackgroundInClipRect_XHandle = Selector.GetHandle ("drawBackgroundInClipRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawGridInClipRect_X = "drawGridInClipRect:";
		static readonly NativeHandle selDrawGridInClipRect_XHandle = Selector.GetHandle ("drawGridInClipRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawRow_ClipRect_X = "drawRow:clipRect:";
		static readonly NativeHandle selDrawRow_ClipRect_XHandle = Selector.GetHandle ("drawRow:clipRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEditColumn_Row_WithEvent_Select_X = "editColumn:row:withEvent:select:";
		static readonly NativeHandle selEditColumn_Row_WithEvent_Select_XHandle = Selector.GetHandle ("editColumn:row:withEvent:select:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEditedColumnX = "editedColumn";
		static readonly NativeHandle selEditedColumnXHandle = Selector.GetHandle ("editedColumn");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEditedRowX = "editedRow";
		static readonly NativeHandle selEditedRowXHandle = Selector.GetHandle ("editedRow");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEffectiveRowSizeStyleX = "effectiveRowSizeStyle";
		static readonly NativeHandle selEffectiveRowSizeStyleXHandle = Selector.GetHandle ("effectiveRowSizeStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEffectiveStyleX = "effectiveStyle";
		static readonly NativeHandle selEffectiveStyleXHandle = Selector.GetHandle ("effectiveStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndUpdatesX = "endUpdates";
		static readonly NativeHandle selEndUpdatesXHandle = Selector.GetHandle ("endUpdates");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateAvailableRowViewsUsingBlock_X = "enumerateAvailableRowViewsUsingBlock:";
		static readonly NativeHandle selEnumerateAvailableRowViewsUsingBlock_XHandle = Selector.GetHandle ("enumerateAvailableRowViewsUsingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFloatsGroupRowsX = "floatsGroupRows";
		static readonly NativeHandle selFloatsGroupRowsXHandle = Selector.GetHandle ("floatsGroupRows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFocusedColumnX = "focusedColumn";
		static readonly NativeHandle selFocusedColumnXHandle = Selector.GetHandle ("focusedColumn");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameOfCellAtColumn_Row_X = "frameOfCellAtColumn:row:";
		static readonly NativeHandle selFrameOfCellAtColumn_Row_XHandle = Selector.GetHandle ("frameOfCellAtColumn:row:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGridColorX = "gridColor";
		static readonly NativeHandle selGridColorXHandle = Selector.GetHandle ("gridColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGridStyleMaskX = "gridStyleMask";
		static readonly NativeHandle selGridStyleMaskXHandle = Selector.GetHandle ("gridStyleMask");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHeaderViewX = "headerView";
		static readonly NativeHandle selHeaderViewXHandle = Selector.GetHandle ("headerView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHiddenRowIndexesX = "hiddenRowIndexes";
		static readonly NativeHandle selHiddenRowIndexesXHandle = Selector.GetHandle ("hiddenRowIndexes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHideRowsAtIndexes_WithAnimation_X = "hideRowsAtIndexes:withAnimation:";
		static readonly NativeHandle selHideRowsAtIndexes_WithAnimation_XHandle = Selector.GetHandle ("hideRowsAtIndexes:withAnimation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHighlightSelectionInClipRect_X = "highlightSelectionInClipRect:";
		static readonly NativeHandle selHighlightSelectionInClipRect_XHandle = Selector.GetHandle ("highlightSelectionInClipRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHighlightedTableColumnX = "highlightedTableColumn";
		static readonly NativeHandle selHighlightedTableColumnXHandle = Selector.GetHandle ("highlightedTableColumn");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIgnoreModifierKeysWhileDraggingX = "ignoreModifierKeysWhileDragging";
		static readonly NativeHandle selIgnoreModifierKeysWhileDraggingXHandle = Selector.GetHandle ("ignoreModifierKeysWhileDragging");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndicatorImageInTableColumn_X = "indicatorImageInTableColumn:";
		static readonly NativeHandle selIndicatorImageInTableColumn_XHandle = Selector.GetHandle ("indicatorImageInTableColumn:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_X = "initWithFrame:";
		static readonly NativeHandle selInitWithFrame_XHandle = Selector.GetHandle ("initWithFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertRowsAtIndexes_WithAnimation_X = "insertRowsAtIndexes:withAnimation:";
		static readonly NativeHandle selInsertRowsAtIndexes_WithAnimation_XHandle = Selector.GetHandle ("insertRowsAtIndexes:withAnimation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIntercellSpacingX = "intercellSpacing";
		static readonly NativeHandle selIntercellSpacingXHandle = Selector.GetHandle ("intercellSpacing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilityFocusedX = "isAccessibilityFocused";
		static readonly NativeHandle selIsAccessibilityFocusedXHandle = Selector.GetHandle ("isAccessibilityFocused");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsColumnSelected_X = "isColumnSelected:";
		static readonly NativeHandle selIsColumnSelected_XHandle = Selector.GetHandle ("isColumnSelected:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsRowSelected_X = "isRowSelected:";
		static readonly NativeHandle selIsRowSelected_XHandle = Selector.GetHandle ("isRowSelected:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakeViewWithIdentifier_Owner_X = "makeViewWithIdentifier:owner:";
		static readonly NativeHandle selMakeViewWithIdentifier_Owner_XHandle = Selector.GetHandle ("makeViewWithIdentifier:owner:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveColumn_ToColumn_X = "moveColumn:toColumn:";
		static readonly NativeHandle selMoveColumn_ToColumn_XHandle = Selector.GetHandle ("moveColumn:toColumn:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveRowAtIndex_ToIndex_X = "moveRowAtIndex:toIndex:";
		static readonly NativeHandle selMoveRowAtIndex_ToIndex_XHandle = Selector.GetHandle ("moveRowAtIndex:toIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNamesOfPromisedFilesDroppedAtDestination_X = "namesOfPromisedFilesDroppedAtDestination:";
		static readonly NativeHandle selNamesOfPromisedFilesDroppedAtDestination_XHandle = Selector.GetHandle ("namesOfPromisedFilesDroppedAtDestination:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNoteHeightOfRowsWithIndexesChanged_X = "noteHeightOfRowsWithIndexesChanged:";
		static readonly NativeHandle selNoteHeightOfRowsWithIndexesChanged_XHandle = Selector.GetHandle ("noteHeightOfRowsWithIndexesChanged:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNoteNumberOfRowsChangedX = "noteNumberOfRowsChanged";
		static readonly NativeHandle selNoteNumberOfRowsChangedXHandle = Selector.GetHandle ("noteNumberOfRowsChanged");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfColumnsX = "numberOfColumns";
		static readonly NativeHandle selNumberOfColumnsXHandle = Selector.GetHandle ("numberOfColumns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfRowsX = "numberOfRows";
		static readonly NativeHandle selNumberOfRowsXHandle = Selector.GetHandle ("numberOfRows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfSelectedColumnsX = "numberOfSelectedColumns";
		static readonly NativeHandle selNumberOfSelectedColumnsXHandle = Selector.GetHandle ("numberOfSelectedColumns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfSelectedRowsX = "numberOfSelectedRows";
		static readonly NativeHandle selNumberOfSelectedRowsXHandle = Selector.GetHandle ("numberOfSelectedRows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformClickOnCellAtColumn_Row_X = "performClickOnCellAtColumn:row:";
		static readonly NativeHandle selPerformClickOnCellAtColumn_Row_XHandle = Selector.GetHandle ("performClickOnCellAtColumn:row:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreparedCellAtColumn_Row_X = "preparedCellAtColumn:row:";
		static readonly NativeHandle selPreparedCellAtColumn_Row_XHandle = Selector.GetHandle ("preparedCellAtColumn:row:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRectOfColumn_X = "rectOfColumn:";
		static readonly NativeHandle selRectOfColumn_XHandle = Selector.GetHandle ("rectOfColumn:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRectOfRow_X = "rectOfRow:";
		static readonly NativeHandle selRectOfRow_XHandle = Selector.GetHandle ("rectOfRow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterNib_ForIdentifier_X = "registerNib:forIdentifier:";
		static readonly NativeHandle selRegisterNib_ForIdentifier_XHandle = Selector.GetHandle ("registerNib:forIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisteredNibsByIdentifierX = "registeredNibsByIdentifier";
		static readonly NativeHandle selRegisteredNibsByIdentifierXHandle = Selector.GetHandle ("registeredNibsByIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadDataX = "reloadData";
		static readonly NativeHandle selReloadDataXHandle = Selector.GetHandle ("reloadData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadDataForRowIndexes_ColumnIndexes_X = "reloadDataForRowIndexes:columnIndexes:";
		static readonly NativeHandle selReloadDataForRowIndexes_ColumnIndexes_XHandle = Selector.GetHandle ("reloadDataForRowIndexes:columnIndexes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveRowsAtIndexes_WithAnimation_X = "removeRowsAtIndexes:withAnimation:";
		static readonly NativeHandle selRemoveRowsAtIndexes_WithAnimation_XHandle = Selector.GetHandle ("removeRowsAtIndexes:withAnimation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveTableColumn_X = "removeTableColumn:";
		static readonly NativeHandle selRemoveTableColumn_XHandle = Selector.GetHandle ("removeTableColumn:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowActionsVisibleX = "rowActionsVisible";
		static readonly NativeHandle selRowActionsVisibleXHandle = Selector.GetHandle ("rowActionsVisible");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowAtPoint_X = "rowAtPoint:";
		static readonly NativeHandle selRowAtPoint_XHandle = Selector.GetHandle ("rowAtPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowForView_X = "rowForView:";
		static readonly NativeHandle selRowForView_XHandle = Selector.GetHandle ("rowForView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowHeightX = "rowHeight";
		static readonly NativeHandle selRowHeightXHandle = Selector.GetHandle ("rowHeight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowSizeStyleX = "rowSizeStyle";
		static readonly NativeHandle selRowSizeStyleXHandle = Selector.GetHandle ("rowSizeStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowViewAtRow_MakeIfNecessary_X = "rowViewAtRow:makeIfNecessary:";
		static readonly NativeHandle selRowViewAtRow_MakeIfNecessary_XHandle = Selector.GetHandle ("rowViewAtRow:makeIfNecessary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowsInRect_X = "rowsInRect:";
		static readonly NativeHandle selRowsInRect_XHandle = Selector.GetHandle ("rowsInRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollColumnToVisible_X = "scrollColumnToVisible:";
		static readonly NativeHandle selScrollColumnToVisible_XHandle = Selector.GetHandle ("scrollColumnToVisible:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollRowToVisible_X = "scrollRowToVisible:";
		static readonly NativeHandle selScrollRowToVisible_XHandle = Selector.GetHandle ("scrollRowToVisible:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectAll_X = "selectAll:";
		static readonly NativeHandle selSelectAll_XHandle = Selector.GetHandle ("selectAll:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectColumnIndexes_ByExtendingSelection_X = "selectColumnIndexes:byExtendingSelection:";
		static readonly NativeHandle selSelectColumnIndexes_ByExtendingSelection_XHandle = Selector.GetHandle ("selectColumnIndexes:byExtendingSelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectRowIndexes_ByExtendingSelection_X = "selectRowIndexes:byExtendingSelection:";
		static readonly NativeHandle selSelectRowIndexes_ByExtendingSelection_XHandle = Selector.GetHandle ("selectRowIndexes:byExtendingSelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedColumnX = "selectedColumn";
		static readonly NativeHandle selSelectedColumnXHandle = Selector.GetHandle ("selectedColumn");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedColumnIndexesX = "selectedColumnIndexes";
		static readonly NativeHandle selSelectedColumnIndexesXHandle = Selector.GetHandle ("selectedColumnIndexes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedRowX = "selectedRow";
		static readonly NativeHandle selSelectedRowXHandle = Selector.GetHandle ("selectedRow");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedRowIndexesX = "selectedRowIndexes";
		static readonly NativeHandle selSelectedRowIndexesXHandle = Selector.GetHandle ("selectedRowIndexes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionHighlightStyleX = "selectionHighlightStyle";
		static readonly NativeHandle selSelectionHighlightStyleXHandle = Selector.GetHandle ("selectionHighlightStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilitySelectedRows_X = "setAccessibilitySelectedRows:";
		static readonly NativeHandle selSetAccessibilitySelectedRows_XHandle = Selector.GetHandle ("setAccessibilitySelectedRows:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsColumnReordering_X = "setAllowsColumnReordering:";
		static readonly NativeHandle selSetAllowsColumnReordering_XHandle = Selector.GetHandle ("setAllowsColumnReordering:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsColumnResizing_X = "setAllowsColumnResizing:";
		static readonly NativeHandle selSetAllowsColumnResizing_XHandle = Selector.GetHandle ("setAllowsColumnResizing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsColumnSelection_X = "setAllowsColumnSelection:";
		static readonly NativeHandle selSetAllowsColumnSelection_XHandle = Selector.GetHandle ("setAllowsColumnSelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsEmptySelection_X = "setAllowsEmptySelection:";
		static readonly NativeHandle selSetAllowsEmptySelection_XHandle = Selector.GetHandle ("setAllowsEmptySelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsMultipleSelection_X = "setAllowsMultipleSelection:";
		static readonly NativeHandle selSetAllowsMultipleSelection_XHandle = Selector.GetHandle ("setAllowsMultipleSelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsTypeSelect_X = "setAllowsTypeSelect:";
		static readonly NativeHandle selSetAllowsTypeSelect_XHandle = Selector.GetHandle ("setAllowsTypeSelect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutosaveName_X = "setAutosaveName:";
		static readonly NativeHandle selSetAutosaveName_XHandle = Selector.GetHandle ("setAutosaveName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutosaveTableColumns_X = "setAutosaveTableColumns:";
		static readonly NativeHandle selSetAutosaveTableColumns_XHandle = Selector.GetHandle ("setAutosaveTableColumns:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBackgroundColor_X = "setBackgroundColor:";
		static readonly NativeHandle selSetBackgroundColor_XHandle = Selector.GetHandle ("setBackgroundColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetColumnAutoresizingStyle_X = "setColumnAutoresizingStyle:";
		static readonly NativeHandle selSetColumnAutoresizingStyle_XHandle = Selector.GetHandle ("setColumnAutoresizingStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCornerView_X = "setCornerView:";
		static readonly NativeHandle selSetCornerView_XHandle = Selector.GetHandle ("setCornerView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDataSource_X = "setDataSource:";
		static readonly NativeHandle selSetDataSource_XHandle = Selector.GetHandle ("setDataSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDoubleAction_X = "setDoubleAction:";
		static readonly NativeHandle selSetDoubleAction_XHandle = Selector.GetHandle ("setDoubleAction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDraggingDestinationFeedbackStyle_X = "setDraggingDestinationFeedbackStyle:";
		static readonly NativeHandle selSetDraggingDestinationFeedbackStyle_XHandle = Selector.GetHandle ("setDraggingDestinationFeedbackStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDraggingSourceOperationMask_ForLocal_X = "setDraggingSourceOperationMask:forLocal:";
		static readonly NativeHandle selSetDraggingSourceOperationMask_ForLocal_XHandle = Selector.GetHandle ("setDraggingSourceOperationMask:forLocal:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDropRow_DropOperation_X = "setDropRow:dropOperation:";
		static readonly NativeHandle selSetDropRow_DropOperation_XHandle = Selector.GetHandle ("setDropRow:dropOperation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFloatsGroupRows_X = "setFloatsGroupRows:";
		static readonly NativeHandle selSetFloatsGroupRows_XHandle = Selector.GetHandle ("setFloatsGroupRows:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFocusedColumn_X = "setFocusedColumn:";
		static readonly NativeHandle selSetFocusedColumn_XHandle = Selector.GetHandle ("setFocusedColumn:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGridColor_X = "setGridColor:";
		static readonly NativeHandle selSetGridColor_XHandle = Selector.GetHandle ("setGridColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGridStyleMask_X = "setGridStyleMask:";
		static readonly NativeHandle selSetGridStyleMask_XHandle = Selector.GetHandle ("setGridStyleMask:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHeaderView_X = "setHeaderView:";
		static readonly NativeHandle selSetHeaderView_XHandle = Selector.GetHandle ("setHeaderView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHighlightedTableColumn_X = "setHighlightedTableColumn:";
		static readonly NativeHandle selSetHighlightedTableColumn_XHandle = Selector.GetHandle ("setHighlightedTableColumn:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIndicatorImage_InTableColumn_X = "setIndicatorImage:inTableColumn:";
		static readonly NativeHandle selSetIndicatorImage_InTableColumn_XHandle = Selector.GetHandle ("setIndicatorImage:inTableColumn:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIntercellSpacing_X = "setIntercellSpacing:";
		static readonly NativeHandle selSetIntercellSpacing_XHandle = Selector.GetHandle ("setIntercellSpacing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRowActionsVisible_X = "setRowActionsVisible:";
		static readonly NativeHandle selSetRowActionsVisible_XHandle = Selector.GetHandle ("setRowActionsVisible:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRowHeight_X = "setRowHeight:";
		static readonly NativeHandle selSetRowHeight_XHandle = Selector.GetHandle ("setRowHeight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRowSizeStyle_X = "setRowSizeStyle:";
		static readonly NativeHandle selSetRowSizeStyle_XHandle = Selector.GetHandle ("setRowSizeStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectionHighlightStyle_X = "setSelectionHighlightStyle:";
		static readonly NativeHandle selSetSelectionHighlightStyle_XHandle = Selector.GetHandle ("setSelectionHighlightStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSortDescriptors_X = "setSortDescriptors:";
		static readonly NativeHandle selSetSortDescriptors_XHandle = Selector.GetHandle ("setSortDescriptors:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStyle_X = "setStyle:";
		static readonly NativeHandle selSetStyle_XHandle = Selector.GetHandle ("setStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUserInterfaceLayoutDirection_X = "setUserInterfaceLayoutDirection:";
		static readonly NativeHandle selSetUserInterfaceLayoutDirection_XHandle = Selector.GetHandle ("setUserInterfaceLayoutDirection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesAlternatingRowBackgroundColors_X = "setUsesAlternatingRowBackgroundColors:";
		static readonly NativeHandle selSetUsesAlternatingRowBackgroundColors_XHandle = Selector.GetHandle ("setUsesAlternatingRowBackgroundColors:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesAutomaticRowHeights_X = "setUsesAutomaticRowHeights:";
		static readonly NativeHandle selSetUsesAutomaticRowHeights_XHandle = Selector.GetHandle ("setUsesAutomaticRowHeights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesStaticContents_X = "setUsesStaticContents:";
		static readonly NativeHandle selSetUsesStaticContents_XHandle = Selector.GetHandle ("setUsesStaticContents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVerticalMotionCanBeginDrag_X = "setVerticalMotionCanBeginDrag:";
		static readonly NativeHandle selSetVerticalMotionCanBeginDrag_XHandle = Selector.GetHandle ("setVerticalMotionCanBeginDrag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldFocusCell_AtColumn_Row_X = "shouldFocusCell:atColumn:row:";
		static readonly NativeHandle selShouldFocusCell_AtColumn_Row_XHandle = Selector.GetHandle ("shouldFocusCell:atColumn:row:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSizeLastColumnToFitX = "sizeLastColumnToFit";
		static readonly NativeHandle selSizeLastColumnToFitXHandle = Selector.GetHandle ("sizeLastColumnToFit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSizeToFitX = "sizeToFit";
		static readonly NativeHandle selSizeToFitXHandle = Selector.GetHandle ("sizeToFit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSortDescriptorsX = "sortDescriptors";
		static readonly NativeHandle selSortDescriptorsXHandle = Selector.GetHandle ("sortDescriptors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStyleX = "style";
		static readonly NativeHandle selStyleXHandle = Selector.GetHandle ("style");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTableColumnWithIdentifier_X = "tableColumnWithIdentifier:";
		static readonly NativeHandle selTableColumnWithIdentifier_XHandle = Selector.GetHandle ("tableColumnWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTableColumnsX = "tableColumns";
		static readonly NativeHandle selTableColumnsXHandle = Selector.GetHandle ("tableColumns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextDidBeginEditing_X = "textDidBeginEditing:";
		static readonly NativeHandle selTextDidBeginEditing_XHandle = Selector.GetHandle ("textDidBeginEditing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextDidChange_X = "textDidChange:";
		static readonly NativeHandle selTextDidChange_XHandle = Selector.GetHandle ("textDidChange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextDidEndEditing_X = "textDidEndEditing:";
		static readonly NativeHandle selTextDidEndEditing_XHandle = Selector.GetHandle ("textDidEndEditing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextShouldBeginEditing_X = "textShouldBeginEditing:";
		static readonly NativeHandle selTextShouldBeginEditing_XHandle = Selector.GetHandle ("textShouldBeginEditing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextShouldEndEditing_X = "textShouldEndEditing:";
		static readonly NativeHandle selTextShouldEndEditing_XHandle = Selector.GetHandle ("textShouldEndEditing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTileX = "tile";
		static readonly NativeHandle selTileXHandle = Selector.GetHandle ("tile");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnhideRowsAtIndexes_WithAnimation_X = "unhideRowsAtIndexes:withAnimation:";
		static readonly NativeHandle selUnhideRowsAtIndexes_WithAnimation_XHandle = Selector.GetHandle ("unhideRowsAtIndexes:withAnimation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserInterfaceLayoutDirectionX = "userInterfaceLayoutDirection";
		static readonly NativeHandle selUserInterfaceLayoutDirectionXHandle = Selector.GetHandle ("userInterfaceLayoutDirection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesAlternatingRowBackgroundColorsX = "usesAlternatingRowBackgroundColors";
		static readonly NativeHandle selUsesAlternatingRowBackgroundColorsXHandle = Selector.GetHandle ("usesAlternatingRowBackgroundColors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesAutomaticRowHeightsX = "usesAutomaticRowHeights";
		static readonly NativeHandle selUsesAutomaticRowHeightsXHandle = Selector.GetHandle ("usesAutomaticRowHeights");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesStaticContentsX = "usesStaticContents";
		static readonly NativeHandle selUsesStaticContentsXHandle = Selector.GetHandle ("usesStaticContents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateUserInterfaceItem_X = "validateUserInterfaceItem:";
		static readonly NativeHandle selValidateUserInterfaceItem_XHandle = Selector.GetHandle ("validateUserInterfaceItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVerticalMotionCanBeginDragX = "verticalMotionCanBeginDrag";
		static readonly NativeHandle selVerticalMotionCanBeginDragXHandle = Selector.GetHandle ("verticalMotionCanBeginDrag");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selViewAtColumn_Row_MakeIfNecessary_X = "viewAtColumn:row:makeIfNecessary:";
		static readonly NativeHandle selViewAtColumn_Row_MakeIfNecessary_XHandle = Selector.GetHandle ("viewAtColumn:row:makeIfNecessary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSTableView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSTableView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSTableView () : base (NSObjectFlag.Empty)
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
		public NSTableView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSTableView (NSObjectFlag t) : base (t)
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
		protected internal NSTableView (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTableView (CGRect frameRect)
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
		[Export ("addTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddColumn (NSTableColumn tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddTableColumn_XHandle, tableColumn__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddTableColumn_XHandle, tableColumn__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableColumn);
		}
		[Export ("beginUpdates")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginUpdates ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selBeginUpdatesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selBeginUpdatesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("canDragRowsWithIndexes:atPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanDragRows (NSIndexSet rowIndexes, CGPoint mouseDownPoint)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var rowIndexes__handle__ = rowIndexes!.GetNonNullHandle (nameof (rowIndexes));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_CGPoint (this.Handle, selCanDragRowsWithIndexes_AtPoint_XHandle, rowIndexes__handle__, mouseDownPoint);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_CGPoint (&__objc_super__, selCanDragRowsWithIndexes_AtPoint_XHandle, rowIndexes__handle__, mouseDownPoint);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (rowIndexes);
			return ret != 0;
		}
		[Export ("columnForView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ColumnForView (NSView view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selColumnForView_XHandle, view__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selColumnForView_XHandle, view__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			return ret!;
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
		[Export ("deselectColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeselectColumn (nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDeselectColumn_XHandle, column);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selDeselectColumn_XHandle, column);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("deselectRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeselectRow (nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDeselectRow_XHandle, row);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selDeselectRow_XHandle, row);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("dragImageForRowsWithIndexes:tableColumns:event:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSImage DragImageForRows (NSIndexSet dragRows, NSTableColumn[] tableColumns, NSEvent dragEvent, ref CGPoint dragImageOffset)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var dragRows__handle__ = dragRows!.GetNonNullHandle (nameof (dragRows));
			if (tableColumns is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tableColumns));
			var dragEvent__handle__ = dragEvent!.GetNonNullHandle (nameof (dragEvent));
			fixed (CGPoint* dragImageOffset__pointer = &dragImageOffset) {
			using var nsa_tableColumns = NSArray.FromNSObjects (tableColumns);
			NSImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_CGPoint (this.Handle, selDragImageForRowsWithIndexes_TableColumns_Event_Offset_XHandle, dragRows__handle__, nsa_tableColumns.Handle, dragEvent__handle__, dragImageOffset__pointer), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_CGPoint (&__objc_super__, selDragImageForRowsWithIndexes_TableColumns_Event_Offset_XHandle, dragRows__handle__, nsa_tableColumns.Handle, dragEvent__handle__, dragImageOffset__pointer), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dragRows);
			GC.KeepAlive (dragEvent);
			return ret!;
			}
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
		[Export ("drawBackgroundInClipRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawBackground (CGRect clipRect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selDrawBackgroundInClipRect_XHandle, clipRect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selDrawBackgroundInClipRect_XHandle, clipRect);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("drawGridInClipRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawGrid (CGRect clipRect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selDrawGridInClipRect_XHandle, clipRect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selDrawGridInClipRect_XHandle, clipRect);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("drawRow:clipRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawRow (nint row, CGRect clipRect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_CGRect (this.Handle, selDrawRow_ClipRect_XHandle, row, clipRect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_CGRect (&__objc_super__, selDrawRow_ClipRect_XHandle, row, clipRect);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("editColumn:row:withEvent:select:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditColumn (nint column, nint row, NSEvent? theEvent, bool select)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NativeHandle_bool (this.Handle, selEditColumn_Row_WithEvent_Select_XHandle, column, row, theEvent__handle__, select ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_NativeHandle_bool (&__objc_super__, selEditColumn_Row_WithEvent_Select_XHandle, column, row, theEvent__handle__, select ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (theEvent);
		}
		[Export ("endUpdates")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndUpdates ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selEndUpdatesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selEndUpdatesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("enumerateAvailableRowViewsUsingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateAvailableRowViews ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTableViewRowHandler))]NSTableViewRowHandler callback)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (callback is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (callback));
			using var block_callback = Trampolines.SDNSTableViewRowHandler.CreateBlock (callback);
			BlockLiteral *block_ptr_callback = &block_callback;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEnumerateAvailableRowViewsUsingBlock_XHandle, (IntPtr) block_ptr_callback);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEnumerateAvailableRowViewsUsingBlock_XHandle, (IntPtr) block_ptr_callback);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("columnWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint FindColumn (NSString identifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selColumnWithIdentifier_XHandle, identifier__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selColumnWithIdentifier_XHandle, identifier__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (identifier);
			return ret!;
		}
		[Export ("tableColumnWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableColumn FindTableColumn (NSString identifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			NSTableColumn? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTableColumn> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selTableColumnWithIdentifier_XHandle, identifier__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTableColumn> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selTableColumnWithIdentifier_XHandle, identifier__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (identifier);
			return ret!;
		}
		[Export ("preparedCellAtColumn:row:")]
		[ObsoletedOSPlatform ("macos10.10", "Use View Based TableView and GetView.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCell GetCell (nint column, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSCell ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr (this.Handle, selPreparedCellAtColumn_Row_XHandle, column, row), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selPreparedCellAtColumn_Row_XHandle, column, row), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("frameOfCellAtColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetCellFrame (nint column, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_IntPtr_IntPtr (this.Handle, selFrameOfCellAtColumn_Row_XHandle, column, row);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_IntPtr_IntPtr (this.Handle, selFrameOfCellAtColumn_Row_XHandle, column, row);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selFrameOfCellAtColumn_Row_XHandle, column, row);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_IntPtr (&__objc_super__, selFrameOfCellAtColumn_Row_XHandle, column, row);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("columnAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetColumn (CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGPoint (this.Handle, selColumnAtPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGPoint (&__objc_super__, selColumnAtPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("columnIndexesInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexSet GetColumnIndexesInRect (CGRect rect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSIndexSet ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selColumnIndexesInRect_XHandle, rect), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selColumnIndexesInRect_XHandle, rect), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("indicatorImageInTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSImage GetIndicatorImage (NSTableColumn tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			NSImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selIndicatorImageInTableColumn_XHandle, tableColumn__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selIndicatorImageInTableColumn_XHandle, tableColumn__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableColumn);
			return ret!;
		}
		[Export ("rowAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetRow (CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGPoint (this.Handle, selRowAtPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGPoint (&__objc_super__, selRowAtPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("rowViewAtRow:makeIfNecessary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableRowView GetRowView (nint row, bool makeIfNecessary)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTableRowView ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTableRowView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_bool (this.Handle, selRowViewAtRow_MakeIfNecessary_XHandle, row, makeIfNecessary ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTableRowView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_bool (&__objc_super__, selRowViewAtRow_MakeIfNecessary_XHandle, row, makeIfNecessary ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("viewAtColumn:row:makeIfNecessary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView GetView (nint column, nint row, bool makeIfNecessary)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSView ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, selViewAtColumn_Row_MakeIfNecessary_XHandle, column, row, makeIfNecessary ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_IntPtr_bool (&__objc_super__, selViewAtColumn_Row_MakeIfNecessary_XHandle, column, row, makeIfNecessary ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("hideRowsAtIndexes:withAnimation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HideRows (NSIndexSet indexes, NSTableViewAnimation rowAnimation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selHideRowsAtIndexes_WithAnimation_XHandle, indexes__handle__, (UIntPtr) (ulong) rowAnimation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selHideRowsAtIndexes_WithAnimation_XHandle, indexes__handle__, (UIntPtr) (ulong) rowAnimation);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
		}
		[Export ("highlightSelectionInClipRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HighlightSelection (CGRect clipRect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selHighlightSelectionInClipRect_XHandle, clipRect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selHighlightSelectionInClipRect_XHandle, clipRect);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("insertRowsAtIndexes:withAnimation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertRows (NSIndexSet indexes, NSTableViewAnimation animationOptions)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selInsertRowsAtIndexes_WithAnimation_XHandle, indexes__handle__, (UIntPtr) (ulong) animationOptions);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selInsertRowsAtIndexes_WithAnimation_XHandle, indexes__handle__, (UIntPtr) (ulong) animationOptions);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
		}
		[Export ("isColumnSelected:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsColumnSelected (nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsColumnSelected_XHandle, column);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selIsColumnSelected_XHandle, column);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("isRowSelected:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsRowSelected (nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsRowSelected_XHandle, row);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selIsRowSelected_XHandle, row);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("makeViewWithIdentifier:owner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView MakeView (string? identifier, NSObject? owner)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var owner__handle__ = owner.GetHandle ();
			var nsidentifier = CFString.CreateNative (identifier);
			NSView? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selMakeViewWithIdentifier_Owner_XHandle, nsidentifier, owner__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selMakeViewWithIdentifier_Owner_XHandle, nsidentifier, owner__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (owner);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("moveColumn:toColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveColumn (nint oldIndex, nint newIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selMoveColumn_ToColumn_XHandle, oldIndex, newIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selMoveColumn_ToColumn_XHandle, oldIndex, newIndex);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("moveRowAtIndex:toIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveRow (nint oldIndex, nint newIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selMoveRowAtIndex_ToIndex_XHandle, oldIndex, newIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selMoveRowAtIndex_ToIndex_XHandle, oldIndex, newIndex);
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
		[Export ("noteHeightOfRowsWithIndexesChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NoteHeightOfRowsWithIndexesChanged (NSIndexSet indexSet)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexSet__handle__ = indexSet!.GetNonNullHandle (nameof (indexSet));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selNoteHeightOfRowsWithIndexesChanged_XHandle, indexSet__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selNoteHeightOfRowsWithIndexesChanged_XHandle, indexSet__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexSet);
		}
		[Export ("noteNumberOfRowsChanged")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NoteNumberOfRowsChanged ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selNoteNumberOfRowsChangedXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selNoteNumberOfRowsChangedXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("performClickOnCellAtColumn:row:")]
		[ObsoletedOSPlatform ("macos10.10", "Use a View Based TableView; directly interact with a particular view as required and call PerformClick on it, if necessary.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformClick (nint column, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selPerformClickOnCellAtColumn_Row_XHandle, column, row);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selPerformClickOnCellAtColumn_Row_XHandle, column, row);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("rectOfColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect RectForColumn (nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_IntPtr (this.Handle, selRectOfColumn_XHandle, column);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_IntPtr (this.Handle, selRectOfColumn_XHandle, column);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_IntPtr (&__objc_super__, selRectOfColumn_XHandle, column);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_IntPtr (&__objc_super__, selRectOfColumn_XHandle, column);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("rectOfRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect RectForRow (nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_IntPtr (this.Handle, selRectOfRow_XHandle, row);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_IntPtr (this.Handle, selRectOfRow_XHandle, row);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_IntPtr (&__objc_super__, selRectOfRow_XHandle, row);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_IntPtr (&__objc_super__, selRectOfRow_XHandle, row);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("registerNib:forIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisterNib (NSNib? nib, string identifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nib__handle__ = nib.GetHandle ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRegisterNib_ForIdentifier_XHandle, nib__handle__, nsidentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRegisterNib_ForIdentifier_XHandle, nib__handle__, nsidentifier);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (nib);
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
		[Export ("reloadDataForRowIndexes:columnIndexes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadData (NSIndexSet rowIndexes, NSIndexSet columnIndexes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var rowIndexes__handle__ = rowIndexes!.GetNonNullHandle (nameof (rowIndexes));
			var columnIndexes__handle__ = columnIndexes!.GetNonNullHandle (nameof (columnIndexes));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selReloadDataForRowIndexes_ColumnIndexes_XHandle, rowIndexes__handle__, columnIndexes__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selReloadDataForRowIndexes_ColumnIndexes_XHandle, rowIndexes__handle__, columnIndexes__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (rowIndexes);
			GC.KeepAlive (columnIndexes);
		}
		[Export ("removeTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveColumn (NSTableColumn tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveTableColumn_XHandle, tableColumn__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveTableColumn_XHandle, tableColumn__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableColumn);
		}
		[Export ("removeRowsAtIndexes:withAnimation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveRows (NSIndexSet indexes, NSTableViewAnimation animationOptions)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selRemoveRowsAtIndexes_WithAnimation_XHandle, indexes__handle__, (UIntPtr) (ulong) animationOptions);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selRemoveRowsAtIndexes_WithAnimation_XHandle, indexes__handle__, (UIntPtr) (ulong) animationOptions);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
		}
		[Export ("rowForView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RowForView (NSView view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selRowForView_XHandle, view__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selRowForView_XHandle, view__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			return ret!;
		}
		[Export ("didAddRowView:forRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RowViewAdded (NSTableRowView rowView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var rowView__handle__ = rowView!.GetNonNullHandle (nameof (rowView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selDidAddRowView_ForRow_XHandle, rowView__handle__, row);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selDidAddRowView_ForRow_XHandle, rowView__handle__, row);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (rowView);
		}
		[Export ("didRemoveRowView:forRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RowViewRemoved (NSTableRowView rowView, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var rowView__handle__ = rowView!.GetNonNullHandle (nameof (rowView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selDidRemoveRowView_ForRow_XHandle, rowView__handle__, row);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selDidRemoveRowView_ForRow_XHandle, rowView__handle__, row);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (rowView);
		}
		[Export ("rowsInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange RowsInRect (CGRect rect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_CGRect (this.Handle, selRowsInRect_XHandle, rect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_CGRect (&__objc_super__, selRowsInRect_XHandle, rect);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("scrollColumnToVisible:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollColumnToVisible (nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollColumnToVisible_XHandle, column);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selScrollColumnToVisible_XHandle, column);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("scrollRowToVisible:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollRowToVisible (nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollRowToVisible_XHandle, row);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selScrollRowToVisible_XHandle, row);
					GC.KeepAlive (this);
				}
			}
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
		[Export ("selectColumnIndexes:byExtendingSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectColumns (NSIndexSet indexes, bool byExtendingSelection)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selSelectColumnIndexes_ByExtendingSelection_XHandle, indexes__handle__, byExtendingSelection ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selSelectColumnIndexes_ByExtendingSelection_XHandle, indexes__handle__, byExtendingSelection ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
		}
		[Export ("selectRowIndexes:byExtendingSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectRows (NSIndexSet indexes, bool byExtendingSelection)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selSelectRowIndexes_ByExtendingSelection_XHandle, indexes__handle__, byExtendingSelection ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selSelectRowIndexes_ByExtendingSelection_XHandle, indexes__handle__, byExtendingSelection ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
		}
		[Export ("setDraggingSourceOperationMask:forLocal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDraggingSourceOperationMask (NSDragOperation mask, bool isLocal)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_bool (this.Handle, selSetDraggingSourceOperationMask_ForLocal_XHandle, (UIntPtr) (ulong) mask, isLocal ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_bool (&__objc_super__, selSetDraggingSourceOperationMask_ForLocal_XHandle, (UIntPtr) (ulong) mask, isLocal ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setDropRow:dropOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDropRowDropOperation (nint row, NSTableViewDropOperation dropOperation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, selSetDropRow_DropOperation_XHandle, row, (UIntPtr) (ulong) dropOperation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr (&__objc_super__, selSetDropRow_DropOperation_XHandle, row, (UIntPtr) (ulong) dropOperation);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setIndicatorImage:inTableColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetIndicatorImage (NSImage? anImage, NSTableColumn tableColumn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var anImage__handle__ = anImage.GetHandle ();
			var tableColumn__handle__ = tableColumn!.GetNonNullHandle (nameof (tableColumn));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetIndicatorImage_InTableColumn_XHandle, anImage__handle__, tableColumn__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetIndicatorImage_InTableColumn_XHandle, anImage__handle__, tableColumn__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anImage);
			GC.KeepAlive (tableColumn);
		}
		[Export ("shouldFocusCell:atColumn:row:")]
		[ObsoletedOSPlatform ("macos10.10", "Use a View Based TableView; observe the window’s firstResponder for focus change notifications.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldFocusCell (NSCell cell, nint column, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr_IntPtr (this.Handle, selShouldFocusCell_AtColumn_Row_XHandle, cell__handle__, column, row);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_IntPtr_IntPtr (&__objc_super__, selShouldFocusCell_AtColumn_Row_XHandle, cell__handle__, column, row);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cell);
			return ret != 0;
		}
		[Export ("sizeLastColumnToFit")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SizeLastColumnToFit ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSizeLastColumnToFitXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSizeLastColumnToFitXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("sizeToFit")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SizeToFit ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSizeToFitXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSizeToFitXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("tableColumns")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableColumn[] TableColumns ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTableColumn[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSTableColumn>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTableColumnsXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSTableColumn>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTableColumnsXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("textDidBeginEditing:")]
		[ObsoletedOSPlatform ("macos10.10", "Use a View Based TableView with an NSTextField.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TextDidBeginEditing (NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTextDidBeginEditing_XHandle, notification__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTextDidBeginEditing_XHandle, notification__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (notification);
		}
		[Export ("textDidChange:")]
		[ObsoletedOSPlatform ("macos10.10", "Use a View Based TableView with an NSTextField.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TextDidChange (NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTextDidChange_XHandle, notification__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTextDidChange_XHandle, notification__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (notification);
		}
		[Export ("textDidEndEditing:")]
		[ObsoletedOSPlatform ("macos10.10", "Use a View Based TableView with an NSTextField.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TextDidEndEditing (NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTextDidEndEditing_XHandle, notification__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTextDidEndEditing_XHandle, notification__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (notification);
		}
		[Export ("textShouldBeginEditing:")]
		[ObsoletedOSPlatform ("macos10.10", "Use a View Based TableView with an NSTextField.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TextShouldBeginEditing (NSText textObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textObject__handle__ = textObject!.GetNonNullHandle (nameof (textObject));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selTextShouldBeginEditing_XHandle, textObject__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selTextShouldBeginEditing_XHandle, textObject__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textObject);
			return ret != 0;
		}
		[Export ("textShouldEndEditing:")]
		[ObsoletedOSPlatform ("macos10.10", "Use a View Based TableView with an NSTextField.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TextShouldEndEditing (NSText textObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textObject__handle__ = textObject!.GetNonNullHandle (nameof (textObject));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selTextShouldEndEditing_XHandle, textObject__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selTextShouldEndEditing_XHandle, textObject__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textObject);
			return ret != 0;
		}
		[Export ("tile")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Tile ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selTileXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selTileXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("unhideRowsAtIndexes:withAnimation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnhideRows (NSIndexSet indexes, NSTableViewAnimation rowAnimation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selUnhideRowsAtIndexes_WithAnimation_XHandle, indexes__handle__, (UIntPtr) (ulong) rowAnimation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selUnhideRowsAtIndexes_WithAnimation_XHandle, indexes__handle__, (UIntPtr) (ulong) rowAnimation);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
		}
		/// <param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("validateUserInterfaceItem:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ValidateUserInterfaceItem (INSValidatedUserInterfaceItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selValidateUserInterfaceItem_XHandle, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selValidateUserInterfaceItem_XHandle, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[] AccessibilityColumnHeaderUIElements {
			[Export ("accessibilityColumnHeaderUIElements")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityColumnHeaderUIElementsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityColumnHeaderUIElementsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[] AccessibilityColumns {
			[Export ("accessibilityColumns")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityColumnsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityColumnsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityFocused {
			[Export ("isAccessibilityFocused")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAccessibilityFocusedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAccessibilityFocusedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual CGRect AccessibilityFrame {
			[Export ("accessibilityFrame")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selAccessibilityFrameXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selAccessibilityFrameXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selAccessibilityFrameXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selAccessibilityFrameXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.14", "Use 'AccessibilityHeader' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string AccessibilityHeaderGroup {
			[Export ("accessibilityHeaderGroup")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'AccessibilityHeader' instead.")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityHeaderGroupXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityHeaderGroupXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string AccessibilityIdentifier {
			[Export ("accessibilityIdentifier")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string? AccessibilityLabel {
			[Export ("accessibilityLabel")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityLabelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityLabelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityParent {
			[Export ("accessibilityParent")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityParentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityParentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[] AccessibilityRowHeaderUIElements {
			[Export ("accessibilityRowHeaderUIElements")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityRowHeaderUIElementsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityRowHeaderUIElementsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual INSAccessibilityRow[]? AccessibilityRows {
			[Export ("accessibilityRows")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				INSAccessibilityRow[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<INSAccessibilityRow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityRowsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<INSAccessibilityRow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityRowsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[] AccessibilitySelectedCells {
			[Export ("accessibilitySelectedCells")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilitySelectedCellsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilitySelectedCellsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[] AccessibilitySelectedColumns {
			[Export ("accessibilitySelectedColumns")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilitySelectedColumnsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilitySelectedColumnsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual INSAccessibilityRow[]? AccessibilitySelectedRows {
			[Export ("accessibilitySelectedRows")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				INSAccessibilityRow[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<INSAccessibilityRow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilitySelectedRowsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<INSAccessibilityRow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilitySelectedRowsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilitySelectedRows:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilitySelectedRows_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilitySelectedRows_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[] AccessibilityVisibleCells {
			[Export ("accessibilityVisibleCells")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityVisibleCellsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityVisibleCellsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[] AccessibilityVisibleColumns {
			[Export ("accessibilityVisibleColumns")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityVisibleColumnsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityVisibleColumnsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual INSAccessibilityRow[] AccessibilityVisibleRows {
			[Export ("accessibilityVisibleRows")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				INSAccessibilityRow[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<INSAccessibilityRow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityVisibleRowsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<INSAccessibilityRow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityVisibleRowsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsColumnReordering {
			[Export ("allowsColumnReordering")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsColumnReorderingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsColumnReorderingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsColumnReordering:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsColumnReordering_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsColumnReordering_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsColumnResizing {
			[Export ("allowsColumnResizing")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsColumnResizingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsColumnResizingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsColumnResizing:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsColumnResizing_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsColumnResizing_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsColumnSelection {
			[Export ("allowsColumnSelection")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsColumnSelectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsColumnSelectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsColumnSelection:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsColumnSelection_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsColumnSelection_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
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
		public virtual bool AllowsTypeSelect {
			[Export ("allowsTypeSelect")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsTypeSelectXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsTypeSelectXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsTypeSelect:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsTypeSelect_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsTypeSelect_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AutosaveName {
			[Export ("autosaveName")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAutosaveNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAutosaveNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAutosaveName:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAutosaveName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAutosaveName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutosaveTableColumns {
			[Export ("autosaveTableColumns")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAutosaveTableColumnsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAutosaveTableColumnsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutosaveTableColumns:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutosaveTableColumns_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutosaveTableColumns_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColor BackgroundColor {
			[Export ("backgroundColor", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBackgroundColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBackgroundColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBackgroundColor:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetBackgroundColor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetBackgroundColor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ClickedColumn {
			[Export ("clickedColumn")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selClickedColumnXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selClickedColumnXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ClickedRow {
			[Export ("clickedRow")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selClickedRowXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selClickedRowXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableViewColumnAutoresizingStyle ColumnAutoresizingStyle {
			[Export ("columnAutoresizingStyle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTableViewColumnAutoresizingStyle ret;
				if (IsDirectBinding) {
					ret = (NSTableViewColumnAutoresizingStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selColumnAutoresizingStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSTableViewColumnAutoresizingStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selColumnAutoresizingStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setColumnAutoresizingStyle:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetColumnAutoresizingStyle_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetColumnAutoresizingStyle_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ColumnCount {
			[Export ("numberOfColumns")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfColumnsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfColumnsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView CornerView {
			[Export ("cornerView", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCornerViewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCornerViewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCornerView:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCornerView_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCornerView_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSTableViewDataSource? DataSource {
			get {
				return (WeakDataSource as INSTableViewDataSource)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDataSource = rvalue;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSTableViewDelegate? Delegate {
			get {
				return (WeakDelegate as INSTableViewDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Selector? DoubleAction {
			[Export ("doubleAction")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				Selector ret;
				if (IsDirectBinding) {
					ret = Selector.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDoubleActionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Selector.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDoubleActionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDoubleAction:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDoubleAction_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDoubleAction_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableViewDraggingDestinationFeedbackStyle DraggingDestinationFeedbackStyle {
			[Export ("draggingDestinationFeedbackStyle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTableViewDraggingDestinationFeedbackStyle ret;
				if (IsDirectBinding) {
					ret = (NSTableViewDraggingDestinationFeedbackStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDraggingDestinationFeedbackStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSTableViewDraggingDestinationFeedbackStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selDraggingDestinationFeedbackStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDraggingDestinationFeedbackStyle:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDraggingDestinationFeedbackStyle_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetDraggingDestinationFeedbackStyle_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint EditedColumn {
			[Export ("editedColumn")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEditedColumnXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selEditedColumnXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint EditedRow {
			[Export ("editedRow")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEditedRowXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selEditedRowXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableViewRowSizeStyle EffectiveRowSizeStyle {
			[Export ("effectiveRowSizeStyle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTableViewRowSizeStyle ret;
				if (IsDirectBinding) {
					ret = (NSTableViewRowSizeStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEffectiveRowSizeStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSTableViewRowSizeStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selEffectiveRowSizeStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableViewStyle EffectiveStyle {
			[Export ("effectiveStyle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTableViewStyle ret;
				if (IsDirectBinding) {
					ret = (NSTableViewStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEffectiveStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSTableViewStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selEffectiveStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool FloatsGroupRows {
			[Export ("floatsGroupRows")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selFloatsGroupRowsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selFloatsGroupRowsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setFloatsGroupRows:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetFloatsGroupRows_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetFloatsGroupRows_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.10", "Use a View Based TableView; observe the window’s firstResponder.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual nint FocusedColumn {
			[Export ("focusedColumn")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFocusedColumnXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selFocusedColumnXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFocusedColumn:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFocusedColumn_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetFocusedColumn_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColor GridColor {
			[Export ("gridColor", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGridColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGridColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setGridColor:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetGridColor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetGridColor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableViewGridStyle GridStyleMask {
			[Export ("gridStyleMask")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTableViewGridStyle ret;
				if (IsDirectBinding) {
					ret = (NSTableViewGridStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selGridStyleMaskXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSTableViewGridStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selGridStyleMaskXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setGridStyleMask:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetGridStyleMask_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetGridStyleMask_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableHeaderView? HeaderView {
			[Export ("headerView", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTableHeaderView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTableHeaderView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHeaderViewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTableHeaderView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHeaderViewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setHeaderView:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetHeaderView_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetHeaderView_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexSet HiddenRowIndexes {
			[Export ("hiddenRowIndexes", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSIndexSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHiddenRowIndexesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHiddenRowIndexesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableColumn HighlightedTableColumn {
			[Export ("highlightedTableColumn")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTableColumn? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTableColumn> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHighlightedTableColumnXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTableColumn> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHighlightedTableColumnXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setHighlightedTableColumn:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetHighlightedTableColumn_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetHighlightedTableColumn_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
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
		public virtual CGSize IntercellSpacing {
			[Export ("intercellSpacing")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selIntercellSpacingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selIntercellSpacingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setIntercellSpacing:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, selSetIntercellSpacing_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, selSetIntercellSpacing_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary RegisteredNibsByIdentifier {
			[Export ("registeredNibsByIdentifier", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRegisteredNibsByIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRegisteredNibsByIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RowActionsVisible {
			[Export ("rowActionsVisible")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRowActionsVisibleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selRowActionsVisibleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setRowActionsVisible:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRowActionsVisible_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetRowActionsVisible_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RowCount {
			[Export ("numberOfRows")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfRowsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfRowsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RowHeight {
			[Export ("rowHeight")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selRowHeightXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selRowHeightXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRowHeight:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetRowHeight_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetRowHeight_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableViewRowSizeStyle RowSizeStyle {
			[Export ("rowSizeStyle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTableViewRowSizeStyle ret;
				if (IsDirectBinding) {
					ret = (NSTableViewRowSizeStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRowSizeStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSTableViewRowSizeStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selRowSizeStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setRowSizeStyle:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRowSizeStyle_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetRowSizeStyle_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SelectedColumn {
			[Export ("selectedColumn")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedColumnXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selSelectedColumnXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexSet SelectedColumns {
			[Export ("selectedColumnIndexes")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSIndexSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectedColumnIndexesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectedColumnIndexesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SelectedColumnsCount {
			[Export ("numberOfSelectedColumns")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfSelectedColumnsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfSelectedColumnsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SelectedRow {
			[Export ("selectedRow")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedRowXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selSelectedRowXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SelectedRowCount {
			[Export ("numberOfSelectedRows")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfSelectedRowsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfSelectedRowsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexSet SelectedRows {
			[Export ("selectedRowIndexes")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSIndexSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectedRowIndexesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectedRowIndexesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableViewSelectionHighlightStyle SelectionHighlightStyle {
			[Export ("selectionHighlightStyle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTableViewSelectionHighlightStyle ret;
				if (IsDirectBinding) {
					ret = (NSTableViewSelectionHighlightStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectionHighlightStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSTableViewSelectionHighlightStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selSelectionHighlightStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSelectionHighlightStyle:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSelectionHighlightStyle_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetSelectionHighlightStyle_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSortDescriptor[] SortDescriptors {
			[Export ("sortDescriptors", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSSortDescriptor[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSSortDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSortDescriptorsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSSortDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSortDescriptorsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSortDescriptors:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSortDescriptors_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSortDescriptors_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTableViewStyle Style {
			[Export ("style", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTableViewStyle ret;
				if (IsDirectBinding) {
					ret = (NSTableViewStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSTableViewStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setStyle:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetStyle_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetStyle_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUserInterfaceLayoutDirection UserInterfaceLayoutDirection {
			[Export ("userInterfaceLayoutDirection")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSUserInterfaceLayoutDirection ret;
				if (IsDirectBinding) {
					ret = (NSUserInterfaceLayoutDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserInterfaceLayoutDirectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSUserInterfaceLayoutDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selUserInterfaceLayoutDirectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setUserInterfaceLayoutDirection:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserInterfaceLayoutDirection_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetUserInterfaceLayoutDirection_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesAlternatingRowBackgroundColors {
			[Export ("usesAlternatingRowBackgroundColors")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesAlternatingRowBackgroundColorsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesAlternatingRowBackgroundColorsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesAlternatingRowBackgroundColors:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesAlternatingRowBackgroundColors_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesAlternatingRowBackgroundColors_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesAutomaticRowHeights {
			[Export ("usesAutomaticRowHeights")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesAutomaticRowHeightsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesAutomaticRowHeightsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesAutomaticRowHeights:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesAutomaticRowHeights_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesAutomaticRowHeights_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesStaticContents {
			[Export ("usesStaticContents")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesStaticContentsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesStaticContentsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesStaticContents:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesStaticContents_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesStaticContents_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool VerticalMotionCanBeginDrag {
			[Export ("verticalMotionCanBeginDrag")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selVerticalMotionCanBeginDragXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selVerticalMotionCanBeginDragXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setVerticalMotionCanBeginDrag:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetVerticalMotionCanBeginDrag_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetVerticalMotionCanBeginDrag_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDataSource_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDataSource {
			[Export ("dataSource", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDataSourceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDataSourceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDataSource_var = ret;
				return ret!;
			}
			[Export ("setDataSource:", ArgumentSemantic.Assign)]
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
				__mt_WeakDataSource_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
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
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
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
		static NSString? _ColumnDidMoveNotification;
		/// <summary>Notification constant for ColumnDidMove</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveColumnDidMove(NSObject,EventHandler{NSViewColumnMoveEventArgs})" />
		///     or <see cref="Notifications.ObserveColumnDidMove(EventHandler{NSViewColumnMoveEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSTableView.Notifications.ObserveColumnDidMove ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSTableView.NSViewColumnMoveEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSTableView.Notifications.ObserveColumnDidMove (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSTableView.ColumnDidMoveNotification, (notification) => { Console.WriteLine ("Received the notification ColumnDidMove", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ColumnDidMove", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSTableView.ColumnDidMoveNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSTableViewColumnDidMoveNotification",  "AppKit")]
		[Advice ("Use NSTableView.Notifications.ObserveColumnDidMove helper method instead.")]
		public static NSString ColumnDidMoveNotification {
			get {
				if (_ColumnDidMoveNotification is null)
					_ColumnDidMoveNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTableViewColumnDidMoveNotification")!;
				return _ColumnDidMoveNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColumnDidResizeNotification;
		/// <summary>Notification constant for ColumnDidResize</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveColumnDidResize(NSObject,EventHandler{NSViewColumnResizeEventArgs})" />
		///     or <see cref="Notifications.ObserveColumnDidResize(EventHandler{NSViewColumnResizeEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSTableView.Notifications.ObserveColumnDidResize ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSTableView.NSViewColumnResizeEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSTableView.Notifications.ObserveColumnDidResize (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSTableView.ColumnDidResizeNotification, (notification) => { Console.WriteLine ("Received the notification ColumnDidResize", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ColumnDidResize", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSTableView.ColumnDidResizeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSTableViewColumnDidResizeNotification",  "AppKit")]
		[Advice ("Use NSTableView.Notifications.ObserveColumnDidResize helper method instead.")]
		public static NSString ColumnDidResizeNotification {
			get {
				if (_ColumnDidResizeNotification is null)
					_ColumnDidResizeNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTableViewColumnDidResizeNotification")!;
				return _ColumnDidResizeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RowViewKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTableViewRowViewKey",  "AppKit")]
		public static NSString RowViewKey {
			get {
				if (_RowViewKey is null)
					_RowViewKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTableViewRowViewKey")!;
				return _RowViewKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectionDidChangeNotification;
		/// <summary>Notification constant for SelectionDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveSelectionDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveSelectionDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSTableView.Notifications.ObserveSelectionDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSTableView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSTableView.Notifications.ObserveSelectionDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSTableView.SelectionDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification SelectionDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification SelectionDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSTableView.SelectionDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSTableViewSelectionDidChangeNotification",  "AppKit")]
		[Advice ("Use NSTableView.Notifications.ObserveSelectionDidChange helper method instead.")]
		public static NSString SelectionDidChangeNotification {
			get {
				if (_SelectionDidChangeNotification is null)
					_SelectionDidChangeNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTableViewSelectionDidChangeNotification")!;
				return _SelectionDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectionIsChangingNotification;
		/// <summary>Notification constant for SelectionIsChanging</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveSelectionIsChanging(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveSelectionIsChanging(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSTableView.Notifications.ObserveSelectionIsChanging ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSTableView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSTableView.Notifications.ObserveSelectionIsChanging (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSTableView.SelectionIsChangingNotification, (notification) => { Console.WriteLine ("Received the notification SelectionIsChanging", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification SelectionIsChanging", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSTableView.SelectionIsChangingNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSTableViewSelectionIsChangingNotification",  "AppKit")]
		[Advice ("Use NSTableView.Notifications.ObserveSelectionIsChanging helper method instead.")]
		public static NSString SelectionIsChangingNotification {
			get {
				if (_SelectionIsChangingNotification is null)
					_SelectionIsChangingNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTableViewSelectionIsChangingNotification")!;
				return _SelectionIsChangingNotification;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_NSTableViewDelegate); }
		}
		internal virtual _NSTableViewDelegate CreateInternalEventDelegateType ()
		{
			return (_NSTableViewDelegate)(new _NSTableViewDelegate());
		}
		internal _NSTableViewDelegate EnsureNSTableViewDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _NSTableViewDelegate;
			if (del is null){
				del = (_NSTableViewDelegate)CreateInternalEventDelegateType ();
				Delegate = (INSTableViewDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _NSTableViewDelegate : NSObject, INSTableViewDelegate { 
			public _NSTableViewDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_NSTableViewDelegate))]
			static _NSTableViewDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler? columnDidMove;
			[Export ("tableViewColumnDidMove:")]
			public void ColumnDidMove (NSNotification notification)
			{
				var handler = columnDidMove;
				if (handler is not null){
					handler (notification, EventArgs.Empty);
				}
			}
			internal EventHandler? columnDidResize;
			[Export ("tableViewColumnDidResize:")]
			public void ColumnDidResize (NSNotification notification)
			{
				var handler = columnDidResize;
				if (handler is not null){
					handler (notification, EventArgs.Empty);
				}
			}
			internal NSTableViewRowGetter? coreGetRowView;
			[Export ("tableView:rowViewForRow:")]
			public NSTableRowView CoreGetRowView (NSTableView tableView, IntPtr row)
			{
				var handler = coreGetRowView;
				if (handler is not null)
					return handler (tableView, row);
				return null!;
			}
			internal EventHandler<NSTableViewRowEventArgs>? didAddRowView;
			[Export ("tableView:didAddRowView:forRow:")]
			public void DidAddRowView (NSTableView tableView, NSTableRowView rowView, IntPtr row)
			{
				var handler = didAddRowView;
				if (handler is not null){
					var args = new NSTableViewRowEventArgs (rowView, row);
					handler (tableView, args);
				}
			}
			internal EventHandler<NSTableViewTableEventArgs>? didClickTableColumn;
			[Export ("tableView:didClickTableColumn:")]
			public void DidClickTableColumn (NSTableView tableView, NSTableColumn tableColumn)
			{
				var handler = didClickTableColumn;
				if (handler is not null){
					var args = new NSTableViewTableEventArgs (tableColumn);
					handler (tableView, args);
				}
			}
			internal EventHandler<NSTableViewTableEventArgs>? didDragTableColumn;
			[Export ("tableView:didDragTableColumn:")]
			public void DidDragTableColumn (NSTableView tableView, NSTableColumn tableColumn)
			{
				var handler = didDragTableColumn;
				if (handler is not null){
					var args = new NSTableViewTableEventArgs (tableColumn);
					handler (tableView, args);
				}
			}
			internal EventHandler<NSTableViewRowEventArgs>? didRemoveRowView;
			[Export ("tableView:didRemoveRowView:forRow:")]
			public void DidRemoveRowView (NSTableView tableView, NSTableRowView rowView, IntPtr row)
			{
				var handler = didRemoveRowView;
				if (handler is not null){
					var args = new NSTableViewRowEventArgs (rowView, row);
					handler (tableView, args);
				}
			}
			internal NSTableViewCellGetter? getDataCell;
			[Export ("tableView:dataCellForTableColumn:row:")]
			public NSCell GetDataCell (NSTableView tableView, NSTableColumn tableColumn, IntPtr row)
			{
				var handler = getDataCell;
				if (handler is not null)
					return handler (tableView, tableColumn, row);
				throw new You_Should_Not_Call_base_In_This_Method ();
			}
			internal NSTableViewSearchString? getNextTypeSelectMatch;
			[Export ("tableView:nextTypeSelectMatchFromRow:toRow:forString:")]
			public IntPtr GetNextTypeSelectMatch (NSTableView tableView, IntPtr startRow, IntPtr endRow, string searchString)
			{
				var handler = getNextTypeSelectMatch;
				if (handler is not null)
					return handler (tableView, startRow, endRow, searchString);
				return ((nint) (-1));
			}
			internal NSTableViewRowHeight? getRowHeight;
			[Export ("tableView:heightOfRow:")]
			public NFloat GetRowHeight (NSTableView tableView, IntPtr row)
			{
				var handler = getRowHeight;
				if (handler is not null)
					return handler (tableView, row);
				throw new You_Should_Not_Call_base_In_This_Method ();
			}
			internal NSTableViewColumnRowString? getSelectString;
			[Export ("tableView:typeSelectStringForTableColumn:row:")]
			public string GetSelectString (NSTableView tableView, NSTableColumn tableColumn, IntPtr row)
			{
				var handler = getSelectString;
				if (handler is not null)
					return handler (tableView, tableColumn, row);
				return String.Empty!;
			}
			internal NSTableViewIndexFilter? getSelectionIndexes;
			[Export ("tableView:selectionIndexesForProposedSelection:")]
			public NSIndexSet GetSelectionIndexes (NSTableView tableView, NSIndexSet proposedSelectionIndexes)
			{
				var handler = getSelectionIndexes;
				if (handler is not null)
					return handler (tableView, proposedSelectionIndexes);
				return proposedSelectionIndexes!;
			}
			internal NSTableViewColumnWidth? getSizeToFitColumnWidth;
			[Export ("tableView:sizeToFitWidthOfColumn:")]
			public NFloat GetSizeToFitColumnWidth (NSTableView tableView, IntPtr column)
			{
				var handler = getSizeToFitColumnWidth;
				if (handler is not null)
					return handler (tableView, column);
				return 80!;
			}
			internal NSTableViewToolTip? getToolTip;
			[Export ("tableView:toolTipForCell:rect:tableColumn:row:mouseLocation:")]
			public NSString GetToolTip (NSTableView tableView, NSCell cell, ref CGRect rect, NSTableColumn? tableColumn, IntPtr row, CGPoint mouseLocation)
			{
				var handler = getToolTip;
				if (handler is not null)
					return handler (tableView, cell, ref rect, tableColumn, row, mouseLocation);
				return null!;
			}
			internal NSTableViewViewGetter? getViewForItem;
			[Export ("tableView:viewForTableColumn:row:")]
			public NSView GetViewForItem (NSTableView tableView, NSTableColumn tableColumn, IntPtr row)
			{
				var handler = getViewForItem;
				if (handler is not null)
					return handler (tableView, tableColumn, row);
				throw new You_Should_Not_Call_base_In_This_Method ();
			}
			internal NSTableViewRowPredicate? isGroupRow;
			[Export ("tableView:isGroupRow:")]
			public bool IsGroupRow (NSTableView tableView, IntPtr row)
			{
				var handler = isGroupRow;
				if (handler is not null)
					return handler (tableView, row);
				return false!;
			}
			internal EventHandler<NSTableViewTableEventArgs>? mouseDownInHeaderOfTableColumn;
			[Export ("tableView:mouseDownInHeaderOfTableColumn:")]
			public void MouseDownInHeaderOfTableColumn (NSTableView tableView, NSTableColumn tableColumn)
			{
				var handler = mouseDownInHeaderOfTableColumn;
				if (handler is not null){
					var args = new NSTableViewTableEventArgs (tableColumn);
					handler (tableView, args);
				}
			}
			internal NSTableViewRowActionsGetter? rowActions;
			[Export ("tableView:rowActionsForRow:edge:")]
			public NSTableViewRowAction[] RowActions (NSTableView tableView, IntPtr row, NSTableRowActionEdge edge)
			{
				var handler = rowActions;
				if (handler is not null)
					return handler (tableView, row, edge);
				throw new You_Should_Not_Call_base_In_This_Method ();
			}
			internal EventHandler? selectionDidChange;
			[Export ("tableViewSelectionDidChange:")]
			public void SelectionDidChange (NSNotification notification)
			{
				var handler = selectionDidChange;
				if (handler is not null){
					handler (notification, EventArgs.Empty);
				}
			}
			internal EventHandler? selectionIsChanging;
			[Export ("tableViewSelectionIsChanging:")]
			public void SelectionIsChanging (NSNotification notification)
			{
				var handler = selectionIsChanging;
				if (handler is not null){
					handler (notification, EventArgs.Empty);
				}
			}
			internal NSTableViewPredicate? selectionShouldChange;
			[Export ("selectionShouldChangeInTableView:")]
			public bool SelectionShouldChange (NSTableView tableView)
			{
				var handler = selectionShouldChange;
				if (handler is not null)
					return handler (tableView);
				return true!;
			}
			internal NSTableViewColumnRowPredicate? shouldEditTableColumn;
			[Export ("tableView:shouldEditTableColumn:row:")]
			public bool ShouldEditTableColumn (NSTableView tableView, NSTableColumn tableColumn, IntPtr row)
			{
				var handler = shouldEditTableColumn;
				if (handler is not null)
					return handler (tableView, tableColumn, row);
				return false!;
			}
			internal NSTableReorder? shouldReorder;
			[Export ("tableView:shouldReorderColumn:toColumn:")]
			public bool ShouldReorder (NSTableView tableView, IntPtr columnIndex, IntPtr newColumnIndex)
			{
				var handler = shouldReorder;
				if (handler is not null)
					return handler (tableView, columnIndex, newColumnIndex);
				return false!;
			}
			internal NSTableViewRowPredicate? shouldSelectRow;
			[Export ("tableView:shouldSelectRow:")]
			public bool ShouldSelectRow (NSTableView tableView, IntPtr row)
			{
				var handler = shouldSelectRow;
				if (handler is not null)
					return handler (tableView, row);
				return true!;
			}
			internal NSTableViewColumnPredicate? shouldSelectTableColumn;
			[Export ("tableView:shouldSelectTableColumn:")]
			public bool ShouldSelectTableColumn (NSTableView tableView, NSTableColumn tableColumn)
			{
				var handler = shouldSelectTableColumn;
				if (handler is not null)
					return handler (tableView, tableColumn);
				return true!;
			}
			internal NSTableViewColumnRowPredicate? shouldShowCellExpansion;
			[Export ("tableView:shouldShowCellExpansionForTableColumn:row:")]
			public bool ShouldShowCellExpansion (NSTableView tableView, NSTableColumn tableColumn, IntPtr row)
			{
				var handler = shouldShowCellExpansion;
				if (handler is not null)
					return handler (tableView, tableColumn, row);
				return false!;
			}
			internal NSTableViewCell? shouldTrackCell;
			[Export ("tableView:shouldTrackCell:forTableColumn:row:")]
			public bool ShouldTrackCell (NSTableView tableView, NSCell cell, NSTableColumn tableColumn, IntPtr row)
			{
				var handler = shouldTrackCell;
				if (handler is not null)
					return handler (tableView, cell, tableColumn, row);
				return false!;
			}
			internal NSTableViewEventString? shouldTypeSelect;
			[Export ("tableView:shouldTypeSelectForEvent:withCurrentSearchString:")]
			public bool ShouldTypeSelect (NSTableView tableView, NSEvent theEvent, string searchString)
			{
				var handler = shouldTypeSelect;
				if (handler is not null)
					return handler (tableView, theEvent, searchString);
				return false!;
			}
			internal NSTableViewUserCanChangeColumnVisibility? userCanChangeVisibility;
			[Export ("tableView:userCanChangeVisibilityOfTableColumn:")]
			public bool UserCanChangeVisibility (NSTableView tableView, NSTableColumn column)
			{
				var handler = userCanChangeVisibility;
				if (handler is not null)
					return handler (tableView, column);
				return false!;
			}
			internal EventHandler<NSTableViewUserCanChangeColumnsVisibilityEventArgs>? userDidChangeVisibility;
			[Export ("tableView:userDidChangeVisibilityOfTableColumns:")]
			public void UserDidChangeVisibility (NSTableView tableView, NSTableColumn[] columns)
			{
				var handler = userDidChangeVisibility;
				if (handler is not null){
					var args = new NSTableViewUserCanChangeColumnsVisibilityEventArgs (columns);
					handler (tableView, args);
				}
			}
			internal EventHandler<NSTableViewCellEventArgs>? willDisplayCell;
			[Export ("tableView:willDisplayCell:forTableColumn:row:")]
			public void WillDisplayCell (NSTableView tableView, NSObject cell, NSTableColumn tableColumn, IntPtr row)
			{
				var handler = willDisplayCell;
				if (handler is not null){
					var args = new NSTableViewCellEventArgs (cell, tableColumn, row);
					handler (tableView, args);
				}
			}
			static NativeHandle selGetDataCellHandle = Selector.GetHandle ("tableView:dataCellForTableColumn:row:");
			static NativeHandle selGetRowHeightHandle = Selector.GetHandle ("tableView:heightOfRow:");
			static NativeHandle selGetViewForItemHandle = Selector.GetHandle ("tableView:viewForTableColumn:row:");
			static NativeHandle selRowActionsHandle = Selector.GetHandle ("tableView:rowActionsForRow:edge:");
			static NativeHandle selRespondsToSelector = Selector.GetHandle ("respondsToSelector:");
			public override bool RespondsToSelector (Selector? sel)
			{
				if (sel is null)
					return false;
				NativeHandle selHandle = sel.Handle;
				if (selHandle.Equals (selGetDataCellHandle))
					return getDataCell is not null;
				if (selHandle.Equals (selGetRowHeightHandle))
					return getRowHeight is not null;
				if (selHandle.Equals (selGetViewForItemHandle))
					return getViewForItem is not null;
				if (selHandle.Equals (selRowActionsHandle))
					return rowActions is not null;
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					return global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selRespondsToSelector, selHandle) != 0;
				}
			}
		}
		#pragma warning restore 672
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler ColumnDidMove {
			add { EnsureNSTableViewDelegate ()!.columnDidMove += value; }
			remove { EnsureNSTableViewDelegate ()!.columnDidMove -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler ColumnDidResize {
			add { EnsureNSTableViewDelegate ()!.columnDidResize += value; }
			remove { EnsureNSTableViewDelegate ()!.columnDidResize -= value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTableViewRowGetter? CoreGetRowView {
			get { return EnsureNSTableViewDelegate ()!.coreGetRowView; }
			set { EnsureNSTableViewDelegate ()!.coreGetRowView = value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<NSTableViewRowEventArgs> DidAddRowView {
			add { EnsureNSTableViewDelegate ()!.didAddRowView += value; }
			remove { EnsureNSTableViewDelegate ()!.didAddRowView -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<NSTableViewTableEventArgs> DidClickTableColumn {
			add { EnsureNSTableViewDelegate ()!.didClickTableColumn += value; }
			remove { EnsureNSTableViewDelegate ()!.didClickTableColumn -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<NSTableViewTableEventArgs> DidDragTableColumn {
			add { EnsureNSTableViewDelegate ()!.didDragTableColumn += value; }
			remove { EnsureNSTableViewDelegate ()!.didDragTableColumn -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<NSTableViewRowEventArgs> DidRemoveRowView {
			add { EnsureNSTableViewDelegate ()!.didRemoveRowView += value; }
			remove { EnsureNSTableViewDelegate ()!.didRemoveRowView -= value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTableViewCellGetter? GetDataCell {
			get { return EnsureNSTableViewDelegate ()!.getDataCell; }
			set { EnsureNSTableViewDelegate ()!.getDataCell = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTableViewSearchString? GetNextTypeSelectMatch {
			get { return EnsureNSTableViewDelegate ()!.getNextTypeSelectMatch; }
			set { EnsureNSTableViewDelegate ()!.getNextTypeSelectMatch = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTableViewRowHeight? GetRowHeight {
			get { return EnsureNSTableViewDelegate ()!.getRowHeight; }
			set { EnsureNSTableViewDelegate ()!.getRowHeight = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTableViewColumnRowString? GetSelectString {
			get { return EnsureNSTableViewDelegate ()!.getSelectString; }
			set { EnsureNSTableViewDelegate ()!.getSelectString = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTableViewIndexFilter? GetSelectionIndexes {
			get { return EnsureNSTableViewDelegate ()!.getSelectionIndexes; }
			set { EnsureNSTableViewDelegate ()!.getSelectionIndexes = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTableViewColumnWidth? GetSizeToFitColumnWidth {
			get { return EnsureNSTableViewDelegate ()!.getSizeToFitColumnWidth; }
			set { EnsureNSTableViewDelegate ()!.getSizeToFitColumnWidth = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTableViewToolTip? GetToolTip {
			get { return EnsureNSTableViewDelegate ()!.getToolTip; }
			set { EnsureNSTableViewDelegate ()!.getToolTip = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTableViewViewGetter? GetViewForItem {
			get { return EnsureNSTableViewDelegate ()!.getViewForItem; }
			set { EnsureNSTableViewDelegate ()!.getViewForItem = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTableViewRowPredicate? IsGroupRow {
			get { return EnsureNSTableViewDelegate ()!.isGroupRow; }
			set { EnsureNSTableViewDelegate ()!.isGroupRow = value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<NSTableViewTableEventArgs> MouseDownInHeaderOfTableColumn {
			add { EnsureNSTableViewDelegate ()!.mouseDownInHeaderOfTableColumn += value; }
			remove { EnsureNSTableViewDelegate ()!.mouseDownInHeaderOfTableColumn -= value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTableViewRowActionsGetter? RowActions {
			get { return EnsureNSTableViewDelegate ()!.rowActions; }
			set { EnsureNSTableViewDelegate ()!.rowActions = value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler SelectionDidChange {
			add { EnsureNSTableViewDelegate ()!.selectionDidChange += value; }
			remove { EnsureNSTableViewDelegate ()!.selectionDidChange -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler SelectionIsChanging {
			add { EnsureNSTableViewDelegate ()!.selectionIsChanging += value; }
			remove { EnsureNSTableViewDelegate ()!.selectionIsChanging -= value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTableViewPredicate? SelectionShouldChange {
			get { return EnsureNSTableViewDelegate ()!.selectionShouldChange; }
			set { EnsureNSTableViewDelegate ()!.selectionShouldChange = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTableViewColumnRowPredicate? ShouldEditTableColumn {
			get { return EnsureNSTableViewDelegate ()!.shouldEditTableColumn; }
			set { EnsureNSTableViewDelegate ()!.shouldEditTableColumn = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTableReorder? ShouldReorder {
			get { return EnsureNSTableViewDelegate ()!.shouldReorder; }
			set { EnsureNSTableViewDelegate ()!.shouldReorder = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTableViewRowPredicate? ShouldSelectRow {
			get { return EnsureNSTableViewDelegate ()!.shouldSelectRow; }
			set { EnsureNSTableViewDelegate ()!.shouldSelectRow = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTableViewColumnPredicate? ShouldSelectTableColumn {
			get { return EnsureNSTableViewDelegate ()!.shouldSelectTableColumn; }
			set { EnsureNSTableViewDelegate ()!.shouldSelectTableColumn = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTableViewColumnRowPredicate? ShouldShowCellExpansion {
			get { return EnsureNSTableViewDelegate ()!.shouldShowCellExpansion; }
			set { EnsureNSTableViewDelegate ()!.shouldShowCellExpansion = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTableViewCell? ShouldTrackCell {
			get { return EnsureNSTableViewDelegate ()!.shouldTrackCell; }
			set { EnsureNSTableViewDelegate ()!.shouldTrackCell = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTableViewEventString? ShouldTypeSelect {
			get { return EnsureNSTableViewDelegate ()!.shouldTypeSelect; }
			set { EnsureNSTableViewDelegate ()!.shouldTypeSelect = value; }
		}
		public NSTableViewUserCanChangeColumnVisibility? UserCanChangeVisibility {
			get { return EnsureNSTableViewDelegate ()!.userCanChangeVisibility; }
			set { EnsureNSTableViewDelegate ()!.userCanChangeVisibility = value; }
		}
		public event EventHandler<NSTableViewUserCanChangeColumnsVisibilityEventArgs> UserDidChangeVisibility {
			add { EnsureNSTableViewDelegate ()!.userDidChangeVisibility += value; }
			remove { EnsureNSTableViewDelegate ()!.userDidChangeVisibility -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<NSTableViewCellEventArgs> WillDisplayCell {
			add { EnsureNSTableViewDelegate ()!.willDisplayCell += value; }
			remove { EnsureNSTableViewDelegate ()!.willDisplayCell -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDataSource_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AppKit.NSTableView" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSTableView.ColumnDidMoveNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSTableView.ColumnDidMoveNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSTableView.Notifications.ObserveColumnDidMove ((notification) => {
			///   Console.WriteLine ("Observed ColumnDidMoveNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveColumnDidMove (EventHandler<AppKit.NSViewColumnMoveEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ColumnDidMoveNotification, notification => handler (null, new AppKit.NSViewColumnMoveEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSTableView.ColumnDidMoveNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSTableView.ColumnDidMoveNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSTableView.Notifications.ObserveColumnDidMove (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ColumnDidMoveNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveColumnDidMove (NSObject objectToObserve, EventHandler<AppKit.NSViewColumnMoveEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ColumnDidMoveNotification, notification => handler (null, new AppKit.NSViewColumnMoveEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSTableView.ColumnDidResizeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSTableView.ColumnDidResizeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSTableView.Notifications.ObserveColumnDidResize ((notification) => {
			///   Console.WriteLine ("Observed ColumnDidResizeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveColumnDidResize (EventHandler<AppKit.NSViewColumnResizeEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ColumnDidResizeNotification, notification => handler (null, new AppKit.NSViewColumnResizeEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSTableView.ColumnDidResizeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSTableView.ColumnDidResizeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSTableView.Notifications.ObserveColumnDidResize (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ColumnDidResizeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveColumnDidResize (NSObject objectToObserve, EventHandler<AppKit.NSViewColumnResizeEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ColumnDidResizeNotification, notification => handler (null, new AppKit.NSViewColumnResizeEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSTableView.SelectionDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSTableView.SelectionDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSTableView.Notifications.ObserveSelectionDidChange ((notification) => {
			///   Console.WriteLine ("Observed SelectionDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectionDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectionDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSTableView.SelectionDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSTableView.SelectionDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSTableView.Notifications.ObserveSelectionDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed SelectionDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectionDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectionDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSTableView.SelectionIsChangingNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSTableView.SelectionIsChangingNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSTableView.Notifications.ObserveSelectionIsChanging ((notification) => {
			///   Console.WriteLine ("Observed SelectionIsChangingNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectionIsChanging (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectionIsChangingNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSTableView.SelectionIsChangingNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSTableView.SelectionIsChangingNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSTableView.Notifications.ObserveSelectionIsChanging (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed SelectionIsChangingNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectionIsChanging (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectionIsChangingNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSTableView */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class NSTableViewCellEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="NSTableViewCellEventArgs" /> with the specified event data.</summary>
		/// <param name="cell">The value for the <see cref="Cell" /> property.</param>
		/// <param name="tableColumn">The value for the <see cref="TableColumn" /> property.</param>
		/// <param name="row">The value for the <see cref="Row" /> property.</param>
		public NSTableViewCellEventArgs (NSObject cell, NSTableColumn tableColumn, IntPtr row)
		{
			this.Cell = cell;
			this.Row = row;
			this.TableColumn = tableColumn;
		}
		public NSObject Cell { get; set; }
		public IntPtr Row { get; set; }
		public NSTableColumn TableColumn { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class NSTableViewRowEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="NSTableViewRowEventArgs" /> with the specified event data.</summary>
		/// <param name="rowView">The value for the <see cref="RowView" /> property.</param>
		/// <param name="row">The value for the <see cref="Row" /> property.</param>
		public NSTableViewRowEventArgs (NSTableRowView rowView, IntPtr row)
		{
			this.Row = row;
			this.RowView = rowView;
		}
		public IntPtr Row { get; set; }
		public NSTableRowView RowView { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class NSTableViewTableEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="NSTableViewTableEventArgs" /> with the specified event data.</summary>
		/// <param name="tableColumn">The value for the <see cref="TableColumn" /> property.</param>
		public NSTableViewTableEventArgs (NSTableColumn tableColumn)
		{
			this.TableColumn = tableColumn;
		}
		public NSTableColumn TableColumn { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class NSTableViewUserCanChangeColumnsVisibilityEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="NSTableViewUserCanChangeColumnsVisibilityEventArgs" /> with the specified event data.</summary>
		/// <param name="columns">The value for the <see cref="Columns" /> property.</param>
		public NSTableViewUserCanChangeColumnsVisibilityEventArgs (NSTableColumn[] columns)
		{
			this.Columns = columns;
		}
		public NSTableColumn[] Columns { get; set; }
	}
}
