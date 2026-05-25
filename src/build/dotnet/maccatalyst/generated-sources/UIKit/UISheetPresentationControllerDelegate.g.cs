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
	/// <summary>This interface represents the Objective-C protocol <c>UISheetPresentationControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "UISheetPresentationControllerDelegate", WrapperType = typeof (UISheetPresentationControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeSelectedDetentIdentifier", Selector = "sheetPresentationControllerDidChangeSelectedDetentIdentifier:", ParameterType = new Type [] { typeof (UISheetPresentationController) }, ParameterByRef = new bool [] { false })]
	public partial interface IUISheetPresentationControllerDelegate : INativeObject, IDisposable, 
		UIKit.IUIAdaptivePresentationControllerDelegate
	{
		[global::Foundation.OptionalMember]
		[Export ("sheetPresentationControllerDidChangeSelectedDetentIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeSelectedDetentIdentifier (UISheetPresentationController sheetPresentationController)
		{
			_DidChangeSelectedDetentIdentifier (this, sheetPresentationController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeSelectedDetentIdentifier (IUISheetPresentationControllerDelegate This, UISheetPresentationController sheetPresentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sheetPresentationController__handle__ = sheetPresentationController!.GetNonNullHandle (nameof (sheetPresentationController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sheetPresentationControllerDidChangeSelectedDetentIdentifier:"), sheetPresentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sheetPresentationController);
		}
		[DynamicDependencyAttribute ("DidChangeSelectedDetentIdentifier(UIKit.UISheetPresentationController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISheetPresentationControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUISheetPresentationControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUISheetPresentationControllerDelegate" /> interface to support all the methods from the UISheetPresentationControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUISheetPresentationControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UISheetPresentationControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UISheetPresentationControllerDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeSelectedDetentIdentifier (this IUISheetPresentationControllerDelegate This, UISheetPresentationController sheetPresentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sheetPresentationController__handle__ = sheetPresentationController!.GetNonNullHandle (nameof (sheetPresentationController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sheetPresentationControllerDidChangeSelectedDetentIdentifier:"), sheetPresentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sheetPresentationController);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UISheetPresentationControllerDelegateWrapper : BaseWrapper, IUISheetPresentationControllerDelegate {
		public UISheetPresentationControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISheetPresentationControllerDelegateWrapper))]
		static UISheetPresentationControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUISheetPresentationControllerDelegate" /> (for the protocol <c>UISheetPresentationControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUISheetPresentationControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UISheetPresentationControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class UISheetPresentationControllerDelegate : NSObject, IUISheetPresentationControllerDelegate, IUIAdaptivePresentationControllerDelegate {
		/// <summary>Creates a new <see cref="UISheetPresentationControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UISheetPresentationControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected UISheetPresentationControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal UISheetPresentationControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("presentationControllerDidAttemptToDismiss:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAttemptToDismiss (UIPresentationController presentationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sheetPresentationControllerDidChangeSelectedDetentIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeSelectedDetentIdentifier (UISheetPresentationController sheetPresentationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("presentationControllerDidDismiss:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismiss (UIPresentationController presentationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="forPresentationController">To be added.</param><summary>Returns the new presentation style to use after a change to the <paramref name="forPresentationController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("adaptivePresentationStyleForPresentationController:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIModalPresentationStyle GetAdaptivePresentationStyle (UIPresentationController forPresentationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="traitCollection">To be added.</param><summary>The presentation style to use for the specified <paramref name="controller" /> and <paramref name="traitCollection" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("adaptivePresentationStyleForPresentationController:traitCollection:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIModalPresentationStyle GetAdaptivePresentationStyle (UIPresentationController controller, UITraitCollection traitCollection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="style">To be added.</param><summary>The view controller to use for the specified <paramref name="style" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("presentationController:viewControllerForAdaptivePresentationStyle:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetViewControllerForAdaptivePresentation (UIPresentationController controller, UIModalPresentationStyle style)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("presentationController:prepareAdaptivePresentationController:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareAdaptivePresentationController (UIPresentationController presentationController, UIPresentationController adaptivePresentationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("presentationControllerShouldDismiss:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDismiss (UIPresentationController presentationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("presentationControllerWillDismiss:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismiss (UIPresentationController presentationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="presentationController">To be added.</param><param name="style">To be added.</param><param name="transitionCoordinator">To be added.</param><summary>Called prior to presentation.</summary><remarks>To be added.</remarks>
		[Export ("presentationController:willPresentWithAdaptiveStyle:transitionCoordinator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresent (UIPresentationController presentationController, UIModalPresentationStyle style, IUIViewControllerTransitionCoordinator? transitionCoordinator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UISheetPresentationControllerDelegate */
}
