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
namespace WebKit {
	[Register("WebView", true)]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class WebView : global::AppKit.NSView, global::AppKit.INSUserInterfaceValidations {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMIMETypesShownAsHTMLX = "MIMETypesShownAsHTML";
		static readonly NativeHandle selMIMETypesShownAsHTMLXHandle = Selector.GetHandle ("MIMETypesShownAsHTML");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUIDelegateX = "UIDelegate";
		static readonly NativeHandle selUIDelegateXHandle = Selector.GetHandle ("UIDelegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLFromPasteboard_X = "URLFromPasteboard:";
		static readonly NativeHandle selURLFromPasteboard_XHandle = Selector.GetHandle ("URLFromPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLTitleFromPasteboard_X = "URLTitleFromPasteboard:";
		static readonly NativeHandle selURLTitleFromPasteboard_XHandle = Selector.GetHandle ("URLTitleFromPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlignCenter_X = "alignCenter:";
		static readonly NativeHandle selAlignCenter_XHandle = Selector.GetHandle ("alignCenter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlignJustified_X = "alignJustified:";
		static readonly NativeHandle selAlignJustified_XHandle = Selector.GetHandle ("alignJustified:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlignLeft_X = "alignLeft:";
		static readonly NativeHandle selAlignLeft_XHandle = Selector.GetHandle ("alignLeft:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlignRight_X = "alignRight:";
		static readonly NativeHandle selAlignRight_XHandle = Selector.GetHandle ("alignRight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplicationNameForUserAgentX = "applicationNameForUserAgent";
		static readonly NativeHandle selApplicationNameForUserAgentXHandle = Selector.GetHandle ("applicationNameForUserAgent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplyStyle_X = "applyStyle:";
		static readonly NativeHandle selApplyStyle_XHandle = Selector.GetHandle ("applyStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackForwardListX = "backForwardList";
		static readonly NativeHandle selBackForwardListXHandle = Selector.GetHandle ("backForwardList");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanGoBackX = "canGoBack";
		static readonly NativeHandle selCanGoBackXHandle = Selector.GetHandle ("canGoBack");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanGoForwardX = "canGoForward";
		static readonly NativeHandle selCanGoForwardXHandle = Selector.GetHandle ("canGoForward");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanMakeTextLargerX = "canMakeTextLarger";
		static readonly NativeHandle selCanMakeTextLargerXHandle = Selector.GetHandle ("canMakeTextLarger");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanMakeTextSmallerX = "canMakeTextSmaller";
		static readonly NativeHandle selCanMakeTextSmallerXHandle = Selector.GetHandle ("canMakeTextSmaller");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanMakeTextStandardSizeX = "canMakeTextStandardSize";
		static readonly NativeHandle selCanMakeTextStandardSizeXHandle = Selector.GetHandle ("canMakeTextStandardSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanShowMIMEType_X = "canShowMIMEType:";
		static readonly NativeHandle selCanShowMIMEType_XHandle = Selector.GetHandle ("canShowMIMEType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanShowMIMETypeAsHTML_X = "canShowMIMETypeAsHTML:";
		static readonly NativeHandle selCanShowMIMETypeAsHTML_XHandle = Selector.GetHandle ("canShowMIMETypeAsHTML:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeAttributes_X = "changeAttributes:";
		static readonly NativeHandle selChangeAttributes_XHandle = Selector.GetHandle ("changeAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeColor_X = "changeColor:";
		static readonly NativeHandle selChangeColor_XHandle = Selector.GetHandle ("changeColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeDocumentBackgroundColor_X = "changeDocumentBackgroundColor:";
		static readonly NativeHandle selChangeDocumentBackgroundColor_XHandle = Selector.GetHandle ("changeDocumentBackgroundColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeFont_X = "changeFont:";
		static readonly NativeHandle selChangeFont_XHandle = Selector.GetHandle ("changeFont:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckSpelling_X = "checkSpelling:";
		static readonly NativeHandle selCheckSpelling_XHandle = Selector.GetHandle ("checkSpelling:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCloseX = "close";
		static readonly NativeHandle selCloseXHandle = Selector.GetHandle ("close");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyFont_X = "copyFont:";
		static readonly NativeHandle selCopyFont_XHandle = Selector.GetHandle ("copyFont:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomTextEncodingNameX = "customTextEncodingName";
		static readonly NativeHandle selCustomTextEncodingNameXHandle = Selector.GetHandle ("customTextEncodingName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomUserAgentX = "customUserAgent";
		static readonly NativeHandle selCustomUserAgentXHandle = Selector.GetHandle ("customUserAgent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCut_X = "cut:";
		static readonly NativeHandle selCut_XHandle = Selector.GetHandle ("cut:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelete_X = "delete:";
		static readonly NativeHandle selDelete_XHandle = Selector.GetHandle ("delete:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteSelectionX = "deleteSelection";
		static readonly NativeHandle selDeleteSelectionXHandle = Selector.GetHandle ("deleteSelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDownloadDelegateX = "downloadDelegate";
		static readonly NativeHandle selDownloadDelegateXHandle = Selector.GetHandle ("downloadDelegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawsBackgroundX = "drawsBackground";
		static readonly NativeHandle selDrawsBackgroundXHandle = Selector.GetHandle ("drawsBackground");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEditingDelegateX = "editingDelegate";
		static readonly NativeHandle selEditingDelegateXHandle = Selector.GetHandle ("editingDelegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selElementAtPoint_X = "elementAtPoint:";
		static readonly NativeHandle selElementAtPoint_XHandle = Selector.GetHandle ("elementAtPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEstimatedProgressX = "estimatedProgress";
		static readonly NativeHandle selEstimatedProgressXHandle = Selector.GetHandle ("estimatedProgress");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameLoadDelegateX = "frameLoadDelegate";
		static readonly NativeHandle selFrameLoadDelegateXHandle = Selector.GetHandle ("frameLoadDelegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoBackX = "goBack";
		static readonly NativeHandle selGoBackXHandle = Selector.GetHandle ("goBack");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoForwardX = "goForward";
		static readonly NativeHandle selGoForwardXHandle = Selector.GetHandle ("goForward");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoToBackForwardItem_X = "goToBackForwardItem:";
		static readonly NativeHandle selGoToBackForwardItem_XHandle = Selector.GetHandle ("goToBackForwardItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGroupNameX = "groupName";
		static readonly NativeHandle selGroupNameXHandle = Selector.GetHandle ("groupName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHostWindowX = "hostWindow";
		static readonly NativeHandle selHostWindowXHandle = Selector.GetHandle ("hostWindow");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_X = "initWithFrame:";
		static readonly NativeHandle selInitWithFrame_XHandle = Selector.GetHandle ("initWithFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_FrameName_GroupName_X = "initWithFrame:frameName:groupName:";
		static readonly NativeHandle selInitWithFrame_FrameName_GroupName_XHandle = Selector.GetHandle ("initWithFrame:frameName:groupName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsContinuousSpellCheckingEnabledX = "isContinuousSpellCheckingEnabled";
		static readonly NativeHandle selIsContinuousSpellCheckingEnabledXHandle = Selector.GetHandle ("isContinuousSpellCheckingEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEditableX = "isEditable";
		static readonly NativeHandle selIsEditableXHandle = Selector.GetHandle ("isEditable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsLoadingX = "isLoading";
		static readonly NativeHandle selIsLoadingXHandle = Selector.GetHandle ("isLoading");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMainFrameX = "mainFrame";
		static readonly NativeHandle selMainFrameXHandle = Selector.GetHandle ("mainFrame");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMainFrameDocumentX = "mainFrameDocument";
		static readonly NativeHandle selMainFrameDocumentXHandle = Selector.GetHandle ("mainFrameDocument");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMainFrameIconX = "mainFrameIcon";
		static readonly NativeHandle selMainFrameIconXHandle = Selector.GetHandle ("mainFrameIcon");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMainFrameTitleX = "mainFrameTitle";
		static readonly NativeHandle selMainFrameTitleXHandle = Selector.GetHandle ("mainFrameTitle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMainFrameURLX = "mainFrameURL";
		static readonly NativeHandle selMainFrameURLXHandle = Selector.GetHandle ("mainFrameURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaintainsInactiveSelectionX = "maintainsInactiveSelection";
		static readonly NativeHandle selMaintainsInactiveSelectionXHandle = Selector.GetHandle ("maintainsInactiveSelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakeTextLarger_X = "makeTextLarger:";
		static readonly NativeHandle selMakeTextLarger_XHandle = Selector.GetHandle ("makeTextLarger:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakeTextSmaller_X = "makeTextSmaller:";
		static readonly NativeHandle selMakeTextSmaller_XHandle = Selector.GetHandle ("makeTextSmaller:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakeTextStandardSize_X = "makeTextStandardSize:";
		static readonly NativeHandle selMakeTextStandardSize_XHandle = Selector.GetHandle ("makeTextStandardSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaStyleX = "mediaStyle";
		static readonly NativeHandle selMediaStyleXHandle = Selector.GetHandle ("mediaStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveDragCaretToPoint_X = "moveDragCaretToPoint:";
		static readonly NativeHandle selMoveDragCaretToPoint_XHandle = Selector.GetHandle ("moveDragCaretToPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveToBeginningOfSentence_X = "moveToBeginningOfSentence:";
		static readonly NativeHandle selMoveToBeginningOfSentence_XHandle = Selector.GetHandle ("moveToBeginningOfSentence:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveToBeginningOfSentenceAndModifySelection_X = "moveToBeginningOfSentenceAndModifySelection:";
		static readonly NativeHandle selMoveToBeginningOfSentenceAndModifySelection_XHandle = Selector.GetHandle ("moveToBeginningOfSentenceAndModifySelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveToEndOfSentence_X = "moveToEndOfSentence:";
		static readonly NativeHandle selMoveToEndOfSentence_XHandle = Selector.GetHandle ("moveToEndOfSentence:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveToEndOfSentenceAndModifySelection_X = "moveToEndOfSentenceAndModifySelection:";
		static readonly NativeHandle selMoveToEndOfSentenceAndModifySelection_XHandle = Selector.GetHandle ("moveToEndOfSentenceAndModifySelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPaste_X = "paste:";
		static readonly NativeHandle selPaste_XHandle = Selector.GetHandle ("paste:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPasteAsPlainText_X = "pasteAsPlainText:";
		static readonly NativeHandle selPasteAsPlainText_XHandle = Selector.GetHandle ("pasteAsPlainText:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPasteAsRichText_X = "pasteAsRichText:";
		static readonly NativeHandle selPasteAsRichText_XHandle = Selector.GetHandle ("pasteAsRichText:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPasteFont_X = "pasteFont:";
		static readonly NativeHandle selPasteFont_XHandle = Selector.GetHandle ("pasteFont:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPasteboardTypesForElement_X = "pasteboardTypesForElement:";
		static readonly NativeHandle selPasteboardTypesForElement_XHandle = Selector.GetHandle ("pasteboardTypesForElement:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPasteboardTypesForSelectionX = "pasteboardTypesForSelection";
		static readonly NativeHandle selPasteboardTypesForSelectionXHandle = Selector.GetHandle ("pasteboardTypesForSelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformFindPanelAction_X = "performFindPanelAction:";
		static readonly NativeHandle selPerformFindPanelAction_XHandle = Selector.GetHandle ("performFindPanelAction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPolicyDelegateX = "policyDelegate";
		static readonly NativeHandle selPolicyDelegateXHandle = Selector.GetHandle ("policyDelegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferencesX = "preferences";
		static readonly NativeHandle selPreferencesXHandle = Selector.GetHandle ("preferences");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferencesIdentifierX = "preferencesIdentifier";
		static readonly NativeHandle selPreferencesIdentifierXHandle = Selector.GetHandle ("preferencesIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterURLSchemeAsLocal_X = "registerURLSchemeAsLocal:";
		static readonly NativeHandle selRegisterURLSchemeAsLocal_XHandle = Selector.GetHandle ("registerURLSchemeAsLocal:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterViewClass_RepresentationClass_ForMIMEType_X = "registerViewClass:representationClass:forMIMEType:";
		static readonly NativeHandle selRegisterViewClass_RepresentationClass_ForMIMEType_XHandle = Selector.GetHandle ("registerViewClass:representationClass:forMIMEType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReload_X = "reload:";
		static readonly NativeHandle selReload_XHandle = Selector.GetHandle ("reload:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadFromOrigin_X = "reloadFromOrigin:";
		static readonly NativeHandle selReloadFromOrigin_XHandle = Selector.GetHandle ("reloadFromOrigin:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveDragCaretX = "removeDragCaret";
		static readonly NativeHandle selRemoveDragCaretXHandle = Selector.GetHandle ("removeDragCaret");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplaceSelectionWithArchive_X = "replaceSelectionWithArchive:";
		static readonly NativeHandle selReplaceSelectionWithArchive_XHandle = Selector.GetHandle ("replaceSelectionWithArchive:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplaceSelectionWithMarkupString_X = "replaceSelectionWithMarkupString:";
		static readonly NativeHandle selReplaceSelectionWithMarkupString_XHandle = Selector.GetHandle ("replaceSelectionWithMarkupString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResourceLoadDelegateX = "resourceLoadDelegate";
		static readonly NativeHandle selResourceLoadDelegateXHandle = Selector.GetHandle ("resourceLoadDelegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSearchFor_Direction_CaseSensitive_Wrap_X = "searchFor:direction:caseSensitive:wrap:";
		static readonly NativeHandle selSearchFor_Direction_CaseSensitive_Wrap_XHandle = Selector.GetHandle ("searchFor:direction:caseSensitive:wrap:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectSentence_X = "selectSentence:";
		static readonly NativeHandle selSelectSentence_XHandle = Selector.GetHandle ("selectSentence:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedDOMRangeX = "selectedDOMRange";
		static readonly NativeHandle selSelectedDOMRangeXHandle = Selector.GetHandle ("selectedDOMRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedFrameX = "selectedFrame";
		static readonly NativeHandle selSelectedFrameXHandle = Selector.GetHandle ("selectedFrame");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionAffinityX = "selectionAffinity";
		static readonly NativeHandle selSelectionAffinityXHandle = Selector.GetHandle ("selectionAffinity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetApplicationNameForUserAgent_X = "setApplicationNameForUserAgent:";
		static readonly NativeHandle selSetApplicationNameForUserAgent_XHandle = Selector.GetHandle ("setApplicationNameForUserAgent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContinuousSpellCheckingEnabled_X = "setContinuousSpellCheckingEnabled:";
		static readonly NativeHandle selSetContinuousSpellCheckingEnabled_XHandle = Selector.GetHandle ("setContinuousSpellCheckingEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomTextEncodingName_X = "setCustomTextEncodingName:";
		static readonly NativeHandle selSetCustomTextEncodingName_XHandle = Selector.GetHandle ("setCustomTextEncodingName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomUserAgent_X = "setCustomUserAgent:";
		static readonly NativeHandle selSetCustomUserAgent_XHandle = Selector.GetHandle ("setCustomUserAgent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDownloadDelegate_X = "setDownloadDelegate:";
		static readonly NativeHandle selSetDownloadDelegate_XHandle = Selector.GetHandle ("setDownloadDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDrawsBackground_X = "setDrawsBackground:";
		static readonly NativeHandle selSetDrawsBackground_XHandle = Selector.GetHandle ("setDrawsBackground:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEditable_X = "setEditable:";
		static readonly NativeHandle selSetEditable_XHandle = Selector.GetHandle ("setEditable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEditingDelegate_X = "setEditingDelegate:";
		static readonly NativeHandle selSetEditingDelegate_XHandle = Selector.GetHandle ("setEditingDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFrameLoadDelegate_X = "setFrameLoadDelegate:";
		static readonly NativeHandle selSetFrameLoadDelegate_XHandle = Selector.GetHandle ("setFrameLoadDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGroupName_X = "setGroupName:";
		static readonly NativeHandle selSetGroupName_XHandle = Selector.GetHandle ("setGroupName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHostWindow_X = "setHostWindow:";
		static readonly NativeHandle selSetHostWindow_XHandle = Selector.GetHandle ("setHostWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMIMETypesShownAsHTML_X = "setMIMETypesShownAsHTML:";
		static readonly NativeHandle selSetMIMETypesShownAsHTML_XHandle = Selector.GetHandle ("setMIMETypesShownAsHTML:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMainFrameURL_X = "setMainFrameURL:";
		static readonly NativeHandle selSetMainFrameURL_XHandle = Selector.GetHandle ("setMainFrameURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaintainsBackForwardList_X = "setMaintainsBackForwardList:";
		static readonly NativeHandle selSetMaintainsBackForwardList_XHandle = Selector.GetHandle ("setMaintainsBackForwardList:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMediaStyle_X = "setMediaStyle:";
		static readonly NativeHandle selSetMediaStyle_XHandle = Selector.GetHandle ("setMediaStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPolicyDelegate_X = "setPolicyDelegate:";
		static readonly NativeHandle selSetPolicyDelegate_XHandle = Selector.GetHandle ("setPolicyDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferences_X = "setPreferences:";
		static readonly NativeHandle selSetPreferences_XHandle = Selector.GetHandle ("setPreferences:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferencesIdentifier_X = "setPreferencesIdentifier:";
		static readonly NativeHandle selSetPreferencesIdentifier_XHandle = Selector.GetHandle ("setPreferencesIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetResourceLoadDelegate_X = "setResourceLoadDelegate:";
		static readonly NativeHandle selSetResourceLoadDelegate_XHandle = Selector.GetHandle ("setResourceLoadDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectedDOMRange_Affinity_X = "setSelectedDOMRange:affinity:";
		static readonly NativeHandle selSetSelectedDOMRange_Affinity_XHandle = Selector.GetHandle ("setSelectedDOMRange:affinity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShouldCloseWithWindow_X = "setShouldCloseWithWindow:";
		static readonly NativeHandle selSetShouldCloseWithWindow_XHandle = Selector.GetHandle ("setShouldCloseWithWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShouldUpdateWhileOffscreen_X = "setShouldUpdateWhileOffscreen:";
		static readonly NativeHandle selSetShouldUpdateWhileOffscreen_XHandle = Selector.GetHandle ("setShouldUpdateWhileOffscreen:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSmartInsertDeleteEnabled_X = "setSmartInsertDeleteEnabled:";
		static readonly NativeHandle selSetSmartInsertDeleteEnabled_XHandle = Selector.GetHandle ("setSmartInsertDeleteEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTextSizeMultiplier_X = "setTextSizeMultiplier:";
		static readonly NativeHandle selSetTextSizeMultiplier_XHandle = Selector.GetHandle ("setTextSizeMultiplier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTypingStyle_X = "setTypingStyle:";
		static readonly NativeHandle selSetTypingStyle_XHandle = Selector.GetHandle ("setTypingStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUIDelegate_X = "setUIDelegate:";
		static readonly NativeHandle selSetUIDelegate_XHandle = Selector.GetHandle ("setUIDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldCloseWithWindowX = "shouldCloseWithWindow";
		static readonly NativeHandle selShouldCloseWithWindowXHandle = Selector.GetHandle ("shouldCloseWithWindow");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldUpdateWhileOffscreenX = "shouldUpdateWhileOffscreen";
		static readonly NativeHandle selShouldUpdateWhileOffscreenXHandle = Selector.GetHandle ("shouldUpdateWhileOffscreen");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowGuessPanel_X = "showGuessPanel:";
		static readonly NativeHandle selShowGuessPanel_XHandle = Selector.GetHandle ("showGuessPanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSmartInsertDeleteEnabledX = "smartInsertDeleteEnabled";
		static readonly NativeHandle selSmartInsertDeleteEnabledXHandle = Selector.GetHandle ("smartInsertDeleteEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpellCheckerDocumentTagX = "spellCheckerDocumentTag";
		static readonly NativeHandle selSpellCheckerDocumentTagXHandle = Selector.GetHandle ("spellCheckerDocumentTag");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartSpeaking_X = "startSpeaking:";
		static readonly NativeHandle selStartSpeaking_XHandle = Selector.GetHandle ("startSpeaking:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopSpeaking_X = "stopSpeaking:";
		static readonly NativeHandle selStopSpeaking_XHandle = Selector.GetHandle ("stopSpeaking:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringByEvaluatingJavaScriptFromString_X = "stringByEvaluatingJavaScriptFromString:";
		static readonly NativeHandle selStringByEvaluatingJavaScriptFromString_XHandle = Selector.GetHandle ("stringByEvaluatingJavaScriptFromString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStyleDeclarationWithText_X = "styleDeclarationWithText:";
		static readonly NativeHandle selStyleDeclarationWithText_XHandle = Selector.GetHandle ("styleDeclarationWithText:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportsTextEncodingX = "supportsTextEncoding";
		static readonly NativeHandle selSupportsTextEncodingXHandle = Selector.GetHandle ("supportsTextEncoding");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextSizeMultiplierX = "textSizeMultiplier";
		static readonly NativeHandle selTextSizeMultiplierXHandle = Selector.GetHandle ("textSizeMultiplier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToggleContinuousSpellChecking_X = "toggleContinuousSpellChecking:";
		static readonly NativeHandle selToggleContinuousSpellChecking_XHandle = Selector.GetHandle ("toggleContinuousSpellChecking:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToggleSmartInsertDelete_X = "toggleSmartInsertDelete:";
		static readonly NativeHandle selToggleSmartInsertDelete_XHandle = Selector.GetHandle ("toggleSmartInsertDelete:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTypingStyleX = "typingStyle";
		static readonly NativeHandle selTypingStyleXHandle = Selector.GetHandle ("typingStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUndoManagerX = "undoManager";
		static readonly NativeHandle selUndoManagerXHandle = Selector.GetHandle ("undoManager");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserAgentForURL_X = "userAgentForURL:";
		static readonly NativeHandle selUserAgentForURL_XHandle = Selector.GetHandle ("userAgentForURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateUserInterfaceItem_X = "validateUserInterfaceItem:";
		static readonly NativeHandle selValidateUserInterfaceItem_XHandle = Selector.GetHandle ("validateUserInterfaceItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWindowScriptObjectX = "windowScriptObject";
		static readonly NativeHandle selWindowScriptObjectXHandle = Selector.GetHandle ("windowScriptObject");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteElement_WithPasteboardTypes_ToPasteboard_X = "writeElement:withPasteboardTypes:toPasteboard:";
		static readonly NativeHandle selWriteElement_WithPasteboardTypes_ToPasteboard_XHandle = Selector.GetHandle ("writeElement:withPasteboardTypes:toPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteSelectionWithPasteboardTypes_ToPasteboard_X = "writeSelectionWithPasteboardTypes:toPasteboard:";
		static readonly NativeHandle selWriteSelectionWithPasteboardTypes_ToPasteboard_XHandle = Selector.GetHandle ("writeSelectionWithPasteboardTypes:toPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("WebView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="WebView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WebView () : base (NSObjectFlag.Empty)
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
		public WebView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected WebView (NSObjectFlag t) : base (t)
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
		protected internal WebView (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:frameName:groupName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public WebView (CGRect frame, string? frameName, string? groupName)
			: base (NSObjectFlag.Empty)
		{
			var nsframeName = CFString.CreateNative (frameName);
			var nsgroupName = CFString.CreateNative (groupName);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_NativeHandle_NativeHandle (this.Handle, selInitWithFrame_FrameName_GroupName_XHandle, frame, nsframeName, nsgroupName), "initWithFrame:frameName:groupName:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect_NativeHandle_NativeHandle (&__objc_super__, selInitWithFrame_FrameName_GroupName_XHandle, frame, nsframeName, nsgroupName), "initWithFrame:frameName:groupName:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsframeName);
			CFString.ReleaseNative (nsgroupName);
		}
		/// <param name="frame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public WebView (CGRect frame)
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
		[Export ("alignCenter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AlignCenter (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAlignCenter_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAlignCenter_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("alignJustified:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AlignJustified (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAlignJustified_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAlignJustified_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("alignLeft:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AlignLeft (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAlignLeft_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAlignLeft_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("alignRight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AlignRight (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAlignRight_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAlignRight_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("applyStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApplyStyle (DomCssStyleDeclaration style)
		{
			var style__handle__ = style!.GetNonNullHandle (nameof (style));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selApplyStyle_XHandle, style__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selApplyStyle_XHandle, style__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (style);
		}
		[Export ("canGoBack")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanGoBack ()
		{
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
		[Export ("canGoForward")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanGoForward ()
		{
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
		[Export ("canMakeTextLarger")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanMakeTextLarger ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanMakeTextLargerXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanMakeTextLargerXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("canMakeTextSmaller")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanMakeTextSmaller ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanMakeTextSmallerXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanMakeTextSmallerXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("canMakeTextStandardSize")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanMakeTextStandardSize ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanMakeTextStandardSizeXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanMakeTextStandardSizeXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("canShowMIMEType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanShowMimeType (string MimeType)
		{
			if (MimeType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (MimeType));
			var nsMimeType = CFString.CreateNative (MimeType);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, selCanShowMIMEType_XHandle, nsMimeType);
			CFString.ReleaseNative (nsMimeType);
			return ret != 0;
		}
		[Export ("canShowMIMETypeAsHTML:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanShowMimeTypeAsHtml (string mimeType)
		{
			if (mimeType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mimeType));
			var nsmimeType = CFString.CreateNative (mimeType);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, selCanShowMIMETypeAsHTML_XHandle, nsmimeType);
			CFString.ReleaseNative (nsmimeType);
			return ret != 0;
		}
		[Export ("changeAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeAttributes (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selChangeAttributes_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selChangeAttributes_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("changeColor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeColor (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selChangeColor_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selChangeColor_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("changeDocumentBackgroundColor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeDocumentBackgroundColor (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selChangeDocumentBackgroundColor_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selChangeDocumentBackgroundColor_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("changeFont:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeFont (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selChangeFont_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selChangeFont_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("checkSpelling:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CheckSpelling (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCheckSpelling_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCheckSpelling_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("close")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Close ()
		{
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
		[Export ("copyFont:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyFont (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCopyFont_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyFont_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("cut:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Cut (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCut_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCut_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("delete:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Delete (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDelete_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDelete_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("deleteSelection")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeleteSelection ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDeleteSelectionXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDeleteSelectionXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("elementAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary ElementAtPoint (CGPoint point)
		{
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, selElementAtPoint_XHandle, point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint (&__objc_super__, selElementAtPoint_XHandle, point), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("goBack")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GoBack ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selGoBackXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selGoBackXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("goForward")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GoForward ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selGoForwardXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selGoForwardXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("goToBackForwardItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GoToBackForwardItem (WebHistoryItem item)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selGoToBackForwardItem_XHandle, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selGoToBackForwardItem_XHandle, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
			return ret != 0;
		}
		[Export ("makeTextLarger:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MakeTextLarger (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMakeTextLarger_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMakeTextLarger_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("makeTextSmaller:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MakeTextSmaller (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMakeTextSmaller_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMakeTextSmaller_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("makeTextStandardSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MakeTextStandardSize (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMakeTextStandardSize_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMakeTextStandardSize_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("moveDragCaretToPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveDragCaretToPoint (CGPoint point)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, selMoveDragCaretToPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, selMoveDragCaretToPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("moveToBeginningOfSentence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveToBeginningOfSentence (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMoveToBeginningOfSentence_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMoveToBeginningOfSentence_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("moveToBeginningOfSentenceAndModifySelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveToBeginningOfSentenceAndModifySelection (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMoveToBeginningOfSentenceAndModifySelection_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMoveToBeginningOfSentenceAndModifySelection_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("moveToEndOfSentence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveToEndOfSentence (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMoveToEndOfSentence_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMoveToEndOfSentence_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("moveToEndOfSentenceAndModifySelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveToEndOfSentenceAndModifySelection (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMoveToEndOfSentenceAndModifySelection_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMoveToEndOfSentenceAndModifySelection_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("paste:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Paste (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPaste_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPaste_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("pasteAsPlainText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PasteAsPlainText (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPasteAsPlainText_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPasteAsPlainText_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("pasteAsRichText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PasteAsRichText (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPasteAsRichText_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPasteAsRichText_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("pasteFont:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PasteFont (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPasteFont_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPasteFont_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("pasteboardTypesForElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] PasteboardTypesForElement (NSDictionary element)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			NSObject[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPasteboardTypesForElement_XHandle, element__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPasteboardTypesForElement_XHandle, element__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (element);
			return ret!;
		}
		[Export ("performFindPanelAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformFindPanelAction (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPerformFindPanelAction_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPerformFindPanelAction_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("registerURLSchemeAsLocal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterUrlSchemeAsLocal (string scheme)
		{
			if (scheme is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (scheme));
			var nsscheme = CFString.CreateNative (scheme);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selRegisterURLSchemeAsLocal_XHandle, nsscheme);
			CFString.ReleaseNative (nsscheme);
		}
		[Export ("registerViewClass:representationClass:forMIMEType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterViewClass (Class viewClass, Class representationClass, string mimeType)
		{
			var viewClass__handle__ = viewClass!.GetNonNullHandle (nameof (viewClass));
			var representationClass__handle__ = representationClass!.GetNonNullHandle (nameof (representationClass));
			if (mimeType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mimeType));
			var nsmimeType = CFString.CreateNative (mimeType);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selRegisterViewClass_RepresentationClass_ForMIMEType_XHandle, viewClass.Handle, representationClass.Handle, nsmimeType);
			GC.KeepAlive (viewClass);
			GC.KeepAlive (representationClass);
			CFString.ReleaseNative (nsmimeType);
		}
		[Export ("reload:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Reload (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReload_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReload_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("reloadFromOrigin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadFromOrigin (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReloadFromOrigin_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReloadFromOrigin_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("removeDragCaret")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveDragCaret ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveDragCaretXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveDragCaretXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("replaceSelectionWithArchive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceSelectionWithArchive (WebArchive archive)
		{
			var archive__handle__ = archive!.GetNonNullHandle (nameof (archive));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReplaceSelectionWithArchive_XHandle, archive__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReplaceSelectionWithArchive_XHandle, archive__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (archive);
		}
		[Export ("replaceSelectionWithMarkupString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceSelectionWithMarkupString (string markupString)
		{
			if (markupString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (markupString));
			var nsmarkupString = CFString.CreateNative (markupString);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReplaceSelectionWithMarkupString_XHandle, nsmarkupString);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReplaceSelectionWithMarkupString_XHandle, nsmarkupString);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsmarkupString);
		}
		[Export ("searchFor:direction:caseSensitive:wrap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Search (string forString, bool forward, bool caseSensitive, bool wrap)
		{
			if (forString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forString));
			var nsforString = CFString.CreateNative (forString);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_bool_bool_bool (this.Handle, selSearchFor_Direction_CaseSensitive_Wrap_XHandle, nsforString, forward ? (byte) 1 : (byte) 0, caseSensitive ? (byte) 1 : (byte) 0, wrap ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_bool_bool_bool (&__objc_super__, selSearchFor_Direction_CaseSensitive_Wrap_XHandle, nsforString, forward ? (byte) 1 : (byte) 0, caseSensitive ? (byte) 1 : (byte) 0, wrap ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsforString);
			return ret != 0;
		}
		[Export ("selectSentence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectSentence (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSelectSentence_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSelectSentence_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("setMaintainsBackForwardList:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMaintainsBackForwardList (bool flag)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetMaintainsBackForwardList_XHandle, flag ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetMaintainsBackForwardList_XHandle, flag ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setSelectedDOMRange:affinity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSelectedDomRange (DomRange? range, global::AppKit.NSSelectionAffinity selectionAffinity)
		{
			var range__handle__ = range.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selSetSelectedDOMRange_Affinity_XHandle, range__handle__, (UIntPtr) (ulong) selectionAffinity);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selSetSelectedDOMRange_Affinity_XHandle, range__handle__, (UIntPtr) (ulong) selectionAffinity);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (range);
		}
		[Export ("showGuessPanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowGuessPanel (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selShowGuessPanel_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selShowGuessPanel_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("startSpeaking:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartSpeaking (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStartSpeaking_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selStartSpeaking_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("stopSpeaking:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopSpeaking (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStopSpeaking_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selStopSpeaking_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("stringByEvaluatingJavaScriptFromString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string StringByEvaluatingJavaScriptFromString (string script)
		{
			if (script is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (script));
			var nsscript = CFString.CreateNative (script);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selStringByEvaluatingJavaScriptFromString_XHandle, nsscript), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selStringByEvaluatingJavaScriptFromString_XHandle, nsscript), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsscript);
			return ret!;
		}
		[Export ("styleDeclarationWithText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomCssStyleDeclaration StyleDeclarationWithText (string text)
		{
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var nstext = CFString.CreateNative (text);
			DomCssStyleDeclaration? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomCssStyleDeclaration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selStyleDeclarationWithText_XHandle, nstext), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomCssStyleDeclaration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selStyleDeclarationWithText_XHandle, nstext), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstext);
			return ret!;
		}
		[Export ("toggleContinuousSpellChecking:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleContinuousSpellChecking (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToggleContinuousSpellChecking_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToggleContinuousSpellChecking_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("toggleSmartInsertDelete:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleSmartInsertDelete (NSObject sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToggleSmartInsertDelete_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToggleSmartInsertDelete_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("URLFromPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl UrlFromPasteboard (global::AppKit.NSPasteboard pasteboard)
		{
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selURLFromPasteboard_XHandle, pasteboard__handle__), false)!;
			GC.KeepAlive (pasteboard);
			return ret!;
		}
		[Export ("URLTitleFromPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string UrlTitleFromPasteboard (global::AppKit.NSPasteboard pasteboard)
		{
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selURLTitleFromPasteboard_XHandle, pasteboard__handle__), false)!;
			GC.KeepAlive (pasteboard);
			return ret!;
		}
		[Export ("userAgentForURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string UserAgentForUrl (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selUserAgentForURL_XHandle, url__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selUserAgentForURL_XHandle, url__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			return ret!;
		}
		/// <param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("validateUserInterfaceItem:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "No longer supported.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ValidateUserInterfaceItem (global::AppKit.INSValidatedUserInterfaceItem item)
		{
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
		[Export ("writeElement:withPasteboardTypes:toPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteElement (NSDictionary element, NSObject[] pasteboardTypes, global::AppKit.NSPasteboard toPasteboard)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			if (pasteboardTypes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pasteboardTypes));
			var toPasteboard__handle__ = toPasteboard!.GetNonNullHandle (nameof (toPasteboard));
			using var nsa_pasteboardTypes = NSArray.FromNSObjects (pasteboardTypes);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selWriteElement_WithPasteboardTypes_ToPasteboard_XHandle, element__handle__, nsa_pasteboardTypes.Handle, toPasteboard__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selWriteElement_WithPasteboardTypes_ToPasteboard_XHandle, element__handle__, nsa_pasteboardTypes.Handle, toPasteboard__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (element);
			GC.KeepAlive (toPasteboard);
		}
		[Export ("writeSelectionWithPasteboardTypes:toPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteSelection (NSObject[] types, global::AppKit.NSPasteboard pasteboard)
		{
			if (types is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (types));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			using var nsa_types = NSArray.FromNSObjects (types);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selWriteSelectionWithPasteboardTypes_ToPasteboard_XHandle, nsa_types.Handle, pasteboard__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selWriteSelectionWithPasteboardTypes_ToPasteboard_XHandle, nsa_types.Handle, pasteboard__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pasteboard);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ApplicationNameForUserAgent {
			[Export ("applicationNameForUserAgent")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selApplicationNameForUserAgentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selApplicationNameForUserAgentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setApplicationNameForUserAgent:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetApplicationNameForUserAgent_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetApplicationNameForUserAgent_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebBackForwardList BackForwardList {
			[Export ("backForwardList")]
			get {
				WebBackForwardList? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WebBackForwardList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBackForwardListXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<WebBackForwardList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBackForwardListXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ContinuousSpellCheckingEnabled {
			[Export ("isContinuousSpellCheckingEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsContinuousSpellCheckingEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsContinuousSpellCheckingEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setContinuousSpellCheckingEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetContinuousSpellCheckingEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetContinuousSpellCheckingEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CustomTextEncodingName {
			[Export ("customTextEncodingName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCustomTextEncodingNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCustomTextEncodingNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCustomTextEncodingName:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCustomTextEncodingName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCustomTextEncodingName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CustomUserAgent {
			[Export ("customUserAgent")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCustomUserAgentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCustomUserAgentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCustomUserAgent:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCustomUserAgent_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCustomUserAgent_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IWebDownloadDelegate DownloadDelegate {
			get {
				return (WeakDownloadDelegate as IWebDownloadDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDownloadDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DrawsBackground {
			[Export ("drawsBackground")]
			get {
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Editable {
			[Export ("isEditable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEditableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsEditableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEditable:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEditable_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetEditable_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_EditingDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? EditingDelegate {
			[Export ("editingDelegate", ArgumentSemantic.Assign)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selEditingDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selEditingDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_EditingDelegate_var = ret;
				return ret!;
			}
			[Export ("setEditingDelegate:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetEditingDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetEditingDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_EditingDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double EstimatedProgress {
			[Export ("estimatedProgress")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selEstimatedProgressXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selEstimatedProgressXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IWebFrameLoadDelegate FrameLoadDelegate {
			get {
				return (WeakFrameLoadDelegate as IWebFrameLoadDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakFrameLoadDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GroupName {
			[Export ("groupName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGroupNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGroupNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setGroupName:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetGroupName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetGroupName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSWindow? HostWindow {
			[Export ("hostWindow", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSWindow? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AppKit.NSWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHostWindowXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AppKit.NSWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHostWindowXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setHostWindow:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetHostWindow_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetHostWindow_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsLoading {
			[Export ("isLoading")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLoadingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsLoadingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebFrame MainFrame {
			[Export ("mainFrame")]
			get {
				WebFrame? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WebFrame> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMainFrameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<WebFrame> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMainFrameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomDocument MainFrameDocument {
			[Export ("mainFrameDocument")]
			get {
				DomDocument? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMainFrameDocumentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMainFrameDocumentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSImage MainFrameIcon {
			[Export ("mainFrameIcon")]
			get {
				global::AppKit.NSImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AppKit.NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMainFrameIconXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AppKit.NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMainFrameIconXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string MainFrameTitle {
			[Export ("mainFrameTitle")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMainFrameTitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMainFrameTitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string MainFrameUrl {
			[Export ("mainFrameURL")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMainFrameURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMainFrameURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMainFrameURL:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMainFrameURL_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMainFrameURL_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MaintainsInactiveSelection {
			[Export ("maintainsInactiveSelection")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selMaintainsInactiveSelectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selMaintainsInactiveSelectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string MediaStyle {
			[Export ("mediaStyle")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMediaStyleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMediaStyleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMediaStyle:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMediaStyle_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMediaStyle_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] MimeTypesShownAsHtml {
			[Export ("MIMETypesShownAsHTML")]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMIMETypesShownAsHTMLXHandle), false)!;
				return ret;
			}
			[Export ("setMIMETypesShownAsHTML:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromStrings (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selSetMIMETypesShownAsHTML_XHandle, nsa_value.Handle);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSPasteboard[] PasteboardTypesForSelection {
			[Export ("pasteboardTypesForSelection")]
			get {
				global::AppKit.NSPasteboard[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<global::AppKit.NSPasteboard>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPasteboardTypesForSelectionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<global::AppKit.NSPasteboard>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPasteboardTypesForSelectionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IWebPolicyDelegate PolicyDelegate {
			get {
				return (WeakPolicyDelegate as IWebPolicyDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakPolicyDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebPreferences Preferences {
			[Export ("preferences", ArgumentSemantic.Retain)]
			get {
				WebPreferences? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WebPreferences> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreferencesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<WebPreferences> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreferencesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPreferences:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPreferences_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPreferences_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string PreferencesIdentifier {
			[Export ("preferencesIdentifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreferencesIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreferencesIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferencesIdentifier:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPreferencesIdentifier_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPreferencesIdentifier_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IWebResourceLoadDelegate ResourceLoadDelegate {
			get {
				return (WeakResourceLoadDelegate as IWebResourceLoadDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakResourceLoadDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomRange SelectedDomRange {
			[Export ("selectedDOMRange")]
			get {
				DomRange? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectedDOMRangeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectedDOMRangeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebFrame SelectedFrame {
			[Export ("selectedFrame")]
			get {
				WebFrame? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WebFrame> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectedFrameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<WebFrame> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectedFrameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSSelectionAffinity SelectionAffinity {
			[Export ("selectionAffinity")]
			get {
				global::AppKit.NSSelectionAffinity ret;
				if (IsDirectBinding) {
					ret = (NSSelectionAffinity) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSelectionAffinityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSSelectionAffinity) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSelectionAffinityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldCloseWithWindow {
			[Export ("shouldCloseWithWindow")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldCloseWithWindowXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShouldCloseWithWindowXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShouldCloseWithWindow:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldCloseWithWindow_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShouldCloseWithWindow_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SmartInsertDeleteEnabled {
			[Export ("smartInsertDeleteEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSmartInsertDeleteEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSmartInsertDeleteEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSmartInsertDeleteEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSmartInsertDeleteEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetSmartInsertDeleteEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SpellCheckerDocumentTag {
			[Export ("spellCheckerDocumentTag")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSpellCheckerDocumentTagXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selSpellCheckerDocumentTagXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SupportsTextEncoding {
			[Export ("supportsTextEncoding")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSupportsTextEncodingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSupportsTextEncodingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float TextSizeMultiplier {
			[Export ("textSizeMultiplier")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selTextSizeMultiplierXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selTextSizeMultiplierXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTextSizeMultiplier:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetTextSizeMultiplier_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetTextSizeMultiplier_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomCssStyleDeclaration TypingStyle {
			[Export ("typingStyle")]
			get {
				DomCssStyleDeclaration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomCssStyleDeclaration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTypingStyleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomCssStyleDeclaration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTypingStyleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTypingStyle:")]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTypingStyle_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTypingStyle_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IWebUIDelegate UIDelegate {
			get {
				return (WeakUIDelegate as IWebUIDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakUIDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUndoManager UndoManager {
			[Export ("undoManager")]
			get {
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
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UpdateWhileOffscreen {
			[Export ("shouldUpdateWhileOffscreen")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldUpdateWhileOffscreenXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShouldUpdateWhileOffscreenXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShouldUpdateWhileOffscreen:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldUpdateWhileOffscreen_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShouldUpdateWhileOffscreen_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDownloadDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDownloadDelegate {
			[Export ("downloadDelegate", ArgumentSemantic.Assign)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDownloadDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDownloadDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDownloadDelegate_var = ret;
				return ret!;
			}
			[Export ("setDownloadDelegate:", ArgumentSemantic.Assign)]
			set {
				NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakDownloadDelegate_var, value, GetInternalEventDownloadDelegateType);
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDownloadDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDownloadDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDownloadDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakFrameLoadDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakFrameLoadDelegate {
			[Export ("frameLoadDelegate", ArgumentSemantic.Assign)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFrameLoadDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFrameLoadDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakFrameLoadDelegate_var = ret;
				return ret!;
			}
			[Export ("setFrameLoadDelegate:", ArgumentSemantic.Assign)]
			set {
				NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakFrameLoadDelegate_var, value, GetInternalEventFrameLoadDelegateType);
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFrameLoadDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFrameLoadDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakFrameLoadDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakPolicyDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakPolicyDelegate {
			[Export ("policyDelegate", ArgumentSemantic.Assign)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPolicyDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPolicyDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakPolicyDelegate_var = ret;
				return ret!;
			}
			[Export ("setPolicyDelegate:", ArgumentSemantic.Assign)]
			set {
				NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakPolicyDelegate_var, value, GetInternalEventPolicyDelegateType);
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPolicyDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPolicyDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakPolicyDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakResourceLoadDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakResourceLoadDelegate {
			[Export ("resourceLoadDelegate", ArgumentSemantic.Assign)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selResourceLoadDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selResourceLoadDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakResourceLoadDelegate_var = ret;
				return ret!;
			}
			[Export ("setResourceLoadDelegate:", ArgumentSemantic.Assign)]
			set {
				NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakResourceLoadDelegate_var, value, GetInternalEventResourceLoadDelegateType);
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetResourceLoadDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetResourceLoadDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakResourceLoadDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakUIDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakUIDelegate {
			[Export ("UIDelegate", ArgumentSemantic.Assign)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUIDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUIDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakUIDelegate_var = ret;
				return ret!;
			}
			[Export ("setUIDelegate:", ArgumentSemantic.Assign)]
			set {
				NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakUIDelegate_var, value, GetInternalEventUIDelegateType);
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetUIDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetUIDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakUIDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebScriptObject WindowScriptObject {
			[Export ("windowScriptObject")]
			get {
				WebScriptObject? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WebScriptObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWindowScriptObjectXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<WebScriptObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWindowScriptObjectXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventFrameLoadDelegateType
		{
			get { return typeof (_WebFrameLoadDelegate); }
		}
		internal virtual _WebFrameLoadDelegate CreateInternalEventFrameLoadDelegateType ()
		{
			return (_WebFrameLoadDelegate)(new _WebFrameLoadDelegate());
		}
		internal _WebFrameLoadDelegate EnsureWebFrameLoadDelegate ()
		{
			if (WeakFrameLoadDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakFrameLoadDelegate, GetInternalEventFrameLoadDelegateType);
			var del = FrameLoadDelegate as _WebFrameLoadDelegate;
			if (del is null){
				del = (_WebFrameLoadDelegate)CreateInternalEventFrameLoadDelegateType ();
				FrameLoadDelegate = (IWebFrameLoadDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _WebFrameLoadDelegate : NSObject, IWebFrameLoadDelegate { 
			public _WebFrameLoadDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_WebFrameLoadDelegate))]
			static _WebFrameLoadDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<WebFrameEventArgs>? canceledClientRedirect;
			[Export ("webView:didCancelClientRedirectForFrame:")]
			public void CanceledClientRedirect (WebKit.WebView sender, WebKit.WebFrame forFrame)
			{
				var handler = canceledClientRedirect;
				if (handler is not null){
					var args = new WebFrameEventArgs (forFrame);
					handler (sender, args);
				}
			}
			internal EventHandler<WebFrameEventArgs>? changedLocationWithinPage;
			[Export ("webView:didChangeLocationWithinPageForFrame:")]
			public void ChangedLocationWithinPage (WebKit.WebView sender, WebKit.WebFrame forFrame)
			{
				var handler = changedLocationWithinPage;
				if (handler is not null){
					var args = new WebFrameEventArgs (forFrame);
					handler (sender, args);
				}
			}
			internal EventHandler<WebFrameScriptFrameEventArgs>? clearedWindowObject;
			[Export ("webView:didClearWindowObject:forFrame:")]
			public void ClearedWindowObject (WebKit.WebView webView, WebKit.WebScriptObject windowObject, WebKit.WebFrame forFrame)
			{
				var handler = clearedWindowObject;
				if (handler is not null){
					var args = new WebFrameScriptFrameEventArgs (windowObject, forFrame);
					handler (webView, args);
				}
			}
			internal EventHandler<WebFrameEventArgs>? commitedLoad;
			[Export ("webView:didCommitLoadForFrame:")]
			public void CommitedLoad (WebKit.WebView sender, WebKit.WebFrame forFrame)
			{
				var handler = commitedLoad;
				if (handler is not null){
					var args = new WebFrameEventArgs (forFrame);
					handler (sender, args);
				}
			}
			internal EventHandler<WebFrameJavaScriptContextEventArgs>? didCreateJavaScriptContext;
			[Export ("webView:didCreateJavaScriptContext:forFrame:")]
			public void DidCreateJavaScriptContext (WebKit.WebView webView, JavaScriptCore.JSContext context, WebKit.WebFrame frame)
			{
				var handler = didCreateJavaScriptContext;
				if (handler is not null){
					var args = new WebFrameJavaScriptContextEventArgs (context, frame);
					handler (webView, args);
				}
			}
			internal EventHandler<WebFrameErrorEventArgs>? failedLoadWithError;
			[Export ("webView:didFailLoadWithError:forFrame:")]
			public void FailedLoadWithError (WebKit.WebView sender, NSError error, WebKit.WebFrame forFrame)
			{
				var handler = failedLoadWithError;
				if (handler is not null){
					var args = new WebFrameErrorEventArgs (error, forFrame);
					handler (sender, args);
				}
			}
			internal EventHandler<WebFrameErrorEventArgs>? failedProvisionalLoad;
			[Export ("webView:didFailProvisionalLoadWithError:forFrame:")]
			public void FailedProvisionalLoad (WebKit.WebView sender, NSError error, WebKit.WebFrame forFrame)
			{
				var handler = failedProvisionalLoad;
				if (handler is not null){
					var args = new WebFrameErrorEventArgs (error, forFrame);
					handler (sender, args);
				}
			}
			internal EventHandler<WebFrameEventArgs>? finishedLoad;
			[Export ("webView:didFinishLoadForFrame:")]
			public void FinishedLoad (WebKit.WebView sender, WebKit.WebFrame forFrame)
			{
				var handler = finishedLoad;
				if (handler is not null){
					var args = new WebFrameEventArgs (forFrame);
					handler (sender, args);
				}
			}
			internal EventHandler<WebFrameImageEventArgs>? receivedIcon;
			[Export ("webView:didReceiveIcon:forFrame:")]
			public void ReceivedIcon (WebKit.WebView sender, NSImage image, WebKit.WebFrame forFrame)
			{
				var handler = receivedIcon;
				if (handler is not null){
					var args = new WebFrameImageEventArgs (image, forFrame);
					handler (sender, args);
				}
			}
			internal EventHandler<WebFrameEventArgs>? receivedServerRedirectForProvisionalLoad;
			[Export ("webView:didReceiveServerRedirectForProvisionalLoadForFrame:")]
			public void ReceivedServerRedirectForProvisionalLoad (WebKit.WebView sender, WebKit.WebFrame forFrame)
			{
				var handler = receivedServerRedirectForProvisionalLoad;
				if (handler is not null){
					var args = new WebFrameEventArgs (forFrame);
					handler (sender, args);
				}
			}
			internal EventHandler<WebFrameTitleEventArgs>? receivedTitle;
			[Export ("webView:didReceiveTitle:forFrame:")]
			public void ReceivedTitle (WebKit.WebView sender, string title, WebKit.WebFrame forFrame)
			{
				var handler = receivedTitle;
				if (handler is not null){
					var args = new WebFrameTitleEventArgs (title, forFrame);
					handler (sender, args);
				}
			}
			internal EventHandler<WebFrameEventArgs>? startedProvisionalLoad;
			[Export ("webView:didStartProvisionalLoadForFrame:")]
			public void StartedProvisionalLoad (WebKit.WebView sender, WebKit.WebFrame forFrame)
			{
				var handler = startedProvisionalLoad;
				if (handler is not null){
					var args = new WebFrameEventArgs (forFrame);
					handler (sender, args);
				}
			}
			internal EventHandler<WebFrameEventArgs>? willCloseFrame;
			[Export ("webView:willCloseFrame:")]
			public void WillCloseFrame (WebKit.WebView sender, WebKit.WebFrame forFrame)
			{
				var handler = willCloseFrame;
				if (handler is not null){
					var args = new WebFrameEventArgs (forFrame);
					handler (sender, args);
				}
			}
			internal EventHandler<WebFrameClientRedirectEventArgs>? willPerformClientRedirect;
			[Export ("webView:willPerformClientRedirectToURL:delay:fireDate:forFrame:")]
			public void WillPerformClientRedirect (WebKit.WebView sender, NSUrl toUrl, double secondsDelay, NSDate fireDate, WebKit.WebFrame forFrame)
			{
				var handler = willPerformClientRedirect;
				if (handler is not null){
					var args = new WebFrameClientRedirectEventArgs (toUrl, secondsDelay, fireDate, forFrame);
					handler (sender, args);
				}
			}
			internal EventHandler<WebFrameScriptObjectEventArgs>? windowScriptObjectAvailable;
			[Export ("webView:windowScriptObjectAvailable:")]
			public void WindowScriptObjectAvailable (WebKit.WebView webView, WebKit.WebScriptObject windowScriptObject)
			{
				var handler = windowScriptObjectAvailable;
				if (handler is not null){
					var args = new WebFrameScriptObjectEventArgs (windowScriptObject);
					handler (webView, args);
				}
			}
		}
		#pragma warning restore 672
		internal virtual Type GetInternalEventDownloadDelegateType
		{
			get { return typeof (_WebDownloadDelegate); }
		}
		internal virtual _WebDownloadDelegate CreateInternalEventDownloadDelegateType ()
		{
			return (_WebDownloadDelegate)(new _WebDownloadDelegate());
		}
		internal _WebDownloadDelegate EnsureWebDownloadDelegate ()
		{
			if (WeakDownloadDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDownloadDelegate, GetInternalEventDownloadDelegateType);
			var del = DownloadDelegate as _WebDownloadDelegate;
			if (del is null){
				del = (_WebDownloadDelegate)CreateInternalEventDownloadDelegateType ();
				DownloadDelegate = (IWebDownloadDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _WebDownloadDelegate : NSObject, IWebDownloadDelegate { 
			public _WebDownloadDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_WebDownloadDelegate))]
			static _WebDownloadDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal WebDownloadRequest? onDownloadWindowForSheet;
			[Export ("downloadWindowForAuthenticationSheet:")]
			public NSWindow OnDownloadWindowForSheet (WebKit.WebDownload download)
			{
				var handler = onDownloadWindowForSheet;
				if (handler is not null)
					return handler (download);
				return null!;
			}
		}
		#pragma warning restore 672
		internal virtual Type GetInternalEventResourceLoadDelegateType
		{
			get { return typeof (_WebResourceLoadDelegate); }
		}
		internal virtual _WebResourceLoadDelegate CreateInternalEventResourceLoadDelegateType ()
		{
			return (_WebResourceLoadDelegate)(new _WebResourceLoadDelegate());
		}
		internal _WebResourceLoadDelegate EnsureWebResourceLoadDelegate ()
		{
			if (WeakResourceLoadDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakResourceLoadDelegate, GetInternalEventResourceLoadDelegateType);
			var del = ResourceLoadDelegate as _WebResourceLoadDelegate;
			if (del is null){
				del = (_WebResourceLoadDelegate)CreateInternalEventResourceLoadDelegateType ();
				ResourceLoadDelegate = (IWebResourceLoadDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _WebResourceLoadDelegate : NSObject, IWebResourceLoadDelegate { 
			public _WebResourceLoadDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_WebResourceLoadDelegate))]
			static _WebResourceLoadDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<WebResourceCancelledChallengeEventArgs>? onCancelledAuthenticationChallenge;
			[Export ("webView:resource:didCancelAuthenticationChallenge:fromDataSource:")]
			public void OnCancelledAuthenticationChallenge (WebKit.WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebKit.WebDataSource dataSource)
			{
				var handler = onCancelledAuthenticationChallenge;
				if (handler is not null){
					var args = new WebResourceCancelledChallengeEventArgs (identifier, challenge, dataSource);
					handler (sender, args);
				}
			}
			internal EventHandler<WebResourceErrorEventArgs>? onFailedLoading;
			[Export ("webView:resource:didFailLoadingWithError:fromDataSource:")]
			public void OnFailedLoading (WebKit.WebView sender, NSObject identifier, NSError withError, WebKit.WebDataSource dataSource)
			{
				var handler = onFailedLoading;
				if (handler is not null){
					var args = new WebResourceErrorEventArgs (identifier, withError, dataSource);
					handler (sender, args);
				}
			}
			internal EventHandler<WebResourceCompletedEventArgs>? onFinishedLoading;
			[Export ("webView:resource:didFinishLoadingFromDataSource:")]
			public void OnFinishedLoading (WebKit.WebView sender, NSObject identifier, WebKit.WebDataSource dataSource)
			{
				var handler = onFinishedLoading;
				if (handler is not null){
					var args = new WebResourceCompletedEventArgs (identifier, dataSource);
					handler (sender, args);
				}
			}
			internal WebResourceIdentifierRequest? onIdentifierForInitialRequest;
			[Export ("webView:identifierForInitialRequest:fromDataSource:")]
			public NSObject OnIdentifierForInitialRequest (WebKit.WebView sender, NSUrlRequest request, WebKit.WebDataSource dataSource)
			{
				var handler = onIdentifierForInitialRequest;
				if (handler is not null)
					return handler (sender, request, dataSource);
				return null!;
			}
			internal EventHandler<WebResourcePluginErrorEventArgs>? onPlugInFailed;
			[Export ("webView:plugInFailedWithError:dataSource:")]
			public void OnPlugInFailed (WebKit.WebView sender, NSError error, WebKit.WebDataSource dataSource)
			{
				var handler = onPlugInFailed;
				if (handler is not null){
					var args = new WebResourcePluginErrorEventArgs (error, dataSource);
					handler (sender, args);
				}
			}
			internal EventHandler<WebResourceAuthenticationChallengeEventArgs>? onReceivedAuthenticationChallenge;
			[Export ("webView:resource:didReceiveAuthenticationChallenge:fromDataSource:")]
			public void OnReceivedAuthenticationChallenge (WebKit.WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebKit.WebDataSource dataSource)
			{
				var handler = onReceivedAuthenticationChallenge;
				if (handler is not null){
					var args = new WebResourceAuthenticationChallengeEventArgs (identifier, challenge, dataSource);
					handler (sender, args);
				}
			}
			internal EventHandler<WebResourceReceivedContentLengthEventArgs>? onReceivedContentLength;
			[Export ("webView:resource:didReceiveContentLength:fromDataSource:")]
			public void OnReceivedContentLength (WebKit.WebView sender, NSObject identifier, IntPtr length, WebKit.WebDataSource dataSource)
			{
				var handler = onReceivedContentLength;
				if (handler is not null){
					var args = new WebResourceReceivedContentLengthEventArgs (identifier, length, dataSource);
					handler (sender, args);
				}
			}
			internal EventHandler<WebResourceReceivedResponseEventArgs>? onReceivedResponse;
			[Export ("webView:resource:didReceiveResponse:fromDataSource:")]
			public void OnReceivedResponse (WebKit.WebView sender, NSObject identifier, NSUrlResponse responseReceived, WebKit.WebDataSource dataSource)
			{
				var handler = onReceivedResponse;
				if (handler is not null){
					var args = new WebResourceReceivedResponseEventArgs (identifier, responseReceived, dataSource);
					handler (sender, args);
				}
			}
			internal WebResourceOnRequestSend? onSendRequest;
			[Export ("webView:resource:willSendRequest:redirectResponse:fromDataSource:")]
			public NSUrlRequest OnSendRequest (WebKit.WebView sender, NSObject identifier, NSUrlRequest request, NSUrlResponse redirectResponse, WebKit.WebDataSource dataSource)
			{
				var handler = onSendRequest;
				if (handler is not null)
					return handler (sender, identifier, request, redirectResponse, dataSource);
				return request!;
			}
		}
		#pragma warning restore 672
		internal virtual Type GetInternalEventUIDelegateType
		{
			get { return typeof (_WebUIDelegate); }
		}
		internal virtual _WebUIDelegate CreateInternalEventUIDelegateType ()
		{
			return (_WebUIDelegate)(new _WebUIDelegate());
		}
		internal _WebUIDelegate EnsureWebUIDelegate ()
		{
			if (WeakUIDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakUIDelegate, GetInternalEventUIDelegateType);
			var del = UIDelegate as _WebUIDelegate;
			if (del is null){
				del = (_WebUIDelegate)CreateInternalEventUIDelegateType ();
				UIDelegate = (IWebUIDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _WebUIDelegate : NSObject, IWebUIDelegate { 
			public _WebUIDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_WebUIDelegate))]
			static _WebUIDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal WebViewGetBool? uIAreToolbarsVisible;
			[Export ("webViewAreToolbarsVisible:")]
			public bool UIAreToolbarsVisible (WebKit.WebView sender)
			{
				var handler = uIAreToolbarsVisible;
				if (handler is not null)
					return handler (sender);
				throw new Exception ("No event handler has been added to the UIAreToolbarsVisible event.");
			}
			internal EventHandler? uIClose;
			[Export ("webViewClose:")]
			public void UIClose (WebKit.WebView sender)
			{
				var handler = uIClose;
				if (handler is not null){
					handler (sender, EventArgs.Empty);
				}
			}
			internal WebViewCreate? uICreateModalDialog;
			[Export ("webView:createWebViewModalDialogWithRequest:")]
			public WebKit.WebView UICreateModalDialog (WebKit.WebView sender, NSUrlRequest request)
			{
				var handler = uICreateModalDialog;
				if (handler is not null)
					return handler (sender, request);
				return null!;
			}
			internal CreateWebViewFromRequest? uICreateWebView;
			[Export ("webView:createWebViewWithRequest:")]
			public WebKit.WebView UICreateWebView (WebKit.WebView sender, NSUrlRequest request)
			{
				var handler = uICreateWebView;
				if (handler is not null)
					return handler (sender, request);
				return null!;
			}
			internal DragSourceGetActionMask? uIDragSourceActionMask;
			[Export ("webView:dragSourceActionMaskForPoint:")]
			public WebKit.WebDragSourceAction UIDragSourceActionMask (WebKit.WebView webView, CGPoint point)
			{
				var handler = uIDragSourceActionMask;
				if (handler is not null)
					return handler (webView, point);
				return WebKit.WebDragSourceAction.None!;
			}
			internal EventHandler<WebViewFooterEventArgs>? uIDrawFooterInRect;
			[Export ("webView:drawFooterInRect:")]
			public void UIDrawFooterInRect (WebKit.WebView sender, CGRect rect)
			{
				var handler = uIDrawFooterInRect;
				if (handler is not null){
					var args = new WebViewFooterEventArgs (rect);
					handler (sender, args);
				}
			}
			internal EventHandler<WebViewHeaderEventArgs>? uIDrawHeaderInRect;
			[Export ("webView:drawHeaderInRect:")]
			public void UIDrawHeaderInRect (WebKit.WebView sender, CGRect rect)
			{
				var handler = uIDrawHeaderInRect;
				if (handler is not null){
					var args = new WebViewHeaderEventArgs (rect);
					handler (sender, args);
				}
			}
			internal EventHandler? uIFocus;
			[Export ("webViewFocus:")]
			public void UIFocus (WebKit.WebView sender)
			{
				var handler = uIFocus;
				if (handler is not null){
					handler (sender, EventArgs.Empty);
				}
			}
			internal WebViewGetRectangle? uIGetContentRect;
			[Export ("webViewContentRect:")]
			public CGRect UIGetContentRect (WebKit.WebView sender)
			{
				var handler = uIGetContentRect;
				if (handler is not null)
					return handler (sender);
				throw new Exception ("No event handler has been added to the UIGetContentRect event.");
			}
			internal WebViewGetContextMenuItems? uIGetContextMenuItems;
			[Export ("webView:contextMenuItemsForElement:defaultMenuItems:")]
			public NSMenuItem[] UIGetContextMenuItems (WebKit.WebView sender, NSDictionary forElement, NSMenuItem[] defaultMenuItems)
			{
				var handler = uIGetContextMenuItems;
				if (handler is not null)
					return handler (sender, forElement, defaultMenuItems);
				return null!;
			}
			internal DragDestinationGetActionMask? uIGetDragDestinationActionMask;
			[Export ("webView:dragDestinationActionMaskForDraggingInfo:")]
			public WebKit.WebDragDestinationAction UIGetDragDestinationActionMask (WebKit.WebView webView, INSDraggingInfo draggingInfo)
			{
				var handler = uIGetDragDestinationActionMask;
				if (handler is not null)
					return handler (webView, draggingInfo);
				return WebKit.WebDragDestinationAction.None!;
			}
			internal WebViewGetResponder? uIGetFirstResponder;
			[Export ("webViewFirstResponder:")]
			public NSResponder UIGetFirstResponder (WebKit.WebView sender)
			{
				var handler = uIGetFirstResponder;
				if (handler is not null)
					return handler (sender);
				return null!;
			}
			internal WebViewGetFloat? uIGetFooterHeight;
			[Export ("webViewFooterHeight:")]
			public float UIGetFooterHeight (WebKit.WebView sender)
			{
				var handler = uIGetFooterHeight;
				if (handler is not null)
					return handler (sender);
				throw new Exception ("No event handler has been added to the UIGetFooterHeight event.");
			}
			internal WebViewGetRectangle? uIGetFrame;
			[Export ("webViewFrame:")]
			public CGRect UIGetFrame (WebKit.WebView sender)
			{
				var handler = uIGetFrame;
				if (handler is not null)
					return handler (sender);
				throw new Exception ("No event handler has been added to the UIGetFrame event.");
			}
			internal WebViewGetFloat? uIGetHeaderHeight;
			[Export ("webViewHeaderHeight:")]
			public float UIGetHeaderHeight (WebKit.WebView sender)
			{
				var handler = uIGetHeaderHeight;
				if (handler is not null)
					return handler (sender);
				throw new Exception ("No event handler has been added to the UIGetHeaderHeight event.");
			}
			internal WebViewGetString? uIGetStatusText;
			[Export ("webViewStatusText:")]
			public string UIGetStatusText (WebKit.WebView sender)
			{
				var handler = uIGetStatusText;
				if (handler is not null)
					return handler (sender);
				return null!;
			}
			internal WebViewGetBool? uIIsResizable;
			[Export ("webViewIsResizable:")]
			public bool UIIsResizable (WebKit.WebView sender)
			{
				var handler = uIIsResizable;
				if (handler is not null)
					return handler (sender);
				throw new Exception ("No event handler has been added to the UIIsResizable event.");
			}
			internal WebViewGetBool? uIIsStatusBarVisible;
			[Export ("webViewIsStatusBarVisible:")]
			public bool UIIsStatusBarVisible (WebKit.WebView sender)
			{
				var handler = uIIsStatusBarVisible;
				if (handler is not null)
					return handler (sender);
				return false!;
			}
			internal EventHandler<WebViewResponderEventArgs>? uIMakeFirstResponder;
			[Export ("webView:makeFirstResponder:")]
			public void UIMakeFirstResponder (WebKit.WebView sender, NSResponder newResponder)
			{
				var handler = uIMakeFirstResponder;
				if (handler is not null){
					var args = new WebViewResponderEventArgs (newResponder);
					handler (sender, args);
				}
			}
			internal EventHandler<WebViewMouseMovedEventArgs>? uIMouseDidMoveOverElement;
			[Export ("webView:mouseDidMoveOverElement:modifierFlags:")]
			public void UIMouseDidMoveOverElement (WebKit.WebView sender, NSDictionary elementInformation, NSEventModifierMask modifierFlags)
			{
				var handler = uIMouseDidMoveOverElement;
				if (handler is not null){
					var args = new WebViewMouseMovedEventArgs (elementInformation, modifierFlags);
					handler (sender, args);
				}
			}
			internal EventHandler<WebViewPrintEventArgs>? uIPrintFrameView;
			[Export ("webView:printFrameView:")]
			public void UIPrintFrameView (WebKit.WebView sender, WebKit.WebFrameView frameView)
			{
				var handler = uIPrintFrameView;
				if (handler is not null){
					var args = new WebViewPrintEventArgs (frameView);
					handler (sender, args);
				}
			}
			internal WebViewJavaScriptFrame? uIRunBeforeUnload;
			[Export ("webView:runBeforeUnloadConfirmPanelWithMessage:initiatedByFrame:")]
			public bool UIRunBeforeUnload (WebKit.WebView sender, string message, WebKit.WebFrame initiatedByFrame)
			{
				var handler = uIRunBeforeUnload;
				if (handler is not null)
					return handler (sender, message, initiatedByFrame);
				throw new Exception ("No event handler has been added to the UIRunBeforeUnload event.");
			}
			internal EventHandler<WebViewJavaScriptEventArgs>? uIRunJavaScriptAlertPanel;
			[Export ("webView:runJavaScriptAlertPanelWithMessage:")]
			public void UIRunJavaScriptAlertPanel (WebKit.WebView sender, string message)
			{
				var handler = uIRunJavaScriptAlertPanel;
				if (handler is not null){
					var args = new WebViewJavaScriptEventArgs (message);
					handler (sender, args);
				}
			}
			internal EventHandler<WebViewJavaScriptFrameEventArgs>? uIRunJavaScriptAlertPanelMessage;
			[Export ("webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:")]
			public void UIRunJavaScriptAlertPanelMessage (WebKit.WebView sender, string withMessage, WebKit.WebFrame initiatedByFrame)
			{
				var handler = uIRunJavaScriptAlertPanelMessage;
				if (handler is not null){
					var args = new WebViewJavaScriptFrameEventArgs (withMessage, initiatedByFrame);
					handler (sender, args);
				}
			}
			internal WebViewPrompt? uIRunJavaScriptConfirmPanel;
			[Export ("webView:runJavaScriptConfirmPanelWithMessage:")]
			public bool UIRunJavaScriptConfirmPanel (WebKit.WebView sender, string message)
			{
				var handler = uIRunJavaScriptConfirmPanel;
				if (handler is not null)
					return handler (sender, message);
				throw new Exception ("No event handler has been added to the UIRunJavaScriptConfirmPanel event.");
			}
			internal WebViewConfirmationPanel? uIRunJavaScriptConfirmationPanel;
			[Export ("webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:")]
			public bool UIRunJavaScriptConfirmationPanel (WebKit.WebView sender, string withMessage, WebKit.WebFrame initiatedByFrame)
			{
				var handler = uIRunJavaScriptConfirmationPanel;
				if (handler is not null)
					return handler (sender, withMessage, initiatedByFrame);
				throw new Exception ("No event handler has been added to the UIRunJavaScriptConfirmationPanel event.");
			}
			internal WebViewJavaScriptInput? uIRunJavaScriptTextInputPanel;
			[Export ("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:")]
			public string UIRunJavaScriptTextInputPanel (WebKit.WebView sender, string prompt, string defaultText)
			{
				var handler = uIRunJavaScriptTextInputPanel;
				if (handler is not null)
					return handler (sender, prompt, defaultText);
				return null!;
			}
			internal WebViewPromptPanel? uIRunJavaScriptTextInputPanelWithFrame;
			[Export ("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:")]
			public string UIRunJavaScriptTextInputPanelWithFrame (WebKit.WebView sender, string prompt, string defaultText, WebKit.WebFrame initiatedByFrame)
			{
				var handler = uIRunJavaScriptTextInputPanelWithFrame;
				if (handler is not null)
					return handler (sender, prompt, defaultText, initiatedByFrame);
				return null!;
			}
			internal EventHandler? uIRunModal;
			[Export ("webViewRunModal:")]
			public void UIRunModal (WebKit.WebView sender)
			{
				var handler = uIRunModal;
				if (handler is not null){
					handler (sender, EventArgs.Empty);
				}
			}
			internal EventHandler<WebViewRunOpenPanelEventArgs>? uIRunOpenPanelForFileButton;
			[Export ("webView:runOpenPanelForFileButtonWithResultListener:")]
			public void UIRunOpenPanelForFileButton (WebKit.WebView sender, WebKit.IWebOpenPanelResultListener resultListener)
			{
				var handler = uIRunOpenPanelForFileButton;
				if (handler is not null){
					var args = new WebViewRunOpenPanelEventArgs (resultListener);
					handler (sender, args);
				}
			}
			internal EventHandler<WebViewContentEventArgs>? uISetContentRect;
			[Export ("webView:setContentRect:")]
			public void UISetContentRect (WebKit.WebView sender, CGRect frame)
			{
				var handler = uISetContentRect;
				if (handler is not null){
					var args = new WebViewContentEventArgs (frame);
					handler (sender, args);
				}
			}
			internal EventHandler<WebViewFrameEventArgs>? uISetFrame;
			[Export ("webView:setFrame:")]
			public void UISetFrame (WebKit.WebView sender, CGRect newFrame)
			{
				var handler = uISetFrame;
				if (handler is not null){
					var args = new WebViewFrameEventArgs (newFrame);
					handler (sender, args);
				}
			}
			internal EventHandler<WebViewResizableEventArgs>? uISetResizable;
			[Export ("webView:setResizable:")]
			public void UISetResizable (WebKit.WebView sender, bool resizable)
			{
				var handler = uISetResizable;
				if (handler is not null){
					var args = new WebViewResizableEventArgs (resizable);
					handler (sender, args);
				}
			}
			internal EventHandler<WebViewStatusBarEventArgs>? uISetStatusBarVisible;
			[Export ("webView:setStatusBarVisible:")]
			public void UISetStatusBarVisible (WebKit.WebView sender, bool visible)
			{
				var handler = uISetStatusBarVisible;
				if (handler is not null){
					var args = new WebViewStatusBarEventArgs (visible);
					handler (sender, args);
				}
			}
			internal EventHandler<WebViewStatusTextEventArgs>? uISetStatusText;
			[Export ("webView:setStatusText:")]
			public void UISetStatusText (WebKit.WebView sender, string text)
			{
				var handler = uISetStatusText;
				if (handler is not null){
					var args = new WebViewStatusTextEventArgs (text);
					handler (sender, args);
				}
			}
			internal EventHandler<WebViewToolBarsEventArgs>? uISetToolbarsVisible;
			[Export ("webView:setToolbarsVisible:")]
			public void UISetToolbarsVisible (WebKit.WebView sender, bool visible)
			{
				var handler = uISetToolbarsVisible;
				if (handler is not null){
					var args = new WebViewToolBarsEventArgs (visible);
					handler (sender, args);
				}
			}
			internal WebViewPerformAction? uIShouldPerformAction;
			[Export ("webView:shouldPerformAction:fromSender:")]
			public bool UIShouldPerformAction (WebKit.WebView webView, Selector action, NSObject sender)
			{
				var handler = uIShouldPerformAction;
				if (handler is not null)
					return handler (webView, action, sender);
				throw new Exception ("No event handler has been added to the UIShouldPerformAction event.");
			}
			internal EventHandler? uIShow;
			[Export ("webViewShow:")]
			public void UIShow (WebKit.WebView sender)
			{
				var handler = uIShow;
				if (handler is not null){
					handler (sender, EventArgs.Empty);
				}
			}
			internal EventHandler? uIUnfocus;
			[Export ("webViewUnfocus:")]
			public void UIUnfocus (WebKit.WebView sender)
			{
				var handler = uIUnfocus;
				if (handler is not null){
					handler (sender, EventArgs.Empty);
				}
			}
			internal WebViewValidateUserInterface? uIValidateUserInterfaceItem;
			[Export ("webView:validateUserInterfaceItem:defaultValidation:")]
			public bool UIValidateUserInterfaceItem (WebKit.WebView webView, NSObject validatedUserInterfaceItem, bool defaultValidation)
			{
				var handler = uIValidateUserInterfaceItem;
				if (handler is not null)
					return handler (webView, validatedUserInterfaceItem, defaultValidation);
				return defaultValidation!;
			}
			internal EventHandler<WebViewDragEventArgs>? uIWillPerformDragDestination;
			[Export ("webView:willPerformDragDestinationAction:forDraggingInfo:")]
			public void UIWillPerformDragDestination (WebKit.WebView webView, WebKit.WebDragDestinationAction action, INSDraggingInfo draggingInfo)
			{
				var handler = uIWillPerformDragDestination;
				if (handler is not null){
					var args = new WebViewDragEventArgs (action, draggingInfo);
					handler (webView, args);
				}
			}
			internal EventHandler<WebViewPerformDragEventArgs>? uIWillPerformDragSource;
			[Export ("webView:willPerformDragSourceAction:fromPoint:withPasteboard:")]
			public void UIWillPerformDragSource (WebKit.WebView webView, WebKit.WebDragSourceAction action, CGPoint sourcePoint, NSPasteboard pasteboard)
			{
				var handler = uIWillPerformDragSource;
				if (handler is not null){
					var args = new WebViewPerformDragEventArgs (action, sourcePoint, pasteboard);
					handler (webView, args);
				}
			}
		}
		#pragma warning restore 672
		internal virtual Type GetInternalEventPolicyDelegateType
		{
			get { return typeof (_WebPolicyDelegate); }
		}
		internal virtual _WebPolicyDelegate CreateInternalEventPolicyDelegateType ()
		{
			return (_WebPolicyDelegate)(new _WebPolicyDelegate());
		}
		internal _WebPolicyDelegate EnsureWebPolicyDelegate ()
		{
			if (WeakPolicyDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakPolicyDelegate, GetInternalEventPolicyDelegateType);
			var del = PolicyDelegate as _WebPolicyDelegate;
			if (del is null){
				del = (_WebPolicyDelegate)CreateInternalEventPolicyDelegateType ();
				PolicyDelegate = (IWebPolicyDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _WebPolicyDelegate : NSObject, IWebPolicyDelegate { 
			public _WebPolicyDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_WebPolicyDelegate))]
			static _WebPolicyDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<WebMimeTypePolicyEventArgs>? decidePolicyForMimeType;
			[Export ("webView:decidePolicyForMIMEType:request:frame:decisionListener:")]
			public void DecidePolicyForMimeType (WebKit.WebView webView, string mimeType, NSUrlRequest request, WebKit.WebFrame frame, NSObject decisionToken)
			{
				var handler = decidePolicyForMimeType;
				if (handler is not null){
					var args = new WebMimeTypePolicyEventArgs (mimeType, request, frame, decisionToken);
					handler (webView, args);
				}
			}
			internal EventHandler<WebNavigationPolicyEventArgs>? decidePolicyForNavigation;
			[Export ("webView:decidePolicyForNavigationAction:request:frame:decisionListener:")]
			public void DecidePolicyForNavigation (WebKit.WebView webView, NSDictionary actionInformation, NSUrlRequest request, WebKit.WebFrame frame, NSObject decisionToken)
			{
				var handler = decidePolicyForNavigation;
				if (handler is not null){
					var args = new WebNavigationPolicyEventArgs (actionInformation, request, frame, decisionToken);
					handler (webView, args);
				}
			}
			internal EventHandler<WebNewWindowPolicyEventArgs>? decidePolicyForNewWindow;
			[Export ("webView:decidePolicyForNewWindowAction:request:newFrameName:decisionListener:")]
			public void DecidePolicyForNewWindow (WebKit.WebView webView, NSDictionary actionInformation, NSUrlRequest request, string newFrameName, NSObject decisionToken)
			{
				var handler = decidePolicyForNewWindow;
				if (handler is not null){
					var args = new WebNewWindowPolicyEventArgs (actionInformation, request, newFrameName, decisionToken);
					handler (webView, args);
				}
			}
			internal EventHandler<WebFailureToImplementPolicyEventArgs>? unableToImplementPolicy;
			[Export ("webView:unableToImplementPolicyWithError:frame:")]
			public void UnableToImplementPolicy (WebKit.WebView webView, NSError error, WebKit.WebFrame frame)
			{
				var handler = unableToImplementPolicy;
				if (handler is not null){
					var args = new WebFailureToImplementPolicyEventArgs (error, frame);
					handler (webView, args);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebDownloadRequest? OnDownloadWindowForSheet {
			get { return EnsureWebDownloadDelegate ()!.onDownloadWindowForSheet; }
			set { EnsureWebDownloadDelegate ()!.onDownloadWindowForSheet = value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebFrameEventArgs> CanceledClientRedirect {
			add { EnsureWebFrameLoadDelegate ()!.canceledClientRedirect += value; }
			remove { EnsureWebFrameLoadDelegate ()!.canceledClientRedirect -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebFrameEventArgs> ChangedLocationWithinPage {
			add { EnsureWebFrameLoadDelegate ()!.changedLocationWithinPage += value; }
			remove { EnsureWebFrameLoadDelegate ()!.changedLocationWithinPage -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebFrameScriptFrameEventArgs> ClearedWindowObject {
			add { EnsureWebFrameLoadDelegate ()!.clearedWindowObject += value; }
			remove { EnsureWebFrameLoadDelegate ()!.clearedWindowObject -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebFrameEventArgs> CommitedLoad {
			add { EnsureWebFrameLoadDelegate ()!.commitedLoad += value; }
			remove { EnsureWebFrameLoadDelegate ()!.commitedLoad -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebFrameJavaScriptContextEventArgs> DidCreateJavaScriptContext {
			add { EnsureWebFrameLoadDelegate ()!.didCreateJavaScriptContext += value; }
			remove { EnsureWebFrameLoadDelegate ()!.didCreateJavaScriptContext -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebFrameErrorEventArgs> FailedLoadWithError {
			add { EnsureWebFrameLoadDelegate ()!.failedLoadWithError += value; }
			remove { EnsureWebFrameLoadDelegate ()!.failedLoadWithError -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebFrameErrorEventArgs> FailedProvisionalLoad {
			add { EnsureWebFrameLoadDelegate ()!.failedProvisionalLoad += value; }
			remove { EnsureWebFrameLoadDelegate ()!.failedProvisionalLoad -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebFrameEventArgs> FinishedLoad {
			add { EnsureWebFrameLoadDelegate ()!.finishedLoad += value; }
			remove { EnsureWebFrameLoadDelegate ()!.finishedLoad -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebFrameImageEventArgs> ReceivedIcon {
			add { EnsureWebFrameLoadDelegate ()!.receivedIcon += value; }
			remove { EnsureWebFrameLoadDelegate ()!.receivedIcon -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebFrameEventArgs> ReceivedServerRedirectForProvisionalLoad {
			add { EnsureWebFrameLoadDelegate ()!.receivedServerRedirectForProvisionalLoad += value; }
			remove { EnsureWebFrameLoadDelegate ()!.receivedServerRedirectForProvisionalLoad -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebFrameTitleEventArgs> ReceivedTitle {
			add { EnsureWebFrameLoadDelegate ()!.receivedTitle += value; }
			remove { EnsureWebFrameLoadDelegate ()!.receivedTitle -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebFrameEventArgs> StartedProvisionalLoad {
			add { EnsureWebFrameLoadDelegate ()!.startedProvisionalLoad += value; }
			remove { EnsureWebFrameLoadDelegate ()!.startedProvisionalLoad -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebFrameEventArgs> WillCloseFrame {
			add { EnsureWebFrameLoadDelegate ()!.willCloseFrame += value; }
			remove { EnsureWebFrameLoadDelegate ()!.willCloseFrame -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebFrameClientRedirectEventArgs> WillPerformClientRedirect {
			add { EnsureWebFrameLoadDelegate ()!.willPerformClientRedirect += value; }
			remove { EnsureWebFrameLoadDelegate ()!.willPerformClientRedirect -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebFrameScriptObjectEventArgs> WindowScriptObjectAvailable {
			add { EnsureWebFrameLoadDelegate ()!.windowScriptObjectAvailable += value; }
			remove { EnsureWebFrameLoadDelegate ()!.windowScriptObjectAvailable -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebMimeTypePolicyEventArgs> DecidePolicyForMimeType {
			add { EnsureWebPolicyDelegate ()!.decidePolicyForMimeType += value; }
			remove { EnsureWebPolicyDelegate ()!.decidePolicyForMimeType -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebNavigationPolicyEventArgs> DecidePolicyForNavigation {
			add { EnsureWebPolicyDelegate ()!.decidePolicyForNavigation += value; }
			remove { EnsureWebPolicyDelegate ()!.decidePolicyForNavigation -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebNewWindowPolicyEventArgs> DecidePolicyForNewWindow {
			add { EnsureWebPolicyDelegate ()!.decidePolicyForNewWindow += value; }
			remove { EnsureWebPolicyDelegate ()!.decidePolicyForNewWindow -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebFailureToImplementPolicyEventArgs> UnableToImplementPolicy {
			add { EnsureWebPolicyDelegate ()!.unableToImplementPolicy += value; }
			remove { EnsureWebPolicyDelegate ()!.unableToImplementPolicy -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebResourceCancelledChallengeEventArgs> OnCancelledAuthenticationChallenge {
			add { EnsureWebResourceLoadDelegate ()!.onCancelledAuthenticationChallenge += value; }
			remove { EnsureWebResourceLoadDelegate ()!.onCancelledAuthenticationChallenge -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebResourceErrorEventArgs> OnFailedLoading {
			add { EnsureWebResourceLoadDelegate ()!.onFailedLoading += value; }
			remove { EnsureWebResourceLoadDelegate ()!.onFailedLoading -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebResourceCompletedEventArgs> OnFinishedLoading {
			add { EnsureWebResourceLoadDelegate ()!.onFinishedLoading += value; }
			remove { EnsureWebResourceLoadDelegate ()!.onFinishedLoading -= value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebResourceIdentifierRequest? OnIdentifierForInitialRequest {
			get { return EnsureWebResourceLoadDelegate ()!.onIdentifierForInitialRequest; }
			set { EnsureWebResourceLoadDelegate ()!.onIdentifierForInitialRequest = value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebResourcePluginErrorEventArgs> OnPlugInFailed {
			add { EnsureWebResourceLoadDelegate ()!.onPlugInFailed += value; }
			remove { EnsureWebResourceLoadDelegate ()!.onPlugInFailed -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebResourceAuthenticationChallengeEventArgs> OnReceivedAuthenticationChallenge {
			add { EnsureWebResourceLoadDelegate ()!.onReceivedAuthenticationChallenge += value; }
			remove { EnsureWebResourceLoadDelegate ()!.onReceivedAuthenticationChallenge -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebResourceReceivedContentLengthEventArgs> OnReceivedContentLength {
			add { EnsureWebResourceLoadDelegate ()!.onReceivedContentLength += value; }
			remove { EnsureWebResourceLoadDelegate ()!.onReceivedContentLength -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebResourceReceivedResponseEventArgs> OnReceivedResponse {
			add { EnsureWebResourceLoadDelegate ()!.onReceivedResponse += value; }
			remove { EnsureWebResourceLoadDelegate ()!.onReceivedResponse -= value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebResourceOnRequestSend? OnSendRequest {
			get { return EnsureWebResourceLoadDelegate ()!.onSendRequest; }
			set { EnsureWebResourceLoadDelegate ()!.onSendRequest = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebViewGetBool? UIAreToolbarsVisible {
			get { return EnsureWebUIDelegate ()!.uIAreToolbarsVisible; }
			set { EnsureWebUIDelegate ()!.uIAreToolbarsVisible = value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler UIClose {
			add { EnsureWebUIDelegate ()!.uIClose += value; }
			remove { EnsureWebUIDelegate ()!.uIClose -= value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebViewCreate? UICreateModalDialog {
			get { return EnsureWebUIDelegate ()!.uICreateModalDialog; }
			set { EnsureWebUIDelegate ()!.uICreateModalDialog = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public CreateWebViewFromRequest? UICreateWebView {
			get { return EnsureWebUIDelegate ()!.uICreateWebView; }
			set { EnsureWebUIDelegate ()!.uICreateWebView = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public DragSourceGetActionMask? UIDragSourceActionMask {
			get { return EnsureWebUIDelegate ()!.uIDragSourceActionMask; }
			set { EnsureWebUIDelegate ()!.uIDragSourceActionMask = value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebViewFooterEventArgs> UIDrawFooterInRect {
			add { EnsureWebUIDelegate ()!.uIDrawFooterInRect += value; }
			remove { EnsureWebUIDelegate ()!.uIDrawFooterInRect -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebViewHeaderEventArgs> UIDrawHeaderInRect {
			add { EnsureWebUIDelegate ()!.uIDrawHeaderInRect += value; }
			remove { EnsureWebUIDelegate ()!.uIDrawHeaderInRect -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler UIFocus {
			add { EnsureWebUIDelegate ()!.uIFocus += value; }
			remove { EnsureWebUIDelegate ()!.uIFocus -= value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebViewGetRectangle? UIGetContentRect {
			get { return EnsureWebUIDelegate ()!.uIGetContentRect; }
			set { EnsureWebUIDelegate ()!.uIGetContentRect = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebViewGetContextMenuItems? UIGetContextMenuItems {
			get { return EnsureWebUIDelegate ()!.uIGetContextMenuItems; }
			set { EnsureWebUIDelegate ()!.uIGetContextMenuItems = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public DragDestinationGetActionMask? UIGetDragDestinationActionMask {
			get { return EnsureWebUIDelegate ()!.uIGetDragDestinationActionMask; }
			set { EnsureWebUIDelegate ()!.uIGetDragDestinationActionMask = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebViewGetResponder? UIGetFirstResponder {
			get { return EnsureWebUIDelegate ()!.uIGetFirstResponder; }
			set { EnsureWebUIDelegate ()!.uIGetFirstResponder = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebViewGetFloat? UIGetFooterHeight {
			get { return EnsureWebUIDelegate ()!.uIGetFooterHeight; }
			set { EnsureWebUIDelegate ()!.uIGetFooterHeight = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebViewGetRectangle? UIGetFrame {
			get { return EnsureWebUIDelegate ()!.uIGetFrame; }
			set { EnsureWebUIDelegate ()!.uIGetFrame = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebViewGetFloat? UIGetHeaderHeight {
			get { return EnsureWebUIDelegate ()!.uIGetHeaderHeight; }
			set { EnsureWebUIDelegate ()!.uIGetHeaderHeight = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebViewGetString? UIGetStatusText {
			get { return EnsureWebUIDelegate ()!.uIGetStatusText; }
			set { EnsureWebUIDelegate ()!.uIGetStatusText = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebViewGetBool? UIIsResizable {
			get { return EnsureWebUIDelegate ()!.uIIsResizable; }
			set { EnsureWebUIDelegate ()!.uIIsResizable = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebViewGetBool? UIIsStatusBarVisible {
			get { return EnsureWebUIDelegate ()!.uIIsStatusBarVisible; }
			set { EnsureWebUIDelegate ()!.uIIsStatusBarVisible = value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebViewResponderEventArgs> UIMakeFirstResponder {
			add { EnsureWebUIDelegate ()!.uIMakeFirstResponder += value; }
			remove { EnsureWebUIDelegate ()!.uIMakeFirstResponder -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebViewMouseMovedEventArgs> UIMouseDidMoveOverElement {
			add { EnsureWebUIDelegate ()!.uIMouseDidMoveOverElement += value; }
			remove { EnsureWebUIDelegate ()!.uIMouseDidMoveOverElement -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebViewPrintEventArgs> UIPrintFrameView {
			add { EnsureWebUIDelegate ()!.uIPrintFrameView += value; }
			remove { EnsureWebUIDelegate ()!.uIPrintFrameView -= value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebViewJavaScriptFrame? UIRunBeforeUnload {
			get { return EnsureWebUIDelegate ()!.uIRunBeforeUnload; }
			set { EnsureWebUIDelegate ()!.uIRunBeforeUnload = value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebViewJavaScriptEventArgs> UIRunJavaScriptAlertPanel {
			add { EnsureWebUIDelegate ()!.uIRunJavaScriptAlertPanel += value; }
			remove { EnsureWebUIDelegate ()!.uIRunJavaScriptAlertPanel -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebViewJavaScriptFrameEventArgs> UIRunJavaScriptAlertPanelMessage {
			add { EnsureWebUIDelegate ()!.uIRunJavaScriptAlertPanelMessage += value; }
			remove { EnsureWebUIDelegate ()!.uIRunJavaScriptAlertPanelMessage -= value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebViewPrompt? UIRunJavaScriptConfirmPanel {
			get { return EnsureWebUIDelegate ()!.uIRunJavaScriptConfirmPanel; }
			set { EnsureWebUIDelegate ()!.uIRunJavaScriptConfirmPanel = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebViewConfirmationPanel? UIRunJavaScriptConfirmationPanel {
			get { return EnsureWebUIDelegate ()!.uIRunJavaScriptConfirmationPanel; }
			set { EnsureWebUIDelegate ()!.uIRunJavaScriptConfirmationPanel = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebViewJavaScriptInput? UIRunJavaScriptTextInputPanel {
			get { return EnsureWebUIDelegate ()!.uIRunJavaScriptTextInputPanel; }
			set { EnsureWebUIDelegate ()!.uIRunJavaScriptTextInputPanel = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebViewPromptPanel? UIRunJavaScriptTextInputPanelWithFrame {
			get { return EnsureWebUIDelegate ()!.uIRunJavaScriptTextInputPanelWithFrame; }
			set { EnsureWebUIDelegate ()!.uIRunJavaScriptTextInputPanelWithFrame = value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler UIRunModal {
			add { EnsureWebUIDelegate ()!.uIRunModal += value; }
			remove { EnsureWebUIDelegate ()!.uIRunModal -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebViewRunOpenPanelEventArgs> UIRunOpenPanelForFileButton {
			add { EnsureWebUIDelegate ()!.uIRunOpenPanelForFileButton += value; }
			remove { EnsureWebUIDelegate ()!.uIRunOpenPanelForFileButton -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebViewContentEventArgs> UISetContentRect {
			add { EnsureWebUIDelegate ()!.uISetContentRect += value; }
			remove { EnsureWebUIDelegate ()!.uISetContentRect -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebViewFrameEventArgs> UISetFrame {
			add { EnsureWebUIDelegate ()!.uISetFrame += value; }
			remove { EnsureWebUIDelegate ()!.uISetFrame -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebViewResizableEventArgs> UISetResizable {
			add { EnsureWebUIDelegate ()!.uISetResizable += value; }
			remove { EnsureWebUIDelegate ()!.uISetResizable -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebViewStatusBarEventArgs> UISetStatusBarVisible {
			add { EnsureWebUIDelegate ()!.uISetStatusBarVisible += value; }
			remove { EnsureWebUIDelegate ()!.uISetStatusBarVisible -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebViewStatusTextEventArgs> UISetStatusText {
			add { EnsureWebUIDelegate ()!.uISetStatusText += value; }
			remove { EnsureWebUIDelegate ()!.uISetStatusText -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebViewToolBarsEventArgs> UISetToolbarsVisible {
			add { EnsureWebUIDelegate ()!.uISetToolbarsVisible += value; }
			remove { EnsureWebUIDelegate ()!.uISetToolbarsVisible -= value; }
		}
		public WebViewPerformAction? UIShouldPerformAction {
			get { return EnsureWebUIDelegate ()!.uIShouldPerformAction; }
			set { EnsureWebUIDelegate ()!.uIShouldPerformAction = value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler UIShow {
			add { EnsureWebUIDelegate ()!.uIShow += value; }
			remove { EnsureWebUIDelegate ()!.uIShow -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler UIUnfocus {
			add { EnsureWebUIDelegate ()!.uIUnfocus += value; }
			remove { EnsureWebUIDelegate ()!.uIUnfocus -= value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public WebViewValidateUserInterface? UIValidateUserInterfaceItem {
			get { return EnsureWebUIDelegate ()!.uIValidateUserInterfaceItem; }
			set { EnsureWebUIDelegate ()!.uIValidateUserInterfaceItem = value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebViewDragEventArgs> UIWillPerformDragDestination {
			add { EnsureWebUIDelegate ()!.uIWillPerformDragDestination += value; }
			remove { EnsureWebUIDelegate ()!.uIWillPerformDragDestination -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<WebViewPerformDragEventArgs> UIWillPerformDragSource {
			add { EnsureWebUIDelegate ()!.uIWillPerformDragSource += value; }
			remove { EnsureWebUIDelegate ()!.uIWillPerformDragSource -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_EditingDelegate_var = null;
				__mt_WeakDownloadDelegate_var = null;
				__mt_WeakFrameLoadDelegate_var = null;
				__mt_WeakPolicyDelegate_var = null;
				__mt_WeakResourceLoadDelegate_var = null;
				__mt_WeakUIDelegate_var = null;
			}
		}
	} /* class WebView */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebFailureToImplementPolicyEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebFailureToImplementPolicyEventArgs" /> with the specified event data.</summary>
		/// <param name="error">The value for the <see cref="Error" /> property.</param>
		/// <param name="frame">The value for the <see cref="Frame" /> property.</param>
		public WebFailureToImplementPolicyEventArgs (NSError error, WebKit.WebFrame frame)
		{
			this.Error = error;
			this.Frame = frame;
		}
		public NSError Error { get; set; }
		public WebKit.WebFrame Frame { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebFrameClientRedirectEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebFrameClientRedirectEventArgs" /> with the specified event data.</summary>
		/// <param name="toUrl">The value for the <see cref="ToUrl" /> property.</param>
		/// <param name="secondsDelay">The value for the <see cref="SecondsDelay" /> property.</param>
		/// <param name="fireDate">The value for the <see cref="FireDate" /> property.</param>
		/// <param name="forFrame">The value for the <see cref="ForFrame" /> property.</param>
		public WebFrameClientRedirectEventArgs (NSUrl toUrl, double secondsDelay, NSDate fireDate, WebKit.WebFrame forFrame)
		{
			this.FireDate = fireDate;
			this.ForFrame = forFrame;
			this.SecondsDelay = secondsDelay;
			this.ToUrl = toUrl;
		}
		public NSDate FireDate { get; set; }
		public WebKit.WebFrame ForFrame { get; set; }
		public double SecondsDelay { get; set; }
		public NSUrl ToUrl { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebFrameErrorEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebFrameErrorEventArgs" /> with the specified event data.</summary>
		/// <param name="error">The value for the <see cref="Error" /> property.</param>
		/// <param name="forFrame">The value for the <see cref="ForFrame" /> property.</param>
		public WebFrameErrorEventArgs (NSError error, WebKit.WebFrame forFrame)
		{
			this.Error = error;
			this.ForFrame = forFrame;
		}
		public NSError Error { get; set; }
		public WebKit.WebFrame ForFrame { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebFrameEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebFrameEventArgs" /> with the specified event data.</summary>
		/// <param name="forFrame">The value for the <see cref="ForFrame" /> property.</param>
		public WebFrameEventArgs (WebKit.WebFrame forFrame)
		{
			this.ForFrame = forFrame;
		}
		public WebKit.WebFrame ForFrame { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebFrameImageEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebFrameImageEventArgs" /> with the specified event data.</summary>
		/// <param name="image">The value for the <see cref="Image" /> property.</param>
		/// <param name="forFrame">The value for the <see cref="ForFrame" /> property.</param>
		public WebFrameImageEventArgs (NSImage image, WebKit.WebFrame forFrame)
		{
			this.ForFrame = forFrame;
			this.Image = image;
		}
		public WebKit.WebFrame ForFrame { get; set; }
		public NSImage Image { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebFrameJavaScriptContextEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebFrameJavaScriptContextEventArgs" /> with the specified event data.</summary>
		/// <param name="context">The value for the <see cref="Context" /> property.</param>
		/// <param name="frame">The value for the <see cref="Frame" /> property.</param>
		public WebFrameJavaScriptContextEventArgs (JavaScriptCore.JSContext context, WebKit.WebFrame frame)
		{
			this.Context = context;
			this.Frame = frame;
		}
		public JavaScriptCore.JSContext Context { get; set; }
		public WebKit.WebFrame Frame { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebFrameScriptFrameEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebFrameScriptFrameEventArgs" /> with the specified event data.</summary>
		/// <param name="windowObject">The value for the <see cref="WindowObject" /> property.</param>
		/// <param name="forFrame">The value for the <see cref="ForFrame" /> property.</param>
		public WebFrameScriptFrameEventArgs (WebKit.WebScriptObject windowObject, WebKit.WebFrame forFrame)
		{
			this.ForFrame = forFrame;
			this.WindowObject = windowObject;
		}
		public WebKit.WebFrame ForFrame { get; set; }
		public WebKit.WebScriptObject WindowObject { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebFrameScriptObjectEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebFrameScriptObjectEventArgs" /> with the specified event data.</summary>
		/// <param name="windowScriptObject">The value for the <see cref="WindowScriptObject" /> property.</param>
		public WebFrameScriptObjectEventArgs (WebKit.WebScriptObject windowScriptObject)
		{
			this.WindowScriptObject = windowScriptObject;
		}
		public WebKit.WebScriptObject WindowScriptObject { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebFrameTitleEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebFrameTitleEventArgs" /> with the specified event data.</summary>
		/// <param name="title">The value for the <see cref="Title" /> property.</param>
		/// <param name="forFrame">The value for the <see cref="ForFrame" /> property.</param>
		public WebFrameTitleEventArgs (string title, WebKit.WebFrame forFrame)
		{
			this.ForFrame = forFrame;
			this.Title = title;
		}
		public WebKit.WebFrame ForFrame { get; set; }
		public string Title { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebMimeTypePolicyEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebMimeTypePolicyEventArgs" /> with the specified event data.</summary>
		/// <param name="mimeType">The value for the <see cref="MimeType" /> property.</param>
		/// <param name="request">The value for the <see cref="Request" /> property.</param>
		/// <param name="frame">The value for the <see cref="Frame" /> property.</param>
		/// <param name="decisionToken">The value for the <see cref="DecisionToken" /> property.</param>
		public WebMimeTypePolicyEventArgs (string mimeType, NSUrlRequest request, WebKit.WebFrame frame, NSObject decisionToken)
		{
			this.DecisionToken = decisionToken;
			this.Frame = frame;
			this.MimeType = mimeType;
			this.Request = request;
		}
		public NSObject DecisionToken { get; set; }
		public WebKit.WebFrame Frame { get; set; }
		public string MimeType { get; set; }
		public NSUrlRequest Request { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebNavigationPolicyEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebNavigationPolicyEventArgs" /> with the specified event data.</summary>
		/// <param name="actionInformation">The value for the <see cref="ActionInformation" /> property.</param>
		/// <param name="request">The value for the <see cref="Request" /> property.</param>
		/// <param name="frame">The value for the <see cref="Frame" /> property.</param>
		/// <param name="decisionToken">The value for the <see cref="DecisionToken" /> property.</param>
		public WebNavigationPolicyEventArgs (NSDictionary actionInformation, NSUrlRequest request, WebKit.WebFrame frame, NSObject decisionToken)
		{
			this.ActionInformation = actionInformation;
			this.DecisionToken = decisionToken;
			this.Frame = frame;
			this.Request = request;
		}
		public NSDictionary ActionInformation { get; set; }
		public NSObject DecisionToken { get; set; }
		public WebKit.WebFrame Frame { get; set; }
		public NSUrlRequest Request { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebNewWindowPolicyEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebNewWindowPolicyEventArgs" /> with the specified event data.</summary>
		/// <param name="actionInformation">The value for the <see cref="ActionInformation" /> property.</param>
		/// <param name="request">The value for the <see cref="Request" /> property.</param>
		/// <param name="newFrameName">The value for the <see cref="NewFrameName" /> property.</param>
		/// <param name="decisionToken">The value for the <see cref="DecisionToken" /> property.</param>
		public WebNewWindowPolicyEventArgs (NSDictionary actionInformation, NSUrlRequest request, string newFrameName, NSObject decisionToken)
		{
			this.ActionInformation = actionInformation;
			this.DecisionToken = decisionToken;
			this.NewFrameName = newFrameName;
			this.Request = request;
		}
		public NSDictionary ActionInformation { get; set; }
		public NSObject DecisionToken { get; set; }
		public string NewFrameName { get; set; }
		public NSUrlRequest Request { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebResourceAuthenticationChallengeEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebResourceAuthenticationChallengeEventArgs" /> with the specified event data.</summary>
		/// <param name="identifier">The value for the <see cref="Identifier" /> property.</param>
		/// <param name="challenge">The value for the <see cref="Challenge" /> property.</param>
		/// <param name="dataSource">The value for the <see cref="DataSource" /> property.</param>
		public WebResourceAuthenticationChallengeEventArgs (NSObject identifier, NSUrlAuthenticationChallenge challenge, WebKit.WebDataSource dataSource)
		{
			this.Challenge = challenge;
			this.DataSource = dataSource;
			this.Identifier = identifier;
		}
		public NSUrlAuthenticationChallenge Challenge { get; set; }
		public WebKit.WebDataSource DataSource { get; set; }
		public NSObject Identifier { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebResourceCancelledChallengeEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebResourceCancelledChallengeEventArgs" /> with the specified event data.</summary>
		/// <param name="identifier">The value for the <see cref="Identifier" /> property.</param>
		/// <param name="challenge">The value for the <see cref="Challenge" /> property.</param>
		/// <param name="dataSource">The value for the <see cref="DataSource" /> property.</param>
		public WebResourceCancelledChallengeEventArgs (NSObject identifier, NSUrlAuthenticationChallenge challenge, WebKit.WebDataSource dataSource)
		{
			this.Challenge = challenge;
			this.DataSource = dataSource;
			this.Identifier = identifier;
		}
		public NSUrlAuthenticationChallenge Challenge { get; set; }
		public WebKit.WebDataSource DataSource { get; set; }
		public NSObject Identifier { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebResourceCompletedEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebResourceCompletedEventArgs" /> with the specified event data.</summary>
		/// <param name="identifier">The value for the <see cref="Identifier" /> property.</param>
		/// <param name="dataSource">The value for the <see cref="DataSource" /> property.</param>
		public WebResourceCompletedEventArgs (NSObject identifier, WebKit.WebDataSource dataSource)
		{
			this.DataSource = dataSource;
			this.Identifier = identifier;
		}
		public WebKit.WebDataSource DataSource { get; set; }
		public NSObject Identifier { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebResourceErrorEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebResourceErrorEventArgs" /> with the specified event data.</summary>
		/// <param name="identifier">The value for the <see cref="Identifier" /> property.</param>
		/// <param name="withError">The value for the <see cref="WithError" /> property.</param>
		/// <param name="dataSource">The value for the <see cref="DataSource" /> property.</param>
		public WebResourceErrorEventArgs (NSObject identifier, NSError withError, WebKit.WebDataSource dataSource)
		{
			this.DataSource = dataSource;
			this.Identifier = identifier;
			this.WithError = withError;
		}
		public WebKit.WebDataSource DataSource { get; set; }
		public NSObject Identifier { get; set; }
		public NSError WithError { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebResourcePluginErrorEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebResourcePluginErrorEventArgs" /> with the specified event data.</summary>
		/// <param name="error">The value for the <see cref="Error" /> property.</param>
		/// <param name="dataSource">The value for the <see cref="DataSource" /> property.</param>
		public WebResourcePluginErrorEventArgs (NSError error, WebKit.WebDataSource dataSource)
		{
			this.DataSource = dataSource;
			this.Error = error;
		}
		public WebKit.WebDataSource DataSource { get; set; }
		public NSError Error { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebResourceReceivedContentLengthEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebResourceReceivedContentLengthEventArgs" /> with the specified event data.</summary>
		/// <param name="identifier">The value for the <see cref="Identifier" /> property.</param>
		/// <param name="length">The value for the <see cref="Length" /> property.</param>
		/// <param name="dataSource">The value for the <see cref="DataSource" /> property.</param>
		public WebResourceReceivedContentLengthEventArgs (NSObject identifier, IntPtr length, WebKit.WebDataSource dataSource)
		{
			this.DataSource = dataSource;
			this.Identifier = identifier;
			this.Length = length;
		}
		public WebKit.WebDataSource DataSource { get; set; }
		public NSObject Identifier { get; set; }
		public IntPtr Length { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebResourceReceivedResponseEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebResourceReceivedResponseEventArgs" /> with the specified event data.</summary>
		/// <param name="identifier">The value for the <see cref="Identifier" /> property.</param>
		/// <param name="responseReceived">The value for the <see cref="ResponseReceived" /> property.</param>
		/// <param name="dataSource">The value for the <see cref="DataSource" /> property.</param>
		public WebResourceReceivedResponseEventArgs (NSObject identifier, NSUrlResponse responseReceived, WebKit.WebDataSource dataSource)
		{
			this.DataSource = dataSource;
			this.Identifier = identifier;
			this.ResponseReceived = responseReceived;
		}
		public WebKit.WebDataSource DataSource { get; set; }
		public NSObject Identifier { get; set; }
		public NSUrlResponse ResponseReceived { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebViewContentEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebViewContentEventArgs" /> with the specified event data.</summary>
		/// <param name="frame">The value for the <see cref="Frame" /> property.</param>
		public WebViewContentEventArgs (CGRect frame)
		{
			this.Frame = frame;
		}
		public CGRect Frame { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebViewDragEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebViewDragEventArgs" /> with the specified event data.</summary>
		/// <param name="action">The value for the <see cref="Action" /> property.</param>
		/// <param name="draggingInfo">The value for the <see cref="DraggingInfo" /> property.</param>
		public WebViewDragEventArgs (WebKit.WebDragDestinationAction action, INSDraggingInfo draggingInfo)
		{
			this.Action = action;
			this.DraggingInfo = draggingInfo;
		}
		public WebKit.WebDragDestinationAction Action { get; set; }
		public INSDraggingInfo DraggingInfo { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebViewFooterEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebViewFooterEventArgs" /> with the specified event data.</summary>
		/// <param name="rect">The value for the <see cref="Rect" /> property.</param>
		public WebViewFooterEventArgs (CGRect rect)
		{
			this.Rect = rect;
		}
		public CGRect Rect { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebViewFrameEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebViewFrameEventArgs" /> with the specified event data.</summary>
		/// <param name="newFrame">The value for the <see cref="NewFrame" /> property.</param>
		public WebViewFrameEventArgs (CGRect newFrame)
		{
			this.NewFrame = newFrame;
		}
		public CGRect NewFrame { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebViewHeaderEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebViewHeaderEventArgs" /> with the specified event data.</summary>
		/// <param name="rect">The value for the <see cref="Rect" /> property.</param>
		public WebViewHeaderEventArgs (CGRect rect)
		{
			this.Rect = rect;
		}
		public CGRect Rect { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebViewJavaScriptEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebViewJavaScriptEventArgs" /> with the specified event data.</summary>
		/// <param name="message">The value for the <see cref="Message" /> property.</param>
		public WebViewJavaScriptEventArgs (string message)
		{
			this.Message = message;
		}
		public string Message { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebViewJavaScriptFrameEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebViewJavaScriptFrameEventArgs" /> with the specified event data.</summary>
		/// <param name="withMessage">The value for the <see cref="WithMessage" /> property.</param>
		/// <param name="initiatedByFrame">The value for the <see cref="InitiatedByFrame" /> property.</param>
		public WebViewJavaScriptFrameEventArgs (string withMessage, WebKit.WebFrame initiatedByFrame)
		{
			this.InitiatedByFrame = initiatedByFrame;
			this.WithMessage = withMessage;
		}
		public WebKit.WebFrame InitiatedByFrame { get; set; }
		public string WithMessage { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebViewMouseMovedEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebViewMouseMovedEventArgs" /> with the specified event data.</summary>
		/// <param name="elementInformation">The value for the <see cref="ElementInformation" /> property.</param>
		/// <param name="modifierFlags">The value for the <see cref="ModifierFlags" /> property.</param>
		public WebViewMouseMovedEventArgs (NSDictionary elementInformation, NSEventModifierMask modifierFlags)
		{
			this.ElementInformation = elementInformation;
			this.ModifierFlags = modifierFlags;
		}
		public NSDictionary ElementInformation { get; set; }
		public NSEventModifierMask ModifierFlags { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebViewPerformDragEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebViewPerformDragEventArgs" /> with the specified event data.</summary>
		/// <param name="action">The value for the <see cref="Action" /> property.</param>
		/// <param name="sourcePoint">The value for the <see cref="SourcePoint" /> property.</param>
		/// <param name="pasteboard">The value for the <see cref="Pasteboard" /> property.</param>
		public WebViewPerformDragEventArgs (WebKit.WebDragSourceAction action, CGPoint sourcePoint, NSPasteboard pasteboard)
		{
			this.Action = action;
			this.Pasteboard = pasteboard;
			this.SourcePoint = sourcePoint;
		}
		public WebKit.WebDragSourceAction Action { get; set; }
		public NSPasteboard Pasteboard { get; set; }
		public CGPoint SourcePoint { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebViewPrintEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebViewPrintEventArgs" /> with the specified event data.</summary>
		/// <param name="frameView">The value for the <see cref="FrameView" /> property.</param>
		public WebViewPrintEventArgs (WebKit.WebFrameView frameView)
		{
			this.FrameView = frameView;
		}
		public WebKit.WebFrameView FrameView { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebViewResizableEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebViewResizableEventArgs" /> with the specified event data.</summary>
		/// <param name="resizable">The value for the <see cref="Resizable" /> property.</param>
		public WebViewResizableEventArgs (bool resizable)
		{
			this.Resizable = resizable;
		}
		public bool Resizable { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebViewResponderEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebViewResponderEventArgs" /> with the specified event data.</summary>
		/// <param name="newResponder">The value for the <see cref="NewResponder" /> property.</param>
		public WebViewResponderEventArgs (NSResponder newResponder)
		{
			this.NewResponder = newResponder;
		}
		public NSResponder NewResponder { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebViewRunOpenPanelEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebViewRunOpenPanelEventArgs" /> with the specified event data.</summary>
		/// <param name="resultListener">The value for the <see cref="ResultListener" /> property.</param>
		public WebViewRunOpenPanelEventArgs (WebKit.IWebOpenPanelResultListener resultListener)
		{
			this.ResultListener = resultListener;
		}
		public WebKit.IWebOpenPanelResultListener ResultListener { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebViewStatusBarEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebViewStatusBarEventArgs" /> with the specified event data.</summary>
		/// <param name="visible">The value for the <see cref="Visible" /> property.</param>
		public WebViewStatusBarEventArgs (bool visible)
		{
			this.Visible = visible;
		}
		public bool Visible { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebViewStatusTextEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebViewStatusTextEventArgs" /> with the specified event data.</summary>
		/// <param name="text">The value for the <see cref="Text" /> property.</param>
		public WebViewStatusTextEventArgs (string text)
		{
			this.Text = text;
		}
		public string Text { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WebViewToolBarsEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WebViewToolBarsEventArgs" /> with the specified event data.</summary>
		/// <param name="visible">The value for the <see cref="Visible" /> property.</param>
		public WebViewToolBarsEventArgs (bool visible)
		{
			this.Visible = visible;
		}
		public bool Visible { get; set; }
	}
}
