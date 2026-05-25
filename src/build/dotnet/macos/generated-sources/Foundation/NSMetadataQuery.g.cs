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
	[Register("NSMetadataQuery", true)]
	public unsafe partial class NSMetadataQuery : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisableUpdatesX = "disableUpdates";
		static readonly NativeHandle selDisableUpdatesXHandle = Selector.GetHandle ("disableUpdates");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnableUpdatesX = "enableUpdates";
		static readonly NativeHandle selEnableUpdatesXHandle = Selector.GetHandle ("enableUpdates");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateResultsUsingBlock_X = "enumerateResultsUsingBlock:";
		static readonly NativeHandle selEnumerateResultsUsingBlock_XHandle = Selector.GetHandle ("enumerateResultsUsingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateResultsWithOptions_UsingBlock_X = "enumerateResultsWithOptions:usingBlock:";
		static readonly NativeHandle selEnumerateResultsWithOptions_UsingBlock_XHandle = Selector.GetHandle ("enumerateResultsWithOptions:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGroupedResultsX = "groupedResults";
		static readonly NativeHandle selGroupedResultsXHandle = Selector.GetHandle ("groupedResults");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGroupingAttributesX = "groupingAttributes";
		static readonly NativeHandle selGroupingAttributesXHandle = Selector.GetHandle ("groupingAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexOfResult_X = "indexOfResult:";
		static readonly NativeHandle selIndexOfResult_XHandle = Selector.GetHandle ("indexOfResult:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsGatheringX = "isGathering";
		static readonly NativeHandle selIsGatheringXHandle = Selector.GetHandle ("isGathering");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsStartedX = "isStarted";
		static readonly NativeHandle selIsStartedXHandle = Selector.GetHandle ("isStarted");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsStoppedX = "isStopped";
		static readonly NativeHandle selIsStoppedXHandle = Selector.GetHandle ("isStopped");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNotificationBatchingIntervalX = "notificationBatchingInterval";
		static readonly NativeHandle selNotificationBatchingIntervalXHandle = Selector.GetHandle ("notificationBatchingInterval");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOperationQueueX = "operationQueue";
		static readonly NativeHandle selOperationQueueXHandle = Selector.GetHandle ("operationQueue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateX = "predicate";
		static readonly NativeHandle selPredicateXHandle = Selector.GetHandle ("predicate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultAtIndex_X = "resultAtIndex:";
		static readonly NativeHandle selResultAtIndex_XHandle = Selector.GetHandle ("resultAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultCountX = "resultCount";
		static readonly NativeHandle selResultCountXHandle = Selector.GetHandle ("resultCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultsX = "results";
		static readonly NativeHandle selResultsXHandle = Selector.GetHandle ("results");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSearchItemsX = "searchItems";
		static readonly NativeHandle selSearchItemsXHandle = Selector.GetHandle ("searchItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSearchScopesX = "searchScopes";
		static readonly NativeHandle selSearchScopesXHandle = Selector.GetHandle ("searchScopes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGroupingAttributes_X = "setGroupingAttributes:";
		static readonly NativeHandle selSetGroupingAttributes_XHandle = Selector.GetHandle ("setGroupingAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNotificationBatchingInterval_X = "setNotificationBatchingInterval:";
		static readonly NativeHandle selSetNotificationBatchingInterval_XHandle = Selector.GetHandle ("setNotificationBatchingInterval:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOperationQueue_X = "setOperationQueue:";
		static readonly NativeHandle selSetOperationQueue_XHandle = Selector.GetHandle ("setOperationQueue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPredicate_X = "setPredicate:";
		static readonly NativeHandle selSetPredicate_XHandle = Selector.GetHandle ("setPredicate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSearchItems_X = "setSearchItems:";
		static readonly NativeHandle selSetSearchItems_XHandle = Selector.GetHandle ("setSearchItems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSearchScopes_X = "setSearchScopes:";
		static readonly NativeHandle selSetSearchScopes_XHandle = Selector.GetHandle ("setSearchScopes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSortDescriptors_X = "setSortDescriptors:";
		static readonly NativeHandle selSetSortDescriptors_XHandle = Selector.GetHandle ("setSortDescriptors:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetValueListAttributes_X = "setValueListAttributes:";
		static readonly NativeHandle selSetValueListAttributes_XHandle = Selector.GetHandle ("setValueListAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSortDescriptorsX = "sortDescriptors";
		static readonly NativeHandle selSortDescriptorsXHandle = Selector.GetHandle ("sortDescriptors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartQueryX = "startQuery";
		static readonly NativeHandle selStartQueryXHandle = Selector.GetHandle ("startQuery");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopQueryX = "stopQuery";
		static readonly NativeHandle selStopQueryXHandle = Selector.GetHandle ("stopQuery");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueListAttributesX = "valueListAttributes";
		static readonly NativeHandle selValueListAttributesXHandle = Selector.GetHandle ("valueListAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueListsX = "valueLists";
		static readonly NativeHandle selValueListsXHandle = Selector.GetHandle ("valueLists");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueOfAttribute_ForResultAtIndex_X = "valueOfAttribute:forResultAtIndex:";
		static readonly NativeHandle selValueOfAttribute_ForResultAtIndex_XHandle = Selector.GetHandle ("valueOfAttribute:forResultAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSMetadataQuery");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSMetadataQuery" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSMetadataQuery () : base (NSObjectFlag.Empty)
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
		protected NSMetadataQuery (NSObjectFlag t) : base (t)
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
		protected internal NSMetadataQuery (NativeHandle handle) : base (handle)
		{
		}

		[Export ("disableUpdates")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisableUpdates ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDisableUpdatesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDisableUpdatesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("enableUpdates")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnableUpdates ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selEnableUpdatesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selEnableUpdatesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("enumerateResultsUsingBlock:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateResultsUsingBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSMetadataQueryEnumerationCallback))]NSMetadataQueryEnumerationCallback callback)
		{
			if (callback is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (callback));
			using var block_callback = Trampolines.SDNSMetadataQueryEnumerationCallback.CreateBlock (callback);
			BlockLiteral *block_ptr_callback = &block_callback;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEnumerateResultsUsingBlock_XHandle, (IntPtr) block_ptr_callback);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEnumerateResultsUsingBlock_XHandle, (IntPtr) block_ptr_callback);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("enumerateResultsWithOptions:usingBlock:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateResultsWithOptions (NSEnumerationOptions opts, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSMetadataQueryEnumerationCallback))]NSMetadataQueryEnumerationCallback block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDNSMetadataQueryEnumerationCallback.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle (this.Handle, selEnumerateResultsWithOptions_UsingBlock_XHandle, (UIntPtr) (ulong) opts, (IntPtr) block_ptr_block);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, selEnumerateResultsWithOptions_UsingBlock_XHandle, (UIntPtr) (ulong) opts, (IntPtr) block_ptr_block);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("indexOfResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint IndexOfResult (NSObject result)
		{
			var result__handle__ = result!.GetNonNullHandle (nameof (result));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selIndexOfResult_XHandle, result__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selIndexOfResult_XHandle, result__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (result);
			return ret!;
		}
		/// <param name="idx">To be added.</param><summary>The result at the specified index.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resultAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ResultAtIndex (nint idx)
		{
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selResultAtIndex_XHandle, idx), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selResultAtIndex_XHandle, idx), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("startQuery")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool StartQuery ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selStartQueryXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selStartQueryXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("stopQuery")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopQuery ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopQueryXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopQueryXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="attribyteName">To be added.</param><param name="atIndex">To be added.</param><summary>The value of the specified attributeName in the result at the specified index in the Results array.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("valueOfAttribute:forResultAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ValueOfAttribute (string attribyteName, nint atIndex)
		{
			if (attribyteName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (attribyteName));
			var nsattribyteName = CFString.CreateNative (attribyteName);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, selValueOfAttribute_ForResultAtIndex_XHandle, nsattribyteName, atIndex), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selValueOfAttribute_ForResultAtIndex_XHandle, nsattribyteName, atIndex), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsattribyteName);
			return ret!;
		}
		/// <summary>An instance of the Foundation.INSMetadataQueryDelegate model class which acts as the class delegate.</summary><value>The instance of the Foundation.INSMetadataQueryDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSMetadataQueryDelegate Delegate {
			get {
				return (WeakDelegate as INSMetadataQueryDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] GroupedResults {
			[Export ("groupedResults")]
			get {
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGroupedResultsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGroupedResultsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray GroupingAttributes {
			[Export ("groupingAttributes", ArgumentSemantic.Copy)]
			get {
				NSArray? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGroupingAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGroupingAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setGroupingAttributes:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetGroupingAttributes_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetGroupingAttributes_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Whether this query is in the initial gathering phase of the query.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsGathering {
			[Export ("isGathering")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsGatheringXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsGatheringXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Whether this query has begun.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsStarted {
			[Export ("isStarted")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsStartedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsStartedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Whether this query has stopped.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsStopped {
			[Export ("isStopped")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsStoppedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsStoppedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double NotificationBatchingInterval {
			[Export ("notificationBatchingInterval")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selNotificationBatchingIntervalXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selNotificationBatchingIntervalXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setNotificationBatchingInterval:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetNotificationBatchingInterval_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetNotificationBatchingInterval_XHandle, value);
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
		public virtual NSOperationQueue? OperationQueue {
			[Export ("operationQueue", ArgumentSemantic.Retain)]
			get {
				NSOperationQueue? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSOperationQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOperationQueueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSOperationQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOperationQueueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOperationQueue:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetOperationQueue_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetOperationQueue_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPredicate? Predicate {
			[Export ("predicate", ArgumentSemantic.Copy)]
			get {
				NSPredicate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPredicateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPredicateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPredicate:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPredicate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPredicate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ResultCount {
			[Export ("resultCount")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selResultCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selResultCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMetadataItem[] Results {
			[Export ("results")]
			get {
				NSMetadataItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSMetadataItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selResultsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSMetadataItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selResultsXHandle), false)!;
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
		public virtual NSObject[]? SearchItems {
			[Export ("searchItems", ArgumentSemantic.Copy)]
			get {
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSearchItemsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSearchItemsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSearchItems:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSearchItems_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSearchItems_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] SearchScopes {
			[Export ("searchScopes", ArgumentSemantic.Copy)]
			get {
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSearchScopesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSearchScopesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSearchScopes:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSearchScopes_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSearchScopes_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSortDescriptor[] SortDescriptors {
			[Export ("sortDescriptors", ArgumentSemantic.Copy)]
			get {
				NSSortDescriptor[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSSortDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSortDescriptorsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSSortDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSortDescriptorsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSortDescriptors:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSortDescriptors_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSortDescriptors_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] ValueListAttributes {
			[Export ("valueListAttributes", ArgumentSemantic.Copy)]
			get {
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selValueListAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selValueListAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setValueListAttributes:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetValueListAttributes_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetValueListAttributes_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary ValueLists {
			[Export ("valueLists")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selValueListsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selValueListsXHandle), false)!;
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
				NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
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
		static NSString? _AccessibleUbiquitousExternalDocumentsScope;
		/// <summary>Represents the value associated with the constant NSMetadataQueryAccessibleUbiquitousExternalDocumentsScope</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataQueryAccessibleUbiquitousExternalDocumentsScope",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AccessibleUbiquitousExternalDocumentsScope {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AccessibleUbiquitousExternalDocumentsScope is null)
					_AccessibleUbiquitousExternalDocumentsScope = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataQueryAccessibleUbiquitousExternalDocumentsScope")!;
				return _AccessibleUbiquitousExternalDocumentsScope;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AcquisitionMakeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemAcquisitionMakeKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AcquisitionMakeKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AcquisitionMakeKey is null)
					_AcquisitionMakeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemAcquisitionMakeKey")!;
				return _AcquisitionMakeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AcquisitionModelKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemAcquisitionModelKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AcquisitionModelKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AcquisitionModelKey is null)
					_AcquisitionModelKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemAcquisitionModelKey")!;
				return _AcquisitionModelKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AlbumKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemAlbumKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AlbumKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AlbumKey is null)
					_AlbumKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemAlbumKey")!;
				return _AlbumKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AltitudeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemAltitudeKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AltitudeKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AltitudeKey is null)
					_AltitudeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemAltitudeKey")!;
				return _AltitudeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApertureKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemApertureKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ApertureKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ApertureKey is null)
					_ApertureKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemApertureKey")!;
				return _ApertureKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleLoopDescriptorsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemAppleLoopDescriptorsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AppleLoopDescriptorsKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AppleLoopDescriptorsKey is null)
					_AppleLoopDescriptorsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemAppleLoopDescriptorsKey")!;
				return _AppleLoopDescriptorsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleLoopsKeyFilterTypeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemAppleLoopsKeyFilterTypeKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AppleLoopsKeyFilterTypeKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AppleLoopsKeyFilterTypeKey is null)
					_AppleLoopsKeyFilterTypeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemAppleLoopsKeyFilterTypeKey")!;
				return _AppleLoopsKeyFilterTypeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleLoopsLoopModeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemAppleLoopsLoopModeKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AppleLoopsLoopModeKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AppleLoopsLoopModeKey is null)
					_AppleLoopsLoopModeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemAppleLoopsLoopModeKey")!;
				return _AppleLoopsLoopModeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleLoopsRootKeyKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemAppleLoopsRootKeyKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AppleLoopsRootKeyKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AppleLoopsRootKeyKey is null)
					_AppleLoopsRootKeyKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemAppleLoopsRootKeyKey")!;
				return _AppleLoopsRootKeyKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApplicationCategoriesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemApplicationCategoriesKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ApplicationCategoriesKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ApplicationCategoriesKey is null)
					_ApplicationCategoriesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemApplicationCategoriesKey")!;
				return _ApplicationCategoriesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AudiencesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemAudiencesKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AudiencesKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AudiencesKey is null)
					_AudiencesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemAudiencesKey")!;
				return _AudiencesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AudioBitRateKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemAudioBitRateKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AudioBitRateKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AudioBitRateKey is null)
					_AudioBitRateKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemAudioBitRateKey")!;
				return _AudioBitRateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AudioChannelCountKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemAudioChannelCountKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AudioChannelCountKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AudioChannelCountKey is null)
					_AudioChannelCountKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemAudioChannelCountKey")!;
				return _AudioChannelCountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AudioEncodingApplicationKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemAudioEncodingApplicationKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AudioEncodingApplicationKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AudioEncodingApplicationKey is null)
					_AudioEncodingApplicationKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemAudioEncodingApplicationKey")!;
				return _AudioEncodingApplicationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AudioSampleRateKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemAudioSampleRateKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AudioSampleRateKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AudioSampleRateKey is null)
					_AudioSampleRateKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemAudioSampleRateKey")!;
				return _AudioSampleRateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AudioTrackNumberKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemAudioTrackNumberKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AudioTrackNumberKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AudioTrackNumberKey is null)
					_AudioTrackNumberKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemAudioTrackNumberKey")!;
				return _AudioTrackNumberKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuthorAddressesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemAuthorAddressesKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuthorAddressesKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuthorAddressesKey is null)
					_AuthorAddressesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemAuthorAddressesKey")!;
				return _AuthorAddressesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuthorEmailAddressesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemAuthorEmailAddressesKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuthorEmailAddressesKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuthorEmailAddressesKey is null)
					_AuthorEmailAddressesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemAuthorEmailAddressesKey")!;
				return _AuthorEmailAddressesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuthorsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemAuthorsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuthorsKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuthorsKey is null)
					_AuthorsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemAuthorsKey")!;
				return _AuthorsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BitsPerSampleKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemBitsPerSampleKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString BitsPerSampleKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_BitsPerSampleKey is null)
					_BitsPerSampleKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemBitsPerSampleKey")!;
				return _BitsPerSampleKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CFBundleIdentifierKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemCFBundleIdentifierKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CFBundleIdentifierKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CFBundleIdentifierKey is null)
					_CFBundleIdentifierKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemCFBundleIdentifierKey")!;
				return _CFBundleIdentifierKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CameraOwnerKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemCameraOwnerKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CameraOwnerKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CameraOwnerKey is null)
					_CameraOwnerKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemCameraOwnerKey")!;
				return _CameraOwnerKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CityKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemCityKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CityKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CityKey is null)
					_CityKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemCityKey")!;
				return _CityKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CodecsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemCodecsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CodecsKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CodecsKey is null)
					_CodecsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemCodecsKey")!;
				return _CodecsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColorSpaceKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemColorSpaceKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ColorSpaceKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ColorSpaceKey is null)
					_ColorSpaceKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemColorSpaceKey")!;
				return _ColorSpaceKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommentKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemCommentKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CommentKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CommentKey is null)
					_CommentKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemCommentKey")!;
				return _CommentKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ComposerKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemComposerKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ComposerKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ComposerKey is null)
					_ComposerKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemComposerKey")!;
				return _ComposerKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContactKeywordsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemContactKeywordsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ContactKeywordsKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ContactKeywordsKey is null)
					_ContactKeywordsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemContactKeywordsKey")!;
				return _ContactKeywordsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentCreationDateKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemContentCreationDateKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ContentCreationDateKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ContentCreationDateKey is null)
					_ContentCreationDateKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemContentCreationDateKey")!;
				return _ContentCreationDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentModificationDateKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemContentModificationDateKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ContentModificationDateKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ContentModificationDateKey is null)
					_ContentModificationDateKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemContentModificationDateKey")!;
				return _ContentModificationDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentTypeKey;
		/// <summary>Represents the value associated with the constant NSMetadataItemContentTypeKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemContentTypeKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ContentTypeKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ContentTypeKey is null)
					_ContentTypeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemContentTypeKey")!;
				return _ContentTypeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentTypeTreeKey;
		/// <summary>Represents the value associated with the constant NSMetadataItemContentTypeTreeKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemContentTypeTreeKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ContentTypeTreeKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ContentTypeTreeKey is null)
					_ContentTypeTreeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemContentTypeTreeKey")!;
				return _ContentTypeTreeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContributorsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemContributorsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ContributorsKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ContributorsKey is null)
					_ContributorsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemContributorsKey")!;
				return _ContributorsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CopyrightKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemCopyrightKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CopyrightKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CopyrightKey is null)
					_CopyrightKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemCopyrightKey")!;
				return _CopyrightKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CountryKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemCountryKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CountryKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CountryKey is null)
					_CountryKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemCountryKey")!;
				return _CountryKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CoverageKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemCoverageKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CoverageKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CoverageKey is null)
					_CoverageKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemCoverageKey")!;
				return _CoverageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreatorKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemCreatorKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CreatorKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CreatorKey is null)
					_CreatorKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemCreatorKey")!;
				return _CreatorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DateAddedKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemDateAddedKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString DateAddedKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DateAddedKey is null)
					_DateAddedKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemDateAddedKey")!;
				return _DateAddedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DeliveryTypeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemDeliveryTypeKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString DeliveryTypeKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DeliveryTypeKey is null)
					_DeliveryTypeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemDeliveryTypeKey")!;
				return _DeliveryTypeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DescriptionKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemDescriptionKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString DescriptionKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DescriptionKey is null)
					_DescriptionKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemDescriptionKey")!;
				return _DescriptionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidFinishGatheringNotification;
		/// <summary>Notification constant for DidFinishGathering</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidFinishGathering(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidFinishGathering(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSMetadataQuery.Notifications.ObserveDidFinishGathering ((sender, args) => {
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
		/// void Callback (object sender, NSMetadataQuery.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSMetadataQuery.Notifications.ObserveDidFinishGathering (Callback);
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
		///     NSMetadataQuery.DidFinishGatheringNotification, (notification) => { Console.WriteLine ("Received the notification DidFinishGathering", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidFinishGathering", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSMetadataQuery.DidFinishGatheringNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSMetadataQueryDidFinishGatheringNotification",  "Foundation")]
		[Advice ("Use NSMetadataQuery.Notifications.ObserveDidFinishGathering helper method instead.")]
		public static NSString DidFinishGatheringNotification {
			get {
				if (_DidFinishGatheringNotification is null)
					_DidFinishGatheringNotification = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataQueryDidFinishGatheringNotification")!;
				return _DidFinishGatheringNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidStartGatheringNotification;
		/// <summary>Notification constant for DidStartGathering</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidStartGathering(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidStartGathering(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSMetadataQuery.Notifications.ObserveDidStartGathering ((sender, args) => {
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
		/// void Callback (object sender, NSMetadataQuery.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSMetadataQuery.Notifications.ObserveDidStartGathering (Callback);
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
		///     NSMetadataQuery.DidStartGatheringNotification, (notification) => { Console.WriteLine ("Received the notification DidStartGathering", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidStartGathering", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSMetadataQuery.DidStartGatheringNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSMetadataQueryDidStartGatheringNotification",  "Foundation")]
		[Advice ("Use NSMetadataQuery.Notifications.ObserveDidStartGathering helper method instead.")]
		public static NSString DidStartGatheringNotification {
			get {
				if (_DidStartGatheringNotification is null)
					_DidStartGatheringNotification = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataQueryDidStartGatheringNotification")!;
				return _DidStartGatheringNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidUpdateNotification;
		/// <summary>Notification constant for DidUpdate</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidUpdate(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidUpdate(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSMetadataQuery.Notifications.ObserveDidUpdate ((sender, args) => {
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
		/// void Callback (object sender, NSMetadataQuery.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSMetadataQuery.Notifications.ObserveDidUpdate (Callback);
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
		///     NSMetadataQuery.DidUpdateNotification, (notification) => { Console.WriteLine ("Received the notification DidUpdate", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidUpdate", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSMetadataQuery.DidUpdateNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSMetadataQueryDidUpdateNotification",  "Foundation")]
		[Advice ("Use NSMetadataQuery.Notifications.ObserveDidUpdate helper method instead.")]
		public static NSString DidUpdateNotification {
			get {
				if (_DidUpdateNotification is null)
					_DidUpdateNotification = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataQueryDidUpdateNotification")!;
				return _DidUpdateNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DirectorKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemDirectorKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString DirectorKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DirectorKey is null)
					_DirectorKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemDirectorKey")!;
				return _DirectorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DownloadedDateKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemDownloadedDateKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString DownloadedDateKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DownloadedDateKey is null)
					_DownloadedDateKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemDownloadedDateKey")!;
				return _DownloadedDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DueDateKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemDueDateKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString DueDateKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DueDateKey is null)
					_DueDateKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemDueDateKey")!;
				return _DueDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DurationSecondsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemDurationSecondsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString DurationSecondsKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DurationSecondsKey is null)
					_DurationSecondsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemDurationSecondsKey")!;
				return _DurationSecondsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EditorsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemEditorsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString EditorsKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_EditorsKey is null)
					_EditorsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemEditorsKey")!;
				return _EditorsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EmailAddressesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemEmailAddressesKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString EmailAddressesKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_EmailAddressesKey is null)
					_EmailAddressesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemEmailAddressesKey")!;
				return _EmailAddressesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodingApplicationsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemEncodingApplicationsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString EncodingApplicationsKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_EncodingApplicationsKey is null)
					_EncodingApplicationsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemEncodingApplicationsKey")!;
				return _EncodingApplicationsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExecutableArchitecturesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemExecutableArchitecturesKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExecutableArchitecturesKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExecutableArchitecturesKey is null)
					_ExecutableArchitecturesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemExecutableArchitecturesKey")!;
				return _ExecutableArchitecturesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExecutablePlatformKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemExecutablePlatformKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExecutablePlatformKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExecutablePlatformKey is null)
					_ExecutablePlatformKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemExecutablePlatformKey")!;
				return _ExecutablePlatformKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifGpsVersionKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemEXIFGPSVersionKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExifGpsVersionKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExifGpsVersionKey is null)
					_ExifGpsVersionKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemEXIFGPSVersionKey")!;
				return _ExifGpsVersionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifVersionKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemEXIFVersionKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExifVersionKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExifVersionKey is null)
					_ExifVersionKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemEXIFVersionKey")!;
				return _ExifVersionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExposureModeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemExposureModeKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExposureModeKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExposureModeKey is null)
					_ExposureModeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemExposureModeKey")!;
				return _ExposureModeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExposureProgramKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemExposureProgramKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExposureProgramKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExposureProgramKey is null)
					_ExposureProgramKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemExposureProgramKey")!;
				return _ExposureProgramKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExposureTimeSecondsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemExposureTimeSecondsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExposureTimeSecondsKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExposureTimeSecondsKey is null)
					_ExposureTimeSecondsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemExposureTimeSecondsKey")!;
				return _ExposureTimeSecondsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExposureTimeStringKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemExposureTimeStringKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExposureTimeStringKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExposureTimeStringKey is null)
					_ExposureTimeStringKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemExposureTimeStringKey")!;
				return _ExposureTimeStringKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FNumberKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemFNumberKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString FNumberKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FNumberKey is null)
					_FNumberKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemFNumberKey")!;
				return _FNumberKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FinderCommentKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemFinderCommentKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString FinderCommentKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FinderCommentKey is null)
					_FinderCommentKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemFinderCommentKey")!;
				return _FinderCommentKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FlashOnOffKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemFlashOnOffKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString FlashOnOffKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FlashOnOffKey is null)
					_FlashOnOffKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemFlashOnOffKey")!;
				return _FlashOnOffKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FocalLength35mmKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemFocalLength35mmKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString FocalLength35mmKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FocalLength35mmKey is null)
					_FocalLength35mmKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemFocalLength35mmKey")!;
				return _FocalLength35mmKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FocalLengthKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemFocalLengthKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString FocalLengthKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FocalLengthKey is null)
					_FocalLengthKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemFocalLengthKey")!;
				return _FocalLengthKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FontsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemFontsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString FontsKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_FontsKey is null)
					_FontsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemFontsKey")!;
				return _FontsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GatheringProgressNotification;
		/// <summary>Notification constant for GatheringProgress</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveGatheringProgress(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveGatheringProgress(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSMetadataQuery.Notifications.ObserveGatheringProgress ((sender, args) => {
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
		/// void Callback (object sender, NSMetadataQuery.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSMetadataQuery.Notifications.ObserveGatheringProgress (Callback);
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
		///     NSMetadataQuery.GatheringProgressNotification, (notification) => { Console.WriteLine ("Received the notification GatheringProgress", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification GatheringProgress", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSMetadataQuery.GatheringProgressNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSMetadataQueryGatheringProgressNotification",  "Foundation")]
		[Advice ("Use NSMetadataQuery.Notifications.ObserveGatheringProgress helper method instead.")]
		public static NSString GatheringProgressNotification {
			get {
				if (_GatheringProgressNotification is null)
					_GatheringProgressNotification = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataQueryGatheringProgressNotification")!;
				return _GatheringProgressNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GenreKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemGenreKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GenreKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GenreKey is null)
					_GenreKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemGenreKey")!;
				return _GenreKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GpsAreaInformationKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemGPSAreaInformationKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GpsAreaInformationKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GpsAreaInformationKey is null)
					_GpsAreaInformationKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemGPSAreaInformationKey")!;
				return _GpsAreaInformationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GpsDateStampKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemGPSDateStampKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GpsDateStampKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GpsDateStampKey is null)
					_GpsDateStampKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemGPSDateStampKey")!;
				return _GpsDateStampKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GpsDestBearingKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemGPSDestBearingKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GpsDestBearingKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GpsDestBearingKey is null)
					_GpsDestBearingKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemGPSDestBearingKey")!;
				return _GpsDestBearingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GpsDestDistanceKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemGPSDestDistanceKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GpsDestDistanceKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GpsDestDistanceKey is null)
					_GpsDestDistanceKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemGPSDestDistanceKey")!;
				return _GpsDestDistanceKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GpsDestLatitudeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemGPSDestLatitudeKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GpsDestLatitudeKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GpsDestLatitudeKey is null)
					_GpsDestLatitudeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemGPSDestLatitudeKey")!;
				return _GpsDestLatitudeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GpsDestLongitudeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemGPSDestLongitudeKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GpsDestLongitudeKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GpsDestLongitudeKey is null)
					_GpsDestLongitudeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemGPSDestLongitudeKey")!;
				return _GpsDestLongitudeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GpsDifferentalKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemGPSDifferentalKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GpsDifferentalKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GpsDifferentalKey is null)
					_GpsDifferentalKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemGPSDifferentalKey")!;
				return _GpsDifferentalKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GpsDopKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemGPSDOPKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GpsDopKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GpsDopKey is null)
					_GpsDopKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemGPSDOPKey")!;
				return _GpsDopKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GpsMapDatumKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemGPSMapDatumKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GpsMapDatumKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GpsMapDatumKey is null)
					_GpsMapDatumKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemGPSMapDatumKey")!;
				return _GpsMapDatumKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GpsMeasureModeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemGPSMeasureModeKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GpsMeasureModeKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GpsMeasureModeKey is null)
					_GpsMeasureModeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemGPSMeasureModeKey")!;
				return _GpsMeasureModeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GpsProcessingMethodKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemGPSProcessingMethodKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GpsProcessingMethodKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GpsProcessingMethodKey is null)
					_GpsProcessingMethodKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemGPSProcessingMethodKey")!;
				return _GpsProcessingMethodKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GpsStatusKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemGPSStatusKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GpsStatusKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GpsStatusKey is null)
					_GpsStatusKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemGPSStatusKey")!;
				return _GpsStatusKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GpsTrackKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemGPSTrackKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GpsTrackKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GpsTrackKey is null)
					_GpsTrackKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemGPSTrackKey")!;
				return _GpsTrackKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HasAlphaChannelKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemHasAlphaChannelKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString HasAlphaChannelKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_HasAlphaChannelKey is null)
					_HasAlphaChannelKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemHasAlphaChannelKey")!;
				return _HasAlphaChannelKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeadlineKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemHeadlineKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString HeadlineKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_HeadlineKey is null)
					_HeadlineKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemHeadlineKey")!;
				return _HeadlineKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IdentifierKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemIdentifierKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString IdentifierKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_IdentifierKey is null)
					_IdentifierKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemIdentifierKey")!;
				return _IdentifierKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ImageDirectionKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemImageDirectionKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ImageDirectionKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ImageDirectionKey is null)
					_ImageDirectionKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemImageDirectionKey")!;
				return _ImageDirectionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InformationKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemInformationKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString InformationKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_InformationKey is null)
					_InformationKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemInformationKey")!;
				return _InformationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InstantMessageAddressesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemInstantMessageAddressesKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString InstantMessageAddressesKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_InstantMessageAddressesKey is null)
					_InstantMessageAddressesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemInstantMessageAddressesKey")!;
				return _InstantMessageAddressesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InstructionsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemInstructionsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString InstructionsKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_InstructionsKey is null)
					_InstructionsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemInstructionsKey")!;
				return _InstructionsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsApplicationManagedKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemIsApplicationManagedKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString IsApplicationManagedKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_IsApplicationManagedKey is null)
					_IsApplicationManagedKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemIsApplicationManagedKey")!;
				return _IsApplicationManagedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsGeneralMidiSequenceKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemIsGeneralMIDISequenceKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString IsGeneralMidiSequenceKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_IsGeneralMidiSequenceKey is null)
					_IsGeneralMidiSequenceKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemIsGeneralMIDISequenceKey")!;
				return _IsGeneralMidiSequenceKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsLikelyJunkKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemIsLikelyJunkKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString IsLikelyJunkKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_IsLikelyJunkKey is null)
					_IsLikelyJunkKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemIsLikelyJunkKey")!;
				return _IsLikelyJunkKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsoSpeedKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemISOSpeedKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString IsoSpeedKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_IsoSpeedKey is null)
					_IsoSpeedKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemISOSpeedKey")!;
				return _IsoSpeedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItemDisplayNameKey;
		/// <summary>Represents the value associated with the constant NSMetadataItemDisplayNameKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemDisplayNameKey",  "Foundation")]
		public static NSString ItemDisplayNameKey {
			get {
				if (_ItemDisplayNameKey is null)
					_ItemDisplayNameKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemDisplayNameKey")!;
				return _ItemDisplayNameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItemFSContentChangeDateKey;
		/// <summary>Represents the value associated with the constant NSMetadataItemFSContentChangeDateKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemFSContentChangeDateKey",  "Foundation")]
		public static NSString ItemFSContentChangeDateKey {
			get {
				if (_ItemFSContentChangeDateKey is null)
					_ItemFSContentChangeDateKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemFSContentChangeDateKey")!;
				return _ItemFSContentChangeDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItemFSCreationDateKey;
		/// <summary>Represents the value associated with the constant NSMetadataItemFSCreationDateKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemFSCreationDateKey",  "Foundation")]
		public static NSString ItemFSCreationDateKey {
			get {
				if (_ItemFSCreationDateKey is null)
					_ItemFSCreationDateKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemFSCreationDateKey")!;
				return _ItemFSCreationDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItemFSNameKey;
		/// <summary>Represents the value associated with the constant NSMetadataItemFSNameKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemFSNameKey",  "Foundation")]
		public static NSString ItemFSNameKey {
			get {
				if (_ItemFSNameKey is null)
					_ItemFSNameKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemFSNameKey")!;
				return _ItemFSNameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItemFSSizeKey;
		/// <summary>Represents the value associated with the constant NSMetadataItemFSSizeKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemFSSizeKey",  "Foundation")]
		public static NSString ItemFSSizeKey {
			get {
				if (_ItemFSSizeKey is null)
					_ItemFSSizeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemFSSizeKey")!;
				return _ItemFSSizeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItemIsUbiquitousKey;
		/// <summary>Represents the value associated with the constant NSMetadataItemIsUbiquitousKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemIsUbiquitousKey",  "Foundation")]
		public static NSString ItemIsUbiquitousKey {
			get {
				if (_ItemIsUbiquitousKey is null)
					_ItemIsUbiquitousKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemIsUbiquitousKey")!;
				return _ItemIsUbiquitousKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItemPathKey;
		/// <summary>Represents the value associated with the constant NSMetadataItemPathKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemPathKey",  "Foundation")]
		public static NSString ItemPathKey {
			get {
				if (_ItemPathKey is null)
					_ItemPathKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemPathKey")!;
				return _ItemPathKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItemURLKey;
		/// <summary>Represents the value associated with the constant NSMetadataItemURLKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemURLKey",  "Foundation")]
		public static NSString ItemURLKey {
			get {
				if (_ItemURLKey is null)
					_ItemURLKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemURLKey")!;
				return _ItemURLKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeySignatureKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemKeySignatureKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString KeySignatureKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_KeySignatureKey is null)
					_KeySignatureKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemKeySignatureKey")!;
				return _KeySignatureKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeywordsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemKeywordsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString KeywordsKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_KeywordsKey is null)
					_KeywordsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemKeywordsKey")!;
				return _KeywordsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KindKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemKindKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString KindKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_KindKey is null)
					_KindKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemKindKey")!;
				return _KindKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LanguagesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemLanguagesKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString LanguagesKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_LanguagesKey is null)
					_LanguagesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemLanguagesKey")!;
				return _LanguagesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LastUsedDateKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemLastUsedDateKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString LastUsedDateKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_LastUsedDateKey is null)
					_LastUsedDateKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemLastUsedDateKey")!;
				return _LastUsedDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LatitudeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemLatitudeKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString LatitudeKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_LatitudeKey is null)
					_LatitudeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemLatitudeKey")!;
				return _LatitudeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LayerNamesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemLayerNamesKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString LayerNamesKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_LayerNamesKey is null)
					_LayerNamesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemLayerNamesKey")!;
				return _LayerNamesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LensModelKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemLensModelKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString LensModelKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_LensModelKey is null)
					_LensModelKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemLensModelKey")!;
				return _LensModelKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LocalComputerScope;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataQueryLocalComputerScope",  "Foundation")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static NSString LocalComputerScope {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_LocalComputerScope is null)
					_LocalComputerScope = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataQueryLocalComputerScope")!;
				return _LocalComputerScope;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LocalDocumentsScope;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataQueryLocalDocumentsScope",  "Foundation")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static NSString LocalDocumentsScope {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_LocalDocumentsScope is null)
					_LocalDocumentsScope = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataQueryLocalDocumentsScope")!;
				return _LocalDocumentsScope;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LongitudeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemLongitudeKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString LongitudeKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_LongitudeKey is null)
					_LongitudeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemLongitudeKey")!;
				return _LongitudeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LyricistKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemLyricistKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString LyricistKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_LyricistKey is null)
					_LyricistKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemLyricistKey")!;
				return _LyricistKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaxApertureKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemMaxApertureKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MaxApertureKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MaxApertureKey is null)
					_MaxApertureKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemMaxApertureKey")!;
				return _MaxApertureKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaTypesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemMediaTypesKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MediaTypesKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MediaTypesKey is null)
					_MediaTypesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemMediaTypesKey")!;
				return _MediaTypesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MeteringModeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemMeteringModeKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MeteringModeKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MeteringModeKey is null)
					_MeteringModeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemMeteringModeKey")!;
				return _MeteringModeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MusicalGenreKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemMusicalGenreKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MusicalGenreKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MusicalGenreKey is null)
					_MusicalGenreKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemMusicalGenreKey")!;
				return _MusicalGenreKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MusicalInstrumentCategoryKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemMusicalInstrumentCategoryKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MusicalInstrumentCategoryKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MusicalInstrumentCategoryKey is null)
					_MusicalInstrumentCategoryKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemMusicalInstrumentCategoryKey")!;
				return _MusicalInstrumentCategoryKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MusicalInstrumentNameKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemMusicalInstrumentNameKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MusicalInstrumentNameKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MusicalInstrumentNameKey is null)
					_MusicalInstrumentNameKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemMusicalInstrumentNameKey")!;
				return _MusicalInstrumentNameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NamedLocationKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemNamedLocationKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NamedLocationKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NamedLocationKey is null)
					_NamedLocationKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemNamedLocationKey")!;
				return _NamedLocationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NetworkScope;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataQueryNetworkScope",  "Foundation")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static NSString NetworkScope {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NetworkScope is null)
					_NetworkScope = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataQueryNetworkScope")!;
				return _NetworkScope;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NumberOfPagesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemNumberOfPagesKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NumberOfPagesKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NumberOfPagesKey is null)
					_NumberOfPagesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemNumberOfPagesKey")!;
				return _NumberOfPagesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OrganizationsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemOrganizationsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString OrganizationsKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_OrganizationsKey is null)
					_OrganizationsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemOrganizationsKey")!;
				return _OrganizationsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OrientationKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemOrientationKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString OrientationKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_OrientationKey is null)
					_OrientationKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemOrientationKey")!;
				return _OrientationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OriginalFormatKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemOriginalFormatKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString OriginalFormatKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_OriginalFormatKey is null)
					_OriginalFormatKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemOriginalFormatKey")!;
				return _OriginalFormatKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OriginalSourceKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemOriginalSourceKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString OriginalSourceKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_OriginalSourceKey is null)
					_OriginalSourceKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemOriginalSourceKey")!;
				return _OriginalSourceKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PageHeightKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemPageHeightKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PageHeightKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PageHeightKey is null)
					_PageHeightKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemPageHeightKey")!;
				return _PageHeightKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PageWidthKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemPageWidthKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PageWidthKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PageWidthKey is null)
					_PageWidthKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemPageWidthKey")!;
				return _PageWidthKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParticipantsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemParticipantsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ParticipantsKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ParticipantsKey is null)
					_ParticipantsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemParticipantsKey")!;
				return _ParticipantsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PerformersKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemPerformersKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PerformersKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PerformersKey is null)
					_PerformersKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemPerformersKey")!;
				return _PerformersKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PhoneNumbersKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemPhoneNumbersKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PhoneNumbersKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PhoneNumbersKey is null)
					_PhoneNumbersKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemPhoneNumbersKey")!;
				return _PhoneNumbersKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelCountKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemPixelCountKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PixelCountKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PixelCountKey is null)
					_PixelCountKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemPixelCountKey")!;
				return _PixelCountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelHeightKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemPixelHeightKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PixelHeightKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PixelHeightKey is null)
					_PixelHeightKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemPixelHeightKey")!;
				return _PixelHeightKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelWidthKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemPixelWidthKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PixelWidthKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PixelWidthKey is null)
					_PixelWidthKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemPixelWidthKey")!;
				return _PixelWidthKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProducerKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemProducerKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ProducerKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ProducerKey is null)
					_ProducerKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemProducerKey")!;
				return _ProducerKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileNameKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemProfileNameKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ProfileNameKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ProfileNameKey is null)
					_ProfileNameKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemProfileNameKey")!;
				return _ProfileNameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProjectsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemProjectsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ProjectsKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ProjectsKey is null)
					_ProjectsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemProjectsKey")!;
				return _ProjectsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PublishersKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemPublishersKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PublishersKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PublishersKey is null)
					_PublishersKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemPublishersKey")!;
				return _PublishersKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QueryUpdateAddedItemsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataQueryUpdateAddedItemsKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString QueryUpdateAddedItemsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_QueryUpdateAddedItemsKey is null)
					_QueryUpdateAddedItemsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataQueryUpdateAddedItemsKey")!;
				return _QueryUpdateAddedItemsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QueryUpdateChangedItemsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataQueryUpdateChangedItemsKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString QueryUpdateChangedItemsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_QueryUpdateChangedItemsKey is null)
					_QueryUpdateChangedItemsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataQueryUpdateChangedItemsKey")!;
				return _QueryUpdateChangedItemsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QueryUpdateRemovedItemsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataQueryUpdateRemovedItemsKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString QueryUpdateRemovedItemsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_QueryUpdateRemovedItemsKey is null)
					_QueryUpdateRemovedItemsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataQueryUpdateRemovedItemsKey")!;
				return _QueryUpdateRemovedItemsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RecipientAddressesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemRecipientAddressesKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString RecipientAddressesKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_RecipientAddressesKey is null)
					_RecipientAddressesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemRecipientAddressesKey")!;
				return _RecipientAddressesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RecipientEmailAddressesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemRecipientEmailAddressesKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString RecipientEmailAddressesKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_RecipientEmailAddressesKey is null)
					_RecipientEmailAddressesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemRecipientEmailAddressesKey")!;
				return _RecipientEmailAddressesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RecipientsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemRecipientsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString RecipientsKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_RecipientsKey is null)
					_RecipientsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemRecipientsKey")!;
				return _RecipientsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RecordingDateKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemRecordingDateKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString RecordingDateKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_RecordingDateKey is null)
					_RecordingDateKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemRecordingDateKey")!;
				return _RecordingDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RecordingYearKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemRecordingYearKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString RecordingYearKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_RecordingYearKey is null)
					_RecordingYearKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemRecordingYearKey")!;
				return _RecordingYearKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RedEyeOnOffKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemRedEyeOnOffKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString RedEyeOnOffKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_RedEyeOnOffKey is null)
					_RedEyeOnOffKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemRedEyeOnOffKey")!;
				return _RedEyeOnOffKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ResolutionHeightDpiKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemResolutionHeightDPIKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ResolutionHeightDpiKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ResolutionHeightDpiKey is null)
					_ResolutionHeightDpiKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemResolutionHeightDPIKey")!;
				return _ResolutionHeightDpiKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ResolutionWidthDpiKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemResolutionWidthDPIKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ResolutionWidthDpiKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ResolutionWidthDpiKey is null)
					_ResolutionWidthDpiKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemResolutionWidthDPIKey")!;
				return _ResolutionWidthDpiKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ResultContentRelevanceAttribute;
		/// <summary>Represents the value associated with the constant NSMetadataQueryResultContentRelevanceAttribute</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataQueryResultContentRelevanceAttribute",  "Foundation")]
		public static NSString ResultContentRelevanceAttribute {
			get {
				if (_ResultContentRelevanceAttribute is null)
					_ResultContentRelevanceAttribute = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataQueryResultContentRelevanceAttribute")!;
				return _ResultContentRelevanceAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RightsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemRightsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString RightsKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_RightsKey is null)
					_RightsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemRightsKey")!;
				return _RightsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SecurityMethodKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemSecurityMethodKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SecurityMethodKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SecurityMethodKey is null)
					_SecurityMethodKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemSecurityMethodKey")!;
				return _SecurityMethodKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SpeedKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemSpeedKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SpeedKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SpeedKey is null)
					_SpeedKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemSpeedKey")!;
				return _SpeedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StarRatingKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemStarRatingKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString StarRatingKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_StarRatingKey is null)
					_StarRatingKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemStarRatingKey")!;
				return _StarRatingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StateOrProvinceKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemStateOrProvinceKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString StateOrProvinceKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_StateOrProvinceKey is null)
					_StateOrProvinceKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemStateOrProvinceKey")!;
				return _StateOrProvinceKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StreamableKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemStreamableKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString StreamableKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_StreamableKey is null)
					_StreamableKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemStreamableKey")!;
				return _StreamableKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SubjectKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemSubjectKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SubjectKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SubjectKey is null)
					_SubjectKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemSubjectKey")!;
				return _SubjectKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TempoKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemTempoKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString TempoKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TempoKey is null)
					_TempoKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemTempoKey")!;
				return _TempoKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextContentKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemTextContentKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString TextContentKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TextContentKey is null)
					_TextContentKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemTextContentKey")!;
				return _TextContentKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ThemeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemThemeKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ThemeKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ThemeKey is null)
					_ThemeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemThemeKey")!;
				return _ThemeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TimeSignatureKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemTimeSignatureKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString TimeSignatureKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TimeSignatureKey is null)
					_TimeSignatureKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemTimeSignatureKey")!;
				return _TimeSignatureKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TimestampKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemTimestampKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString TimestampKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TimestampKey is null)
					_TimestampKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemTimestampKey")!;
				return _TimestampKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TitleKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemTitleKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString TitleKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TitleKey is null)
					_TitleKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemTitleKey")!;
				return _TitleKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TotalBitRateKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemTotalBitRateKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString TotalBitRateKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TotalBitRateKey is null)
					_TotalBitRateKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemTotalBitRateKey")!;
				return _TotalBitRateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousDataScope;
		/// <summary>Represents the value associated with the constant NSMetadataQueryUbiquitousDataScope</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataQueryUbiquitousDataScope",  "Foundation")]
		public static NSString UbiquitousDataScope {
			get {
				if (_UbiquitousDataScope is null)
					_UbiquitousDataScope = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataQueryUbiquitousDataScope")!;
				return _UbiquitousDataScope;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousDocumentsScope;
		/// <summary>Represents the value associated with the constant NSMetadataQueryUbiquitousDocumentsScope</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataQueryUbiquitousDocumentsScope",  "Foundation")]
		public static NSString UbiquitousDocumentsScope {
			get {
				if (_UbiquitousDocumentsScope is null)
					_UbiquitousDocumentsScope = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataQueryUbiquitousDocumentsScope")!;
				return _UbiquitousDocumentsScope;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemContainerDisplayNameKey;
		/// <summary>Represents the value associated with the constant NSMetadataUbiquitousItemContainerDisplayNameKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousItemContainerDisplayNameKey",  "Foundation")]
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
					_UbiquitousItemContainerDisplayNameKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousItemContainerDisplayNameKey")!;
				return _UbiquitousItemContainerDisplayNameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemDownloadRequestedKey;
		/// <summary>Represents the value associated with the constant NSMetadataUbiquitousItemDownloadRequestedKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousItemDownloadRequestedKey",  "Foundation")]
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
					_UbiquitousItemDownloadRequestedKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousItemDownloadRequestedKey")!;
				return _UbiquitousItemDownloadRequestedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemDownloadingErrorKey;
		/// <summary>Represents the value associated with the constant NSMetadataUbiquitousItemDownloadingErrorKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousItemDownloadingErrorKey",  "Foundation")]
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
					_UbiquitousItemDownloadingErrorKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousItemDownloadingErrorKey")!;
				return _UbiquitousItemDownloadingErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemDownloadingStatusKey;
		/// <summary>Represents the value associated with the constant NSMetadataUbiquitousItemDownloadingStatusKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousItemDownloadingStatusKey",  "Foundation")]
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
					_UbiquitousItemDownloadingStatusKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousItemDownloadingStatusKey")!;
				return _UbiquitousItemDownloadingStatusKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemHasUnresolvedConflictsKey;
		/// <summary>Represents the value associated with the constant NSMetadataUbiquitousItemHasUnresolvedConflictsKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousItemHasUnresolvedConflictsKey",  "Foundation")]
		public static NSString UbiquitousItemHasUnresolvedConflictsKey {
			get {
				if (_UbiquitousItemHasUnresolvedConflictsKey is null)
					_UbiquitousItemHasUnresolvedConflictsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousItemHasUnresolvedConflictsKey")!;
				return _UbiquitousItemHasUnresolvedConflictsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemIsDownloadedKey;
		/// <summary>Developers should not use this deprecated property. Developers should use 'UbiquitousItemDownloadingStatusKey' instead.</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousItemIsDownloadedKey",  "Foundation")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'UbiquitousItemDownloadingStatusKey' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'UbiquitousItemDownloadingStatusKey' instead.")]
		[ObsoletedOSPlatform ("macos10.9", "Use 'UbiquitousItemDownloadingStatusKey' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UbiquitousItemDownloadingStatusKey' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString UbiquitousItemIsDownloadedKey {
			[ObsoletedOSPlatform ("ios7.0", "Use 'UbiquitousItemDownloadingStatusKey' instead.")]
			[ObsoletedOSPlatform ("tvos9.0", "Use 'UbiquitousItemDownloadingStatusKey' instead.")]
			[ObsoletedOSPlatform ("macos10.9", "Use 'UbiquitousItemDownloadingStatusKey' instead.")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UbiquitousItemDownloadingStatusKey' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_UbiquitousItemIsDownloadedKey is null)
					_UbiquitousItemIsDownloadedKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousItemIsDownloadedKey")!;
				return _UbiquitousItemIsDownloadedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemIsDownloadingKey;
		/// <summary>Represents the value associated with the constant NSMetadataUbiquitousItemIsDownloadingKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousItemIsDownloadingKey",  "Foundation")]
		public static NSString UbiquitousItemIsDownloadingKey {
			get {
				if (_UbiquitousItemIsDownloadingKey is null)
					_UbiquitousItemIsDownloadingKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousItemIsDownloadingKey")!;
				return _UbiquitousItemIsDownloadingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemIsExternalDocumentKey;
		/// <summary>Represents the value associated with the constant NSMetadataUbiquitousItemIsExternalDocumentKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousItemIsExternalDocumentKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString UbiquitousItemIsExternalDocumentKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_UbiquitousItemIsExternalDocumentKey is null)
					_UbiquitousItemIsExternalDocumentKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousItemIsExternalDocumentKey")!;
				return _UbiquitousItemIsExternalDocumentKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemIsSharedKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousItemIsSharedKey",  "Foundation")]
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
					_UbiquitousItemIsSharedKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousItemIsSharedKey")!;
				return _UbiquitousItemIsSharedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemIsUploadedKey;
		/// <summary>Represents the value associated with the constant NSMetadataUbiquitousItemIsUploadedKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousItemIsUploadedKey",  "Foundation")]
		public static NSString UbiquitousItemIsUploadedKey {
			get {
				if (_UbiquitousItemIsUploadedKey is null)
					_UbiquitousItemIsUploadedKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousItemIsUploadedKey")!;
				return _UbiquitousItemIsUploadedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemIsUploadingKey;
		/// <summary>Represents the value associated with the constant NSMetadataUbiquitousItemIsUploadingKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousItemIsUploadingKey",  "Foundation")]
		public static NSString UbiquitousItemIsUploadingKey {
			get {
				if (_UbiquitousItemIsUploadingKey is null)
					_UbiquitousItemIsUploadingKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousItemIsUploadingKey")!;
				return _UbiquitousItemIsUploadingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemPercentDownloadedKey;
		/// <summary>Represents the value associated with the constant NSMetadataUbiquitousItemPercentDownloadedKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousItemPercentDownloadedKey",  "Foundation")]
		public static NSString UbiquitousItemPercentDownloadedKey {
			get {
				if (_UbiquitousItemPercentDownloadedKey is null)
					_UbiquitousItemPercentDownloadedKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousItemPercentDownloadedKey")!;
				return _UbiquitousItemPercentDownloadedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemPercentUploadedKey;
		/// <summary>Represents the value associated with the constant NSMetadataUbiquitousItemPercentUploadedKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousItemPercentUploadedKey",  "Foundation")]
		public static NSString UbiquitousItemPercentUploadedKey {
			get {
				if (_UbiquitousItemPercentUploadedKey is null)
					_UbiquitousItemPercentUploadedKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousItemPercentUploadedKey")!;
				return _UbiquitousItemPercentUploadedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemURLInLocalContainerKey;
		/// <summary>Represents the value associated with the constant NSMetadataUbiquitousItemURLInLocalContainerKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousItemURLInLocalContainerKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString UbiquitousItemURLInLocalContainerKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_UbiquitousItemURLInLocalContainerKey is null)
					_UbiquitousItemURLInLocalContainerKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousItemURLInLocalContainerKey")!;
				return _UbiquitousItemURLInLocalContainerKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousItemUploadingErrorKey;
		/// <summary>Represents the value associated with the constant NSMetadataUbiquitousItemUploadingErrorKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousItemUploadingErrorKey",  "Foundation")]
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
					_UbiquitousItemUploadingErrorKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousItemUploadingErrorKey")!;
				return _UbiquitousItemUploadingErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousSharedItemCurrentUserPermissionsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousSharedItemCurrentUserPermissionsKey",  "Foundation")]
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
					_UbiquitousSharedItemCurrentUserPermissionsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousSharedItemCurrentUserPermissionsKey")!;
				return _UbiquitousSharedItemCurrentUserPermissionsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousSharedItemCurrentUserRoleKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousSharedItemCurrentUserRoleKey",  "Foundation")]
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
					_UbiquitousSharedItemCurrentUserRoleKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousSharedItemCurrentUserRoleKey")!;
				return _UbiquitousSharedItemCurrentUserRoleKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousSharedItemMostRecentEditorNameComponentsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousSharedItemMostRecentEditorNameComponentsKey",  "Foundation")]
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
					_UbiquitousSharedItemMostRecentEditorNameComponentsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousSharedItemMostRecentEditorNameComponentsKey")!;
				return _UbiquitousSharedItemMostRecentEditorNameComponentsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousSharedItemOwnerNameComponentsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousSharedItemOwnerNameComponentsKey",  "Foundation")]
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
					_UbiquitousSharedItemOwnerNameComponentsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousSharedItemOwnerNameComponentsKey")!;
				return _UbiquitousSharedItemOwnerNameComponentsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousSharedItemPermissionsReadOnly;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousSharedItemPermissionsReadOnly",  "Foundation")]
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
					_UbiquitousSharedItemPermissionsReadOnly = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousSharedItemPermissionsReadOnly")!;
				return _UbiquitousSharedItemPermissionsReadOnly;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousSharedItemPermissionsReadWrite;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousSharedItemPermissionsReadWrite",  "Foundation")]
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
					_UbiquitousSharedItemPermissionsReadWrite = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousSharedItemPermissionsReadWrite")!;
				return _UbiquitousSharedItemPermissionsReadWrite;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousSharedItemRoleOwner;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousSharedItemRoleOwner",  "Foundation")]
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
					_UbiquitousSharedItemRoleOwner = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousSharedItemRoleOwner")!;
				return _UbiquitousSharedItemRoleOwner;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UbiquitousSharedItemRoleParticipant;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataUbiquitousSharedItemRoleParticipant",  "Foundation")]
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
					_UbiquitousSharedItemRoleParticipant = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataUbiquitousSharedItemRoleParticipant")!;
				return _UbiquitousSharedItemRoleParticipant;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UserHomeScope;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataQueryUserHomeScope",  "Foundation")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static NSString UserHomeScope {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UserHomeScope is null)
					_UserHomeScope = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataQueryUserHomeScope")!;
				return _UserHomeScope;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VersionKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemVersionKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString VersionKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_VersionKey is null)
					_VersionKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemVersionKey")!;
				return _VersionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VideoBitRateKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemVideoBitRateKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString VideoBitRateKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_VideoBitRateKey is null)
					_VideoBitRateKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemVideoBitRateKey")!;
				return _VideoBitRateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WhereFromsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemWhereFromsKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString WhereFromsKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_WhereFromsKey is null)
					_WhereFromsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemWhereFromsKey")!;
				return _WhereFromsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WhiteBalanceKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMetadataItemWhiteBalanceKey",  "Foundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString WhiteBalanceKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_WhiteBalanceKey is null)
					_WhiteBalanceKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMetadataItemWhiteBalanceKey")!;
				return _WhiteBalanceKey;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_NSMetadataQueryDelegate); }
		}
		internal virtual _NSMetadataQueryDelegate CreateInternalEventDelegateType ()
		{
			return (_NSMetadataQueryDelegate)(new _NSMetadataQueryDelegate());
		}
		internal _NSMetadataQueryDelegate EnsureNSMetadataQueryDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _NSMetadataQueryDelegate;
			if (del is null){
				del = (_NSMetadataQueryDelegate)CreateInternalEventDelegateType ();
				Delegate = (INSMetadataQueryDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _NSMetadataQueryDelegate : NSObject, INSMetadataQueryDelegate { 
			public _NSMetadataQueryDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_NSMetadataQueryDelegate))]
			static _NSMetadataQueryDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal NSMetadataQueryObject? replacementObjectForResultObject;
			[Export ("metadataQuery:replacementObjectForResultObject:")]
			public NSObject ReplacementObjectForResultObject (NSMetadataQuery query, NSMetadataItem result)
			{
				var handler = replacementObjectForResultObject;
				if (handler is not null)
					return handler (query, result);
				return null!;
			}
			internal NSMetadataQueryValue? replacementValueForAttributevalue;
			[Export ("metadataQuery:replacementValueForAttribute:value:")]
			public NSObject ReplacementValueForAttributevalue (NSMetadataQuery query, string attributeName, NSObject value)
			{
				var handler = replacementValueForAttributevalue;
				if (handler is not null)
					return handler (query, attributeName, value);
				return null!;
			}
		}
		#pragma warning restore 672
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the Delegate property to an internal handler that maps delegates to events.</remarks>
		public NSMetadataQueryObject? ReplacementObjectForResultObject {
			get { return EnsureNSMetadataQueryDelegate ()!.replacementObjectForResultObject; }
			set { EnsureNSMetadataQueryDelegate ()!.replacementObjectForResultObject = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the Delegate property to an internal handler that maps delegates to events.</remarks>
		public NSMetadataQueryValue? ReplacementValueForAttributevalue {
			get { return EnsureNSMetadataQueryDelegate ()!.replacementValueForAttributevalue; }
			set { EnsureNSMetadataQueryDelegate ()!.replacementValueForAttributevalue = value; }
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
		/// <summary>Notifications posted by the <see cref="global::Foundation.NSMetadataQuery" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSMetadataQuery.DidFinishGatheringNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSMetadataQuery.DidFinishGatheringNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSMetadataQuery.Notifications.ObserveDidFinishGathering ((notification) => {
			///   Console.WriteLine ("Observed DidFinishGatheringNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidFinishGathering (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidFinishGatheringNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSMetadataQuery.DidFinishGatheringNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSMetadataQuery.DidFinishGatheringNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSMetadataQuery.Notifications.ObserveDidFinishGathering (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidFinishGatheringNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidFinishGathering (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidFinishGatheringNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSMetadataQuery.DidStartGatheringNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSMetadataQuery.DidStartGatheringNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSMetadataQuery.Notifications.ObserveDidStartGathering ((notification) => {
			///   Console.WriteLine ("Observed DidStartGatheringNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidStartGathering (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidStartGatheringNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSMetadataQuery.DidStartGatheringNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSMetadataQuery.DidStartGatheringNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSMetadataQuery.Notifications.ObserveDidStartGathering (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidStartGatheringNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidStartGathering (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidStartGatheringNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSMetadataQuery.DidUpdateNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSMetadataQuery.DidUpdateNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSMetadataQuery.Notifications.ObserveDidUpdate ((notification) => {
			///   Console.WriteLine ("Observed DidUpdateNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidUpdate (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidUpdateNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSMetadataQuery.DidUpdateNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSMetadataQuery.DidUpdateNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSMetadataQuery.Notifications.ObserveDidUpdate (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidUpdateNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidUpdate (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidUpdateNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSMetadataQuery.GatheringProgressNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSMetadataQuery.GatheringProgressNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSMetadataQuery.Notifications.ObserveGatheringProgress ((notification) => {
			///   Console.WriteLine ("Observed GatheringProgressNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveGatheringProgress (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (GatheringProgressNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSMetadataQuery.GatheringProgressNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSMetadataQuery.GatheringProgressNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSMetadataQuery.Notifications.ObserveGatheringProgress (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed GatheringProgressNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveGatheringProgress (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (GatheringProgressNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSMetadataQuery */
}
