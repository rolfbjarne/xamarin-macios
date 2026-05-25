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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UISearchControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UISearchControllerDelegate", WrapperType = typeof (UISearchControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentSearchController", Selector = "willPresentSearchController:", ParameterType = new Type [] { typeof (UISearchController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPresentSearchController", Selector = "didPresentSearchController:", ParameterType = new Type [] { typeof (UISearchController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDismissSearchController", Selector = "willDismissSearchController:", ParameterType = new Type [] { typeof (UISearchController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismissSearchController", Selector = "didDismissSearchController:", ParameterType = new Type [] { typeof (UISearchController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentSearchController", Selector = "presentSearchController:", ParameterType = new Type [] { typeof (UISearchController) }, ParameterByRef = new bool [] { false })]
	public partial interface IUISearchControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="searchController">To be added.</param><summary>The <paramref name="searchController" /> is about to be presented.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("willPresentSearchController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentSearchController (UISearchController searchController)
		{
			_WillPresentSearchController (this, searchController);
		}
		/// <param name="searchController">To be added.</param><summary>The <paramref name="searchController" /> is about to be presented.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPresentSearchController (IUISearchControllerDelegate This, UISearchController searchController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchController__handle__ = searchController!.GetNonNullHandle (nameof (searchController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("willPresentSearchController:"), searchController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchController);
		}
		/// <param name="searchController">To be added.</param><summary>The <paramref name="searchController" /> was presented.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("didPresentSearchController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPresentSearchController (UISearchController searchController)
		{
			_DidPresentSearchController (this, searchController);
		}
		/// <param name="searchController">To be added.</param><summary>The <paramref name="searchController" /> was presented.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidPresentSearchController (IUISearchControllerDelegate This, UISearchController searchController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchController__handle__ = searchController!.GetNonNullHandle (nameof (searchController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didPresentSearchController:"), searchController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchController);
		}
		/// <param name="searchController">To be added.</param><summary>The <paramref name="searchController" /> is about to be dismissed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("willDismissSearchController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissSearchController (UISearchController searchController)
		{
			_WillDismissSearchController (this, searchController);
		}
		/// <param name="searchController">To be added.</param><summary>The <paramref name="searchController" /> is about to be dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDismissSearchController (IUISearchControllerDelegate This, UISearchController searchController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchController__handle__ = searchController!.GetNonNullHandle (nameof (searchController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("willDismissSearchController:"), searchController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchController);
		}
		/// <param name="searchController">To be added.</param><summary>The <paramref name="searchController" /> was dismissed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("didDismissSearchController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissSearchController (UISearchController searchController)
		{
			_DidDismissSearchController (this, searchController);
		}
		/// <param name="searchController">To be added.</param><summary>The <paramref name="searchController" /> was dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDismissSearchController (IUISearchControllerDelegate This, UISearchController searchController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchController__handle__ = searchController!.GetNonNullHandle (nameof (searchController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didDismissSearchController:"), searchController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchController);
		}
		/// <param name="searchController">To be added.</param><summary>Presents the <paramref name="searchController" /> to the user.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("presentSearchController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentSearchController (UISearchController searchController)
		{
			_PresentSearchController (this, searchController);
		}
		/// <param name="searchController">To be added.</param><summary>Presents the <paramref name="searchController" /> to the user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PresentSearchController (IUISearchControllerDelegate This, UISearchController searchController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchController__handle__ = searchController!.GetNonNullHandle (nameof (searchController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentSearchController:"), searchController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchController);
		}
		[DynamicDependencyAttribute ("DidDismissSearchController(UIKit.UISearchController)")]
		[DynamicDependencyAttribute ("DidPresentSearchController(UIKit.UISearchController)")]
		[DynamicDependencyAttribute ("PresentSearchController(UIKit.UISearchController)")]
		[DynamicDependencyAttribute ("WillDismissSearchController(UIKit.UISearchController)")]
		[DynamicDependencyAttribute ("WillPresentSearchController(UIKit.UISearchController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISearchControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUISearchControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUISearchControllerDelegate" /> interface to support all the methods from the UISearchControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUISearchControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UISearchControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UISearchControllerDelegate_Extensions {
		/// <param name="searchController">To be added.</param><summary>The <paramref name="searchController" /> is about to be presented.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresentSearchController (this IUISearchControllerDelegate This, UISearchController searchController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchController__handle__ = searchController!.GetNonNullHandle (nameof (searchController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("willPresentSearchController:"), searchController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchController);
		}
		/// <param name="searchController">To be added.</param><summary>The <paramref name="searchController" /> was presented.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPresentSearchController (this IUISearchControllerDelegate This, UISearchController searchController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchController__handle__ = searchController!.GetNonNullHandle (nameof (searchController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didPresentSearchController:"), searchController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchController);
		}
		/// <param name="searchController">To be added.</param><summary>The <paramref name="searchController" /> is about to be dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDismissSearchController (this IUISearchControllerDelegate This, UISearchController searchController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchController__handle__ = searchController!.GetNonNullHandle (nameof (searchController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("willDismissSearchController:"), searchController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchController);
		}
		/// <param name="searchController">To be added.</param><summary>The <paramref name="searchController" /> was dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismissSearchController (this IUISearchControllerDelegate This, UISearchController searchController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchController__handle__ = searchController!.GetNonNullHandle (nameof (searchController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didDismissSearchController:"), searchController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchController);
		}
		/// <param name="searchController">To be added.</param><summary>Presents the <paramref name="searchController" /> to the user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PresentSearchController (this IUISearchControllerDelegate This, UISearchController searchController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchController__handle__ = searchController!.GetNonNullHandle (nameof (searchController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentSearchController:"), searchController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchController);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UISearchControllerDelegateWrapper : BaseWrapper, IUISearchControllerDelegate {
		public UISearchControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISearchControllerDelegateWrapper))]
		static UISearchControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUISearchControllerDelegate" /> (for the protocol <c>UISearchControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUISearchControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UISearchControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UISearchControllerDelegate : NSObject, IUISearchControllerDelegate {
		/// <summary>Creates a new <see cref="UISearchControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UISearchControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected UISearchControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal UISearchControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="searchController">To be added.</param><summary>The <paramref name="searchController" /> was dismissed.</summary><remarks>To be added.</remarks>
		[Export ("didDismissSearchController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissSearchController (UISearchController searchController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchController">To be added.</param><summary>The <paramref name="searchController" /> was presented.</summary><remarks>To be added.</remarks>
		[Export ("didPresentSearchController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPresentSearchController (UISearchController searchController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchController">To be added.</param><summary>Presents the <paramref name="searchController" /> to the user.</summary><remarks>To be added.</remarks>
		[Export ("presentSearchController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentSearchController (UISearchController searchController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchController">To be added.</param><summary>The <paramref name="searchController" /> is about to be dismissed.</summary><remarks>To be added.</remarks>
		[Export ("willDismissSearchController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissSearchController (UISearchController searchController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchController">To be added.</param><summary>The <paramref name="searchController" /> is about to be presented.</summary><remarks>To be added.</remarks>
		[Export ("willPresentSearchController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentSearchController (UISearchController searchController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UISearchControllerDelegate */
}
