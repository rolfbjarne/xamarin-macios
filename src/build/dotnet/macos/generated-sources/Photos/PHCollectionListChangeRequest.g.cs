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
namespace Photos {
	/// <summary>Used within a Photos change block to create, update, or delete <see cref="T:Photos.PHCollectionList" /> objects..</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Photos/Reference/PHCollectionListChangeRequest_Class/index.html">Apple documentation for <c>PHCollectionListChangeRequest</c></related>
	[Register("PHCollectionListChangeRequest", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class PHCollectionListChangeRequest : PHChangeRequest {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddChildCollections_X = "addChildCollections:";
		static readonly NativeHandle selAddChildCollections_XHandle = Selector.GetHandle ("addChildCollections:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeRequestForCollectionList_X = "changeRequestForCollectionList:";
		static readonly NativeHandle selChangeRequestForCollectionList_XHandle = Selector.GetHandle ("changeRequestForCollectionList:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeRequestForCollectionList_ChildCollections_X = "changeRequestForCollectionList:childCollections:";
		static readonly NativeHandle selChangeRequestForCollectionList_ChildCollections_XHandle = Selector.GetHandle ("changeRequestForCollectionList:childCollections:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeRequestForTopLevelCollectionListUserCollections_X = "changeRequestForTopLevelCollectionListUserCollections:";
		static readonly NativeHandle selChangeRequestForTopLevelCollectionListUserCollections_XHandle = Selector.GetHandle ("changeRequestForTopLevelCollectionListUserCollections:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreationRequestForCollectionListWithTitle_X = "creationRequestForCollectionListWithTitle:";
		static readonly NativeHandle selCreationRequestForCollectionListWithTitle_XHandle = Selector.GetHandle ("creationRequestForCollectionListWithTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteCollectionLists_X = "deleteCollectionLists:";
		static readonly NativeHandle selDeleteCollectionLists_XHandle = Selector.GetHandle ("deleteCollectionLists:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertChildCollections_AtIndexes_X = "insertChildCollections:atIndexes:";
		static readonly NativeHandle selInsertChildCollections_AtIndexes_XHandle = Selector.GetHandle ("insertChildCollections:atIndexes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveChildCollectionsAtIndexes_ToIndex_X = "moveChildCollectionsAtIndexes:toIndex:";
		static readonly NativeHandle selMoveChildCollectionsAtIndexes_ToIndex_XHandle = Selector.GetHandle ("moveChildCollectionsAtIndexes:toIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlaceholderForCreatedCollectionListX = "placeholderForCreatedCollectionList";
		static readonly NativeHandle selPlaceholderForCreatedCollectionListXHandle = Selector.GetHandle ("placeholderForCreatedCollectionList");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveChildCollections_X = "removeChildCollections:";
		static readonly NativeHandle selRemoveChildCollections_XHandle = Selector.GetHandle ("removeChildCollections:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveChildCollectionsAtIndexes_X = "removeChildCollectionsAtIndexes:";
		static readonly NativeHandle selRemoveChildCollectionsAtIndexes_XHandle = Selector.GetHandle ("removeChildCollectionsAtIndexes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplaceChildCollectionsAtIndexes_WithChildCollections_X = "replaceChildCollectionsAtIndexes:withChildCollections:";
		static readonly NativeHandle selReplaceChildCollectionsAtIndexes_WithChildCollections_XHandle = Selector.GetHandle ("replaceChildCollectionsAtIndexes:withChildCollections:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTitle_X = "setTitle:";
		static readonly NativeHandle selSetTitle_XHandle = Selector.GetHandle ("setTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleX = "title";
		static readonly NativeHandle selTitleXHandle = Selector.GetHandle ("title");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PHCollectionListChangeRequest");
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
		protected PHCollectionListChangeRequest (NSObjectFlag t) : base (t)
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
		protected internal PHCollectionListChangeRequest (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addChildCollections:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddChildCollections (PHCollection[] collections)
		{
			if (collections is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (collections));
			using var nsa_collections = NSArray.FromNSObjects (collections);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddChildCollections_XHandle, nsa_collections.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddChildCollections_XHandle, nsa_collections.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("changeRequestForCollectionList:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHCollectionListChangeRequest? ChangeRequest (PHCollectionList collectionList)
		{
			var collectionList__handle__ = collectionList!.GetNonNullHandle (nameof (collectionList));
			PHCollectionListChangeRequest? ret;
			ret =  Runtime.GetNSObject<PHCollectionListChangeRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selChangeRequestForCollectionList_XHandle, collectionList__handle__), false)!;
			GC.KeepAlive (collectionList);
			return ret!;
		}
		[Export ("changeRequestForCollectionList:childCollections:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHCollectionListChangeRequest? ChangeRequest (PHCollectionList collectionList, PHFetchResult childCollections)
		{
			var collectionList__handle__ = collectionList!.GetNonNullHandle (nameof (collectionList));
			var childCollections__handle__ = childCollections!.GetNonNullHandle (nameof (childCollections));
			PHCollectionListChangeRequest? ret;
			ret =  Runtime.GetNSObject<PHCollectionListChangeRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selChangeRequestForCollectionList_ChildCollections_XHandle, collectionList__handle__, childCollections__handle__), false)!;
			GC.KeepAlive (collectionList);
			GC.KeepAlive (childCollections);
			return ret!;
		}
		[Export ("changeRequestForTopLevelCollectionListUserCollections:")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("ios14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHCollectionListChangeRequest? ChangeRequestForTopLevelCollectionList (PHFetchResult childCollections)
		{
			var childCollections__handle__ = childCollections!.GetNonNullHandle (nameof (childCollections));
			PHCollectionListChangeRequest? ret;
			ret =  Runtime.GetNSObject<PHCollectionListChangeRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selChangeRequestForTopLevelCollectionListUserCollections_XHandle, childCollections__handle__), false)!;
			GC.KeepAlive (childCollections);
			return ret!;
		}
		[Export ("creationRequestForCollectionListWithTitle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHCollectionListChangeRequest CreateAssetCollection (string title)
		{
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			PHCollectionListChangeRequest? ret;
			ret =  Runtime.GetNSObject<PHCollectionListChangeRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selCreationRequestForCollectionListWithTitle_XHandle, nstitle), false)!;
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
		[Export ("deleteCollectionLists:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DeleteCollectionLists (PHCollectionList[] collectionLists)
		{
			if (collectionLists is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (collectionLists));
			using var nsa_collectionLists = NSArray.FromNSObjects (collectionLists);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selDeleteCollectionLists_XHandle, nsa_collectionLists.Handle);
		}
		[Export ("insertChildCollections:atIndexes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertChildCollections (PHCollection[] collections, NSIndexSet indexes)
		{
			if (collections is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (collections));
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			using var nsa_collections = NSArray.FromNSObjects (collections);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInsertChildCollections_AtIndexes_XHandle, nsa_collections.Handle, indexes__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInsertChildCollections_AtIndexes_XHandle, nsa_collections.Handle, indexes__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
		}
		/// <param name="indexes">To be added.</param><param name="toIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("moveChildCollectionsAtIndexes:toIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveChildCollections (NSIndexSet indexes, nuint toIndex)
		{
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selMoveChildCollectionsAtIndexes_ToIndex_XHandle, indexes__handle__, toIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selMoveChildCollectionsAtIndexes_ToIndex_XHandle, indexes__handle__, toIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
		}
		[Export ("removeChildCollections:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveChildCollections (PHCollection[] collections)
		{
			if (collections is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (collections));
			using var nsa_collections = NSArray.FromNSObjects (collections);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveChildCollections_XHandle, nsa_collections.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveChildCollections_XHandle, nsa_collections.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeChildCollectionsAtIndexes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveChildCollections (NSIndexSet indexes)
		{
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveChildCollectionsAtIndexes_XHandle, indexes__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveChildCollectionsAtIndexes_XHandle, indexes__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
		}
		[Export ("replaceChildCollectionsAtIndexes:withChildCollections:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceChildCollection (NSIndexSet indexes, PHCollection[] collections)
		{
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			if (collections is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (collections));
			using var nsa_collections = NSArray.FromNSObjects (collections);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selReplaceChildCollectionsAtIndexes_WithChildCollections_XHandle, indexes__handle__, nsa_collections.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selReplaceChildCollectionsAtIndexes_WithChildCollections_XHandle, indexes__handle__, nsa_collections.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PHObjectPlaceholder PlaceholderForCreatedCollectionList {
			[Export ("placeholderForCreatedCollectionList", ArgumentSemantic.Retain)]
			get {
				PHObjectPlaceholder? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PHObjectPlaceholder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPlaceholderForCreatedCollectionListXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PHObjectPlaceholder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPlaceholderForCreatedCollectionListXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Title {
			[Export ("title", ArgumentSemantic.Retain)]
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
			[Export ("setTitle:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTitle_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTitle_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
	} /* class PHCollectionListChangeRequest */
}
