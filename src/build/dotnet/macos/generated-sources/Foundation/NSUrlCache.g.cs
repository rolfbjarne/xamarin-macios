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
namespace Foundation {
	[Register("NSURLCache", true)]
	public unsafe partial class NSUrlCache : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCachedResponseForRequest_X = "cachedResponseForRequest:";
		static readonly NativeHandle selCachedResponseForRequest_XHandle = Selector.GetHandle ("cachedResponseForRequest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentDiskUsageX = "currentDiskUsage";
		static readonly NativeHandle selCurrentDiskUsageXHandle = Selector.GetHandle ("currentDiskUsage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentMemoryUsageX = "currentMemoryUsage";
		static readonly NativeHandle selCurrentMemoryUsageXHandle = Selector.GetHandle ("currentMemoryUsage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDiskCapacityX = "diskCapacity";
		static readonly NativeHandle selDiskCapacityXHandle = Selector.GetHandle ("diskCapacity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetCachedResponseForDataTask_CompletionHandler_X = "getCachedResponseForDataTask:completionHandler:";
		static readonly NativeHandle selGetCachedResponseForDataTask_CompletionHandler_XHandle = Selector.GetHandle ("getCachedResponseForDataTask:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithMemoryCapacity_DiskCapacity_DirectoryURL_X = "initWithMemoryCapacity:diskCapacity:directoryURL:";
		static readonly NativeHandle selInitWithMemoryCapacity_DiskCapacity_DirectoryURL_XHandle = Selector.GetHandle ("initWithMemoryCapacity:diskCapacity:directoryURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithMemoryCapacity_DiskCapacity_DiskPath_X = "initWithMemoryCapacity:diskCapacity:diskPath:";
		static readonly NativeHandle selInitWithMemoryCapacity_DiskCapacity_DiskPath_XHandle = Selector.GetHandle ("initWithMemoryCapacity:diskCapacity:diskPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMemoryCapacityX = "memoryCapacity";
		static readonly NativeHandle selMemoryCapacityXHandle = Selector.GetHandle ("memoryCapacity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllCachedResponsesX = "removeAllCachedResponses";
		static readonly NativeHandle selRemoveAllCachedResponsesXHandle = Selector.GetHandle ("removeAllCachedResponses");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveCachedResponseForDataTask_X = "removeCachedResponseForDataTask:";
		static readonly NativeHandle selRemoveCachedResponseForDataTask_XHandle = Selector.GetHandle ("removeCachedResponseForDataTask:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveCachedResponseForRequest_X = "removeCachedResponseForRequest:";
		static readonly NativeHandle selRemoveCachedResponseForRequest_XHandle = Selector.GetHandle ("removeCachedResponseForRequest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveCachedResponsesSinceDate_X = "removeCachedResponsesSinceDate:";
		static readonly NativeHandle selRemoveCachedResponsesSinceDate_XHandle = Selector.GetHandle ("removeCachedResponsesSinceDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDiskCapacity_X = "setDiskCapacity:";
		static readonly NativeHandle selSetDiskCapacity_XHandle = Selector.GetHandle ("setDiskCapacity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMemoryCapacity_X = "setMemoryCapacity:";
		static readonly NativeHandle selSetMemoryCapacity_XHandle = Selector.GetHandle ("setMemoryCapacity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSharedURLCache_X = "setSharedURLCache:";
		static readonly NativeHandle selSetSharedURLCache_XHandle = Selector.GetHandle ("setSharedURLCache:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedURLCacheX = "sharedURLCache";
		static readonly NativeHandle selSharedURLCacheXHandle = Selector.GetHandle ("sharedURLCache");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStoreCachedResponse_ForDataTask_X = "storeCachedResponse:forDataTask:";
		static readonly NativeHandle selStoreCachedResponse_ForDataTask_XHandle = Selector.GetHandle ("storeCachedResponse:forDataTask:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStoreCachedResponse_ForRequest_X = "storeCachedResponse:forRequest:";
		static readonly NativeHandle selStoreCachedResponse_ForRequest_XHandle = Selector.GetHandle ("storeCachedResponse:forRequest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSURLCache");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSUrlCache" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSUrlCache () : base (NSObjectFlag.Empty)
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
		protected NSUrlCache (NSObjectFlag t) : base (t)
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
		protected internal NSUrlCache (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="memoryCapacity">To be added.</param><param name="diskCapacity">To be added.</param><param name="diskPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithMemoryCapacity:diskCapacity:diskPath:")]
		[ObsoletedOSPlatform ("macos10.15", "Use the overload that accepts an 'NSUrl' parameter instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use the overload that accepts an 'NSUrl' parameter instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use the overload that accepts an 'NSUrl' parameter instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the overload that accepts an 'NSUrl' parameter instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUrlCache (nuint memoryCapacity, nuint diskCapacity, string? diskPath)
			: base (NSObjectFlag.Empty)
		{
			var nsdiskPath = CFString.CreateNative (diskPath);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_NativeHandle (this.Handle, selInitWithMemoryCapacity_DiskCapacity_DiskPath_XHandle, memoryCapacity, diskCapacity, nsdiskPath), "initWithMemoryCapacity:diskCapacity:diskPath:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_UIntPtr_NativeHandle (&__objc_super__, selInitWithMemoryCapacity_DiskCapacity_DiskPath_XHandle, memoryCapacity, diskCapacity, nsdiskPath), "initWithMemoryCapacity:diskCapacity:diskPath:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdiskPath);
		}
		[Export ("initWithMemoryCapacity:diskCapacity:directoryURL:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUrlCache (nuint memoryCapacity, nuint diskCapacity, NSUrl? directoryUrl)
			: base (NSObjectFlag.Empty)
		{
			var directoryUrl__handle__ = directoryUrl.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_NativeHandle (this.Handle, selInitWithMemoryCapacity_DiskCapacity_DirectoryURL_XHandle, memoryCapacity, diskCapacity, directoryUrl__handle__), "initWithMemoryCapacity:diskCapacity:directoryURL:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_UIntPtr_NativeHandle (&__objc_super__, selInitWithMemoryCapacity_DiskCapacity_DirectoryURL_XHandle, memoryCapacity, diskCapacity, directoryUrl__handle__), "initWithMemoryCapacity:diskCapacity:directoryURL:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (directoryUrl);
		}
		[Export ("cachedResponseForRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCachedUrlResponse CachedResponseForRequest (NSUrlRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			NSCachedUrlResponse? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCachedUrlResponse> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCachedResponseForRequest_XHandle, request__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCachedUrlResponse> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCachedResponseForRequest_XHandle, request__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			return ret!;
		}
		[Export ("getCachedResponseForDataTask:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetCachedResponse (NSUrlSessionDataTask dataTask, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V57))]global::System.Action<NSCachedUrlResponse> completionHandler)
		{
			var dataTask__handle__ = dataTask!.GetNonNullHandle (nameof (dataTask));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V57.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selGetCachedResponseForDataTask_CompletionHandler_XHandle, dataTask__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selGetCachedResponseForDataTask_CompletionHandler_XHandle, dataTask__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dataTask);
		}
		/// <param name="dataTask">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous GetCachedResponse operation.  The value of the TResult parameter is of type System.Action&lt;Foundation.NSCachedUrlResponse&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The GetCachedResponseAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSCachedUrlResponse> GetCachedResponseAsync (NSUrlSessionDataTask dataTask)
		{
			var tcs = new TaskCompletionSource<NSCachedUrlResponse> ();
			GetCachedResponse(dataTask, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("removeAllCachedResponses")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllCachedResponses ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveAllCachedResponsesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveAllCachedResponsesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeCachedResponseForRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveCachedResponse (NSUrlRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveCachedResponseForRequest_XHandle, request__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveCachedResponseForRequest_XHandle, request__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
		}
		[Export ("removeCachedResponseForDataTask:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveCachedResponse (NSUrlSessionDataTask dataTask)
		{
			var dataTask__handle__ = dataTask!.GetNonNullHandle (nameof (dataTask));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveCachedResponseForDataTask_XHandle, dataTask__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveCachedResponseForDataTask_XHandle, dataTask__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dataTask);
		}
		[Export ("removeCachedResponsesSinceDate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveCachedResponsesSinceDate (NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveCachedResponsesSinceDate_XHandle, date__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveCachedResponsesSinceDate_XHandle, date__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
		}
		[Export ("storeCachedResponse:forRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StoreCachedResponse (NSCachedUrlResponse cachedResponse, NSUrlRequest forRequest)
		{
			var cachedResponse__handle__ = cachedResponse!.GetNonNullHandle (nameof (cachedResponse));
			var forRequest__handle__ = forRequest!.GetNonNullHandle (nameof (forRequest));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selStoreCachedResponse_ForRequest_XHandle, cachedResponse__handle__, forRequest__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selStoreCachedResponse_ForRequest_XHandle, cachedResponse__handle__, forRequest__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cachedResponse);
			GC.KeepAlive (forRequest);
		}
		[Export ("storeCachedResponse:forDataTask:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StoreCachedResponse (NSCachedUrlResponse cachedResponse, NSUrlSessionDataTask dataTask)
		{
			var cachedResponse__handle__ = cachedResponse!.GetNonNullHandle (nameof (cachedResponse));
			var dataTask__handle__ = dataTask!.GetNonNullHandle (nameof (dataTask));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selStoreCachedResponse_ForDataTask_XHandle, cachedResponse__handle__, dataTask__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selStoreCachedResponse_ForDataTask_XHandle, cachedResponse__handle__, dataTask__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cachedResponse);
			GC.KeepAlive (dataTask);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint CurrentDiskUsage {
			[Export ("currentDiskUsage")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selCurrentDiskUsageXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selCurrentDiskUsageXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint CurrentMemoryUsage {
			[Export ("currentMemoryUsage")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selCurrentMemoryUsageXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selCurrentMemoryUsageXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint DiskCapacity {
			[Export ("diskCapacity")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDiskCapacityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDiskCapacityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDiskCapacity:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetDiskCapacity_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetDiskCapacity_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint MemoryCapacity {
			[Export ("memoryCapacity")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMemoryCapacityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMemoryCapacityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMemoryCapacity:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetMemoryCapacity_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetMemoryCapacity_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrlCache SharedCache {
			[Export ("sharedURLCache", ArgumentSemantic.Retain)]
			get {
				NSUrlCache? ret;
				ret =  Runtime.GetNSObject<NSUrlCache> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSharedURLCacheXHandle), false)!;
				return ret!;
			}
			[Export ("setSharedURLCache:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selSetSharedURLCache_XHandle, value__handle__);
				GC.KeepAlive (value);
			}
		}
	} /* class NSUrlCache */
}
