// This file describes the API that the generator will produce
//
// Authors:
//   MonoMac community
//   Miguel de Icaza
//
// Copyright 2009, 2011, MonoMac community
// Copyright 2011, 2015 Xamarin Inc.
//
using CloudKit;
#if MONOMAC
using AppKit;
#endif
using CoreSpotlight;

namespace CoreData {
	/// <summary>Contains Core Data error information.</summary>
	[StrongDictionary ("UserInfoKeys")]
	interface UserInfo {
		/// <summary>Gets or sets an array that contains the multiple errors that occurred, if multiple errors occurred.</summary>
		///         <value>An array of <see cref="Foundation.NSError" /> objects that contains the errors that occurred.</value>
		NSError [] DetailedErrors { get; set; }
		/// <summary>Gets or sets the object that failed validation.</summary>
		///         <value>The object that failed validation.</value>
		NSManagedObject ObjectForValidationError { get; set; }
		/// <summary>Gets or sets the key that identifies the validation error that occurred.</summary>
		///         <value>The key that identifies the validation error that occurred.</value>
		NSString KeyForValidationError { get; set; }
		/// <summary>Gets or sets the predicate that failed validation.</summary>
		///         <value>The <see cref="Foundation.NSPredicate" /> object for the predicate that failed.</value>
		NSPredicate PredicateForValidationError { get; set; }
		/// <summary>Gets or sets the value that failed validation.</summary>
		///         <value>The value that failed validation.</value>
		NSValue ValueForValidationError { get; set; }
		/// <summary>Gets or sets the array of merge conflicts.</summary>
		///         <value>An array of <see cref="CoreData.NSMergeConflict" /> objects.</value>
		NSMergeConflict [] PersistentStoreSaveConflicts { get; set; }
		/// <summary>Gets or sets an array that contains the stores that were affected by the error.</summary>
		///         <value>An array that contains the stores that were affected by the error.</value>
		NSPersistentStore [] AffectedStoresForError { get; set; }
	}

	/// <summary>Contains keys for error information that Core Data stores in a dictionary.</summary>
	[Static]
	interface UserInfoKeys {
		/// <summary>Gets the DetailedErrorsKey key constant.</summary>
		///         <value>A key that identifies an array of <see cref="Foundation.NSError" /> objects that contains the errors that occurred.</value>
		///         <remarks>
		///           <para>This key corresponds to the <see cref="CoreData.UserInfo.DetailedErrors" /> property.</para>
		///         </remarks>
		[Field ("NSDetailedErrorsKey")]
		NSString DetailedErrorsKey { get; }

		/// <summary>Gets the key that identifies the object that failed validation.</summary>
		///         <value>The key that identifies the object that failed validation.</value>
		///         <remarks>
		///           <para>This key corresponds to the <see cref="CoreData.UserInfo.ObjectForValidationError" /> property.</para>
		///         </remarks>
		[Field ("NSValidationObjectErrorKey")]
		NSString ObjectForValidationErrorKey { get; }

		/// <summary>Gets the key that identifies the key that, in turn, identifies the validation error that occurred.</summary>
		///         <value>The key that identifies the key that, in turn, identifies the validation error that occurred.</value>
		///         <remarks>
		///           <para>This key corresponds to the <see cref="CoreData.UserInfo.KeyForValidationError" /> property.</para>
		///         </remarks>
		[Field ("NSValidationKeyErrorKey")]
		NSString KeyForValidationErrorKey { get; }

		/// <summary>Gets the key that identifies the predicate that failed validation..</summary>
		///         <value>The key that identifies the <see cref="Foundation.NSPredicate" /> object for the predicate that failed..</value>
		///         <remarks>
		///           <para>This key corresponds to the <see cref="CoreData.UserInfo.PredicateForValidationError" /> property.</para>
		///         </remarks>
		[Field ("NSValidationPredicateErrorKey")]
		NSString PredicateForValidationErrorKey { get; }

		/// <summary>Gets the key that identifies the value that failed validation.</summary>
		///         <value>The key that identifies the value that failed validation.</value>
		///         <remarks>
		///           <para>This key corresponds to the <see cref="CoreData.UserInfo.ValueForValidationError" /> property.</para>
		///         </remarks>
		[Field ("NSValidationValueErrorKey")]
		NSString ValueForValidationErrorKey { get; }

		/// <summary>Gets the key that identifies the array of merge conflicts..</summary>
		///         <value>A key that identifies an array of <see cref="CoreData.NSMergeConflict" /> objects.</value>
		///         <remarks>
		///           <para>This key corresponds to the <see cref="CoreData.UserInfoKeys.PersistentStoreSaveConflictsKey" /> property.</para>
		///         </remarks>
		[Field ("NSPersistentStoreSaveConflictsErrorKey")]
		NSString PersistentStoreSaveConflictsKey { get; }

		/// <summary>Gets the key that identifies an array that contains the stores that were affected by the error.</summary>
		///         <value>A key that identifies an array of <see cref="CoreData.NSPersistentStore" /> objects that were affected by the error.</value>
		///         <remarks>
		///           <para>This key corresponds to the <see cref="CoreData.UserInfo.AffectedStoresForError" /> property.</para>
		///         </remarks>
		[Field ("NSAffectedStoresErrorKey")]
		NSString AffectedStoresForErrorKey { get; }

		[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
		[Field ("NSPersistentStoreStagedMigrationManagerOptionKey")]
		NSString StagedMigrationManagerOptionKey { get; }

		[TV (14, 0), iOS (14, 0), MacCatalyst (17, 0)]
		[Field ("NSPersistentStoreDeferredLightweightMigrationOptionKey")]
		NSString DeferredLightweightMigrationOptionKey { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("NSPersistentStoreModelVersionChecksumKey")]
		NSString ModelVersionChecksumKey { get; }
	}

	/// <summary>Enumerates valid keys for the user information dictionary used in <see cref="CoreData.NSPersistentStoreCoordinator.StoresWillChangeNotification" /> and <see cref="CoreData.NSPersistentStoreCoordinator.StoresDidChangeNotification" />.</summary>
	[NoTV]
	[Native] // NUInteger -> NSPersistentStoreCoordinator.h
	[Deprecated (PlatformName.iOS, 10, 0, message: "Please see the release notes and Core Data documentation.")]
	[Deprecated (PlatformName.MacOSX, 10, 12, message: "Please see the release notes and Core Data documentation.")]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Please see the release notes and Core Data documentation.")]
	public enum NSPersistentStoreUbiquitousTransitionType : ulong {
		/// <summary>An iCloud account was added.</summary>
		AccountAdded = 1,
		/// <summary>An iCloud account was removed.</summary>
		AccountRemoved,
		/// <summary>The iCloud content was removed.</summary>
		ContentRemoved,
		/// <summary>The initial import from iCloud completed.</summary>
		InitialImportCompleted,
	}

	/// <summary>Enumerates reasons that a managed object may need to reinitialize certain values when it awakes.</summary>
	/// <remarks>
	///       <para>The values in this enumeration are returned by the <see cref="CoreData.NSManagedObject.AwakeFromSnapshotEvents(CoreData.NSSnapshotEventType)" /> method.</para>
	///     </remarks>
	[Native]
	public enum NSSnapshotEventType : ulong {
		/// <summary>Indicates that an insertion was undone.</summary>
		UndoInsertion = 1 << 1,
		/// <summary>Indicates that a deletion was undone.</summary>
		UndoDeletion = 1 << 2,
		/// <summary>Indicates that an update was undone.</summary>
		UndoUpdate = 1 << 3,
		/// <summary>Indicates that a rollback occurred.</summary>
		Rollback = 1 << 4,
		/// <summary>Indicates that a managed object was refreshed.</summary>
		Refresh = 1 << 5,
		/// <summary>Indicates that a conflict was resolved while saving.</summary>
		MergePolicy = 1 << 6,
	}

	/// <summary>A base class for 'atomic stores,' which can be used to store custom file formats in Core Data.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/NSAtomicStore_class/index.html">Apple documentation for <c>NSAtomicStore</c></related>
	[BaseType (typeof (NSPersistentStore))]
	// Objective-C exception thrown.  Name: NSInternalInconsistencyException Reason: NSMappedObjectStore must be initialized with initWithPersistentStoreCoordinator:configurationName:URL:options
	[DisableDefaultCtor]
	interface NSAtomicStore {

		/// <param name="coordinator">The persistent store coordinator.</param>
		/// <param name="configurationName">The configuration name.</param>
		/// <param name="url">The URL.</param>
		/// <param name="options">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithPersistentStoreCoordinator:configurationName:URL:options:")]
		NativeHandle Constructor ([NullAllowed] NSPersistentStoreCoordinator coordinator, [NullAllowed] string configurationName, NSUrl url, [NullAllowed] NSDictionary options);

		/// <param name="error">The error, or null if none.</param>
		///         <summary>Performs the load operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("load:")]
		bool Load (out NSError error);

		/// <param name="error">The error, or null if none.</param>
		///         <summary>Performs the save operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("save:")]
		bool Save (out NSError error);

		/// <param name="managedObject">The managed object.</param>
		///         <summary>Performs the new cache node for managed object operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("newCacheNodeForManagedObject:")]
		NSAtomicStoreCacheNode NewCacheNodeForManagedObject (NSManagedObject managedObject);

		/// <param name="node">The cache node.</param>
		///         <param name="managedObject">The managed object.</param>
		///         <summary>Performs the update cache node operation.</summary>
		[Export ("updateCacheNode:fromManagedObject:")]
		void UpdateCacheNode (NSAtomicStoreCacheNode node, NSManagedObject managedObject);

		/// <summary>Performs the Core Data operation.</summary>
		[Export ("cacheNodes")]
#if XAMCORE_5_0
		NSSet<NSAtomicStoreCacheNode> CacheNodes { get; }
#else
		NSSet CacheNodes { get; }
#endif

		/// <param name="cacheNodes">The array of cache nodes.</param>
		///         <summary>Performs the Core Data operation.</summary>
		[Export ("addCacheNodes:")]

#if XAMCORE_5_0
		void AddCacheNodes (NSSet<NSAtomicStoreCacheNode> cacheNodes);
#else
		void AddCacheNodes (NSSet cacheNodes);
#endif

		/// <param name="cacheNodes">The array of cache nodes.</param>
		///         <summary>Performs the Core Data operation.</summary>
		[Export ("willRemoveCacheNodes:")]
#if XAMCORE_5_0
		void WillRemoveCacheNodes (NSSet<NSAtomicStoreCacheNode> cacheNodes);
#else
		void WillRemoveCacheNodes (NSSet cacheNodes);
#endif

		/// <param name="objectID">The managed object identifier.</param>
		///         <summary>Performs the cache node for object i d operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("cacheNodeForObjectID:")]
		[return: NullAllowed]
		NSAtomicStoreCacheNode CacheNodeForObjectID (NSManagedObjectID objectID);

		/// <param name="entity">The entity description.</param>
		///         <param name="data">The data.</param>
		///         <summary>Performs the object i d for entity operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("objectIDForEntity:referenceObject:")]
		NSManagedObjectID ObjectIDForEntity (NSEntityDescription entity, NSObject data);

		/// <param name="managedObject">The managed object.</param>
		///         <summary>Performs the new reference object for managed object operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("newReferenceObjectForManagedObject:")]
		NSAtomicStore NewReferenceObjectForManagedObject (NSManagedObject managedObject);

		/// <param name="objectID">The managed object identifier.</param>
		///         <summary>Performs the reference object for object i d operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("referenceObjectForObjectID:")]
		NSAtomicStore ReferenceObjectForObjectID (NSManagedObjectID objectID);
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NSFetchIndexElementDescription : NSCoding, NSCopying {
		/// <param name="property">The property description.</param>
		/// <param name="collationType">The collation type.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithProperty:collationType:")]
		NativeHandle Constructor (NSPropertyDescription property, NSFetchIndexElementType collationType);

		/// <summary>Gets the Property value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("property", ArgumentSemantic.Retain)]
		NSPropertyDescription Property { get; }

		/// <summary>Gets the PropertyName value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("propertyName", ArgumentSemantic.Retain)]
		string PropertyName { get; }

		/// <summary>Gets or sets the CollationType value.</summary>
		[Export ("collationType", ArgumentSemantic.Assign)]
		NSFetchIndexElementType CollationType { get; set; }

		/// <summary>Gets or sets the IsAscending value.</summary>
		[Export ("ascending")]
		bool IsAscending { [Bind ("isAscending")] get; set; }

		/// <summary>Gets the IndexDescription value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("indexDescription", ArgumentSemantic.Assign)]
		NSFetchIndexDescription IndexDescription { get; }
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NSFetchIndexDescription : NSCoding, NSCopying {
		/// <param name="name">The name.</param>
		/// <param name="elements">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithName:elements:")]
		NativeHandle Constructor (string name, [NullAllowed] NSFetchIndexElementDescription [] elements);

		/// <summary>Gets or sets the Name value.</summary>
		[Export ("name")]
		string Name { get; set; }

		/// <summary>Gets or sets the Elements value.</summary>
		[Export ("elements", ArgumentSemantic.Copy)]
		NSFetchIndexElementDescription [] Elements { get; set; }

		/// <summary>Gets the Entity value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("entity", ArgumentSemantic.Assign)]
		NSEntityDescription Entity { get; }

		/// <summary>Gets or sets the PartialIndexPredicate value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("partialIndexPredicate", ArgumentSemantic.Copy)]
		NSPredicate PartialIndexPredicate { get; set; }
	}

	/// <summary>Represents a single record in a Core Data atomic store.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/NSAtomicStoreCacheNode_class/index.html">Apple documentation for <c>NSAtomicStoreCacheNode</c></related>
	[BaseType (typeof (NSObject))]
	// Objective-C exception thrown.  Name: NSInvalidArgumentException Reason: NSAtomicStoreCacheNodes must be initialized using initWithObjectID:(NSManagedObjectID *)
	[DisableDefaultCtor]
	interface NSAtomicStoreCacheNode {

		/// <param name="moid">The managed object identifier.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithObjectID:")]
		NativeHandle Constructor (NSManagedObjectID moid);

		/// <summary>Gets the ObjectID value.</summary>
		[Export ("objectID", ArgumentSemantic.Strong)]
		NSManagedObjectID ObjectID { get; }

		/// <summary>Performs the Core Data operation.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("propertyCache", ArgumentSemantic.Retain)]
#if XAMCORE_5_0
		NSMutableDictionary<NSString, NSObject> PropertyCache { get; set; }
#else
		NSDictionary PropertyCache { get; set; }
#endif

		/// <param name="key">The key.</param>
		///         <summary>Performs the value for key operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("valueForKey:")]
		[return: NullAllowed]
		NSAtomicStoreCacheNode ValueForKey (string key);

		/// <param name="value">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="key">The key.</param>
		///         <summary>Performs the set value operation.</summary>
		[Export ("setValue:forKey:")]
		void SetValue ([NullAllowed] NSObject value, string key);

	}
	/// <summary>Describes an attribute of an <see cref="CoreData.NSEntityDescription" /> object.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/CoreDataFramework/Classes/NSAttributeDescription_Class/index.html">Apple documentation for <c>NSAttributeDescription</c></related>
	[BaseType (typeof (NSPropertyDescription))]
	interface NSAttributeDescription {

		/// <summary>Gets or sets the AttributeType value.</summary>
		[Export ("attributeType")]
		NSAttributeType AttributeType { get; set; }

		// Default property value is null but it cannot be set to that value
		// NSInternalInconsistencyException Reason: Can't set attributeValueClassName to nil for a non-transient attribute.
		/// <summary>Gets or sets the AttributeValueClassName value.</summary>
		[Export ("attributeValueClassName")]
		[NullAllowed]
		string AttributeValueClassName { get; set; }

		/// <summary>Gets or sets the DefaultValue value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("defaultValue", ArgumentSemantic.Retain)]
		NSObject DefaultValue { get; set; }

		/// <summary>Gets the VersionHash value.</summary>
		[Export ("versionHash")]
		NSData VersionHash { get; }

		/// <summary>Gets or sets the ValueTransformerName value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("valueTransformerName")]
		string ValueTransformerName { get; set; }

		/// <summary>Gets or sets the AllowsExternalBinaryDataStorage value.</summary>
		[Export ("allowsExternalBinaryDataStorage")]
		bool AllowsExternalBinaryDataStorage { get; set; }

		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("preservesValueInHistoryOnDeletion")]
		bool PreservesValueInHistoryOnDeletion { get; set; }

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("allowsCloudEncryption")]
		bool AllowsCloudEncryption { get; set; }
	}

	[BaseType (typeof (NSObject))]
	interface NSEntityDescription : NSCoding, NSCopying {

		/// <param name="entityName">The entity name.</param>
		///         <param name="context">The managed object context.</param>
		///         <summary>Retrieves the entity with <paramref name="entityName" /> that resides in the specified managed object <paramref name="context" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Static, Export ("entityForName:inManagedObjectContext:")]
		[return: NullAllowed]
		NSEntityDescription EntityForName (string entityName, NSManagedObjectContext context);

		[Static, Export ("insertNewObjectForEntityForName:inManagedObjectContext:")]
		NSManagedObject InsertNewObject (string entityName, NSManagedObjectContext context);

		/// <summary>Gets the managed object model for the receiver.</summary>
		[Export ("managedObjectModel")]
		NSManagedObjectModel ManagedObjectModel { get; }

		/// <summary>Gets or sets the name of the receiver's class.</summary>
		[Export ("managedObjectClassName")]
		[NullAllowed]
		string ManagedObjectClassName { get; set; }

		/// <summary>Gets or sets the a value that is used to resolve name conflicts from one model to another.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("renamingIdentifier")]
		string RenamingIdentifier { get; set; }

		/// <summary>Gets the receiver's entity name.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("name")]
		string Name { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the receiver is an abstract entity.</summary>
		[Export ("abstract")]
		bool Abstract { [Bind ("isAbstract")] get; set; }

		/// <summary>Gets a dictionary of the subentities for this entity.</summary>
		[Export ("subentitiesByName")]
#if XAMCORE_5_0
		NSDictionary<NSString, NSEntityDescription> SubentitiesByName { get; }
#else
		NSDictionary SubentitiesByName { get; }
#endif

		/// <summary>Gets an array of the subentities for this entity.</summary>
		[Export ("subentities", ArgumentSemantic.Retain)]
		NSEntityDescription [] Subentities { get; set; }

		/// <summary>Gets the superentity of this entity.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("superentity")]
		NSEntityDescription Superentity { get; }

		/// <summary>Gets a dictionary of the receiver's properties.</summary>
		[Export ("propertiesByName")]
#if XAMCORE_5_0
		NSDictionary<NSString, NSPropertyDescription> PropertiesByName { get; }
#else
		NSDictionary PropertiesByName { get; }
#endif

		/// <summary>Gets an array that contains the receiver's properties.</summary>
		[Export ("properties", ArgumentSemantic.Retain)]
		NSPropertyDescription [] Properties { get; set; }

		/// <summary>Gets or sets the receiver's user information dictionary.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("userInfo", ArgumentSemantic.Retain)]
		NSDictionary UserInfo { get; set; }

		/// <summary>Gets the a dictionary whose keys are the receiver attribute names and whose values are the corresponding attribute values.</summary>
		[Export ("attributesByName")]
#if XAMCORE_5_0
		NSDictionary<NSString, NSAttributeDescription> AttributesByName { get; }
#else
		NSDictionary AttributesByName { get; }
#endif

		/// <summary>Gets a dictionary of the receiver's relationships.</summary>
		[Export ("relationshipsByName")]
#if XAMCORE_5_0
		NSDictionary<NSString, NSRelationshipDescription> RelationshipsByName { get; }
#else
		NSDictionary RelationshipsByName { get; }
#endif

		/// <param name="entity">The entity description.</param>
		///         <summary>Gets a dictionary of the relationships that the receiver has with <paramref name="entity" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("relationshipsWithDestinationEntity:")]
		NSRelationshipDescription [] RelationshipsWithDestinationEntity (NSEntityDescription entity);

		/// <param name="entity">The entity description.</param>
		///         <summary>Returns a Boolean value that tells whether the receiver is a subtype of <paramref name="entity" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("isKindOfEntity:")]
		bool IsKindOfEntity (NSEntityDescription entity);

		/// <summary>Gets the receiver's version hash.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("versionHash")]
		NSData VersionHash { get; }

		/// <summary>Gets the modifier for the receiver's version hash.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("versionHashModifier")]
		string VersionHashModifier { get; set; }

		/// <summary>Developers should not use this deprecated property. Developers should use 'NSEntityDescription.Indexes' instead.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("compoundIndexes", ArgumentSemantic.Retain)]
		[Deprecated (PlatformName.iOS, 11, 0, message: "Use 'NSEntityDescription.Indexes' instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 13, message: "Use 'NSEntityDescription.Indexes' instead.")]
		[Deprecated (PlatformName.TvOS, 11, 0, message: "Use 'NSEntityDescription.Indexes' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'NSEntityDescription.Indexes' instead.")]
		NSPropertyDescription [] CompoundIndexes { get; set; }

		/// <summary>Gets or sets the indices for the entity.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[Export ("indexes", ArgumentSemantic.Copy)]
		NSFetchIndexDescription [] Indexes { get; set; }

		// @property (strong) NSArray<NSArray<id __nonnull> * __nonnull> * __nonnull uniquenessConstraints __attribute__((availability(ios, introduced=9.0)));
		[MacCatalyst (13, 1)]
		[Internal, Export ("uniquenessConstraints", ArgumentSemantic.Strong)]
		NSArray _UniquenessConstraints { get; set; }

		/// <summary>Gets or sets the expression that will be used to calculate the core spotlight display name for the entity.</summary>
		[MacCatalyst (13, 1)]
		[Export ("coreSpotlightDisplayNameExpression", ArgumentSemantic.Retain)]
		NSExpression CoreSpotlightDisplayNameExpression { get; set; }
	}

	/// <summary>Specifies the mapping between an in-memory object and its persistent representation.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/NSEntityMapping_class/index.html">Apple documentation for <c>NSEntityMapping</c></related>
	[BaseType (typeof (NSObject))]
	interface NSEntityMapping {

		/// <summary>Gets or sets the Name value.</summary>
		[Export ("name")]
		[NullAllowed]
		string Name { get; set; }

		/// <summary>Gets or sets the MappingType value.</summary>
		[Export ("mappingType")]
		NSEntityMappingType MappingType { get; set; }

		/// <summary>Gets or sets the SourceEntityName value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("sourceEntityName")]
		string SourceEntityName { get; set; }

		/// <summary>Gets or sets the SourceEntityVersionHash value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("sourceEntityVersionHash", ArgumentSemantic.Copy)]
		NSData SourceEntityVersionHash { get; set; }

		/// <summary>Gets or sets the DestinationEntityName value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("destinationEntityName", ArgumentSemantic.Copy)]
		string DestinationEntityName { get; set; }

		/// <summary>Gets or sets the DestinationEntityVersionHash value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("destinationEntityVersionHash", ArgumentSemantic.Copy)]
		NSData DestinationEntityVersionHash { get; set; }

		/// <summary>Gets or sets the AttributeMappings value.</summary>
		[Export ("attributeMappings", ArgumentSemantic.Retain)]
		[NullAllowed]
		NSPropertyMapping [] AttributeMappings { get; set; }

		/// <summary>Gets or sets the RelationshipMappings value.</summary>
		[Export ("relationshipMappings", ArgumentSemantic.Retain)]
		[NullAllowed]
		NSPropertyMapping [] RelationshipMappings { get; set; }

		/// <summary>Gets or sets the SourceExpression value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("sourceExpression", ArgumentSemantic.Retain)]
		NSExpression SourceExpression { get; set; }

		/// <summary>Gets or sets the UserInfo value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("userInfo", ArgumentSemantic.Retain)]
		NSDictionary UserInfo { get; set; }

		/// <summary>Gets or sets the EntityMigrationPolicyClassName value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("entityMigrationPolicyClassName")]
		string EntityMigrationPolicyClassName { get; set; }
	}

	/// <summary>Customizes the migration process during entity mapping.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/NSEntityMigrationPolicy_class/index.html">Apple documentation for <c>NSEntityMigrationPolicy</c></related>
	[BaseType (typeof (NSObject))]
	interface NSEntityMigrationPolicy {

		/// <param name="mapping">The entity mapping.</param>
		///         <param name="manager">The migration manager.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Performs the begin entity mapping operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("beginEntityMapping:manager:error:")]
		bool BeginEntityMapping (NSEntityMapping mapping, NSMigrationManager manager, out NSError error);

		/// <param name="sInstance">The source instance.</param>
		///         <param name="mapping">The entity mapping.</param>
		///         <param name="manager">The migration manager.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Performs the create destination instances for source instance operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("createDestinationInstancesForSourceInstance:entityMapping:manager:error:")]
		bool CreateDestinationInstancesForSourceInstance (NSManagedObject sInstance, NSEntityMapping mapping, NSMigrationManager manager, out NSError error);

		/// <param name="mapping">The entity mapping.</param>
		///         <param name="manager">The migration manager.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Performs the end instance creation for entity mapping operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("endInstanceCreationForEntityMapping:manager:error:")]
		bool EndInstanceCreationForEntityMapping (NSEntityMapping mapping, NSMigrationManager manager, out NSError error);

		/// <param name="dInstance">The destination instance.</param>
		///         <param name="mapping">The entity mapping.</param>
		///         <param name="manager">The migration manager.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Performs the create relationships for destination instance operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("createRelationshipsForDestinationInstance:entityMapping:manager:error:")]
		bool CreateRelationshipsForDestinationInstance (NSManagedObject dInstance, NSEntityMapping mapping, NSMigrationManager manager, out NSError error);

		/// <param name="mapping">The entity mapping.</param>
		///         <param name="manager">The migration manager.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Performs the end relationship creation for entity mapping operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("endRelationshipCreationForEntityMapping:manager:error:")]
		bool EndRelationshipCreationForEntityMapping (NSEntityMapping mapping, NSMigrationManager manager, out NSError error);

		/// <param name="mapping">The entity mapping.</param>
		///         <param name="manager">The migration manager.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Performs the perform custom validation for entity mapping operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("performCustomValidationForEntityMapping:manager:error:")]
		bool PerformCustomValidationForEntityMapping (NSEntityMapping mapping, NSMigrationManager manager, out NSError error);

		/// <param name="mapping">The entity mapping.</param>
		///         <param name="manager">The migration manager.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Performs the end entity mapping operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("endEntityMapping:manager:error:")]
		bool EndEntityMapping (NSEntityMapping mapping, NSMigrationManager manager, out NSError error);
	}

	/// <summary>Descriptor for a fetch result column that does not appear in the source, such as a sum or a minimum of a column in the source.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/CoreData/NSExpressionDescription">Apple documentation for <c>NSExpressionDescription</c></related>
	[BaseType (typeof (NSPropertyDescription))]
	interface NSExpressionDescription {

		/// <summary>Gets or sets the expression that describes the column to return.</summary>
		///         <value>
		///           <para>The expression that describes the column to return.</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("expression", ArgumentSemantic.Strong)]
		NSExpression Expression { get; set; }

		/// <summary>Gets or sets the data type for the column to return.</summary>
		///         <value>The data type for the column to return.</value>
		[Export ("expressionResultType")]
		NSAttributeType ResultType { get; set; }
	}

	/// <summary>Holds "fetched properties," that allow the developer to specify related objects via a weak unidirectional relationship in a fetch request.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/CoreDataFramework/Classes/NSFetchedPropertyDescription_Class/index.html">Apple documentation for <c>NSFetchedPropertyDescription</c></related>
	[BaseType (typeof (NSPropertyDescription))]
	interface NSFetchedPropertyDescription {

		/// <summary>Gets or sets the FetchRequest value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("fetchRequest", ArgumentSemantic.Retain)]
		NSFetchRequest FetchRequest { get; set; }
	}

	/// <summary>Represents an expression that fetches results in a managed object context.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/CoreData/NSFetchRequestExpression">Apple documentation for <c>NSFetchRequestExpression</c></related>
	[DisableDefaultCtor]
	[BaseType (typeof (NSExpression))]
	interface NSFetchRequestExpression {

		[Internal]
		[DesignatedInitializer]
		[Export ("initWithExpressionType:")]
		NativeHandle Constructor (NSExpressionType type);

		/// <param name="fetch">The expression from which to create a new fetch request expression.</param>
		///         <param name="context">The context in which to create the fetch request expression.</param>
		///         <param name="countOnly">Whether to create a fetch request expression that counts the matches, rather than returning them.</param>
		///         <summary>Creates a new <see cref="CoreData.NSFetchRequestExpression" /> from the specified expression and context.</summary>
		///         <returns>A new <see cref="CoreData.NSFetchRequestExpression" /> that was created from the specified expression and context.</returns>
		[Static, Export ("expressionForFetch:context:countOnly:")]
		NSFetchRequestExpression FromFetch (NSExpression fetch, NSExpression context, bool countOnly);

		/// <summary>Gets the expression that represents the request.</summary>
		///         <value>The expression that represents the request.</value>
		[Export ("requestExpression")]
		NSExpression Request { get; }

		/// <summary>Gets the managed object context for the receiver.</summary>
		///         <value>The managed object context for the receiver.</value>
		[Export ("contextExpression")]
		NSExpression Context { get; }

		/// <summary>Gets a <see langword="bool" /> that tells whether the fetch request expression counts the matching data, rather than returning them.</summary>
		///         <value>
		///           <see langword="true" /> if the fetch request expression counts the matching data, rather than returning them. Otherwise, <see langword="false" />.</value>
		[Export ("countOnlyRequest")]
		bool IsCountOnly { [Bind ("isCountOnlyRequest")] get; }
	}

	interface INSFetchRequestResult { }

	[MacCatalyst (13, 1)]
	[Protocol]
	interface NSFetchRequestResult { }

	/// <summary>Holds search criteria used to retrieve data from APersistent store.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/CoreDataFramework/Classes/NSFetchRequest_Class/index.html">Apple documentation for <c>NSFetchRequest</c></related>
	[DisableDefaultCtor] // designated
	[BaseType (typeof (NSPersistentStoreRequest))]
	interface NSFetchRequest : NSCoding {

		/// <summary>Default constructor that initializes a new instance of this class with no parameters.</summary>
		/// <remarks>
		///         </remarks>
		[DesignatedInitializer]
		[Export ("init")]
		NativeHandle Constructor ();

		/// <summary>Gets or sets the Entity value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("entity", ArgumentSemantic.Retain)]
		[NullAllowed]
		NSEntityDescription Entity { get; set; }

		/// <summary>Gets or sets the Predicate value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("predicate", ArgumentSemantic.Retain)]
		[NullAllowed]
		NSPredicate Predicate { get; set; }

		/// <summary>Gets or sets the SortDescriptors value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("sortDescriptors", ArgumentSemantic.Retain)]
		[NullAllowed]
		NSSortDescriptor [] SortDescriptors { get; set; }

		/// <summary>Gets or sets the FetchLimit value.</summary>
		[Export ("fetchLimit")]
		nuint FetchLimit { get; set; }

		/// <summary>Gets or sets the FetchOffset value.</summary>
		[Export ("fetchOffset")]
		nuint FetchOffset { get; set; }

		/// <summary>Gets or sets the AffectedStores value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("affectedStores", ArgumentSemantic.Retain)]
		[NullAllowed]
		NSPersistentStore [] AffectedStores { get; set; }

		/// <summary>Gets or sets the ResultType value.</summary>
		[Export ("resultType")]
		NSFetchRequestResultType ResultType { get; set; }

		/// <summary>Gets or sets the ReturnsDistinctResults value.</summary>
		[Export ("returnsDistinctResults")]
		bool ReturnsDistinctResults { get; set; }

		/// <summary>Gets or sets the IncludesSubentities value.</summary>
		[Export ("includesSubentities")]
		bool IncludesSubentities { get; set; }

		/// <summary>Gets or sets the IncludesPropertyValues value.</summary>
		[Export ("includesPropertyValues")]
		bool IncludesPropertyValues { get; set; }

		/// <summary>Gets or sets the IncludesPendingChanges value.</summary>
		[Export ("includesPendingChanges")]
		bool IncludesPendingChanges { get; set; }

		/// <summary>Gets or sets the ReturnsObjectsAsFaults value.</summary>
		[Export ("returnsObjectsAsFaults")]
		bool ReturnsObjectsAsFaults { get; set; }

		/// <summary>Gets or sets the RelationshipKeyPathsForPrefetching value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("relationshipKeyPathsForPrefetching")]
		[NullAllowed]
		string [] RelationshipKeyPathsForPrefetching { get; set; }

		/// <summary>Gets or sets the PropertiesToFetch value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("propertiesToFetch", ArgumentSemantic.Copy)]
		[NullAllowed]
		NSPropertyDescription [] PropertiesToFetch { get; set; }

		/// <param name="entityName">The entity name.</param>
		///         <summary>Performs the Core Data operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("fetchRequestWithEntityName:")]
		// note: Xcode 6.3 changed the return value type from `NSFetchRequest*` to `instancetype`
		NSFetchRequest FromEntityName (string entityName);

		/// <param name="entityName">The entity name.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithEntityName:")]
		NativeHandle Constructor (string entityName);

		/// <summary>Gets the EntityName value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("entityName", ArgumentSemantic.Strong)]
		string EntityName { get; }

		/// <summary>Gets or sets the FetchBatchSize value.</summary>
		[Export ("fetchBatchSize")]
		nint FetchBatchSize { get; set; }

		/// <summary>Gets or sets the ShouldRefreshRefetchedObjects value.</summary>
		[Export ("shouldRefreshRefetchedObjects")]
		bool ShouldRefreshRefetchedObjects { get; set; }

		/// <summary>Gets or sets the HavingPredicate value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("havingPredicate", ArgumentSemantic.Retain)]
		[NullAllowed]
		NSPredicate HavingPredicate { get; set; }

		/// <summary>Gets or sets the PropertiesToGroupBy value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("propertiesToGroupBy", ArgumentSemantic.Copy)]
		[NullAllowed]
		NSPropertyDescription [] PropertiesToGroupBy { get; set; }

		/// <param name="error">The error, or null if none.</param>
		///         <summary>Performs the Core Data operation.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("execute:")]
		[return: NullAllowed]
		INSFetchRequestResult [] Execute (out NSError error);
	}

	/// <summary>Controller object for Core Data fetch requests; generally used to provide data for a <see cref="UIKit.UITableView" />.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreData/Reference/NSFetchedResultsController_Class/index.html">Apple documentation for <c>NSFetchedResultsController</c></related>
	[NoMac]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject), Delegates = new string [] { "WeakDelegate" })]
	interface NSFetchedResultsController {

		/// <param name="fetchRequest">The fetch request.</param>
		/// <param name="context">The managed object context.</param>
		/// <param name="sectionNameKeyPath">
		///           <para>the key path to the section name</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="name">
		///           <para>The cache name.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new <see cref="CoreData.NSFetchedResultsController" /> from the specified values.</summary>
		[Export ("initWithFetchRequest:managedObjectContext:sectionNameKeyPath:cacheName:")]
		NativeHandle Constructor (NSFetchRequest fetchRequest, NSManagedObjectContext context, [NullAllowed] string sectionNameKeyPath, [NullAllowed] string name);

		/// <summary>An instance of the CoreData.INSFetchedResultsControllerDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the CoreData.INSFetchedResultsControllerDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		INSFetchedResultsControllerDelegate Delegate { get; set; }

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Assign)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>Gets the filename where section information is cached.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("cacheName")]
		string CacheName { get; }

		/// <summary>Gets an array that contains the fetched objects.</summary>
		[Export ("fetchedObjects")]
		[NullAllowed]
		NSObject [] FetchedObjects { get; }

		/// <summary>Gets the request for the fetch for which this object contains the results.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("fetchRequest")]
		NSFetchRequest FetchRequest { get; }

		/// <summary>Returns the <see cref="CoreData.NSManagedObjectContext" /> that is used for fetching.</summary>
		[Export ("managedObjectContext")]
		NSManagedObjectContext ManagedObjectContext { get; }

		/// <summary>Returns the key path to the section name on fetched objects.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("sectionNameKeyPath")]
		string SectionNameKeyPath { get; }

		/// <summary>Gets the sections of the fetch results.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("sections")]
		INSFetchedResultsSectionInfo [] Sections { get; }

		/// <param name="error">The error, or null if none.</param>
		///         <summary>Performs the receiver's fetch request and stores any errors that occur in the specified <see langword="out" /> parameter.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("performFetch:")]
		bool PerformFetch (out NSError error);

		/// <param name="obj">The object.</param>
		///         <summary>Creates a new <see cref="CoreData.NSFetchedResultsController" /> from the specified object.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("indexPathForObject:")]
		[return: NullAllowed]
		NSIndexPath FromObject (NSObject obj);

		/// <param name="path">The key path.</param>
		///         <summary>Returns the object that is located at the specified index <paramref name="path" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("objectAtIndexPath:")]
		NSObject ObjectAt (NSIndexPath path);

		/// <param name="title">The section title.</param>
		/// <param name="atIndex">The index.</param>
		/// <summary>Returns the section number for the specified <paramref name="title" /> and index.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("sectionForSectionIndexTitle:atIndex:")]
		// name like UITableViewSource's similar (and linked) selector
		nint SectionFor (string title, nint atIndex);

		/// <param name="sectionName">The section name.</param>
		/// <summary>Returns the section index titles for the specified section name.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("sectionIndexTitleForSectionName:")]
		[return: NullAllowed]
		string GetSectionIndexTitle (string sectionName);

		/// <summary>Returns an array that contains the section index titles.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("sectionIndexTitles")]
		string [] SectionIndexTitles { get; }

		/// <param name="name">
		///           <para>Name of the cache to delete.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Deletes the cache that resides that ahs the specified name.</summary>
		///         <remarks>Developers should note that passing <see langword="null" /> to this method deletes all caches.</remarks>
		[Static]
		[Export ("deleteCacheWithName:")]
		void DeleteCache ([NullAllowed] string name);
	}

	interface INSFetchedResultsControllerDelegate { }

	[NoMac]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface NSFetchedResultsControllerDelegate {
		/// <param name="controller">The fetched results controller.</param>
		///         <summary>Performs the will change content operation.</summary>
		[Export ("controllerWillChangeContent:")]
		void WillChangeContent (NSFetchedResultsController controller);

		/// <param name="controller">The fetched results controller.</param>
		///         <param name="anObject">The object that changed.</param>
		///         <param name="indexPath">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="type">The store type.</param>
		///         <param name="newIndexPath">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the did change object operation.</summary>
		[Export ("controller:didChangeObject:atIndexPath:forChangeType:newIndexPath:")]
		void DidChangeObject (NSFetchedResultsController controller, NSObject anObject, [NullAllowed] NSIndexPath indexPath, NSFetchedResultsChangeType type, [NullAllowed] NSIndexPath newIndexPath);

		/// <param name="controller">The fetched results controller.</param>
		/// <param name="sectionInfo">The section info.</param>
		/// <param name="sectionIndex">The section index.</param>
		/// <param name="type">The store type.</param>
		/// <summary>Performs the did change section operation.</summary>
		[Export ("controller:didChangeSection:atIndex:forChangeType:")]
		void DidChangeSection (NSFetchedResultsController controller, INSFetchedResultsSectionInfo sectionInfo, nuint sectionIndex, NSFetchedResultsChangeType type);

		/// <param name="controller">The fetched results controller.</param>
		///         <summary>Performs the did change content operation.</summary>
		[Export ("controllerDidChangeContent:")]
		void DidChangeContent (NSFetchedResultsController controller);

		/// <param name="controller">The fetched results controller.</param>
		///         <param name="sectionName">The section name.</param>
		///         <summary>Performs the section for operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("controller:sectionIndexTitleForSectionName:")]
		[return: NullAllowed]
		string SectionFor (NSFetchedResultsController controller, string sectionName);
	}

	[NoMac]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface NSFetchedResultsSectionInfo {
		/// <summary>Gets the Count value.</summary>
		[Export ("numberOfObjects")]
		[Abstract]
		nint Count { get; }

		/// <summary>Gets the Objects value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("objects")]
		[Abstract]
		NSObject [] Objects { get; }

		/// <summary>Gets the Name value.</summary>
		[Export ("name")]
		[Abstract]
		string Name { get; }

		/// <summary>Gets the IndexTitle value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("indexTitle")]
		[Abstract]
		string IndexTitle { get; }
	}

	interface INSFetchedResultsSectionInfo { }

	// 	NSInvalidArgumentException *** -loadMetadata: cannot be sent to an abstract object of class NSIncrementalStore: Create a concrete instance!
	//	Apple doc quote: "NSIncrementalStore is an abstract superclass..."
	// Making a class abstract has problems: https://github.com/dotnet/macios/issues/4969, so we're not doing this yet
	// [Abstract] // Abstract superclass.
	/// <summary>Supports the use of persistent stores that are loaded and saved incrementally, allowing for larger and shared datasets.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreData/Reference/NSIncrementalStore_Class/index.html">Apple documentation for <c>NSIncrementalStore</c></related>
	[BaseType (typeof (NSPersistentStore))]
	interface NSIncrementalStore {
		/// <param name="root">The root expression.</param>
		/// <param name="name">The name.</param>
		/// <param name="url">The URL.</param>
		/// <param name="options">The options dictionary.</param>
		/// <summary>Creates a new <see cref="CoreData.NSIncrementalStore" /> with the specified values.</summary>
		[Protected]
		[Export ("initWithPersistentStoreCoordinator:configurationName:URL:options:")]
		NativeHandle Constructor (NSPersistentStoreCoordinator root, string name, NSUrl url, NSDictionary options);

		/// <param name="error">The error, or null if none.</param>
		///         <summary>Loads the store metadata and reports any errors in <paramref name="error" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("loadMetadata:")]
		bool LoadMetadata (out NSError error);

		/// <param name="request">The fetch request.</param>
		///         <param name="context">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Runs the specified <paramref name="request" /> in the specified <paramref name="context" />, and reports any errors in <paramref name="error" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("executeRequest:withContext:error:")]
		[return: NullAllowed]
		NSObject ExecuteRequest (NSPersistentStoreRequest request, [NullAllowed] NSManagedObjectContext context, out NSError error);

		/// <param name="forObjectId">The object identifier.</param>
		///         <param name="context">The managed object context.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Returns a <see cref="CoreData.NSIncrementalStoreNode" /> for the persistent external values of the identified object and reports any errors in <paramref name="error" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("newValuesForObjectWithID:withContext:error:")]
		[return: NullAllowed]
		NSIncrementalStoreNode NewValues (NSManagedObjectID forObjectId, NSManagedObjectContext context, out NSError error);

		/// <param name="forRelationship">The relationship description.</param>
		///         <param name="forObjectI">The object identifier.</param>
		///         <param name="context">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Returns a new relationship for the specified relationship data.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("newValueForRelationship:forObjectWithID:withContext:error:")]
		[return: NullAllowed]
		NSObject NewValue (NSRelationshipDescription forRelationship, NSManagedObjectID forObjectI, [NullAllowed] NSManagedObjectContext context, out NSError error);

		/// <param name="storeUrl">The store URL.</param>
		/// <summary>Returns the identifier for the store at <paramref name="storeUrl" />.</summary>
		/// <returns>The result of the operation.</returns>
		[Static]
		[Export ("identifierForNewStoreAtURL:")]
		NSObject GetIdentifierForNewStore (NSUrl storeUrl);

		/// <param name="array">The array of objects.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Returns an array of permanent identifiers for the provided newly inserted objects and reports any errors in <paramref name="error" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("obtainPermanentIDsForObjects:error:")]
		[return: NullAllowed]
		NSObject [] ObtainPermanentIds (NSObject [] array, out NSError error);

		/// <param name="objectIds">The object identifiers.</param>
		///         <summary>Method that is called when the <paramref name="objectIds" /> are registered for use.</summary>
		[Export ("managedObjectContextDidRegisterObjectsWithIDs:")]
		void ManagedObjectContextDidRegisterObjectsWithIds (NSObject [] objectIds);

		/// <param name="objectIds">The object identifiers.</param>
		///         <summary>Method that is called when the <paramref name="objectIds" /> are unregistered for use.</summary>
		[Export ("managedObjectContextDidUnregisterObjectsWithIDs:")]
		void ManagedObjectContextDidUnregisterObjectsWithIds (NSObject [] objectIds);

		/// <param name="forEntity">The entity description.</param>
		///         <param name="referenceObject">The reference object.</param>
		///         <summary>Developers should not override this method. Returns a new ID for the entity and description.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("newObjectIDForEntity:referenceObject:")]
		NSManagedObjectID NewObjectIdFor (NSEntityDescription forEntity, NSObject referenceObject);

		/// <param name="objectId">The object identifier.</param>
		///         <summary>Developers should not override this method. Returns a reference object for <paramref name="objectId" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("referenceObjectForObjectID:")]
		NSObject ReferenceObjectForObject (NSManagedObjectID objectId);

	}

	/// <summary>A concrete class that represents basic nodes in a <see cref="CoreData.NSIncrementalStore" />.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreData/Reference/NSIncrementalStoreNode_Class/index.html">Apple documentation for <c>NSIncrementalStoreNode</c></related>
	[BaseType (typeof (NSObject))]
	interface NSIncrementalStoreNode {
		/// <param name="objectId">The object identifier.</param>
		/// <param name="values">The values.</param>
		/// <param name="version">The version.</param>
		/// <summary>Performs the Core Data operation.</summary>
		[Export ("initWithObjectID:withValues:version:")]
#if XAMCORE_5_0
		NativeHandle Constructor (NSManagedObjectID objectId, NSDictionary<NSString, NSObject> values, ulong version);
#else
		NativeHandle Constructor (NSManagedObjectID objectId, NSDictionary values, ulong version);
#endif

		/// <param name="values">The values.</param>
		///         <param name="version">The version.</param>
		///         <summary>Performs the Core Data operation.</summary>
		[Export ("updateWithValues:version:")]
#if XAMCORE_5_0
		void Update (NSDictionary<NSString, NSObject> values, ulong version);
#else
		void Update (NSDictionary values, ulong version);
#endif

		/// <summary>Gets the ObjectId value.</summary>
		[Export ("objectID")]
		NSManagedObjectID ObjectId { get; }

		/// <summary>Gets the Version value.</summary>
		[Export ("version")]
		long Version { get; }

		/// <param name="prop">The property description.</param>
		///         <summary>Performs the value for property description operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("valueForPropertyDescription:")]
		[return: NullAllowed]
		NSObject ValueForPropertyDescription (NSPropertyDescription prop);
	}

	/// <summary>A class that can be managed by a managed object context. Should have a correspondence to domain model classes, even if they are not direct subtypes.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/CoreDataFramework/Classes/NSManagedObject_Class/index.html">Apple documentation for <c>NSManagedObject</c></related>
	[BaseType (typeof (NSObject))]
	// 'init' issues a warning: CoreData: error: Failed to call designated initializer on NSManagedObject class 'NSManagedObject' 
	// then crash while disposing the instance
	[DisableDefaultCtor]
	interface NSManagedObject : NSFetchRequestResult {
		/// <param name="entity">The entity description.</param>
		/// <param name="context">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new <see cref="CoreData.NSManagedObject" /> from an entity description and inserts the object into the specified managed object context.</summary>
		[DesignatedInitializer]
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);

		/// <param name="moc">The managed object context.</param>
		/// <summary>Creates a new <see cref="CoreData.NSManagedObject" /> in the specified managed object context.</summary>
		[MacCatalyst (13, 1)]
		[Export ("initWithContext:")]
		NativeHandle Constructor (NSManagedObjectContext moc);

		/// <summary>Gets the entity description for the receiver.</summary>
		///         <returns>The entity description for the receiver.</returns>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("entity")]
		NSEntityDescription GetEntityDescription ();

		/// <summary>Creates and returns a fetch request.</summary>
		///         <returns>A fetch request.</returns>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("fetchRequest")]
		NSFetchRequest CreateFetchRequest ();

		/// <summary>Gets the managed object context where this managed object is registered.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("managedObjectContext")]
		NSManagedObjectContext ManagedObjectContext { get; }

		/// <summary>Gets the receiver's entity description.</summary>
		[Export ("entity", ArgumentSemantic.Strong)]
		NSEntityDescription Entity { get; }

		/// <summary>Gets the object identifier.</summary>
		///         <remarks>This value changes when an unsaved object is saved.</remarks>
		[Export ("objectID", ArgumentSemantic.Strong)]
		NSManagedObjectID ObjectID { get; }

		/// <summary>Gets a Boolean value that tells whether the managed object should ignore changes to unmodeled properties.</summary>
		///         <value>A Boolean value that tells whether the managed object should ignore changes to unmodeled properties.</value>
		[Static, Export ("contextShouldIgnoreUnmodeledPropertyChanges")]
		bool ContextShouldIgnoreUnModeledPropertyChanges { get; }

		/// <summary>Gets a Boolean value that tells whether the receiver was inserted into a managed object context.</summary>
		[Export ("inserted")]
		bool IsInserted { [Bind ("isInserted")] get; }

		/// <summary>Gets a Boolean value that tells whether the receiver has changes that are not yet saved.</summary>
		[Export ("updated")]
		bool IsUpdated { [Bind ("isUpdated")] get; }

		/// <summary>Gets a Boolean value that tells whether the receiver will be deleted in the next save.</summary>
		[Export ("deleted")]
		bool IsDeleted { [Bind ("isDeleted")] get; }

		/// <summary>Gets a Boolean value that tells whether the receiver has been converted to a fault.</summary>
		[Export ("fault")]
		bool IsFault { [Bind ("isFault")] get; }

		/// <summary>Gets the receiver's faulting state.</summary>
		///         <value>The receiver's faulting state.</value>
		[Export ("faultingState")]
		nuint FaultingState { get; }

		/// <param name="key">The key.</param>
		///         <summary>Gets a Boolean value that tells whether the receiver has a fault.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("hasFaultForRelationshipNamed:")]
		bool HasFaultForRelationshipNamed (string key);

		/// <param name="key">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Method that is called before the value for the property that is identified by <paramref name="key" /> is accessed.</summary>
		[Export ("willAccessValueForKey:")]
		void WillAccessValueForKey ([NullAllowed] string key);

		/// <param name="key">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Method that is called when the value for the property that is identified by <paramref name="key" /> is accessed.</summary>
		[Export ("didAccessValueForKey:")]
		void DidAccessValueForKey ([NullAllowed] string key);

		/// <param name="key">The key.</param>
		///         <summary>Method that is called before the value for the property that is identified by <paramref name="key" /> is changed.</summary>
		[Export ("willChangeValueForKey:")]
		void WillChangeValueForKey (string key);

		/// <param name="key">The key.</param>
		///         <summary>Method that is called when the value for the property that is identified by <paramref name="key" /> is changed.</summary>
		[Export ("didChangeValueForKey:")]
		void DidChangeValueForKey (string key);

		/// <param name="inKey">The key.</param>
		///         <param name="inMutationKind">The mutation kind.</param>
		///         <param name="inObjects">The objects.</param>
		///         <summary>Method that is called before the value for the many-to-many property that is identified by <paramref name="inKey" /> is changed.</summary>
		[Export ("willChangeValueForKey:withSetMutation:usingObjects:")]
		void WillChangeValueForKey (string inKey, NSKeyValueSetMutationKind inMutationKind, NSSet inObjects);

		/// <param name="inKey">The key.</param>
		///         <param name="inMutationKind">The mutation kind.</param>
		///         <param name="inObjects">The objects.</param>
		///         <summary>Method that is called when the value for the many-to-many property that is identified by <paramref name="inKey" /> is changed.</summary>
		[Export ("didChangeValueForKey:withSetMutation:usingObjects:")]
		void DidChangeValueForKey (string inKey, NSKeyValueSetMutationKind inMutationKind, NSSet inObjects);

		/// <summary>Gets the KVO information for the object.</summary>
		[NoTV]
		[MacCatalyst (13, 1)]
		[Export ("observationInfo")]
		IntPtr ObservationInfo { get; set; }

		/// <summary>Method that is called after the receiver is fetched.</summary>
		[Export ("awakeFromFetch")]
		void AwakeFromFetch ();

		/// <summary>Method that is called after the managed object is inserted into a managed object context.</summary>
		[Export ("awakeFromInsert")]
		void AwakeFromInsert ();

		/// <param name="flags">The flags.</param>
		///         <summary>Method that is called to awaken the receiver when AProperty state change occurs.</summary>
		///         <remarks>
		///           <para>See the <see cref="CoreData.NSSnapshotEventType" /> enumeration for a list of the values that can be returned by this method.</para>
		///         </remarks>
		[Export ("awakeFromSnapshotEvents:")]
		void AwakeFromSnapshotEvents (NSSnapshotEventType flags);

		/// <summary>Method that is called before the receiver is saved.</summary>
		[Export ("willSave")]
		void WillSave ();

		/// <summary>Method that is called after the managed context operation saves values.</summary>
		[Export ("didSave")]
		void DidSave ();

		/// <summary>Method that is called before the receiver is turned into a fault.</summary>
		[Export ("willTurnIntoFault")]
		void WillTurnIntoFault ();

		/// <summary>Method that is called when the receiver becomes a fault.</summary>
		[Export ("didTurnIntoFault")]
		void DidTurnIntoFault ();

		/// <param name="key">The key.</param>
		/// <summary>Returns the value for the property that is identified by the specified <paramref name="key" />.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("valueForKey:")]
		[return: NullAllowed]
		NSObject GetValue (string key);

		/// <param name="value">The value.</param>
		/// <param name="key">The key.</param>
		/// <summary>Sets the receiver's value for the property that is specified by the provided <paramref name="key" />.</summary>
		[Export ("setValue:forKey:")]
		void SetValue ([NullAllowed] NSObject value, string key);

		/// <param name="key">The key.</param>
		/// <summary>Returns the receiver's internal primitive value for the property that is specified by the provided <paramref name="key" />.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("primitiveValueForKey:")]
		[return: NullAllowed]
		NSObject GetPrimitiveValue (string key);

		/// <param name="value">The value.</param>
		/// <param name="key">The key.</param>
		/// <summary>Sets the receiver's internal primitive value for the property that is specified by the provided <paramref name="key" />.</summary>
		[Export ("setPrimitiveValue:forKey:")]
		void SetPrimitiveValue ([NullAllowed] NSObject value, string key);

		/// <param name="keys">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Returns a dictionary that contains property values for the specified <paramref name="keys" /> from before the last fetch or save.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("committedValuesForKeys:")]
#if XAMCORE_5_0
		NSDictionary<NSString, NSObject> GetCommittedValues ([NullAllowed] string[] keys);
#else
		NSDictionary GetCommittedValues ([NullAllowed] string [] keys);
#endif

		/// <summary>Gets a dictionary of the old values of persistent values that were recently changed since the receiver was last fetched.</summary>
		[Export ("changedValues")]
#if XAMCORE_5_0
		NSDictionary<NSString, NSObject> ChangedValues { get; }
#else
		NSDictionary ChangedValues { get; }
#endif

		/// <param name="value">The value.</param>
		///         <param name="key">The key.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Returns <see langword="true" /> if the specified <paramref name="value" /> is valid for the property that is identified by the specified <paramref name="key" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("validateValue:forKey:error:")]
		bool ValidateValue (ref NSObject value, string key, out NSError error);

		/// <param name="error">The error, or null if none.</param>
		///         <summary>Returns <see langword="true" /> if the receiver is valid for deletion.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("validateForDelete:")]
		bool ValidateForDelete (out NSError error);

		/// <param name="error">The error, or null if none.</param>
		///         <summary>Returns <see langword="true" /> if the receiver is valid for insertion.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("validateForInsert:")]
		bool ValidateForInsert (out NSError error);

		/// <param name="error">The error, or null if none.</param>
		///         <summary>Returns <see langword="true" /> if the receiver is valid for updating.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("validateForUpdate:")]
		bool ValidateForUpdate (out NSError error);

		/// <summary>Gets a Boolean value that tells whether the receiver has changes due to having been inserted or deleted, or due to having other unsaved changes.</summary>
		[Export ("hasChanges")]
		bool HasChanges { get; }

		/// <summary>Returns a dictionary of the old values of persistent values that were recently changed since the context objects last changed.</summary>
		[Export ("changedValuesForCurrentEvent")]
		NSDictionary ChangedValuesForCurrentEvent { get; }

		/// <summary>Method that is called prior to the object being deleted.</summary>
		[Export ("prepareForDeletion")]
		void PrepareForDeletion ();

		// headers say this is introduced in 7.0,10.9 but Xcode 7 API diff
		// indicates it's new in 9.0,10.11... going by the header value...
		/// <summary>Gets a Boolean value that tells whether the receiver has unsaved changes to persistent values.</summary>
		[MacCatalyst (13, 1)]
		[Export ("hasPersistentChangedValues")]
		bool HasPersistentChangedValues { get; }

		/// <param name="relationshipName">The relationship name.</param>
		///         <summary>Gets the identifiers for all of the objects that are involved in the specified relationship.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("objectIDsForRelationshipNamed:")]
		NSManagedObjectID [] GetObjectIDs (string relationshipName);
	}

	/// <summary>Controls whether and how a managed object context pins itself to database transactions.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/CoreData/NSQueryGenerationToken">Apple documentation for <c>NSQueryGenerationToken</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NSQueryGenerationToken : NSSecureCoding, NSCopying {
		/// <summary>Gets the current query generation token.</summary>
		///         <value>The current query generation token.</value>
		[Static, Export ("currentQueryGenerationToken", ArgumentSemantic.Strong)]
		NSQueryGenerationToken CurrentToken { get; }
	}

	/// <summary>A collection of related managed objects that create aninternally-consistent view of one or more persistent stores.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/CoreDataFramework/Classes/NSManagedObjectContext_Class/index.html">Apple documentation for <c>NSManagedObjectContext</c></related>
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NSManagedObjectContext : NSCoding
#if !TVOS
	, NSLocking
#endif
#if MONOMAC
	, NSEditor, NSEditorRegistration
#endif
	{
		/// <summary>Default constructor that initializes a new instance of this class with no parameters.</summary>
		/// <remarks>
		///         </remarks>
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'NSManagedObjectContext (NSManagedObjectContextConcurrencyType)' instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use 'NSManagedObjectContext (NSManagedObjectContextConcurrencyType)' instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 11, message: "Use 'NSManagedObjectContext (NSManagedObjectContextConcurrencyType)' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'NSManagedObjectContext (NSManagedObjectContextConcurrencyType)' instead.")]
		[Export ("init")]
		NativeHandle Constructor ();

		/// <summary>Gets the receiver's store coordinator.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("persistentStoreCoordinator", ArgumentSemantic.Retain)]
		NSPersistentStoreCoordinator PersistentStoreCoordinator { get; set; }

		/// <summary>Gets the receiver's undo manager.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("undoManager", ArgumentSemantic.Retain)]
		[NullAllowed]
		NSUndoManager UndoManager { get; set; }

		/// <summary>Gets a Boolean value that tells whether the receiver has any unsaved changes.</summary>
		[Export ("hasChanges")]
		bool HasChanges { get; }

		/// <param name="objectID">The managed object identifier.</param>
		///         <summary>Returns the object that is identified by <paramref name="objectID" />, if it represents a registered object.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("objectRegisteredForID:")]
		[return: NullAllowed]
		NSManagedObject ObjectRegisteredForID (NSManagedObjectID objectID);

		/// <param name="objectID">The managed object identifier.</param>
		///         <summary>Returns the object that is identified by <paramref name="objectID" /></summary>
		///         <returns>The result of the operation.</returns>
		[Export ("objectWithID:")]
		NSManagedObject ObjectWithID (NSManagedObjectID objectID);

		/// <param name="request">The fetch request.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Runs the specified <paramref name="request" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("executeFetchRequest:error:")]
		[return: NullAllowed]
		NSObject [] ExecuteFetchRequest (NSFetchRequest request, out NSError error);

		/// <param name="request">The fetch request.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Returns the number of objects that <paramref name="request" /> would return if it were run.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("countForFetchRequest:error:")]
		nuint CountForFetchRequest (NSFetchRequest request, out NSError error);

		/// <param name="object1">The first object.</param>
		///         <summary>Inserts <paramref name="object1" /> into the context.</summary>
		[Export ("insertObject:")]
		void InsertObject (NSManagedObject object1);

		/// <param name="object1">The first object.</param>
		///         <summary>Queues <paramref name="object1" /> for deletion.</summary>
		[Export ("deleteObject:")]
		void DeleteObject (NSManagedObject object1);

		/// <param name="object1">The first object.</param>
		///         <param name="flag">The flag value.</param>
		///         <summary>Refreshes <paramref name="object1" /> with the most current values from its store.</summary>
		[Export ("refreshObject:mergeChanges:")]
		void RefreshObject (NSManagedObject object1, bool flag);

		/// <param name="object1">The first object.</param>
		///         <summary>Marks <paramref name="object1" /> for conflict detection.</summary>
		[Export ("detectConflictsForObject:")]
		void DetectConflictsForObject (NSManagedObject object1);

		/// <param name="keyPath">The key path.</param>
		/// <param name="object1">The first object.</param>
		/// <param name="change">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="context">The managed object context.</param>
		/// <summary>Observes the object that is identified by the provided object and keypath for changes.</summary>
		[Export ("observeValueForKeyPath:ofObject:change:context:")]
#if XAMCORE_5_0
		void ObserveValue ([NullAllowed] string keyPath, [NullAllowed] NSObject object1, [NullAllowed] NSDictionary<NSString, NSObject> change, IntPtr context);
#else
		void ObserveValue ([NullAllowed] string keyPath, [NullAllowed] NSObject object1, [NullAllowed] NSDictionary change, IntPtr context);
#endif

		/// <summary>Tells the receiver to process all changes on the object graph.</summary>
		[Export ("processPendingChanges")]
		void ProcessPendingChanges ();

		/// <param name="object1">The first object.</param>
		/// <param name="store">The persistent store.</param>
		/// <summary>Assigns <paramref name="object1" /> to <paramref name="store" />.</summary>
		[Export ("assignObject:toPersistentStore:")]
		void AssignObject (NSObject object1, NSPersistentStore store);

		/// <summary>Gets the inserted, but unsaved, objects in the context.</summary>
		[Export ("insertedObjects", ArgumentSemantic.Strong)]
#if XAMCORE_5_0
		NSSet<NSManagedObject> InsertedObjects { get; }
#else
		NSSet InsertedObjects { get; }
#endif

		/// <summary>Gets a set that contains all of the receiver's objects which have uncommitted changes.</summary>
		[Export ("updatedObjects", ArgumentSemantic.Strong)]
#if XAMCORE_5_0
		NSSet<NSManagedObject> UpdatedObjects { get; }
#else
		NSSet UpdatedObjects { get; }
#endif

		/// <summary>Gets a set that contains the objects that will be deleted by the next save operation.</summary>
		[Export ("deletedObjects", ArgumentSemantic.Strong)]
#if XAMCORE_5_0
		NSSet<NSManagedObject> DeletedObjects { get; }
#else
		NSSet DeletedObjects { get; }
#endif

		/// <summary>Gets a set that contains all of the receiver's registered objects.</summary>
		[Export ("registeredObjects", ArgumentSemantic.Strong)]
#if XAMCORE_5_0
		NSSet<NSManagedObject> RegisteredObjects { get; }
#else
		NSSet RegisteredObjects { get; }
#endif

		/// <summary>Instructs the receiver to undo its uncommitted changes.</summary>
		[Export ("undo")]
		void Undo ();

		/// <summary>Reverses the most recent unreversed undo.</summary>
		[Export ("redo")]
		void Redo ();

		/// <summary>Resets the receiver.</summary>
		[Export ("reset")]
		void Reset ();

		/// <summary>Rolls the state of all objects in the object graph back to the most recent committed values.</summary>
		[Export ("rollback")]
		void Rollback ();

		/// <param name="error">The error, or null if none.</param>
		///         <summary>Saves uncommitted changes and reports any error that it encounters.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("save:")]
		bool Save (out NSError error);

#pragma warning disable 0109 // warning CS0109: The member 'NSManagedObjectContext.Lock()' does not hide an accessible member. The new keyword is not required.
		/// <summary>Developers should not use this deprecated method. Developers should use a queue style context and 'PerformAndWait' instead.</summary>
		[NoTV]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use a queue style context and 'PerformAndWait' instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use a queue style context and 'PerformAndWait' instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use a queue style context and 'PerformAndWait' instead.")]
		[Export ("lock")]
		new void Lock ();
#pragma warning restore

#pragma warning disable 0109 // warning CS0109: The member 'NSManagedObjectContext.Unlock()' does not hide an accessible member. The new keyword is not required.
		/// <summary>Performs the unlock operation.</summary>
		[NoTV]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use a queue style context and 'PerformAndWait' instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use a queue style context and 'PerformAndWait' instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use a queue style context and 'PerformAndWait' instead.")]
		[Export ("unlock")]
		new void Unlock ();
#pragma warning restore

		/// <summary>Gets the TryLock value.</summary>
		[NoTV]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use a queue style context and 'Perform' instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use a queue style context and 'Perform' instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use a queue style context and 'Perform' instead.")]
		[Export ("tryLock")]
		bool TryLock { get; }

		/// <summary>Gets or sets a Boolean value that controls whether the receiver propagates deletes after change events.</summary>
		[Export ("propagatesDeletesAtEndOfEvent")]
		bool PropagatesDeletesAtEndOfEvent { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the receiver retains hard references to its registered managed objects.</summary>
		[Export ("retainsRegisteredObjects")]
		bool RetainsRegisteredObjects { get; set; }

		/// <summary>Gets or sets the maximum elapsed time after fetching which causes fault fulfillment to fetch new data.</summary>
		[Export ("stalenessInterval")]
		double StalenessInterval { get; set; }

		/// <summary>Gets or sets the receiver's merge policy.</summary>
		[Export ("mergePolicy", ArgumentSemantic.Retain)]
		IntPtr MergePolicy { get; set; }

		/// <param name="objects">The managed objects.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Converts the object identifiers to permanent identifiers for the provided <paramref name="objects" />. Returns <see langword="true" /> if all of the identifiers were converted.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("obtainPermanentIDsForObjects:error:")]
		bool ObtainPermanentIDsForObjects (NSManagedObject [] objects, out NSError error);

		/// <param name="notification">The notification.</param>
		///         <summary>Method that is called to merge the changes that are specified by <paramref name="notification" />.</summary>
		[Export ("mergeChangesFromContextDidSaveNotification:")]
		void MergeChangesFromContextDidSaveNotification (NSNotification notification);

		/// <param name="ct">The cancellation token.</param>
		/// <summary>Creates a new <see cref="CoreData.NSManagedObjectContext" /> of the specified type.</summary>
		[DesignatedInitializer]
		[Export ("initWithConcurrencyType:")]
		NativeHandle Constructor (NSManagedObjectContextConcurrencyType ct);

		/// <param name="action">The action.</param>
		///         <summary>Asynchronously performs the specified <paramref name="action" />.</summary>
		[Export ("performBlock:")]
		void Perform (/* non null */ Action action);

		/// <param name="action">The action.</param>
		///         <summary>Synchronously performs the specified <paramref name="action" />.</summary>
		[Export ("performBlockAndWait:")]
		void PerformAndWait (/* non null */ Action action);

		/// <summary>Gets the receiver's user information.</summary>
		[Export ("userInfo", ArgumentSemantic.Strong)]
		NSMutableDictionary UserInfo { get; }

		/// <summary>Gets the receiver's concurrency type.</summary>
		[Export ("concurrencyType")]
		NSManagedObjectContextConcurrencyType ConcurrencyType { get; }

		//Detected properties
		// default is null, but setting it to null again would crash the app
		/// <summary>Gets the receiver's parent context.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("parentContext", ArgumentSemantic.Retain)]
		NSManagedObjectContext ParentContext { get; set; }

		[Field ("NSManagedObjectContextObjectsDidChangeNotification")]
		[Notification (typeof (NSManagedObjectChangeEventArgs))]
		NSString ObjectsDidChangeNotification { get; }

		[Field ("NSManagedObjectContextDidSaveNotification")]
		[Notification (typeof (NSManagedObjectChangeEventArgs))]
		NSString DidSaveNotification { get; }

		[Field ("NSManagedObjectContextWillSaveNotification")]
		[Notification ()]
		NSString WillSaveNotification { get; }

		/// <summary>Gets or sets a name for the object.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed] // by default this property is null
		[Export ("name")]
		string Name { get; set; }

		/// <param name="request">The fetch request.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Runs the specified <paramref name="request" />.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("executeRequest:error:")]
		[return: NullAllowed]
		NSPersistentStoreResult ExecuteRequest (NSPersistentStoreRequest request, out NSError error);

		/// <param name="objectID">The object ID of object to fetch.</param>
		///         <param name="error">On error, this will contain the error information.</param>
		///         <summary>Fetches an object with a specified id.</summary>
		///         <returns>The object with the associated ID, or null if the
		/// 	object does not exist, or can not be retrieved.</returns>
		[Export ("existingObjectWithID:error:")]
		[return: NullAllowed]
		NSManagedObject GetExistingObject (NSManagedObjectID objectID, out NSError error);

		/// <summary>Gets or sets a Boolean value that controls whether inaccessible faults will be deleted.</summary>
		[MacCatalyst (13, 1)]
		[Export ("shouldDeleteInaccessibleFaults")]
		bool ShouldDeleteInaccessibleFaults { get; set; }

		/// <param name="fault">The fault.</param>
		///         <param name="oid">The object identifier.</param>
		///         <param name="property">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Returns a Boolean value that controls whether inaccessible faults will be handled.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("shouldHandleInaccessibleFault:forObjectID:triggeredByProperty:")]
		bool ShouldHandleInaccessibleFault (NSManagedObject fault, NSManagedObjectID oid, [NullAllowed] NSPropertyDescription property);

		/// <param name="changeNotificationData">The change notification data.</param>
		///         <param name="contexts">The contexts to merge.</param>
		///         <summary>Merges remote changes.</summary>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("mergeChangesFromRemoteContextSave:intoContexts:")]
		void MergeChangesFromRemoteContextSave (NSDictionary changeNotificationData, NSManagedObjectContext [] contexts);

		/// <summary>Gets the token that identifies the current query generation behavior.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("queryGenerationToken", ArgumentSemantic.Strong)]
		NSQueryGenerationToken QueryGenerationToken { get; }

		/// <param name="generation">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Sets the query generation from the specified query generation token.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("setQueryGenerationFromToken:error:")]
		bool SetQueryGenerationFromToken ([NullAllowed] NSQueryGenerationToken generation, out NSError error);

		/// <summary>Gets or sets a Boolean that tells whether changes in the parent are automatically merged.</summary>
		[MacCatalyst (13, 1)]
		[Export ("automaticallyMergesChangesFromParent")]
		bool AutomaticallyMergesChangesFromParent { get; set; }

		/// <summary>Refreshes all objects in the store.</summary>
		[MacCatalyst (13, 1)]
		[Export ("refreshAllObjects")]
		void RefreshAllObjects ();

		/// <summary>Gets or sets the author of the persistent history context.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("transactionAuthor")]
		string TransactionAuthor { get; set; }

		[Notification (typeof (NSManagedObjectsIdsChangedEventArgs))]
		[TV (14, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Field ("NSManagedObjectContextDidMergeChangesObjectIDsNotification")]
		NSString DidMergeChangesObjectIdsNotification { get; }

		[Notification (typeof (NSManagedObjectsIdsChangedEventArgs))]
		[TV (14, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Field ("NSManagedObjectContextDidSaveObjectIDsNotification")]
		NSString DidSaveObjectIdsNotification { get; }
	}

	[TV (14, 0), iOS (14, 0)]
	[MacCatalyst (14, 0)]
	interface NSManagedObjectsIdsChangedEventArgs {
		[Export ("NSDeletedObjectIDsKey")]
		NSSet DeletedObjectIds { get; }

		[Export ("NSInsertedObjectIDsKey")]
		NSSet InsertedObjectIdsKey { get; }

		[Export ("NSInvalidatedObjectIDsKey")]
		NSSet InvalidatedObjectIdsKey { get; }

		[Export ("NSRefreshedObjectIDsKey")]
		NSSet RefreshedObjectIdsKey { get; }

		[Export ("NSUpdatedObjectIDsKey")]
		NSSet UpdatedObjectIdsKey { get; }
	}

	interface NSManagedObjectChangeEventArgs {
		/// <summary>Gets the InsertedObjects value.</summary>
		[Export ("NSInsertedObjectsKey")]
		NSSet InsertedObjects { get; }

		/// <summary>Gets the UpdatedObjects value.</summary>
		[Export ("NSUpdatedObjectsKey")]
		NSSet UpdatedObjects { get; }

		/// <summary>Gets the DeletedObjects value.</summary>
		[Export ("NSDeletedObjectsKey")]
		NSSet DeletedObjects { get; }

		/// <summary>Gets the RefreshedObjects value.</summary>
		[Export ("NSRefreshedObjectsKey")]
		NSSet RefreshedObjects { get; }

		/// <summary>Gets the InvalidatedObjects value.</summary>
		[Export ("NSInvalidatedObjectsKey")]
		NSSet InvalidatedObjects { get; }

		/// <summary>Gets the InvalidatedAllObjects value.</summary>
		[ProbePresence]
		[Export ("NSInvalidatedAllObjectsKey")]
		bool InvalidatedAllObjects { get; }
	}

	/// <summary>A universal identifier of a Core Data managed object. Works across object contexts and applications.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/CoreDataFramework/Classes/NSManagedObjectID_Class/index.html">Apple documentation for <c>NSManagedObjectID</c></related>
	[BaseType (typeof (NSObject))]
	// Objective-C exception thrown.  Name: NSInvalidArgumentException Reason: *** -URIRepresentation cannot be sent to an abstract object of class NSManagedObjectID: Create a concrete instance!
	[DisableDefaultCtor]
	interface NSManagedObjectID : NSCopying, NSFetchRequestResult {

		/// <summary>Gets the Entity value.</summary>
		[Export ("entity", ArgumentSemantic.Strong)]
		NSEntityDescription Entity { get; }

		/// <summary>Gets the PersistentStore value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("persistentStore", ArgumentSemantic.Weak)]
		NSPersistentStore PersistentStore { get; }

		/// <summary>Gets the IsTemporaryID value.</summary>
		[Export ("temporaryID")]
		bool IsTemporaryID { [Bind ("isTemporaryID")] get; }

		/// <summary>Gets the URIRepresentation value.</summary>
		[Export ("URIRepresentation")]
		NSUrl URIRepresentation { get; }

	}

	/// <summary>A schema describing a graph of entities used by the application.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/CoreDataFramework/Classes/NSManagedObjectModel_Class/index.html">Apple documentation for <c>NSManagedObjectModel</c></related>
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // designated
	interface NSManagedObjectModel : NSCoding, NSCopying {

		/// <summary>Default constructor that initializes a new instance of this class with no parameters.</summary>
		/// <remarks>
		///         </remarks>
		[DesignatedInitializer]
		[Export ("init")]
		NativeHandle Constructor ();

		/// <param name="bundles">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Performs the get merged model operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Static, Export ("mergedModelFromBundles:")]
		[return: NullAllowed]
		NSManagedObjectModel GetMergedModel ([NullAllowed] NSBundle [] bundles);

		/// <param name="models">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the model by merging models operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static, Export ("modelByMergingModels:")]
		[return: NullAllowed]
		NSManagedObjectModel ModelByMergingModels ([NullAllowed] NSManagedObjectModel [] models);

		/// <param name="url">The URL.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithContentsOfURL:")]
		NativeHandle Constructor (NSUrl url);

		/// <summary>Performs the Core Data operation.</summary>
		[Export ("entitiesByName", ArgumentSemantic.Copy)]
#if XAMCORE_5_0
		NSDictionary<NSString, NSEntityDescription> EntitiesByName { get; }
#else
		NSDictionary EntitiesByName { get; }
#endif

		/// <summary>Gets or sets the Entities value.</summary>
		[Export ("entities", ArgumentSemantic.Retain)]
		NSEntityDescription [] Entities { get; set; }

		/// <summary>Gets the Configurations value.</summary>
		[Export ("configurations", ArgumentSemantic.Strong)]
		string [] Configurations { get; }

		/// <param name="configuration">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the Core Data operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("entitiesForConfiguration:")]
		[return: NullAllowed]
		string [] EntitiesForConfiguration ([NullAllowed] string configuration);

		/// <param name="entities">The entity descriptions.</param>
		///         <param name="configuration">The configuration name.</param>
		///         <summary>Performs the set entities operation.</summary>
		[Export ("setEntities:forConfiguration:")]
		void SetEntities (NSEntityDescription [] entities, string configuration);

		/// <param name="fetchRequestTemplate">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="name">The name.</param>
		///         <summary>Performs the set fetch request template operation.</summary>
		[Export ("setFetchRequestTemplate:forName:")]
		void SetFetchRequestTemplate ([NullAllowed] NSFetchRequest fetchRequestTemplate, string name);

		[Export ("fetchRequestTemplateForName:")]
		[return: NullAllowed]
		NSFetchRequest GetFetchRequestTemplate (string name);

		[Export ("fetchRequestFromTemplateWithName:substitutionVariables:")]
		[return: NullAllowed]
#if XAMCORE_5_0
		NSFetchRequest GetFetchRequestFromTemplate (string name, NSDictionary<NSString, NSObject> variables);
#else
		NSFetchRequest GetFetchRequestFromTemplate (string name, NSDictionary variables);
#endif

		/// <summary>Performs the Core Data operation.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("localizationDictionary", ArgumentSemantic.Retain)]
#if XAMCORE_5_0
		NSDictionary<NSString, NSString> LocalizationDictionary { get; set; }
#else
		NSDictionary LocalizationDictionary { get; set; }
#endif

		/// <param name="bundles">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="metadata">The metadata dictionary.</param>
		/// <summary>Performs the Core Data operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Static, Export ("mergedModelFromBundles:forStoreMetadata:")]
		[return: NullAllowed]
#if XAMCORE_5_0
		NSManagedObjectModel GetMergedModel ([NullAllowed] NSBundle[] bundles, NSDictionary<NSString, NSObject> metadata);
#else
		NSManagedObjectModel GetMergedModel ([NullAllowed] NSBundle [] bundles, NSDictionary metadata);
#endif

		[Static, Export ("modelByMergingModels:forStoreMetadata:")]
		[return: NullAllowed]
#if XAMCORE_5_0
		NSManagedObjectModel GetModelByMerging (NSManagedObjectModel[] models, NSDictionary<NSString, NSObject> metadata);
#else
		NSManagedObjectModel GetModelByMerging (NSManagedObjectModel [] models, NSDictionary metadata);
#endif

		/// <summary>Performs the Core Data operation.</summary>
		[Export ("fetchRequestTemplatesByName", ArgumentSemantic.Copy)]
#if XAMCORE_5_0
		NSDictionary<NSString, NSFetchRequest> FetchRequestTemplatesByName { get; }
#else
		NSDictionary FetchRequestTemplatesByName { get; }
#endif

		/// <summary>Gets or sets the VersionIdentifiers value.</summary>
		[Export ("versionIdentifiers", ArgumentSemantic.Copy)]
		NSSet VersionIdentifiers { get; set; }

		/// <param name="configuration">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="metadata">The metadata dictionary.</param>
		/// <summary>Performs the Core Data operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("isConfiguration:compatibleWithStoreMetadata:")]
#if XAMCORE_5_0
		bool IsConfigurationCompatibleWithStoreMetadata ([NullAllowed] string configuration, NSDictionary<NSString, NSObject> metadata);
#else
		bool IsConfigurationCompatibleWithStoreMetadata ([NullAllowed] string configuration, NSDictionary metadata);
#endif

		/// <summary>Performs the Core Data operation.</summary>
		[Export ("entityVersionHashesByName", ArgumentSemantic.Copy)]
#if XAMCORE_5_0
		NSDictionary<NSString, NSData> EntityVersionHashesByName { get; }
#else
		NSDictionary EntityVersionHashesByName { get; }
#endif

		[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
		[Static]
		[Export ("checksumsForVersionedModelAtURL:error:")]
		[return: NullAllowed]
		NSDictionary<NSString, NSString> ChecksumsForVersionedModel (NSUrl modelUrl, [NullAllowed] out NSError error);

		[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
		[Export ("versionChecksum")]
		string VersionChecksum { get; }
	}

	/// <summary>Holds mappings between a source and destination managed object model.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/NSMappingModel_class/index.html">Apple documentation for <c>NSMappingModel</c></related>
	[BaseType (typeof (NSObject))]
	interface NSMappingModel {

		[Static, Export ("mappingModelFromBundles:forSourceModel:destinationModel:")]
		[return: NullAllowed]
		NSMappingModel GetMappingModel ([NullAllowed] NSBundle [] bundles, [NullAllowed] NSManagedObjectModel sourceModel, [NullAllowed] NSManagedObjectModel destinationModel);

		/// <param name="source">The source object.</param>
		///         <param name="destination">The destination object.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Performs the get inferred mapping model operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static, Export ("inferredMappingModelForSourceModel:destinationModel:error:")]
		[return: NullAllowed]
		NSMappingModel GetInferredMappingModel (NSManagedObjectModel source, NSManagedObjectModel destination, out NSError error);

		/// <param name="url">The URL.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithContentsOfURL:")]
		NativeHandle Constructor ([NullAllowed] NSUrl url);

		/// <summary>Gets or sets the EntityMappings value.</summary>
		[Export ("entityMappings", ArgumentSemantic.Retain)]
		[NullAllowed]
		NSEntityMapping [] EntityMappings { get; set; }

		/// <summary>Performs the Core Data operation.</summary>
		[Export ("entityMappingsByName", ArgumentSemantic.Copy)]
#if XAMCORE_5_0
		NSDictionary<NSString, NSEntityMapping> EntityMappingsByName { get; }
#else
		NSDictionary EntityMappingsByName { get; }
#endif

	}

	/// <summary>Models conflicts that can occur when saving changes.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreData/Reference/NSMergeConflict_Class/index.html">Apple documentation for <c>NSMergeConflict</c></related>
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NSMergeConflict {
		/// <summary>Gets the SourceObject value.</summary>
		[Export ("sourceObject", ArgumentSemantic.Retain)]
		NSManagedObject SourceObject { get; }

		/// <summary>Performs the Core Data operation.</summary>
		[Export ("objectSnapshot", ArgumentSemantic.Retain)]
		[NullAllowed]
#if XAMCORE_5_0
		NSDictionary<NSString, NSObject> ObjectSnapshot { get; }
#else
		NSDictionary ObjectSnapshot { get; }
#endif

		/// <summary>Performs the Core Data operation.</summary>
		[Export ("cachedSnapshot", ArgumentSemantic.Retain)]
		[NullAllowed]
#if XAMCORE_5_0
		NSDictionary<NSString, NSObject> CachedSnapshot { get; }
#else
		NSDictionary CachedSnapshot { get; }
#endif

		/// <summary>Performs the Core Data operation.</summary>
		[Export ("persistedSnapshot", ArgumentSemantic.Retain)]
		[NullAllowed]
#if XAMCORE_5_0
		NSDictionary<NSString, NSObject> PersistedSnapshot { get; }
#else
		NSDictionary PersistedSnapshot { get; }
#endif

		/// <summary>Gets the NewVersionNumber value.</summary>
		[Export ("newVersionNumber")]
		nuint NewVersionNumber { get; }

		/// <summary>Gets the OldVersionNumber value.</summary>
		[Export ("oldVersionNumber")]
		nuint OldVersionNumber { get; }

		/// <param name="sourceObject">The source object.</param>
		/// <param name="newVersion">The new version.</param>
		/// <param name="oldVersion">The old version.</param>
		/// <param name="cachedSnapshot">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="persistedSnapshot">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Performs the Core Data operation.</summary>
		[DesignatedInitializer]
		[Export ("initWithSource:newVersion:oldVersion:cachedSnapshot:persistedSnapshot:")]
#if XAMCORE_5_0
		NativeHandle Constructor (NSManagedObject sourceObject, nuint newVersion, nuint oldVersion, [NullAllowed] NSDictionary<NSString, NSObject> cachedSnapshot, [NullAllowed] NSDictionary<NSString, NSObject> persistedSnapshot);
#else
		NativeHandle Constructor (NSManagedObject sourceObject, nuint newVersion, nuint oldVersion, [NullAllowed] NSDictionary cachedSnapshot, [NullAllowed] NSDictionary persistedSnapshot);
#endif
	}

	/// <summary>Strategy for resolving conflicts between in-memory objects and those in persistent stores.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreData/Reference/NSMergePolicy_Class/index.html">Apple documentation for <c>NSMergePolicy</c></related>
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NSMergePolicy {
		/// <summary>Gets the policy's merge type.</summary>
		[Export ("mergeType")]
		NSMergePolicyType MergeType { get; }

		/// <param name="ty">The argument type.</param>
		/// <summary>Creates a new <see cref="CoreData.NSMergePolicy" /> from the specified merege policy type.</summary>
		[DesignatedInitializer]
		[Export ("initWithMergeType:")]
		NativeHandle Constructor (NSMergePolicyType ty);

		/// <param name="list">The array of expressions.</param>
		/// <param name="error">The error, or null if none.</param>
		/// <summary>Attempts to resolve the specified conflicts, and reports any errors.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("resolveConflicts:error:")]
		bool ResolveConflicts (NSMergeConflict [] list, out NSError error);

		/// <param name="list">The array of expressions.</param>
		///         <param name="error">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Attempts to resolve the specified locking constraint conflicts, and reports any errors.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("resolveOptimisticLockingVersionConflicts:error:")]
		bool ResolveOptimisticLockingVersionConflicts (NSMergeConflict [] list, out NSError error);

		/// <param name="list">The array of expressions.</param>
		///         <param name="error">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Attempts to resolve the specified constraint conflicts, and reports any errors.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("resolveConstraintConflicts:error:")]
		bool ResolveConstraintConflicts (NSConstraintConflict [] list, out NSError error);

		/// <summary>Gets a value that indicates that saving will fail if an error is encountered.</summary>
		[MacCatalyst (13, 1)]
		[Static, Export ("errorMergePolicy", ArgumentSemantic.Strong)]
		NSMergePolicy ErrorPolicy { get; }

		/// <summary>Gets a value that indicates tha in-memory state changes are discarded for conflicting objects.</summary>
		[MacCatalyst (13, 1)]
		[Static, Export ("rollbackMergePolicy", ArgumentSemantic.Strong)]
		NSMergePolicy RollbackPolicy { get; }

		/// <summary>Gets a value that controls policy for handling overwrites.</summary>
		[MacCatalyst (13, 1)]
		[Static, Export ("overwriteMergePolicy", ArgumentSemantic.Strong)]
		NSMergePolicy OverwritePolicy { get; }

		/// <summary>Gets a value that indicates that the property object is favored during merges.</summary>
		[MacCatalyst (13, 1)]
		[Static, Export ("mergeByPropertyObjectTrumpMergePolicy", ArgumentSemantic.Strong)]
		NSMergePolicy MergeByPropertyObjectTrumpPolicy { get; }

		/// <summary>Gets a value that indicates that the property store is favored during merges.</summary>
		[MacCatalyst (13, 1)]
		[Static, Export ("mergeByPropertyStoreTrumpMergePolicy", ArgumentSemantic.Strong)]
		NSMergePolicy MergeByPropertyStoreTrumpPolicy { get; }
	}

	/// <summary>Allows migration from one persistent store to another.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/NSMigrationManager_class/index.html">Apple documentation for <c>NSMigrationManager</c></related>
	[BaseType (typeof (NSObject))]
	interface NSMigrationManager {

		/// <param name="sourceModel">The source model.</param>
		/// <param name="destinationModel">The destination model.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithSourceModel:destinationModel:")]
		NativeHandle Constructor (NSManagedObjectModel sourceModel, NSManagedObjectModel destinationModel);

		/// <param name="sourceUrl">The source store URL.</param>
		///         <param name="sStoreType">The source store type.</param>
		///         <param name="sOptions">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="mappings">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="dUrl">The destination URL.</param>
		///         <param name="dStoreType">The destination store type.</param>
		///         <param name="dOptions">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Performs the migrate store from url operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("migrateStoreFromURL:type:options:withMappingModel:toDestinationURL:destinationType:destinationOptions:error:")]
		bool MigrateStoreFromUrl (NSUrl sourceUrl, string sStoreType, [NullAllowed] NSDictionary sOptions, [NullAllowed] NSMappingModel mappings, NSUrl dUrl, string dStoreType, [NullAllowed] NSDictionary dOptions, out NSError error);

		/// <summary>Performs the reset operation.</summary>
		[Export ("reset")]
		void Reset ();

		/// <summary>Gets the MappingModel value.</summary>
		[Export ("mappingModel", ArgumentSemantic.Strong)]
		NSMappingModel MappingModel { get; }

		/// <summary>Gets the SourceModel value.</summary>
		[Export ("sourceModel", ArgumentSemantic.Strong)]
		NSManagedObjectModel SourceModel { get; }

		/// <summary>Gets the DestinationModel value.</summary>
		[Export ("destinationModel", ArgumentSemantic.Strong)]
		NSManagedObjectModel DestinationModel { get; }

		/// <summary>Gets the SourceContext value.</summary>
		[Export ("sourceContext", ArgumentSemantic.Strong)]
		NSManagedObjectContext SourceContext { get; }

		/// <summary>Gets the DestinationContext value.</summary>
		[Export ("destinationContext", ArgumentSemantic.Strong)]
		NSManagedObjectContext DestinationContext { get; }

		/// <param name="mEntity">The entity description.</param>
		///         <summary>Performs the source entity for entity mapping operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("sourceEntityForEntityMapping:")]
		[return: NullAllowed]
		NSEntityDescription SourceEntityForEntityMapping (NSEntityMapping mEntity);

		/// <param name="mEntity">The entity description.</param>
		///         <summary>Performs the destination entity for entity mapping operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("destinationEntityForEntityMapping:")]
		[return: NullAllowed]
		NSEntityDescription DestinationEntityForEntityMapping (NSEntityMapping mEntity);

		/// <param name="sourceInstance">The source instance.</param>
		///         <param name="destinationInstance">The destination instance.</param>
		///         <param name="entityMapping">The entity mapping.</param>
		///         <summary>Performs the associate source instance operation.</summary>
		[Export ("associateSourceInstance:withDestinationInstance:forEntityMapping:")]
		void AssociateSourceInstance (NSManagedObject sourceInstance, NSManagedObject destinationInstance, NSEntityMapping entityMapping);

		/// <param name="mappingName">The mapping name.</param>
		///         <param name="sourceInstances">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the Core Data operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("destinationInstancesForEntityMappingNamed:sourceInstances:")]
		NSManagedObject [] DestinationInstancesForEntityMappingNamed (string mappingName, [NullAllowed] NSManagedObject [] sourceInstances);

		/// <param name="mappingName">The mapping name.</param>
		///         <param name="destinationInstances">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the Core Data operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("sourceInstancesForEntityMappingNamed:destinationInstances:")]
		NSManagedObject [] SourceInstancesForEntityMappingNamed (string mappingName, [NullAllowed] NSManagedObject [] destinationInstances);

		/// <summary>Gets the CurrentEntityMapping value.</summary>
		[Export ("currentEntityMapping", ArgumentSemantic.Strong)]
		NSEntityMapping CurrentEntityMapping { get; }

		/// <summary>Gets the MigrationProgress value.</summary>
		[Export ("migrationProgress")]
		float MigrationProgress { get; }  /* float, not CGFloat */

		/// <summary>Gets or sets the UserInfo value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("userInfo", ArgumentSemantic.Retain)]
		NSDictionary UserInfo { get; set; }

		/// <param name="error">The error, or null if none.</param>
		///         <summary>Performs the cancel migration with error operation.</summary>
		[Export ("cancelMigrationWithError:")]
		void CancelMigrationWithError (NSError error);

		// 5.0
		/// <summary>Gets or sets the UsesStoreSpecificMigrationManager value.</summary>
		[Export ("usesStoreSpecificMigrationManager")]
		bool UsesStoreSpecificMigrationManager { get; set; }
	}

	[Abstract]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NSPersistentHistoryChange : NSCopying {
		/// <summary>Gets the ChangeId value.</summary>
		[Export ("changeID")]
		long ChangeId { get; }

		/// <summary>Gets the ChangedObjectId value.</summary>
		[Export ("changedObjectID", ArgumentSemantic.Copy)]
		NSManagedObjectID ChangedObjectId { get; }

		/// <summary>Gets the ChangeType value.</summary>
		[Export ("changeType")]
		NSPersistentHistoryChangeType ChangeType { get; }

		/// <summary>Gets the Tombstone value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("tombstone", ArgumentSemantic.Copy)]
		NSDictionary Tombstone { get; }

		/// <summary>Gets the Transaction value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("transaction", ArgumentSemantic.Strong)]
		NSPersistentHistoryTransaction Transaction { get; }

		/// <summary>Gets the UpdatedProperties value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("updatedProperties", ArgumentSemantic.Copy)]
		NSSet<NSPropertyDescription> UpdatedProperties { get; }

		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Static]
		[NullAllowed, Export ("entityDescription")]
		NSEntityDescription EntityDescription { get; }

		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Static]
		[NullAllowed, Export ("fetchRequest")]
		NSFetchRequest FetchRequest { get; }

		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("entityDescriptionWithContext:")]
		[return: NullAllowed]
		NSEntityDescription GetEntityDescription (NSManagedObjectContext context);
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NSPersistentHistoryToken : NSCopying //, NSSecureCoding TODO: The class does state that it supports the NSSecureCoding YET SupportsSecureCoding returns false, radar 32761925
	{
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSPersistentStoreRequest))]
	[DisableDefaultCtor]
	interface NSPersistentHistoryChangeRequest {
		/// <param name="date">The date.</param>
		///         <summary>Performs the fetch history after operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("fetchHistoryAfterDate:")]
		NSPersistentHistoryChangeRequest FetchHistoryAfter (NSDate date);

		/// <param name="token">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the fetch history after operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("fetchHistoryAfterToken:")]
		NSPersistentHistoryChangeRequest FetchHistoryAfter ([NullAllowed] NSPersistentHistoryToken token);

		/// <param name="transaction">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the fetch history after operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("fetchHistoryAfterTransaction:")]
		NSPersistentHistoryChangeRequest FetchHistoryAfter ([NullAllowed] NSPersistentHistoryTransaction transaction);

		/// <param name="date">The date.</param>
		///         <summary>Performs the delete history before operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("deleteHistoryBeforeDate:")]
		NSPersistentHistoryChangeRequest DeleteHistoryBefore (NSDate date);

		/// <param name="token">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the delete history before operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("deleteHistoryBeforeToken:")]
		NSPersistentHistoryChangeRequest DeleteHistoryBefore ([NullAllowed] NSPersistentHistoryToken token);

		/// <param name="transaction">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the delete history before operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("deleteHistoryBeforeTransaction:")]
		NSPersistentHistoryChangeRequest DeleteHistoryBefore ([NullAllowed] NSPersistentHistoryTransaction transaction);

		/// <summary>Gets or sets the ResultType value.</summary>
		[Export ("resultType", ArgumentSemantic.Assign)]
		NSPersistentHistoryResultType ResultType { get; set; }

		/// <summary>Gets the Token value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("token", ArgumentSemantic.Strong)]
		NSPersistentHistoryToken Token { get; }

		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("fetchHistoryWithFetchRequest:")]
		NSPersistentHistoryChangeRequest FetchHistory (NSFetchRequest fetchRequest);

		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("fetchRequest", ArgumentSemantic.Strong)]
		NSFetchRequest FetchRequest { get; set; }
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSPersistentStoreResult))]
	interface NSPersistentHistoryResult {
		/// <summary>Gets the Result value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("result", ArgumentSemantic.Strong)]
		NSObject Result { get; }

		/// <summary>Gets the ResultType value.</summary>
		[Export ("resultType")]
		NSPersistentHistoryResultType ResultType { get; }
	}

	[Abstract]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NSPersistentHistoryTransaction : NSCopying {
		/// <summary>Gets the Timestamp value.</summary>
		[Export ("timestamp", ArgumentSemantic.Copy)]
		NSDate Timestamp { get; }

		/// <summary>Gets the Changes value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("changes", ArgumentSemantic.Copy)]
		NSPersistentHistoryChange [] Changes { get; }

		/// <summary>Gets the TransactionNumber value.</summary>
		[Export ("transactionNumber")]
		long TransactionNumber { get; }

		/// <summary>Gets the StoreId value.</summary>
		[Export ("storeID")]
		string StoreId { get; }

		/// <summary>Gets the BundleId value.</summary>
		[Export ("bundleID")]
		string BundleId { get; }

		/// <summary>Gets the ProcessId value.</summary>
		[Export ("processID")]
		string ProcessId { get; }

		/// <summary>Gets the ContextName value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("contextName")]
		string ContextName { get; }

		/// <summary>Gets the Author value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("author")]
		string Author { get; }

		/// <summary>Gets the Token value.</summary>
		[Export ("token", ArgumentSemantic.Strong)]
		NSPersistentHistoryToken Token { get; }

		/// <summary>Gets the ObjectIdNotification value.</summary>
		[Export ("objectIDNotification")]
		NSNotification ObjectIdNotification { get; }

		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("entityDescriptionWithContext:")]
		[return: NullAllowed]
		NSEntityDescription GetEntityDescription (NSManagedObjectContext context);

		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Static]
		[NullAllowed, Export ("entityDescription")]
		NSEntityDescription EntityDescription { get; }

		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Static]
		[NullAllowed, Export ("fetchRequest")]
		NSFetchRequest FetchRequest { get; }
	}

	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // NSInternalInconsistencyException Reason: NSCoreDataCoreSpotlightDelegate requires the use of the initializer initForStoreWithDescription:model: 
	interface NSCoreDataCoreSpotlightDelegate {

		[Notification]
		[iOS (15, 0), MacCatalyst (15, 0)]
		[Field ("NSCoreDataCoreSpotlightDelegateIndexDidUpdateNotification")]
		NSString IndexDidUpdateNotification { get; }

		[iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("initForStoreWithDescription:coordinator:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSPersistentStoreDescription description, NSPersistentStoreCoordinator psc);

		/// <summary>Gets the DomainIdentifier value.</summary>
		[Export ("domainIdentifier")]
		string DomainIdentifier { get; }

		/// <summary>Gets the IndexName value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("indexName")]
		string IndexName { get; }

		/// <param name="description">The persistent store description.</param>
		/// <param name="model">The managed object model.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Deprecated (PlatformName.iOS, 15, 0, message: "Use the constructor that takes a NSPersistentStoreCoordinator instead.")]
		[Deprecated (PlatformName.MacOSX, 12, 0, message: "Use the constructor that takes a NSPersistentStoreCoordinator instead.")]
		[Deprecated (PlatformName.MacCatalyst, 15, 0, message: "Use the constructor that takes a NSPersistentStoreCoordinator instead.")]
		[Export ("initForStoreWithDescription:model:")]
		NativeHandle Constructor (NSPersistentStoreDescription description, NSManagedObjectModel model);

		/// <param name="object">The managed object.</param>
		///         <summary>Performs the get attribute set operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("attributeSetForObject:")]
		[return: NullAllowed]
		CSSearchableItemAttributeSet GetAttributeSet (NSManagedObject @object);

		/// <param name="searchableIndex">The searchable index.</param>
		///         <param name="acknowledgementHandler">The acknowledgement handler.</param>
		///         <summary>Performs the reindex all searchable items operation.</summary>
		[Export ("searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:")]
		void ReindexAllSearchableItems (CSSearchableIndex searchableIndex, Action acknowledgementHandler);

		/// <param name="searchableIndex">The searchable index.</param>
		///         <param name="identifiers">The identifiers.</param>
		///         <param name="acknowledgementHandler">The acknowledgement handler.</param>
		///         <summary>Performs the reindex searchable items operation.</summary>
		[Export ("searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:")]
		void ReindexSearchableItems (CSSearchableIndex searchableIndex, string [] identifiers, Action acknowledgementHandler);

		[Async]
		[NoTV, iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("deleteSpotlightIndexWithCompletionHandler:")]
		void DeleteSpotlightIndex (Action<NSError> completionHandler);

		[NoTV, iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("indexingEnabled")]
		bool IndexingEnabled { [Bind ("isIndexingEnabled")] get; }

		[NoTV, iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("startSpotlightIndexing")]
		void StartSpotlightIndexing ();

		[NoTV, iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("stopSpotlightIndexing")]
		void StopSpotlightIndexing ();
	}

	// NSPersistentStore is an abstract type according to Apple's documentation, but Apple
	// also have internal subclasses of NSPersistentStore, and in those cases our closest
	// type is NSPersistentStore, which means we must be able to create managed wrappers
	// for such native classes using the managed NSPersistentStore. This means we can't
	// make our managed version [Abstract].
	/// <summary>Abstract base class for Core DatAPersistent stores.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/NSPersistentStore_Class/index.html">Apple documentation for <c>NSPersistentStore</c></related>
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NSPersistentStore {

		/// <summary>Gets the MigrationManagerClass value.</summary>
		[Static]
		[Export ("migrationManagerClass")]
		Class MigrationManagerClass { get; }

		/// <param name="url">The URL.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Gets the metadata for the store at the provided URL.</summary>
		///         <returns>The result of the operation.</returns>
		[Static, Export ("metadataForPersistentStoreWithURL:error:")]
		[return: NullAllowed]
#if XAMCORE_5_0
		NSDictionary<NSString, NSObject> GetMetadataForPersistentStore (NSUrl url, out NSError error);
#else
		NSDictionary MetadataForPersistentStoreWithUrl (NSUrl url, out NSError error);
#endif

		/// <param name="metadata">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="url">The URL.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Sets the metadata for the store at the provided URL.</summary>
		///         <returns>The result of the operation.</returns>
		[Static, Export ("setMetadata:forPersistentStoreWithURL:error:")]
#if XAMCORE_5_0
		bool SetMetadata ([NullAllowed] NSDictionary<NSString, NSObject> metadata, NSUrl url, out NSError error);
#else
		bool SetMetadata ([NullAllowed] NSDictionary metadata, NSUrl url, out NSError error);
#endif

		/// <param name="root">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="name">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="url">The URL.</param>
		/// <param name="options">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Protected]
		[DesignatedInitializer]
		[Export ("initWithPersistentStoreCoordinator:configurationName:URL:options:")]
		NativeHandle Constructor ([NullAllowed] NSPersistentStoreCoordinator root, [NullAllowed] string name, NSUrl url, [NullAllowed] NSDictionary options);

		/// <param name="error">The error that was encountered, or <see langword="null" /> if no error was encountered.</param>
		///         <summary>Causes the store to load its metadata.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("loadMetadata:")]
		bool LoadMetadata (out NSError error);

		/// <summary>Gets the coordinator to which this store belongs, if present.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("persistentStoreCoordinator", ArgumentSemantic.Weak)]
		NSPersistentStoreCoordinator PersistentStoreCoordinator { get; }

		/// <summary>Gets the managed object model configuration name for the configuration that was used to create the store.</summary>
		[Export ("configurationName")]
		string ConfigurationName { get; }

		/// <summary>Gets the options with which the store was initialized.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("options", ArgumentSemantic.Strong)]
		NSDictionary Options { get; }

		/// <summary>Gets or sets the URL of the store.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("URL", ArgumentSemantic.Retain)]
		NSUrl Url { get; set; }

		/// <summary>Gets the unique identifier for this store.</summary>
		[Export ("identifier")]
		[NullAllowed]
		string Identifier { get; set; }

		/// <summary>Application developers override this method to provide a unique store type to use when adding the store to the store coordinator.</summary>
		[Export ("type")]
		string Type { get; }

		/// <summary>Gets or sets the read-only status of the store</summary>
		[Export ("readOnly")]
		bool ReadOnly { [Bind ("isReadOnly")] get; set; }

		/// <summary>Gets or sets the store metadata.</summary>
		[Export ("metadata", ArgumentSemantic.Retain)]
		[NullAllowed]
#if XAMCORE_5_0
		NSDictionary<NSString, NSObject> Metadata { get; set; }
#else
		NSDictionary Metadata { get; set; }
#endif

		/// <param name="coordinator">The persistent store coordinator.</param>
		///         <summary>Method that is called when this store is added to the store coordinator.</summary>
		[Export ("didAddToPersistentStoreCoordinator:")]
		void DidAddToPersistentStoreCoordinator (NSPersistentStoreCoordinator coordinator);

		/// <param name="coordinator">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Method that is called when the store is about to be removed from the coordinator.</summary>
		[Export ("willRemoveFromPersistentStoreCoordinator:")]
		void WillRemoveFromPersistentStoreCoordinator ([NullAllowed] NSPersistentStoreCoordinator coordinator);

		/// <summary>Represents the value associated with the constant NSPersistentStoreSaveConflictsErrorKey</summary>
		///         <value>
		///         </value>
		[Field ("NSPersistentStoreSaveConflictsErrorKey")]
		NSString SaveConflictsErrorKey { get; }

		/// <summary>Gets the spotlight exporter for the store.</summary>
		[NoTV]
		[MacCatalyst (13, 1)]
		[Export ("coreSpotlightExporter")]
		NSCoreDataCoreSpotlightDelegate CoreSpotlightExporter { get; }

		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("NSPersistentStoreRemoteChangeNotificationPostOptionKey")]
		NSString RemoteChangeNotificationPostOptionKey { get; }

		[Notification (typeof (NSPersistentStoreRemoteChangeEventArgs))]
		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("NSPersistentStoreRemoteChangeNotification")]
		NSString StoreRemoteChangeNotification { get; }

	}

	interface NSPersistentStoreRemoteChangeEventArgs {
		[Export ("NSStoreUUIDKey")]
		NSUuid Uuid { get; }

		[Export ("NSPersistentStoreURLKey")]
		string Url { get; }

		[Export ("NSPersistentHistoryTokenKey")]
		NSPersistentHistoryToken PersistentHistoryTracking { get; }
	}

	/// <summary>Descriptor for APersistent store inside APersistent container.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/CoreData/NSPersistentStoreDescription">Apple documentation for <c>NSPersistentStoreDescription</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NSPersistentStoreDescription : NSCopying {
		/// <param name="Url">The store URL for which to get a description.</param>
		///         <summary>Returns the description for the store at the specified URL.</summary>
		///         <returns>The description for the store at the specified URL.</returns>
		[Static]
		[Export ("persistentStoreDescriptionWithURL:")]
		NSPersistentStoreDescription GetPersistentStoreDescription (NSUrl Url);

		/// <summary>Gets or sets the store type.</summary>
		///         <value>The store type.</value>
		///         <remarks>
		///           <para>
		///             <see cref="CoreData.NSPersistentStoreCoordinator" /> contains static properties that represent valid store types.</para>
		///         </remarks>
		[Export ("type")]
		string Type { get; set; }

		/// <summary>Gets or sets the configuration that is used by the store.</summary>
		///         <value>
		///           <para>The configuration that is used by the store.</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("configuration")]
		string Configuration { get; set; }

		/// <summary>Gets or sets the URL for the store.</summary>
		///         <value>
		///           <para>The URL for the store.</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("URL", ArgumentSemantic.Copy)]
		NSUrl Url { get; set; }

		/// <summary>Gets the dictionary of options for the store.</summary>
		///         <value>The dictionary of options for the store.</value>
		///         <remarks>
		///           <para>
		///             <see cref="CoreData.NSPersistentStoreCoordinator" /> contains static properties that represent the option keys that are valid for this dictionary.</para>
		///         </remarks>
		[Export ("options", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Options { get; }

		/// <param name="option">
		///           <para>The value of the option to set.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="key">The key for the value to set.</param>
		///         <summary>Sets the option for the specified <paramref name="key" />.</summary>
		///         <remarks>
		///           <para>
		///             <see cref="CoreData.NSPersistentStoreCoordinator" /> contains static properties that represent the option keys that are valid for this dictionary.</para>
		///         </remarks>
		[Export ("setOption:forKey:")]
		void SetOption ([NullAllowed] NSObject option, string key);

		/// <summary>Gets or sets a value that tells whether the store is read-only.</summary>
		///         <value>
		///           <see langword="true" /> if the store is read-only. Otherwise, <see langword="false" />.</value>
		[Export ("readOnly")]
		bool IsReadOnly { [Bind ("isReadOnly")] get; set; }

		/// <summary>Gets or sets the connection timeout interval.</summary>
		///         <value>The connection timeout interval.</value>
		[Export ("timeout")]
		double Timeout { get; set; }

		/// <summary>Gets the SQLite pragmas for the store.</summary>
		///         <value>The SQLite pragmas for the store.</value>
		[Export ("sqlitePragmas", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> SqlitePragmas { get; }

		/// <param name="value">
		///           <para>The value to set.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="name">The name.</param>
		///         <summary>Sets the value for the specified option <paramref name="name" />.</summary>
		[Export ("setValue:forPragmaNamed:")]
		void SetValue ([NullAllowed] NSObject value, string name);

		/// <summary>Gets or sets a value that controls whether the store is added on the calling thread or on a background thread.</summary>
		///         <value>
		///           <see langword="false" />, the default value, to load the store on the main thread. <see langword="true" /> to load the store on a background thread.</value>
		[Export ("shouldAddStoreAsynchronously")]
		bool ShouldAddStoreAsynchronously { get; set; }

		/// <summary>Gets or sets a value that controls whether the persistent store should be automatically migrated.</summary>
		///         <value>
		///           <see langword="true" /> to indicate that the store should be migrated. Otherwise, <see langword="false" />.</value>
		[Export ("shouldMigrateStoreAutomatically")]
		bool ShouldMigrateStoreAutomatically { get; set; }

		/// <summary>Gets or sets a value that controls whether the coordinator will attempt to create a mapping model by inspecting the schemas to be mapped.</summary>
		///         <value>
		///           <see langword="true" /> to indicate that the coordinator should attempt to create a mapping model. Otherwise, <see langword="false" />.</value>
		[Export ("shouldInferMappingModelAutomatically")]
		bool ShouldInferMappingModelAutomatically { get; set; }

		/// <param name="url">The url for the persistent store.</param>
		/// <summary>Creates APersistent store description with the specified store URL.</summary>
		[Export ("initWithURL:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSUrl url);

		// NSPersistentStoreDescription_NSPersistentCloudKitContainerAdditions category
		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("cloudKitContainerOptions", ArgumentSemantic.Strong)]
		NSPersistentCloudKitContainerOptions CloudKitContainerOptions { get; set; }
	}

	/// <summary>Creates and manages a Core Data stack.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/CoreData/NSPersistentContainer">Apple documentation for <c>NSPersistentContainer</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NSPersistentContainer {
		/// <param name="name">The name of the persistent container to create.</param>
		///         <summary>Creates APersistent container with the specified name.</summary>
		///         <returns>A persistent container with the specified name.</returns>
		[Static]
		[Export ("persistentContainerWithName:")]
		NSPersistentContainer GetPersistentContainer (string name);

		/// <param name="name">The name of the persistent container to create.</param>
		///         <param name="model">The object model for the persistent container to create.</param>
		///         <summary>Creates APersistent container with the specified name and object model.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("persistentContainerWithName:managedObjectModel:")]
		NSPersistentContainer GetPersistentContainer (string name, NSManagedObjectModel model);

		/// <summary>Gets the platform's default directory for persistent stores.</summary>
		///         <value>The platform's default directory for persistent stores..</value>
		[Static]
		[Export ("defaultDirectoryURL")]
		NSUrl DefaultDirectoryUrl { get; }

		/// <summary>Gets the name of the persistent container.</summary>
		///         <value>The name of the persistent container.</value>
		[Export ("name")]
		string Name { get; }

		/// <summary>Gets the managed object context for the main queue.</summary>
		///         <value>The managed object context for the main queue.</value>
		[Export ("viewContext", ArgumentSemantic.Strong)]
		NSManagedObjectContext ViewContext { get; }

		/// <summary>Gets the managed object model for the persistent container.</summary>
		///         <value>The managed object model for the persistent container.</value>
		[Export ("managedObjectModel", ArgumentSemantic.Strong)]
		NSManagedObjectModel ManagedObjectModel { get; }

		/// <summary>Gets the coordinator for this persistent container.</summary>
		///         <value>The coordinator for this persistent container.</value>
		[Export ("persistentStoreCoordinator", ArgumentSemantic.Strong)]
		NSPersistentStoreCoordinator PersistentStoreCoordinator { get; }

		/// <summary>Gets an array that contains the descriptions of the persistent stores in this persistent container.</summary>
		///         <value>An array that contains the descriptions of the persistent stores in this persistent container.</value>
		[Export ("persistentStoreDescriptions", ArgumentSemantic.Copy)]
		NSPersistentStoreDescription [] PersistentStoreDescriptions { get; set; }

		/// <param name="name">The name for the Core Data stack manager.</param>
		/// <summary>Creates a new Core Data stack manager with the specified name.</summary>
		[Export ("initWithName:")]
		NativeHandle Constructor (string name);

		/// <param name="name">The name for the Core Data stack manager.</param>
		/// <param name="model">The managed object model to use.</param>
		/// <summary>Creates a new Core Data stack manager with the specified name and managed object model.</summary>
		[Export ("initWithName:managedObjectModel:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string name, NSManagedObjectModel model);

		/// <param name="block">A completion handler that takes a <see cref="CoreData.NSPersistentStoreDescription" /> and an error in which to store any errors that were encountered while attempting to load the stores.</param>
		///         <summary>Loads the persistent stores in the container and runs a completion handler when finished.</summary>
		[Export ("loadPersistentStoresWithCompletionHandler:")]
		[Async (XmlDocs = """
			<summary>Loads the persistent stores in the container and runs a completion handler when finished.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous LoadPersistentStores operation.  The value of the TResult parameter is of type System.Action&lt;CoreData.NSPersistentStoreDescription,Foundation.NSError&gt;.</para>
			        </returns>
			<remarks>
			          <para copied="true">The LoadPersistentStoresAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		void LoadPersistentStores (Action<NSPersistentStoreDescription, NSError> block);

		/// <summary>Creates and returns APrivate managed object context.</summary>
		///         <value>A private managed object context.</value>
		[Export ("newBackgroundContext")]
		NSManagedObjectContext NewBackgroundContext { get; }

		/// <param name="block">The code to perform.</param>
		///         <summary>Performs background task that is represented by <paramref name="block" /> on the managed object context that was passed to it.</summary>
		[Export ("performBackgroundTask:")]
		void Perform (Action<NSManagedObjectContext> block);
	}

	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // iOS8 -> Core Data: warning: client failed to call designated initializer on NSPersistentStoreCoordinator
	partial interface NSPersistentStoreCoordinator
#if !TVOS
		: NSLocking
#endif // !TVOS
	{

		/// <summary>Performs the Core Data operation.</summary>
		[Static, Export ("registeredStoreTypes", ArgumentSemantic.Strong)]
#if XAMCORE_5_0
		NSDictionary<NSString, NSValue> RegisteredStoreTypes { get; }
#else
		NSDictionary RegisteredStoreTypes { get; }
#endif

		/// <param name="storeClass">The store class.</param>
		///         <param name="storeType">The store type.</param>
		///         <summary>Performs the register store class operation.</summary>
		[Static, Export ("registerStoreClass:forStoreType:")]
		void RegisterStoreClass ([NullAllowed] Class storeClass, NSString storeType);

		/// <param name="storeType">The store type.</param>
		///         <param name="url">The URL.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Performs the metadata for persistent store of type operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use the method that takes an out NSError parameter.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use the method that takes an out NSError parameter.")]
		[Deprecated (PlatformName.MacOSX, 10, 11, message: "Use the method that takes an out NSError parameter.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use the method that takes an out NSError parameter.")]
		[Static, Export ("metadataForPersistentStoreOfType:URL:error:")]
		[return: NullAllowed]
		NSDictionary MetadataForPersistentStoreOfType ([NullAllowed] NSString storeType, NSUrl url, out NSError error);

		/// <param name="storeType">The store type.</param>
		///         <param name="url">The URL.</param>
		///         <param name="options">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Gets the metadata for the store at a URL.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Static, Export ("metadataForPersistentStoreOfType:URL:options:error:")]
		[return: NullAllowed]
		NSDictionary<NSString, NSObject> GetMetadata (string storeType, NSUrl url, [NullAllowed] NSDictionary options, out NSError error);

		/// <param name="metadata">The metadata dictionary.</param>
		///         <param name="storeType">The store type.</param>
		///         <param name="url">The URL.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Sets the metadata for APersistent store at a URL.</summary>
		///         <returns>The result of the operation.</returns>
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use the method that takes an 'out NSError' parameter.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use the method that takes an 'out NSError' parameter.")]
		[Deprecated (PlatformName.MacOSX, 10, 11, message: "Use the method that takes an 'out NSError' parameter.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use the method that takes an 'out NSError' parameter.")]
		[Static, Export ("setMetadata:forPersistentStoreOfType:URL:error:")]
		bool SetMetadata ([NullAllowed] NSDictionary metadata, [NullAllowed] NSString storeType, NSUrl url, out NSError error);

		/// <param name="metadata">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="storeType">The store type.</param>
		///         <param name="url">The URL.</param>
		///         <param name="options">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Sets the metadata for APersistent store at a URL..</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Static, Export ("setMetadata:forPersistentStoreOfType:URL:options:error:")]
		bool SetMetadata ([NullAllowed] NSDictionary<NSString, NSObject> metadata, string storeType, NSUrl url, [NullAllowed] NSDictionary options, out NSError error);

		/// <summary>Returns a cached managed object model for the persistent store at the specified URL, if one exists.</summary>
		/// <param name="url">The URL of the persistent store.</param>
		/// <param name="options">
		///   <para>Options for accessing the persistent store.</para>
		///   <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		/// </param>
		/// <param name="error">
		///   <para>On output, contains an error object if an error occurred.</para>
		///   <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		/// </param>
		/// <returns>The cached <see cref="NSManagedObjectModel" /> for the persistent store, or <see langword="null" /> if no cached model exists.</returns>
		[TV (26, 4), Mac (26, 4), iOS (26, 4), MacCatalyst (26, 4)]
		[Static]
		[Export ("cachedModelForPersistentStoreAtURL:options:error:")]
		[return: NullAllowed]
		NSManagedObjectModel GetCachedModel (NSUrl url, [NullAllowed] NSDictionary options, [NullAllowed] out NSError error);

		/// <param name="metadata">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="store">The persistent store.</param>
		///         <summary>Sets the metadata for APersistent store.</summary>
		[Export ("setMetadata:forPersistentStore:")]
#if XAMCORE_5_0
		void SetMetadata ([NullAllowed] NSDictionary<NSString, NSObject> metadata, NSPersistentStore store);
#else
		void SetMetadata ([NullAllowed] NSDictionary metadata, NSPersistentStore store);
#endif

		[Export ("metadataForPersistentStore:")]
#if XAMCORE_5_0
		NSDictionary<NSString, NSObject> GetMetadata (NSPersistentStore store);
#else
		NSDictionary GetMetadata (NSPersistentStore store);
#endif

		[DesignatedInitializer]
		[Export ("initWithManagedObjectModel:")]
		NativeHandle Constructor (NSManagedObjectModel model);

		/// <summary>Gets the managed object model for the receiver.</summary>
		[Export ("managedObjectModel", ArgumentSemantic.Strong)]
		NSManagedObjectModel ManagedObjectModel { get; }

		/// <summary>Gets an array that contains the receiver's persistent stores.</summary>
		[Export ("persistentStores", ArgumentSemantic.Strong)]
		NSPersistentStore [] PersistentStores { get; }

		/// <param name="url">The URL.</param>
		///         <summary>Returns the persistent store at <paramref name="url" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("persistentStoreForURL:")]
		[return: NullAllowed]
		NSPersistentStore PersistentStoreForUrl (NSUrl url);

		/// <param name="store">The persistent store.</param>
		///         <summary>Returns the URL for the specified <paramref name="store" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("URLForPersistentStore:")]
		NSUrl UrlForPersistentStore (NSPersistentStore store);

		/// <param name="url">The URL.</param>
		///         <param name="store">The persistent store.</param>
		///         <summary>Sets the URL for the specfied <paramref name="store" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("setURL:forPersistentStore:")]
		bool SetUrl (NSUrl url, NSPersistentStore store);

		[Export ("addPersistentStoreWithType:configuration:URL:options:error:")]
		[return: NullAllowed]
		NSPersistentStore AddPersistentStore (NSString storeType, [NullAllowed] string configuration, [NullAllowed] NSUrl storeUrl, [NullAllowed] NSDictionary options, out NSError error);

		/// <param name="storeDescription">The persistent store description.</param>
		///         <param name="block">The block to execute.</param>
		///         <summary>Adds the described persistent store and runs a handler when it is complete.</summary>
		[MacCatalyst (13, 1)]
		[Export ("addPersistentStoreWithDescription:completionHandler:")]
		[Async]
		void AddPersistentStore (NSPersistentStoreDescription storeDescription, Action<NSPersistentStoreDescription, NSError> block);

		/// <param name="store">The persistent store.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Removes the specified <paramref name="store" /> and reports any errors that are encountered.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("removePersistentStore:error:")]
		bool RemovePersistentStore (NSPersistentStore store, out NSError error);

		/// <param name="store">The persistent store.</param>
		///         <param name="url">The URL.</param>
		///         <param name="options">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="storeType">The store type.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Migrates <paramref name="store" /> to <paramref name="url" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("migratePersistentStore:toURL:options:withType:error:")]
		[return: NullAllowed]
		NSPersistentStore MigratePersistentStore (NSPersistentStore store, NSUrl url, [NullAllowed] NSDictionary options, NSString storeType, out NSError error);

		/// <param name="url">The URL.</param>
		///         <summary>Returns a managed object id for the specified <paramref name="url" /> if a store that matches the URL can be found.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("managedObjectIDForURIRepresentation:")]
		[return: NullAllowed]
		NSManagedObjectID ManagedObjectIDForURIRepresentation (NSUrl url);

#pragma warning disable 0109 // warning CS0109: The member 'NSManagedObjectContext.Lock()' does not hide an accessible member. The new keyword is not required.
		/// <summary>Performs the lock operation.</summary>
		[NoTV]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use 'PerformAndWait' instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use 'PerformAndWait' instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'PerformAndWait' instead.")]
		[Export ("lock")]
		new void Lock ();
#pragma warning restore

#pragma warning disable 0109 // warning CS0109: The member 'NSManagedObjectContext.Unlock()' does not hide an accessible member. The new keyword is not required.
		/// <summary>Performs the unlock operation.</summary>
		[NoTV]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use 'PerformAndWait' instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use 'PerformAndWait' instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'PerformAndWait' instead.")]
		[Export ("unlock")]
		new void Unlock ();
#pragma warning restore

		/// <summary>Gets the TryLock value.</summary>
		[NoTV]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use 'Perform' instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use 'Perform' instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'Perform' instead.")]
		[Export ("tryLock")]
		bool TryLock { get; }

		/// <param name="url">The URL.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Performs the metadata for persistent store with url operation.</summary>
		///         <returns>The result of the operation.</returns>
		[NoiOS]
		[NoMacCatalyst]
		[NoTV]
		[Deprecated (PlatformName.MacOSX, 10, 5)]
		[Static, Export ("metadataForPersistentStoreWithURL:error:")]
		[return: NullAllowed]
		NSDictionary MetadataForPersistentStoreWithUrl (NSUrl url, out NSError error);

		/// <summary>Represents the value associated with the constant NSSQLiteStoreType</summary>
		///         <value>
		///         </value>
		[Field ("NSSQLiteStoreType")]
		NSString SQLiteStoreType { get; }

		/// <summary>Gets the XMLStoreType key constant.</summary>
		[NoiOS]
		[NoMacCatalyst]
		[NoTV]
		[Field ("NSXMLStoreType")]
		NSString XMLStoreType { get; }

		/// <summary>Represents the value associated with the constant NSBinaryStoreType</summary>
		///         <value>
		///         </value>
		[Field ("NSBinaryStoreType")]
		NSString BinaryStoreType { get; }

		/// <summary>Gets the BinaryStoreSecureDecodingClasses key constant.</summary>
		[MacCatalyst (13, 1)]
		[Field ("NSBinaryStoreSecureDecodingClasses")]
		NSString BinaryStoreSecureDecodingClasses { get; }

		/// <summary>Gets the BinaryStoreInsecureDecodingCompatibilityOption key constant.</summary>
		[MacCatalyst (13, 1)]
		[Field ("NSBinaryStoreInsecureDecodingCompatibilityOption")]
		NSString BinaryStoreInsecureDecodingCompatibilityOption { get; }

		/// <summary>Represents the value associated with the constant NSInMemoryStoreType</summary>
		///         <value>
		///         </value>
		[Field ("NSInMemoryStoreType")]
		NSString InMemoryStoreType { get; }

		/// <summary>Represents the value associated with the constant NSStoreUUIDKey</summary>
		///         <value>
		///         </value>
		[Field ("NSStoreUUIDKey")]
		NSString StoreUUIDKey { get; }

		/// <summary>Represents the value associated with the constant NSAddedPersistentStoresKey</summary>
		///         <value>
		///         </value>
		[Field ("NSAddedPersistentStoresKey")]
		NSString AddedPersistentStoresKey { get; }

		/// <summary>Represents the value associated with the constant NSRemovedPersistentStoresKey</summary>
		///         <value>
		///         </value>
		[Field ("NSRemovedPersistentStoresKey")]
		NSString RemovedPersistentStoresKey { get; }

		/// <summary>Represents the value associated with the constant NSUUIDChangedPersistentStoresKey</summary>
		///         <value>
		///         </value>
		[Field ("NSUUIDChangedPersistentStoresKey")]
		NSString UUIDChangedPersistentStoresKey { get; }

		/// <summary>Represents the value associated with the constant NSReadOnlyPersistentStoreOption</summary>
		///         <value>
		///         </value>
		[Field ("NSReadOnlyPersistentStoreOption")]
		NSString ReadOnlyPersistentStoreOption { get; }

		/// <summary>Gets the ValidateXMLStoreOption key constant.</summary>
		[NoiOS]
		[NoMacCatalyst]
		[NoTV]
		[Field ("NSValidateXMLStoreOption")]
		NSString ValidateXMLStoreOption { get; }

		/// <summary>Represents the value associated with the constant NSPersistentStoreTimeoutOption</summary>
		///         <value>
		///         </value>
		[Field ("NSPersistentStoreTimeoutOption")]
		NSString PersistentStoreTimeoutOption { get; }

		/// <summary>Represents the value associated with the constant NSSQLitePragmasOption</summary>
		///         <value>
		///         </value>
		[Field ("NSSQLitePragmasOption")]
		NSString SQLitePragmasOption { get; }

		/// <summary>Represents the value associated with the constant NSSQLiteAnalyzeOption</summary>
		///         <value>
		///         </value>
		[Field ("NSSQLiteAnalyzeOption")]
		NSString SQLiteAnalyzeOption { get; }

		/// <summary>Represents the value associated with the constant NSSQLiteManualVacuumOption</summary>
		///         <value>
		///         </value>
		[Field ("NSSQLiteManualVacuumOption")]
		NSString SQLiteManualVacuumOption { get; }

		/// <summary>Represents the value associated with the constant NSIgnorePersistentStoreVersioningOption</summary>
		///         <value>
		///         </value>
		[Field ("NSIgnorePersistentStoreVersioningOption")]
		NSString IgnorePersistentStoreVersioningOption { get; }

		/// <summary>Represents the value associated with the constant NSMigratePersistentStoresAutomaticallyOption</summary>
		///         <value>
		///         </value>
		[Field ("NSMigratePersistentStoresAutomaticallyOption")]
		NSString MigratePersistentStoresAutomaticallyOption { get; }

		/// <summary>Represents the value associated with the constant NSInferMappingModelAutomaticallyOption</summary>
		///         <value>
		///         </value>
		[Field ("NSInferMappingModelAutomaticallyOption")]
		NSString InferMappingModelAutomaticallyOption { get; }

		/// <summary>Represents the value associated with the constant NSStoreModelVersionHashesKey</summary>
		///         <value>
		///         </value>
		[Field ("NSStoreModelVersionHashesKey")]
		NSString StoreModelVersionHashesKey { get; }

		/// <summary>Represents the value associated with the constant NSStoreModelVersionIdentifiersKey</summary>
		///         <value>
		///         </value>
		[Field ("NSStoreModelVersionIdentifiersKey")]
		NSString StoreModelVersionIdentifiersKey { get; }

		/// <summary>Represents the value associated with the constant NSPersistentStoreOSCompatibility</summary>
		///         <value>
		///         </value>
		[Field ("NSPersistentStoreOSCompatibility")]
		NSString PersistentStoreOSCompatibility { get; }

		/// <summary>Represents the value associated with the constant NSStoreTypeKey</summary>
		///         <value>
		///         </value>
		[Field ("NSStoreTypeKey")]
		NSString StoreTypeKey { get; }

		[Notification]
		[Field ("NSPersistentStoreCoordinatorStoresDidChangeNotification")]
		NSString StoresDidChangeNotification { get; }

		[Notification]
		[Field ("NSPersistentStoreCoordinatorWillRemoveStoreNotification")]
		NSString WillRemoveStoreNotification { get; }

		// 5.0
		[Export ("executeRequest:withContext:error:")]
		[return: NullAllowed]
		NSObject Execute (NSPersistentStoreRequest request, NSManagedObjectContext context, out NSError error);

		[NoTV]
		[Notification]
		[Deprecated (PlatformName.iOS, 10, 0, message: "Please see the release notes and Core Data documentation.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Please see the release notes and Core Data documentation.")]
		[Field ("NSPersistentStoreDidImportUbiquitousContentChangesNotification")]
		NSString DidImportUbiquitousContentChangesNotification { get; }

		/// <summary>Represents the value associated with the constant NSPersistentStoreUbiquitousContentNameKey</summary>
		///         <value>
		///         </value>
		[NoTV]
		[Deprecated (PlatformName.iOS, 10, 0, message: "Please see the release notes and Core Data documentation.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Please see the release notes and Core Data documentation.")]
		[Field ("NSPersistentStoreUbiquitousContentNameKey")]
		NSString PersistentStoreUbiquitousContentNameKey { get; }

		[NoTV]
		[Deprecated (PlatformName.iOS, 10, 0, message: "Please see the release notes and Core Data documentation.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Please see the release notes and Core Data documentation.")]
		[Field ("NSPersistentStoreUbiquitousContentURLKey")]
		NSString PersistentStoreUbiquitousContentUrlKey { get; }

		/// <summary>Represents the value associated with the constant NSPersistentStoreFileProtectionKey</summary>
		///         <value>
		///         </value>
		[NoMac]
		[MacCatalyst (13, 1)]
		[Field ("NSPersistentStoreFileProtectionKey")]
		NSString PersistentStoreFileProtectionKey { get; }

		// 7.0

		/// <summary>Represents the value associated with the constant NSPersistentStoreUbiquitousPeerTokenOption</summary>
		///         <value>
		///         </value>
		[NoTV]
		[MacCatalyst (13, 1)]
		[Field ("NSPersistentStoreUbiquitousPeerTokenOption")]
		NSString PersistentStoreUbiquitousPeerTokenOption { get; }

		/// <param name="storeUrl">The store URL.</param>
		///         <param name="options">The options dictionary.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Performs the remove ubiquitous content and persistent store operation.</summary>
		///         <returns>The result of the operation.</returns>
		[NoTV]
		[Static]
		[Deprecated (PlatformName.iOS, 10, 0, message: "Please see the release notes and Core Data documentation.")]
		[Deprecated (PlatformName.MacOSX, 10, 12, message: "Please see the release notes and Core Data documentation.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Please see the release notes and Core Data documentation.")]
		[Export ("removeUbiquitousContentAndPersistentStoreAtURL:options:error:")]
		bool RemoveUbiquitousContentAndPersistentStore (NSUrl storeUrl, [NullAllowed] NSDictionary options, out NSError error);

		[MacCatalyst (13, 1)]
		[Notification (typeof (NSPersistentStoreCoordinatorStoreChangeEventArgs))]
		[Field ("NSPersistentStoreCoordinatorStoresWillChangeNotification")]
		NSString StoresWillChangeNotification { get; }

		/// <summary>Represents the value associated with the constant NSPersistentStoreRebuildFromUbiquitousContentOption</summary>
		///         <value>
		///         </value>
		[NoTV]
		[MacCatalyst (13, 1)]
		[Field ("NSPersistentStoreRebuildFromUbiquitousContentOption")]
		NSString RebuildFromUbiquitousContentOption { get; }

		/// <summary>Represents the value associated with the constant NSPersistentStoreRemoveUbiquitousMetadataOption</summary>
		///         <value>
		///         </value>
		[NoTV]
		[MacCatalyst (13, 1)]
		[Field ("NSPersistentStoreRemoveUbiquitousMetadataOption")]
		NSString RemoveUbiquitousMetadataOption { get; }

		/// <summary>Represents the value associated with the constant NSPersistentStoreUbiquitousContainerIdentifierKey</summary>
		///         <value>
		///         </value>
		[NoTV]
		[MacCatalyst (13, 1)]
		[Field ("NSPersistentStoreUbiquitousContainerIdentifierKey")]
		[Obsolete ("Use 'UbiquitousContainerIdentifierKey' instead.")]
		NSString eUbiquitousContainerIdentifierKey { get; }

		/// <summary>Represents the value that is associated with the NSPersistentStoreUbiquitousContainerIdentifierKey constant.</summary>
		[NoTV]
		[MacCatalyst (13, 1)]
		[Field ("NSPersistentStoreUbiquitousContainerIdentifierKey")]
		NSString UbiquitousContainerIdentifierKey { get; }

		// 11.0

		/// <summary>Gets the CoreSpotlightExporter key constant.</summary>
		[NoTV]
		[MacCatalyst (13, 1)]
		[Field ("NSCoreDataCoreSpotlightExporter")]
		NSString CoreSpotlightExporter { get; }

		/// <summary>Represents the value that is associated with the NSPersistentHistoryTrackingKey constant.</summary>
		[MacCatalyst (13, 1)]
		[Field ("NSPersistentHistoryTrackingKey")]
		NSString HistoryTrackingKey { get; }

		/// <summary>Gets the name of the persistent store coordinator.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("name")]
		string Name { get; set; }

		/// <param name="code">The error code.</param>
		///         <summary>Performs the perform operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("performBlock:")]
		void Perform (Action code);

		/// <param name="code">The error code.</param>
		///         <summary>Performs the perform and wait operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("performBlockAndWait:")]
		void PerformAndWait (Action code);

		/// <param name="url">The URL.</param>
		///         <param name="storeType">The store type.</param>
		///         <param name="options">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="error">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Destroys the persistent store that is located at the specified <paramref name="url" />.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("destroyPersistentStoreAtURL:withType:options:error:")]
		bool DestroyPersistentStore (NSUrl url, string storeType, [NullAllowed] NSDictionary options, out NSError error);

		/// <param name="destinationUrl">The destination URL.</param>
		///         <param name="destinationOptions">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="sourceUrl">The source store URL.</param>
		///         <param name="sourceOptions">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="storeType">The store type.</param>
		///         <param name="error">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Replaces the persistent store at <paramref name="destinationUrl" /> with the one at <paramref name="sourceUrl" />.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("replacePersistentStoreAtURL:destinationOptions:withPersistentStoreFromURL:sourceOptions:storeType:error:")]
		bool ReplacePersistentStore (NSUrl destinationUrl, [NullAllowed] NSDictionary destinationOptions, NSUrl sourceUrl, [NullAllowed] NSDictionary sourceOptions, string storeType, out NSError error);


		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("currentPersistentHistoryTokenFromStores:")]
		[return: NullAllowed]
		NSPersistentHistoryToken GetCurrentPersistentHistoryToken ([NullAllowed] NSObject [] stores);

		[TV (14, 0), iOS (14, 0), MacCatalyst (14, 0)]
		[Export ("finishDeferredLightweightMigration:")]
		bool FinishDeferredLightweightMigration ([NullAllowed] out NSError error);

		[TV (14, 0), iOS (14, 0), MacCatalyst (14, 0)]
		[Export ("finishDeferredLightweightMigrationTask:")]
		bool FinishDeferredLightweightMigrationTask ([NullAllowed] out NSError error);

		[NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("managedObjectIDFromUTF8String:length:")]
		NSManagedObjectID GetManagedObjectId (IntPtr utf8String, nuint length);
	}

	interface NSPersistentStoreCoordinatorStoreChangeEventArgs {
		/// <summary>Gets the EventType value.</summary>
		[NoTV]
		[Export ("NSPersistentStoreUbiquitousTransitionTypeKey")]
		[Deprecated (PlatformName.iOS, 10, 0, message: "Please see the release notes and Core Data documentation.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Please see the release notes and Core Data documentation.")]
		NSPersistentStoreUbiquitousTransitionType EventType { get; }
	}

	/// <summary>Criteria used to retrieve data from or save data in APersistent store.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreData/Reference/NSPersistentStoreRequest_Class/index.html">Apple documentation for <c>NSPersistentStoreRequest</c></related>
	[BaseType (typeof (NSObject))]
	interface NSPersistentStoreRequest : NSCopying {
		/// <summary>Gets the RequestType value.</summary>
		[Export ("requestType")]
		NSPersistentStoreRequestType RequestType { get; }

		//Detected properties
		/// <summary>Gets or sets the AffectedStores value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("affectedStores", ArgumentSemantic.Retain)]
		NSPersistentStore [] AffectedStores { get; set; }
	}

	/// <summary>Class that represents the result of an asynchronous fetch request.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/CoreData/NSAsynchronousFetchResult">Apple documentation for <c>NSAsynchronousFetchResult</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSPersistentStoreAsynchronousResult))]
	interface NSAsynchronousFetchResult {
		/// <summary>Gets the FetchRequest value.</summary>
		[Export ("fetchRequest", ArgumentSemantic.Retain)]
		NSAsynchronousFetchRequest FetchRequest { get; }

		/// <summary>Gets the FinalResult value.</summary>
		[Export ("finalResult", ArgumentSemantic.Retain)]
		[NullAllowed]
		INSFetchRequestResult [] FinalResult { get; }
	}

	/// <summary>Class that represents the result of request that was made of APersistent data store.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/CoreData/NSPersistentStoreResult">Apple documentation for <c>NSPersistentStoreResult</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NSPersistentStoreResult {

	}

	/// <summary>Class that represents the result of an batch update request.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/CoreData/NSBatchUpdateResult">Apple documentation for <c>NSBatchUpdateResult</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSPersistentStoreResult))]
	interface NSBatchUpdateResult {
		/// <summary>Gets the Result value.</summary>
		[Export ("result", ArgumentSemantic.Retain)]
		[NullAllowed]
		NSObject Result { get; }

		/// <summary>Gets the ResultType value.</summary>
		[Export ("resultType")]
		NSBatchUpdateRequestResultType ResultType { get; }
	}

	/// <summary>Class that represents the results of an asynchronous request that was made of APersistent data store.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/CoreData/NSPersistentStoreAsynchronousResult">Apple documentation for <c>NSPersistentStoreAsynchronousResult</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSPersistentStoreResult))]
	interface NSPersistentStoreAsynchronousResult {
		/// <summary>Gets the ManagedObjectContext value.</summary>
		[Export ("managedObjectContext", ArgumentSemantic.Retain)]
		NSManagedObjectContext ManagedObjectContext { get; }

		/// <summary>Gets the OperationError value.</summary>
		[Export ("operationError", ArgumentSemantic.Retain)]
		[NullAllowed]
		NSError OperationError { get; }

		/// <summary>Gets the Progress value.</summary>
		[Export ("progress", ArgumentSemantic.Retain)]
		[NullAllowed]
		NSProgress Progress { get; }

		/// <summary>Performs the cancel operation.</summary>
		[Export ("cancel")]
		void Cancel ();
	}

	/// <summary>Class that represents an asynchronous fetch request.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/CoreData/NSAsynchronousFetchRequest">Apple documentation for <c>NSAsynchronousFetchRequest</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSPersistentStoreRequest))]
	interface NSAsynchronousFetchRequest {
		/// <param name="request">The fetch request.</param>
		/// <param name="completion">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithFetchRequest:completionBlock:")]
		NativeHandle Constructor (NSFetchRequest request, [NullAllowed] Action<NSAsynchronousFetchResult> completion);

		/// <summary>Gets the FetchRequest value.</summary>
		[Export ("fetchRequest", ArgumentSemantic.Retain)]
		NSFetchRequest FetchRequest { get; }

		/// <summary>Gets or sets the EstimatedResultCount value.</summary>
		[Export ("estimatedResultCount")]
		nint EstimatedResultCount { get; set; }
	}

	/// <summary>Defines properties of an entity in a managed objectmodel. The equivalent of an instance property.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/CoreDataFramework/Classes/NSPropertyDescription_Class/index.html">Apple documentation for <c>NSPropertyDescription</c></related>
	[BaseType (typeof (NSObject))]
	interface NSPropertyDescription : NSCoding, NSCopying {

		/// <summary>Gets the Entity value.</summary>
		[Export ("entity")]
		NSEntityDescription Entity { get; }

		// by default this property is null, but docs mention possible 
		// exception on setter so allowing a null is not a good idea
		/// <summary>Gets or sets the Name value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("name")]
		string Name { get; set; }

		/// <summary>Gets or sets the Optional value.</summary>
		[Export ("optional")]
		bool Optional { [Bind ("isOptional")] get; set; }

		/// <summary>Gets or sets the Transient value.</summary>
		[Export ("transient")]
		bool Transient { [Bind ("isTransient")] get; set; }

		/// <summary>Gets the ValidationPredicates value.</summary>
		[Export ("validationPredicates")]
		NSPredicate [] ValidationPredicates { get; }

		/// <summary>Gets the ValidationWarnings value.</summary>
		[Export ("validationWarnings")]
		string [] ValidationWarnings { get; }

		/// <param name="validationPredicates">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="validationWarnings">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the set validation predicates operation.</summary>
		[Export ("setValidationPredicates:withValidationWarnings:")]
		void SetValidationPredicates ([NullAllowed] NSPredicate [] validationPredicates, [NullAllowed] string [] validationWarnings);

		/// <summary>Gets or sets the UserInfo value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("userInfo", ArgumentSemantic.Retain)]
		NSDictionary UserInfo { get; set; }

		/// <summary>Developers should not use this deprecated property. Developers should use 'NSEntityDescription.Indexes' instead.</summary>
		[Export ("indexed")]
		[Deprecated (PlatformName.iOS, 11, 0, message: "Use 'NSEntityDescription.Indexes' instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 13, message: "Use 'NSEntityDescription.Indexes' instead.")]
		[Deprecated (PlatformName.TvOS, 11, 0, message: "Use 'NSEntityDescription.Indexes' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'NSEntityDescription.Indexes' instead.")]
		bool Indexed { [Bind ("isIndexed")] get; set; }

		/// <summary>Gets the VersionHash value.</summary>
		[Export ("versionHash")]
		NSData VersionHash { get; }

		/// <summary>Gets or sets the VersionHashModifier value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("versionHashModifier")]
		string VersionHashModifier { get; set; }

		/// <summary>Gets the receiver's renaming identifier.</summary>
		[Export ("renamingIdentifier")]
		[NullAllowed]
		string RenamingIdentifier { get; set; }

		// 5.0
		/// <summary>Gets or sets the IndexedBySpotlight value.</summary>
		[Export ("indexedBySpotlight")]
		bool IndexedBySpotlight { [Bind ("isIndexedBySpotlight")] get; set; }

		/// <summary>Gets or sets the StoredInExternalRecord value.</summary>
		[Export ("storedInExternalRecord")]
		[Deprecated (PlatformName.iOS, 11, 0, message: "Use 'CoreSpotlight' integration instead.")]
		[Deprecated (PlatformName.TvOS, 11, 0, message: "Use 'CoreSpotlight' integration instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 13, message: "Use 'CoreSpotlight' integration instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'CoreSpotlight' integration instead.")]
		bool StoredInExternalRecord { [Bind ("isStoredInExternalRecord")] get; set; }
	}

	/// <summary>Maps AProperty between source and destination entities.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/NSPropertyMapping_class/index.html">Apple documentation for <c>NSPropertyMapping</c></related>
	[BaseType (typeof (NSObject))]
	interface NSPropertyMapping {

		/// <summary>Gets or sets the Name value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("name")]
		string Name { get; set; }

		/// <summary>Gets or sets the ValueExpression value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("valueExpression", ArgumentSemantic.Retain)]
		NSExpression ValueExpression { get; set; }

		/// <summary>Gets or sets the UserInfo value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("userInfo", ArgumentSemantic.Retain)]
		NSDictionary UserInfo { get; set; }
	}

	/// <summary>Describes the relationships of a <see cref="CoreData.NSEntityDescription" /> object.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/CoreDataFramework/Classes/NSRelationshipDescription_Class/index.html">Apple documentation for <c>NSRelationshipDescription</c></related>
	[BaseType (typeof (NSPropertyDescription))]
	interface NSRelationshipDescription {

		/// <summary>Gets or sets the DestinationEntity value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("destinationEntity")]
		NSEntityDescription DestinationEntity { get; set; }

		/// <summary>Gets or sets the InverseRelationship value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("inverseRelationship")]
		NSRelationshipDescription InverseRelationship { get; set; }

		/// <summary>Gets or sets the MaxCount value.</summary>
		[Export ("maxCount")]
		nuint MaxCount { get; set; }

		/// <summary>Gets or sets the MinCount value.</summary>
		[Export ("minCount")]
		nuint MinCount { get; set; }

		/// <summary>Gets or sets the DeleteRule value.</summary>
		[Export ("deleteRule")]
		NSDeleteRule DeleteRule { get; set; }

		/// <summary>Gets the IsToMany value.</summary>
		[Export ("toMany")]
		bool IsToMany { [Bind ("isToMany")] get; }

		/// <summary>Gets the VersionHash value.</summary>
		[Export ("versionHash")]
		NSData VersionHash { get; }

		// 5.0
		/// <summary>Gets or sets the Ordered value.</summary>
		[Export ("ordered")]
		bool Ordered { [Bind ("isOrdered")] get; set; }
	}

	/// <summary>A collection of changes to be made by an object store.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreData/Reference/NSSaveChangesRequest_Class/index.html">Apple documentation for <c>NSSaveChangesRequest</c></related>
	[BaseType (typeof (NSPersistentStoreRequest))]
	interface NSSaveChangesRequest {
		/// <param name="insertedObjects">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="updatedObjects">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="deletedObjects">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="lockedObjects">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Performs the Core Data operation.</summary>
		[Export ("initWithInsertedObjects:updatedObjects:deletedObjects:lockedObjects:")]
#if XAMCORE_5_0
		NativeHandle Constructor ([NullAllowed] NSSet<NSManagedObject> insertedObjects, [NullAllowed] NSSet<NSManagedObject> updatedObjects, [NullAllowed] NSSet<NSManagedObject> deletedObjects, [NullAllowed] NSSet<NSManagedObject> lockedObjects);
#else
		NativeHandle Constructor ([NullAllowed] NSSet insertedObjects, [NullAllowed] NSSet updatedObjects, [NullAllowed] NSSet deletedObjects, [NullAllowed] NSSet lockedObjects);
#endif

		/// <summary>Performs the Core Data operation.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("insertedObjects", ArgumentSemantic.Strong)]
#if XAMCORE_5_0
		NSSet<NSManagedObject> InsertedObjects { get; }
#else
		NSSet InsertedObjects { get; }
#endif

		/// <summary>Performs the Core Data operation.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("updatedObjects", ArgumentSemantic.Strong)]
#if XAMCORE_5_0
		NSSet<NSManagedObject> UpdatedObjects { get; }
#else
		NSSet UpdatedObjects { get; }
#endif

		/// <summary>Performs the Core Data operation.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("deletedObjects", ArgumentSemantic.Strong)]
#if XAMCORE_5_0
		NSSet<NSManagedObject> DeletedObjects { get; }
#else
		NSSet DeletedObjects { get; }
#endif

		/// <summary>Performs the Core Data operation.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("lockedObjects", ArgumentSemantic.Strong)]
#if XAMCORE_5_0
		NSSet<NSManagedObject> LockedObjects { get; }
#else
		NSSet LockedObjects { get; }
#endif
	}

	/// <summary>Class that represents a request for a batch update.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/CoreData/NSBatchUpdateRequest">Apple documentation for <c>NSBatchUpdateRequest</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSPersistentStoreRequest))]
	interface NSBatchUpdateRequest {
		/// <param name="entityName">The entity name.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithEntityName:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string entityName);

		/// <param name="entity">The entity description.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithEntity:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity);

		/// <summary>Gets the EntityName value.</summary>
		[Export ("entityName")]
		string EntityName { get; }

		/// <summary>Gets the Entity value.</summary>
		[Export ("entity", ArgumentSemantic.Retain)]
		NSEntityDescription Entity { get; }

		/// <summary>Gets or sets the Predicate value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("predicate", ArgumentSemantic.Retain)]
		NSPredicate Predicate { get; set; }

		/// <summary>Gets or sets the IncludesSubentities value.</summary>
		[Export ("includesSubentities")]
		bool IncludesSubentities { get; set; }

		/// <summary>Gets or sets the ResultType value.</summary>
		[Export ("resultType", ArgumentSemantic.Assign)]
		NSBatchUpdateRequestResultType ResultType { get; set; }

		/// <summary>Gets or sets the PropertiesToUpdate value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("propertiesToUpdate", ArgumentSemantic.Copy)]
		NSDictionary PropertiesToUpdate { get; set; }

		/// <param name="entityName">The entity name.</param>
		///         <summary>Performs the batch update request with entity name operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static, Export ("batchUpdateRequestWithEntityName:")]
		NSBatchUpdateRequest BatchUpdateRequestWithEntityName (string entityName);
	}

	/// <summary>A <see cref="CoreData.NSPersistentStoreRequest" /> that performs a batch delete.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/CoreData/NSBatchDeleteRequest">Apple documentation for <c>NSBatchDeleteRequest</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSPersistentStoreRequest))]
	[DisableDefaultCtor]
	interface NSBatchDeleteRequest {
		/// <param name="fetch">The fetch request.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithFetchRequest:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSFetchRequest fetch);

		/// <param name="objects">The managed objects.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithObjectIDs:")]
		NativeHandle Constructor (NSManagedObjectID [] objects);

		/// <summary>Gets or sets the ResultType value.</summary>
		[Export ("resultType", ArgumentSemantic.Assign)]
		NSBatchDeleteRequestResultType ResultType { get; set; }

		/// <summary>Gets the FetchRequest value.</summary>
		[Export ("fetchRequest", ArgumentSemantic.Copy)]
		NSFetchRequest FetchRequest { get; }
	}

	/// <summary>The results of a <see cref="CoreData.NSBatchDeleteRequest" />.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/CoreData/NSBatchDeleteResult">Apple documentation for <c>NSBatchDeleteResult</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSPersistentStoreResult))]
	interface NSBatchDeleteResult {
		/// <summary>Gets the Result value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("result", ArgumentSemantic.Strong)]
		NSObject Result { get; }

		/// <summary>Gets the ResultType value.</summary>
		[Export ("resultType")]
		NSBatchDeleteRequestResultType ResultType { get; }
	}

	/// <summary>Performs the n s constraint conflict operation.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/CoreData/NSConstraintConflict">Apple documentation for <c>NSConstraintConflict</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NSConstraintConflict {
		/// <param name="contraint">The constraint.</param>
		/// <param name="databaseObject">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="databaseSnapshot">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="conflictingObjects">The conflicting objects.</param>
		/// <param name="conflictingSnapshots">The conflicting snapshots.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithConstraint:databaseObject:databaseSnapshot:conflictingObjects:conflictingSnapshots:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string [] contraint, [NullAllowed] NSManagedObject databaseObject, [NullAllowed] NSDictionary databaseSnapshot, NSManagedObject [] conflictingObjects, NSObject [] conflictingSnapshots);

#if MONOMAC
		/// <summary>Performs the Core Data operation.</summary>
		[Export ("constraint", ArgumentSemantic.Copy)]
#else
		[Export ("constraint", ArgumentSemantic.Retain)]
#endif
		string [] Constraint { get; }

#if MONOMAC
		/// <summary>Performs the Core Data operation.</summary>
		[Export ("constraintValues", ArgumentSemantic.Copy)]
#else
		[Export ("constraintValues", ArgumentSemantic.Retain)]
#endif
		NSDictionary<NSString, NSObject> ConstraintValues { get; }

		/// <summary>Gets the DatabaseObject value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("databaseObject", ArgumentSemantic.Retain)]
		NSManagedObject DatabaseObject { get; }

		/// <summary>Gets the DatabaseSnapshot value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("databaseSnapshot", ArgumentSemantic.Retain)]
		NSDictionary<NSString, NSObject> DatabaseSnapshot { get; }

#if MONOMAC
		/// <summary>Performs the Core Data operation.</summary>
		[Export ("conflictingObjects", ArgumentSemantic.Copy)]
#else
		[Export ("conflictingObjects", ArgumentSemantic.Retain)]
#endif
		NSManagedObject [] ConflictingObjects { get; }

#if MONOMAC
		/// <summary>Performs the Core Data operation.</summary>
		[Export ("conflictingSnapshots", ArgumentSemantic.Copy)]
#else
		[Export ("conflictingSnapshots", ArgumentSemantic.Retain)]
#endif
		NSDictionary [] ConflictingSnapshots { get; }
	}

#if XAMCORE_5_0
	delegate bool NSBatchInsertRequestDictionaryHandler (NSMutableDictionary<NSString, NSObject> dictionary);
#else
	delegate bool NSBatchInsertRequestDictionaryHandler (NSMutableDictionary dictionary);
#endif
	delegate bool NSBatchInsertRequestManagedObjectHandler (NSManagedObject managedObject);

	[TV (13, 0), iOS (13, 0)]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSPersistentStoreRequest))]
	[DisableDefaultCtor] // NSInternalInconsistencyException Reason: -init results in undefined behavior for NSBatchInsertRequest
	interface NSBatchInsertRequest {

		[Deprecated (PlatformName.iOS, 14, 0, message: "Use another constructor instead.")]
		[Deprecated (PlatformName.TvOS, 14, 0, message: "Use another constructor instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 16, message: "Use another constructor instead.")]
		[NoMacCatalyst]
		[Deprecated (PlatformName.MacCatalyst, 14, 0, message: "Use another constructor instead.")]
		[Export ("init")]
		NativeHandle Constructor ();

		[TV (14, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("initWithEntity:dictionaryHandler:")]
		NativeHandle Constructor (NSEntityDescription entity, NSBatchInsertRequestDictionaryHandler handler);

		[TV (14, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("initWithEntity:managedObjectHandler:")]
		NativeHandle Constructor (NSEntityDescription entity, NSBatchInsertRequestManagedObjectHandler handler);

		[TV (14, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("initWithEntityName:dictionaryHandler:")]
		NativeHandle Constructor (string entityName, NSBatchInsertRequestDictionaryHandler handler);

		[TV (14, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("initWithEntityName:managedObjectHandler:")]
		NativeHandle Constructor (string entityName, NSBatchInsertRequestManagedObjectHandler handler);

		[Export ("entityName")]
		string EntityName { get; }

		[NullAllowed, Export ("entity", ArgumentSemantic.Strong)]
		NSEntityDescription Entity { get; }

		[NullAllowed, Export ("objectsToInsert", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> [] ObjectsToInsert { get; set; }

		[Export ("resultType", ArgumentSemantic.Assign)]
		NSBatchInsertRequestResultType ResultType { get; set; }

		[Static]
		[Export ("batchInsertRequestWithEntityName:objects:")]
		NSBatchInsertRequest BatchInsertRequest (string entityName, NSDictionary<NSString, NSObject> [] dictionaries);

		[DesignatedInitializer]
		[Export ("initWithEntityName:objects:")]
		NativeHandle Constructor (string entityName, NSDictionary<NSString, NSObject> [] dictionaries);

		[DesignatedInitializer]
		[Export ("initWithEntity:objects:")]
		NativeHandle Constructor (NSEntityDescription entity, NSDictionary<NSString, NSObject> [] dictionaries);

		[TV (14, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[NullAllowed, Export ("dictionaryHandler", ArgumentSemantic.Copy)]
		NSBatchInsertRequestDictionaryHandler DictionaryHandler { get; set; }

		[TV (14, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[NullAllowed, Export ("managedObjectHandler", ArgumentSemantic.Copy)]
		NSBatchInsertRequestManagedObjectHandler ManagedObjectHandler { get; set; }

		[TV (14, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Static]
		[Export ("batchInsertRequestWithEntityName:dictionaryHandler:")]
		NSBatchInsertRequest CreateBatchInsertRequest (string entityName, NSBatchInsertRequestDictionaryHandler handler);

		[TV (14, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Static]
		[Export ("batchInsertRequestWithEntityName:managedObjectHandler:")]
		NSBatchInsertRequest CreateBatchInsertRequest (string entityName, NSBatchInsertRequestManagedObjectHandler handler);
	}

	[TV (13, 0), iOS (13, 0)]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSPersistentStoreResult))]
	interface NSBatchInsertResult {
		[NullAllowed, Export ("result", ArgumentSemantic.Strong)]
		NSObject Result { get; }

		[Export ("resultType")]
		NSBatchInsertRequestResultType ResultType { get; }
	}

	[TV (13, 0), iOS (13, 0)]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSAttributeDescription))]
	interface NSDerivedAttributeDescription : NSSecureCoding {
		[NullAllowed, Export ("derivationExpression", ArgumentSemantic.Strong)]
		NSExpression DerivationExpression { get; set; }
	}

	[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
	delegate void NSPersistentCloudKitContainerShareManagedObjectsHandler ([NullAllowed] NSSet<NSManagedObjectID> sharedObjectIds, [NullAllowed] CKShare share, [NullAllowed] CKContainer container, [NullAllowed] NSError error);

	[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
	delegate void NSPersistentCloudKitContainerFetchParticipantsMatchingLookupInfosHandler ([NullAllowed] NSArray<CKShareParticipant> fetchedParticipants, [NullAllowed] NSError error);

	[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
	delegate void NSPersistentCloudKitContainerPersistUpdatedShareHandler ([NullAllowed] CKShare persistedShare, [NullAllowed] NSError error);

	[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
	delegate void NSPersistentCloudKitContainerPurgeObjectsAndRecordsInZoneHandler ([NullAllowed] CKRecordZoneID purgedZoneId, [NullAllowed] NSError error);

	[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
	delegate void NSPersistentCloudKitContainerAcceptShareInvitationsHandler ([NullAllowed] NSArray<CKShareMetadata> acceptedShareMetadatas, [NullAllowed] NSError error);

	[TV (13, 0), iOS (13, 0)]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSPersistentContainer))]
	[DisableDefaultCtor]
	interface NSPersistentCloudKitContainer {

		[Export ("initWithName:managedObjectModel:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string name, NSManagedObjectModel model);

		[Export ("initializeCloudKitSchemaWithOptions:error:")]
		bool Initialize (NSPersistentCloudKitContainerSchemaInitializationOptions options, [NullAllowed] out NSError error);

		[Export ("recordForManagedObjectID:")]
		[return: NullAllowed]
		CKRecord GetRecord (NSManagedObjectID managedObjectId);

		[Export ("recordsForManagedObjectIDs:")]
		NSDictionary<NSManagedObjectID, CKRecord> GetRecords (NSManagedObjectID [] managedObjectIds);

		[Export ("recordIDForManagedObjectID:")]
		[return: NullAllowed]
		CKRecordID GetRecordId (NSManagedObjectID managedObjectId);

		[Export ("recordIDsForManagedObjectIDs:")]
		NSDictionary<NSManagedObjectID, CKRecordID> GetRecordIds (NSManagedObjectID [] managedObjectIds);

		[TV (14, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("canUpdateRecordForManagedObjectWithID:")]
		bool CanUpdateRecord (NSManagedObjectID objectID);

		[TV (14, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("canDeleteRecordForManagedObjectWithID:")]
		bool CanDeleteRecord (NSManagedObjectID objectID);

		[TV (14, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("canModifyManagedObjectsInStore:")]
		bool CanModifyManagedObjects (NSPersistentStore store);

		// NSPersistentCloudKitContainer_Sharing
		[Async (ResultTypeName = "NSPersistentCloudKitContainerAcceptShareInvitationsResult")]
		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("acceptShareInvitationsFromMetadata:intoPersistentStore:completion:")]
		void AcceptShareInvitations (CKShareMetadata [] metadata, NSPersistentStore persistentStore, [NullAllowed] NSPersistentCloudKitContainerAcceptShareInvitationsHandler handler);

		[Async (ResultTypeName = "NSPersistentCloudKitContainerPurgeObjectsAndRecordsInZone")]
		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("purgeObjectsAndRecordsInZoneWithID:inPersistentStore:completion:")]
		void PurgeObjectsAndRecordsInZone (CKRecordZoneID zoneId, [NullAllowed] NSPersistentStore persistentStore, [NullAllowed] NSPersistentCloudKitContainerPurgeObjectsAndRecordsInZoneHandler handler);

		[Async (ResultTypeName = "NSPersistentCloudKitContainerPersistUpdatedShareResult")]
		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("persistUpdatedShare:inPersistentStore:completion:")]
		void PersistUpdatedShare (CKShare share, NSPersistentStore persistentStore, [NullAllowed] NSPersistentCloudKitContainerPersistUpdatedShareHandler handler);

		[Async (ResultTypeName = "NSPersistentCloudKitContainerFetchParticipantsMatchingLookupInfosResult")]
		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("fetchParticipantsMatchingLookupInfos:intoPersistentStore:completion:")]
		void FetchParticipantsMatchingLookupInfos (CKUserIdentityLookupInfo [] lookupInfos, NSPersistentStore persistentStore, NSPersistentCloudKitContainerFetchParticipantsMatchingLookupInfosHandler handler);

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("fetchSharesMatchingObjectIDs:error:")]
		[return: NullAllowed]
		NSDictionary<NSManagedObjectID, CKShare> FetchSharesMatchingObjectIds (NSManagedObjectID [] objectIDs, [NullAllowed] out NSError error);

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("fetchSharesInPersistentStore:error:")]
		[return: NullAllowed]
		CKShare [] FetchSharesInPersistentStore ([NullAllowed] NSPersistentStore persistentStore, [NullAllowed] out NSError error);

		[Async (ResultTypeName = "NSPersistentCloudKitContainerShareManagedObjectsResult")]
		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("shareManagedObjects:toShare:completion:")]
		void ShareManagedObjects (NSManagedObject [] managedObjects, [NullAllowed] CKShare share, NSPersistentCloudKitContainerShareManagedObjectsHandler handler);

	}

	[TV (13, 0), iOS (13, 0)]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NSPersistentCloudKitContainerOptions {
		[Export ("containerIdentifier")]
		string ContainerIdentifier { get; }

		[Export ("initWithContainerIdentifier:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string containerIdentifier);

		[TV (14, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("databaseScope", ArgumentSemantic.Assign)]
		CKDatabaseScope DatabaseScope { get; set; }
	}

	[TV (14, 0), iOS (14, 0)]
	[MacCatalyst (14, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NSPersistentCloudKitContainerEvent : NSCopying {
		[Export ("identifier", ArgumentSemantic.Strong)]
		NSUuid Identifier { get; }

		[Export ("storeIdentifier", ArgumentSemantic.Strong)]
		string StoreIdentifier { get; }

		[Export ("type")]
		NSPersistentCloudKitContainerEventType Type { get; }

		[Export ("startDate", ArgumentSemantic.Strong)]
		NSDate StartDate { get; }

		[NullAllowed, Export ("endDate", ArgumentSemantic.Strong)]
		NSDate EndDate { get; }

		[Export ("succeeded")]
		bool Succeeded { get; }

		[NullAllowed, Export ("error", ArgumentSemantic.Strong)]
		NSError Error { get; }

		[Notification]
		[Field ("NSPersistentCloudKitContainerEventChangedNotification")]
		NSString ChangedNotification { get; }

		[Field ("NSPersistentCloudKitContainerEventUserInfoKey")]
		NSString UserInfoKey { get; }
	}

	[TV (14, 0), iOS (14, 0)]
	[MacCatalyst (14, 0)]
	[BaseType (typeof (NSPersistentStoreRequest))]
	interface NSPersistentCloudKitContainerEventRequest {
		[Export ("resultType", ArgumentSemantic.Assign)]
		NSPersistentCloudKitContainerEventResultType ResultType { get; set; }

		[Static]
		[Export ("fetchEventsAfterDate:")]
		NSPersistentCloudKitContainerEventRequest FetchEventsAfter (NSDate date);

		[Static]
		[Export ("fetchEventsAfterEvent:")]
		NSPersistentCloudKitContainerEventRequest FetchEventsAfter ([NullAllowed] NSPersistentCloudKitContainerEvent @event);

		[Static]
		[Export ("fetchEventsMatchingFetchRequest:")]
		NSPersistentCloudKitContainerEventRequest FetchEvents (NSFetchRequest fetchRequest);

		[Static]
		[Export ("fetchRequestForEvents")]
		NSFetchRequest FetchRequest ();
	}

	[TV (14, 0), iOS (14, 0)]
	[MacCatalyst (14, 0)]
	[BaseType (typeof (NSPersistentStoreResult))]
	[DisableDefaultCtor]
	interface NSPersistentCloudKitContainerEventResult {
		[NullAllowed, Export ("result", ArgumentSemantic.Strong)]
		NSObject Result { get; }

		[Export ("resultType")]
		NSPersistentCloudKitContainerEventResultType ResultType { get; }
	}

	[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NSStagedMigrationManager {
		[Export ("stages", ArgumentSemantic.Strong)]
		NSMigrationStage [] Stages { get; }

		[NullAllowed, Export ("container", ArgumentSemantic.Strong)]
		NSPersistentContainer Container { get; }

		[Export ("initWithMigrationStages:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSMigrationStage [] stages);
	}

	[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
	[BaseType (typeof (NSObject))]
	interface NSMigrationStage {
		[NullAllowed, Export ("label")]
		string Label { get; set; }
	}

	[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NSManagedObjectModelReference {
		[Export ("resolvedModel", ArgumentSemantic.Strong)]
		NSManagedObjectModel ResolvedModel { get; }

		[Export ("versionChecksum", ArgumentSemantic.Strong)]
		string VersionChecksum { get; }

		[Export ("initWithModel:versionChecksum:")]
		NativeHandle Constructor (NSManagedObjectModel model, string versionChecksum);

		[Export ("initWithFileURL:versionChecksum:")]
		NativeHandle Constructor (NSUrl fileUrl, string versionChecksum);

		[Export ("initWithEntityVersionHashes:inBundle:versionChecksum:")]
		NativeHandle Constructor (NSDictionary versionHash, [NullAllowed] NSBundle bundle, string versionChecksum);

		[Export ("initWithName:inBundle:versionChecksum:")]
		NativeHandle Constructor (string modelName, [NullAllowed] NSBundle bundle, string versionChecksum);
	}

	[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
	[BaseType (typeof (NSMigrationStage))]
	[DisableDefaultCtor]
	interface NSLightweightMigrationStage {
		[Export ("versionChecksums", ArgumentSemantic.Strong)]
		string [] VersionChecksums { get; }

		[Export ("initWithVersionChecksums:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string [] versionChecksums);
	}

	[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
	[BaseType (typeof (NSAttributeDescription))]
	interface NSCompositeAttributeDescription {
		[Export ("elements", ArgumentSemantic.Copy)]
		NSAttributeDescription [] Elements { get; set; }
	}

	[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
	[BaseType (typeof (NSMigrationStage))]
	[DisableDefaultCtor]
	interface NSCustomMigrationStage {
		[Export ("currentModel", ArgumentSemantic.Strong)]
		NSManagedObjectModelReference CurrentModel { get; }

		[Export ("nextModel", ArgumentSemantic.Strong)]
		NSManagedObjectModelReference NextModel { get; }

		[NullAllowed]
		[Export ("willMigrateHandler", ArgumentSemantic.Copy)]
		Func<NSStagedMigrationManager, NSCustomMigrationStage, NSError, bool> WillMigrateHandler { get; set; }

		[NullAllowed]
		[Export ("didMigrateHandler", ArgumentSemantic.Copy)]
		Func<NSStagedMigrationManager, NSCustomMigrationStage, NSError, bool> DidMigrateHandler { get; set; }

		[Export ("initWithCurrentModelReference:nextModelReference:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSManagedObjectModelReference currentModel, NSManagedObjectModelReference nextModel);
	}
}
