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
	/// <summary>This interface represents the Objective-C protocol <c>NSImageDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSImageDelegate", WrapperType = typeof (NSImageDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ImageDidNotDraw", Selector = "imageDidNotDraw:inRect:", ReturnType = typeof (NSImage), ParameterType = new Type [] { typeof (NSObject), typeof (CGRect) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillLoadRepresentation", Selector = "image:willLoadRepresentation:", ParameterType = new Type [] { typeof (NSImage), typeof (NSImageRep) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidLoadRepresentationHeader", Selector = "image:didLoadRepresentationHeader:", ParameterType = new Type [] { typeof (NSImage), typeof (NSImageRep) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidLoadPartOfRepresentation", Selector = "image:didLoadPartOfRepresentation:withValidRows:", ParameterType = new Type [] { typeof (NSImage), typeof (NSImageRep), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidLoadRepresentation", Selector = "image:didLoadRepresentation:withStatus:", ParameterType = new Type [] { typeof (NSImage), typeof (NSImageRep), typeof (NSImageLoadStatus) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface INSImageDelegate : INativeObject, IDisposable
	{
		/// <param name="sender">To be added.</param><param name="aRect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("imageDidNotDraw:inRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSImage ImageDidNotDraw (NSObject sender, CGRect aRect)
		{
			return _ImageDidNotDraw (this, sender, aRect);
		}
		/// <param name="sender">To be added.</param><param name="aRect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSImage _ImageDidNotDraw (INSImageDelegate This, NSObject sender, CGRect aRect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			NSImage? ret;
			ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("imageDidNotDraw:inRect:"), sender__handle__, aRect), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="image">To be added.</param><param name="rep">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("image:willLoadRepresentation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillLoadRepresentation (NSImage image, NSImageRep rep)
		{
			_WillLoadRepresentation (this, image, rep);
		}
		/// <param name="image">To be added.</param><param name="rep">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillLoadRepresentation (INSImageDelegate This, NSImage image, NSImageRep rep)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var rep__handle__ = rep!.GetNonNullHandle (nameof (rep));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("image:willLoadRepresentation:"), image__handle__, rep__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (rep);
		}
		/// <param name="image">To be added.</param><param name="rep">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("image:didLoadRepresentationHeader:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoadRepresentationHeader (NSImage image, NSImageRep rep)
		{
			_DidLoadRepresentationHeader (this, image, rep);
		}
		/// <param name="image">To be added.</param><param name="rep">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidLoadRepresentationHeader (INSImageDelegate This, NSImage image, NSImageRep rep)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var rep__handle__ = rep!.GetNonNullHandle (nameof (rep));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("image:didLoadRepresentationHeader:"), image__handle__, rep__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (rep);
		}
		/// <param name="image">To be added.</param><param name="rep">To be added.</param><param name="rows">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("image:didLoadPartOfRepresentation:withValidRows:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoadPartOfRepresentation (NSImage image, NSImageRep rep, nint rows)
		{
			_DidLoadPartOfRepresentation (this, image, rep, rows);
		}
		/// <param name="image">To be added.</param><param name="rep">To be added.</param><param name="rows">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidLoadPartOfRepresentation (INSImageDelegate This, NSImage image, NSImageRep rep, nint rows)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var rep__handle__ = rep!.GetNonNullHandle (nameof (rep));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("image:didLoadPartOfRepresentation:withValidRows:"), image__handle__, rep__handle__, rows);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (rep);
		}
		/// <param name="image">To be added.</param><param name="rep">To be added.</param><param name="status">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("image:didLoadRepresentation:withStatus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoadRepresentation (NSImage image, NSImageRep rep, NSImageLoadStatus status)
		{
			_DidLoadRepresentation (this, image, rep, status);
		}
		/// <param name="image">To be added.</param><param name="rep">To be added.</param><param name="status">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidLoadRepresentation (INSImageDelegate This, NSImage image, NSImageRep rep, NSImageLoadStatus status)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var rep__handle__ = rep!.GetNonNullHandle (nameof (rep));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("image:didLoadRepresentation:withStatus:"), image__handle__, rep__handle__, (UIntPtr) (ulong) status);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (rep);
		}
		[DynamicDependencyAttribute ("DidLoadPartOfRepresentation(AppKit.NSImage,AppKit.NSImageRep,System.IntPtr)")]
		[DynamicDependencyAttribute ("DidLoadRepresentation(AppKit.NSImage,AppKit.NSImageRep,AppKit.NSImageLoadStatus)")]
		[DynamicDependencyAttribute ("DidLoadRepresentationHeader(AppKit.NSImage,AppKit.NSImageRep)")]
		[DynamicDependencyAttribute ("ImageDidNotDraw(Foundation.NSObject,CoreGraphics.CGRect)")]
		[DynamicDependencyAttribute ("WillLoadRepresentation(AppKit.NSImage,AppKit.NSImageRep)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSImageDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSImageDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSImageDelegate" /> interface to support all the methods from the NSImageDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSImageDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSImageDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSImageDelegate_Extensions {
		/// <param name="sender">To be added.</param><param name="aRect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSImage ImageDidNotDraw (this INSImageDelegate This, NSObject sender, CGRect aRect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			NSImage? ret;
			ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("imageDidNotDraw:inRect:"), sender__handle__, aRect), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="image">To be added.</param><param name="rep">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillLoadRepresentation (this INSImageDelegate This, NSImage image, NSImageRep rep)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var rep__handle__ = rep!.GetNonNullHandle (nameof (rep));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("image:willLoadRepresentation:"), image__handle__, rep__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (rep);
		}
		/// <param name="image">To be added.</param><param name="rep">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidLoadRepresentationHeader (this INSImageDelegate This, NSImage image, NSImageRep rep)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var rep__handle__ = rep!.GetNonNullHandle (nameof (rep));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("image:didLoadRepresentationHeader:"), image__handle__, rep__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (rep);
		}
		/// <param name="image">To be added.</param><param name="rep">To be added.</param><param name="rows">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidLoadPartOfRepresentation (this INSImageDelegate This, NSImage image, NSImageRep rep, nint rows)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var rep__handle__ = rep!.GetNonNullHandle (nameof (rep));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("image:didLoadPartOfRepresentation:withValidRows:"), image__handle__, rep__handle__, rows);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (rep);
		}
		/// <param name="image">To be added.</param><param name="rep">To be added.</param><param name="status">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidLoadRepresentation (this INSImageDelegate This, NSImage image, NSImageRep rep, NSImageLoadStatus status)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var rep__handle__ = rep!.GetNonNullHandle (nameof (rep));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("image:didLoadRepresentation:withStatus:"), image__handle__, rep__handle__, (UIntPtr) (ulong) status);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (rep);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSImageDelegateWrapper : BaseWrapper, INSImageDelegate {
		public NSImageDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSImageDelegateWrapper))]
		static NSImageDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSImageDelegate" /> (for the protocol <c>NSImageDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSImageDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSImageDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSImageDelegate : NSObject, INSImageDelegate {
		/// <summary>Creates a new <see cref="NSImageDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSImageDelegate () : base (NSObjectFlag.Empty)
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
		protected NSImageDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSImageDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="image">To be added.</param><param name="rep">To be added.</param><param name="rows">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("image:didLoadPartOfRepresentation:withValidRows:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoadPartOfRepresentation (NSImage image, NSImageRep rep, nint rows)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="image">To be added.</param><param name="rep">To be added.</param><param name="status">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("image:didLoadRepresentation:withStatus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoadRepresentation (NSImage image, NSImageRep rep, NSImageLoadStatus status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="image">To be added.</param><param name="rep">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("image:didLoadRepresentationHeader:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoadRepresentationHeader (NSImage image, NSImageRep rep)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="aRect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageDidNotDraw:inRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSImage ImageDidNotDraw (NSObject sender, CGRect aRect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="image">To be added.</param><param name="rep">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("image:willLoadRepresentation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillLoadRepresentation (NSImage image, NSImageRep rep)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSImageDelegate */
}
