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
namespace CoreMotion {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CMWaterSubmersionManagerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios16.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[Protocol (Name = "CMWaterSubmersionManagerDelegate", WrapperType = typeof (CMWaterSubmersionManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidUpdateEvent", Selector = "manager:didUpdateEvent:", ParameterType = new Type [] { typeof (CMWaterSubmersionManager), typeof (CMWaterSubmersionEvent) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidUpdateMeasurement", Selector = "manager:didUpdateMeasurement:", ParameterType = new Type [] { typeof (CMWaterSubmersionManager), typeof (CMWaterSubmersionMeasurement) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidUpdateTemperature", Selector = "manager:didUpdateTemperature:", ParameterType = new Type [] { typeof (CMWaterSubmersionManager), typeof (CMWaterTemperature) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ErrorOccurred", Selector = "manager:errorOccurred:", ParameterType = new Type [] { typeof (CMWaterSubmersionManager), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ICMWaterSubmersionManagerDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("manager:didUpdateEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateEvent (CMWaterSubmersionManager manager, CMWaterSubmersionEvent @event)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateEvent (ICMWaterSubmersionManagerDelegate This, CMWaterSubmersionManager manager, CMWaterSubmersionEvent @event)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("manager:didUpdateEvent:"), manager__handle__, @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (@event);
		}
		[global::Foundation.RequiredMember]
		[Export ("manager:didUpdateMeasurement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateMeasurement (CMWaterSubmersionManager manager, CMWaterSubmersionMeasurement measurement)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateMeasurement (ICMWaterSubmersionManagerDelegate This, CMWaterSubmersionManager manager, CMWaterSubmersionMeasurement measurement)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var measurement__handle__ = measurement!.GetNonNullHandle (nameof (measurement));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("manager:didUpdateMeasurement:"), manager__handle__, measurement__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (measurement);
		}
		[global::Foundation.RequiredMember]
		[Export ("manager:didUpdateTemperature:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateTemperature (CMWaterSubmersionManager manager, CMWaterTemperature measurement)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateTemperature (ICMWaterSubmersionManagerDelegate This, CMWaterSubmersionManager manager, CMWaterTemperature measurement)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var measurement__handle__ = measurement!.GetNonNullHandle (nameof (measurement));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("manager:didUpdateTemperature:"), manager__handle__, measurement__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (measurement);
		}
		[global::Foundation.RequiredMember]
		[Export ("manager:errorOccurred:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ErrorOccurred (CMWaterSubmersionManager manager, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ErrorOccurred (ICMWaterSubmersionManagerDelegate This, CMWaterSubmersionManager manager, NSError error)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("manager:errorOccurred:"), manager__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("DidUpdateEvent(CoreMotion.CMWaterSubmersionManager,CoreMotion.CMWaterSubmersionEvent)")]
		[DynamicDependencyAttribute ("DidUpdateMeasurement(CoreMotion.CMWaterSubmersionManager,CoreMotion.CMWaterSubmersionMeasurement)")]
		[DynamicDependencyAttribute ("DidUpdateTemperature(CoreMotion.CMWaterSubmersionManager,CoreMotion.CMWaterTemperature)")]
		[DynamicDependencyAttribute ("ErrorOccurred(CoreMotion.CMWaterSubmersionManager,Foundation.NSError)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CMWaterSubmersionManagerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICMWaterSubmersionManagerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CMWaterSubmersionManagerDelegateWrapper : BaseWrapper, ICMWaterSubmersionManagerDelegate {
		public CMWaterSubmersionManagerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CMWaterSubmersionManagerDelegateWrapper))]
		static CMWaterSubmersionManagerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("manager:didUpdateEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidUpdateEvent (CMWaterSubmersionManager manager, CMWaterSubmersionEvent @event)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("manager:didUpdateEvent:"), manager__handle__, @event__handle__);
			GC.KeepAlive (manager);
			GC.KeepAlive (@event);
		}
		[Export ("manager:didUpdateMeasurement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidUpdateMeasurement (CMWaterSubmersionManager manager, CMWaterSubmersionMeasurement measurement)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var measurement__handle__ = measurement!.GetNonNullHandle (nameof (measurement));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("manager:didUpdateMeasurement:"), manager__handle__, measurement__handle__);
			GC.KeepAlive (manager);
			GC.KeepAlive (measurement);
		}
		[Export ("manager:didUpdateTemperature:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidUpdateTemperature (CMWaterSubmersionManager manager, CMWaterTemperature measurement)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var measurement__handle__ = measurement!.GetNonNullHandle (nameof (measurement));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("manager:didUpdateTemperature:"), manager__handle__, measurement__handle__);
			GC.KeepAlive (manager);
			GC.KeepAlive (measurement);
		}
		[Export ("manager:errorOccurred:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ErrorOccurred (CMWaterSubmersionManager manager, NSError error)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("manager:errorOccurred:"), manager__handle__, error__handle__);
			GC.KeepAlive (manager);
			GC.KeepAlive (error);
		}
	}
}
namespace CoreMotion {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="ICMWaterSubmersionManagerDelegate" /> (for the protocol <c>CMWaterSubmersionManagerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="ICMWaterSubmersionManagerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__CoreMotion_CMWaterSubmersionManagerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios16.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	public unsafe abstract partial class CMWaterSubmersionManagerDelegate : NSObject, ICMWaterSubmersionManagerDelegate {
		/// <summary>Creates a new <see cref="CMWaterSubmersionManagerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CMWaterSubmersionManagerDelegate () : base (NSObjectFlag.Empty)
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
		protected CMWaterSubmersionManagerDelegate (NSObjectFlag t) : base (t)
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
		protected internal CMWaterSubmersionManagerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("manager:didUpdateEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateEvent (CMWaterSubmersionManager manager, CMWaterSubmersionEvent @event)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("manager:didUpdateMeasurement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateMeasurement (CMWaterSubmersionManager manager, CMWaterSubmersionMeasurement measurement)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("manager:didUpdateTemperature:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateTemperature (CMWaterSubmersionManager manager, CMWaterTemperature measurement)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("manager:errorOccurred:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ErrorOccurred (CMWaterSubmersionManager manager, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CMWaterSubmersionManagerDelegate */
}
