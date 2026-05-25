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
	/// <summary>This interface represents the Objective-C protocol <c>UILargeContentViewerInteractionDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "UILargeContentViewerInteractionDelegate", WrapperType = typeof (UILargeContentViewerInteractionDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEnd", Selector = "largeContentViewerInteraction:didEndOnItem:atPoint:", ParameterType = new Type [] { typeof (UILargeContentViewerInteraction), typeof (IUILargeContentViewerItem), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetItem", Selector = "largeContentViewerInteraction:itemAtPoint:", ReturnType = typeof (IUILargeContentViewerItem), ParameterType = new Type [] { typeof (UILargeContentViewerInteraction), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetViewController", Selector = "viewControllerForLargeContentViewerInteraction:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (UILargeContentViewerInteraction) }, ParameterByRef = new bool [] { false })]
	public partial interface IUILargeContentViewerInteractionDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("largeContentViewerInteraction:didEndOnItem:atPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnd (UILargeContentViewerInteraction interaction, IUILargeContentViewerItem? item, CGPoint point)
		{
			_DidEnd (this, interaction, item, point);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEnd (IUILargeContentViewerInteractionDelegate This, UILargeContentViewerInteraction interaction, IUILargeContentViewerItem? item, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var item__handle__ = item.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("largeContentViewerInteraction:didEndOnItem:atPoint:"), interaction__handle__, item__handle__, point);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (item);
		}
		[global::Foundation.OptionalMember]
		[Export ("largeContentViewerInteraction:itemAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUILargeContentViewerItem? GetItem (UILargeContentViewerInteraction interaction, CGPoint point)
		{
			return _GetItem (this, interaction, point);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUILargeContentViewerItem? _GetItem (IUILargeContentViewerInteractionDelegate This, UILargeContentViewerInteraction interaction, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			IUILargeContentViewerItem? ret;
			ret =  Runtime.GetINativeObject<IUILargeContentViewerItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("largeContentViewerInteraction:itemAtPoint:"), interaction__handle__, point), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("viewControllerForLargeContentViewerInteraction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetViewController (UILargeContentViewerInteraction interaction)
		{
			return _GetViewController (this, interaction);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIViewController _GetViewController (IUILargeContentViewerInteractionDelegate This, UILargeContentViewerInteraction interaction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("viewControllerForLargeContentViewerInteraction:"), interaction__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			return ret!;
		}
		[DynamicDependencyAttribute ("DidEnd(UIKit.UILargeContentViewerInteraction,UIKit.IUILargeContentViewerItem,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("GetItem(UIKit.UILargeContentViewerInteraction,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("GetViewController(UIKit.UILargeContentViewerInteraction)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UILargeContentViewerInteractionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUILargeContentViewerInteractionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUILargeContentViewerInteractionDelegate" /> interface to support all the methods from the UILargeContentViewerInteractionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUILargeContentViewerInteractionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UILargeContentViewerInteractionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UILargeContentViewerInteractionDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEnd (this IUILargeContentViewerInteractionDelegate This, UILargeContentViewerInteraction interaction, IUILargeContentViewerItem? item, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var item__handle__ = item.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("largeContentViewerInteraction:didEndOnItem:atPoint:"), interaction__handle__, item__handle__, point);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (item);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IUILargeContentViewerItem? GetItem (this IUILargeContentViewerInteractionDelegate This, UILargeContentViewerInteraction interaction, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			IUILargeContentViewerItem? ret;
			ret =  Runtime.GetINativeObject<IUILargeContentViewerItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("largeContentViewerInteraction:itemAtPoint:"), interaction__handle__, point), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIViewController GetViewController (this IUILargeContentViewerInteractionDelegate This, UILargeContentViewerInteraction interaction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("viewControllerForLargeContentViewerInteraction:"), interaction__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UILargeContentViewerInteractionDelegateWrapper : BaseWrapper, IUILargeContentViewerInteractionDelegate {
		public UILargeContentViewerInteractionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UILargeContentViewerInteractionDelegateWrapper))]
		static UILargeContentViewerInteractionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUILargeContentViewerInteractionDelegate" /> (for the protocol <c>UILargeContentViewerInteractionDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUILargeContentViewerInteractionDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UILargeContentViewerInteractionDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class UILargeContentViewerInteractionDelegate : NSObject, IUILargeContentViewerInteractionDelegate {
		/// <summary>Creates a new <see cref="UILargeContentViewerInteractionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UILargeContentViewerInteractionDelegate () : base (NSObjectFlag.Empty)
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
		protected UILargeContentViewerInteractionDelegate (NSObjectFlag t) : base (t)
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
		protected internal UILargeContentViewerInteractionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("largeContentViewerInteraction:didEndOnItem:atPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnd (UILargeContentViewerInteraction interaction, IUILargeContentViewerItem? item, CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("largeContentViewerInteraction:itemAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUILargeContentViewerItem? GetItem (UILargeContentViewerInteraction interaction, CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("viewControllerForLargeContentViewerInteraction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetViewController (UILargeContentViewerInteraction interaction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UILargeContentViewerInteractionDelegate */
}
