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
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace VisionKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>VNDocumentCameraViewControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "VNDocumentCameraViewControllerDelegate", WrapperType = typeof (VNDocumentCameraViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinish", Selector = "documentCameraViewController:didFinishWithScan:", ParameterType = new Type [] { typeof (VisionKit.VNDocumentCameraViewController), typeof (VisionKit.VNDocumentCameraScan) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCancel", Selector = "documentCameraViewControllerDidCancel:", ParameterType = new Type [] { typeof (VisionKit.VNDocumentCameraViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFail", Selector = "documentCameraViewController:didFailWithError:", ParameterType = new Type [] { typeof (VisionKit.VNDocumentCameraViewController), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IVNDocumentCameraViewControllerDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("documentCameraViewController:didFinishWithScan:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (VNDocumentCameraViewController controller, VNDocumentCameraScan scan)
		{
			_DidFinish (this, controller, scan);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinish (IVNDocumentCameraViewControllerDelegate This, VNDocumentCameraViewController controller, VNDocumentCameraScan scan)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var scan__handle__ = scan!.GetNonNullHandle (nameof (scan));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentCameraViewController:didFinishWithScan:"), controller__handle__, scan__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (scan);
		}
		[global::Foundation.OptionalMember]
		[Export ("documentCameraViewControllerDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancel (VNDocumentCameraViewController controller)
		{
			_DidCancel (this, controller);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCancel (IVNDocumentCameraViewControllerDelegate This, VNDocumentCameraViewController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentCameraViewControllerDidCancel:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		[global::Foundation.OptionalMember]
		[Export ("documentCameraViewController:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFail (VNDocumentCameraViewController controller, NSError error)
		{
			_DidFail (this, controller, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFail (IVNDocumentCameraViewControllerDelegate This, VNDocumentCameraViewController controller, NSError error)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentCameraViewController:didFailWithError:"), controller__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("DidCancel(VisionKit.VNDocumentCameraViewController)")]
		[DynamicDependencyAttribute ("DidFail(VisionKit.VNDocumentCameraViewController,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidFinish(VisionKit.VNDocumentCameraViewController,VisionKit.VNDocumentCameraScan)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (VNDocumentCameraViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IVNDocumentCameraViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IVNDocumentCameraViewControllerDelegate" /> interface to support all the methods from the VNDocumentCameraViewControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IVNDocumentCameraViewControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original VNDocumentCameraViewControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class VNDocumentCameraViewControllerDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinish (this IVNDocumentCameraViewControllerDelegate This, VNDocumentCameraViewController controller, VNDocumentCameraScan scan)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var scan__handle__ = scan!.GetNonNullHandle (nameof (scan));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentCameraViewController:didFinishWithScan:"), controller__handle__, scan__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (scan);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCancel (this IVNDocumentCameraViewControllerDelegate This, VNDocumentCameraViewController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentCameraViewControllerDidCancel:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFail (this IVNDocumentCameraViewControllerDelegate This, VNDocumentCameraViewController controller, NSError error)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentCameraViewController:didFailWithError:"), controller__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (error);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class VNDocumentCameraViewControllerDelegateWrapper : BaseWrapper, IVNDocumentCameraViewControllerDelegate {
		public VNDocumentCameraViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (VNDocumentCameraViewControllerDelegateWrapper))]
		static VNDocumentCameraViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace VisionKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IVNDocumentCameraViewControllerDelegate" /> (for the protocol <c>VNDocumentCameraViewControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IVNDocumentCameraViewControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__VisionKit_VNDocumentCameraViewControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class VNDocumentCameraViewControllerDelegate : NSObject, IVNDocumentCameraViewControllerDelegate {
		/// <summary>Creates a new <see cref="VNDocumentCameraViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public VNDocumentCameraViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected VNDocumentCameraViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal VNDocumentCameraViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("documentCameraViewControllerDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancel (VNDocumentCameraViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("documentCameraViewController:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFail (VNDocumentCameraViewController controller, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("documentCameraViewController:didFinishWithScan:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (VNDocumentCameraViewController controller, VNDocumentCameraScan scan)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class VNDocumentCameraViewControllerDelegate */
}
