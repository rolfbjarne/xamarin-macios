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
	/// <summary>This interface represents the Objective-C protocol <c>NSTextFinderBarContainer</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSTextFinderBarContainer", WrapperType = typeof (NSTextFinderBarContainerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FindBarViewDidChangeHeight", Selector = "findBarViewDidChangeHeight")]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "FindBarVisible", Selector = "findBarVisible", PropertyType = typeof (bool), GetterSelector = "isFindBarVisible", SetterSelector = "setFindBarVisible:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "FindBarView", Selector = "findBarView", PropertyType = typeof (NSView), GetterSelector = "findBarView", SetterSelector = "setFindBarView:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ContentView", Selector = "contentView", PropertyType = typeof (NSView), GetterSelector = "contentView", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSTextFinderBarContainer : INativeObject, IDisposable
	{
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("findBarViewDidChangeHeight")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FindBarViewDidChangeHeight ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FindBarViewDidChangeHeight (INSTextFinderBarContainer This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("findBarViewDidChangeHeight"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("ContentView")]
		[DynamicDependencyAttribute ("FindBarView")]
		[DynamicDependencyAttribute ("FindBarViewDidChangeHeight()")]
		[DynamicDependencyAttribute ("FindBarVisible")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextFinderBarContainerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTextFinderBarContainer ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool FindBarVisible {
			[Export ("isFindBarVisible")]
			get {
				return _GetFindBarVisible (this);
			}
			[Export ("setFindBarVisible:")]
			set {
				_SetFindBarVisible (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetFindBarVisible (INSTextFinderBarContainer This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isFindBarVisible"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFindBarVisible (INSTextFinderBarContainer This, bool value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setFindBarVisible:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSView FindBarView {
			[Export ("findBarView", ArgumentSemantic.Retain)]
			get {
				return _GetFindBarView (this);
			}
			[Export ("setFindBarView:", ArgumentSemantic.Retain)]
			set {
				_SetFindBarView (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSView _GetFindBarView (INSTextFinderBarContainer This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSView ret;
			ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("findBarView")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFindBarView (INSTextFinderBarContainer This, NSView value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setFindBarView:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSView ContentView {
			[Export ("contentView")]
			get {
				return _GetContentView (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSView _GetContentView (INSTextFinderBarContainer This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSView ret;
			ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("contentView")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSTextFinderBarContainer" /> interface to support all the methods from the NSTextFinderBarContainer protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSTextFinderBarContainer" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSTextFinderBarContainer protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSTextFinderBarContainer_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSView GetContentView (this INSTextFinderBarContainer This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSView ret;
			ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("contentView")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTextFinderBarContainerWrapper : BaseWrapper, INSTextFinderBarContainer {
		public NSTextFinderBarContainerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextFinderBarContainerWrapper))]
		static NSTextFinderBarContainerWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("findBarViewDidChangeHeight")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FindBarViewDidChangeHeight ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("findBarViewDidChangeHeight"));
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool FindBarVisible {
			[Export ("isFindBarVisible")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isFindBarVisible"));
				return ret != 0;
			}
			[Export ("setFindBarVisible:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setFindBarVisible:"), value ? (byte) 1 : (byte) 0);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSView FindBarView {
			[Export ("findBarView", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSView ret;
				ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("findBarView")), false)!;
				return ret;
			}
			[Export ("setFindBarView:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setFindBarView:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSTextFinderBarContainer" /> (for the protocol <c>NSTextFinderBarContainer</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSTextFinderBarContainer" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSTextFinderBarContainer", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class NSTextFinderBarContainer : NSObject, INSTextFinderBarContainer {
		/// <summary>Creates a new <see cref="NSTextFinderBarContainer" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NSTextFinderBarContainer () : base (NSObjectFlag.Empty)
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
		protected NSTextFinderBarContainer (NSObjectFlag t) : base (t)
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
		protected internal NSTextFinderBarContainer (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("findBarViewDidChangeHeight")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FindBarViewDidChangeHeight ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView ContentView {
			[Export ("contentView")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView FindBarView {
			[Export ("findBarView", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setFindBarView:", ArgumentSemantic.Retain)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool FindBarVisible {
			[Export ("isFindBarVisible")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setFindBarVisible:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class NSTextFinderBarContainer */
}
