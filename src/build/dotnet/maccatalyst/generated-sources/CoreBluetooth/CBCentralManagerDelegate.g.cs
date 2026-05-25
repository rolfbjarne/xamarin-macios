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
namespace CoreBluetooth {
	#pragma warning disable CS1573
	/// <summary>Delegate objects for <see cref="T:CoreBluetooth.CBCentralManager" /> objects.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBCentralManagerDelegate_Protocol/index.html">Apple documentation for <c>CBCentralManagerDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "CBCentralManagerDelegate", WrapperType = typeof (CBCentralManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdatedState", Selector = "centralManagerDidUpdateState:", ParameterType = new Type [] { typeof (CoreBluetooth.CBCentralManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DiscoveredPeripheral", Selector = "centralManager:didDiscoverPeripheral:advertisementData:RSSI:", ParameterType = new Type [] { typeof (CoreBluetooth.CBCentralManager), typeof (CoreBluetooth.CBPeripheral), typeof (NSDictionary), typeof (NSNumber) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConnectedPeripheral", Selector = "centralManager:didConnectPeripheral:", ParameterType = new Type [] { typeof (CoreBluetooth.CBCentralManager), typeof (CoreBluetooth.CBPeripheral) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToConnectPeripheral", Selector = "centralManager:didFailToConnectPeripheral:error:", ParameterType = new Type [] { typeof (CoreBluetooth.CBCentralManager), typeof (CoreBluetooth.CBPeripheral), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DisconnectedPeripheral", Selector = "centralManager:didDisconnectPeripheral:error:", ParameterType = new Type [] { typeof (CoreBluetooth.CBCentralManager), typeof (CoreBluetooth.CBPeripheral), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillRestoreState", Selector = "centralManager:willRestoreState:", ParameterType = new Type [] { typeof (CoreBluetooth.CBCentralManager), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConnectionEventDidOccur", Selector = "centralManager:connectionEventDidOccur:forPeripheral:", ParameterType = new Type [] { typeof (CoreBluetooth.CBCentralManager), typeof (CoreBluetooth.CBConnectionEvent), typeof (CoreBluetooth.CBPeripheral) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateAncsAuthorization", Selector = "centralManager:didUpdateANCSAuthorizationForPeripheral:", ParameterType = new Type [] { typeof (CoreBluetooth.CBCentralManager), typeof (CoreBluetooth.CBPeripheral) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDisconnectPeripheral", Selector = "centralManager:didDisconnectPeripheral:timestamp:isReconnecting:error:", ParameterType = new Type [] { typeof (CoreBluetooth.CBCentralManager), typeof (CoreBluetooth.CBPeripheral), typeof (double), typeof (bool), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	public partial interface ICBCentralManagerDelegate : INativeObject, IDisposable
	{
		/// <param name="central">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("centralManagerDidUpdateState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedState (CBCentralManager central)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="central">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdatedState (ICBCentralManagerDelegate This, CBCentralManager central)
		{
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("centralManagerDidUpdateState:"), central__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (central);
		}
		/// <param name="central">To be added.</param><param name="peripheral">To be added.</param><param name="advertisementData">To be added.</param><param name="RSSI">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("centralManager:didDiscoverPeripheral:advertisementData:RSSI:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DiscoveredPeripheral (CBCentralManager central, CBPeripheral peripheral, NSDictionary advertisementData, NSNumber RSSI)
		{
			_DiscoveredPeripheral (this, central, peripheral, advertisementData, RSSI);
		}
		/// <param name="central">To be added.</param><param name="peripheral">To be added.</param><param name="advertisementData">To be added.</param><param name="RSSI">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DiscoveredPeripheral (ICBCentralManagerDelegate This, CBCentralManager central, CBPeripheral peripheral, NSDictionary advertisementData, NSNumber RSSI)
		{
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var advertisementData__handle__ = advertisementData!.GetNonNullHandle (nameof (advertisementData));
			var RSSI__handle__ = RSSI!.GetNonNullHandle (nameof (RSSI));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("centralManager:didDiscoverPeripheral:advertisementData:RSSI:"), central__handle__, peripheral__handle__, advertisementData__handle__, RSSI__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (central);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (advertisementData);
			GC.KeepAlive (RSSI);
		}
		/// <param name="central">To be added.</param><param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("centralManager:didConnectPeripheral:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConnectedPeripheral (CBCentralManager central, CBPeripheral peripheral)
		{
			_ConnectedPeripheral (this, central, peripheral);
		}
		/// <param name="central">To be added.</param><param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ConnectedPeripheral (ICBCentralManagerDelegate This, CBCentralManager central, CBPeripheral peripheral)
		{
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("centralManager:didConnectPeripheral:"), central__handle__, peripheral__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (central);
			GC.KeepAlive (peripheral);
		}
		/// <param name="central">To be added.</param><param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("centralManager:didFailToConnectPeripheral:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToConnectPeripheral (CBCentralManager central, CBPeripheral peripheral, NSError? error)
		{
			_FailedToConnectPeripheral (this, central, peripheral, error);
		}
		/// <param name="central">To be added.</param><param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedToConnectPeripheral (ICBCentralManagerDelegate This, CBCentralManager central, CBPeripheral peripheral, NSError? error)
		{
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("centralManager:didFailToConnectPeripheral:error:"), central__handle__, peripheral__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (central);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (error);
		}
		/// <param name="central">To be added.</param><param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("centralManager:didDisconnectPeripheral:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisconnectedPeripheral (CBCentralManager central, CBPeripheral peripheral, NSError? error)
		{
			_DisconnectedPeripheral (this, central, peripheral, error);
		}
		/// <param name="central">To be added.</param><param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DisconnectedPeripheral (ICBCentralManagerDelegate This, CBCentralManager central, CBPeripheral peripheral, NSError? error)
		{
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("centralManager:didDisconnectPeripheral:error:"), central__handle__, peripheral__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (central);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (error);
		}
		/// <param name="central">To be added.</param><param name="dict">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("centralManager:willRestoreState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillRestoreState (CBCentralManager central, NSDictionary dict)
		{
			_WillRestoreState (this, central, dict);
		}
		/// <param name="central">To be added.</param><param name="dict">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillRestoreState (ICBCentralManagerDelegate This, CBCentralManager central, NSDictionary dict)
		{
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var dict__handle__ = dict!.GetNonNullHandle (nameof (dict));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("centralManager:willRestoreState:"), central__handle__, dict__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (central);
			GC.KeepAlive (dict);
		}
		[global::Foundation.OptionalMember]
		[Export ("centralManager:connectionEventDidOccur:forPeripheral:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConnectionEventDidOccur (CBCentralManager central, CBConnectionEvent connectionEvent, CBPeripheral peripheral)
		{
			_ConnectionEventDidOccur (this, central, connectionEvent, peripheral);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ConnectionEventDidOccur (ICBCentralManagerDelegate This, CBCentralManager central, CBConnectionEvent connectionEvent, CBPeripheral peripheral)
		{
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("centralManager:connectionEventDidOccur:forPeripheral:"), central__handle__, (IntPtr) (long) connectionEvent, peripheral__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (central);
			GC.KeepAlive (peripheral);
		}
		[global::Foundation.OptionalMember]
		[Export ("centralManager:didUpdateANCSAuthorizationForPeripheral:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateAncsAuthorization (CBCentralManager central, CBPeripheral peripheral)
		{
			_DidUpdateAncsAuthorization (this, central, peripheral);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateAncsAuthorization (ICBCentralManagerDelegate This, CBCentralManager central, CBPeripheral peripheral)
		{
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("centralManager:didUpdateANCSAuthorizationForPeripheral:"), central__handle__, peripheral__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (central);
			GC.KeepAlive (peripheral);
		}
		[global::Foundation.OptionalMember]
		[Export ("centralManager:didDisconnectPeripheral:timestamp:isReconnecting:error:")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnectPeripheral (CBCentralManager central, CBPeripheral peripheral, double timestamp, bool isReconnecting, NSError? error)
		{
			_DidDisconnectPeripheral (this, central, peripheral, timestamp, isReconnecting, error);
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDisconnectPeripheral (ICBCentralManagerDelegate This, CBCentralManager central, CBPeripheral peripheral, double timestamp, bool isReconnecting, NSError? error)
		{
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Double_bool_NativeHandle (This.Handle, Selector.GetHandle ("centralManager:didDisconnectPeripheral:timestamp:isReconnecting:error:"), central__handle__, peripheral__handle__, timestamp, isReconnecting ? (byte) 1 : (byte) 0, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (central);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("ConnectedPeripheral(CoreBluetooth.CBCentralManager,CoreBluetooth.CBPeripheral)")]
		[DynamicDependencyAttribute ("ConnectionEventDidOccur(CoreBluetooth.CBCentralManager,CoreBluetooth.CBConnectionEvent,CoreBluetooth.CBPeripheral)")]
		[DynamicDependencyAttribute ("DidDisconnectPeripheral(CoreBluetooth.CBCentralManager,CoreBluetooth.CBPeripheral,System.Double,System.Boolean,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidUpdateAncsAuthorization(CoreBluetooth.CBCentralManager,CoreBluetooth.CBPeripheral)")]
		[DynamicDependencyAttribute ("DisconnectedPeripheral(CoreBluetooth.CBCentralManager,CoreBluetooth.CBPeripheral,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DiscoveredPeripheral(CoreBluetooth.CBCentralManager,CoreBluetooth.CBPeripheral,Foundation.NSDictionary,Foundation.NSNumber)")]
		[DynamicDependencyAttribute ("FailedToConnectPeripheral(CoreBluetooth.CBCentralManager,CoreBluetooth.CBPeripheral,Foundation.NSError)")]
		[DynamicDependencyAttribute ("UpdatedState(CoreBluetooth.CBCentralManager)")]
		[DynamicDependencyAttribute ("WillRestoreState(CoreBluetooth.CBCentralManager,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CBCentralManagerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICBCentralManagerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICBCentralManagerDelegate" /> interface to support all the methods from the CBCentralManagerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICBCentralManagerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CBCentralManagerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CBCentralManagerDelegate_Extensions {
		/// <param name="central">To be added.</param><param name="peripheral">To be added.</param><param name="advertisementData">To be added.</param><param name="RSSI">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DiscoveredPeripheral (this ICBCentralManagerDelegate This, CBCentralManager central, CBPeripheral peripheral, NSDictionary advertisementData, NSNumber RSSI)
		{
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var advertisementData__handle__ = advertisementData!.GetNonNullHandle (nameof (advertisementData));
			var RSSI__handle__ = RSSI!.GetNonNullHandle (nameof (RSSI));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("centralManager:didDiscoverPeripheral:advertisementData:RSSI:"), central__handle__, peripheral__handle__, advertisementData__handle__, RSSI__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (central);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (advertisementData);
			GC.KeepAlive (RSSI);
		}
		/// <param name="central">To be added.</param><param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConnectedPeripheral (this ICBCentralManagerDelegate This, CBCentralManager central, CBPeripheral peripheral)
		{
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("centralManager:didConnectPeripheral:"), central__handle__, peripheral__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (central);
			GC.KeepAlive (peripheral);
		}
		/// <param name="central">To be added.</param><param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedToConnectPeripheral (this ICBCentralManagerDelegate This, CBCentralManager central, CBPeripheral peripheral, NSError? error)
		{
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("centralManager:didFailToConnectPeripheral:error:"), central__handle__, peripheral__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (central);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (error);
		}
		/// <param name="central">To be added.</param><param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DisconnectedPeripheral (this ICBCentralManagerDelegate This, CBCentralManager central, CBPeripheral peripheral, NSError? error)
		{
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("centralManager:didDisconnectPeripheral:error:"), central__handle__, peripheral__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (central);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (error);
		}
		/// <param name="central">To be added.</param><param name="dict">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillRestoreState (this ICBCentralManagerDelegate This, CBCentralManager central, NSDictionary dict)
		{
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var dict__handle__ = dict!.GetNonNullHandle (nameof (dict));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("centralManager:willRestoreState:"), central__handle__, dict__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (central);
			GC.KeepAlive (dict);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConnectionEventDidOccur (this ICBCentralManagerDelegate This, CBCentralManager central, CBConnectionEvent connectionEvent, CBPeripheral peripheral)
		{
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("centralManager:connectionEventDidOccur:forPeripheral:"), central__handle__, (IntPtr) (long) connectionEvent, peripheral__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (central);
			GC.KeepAlive (peripheral);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateAncsAuthorization (this ICBCentralManagerDelegate This, CBCentralManager central, CBPeripheral peripheral)
		{
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("centralManager:didUpdateANCSAuthorizationForPeripheral:"), central__handle__, peripheral__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (central);
			GC.KeepAlive (peripheral);
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDisconnectPeripheral (this ICBCentralManagerDelegate This, CBCentralManager central, CBPeripheral peripheral, double timestamp, bool isReconnecting, NSError? error)
		{
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			var peripheral__handle__ = peripheral!.GetNonNullHandle (nameof (peripheral));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Double_bool_NativeHandle (This.Handle, Selector.GetHandle ("centralManager:didDisconnectPeripheral:timestamp:isReconnecting:error:"), central__handle__, peripheral__handle__, timestamp, isReconnecting ? (byte) 1 : (byte) 0, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (central);
			GC.KeepAlive (peripheral);
			GC.KeepAlive (error);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CBCentralManagerDelegateWrapper : BaseWrapper, ICBCentralManagerDelegate {
		public CBCentralManagerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CBCentralManagerDelegateWrapper))]
		static CBCentralManagerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="central">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("centralManagerDidUpdateState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UpdatedState (CBCentralManager central)
		{
			var central__handle__ = central!.GetNonNullHandle (nameof (central));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("centralManagerDidUpdateState:"), central__handle__);
			GC.KeepAlive (central);
		}
	}
}
namespace CoreBluetooth {
	/// <summary>Delegate objects for <see cref="T:CoreBluetooth.CBCentralManager" /> objects.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBCentralManagerDelegate_Protocol/index.html">Apple documentation for <c>CBCentralManagerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__CoreBluetooth_CBCentralManagerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class CBCentralManagerDelegate : NSObject, ICBCentralManagerDelegate {
		/// <summary>Creates a new <see cref="CBCentralManagerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CBCentralManagerDelegate () : base (NSObjectFlag.Empty)
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
		protected CBCentralManagerDelegate (NSObjectFlag t) : base (t)
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
		protected internal CBCentralManagerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="central">To be added.</param><param name="peripheral">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("centralManager:didConnectPeripheral:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConnectedPeripheral (CBCentralManager central, CBPeripheral peripheral)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("centralManager:connectionEventDidOccur:forPeripheral:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConnectionEventDidOccur (CBCentralManager central, CBConnectionEvent connectionEvent, CBPeripheral peripheral)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("centralManager:didDisconnectPeripheral:timestamp:isReconnecting:error:")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnectPeripheral (CBCentralManager central, CBPeripheral peripheral, double timestamp, bool isReconnecting, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("centralManager:didUpdateANCSAuthorizationForPeripheral:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateAncsAuthorization (CBCentralManager central, CBPeripheral peripheral)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="central">To be added.</param><param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("centralManager:didDisconnectPeripheral:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisconnectedPeripheral (CBCentralManager central, CBPeripheral peripheral, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="central">To be added.</param><param name="peripheral">To be added.</param><param name="advertisementData">To be added.</param><param name="RSSI">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("centralManager:didDiscoverPeripheral:advertisementData:RSSI:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DiscoveredPeripheral (CBCentralManager central, CBPeripheral peripheral, NSDictionary advertisementData, NSNumber RSSI)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="central">To be added.</param><param name="peripheral">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("centralManager:didFailToConnectPeripheral:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToConnectPeripheral (CBCentralManager central, CBPeripheral peripheral, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="central">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("centralManagerDidUpdateState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedState (CBCentralManager central)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="central">To be added.</param><param name="dict">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("centralManager:willRestoreState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillRestoreState (CBCentralManager central, NSDictionary dict)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CBCentralManagerDelegate */
}
