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
	/// <summary>Differences between a fetch previously performed and what would be the results if the same fetch were performed now.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Photos/Reference/PHFetchResultChangeDetails_Class/index.html">Apple documentation for <c>PHFetchResultChangeDetails</c></related>
	[Register("PHFetchResultChangeDetails", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class PHFetchResultChangeDetails : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeDetailsFromFetchResult_ToFetchResult_ChangedObjects_X = "changeDetailsFromFetchResult:toFetchResult:changedObjects:";
		static readonly NativeHandle selChangeDetailsFromFetchResult_ToFetchResult_ChangedObjects_XHandle = Selector.GetHandle ("changeDetailsFromFetchResult:toFetchResult:changedObjects:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangedIndexesX = "changedIndexes";
		static readonly NativeHandle selChangedIndexesXHandle = Selector.GetHandle ("changedIndexes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangedObjectsX = "changedObjects";
		static readonly NativeHandle selChangedObjectsXHandle = Selector.GetHandle ("changedObjects");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateMovesWithBlock_X = "enumerateMovesWithBlock:";
		static readonly NativeHandle selEnumerateMovesWithBlock_XHandle = Selector.GetHandle ("enumerateMovesWithBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchResultAfterChangesX = "fetchResultAfterChanges";
		static readonly NativeHandle selFetchResultAfterChangesXHandle = Selector.GetHandle ("fetchResultAfterChanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchResultBeforeChangesX = "fetchResultBeforeChanges";
		static readonly NativeHandle selFetchResultBeforeChangesXHandle = Selector.GetHandle ("fetchResultBeforeChanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasIncrementalChangesX = "hasIncrementalChanges";
		static readonly NativeHandle selHasIncrementalChangesXHandle = Selector.GetHandle ("hasIncrementalChanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasMovesX = "hasMoves";
		static readonly NativeHandle selHasMovesXHandle = Selector.GetHandle ("hasMoves");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertedIndexesX = "insertedIndexes";
		static readonly NativeHandle selInsertedIndexesXHandle = Selector.GetHandle ("insertedIndexes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertedObjectsX = "insertedObjects";
		static readonly NativeHandle selInsertedObjectsXHandle = Selector.GetHandle ("insertedObjects");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemovedIndexesX = "removedIndexes";
		static readonly NativeHandle selRemovedIndexesXHandle = Selector.GetHandle ("removedIndexes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemovedObjectsX = "removedObjects";
		static readonly NativeHandle selRemovedObjectsXHandle = Selector.GetHandle ("removedObjects");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PHFetchResultChangeDetails");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="PHFetchResultChangeDetails" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PHFetchResultChangeDetails () : base (NSObjectFlag.Empty)
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
		protected PHFetchResultChangeDetails (NSObjectFlag t) : base (t)
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
		protected internal PHFetchResultChangeDetails (NativeHandle handle) : base (handle)
		{
		}

		[Export ("changeDetailsFromFetchResult:toFetchResult:changedObjects:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHFetchResultChangeDetails ChangeDetails (PHFetchResult fromResult, PHFetchResult toResult, PHObject[] changedObjects)
		{
			var fromResult__handle__ = fromResult!.GetNonNullHandle (nameof (fromResult));
			var toResult__handle__ = toResult!.GetNonNullHandle (nameof (toResult));
			if (changedObjects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (changedObjects));
			using var nsa_changedObjects = NSArray.FromNSObjects (changedObjects);
			PHFetchResultChangeDetails? ret;
			ret =  Runtime.GetNSObject<PHFetchResultChangeDetails> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selChangeDetailsFromFetchResult_ToFetchResult_ChangedObjects_XHandle, fromResult__handle__, toResult__handle__, nsa_changedObjects.Handle), false)!;
			GC.KeepAlive (fromResult);
			GC.KeepAlive (toResult);
			return ret!;
		}
		[Export ("enumerateMovesWithBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateMoves ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPHChangeDetailEnumerator))]PHChangeDetailEnumerator handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDPHChangeDetailEnumerator.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEnumerateMovesWithBlock_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEnumerateMovesWithBlock_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexSet? ChangedIndexes {
			[Export ("changedIndexes", ArgumentSemantic.Retain)]
			get {
				NSIndexSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selChangedIndexesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selChangedIndexesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PHObject[] ChangedObjects {
			[Export ("changedObjects", ArgumentSemantic.Retain)]
			get {
				PHObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<PHObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selChangedObjectsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<PHObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selChangedObjectsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PHFetchResult FetchResultAfterChanges {
			[Export ("fetchResultAfterChanges", ArgumentSemantic.Retain)]
			get {
				PHFetchResult? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PHFetchResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFetchResultAfterChangesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PHFetchResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFetchResultAfterChangesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PHFetchResult FetchResultBeforeChanges {
			[Export ("fetchResultBeforeChanges", ArgumentSemantic.Retain)]
			get {
				PHFetchResult? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PHFetchResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFetchResultBeforeChangesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PHFetchResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFetchResultBeforeChangesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasIncrementalChanges {
			[Export ("hasIncrementalChanges")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasIncrementalChangesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasIncrementalChangesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasMoves {
			[Export ("hasMoves")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasMovesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasMovesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexSet? InsertedIndexes {
			[Export ("insertedIndexes", ArgumentSemantic.Retain)]
			get {
				NSIndexSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInsertedIndexesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInsertedIndexesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PHObject[] InsertedObjects {
			[Export ("insertedObjects", ArgumentSemantic.Retain)]
			get {
				PHObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<PHObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInsertedObjectsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<PHObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInsertedObjectsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexSet? RemovedIndexes {
			[Export ("removedIndexes", ArgumentSemantic.Retain)]
			get {
				NSIndexSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRemovedIndexesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRemovedIndexesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PHObject[] RemovedObjects {
			[Export ("removedObjects", ArgumentSemantic.Retain)]
			get {
				PHObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<PHObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRemovedObjectsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<PHObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRemovedObjectsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class PHFetchResultChangeDetails */
}
