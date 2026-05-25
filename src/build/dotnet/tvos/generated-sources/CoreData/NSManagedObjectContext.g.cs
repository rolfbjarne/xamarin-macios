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
using UIKit;
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreData {
	/// <summary>A collection of related managed objects that create aninternally-consistent view of one or more persistent stores.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/CoreDataFramework/Classes/NSManagedObjectContext_Class/index.html">Apple documentation for <c>NSManagedObjectContext</c></related>
	[Register("NSManagedObjectContext", true)]
	public unsafe partial class NSManagedObjectContext : NSObject, INSCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSManagedObjectContext");
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
		public NSManagedObjectContext (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
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
		protected NSManagedObjectContext (NSObjectFlag t) : base (t)
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
		protected internal NSManagedObjectContext (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>Default constructor that initializes a new instance of this class with no parameters.</summary><remarks></remarks>
		[Export ("init")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'NSManagedObjectContext (NSManagedObjectContextConcurrencyType)' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'NSManagedObjectContext (NSManagedObjectContextConcurrencyType)' instead.")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'NSManagedObjectContext (NSManagedObjectContextConcurrencyType)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSManagedObjectContext (NSManagedObjectContextConcurrencyType)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSManagedObjectContext ()
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("init")), "init");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="ct">To be added.</param><summary>Creates a new <see cref="T:CoreData.NSManagedObjectContext" /> of the specified type.</summary><remarks>To be added.</remarks>
		[Export ("initWithConcurrencyType:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSManagedObjectContext (NSManagedObjectContextConcurrencyType ct)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("initWithConcurrencyType:"), (UIntPtr) (ulong) ct), "initWithConcurrencyType:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("initWithConcurrencyType:"), (UIntPtr) (ulong) ct), "initWithConcurrencyType:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="object1">To be added.</param><param name="store">To be added.</param><summary>Assigns <paramref name="object1" /> to <paramref name="store" />.</summary><remarks>To be added.</remarks>
		[Export ("assignObject:toPersistentStore:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AssignObject (NSObject object1, NSPersistentStore store)
		{
			var object1__handle__ = object1!.GetNonNullHandle (nameof (object1));
			var store__handle__ = store!.GetNonNullHandle (nameof (store));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("assignObject:toPersistentStore:"), object1__handle__, store__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("assignObject:toPersistentStore:"), object1__handle__, store__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (object1);
			GC.KeepAlive (store);
		}
		/// <param name="request">To be added.</param><param name="error">To be added.</param><summary>Returns the number of objects that <paramref name="request" /> would return if it were run.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("countForFetchRequest:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual nuint CountForFetchRequest (NSFetchRequest request, out NSError error)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			NativeHandle errorValue = IntPtr.Zero;
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("countForFetchRequest:error:"), request__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("countForFetchRequest:error:"), request__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="object1">To be added.</param><summary>Queues <paramref name="object1" /> for deletion.</summary><remarks>To be added.</remarks>
		[Export ("deleteObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeleteObject (NSManagedObject object1)
		{
			var object1__handle__ = object1!.GetNonNullHandle (nameof (object1));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("deleteObject:"), object1__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("deleteObject:"), object1__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (object1);
		}
		/// <param name="object1">To be added.</param><summary>Marks <paramref name="object1" /> for conflict detection.</summary><remarks>To be added.</remarks>
		[Export ("detectConflictsForObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DetectConflictsForObject (NSManagedObject object1)
		{
			var object1__handle__ = object1!.GetNonNullHandle (nameof (object1));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("detectConflictsForObject:"), object1__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("detectConflictsForObject:"), object1__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (object1);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		/// <param name="request">To be added.</param><param name="error">To be added.</param><summary>Runs the specified <paramref name="request" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("executeFetchRequest:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject[]? ExecuteFetchRequest (NSFetchRequest request, out NSError error)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			NativeHandle errorValue = IntPtr.Zero;
			NSObject[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("executeFetchRequest:error:"), request__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("executeFetchRequest:error:"), request__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="request">To be added.</param><param name="error">To be added.</param><summary>Runs the specified <paramref name="request" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("executeRequest:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSPersistentStoreResult? ExecuteRequest (NSPersistentStoreRequest request, out NSError error)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			NativeHandle errorValue = IntPtr.Zero;
			NSPersistentStoreResult? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSPersistentStoreResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("executeRequest:error:"), request__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSPersistentStoreResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("executeRequest:error:"), request__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="objectID">The object ID of object to fetch.</param><param name="error">On error, this will contain the error information.</param><summary>Fetches an object with a specified id.</summary><returns>The object with the associated ID, or null if the
		/// 	object does not exist, or can not be retrieved.</returns><remarks>To be added.</remarks>
		[Export ("existingObjectWithID:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSManagedObject? GetExistingObject (NSManagedObjectID objectID, out NSError error)
		{
			var objectID__handle__ = objectID!.GetNonNullHandle (nameof (objectID));
			NativeHandle errorValue = IntPtr.Zero;
			NSManagedObject? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSManagedObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("existingObjectWithID:error:"), objectID__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSManagedObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("existingObjectWithID:error:"), objectID__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (objectID);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="object1">To be added.</param><summary>Inserts <paramref name="object1" /> into the context.</summary><remarks>To be added.</remarks>
		[Export ("insertObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertObject (NSManagedObject object1)
		{
			var object1__handle__ = object1!.GetNonNullHandle (nameof (object1));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("insertObject:"), object1__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("insertObject:"), object1__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (object1);
		}
		/// <param name="notification">To be added.</param><summary>Method that is called to merge the changes that are specified by <paramref name="notification" />.</summary><remarks>To be added.</remarks>
		[Export ("mergeChangesFromContextDidSaveNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MergeChangesFromContextDidSaveNotification (NSNotification notification)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("mergeChangesFromContextDidSaveNotification:"), notification__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("mergeChangesFromContextDidSaveNotification:"), notification__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (notification);
		}
		/// <param name="changeNotificationData">To be added.</param><param name="contexts">To be added.</param><summary>Merges remote changes.</summary><remarks>To be added.</remarks>
		[Export ("mergeChangesFromRemoteContextSave:intoContexts:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MergeChangesFromRemoteContextSave (NSDictionary changeNotificationData, NSManagedObjectContext[] contexts)
		{
			var changeNotificationData__handle__ = changeNotificationData!.GetNonNullHandle (nameof (changeNotificationData));
			if (contexts is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (contexts));
			using var nsa_contexts = NSArray.FromNSObjects (contexts);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("mergeChangesFromRemoteContextSave:intoContexts:"), changeNotificationData__handle__, nsa_contexts.Handle);
			GC.KeepAlive (changeNotificationData);
		}
		/// <param name="objectID">To be added.</param><summary>Returns the object that is identified by <paramref name="objectID" />, if it represents a registered object.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("objectRegisteredForID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSManagedObject? ObjectRegisteredForID (NSManagedObjectID objectID)
		{
			var objectID__handle__ = objectID!.GetNonNullHandle (nameof (objectID));
			NSManagedObject? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSManagedObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("objectRegisteredForID:"), objectID__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSManagedObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("objectRegisteredForID:"), objectID__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (objectID);
			return ret!;
		}
		/// <param name="objectID">To be added.</param><summary>Returns the object that is identified by <paramref name="objectID" /></summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("objectWithID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSManagedObject ObjectWithID (NSManagedObjectID objectID)
		{
			var objectID__handle__ = objectID!.GetNonNullHandle (nameof (objectID));
			NSManagedObject? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSManagedObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("objectWithID:"), objectID__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSManagedObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("objectWithID:"), objectID__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (objectID);
			return ret!;
		}
		/// <param name="keyPath">To be added.</param><param name="object1">To be added.</param><param name="change"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="context">To be added.</param><summary>Observes the object that is identified by the provided object and keypath for changes.</summary><remarks>To be added.</remarks>
		[Export ("observeValueForKeyPath:ofObject:change:context:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ObserveValue (string? keyPath, NSObject? object1, NSDictionary? change, nint context)
		{
			var object1__handle__ = object1.GetHandle ();
			var change__handle__ = change.GetHandle ();
			var nskeyPath = CFString.CreateNative (keyPath);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("observeValueForKeyPath:ofObject:change:context:"), nskeyPath, object1__handle__, change__handle__, context);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("observeValueForKeyPath:ofObject:change:context:"), nskeyPath, object1__handle__, change__handle__, context);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (object1);
			GC.KeepAlive (change);
			CFString.ReleaseNative (nskeyPath);
		}
		/// <param name="objects">To be added.</param><param name="error">To be added.</param><summary>Converts the object identifiers to permanent identifiers for the provided <paramref name="objects" />. Returns <see langword="true" /> if all of the identifiers were converted.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("obtainPermanentIDsForObjects:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ObtainPermanentIDsForObjects (NSManagedObject[] objects, out NSError error)
		{
			if (objects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objects));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_objects = NSArray.FromNSObjects (objects);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("obtainPermanentIDsForObjects:error:"), nsa_objects.Handle, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("obtainPermanentIDsForObjects:error:"), nsa_objects.Handle, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="action">To be added.</param><summary>Asynchronously performs the specified <paramref name="action" />.</summary><remarks>To be added.</remarks>
		[Export ("performBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Perform ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action action)
		{
			if (action is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (action));
			using var block_action = Trampolines.SDAction.CreateBlock (action);
			BlockLiteral *block_ptr_action = &block_action;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("performBlock:"), (IntPtr) block_ptr_action);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("performBlock:"), (IntPtr) block_ptr_action);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="action">To be added.</param><summary>Synchronously performs the specified <paramref name="action" />.</summary><remarks>To be added.</remarks>
		[Export ("performBlockAndWait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PerformAndWait ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action action)
		{
			if (action is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (action));
			using var block_action = Trampolines.SDAction.CreateBlock (action);
			BlockLiteral *block_ptr_action = &block_action;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("performBlockAndWait:"), (IntPtr) block_ptr_action);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("performBlockAndWait:"), (IntPtr) block_ptr_action);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Tells the receiver to process all changes on the object graph.</summary><remarks>To be added.</remarks>
		[Export ("processPendingChanges")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProcessPendingChanges ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("processPendingChanges"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("processPendingChanges"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Reverses the most recent unreversed undo.</summary><remarks>To be added.</remarks>
		[Export ("redo")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Redo ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("redo"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("redo"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Refreshes all objects in the store.</summary><remarks>To be added.</remarks>
		[Export ("refreshAllObjects")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RefreshAllObjects ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("refreshAllObjects"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("refreshAllObjects"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="object1">To be added.</param><param name="flag">To be added.</param><summary>Refreshes <paramref name="object1" /> with the most current values from its store.</summary><remarks>To be added.</remarks>
		[Export ("refreshObject:mergeChanges:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RefreshObject (NSManagedObject object1, bool flag)
		{
			var object1__handle__ = object1!.GetNonNullHandle (nameof (object1));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("refreshObject:mergeChanges:"), object1__handle__, flag ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("refreshObject:mergeChanges:"), object1__handle__, flag ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (object1);
		}
		/// <summary>Resets the receiver.</summary><remarks>To be added.</remarks>
		[Export ("reset")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Reset ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reset"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("reset"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Rolls the state of all objects in the object graph back to the most recent committed values.</summary><remarks>To be added.</remarks>
		[Export ("rollback")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Rollback ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("rollback"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("rollback"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="error">To be added.</param><summary>Saves uncommitted changes and reports any error that it encounters.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("save:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Save (out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, Selector.GetHandle ("save:"), &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("save:"), &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="generation"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error">To be added.</param><summary>Sets the query generation from the specified query generation token.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("setQueryGenerationFromToken:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetQueryGenerationFromToken (NSQueryGenerationToken? generation, out NSError error)
		{
			var generation__handle__ = generation.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("setQueryGenerationFromToken:error:"), generation__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("setQueryGenerationFromToken:error:"), generation__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (generation);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="fault">To be added.</param><param name="oid">To be added.</param><param name="property"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Returns a Boolean value that controls whether inaccessible faults will be handled.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shouldHandleInaccessibleFault:forObjectID:triggeredByProperty:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldHandleInaccessibleFault (NSManagedObject fault, NSManagedObjectID oid, NSPropertyDescription? property)
		{
			var fault__handle__ = fault!.GetNonNullHandle (nameof (fault));
			var oid__handle__ = oid!.GetNonNullHandle (nameof (oid));
			var property__handle__ = property.GetHandle ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("shouldHandleInaccessibleFault:forObjectID:triggeredByProperty:"), fault__handle__, oid__handle__, property__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("shouldHandleInaccessibleFault:forObjectID:triggeredByProperty:"), fault__handle__, oid__handle__, property__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fault);
			GC.KeepAlive (oid);
			GC.KeepAlive (property);
			return ret != 0;
		}
		/// <summary>Instructs the receiver to undo its uncommitted changes.</summary><remarks>To be added.</remarks>
		[Export ("undo")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Undo ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("undo"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("undo"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Gets or sets a Boolean that tells whether changes in the parent are automatically merged.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool AutomaticallyMergesChangesFromParent {
			[Export ("automaticallyMergesChangesFromParent")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("automaticallyMergesChangesFromParent"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("automaticallyMergesChangesFromParent"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutomaticallyMergesChangesFromParent:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutomaticallyMergesChangesFromParent:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAutomaticallyMergesChangesFromParent:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the receiver's concurrency type.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSManagedObjectContextConcurrencyType ConcurrencyType {
			[Export ("concurrencyType")]
			get {
				NSManagedObjectContextConcurrencyType ret;
				if (IsDirectBinding) {
					ret = (CoreData.NSManagedObjectContextConcurrencyType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("concurrencyType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CoreData.NSManagedObjectContextConcurrencyType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("concurrencyType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets a set that contains the objects that will be deleted by the next save operation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet DeletedObjects {
			[Export ("deletedObjects", ArgumentSemantic.Retain)]
			get {
				NSSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("deletedObjects")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("deletedObjects")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the receiver has any unsaved changes.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasChanges {
			[Export ("hasChanges")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasChanges"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("hasChanges"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets the inserted, but unsaved, objects in the context.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet InsertedObjects {
			[Export ("insertedObjects", ArgumentSemantic.Retain)]
			get {
				NSSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("insertedObjects")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("insertedObjects")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets the receiver's merge policy.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint MergePolicy {
			[Export ("mergePolicy", ArgumentSemantic.Retain)]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mergePolicy"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("mergePolicy"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMergePolicy:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMergePolicy:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setMergePolicy:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a name for the object.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual string? Name {
			[Export ("name")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("name")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("name")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setName:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setName:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>Gets the receiver's parent context.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSManagedObjectContext? ParentContext {
			[Export ("parentContext", ArgumentSemantic.Retain)]
			get {
				NSManagedObjectContext? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSManagedObjectContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("parentContext")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSManagedObjectContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("parentContext")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setParentContext:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setParentContext:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setParentContext:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets the receiver's store coordinator.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPersistentStoreCoordinator? PersistentStoreCoordinator {
			[Export ("persistentStoreCoordinator", ArgumentSemantic.Retain)]
			get {
				NSPersistentStoreCoordinator? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSPersistentStoreCoordinator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("persistentStoreCoordinator")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSPersistentStoreCoordinator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("persistentStoreCoordinator")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPersistentStoreCoordinator:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPersistentStoreCoordinator:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPersistentStoreCoordinator:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the receiver propagates deletes after change events.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PropagatesDeletesAtEndOfEvent {
			[Export ("propagatesDeletesAtEndOfEvent")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("propagatesDeletesAtEndOfEvent"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("propagatesDeletesAtEndOfEvent"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPropagatesDeletesAtEndOfEvent:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPropagatesDeletesAtEndOfEvent:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setPropagatesDeletesAtEndOfEvent:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the token that identifies the current query generation behavior.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSQueryGenerationToken? QueryGenerationToken {
			[Export ("queryGenerationToken", ArgumentSemantic.Retain)]
			get {
				NSQueryGenerationToken? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSQueryGenerationToken> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("queryGenerationToken")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSQueryGenerationToken> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("queryGenerationToken")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets a set that contains all of the receiver's registered objects.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet RegisteredObjects {
			[Export ("registeredObjects", ArgumentSemantic.Retain)]
			get {
				NSSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("registeredObjects")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("registeredObjects")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the receiver retains hard references to its registered managed objects.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RetainsRegisteredObjects {
			[Export ("retainsRegisteredObjects")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("retainsRegisteredObjects"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("retainsRegisteredObjects"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setRetainsRegisteredObjects:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRetainsRegisteredObjects:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setRetainsRegisteredObjects:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether inaccessible faults will be deleted.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool ShouldDeleteInaccessibleFaults {
			[Export ("shouldDeleteInaccessibleFaults")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldDeleteInaccessibleFaults"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("shouldDeleteInaccessibleFaults"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShouldDeleteInaccessibleFaults:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldDeleteInaccessibleFaults:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShouldDeleteInaccessibleFaults:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the maximum elapsed time after fetching which causes fault fulfillment to fetch new data.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double StalenessInterval {
			[Export ("stalenessInterval")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("stalenessInterval"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("stalenessInterval"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setStalenessInterval:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setStalenessInterval:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, Selector.GetHandle ("setStalenessInterval:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the author of the persistent history context.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual string? TransactionAuthor {
			[Export ("transactionAuthor")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("transactionAuthor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("transactionAuthor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTransactionAuthor:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTransactionAuthor:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTransactionAuthor:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>Gets the receiver's undo manager.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUndoManager? UndoManager {
			[Export ("undoManager", ArgumentSemantic.Retain)]
			get {
				NSUndoManager? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUndoManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("undoManager")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUndoManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("undoManager")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setUndoManager:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setUndoManager:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setUndoManager:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets a set that contains all of the receiver's objects which have uncommitted changes.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet UpdatedObjects {
			[Export ("updatedObjects", ArgumentSemantic.Retain)]
			get {
				NSSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("updatedObjects")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("updatedObjects")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the receiver's user information.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableDictionary UserInfo {
			[Export ("userInfo", ArgumentSemantic.Retain)]
			get {
				NSMutableDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("userInfo")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("userInfo")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidMergeChangesObjectIdsNotification;
		/// <summary>Notification constant for DidMergeChangesObjectIds</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidMergeChangesObjectIds(NSObject,EventHandler{NSManagedObjectsIdsChangedEventArgs})" />
		///     or <see cref="Notifications.ObserveDidMergeChangesObjectIds(EventHandler{NSManagedObjectsIdsChangedEventArgs})" /> methods,
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
		/// notification = NSManagedObjectContext.Notifications.ObserveDidMergeChangesObjectIds ((sender, args) => {
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
		/// void Callback (object sender, NSManagedObjectContext.NSManagedObjectsIdsChangedEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSManagedObjectContext.Notifications.ObserveDidMergeChangesObjectIds (Callback);
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
		///     NSManagedObjectContext.DidMergeChangesObjectIdsNotification, (notification) => { Console.WriteLine ("Received the notification DidMergeChangesObjectIds", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidMergeChangesObjectIds", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSManagedObjectContext.DidMergeChangesObjectIdsNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSManagedObjectContextDidMergeChangesObjectIDsNotification",  "CoreData")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Advice ("Use NSManagedObjectContext.Notifications.ObserveDidMergeChangesObjectIds helper method instead.")]
		public static NSString DidMergeChangesObjectIdsNotification {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DidMergeChangesObjectIdsNotification is null)
					_DidMergeChangesObjectIdsNotification = Dlfcn.GetStringConstant (Libraries.CoreData.Handle, "NSManagedObjectContextDidMergeChangesObjectIDsNotification")!;
				return _DidMergeChangesObjectIdsNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidSaveNotification;
		/// <summary>Notification constant for DidSave</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidSave(NSObject,EventHandler{NSManagedObjectChangeEventArgs})" />
		///     or <see cref="Notifications.ObserveDidSave(EventHandler{NSManagedObjectChangeEventArgs})" /> methods,
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
		/// notification = NSManagedObjectContext.Notifications.ObserveDidSave ((sender, args) => {
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
		/// void Callback (object sender, NSManagedObjectContext.NSManagedObjectChangeEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSManagedObjectContext.Notifications.ObserveDidSave (Callback);
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
		///     NSManagedObjectContext.DidSaveNotification, (notification) => { Console.WriteLine ("Received the notification DidSave", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidSave", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSManagedObjectContext.DidSaveNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSManagedObjectContextDidSaveNotification",  "CoreData")]
		[Advice ("Use NSManagedObjectContext.Notifications.ObserveDidSave helper method instead.")]
		public static NSString DidSaveNotification {
			get {
				if (_DidSaveNotification is null)
					_DidSaveNotification = Dlfcn.GetStringConstant (Libraries.CoreData.Handle, "NSManagedObjectContextDidSaveNotification")!;
				return _DidSaveNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidSaveObjectIdsNotification;
		/// <summary>Notification constant for DidSaveObjectIds</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidSaveObjectIds(NSObject,EventHandler{NSManagedObjectsIdsChangedEventArgs})" />
		///     or <see cref="Notifications.ObserveDidSaveObjectIds(EventHandler{NSManagedObjectsIdsChangedEventArgs})" /> methods,
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
		/// notification = NSManagedObjectContext.Notifications.ObserveDidSaveObjectIds ((sender, args) => {
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
		/// void Callback (object sender, NSManagedObjectContext.NSManagedObjectsIdsChangedEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSManagedObjectContext.Notifications.ObserveDidSaveObjectIds (Callback);
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
		///     NSManagedObjectContext.DidSaveObjectIdsNotification, (notification) => { Console.WriteLine ("Received the notification DidSaveObjectIds", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidSaveObjectIds", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSManagedObjectContext.DidSaveObjectIdsNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSManagedObjectContextDidSaveObjectIDsNotification",  "CoreData")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Advice ("Use NSManagedObjectContext.Notifications.ObserveDidSaveObjectIds helper method instead.")]
		public static NSString DidSaveObjectIdsNotification {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DidSaveObjectIdsNotification is null)
					_DidSaveObjectIdsNotification = Dlfcn.GetStringConstant (Libraries.CoreData.Handle, "NSManagedObjectContextDidSaveObjectIDsNotification")!;
				return _DidSaveObjectIdsNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ObjectsDidChangeNotification;
		/// <summary>Notification constant for ObjectsDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveObjectsDidChange(NSObject,EventHandler{NSManagedObjectChangeEventArgs})" />
		///     or <see cref="Notifications.ObserveObjectsDidChange(EventHandler{NSManagedObjectChangeEventArgs})" /> methods,
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
		/// notification = NSManagedObjectContext.Notifications.ObserveObjectsDidChange ((sender, args) => {
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
		/// void Callback (object sender, NSManagedObjectContext.NSManagedObjectChangeEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSManagedObjectContext.Notifications.ObserveObjectsDidChange (Callback);
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
		///     NSManagedObjectContext.ObjectsDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification ObjectsDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ObjectsDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSManagedObjectContext.ObjectsDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSManagedObjectContextObjectsDidChangeNotification",  "CoreData")]
		[Advice ("Use NSManagedObjectContext.Notifications.ObserveObjectsDidChange helper method instead.")]
		public static NSString ObjectsDidChangeNotification {
			get {
				if (_ObjectsDidChangeNotification is null)
					_ObjectsDidChangeNotification = Dlfcn.GetStringConstant (Libraries.CoreData.Handle, "NSManagedObjectContextObjectsDidChangeNotification")!;
				return _ObjectsDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WillSaveNotification;
		/// <summary>Notification constant for WillSave</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWillSave(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveWillSave(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSManagedObjectContext.Notifications.ObserveWillSave ((sender, args) => {
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
		/// void Callback (object sender, NSManagedObjectContext.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSManagedObjectContext.Notifications.ObserveWillSave (Callback);
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
		///     NSManagedObjectContext.WillSaveNotification, (notification) => { Console.WriteLine ("Received the notification WillSave", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WillSave", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSManagedObjectContext.WillSaveNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSManagedObjectContextWillSaveNotification",  "CoreData")]
		[Advice ("Use NSManagedObjectContext.Notifications.ObserveWillSave helper method instead.")]
		public static NSString WillSaveNotification {
			get {
				if (_WillSaveNotification is null)
					_WillSaveNotification = Dlfcn.GetStringConstant (Libraries.CoreData.Handle, "NSManagedObjectContextWillSaveNotification")!;
				return _WillSaveNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::CoreData.NSManagedObjectContext" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::CoreData.NSManagedObjectContext.DidMergeChangesObjectIdsNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::CoreData.NSManagedObjectContext.DidMergeChangesObjectIdsNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSManagedObjectContext.Notifications.ObserveDidMergeChangesObjectIds ((notification) => {
			///   Console.WriteLine ("Observed DidMergeChangesObjectIdsNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidMergeChangesObjectIds (EventHandler<CoreData.NSManagedObjectsIdsChangedEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidMergeChangesObjectIdsNotification, notification => handler (null, new CoreData.NSManagedObjectsIdsChangedEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::CoreData.NSManagedObjectContext.DidMergeChangesObjectIdsNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::CoreData.NSManagedObjectContext.DidMergeChangesObjectIdsNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSManagedObjectContext.Notifications.ObserveDidMergeChangesObjectIds (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidMergeChangesObjectIdsNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidMergeChangesObjectIds (NSObject objectToObserve, EventHandler<CoreData.NSManagedObjectsIdsChangedEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidMergeChangesObjectIdsNotification, notification => handler (null, new CoreData.NSManagedObjectsIdsChangedEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::CoreData.NSManagedObjectContext.DidSaveNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::CoreData.NSManagedObjectContext.DidSaveNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSManagedObjectContext.Notifications.ObserveDidSave ((notification) => {
			///   Console.WriteLine ("Observed DidSaveNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidSave (EventHandler<CoreData.NSManagedObjectChangeEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidSaveNotification, notification => handler (null, new CoreData.NSManagedObjectChangeEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::CoreData.NSManagedObjectContext.DidSaveNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::CoreData.NSManagedObjectContext.DidSaveNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSManagedObjectContext.Notifications.ObserveDidSave (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidSaveNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidSave (NSObject objectToObserve, EventHandler<CoreData.NSManagedObjectChangeEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidSaveNotification, notification => handler (null, new CoreData.NSManagedObjectChangeEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::CoreData.NSManagedObjectContext.DidSaveObjectIdsNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::CoreData.NSManagedObjectContext.DidSaveObjectIdsNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSManagedObjectContext.Notifications.ObserveDidSaveObjectIds ((notification) => {
			///   Console.WriteLine ("Observed DidSaveObjectIdsNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidSaveObjectIds (EventHandler<CoreData.NSManagedObjectsIdsChangedEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidSaveObjectIdsNotification, notification => handler (null, new CoreData.NSManagedObjectsIdsChangedEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::CoreData.NSManagedObjectContext.DidSaveObjectIdsNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::CoreData.NSManagedObjectContext.DidSaveObjectIdsNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSManagedObjectContext.Notifications.ObserveDidSaveObjectIds (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidSaveObjectIdsNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidSaveObjectIds (NSObject objectToObserve, EventHandler<CoreData.NSManagedObjectsIdsChangedEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidSaveObjectIdsNotification, notification => handler (null, new CoreData.NSManagedObjectsIdsChangedEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::CoreData.NSManagedObjectContext.ObjectsDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::CoreData.NSManagedObjectContext.ObjectsDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSManagedObjectContext.Notifications.ObserveObjectsDidChange ((notification) => {
			///   Console.WriteLine ("Observed ObjectsDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveObjectsDidChange (EventHandler<CoreData.NSManagedObjectChangeEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ObjectsDidChangeNotification, notification => handler (null, new CoreData.NSManagedObjectChangeEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::CoreData.NSManagedObjectContext.ObjectsDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::CoreData.NSManagedObjectContext.ObjectsDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSManagedObjectContext.Notifications.ObserveObjectsDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ObjectsDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveObjectsDidChange (NSObject objectToObserve, EventHandler<CoreData.NSManagedObjectChangeEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ObjectsDidChangeNotification, notification => handler (null, new CoreData.NSManagedObjectChangeEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::CoreData.NSManagedObjectContext.WillSaveNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::CoreData.NSManagedObjectContext.WillSaveNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSManagedObjectContext.Notifications.ObserveWillSave ((notification) => {
			///   Console.WriteLine ("Observed WillSaveNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillSave (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WillSaveNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::CoreData.NSManagedObjectContext.WillSaveNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::CoreData.NSManagedObjectContext.WillSaveNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSManagedObjectContext.Notifications.ObserveWillSave (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WillSaveNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillSave (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WillSaveNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSManagedObjectContext */
}
