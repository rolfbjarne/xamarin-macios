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
	/// <summary>This interface represents the Objective-C protocol <c>NSTextViewportLayoutControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "NSTextViewportLayoutControllerDelegate", WrapperType = typeof (NSTextViewportLayoutControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetViewportBounds", Selector = "viewportBoundsForTextViewportLayoutController:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (NSTextViewportLayoutController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConfigureRenderingSurface", Selector = "textViewportLayoutController:configureRenderingSurfaceForTextLayoutFragment:", ParameterType = new Type [] { typeof (NSTextViewportLayoutController), typeof (NSTextLayoutFragment) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillLayout", Selector = "textViewportLayoutControllerWillLayout:", ParameterType = new Type [] { typeof (NSTextViewportLayoutController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidLayout", Selector = "textViewportLayoutControllerDidLayout:", ParameterType = new Type [] { typeof (NSTextViewportLayoutController) }, ParameterByRef = new bool [] { false })]
	public partial interface INSTextViewportLayoutControllerDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("viewportBoundsForTextViewportLayoutController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetViewportBounds (NSTextViewportLayoutController textViewportLayoutController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetViewportBounds (INSTextViewportLayoutControllerDelegate This, NSTextViewportLayoutController textViewportLayoutController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textViewportLayoutController__handle__ = textViewportLayoutController!.GetNonNullHandle (nameof (textViewportLayoutController));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("viewportBoundsForTextViewportLayoutController:"), textViewportLayoutController__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("viewportBoundsForTextViewportLayoutController:"), textViewportLayoutController__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (textViewportLayoutController);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("textViewportLayoutController:configureRenderingSurfaceForTextLayoutFragment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConfigureRenderingSurface (NSTextViewportLayoutController textViewportLayoutController, NSTextLayoutFragment textLayoutFragment)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ConfigureRenderingSurface (INSTextViewportLayoutControllerDelegate This, NSTextViewportLayoutController textViewportLayoutController, NSTextLayoutFragment textLayoutFragment)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textViewportLayoutController__handle__ = textViewportLayoutController!.GetNonNullHandle (nameof (textViewportLayoutController));
			var textLayoutFragment__handle__ = textLayoutFragment!.GetNonNullHandle (nameof (textLayoutFragment));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textViewportLayoutController:configureRenderingSurfaceForTextLayoutFragment:"), textViewportLayoutController__handle__, textLayoutFragment__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textViewportLayoutController);
			GC.KeepAlive (textLayoutFragment);
		}
		[global::Foundation.OptionalMember]
		[Export ("textViewportLayoutControllerWillLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillLayout (NSTextViewportLayoutController textViewportLayoutController)
		{
			_WillLayout (this, textViewportLayoutController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillLayout (INSTextViewportLayoutControllerDelegate This, NSTextViewportLayoutController textViewportLayoutController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textViewportLayoutController__handle__ = textViewportLayoutController!.GetNonNullHandle (nameof (textViewportLayoutController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewportLayoutControllerWillLayout:"), textViewportLayoutController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textViewportLayoutController);
		}
		[global::Foundation.OptionalMember]
		[Export ("textViewportLayoutControllerDidLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLayout (NSTextViewportLayoutController textViewportLayoutController)
		{
			_DidLayout (this, textViewportLayoutController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidLayout (INSTextViewportLayoutControllerDelegate This, NSTextViewportLayoutController textViewportLayoutController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textViewportLayoutController__handle__ = textViewportLayoutController!.GetNonNullHandle (nameof (textViewportLayoutController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewportLayoutControllerDidLayout:"), textViewportLayoutController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textViewportLayoutController);
		}
		[DynamicDependencyAttribute ("ConfigureRenderingSurface(UIKit.NSTextViewportLayoutController,UIKit.NSTextLayoutFragment)")]
		[DynamicDependencyAttribute ("DidLayout(UIKit.NSTextViewportLayoutController)")]
		[DynamicDependencyAttribute ("GetViewportBounds(UIKit.NSTextViewportLayoutController)")]
		[DynamicDependencyAttribute ("WillLayout(UIKit.NSTextViewportLayoutController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextViewportLayoutControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTextViewportLayoutControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSTextViewportLayoutControllerDelegate" /> interface to support all the methods from the NSTextViewportLayoutControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSTextViewportLayoutControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSTextViewportLayoutControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSTextViewportLayoutControllerDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillLayout (this INSTextViewportLayoutControllerDelegate This, NSTextViewportLayoutController textViewportLayoutController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textViewportLayoutController__handle__ = textViewportLayoutController!.GetNonNullHandle (nameof (textViewportLayoutController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewportLayoutControllerWillLayout:"), textViewportLayoutController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textViewportLayoutController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidLayout (this INSTextViewportLayoutControllerDelegate This, NSTextViewportLayoutController textViewportLayoutController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textViewportLayoutController__handle__ = textViewportLayoutController!.GetNonNullHandle (nameof (textViewportLayoutController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewportLayoutControllerDidLayout:"), textViewportLayoutController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textViewportLayoutController);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTextViewportLayoutControllerDelegateWrapper : BaseWrapper, INSTextViewportLayoutControllerDelegate {
		public NSTextViewportLayoutControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextViewportLayoutControllerDelegateWrapper))]
		static NSTextViewportLayoutControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("viewportBoundsForTextViewportLayoutController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetViewportBounds (NSTextViewportLayoutController textViewportLayoutController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textViewportLayoutController__handle__ = textViewportLayoutController!.GetNonNullHandle (nameof (textViewportLayoutController));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("viewportBoundsForTextViewportLayoutController:"), textViewportLayoutController__handle__);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("viewportBoundsForTextViewportLayoutController:"), textViewportLayoutController__handle__);
			}
			GC.KeepAlive (textViewportLayoutController);
			return ret!;
		}
		[Export ("textViewportLayoutController:configureRenderingSurfaceForTextLayoutFragment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ConfigureRenderingSurface (NSTextViewportLayoutController textViewportLayoutController, NSTextLayoutFragment textLayoutFragment)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textViewportLayoutController__handle__ = textViewportLayoutController!.GetNonNullHandle (nameof (textViewportLayoutController));
			var textLayoutFragment__handle__ = textLayoutFragment!.GetNonNullHandle (nameof (textLayoutFragment));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textViewportLayoutController:configureRenderingSurfaceForTextLayoutFragment:"), textViewportLayoutController__handle__, textLayoutFragment__handle__);
			GC.KeepAlive (textViewportLayoutController);
			GC.KeepAlive (textLayoutFragment);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSTextViewportLayoutControllerDelegate" /> (for the protocol <c>NSTextViewportLayoutControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSTextViewportLayoutControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_NSTextViewportLayoutControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe abstract partial class NSTextViewportLayoutControllerDelegate : NSObject, INSTextViewportLayoutControllerDelegate {
		/// <summary>Creates a new <see cref="NSTextViewportLayoutControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NSTextViewportLayoutControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected NSTextViewportLayoutControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSTextViewportLayoutControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("textViewportLayoutController:configureRenderingSurfaceForTextLayoutFragment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConfigureRenderingSurface (NSTextViewportLayoutController textViewportLayoutController, NSTextLayoutFragment textLayoutFragment)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textViewportLayoutControllerDidLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLayout (NSTextViewportLayoutController textViewportLayoutController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("viewportBoundsForTextViewportLayoutController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetViewportBounds (NSTextViewportLayoutController textViewportLayoutController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textViewportLayoutControllerWillLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillLayout (NSTextViewportLayoutController textViewportLayoutController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSTextViewportLayoutControllerDelegate */
}
