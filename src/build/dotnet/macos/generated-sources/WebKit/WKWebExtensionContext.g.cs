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
	[Register("WKWebExtensionContext", true)]
	[SupportedOSPlatform ("macos15.4")]
	[SupportedOSPlatform ("ios18.4")]
	[SupportedOSPlatform ("maccatalyst18.4")]
	[UnsupportedOSPlatform ("tvos")]
	public unsafe partial class WKWebExtensionContext : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActionForTab_X = "actionForTab:";
		static readonly NativeHandle selActionForTab_XHandle = Selector.GetHandle ("actionForTab:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBaseURLX = "baseURL";
		static readonly NativeHandle selBaseURLXHandle = Selector.GetHandle ("baseURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClearUserGestureInTab_X = "clearUserGestureInTab:";
		static readonly NativeHandle selClearUserGestureInTab_XHandle = Selector.GetHandle ("clearUserGestureInTab:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommandForEvent_X = "commandForEvent:";
		static readonly NativeHandle selCommandForEvent_XHandle = Selector.GetHandle ("commandForEvent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommandsX = "commands";
		static readonly NativeHandle selCommandsXHandle = Selector.GetHandle ("commands");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextForExtension_X = "contextForExtension:";
		static readonly NativeHandle selContextForExtension_XHandle = Selector.GetHandle ("contextForExtension:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentPermissionMatchPatternsX = "currentPermissionMatchPatterns";
		static readonly NativeHandle selCurrentPermissionMatchPatternsXHandle = Selector.GetHandle ("currentPermissionMatchPatterns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentPermissionsX = "currentPermissions";
		static readonly NativeHandle selCurrentPermissionsXHandle = Selector.GetHandle ("currentPermissions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeniedPermissionMatchPatternsX = "deniedPermissionMatchPatterns";
		static readonly NativeHandle selDeniedPermissionMatchPatternsXHandle = Selector.GetHandle ("deniedPermissionMatchPatterns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeniedPermissionsX = "deniedPermissions";
		static readonly NativeHandle selDeniedPermissionsXHandle = Selector.GetHandle ("deniedPermissions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidActivateTab_PreviousActiveTab_X = "didActivateTab:previousActiveTab:";
		static readonly NativeHandle selDidActivateTab_PreviousActiveTab_XHandle = Selector.GetHandle ("didActivateTab:previousActiveTab:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidChangeTabProperties_ForTab_X = "didChangeTabProperties:forTab:";
		static readonly NativeHandle selDidChangeTabProperties_ForTab_XHandle = Selector.GetHandle ("didChangeTabProperties:forTab:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidCloseTab_WindowIsClosing_X = "didCloseTab:windowIsClosing:";
		static readonly NativeHandle selDidCloseTab_WindowIsClosing_XHandle = Selector.GetHandle ("didCloseTab:windowIsClosing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidCloseWindow_X = "didCloseWindow:";
		static readonly NativeHandle selDidCloseWindow_XHandle = Selector.GetHandle ("didCloseWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidDeselectTabs_X = "didDeselectTabs:";
		static readonly NativeHandle selDidDeselectTabs_XHandle = Selector.GetHandle ("didDeselectTabs:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidFocusWindow_X = "didFocusWindow:";
		static readonly NativeHandle selDidFocusWindow_XHandle = Selector.GetHandle ("didFocusWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidMoveTab_FromIndex_InWindow_X = "didMoveTab:fromIndex:inWindow:";
		static readonly NativeHandle selDidMoveTab_FromIndex_InWindow_XHandle = Selector.GetHandle ("didMoveTab:fromIndex:inWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidOpenTab_X = "didOpenTab:";
		static readonly NativeHandle selDidOpenTab_XHandle = Selector.GetHandle ("didOpenTab:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidOpenWindow_X = "didOpenWindow:";
		static readonly NativeHandle selDidOpenWindow_XHandle = Selector.GetHandle ("didOpenWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidReplaceTab_WithTab_X = "didReplaceTab:withTab:";
		static readonly NativeHandle selDidReplaceTab_WithTab_XHandle = Selector.GetHandle ("didReplaceTab:withTab:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidSelectTabs_X = "didSelectTabs:";
		static readonly NativeHandle selDidSelectTabs_XHandle = Selector.GetHandle ("didSelectTabs:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selErrorsX = "errors";
		static readonly NativeHandle selErrorsXHandle = Selector.GetHandle ("errors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFocusedWindowX = "focusedWindow";
		static readonly NativeHandle selFocusedWindowXHandle = Selector.GetHandle ("focusedWindow");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGrantedPermissionMatchPatternsX = "grantedPermissionMatchPatterns";
		static readonly NativeHandle selGrantedPermissionMatchPatternsXHandle = Selector.GetHandle ("grantedPermissionMatchPatterns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGrantedPermissionsX = "grantedPermissions";
		static readonly NativeHandle selGrantedPermissionsXHandle = Selector.GetHandle ("grantedPermissions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasAccessToAllHostsX = "hasAccessToAllHosts";
		static readonly NativeHandle selHasAccessToAllHostsXHandle = Selector.GetHandle ("hasAccessToAllHosts");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasAccessToAllURLsX = "hasAccessToAllURLs";
		static readonly NativeHandle selHasAccessToAllURLsXHandle = Selector.GetHandle ("hasAccessToAllURLs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasAccessToPrivateDataX = "hasAccessToPrivateData";
		static readonly NativeHandle selHasAccessToPrivateDataXHandle = Selector.GetHandle ("hasAccessToPrivateData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasAccessToURL_X = "hasAccessToURL:";
		static readonly NativeHandle selHasAccessToURL_XHandle = Selector.GetHandle ("hasAccessToURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasAccessToURL_InTab_X = "hasAccessToURL:inTab:";
		static readonly NativeHandle selHasAccessToURL_InTab_XHandle = Selector.GetHandle ("hasAccessToURL:inTab:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasActiveUserGestureInTab_X = "hasActiveUserGestureInTab:";
		static readonly NativeHandle selHasActiveUserGestureInTab_XHandle = Selector.GetHandle ("hasActiveUserGestureInTab:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasContentModificationRulesX = "hasContentModificationRules";
		static readonly NativeHandle selHasContentModificationRulesXHandle = Selector.GetHandle ("hasContentModificationRules");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasInjectedContentX = "hasInjectedContent";
		static readonly NativeHandle selHasInjectedContentXHandle = Selector.GetHandle ("hasInjectedContent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasInjectedContentForURL_X = "hasInjectedContentForURL:";
		static readonly NativeHandle selHasInjectedContentForURL_XHandle = Selector.GetHandle ("hasInjectedContentForURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasPermission_X = "hasPermission:";
		static readonly NativeHandle selHasPermission_XHandle = Selector.GetHandle ("hasPermission:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasPermission_InTab_X = "hasPermission:inTab:";
		static readonly NativeHandle selHasPermission_InTab_XHandle = Selector.GetHandle ("hasPermission:inTab:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasRequestedOptionalAccessToAllHostsX = "hasRequestedOptionalAccessToAllHosts";
		static readonly NativeHandle selHasRequestedOptionalAccessToAllHostsXHandle = Selector.GetHandle ("hasRequestedOptionalAccessToAllHosts");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitForExtension_X = "initForExtension:";
		static readonly NativeHandle selInitForExtension_XHandle = Selector.GetHandle ("initForExtension:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInspectionNameX = "inspectionName";
		static readonly NativeHandle selInspectionNameXHandle = Selector.GetHandle ("inspectionName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsInspectableX = "isInspectable";
		static readonly NativeHandle selIsInspectableXHandle = Selector.GetHandle ("isInspectable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsLoadedX = "isLoaded";
		static readonly NativeHandle selIsLoadedXHandle = Selector.GetHandle ("isLoaded");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadBackgroundContentWithCompletionHandler_X = "loadBackgroundContentWithCompletionHandler:";
		static readonly NativeHandle selLoadBackgroundContentWithCompletionHandler_XHandle = Selector.GetHandle ("loadBackgroundContentWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMenuItemsForTab_X = "menuItemsForTab:";
		static readonly NativeHandle selMenuItemsForTab_XHandle = Selector.GetHandle ("menuItemsForTab:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenTabsX = "openTabs";
		static readonly NativeHandle selOpenTabsXHandle = Selector.GetHandle ("openTabs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenWindowsX = "openWindows";
		static readonly NativeHandle selOpenWindowsXHandle = Selector.GetHandle ("openWindows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOptionsPageURLX = "optionsPageURL";
		static readonly NativeHandle selOptionsPageURLXHandle = Selector.GetHandle ("optionsPageURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOverrideNewTabPageURLX = "overrideNewTabPageURL";
		static readonly NativeHandle selOverrideNewTabPageURLXHandle = Selector.GetHandle ("overrideNewTabPageURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformActionForTab_X = "performActionForTab:";
		static readonly NativeHandle selPerformActionForTab_XHandle = Selector.GetHandle ("performActionForTab:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformCommand_X = "performCommand:";
		static readonly NativeHandle selPerformCommand_XHandle = Selector.GetHandle ("performCommand:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformCommandForEvent_X = "performCommandForEvent:";
		static readonly NativeHandle selPerformCommandForEvent_XHandle = Selector.GetHandle ("performCommandForEvent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPermissionStatusForMatchPattern_X = "permissionStatusForMatchPattern:";
		static readonly NativeHandle selPermissionStatusForMatchPattern_XHandle = Selector.GetHandle ("permissionStatusForMatchPattern:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPermissionStatusForMatchPattern_InTab_X = "permissionStatusForMatchPattern:inTab:";
		static readonly NativeHandle selPermissionStatusForMatchPattern_InTab_XHandle = Selector.GetHandle ("permissionStatusForMatchPattern:inTab:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPermissionStatusForPermission_X = "permissionStatusForPermission:";
		static readonly NativeHandle selPermissionStatusForPermission_XHandle = Selector.GetHandle ("permissionStatusForPermission:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPermissionStatusForPermission_InTab_X = "permissionStatusForPermission:inTab:";
		static readonly NativeHandle selPermissionStatusForPermission_InTab_XHandle = Selector.GetHandle ("permissionStatusForPermission:inTab:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPermissionStatusForURL_X = "permissionStatusForURL:";
		static readonly NativeHandle selPermissionStatusForURL_XHandle = Selector.GetHandle ("permissionStatusForURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPermissionStatusForURL_InTab_X = "permissionStatusForURL:inTab:";
		static readonly NativeHandle selPermissionStatusForURL_InTab_XHandle = Selector.GetHandle ("permissionStatusForURL:inTab:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBaseURL_X = "setBaseURL:";
		static readonly NativeHandle selSetBaseURL_XHandle = Selector.GetHandle ("setBaseURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDeniedPermissionMatchPatterns_X = "setDeniedPermissionMatchPatterns:";
		static readonly NativeHandle selSetDeniedPermissionMatchPatterns_XHandle = Selector.GetHandle ("setDeniedPermissionMatchPatterns:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDeniedPermissions_X = "setDeniedPermissions:";
		static readonly NativeHandle selSetDeniedPermissions_XHandle = Selector.GetHandle ("setDeniedPermissions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGrantedPermissionMatchPatterns_X = "setGrantedPermissionMatchPatterns:";
		static readonly NativeHandle selSetGrantedPermissionMatchPatterns_XHandle = Selector.GetHandle ("setGrantedPermissionMatchPatterns:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGrantedPermissions_X = "setGrantedPermissions:";
		static readonly NativeHandle selSetGrantedPermissions_XHandle = Selector.GetHandle ("setGrantedPermissions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHasAccessToPrivateData_X = "setHasAccessToPrivateData:";
		static readonly NativeHandle selSetHasAccessToPrivateData_XHandle = Selector.GetHandle ("setHasAccessToPrivateData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHasRequestedOptionalAccessToAllHosts_X = "setHasRequestedOptionalAccessToAllHosts:";
		static readonly NativeHandle selSetHasRequestedOptionalAccessToAllHosts_XHandle = Selector.GetHandle ("setHasRequestedOptionalAccessToAllHosts:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInspectable_X = "setInspectable:";
		static readonly NativeHandle selSetInspectable_XHandle = Selector.GetHandle ("setInspectable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInspectionName_X = "setInspectionName:";
		static readonly NativeHandle selSetInspectionName_XHandle = Selector.GetHandle ("setInspectionName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPermissionStatus_ForMatchPattern_X = "setPermissionStatus:forMatchPattern:";
		static readonly NativeHandle selSetPermissionStatus_ForMatchPattern_XHandle = Selector.GetHandle ("setPermissionStatus:forMatchPattern:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPermissionStatus_ForMatchPattern_ExpirationDate_X = "setPermissionStatus:forMatchPattern:expirationDate:";
		static readonly NativeHandle selSetPermissionStatus_ForMatchPattern_ExpirationDate_XHandle = Selector.GetHandle ("setPermissionStatus:forMatchPattern:expirationDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPermissionStatus_ForPermission_X = "setPermissionStatus:forPermission:";
		static readonly NativeHandle selSetPermissionStatus_ForPermission_XHandle = Selector.GetHandle ("setPermissionStatus:forPermission:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPermissionStatus_ForPermission_ExpirationDate_X = "setPermissionStatus:forPermission:expirationDate:";
		static readonly NativeHandle selSetPermissionStatus_ForPermission_ExpirationDate_XHandle = Selector.GetHandle ("setPermissionStatus:forPermission:expirationDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPermissionStatus_ForURL_X = "setPermissionStatus:forURL:";
		static readonly NativeHandle selSetPermissionStatus_ForURL_XHandle = Selector.GetHandle ("setPermissionStatus:forURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPermissionStatus_ForURL_ExpirationDate_X = "setPermissionStatus:forURL:expirationDate:";
		static readonly NativeHandle selSetPermissionStatus_ForURL_ExpirationDate_XHandle = Selector.GetHandle ("setPermissionStatus:forURL:expirationDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUniqueIdentifier_X = "setUniqueIdentifier:";
		static readonly NativeHandle selSetUniqueIdentifier_XHandle = Selector.GetHandle ("setUniqueIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUnsupportedAPIs_X = "setUnsupportedAPIs:";
		static readonly NativeHandle selSetUnsupportedAPIs_XHandle = Selector.GetHandle ("setUnsupportedAPIs:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUniqueIdentifierX = "uniqueIdentifier";
		static readonly NativeHandle selUniqueIdentifierXHandle = Selector.GetHandle ("uniqueIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnsupportedAPIsX = "unsupportedAPIs";
		static readonly NativeHandle selUnsupportedAPIsXHandle = Selector.GetHandle ("unsupportedAPIs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserGesturePerformedInTab_X = "userGesturePerformedInTab:";
		static readonly NativeHandle selUserGesturePerformedInTab_XHandle = Selector.GetHandle ("userGesturePerformedInTab:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWebExtensionX = "webExtension";
		static readonly NativeHandle selWebExtensionXHandle = Selector.GetHandle ("webExtension");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWebExtensionControllerX = "webExtensionController";
		static readonly NativeHandle selWebExtensionControllerXHandle = Selector.GetHandle ("webExtensionController");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWebViewConfigurationX = "webViewConfiguration";
		static readonly NativeHandle selWebViewConfigurationXHandle = Selector.GetHandle ("webViewConfiguration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("WKWebExtensionContext");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected WKWebExtensionContext (NSObjectFlag t) : base (t)
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
		protected internal WKWebExtensionContext (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initForExtension:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public WKWebExtensionContext (WKWebExtension extension)
			: base (NSObjectFlag.Empty)
		{
			var extension__handle__ = extension!.GetNonNullHandle (nameof (extension));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitForExtension_XHandle, extension__handle__), "initForExtension:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitForExtension_XHandle, extension__handle__), "initForExtension:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (extension);
		}
		[Export ("clearUserGestureInTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClearUserGesture (IWKWebExtensionTab tab)
		{
			var tab__handle__ = tab!.GetNonNullHandle (nameof (tab));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selClearUserGestureInTab_XHandle, tab__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selClearUserGestureInTab_XHandle, tab__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tab);
		}
		[Export ("contextForExtension:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static WKWebExtensionContext Create (WKWebExtension extension)
		{
			var extension__handle__ = extension!.GetNonNullHandle (nameof (extension));
			WKWebExtensionContext? ret;
			ret =  Runtime.GetNSObject<WKWebExtensionContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selContextForExtension_XHandle, extension__handle__), false)!;
			GC.KeepAlive (extension);
			return ret!;
		}
		[Export ("didActivateTab:previousActiveTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidActivateTab (IWKWebExtensionTab activatedTab, IWKWebExtensionTab? previousTab)
		{
			var activatedTab__handle__ = activatedTab!.GetNonNullHandle (nameof (activatedTab));
			var previousTab__handle__ = previousTab.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDidActivateTab_PreviousActiveTab_XHandle, activatedTab__handle__, previousTab__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDidActivateTab_PreviousActiveTab_XHandle, activatedTab__handle__, previousTab__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (activatedTab);
			GC.KeepAlive (previousTab);
		}
		[Export ("didChangeTabProperties:forTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeTabProperties (WKWebExtensionTabChangedProperties properties, IWKWebExtensionTab changedTab)
		{
			var changedTab__handle__ = changedTab!.GetNonNullHandle (nameof (changedTab));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle (this.Handle, selDidChangeTabProperties_ForTab_XHandle, (UIntPtr) (ulong) properties, changedTab__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, selDidChangeTabProperties_ForTab_XHandle, (UIntPtr) (ulong) properties, changedTab__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (changedTab);
		}
		[Export ("didCloseTab:windowIsClosing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCloseTab (IWKWebExtensionTab closedTab, bool windowIsClosing)
		{
			var closedTab__handle__ = closedTab!.GetNonNullHandle (nameof (closedTab));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selDidCloseTab_WindowIsClosing_XHandle, closedTab__handle__, windowIsClosing ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selDidCloseTab_WindowIsClosing_XHandle, closedTab__handle__, windowIsClosing ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (closedTab);
		}
		[Export ("didCloseWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCloseWindow (IWKWebExtensionWindow closedWindow)
		{
			var closedWindow__handle__ = closedWindow!.GetNonNullHandle (nameof (closedWindow));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDidCloseWindow_XHandle, closedWindow__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDidCloseWindow_XHandle, closedWindow__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (closedWindow);
		}
		[Export ("didDeselectTabs:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDeselectTabs (IWKWebExtensionTab[] deselectedTabs)
		{
			if (deselectedTabs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (deselectedTabs));
			using var nsa_deselectedTabs = NSArray.FromNSObjects (deselectedTabs);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDidDeselectTabs_XHandle, nsa_deselectedTabs.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDidDeselectTabs_XHandle, nsa_deselectedTabs.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("didFocusWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFocusWindow (IWKWebExtensionWindow? focusedWindow)
		{
			var focusedWindow__handle__ = focusedWindow.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDidFocusWindow_XHandle, focusedWindow__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDidFocusWindow_XHandle, focusedWindow__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (focusedWindow);
		}
		[Export ("didMoveTab:fromIndex:inWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidMoveTab (IWKWebExtensionTab movedTab, nuint index, IWKWebExtensionWindow? oldWindow)
		{
			var movedTab__handle__ = movedTab!.GetNonNullHandle (nameof (movedTab));
			var oldWindow__handle__ = oldWindow.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, selDidMoveTab_FromIndex_InWindow_XHandle, movedTab__handle__, index, oldWindow__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selDidMoveTab_FromIndex_InWindow_XHandle, movedTab__handle__, index, oldWindow__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (movedTab);
			GC.KeepAlive (oldWindow);
		}
		[Export ("didOpenTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOpenTab (IWKWebExtensionTab newTab)
		{
			var newTab__handle__ = newTab!.GetNonNullHandle (nameof (newTab));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDidOpenTab_XHandle, newTab__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDidOpenTab_XHandle, newTab__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newTab);
		}
		[Export ("didOpenWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOpenWindow (IWKWebExtensionWindow newWindow)
		{
			var newWindow__handle__ = newWindow!.GetNonNullHandle (nameof (newWindow));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDidOpenWindow_XHandle, newWindow__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDidOpenWindow_XHandle, newWindow__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newWindow);
		}
		[Export ("didReplaceTab:withTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReplaceTab (IWKWebExtensionTab oldTab, IWKWebExtensionTab newTab)
		{
			var oldTab__handle__ = oldTab!.GetNonNullHandle (nameof (oldTab));
			var newTab__handle__ = newTab!.GetNonNullHandle (nameof (newTab));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDidReplaceTab_WithTab_XHandle, oldTab__handle__, newTab__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDidReplaceTab_WithTab_XHandle, oldTab__handle__, newTab__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (oldTab);
			GC.KeepAlive (newTab);
		}
		[Export ("didSelectTabs:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectTabs (IWKWebExtensionTab[] selectedTabs)
		{
			if (selectedTabs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (selectedTabs));
			using var nsa_selectedTabs = NSArray.FromNSObjects (selectedTabs);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDidSelectTabs_XHandle, nsa_selectedTabs.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDidSelectTabs_XHandle, nsa_selectedTabs.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("actionForTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebExtensionAction? GetAction (IWKWebExtensionTab? tab)
		{
			var tab__handle__ = tab.GetHandle ();
			WKWebExtensionAction? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKWebExtensionAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selActionForTab_XHandle, tab__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKWebExtensionAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selActionForTab_XHandle, tab__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tab);
			return ret!;
		}
		[Export ("commandForEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebExtensionCommand? GetCommand (global::AppKit.NSEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			WKWebExtensionCommand? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WKWebExtensionCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCommandForEvent_XHandle, @event__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WKWebExtensionCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCommandForEvent_XHandle, @event__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (@event);
			return ret!;
		}
		[Export ("menuItemsForTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSMenuItem[] GetMenuItems (IWKWebExtensionTab tab)
		{
			var tab__handle__ = tab!.GetNonNullHandle (nameof (tab));
			global::AppKit.NSMenuItem[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<global::AppKit.NSMenuItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMenuItemsForTab_XHandle, tab__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<global::AppKit.NSMenuItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMenuItemsForTab_XHandle, tab__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tab);
			return ret!;
		}
		[Export ("permissionStatusForPermission:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebExtensionContextPermissionStatus GetPermissionStatus (string permission)
		{
			if (permission is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (permission));
			var nspermission = CFString.CreateNative (permission);
			WKWebExtensionContextPermissionStatus ret;
			if (IsDirectBinding) {
				ret = (WebKit.WKWebExtensionContextPermissionStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selPermissionStatusForPermission_XHandle, nspermission);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (WebKit.WKWebExtensionContextPermissionStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selPermissionStatusForPermission_XHandle, nspermission);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspermission);
			return ret!;
		}
		[Export ("permissionStatusForPermission:inTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebExtensionContextPermissionStatus GetPermissionStatus (string permission, IWKWebExtensionTab? tab)
		{
			if (permission is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (permission));
			var tab__handle__ = tab.GetHandle ();
			var nspermission = CFString.CreateNative (permission);
			WKWebExtensionContextPermissionStatus ret;
			if (IsDirectBinding) {
				ret = (WebKit.WKWebExtensionContextPermissionStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPermissionStatusForPermission_InTab_XHandle, nspermission, tab__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (WebKit.WKWebExtensionContextPermissionStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPermissionStatusForPermission_InTab_XHandle, nspermission, tab__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tab);
			CFString.ReleaseNative (nspermission);
			return ret!;
		}
		[Export ("permissionStatusForURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebExtensionContextPermissionStatus GetPermissionStatus (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			WKWebExtensionContextPermissionStatus ret;
			if (IsDirectBinding) {
				ret = (WebKit.WKWebExtensionContextPermissionStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selPermissionStatusForURL_XHandle, url__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (WebKit.WKWebExtensionContextPermissionStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selPermissionStatusForURL_XHandle, url__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("permissionStatusForURL:inTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebExtensionContextPermissionStatus GetPermissionStatus (NSUrl url, IWKWebExtensionTab? tab)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var tab__handle__ = tab.GetHandle ();
			WKWebExtensionContextPermissionStatus ret;
			if (IsDirectBinding) {
				ret = (WebKit.WKWebExtensionContextPermissionStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPermissionStatusForURL_InTab_XHandle, url__handle__, tab__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (WebKit.WKWebExtensionContextPermissionStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPermissionStatusForURL_InTab_XHandle, url__handle__, tab__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (tab);
			return ret!;
		}
		[Export ("permissionStatusForMatchPattern:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebExtensionContextPermissionStatus GetPermissionStatus (WKWebExtensionMatchPattern pattern)
		{
			var pattern__handle__ = pattern!.GetNonNullHandle (nameof (pattern));
			WKWebExtensionContextPermissionStatus ret;
			if (IsDirectBinding) {
				ret = (WebKit.WKWebExtensionContextPermissionStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selPermissionStatusForMatchPattern_XHandle, pattern__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (WebKit.WKWebExtensionContextPermissionStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selPermissionStatusForMatchPattern_XHandle, pattern__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pattern);
			return ret!;
		}
		[Export ("permissionStatusForMatchPattern:inTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebExtensionContextPermissionStatus GetPermissionStatus (WKWebExtensionMatchPattern pattern, IWKWebExtensionTab? tab)
		{
			var pattern__handle__ = pattern!.GetNonNullHandle (nameof (pattern));
			var tab__handle__ = tab.GetHandle ();
			WKWebExtensionContextPermissionStatus ret;
			if (IsDirectBinding) {
				ret = (WebKit.WKWebExtensionContextPermissionStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPermissionStatusForMatchPattern_InTab_XHandle, pattern__handle__, tab__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (WebKit.WKWebExtensionContextPermissionStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPermissionStatusForMatchPattern_InTab_XHandle, pattern__handle__, tab__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pattern);
			GC.KeepAlive (tab);
			return ret!;
		}
		[Export ("hasAccessToURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasAccessToUrl (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selHasAccessToURL_XHandle, url__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selHasAccessToURL_XHandle, url__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			return ret != 0;
		}
		[Export ("hasAccessToURL:inTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasAccessToUrl (NSUrl url, IWKWebExtensionTab? tab)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var tab__handle__ = tab.GetHandle ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selHasAccessToURL_InTab_XHandle, url__handle__, tab__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selHasAccessToURL_InTab_XHandle, url__handle__, tab__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (tab);
			return ret != 0;
		}
		[Export ("hasActiveUserGestureInTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasActiveUserGesture (IWKWebExtensionTab tab)
		{
			var tab__handle__ = tab!.GetNonNullHandle (nameof (tab));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selHasActiveUserGestureInTab_XHandle, tab__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selHasActiveUserGestureInTab_XHandle, tab__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tab);
			return ret != 0;
		}
		[Export ("hasInjectedContentForURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasInjectedContentForUrl (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selHasInjectedContentForURL_XHandle, url__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selHasInjectedContentForURL_XHandle, url__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			return ret != 0;
		}
		[Export ("hasPermission:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasPermission (string permission)
		{
			if (permission is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (permission));
			var nspermission = CFString.CreateNative (permission);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selHasPermission_XHandle, nspermission);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selHasPermission_XHandle, nspermission);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspermission);
			return ret != 0;
		}
		[Export ("hasPermission:inTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasPermission (string permission, IWKWebExtensionTab? tab)
		{
			if (permission is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (permission));
			var tab__handle__ = tab.GetHandle ();
			var nspermission = CFString.CreateNative (permission);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selHasPermission_InTab_XHandle, nspermission, tab__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selHasPermission_InTab_XHandle, nspermission, tab__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tab);
			CFString.ReleaseNative (nspermission);
			return ret != 0;
		}
		[Export ("loadBackgroundContentWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadBackgroundContent ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionContextCallback))]WKWebExtensionContextCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionContextCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLoadBackgroundContentWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLoadBackgroundContentWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task LoadBackgroundContentAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			LoadBackgroundContent((error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("performActionForTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformAction (IWKWebExtensionTab? tab)
		{
			var tab__handle__ = tab.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPerformActionForTab_XHandle, tab__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPerformActionForTab_XHandle, tab__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tab);
		}
		[Export ("performCommand:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformCommand (WKWebExtensionCommand command)
		{
			var command__handle__ = command!.GetNonNullHandle (nameof (command));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPerformCommand_XHandle, command__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPerformCommand_XHandle, command__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (command);
		}
		[Export ("performCommandForEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PerformCommand (global::AppKit.NSEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selPerformCommandForEvent_XHandle, @event__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selPerformCommandForEvent_XHandle, @event__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (@event);
			return ret != 0;
		}
		[Export ("setPermissionStatus:forPermission:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPermissionStatus (WKWebExtensionContextPermissionStatus status, string permission)
		{
			if (permission is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (permission));
			var nspermission = CFString.CreateNative (permission);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, selSetPermissionStatus_ForPermission_XHandle, (IntPtr) (long) status, nspermission);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selSetPermissionStatus_ForPermission_XHandle, (IntPtr) (long) status, nspermission);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspermission);
		}
		[Export ("setPermissionStatus:forPermission:expirationDate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPermissionStatus (WKWebExtensionContextPermissionStatus status, string permission, NSDate? expirationDate)
		{
			if (permission is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (permission));
			var expirationDate__handle__ = expirationDate.GetHandle ();
			var nspermission = CFString.CreateNative (permission);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle (this.Handle, selSetPermissionStatus_ForPermission_ExpirationDate_XHandle, (IntPtr) (long) status, nspermission, expirationDate__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle_NativeHandle (&__objc_super__, selSetPermissionStatus_ForPermission_ExpirationDate_XHandle, (IntPtr) (long) status, nspermission, expirationDate__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (expirationDate);
			CFString.ReleaseNative (nspermission);
		}
		[Export ("setPermissionStatus:forURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPermissionStatus (WKWebExtensionContextPermissionStatus status, NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, selSetPermissionStatus_ForURL_XHandle, (IntPtr) (long) status, url__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selSetPermissionStatus_ForURL_XHandle, (IntPtr) (long) status, url__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		[Export ("setPermissionStatus:forURL:expirationDate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPermissionStatus (WKWebExtensionContextPermissionStatus status, NSUrl url, NSDate? expirationDate)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var expirationDate__handle__ = expirationDate.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle (this.Handle, selSetPermissionStatus_ForURL_ExpirationDate_XHandle, (IntPtr) (long) status, url__handle__, expirationDate__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle_NativeHandle (&__objc_super__, selSetPermissionStatus_ForURL_ExpirationDate_XHandle, (IntPtr) (long) status, url__handle__, expirationDate__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (expirationDate);
		}
		[Export ("setPermissionStatus:forMatchPattern:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPermissionStatus (WKWebExtensionContextPermissionStatus status, WKWebExtensionMatchPattern pattern)
		{
			var pattern__handle__ = pattern!.GetNonNullHandle (nameof (pattern));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, selSetPermissionStatus_ForMatchPattern_XHandle, (IntPtr) (long) status, pattern__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selSetPermissionStatus_ForMatchPattern_XHandle, (IntPtr) (long) status, pattern__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pattern);
		}
		[Export ("setPermissionStatus:forMatchPattern:expirationDate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPermissionStatus (WKWebExtensionContextPermissionStatus status, WKWebExtensionMatchPattern pattern, NSDate? expirationDate)
		{
			var pattern__handle__ = pattern!.GetNonNullHandle (nameof (pattern));
			var expirationDate__handle__ = expirationDate.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle (this.Handle, selSetPermissionStatus_ForMatchPattern_ExpirationDate_XHandle, (IntPtr) (long) status, pattern__handle__, expirationDate__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle_NativeHandle (&__objc_super__, selSetPermissionStatus_ForMatchPattern_ExpirationDate_XHandle, (IntPtr) (long) status, pattern__handle__, expirationDate__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pattern);
			GC.KeepAlive (expirationDate);
		}
		[Export ("userGesturePerformedInTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserGesturePerformed (IWKWebExtensionTab tab)
		{
			var tab__handle__ = tab!.GetNonNullHandle (nameof (tab));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUserGesturePerformedInTab_XHandle, tab__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUserGesturePerformedInTab_XHandle, tab__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tab);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl BaseUrl {
			[Export ("baseURL", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBaseURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBaseURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBaseURL:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetBaseURL_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetBaseURL_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebExtensionCommand[] Commands {
			[Export ("commands", ArgumentSemantic.Copy)]
			get {
				WKWebExtensionCommand[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<WKWebExtensionCommand>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCommandsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<WKWebExtensionCommand>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCommandsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebExtensionPermission CurrentPermission {
			get {
				return WKWebExtensionPermissionExtensions.ToFlags (WeakCurrentPermissions);;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<WKWebExtensionMatchPattern> CurrentPermissionMatchPatterns {
			[Export ("currentPermissionMatchPatterns", ArgumentSemantic.Copy)]
			get {
				NSSet<WKWebExtensionMatchPattern>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<WKWebExtensionMatchPattern>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentPermissionMatchPatternsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<WKWebExtensionMatchPattern>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentPermissionMatchPatternsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<WKWebExtensionMatchPattern, NSDate> DeniedPermissionMatchPatterns {
			[Export ("deniedPermissionMatchPatterns", ArgumentSemantic.Copy)]
			get {
				NSDictionary<WKWebExtensionMatchPattern, NSDate>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<WKWebExtensionMatchPattern, NSDate>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDeniedPermissionMatchPatternsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<WKWebExtensionMatchPattern, NSDate>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDeniedPermissionMatchPatternsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDeniedPermissionMatchPatterns:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDeniedPermissionMatchPatterns_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDeniedPermissionMatchPatterns_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSDate> DeniedPermissions {
			[Export ("deniedPermissions", ArgumentSemantic.Copy)]
			get {
				NSDictionary<NSString, NSDate>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSDate>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDeniedPermissionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, NSDate>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDeniedPermissionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDeniedPermissions:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDeniedPermissions_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDeniedPermissions_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSError[] Errors {
			[Export ("errors", ArgumentSemantic.Copy)]
			get {
				NSError[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSError>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selErrorsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSError>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selErrorsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_FocusedWindow_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IWKWebExtensionWindow? FocusedWindow {
			[Export ("focusedWindow", ArgumentSemantic.Weak)]
			get {
				IWKWebExtensionWindow? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IWKWebExtensionWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFocusedWindowXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IWKWebExtensionWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFocusedWindowXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_FocusedWindow_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<WKWebExtensionMatchPattern, NSDate> GrantedPermissionMatchPatterns {
			[Export ("grantedPermissionMatchPatterns", ArgumentSemantic.Copy)]
			get {
				NSDictionary<WKWebExtensionMatchPattern, NSDate>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<WKWebExtensionMatchPattern, NSDate>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGrantedPermissionMatchPatternsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<WKWebExtensionMatchPattern, NSDate>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGrantedPermissionMatchPatternsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setGrantedPermissionMatchPatterns:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetGrantedPermissionMatchPatterns_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetGrantedPermissionMatchPatterns_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSDate> GrantedPermissions {
			[Export ("grantedPermissions", ArgumentSemantic.Copy)]
			get {
				NSDictionary<NSString, NSDate>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSDate>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGrantedPermissionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, NSDate>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGrantedPermissionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setGrantedPermissions:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetGrantedPermissions_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetGrantedPermissions_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasAccessToAllHosts {
			[Export ("hasAccessToAllHosts")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasAccessToAllHostsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasAccessToAllHostsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasAccessToAllUrls {
			[Export ("hasAccessToAllURLs")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasAccessToAllURLsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasAccessToAllURLsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasAccessToPrivateData {
			[Export ("hasAccessToPrivateData")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasAccessToPrivateDataXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasAccessToPrivateDataXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHasAccessToPrivateData:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHasAccessToPrivateData_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetHasAccessToPrivateData_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasContentModificationRules {
			[Export ("hasContentModificationRules")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasContentModificationRulesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasContentModificationRulesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasInjectedContent {
			[Export ("hasInjectedContent")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasInjectedContentXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasInjectedContentXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasRequestedOptionalAccessToAllHosts {
			[Export ("hasRequestedOptionalAccessToAllHosts")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasRequestedOptionalAccessToAllHostsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasRequestedOptionalAccessToAllHostsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHasRequestedOptionalAccessToAllHosts:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHasRequestedOptionalAccessToAllHosts_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetHasRequestedOptionalAccessToAllHosts_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		public virtual string? InspectionName {
			[Export ("inspectionName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInspectionNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInspectionNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setInspectionName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetInspectionName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetInspectionName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Loaded {
			[Export ("isLoaded")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLoadedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsLoadedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<IWKWebExtensionTab> OpenTabs {
			[Export ("openTabs", ArgumentSemantic.Copy)]
			get {
				NSSet<IWKWebExtensionTab>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<IWKWebExtensionTab>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOpenTabsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<IWKWebExtensionTab>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOpenTabsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IWKWebExtensionWindow[] OpenWindows {
			[Export ("openWindows", ArgumentSemantic.Copy)]
			get {
				IWKWebExtensionWindow[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IWKWebExtensionWindow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOpenWindowsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IWKWebExtensionWindow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOpenWindowsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? OptionsPageUrl {
			[Export ("optionsPageURL", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOptionsPageURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOptionsPageURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? OverrideNewTabPageUrl {
			[Export ("overrideNewTabPageURL", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOverrideNewTabPageURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOverrideNewTabPageURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string UniqueIdentifier {
			[Export ("uniqueIdentifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUniqueIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUniqueIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setUniqueIdentifier:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetUniqueIdentifier_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetUniqueIdentifier_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<NSString>? UnsupportedAPIs {
			[Export ("unsupportedAPIs", ArgumentSemantic.Copy)]
			get {
				NSSet<NSString>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUnsupportedAPIsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUnsupportedAPIsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setUnsupportedAPIs:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetUnsupportedAPIs_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetUnsupportedAPIs_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<NSString> WeakCurrentPermissions {
			[Export ("currentPermissions", ArgumentSemantic.Copy)]
			get {
				NSSet<NSString>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentPermissionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentPermissionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebExtension WebExtension {
			[Export ("webExtension", ArgumentSemantic.Retain)]
			get {
				WKWebExtension? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WKWebExtension> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWebExtensionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<WKWebExtension> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWebExtensionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WebExtensionController_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebExtensionController? WebExtensionController {
			[Export ("webExtensionController", ArgumentSemantic.Weak)]
			get {
				WKWebExtensionController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WKWebExtensionController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWebExtensionControllerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<WKWebExtensionController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWebExtensionControllerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WebExtensionController_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebViewConfiguration? WebViewConfiguration {
			[Export ("webViewConfiguration", ArgumentSemantic.Copy)]
			get {
				WKWebViewConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WKWebViewConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWebViewConfigurationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<WKWebViewConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWebViewConfigurationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DeniedPermissionMatchPatternsWereRemovedNotification;
		/// <summary>Notification constant for DeniedPermissionMatchPatternsWereRemoved</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDeniedPermissionMatchPatternsWereRemoved(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDeniedPermissionMatchPatternsWereRemoved(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = WKWebExtensionContext.Notifications.ObserveDeniedPermissionMatchPatternsWereRemoved ((sender, args) => {
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
		/// void Callback (object sender, WKWebExtensionContext.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = WKWebExtensionContext.Notifications.ObserveDeniedPermissionMatchPatternsWereRemoved (Callback);
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
		///     WKWebExtensionContext.DeniedPermissionMatchPatternsWereRemovedNotification, (notification) => { Console.WriteLine ("Received the notification DeniedPermissionMatchPatternsWereRemoved", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DeniedPermissionMatchPatternsWereRemoved", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (WKWebExtensionContext.DeniedPermissionMatchPatternsWereRemovedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("WKWebExtensionContextDeniedPermissionMatchPatternsWereRemovedNotification",  "WebKit")]
		[Advice ("Use WKWebExtensionContext.Notifications.ObserveDeniedPermissionMatchPatternsWereRemoved helper method instead.")]
		public static NSString DeniedPermissionMatchPatternsWereRemovedNotification {
			get {
				if (_DeniedPermissionMatchPatternsWereRemovedNotification is null)
					_DeniedPermissionMatchPatternsWereRemovedNotification = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebExtensionContextDeniedPermissionMatchPatternsWereRemovedNotification")!;
				return _DeniedPermissionMatchPatternsWereRemovedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DeniedPermissionsWereRemovedNotification;
		/// <summary>Notification constant for DeniedPermissionsWereRemoved</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDeniedPermissionsWereRemoved(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDeniedPermissionsWereRemoved(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = WKWebExtensionContext.Notifications.ObserveDeniedPermissionsWereRemoved ((sender, args) => {
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
		/// void Callback (object sender, WKWebExtensionContext.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = WKWebExtensionContext.Notifications.ObserveDeniedPermissionsWereRemoved (Callback);
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
		///     WKWebExtensionContext.DeniedPermissionsWereRemovedNotification, (notification) => { Console.WriteLine ("Received the notification DeniedPermissionsWereRemoved", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DeniedPermissionsWereRemoved", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (WKWebExtensionContext.DeniedPermissionsWereRemovedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("WKWebExtensionContextDeniedPermissionsWereRemovedNotification",  "WebKit")]
		[Advice ("Use WKWebExtensionContext.Notifications.ObserveDeniedPermissionsWereRemoved helper method instead.")]
		public static NSString DeniedPermissionsWereRemovedNotification {
			get {
				if (_DeniedPermissionsWereRemovedNotification is null)
					_DeniedPermissionsWereRemovedNotification = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebExtensionContextDeniedPermissionsWereRemovedNotification")!;
				return _DeniedPermissionsWereRemovedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ErrorsDidUpdateNotification;
		/// <summary>Notification constant for ErrorsDidUpdate</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveErrorsDidUpdate(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveErrorsDidUpdate(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = WKWebExtensionContext.Notifications.ObserveErrorsDidUpdate ((sender, args) => {
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
		/// void Callback (object sender, WKWebExtensionContext.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = WKWebExtensionContext.Notifications.ObserveErrorsDidUpdate (Callback);
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
		///     WKWebExtensionContext.ErrorsDidUpdateNotification, (notification) => { Console.WriteLine ("Received the notification ErrorsDidUpdate", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ErrorsDidUpdate", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (WKWebExtensionContext.ErrorsDidUpdateNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("WKWebExtensionContextErrorsDidUpdateNotification",  "WebKit")]
		[Advice ("Use WKWebExtensionContext.Notifications.ObserveErrorsDidUpdate helper method instead.")]
		public static NSString ErrorsDidUpdateNotification {
			get {
				if (_ErrorsDidUpdateNotification is null)
					_ErrorsDidUpdateNotification = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebExtensionContextErrorsDidUpdateNotification")!;
				return _ErrorsDidUpdateNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GrantedPermissionMatchPatternsWereRemovedNotification;
		/// <summary>Notification constant for GrantedPermissionMatchPatternsWereRemoved</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveGrantedPermissionMatchPatternsWereRemoved(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveGrantedPermissionMatchPatternsWereRemoved(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = WKWebExtensionContext.Notifications.ObserveGrantedPermissionMatchPatternsWereRemoved ((sender, args) => {
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
		/// void Callback (object sender, WKWebExtensionContext.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = WKWebExtensionContext.Notifications.ObserveGrantedPermissionMatchPatternsWereRemoved (Callback);
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
		///     WKWebExtensionContext.GrantedPermissionMatchPatternsWereRemovedNotification, (notification) => { Console.WriteLine ("Received the notification GrantedPermissionMatchPatternsWereRemoved", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification GrantedPermissionMatchPatternsWereRemoved", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (WKWebExtensionContext.GrantedPermissionMatchPatternsWereRemovedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("WKWebExtensionContextGrantedPermissionMatchPatternsWereRemovedNotification",  "WebKit")]
		[Advice ("Use WKWebExtensionContext.Notifications.ObserveGrantedPermissionMatchPatternsWereRemoved helper method instead.")]
		public static NSString GrantedPermissionMatchPatternsWereRemovedNotification {
			get {
				if (_GrantedPermissionMatchPatternsWereRemovedNotification is null)
					_GrantedPermissionMatchPatternsWereRemovedNotification = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebExtensionContextGrantedPermissionMatchPatternsWereRemovedNotification")!;
				return _GrantedPermissionMatchPatternsWereRemovedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GrantedPermissionsWereRemovedNotification;
		/// <summary>Notification constant for GrantedPermissionsWereRemoved</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveGrantedPermissionsWereRemoved(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveGrantedPermissionsWereRemoved(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = WKWebExtensionContext.Notifications.ObserveGrantedPermissionsWereRemoved ((sender, args) => {
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
		/// void Callback (object sender, WKWebExtensionContext.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = WKWebExtensionContext.Notifications.ObserveGrantedPermissionsWereRemoved (Callback);
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
		///     WKWebExtensionContext.GrantedPermissionsWereRemovedNotification, (notification) => { Console.WriteLine ("Received the notification GrantedPermissionsWereRemoved", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification GrantedPermissionsWereRemoved", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (WKWebExtensionContext.GrantedPermissionsWereRemovedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("WKWebExtensionContextGrantedPermissionsWereRemovedNotification",  "WebKit")]
		[Advice ("Use WKWebExtensionContext.Notifications.ObserveGrantedPermissionsWereRemoved helper method instead.")]
		public static NSString GrantedPermissionsWereRemovedNotification {
			get {
				if (_GrantedPermissionsWereRemovedNotification is null)
					_GrantedPermissionsWereRemovedNotification = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebExtensionContextGrantedPermissionsWereRemovedNotification")!;
				return _GrantedPermissionsWereRemovedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NotificationUserInfoKeyMatchPatterns;
		/// <summary>Notification constant for NotificationUserInfoKeyMatchPatterns</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveNotificationUserInfoKeyMatchPatterns(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveNotificationUserInfoKeyMatchPatterns(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = WKWebExtensionContext.Notifications.ObserveNotificationUserInfoKeyMatchPatterns ((sender, args) => {
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
		/// void Callback (object sender, WKWebExtensionContext.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = WKWebExtensionContext.Notifications.ObserveNotificationUserInfoKeyMatchPatterns (Callback);
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
		///     WKWebExtensionContext.NotificationUserInfoKeyMatchPatternsNotification, (notification) => { Console.WriteLine ("Received the notification NotificationUserInfoKeyMatchPatterns", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification NotificationUserInfoKeyMatchPatterns", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (WKWebExtensionContext.NotificationUserInfoKeyMatchPatternsNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("WKWebExtensionContextNotificationUserInfoKeyMatchPatterns",  "WebKit")]
		[Advice ("Use WKWebExtensionContext.Notifications.ObserveNotificationUserInfoKeyMatchPatterns helper method instead.")]
		public static NSString NotificationUserInfoKeyMatchPatterns {
			get {
				if (_NotificationUserInfoKeyMatchPatterns is null)
					_NotificationUserInfoKeyMatchPatterns = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebExtensionContextNotificationUserInfoKeyMatchPatterns")!;
				return _NotificationUserInfoKeyMatchPatterns;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NotificationUserInfoKeyPermissions;
		/// <summary>Notification constant for NotificationUserInfoKeyPermissions</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveNotificationUserInfoKeyPermissions(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveNotificationUserInfoKeyPermissions(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = WKWebExtensionContext.Notifications.ObserveNotificationUserInfoKeyPermissions ((sender, args) => {
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
		/// void Callback (object sender, WKWebExtensionContext.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = WKWebExtensionContext.Notifications.ObserveNotificationUserInfoKeyPermissions (Callback);
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
		///     WKWebExtensionContext.NotificationUserInfoKeyPermissionsNotification, (notification) => { Console.WriteLine ("Received the notification NotificationUserInfoKeyPermissions", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification NotificationUserInfoKeyPermissions", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (WKWebExtensionContext.NotificationUserInfoKeyPermissionsNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("WKWebExtensionContextNotificationUserInfoKeyPermissions",  "WebKit")]
		[Advice ("Use WKWebExtensionContext.Notifications.ObserveNotificationUserInfoKeyPermissions helper method instead.")]
		public static NSString NotificationUserInfoKeyPermissions {
			get {
				if (_NotificationUserInfoKeyPermissions is null)
					_NotificationUserInfoKeyPermissions = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebExtensionContextNotificationUserInfoKeyPermissions")!;
				return _NotificationUserInfoKeyPermissions;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PermissionMatchPatternsWereDeniedNotification;
		/// <summary>Notification constant for PermissionMatchPatternsWereDenied</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObservePermissionMatchPatternsWereDenied(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObservePermissionMatchPatternsWereDenied(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = WKWebExtensionContext.Notifications.ObservePermissionMatchPatternsWereDenied ((sender, args) => {
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
		/// void Callback (object sender, WKWebExtensionContext.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = WKWebExtensionContext.Notifications.ObservePermissionMatchPatternsWereDenied (Callback);
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
		///     WKWebExtensionContext.PermissionMatchPatternsWereDeniedNotification, (notification) => { Console.WriteLine ("Received the notification PermissionMatchPatternsWereDenied", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification PermissionMatchPatternsWereDenied", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (WKWebExtensionContext.PermissionMatchPatternsWereDeniedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("WKWebExtensionContextPermissionMatchPatternsWereDeniedNotification",  "WebKit")]
		[Advice ("Use WKWebExtensionContext.Notifications.ObservePermissionMatchPatternsWereDenied helper method instead.")]
		public static NSString PermissionMatchPatternsWereDeniedNotification {
			get {
				if (_PermissionMatchPatternsWereDeniedNotification is null)
					_PermissionMatchPatternsWereDeniedNotification = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebExtensionContextPermissionMatchPatternsWereDeniedNotification")!;
				return _PermissionMatchPatternsWereDeniedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PermissionMatchPatternsWereGrantedNotification;
		/// <summary>Notification constant for PermissionMatchPatternsWereGranted</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObservePermissionMatchPatternsWereGranted(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObservePermissionMatchPatternsWereGranted(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = WKWebExtensionContext.Notifications.ObservePermissionMatchPatternsWereGranted ((sender, args) => {
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
		/// void Callback (object sender, WKWebExtensionContext.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = WKWebExtensionContext.Notifications.ObservePermissionMatchPatternsWereGranted (Callback);
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
		///     WKWebExtensionContext.PermissionMatchPatternsWereGrantedNotification, (notification) => { Console.WriteLine ("Received the notification PermissionMatchPatternsWereGranted", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification PermissionMatchPatternsWereGranted", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (WKWebExtensionContext.PermissionMatchPatternsWereGrantedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("WKWebExtensionContextPermissionMatchPatternsWereGrantedNotification",  "WebKit")]
		[Advice ("Use WKWebExtensionContext.Notifications.ObservePermissionMatchPatternsWereGranted helper method instead.")]
		public static NSString PermissionMatchPatternsWereGrantedNotification {
			get {
				if (_PermissionMatchPatternsWereGrantedNotification is null)
					_PermissionMatchPatternsWereGrantedNotification = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebExtensionContextPermissionMatchPatternsWereGrantedNotification")!;
				return _PermissionMatchPatternsWereGrantedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PermissionsWereDeniedNotification;
		/// <summary>Notification constant for PermissionsWereDenied</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObservePermissionsWereDenied(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObservePermissionsWereDenied(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = WKWebExtensionContext.Notifications.ObservePermissionsWereDenied ((sender, args) => {
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
		/// void Callback (object sender, WKWebExtensionContext.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = WKWebExtensionContext.Notifications.ObservePermissionsWereDenied (Callback);
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
		///     WKWebExtensionContext.PermissionsWereDeniedNotification, (notification) => { Console.WriteLine ("Received the notification PermissionsWereDenied", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification PermissionsWereDenied", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (WKWebExtensionContext.PermissionsWereDeniedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("WKWebExtensionContextPermissionsWereDeniedNotification",  "WebKit")]
		[Advice ("Use WKWebExtensionContext.Notifications.ObservePermissionsWereDenied helper method instead.")]
		public static NSString PermissionsWereDeniedNotification {
			get {
				if (_PermissionsWereDeniedNotification is null)
					_PermissionsWereDeniedNotification = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebExtensionContextPermissionsWereDeniedNotification")!;
				return _PermissionsWereDeniedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PermissionsWereGrantedNotification;
		/// <summary>Notification constant for PermissionsWereGranted</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObservePermissionsWereGranted(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObservePermissionsWereGranted(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = WKWebExtensionContext.Notifications.ObservePermissionsWereGranted ((sender, args) => {
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
		/// void Callback (object sender, WKWebExtensionContext.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = WKWebExtensionContext.Notifications.ObservePermissionsWereGranted (Callback);
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
		///     WKWebExtensionContext.PermissionsWereGrantedNotification, (notification) => { Console.WriteLine ("Received the notification PermissionsWereGranted", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification PermissionsWereGranted", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (WKWebExtensionContext.PermissionsWereGrantedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("WKWebExtensionContextPermissionsWereGrantedNotification",  "WebKit")]
		[Advice ("Use WKWebExtensionContext.Notifications.ObservePermissionsWereGranted helper method instead.")]
		public static NSString PermissionsWereGrantedNotification {
			get {
				if (_PermissionsWereGrantedNotification is null)
					_PermissionsWereGrantedNotification = Dlfcn.GetStringConstant (Libraries.WebKit.Handle, "WKWebExtensionContextPermissionsWereGrantedNotification")!;
				return _PermissionsWereGrantedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_FocusedWindow_var = null;
				__mt_WebExtensionController_var = null;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::WebKit.WKWebExtensionContext" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.DeniedPermissionMatchPatternsWereRemovedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.DeniedPermissionMatchPatternsWereRemovedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = WKWebExtensionContext.Notifications.ObserveDeniedPermissionMatchPatternsWereRemoved ((notification) => {
			///   Console.WriteLine ("Observed DeniedPermissionMatchPatternsWereRemovedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDeniedPermissionMatchPatternsWereRemoved (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DeniedPermissionMatchPatternsWereRemovedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.DeniedPermissionMatchPatternsWereRemovedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.DeniedPermissionMatchPatternsWereRemovedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = WKWebExtensionContext.Notifications.ObserveDeniedPermissionMatchPatternsWereRemoved (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DeniedPermissionMatchPatternsWereRemovedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDeniedPermissionMatchPatternsWereRemoved (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DeniedPermissionMatchPatternsWereRemovedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.DeniedPermissionsWereRemovedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.DeniedPermissionsWereRemovedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = WKWebExtensionContext.Notifications.ObserveDeniedPermissionsWereRemoved ((notification) => {
			///   Console.WriteLine ("Observed DeniedPermissionsWereRemovedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDeniedPermissionsWereRemoved (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DeniedPermissionsWereRemovedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.DeniedPermissionsWereRemovedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.DeniedPermissionsWereRemovedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = WKWebExtensionContext.Notifications.ObserveDeniedPermissionsWereRemoved (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DeniedPermissionsWereRemovedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDeniedPermissionsWereRemoved (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DeniedPermissionsWereRemovedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.ErrorsDidUpdateNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.ErrorsDidUpdateNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = WKWebExtensionContext.Notifications.ObserveErrorsDidUpdate ((notification) => {
			///   Console.WriteLine ("Observed ErrorsDidUpdateNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveErrorsDidUpdate (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ErrorsDidUpdateNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.ErrorsDidUpdateNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.ErrorsDidUpdateNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = WKWebExtensionContext.Notifications.ObserveErrorsDidUpdate (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ErrorsDidUpdateNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveErrorsDidUpdate (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ErrorsDidUpdateNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.GrantedPermissionMatchPatternsWereRemovedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.GrantedPermissionMatchPatternsWereRemovedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = WKWebExtensionContext.Notifications.ObserveGrantedPermissionMatchPatternsWereRemoved ((notification) => {
			///   Console.WriteLine ("Observed GrantedPermissionMatchPatternsWereRemovedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveGrantedPermissionMatchPatternsWereRemoved (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (GrantedPermissionMatchPatternsWereRemovedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.GrantedPermissionMatchPatternsWereRemovedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.GrantedPermissionMatchPatternsWereRemovedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = WKWebExtensionContext.Notifications.ObserveGrantedPermissionMatchPatternsWereRemoved (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed GrantedPermissionMatchPatternsWereRemovedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveGrantedPermissionMatchPatternsWereRemoved (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (GrantedPermissionMatchPatternsWereRemovedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.GrantedPermissionsWereRemovedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.GrantedPermissionsWereRemovedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = WKWebExtensionContext.Notifications.ObserveGrantedPermissionsWereRemoved ((notification) => {
			///   Console.WriteLine ("Observed GrantedPermissionsWereRemovedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveGrantedPermissionsWereRemoved (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (GrantedPermissionsWereRemovedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.GrantedPermissionsWereRemovedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.GrantedPermissionsWereRemovedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = WKWebExtensionContext.Notifications.ObserveGrantedPermissionsWereRemoved (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed GrantedPermissionsWereRemovedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveGrantedPermissionsWereRemoved (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (GrantedPermissionsWereRemovedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.NotificationUserInfoKeyMatchPatterns" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.NotificationUserInfoKeyMatchPatterns" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = WKWebExtensionContext.Notifications.ObserveNotificationUserInfoKeyMatchPatterns ((notification) => {
			///   Console.WriteLine ("Observed NotificationUserInfoKeyMatchPatternsNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveNotificationUserInfoKeyMatchPatterns (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (NotificationUserInfoKeyMatchPatterns, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.NotificationUserInfoKeyMatchPatterns" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.NotificationUserInfoKeyMatchPatterns" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = WKWebExtensionContext.Notifications.ObserveNotificationUserInfoKeyMatchPatterns (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed NotificationUserInfoKeyMatchPatternsNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveNotificationUserInfoKeyMatchPatterns (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (NotificationUserInfoKeyMatchPatterns, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.NotificationUserInfoKeyPermissions" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.NotificationUserInfoKeyPermissions" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = WKWebExtensionContext.Notifications.ObserveNotificationUserInfoKeyPermissions ((notification) => {
			///   Console.WriteLine ("Observed NotificationUserInfoKeyPermissionsNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveNotificationUserInfoKeyPermissions (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (NotificationUserInfoKeyPermissions, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.NotificationUserInfoKeyPermissions" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.NotificationUserInfoKeyPermissions" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = WKWebExtensionContext.Notifications.ObserveNotificationUserInfoKeyPermissions (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed NotificationUserInfoKeyPermissionsNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveNotificationUserInfoKeyPermissions (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (NotificationUserInfoKeyPermissions, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.PermissionMatchPatternsWereDeniedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.PermissionMatchPatternsWereDeniedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = WKWebExtensionContext.Notifications.ObservePermissionMatchPatternsWereDenied ((notification) => {
			///   Console.WriteLine ("Observed PermissionMatchPatternsWereDeniedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePermissionMatchPatternsWereDenied (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PermissionMatchPatternsWereDeniedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.PermissionMatchPatternsWereDeniedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.PermissionMatchPatternsWereDeniedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = WKWebExtensionContext.Notifications.ObservePermissionMatchPatternsWereDenied (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed PermissionMatchPatternsWereDeniedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePermissionMatchPatternsWereDenied (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PermissionMatchPatternsWereDeniedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.PermissionMatchPatternsWereGrantedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.PermissionMatchPatternsWereGrantedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = WKWebExtensionContext.Notifications.ObservePermissionMatchPatternsWereGranted ((notification) => {
			///   Console.WriteLine ("Observed PermissionMatchPatternsWereGrantedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePermissionMatchPatternsWereGranted (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PermissionMatchPatternsWereGrantedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.PermissionMatchPatternsWereGrantedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.PermissionMatchPatternsWereGrantedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = WKWebExtensionContext.Notifications.ObservePermissionMatchPatternsWereGranted (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed PermissionMatchPatternsWereGrantedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePermissionMatchPatternsWereGranted (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PermissionMatchPatternsWereGrantedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.PermissionsWereDeniedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.PermissionsWereDeniedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = WKWebExtensionContext.Notifications.ObservePermissionsWereDenied ((notification) => {
			///   Console.WriteLine ("Observed PermissionsWereDeniedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePermissionsWereDenied (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PermissionsWereDeniedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.PermissionsWereDeniedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.PermissionsWereDeniedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = WKWebExtensionContext.Notifications.ObservePermissionsWereDenied (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed PermissionsWereDeniedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePermissionsWereDenied (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PermissionsWereDeniedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.PermissionsWereGrantedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.PermissionsWereGrantedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = WKWebExtensionContext.Notifications.ObservePermissionsWereGranted ((notification) => {
			///   Console.WriteLine ("Observed PermissionsWereGrantedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePermissionsWereGranted (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PermissionsWereGrantedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::WebKit.WKWebExtensionContext.PermissionsWereGrantedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::WebKit.WKWebExtensionContext.PermissionsWereGrantedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = WKWebExtensionContext.Notifications.ObservePermissionsWereGranted (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed PermissionsWereGrantedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePermissionsWereGranted (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PermissionsWereGrantedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class WKWebExtensionContext */
}
