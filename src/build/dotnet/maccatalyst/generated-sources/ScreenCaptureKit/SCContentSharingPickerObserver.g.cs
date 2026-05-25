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
namespace ScreenCaptureKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>SCContentSharingPickerObserver</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("maccatalyst18.2")]
	[Protocol (Name = "SCContentSharingPickerObserver", WrapperType = typeof (SCContentSharingPickerObserverWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidCancel", Selector = "contentSharingPicker:didCancelForStream:", ParameterType = new Type [] { typeof (ScreenCaptureKit.SCContentSharingPicker), typeof (ScreenCaptureKit.SCStream) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidUpdate", Selector = "contentSharingPicker:didUpdateWithFilter:forStream:", ParameterType = new Type [] { typeof (ScreenCaptureKit.SCContentSharingPicker), typeof (ScreenCaptureKit.SCContentFilter), typeof (ScreenCaptureKit.SCStream) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFail", Selector = "contentSharingPickerStartDidFailWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	public partial interface ISCContentSharingPickerObserver : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("contentSharingPicker:didCancelForStream:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancel (SCContentSharingPicker picker, SCStream? stream)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCancel (ISCContentSharingPickerObserver This, SCContentSharingPicker picker, SCStream? stream)
		{
			var picker__handle__ = picker!.GetNonNullHandle (nameof (picker));
			var stream__handle__ = stream.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentSharingPicker:didCancelForStream:"), picker__handle__, stream__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (picker);
			GC.KeepAlive (stream);
		}
		[global::Foundation.RequiredMember]
		[Export ("contentSharingPicker:didUpdateWithFilter:forStream:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdate (SCContentSharingPicker picker, SCContentFilter filter, SCStream? stream)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdate (ISCContentSharingPickerObserver This, SCContentSharingPicker picker, SCContentFilter filter, SCStream? stream)
		{
			var picker__handle__ = picker!.GetNonNullHandle (nameof (picker));
			var filter__handle__ = filter!.GetNonNullHandle (nameof (filter));
			var stream__handle__ = stream.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentSharingPicker:didUpdateWithFilter:forStream:"), picker__handle__, filter__handle__, stream__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (picker);
			GC.KeepAlive (filter);
			GC.KeepAlive (stream);
		}
		[global::Foundation.RequiredMember]
		[Export ("contentSharingPickerStartDidFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFail (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFail (ISCContentSharingPickerObserver This, NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("contentSharingPickerStartDidFailWithError:"), error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("DidCancel(ScreenCaptureKit.SCContentSharingPicker,ScreenCaptureKit.SCStream)")]
		[DynamicDependencyAttribute ("DidFail(Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidUpdate(ScreenCaptureKit.SCContentSharingPicker,ScreenCaptureKit.SCContentFilter,ScreenCaptureKit.SCStream)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCContentSharingPickerObserverWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISCContentSharingPickerObserver ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SCContentSharingPickerObserverWrapper : BaseWrapper, ISCContentSharingPickerObserver {
		public SCContentSharingPickerObserverWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCContentSharingPickerObserverWrapper))]
		static SCContentSharingPickerObserverWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("contentSharingPicker:didCancelForStream:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidCancel (SCContentSharingPicker picker, SCStream? stream)
		{
			var picker__handle__ = picker!.GetNonNullHandle (nameof (picker));
			var stream__handle__ = stream.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("contentSharingPicker:didCancelForStream:"), picker__handle__, stream__handle__);
			GC.KeepAlive (picker);
			GC.KeepAlive (stream);
		}
		[Export ("contentSharingPicker:didUpdateWithFilter:forStream:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidUpdate (SCContentSharingPicker picker, SCContentFilter filter, SCStream? stream)
		{
			var picker__handle__ = picker!.GetNonNullHandle (nameof (picker));
			var filter__handle__ = filter!.GetNonNullHandle (nameof (filter));
			var stream__handle__ = stream.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("contentSharingPicker:didUpdateWithFilter:forStream:"), picker__handle__, filter__handle__, stream__handle__);
			GC.KeepAlive (picker);
			GC.KeepAlive (filter);
			GC.KeepAlive (stream);
		}
		[Export ("contentSharingPickerStartDidFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFail (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("contentSharingPickerStartDidFailWithError:"), error__handle__);
			GC.KeepAlive (error);
		}
	}
}
namespace ScreenCaptureKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="ISCContentSharingPickerObserver" /> (for the protocol <c>SCContentSharingPickerObserver</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="ISCContentSharingPickerObserver" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__ScreenCaptureKit_SCContentSharingPickerObserver", false)]
	[Model]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("maccatalyst18.2")]
	public unsafe abstract partial class SCContentSharingPickerObserver : NSObject, ISCContentSharingPickerObserver {
		/// <summary>Creates a new <see cref="SCContentSharingPickerObserver" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SCContentSharingPickerObserver () : base (NSObjectFlag.Empty)
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
		protected SCContentSharingPickerObserver (NSObjectFlag t) : base (t)
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
		protected internal SCContentSharingPickerObserver (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("contentSharingPicker:didCancelForStream:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancel (SCContentSharingPicker picker, SCStream? stream)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("contentSharingPickerStartDidFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFail (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("contentSharingPicker:didUpdateWithFilter:forStream:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdate (SCContentSharingPicker picker, SCContentFilter filter, SCStream? stream)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SCContentSharingPickerObserver */
}
