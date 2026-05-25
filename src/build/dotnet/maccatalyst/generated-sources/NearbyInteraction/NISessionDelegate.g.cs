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
namespace NearbyInteraction {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NISessionDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "NISessionDelegate", WrapperType = typeof (NISessionDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSessionUpdateNearbyObjects", Selector = "session:didUpdateNearbyObjects:", ParameterType = new Type [] { typeof (NearbyInteraction.NISession), typeof (NearbyInteraction.NINearbyObject[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSessionRemoveNearbyObjects", Selector = "session:didRemoveNearbyObjects:withReason:", ParameterType = new Type [] { typeof (NearbyInteraction.NISession), typeof (NearbyInteraction.NINearbyObject[]), typeof (NearbyInteraction.NINearbyObjectRemovalReason) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SessionWasSuspended", Selector = "sessionWasSuspended:", ParameterType = new Type [] { typeof (NearbyInteraction.NISession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SessionSuspensionEnded", Selector = "sessionSuspensionEnded:", ParameterType = new Type [] { typeof (NearbyInteraction.NISession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSessionInvalidate", Selector = "session:didInvalidateWithError:", ParameterType = new Type [] { typeof (NearbyInteraction.NISession), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidGenerateShareableConfigurationData", Selector = "session:didGenerateShareableConfigurationData:forObject:", ParameterType = new Type [] { typeof (NearbyInteraction.NISession), typeof (NSData), typeof (NearbyInteraction.NINearbyObject) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateAlgorithmConvergence", Selector = "session:didUpdateAlgorithmConvergence:forObject:", ParameterType = new Type [] { typeof (NearbyInteraction.NISession), typeof (NearbyInteraction.NIAlgorithmConvergence), typeof (NearbyInteraction.NINearbyObject) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSessionStartRunning", Selector = "sessionDidStartRunning:", ParameterType = new Type [] { typeof (NearbyInteraction.NISession) }, ParameterByRef = new bool [] { false })]
	public partial interface INISessionDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("session:didUpdateNearbyObjects:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSessionUpdateNearbyObjects (NISession session, NINearbyObject[] nearbyObjects)
		{
			_DidSessionUpdateNearbyObjects (this, session, nearbyObjects);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSessionUpdateNearbyObjects (INISessionDelegate This, NISession session, NINearbyObject[] nearbyObjects)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (nearbyObjects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nearbyObjects));
			using var nsa_nearbyObjects = NSArray.FromNSObjects (nearbyObjects);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didUpdateNearbyObjects:"), session__handle__, nsa_nearbyObjects.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[global::Foundation.OptionalMember]
		[Export ("session:didRemoveNearbyObjects:withReason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSessionRemoveNearbyObjects (NISession session, NINearbyObject[] nearbyObjects, NINearbyObjectRemovalReason reason)
		{
			_DidSessionRemoveNearbyObjects (this, session, nearbyObjects, reason);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSessionRemoveNearbyObjects (INISessionDelegate This, NISession session, NINearbyObject[] nearbyObjects, NINearbyObjectRemovalReason reason)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (nearbyObjects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nearbyObjects));
			using var nsa_nearbyObjects = NSArray.FromNSObjects (nearbyObjects);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("session:didRemoveNearbyObjects:withReason:"), session__handle__, nsa_nearbyObjects.Handle, (IntPtr) (long) reason);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[global::Foundation.OptionalMember]
		[Export ("sessionWasSuspended:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionWasSuspended (NISession session)
		{
			_SessionWasSuspended (this, session);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SessionWasSuspended (INISessionDelegate This, NISession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sessionWasSuspended:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[global::Foundation.OptionalMember]
		[Export ("sessionSuspensionEnded:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionSuspensionEnded (NISession session)
		{
			_SessionSuspensionEnded (this, session);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SessionSuspensionEnded (INISessionDelegate This, NISession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sessionSuspensionEnded:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[global::Foundation.OptionalMember]
		[Export ("session:didInvalidateWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSessionInvalidate (NISession session, NSError error)
		{
			_DidSessionInvalidate (this, session, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSessionInvalidate (INISessionDelegate This, NISession session, NSError error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didInvalidateWithError:"), session__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("session:didGenerateShareableConfigurationData:forObject:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidGenerateShareableConfigurationData (NISession session, NSData shareableConfigurationData, NINearbyObject @object)
		{
			_DidGenerateShareableConfigurationData (this, session, shareableConfigurationData, @object);
		}
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidGenerateShareableConfigurationData (INISessionDelegate This, NISession session, NSData shareableConfigurationData, NINearbyObject @object)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var shareableConfigurationData__handle__ = shareableConfigurationData!.GetNonNullHandle (nameof (shareableConfigurationData));
			var @object__handle__ = @object!.GetNonNullHandle (nameof (@object));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didGenerateShareableConfigurationData:forObject:"), session__handle__, shareableConfigurationData__handle__, @object__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (shareableConfigurationData);
			GC.KeepAlive (@object);
		}
		[global::Foundation.OptionalMember]
		[Export ("session:didUpdateAlgorithmConvergence:forObject:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateAlgorithmConvergence (NISession session, NIAlgorithmConvergence convergence, NINearbyObject? @object)
		{
			_DidUpdateAlgorithmConvergence (this, session, convergence, @object);
		}
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateAlgorithmConvergence (INISessionDelegate This, NISession session, NIAlgorithmConvergence convergence, NINearbyObject? @object)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var convergence__handle__ = convergence!.GetNonNullHandle (nameof (convergence));
			var @object__handle__ = @object.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didUpdateAlgorithmConvergence:forObject:"), session__handle__, convergence__handle__, @object__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (convergence);
			GC.KeepAlive (@object);
		}
		[global::Foundation.OptionalMember]
		[Export ("sessionDidStartRunning:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSessionStartRunning (NISession session)
		{
			_DidSessionStartRunning (this, session);
		}
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSessionStartRunning (INISessionDelegate This, NISession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sessionDidStartRunning:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[DynamicDependencyAttribute ("DidGenerateShareableConfigurationData(NearbyInteraction.NISession,Foundation.NSData,NearbyInteraction.NINearbyObject)")]
		[DynamicDependencyAttribute ("DidSessionInvalidate(NearbyInteraction.NISession,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidSessionRemoveNearbyObjects(NearbyInteraction.NISession,NearbyInteraction.NINearbyObject[],NearbyInteraction.NINearbyObjectRemovalReason)")]
		[DynamicDependencyAttribute ("DidSessionStartRunning(NearbyInteraction.NISession)")]
		[DynamicDependencyAttribute ("DidSessionUpdateNearbyObjects(NearbyInteraction.NISession,NearbyInteraction.NINearbyObject[])")]
		[DynamicDependencyAttribute ("DidUpdateAlgorithmConvergence(NearbyInteraction.NISession,NearbyInteraction.NIAlgorithmConvergence,NearbyInteraction.NINearbyObject)")]
		[DynamicDependencyAttribute ("SessionSuspensionEnded(NearbyInteraction.NISession)")]
		[DynamicDependencyAttribute ("SessionWasSuspended(NearbyInteraction.NISession)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NISessionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INISessionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INISessionDelegate" /> interface to support all the methods from the NISessionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INISessionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NISessionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NISessionDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSessionUpdateNearbyObjects (this INISessionDelegate This, NISession session, NINearbyObject[] nearbyObjects)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (nearbyObjects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nearbyObjects));
			using var nsa_nearbyObjects = NSArray.FromNSObjects (nearbyObjects);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didUpdateNearbyObjects:"), session__handle__, nsa_nearbyObjects.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSessionRemoveNearbyObjects (this INISessionDelegate This, NISession session, NINearbyObject[] nearbyObjects, NINearbyObjectRemovalReason reason)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (nearbyObjects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nearbyObjects));
			using var nsa_nearbyObjects = NSArray.FromNSObjects (nearbyObjects);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("session:didRemoveNearbyObjects:withReason:"), session__handle__, nsa_nearbyObjects.Handle, (IntPtr) (long) reason);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SessionWasSuspended (this INISessionDelegate This, NISession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sessionWasSuspended:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SessionSuspensionEnded (this INISessionDelegate This, NISession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sessionSuspensionEnded:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSessionInvalidate (this INISessionDelegate This, NISession session, NSError error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didInvalidateWithError:"), session__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (error);
		}
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidGenerateShareableConfigurationData (this INISessionDelegate This, NISession session, NSData shareableConfigurationData, NINearbyObject @object)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var shareableConfigurationData__handle__ = shareableConfigurationData!.GetNonNullHandle (nameof (shareableConfigurationData));
			var @object__handle__ = @object!.GetNonNullHandle (nameof (@object));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didGenerateShareableConfigurationData:forObject:"), session__handle__, shareableConfigurationData__handle__, @object__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (shareableConfigurationData);
			GC.KeepAlive (@object);
		}
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateAlgorithmConvergence (this INISessionDelegate This, NISession session, NIAlgorithmConvergence convergence, NINearbyObject? @object)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var convergence__handle__ = convergence!.GetNonNullHandle (nameof (convergence));
			var @object__handle__ = @object.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didUpdateAlgorithmConvergence:forObject:"), session__handle__, convergence__handle__, @object__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (convergence);
			GC.KeepAlive (@object);
		}
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSessionStartRunning (this INISessionDelegate This, NISession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sessionDidStartRunning:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NISessionDelegateWrapper : BaseWrapper, INISessionDelegate {
		public NISessionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NISessionDelegateWrapper))]
		static NISessionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace NearbyInteraction {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INISessionDelegate" /> (for the protocol <c>NISessionDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INISessionDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__NearbyInteraction_NISessionDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class NISessionDelegate : NSObject, INISessionDelegate {
		/// <summary>Creates a new <see cref="NISessionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NISessionDelegate () : base (NSObjectFlag.Empty)
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
		protected NISessionDelegate (NSObjectFlag t) : base (t)
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
		protected internal NISessionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("session:didGenerateShareableConfigurationData:forObject:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidGenerateShareableConfigurationData (NISession session, NSData shareableConfigurationData, NINearbyObject @object)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("session:didInvalidateWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSessionInvalidate (NISession session, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("session:didRemoveNearbyObjects:withReason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSessionRemoveNearbyObjects (NISession session, NINearbyObject[] nearbyObjects, NINearbyObjectRemovalReason reason)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sessionDidStartRunning:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSessionStartRunning (NISession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("session:didUpdateNearbyObjects:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSessionUpdateNearbyObjects (NISession session, NINearbyObject[] nearbyObjects)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("session:didUpdateAlgorithmConvergence:forObject:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateAlgorithmConvergence (NISession session, NIAlgorithmConvergence convergence, NINearbyObject? @object)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sessionSuspensionEnded:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionSuspensionEnded (NISession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sessionWasSuspended:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionWasSuspended (NISession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NISessionDelegate */
}
