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
namespace CloudKit {
	[Register("CKQueryOperation", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class CKQueryOperation : CKDatabaseOperation {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCursorX = "cursor";
		static readonly NativeHandle selCursorXHandle = Selector.GetHandle ("cursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDesiredKeysX = "desiredKeys";
		static readonly NativeHandle selDesiredKeysXHandle = Selector.GetHandle ("desiredKeys");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCursor_X = "initWithCursor:";
		static readonly NativeHandle selInitWithCursor_XHandle = Selector.GetHandle ("initWithCursor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithQuery_X = "initWithQuery:";
		static readonly NativeHandle selInitWithQuery_XHandle = Selector.GetHandle ("initWithQuery:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQueryX = "query";
		static readonly NativeHandle selQueryXHandle = Selector.GetHandle ("query");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQueryCompletionBlockX = "queryCompletionBlock";
		static readonly NativeHandle selQueryCompletionBlockXHandle = Selector.GetHandle ("queryCompletionBlock");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecordFetchedBlockX = "recordFetchedBlock";
		static readonly NativeHandle selRecordFetchedBlockXHandle = Selector.GetHandle ("recordFetchedBlock");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecordMatchedBlockX = "recordMatchedBlock";
		static readonly NativeHandle selRecordMatchedBlockXHandle = Selector.GetHandle ("recordMatchedBlock");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultsLimitX = "resultsLimit";
		static readonly NativeHandle selResultsLimitXHandle = Selector.GetHandle ("resultsLimit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCursor_X = "setCursor:";
		static readonly NativeHandle selSetCursor_XHandle = Selector.GetHandle ("setCursor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDesiredKeys_X = "setDesiredKeys:";
		static readonly NativeHandle selSetDesiredKeys_XHandle = Selector.GetHandle ("setDesiredKeys:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetQuery_X = "setQuery:";
		static readonly NativeHandle selSetQuery_XHandle = Selector.GetHandle ("setQuery:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetQueryCompletionBlock_X = "setQueryCompletionBlock:";
		static readonly NativeHandle selSetQueryCompletionBlock_XHandle = Selector.GetHandle ("setQueryCompletionBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRecordFetchedBlock_X = "setRecordFetchedBlock:";
		static readonly NativeHandle selSetRecordFetchedBlock_XHandle = Selector.GetHandle ("setRecordFetchedBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRecordMatchedBlock_X = "setRecordMatchedBlock:";
		static readonly NativeHandle selSetRecordMatchedBlock_XHandle = Selector.GetHandle ("setRecordMatchedBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetResultsLimit_X = "setResultsLimit:";
		static readonly NativeHandle selSetResultsLimit_XHandle = Selector.GetHandle ("setResultsLimit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetZoneID_X = "setZoneID:";
		static readonly NativeHandle selSetZoneID_XHandle = Selector.GetHandle ("setZoneID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selZoneIDX = "zoneID";
		static readonly NativeHandle selZoneIDXHandle = Selector.GetHandle ("zoneID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CKQueryOperation");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CKQueryOperation" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CKQueryOperation () : base (NSObjectFlag.Empty)
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
		protected CKQueryOperation (NSObjectFlag t) : base (t)
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
		protected internal CKQueryOperation (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithQuery:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CKQueryOperation (CKQuery query)
			: base (NSObjectFlag.Empty)
		{
			var query__handle__ = query!.GetNonNullHandle (nameof (query));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithQuery_XHandle, query__handle__), "initWithQuery:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithQuery_XHandle, query__handle__), "initWithQuery:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (query);
		}
		[Export ("initWithCursor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CKQueryOperation (CKQueryCursor cursor)
			: base (NSObjectFlag.Empty)
		{
			var cursor__handle__ = cursor!.GetNonNullHandle (nameof (cursor));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithCursor_XHandle, cursor__handle__), "initWithCursor:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithCursor_XHandle, cursor__handle__), "initWithCursor:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cursor);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::System.Action<CKQueryCursor, NSError>? Completed {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity2V59))]
			[Export ("queryCompletionBlock", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selQueryCompletionBlockXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selQueryCompletionBlockXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDActionArity2V59.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V59))]
			[Export ("setQueryCompletionBlock:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDActionArity2V59.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetQueryCompletionBlock_XHandle, (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetQueryCompletionBlock_XHandle, (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKQueryCursor? Cursor {
			[Export ("cursor", ArgumentSemantic.Copy)]
			get {
				CKQueryCursor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKQueryCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCursorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKQueryCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCursorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCursor:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCursor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCursor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? DesiredKeys {
			[Export ("desiredKeys", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDesiredKeysXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDesiredKeysXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDesiredKeys:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = NSArray.FromNullableStrings (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDesiredKeys_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDesiredKeys_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKQuery? Query {
			[Export ("query", ArgumentSemantic.Copy)]
			get {
				CKQuery? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKQuery> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selQueryXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKQuery> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selQueryXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setQuery:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetQuery_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetQuery_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'RecordMatchedHandler' instead.")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'RecordMatchedHandler' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'RecordMatchedHandler' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'RecordMatchedHandler' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public unsafe virtual global::System.Action<CKRecord>? RecordFetched {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity1V34))]
			[Export ("recordFetchedBlock", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRecordFetchedBlockXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRecordFetchedBlockXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDActionArity1V34.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V34))]
			[Export ("setRecordFetchedBlock:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDActionArity1V34.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetRecordFetchedBlock_XHandle, (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetRecordFetchedBlock_XHandle, (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public unsafe virtual CKQueryOperationRecordMatchedHandler? RecordMatchedHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDCKQueryOperationRecordMatchedHandler))]
			[Export ("recordMatchedBlock", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRecordMatchedBlockXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRecordMatchedBlockXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDCKQueryOperationRecordMatchedHandler.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCKQueryOperationRecordMatchedHandler))]
			[Export ("setRecordMatchedBlock:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDCKQueryOperationRecordMatchedHandler.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetRecordMatchedBlock_XHandle, (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetRecordMatchedBlock_XHandle, (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint ResultsLimit {
			[Export ("resultsLimit")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selResultsLimitXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selResultsLimitXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setResultsLimit:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetResultsLimit_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetResultsLimit_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKRecordZoneID? ZoneId {
			[Export ("zoneID", ArgumentSemantic.Copy)]
			get {
				CKRecordZoneID? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKRecordZoneID> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selZoneIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKRecordZoneID> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selZoneIDXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setZoneID:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetZoneID_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetZoneID_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Represents the value associated with the constant 'CKQueryOperationMaximumResults'.</summary>
		[Field ("CKQueryOperationMaximumResults",  "CloudKit")]
		public static nint MaximumResults {
			get {
				return Dlfcn.GetIntPtr (Libraries.CloudKit.Handle, "CKQueryOperationMaximumResults");
			}
		}
	} /* class CKQueryOperation */
}
