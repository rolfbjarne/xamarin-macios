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
	/// <summary>This interface represents the Objective-C protocol <c>NSScrubberDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSScrubberDelegate", WrapperType = typeof (NSScrubberDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectItem", Selector = "scrubber:didSelectItemAtIndex:", ParameterType = new Type [] { typeof (NSScrubber), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidHighlightItem", Selector = "scrubber:didHighlightItemAtIndex:", ParameterType = new Type [] { typeof (NSScrubber), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeVisible", Selector = "scrubber:didChangeVisibleRange:", ParameterType = new Type [] { typeof (NSScrubber), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBeginInteracting", Selector = "didBeginInteractingWithScrubber:", ParameterType = new Type [] { typeof (NSScrubber) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishInteracting", Selector = "didFinishInteractingWithScrubber:", ParameterType = new Type [] { typeof (NSScrubber) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCancelInteracting", Selector = "didCancelInteractingWithScrubber:", ParameterType = new Type [] { typeof (NSScrubber) }, ParameterByRef = new bool [] { false })]
	public partial interface INSScrubberDelegate : INativeObject, IDisposable
	{
		/// <param name="scrubber">To be added.</param><param name="selectedIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("scrubber:didSelectItemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectItem (NSScrubber scrubber, nint selectedIndex)
		{
			_DidSelectItem (this, scrubber, selectedIndex);
		}
		/// <param name="scrubber">To be added.</param><param name="selectedIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectItem (INSScrubberDelegate This, NSScrubber scrubber, nint selectedIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var scrubber__handle__ = scrubber!.GetNonNullHandle (nameof (scrubber));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("scrubber:didSelectItemAtIndex:"), scrubber__handle__, selectedIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (scrubber);
		}
		/// <param name="scrubber">To be added.</param><param name="highlightedIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("scrubber:didHighlightItemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidHighlightItem (NSScrubber scrubber, nint highlightedIndex)
		{
			_DidHighlightItem (this, scrubber, highlightedIndex);
		}
		/// <param name="scrubber">To be added.</param><param name="highlightedIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidHighlightItem (INSScrubberDelegate This, NSScrubber scrubber, nint highlightedIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var scrubber__handle__ = scrubber!.GetNonNullHandle (nameof (scrubber));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("scrubber:didHighlightItemAtIndex:"), scrubber__handle__, highlightedIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (scrubber);
		}
		/// <param name="scrubber">To be added.</param><param name="visibleRange">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("scrubber:didChangeVisibleRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeVisible (NSScrubber scrubber, NSRange visibleRange)
		{
			_DidChangeVisible (this, scrubber, visibleRange);
		}
		/// <param name="scrubber">To be added.</param><param name="visibleRange">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeVisible (INSScrubberDelegate This, NSScrubber scrubber, NSRange visibleRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var scrubber__handle__ = scrubber!.GetNonNullHandle (nameof (scrubber));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("scrubber:didChangeVisibleRange:"), scrubber__handle__, visibleRange);
			GC.KeepAlive (This);
			GC.KeepAlive (scrubber);
		}
		/// <param name="scrubber">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("didBeginInteractingWithScrubber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginInteracting (NSScrubber scrubber)
		{
			_DidBeginInteracting (this, scrubber);
		}
		/// <param name="scrubber">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBeginInteracting (INSScrubberDelegate This, NSScrubber scrubber)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var scrubber__handle__ = scrubber!.GetNonNullHandle (nameof (scrubber));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didBeginInteractingWithScrubber:"), scrubber__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrubber);
		}
		/// <param name="scrubber">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("didFinishInteractingWithScrubber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishInteracting (NSScrubber scrubber)
		{
			_DidFinishInteracting (this, scrubber);
		}
		/// <param name="scrubber">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishInteracting (INSScrubberDelegate This, NSScrubber scrubber)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var scrubber__handle__ = scrubber!.GetNonNullHandle (nameof (scrubber));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didFinishInteractingWithScrubber:"), scrubber__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrubber);
		}
		/// <param name="scrubber">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("didCancelInteractingWithScrubber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancelInteracting (NSScrubber scrubber)
		{
			_DidCancelInteracting (this, scrubber);
		}
		/// <param name="scrubber">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCancelInteracting (INSScrubberDelegate This, NSScrubber scrubber)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var scrubber__handle__ = scrubber!.GetNonNullHandle (nameof (scrubber));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didCancelInteractingWithScrubber:"), scrubber__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrubber);
		}
		[DynamicDependencyAttribute ("DidBeginInteracting(AppKit.NSScrubber)")]
		[DynamicDependencyAttribute ("DidCancelInteracting(AppKit.NSScrubber)")]
		[DynamicDependencyAttribute ("DidChangeVisible(AppKit.NSScrubber,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("DidFinishInteracting(AppKit.NSScrubber)")]
		[DynamicDependencyAttribute ("DidHighlightItem(AppKit.NSScrubber,System.IntPtr)")]
		[DynamicDependencyAttribute ("DidSelectItem(AppKit.NSScrubber,System.IntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSScrubberDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSScrubberDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSScrubberDelegate" /> interface to support all the methods from the NSScrubberDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSScrubberDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSScrubberDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSScrubberDelegate_Extensions {
		/// <param name="scrubber">To be added.</param><param name="selectedIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectItem (this INSScrubberDelegate This, NSScrubber scrubber, nint selectedIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var scrubber__handle__ = scrubber!.GetNonNullHandle (nameof (scrubber));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("scrubber:didSelectItemAtIndex:"), scrubber__handle__, selectedIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (scrubber);
		}
		/// <param name="scrubber">To be added.</param><param name="highlightedIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidHighlightItem (this INSScrubberDelegate This, NSScrubber scrubber, nint highlightedIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var scrubber__handle__ = scrubber!.GetNonNullHandle (nameof (scrubber));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("scrubber:didHighlightItemAtIndex:"), scrubber__handle__, highlightedIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (scrubber);
		}
		/// <param name="scrubber">To be added.</param><param name="visibleRange">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeVisible (this INSScrubberDelegate This, NSScrubber scrubber, NSRange visibleRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var scrubber__handle__ = scrubber!.GetNonNullHandle (nameof (scrubber));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("scrubber:didChangeVisibleRange:"), scrubber__handle__, visibleRange);
			GC.KeepAlive (This);
			GC.KeepAlive (scrubber);
		}
		/// <param name="scrubber">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBeginInteracting (this INSScrubberDelegate This, NSScrubber scrubber)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var scrubber__handle__ = scrubber!.GetNonNullHandle (nameof (scrubber));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didBeginInteractingWithScrubber:"), scrubber__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrubber);
		}
		/// <param name="scrubber">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishInteracting (this INSScrubberDelegate This, NSScrubber scrubber)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var scrubber__handle__ = scrubber!.GetNonNullHandle (nameof (scrubber));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didFinishInteractingWithScrubber:"), scrubber__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrubber);
		}
		/// <param name="scrubber">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCancelInteracting (this INSScrubberDelegate This, NSScrubber scrubber)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var scrubber__handle__ = scrubber!.GetNonNullHandle (nameof (scrubber));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didCancelInteractingWithScrubber:"), scrubber__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scrubber);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSScrubberDelegateWrapper : BaseWrapper, INSScrubberDelegate {
		public NSScrubberDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSScrubberDelegateWrapper))]
		static NSScrubberDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSScrubberDelegate" /> (for the protocol <c>NSScrubberDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSScrubberDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSScrubberDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSScrubberDelegate : NSObject, INSScrubberDelegate {
		/// <summary>Creates a new <see cref="NSScrubberDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSScrubberDelegate () : base (NSObjectFlag.Empty)
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
		protected NSScrubberDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSScrubberDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="scrubber">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("didBeginInteractingWithScrubber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginInteracting (NSScrubber scrubber)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrubber">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("didCancelInteractingWithScrubber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancelInteracting (NSScrubber scrubber)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrubber">To be added.</param><param name="visibleRange">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("scrubber:didChangeVisibleRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeVisible (NSScrubber scrubber, NSRange visibleRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrubber">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("didFinishInteractingWithScrubber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishInteracting (NSScrubber scrubber)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrubber">To be added.</param><param name="highlightedIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("scrubber:didHighlightItemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidHighlightItem (NSScrubber scrubber, nint highlightedIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrubber">To be added.</param><param name="selectedIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("scrubber:didSelectItemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectItem (NSScrubber scrubber, nint selectedIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSScrubberDelegate */
}
