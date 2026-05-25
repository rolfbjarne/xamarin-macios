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
namespace QuickLookUI {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>QLPreviewPanelDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "QLPreviewPanelDelegate", WrapperType = typeof (QLPreviewPanelDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleEvent", Selector = "previewPanel:handleEvent:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (QuickLookUI.QLPreviewPanel), typeof (NSEvent) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SourceFrameOnScreenForPreviewItem", Selector = "previewPanel:sourceFrameOnScreenForPreviewItem:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (QuickLookUI.QLPreviewPanel), typeof (QuickLookUI.IQLPreviewItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TransitionImageForPreviewItem", Selector = "previewPanel:transitionImageForPreviewItem:contentRect:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (QuickLookUI.QLPreviewPanel), typeof (QuickLookUI.IQLPreviewItem), typeof (CGRect) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IQLPreviewPanelDelegate : INativeObject, IDisposable, 
		AppKit.INSWindowDelegate
	{
		/// <param name="panel">To be added.</param><param name="theEvent">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("previewPanel:handleEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HandleEvent (QLPreviewPanel panel, global::AppKit.NSEvent theEvent)
		{
			return _HandleEvent (this, panel, theEvent);
		}
		/// <param name="panel">To be added.</param><param name="theEvent">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _HandleEvent (IQLPreviewPanelDelegate This, QLPreviewPanel panel, global::AppKit.NSEvent theEvent)
		{
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("previewPanel:handleEvent:"), panel__handle__, theEvent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			GC.KeepAlive (theEvent);
			return ret != 0;
		}
		/// <param name="panel">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("previewPanel:sourceFrameOnScreenForPreviewItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect SourceFrameOnScreenForPreviewItem (QLPreviewPanel panel, IQLPreviewItem item)
		{
			return _SourceFrameOnScreenForPreviewItem (this, panel, item);
		}
		/// <param name="panel">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _SourceFrameOnScreenForPreviewItem (IQLPreviewPanelDelegate This, QLPreviewPanel panel, IQLPreviewItem item)
		{
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("previewPanel:sourceFrameOnScreenForPreviewItem:"), panel__handle__, item__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("previewPanel:sourceFrameOnScreenForPreviewItem:"), panel__handle__, item__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (panel);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="panel">To be added.</param><param name="item">To be added.</param><param name="contentRect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("previewPanel:transitionImageForPreviewItem:contentRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject TransitionImageForPreviewItem (QLPreviewPanel panel, IQLPreviewItem item, CGRect contentRect)
		{
			return _TransitionImageForPreviewItem (this, panel, item, contentRect);
		}
		/// <param name="panel">To be added.</param><param name="item">To be added.</param><param name="contentRect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _TransitionImageForPreviewItem (IQLPreviewPanelDelegate This, QLPreviewPanel panel, IQLPreviewItem item, CGRect contentRect)
		{
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("previewPanel:transitionImageForPreviewItem:contentRect:"), panel__handle__, item__handle__, contentRect), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			GC.KeepAlive (item);
			return ret!;
		}
		[DynamicDependencyAttribute ("HandleEvent(QuickLookUI.QLPreviewPanel,AppKit.NSEvent)")]
		[DynamicDependencyAttribute ("SourceFrameOnScreenForPreviewItem(QuickLookUI.QLPreviewPanel,QuickLookUI.IQLPreviewItem)")]
		[DynamicDependencyAttribute ("TransitionImageForPreviewItem(QuickLookUI.QLPreviewPanel,QuickLookUI.IQLPreviewItem,CoreGraphics.CGRect)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (QLPreviewPanelDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IQLPreviewPanelDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IQLPreviewPanelDelegate" /> interface to support all the methods from the QLPreviewPanelDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IQLPreviewPanelDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original QLPreviewPanelDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class QLPreviewPanelDelegate_Extensions {
		/// <param name="panel">To be added.</param><param name="theEvent">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HandleEvent (this IQLPreviewPanelDelegate This, QLPreviewPanel panel, global::AppKit.NSEvent theEvent)
		{
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("previewPanel:handleEvent:"), panel__handle__, theEvent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			GC.KeepAlive (theEvent);
			return ret != 0;
		}
		/// <param name="panel">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect SourceFrameOnScreenForPreviewItem (this IQLPreviewPanelDelegate This, QLPreviewPanel panel, IQLPreviewItem item)
		{
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("previewPanel:sourceFrameOnScreenForPreviewItem:"), panel__handle__, item__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("previewPanel:sourceFrameOnScreenForPreviewItem:"), panel__handle__, item__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (panel);
			GC.KeepAlive (item);
			return ret!;
		}
		/// <param name="panel">To be added.</param><param name="item">To be added.</param><param name="contentRect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject TransitionImageForPreviewItem (this IQLPreviewPanelDelegate This, QLPreviewPanel panel, IQLPreviewItem item, CGRect contentRect)
		{
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("previewPanel:transitionImageForPreviewItem:contentRect:"), panel__handle__, item__handle__, contentRect), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			GC.KeepAlive (item);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class QLPreviewPanelDelegateWrapper : BaseWrapper, IQLPreviewPanelDelegate {
		public QLPreviewPanelDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (QLPreviewPanelDelegateWrapper))]
		static QLPreviewPanelDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace QuickLookUI {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IQLPreviewPanelDelegate" /> (for the protocol <c>QLPreviewPanelDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IQLPreviewPanelDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__QuickLookUI_QLPreviewPanelDelegate", false)]
	[Model]
	public unsafe partial class QLPreviewPanelDelegate : NSObject, IQLPreviewPanelDelegate, global::AppKit.INSWindowDelegate {
		/// <summary>Creates a new <see cref="QLPreviewPanelDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QLPreviewPanelDelegate () : base (NSObjectFlag.Empty)
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
		protected QLPreviewPanelDelegate (NSObjectFlag t) : base (t)
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
		protected internal QLPreviewPanelDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="window">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("customWindowsToEnterFullScreenForWindow:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSWindow[] CustomWindowsToEnterFullScreen (global::AppKit.NSWindow window)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="window">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("customWindowsToExitFullScreenForWindow:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSWindow[] CustomWindowsToExitFullScreen (global::AppKit.NSWindow window)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidBecomeKey:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeKey (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidBecomeMain:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeMain (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidChangeBackingProperties:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeBackingProperties (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidChangeScreen:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeScreen (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidChangeScreenProfile:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeScreenProfile (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="window">To be added.</param><param name="coder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("window:didDecodeRestorableState:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDecodeRestorableState (global::AppKit.NSWindow window, NSCoder coder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidDeminiaturize:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDeminiaturize (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidEndLiveResize:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndLiveResize (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidEndSheet:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndSheet (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidEnterFullScreen:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnterFullScreen (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidEnterVersionBrowser:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnterVersionBrowser (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidExitFullScreen:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidExitFullScreen (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidExitVersionBrowser:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidExitVersionBrowser (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidExpose:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidExpose (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidFailToEnterFullScreen:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToEnterFullScreen (global::AppKit.NSWindow window)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidFailToExitFullScreen:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToExitFullScreen (global::AppKit.NSWindow window)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidMiniaturize:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidMiniaturize (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidMove:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidMove (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidResignKey:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidResignKey (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidResignMain:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidResignMain (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidResize:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidResize (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowDidUpdate:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdate (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("previewRepresentableActivityItemsForWindow:")]
		[SupportedOSPlatform ("macos13.2")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.INSPreviewRepresentableActivityItem[]? GetPreviewRepresentableActivityItems (global::AppKit.NSWindow window)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("windowForSharingRequestFromWindow:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSWindow? GetWindowForSharingRequest (global::AppKit.NSWindow fromWindow)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="panel">To be added.</param><param name="theEvent">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("previewPanel:handleEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HandleEvent (QLPreviewPanel panel, global::AppKit.NSEvent theEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="window">To be added.</param><param name="theEvent">To be added.</param><param name="dragImageLocation">To be added.</param><param name="withPasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("window:shouldDragDocumentWithEvent:from:withPasteboard:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDragDocumentWithEvent (global::AppKit.NSWindow window, global::AppKit.NSEvent theEvent, CGPoint dragImageLocation, global::AppKit.NSPasteboard withPasteboard)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="window">To be added.</param><param name="menu">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("window:shouldPopUpDocumentPathMenu:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPopUpDocumentPathMenu (global::AppKit.NSWindow window, global::AppKit.NSMenu menu)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="window">To be added.</param><param name="newFrame">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("windowShouldZoom:toFrame:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldZoom (global::AppKit.NSWindow window, CGRect newFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="panel">To be added.</param><param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("previewPanel:sourceFrameOnScreenForPreviewItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect SourceFrameOnScreenForPreviewItem (QLPreviewPanel panel, IQLPreviewItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="window">To be added.</param><param name="duration">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("window:startCustomAnimationToEnterFullScreenWithDuration:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartCustomAnimationToEnterFullScreen (global::AppKit.NSWindow window, double duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="window">To be added.</param><param name="duration">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("window:startCustomAnimationToExitFullScreenWithDuration:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartCustomAnimationToExitFullScreen (global::AppKit.NSWindow window, double duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="panel">To be added.</param><param name="item">To be added.</param><param name="contentRect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("previewPanel:transitionImageForPreviewItem:contentRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject TransitionImageForPreviewItem (QLPreviewPanel panel, IQLPreviewItem item, CGRect contentRect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowWillBeginSheet:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginSheet (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowWillClose:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillClose (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="window">To be added.</param><param name="coder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("window:willEncodeRestorableState:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEncodeRestorableState (global::AppKit.NSWindow window, NSCoder coder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowWillEnterFullScreen:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEnterFullScreen (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowWillEnterVersionBrowser:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEnterVersionBrowser (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowWillExitFullScreen:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillExitFullScreen (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowWillExitVersionBrowser:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillExitVersionBrowser (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowWillMiniaturize:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillMiniaturize (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowWillMove:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillMove (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="window">To be added.</param><param name="sheet">To be added.</param><param name="usingRect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("window:willPositionSheet:usingRect:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect WillPositionSheet (global::AppKit.NSWindow window, global::AppKit.NSWindow sheet, CGRect usingRect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="toFrameSize">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("windowWillResize:toSize:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize WillResize (global::AppKit.NSWindow sender, CGSize toFrameSize)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="window">To be added.</param><param name="maxPreferredSize">To be added.</param><param name="maxAllowedSize">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("window:willResizeForVersionBrowserWithMaxPreferredSize:maxAllowedSize:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize WillResizeForVersionBrowser (global::AppKit.NSWindow window, CGSize maxPreferredSize, CGSize maxAllowedSize)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="client">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("windowWillReturnFieldEditor:toObject:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject WillReturnFieldEditor (global::AppKit.NSWindow sender, NSObject client)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="window">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("windowWillReturnUndoManager:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUndoManager WillReturnUndoManager (global::AppKit.NSWindow window)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("windowWillStartLiveResize:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartLiveResize (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="window">To be added.</param><param name="proposedSize">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("window:willUseFullScreenContentSize:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize WillUseFullScreenContentSize (global::AppKit.NSWindow window, CGSize proposedSize)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="window">To be added.</param><param name="proposedOptions">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("window:willUseFullScreenPresentationOptions:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSApplicationPresentationOptions WillUseFullScreenPresentationOptions (global::AppKit.NSWindow window, global::AppKit.NSApplicationPresentationOptions proposedOptions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="window">To be added.</param><param name="newFrame">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("windowWillUseStandardFrame:defaultFrame:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect WillUseStandardFrame (global::AppKit.NSWindow window, CGRect newFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("windowShouldClose:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WindowShouldClose (NSObject sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class QLPreviewPanelDelegate */
}
