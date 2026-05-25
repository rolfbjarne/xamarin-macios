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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreBluetooth {
	#pragma warning disable CS1573
	/// <summary>Delegate object for <see cref="T:CoreBluetooth.CBPeripheral" />. Provides methods called on events relating to discovery, exploration, and interaction with a remote peripheral.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBPeripheralDelegate_Protocol/index.html">Apple documentation for <c>CBPeripheralDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "CBPeripheralDelegate", WrapperType = typeof (CBPeripheralDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RssiUpdated", Selector = "peripheralDidUpdateRSSI:error:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheral), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RssiRead", Selector = "peripheral:didReadRSSI:error:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheral), typeof (NSNumber), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DiscoveredService", Selector = "peripheral:didDiscoverServices:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheral), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DiscoveredIncludedService", Selector = "peripheral:didDiscoverIncludedServicesForService:error:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheral), typeof (CoreBluetooth.CBService), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DiscoveredCharacteristics", Selector = "peripheral:didDiscoverCharacteristicsForService:error:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheral), typeof (CoreBluetooth.CBService), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdatedCharacterteristicValue", Selector = "peripheral:didUpdateValueForCharacteristic:error:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheral), typeof (CoreBluetooth.CBCharacteristic), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WroteCharacteristicValue", Selector = "peripheral:didWriteValueForCharacteristic:error:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheral), typeof (CoreBluetooth.CBCharacteristic), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdatedNotificationState", Selector = "peripheral:didUpdateNotificationStateForCharacteristic:error:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheral), typeof (CoreBluetooth.CBCharacteristic), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DiscoveredDescriptor", Selector = "peripheral:didDiscoverDescriptorsForCharacteristic:error:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheral), typeof (CoreBluetooth.CBCharacteristic), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdatedValue", Selector = "peripheral:didUpdateValueForDescriptor:error:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheral), typeof (CoreBluetooth.CBDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WroteDescriptorValue", Selector = "peripheral:didWriteValueForDescriptor:error:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheral), typeof (CoreBluetooth.CBDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdatedName", Selector = "peripheralDidUpdateName:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheral) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ModifiedServices", Selector = "peripheral:didModifyServices:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheral), typeof (CoreBluetooth.CBService[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOpenL2CapChannel", Selector = "peripheral:didOpenL2CAPChannel:error:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheral), typeof (CoreBluetooth.CBL2CapChannel), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsReadyToSendWriteWithoutResponse", Selector = "peripheralIsReadyToSendWriteWithoutResponse:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheral) }, ParameterByRef = new bool [] { false })]
	public partial interface ICBPeripheralDelegate : INativeObject, IDisposable
	{
		/// <param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheralDidUpdateRSSI:error:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'RssiRead' instead.")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'RssiRead' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'RssiRead' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'RssiRead' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RssiUpdated (CBPeripheral peripheral, NSError? error)
		{
			_RssiUpdated (this, peripheral, error);
		}
		/// <param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.13", "Use 'RssiRead' instead.")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'RssiRead' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'RssiRead' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'RssiRead' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RssiUpdated (ICBPeripheralDelegate This, CBPeripheral peripheral, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheralDidUpdateRSSI:error:"), peripheral__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="rssi">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheral:didReadRSSI:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RssiRead (CBPeripheral peripheral, NSNumber rssi, NSError? error)
		{
			_RssiRead (this, peripheral, rssi, error);
		}
		/// <param name="peripheral">To be added.</param><param name="rssi">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RssiRead (ICBPeripheralDelegate This, CBPeripheral peripheral, NSNumber rssi, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var rssi__handle__ = rssi!.GetNonNullHandle (nameof (rssi));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didReadRSSI:error:"), peripheral__handle__, rssi__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (rssi);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheral:didDiscoverServices:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DiscoveredService (CBPeripheral peripheral, NSError? error)
		{
			_DiscoveredService (this, peripheral, error);
		}
		/// <param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DiscoveredService (ICBPeripheralDelegate This, CBPeripheral peripheral, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didDiscoverServices:"), peripheral__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="service">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheral:didDiscoverIncludedServicesForService:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DiscoveredIncludedService (CBPeripheral peripheral, CBService service, NSError? error)
		{
			_DiscoveredIncludedService (this, peripheral, service, error);
		}
		/// <param name="peripheral">To be added.</param><param name="service">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DiscoveredIncludedService (ICBPeripheralDelegate This, CBPeripheral peripheral, CBService service, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didDiscoverIncludedServicesForService:error:"), peripheral__handle__, service__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (service);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="service">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheral:didDiscoverCharacteristicsForService:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DiscoveredCharacteristics (CBPeripheral peripheral, CBService service, NSError? error)
		{
			_DiscoveredCharacteristics (this, peripheral, service, error);
		}
		/// <param name="peripheral">To be added.</param><param name="service">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DiscoveredCharacteristics (ICBPeripheralDelegate This, CBPeripheral peripheral, CBService service, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didDiscoverCharacteristicsForService:error:"), peripheral__handle__, service__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (service);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="characteristic">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheral:didUpdateValueForCharacteristic:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedCharacterteristicValue (CBPeripheral peripheral, CBCharacteristic characteristic, NSError? error)
		{
			_UpdatedCharacterteristicValue (this, peripheral, characteristic, error);
		}
		/// <param name="peripheral">To be added.</param><param name="characteristic">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdatedCharacterteristicValue (ICBPeripheralDelegate This, CBPeripheral peripheral, CBCharacteristic characteristic, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var characteristic__handle__ = characteristic!.GetNonNullHandle (nameof (characteristic));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didUpdateValueForCharacteristic:error:"), peripheral__handle__, characteristic__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (characteristic);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="characteristic">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheral:didWriteValueForCharacteristic:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WroteCharacteristicValue (CBPeripheral peripheral, CBCharacteristic characteristic, NSError? error)
		{
			_WroteCharacteristicValue (this, peripheral, characteristic, error);
		}
		/// <param name="peripheral">To be added.</param><param name="characteristic">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WroteCharacteristicValue (ICBPeripheralDelegate This, CBPeripheral peripheral, CBCharacteristic characteristic, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var characteristic__handle__ = characteristic!.GetNonNullHandle (nameof (characteristic));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didWriteValueForCharacteristic:error:"), peripheral__handle__, characteristic__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (characteristic);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="characteristic">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheral:didUpdateNotificationStateForCharacteristic:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedNotificationState (CBPeripheral peripheral, CBCharacteristic characteristic, NSError? error)
		{
			_UpdatedNotificationState (this, peripheral, characteristic, error);
		}
		/// <param name="peripheral">To be added.</param><param name="characteristic">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdatedNotificationState (ICBPeripheralDelegate This, CBPeripheral peripheral, CBCharacteristic characteristic, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var characteristic__handle__ = characteristic!.GetNonNullHandle (nameof (characteristic));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didUpdateNotificationStateForCharacteristic:error:"), peripheral__handle__, characteristic__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (characteristic);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="characteristic">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheral:didDiscoverDescriptorsForCharacteristic:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DiscoveredDescriptor (CBPeripheral peripheral, CBCharacteristic characteristic, NSError? error)
		{
			_DiscoveredDescriptor (this, peripheral, characteristic, error);
		}
		/// <param name="peripheral">To be added.</param><param name="characteristic">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DiscoveredDescriptor (ICBPeripheralDelegate This, CBPeripheral peripheral, CBCharacteristic characteristic, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var characteristic__handle__ = characteristic!.GetNonNullHandle (nameof (characteristic));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didDiscoverDescriptorsForCharacteristic:error:"), peripheral__handle__, characteristic__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (characteristic);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="descriptor">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheral:didUpdateValueForDescriptor:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedValue (CBPeripheral peripheral, CBDescriptor descriptor, NSError? error)
		{
			_UpdatedValue (this, peripheral, descriptor, error);
		}
		/// <param name="peripheral">To be added.</param><param name="descriptor">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdatedValue (ICBPeripheralDelegate This, CBPeripheral peripheral, CBDescriptor descriptor, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didUpdateValueForDescriptor:error:"), peripheral__handle__, descriptor__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="descriptor">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheral:didWriteValueForDescriptor:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WroteDescriptorValue (CBPeripheral peripheral, CBDescriptor descriptor, NSError? error)
		{
			_WroteDescriptorValue (this, peripheral, descriptor, error);
		}
		/// <param name="peripheral">To be added.</param><param name="descriptor">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WroteDescriptorValue (ICBPeripheralDelegate This, CBPeripheral peripheral, CBDescriptor descriptor, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didWriteValueForDescriptor:error:"), peripheral__handle__, descriptor__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheralDidUpdateName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedName (CBPeripheral peripheral)
		{
			_UpdatedName (this, peripheral);
		}
		/// <param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdatedName (ICBPeripheralDelegate This, CBPeripheral peripheral)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("peripheralDidUpdateName:"), peripheral__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
		}
		/// <param name="peripheral">To be added.</param><param name="services">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheral:didModifyServices:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ModifiedServices (CBPeripheral peripheral, CBService[] services)
		{
			_ModifiedServices (this, peripheral, services);
		}
		/// <param name="peripheral">To be added.</param><param name="services">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ModifiedServices (ICBPeripheralDelegate This, CBPeripheral peripheral, CBService[] services)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			if (services is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (services));
			using var nsa_services = NSArray.FromNSObjects (services);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didModifyServices:"), peripheral__handle__, nsa_services.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
		}
		/// <param name="peripheral">To be added.</param><param name="channel"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheral:didOpenL2CAPChannel:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOpenL2CapChannel (CBPeripheral peripheral, CBL2CapChannel? channel, NSError? error)
		{
			_DidOpenL2CapChannel (this, peripheral, channel, error);
		}
		/// <param name="peripheral">To be added.</param><param name="channel"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidOpenL2CapChannel (ICBPeripheralDelegate This, CBPeripheral peripheral, CBL2CapChannel? channel, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var channel__handle__ = channel.GetHandle ();
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didOpenL2CAPChannel:error:"), peripheral__handle__, channel__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (channel);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheralIsReadyToSendWriteWithoutResponse:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void IsReadyToSendWriteWithoutResponse (CBPeripheral peripheral)
		{
			_IsReadyToSendWriteWithoutResponse (this, peripheral);
		}
		/// <param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _IsReadyToSendWriteWithoutResponse (ICBPeripheralDelegate This, CBPeripheral peripheral)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("peripheralIsReadyToSendWriteWithoutResponse:"), peripheral__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
		}
		[DynamicDependencyAttribute ("DidOpenL2CapChannel(CoreBluetooth.CBPeripheral,CoreBluetooth.CBL2CapChannel,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DiscoveredCharacteristics(CoreBluetooth.CBPeripheral,CoreBluetooth.CBService,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DiscoveredDescriptor(CoreBluetooth.CBPeripheral,CoreBluetooth.CBCharacteristic,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DiscoveredIncludedService(CoreBluetooth.CBPeripheral,CoreBluetooth.CBService,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DiscoveredService(CoreBluetooth.CBPeripheral,Foundation.NSError)")]
		[DynamicDependencyAttribute ("IsReadyToSendWriteWithoutResponse(CoreBluetooth.CBPeripheral)")]
		[DynamicDependencyAttribute ("ModifiedServices(CoreBluetooth.CBPeripheral,CoreBluetooth.CBService[])")]
		[DynamicDependencyAttribute ("RssiRead(CoreBluetooth.CBPeripheral,Foundation.NSNumber,Foundation.NSError)")]
		[DynamicDependencyAttribute ("RssiUpdated(CoreBluetooth.CBPeripheral,Foundation.NSError)")]
		[DynamicDependencyAttribute ("UpdatedCharacterteristicValue(CoreBluetooth.CBPeripheral,CoreBluetooth.CBCharacteristic,Foundation.NSError)")]
		[DynamicDependencyAttribute ("UpdatedName(CoreBluetooth.CBPeripheral)")]
		[DynamicDependencyAttribute ("UpdatedNotificationState(CoreBluetooth.CBPeripheral,CoreBluetooth.CBCharacteristic,Foundation.NSError)")]
		[DynamicDependencyAttribute ("UpdatedValue(CoreBluetooth.CBPeripheral,CoreBluetooth.CBDescriptor,Foundation.NSError)")]
		[DynamicDependencyAttribute ("WroteCharacteristicValue(CoreBluetooth.CBPeripheral,CoreBluetooth.CBCharacteristic,Foundation.NSError)")]
		[DynamicDependencyAttribute ("WroteDescriptorValue(CoreBluetooth.CBPeripheral,CoreBluetooth.CBDescriptor,Foundation.NSError)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CBPeripheralDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICBPeripheralDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICBPeripheralDelegate" /> interface to support all the methods from the CBPeripheralDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICBPeripheralDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CBPeripheralDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CBPeripheralDelegate_Extensions {
		/// <param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.13", "Use 'RssiRead' instead.")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'RssiRead' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'RssiRead' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'RssiRead' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RssiUpdated (this ICBPeripheralDelegate This, CBPeripheral peripheral, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheralDidUpdateRSSI:error:"), peripheral__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="rssi">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RssiRead (this ICBPeripheralDelegate This, CBPeripheral peripheral, NSNumber rssi, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var rssi__handle__ = rssi!.GetNonNullHandle (nameof (rssi));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didReadRSSI:error:"), peripheral__handle__, rssi__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (rssi);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DiscoveredService (this ICBPeripheralDelegate This, CBPeripheral peripheral, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didDiscoverServices:"), peripheral__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="service">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DiscoveredIncludedService (this ICBPeripheralDelegate This, CBPeripheral peripheral, CBService service, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didDiscoverIncludedServicesForService:error:"), peripheral__handle__, service__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (service);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="service">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DiscoveredCharacteristics (this ICBPeripheralDelegate This, CBPeripheral peripheral, CBService service, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didDiscoverCharacteristicsForService:error:"), peripheral__handle__, service__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (service);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="characteristic">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdatedCharacterteristicValue (this ICBPeripheralDelegate This, CBPeripheral peripheral, CBCharacteristic characteristic, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var characteristic__handle__ = characteristic!.GetNonNullHandle (nameof (characteristic));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didUpdateValueForCharacteristic:error:"), peripheral__handle__, characteristic__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (characteristic);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="characteristic">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WroteCharacteristicValue (this ICBPeripheralDelegate This, CBPeripheral peripheral, CBCharacteristic characteristic, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var characteristic__handle__ = characteristic!.GetNonNullHandle (nameof (characteristic));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didWriteValueForCharacteristic:error:"), peripheral__handle__, characteristic__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (characteristic);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="characteristic">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdatedNotificationState (this ICBPeripheralDelegate This, CBPeripheral peripheral, CBCharacteristic characteristic, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var characteristic__handle__ = characteristic!.GetNonNullHandle (nameof (characteristic));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didUpdateNotificationStateForCharacteristic:error:"), peripheral__handle__, characteristic__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (characteristic);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="characteristic">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DiscoveredDescriptor (this ICBPeripheralDelegate This, CBPeripheral peripheral, CBCharacteristic characteristic, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var characteristic__handle__ = characteristic!.GetNonNullHandle (nameof (characteristic));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didDiscoverDescriptorsForCharacteristic:error:"), peripheral__handle__, characteristic__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (characteristic);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="descriptor">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdatedValue (this ICBPeripheralDelegate This, CBPeripheral peripheral, CBDescriptor descriptor, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didUpdateValueForDescriptor:error:"), peripheral__handle__, descriptor__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="descriptor">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WroteDescriptorValue (this ICBPeripheralDelegate This, CBPeripheral peripheral, CBDescriptor descriptor, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didWriteValueForDescriptor:error:"), peripheral__handle__, descriptor__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdatedName (this ICBPeripheralDelegate This, CBPeripheral peripheral)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("peripheralDidUpdateName:"), peripheral__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
		}
		/// <param name="peripheral">To be added.</param><param name="services">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ModifiedServices (this ICBPeripheralDelegate This, CBPeripheral peripheral, CBService[] services)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			if (services is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (services));
			using var nsa_services = NSArray.FromNSObjects (services);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didModifyServices:"), peripheral__handle__, nsa_services.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
		}
		/// <param name="peripheral">To be added.</param><param name="channel"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidOpenL2CapChannel (this ICBPeripheralDelegate This, CBPeripheral peripheral, CBL2CapChannel? channel, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var channel__handle__ = channel.GetHandle ();
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheral:didOpenL2CAPChannel:error:"), peripheral__handle__, channel__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (channel);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void IsReadyToSendWriteWithoutResponse (this ICBPeripheralDelegate This, CBPeripheral peripheral)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("peripheralIsReadyToSendWriteWithoutResponse:"), peripheral__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CBPeripheralDelegateWrapper : BaseWrapper, ICBPeripheralDelegate {
		public CBPeripheralDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CBPeripheralDelegateWrapper))]
		static CBPeripheralDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace CoreBluetooth {
	/// <summary>Delegate object for <see cref="T:CoreBluetooth.CBPeripheral" />. Provides methods called on events relating to discovery, exploration, and interaction with a remote peripheral.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBPeripheralDelegate_Protocol/index.html">Apple documentation for <c>CBPeripheralDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_tvOS__CoreBluetooth_CBPeripheralDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class CBPeripheralDelegate : NSObject, ICBPeripheralDelegate {
		/// <summary>Creates a new <see cref="CBPeripheralDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CBPeripheralDelegate () : base (NSObjectFlag.Empty)
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
		protected CBPeripheralDelegate (NSObjectFlag t) : base (t)
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
		protected internal CBPeripheralDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="peripheral">To be added.</param><param name="channel"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheral:didOpenL2CAPChannel:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOpenL2CapChannel (CBPeripheral peripheral, CBL2CapChannel? channel, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="service">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheral:didDiscoverCharacteristicsForService:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DiscoveredCharacteristics (CBPeripheral peripheral, CBService service, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="characteristic">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheral:didDiscoverDescriptorsForCharacteristic:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DiscoveredDescriptor (CBPeripheral peripheral, CBCharacteristic characteristic, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="service">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheral:didDiscoverIncludedServicesForService:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DiscoveredIncludedService (CBPeripheral peripheral, CBService service, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheral:didDiscoverServices:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DiscoveredService (CBPeripheral peripheral, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheralIsReadyToSendWriteWithoutResponse:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void IsReadyToSendWriteWithoutResponse (CBPeripheral peripheral)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="services">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheral:didModifyServices:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ModifiedServices (CBPeripheral peripheral, CBService[] services)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="rssi">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheral:didReadRSSI:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RssiRead (CBPeripheral peripheral, NSNumber rssi, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheralDidUpdateRSSI:error:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'RssiRead' instead.")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'RssiRead' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'RssiRead' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'RssiRead' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RssiUpdated (CBPeripheral peripheral, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="characteristic">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheral:didUpdateValueForCharacteristic:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedCharacterteristicValue (CBPeripheral peripheral, CBCharacteristic characteristic, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheralDidUpdateName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedName (CBPeripheral peripheral)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="characteristic">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheral:didUpdateNotificationStateForCharacteristic:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedNotificationState (CBPeripheral peripheral, CBCharacteristic characteristic, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="descriptor">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheral:didUpdateValueForDescriptor:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedValue (CBPeripheral peripheral, CBDescriptor descriptor, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="characteristic">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheral:didWriteValueForCharacteristic:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WroteCharacteristicValue (CBPeripheral peripheral, CBCharacteristic characteristic, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="descriptor">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheral:didWriteValueForDescriptor:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WroteDescriptorValue (CBPeripheral peripheral, CBDescriptor descriptor, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CBPeripheralDelegate */
}
