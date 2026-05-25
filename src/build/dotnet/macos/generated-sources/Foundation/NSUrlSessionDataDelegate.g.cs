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
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSURLSessionDataDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "NSURLSessionDataDelegate", WrapperType = typeof (NSUrlSessionDataDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveResponse", Selector = "URLSession:dataTask:didReceiveResponse:completionHandler:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionDataTask), typeof (NSUrlResponse), typeof (global::System.Action<NSUrlSessionResponseDisposition>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V60) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBecomeDownloadTask", Selector = "URLSession:dataTask:didBecomeDownloadTask:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionDataTask), typeof (NSUrlSessionDownloadTask) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveData", Selector = "URLSession:dataTask:didReceiveData:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionDataTask), typeof (NSData) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillCacheResponse", Selector = "URLSession:dataTask:willCacheResponse:completionHandler:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionDataTask), typeof (NSCachedUrlResponse), typeof (global::System.Action<NSCachedUrlResponse>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V57) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBecomeStreamTask", Selector = "URLSession:dataTask:didBecomeStreamTask:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionDataTask), typeof (NSUrlSessionStreamTask) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface INSUrlSessionDataDelegate : INativeObject, IDisposable, 
		Foundation.INSUrlSessionTaskDelegate
	{
		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="response">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:dataTask:didReceiveResponse:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveResponse (NSUrlSession session, NSUrlSessionDataTask dataTask, NSUrlResponse response, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V60))]global::System.Action<NSUrlSessionResponseDisposition> completionHandler)
		{
			_DidReceiveResponse (this, session, dataTask, response, completionHandler);
		}
		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="response">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidReceiveResponse (INSUrlSessionDataDelegate This, NSUrlSession session, NSUrlSessionDataTask dataTask, NSUrlResponse response, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V60))]global::System.Action<NSUrlSessionResponseDisposition> completionHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var dataTask__handle__ = dataTask!.GetNonNullHandle (nameof (dataTask));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V60.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:dataTask:didReceiveResponse:completionHandler:"), session__handle__, dataTask__handle__, response__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (dataTask);
			GC.KeepAlive (response);
		}
		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="downloadTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:dataTask:didBecomeDownloadTask:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeDownloadTask (NSUrlSession session, NSUrlSessionDataTask dataTask, NSUrlSessionDownloadTask downloadTask)
		{
			_DidBecomeDownloadTask (this, session, dataTask, downloadTask);
		}
		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="downloadTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBecomeDownloadTask (INSUrlSessionDataDelegate This, NSUrlSession session, NSUrlSessionDataTask dataTask, NSUrlSessionDownloadTask downloadTask)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var dataTask__handle__ = dataTask!.GetNonNullHandle (nameof (dataTask));
			var downloadTask__handle__ = downloadTask!.GetNonNullHandle (nameof (downloadTask));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:dataTask:didBecomeDownloadTask:"), session__handle__, dataTask__handle__, downloadTask__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (dataTask);
			GC.KeepAlive (downloadTask);
		}
		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="data">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:dataTask:didReceiveData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveData (NSUrlSession session, NSUrlSessionDataTask dataTask, NSData data)
		{
			_DidReceiveData (this, session, dataTask, data);
		}
		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="data">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveData (INSUrlSessionDataDelegate This, NSUrlSession session, NSUrlSessionDataTask dataTask, NSData data)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var dataTask__handle__ = dataTask!.GetNonNullHandle (nameof (dataTask));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:dataTask:didReceiveData:"), session__handle__, dataTask__handle__, data__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (dataTask);
			GC.KeepAlive (data);
		}
		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="proposedResponse">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:dataTask:willCacheResponse:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillCacheResponse (NSUrlSession session, NSUrlSessionDataTask dataTask, NSCachedUrlResponse proposedResponse, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V57))]global::System.Action<NSCachedUrlResponse> completionHandler)
		{
			_WillCacheResponse (this, session, dataTask, proposedResponse, completionHandler);
		}
		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="proposedResponse">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _WillCacheResponse (INSUrlSessionDataDelegate This, NSUrlSession session, NSUrlSessionDataTask dataTask, NSCachedUrlResponse proposedResponse, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V57))]global::System.Action<NSCachedUrlResponse> completionHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var dataTask__handle__ = dataTask!.GetNonNullHandle (nameof (dataTask));
			var proposedResponse__handle__ = proposedResponse!.GetNonNullHandle (nameof (proposedResponse));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V57.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:dataTask:willCacheResponse:completionHandler:"), session__handle__, dataTask__handle__, proposedResponse__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (dataTask);
			GC.KeepAlive (proposedResponse);
		}
		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="streamTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:dataTask:didBecomeStreamTask:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeStreamTask (NSUrlSession session, NSUrlSessionDataTask dataTask, NSUrlSessionStreamTask streamTask)
		{
			_DidBecomeStreamTask (this, session, dataTask, streamTask);
		}
		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="streamTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBecomeStreamTask (INSUrlSessionDataDelegate This, NSUrlSession session, NSUrlSessionDataTask dataTask, NSUrlSessionStreamTask streamTask)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var dataTask__handle__ = dataTask!.GetNonNullHandle (nameof (dataTask));
			var streamTask__handle__ = streamTask!.GetNonNullHandle (nameof (streamTask));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:dataTask:didBecomeStreamTask:"), session__handle__, dataTask__handle__, streamTask__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (dataTask);
			GC.KeepAlive (streamTask);
		}
		[DynamicDependencyAttribute ("DidBecomeDownloadTask(Foundation.NSUrlSession,Foundation.NSUrlSessionDataTask,Foundation.NSUrlSessionDownloadTask)")]
		[DynamicDependencyAttribute ("DidBecomeStreamTask(Foundation.NSUrlSession,Foundation.NSUrlSessionDataTask,Foundation.NSUrlSessionStreamTask)")]
		[DynamicDependencyAttribute ("DidReceiveData(Foundation.NSUrlSession,Foundation.NSUrlSessionDataTask,Foundation.NSData)")]
		[DynamicDependencyAttribute ("DidReceiveResponse(Foundation.NSUrlSession,Foundation.NSUrlSessionDataTask,Foundation.NSUrlResponse,System.Action{Foundation.NSUrlSessionResponseDisposition})")]
		[DynamicDependencyAttribute ("WillCacheResponse(Foundation.NSUrlSession,Foundation.NSUrlSessionDataTask,Foundation.NSCachedUrlResponse,System.Action{Foundation.NSCachedUrlResponse})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlSessionDataDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSUrlSessionDataDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSUrlSessionDataDelegate" /> interface to support all the methods from the NSURLSessionDataDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSUrlSessionDataDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSURLSessionDataDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSUrlSessionDataDelegate_Extensions {
		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="response">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidReceiveResponse (this INSUrlSessionDataDelegate This, NSUrlSession session, NSUrlSessionDataTask dataTask, NSUrlResponse response, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V60))]global::System.Action<NSUrlSessionResponseDisposition> completionHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var dataTask__handle__ = dataTask!.GetNonNullHandle (nameof (dataTask));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V60.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:dataTask:didReceiveResponse:completionHandler:"), session__handle__, dataTask__handle__, response__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (dataTask);
			GC.KeepAlive (response);
		}
		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="downloadTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBecomeDownloadTask (this INSUrlSessionDataDelegate This, NSUrlSession session, NSUrlSessionDataTask dataTask, NSUrlSessionDownloadTask downloadTask)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var dataTask__handle__ = dataTask!.GetNonNullHandle (nameof (dataTask));
			var downloadTask__handle__ = downloadTask!.GetNonNullHandle (nameof (downloadTask));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:dataTask:didBecomeDownloadTask:"), session__handle__, dataTask__handle__, downloadTask__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (dataTask);
			GC.KeepAlive (downloadTask);
		}
		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="data">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveData (this INSUrlSessionDataDelegate This, NSUrlSession session, NSUrlSessionDataTask dataTask, NSData data)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var dataTask__handle__ = dataTask!.GetNonNullHandle (nameof (dataTask));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:dataTask:didReceiveData:"), session__handle__, dataTask__handle__, data__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (dataTask);
			GC.KeepAlive (data);
		}
		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="proposedResponse">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void WillCacheResponse (this INSUrlSessionDataDelegate This, NSUrlSession session, NSUrlSessionDataTask dataTask, NSCachedUrlResponse proposedResponse, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V57))]global::System.Action<NSCachedUrlResponse> completionHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var dataTask__handle__ = dataTask!.GetNonNullHandle (nameof (dataTask));
			var proposedResponse__handle__ = proposedResponse!.GetNonNullHandle (nameof (proposedResponse));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V57.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:dataTask:willCacheResponse:completionHandler:"), session__handle__, dataTask__handle__, proposedResponse__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (dataTask);
			GC.KeepAlive (proposedResponse);
		}
		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="streamTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBecomeStreamTask (this INSUrlSessionDataDelegate This, NSUrlSession session, NSUrlSessionDataTask dataTask, NSUrlSessionStreamTask streamTask)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var dataTask__handle__ = dataTask!.GetNonNullHandle (nameof (dataTask));
			var streamTask__handle__ = streamTask!.GetNonNullHandle (nameof (streamTask));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:dataTask:didBecomeStreamTask:"), session__handle__, dataTask__handle__, streamTask__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (dataTask);
			GC.KeepAlive (streamTask);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSUrlSessionDataDelegateWrapper : BaseWrapper, INSUrlSessionDataDelegate {
		public NSUrlSessionDataDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlSessionDataDelegateWrapper))]
		static NSUrlSessionDataDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace Foundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSUrlSessionDataDelegate" /> (for the protocol <c>NSURLSessionDataDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSUrlSessionDataDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__Foundation_NSUrlSessionDataDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NSUrlSessionDataDelegate : NSUrlSessionTaskDelegate, INSUrlSessionDataDelegate {
		/// <summary>Creates a new <see cref="NSUrlSessionDataDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSUrlSessionDataDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
			GC.KeepAlive (this);
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
		protected NSUrlSessionDataDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
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
		protected internal NSUrlSessionDataDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="downloadTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:dataTask:didBecomeDownloadTask:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeDownloadTask (NSUrlSession session, NSUrlSessionDataTask dataTask, NSUrlSessionDownloadTask downloadTask)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="streamTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:dataTask:didBecomeStreamTask:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeStreamTask (NSUrlSession session, NSUrlSessionDataTask dataTask, NSUrlSessionStreamTask streamTask)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="data">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:dataTask:didReceiveData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveData (NSUrlSession session, NSUrlSessionDataTask dataTask, NSData data)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="response">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:dataTask:didReceiveResponse:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveResponse (NSUrlSession session, NSUrlSessionDataTask dataTask, NSUrlResponse response, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V60))]global::System.Action<NSUrlSessionResponseDisposition> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="dataTask">To be added.</param><param name="proposedResponse">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:dataTask:willCacheResponse:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillCacheResponse (NSUrlSession session, NSUrlSessionDataTask dataTask, NSCachedUrlResponse proposedResponse, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V57))]global::System.Action<NSCachedUrlResponse> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSUrlSessionDataDelegate */
}
