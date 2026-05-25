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
	/// <summary>A class that can be managed by a managed object context. Should have a correspondence to domain model classes, even if they are not direct subtypes.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/CoreDataFramework/Classes/NSManagedObject_Class/index.html">Apple documentation for <c>NSManagedObject</c></related>
	[Register("NSManagedObject", true)]
	public unsafe partial class NSManagedObject : NSObject, INSFetchRequestResult {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAwakeFromFetchX = "awakeFromFetch";
		static readonly NativeHandle selAwakeFromFetchXHandle = Selector.GetHandle ("awakeFromFetch");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAwakeFromInsertX = "awakeFromInsert";
		static readonly NativeHandle selAwakeFromInsertXHandle = Selector.GetHandle ("awakeFromInsert");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAwakeFromSnapshotEvents_X = "awakeFromSnapshotEvents:";
		static readonly NativeHandle selAwakeFromSnapshotEvents_XHandle = Selector.GetHandle ("awakeFromSnapshotEvents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangedValuesX = "changedValues";
		static readonly NativeHandle selChangedValuesXHandle = Selector.GetHandle ("changedValues");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangedValuesForCurrentEventX = "changedValuesForCurrentEvent";
		static readonly NativeHandle selChangedValuesForCurrentEventXHandle = Selector.GetHandle ("changedValuesForCurrentEvent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommittedValuesForKeys_X = "committedValuesForKeys:";
		static readonly NativeHandle selCommittedValuesForKeys_XHandle = Selector.GetHandle ("committedValuesForKeys:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextShouldIgnoreUnmodeledPropertyChangesX = "contextShouldIgnoreUnmodeledPropertyChanges";
		static readonly NativeHandle selContextShouldIgnoreUnmodeledPropertyChangesXHandle = Selector.GetHandle ("contextShouldIgnoreUnmodeledPropertyChanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidAccessValueForKey_X = "didAccessValueForKey:";
		static readonly NativeHandle selDidAccessValueForKey_XHandle = Selector.GetHandle ("didAccessValueForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidChangeValueForKey_X = "didChangeValueForKey:";
		static readonly NativeHandle selDidChangeValueForKey_XHandle = Selector.GetHandle ("didChangeValueForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidChangeValueForKey_WithSetMutation_UsingObjects_X = "didChangeValueForKey:withSetMutation:usingObjects:";
		static readonly NativeHandle selDidChangeValueForKey_WithSetMutation_UsingObjects_XHandle = Selector.GetHandle ("didChangeValueForKey:withSetMutation:usingObjects:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidSaveX = "didSave";
		static readonly NativeHandle selDidSaveXHandle = Selector.GetHandle ("didSave");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidTurnIntoFaultX = "didTurnIntoFault";
		static readonly NativeHandle selDidTurnIntoFaultXHandle = Selector.GetHandle ("didTurnIntoFault");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEntityX = "entity";
		static readonly NativeHandle selEntityXHandle = Selector.GetHandle ("entity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFaultingStateX = "faultingState";
		static readonly NativeHandle selFaultingStateXHandle = Selector.GetHandle ("faultingState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchRequestX = "fetchRequest";
		static readonly NativeHandle selFetchRequestXHandle = Selector.GetHandle ("fetchRequest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasChangesX = "hasChanges";
		static readonly NativeHandle selHasChangesXHandle = Selector.GetHandle ("hasChanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasFaultForRelationshipNamed_X = "hasFaultForRelationshipNamed:";
		static readonly NativeHandle selHasFaultForRelationshipNamed_XHandle = Selector.GetHandle ("hasFaultForRelationshipNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasPersistentChangedValuesX = "hasPersistentChangedValues";
		static readonly NativeHandle selHasPersistentChangedValuesXHandle = Selector.GetHandle ("hasPersistentChangedValues");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithContext_X = "initWithContext:";
		static readonly NativeHandle selInitWithContext_XHandle = Selector.GetHandle ("initWithContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithEntity_InsertIntoManagedObjectContext_X = "initWithEntity:insertIntoManagedObjectContext:";
		static readonly NativeHandle selInitWithEntity_InsertIntoManagedObjectContext_XHandle = Selector.GetHandle ("initWithEntity:insertIntoManagedObjectContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDeletedX = "isDeleted";
		static readonly NativeHandle selIsDeletedXHandle = Selector.GetHandle ("isDeleted");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFaultX = "isFault";
		static readonly NativeHandle selIsFaultXHandle = Selector.GetHandle ("isFault");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsInsertedX = "isInserted";
		static readonly NativeHandle selIsInsertedXHandle = Selector.GetHandle ("isInserted");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsUpdatedX = "isUpdated";
		static readonly NativeHandle selIsUpdatedXHandle = Selector.GetHandle ("isUpdated");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selManagedObjectContextX = "managedObjectContext";
		static readonly NativeHandle selManagedObjectContextXHandle = Selector.GetHandle ("managedObjectContext");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectIDX = "objectID";
		static readonly NativeHandle selObjectIDXHandle = Selector.GetHandle ("objectID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectIDsForRelationshipNamed_X = "objectIDsForRelationshipNamed:";
		static readonly NativeHandle selObjectIDsForRelationshipNamed_XHandle = Selector.GetHandle ("objectIDsForRelationshipNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObservationInfoX = "observationInfo";
		static readonly NativeHandle selObservationInfoXHandle = Selector.GetHandle ("observationInfo");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareForDeletionX = "prepareForDeletion";
		static readonly NativeHandle selPrepareForDeletionXHandle = Selector.GetHandle ("prepareForDeletion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrimitiveValueForKey_X = "primitiveValueForKey:";
		static readonly NativeHandle selPrimitiveValueForKey_XHandle = Selector.GetHandle ("primitiveValueForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetObservationInfo_X = "setObservationInfo:";
		static readonly NativeHandle selSetObservationInfo_XHandle = Selector.GetHandle ("setObservationInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrimitiveValue_ForKey_X = "setPrimitiveValue:forKey:";
		static readonly NativeHandle selSetPrimitiveValue_ForKey_XHandle = Selector.GetHandle ("setPrimitiveValue:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetValue_ForKey_X = "setValue:forKey:";
		static readonly NativeHandle selSetValue_ForKey_XHandle = Selector.GetHandle ("setValue:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateForDelete_X = "validateForDelete:";
		static readonly NativeHandle selValidateForDelete_XHandle = Selector.GetHandle ("validateForDelete:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateForInsert_X = "validateForInsert:";
		static readonly NativeHandle selValidateForInsert_XHandle = Selector.GetHandle ("validateForInsert:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateForUpdate_X = "validateForUpdate:";
		static readonly NativeHandle selValidateForUpdate_XHandle = Selector.GetHandle ("validateForUpdate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateValue_ForKey_Error_X = "validateValue:forKey:error:";
		static readonly NativeHandle selValidateValue_ForKey_Error_XHandle = Selector.GetHandle ("validateValue:forKey:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueForKey_X = "valueForKey:";
		static readonly NativeHandle selValueForKey_XHandle = Selector.GetHandle ("valueForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWillAccessValueForKey_X = "willAccessValueForKey:";
		static readonly NativeHandle selWillAccessValueForKey_XHandle = Selector.GetHandle ("willAccessValueForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWillChangeValueForKey_X = "willChangeValueForKey:";
		static readonly NativeHandle selWillChangeValueForKey_XHandle = Selector.GetHandle ("willChangeValueForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWillChangeValueForKey_WithSetMutation_UsingObjects_X = "willChangeValueForKey:withSetMutation:usingObjects:";
		static readonly NativeHandle selWillChangeValueForKey_WithSetMutation_UsingObjects_XHandle = Selector.GetHandle ("willChangeValueForKey:withSetMutation:usingObjects:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWillSaveX = "willSave";
		static readonly NativeHandle selWillSaveXHandle = Selector.GetHandle ("willSave");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWillTurnIntoFaultX = "willTurnIntoFault";
		static readonly NativeHandle selWillTurnIntoFaultXHandle = Selector.GetHandle ("willTurnIntoFault");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSManagedObject");
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
		protected NSManagedObject (NSObjectFlag t) : base (t)
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
		protected internal NSManagedObject (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="entity">To be added.</param><param name="context"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a new <see cref="T:CoreData.NSManagedObject" /> from an entity description and inserts the object into the specified managed object context.</summary><remarks>To be added.</remarks>
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSManagedObject (NSEntityDescription entity, NSManagedObjectContext? context)
			: base (NSObjectFlag.Empty)
		{
			var entity__handle__ = entity!.GetNonNullHandle (nameof (entity));
			var context__handle__ = context.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithEntity_InsertIntoManagedObjectContext_XHandle, entity__handle__, context__handle__), "initWithEntity:insertIntoManagedObjectContext:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithEntity_InsertIntoManagedObjectContext_XHandle, entity__handle__, context__handle__), "initWithEntity:insertIntoManagedObjectContext:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (entity);
			GC.KeepAlive (context);
		}
		/// <param name="moc">To be added.</param><summary>Creates a new <see cref="T:CoreData.NSManagedObject" /> in the specified managed object context.</summary><remarks>To be added.</remarks>
		[Export ("initWithContext:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSManagedObject (NSManagedObjectContext moc)
			: base (NSObjectFlag.Empty)
		{
			var moc__handle__ = moc!.GetNonNullHandle (nameof (moc));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithContext_XHandle, moc__handle__), "initWithContext:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithContext_XHandle, moc__handle__), "initWithContext:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (moc);
		}
		/// <summary>Method that is called after the receiver is fetched.</summary><remarks>To be added.</remarks>
		[Export ("awakeFromFetch")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AwakeFromFetch ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selAwakeFromFetchXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selAwakeFromFetchXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Method that is called after the managed object is inserted into a managed object context.</summary><remarks>To be added.</remarks>
		[Export ("awakeFromInsert")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AwakeFromInsert ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selAwakeFromInsertXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selAwakeFromInsertXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="flags">To be added.</param><summary>Method that is called to awaken the receiver when a property state change occurs.</summary><remarks><para>See the <see cref="T:CoreData.NSSnapshotEventType" /> enumeration for a list of the values that can be returned by this method.</para></remarks>
		[Export ("awakeFromSnapshotEvents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AwakeFromSnapshotEvents (NSSnapshotEventType flags)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selAwakeFromSnapshotEvents_XHandle, (UIntPtr) (ulong) flags);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selAwakeFromSnapshotEvents_XHandle, (UIntPtr) (ulong) flags);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Creates and returns a fetch request.</summary><returns>A fetch request.</returns><remarks>To be added.</remarks>
		[Export ("fetchRequest")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFetchRequest CreateFetchRequest ()
		{
			NSFetchRequest ret;
			ret =  Runtime.GetNSObject<NSFetchRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selFetchRequestXHandle), false)!;
			return ret;
		}
		/// <param name="key"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called when the value for the property that is identified by <paramref name="key" /> is accessed.</summary><remarks>To be added.</remarks>
		[Export ("didAccessValueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAccessValueForKey (string? key)
		{
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDidAccessValueForKey_XHandle, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDidAccessValueForKey_XHandle, nskey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
		}
		/// <param name="key">To be added.</param><summary>Method that is called when the value for the property that is identified by <paramref name="key" /> is changed.</summary><remarks>To be added.</remarks>
		[Export ("didChangeValueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeValueForKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDidChangeValueForKey_XHandle, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDidChangeValueForKey_XHandle, nskey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
		}
		/// <param name="inKey">To be added.</param><param name="inMutationKind">To be added.</param><param name="inObjects">To be added.</param><summary>Method that is called when the value for the many-to-many property that is identified by <paramref name="inKey" /> is changed.</summary><remarks>To be added.</remarks>
		[Export ("didChangeValueForKey:withSetMutation:usingObjects:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeValueForKey (string inKey, NSKeyValueSetMutationKind inMutationKind, NSSet inObjects)
		{
			if (inKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inKey));
			var inObjects__handle__ = inObjects!.GetNonNullHandle (nameof (inObjects));
			var nsinKey = CFString.CreateNative (inKey);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, selDidChangeValueForKey_WithSetMutation_UsingObjects_XHandle, nsinKey, (UIntPtr) (ulong) inMutationKind, inObjects__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selDidChangeValueForKey_WithSetMutation_UsingObjects_XHandle, nsinKey, (UIntPtr) (ulong) inMutationKind, inObjects__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inObjects);
			CFString.ReleaseNative (nsinKey);
		}
		/// <summary>Method that is called after the managed context operation saves values.</summary><remarks>To be added.</remarks>
		[Export ("didSave")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSave ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDidSaveXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDidSaveXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Method that is called when the receiver becomes a fault.</summary><remarks>To be added.</remarks>
		[Export ("didTurnIntoFault")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidTurnIntoFault ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDidTurnIntoFaultXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDidTurnIntoFaultXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="keys"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Returns a dictionary that contains property values for the specified <paramref name="keys" /> from before the last fetch or save.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("committedValuesForKeys:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GetCommittedValues (string[]? keys)
		{
			using var nsa_keys = NSArray.FromNullableStrings (keys);
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCommittedValuesForKeys_XHandle, nsa_keys.GetHandle ()), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCommittedValuesForKeys_XHandle, nsa_keys.GetHandle ()), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>Gets the entity description for the receiver.</summary><returns>The entity description for the receiver.</returns><remarks>To be added.</remarks>
		[Export ("entity")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSEntityDescription GetEntityDescription ()
		{
			NSEntityDescription ret;
			ret =  Runtime.GetNSObject<NSEntityDescription> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selEntityXHandle), false)!;
			return ret;
		}
		/// <param name="relationshipName">To be added.</param><summary>Gets the identifiers for all of the objects that are involved in the specified relationship.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("objectIDsForRelationshipNamed:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSManagedObjectID[] GetObjectIDs (string relationshipName)
		{
			if (relationshipName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (relationshipName));
			var nsrelationshipName = CFString.CreateNative (relationshipName);
			NSManagedObjectID[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSManagedObjectID>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selObjectIDsForRelationshipNamed_XHandle, nsrelationshipName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSManagedObjectID>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectIDsForRelationshipNamed_XHandle, nsrelationshipName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsrelationshipName);
			return ret!;
		}
		/// <param name="key">To be added.</param><summary>Returns the receiver's internal primitive value for the property that is specified by the provided <paramref name="key" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("primitiveValueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetPrimitiveValue (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPrimitiveValueForKey_XHandle, nskey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPrimitiveValueForKey_XHandle, nskey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		/// <param name="key">To be added.</param><summary>Returns the value for the property that is identified by the specified <paramref name="key" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("valueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetValue (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selValueForKey_XHandle, nskey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selValueForKey_XHandle, nskey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		/// <param name="key">To be added.</param><summary>Gets a Boolean value that tells whether the receiver has a fault.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("hasFaultForRelationshipNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasFaultForRelationshipNamed (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selHasFaultForRelationshipNamed_XHandle, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selHasFaultForRelationshipNamed_XHandle, nskey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			return ret != 0;
		}
		/// <summary>Method that is called prior to the object being deleted.</summary><remarks>To be added.</remarks>
		[Export ("prepareForDeletion")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareForDeletion ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPrepareForDeletionXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selPrepareForDeletionXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="value">To be added.</param><param name="key">To be added.</param><summary>Sets the receiver's internal primitive value for the property that is specified by the provided <paramref name="key" />.</summary><remarks>To be added.</remarks>
		[Export ("setPrimitiveValue:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPrimitiveValue (NSObject? value, string key)
		{
			var value__handle__ = value.GetHandle ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetPrimitiveValue_ForKey_XHandle, value__handle__, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetPrimitiveValue_ForKey_XHandle, value__handle__, nskey);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			CFString.ReleaseNative (nskey);
		}
		/// <param name="value">To be added.</param><param name="key">To be added.</param><summary>Sets the receiver's value for the property that is specified by the provided <paramref name="key" />.</summary><remarks>To be added.</remarks>
		[Export ("setValue:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetValue (NSObject? value, string key)
		{
			var value__handle__ = value.GetHandle ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetValue_ForKey_XHandle, value__handle__, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetValue_ForKey_XHandle, value__handle__, nskey);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			CFString.ReleaseNative (nskey);
		}
		/// <param name="error">To be added.</param><summary>Returns <see langword="true" /> if the receiver is valid for deletion.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("validateForDelete:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ValidateForDelete (out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, selValidateForDelete_XHandle, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selValidateForDelete_XHandle, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="error">To be added.</param><summary>Returns <see langword="true" /> if the receiver is valid for insertion.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("validateForInsert:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ValidateForInsert (out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, selValidateForInsert_XHandle, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selValidateForInsert_XHandle, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="error">To be added.</param><summary>Returns <see langword="true" /> if the receiver is valid for updating.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("validateForUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ValidateForUpdate (out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, selValidateForUpdate_XHandle, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selValidateForUpdate_XHandle, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="value">To be added.</param><param name="key">To be added.</param><param name="error">To be added.</param><summary>Returns <see langword="true" /> if the specified <paramref name="value" /> is valid for the property that is identified by the specified <paramref name="key" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("validateValue:forKey:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ValidateValue (ref NSObject value, string key, out NSError error)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var valueValue = Runtime.RetainAndAutoreleaseNativeObject (value);
			NativeHandle errorValue = IntPtr.Zero;
			var nskey = CFString.CreateNative (key);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selValidateValue_ForKey_Error_XHandle, &valueValue, nskey, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selValidateValue_ForKey_Error_XHandle, &valueValue, nskey, &errorValue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			value = Runtime.GetNSObject<NSObject> (valueValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="key"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called before the value for the property that is identified by <paramref name="key" /> is accessed.</summary><remarks>To be added.</remarks>
		[Export ("willAccessValueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAccessValueForKey (string? key)
		{
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selWillAccessValueForKey_XHandle, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selWillAccessValueForKey_XHandle, nskey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
		}
		/// <param name="key">To be added.</param><summary>Method that is called before the value for the property that is identified by <paramref name="key" /> is changed.</summary><remarks>To be added.</remarks>
		[Export ("willChangeValueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillChangeValueForKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selWillChangeValueForKey_XHandle, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selWillChangeValueForKey_XHandle, nskey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
		}
		/// <param name="inKey">To be added.</param><param name="inMutationKind">To be added.</param><param name="inObjects">To be added.</param><summary>Method that is called before the value for the many-to-many property that is identified by <paramref name="inKey" /> is changed.</summary><remarks>To be added.</remarks>
		[Export ("willChangeValueForKey:withSetMutation:usingObjects:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillChangeValueForKey (string inKey, NSKeyValueSetMutationKind inMutationKind, NSSet inObjects)
		{
			if (inKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inKey));
			var inObjects__handle__ = inObjects!.GetNonNullHandle (nameof (inObjects));
			var nsinKey = CFString.CreateNative (inKey);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, selWillChangeValueForKey_WithSetMutation_UsingObjects_XHandle, nsinKey, (UIntPtr) (ulong) inMutationKind, inObjects__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selWillChangeValueForKey_WithSetMutation_UsingObjects_XHandle, nsinKey, (UIntPtr) (ulong) inMutationKind, inObjects__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inObjects);
			CFString.ReleaseNative (nsinKey);
		}
		/// <summary>Method that is called before the receiver is saved.</summary><remarks>To be added.</remarks>
		[Export ("willSave")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillSave ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selWillSaveXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selWillSaveXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Method that is called before the receiver is turned into a fault.</summary><remarks>To be added.</remarks>
		[Export ("willTurnIntoFault")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillTurnIntoFault ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selWillTurnIntoFaultXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selWillTurnIntoFaultXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Gets a dictionary of the old values of persistent values that were recently changed since the receiver was last fetched.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary ChangedValues {
			[Export ("changedValues")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selChangedValuesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selChangedValuesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Returns a dictionary of the old values of persistent values that were recently changed since the context objects last changed.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary ChangedValuesForCurrentEvent {
			[Export ("changedValuesForCurrentEvent")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selChangedValuesForCurrentEventXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selChangedValuesForCurrentEventXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the managed object should ignore changes to unmodeled properties.</summary><value>A Boolean value that tells whether the managed object should ignore changes to unmodeled properties.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ContextShouldIgnoreUnModeledPropertyChanges {
			[Export ("contextShouldIgnoreUnmodeledPropertyChanges")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selContextShouldIgnoreUnmodeledPropertyChangesXHandle);
				return ret != 0;
			}
		}
		/// <summary>Gets the receiver's entity description.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSEntityDescription Entity {
			[Export ("entity", ArgumentSemantic.Retain)]
			get {
				NSEntityDescription? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSEntityDescription> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selEntityXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSEntityDescription> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selEntityXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the receiver's faulting state.</summary><value>The receiver's faulting state.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint FaultingState {
			[Export ("faultingState")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selFaultingStateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selFaultingStateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the receiver has changes due to having been inserted or deleted, or due to having other unsaved changes.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasChanges {
			[Export ("hasChanges")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasChangesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasChangesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the receiver has unsaved changes to persistent values.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool HasPersistentChangedValues {
			[Export ("hasPersistentChangedValues")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasPersistentChangedValuesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasPersistentChangedValuesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the receiver will be deleted in the next save.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsDeleted {
			[Export ("isDeleted")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDeletedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsDeletedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the receiver has been converted to a fault.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsFault {
			[Export ("isFault")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFaultXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsFaultXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the receiver was inserted into a managed object context.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsInserted {
			[Export ("isInserted")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsInsertedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsInsertedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the receiver has changes that are not yet saved.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsUpdated {
			[Export ("isUpdated")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsUpdatedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsUpdatedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets the managed object context where this managed object is registered.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSManagedObjectContext? ManagedObjectContext {
			[Export ("managedObjectContext")]
			get {
				NSManagedObjectContext? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSManagedObjectContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selManagedObjectContextXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSManagedObjectContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selManagedObjectContextXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the object identifier.</summary><value>To be added.</value><remarks>This value changes when an unsaved object is saved.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSManagedObjectID ObjectID {
			[Export ("objectID", ArgumentSemantic.Retain)]
			get {
				NSManagedObjectID? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSManagedObjectID> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selObjectIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSManagedObjectID> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selObjectIDXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the KVO information for the object.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual nint ObservationInfo {
			[Export ("observationInfo")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selObservationInfoXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selObservationInfoXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setObservationInfo:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetObservationInfo_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetObservationInfo_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class NSManagedObject */
}
