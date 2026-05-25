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
	/// <summary>Used within a Photos change block to create, update, or delete <see cref="T:Photos.PHAssetCollection" /> objects..</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Photos/Reference/PHAssetCollectionChangeRequest_Class/index.html">Apple documentation for <c>PHAssetCollectionChangeRequest</c></related>
	[Register("PHAssetCollectionChangeRequest", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class PHAssetCollectionChangeRequest : PHChangeRequest {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddAssets_X = "addAssets:";
		static readonly NativeHandle selAddAssets_XHandle = Selector.GetHandle ("addAssets:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeRequestForAssetCollection_X = "changeRequestForAssetCollection:";
		static readonly NativeHandle selChangeRequestForAssetCollection_XHandle = Selector.GetHandle ("changeRequestForAssetCollection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeRequestForAssetCollection_Assets_X = "changeRequestForAssetCollection:assets:";
		static readonly NativeHandle selChangeRequestForAssetCollection_Assets_XHandle = Selector.GetHandle ("changeRequestForAssetCollection:assets:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreationRequestForAssetCollectionWithTitle_X = "creationRequestForAssetCollectionWithTitle:";
		static readonly NativeHandle selCreationRequestForAssetCollectionWithTitle_XHandle = Selector.GetHandle ("creationRequestForAssetCollectionWithTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteAssetCollections_X = "deleteAssetCollections:";
		static readonly NativeHandle selDeleteAssetCollections_XHandle = Selector.GetHandle ("deleteAssetCollections:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertAssets_AtIndexes_X = "insertAssets:atIndexes:";
		static readonly NativeHandle selInsertAssets_AtIndexes_XHandle = Selector.GetHandle ("insertAssets:atIndexes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveAssetsAtIndexes_ToIndex_X = "moveAssetsAtIndexes:toIndex:";
		static readonly NativeHandle selMoveAssetsAtIndexes_ToIndex_XHandle = Selector.GetHandle ("moveAssetsAtIndexes:toIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlaceholderForCreatedAssetCollectionX = "placeholderForCreatedAssetCollection";
		static readonly NativeHandle selPlaceholderForCreatedAssetCollectionXHandle = Selector.GetHandle ("placeholderForCreatedAssetCollection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAssets_X = "removeAssets:";
		static readonly NativeHandle selRemoveAssets_XHandle = Selector.GetHandle ("removeAssets:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAssetsAtIndexes_X = "removeAssetsAtIndexes:";
		static readonly NativeHandle selRemoveAssetsAtIndexes_XHandle = Selector.GetHandle ("removeAssetsAtIndexes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplaceAssetsAtIndexes_WithAssets_X = "replaceAssetsAtIndexes:withAssets:";
		static readonly NativeHandle selReplaceAssetsAtIndexes_WithAssets_XHandle = Selector.GetHandle ("replaceAssetsAtIndexes:withAssets:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTitle_X = "setTitle:";
		static readonly NativeHandle selSetTitle_XHandle = Selector.GetHandle ("setTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleX = "title";
		static readonly NativeHandle selTitleXHandle = Selector.GetHandle ("title");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PHAssetCollectionChangeRequest");
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
		protected PHAssetCollectionChangeRequest (NSObjectFlag t) : base (t)
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
		protected internal PHAssetCollectionChangeRequest (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addAssets:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAssets (PHObject[] assets)
		{
			if (assets is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (assets));
			using var nsa_assets = NSArray.FromNSObjects (assets);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddAssets_XHandle, nsa_assets.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddAssets_XHandle, nsa_assets.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("changeRequestForAssetCollection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHAssetCollectionChangeRequest? ChangeRequest (PHAssetCollection assetCollection)
		{
			var assetCollection__handle__ = assetCollection!.GetNonNullHandle (nameof (assetCollection));
			PHAssetCollectionChangeRequest? ret;
			ret =  Runtime.GetNSObject<PHAssetCollectionChangeRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selChangeRequestForAssetCollection_XHandle, assetCollection__handle__), false)!;
			GC.KeepAlive (assetCollection);
			return ret!;
		}
		[Export ("changeRequestForAssetCollection:assets:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHAssetCollectionChangeRequest? ChangeRequest (PHAssetCollection assetCollection, PHFetchResult? assets)
		{
			var assetCollection__handle__ = assetCollection!.GetNonNullHandle (nameof (assetCollection));
			var assets__handle__ = assets.GetHandle ();
			PHAssetCollectionChangeRequest? ret;
			ret =  Runtime.GetNSObject<PHAssetCollectionChangeRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selChangeRequestForAssetCollection_Assets_XHandle, assetCollection__handle__, assets__handle__), false)!;
			GC.KeepAlive (assetCollection);
			GC.KeepAlive (assets);
			return ret!;
		}
		[Export ("creationRequestForAssetCollectionWithTitle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHAssetCollectionChangeRequest CreateAssetCollection (string title)
		{
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			PHAssetCollectionChangeRequest? ret;
			ret =  Runtime.GetNSObject<PHAssetCollectionChangeRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selCreationRequestForAssetCollectionWithTitle_XHandle, nstitle), false)!;
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
		[Export ("deleteAssetCollections:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DeleteAssetCollections (PHAssetCollection[] assetCollections)
		{
			if (assetCollections is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (assetCollections));
			using var nsa_assetCollections = NSArray.FromNSObjects (assetCollections);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selDeleteAssetCollections_XHandle, nsa_assetCollections.Handle);
		}
		[Export ("insertAssets:atIndexes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertAssets (PHObject[] assets, NSIndexSet indexes)
		{
			if (assets is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (assets));
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			using var nsa_assets = NSArray.FromNSObjects (assets);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInsertAssets_AtIndexes_XHandle, nsa_assets.Handle, indexes__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInsertAssets_AtIndexes_XHandle, nsa_assets.Handle, indexes__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
		}
		/// <param name="fromIndexes">To be added.</param><param name="toIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("moveAssetsAtIndexes:toIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveAssets (NSIndexSet fromIndexes, nuint toIndex)
		{
			var fromIndexes__handle__ = fromIndexes!.GetNonNullHandle (nameof (fromIndexes));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selMoveAssetsAtIndexes_ToIndex_XHandle, fromIndexes__handle__, toIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selMoveAssetsAtIndexes_ToIndex_XHandle, fromIndexes__handle__, toIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fromIndexes);
		}
		[Export ("removeAssets:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAssets (PHObject[] assets)
		{
			if (assets is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (assets));
			using var nsa_assets = NSArray.FromNSObjects (assets);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveAssets_XHandle, nsa_assets.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveAssets_XHandle, nsa_assets.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeAssetsAtIndexes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAssets (NSIndexSet indexes)
		{
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveAssetsAtIndexes_XHandle, indexes__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveAssetsAtIndexes_XHandle, indexes__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
		}
		[Export ("replaceAssetsAtIndexes:withAssets:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceAssets (NSIndexSet indexes, PHObject[] assets)
		{
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			if (assets is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (assets));
			using var nsa_assets = NSArray.FromNSObjects (assets);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selReplaceAssetsAtIndexes_WithAssets_XHandle, indexes__handle__, nsa_assets.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selReplaceAssetsAtIndexes_WithAssets_XHandle, indexes__handle__, nsa_assets.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PHObjectPlaceholder PlaceholderForCreatedAssetCollection {
			[Export ("placeholderForCreatedAssetCollection", ArgumentSemantic.Retain)]
			get {
				PHObjectPlaceholder? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PHObjectPlaceholder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPlaceholderForCreatedAssetCollectionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PHObjectPlaceholder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPlaceholderForCreatedAssetCollectionXHandle), false)!;
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
	} /* class PHAssetCollectionChangeRequest */
}
