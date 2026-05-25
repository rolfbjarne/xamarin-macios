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
	/// <summary>Supports the use of persistent stores that are loaded and saved incrementally, allowing for larger and shared datasets.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreData/Reference/NSIncrementalStore_Class/index.html">Apple documentation for <c>NSIncrementalStore</c></related>
	[Register("NSIncrementalStore", true)]
	public unsafe partial class NSIncrementalStore : NSPersistentStore {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExecuteRequest_WithContext_Error_X = "executeRequest:withContext:error:";
		static readonly NativeHandle selExecuteRequest_WithContext_Error_XHandle = Selector.GetHandle ("executeRequest:withContext:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIdentifierForNewStoreAtURL_X = "identifierForNewStoreAtURL:";
		static readonly NativeHandle selIdentifierForNewStoreAtURL_XHandle = Selector.GetHandle ("identifierForNewStoreAtURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPersistentStoreCoordinator_ConfigurationName_URL_Options_X = "initWithPersistentStoreCoordinator:configurationName:URL:options:";
		static readonly NativeHandle selInitWithPersistentStoreCoordinator_ConfigurationName_URL_Options_XHandle = Selector.GetHandle ("initWithPersistentStoreCoordinator:configurationName:URL:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadMetadata_X = "loadMetadata:";
		static readonly NativeHandle selLoadMetadata_XHandle = Selector.GetHandle ("loadMetadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selManagedObjectContextDidRegisterObjectsWithIDs_X = "managedObjectContextDidRegisterObjectsWithIDs:";
		static readonly NativeHandle selManagedObjectContextDidRegisterObjectsWithIDs_XHandle = Selector.GetHandle ("managedObjectContextDidRegisterObjectsWithIDs:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selManagedObjectContextDidUnregisterObjectsWithIDs_X = "managedObjectContextDidUnregisterObjectsWithIDs:";
		static readonly NativeHandle selManagedObjectContextDidUnregisterObjectsWithIDs_XHandle = Selector.GetHandle ("managedObjectContextDidUnregisterObjectsWithIDs:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewObjectIDForEntity_ReferenceObject_X = "newObjectIDForEntity:referenceObject:";
		static readonly NativeHandle selNewObjectIDForEntity_ReferenceObject_XHandle = Selector.GetHandle ("newObjectIDForEntity:referenceObject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewValueForRelationship_ForObjectWithID_WithContext_Error_X = "newValueForRelationship:forObjectWithID:withContext:error:";
		static readonly NativeHandle selNewValueForRelationship_ForObjectWithID_WithContext_Error_XHandle = Selector.GetHandle ("newValueForRelationship:forObjectWithID:withContext:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewValuesForObjectWithID_WithContext_Error_X = "newValuesForObjectWithID:withContext:error:";
		static readonly NativeHandle selNewValuesForObjectWithID_WithContext_Error_XHandle = Selector.GetHandle ("newValuesForObjectWithID:withContext:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObtainPermanentIDsForObjects_Error_X = "obtainPermanentIDsForObjects:error:";
		static readonly NativeHandle selObtainPermanentIDsForObjects_Error_XHandle = Selector.GetHandle ("obtainPermanentIDsForObjects:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReferenceObjectForObjectID_X = "referenceObjectForObjectID:";
		static readonly NativeHandle selReferenceObjectForObjectID_XHandle = Selector.GetHandle ("referenceObjectForObjectID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSIncrementalStore");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSIncrementalStore" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSIncrementalStore () : base (NSObjectFlag.Empty)
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
		protected NSIncrementalStore (NSObjectFlag t) : base (t)
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
		protected internal NSIncrementalStore (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="root">To be added.</param><param name="name">To be added.</param><param name="url">To be added.</param><param name="options">To be added.</param><summary>Creates a new <see cref="T:CoreData.NSIncrementalStore" /> with the specified values.</summary><remarks>To be added.</remarks>
		[Export ("initWithPersistentStoreCoordinator:configurationName:URL:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected NSIncrementalStore (NSPersistentStoreCoordinator root, string name, NSUrl url, NSDictionary options)
			: base (NSObjectFlag.Empty)
		{
			var root__handle__ = root!.GetNonNullHandle (nameof (root));
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithPersistentStoreCoordinator_ConfigurationName_URL_Options_XHandle, root__handle__, nsname, url__handle__, options__handle__), "initWithPersistentStoreCoordinator:configurationName:URL:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithPersistentStoreCoordinator_ConfigurationName_URL_Options_XHandle, root__handle__, nsname, url__handle__, options__handle__), "initWithPersistentStoreCoordinator:configurationName:URL:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (root);
			GC.KeepAlive (url);
			GC.KeepAlive (options);
			CFString.ReleaseNative (nsname);
		}
		/// <param name="request">To be added.</param><param name="context"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error">To be added.</param><summary>Runs the specified <paramref name="request" /> in the specified <paramref name="context" />, and reports any errors in <paramref name="error" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("executeRequest:withContext:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject? ExecuteRequest (NSPersistentStoreRequest request, NSManagedObjectContext? context, out NSError error)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var context__handle__ = context.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selExecuteRequest_WithContext_Error_XHandle, request__handle__, context__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selExecuteRequest_WithContext_Error_XHandle, request__handle__, context__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			GC.KeepAlive (context);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="storeUrl">To be added.</param><summary>Returns the identifier for the store at <paramref name="storeUrl" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("identifierForNewStoreAtURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetIdentifierForNewStore (NSUrl storeUrl)
		{
			var storeUrl__handle__ = storeUrl!.GetNonNullHandle (nameof (storeUrl));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selIdentifierForNewStoreAtURL_XHandle, storeUrl__handle__), false)!;
			GC.KeepAlive (storeUrl);
			return ret!;
		}
		/// <param name="error">To be added.</param><summary>Loads the store metadata and reports any errors in <paramref name="error" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("loadMetadata:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool LoadMetadata (out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, selLoadMetadata_XHandle, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selLoadMetadata_XHandle, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="objectIds">To be added.</param><summary>Method that is called when the <paramref name="objectIds" /> are registered for use.</summary><remarks>To be added.</remarks>
		[Export ("managedObjectContextDidRegisterObjectsWithIDs:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ManagedObjectContextDidRegisterObjectsWithIds (NSObject[] objectIds)
		{
			if (objectIds is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objectIds));
			using var nsa_objectIds = NSArray.FromNSObjects (objectIds);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selManagedObjectContextDidRegisterObjectsWithIDs_XHandle, nsa_objectIds.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selManagedObjectContextDidRegisterObjectsWithIDs_XHandle, nsa_objectIds.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="objectIds">To be added.</param><summary>Method that is called when the <paramref name="objectIds" /> are unregistered for use.</summary><remarks>To be added.</remarks>
		[Export ("managedObjectContextDidUnregisterObjectsWithIDs:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ManagedObjectContextDidUnregisterObjectsWithIds (NSObject[] objectIds)
		{
			if (objectIds is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objectIds));
			using var nsa_objectIds = NSArray.FromNSObjects (objectIds);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selManagedObjectContextDidUnregisterObjectsWithIDs_XHandle, nsa_objectIds.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selManagedObjectContextDidUnregisterObjectsWithIDs_XHandle, nsa_objectIds.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="forEntity">To be added.</param><param name="referenceObject">To be added.</param><summary>Developers should not override this method. Returns a new ID for the entity and description.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newObjectIDForEntity:referenceObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSManagedObjectID NewObjectIdFor (NSEntityDescription forEntity, NSObject referenceObject)
		{
			var forEntity__handle__ = forEntity!.GetNonNullHandle (nameof (forEntity));
			var referenceObject__handle__ = referenceObject!.GetNonNullHandle (nameof (referenceObject));
			NSManagedObjectID? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSManagedObjectID> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selNewObjectIDForEntity_ReferenceObject_XHandle, forEntity__handle__, referenceObject__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSManagedObjectID> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selNewObjectIDForEntity_ReferenceObject_XHandle, forEntity__handle__, referenceObject__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (forEntity);
			GC.KeepAlive (referenceObject);
			return ret!;
		}
		/// <param name="forRelationship">To be added.</param><param name="forObjectI">To be added.</param><param name="context"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error">To be added.</param><summary>Returns a new relationship for the specified relationship data.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newValueForRelationship:forObjectWithID:withContext:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject? NewValue (NSRelationshipDescription forRelationship, NSManagedObjectID forObjectI, NSManagedObjectContext? context, out NSError error)
		{
			var forRelationship__handle__ = forRelationship!.GetNonNullHandle (nameof (forRelationship));
			var forObjectI__handle__ = forObjectI!.GetNonNullHandle (nameof (forObjectI));
			var context__handle__ = context.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selNewValueForRelationship_ForObjectWithID_WithContext_Error_XHandle, forRelationship__handle__, forObjectI__handle__, context__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selNewValueForRelationship_ForObjectWithID_WithContext_Error_XHandle, forRelationship__handle__, forObjectI__handle__, context__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (forRelationship);
			GC.KeepAlive (forObjectI);
			GC.KeepAlive (context);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="forObjectId">To be added.</param><param name="context">To be added.</param><param name="error">To be added.</param><summary>Returns a <see cref="T:CoreData.NSIncrementalStoreNode" /> for the persistent external values of the identified object and reports any errors in <paramref name="error" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newValuesForObjectWithID:withContext:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSIncrementalStoreNode? NewValues (NSManagedObjectID forObjectId, NSManagedObjectContext context, out NSError error)
		{
			var forObjectId__handle__ = forObjectId!.GetNonNullHandle (nameof (forObjectId));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			NativeHandle errorValue = IntPtr.Zero;
			NSIncrementalStoreNode? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIncrementalStoreNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selNewValuesForObjectWithID_WithContext_Error_XHandle, forObjectId__handle__, context__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSIncrementalStoreNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selNewValuesForObjectWithID_WithContext_Error_XHandle, forObjectId__handle__, context__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (forObjectId);
			GC.KeepAlive (context);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="array">To be added.</param><param name="error">To be added.</param><summary>Returns an array of permanent identifiers for the provided newly inserted objects and reports any errors in <paramref name="error" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("obtainPermanentIDsForObjects:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject[]? ObtainPermanentIds (NSObject[] array, out NSError error)
		{
			if (array is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (array));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_array = NSArray.FromNSObjects (array);
			NSObject[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selObtainPermanentIDsForObjects_Error_XHandle, nsa_array.Handle, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selObtainPermanentIDsForObjects_Error_XHandle, nsa_array.Handle, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="objectId">To be added.</param><summary>Developers should not override this method. Returns a reference object for <paramref name="objectId" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("referenceObjectForObjectID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ReferenceObjectForObject (NSManagedObjectID objectId)
		{
			var objectId__handle__ = objectId!.GetNonNullHandle (nameof (objectId));
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selReferenceObjectForObjectID_XHandle, objectId__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selReferenceObjectForObjectID_XHandle, objectId__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (objectId);
			return ret!;
		}
	} /* class NSIncrementalStore */
}
