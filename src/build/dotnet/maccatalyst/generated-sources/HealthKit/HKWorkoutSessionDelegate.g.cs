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
namespace HealthKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>HKWorkoutSessionDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[Protocol (Name = "HKWorkoutSessionDelegate", WrapperType = typeof (HKWorkoutSessionDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidChangeToState", Selector = "workoutSession:didChangeToState:fromState:date:", ParameterType = new Type [] { typeof (HealthKit.HKWorkoutSession), typeof (HealthKit.HKWorkoutSessionState), typeof (HealthKit.HKWorkoutSessionState), typeof (NSDate) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFail", Selector = "workoutSession:didFailWithError:", ParameterType = new Type [] { typeof (HealthKit.HKWorkoutSession), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidGenerateEvent", Selector = "workoutSession:didGenerateEvent:", ParameterType = new Type [] { typeof (HealthKit.HKWorkoutSession), typeof (HealthKit.HKWorkoutEvent) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBeginActivity", Selector = "workoutSession:didBeginActivityWithConfiguration:date:", ParameterType = new Type [] { typeof (HealthKit.HKWorkoutSession), typeof (HealthKit.HKWorkoutConfiguration), typeof (NSDate) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndActivity", Selector = "workoutSession:didEndActivityWithConfiguration:date:", ParameterType = new Type [] { typeof (HealthKit.HKWorkoutSession), typeof (HealthKit.HKWorkoutConfiguration), typeof (NSDate) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveData", Selector = "workoutSession:didReceiveDataFromRemoteWorkoutSession:", ParameterType = new Type [] { typeof (HealthKit.HKWorkoutSession), typeof (NSData[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDisconnect", Selector = "workoutSession:didDisconnectFromRemoteDeviceWithError:", ParameterType = new Type [] { typeof (HealthKit.HKWorkoutSession), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IHKWorkoutSessionDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("workoutSession:didChangeToState:fromState:date:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeToState (HKWorkoutSession workoutSession, HKWorkoutSessionState toState, HKWorkoutSessionState fromState, NSDate date)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeToState (IHKWorkoutSessionDelegate This, HKWorkoutSession workoutSession, HKWorkoutSessionState toState, HKWorkoutSessionState fromState, NSDate date)
		{
			var workoutSession__handle__ = workoutSession!.GetNonNullHandle (nameof (workoutSession));
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("workoutSession:didChangeToState:fromState:date:"), workoutSession__handle__, (IntPtr) (long) toState, (IntPtr) (long) fromState, date__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (workoutSession);
			GC.KeepAlive (date);
		}
		[global::Foundation.RequiredMember]
		[Export ("workoutSession:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFail (HKWorkoutSession workoutSession, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFail (IHKWorkoutSessionDelegate This, HKWorkoutSession workoutSession, NSError error)
		{
			var workoutSession__handle__ = workoutSession!.GetNonNullHandle (nameof (workoutSession));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("workoutSession:didFailWithError:"), workoutSession__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (workoutSession);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("workoutSession:didGenerateEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidGenerateEvent (HKWorkoutSession workoutSession, HKWorkoutEvent @event)
		{
			_DidGenerateEvent (this, workoutSession, @event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidGenerateEvent (IHKWorkoutSessionDelegate This, HKWorkoutSession workoutSession, HKWorkoutEvent @event)
		{
			var workoutSession__handle__ = workoutSession!.GetNonNullHandle (nameof (workoutSession));
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("workoutSession:didGenerateEvent:"), workoutSession__handle__, @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (workoutSession);
			GC.KeepAlive (@event);
		}
		[global::Foundation.OptionalMember]
		[Export ("workoutSession:didBeginActivityWithConfiguration:date:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginActivity (HKWorkoutSession workoutSession, HKWorkoutConfiguration workoutConfiguration, NSDate date)
		{
			_DidBeginActivity (this, workoutSession, workoutConfiguration, date);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBeginActivity (IHKWorkoutSessionDelegate This, HKWorkoutSession workoutSession, HKWorkoutConfiguration workoutConfiguration, NSDate date)
		{
			var workoutSession__handle__ = workoutSession!.GetNonNullHandle (nameof (workoutSession));
			var workoutConfiguration__handle__ = workoutConfiguration!.GetNonNullHandle (nameof (workoutConfiguration));
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("workoutSession:didBeginActivityWithConfiguration:date:"), workoutSession__handle__, workoutConfiguration__handle__, date__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (workoutSession);
			GC.KeepAlive (workoutConfiguration);
			GC.KeepAlive (date);
		}
		[global::Foundation.OptionalMember]
		[Export ("workoutSession:didEndActivityWithConfiguration:date:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndActivity (HKWorkoutSession workoutSession, HKWorkoutConfiguration workoutConfiguration, NSDate date)
		{
			_DidEndActivity (this, workoutSession, workoutConfiguration, date);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEndActivity (IHKWorkoutSessionDelegate This, HKWorkoutSession workoutSession, HKWorkoutConfiguration workoutConfiguration, NSDate date)
		{
			var workoutSession__handle__ = workoutSession!.GetNonNullHandle (nameof (workoutSession));
			var workoutConfiguration__handle__ = workoutConfiguration!.GetNonNullHandle (nameof (workoutConfiguration));
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("workoutSession:didEndActivityWithConfiguration:date:"), workoutSession__handle__, workoutConfiguration__handle__, date__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (workoutSession);
			GC.KeepAlive (workoutConfiguration);
			GC.KeepAlive (date);
		}
		[global::Foundation.OptionalMember]
		[Export ("workoutSession:didReceiveDataFromRemoteWorkoutSession:")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveData (HKWorkoutSession workoutSession, NSData[] data)
		{
			_DidReceiveData (this, workoutSession, data);
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveData (IHKWorkoutSessionDelegate This, HKWorkoutSession workoutSession, NSData[] data)
		{
			var workoutSession__handle__ = workoutSession!.GetNonNullHandle (nameof (workoutSession));
			if (data is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (data));
			using var nsa_data = NSArray.FromNSObjects (data);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("workoutSession:didReceiveDataFromRemoteWorkoutSession:"), workoutSession__handle__, nsa_data.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (workoutSession);
		}
		[global::Foundation.OptionalMember]
		[Export ("workoutSession:didDisconnectFromRemoteDeviceWithError:")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnect (HKWorkoutSession workoutSession, NSError? error)
		{
			_DidDisconnect (this, workoutSession, error);
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDisconnect (IHKWorkoutSessionDelegate This, HKWorkoutSession workoutSession, NSError? error)
		{
			var workoutSession__handle__ = workoutSession!.GetNonNullHandle (nameof (workoutSession));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("workoutSession:didDisconnectFromRemoteDeviceWithError:"), workoutSession__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (workoutSession);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("DidBeginActivity(HealthKit.HKWorkoutSession,HealthKit.HKWorkoutConfiguration,Foundation.NSDate)")]
		[DynamicDependencyAttribute ("DidChangeToState(HealthKit.HKWorkoutSession,HealthKit.HKWorkoutSessionState,HealthKit.HKWorkoutSessionState,Foundation.NSDate)")]
		[DynamicDependencyAttribute ("DidDisconnect(HealthKit.HKWorkoutSession,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidEndActivity(HealthKit.HKWorkoutSession,HealthKit.HKWorkoutConfiguration,Foundation.NSDate)")]
		[DynamicDependencyAttribute ("DidFail(HealthKit.HKWorkoutSession,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidGenerateEvent(HealthKit.HKWorkoutSession,HealthKit.HKWorkoutEvent)")]
		[DynamicDependencyAttribute ("DidReceiveData(HealthKit.HKWorkoutSession,Foundation.NSData[])")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (HKWorkoutSessionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IHKWorkoutSessionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IHKWorkoutSessionDelegate" /> interface to support all the methods from the HKWorkoutSessionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IHKWorkoutSessionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original HKWorkoutSessionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class HKWorkoutSessionDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidGenerateEvent (this IHKWorkoutSessionDelegate This, HKWorkoutSession workoutSession, HKWorkoutEvent @event)
		{
			var workoutSession__handle__ = workoutSession!.GetNonNullHandle (nameof (workoutSession));
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("workoutSession:didGenerateEvent:"), workoutSession__handle__, @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (workoutSession);
			GC.KeepAlive (@event);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBeginActivity (this IHKWorkoutSessionDelegate This, HKWorkoutSession workoutSession, HKWorkoutConfiguration workoutConfiguration, NSDate date)
		{
			var workoutSession__handle__ = workoutSession!.GetNonNullHandle (nameof (workoutSession));
			var workoutConfiguration__handle__ = workoutConfiguration!.GetNonNullHandle (nameof (workoutConfiguration));
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("workoutSession:didBeginActivityWithConfiguration:date:"), workoutSession__handle__, workoutConfiguration__handle__, date__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (workoutSession);
			GC.KeepAlive (workoutConfiguration);
			GC.KeepAlive (date);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEndActivity (this IHKWorkoutSessionDelegate This, HKWorkoutSession workoutSession, HKWorkoutConfiguration workoutConfiguration, NSDate date)
		{
			var workoutSession__handle__ = workoutSession!.GetNonNullHandle (nameof (workoutSession));
			var workoutConfiguration__handle__ = workoutConfiguration!.GetNonNullHandle (nameof (workoutConfiguration));
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("workoutSession:didEndActivityWithConfiguration:date:"), workoutSession__handle__, workoutConfiguration__handle__, date__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (workoutSession);
			GC.KeepAlive (workoutConfiguration);
			GC.KeepAlive (date);
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveData (this IHKWorkoutSessionDelegate This, HKWorkoutSession workoutSession, NSData[] data)
		{
			var workoutSession__handle__ = workoutSession!.GetNonNullHandle (nameof (workoutSession));
			if (data is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (data));
			using var nsa_data = NSArray.FromNSObjects (data);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("workoutSession:didReceiveDataFromRemoteWorkoutSession:"), workoutSession__handle__, nsa_data.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (workoutSession);
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDisconnect (this IHKWorkoutSessionDelegate This, HKWorkoutSession workoutSession, NSError? error)
		{
			var workoutSession__handle__ = workoutSession!.GetNonNullHandle (nameof (workoutSession));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("workoutSession:didDisconnectFromRemoteDeviceWithError:"), workoutSession__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (workoutSession);
			GC.KeepAlive (error);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class HKWorkoutSessionDelegateWrapper : BaseWrapper, IHKWorkoutSessionDelegate {
		public HKWorkoutSessionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (HKWorkoutSessionDelegateWrapper))]
		static HKWorkoutSessionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("workoutSession:didChangeToState:fromState:date:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidChangeToState (HKWorkoutSession workoutSession, HKWorkoutSessionState toState, HKWorkoutSessionState fromState, NSDate date)
		{
			var workoutSession__handle__ = workoutSession!.GetNonNullHandle (nameof (workoutSession));
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("workoutSession:didChangeToState:fromState:date:"), workoutSession__handle__, (IntPtr) (long) toState, (IntPtr) (long) fromState, date__handle__);
			GC.KeepAlive (workoutSession);
			GC.KeepAlive (date);
		}
		[Export ("workoutSession:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFail (HKWorkoutSession workoutSession, NSError error)
		{
			var workoutSession__handle__ = workoutSession!.GetNonNullHandle (nameof (workoutSession));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("workoutSession:didFailWithError:"), workoutSession__handle__, error__handle__);
			GC.KeepAlive (workoutSession);
			GC.KeepAlive (error);
		}
	}
}
namespace HealthKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IHKWorkoutSessionDelegate" /> (for the protocol <c>HKWorkoutSessionDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IHKWorkoutSessionDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__HealthKit_HKWorkoutSessionDelegate", false)]
	[Model]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public unsafe abstract partial class HKWorkoutSessionDelegate : NSObject, IHKWorkoutSessionDelegate {
		/// <summary>Creates a new <see cref="HKWorkoutSessionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected HKWorkoutSessionDelegate () : base (NSObjectFlag.Empty)
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
		protected HKWorkoutSessionDelegate (NSObjectFlag t) : base (t)
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
		protected internal HKWorkoutSessionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("workoutSession:didBeginActivityWithConfiguration:date:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginActivity (HKWorkoutSession workoutSession, HKWorkoutConfiguration workoutConfiguration, NSDate date)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("workoutSession:didChangeToState:fromState:date:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeToState (HKWorkoutSession workoutSession, HKWorkoutSessionState toState, HKWorkoutSessionState fromState, NSDate date)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("workoutSession:didDisconnectFromRemoteDeviceWithError:")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnect (HKWorkoutSession workoutSession, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("workoutSession:didEndActivityWithConfiguration:date:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndActivity (HKWorkoutSession workoutSession, HKWorkoutConfiguration workoutConfiguration, NSDate date)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("workoutSession:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFail (HKWorkoutSession workoutSession, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("workoutSession:didGenerateEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidGenerateEvent (HKWorkoutSession workoutSession, HKWorkoutEvent @event)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("workoutSession:didReceiveDataFromRemoteWorkoutSession:")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveData (HKWorkoutSession workoutSession, NSData[] data)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class HKWorkoutSessionDelegate */
}
