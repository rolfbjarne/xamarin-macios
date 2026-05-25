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
namespace AVKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AVCustomRoutingControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[Protocol (Name = "AVCustomRoutingControllerDelegate", WrapperType = typeof (AVCustomRoutingControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleEvent", Selector = "customRoutingController:handleEvent:completionHandler:", ParameterType = new Type [] { typeof (AVRouting.AVCustomRoutingController), typeof (AVRouting.AVCustomRoutingEvent), typeof (AVKit.AVCustomRoutingControllerDelegateCompletionHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDAVCustomRoutingControllerDelegateCompletionHandler) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EventDidTimeOut", Selector = "customRoutingController:eventDidTimeOut:", ParameterType = new Type [] { typeof (AVRouting.AVCustomRoutingController), typeof (AVRouting.AVCustomRoutingEvent) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectItem", Selector = "customRoutingController:didSelectItem:", ParameterType = new Type [] { typeof (AVRouting.AVCustomRoutingController), typeof (AVRouting.AVCustomRoutingActionItem) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IAVCustomRoutingControllerDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("customRoutingController:handleEvent:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleEvent (global::AVRouting.AVCustomRoutingController controller, global::AVRouting.AVCustomRoutingEvent @event, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVCustomRoutingControllerDelegateCompletionHandler))]AVCustomRoutingControllerDelegateCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleEvent (IAVCustomRoutingControllerDelegate This, global::AVRouting.AVCustomRoutingController controller, global::AVRouting.AVCustomRoutingEvent @event, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVCustomRoutingControllerDelegateCompletionHandler))]AVCustomRoutingControllerDelegateCompletionHandler completionHandler)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAVCustomRoutingControllerDelegateCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("customRoutingController:handleEvent:completionHandler:"), controller__handle__, @event__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (@event);
		}
		[global::Foundation.OptionalMember]
		[Export ("customRoutingController:eventDidTimeOut:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EventDidTimeOut (global::AVRouting.AVCustomRoutingController controller, global::AVRouting.AVCustomRoutingEvent @event)
		{
			_EventDidTimeOut (this, controller, @event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EventDidTimeOut (IAVCustomRoutingControllerDelegate This, global::AVRouting.AVCustomRoutingController controller, global::AVRouting.AVCustomRoutingEvent @event)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("customRoutingController:eventDidTimeOut:"), controller__handle__, @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (@event);
		}
		[global::Foundation.OptionalMember]
		[Export ("customRoutingController:didSelectItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectItem (global::AVRouting.AVCustomRoutingController controller, global::AVRouting.AVCustomRoutingActionItem customActionItem)
		{
			_DidSelectItem (this, controller, customActionItem);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectItem (IAVCustomRoutingControllerDelegate This, global::AVRouting.AVCustomRoutingController controller, global::AVRouting.AVCustomRoutingActionItem customActionItem)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var customActionItem__handle__ = customActionItem!.GetNonNullHandle (nameof (customActionItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("customRoutingController:didSelectItem:"), controller__handle__, customActionItem__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (customActionItem);
		}
		[DynamicDependencyAttribute ("DidSelectItem(AVRouting.AVCustomRoutingController,AVRouting.AVCustomRoutingActionItem)")]
		[DynamicDependencyAttribute ("EventDidTimeOut(AVRouting.AVCustomRoutingController,AVRouting.AVCustomRoutingEvent)")]
		[DynamicDependencyAttribute ("HandleEvent(AVRouting.AVCustomRoutingController,AVRouting.AVCustomRoutingEvent,AVKit.AVCustomRoutingControllerDelegateCompletionHandler)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVCustomRoutingControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVCustomRoutingControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVCustomRoutingControllerDelegate" /> interface to support all the methods from the AVCustomRoutingControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVCustomRoutingControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVCustomRoutingControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVCustomRoutingControllerDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EventDidTimeOut (this IAVCustomRoutingControllerDelegate This, global::AVRouting.AVCustomRoutingController controller, global::AVRouting.AVCustomRoutingEvent @event)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("customRoutingController:eventDidTimeOut:"), controller__handle__, @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (@event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectItem (this IAVCustomRoutingControllerDelegate This, global::AVRouting.AVCustomRoutingController controller, global::AVRouting.AVCustomRoutingActionItem customActionItem)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var customActionItem__handle__ = customActionItem!.GetNonNullHandle (nameof (customActionItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("customRoutingController:didSelectItem:"), controller__handle__, customActionItem__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (customActionItem);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVCustomRoutingControllerDelegateWrapper : BaseWrapper, IAVCustomRoutingControllerDelegate {
		public AVCustomRoutingControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVCustomRoutingControllerDelegateWrapper))]
		static AVCustomRoutingControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("customRoutingController:handleEvent:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleEvent (global::AVRouting.AVCustomRoutingController controller, global::AVRouting.AVCustomRoutingEvent @event, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVCustomRoutingControllerDelegateCompletionHandler))]AVCustomRoutingControllerDelegateCompletionHandler completionHandler)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAVCustomRoutingControllerDelegateCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("customRoutingController:handleEvent:completionHandler:"), controller__handle__, @event__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (controller);
			GC.KeepAlive (@event);
		}
	}
}
namespace AVKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IAVCustomRoutingControllerDelegate" /> (for the protocol <c>AVCustomRoutingControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IAVCustomRoutingControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__AVKit_AVCustomRoutingControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[ObjectiveCFramework ("AVRouting")]
	public unsafe abstract partial class AVCustomRoutingControllerDelegate : NSObject, IAVCustomRoutingControllerDelegate {
		/// <summary>Creates a new <see cref="AVCustomRoutingControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AVCustomRoutingControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected AVCustomRoutingControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVCustomRoutingControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("customRoutingController:didSelectItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectItem (global::AVRouting.AVCustomRoutingController controller, global::AVRouting.AVCustomRoutingActionItem customActionItem)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("customRoutingController:eventDidTimeOut:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EventDidTimeOut (global::AVRouting.AVCustomRoutingController controller, global::AVRouting.AVCustomRoutingEvent @event)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("customRoutingController:handleEvent:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleEvent (global::AVRouting.AVCustomRoutingController controller, global::AVRouting.AVCustomRoutingEvent @event, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVCustomRoutingControllerDelegateCompletionHandler))]AVCustomRoutingControllerDelegateCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVCustomRoutingControllerDelegate */
}
