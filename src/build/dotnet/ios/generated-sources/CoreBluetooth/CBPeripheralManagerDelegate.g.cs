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
namespace CoreBluetooth {
	#pragma warning disable CS1573
	/// <summary>Delegate object for <see cref="T:CoreBluetooth.CBPeripheralManager" />. Adds methods for events relating to availability, publishing, advertising, and subscription.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBPeripheralManagerDelegate_Protocol/index.html">Apple documentation for <c>CBPeripheralManagerDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "CBPeripheralManagerDelegate", WrapperType = typeof (CBPeripheralManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StateUpdated", Selector = "peripheralManagerDidUpdateState:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheralManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillRestoreState", Selector = "peripheralManager:willRestoreState:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheralManager), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AdvertisingStarted", Selector = "peripheralManagerDidStartAdvertising:error:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheralManager), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ServiceAdded", Selector = "peripheralManager:didAddService:error:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheralManager), typeof (CoreBluetooth.CBService), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CharacteristicSubscribed", Selector = "peripheralManager:central:didSubscribeToCharacteristic:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheralManager), typeof (CoreBluetooth.CBCentral), typeof (CoreBluetooth.CBCharacteristic) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CharacteristicUnsubscribed", Selector = "peripheralManager:central:didUnsubscribeFromCharacteristic:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheralManager), typeof (CoreBluetooth.CBCentral), typeof (CoreBluetooth.CBCharacteristic) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReadRequestReceived", Selector = "peripheralManager:didReceiveReadRequest:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheralManager), typeof (CoreBluetooth.CBATTRequest) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteRequestsReceived", Selector = "peripheralManager:didReceiveWriteRequests:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheralManager), typeof (CoreBluetooth.CBATTRequest[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReadyToUpdateSubscribers", Selector = "peripheralManagerIsReadyToUpdateSubscribers:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheralManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOpenL2CapChannel", Selector = "peripheralManager:didOpenL2CAPChannel:error:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheralManager), typeof (CoreBluetooth.CBL2CapChannel), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUnpublishL2CapChannel", Selector = "peripheralManager:didUnpublishL2CAPChannel:error:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheralManager), typeof (UInt16), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPublishL2CapChannel", Selector = "peripheralManager:didPublishL2CAPChannel:error:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheralManager), typeof (UInt16), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface ICBPeripheralManagerDelegate : INativeObject, IDisposable
	{
		/// <param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("peripheralManagerDidUpdateState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StateUpdated (CBPeripheralManager peripheral)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _StateUpdated (ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManagerDidUpdateState:"), peripheral__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
		}
		/// <param name="peripheral">To be added.</param><param name="dict">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheralManager:willRestoreState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillRestoreState (CBPeripheralManager peripheral, NSDictionary dict)
		{
			_WillRestoreState (this, peripheral, dict);
		}
		/// <param name="peripheral">To be added.</param><param name="dict">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillRestoreState (ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, NSDictionary dict)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var dict__handle__ = dict!.GetNonNullHandle (nameof (dict));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManager:willRestoreState:"), peripheral__handle__, dict__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (dict);
		}
		/// <param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheralManagerDidStartAdvertising:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdvertisingStarted (CBPeripheralManager peripheral, NSError? error)
		{
			_AdvertisingStarted (this, peripheral, error);
		}
		/// <param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AdvertisingStarted (ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManagerDidStartAdvertising:error:"), peripheral__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="service">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheralManager:didAddService:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ServiceAdded (CBPeripheralManager peripheral, CBService service, NSError? error)
		{
			_ServiceAdded (this, peripheral, service, error);
		}
		/// <param name="peripheral">To be added.</param><param name="service">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ServiceAdded (ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, CBService service, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManager:didAddService:error:"), peripheral__handle__, service__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (service);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="central">To be added.</param><param name="characteristic">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheralManager:central:didSubscribeToCharacteristic:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CharacteristicSubscribed (CBPeripheralManager peripheral, CBCentral central, CBCharacteristic characteristic)
		{
			_CharacteristicSubscribed (this, peripheral, central, characteristic);
		}
		/// <param name="peripheral">To be added.</param><param name="central">To be added.</param><param name="characteristic">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CharacteristicSubscribed (ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, CBCentral central, CBCharacteristic characteristic)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var characteristic__handle__ = characteristic!.GetNonNullHandle (nameof (characteristic));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManager:central:didSubscribeToCharacteristic:"), peripheral__handle__, central__handle__, characteristic__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (central);
			GC.KeepAlive (characteristic);
		}
		/// <param name="peripheral">To be added.</param><param name="central">To be added.</param><param name="characteristic">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheralManager:central:didUnsubscribeFromCharacteristic:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CharacteristicUnsubscribed (CBPeripheralManager peripheral, CBCentral central, CBCharacteristic characteristic)
		{
			_CharacteristicUnsubscribed (this, peripheral, central, characteristic);
		}
		/// <param name="peripheral">To be added.</param><param name="central">To be added.</param><param name="characteristic">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CharacteristicUnsubscribed (ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, CBCentral central, CBCharacteristic characteristic)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var characteristic__handle__ = characteristic!.GetNonNullHandle (nameof (characteristic));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManager:central:didUnsubscribeFromCharacteristic:"), peripheral__handle__, central__handle__, characteristic__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (central);
			GC.KeepAlive (characteristic);
		}
		/// <param name="peripheral">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheralManager:didReceiveReadRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReadRequestReceived (CBPeripheralManager peripheral, CBATTRequest request)
		{
			_ReadRequestReceived (this, peripheral, request);
		}
		/// <param name="peripheral">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReadRequestReceived (ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, CBATTRequest request)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManager:didReceiveReadRequest:"), peripheral__handle__, request__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (request);
		}
		/// <param name="peripheral">To be added.</param><param name="requests">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheralManager:didReceiveWriteRequests:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteRequestsReceived (CBPeripheralManager peripheral, CBATTRequest[] requests)
		{
			_WriteRequestsReceived (this, peripheral, requests);
		}
		/// <param name="peripheral">To be added.</param><param name="requests">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WriteRequestsReceived (ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, CBATTRequest[] requests)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			if (requests is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (requests));
			using var nsa_requests = NSArray.FromNSObjects (requests);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManager:didReceiveWriteRequests:"), peripheral__handle__, nsa_requests.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
		}
		/// <param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheralManagerIsReadyToUpdateSubscribers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReadyToUpdateSubscribers (CBPeripheralManager peripheral)
		{
			_ReadyToUpdateSubscribers (this, peripheral);
		}
		/// <param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReadyToUpdateSubscribers (ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManagerIsReadyToUpdateSubscribers:"), peripheral__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
		}
		/// <param name="peripheral">To be added.</param><param name="channel"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheralManager:didOpenL2CAPChannel:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOpenL2CapChannel (CBPeripheralManager peripheral, CBL2CapChannel? channel, NSError? error)
		{
			_DidOpenL2CapChannel (this, peripheral, channel, error);
		}
		/// <param name="peripheral">To be added.</param><param name="channel"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidOpenL2CapChannel (ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, CBL2CapChannel? channel, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var channel__handle__ = channel.GetHandle ();
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManager:didOpenL2CAPChannel:error:"), peripheral__handle__, channel__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (channel);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="psm">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheralManager:didUnpublishL2CAPChannel:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUnpublishL2CapChannel (CBPeripheralManager peripheral, ushort psm, NSError? error)
		{
			_DidUnpublishL2CapChannel (this, peripheral, psm, error);
		}
		/// <param name="peripheral">To be added.</param><param name="psm">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUnpublishL2CapChannel (ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, ushort psm, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt16_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManager:didUnpublishL2CAPChannel:error:"), peripheral__handle__, psm, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="psm">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peripheralManager:didPublishL2CAPChannel:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPublishL2CapChannel (CBPeripheralManager peripheral, ushort psm, NSError? error)
		{
			_DidPublishL2CapChannel (this, peripheral, psm, error);
		}
		/// <param name="peripheral">To be added.</param><param name="psm">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidPublishL2CapChannel (ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, ushort psm, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt16_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManager:didPublishL2CAPChannel:error:"), peripheral__handle__, psm, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("AdvertisingStarted(CoreBluetooth.CBPeripheralManager,Foundation.NSError)")]
		[DynamicDependencyAttribute ("CharacteristicSubscribed(CoreBluetooth.CBPeripheralManager,CoreBluetooth.CBCentral,CoreBluetooth.CBCharacteristic)")]
		[DynamicDependencyAttribute ("CharacteristicUnsubscribed(CoreBluetooth.CBPeripheralManager,CoreBluetooth.CBCentral,CoreBluetooth.CBCharacteristic)")]
		[DynamicDependencyAttribute ("DidOpenL2CapChannel(CoreBluetooth.CBPeripheralManager,CoreBluetooth.CBL2CapChannel,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidPublishL2CapChannel(CoreBluetooth.CBPeripheralManager,System.UInt16,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidUnpublishL2CapChannel(CoreBluetooth.CBPeripheralManager,System.UInt16,Foundation.NSError)")]
		[DynamicDependencyAttribute ("ReadRequestReceived(CoreBluetooth.CBPeripheralManager,CoreBluetooth.CBATTRequest)")]
		[DynamicDependencyAttribute ("ReadyToUpdateSubscribers(CoreBluetooth.CBPeripheralManager)")]
		[DynamicDependencyAttribute ("ServiceAdded(CoreBluetooth.CBPeripheralManager,CoreBluetooth.CBService,Foundation.NSError)")]
		[DynamicDependencyAttribute ("StateUpdated(CoreBluetooth.CBPeripheralManager)")]
		[DynamicDependencyAttribute ("WillRestoreState(CoreBluetooth.CBPeripheralManager,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("WriteRequestsReceived(CoreBluetooth.CBPeripheralManager,CoreBluetooth.CBATTRequest[])")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CBPeripheralManagerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICBPeripheralManagerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICBPeripheralManagerDelegate" /> interface to support all the methods from the CBPeripheralManagerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICBPeripheralManagerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CBPeripheralManagerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CBPeripheralManagerDelegate_Extensions {
		/// <param name="peripheral">To be added.</param><param name="dict">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillRestoreState (this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, NSDictionary dict)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var dict__handle__ = dict!.GetNonNullHandle (nameof (dict));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManager:willRestoreState:"), peripheral__handle__, dict__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (dict);
		}
		/// <param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AdvertisingStarted (this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManagerDidStartAdvertising:error:"), peripheral__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="service">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ServiceAdded (this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, CBService service, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManager:didAddService:error:"), peripheral__handle__, service__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (service);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="central">To be added.</param><param name="characteristic">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CharacteristicSubscribed (this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, CBCentral central, CBCharacteristic characteristic)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var characteristic__handle__ = characteristic!.GetNonNullHandle (nameof (characteristic));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManager:central:didSubscribeToCharacteristic:"), peripheral__handle__, central__handle__, characteristic__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (central);
			GC.KeepAlive (characteristic);
		}
		/// <param name="peripheral">To be added.</param><param name="central">To be added.</param><param name="characteristic">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CharacteristicUnsubscribed (this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, CBCentral central, CBCharacteristic characteristic)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var characteristic__handle__ = characteristic!.GetNonNullHandle (nameof (characteristic));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManager:central:didUnsubscribeFromCharacteristic:"), peripheral__handle__, central__handle__, characteristic__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (central);
			GC.KeepAlive (characteristic);
		}
		/// <param name="peripheral">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReadRequestReceived (this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, CBATTRequest request)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManager:didReceiveReadRequest:"), peripheral__handle__, request__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (request);
		}
		/// <param name="peripheral">To be added.</param><param name="requests">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WriteRequestsReceived (this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, CBATTRequest[] requests)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			if (requests is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (requests));
			using var nsa_requests = NSArray.FromNSObjects (requests);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManager:didReceiveWriteRequests:"), peripheral__handle__, nsa_requests.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
		}
		/// <param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReadyToUpdateSubscribers (this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManagerIsReadyToUpdateSubscribers:"), peripheral__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
		}
		/// <param name="peripheral">To be added.</param><param name="channel"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidOpenL2CapChannel (this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, CBL2CapChannel? channel, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var channel__handle__ = channel.GetHandle ();
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManager:didOpenL2CAPChannel:error:"), peripheral__handle__, channel__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (channel);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="psm">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUnpublishL2CapChannel (this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, ushort psm, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt16_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManager:didUnpublishL2CAPChannel:error:"), peripheral__handle__, psm, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (error);
		}
		/// <param name="peripheral">To be added.</param><param name="psm">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPublishL2CapChannel (this ICBPeripheralManagerDelegate This, CBPeripheralManager peripheral, ushort psm, NSError? error)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt16_NativeHandle (This.Handle, Selector.GetHandle ("peripheralManager:didPublishL2CAPChannel:error:"), peripheral__handle__, psm, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (error);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CBPeripheralManagerDelegateWrapper : BaseWrapper, ICBPeripheralManagerDelegate {
		public CBPeripheralManagerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CBPeripheralManagerDelegateWrapper))]
		static CBPeripheralManagerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheralManagerDidUpdateState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void StateUpdated (CBPeripheralManager peripheral)
		{
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("peripheralManagerDidUpdateState:"), peripheral__handle__);
			GC.KeepAlive (peripheral);
		}
	}
}
namespace CoreBluetooth {
	/// <summary>Delegate object for <see cref="T:CoreBluetooth.CBPeripheralManager" />. Adds methods for events relating to availability, publishing, advertising, and subscription.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBPeripheralManagerDelegate_Protocol/index.html">Apple documentation for <c>CBPeripheralManagerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__CoreBluetooth_CBPeripheralManagerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class CBPeripheralManagerDelegate : NSObject, ICBPeripheralManagerDelegate {
		/// <summary>Creates a new <see cref="CBPeripheralManagerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CBPeripheralManagerDelegate () : base (NSObjectFlag.Empty)
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
		protected CBPeripheralManagerDelegate (NSObjectFlag t) : base (t)
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
		protected internal CBPeripheralManagerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheralManagerDidStartAdvertising:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdvertisingStarted (CBPeripheralManager peripheral, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="central">To be added.</param><param name="characteristic">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheralManager:central:didSubscribeToCharacteristic:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CharacteristicSubscribed (CBPeripheralManager peripheral, CBCentral central, CBCharacteristic characteristic)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="central">To be added.</param><param name="characteristic">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheralManager:central:didUnsubscribeFromCharacteristic:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CharacteristicUnsubscribed (CBPeripheralManager peripheral, CBCentral central, CBCharacteristic characteristic)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="channel"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheralManager:didOpenL2CAPChannel:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOpenL2CapChannel (CBPeripheralManager peripheral, CBL2CapChannel? channel, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="psm">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheralManager:didPublishL2CAPChannel:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPublishL2CapChannel (CBPeripheralManager peripheral, ushort psm, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="psm">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheralManager:didUnpublishL2CAPChannel:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUnpublishL2CapChannel (CBPeripheralManager peripheral, ushort psm, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheralManager:didReceiveReadRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReadRequestReceived (CBPeripheralManager peripheral, CBATTRequest request)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheralManagerIsReadyToUpdateSubscribers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReadyToUpdateSubscribers (CBPeripheralManager peripheral)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="service">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheralManager:didAddService:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ServiceAdded (CBPeripheralManager peripheral, CBService service, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheralManagerDidUpdateState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StateUpdated (CBPeripheralManager peripheral)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="dict">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheralManager:willRestoreState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillRestoreState (CBPeripheralManager peripheral, NSDictionary dict)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peripheral">To be added.</param><param name="requests">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peripheralManager:didReceiveWriteRequests:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteRequestsReceived (CBPeripheralManager peripheral, CBATTRequest[] requests)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CBPeripheralManagerDelegate */
}
