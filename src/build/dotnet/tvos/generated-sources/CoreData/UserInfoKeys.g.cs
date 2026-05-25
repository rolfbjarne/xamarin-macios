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
	/// <summary>Contains keys for error information that Core Data stores in a dictionary.</summary><remarks>To be added.</remarks>
	public unsafe static partial class UserInfoKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AffectedStoresForErrorKey;
		/// <summary>Gets the key that identifies an array that contains the stores that were affected by the error.</summary><value>A key that identifies an array of <see cref="T:CoreData.NSPersistentStore" /> objects that were affected by the error.</value><remarks><para>This key corresponds to the <see cref="P:CoreData.UserInfo.AffectedStoresForError" /> property.</para></remarks>
		[Field ("NSAffectedStoresErrorKey",  "CoreData")]
		public static NSString AffectedStoresForErrorKey {
			get {
				if (_AffectedStoresForErrorKey is null)
					_AffectedStoresForErrorKey = Dlfcn.GetStringConstant (Libraries.CoreData.Handle, "NSAffectedStoresErrorKey")!;
				return _AffectedStoresForErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DeferredLightweightMigrationOptionKey;
		/// <summary>Represents the value associated with the constant 'NSPersistentStoreDeferredLightweightMigrationOptionKey'.</summary>
		[Field ("NSPersistentStoreDeferredLightweightMigrationOptionKey",  "CoreData")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos")]
		public static NSString DeferredLightweightMigrationOptionKey {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DeferredLightweightMigrationOptionKey is null)
					_DeferredLightweightMigrationOptionKey = Dlfcn.GetStringConstant (Libraries.CoreData.Handle, "NSPersistentStoreDeferredLightweightMigrationOptionKey")!;
				return _DeferredLightweightMigrationOptionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DetailedErrorsKey;
		/// <summary>To be added.</summary><value>A key that identifies an array of <see cref="T:Foundation.NSError" /> objects that contains the errors that occurred.</value><remarks><para>This key corresponds to the <see cref="P:CoreData.UserInfo.DetailedErrors" /> property.</para></remarks>
		[Field ("NSDetailedErrorsKey",  "CoreData")]
		public static NSString DetailedErrorsKey {
			get {
				if (_DetailedErrorsKey is null)
					_DetailedErrorsKey = Dlfcn.GetStringConstant (Libraries.CoreData.Handle, "NSDetailedErrorsKey")!;
				return _DetailedErrorsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeyForValidationErrorKey;
		/// <summary>Gets the key that identifies the key that, in turn, identifies the validation error that occurred.</summary><value>The key that identifies the key that, in turn, identifies the validation error that occurred.</value><remarks><para>This key corresponds to the <see cref="P:CoreData.UserInfo.KeyForValidationError" /> property.</para></remarks>
		[Field ("NSValidationKeyErrorKey",  "CoreData")]
		public static NSString KeyForValidationErrorKey {
			get {
				if (_KeyForValidationErrorKey is null)
					_KeyForValidationErrorKey = Dlfcn.GetStringConstant (Libraries.CoreData.Handle, "NSValidationKeyErrorKey")!;
				return _KeyForValidationErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ModelVersionChecksumKey;
		/// <summary>Represents the value associated with the constant 'NSPersistentStoreModelVersionChecksumKey'.</summary>
		[Field ("NSPersistentStoreModelVersionChecksumKey",  "CoreData")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString ModelVersionChecksumKey {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_ModelVersionChecksumKey is null)
					_ModelVersionChecksumKey = Dlfcn.GetStringConstant (Libraries.CoreData.Handle, "NSPersistentStoreModelVersionChecksumKey")!;
				return _ModelVersionChecksumKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ObjectForValidationErrorKey;
		/// <summary>Gets the key that identifies the object that failed validation.</summary><value>The key that identifies the object that failed validation.</value><remarks><para>This key corresponds to the <see cref="P:CoreData.UserInfo.ObjectForValidationError" /> property.</para></remarks>
		[Field ("NSValidationObjectErrorKey",  "CoreData")]
		public static NSString ObjectForValidationErrorKey {
			get {
				if (_ObjectForValidationErrorKey is null)
					_ObjectForValidationErrorKey = Dlfcn.GetStringConstant (Libraries.CoreData.Handle, "NSValidationObjectErrorKey")!;
				return _ObjectForValidationErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PersistentStoreSaveConflictsKey;
		/// <summary>Gets the key that identifies the array of merge conflicts..</summary><value>A key that identifies an array of <see cref="T:CoreData.NSMergeConflict" /> objects.</value><remarks><para>This key corresponds to the <see cref="P:CoreData.UserInfoKeys.PersistentStoreSaveConflictsKey" /> property.</para></remarks>
		[Field ("NSPersistentStoreSaveConflictsErrorKey",  "CoreData")]
		public static NSString PersistentStoreSaveConflictsKey {
			get {
				if (_PersistentStoreSaveConflictsKey is null)
					_PersistentStoreSaveConflictsKey = Dlfcn.GetStringConstant (Libraries.CoreData.Handle, "NSPersistentStoreSaveConflictsErrorKey")!;
				return _PersistentStoreSaveConflictsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PredicateForValidationErrorKey;
		/// <summary>Gets the key that identifies the predicate that failed validation..</summary><value>The key that identifies the <see cref="T:Foundation.NSPredicate" /> object for the predicate that failed..</value><remarks><para>This key corresponds to the <see cref="P:CoreData.UserInfo.PredicateForValidationError" /> property.</para></remarks>
		[Field ("NSValidationPredicateErrorKey",  "CoreData")]
		public static NSString PredicateForValidationErrorKey {
			get {
				if (_PredicateForValidationErrorKey is null)
					_PredicateForValidationErrorKey = Dlfcn.GetStringConstant (Libraries.CoreData.Handle, "NSValidationPredicateErrorKey")!;
				return _PredicateForValidationErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StagedMigrationManagerOptionKey;
		/// <summary>Represents the value associated with the constant 'NSPersistentStoreStagedMigrationManagerOptionKey'.</summary>
		[Field ("NSPersistentStoreStagedMigrationManagerOptionKey",  "CoreData")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString StagedMigrationManagerOptionKey {
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_StagedMigrationManagerOptionKey is null)
					_StagedMigrationManagerOptionKey = Dlfcn.GetStringConstant (Libraries.CoreData.Handle, "NSPersistentStoreStagedMigrationManagerOptionKey")!;
				return _StagedMigrationManagerOptionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ValueForValidationErrorKey;
		/// <summary>Gets the key that identifies the value that failed validation.</summary><value>The key that identifies the value that failed validation.</value><remarks><para>This key corresponds to the <see cref="P:CoreData.UserInfo.ValueForValidationError" /> property.</para></remarks>
		[Field ("NSValidationValueErrorKey",  "CoreData")]
		public static NSString ValueForValidationErrorKey {
			get {
				if (_ValueForValidationErrorKey is null)
					_ValueForValidationErrorKey = Dlfcn.GetStringConstant (Libraries.CoreData.Handle, "NSValidationValueErrorKey")!;
				return _ValueForValidationErrorKey;
			}
		}
	} /* class UserInfoKeys */
}
