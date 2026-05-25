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
namespace PdfKit {
	/// <summary>A viewer for PDF files.</summary>
	[Register("PDFView", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class PdfView : global::AppKit.NSView, global::AppKit.INSAnimationDelegate, global::AppKit.INSMenuDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAcceptsDraggedFilesX = "acceptsDraggedFiles";
		static readonly NativeHandle selAcceptsDraggedFilesXHandle = Selector.GetHandle ("acceptsDraggedFiles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsDraggingX = "allowsDragging";
		static readonly NativeHandle selAllowsDraggingXHandle = Selector.GetHandle ("allowsDragging");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimation_DidReachProgressMark_X = "animation:didReachProgressMark:";
		static readonly NativeHandle selAnimation_DidReachProgressMark_XHandle = Selector.GetHandle ("animation:didReachProgressMark:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimation_ValueForProgress_X = "animation:valueForProgress:";
		static readonly NativeHandle selAnimation_ValueForProgress_XHandle = Selector.GetHandle ("animation:valueForProgress:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimationDidEnd_X = "animationDidEnd:";
		static readonly NativeHandle selAnimationDidEnd_XHandle = Selector.GetHandle ("animationDidEnd:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimationDidStop_X = "animationDidStop:";
		static readonly NativeHandle selAnimationDidStop_XHandle = Selector.GetHandle ("animationDidStop:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimationShouldStart_X = "animationShouldStart:";
		static readonly NativeHandle selAnimationShouldStart_XHandle = Selector.GetHandle ("animationShouldStart:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnnotationsChangedOnPage_X = "annotationsChangedOnPage:";
		static readonly NativeHandle selAnnotationsChangedOnPage_XHandle = Selector.GetHandle ("annotationsChangedOnPage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAreaOfInterestForMouse_X = "areaOfInterestForMouse:";
		static readonly NativeHandle selAreaOfInterestForMouse_XHandle = Selector.GetHandle ("areaOfInterestForMouse:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAreaOfInterestForPoint_X = "areaOfInterestForPoint:";
		static readonly NativeHandle selAreaOfInterestForPoint_XHandle = Selector.GetHandle ("areaOfInterestForPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutoScalesX = "autoScales";
		static readonly NativeHandle selAutoScalesXHandle = Selector.GetHandle ("autoScales");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackgroundColorX = "backgroundColor";
		static readonly NativeHandle selBackgroundColorXHandle = Selector.GetHandle ("backgroundColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanGoBackX = "canGoBack";
		static readonly NativeHandle selCanGoBackXHandle = Selector.GetHandle ("canGoBack");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanGoForwardX = "canGoForward";
		static readonly NativeHandle selCanGoForwardXHandle = Selector.GetHandle ("canGoForward");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanGoToFirstPageX = "canGoToFirstPage";
		static readonly NativeHandle selCanGoToFirstPageXHandle = Selector.GetHandle ("canGoToFirstPage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanGoToLastPageX = "canGoToLastPage";
		static readonly NativeHandle selCanGoToLastPageXHandle = Selector.GetHandle ("canGoToLastPage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanGoToNextPageX = "canGoToNextPage";
		static readonly NativeHandle selCanGoToNextPageXHandle = Selector.GetHandle ("canGoToNextPage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanGoToPreviousPageX = "canGoToPreviousPage";
		static readonly NativeHandle selCanGoToPreviousPageXHandle = Selector.GetHandle ("canGoToPreviousPage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanZoomInX = "canZoomIn";
		static readonly NativeHandle selCanZoomInXHandle = Selector.GetHandle ("canZoomIn");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanZoomOutX = "canZoomOut";
		static readonly NativeHandle selCanZoomOutXHandle = Selector.GetHandle ("canZoomOut");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClearSelectionX = "clearSelection";
		static readonly NativeHandle selClearSelectionXHandle = Selector.GetHandle ("clearSelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConfinementRectForMenu_OnScreen_X = "confinementRectForMenu:onScreen:";
		static readonly NativeHandle selConfinementRectForMenu_OnScreen_XHandle = Selector.GetHandle ("confinementRectForMenu:onScreen:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertPoint_FromPage_X = "convertPoint:fromPage:";
		static readonly NativeHandle selConvertPoint_FromPage_XHandle = Selector.GetHandle ("convertPoint:fromPage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertPoint_ToPage_X = "convertPoint:toPage:";
		static readonly NativeHandle selConvertPoint_ToPage_XHandle = Selector.GetHandle ("convertPoint:toPage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertRect_FromPage_X = "convertRect:fromPage:";
		static readonly NativeHandle selConvertRect_FromPage_XHandle = Selector.GetHandle ("convertRect:fromPage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertRect_ToPage_X = "convertRect:toPage:";
		static readonly NativeHandle selConvertRect_ToPage_XHandle = Selector.GetHandle ("convertRect:toPage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopy_X = "copy:";
		static readonly NativeHandle selCopy_XHandle = Selector.GetHandle ("copy:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentDestinationX = "currentDestination";
		static readonly NativeHandle selCurrentDestinationXHandle = Selector.GetHandle ("currentDestination");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentPageX = "currentPage";
		static readonly NativeHandle selCurrentPageXHandle = Selector.GetHandle ("currentPage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentSelectionX = "currentSelection";
		static readonly NativeHandle selCurrentSelectionXHandle = Selector.GetHandle ("currentSelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplayBoxX = "displayBox";
		static readonly NativeHandle selDisplayBoxXHandle = Selector.GetHandle ("displayBox");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplayDirectionX = "displayDirection";
		static readonly NativeHandle selDisplayDirectionXHandle = Selector.GetHandle ("displayDirection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplayModeX = "displayMode";
		static readonly NativeHandle selDisplayModeXHandle = Selector.GetHandle ("displayMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplaysAsBookX = "displaysAsBook";
		static readonly NativeHandle selDisplaysAsBookXHandle = Selector.GetHandle ("displaysAsBook");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplaysPageBreaksX = "displaysPageBreaks";
		static readonly NativeHandle selDisplaysPageBreaksXHandle = Selector.GetHandle ("displaysPageBreaks");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplaysRTLX = "displaysRTL";
		static readonly NativeHandle selDisplaysRTLXHandle = Selector.GetHandle ("displaysRTL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDocumentX = "document";
		static readonly NativeHandle selDocumentXHandle = Selector.GetHandle ("document");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDocumentViewX = "documentView";
		static readonly NativeHandle selDocumentViewXHandle = Selector.GetHandle ("documentView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawPage_X = "drawPage:";
		static readonly NativeHandle selDrawPage_XHandle = Selector.GetHandle ("drawPage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawPage_ToContext_X = "drawPage:toContext:";
		static readonly NativeHandle selDrawPage_ToContext_XHandle = Selector.GetHandle ("drawPage:toContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawPagePost_X = "drawPagePost:";
		static readonly NativeHandle selDrawPagePost_XHandle = Selector.GetHandle ("drawPagePost:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawPagePost_ToContext_X = "drawPagePost:toContext:";
		static readonly NativeHandle selDrawPagePost_ToContext_XHandle = Selector.GetHandle ("drawPagePost:toContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnableDataDetectorsX = "enableDataDetectors";
		static readonly NativeHandle selEnableDataDetectorsXHandle = Selector.GetHandle ("enableDataDetectors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnablePageShadows_X = "enablePageShadows:";
		static readonly NativeHandle selEnablePageShadows_XHandle = Selector.GetHandle ("enablePageShadows:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoBack_X = "goBack:";
		static readonly NativeHandle selGoBack_XHandle = Selector.GetHandle ("goBack:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoForward_X = "goForward:";
		static readonly NativeHandle selGoForward_XHandle = Selector.GetHandle ("goForward:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoToDestination_X = "goToDestination:";
		static readonly NativeHandle selGoToDestination_XHandle = Selector.GetHandle ("goToDestination:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoToFirstPage_X = "goToFirstPage:";
		static readonly NativeHandle selGoToFirstPage_XHandle = Selector.GetHandle ("goToFirstPage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoToLastPage_X = "goToLastPage:";
		static readonly NativeHandle selGoToLastPage_XHandle = Selector.GetHandle ("goToLastPage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoToNextPage_X = "goToNextPage:";
		static readonly NativeHandle selGoToNextPage_XHandle = Selector.GetHandle ("goToNextPage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoToPage_X = "goToPage:";
		static readonly NativeHandle selGoToPage_XHandle = Selector.GetHandle ("goToPage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoToPreviousPage_X = "goToPreviousPage:";
		static readonly NativeHandle selGoToPreviousPage_XHandle = Selector.GetHandle ("goToPreviousPage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoToRect_OnPage_X = "goToRect:onPage:";
		static readonly NativeHandle selGoToRect_OnPage_XHandle = Selector.GetHandle ("goToRect:onPage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoToSelection_X = "goToSelection:";
		static readonly NativeHandle selGoToSelection_XHandle = Selector.GetHandle ("goToSelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGreekingThresholdX = "greekingThreshold";
		static readonly NativeHandle selGreekingThresholdXHandle = Selector.GetHandle ("greekingThreshold");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHighlightedSelectionsX = "highlightedSelections";
		static readonly NativeHandle selHighlightedSelectionsXHandle = Selector.GetHandle ("highlightedSelections");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_X = "initWithFrame:";
		static readonly NativeHandle selInitWithFrame_XHandle = Selector.GetHandle ("initWithFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInterpolationQualityX = "interpolationQuality";
		static readonly NativeHandle selInterpolationQualityXHandle = Selector.GetHandle ("interpolationQuality");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsInMarkupModeX = "isInMarkupMode";
		static readonly NativeHandle selIsInMarkupModeXHandle = Selector.GetHandle ("isInMarkupMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutDocumentViewX = "layoutDocumentView";
		static readonly NativeHandle selLayoutDocumentViewXHandle = Selector.GetHandle ("layoutDocumentView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxScaleFactorX = "maxScaleFactor";
		static readonly NativeHandle selMaxScaleFactorXHandle = Selector.GetHandle ("maxScaleFactor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMenu_UpdateItem_AtIndex_ShouldCancel_X = "menu:updateItem:atIndex:shouldCancel:";
		static readonly NativeHandle selMenu_UpdateItem_AtIndex_ShouldCancel_XHandle = Selector.GetHandle ("menu:updateItem:atIndex:shouldCancel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMenu_WillHighlightItem_X = "menu:willHighlightItem:";
		static readonly NativeHandle selMenu_WillHighlightItem_XHandle = Selector.GetHandle ("menu:willHighlightItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMenuDidClose_X = "menuDidClose:";
		static readonly NativeHandle selMenuDidClose_XHandle = Selector.GetHandle ("menuDidClose:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMenuHasKeyEquivalent_ForEvent_Target_Action_X = "menuHasKeyEquivalent:forEvent:target:action:";
		static readonly NativeHandle selMenuHasKeyEquivalent_ForEvent_Target_Action_XHandle = Selector.GetHandle ("menuHasKeyEquivalent:forEvent:target:action:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMenuNeedsUpdate_X = "menuNeedsUpdate:";
		static readonly NativeHandle selMenuNeedsUpdate_XHandle = Selector.GetHandle ("menuNeedsUpdate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMenuWillOpen_X = "menuWillOpen:";
		static readonly NativeHandle selMenuWillOpen_XHandle = Selector.GetHandle ("menuWillOpen:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinScaleFactorX = "minScaleFactor";
		static readonly NativeHandle selMinScaleFactorXHandle = Selector.GetHandle ("minScaleFactor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfItemsInMenu_X = "numberOfItemsInMenu:";
		static readonly NativeHandle selNumberOfItemsInMenu_XHandle = Selector.GetHandle ("numberOfItemsInMenu:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPageBreakMarginsX = "pageBreakMargins";
		static readonly NativeHandle selPageBreakMarginsXHandle = Selector.GetHandle ("pageBreakMargins");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPageForPoint_Nearest_X = "pageForPoint:nearest:";
		static readonly NativeHandle selPageForPoint_Nearest_XHandle = Selector.GetHandle ("pageForPoint:nearest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPageOverlayViewProviderX = "pageOverlayViewProvider";
		static readonly NativeHandle selPageOverlayViewProviderXHandle = Selector.GetHandle ("pageOverlayViewProvider");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPageShadowsEnabledX = "pageShadowsEnabled";
		static readonly NativeHandle selPageShadowsEnabledXHandle = Selector.GetHandle ("pageShadowsEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformAction_X = "performAction:";
		static readonly NativeHandle selPerformAction_XHandle = Selector.GetHandle ("performAction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrintWithInfo_AutoRotate_X = "printWithInfo:autoRotate:";
		static readonly NativeHandle selPrintWithInfo_AutoRotate_XHandle = Selector.GetHandle ("printWithInfo:autoRotate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrintWithInfo_AutoRotate_PageScaling_X = "printWithInfo:autoRotate:pageScaling:";
		static readonly NativeHandle selPrintWithInfo_AutoRotate_PageScaling_XHandle = Selector.GetHandle ("printWithInfo:autoRotate:pageScaling:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowSizeForPage_X = "rowSizeForPage:";
		static readonly NativeHandle selRowSizeForPage_XHandle = Selector.GetHandle ("rowSizeForPage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleFactorX = "scaleFactor";
		static readonly NativeHandle selScaleFactorXHandle = Selector.GetHandle ("scaleFactor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleFactorForSizeToFitX = "scaleFactorForSizeToFit";
		static readonly NativeHandle selScaleFactorForSizeToFitXHandle = Selector.GetHandle ("scaleFactorForSizeToFit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollSelectionToVisible_X = "scrollSelectionToVisible:";
		static readonly NativeHandle selScrollSelectionToVisible_XHandle = Selector.GetHandle ("scrollSelectionToVisible:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectAll_X = "selectAll:";
		static readonly NativeHandle selSelectAll_XHandle = Selector.GetHandle ("selectAll:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAcceptsDraggedFiles_X = "setAcceptsDraggedFiles:";
		static readonly NativeHandle selSetAcceptsDraggedFiles_XHandle = Selector.GetHandle ("setAcceptsDraggedFiles:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsDragging_X = "setAllowsDragging:";
		static readonly NativeHandle selSetAllowsDragging_XHandle = Selector.GetHandle ("setAllowsDragging:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutoScales_X = "setAutoScales:";
		static readonly NativeHandle selSetAutoScales_XHandle = Selector.GetHandle ("setAutoScales:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBackgroundColor_X = "setBackgroundColor:";
		static readonly NativeHandle selSetBackgroundColor_XHandle = Selector.GetHandle ("setBackgroundColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCurrentSelection_X = "setCurrentSelection:";
		static readonly NativeHandle selSetCurrentSelection_XHandle = Selector.GetHandle ("setCurrentSelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCurrentSelection_Animate_X = "setCurrentSelection:animate:";
		static readonly NativeHandle selSetCurrentSelection_Animate_XHandle = Selector.GetHandle ("setCurrentSelection:animate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCursorForAreaOfInterest_X = "setCursorForAreaOfInterest:";
		static readonly NativeHandle selSetCursorForAreaOfInterest_XHandle = Selector.GetHandle ("setCursorForAreaOfInterest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDisplayBox_X = "setDisplayBox:";
		static readonly NativeHandle selSetDisplayBox_XHandle = Selector.GetHandle ("setDisplayBox:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDisplayDirection_X = "setDisplayDirection:";
		static readonly NativeHandle selSetDisplayDirection_XHandle = Selector.GetHandle ("setDisplayDirection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDisplayMode_X = "setDisplayMode:";
		static readonly NativeHandle selSetDisplayMode_XHandle = Selector.GetHandle ("setDisplayMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDisplaysAsBook_X = "setDisplaysAsBook:";
		static readonly NativeHandle selSetDisplaysAsBook_XHandle = Selector.GetHandle ("setDisplaysAsBook:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDisplaysPageBreaks_X = "setDisplaysPageBreaks:";
		static readonly NativeHandle selSetDisplaysPageBreaks_XHandle = Selector.GetHandle ("setDisplaysPageBreaks:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDisplaysRTL_X = "setDisplaysRTL:";
		static readonly NativeHandle selSetDisplaysRTL_XHandle = Selector.GetHandle ("setDisplaysRTL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDocument_X = "setDocument:";
		static readonly NativeHandle selSetDocument_XHandle = Selector.GetHandle ("setDocument:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEnableDataDetectors_X = "setEnableDataDetectors:";
		static readonly NativeHandle selSetEnableDataDetectors_XHandle = Selector.GetHandle ("setEnableDataDetectors:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGreekingThreshold_X = "setGreekingThreshold:";
		static readonly NativeHandle selSetGreekingThreshold_XHandle = Selector.GetHandle ("setGreekingThreshold:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHighlightedSelections_X = "setHighlightedSelections:";
		static readonly NativeHandle selSetHighlightedSelections_XHandle = Selector.GetHandle ("setHighlightedSelections:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInMarkupMode_X = "setInMarkupMode:";
		static readonly NativeHandle selSetInMarkupMode_XHandle = Selector.GetHandle ("setInMarkupMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInterpolationQuality_X = "setInterpolationQuality:";
		static readonly NativeHandle selSetInterpolationQuality_XHandle = Selector.GetHandle ("setInterpolationQuality:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaxScaleFactor_X = "setMaxScaleFactor:";
		static readonly NativeHandle selSetMaxScaleFactor_XHandle = Selector.GetHandle ("setMaxScaleFactor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMinScaleFactor_X = "setMinScaleFactor:";
		static readonly NativeHandle selSetMinScaleFactor_XHandle = Selector.GetHandle ("setMinScaleFactor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPageBreakMargins_X = "setPageBreakMargins:";
		static readonly NativeHandle selSetPageBreakMargins_XHandle = Selector.GetHandle ("setPageBreakMargins:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPageOverlayViewProvider_X = "setPageOverlayViewProvider:";
		static readonly NativeHandle selSetPageOverlayViewProvider_XHandle = Selector.GetHandle ("setPageOverlayViewProvider:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetScaleFactor_X = "setScaleFactor:";
		static readonly NativeHandle selSetScaleFactor_XHandle = Selector.GetHandle ("setScaleFactor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShouldAntiAlias_X = "setShouldAntiAlias:";
		static readonly NativeHandle selSetShouldAntiAlias_XHandle = Selector.GetHandle ("setShouldAntiAlias:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldAntiAliasX = "shouldAntiAlias";
		static readonly NativeHandle selShouldAntiAliasXHandle = Selector.GetHandle ("shouldAntiAlias");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTakeBackgroundColorFrom_X = "takeBackgroundColorFrom:";
		static readonly NativeHandle selTakeBackgroundColorFrom_XHandle = Selector.GetHandle ("takeBackgroundColorFrom:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTakePasswordFrom_X = "takePasswordFrom:";
		static readonly NativeHandle selTakePasswordFrom_XHandle = Selector.GetHandle ("takePasswordFrom:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVisiblePagesX = "visiblePages";
		static readonly NativeHandle selVisiblePagesXHandle = Selector.GetHandle ("visiblePages");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selZoomIn_X = "zoomIn:";
		static readonly NativeHandle selZoomIn_XHandle = Selector.GetHandle ("zoomIn:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selZoomOut_X = "zoomOut:";
		static readonly NativeHandle selZoomOut_XHandle = Selector.GetHandle ("zoomOut:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PDFView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="PdfView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PdfView () : base (NSObjectFlag.Empty)
		{
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
		public PdfView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
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
		protected PdfView (NSObjectFlag t) : base (t)
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
		protected internal PdfView (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="frame">Frame used by the view, expressed in iOS points.</param><summary>Initializes the PdfView with the specified frame.</summary><remarks><para>This constructor is used to programmatically create a new instance of PdfView with the specified dimension in the frame.   The object will only be displayed once it has been added to a view hierarchy by calling AddSubview in a containing view.</para><para>This constructor is not invoked when deserializing objects from storyboards or XIB files; instead, the constructor that takes an NSCoder parameter is invoked.</para></remarks>
		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PdfView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selInitWithFrame_XHandle, frame), "initWithFrame:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selInitWithFrame_XHandle, frame), "initWithFrame:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="animation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("animationDidEnd:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AnimationDidEnd (global::AppKit.NSAnimation animation)
		{
			var animation__handle__ = animation!.GetNonNullHandle (nameof (animation));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAnimationDidEnd_XHandle, animation__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAnimationDidEnd_XHandle, animation__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (animation);
		}
		/// <param name="animation">To be added.</param><param name="progress">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("animation:didReachProgressMark:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AnimationDidReachProgressMark (global::AppKit.NSAnimation animation, float progress)
		{
			var animation__handle__ = animation!.GetNonNullHandle (nameof (animation));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float (this.Handle, selAnimation_DidReachProgressMark_XHandle, animation__handle__, progress);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_float (&__objc_super__, selAnimation_DidReachProgressMark_XHandle, animation__handle__, progress);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (animation);
		}
		/// <param name="animation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("animationDidStop:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AnimationDidStop (global::AppKit.NSAnimation animation)
		{
			var animation__handle__ = animation!.GetNonNullHandle (nameof (animation));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAnimationDidStop_XHandle, animation__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAnimationDidStop_XHandle, animation__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (animation);
		}
		/// <param name="animation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("animationShouldStart:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AnimationShouldStart (global::AppKit.NSAnimation animation)
		{
			var animation__handle__ = animation!.GetNonNullHandle (nameof (animation));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selAnimationShouldStart_XHandle, animation__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selAnimationShouldStart_XHandle, animation__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (animation);
			return ret != 0;
		}
		/// <param name="page">The page for which the annotations changed.</param><summary>Method that is called when an annotation on the specified <paramref name="page" /> changes.</summary><remarks>To be added.</remarks>
		[Export ("annotationsChangedOnPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AnnotationsChanged (PdfPage page)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAnnotationsChangedOnPage_XHandle, page__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAnnotationsChangedOnPage_XHandle, page__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
		}
		/// <summary>Clears all selections in the PDF.</summary><remarks>To be added.</remarks>
		[Export ("clearSelection")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClearSelection ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selClearSelectionXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selClearSelectionXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="animation">To be added.</param><param name="progress">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("animation:valueForProgress:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ComputeAnimationCurve (global::AppKit.NSAnimation animation, float progress)
		{
			var animation__handle__ = animation!.GetNonNullHandle (nameof (animation));
			float ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend_NativeHandle_float (this.Handle, selAnimation_ValueForProgress_XHandle, animation__handle__, progress);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper_NativeHandle_float (&__objc_super__, selAnimation_ValueForProgress_XHandle, animation__handle__, progress);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (animation);
			return ret!;
		}
		/// <param name="menu">To be added.</param><param name="screen">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("confinementRectForMenu:onScreen:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConfinementRectForMenu (global::AppKit.NSMenu menu, global::AppKit.NSScreen screen)
		{
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			var screen__handle__ = screen!.GetNonNullHandle (nameof (screen));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selConfinementRectForMenu_OnScreen_XHandle, menu__handle__, screen__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NativeHandle (this.Handle, selConfinementRectForMenu_OnScreen_XHandle, menu__handle__, screen__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selConfinementRectForMenu_OnScreen_XHandle, menu__handle__, screen__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle_NativeHandle (&__objc_super__, selConfinementRectForMenu_OnScreen_XHandle, menu__handle__, screen__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (menu);
			GC.KeepAlive (screen);
			return ret!;
		}
		/// <param name="point">The point to convert.</param><param name="page">The page that contains the point.</param><summary>Converts the provided <paramref name="point" /> from page space to view space.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertPoint:fromPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertPointFromPage (CGPoint point, PdfPage page)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, selConvertPoint_FromPage_XHandle, point, page__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, selConvertPoint_FromPage_XHandle, point, page__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
			return ret!;
		}
		/// <param name="point">The point to convert.</param><param name="page">The page that contains the point.</param><summary>Converts the provided <paramref name="point" /> from view space to page space.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertPoint:toPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertPointToPage (CGPoint point, PdfPage page)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, selConvertPoint_ToPage_XHandle, point, page__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, selConvertPoint_ToPage_XHandle, point, page__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
			return ret!;
		}
		/// <param name="rect">The rectangle to convert.</param><param name="page">The page that contains the rectangle.</param><summary>Converts the provided rectangle from page space to view space.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertRect:fromPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConvertRectangleFromPage (CGRect rect, PdfPage page)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (this.Handle, selConvertRect_FromPage_XHandle, rect, page__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, selConvertRect_FromPage_XHandle, rect, page__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selConvertRect_FromPage_XHandle, rect, page__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect_NativeHandle (&__objc_super__, selConvertRect_FromPage_XHandle, rect, page__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (page);
			return ret!;
		}
		/// <param name="rect">The rectangle to convert.</param><param name="page">The page that contains the rectangle.</param><summary>Converts the provided rectangle from view space to page space.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertRect:toPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConvertRectangleToPage (CGRect rect, PdfPage page)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (this.Handle, selConvertRect_ToPage_XHandle, rect, page__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, selConvertRect_ToPage_XHandle, rect, page__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selConvertRect_ToPage_XHandle, rect, page__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect_NativeHandle (&__objc_super__, selConvertRect_ToPage_XHandle, rect, page__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (page);
			return ret!;
		}
		/// <param name="sender"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("copy:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Copy (NSObject? sender)
		{
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCopy_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopy_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <param name="page">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawPage:")]
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("macos10.12")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawPage (PdfPage page)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDrawPage_XHandle, page__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDrawPage_XHandle, page__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
		}
		/// <param name="page">To be added.</param><param name="context">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawPage:toContext:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawPage (PdfPage page, CGContext context)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDrawPage_ToContext_XHandle, page__handle__, context.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDrawPage_ToContext_XHandle, page__handle__, context.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
			GC.KeepAlive (context);
		}
		/// <param name="page">To be added.</param><param name="context">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawPagePost:toContext:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawPagePost (PdfPage page, CGContext context)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDrawPagePost_ToContext_XHandle, page__handle__, context.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDrawPagePost_ToContext_XHandle, page__handle__, context.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
			GC.KeepAlive (context);
		}
		/// <param name="page">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawPagePost:")]
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("macos10.12")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawPagePost (PdfPage page)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDrawPagePost_XHandle, page__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDrawPagePost_XHandle, page__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
		}
		/// <param name="mouseEvent">The mouse event for which to obtain the area of interest.</param><summary>Returns the area of interest for the current cursor position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("areaOfInterestForMouse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfAreaOfInterest GetAreaOfInterest (global::AppKit.NSEvent mouseEvent)
		{
			var mouseEvent__handle__ = mouseEvent!.GetNonNullHandle (nameof (mouseEvent));
			PdfAreaOfInterest ret;
			if (IsDirectBinding) {
				ret = (PdfKit.PdfAreaOfInterest) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selAreaOfInterestForMouse_XHandle, mouseEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (PdfKit.PdfAreaOfInterest) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selAreaOfInterestForMouse_XHandle, mouseEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mouseEvent);
			return ret!;
		}
		/// <param name="point">The point for which to obtain the area of interest</param><summary>Returns the area of interest for the specified point.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("areaOfInterestForPoint:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfAreaOfInterest GetAreaOfInterest (CGPoint point)
		{
			PdfAreaOfInterest ret;
			if (IsDirectBinding) {
				ret = (PdfKit.PdfAreaOfInterest) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGPoint (this.Handle, selAreaOfInterestForPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (PdfKit.PdfAreaOfInterest) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGPoint (&__objc_super__, selAreaOfInterestForPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		/// <param name="point">The point for which to return a page.</param><param name="nearest">Whether to return the nearest page if the point is not on a page.</param><summary>Returns the page for the point, or the nearest page if <paramref name="nearest" /> is <see langword="true" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pageForPoint:nearest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfPage? GetPage (CGPoint point, bool nearest)
		{
			PdfPage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PdfPage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_bool (this.Handle, selPageForPoint_Nearest_XHandle, point, nearest ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<PdfPage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint_bool (&__objc_super__, selPageForPoint_Nearest_XHandle, point, nearest ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="sender">The object that requested the operation.</param><summary>Goes back one page in the history.</summary><remarks>To be added.</remarks>
		[Export ("goBack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GoBack (NSObject? sender)
		{
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selGoBack_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selGoBack_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <param name="sender">The object that requested the operation.</param><summary>Goes forward one page in the history.</summary><remarks>To be added.</remarks>
		[Export ("goForward:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GoForward (NSObject? sender)
		{
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selGoForward_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selGoForward_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <param name="destination">The destination to which to go.</param><summary>Goes to the specified <paramref name="destination" />.</summary><remarks>To be added.</remarks>
		[Export ("goToDestination:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GoToDestination (PdfDestination destination)
		{
			var destination__handle__ = destination!.GetNonNullHandle (nameof (destination));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selGoToDestination_XHandle, destination__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selGoToDestination_XHandle, destination__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (destination);
		}
		/// <param name="sender">The object that requested the operation.</param><summary>Goes to the first page of the PDF.</summary><remarks>To be added.</remarks>
		[Export ("goToFirstPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GoToFirstPage (NSObject? sender)
		{
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selGoToFirstPage_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selGoToFirstPage_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <param name="sender">The object that requested the operation..</param><summary>Goes to the last page of the PDF.</summary><remarks>To be added.</remarks>
		[Export ("goToLastPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GoToLastPage (NSObject? sender)
		{
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selGoToLastPage_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selGoToLastPage_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <param name="sender">The object that requested the operation.</param><summary>Goes to the next page in the PDF.</summary><remarks>To be added.</remarks>
		[Export ("goToNextPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GoToNextPage (NSObject? sender)
		{
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selGoToNextPage_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selGoToNextPage_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <param name="page">The page to which to go.</param><summary>Goes to the specified page.</summary><remarks>To be added.</remarks>
		[Export ("goToPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GoToPage (PdfPage page)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selGoToPage_XHandle, page__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selGoToPage_XHandle, page__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
		}
		/// <param name="sender">The object that requested the operation.</param><summary>Goes to the previous page in the PDF.</summary><remarks>To be added.</remarks>
		[Export ("goToPreviousPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GoToPreviousPage (NSObject? sender)
		{
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selGoToPreviousPage_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selGoToPreviousPage_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <param name="rect">The rectangle to which to go.</param><param name="page">The page that contains the rectangle.</param><summary>Goes to the specified rectangle on the specified page.</summary><remarks>To be added.</remarks>
		[Export ("goToRect:onPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GoToRectangle (CGRect rect, PdfPage page)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle (this.Handle, selGoToRect_OnPage_XHandle, rect, page__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selGoToRect_OnPage_XHandle, rect, page__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
		}
		/// <param name="selection">The selection to which to go.</param><summary>Goes to the specified selection.</summary><remarks>To be added.</remarks>
		[Export ("goToSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GoToSelection (PdfSelection selection)
		{
			var selection__handle__ = selection!.GetNonNullHandle (nameof (selection));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selGoToSelection_XHandle, selection__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selGoToSelection_XHandle, selection__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (selection);
		}
		/// <param name="menu">To be added.</param><param name="theEvent">To be added.</param><param name="target">To be added.</param><param name="action">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("menuHasKeyEquivalent:forEvent:target:action:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasKeyEquivalentForEvent (global::AppKit.NSMenu menu, global::AppKit.NSEvent theEvent, NSObject target, Selector action)
		{
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selMenuHasKeyEquivalent_ForEvent_Target_Action_XHandle, menu__handle__, theEvent__handle__, target__handle__, action.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selMenuHasKeyEquivalent_ForEvent_Target_Action_XHandle, menu__handle__, theEvent__handle__, target__handle__, action.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (menu);
			GC.KeepAlive (theEvent);
			GC.KeepAlive (target);
			GC.KeepAlive (action);
			return ret != 0;
		}
		/// <summary>Lays out the document view.</summary><remarks>To be added.</remarks>
		[Export ("layoutDocumentView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LayoutDocumentView ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selLayoutDocumentViewXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selLayoutDocumentViewXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="menu">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("menuDidClose:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MenuDidClose (global::AppKit.NSMenu menu)
		{
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMenuDidClose_XHandle, menu__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMenuDidClose_XHandle, menu__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (menu);
		}
		/// <param name="menu">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfItemsInMenu:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint MenuItemCount (global::AppKit.NSMenu menu)
		{
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selNumberOfItemsInMenu_XHandle, menu__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selNumberOfItemsInMenu_XHandle, menu__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (menu);
			return ret!;
		}
		/// <param name="menu">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("menu:willHighlightItem:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MenuWillHighlightItem (global::AppKit.NSMenu menu, global::AppKit.NSMenuItem item)
		{
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selMenu_WillHighlightItem_XHandle, menu__handle__, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selMenu_WillHighlightItem_XHandle, menu__handle__, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (menu);
			GC.KeepAlive (item);
		}
		/// <param name="menu">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("menuWillOpen:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MenuWillOpen (global::AppKit.NSMenu menu)
		{
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMenuWillOpen_XHandle, menu__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMenuWillOpen_XHandle, menu__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (menu);
		}
		/// <param name="menu">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("menuNeedsUpdate:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NeedsUpdate (global::AppKit.NSMenu menu)
		{
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMenuNeedsUpdate_XHandle, menu__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMenuNeedsUpdate_XHandle, menu__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (menu);
		}
		/// <param name="action">The action to perform</param><summary>Performs the action.</summary><remarks>To be added.</remarks>
		[Export ("performAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformAction (PdfAction action)
		{
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPerformAction_XHandle, action__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPerformAction_XHandle, action__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (action);
		}
		/// <param name="printInfo">To be added.</param><param name="doRotate">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("printWithInfo:autoRotate:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Print (global::AppKit.NSPrintInfo printInfo, bool doRotate)
		{
			var printInfo__handle__ = printInfo!.GetNonNullHandle (nameof (printInfo));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selPrintWithInfo_AutoRotate_XHandle, printInfo__handle__, doRotate ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selPrintWithInfo_AutoRotate_XHandle, printInfo__handle__, doRotate ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (printInfo);
		}
		/// <param name="printInfo">To be added.</param><param name="doRotate">To be added.</param><param name="scaleMode">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("printWithInfo:autoRotate:pageScaling:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Print (global::AppKit.NSPrintInfo printInfo, bool doRotate, PdfPrintScalingMode scaleMode)
		{
			var printInfo__handle__ = printInfo!.GetNonNullHandle (nameof (printInfo));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool_IntPtr (this.Handle, selPrintWithInfo_AutoRotate_PageScaling_XHandle, printInfo__handle__, doRotate ? (byte) 1 : (byte) 0, (IntPtr) (long) scaleMode);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool_IntPtr (&__objc_super__, selPrintWithInfo_AutoRotate_PageScaling_XHandle, printInfo__handle__, doRotate ? (byte) 1 : (byte) 0, (IntPtr) (long) scaleMode);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (printInfo);
		}
		/// <param name="page">The page for which to get the row size.</param><summary>Returns the display size of a row on the specified <paramref name="page" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rowSizeForPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize RowSize (PdfPage page)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			CGSize ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle (this.Handle, selRowSizeForPage_XHandle, page__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper_NativeHandle (&__objc_super__, selRowSizeForPage_XHandle, page__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
			return ret!;
		}
		/// <param name="sender">The object that requested the operation.</param><summary>Scrolls the current selection into view.</summary><remarks>To be added.</remarks>
		[Export ("scrollSelectionToVisible:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollSelectionToVisible (NSObject? sender)
		{
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selScrollSelectionToVisible_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selScrollSelectionToVisible_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <param name="sender"><para>The object that requested the operation.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Selects all the text.</summary><remarks>To be added.</remarks>
		[Export ("selectAll:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectAll (NSObject? sender)
		{
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
		/// <param name="selection">The selection to make current.</param><param name="animate">Whether to animate the selection operation.</param><summary>Sets the current selection with an optional animation.</summary><remarks>To be added.</remarks>
		[Export ("setCurrentSelection:animate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCurrentSelection (PdfSelection? selection, bool animate)
		{
			var selection__handle__ = selection.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selSetCurrentSelection_Animate_XHandle, selection__handle__, animate ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selSetCurrentSelection_Animate_XHandle, selection__handle__, animate ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (selection);
		}
		/// <param name="area">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setCursorForAreaOfInterest:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCursor (PdfAreaOfInterest area)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCursorForAreaOfInterest_XHandle, (IntPtr) (long) area);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetCursorForAreaOfInterest_XHandle, (IntPtr) (long) area);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("takeBackgroundColorFrom:")]
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("macos10.12")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TakeBackgroundColor (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTakeBackgroundColorFrom_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTakeBackgroundColorFrom_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("takePasswordFrom:")]
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("macos10.12")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TakePasswordFrom (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTakePasswordFrom_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTakePasswordFrom_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <param name="menu">To be added.</param><param name="item">To be added.</param><param name="atIndex">To be added.</param><param name="shouldCancel">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("menu:updateItem:atIndex:shouldCancel:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UpdateItem (global::AppKit.NSMenu menu, global::AppKit.NSMenuItem item, nint atIndex, bool shouldCancel)
		{
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr_bool (this.Handle, selMenu_UpdateItem_AtIndex_ShouldCancel_XHandle, menu__handle__, item__handle__, atIndex, shouldCancel ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr_bool (&__objc_super__, selMenu_UpdateItem_AtIndex_ShouldCancel_XHandle, menu__handle__, item__handle__, atIndex, shouldCancel ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (menu);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="sender">The object that requested the operation.</param><summary>Zooms in one level.</summary><remarks>To be added.</remarks>
		[Export ("zoomIn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ZoomIn (NSObject? sender)
		{
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selZoomIn_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selZoomIn_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <param name="sender">The object that requested the operation.</param><summary>Zooms out one level.</summary><remarks>To be added.</remarks>
		[Export ("zoomOut:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ZoomOut (NSObject? sender)
		{
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selZoomOut_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selZoomOut_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AcceptsDraggedFiles {
			[Export ("acceptsDraggedFiles")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAcceptsDraggedFilesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAcceptsDraggedFilesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAcceptsDraggedFiles:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAcceptsDraggedFiles_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAcceptsDraggedFiles_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("macos10.13")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AllowsDragging {
			[Export ("allowsDragging")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsDraggingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsDraggingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsDragging:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsDragging_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsDragging_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the pages of the PDF autoscale to fit the view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutoScales {
			[Export ("autoScales")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAutoScalesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAutoScalesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutoScales:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutoScales_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutoScales_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the background color for the view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSColor BackgroundColor {
			[Export ("backgroundColor")]
			get {
				global::AppKit.NSColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBackgroundColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBackgroundColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBackgroundColor:")]
			set {
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
		/// <summary>Gets a Boolean value that tells whether the view can navigate back one page.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanGoBack {
			[Export ("canGoBack")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanGoBackXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanGoBackXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the view can navigate forward one page.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanGoForward {
			[Export ("canGoForward")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanGoForwardXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanGoForwardXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the view can navigate to the first page.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanGoToFirstPage {
			[Export ("canGoToFirstPage")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanGoToFirstPageXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanGoToFirstPageXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the view can navigate to the last page.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanGoToLastPage {
			[Export ("canGoToLastPage")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanGoToLastPageXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanGoToLastPageXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the view can navigate to the next page.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanGoToNextPage {
			[Export ("canGoToNextPage")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanGoToNextPageXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanGoToNextPageXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the view can navigate to the previous page.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanGoToPreviousPage {
			[Export ("canGoToPreviousPage")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanGoToPreviousPageXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanGoToPreviousPageXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the view can zoom in.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanZoomIn {
			[Export ("canZoomIn")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanZoomInXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanZoomInXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the view can zoom out.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanZoomOut {
			[Export ("canZoomOut")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanZoomOutXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanZoomOutXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets the currently displayed location.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfDestination? CurrentDestination {
			[Export ("currentDestination")]
			get {
				PdfDestination? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PdfDestination> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentDestinationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PdfDestination> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentDestinationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the currently displayed page.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfPage? CurrentPage {
			[Export ("currentPage")]
			get {
				PdfPage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PdfPage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentPageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PdfPage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentPageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets the current selection.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfSelection? CurrentSelection {
			[Export ("currentSelection")]
			get {
				PdfSelection? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentSelectionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentSelectionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCurrentSelection:")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCurrentSelection_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCurrentSelection_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>An instance of the PdfKit.IPdfViewDelegate model class which acts as the class delegate.</summary><value>The instance of the PdfKit.IPdfViewDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IPdfViewDelegate Delegate {
			get {
				return (WeakDelegate as IPdfViewDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		/// <summary>Gets or sets the display box style.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfDisplayBox DisplayBox {
			[Export ("displayBox")]
			get {
				PdfDisplayBox ret;
				if (IsDirectBinding) {
					ret = (PdfKit.PdfDisplayBox) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDisplayBoxXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (PdfKit.PdfDisplayBox) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selDisplayBoxXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDisplayBox:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDisplayBox_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetDisplayBox_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		public virtual PdfDisplayDirection DisplayDirection {
			[Export ("displayDirection")]
			get {
				PdfDisplayDirection ret;
				if (IsDirectBinding) {
					ret = (PdfKit.PdfDisplayDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDisplayDirectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (PdfKit.PdfDisplayDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selDisplayDirectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDisplayDirection:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDisplayDirection_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetDisplayDirection_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the display mode.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfDisplayMode DisplayMode {
			[Export ("displayMode")]
			get {
				PdfDisplayMode ret;
				if (IsDirectBinding) {
					ret = (PdfKit.PdfDisplayMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDisplayModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (PdfKit.PdfDisplayMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selDisplayModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDisplayMode:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDisplayMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetDisplayMode_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the first page is displayed as a book cover for two-up or two-up continuous display.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DisplaysAsBook {
			[Export ("displaysAsBook")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDisplaysAsBookXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDisplaysAsBookXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDisplaysAsBook:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDisplaysAsBook_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDisplaysAsBook_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether page breaks will be displayed.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DisplaysPageBreaks {
			[Export ("displaysPageBreaks")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDisplaysPageBreaksXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDisplaysPageBreaksXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDisplaysPageBreaks:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDisplaysPageBreaks_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDisplaysPageBreaks_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		public virtual bool DisplaysRtl {
			[Export ("displaysRTL")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDisplaysRTLXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDisplaysRTLXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDisplaysRTL:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDisplaysRTL_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDisplaysRTL_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the document to display.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfDocument? Document {
			[Export ("document")]
			get {
				PdfDocument? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PdfDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDocumentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PdfDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDocumentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDocument:")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDocument_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDocument_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets the innermost view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSView? DocumentView {
			[Export ("documentView")]
			get {
				global::AppKit.NSView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AppKit.NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDocumentViewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AppKit.NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDocumentViewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("tvos18.2")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool EnableDataDetectors {
			[Export ("enableDataDetectors")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selEnableDataDetectorsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selEnableDataDetectorsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEnableDataDetectors:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEnableDataDetectors_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetEnableDataDetectors_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Developers should not use this deprecated property. </summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("macos10.12")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual nfloat GreekingThreshold {
			[Export ("greekingThreshold")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selGreekingThresholdXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selGreekingThresholdXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setGreekingThreshold:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetGreekingThreshold_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetGreekingThreshold_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the currently highlighted selections.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfSelection[]? HighlightedSelections {
			[Export ("highlightedSelections")]
			get {
				PdfSelection[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<PdfSelection>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHighlightedSelectionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<PdfSelection>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHighlightedSelectionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setHighlightedSelections:")]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetHighlightedSelections_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetHighlightedSelections_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos18.2")]
		public virtual bool InMarkupMode {
			[Export ("isInMarkupMode")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsInMarkupModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsInMarkupModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setInMarkupMode:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetInMarkupMode_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetInMarkupMode_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfInterpolationQuality InterpolationQuality {
			[Export ("interpolationQuality", ArgumentSemantic.Assign)]
			get {
				PdfInterpolationQuality ret;
				if (IsDirectBinding) {
					ret = (PdfKit.PdfInterpolationQuality) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selInterpolationQualityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (PdfKit.PdfInterpolationQuality) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selInterpolationQualityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInterpolationQuality:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetInterpolationQuality_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetInterpolationQuality_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		public virtual nfloat MaxScaleFactor {
			[Export ("maxScaleFactor")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selMaxScaleFactorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selMaxScaleFactorXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaxScaleFactor:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetMaxScaleFactor_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetMaxScaleFactor_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		public virtual nfloat MinScaleFactor {
			[Export ("minScaleFactor")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selMinScaleFactorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selMinScaleFactorXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinScaleFactor:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetMinScaleFactor_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetMinScaleFactor_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		public virtual global::AppKit.NSEdgeInsets PageBreakMargins {
			[Export ("pageBreakMargins")]
			get {
				global::AppKit.NSEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSend (this.Handle, selPageBreakMarginsXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSend_stret (this.Handle, selPageBreakMarginsXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSendSuper (&__objc_super__, selPageBreakMarginsXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, selPageBreakMarginsXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setPageBreakMargins:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NSEdgeInsets (this.Handle, selSetPageBreakMargins_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSEdgeInsets (&__objc_super__, selSetPageBreakMargins_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_PageOverlayViewProvider_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos18.2")]
		public virtual IPdfPageOverlayViewProvider? PageOverlayViewProvider {
			[Export ("pageOverlayViewProvider", ArgumentSemantic.Weak)]
			get {
				IPdfPageOverlayViewProvider? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPdfPageOverlayViewProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPageOverlayViewProviderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IPdfPageOverlayViewProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPageOverlayViewProviderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_PageOverlayViewProvider_var = ret;
				return ret!;
			}
			[Export ("setPageOverlayViewProvider:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPageOverlayViewProvider_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPageOverlayViewProvider_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_PageOverlayViewProvider_var = value;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		public virtual bool PageShadowsEnabled {
			[Export ("pageShadowsEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPageShadowsEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selPageShadowsEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("enablePageShadows:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selEnablePageShadows_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selEnablePageShadows_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the view scale factor.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat ScaleFactor {
			[Export ("scaleFactor")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selScaleFactorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selScaleFactorXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setScaleFactor:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetScaleFactor_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetScaleFactor_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the scale factor that would fit the current PDF page(s) in the view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		public virtual nfloat ScaleFactorForSizeToFit {
			[Export ("scaleFactorForSizeToFit")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selScaleFactorForSizeToFitXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selScaleFactorForSizeToFitXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("macos10.12")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool ShouldAntiAlias {
			[Export ("shouldAntiAlias")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldAntiAliasXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShouldAntiAliasXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShouldAntiAlias:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldAntiAlias_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShouldAntiAlias_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Returns the currently visible pages.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfPage[] VisiblePages {
			[Export ("visiblePages")]
			get {
				PdfPage[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<PdfPage>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVisiblePagesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<PdfPage>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVisiblePagesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		/// <summary>An object that can respond to the delegate protocol for this type</summary><value>The instance that will respond to events and data requests.</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
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
		static NSString? _AnnotationHitNotification;
		/// <summary>Notification constant for AnnotationHit</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveAnnotationHit(NSObject,EventHandler{PdfViewAnnotationHitEventArgs})" />
		///     or <see cref="Notifications.ObserveAnnotationHit(EventHandler{PdfViewAnnotationHitEventArgs})" /> methods,
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
		/// notification = PdfView.Notifications.ObserveAnnotationHit ((sender, args) => {
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
		/// void Callback (object sender, PdfView.PdfViewAnnotationHitEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfView.Notifications.ObserveAnnotationHit (Callback);
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
		///     PdfView.AnnotationHitNotification, (notification) => { Console.WriteLine ("Received the notification AnnotationHit", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification AnnotationHit", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfView.AnnotationHitNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFViewAnnotationHitNotification",  "Quartz")]
		[Advice ("Use PdfView.Notifications.ObserveAnnotationHit helper method instead.")]
		public static NSString AnnotationHitNotification {
			get {
				if (_AnnotationHitNotification is null)
					_AnnotationHitNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFViewAnnotationHitNotification")!;
				return _AnnotationHitNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnnotationWillHitNotification;
		/// <summary>Notification constant for AnnotationWillHit</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveAnnotationWillHit(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveAnnotationWillHit(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfView.Notifications.ObserveAnnotationWillHit ((sender, args) => {
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
		/// void Callback (object sender, PdfView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfView.Notifications.ObserveAnnotationWillHit (Callback);
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
		///     PdfView.AnnotationWillHitNotification, (notification) => { Console.WriteLine ("Received the notification AnnotationWillHit", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification AnnotationWillHit", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfView.AnnotationWillHitNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFViewAnnotationWillHitNotification",  "Quartz")]
		[Advice ("Use PdfView.Notifications.ObserveAnnotationWillHit helper method instead.")]
		public static NSString AnnotationWillHitNotification {
			get {
				if (_AnnotationWillHitNotification is null)
					_AnnotationWillHitNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFViewAnnotationWillHitNotification")!;
				return _AnnotationWillHitNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChangedHistoryNotification;
		/// <summary>Notification constant for ChangedHistory</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveChangedHistory(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveChangedHistory(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfView.Notifications.ObserveChangedHistory ((sender, args) => {
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
		/// void Callback (object sender, PdfView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfView.Notifications.ObserveChangedHistory (Callback);
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
		///     PdfView.ChangedHistoryNotification, (notification) => { Console.WriteLine ("Received the notification ChangedHistory", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ChangedHistory", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfView.ChangedHistoryNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFViewChangedHistoryNotification",  "Quartz")]
		[Advice ("Use PdfView.Notifications.ObserveChangedHistory helper method instead.")]
		public static NSString ChangedHistoryNotification {
			get {
				if (_ChangedHistoryNotification is null)
					_ChangedHistoryNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFViewChangedHistoryNotification")!;
				return _ChangedHistoryNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CopyPermissionNotification;
		/// <summary>Notification constant for CopyPermission</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveCopyPermission(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveCopyPermission(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfView.Notifications.ObserveCopyPermission ((sender, args) => {
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
		/// void Callback (object sender, PdfView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfView.Notifications.ObserveCopyPermission (Callback);
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
		///     PdfView.CopyPermissionNotification, (notification) => { Console.WriteLine ("Received the notification CopyPermission", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification CopyPermission", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfView.CopyPermissionNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFViewCopyPermissionNotification",  "Quartz")]
		[Advice ("Use PdfView.Notifications.ObserveCopyPermission helper method instead.")]
		public static NSString CopyPermissionNotification {
			get {
				if (_CopyPermissionNotification is null)
					_CopyPermissionNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFViewCopyPermissionNotification")!;
				return _CopyPermissionNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisplayBoxChangedNotification;
		/// <summary>Notification constant for DisplayBoxChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDisplayBoxChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDisplayBoxChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfView.Notifications.ObserveDisplayBoxChanged ((sender, args) => {
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
		/// void Callback (object sender, PdfView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfView.Notifications.ObserveDisplayBoxChanged (Callback);
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
		///     PdfView.DisplayBoxChangedNotification, (notification) => { Console.WriteLine ("Received the notification DisplayBoxChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DisplayBoxChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfView.DisplayBoxChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFViewDisplayBoxChangedNotification",  "Quartz")]
		[Advice ("Use PdfView.Notifications.ObserveDisplayBoxChanged helper method instead.")]
		public static NSString DisplayBoxChangedNotification {
			get {
				if (_DisplayBoxChangedNotification is null)
					_DisplayBoxChangedNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFViewDisplayBoxChangedNotification")!;
				return _DisplayBoxChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisplayModeChangedNotification;
		/// <summary>Notification constant for DisplayModeChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDisplayModeChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDisplayModeChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfView.Notifications.ObserveDisplayModeChanged ((sender, args) => {
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
		/// void Callback (object sender, PdfView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfView.Notifications.ObserveDisplayModeChanged (Callback);
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
		///     PdfView.DisplayModeChangedNotification, (notification) => { Console.WriteLine ("Received the notification DisplayModeChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DisplayModeChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfView.DisplayModeChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFViewDisplayModeChangedNotification",  "Quartz")]
		[Advice ("Use PdfView.Notifications.ObserveDisplayModeChanged helper method instead.")]
		public static NSString DisplayModeChangedNotification {
			get {
				if (_DisplayModeChangedNotification is null)
					_DisplayModeChangedNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFViewDisplayModeChangedNotification")!;
				return _DisplayModeChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DocumentChangedNotification;
		/// <summary>Notification constant for DocumentChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDocumentChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDocumentChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfView.Notifications.ObserveDocumentChanged ((sender, args) => {
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
		/// void Callback (object sender, PdfView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfView.Notifications.ObserveDocumentChanged (Callback);
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
		///     PdfView.DocumentChangedNotification, (notification) => { Console.WriteLine ("Received the notification DocumentChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DocumentChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfView.DocumentChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFViewDocumentChangedNotification",  "Quartz")]
		[Advice ("Use PdfView.Notifications.ObserveDocumentChanged helper method instead.")]
		public static NSString DocumentChangedNotification {
			get {
				if (_DocumentChangedNotification is null)
					_DocumentChangedNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFViewDocumentChangedNotification")!;
				return _DocumentChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PageChangedNotification;
		/// <summary>Notification constant for PageChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObservePageChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObservePageChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfView.Notifications.ObservePageChanged ((sender, args) => {
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
		/// void Callback (object sender, PdfView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfView.Notifications.ObservePageChanged (Callback);
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
		///     PdfView.PageChangedNotification, (notification) => { Console.WriteLine ("Received the notification PageChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification PageChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfView.PageChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFViewPageChangedNotification",  "Quartz")]
		[Advice ("Use PdfView.Notifications.ObservePageChanged helper method instead.")]
		public static NSString PageChangedNotification {
			get {
				if (_PageChangedNotification is null)
					_PageChangedNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFViewPageChangedNotification")!;
				return _PageChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PrintPermissionNotification;
		/// <summary>Notification constant for PrintPermission</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObservePrintPermission(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObservePrintPermission(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfView.Notifications.ObservePrintPermission ((sender, args) => {
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
		/// void Callback (object sender, PdfView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfView.Notifications.ObservePrintPermission (Callback);
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
		///     PdfView.PrintPermissionNotification, (notification) => { Console.WriteLine ("Received the notification PrintPermission", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification PrintPermission", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfView.PrintPermissionNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFViewPrintPermissionNotification",  "Quartz")]
		[Advice ("Use PdfView.Notifications.ObservePrintPermission helper method instead.")]
		public static NSString PrintPermissionNotification {
			get {
				if (_PrintPermissionNotification is null)
					_PrintPermissionNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFViewPrintPermissionNotification")!;
				return _PrintPermissionNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScaleChangedNotification;
		/// <summary>Notification constant for ScaleChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveScaleChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveScaleChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfView.Notifications.ObserveScaleChanged ((sender, args) => {
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
		/// void Callback (object sender, PdfView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfView.Notifications.ObserveScaleChanged (Callback);
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
		///     PdfView.ScaleChangedNotification, (notification) => { Console.WriteLine ("Received the notification ScaleChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ScaleChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfView.ScaleChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFViewScaleChangedNotification",  "Quartz")]
		[Advice ("Use PdfView.Notifications.ObserveScaleChanged helper method instead.")]
		public static NSString ScaleChangedNotification {
			get {
				if (_ScaleChangedNotification is null)
					_ScaleChangedNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFViewScaleChangedNotification")!;
				return _ScaleChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectionChangedNotification;
		/// <summary>Notification constant for SelectionChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveSelectionChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveSelectionChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfView.Notifications.ObserveSelectionChanged ((sender, args) => {
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
		/// void Callback (object sender, PdfView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfView.Notifications.ObserveSelectionChanged (Callback);
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
		///     PdfView.SelectionChangedNotification, (notification) => { Console.WriteLine ("Received the notification SelectionChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification SelectionChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfView.SelectionChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFViewSelectionChangedNotification",  "Quartz")]
		[Advice ("Use PdfView.Notifications.ObserveSelectionChanged helper method instead.")]
		public static NSString SelectionChangedNotification {
			get {
				if (_SelectionChangedNotification is null)
					_SelectionChangedNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFViewSelectionChangedNotification")!;
				return _SelectionChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VisiblePagesChangedNotification;
		/// <summary>Notification constant for VisiblePagesChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveVisiblePagesChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveVisiblePagesChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfView.Notifications.ObserveVisiblePagesChanged ((sender, args) => {
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
		/// void Callback (object sender, PdfView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfView.Notifications.ObserveVisiblePagesChanged (Callback);
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
		///     PdfView.VisiblePagesChangedNotification, (notification) => { Console.WriteLine ("Received the notification VisiblePagesChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification VisiblePagesChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfView.VisiblePagesChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFViewVisiblePagesChangedNotification",  "Quartz")]
		[Advice ("Use PdfView.Notifications.ObserveVisiblePagesChanged helper method instead.")]
		public static NSString VisiblePagesChangedNotification {
			get {
				if (_VisiblePagesChangedNotification is null)
					_VisiblePagesChangedNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFViewVisiblePagesChangedNotification")!;
				return _VisiblePagesChangedNotification;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_PdfViewDelegate); }
		}
		internal virtual _PdfViewDelegate CreateInternalEventDelegateType ()
		{
			return (_PdfViewDelegate)(new _PdfViewDelegate());
		}
		internal _PdfViewDelegate EnsurePdfViewDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _PdfViewDelegate;
			if (del is null){
				del = (_PdfViewDelegate)CreateInternalEventDelegateType ();
				Delegate = (IPdfViewDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _PdfViewDelegate : NSObject, IPdfViewDelegate { 
			public _PdfViewDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_PdfViewDelegate))]
			static _PdfViewDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<PdfViewActionEventArgs>? openPdf;
			[Export ("PDFViewOpenPDF:forRemoteGoToAction:")]
			public void OpenPdf (PdfKit.PdfView sender, PdfKit.PdfActionRemoteGoTo action)
			{
				var handler = openPdf;
				if (handler is not null){
					var args = new PdfViewActionEventArgs (action);
					handler (sender, args);
				}
			}
			internal EventHandler? performFind;
			[Export ("PDFViewPerformFind:")]
			public void PerformFind (PdfKit.PdfView sender)
			{
				var handler = performFind;
				if (handler is not null){
					handler (sender, EventArgs.Empty);
				}
			}
			internal EventHandler? performGoToPage;
			[Export ("PDFViewPerformGoToPage:")]
			public void PerformGoToPage (PdfKit.PdfView sender)
			{
				var handler = performGoToPage;
				if (handler is not null){
					handler (sender, EventArgs.Empty);
				}
			}
			internal EventHandler? performPrint;
			[Export ("PDFViewPerformPrint:")]
			public void PerformPrint (PdfKit.PdfView sender)
			{
				var handler = performPrint;
				if (handler is not null){
					handler (sender, EventArgs.Empty);
				}
			}
			internal PdfViewTitle? titleOfPrintJob;
			[Export ("PDFViewPrintJobTitle:")]
			public string TitleOfPrintJob (PdfKit.PdfView sender)
			{
				var handler = titleOfPrintJob;
				if (handler is not null)
					return handler (sender);
				return String.Empty!;
			}
			internal PdfViewScale? willChangeScaleFactor;
			[Export ("PDFViewWillChangeScaleFactor:toScale:")]
			public NFloat WillChangeScaleFactor (PdfKit.PdfView sender, NFloat scale)
			{
				var handler = willChangeScaleFactor;
				if (handler is not null)
					return handler (sender, scale);
				return scale!;
			}
			internal EventHandler<PdfViewUrlEventArgs>? willClickOnLink;
			[Export ("PDFViewWillClickOnLink:withURL:")]
			public void WillClickOnLink (PdfKit.PdfView sender, NSUrl url)
			{
				var handler = willClickOnLink;
				if (handler is not null){
					var args = new PdfViewUrlEventArgs (url);
					handler (sender, args);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<PdfViewActionEventArgs> OpenPdf {
			add { EnsurePdfViewDelegate ()!.openPdf += value; }
			remove { EnsurePdfViewDelegate ()!.openPdf -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler PerformFind {
			add { EnsurePdfViewDelegate ()!.performFind += value; }
			remove { EnsurePdfViewDelegate ()!.performFind -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler PerformGoToPage {
			add { EnsurePdfViewDelegate ()!.performGoToPage += value; }
			remove { EnsurePdfViewDelegate ()!.performGoToPage -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler PerformPrint {
			add { EnsurePdfViewDelegate ()!.performPrint += value; }
			remove { EnsurePdfViewDelegate ()!.performPrint -= value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public PdfViewTitle? TitleOfPrintJob {
			get { return EnsurePdfViewDelegate ()!.titleOfPrintJob; }
			set { EnsurePdfViewDelegate ()!.titleOfPrintJob = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public PdfViewScale? WillChangeScaleFactor {
			get { return EnsurePdfViewDelegate ()!.willChangeScaleFactor; }
			set { EnsurePdfViewDelegate ()!.willChangeScaleFactor = value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<PdfViewUrlEventArgs> WillClickOnLink {
			add { EnsurePdfViewDelegate ()!.willClickOnLink += value; }
			remove { EnsurePdfViewDelegate ()!.willClickOnLink -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PageOverlayViewProvider_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::PdfKit.PdfView" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.AnnotationHitNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.AnnotationHitNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfView.Notifications.ObserveAnnotationHit ((notification) => {
			///   Console.WriteLine ("Observed AnnotationHitNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAnnotationHit (EventHandler<PdfKit.PdfViewAnnotationHitEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AnnotationHitNotification, notification => handler (null, new PdfKit.PdfViewAnnotationHitEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.AnnotationHitNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.AnnotationHitNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfView.Notifications.ObserveAnnotationHit (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed AnnotationHitNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAnnotationHit (NSObject objectToObserve, EventHandler<PdfKit.PdfViewAnnotationHitEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AnnotationHitNotification, notification => handler (null, new PdfKit.PdfViewAnnotationHitEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.AnnotationWillHitNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.AnnotationWillHitNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfView.Notifications.ObserveAnnotationWillHit ((notification) => {
			///   Console.WriteLine ("Observed AnnotationWillHitNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAnnotationWillHit (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AnnotationWillHitNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.AnnotationWillHitNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.AnnotationWillHitNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfView.Notifications.ObserveAnnotationWillHit (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed AnnotationWillHitNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAnnotationWillHit (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AnnotationWillHitNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.ChangedHistoryNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.ChangedHistoryNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfView.Notifications.ObserveChangedHistory ((notification) => {
			///   Console.WriteLine ("Observed ChangedHistoryNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveChangedHistory (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ChangedHistoryNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.ChangedHistoryNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.ChangedHistoryNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfView.Notifications.ObserveChangedHistory (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ChangedHistoryNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveChangedHistory (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ChangedHistoryNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.CopyPermissionNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.CopyPermissionNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfView.Notifications.ObserveCopyPermission ((notification) => {
			///   Console.WriteLine ("Observed CopyPermissionNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveCopyPermission (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (CopyPermissionNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.CopyPermissionNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.CopyPermissionNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfView.Notifications.ObserveCopyPermission (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed CopyPermissionNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveCopyPermission (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (CopyPermissionNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.DisplayBoxChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.DisplayBoxChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfView.Notifications.ObserveDisplayBoxChanged ((notification) => {
			///   Console.WriteLine ("Observed DisplayBoxChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDisplayBoxChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DisplayBoxChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.DisplayBoxChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.DisplayBoxChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfView.Notifications.ObserveDisplayBoxChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DisplayBoxChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDisplayBoxChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DisplayBoxChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.DisplayModeChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.DisplayModeChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfView.Notifications.ObserveDisplayModeChanged ((notification) => {
			///   Console.WriteLine ("Observed DisplayModeChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDisplayModeChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DisplayModeChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.DisplayModeChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.DisplayModeChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfView.Notifications.ObserveDisplayModeChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DisplayModeChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDisplayModeChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DisplayModeChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.DocumentChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.DocumentChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfView.Notifications.ObserveDocumentChanged ((notification) => {
			///   Console.WriteLine ("Observed DocumentChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDocumentChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DocumentChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.DocumentChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.DocumentChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfView.Notifications.ObserveDocumentChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DocumentChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDocumentChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DocumentChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.PageChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.PageChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfView.Notifications.ObservePageChanged ((notification) => {
			///   Console.WriteLine ("Observed PageChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePageChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PageChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.PageChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.PageChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfView.Notifications.ObservePageChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed PageChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePageChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PageChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.PrintPermissionNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.PrintPermissionNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfView.Notifications.ObservePrintPermission ((notification) => {
			///   Console.WriteLine ("Observed PrintPermissionNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePrintPermission (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PrintPermissionNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.PrintPermissionNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.PrintPermissionNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfView.Notifications.ObservePrintPermission (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed PrintPermissionNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePrintPermission (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PrintPermissionNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.ScaleChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.ScaleChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfView.Notifications.ObserveScaleChanged ((notification) => {
			///   Console.WriteLine ("Observed ScaleChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveScaleChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ScaleChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.ScaleChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.ScaleChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfView.Notifications.ObserveScaleChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ScaleChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveScaleChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ScaleChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.SelectionChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.SelectionChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfView.Notifications.ObserveSelectionChanged ((notification) => {
			///   Console.WriteLine ("Observed SelectionChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectionChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectionChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.SelectionChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.SelectionChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfView.Notifications.ObserveSelectionChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed SelectionChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectionChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectionChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.VisiblePagesChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.VisiblePagesChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfView.Notifications.ObserveVisiblePagesChanged ((notification) => {
			///   Console.WriteLine ("Observed VisiblePagesChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveVisiblePagesChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (VisiblePagesChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfView.VisiblePagesChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfView.VisiblePagesChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfView.Notifications.ObserveVisiblePagesChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed VisiblePagesChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveVisiblePagesChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (VisiblePagesChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class PdfView */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class PdfViewActionEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="PdfViewActionEventArgs" /> with the specified event data.</summary>
		/// <param name="action">The value for the <see cref="Action" /> property.</param>
		public PdfViewActionEventArgs (PdfKit.PdfActionRemoteGoTo action)
		{
			this.Action = action;
		}
		public PdfKit.PdfActionRemoteGoTo Action { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class PdfViewUrlEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="PdfViewUrlEventArgs" /> with the specified event data.</summary>
		/// <param name="url">The value for the <see cref="Url" /> property.</param>
		public PdfViewUrlEventArgs (NSUrl url)
		{
			this.Url = url;
		}
		public NSUrl Url { get; set; }
	}
}
