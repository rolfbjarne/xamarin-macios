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
	#pragma warning disable CS1573
	/// <summary>Allows messages from JavaScript to be handled by the app.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/WebKit/Reference/WKScriptMessageHandler_Ref/index.html">Apple documentation for <c>WKScriptMessageHandler</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "WKScriptMessageHandler", WrapperType = typeof (WKScriptMessageHandlerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveScriptMessage", Selector = "userContentController:didReceiveScriptMessage:", ParameterType = new Type [] { typeof (WebKit.WKUserContentController), typeof (WebKit.WKScriptMessage) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IWKScriptMessageHandler : INativeObject, IDisposable
	{
		/// <param name="userContentController">To be added.</param><param name="message">To be added.</param><summary>Method that is called after a message is received from a script.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("userContentController:didReceiveScriptMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveScriptMessage (WKUserContentController userContentController, WKScriptMessage message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="userContentController">To be added.</param><param name="message">To be added.</param><summary>Method that is called after a message is received from a script.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveScriptMessage (IWKScriptMessageHandler This, WKUserContentController userContentController, WKScriptMessage message)
		{
			var userContentController__handle__ = userContentController!.GetNonNullHandle (nameof (userContentController));
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:"), userContentController__handle__, message__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (userContentController);
			GC.KeepAlive (message);
		}
		[DynamicDependencyAttribute ("DidReceiveScriptMessage(WebKit.WKUserContentController,WebKit.WKScriptMessage)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKScriptMessageHandlerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IWKScriptMessageHandler ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class WKScriptMessageHandlerWrapper : BaseWrapper, IWKScriptMessageHandler {
		public WKScriptMessageHandlerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKScriptMessageHandlerWrapper))]
		static WKScriptMessageHandlerWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="userContentController">To be added.</param><param name="message">To be added.</param><summary>Method that is called after a message is received from a script.</summary><remarks>To be added.</remarks>
		[Export ("userContentController:didReceiveScriptMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReceiveScriptMessage (WKUserContentController userContentController, WKScriptMessage message)
		{
			var userContentController__handle__ = userContentController!.GetNonNullHandle (nameof (userContentController));
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:"), userContentController__handle__, message__handle__);
			GC.KeepAlive (userContentController);
			GC.KeepAlive (message);
		}
	}
}
namespace WebKit {
	/// <summary>Allows messages from JavaScript to be handled by the app.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/WebKit/Reference/WKScriptMessageHandler_Ref/index.html">Apple documentation for <c>WKScriptMessageHandler</c></related>
	[Protocol()]
	[Register("Microsoft_macOS__WebKit_WKScriptMessageHandler", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class WKScriptMessageHandler : NSObject, IWKScriptMessageHandler {
		/// <summary>Creates a new <see cref="WKScriptMessageHandler" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected WKScriptMessageHandler () : base (NSObjectFlag.Empty)
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
		protected WKScriptMessageHandler (NSObjectFlag t) : base (t)
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
		protected internal WKScriptMessageHandler (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="userContentController">To be added.</param><param name="message">To be added.</param><summary>Method that is called after a message is received from a script.</summary><remarks>To be added.</remarks>
		[Export ("userContentController:didReceiveScriptMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveScriptMessage (WKUserContentController userContentController, WKScriptMessage message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class WKScriptMessageHandler */
}
