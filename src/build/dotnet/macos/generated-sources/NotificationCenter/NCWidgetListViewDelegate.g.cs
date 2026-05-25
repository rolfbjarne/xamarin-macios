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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace NotificationCenter {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NCWidgetListViewDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[ObsoletedOSPlatform ("macos11.0")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NCWidgetListViewDelegate", WrapperType = typeof (NCWidgetListViewDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetViewControllerForRow", Selector = "widgetList:viewControllerForRow:", ReturnType = typeof (NSViewController), ParameterType = new Type [] { typeof (NotificationCenter.NCWidgetListViewController), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformAddAction", Selector = "widgetListPerformAddAction:", ParameterType = new Type [] { typeof (NotificationCenter.NCWidgetListViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReorderRow", Selector = "widgetList:shouldReorderRow:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NotificationCenter.NCWidgetListViewController), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReorderRow", Selector = "widgetList:didReorderRow:toRow:", ParameterType = new Type [] { typeof (NotificationCenter.NCWidgetListViewController), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldRemoveRow", Selector = "widgetList:shouldRemoveRow:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NotificationCenter.NCWidgetListViewController), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveRow", Selector = "widgetList:didRemoveRow:", ParameterType = new Type [] { typeof (NotificationCenter.NCWidgetListViewController), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INCWidgetListViewDelegate : INativeObject, IDisposable
	{
		/// <param name="list">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("widgetList:viewControllerForRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSViewController GetViewControllerForRow (NCWidgetListViewController list, nuint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="list">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::AppKit.NSViewController _GetViewControllerForRow (INCWidgetListViewDelegate This, NCWidgetListViewController list, nuint row)
		{
			var list__handle__ = list!.GetNonNullHandle (nameof (list));
			global::AppKit.NSViewController? ret;
			ret =  Runtime.GetNSObject<global::AppKit.NSViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("widgetList:viewControllerForRow:"), list__handle__, row), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (list);
			return ret!;
		}
		/// <param name="list">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("widgetListPerformAddAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformAddAction (NCWidgetListViewController list)
		{
			_PerformAddAction (this, list);
		}
		/// <param name="list">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformAddAction (INCWidgetListViewDelegate This, NCWidgetListViewController list)
		{
			var list__handle__ = list!.GetNonNullHandle (nameof (list));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("widgetListPerformAddAction:"), list__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (list);
		}
		/// <param name="list">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("widgetList:shouldReorderRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReorderRow (NCWidgetListViewController list, nuint row)
		{
			return _ShouldReorderRow (this, list, row);
		}
		/// <param name="list">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldReorderRow (INCWidgetListViewDelegate This, NCWidgetListViewController list, nuint row)
		{
			var list__handle__ = list!.GetNonNullHandle (nameof (list));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("widgetList:shouldReorderRow:"), list__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (list);
			return ret != 0;
		}
		/// <param name="list">To be added.</param><param name="row">To be added.</param><param name="newIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("widgetList:didReorderRow:toRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReorderRow (NCWidgetListViewController list, nuint row, nuint newIndex)
		{
			_DidReorderRow (this, list, row, newIndex);
		}
		/// <param name="list">To be added.</param><param name="row">To be added.</param><param name="newIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReorderRow (INCWidgetListViewDelegate This, NCWidgetListViewController list, nuint row, nuint newIndex)
		{
			var list__handle__ = list!.GetNonNullHandle (nameof (list));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("widgetList:didReorderRow:toRow:"), list__handle__, row, newIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (list);
		}
		/// <param name="list">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("widgetList:shouldRemoveRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRemoveRow (NCWidgetListViewController list, nuint row)
		{
			return _ShouldRemoveRow (this, list, row);
		}
		/// <param name="list">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldRemoveRow (INCWidgetListViewDelegate This, NCWidgetListViewController list, nuint row)
		{
			var list__handle__ = list!.GetNonNullHandle (nameof (list));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("widgetList:shouldRemoveRow:"), list__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (list);
			return ret != 0;
		}
		/// <param name="list">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("widgetList:didRemoveRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveRow (NCWidgetListViewController list, nuint row)
		{
			_DidRemoveRow (this, list, row);
		}
		/// <param name="list">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveRow (INCWidgetListViewDelegate This, NCWidgetListViewController list, nuint row)
		{
			var list__handle__ = list!.GetNonNullHandle (nameof (list));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("widgetList:didRemoveRow:"), list__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (list);
		}
		[DynamicDependencyAttribute ("DidRemoveRow(NotificationCenter.NCWidgetListViewController,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DidReorderRow(NotificationCenter.NCWidgetListViewController,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("GetViewControllerForRow(NotificationCenter.NCWidgetListViewController,System.UIntPtr)")]
		[DynamicDependencyAttribute ("PerformAddAction(NotificationCenter.NCWidgetListViewController)")]
		[DynamicDependencyAttribute ("ShouldRemoveRow(NotificationCenter.NCWidgetListViewController,System.UIntPtr)")]
		[DynamicDependencyAttribute ("ShouldReorderRow(NotificationCenter.NCWidgetListViewController,System.UIntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NCWidgetListViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INCWidgetListViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INCWidgetListViewDelegate" /> interface to support all the methods from the NCWidgetListViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INCWidgetListViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NCWidgetListViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NCWidgetListViewDelegate_Extensions {
		/// <param name="list">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PerformAddAction (this INCWidgetListViewDelegate This, NCWidgetListViewController list)
		{
			var list__handle__ = list!.GetNonNullHandle (nameof (list));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("widgetListPerformAddAction:"), list__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (list);
		}
		/// <param name="list">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldReorderRow (this INCWidgetListViewDelegate This, NCWidgetListViewController list, nuint row)
		{
			var list__handle__ = list!.GetNonNullHandle (nameof (list));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("widgetList:shouldReorderRow:"), list__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (list);
			return ret != 0;
		}
		/// <param name="list">To be added.</param><param name="row">To be added.</param><param name="newIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReorderRow (this INCWidgetListViewDelegate This, NCWidgetListViewController list, nuint row, nuint newIndex)
		{
			var list__handle__ = list!.GetNonNullHandle (nameof (list));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("widgetList:didReorderRow:toRow:"), list__handle__, row, newIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (list);
		}
		/// <param name="list">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldRemoveRow (this INCWidgetListViewDelegate This, NCWidgetListViewController list, nuint row)
		{
			var list__handle__ = list!.GetNonNullHandle (nameof (list));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("widgetList:shouldRemoveRow:"), list__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (list);
			return ret != 0;
		}
		/// <param name="list">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemoveRow (this INCWidgetListViewDelegate This, NCWidgetListViewController list, nuint row)
		{
			var list__handle__ = list!.GetNonNullHandle (nameof (list));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("widgetList:didRemoveRow:"), list__handle__, row);
			GC.KeepAlive (This);
			GC.KeepAlive (list);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NCWidgetListViewDelegateWrapper : BaseWrapper, INCWidgetListViewDelegate {
		public NCWidgetListViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NCWidgetListViewDelegateWrapper))]
		static NCWidgetListViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="list">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("widgetList:viewControllerForRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::AppKit.NSViewController GetViewControllerForRow (NCWidgetListViewController list, nuint row)
		{
			var list__handle__ = list!.GetNonNullHandle (nameof (list));
			global::AppKit.NSViewController? ret;
			ret =  Runtime.GetNSObject<global::AppKit.NSViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("widgetList:viewControllerForRow:"), list__handle__, row), false)!;
			GC.KeepAlive (list);
			return ret!;
		}
	}
}
namespace NotificationCenter {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INCWidgetListViewDelegate" /> (for the protocol <c>NCWidgetListViewDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INCWidgetListViewDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__NotificationCenter_NCWidgetListViewDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("ios")]
	[ObsoletedOSPlatform ("macos11.0")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class NCWidgetListViewDelegate : NSObject, INCWidgetListViewDelegate {
		/// <summary>Creates a new <see cref="NCWidgetListViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NCWidgetListViewDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected NCWidgetListViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal NCWidgetListViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="list">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("widgetList:didRemoveRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveRow (NCWidgetListViewController list, nuint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="list">To be added.</param><param name="row">To be added.</param><param name="newIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("widgetList:didReorderRow:toRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReorderRow (NCWidgetListViewController list, nuint row, nuint newIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="list">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("widgetList:viewControllerForRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSViewController GetViewControllerForRow (NCWidgetListViewController list, nuint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="list">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("widgetListPerformAddAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformAddAction (NCWidgetListViewController list)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="list">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("widgetList:shouldRemoveRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRemoveRow (NCWidgetListViewController list, nuint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="list">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("widgetList:shouldReorderRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReorderRow (NCWidgetListViewController list, nuint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NCWidgetListViewDelegate */
}
