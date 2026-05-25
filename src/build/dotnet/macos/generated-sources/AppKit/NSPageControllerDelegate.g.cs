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
namespace AppKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSPageControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSPageControllerDelegate", WrapperType = typeof (NSPageControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetIdentifier", Selector = "pageController:identifierForObject:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (NSPageController), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetViewController", Selector = "pageController:viewControllerForIdentifier:", ReturnType = typeof (NSViewController), ParameterType = new Type [] { typeof (NSPageController), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetFrame", Selector = "pageController:frameForObject:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (NSPageController), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PrepareViewController", Selector = "pageController:prepareViewController:withObject:", ParameterType = new Type [] { typeof (NSPageController), typeof (NSViewController), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidTransition", Selector = "pageController:didTransitionToObject:", ParameterType = new Type [] { typeof (NSPageController), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStartLiveTransition", Selector = "pageControllerWillStartLiveTransition:", ParameterType = new Type [] { typeof (NSPageController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndLiveTransition", Selector = "pageControllerDidEndLiveTransition:", ParameterType = new Type [] { typeof (NSPageController) }, ParameterByRef = new bool [] { false })]
	public partial interface INSPageControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="pageController">To be added.</param><param name="targetObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pageController:identifierForObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetIdentifier (NSPageController pageController, NSObject targetObject)
		{
			return _GetIdentifier (this, pageController, targetObject);
		}
		/// <param name="pageController">To be added.</param><param name="targetObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetIdentifier (INSPageControllerDelegate This, NSPageController pageController, NSObject targetObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pageController__handle__ = pageController!.GetNonNullHandle (nameof (pageController));
			var targetObject__handle__ = targetObject!.GetNonNullHandle (nameof (targetObject));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pageController:identifierForObject:"), pageController__handle__, targetObject__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pageController);
			GC.KeepAlive (targetObject);
			return ret!;
		}
		/// <param name="pageController">To be added.</param><param name="identifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pageController:viewControllerForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSViewController GetViewController (NSPageController pageController, string identifier)
		{
			return _GetViewController (this, pageController, identifier);
		}
		/// <param name="pageController">To be added.</param><param name="identifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSViewController _GetViewController (INSPageControllerDelegate This, NSPageController pageController, string identifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pageController__handle__ = pageController!.GetNonNullHandle (nameof (pageController));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			NSViewController? ret;
			ret =  Runtime.GetNSObject<NSViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pageController:viewControllerForIdentifier:"), pageController__handle__, nsidentifier), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pageController);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		/// <param name="pageController">To be added.</param><param name="targetObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pageController:frameForObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFrame (NSPageController pageController, NSObject targetObject)
		{
			return _GetFrame (this, pageController, targetObject);
		}
		/// <param name="pageController">To be added.</param><param name="targetObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetFrame (INSPageControllerDelegate This, NSPageController pageController, NSObject targetObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pageController__handle__ = pageController!.GetNonNullHandle (nameof (pageController));
			var targetObject__handle__ = targetObject!.GetNonNullHandle (nameof (targetObject));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pageController:frameForObject:"), pageController__handle__, targetObject__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pageController:frameForObject:"), pageController__handle__, targetObject__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (pageController);
			GC.KeepAlive (targetObject);
			return ret!;
		}
		/// <param name="pageController">To be added.</param><param name="viewController">To be added.</param><param name="targetObject">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pageController:prepareViewController:withObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareViewController (NSPageController pageController, NSViewController viewController, NSObject targetObject)
		{
			_PrepareViewController (this, pageController, viewController, targetObject);
		}
		/// <param name="pageController">To be added.</param><param name="viewController">To be added.</param><param name="targetObject">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PrepareViewController (INSPageControllerDelegate This, NSPageController pageController, NSViewController viewController, NSObject targetObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pageController__handle__ = pageController!.GetNonNullHandle (nameof (pageController));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var targetObject__handle__ = targetObject!.GetNonNullHandle (nameof (targetObject));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pageController:prepareViewController:withObject:"), pageController__handle__, viewController__handle__, targetObject__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pageController);
			GC.KeepAlive (viewController);
			GC.KeepAlive (targetObject);
		}
		/// <param name="pageController">To be added.</param><param name="targetObject">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pageController:didTransitionToObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidTransition (NSPageController pageController, NSObject targetObject)
		{
			_DidTransition (this, pageController, targetObject);
		}
		/// <param name="pageController">To be added.</param><param name="targetObject">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidTransition (INSPageControllerDelegate This, NSPageController pageController, NSObject targetObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pageController__handle__ = pageController!.GetNonNullHandle (nameof (pageController));
			var targetObject__handle__ = targetObject!.GetNonNullHandle (nameof (targetObject));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pageController:didTransitionToObject:"), pageController__handle__, targetObject__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pageController);
			GC.KeepAlive (targetObject);
		}
		/// <param name="pageController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pageControllerWillStartLiveTransition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartLiveTransition (NSPageController pageController)
		{
			_WillStartLiveTransition (this, pageController);
		}
		/// <param name="pageController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillStartLiveTransition (INSPageControllerDelegate This, NSPageController pageController)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pageController__handle__ = pageController!.GetNonNullHandle (nameof (pageController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pageControllerWillStartLiveTransition:"), pageController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pageController);
		}
		/// <param name="pageController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pageControllerDidEndLiveTransition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndLiveTransition (NSPageController pageController)
		{
			_DidEndLiveTransition (this, pageController);
		}
		/// <param name="pageController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEndLiveTransition (INSPageControllerDelegate This, NSPageController pageController)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pageController__handle__ = pageController!.GetNonNullHandle (nameof (pageController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pageControllerDidEndLiveTransition:"), pageController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pageController);
		}
		[DynamicDependencyAttribute ("DidEndLiveTransition(AppKit.NSPageController)")]
		[DynamicDependencyAttribute ("DidTransition(AppKit.NSPageController,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("GetFrame(AppKit.NSPageController,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("GetIdentifier(AppKit.NSPageController,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("GetViewController(AppKit.NSPageController,System.String)")]
		[DynamicDependencyAttribute ("PrepareViewController(AppKit.NSPageController,AppKit.NSViewController,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("WillStartLiveTransition(AppKit.NSPageController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSPageControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSPageControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSPageControllerDelegate" /> interface to support all the methods from the NSPageControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSPageControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSPageControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSPageControllerDelegate_Extensions {
		/// <param name="pageController">To be added.</param><param name="targetObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetIdentifier (this INSPageControllerDelegate This, NSPageController pageController, NSObject targetObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pageController__handle__ = pageController!.GetNonNullHandle (nameof (pageController));
			var targetObject__handle__ = targetObject!.GetNonNullHandle (nameof (targetObject));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pageController:identifierForObject:"), pageController__handle__, targetObject__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pageController);
			GC.KeepAlive (targetObject);
			return ret!;
		}
		/// <param name="pageController">To be added.</param><param name="identifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSViewController GetViewController (this INSPageControllerDelegate This, NSPageController pageController, string identifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pageController__handle__ = pageController!.GetNonNullHandle (nameof (pageController));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			NSViewController? ret;
			ret =  Runtime.GetNSObject<NSViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pageController:viewControllerForIdentifier:"), pageController__handle__, nsidentifier), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pageController);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		/// <param name="pageController">To be added.</param><param name="targetObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect GetFrame (this INSPageControllerDelegate This, NSPageController pageController, NSObject targetObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pageController__handle__ = pageController!.GetNonNullHandle (nameof (pageController));
			var targetObject__handle__ = targetObject!.GetNonNullHandle (nameof (targetObject));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pageController:frameForObject:"), pageController__handle__, targetObject__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pageController:frameForObject:"), pageController__handle__, targetObject__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (pageController);
			GC.KeepAlive (targetObject);
			return ret!;
		}
		/// <param name="pageController">To be added.</param><param name="viewController">To be added.</param><param name="targetObject">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PrepareViewController (this INSPageControllerDelegate This, NSPageController pageController, NSViewController viewController, NSObject targetObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pageController__handle__ = pageController!.GetNonNullHandle (nameof (pageController));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var targetObject__handle__ = targetObject!.GetNonNullHandle (nameof (targetObject));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pageController:prepareViewController:withObject:"), pageController__handle__, viewController__handle__, targetObject__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pageController);
			GC.KeepAlive (viewController);
			GC.KeepAlive (targetObject);
		}
		/// <param name="pageController">To be added.</param><param name="targetObject">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidTransition (this INSPageControllerDelegate This, NSPageController pageController, NSObject targetObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pageController__handle__ = pageController!.GetNonNullHandle (nameof (pageController));
			var targetObject__handle__ = targetObject!.GetNonNullHandle (nameof (targetObject));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pageController:didTransitionToObject:"), pageController__handle__, targetObject__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pageController);
			GC.KeepAlive (targetObject);
		}
		/// <param name="pageController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillStartLiveTransition (this INSPageControllerDelegate This, NSPageController pageController)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pageController__handle__ = pageController!.GetNonNullHandle (nameof (pageController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pageControllerWillStartLiveTransition:"), pageController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pageController);
		}
		/// <param name="pageController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEndLiveTransition (this INSPageControllerDelegate This, NSPageController pageController)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pageController__handle__ = pageController!.GetNonNullHandle (nameof (pageController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pageControllerDidEndLiveTransition:"), pageController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pageController);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSPageControllerDelegateWrapper : BaseWrapper, INSPageControllerDelegate {
		public NSPageControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSPageControllerDelegateWrapper))]
		static NSPageControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSPageControllerDelegate" /> (for the protocol <c>NSPageControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSPageControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSPageControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSPageControllerDelegate : NSObject, INSPageControllerDelegate {
		/// <summary>Creates a new <see cref="NSPageControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSPageControllerDelegate () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		protected NSPageControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSPageControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="pageController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("pageControllerDidEndLiveTransition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndLiveTransition (NSPageController pageController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pageController">To be added.</param><param name="targetObject">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("pageController:didTransitionToObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidTransition (NSPageController pageController, NSObject targetObject)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pageController">To be added.</param><param name="targetObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pageController:frameForObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFrame (NSPageController pageController, NSObject targetObject)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pageController">To be added.</param><param name="targetObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pageController:identifierForObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetIdentifier (NSPageController pageController, NSObject targetObject)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pageController">To be added.</param><param name="identifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pageController:viewControllerForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSViewController GetViewController (NSPageController pageController, string identifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pageController">To be added.</param><param name="viewController">To be added.</param><param name="targetObject">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("pageController:prepareViewController:withObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareViewController (NSPageController pageController, NSViewController viewController, NSObject targetObject)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pageController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("pageControllerWillStartLiveTransition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartLiveTransition (NSPageController pageController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSPageControllerDelegate */
}
