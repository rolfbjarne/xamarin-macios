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
	/// <summary>Displays a Web page.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/WebKit/Reference/WKWebView_Ref/index.html">Apple documentation for <c>WKWebView</c></related>
	[Register("WKWebView", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class WKWebView : global::AppKit.NSView, global::AppKit.INSUserInterfaceValidations {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUIDelegateX = "UIDelegate";
		static readonly NativeHandle selUIDelegateXHandle = Selector.GetHandle ("UIDelegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLX = "URL";
		static readonly NativeHandle selURLXHandle = Selector.GetHandle ("URL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsBackForwardNavigationGesturesX = "allowsBackForwardNavigationGestures";
		static readonly NativeHandle selAllowsBackForwardNavigationGesturesXHandle = Selector.GetHandle ("allowsBackForwardNavigationGestures");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsLinkPreviewX = "allowsLinkPreview";
		static readonly NativeHandle selAllowsLinkPreviewXHandle = Selector.GetHandle ("allowsLinkPreview");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsMagnificationX = "allowsMagnification";
		static readonly NativeHandle selAllowsMagnificationXHandle = Selector.GetHandle ("allowsMagnification");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackForwardListX = "backForwardList";
		static readonly NativeHandle selBackForwardListXHandle = Selector.GetHandle ("backForwardList");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCallAsyncJavaScript_Arguments_InFrame_InContentWorld_CompletionHandler_X = "callAsyncJavaScript:arguments:inFrame:inContentWorld:completionHandler:";
		static readonly NativeHandle selCallAsyncJavaScript_Arguments_InFrame_InContentWorld_CompletionHandler_XHandle = Selector.GetHandle ("callAsyncJavaScript:arguments:inFrame:inContentWorld:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCameraCaptureStateX = "cameraCaptureState";
		static readonly NativeHandle selCameraCaptureStateXHandle = Selector.GetHandle ("cameraCaptureState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanGoBackX = "canGoBack";
		static readonly NativeHandle selCanGoBackXHandle = Selector.GetHandle ("canGoBack");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanGoForwardX = "canGoForward";
		static readonly NativeHandle selCanGoForwardXHandle = Selector.GetHandle ("canGoForward");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCertificateChainX = "certificateChain";
		static readonly NativeHandle selCertificateChainXHandle = Selector.GetHandle ("certificateChain");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCloseAllMediaPresentationsX = "closeAllMediaPresentations";
		static readonly NativeHandle selCloseAllMediaPresentationsXHandle = Selector.GetHandle ("closeAllMediaPresentations");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCloseAllMediaPresentationsWithCompletionHandler_X = "closeAllMediaPresentationsWithCompletionHandler:";
		static readonly NativeHandle selCloseAllMediaPresentationsWithCompletionHandler_XHandle = Selector.GetHandle ("closeAllMediaPresentationsWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConfigurationX = "configuration";
		static readonly NativeHandle selConfigurationXHandle = Selector.GetHandle ("configuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreatePDFWithConfiguration_CompletionHandler_X = "createPDFWithConfiguration:completionHandler:";
		static readonly NativeHandle selCreatePDFWithConfiguration_CompletionHandler_XHandle = Selector.GetHandle ("createPDFWithConfiguration:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateWebArchiveDataWithCompletionHandler_X = "createWebArchiveDataWithCompletionHandler:";
		static readonly NativeHandle selCreateWebArchiveDataWithCompletionHandler_XHandle = Selector.GetHandle ("createWebArchiveDataWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomUserAgentX = "customUserAgent";
		static readonly NativeHandle selCustomUserAgentXHandle = Selector.GetHandle ("customUserAgent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEstimatedProgressX = "estimatedProgress";
		static readonly NativeHandle selEstimatedProgressXHandle = Selector.GetHandle ("estimatedProgress");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEvaluateJavaScript_CompletionHandler_X = "evaluateJavaScript:completionHandler:";
		static readonly NativeHandle selEvaluateJavaScript_CompletionHandler_XHandle = Selector.GetHandle ("evaluateJavaScript:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEvaluateJavaScript_InFrame_InContentWorld_CompletionHandler_X = "evaluateJavaScript:inFrame:inContentWorld:completionHandler:";
		static readonly NativeHandle selEvaluateJavaScript_InFrame_InContentWorld_CompletionHandler_XHandle = Selector.GetHandle ("evaluateJavaScript:inFrame:inContentWorld:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchDataOfTypes_CompletionHandler_X = "fetchDataOfTypes:completionHandler:";
		static readonly NativeHandle selFetchDataOfTypes_CompletionHandler_XHandle = Selector.GetHandle ("fetchDataOfTypes:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFindString_WithConfiguration_CompletionHandler_X = "findString:withConfiguration:completionHandler:";
		static readonly NativeHandle selFindString_WithConfiguration_CompletionHandler_XHandle = Selector.GetHandle ("findString:withConfiguration:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFullscreenStateX = "fullscreenState";
		static readonly NativeHandle selFullscreenStateXHandle = Selector.GetHandle ("fullscreenState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoBackX = "goBack";
		static readonly NativeHandle selGoBackXHandle = Selector.GetHandle ("goBack");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoBack_X = "goBack:";
		static readonly NativeHandle selGoBack_XHandle = Selector.GetHandle ("goBack:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoForwardX = "goForward";
		static readonly NativeHandle selGoForwardXHandle = Selector.GetHandle ("goForward");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoForward_X = "goForward:";
		static readonly NativeHandle selGoForward_XHandle = Selector.GetHandle ("goForward:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoToBackForwardListItem_X = "goToBackForwardListItem:";
		static readonly NativeHandle selGoToBackForwardListItem_XHandle = Selector.GetHandle ("goToBackForwardListItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHandlesURLScheme_X = "handlesURLScheme:";
		static readonly NativeHandle selHandlesURLScheme_XHandle = Selector.GetHandle ("handlesURLScheme:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasOnlySecureContentX = "hasOnlySecureContent";
		static readonly NativeHandle selHasOnlySecureContentXHandle = Selector.GetHandle ("hasOnlySecureContent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_Configuration_X = "initWithFrame:configuration:";
		static readonly NativeHandle selInitWithFrame_Configuration_XHandle = Selector.GetHandle ("initWithFrame:configuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInteractionStateX = "interactionState";
		static readonly NativeHandle selInteractionStateXHandle = Selector.GetHandle ("interactionState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsBlockedByScreenTimeX = "isBlockedByScreenTime";
		static readonly NativeHandle selIsBlockedByScreenTimeXHandle = Selector.GetHandle ("isBlockedByScreenTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsInspectableX = "isInspectable";
		static readonly NativeHandle selIsInspectableXHandle = Selector.GetHandle ("isInspectable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsLoadingX = "isLoading";
		static readonly NativeHandle selIsLoadingXHandle = Selector.GetHandle ("isLoading");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsWritingToolsActiveX = "isWritingToolsActive";
		static readonly NativeHandle selIsWritingToolsActiveXHandle = Selector.GetHandle ("isWritingToolsActive");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadData_MIMEType_CharacterEncodingName_BaseURL_X = "loadData:MIMEType:characterEncodingName:baseURL:";
		static readonly NativeHandle selLoadData_MIMEType_CharacterEncodingName_BaseURL_XHandle = Selector.GetHandle ("loadData:MIMEType:characterEncodingName:baseURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadFileRequest_AllowingReadAccessToURL_X = "loadFileRequest:allowingReadAccessToURL:";
		static readonly NativeHandle selLoadFileRequest_AllowingReadAccessToURL_XHandle = Selector.GetHandle ("loadFileRequest:allowingReadAccessToURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadFileURL_AllowingReadAccessToURL_X = "loadFileURL:allowingReadAccessToURL:";
		static readonly NativeHandle selLoadFileURL_AllowingReadAccessToURL_XHandle = Selector.GetHandle ("loadFileURL:allowingReadAccessToURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadHTMLString_BaseURL_X = "loadHTMLString:baseURL:";
		static readonly NativeHandle selLoadHTMLString_BaseURL_XHandle = Selector.GetHandle ("loadHTMLString:baseURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadRequest_X = "loadRequest:";
		static readonly NativeHandle selLoadRequest_XHandle = Selector.GetHandle ("loadRequest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadSimulatedRequest_Response_ResponseData_X = "loadSimulatedRequest:response:responseData:";
		static readonly NativeHandle selLoadSimulatedRequest_Response_ResponseData_XHandle = Selector.GetHandle ("loadSimulatedRequest:response:responseData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadSimulatedRequest_ResponseHTMLString_X = "loadSimulatedRequest:responseHTMLString:";
		static readonly NativeHandle selLoadSimulatedRequest_ResponseHTMLString_XHandle = Selector.GetHandle ("loadSimulatedRequest:responseHTMLString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMagnificationX = "magnification";
		static readonly NativeHandle selMagnificationXHandle = Selector.GetHandle ("magnification");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumViewportInsetX = "maximumViewportInset";
		static readonly NativeHandle selMaximumViewportInsetXHandle = Selector.GetHandle ("maximumViewportInset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaTypeX = "mediaType";
		static readonly NativeHandle selMediaTypeXHandle = Selector.GetHandle ("mediaType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMicrophoneCaptureStateX = "microphoneCaptureState";
		static readonly NativeHandle selMicrophoneCaptureStateXHandle = Selector.GetHandle ("microphoneCaptureState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumViewportInsetX = "minimumViewportInset";
		static readonly NativeHandle selMinimumViewportInsetXHandle = Selector.GetHandle ("minimumViewportInset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNavigationDelegateX = "navigationDelegate";
		static readonly NativeHandle selNavigationDelegateXHandle = Selector.GetHandle ("navigationDelegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObscuredContentInsetsX = "obscuredContentInsets";
		static readonly NativeHandle selObscuredContentInsetsXHandle = Selector.GetHandle ("obscuredContentInsets");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPageZoomX = "pageZoom";
		static readonly NativeHandle selPageZoomXHandle = Selector.GetHandle ("pageZoom");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPauseAllMediaPlayback_X = "pauseAllMediaPlayback:";
		static readonly NativeHandle selPauseAllMediaPlayback_XHandle = Selector.GetHandle ("pauseAllMediaPlayback:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPauseAllMediaPlaybackWithCompletionHandler_X = "pauseAllMediaPlaybackWithCompletionHandler:";
		static readonly NativeHandle selPauseAllMediaPlaybackWithCompletionHandler_XHandle = Selector.GetHandle ("pauseAllMediaPlaybackWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrintOperationWithPrintInfo_X = "printOperationWithPrintInfo:";
		static readonly NativeHandle selPrintOperationWithPrintInfo_XHandle = Selector.GetHandle ("printOperationWithPrintInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadX = "reload";
		static readonly NativeHandle selReloadXHandle = Selector.GetHandle ("reload");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReload_X = "reload:";
		static readonly NativeHandle selReload_XHandle = Selector.GetHandle ("reload:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadFromOriginX = "reloadFromOrigin";
		static readonly NativeHandle selReloadFromOriginXHandle = Selector.GetHandle ("reloadFromOrigin");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadFromOrigin_X = "reloadFromOrigin:";
		static readonly NativeHandle selReloadFromOrigin_XHandle = Selector.GetHandle ("reloadFromOrigin:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestMediaPlaybackStateWithCompletionHandler_X = "requestMediaPlaybackStateWithCompletionHandler:";
		static readonly NativeHandle selRequestMediaPlaybackStateWithCompletionHandler_XHandle = Selector.GetHandle ("requestMediaPlaybackStateWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRestoreData_CompletionHandler_X = "restoreData:completionHandler:";
		static readonly NativeHandle selRestoreData_CompletionHandler_XHandle = Selector.GetHandle ("restoreData:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResumeAllMediaPlayback_X = "resumeAllMediaPlayback:";
		static readonly NativeHandle selResumeAllMediaPlayback_XHandle = Selector.GetHandle ("resumeAllMediaPlayback:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResumeDownloadFromResumeData_CompletionHandler_X = "resumeDownloadFromResumeData:completionHandler:";
		static readonly NativeHandle selResumeDownloadFromResumeData_CompletionHandler_XHandle = Selector.GetHandle ("resumeDownloadFromResumeData:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selServerTrustX = "serverTrust";
		static readonly NativeHandle selServerTrustXHandle = Selector.GetHandle ("serverTrust");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllMediaPlaybackSuspended_CompletionHandler_X = "setAllMediaPlaybackSuspended:completionHandler:";
		static readonly NativeHandle selSetAllMediaPlaybackSuspended_CompletionHandler_XHandle = Selector.GetHandle ("setAllMediaPlaybackSuspended:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsBackForwardNavigationGestures_X = "setAllowsBackForwardNavigationGestures:";
		static readonly NativeHandle selSetAllowsBackForwardNavigationGestures_XHandle = Selector.GetHandle ("setAllowsBackForwardNavigationGestures:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsLinkPreview_X = "setAllowsLinkPreview:";
		static readonly NativeHandle selSetAllowsLinkPreview_XHandle = Selector.GetHandle ("setAllowsLinkPreview:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsMagnification_X = "setAllowsMagnification:";
		static readonly NativeHandle selSetAllowsMagnification_XHandle = Selector.GetHandle ("setAllowsMagnification:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCameraCaptureState_CompletionHandler_X = "setCameraCaptureState:completionHandler:";
		static readonly NativeHandle selSetCameraCaptureState_CompletionHandler_XHandle = Selector.GetHandle ("setCameraCaptureState:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomUserAgent_X = "setCustomUserAgent:";
		static readonly NativeHandle selSetCustomUserAgent_XHandle = Selector.GetHandle ("setCustomUserAgent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInspectable_X = "setInspectable:";
		static readonly NativeHandle selSetInspectable_XHandle = Selector.GetHandle ("setInspectable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInteractionState_X = "setInteractionState:";
		static readonly NativeHandle selSetInteractionState_XHandle = Selector.GetHandle ("setInteractionState:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMagnification_X = "setMagnification:";
		static readonly NativeHandle selSetMagnification_XHandle = Selector.GetHandle ("setMagnification:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMagnification_CenteredAtPoint_X = "setMagnification:centeredAtPoint:";
		static readonly NativeHandle selSetMagnification_CenteredAtPoint_XHandle = Selector.GetHandle ("setMagnification:centeredAtPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMediaType_X = "setMediaType:";
		static readonly NativeHandle selSetMediaType_XHandle = Selector.GetHandle ("setMediaType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMicrophoneCaptureState_CompletionHandler_X = "setMicrophoneCaptureState:completionHandler:";
		static readonly NativeHandle selSetMicrophoneCaptureState_CompletionHandler_XHandle = Selector.GetHandle ("setMicrophoneCaptureState:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMinimumViewportInset_MaximumViewportInset_X = "setMinimumViewportInset:maximumViewportInset:";
		static readonly NativeHandle selSetMinimumViewportInset_MaximumViewportInset_XHandle = Selector.GetHandle ("setMinimumViewportInset:maximumViewportInset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNavigationDelegate_X = "setNavigationDelegate:";
		static readonly NativeHandle selSetNavigationDelegate_XHandle = Selector.GetHandle ("setNavigationDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetObscuredContentInsets_X = "setObscuredContentInsets:";
		static readonly NativeHandle selSetObscuredContentInsets_XHandle = Selector.GetHandle ("setObscuredContentInsets:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPageZoom_X = "setPageZoom:";
		static readonly NativeHandle selSetPageZoom_XHandle = Selector.GetHandle ("setPageZoom:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUIDelegate_X = "setUIDelegate:";
		static readonly NativeHandle selSetUIDelegate_XHandle = Selector.GetHandle ("setUIDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUnderPageBackgroundColor_X = "setUnderPageBackgroundColor:";
		static readonly NativeHandle selSetUnderPageBackgroundColor_XHandle = Selector.GetHandle ("setUnderPageBackgroundColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartDownloadUsingRequest_CompletionHandler_X = "startDownloadUsingRequest:completionHandler:";
		static readonly NativeHandle selStartDownloadUsingRequest_CompletionHandler_XHandle = Selector.GetHandle ("startDownloadUsingRequest:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopLoadingX = "stopLoading";
		static readonly NativeHandle selStopLoadingXHandle = Selector.GetHandle ("stopLoading");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopLoading_X = "stopLoading:";
		static readonly NativeHandle selStopLoading_XHandle = Selector.GetHandle ("stopLoading:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSuspendAllMediaPlayback_X = "suspendAllMediaPlayback:";
		static readonly NativeHandle selSuspendAllMediaPlayback_XHandle = Selector.GetHandle ("suspendAllMediaPlayback:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTakeSnapshotWithConfiguration_CompletionHandler_X = "takeSnapshotWithConfiguration:completionHandler:";
		static readonly NativeHandle selTakeSnapshotWithConfiguration_CompletionHandler_XHandle = Selector.GetHandle ("takeSnapshotWithConfiguration:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selThemeColorX = "themeColor";
		static readonly NativeHandle selThemeColorXHandle = Selector.GetHandle ("themeColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleX = "title";
		static readonly NativeHandle selTitleXHandle = Selector.GetHandle ("title");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnderPageBackgroundColorX = "underPageBackgroundColor";
		static readonly NativeHandle selUnderPageBackgroundColorXHandle = Selector.GetHandle ("underPageBackgroundColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateUserInterfaceItem_X = "validateUserInterfaceItem:";
		static readonly NativeHandle selValidateUserInterfaceItem_XHandle = Selector.GetHandle ("validateUserInterfaceItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("WKWebView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		public WKWebView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected WKWebView (NSObjectFlag t) : base (t)
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
		protected internal WKWebView (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:configuration:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public WKWebView (CGRect frame, WKWebViewConfiguration configuration)
			: base (NSObjectFlag.Empty)
		{
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_NativeHandle (this.Handle, selInitWithFrame_Configuration_XHandle, frame, configuration__handle__), "initWithFrame:configuration:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selInitWithFrame_Configuration_XHandle, frame, configuration__handle__), "initWithFrame:configuration:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (configuration);
		}
		[Export ("callAsyncJavaScript:arguments:inFrame:inContentWorld:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CallAsyncJavaScript (string functionBody, NSDictionary<NSString, NSObject>? arguments, WKFrameInfo? frame, WKContentWorld contentWorld, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V78))]global::System.Action<NSObject, NSError>? completionHandler)
		{
			if (functionBody is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functionBody));
			var arguments__handle__ = arguments.GetHandle ();
			var frame__handle__ = frame.GetHandle ();
			var contentWorld__handle__ = contentWorld!.GetNonNullHandle (nameof (contentWorld));
			var nsfunctionBody = CFString.CreateNative (functionBody);
			using var block_completionHandler = Trampolines.SDActionArity2V78.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selCallAsyncJavaScript_Arguments_InFrame_InContentWorld_CompletionHandler_XHandle, nsfunctionBody, arguments__handle__, frame__handle__, contentWorld__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selCallAsyncJavaScript_Arguments_InFrame_InContentWorld_CompletionHandler_XHandle, nsfunctionBody, arguments__handle__, frame__handle__, contentWorld__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (arguments);
			GC.KeepAlive (frame);
			GC.KeepAlive (contentWorld);
			CFString.ReleaseNative (nsfunctionBody);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSObject> CallAsyncJavaScriptAsync (string functionBody, NSDictionary<NSString, NSObject>? arguments, WKFrameInfo? frame, WKContentWorld contentWorld)
		{
			var tcs = new TaskCompletionSource<NSObject> ();
			CallAsyncJavaScript(functionBody, arguments, frame, contentWorld, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("closeAllMediaPresentationsWithCompletionHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CloseAllMediaPresentations ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCloseAllMediaPresentationsWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCloseAllMediaPresentationsWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task CloseAllMediaPresentationsAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			CloseAllMediaPresentations(() => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("createPDFWithConfiguration:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreatePdf (WKPdfConfiguration? pdfConfiguration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V16))]global::System.Action<NSData, NSError> completionHandler)
		{
			var pdfConfiguration__handle__ = pdfConfiguration.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selCreatePDFWithConfiguration_CompletionHandler_XHandle, pdfConfiguration__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selCreatePDFWithConfiguration_CompletionHandler_XHandle, pdfConfiguration__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pdfConfiguration);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> CreatePdfAsync (WKPdfConfiguration? pdfConfiguration)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			CreatePdf(pdfConfiguration, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("createWebArchiveDataWithCompletionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateWebArchive ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V16))]global::System.Action<NSData, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCreateWebArchiveDataWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCreateWebArchiveDataWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> CreateWebArchiveAsync ()
		{
			var tcs = new TaskCompletionSource<NSData> ();
			CreateWebArchive((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("evaluateJavaScript:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EvaluateJavaScript (NSString javascript, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKJavascriptEvaluationResult))]WKJavascriptEvaluationResult? completionHandler)
		{
			var javascript__handle__ = javascript!.GetNonNullHandle (nameof (javascript));
			using var block_completionHandler = Trampolines.SDWKJavascriptEvaluationResult.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selEvaluateJavaScript_CompletionHandler_XHandle, javascript__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selEvaluateJavaScript_CompletionHandler_XHandle, javascript__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (javascript);
		}
		/// <param name="javascript">The JavaScript string to evaluate</param>
		/// <summary>Evaluates the given JavaScript string.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous EvaluateJavaScript operation.   The value of the TResult parameter is a <see cref="WebKit.WKJavascriptEvaluationResult" />.</para>
		///         </returns>
		/// <remarks>
		///           <para>This method will throw a <see cref="Foundation.NSErrorException" /> if the JavaScript is not evaluated successfully.</para>
		///           <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// var config = new WKWebViewConfiguration();
		/// var wk = new WKWebView(UIScreen.MainScreen.Bounds, config);
		/// var js = (NSString) "document.getElementById('foo').innerHTML = 'bar'";
		/// var result = await wk.EvaluateJavaScriptAsync(js); //== "bar"
		///     ]]></code>
		///           </example>
		///           <para>The EvaluateJavaScriptAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para>The arguments to the handler are an <see cref="Foundation.NSObject" /> containing the results of the evaluation and an <see cref="Foundation.NSError" /> if an error. If an error occurred, the <c>result</c> argument will be <see langword="null" />. If no error occurred, the <c>error</c> argument will be <see langword="null" />.</para>
		///           <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// var config = new WKWebViewConfiguration();
		/// var wk = new WKWebView(UIScreen.MainScreen.Bounds, config);
		/// var js = (NSString) "document.getElementById('foo').innerHTML = 'bar'";
		/// WKJavascriptEvaluationResult handler = (NSObject result, NSError err) => { 
		///   if(err is not null)
		///   {
		///     System.Console.WriteLine(err);
		///   }
		///   if(result is not null)
		///   {
		///      System.Console.WriteLine(result);
		///   }
		/// };
		/// wk.EvaluateJavaScript(js, handler);
		///     ]]></code>
		///           </example>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSObject> EvaluateJavaScriptAsync (NSString javascript)
		{
			var tcs = new TaskCompletionSource<NSObject> ();
			EvaluateJavaScript(javascript, (result_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (result_!);
			});
			return tcs.Task;
		}
		/// <param name="javascript">To be added.</param><param name="completionHandler">To be added.</param><summary>Evaluates JavaScript and calls back into C# with the results.</summary><remarks><para>The system calls <paramref name="completionHandler" /> after evaluation. The arguments to the handler are an <see cref="T:Foundation.NSObject" /> containing the results of the evaluation and an <see cref="T:Foundation.NSError" /> if an error. If an error occurred, the <c>result</c> argument will be <see langword="null" />. If no error occurred, the <c>error</c> argument will be <see langword="null" />.</para><example><code lang="csharp lang-csharp"><![CDATA[
		/// var config = new WKWebViewConfiguration();
		/// var wk = new WKWebView(UIScreen.MainScreen.Bounds, config);
		/// var js = (NSString) "document.getElementById('foo').innerHTML = 'bar'";
		/// WKJavascriptEvaluationResult handler = (NSObject result, NSError err) => { 
		/// if(err != null)
		/// {
		/// System.Console.WriteLine(err);
		/// }
		/// if(result != null)
		/// {
		/// System.Console.WriteLine(result);
		/// }
		/// };
		/// wk.EvaluateJavaScript(js, handler);
		/// ]]></code></example></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void EvaluateJavaScript (string javascript, WKJavascriptEvaluationResult completionHandler)
		{
			EvaluateJavaScript ((NSString)javascript, completionHandler);
		}
		/// <param name="javascript">A well-formed JavaScript expression.</param>
		/// <summary>Evaluates the given JavaScript string.</summary>
		/// <returns>A task that represents the asynchronous EvaluateJavaScript operation. The TResult holds the results of the evaluation.</returns>
		/// <remarks>
		///           <para>This method will throw a <see cref="Foundation.NSErrorException" /> if the JavaScript is not evaluated successfully.</para>
		///           <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// var config = new WKWebViewConfiguration();
		/// var wk = new WKWebView(UIScreen.MainScreen.Bounds, config);
		/// var js = (NSString) "document.getElementById('foo').innerHTML = 'bar'";
		/// var result = await wk.EvaluateJavaScriptAsync(js); //== "bar"
		///     ]]></code>
		///           </example>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task<NSObject> EvaluateJavaScriptAsync (string javascript)
		{
			var tcs = new TaskCompletionSource<NSObject> ();
			EvaluateJavaScript(javascript, (result_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (result_!);
			});
			return tcs.Task;
		}
		[Export ("evaluateJavaScript:inFrame:inContentWorld:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EvaluateJavaScript (string javaScriptString, WKFrameInfo? frame, WKContentWorld contentWorld, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V78))]global::System.Action<NSObject, NSError>? completionHandler)
		{
			if (javaScriptString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (javaScriptString));
			var frame__handle__ = frame.GetHandle ();
			var contentWorld__handle__ = contentWorld!.GetNonNullHandle (nameof (contentWorld));
			var nsjavaScriptString = CFString.CreateNative (javaScriptString);
			using var block_completionHandler = Trampolines.SDActionArity2V78.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEvaluateJavaScript_InFrame_InContentWorld_CompletionHandler_XHandle, nsjavaScriptString, frame__handle__, contentWorld__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEvaluateJavaScript_InFrame_InContentWorld_CompletionHandler_XHandle, nsjavaScriptString, frame__handle__, contentWorld__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (frame);
			GC.KeepAlive (contentWorld);
			CFString.ReleaseNative (nsjavaScriptString);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSObject> EvaluateJavaScriptAsync (string javaScriptString, WKFrameInfo? frame, WKContentWorld contentWorld)
		{
			var tcs = new TaskCompletionSource<NSObject> ();
			EvaluateJavaScript(javaScriptString, frame, contentWorld, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("fetchDataOfTypes:completionHandler:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchData (WKWebViewDataType dataTypes, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebViewFetchDataHandler))]WKWebViewFetchDataHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebViewFetchDataHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle (this.Handle, selFetchDataOfTypes_CompletionHandler_XHandle, (UIntPtr) (ulong) dataTypes, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, selFetchDataOfTypes_CompletionHandler_XHandle, (UIntPtr) (ulong) dataTypes, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> FetchDataAsync (WKWebViewDataType dataTypes)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			FetchData(dataTypes, (data_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (data_!);
			});
			return tcs.Task;
		}
		[Export ("findString:withConfiguration:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Find (string @string, WKFindConfiguration? configuration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V133))]global::System.Action<WKFindResult> completionHandler)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var configuration__handle__ = configuration.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsstring = CFString.CreateNative (@string);
			using var block_completionHandler = Trampolines.SDActionArity1V133.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selFindString_WithConfiguration_CompletionHandler_XHandle, nsstring, configuration__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selFindString_WithConfiguration_CompletionHandler_XHandle, nsstring, configuration__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (configuration);
			CFString.ReleaseNative (nsstring);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<WKFindResult> FindAsync (string @string, WKFindConfiguration? configuration)
		{
			var tcs = new TaskCompletionSource<WKFindResult> ();
			Find(@string, configuration, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("printOperationWithPrintInfo:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSPrintOperation GetPrintOperation (global::AppKit.NSPrintInfo printInfo)
		{
			var printInfo__handle__ = printInfo!.GetNonNullHandle (nameof (printInfo));
			global::AppKit.NSPrintOperation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::AppKit.NSPrintOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPrintOperationWithPrintInfo_XHandle, printInfo__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::AppKit.NSPrintOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPrintOperationWithPrintInfo_XHandle, printInfo__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (printInfo);
			return ret!;
		}
		[Export ("goBack")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation? GoBack ()
		{
			WKNavigation ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGoBackXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGoBackXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("goBack:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
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
		[Export ("goForward")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation? GoForward ()
		{
			WKNavigation ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGoForwardXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGoForwardXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("goForward:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
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
		[Export ("goToBackForwardListItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation? GoTo (WKBackForwardListItem item)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			WKNavigation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGoToBackForwardListItem_XHandle, item__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGoToBackForwardListItem_XHandle, item__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
			return ret!;
		}
		[Export ("handlesURLScheme:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HandlesUrlScheme (string urlScheme)
		{
			if (urlScheme is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urlScheme));
			var nsurlScheme = CFString.CreateNative (urlScheme);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, selHandlesURLScheme_XHandle, nsurlScheme);
			CFString.ReleaseNative (nsurlScheme);
			return ret != 0;
		}
		[Export ("loadData:MIMEType:characterEncodingName:baseURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation? LoadData (NSData data, string mimeType, string characterEncodingName, NSUrl baseUrl)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (mimeType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mimeType));
			if (characterEncodingName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (characterEncodingName));
			var baseUrl__handle__ = baseUrl!.GetNonNullHandle (nameof (baseUrl));
			var nsmimeType = CFString.CreateNative (mimeType);
			var nscharacterEncodingName = CFString.CreateNative (characterEncodingName);
			WKNavigation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selLoadData_MIMEType_CharacterEncodingName_BaseURL_XHandle, data__handle__, nsmimeType, nscharacterEncodingName, baseUrl__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selLoadData_MIMEType_CharacterEncodingName_BaseURL_XHandle, data__handle__, nsmimeType, nscharacterEncodingName, baseUrl__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			GC.KeepAlive (baseUrl);
			CFString.ReleaseNative (nsmimeType);
			CFString.ReleaseNative (nscharacterEncodingName);
			return ret!;
		}
		[Export ("loadFileRequest:allowingReadAccessToURL:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation LoadFileRequest (NSUrlRequest request, NSUrl readAccessURL)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var readAccessURL__handle__ = readAccessURL!.GetNonNullHandle (nameof (readAccessURL));
			WKNavigation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadFileRequest_AllowingReadAccessToURL_XHandle, request__handle__, readAccessURL__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadFileRequest_AllowingReadAccessToURL_XHandle, request__handle__, readAccessURL__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			GC.KeepAlive (readAccessURL);
			return ret!;
		}
		[Export ("loadFileURL:allowingReadAccessToURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation? LoadFileUrl (NSUrl url, NSUrl readAccessUrl)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var readAccessUrl__handle__ = readAccessUrl!.GetNonNullHandle (nameof (readAccessUrl));
			WKNavigation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadFileURL_AllowingReadAccessToURL_XHandle, url__handle__, readAccessUrl__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadFileURL_AllowingReadAccessToURL_XHandle, url__handle__, readAccessUrl__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (readAccessUrl);
			return ret!;
		}
		[Export ("loadHTMLString:baseURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation? LoadHtmlString (NSString htmlString, NSUrl? baseUrl)
		{
			var htmlString__handle__ = htmlString!.GetNonNullHandle (nameof (htmlString));
			var baseUrl__handle__ = baseUrl.GetHandle ();
			WKNavigation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadHTMLString_BaseURL_XHandle, htmlString__handle__, baseUrl__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadHTMLString_BaseURL_XHandle, htmlString__handle__, baseUrl__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (htmlString);
			GC.KeepAlive (baseUrl);
			return ret!;
		}
		/// <param name="htmlString">To be added.</param><param name="baseUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public WKNavigation? LoadHtmlString (string htmlString, NSUrl baseUrl)
		{
			return LoadHtmlString ((NSString)htmlString, baseUrl);
		}
		[Export ("loadRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation? LoadRequest (NSUrlRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			WKNavigation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selLoadRequest_XHandle, request__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selLoadRequest_XHandle, request__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			return ret!;
		}
		[Export ("loadSimulatedRequest:response:responseData:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation LoadSimulatedRequest (NSUrlRequest request, NSUrlResponse response, NSData data)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			WKNavigation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selLoadSimulatedRequest_Response_ResponseData_XHandle, request__handle__, response__handle__, data__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selLoadSimulatedRequest_Response_ResponseData_XHandle, request__handle__, response__handle__, data__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			GC.KeepAlive (response);
			GC.KeepAlive (data);
			return ret!;
		}
		[Export ("loadSimulatedRequest:responseHTMLString:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation LoadSimulatedRequest (NSUrlRequest request, string htmlString)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (htmlString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (htmlString));
			var nshtmlString = CFString.CreateNative (htmlString);
			WKNavigation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadSimulatedRequest_ResponseHTMLString_XHandle, request__handle__, nshtmlString), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadSimulatedRequest_ResponseHTMLString_XHandle, request__handle__, nshtmlString), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			CFString.ReleaseNative (nshtmlString);
			return ret!;
		}
		[Export ("reload")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation? Reload ()
		{
			WKNavigation ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selReloadXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selReloadXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("reload:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Reload (NSObject? sender)
		{
			var sender__handle__ = sender.GetHandle ();
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
		[Export ("reloadFromOrigin")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKNavigation? ReloadFromOrigin ()
		{
			WKNavigation ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selReloadFromOriginXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selReloadFromOriginXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("reloadFromOrigin:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadFromOrigin (NSObject? sender)
		{
			var sender__handle__ = sender.GetHandle ();
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
		[Export ("requestMediaPlaybackStateWithCompletionHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestMediaPlaybackState ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V134))]global::System.Action<WKMediaPlaybackState> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V134.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRequestMediaPlaybackStateWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRequestMediaPlaybackStateWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<WKMediaPlaybackState> RequestMediaPlaybackStateAsync ()
		{
			var tcs = new TaskCompletionSource<WKMediaPlaybackState> ();
			RequestMediaPlaybackState((obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("restoreData:completionHandler:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RestoreData (NSData data, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebViewRestoreDataHandler))]WKWebViewRestoreDataHandler completionHandler)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebViewRestoreDataHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRestoreData_CompletionHandler_XHandle, data__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRestoreData_CompletionHandler_XHandle, data__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task RestoreDataAsync (NSData data)
		{
			var tcs = new TaskCompletionSource<bool> ();
			RestoreData(data, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("resumeDownloadFromResumeData:completionHandler:")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResumeDownload (NSData resumeData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V135))]global::System.Action<WKDownload> completionHandler)
		{
			var resumeData__handle__ = resumeData!.GetNonNullHandle (nameof (resumeData));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V135.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selResumeDownloadFromResumeData_CompletionHandler_XHandle, resumeData__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selResumeDownloadFromResumeData_CompletionHandler_XHandle, resumeData__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (resumeData);
		}
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<WKDownload> ResumeDownloadAsync (NSData resumeData)
		{
			var tcs = new TaskCompletionSource<WKDownload> ();
			ResumeDownload(resumeData, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("setAllMediaPlaybackSuspended:completionHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetAllMediaPlaybackSuspended (bool suspended, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NativeHandle (this.Handle, selSetAllMediaPlaybackSuspended_CompletionHandler_XHandle, suspended ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_NativeHandle (&__objc_super__, selSetAllMediaPlaybackSuspended_CompletionHandler_XHandle, suspended ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetAllMediaPlaybackSuspendedAsync (bool suspended)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetAllMediaPlaybackSuspended(suspended, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("setCameraCaptureState:completionHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetCameraCaptureState (WKMediaCaptureState state, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, selSetCameraCaptureState_CompletionHandler_XHandle, (IntPtr) (long) state, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selSetCameraCaptureState_CompletionHandler_XHandle, (IntPtr) (long) state, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetCameraCaptureStateAsync (WKMediaCaptureState state)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetCameraCaptureState(state, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("setMagnification:centeredAtPoint:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMagnification (nfloat magnification, CGPoint centerPoint)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat_CGPoint (this.Handle, selSetMagnification_CenteredAtPoint_XHandle, magnification, centerPoint);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat_CGPoint (&__objc_super__, selSetMagnification_CenteredAtPoint_XHandle, magnification, centerPoint);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setMicrophoneCaptureState:completionHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetMicrophoneCaptureState (WKMediaCaptureState state, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, selSetMicrophoneCaptureState_CompletionHandler_XHandle, (IntPtr) (long) state, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selSetMicrophoneCaptureState_CompletionHandler_XHandle, (IntPtr) (long) state, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetMicrophoneCaptureStateAsync (WKMediaCaptureState state)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetMicrophoneCaptureState(state, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("setMinimumViewportInset:maximumViewportInset:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetViewportInsets (global::AppKit.NSEdgeInsets minimumViewportInset, global::AppKit.NSEdgeInsets maximumViewportInset)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSEdgeInsets_NSEdgeInsets (this.Handle, selSetMinimumViewportInset_MaximumViewportInset_XHandle, minimumViewportInset, maximumViewportInset);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSEdgeInsets_NSEdgeInsets (&__objc_super__, selSetMinimumViewportInset_MaximumViewportInset_XHandle, minimumViewportInset, maximumViewportInset);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("startDownloadUsingRequest:completionHandler:")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void StartDownload (NSUrlRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V135))]global::System.Action<WKDownload> completionHandler)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V135.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selStartDownloadUsingRequest_CompletionHandler_XHandle, request__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selStartDownloadUsingRequest_CompletionHandler_XHandle, request__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
		}
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<WKDownload> StartDownloadAsync (NSUrlRequest request)
		{
			var tcs = new TaskCompletionSource<WKDownload> ();
			StartDownload(request, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("stopLoading")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopLoading ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopLoadingXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopLoadingXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("stopLoading:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopLoading (NSObject? sender)
		{
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStopLoading_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selStopLoading_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("takeSnapshotWithConfiguration:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void TakeSnapshot (WKSnapshotConfiguration? snapshotConfiguration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V155))]global::System.Action<global::AppKit.NSImage, NSError> completionHandler)
		{
			var snapshotConfiguration__handle__ = snapshotConfiguration.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V155.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selTakeSnapshotWithConfiguration_CompletionHandler_XHandle, snapshotConfiguration__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selTakeSnapshotWithConfiguration_CompletionHandler_XHandle, snapshotConfiguration__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (snapshotConfiguration);
		}
		/// <param name="snapshotConfiguration">The snapshot configuration to use.This parameter can be .</param>
		/// <summary>Asynchronously takes a snapshot of the current viewport.</summary>
		/// <returns>
		///           <para>The result is of type System.Tasks.Task&lt;AppKit.NSImage&gt; on MacOS and System.Tasks.Task&lt;UIKit.UIImage&gt; on iOS.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The TakeSnapshotAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<global::AppKit.NSImage> TakeSnapshotAsync (WKSnapshotConfiguration? snapshotConfiguration)
		{
			var tcs = new TaskCompletionSource<global::AppKit.NSImage> ();
			TakeSnapshot(snapshotConfiguration, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		/// <param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("validateUserInterfaceItem:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
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
		[Export ("pauseAllMediaPlaybackWithCompletionHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual void _NewPauseAllMediaPlayback ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPauseAllMediaPlaybackWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPauseAllMediaPlaybackWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual Task _NewPauseAllMediaPlaybackAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			_NewPauseAllMediaPlayback(() => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("closeAllMediaPresentations")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _OldCloseAllMediaPresentations ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCloseAllMediaPresentationsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCloseAllMediaPresentationsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("pauseAllMediaPlayback:")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual void _OldPauseAllMediaPlayback ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPauseAllMediaPlayback_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPauseAllMediaPlayback_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual Task _OldPauseAllMediaPlaybackAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			_OldPauseAllMediaPlayback(() => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("resumeAllMediaPlayback:")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual void _OldResumeAllMediaPlayback ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selResumeAllMediaPlayback_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selResumeAllMediaPlayback_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual Task _OldResumeAllMediaPlaybackAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			_OldResumeAllMediaPlayback(() => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("suspendAllMediaPlayback:")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual void _OldSuspendAllMediaPlayback ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSuspendAllMediaPlayback_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSuspendAllMediaPlayback_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual Task _OldSuspendAllMediaPlaybackAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			_OldSuspendAllMediaPlayback(() => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsBackForwardNavigationGestures {
			[Export ("allowsBackForwardNavigationGestures")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsBackForwardNavigationGesturesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsBackForwardNavigationGesturesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsBackForwardNavigationGestures:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsBackForwardNavigationGestures_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsBackForwardNavigationGestures_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AllowsLinkPreview {
			[Export ("allowsLinkPreview")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsLinkPreviewXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsLinkPreviewXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsLinkPreview:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsLinkPreview_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsLinkPreview_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AllowsMagnification {
			[Export ("allowsMagnification")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsMagnificationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsMagnificationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsMagnification:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsMagnification_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsMagnification_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKBackForwardList BackForwardList {
			[Export ("backForwardList", ArgumentSemantic.Retain)]
			get {
				WKBackForwardList? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WKBackForwardList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBackForwardListXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<WKBackForwardList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBackForwardListXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual WKMediaCaptureState CameraCaptureState {
			[Export ("cameraCaptureState")]
			get {
				WKMediaCaptureState ret;
				if (IsDirectBinding) {
					ret = (WebKit.WKMediaCaptureState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCameraCaptureStateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (WebKit.WKMediaCaptureState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selCameraCaptureStateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios10.0", "Use 'ServerTrust' property.")]
		[ObsoletedOSPlatform ("macos10.12", "Use 'ServerTrust' property.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ServerTrust' property.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual global::Security.SecCertificate[] CertificateChain {
			[Export ("certificateChain", ArgumentSemantic.Copy)]
			get {
				global::Security.SecCertificate[] ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<global::Security.SecCertificate>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCertificateChainXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<global::Security.SecCertificate>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCertificateChainXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebViewConfiguration Configuration {
			[Export ("configuration", ArgumentSemantic.Copy)]
			get {
				WKWebViewConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WKWebViewConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selConfigurationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<WKWebViewConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selConfigurationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual string? CustomUserAgent {
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual WKFullscreenState FullscreenState {
			[Export ("fullscreenState")]
			get {
				WKFullscreenState ret;
				if (IsDirectBinding) {
					ret = (WebKit.WKFullscreenState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFullscreenStateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (WebKit.WKFullscreenState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selFullscreenStateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasOnlySecureContent {
			[Export ("hasOnlySecureContent")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasOnlySecureContentXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasOnlySecureContentXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[SupportedOSPlatform ("ios16.4")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual bool Inspectable {
			[Export ("isInspectable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsInspectableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsInspectableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setInspectable:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetInspectable_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetInspectable_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? InteractionState {
			[Export ("interactionState", ArgumentSemantic.Copy)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInteractionStateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInteractionStateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInteractionState:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetInteractionState_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetInteractionState_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual bool IsBlockedByScreenTime {
			[Export ("isBlockedByScreenTime")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsBlockedByScreenTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsBlockedByScreenTimeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>A Boolean value indicating whether the view is currently loading content.</summary><value><para /></value><remarks><para /></remarks>
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
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual nfloat Magnification {
			[Export ("magnification")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selMagnificationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selMagnificationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMagnification:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetMagnification_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetMagnification_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual global::AppKit.NSEdgeInsets MaximumViewportInset {
			[Export ("maximumViewportInset")]
			get {
				global::AppKit.NSEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSend (this.Handle, selMaximumViewportInsetXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSend_stret (this.Handle, selMaximumViewportInsetXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSendSuper (&__objc_super__, selMaximumViewportInsetXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, selMaximumViewportInsetXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string? MediaType {
			[Export ("mediaType")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMediaTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMediaTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMediaType:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMediaType_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMediaType_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual WKMediaCaptureState MicrophoneCaptureState {
			[Export ("microphoneCaptureState")]
			get {
				WKMediaCaptureState ret;
				if (IsDirectBinding) {
					ret = (WebKit.WKMediaCaptureState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMicrophoneCaptureStateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (WebKit.WKMediaCaptureState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMicrophoneCaptureStateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual global::AppKit.NSEdgeInsets MinimumViewportInset {
			[Export ("minimumViewportInset")]
			get {
				global::AppKit.NSEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSend (this.Handle, selMinimumViewportInsetXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSend_stret (this.Handle, selMinimumViewportInsetXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSendSuper (&__objc_super__, selMinimumViewportInsetXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, selMinimumViewportInsetXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>The web view's navigation delegate.</summary><value><para>This value can be <see langword="null" />.</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks><para></para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IWKNavigationDelegate NavigationDelegate {
			get {
				return (WeakNavigationDelegate as IWKNavigationDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakNavigationDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual global::AppKit.NSEdgeInsets ObscuredContentInsets {
			[Export ("obscuredContentInsets", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSend (this.Handle, selObscuredContentInsetsXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSend_stret (this.Handle, selObscuredContentInsetsXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSendSuper (&__objc_super__, selObscuredContentInsetsXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, selObscuredContentInsetsXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setObscuredContentInsets:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NSEdgeInsets (this.Handle, selSetObscuredContentInsets_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSEdgeInsets (&__objc_super__, selSetObscuredContentInsets_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual nfloat PageZoom {
			[Export ("pageZoom")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selPageZoomXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selPageZoomXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPageZoom:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetPageZoom_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetPageZoom_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual global::Security.SecTrust? ServerTrust {
			[Export ("serverTrust")]
			get {
				global::Security.SecTrust ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::Security.SecTrust> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selServerTrustXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::Security.SecTrust> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selServerTrustXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual global::AppKit.NSColor? ThemeColor {
			[Export ("themeColor")]
			get {
				global::AppKit.NSColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selThemeColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selThemeColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Title {
			[Export ("title")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>The web view's user interface delegate. </summary><value><para>This value can be <see langword="null" />.</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks><para></para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IWKUIDelegate UIDelegate {
			get {
				return (WeakUIDelegate as IWKUIDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakUIDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual global::AppKit.NSColor? UnderPageBackgroundColor {
			[Export ("underPageBackgroundColor", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUnderPageBackgroundColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUnderPageBackgroundColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setUnderPageBackgroundColor:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetUnderPageBackgroundColor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetUnderPageBackgroundColor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? Url {
			[Export ("URL", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakNavigationDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakNavigationDelegate {
			[Export ("navigationDelegate", ArgumentSemantic.Weak)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNavigationDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNavigationDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakNavigationDelegate_var = ret;
				return ret!;
			}
			[Export ("setNavigationDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetNavigationDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetNavigationDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakNavigationDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakUIDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakUIDelegate {
			[Export ("UIDelegate", ArgumentSemantic.Weak)]
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
			[Export ("setUIDelegate:", ArgumentSemantic.Weak)]
			set {
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
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual bool WritingToolsActive {
			[Export ("isWritingToolsActive")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsWritingToolsActiveXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsWritingToolsActiveXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakNavigationDelegate_var = null;
				__mt_WeakUIDelegate_var = null;
			}
		}
	} /* class WKWebView */
}
