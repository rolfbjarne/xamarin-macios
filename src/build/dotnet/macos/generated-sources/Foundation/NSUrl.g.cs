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
	[Register("NSURL", true)]
	public unsafe partial class NSUrl : NSObject, INSCoding, INSCopying, INSItemProviderReading, INSItemProviderWriting, INSSecureCoding, global::AppKit.INSPasteboardReading, global::AppKit.INSPasteboardWriting, global::QuickLookUI.IQLPreviewItem {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLByAppendingPathComponent_IsDirectory_X = "URLByAppendingPathComponent:isDirectory:";
		static readonly NativeHandle selURLByAppendingPathComponent_IsDirectory_XHandle = Selector.GetHandle ("URLByAppendingPathComponent:isDirectory:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLByAppendingPathExtension_X = "URLByAppendingPathExtension:";
		static readonly NativeHandle selURLByAppendingPathExtension_XHandle = Selector.GetHandle ("URLByAppendingPathExtension:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLByDeletingLastPathComponentX = "URLByDeletingLastPathComponent";
		static readonly NativeHandle selURLByDeletingLastPathComponentXHandle = Selector.GetHandle ("URLByDeletingLastPathComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLByDeletingPathExtensionX = "URLByDeletingPathExtension";
		static readonly NativeHandle selURLByDeletingPathExtensionXHandle = Selector.GetHandle ("URLByDeletingPathExtension");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLByResolvingAliasFileAtURL_Options_Error_X = "URLByResolvingAliasFileAtURL:options:error:";
		static readonly NativeHandle selURLByResolvingAliasFileAtURL_Options_Error_XHandle = Selector.GetHandle ("URLByResolvingAliasFileAtURL:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLByResolvingBookmarkData_Options_RelativeToURL_BookmarkDataIsStale_Error_X = "URLByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:";
		static readonly NativeHandle selURLByResolvingBookmarkData_Options_RelativeToURL_BookmarkDataIsStale_Error_XHandle = Selector.GetHandle ("URLByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLFromPasteboard_X = "URLFromPasteboard:";
		static readonly NativeHandle selURLFromPasteboard_XHandle = Selector.GetHandle ("URLFromPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLWithDataRepresentation_RelativeToURL_X = "URLWithDataRepresentation:relativeToURL:";
		static readonly NativeHandle selURLWithDataRepresentation_RelativeToURL_XHandle = Selector.GetHandle ("URLWithDataRepresentation:relativeToURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLWithString_X = "URLWithString:";
		static readonly NativeHandle selURLWithString_XHandle = Selector.GetHandle ("URLWithString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLWithString_EncodingInvalidCharacters_X = "URLWithString:encodingInvalidCharacters:";
		static readonly NativeHandle selURLWithString_EncodingInvalidCharacters_XHandle = Selector.GetHandle ("URLWithString:encodingInvalidCharacters:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLWithString_RelativeToURL_X = "URLWithString:relativeToURL:";
		static readonly NativeHandle selURLWithString_RelativeToURL_XHandle = Selector.GetHandle ("URLWithString:relativeToURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAbsoluteStringX = "absoluteString";
		static readonly NativeHandle selAbsoluteStringXHandle = Selector.GetHandle ("absoluteString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAbsoluteURLX = "absoluteURL";
		static readonly NativeHandle selAbsoluteURLXHandle = Selector.GetHandle ("absoluteURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAbsoluteURLWithDataRepresentation_RelativeToURL_X = "absoluteURLWithDataRepresentation:relativeToURL:";
		static readonly NativeHandle selAbsoluteURLWithDataRepresentation_RelativeToURL_XHandle = Selector.GetHandle ("absoluteURLWithDataRepresentation:relativeToURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBaseURLX = "baseURL";
		static readonly NativeHandle selBaseURLXHandle = Selector.GetHandle ("baseURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBookmarkDataWithContentsOfURL_Error_X = "bookmarkDataWithContentsOfURL:error:";
		static readonly NativeHandle selBookmarkDataWithContentsOfURL_Error_XHandle = Selector.GetHandle ("bookmarkDataWithContentsOfURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBookmarkDataWithOptions_IncludingResourceValuesForKeys_RelativeToURL_Error_X = "bookmarkDataWithOptions:includingResourceValuesForKeys:relativeToURL:error:";
		static readonly NativeHandle selBookmarkDataWithOptions_IncludingResourceValuesForKeys_RelativeToURL_Error_XHandle = Selector.GetHandle ("bookmarkDataWithOptions:includingResourceValuesForKeys:relativeToURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataRepresentationX = "dataRepresentation";
		static readonly NativeHandle selDataRepresentationXHandle = Selector.GetHandle ("dataRepresentation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilePathURLX = "filePathURL";
		static readonly NativeHandle selFilePathURLXHandle = Selector.GetHandle ("filePathURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileReferenceURLX = "fileReferenceURL";
		static readonly NativeHandle selFileReferenceURLXHandle = Selector.GetHandle ("fileReferenceURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileSystemRepresentationX = "fileSystemRepresentation";
		static readonly NativeHandle selFileSystemRepresentationXHandle = Selector.GetHandle ("fileSystemRepresentation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileURLWithFileSystemRepresentation_IsDirectory_RelativeToURL_X = "fileURLWithFileSystemRepresentation:isDirectory:relativeToURL:";
		static readonly NativeHandle selFileURLWithFileSystemRepresentation_IsDirectory_RelativeToURL_XHandle = Selector.GetHandle ("fileURLWithFileSystemRepresentation:isDirectory:relativeToURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileURLWithPath_X = "fileURLWithPath:";
		static readonly NativeHandle selFileURLWithPath_XHandle = Selector.GetHandle ("fileURLWithPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileURLWithPath_IsDirectory_X = "fileURLWithPath:isDirectory:";
		static readonly NativeHandle selFileURLWithPath_IsDirectory_XHandle = Selector.GetHandle ("fileURLWithPath:isDirectory:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileURLWithPath_IsDirectory_RelativeToURL_X = "fileURLWithPath:isDirectory:relativeToURL:";
		static readonly NativeHandle selFileURLWithPath_IsDirectory_RelativeToURL_XHandle = Selector.GetHandle ("fileURLWithPath:isDirectory:relativeToURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileURLWithPath_RelativeToURL_X = "fileURLWithPath:relativeToURL:";
		static readonly NativeHandle selFileURLWithPath_RelativeToURL_XHandle = Selector.GetHandle ("fileURLWithPath:relativeToURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileURLWithPathComponents_X = "fileURLWithPathComponents:";
		static readonly NativeHandle selFileURLWithPathComponents_XHandle = Selector.GetHandle ("fileURLWithPathComponents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFragmentX = "fragment";
		static readonly NativeHandle selFragmentXHandle = Selector.GetHandle ("fragment");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetFileSystemRepresentation_MaxLength_X = "getFileSystemRepresentation:maxLength:";
		static readonly NativeHandle selGetFileSystemRepresentation_MaxLength_XHandle = Selector.GetHandle ("getFileSystemRepresentation:maxLength:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetResourceValue_ForKey_Error_X = "getResourceValue:forKey:error:";
		static readonly NativeHandle selGetResourceValue_ForKey_Error_XHandle = Selector.GetHandle ("getResourceValue:forKey:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasDirectoryPathX = "hasDirectoryPath";
		static readonly NativeHandle selHasDirectoryPathXHandle = Selector.GetHandle ("hasDirectoryPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHostX = "host";
		static readonly NativeHandle selHostXHandle = Selector.GetHandle ("host");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitByResolvingBookmarkData_Options_RelativeToURL_BookmarkDataIsStale_Error_X = "initByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:";
		static readonly NativeHandle selInitByResolvingBookmarkData_Options_RelativeToURL_BookmarkDataIsStale_Error_XHandle = Selector.GetHandle ("initByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitFileURLWithFileSystemRepresentation_IsDirectory_RelativeToURL_X = "initFileURLWithFileSystemRepresentation:isDirectory:relativeToURL:";
		static readonly NativeHandle selInitFileURLWithFileSystemRepresentation_IsDirectory_RelativeToURL_XHandle = Selector.GetHandle ("initFileURLWithFileSystemRepresentation:isDirectory:relativeToURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitFileURLWithPath_IsDirectory_X = "initFileURLWithPath:isDirectory:";
		static readonly NativeHandle selInitFileURLWithPath_IsDirectory_XHandle = Selector.GetHandle ("initFileURLWithPath:isDirectory:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitFileURLWithPath_IsDirectory_RelativeToURL_X = "initFileURLWithPath:isDirectory:relativeToURL:";
		static readonly NativeHandle selInitFileURLWithPath_IsDirectory_RelativeToURL_XHandle = Selector.GetHandle ("initFileURLWithPath:isDirectory:relativeToURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPasteboardPropertyList_OfType_X = "initWithPasteboardPropertyList:ofType:";
		static readonly NativeHandle selInitWithPasteboardPropertyList_OfType_XHandle = Selector.GetHandle ("initWithPasteboardPropertyList:ofType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithScheme_Host_Path_X = "initWithScheme:host:path:";
		static readonly NativeHandle selInitWithScheme_Host_Path_XHandle = Selector.GetHandle ("initWithScheme:host:path:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithString_X = "initWithString:";
		static readonly NativeHandle selInitWithString_XHandle = Selector.GetHandle ("initWithString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithString_RelativeToURL_X = "initWithString:relativeToURL:";
		static readonly NativeHandle selInitWithString_RelativeToURL_XHandle = Selector.GetHandle ("initWithString:relativeToURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEqual_X = "isEqual:";
		static readonly NativeHandle selIsEqual_XHandle = Selector.GetHandle ("isEqual:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFileReferenceURLX = "isFileReferenceURL";
		static readonly NativeHandle selIsFileReferenceURLXHandle = Selector.GetHandle ("isFileReferenceURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFileURLX = "isFileURL";
		static readonly NativeHandle selIsFileURLXHandle = Selector.GetHandle ("isFileURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemProviderVisibilityForRepresentationWithTypeIdentifier_X = "itemProviderVisibilityForRepresentationWithTypeIdentifier:";
		static readonly NativeHandle selItemProviderVisibilityForRepresentationWithTypeIdentifier_XHandle = Selector.GetHandle ("itemProviderVisibilityForRepresentationWithTypeIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLastPathComponentX = "lastPathComponent";
		static readonly NativeHandle selLastPathComponentXHandle = Selector.GetHandle ("lastPathComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_X = "loadDataWithTypeIdentifier:forItemProviderCompletionHandler:";
		static readonly NativeHandle selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_XHandle = Selector.GetHandle ("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectWithItemProviderData_TypeIdentifier_Error_X = "objectWithItemProviderData:typeIdentifier:error:";
		static readonly NativeHandle selObjectWithItemProviderData_TypeIdentifier_Error_XHandle = Selector.GetHandle ("objectWithItemProviderData:typeIdentifier:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParameterStringX = "parameterString";
		static readonly NativeHandle selParameterStringXHandle = Selector.GetHandle ("parameterString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPasswordX = "password";
		static readonly NativeHandle selPasswordXHandle = Selector.GetHandle ("password");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPasteboardPropertyListForType_X = "pasteboardPropertyListForType:";
		static readonly NativeHandle selPasteboardPropertyListForType_XHandle = Selector.GetHandle ("pasteboardPropertyListForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPathX = "path";
		static readonly NativeHandle selPathXHandle = Selector.GetHandle ("path");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPathComponentsX = "pathComponents";
		static readonly NativeHandle selPathComponentsXHandle = Selector.GetHandle ("pathComponents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPathExtensionX = "pathExtension";
		static readonly NativeHandle selPathExtensionXHandle = Selector.GetHandle ("pathExtension");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPortX = "port";
		static readonly NativeHandle selPortXHandle = Selector.GetHandle ("port");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreviewItemDisplayStateX = "previewItemDisplayState";
		static readonly NativeHandle selPreviewItemDisplayStateXHandle = Selector.GetHandle ("previewItemDisplayState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreviewItemTitleX = "previewItemTitle";
		static readonly NativeHandle selPreviewItemTitleXHandle = Selector.GetHandle ("previewItemTitle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreviewItemURLX = "previewItemURL";
		static readonly NativeHandle selPreviewItemURLXHandle = Selector.GetHandle ("previewItemURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQueryX = "query";
		static readonly NativeHandle selQueryXHandle = Selector.GetHandle ("query");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadableTypeIdentifiersForItemProviderX = "readableTypeIdentifiersForItemProvider";
		static readonly NativeHandle selReadableTypeIdentifiersForItemProviderXHandle = Selector.GetHandle ("readableTypeIdentifiersForItemProvider");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadableTypesForPasteboard_X = "readableTypesForPasteboard:";
		static readonly NativeHandle selReadableTypesForPasteboard_XHandle = Selector.GetHandle ("readableTypesForPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadingOptionsForType_Pasteboard_X = "readingOptionsForType:pasteboard:";
		static readonly NativeHandle selReadingOptionsForType_Pasteboard_XHandle = Selector.GetHandle ("readingOptionsForType:pasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRelativePathX = "relativePath";
		static readonly NativeHandle selRelativePathXHandle = Selector.GetHandle ("relativePath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRelativeStringX = "relativeString";
		static readonly NativeHandle selRelativeStringXHandle = Selector.GetHandle ("relativeString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllCachedResourceValuesX = "removeAllCachedResourceValues";
		static readonly NativeHandle selRemoveAllCachedResourceValuesXHandle = Selector.GetHandle ("removeAllCachedResourceValues");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveCachedResourceValueForKey_X = "removeCachedResourceValueForKey:";
		static readonly NativeHandle selRemoveCachedResourceValueForKey_XHandle = Selector.GetHandle ("removeCachedResourceValueForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResourceSpecifierX = "resourceSpecifier";
		static readonly NativeHandle selResourceSpecifierXHandle = Selector.GetHandle ("resourceSpecifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResourceValuesForKeys_Error_X = "resourceValuesForKeys:error:";
		static readonly NativeHandle selResourceValuesForKeys_Error_XHandle = Selector.GetHandle ("resourceValuesForKeys:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSchemeX = "scheme";
		static readonly NativeHandle selSchemeXHandle = Selector.GetHandle ("scheme");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetResourceValue_ForKey_Error_X = "setResourceValue:forKey:error:";
		static readonly NativeHandle selSetResourceValue_ForKey_Error_XHandle = Selector.GetHandle ("setResourceValue:forKey:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTemporaryResourceValue_ForKey_X = "setTemporaryResourceValue:forKey:";
		static readonly NativeHandle selSetTemporaryResourceValue_ForKey_XHandle = Selector.GetHandle ("setTemporaryResourceValue:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStandardizedURLX = "standardizedURL";
		static readonly NativeHandle selStandardizedURLXHandle = Selector.GetHandle ("standardizedURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartAccessingSecurityScopedResourceX = "startAccessingSecurityScopedResource";
		static readonly NativeHandle selStartAccessingSecurityScopedResourceXHandle = Selector.GetHandle ("startAccessingSecurityScopedResource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopAccessingSecurityScopedResourceX = "stopAccessingSecurityScopedResource";
		static readonly NativeHandle selStopAccessingSecurityScopedResourceXHandle = Selector.GetHandle ("stopAccessingSecurityScopedResource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserX = "user";
		static readonly NativeHandle selUserXHandle = Selector.GetHandle ("user");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWritableTypeIdentifiersForItemProviderX = "writableTypeIdentifiersForItemProvider";
		static readonly NativeHandle selWritableTypeIdentifiersForItemProviderXHandle = Selector.GetHandle ("writableTypeIdentifiersForItemProvider");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWritableTypesForPasteboard_X = "writableTypesForPasteboard:";
		static readonly NativeHandle selWritableTypesForPasteboard_XHandle = Selector.GetHandle ("writableTypesForPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteBookmarkData_ToURL_Options_Error_X = "writeBookmarkData:toURL:options:error:";
		static readonly NativeHandle selWriteBookmarkData_ToURL_Options_Error_XHandle = Selector.GetHandle ("writeBookmarkData:toURL:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteToPasteboard_X = "writeToPasteboard:";
		static readonly NativeHandle selWriteToPasteboard_XHandle = Selector.GetHandle ("writeToPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWritingOptionsForType_Pasteboard_X = "writingOptionsForType:pasteboard:";
		static readonly NativeHandle selWritingOptionsForType_Pasteboard_XHandle = Selector.GetHandle ("writingOptionsForType:pasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSURL");
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
		public NSUrl (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSUrl (NSObjectFlag t) : base (t)
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
		protected internal NSUrl (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithScheme:host:path:")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'NSUrlComponents' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'NSUrlComponents' instead.")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'NSUrlComponents' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSUrlComponents' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUrl (string scheme, string host, string path)
			: base (NSObjectFlag.Empty)
		{
			if (scheme is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (scheme));
			if (host is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (host));
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nsscheme = CFString.CreateNative (scheme);
			var nshost = CFString.CreateNative (host);
			var nspath = CFString.CreateNative (path);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithScheme_Host_Path_XHandle, nsscheme, nshost, nspath), "initWithScheme:host:path:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithScheme_Host_Path_XHandle, nsscheme, nshost, nspath), "initWithScheme:host:path:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsscheme);
			CFString.ReleaseNative (nshost);
			CFString.ReleaseNative (nspath);
		}
		[Export ("initFileURLWithPath:isDirectory:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUrl (string path, bool isDir)
			: base (NSObjectFlag.Empty)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, selInitFileURLWithPath_IsDirectory_XHandle, nspath, isDir ? (byte) 1 : (byte) 0), "initFileURLWithPath:isDirectory:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selInitFileURLWithPath_IsDirectory_XHandle, nspath, isDir ? (byte) 1 : (byte) 0), "initFileURLWithPath:isDirectory:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
		}
		[Export ("initWithString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUrl (string urlString)
			: base (NSObjectFlag.Empty)
		{
			if (urlString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urlString));
			var nsurlString = CFString.CreateNative (urlString);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithString_XHandle, nsurlString), "initWithString:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithString_XHandle, nsurlString), "initWithString:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsurlString);
		}
		[Export ("initWithString:relativeToURL:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUrl (string urlString, NSUrl relativeToUrl)
			: base (NSObjectFlag.Empty)
		{
			if (urlString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urlString));
			var relativeToUrl__handle__ = relativeToUrl!.GetNonNullHandle (nameof (relativeToUrl));
			var nsurlString = CFString.CreateNative (urlString);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithString_RelativeToURL_XHandle, nsurlString, relativeToUrl__handle__), "initWithString:relativeToURL:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithString_RelativeToURL_XHandle, nsurlString, relativeToUrl__handle__), "initWithString:relativeToURL:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (relativeToUrl);
			CFString.ReleaseNative (nsurlString);
		}
		[Export ("initFileURLWithFileSystemRepresentation:isDirectory:relativeToURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUrl (nint ptrUtf8path, bool isDir, NSUrl? baseURL)
			: base (NSObjectFlag.Empty)
		{
			var baseURL__handle__ = baseURL.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_bool_NativeHandle (this.Handle, selInitFileURLWithFileSystemRepresentation_IsDirectory_RelativeToURL_XHandle, ptrUtf8path, isDir ? (byte) 1 : (byte) 0, baseURL__handle__), "initFileURLWithFileSystemRepresentation:isDirectory:relativeToURL:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_bool_NativeHandle (&__objc_super__, selInitFileURLWithFileSystemRepresentation_IsDirectory_RelativeToURL_XHandle, ptrUtf8path, isDir ? (byte) 1 : (byte) 0, baseURL__handle__), "initFileURLWithFileSystemRepresentation:isDirectory:relativeToURL:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (baseURL);
		}
		[Export ("initByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSUrl (NSData bookmarkData, NSUrlBookmarkResolutionOptions resolutionOptions, NSUrl? relativeUrl, out bool bookmarkIsStale, out NSError error)
			: base (NSObjectFlag.Empty)
		{
			var bookmarkData__handle__ = bookmarkData!.GetNonNullHandle (nameof (bookmarkData));
			var relativeUrl__handle__ = relativeUrl.GetHandle ();
			fixed (bool* bookmarkIsStale__pointer = &bookmarkIsStale) {
			NativeHandle errorValue = IntPtr.Zero;
			bookmarkIsStale = default;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_out_Boolean_ref_NativeHandle (this.Handle, selInitByResolvingBookmarkData_Options_RelativeToURL_BookmarkDataIsStale_Error_XHandle, bookmarkData__handle__, (UIntPtr) (ulong) resolutionOptions, relativeUrl__handle__, (byte*) bookmarkIsStale__pointer, &errorValue), "initByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle_out_Boolean_ref_NativeHandle (&__objc_super__, selInitByResolvingBookmarkData_Options_RelativeToURL_BookmarkDataIsStale_Error_XHandle, bookmarkData__handle__, (UIntPtr) (ulong) resolutionOptions, relativeUrl__handle__, (byte*) bookmarkIsStale__pointer, &errorValue), "initByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (bookmarkData);
			GC.KeepAlive (relativeUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			}
		}
		[Export ("initFileURLWithPath:isDirectory:relativeToURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUrl (string path, bool isDir, NSUrl? relativeToUrl)
			: base (NSObjectFlag.Empty)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var relativeToUrl__handle__ = relativeToUrl.GetHandle ();
			var nspath = CFString.CreateNative (path);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool_NativeHandle (this.Handle, selInitFileURLWithPath_IsDirectory_RelativeToURL_XHandle, nspath, isDir ? (byte) 1 : (byte) 0, relativeToUrl__handle__), "initFileURLWithPath:isDirectory:relativeToURL:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool_NativeHandle (&__objc_super__, selInitFileURLWithPath_IsDirectory_RelativeToURL_XHandle, nspath, isDir ? (byte) 1 : (byte) 0, relativeToUrl__handle__), "initFileURLWithPath:isDirectory:relativeToURL:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (relativeToUrl);
			CFString.ReleaseNative (nspath);
		}
		[Export ("URLByAppendingPathComponent:isDirectory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl Append (string pathComponent, bool isDirectory)
		{
			if (pathComponent is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pathComponent));
			var nspathComponent = CFString.CreateNative (pathComponent);
			NSUrl? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, selURLByAppendingPathComponent_IsDirectory_XHandle, nspathComponent, isDirectory ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selURLByAppendingPathComponent_IsDirectory_XHandle, nspathComponent, isDirectory ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspathComponent);
			return ret!;
		}
		[Export ("URLByAppendingPathExtension:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl AppendPathExtension (string extension)
		{
			if (extension is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (extension));
			var nsextension = CFString.CreateNative (extension);
			NSUrl? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selURLByAppendingPathExtension_XHandle, nsextension), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selURLByAppendingPathExtension_XHandle, nsextension), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsextension);
			return ret!;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("absoluteURLWithDataRepresentation:relativeToURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl CreateAbsoluteUrlWithDataRepresentation (NSData data, NSUrl? relativeToUrl)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var relativeToUrl__handle__ = relativeToUrl.GetHandle ();
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selAbsoluteURLWithDataRepresentation_RelativeToURL_XHandle, data__handle__, relativeToUrl__handle__), false)!;
			GC.KeepAlive (data);
			GC.KeepAlive (relativeToUrl);
			return ret!;
		}
		[Export ("bookmarkDataWithOptions:includingResourceValuesForKeys:relativeToURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSData CreateBookmarkData (NSUrlBookmarkCreationOptions options, string[]? resourceValues, NSUrl? relativeUrl, out NSError error)
		{
			var relativeUrl__handle__ = relativeUrl.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_resourceValues = NSArray.FromNullableStrings (resourceValues);
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selBookmarkDataWithOptions_IncludingResourceValuesForKeys_RelativeToURL_Error_XHandle, (UIntPtr) (ulong) options, nsa_resourceValues.GetHandle (), relativeUrl__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selBookmarkDataWithOptions_IncludingResourceValuesForKeys_RelativeToURL_Error_XHandle, (UIntPtr) (ulong) options, nsa_resourceValues.GetHandle (), relativeUrl__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (relativeUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("fileURLWithPathComponents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl CreateFileUrl (string[] pathComponents)
		{
			if (pathComponents is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pathComponents));
			using var nsa_pathComponents = NSArray.FromStrings (pathComponents);
			NSUrl ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFileURLWithPathComponents_XHandle, nsa_pathComponents.Handle), false)!;
			return ret;
		}
		[Export ("fileURLWithPath:isDirectory:relativeToURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl CreateFileUrl (string path, bool isDir, NSUrl? relativeToUrl)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var relativeToUrl__handle__ = relativeToUrl.GetHandle ();
			var nspath = CFString.CreateNative (path);
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool_NativeHandle (class_ptr, selFileURLWithPath_IsDirectory_RelativeToURL_XHandle, nspath, isDir ? (byte) 1 : (byte) 0, relativeToUrl__handle__), false)!;
			GC.KeepAlive (relativeToUrl);
			CFString.ReleaseNative (nspath);
			return ret!;
		}
		[Export ("fileURLWithPath:isDirectory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl CreateFileUrl (string path, bool isDir)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (class_ptr, selFileURLWithPath_IsDirectory_XHandle, nspath, isDir ? (byte) 1 : (byte) 0), false)!;
			CFString.ReleaseNative (nspath);
			return ret!;
		}
		[Export ("fileURLWithPath:relativeToURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl CreateFileUrl (string path, NSUrl? relativeToUrl)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var relativeToUrl__handle__ = relativeToUrl.GetHandle ();
			var nspath = CFString.CreateNative (path);
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selFileURLWithPath_RelativeToURL_XHandle, nspath, relativeToUrl__handle__), false)!;
			GC.KeepAlive (relativeToUrl);
			CFString.ReleaseNative (nspath);
			return ret!;
		}
		[Export ("fileURLWithPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl CreateFileUrl (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFileURLWithPath_XHandle, nspath), false)!;
			CFString.ReleaseNative (nspath);
			return ret!;
		}
		[Export ("URLWithDataRepresentation:relativeToURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl CreateWithDataRepresentation (NSData data, NSUrl? relativeToUrl)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var relativeToUrl__handle__ = relativeToUrl.GetHandle ();
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selURLWithDataRepresentation_RelativeToURL_XHandle, data__handle__, relativeToUrl__handle__), false)!;
			GC.KeepAlive (data);
			GC.KeepAlive (relativeToUrl);
			return ret!;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[Export ("URLByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSUrl FromBookmarkData (NSData data, NSUrlBookmarkResolutionOptions options, NSUrl? relativeToUrl, out bool isStale, out NSError error)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var relativeToUrl__handle__ = relativeToUrl.GetHandle ();
			fixed (bool* isStale__pointer = &isStale) {
			NativeHandle errorValue = IntPtr.Zero;
			isStale = default;
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_out_Boolean_ref_NativeHandle (class_ptr, selURLByResolvingBookmarkData_Options_RelativeToURL_BookmarkDataIsStale_Error_XHandle, data__handle__, (UIntPtr) (ulong) options, relativeToUrl__handle__, (byte*) isStale__pointer, &errorValue), false)!;
			GC.KeepAlive (data);
			GC.KeepAlive (relativeToUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
			}
		}
		/// <param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("URLFromPasteboard:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl? FromPasteboard (global::AppKit.NSPasteboard pasteboard)
		{
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selURLFromPasteboard_XHandle, pasteboard__handle__), false)!;
			GC.KeepAlive (pasteboard);
			return ret!;
		}
		[Export ("URLWithString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl? FromString (string? s)
		{
			var nss = CFString.CreateNative (s);
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selURLWithString_XHandle, nss), false)!;
			CFString.ReleaseNative (nss);
			return ret!;
		}
		[Export ("URLWithString:encodingInvalidCharacters:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl? FromString (string url, bool encodingInvalidCharacters)
		{
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));
			var nsurl = CFString.CreateNative (url);
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (class_ptr, selURLWithString_EncodingInvalidCharacters_XHandle, nsurl, encodingInvalidCharacters ? (byte) 1 : (byte) 0), false)!;
			CFString.ReleaseNative (nsurl);
			return ret!;
		}
		[Export ("fileURLWithFileSystemRepresentation:isDirectory:relativeToURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl FromUTF8Pointer (nint ptrUtf8path, bool isDir, NSUrl? baseURL)
		{
			var baseURL__handle__ = baseURL.GetHandle ();
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_bool_NativeHandle (class_ptr, selFileURLWithFileSystemRepresentation_IsDirectory_RelativeToURL_XHandle, ptrUtf8path, isDir ? (byte) 1 : (byte) 0, baseURL__handle__), false)!;
			GC.KeepAlive (baseURL);
			return ret!;
		}
		[Export ("bookmarkDataWithContentsOfURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSData GetBookmarkData (NSUrl bookmarkFileUrl, out NSError error)
		{
			var bookmarkFileUrl__handle__ = bookmarkFileUrl!.GetNonNullHandle (nameof (bookmarkFileUrl));
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (class_ptr, selBookmarkDataWithContentsOfURL_Error_XHandle, bookmarkFileUrl__handle__, &errorValue), false)!;
			GC.KeepAlive (bookmarkFileUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("getFileSystemRepresentation:maxLength:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GetFileSystemRepresentation (nint buffer, nint maxBufferLength)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, selGetFileSystemRepresentation_MaxLength_XHandle, buffer, maxBufferLength);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selGetFileSystemRepresentation_MaxLength_XHandle, buffer, maxBufferLength);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <param name="typeIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("itemProviderVisibilityForRepresentationWithTypeIdentifier:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSItemProviderRepresentationVisibility GetItemProviderVisibilityForTypeIdentifier (string typeIdentifier)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			NSItemProviderRepresentationVisibility ret;
			if (IsDirectBinding) {
				ret = (NSItemProviderRepresentationVisibility) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selItemProviderVisibilityForRepresentationWithTypeIdentifier_XHandle, nstypeIdentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSItemProviderRepresentationVisibility) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selItemProviderVisibilityForRepresentationWithTypeIdentifier_XHandle, nstypeIdentifier);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeIdentifier);
			return ret!;
		}
		[Export ("objectWithItemProviderData:typeIdentifier:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSUrl? GetObject (NSData data, string typeIdentifier, out NSError? outError)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, selObjectWithItemProviderData_TypeIdentifier_Error_XHandle, data__handle__, nstypeIdentifier, &outErrorValue), false)!;
			GC.KeepAlive (data);
			CFString.ReleaseNative (nstypeIdentifier);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		/// <param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pasteboardPropertyListForType:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetPasteboardPropertyListForType (string type)
		{
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPasteboardPropertyListForType_XHandle, nstype), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPasteboardPropertyListForType_XHandle, nstype), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		/// <param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("readableTypesForPasteboard:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetReadableTypesForPasteboard (global::AppKit.NSPasteboard pasteboard)
		{
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selReadableTypesForPasteboard_XHandle, pasteboard__handle__), false)!;
			GC.KeepAlive (pasteboard);
			return ret!;
		}
		/// <param name="type">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("readingOptionsForType:pasteboard:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::AppKit.NSPasteboardReadingOptions GetReadingOptionsForType (string type, global::AppKit.NSPasteboard pasteboard)
		{
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			var nstype = CFString.CreateNative (type);
			global::AppKit.NSPasteboardReadingOptions ret;
			ret = (NSPasteboardReadingOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selReadingOptionsForType_Pasteboard_XHandle, nstype, pasteboard__handle__);
			GC.KeepAlive (pasteboard);
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		[Export ("getResourceValue:forKey:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual bool GetResourceValue (out NSObject value, NSString key, out NSError error)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			NativeHandle valueValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selGetResourceValue_ForKey_Error_XHandle, &valueValue, key__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selGetResourceValue_ForKey_Error_XHandle, &valueValue, key__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
			value = Runtime.GetNSObject<NSObject> (valueValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("resourceValuesForKeys:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDictionary GetResourceValues (NSString[] keys, out NSError error)
		{
			if (keys is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keys));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_keys = NSArray.FromNSObjects (keys);
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selResourceValuesForKeys_Error_XHandle, nsa_keys.Handle, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selResourceValuesForKeys_Error_XHandle, nsa_keys.Handle, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writableTypesForPasteboard:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetWritableTypesForPasteboard (global::AppKit.NSPasteboard pasteboard)
		{
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selWritableTypesForPasteboard_XHandle, pasteboard__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selWritableTypesForPasteboard_XHandle, pasteboard__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pasteboard);
			return ret!;
		}
		/// <param name="type">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writingOptionsForType:pasteboard:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSPasteboardWritingOptions GetWritingOptionsForType (string type, global::AppKit.NSPasteboard pasteboard)
		{
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			var nstype = CFString.CreateNative (type);
			global::AppKit.NSPasteboardWritingOptions ret;
			if (IsDirectBinding) {
				ret = (NSPasteboardWritingOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selWritingOptionsForType_Pasteboard_XHandle, nstype, pasteboard__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSPasteboardWritingOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selWritingOptionsForType_Pasteboard_XHandle, nstype, pasteboard__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pasteboard);
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		[Export ("isEqual:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual bool IsEqual (NSUrl? other)
		{
			var other__handle__ = other.GetHandle ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsEqual_XHandle, other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsEqual_XHandle, other__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
			return ret != 0;
		}
		/// <param name="typeIdentifier">A Universal Type Identifier (UTI) indicating the type of data to load.</param><param name="completionHandler">The method called after the data is loaded.</param><summary>Implement this method to customize the loading of data by an <see cref="T:Foundation.NSItemProvider" />.</summary><returns>An <see cref="T:Foundation.NSProgress" /> object reflecting the data-loading operation.</returns><remarks><para>The <paramref name="typeIdentifier" /> must be in the set of values returned by <see cref="Foundation.NSItemProviderWriting_Extensions.GetWritableTypeIdentifiersForItemProvider(Foundation.INSItemProviderWriting)" />.</para></remarks>
		[Export ("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress? LoadData (string typeIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V16))]global::System.Action<NSData, NSError> completionHandler)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			using var block_completionHandler = Trampolines.SDActionArity2V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_XHandle, nstypeIdentifier, (IntPtr) block_ptr_completionHandler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_XHandle, nstypeIdentifier, (IntPtr) block_ptr_completionHandler), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeIdentifier);
			return ret!;
		}
		/// <param name="typeIdentifier">A Universal Type Identifier (UTI) indicating the type of data to load.</param>
		/// <summary>Asynchronously loads data for the identified type from an item provider, returning a task that contains the data.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> LoadDataAsync (string typeIdentifier)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			LoadData(typeIdentifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> LoadDataAsync (string typeIdentifier, out NSProgress result)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			result = LoadData(typeIdentifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			})!;
			return tcs.Task;
		}
		[Export ("removeAllCachedResourceValues")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllCachedResourceValues ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveAllCachedResourceValuesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveAllCachedResourceValuesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeCachedResourceValueForKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveCachedResourceValueForKey (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveCachedResourceValueForKey_XHandle, key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveCachedResourceValueForKey_XHandle, key__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
		}
		[Export ("URLByDeletingLastPathComponent")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl RemoveLastPathComponent ()
		{
			NSUrl ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selURLByDeletingLastPathComponentXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selURLByDeletingLastPathComponentXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("URLByDeletingPathExtension")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl RemovePathExtension ()
		{
			NSUrl ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selURLByDeletingPathExtensionXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selURLByDeletingPathExtensionXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("URLByResolvingAliasFileAtURL:options:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSUrl ResolveAlias (NSUrl aliasFileUrl, NSUrlBookmarkResolutionOptions options, out NSError error)
		{
			var aliasFileUrl__handle__ = aliasFileUrl!.GetNonNullHandle (nameof (aliasFileUrl));
			NativeHandle errorValue = IntPtr.Zero;
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle (class_ptr, selURLByResolvingAliasFileAtURL_Options_Error_XHandle, aliasFileUrl__handle__, (UIntPtr) (ulong) options, &errorValue), false)!;
			GC.KeepAlive (aliasFileUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("setResourceValue:forKey:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual bool SetResourceValue (NSObject value, NSString key, out NSError error)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selSetResourceValue_ForKey_Error_XHandle, value__handle__, key__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selSetResourceValue_ForKey_Error_XHandle, value__handle__, key__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			GC.KeepAlive (key);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("setTemporaryResourceValue:forKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTemporaryResourceValue (NSObject value, NSString key)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetTemporaryResourceValue_ForKey_XHandle, value__handle__, key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetTemporaryResourceValue_ForKey_XHandle, value__handle__, key__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			GC.KeepAlive (key);
		}
		[Export ("startAccessingSecurityScopedResource")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool StartAccessingSecurityScopedResource ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selStartAccessingSecurityScopedResourceXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selStartAccessingSecurityScopedResourceXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("stopAccessingSecurityScopedResource")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopAccessingSecurityScopedResource ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopAccessingSecurityScopedResourceXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopAccessingSecurityScopedResourceXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("writeBookmarkData:toURL:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool WriteBookmarkData (NSData data, NSUrl bookmarkFileUrl, NSUrlBookmarkCreationOptions options, out NSError error)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var bookmarkFileUrl__handle__ = bookmarkFileUrl!.GetNonNullHandle (nameof (bookmarkFileUrl));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_ref_NativeHandle (class_ptr, selWriteBookmarkData_ToURL_Options_Error_XHandle, data__handle__, bookmarkFileUrl__handle__, (UIntPtr) (ulong) options, &errorValue);
			GC.KeepAlive (data);
			GC.KeepAlive (bookmarkFileUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="pasteboard">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("writeToPasteboard:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteToPasteboard (global::AppKit.NSPasteboard pasteboard)
		{
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selWriteToPasteboard_XHandle, pasteboard__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selWriteToPasteboard_XHandle, pasteboard__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pasteboard);
		}
		[Export ("URLWithString:relativeToURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSUrl _FromStringRelative (string url, NSUrl relative)
		{
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));
			var relative__handle__ = relative!.GetNonNullHandle (nameof (relative));
			var nsurl = CFString.CreateNative (url);
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selURLWithString_RelativeToURL_XHandle, nsurl, relative__handle__), false)!;
			GC.KeepAlive (relative);
			CFString.ReleaseNative (nsurl);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? AbsoluteString {
			[Export ("absoluteString")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAbsoluteStringXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAbsoluteStringXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? AbsoluteUrl {
			[Export ("absoluteURL")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAbsoluteURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAbsoluteURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? BaseUrl {
			[Export ("baseURL")]
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
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSData DataRepresentation {
			[Export ("dataRepresentation", ArgumentSemantic.Copy)]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDataRepresentationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDataRepresentationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? FilePathUrl {
			[Export ("filePathURL")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFilePathURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFilePathURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? FileReferenceUrl {
			[Export ("fileReferenceURL")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFileReferenceURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFileReferenceURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Fragment {
			[Export ("fragment")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFragmentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFragmentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nint GetFileSystemRepresentationAsUtf8Ptr {
			[Export ("fileSystemRepresentation")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFileSystemRepresentationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selFileSystemRepresentationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool HasDirectoryPath {
			[Export ("hasDirectoryPath")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasDirectoryPathXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasDirectoryPathXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Host {
			[Export ("host")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHostXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHostXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsFileReferenceUrl {
			[Export ("isFileReferenceURL")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFileReferenceURLXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsFileReferenceURLXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Whether this NSUrl uses the file scheme.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsFileUrl {
			[Export ("isFileURL")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFileURLXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsFileURLXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? LastPathComponent {
			[Export ("lastPathComponent")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLastPathComponentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLastPathComponentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.15", "Always return 'null'. Use and parse 'Path' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Always return 'null'. Use and parse 'Path' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Always return 'null'. Use and parse 'Path' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Always return 'null'. Use and parse 'Path' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string? ParameterString {
			[Export ("parameterString")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selParameterStringXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selParameterStringXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Password {
			[Export ("password")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPasswordXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPasswordXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Path {
			[Export ("path")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? PathComponents {
			[Export ("pathComponents")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPathComponentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPathComponentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? PathExtension {
			[Export ("pathExtension")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPathExtensionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPathExtensionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSNumber? PortNumber {
			[Export ("port")]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPortXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPortXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject PreviewItemDisplayState {
			[Export ("previewItemDisplayState")]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreviewItemDisplayStateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreviewItemDisplayStateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string PreviewItemTitle {
			[Export ("previewItemTitle")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreviewItemTitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreviewItemTitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl PreviewItemUrl {
			[Export ("previewItemURL")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreviewItemURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreviewItemURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Query {
			[Export ("query")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selQueryXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selQueryXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static string[] ReadableTypeIdentifiers {
			[Export ("readableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selReadableTypeIdentifiersForItemProviderXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? RelativePath {
			[Export ("relativePath")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRelativePathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRelativePathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string RelativeString {
			[Export ("relativeString")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRelativeStringXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRelativeStringXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ResourceSpecifier {
			[Export ("resourceSpecifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selResourceSpecifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selResourceSpecifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Scheme {
			[Export ("scheme")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSchemeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSchemeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? StandardizedUrl {
			[Export ("standardizedURL")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStandardizedURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStandardizedURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? User {
			[Export ("user")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUserXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUserXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static string[] WritableTypeIdentifiers {
			[Export ("writableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selWritableTypeIdentifiersForItemProviderXHandle), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual string[] WritableTypeIdentifiersForItemProvider {
			[Export ("writableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWritableTypeIdentifiersForItemProviderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWritableTypeIdentifiersForItemProviderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AddedToDirectoryDateKey;
		/// <summary>Represents the value associated with the constant NSURLAddedToDirectoryDateKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLAddedToDirectoryDateKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AddedToDirectoryDateKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AddedToDirectoryDateKey is null)
					_AddedToDirectoryDateKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLAddedToDirectoryDateKey")!;
				return _AddedToDirectoryDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AttributeModificationDateKey;
		/// <summary>Represents the value associated with the constant NSURLAttributeModificationDateKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLAttributeModificationDateKey",  "Foundation")]
		public static NSString AttributeModificationDateKey {
			get {
				if (_AttributeModificationDateKey is null)
					_AttributeModificationDateKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLAttributeModificationDateKey")!;
				return _AttributeModificationDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentAccessDateKey;
		/// <summary>Represents the value associated with the constant NSURLContentAccessDateKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLContentAccessDateKey",  "Foundation")]
		public static NSString ContentAccessDateKey {
			get {
				if (_ContentAccessDateKey is null)
					_ContentAccessDateKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLContentAccessDateKey")!;
				return _ContentAccessDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentModificationDateKey;
		/// <summary>Represents the value associated with the constant NSURLContentModificationDateKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLContentModificationDateKey",  "Foundation")]
		public static NSString ContentModificationDateKey {
			get {
				if (_ContentModificationDateKey is null)
					_ContentModificationDateKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLContentModificationDateKey")!;
				return _ContentModificationDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentTypeKey;
		/// <summary>Represents the value associated with the constant 'NSURLContentTypeKey'.</summary>
		[Field ("NSURLContentTypeKey",  "Foundation")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ContentTypeKey {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ContentTypeKey is null)
					_ContentTypeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLContentTypeKey")!;
				return _ContentTypeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreationDateKey;
		/// <summary>Represents the value associated with the constant NSURLCreationDateKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLCreationDateKey",  "Foundation")]
		public static NSString CreationDateKey {
			get {
				if (_CreationDateKey is null)
					_CreationDateKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLCreationDateKey")!;
				return _CreationDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CustomIconKey;
		/// <summary>Represents the value associated with the constant NSURLCustomIconKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLCustomIconKey",  "Foundation")]
		public static NSString CustomIconKey {
			get {
				if (_CustomIconKey is null)
					_CustomIconKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLCustomIconKey")!;
				return _CustomIconKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DirectoryEntryCountKey;
		/// <summary>Represents the value associated with the constant 'NSURLDirectoryEntryCountKey'.</summary>
		[Field ("NSURLDirectoryEntryCountKey",  "Foundation")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString DirectoryEntryCountKey {
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_DirectoryEntryCountKey is null)
					_DirectoryEntryCountKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLDirectoryEntryCountKey")!;
				return _DirectoryEntryCountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DocumentIdentifierKey;
		/// <summary>Represents the value associated with the constant NSURLDocumentIdentifierKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLDocumentIdentifierKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DocumentIdentifierKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DocumentIdentifierKey is null)
					_DocumentIdentifierKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLDocumentIdentifierKey")!;
				return _DocumentIdentifierKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EffectiveIconKey;
		/// <summary>Represents the value associated with the constant NSURLEffectiveIconKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLEffectiveIconKey",  "Foundation")]
		public static NSString EffectiveIconKey {
			get {
				if (_EffectiveIconKey is null)
					_EffectiveIconKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLEffectiveIconKey")!;
				return _EffectiveIconKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileAllocatedSizeKey;
		/// <summary>Represents the value associated with the constant NSURLFileAllocatedSizeKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLFileAllocatedSizeKey",  "Foundation")]
		public static NSString FileAllocatedSizeKey {
			get {
				if (_FileAllocatedSizeKey is null)
					_FileAllocatedSizeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileAllocatedSizeKey")!;
				return _FileAllocatedSizeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileContentIdentifierKey;
		/// <summary>Represents the value associated with the constant 'NSURLFileContentIdentifierKey'.</summary>
		[Field ("NSURLFileContentIdentifierKey",  "Foundation")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString FileContentIdentifierKey {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FileContentIdentifierKey is null)
					_FileContentIdentifierKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileContentIdentifierKey")!;
				return _FileContentIdentifierKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileIdentifierKey;
		/// <summary>Represents the value associated with the constant 'NSURLFileIdentifierKey'.</summary>
		[Field ("NSURLFileIdentifierKey",  "Foundation")]
		[SupportedOSPlatform ("tvos16.4")]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		public static NSString FileIdentifierKey {
			[SupportedOSPlatform ("tvos16.4")]
			[SupportedOSPlatform ("macos13.3")]
			[SupportedOSPlatform ("ios16.4")]
			[SupportedOSPlatform ("maccatalyst16.4")]
			get {
				if (_FileIdentifierKey is null)
					_FileIdentifierKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileIdentifierKey")!;
				return _FileIdentifierKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileProtectionComplete;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLFileProtectionComplete",  "Foundation")]
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
					_FileProtectionComplete = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileProtectionComplete")!;
				return _FileProtectionComplete;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileProtectionCompleteUnlessOpen;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLFileProtectionCompleteUnlessOpen",  "Foundation")]
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
					_FileProtectionCompleteUnlessOpen = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileProtectionCompleteUnlessOpen")!;
				return _FileProtectionCompleteUnlessOpen;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileProtectionCompleteUntilFirstUserAuthentication;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLFileProtectionCompleteUntilFirstUserAuthentication",  "Foundation")]
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
					_FileProtectionCompleteUntilFirstUserAuthentication = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileProtectionCompleteUntilFirstUserAuthentication")!;
				return _FileProtectionCompleteUntilFirstUserAuthentication;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileProtectionKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLFileProtectionKey",  "Foundation")]
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
					_FileProtectionKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileProtectionKey")!;
				return _FileProtectionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileProtectionNone;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLFileProtectionNone",  "Foundation")]
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
					_FileProtectionNone = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileProtectionNone")!;
				return _FileProtectionNone;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileResourceIdentifierKey;
		/// <summary>Represents the value associated with the constant NSURLFileResourceIdentifierKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLFileResourceIdentifierKey",  "Foundation")]
		public static NSString FileResourceIdentifierKey {
			get {
				if (_FileResourceIdentifierKey is null)
					_FileResourceIdentifierKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileResourceIdentifierKey")!;
				return _FileResourceIdentifierKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileResourceTypeBlockSpecial;
		/// <summary>Represents the value associated with the constant NSURLFileResourceTypeBlockSpecial</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLFileResourceTypeBlockSpecial",  "Foundation")]
		public static NSString FileResourceTypeBlockSpecial {
			get {
				if (_FileResourceTypeBlockSpecial is null)
					_FileResourceTypeBlockSpecial = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileResourceTypeBlockSpecial")!;
				return _FileResourceTypeBlockSpecial;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileResourceTypeCharacterSpecial;
		/// <summary>Represents the value associated with the constant NSURLFileResourceTypeCharacterSpecial</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLFileResourceTypeCharacterSpecial",  "Foundation")]
		public static NSString FileResourceTypeCharacterSpecial {
			get {
				if (_FileResourceTypeCharacterSpecial is null)
					_FileResourceTypeCharacterSpecial = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileResourceTypeCharacterSpecial")!;
				return _FileResourceTypeCharacterSpecial;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileResourceTypeDirectory;
		/// <summary>Represents the value associated with the constant NSURLFileResourceTypeDirectory</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLFileResourceTypeDirectory",  "Foundation")]
		public static NSString FileResourceTypeDirectory {
			get {
				if (_FileResourceTypeDirectory is null)
					_FileResourceTypeDirectory = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileResourceTypeDirectory")!;
				return _FileResourceTypeDirectory;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileResourceTypeKey;
		/// <summary>Represents the value associated with the constant NSURLFileResourceTypeKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLFileResourceTypeKey",  "Foundation")]
		public static NSString FileResourceTypeKey {
			get {
				if (_FileResourceTypeKey is null)
					_FileResourceTypeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileResourceTypeKey")!;
				return _FileResourceTypeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileResourceTypeNamedPipe;
		/// <summary>Represents the value associated with the constant NSURLFileResourceTypeNamedPipe</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLFileResourceTypeNamedPipe",  "Foundation")]
		public static NSString FileResourceTypeNamedPipe {
			get {
				if (_FileResourceTypeNamedPipe is null)
					_FileResourceTypeNamedPipe = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileResourceTypeNamedPipe")!;
				return _FileResourceTypeNamedPipe;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileResourceTypeRegular;
		/// <summary>Represents the value associated with the constant NSURLFileResourceTypeRegular</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLFileResourceTypeRegular",  "Foundation")]
		public static NSString FileResourceTypeRegular {
			get {
				if (_FileResourceTypeRegular is null)
					_FileResourceTypeRegular = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileResourceTypeRegular")!;
				return _FileResourceTypeRegular;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileResourceTypeSocket;
		/// <summary>Represents the value associated with the constant NSURLFileResourceTypeSocket</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLFileResourceTypeSocket",  "Foundation")]
		public static NSString FileResourceTypeSocket {
			get {
				if (_FileResourceTypeSocket is null)
					_FileResourceTypeSocket = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileResourceTypeSocket")!;
				return _FileResourceTypeSocket;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileResourceTypeSymbolicLink;
		/// <summary>Represents the value associated with the constant NSURLFileResourceTypeSymbolicLink</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLFileResourceTypeSymbolicLink",  "Foundation")]
		public static NSString FileResourceTypeSymbolicLink {
			get {
				if (_FileResourceTypeSymbolicLink is null)
					_FileResourceTypeSymbolicLink = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileResourceTypeSymbolicLink")!;
				return _FileResourceTypeSymbolicLink;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileResourceTypeUnknown;
		/// <summary>Represents the value associated with the constant NSURLFileResourceTypeUnknown</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLFileResourceTypeUnknown",  "Foundation")]
		public static NSString FileResourceTypeUnknown {
			get {
				if (_FileResourceTypeUnknown is null)
					_FileResourceTypeUnknown = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileResourceTypeUnknown")!;
				return _FileResourceTypeUnknown;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileSecurityKey;
		/// <summary>Represents the value associated with the constant NSURLFileSecurityKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLFileSecurityKey",  "Foundation")]
		public static NSString FileSecurityKey {
			get {
				if (_FileSecurityKey is null)
					_FileSecurityKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileSecurityKey")!;
				return _FileSecurityKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileSizeKey;
		/// <summary>Represents the value associated with the constant NSURLFileSizeKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLFileSizeKey",  "Foundation")]
		public static NSString FileSizeKey {
			get {
				if (_FileSizeKey is null)
					_FileSizeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLFileSizeKey")!;
				return _FileSizeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GenerationIdentifierKey;
		/// <summary>Represents the value associated with the constant NSURLGenerationIdentifierKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLGenerationIdentifierKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString GenerationIdentifierKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_GenerationIdentifierKey is null)
					_GenerationIdentifierKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLGenerationIdentifierKey")!;
				return _GenerationIdentifierKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HasHiddenExtensionKey;
		/// <summary>Represents the value associated with the constant NSURLHasHiddenExtensionKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLHasHiddenExtensionKey",  "Foundation")]
		public static NSString HasHiddenExtensionKey {
			get {
				if (_HasHiddenExtensionKey is null)
					_HasHiddenExtensionKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLHasHiddenExtensionKey")!;
				return _HasHiddenExtensionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsAliasFileKey;
		/// <summary>Represents the value associated with the constant NSURLIsAliasFileKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLIsAliasFileKey",  "Foundation")]
		public static NSString IsAliasFileKey {
			get {
				if (_IsAliasFileKey is null)
					_IsAliasFileKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLIsAliasFileKey")!;
				return _IsAliasFileKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsApplicationKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLIsApplicationKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IsApplicationKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IsApplicationKey is null)
					_IsApplicationKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLIsApplicationKey")!;
				return _IsApplicationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsDirectoryKey;
		/// <summary>Represents the value associated with the constant NSURLIsDirectoryKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLIsDirectoryKey",  "Foundation")]
		public static NSString IsDirectoryKey {
			get {
				if (_IsDirectoryKey is null)
					_IsDirectoryKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLIsDirectoryKey")!;
				return _IsDirectoryKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsExcludedFromBackupKey;
		/// <summary>Represents the value associated with the constant NSURLIsExcludedFromBackupKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLIsExcludedFromBackupKey",  "Foundation")]
		public static NSString IsExcludedFromBackupKey {
			get {
				if (_IsExcludedFromBackupKey is null)
					_IsExcludedFromBackupKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLIsExcludedFromBackupKey")!;
				return _IsExcludedFromBackupKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsExecutableKey;
		/// <summary>Represents the value associated with the constant NSURLIsExecutableKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLIsExecutableKey",  "Foundation")]
		public static NSString IsExecutableKey {
			get {
				if (_IsExecutableKey is null)
					_IsExecutableKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLIsExecutableKey")!;
				return _IsExecutableKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsHiddenKey;
		/// <summary>Represents the value associated with the constant NSURLIsHiddenKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLIsHiddenKey",  "Foundation")]
		public static NSString IsHiddenKey {
			get {
				if (_IsHiddenKey is null)
					_IsHiddenKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLIsHiddenKey")!;
				return _IsHiddenKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsMountTriggerKey;
		/// <summary>Represents the value associated with the constant NSURLIsMountTriggerKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLIsMountTriggerKey",  "Foundation")]
		public static NSString IsMountTriggerKey {
			get {
				if (_IsMountTriggerKey is null)
					_IsMountTriggerKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLIsMountTriggerKey")!;
				return _IsMountTriggerKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsPackageKey;
		/// <summary>Represents the value associated with the constant NSURLIsPackageKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLIsPackageKey",  "Foundation")]
		public static NSString IsPackageKey {
			get {
				if (_IsPackageKey is null)
					_IsPackageKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLIsPackageKey")!;
				return _IsPackageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsPurgeableKey;
		/// <summary>Represents the value associated with the constant 'NSURLIsPurgeableKey'.</summary>
		[Field ("NSURLIsPurgeableKey",  "Foundation")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString IsPurgeableKey {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_IsPurgeableKey is null)
					_IsPurgeableKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLIsPurgeableKey")!;
				return _IsPurgeableKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsReadableKey;
		/// <summary>Represents the value associated with the constant NSURLIsReadableKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLIsReadableKey",  "Foundation")]
		public static NSString IsReadableKey {
			get {
				if (_IsReadableKey is null)
					_IsReadableKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLIsReadableKey")!;
				return _IsReadableKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsRegularFileKey;
		/// <summary>Represents the value associated with the constant NSURLIsRegularFileKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLIsRegularFileKey",  "Foundation")]
		public static NSString IsRegularFileKey {
			get {
				if (_IsRegularFileKey is null)
					_IsRegularFileKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLIsRegularFileKey")!;
				return _IsRegularFileKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsSparseKey;
		/// <summary>Represents the value associated with the constant 'NSURLIsSparseKey'.</summary>
		[Field ("NSURLIsSparseKey",  "Foundation")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString IsSparseKey {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_IsSparseKey is null)
					_IsSparseKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLIsSparseKey")!;
				return _IsSparseKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsSymbolicLinkKey;
		/// <summary>Represents the value associated with the constant NSURLIsSymbolicLinkKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLIsSymbolicLinkKey",  "Foundation")]
		public static NSString IsSymbolicLinkKey {
			get {
				if (_IsSymbolicLinkKey is null)
					_IsSymbolicLinkKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLIsSymbolicLinkKey")!;
				return _IsSymbolicLinkKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsSystemImmutableKey;
		/// <summary>Represents the value associated with the constant NSURLIsSystemImmutableKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLIsSystemImmutableKey",  "Foundation")]
		public static NSString IsSystemImmutableKey {
			get {
				if (_IsSystemImmutableKey is null)
					_IsSystemImmutableKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLIsSystemImmutableKey")!;
				return _IsSystemImmutableKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsUbiquitousItemKey;
		/// <summary>Represents the value associated with the constant NSURLIsUbiquitousItemKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLIsUbiquitousItemKey",  "Foundation")]
		public static NSString IsUbiquitousItemKey {
			get {
				if (_IsUbiquitousItemKey is null)
					_IsUbiquitousItemKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLIsUbiquitousItemKey")!;
				return _IsUbiquitousItemKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsUserImmutableKey;
		/// <summary>Represents the value associated with the constant NSURLIsUserImmutableKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLIsUserImmutableKey",  "Foundation")]
		public static NSString IsUserImmutableKey {
			get {
				if (_IsUserImmutableKey is null)
					_IsUserImmutableKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLIsUserImmutableKey")!;
				return _IsUserImmutableKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsVolumeKey;
		/// <summary>Represents the value associated with the constant NSURLIsVolumeKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLIsVolumeKey",  "Foundation")]
		public static NSString IsVolumeKey {
			get {
				if (_IsVolumeKey is null)
					_IsVolumeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLIsVolumeKey")!;
				return _IsVolumeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsWritableKey;
		/// <summary>Represents the value associated with the constant NSURLIsWritableKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLIsWritableKey",  "Foundation")]
		public static NSString IsWritableKey {
			get {
				if (_IsWritableKey is null)
					_IsWritableKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLIsWritableKey")!;
				return _IsWritableKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeysOfUnsetValuesKey;
		/// <summary>Represents the value associated with the constant NSURLKeysOfUnsetValuesKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLKeysOfUnsetValuesKey",  "Foundation")]
		public static NSString KeysOfUnsetValuesKey {
			get {
				if (_KeysOfUnsetValuesKey is null)
					_KeysOfUnsetValuesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLKeysOfUnsetValuesKey")!;
				return _KeysOfUnsetValuesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LabelColorKey;
		/// <summary>Represents the value associated with the constant NSURLLabelColorKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLLabelColorKey",  "Foundation")]
		public static NSString LabelColorKey {
			get {
				if (_LabelColorKey is null)
					_LabelColorKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLLabelColorKey")!;
				return _LabelColorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LabelNumberKey;
		/// <summary>Represents the value associated with the constant NSURLLabelNumberKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLLabelNumberKey",  "Foundation")]
		public static NSString LabelNumberKey {
			get {
				if (_LabelNumberKey is null)
					_LabelNumberKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLLabelNumberKey")!;
				return _LabelNumberKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LinkCountKey;
		/// <summary>Represents the value associated with the constant NSURLLinkCountKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLLinkCountKey",  "Foundation")]
		public static NSString LinkCountKey {
			get {
				if (_LinkCountKey is null)
					_LinkCountKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLLinkCountKey")!;
				return _LinkCountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LocalizedLabelKey;
		/// <summary>Represents the value associated with the constant NSURLLocalizedLabelKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLLocalizedLabelKey",  "Foundation")]
		public static NSString LocalizedLabelKey {
			get {
				if (_LocalizedLabelKey is null)
					_LocalizedLabelKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLLocalizedLabelKey")!;
				return _LocalizedLabelKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LocalizedNameKey;
		/// <summary>Represents the value associated with the constant NSURLLocalizedNameKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLLocalizedNameKey",  "Foundation")]
		public static NSString LocalizedNameKey {
			get {
				if (_LocalizedNameKey is null)
					_LocalizedNameKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLLocalizedNameKey")!;
				return _LocalizedNameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LocalizedTypeDescriptionKey;
		/// <summary>Represents the value associated with the constant NSURLLocalizedTypeDescriptionKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLLocalizedTypeDescriptionKey",  "Foundation")]
		public static NSString LocalizedTypeDescriptionKey {
			get {
				if (_LocalizedTypeDescriptionKey is null)
					_LocalizedTypeDescriptionKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLLocalizedTypeDescriptionKey")!;
				return _LocalizedTypeDescriptionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MayHaveExtendedAttributesKey;
		/// <summary>Represents the value associated with the constant 'NSURLMayHaveExtendedAttributesKey'.</summary>
		[Field ("NSURLMayHaveExtendedAttributesKey",  "Foundation")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MayHaveExtendedAttributesKey {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MayHaveExtendedAttributesKey is null)
					_MayHaveExtendedAttributesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLMayHaveExtendedAttributesKey")!;
				return _MayHaveExtendedAttributesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MayShareFileContentKey;
		/// <summary>Represents the value associated with the constant 'NSURLMayShareFileContentKey'.</summary>
		[Field ("NSURLMayShareFileContentKey",  "Foundation")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MayShareFileContentKey {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MayShareFileContentKey is null)
					_MayShareFileContentKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLMayShareFileContentKey")!;
				return _MayShareFileContentKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NameKey;
		/// <summary>Represents the value associated with the constant NSURLNameKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLNameKey",  "Foundation")]
		public static NSString NameKey {
			get {
				if (_NameKey is null)
					_NameKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLNameKey")!;
				return _NameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParentDirectoryURLKey;
		/// <summary>Represents the value associated with the constant NSURLParentDirectoryURLKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLParentDirectoryURLKey",  "Foundation")]
		public static NSString ParentDirectoryURLKey {
			get {
				if (_ParentDirectoryURLKey is null)
					_ParentDirectoryURLKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLParentDirectoryURLKey")!;
				return _ParentDirectoryURLKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PathKey;
		/// <summary>Represents the value associated with the constant NSURLPathKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLPathKey",  "Foundation")]
		public static NSString PathKey {
			get {
				if (_PathKey is null)
					_PathKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLPathKey")!;
				return _PathKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PreferredIOBlockSizeKey;
		/// <summary>Represents the value associated with the constant NSURLPreferredIOBlockSizeKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLPreferredIOBlockSizeKey",  "Foundation")]
		public static NSString PreferredIOBlockSizeKey {
			get {
				if (_PreferredIOBlockSizeKey is null)
					_PreferredIOBlockSizeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLPreferredIOBlockSizeKey")!;
				return _PreferredIOBlockSizeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ThumbnailDictionaryKey;
		/// <summary>Represents the value associated with the constant NSURLThumbnailDictionaryKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLThumbnailDictionaryKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ThumbnailDictionaryKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ThumbnailDictionaryKey is null)
					_ThumbnailDictionaryKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLThumbnailDictionaryKey")!;
				return _ThumbnailDictionaryKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TotalFileAllocatedSizeKey;
		/// <summary>Represents the value associated with the constant NSURLTotalFileAllocatedSizeKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLTotalFileAllocatedSizeKey",  "Foundation")]
		public static NSString TotalFileAllocatedSizeKey {
			get {
				if (_TotalFileAllocatedSizeKey is null)
					_TotalFileAllocatedSizeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLTotalFileAllocatedSizeKey")!;
				return _TotalFileAllocatedSizeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TotalFileSizeKey;
		/// <summary>Represents the value associated with the constant NSURLTotalFileSizeKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLTotalFileSizeKey",  "Foundation")]
		public static NSString TotalFileSizeKey {
			get {
				if (_TotalFileSizeKey is null)
					_TotalFileSizeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLTotalFileSizeKey")!;
				return _TotalFileSizeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeIdentifierKey;
		/// <summary>Represents the value associated with the constant NSURLTypeIdentifierKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLTypeIdentifierKey",  "Foundation")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'ContentTypeKey' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'ContentTypeKey' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'ContentTypeKey' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'ContentTypeKey' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString TypeIdentifierKey {
			[ObsoletedOSPlatform ("ios14.0", "Use 'ContentTypeKey' instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use 'ContentTypeKey' instead.")]
			[ObsoletedOSPlatform ("macos11.0", "Use 'ContentTypeKey' instead.")]
			[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'ContentTypeKey' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_TypeIdentifierKey is null)
					_TypeIdentifierKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLTypeIdentifierKey")!;
				return _TypeIdentifierKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemContainerDisplayNameKey;
		/// <summary>Represents the value associated with the constant NSURLUbiquitousItemContainerDisplayNameKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousItemContainerDisplayNameKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString UbiquitousItemContainerDisplayNameKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_UbiquitousItemContainerDisplayNameKey is null)
					_UbiquitousItemContainerDisplayNameKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousItemContainerDisplayNameKey")!;
				return _UbiquitousItemContainerDisplayNameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemDownloadRequestedKey;
		/// <summary>Represents the value associated with the constant NSURLUbiquitousItemDownloadRequestedKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousItemDownloadRequestedKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString UbiquitousItemDownloadRequestedKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_UbiquitousItemDownloadRequestedKey is null)
					_UbiquitousItemDownloadRequestedKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousItemDownloadRequestedKey")!;
				return _UbiquitousItemDownloadRequestedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemDownloadingErrorKey;
		/// <summary>Represents the value associated with the constant NSURLUbiquitousItemDownloadingErrorKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousItemDownloadingErrorKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString UbiquitousItemDownloadingErrorKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_UbiquitousItemDownloadingErrorKey is null)
					_UbiquitousItemDownloadingErrorKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousItemDownloadingErrorKey")!;
				return _UbiquitousItemDownloadingErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemDownloadingStatusCurrent;
		/// <summary>Represents the value associated with the constant NSURLUbiquitousItemDownloadingStatusCurrent</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousItemDownloadingStatusCurrent",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString UbiquitousItemDownloadingStatusCurrent {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_UbiquitousItemDownloadingStatusCurrent is null)
					_UbiquitousItemDownloadingStatusCurrent = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousItemDownloadingStatusCurrent")!;
				return _UbiquitousItemDownloadingStatusCurrent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemDownloadingStatusDownloaded;
		/// <summary>Represents the value associated with the constant NSURLUbiquitousItemDownloadingStatusDownloaded</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousItemDownloadingStatusDownloaded",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString UbiquitousItemDownloadingStatusDownloaded {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_UbiquitousItemDownloadingStatusDownloaded is null)
					_UbiquitousItemDownloadingStatusDownloaded = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousItemDownloadingStatusDownloaded")!;
				return _UbiquitousItemDownloadingStatusDownloaded;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemDownloadingStatusKey;
		/// <summary>Represents the value associated with the constant NSURLUbiquitousItemDownloadingStatusKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousItemDownloadingStatusKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString UbiquitousItemDownloadingStatusKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_UbiquitousItemDownloadingStatusKey is null)
					_UbiquitousItemDownloadingStatusKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousItemDownloadingStatusKey")!;
				return _UbiquitousItemDownloadingStatusKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemDownloadingStatusNotDownloaded;
		/// <summary>Represents the value associated with the constant NSURLUbiquitousItemDownloadingStatusNotDownloaded</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousItemDownloadingStatusNotDownloaded",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString UbiquitousItemDownloadingStatusNotDownloaded {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_UbiquitousItemDownloadingStatusNotDownloaded is null)
					_UbiquitousItemDownloadingStatusNotDownloaded = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousItemDownloadingStatusNotDownloaded")!;
				return _UbiquitousItemDownloadingStatusNotDownloaded;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemHasUnresolvedConflictsKey;
		/// <summary>Represents the value associated with the constant NSURLUbiquitousItemHasUnresolvedConflictsKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousItemHasUnresolvedConflictsKey",  "Foundation")]
		public static NSString UbiquitousItemHasUnresolvedConflictsKey {
			get {
				if (_UbiquitousItemHasUnresolvedConflictsKey is null)
					_UbiquitousItemHasUnresolvedConflictsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousItemHasUnresolvedConflictsKey")!;
				return _UbiquitousItemHasUnresolvedConflictsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemIsDownloadedKey;
		/// <summary>Represents the value associated with the constant NSURLUbiquitousItemIsDownloadedKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousItemIsDownloadedKey",  "Foundation")]
		public static NSString UbiquitousItemIsDownloadedKey {
			get {
				if (_UbiquitousItemIsDownloadedKey is null)
					_UbiquitousItemIsDownloadedKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousItemIsDownloadedKey")!;
				return _UbiquitousItemIsDownloadedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemIsDownloadingKey;
		/// <summary>Developers should not use this deprecated property. </summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousItemIsDownloadingKey",  "Foundation")]
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString UbiquitousItemIsDownloadingKey {
			[ObsoletedOSPlatform ("ios7.0")]
			[ObsoletedOSPlatform ("maccatalyst13.1")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_UbiquitousItemIsDownloadingKey is null)
					_UbiquitousItemIsDownloadingKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousItemIsDownloadingKey")!;
				return _UbiquitousItemIsDownloadingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemIsExcludedFromSyncKey;
		/// <summary>Represents the value associated with the constant 'NSURLUbiquitousItemIsExcludedFromSyncKey'.</summary>
		[Field ("NSURLUbiquitousItemIsExcludedFromSyncKey",  "Foundation")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString UbiquitousItemIsExcludedFromSyncKey {
			[SupportedOSPlatform ("tvos14.5")]
			[SupportedOSPlatform ("ios14.5")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UbiquitousItemIsExcludedFromSyncKey is null)
					_UbiquitousItemIsExcludedFromSyncKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousItemIsExcludedFromSyncKey")!;
				return _UbiquitousItemIsExcludedFromSyncKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemIsSharedKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousItemIsSharedKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString UbiquitousItemIsSharedKey {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UbiquitousItemIsSharedKey is null)
					_UbiquitousItemIsSharedKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousItemIsSharedKey")!;
				return _UbiquitousItemIsSharedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemIsSyncPausedKey;
		/// <summary>Represents the value associated with the constant 'NSURLUbiquitousItemIsSyncPausedKey'.</summary>
		[Field ("NSURLUbiquitousItemIsSyncPausedKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString UbiquitousItemIsSyncPausedKey {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_UbiquitousItemIsSyncPausedKey is null)
					_UbiquitousItemIsSyncPausedKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousItemIsSyncPausedKey")!;
				return _UbiquitousItemIsSyncPausedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemIsUploadedKey;
		/// <summary>Represents the value associated with the constant NSURLUbiquitousItemIsUploadedKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousItemIsUploadedKey",  "Foundation")]
		public static NSString UbiquitousItemIsUploadedKey {
			get {
				if (_UbiquitousItemIsUploadedKey is null)
					_UbiquitousItemIsUploadedKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousItemIsUploadedKey")!;
				return _UbiquitousItemIsUploadedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemIsUploadingKey;
		/// <summary>Represents the value associated with the constant NSURLUbiquitousItemIsUploadingKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousItemIsUploadingKey",  "Foundation")]
		public static NSString UbiquitousItemIsUploadingKey {
			get {
				if (_UbiquitousItemIsUploadingKey is null)
					_UbiquitousItemIsUploadingKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousItemIsUploadingKey")!;
				return _UbiquitousItemIsUploadingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemPercentDownloadedKey;
		/// <summary>Represents the value associated with the constant NSURLUbiquitousItemPercentDownloadedKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousItemPercentDownloadedKey",  "Foundation")]
		[ObsoletedOSPlatform ("ios6.0", "Use 'NSMetadataQuery.UbiquitousItemPercentDownloadedKey' on 'NSMetadataItem' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'NSMetadataQuery.UbiquitousItemPercentDownloadedKey' on 'NSMetadataItem' instead.")]
		[ObsoletedOSPlatform ("macos10.8", "Use 'NSMetadataQuery.UbiquitousItemPercentDownloadedKey' on 'NSMetadataItem' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSMetadataQuery.UbiquitousItemPercentDownloadedKey' on 'NSMetadataItem' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString UbiquitousItemPercentDownloadedKey {
			[ObsoletedOSPlatform ("ios6.0", "Use 'NSMetadataQuery.UbiquitousItemPercentDownloadedKey' on 'NSMetadataItem' instead.")]
			[ObsoletedOSPlatform ("tvos9.0", "Use 'NSMetadataQuery.UbiquitousItemPercentDownloadedKey' on 'NSMetadataItem' instead.")]
			[ObsoletedOSPlatform ("macos10.8", "Use 'NSMetadataQuery.UbiquitousItemPercentDownloadedKey' on 'NSMetadataItem' instead.")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSMetadataQuery.UbiquitousItemPercentDownloadedKey' on 'NSMetadataItem' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_UbiquitousItemPercentDownloadedKey is null)
					_UbiquitousItemPercentDownloadedKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousItemPercentDownloadedKey")!;
				return _UbiquitousItemPercentDownloadedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemPercentUploadedKey;
		/// <summary>Represents the value associated with the constant NSURLUbiquitousItemPercentUploadedKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousItemPercentUploadedKey",  "Foundation")]
		[ObsoletedOSPlatform ("ios6.0", "Use 'NSMetadataQuery.UbiquitousItemPercentUploadedKey' on 'NSMetadataItem' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'NSMetadataQuery.UbiquitousItemPercentUploadedKey' on 'NSMetadataItem' instead.")]
		[ObsoletedOSPlatform ("macos10.8", "Use 'NSMetadataQuery.UbiquitousItemPercentUploadedKey' on 'NSMetadataItem' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSMetadataQuery.UbiquitousItemPercentUploadedKey' on 'NSMetadataItem' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString UbiquitousItemPercentUploadedKey {
			[ObsoletedOSPlatform ("ios6.0", "Use 'NSMetadataQuery.UbiquitousItemPercentUploadedKey' on 'NSMetadataItem' instead.")]
			[ObsoletedOSPlatform ("tvos9.0", "Use 'NSMetadataQuery.UbiquitousItemPercentUploadedKey' on 'NSMetadataItem' instead.")]
			[ObsoletedOSPlatform ("macos10.8", "Use 'NSMetadataQuery.UbiquitousItemPercentUploadedKey' on 'NSMetadataItem' instead.")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSMetadataQuery.UbiquitousItemPercentUploadedKey' on 'NSMetadataItem' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_UbiquitousItemPercentUploadedKey is null)
					_UbiquitousItemPercentUploadedKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousItemPercentUploadedKey")!;
				return _UbiquitousItemPercentUploadedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemSupportedSyncControlsKey;
		/// <summary>Represents the value associated with the constant 'NSURLUbiquitousItemSupportedSyncControlsKey'.</summary>
		[Field ("NSURLUbiquitousItemSupportedSyncControlsKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString UbiquitousItemSupportedSyncControlsKey {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_UbiquitousItemSupportedSyncControlsKey is null)
					_UbiquitousItemSupportedSyncControlsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousItemSupportedSyncControlsKey")!;
				return _UbiquitousItemSupportedSyncControlsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemUploadingErrorKey;
		/// <summary>Represents the value associated with the constant NSURLUbiquitousItemUploadingErrorKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousItemUploadingErrorKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString UbiquitousItemUploadingErrorKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_UbiquitousItemUploadingErrorKey is null)
					_UbiquitousItemUploadingErrorKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousItemUploadingErrorKey")!;
				return _UbiquitousItemUploadingErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousSharedItemCurrentUserPermissionsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousSharedItemCurrentUserPermissionsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString UbiquitousSharedItemCurrentUserPermissionsKey {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UbiquitousSharedItemCurrentUserPermissionsKey is null)
					_UbiquitousSharedItemCurrentUserPermissionsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousSharedItemCurrentUserPermissionsKey")!;
				return _UbiquitousSharedItemCurrentUserPermissionsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousSharedItemCurrentUserRoleKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousSharedItemCurrentUserRoleKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString UbiquitousSharedItemCurrentUserRoleKey {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UbiquitousSharedItemCurrentUserRoleKey is null)
					_UbiquitousSharedItemCurrentUserRoleKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousSharedItemCurrentUserRoleKey")!;
				return _UbiquitousSharedItemCurrentUserRoleKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousSharedItemMostRecentEditorNameComponentsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousSharedItemMostRecentEditorNameComponentsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString UbiquitousSharedItemMostRecentEditorNameComponentsKey {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UbiquitousSharedItemMostRecentEditorNameComponentsKey is null)
					_UbiquitousSharedItemMostRecentEditorNameComponentsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousSharedItemMostRecentEditorNameComponentsKey")!;
				return _UbiquitousSharedItemMostRecentEditorNameComponentsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousSharedItemOwnerNameComponentsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousSharedItemOwnerNameComponentsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString UbiquitousSharedItemOwnerNameComponentsKey {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UbiquitousSharedItemOwnerNameComponentsKey is null)
					_UbiquitousSharedItemOwnerNameComponentsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousSharedItemOwnerNameComponentsKey")!;
				return _UbiquitousSharedItemOwnerNameComponentsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousSharedItemPermissionsReadOnly;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousSharedItemPermissionsReadOnly",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString UbiquitousSharedItemPermissionsReadOnly {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UbiquitousSharedItemPermissionsReadOnly is null)
					_UbiquitousSharedItemPermissionsReadOnly = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousSharedItemPermissionsReadOnly")!;
				return _UbiquitousSharedItemPermissionsReadOnly;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousSharedItemPermissionsReadWrite;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousSharedItemPermissionsReadWrite",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString UbiquitousSharedItemPermissionsReadWrite {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UbiquitousSharedItemPermissionsReadWrite is null)
					_UbiquitousSharedItemPermissionsReadWrite = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousSharedItemPermissionsReadWrite")!;
				return _UbiquitousSharedItemPermissionsReadWrite;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousSharedItemRoleOwner;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousSharedItemRoleOwner",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString UbiquitousSharedItemRoleOwner {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UbiquitousSharedItemRoleOwner is null)
					_UbiquitousSharedItemRoleOwner = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousSharedItemRoleOwner")!;
				return _UbiquitousSharedItemRoleOwner;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousSharedItemRoleParticipant;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLUbiquitousSharedItemRoleParticipant",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString UbiquitousSharedItemRoleParticipant {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UbiquitousSharedItemRoleParticipant is null)
					_UbiquitousSharedItemRoleParticipant = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLUbiquitousSharedItemRoleParticipant")!;
				return _UbiquitousSharedItemRoleParticipant;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeAvailableCapacityForImportantUsageKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeAvailableCapacityForImportantUsageKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString VolumeAvailableCapacityForImportantUsageKey {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_VolumeAvailableCapacityForImportantUsageKey is null)
					_VolumeAvailableCapacityForImportantUsageKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeAvailableCapacityForImportantUsageKey")!;
				return _VolumeAvailableCapacityForImportantUsageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeAvailableCapacityForOpportunisticUsageKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeAvailableCapacityForOpportunisticUsageKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString VolumeAvailableCapacityForOpportunisticUsageKey {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_VolumeAvailableCapacityForOpportunisticUsageKey is null)
					_VolumeAvailableCapacityForOpportunisticUsageKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeAvailableCapacityForOpportunisticUsageKey")!;
				return _VolumeAvailableCapacityForOpportunisticUsageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeAvailableCapacityKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeAvailableCapacityKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeAvailableCapacityKey",  "Foundation")]
		public static NSString VolumeAvailableCapacityKey {
			get {
				if (_VolumeAvailableCapacityKey is null)
					_VolumeAvailableCapacityKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeAvailableCapacityKey")!;
				return _VolumeAvailableCapacityKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeCreationDateKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeCreationDateKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeCreationDateKey",  "Foundation")]
		public static NSString VolumeCreationDateKey {
			get {
				if (_VolumeCreationDateKey is null)
					_VolumeCreationDateKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeCreationDateKey")!;
				return _VolumeCreationDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeIdentifierKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeIdentifierKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeIdentifierKey",  "Foundation")]
		public static NSString VolumeIdentifierKey {
			get {
				if (_VolumeIdentifierKey is null)
					_VolumeIdentifierKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeIdentifierKey")!;
				return _VolumeIdentifierKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeIsAutomountedKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeIsAutomountedKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeIsAutomountedKey",  "Foundation")]
		public static NSString VolumeIsAutomountedKey {
			get {
				if (_VolumeIsAutomountedKey is null)
					_VolumeIsAutomountedKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeIsAutomountedKey")!;
				return _VolumeIsAutomountedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeIsBrowsableKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeIsBrowsableKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeIsBrowsableKey",  "Foundation")]
		public static NSString VolumeIsBrowsableKey {
			get {
				if (_VolumeIsBrowsableKey is null)
					_VolumeIsBrowsableKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeIsBrowsableKey")!;
				return _VolumeIsBrowsableKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeIsEjectableKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeIsEjectableKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeIsEjectableKey",  "Foundation")]
		public static NSString VolumeIsEjectableKey {
			get {
				if (_VolumeIsEjectableKey is null)
					_VolumeIsEjectableKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeIsEjectableKey")!;
				return _VolumeIsEjectableKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeIsEncryptedKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeIsEncryptedKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString VolumeIsEncryptedKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_VolumeIsEncryptedKey is null)
					_VolumeIsEncryptedKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeIsEncryptedKey")!;
				return _VolumeIsEncryptedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeIsInternalKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeIsInternalKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeIsInternalKey",  "Foundation")]
		public static NSString VolumeIsInternalKey {
			get {
				if (_VolumeIsInternalKey is null)
					_VolumeIsInternalKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeIsInternalKey")!;
				return _VolumeIsInternalKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeIsJournalingKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeIsJournalingKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeIsJournalingKey",  "Foundation")]
		public static NSString VolumeIsJournalingKey {
			get {
				if (_VolumeIsJournalingKey is null)
					_VolumeIsJournalingKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeIsJournalingKey")!;
				return _VolumeIsJournalingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeIsLocalKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeIsLocalKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeIsLocalKey",  "Foundation")]
		public static NSString VolumeIsLocalKey {
			get {
				if (_VolumeIsLocalKey is null)
					_VolumeIsLocalKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeIsLocalKey")!;
				return _VolumeIsLocalKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeIsReadOnlyKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeIsReadOnlyKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeIsReadOnlyKey",  "Foundation")]
		public static NSString VolumeIsReadOnlyKey {
			get {
				if (_VolumeIsReadOnlyKey is null)
					_VolumeIsReadOnlyKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeIsReadOnlyKey")!;
				return _VolumeIsReadOnlyKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeIsRemovableKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeIsRemovableKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeIsRemovableKey",  "Foundation")]
		public static NSString VolumeIsRemovableKey {
			get {
				if (_VolumeIsRemovableKey is null)
					_VolumeIsRemovableKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeIsRemovableKey")!;
				return _VolumeIsRemovableKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeIsRootFileSystemKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeIsRootFileSystemKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString VolumeIsRootFileSystemKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_VolumeIsRootFileSystemKey is null)
					_VolumeIsRootFileSystemKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeIsRootFileSystemKey")!;
				return _VolumeIsRootFileSystemKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeLocalizedFormatDescriptionKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeLocalizedFormatDescriptionKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeLocalizedFormatDescriptionKey",  "Foundation")]
		public static NSString VolumeLocalizedFormatDescriptionKey {
			get {
				if (_VolumeLocalizedFormatDescriptionKey is null)
					_VolumeLocalizedFormatDescriptionKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeLocalizedFormatDescriptionKey")!;
				return _VolumeLocalizedFormatDescriptionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeLocalizedNameKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeLocalizedNameKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeLocalizedNameKey",  "Foundation")]
		public static NSString VolumeLocalizedNameKey {
			get {
				if (_VolumeLocalizedNameKey is null)
					_VolumeLocalizedNameKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeLocalizedNameKey")!;
				return _VolumeLocalizedNameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeMaximumFileSizeKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeMaximumFileSizeKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeMaximumFileSizeKey",  "Foundation")]
		public static NSString VolumeMaximumFileSizeKey {
			get {
				if (_VolumeMaximumFileSizeKey is null)
					_VolumeMaximumFileSizeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeMaximumFileSizeKey")!;
				return _VolumeMaximumFileSizeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeMountFromLocationKey;
		/// <summary>Represents the value associated with the constant 'NSURLVolumeMountFromLocationKey'.</summary>
		[Field ("NSURLVolumeMountFromLocationKey",  "Foundation")]
		[SupportedOSPlatform ("tvos16.4")]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		public static NSString VolumeMountFromLocationKey {
			[SupportedOSPlatform ("tvos16.4")]
			[SupportedOSPlatform ("macos13.3")]
			[SupportedOSPlatform ("ios16.4")]
			[SupportedOSPlatform ("maccatalyst16.4")]
			get {
				if (_VolumeMountFromLocationKey is null)
					_VolumeMountFromLocationKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeMountFromLocationKey")!;
				return _VolumeMountFromLocationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeNameKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeNameKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeNameKey",  "Foundation")]
		public static NSString VolumeNameKey {
			get {
				if (_VolumeNameKey is null)
					_VolumeNameKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeNameKey")!;
				return _VolumeNameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeResourceCountKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeResourceCountKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeResourceCountKey",  "Foundation")]
		public static NSString VolumeResourceCountKey {
			get {
				if (_VolumeResourceCountKey is null)
					_VolumeResourceCountKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeResourceCountKey")!;
				return _VolumeResourceCountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSubtypeKey;
		/// <summary>Represents the value associated with the constant 'NSURLVolumeSubtypeKey'.</summary>
		[Field ("NSURLVolumeSubtypeKey",  "Foundation")]
		[SupportedOSPlatform ("tvos16.4")]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		public static NSString VolumeSubtypeKey {
			[SupportedOSPlatform ("tvos16.4")]
			[SupportedOSPlatform ("macos13.3")]
			[SupportedOSPlatform ("ios16.4")]
			[SupportedOSPlatform ("maccatalyst16.4")]
			get {
				if (_VolumeSubtypeKey is null)
					_VolumeSubtypeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSubtypeKey")!;
				return _VolumeSubtypeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsAccessPermissionsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeSupportsAccessPermissionsKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString VolumeSupportsAccessPermissionsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_VolumeSupportsAccessPermissionsKey is null)
					_VolumeSupportsAccessPermissionsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsAccessPermissionsKey")!;
				return _VolumeSupportsAccessPermissionsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsAdvisoryFileLockingKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeSupportsAdvisoryFileLockingKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeSupportsAdvisoryFileLockingKey",  "Foundation")]
		public static NSString VolumeSupportsAdvisoryFileLockingKey {
			get {
				if (_VolumeSupportsAdvisoryFileLockingKey is null)
					_VolumeSupportsAdvisoryFileLockingKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsAdvisoryFileLockingKey")!;
				return _VolumeSupportsAdvisoryFileLockingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsCasePreservedNamesKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeSupportsCasePreservedNamesKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeSupportsCasePreservedNamesKey",  "Foundation")]
		public static NSString VolumeSupportsCasePreservedNamesKey {
			get {
				if (_VolumeSupportsCasePreservedNamesKey is null)
					_VolumeSupportsCasePreservedNamesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsCasePreservedNamesKey")!;
				return _VolumeSupportsCasePreservedNamesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsCaseSensitiveNamesKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeSupportsCaseSensitiveNamesKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeSupportsCaseSensitiveNamesKey",  "Foundation")]
		public static NSString VolumeSupportsCaseSensitiveNamesKey {
			get {
				if (_VolumeSupportsCaseSensitiveNamesKey is null)
					_VolumeSupportsCaseSensitiveNamesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsCaseSensitiveNamesKey")!;
				return _VolumeSupportsCaseSensitiveNamesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsCompressionKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeSupportsCompressionKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString VolumeSupportsCompressionKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_VolumeSupportsCompressionKey is null)
					_VolumeSupportsCompressionKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsCompressionKey")!;
				return _VolumeSupportsCompressionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsExclusiveRenamingKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeSupportsExclusiveRenamingKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString VolumeSupportsExclusiveRenamingKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_VolumeSupportsExclusiveRenamingKey is null)
					_VolumeSupportsExclusiveRenamingKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsExclusiveRenamingKey")!;
				return _VolumeSupportsExclusiveRenamingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsExtendedSecurityKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeSupportsExtendedSecurityKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeSupportsExtendedSecurityKey",  "Foundation")]
		public static NSString VolumeSupportsExtendedSecurityKey {
			get {
				if (_VolumeSupportsExtendedSecurityKey is null)
					_VolumeSupportsExtendedSecurityKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsExtendedSecurityKey")!;
				return _VolumeSupportsExtendedSecurityKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsFileCloningKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeSupportsFileCloningKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString VolumeSupportsFileCloningKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_VolumeSupportsFileCloningKey is null)
					_VolumeSupportsFileCloningKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsFileCloningKey")!;
				return _VolumeSupportsFileCloningKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsFileProtectionKey;
		/// <summary>Represents the value associated with the constant 'NSURLVolumeSupportsFileProtectionKey'.</summary>
		[Field ("NSURLVolumeSupportsFileProtectionKey",  "Foundation")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString VolumeSupportsFileProtectionKey {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_VolumeSupportsFileProtectionKey is null)
					_VolumeSupportsFileProtectionKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsFileProtectionKey")!;
				return _VolumeSupportsFileProtectionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsHardLinksKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeSupportsHardLinksKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeSupportsHardLinksKey",  "Foundation")]
		public static NSString VolumeSupportsHardLinksKey {
			get {
				if (_VolumeSupportsHardLinksKey is null)
					_VolumeSupportsHardLinksKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsHardLinksKey")!;
				return _VolumeSupportsHardLinksKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsImmutableFilesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeSupportsImmutableFilesKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString VolumeSupportsImmutableFilesKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_VolumeSupportsImmutableFilesKey is null)
					_VolumeSupportsImmutableFilesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsImmutableFilesKey")!;
				return _VolumeSupportsImmutableFilesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsJournalingKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeSupportsJournalingKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeSupportsJournalingKey",  "Foundation")]
		public static NSString VolumeSupportsJournalingKey {
			get {
				if (_VolumeSupportsJournalingKey is null)
					_VolumeSupportsJournalingKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsJournalingKey")!;
				return _VolumeSupportsJournalingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsPersistentIDsKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeSupportsPersistentIDsKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeSupportsPersistentIDsKey",  "Foundation")]
		public static NSString VolumeSupportsPersistentIDsKey {
			get {
				if (_VolumeSupportsPersistentIDsKey is null)
					_VolumeSupportsPersistentIDsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsPersistentIDsKey")!;
				return _VolumeSupportsPersistentIDsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsRenamingKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeSupportsRenamingKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeSupportsRenamingKey",  "Foundation")]
		public static NSString VolumeSupportsRenamingKey {
			get {
				if (_VolumeSupportsRenamingKey is null)
					_VolumeSupportsRenamingKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsRenamingKey")!;
				return _VolumeSupportsRenamingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsRootDirectoryDatesKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeSupportsRootDirectoryDatesKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeSupportsRootDirectoryDatesKey",  "Foundation")]
		public static NSString VolumeSupportsRootDirectoryDatesKey {
			get {
				if (_VolumeSupportsRootDirectoryDatesKey is null)
					_VolumeSupportsRootDirectoryDatesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsRootDirectoryDatesKey")!;
				return _VolumeSupportsRootDirectoryDatesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsSparseFilesKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeSupportsSparseFilesKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeSupportsSparseFilesKey",  "Foundation")]
		public static NSString VolumeSupportsSparseFilesKey {
			get {
				if (_VolumeSupportsSparseFilesKey is null)
					_VolumeSupportsSparseFilesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsSparseFilesKey")!;
				return _VolumeSupportsSparseFilesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsSwapRenamingKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeSupportsSwapRenamingKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString VolumeSupportsSwapRenamingKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_VolumeSupportsSwapRenamingKey is null)
					_VolumeSupportsSwapRenamingKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsSwapRenamingKey")!;
				return _VolumeSupportsSwapRenamingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsSymbolicLinksKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeSupportsSymbolicLinksKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeSupportsSymbolicLinksKey",  "Foundation")]
		public static NSString VolumeSupportsSymbolicLinksKey {
			get {
				if (_VolumeSupportsSymbolicLinksKey is null)
					_VolumeSupportsSymbolicLinksKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsSymbolicLinksKey")!;
				return _VolumeSupportsSymbolicLinksKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsVolumeSizesKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeSupportsVolumeSizesKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeSupportsVolumeSizesKey",  "Foundation")]
		public static NSString VolumeSupportsVolumeSizesKey {
			get {
				if (_VolumeSupportsVolumeSizesKey is null)
					_VolumeSupportsVolumeSizesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsVolumeSizesKey")!;
				return _VolumeSupportsVolumeSizesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeSupportsZeroRunsKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeSupportsZeroRunsKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeSupportsZeroRunsKey",  "Foundation")]
		public static NSString VolumeSupportsZeroRunsKey {
			get {
				if (_VolumeSupportsZeroRunsKey is null)
					_VolumeSupportsZeroRunsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeSupportsZeroRunsKey")!;
				return _VolumeSupportsZeroRunsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeTotalCapacityKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeTotalCapacityKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeTotalCapacityKey",  "Foundation")]
		public static NSString VolumeTotalCapacityKey {
			get {
				if (_VolumeTotalCapacityKey is null)
					_VolumeTotalCapacityKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeTotalCapacityKey")!;
				return _VolumeTotalCapacityKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeTypeNameKey;
		/// <summary>Represents the value associated with the constant 'NSURLVolumeTypeNameKey'.</summary>
		[Field ("NSURLVolumeTypeNameKey",  "Foundation")]
		[SupportedOSPlatform ("tvos16.4")]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		public static NSString VolumeTypeNameKey {
			[SupportedOSPlatform ("tvos16.4")]
			[SupportedOSPlatform ("macos13.3")]
			[SupportedOSPlatform ("ios16.4")]
			[SupportedOSPlatform ("maccatalyst16.4")]
			get {
				if (_VolumeTypeNameKey is null)
					_VolumeTypeNameKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeTypeNameKey")!;
				return _VolumeTypeNameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeURLForRemountingKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeURLForRemountingKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeURLForRemountingKey",  "Foundation")]
		public static NSString VolumeURLForRemountingKey {
			get {
				if (_VolumeURLForRemountingKey is null)
					_VolumeURLForRemountingKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeURLForRemountingKey")!;
				return _VolumeURLForRemountingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeURLKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeURLKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeURLKey",  "Foundation")]
		public static NSString VolumeURLKey {
			get {
				if (_VolumeURLKey is null)
					_VolumeURLKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeURLKey")!;
				return _VolumeURLKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VolumeUUIDStringKey;
		/// <summary>Represents the value associated with the constant NSURLVolumeUUIDStringKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLVolumeUUIDStringKey",  "Foundation")]
		public static NSString VolumeUUIDStringKey {
			get {
				if (_VolumeUUIDStringKey is null)
					_VolumeUUIDStringKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLVolumeUUIDStringKey")!;
				return _VolumeUUIDStringKey;
			}
		}
	} /* class NSUrl */
}
