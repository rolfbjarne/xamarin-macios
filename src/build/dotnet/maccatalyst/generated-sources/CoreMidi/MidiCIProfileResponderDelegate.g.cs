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
namespace CoreMidi {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MIDICIProfileResponderDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios14.0")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "MIDICIProfileResponderDelegate", WrapperType = typeof (MidiCIProfileResponderDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConnectInitiator", Selector = "connectInitiator:withDeviceInfo:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSNumber), typeof (CoreMidi.MidiCIDeviceInfo) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InitiatorDisconnected", Selector = "initiatorDisconnected:", ParameterType = new Type [] { typeof (NSNumber) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillSetProfile", Selector = "willSetProfile:onChannel:enabled:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CoreMidi.MidiCIProfile), typeof (byte), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleData", Selector = "handleDataForProfile:onChannel:data:", ParameterType = new Type [] { typeof (CoreMidi.MidiCIProfile), typeof (byte), typeof (NSData) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IMidiCIProfileResponderDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("connectInitiator:withDeviceInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ConnectInitiator (NSNumber initiatorMuid, MidiCIDeviceInfo deviceInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ConnectInitiator (IMidiCIProfileResponderDelegate This, NSNumber initiatorMuid, MidiCIDeviceInfo deviceInfo)
		{
			var initiatorMuid__handle__ = initiatorMuid!.GetNonNullHandle (nameof (initiatorMuid));
			var deviceInfo__handle__ = deviceInfo!.GetNonNullHandle (nameof (deviceInfo));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connectInitiator:withDeviceInfo:"), initiatorMuid__handle__, deviceInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (initiatorMuid);
			GC.KeepAlive (deviceInfo);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("initiatorDisconnected:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitiatorDisconnected (NSNumber initiatorMuid)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InitiatorDisconnected (IMidiCIProfileResponderDelegate This, NSNumber initiatorMuid)
		{
			var initiatorMuid__handle__ = initiatorMuid!.GetNonNullHandle (nameof (initiatorMuid));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("initiatorDisconnected:"), initiatorMuid__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (initiatorMuid);
		}
		[global::Foundation.OptionalMember]
		[Export ("willSetProfile:onChannel:enabled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillSetProfile (MidiCIProfile profile, byte channel, bool shouldEnable)
		{
			return _WillSetProfile (this, profile, channel, shouldEnable);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WillSetProfile (IMidiCIProfileResponderDelegate This, MidiCIProfile profile, byte channel, bool shouldEnable)
		{
			var profile__handle__ = profile!.GetNonNullHandle (nameof (profile));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_byte_bool (This.Handle, Selector.GetHandle ("willSetProfile:onChannel:enabled:"), profile__handle__, channel, shouldEnable ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (profile);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("handleDataForProfile:onChannel:data:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleData (MidiCIProfile profile, byte channel, NSData inData)
		{
			_HandleData (this, profile, channel, inData);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _HandleData (IMidiCIProfileResponderDelegate This, MidiCIProfile profile, byte channel, NSData inData)
		{
			var profile__handle__ = profile!.GetNonNullHandle (nameof (profile));
			var inData__handle__ = inData!.GetNonNullHandle (nameof (inData));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_byte_NativeHandle (This.Handle, Selector.GetHandle ("handleDataForProfile:onChannel:data:"), profile__handle__, channel, inData__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (profile);
			GC.KeepAlive (inData);
		}
		[DynamicDependencyAttribute ("ConnectInitiator(Foundation.NSNumber,CoreMidi.MidiCIDeviceInfo)")]
		[DynamicDependencyAttribute ("HandleData(CoreMidi.MidiCIProfile,System.Byte,Foundation.NSData)")]
		[DynamicDependencyAttribute ("InitiatorDisconnected(Foundation.NSNumber)")]
		[DynamicDependencyAttribute ("WillSetProfile(CoreMidi.MidiCIProfile,System.Byte,System.Boolean)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MidiCIProfileResponderDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMidiCIProfileResponderDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMidiCIProfileResponderDelegate" /> interface to support all the methods from the MIDICIProfileResponderDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMidiCIProfileResponderDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MIDICIProfileResponderDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MidiCIProfileResponderDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WillSetProfile (this IMidiCIProfileResponderDelegate This, MidiCIProfile profile, byte channel, bool shouldEnable)
		{
			var profile__handle__ = profile!.GetNonNullHandle (nameof (profile));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_byte_bool (This.Handle, Selector.GetHandle ("willSetProfile:onChannel:enabled:"), profile__handle__, channel, shouldEnable ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (profile);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandleData (this IMidiCIProfileResponderDelegate This, MidiCIProfile profile, byte channel, NSData inData)
		{
			var profile__handle__ = profile!.GetNonNullHandle (nameof (profile));
			var inData__handle__ = inData!.GetNonNullHandle (nameof (inData));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_byte_NativeHandle (This.Handle, Selector.GetHandle ("handleDataForProfile:onChannel:data:"), profile__handle__, channel, inData__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (profile);
			GC.KeepAlive (inData);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MidiCIProfileResponderDelegateWrapper : BaseWrapper, IMidiCIProfileResponderDelegate {
		public MidiCIProfileResponderDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MidiCIProfileResponderDelegateWrapper))]
		static MidiCIProfileResponderDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("connectInitiator:withDeviceInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ConnectInitiator (NSNumber initiatorMuid, MidiCIDeviceInfo deviceInfo)
		{
			var initiatorMuid__handle__ = initiatorMuid!.GetNonNullHandle (nameof (initiatorMuid));
			var deviceInfo__handle__ = deviceInfo!.GetNonNullHandle (nameof (deviceInfo));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("connectInitiator:withDeviceInfo:"), initiatorMuid__handle__, deviceInfo__handle__);
			GC.KeepAlive (initiatorMuid);
			GC.KeepAlive (deviceInfo);
			return ret != 0;
		}
		[Export ("initiatorDisconnected:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InitiatorDisconnected (NSNumber initiatorMuid)
		{
			var initiatorMuid__handle__ = initiatorMuid!.GetNonNullHandle (nameof (initiatorMuid));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initiatorDisconnected:"), initiatorMuid__handle__);
			GC.KeepAlive (initiatorMuid);
		}
	}
}
namespace CoreMidi {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IMidiCIProfileResponderDelegate" /> (for the protocol <c>MIDICIProfileResponderDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IMidiCIProfileResponderDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__CoreMidi_MidiCIProfileResponderDelegate", false)]
	[Model]
	[SupportedOSPlatform ("ios14.0")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class MidiCIProfileResponderDelegate : NSObject, IMidiCIProfileResponderDelegate {
		/// <summary>Creates a new <see cref="MidiCIProfileResponderDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MidiCIProfileResponderDelegate () : base (NSObjectFlag.Empty)
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
		protected MidiCIProfileResponderDelegate (NSObjectFlag t) : base (t)
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
		protected internal MidiCIProfileResponderDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("connectInitiator:withDeviceInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ConnectInitiator (NSNumber initiatorMuid, MidiCIDeviceInfo deviceInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("handleDataForProfile:onChannel:data:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleData (MidiCIProfile profile, byte channel, NSData inData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("initiatorDisconnected:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitiatorDisconnected (NSNumber initiatorMuid)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("willSetProfile:onChannel:enabled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillSetProfile (MidiCIProfile profile, byte channel, bool shouldEnable)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MidiCIProfileResponderDelegate */
}
