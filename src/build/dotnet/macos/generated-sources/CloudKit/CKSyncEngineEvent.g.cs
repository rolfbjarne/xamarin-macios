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
	[Register("CKSyncEngineEvent", true)]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public unsafe partial class CKSyncEngineEvent : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccountChangeEventX = "accountChangeEvent";
		static readonly NativeHandle selAccountChangeEventXHandle = Selector.GetHandle ("accountChangeEvent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidFetchChangesEventX = "didFetchChangesEvent";
		static readonly NativeHandle selDidFetchChangesEventXHandle = Selector.GetHandle ("didFetchChangesEvent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidFetchRecordZoneChangesEventX = "didFetchRecordZoneChangesEvent";
		static readonly NativeHandle selDidFetchRecordZoneChangesEventXHandle = Selector.GetHandle ("didFetchRecordZoneChangesEvent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidSendChangesEventX = "didSendChangesEvent";
		static readonly NativeHandle selDidSendChangesEventXHandle = Selector.GetHandle ("didSendChangesEvent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchedDatabaseChangesEventX = "fetchedDatabaseChangesEvent";
		static readonly NativeHandle selFetchedDatabaseChangesEventXHandle = Selector.GetHandle ("fetchedDatabaseChangesEvent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchedRecordZoneChangesEventX = "fetchedRecordZoneChangesEvent";
		static readonly NativeHandle selFetchedRecordZoneChangesEventXHandle = Selector.GetHandle ("fetchedRecordZoneChangesEvent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSentDatabaseChangesEventX = "sentDatabaseChangesEvent";
		static readonly NativeHandle selSentDatabaseChangesEventXHandle = Selector.GetHandle ("sentDatabaseChangesEvent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSentRecordZoneChangesEventX = "sentRecordZoneChangesEvent";
		static readonly NativeHandle selSentRecordZoneChangesEventXHandle = Selector.GetHandle ("sentRecordZoneChangesEvent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStateUpdateEventX = "stateUpdateEvent";
		static readonly NativeHandle selStateUpdateEventXHandle = Selector.GetHandle ("stateUpdateEvent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTypeX = "type";
		static readonly NativeHandle selTypeXHandle = Selector.GetHandle ("type");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWillFetchChangesEventX = "willFetchChangesEvent";
		static readonly NativeHandle selWillFetchChangesEventXHandle = Selector.GetHandle ("willFetchChangesEvent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWillFetchRecordZoneChangesEventX = "willFetchRecordZoneChangesEvent";
		static readonly NativeHandle selWillFetchRecordZoneChangesEventXHandle = Selector.GetHandle ("willFetchRecordZoneChangesEvent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWillSendChangesEventX = "willSendChangesEvent";
		static readonly NativeHandle selWillSendChangesEventXHandle = Selector.GetHandle ("willSendChangesEvent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CKSyncEngineEvent");
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
		protected CKSyncEngineEvent (NSObjectFlag t) : base (t)
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
		protected internal CKSyncEngineEvent (NativeHandle handle) : base (handle)
		{
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKSyncEngineAccountChangeEvent AccountChangeEvent {
			[Export ("accountChangeEvent", ArgumentSemantic.Retain)]
			get {
				CKSyncEngineAccountChangeEvent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKSyncEngineAccountChangeEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccountChangeEventXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKSyncEngineAccountChangeEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccountChangeEventXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKSyncEngineDidFetchChangesEvent DidFetchChangesEvent {
			[Export ("didFetchChangesEvent", ArgumentSemantic.Retain)]
			get {
				CKSyncEngineDidFetchChangesEvent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKSyncEngineDidFetchChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDidFetchChangesEventXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKSyncEngineDidFetchChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDidFetchChangesEventXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKSyncEngineDidFetchRecordZoneChangesEvent DidFetchRecordZoneChangesEvent {
			[Export ("didFetchRecordZoneChangesEvent", ArgumentSemantic.Retain)]
			get {
				CKSyncEngineDidFetchRecordZoneChangesEvent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKSyncEngineDidFetchRecordZoneChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDidFetchRecordZoneChangesEventXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKSyncEngineDidFetchRecordZoneChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDidFetchRecordZoneChangesEventXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKSyncEngineDidSendChangesEvent DidSendChangesEvent {
			[Export ("didSendChangesEvent", ArgumentSemantic.Retain)]
			get {
				CKSyncEngineDidSendChangesEvent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKSyncEngineDidSendChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDidSendChangesEventXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKSyncEngineDidSendChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDidSendChangesEventXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKSyncEngineFetchedDatabaseChangesEvent FetchedDatabaseChangesEvent {
			[Export ("fetchedDatabaseChangesEvent", ArgumentSemantic.Retain)]
			get {
				CKSyncEngineFetchedDatabaseChangesEvent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKSyncEngineFetchedDatabaseChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFetchedDatabaseChangesEventXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKSyncEngineFetchedDatabaseChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFetchedDatabaseChangesEventXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKSyncEngineFetchedRecordZoneChangesEvent FetchedRecordZoneChangesEvent {
			[Export ("fetchedRecordZoneChangesEvent", ArgumentSemantic.Retain)]
			get {
				CKSyncEngineFetchedRecordZoneChangesEvent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKSyncEngineFetchedRecordZoneChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFetchedRecordZoneChangesEventXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKSyncEngineFetchedRecordZoneChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFetchedRecordZoneChangesEventXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKSyncEngineSentDatabaseChangesEvent SentDatabaseChangesEvent {
			[Export ("sentDatabaseChangesEvent", ArgumentSemantic.Retain)]
			get {
				CKSyncEngineSentDatabaseChangesEvent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKSyncEngineSentDatabaseChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSentDatabaseChangesEventXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKSyncEngineSentDatabaseChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSentDatabaseChangesEventXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKSyncEngineSentRecordZoneChangesEvent SentRecordZoneChangesEvent {
			[Export ("sentRecordZoneChangesEvent", ArgumentSemantic.Retain)]
			get {
				CKSyncEngineSentRecordZoneChangesEvent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKSyncEngineSentRecordZoneChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSentRecordZoneChangesEventXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKSyncEngineSentRecordZoneChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSentRecordZoneChangesEventXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKSyncEngineStateUpdateEvent StateUpdateEvent {
			[Export ("stateUpdateEvent", ArgumentSemantic.Retain)]
			get {
				CKSyncEngineStateUpdateEvent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKSyncEngineStateUpdateEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStateUpdateEventXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKSyncEngineStateUpdateEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStateUpdateEventXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKSyncEngineEventType Type {
			[Export ("type", ArgumentSemantic.Assign)]
			get {
				CKSyncEngineEventType ret;
				if (IsDirectBinding) {
					ret = (CKSyncEngineEventType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CKSyncEngineEventType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKSyncEngineWillFetchChangesEvent WillFetchChangesEvent {
			[Export ("willFetchChangesEvent", ArgumentSemantic.Retain)]
			get {
				CKSyncEngineWillFetchChangesEvent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKSyncEngineWillFetchChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWillFetchChangesEventXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKSyncEngineWillFetchChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWillFetchChangesEventXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKSyncEngineWillFetchRecordZoneChangesEvent WillFetchRecordZoneChangesEvent {
			[Export ("willFetchRecordZoneChangesEvent", ArgumentSemantic.Retain)]
			get {
				CKSyncEngineWillFetchRecordZoneChangesEvent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKSyncEngineWillFetchRecordZoneChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWillFetchRecordZoneChangesEventXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKSyncEngineWillFetchRecordZoneChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWillFetchRecordZoneChangesEventXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKSyncEngineWillSendChangesEvent WillSendChangesEvent {
			[Export ("willSendChangesEvent", ArgumentSemantic.Retain)]
			get {
				CKSyncEngineWillSendChangesEvent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKSyncEngineWillSendChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWillSendChangesEventXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKSyncEngineWillSendChangesEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWillSendChangesEventXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class CKSyncEngineEvent */
}
