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
namespace ClassKit {
	/// <summary>Manages ClassKit data by operating on hierarchical contexts, such as acts, chapters, sections, and so on.</summary>
	[Register("CLSDataStore", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class CLSDataStore : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActiveContextX = "activeContext";
		static readonly NativeHandle selActiveContextXHandle = Selector.GetHandle ("activeContext");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckIsAssignedDocument_Completion_X = "checkIsAssignedDocument:completion:";
		static readonly NativeHandle selCheckIsAssignedDocument_Completion_XHandle = Selector.GetHandle ("checkIsAssignedDocument:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompleteAllAssignedActivitiesMatching_X = "completeAllAssignedActivitiesMatching:";
		static readonly NativeHandle selCompleteAllAssignedActivitiesMatching_XHandle = Selector.GetHandle ("completeAllAssignedActivitiesMatching:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextsMatchingIdentifierPath_Completion_X = "contextsMatchingIdentifierPath:completion:";
		static readonly NativeHandle selContextsMatchingIdentifierPath_Completion_XHandle = Selector.GetHandle ("contextsMatchingIdentifierPath:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextsMatchingPredicate_Completion_X = "contextsMatchingPredicate:completion:";
		static readonly NativeHandle selContextsMatchingPredicate_Completion_XHandle = Selector.GetHandle ("contextsMatchingPredicate:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchActivityForURL_Completion_X = "fetchActivityForURL:completion:";
		static readonly NativeHandle selFetchActivityForURL_Completion_XHandle = Selector.GetHandle ("fetchActivityForURL:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMainAppContextX = "mainAppContext";
		static readonly NativeHandle selMainAppContextXHandle = Selector.GetHandle ("mainAppContext");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveContext_X = "removeContext:";
		static readonly NativeHandle selRemoveContext_XHandle = Selector.GetHandle ("removeContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunningActivityX = "runningActivity";
		static readonly NativeHandle selRunningActivityXHandle = Selector.GetHandle ("runningActivity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveWithCompletion_X = "saveWithCompletion:";
		static readonly NativeHandle selSaveWithCompletion_XHandle = Selector.GetHandle ("saveWithCompletion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedX = "shared";
		static readonly NativeHandle selSharedXHandle = Selector.GetHandle ("shared");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CLSDataStore");
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
		protected CLSDataStore (NSObjectFlag t) : base (t)
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
		protected internal CLSDataStore (NativeHandle handle) : base (handle)
		{
		}

		[Export ("checkIsAssignedDocument:completion:")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CheckIsAssignedDocument (NSUrl documentUrl, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCLSDataStoreCheckAssignedDocumentCompletionHandler))]CLSDataStoreCheckAssignedDocumentCompletionHandler completion)
		{
			var documentUrl__handle__ = documentUrl!.GetNonNullHandle (nameof (documentUrl));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDCLSDataStoreCheckAssignedDocumentCompletionHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selCheckIsAssignedDocument_Completion_XHandle, documentUrl__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selCheckIsAssignedDocument_Completion_XHandle, documentUrl__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (documentUrl);
		}
		/// <param name="documentUrl">The URL of the document to check.</param>
		/// <summary>Asynchronously checks whether the specified document is assigned and returns a task that contains the result.</summary>
		/// <returns>A task that contains the result of the check.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError?>> CheckIsAssignedDocumentAsync (NSUrl documentUrl)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			CheckIsAssignedDocument(documentUrl, (isAssigned_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (isAssigned_, error_));
			});
			return tcs.Task;
		}
		[Export ("completeAllAssignedActivitiesMatching:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CompleteAllAssignedActivitiesMatching (string[] contextPath)
		{
			if (contextPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (contextPath));
			using var nsa_contextPath = NSArray.FromStrings (contextPath);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCompleteAllAssignedActivitiesMatching_XHandle, nsa_contextPath.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCompleteAllAssignedActivitiesMatching_XHandle, nsa_contextPath.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("fetchActivityForURL:completion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.5")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchActivity (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V38))]global::System.Action<CLSActivity, NSError> completion)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V38.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFetchActivityForURL_Completion_XHandle, url__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFetchActivityForURL_Completion_XHandle, url__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.5")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CLSActivity> FetchActivityAsync (NSUrl url)
		{
			var tcs = new TaskCompletionSource<CLSActivity> ();
			FetchActivity(url, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("contextsMatchingPredicate:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FindContextsMatching (NSPredicate predicate, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V39))]global::System.Action<CLSContext[], NSError> completion)
		{
			var predicate__handle__ = predicate!.GetNonNullHandle (nameof (predicate));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V39.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selContextsMatchingPredicate_Completion_XHandle, predicate__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selContextsMatchingPredicate_Completion_XHandle, predicate__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (predicate);
		}
		/// <param name="predicate">The search predicate.</param>
		/// <summary>Searches for a context that matches the supplied <paramref name="predicate" /> and returns a task that contains the result.</summary>
		/// <returns>A task that contains the search results</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CLSContext[]> FindContextsMatchingAsync (NSPredicate predicate)
		{
			var tcs = new TaskCompletionSource<CLSContext[]> ();
			FindContextsMatching(predicate, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("contextsMatchingIdentifierPath:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FindContextsMatching (string[] identifierPath, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V39))]global::System.Action<CLSContext[], NSError> completion)
		{
			if (identifierPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifierPath));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var nsa_identifierPath = NSArray.FromStrings (identifierPath);
			using var block_completion = Trampolines.SDActionArity2V39.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selContextsMatchingIdentifierPath_Completion_XHandle, nsa_identifierPath.Handle, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selContextsMatchingIdentifierPath_Completion_XHandle, nsa_identifierPath.Handle, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="identifierPath">The identifier paths for the contexts to find.</param>
		/// <summary>Finds the contexts identified by a set of identifier paths and returns a task that contains the results.</summary>
		/// <returns>A task that contains the search results</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CLSContext[]> FindContextsMatchingAsync (string[] identifierPath)
		{
			var tcs = new TaskCompletionSource<CLSContext[]> ();
			FindContextsMatching(identifierPath, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("removeContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Remove (CLSContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveContext_XHandle, context__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveContext_XHandle, context__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
		}
		[Export ("saveWithCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Save ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completion)
		{
			using var block_completion = Trampolines.SDActionArity1V16.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSaveWithCompletion_XHandle, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSaveWithCompletion_XHandle, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Asynchronously saves the data store and returns a task that represents the operation.</summary>
		/// <returns>A task that represents the operation.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SaveAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			Save((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CLSContext? ActiveContext {
			[Export ("activeContext", ArgumentSemantic.Retain)]
			get {
				CLSContext? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CLSContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selActiveContextXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CLSContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selActiveContextXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>An instance of the ClassKit.ICLSDataStoreDelegate model class which acts as the class delegate.</summary><value>The instance of the ClassKit.ICLSDataStoreDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ICLSDataStoreDelegate? Delegate {
			get {
				return (WeakDelegate as ICLSDataStoreDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CLSContext MainAppContext {
			[Export ("mainAppContext", ArgumentSemantic.Retain)]
			get {
				CLSContext? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CLSContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMainAppContextXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CLSContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMainAppContextXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CLSActivity? RunningActivity {
			[Export ("runningActivity", ArgumentSemantic.Retain)]
			get {
				CLSActivity? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CLSActivity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRunningActivityXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CLSActivity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRunningActivityXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CLSDataStore Shared {
			[Export ("shared", ArgumentSemantic.Retain)]
			get {
				CLSDataStore? ret;
				ret =  Runtime.GetNSObject<CLSDataStore> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSharedXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class CLSDataStore */
}
