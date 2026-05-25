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
namespace ImageKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>IKImageBrowserDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "IKImageBrowserDelegate", WrapperType = typeof (IKImageBrowserDelegateWrapper), IsInformal = true)]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionDidChange", Selector = "imageBrowserSelectionDidChange:", ParameterType = new Type [] { typeof (ImageKit.IKImageBrowserView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CellWasDoubleClicked", Selector = "imageBrowser:cellWasDoubleClickedAtIndex:", ParameterType = new Type [] { typeof (ImageKit.IKImageBrowserView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CellWasRightClicked", Selector = "imageBrowser:cellWasRightClickedAtIndex:withEvent:", ParameterType = new Type [] { typeof (ImageKit.IKImageBrowserView), typeof (IntPtr), typeof (NSEvent) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "BackgroundWasRightClicked", Selector = "imageBrowser:backgroundWasRightClickedWithEvent:", ParameterType = new Type [] { typeof (ImageKit.IKImageBrowserView), typeof (NSEvent) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IIKImageBrowserDelegate : INativeObject, IDisposable
	{
		/// <param name="browser">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("imageBrowserSelectionDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionDidChange (IKImageBrowserView browser)
		{
			_SelectionDidChange (this, browser);
		}
		/// <param name="browser">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectionDidChange (IIKImageBrowserDelegate This, IKImageBrowserView browser)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("imageBrowserSelectionDidChange:"), browser__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
		}
		/// <param name="browser">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("imageBrowser:cellWasDoubleClickedAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CellWasDoubleClicked (IKImageBrowserView browser, nint index)
		{
			_CellWasDoubleClicked (this, browser, index);
		}
		/// <param name="browser">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CellWasDoubleClicked (IIKImageBrowserDelegate This, IKImageBrowserView browser, nint index)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("imageBrowser:cellWasDoubleClickedAtIndex:"), browser__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
		}
		/// <param name="browser">To be added.</param><param name="index">To be added.</param><param name="nsevent">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("imageBrowser:cellWasRightClickedAtIndex:withEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CellWasRightClicked (IKImageBrowserView browser, nint index, global::AppKit.NSEvent nsevent)
		{
			_CellWasRightClicked (this, browser, index, nsevent);
		}
		/// <param name="browser">To be added.</param><param name="index">To be added.</param><param name="nsevent">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CellWasRightClicked (IIKImageBrowserDelegate This, IKImageBrowserView browser, nint index, global::AppKit.NSEvent nsevent)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var nsevent__handle__ = nsevent!.GetNonNullHandle (nameof (nsevent));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("imageBrowser:cellWasRightClickedAtIndex:withEvent:"), browser__handle__, index, nsevent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (nsevent);
		}
		/// <param name="browser">To be added.</param><param name="nsevent">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("imageBrowser:backgroundWasRightClickedWithEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BackgroundWasRightClicked (IKImageBrowserView browser, global::AppKit.NSEvent nsevent)
		{
			_BackgroundWasRightClicked (this, browser, nsevent);
		}
		/// <param name="browser">To be added.</param><param name="nsevent">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BackgroundWasRightClicked (IIKImageBrowserDelegate This, IKImageBrowserView browser, global::AppKit.NSEvent nsevent)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var nsevent__handle__ = nsevent!.GetNonNullHandle (nameof (nsevent));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("imageBrowser:backgroundWasRightClickedWithEvent:"), browser__handle__, nsevent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (nsevent);
		}
		[DynamicDependencyAttribute ("BackgroundWasRightClicked(ImageKit.IKImageBrowserView,AppKit.NSEvent)")]
		[DynamicDependencyAttribute ("CellWasDoubleClicked(ImageKit.IKImageBrowserView,System.IntPtr)")]
		[DynamicDependencyAttribute ("CellWasRightClicked(ImageKit.IKImageBrowserView,System.IntPtr,AppKit.NSEvent)")]
		[DynamicDependencyAttribute ("SelectionDidChange(ImageKit.IKImageBrowserView)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (IKImageBrowserDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IIKImageBrowserDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IIKImageBrowserDelegate" /> interface to support all the methods from the IKImageBrowserDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IIKImageBrowserDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original IKImageBrowserDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class IKImageBrowserDelegate_Extensions {
		/// <param name="browser">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SelectionDidChange (this IIKImageBrowserDelegate This, IKImageBrowserView browser)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("imageBrowserSelectionDidChange:"), browser__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
		}
		/// <param name="browser">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CellWasDoubleClicked (this IIKImageBrowserDelegate This, IKImageBrowserView browser, nint index)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("imageBrowser:cellWasDoubleClickedAtIndex:"), browser__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
		}
		/// <param name="browser">To be added.</param><param name="index">To be added.</param><param name="nsevent">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CellWasRightClicked (this IIKImageBrowserDelegate This, IKImageBrowserView browser, nint index, global::AppKit.NSEvent nsevent)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var nsevent__handle__ = nsevent!.GetNonNullHandle (nameof (nsevent));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("imageBrowser:cellWasRightClickedAtIndex:withEvent:"), browser__handle__, index, nsevent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (nsevent);
		}
		/// <param name="browser">To be added.</param><param name="nsevent">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void BackgroundWasRightClicked (this IIKImageBrowserDelegate This, IKImageBrowserView browser, global::AppKit.NSEvent nsevent)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var nsevent__handle__ = nsevent!.GetNonNullHandle (nameof (nsevent));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("imageBrowser:backgroundWasRightClickedWithEvent:"), browser__handle__, nsevent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (nsevent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class IKImageBrowserDelegateWrapper : BaseWrapper, IIKImageBrowserDelegate {
		public IKImageBrowserDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (IKImageBrowserDelegateWrapper))]
		static IKImageBrowserDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace ImageKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IIKImageBrowserDelegate" /> (for the protocol <c>IKImageBrowserDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IIKImageBrowserDelegate" />.</para>
	/// </summary>
	[Protocol(IsInformal = true)]
	[Register("Microsoft_macOS__ImageKit_IKImageBrowserDelegate", false)]
	[Model]
	public unsafe partial class IKImageBrowserDelegate : NSObject, IIKImageBrowserDelegate {
		/// <summary>Creates a new <see cref="IKImageBrowserDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public IKImageBrowserDelegate () : base (NSObjectFlag.Empty)
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
		protected IKImageBrowserDelegate (NSObjectFlag t) : base (t)
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
		protected internal IKImageBrowserDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="browser">To be added.</param><param name="nsevent">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("imageBrowser:backgroundWasRightClickedWithEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BackgroundWasRightClicked (IKImageBrowserView browser, global::AppKit.NSEvent nsevent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("imageBrowser:cellWasDoubleClickedAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CellWasDoubleClicked (IKImageBrowserView browser, nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="index">To be added.</param><param name="nsevent">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("imageBrowser:cellWasRightClickedAtIndex:withEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CellWasRightClicked (IKImageBrowserView browser, nint index, global::AppKit.NSEvent nsevent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("imageBrowserSelectionDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionDidChange (IKImageBrowserView browser)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class IKImageBrowserDelegate */
}
