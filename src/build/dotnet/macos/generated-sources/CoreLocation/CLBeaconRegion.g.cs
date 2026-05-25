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
namespace CoreLocation {
	/// <summary>CoreLocation region determined by an iBeacon.</summary><remarks><para>
	/// 	Regions created with CLBeaconRegion can be added to a
	/// 	CoreLocation location manager (see <see cref="T:CoreLocation.CLLocationManager" />) to
	/// 	monitor when the device gets close to an iBeacon.
	/// 
	/// </para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreLocation/Reference/CLBeaconRegion_class/index.html">Apple documentation for <c>CLBeaconRegion</c></related>
	[Register("CLBeaconRegion", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos14.0", "Use 'CLBeaconIdentityCondition' instead.")]
	[ObsoletedOSPlatform ("ios17.0", "Use 'CLBeaconIdentityCondition' instead.")]
	[ObsoletedOSPlatform ("maccatalyst17.0", "Use 'CLBeaconIdentityCondition' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class CLBeaconRegion : CLRegion {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUUIDX = "UUID";
		static readonly NativeHandle selUUIDXHandle = Selector.GetHandle ("UUID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeaconIdentityConstraintX = "beaconIdentityConstraint";
		static readonly NativeHandle selBeaconIdentityConstraintXHandle = Selector.GetHandle ("beaconIdentityConstraint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithBeaconIdentityConstraint_Identifier_X = "initWithBeaconIdentityConstraint:identifier:";
		static readonly NativeHandle selInitWithBeaconIdentityConstraint_Identifier_XHandle = Selector.GetHandle ("initWithBeaconIdentityConstraint:identifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithProximityUUID_Identifier_X = "initWithProximityUUID:identifier:";
		static readonly NativeHandle selInitWithProximityUUID_Identifier_XHandle = Selector.GetHandle ("initWithProximityUUID:identifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithProximityUUID_Major_Identifier_X = "initWithProximityUUID:major:identifier:";
		static readonly NativeHandle selInitWithProximityUUID_Major_Identifier_XHandle = Selector.GetHandle ("initWithProximityUUID:major:identifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithProximityUUID_Major_Minor_Identifier_X = "initWithProximityUUID:major:minor:identifier:";
		static readonly NativeHandle selInitWithProximityUUID_Major_Minor_Identifier_XHandle = Selector.GetHandle ("initWithProximityUUID:major:minor:identifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithUUID_Identifier_X = "initWithUUID:identifier:";
		static readonly NativeHandle selInitWithUUID_Identifier_XHandle = Selector.GetHandle ("initWithUUID:identifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithUUID_Major_Identifier_X = "initWithUUID:major:identifier:";
		static readonly NativeHandle selInitWithUUID_Major_Identifier_XHandle = Selector.GetHandle ("initWithUUID:major:identifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithUUID_Major_Minor_Identifier_X = "initWithUUID:major:minor:identifier:";
		static readonly NativeHandle selInitWithUUID_Major_Minor_Identifier_XHandle = Selector.GetHandle ("initWithUUID:major:minor:identifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMajorX = "major";
		static readonly NativeHandle selMajorXHandle = Selector.GetHandle ("major");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinorX = "minor";
		static readonly NativeHandle selMinorXHandle = Selector.GetHandle ("minor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNotifyEntryStateOnDisplayX = "notifyEntryStateOnDisplay";
		static readonly NativeHandle selNotifyEntryStateOnDisplayXHandle = Selector.GetHandle ("notifyEntryStateOnDisplay");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPeripheralDataWithMeasuredPower_X = "peripheralDataWithMeasuredPower:";
		static readonly NativeHandle selPeripheralDataWithMeasuredPower_XHandle = Selector.GetHandle ("peripheralDataWithMeasuredPower:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNotifyEntryStateOnDisplay_X = "setNotifyEntryStateOnDisplay:";
		static readonly NativeHandle selSetNotifyEntryStateOnDisplay_XHandle = Selector.GetHandle ("setNotifyEntryStateOnDisplay:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CLBeaconRegion");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public CLBeaconRegion (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected CLBeaconRegion (NSObjectFlag t) : base (t)
		{
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
		protected internal CLBeaconRegion (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithBeaconIdentityConstraint:identifier:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos14.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[ObsoletedOSPlatform ("ios17.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CLBeaconRegion (CLBeaconIdentityConstraint beaconIdentityConstraint, string identifier)
			: base (NSObjectFlag.Empty)
		{
			var beaconIdentityConstraint__handle__ = beaconIdentityConstraint!.GetNonNullHandle (nameof (beaconIdentityConstraint));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithBeaconIdentityConstraint_Identifier_XHandle, beaconIdentityConstraint__handle__, nsidentifier), "initWithBeaconIdentityConstraint:identifier:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithBeaconIdentityConstraint_Identifier_XHandle, beaconIdentityConstraint__handle__, nsidentifier), "initWithBeaconIdentityConstraint:identifier:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (beaconIdentityConstraint);
			CFString.ReleaseNative (nsidentifier);
		}
		/// <param name="measuredPower"><para>The measured RSSI (signal strength) of the device, in decibels at 1M. Developers should pass <see langword="null" /> to use the device's default value.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Gets data for use with <see cref="M:CoreBluetooth.CBPeripheralManager.StartAdvertising(Foundation.NSDictionary)" />.</summary><returns>The result can be passed to <see cref="M:CoreBluetooth.CBPeripheralManager.StartAdvertising(Foundation.NSDictionary)" />.</returns><remarks><para>Retrieves the appropriate data required by <see cref="M:CoreBluetooth.CBPeripheralManager.StartAdvertising(Foundation.NSDictionary)" />.</para></remarks>
		[Export ("peripheralDataWithMeasuredPower:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableDictionary GetPeripheralData (NSNumber? measuredPower)
		{
			var measuredPower__handle__ = measuredPower.GetHandle ();
			NSMutableDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPeripheralDataWithMeasuredPower_XHandle, measuredPower__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPeripheralDataWithMeasuredPower_XHandle, measuredPower__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (measuredPower);
			return ret!;
		}
		/// <param name="proximityUuid">The unique ID of the iBeacons of interest.</param><param name="identifier">The name of the region to be created.</param><summary>Constructor that produces a region identified by <paramref name="identifier" /> that reports iBeacons associated with the <paramref name="proximityUuid" />.</summary>
		[Export ("initWithProximityUUID:identifier:")]
		[ObsoletedOSPlatform ("ios13.0", "Use the 'Create' method or the constructor using 'CLBeaconIdentityConstraint' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'Create' method or the constructor using 'CLBeaconIdentityConstraint' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos14.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NativeHandle _InitWithProximityUuid (NSUuid proximityUuid, string identifier)
		{
			var proximityUuid__handle__ = proximityUuid!.GetNonNullHandle (nameof (proximityUuid));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithProximityUUID_Identifier_XHandle, proximityUuid__handle__, nsidentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithProximityUUID_Identifier_XHandle, proximityUuid__handle__, nsidentifier);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (proximityUuid);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		/// <param name="proximityUuid">The unique ID of the iBeacons of interest.</param><param name="major">Can be used by the app developer for any purpose.</param><param name="identifier">The name of the region to be created.</param><summary>Constructor that produces a region identified by <paramref name="identifier" /> that reports iBeacons associated with the <paramref name="proximityUuid" /> and that assigns the <see cref="P:CoreLocation.CLBeaconRegion.Major" /> property.</summary>
		[Export ("initWithProximityUUID:major:identifier:")]
		[ObsoletedOSPlatform ("ios13.0", "Use the 'Create' method or the constructor using 'CLBeaconIdentityConstraint' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'Create' method or the constructor using 'CLBeaconIdentityConstraint' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos14.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NativeHandle _InitWithProximityUuid (NSUuid proximityUuid, ushort major, string identifier)
		{
			var proximityUuid__handle__ = proximityUuid!.GetNonNullHandle (nameof (proximityUuid));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UInt16_NativeHandle (this.Handle, selInitWithProximityUUID_Major_Identifier_XHandle, proximityUuid__handle__, major, nsidentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UInt16_NativeHandle (&__objc_super__, selInitWithProximityUUID_Major_Identifier_XHandle, proximityUuid__handle__, major, nsidentifier);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (proximityUuid);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		/// <param name="proximityUuid">The unique ID of the iBeacons of interest.</param><param name="major">Can be used by the app developer for any purpose.</param><param name="minor">Can be used by the app developer for any purpose.</param><param name="identifier">The name of the region to be created.</param><summary>Constructor that produces a region identified by <paramref name="identifier" /> that reports iBeacons associated with the <paramref name="proximityUuid" /> and that assigns the <see cref="P:CoreLocation.CLBeaconRegion.Major" /> and <see cref="P:CoreLocation.CLBeaconRegion.Minor" /> properties.</summary>
		[Export ("initWithProximityUUID:major:minor:identifier:")]
		[ObsoletedOSPlatform ("ios13.0", "Use the 'Create' method or the constructor using 'CLBeaconIdentityConstraint' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'Create' method or the constructor using 'CLBeaconIdentityConstraint' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos14.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NativeHandle _InitWithProximityUuid (NSUuid proximityUuid, ushort major, ushort minor, string identifier)
		{
			var proximityUuid__handle__ = proximityUuid!.GetNonNullHandle (nameof (proximityUuid));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UInt16_UInt16_NativeHandle (this.Handle, selInitWithProximityUUID_Major_Minor_Identifier_XHandle, proximityUuid__handle__, major, minor, nsidentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UInt16_UInt16_NativeHandle (&__objc_super__, selInitWithProximityUUID_Major_Minor_Identifier_XHandle, proximityUuid__handle__, major, minor, nsidentifier);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (proximityUuid);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("initWithUUID:identifier:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos14.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[ObsoletedOSPlatform ("ios17.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint _InitWithUuid (NSUuid uuid, string identifier)
		{
			var uuid__handle__ = uuid!.GetNonNullHandle (nameof (uuid));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithUUID_Identifier_XHandle, uuid__handle__, nsidentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithUUID_Identifier_XHandle, uuid__handle__, nsidentifier);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (uuid);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("initWithUUID:major:identifier:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos14.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[ObsoletedOSPlatform ("ios17.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint _InitWithUuid (NSUuid uuid, ushort major, string identifier)
		{
			var uuid__handle__ = uuid!.GetNonNullHandle (nameof (uuid));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_UInt16_NativeHandle (this.Handle, selInitWithUUID_Major_Identifier_XHandle, uuid__handle__, major, nsidentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_UInt16_NativeHandle (&__objc_super__, selInitWithUUID_Major_Identifier_XHandle, uuid__handle__, major, nsidentifier);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (uuid);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("initWithUUID:major:minor:identifier:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos14.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[ObsoletedOSPlatform ("ios17.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint _InitWithUuid (NSUuid uuid, ushort major, ushort minor, string identifier)
		{
			var uuid__handle__ = uuid!.GetNonNullHandle (nameof (uuid));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_UInt16_UInt16_NativeHandle (this.Handle, selInitWithUUID_Major_Minor_Identifier_XHandle, uuid__handle__, major, minor, nsidentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_UInt16_UInt16_NativeHandle (&__objc_super__, selInitWithUUID_Major_Minor_Identifier_XHandle, uuid__handle__, major, minor, nsidentifier);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (uuid);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos14.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[ObsoletedOSPlatform ("ios17.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[SupportedOSPlatform ("macos")]
		public virtual CLBeaconIdentityConstraint BeaconIdentityConstraint {
			[Export ("beaconIdentityConstraint", ArgumentSemantic.Copy)]
			get {
				CLBeaconIdentityConstraint? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CLBeaconIdentityConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBeaconIdentityConstraintXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CLBeaconIdentityConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBeaconIdentityConstraintXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>A number that can be used by the application developer for any purpose.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber? Major {
			[Export ("major", ArgumentSemantic.Copy)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMajorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMajorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>A number that can be used by the application developer for any purpose.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber? Minor {
			[Export ("minor", ArgumentSemantic.Copy)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMinorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMinorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Controls whether the entry/leave events are displayed to the user when they turn on their display.</summary><value></value><remarks></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool NotifyEntryStateOnDisplay {
			[Export ("notifyEntryStateOnDisplay")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selNotifyEntryStateOnDisplayXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selNotifyEntryStateOnDisplayXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setNotifyEntryStateOnDisplay:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetNotifyEntryStateOnDisplay_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetNotifyEntryStateOnDisplay_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos14.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[ObsoletedOSPlatform ("ios17.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use 'CLBeaconIdentityCondition' instead.")]
		[SupportedOSPlatform ("macos")]
		public virtual NSUuid Uuid {
			[Export ("UUID", ArgumentSemantic.Copy)]
			get {
				NSUuid? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUuid> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUUIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUuid> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUUIDXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class CLBeaconRegion */
}
