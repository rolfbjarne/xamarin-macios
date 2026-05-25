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
namespace PassKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>PKShareSecureElementPassViewControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[Protocol (Name = "PKShareSecureElementPassViewControllerDelegate", WrapperType = typeof (PKShareSecureElementPassViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFinish", Selector = "shareSecureElementPassViewController:didFinishWithResult:", ParameterType = new Type [] { typeof (PassKit.PKShareSecureElementPassViewController), typeof (PassKit.PKShareSecureElementPassResult) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCreateShareUrl", Selector = "shareSecureElementPassViewController:didCreateShareURL:activationCode:", ParameterType = new Type [] { typeof (PassKit.PKShareSecureElementPassViewController), typeof (NSUrl), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IPKShareSecureElementPassViewControllerDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("shareSecureElementPassViewController:didFinishWithResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (PKShareSecureElementPassViewController controller, PKShareSecureElementPassResult result)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinish (IPKShareSecureElementPassViewControllerDelegate This, PKShareSecureElementPassViewController controller, PKShareSecureElementPassResult result)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("shareSecureElementPassViewController:didFinishWithResult:"), controller__handle__, (IntPtr) (long) result);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		[global::Foundation.OptionalMember]
		[Export ("shareSecureElementPassViewController:didCreateShareURL:activationCode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCreateShareUrl (PKShareSecureElementPassViewController controller, NSUrl? universalShareUrl, string? activationCode)
		{
			_DidCreateShareUrl (this, controller, universalShareUrl, activationCode);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCreateShareUrl (IPKShareSecureElementPassViewControllerDelegate This, PKShareSecureElementPassViewController controller, NSUrl? universalShareUrl, string? activationCode)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var universalShareUrl__handle__ = universalShareUrl.GetHandle ();
			var nsactivationCode = CFString.CreateNative (activationCode);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("shareSecureElementPassViewController:didCreateShareURL:activationCode:"), controller__handle__, universalShareUrl__handle__, nsactivationCode);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (universalShareUrl);
			CFString.ReleaseNative (nsactivationCode);
		}
		[DynamicDependencyAttribute ("DidCreateShareUrl(PassKit.PKShareSecureElementPassViewController,Foundation.NSUrl,System.String)")]
		[DynamicDependencyAttribute ("DidFinish(PassKit.PKShareSecureElementPassViewController,PassKit.PKShareSecureElementPassResult)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKShareSecureElementPassViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPKShareSecureElementPassViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IPKShareSecureElementPassViewControllerDelegate" /> interface to support all the methods from the PKShareSecureElementPassViewControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IPKShareSecureElementPassViewControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original PKShareSecureElementPassViewControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class PKShareSecureElementPassViewControllerDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCreateShareUrl (this IPKShareSecureElementPassViewControllerDelegate This, PKShareSecureElementPassViewController controller, NSUrl? universalShareUrl, string? activationCode)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var universalShareUrl__handle__ = universalShareUrl.GetHandle ();
			var nsactivationCode = CFString.CreateNative (activationCode);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("shareSecureElementPassViewController:didCreateShareURL:activationCode:"), controller__handle__, universalShareUrl__handle__, nsactivationCode);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (universalShareUrl);
			CFString.ReleaseNative (nsactivationCode);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PKShareSecureElementPassViewControllerDelegateWrapper : BaseWrapper, IPKShareSecureElementPassViewControllerDelegate {
		public PKShareSecureElementPassViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKShareSecureElementPassViewControllerDelegateWrapper))]
		static PKShareSecureElementPassViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("shareSecureElementPassViewController:didFinishWithResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFinish (PKShareSecureElementPassViewController controller, PKShareSecureElementPassResult result)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("shareSecureElementPassViewController:didFinishWithResult:"), controller__handle__, (IntPtr) (long) result);
			GC.KeepAlive (controller);
		}
	}
}
namespace PassKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IPKShareSecureElementPassViewControllerDelegate" /> (for the protocol <c>PKShareSecureElementPassViewControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IPKShareSecureElementPassViewControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__PassKit_PKShareSecureElementPassViewControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	public unsafe abstract partial class PKShareSecureElementPassViewControllerDelegate : NSObject, IPKShareSecureElementPassViewControllerDelegate {
		/// <summary>Creates a new <see cref="PKShareSecureElementPassViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PKShareSecureElementPassViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PKShareSecureElementPassViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal PKShareSecureElementPassViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("shareSecureElementPassViewController:didCreateShareURL:activationCode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCreateShareUrl (PKShareSecureElementPassViewController controller, NSUrl? universalShareUrl, string? activationCode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("shareSecureElementPassViewController:didFinishWithResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (PKShareSecureElementPassViewController controller, PKShareSecureElementPassResult result)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class PKShareSecureElementPassViewControllerDelegate */
}
