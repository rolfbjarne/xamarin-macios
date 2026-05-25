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
namespace Contacts {
	/// <summary>The system's contact database.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Contacts/Reference/CNContactStore_Class/index.html">Apple documentation for <c>CNContactStore</c></related>
	[Register("CNContactStore", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class CNContactStore : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAuthorizationStatusForEntityType_X = "authorizationStatusForEntityType:";
		static readonly NativeHandle selAuthorizationStatusForEntityType_XHandle = Selector.GetHandle ("authorizationStatusForEntityType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContainersMatchingPredicate_Error_X = "containersMatchingPredicate:error:";
		static readonly NativeHandle selContainersMatchingPredicate_Error_XHandle = Selector.GetHandle ("containersMatchingPredicate:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentHistoryTokenX = "currentHistoryToken";
		static readonly NativeHandle selCurrentHistoryTokenXHandle = Selector.GetHandle ("currentHistoryToken");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultContainerIdentifierX = "defaultContainerIdentifier";
		static readonly NativeHandle selDefaultContainerIdentifierXHandle = Selector.GetHandle ("defaultContainerIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateContactsWithFetchRequest_Error_UsingBlock_X = "enumerateContactsWithFetchRequest:error:usingBlock:";
		static readonly NativeHandle selEnumerateContactsWithFetchRequest_Error_UsingBlock_XHandle = Selector.GetHandle ("enumerateContactsWithFetchRequest:error:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumeratorForChangeHistoryFetchRequest_Error_X = "enumeratorForChangeHistoryFetchRequest:error:";
		static readonly NativeHandle selEnumeratorForChangeHistoryFetchRequest_Error_XHandle = Selector.GetHandle ("enumeratorForChangeHistoryFetchRequest:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumeratorForContactFetchRequest_Error_X = "enumeratorForContactFetchRequest:error:";
		static readonly NativeHandle selEnumeratorForContactFetchRequest_Error_XHandle = Selector.GetHandle ("enumeratorForContactFetchRequest:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExecuteSaveRequest_Error_X = "executeSaveRequest:error:";
		static readonly NativeHandle selExecuteSaveRequest_Error_XHandle = Selector.GetHandle ("executeSaveRequest:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGroupsMatchingPredicate_Error_X = "groupsMatchingPredicate:error:";
		static readonly NativeHandle selGroupsMatchingPredicate_Error_XHandle = Selector.GetHandle ("groupsMatchingPredicate:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestAccessForEntityType_CompletionHandler_X = "requestAccessForEntityType:completionHandler:";
		static readonly NativeHandle selRequestAccessForEntityType_CompletionHandler_XHandle = Selector.GetHandle ("requestAccessForEntityType:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnifiedContactWithIdentifier_KeysToFetch_Error_X = "unifiedContactWithIdentifier:keysToFetch:error:";
		static readonly NativeHandle selUnifiedContactWithIdentifier_KeysToFetch_Error_XHandle = Selector.GetHandle ("unifiedContactWithIdentifier:keysToFetch:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnifiedContactsMatchingPredicate_KeysToFetch_Error_X = "unifiedContactsMatchingPredicate:keysToFetch:error:";
		static readonly NativeHandle selUnifiedContactsMatchingPredicate_KeysToFetch_Error_XHandle = Selector.GetHandle ("unifiedContactsMatchingPredicate:keysToFetch:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnifiedMeContactWithKeysToFetch_Error_X = "unifiedMeContactWithKeysToFetch:error:";
		static readonly NativeHandle selUnifiedMeContactWithKeysToFetch_Error_XHandle = Selector.GetHandle ("unifiedMeContactWithKeysToFetch:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CNContactStore");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CNContactStore" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CNContactStore () : base (NSObjectFlag.Empty)
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
		protected CNContactStore (NSObjectFlag t) : base (t)
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
		protected internal CNContactStore (NativeHandle handle) : base (handle)
		{
		}

		[Export ("enumerateContactsWithFetchRequest:error:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool EnumerateContacts (CNContactFetchRequest fetchRequest, out NSError? error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCNContactStoreListContactsHandler))]CNContactStoreListContactsHandler handler)
		{
			var fetchRequest__handle__ = fetchRequest!.GetNonNullHandle (nameof (fetchRequest));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			NativeHandle errorValue = IntPtr.Zero;
			using var block_handler = Trampolines.SDCNContactStoreListContactsHandler.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle_NativeHandle (this.Handle, selEnumerateContactsWithFetchRequest_Error_UsingBlock_XHandle, fetchRequest__handle__, &errorValue, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle_NativeHandle (&__objc_super__, selEnumerateContactsWithFetchRequest_Error_UsingBlock_XHandle, fetchRequest__handle__, &errorValue, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fetchRequest);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("executeSaveRequest:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ExecuteSaveRequest (CNSaveRequest saveRequest, out NSError? error)
		{
			var saveRequest__handle__ = saveRequest!.GetNonNullHandle (nameof (saveRequest));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selExecuteSaveRequest_Error_XHandle, saveRequest__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selExecuteSaveRequest_Error_XHandle, saveRequest__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (saveRequest);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("authorizationStatusForEntityType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CNAuthorizationStatus GetAuthorizationStatus (CNEntityType entityType)
		{
			CNAuthorizationStatus ret;
			ret = (CNAuthorizationStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selAuthorizationStatusForEntityType_XHandle, (IntPtr) (long) entityType);
			return ret!;
		}
		[Export ("containersMatchingPredicate:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual CNContainer[]? GetContainers (NSPredicate? predicate, out NSError? error)
		{
			var predicate__handle__ = predicate.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			CNContainer[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<CNContainer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selContainersMatchingPredicate_Error_XHandle, predicate__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<CNContainer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selContainersMatchingPredicate_Error_XHandle, predicate__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (predicate);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("enumeratorForChangeHistoryFetchRequest:error:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual CNFetchResult<NSEnumerator<CNChangeHistoryEvent>>? GetEnumeratorForChangeHistory (CNChangeHistoryFetchRequest request, out NSError? error)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			NativeHandle errorValue = IntPtr.Zero;
			CNFetchResult<NSEnumerator<CNChangeHistoryEvent>>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CNFetchResult<NSEnumerator<CNChangeHistoryEvent>>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selEnumeratorForChangeHistoryFetchRequest_Error_XHandle, request__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CNFetchResult<NSEnumerator<CNChangeHistoryEvent>>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selEnumeratorForChangeHistoryFetchRequest_Error_XHandle, request__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("enumeratorForContactFetchRequest:error:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual CNFetchResult<NSEnumerator<CNContact>>? GetEnumeratorForContact (CNContactFetchRequest request, out NSError? error)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			NativeHandle errorValue = IntPtr.Zero;
			CNFetchResult<NSEnumerator<CNContact>>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CNFetchResult<NSEnumerator<CNContact>>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selEnumeratorForContactFetchRequest_Error_XHandle, request__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CNFetchResult<NSEnumerator<CNContact>>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selEnumeratorForContactFetchRequest_Error_XHandle, request__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("groupsMatchingPredicate:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual CNGroup[]? GetGroups (NSPredicate? predicate, out NSError? error)
		{
			var predicate__handle__ = predicate.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			CNGroup[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<CNGroup>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selGroupsMatchingPredicate_Error_XHandle, predicate__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<CNGroup>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selGroupsMatchingPredicate_Error_XHandle, predicate__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (predicate);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("unifiedContactWithIdentifier:keysToFetch:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected unsafe virtual CNContact? GetUnifiedContact (string identifier, NSArray keys, out NSError? error)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var keys__handle__ = keys!.GetNonNullHandle (nameof (keys));
			NativeHandle errorValue = IntPtr.Zero;
			var nsidentifier = CFString.CreateNative (identifier);
			CNContact? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CNContact> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selUnifiedContactWithIdentifier_KeysToFetch_Error_XHandle, nsidentifier, keys__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CNContact> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selUnifiedContactWithIdentifier_KeysToFetch_Error_XHandle, nsidentifier, keys__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (keys);
			CFString.ReleaseNative (nsidentifier);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("unifiedContactsMatchingPredicate:keysToFetch:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected unsafe virtual CNContact[]? GetUnifiedContacts (NSPredicate predicate, NSArray keys, out NSError? error)
		{
			var predicate__handle__ = predicate!.GetNonNullHandle (nameof (predicate));
			var keys__handle__ = keys!.GetNonNullHandle (nameof (keys));
			NativeHandle errorValue = IntPtr.Zero;
			CNContact[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<CNContact>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selUnifiedContactsMatchingPredicate_KeysToFetch_Error_XHandle, predicate__handle__, keys__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<CNContact>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selUnifiedContactsMatchingPredicate_KeysToFetch_Error_XHandle, predicate__handle__, keys__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (predicate);
			GC.KeepAlive (keys);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("unifiedMeContactWithKeysToFetch:error:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected unsafe virtual NSObject? GetUnifiedMeContact (NSArray keys, out NSError? error)
		{
			var keys__handle__ = keys!.GetNonNullHandle (nameof (keys));
			NativeHandle errorValue = IntPtr.Zero;
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selUnifiedMeContactWithKeysToFetch_Error_XHandle, keys__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selUnifiedMeContactWithKeysToFetch_Error_XHandle, keys__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (keys);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("requestAccessForEntityType:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestAccess (CNEntityType entityType, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCNContactStoreRequestAccessHandler))]CNContactStoreRequestAccessHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDCNContactStoreRequestAccessHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, selRequestAccessForEntityType_CompletionHandler_XHandle, (IntPtr) (long) entityType, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selRequestAccessForEntityType_CompletionHandler_XHandle, (IntPtr) (long) entityType, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="entityType">To be added.</param>
		/// <summary>Requests access to the user's contacts.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous RequestAccess operation.   The value of the TResult parameter is a Contacts.CNContactStoreRequestAccessHandler.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The RequestAccessAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError?>> RequestAccessAsync (CNEntityType entityType)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			RequestAccess(entityType, (granted_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (granted_, error_));
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSData? CurrentHistoryToken {
			[Export ("currentHistoryToken", ArgumentSemantic.Copy)]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentHistoryTokenXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentHistoryTokenXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? DefaultContainerIdentifier {
			[Export ("defaultContainerIdentifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDefaultContainerIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDefaultContainerIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NotificationDidChange;
		/// <summary>Notification constant for NotificationDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveNotificationDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveNotificationDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = CNContactStore.Notifications.ObserveNotificationDidChange ((sender, args) => {
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
		/// void Callback (object sender, CNContactStore.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = CNContactStore.Notifications.ObserveNotificationDidChange (Callback);
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
		///     CNContactStore.NotificationDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification NotificationDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification NotificationDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (CNContactStore.NotificationDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("CNContactStoreDidChangeNotification",  "Contacts")]
		[Advice ("Use CNContactStore.Notifications.ObserveNotificationDidChange helper method instead.")]
		public static NSString NotificationDidChange {
			get {
				if (_NotificationDidChange is null)
					_NotificationDidChange = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactStoreDidChangeNotification")!;
				return _NotificationDidChange;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::Contacts.CNContactStore" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::Contacts.CNContactStore.NotificationDidChange" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Contacts.CNContactStore.NotificationDidChange" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = CNContactStore.Notifications.ObserveNotificationDidChange ((notification) => {
			///   Console.WriteLine ("Observed NotificationDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveNotificationDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (NotificationDidChange, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::Contacts.CNContactStore.NotificationDidChange" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Contacts.CNContactStore.NotificationDidChange" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = CNContactStore.Notifications.ObserveNotificationDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed NotificationDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveNotificationDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (NotificationDidChange, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class CNContactStore */
}
