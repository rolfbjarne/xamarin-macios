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
namespace AppKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSPathControlDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSPathControlDelegate", WrapperType = typeof (NSPathControlDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldDragPathComponentCell", Selector = "pathControl:shouldDragPathComponentCell:withPasteboard:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSPathControl), typeof (NSPathComponentCell), typeof (NSPasteboard) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateDrop", Selector = "pathControl:validateDrop:", ReturnType = typeof (NSDragOperation), ParameterType = new Type [] { typeof (NSPathControl), typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AcceptDrop", Selector = "pathControl:acceptDrop:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSPathControl), typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayOpenPanel", Selector = "pathControl:willDisplayOpenPanel:", ParameterType = new Type [] { typeof (NSPathControl), typeof (NSOpenPanel) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPopUpMenu", Selector = "pathControl:willPopUpMenu:", ParameterType = new Type [] { typeof (NSPathControl), typeof (NSMenu) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldDragItem", Selector = "pathControl:shouldDragItem:withPasteboard:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSPathControl), typeof (NSPathControlItem), typeof (NSPasteboard) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface INSPathControlDelegate : INativeObject, IDisposable
	{
		/// <param name="pathControl">To be added.</param><param name="pathComponentCell">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pathControl:shouldDragPathComponentCell:withPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDragPathComponentCell (NSPathControl pathControl, NSPathComponentCell pathComponentCell, NSPasteboard pasteboard)
		{
			return _ShouldDragPathComponentCell (this, pathControl, pathComponentCell, pasteboard);
		}
		/// <param name="pathControl">To be added.</param><param name="pathComponentCell">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldDragPathComponentCell (INSPathControlDelegate This, NSPathControl pathControl, NSPathComponentCell pathComponentCell, NSPasteboard pasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pathControl__handle__ = pathControl!.GetNonNullHandle (nameof (pathControl));
			var pathComponentCell__handle__ = pathComponentCell!.GetNonNullHandle (nameof (pathComponentCell));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pathControl:shouldDragPathComponentCell:withPasteboard:"), pathControl__handle__, pathComponentCell__handle__, pasteboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pathControl);
			GC.KeepAlive (pathComponentCell);
			GC.KeepAlive (pasteboard);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("pathControl:validateDrop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDragOperation ValidateDrop (NSPathControl pathControl, INSDraggingInfo info)
		{
			return _ValidateDrop (this, pathControl, info);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDragOperation _ValidateDrop (INSPathControlDelegate This, NSPathControl pathControl, INSDraggingInfo info)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pathControl__handle__ = pathControl!.GetNonNullHandle (nameof (pathControl));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			NSDragOperation ret;
			ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pathControl:validateDrop:"), pathControl__handle__, info__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pathControl);
			GC.KeepAlive (info);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("pathControl:acceptDrop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AcceptDrop (NSPathControl pathControl, INSDraggingInfo info)
		{
			return _AcceptDrop (this, pathControl, info);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AcceptDrop (INSPathControlDelegate This, NSPathControl pathControl, INSDraggingInfo info)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pathControl__handle__ = pathControl!.GetNonNullHandle (nameof (pathControl));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pathControl:acceptDrop:"), pathControl__handle__, info__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pathControl);
			GC.KeepAlive (info);
			return ret != 0;
		}
		/// <param name="pathControl">To be added.</param><param name="openPanel">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pathControl:willDisplayOpenPanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayOpenPanel (NSPathControl pathControl, NSOpenPanel openPanel)
		{
			_WillDisplayOpenPanel (this, pathControl, openPanel);
		}
		/// <param name="pathControl">To be added.</param><param name="openPanel">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDisplayOpenPanel (INSPathControlDelegate This, NSPathControl pathControl, NSOpenPanel openPanel)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pathControl__handle__ = pathControl!.GetNonNullHandle (nameof (pathControl));
			var openPanel__handle__ = openPanel!.GetNonNullHandle (nameof (openPanel));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pathControl:willDisplayOpenPanel:"), pathControl__handle__, openPanel__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pathControl);
			GC.KeepAlive (openPanel);
		}
		/// <param name="pathControl">To be added.</param><param name="menu">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pathControl:willPopUpMenu:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPopUpMenu (NSPathControl pathControl, NSMenu menu)
		{
			_WillPopUpMenu (this, pathControl, menu);
		}
		/// <param name="pathControl">To be added.</param><param name="menu">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPopUpMenu (INSPathControlDelegate This, NSPathControl pathControl, NSMenu menu)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pathControl__handle__ = pathControl!.GetNonNullHandle (nameof (pathControl));
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pathControl:willPopUpMenu:"), pathControl__handle__, menu__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pathControl);
			GC.KeepAlive (menu);
		}
		/// <param name="pathControl">To be added.</param><param name="pathItem">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pathControl:shouldDragItem:withPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDragItem (NSPathControl pathControl, NSPathControlItem pathItem, NSPasteboard pasteboard)
		{
			return _ShouldDragItem (this, pathControl, pathItem, pasteboard);
		}
		/// <param name="pathControl">To be added.</param><param name="pathItem">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldDragItem (INSPathControlDelegate This, NSPathControl pathControl, NSPathControlItem pathItem, NSPasteboard pasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pathControl__handle__ = pathControl!.GetNonNullHandle (nameof (pathControl));
			var pathItem__handle__ = pathItem!.GetNonNullHandle (nameof (pathItem));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pathControl:shouldDragItem:withPasteboard:"), pathControl__handle__, pathItem__handle__, pasteboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pathControl);
			GC.KeepAlive (pathItem);
			GC.KeepAlive (pasteboard);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("AcceptDrop(AppKit.NSPathControl,AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute ("ShouldDragItem(AppKit.NSPathControl,AppKit.NSPathControlItem,AppKit.NSPasteboard)")]
		[DynamicDependencyAttribute ("ShouldDragPathComponentCell(AppKit.NSPathControl,AppKit.NSPathComponentCell,AppKit.NSPasteboard)")]
		[DynamicDependencyAttribute ("ValidateDrop(AppKit.NSPathControl,AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute ("WillDisplayOpenPanel(AppKit.NSPathControl,AppKit.NSOpenPanel)")]
		[DynamicDependencyAttribute ("WillPopUpMenu(AppKit.NSPathControl,AppKit.NSMenu)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSPathControlDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSPathControlDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSPathControlDelegate" /> interface to support all the methods from the NSPathControlDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSPathControlDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSPathControlDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSPathControlDelegate_Extensions {
		/// <param name="pathControl">To be added.</param><param name="pathComponentCell">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldDragPathComponentCell (this INSPathControlDelegate This, NSPathControl pathControl, NSPathComponentCell pathComponentCell, NSPasteboard pasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pathControl__handle__ = pathControl!.GetNonNullHandle (nameof (pathControl));
			var pathComponentCell__handle__ = pathComponentCell!.GetNonNullHandle (nameof (pathComponentCell));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pathControl:shouldDragPathComponentCell:withPasteboard:"), pathControl__handle__, pathComponentCell__handle__, pasteboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pathControl);
			GC.KeepAlive (pathComponentCell);
			GC.KeepAlive (pasteboard);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDragOperation ValidateDrop (this INSPathControlDelegate This, NSPathControl pathControl, INSDraggingInfo info)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pathControl__handle__ = pathControl!.GetNonNullHandle (nameof (pathControl));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			NSDragOperation ret;
			ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pathControl:validateDrop:"), pathControl__handle__, info__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pathControl);
			GC.KeepAlive (info);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AcceptDrop (this INSPathControlDelegate This, NSPathControl pathControl, INSDraggingInfo info)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pathControl__handle__ = pathControl!.GetNonNullHandle (nameof (pathControl));
			var info__handle__ = info!.GetNonNullHandle (nameof (info));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pathControl:acceptDrop:"), pathControl__handle__, info__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pathControl);
			GC.KeepAlive (info);
			return ret != 0;
		}
		/// <param name="pathControl">To be added.</param><param name="openPanel">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDisplayOpenPanel (this INSPathControlDelegate This, NSPathControl pathControl, NSOpenPanel openPanel)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pathControl__handle__ = pathControl!.GetNonNullHandle (nameof (pathControl));
			var openPanel__handle__ = openPanel!.GetNonNullHandle (nameof (openPanel));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pathControl:willDisplayOpenPanel:"), pathControl__handle__, openPanel__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pathControl);
			GC.KeepAlive (openPanel);
		}
		/// <param name="pathControl">To be added.</param><param name="menu">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPopUpMenu (this INSPathControlDelegate This, NSPathControl pathControl, NSMenu menu)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pathControl__handle__ = pathControl!.GetNonNullHandle (nameof (pathControl));
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pathControl:willPopUpMenu:"), pathControl__handle__, menu__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pathControl);
			GC.KeepAlive (menu);
		}
		/// <param name="pathControl">To be added.</param><param name="pathItem">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldDragItem (this INSPathControlDelegate This, NSPathControl pathControl, NSPathControlItem pathItem, NSPasteboard pasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pathControl__handle__ = pathControl!.GetNonNullHandle (nameof (pathControl));
			var pathItem__handle__ = pathItem!.GetNonNullHandle (nameof (pathItem));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pathControl:shouldDragItem:withPasteboard:"), pathControl__handle__, pathItem__handle__, pasteboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pathControl);
			GC.KeepAlive (pathItem);
			GC.KeepAlive (pasteboard);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSPathControlDelegateWrapper : BaseWrapper, INSPathControlDelegate {
		public NSPathControlDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSPathControlDelegateWrapper))]
		static NSPathControlDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSPathControlDelegate" /> (for the protocol <c>NSPathControlDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSPathControlDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSPathControlDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSPathControlDelegate : NSObject, INSPathControlDelegate {
		/// <summary>Creates a new <see cref="NSPathControlDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSPathControlDelegate () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		protected NSPathControlDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSPathControlDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("pathControl:acceptDrop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AcceptDrop (NSPathControl pathControl, INSDraggingInfo info)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pathControl">To be added.</param><param name="pathItem">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pathControl:shouldDragItem:withPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDragItem (NSPathControl pathControl, NSPathControlItem pathItem, NSPasteboard pasteboard)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pathControl">To be added.</param><param name="pathComponentCell">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pathControl:shouldDragPathComponentCell:withPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDragPathComponentCell (NSPathControl pathControl, NSPathComponentCell pathComponentCell, NSPasteboard pasteboard)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("pathControl:validateDrop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDragOperation ValidateDrop (NSPathControl pathControl, INSDraggingInfo info)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pathControl">To be added.</param><param name="openPanel">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("pathControl:willDisplayOpenPanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayOpenPanel (NSPathControl pathControl, NSOpenPanel openPanel)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pathControl">To be added.</param><param name="menu">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("pathControl:willPopUpMenu:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPopUpMenu (NSPathControl pathControl, NSMenu menu)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSPathControlDelegate */
}
