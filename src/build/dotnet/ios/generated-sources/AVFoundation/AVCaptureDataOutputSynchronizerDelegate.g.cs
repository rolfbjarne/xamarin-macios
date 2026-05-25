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
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>Delegate for receiving synchronized data for a <see cref="T:AVFoundation.AVCaptureDataOutputSynchronizer" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "AVCaptureDataOutputSynchronizerDelegate", WrapperType = typeof (AVCaptureDataOutputSynchronizerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidOutputSynchronizedDataCollection", Selector = "dataOutputSynchronizer:didOutputSynchronizedDataCollection:", ParameterType = new Type [] { typeof (AVCaptureDataOutputSynchronizer), typeof (AVCaptureSynchronizedDataCollection) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IAVCaptureDataOutputSynchronizerDelegate : INativeObject, IDisposable
	{
		/// <param name="synchronizer">The synchronizer that provided the data.</param><param name="synchronizedDataCollection">The collection of synchronized data.</param><summary>Developers implement this method to respond when collections of synchronized capture data arrive.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("dataOutputSynchronizer:didOutputSynchronizedDataCollection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOutputSynchronizedDataCollection (AVCaptureDataOutputSynchronizer synchronizer, AVCaptureSynchronizedDataCollection synchronizedDataCollection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="synchronizer">The synchronizer that provided the data.</param><param name="synchronizedDataCollection">The collection of synchronized data.</param><summary>Developers implement this method to respond when collections of synchronized capture data arrive.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidOutputSynchronizedDataCollection (IAVCaptureDataOutputSynchronizerDelegate This, AVCaptureDataOutputSynchronizer synchronizer, AVCaptureSynchronizedDataCollection synchronizedDataCollection)
		{
			var synchronizer__handle__ = synchronizer!.GetNonNullHandle (nameof (synchronizer));
			var synchronizedDataCollection__handle__ = synchronizedDataCollection!.GetNonNullHandle (nameof (synchronizedDataCollection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dataOutputSynchronizer:didOutputSynchronizedDataCollection:"), synchronizer__handle__, synchronizedDataCollection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (synchronizer);
			GC.KeepAlive (synchronizedDataCollection);
		}
		[DynamicDependencyAttribute ("DidOutputSynchronizedDataCollection(AVFoundation.AVCaptureDataOutputSynchronizer,AVFoundation.AVCaptureSynchronizedDataCollection)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVCaptureDataOutputSynchronizerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVCaptureDataOutputSynchronizerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVCaptureDataOutputSynchronizerDelegateWrapper : BaseWrapper, IAVCaptureDataOutputSynchronizerDelegate {
		public AVCaptureDataOutputSynchronizerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVCaptureDataOutputSynchronizerDelegateWrapper))]
		static AVCaptureDataOutputSynchronizerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="synchronizer">The synchronizer that provided the data.</param><param name="synchronizedDataCollection">The collection of synchronized data.</param><summary>Developers implement this method to respond when collections of synchronized capture data arrive.</summary><remarks>To be added.</remarks>
		[Export ("dataOutputSynchronizer:didOutputSynchronizedDataCollection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidOutputSynchronizedDataCollection (AVCaptureDataOutputSynchronizer synchronizer, AVCaptureSynchronizedDataCollection synchronizedDataCollection)
		{
			var synchronizer__handle__ = synchronizer!.GetNonNullHandle (nameof (synchronizer));
			var synchronizedDataCollection__handle__ = synchronizedDataCollection!.GetNonNullHandle (nameof (synchronizedDataCollection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("dataOutputSynchronizer:didOutputSynchronizedDataCollection:"), synchronizer__handle__, synchronizedDataCollection__handle__);
			GC.KeepAlive (synchronizer);
			GC.KeepAlive (synchronizedDataCollection);
		}
	}
}
namespace AVFoundation {
	/// <summary>Delegate for receiving synchronized data for a <see cref="T:AVFoundation.AVCaptureDataOutputSynchronizer" />.</summary>
	[Protocol()]
	[Register("Microsoft_iOS__AVFoundation_AVCaptureDataOutputSynchronizerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class AVCaptureDataOutputSynchronizerDelegate : NSObject, IAVCaptureDataOutputSynchronizerDelegate {
		/// <summary>Creates a new <see cref="AVCaptureDataOutputSynchronizerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AVCaptureDataOutputSynchronizerDelegate () : base (NSObjectFlag.Empty)
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
		protected AVCaptureDataOutputSynchronizerDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVCaptureDataOutputSynchronizerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="synchronizer">The synchronizer that provided the data.</param><param name="synchronizedDataCollection">The collection of synchronized data.</param><summary>Developers implement this method to respond when collections of synchronized capture data arrive.</summary><remarks>To be added.</remarks>
		[Export ("dataOutputSynchronizer:didOutputSynchronizedDataCollection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOutputSynchronizedDataCollection (AVCaptureDataOutputSynchronizer synchronizer, AVCaptureSynchronizedDataCollection synchronizedDataCollection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVCaptureDataOutputSynchronizerDelegate */
}
