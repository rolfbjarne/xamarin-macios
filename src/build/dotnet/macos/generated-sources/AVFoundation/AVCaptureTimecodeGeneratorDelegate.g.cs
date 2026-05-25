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
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AVCaptureTimecodeGeneratorDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[Protocol (Name = "AVCaptureTimecodeGeneratorDelegate", WrapperType = typeof (AVCaptureTimecodeGeneratorDelegateWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveUpdate", Selector = "timecodeGenerator:didReceiveUpdate:fromSource:", ParameterType = new Type [] { typeof (AVCaptureTimecodeGenerator), typeof (AVCaptureTimecode), typeof (AVCaptureTimecodeSource) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "TransitionedToSynchronizationStatus", Selector = "timecodeGenerator:transitionedToSynchronizationStatus:forSource:", ParameterType = new Type [] { typeof (AVCaptureTimecodeGenerator), typeof (AVCaptureTimecodeGeneratorSynchronizationStatus), typeof (AVCaptureTimecodeSource) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidUpdateAvailableSources", Selector = "timecodeGenerator:didUpdateAvailableSources:", ParameterType = new Type [] { typeof (AVCaptureTimecodeGenerator), typeof (AVCaptureTimecodeSource[]) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IAVCaptureTimecodeGeneratorDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("timecodeGenerator:didReceiveUpdate:fromSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveUpdate (AVCaptureTimecodeGenerator generator, AVCaptureTimecode timecode, AVCaptureTimecodeSource source)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveUpdate (IAVCaptureTimecodeGeneratorDelegate This, AVCaptureTimecodeGenerator generator, AVCaptureTimecode timecode, AVCaptureTimecodeSource source)
		{
			var generator__handle__ = generator!.GetNonNullHandle (nameof (generator));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_AVCaptureTimecode_NativeHandle (This.Handle, Selector.GetHandle ("timecodeGenerator:didReceiveUpdate:fromSource:"), generator__handle__, timecode, source__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (generator);
			GC.KeepAlive (source);
		}
		[global::Foundation.RequiredMember]
		[Export ("timecodeGenerator:transitionedToSynchronizationStatus:forSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TransitionedToSynchronizationStatus (AVCaptureTimecodeGenerator generator, AVCaptureTimecodeGeneratorSynchronizationStatus synchronizationStatus, AVCaptureTimecodeSource source)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _TransitionedToSynchronizationStatus (IAVCaptureTimecodeGeneratorDelegate This, AVCaptureTimecodeGenerator generator, AVCaptureTimecodeGeneratorSynchronizationStatus synchronizationStatus, AVCaptureTimecodeSource source)
		{
			var generator__handle__ = generator!.GetNonNullHandle (nameof (generator));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("timecodeGenerator:transitionedToSynchronizationStatus:forSource:"), generator__handle__, (IntPtr) (long) synchronizationStatus, source__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (generator);
			GC.KeepAlive (source);
		}
		[global::Foundation.RequiredMember]
		[Export ("timecodeGenerator:didUpdateAvailableSources:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateAvailableSources (AVCaptureTimecodeGenerator generator, AVCaptureTimecodeSource[] availableSources)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateAvailableSources (IAVCaptureTimecodeGeneratorDelegate This, AVCaptureTimecodeGenerator generator, AVCaptureTimecodeSource[] availableSources)
		{
			var generator__handle__ = generator!.GetNonNullHandle (nameof (generator));
			if (availableSources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (availableSources));
			using var nsa_availableSources = NSArray.FromNSObjects (availableSources);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("timecodeGenerator:didUpdateAvailableSources:"), generator__handle__, nsa_availableSources.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (generator);
		}
		[DynamicDependencyAttribute ("DidReceiveUpdate(AVFoundation.AVCaptureTimecodeGenerator,AVFoundation.AVCaptureTimecode,AVFoundation.AVCaptureTimecodeSource)")]
		[DynamicDependencyAttribute ("DidUpdateAvailableSources(AVFoundation.AVCaptureTimecodeGenerator,AVFoundation.AVCaptureTimecodeSource[])")]
		[DynamicDependencyAttribute ("TransitionedToSynchronizationStatus(AVFoundation.AVCaptureTimecodeGenerator,AVFoundation.AVCaptureTimecodeGeneratorSynchronizationStatus,AVFoundation.AVCaptureTimecodeSource)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVCaptureTimecodeGeneratorDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVCaptureTimecodeGeneratorDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVCaptureTimecodeGeneratorDelegateWrapper : BaseWrapper, IAVCaptureTimecodeGeneratorDelegate {
		public AVCaptureTimecodeGeneratorDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVCaptureTimecodeGeneratorDelegateWrapper))]
		static AVCaptureTimecodeGeneratorDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("timecodeGenerator:didReceiveUpdate:fromSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReceiveUpdate (AVCaptureTimecodeGenerator generator, AVCaptureTimecode timecode, AVCaptureTimecodeSource source)
		{
			var generator__handle__ = generator!.GetNonNullHandle (nameof (generator));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_AVCaptureTimecode_NativeHandle (this.Handle, Selector.GetHandle ("timecodeGenerator:didReceiveUpdate:fromSource:"), generator__handle__, timecode, source__handle__);
			GC.KeepAlive (generator);
			GC.KeepAlive (source);
		}
		[Export ("timecodeGenerator:transitionedToSynchronizationStatus:forSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void TransitionedToSynchronizationStatus (AVCaptureTimecodeGenerator generator, AVCaptureTimecodeGeneratorSynchronizationStatus synchronizationStatus, AVCaptureTimecodeSource source)
		{
			var generator__handle__ = generator!.GetNonNullHandle (nameof (generator));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("timecodeGenerator:transitionedToSynchronizationStatus:forSource:"), generator__handle__, (IntPtr) (long) synchronizationStatus, source__handle__);
			GC.KeepAlive (generator);
			GC.KeepAlive (source);
		}
		[Export ("timecodeGenerator:didUpdateAvailableSources:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidUpdateAvailableSources (AVCaptureTimecodeGenerator generator, AVCaptureTimecodeSource[] availableSources)
		{
			var generator__handle__ = generator!.GetNonNullHandle (nameof (generator));
			if (availableSources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (availableSources));
			using var nsa_availableSources = NSArray.FromNSObjects (availableSources);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("timecodeGenerator:didUpdateAvailableSources:"), generator__handle__, nsa_availableSources.Handle);
			GC.KeepAlive (generator);
		}
	}
}
namespace AVFoundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IAVCaptureTimecodeGeneratorDelegate" /> (for the protocol <c>AVCaptureTimecodeGeneratorDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IAVCaptureTimecodeGeneratorDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AVFoundation_AVCaptureTimecodeGeneratorDelegate", false)]
	[Model]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public unsafe abstract partial class AVCaptureTimecodeGeneratorDelegate : NSObject, IAVCaptureTimecodeGeneratorDelegate {
		/// <summary>Creates a new <see cref="AVCaptureTimecodeGeneratorDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AVCaptureTimecodeGeneratorDelegate () : base (NSObjectFlag.Empty)
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
		protected AVCaptureTimecodeGeneratorDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVCaptureTimecodeGeneratorDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("timecodeGenerator:didReceiveUpdate:fromSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveUpdate (AVCaptureTimecodeGenerator generator, AVCaptureTimecode timecode, AVCaptureTimecodeSource source)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("timecodeGenerator:didUpdateAvailableSources:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateAvailableSources (AVCaptureTimecodeGenerator generator, AVCaptureTimecodeSource[] availableSources)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("timecodeGenerator:transitionedToSynchronizationStatus:forSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TransitionedToSynchronizationStatus (AVCaptureTimecodeGenerator generator, AVCaptureTimecodeGeneratorSynchronizationStatus synchronizationStatus, AVCaptureTimecodeSource source)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVCaptureTimecodeGeneratorDelegate */
}
