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
	/// <summary>Strategy for resolving conflicts between in-memory objects and those in persistent stores.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreData/Reference/NSMergePolicy_Class/index.html">Apple documentation for <c>NSMergePolicy</c></related>
	[Register("NSMergePolicy", true)]
	public unsafe partial class NSMergePolicy : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selErrorMergePolicyX = "errorMergePolicy";
		static readonly NativeHandle selErrorMergePolicyXHandle = Selector.GetHandle ("errorMergePolicy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithMergeType_X = "initWithMergeType:";
		static readonly NativeHandle selInitWithMergeType_XHandle = Selector.GetHandle ("initWithMergeType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMergeByPropertyObjectTrumpMergePolicyX = "mergeByPropertyObjectTrumpMergePolicy";
		static readonly NativeHandle selMergeByPropertyObjectTrumpMergePolicyXHandle = Selector.GetHandle ("mergeByPropertyObjectTrumpMergePolicy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMergeByPropertyStoreTrumpMergePolicyX = "mergeByPropertyStoreTrumpMergePolicy";
		static readonly NativeHandle selMergeByPropertyStoreTrumpMergePolicyXHandle = Selector.GetHandle ("mergeByPropertyStoreTrumpMergePolicy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMergeTypeX = "mergeType";
		static readonly NativeHandle selMergeTypeXHandle = Selector.GetHandle ("mergeType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOverwriteMergePolicyX = "overwriteMergePolicy";
		static readonly NativeHandle selOverwriteMergePolicyXHandle = Selector.GetHandle ("overwriteMergePolicy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResolveConflicts_Error_X = "resolveConflicts:error:";
		static readonly NativeHandle selResolveConflicts_Error_XHandle = Selector.GetHandle ("resolveConflicts:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResolveConstraintConflicts_Error_X = "resolveConstraintConflicts:error:";
		static readonly NativeHandle selResolveConstraintConflicts_Error_XHandle = Selector.GetHandle ("resolveConstraintConflicts:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResolveOptimisticLockingVersionConflicts_Error_X = "resolveOptimisticLockingVersionConflicts:error:";
		static readonly NativeHandle selResolveOptimisticLockingVersionConflicts_Error_XHandle = Selector.GetHandle ("resolveOptimisticLockingVersionConflicts:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRollbackMergePolicyX = "rollbackMergePolicy";
		static readonly NativeHandle selRollbackMergePolicyXHandle = Selector.GetHandle ("rollbackMergePolicy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSMergePolicy");
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
		protected NSMergePolicy (NSObjectFlag t) : base (t)
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
		protected internal NSMergePolicy (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="ty">To be added.</param><summary>Creates a new <see cref="T:CoreData.NSMergePolicy" /> from the specified merege policy type.</summary><remarks>To be added.</remarks>
		[Export ("initWithMergeType:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSMergePolicy (NSMergePolicyType ty)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selInitWithMergeType_XHandle, (UIntPtr) (ulong) ty), "initWithMergeType:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selInitWithMergeType_XHandle, (UIntPtr) (ulong) ty), "initWithMergeType:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="list">To be added.</param><param name="error">To be added.</param><summary>Attempts to resolve the specified conflicts, and reports any errors.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resolveConflicts:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ResolveConflicts (NSMergeConflict[] list, out NSError error)
		{
			if (list is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (list));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_list = NSArray.FromNSObjects (list);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selResolveConflicts_Error_XHandle, nsa_list.Handle, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selResolveConflicts_Error_XHandle, nsa_list.Handle, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="list">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Attempts to resolve the specified constraint conflicts, and reports any errors.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resolveConstraintConflicts:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ResolveConstraintConflicts (NSConstraintConflict[] list, out NSError error)
		{
			if (list is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (list));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_list = NSArray.FromNSObjects (list);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selResolveConstraintConflicts_Error_XHandle, nsa_list.Handle, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selResolveConstraintConflicts_Error_XHandle, nsa_list.Handle, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="list">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Attempts to resolve the specified locking constraint conflicts, and reports any errors.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resolveOptimisticLockingVersionConflicts:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ResolveOptimisticLockingVersionConflicts (NSMergeConflict[] list, out NSError error)
		{
			if (list is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (list));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_list = NSArray.FromNSObjects (list);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selResolveOptimisticLockingVersionConflicts_Error_XHandle, nsa_list.Handle, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selResolveOptimisticLockingVersionConflicts_Error_XHandle, nsa_list.Handle, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <summary>Gets a value that indicates that saving will fail if an error is encountered.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSMergePolicy ErrorPolicy {
			[Export ("errorMergePolicy", ArgumentSemantic.Retain)]
			get {
				NSMergePolicy? ret;
				ret =  Runtime.GetNSObject<NSMergePolicy> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selErrorMergePolicyXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>Gets a value that indicates that the property object is favored during merges.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSMergePolicy MergeByPropertyObjectTrumpPolicy {
			[Export ("mergeByPropertyObjectTrumpMergePolicy", ArgumentSemantic.Retain)]
			get {
				NSMergePolicy? ret;
				ret =  Runtime.GetNSObject<NSMergePolicy> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMergeByPropertyObjectTrumpMergePolicyXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>Gets a value that indicates that the property store is favored during merges.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSMergePolicy MergeByPropertyStoreTrumpPolicy {
			[Export ("mergeByPropertyStoreTrumpMergePolicy", ArgumentSemantic.Retain)]
			get {
				NSMergePolicy? ret;
				ret =  Runtime.GetNSObject<NSMergePolicy> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMergeByPropertyStoreTrumpMergePolicyXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>Gets the policy's merge type.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMergePolicyType MergeType {
			[Export ("mergeType")]
			get {
				NSMergePolicyType ret;
				if (IsDirectBinding) {
					ret = (CoreData.NSMergePolicyType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMergeTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CoreData.NSMergePolicyType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMergeTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets a value that controls policy for handling overwrites.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSMergePolicy OverwritePolicy {
			[Export ("overwriteMergePolicy", ArgumentSemantic.Retain)]
			get {
				NSMergePolicy? ret;
				ret =  Runtime.GetNSObject<NSMergePolicy> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selOverwriteMergePolicyXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>Gets a value that indicates tha in-memory state changes are discarded for conflicting objects.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSMergePolicy RollbackPolicy {
			[Export ("rollbackMergePolicy", ArgumentSemantic.Retain)]
			get {
				NSMergePolicy? ret;
				ret =  Runtime.GetNSObject<NSMergePolicy> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selRollbackMergePolicyXHandle), false)!;
				return ret!;
			}
		}
	} /* class NSMergePolicy */
}
