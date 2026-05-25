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
namespace CoreBluetooth {
	/// <summary>Represents a CoreBluetooth peripheral.</summary><remarks><para>
	/// 	CBPeripherals represent a remote peripheral that the device
	/// 	has discovered or has discovered and connected to.
	/// </para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBPeripheral_Class/index.html">Apple documentation for <c>CBPeripheral</c></related>
	[Register("CBPeripheral", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class CBPeripheral : CBPeer, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRSSIX = "RSSI";
		static readonly NativeHandle selRSSIXHandle = Selector.GetHandle ("RSSI");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanSendWriteWithoutResponseX = "canSendWriteWithoutResponse";
		static readonly NativeHandle selCanSendWriteWithoutResponseXHandle = Selector.GetHandle ("canSendWriteWithoutResponse");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDiscoverCharacteristics_ForService_X = "discoverCharacteristics:forService:";
		static readonly NativeHandle selDiscoverCharacteristics_ForService_XHandle = Selector.GetHandle ("discoverCharacteristics:forService:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDiscoverDescriptorsForCharacteristic_X = "discoverDescriptorsForCharacteristic:";
		static readonly NativeHandle selDiscoverDescriptorsForCharacteristic_XHandle = Selector.GetHandle ("discoverDescriptorsForCharacteristic:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDiscoverIncludedServices_ForService_X = "discoverIncludedServices:forService:";
		static readonly NativeHandle selDiscoverIncludedServices_ForService_XHandle = Selector.GetHandle ("discoverIncludedServices:forService:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDiscoverServices_X = "discoverServices:";
		static readonly NativeHandle selDiscoverServices_XHandle = Selector.GetHandle ("discoverServices:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumWriteValueLengthForType_X = "maximumWriteValueLengthForType:";
		static readonly NativeHandle selMaximumWriteValueLengthForType_XHandle = Selector.GetHandle ("maximumWriteValueLengthForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNameX = "name";
		static readonly NativeHandle selNameXHandle = Selector.GetHandle ("name");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenL2CAPChannel_X = "openL2CAPChannel:";
		static readonly NativeHandle selOpenL2CAPChannel_XHandle = Selector.GetHandle ("openL2CAPChannel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadRSSIX = "readRSSI";
		static readonly NativeHandle selReadRSSIXHandle = Selector.GetHandle ("readRSSI");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadValueForCharacteristic_X = "readValueForCharacteristic:";
		static readonly NativeHandle selReadValueForCharacteristic_XHandle = Selector.GetHandle ("readValueForCharacteristic:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadValueForDescriptor_X = "readValueForDescriptor:";
		static readonly NativeHandle selReadValueForDescriptor_XHandle = Selector.GetHandle ("readValueForDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selServicesX = "services";
		static readonly NativeHandle selServicesXHandle = Selector.GetHandle ("services");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNotifyValue_ForCharacteristic_X = "setNotifyValue:forCharacteristic:";
		static readonly NativeHandle selSetNotifyValue_ForCharacteristic_XHandle = Selector.GetHandle ("setNotifyValue:forCharacteristic:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStateX = "state";
		static readonly NativeHandle selStateXHandle = Selector.GetHandle ("state");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteValue_ForCharacteristic_Type_X = "writeValue:forCharacteristic:type:";
		static readonly NativeHandle selWriteValue_ForCharacteristic_Type_XHandle = Selector.GetHandle ("writeValue:forCharacteristic:type:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteValue_ForDescriptor_X = "writeValue:forDescriptor:";
		static readonly NativeHandle selWriteValue_ForDescriptor_XHandle = Selector.GetHandle ("writeValue:forDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CBPeripheral");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected CBPeripheral (NSObjectFlag t) : base (t)
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
		protected internal CBPeripheral (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("discoverCharacteristics:forService:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void DiscoverCharacteristics (NSArray? characteristicUUIDs, CBService forService)
		{
			var characteristicUUIDs__handle__ = characteristicUUIDs.GetHandle ();
			var forService__handle__ = forService!.GetNonNullHandle (nameof (forService));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDiscoverCharacteristics_ForService_XHandle, characteristicUUIDs__handle__, forService__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDiscoverCharacteristics_ForService_XHandle, characteristicUUIDs__handle__, forService__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (characteristicUUIDs);
			GC.KeepAlive (forService);
		}
		/// <param name="characteristic">To be added.</param><summary>Finds descriptors for the specified <paramref name="characteristic" />.</summary><remarks>To be added.</remarks>
		[Export ("discoverDescriptorsForCharacteristic:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DiscoverDescriptors (CBCharacteristic characteristic)
		{
			var characteristic__handle__ = characteristic!.GetNonNullHandle (nameof (characteristic));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDiscoverDescriptorsForCharacteristic_XHandle, characteristic__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDiscoverDescriptorsForCharacteristic_XHandle, characteristic__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (characteristic);
		}
		[Export ("discoverIncludedServices:forService:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void DiscoverIncludedServices (NSArray? includedServiceUUIDs, CBService forService)
		{
			var includedServiceUUIDs__handle__ = includedServiceUUIDs.GetHandle ();
			var forService__handle__ = forService!.GetNonNullHandle (nameof (forService));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDiscoverIncludedServices_ForService_XHandle, includedServiceUUIDs__handle__, forService__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDiscoverIncludedServices_ForService_XHandle, includedServiceUUIDs__handle__, forService__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (includedServiceUUIDs);
			GC.KeepAlive (forService);
		}
		[Export ("discoverServices:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void DiscoverServices (NSArray? serviceUUIDs)
		{
			var serviceUUIDs__handle__ = serviceUUIDs.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDiscoverServices_XHandle, serviceUUIDs__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDiscoverServices_XHandle, serviceUUIDs__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (serviceUUIDs);
		}
		/// <param name="type">To be added.</param><summary>Gets the maximum write length for data that is written to the values of the specified <paramref name="type" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("maximumWriteValueLengthForType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetMaximumWriteValueLength (CBCharacteristicWriteType type)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_IntPtr (this.Handle, selMaximumWriteValueLengthForType_XHandle, (IntPtr) (long) type);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, selMaximumWriteValueLengthForType_XHandle, (IntPtr) (long) type);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="psm">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("openL2CAPChannel:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OpenL2CapChannel (ushort psm)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UInt16 (this.Handle, selOpenL2CAPChannel_XHandle, psm);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt16 (&__objc_super__, selOpenL2CAPChannel_XHandle, psm);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Reads the signal strength of the peripheral.</summary><remarks>To be added.</remarks>
		[Export ("readRSSI")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReadRSSI ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReadRSSIXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selReadRSSIXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="characteristic">To be added.</param><summary>Reads the value of the specified <paramref name="characteristic" />.</summary><remarks>To be added.</remarks>
		[Export ("readValueForCharacteristic:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReadValue (CBCharacteristic characteristic)
		{
			var characteristic__handle__ = characteristic!.GetNonNullHandle (nameof (characteristic));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReadValueForCharacteristic_XHandle, characteristic__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReadValueForCharacteristic_XHandle, characteristic__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (characteristic);
		}
		/// <param name="descriptor">To be added.</param><summary>Reads the value of the characteristic that is identified by the specified <paramref name="descriptor" />.</summary><remarks>To be added.</remarks>
		[Export ("readValueForDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReadValue (CBDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReadValueForDescriptor_XHandle, descriptor__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReadValueForDescriptor_XHandle, descriptor__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (descriptor);
		}
		/// <param name="enabled">To be added.</param><param name="characteristic">To be added.</param><summary>Sets the notification status for the specified <paramref name="characteristic" />.</summary><remarks>To be added.</remarks>
		[Export ("setNotifyValue:forCharacteristic:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNotifyValue (bool enabled, CBCharacteristic characteristic)
		{
			var characteristic__handle__ = characteristic!.GetNonNullHandle (nameof (characteristic));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NativeHandle (this.Handle, selSetNotifyValue_ForCharacteristic_XHandle, enabled ? (byte) 1 : (byte) 0, characteristic__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_NativeHandle (&__objc_super__, selSetNotifyValue_ForCharacteristic_XHandle, enabled ? (byte) 1 : (byte) 0, characteristic__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (characteristic);
		}
		/// <param name="data">To be added.</param><param name="characteristic">To be added.</param><param name="type">To be added.</param><summary>Writes <paramref name="data" /> to the specified <paramref name="characteristic" /> with the specified <paramref name="type" />.</summary><remarks>To be added.</remarks>
		[Export ("writeValue:forCharacteristic:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteValue (NSData data, CBCharacteristic characteristic, CBCharacteristicWriteType type)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var characteristic__handle__ = characteristic!.GetNonNullHandle (nameof (characteristic));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, selWriteValue_ForCharacteristic_Type_XHandle, data__handle__, characteristic__handle__, (IntPtr) (long) type);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selWriteValue_ForCharacteristic_Type_XHandle, data__handle__, characteristic__handle__, (IntPtr) (long) type);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			GC.KeepAlive (characteristic);
		}
		/// <param name="data">The data to write.</param><param name="descriptor">The descriptor to use for the data.</param><summary>Writes <paramref name="data" /> to the characteristic that is identified by the specified <paramref name="descriptor" />.</summary><remarks>To be added.</remarks>
		[Export ("writeValue:forDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteValue (NSData data, CBDescriptor descriptor)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selWriteValue_ForDescriptor_XHandle, data__handle__, descriptor__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selWriteValue_ForDescriptor_XHandle, data__handle__, descriptor__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			GC.KeepAlive (descriptor);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool CanSendWriteWithoutResponse {
			[Export ("canSendWriteWithoutResponse")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanSendWriteWithoutResponseXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanSendWriteWithoutResponseXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>An instance of the CoreBluetooth.ICBPeripheralDelegate model class which acts as the class delegate.</summary><value>The instance of the CoreBluetooth.ICBPeripheralDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ICBPeripheralDelegate Delegate {
			get {
				return (WeakDelegate as ICBPeripheralDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		/// <summary>Gets the peripheral name.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Name {
			[Export ("name", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Developers should not use this deprecated property. </summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios8.0")]
		[ObsoletedOSPlatform ("tvos9.0")]
		[ObsoletedOSPlatform ("macos10.13")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSNumber? RSSI {
			[Export ("RSSI", ArgumentSemantic.Retain)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRSSIXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRSSIXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>The discovered <see cref="T:CoreBluetooth.CBService" />s of this peripheral.</summary><value>Will be <see langword="null" /> until some time after <see cref="CoreBluetooth.CBPeripheral.DiscoverServices(CoreBluetooth.CBUUID[])" /> is called.</value><remarks><para>This property is mutated asynchronously subsequent to calls to <see cref="CoreBluetooth.CBPeripheral.DiscoverServices(CoreBluetooth.CBUUID[])" />. Application developers generally override <see cref="M:CoreBluetooth.CBPeripheralDelegate.DiscoveredService(CoreBluetooth.CBPeripheral,Foundation.NSError)" /> to enumerate services. </para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CBService[]? Services {
			[Export ("services", ArgumentSemantic.Retain)]
			get {
				CBService[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<CBService>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selServicesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<CBService>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selServicesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the connection state for the peripheral.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CBPeripheralState State {
			[Export ("state")]
			get {
				CBPeripheralState ret;
				if (IsDirectBinding) {
					ret = (CoreBluetooth.CBPeripheralState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CoreBluetooth.CBPeripheralState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selStateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		/// <summary>An object that can respond to the delegate protocol for this type</summary><value>The instance that will respond to events and data requests.</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_CBPeripheralDelegate); }
		}
		internal virtual _CBPeripheralDelegate CreateInternalEventDelegateType ()
		{
			return (_CBPeripheralDelegate)(new _CBPeripheralDelegate());
		}
		internal _CBPeripheralDelegate EnsureCBPeripheralDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _CBPeripheralDelegate;
			if (del is null){
				del = (_CBPeripheralDelegate)CreateInternalEventDelegateType ();
				Delegate = (ICBPeripheralDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _CBPeripheralDelegate : NSObject, ICBPeripheralDelegate { 
			public _CBPeripheralDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_CBPeripheralDelegate))]
			static _CBPeripheralDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<CBPeripheralOpenL2CapChannelEventArgs>? didOpenL2CapChannel;
			[Export ("peripheral:didOpenL2CAPChannel:error:")]
			public void DidOpenL2CapChannel (CoreBluetooth.CBPeripheral peripheral, CoreBluetooth.CBL2CapChannel? channel, NSError? error)
			{
				var handler = didOpenL2CapChannel;
				if (handler is not null){
					var args = new CBPeripheralOpenL2CapChannelEventArgs (channel, error);
					handler (peripheral, args);
				}
			}
			internal EventHandler<CBServiceEventArgs>? discoveredCharacteristics;
			[Export ("peripheral:didDiscoverCharacteristicsForService:error:")]
			public void DiscoveredCharacteristics (CoreBluetooth.CBPeripheral peripheral, CoreBluetooth.CBService service, NSError? error)
			{
				var handler = discoveredCharacteristics;
				if (handler is not null){
					var args = new CBServiceEventArgs (service, error);
					handler (peripheral, args);
				}
			}
			internal EventHandler<CBCharacteristicEventArgs>? discoveredDescriptor;
			[Export ("peripheral:didDiscoverDescriptorsForCharacteristic:error:")]
			public void DiscoveredDescriptor (CoreBluetooth.CBPeripheral peripheral, CoreBluetooth.CBCharacteristic characteristic, NSError? error)
			{
				var handler = discoveredDescriptor;
				if (handler is not null){
					var args = new CBCharacteristicEventArgs (characteristic, error);
					handler (peripheral, args);
				}
			}
			internal EventHandler<CBServiceEventArgs>? discoveredIncludedService;
			[Export ("peripheral:didDiscoverIncludedServicesForService:error:")]
			public void DiscoveredIncludedService (CoreBluetooth.CBPeripheral peripheral, CoreBluetooth.CBService service, NSError? error)
			{
				var handler = discoveredIncludedService;
				if (handler is not null){
					var args = new CBServiceEventArgs (service, error);
					handler (peripheral, args);
				}
			}
			internal EventHandler<NSErrorEventArgs>? discoveredService;
			[Export ("peripheral:didDiscoverServices:")]
			public void DiscoveredService (CoreBluetooth.CBPeripheral peripheral, NSError? error)
			{
				var handler = discoveredService;
				if (handler is not null){
					var args = new NSErrorEventArgs (error);
					handler (peripheral, args);
				}
			}
			internal EventHandler? isReadyToSendWriteWithoutResponse;
			[Export ("peripheralIsReadyToSendWriteWithoutResponse:")]
			public void IsReadyToSendWriteWithoutResponse (CoreBluetooth.CBPeripheral peripheral)
			{
				var handler = isReadyToSendWriteWithoutResponse;
				if (handler is not null){
					handler (peripheral, EventArgs.Empty);
				}
			}
			internal EventHandler<CBPeripheralServicesEventArgs>? modifiedServices;
			[Export ("peripheral:didModifyServices:")]
			public void ModifiedServices (CoreBluetooth.CBPeripheral peripheral, CoreBluetooth.CBService[] services)
			{
				var handler = modifiedServices;
				if (handler is not null){
					var args = new CBPeripheralServicesEventArgs (services);
					handler (peripheral, args);
				}
			}
			internal EventHandler<CBRssiEventArgs>? rssiRead;
			[Export ("peripheral:didReadRSSI:error:")]
			public void RssiRead (CoreBluetooth.CBPeripheral peripheral, NSNumber rssi, NSError? error)
			{
				var handler = rssiRead;
				if (handler is not null){
					var args = new CBRssiEventArgs (rssi, error);
					handler (peripheral, args);
				}
			}
			internal EventHandler<NSErrorEventArgs>? rssiUpdated;
			[Export ("peripheralDidUpdateRSSI:error:")]
			public void RssiUpdated (CoreBluetooth.CBPeripheral peripheral, NSError? error)
			{
				var handler = rssiUpdated;
				if (handler is not null){
					var args = new NSErrorEventArgs (error);
					handler (peripheral, args);
				}
			}
			internal EventHandler<CBCharacteristicEventArgs>? updatedCharacterteristicValue;
			[Export ("peripheral:didUpdateValueForCharacteristic:error:")]
			public void UpdatedCharacterteristicValue (CoreBluetooth.CBPeripheral peripheral, CoreBluetooth.CBCharacteristic characteristic, NSError? error)
			{
				var handler = updatedCharacterteristicValue;
				if (handler is not null){
					var args = new CBCharacteristicEventArgs (characteristic, error);
					handler (peripheral, args);
				}
			}
			internal EventHandler? updatedName;
			[Export ("peripheralDidUpdateName:")]
			public void UpdatedName (CoreBluetooth.CBPeripheral peripheral)
			{
				var handler = updatedName;
				if (handler is not null){
					handler (peripheral, EventArgs.Empty);
				}
			}
			internal EventHandler<CBCharacteristicEventArgs>? updatedNotificationState;
			[Export ("peripheral:didUpdateNotificationStateForCharacteristic:error:")]
			public void UpdatedNotificationState (CoreBluetooth.CBPeripheral peripheral, CoreBluetooth.CBCharacteristic characteristic, NSError? error)
			{
				var handler = updatedNotificationState;
				if (handler is not null){
					var args = new CBCharacteristicEventArgs (characteristic, error);
					handler (peripheral, args);
				}
			}
			internal EventHandler<CBDescriptorEventArgs>? updatedValue;
			[Export ("peripheral:didUpdateValueForDescriptor:error:")]
			public void UpdatedValue (CoreBluetooth.CBPeripheral peripheral, CoreBluetooth.CBDescriptor descriptor, NSError? error)
			{
				var handler = updatedValue;
				if (handler is not null){
					var args = new CBDescriptorEventArgs (descriptor, error);
					handler (peripheral, args);
				}
			}
			internal EventHandler<CBCharacteristicEventArgs>? wroteCharacteristicValue;
			[Export ("peripheral:didWriteValueForCharacteristic:error:")]
			public void WroteCharacteristicValue (CoreBluetooth.CBPeripheral peripheral, CoreBluetooth.CBCharacteristic characteristic, NSError? error)
			{
				var handler = wroteCharacteristicValue;
				if (handler is not null){
					var args = new CBCharacteristicEventArgs (characteristic, error);
					handler (peripheral, args);
				}
			}
			internal EventHandler<CBDescriptorEventArgs>? wroteDescriptorValue;
			[Export ("peripheral:didWriteValueForDescriptor:error:")]
			public void WroteDescriptorValue (CoreBluetooth.CBPeripheral peripheral, CoreBluetooth.CBDescriptor descriptor, NSError? error)
			{
				var handler = wroteDescriptorValue;
				if (handler is not null){
					var args = new CBDescriptorEventArgs (descriptor, error);
					handler (peripheral, args);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<CBPeripheralOpenL2CapChannelEventArgs> DidOpenL2CapChannel {
			add { EnsureCBPeripheralDelegate ()!.didOpenL2CapChannel += value; }
			remove { EnsureCBPeripheralDelegate ()!.didOpenL2CapChannel -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<CBServiceEventArgs> DiscoveredCharacteristics {
			add { EnsureCBPeripheralDelegate ()!.discoveredCharacteristics += value; }
			remove { EnsureCBPeripheralDelegate ()!.discoveredCharacteristics -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<CBCharacteristicEventArgs> DiscoveredDescriptor {
			add { EnsureCBPeripheralDelegate ()!.discoveredDescriptor += value; }
			remove { EnsureCBPeripheralDelegate ()!.discoveredDescriptor -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<CBServiceEventArgs> DiscoveredIncludedService {
			add { EnsureCBPeripheralDelegate ()!.discoveredIncludedService += value; }
			remove { EnsureCBPeripheralDelegate ()!.discoveredIncludedService -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<NSErrorEventArgs> DiscoveredService {
			add { EnsureCBPeripheralDelegate ()!.discoveredService += value; }
			remove { EnsureCBPeripheralDelegate ()!.discoveredService -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler IsReadyToSendWriteWithoutResponse {
			add { EnsureCBPeripheralDelegate ()!.isReadyToSendWriteWithoutResponse += value; }
			remove { EnsureCBPeripheralDelegate ()!.isReadyToSendWriteWithoutResponse -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<CBPeripheralServicesEventArgs> ModifiedServices {
			add { EnsureCBPeripheralDelegate ()!.modifiedServices += value; }
			remove { EnsureCBPeripheralDelegate ()!.modifiedServices -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<CBRssiEventArgs> RssiRead {
			add { EnsureCBPeripheralDelegate ()!.rssiRead += value; }
			remove { EnsureCBPeripheralDelegate ()!.rssiRead -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<NSErrorEventArgs> RssiUpdated {
			add { EnsureCBPeripheralDelegate ()!.rssiUpdated += value; }
			remove { EnsureCBPeripheralDelegate ()!.rssiUpdated -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<CBCharacteristicEventArgs> UpdatedCharacterteristicValue {
			add { EnsureCBPeripheralDelegate ()!.updatedCharacterteristicValue += value; }
			remove { EnsureCBPeripheralDelegate ()!.updatedCharacterteristicValue -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler UpdatedName {
			add { EnsureCBPeripheralDelegate ()!.updatedName += value; }
			remove { EnsureCBPeripheralDelegate ()!.updatedName -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<CBCharacteristicEventArgs> UpdatedNotificationState {
			add { EnsureCBPeripheralDelegate ()!.updatedNotificationState += value; }
			remove { EnsureCBPeripheralDelegate ()!.updatedNotificationState -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<CBDescriptorEventArgs> UpdatedValue {
			add { EnsureCBPeripheralDelegate ()!.updatedValue += value; }
			remove { EnsureCBPeripheralDelegate ()!.updatedValue -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<CBCharacteristicEventArgs> WroteCharacteristicValue {
			add { EnsureCBPeripheralDelegate ()!.wroteCharacteristicValue += value; }
			remove { EnsureCBPeripheralDelegate ()!.wroteCharacteristicValue -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<CBDescriptorEventArgs> WroteDescriptorValue {
			add { EnsureCBPeripheralDelegate ()!.wroteDescriptorValue += value; }
			remove { EnsureCBPeripheralDelegate ()!.wroteDescriptorValue -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class CBPeripheral */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class CBCharacteristicEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="CBCharacteristicEventArgs" /> with the specified event data.</summary>
		/// <param name="characteristic">The value for the <see cref="Characteristic" /> property.</param>
		/// <param name="error">The value for the <see cref="Error" /> property.</param>
		public CBCharacteristicEventArgs (CoreBluetooth.CBCharacteristic characteristic, NSError? error)
		{
			this.Characteristic = characteristic;
			this.Error = error;
		}
		public CoreBluetooth.CBCharacteristic Characteristic { get; set; }
		public NSError? Error { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class CBDescriptorEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="CBDescriptorEventArgs" /> with the specified event data.</summary>
		/// <param name="descriptor">The value for the <see cref="Descriptor" /> property.</param>
		/// <param name="error">The value for the <see cref="Error" /> property.</param>
		public CBDescriptorEventArgs (CoreBluetooth.CBDescriptor descriptor, NSError? error)
		{
			this.Descriptor = descriptor;
			this.Error = error;
		}
		public CoreBluetooth.CBDescriptor Descriptor { get; set; }
		public NSError? Error { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class CBPeripheralOpenL2CapChannelEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="CBPeripheralOpenL2CapChannelEventArgs" /> with the specified event data.</summary>
		/// <param name="channel">The value for the <see cref="Channel" /> property.</param>
		/// <param name="error">The value for the <see cref="Error" /> property.</param>
		public CBPeripheralOpenL2CapChannelEventArgs (CoreBluetooth.CBL2CapChannel? channel, NSError? error)
		{
			this.Channel = channel;
			this.Error = error;
		}
		public CoreBluetooth.CBL2CapChannel? Channel { get; set; }
		public NSError? Error { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class CBPeripheralServicesEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="CBPeripheralServicesEventArgs" /> with the specified event data.</summary>
		/// <param name="services">The value for the <see cref="Services" /> property.</param>
		public CBPeripheralServicesEventArgs (CoreBluetooth.CBService[] services)
		{
			this.Services = services;
		}
		public CoreBluetooth.CBService[] Services { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class CBRssiEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="CBRssiEventArgs" /> with the specified event data.</summary>
		/// <param name="rssi">The value for the <see cref="Rssi" /> property.</param>
		/// <param name="error">The value for the <see cref="Error" /> property.</param>
		public CBRssiEventArgs (NSNumber rssi, NSError? error)
		{
			this.Error = error;
			this.Rssi = rssi;
		}
		public NSError? Error { get; set; }
		public NSNumber Rssi { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class CBServiceEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="CBServiceEventArgs" /> with the specified event data.</summary>
		/// <param name="service">The value for the <see cref="Service" /> property.</param>
		/// <param name="error">The value for the <see cref="Error" /> property.</param>
		public CBServiceEventArgs (CoreBluetooth.CBService service, NSError? error)
		{
			this.Error = error;
			this.Service = service;
		}
		public NSError? Error { get; set; }
		public CoreBluetooth.CBService Service { get; set; }
	}
}
