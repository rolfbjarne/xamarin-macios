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
namespace NetworkExtension {
	/// <summary>Provides IO over a network socket.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEAppProxyFlowClassRef/index.html">Apple documentation for <c>NEAppProxyFlow</c></related>
	[Register("NEAppProxyFlow", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NEAppProxyFlow : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCloseReadWithError_X = "closeReadWithError:";
		static readonly NativeHandle selCloseReadWithError_XHandle = Selector.GetHandle ("closeReadWithError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCloseWriteWithError_X = "closeWriteWithError:";
		static readonly NativeHandle selCloseWriteWithError_XHandle = Selector.GetHandle ("closeWriteWithError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsBoundX = "isBound";
		static readonly NativeHandle selIsBoundXHandle = Selector.GetHandle ("isBound");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetaDataX = "metaData";
		static readonly NativeHandle selMetaDataXHandle = Selector.GetHandle ("metaData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNetworkInterfaceX = "networkInterface";
		static readonly NativeHandle selNetworkInterfaceXHandle = Selector.GetHandle ("networkInterface");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenWithLocalEndpoint_CompletionHandler_X = "openWithLocalEndpoint:completionHandler:";
		static readonly NativeHandle selOpenWithLocalEndpoint_CompletionHandler_XHandle = Selector.GetHandle ("openWithLocalEndpoint:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenWithLocalFlowEndpoint_CompletionHandler_X = "openWithLocalFlowEndpoint:completionHandler:";
		static readonly NativeHandle selOpenWithLocalFlowEndpoint_CompletionHandler_XHandle = Selector.GetHandle ("openWithLocalFlowEndpoint:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoteHostnameX = "remoteHostname";
		static readonly NativeHandle selRemoteHostnameXHandle = Selector.GetHandle ("remoteHostname");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMetadata_X = "setMetadata:";
		static readonly NativeHandle selSetMetadata_XHandle = Selector.GetHandle ("setMetadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNetworkInterface_X = "setNetworkInterface:";
		static readonly NativeHandle selSetNetworkInterface_XHandle = Selector.GetHandle ("setNetworkInterface:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NEAppProxyFlow");
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
		protected NEAppProxyFlow (NSObjectFlag t) : base (t)
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
		protected internal NEAppProxyFlow (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Closes the flow for reading.</summary><remarks>To be added.</remarks>
		[Export ("closeReadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CloseRead (NSError? error)
		{
			var error__handle__ = error.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCloseReadWithError_XHandle, error__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCloseReadWithError_XHandle, error__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (error);
		}
		/// <param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Closes the flow for writing.</summary><remarks>To be added.</remarks>
		[Export ("closeWriteWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CloseWrite (NSError? error)
		{
			var error__handle__ = error.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCloseWriteWithError_XHandle, error__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCloseWriteWithError_XHandle, error__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (error);
		}
		/// <param name="localEndpoint"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="completionHandler">To be added.</param><summary>Opens the flow.</summary><remarks>To be added.</remarks>
		[Export ("openWithLocalEndpoint:completionHandler:")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'OpenWithLocalFlowEndpoint' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'OpenWithLocalFlowEndpoint' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'OpenWithLocalFlowEndpoint' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void OpenWithLocalEndpoint (NWHostEndpoint? localEndpoint, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			var localEndpoint__handle__ = localEndpoint.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selOpenWithLocalEndpoint_CompletionHandler_XHandle, localEndpoint__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selOpenWithLocalEndpoint_CompletionHandler_XHandle, localEndpoint__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (localEndpoint);
		}
		/// <param name="localEndpoint">To be added.</param>
		/// <summary>Opens the flow.</summary>
		/// <returns>A task that represents the asynchronous OpenWithLocalEndpoint operation</returns>
		/// <remarks>
		///           <para copied="true">The OpenWithLocalEndpointAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[ObsoletedOSPlatform ("ios18.0", "Use 'OpenWithLocalFlowEndpoint' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'OpenWithLocalFlowEndpoint' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'OpenWithLocalFlowEndpoint' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task OpenWithLocalEndpointAsync (NWHostEndpoint? localEndpoint)
		{
			var tcs = new TaskCompletionSource<bool> ();
			OpenWithLocalEndpoint(localEndpoint, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("openWithLocalFlowEndpoint:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void OpenWithLocalFlowEndpoint (global::Network.NWEndpoint? localEndpoint, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNEAppProxyFlowOpenCallback))]NEAppProxyFlowOpenCallback completionHandler)
		{
			var localEndpoint__handle__ = localEndpoint.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNEAppProxyFlowOpenCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selOpenWithLocalFlowEndpoint_CompletionHandler_XHandle, localEndpoint__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selOpenWithLocalFlowEndpoint_CompletionHandler_XHandle, localEndpoint__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (localEndpoint);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task OpenWithLocalFlowEndpointAsync (global::Network.NWEndpoint? localEndpoint)
		{
			var tcs = new TaskCompletionSource<bool> ();
			OpenWithLocalFlowEndpoint(localEndpoint, (completionHandler_) => {
				if (completionHandler_ is not null)
					tcs.SetException (new NSErrorException(completionHandler_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("setMetadata:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void SetMetadata (nint nwparameters)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMetadata_XHandle, nwparameters);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetMetadata_XHandle, nwparameters);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool IsBound {
			[Export ("isBound")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsBoundXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsBoundXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets the flow metadata.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NEFlowMetaData MetaData {
			[Export ("metaData")]
			get {
				NEFlowMetaData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NEFlowMetaData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMetaDataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NEFlowMetaData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMetaDataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual global::Network.NWInterface NetworkInterface {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				return Runtime.GetINativeObject<NWInterface> (WeakNetworkInterface, false)!;
			}
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			set {
				WeakNetworkInterface = Runtime.RetainAndAutoreleaseNativeObject (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string? RemoteHostname {
			[Export ("remoteHostname")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRemoteHostnameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRemoteHostnameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		internal virtual nint WeakNetworkInterface {
			[Export ("networkInterface", ArgumentSemantic.Copy)]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNetworkInterfaceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNetworkInterfaceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setNetworkInterface:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetNetworkInterface_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetNetworkInterface_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class NEAppProxyFlow */
}
