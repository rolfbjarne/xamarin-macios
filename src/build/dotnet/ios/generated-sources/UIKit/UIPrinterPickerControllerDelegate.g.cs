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
	/// <summary>Delegate object for a <see cref="T:UIKit.UIPrinterPickerController" />. Defines events relating to the presentation and dismissal of the controller, and a method for when a printer has been selected.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIPrinterPickerControllerDelegate_protocol/index.html">Apple documentation for <c>UIPrinterPickerControllerDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIPrinterPickerControllerDelegate", WrapperType = typeof (UIPrinterPickerControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetParentViewController", Selector = "printerPickerControllerParentViewController:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (UIPrinterPickerController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowPrinter", Selector = "printerPickerController:shouldShowPrinter:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIPrinterPickerController), typeof (UIPrinter) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresent", Selector = "printerPickerControllerWillPresent:", ParameterType = new Type [] { typeof (UIPrinterPickerController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPresent", Selector = "printerPickerControllerDidPresent:", ParameterType = new Type [] { typeof (UIPrinterPickerController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDismiss", Selector = "printerPickerControllerWillDismiss:", ParameterType = new Type [] { typeof (UIPrinterPickerController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismiss", Selector = "printerPickerControllerDidDismiss:", ParameterType = new Type [] { typeof (UIPrinterPickerController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectPrinter", Selector = "printerPickerControllerDidSelectPrinter:", ParameterType = new Type [] { typeof (UIPrinterPickerController) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIPrinterPickerControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>Gets the parent view controller of the <paramref name="printerPickerController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("printerPickerControllerParentViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetParentViewController (UIPrinterPickerController printerPickerController)
		{
			return _GetParentViewController (this, printerPickerController);
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>Gets the parent view controller of the <paramref name="printerPickerController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIViewController _GetParentViewController (IUIPrinterPickerControllerDelegate This, UIPrinterPickerController printerPickerController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printerPickerController__handle__ = printerPickerController!.GetNonNullHandle (nameof (printerPickerController));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printerPickerControllerParentViewController:"), printerPickerController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (printerPickerController);
			return ret!;
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><param name="printer">Designated printer for consideration by the delegate.</param><summary>The <paramref name="printerPickerController" /> should show <paramref name="printer" /> to the user.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("printerPickerController:shouldShowPrinter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowPrinter (UIPrinterPickerController printerPickerController, UIPrinter printer)
		{
			return _ShouldShowPrinter (this, printerPickerController, printer);
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><param name="printer">Designated printer for consideration by the delegate.</param><summary>The <paramref name="printerPickerController" /> should show <paramref name="printer" /> to the user.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldShowPrinter (IUIPrinterPickerControllerDelegate This, UIPrinterPickerController printerPickerController, UIPrinter printer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printerPickerController__handle__ = printerPickerController!.GetNonNullHandle (nameof (printerPickerController));
			var printer__handle__ = printer!.GetNonNullHandle (nameof (printer));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("printerPickerController:shouldShowPrinter:"), printerPickerController__handle__, printer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printerPickerController);
			GC.KeepAlive (printer);
			return ret != 0;
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>The <paramref name="printerPickerController" /> is about to be presented.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("printerPickerControllerWillPresent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresent (UIPrinterPickerController printerPickerController)
		{
			_WillPresent (this, printerPickerController);
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>The <paramref name="printerPickerController" /> is about to be presented.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPresent (IUIPrinterPickerControllerDelegate This, UIPrinterPickerController printerPickerController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printerPickerController__handle__ = printerPickerController!.GetNonNullHandle (nameof (printerPickerController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printerPickerControllerWillPresent:"), printerPickerController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printerPickerController);
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>TThe <paramref name="printerPickerController" /> was presented.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("printerPickerControllerDidPresent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPresent (UIPrinterPickerController printerPickerController)
		{
			_DidPresent (this, printerPickerController);
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>TThe <paramref name="printerPickerController" /> was presented.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidPresent (IUIPrinterPickerControllerDelegate This, UIPrinterPickerController printerPickerController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printerPickerController__handle__ = printerPickerController!.GetNonNullHandle (nameof (printerPickerController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printerPickerControllerDidPresent:"), printerPickerController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printerPickerController);
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>The <paramref name="printerPickerController" /> is about to be dismissed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("printerPickerControllerWillDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismiss (UIPrinterPickerController printerPickerController)
		{
			_WillDismiss (this, printerPickerController);
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>The <paramref name="printerPickerController" /> is about to be dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDismiss (IUIPrinterPickerControllerDelegate This, UIPrinterPickerController printerPickerController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printerPickerController__handle__ = printerPickerController!.GetNonNullHandle (nameof (printerPickerController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printerPickerControllerWillDismiss:"), printerPickerController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printerPickerController);
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>The <paramref name="printerPickerController" /> was dismissed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("printerPickerControllerDidDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismiss (UIPrinterPickerController printerPickerController)
		{
			_DidDismiss (this, printerPickerController);
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>The <paramref name="printerPickerController" /> was dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDismiss (IUIPrinterPickerControllerDelegate This, UIPrinterPickerController printerPickerController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printerPickerController__handle__ = printerPickerController!.GetNonNullHandle (nameof (printerPickerController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printerPickerControllerDidDismiss:"), printerPickerController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printerPickerController);
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>The <paramref name="printerPickerController" /> selected a printer.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("printerPickerControllerDidSelectPrinter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectPrinter (UIPrinterPickerController printerPickerController)
		{
			_DidSelectPrinter (this, printerPickerController);
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>The <paramref name="printerPickerController" /> selected a printer.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectPrinter (IUIPrinterPickerControllerDelegate This, UIPrinterPickerController printerPickerController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printerPickerController__handle__ = printerPickerController!.GetNonNullHandle (nameof (printerPickerController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printerPickerControllerDidSelectPrinter:"), printerPickerController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printerPickerController);
		}
		[DynamicDependencyAttribute ("DidDismiss(UIKit.UIPrinterPickerController)")]
		[DynamicDependencyAttribute ("DidPresent(UIKit.UIPrinterPickerController)")]
		[DynamicDependencyAttribute ("DidSelectPrinter(UIKit.UIPrinterPickerController)")]
		[DynamicDependencyAttribute ("GetParentViewController(UIKit.UIPrinterPickerController)")]
		[DynamicDependencyAttribute ("ShouldShowPrinter(UIKit.UIPrinterPickerController,UIKit.UIPrinter)")]
		[DynamicDependencyAttribute ("WillDismiss(UIKit.UIPrinterPickerController)")]
		[DynamicDependencyAttribute ("WillPresent(UIKit.UIPrinterPickerController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPrinterPickerControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIPrinterPickerControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIPrinterPickerControllerDelegate" /> interface to support all the methods from the UIPrinterPickerControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIPrinterPickerControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIPrinterPickerControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIPrinterPickerControllerDelegate_Extensions {
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>Gets the parent view controller of the <paramref name="printerPickerController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIViewController GetParentViewController (this IUIPrinterPickerControllerDelegate This, UIPrinterPickerController printerPickerController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printerPickerController__handle__ = printerPickerController!.GetNonNullHandle (nameof (printerPickerController));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printerPickerControllerParentViewController:"), printerPickerController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (printerPickerController);
			return ret!;
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><param name="printer">Designated printer for consideration by the delegate.</param><summary>The <paramref name="printerPickerController" /> should show <paramref name="printer" /> to the user.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldShowPrinter (this IUIPrinterPickerControllerDelegate This, UIPrinterPickerController printerPickerController, UIPrinter printer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printerPickerController__handle__ = printerPickerController!.GetNonNullHandle (nameof (printerPickerController));
			var printer__handle__ = printer!.GetNonNullHandle (nameof (printer));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("printerPickerController:shouldShowPrinter:"), printerPickerController__handle__, printer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printerPickerController);
			GC.KeepAlive (printer);
			return ret != 0;
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>The <paramref name="printerPickerController" /> is about to be presented.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresent (this IUIPrinterPickerControllerDelegate This, UIPrinterPickerController printerPickerController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printerPickerController__handle__ = printerPickerController!.GetNonNullHandle (nameof (printerPickerController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printerPickerControllerWillPresent:"), printerPickerController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printerPickerController);
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>TThe <paramref name="printerPickerController" /> was presented.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPresent (this IUIPrinterPickerControllerDelegate This, UIPrinterPickerController printerPickerController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printerPickerController__handle__ = printerPickerController!.GetNonNullHandle (nameof (printerPickerController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printerPickerControllerDidPresent:"), printerPickerController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printerPickerController);
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>The <paramref name="printerPickerController" /> is about to be dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDismiss (this IUIPrinterPickerControllerDelegate This, UIPrinterPickerController printerPickerController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printerPickerController__handle__ = printerPickerController!.GetNonNullHandle (nameof (printerPickerController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printerPickerControllerWillDismiss:"), printerPickerController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printerPickerController);
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>The <paramref name="printerPickerController" /> was dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismiss (this IUIPrinterPickerControllerDelegate This, UIPrinterPickerController printerPickerController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printerPickerController__handle__ = printerPickerController!.GetNonNullHandle (nameof (printerPickerController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printerPickerControllerDidDismiss:"), printerPickerController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printerPickerController);
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>The <paramref name="printerPickerController" /> selected a printer.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectPrinter (this IUIPrinterPickerControllerDelegate This, UIPrinterPickerController printerPickerController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printerPickerController__handle__ = printerPickerController!.GetNonNullHandle (nameof (printerPickerController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printerPickerControllerDidSelectPrinter:"), printerPickerController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printerPickerController);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIPrinterPickerControllerDelegateWrapper : BaseWrapper, IUIPrinterPickerControllerDelegate {
		public UIPrinterPickerControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPrinterPickerControllerDelegateWrapper))]
		static UIPrinterPickerControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>Delegate object for a <see cref="T:UIKit.UIPrinterPickerController" />. Defines events relating to the presentation and dismissal of the controller, and a method for when a printer has been selected.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIPrinterPickerControllerDelegate_protocol/index.html">Apple documentation for <c>UIPrinterPickerControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UIPrinterPickerControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIPrinterPickerControllerDelegate : NSObject, IUIPrinterPickerControllerDelegate {
		/// <summary>Creates a new <see cref="UIPrinterPickerControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIPrinterPickerControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected UIPrinterPickerControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIPrinterPickerControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>The <paramref name="printerPickerController" /> was dismissed.</summary><remarks>To be added.</remarks>
		[Export ("printerPickerControllerDidDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismiss (UIPrinterPickerController printerPickerController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>TThe <paramref name="printerPickerController" /> was presented.</summary><remarks>To be added.</remarks>
		[Export ("printerPickerControllerDidPresent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPresent (UIPrinterPickerController printerPickerController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>The <paramref name="printerPickerController" /> selected a printer.</summary><remarks>To be added.</remarks>
		[Export ("printerPickerControllerDidSelectPrinter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectPrinter (UIPrinterPickerController printerPickerController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>Gets the parent view controller of the <paramref name="printerPickerController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("printerPickerControllerParentViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetParentViewController (UIPrinterPickerController printerPickerController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><param name="printer">Designated printer for consideration by the delegate.</param><summary>The <paramref name="printerPickerController" /> should show <paramref name="printer" /> to the user.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("printerPickerController:shouldShowPrinter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowPrinter (UIPrinterPickerController printerPickerController, UIPrinter printer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>The <paramref name="printerPickerController" /> is about to be dismissed.</summary><remarks>To be added.</remarks>
		[Export ("printerPickerControllerWillDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismiss (UIPrinterPickerController printerPickerController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="printerPickerController">The printer picker controller that is being displayed.</param><summary>The <paramref name="printerPickerController" /> is about to be presented.</summary><remarks>To be added.</remarks>
		[Export ("printerPickerControllerWillPresent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresent (UIPrinterPickerController printerPickerController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIPrinterPickerControllerDelegate */
}
