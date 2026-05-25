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
	[Register("NSWorkspace", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSWorkspace : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLForApplicationToOpenContentType_X = "URLForApplicationToOpenContentType:";
		static readonly NativeHandle selURLForApplicationToOpenContentType_XHandle = Selector.GetHandle ("URLForApplicationToOpenContentType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLForApplicationToOpenURL_X = "URLForApplicationToOpenURL:";
		static readonly NativeHandle selURLForApplicationToOpenURL_XHandle = Selector.GetHandle ("URLForApplicationToOpenURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLForApplicationWithBundleIdentifier_X = "URLForApplicationWithBundleIdentifier:";
		static readonly NativeHandle selURLForApplicationWithBundleIdentifier_XHandle = Selector.GetHandle ("URLForApplicationWithBundleIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLsForApplicationsToOpenContentType_X = "URLsForApplicationsToOpenContentType:";
		static readonly NativeHandle selURLsForApplicationsToOpenContentType_XHandle = Selector.GetHandle ("URLsForApplicationsToOpenContentType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLsForApplicationsToOpenURL_X = "URLsForApplicationsToOpenURL:";
		static readonly NativeHandle selURLsForApplicationsToOpenURL_XHandle = Selector.GetHandle ("URLsForApplicationsToOpenURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLsForApplicationsWithBundleIdentifier_X = "URLsForApplicationsWithBundleIdentifier:";
		static readonly NativeHandle selURLsForApplicationsWithBundleIdentifier_XHandle = Selector.GetHandle ("URLsForApplicationsWithBundleIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAbsolutePathForAppBundleWithIdentifier_X = "absolutePathForAppBundleWithIdentifier:";
		static readonly NativeHandle selAbsolutePathForAppBundleWithIdentifier_XHandle = Selector.GetHandle ("absolutePathForAppBundleWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityDisplayShouldDifferentiateWithoutColorX = "accessibilityDisplayShouldDifferentiateWithoutColor";
		static readonly NativeHandle selAccessibilityDisplayShouldDifferentiateWithoutColorXHandle = Selector.GetHandle ("accessibilityDisplayShouldDifferentiateWithoutColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityDisplayShouldIncreaseContrastX = "accessibilityDisplayShouldIncreaseContrast";
		static readonly NativeHandle selAccessibilityDisplayShouldIncreaseContrastXHandle = Selector.GetHandle ("accessibilityDisplayShouldIncreaseContrast");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityDisplayShouldInvertColorsX = "accessibilityDisplayShouldInvertColors";
		static readonly NativeHandle selAccessibilityDisplayShouldInvertColorsXHandle = Selector.GetHandle ("accessibilityDisplayShouldInvertColors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityDisplayShouldReduceMotionX = "accessibilityDisplayShouldReduceMotion";
		static readonly NativeHandle selAccessibilityDisplayShouldReduceMotionXHandle = Selector.GetHandle ("accessibilityDisplayShouldReduceMotion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityDisplayShouldReduceTransparencyX = "accessibilityDisplayShouldReduceTransparency";
		static readonly NativeHandle selAccessibilityDisplayShouldReduceTransparencyXHandle = Selector.GetHandle ("accessibilityDisplayShouldReduceTransparency");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActivateFileViewerSelectingURLs_X = "activateFileViewerSelectingURLs:";
		static readonly NativeHandle selActivateFileViewerSelectingURLs_XHandle = Selector.GetHandle ("activateFileViewerSelectingURLs:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActiveApplicationX = "activeApplication";
		static readonly NativeHandle selActiveApplicationXHandle = Selector.GetHandle ("activeApplication");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDesktopImageOptionsForScreen_X = "desktopImageOptionsForScreen:";
		static readonly NativeHandle selDesktopImageOptionsForScreen_XHandle = Selector.GetHandle ("desktopImageOptionsForScreen:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDesktopImageURLForScreen_X = "desktopImageURLForScreen:";
		static readonly NativeHandle selDesktopImageURLForScreen_XHandle = Selector.GetHandle ("desktopImageURLForScreen:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDuplicateURLs_CompletionHandler_X = "duplicateURLs:completionHandler:";
		static readonly NativeHandle selDuplicateURLs_CompletionHandler_XHandle = Selector.GetHandle ("duplicateURLs:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtendPowerOffBy_X = "extendPowerOffBy:";
		static readonly NativeHandle selExtendPowerOffBy_XHandle = Selector.GetHandle ("extendPowerOffBy:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileLabelColorsX = "fileLabelColors";
		static readonly NativeHandle selFileLabelColorsXHandle = Selector.GetHandle ("fileLabelColors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileLabelsX = "fileLabels";
		static readonly NativeHandle selFileLabelsXHandle = Selector.GetHandle ("fileLabels");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilenameExtension_IsValidForType_X = "filenameExtension:isValidForType:";
		static readonly NativeHandle selFilenameExtension_IsValidForType_XHandle = Selector.GetHandle ("filenameExtension:isValidForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrontmostApplicationX = "frontmostApplication";
		static readonly NativeHandle selFrontmostApplicationXHandle = Selector.GetHandle ("frontmostApplication");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFullPathForApplication_X = "fullPathForApplication:";
		static readonly NativeHandle selFullPathForApplication_XHandle = Selector.GetHandle ("fullPathForApplication:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetFileSystemInfoForPath_IsRemovable_IsWritable_IsUnmountable_Description_Type_X = "getFileSystemInfoForPath:isRemovable:isWritable:isUnmountable:description:type:";
		static readonly NativeHandle selGetFileSystemInfoForPath_IsRemovable_IsWritable_IsUnmountable_Description_Type_XHandle = Selector.GetHandle ("getFileSystemInfoForPath:isRemovable:isWritable:isUnmountable:description:type:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetInfoForFile_Application_Type_X = "getInfoForFile:application:type:";
		static readonly NativeHandle selGetInfoForFile_Application_Type_XHandle = Selector.GetHandle ("getInfoForFile:application:type:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHideOtherApplicationsX = "hideOtherApplications";
		static readonly NativeHandle selHideOtherApplicationsXHandle = Selector.GetHandle ("hideOtherApplications");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIconForContentType_X = "iconForContentType:";
		static readonly NativeHandle selIconForContentType_XHandle = Selector.GetHandle ("iconForContentType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIconForFile_X = "iconForFile:";
		static readonly NativeHandle selIconForFile_XHandle = Selector.GetHandle ("iconForFile:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIconForFileType_X = "iconForFileType:";
		static readonly NativeHandle selIconForFileType_XHandle = Selector.GetHandle ("iconForFileType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIconForFiles_X = "iconForFiles:";
		static readonly NativeHandle selIconForFiles_XHandle = Selector.GetHandle ("iconForFiles:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFilePackageAtPath_X = "isFilePackageAtPath:";
		static readonly NativeHandle selIsFilePackageAtPath_XHandle = Selector.GetHandle ("isFilePackageAtPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSwitchControlEnabledX = "isSwitchControlEnabled";
		static readonly NativeHandle selIsSwitchControlEnabledXHandle = Selector.GetHandle ("isSwitchControlEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsVoiceOverEnabledX = "isVoiceOverEnabled";
		static readonly NativeHandle selIsVoiceOverEnabledXHandle = Selector.GetHandle ("isVoiceOverEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLaunchAppWithBundleIdentifier_Options_AdditionalEventParamDescriptor_LaunchIdentifier_X = "launchAppWithBundleIdentifier:options:additionalEventParamDescriptor:launchIdentifier:";
		static readonly NativeHandle selLaunchAppWithBundleIdentifier_Options_AdditionalEventParamDescriptor_LaunchIdentifier_XHandle = Selector.GetHandle ("launchAppWithBundleIdentifier:options:additionalEventParamDescriptor:launchIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLaunchApplication_X = "launchApplication:";
		static readonly NativeHandle selLaunchApplication_XHandle = Selector.GetHandle ("launchApplication:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLaunchApplication_ShowIcon_Autolaunch_X = "launchApplication:showIcon:autolaunch:";
		static readonly NativeHandle selLaunchApplication_ShowIcon_Autolaunch_XHandle = Selector.GetHandle ("launchApplication:showIcon:autolaunch:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLaunchApplicationAtURL_Options_Configuration_Error_X = "launchApplicationAtURL:options:configuration:error:";
		static readonly NativeHandle selLaunchApplicationAtURL_Options_Configuration_Error_XHandle = Selector.GetHandle ("launchApplicationAtURL:options:configuration:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLaunchedApplicationsX = "launchedApplications";
		static readonly NativeHandle selLaunchedApplicationsXHandle = Selector.GetHandle ("launchedApplications");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedDescriptionForType_X = "localizedDescriptionForType:";
		static readonly NativeHandle selLocalizedDescriptionForType_XHandle = Selector.GetHandle ("localizedDescriptionForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMenuBarOwningApplicationX = "menuBarOwningApplication";
		static readonly NativeHandle selMenuBarOwningApplicationXHandle = Selector.GetHandle ("menuBarOwningApplication");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMountedLocalVolumePathsX = "mountedLocalVolumePaths";
		static readonly NativeHandle selMountedLocalVolumePathsXHandle = Selector.GetHandle ("mountedLocalVolumePaths");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMountedRemovableMediaX = "mountedRemovableMedia";
		static readonly NativeHandle selMountedRemovableMediaXHandle = Selector.GetHandle ("mountedRemovableMedia");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNoteFileSystemChanged_X = "noteFileSystemChanged:";
		static readonly NativeHandle selNoteFileSystemChanged_XHandle = Selector.GetHandle ("noteFileSystemChanged:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNotificationCenterX = "notificationCenter";
		static readonly NativeHandle selNotificationCenterXHandle = Selector.GetHandle ("notificationCenter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenApplicationAtURL_Configuration_CompletionHandler_X = "openApplicationAtURL:configuration:completionHandler:";
		static readonly NativeHandle selOpenApplicationAtURL_Configuration_CompletionHandler_XHandle = Selector.GetHandle ("openApplicationAtURL:configuration:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenFile_X = "openFile:";
		static readonly NativeHandle selOpenFile_XHandle = Selector.GetHandle ("openFile:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenFile_FromImage_At_InView_X = "openFile:fromImage:at:inView:";
		static readonly NativeHandle selOpenFile_FromImage_At_InView_XHandle = Selector.GetHandle ("openFile:fromImage:at:inView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenFile_WithApplication_X = "openFile:withApplication:";
		static readonly NativeHandle selOpenFile_WithApplication_XHandle = Selector.GetHandle ("openFile:withApplication:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenFile_WithApplication_AndDeactivate_X = "openFile:withApplication:andDeactivate:";
		static readonly NativeHandle selOpenFile_WithApplication_AndDeactivate_XHandle = Selector.GetHandle ("openFile:withApplication:andDeactivate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenURL_X = "openURL:";
		static readonly NativeHandle selOpenURL_XHandle = Selector.GetHandle ("openURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenURL_Configuration_CompletionHandler_X = "openURL:configuration:completionHandler:";
		static readonly NativeHandle selOpenURL_Configuration_CompletionHandler_XHandle = Selector.GetHandle ("openURL:configuration:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenURL_Options_Configuration_Error_X = "openURL:options:configuration:error:";
		static readonly NativeHandle selOpenURL_Options_Configuration_Error_XHandle = Selector.GetHandle ("openURL:options:configuration:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenURLs_WithAppBundleIdentifier_Options_AdditionalEventParamDescriptor_LaunchIdentifiers_X = "openURLs:withAppBundleIdentifier:options:additionalEventParamDescriptor:launchIdentifiers:";
		static readonly NativeHandle selOpenURLs_WithAppBundleIdentifier_Options_AdditionalEventParamDescriptor_LaunchIdentifiers_XHandle = Selector.GetHandle ("openURLs:withAppBundleIdentifier:options:additionalEventParamDescriptor:launchIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenURLs_WithApplicationAtURL_Configuration_CompletionHandler_X = "openURLs:withApplicationAtURL:configuration:completionHandler:";
		static readonly NativeHandle selOpenURLs_WithApplicationAtURL_Configuration_CompletionHandler_XHandle = Selector.GetHandle ("openURLs:withApplicationAtURL:configuration:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenURLs_WithApplicationAtURL_Options_Configuration_Error_X = "openURLs:withApplicationAtURL:options:configuration:error:";
		static readonly NativeHandle selOpenURLs_WithApplicationAtURL_Options_Configuration_Error_XHandle = Selector.GetHandle ("openURLs:withApplicationAtURL:options:configuration:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformFileOperation_Source_Destination_Files_Tag_X = "performFileOperation:source:destination:files:tag:";
		static readonly NativeHandle selPerformFileOperation_Source_Destination_Files_Tag_XHandle = Selector.GetHandle ("performFileOperation:source:destination:files:tag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredFilenameExtensionForType_X = "preferredFilenameExtensionForType:";
		static readonly NativeHandle selPreferredFilenameExtensionForType_XHandle = Selector.GetHandle ("preferredFilenameExtensionForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecycleURLs_CompletionHandler_X = "recycleURLs:completionHandler:";
		static readonly NativeHandle selRecycleURLs_CompletionHandler_XHandle = Selector.GetHandle ("recycleURLs:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestAuthorizationOfType_CompletionHandler_X = "requestAuthorizationOfType:completionHandler:";
		static readonly NativeHandle selRequestAuthorizationOfType_CompletionHandler_XHandle = Selector.GetHandle ("requestAuthorizationOfType:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunningApplicationsX = "runningApplications";
		static readonly NativeHandle selRunningApplicationsXHandle = Selector.GetHandle ("runningApplications");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectFile_InFileViewerRootedAtPath_X = "selectFile:inFileViewerRootedAtPath:";
		static readonly NativeHandle selSelectFile_InFileViewerRootedAtPath_XHandle = Selector.GetHandle ("selectFile:inFileViewerRootedAtPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultApplicationAtURL_ToOpenContentType_CompletionHandler_X = "setDefaultApplicationAtURL:toOpenContentType:completionHandler:";
		static readonly NativeHandle selSetDefaultApplicationAtURL_ToOpenContentType_CompletionHandler_XHandle = Selector.GetHandle ("setDefaultApplicationAtURL:toOpenContentType:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultApplicationAtURL_ToOpenContentTypeOfFileAtURL_CompletionHandler_X = "setDefaultApplicationAtURL:toOpenContentTypeOfFileAtURL:completionHandler:";
		static readonly NativeHandle selSetDefaultApplicationAtURL_ToOpenContentTypeOfFileAtURL_CompletionHandler_XHandle = Selector.GetHandle ("setDefaultApplicationAtURL:toOpenContentTypeOfFileAtURL:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultApplicationAtURL_ToOpenFileAtURL_CompletionHandler_X = "setDefaultApplicationAtURL:toOpenFileAtURL:completionHandler:";
		static readonly NativeHandle selSetDefaultApplicationAtURL_ToOpenFileAtURL_CompletionHandler_XHandle = Selector.GetHandle ("setDefaultApplicationAtURL:toOpenFileAtURL:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultApplicationAtURL_ToOpenURLsWithScheme_CompletionHandler_X = "setDefaultApplicationAtURL:toOpenURLsWithScheme:completionHandler:";
		static readonly NativeHandle selSetDefaultApplicationAtURL_ToOpenURLsWithScheme_CompletionHandler_XHandle = Selector.GetHandle ("setDefaultApplicationAtURL:toOpenURLsWithScheme:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDesktopImageURL_ForScreen_Options_Error_X = "setDesktopImageURL:forScreen:options:error:";
		static readonly NativeHandle selSetDesktopImageURL_ForScreen_Options_Error_XHandle = Selector.GetHandle ("setDesktopImageURL:forScreen:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIcon_ForFile_Options_X = "setIcon:forFile:options:";
		static readonly NativeHandle selSetIcon_ForFile_Options_XHandle = Selector.GetHandle ("setIcon:forFile:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedWorkspaceX = "sharedWorkspace";
		static readonly NativeHandle selSharedWorkspaceXHandle = Selector.GetHandle ("sharedWorkspace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowSearchResultsForQueryString_X = "showSearchResultsForQueryString:";
		static readonly NativeHandle selShowSearchResultsForQueryString_XHandle = Selector.GetHandle ("showSearchResultsForQueryString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selType_ConformsToType_X = "type:conformsToType:";
		static readonly NativeHandle selType_ConformsToType_XHandle = Selector.GetHandle ("type:conformsToType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTypeOfFile_Error_X = "typeOfFile:error:";
		static readonly NativeHandle selTypeOfFile_Error_XHandle = Selector.GetHandle ("typeOfFile:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnmountAndEjectDeviceAtPath_X = "unmountAndEjectDeviceAtPath:";
		static readonly NativeHandle selUnmountAndEjectDeviceAtPath_XHandle = Selector.GetHandle ("unmountAndEjectDeviceAtPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnmountAndEjectDeviceAtURL_Error_X = "unmountAndEjectDeviceAtURL:error:";
		static readonly NativeHandle selUnmountAndEjectDeviceAtURL_Error_XHandle = Selector.GetHandle ("unmountAndEjectDeviceAtURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSWorkspace");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSWorkspace" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSWorkspace () : base (NSObjectFlag.Empty)
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
		protected NSWorkspace (NSObjectFlag t) : base (t)
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
		protected internal NSWorkspace (NativeHandle handle) : base (handle)
		{
		}

		[Export ("absolutePathForAppBundleWithIdentifier:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("macos10.15", "Use the 'UrlForApplication' method instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? AbsolutePathForAppBundle (string bundleIdentifier)
		{
			if (bundleIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (bundleIdentifier));
			var nsbundleIdentifier = CFString.CreateNative (bundleIdentifier);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAbsolutePathForAppBundleWithIdentifier_XHandle, nsbundleIdentifier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAbsolutePathForAppBundleWithIdentifier_XHandle, nsbundleIdentifier), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsbundleIdentifier);
			return ret!;
		}
		[Export ("activateFileViewerSelectingURLs:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ActivateFileViewer (NSUrl[] fileUrls)
		{
			if (fileUrls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileUrls));
			using var nsa_fileUrls = NSArray.FromNSObjects (fileUrls);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selActivateFileViewerSelectingURLs_XHandle, nsa_fileUrls.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selActivateFileViewerSelectingURLs_XHandle, nsa_fileUrls.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("desktopImageOptionsForScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary DesktopImageOptions (NSScreen screen)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var screen__handle__ = screen!.GetNonNullHandle (nameof (screen));
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDesktopImageOptionsForScreen_XHandle, screen__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDesktopImageOptionsForScreen_XHandle, screen__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (screen);
			return ret!;
		}
		[Export ("desktopImageURLForScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl DesktopImageUrl (NSScreen screen)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var screen__handle__ = screen!.GetNonNullHandle (nameof (screen));
			NSUrl? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDesktopImageURLForScreen_XHandle, screen__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDesktopImageURLForScreen_XHandle, screen__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (screen);
			return ret!;
		}
		[Export ("duplicateURLs:completionHandler:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DuplicateUrls (NSArray urls, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWorkspaceUrlHandler))]NSWorkspaceUrlHandler completionHandler)
		{
			var urls__handle__ = urls!.GetNonNullHandle (nameof (urls));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSWorkspaceUrlHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDuplicateURLs_CompletionHandler_XHandle, urls__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDuplicateURLs_CompletionHandler_XHandle, urls__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (urls);
		}
		[Export ("extendPowerOffBy:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ExtendPowerOffBy (nint requested)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selExtendPowerOffBy_XHandle, requested);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, selExtendPowerOffBy_XHandle, requested);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("fullPathForApplication:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("macos10.15", "Use the 'UrlForApplication' method instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? FullPathForApplication (string appName)
		{
			if (appName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (appName));
			var nsappName = CFString.CreateNative (appName);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selFullPathForApplication_XHandle, nsappName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selFullPathForApplication_XHandle, nsappName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsappName);
			return ret!;
		}
		[Export ("getFileSystemInfoForPath:isRemovable:isWritable:isUnmountable:description:type:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool GetFileSystemInfo (string fullPath, out bool removableFlag, out bool writableFlag, out bool unmountableFlag, out string description, out string fileSystemType)
		{
			if (fullPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fullPath));
			fixed (bool* removableFlag__pointer = &removableFlag) {
			fixed (bool* writableFlag__pointer = &writableFlag) {
			fixed (bool* unmountableFlag__pointer = &unmountableFlag) {
			NativeHandle descriptionValue = IntPtr.Zero;
			NativeHandle fileSystemTypeValue = IntPtr.Zero;
			var nsfullPath = CFString.CreateNative (fullPath);
			removableFlag = default;
			writableFlag = default;
			unmountableFlag = default;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_out_Boolean_out_Boolean_out_Boolean_ref_NativeHandle_ref_NativeHandle (this.Handle, selGetFileSystemInfoForPath_IsRemovable_IsWritable_IsUnmountable_Description_Type_XHandle, nsfullPath, (byte*) removableFlag__pointer, (byte*) writableFlag__pointer, (byte*) unmountableFlag__pointer, &descriptionValue, &fileSystemTypeValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_out_Boolean_out_Boolean_out_Boolean_ref_NativeHandle_ref_NativeHandle (&__objc_super__, selGetFileSystemInfoForPath_IsRemovable_IsWritable_IsUnmountable_Description_Type_XHandle, nsfullPath, (byte*) removableFlag__pointer, (byte*) writableFlag__pointer, (byte*) unmountableFlag__pointer, &descriptionValue, &fileSystemTypeValue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfullPath);
			description = CFString.FromHandle (descriptionValue)!;
			fileSystemType = CFString.FromHandle (fileSystemTypeValue)!;
			return ret != 0;
			}
			}
			}
		}
		[Export ("iconForContentType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSImage GetIcon (global::UniformTypeIdentifiers.UTType contentType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var contentType__handle__ = contentType!.GetNonNullHandle (nameof (contentType));
			NSImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selIconForContentType_XHandle, contentType__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selIconForContentType_XHandle, contentType__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contentType);
			return ret!;
		}
		[Export ("getInfoForFile:application:type:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("macos12.0", "Use 'NSWorkspace.UrlForApplication' or 'NSUrl.GetResourceValue' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool GetInfo (string fullPath, out string appName, out string fileType)
		{
			if (fullPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fullPath));
			NativeHandle appNameValue = IntPtr.Zero;
			NativeHandle fileTypeValue = IntPtr.Zero;
			var nsfullPath = CFString.CreateNative (fullPath);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle_ref_NativeHandle (this.Handle, selGetInfoForFile_Application_Type_XHandle, nsfullPath, &appNameValue, &fileTypeValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle_ref_NativeHandle (&__objc_super__, selGetInfoForFile_Application_Type_XHandle, nsfullPath, &appNameValue, &fileTypeValue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfullPath);
			appName = CFString.FromHandle (appNameValue)!;
			fileType = CFString.FromHandle (fileTypeValue)!;
			return ret != 0;
		}
		[Export ("URLForApplicationToOpenContentType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? GetUrlForApplicationToOpenContentType (global::UniformTypeIdentifiers.UTType contentType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var contentType__handle__ = contentType!.GetNonNullHandle (nameof (contentType));
			NSUrl? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selURLForApplicationToOpenContentType_XHandle, contentType__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selURLForApplicationToOpenContentType_XHandle, contentType__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contentType);
			return ret!;
		}
		[Export ("URLsForApplicationsWithBundleIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl[] GetUrlsForApplications (string bundleIdentifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (bundleIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (bundleIdentifier));
			var nsbundleIdentifier = CFString.CreateNative (bundleIdentifier);
			NSUrl[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selURLsForApplicationsWithBundleIdentifier_XHandle, nsbundleIdentifier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selURLsForApplicationsWithBundleIdentifier_XHandle, nsbundleIdentifier), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsbundleIdentifier);
			return ret!;
		}
		[Export ("URLsForApplicationsToOpenURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl[] GetUrlsForApplications (NSUrl url)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NSUrl[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selURLsForApplicationsToOpenURL_XHandle, url__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selURLsForApplicationsToOpenURL_XHandle, url__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("URLsForApplicationsToOpenContentType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl[] GetUrlsForApplicationsToOpenContentType (global::UniformTypeIdentifiers.UTType contentType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var contentType__handle__ = contentType!.GetNonNullHandle (nameof (contentType));
			NSUrl[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selURLsForApplicationsToOpenContentType_XHandle, contentType__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selURLsForApplicationsToOpenContentType_XHandle, contentType__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contentType);
			return ret!;
		}
		[Export ("hideOtherApplications")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HideOtherApplications ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selHideOtherApplicationsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selHideOtherApplicationsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("iconForFile:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSImage IconForFile (string fullPath)
		{
			if (fullPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fullPath));
			var nsfullPath = CFString.CreateNative (fullPath);
			NSImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selIconForFile_XHandle, nsfullPath), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selIconForFile_XHandle, nsfullPath), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfullPath);
			return ret!;
		}
		[Export ("iconForFileType:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("macos12.0", "Use 'NSWorkspace.GetIcon' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSImage IconForFileType (nint fileTypeOrTypeCode)
		{
			NSImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selIconForFileType_XHandle, fileTypeOrTypeCode), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selIconForFileType_XHandle, fileTypeOrTypeCode), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("iconForFiles:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSImage IconForFiles (string[] fullPaths)
		{
			if (fullPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fullPaths));
			using var nsa_fullPaths = NSArray.FromStrings (fullPaths);
			NSImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selIconForFiles_XHandle, nsa_fullPaths.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selIconForFiles_XHandle, nsa_fullPaths.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("isFilePackageAtPath:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsFilePackage (string fullPath)
		{
			if (fullPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fullPath));
			var nsfullPath = CFString.CreateNative (fullPath);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsFilePackageAtPath_XHandle, nsfullPath);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsFilePackageAtPath_XHandle, nsfullPath);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfullPath);
			return ret != 0;
		}
		[Export ("filenameExtension:isValidForType:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("macos12.0", "Compare against 'UTType.GetTypes' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsFilenameExtensionValid (string filenameExtension, string typeName)
		{
			if (filenameExtension is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filenameExtension));
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			var nsfilenameExtension = CFString.CreateNative (filenameExtension);
			var nstypeName = CFString.CreateNative (typeName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFilenameExtension_IsValidForType_XHandle, nsfilenameExtension, nstypeName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFilenameExtension_IsValidForType_XHandle, nsfilenameExtension, nstypeName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfilenameExtension);
			CFString.ReleaseNative (nstypeName);
			return ret != 0;
		}
		[Export ("launchAppWithBundleIdentifier:options:additionalEventParamDescriptor:launchIdentifier:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("macos10.15")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LaunchApp (string bundleIdentifier, NSWorkspaceLaunchOptions options, NSAppleEventDescriptor descriptor, nint identifier)
		{
			if (bundleIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (bundleIdentifier));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsbundleIdentifier = CFString.CreateNative (bundleIdentifier);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_IntPtr (this.Handle, selLaunchAppWithBundleIdentifier_Options_AdditionalEventParamDescriptor_LaunchIdentifier_XHandle, nsbundleIdentifier, (UIntPtr) (ulong) options, descriptor__handle__, identifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle_IntPtr (&__objc_super__, selLaunchAppWithBundleIdentifier_Options_AdditionalEventParamDescriptor_LaunchIdentifier_XHandle, nsbundleIdentifier, (UIntPtr) (ulong) options, descriptor__handle__, identifier);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsbundleIdentifier);
			return ret != 0;
		}
		[Export ("launchApplication:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("macos10.15", "Use 'OpenApplication' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LaunchApplication (string appName)
		{
			if (appName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (appName));
			var nsappName = CFString.CreateNative (appName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selLaunchApplication_XHandle, nsappName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selLaunchApplication_XHandle, nsappName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsappName);
			return ret != 0;
		}
		[Export ("launchApplicationAtURL:options:configuration:error:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("macos10.15", "Use 'OpenApplication' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSRunningApplication LaunchApplication (NSUrl url, NSWorkspaceLaunchOptions options, NSDictionary configuration, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			NativeHandle errorValue = IntPtr.Zero;
			NSRunningApplication? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSRunningApplication> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_ref_NativeHandle (this.Handle, selLaunchApplicationAtURL_Options_Configuration_Error_XHandle, url__handle__, (UIntPtr) (ulong) options, configuration__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSRunningApplication> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle_ref_NativeHandle (&__objc_super__, selLaunchApplicationAtURL_Options_Configuration_Error_XHandle, url__handle__, (UIntPtr) (ulong) options, configuration__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (configuration);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("launchApplication:showIcon:autolaunch:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("macos10.15", "Use 'OpenApplication' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LaunchApplication (string appName, bool showIcon, bool autolaunch)
		{
			if (appName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (appName));
			var nsappName = CFString.CreateNative (appName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_bool_bool (this.Handle, selLaunchApplication_ShowIcon_Autolaunch_XHandle, nsappName, showIcon ? (byte) 1 : (byte) 0, autolaunch ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_bool_bool (&__objc_super__, selLaunchApplication_ShowIcon_Autolaunch_XHandle, nsappName, showIcon ? (byte) 1 : (byte) 0, autolaunch ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsappName);
			return ret != 0;
		}
		[Export ("localizedDescriptionForType:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("macos12.0", "Use 'UTType.LocalizedDescription' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string LocalizedDescription (string typeName)
		{
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			var nstypeName = CFString.CreateNative (typeName);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selLocalizedDescriptionForType_XHandle, nstypeName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selLocalizedDescriptionForType_XHandle, nstypeName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeName);
			return ret!;
		}
		[Export ("noteFileSystemChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NoteFileSystemChanged (string path)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selNoteFileSystemChanged_XHandle, nspath);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selNoteFileSystemChanged_XHandle, nspath);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
		}
		[Export ("openApplicationAtURL:configuration:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void OpenApplication (NSUrl applicationUrl, NSWorkspaceOpenConfiguration configuration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V28))]global::System.Action<NSRunningApplication, NSError>? completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var applicationUrl__handle__ = applicationUrl!.GetNonNullHandle (nameof (applicationUrl));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			using var block_completionHandler = Trampolines.SDActionArity2V28.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selOpenApplicationAtURL_Configuration_CompletionHandler_XHandle, applicationUrl__handle__, configuration__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selOpenApplicationAtURL_Configuration_CompletionHandler_XHandle, applicationUrl__handle__, configuration__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (applicationUrl);
			GC.KeepAlive (configuration);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSRunningApplication> OpenApplicationAsync (NSUrl applicationUrl, NSWorkspaceOpenConfiguration configuration)
		{
			var tcs = new TaskCompletionSource<NSRunningApplication> ();
			OpenApplication(applicationUrl, configuration, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("openFile:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("macos10.15", "Use the 'OpenUrl' method instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OpenFile (string fullPath)
		{
			if (fullPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fullPath));
			var nsfullPath = CFString.CreateNative (fullPath);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selOpenFile_XHandle, nsfullPath);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selOpenFile_XHandle, nsfullPath);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfullPath);
			return ret != 0;
		}
		[Export ("openFile:withApplication:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("macos10.15")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OpenFile (string fullPath, string? appName)
		{
			if (fullPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fullPath));
			var nsfullPath = CFString.CreateNative (fullPath);
			var nsappName = CFString.CreateNative (appName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selOpenFile_WithApplication_XHandle, nsfullPath, nsappName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selOpenFile_WithApplication_XHandle, nsfullPath, nsappName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfullPath);
			CFString.ReleaseNative (nsappName);
			return ret != 0;
		}
		[Export ("openFile:withApplication:andDeactivate:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("macos10.15")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OpenFile (string fullPath, string? appName, bool deactivate)
		{
			if (fullPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fullPath));
			var nsfullPath = CFString.CreateNative (fullPath);
			var nsappName = CFString.CreateNative (appName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_bool (this.Handle, selOpenFile_WithApplication_AndDeactivate_XHandle, nsfullPath, nsappName, deactivate ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_bool (&__objc_super__, selOpenFile_WithApplication_AndDeactivate_XHandle, nsfullPath, nsappName, deactivate ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfullPath);
			CFString.ReleaseNative (nsappName);
			return ret != 0;
		}
		[Export ("openFile:fromImage:at:inView:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("macos10.11", "Use 'NSWorkspace.OpenUrl' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OpenFile (string fullPath, NSImage anImage, CGPoint point, NSView aView)
		{
			if (fullPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fullPath));
			var anImage__handle__ = anImage!.GetNonNullHandle (nameof (anImage));
			var aView__handle__ = aView!.GetNonNullHandle (nameof (aView));
			var nsfullPath = CFString.CreateNative (fullPath);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_CGPoint_NativeHandle (this.Handle, selOpenFile_FromImage_At_InView_XHandle, nsfullPath, anImage__handle__, point, aView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_CGPoint_NativeHandle (&__objc_super__, selOpenFile_FromImage_At_InView_XHandle, nsfullPath, anImage__handle__, point, aView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anImage);
			GC.KeepAlive (aView);
			CFString.ReleaseNative (nsfullPath);
			return ret != 0;
		}
		[Export ("openURL:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OpenUrl (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selOpenURL_XHandle, url__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selOpenURL_XHandle, url__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			return ret != 0;
		}
		[Export ("openURL:options:configuration:error:")]
		[ObsoletedOSPlatform ("macos10.15")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSRunningApplication? OpenUrl (NSUrl url, NSWorkspaceLaunchOptions options, NSDictionary configuration, out NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			NativeHandle errorValue = IntPtr.Zero;
			NSRunningApplication? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSRunningApplication> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_ref_NativeHandle (this.Handle, selOpenURL_Options_Configuration_Error_XHandle, url__handle__, (UIntPtr) (ulong) options, configuration__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSRunningApplication> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle_ref_NativeHandle (&__objc_super__, selOpenURL_Options_Configuration_Error_XHandle, url__handle__, (UIntPtr) (ulong) options, configuration__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (configuration);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("openURL:configuration:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void OpenUrl (NSUrl url, NSWorkspaceOpenConfiguration configuration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V28))]global::System.Action<NSRunningApplication, NSError>? completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			using var block_completionHandler = Trampolines.SDActionArity2V28.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selOpenURL_Configuration_CompletionHandler_XHandle, url__handle__, configuration__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selOpenURL_Configuration_CompletionHandler_XHandle, url__handle__, configuration__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (configuration);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSRunningApplication> OpenUrlAsync (NSUrl url, NSWorkspaceOpenConfiguration configuration)
		{
			var tcs = new TaskCompletionSource<NSRunningApplication> ();
			OpenUrl(url, configuration, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("openURLs:withApplicationAtURL:options:configuration:error:")]
		[ObsoletedOSPlatform ("macos10.15")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSRunningApplication? OpenUrls (NSUrl[] urls, NSUrl applicationURL, NSWorkspaceLaunchOptions options, NSDictionary configuration, out NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (urls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urls));
			var applicationURL__handle__ = applicationURL!.GetNonNullHandle (nameof (applicationURL));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_urls = NSArray.FromNSObjects (urls);
			NSRunningApplication? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSRunningApplication> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle_ref_NativeHandle (this.Handle, selOpenURLs_WithApplicationAtURL_Options_Configuration_Error_XHandle, nsa_urls.Handle, applicationURL__handle__, (UIntPtr) (ulong) options, configuration__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSRunningApplication> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_NativeHandle_ref_NativeHandle (&__objc_super__, selOpenURLs_WithApplicationAtURL_Options_Configuration_Error_XHandle, nsa_urls.Handle, applicationURL__handle__, (UIntPtr) (ulong) options, configuration__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (applicationURL);
			GC.KeepAlive (configuration);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("openURLs:withApplicationAtURL:configuration:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void OpenUrls (NSUrl[] urls, NSUrl applicationUrl, NSWorkspaceOpenConfiguration configuration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V28))]global::System.Action<NSRunningApplication, NSError>? completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (urls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urls));
			var applicationUrl__handle__ = applicationUrl!.GetNonNullHandle (nameof (applicationUrl));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			using var nsa_urls = NSArray.FromNSObjects (urls);
			using var block_completionHandler = Trampolines.SDActionArity2V28.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selOpenURLs_WithApplicationAtURL_Configuration_CompletionHandler_XHandle, nsa_urls.Handle, applicationUrl__handle__, configuration__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selOpenURLs_WithApplicationAtURL_Configuration_CompletionHandler_XHandle, nsa_urls.Handle, applicationUrl__handle__, configuration__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (applicationUrl);
			GC.KeepAlive (configuration);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSRunningApplication> OpenUrlsAsync (NSUrl[] urls, NSUrl applicationUrl, NSWorkspaceOpenConfiguration configuration)
		{
			var tcs = new TaskCompletionSource<NSRunningApplication> ();
			OpenUrls(urls, applicationUrl, configuration, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("performFileOperation:source:destination:files:tag:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("macos10.11")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool PerformFileOperation (NSString workspaceOperation, string source, string destination, string[] files, out nint tag)
		{
			var workspaceOperation__handle__ = workspaceOperation!.GetNonNullHandle (nameof (workspaceOperation));
			if (source is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (source));
			if (destination is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (destination));
			if (files is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (files));
			fixed (nint* tag__pointer = &tag) {
			var nssource = CFString.CreateNative (source);
			var nsdestination = CFString.CreateNative (destination);
			using var nsa_files = NSArray.FromStrings (files);
			tag = default;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_out_IntPtr (this.Handle, selPerformFileOperation_Source_Destination_Files_Tag_XHandle, workspaceOperation__handle__, nssource, nsdestination, nsa_files.Handle, tag__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_out_IntPtr (&__objc_super__, selPerformFileOperation_Source_Destination_Files_Tag_XHandle, workspaceOperation__handle__, nssource, nsdestination, nsa_files.Handle, tag__pointer);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (workspaceOperation);
			CFString.ReleaseNative (nssource);
			CFString.ReleaseNative (nsdestination);
			return ret != 0;
			}
		}
		[Export ("preferredFilenameExtensionForType:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("macos12.0", "Use 'UTType.PreferredFilenameExtension' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string PreferredFilenameExtension (string typeName)
		{
			if (typeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeName));
			var nstypeName = CFString.CreateNative (typeName);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPreferredFilenameExtensionForType_XHandle, nstypeName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPreferredFilenameExtensionForType_XHandle, nstypeName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeName);
			return ret!;
		}
		[Export ("recycleURLs:completionHandler:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RecycleUrls (NSArray urls, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWorkspaceUrlHandler))]NSWorkspaceUrlHandler completionHandler)
		{
			var urls__handle__ = urls!.GetNonNullHandle (nameof (urls));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSWorkspaceUrlHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRecycleURLs_CompletionHandler_XHandle, urls__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRecycleURLs_CompletionHandler_XHandle, urls__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (urls);
		}
		[Export ("requestAuthorizationOfType:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestAuthorization (NSWorkspaceAuthorizationType type, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V29))]global::System.Action<NSWorkspaceAuthorization, NSError> completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V29.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, selRequestAuthorizationOfType_CompletionHandler_XHandle, (IntPtr) (long) type, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selRequestAuthorizationOfType_CompletionHandler_XHandle, (IntPtr) (long) type, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("selectFile:inFileViewerRootedAtPath:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SelectFile (string fullPath, string rootFullPath)
		{
			if (fullPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fullPath));
			if (rootFullPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (rootFullPath));
			var nsfullPath = CFString.CreateNative (fullPath);
			var nsrootFullPath = CFString.CreateNative (rootFullPath);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSelectFile_InFileViewerRootedAtPath_XHandle, nsfullPath, nsrootFullPath);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSelectFile_InFileViewerRootedAtPath_XHandle, nsfullPath, nsrootFullPath);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfullPath);
			CFString.ReleaseNative (nsrootFullPath);
			return ret != 0;
		}
		[Export ("setDefaultApplicationAtURL:toOpenContentTypeOfFileAtURL:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetDefaultApplicationToOpenContentType (NSUrl applicationUrl, NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var applicationUrl__handle__ = applicationUrl!.GetNonNullHandle (nameof (applicationUrl));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selSetDefaultApplicationAtURL_ToOpenContentTypeOfFileAtURL_CompletionHandler_XHandle, applicationUrl__handle__, url__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selSetDefaultApplicationAtURL_ToOpenContentTypeOfFileAtURL_CompletionHandler_XHandle, applicationUrl__handle__, url__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (applicationUrl);
			GC.KeepAlive (url);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetDefaultApplicationToOpenContentTypeAsync (NSUrl applicationUrl, NSUrl url)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetDefaultApplicationToOpenContentType(applicationUrl, url, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("setDefaultApplicationAtURL:toOpenContentType:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetDefaultApplicationToOpenContentType (NSUrl applicationUrl, global::UniformTypeIdentifiers.UTType contentType, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var applicationUrl__handle__ = applicationUrl!.GetNonNullHandle (nameof (applicationUrl));
			var contentType__handle__ = contentType!.GetNonNullHandle (nameof (contentType));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selSetDefaultApplicationAtURL_ToOpenContentType_CompletionHandler_XHandle, applicationUrl__handle__, contentType__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selSetDefaultApplicationAtURL_ToOpenContentType_CompletionHandler_XHandle, applicationUrl__handle__, contentType__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (applicationUrl);
			GC.KeepAlive (contentType);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetDefaultApplicationToOpenContentTypeAsync (NSUrl applicationUrl, global::UniformTypeIdentifiers.UTType contentType)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetDefaultApplicationToOpenContentType(applicationUrl, contentType, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("setDefaultApplicationAtURL:toOpenFileAtURL:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetDefaultApplicationToOpenFile (NSUrl applicationUrl, NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var applicationUrl__handle__ = applicationUrl!.GetNonNullHandle (nameof (applicationUrl));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selSetDefaultApplicationAtURL_ToOpenFileAtURL_CompletionHandler_XHandle, applicationUrl__handle__, url__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selSetDefaultApplicationAtURL_ToOpenFileAtURL_CompletionHandler_XHandle, applicationUrl__handle__, url__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (applicationUrl);
			GC.KeepAlive (url);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetDefaultApplicationToOpenFileAsync (NSUrl applicationUrl, NSUrl url)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetDefaultApplicationToOpenFile(applicationUrl, url, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("setDefaultApplicationAtURL:toOpenURLsWithScheme:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetDefaultApplicationToOpenUrls (NSUrl applicationUrl, string urlScheme, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var applicationUrl__handle__ = applicationUrl!.GetNonNullHandle (nameof (applicationUrl));
			if (urlScheme is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urlScheme));
			var nsurlScheme = CFString.CreateNative (urlScheme);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selSetDefaultApplicationAtURL_ToOpenURLsWithScheme_CompletionHandler_XHandle, applicationUrl__handle__, nsurlScheme, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selSetDefaultApplicationAtURL_ToOpenURLsWithScheme_CompletionHandler_XHandle, applicationUrl__handle__, nsurlScheme, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (applicationUrl);
			CFString.ReleaseNative (nsurlScheme);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetDefaultApplicationToOpenUrlsAsync (NSUrl applicationUrl, string urlScheme)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetDefaultApplicationToOpenUrls(applicationUrl, urlScheme, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("setDesktopImageURL:forScreen:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SetDesktopImageUrl (NSUrl url, NSScreen screen, NSDictionary options, NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var screen__handle__ = screen!.GetNonNullHandle (nameof (screen));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selSetDesktopImageURL_ForScreen_Options_Error_XHandle, url__handle__, screen__handle__, options__handle__, error__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selSetDesktopImageURL_ForScreen_Options_Error_XHandle, url__handle__, screen__handle__, options__handle__, error__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (screen);
			GC.KeepAlive (options);
			GC.KeepAlive (error);
			return ret != 0;
		}
		[Export ("setIcon:forFile:options:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SetIconforFile (NSImage image, string fullPath, NSWorkspaceIconCreationOptions options)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (fullPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fullPath));
			var nsfullPath = CFString.CreateNative (fullPath);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, selSetIcon_ForFile_Options_XHandle, image__handle__, nsfullPath, (UIntPtr) (ulong) options);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr (&__objc_super__, selSetIcon_ForFile_Options_XHandle, image__handle__, nsfullPath, (UIntPtr) (ulong) options);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			CFString.ReleaseNative (nsfullPath);
			return ret != 0;
		}
		[Export ("showSearchResultsForQueryString:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowSearchResults (string queryString)
		{
			if (queryString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (queryString));
			var nsqueryString = CFString.CreateNative (queryString);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selShowSearchResultsForQueryString_XHandle, nsqueryString);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selShowSearchResultsForQueryString_XHandle, nsqueryString);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsqueryString);
			return ret != 0;
		}
		[Export ("type:conformsToType:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("macos12.0", "Use 'UTType.ConformsToType' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TypeConformsTo (string firstTypeName, string secondTypeName)
		{
			if (firstTypeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (firstTypeName));
			if (secondTypeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (secondTypeName));
			var nsfirstTypeName = CFString.CreateNative (firstTypeName);
			var nssecondTypeName = CFString.CreateNative (secondTypeName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selType_ConformsToType_XHandle, nsfirstTypeName, nssecondTypeName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selType_ConformsToType_XHandle, nsfirstTypeName, nssecondTypeName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfirstTypeName);
			CFString.ReleaseNative (nssecondTypeName);
			return ret != 0;
		}
		[Export ("typeOfFile:error:")]
		[ThreadSafe]
		[ObsoletedOSPlatform ("macos12.0", "Use 'NSUrl.GetResourceValue' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual string TypeOfFile (string absoluteFilePath, out NSError outError)
		{
			if (absoluteFilePath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (absoluteFilePath));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nsabsoluteFilePath = CFString.CreateNative (absoluteFilePath);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selTypeOfFile_Error_XHandle, nsabsoluteFilePath, &outErrorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selTypeOfFile_Error_XHandle, nsabsoluteFilePath, &outErrorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsabsoluteFilePath);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[Export ("unmountAndEjectDeviceAtPath:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UnmountAndEjectDevice (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selUnmountAndEjectDeviceAtPath_XHandle, nspath);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selUnmountAndEjectDeviceAtPath_XHandle, nspath);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			return ret != 0;
		}
		[Export ("unmountAndEjectDeviceAtURL:error:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool UnmountAndEjectDevice (NSUrl url, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selUnmountAndEjectDeviceAtURL_Error_XHandle, url__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selUnmountAndEjectDeviceAtURL_Error_XHandle, url__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("URLForApplicationWithBundleIdentifier:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl UrlForApplication (string bundleIdentifier)
		{
			if (bundleIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (bundleIdentifier));
			var nsbundleIdentifier = CFString.CreateNative (bundleIdentifier);
			NSUrl? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selURLForApplicationWithBundleIdentifier_XHandle, nsbundleIdentifier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selURLForApplicationWithBundleIdentifier_XHandle, nsbundleIdentifier), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsbundleIdentifier);
			return ret!;
		}
		[Export ("URLForApplicationToOpenURL:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl UrlForApplication (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NSUrl? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selURLForApplicationToOpenURL_XHandle, url__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selURLForApplicationToOpenURL_XHandle, url__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("openURLs:withAppBundleIdentifier:options:additionalEventParamDescriptor:launchIdentifiers:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual bool _OpenUrls (NSUrl[] urls, string bundleIdentifier, NSWorkspaceLaunchOptions options, NSAppleEventDescriptor descriptor, string[]? identifiers)
		{
			if (urls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urls));
			if (bundleIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (bundleIdentifier));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			using var nsa_urls = NSArray.FromNSObjects (urls);
			var nsbundleIdentifier = CFString.CreateNative (bundleIdentifier);
			using var nsa_identifiers = NSArray.FromNullableStrings (identifiers);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle_NativeHandle (this.Handle, selOpenURLs_WithAppBundleIdentifier_Options_AdditionalEventParamDescriptor_LaunchIdentifiers_XHandle, nsa_urls.Handle, nsbundleIdentifier, (UIntPtr) (ulong) options, descriptor__handle__, nsa_identifiers.GetHandle ());
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_NativeHandle_NativeHandle (&__objc_super__, selOpenURLs_WithAppBundleIdentifier_Options_AdditionalEventParamDescriptor_LaunchIdentifiers_XHandle, nsa_urls.Handle, nsbundleIdentifier, (UIntPtr) (ulong) options, descriptor__handle__, nsa_identifiers.GetHandle ());
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsbundleIdentifier);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityDisplayShouldDifferentiateWithoutColor {
			[Export ("accessibilityDisplayShouldDifferentiateWithoutColor")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAccessibilityDisplayShouldDifferentiateWithoutColorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAccessibilityDisplayShouldDifferentiateWithoutColorXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityDisplayShouldIncreaseContrast {
			[Export ("accessibilityDisplayShouldIncreaseContrast")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAccessibilityDisplayShouldIncreaseContrastXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAccessibilityDisplayShouldIncreaseContrastXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityDisplayShouldInvertColors {
			[Export ("accessibilityDisplayShouldInvertColors")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAccessibilityDisplayShouldInvertColorsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAccessibilityDisplayShouldInvertColorsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityDisplayShouldReduceMotion {
			[Export ("accessibilityDisplayShouldReduceMotion")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAccessibilityDisplayShouldReduceMotionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAccessibilityDisplayShouldReduceMotionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityDisplayShouldReduceTransparency {
			[Export ("accessibilityDisplayShouldReduceTransparency")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAccessibilityDisplayShouldReduceTransparencyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAccessibilityDisplayShouldReduceTransparencyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.11", "Use 'NSWorkspace.FrontmostApplication' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSDictionary ActiveApplication {
			[Export ("activeApplication")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selActiveApplicationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selActiveApplicationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ThreadSafe]
		public virtual NSColor[] FileLabelColors {
			[Export ("fileLabelColors")]
			get {
				NSColor[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSColor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFileLabelColorsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSColor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFileLabelColorsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ThreadSafe]
		public virtual string[] FileLabels {
			[Export ("fileLabels")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFileLabelsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFileLabelsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRunningApplication FrontmostApplication {
			[Export ("frontmostApplication")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRunningApplication? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSRunningApplication> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFrontmostApplicationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSRunningApplication> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFrontmostApplicationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.7", "Use 'NSWorkspace.RunningApplications' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSDictionary[] LaunchedApplications {
			[Export ("launchedApplications")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDictionary[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSDictionary>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLaunchedApplicationsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSDictionary>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLaunchedApplicationsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRunningApplication MenuBarOwningApplication {
			[Export ("menuBarOwningApplication")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRunningApplication? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSRunningApplication> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMenuBarOwningApplicationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSRunningApplication> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMenuBarOwningApplicationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.11")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string[] MountedLocalVolumePaths {
			[Export ("mountedLocalVolumePaths")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMountedLocalVolumePathsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMountedLocalVolumePathsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.11")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string[] MountedRemovableMedia {
			[Export ("mountedRemovableMedia")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMountedRemovableMediaXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMountedRemovableMediaXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ThreadSafe]
		public virtual NSNotificationCenter NotificationCenter {
			[Export ("notificationCenter")]
			get {
				NSNotificationCenter? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNotificationCenter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNotificationCenterXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSNotificationCenter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNotificationCenterXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ThreadSafe]
		public virtual NSRunningApplication[] RunningApplications {
			[Export ("runningApplications")]
			get {
				NSRunningApplication[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSRunningApplication>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRunningApplicationsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSRunningApplication>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRunningApplicationsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ThreadSafe]
		public static NSWorkspace SharedWorkspace {
			[Export ("sharedWorkspace")]
			get {
				NSWorkspace? ret;
				ret =  Runtime.GetNSObject<NSWorkspace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSharedWorkspaceXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool SwitchControlEnabled {
			[Export ("isSwitchControlEnabled")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSwitchControlEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsSwitchControlEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool VoiceOverEnabled {
			[Export ("isVoiceOverEnabled")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsVoiceOverEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsVoiceOverEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ActiveSpaceDidChangeNotification;
		/// <summary>Notification constant for ActiveSpaceDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveActiveSpaceDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveActiveSpaceDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveActiveSpaceDidChange ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveActiveSpaceDidChange (Callback);
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
		///     NSWorkspace.ActiveSpaceDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification ActiveSpaceDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ActiveSpaceDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.ActiveSpaceDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceActiveSpaceDidChangeNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveActiveSpaceDidChange helper method instead.")]
		public static NSString ActiveSpaceDidChangeNotification {
			get {
				if (_ActiveSpaceDidChangeNotification is null)
					_ActiveSpaceDidChangeNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceActiveSpaceDidChangeNotification")!;
				return _ActiveSpaceDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidActivateApplicationNotification;
		/// <summary>Notification constant for DidActivateApplication</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidActivateApplication(NSObject,EventHandler{NSWorkspaceApplicationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidActivateApplication(EventHandler{NSWorkspaceApplicationEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveDidActivateApplication ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSWorkspaceApplicationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveDidActivateApplication (Callback);
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
		///     NSWorkspace.DidActivateApplicationNotification, (notification) => { Console.WriteLine ("Received the notification DidActivateApplication", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidActivateApplication", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.DidActivateApplicationNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceDidActivateApplicationNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveDidActivateApplication helper method instead.")]
		public static NSString DidActivateApplicationNotification {
			get {
				if (_DidActivateApplicationNotification is null)
					_DidActivateApplicationNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceDidActivateApplicationNotification")!;
				return _DidActivateApplicationNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidChangeFileLabelsNotification;
		/// <summary>Notification constant for DidChangeFileLabels</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidChangeFileLabels(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidChangeFileLabels(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveDidChangeFileLabels ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveDidChangeFileLabels (Callback);
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
		///     NSWorkspace.DidChangeFileLabelsNotification, (notification) => { Console.WriteLine ("Received the notification DidChangeFileLabels", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidChangeFileLabels", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.DidChangeFileLabelsNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceDidChangeFileLabelsNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveDidChangeFileLabels helper method instead.")]
		public static NSString DidChangeFileLabelsNotification {
			get {
				if (_DidChangeFileLabelsNotification is null)
					_DidChangeFileLabelsNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceDidChangeFileLabelsNotification")!;
				return _DidChangeFileLabelsNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidDeactivateApplicationNotification;
		/// <summary>Notification constant for DidDeactivateApplication</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidDeactivateApplication(NSObject,EventHandler{NSWorkspaceApplicationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidDeactivateApplication(EventHandler{NSWorkspaceApplicationEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveDidDeactivateApplication ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSWorkspaceApplicationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveDidDeactivateApplication (Callback);
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
		///     NSWorkspace.DidDeactivateApplicationNotification, (notification) => { Console.WriteLine ("Received the notification DidDeactivateApplication", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidDeactivateApplication", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.DidDeactivateApplicationNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceDidDeactivateApplicationNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveDidDeactivateApplication helper method instead.")]
		public static NSString DidDeactivateApplicationNotification {
			get {
				if (_DidDeactivateApplicationNotification is null)
					_DidDeactivateApplicationNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceDidDeactivateApplicationNotification")!;
				return _DidDeactivateApplicationNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidHideApplicationNotification;
		/// <summary>Notification constant for DidHideApplication</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidHideApplication(NSObject,EventHandler{NSWorkspaceApplicationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidHideApplication(EventHandler{NSWorkspaceApplicationEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveDidHideApplication ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSWorkspaceApplicationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveDidHideApplication (Callback);
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
		///     NSWorkspace.DidHideApplicationNotification, (notification) => { Console.WriteLine ("Received the notification DidHideApplication", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidHideApplication", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.DidHideApplicationNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceDidHideApplicationNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveDidHideApplication helper method instead.")]
		public static NSString DidHideApplicationNotification {
			get {
				if (_DidHideApplicationNotification is null)
					_DidHideApplicationNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceDidHideApplicationNotification")!;
				return _DidHideApplicationNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidLaunchApplicationNotification;
		/// <summary>Notification constant for DidLaunchApplication</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidLaunchApplication(NSObject,EventHandler{NSWorkspaceApplicationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidLaunchApplication(EventHandler{NSWorkspaceApplicationEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveDidLaunchApplication ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSWorkspaceApplicationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveDidLaunchApplication (Callback);
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
		///     NSWorkspace.DidLaunchApplicationNotification, (notification) => { Console.WriteLine ("Received the notification DidLaunchApplication", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidLaunchApplication", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.DidLaunchApplicationNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceDidLaunchApplicationNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveDidLaunchApplication helper method instead.")]
		public static NSString DidLaunchApplicationNotification {
			get {
				if (_DidLaunchApplicationNotification is null)
					_DidLaunchApplicationNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceDidLaunchApplicationNotification")!;
				return _DidLaunchApplicationNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidMountNotification;
		/// <summary>Notification constant for DidMount</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidMount(NSObject,EventHandler{NSWorkspaceMountEventArgs})" />
		///     or <see cref="Notifications.ObserveDidMount(EventHandler{NSWorkspaceMountEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveDidMount ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSWorkspaceMountEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveDidMount (Callback);
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
		///     NSWorkspace.DidMountNotification, (notification) => { Console.WriteLine ("Received the notification DidMount", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidMount", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.DidMountNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceDidMountNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveDidMount helper method instead.")]
		public static NSString DidMountNotification {
			get {
				if (_DidMountNotification is null)
					_DidMountNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceDidMountNotification")!;
				return _DidMountNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidPerformFileOperationNotification;
		/// <summary>Notification constant for DidPerformFileOperation</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidPerformFileOperation(NSObject,EventHandler{NSWorkspaceFileOperationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidPerformFileOperation(EventHandler{NSWorkspaceFileOperationEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveDidPerformFileOperation ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSWorkspaceFileOperationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveDidPerformFileOperation (Callback);
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
		///     NSWorkspace.DidPerformFileOperationNotification, (notification) => { Console.WriteLine ("Received the notification DidPerformFileOperation", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidPerformFileOperation", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.DidPerformFileOperationNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceDidPerformFileOperationNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveDidPerformFileOperation helper method instead.")]
		public static NSString DidPerformFileOperationNotification {
			get {
				if (_DidPerformFileOperationNotification is null)
					_DidPerformFileOperationNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceDidPerformFileOperationNotification")!;
				return _DidPerformFileOperationNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidRenameVolumeNotification;
		/// <summary>Notification constant for DidRenameVolume</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidRenameVolume(NSObject,EventHandler{NSWorkspaceRenamedEventArgs})" />
		///     or <see cref="Notifications.ObserveDidRenameVolume(EventHandler{NSWorkspaceRenamedEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveDidRenameVolume ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSWorkspaceRenamedEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveDidRenameVolume (Callback);
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
		///     NSWorkspace.DidRenameVolumeNotification, (notification) => { Console.WriteLine ("Received the notification DidRenameVolume", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidRenameVolume", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.DidRenameVolumeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceDidRenameVolumeNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveDidRenameVolume helper method instead.")]
		public static NSString DidRenameVolumeNotification {
			get {
				if (_DidRenameVolumeNotification is null)
					_DidRenameVolumeNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceDidRenameVolumeNotification")!;
				return _DidRenameVolumeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidTerminateApplicationNotification;
		/// <summary>Notification constant for DidTerminateApplication</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidTerminateApplication(NSObject,EventHandler{NSWorkspaceApplicationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidTerminateApplication(EventHandler{NSWorkspaceApplicationEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveDidTerminateApplication ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSWorkspaceApplicationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveDidTerminateApplication (Callback);
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
		///     NSWorkspace.DidTerminateApplicationNotification, (notification) => { Console.WriteLine ("Received the notification DidTerminateApplication", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidTerminateApplication", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.DidTerminateApplicationNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceDidTerminateApplicationNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveDidTerminateApplication helper method instead.")]
		public static NSString DidTerminateApplicationNotification {
			get {
				if (_DidTerminateApplicationNotification is null)
					_DidTerminateApplicationNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceDidTerminateApplicationNotification")!;
				return _DidTerminateApplicationNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidUnhideApplicationNotification;
		/// <summary>Notification constant for DidUnhideApplication</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidUnhideApplication(NSObject,EventHandler{NSWorkspaceApplicationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidUnhideApplication(EventHandler{NSWorkspaceApplicationEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveDidUnhideApplication ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSWorkspaceApplicationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveDidUnhideApplication (Callback);
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
		///     NSWorkspace.DidUnhideApplicationNotification, (notification) => { Console.WriteLine ("Received the notification DidUnhideApplication", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidUnhideApplication", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.DidUnhideApplicationNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceDidUnhideApplicationNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveDidUnhideApplication helper method instead.")]
		public static NSString DidUnhideApplicationNotification {
			get {
				if (_DidUnhideApplicationNotification is null)
					_DidUnhideApplicationNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceDidUnhideApplicationNotification")!;
				return _DidUnhideApplicationNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidUnmountNotification;
		/// <summary>Notification constant for DidUnmount</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidUnmount(NSObject,EventHandler{NSWorkspaceMountEventArgs})" />
		///     or <see cref="Notifications.ObserveDidUnmount(EventHandler{NSWorkspaceMountEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveDidUnmount ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSWorkspaceMountEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveDidUnmount (Callback);
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
		///     NSWorkspace.DidUnmountNotification, (notification) => { Console.WriteLine ("Received the notification DidUnmount", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidUnmount", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.DidUnmountNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceDidUnmountNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveDidUnmount helper method instead.")]
		public static NSString DidUnmountNotification {
			get {
				if (_DidUnmountNotification is null)
					_DidUnmountNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceDidUnmountNotification")!;
				return _DidUnmountNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidWakeNotification;
		/// <summary>Notification constant for DidWake</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidWake(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidWake(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveDidWake ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveDidWake (Callback);
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
		///     NSWorkspace.DidWakeNotification, (notification) => { Console.WriteLine ("Received the notification DidWake", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidWake", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.DidWakeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceDidWakeNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveDidWake helper method instead.")]
		public static NSString DidWakeNotification {
			get {
				if (_DidWakeNotification is null)
					_DidWakeNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceDidWakeNotification")!;
				return _DidWakeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisplayOptionsDidChangeNotification;
		/// <summary>Notification constant for DisplayOptionsDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDisplayOptionsDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDisplayOptionsDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveDisplayOptionsDidChange ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveDisplayOptionsDidChange (Callback);
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
		///     NSWorkspace.DisplayOptionsDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification DisplayOptionsDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DisplayOptionsDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.DisplayOptionsDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceAccessibilityDisplayOptionsDidChangeNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveDisplayOptionsDidChange helper method instead.")]
		public static NSString DisplayOptionsDidChangeNotification {
			get {
				if (_DisplayOptionsDidChangeNotification is null)
					_DisplayOptionsDidChangeNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceAccessibilityDisplayOptionsDidChangeNotification")!;
				return _DisplayOptionsDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LaunchConfigurationAppleEvent;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSWorkspaceLaunchConfigurationAppleEvent",  "AppKit")]
		public static NSString LaunchConfigurationAppleEvent {
			get {
				if (_LaunchConfigurationAppleEvent is null)
					_LaunchConfigurationAppleEvent = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceLaunchConfigurationAppleEvent")!;
				return _LaunchConfigurationAppleEvent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LaunchConfigurationArchitecture;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSWorkspaceLaunchConfigurationArchitecture",  "AppKit")]
		public static NSString LaunchConfigurationArchitecture {
			get {
				if (_LaunchConfigurationArchitecture is null)
					_LaunchConfigurationArchitecture = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceLaunchConfigurationArchitecture")!;
				return _LaunchConfigurationArchitecture;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LaunchConfigurationArguments;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSWorkspaceLaunchConfigurationArguments",  "AppKit")]
		public static NSString LaunchConfigurationArguments {
			get {
				if (_LaunchConfigurationArguments is null)
					_LaunchConfigurationArguments = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceLaunchConfigurationArguments")!;
				return _LaunchConfigurationArguments;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LaunchConfigurationEnvironment;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSWorkspaceLaunchConfigurationEnvironment",  "AppKit")]
		public static NSString LaunchConfigurationEnvironment {
			get {
				if (_LaunchConfigurationEnvironment is null)
					_LaunchConfigurationEnvironment = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceLaunchConfigurationEnvironment")!;
				return _LaunchConfigurationEnvironment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OperationCopy;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSWorkspaceCopyOperation",  "AppKit")]
		public static NSString OperationCopy {
			get {
				if (_OperationCopy is null)
					_OperationCopy = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceCopyOperation")!;
				return _OperationCopy;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OperationDestroy;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSWorkspaceDestroyOperation",  "AppKit")]
		public static NSString OperationDestroy {
			get {
				if (_OperationDestroy is null)
					_OperationDestroy = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceDestroyOperation")!;
				return _OperationDestroy;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OperationDuplicate;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSWorkspaceDuplicateOperation",  "AppKit")]
		public static NSString OperationDuplicate {
			get {
				if (_OperationDuplicate is null)
					_OperationDuplicate = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceDuplicateOperation")!;
				return _OperationDuplicate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OperationLink;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSWorkspaceLinkOperation",  "AppKit")]
		public static NSString OperationLink {
			get {
				if (_OperationLink is null)
					_OperationLink = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceLinkOperation")!;
				return _OperationLink;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OperationMove;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSWorkspaceMoveOperation",  "AppKit")]
		public static NSString OperationMove {
			get {
				if (_OperationMove is null)
					_OperationMove = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceMoveOperation")!;
				return _OperationMove;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OperationRecycle;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSWorkspaceRecycleOperation",  "AppKit")]
		public static NSString OperationRecycle {
			get {
				if (_OperationRecycle is null)
					_OperationRecycle = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceRecycleOperation")!;
				return _OperationRecycle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScreensDidSleepNotification;
		/// <summary>Notification constant for ScreensDidSleep</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveScreensDidSleep(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveScreensDidSleep(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveScreensDidSleep ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveScreensDidSleep (Callback);
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
		///     NSWorkspace.ScreensDidSleepNotification, (notification) => { Console.WriteLine ("Received the notification ScreensDidSleep", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ScreensDidSleep", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.ScreensDidSleepNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceScreensDidSleepNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveScreensDidSleep helper method instead.")]
		public static NSString ScreensDidSleepNotification {
			get {
				if (_ScreensDidSleepNotification is null)
					_ScreensDidSleepNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceScreensDidSleepNotification")!;
				return _ScreensDidSleepNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScreensDidWakeNotification;
		/// <summary>Notification constant for ScreensDidWake</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveScreensDidWake(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveScreensDidWake(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveScreensDidWake ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveScreensDidWake (Callback);
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
		///     NSWorkspace.ScreensDidWakeNotification, (notification) => { Console.WriteLine ("Received the notification ScreensDidWake", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ScreensDidWake", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.ScreensDidWakeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceScreensDidWakeNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveScreensDidWake helper method instead.")]
		public static NSString ScreensDidWakeNotification {
			get {
				if (_ScreensDidWakeNotification is null)
					_ScreensDidWakeNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceScreensDidWakeNotification")!;
				return _ScreensDidWakeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SessionDidBecomeActiveNotification;
		/// <summary>Notification constant for SessionDidBecomeActive</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveSessionDidBecomeActive(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveSessionDidBecomeActive(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveSessionDidBecomeActive ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveSessionDidBecomeActive (Callback);
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
		///     NSWorkspace.SessionDidBecomeActiveNotification, (notification) => { Console.WriteLine ("Received the notification SessionDidBecomeActive", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification SessionDidBecomeActive", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.SessionDidBecomeActiveNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceSessionDidBecomeActiveNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveSessionDidBecomeActive helper method instead.")]
		public static NSString SessionDidBecomeActiveNotification {
			get {
				if (_SessionDidBecomeActiveNotification is null)
					_SessionDidBecomeActiveNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceSessionDidBecomeActiveNotification")!;
				return _SessionDidBecomeActiveNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SessionDidResignActiveNotification;
		/// <summary>Notification constant for SessionDidResignActive</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveSessionDidResignActive(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveSessionDidResignActive(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveSessionDidResignActive ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveSessionDidResignActive (Callback);
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
		///     NSWorkspace.SessionDidResignActiveNotification, (notification) => { Console.WriteLine ("Received the notification SessionDidResignActive", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification SessionDidResignActive", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.SessionDidResignActiveNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceSessionDidResignActiveNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveSessionDidResignActive helper method instead.")]
		public static NSString SessionDidResignActiveNotification {
			get {
				if (_SessionDidResignActiveNotification is null)
					_SessionDidResignActiveNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceSessionDidResignActiveNotification")!;
				return _SessionDidResignActiveNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WillLaunchApplication;
		/// <summary>Notification constant for WillLaunchApplication</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWillLaunchApplication(NSObject,EventHandler{NSWorkspaceApplicationEventArgs})" />
		///     or <see cref="Notifications.ObserveWillLaunchApplication(EventHandler{NSWorkspaceApplicationEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveWillLaunchApplication ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSWorkspaceApplicationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveWillLaunchApplication (Callback);
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
		///     NSWorkspace.WillLaunchApplicationNotification, (notification) => { Console.WriteLine ("Received the notification WillLaunchApplication", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WillLaunchApplication", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.WillLaunchApplicationNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceWillLaunchApplicationNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveWillLaunchApplication helper method instead.")]
		public static NSString WillLaunchApplication {
			get {
				if (_WillLaunchApplication is null)
					_WillLaunchApplication = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceWillLaunchApplicationNotification")!;
				return _WillLaunchApplication;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WillPowerOffNotification;
		/// <summary>Notification constant for WillPowerOff</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWillPowerOff(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveWillPowerOff(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveWillPowerOff ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveWillPowerOff (Callback);
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
		///     NSWorkspace.WillPowerOffNotification, (notification) => { Console.WriteLine ("Received the notification WillPowerOff", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WillPowerOff", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.WillPowerOffNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceWillPowerOffNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveWillPowerOff helper method instead.")]
		public static NSString WillPowerOffNotification {
			get {
				if (_WillPowerOffNotification is null)
					_WillPowerOffNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceWillPowerOffNotification")!;
				return _WillPowerOffNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WillSleepNotification;
		/// <summary>Notification constant for WillSleep</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWillSleep(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveWillSleep(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveWillSleep ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveWillSleep (Callback);
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
		///     NSWorkspace.WillSleepNotification, (notification) => { Console.WriteLine ("Received the notification WillSleep", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WillSleep", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.WillSleepNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceWillSleepNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveWillSleep helper method instead.")]
		public static NSString WillSleepNotification {
			get {
				if (_WillSleepNotification is null)
					_WillSleepNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceWillSleepNotification")!;
				return _WillSleepNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WillUnmountNotification;
		/// <summary>Notification constant for WillUnmount</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWillUnmount(NSObject,EventHandler{NSWorkspaceMountEventArgs})" />
		///     or <see cref="Notifications.ObserveWillUnmount(EventHandler{NSWorkspaceMountEventArgs})" /> methods,
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
		/// notification = NSWorkspace.Notifications.ObserveWillUnmount ((sender, args) => {
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
		/// void Callback (object sender, NSWorkspace.NSWorkspaceMountEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSWorkspace.Notifications.ObserveWillUnmount (Callback);
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
		///     NSWorkspace.WillUnmountNotification, (notification) => { Console.WriteLine ("Received the notification WillUnmount", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WillUnmount", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSWorkspace.WillUnmountNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSWorkspaceWillUnmountNotification",  "AppKit")]
		[Advice ("Use NSWorkspace.Notifications.ObserveWillUnmount helper method instead.")]
		public static NSString WillUnmountNotification {
			get {
				if (_WillUnmountNotification is null)
					_WillUnmountNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSWorkspaceWillUnmountNotification")!;
				return _WillUnmountNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AppKit.NSWorkspace" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.ActiveSpaceDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.ActiveSpaceDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveActiveSpaceDidChange ((notification) => {
			///   Console.WriteLine ("Observed ActiveSpaceDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveActiveSpaceDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (ActiveSpaceDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.ActiveSpaceDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.ActiveSpaceDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveActiveSpaceDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ActiveSpaceDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveActiveSpaceDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (ActiveSpaceDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidActivateApplicationNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidActivateApplicationNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveDidActivateApplication ((notification) => {
			///   Console.WriteLine ("Observed DidActivateApplicationNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidActivateApplication (EventHandler<AppKit.NSWorkspaceApplicationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidActivateApplicationNotification, notification => handler (null, new AppKit.NSWorkspaceApplicationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidActivateApplicationNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidActivateApplicationNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveDidActivateApplication (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidActivateApplicationNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidActivateApplication (NSObject objectToObserve, EventHandler<AppKit.NSWorkspaceApplicationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidActivateApplicationNotification, notification => handler (null, new AppKit.NSWorkspaceApplicationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidChangeFileLabelsNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidChangeFileLabelsNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveDidChangeFileLabels ((notification) => {
			///   Console.WriteLine ("Observed DidChangeFileLabelsNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeFileLabels (EventHandler<NSNotificationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidChangeFileLabelsNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidChangeFileLabelsNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidChangeFileLabelsNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveDidChangeFileLabels (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidChangeFileLabelsNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeFileLabels (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidChangeFileLabelsNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidDeactivateApplicationNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidDeactivateApplicationNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveDidDeactivateApplication ((notification) => {
			///   Console.WriteLine ("Observed DidDeactivateApplicationNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidDeactivateApplication (EventHandler<AppKit.NSWorkspaceApplicationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidDeactivateApplicationNotification, notification => handler (null, new AppKit.NSWorkspaceApplicationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidDeactivateApplicationNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidDeactivateApplicationNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveDidDeactivateApplication (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidDeactivateApplicationNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidDeactivateApplication (NSObject objectToObserve, EventHandler<AppKit.NSWorkspaceApplicationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidDeactivateApplicationNotification, notification => handler (null, new AppKit.NSWorkspaceApplicationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidHideApplicationNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidHideApplicationNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveDidHideApplication ((notification) => {
			///   Console.WriteLine ("Observed DidHideApplicationNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidHideApplication (EventHandler<AppKit.NSWorkspaceApplicationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidHideApplicationNotification, notification => handler (null, new AppKit.NSWorkspaceApplicationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidHideApplicationNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidHideApplicationNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveDidHideApplication (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidHideApplicationNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidHideApplication (NSObject objectToObserve, EventHandler<AppKit.NSWorkspaceApplicationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidHideApplicationNotification, notification => handler (null, new AppKit.NSWorkspaceApplicationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidLaunchApplicationNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidLaunchApplicationNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveDidLaunchApplication ((notification) => {
			///   Console.WriteLine ("Observed DidLaunchApplicationNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidLaunchApplication (EventHandler<AppKit.NSWorkspaceApplicationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidLaunchApplicationNotification, notification => handler (null, new AppKit.NSWorkspaceApplicationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidLaunchApplicationNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidLaunchApplicationNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveDidLaunchApplication (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidLaunchApplicationNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidLaunchApplication (NSObject objectToObserve, EventHandler<AppKit.NSWorkspaceApplicationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidLaunchApplicationNotification, notification => handler (null, new AppKit.NSWorkspaceApplicationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidMountNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidMountNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveDidMount ((notification) => {
			///   Console.WriteLine ("Observed DidMountNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidMount (EventHandler<AppKit.NSWorkspaceMountEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidMountNotification, notification => handler (null, new AppKit.NSWorkspaceMountEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidMountNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidMountNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveDidMount (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidMountNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidMount (NSObject objectToObserve, EventHandler<AppKit.NSWorkspaceMountEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidMountNotification, notification => handler (null, new AppKit.NSWorkspaceMountEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidPerformFileOperationNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidPerformFileOperationNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveDidPerformFileOperation ((notification) => {
			///   Console.WriteLine ("Observed DidPerformFileOperationNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidPerformFileOperation (EventHandler<AppKit.NSWorkspaceFileOperationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidPerformFileOperationNotification, notification => handler (null, new AppKit.NSWorkspaceFileOperationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidPerformFileOperationNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidPerformFileOperationNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveDidPerformFileOperation (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidPerformFileOperationNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidPerformFileOperation (NSObject objectToObserve, EventHandler<AppKit.NSWorkspaceFileOperationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidPerformFileOperationNotification, notification => handler (null, new AppKit.NSWorkspaceFileOperationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidRenameVolumeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidRenameVolumeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveDidRenameVolume ((notification) => {
			///   Console.WriteLine ("Observed DidRenameVolumeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidRenameVolume (EventHandler<AppKit.NSWorkspaceRenamedEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidRenameVolumeNotification, notification => handler (null, new AppKit.NSWorkspaceRenamedEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidRenameVolumeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidRenameVolumeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveDidRenameVolume (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidRenameVolumeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidRenameVolume (NSObject objectToObserve, EventHandler<AppKit.NSWorkspaceRenamedEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidRenameVolumeNotification, notification => handler (null, new AppKit.NSWorkspaceRenamedEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidTerminateApplicationNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidTerminateApplicationNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveDidTerminateApplication ((notification) => {
			///   Console.WriteLine ("Observed DidTerminateApplicationNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidTerminateApplication (EventHandler<AppKit.NSWorkspaceApplicationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidTerminateApplicationNotification, notification => handler (null, new AppKit.NSWorkspaceApplicationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidTerminateApplicationNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidTerminateApplicationNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveDidTerminateApplication (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidTerminateApplicationNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidTerminateApplication (NSObject objectToObserve, EventHandler<AppKit.NSWorkspaceApplicationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidTerminateApplicationNotification, notification => handler (null, new AppKit.NSWorkspaceApplicationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidUnhideApplicationNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidUnhideApplicationNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveDidUnhideApplication ((notification) => {
			///   Console.WriteLine ("Observed DidUnhideApplicationNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidUnhideApplication (EventHandler<AppKit.NSWorkspaceApplicationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidUnhideApplicationNotification, notification => handler (null, new AppKit.NSWorkspaceApplicationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidUnhideApplicationNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidUnhideApplicationNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveDidUnhideApplication (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidUnhideApplicationNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidUnhideApplication (NSObject objectToObserve, EventHandler<AppKit.NSWorkspaceApplicationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidUnhideApplicationNotification, notification => handler (null, new AppKit.NSWorkspaceApplicationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidUnmountNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidUnmountNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveDidUnmount ((notification) => {
			///   Console.WriteLine ("Observed DidUnmountNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidUnmount (EventHandler<AppKit.NSWorkspaceMountEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidUnmountNotification, notification => handler (null, new AppKit.NSWorkspaceMountEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidUnmountNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidUnmountNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveDidUnmount (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidUnmountNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidUnmount (NSObject objectToObserve, EventHandler<AppKit.NSWorkspaceMountEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidUnmountNotification, notification => handler (null, new AppKit.NSWorkspaceMountEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidWakeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidWakeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveDidWake ((notification) => {
			///   Console.WriteLine ("Observed DidWakeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidWake (EventHandler<NSNotificationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidWakeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DidWakeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DidWakeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveDidWake (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidWakeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidWake (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (DidWakeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DisplayOptionsDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DisplayOptionsDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveDisplayOptionsDidChange ((notification) => {
			///   Console.WriteLine ("Observed DisplayOptionsDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDisplayOptionsDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DisplayOptionsDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.DisplayOptionsDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.DisplayOptionsDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveDisplayOptionsDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DisplayOptionsDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDisplayOptionsDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DisplayOptionsDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.ScreensDidSleepNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.ScreensDidSleepNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveScreensDidSleep ((notification) => {
			///   Console.WriteLine ("Observed ScreensDidSleepNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveScreensDidSleep (EventHandler<NSNotificationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (ScreensDidSleepNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.ScreensDidSleepNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.ScreensDidSleepNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveScreensDidSleep (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ScreensDidSleepNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveScreensDidSleep (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (ScreensDidSleepNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.ScreensDidWakeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.ScreensDidWakeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveScreensDidWake ((notification) => {
			///   Console.WriteLine ("Observed ScreensDidWakeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveScreensDidWake (EventHandler<NSNotificationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (ScreensDidWakeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.ScreensDidWakeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.ScreensDidWakeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveScreensDidWake (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ScreensDidWakeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveScreensDidWake (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (ScreensDidWakeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.SessionDidBecomeActiveNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.SessionDidBecomeActiveNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveSessionDidBecomeActive ((notification) => {
			///   Console.WriteLine ("Observed SessionDidBecomeActiveNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSessionDidBecomeActive (EventHandler<NSNotificationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (SessionDidBecomeActiveNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.SessionDidBecomeActiveNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.SessionDidBecomeActiveNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveSessionDidBecomeActive (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed SessionDidBecomeActiveNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSessionDidBecomeActive (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (SessionDidBecomeActiveNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.SessionDidResignActiveNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.SessionDidResignActiveNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveSessionDidResignActive ((notification) => {
			///   Console.WriteLine ("Observed SessionDidResignActiveNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSessionDidResignActive (EventHandler<NSNotificationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (SessionDidResignActiveNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.SessionDidResignActiveNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.SessionDidResignActiveNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveSessionDidResignActive (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed SessionDidResignActiveNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSessionDidResignActive (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (SessionDidResignActiveNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.WillLaunchApplication" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.WillLaunchApplication" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveWillLaunchApplication ((notification) => {
			///   Console.WriteLine ("Observed WillLaunchApplicationNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillLaunchApplication (EventHandler<AppKit.NSWorkspaceApplicationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (WillLaunchApplication, notification => handler (null, new AppKit.NSWorkspaceApplicationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.WillLaunchApplication" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.WillLaunchApplication" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveWillLaunchApplication (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WillLaunchApplicationNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillLaunchApplication (NSObject objectToObserve, EventHandler<AppKit.NSWorkspaceApplicationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (WillLaunchApplication, notification => handler (null, new AppKit.NSWorkspaceApplicationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.WillPowerOffNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.WillPowerOffNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveWillPowerOff ((notification) => {
			///   Console.WriteLine ("Observed WillPowerOffNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillPowerOff (EventHandler<NSNotificationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (WillPowerOffNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.WillPowerOffNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.WillPowerOffNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveWillPowerOff (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WillPowerOffNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillPowerOff (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (WillPowerOffNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.WillSleepNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.WillSleepNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveWillSleep ((notification) => {
			///   Console.WriteLine ("Observed WillSleepNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillSleep (EventHandler<NSNotificationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (WillSleepNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.WillSleepNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.WillSleepNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveWillSleep (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WillSleepNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillSleep (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (WillSleepNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.WillUnmountNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.WillUnmountNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSWorkspace.Notifications.ObserveWillUnmount ((notification) => {
			///   Console.WriteLine ("Observed WillUnmountNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillUnmount (EventHandler<AppKit.NSWorkspaceMountEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (WillUnmountNotification, notification => handler (null, new AppKit.NSWorkspaceMountEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSWorkspace.WillUnmountNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSWorkspace.WillUnmountNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSWorkspace.Notifications.ObserveWillUnmount (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WillUnmountNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillUnmount (NSObject objectToObserve, EventHandler<AppKit.NSWorkspaceMountEventArgs> handler)
			{
				return SharedWorkspace.NotificationCenter.AddObserver (WillUnmountNotification, notification => handler (null, new AppKit.NSWorkspaceMountEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSWorkspace */
}
