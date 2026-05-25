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
	[Register("NSFileVersion", true)]
	public unsafe partial class NSFileVersion : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLX = "URL";
		static readonly NativeHandle selURLXHandle = Selector.GetHandle ("URL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddVersionOfItemAtURL_WithContentsOfURL_Options_Error_X = "addVersionOfItemAtURL:withContentsOfURL:options:error:";
		static readonly NativeHandle selAddVersionOfItemAtURL_WithContentsOfURL_Options_Error_XHandle = Selector.GetHandle ("addVersionOfItemAtURL:withContentsOfURL:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentVersionOfItemAtURL_X = "currentVersionOfItemAtURL:";
		static readonly NativeHandle selCurrentVersionOfItemAtURL_XHandle = Selector.GetHandle ("currentVersionOfItemAtURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetNonlocalVersionsOfItemAtURL_CompletionHandler_X = "getNonlocalVersionsOfItemAtURL:completionHandler:";
		static readonly NativeHandle selGetNonlocalVersionsOfItemAtURL_CompletionHandler_XHandle = Selector.GetHandle ("getNonlocalVersionsOfItemAtURL:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasLocalContentsX = "hasLocalContents";
		static readonly NativeHandle selHasLocalContentsXHandle = Selector.GetHandle ("hasLocalContents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasThumbnailX = "hasThumbnail";
		static readonly NativeHandle selHasThumbnailXHandle = Selector.GetHandle ("hasThumbnail");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsConflictX = "isConflict";
		static readonly NativeHandle selIsConflictXHandle = Selector.GetHandle ("isConflict");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDiscardableX = "isDiscardable";
		static readonly NativeHandle selIsDiscardableXHandle = Selector.GetHandle ("isDiscardable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsResolvedX = "isResolved";
		static readonly NativeHandle selIsResolvedXHandle = Selector.GetHandle ("isResolved");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedNameX = "localizedName";
		static readonly NativeHandle selLocalizedNameXHandle = Selector.GetHandle ("localizedName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedNameOfSavingComputerX = "localizedNameOfSavingComputer";
		static readonly NativeHandle selLocalizedNameOfSavingComputerXHandle = Selector.GetHandle ("localizedNameOfSavingComputer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selModificationDateX = "modificationDate";
		static readonly NativeHandle selModificationDateXHandle = Selector.GetHandle ("modificationDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOriginatorNameComponentsX = "originatorNameComponents";
		static readonly NativeHandle selOriginatorNameComponentsXHandle = Selector.GetHandle ("originatorNameComponents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOtherVersionsOfItemAtURL_X = "otherVersionsOfItemAtURL:";
		static readonly NativeHandle selOtherVersionsOfItemAtURL_XHandle = Selector.GetHandle ("otherVersionsOfItemAtURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPersistentIdentifierX = "persistentIdentifier";
		static readonly NativeHandle selPersistentIdentifierXHandle = Selector.GetHandle ("persistentIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAndReturnError_X = "removeAndReturnError:";
		static readonly NativeHandle selRemoveAndReturnError_XHandle = Selector.GetHandle ("removeAndReturnError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveOtherVersionsOfItemAtURL_Error_X = "removeOtherVersionsOfItemAtURL:error:";
		static readonly NativeHandle selRemoveOtherVersionsOfItemAtURL_Error_XHandle = Selector.GetHandle ("removeOtherVersionsOfItemAtURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplaceItemAtURL_Options_Error_X = "replaceItemAtURL:options:error:";
		static readonly NativeHandle selReplaceItemAtURL_Options_Error_XHandle = Selector.GetHandle ("replaceItemAtURL:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDiscardable_X = "setDiscardable:";
		static readonly NativeHandle selSetDiscardable_XHandle = Selector.GetHandle ("setDiscardable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetResolved_X = "setResolved:";
		static readonly NativeHandle selSetResolved_XHandle = Selector.GetHandle ("setResolved:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporaryDirectoryURLForNewVersionOfItemAtURL_X = "temporaryDirectoryURLForNewVersionOfItemAtURL:";
		static readonly NativeHandle selTemporaryDirectoryURLForNewVersionOfItemAtURL_XHandle = Selector.GetHandle ("temporaryDirectoryURLForNewVersionOfItemAtURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnresolvedConflictVersionsOfItemAtURL_X = "unresolvedConflictVersionsOfItemAtURL:";
		static readonly NativeHandle selUnresolvedConflictVersionsOfItemAtURL_XHandle = Selector.GetHandle ("unresolvedConflictVersionsOfItemAtURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVersionOfItemAtURL_ForPersistentIdentifier_X = "versionOfItemAtURL:forPersistentIdentifier:";
		static readonly NativeHandle selVersionOfItemAtURL_ForPersistentIdentifier_XHandle = Selector.GetHandle ("versionOfItemAtURL:forPersistentIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSFileVersion");
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
		protected NSFileVersion (NSObjectFlag t) : base (t)
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
		protected internal NSFileVersion (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addVersionOfItemAtURL:withContentsOfURL:options:error:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSFileVersion? AddVersion (NSUrl url, NSUrl contentsURL, NSFileVersionAddingOptions options, out NSError outError)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var contentsURL__handle__ = contentsURL!.GetNonNullHandle (nameof (contentsURL));
			NativeHandle outErrorValue = IntPtr.Zero;
			NSFileVersion? ret;
			ret =  Runtime.GetNSObject<NSFileVersion> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_ref_NativeHandle (class_ptr, selAddVersionOfItemAtURL_WithContentsOfURL_Options_Error_XHandle, url__handle__, contentsURL__handle__, (UIntPtr) (ulong) options, &outErrorValue), false)!;
			GC.KeepAlive (url);
			GC.KeepAlive (contentsURL);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[Export ("currentVersionOfItemAtURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFileVersion GetCurrentVersion (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NSFileVersion? ret;
			ret =  Runtime.GetNSObject<NSFileVersion> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selCurrentVersionOfItemAtURL_XHandle, url__handle__), false)!;
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("getNonlocalVersionsOfItemAtURL:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetNonlocalVersions (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileVersionNonlocalVersionsCompletionHandler))]NSFileVersionNonlocalVersionsCompletionHandler completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSFileVersionNonlocalVersionsCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selGetNonlocalVersionsOfItemAtURL_CompletionHandler_XHandle, url__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (url);
		}
		/// <param name="url">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous GetNonlocalVersions operation.   The value of the TResult parameter is a <see cref="Foundation.NSFileVersionNonlocalVersionsCompletionHandler" />.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The GetNonlocalVersionsAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSFileVersion[]> GetNonlocalVersionsAsync (NSUrl url)
		{
			var tcs = new TaskCompletionSource<NSFileVersion[]> ();
			GetNonlocalVersions(url, (nonlocalFileVersions_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (nonlocalFileVersions_!);
			});
			return tcs.Task;
		}
		[Export ("otherVersionsOfItemAtURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFileVersion[] GetOtherVersions (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NSFileVersion[]? ret;
			ret = CFArray.ArrayFromHandle<NSFileVersion>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selOtherVersionsOfItemAtURL_XHandle, url__handle__), false)!;
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("versionOfItemAtURL:forPersistentIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFileVersion GetSpecificVersion (NSUrl url, NSObject persistentIdentifier)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var persistentIdentifier__handle__ = persistentIdentifier!.GetNonNullHandle (nameof (persistentIdentifier));
			NSFileVersion? ret;
			ret =  Runtime.GetNSObject<NSFileVersion> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selVersionOfItemAtURL_ForPersistentIdentifier_XHandle, url__handle__, persistentIdentifier__handle__), false)!;
			GC.KeepAlive (url);
			GC.KeepAlive (persistentIdentifier);
			return ret!;
		}
		[Export ("unresolvedConflictVersionsOfItemAtURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFileVersion[] GetUnresolvedConflictVersions (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NSFileVersion[]? ret;
			ret = CFArray.ArrayFromHandle<NSFileVersion>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selUnresolvedConflictVersionsOfItemAtURL_XHandle, url__handle__), false)!;
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("removeAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Remove (out NSError outError)
		{
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, selRemoveAndReturnError_XHandle, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selRemoveAndReturnError_XHandle, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[Export ("removeOtherVersionsOfItemAtURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool RemoveOtherVersions (NSUrl url, out NSError outError)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (class_ptr, selRemoveOtherVersionsOfItemAtURL_Error_XHandle, url__handle__, &outErrorValue);
			GC.KeepAlive (url);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[Export ("replaceItemAtURL:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSUrl ReplaceItem (NSUrl url, NSFileVersionReplacingOptions options, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			NSUrl? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle (this.Handle, selReplaceItemAtURL_Options_Error_XHandle, url__handle__, (UIntPtr) (ulong) options, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_ref_NativeHandle (&__objc_super__, selReplaceItemAtURL_Options_Error_XHandle, url__handle__, (UIntPtr) (ulong) options, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("temporaryDirectoryURLForNewVersionOfItemAtURL:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl TemporaryDirectoryForItem (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selTemporaryDirectoryURLForNewVersionOfItemAtURL_XHandle, url__handle__), false)!;
			GC.KeepAlive (url);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool Discardable {
			[Export ("isDiscardable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDiscardableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsDiscardableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDiscardable:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDiscardable_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDiscardable_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool HasLocalContents {
			[Export ("hasLocalContents")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasLocalContentsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasLocalContentsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool HasThumbnail {
			[Export ("hasThumbnail")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasThumbnailXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasThumbnailXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Whether this NSFileVersion is in conflict with another NSFileVersion. Read-only.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsConflict {
			[Export ("isConflict")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsConflictXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsConflictXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string LocalizedName {
			[Export ("localizedName", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string LocalizedNameOfSavingComputer {
			[Export ("localizedNameOfSavingComputer", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedNameOfSavingComputerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedNameOfSavingComputerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate ModificationDate {
			[Export ("modificationDate", ArgumentSemantic.Copy)]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selModificationDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selModificationDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual NSPersonNameComponents? OriginatorNameComponents {
			[Export ("originatorNameComponents", ArgumentSemantic.Copy)]
			get {
				NSPersonNameComponents? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSPersonNameComponents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOriginatorNameComponentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSPersonNameComponents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOriginatorNameComponentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject PersistentIdentifier {
			[Export ("persistentIdentifier", ArgumentSemantic.Retain)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPersistentIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPersistentIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>True if this version is not in conflict with another version. App devs should not assign the value false to this property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Resolved {
			[Export ("isResolved")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsResolvedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsResolvedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setResolved:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetResolved_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetResolved_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl Url {
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
	} /* class NSFileVersion */
}
