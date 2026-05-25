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
	/// <summary>A delegate object that provides events relating to processing editing for <see cref="T:AppKit.NSTextStorage" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/documentation/uikit/nstextstoragedelegate">Apple documentation for <c>NSTextStorageDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSTextStorageDelegate", WrapperType = typeof (NSTextStorageDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TextStorageWillProcessEditing", Selector = "textStorageWillProcessEditing:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TextStorageDidProcessEditing", Selector = "textStorageDidProcessEditing:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillProcessEditing", Selector = "textStorage:willProcessEditing:range:changeInLength:", ParameterType = new Type [] { typeof (NSTextStorage), typeof (NSTextStorageEditActions), typeof (NSRange), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidProcessEditing", Selector = "textStorage:didProcessEditing:range:changeInLength:", ParameterType = new Type [] { typeof (NSTextStorage), typeof (NSTextStorageEditActions), typeof (NSRange), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	public partial interface INSTextStorageDelegate : INativeObject, IDisposable
	{
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textStorageWillProcessEditing:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.11", "Use WillProcessEditing instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TextStorageWillProcessEditing (NSNotification notification)
		{
			_TextStorageWillProcessEditing (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.11", "Use WillProcessEditing instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _TextStorageWillProcessEditing (INSTextStorageDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textStorageWillProcessEditing:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textStorageDidProcessEditing:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.11", "Use DidProcessEditing instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TextStorageDidProcessEditing (NSNotification notification)
		{
			_TextStorageDidProcessEditing (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.11", "Use DidProcessEditing instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _TextStorageDidProcessEditing (INSTextStorageDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textStorageDidProcessEditing:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="textStorage">To be added.</param><param name="editedMask">To be added.</param><param name="editedRange">To be added.</param><param name="delta">To be added.</param><summary>Indicates that processing of the editing on the specified editedRange is about to start.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textStorage:willProcessEditing:range:changeInLength:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillProcessEditing (NSTextStorage textStorage, NSTextStorageEditActions editedMask, NSRange editedRange, nint delta)
		{
			_WillProcessEditing (this, textStorage, editedMask, editedRange, delta);
		}
		/// <param name="textStorage">To be added.</param><param name="editedMask">To be added.</param><param name="editedRange">To be added.</param><param name="delta">To be added.</param><summary>Indicates that processing of the editing on the specified editedRange is about to start.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillProcessEditing (INSTextStorageDelegate This, NSTextStorage textStorage, NSTextStorageEditActions editedMask, NSRange editedRange, nint delta)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textStorage__handle__ = textStorage!.GetNonNullHandle (nameof (textStorage));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NSRange_IntPtr (This.Handle, Selector.GetHandle ("textStorage:willProcessEditing:range:changeInLength:"), textStorage__handle__, (UIntPtr) (ulong) editedMask, editedRange, delta);
			GC.KeepAlive (This);
			GC.KeepAlive (textStorage);
		}
		/// <param name="textStorage">To be added.</param><param name="editedMask">To be added.</param><param name="editedRange">To be added.</param><param name="delta">To be added.</param><summary>Indicates that editing has completed for the specified editedRange.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textStorage:didProcessEditing:range:changeInLength:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidProcessEditing (NSTextStorage textStorage, NSTextStorageEditActions editedMask, NSRange editedRange, nint delta)
		{
			_DidProcessEditing (this, textStorage, editedMask, editedRange, delta);
		}
		/// <param name="textStorage">To be added.</param><param name="editedMask">To be added.</param><param name="editedRange">To be added.</param><param name="delta">To be added.</param><summary>Indicates that editing has completed for the specified editedRange.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidProcessEditing (INSTextStorageDelegate This, NSTextStorage textStorage, NSTextStorageEditActions editedMask, NSRange editedRange, nint delta)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textStorage__handle__ = textStorage!.GetNonNullHandle (nameof (textStorage));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NSRange_IntPtr (This.Handle, Selector.GetHandle ("textStorage:didProcessEditing:range:changeInLength:"), textStorage__handle__, (UIntPtr) (ulong) editedMask, editedRange, delta);
			GC.KeepAlive (This);
			GC.KeepAlive (textStorage);
		}
		[DynamicDependencyAttribute ("DidProcessEditing(AppKit.NSTextStorage,AppKit.NSTextStorageEditActions,Foundation.NSRange,System.IntPtr)")]
		[DynamicDependencyAttribute ("TextStorageDidProcessEditing(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("TextStorageWillProcessEditing(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("WillProcessEditing(AppKit.NSTextStorage,AppKit.NSTextStorageEditActions,Foundation.NSRange,System.IntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextStorageDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTextStorageDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSTextStorageDelegate" /> interface to support all the methods from the NSTextStorageDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSTextStorageDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSTextStorageDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSTextStorageDelegate_Extensions {
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.11", "Use WillProcessEditing instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void TextStorageWillProcessEditing (this INSTextStorageDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textStorageWillProcessEditing:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.11", "Use DidProcessEditing instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void TextStorageDidProcessEditing (this INSTextStorageDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textStorageDidProcessEditing:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="textStorage">To be added.</param><param name="editedMask">To be added.</param><param name="editedRange">To be added.</param><param name="delta">To be added.</param><summary>Indicates that processing of the editing on the specified editedRange is about to start.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillProcessEditing (this INSTextStorageDelegate This, NSTextStorage textStorage, NSTextStorageEditActions editedMask, NSRange editedRange, nint delta)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textStorage__handle__ = textStorage!.GetNonNullHandle (nameof (textStorage));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NSRange_IntPtr (This.Handle, Selector.GetHandle ("textStorage:willProcessEditing:range:changeInLength:"), textStorage__handle__, (UIntPtr) (ulong) editedMask, editedRange, delta);
			GC.KeepAlive (This);
			GC.KeepAlive (textStorage);
		}
		/// <param name="textStorage">To be added.</param><param name="editedMask">To be added.</param><param name="editedRange">To be added.</param><param name="delta">To be added.</param><summary>Indicates that editing has completed for the specified editedRange.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidProcessEditing (this INSTextStorageDelegate This, NSTextStorage textStorage, NSTextStorageEditActions editedMask, NSRange editedRange, nint delta)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textStorage__handle__ = textStorage!.GetNonNullHandle (nameof (textStorage));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NSRange_IntPtr (This.Handle, Selector.GetHandle ("textStorage:didProcessEditing:range:changeInLength:"), textStorage__handle__, (UIntPtr) (ulong) editedMask, editedRange, delta);
			GC.KeepAlive (This);
			GC.KeepAlive (textStorage);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTextStorageDelegateWrapper : BaseWrapper, INSTextStorageDelegate {
		public NSTextStorageDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextStorageDelegateWrapper))]
		static NSTextStorageDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>A delegate object that provides events relating to processing editing for <see cref="T:AppKit.NSTextStorage" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/documentation/uikit/nstextstoragedelegate">Apple documentation for <c>NSTextStorageDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSTextStorageDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSTextStorageDelegate : NSObject, INSTextStorageDelegate {
		/// <summary>Creates a new <see cref="NSTextStorageDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSTextStorageDelegate () : base (NSObjectFlag.Empty)
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
		protected NSTextStorageDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSTextStorageDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="textStorage">To be added.</param><param name="editedMask">To be added.</param><param name="editedRange">To be added.</param><param name="delta">To be added.</param><summary>Indicates that editing has completed for the specified editedRange.</summary><remarks>To be added.</remarks>
		[Export ("textStorage:didProcessEditing:range:changeInLength:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidProcessEditing (NSTextStorage textStorage, NSTextStorageEditActions editedMask, NSRange editedRange, nint delta)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("textStorageDidProcessEditing:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.11", "Use DidProcessEditing instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TextStorageDidProcessEditing (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("textStorageWillProcessEditing:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.11", "Use WillProcessEditing instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TextStorageWillProcessEditing (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textStorage">To be added.</param><param name="editedMask">To be added.</param><param name="editedRange">To be added.</param><param name="delta">To be added.</param><summary>Indicates that processing of the editing on the specified editedRange is about to start.</summary><remarks>To be added.</remarks>
		[Export ("textStorage:willProcessEditing:range:changeInLength:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillProcessEditing (NSTextStorage textStorage, NSTextStorageEditActions editedMask, NSRange editedRange, nint delta)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSTextStorageDelegate */
}
