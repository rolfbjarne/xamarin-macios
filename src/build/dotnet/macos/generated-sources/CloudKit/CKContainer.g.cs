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
namespace CloudKit {
	[Register("CKContainer", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class CKContainer : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAcceptShareMetadata_CompletionHandler_X = "acceptShareMetadata:completionHandler:";
		static readonly NativeHandle selAcceptShareMetadata_CompletionHandler_XHandle = Selector.GetHandle ("acceptShareMetadata:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccountStatusWithCompletionHandler_X = "accountStatusWithCompletionHandler:";
		static readonly NativeHandle selAccountStatusWithCompletionHandler_XHandle = Selector.GetHandle ("accountStatusWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddOperation_X = "addOperation:";
		static readonly NativeHandle selAddOperation_XHandle = Selector.GetHandle ("addOperation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContainerIdentifierX = "containerIdentifier";
		static readonly NativeHandle selContainerIdentifierXHandle = Selector.GetHandle ("containerIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContainerWithIdentifier_X = "containerWithIdentifier:";
		static readonly NativeHandle selContainerWithIdentifier_XHandle = Selector.GetHandle ("containerWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDatabaseWithDatabaseScope_X = "databaseWithDatabaseScope:";
		static readonly NativeHandle selDatabaseWithDatabaseScope_XHandle = Selector.GetHandle ("databaseWithDatabaseScope:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultContainerX = "defaultContainer";
		static readonly NativeHandle selDefaultContainerXHandle = Selector.GetHandle ("defaultContainer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDiscoverAllIdentitiesWithCompletionHandler_X = "discoverAllIdentitiesWithCompletionHandler:";
		static readonly NativeHandle selDiscoverAllIdentitiesWithCompletionHandler_XHandle = Selector.GetHandle ("discoverAllIdentitiesWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDiscoverUserIdentityWithEmailAddress_CompletionHandler_X = "discoverUserIdentityWithEmailAddress:completionHandler:";
		static readonly NativeHandle selDiscoverUserIdentityWithEmailAddress_CompletionHandler_XHandle = Selector.GetHandle ("discoverUserIdentityWithEmailAddress:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDiscoverUserIdentityWithPhoneNumber_CompletionHandler_X = "discoverUserIdentityWithPhoneNumber:completionHandler:";
		static readonly NativeHandle selDiscoverUserIdentityWithPhoneNumber_CompletionHandler_XHandle = Selector.GetHandle ("discoverUserIdentityWithPhoneNumber:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDiscoverUserIdentityWithUserRecordID_CompletionHandler_X = "discoverUserIdentityWithUserRecordID:completionHandler:";
		static readonly NativeHandle selDiscoverUserIdentityWithUserRecordID_CompletionHandler_XHandle = Selector.GetHandle ("discoverUserIdentityWithUserRecordID:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchAllLongLivedOperationIDsWithCompletionHandler_X = "fetchAllLongLivedOperationIDsWithCompletionHandler:";
		static readonly NativeHandle selFetchAllLongLivedOperationIDsWithCompletionHandler_XHandle = Selector.GetHandle ("fetchAllLongLivedOperationIDsWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchLongLivedOperationWithID_CompletionHandler_X = "fetchLongLivedOperationWithID:completionHandler:";
		static readonly NativeHandle selFetchLongLivedOperationWithID_CompletionHandler_XHandle = Selector.GetHandle ("fetchLongLivedOperationWithID:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchShareMetadataWithURL_CompletionHandler_X = "fetchShareMetadataWithURL:completionHandler:";
		static readonly NativeHandle selFetchShareMetadataWithURL_CompletionHandler_XHandle = Selector.GetHandle ("fetchShareMetadataWithURL:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchShareParticipantWithEmailAddress_CompletionHandler_X = "fetchShareParticipantWithEmailAddress:completionHandler:";
		static readonly NativeHandle selFetchShareParticipantWithEmailAddress_CompletionHandler_XHandle = Selector.GetHandle ("fetchShareParticipantWithEmailAddress:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchShareParticipantWithPhoneNumber_CompletionHandler_X = "fetchShareParticipantWithPhoneNumber:completionHandler:";
		static readonly NativeHandle selFetchShareParticipantWithPhoneNumber_CompletionHandler_XHandle = Selector.GetHandle ("fetchShareParticipantWithPhoneNumber:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchShareParticipantWithUserRecordID_CompletionHandler_X = "fetchShareParticipantWithUserRecordID:completionHandler:";
		static readonly NativeHandle selFetchShareParticipantWithUserRecordID_CompletionHandler_XHandle = Selector.GetHandle ("fetchShareParticipantWithUserRecordID:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchUserRecordIDWithCompletionHandler_X = "fetchUserRecordIDWithCompletionHandler:";
		static readonly NativeHandle selFetchUserRecordIDWithCompletionHandler_XHandle = Selector.GetHandle ("fetchUserRecordIDWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrivateCloudDatabaseX = "privateCloudDatabase";
		static readonly NativeHandle selPrivateCloudDatabaseXHandle = Selector.GetHandle ("privateCloudDatabase");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPublicCloudDatabaseX = "publicCloudDatabase";
		static readonly NativeHandle selPublicCloudDatabaseXHandle = Selector.GetHandle ("publicCloudDatabase");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestApplicationPermission_CompletionHandler_X = "requestApplicationPermission:completionHandler:";
		static readonly NativeHandle selRequestApplicationPermission_CompletionHandler_XHandle = Selector.GetHandle ("requestApplicationPermission:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedCloudDatabaseX = "sharedCloudDatabase";
		static readonly NativeHandle selSharedCloudDatabaseXHandle = Selector.GetHandle ("sharedCloudDatabase");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStatusForApplicationPermission_CompletionHandler_X = "statusForApplicationPermission:completionHandler:";
		static readonly NativeHandle selStatusForApplicationPermission_CompletionHandler_XHandle = Selector.GetHandle ("statusForApplicationPermission:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CKContainer");
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
		protected CKContainer (NSObjectFlag t) : base (t)
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
		protected internal CKContainer (NativeHandle handle) : base (handle)
		{
		}

		[Export ("acceptShareMetadata:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AcceptShareMetadata (CKShareMetadata metadata, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V40))]global::System.Action<CKShare, NSError> completionHandler)
		{
			var metadata__handle__ = metadata!.GetNonNullHandle (nameof (metadata));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V40.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAcceptShareMetadata_CompletionHandler_XHandle, metadata__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAcceptShareMetadata_CompletionHandler_XHandle, metadata__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (metadata);
		}
		/// <param name="metadata">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous AcceptShareMetadata operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKShare,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The AcceptShareMetadataAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKShare> AcceptShareMetadataAsync (CKShareMetadata metadata)
		{
			var tcs = new TaskCompletionSource<CKShare> ();
			AcceptShareMetadata(metadata, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("addOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddOperation (CKOperation operation)
		{
			var operation__handle__ = operation!.GetNonNullHandle (nameof (operation));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddOperation_XHandle, operation__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddOperation_XHandle, operation__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (operation);
		}
		[Export ("discoverAllIdentitiesWithCompletionHandler:")]
		[ObsoletedOSPlatform ("macos14.0")]
		[ObsoletedOSPlatform ("ios17.0")]
		[ObsoletedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DiscoverAllIdentities ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V41))]global::System.Action<CKUserIdentity[], NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V41.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDiscoverAllIdentitiesWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDiscoverAllIdentitiesWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Fetches all user records in the <see cref="CloudKit.CKContainer" /> that correspond to an entry in the user's address book.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous DiscoverAllIdentities operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKUserIdentity[],Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para>The "identity discovery" methods in <see cref="CloudKit.CKContainer" /> allow the developer to implement "friends who also use" functionality in their apps. These methods can be used to find user records in the CloudKit container that correspond to entries in the user's address book. No information about the user, beyond the fact that they use the app and agreed to share that status, is available from the <see cref="CloudKit.CKContainer" />.</para>
		///         </remarks>
		[ObsoletedOSPlatform ("macos14.0")]
		[ObsoletedOSPlatform ("ios17.0")]
		[ObsoletedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKUserIdentity[]> DiscoverAllIdentitiesAsync ()
		{
			var tcs = new TaskCompletionSource<CKUserIdentity[]> ();
			DiscoverAllIdentities((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("discoverUserIdentityWithUserRecordID:completionHandler:")]
		[ObsoletedOSPlatform ("macos14.0")]
		[ObsoletedOSPlatform ("ios17.0")]
		[ObsoletedOSPlatform ("tvos17.0")]
		[ObsoletedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DiscoverUserIdentity (CKRecordID userRecordID, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V42))]global::System.Action<CKUserIdentity, NSError> completionHandler)
		{
			var userRecordID__handle__ = userRecordID!.GetNonNullHandle (nameof (userRecordID));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V42.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDiscoverUserIdentityWithUserRecordID_CompletionHandler_XHandle, userRecordID__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDiscoverUserIdentityWithUserRecordID_CompletionHandler_XHandle, userRecordID__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (userRecordID);
		}
		/// <param name="userRecordID">To be added.</param>
		/// <summary>Retrieves the <see cref="CloudKit.CKUserIdentity" /> data for the record with specified <paramref name="userRecordID" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous DiscoverUserIdentity operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKUserIdentity,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para>The "identity discovery" methods in <see cref="CloudKit.CKContainer" /> allow the developer to implement "friends who also use" functionality in their apps. These methods can be used to find user records in the CloudKit container that correspond to entries in the user's address book. No information about the user, beyond the fact that they use the app and agreed to share that status, is available from the <see cref="CloudKit.CKContainer" />.</para>
		///         </remarks>
		[ObsoletedOSPlatform ("macos14.0")]
		[ObsoletedOSPlatform ("ios17.0")]
		[ObsoletedOSPlatform ("tvos17.0")]
		[ObsoletedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKUserIdentity> DiscoverUserIdentityAsync (CKRecordID userRecordID)
		{
			var tcs = new TaskCompletionSource<CKUserIdentity> ();
			DiscoverUserIdentity(userRecordID, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("discoverUserIdentityWithEmailAddress:completionHandler:")]
		[ObsoletedOSPlatform ("macos14.0")]
		[ObsoletedOSPlatform ("ios17.0")]
		[ObsoletedOSPlatform ("tvos17.0")]
		[ObsoletedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DiscoverUserIdentityWithEmailAddress (string email, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V42))]global::System.Action<CKUserIdentity, NSError> completionHandler)
		{
			if (email is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (email));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsemail = CFString.CreateNative (email);
			using var block_completionHandler = Trampolines.SDActionArity2V42.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDiscoverUserIdentityWithEmailAddress_CompletionHandler_XHandle, nsemail, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDiscoverUserIdentityWithEmailAddress_CompletionHandler_XHandle, nsemail, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsemail);
		}
		/// <param name="email">To be added.</param>
		/// <summary>Retrieves the <see cref="CloudKit.CKUserIdentity" /> data for the record with specified <paramref name="email" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous DiscoverUserIdentityWithEmailAddress operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKUserIdentity,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para>The "identity discovery" methods in <see cref="CloudKit.CKContainer" /> allow the developer to implement "friends who also use" functionality in their apps. These methods can be used to find user records in the CloudKit container that correspond to entries in the user's address book. No information about the user, beyond the fact that they use the app and agreed to share that status, is available from the <see cref="CloudKit.CKContainer" />.</para>
		///         </remarks>
		[ObsoletedOSPlatform ("macos14.0")]
		[ObsoletedOSPlatform ("ios17.0")]
		[ObsoletedOSPlatform ("tvos17.0")]
		[ObsoletedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKUserIdentity> DiscoverUserIdentityWithEmailAddressAsync (string email)
		{
			var tcs = new TaskCompletionSource<CKUserIdentity> ();
			DiscoverUserIdentityWithEmailAddress(email, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("discoverUserIdentityWithPhoneNumber:completionHandler:")]
		[ObsoletedOSPlatform ("macos14.0")]
		[ObsoletedOSPlatform ("ios17.0")]
		[ObsoletedOSPlatform ("tvos17.0")]
		[ObsoletedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DiscoverUserIdentityWithPhoneNumber (string phoneNumber, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V42))]global::System.Action<CKUserIdentity, NSError> completionHandler)
		{
			if (phoneNumber is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (phoneNumber));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsphoneNumber = CFString.CreateNative (phoneNumber);
			using var block_completionHandler = Trampolines.SDActionArity2V42.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDiscoverUserIdentityWithPhoneNumber_CompletionHandler_XHandle, nsphoneNumber, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDiscoverUserIdentityWithPhoneNumber_CompletionHandler_XHandle, nsphoneNumber, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsphoneNumber);
		}
		/// <param name="phoneNumber">To be added.</param>
		/// <summary>Retrieves the <see cref="CloudKit.CKUserIdentity" /> data for the record with specified <paramref name="phoneNumber" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous DiscoverUserIdentityWithPhoneNumber operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKUserIdentity,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para>The "identity discovery" methods in <see cref="CloudKit.CKContainer" /> allow the developer to implement "friends who also use" functionality in their apps. These methods can be used to find user records in the CloudKit container that correspond to entries in the user's address book. No information about the user, beyond the fact that they use the app and agreed to share that status, is available from the <see cref="CloudKit.CKContainer" />.</para>
		///         </remarks>
		[ObsoletedOSPlatform ("macos14.0")]
		[ObsoletedOSPlatform ("ios17.0")]
		[ObsoletedOSPlatform ("tvos17.0")]
		[ObsoletedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKUserIdentity> DiscoverUserIdentityWithPhoneNumberAsync (string phoneNumber)
		{
			var tcs = new TaskCompletionSource<CKUserIdentity> ();
			DiscoverUserIdentityWithPhoneNumber(phoneNumber, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("fetchAllLongLivedOperationIDsWithCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchAllLongLivedOperationIDs ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V43))]global::System.Action<NSDictionary<NSString, NSOperation>, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V43.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFetchAllLongLivedOperationIDsWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFetchAllLongLivedOperationIDsWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Returns an array that contains the identifiers for all the currently active long-lived operations.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous FetchAllLongLivedOperationIDs operation.  The value of the TResult parameter is of type System.Action&lt;Foundation.NSDictionary&lt;Foundation.NSString,Foundation.NSOperation&gt;,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSDictionary<NSString, NSOperation>> FetchAllLongLivedOperationIDsAsync ()
		{
			var tcs = new TaskCompletionSource<NSDictionary<NSString, NSOperation>> ();
			FetchAllLongLivedOperationIDs((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("fetchLongLivedOperationWithID:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchLongLivedOperation (string[] operationID, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V43))]global::System.Action<NSDictionary<NSString, NSOperation>, NSError> completionHandler)
		{
			if (operationID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (operationID));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_operationID = NSArray.FromStrings (operationID);
			using var block_completionHandler = Trampolines.SDActionArity2V43.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFetchLongLivedOperationWithID_CompletionHandler_XHandle, nsa_operationID.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFetchLongLivedOperationWithID_CompletionHandler_XHandle, nsa_operationID.Handle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="operationID">The ID of the long-lived operation to fetch.</param>
		/// <summary>Fetches the long-lived operation that is identified by <paramref name="operationID" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous FetchLongLivedOperation operation.  The value of the TResult parameter is of type System.Action&lt;Foundation.NSDictionary&lt;Foundation.NSString,Foundation.NSOperation&gt;,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSDictionary<NSString, NSOperation>> FetchLongLivedOperationAsync (string[] operationID)
		{
			var tcs = new TaskCompletionSource<NSDictionary<NSString, NSOperation>> ();
			FetchLongLivedOperation(operationID, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("fetchShareMetadataWithURL:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchShareMetadata (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V44))]global::System.Action<CKShareMetadata, NSError> completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V44.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFetchShareMetadataWithURL_CompletionHandler_XHandle, url__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFetchShareMetadataWithURL_CompletionHandler_XHandle, url__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		/// <param name="url">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous FetchShareMetadata operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKShareMetadata,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKShareMetadata> FetchShareMetadataAsync (NSUrl url)
		{
			var tcs = new TaskCompletionSource<CKShareMetadata> ();
			FetchShareMetadata(url, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("fetchShareParticipantWithUserRecordID:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchShareParticipant (CKRecordID userRecordID, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V45))]global::System.Action<CKShareParticipant, NSError> completionHandler)
		{
			var userRecordID__handle__ = userRecordID!.GetNonNullHandle (nameof (userRecordID));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V45.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFetchShareParticipantWithUserRecordID_CompletionHandler_XHandle, userRecordID__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFetchShareParticipantWithUserRecordID_CompletionHandler_XHandle, userRecordID__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (userRecordID);
		}
		/// <param name="userRecordID">To be added.</param>
		/// <summary>Retrieves the <see cref="CloudKit.CKShareParticipant" /> information for the user who accepted a shared record.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous FetchShareParticipant operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKShareParticipant,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKShareParticipant> FetchShareParticipantAsync (CKRecordID userRecordID)
		{
			var tcs = new TaskCompletionSource<CKShareParticipant> ();
			FetchShareParticipant(userRecordID, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("fetchShareParticipantWithEmailAddress:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchShareParticipantWithEmailAddress (string emailAddress, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V45))]global::System.Action<CKShareParticipant, NSError> completionHandler)
		{
			if (emailAddress is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (emailAddress));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsemailAddress = CFString.CreateNative (emailAddress);
			using var block_completionHandler = Trampolines.SDActionArity2V45.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFetchShareParticipantWithEmailAddress_CompletionHandler_XHandle, nsemailAddress, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFetchShareParticipantWithEmailAddress_CompletionHandler_XHandle, nsemailAddress, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsemailAddress);
		}
		/// <param name="emailAddress">To be added.</param>
		/// <summary>Retrieves the <see cref="CloudKit.CKShareParticipant" /> information for the user who accepted a shared record..</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous FetchShareParticipantWithEmailAddress operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKShareParticipant,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKShareParticipant> FetchShareParticipantWithEmailAddressAsync (string emailAddress)
		{
			var tcs = new TaskCompletionSource<CKShareParticipant> ();
			FetchShareParticipantWithEmailAddress(emailAddress, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("fetchShareParticipantWithPhoneNumber:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchShareParticipantWithPhoneNumber (string phoneNumber, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V45))]global::System.Action<CKShareParticipant, NSError> completionHandler)
		{
			if (phoneNumber is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (phoneNumber));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsphoneNumber = CFString.CreateNative (phoneNumber);
			using var block_completionHandler = Trampolines.SDActionArity2V45.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFetchShareParticipantWithPhoneNumber_CompletionHandler_XHandle, nsphoneNumber, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFetchShareParticipantWithPhoneNumber_CompletionHandler_XHandle, nsphoneNumber, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsphoneNumber);
		}
		/// <param name="phoneNumber">To be added.</param>
		/// <summary>Retrieves the <see cref="CloudKit.CKShareParticipant" /> information for the user who accepted a shared record.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous FetchShareParticipantWithPhoneNumber operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKShareParticipant,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKShareParticipant> FetchShareParticipantWithPhoneNumberAsync (string phoneNumber)
		{
			var tcs = new TaskCompletionSource<CKShareParticipant> ();
			FetchShareParticipantWithPhoneNumber(phoneNumber, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("fetchUserRecordIDWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchUserRecordId ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V46))]global::System.Action<CKRecordID, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V46.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFetchUserRecordIDWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFetchUserRecordIDWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Retrieves the <see cref="CloudKit.CKRecordID" /> of the current user.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous FetchUserRecordId operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKRecordID,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKRecordID> FetchUserRecordIdAsync ()
		{
			var tcs = new TaskCompletionSource<CKRecordID> ();
			FetchUserRecordId((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("containerWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CKContainer FromIdentifier (string containerIdentifier)
		{
			if (containerIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (containerIdentifier));
			var nscontainerIdentifier = CFString.CreateNative (containerIdentifier);
			CKContainer? ret;
			ret =  Runtime.GetNSObject<CKContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selContainerWithIdentifier_XHandle, nscontainerIdentifier), false)!;
			CFString.ReleaseNative (nscontainerIdentifier);
			return ret!;
		}
		[Export ("accountStatusWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetAccountStatus ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V47))]global::System.Action<CKAccountStatus, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V47.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAccountStatusWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAccountStatusWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Retrieves the current user's <see cref="CloudKit.CKAccountStatus" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous GetAccountStatus operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKAccountStatus,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKAccountStatus> GetAccountStatusAsync ()
		{
			var tcs = new TaskCompletionSource<CKAccountStatus> ();
			GetAccountStatus((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("databaseWithDatabaseScope:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKDatabase GetDatabase (CKDatabaseScope databaseScope)
		{
			CKDatabase ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CKDatabase> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selDatabaseWithDatabaseScope_XHandle, (IntPtr) (long) databaseScope), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CKDatabase> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selDatabaseWithDatabaseScope_XHandle, (IntPtr) (long) databaseScope), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("requestApplicationPermission:completionHandler:")]
		[ObsoletedOSPlatform ("macos14.0")]
		[ObsoletedOSPlatform ("ios17.0")]
		[ObsoletedOSPlatform ("tvos17.0")]
		[ObsoletedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestApplicationPermission (CKApplicationPermissions applicationPermission, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V48))]global::System.Action<CKApplicationPermissionStatus, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V48.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle (this.Handle, selRequestApplicationPermission_CompletionHandler_XHandle, (UIntPtr) (ulong) applicationPermission, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, selRequestApplicationPermission_CompletionHandler_XHandle, (UIntPtr) (ulong) applicationPermission, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="applicationPermission">To be added.</param>
		/// <summary>Triggers the system UX for asking the user's permission for the requested <paramref name="applicationPermission" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous RequestApplicationPermission operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKApplicationPermissionStatus,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos14.0")]
		[ObsoletedOSPlatform ("ios17.0")]
		[ObsoletedOSPlatform ("tvos17.0")]
		[ObsoletedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKApplicationPermissionStatus> RequestApplicationPermissionAsync (CKApplicationPermissions applicationPermission)
		{
			var tcs = new TaskCompletionSource<CKApplicationPermissionStatus> ();
			RequestApplicationPermission(applicationPermission, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("statusForApplicationPermission:completionHandler:")]
		[ObsoletedOSPlatform ("macos14.0")]
		[ObsoletedOSPlatform ("ios17.0")]
		[ObsoletedOSPlatform ("tvos17.0")]
		[ObsoletedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void StatusForApplicationPermission (CKApplicationPermissions applicationPermission, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V48))]global::System.Action<CKApplicationPermissionStatus, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V48.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle (this.Handle, selStatusForApplicationPermission_CompletionHandler_XHandle, (UIntPtr) (ulong) applicationPermission, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, selStatusForApplicationPermission_CompletionHandler_XHandle, (UIntPtr) (ulong) applicationPermission, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="applicationPermission">To be added.</param>
		/// <summary>Requests the current <see cref="CloudKit.CKApplicationPermissionStatus" /> for the specified <see cref="CloudKit.CKApplicationPermissions" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous StatusForApplicationPermission operation.  The value of the TResult parameter is of type System.Action&lt;CloudKit.CKApplicationPermissionStatus,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos14.0")]
		[ObsoletedOSPlatform ("ios17.0")]
		[ObsoletedOSPlatform ("tvos17.0")]
		[ObsoletedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CKApplicationPermissionStatus> StatusForApplicationPermissionAsync (CKApplicationPermissions applicationPermission)
		{
			var tcs = new TaskCompletionSource<CKApplicationPermissionStatus> ();
			StatusForApplicationPermission(applicationPermission, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ContainerIdentifier {
			[Export ("containerIdentifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContainerIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContainerIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CKContainer DefaultContainer {
			[Export ("defaultContainer")]
			get {
				CKContainer? ret;
				ret =  Runtime.GetNSObject<CKContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDefaultContainerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKDatabase PrivateCloudDatabase {
			[Export ("privateCloudDatabase")]
			get {
				CKDatabase? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKDatabase> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPrivateCloudDatabaseXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKDatabase> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPrivateCloudDatabaseXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKDatabase PublicCloudDatabase {
			[Export ("publicCloudDatabase")]
			get {
				CKDatabase? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKDatabase> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPublicCloudDatabaseXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKDatabase> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPublicCloudDatabaseXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CKDatabase SharedCloudDatabase {
			[Export ("sharedCloudDatabase")]
			get {
				CKDatabase? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKDatabase> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSharedCloudDatabaseXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKDatabase> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSharedCloudDatabaseXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AccountChangedNotification;
		/// <summary>Notification constant for AccountChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveAccountChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveAccountChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = CKContainer.Notifications.ObserveAccountChanged ((sender, args) => {
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
		/// void Callback (object sender, CKContainer.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = CKContainer.Notifications.ObserveAccountChanged (Callback);
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
		///     CKContainer.AccountChangedNotification, (notification) => { Console.WriteLine ("Received the notification AccountChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification AccountChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (CKContainer.AccountChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("CKAccountChangedNotification",  "CloudKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use CKContainer.Notifications.ObserveAccountChanged helper method instead.")]
		public static NSString AccountChangedNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AccountChangedNotification is null)
					_AccountChangedNotification = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKAccountChangedNotification")!;
				return _AccountChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CurrentUserDefaultName;
		/// <summary>The current user of the database.</summary><value>The default value is "defaultOwner".</value><remarks>To be added.</remarks>
		[Field ("CKCurrentUserDefaultName",  "CloudKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString CurrentUserDefaultName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_CurrentUserDefaultName is null)
					_CurrentUserDefaultName = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKCurrentUserDefaultName")!;
				return _CurrentUserDefaultName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OwnerDefaultName;
		/// <summary>Developers should not use this deprecated property. Developers should use 'CurrentUserDefaultName' instead.</summary><value></value><remarks>To be added.</remarks>
		[Field ("CKOwnerDefaultName",  "CloudKit")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'CurrentUserDefaultName' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use 'CurrentUserDefaultName' instead.")]
		[ObsoletedOSPlatform ("macos10.12", "Use 'CurrentUserDefaultName' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'CurrentUserDefaultName' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString OwnerDefaultName {
			[ObsoletedOSPlatform ("ios10.0", "Use 'CurrentUserDefaultName' instead.")]
			[ObsoletedOSPlatform ("tvos10.0", "Use 'CurrentUserDefaultName' instead.")]
			[ObsoletedOSPlatform ("macos10.12", "Use 'CurrentUserDefaultName' instead.")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'CurrentUserDefaultName' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_OwnerDefaultName is null)
					_OwnerDefaultName = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKOwnerDefaultName")!;
				return _OwnerDefaultName;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::CloudKit.CKContainer" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::CloudKit.CKContainer.AccountChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::CloudKit.CKContainer.AccountChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = CKContainer.Notifications.ObserveAccountChanged ((notification) => {
			///   Console.WriteLine ("Observed AccountChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAccountChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AccountChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::CloudKit.CKContainer.AccountChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::CloudKit.CKContainer.AccountChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = CKContainer.Notifications.ObserveAccountChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed AccountChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAccountChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AccountChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class CKContainer */
}
