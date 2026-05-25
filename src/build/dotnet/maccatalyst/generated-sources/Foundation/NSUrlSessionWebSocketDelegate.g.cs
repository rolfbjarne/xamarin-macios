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
using UIKit;
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
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
	/// <summary>This interface represents the Objective-C protocol <c>NSURLSessionWebSocketDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSURLSessionWebSocketDelegate", WrapperType = typeof (NSUrlSessionWebSocketDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOpen", Selector = "URLSession:webSocketTask:didOpenWithProtocol:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionWebSocketTask), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidClose", Selector = "URLSession:webSocketTask:didCloseWithCode:reason:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionWebSocketTask), typeof (NSUrlSessionWebSocketCloseCode), typeof (NSData) }, ParameterByRef = new bool [] { false, false, false, false })]
	public partial interface INSUrlSessionWebSocketDelegate : INativeObject, IDisposable, 
		Foundation.INSUrlSessionTaskDelegate
	{
		[global::Foundation.OptionalMember]
		[Export ("URLSession:webSocketTask:didOpenWithProtocol:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOpen (NSUrlSession session, NSUrlSessionWebSocketTask webSocketTask, string? protocol)
		{
			_DidOpen (this, session, webSocketTask, protocol);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidOpen (INSUrlSessionWebSocketDelegate This, NSUrlSession session, NSUrlSessionWebSocketTask webSocketTask, string? protocol)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var webSocketTask__handle__ = webSocketTask!.GetNonNullHandle (nameof (webSocketTask));
			var nsprotocol = CFString.CreateNative (protocol);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:webSocketTask:didOpenWithProtocol:"), session__handle__, webSocketTask__handle__, nsprotocol);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (webSocketTask);
			CFString.ReleaseNative (nsprotocol);
		}
		[global::Foundation.OptionalMember]
		[Export ("URLSession:webSocketTask:didCloseWithCode:reason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidClose (NSUrlSession session, NSUrlSessionWebSocketTask webSocketTask, NSUrlSessionWebSocketCloseCode closeCode, NSData? reason)
		{
			_DidClose (this, session, webSocketTask, closeCode, reason);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidClose (INSUrlSessionWebSocketDelegate This, NSUrlSession session, NSUrlSessionWebSocketTask webSocketTask, NSUrlSessionWebSocketCloseCode closeCode, NSData? reason)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var webSocketTask__handle__ = webSocketTask!.GetNonNullHandle (nameof (webSocketTask));
			var reason__handle__ = reason.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:webSocketTask:didCloseWithCode:reason:"), session__handle__, webSocketTask__handle__, (IntPtr) (long) closeCode, reason__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (webSocketTask);
			GC.KeepAlive (reason);
		}
		[DynamicDependencyAttribute ("DidClose(Foundation.NSUrlSession,Foundation.NSUrlSessionWebSocketTask,Foundation.NSUrlSessionWebSocketCloseCode,Foundation.NSData)")]
		[DynamicDependencyAttribute ("DidOpen(Foundation.NSUrlSession,Foundation.NSUrlSessionWebSocketTask,System.String)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlSessionWebSocketDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSUrlSessionWebSocketDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSUrlSessionWebSocketDelegate" /> interface to support all the methods from the NSURLSessionWebSocketDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSUrlSessionWebSocketDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSURLSessionWebSocketDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSUrlSessionWebSocketDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidOpen (this INSUrlSessionWebSocketDelegate This, NSUrlSession session, NSUrlSessionWebSocketTask webSocketTask, string? protocol)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var webSocketTask__handle__ = webSocketTask!.GetNonNullHandle (nameof (webSocketTask));
			var nsprotocol = CFString.CreateNative (protocol);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:webSocketTask:didOpenWithProtocol:"), session__handle__, webSocketTask__handle__, nsprotocol);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (webSocketTask);
			CFString.ReleaseNative (nsprotocol);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidClose (this INSUrlSessionWebSocketDelegate This, NSUrlSession session, NSUrlSessionWebSocketTask webSocketTask, NSUrlSessionWebSocketCloseCode closeCode, NSData? reason)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var webSocketTask__handle__ = webSocketTask!.GetNonNullHandle (nameof (webSocketTask));
			var reason__handle__ = reason.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:webSocketTask:didCloseWithCode:reason:"), session__handle__, webSocketTask__handle__, (IntPtr) (long) closeCode, reason__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (webSocketTask);
			GC.KeepAlive (reason);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSUrlSessionWebSocketDelegateWrapper : BaseWrapper, INSUrlSessionWebSocketDelegate {
		public NSUrlSessionWebSocketDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlSessionWebSocketDelegateWrapper))]
		static NSUrlSessionWebSocketDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace Foundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSUrlSessionWebSocketDelegate" /> (for the protocol <c>NSURLSessionWebSocketDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSUrlSessionWebSocketDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__Foundation_NSUrlSessionWebSocketDelegate", false)]
	[Model]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSUrlSessionWebSocketDelegate : NSUrlSessionTaskDelegate, INSUrlSessionWebSocketDelegate {
		/// <summary>Creates a new <see cref="NSUrlSessionWebSocketDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSUrlSessionWebSocketDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
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
		protected NSUrlSessionWebSocketDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSUrlSessionWebSocketDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("URLSession:webSocketTask:didCloseWithCode:reason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidClose (NSUrlSession session, NSUrlSessionWebSocketTask webSocketTask, NSUrlSessionWebSocketCloseCode closeCode, NSData? reason)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("URLSession:webSocketTask:didOpenWithProtocol:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOpen (NSUrlSession session, NSUrlSessionWebSocketTask webSocketTask, string? protocol)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSUrlSessionWebSocketDelegate */
}
