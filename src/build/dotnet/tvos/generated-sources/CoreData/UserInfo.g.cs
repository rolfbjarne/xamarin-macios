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
	/// <summary>Contains Core Data error information.</summary><remarks>To be added.</remarks>
	public partial class UserInfo : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="UserInfo" /> with default (empty) values.</summary>
		public UserInfo () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="UserInfo" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public UserInfo (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>Gets or sets an array that contains the multiple errors that occurred, if multiple errors occurred.</summary><value>An array of <see cref="T:Foundation.NSError" /> objects that contains the errors that occurred.</value><remarks>To be added.</remarks>
		public NSError[]? DetailedErrors {
			get {
				return GetArray<NSError> (UserInfoKeys.DetailedErrorsKey!);
			}
			set {
				SetArrayValue (UserInfoKeys.DetailedErrorsKey!, value);
			}
		}
		/// <summary>Gets or sets the object that failed validation.</summary><value>The object that failed validation.</value><remarks>To be added.</remarks>
		public NSManagedObject? ObjectForValidationError {
			get {
				return Dictionary [UserInfoKeys.ObjectForValidationErrorKey!] as CoreData.NSManagedObject;
			}
			set {
				SetNativeValue (UserInfoKeys.ObjectForValidationErrorKey!, value);
			}
		}
		/// <summary>Gets or sets the key that identifies the validation error that occurred.</summary><value>The key that identifies the validation error that occurred.</value><remarks>To be added.</remarks>
		public NSString? KeyForValidationError {
			get {
				return GetNSStringValue (UserInfoKeys.KeyForValidationErrorKey!);
			}
			set {
				SetStringValue (UserInfoKeys.KeyForValidationErrorKey!, value);
			}
		}
		/// <summary>Gets or sets the predicate that failed validation.</summary><value>The <see cref="T:Foundation.NSPredicate" /> object for the predicate that failed.</value><remarks>To be added.</remarks>
		public NSPredicate? PredicateForValidationError {
			get {
				return Dictionary [UserInfoKeys.PredicateForValidationErrorKey!] as Foundation.NSPredicate;
			}
			set {
				SetNativeValue (UserInfoKeys.PredicateForValidationErrorKey!, value);
			}
		}
		/// <summary>Gets or sets the value that failed validation.</summary><value>The value that failed validation.</value><remarks>To be added.</remarks>
		public NSValue? ValueForValidationError {
			get {
				return Dictionary [UserInfoKeys.ValueForValidationErrorKey!] as Foundation.NSValue;
			}
			set {
				SetNativeValue (UserInfoKeys.ValueForValidationErrorKey!, value);
			}
		}
		/// <summary>Gets or sets the array of merge conflicts.</summary><value>An array of <see cref="T:CoreData.NSMergeConflict" /> objects.</value><remarks>To be added.</remarks>
		public NSMergeConflict[]? PersistentStoreSaveConflicts {
			get {
				return GetArray<NSMergeConflict> (UserInfoKeys.PersistentStoreSaveConflictsKey!);
			}
			set {
				SetArrayValue (UserInfoKeys.PersistentStoreSaveConflictsKey!, value);
			}
		}
		/// <summary>Gets or sets an array that contains the stores that were affected by the error.</summary><value>An array that contains the stores that were affected by the error.</value><remarks>To be added.</remarks>
		public NSPersistentStore[]? AffectedStoresForError {
			get {
				return GetArray<NSPersistentStore> (UserInfoKeys.AffectedStoresForErrorKey!);
			}
			set {
				SetArrayValue (UserInfoKeys.AffectedStoresForErrorKey!, value);
			}
		}
#endif
	}
}
