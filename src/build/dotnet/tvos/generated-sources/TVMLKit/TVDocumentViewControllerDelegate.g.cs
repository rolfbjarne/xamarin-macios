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
namespace TVMLKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>TVDocumentViewControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[ObsoletedOSPlatform ("tvos18.0", "Use SwiftUI or UIKit instead.")]
	[SupportedOSPlatform ("tvos13.0")]
	[Protocol (Name = "TVDocumentViewControllerDelegate", WrapperType = typeof (TVDocumentViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillUpdate", Selector = "documentViewControllerWillUpdate:", ParameterType = new Type [] { typeof (TVMLKit.TVDocumentViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdate", Selector = "documentViewControllerDidUpdate:", ParameterType = new Type [] { typeof (TVMLKit.TVDocumentViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdate", Selector = "documentViewController:didUpdateWithContext:", ParameterType = new Type [] { typeof (TVMLKit.TVDocumentViewController), typeof (global::Foundation.NSDictionary<NSString, NSObject>) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailUpdate", Selector = "documentViewController:didFailUpdateWithError:", ParameterType = new Type [] { typeof (TVMLKit.TVDocumentViewController), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleEvent", Selector = "documentViewController:handleEvent:withElement:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (TVMLKit.TVDocumentViewController), typeof (NSString), typeof (TVMLKit.TVViewElement) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface ITVDocumentViewControllerDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("documentViewControllerWillUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillUpdate (TVDocumentViewController documentViewController)
		{
			_WillUpdate (this, documentViewController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillUpdate (ITVDocumentViewControllerDelegate This, TVDocumentViewController documentViewController)
		{
			var documentViewController__handle__ = documentViewController!.GetNonNullHandle (nameof (documentViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentViewControllerWillUpdate:"), documentViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (documentViewController);
		}
		[global::Foundation.OptionalMember]
		[Export ("documentViewControllerDidUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdate (TVDocumentViewController documentViewController)
		{
			_DidUpdate (this, documentViewController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdate (ITVDocumentViewControllerDelegate This, TVDocumentViewController documentViewController)
		{
			var documentViewController__handle__ = documentViewController!.GetNonNullHandle (nameof (documentViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentViewControllerDidUpdate:"), documentViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (documentViewController);
		}
		[global::Foundation.OptionalMember]
		[Export ("documentViewController:didUpdateWithContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdate (TVDocumentViewController documentViewController, NSDictionary<NSString, NSObject> context)
		{
			_DidUpdate (this, documentViewController, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdate (ITVDocumentViewControllerDelegate This, TVDocumentViewController documentViewController, NSDictionary<NSString, NSObject> context)
		{
			var documentViewController__handle__ = documentViewController!.GetNonNullHandle (nameof (documentViewController));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentViewController:didUpdateWithContext:"), documentViewController__handle__, context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (documentViewController);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("documentViewController:didFailUpdateWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailUpdate (TVDocumentViewController documentViewController, NSError error)
		{
			_DidFailUpdate (this, documentViewController, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailUpdate (ITVDocumentViewControllerDelegate This, TVDocumentViewController documentViewController, NSError error)
		{
			var documentViewController__handle__ = documentViewController!.GetNonNullHandle (nameof (documentViewController));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentViewController:didFailUpdateWithError:"), documentViewController__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (documentViewController);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("documentViewController:handleEvent:withElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HandleEvent (TVDocumentViewController documentViewController, NSString @event, TVViewElement element)
		{
			return _HandleEvent (this, documentViewController, @event, element);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _HandleEvent (ITVDocumentViewControllerDelegate This, TVDocumentViewController documentViewController, NSString @event, TVViewElement element)
		{
			var documentViewController__handle__ = documentViewController!.GetNonNullHandle (nameof (documentViewController));
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentViewController:handleEvent:withElement:"), documentViewController__handle__, @event__handle__, element__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (documentViewController);
			GC.KeepAlive (@event);
			GC.KeepAlive (element);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("DidFailUpdate(TVMLKit.TVDocumentViewController,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidUpdate(TVMLKit.TVDocumentViewController,Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject})")]
		[DynamicDependencyAttribute ("DidUpdate(TVMLKit.TVDocumentViewController)")]
		[DynamicDependencyAttribute ("HandleEvent(TVMLKit.TVDocumentViewController,Foundation.NSString,TVMLKit.TVViewElement)")]
		[DynamicDependencyAttribute ("WillUpdate(TVMLKit.TVDocumentViewController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TVDocumentViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ITVDocumentViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ITVDocumentViewControllerDelegate" /> interface to support all the methods from the TVDocumentViewControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ITVDocumentViewControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original TVDocumentViewControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class TVDocumentViewControllerDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillUpdate (this ITVDocumentViewControllerDelegate This, TVDocumentViewController documentViewController)
		{
			var documentViewController__handle__ = documentViewController!.GetNonNullHandle (nameof (documentViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentViewControllerWillUpdate:"), documentViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (documentViewController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdate (this ITVDocumentViewControllerDelegate This, TVDocumentViewController documentViewController)
		{
			var documentViewController__handle__ = documentViewController!.GetNonNullHandle (nameof (documentViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentViewControllerDidUpdate:"), documentViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (documentViewController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdate (this ITVDocumentViewControllerDelegate This, TVDocumentViewController documentViewController, NSDictionary<NSString, NSObject> context)
		{
			var documentViewController__handle__ = documentViewController!.GetNonNullHandle (nameof (documentViewController));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentViewController:didUpdateWithContext:"), documentViewController__handle__, context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (documentViewController);
			GC.KeepAlive (context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailUpdate (this ITVDocumentViewControllerDelegate This, TVDocumentViewController documentViewController, NSError error)
		{
			var documentViewController__handle__ = documentViewController!.GetNonNullHandle (nameof (documentViewController));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentViewController:didFailUpdateWithError:"), documentViewController__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (documentViewController);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HandleEvent (this ITVDocumentViewControllerDelegate This, TVDocumentViewController documentViewController, NSString @event, TVViewElement element)
		{
			var documentViewController__handle__ = documentViewController!.GetNonNullHandle (nameof (documentViewController));
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentViewController:handleEvent:withElement:"), documentViewController__handle__, @event__handle__, element__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (documentViewController);
			GC.KeepAlive (@event);
			GC.KeepAlive (element);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class TVDocumentViewControllerDelegateWrapper : BaseWrapper, ITVDocumentViewControllerDelegate {
		public TVDocumentViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TVDocumentViewControllerDelegateWrapper))]
		static TVDocumentViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace TVMLKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="ITVDocumentViewControllerDelegate" /> (for the protocol <c>TVDocumentViewControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="ITVDocumentViewControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__TVMLKit_TVDocumentViewControllerDelegate", false)]
	[Model]
	[ObsoletedOSPlatform ("tvos18.0", "Use SwiftUI or UIKit instead.")]
	[SupportedOSPlatform ("tvos13.0")]
	public unsafe partial class TVDocumentViewControllerDelegate : NSObject, ITVDocumentViewControllerDelegate {
		/// <summary>Creates a new <see cref="TVDocumentViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TVDocumentViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected TVDocumentViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal TVDocumentViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("documentViewController:didFailUpdateWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailUpdate (TVDocumentViewController documentViewController, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("documentViewControllerDidUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdate (TVDocumentViewController documentViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("documentViewController:didUpdateWithContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdate (TVDocumentViewController documentViewController, NSDictionary<NSString, NSObject> context)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("documentViewController:handleEvent:withElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HandleEvent (TVDocumentViewController documentViewController, NSString @event, TVViewElement element)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("documentViewControllerWillUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillUpdate (TVDocumentViewController documentViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class TVDocumentViewControllerDelegate */
}
