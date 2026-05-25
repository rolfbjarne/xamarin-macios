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
	/// <summary>This interface represents the Objective-C protocol <c>UIColorPickerViewControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "UIColorPickerViewControllerDelegate", WrapperType = typeof (UIColorPickerViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectColor", Selector = "colorPickerViewControllerDidSelectColor:", ParameterType = new Type [] { typeof (UIColorPickerViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectColor", Selector = "colorPickerViewController:didSelectColor:continuously:", ParameterType = new Type [] { typeof (UIColorPickerViewController), typeof (UIColor), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinish", Selector = "colorPickerViewControllerDidFinish:", ParameterType = new Type [] { typeof (UIColorPickerViewController) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIColorPickerViewControllerDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("colorPickerViewControllerDidSelectColor:")]
		[ObsoletedOSPlatform ("ios15.0", "Use the 'DidSelectColor (UIColorPickerViewController, UIColor, bool)' overload instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'DidSelectColor (UIColorPickerViewController, UIColor, bool)' overload instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectColor (UIColorPickerViewController viewController)
		{
			_DidSelectColor (this, viewController);
		}
		[ObsoletedOSPlatform ("ios15.0", "Use the 'DidSelectColor (UIColorPickerViewController, UIColor, bool)' overload instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'DidSelectColor (UIColorPickerViewController, UIColor, bool)' overload instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectColor (IUIColorPickerViewControllerDelegate This, UIColorPickerViewController viewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("colorPickerViewControllerDidSelectColor:"), viewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
		}
		[global::Foundation.OptionalMember]
		[Export ("colorPickerViewController:didSelectColor:continuously:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectColor (UIColorPickerViewController viewController, UIColor color, bool continuously)
		{
			_DidSelectColor (this, viewController, color, continuously);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectColor (IUIColorPickerViewControllerDelegate This, UIColorPickerViewController viewController, UIColor color, bool continuously)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var color__handle__ = color!.GetNonNullHandle (nameof (color));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("colorPickerViewController:didSelectColor:continuously:"), viewController__handle__, color__handle__, continuously ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (color);
		}
		[global::Foundation.OptionalMember]
		[Export ("colorPickerViewControllerDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (UIColorPickerViewController viewController)
		{
			_DidFinish (this, viewController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinish (IUIColorPickerViewControllerDelegate This, UIColorPickerViewController viewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("colorPickerViewControllerDidFinish:"), viewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
		}
		[DynamicDependencyAttribute ("DidFinish(UIKit.UIColorPickerViewController)")]
		[DynamicDependencyAttribute ("DidSelectColor(UIKit.UIColorPickerViewController,UIKit.UIColor,System.Boolean)")]
		[DynamicDependencyAttribute ("DidSelectColor(UIKit.UIColorPickerViewController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIColorPickerViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIColorPickerViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIColorPickerViewControllerDelegate" /> interface to support all the methods from the UIColorPickerViewControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIColorPickerViewControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIColorPickerViewControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIColorPickerViewControllerDelegate_Extensions {
		[ObsoletedOSPlatform ("ios15.0", "Use the 'DidSelectColor (UIColorPickerViewController, UIColor, bool)' overload instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'DidSelectColor (UIColorPickerViewController, UIColor, bool)' overload instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectColor (this IUIColorPickerViewControllerDelegate This, UIColorPickerViewController viewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("colorPickerViewControllerDidSelectColor:"), viewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectColor (this IUIColorPickerViewControllerDelegate This, UIColorPickerViewController viewController, UIColor color, bool continuously)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var color__handle__ = color!.GetNonNullHandle (nameof (color));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("colorPickerViewController:didSelectColor:continuously:"), viewController__handle__, color__handle__, continuously ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (color);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinish (this IUIColorPickerViewControllerDelegate This, UIColorPickerViewController viewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("colorPickerViewControllerDidFinish:"), viewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIColorPickerViewControllerDelegateWrapper : BaseWrapper, IUIColorPickerViewControllerDelegate {
		public UIColorPickerViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIColorPickerViewControllerDelegateWrapper))]
		static UIColorPickerViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIColorPickerViewControllerDelegate" /> (for the protocol <c>UIColorPickerViewControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIColorPickerViewControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UIColorPickerViewControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class UIColorPickerViewControllerDelegate : NSObject, IUIColorPickerViewControllerDelegate {
		/// <summary>Creates a new <see cref="UIColorPickerViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIColorPickerViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected UIColorPickerViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIColorPickerViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("colorPickerViewControllerDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (UIColorPickerViewController viewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("colorPickerViewControllerDidSelectColor:")]
		[ObsoletedOSPlatform ("ios15.0", "Use the 'DidSelectColor (UIColorPickerViewController, UIColor, bool)' overload instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'DidSelectColor (UIColorPickerViewController, UIColor, bool)' overload instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectColor (UIColorPickerViewController viewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("colorPickerViewController:didSelectColor:continuously:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectColor (UIColorPickerViewController viewController, UIColor color, bool continuously)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIColorPickerViewControllerDelegate */
}
