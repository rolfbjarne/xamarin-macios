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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AVKit {
	#pragma warning disable CS1573
	/// <summary>Delegate object providing methods for the application's <see cref="T:AVKit.AVPictureInPictureController" /> at the start and stop of picture-in-picture video playback.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AVKit/Reference/AVPictureInPictureControllerDelegate_Protocol/index.html">Apple documentation for <c>AVPictureInPictureControllerDelegate</c></related>
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "AVPictureInPictureControllerDelegate", WrapperType = typeof (AVPictureInPictureControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStartPictureInPicture", Selector = "pictureInPictureControllerWillStartPictureInPicture:", ParameterType = new Type [] { typeof (AVKit.AVPictureInPictureController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStartPictureInPicture", Selector = "pictureInPictureControllerDidStartPictureInPicture:", ParameterType = new Type [] { typeof (AVKit.AVPictureInPictureController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToStartPictureInPicture", Selector = "pictureInPictureController:failedToStartPictureInPictureWithError:", ParameterType = new Type [] { typeof (AVKit.AVPictureInPictureController), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStopPictureInPicture", Selector = "pictureInPictureControllerWillStopPictureInPicture:", ParameterType = new Type [] { typeof (AVKit.AVPictureInPictureController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStopPictureInPicture", Selector = "pictureInPictureControllerDidStopPictureInPicture:", ParameterType = new Type [] { typeof (AVKit.AVPictureInPictureController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RestoreUserInterfaceForPictureInPicture", Selector = "pictureInPictureController:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:", ParameterType = new Type [] { typeof (AVKit.AVPictureInPictureController), typeof (global::System.Action<bool>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V2) })]
	public partial interface IAVPictureInPictureControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="pictureInPictureController">To be added.</param><summary>Picture In Picture playback is about to start.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pictureInPictureControllerWillStartPictureInPicture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartPictureInPicture (AVPictureInPictureController pictureInPictureController)
		{
			_WillStartPictureInPicture (this, pictureInPictureController);
		}
		/// <param name="pictureInPictureController">To be added.</param><summary>Picture In Picture playback is about to start.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillStartPictureInPicture (IAVPictureInPictureControllerDelegate This, AVPictureInPictureController pictureInPictureController)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pictureInPictureControllerWillStartPictureInPicture:"), pictureInPictureController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pictureInPictureController);
		}
		/// <param name="pictureInPictureController">To be added.</param><summary>Picture In Picture playback has started.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pictureInPictureControllerDidStartPictureInPicture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStartPictureInPicture (AVPictureInPictureController pictureInPictureController)
		{
			_DidStartPictureInPicture (this, pictureInPictureController);
		}
		/// <param name="pictureInPictureController">To be added.</param><summary>Picture In Picture playback has started.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStartPictureInPicture (IAVPictureInPictureControllerDelegate This, AVPictureInPictureController pictureInPictureController)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pictureInPictureControllerDidStartPictureInPicture:"), pictureInPictureController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pictureInPictureController);
		}
		/// <param name="pictureInPictureController">To be added.</param><param name="error">To be added.</param><summary>Picture In Picture playback failed to start.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pictureInPictureController:failedToStartPictureInPictureWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToStartPictureInPicture (AVPictureInPictureController pictureInPictureController, NSError error)
		{
			_FailedToStartPictureInPicture (this, pictureInPictureController, error);
		}
		/// <param name="pictureInPictureController">To be added.</param><param name="error">To be added.</param><summary>Picture In Picture playback failed to start.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedToStartPictureInPicture (IAVPictureInPictureControllerDelegate This, AVPictureInPictureController pictureInPictureController, NSError error)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pictureInPictureController:failedToStartPictureInPictureWithError:"), pictureInPictureController__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pictureInPictureController);
			GC.KeepAlive (error);
		}
		/// <param name="pictureInPictureController">To be added.</param><summary>Picture In Picture playback is about to stop.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pictureInPictureControllerWillStopPictureInPicture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStopPictureInPicture (AVPictureInPictureController pictureInPictureController)
		{
			_WillStopPictureInPicture (this, pictureInPictureController);
		}
		/// <param name="pictureInPictureController">To be added.</param><summary>Picture In Picture playback is about to stop.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillStopPictureInPicture (IAVPictureInPictureControllerDelegate This, AVPictureInPictureController pictureInPictureController)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pictureInPictureControllerWillStopPictureInPicture:"), pictureInPictureController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pictureInPictureController);
		}
		/// <param name="pictureInPictureController">To be added.</param><summary>Picture In Picture playback has stopped.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pictureInPictureControllerDidStopPictureInPicture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStopPictureInPicture (AVPictureInPictureController pictureInPictureController)
		{
			_DidStopPictureInPicture (this, pictureInPictureController);
		}
		/// <param name="pictureInPictureController">To be added.</param><summary>Picture In Picture playback has stopped.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStopPictureInPicture (IAVPictureInPictureControllerDelegate This, AVPictureInPictureController pictureInPictureController)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pictureInPictureControllerDidStopPictureInPicture:"), pictureInPictureController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pictureInPictureController);
		}
		/// <param name="pictureInPictureController">To be added.</param><param name="completionHandler">To be added.</param><summary>Picture In Picture playback is about to stop. Called to give the app the opportunity to provide a playback user interface by passing <see langword="true" /> to <paramref name="completionHandler" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pictureInPictureController:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RestoreUserInterfaceForPictureInPicture (AVPictureInPictureController pictureInPictureController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completionHandler)
		{
			_RestoreUserInterfaceForPictureInPicture (this, pictureInPictureController, completionHandler);
		}
		/// <param name="pictureInPictureController">To be added.</param><param name="completionHandler">To be added.</param><summary>Picture In Picture playback is about to stop. Called to give the app the opportunity to provide a playback user interface by passing <see langword="true" /> to <paramref name="completionHandler" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RestoreUserInterfaceForPictureInPicture (IAVPictureInPictureControllerDelegate This, AVPictureInPictureController pictureInPictureController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completionHandler)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V2.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pictureInPictureController:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:"), pictureInPictureController__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (pictureInPictureController);
		}
		[DynamicDependencyAttribute ("DidStartPictureInPicture(AVKit.AVPictureInPictureController)")]
		[DynamicDependencyAttribute ("DidStopPictureInPicture(AVKit.AVPictureInPictureController)")]
		[DynamicDependencyAttribute ("FailedToStartPictureInPicture(AVKit.AVPictureInPictureController,Foundation.NSError)")]
		[DynamicDependencyAttribute ("RestoreUserInterfaceForPictureInPicture(AVKit.AVPictureInPictureController,System.Action{System.Boolean})")]
		[DynamicDependencyAttribute ("WillStartPictureInPicture(AVKit.AVPictureInPictureController)")]
		[DynamicDependencyAttribute ("WillStopPictureInPicture(AVKit.AVPictureInPictureController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVPictureInPictureControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVPictureInPictureControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVPictureInPictureControllerDelegate" /> interface to support all the methods from the AVPictureInPictureControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVPictureInPictureControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVPictureInPictureControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVPictureInPictureControllerDelegate_Extensions {
		/// <param name="pictureInPictureController">To be added.</param><summary>Picture In Picture playback is about to start.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillStartPictureInPicture (this IAVPictureInPictureControllerDelegate This, AVPictureInPictureController pictureInPictureController)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pictureInPictureControllerWillStartPictureInPicture:"), pictureInPictureController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pictureInPictureController);
		}
		/// <param name="pictureInPictureController">To be added.</param><summary>Picture In Picture playback has started.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStartPictureInPicture (this IAVPictureInPictureControllerDelegate This, AVPictureInPictureController pictureInPictureController)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pictureInPictureControllerDidStartPictureInPicture:"), pictureInPictureController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pictureInPictureController);
		}
		/// <param name="pictureInPictureController">To be added.</param><param name="error">To be added.</param><summary>Picture In Picture playback failed to start.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedToStartPictureInPicture (this IAVPictureInPictureControllerDelegate This, AVPictureInPictureController pictureInPictureController, NSError error)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pictureInPictureController:failedToStartPictureInPictureWithError:"), pictureInPictureController__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pictureInPictureController);
			GC.KeepAlive (error);
		}
		/// <param name="pictureInPictureController">To be added.</param><summary>Picture In Picture playback is about to stop.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillStopPictureInPicture (this IAVPictureInPictureControllerDelegate This, AVPictureInPictureController pictureInPictureController)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pictureInPictureControllerWillStopPictureInPicture:"), pictureInPictureController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pictureInPictureController);
		}
		/// <param name="pictureInPictureController">To be added.</param><summary>Picture In Picture playback has stopped.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStopPictureInPicture (this IAVPictureInPictureControllerDelegate This, AVPictureInPictureController pictureInPictureController)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pictureInPictureControllerDidStopPictureInPicture:"), pictureInPictureController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pictureInPictureController);
		}
		/// <param name="pictureInPictureController">To be added.</param><param name="completionHandler">To be added.</param><summary>Picture In Picture playback is about to stop. Called to give the app the opportunity to provide a playback user interface by passing <see langword="true" /> to <paramref name="completionHandler" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RestoreUserInterfaceForPictureInPicture (this IAVPictureInPictureControllerDelegate This, AVPictureInPictureController pictureInPictureController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completionHandler)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V2.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pictureInPictureController:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:"), pictureInPictureController__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (pictureInPictureController);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVPictureInPictureControllerDelegateWrapper : BaseWrapper, IAVPictureInPictureControllerDelegate {
		public AVPictureInPictureControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVPictureInPictureControllerDelegateWrapper))]
		static AVPictureInPictureControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AVKit {
	/// <summary>Delegate object providing methods for the application's <see cref="T:AVKit.AVPictureInPictureController" /> at the start and stop of picture-in-picture video playback.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AVKit/Reference/AVPictureInPictureControllerDelegate_Protocol/index.html">Apple documentation for <c>AVPictureInPictureControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__AVKit_AVPictureInPictureControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AVPictureInPictureControllerDelegate : NSObject, IAVPictureInPictureControllerDelegate {
		/// <summary>Creates a new <see cref="AVPictureInPictureControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVPictureInPictureControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected AVPictureInPictureControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVPictureInPictureControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="pictureInPictureController">To be added.</param><summary>Picture In Picture playback has started.</summary><remarks>To be added.</remarks>
		[Export ("pictureInPictureControllerDidStartPictureInPicture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStartPictureInPicture (AVPictureInPictureController pictureInPictureController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pictureInPictureController">To be added.</param><summary>Picture In Picture playback has stopped.</summary><remarks>To be added.</remarks>
		[Export ("pictureInPictureControllerDidStopPictureInPicture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStopPictureInPicture (AVPictureInPictureController pictureInPictureController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pictureInPictureController">To be added.</param><param name="error">To be added.</param><summary>Picture In Picture playback failed to start.</summary><remarks>To be added.</remarks>
		[Export ("pictureInPictureController:failedToStartPictureInPictureWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToStartPictureInPicture (AVPictureInPictureController pictureInPictureController, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pictureInPictureController">To be added.</param><param name="completionHandler">To be added.</param><summary>Picture In Picture playback is about to stop. Called to give the app the opportunity to provide a playback user interface by passing <see langword="true" /> to <paramref name="completionHandler" />.</summary><remarks>To be added.</remarks>
		[Export ("pictureInPictureController:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RestoreUserInterfaceForPictureInPicture (AVPictureInPictureController pictureInPictureController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pictureInPictureController">To be added.</param><summary>Picture In Picture playback is about to start.</summary><remarks>To be added.</remarks>
		[Export ("pictureInPictureControllerWillStartPictureInPicture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartPictureInPicture (AVPictureInPictureController pictureInPictureController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pictureInPictureController">To be added.</param><summary>Picture In Picture playback is about to stop.</summary><remarks>To be added.</remarks>
		[Export ("pictureInPictureControllerWillStopPictureInPicture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStopPictureInPicture (AVPictureInPictureController pictureInPictureController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVPictureInPictureControllerDelegate */
}
