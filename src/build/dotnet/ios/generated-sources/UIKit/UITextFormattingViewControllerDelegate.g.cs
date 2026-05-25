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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UITextFormattingViewControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios18.0")]
	[Protocol (Name = "UITextFormattingViewControllerDelegate", WrapperType = typeof (UITextFormattingViewControllerDelegateWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidChangeValue", Selector = "textFormattingViewController:didChangeValue:", ParameterType = new Type [] { typeof (UITextFormattingViewController), typeof (UITextFormattingViewControllerChangeValue) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldPresentFontPicker", Selector = "textFormattingViewController:shouldPresentFontPicker:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextFormattingViewController), typeof (UIFontPickerViewController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldPresentColorPicker", Selector = "textFormattingViewController:shouldPresentColorPicker:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextFormattingViewController), typeof (UIColorPickerViewController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TextFormattingDidFinish", Selector = "textFormattingDidFinish:", ParameterType = new Type [] { typeof (UITextFormattingViewController) }, ParameterByRef = new bool [] { false })]
	public partial interface IUITextFormattingViewControllerDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("textFormattingViewController:didChangeValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeValue (UITextFormattingViewController viewController, UITextFormattingViewControllerChangeValue changeValue)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeValue (IUITextFormattingViewControllerDelegate This, UITextFormattingViewController viewController, UITextFormattingViewControllerChangeValue changeValue)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var changeValue__handle__ = changeValue!.GetNonNullHandle (nameof (changeValue));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textFormattingViewController:didChangeValue:"), viewController__handle__, changeValue__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (changeValue);
		}
		[global::Foundation.OptionalMember]
		[Export ("textFormattingViewController:shouldPresentFontPicker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPresentFontPicker (UITextFormattingViewController viewController, UIFontPickerViewController fontPicker)
		{
			return _ShouldPresentFontPicker (this, viewController, fontPicker);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldPresentFontPicker (IUITextFormattingViewControllerDelegate This, UITextFormattingViewController viewController, UIFontPickerViewController fontPicker)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var fontPicker__handle__ = fontPicker!.GetNonNullHandle (nameof (fontPicker));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textFormattingViewController:shouldPresentFontPicker:"), viewController__handle__, fontPicker__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (fontPicker);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("textFormattingViewController:shouldPresentColorPicker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPresentColorPicker (UITextFormattingViewController viewController, UIColorPickerViewController colorPicker)
		{
			return _ShouldPresentColorPicker (this, viewController, colorPicker);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldPresentColorPicker (IUITextFormattingViewControllerDelegate This, UITextFormattingViewController viewController, UIColorPickerViewController colorPicker)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var colorPicker__handle__ = colorPicker!.GetNonNullHandle (nameof (colorPicker));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textFormattingViewController:shouldPresentColorPicker:"), viewController__handle__, colorPicker__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (colorPicker);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("textFormattingDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TextFormattingDidFinish (UITextFormattingViewController viewController)
		{
			_TextFormattingDidFinish (this, viewController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _TextFormattingDidFinish (IUITextFormattingViewControllerDelegate This, UITextFormattingViewController viewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textFormattingDidFinish:"), viewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
		}
		[DynamicDependencyAttribute ("DidChangeValue(UIKit.UITextFormattingViewController,UIKit.UITextFormattingViewControllerChangeValue)")]
		[DynamicDependencyAttribute ("ShouldPresentColorPicker(UIKit.UITextFormattingViewController,UIKit.UIColorPickerViewController)")]
		[DynamicDependencyAttribute ("ShouldPresentFontPicker(UIKit.UITextFormattingViewController,UIKit.UIFontPickerViewController)")]
		[DynamicDependencyAttribute ("TextFormattingDidFinish(UIKit.UITextFormattingViewController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextFormattingViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextFormattingViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextFormattingViewControllerDelegateWrapper : BaseWrapper, IUITextFormattingViewControllerDelegate {
		public UITextFormattingViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextFormattingViewControllerDelegateWrapper))]
		static UITextFormattingViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("textFormattingViewController:didChangeValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidChangeValue (UITextFormattingViewController viewController, UITextFormattingViewControllerChangeValue changeValue)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var changeValue__handle__ = changeValue!.GetNonNullHandle (nameof (changeValue));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textFormattingViewController:didChangeValue:"), viewController__handle__, changeValue__handle__);
			GC.KeepAlive (viewController);
			GC.KeepAlive (changeValue);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUITextFormattingViewControllerDelegate" /> (for the protocol <c>UITextFormattingViewControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUITextFormattingViewControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UITextFormattingViewControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios18.0")]
	public unsafe abstract partial class UITextFormattingViewControllerDelegate : NSObject, IUITextFormattingViewControllerDelegate {
		/// <summary>Creates a new <see cref="UITextFormattingViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UITextFormattingViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected UITextFormattingViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal UITextFormattingViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("textFormattingViewController:didChangeValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeValue (UITextFormattingViewController viewController, UITextFormattingViewControllerChangeValue changeValue)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textFormattingViewController:shouldPresentColorPicker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPresentColorPicker (UITextFormattingViewController viewController, UIColorPickerViewController colorPicker)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textFormattingViewController:shouldPresentFontPicker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPresentFontPicker (UITextFormattingViewController viewController, UIFontPickerViewController fontPicker)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textFormattingDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TextFormattingDidFinish (UITextFormattingViewController viewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UITextFormattingViewControllerDelegate */
}
