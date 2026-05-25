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
namespace SafariServices {
	[Register("SFSafariApplication", true)]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class SFSafariApplication : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDispatchMessageWithName_ToExtensionWithIdentifier_UserInfo_CompletionHandler_X = "dispatchMessageWithName:toExtensionWithIdentifier:userInfo:completionHandler:";
		static readonly NativeHandle selDispatchMessageWithName_ToExtensionWithIdentifier_UserInfo_CompletionHandler_XHandle = Selector.GetHandle ("dispatchMessageWithName:toExtensionWithIdentifier:userInfo:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetActiveWindowWithCompletionHandler_X = "getActiveWindowWithCompletionHandler:";
		static readonly NativeHandle selGetActiveWindowWithCompletionHandler_XHandle = Selector.GetHandle ("getActiveWindowWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetAllWindowsWithCompletionHandler_X = "getAllWindowsWithCompletionHandler:";
		static readonly NativeHandle selGetAllWindowsWithCompletionHandler_XHandle = Selector.GetHandle ("getAllWindowsWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetHostApplicationWithCompletionHandler_X = "getHostApplicationWithCompletionHandler:";
		static readonly NativeHandle selGetHostApplicationWithCompletionHandler_XHandle = Selector.GetHandle ("getHostApplicationWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenWindowWithURL_CompletionHandler_X = "openWindowWithURL:completionHandler:";
		static readonly NativeHandle selOpenWindowWithURL_CompletionHandler_XHandle = Selector.GetHandle ("openWindowWithURL:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetToolbarItemsNeedUpdateX = "setToolbarItemsNeedUpdate";
		static readonly NativeHandle selSetToolbarItemsNeedUpdateXHandle = Selector.GetHandle ("setToolbarItemsNeedUpdate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowPreferencesForExtensionWithIdentifier_CompletionHandler_X = "showPreferencesForExtensionWithIdentifier:completionHandler:";
		static readonly NativeHandle selShowPreferencesForExtensionWithIdentifier_CompletionHandler_XHandle = Selector.GetHandle ("showPreferencesForExtensionWithIdentifier:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SFSafariApplication");
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
		protected SFSafariApplication (NSObjectFlag t) : base (t)
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
		protected internal SFSafariApplication (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="messageName">To be added.</param><param name="identifier">To be added.</param><param name="userInfo">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("dispatchMessageWithName:toExtensionWithIdentifier:userInfo:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Unavailable to extensions.")]
		public unsafe static void DispatchMessage (string messageName, string identifier, NSDictionary<NSString, NSObject>? userInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			if (messageName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (messageName));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var userInfo__handle__ = userInfo.GetHandle ();
			var nsmessageName = CFString.CreateNative (messageName);
			var nsidentifier = CFString.CreateNative (identifier);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selDispatchMessageWithName_ToExtensionWithIdentifier_UserInfo_CompletionHandler_XHandle, nsmessageName, nsidentifier, userInfo__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (userInfo);
			CFString.ReleaseNative (nsmessageName);
			CFString.ReleaseNative (nsidentifier);
		}
		/// <param name="messageName">To be added.</param>
		/// <param name="identifier">To be added.</param>
		/// <param name="userInfo">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Unavailable to extensions.")]
		public unsafe static Task DispatchMessageAsync (string messageName, string identifier, NSDictionary<NSString, NSObject>? userInfo)
		{
			var tcs = new TaskCompletionSource<bool> ();
			DispatchMessage(messageName, identifier, userInfo, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("getActiveWindowWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetActiveWindow ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V106))]global::System.Action<SFSafariWindow> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V106.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selGetActiveWindowWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<SFSafariWindow> GetActiveWindowAsync ()
		{
			var tcs = new TaskCompletionSource<SFSafariWindow> ();
			GetActiveWindow((obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("getAllWindowsWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetAllWindows ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V107))]global::System.Action<SFSafariWindow[]> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V107.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selGetAllWindowsWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<SFSafariWindow[]> GetAllWindowsAsync ()
		{
			var tcs = new TaskCompletionSource<SFSafariWindow[]> ();
			GetAllWindows((obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("getHostApplicationWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetHostApplication ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V108))]global::System.Action<global::AppKit.NSRunningApplication> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V108.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selGetHostApplicationWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<global::AppKit.NSRunningApplication> GetHostApplicationAsync ()
		{
			var tcs = new TaskCompletionSource<global::AppKit.NSRunningApplication> ();
			GetHostApplication((obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		/// <param name="url">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("openWindowWithURL:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void OpenWindow (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V106))]global::System.Action<SFSafariWindow>? completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			using var block_completionHandler = Trampolines.SDActionArity1V106.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selOpenWindowWithURL_CompletionHandler_XHandle, url__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (url);
		}
		/// <param name="url">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<SFSafariWindow> OpenWindowAsync (NSUrl url)
		{
			var tcs = new TaskCompletionSource<SFSafariWindow> ();
			OpenWindow(url, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setToolbarItemsNeedUpdate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetToolbarItemsNeedUpdate ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selSetToolbarItemsNeedUpdateXHandle);
		}
		/// <param name="identifier">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("showPreferencesForExtensionWithIdentifier:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ShowPreferencesForExtension (string identifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selShowPreferencesForExtensionWithIdentifier_CompletionHandler_XHandle, nsidentifier, (IntPtr) block_ptr_completionHandler);
			CFString.ReleaseNative (nsidentifier);
		}
	} /* class SFSafariApplication */
}
