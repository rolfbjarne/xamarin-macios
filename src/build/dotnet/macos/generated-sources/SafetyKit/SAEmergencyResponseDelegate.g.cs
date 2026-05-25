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
namespace SafetyKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>SAEmergencyResponseDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[UnsupportedOSPlatform ("tvos")]
	[Protocol (Name = "SAEmergencyResponseDelegate", WrapperType = typeof (SAEmergencyResponseDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateVoiceCallStatus", Selector = "emergencyResponseManager:didUpdateVoiceCallStatus:", ParameterType = new Type [] { typeof (SafetyKit.SAEmergencyResponseManager), typeof (SafetyKit.SAEmergencyResponseManagerVoiceCallStatus) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ISAEmergencyResponseDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("emergencyResponseManager:didUpdateVoiceCallStatus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateVoiceCallStatus (SAEmergencyResponseManager emergencyResponseManager, SAEmergencyResponseManagerVoiceCallStatus voiceCallStatus)
		{
			_DidUpdateVoiceCallStatus (this, emergencyResponseManager, voiceCallStatus);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateVoiceCallStatus (ISAEmergencyResponseDelegate This, SAEmergencyResponseManager emergencyResponseManager, SAEmergencyResponseManagerVoiceCallStatus voiceCallStatus)
		{
			var emergencyResponseManager__handle__ = emergencyResponseManager!.GetNonNullHandle (nameof (emergencyResponseManager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("emergencyResponseManager:didUpdateVoiceCallStatus:"), emergencyResponseManager__handle__, (IntPtr) (long) voiceCallStatus);
			GC.KeepAlive (This);
			GC.KeepAlive (emergencyResponseManager);
		}
		[DynamicDependencyAttribute ("DidUpdateVoiceCallStatus(SafetyKit.SAEmergencyResponseManager,SafetyKit.SAEmergencyResponseManagerVoiceCallStatus)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SAEmergencyResponseDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISAEmergencyResponseDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ISAEmergencyResponseDelegate" /> interface to support all the methods from the SAEmergencyResponseDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ISAEmergencyResponseDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original SAEmergencyResponseDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class SAEmergencyResponseDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateVoiceCallStatus (this ISAEmergencyResponseDelegate This, SAEmergencyResponseManager emergencyResponseManager, SAEmergencyResponseManagerVoiceCallStatus voiceCallStatus)
		{
			var emergencyResponseManager__handle__ = emergencyResponseManager!.GetNonNullHandle (nameof (emergencyResponseManager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("emergencyResponseManager:didUpdateVoiceCallStatus:"), emergencyResponseManager__handle__, (IntPtr) (long) voiceCallStatus);
			GC.KeepAlive (This);
			GC.KeepAlive (emergencyResponseManager);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SAEmergencyResponseDelegateWrapper : BaseWrapper, ISAEmergencyResponseDelegate {
		public SAEmergencyResponseDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SAEmergencyResponseDelegateWrapper))]
		static SAEmergencyResponseDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace SafetyKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="ISAEmergencyResponseDelegate" /> (for the protocol <c>SAEmergencyResponseDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="ISAEmergencyResponseDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__SafetyKit_SAEmergencyResponseDelegate", false)]
	[Model]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[UnsupportedOSPlatform ("tvos")]
	public unsafe partial class SAEmergencyResponseDelegate : NSObject, ISAEmergencyResponseDelegate {
		/// <summary>Creates a new <see cref="SAEmergencyResponseDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SAEmergencyResponseDelegate () : base (NSObjectFlag.Empty)
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
		protected SAEmergencyResponseDelegate (NSObjectFlag t) : base (t)
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
		protected internal SAEmergencyResponseDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("emergencyResponseManager:didUpdateVoiceCallStatus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateVoiceCallStatus (SAEmergencyResponseManager emergencyResponseManager, SAEmergencyResponseManagerVoiceCallStatus voiceCallStatus)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SAEmergencyResponseDelegate */
}
