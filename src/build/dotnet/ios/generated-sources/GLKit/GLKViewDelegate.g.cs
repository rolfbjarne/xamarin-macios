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
namespace GLKit {
	#pragma warning disable CS1573
	/// <summary>A class that acts like a delegate object for instances of <see cref="T:GLKit.GLKView" />.</summary><remarks><para>The specific use-case supported by this class is to customize the <see cref="GLKit.IGLKViewDelegate.DrawInRect(GLKit.GLKView,CoreGraphics.CGRect)" /> method without subclassing <see cref="T:GLKit.GLKView" />.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GLKViewDelegate_ProtocolRef/index.html">Apple documentation for <c>GLKViewDelegate</c></related>
	[UnsupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("ios12.0", "Use 'Metal' instead.")]
	[ObsoletedOSPlatform ("tvos12.0", "Use 'Metal' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "GLKViewDelegate", WrapperType = typeof (GLKViewDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawInRect", Selector = "glkView:drawInRect:", ParameterType = new Type [] { typeof (GLKView), typeof (CGRect) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IGLKViewDelegate : INativeObject, IDisposable
	{
		/// <param name="view">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("glkView:drawInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawInRect (GLKView view, CGRect rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="view">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawInRect (IGLKViewDelegate This, GLKView view, CGRect rect)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("glkView:drawInRect:"), view__handle__, rect);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
		}
		[DynamicDependencyAttribute ("DrawInRect(GLKit.GLKView,CoreGraphics.CGRect)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GLKViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGLKViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GLKViewDelegateWrapper : BaseWrapper, IGLKViewDelegate {
		public GLKViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GLKViewDelegateWrapper))]
		static GLKViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="view">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("glkView:drawInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawInRect (GLKView view, CGRect rect)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGRect (this.Handle, Selector.GetHandle ("glkView:drawInRect:"), view__handle__, rect);
			GC.KeepAlive (view);
		}
	}
}
namespace GLKit {
	/// <summary>A class that acts like a delegate object for instances of <see cref="T:GLKit.GLKView" />.</summary><remarks><para>The specific use-case supported by this class is to customize the <see cref="GLKit.IGLKViewDelegate.DrawInRect(GLKit.GLKView,CoreGraphics.CGRect)" /> method without subclassing <see cref="T:GLKit.GLKView" />.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GLKViewDelegate_ProtocolRef/index.html">Apple documentation for <c>GLKViewDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__GLKit_GLKViewDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("ios12.0", "Use 'Metal' instead.")]
	[ObsoletedOSPlatform ("tvos12.0", "Use 'Metal' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class GLKViewDelegate : NSObject, IGLKViewDelegate {
		/// <summary>Creates a new <see cref="GLKViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected GLKViewDelegate () : base (NSObjectFlag.Empty)
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
		protected GLKViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal GLKViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="view">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("glkView:drawInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawInRect (GLKView view, CGRect rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class GLKViewDelegate */
}
