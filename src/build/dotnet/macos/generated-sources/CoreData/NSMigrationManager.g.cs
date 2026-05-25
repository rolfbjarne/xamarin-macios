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
	/// <summary>Allows migration from one persistent store to another.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/NSMigrationManager_class/index.html">Apple documentation for <c>NSMigrationManager</c></related>
	[Register("NSMigrationManager", true)]
	public unsafe partial class NSMigrationManager : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssociateSourceInstance_WithDestinationInstance_ForEntityMapping_X = "associateSourceInstance:withDestinationInstance:forEntityMapping:";
		static readonly NativeHandle selAssociateSourceInstance_WithDestinationInstance_ForEntityMapping_XHandle = Selector.GetHandle ("associateSourceInstance:withDestinationInstance:forEntityMapping:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelMigrationWithError_X = "cancelMigrationWithError:";
		static readonly NativeHandle selCancelMigrationWithError_XHandle = Selector.GetHandle ("cancelMigrationWithError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentEntityMappingX = "currentEntityMapping";
		static readonly NativeHandle selCurrentEntityMappingXHandle = Selector.GetHandle ("currentEntityMapping");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationContextX = "destinationContext";
		static readonly NativeHandle selDestinationContextXHandle = Selector.GetHandle ("destinationContext");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationEntityForEntityMapping_X = "destinationEntityForEntityMapping:";
		static readonly NativeHandle selDestinationEntityForEntityMapping_XHandle = Selector.GetHandle ("destinationEntityForEntityMapping:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationInstancesForEntityMappingNamed_SourceInstances_X = "destinationInstancesForEntityMappingNamed:sourceInstances:";
		static readonly NativeHandle selDestinationInstancesForEntityMappingNamed_SourceInstances_XHandle = Selector.GetHandle ("destinationInstancesForEntityMappingNamed:sourceInstances:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationModelX = "destinationModel";
		static readonly NativeHandle selDestinationModelXHandle = Selector.GetHandle ("destinationModel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithSourceModel_DestinationModel_X = "initWithSourceModel:destinationModel:";
		static readonly NativeHandle selInitWithSourceModel_DestinationModel_XHandle = Selector.GetHandle ("initWithSourceModel:destinationModel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMappingModelX = "mappingModel";
		static readonly NativeHandle selMappingModelXHandle = Selector.GetHandle ("mappingModel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMigrateStoreFromURL_Type_Options_WithMappingModel_ToDestinationURL_DestinationType_DestinationOptions_Error_X = "migrateStoreFromURL:type:options:withMappingModel:toDestinationURL:destinationType:destinationOptions:error:";
		static readonly NativeHandle selMigrateStoreFromURL_Type_Options_WithMappingModel_ToDestinationURL_DestinationType_DestinationOptions_Error_XHandle = Selector.GetHandle ("migrateStoreFromURL:type:options:withMappingModel:toDestinationURL:destinationType:destinationOptions:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMigrationProgressX = "migrationProgress";
		static readonly NativeHandle selMigrationProgressXHandle = Selector.GetHandle ("migrationProgress");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResetX = "reset";
		static readonly NativeHandle selResetXHandle = Selector.GetHandle ("reset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUserInfo_X = "setUserInfo:";
		static readonly NativeHandle selSetUserInfo_XHandle = Selector.GetHandle ("setUserInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesStoreSpecificMigrationManager_X = "setUsesStoreSpecificMigrationManager:";
		static readonly NativeHandle selSetUsesStoreSpecificMigrationManager_XHandle = Selector.GetHandle ("setUsesStoreSpecificMigrationManager:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceContextX = "sourceContext";
		static readonly NativeHandle selSourceContextXHandle = Selector.GetHandle ("sourceContext");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceEntityForEntityMapping_X = "sourceEntityForEntityMapping:";
		static readonly NativeHandle selSourceEntityForEntityMapping_XHandle = Selector.GetHandle ("sourceEntityForEntityMapping:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceInstancesForEntityMappingNamed_DestinationInstances_X = "sourceInstancesForEntityMappingNamed:destinationInstances:";
		static readonly NativeHandle selSourceInstancesForEntityMappingNamed_DestinationInstances_XHandle = Selector.GetHandle ("sourceInstancesForEntityMappingNamed:destinationInstances:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceModelX = "sourceModel";
		static readonly NativeHandle selSourceModelXHandle = Selector.GetHandle ("sourceModel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserInfoX = "userInfo";
		static readonly NativeHandle selUserInfoXHandle = Selector.GetHandle ("userInfo");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesStoreSpecificMigrationManagerX = "usesStoreSpecificMigrationManager";
		static readonly NativeHandle selUsesStoreSpecificMigrationManagerXHandle = Selector.GetHandle ("usesStoreSpecificMigrationManager");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSMigrationManager");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSMigrationManager" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSMigrationManager () : base (NSObjectFlag.Empty)
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
		protected NSMigrationManager (NSObjectFlag t) : base (t)
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
		protected internal NSMigrationManager (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="sourceModel">To be added.</param><param name="destinationModel">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithSourceModel:destinationModel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSMigrationManager (NSManagedObjectModel sourceModel, NSManagedObjectModel destinationModel)
			: base (NSObjectFlag.Empty)
		{
			var sourceModel__handle__ = sourceModel!.GetNonNullHandle (nameof (sourceModel));
			var destinationModel__handle__ = destinationModel!.GetNonNullHandle (nameof (destinationModel));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithSourceModel_DestinationModel_XHandle, sourceModel__handle__, destinationModel__handle__), "initWithSourceModel:destinationModel:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithSourceModel_DestinationModel_XHandle, sourceModel__handle__, destinationModel__handle__), "initWithSourceModel:destinationModel:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceModel);
			GC.KeepAlive (destinationModel);
		}
		/// <param name="sourceInstance">To be added.</param><param name="destinationInstance">To be added.</param><param name="entityMapping">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("associateSourceInstance:withDestinationInstance:forEntityMapping:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AssociateSourceInstance (NSManagedObject sourceInstance, NSManagedObject destinationInstance, NSEntityMapping entityMapping)
		{
			var sourceInstance__handle__ = sourceInstance!.GetNonNullHandle (nameof (sourceInstance));
			var destinationInstance__handle__ = destinationInstance!.GetNonNullHandle (nameof (destinationInstance));
			var entityMapping__handle__ = entityMapping!.GetNonNullHandle (nameof (entityMapping));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selAssociateSourceInstance_WithDestinationInstance_ForEntityMapping_XHandle, sourceInstance__handle__, destinationInstance__handle__, entityMapping__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selAssociateSourceInstance_WithDestinationInstance_ForEntityMapping_XHandle, sourceInstance__handle__, destinationInstance__handle__, entityMapping__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceInstance);
			GC.KeepAlive (destinationInstance);
			GC.KeepAlive (entityMapping);
		}
		/// <param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("cancelMigrationWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelMigrationWithError (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCancelMigrationWithError_XHandle, error__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCancelMigrationWithError_XHandle, error__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (error);
		}
		/// <param name="mEntity">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("destinationEntityForEntityMapping:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSEntityDescription? DestinationEntityForEntityMapping (NSEntityMapping mEntity)
		{
			var mEntity__handle__ = mEntity!.GetNonNullHandle (nameof (mEntity));
			NSEntityDescription? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSEntityDescription> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDestinationEntityForEntityMapping_XHandle, mEntity__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSEntityDescription> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDestinationEntityForEntityMapping_XHandle, mEntity__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mEntity);
			return ret!;
		}
		/// <param name="mappingName">To be added.</param><param name="sourceInstances"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("destinationInstancesForEntityMappingNamed:sourceInstances:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSManagedObject[] DestinationInstancesForEntityMappingNamed (string mappingName, NSManagedObject[]? sourceInstances)
		{
			if (mappingName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mappingName));
			var nsmappingName = CFString.CreateNative (mappingName);
			using var nsa_sourceInstances = sourceInstances is null ? null : NSArray.FromNSObjects (sourceInstances);
			NSManagedObject[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSManagedObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDestinationInstancesForEntityMappingNamed_SourceInstances_XHandle, nsmappingName, nsa_sourceInstances.GetHandle ()), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSManagedObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDestinationInstancesForEntityMappingNamed_SourceInstances_XHandle, nsmappingName, nsa_sourceInstances.GetHandle ()), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsmappingName);
			return ret!;
		}
		/// <param name="sourceUrl">To be added.</param><param name="sStoreType">To be added.</param><param name="sOptions"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="mappings"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="dUrl">To be added.</param><param name="dStoreType">To be added.</param><param name="dOptions"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("migrateStoreFromURL:type:options:withMappingModel:toDestinationURL:destinationType:destinationOptions:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool MigrateStoreFromUrl (NSUrl sourceUrl, string sStoreType, NSDictionary? sOptions, NSMappingModel? mappings, NSUrl dUrl, string dStoreType, NSDictionary? dOptions, out NSError error)
		{
			var sourceUrl__handle__ = sourceUrl!.GetNonNullHandle (nameof (sourceUrl));
			if (sStoreType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sStoreType));
			var sOptions__handle__ = sOptions.GetHandle ();
			var mappings__handle__ = mappings.GetHandle ();
			var dUrl__handle__ = dUrl!.GetNonNullHandle (nameof (dUrl));
			if (dStoreType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dStoreType));
			var dOptions__handle__ = dOptions.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			var nssStoreType = CFString.CreateNative (sStoreType);
			var nsdStoreType = CFString.CreateNative (dStoreType);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selMigrateStoreFromURL_Type_Options_WithMappingModel_ToDestinationURL_DestinationType_DestinationOptions_Error_XHandle, sourceUrl__handle__, nssStoreType, sOptions__handle__, mappings__handle__, dUrl__handle__, nsdStoreType, dOptions__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selMigrateStoreFromURL_Type_Options_WithMappingModel_ToDestinationURL_DestinationType_DestinationOptions_Error_XHandle, sourceUrl__handle__, nssStoreType, sOptions__handle__, mappings__handle__, dUrl__handle__, nsdStoreType, dOptions__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceUrl);
			GC.KeepAlive (sOptions);
			GC.KeepAlive (mappings);
			GC.KeepAlive (dUrl);
			GC.KeepAlive (dOptions);
			CFString.ReleaseNative (nssStoreType);
			CFString.ReleaseNative (nsdStoreType);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("reset")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Reset ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selResetXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selResetXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="mEntity">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("sourceEntityForEntityMapping:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSEntityDescription? SourceEntityForEntityMapping (NSEntityMapping mEntity)
		{
			var mEntity__handle__ = mEntity!.GetNonNullHandle (nameof (mEntity));
			NSEntityDescription? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSEntityDescription> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selSourceEntityForEntityMapping_XHandle, mEntity__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSEntityDescription> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selSourceEntityForEntityMapping_XHandle, mEntity__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mEntity);
			return ret!;
		}
		/// <param name="mappingName">To be added.</param><param name="destinationInstances"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("sourceInstancesForEntityMappingNamed:destinationInstances:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSManagedObject[] SourceInstancesForEntityMappingNamed (string mappingName, NSManagedObject[]? destinationInstances)
		{
			if (mappingName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mappingName));
			var nsmappingName = CFString.CreateNative (mappingName);
			using var nsa_destinationInstances = destinationInstances is null ? null : NSArray.FromNSObjects (destinationInstances);
			NSManagedObject[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSManagedObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSourceInstancesForEntityMappingNamed_DestinationInstances_XHandle, nsmappingName, nsa_destinationInstances.GetHandle ()), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSManagedObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSourceInstancesForEntityMappingNamed_DestinationInstances_XHandle, nsmappingName, nsa_destinationInstances.GetHandle ()), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsmappingName);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSEntityMapping CurrentEntityMapping {
			[Export ("currentEntityMapping", ArgumentSemantic.Retain)]
			get {
				NSEntityMapping? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSEntityMapping> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentEntityMappingXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSEntityMapping> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentEntityMappingXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSManagedObjectContext DestinationContext {
			[Export ("destinationContext", ArgumentSemantic.Retain)]
			get {
				NSManagedObjectContext? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSManagedObjectContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDestinationContextXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSManagedObjectContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDestinationContextXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSManagedObjectModel DestinationModel {
			[Export ("destinationModel", ArgumentSemantic.Retain)]
			get {
				NSManagedObjectModel? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSManagedObjectModel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDestinationModelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSManagedObjectModel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDestinationModelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMappingModel MappingModel {
			[Export ("mappingModel", ArgumentSemantic.Retain)]
			get {
				NSMappingModel? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMappingModel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMappingModelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSMappingModel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMappingModelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float MigrationProgress {
			[Export ("migrationProgress")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMigrationProgressXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selMigrationProgressXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSManagedObjectContext SourceContext {
			[Export ("sourceContext", ArgumentSemantic.Retain)]
			get {
				NSManagedObjectContext? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSManagedObjectContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSourceContextXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSManagedObjectContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSourceContextXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSManagedObjectModel SourceModel {
			[Export ("sourceModel", ArgumentSemantic.Retain)]
			get {
				NSManagedObjectModel? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSManagedObjectModel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSourceModelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSManagedObjectModel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSourceModelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? UserInfo {
			[Export ("userInfo", ArgumentSemantic.Retain)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUserInfoXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUserInfoXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setUserInfo:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetUserInfo_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetUserInfo_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesStoreSpecificMigrationManager {
			[Export ("usesStoreSpecificMigrationManager")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesStoreSpecificMigrationManagerXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesStoreSpecificMigrationManagerXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesStoreSpecificMigrationManager:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesStoreSpecificMigrationManager_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesStoreSpecificMigrationManager_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class NSMigrationManager */
}
