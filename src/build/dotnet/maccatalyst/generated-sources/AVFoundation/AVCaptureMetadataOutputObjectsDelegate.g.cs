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
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>A delegate object that allows the application developer to respond to the arrival of metadata capture objects.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AVFoundation/Reference/AVCaptureMetadataOutputObjectsDelegate_Protocol/index.html">Apple documentation for <c>AVCaptureMetadataOutputObjectsDelegate</c></related>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "AVCaptureMetadataOutputObjectsDelegate", WrapperType = typeof (AVCaptureMetadataOutputObjectsDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOutputMetadataObjects", Selector = "captureOutput:didOutputMetadataObjects:fromConnection:", ParameterType = new Type [] { typeof (AVCaptureMetadataOutput), typeof (AVMetadataObject[]), typeof (AVCaptureConnection) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IAVCaptureMetadataOutputObjectsDelegate : INativeObject, IDisposable
	{
		/// <param name="captureOutput">To be added.</param><param name="metadataObjects">To be added.</param><param name="connection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("captureOutput:didOutputMetadataObjects:fromConnection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOutputMetadataObjects (AVCaptureMetadataOutput captureOutput, AVMetadataObject[] metadataObjects, AVCaptureConnection connection)
		{
			_DidOutputMetadataObjects (this, captureOutput, metadataObjects, connection);
		}
		/// <param name="captureOutput">To be added.</param><param name="metadataObjects">To be added.</param><param name="connection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidOutputMetadataObjects (IAVCaptureMetadataOutputObjectsDelegate This, AVCaptureMetadataOutput captureOutput, AVMetadataObject[] metadataObjects, AVCaptureConnection connection)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			if (metadataObjects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (metadataObjects));
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			using var nsa_metadataObjects = NSArray.FromNSObjects (metadataObjects);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didOutputMetadataObjects:fromConnection:"), captureOutput__handle__, nsa_metadataObjects.Handle, connection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (connection);
		}
		[DynamicDependencyAttribute ("DidOutputMetadataObjects(AVFoundation.AVCaptureMetadataOutput,AVFoundation.AVMetadataObject[],AVFoundation.AVCaptureConnection)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVCaptureMetadataOutputObjectsDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVCaptureMetadataOutputObjectsDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVCaptureMetadataOutputObjectsDelegate" /> interface to support all the methods from the AVCaptureMetadataOutputObjectsDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVCaptureMetadataOutputObjectsDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVCaptureMetadataOutputObjectsDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVCaptureMetadataOutputObjectsDelegate_Extensions {
		/// <param name="captureOutput">To be added.</param><param name="metadataObjects">To be added.</param><param name="connection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidOutputMetadataObjects (this IAVCaptureMetadataOutputObjectsDelegate This, AVCaptureMetadataOutput captureOutput, AVMetadataObject[] metadataObjects, AVCaptureConnection connection)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			if (metadataObjects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (metadataObjects));
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			using var nsa_metadataObjects = NSArray.FromNSObjects (metadataObjects);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didOutputMetadataObjects:fromConnection:"), captureOutput__handle__, nsa_metadataObjects.Handle, connection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (connection);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVCaptureMetadataOutputObjectsDelegateWrapper : BaseWrapper, IAVCaptureMetadataOutputObjectsDelegate {
		public AVCaptureMetadataOutputObjectsDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVCaptureMetadataOutputObjectsDelegateWrapper))]
		static AVCaptureMetadataOutputObjectsDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AVFoundation {
	/// <summary>A delegate object that allows the application developer to respond to the arrival of metadata capture objects.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AVFoundation/Reference/AVCaptureMetadataOutputObjectsDelegate_Protocol/index.html">Apple documentation for <c>AVCaptureMetadataOutputObjectsDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__AVFoundation_AVCaptureMetadataOutputObjectsDelegate", false)]
	[Model]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class AVCaptureMetadataOutputObjectsDelegate : NSObject, IAVCaptureMetadataOutputObjectsDelegate {
		/// <summary>Creates a new <see cref="AVCaptureMetadataOutputObjectsDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVCaptureMetadataOutputObjectsDelegate () : base (NSObjectFlag.Empty)
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
		protected AVCaptureMetadataOutputObjectsDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVCaptureMetadataOutputObjectsDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="captureOutput">To be added.</param><param name="metadataObjects">To be added.</param><param name="connection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("captureOutput:didOutputMetadataObjects:fromConnection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOutputMetadataObjects (AVCaptureMetadataOutput captureOutput, AVMetadataObject[] metadataObjects, AVCaptureConnection connection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVCaptureMetadataOutputObjectsDelegate */
}
