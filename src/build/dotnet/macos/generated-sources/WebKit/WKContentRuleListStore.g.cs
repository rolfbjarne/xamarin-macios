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
namespace WebKit {
	/// <summary>A store that contents rules for web content.</summary>
	[Register("WKContentRuleListStore", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class WKContentRuleListStore : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompileContentRuleListForIdentifier_EncodedContentRuleList_CompletionHandler_X = "compileContentRuleListForIdentifier:encodedContentRuleList:completionHandler:";
		static readonly NativeHandle selCompileContentRuleListForIdentifier_EncodedContentRuleList_CompletionHandler_XHandle = Selector.GetHandle ("compileContentRuleListForIdentifier:encodedContentRuleList:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultStoreX = "defaultStore";
		static readonly NativeHandle selDefaultStoreXHandle = Selector.GetHandle ("defaultStore");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetAvailableContentRuleListIdentifiers_X = "getAvailableContentRuleListIdentifiers:";
		static readonly NativeHandle selGetAvailableContentRuleListIdentifiers_XHandle = Selector.GetHandle ("getAvailableContentRuleListIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLookUpContentRuleListForIdentifier_CompletionHandler_X = "lookUpContentRuleListForIdentifier:completionHandler:";
		static readonly NativeHandle selLookUpContentRuleListForIdentifier_CompletionHandler_XHandle = Selector.GetHandle ("lookUpContentRuleListForIdentifier:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveContentRuleListForIdentifier_CompletionHandler_X = "removeContentRuleListForIdentifier:completionHandler:";
		static readonly NativeHandle selRemoveContentRuleListForIdentifier_CompletionHandler_XHandle = Selector.GetHandle ("removeContentRuleListForIdentifier:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStoreWithURL_X = "storeWithURL:";
		static readonly NativeHandle selStoreWithURL_XHandle = Selector.GetHandle ("storeWithURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("WKContentRuleListStore");
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
		protected WKContentRuleListStore (NSObjectFlag t) : base (t)
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
		protected internal WKContentRuleListStore (NativeHandle handle) : base (handle)
		{
		}

		[Export ("compileContentRuleListForIdentifier:encodedContentRuleList:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CompileContentRuleList (string identifier, string encodedContentRuleList, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V152))]global::System.Action<WKContentRuleList, NSError> completionHandler)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			if (encodedContentRuleList is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (encodedContentRuleList));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsidentifier = CFString.CreateNative (identifier);
			var nsencodedContentRuleList = CFString.CreateNative (encodedContentRuleList);
			using var block_completionHandler = Trampolines.SDActionArity2V152.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selCompileContentRuleListForIdentifier_EncodedContentRuleList_CompletionHandler_XHandle, nsidentifier, nsencodedContentRuleList, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selCompileContentRuleListForIdentifier_EncodedContentRuleList_CompletionHandler_XHandle, nsidentifier, nsencodedContentRuleList, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsidentifier);
			CFString.ReleaseNative (nsencodedContentRuleList);
		}
		/// <param name="identifier">The identifier for the newly compiled list.</param>
		/// <param name="encodedContentRuleList">JSON source to compile.</param>
		/// <summary>Compiles the provided list of rules, adds the list to the store with the specified <paramref name="identifier" />, and runs a handler that receives the content list and any error that is encountered.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous CompileContentRuleList operation.  The value of the TResult parameter is of type System.Action&lt;WebKit.WKContentRuleList,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<WKContentRuleList> CompileContentRuleListAsync (string identifier, string encodedContentRuleList)
		{
			var tcs = new TaskCompletionSource<WKContentRuleList> ();
			CompileContentRuleList(identifier, encodedContentRuleList, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("storeWithURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static WKContentRuleListStore FromUrl (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			WKContentRuleListStore? ret;
			ret =  Runtime.GetNSObject<WKContentRuleListStore> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selStoreWithURL_XHandle, url__handle__), false)!;
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("getAvailableContentRuleListIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetAvailableContentRuleListIdentifiers ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V3))]global::System.Action<string[]> callback)
		{
			if (callback is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (callback));
			using var block_callback = Trampolines.SDActionArity1V3.CreateBlock (callback);
			BlockLiteral *block_ptr_callback = &block_callback;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selGetAvailableContentRuleListIdentifiers_XHandle, (IntPtr) block_ptr_callback);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selGetAvailableContentRuleListIdentifiers_XHandle, (IntPtr) block_ptr_callback);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Asynchronously retrieves the list of identifiers for available content rule lists.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous GetAvailableContentRuleListIdentifiers operation.  The value of the TResult parameter is of type System.Action&lt;System.String[]&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The GetAvailableContentRuleListIdentifiersAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<string[]> GetAvailableContentRuleListIdentifiersAsync ()
		{
			var tcs = new TaskCompletionSource<string[]> ();
			GetAvailableContentRuleListIdentifiers((obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("lookUpContentRuleListForIdentifier:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LookUpContentRuleList (string identifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V152))]global::System.Action<WKContentRuleList, NSError> completionHandler)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsidentifier = CFString.CreateNative (identifier);
			using var block_completionHandler = Trampolines.SDActionArity2V152.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLookUpContentRuleListForIdentifier_CompletionHandler_XHandle, nsidentifier, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLookUpContentRuleListForIdentifier_CompletionHandler_XHandle, nsidentifier, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsidentifier);
		}
		/// <param name="identifier">The identifer for the rule list to look up.</param>
		/// <summary>Asynchronously finds and returns the content rule list that is specified by the provided <paramref name="identifier" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous LookUpContentRuleList operation.  The value of the TResult parameter is of type System.Action&lt;WebKit.WKContentRuleList,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<WKContentRuleList> LookUpContentRuleListAsync (string identifier)
		{
			var tcs = new TaskCompletionSource<WKContentRuleList> ();
			LookUpContentRuleList(identifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("removeContentRuleListForIdentifier:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RemoveContentRuleList (string identifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsidentifier = CFString.CreateNative (identifier);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRemoveContentRuleListForIdentifier_CompletionHandler_XHandle, nsidentifier, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRemoveContentRuleListForIdentifier_CompletionHandler_XHandle, nsidentifier, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsidentifier);
		}
		/// <param name="identifier">The identifier for the list to remove.</param>
		/// <summary>Asynchronously removes the content rule list that is specified by the provided <paramref name="identifier" />.</summary>
		/// <returns>A task that represents the asynchronous RemoveContentRuleList operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task RemoveContentRuleListAsync (string identifier)
		{
			var tcs = new TaskCompletionSource<bool> ();
			RemoveContentRuleList(identifier, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static WKContentRuleListStore DefaultStore {
			[Export ("defaultStore")]
			get {
				WKContentRuleListStore? ret;
				ret =  Runtime.GetNSObject<WKContentRuleListStore> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDefaultStoreXHandle), false)!;
				return ret!;
			}
		}
	} /* class WKContentRuleListStore */
}
