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
	[Register("NSMatrix", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSMatrix : NSControl, INSUserInterfaceValidations, INSViewToolTipOwner {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAcceptsFirstMouse_X = "acceptsFirstMouse:";
		static readonly NativeHandle selAcceptsFirstMouse_XHandle = Selector.GetHandle ("acceptsFirstMouse:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddColumnX = "addColumn";
		static readonly NativeHandle selAddColumnXHandle = Selector.GetHandle ("addColumn");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddColumnWithCells_X = "addColumnWithCells:";
		static readonly NativeHandle selAddColumnWithCells_XHandle = Selector.GetHandle ("addColumnWithCells:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddRowX = "addRow";
		static readonly NativeHandle selAddRowXHandle = Selector.GetHandle ("addRow");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddRowWithCells_X = "addRowWithCells:";
		static readonly NativeHandle selAddRowWithCells_XHandle = Selector.GetHandle ("addRowWithCells:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsEmptySelectionX = "allowsEmptySelection";
		static readonly NativeHandle selAllowsEmptySelectionXHandle = Selector.GetHandle ("allowsEmptySelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutorecalculatesCellSizeX = "autorecalculatesCellSize";
		static readonly NativeHandle selAutorecalculatesCellSizeXHandle = Selector.GetHandle ("autorecalculatesCellSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutosizesCellsX = "autosizesCells";
		static readonly NativeHandle selAutosizesCellsXHandle = Selector.GetHandle ("autosizesCells");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackgroundColorX = "backgroundColor";
		static readonly NativeHandle selBackgroundColorXHandle = Selector.GetHandle ("backgroundColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellAtRow_Column_X = "cellAtRow:column:";
		static readonly NativeHandle selCellAtRow_Column_XHandle = Selector.GetHandle ("cellAtRow:column:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellBackgroundColorX = "cellBackgroundColor";
		static readonly NativeHandle selCellBackgroundColorXHandle = Selector.GetHandle ("cellBackgroundColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellClassX = "cellClass";
		static readonly NativeHandle selCellClassXHandle = Selector.GetHandle ("cellClass");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellFrameAtRow_Column_X = "cellFrameAtRow:column:";
		static readonly NativeHandle selCellFrameAtRow_Column_XHandle = Selector.GetHandle ("cellFrameAtRow:column:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellSizeX = "cellSize";
		static readonly NativeHandle selCellSizeXHandle = Selector.GetHandle ("cellSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellWithTag_X = "cellWithTag:";
		static readonly NativeHandle selCellWithTag_XHandle = Selector.GetHandle ("cellWithTag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellsX = "cells";
		static readonly NativeHandle selCellsXHandle = Selector.GetHandle ("cells");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeselectAllCellsX = "deselectAllCells";
		static readonly NativeHandle selDeselectAllCellsXHandle = Selector.GetHandle ("deselectAllCells");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeselectSelectedCellX = "deselectSelectedCell";
		static readonly NativeHandle selDeselectSelectedCellXHandle = Selector.GetHandle ("deselectSelectedCell");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDoubleActionX = "doubleAction";
		static readonly NativeHandle selDoubleActionXHandle = Selector.GetHandle ("doubleAction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawCellAtRow_Column_X = "drawCellAtRow:column:";
		static readonly NativeHandle selDrawCellAtRow_Column_XHandle = Selector.GetHandle ("drawCellAtRow:column:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawsBackgroundX = "drawsBackground";
		static readonly NativeHandle selDrawsBackgroundXHandle = Selector.GetHandle ("drawsBackground");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawsCellBackgroundX = "drawsCellBackground";
		static readonly NativeHandle selDrawsCellBackgroundXHandle = Selector.GetHandle ("drawsCellBackground");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetNumberOfRows_Columns_X = "getNumberOfRows:columns:";
		static readonly NativeHandle selGetNumberOfRows_Columns_XHandle = Selector.GetHandle ("getNumberOfRows:columns:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetRow_Column_ForPoint_X = "getRow:column:forPoint:";
		static readonly NativeHandle selGetRow_Column_ForPoint_XHandle = Selector.GetHandle ("getRow:column:forPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetRow_Column_OfCell_X = "getRow:column:ofCell:";
		static readonly NativeHandle selGetRow_Column_OfCell_XHandle = Selector.GetHandle ("getRow:column:ofCell:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHighlightCell_AtRow_Column_X = "highlightCell:atRow:column:";
		static readonly NativeHandle selHighlightCell_AtRow_Column_XHandle = Selector.GetHandle ("highlightCell:atRow:column:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_X = "initWithFrame:";
		static readonly NativeHandle selInitWithFrame_XHandle = Selector.GetHandle ("initWithFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_Mode_CellClass_NumberOfRows_NumberOfColumns_X = "initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:";
		static readonly NativeHandle selInitWithFrame_Mode_CellClass_NumberOfRows_NumberOfColumns_XHandle = Selector.GetHandle ("initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_Mode_Prototype_NumberOfRows_NumberOfColumns_X = "initWithFrame:mode:prototype:numberOfRows:numberOfColumns:";
		static readonly NativeHandle selInitWithFrame_Mode_Prototype_NumberOfRows_NumberOfColumns_XHandle = Selector.GetHandle ("initWithFrame:mode:prototype:numberOfRows:numberOfColumns:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertColumn_X = "insertColumn:";
		static readonly NativeHandle selInsertColumn_XHandle = Selector.GetHandle ("insertColumn:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertColumn_WithCells_X = "insertColumn:withCells:";
		static readonly NativeHandle selInsertColumn_WithCells_XHandle = Selector.GetHandle ("insertColumn:withCells:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertRow_X = "insertRow:";
		static readonly NativeHandle selInsertRow_XHandle = Selector.GetHandle ("insertRow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertRow_WithCells_X = "insertRow:withCells:";
		static readonly NativeHandle selInsertRow_WithCells_XHandle = Selector.GetHandle ("insertRow:withCells:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIntercellSpacingX = "intercellSpacing";
		static readonly NativeHandle selIntercellSpacingXHandle = Selector.GetHandle ("intercellSpacing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutoscrollX = "isAutoscroll";
		static readonly NativeHandle selIsAutoscrollXHandle = Selector.GetHandle ("isAutoscroll");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSelectionByRectX = "isSelectionByRect";
		static readonly NativeHandle selIsSelectionByRectXHandle = Selector.GetHandle ("isSelectionByRect");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeyCellX = "keyCell";
		static readonly NativeHandle selKeyCellXHandle = Selector.GetHandle ("keyCell");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakeCellAtRow_Column_X = "makeCellAtRow:column:";
		static readonly NativeHandle selMakeCellAtRow_Column_XHandle = Selector.GetHandle ("makeCellAtRow:column:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selModeX = "mode";
		static readonly NativeHandle selModeXHandle = Selector.GetHandle ("mode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMouseDown_X = "mouseDown:";
		static readonly NativeHandle selMouseDown_XHandle = Selector.GetHandle ("mouseDown:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMouseDownFlagsX = "mouseDownFlags";
		static readonly NativeHandle selMouseDownFlagsXHandle = Selector.GetHandle ("mouseDownFlags");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfColumnsX = "numberOfColumns";
		static readonly NativeHandle selNumberOfColumnsXHandle = Selector.GetHandle ("numberOfColumns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfRowsX = "numberOfRows";
		static readonly NativeHandle selNumberOfRowsXHandle = Selector.GetHandle ("numberOfRows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformKeyEquivalent_X = "performKeyEquivalent:";
		static readonly NativeHandle selPerformKeyEquivalent_XHandle = Selector.GetHandle ("performKeyEquivalent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrototypeX = "prototype";
		static readonly NativeHandle selPrototypeXHandle = Selector.GetHandle ("prototype");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPutCell_AtRow_Column_X = "putCell:atRow:column:";
		static readonly NativeHandle selPutCell_AtRow_Column_XHandle = Selector.GetHandle ("putCell:atRow:column:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveColumn_X = "removeColumn:";
		static readonly NativeHandle selRemoveColumn_XHandle = Selector.GetHandle ("removeColumn:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveRow_X = "removeRow:";
		static readonly NativeHandle selRemoveRow_XHandle = Selector.GetHandle ("removeRow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenewRows_Columns_X = "renewRows:columns:";
		static readonly NativeHandle selRenewRows_Columns_XHandle = Selector.GetHandle ("renewRows:columns:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResetCursorRectsX = "resetCursorRects";
		static readonly NativeHandle selResetCursorRectsXHandle = Selector.GetHandle ("resetCursorRects");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollCellToVisibleAtRow_Column_X = "scrollCellToVisibleAtRow:column:";
		static readonly NativeHandle selScrollCellToVisibleAtRow_Column_XHandle = Selector.GetHandle ("scrollCellToVisibleAtRow:column:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectAll_X = "selectAll:";
		static readonly NativeHandle selSelectAll_XHandle = Selector.GetHandle ("selectAll:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectCellAtRow_Column_X = "selectCellAtRow:column:";
		static readonly NativeHandle selSelectCellAtRow_Column_XHandle = Selector.GetHandle ("selectCellAtRow:column:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectCellWithTag_X = "selectCellWithTag:";
		static readonly NativeHandle selSelectCellWithTag_XHandle = Selector.GetHandle ("selectCellWithTag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectText_X = "selectText:";
		static readonly NativeHandle selSelectText_XHandle = Selector.GetHandle ("selectText:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectTextAtRow_Column_X = "selectTextAtRow:column:";
		static readonly NativeHandle selSelectTextAtRow_Column_XHandle = Selector.GetHandle ("selectTextAtRow:column:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedCellX = "selectedCell";
		static readonly NativeHandle selSelectedCellXHandle = Selector.GetHandle ("selectedCell");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedCellsX = "selectedCells";
		static readonly NativeHandle selSelectedCellsXHandle = Selector.GetHandle ("selectedCells");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedColumnX = "selectedColumn";
		static readonly NativeHandle selSelectedColumnXHandle = Selector.GetHandle ("selectedColumn");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedRowX = "selectedRow";
		static readonly NativeHandle selSelectedRowXHandle = Selector.GetHandle ("selectedRow");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendActionX = "sendAction";
		static readonly NativeHandle selSendActionXHandle = Selector.GetHandle ("sendAction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendAction_To_ForAllCells_X = "sendAction:to:forAllCells:";
		static readonly NativeHandle selSendAction_To_ForAllCells_XHandle = Selector.GetHandle ("sendAction:to:forAllCells:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendDoubleActionX = "sendDoubleAction";
		static readonly NativeHandle selSendDoubleActionXHandle = Selector.GetHandle ("sendDoubleAction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsEmptySelection_X = "setAllowsEmptySelection:";
		static readonly NativeHandle selSetAllowsEmptySelection_XHandle = Selector.GetHandle ("setAllowsEmptySelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutorecalculatesCellSize_X = "setAutorecalculatesCellSize:";
		static readonly NativeHandle selSetAutorecalculatesCellSize_XHandle = Selector.GetHandle ("setAutorecalculatesCellSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutoscroll_X = "setAutoscroll:";
		static readonly NativeHandle selSetAutoscroll_XHandle = Selector.GetHandle ("setAutoscroll:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutosizesCells_X = "setAutosizesCells:";
		static readonly NativeHandle selSetAutosizesCells_XHandle = Selector.GetHandle ("setAutosizesCells:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBackgroundColor_X = "setBackgroundColor:";
		static readonly NativeHandle selSetBackgroundColor_XHandle = Selector.GetHandle ("setBackgroundColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCellBackgroundColor_X = "setCellBackgroundColor:";
		static readonly NativeHandle selSetCellBackgroundColor_XHandle = Selector.GetHandle ("setCellBackgroundColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCellClass_X = "setCellClass:";
		static readonly NativeHandle selSetCellClass_XHandle = Selector.GetHandle ("setCellClass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCellSize_X = "setCellSize:";
		static readonly NativeHandle selSetCellSize_XHandle = Selector.GetHandle ("setCellSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDoubleAction_X = "setDoubleAction:";
		static readonly NativeHandle selSetDoubleAction_XHandle = Selector.GetHandle ("setDoubleAction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDrawsBackground_X = "setDrawsBackground:";
		static readonly NativeHandle selSetDrawsBackground_XHandle = Selector.GetHandle ("setDrawsBackground:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDrawsCellBackground_X = "setDrawsCellBackground:";
		static readonly NativeHandle selSetDrawsCellBackground_XHandle = Selector.GetHandle ("setDrawsCellBackground:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIntercellSpacing_X = "setIntercellSpacing:";
		static readonly NativeHandle selSetIntercellSpacing_XHandle = Selector.GetHandle ("setIntercellSpacing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetKeyCell_X = "setKeyCell:";
		static readonly NativeHandle selSetKeyCell_XHandle = Selector.GetHandle ("setKeyCell:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMode_X = "setMode:";
		static readonly NativeHandle selSetMode_XHandle = Selector.GetHandle ("setMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrototype_X = "setPrototype:";
		static readonly NativeHandle selSetPrototype_XHandle = Selector.GetHandle ("setPrototype:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetScrollable_X = "setScrollable:";
		static readonly NativeHandle selSetScrollable_XHandle = Selector.GetHandle ("setScrollable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectionByRect_X = "setSelectionByRect:";
		static readonly NativeHandle selSetSelectionByRect_XHandle = Selector.GetHandle ("setSelectionByRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectionFrom_To_Anchor_Highlight_X = "setSelectionFrom:to:anchor:highlight:";
		static readonly NativeHandle selSetSelectionFrom_To_Anchor_Highlight_XHandle = Selector.GetHandle ("setSelectionFrom:to:anchor:highlight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetState_AtRow_Column_X = "setState:atRow:column:";
		static readonly NativeHandle selSetState_AtRow_Column_XHandle = Selector.GetHandle ("setState:atRow:column:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTabKeyTraversesCells_X = "setTabKeyTraversesCells:";
		static readonly NativeHandle selSetTabKeyTraversesCells_XHandle = Selector.GetHandle ("setTabKeyTraversesCells:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetToolTip_ForCell_X = "setToolTip:forCell:";
		static readonly NativeHandle selSetToolTip_ForCell_XHandle = Selector.GetHandle ("setToolTip:forCell:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetValidateSize_X = "setValidateSize:";
		static readonly NativeHandle selSetValidateSize_XHandle = Selector.GetHandle ("setValidateSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSizeToCellsX = "sizeToCells";
		static readonly NativeHandle selSizeToCellsXHandle = Selector.GetHandle ("sizeToCells");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSortUsingSelector_X = "sortUsingSelector:";
		static readonly NativeHandle selSortUsingSelector_XHandle = Selector.GetHandle ("sortUsingSelector:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTabKeyTraversesCellsX = "tabKeyTraversesCells";
		static readonly NativeHandle selTabKeyTraversesCellsXHandle = Selector.GetHandle ("tabKeyTraversesCells");
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
		const string selToolTipForCell_X = "toolTipForCell:";
		static readonly NativeHandle selToolTipForCell_XHandle = Selector.GetHandle ("toolTipForCell:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateUserInterfaceItem_X = "validateUserInterfaceItem:";
		static readonly NativeHandle selValidateUserInterfaceItem_XHandle = Selector.GetHandle ("validateUserInterfaceItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selView_StringForToolTip_Point_UserData_X = "view:stringForToolTip:point:userData:";
		static readonly NativeHandle selView_StringForToolTip_Point_UserData_XHandle = Selector.GetHandle ("view:stringForToolTip:point:userData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSMatrix");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSMatrix" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSMatrix () : base (NSObjectFlag.Empty)
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
		public NSMatrix (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSMatrix (NSObjectFlag t) : base (t)
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
		protected internal NSMatrix (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSMatrix (CGRect frameRect)
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
		[Export ("initWithFrame:mode:prototype:numberOfRows:numberOfColumns:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSMatrix (CGRect frameRect, NSMatrixMode aMode, NSCell aCell, nint rowsHigh, nint colsWide)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var aCell__handle__ = aCell!.GetNonNullHandle (nameof (aCell));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_UIntPtr_NativeHandle_IntPtr_IntPtr (this.Handle, selInitWithFrame_Mode_Prototype_NumberOfRows_NumberOfColumns_XHandle, frameRect, (UIntPtr) (ulong) aMode, aCell__handle__, rowsHigh, colsWide), "initWithFrame:mode:prototype:numberOfRows:numberOfColumns:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect_UIntPtr_NativeHandle_IntPtr_IntPtr (&__objc_super__, selInitWithFrame_Mode_Prototype_NumberOfRows_NumberOfColumns_XHandle, frameRect, (UIntPtr) (ulong) aMode, aCell__handle__, rowsHigh, colsWide), "initWithFrame:mode:prototype:numberOfRows:numberOfColumns:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aCell);
		}
		[Export ("initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSMatrix (CGRect frameRect, NSMatrixMode aMode, Class factoryId, nint rowsHigh, nint colsWide)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var factoryId__handle__ = factoryId!.GetNonNullHandle (nameof (factoryId));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_UIntPtr_NativeHandle_IntPtr_IntPtr (this.Handle, selInitWithFrame_Mode_CellClass_NumberOfRows_NumberOfColumns_XHandle, frameRect, (UIntPtr) (ulong) aMode, factoryId.Handle, rowsHigh, colsWide), "initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect_UIntPtr_NativeHandle_IntPtr_IntPtr (&__objc_super__, selInitWithFrame_Mode_CellClass_NumberOfRows_NumberOfColumns_XHandle, frameRect, (UIntPtr) (ulong) aMode, factoryId.Handle, rowsHigh, colsWide), "initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (factoryId);
		}
		[Export ("acceptsFirstMouse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AcceptsFirstMouse (NSEvent theEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selAcceptsFirstMouse_XHandle, theEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selAcceptsFirstMouse_XHandle, theEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (theEvent);
			return ret != 0;
		}
		[Export ("addColumn")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddColumn ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selAddColumnXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selAddColumnXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("addColumnWithCells:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddColumnWithCells (NSCell[] newCells)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (newCells is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (newCells));
			using var nsa_newCells = NSArray.FromNSObjects (newCells);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddColumnWithCells_XHandle, nsa_newCells.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddColumnWithCells_XHandle, nsa_newCells.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("addRow")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddRow ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selAddRowXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selAddRowXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("addRowWithCells:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddRowWithCells (NSCell[] newCells)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (newCells is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (newCells));
			using var nsa_newCells = NSArray.FromNSObjects (newCells);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddRowWithCells_XHandle, nsa_newCells.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddRowWithCells_XHandle, nsa_newCells.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("cellAtRow:column:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSCell CellAtRowColumn (nint row, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSCell ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr (this.Handle, selCellAtRow_Column_XHandle, row, column), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selCellAtRow_Column_XHandle, row, column), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("cellFrameAtRow:column:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect CellFrameAtRowColumn (nint row, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_IntPtr_IntPtr (this.Handle, selCellFrameAtRow_Column_XHandle, row, column);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_IntPtr_IntPtr (this.Handle, selCellFrameAtRow_Column_XHandle, row, column);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selCellFrameAtRow_Column_XHandle, row, column);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_IntPtr (&__objc_super__, selCellFrameAtRow_Column_XHandle, row, column);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("cellWithTag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCell CellWithTag (nint anInt)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSCell ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selCellWithTag_XHandle, anInt), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selCellWithTag_XHandle, anInt), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("textDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Changed (NSNotification notification)
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
		[Export ("deselectAllCells")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeselectAllCells ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDeselectAllCellsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDeselectAllCellsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("deselectSelectedCell")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeselectSelectedCell ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDeselectSelectedCellXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDeselectSelectedCellXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("textDidBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginEditing (NSNotification notification)
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
		[Export ("textDidEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndEditing (NSNotification notification)
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
		[Export ("drawCellAtRow:column:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawCellAtRowColumn (nint row, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selDrawCellAtRow_Column_XHandle, row, column);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selDrawCellAtRow_Column_XHandle, row, column);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("getRow:column:ofCell:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool GetRowColumn (out nint row, out nint column, NSCell aCell)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var aCell__handle__ = aCell!.GetNonNullHandle (nameof (aCell));
			fixed (nint* row__pointer = &row) {
			fixed (nint* column__pointer = &column) {
			row = default;
			column = default;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_out_IntPtr_out_IntPtr_NativeHandle (this.Handle, selGetRow_Column_OfCell_XHandle, row__pointer, column__pointer, aCell__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_out_IntPtr_out_IntPtr_NativeHandle (&__objc_super__, selGetRow_Column_OfCell_XHandle, row__pointer, column__pointer, aCell__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aCell);
			return ret != 0;
			}
			}
		}
		[Export ("getRow:column:forPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool GetRowColumnForPoint (out nint row, out nint column, CGPoint aPoint)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (nint* row__pointer = &row) {
			fixed (nint* column__pointer = &column) {
			row = default;
			column = default;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_out_IntPtr_out_IntPtr_CGPoint (this.Handle, selGetRow_Column_ForPoint_XHandle, row__pointer, column__pointer, aPoint);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_out_IntPtr_out_IntPtr_CGPoint (&__objc_super__, selGetRow_Column_ForPoint_XHandle, row__pointer, column__pointer, aPoint);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
			}
			}
		}
		[Export ("getNumberOfRows:columns:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetRowsAndColumnsCount (out nint rowCount, out nint colCount)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (nint* rowCount__pointer = &rowCount) {
			fixed (nint* colCount__pointer = &colCount) {
			rowCount = default;
			colCount = default;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_out_IntPtr_out_IntPtr (this.Handle, selGetNumberOfRows_Columns_XHandle, rowCount__pointer, colCount__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_out_IntPtr_out_IntPtr (&__objc_super__, selGetNumberOfRows_Columns_XHandle, rowCount__pointer, colCount__pointer);
					GC.KeepAlive (this);
				}
			}
			}
			}
		}
		[Export ("view:stringForToolTip:point:userData:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetStringForToolTip (NSView view, nint tag, CGPoint point, nint data)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_CGPoint_IntPtr (this.Handle, selView_StringForToolTip_Point_UserData_XHandle, view__handle__, tag, point, data), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_CGPoint_IntPtr (&__objc_super__, selView_StringForToolTip_Point_UserData_XHandle, view__handle__, tag, point, data), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			return ret!;
		}
		[Export ("highlightCell:atRow:column:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HighlightCell (bool highlight, nint row, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_IntPtr_IntPtr (this.Handle, selHighlightCell_AtRow_Column_XHandle, highlight ? (byte) 1 : (byte) 0, row, column);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_IntPtr_IntPtr (&__objc_super__, selHighlightCell_AtRow_Column_XHandle, highlight ? (byte) 1 : (byte) 0, row, column);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("insertColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertColumn (nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selInsertColumn_XHandle, column);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selInsertColumn_XHandle, column);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("insertColumn:withCells:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertColumn (nint column, NSCell[] newCells)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (newCells is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (newCells));
			using var nsa_newCells = NSArray.FromNSObjects (newCells);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, selInsertColumn_WithCells_XHandle, column, nsa_newCells.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selInsertColumn_WithCells_XHandle, column, nsa_newCells.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("insertRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertRow (nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selInsertRow_XHandle, row);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selInsertRow_XHandle, row);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("insertRow:withCells:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertRow (nint row, NSCell[] newCells)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (newCells is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (newCells));
			using var nsa_newCells = NSArray.FromNSObjects (newCells);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, selInsertRow_WithCells_XHandle, row, nsa_newCells.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selInsertRow_WithCells_XHandle, row, nsa_newCells.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("makeCellAtRow:column:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCell MakeCell (nint row, nint col)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSCell ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr (this.Handle, selMakeCellAtRow_Column_XHandle, row, col), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selMakeCellAtRow_Column_XHandle, row, col), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("mouseDown:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MouseDown (NSEvent theEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMouseDown_XHandle, theEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMouseDown_XHandle, theEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (theEvent);
		}
		[Export ("mouseDownFlags")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint MouseDownFlags ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMouseDownFlagsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMouseDownFlagsXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("performKeyEquivalent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PerformKeyEquivalent (NSEvent theEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selPerformKeyEquivalent_XHandle, theEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selPerformKeyEquivalent_XHandle, theEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (theEvent);
			return ret != 0;
		}
		[Export ("putCell:atRow:column:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PutCell (NSCell newCell, nint row, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var newCell__handle__ = newCell!.GetNonNullHandle (nameof (newCell));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr (this.Handle, selPutCell_AtRow_Column_XHandle, newCell__handle__, row, column);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_IntPtr (&__objc_super__, selPutCell_AtRow_Column_XHandle, newCell__handle__, row, column);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newCell);
		}
		[Export ("removeColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveColumn (nint col)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRemoveColumn_XHandle, col);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selRemoveColumn_XHandle, col);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveRow (nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRemoveRow_XHandle, row);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selRemoveRow_XHandle, row);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("renewRows:columns:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RenewRowsColumns (nint newRows, nint newCols)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selRenewRows_Columns_XHandle, newRows, newCols);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selRenewRows_Columns_XHandle, newRows, newCols);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("resetCursorRects")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetCursorRects ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selResetCursorRectsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selResetCursorRectsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("scrollCellToVisibleAtRow:column:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollCellToVisible (nint row, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selScrollCellToVisibleAtRow_Column_XHandle, row, column);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selScrollCellToVisibleAtRow_Column_XHandle, row, column);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("selectAll:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectAll (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
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
		[Export ("selectCellAtRow:column:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectCell (nint row, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSelectCellAtRow_Column_XHandle, row, column);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selSelectCellAtRow_Column_XHandle, row, column);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("selectCellWithTag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SelectCellWithTag (nint tag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSelectCellWithTag_XHandle, tag);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selSelectCellWithTag_XHandle, tag);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("selectText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectText (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSelectText_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSelectText_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("selectTextAtRow:column:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject SelectTextAtRowColumn (nint row, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr (this.Handle, selSelectTextAtRow_Column_XHandle, row, column), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selSelectTextAtRow_Column_XHandle, row, column), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("sendAction:to:forAllCells:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendAction (Selector aSelector, NSObject anObject, bool forAllCells)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var aSelector__handle__ = aSelector!.GetNonNullHandle (nameof (aSelector));
			var anObject__handle__ = anObject!.GetNonNullHandle (nameof (anObject));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (this.Handle, selSendAction_To_ForAllCells_XHandle, aSelector.Handle, anObject__handle__, forAllCells ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_bool (&__objc_super__, selSendAction_To_ForAllCells_XHandle, aSelector.Handle, anObject__handle__, forAllCells ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aSelector);
			GC.KeepAlive (anObject);
		}
		[Export ("sendAction")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SendAction ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSendActionXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSendActionXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("sendDoubleAction")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendDoubleAction ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSendDoubleActionXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSendDoubleActionXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setScrollable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetScrollable (bool flag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetScrollable_XHandle, flag ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetScrollable_XHandle, flag ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setSelectionFrom:to:anchor:highlight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSelection (nint startPos, nint endPos, nint anchorPos, bool highlight)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool (this.Handle, selSetSelectionFrom_To_Anchor_Highlight_XHandle, startPos, endPos, anchorPos, highlight ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool (&__objc_super__, selSetSelectionFrom_To_Anchor_Highlight_XHandle, startPos, endPos, anchorPos, highlight ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setState:atRow:column:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetState (nint state, nint row, nint column)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selSetState_AtRow_Column_XHandle, state, row, column);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (&__objc_super__, selSetState_AtRow_Column_XHandle, state, row, column);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setToolTip:forCell:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetToolTipForCell (string? toolTipString, NSCell cell)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var nstoolTipString = CFString.CreateNative (toolTipString);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetToolTip_ForCell_XHandle, nstoolTipString, cell__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetToolTip_ForCell_XHandle, nstoolTipString, cell__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cell);
			CFString.ReleaseNative (nstoolTipString);
		}
		[Export ("setValidateSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetValidateSize (bool flag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetValidateSize_XHandle, flag ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetValidateSize_XHandle, flag ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("textShouldBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeginEditing (NSText textObject)
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEndEditing (NSText textObject)
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
		[Export ("sizeToCells")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SizeToCells ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSizeToCellsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSizeToCellsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("sortUsingSelector:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Sort (Selector comparator)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var comparator__handle__ = comparator!.GetNonNullHandle (nameof (comparator));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSortUsingSelector_XHandle, comparator.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSortUsingSelector_XHandle, comparator.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (comparator);
		}
		[Export ("toolTipForCell:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ToolTipForCell (NSCell cell)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selToolTipForCell_XHandle, cell__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selToolTipForCell_XHandle, cell__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cell);
			return ret!;
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
		public virtual bool AutoRecalculatesCellSize {
			[Export ("autorecalculatesCellSize")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAutorecalculatesCellSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAutorecalculatesCellSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutorecalculatesCellSize:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutorecalculatesCellSize_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutorecalculatesCellSize_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Autoscroll {
			[Export ("isAutoscroll")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAutoscrollXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAutoscrollXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutoscroll:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutoscroll_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutoscroll_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutosizesCells {
			[Export ("autosizesCells")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAutosizesCellsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAutosizesCellsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutosizesCells:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutosizesCells_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutosizesCells_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual NSColor CellBackgroundColor {
			[Export ("cellBackgroundColor", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCellBackgroundColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCellBackgroundColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCellBackgroundColor:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCellBackgroundColor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCellBackgroundColor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Class CellClass {
			[Export ("cellClass")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				Class ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCellClassXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCellClassXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCellClass:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCellClass_XHandle, value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCellClass_XHandle, value.Handle);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize CellSize {
			[Export ("cellSize")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selCellSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selCellSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCellSize:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, selSetCellSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, selSetCellSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCell[] Cells {
			[Export ("cells")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCell[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSCell>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCellsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSCell>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCellsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Columns {
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSMatrixDelegate Delegate {
			get {
				return (WeakDelegate as INSMatrixDelegate)!;
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
		public virtual bool DrawsBackground {
			[Export ("drawsBackground")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDrawsBackgroundXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDrawsBackgroundXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDrawsBackground:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDrawsBackground_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDrawsBackground_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DrawsCellBackground {
			[Export ("drawsCellBackground")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDrawsCellBackgroundXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDrawsCellBackgroundXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDrawsCellBackground:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDrawsCellBackground_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDrawsCellBackground_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
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
		public virtual NSObject KeyCell {
			[Export ("keyCell")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selKeyCellXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selKeyCellXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setKeyCell:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetKeyCell_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetKeyCell_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMatrixMode Mode {
			[Export ("mode")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSMatrixMode ret;
				if (IsDirectBinding) {
					ret = (NSMatrixMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSMatrixMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMode:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetMode_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetMode_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCell Prototype {
			[Export ("prototype", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCell? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPrototypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPrototypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPrototype:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPrototype_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPrototype_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Rows {
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
		public virtual NSCell SelectedCell {
			[Export ("selectedCell")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCell? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectedCellXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectedCellXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCell[] SelectedCells {
			[Export ("selectedCells")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCell[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSCell>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectedCellsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSCell>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectedCellsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SelectionByRect {
			[Export ("isSelectionByRect")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSelectionByRectXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsSelectionByRectXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSelectionByRect:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSelectionByRect_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetSelectionByRect_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TabKeyTraversesCells {
			[Export ("tabKeyTraversesCells")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selTabKeyTraversesCellsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selTabKeyTraversesCellsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setTabKeyTraversesCells:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetTabKeyTraversesCells_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetTabKeyTraversesCells_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
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
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_NSMatrixDelegate); }
		}
		internal virtual _NSMatrixDelegate CreateInternalEventDelegateType ()
		{
			return (_NSMatrixDelegate)(new _NSMatrixDelegate());
		}
		internal _NSMatrixDelegate EnsureNSMatrixDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _NSMatrixDelegate;
			if (del is null){
				del = (_NSMatrixDelegate)CreateInternalEventDelegateType ();
				Delegate = (INSMatrixDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _NSMatrixDelegate : NSObject, INSMatrixDelegate { 
			public _NSMatrixDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_NSMatrixDelegate))]
			static _NSMatrixDelegate ()
			{
				GC.KeepAlive (null);
			}
		}
		#pragma warning restore 672
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class NSMatrix */
}
