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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AVKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AVContinuityDevicePickerViewControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos17.0")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "AVContinuityDevicePickerViewControllerDelegate", WrapperType = typeof (AVContinuityDevicePickerViewControllerDelegateWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginPresenting", Selector = "continuityDevicePickerWillBeginPresenting:", ParameterType = new Type [] { typeof (AVKit.AVContinuityDevicePickerViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidConnectDevice", Selector = "continuityDevicePicker:didConnectDevice:", ParameterType = new Type [] { typeof (AVKit.AVContinuityDevicePickerViewController), typeof (AVContinuityDevice) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCancel", Selector = "continuityDevicePickerDidCancel:", ParameterType = new Type [] { typeof (AVKit.AVContinuityDevicePickerViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndPresenting", Selector = "continuityDevicePickerDidEndPresenting:", ParameterType = new Type [] { typeof (AVKit.AVContinuityDevicePickerViewController) }, ParameterByRef = new bool [] { false })]
	public partial interface IAVContinuityDevicePickerViewControllerDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("continuityDevicePickerWillBeginPresenting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginPresenting (AVContinuityDevicePickerViewController pickerViewController)
		{
			_WillBeginPresenting (this, pickerViewController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillBeginPresenting (IAVContinuityDevicePickerViewControllerDelegate This, AVContinuityDevicePickerViewController pickerViewController)
		{
			var pickerViewController__handle__ = pickerViewController!.GetNonNullHandle (nameof (pickerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("continuityDevicePickerWillBeginPresenting:"), pickerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pickerViewController);
		}
		[global::Foundation.OptionalMember]
		[Export ("continuityDevicePicker:didConnectDevice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidConnectDevice (AVContinuityDevicePickerViewController pickerViewController, global::AVFoundation.AVContinuityDevice device)
		{
			_DidConnectDevice (this, pickerViewController, device);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidConnectDevice (IAVContinuityDevicePickerViewControllerDelegate This, AVContinuityDevicePickerViewController pickerViewController, global::AVFoundation.AVContinuityDevice device)
		{
			var pickerViewController__handle__ = pickerViewController!.GetNonNullHandle (nameof (pickerViewController));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("continuityDevicePicker:didConnectDevice:"), pickerViewController__handle__, device__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pickerViewController);
			GC.KeepAlive (device);
		}
		[global::Foundation.OptionalMember]
		[Export ("continuityDevicePickerDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancel (AVContinuityDevicePickerViewController pickerViewController)
		{
			_DidCancel (this, pickerViewController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCancel (IAVContinuityDevicePickerViewControllerDelegate This, AVContinuityDevicePickerViewController pickerViewController)
		{
			var pickerViewController__handle__ = pickerViewController!.GetNonNullHandle (nameof (pickerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("continuityDevicePickerDidCancel:"), pickerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pickerViewController);
		}
		[global::Foundation.OptionalMember]
		[Export ("continuityDevicePickerDidEndPresenting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndPresenting (AVContinuityDevicePickerViewController pickerViewController)
		{
			_DidEndPresenting (this, pickerViewController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEndPresenting (IAVContinuityDevicePickerViewControllerDelegate This, AVContinuityDevicePickerViewController pickerViewController)
		{
			var pickerViewController__handle__ = pickerViewController!.GetNonNullHandle (nameof (pickerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("continuityDevicePickerDidEndPresenting:"), pickerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pickerViewController);
		}
		[DynamicDependencyAttribute ("DidCancel(AVKit.AVContinuityDevicePickerViewController)")]
		[DynamicDependencyAttribute ("DidConnectDevice(AVKit.AVContinuityDevicePickerViewController,AVFoundation.AVContinuityDevice)")]
		[DynamicDependencyAttribute ("DidEndPresenting(AVKit.AVContinuityDevicePickerViewController)")]
		[DynamicDependencyAttribute ("WillBeginPresenting(AVKit.AVContinuityDevicePickerViewController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVContinuityDevicePickerViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVContinuityDevicePickerViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVContinuityDevicePickerViewControllerDelegateWrapper : BaseWrapper, IAVContinuityDevicePickerViewControllerDelegate {
		public AVContinuityDevicePickerViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVContinuityDevicePickerViewControllerDelegateWrapper))]
		static AVContinuityDevicePickerViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AVKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IAVContinuityDevicePickerViewControllerDelegate" /> (for the protocol <c>AVContinuityDevicePickerViewControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IAVContinuityDevicePickerViewControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__AVKit_AVContinuityDevicePickerViewControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("tvos17.0")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public unsafe partial class AVContinuityDevicePickerViewControllerDelegate : NSObject, IAVContinuityDevicePickerViewControllerDelegate {
		/// <summary>Creates a new <see cref="AVContinuityDevicePickerViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVContinuityDevicePickerViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected AVContinuityDevicePickerViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVContinuityDevicePickerViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("continuityDevicePickerDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancel (AVContinuityDevicePickerViewController pickerViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("continuityDevicePicker:didConnectDevice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidConnectDevice (AVContinuityDevicePickerViewController pickerViewController, global::AVFoundation.AVContinuityDevice device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("continuityDevicePickerDidEndPresenting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndPresenting (AVContinuityDevicePickerViewController pickerViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("continuityDevicePickerWillBeginPresenting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginPresenting (AVContinuityDevicePickerViewController pickerViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVContinuityDevicePickerViewControllerDelegate */
}
