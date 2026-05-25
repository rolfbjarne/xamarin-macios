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
namespace CoreData {
	[Register("NSCoreDataCoreSpotlightDelegate", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSCoreDataCoreSpotlightDelegate : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributeSetForObject_X = "attributeSetForObject:";
		static readonly NativeHandle selAttributeSetForObject_XHandle = Selector.GetHandle ("attributeSetForObject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteSpotlightIndexWithCompletionHandler_X = "deleteSpotlightIndexWithCompletionHandler:";
		static readonly NativeHandle selDeleteSpotlightIndexWithCompletionHandler_XHandle = Selector.GetHandle ("deleteSpotlightIndexWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDomainIdentifierX = "domainIdentifier";
		static readonly NativeHandle selDomainIdentifierXHandle = Selector.GetHandle ("domainIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexNameX = "indexName";
		static readonly NativeHandle selIndexNameXHandle = Selector.GetHandle ("indexName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitForStoreWithDescription_Coordinator_X = "initForStoreWithDescription:coordinator:";
		static readonly NativeHandle selInitForStoreWithDescription_Coordinator_XHandle = Selector.GetHandle ("initForStoreWithDescription:coordinator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitForStoreWithDescription_Model_X = "initForStoreWithDescription:model:";
		static readonly NativeHandle selInitForStoreWithDescription_Model_XHandle = Selector.GetHandle ("initForStoreWithDescription:model:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsIndexingEnabledX = "isIndexingEnabled";
		static readonly NativeHandle selIsIndexingEnabledXHandle = Selector.GetHandle ("isIndexingEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSearchableIndex_ReindexAllSearchableItemsWithAcknowledgementHandler_X = "searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:";
		static readonly NativeHandle selSearchableIndex_ReindexAllSearchableItemsWithAcknowledgementHandler_XHandle = Selector.GetHandle ("searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSearchableIndex_ReindexSearchableItemsWithIdentifiers_AcknowledgementHandler_X = "searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:";
		static readonly NativeHandle selSearchableIndex_ReindexSearchableItemsWithIdentifiers_AcknowledgementHandler_XHandle = Selector.GetHandle ("searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartSpotlightIndexingX = "startSpotlightIndexing";
		static readonly NativeHandle selStartSpotlightIndexingXHandle = Selector.GetHandle ("startSpotlightIndexing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopSpotlightIndexingX = "stopSpotlightIndexing";
		static readonly NativeHandle selStopSpotlightIndexingXHandle = Selector.GetHandle ("stopSpotlightIndexing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSCoreDataCoreSpotlightDelegate");
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
		protected NSCoreDataCoreSpotlightDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSCoreDataCoreSpotlightDelegate (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initForStoreWithDescription:coordinator:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSCoreDataCoreSpotlightDelegate (NSPersistentStoreDescription description, NSPersistentStoreCoordinator psc)
			: base (NSObjectFlag.Empty)
		{
			var description__handle__ = description!.GetNonNullHandle (nameof (description));
			var psc__handle__ = psc!.GetNonNullHandle (nameof (psc));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitForStoreWithDescription_Coordinator_XHandle, description__handle__, psc__handle__), "initForStoreWithDescription:coordinator:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitForStoreWithDescription_Coordinator_XHandle, description__handle__, psc__handle__), "initForStoreWithDescription:coordinator:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (description);
			GC.KeepAlive (psc);
		}
		/// <param name="description">To be added.</param><param name="model">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initForStoreWithDescription:model:")]
		[ObsoletedOSPlatform ("ios15.0", "Use the constructor that takes a NSPersistentStoreCoordinator instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the constructor that takes a NSPersistentStoreCoordinator instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the constructor that takes a NSPersistentStoreCoordinator instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSCoreDataCoreSpotlightDelegate (NSPersistentStoreDescription description, NSManagedObjectModel model)
			: base (NSObjectFlag.Empty)
		{
			var description__handle__ = description!.GetNonNullHandle (nameof (description));
			var model__handle__ = model!.GetNonNullHandle (nameof (model));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitForStoreWithDescription_Model_XHandle, description__handle__, model__handle__), "initForStoreWithDescription:model:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitForStoreWithDescription_Model_XHandle, description__handle__, model__handle__), "initForStoreWithDescription:model:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (description);
			GC.KeepAlive (model);
		}
		[Export ("deleteSpotlightIndexWithCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DeleteSpotlightIndex ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDeleteSpotlightIndexWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDeleteSpotlightIndexWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task DeleteSpotlightIndexAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			DeleteSpotlightIndex((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <param name="object">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("attributeSetForObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreSpotlight.CSSearchableItemAttributeSet? GetAttributeSet (NSManagedObject @object)
		{
			var @object__handle__ = @object!.GetNonNullHandle (nameof (@object));
			global::CoreSpotlight.CSSearchableItemAttributeSet? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::CoreSpotlight.CSSearchableItemAttributeSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAttributeSetForObject_XHandle, @object__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::CoreSpotlight.CSSearchableItemAttributeSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAttributeSetForObject_XHandle, @object__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (@object);
			return ret!;
		}
		/// <param name="searchableIndex">To be added.</param><param name="acknowledgementHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReindexAllSearchableItems (global::CoreSpotlight.CSSearchableIndex searchableIndex, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action acknowledgementHandler)
		{
			var searchableIndex__handle__ = searchableIndex!.GetNonNullHandle (nameof (searchableIndex));
			if (acknowledgementHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (acknowledgementHandler));
			using var block_acknowledgementHandler = Trampolines.SDAction.CreateBlock (acknowledgementHandler);
			BlockLiteral *block_ptr_acknowledgementHandler = &block_acknowledgementHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSearchableIndex_ReindexAllSearchableItemsWithAcknowledgementHandler_XHandle, searchableIndex__handle__, (IntPtr) block_ptr_acknowledgementHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSearchableIndex_ReindexAllSearchableItemsWithAcknowledgementHandler_XHandle, searchableIndex__handle__, (IntPtr) block_ptr_acknowledgementHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (searchableIndex);
		}
		/// <param name="searchableIndex">To be added.</param><param name="identifiers">To be added.</param><param name="acknowledgementHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReindexSearchableItems (global::CoreSpotlight.CSSearchableIndex searchableIndex, string[] identifiers, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action acknowledgementHandler)
		{
			var searchableIndex__handle__ = searchableIndex!.GetNonNullHandle (nameof (searchableIndex));
			if (identifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifiers));
			if (acknowledgementHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (acknowledgementHandler));
			using var nsa_identifiers = NSArray.FromStrings (identifiers);
			using var block_acknowledgementHandler = Trampolines.SDAction.CreateBlock (acknowledgementHandler);
			BlockLiteral *block_ptr_acknowledgementHandler = &block_acknowledgementHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selSearchableIndex_ReindexSearchableItemsWithIdentifiers_AcknowledgementHandler_XHandle, searchableIndex__handle__, nsa_identifiers.Handle, (IntPtr) block_ptr_acknowledgementHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selSearchableIndex_ReindexSearchableItemsWithIdentifiers_AcknowledgementHandler_XHandle, searchableIndex__handle__, nsa_identifiers.Handle, (IntPtr) block_ptr_acknowledgementHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (searchableIndex);
		}
		[Export ("startSpotlightIndexing")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartSpotlightIndexing ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStartSpotlightIndexingXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStartSpotlightIndexingXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("stopSpotlightIndexing")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopSpotlightIndexing ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopSpotlightIndexingXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopSpotlightIndexingXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DomainIdentifier {
			[Export ("domainIdentifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDomainIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDomainIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? IndexName {
			[Export ("indexName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIndexNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIndexNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool IndexingEnabled {
			[Export ("isIndexingEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsIndexingEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsIndexingEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IndexDidUpdateNotification;
		/// <summary>Notification constant for IndexDidUpdate</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveIndexDidUpdate(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveIndexDidUpdate(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCoreDataCoreSpotlightDelegate.Notifications.ObserveIndexDidUpdate ((sender, args) => {
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
		/// void Callback (object sender, NSCoreDataCoreSpotlightDelegate.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCoreDataCoreSpotlightDelegate.Notifications.ObserveIndexDidUpdate (Callback);
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
		///     NSCoreDataCoreSpotlightDelegate.IndexDidUpdateNotification, (notification) => { Console.WriteLine ("Received the notification IndexDidUpdate", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification IndexDidUpdate", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCoreDataCoreSpotlightDelegate.IndexDidUpdateNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSCoreDataCoreSpotlightDelegateIndexDidUpdateNotification",  "CoreData")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[Advice ("Use NSCoreDataCoreSpotlightDelegate.Notifications.ObserveIndexDidUpdate helper method instead.")]
		public static NSString IndexDidUpdateNotification {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_IndexDidUpdateNotification is null)
					_IndexDidUpdateNotification = Dlfcn.GetStringConstant (Libraries.CoreData.Handle, "NSCoreDataCoreSpotlightDelegateIndexDidUpdateNotification")!;
				return _IndexDidUpdateNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::CoreData.NSCoreDataCoreSpotlightDelegate" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::CoreData.NSCoreDataCoreSpotlightDelegate.IndexDidUpdateNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::CoreData.NSCoreDataCoreSpotlightDelegate.IndexDidUpdateNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCoreDataCoreSpotlightDelegate.Notifications.ObserveIndexDidUpdate ((notification) => {
			///   Console.WriteLine ("Observed IndexDidUpdateNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveIndexDidUpdate (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (IndexDidUpdateNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::CoreData.NSCoreDataCoreSpotlightDelegate.IndexDidUpdateNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::CoreData.NSCoreDataCoreSpotlightDelegate.IndexDidUpdateNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCoreDataCoreSpotlightDelegate.Notifications.ObserveIndexDidUpdate (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed IndexDidUpdateNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveIndexDidUpdate (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (IndexDidUpdateNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSCoreDataCoreSpotlightDelegate */
}
