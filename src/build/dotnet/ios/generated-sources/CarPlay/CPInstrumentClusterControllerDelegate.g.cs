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
namespace CarPlay {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CPInstrumentClusterControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios15.4")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "CPInstrumentClusterControllerDelegate", WrapperType = typeof (CPInstrumentClusterControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidConnectWindow", Selector = "instrumentClusterControllerDidConnectWindow:", ParameterType = new Type [] { typeof (UIWindow) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidDisconnectWindow", Selector = "instrumentClusterControllerDidDisconnectWindow:", ParameterType = new Type [] { typeof (UIWindow) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidZoomIn", Selector = "instrumentClusterControllerDidZoomIn:", ParameterType = new Type [] { typeof (CarPlay.CPInstrumentClusterController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidZoomOut", Selector = "instrumentClusterControllerDidZoomOut:", ParameterType = new Type [] { typeof (CarPlay.CPInstrumentClusterController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeCompassSetting", Selector = "instrumentClusterController:didChangeCompassSetting:", ParameterType = new Type [] { typeof (CarPlay.CPInstrumentClusterController), typeof (CarPlay.CPInstrumentClusterSetting) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeSpeedLimitSetting", Selector = "instrumentClusterController:didChangeSpeedLimitSetting:", ParameterType = new Type [] { typeof (CarPlay.CPInstrumentClusterController), typeof (CarPlay.CPInstrumentClusterSetting) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ICPInstrumentClusterControllerDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("instrumentClusterControllerDidConnectWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidConnectWindow (global::UIKit.UIWindow instrumentClusterWindow)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidConnectWindow (ICPInstrumentClusterControllerDelegate This, global::UIKit.UIWindow instrumentClusterWindow)
		{
			var instrumentClusterWindow__handle__ = instrumentClusterWindow!.GetNonNullHandle (nameof (instrumentClusterWindow));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("instrumentClusterControllerDidConnectWindow:"), instrumentClusterWindow__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (instrumentClusterWindow);
		}
		[global::Foundation.RequiredMember]
		[Export ("instrumentClusterControllerDidDisconnectWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnectWindow (global::UIKit.UIWindow instrumentClusterWindow)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDisconnectWindow (ICPInstrumentClusterControllerDelegate This, global::UIKit.UIWindow instrumentClusterWindow)
		{
			var instrumentClusterWindow__handle__ = instrumentClusterWindow!.GetNonNullHandle (nameof (instrumentClusterWindow));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("instrumentClusterControllerDidDisconnectWindow:"), instrumentClusterWindow__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (instrumentClusterWindow);
		}
		[global::Foundation.OptionalMember]
		[Export ("instrumentClusterControllerDidZoomIn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidZoomIn (CPInstrumentClusterController instrumentClusterController)
		{
			_DidZoomIn (this, instrumentClusterController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidZoomIn (ICPInstrumentClusterControllerDelegate This, CPInstrumentClusterController instrumentClusterController)
		{
			var instrumentClusterController__handle__ = instrumentClusterController!.GetNonNullHandle (nameof (instrumentClusterController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("instrumentClusterControllerDidZoomIn:"), instrumentClusterController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (instrumentClusterController);
		}
		[global::Foundation.OptionalMember]
		[Export ("instrumentClusterControllerDidZoomOut:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidZoomOut (CPInstrumentClusterController instrumentClusterController)
		{
			_DidZoomOut (this, instrumentClusterController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidZoomOut (ICPInstrumentClusterControllerDelegate This, CPInstrumentClusterController instrumentClusterController)
		{
			var instrumentClusterController__handle__ = instrumentClusterController!.GetNonNullHandle (nameof (instrumentClusterController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("instrumentClusterControllerDidZoomOut:"), instrumentClusterController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (instrumentClusterController);
		}
		[global::Foundation.OptionalMember]
		[Export ("instrumentClusterController:didChangeCompassSetting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeCompassSetting (CPInstrumentClusterController instrumentClusterController, CPInstrumentClusterSetting compassSetting)
		{
			_DidChangeCompassSetting (this, instrumentClusterController, compassSetting);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeCompassSetting (ICPInstrumentClusterControllerDelegate This, CPInstrumentClusterController instrumentClusterController, CPInstrumentClusterSetting compassSetting)
		{
			var instrumentClusterController__handle__ = instrumentClusterController!.GetNonNullHandle (nameof (instrumentClusterController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("instrumentClusterController:didChangeCompassSetting:"), instrumentClusterController__handle__, (UIntPtr) (ulong) compassSetting);
			GC.KeepAlive (This);
			GC.KeepAlive (instrumentClusterController);
		}
		[global::Foundation.OptionalMember]
		[Export ("instrumentClusterController:didChangeSpeedLimitSetting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeSpeedLimitSetting (CPInstrumentClusterController instrumentClusterController, CPInstrumentClusterSetting speedLimitSetting)
		{
			_DidChangeSpeedLimitSetting (this, instrumentClusterController, speedLimitSetting);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeSpeedLimitSetting (ICPInstrumentClusterControllerDelegate This, CPInstrumentClusterController instrumentClusterController, CPInstrumentClusterSetting speedLimitSetting)
		{
			var instrumentClusterController__handle__ = instrumentClusterController!.GetNonNullHandle (nameof (instrumentClusterController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("instrumentClusterController:didChangeSpeedLimitSetting:"), instrumentClusterController__handle__, (UIntPtr) (ulong) speedLimitSetting);
			GC.KeepAlive (This);
			GC.KeepAlive (instrumentClusterController);
		}
		[DynamicDependencyAttribute ("DidChangeCompassSetting(CarPlay.CPInstrumentClusterController,CarPlay.CPInstrumentClusterSetting)")]
		[DynamicDependencyAttribute ("DidChangeSpeedLimitSetting(CarPlay.CPInstrumentClusterController,CarPlay.CPInstrumentClusterSetting)")]
		[DynamicDependencyAttribute ("DidConnectWindow(UIKit.UIWindow)")]
		[DynamicDependencyAttribute ("DidDisconnectWindow(UIKit.UIWindow)")]
		[DynamicDependencyAttribute ("DidZoomIn(CarPlay.CPInstrumentClusterController)")]
		[DynamicDependencyAttribute ("DidZoomOut(CarPlay.CPInstrumentClusterController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPInstrumentClusterControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICPInstrumentClusterControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICPInstrumentClusterControllerDelegate" /> interface to support all the methods from the CPInstrumentClusterControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICPInstrumentClusterControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CPInstrumentClusterControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CPInstrumentClusterControllerDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidZoomIn (this ICPInstrumentClusterControllerDelegate This, CPInstrumentClusterController instrumentClusterController)
		{
			var instrumentClusterController__handle__ = instrumentClusterController!.GetNonNullHandle (nameof (instrumentClusterController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("instrumentClusterControllerDidZoomIn:"), instrumentClusterController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (instrumentClusterController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidZoomOut (this ICPInstrumentClusterControllerDelegate This, CPInstrumentClusterController instrumentClusterController)
		{
			var instrumentClusterController__handle__ = instrumentClusterController!.GetNonNullHandle (nameof (instrumentClusterController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("instrumentClusterControllerDidZoomOut:"), instrumentClusterController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (instrumentClusterController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeCompassSetting (this ICPInstrumentClusterControllerDelegate This, CPInstrumentClusterController instrumentClusterController, CPInstrumentClusterSetting compassSetting)
		{
			var instrumentClusterController__handle__ = instrumentClusterController!.GetNonNullHandle (nameof (instrumentClusterController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("instrumentClusterController:didChangeCompassSetting:"), instrumentClusterController__handle__, (UIntPtr) (ulong) compassSetting);
			GC.KeepAlive (This);
			GC.KeepAlive (instrumentClusterController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeSpeedLimitSetting (this ICPInstrumentClusterControllerDelegate This, CPInstrumentClusterController instrumentClusterController, CPInstrumentClusterSetting speedLimitSetting)
		{
			var instrumentClusterController__handle__ = instrumentClusterController!.GetNonNullHandle (nameof (instrumentClusterController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("instrumentClusterController:didChangeSpeedLimitSetting:"), instrumentClusterController__handle__, (UIntPtr) (ulong) speedLimitSetting);
			GC.KeepAlive (This);
			GC.KeepAlive (instrumentClusterController);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CPInstrumentClusterControllerDelegateWrapper : BaseWrapper, ICPInstrumentClusterControllerDelegate {
		public CPInstrumentClusterControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPInstrumentClusterControllerDelegateWrapper))]
		static CPInstrumentClusterControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("instrumentClusterControllerDidConnectWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidConnectWindow (global::UIKit.UIWindow instrumentClusterWindow)
		{
			var instrumentClusterWindow__handle__ = instrumentClusterWindow!.GetNonNullHandle (nameof (instrumentClusterWindow));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("instrumentClusterControllerDidConnectWindow:"), instrumentClusterWindow__handle__);
			GC.KeepAlive (instrumentClusterWindow);
		}
		[Export ("instrumentClusterControllerDidDisconnectWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidDisconnectWindow (global::UIKit.UIWindow instrumentClusterWindow)
		{
			var instrumentClusterWindow__handle__ = instrumentClusterWindow!.GetNonNullHandle (nameof (instrumentClusterWindow));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("instrumentClusterControllerDidDisconnectWindow:"), instrumentClusterWindow__handle__);
			GC.KeepAlive (instrumentClusterWindow);
		}
	}
}
namespace CarPlay {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="ICPInstrumentClusterControllerDelegate" /> (for the protocol <c>CPInstrumentClusterControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="ICPInstrumentClusterControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__CarPlay_CPInstrumentClusterControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios15.4")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public unsafe abstract partial class CPInstrumentClusterControllerDelegate : NSObject, ICPInstrumentClusterControllerDelegate {
		/// <summary>Creates a new <see cref="CPInstrumentClusterControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CPInstrumentClusterControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected CPInstrumentClusterControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal CPInstrumentClusterControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("instrumentClusterController:didChangeCompassSetting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeCompassSetting (CPInstrumentClusterController instrumentClusterController, CPInstrumentClusterSetting compassSetting)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("instrumentClusterController:didChangeSpeedLimitSetting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeSpeedLimitSetting (CPInstrumentClusterController instrumentClusterController, CPInstrumentClusterSetting speedLimitSetting)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("instrumentClusterControllerDidConnectWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidConnectWindow (global::UIKit.UIWindow instrumentClusterWindow)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("instrumentClusterControllerDidDisconnectWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnectWindow (global::UIKit.UIWindow instrumentClusterWindow)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("instrumentClusterControllerDidZoomIn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidZoomIn (CPInstrumentClusterController instrumentClusterController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("instrumentClusterControllerDidZoomOut:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidZoomOut (CPInstrumentClusterController instrumentClusterController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CPInstrumentClusterControllerDelegate */
}
