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
	/// <summary>Delegate object for <see cref="T:Foundation.NSUrlSession" /> objects that have <see cref="T:Foundation.NSUrlSessionStreamTask" /> objects.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/reference/Foundation/NSURLSessionStreamDelegate">Apple documentation for <c>NSURLSessionStreamDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "NSURLSessionStreamDelegate", WrapperType = typeof (NSUrlSessionStreamDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReadClosed", Selector = "URLSession:readClosedForStreamTask:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionStreamTask) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteClosed", Selector = "URLSession:writeClosedForStreamTask:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionStreamTask) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "BetterRouteDiscovered", Selector = "URLSession:betterRouteDiscoveredForStreamTask:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionStreamTask) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CompletedTaskCaptureStreams", Selector = "URLSession:streamTask:didBecomeInputStream:outputStream:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionStreamTask), typeof (NSInputStream), typeof (NSOutputStream) }, ParameterByRef = new bool [] { false, false, false, false })]
	public partial interface INSUrlSessionStreamDelegate : INativeObject, IDisposable, 
		Foundation.INSUrlSessionTaskDelegate
	{
		/// <param name="session">To be added.</param><param name="streamTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:readClosedForStreamTask:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReadClosed (NSUrlSession session, NSUrlSessionStreamTask streamTask)
		{
			_ReadClosed (this, session, streamTask);
		}
		/// <param name="session">To be added.</param><param name="streamTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReadClosed (INSUrlSessionStreamDelegate This, NSUrlSession session, NSUrlSessionStreamTask streamTask)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var streamTask__handle__ = streamTask!.GetNonNullHandle (nameof (streamTask));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:readClosedForStreamTask:"), session__handle__, streamTask__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (streamTask);
		}
		/// <param name="session">To be added.</param><param name="streamTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:writeClosedForStreamTask:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteClosed (NSUrlSession session, NSUrlSessionStreamTask streamTask)
		{
			_WriteClosed (this, session, streamTask);
		}
		/// <param name="session">To be added.</param><param name="streamTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WriteClosed (INSUrlSessionStreamDelegate This, NSUrlSession session, NSUrlSessionStreamTask streamTask)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var streamTask__handle__ = streamTask!.GetNonNullHandle (nameof (streamTask));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:writeClosedForStreamTask:"), session__handle__, streamTask__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (streamTask);
		}
		/// <param name="session">To be added.</param><param name="streamTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:betterRouteDiscoveredForStreamTask:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BetterRouteDiscovered (NSUrlSession session, NSUrlSessionStreamTask streamTask)
		{
			_BetterRouteDiscovered (this, session, streamTask);
		}
		/// <param name="session">To be added.</param><param name="streamTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BetterRouteDiscovered (INSUrlSessionStreamDelegate This, NSUrlSession session, NSUrlSessionStreamTask streamTask)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var streamTask__handle__ = streamTask!.GetNonNullHandle (nameof (streamTask));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:betterRouteDiscoveredForStreamTask:"), session__handle__, streamTask__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (streamTask);
		}
		/// <param name="session">To be added.</param><param name="streamTask">To be added.</param><param name="inputStream">To be added.</param><param name="outputStream">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:streamTask:didBecomeInputStream:outputStream:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CompletedTaskCaptureStreams (NSUrlSession session, NSUrlSessionStreamTask streamTask, NSInputStream inputStream, NSOutputStream outputStream)
		{
			_CompletedTaskCaptureStreams (this, session, streamTask, inputStream, outputStream);
		}
		/// <param name="session">To be added.</param><param name="streamTask">To be added.</param><param name="inputStream">To be added.</param><param name="outputStream">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CompletedTaskCaptureStreams (INSUrlSessionStreamDelegate This, NSUrlSession session, NSUrlSessionStreamTask streamTask, NSInputStream inputStream, NSOutputStream outputStream)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var streamTask__handle__ = streamTask!.GetNonNullHandle (nameof (streamTask));
			var inputStream__handle__ = inputStream!.GetNonNullHandle (nameof (inputStream));
			var outputStream__handle__ = outputStream!.GetNonNullHandle (nameof (outputStream));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:streamTask:didBecomeInputStream:outputStream:"), session__handle__, streamTask__handle__, inputStream__handle__, outputStream__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (streamTask);
			GC.KeepAlive (inputStream);
			GC.KeepAlive (outputStream);
		}
		[DynamicDependencyAttribute ("BetterRouteDiscovered(Foundation.NSUrlSession,Foundation.NSUrlSessionStreamTask)")]
		[DynamicDependencyAttribute ("CompletedTaskCaptureStreams(Foundation.NSUrlSession,Foundation.NSUrlSessionStreamTask,Foundation.NSInputStream,Foundation.NSOutputStream)")]
		[DynamicDependencyAttribute ("ReadClosed(Foundation.NSUrlSession,Foundation.NSUrlSessionStreamTask)")]
		[DynamicDependencyAttribute ("WriteClosed(Foundation.NSUrlSession,Foundation.NSUrlSessionStreamTask)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlSessionStreamDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSUrlSessionStreamDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSUrlSessionStreamDelegate" /> interface to support all the methods from the NSURLSessionStreamDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSUrlSessionStreamDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSURLSessionStreamDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSUrlSessionStreamDelegate_Extensions {
		/// <param name="session">To be added.</param><param name="streamTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReadClosed (this INSUrlSessionStreamDelegate This, NSUrlSession session, NSUrlSessionStreamTask streamTask)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var streamTask__handle__ = streamTask!.GetNonNullHandle (nameof (streamTask));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:readClosedForStreamTask:"), session__handle__, streamTask__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (streamTask);
		}
		/// <param name="session">To be added.</param><param name="streamTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WriteClosed (this INSUrlSessionStreamDelegate This, NSUrlSession session, NSUrlSessionStreamTask streamTask)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var streamTask__handle__ = streamTask!.GetNonNullHandle (nameof (streamTask));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:writeClosedForStreamTask:"), session__handle__, streamTask__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (streamTask);
		}
		/// <param name="session">To be added.</param><param name="streamTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void BetterRouteDiscovered (this INSUrlSessionStreamDelegate This, NSUrlSession session, NSUrlSessionStreamTask streamTask)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var streamTask__handle__ = streamTask!.GetNonNullHandle (nameof (streamTask));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:betterRouteDiscoveredForStreamTask:"), session__handle__, streamTask__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (streamTask);
		}
		/// <param name="session">To be added.</param><param name="streamTask">To be added.</param><param name="inputStream">To be added.</param><param name="outputStream">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CompletedTaskCaptureStreams (this INSUrlSessionStreamDelegate This, NSUrlSession session, NSUrlSessionStreamTask streamTask, NSInputStream inputStream, NSOutputStream outputStream)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var streamTask__handle__ = streamTask!.GetNonNullHandle (nameof (streamTask));
			var inputStream__handle__ = inputStream!.GetNonNullHandle (nameof (inputStream));
			var outputStream__handle__ = outputStream!.GetNonNullHandle (nameof (outputStream));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:streamTask:didBecomeInputStream:outputStream:"), session__handle__, streamTask__handle__, inputStream__handle__, outputStream__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (streamTask);
			GC.KeepAlive (inputStream);
			GC.KeepAlive (outputStream);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSUrlSessionStreamDelegateWrapper : BaseWrapper, INSUrlSessionStreamDelegate {
		public NSUrlSessionStreamDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlSessionStreamDelegateWrapper))]
		static NSUrlSessionStreamDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace Foundation {
	/// <summary>Delegate object for <see cref="T:Foundation.NSUrlSession" /> objects that have <see cref="T:Foundation.NSUrlSessionStreamTask" /> objects.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/reference/Foundation/NSURLSessionStreamDelegate">Apple documentation for <c>NSURLSessionStreamDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_macOS__Foundation_NSUrlSessionStreamDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NSUrlSessionStreamDelegate : NSUrlSessionTaskDelegate, INSUrlSessionStreamDelegate {
		/// <summary>Creates a new <see cref="NSUrlSessionStreamDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSUrlSessionStreamDelegate () : base (NSObjectFlag.Empty)
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
		protected NSUrlSessionStreamDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSUrlSessionStreamDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="session">To be added.</param><param name="streamTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:betterRouteDiscoveredForStreamTask:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BetterRouteDiscovered (NSUrlSession session, NSUrlSessionStreamTask streamTask)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="streamTask">To be added.</param><param name="inputStream">To be added.</param><param name="outputStream">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:streamTask:didBecomeInputStream:outputStream:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CompletedTaskCaptureStreams (NSUrlSession session, NSUrlSessionStreamTask streamTask, NSInputStream inputStream, NSOutputStream outputStream)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="streamTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:readClosedForStreamTask:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReadClosed (NSUrlSession session, NSUrlSessionStreamTask streamTask)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="streamTask">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:writeClosedForStreamTask:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteClosed (NSUrlSession session, NSUrlSessionStreamTask streamTask)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSUrlSessionStreamDelegate */
}
