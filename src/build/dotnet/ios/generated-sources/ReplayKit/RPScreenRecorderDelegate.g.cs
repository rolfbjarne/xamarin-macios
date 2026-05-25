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
namespace ReplayKit {
	#pragma warning disable CS1573
	/// <summary>Protocol for enabling the user to record visual and audio output of applications, with simultaneous recorded audio (screencasts)..</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ReplayKit/Reference/RPScreenRecorderDelegate_Ref/index.html">Apple documentation for <c>RPScreenRecorderDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "RPScreenRecorderDelegate", WrapperType = typeof (RPScreenRecorderDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStopRecording", Selector = "screenRecorder:didStopRecordingWithError:previewViewController:", ParameterType = new Type [] { typeof (ReplayKit.RPScreenRecorder), typeof (NSError), typeof (ReplayKit.RPPreviewViewController) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStopRecording", Selector = "screenRecorder:didStopRecordingWithPreviewViewController:error:", ParameterType = new Type [] { typeof (ReplayKit.RPScreenRecorder), typeof (ReplayKit.RPPreviewViewController), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeAvailability", Selector = "screenRecorderDidChangeAvailability:", ParameterType = new Type [] { typeof (ReplayKit.RPScreenRecorder) }, ParameterByRef = new bool [] { false })]
	public partial interface IRPScreenRecorderDelegate : INativeObject, IDisposable
	{
		/// <param name="screenRecorder">To be added.</param><param name="error">To be added.</param><param name="previewViewController"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Developers should not use this deprecated method. Developers should use 'DidStopRecording(RPScreenRecorder,RPPreviewViewController,NSError)' instead.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("screenRecorder:didStopRecordingWithError:previewViewController:")]
		[ObsoletedOSPlatform ("tvos10.0", "Use 'DidStopRecording(RPScreenRecorder,RPPreviewViewController,NSError)' instead.")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'DidStopRecording(RPScreenRecorder,RPPreviewViewController,NSError)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidStopRecording(RPScreenRecorder,RPPreviewViewController,NSError)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStopRecording (RPScreenRecorder screenRecorder, NSError error, RPPreviewViewController? previewViewController)
		{
			_DidStopRecording (this, screenRecorder, error, previewViewController);
		}
		/// <param name="screenRecorder">To be added.</param><param name="error">To be added.</param><param name="previewViewController"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Developers should not use this deprecated method. Developers should use 'DidStopRecording(RPScreenRecorder,RPPreviewViewController,NSError)' instead.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("tvos10.0", "Use 'DidStopRecording(RPScreenRecorder,RPPreviewViewController,NSError)' instead.")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'DidStopRecording(RPScreenRecorder,RPPreviewViewController,NSError)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidStopRecording(RPScreenRecorder,RPPreviewViewController,NSError)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStopRecording (IRPScreenRecorderDelegate This, RPScreenRecorder screenRecorder, NSError error, RPPreviewViewController? previewViewController)
		{
			var screenRecorder__handle__ = screenRecorder!.GetNonNullHandle (nameof (screenRecorder));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var previewViewController__handle__ = previewViewController.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("screenRecorder:didStopRecordingWithError:previewViewController:"), screenRecorder__handle__, error__handle__, previewViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (screenRecorder);
			GC.KeepAlive (error);
			GC.KeepAlive (previewViewController);
		}
		/// <param name="screenRecorder">To be added.</param><param name="previewViewController"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("screenRecorder:didStopRecordingWithPreviewViewController:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStopRecording (RPScreenRecorder screenRecorder, RPPreviewViewController? previewViewController, NSError? error)
		{
			_DidStopRecording (this, screenRecorder, previewViewController, error);
		}
		/// <param name="screenRecorder">To be added.</param><param name="previewViewController"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStopRecording (IRPScreenRecorderDelegate This, RPScreenRecorder screenRecorder, RPPreviewViewController? previewViewController, NSError? error)
		{
			var screenRecorder__handle__ = screenRecorder!.GetNonNullHandle (nameof (screenRecorder));
			var previewViewController__handle__ = previewViewController.GetHandle ();
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("screenRecorder:didStopRecordingWithPreviewViewController:error:"), screenRecorder__handle__, previewViewController__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (screenRecorder);
			GC.KeepAlive (previewViewController);
			GC.KeepAlive (error);
		}
		/// <param name="screenRecorder">To be added.</param><summary>Method that is called when the availability status changes.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("screenRecorderDidChangeAvailability:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeAvailability (RPScreenRecorder screenRecorder)
		{
			_DidChangeAvailability (this, screenRecorder);
		}
		/// <param name="screenRecorder">To be added.</param><summary>Method that is called when the availability status changes.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeAvailability (IRPScreenRecorderDelegate This, RPScreenRecorder screenRecorder)
		{
			var screenRecorder__handle__ = screenRecorder!.GetNonNullHandle (nameof (screenRecorder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("screenRecorderDidChangeAvailability:"), screenRecorder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (screenRecorder);
		}
		[DynamicDependencyAttribute ("DidChangeAvailability(ReplayKit.RPScreenRecorder)")]
		[DynamicDependencyAttribute ("DidStopRecording(ReplayKit.RPScreenRecorder,Foundation.NSError,ReplayKit.RPPreviewViewController)")]
		[DynamicDependencyAttribute ("DidStopRecording(ReplayKit.RPScreenRecorder,ReplayKit.RPPreviewViewController,Foundation.NSError)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (RPScreenRecorderDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IRPScreenRecorderDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IRPScreenRecorderDelegate" /> interface to support all the methods from the RPScreenRecorderDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IRPScreenRecorderDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original RPScreenRecorderDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class RPScreenRecorderDelegate_Extensions {
		/// <param name="screenRecorder">To be added.</param><param name="error">To be added.</param><param name="previewViewController"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Developers should not use this deprecated method. Developers should use 'DidStopRecording(RPScreenRecorder,RPPreviewViewController,NSError)' instead.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("tvos10.0", "Use 'DidStopRecording(RPScreenRecorder,RPPreviewViewController,NSError)' instead.")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'DidStopRecording(RPScreenRecorder,RPPreviewViewController,NSError)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidStopRecording(RPScreenRecorder,RPPreviewViewController,NSError)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStopRecording (this IRPScreenRecorderDelegate This, RPScreenRecorder screenRecorder, NSError error, RPPreviewViewController? previewViewController)
		{
			var screenRecorder__handle__ = screenRecorder!.GetNonNullHandle (nameof (screenRecorder));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var previewViewController__handle__ = previewViewController.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("screenRecorder:didStopRecordingWithError:previewViewController:"), screenRecorder__handle__, error__handle__, previewViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (screenRecorder);
			GC.KeepAlive (error);
			GC.KeepAlive (previewViewController);
		}
		/// <param name="screenRecorder">To be added.</param><param name="previewViewController"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStopRecording (this IRPScreenRecorderDelegate This, RPScreenRecorder screenRecorder, RPPreviewViewController? previewViewController, NSError? error)
		{
			var screenRecorder__handle__ = screenRecorder!.GetNonNullHandle (nameof (screenRecorder));
			var previewViewController__handle__ = previewViewController.GetHandle ();
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("screenRecorder:didStopRecordingWithPreviewViewController:error:"), screenRecorder__handle__, previewViewController__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (screenRecorder);
			GC.KeepAlive (previewViewController);
			GC.KeepAlive (error);
		}
		/// <param name="screenRecorder">To be added.</param><summary>Method that is called when the availability status changes.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeAvailability (this IRPScreenRecorderDelegate This, RPScreenRecorder screenRecorder)
		{
			var screenRecorder__handle__ = screenRecorder!.GetNonNullHandle (nameof (screenRecorder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("screenRecorderDidChangeAvailability:"), screenRecorder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (screenRecorder);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class RPScreenRecorderDelegateWrapper : BaseWrapper, IRPScreenRecorderDelegate {
		public RPScreenRecorderDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (RPScreenRecorderDelegateWrapper))]
		static RPScreenRecorderDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace ReplayKit {
	/// <summary>Protocol for enabling the user to record visual and audio output of applications, with simultaneous recorded audio (screencasts)..</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ReplayKit/Reference/RPScreenRecorderDelegate_Ref/index.html">Apple documentation for <c>RPScreenRecorderDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__ReplayKit_RPScreenRecorderDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class RPScreenRecorderDelegate : NSObject, IRPScreenRecorderDelegate {
		/// <summary>Creates a new <see cref="RPScreenRecorderDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public RPScreenRecorderDelegate () : base (NSObjectFlag.Empty)
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
		protected RPScreenRecorderDelegate (NSObjectFlag t) : base (t)
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
		protected internal RPScreenRecorderDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="screenRecorder">To be added.</param><summary>Method that is called when the availability status changes.</summary><remarks>To be added.</remarks>
		[Export ("screenRecorderDidChangeAvailability:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeAvailability (RPScreenRecorder screenRecorder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="screenRecorder">To be added.</param><param name="error">To be added.</param><param name="previewViewController"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Developers should not use this deprecated method. Developers should use 'DidStopRecording(RPScreenRecorder,RPPreviewViewController,NSError)' instead.</summary><remarks>To be added.</remarks>
		[Export ("screenRecorder:didStopRecordingWithError:previewViewController:")]
		[ObsoletedOSPlatform ("tvos10.0", "Use 'DidStopRecording(RPScreenRecorder,RPPreviewViewController,NSError)' instead.")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'DidStopRecording(RPScreenRecorder,RPPreviewViewController,NSError)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidStopRecording(RPScreenRecorder,RPPreviewViewController,NSError)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStopRecording (RPScreenRecorder screenRecorder, NSError error, RPPreviewViewController? previewViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="screenRecorder">To be added.</param><param name="previewViewController"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("screenRecorder:didStopRecordingWithPreviewViewController:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStopRecording (RPScreenRecorder screenRecorder, RPPreviewViewController? previewViewController, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class RPScreenRecorderDelegate */
}
