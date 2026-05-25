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
namespace Foundation {
	[Register("NSFileManager", true)]
	public unsafe partial class NSFileManager : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLForDirectory_InDomain_AppropriateForURL_Create_Error_X = "URLForDirectory:inDomain:appropriateForURL:create:error:";
		static readonly NativeHandle selURLForDirectory_InDomain_AppropriateForURL_Create_Error_XHandle = Selector.GetHandle ("URLForDirectory:inDomain:appropriateForURL:create:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLForPublishingUbiquitousItemAtURL_ExpirationDate_Error_X = "URLForPublishingUbiquitousItemAtURL:expirationDate:error:";
		static readonly NativeHandle selURLForPublishingUbiquitousItemAtURL_ExpirationDate_Error_XHandle = Selector.GetHandle ("URLForPublishingUbiquitousItemAtURL:expirationDate:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLForUbiquityContainerIdentifier_X = "URLForUbiquityContainerIdentifier:";
		static readonly NativeHandle selURLForUbiquityContainerIdentifier_XHandle = Selector.GetHandle ("URLForUbiquityContainerIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLsForDirectory_InDomains_X = "URLsForDirectory:inDomains:";
		static readonly NativeHandle selURLsForDirectory_InDomains_XHandle = Selector.GetHandle ("URLsForDirectory:inDomains:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributesOfFileSystemForPath_Error_X = "attributesOfFileSystemForPath:error:";
		static readonly NativeHandle selAttributesOfFileSystemForPath_Error_XHandle = Selector.GetHandle ("attributesOfFileSystemForPath:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributesOfItemAtPath_Error_X = "attributesOfItemAtPath:error:";
		static readonly NativeHandle selAttributesOfItemAtPath_Error_XHandle = Selector.GetHandle ("attributesOfItemAtPath:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeCurrentDirectoryPath_X = "changeCurrentDirectoryPath:";
		static readonly NativeHandle selChangeCurrentDirectoryPath_XHandle = Selector.GetHandle ("changeCurrentDirectoryPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponentsToDisplayForPath_X = "componentsToDisplayForPath:";
		static readonly NativeHandle selComponentsToDisplayForPath_XHandle = Selector.GetHandle ("componentsToDisplayForPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContainerURLForSecurityApplicationGroupIdentifier_X = "containerURLForSecurityApplicationGroupIdentifier:";
		static readonly NativeHandle selContainerURLForSecurityApplicationGroupIdentifier_XHandle = Selector.GetHandle ("containerURLForSecurityApplicationGroupIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentsAtPath_X = "contentsAtPath:";
		static readonly NativeHandle selContentsAtPath_XHandle = Selector.GetHandle ("contentsAtPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentsEqualAtPath_AndPath_X = "contentsEqualAtPath:andPath:";
		static readonly NativeHandle selContentsEqualAtPath_AndPath_XHandle = Selector.GetHandle ("contentsEqualAtPath:andPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentsOfDirectoryAtPath_Error_X = "contentsOfDirectoryAtPath:error:";
		static readonly NativeHandle selContentsOfDirectoryAtPath_Error_XHandle = Selector.GetHandle ("contentsOfDirectoryAtPath:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentsOfDirectoryAtURL_IncludingPropertiesForKeys_Options_Error_X = "contentsOfDirectoryAtURL:includingPropertiesForKeys:options:error:";
		static readonly NativeHandle selContentsOfDirectoryAtURL_IncludingPropertiesForKeys_Options_Error_XHandle = Selector.GetHandle ("contentsOfDirectoryAtURL:includingPropertiesForKeys:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyItemAtPath_ToPath_Error_X = "copyItemAtPath:toPath:error:";
		static readonly NativeHandle selCopyItemAtPath_ToPath_Error_XHandle = Selector.GetHandle ("copyItemAtPath:toPath:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyItemAtURL_ToURL_Error_X = "copyItemAtURL:toURL:error:";
		static readonly NativeHandle selCopyItemAtURL_ToURL_Error_XHandle = Selector.GetHandle ("copyItemAtURL:toURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateDirectoryAtPath_WithIntermediateDirectories_Attributes_Error_X = "createDirectoryAtPath:withIntermediateDirectories:attributes:error:";
		static readonly NativeHandle selCreateDirectoryAtPath_WithIntermediateDirectories_Attributes_Error_XHandle = Selector.GetHandle ("createDirectoryAtPath:withIntermediateDirectories:attributes:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateDirectoryAtURL_WithIntermediateDirectories_Attributes_Error_X = "createDirectoryAtURL:withIntermediateDirectories:attributes:error:";
		static readonly NativeHandle selCreateDirectoryAtURL_WithIntermediateDirectories_Attributes_Error_XHandle = Selector.GetHandle ("createDirectoryAtURL:withIntermediateDirectories:attributes:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateFileAtPath_Contents_Attributes_X = "createFileAtPath:contents:attributes:";
		static readonly NativeHandle selCreateFileAtPath_Contents_Attributes_XHandle = Selector.GetHandle ("createFileAtPath:contents:attributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateSymbolicLinkAtPath_WithDestinationPath_Error_X = "createSymbolicLinkAtPath:withDestinationPath:error:";
		static readonly NativeHandle selCreateSymbolicLinkAtPath_WithDestinationPath_Error_XHandle = Selector.GetHandle ("createSymbolicLinkAtPath:withDestinationPath:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateSymbolicLinkAtURL_WithDestinationURL_Error_X = "createSymbolicLinkAtURL:withDestinationURL:error:";
		static readonly NativeHandle selCreateSymbolicLinkAtURL_WithDestinationURL_Error_XHandle = Selector.GetHandle ("createSymbolicLinkAtURL:withDestinationURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentDirectoryPathX = "currentDirectoryPath";
		static readonly NativeHandle selCurrentDirectoryPathXHandle = Selector.GetHandle ("currentDirectoryPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultManagerX = "defaultManager";
		static readonly NativeHandle selDefaultManagerXHandle = Selector.GetHandle ("defaultManager");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationOfSymbolicLinkAtPath_Error_X = "destinationOfSymbolicLinkAtPath:error:";
		static readonly NativeHandle selDestinationOfSymbolicLinkAtPath_Error_XHandle = Selector.GetHandle ("destinationOfSymbolicLinkAtPath:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplayNameAtPath_X = "displayNameAtPath:";
		static readonly NativeHandle selDisplayNameAtPath_XHandle = Selector.GetHandle ("displayNameAtPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumeratorAtPath_X = "enumeratorAtPath:";
		static readonly NativeHandle selEnumeratorAtPath_XHandle = Selector.GetHandle ("enumeratorAtPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumeratorAtURL_IncludingPropertiesForKeys_Options_ErrorHandler_X = "enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:";
		static readonly NativeHandle selEnumeratorAtURL_IncludingPropertiesForKeys_Options_ErrorHandler_XHandle = Selector.GetHandle ("enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEvictUbiquitousItemAtURL_Error_X = "evictUbiquitousItemAtURL:error:";
		static readonly NativeHandle selEvictUbiquitousItemAtURL_Error_XHandle = Selector.GetHandle ("evictUbiquitousItemAtURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchLatestRemoteVersionOfItemAtURL_CompletionHandler_X = "fetchLatestRemoteVersionOfItemAtURL:completionHandler:";
		static readonly NativeHandle selFetchLatestRemoteVersionOfItemAtURL_CompletionHandler_XHandle = Selector.GetHandle ("fetchLatestRemoteVersionOfItemAtURL:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileExistsAtPath_X = "fileExistsAtPath:";
		static readonly NativeHandle selFileExistsAtPath_XHandle = Selector.GetHandle ("fileExistsAtPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileExistsAtPath_IsDirectory_X = "fileExistsAtPath:isDirectory:";
		static readonly NativeHandle selFileExistsAtPath_IsDirectory_XHandle = Selector.GetHandle ("fileExistsAtPath:isDirectory:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileManagerWithAuthorization_X = "fileManagerWithAuthorization:";
		static readonly NativeHandle selFileManagerWithAuthorization_XHandle = Selector.GetHandle ("fileManagerWithAuthorization:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetFileProviderServicesForItemAtURL_CompletionHandler_X = "getFileProviderServicesForItemAtURL:completionHandler:";
		static readonly NativeHandle selGetFileProviderServicesForItemAtURL_CompletionHandler_XHandle = Selector.GetHandle ("getFileProviderServicesForItemAtURL:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetRelationship_OfDirectory_InDomain_ToItemAtURL_Error_X = "getRelationship:ofDirectory:inDomain:toItemAtURL:error:";
		static readonly NativeHandle selGetRelationship_OfDirectory_InDomain_ToItemAtURL_Error_XHandle = Selector.GetHandle ("getRelationship:ofDirectory:inDomain:toItemAtURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetRelationship_OfDirectoryAtURL_ToItemAtURL_Error_X = "getRelationship:ofDirectoryAtURL:toItemAtURL:error:";
		static readonly NativeHandle selGetRelationship_OfDirectoryAtURL_ToItemAtURL_Error_XHandle = Selector.GetHandle ("getRelationship:ofDirectoryAtURL:toItemAtURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDeletableFileAtPath_X = "isDeletableFileAtPath:";
		static readonly NativeHandle selIsDeletableFileAtPath_XHandle = Selector.GetHandle ("isDeletableFileAtPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsExecutableFileAtPath_X = "isExecutableFileAtPath:";
		static readonly NativeHandle selIsExecutableFileAtPath_XHandle = Selector.GetHandle ("isExecutableFileAtPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsReadableFileAtPath_X = "isReadableFileAtPath:";
		static readonly NativeHandle selIsReadableFileAtPath_XHandle = Selector.GetHandle ("isReadableFileAtPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsUbiquitousItemAtURL_X = "isUbiquitousItemAtURL:";
		static readonly NativeHandle selIsUbiquitousItemAtURL_XHandle = Selector.GetHandle ("isUbiquitousItemAtURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsWritableFileAtPath_X = "isWritableFileAtPath:";
		static readonly NativeHandle selIsWritableFileAtPath_XHandle = Selector.GetHandle ("isWritableFileAtPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLinkItemAtPath_ToPath_Error_X = "linkItemAtPath:toPath:error:";
		static readonly NativeHandle selLinkItemAtPath_ToPath_Error_XHandle = Selector.GetHandle ("linkItemAtPath:toPath:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLinkItemAtURL_ToURL_Error_X = "linkItemAtURL:toURL:error:";
		static readonly NativeHandle selLinkItemAtURL_ToURL_Error_XHandle = Selector.GetHandle ("linkItemAtURL:toURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMountedVolumeURLsIncludingResourceValuesForKeys_Options_X = "mountedVolumeURLsIncludingResourceValuesForKeys:options:";
		static readonly NativeHandle selMountedVolumeURLsIncludingResourceValuesForKeys_Options_XHandle = Selector.GetHandle ("mountedVolumeURLsIncludingResourceValuesForKeys:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveItemAtPath_ToPath_Error_X = "moveItemAtPath:toPath:error:";
		static readonly NativeHandle selMoveItemAtPath_ToPath_Error_XHandle = Selector.GetHandle ("moveItemAtPath:toPath:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveItemAtURL_ToURL_Error_X = "moveItemAtURL:toURL:error:";
		static readonly NativeHandle selMoveItemAtURL_ToURL_Error_XHandle = Selector.GetHandle ("moveItemAtURL:toURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPauseSyncForUbiquitousItemAtURL_CompletionHandler_X = "pauseSyncForUbiquitousItemAtURL:completionHandler:";
		static readonly NativeHandle selPauseSyncForUbiquitousItemAtURL_CompletionHandler_XHandle = Selector.GetHandle ("pauseSyncForUbiquitousItemAtURL:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveItemAtPath_Error_X = "removeItemAtPath:error:";
		static readonly NativeHandle selRemoveItemAtPath_Error_XHandle = Selector.GetHandle ("removeItemAtPath:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveItemAtURL_Error_X = "removeItemAtURL:error:";
		static readonly NativeHandle selRemoveItemAtURL_Error_XHandle = Selector.GetHandle ("removeItemAtURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplaceItemAtURL_WithItemAtURL_BackupItemName_Options_ResultingItemURL_Error_X = "replaceItemAtURL:withItemAtURL:backupItemName:options:resultingItemURL:error:";
		static readonly NativeHandle selReplaceItemAtURL_WithItemAtURL_BackupItemName_Options_ResultingItemURL_Error_XHandle = Selector.GetHandle ("replaceItemAtURL:withItemAtURL:backupItemName:options:resultingItemURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResumeSyncForUbiquitousItemAtURL_WithBehavior_CompletionHandler_X = "resumeSyncForUbiquitousItemAtURL:withBehavior:completionHandler:";
		static readonly NativeHandle selResumeSyncForUbiquitousItemAtURL_WithBehavior_CompletionHandler_XHandle = Selector.GetHandle ("resumeSyncForUbiquitousItemAtURL:withBehavior:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAttributes_OfItemAtPath_Error_X = "setAttributes:ofItemAtPath:error:";
		static readonly NativeHandle selSetAttributes_OfItemAtPath_Error_XHandle = Selector.GetHandle ("setAttributes:ofItemAtPath:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUbiquitous_ItemAtURL_DestinationURL_Error_X = "setUbiquitous:itemAtURL:destinationURL:error:";
		static readonly NativeHandle selSetUbiquitous_ItemAtURL_DestinationURL_Error_XHandle = Selector.GetHandle ("setUbiquitous:itemAtURL:destinationURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartDownloadingUbiquitousItemAtURL_Error_X = "startDownloadingUbiquitousItemAtURL:error:";
		static readonly NativeHandle selStartDownloadingUbiquitousItemAtURL_Error_XHandle = Selector.GetHandle ("startDownloadingUbiquitousItemAtURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubpathsAtPath_X = "subpathsAtPath:";
		static readonly NativeHandle selSubpathsAtPath_XHandle = Selector.GetHandle ("subpathsAtPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubpathsOfDirectoryAtPath_Error_X = "subpathsOfDirectoryAtPath:error:";
		static readonly NativeHandle selSubpathsOfDirectoryAtPath_Error_XHandle = Selector.GetHandle ("subpathsOfDirectoryAtPath:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTrashItemAtURL_ResultingItemURL_Error_X = "trashItemAtURL:resultingItemURL:error:";
		static readonly NativeHandle selTrashItemAtURL_ResultingItemURL_Error_XHandle = Selector.GetHandle ("trashItemAtURL:resultingItemURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUbiquityIdentityTokenX = "ubiquityIdentityToken";
		static readonly NativeHandle selUbiquityIdentityTokenXHandle = Selector.GetHandle ("ubiquityIdentityToken");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnmountVolumeAtURL_Options_CompletionHandler_X = "unmountVolumeAtURL:options:completionHandler:";
		static readonly NativeHandle selUnmountVolumeAtURL_Options_CompletionHandler_XHandle = Selector.GetHandle ("unmountVolumeAtURL:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUploadLocalVersionOfUbiquitousItemAtURL_WithConflictResolutionPolicy_CompletionHandler_X = "uploadLocalVersionOfUbiquitousItemAtURL:withConflictResolutionPolicy:completionHandler:";
		static readonly NativeHandle selUploadLocalVersionOfUbiquitousItemAtURL_WithConflictResolutionPolicy_CompletionHandler_XHandle = Selector.GetHandle ("uploadLocalVersionOfUbiquitousItemAtURL:withConflictResolutionPolicy:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSFileManager");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSFileManager" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSFileManager () : base (NSObjectFlag.Empty)
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
		protected NSFileManager (NSObjectFlag t) : base (t)
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
		protected internal NSFileManager (NativeHandle handle) : base (handle)
		{
		}

		[Export ("changeCurrentDirectoryPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ChangeCurrentDirectory (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selChangeCurrentDirectoryPath_XHandle, nspath);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selChangeCurrentDirectoryPath_XHandle, nspath);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			return ret != 0;
		}
		[Export ("componentsToDisplayForPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] ComponentsToDisplay (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selComponentsToDisplayForPath_XHandle, nspath), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selComponentsToDisplayForPath_XHandle, nspath), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			return ret!;
		}
		[Export ("contentsAtPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData Contents (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selContentsAtPath_XHandle, nspath), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selContentsAtPath_XHandle, nspath), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			return ret!;
		}
		[Export ("contentsEqualAtPath:andPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ContentsEqual (string path1, string path2)
		{
			if (path1 is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path1));
			if (path2 is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path2));
			var nspath1 = CFString.CreateNative (path1);
			var nspath2 = CFString.CreateNative (path2);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selContentsEqualAtPath_AndPath_XHandle, nspath1, nspath2);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selContentsEqualAtPath_AndPath_XHandle, nspath1, nspath2);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath1);
			CFString.ReleaseNative (nspath2);
			return ret != 0;
		}
		[Export ("copyItemAtPath:toPath:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Copy (string srcPath, string dstPath, out NSError error)
		{
			if (srcPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (srcPath));
			if (dstPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dstPath));
			NativeHandle errorValue = IntPtr.Zero;
			var nssrcPath = CFString.CreateNative (srcPath);
			var nsdstPath = CFString.CreateNative (dstPath);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selCopyItemAtPath_ToPath_Error_XHandle, nssrcPath, nsdstPath, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selCopyItemAtPath_ToPath_Error_XHandle, nssrcPath, nsdstPath, &errorValue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nssrcPath);
			CFString.ReleaseNative (nsdstPath);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("copyItemAtURL:toURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Copy (NSUrl srcUrl, NSUrl dstUrl, out NSError error)
		{
			var srcUrl__handle__ = srcUrl!.GetNonNullHandle (nameof (srcUrl));
			var dstUrl__handle__ = dstUrl!.GetNonNullHandle (nameof (dstUrl));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selCopyItemAtURL_ToURL_Error_XHandle, srcUrl__handle__, dstUrl__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selCopyItemAtURL_ToURL_Error_XHandle, srcUrl__handle__, dstUrl__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (srcUrl);
			GC.KeepAlive (dstUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("createDirectoryAtPath:withIntermediateDirectories:attributes:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool CreateDirectory (string path, bool createIntermediates, NSDictionary? attributes, out NSError error)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var attributes__handle__ = attributes.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			var nspath = CFString.CreateNative (path);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_bool_NativeHandle_ref_NativeHandle (this.Handle, selCreateDirectoryAtPath_WithIntermediateDirectories_Attributes_Error_XHandle, nspath, createIntermediates ? (byte) 1 : (byte) 0, attributes__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_bool_NativeHandle_ref_NativeHandle (&__objc_super__, selCreateDirectoryAtPath_WithIntermediateDirectories_Attributes_Error_XHandle, nspath, createIntermediates ? (byte) 1 : (byte) 0, attributes__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributes);
			CFString.ReleaseNative (nspath);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("createDirectoryAtURL:withIntermediateDirectories:attributes:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool CreateDirectory (NSUrl url, bool createIntermediates, NSDictionary? attributes, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var attributes__handle__ = attributes.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_bool_NativeHandle_ref_NativeHandle (this.Handle, selCreateDirectoryAtURL_WithIntermediateDirectories_Attributes_Error_XHandle, url__handle__, createIntermediates ? (byte) 1 : (byte) 0, attributes__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_bool_NativeHandle_ref_NativeHandle (&__objc_super__, selCreateDirectoryAtURL_WithIntermediateDirectories_Attributes_Error_XHandle, url__handle__, createIntermediates ? (byte) 1 : (byte) 0, attributes__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (attributes);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("createFileAtPath:contents:attributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CreateFile (string path, NSData data, NSDictionary? attr)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var attr__handle__ = attr.GetHandle ();
			var nspath = CFString.CreateNative (path);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selCreateFileAtPath_Contents_Attributes_XHandle, nspath, data__handle__, attr__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selCreateFileAtPath_Contents_Attributes_XHandle, nspath, data__handle__, attr__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			GC.KeepAlive (attr);
			CFString.ReleaseNative (nspath);
			return ret != 0;
		}
		[Export ("createSymbolicLinkAtPath:withDestinationPath:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool CreateSymbolicLink (string path, string destPath, out NSError error)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			if (destPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (destPath));
			NativeHandle errorValue = IntPtr.Zero;
			var nspath = CFString.CreateNative (path);
			var nsdestPath = CFString.CreateNative (destPath);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selCreateSymbolicLinkAtPath_WithDestinationPath_Error_XHandle, nspath, nsdestPath, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selCreateSymbolicLinkAtPath_WithDestinationPath_Error_XHandle, nspath, nsdestPath, &errorValue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			CFString.ReleaseNative (nsdestPath);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("createSymbolicLinkAtURL:withDestinationURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool CreateSymbolicLink (NSUrl url, NSUrl destURL, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var destURL__handle__ = destURL!.GetNonNullHandle (nameof (destURL));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selCreateSymbolicLinkAtURL_WithDestinationURL_Error_XHandle, url__handle__, destURL__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selCreateSymbolicLinkAtURL_WithDestinationURL_Error_XHandle, url__handle__, destURL__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (destURL);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("displayNameAtPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DisplayName (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDisplayNameAtPath_XHandle, nspath), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDisplayNameAtPath_XHandle, nspath), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			return ret!;
		}
		[Export ("evictUbiquitousItemAtURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool EvictUbiquitous (NSUrl url, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selEvictUbiquitousItemAtURL_Error_XHandle, url__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selEvictUbiquitousItemAtURL_Error_XHandle, url__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("fetchLatestRemoteVersionOfItemAtURL:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchLatestRemoteVersionOfItem (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileManagerFetchLatestRemoteVersionOfItemHandler))]NSFileManagerFetchLatestRemoteVersionOfItemHandler completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSFileManagerFetchLatestRemoteVersionOfItemHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFetchLatestRemoteVersionOfItemAtURL_CompletionHandler_XHandle, url__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFetchLatestRemoteVersionOfItemAtURL_CompletionHandler_XHandle, url__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSFileVersion> FetchLatestRemoteVersionOfItemAsync (NSUrl url)
		{
			var tcs = new TaskCompletionSource<NSFileVersion> ();
			FetchLatestRemoteVersionOfItem(url, (latestRemoteVersion_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (latestRemoteVersion_!);
			});
			return tcs.Task;
		}
		[Export ("fileExistsAtPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool FileExists (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selFileExistsAtPath_XHandle, nspath);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selFileExistsAtPath_XHandle, nspath);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			return ret != 0;
		}
		[Export ("fileExistsAtPath:isDirectory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool FileExists (string path, ref bool isDirectory)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			fixed (bool* isDirectory__pointer = &isDirectory) {
			var nspath = CFString.CreateNative (path);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_Boolean (this.Handle, selFileExistsAtPath_IsDirectory_XHandle, nspath, (byte*) isDirectory__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_Boolean (&__objc_super__, selFileExistsAtPath_IsDirectory_XHandle, nspath, (byte*) isDirectory__pointer);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			return ret != 0;
			}
		}
		/// <param name="authorization">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileManagerWithAuthorization:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFileManager FromAuthorization (global::AppKit.NSWorkspaceAuthorization authorization)
		{
			var authorization__handle__ = authorization!.GetNonNullHandle (nameof (authorization));
			NSFileManager? ret;
			ret =  Runtime.GetNSObject<NSFileManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFileManagerWithAuthorization_XHandle, authorization__handle__), false)!;
			GC.KeepAlive (authorization);
			return ret!;
		}
		[Export ("containerURLForSecurityApplicationGroupIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl GetContainerUrl (string securityApplicationGroupIdentifier)
		{
			if (securityApplicationGroupIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (securityApplicationGroupIdentifier));
			var nssecurityApplicationGroupIdentifier = CFString.CreateNative (securityApplicationGroupIdentifier);
			NSUrl? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selContainerURLForSecurityApplicationGroupIdentifier_XHandle, nssecurityApplicationGroupIdentifier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selContainerURLForSecurityApplicationGroupIdentifier_XHandle, nssecurityApplicationGroupIdentifier), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nssecurityApplicationGroupIdentifier);
			return ret!;
		}
		[Export ("currentDirectoryPath")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetCurrentDirectory ()
		{
			string ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentDirectoryPathXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentDirectoryPathXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("contentsOfDirectoryAtPath:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual string[] GetDirectoryContent (string path, out NSError error)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			NativeHandle errorValue = IntPtr.Zero;
			var nspath = CFString.CreateNative (path);
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selContentsOfDirectoryAtPath_Error_XHandle, nspath, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selContentsOfDirectoryAtPath_Error_XHandle, nspath, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("contentsOfDirectoryAtURL:includingPropertiesForKeys:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSUrl[] GetDirectoryContent (NSUrl url, NSArray? properties, NSDirectoryEnumerationOptions options, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var properties__handle__ = properties.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			NSUrl[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_ref_NativeHandle (this.Handle, selContentsOfDirectoryAtURL_IncludingPropertiesForKeys_Options_Error_XHandle, url__handle__, properties__handle__, (UIntPtr) (ulong) options, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_ref_NativeHandle (&__objc_super__, selContentsOfDirectoryAtURL_IncludingPropertiesForKeys_Options_Error_XHandle, url__handle__, properties__handle__, (UIntPtr) (ulong) options, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (properties);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("subpathsOfDirectoryAtPath:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual string[] GetDirectoryContentRecursive (string path, out NSError error)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			NativeHandle errorValue = IntPtr.Zero;
			var nspath = CFString.CreateNative (path);
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selSubpathsOfDirectoryAtPath_Error_XHandle, nspath, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selSubpathsOfDirectoryAtPath_Error_XHandle, nspath, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("enumeratorAtPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDirectoryEnumerator GetEnumerator (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			NSDirectoryEnumerator? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDirectoryEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selEnumeratorAtPath_XHandle, nspath), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDirectoryEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selEnumeratorAtPath_XHandle, nspath), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			return ret!;
		}
		[Export ("enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDirectoryEnumerator GetEnumerator (NSUrl url, NSString[]? keys, NSDirectoryEnumerationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSEnumerateErrorHandler))]NSEnumerateErrorHandler? handler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			using var nsa_keys = keys is null ? null : NSArray.FromNSObjects (keys);
			using var block_handler = Trampolines.SDNSEnumerateErrorHandler.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			NSDirectoryEnumerator? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDirectoryEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle (this.Handle, selEnumeratorAtURL_IncludingPropertiesForKeys_Options_ErrorHandler_XHandle, url__handle__, nsa_keys.GetHandle (), (UIntPtr) (ulong) options, (IntPtr) block_ptr_handler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDirectoryEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selEnumeratorAtURL_IncludingPropertiesForKeys_Options_ErrorHandler_XHandle, url__handle__, nsa_keys.GetHandle (), (UIntPtr) (ulong) options, (IntPtr) block_ptr_handler), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("getFileProviderServicesForItemAtURL:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetFileProviderServices (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V76))]global::System.Action<NSDictionary<NSString, NSFileProviderService>, NSError> completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V76.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selGetFileProviderServicesForItemAtURL_CompletionHandler_XHandle, url__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selGetFileProviderServicesForItemAtURL_CompletionHandler_XHandle, url__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		/// <param name="url">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous GetFileProviderServices operation.  The value of the TResult parameter is of type System.Action&lt;Foundation.NSDictionary&lt;Foundation.NSString,Foundation.NSFileProviderService&gt;,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The GetFileProviderServicesAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSDictionary<NSString, NSFileProviderService>> GetFileProviderServicesAsync (NSUrl url)
		{
			var tcs = new TaskCompletionSource<NSDictionary<NSString, NSFileProviderService>> ();
			GetFileProviderServices(url, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("mountedVolumeURLsIncludingResourceValuesForKeys:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl[] GetMountedVolumes (NSArray? properties, NSVolumeEnumerationOptions options)
		{
			var properties__handle__ = properties.GetHandle ();
			NSUrl[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selMountedVolumeURLsIncludingResourceValuesForKeys_Options_XHandle, properties__handle__, (UIntPtr) (ulong) options), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selMountedVolumeURLsIncludingResourceValuesForKeys_Options_XHandle, properties__handle__, (UIntPtr) (ulong) options), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (properties);
			return ret!;
		}
		[Export ("getRelationship:ofDirectory:inDomain:toItemAtURL:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool GetRelationship (out NSUrlRelationship outRelationship, NSSearchPathDirectory directory, NSSearchPathDomain domain, NSUrl toItemAtUrl, out NSError error)
		{
			var toItemAtUrl__handle__ = toItemAtUrl!.GetNonNullHandle (nameof (toItemAtUrl));
			fixed (NSUrlRelationship* outRelationship__pointer = &outRelationship) {
			NativeHandle errorValue = IntPtr.Zero;
			outRelationship = default;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_out_NSUrlRelationship_UIntPtr_UIntPtr_NativeHandle_ref_NativeHandle (this.Handle, selGetRelationship_OfDirectory_InDomain_ToItemAtURL_Error_XHandle, outRelationship__pointer, (UIntPtr) (ulong) directory, (UIntPtr) (ulong) domain, toItemAtUrl__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_out_NSUrlRelationship_UIntPtr_UIntPtr_NativeHandle_ref_NativeHandle (&__objc_super__, selGetRelationship_OfDirectory_InDomain_ToItemAtURL_Error_XHandle, outRelationship__pointer, (UIntPtr) (ulong) directory, (UIntPtr) (ulong) domain, toItemAtUrl__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (toItemAtUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
			}
		}
		[Export ("getRelationship:ofDirectoryAtURL:toItemAtURL:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool GetRelationship (out NSUrlRelationship outRelationship, NSUrl directoryURL, NSUrl otherURL, out NSError error)
		{
			var directoryURL__handle__ = directoryURL!.GetNonNullHandle (nameof (directoryURL));
			var otherURL__handle__ = otherURL!.GetNonNullHandle (nameof (otherURL));
			fixed (NSUrlRelationship* outRelationship__pointer = &outRelationship) {
			NativeHandle errorValue = IntPtr.Zero;
			outRelationship = default;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_out_NSUrlRelationship_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selGetRelationship_OfDirectoryAtURL_ToItemAtURL_Error_XHandle, outRelationship__pointer, directoryURL__handle__, otherURL__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_out_NSUrlRelationship_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selGetRelationship_OfDirectoryAtURL_ToItemAtURL_Error_XHandle, outRelationship__pointer, directoryURL__handle__, otherURL__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (directoryURL);
			GC.KeepAlive (otherURL);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
			}
		}
		[Export ("destinationOfSymbolicLinkAtPath:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual string GetSymbolicLinkDestination (string path, out NSError error)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			NativeHandle errorValue = IntPtr.Zero;
			var nspath = CFString.CreateNative (path);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selDestinationOfSymbolicLinkAtPath_Error_XHandle, nspath, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selDestinationOfSymbolicLinkAtPath_Error_XHandle, nspath, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("URLForDirectory:inDomain:appropriateForURL:create:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSUrl GetUrl (NSSearchPathDirectory directory, NSSearchPathDomain domain, NSUrl? url, bool shouldCreate, out NSError error)
		{
			var url__handle__ = url.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			NSUrl? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_NativeHandle_bool_ref_NativeHandle (this.Handle, selURLForDirectory_InDomain_AppropriateForURL_Create_Error_XHandle, (UIntPtr) (ulong) directory, (UIntPtr) (ulong) domain, url__handle__, shouldCreate ? (byte) 1 : (byte) 0, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_UIntPtr_NativeHandle_bool_ref_NativeHandle (&__objc_super__, selURLForDirectory_InDomain_AppropriateForURL_Create_Error_XHandle, (UIntPtr) (ulong) directory, (UIntPtr) (ulong) domain, url__handle__, shouldCreate ? (byte) 1 : (byte) 0, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("URLForPublishingUbiquitousItemAtURL:expirationDate:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSUrl GetUrlForPublishingUbiquitousItem (NSUrl url, out NSDate expirationDate, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle expirationDateValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			NSUrl? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle_ref_NativeHandle (this.Handle, selURLForPublishingUbiquitousItemAtURL_ExpirationDate_Error_XHandle, url__handle__, &expirationDateValue, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle_ref_NativeHandle (&__objc_super__, selURLForPublishingUbiquitousItemAtURL_ExpirationDate_Error_XHandle, url__handle__, &expirationDateValue, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			expirationDate = Runtime.GetNSObject<NSDate> (expirationDateValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("URLForUbiquityContainerIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl GetUrlForUbiquityContainer (string? containerIdentifier)
		{
			var nscontainerIdentifier = CFString.CreateNative (containerIdentifier);
			NSUrl? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selURLForUbiquityContainerIdentifier_XHandle, nscontainerIdentifier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selURLForUbiquityContainerIdentifier_XHandle, nscontainerIdentifier), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscontainerIdentifier);
			return ret!;
		}
		[Export ("URLsForDirectory:inDomains:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl[] GetUrls (NSSearchPathDirectory directory, NSSearchPathDomain domains)
		{
			NSUrl[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (this.Handle, selURLsForDirectory_InDomains_XHandle, (UIntPtr) (ulong) directory, (UIntPtr) (ulong) domains), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, selURLsForDirectory_InDomains_XHandle, (UIntPtr) (ulong) directory, (UIntPtr) (ulong) domains), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("isDeletableFileAtPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsDeletableFile (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsDeletableFileAtPath_XHandle, nspath);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsDeletableFileAtPath_XHandle, nspath);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			return ret != 0;
		}
		[Export ("isExecutableFileAtPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsExecutableFile (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsExecutableFileAtPath_XHandle, nspath);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsExecutableFileAtPath_XHandle, nspath);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			return ret != 0;
		}
		[Export ("isReadableFileAtPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsReadableFile (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsReadableFileAtPath_XHandle, nspath);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsReadableFileAtPath_XHandle, nspath);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			return ret != 0;
		}
		[Export ("isUbiquitousItemAtURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsUbiquitous (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsUbiquitousItemAtURL_XHandle, url__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsUbiquitousItemAtURL_XHandle, url__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			return ret != 0;
		}
		[Export ("isWritableFileAtPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsWritableFile (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsWritableFileAtPath_XHandle, nspath);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsWritableFileAtPath_XHandle, nspath);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			return ret != 0;
		}
		[Export ("linkItemAtPath:toPath:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Link (string srcPath, string dstPath, out NSError error)
		{
			if (srcPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (srcPath));
			if (dstPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dstPath));
			NativeHandle errorValue = IntPtr.Zero;
			var nssrcPath = CFString.CreateNative (srcPath);
			var nsdstPath = CFString.CreateNative (dstPath);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selLinkItemAtPath_ToPath_Error_XHandle, nssrcPath, nsdstPath, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selLinkItemAtPath_ToPath_Error_XHandle, nssrcPath, nsdstPath, &errorValue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nssrcPath);
			CFString.ReleaseNative (nsdstPath);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("linkItemAtURL:toURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Link (NSUrl srcUrl, NSUrl dstUrl, out NSError error)
		{
			var srcUrl__handle__ = srcUrl!.GetNonNullHandle (nameof (srcUrl));
			var dstUrl__handle__ = dstUrl!.GetNonNullHandle (nameof (dstUrl));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selLinkItemAtURL_ToURL_Error_XHandle, srcUrl__handle__, dstUrl__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selLinkItemAtURL_ToURL_Error_XHandle, srcUrl__handle__, dstUrl__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (srcUrl);
			GC.KeepAlive (dstUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("moveItemAtPath:toPath:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Move (string srcPath, string dstPath, out NSError error)
		{
			if (srcPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (srcPath));
			if (dstPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dstPath));
			NativeHandle errorValue = IntPtr.Zero;
			var nssrcPath = CFString.CreateNative (srcPath);
			var nsdstPath = CFString.CreateNative (dstPath);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selMoveItemAtPath_ToPath_Error_XHandle, nssrcPath, nsdstPath, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selMoveItemAtPath_ToPath_Error_XHandle, nssrcPath, nsdstPath, &errorValue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nssrcPath);
			CFString.ReleaseNative (nsdstPath);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("moveItemAtURL:toURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Move (NSUrl srcUrl, NSUrl dstUrl, out NSError error)
		{
			var srcUrl__handle__ = srcUrl!.GetNonNullHandle (nameof (srcUrl));
			var dstUrl__handle__ = dstUrl!.GetNonNullHandle (nameof (dstUrl));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selMoveItemAtURL_ToURL_Error_XHandle, srcUrl__handle__, dstUrl__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selMoveItemAtURL_ToURL_Error_XHandle, srcUrl__handle__, dstUrl__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (srcUrl);
			GC.KeepAlive (dstUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("pauseSyncForUbiquitousItemAtURL:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PauseSyncForUbiquitousItem (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileManagerSyncForUbiquitousItemHandler))]NSFileManagerSyncForUbiquitousItemHandler completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSFileManagerSyncForUbiquitousItemHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPauseSyncForUbiquitousItemAtURL_CompletionHandler_XHandle, url__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPauseSyncForUbiquitousItemAtURL_CompletionHandler_XHandle, url__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task PauseSyncForUbiquitousItemAsync (NSUrl url)
		{
			var tcs = new TaskCompletionSource<bool> ();
			PauseSyncForUbiquitousItem(url, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("removeItemAtPath:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Remove (string? path, out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			var nspath = CFString.CreateNative (path);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selRemoveItemAtPath_Error_XHandle, nspath, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selRemoveItemAtPath_Error_XHandle, nspath, &errorValue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("removeItemAtURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Remove (NSUrl? url, out NSError error)
		{
			var url__handle__ = url.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selRemoveItemAtURL_Error_XHandle, url__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selRemoveItemAtURL_Error_XHandle, url__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("replaceItemAtURL:withItemAtURL:backupItemName:options:resultingItemURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Replace (NSUrl originalItem, NSUrl newItem, string? backupItemName, NSFileManagerItemReplacementOptions options, out NSUrl resultingURL, out NSError error)
		{
			var originalItem__handle__ = originalItem!.GetNonNullHandle (nameof (originalItem));
			var newItem__handle__ = newItem!.GetNonNullHandle (nameof (newItem));
			NativeHandle resultingURLValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			var nsbackupItemName = CFString.CreateNative (backupItemName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_ref_NativeHandle_ref_NativeHandle (this.Handle, selReplaceItemAtURL_WithItemAtURL_BackupItemName_Options_ResultingItemURL_Error_XHandle, originalItem__handle__, newItem__handle__, nsbackupItemName, (UIntPtr) (ulong) options, &resultingURLValue, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_UIntPtr_ref_NativeHandle_ref_NativeHandle (&__objc_super__, selReplaceItemAtURL_WithItemAtURL_BackupItemName_Options_ResultingItemURL_Error_XHandle, originalItem__handle__, newItem__handle__, nsbackupItemName, (UIntPtr) (ulong) options, &resultingURLValue, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (originalItem);
			GC.KeepAlive (newItem);
			CFString.ReleaseNative (nsbackupItemName);
			resultingURL = Runtime.GetNSObject<NSUrl> (resultingURLValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("resumeSyncForUbiquitousItemAtURL:withBehavior:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResumeSyncForUbiquitousItem (NSUrl url, NSFileManagerResumeSyncBehavior behavior, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileManagerSyncForUbiquitousItemHandler))]NSFileManagerSyncForUbiquitousItemHandler completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSFileManagerSyncForUbiquitousItemHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (this.Handle, selResumeSyncForUbiquitousItemAtURL_WithBehavior_CompletionHandler_XHandle, url__handle__, (IntPtr) (long) behavior, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_NativeHandle (&__objc_super__, selResumeSyncForUbiquitousItemAtURL_WithBehavior_CompletionHandler_XHandle, url__handle__, (IntPtr) (long) behavior, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task ResumeSyncForUbiquitousItemAsync (NSUrl url, NSFileManagerResumeSyncBehavior behavior)
		{
			var tcs = new TaskCompletionSource<bool> ();
			ResumeSyncForUbiquitousItem(url, behavior, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("setAttributes:ofItemAtPath:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetAttributes (NSDictionary attributes, string path, out NSError error)
		{
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			NativeHandle errorValue = IntPtr.Zero;
			var nspath = CFString.CreateNative (path);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selSetAttributes_OfItemAtPath_Error_XHandle, attributes__handle__, nspath, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selSetAttributes_OfItemAtPath_Error_XHandle, attributes__handle__, nspath, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributes);
			CFString.ReleaseNative (nspath);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("setUbiquitous:itemAtURL:destinationURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetUbiquitous (bool flag, NSUrl url, NSUrl destinationUrl, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var destinationUrl__handle__ = destinationUrl!.GetNonNullHandle (nameof (destinationUrl));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_bool_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selSetUbiquitous_ItemAtURL_DestinationURL_Error_XHandle, flag ? (byte) 1 : (byte) 0, url__handle__, destinationUrl__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_bool_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selSetUbiquitous_ItemAtURL_DestinationURL_Error_XHandle, flag ? (byte) 1 : (byte) 0, url__handle__, destinationUrl__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (destinationUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("startDownloadingUbiquitousItemAtURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool StartDownloadingUbiquitous (NSUrl url, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selStartDownloadingUbiquitousItemAtURL_Error_XHandle, url__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selStartDownloadingUbiquitousItemAtURL_Error_XHandle, url__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("subpathsAtPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] Subpaths (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selSubpathsAtPath_XHandle, nspath), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selSubpathsAtPath_XHandle, nspath), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			return ret!;
		}
		[Export ("trashItemAtURL:resultingItemURL:error:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool TrashItem (NSUrl url, out NSUrl resultingItemUrl, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle resultingItemUrlValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle_ref_NativeHandle (this.Handle, selTrashItemAtURL_ResultingItemURL_Error_XHandle, url__handle__, &resultingItemUrlValue, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle_ref_NativeHandle (&__objc_super__, selTrashItemAtURL_ResultingItemURL_Error_XHandle, url__handle__, &resultingItemUrlValue, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			resultingItemUrl = Runtime.GetNSObject<NSUrl> (resultingItemUrlValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("unmountVolumeAtURL:options:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void UnmountVolume (NSUrl url, NSFileManagerUnmountOptions mask, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, selUnmountVolumeAtURL_Options_CompletionHandler_XHandle, url__handle__, (UIntPtr) (ulong) mask, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selUnmountVolumeAtURL_Options_CompletionHandler_XHandle, url__handle__, (UIntPtr) (ulong) mask, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		/// <param name="url">To be added.</param>
		/// <param name="mask">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task UnmountVolumeAsync (NSUrl url, NSFileManagerUnmountOptions mask)
		{
			var tcs = new TaskCompletionSource<bool> ();
			UnmountVolume(url, mask, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("uploadLocalVersionOfUbiquitousItemAtURL:withConflictResolutionPolicy:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void UploadLocalVersionOfUbiquitousItem (NSUrl url, NSFileManagerUploadLocalVersionConflictPolicy conflictResolutionPolicy, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileManagerUploadLocalVersionOfUbiquitousItemHandler))]NSFileManagerUploadLocalVersionOfUbiquitousItemHandler completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSFileManagerUploadLocalVersionOfUbiquitousItemHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (this.Handle, selUploadLocalVersionOfUbiquitousItemAtURL_WithConflictResolutionPolicy_CompletionHandler_XHandle, url__handle__, (IntPtr) (long) conflictResolutionPolicy, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_NativeHandle (&__objc_super__, selUploadLocalVersionOfUbiquitousItemAtURL_WithConflictResolutionPolicy_CompletionHandler_XHandle, url__handle__, (IntPtr) (long) conflictResolutionPolicy, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSFileVersion> UploadLocalVersionOfUbiquitousItemAsync (NSUrl url, NSFileManagerUploadLocalVersionConflictPolicy conflictResolutionPolicy)
		{
			var tcs = new TaskCompletionSource<NSFileVersion> ();
			UploadLocalVersionOfUbiquitousItem(url, conflictResolutionPolicy, (uploadedVersion_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (uploadedVersion_!);
			});
			return tcs.Task;
		}
		[Export ("attributesOfItemAtPath:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual NSDictionary _GetAttributes (string path, out NSError error)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			NativeHandle errorValue = IntPtr.Zero;
			var nspath = CFString.CreateNative (path);
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selAttributesOfItemAtPath_Error_XHandle, nspath, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selAttributesOfItemAtPath_Error_XHandle, nspath, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("attributesOfFileSystemForPath:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual NSDictionary _GetFileSystemAttributes (string path, out NSError error)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			NativeHandle errorValue = IntPtr.Zero;
			var nspath = CFString.CreateNative (path);
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selAttributesOfFileSystemForPath_Error_XHandle, nspath, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selAttributesOfFileSystemForPath_Error_XHandle, nspath, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFileManager DefaultManager {
			[Export ("defaultManager", ArgumentSemantic.Retain)]
			get {
				NSFileManager? ret;
				ret =  Runtime.GetNSObject<NSFileManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDefaultManagerXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>An instance of the Foundation.INSFileManagerDelegate model class which acts as the class delegate.</summary><value>The instance of the Foundation.INSFileManagerDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSFileManagerDelegate? Delegate {
			get {
				return (WeakDelegate as INSFileManagerDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject UbiquityIdentityToken {
			[Export ("ubiquityIdentityToken")]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUbiquityIdentityTokenXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUbiquityIdentityTokenXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
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
		static NSString? _AppendOnly;
		/// <summary>Represents the value associated with the constant NSFileAppendOnly</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileAppendOnly",  "Foundation")]
		public static NSString AppendOnly {
			get {
				if (_AppendOnly is null)
					_AppendOnly = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileAppendOnly")!;
				return _AppendOnly;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Busy;
		/// <summary>Represents the value associated with the constant NSFileBusy</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileBusy",  "Foundation")]
		public static NSString Busy {
			get {
				if (_Busy is null)
					_Busy = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileBusy")!;
				return _Busy;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreationDate;
		/// <summary>Represents the value associated with the constant NSFileCreationDate</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileCreationDate",  "Foundation")]
		public static NSString CreationDate {
			get {
				if (_CreationDate is null)
					_CreationDate = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileCreationDate")!;
				return _CreationDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DeviceIdentifier;
		/// <summary>Represents the value associated with the constant NSFileDeviceIdentifier</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileDeviceIdentifier",  "Foundation")]
		public static NSString DeviceIdentifier {
			get {
				if (_DeviceIdentifier is null)
					_DeviceIdentifier = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileDeviceIdentifier")!;
				return _DeviceIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtensionHidden;
		/// <summary>Represents the value associated with the constant NSFileExtensionHidden</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileExtensionHidden",  "Foundation")]
		public static NSString ExtensionHidden {
			get {
				if (_ExtensionHidden is null)
					_ExtensionHidden = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileExtensionHidden")!;
				return _ExtensionHidden;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileProtectionComplete;
		/// <summary>Represents the value associated with the constant NSFileProtectionComplete</summary><value></value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSFileProtectionType' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSFileProtectionComplete",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString FileProtectionComplete {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_FileProtectionComplete is null)
					_FileProtectionComplete = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileProtectionComplete")!;
				return _FileProtectionComplete;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileProtectionCompleteUnlessOpen;
		/// <summary>Represents the value associated with the constant NSFileProtectionCompleteUnlessOpen</summary><value></value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSFileProtectionType' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSFileProtectionCompleteUnlessOpen",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString FileProtectionCompleteUnlessOpen {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_FileProtectionCompleteUnlessOpen is null)
					_FileProtectionCompleteUnlessOpen = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileProtectionCompleteUnlessOpen")!;
				return _FileProtectionCompleteUnlessOpen;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileProtectionCompleteUntilFirstUserAuthentication;
		/// <summary>Represents the value associated with the constant NSFileProtectionCompleteUntilFirstUserAuthentication</summary><value></value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSFileProtectionType' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSFileProtectionCompleteUntilFirstUserAuthentication",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString FileProtectionCompleteUntilFirstUserAuthentication {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_FileProtectionCompleteUntilFirstUserAuthentication is null)
					_FileProtectionCompleteUntilFirstUserAuthentication = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileProtectionCompleteUntilFirstUserAuthentication")!;
				return _FileProtectionCompleteUntilFirstUserAuthentication;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileProtectionKey;
		/// <summary>Represents the value associated with the constant NSFileProtectionKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileProtectionKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString FileProtectionKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_FileProtectionKey is null)
					_FileProtectionKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileProtectionKey")!;
				return _FileProtectionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileProtectionNone;
		/// <summary>Represents the value associated with the constant NSFileProtectionNone</summary><value></value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSFileProtectionType' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSFileProtectionNone",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString FileProtectionNone {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_FileProtectionNone is null)
					_FileProtectionNone = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileProtectionNone")!;
				return _FileProtectionNone;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupOwnerAccountID;
		/// <summary>Represents the value associated with the constant NSFileGroupOwnerAccountID</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileGroupOwnerAccountID",  "Foundation")]
		public static NSString GroupOwnerAccountID {
			get {
				if (_GroupOwnerAccountID is null)
					_GroupOwnerAccountID = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileGroupOwnerAccountID")!;
				return _GroupOwnerAccountID;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupOwnerAccountName;
		/// <summary>Represents the value associated with the constant NSFileGroupOwnerAccountName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileGroupOwnerAccountName",  "Foundation")]
		public static NSString GroupOwnerAccountName {
			get {
				if (_GroupOwnerAccountName is null)
					_GroupOwnerAccountName = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileGroupOwnerAccountName")!;
				return _GroupOwnerAccountName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HfsCreatorCode;
		/// <summary>Represents the value associated with the constant NSFileHFSCreatorCode</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileHFSCreatorCode",  "Foundation")]
		public static NSString HfsCreatorCode {
			get {
				if (_HfsCreatorCode is null)
					_HfsCreatorCode = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileHFSCreatorCode")!;
				return _HfsCreatorCode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HfsTypeCode;
		/// <summary>Represents the value associated with the constant NSFileHFSTypeCode</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileHFSTypeCode",  "Foundation")]
		public static NSString HfsTypeCode {
			get {
				if (_HfsTypeCode is null)
					_HfsTypeCode = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileHFSTypeCode")!;
				return _HfsTypeCode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Immutable;
		/// <summary>Represents the value associated with the constant NSFileImmutable</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileImmutable",  "Foundation")]
		public static NSString Immutable {
			get {
				if (_Immutable is null)
					_Immutable = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileImmutable")!;
				return _Immutable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ModificationDate;
		/// <summary>Represents the value associated with the constant NSFileModificationDate</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileModificationDate",  "Foundation")]
		public static NSString ModificationDate {
			get {
				if (_ModificationDate is null)
					_ModificationDate = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileModificationDate")!;
				return _ModificationDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSFileType;
		/// <summary>Represents the value associated with the constant NSFileType</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileType",  "Foundation")]
		public static NSString NSFileType {
			get {
				if (_NSFileType is null)
					_NSFileType = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileType")!;
				return _NSFileType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OwnerAccountID;
		/// <summary>Represents the value associated with the constant NSFileOwnerAccountID</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileOwnerAccountID",  "Foundation")]
		public static NSString OwnerAccountID {
			get {
				if (_OwnerAccountID is null)
					_OwnerAccountID = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileOwnerAccountID")!;
				return _OwnerAccountID;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OwnerAccountName;
		/// <summary>Represents the value associated with the constant NSFileOwnerAccountName</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileOwnerAccountName",  "Foundation")]
		public static NSString OwnerAccountName {
			get {
				if (_OwnerAccountName is null)
					_OwnerAccountName = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileOwnerAccountName")!;
				return _OwnerAccountName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PosixPermissions;
		/// <summary>Represents the value associated with the constant NSFilePosixPermissions</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFilePosixPermissions",  "Foundation")]
		public static NSString PosixPermissions {
			get {
				if (_PosixPermissions is null)
					_PosixPermissions = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFilePosixPermissions")!;
				return _PosixPermissions;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReferenceCount;
		/// <summary>Represents the value associated with the constant NSFileReferenceCount</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileReferenceCount",  "Foundation")]
		public static NSString ReferenceCount {
			get {
				if (_ReferenceCount is null)
					_ReferenceCount = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileReferenceCount")!;
				return _ReferenceCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Size;
		/// <summary>Represents the value associated with the constant NSFileSize</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileSize",  "Foundation")]
		public static NSString Size {
			get {
				if (_Size is null)
					_Size = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileSize")!;
				return _Size;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SystemFileNumber;
		/// <summary>Represents the value associated with the constant NSFileSystemFileNumber</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileSystemFileNumber",  "Foundation")]
		public static NSString SystemFileNumber {
			get {
				if (_SystemFileNumber is null)
					_SystemFileNumber = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileSystemFileNumber")!;
				return _SystemFileNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SystemFreeNodes;
		/// <summary>Represents the value associated with the constant NSFileSystemFreeNodes</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileSystemFreeNodes",  "Foundation")]
		public static NSString SystemFreeNodes {
			get {
				if (_SystemFreeNodes is null)
					_SystemFreeNodes = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileSystemFreeNodes")!;
				return _SystemFreeNodes;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SystemFreeSize;
		/// <summary>Represents the value associated with the constant NSFileSystemFreeSize</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileSystemFreeSize",  "Foundation")]
		public static NSString SystemFreeSize {
			get {
				if (_SystemFreeSize is null)
					_SystemFreeSize = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileSystemFreeSize")!;
				return _SystemFreeSize;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SystemNodes;
		/// <summary>Represents the value associated with the constant NSFileSystemNodes</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileSystemNodes",  "Foundation")]
		public static NSString SystemNodes {
			get {
				if (_SystemNodes is null)
					_SystemNodes = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileSystemNodes")!;
				return _SystemNodes;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SystemNumber;
		/// <summary>Represents the value associated with the constant NSFileSystemNumber</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileSystemNumber",  "Foundation")]
		public static NSString SystemNumber {
			get {
				if (_SystemNumber is null)
					_SystemNumber = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileSystemNumber")!;
				return _SystemNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SystemSize;
		/// <summary>Represents the value associated with the constant NSFileSystemSize</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileSystemSize",  "Foundation")]
		public static NSString SystemSize {
			get {
				if (_SystemSize is null)
					_SystemSize = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileSystemSize")!;
				return _SystemSize;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeBlockSpecial;
		/// <summary>Represents the value associated with the constant NSFileTypeBlockSpecial</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileTypeBlockSpecial",  "Foundation")]
		public static NSString TypeBlockSpecial {
			get {
				if (_TypeBlockSpecial is null)
					_TypeBlockSpecial = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileTypeBlockSpecial")!;
				return _TypeBlockSpecial;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeCharacterSpecial;
		/// <summary>Represents the value associated with the constant NSFileTypeCharacterSpecial</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileTypeCharacterSpecial",  "Foundation")]
		public static NSString TypeCharacterSpecial {
			get {
				if (_TypeCharacterSpecial is null)
					_TypeCharacterSpecial = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileTypeCharacterSpecial")!;
				return _TypeCharacterSpecial;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeDirectory;
		/// <summary>Represents the value associated with the constant NSFileTypeDirectory</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileTypeDirectory",  "Foundation")]
		public static NSString TypeDirectory {
			get {
				if (_TypeDirectory is null)
					_TypeDirectory = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileTypeDirectory")!;
				return _TypeDirectory;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeRegular;
		/// <summary>Represents the value associated with the constant NSFileTypeRegular</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileTypeRegular",  "Foundation")]
		public static NSString TypeRegular {
			get {
				if (_TypeRegular is null)
					_TypeRegular = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileTypeRegular")!;
				return _TypeRegular;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeSocket;
		/// <summary>Represents the value associated with the constant NSFileTypeSocket</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileTypeSocket",  "Foundation")]
		public static NSString TypeSocket {
			get {
				if (_TypeSocket is null)
					_TypeSocket = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileTypeSocket")!;
				return _TypeSocket;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeSymbolicLink;
		/// <summary>Represents the value associated with the constant NSFileTypeSymbolicLink</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileTypeSymbolicLink",  "Foundation")]
		public static NSString TypeSymbolicLink {
			get {
				if (_TypeSymbolicLink is null)
					_TypeSymbolicLink = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileTypeSymbolicLink")!;
				return _TypeSymbolicLink;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeUnknown;
		/// <summary>Represents the value associated with the constant NSFileTypeUnknown</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSFileTypeUnknown",  "Foundation")]
		public static NSString TypeUnknown {
			get {
				if (_TypeUnknown is null)
					_TypeUnknown = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFileTypeUnknown")!;
				return _TypeUnknown;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquityIdentityDidChangeNotification;
		/// <summary>Notification constant for UbiquityIdentityDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveUbiquityIdentityDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveUbiquityIdentityDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSFileManager.Notifications.ObserveUbiquityIdentityDidChange ((sender, args) => {
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
		/// void Callback (object sender, NSFileManager.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSFileManager.Notifications.ObserveUbiquityIdentityDidChange (Callback);
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
		///     NSFileManager.UbiquityIdentityDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification UbiquityIdentityDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification UbiquityIdentityDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSFileManager.UbiquityIdentityDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSUbiquityIdentityDidChangeNotification",  "Foundation")]
		[Advice ("Use NSFileManager.Notifications.ObserveUbiquityIdentityDidChange helper method instead.")]
		public static NSString UbiquityIdentityDidChangeNotification {
			get {
				if (_UbiquityIdentityDidChangeNotification is null)
					_UbiquityIdentityDidChangeNotification = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSUbiquityIdentityDidChangeNotification")!;
				return _UbiquityIdentityDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::Foundation.NSFileManager" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSFileManager.UbiquityIdentityDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSFileManager.UbiquityIdentityDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSFileManager.Notifications.ObserveUbiquityIdentityDidChange ((notification) => {
			///   Console.WriteLine ("Observed UbiquityIdentityDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveUbiquityIdentityDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (UbiquityIdentityDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSFileManager.UbiquityIdentityDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSFileManager.UbiquityIdentityDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSFileManager.Notifications.ObserveUbiquityIdentityDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed UbiquityIdentityDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveUbiquityIdentityDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (UbiquityIdentityDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSFileManager */
}
