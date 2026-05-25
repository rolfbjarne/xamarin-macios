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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>A class used to receive notifications from the <see cref="T:UIKit.UIImagePickerController" />.</summary><remarks><para>
	/// Application developers can implement this delegate in order to handle actions associated with the <see cref="T:UIKit.UIImagePickerController" />
	/// and the capture or selection of images or video. The application developer is responsible for dismissing the <see cref="T:UIKit.UIImagePickerController" />
	/// after the operation (capture, selection, or cancellation) is complete and should do so using the
	/// <see cref="M:UIKit.UIViewController.DismissModalViewController(System.Boolean)" /> method of the parent <see cref="T:UIKit.UIViewController" />.
	/// </para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIImagePickerControllerDelegate_Protocol/index.html">Apple documentation for <c>UIImagePickerControllerDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIImagePickerControllerDelegate", WrapperType = typeof (UIImagePickerControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FinishedPickingMedia", Selector = "imagePickerController:didFinishPickingMediaWithInfo:", ParameterType = new Type [] { typeof (UIImagePickerController), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Canceled", Selector = "imagePickerControllerDidCancel:", ParameterType = new Type [] { typeof (UIImagePickerController) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIImagePickerControllerDelegate : INativeObject, IDisposable, 
		UIKit.IUINavigationControllerDelegate
	{
		/// <param name="picker">To be added.</param><param name="info">To be added.</param><summary>Indicates that the user has picked a picture or movie.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("imagePickerController:didFinishPickingMediaWithInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedPickingMedia (UIImagePickerController picker, NSDictionary info)
		{
			_FinishedPickingMedia (this, picker, info);
		}
		/// <param name="picker">To be added.</param><param name="info">To be added.</param><summary>Indicates that the user has picked a picture or movie.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FinishedPickingMedia (IUIImagePickerControllerDelegate This, UIImagePickerController picker, NSDictionary info)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var picker__handle__ = picker!.GetNonNullHandle (nameof (picker));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("imagePickerController:didFinishPickingMediaWithInfo:"), picker__handle__, info__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (picker);
			GC.KeepAlive (info);
		}
		/// <param name="picker">To be added.</param><summary>Indicates that the user cancelled the media-picking operation.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("imagePickerControllerDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Canceled (UIImagePickerController picker)
		{
			_Canceled (this, picker);
		}
		/// <param name="picker">To be added.</param><summary>Indicates that the user cancelled the media-picking operation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Canceled (IUIImagePickerControllerDelegate This, UIImagePickerController picker)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var picker__handle__ = picker!.GetNonNullHandle (nameof (picker));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("imagePickerControllerDidCancel:"), picker__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (picker);
		}
		[DynamicDependencyAttribute ("Canceled(UIKit.UIImagePickerController)")]
		[DynamicDependencyAttribute ("FinishedPickingMedia(UIKit.UIImagePickerController,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIImagePickerControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIImagePickerControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIImagePickerControllerDelegate" /> interface to support all the methods from the UIImagePickerControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIImagePickerControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIImagePickerControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIImagePickerControllerDelegate_Extensions {
		/// <param name="picker">To be added.</param><param name="info">To be added.</param><summary>Indicates that the user has picked a picture or movie.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FinishedPickingMedia (this IUIImagePickerControllerDelegate This, UIImagePickerController picker, NSDictionary info)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var picker__handle__ = picker!.GetNonNullHandle (nameof (picker));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("imagePickerController:didFinishPickingMediaWithInfo:"), picker__handle__, info__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (picker);
			GC.KeepAlive (info);
		}
		/// <param name="picker">To be added.</param><summary>Indicates that the user cancelled the media-picking operation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Canceled (this IUIImagePickerControllerDelegate This, UIImagePickerController picker)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var picker__handle__ = picker!.GetNonNullHandle (nameof (picker));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("imagePickerControllerDidCancel:"), picker__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (picker);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIImagePickerControllerDelegateWrapper : BaseWrapper, IUIImagePickerControllerDelegate {
		public UIImagePickerControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIImagePickerControllerDelegateWrapper))]
		static UIImagePickerControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>A class used to receive notifications from the <see cref="T:UIKit.UIImagePickerController" />.</summary><remarks><para>
	/// Application developers can implement this delegate in order to handle actions associated with the <see cref="T:UIKit.UIImagePickerController" />
	/// and the capture or selection of images or video. The application developer is responsible for dismissing the <see cref="T:UIKit.UIImagePickerController" />
	/// after the operation (capture, selection, or cancellation) is complete and should do so using the
	/// <see cref="M:UIKit.UIViewController.DismissModalViewController(System.Boolean)" /> method of the parent <see cref="T:UIKit.UIViewController" />.
	/// </para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIImagePickerControllerDelegate_Protocol/index.html">Apple documentation for <c>UIImagePickerControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UIImagePickerControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIImagePickerControllerDelegate : UINavigationControllerDelegate, IUIImagePickerControllerDelegate {
		/// <summary>Creates a new <see cref="UIImagePickerControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIImagePickerControllerDelegate () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		protected UIImagePickerControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIImagePickerControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="picker">To be added.</param><summary>Indicates that the user cancelled the media-picking operation.</summary><remarks>To be added.</remarks>
		[Export ("imagePickerControllerDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Canceled (UIImagePickerController picker)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="picker">To be added.</param><param name="info">To be added.</param><summary>Indicates that the user has picked a picture or movie.</summary><remarks>To be added.</remarks>
		[Export ("imagePickerController:didFinishPickingMediaWithInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedPickingMedia (UIImagePickerController picker, NSDictionary info)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIImagePickerControllerDelegate */
}
