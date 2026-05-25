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
namespace SceneKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>SCNCameraControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "SCNCameraControllerDelegate", WrapperType = typeof (SCNCameraControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CameraInertiaWillStart", Selector = "cameraInertiaWillStartForController:", ParameterType = new Type [] { typeof (SCNCameraController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CameraInertiaDidEnd", Selector = "cameraInertiaDidEndForController:", ParameterType = new Type [] { typeof (SCNCameraController) }, ParameterByRef = new bool [] { false })]
	public partial interface ISCNCameraControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="cameraController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("cameraInertiaWillStartForController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CameraInertiaWillStart (SCNCameraController cameraController)
		{
			_CameraInertiaWillStart (this, cameraController);
		}
		/// <param name="cameraController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CameraInertiaWillStart (ISCNCameraControllerDelegate This, SCNCameraController cameraController)
		{
			var cameraController__handle__ = cameraController!.GetNonNullHandle (nameof (cameraController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cameraInertiaWillStartForController:"), cameraController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cameraController);
		}
		/// <param name="cameraController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("cameraInertiaDidEndForController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CameraInertiaDidEnd (SCNCameraController cameraController)
		{
			_CameraInertiaDidEnd (this, cameraController);
		}
		/// <param name="cameraController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CameraInertiaDidEnd (ISCNCameraControllerDelegate This, SCNCameraController cameraController)
		{
			var cameraController__handle__ = cameraController!.GetNonNullHandle (nameof (cameraController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cameraInertiaDidEndForController:"), cameraController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cameraController);
		}
		[DynamicDependencyAttribute ("CameraInertiaDidEnd(SceneKit.SCNCameraController)")]
		[DynamicDependencyAttribute ("CameraInertiaWillStart(SceneKit.SCNCameraController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCNCameraControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISCNCameraControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ISCNCameraControllerDelegate" /> interface to support all the methods from the SCNCameraControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ISCNCameraControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original SCNCameraControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class SCNCameraControllerDelegate_Extensions {
		/// <param name="cameraController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CameraInertiaWillStart (this ISCNCameraControllerDelegate This, SCNCameraController cameraController)
		{
			var cameraController__handle__ = cameraController!.GetNonNullHandle (nameof (cameraController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cameraInertiaWillStartForController:"), cameraController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cameraController);
		}
		/// <param name="cameraController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CameraInertiaDidEnd (this ISCNCameraControllerDelegate This, SCNCameraController cameraController)
		{
			var cameraController__handle__ = cameraController!.GetNonNullHandle (nameof (cameraController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cameraInertiaDidEndForController:"), cameraController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cameraController);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SCNCameraControllerDelegateWrapper : BaseWrapper, ISCNCameraControllerDelegate {
		public SCNCameraControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCNCameraControllerDelegateWrapper))]
		static SCNCameraControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace SceneKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="ISCNCameraControllerDelegate" /> (for the protocol <c>SCNCameraControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="ISCNCameraControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__SceneKit_SCNCameraControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SCNCameraControllerDelegate : NSObject, ISCNCameraControllerDelegate {
		/// <summary>Creates a new <see cref="SCNCameraControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCNCameraControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected SCNCameraControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal SCNCameraControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="cameraController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("cameraInertiaDidEndForController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CameraInertiaDidEnd (SCNCameraController cameraController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="cameraController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("cameraInertiaWillStartForController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CameraInertiaWillStart (SCNCameraController cameraController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SCNCameraControllerDelegate */
}
