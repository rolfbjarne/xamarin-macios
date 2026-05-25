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
namespace HomeKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>HMAccessoryDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "HMAccessoryDelegate", WrapperType = typeof (HMAccessoryDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateName", Selector = "accessoryDidUpdateName:", ParameterType = new Type [] { typeof (HomeKit.HMAccessory) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateNameForService", Selector = "accessory:didUpdateNameForService:", ParameterType = new Type [] { typeof (HomeKit.HMAccessory), typeof (HomeKit.HMService) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateAssociatedServiceType", Selector = "accessory:didUpdateAssociatedServiceTypeForService:", ParameterType = new Type [] { typeof (HomeKit.HMAccessory), typeof (HomeKit.HMService) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateServices", Selector = "accessoryDidUpdateServices:", ParameterType = new Type [] { typeof (HomeKit.HMAccessory) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddProfile", Selector = "accessory:didAddProfile:", ParameterType = new Type [] { typeof (HomeKit.HMAccessory), typeof (HomeKit.HMAccessoryProfile) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveProfile", Selector = "accessory:didRemoveProfile:", ParameterType = new Type [] { typeof (HomeKit.HMAccessory), typeof (HomeKit.HMAccessoryProfile) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateReachability", Selector = "accessoryDidUpdateReachability:", ParameterType = new Type [] { typeof (HomeKit.HMAccessory) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateValueForCharacteristic", Selector = "accessory:service:didUpdateValueForCharacteristic:", ParameterType = new Type [] { typeof (HomeKit.HMAccessory), typeof (HomeKit.HMService), typeof (HomeKit.HMCharacteristic) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateFirmwareVersion", Selector = "accessory:didUpdateFirmwareVersion:", ParameterType = new Type [] { typeof (HomeKit.HMAccessory), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IHMAccessoryDelegate : INativeObject, IDisposable
	{
		/// <param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> updated its name.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accessoryDidUpdateName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateName (HMAccessory accessory)
		{
			_DidUpdateName (this, accessory);
		}
		/// <param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> updated its name.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateName (IHMAccessoryDelegate This, HMAccessory accessory)
		{
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessoryDidUpdateName:"), accessory__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (accessory);
		}
		/// <param name="accessory">To be added.</param><param name="service">To be added.</param><summary>The <paramref name="accessory" /> updated the name of <paramref name="service" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accessory:didUpdateNameForService:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateNameForService (HMAccessory accessory, HMService service)
		{
			_DidUpdateNameForService (this, accessory, service);
		}
		/// <param name="accessory">To be added.</param><param name="service">To be added.</param><summary>The <paramref name="accessory" /> updated the name of <paramref name="service" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateNameForService (IHMAccessoryDelegate This, HMAccessory accessory, HMService service)
		{
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accessory:didUpdateNameForService:"), accessory__handle__, service__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (accessory);
			GC.KeepAlive (service);
		}
		/// <param name="accessory">To be added.</param><param name="service">To be added.</param><summary>The <paramref name="accessory" /> updated the service type for <paramref name="service" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accessory:didUpdateAssociatedServiceTypeForService:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateAssociatedServiceType (HMAccessory accessory, HMService service)
		{
			_DidUpdateAssociatedServiceType (this, accessory, service);
		}
		/// <param name="accessory">To be added.</param><param name="service">To be added.</param><summary>The <paramref name="accessory" /> updated the service type for <paramref name="service" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateAssociatedServiceType (IHMAccessoryDelegate This, HMAccessory accessory, HMService service)
		{
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accessory:didUpdateAssociatedServiceTypeForService:"), accessory__handle__, service__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (accessory);
			GC.KeepAlive (service);
		}
		/// <param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> updated its services.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accessoryDidUpdateServices:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateServices (HMAccessory accessory)
		{
			_DidUpdateServices (this, accessory);
		}
		/// <param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> updated its services.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateServices (IHMAccessoryDelegate This, HMAccessory accessory)
		{
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessoryDidUpdateServices:"), accessory__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (accessory);
		}
		/// <param name="accessory">The accessory to which the profile was added.</param><param name="profile">The profile that was added.</param><summary>Method that is called when <paramref name="profile" /> was added to <paramref name="accessory" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accessory:didAddProfile:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddProfile (HMAccessory accessory, HMAccessoryProfile profile)
		{
			_DidAddProfile (this, accessory, profile);
		}
		/// <param name="accessory">The accessory to which the profile was added.</param><param name="profile">The profile that was added.</param><summary>Method that is called when <paramref name="profile" /> was added to <paramref name="accessory" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddProfile (IHMAccessoryDelegate This, HMAccessory accessory, HMAccessoryProfile profile)
		{
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			var profile__handle__ = profile!.GetNonNullHandle (nameof (profile));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accessory:didAddProfile:"), accessory__handle__, profile__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (accessory);
			GC.KeepAlive (profile);
		}
		/// <param name="accessory">The accessory from which the profile was removed.</param><param name="profile">The profile that was removed.</param><summary>Method that is called when <paramref name="profile" /> was removed from <paramref name="accessory" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accessory:didRemoveProfile:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveProfile (HMAccessory accessory, HMAccessoryProfile profile)
		{
			_DidRemoveProfile (this, accessory, profile);
		}
		/// <param name="accessory">The accessory from which the profile was removed.</param><param name="profile">The profile that was removed.</param><summary>Method that is called when <paramref name="profile" /> was removed from <paramref name="accessory" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveProfile (IHMAccessoryDelegate This, HMAccessory accessory, HMAccessoryProfile profile)
		{
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			var profile__handle__ = profile!.GetNonNullHandle (nameof (profile));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accessory:didRemoveProfile:"), accessory__handle__, profile__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (accessory);
			GC.KeepAlive (profile);
		}
		/// <param name="accessory">To be added.</param><summary>Delegate method called by the system when the accessory's network visibility has changed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accessoryDidUpdateReachability:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateReachability (HMAccessory accessory)
		{
			_DidUpdateReachability (this, accessory);
		}
		/// <param name="accessory">To be added.</param><summary>Delegate method called by the system when the accessory's network visibility has changed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateReachability (IHMAccessoryDelegate This, HMAccessory accessory)
		{
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessoryDidUpdateReachability:"), accessory__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (accessory);
		}
		/// <param name="accessory">To be added.</param><param name="service">To be added.</param><param name="characteristic">To be added.</param><summary>The <paramref name="accessory" /> updated the value of <paramref name="characteristic" /> on <paramref name="service" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accessory:service:didUpdateValueForCharacteristic:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateValueForCharacteristic (HMAccessory accessory, HMService service, HMCharacteristic characteristic)
		{
			_DidUpdateValueForCharacteristic (this, accessory, service, characteristic);
		}
		/// <param name="accessory">To be added.</param><param name="service">To be added.</param><param name="characteristic">To be added.</param><summary>The <paramref name="accessory" /> updated the value of <paramref name="characteristic" /> on <paramref name="service" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateValueForCharacteristic (IHMAccessoryDelegate This, HMAccessory accessory, HMService service, HMCharacteristic characteristic)
		{
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			var characteristic__handle__ = characteristic!.GetNonNullHandle (nameof (characteristic));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accessory:service:didUpdateValueForCharacteristic:"), accessory__handle__, service__handle__, characteristic__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (accessory);
			GC.KeepAlive (service);
			GC.KeepAlive (characteristic);
		}
		/// <param name="accessory">The accessory whose firmware version was updated.</param><param name="firmwareVersion">The new firmware version.</param><summary>Method that is called when the firmware version of <paramref name="accessory" /> is updated to <paramref name="firmwareVersion" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accessory:didUpdateFirmwareVersion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateFirmwareVersion (HMAccessory accessory, string firmwareVersion)
		{
			_DidUpdateFirmwareVersion (this, accessory, firmwareVersion);
		}
		/// <param name="accessory">The accessory whose firmware version was updated.</param><param name="firmwareVersion">The new firmware version.</param><summary>Method that is called when the firmware version of <paramref name="accessory" /> is updated to <paramref name="firmwareVersion" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateFirmwareVersion (IHMAccessoryDelegate This, HMAccessory accessory, string firmwareVersion)
		{
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			if (firmwareVersion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (firmwareVersion));
			var nsfirmwareVersion = CFString.CreateNative (firmwareVersion);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accessory:didUpdateFirmwareVersion:"), accessory__handle__, nsfirmwareVersion);
			GC.KeepAlive (This);
			GC.KeepAlive (accessory);
			CFString.ReleaseNative (nsfirmwareVersion);
		}
		[DynamicDependencyAttribute ("DidAddProfile(HomeKit.HMAccessory,HomeKit.HMAccessoryProfile)")]
		[DynamicDependencyAttribute ("DidRemoveProfile(HomeKit.HMAccessory,HomeKit.HMAccessoryProfile)")]
		[DynamicDependencyAttribute ("DidUpdateAssociatedServiceType(HomeKit.HMAccessory,HomeKit.HMService)")]
		[DynamicDependencyAttribute ("DidUpdateFirmwareVersion(HomeKit.HMAccessory,System.String)")]
		[DynamicDependencyAttribute ("DidUpdateName(HomeKit.HMAccessory)")]
		[DynamicDependencyAttribute ("DidUpdateNameForService(HomeKit.HMAccessory,HomeKit.HMService)")]
		[DynamicDependencyAttribute ("DidUpdateReachability(HomeKit.HMAccessory)")]
		[DynamicDependencyAttribute ("DidUpdateServices(HomeKit.HMAccessory)")]
		[DynamicDependencyAttribute ("DidUpdateValueForCharacteristic(HomeKit.HMAccessory,HomeKit.HMService,HomeKit.HMCharacteristic)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (HMAccessoryDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IHMAccessoryDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IHMAccessoryDelegate" /> interface to support all the methods from the HMAccessoryDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IHMAccessoryDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original HMAccessoryDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class HMAccessoryDelegate_Extensions {
		/// <param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> updated its name.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateName (this IHMAccessoryDelegate This, HMAccessory accessory)
		{
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessoryDidUpdateName:"), accessory__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (accessory);
		}
		/// <param name="accessory">To be added.</param><param name="service">To be added.</param><summary>The <paramref name="accessory" /> updated the name of <paramref name="service" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateNameForService (this IHMAccessoryDelegate This, HMAccessory accessory, HMService service)
		{
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accessory:didUpdateNameForService:"), accessory__handle__, service__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (accessory);
			GC.KeepAlive (service);
		}
		/// <param name="accessory">To be added.</param><param name="service">To be added.</param><summary>The <paramref name="accessory" /> updated the service type for <paramref name="service" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateAssociatedServiceType (this IHMAccessoryDelegate This, HMAccessory accessory, HMService service)
		{
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accessory:didUpdateAssociatedServiceTypeForService:"), accessory__handle__, service__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (accessory);
			GC.KeepAlive (service);
		}
		/// <param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> updated its services.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateServices (this IHMAccessoryDelegate This, HMAccessory accessory)
		{
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessoryDidUpdateServices:"), accessory__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (accessory);
		}
		/// <param name="accessory">The accessory to which the profile was added.</param><param name="profile">The profile that was added.</param><summary>Method that is called when <paramref name="profile" /> was added to <paramref name="accessory" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddProfile (this IHMAccessoryDelegate This, HMAccessory accessory, HMAccessoryProfile profile)
		{
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			var profile__handle__ = profile!.GetNonNullHandle (nameof (profile));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accessory:didAddProfile:"), accessory__handle__, profile__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (accessory);
			GC.KeepAlive (profile);
		}
		/// <param name="accessory">The accessory from which the profile was removed.</param><param name="profile">The profile that was removed.</param><summary>Method that is called when <paramref name="profile" /> was removed from <paramref name="accessory" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemoveProfile (this IHMAccessoryDelegate This, HMAccessory accessory, HMAccessoryProfile profile)
		{
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			var profile__handle__ = profile!.GetNonNullHandle (nameof (profile));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accessory:didRemoveProfile:"), accessory__handle__, profile__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (accessory);
			GC.KeepAlive (profile);
		}
		/// <param name="accessory">To be added.</param><summary>Delegate method called by the system when the accessory's network visibility has changed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateReachability (this IHMAccessoryDelegate This, HMAccessory accessory)
		{
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessoryDidUpdateReachability:"), accessory__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (accessory);
		}
		/// <param name="accessory">To be added.</param><param name="service">To be added.</param><param name="characteristic">To be added.</param><summary>The <paramref name="accessory" /> updated the value of <paramref name="characteristic" /> on <paramref name="service" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateValueForCharacteristic (this IHMAccessoryDelegate This, HMAccessory accessory, HMService service, HMCharacteristic characteristic)
		{
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			var characteristic__handle__ = characteristic!.GetNonNullHandle (nameof (characteristic));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accessory:service:didUpdateValueForCharacteristic:"), accessory__handle__, service__handle__, characteristic__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (accessory);
			GC.KeepAlive (service);
			GC.KeepAlive (characteristic);
		}
		/// <param name="accessory">The accessory whose firmware version was updated.</param><param name="firmwareVersion">The new firmware version.</param><summary>Method that is called when the firmware version of <paramref name="accessory" /> is updated to <paramref name="firmwareVersion" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateFirmwareVersion (this IHMAccessoryDelegate This, HMAccessory accessory, string firmwareVersion)
		{
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			if (firmwareVersion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (firmwareVersion));
			var nsfirmwareVersion = CFString.CreateNative (firmwareVersion);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accessory:didUpdateFirmwareVersion:"), accessory__handle__, nsfirmwareVersion);
			GC.KeepAlive (This);
			GC.KeepAlive (accessory);
			CFString.ReleaseNative (nsfirmwareVersion);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class HMAccessoryDelegateWrapper : BaseWrapper, IHMAccessoryDelegate {
		public HMAccessoryDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (HMAccessoryDelegateWrapper))]
		static HMAccessoryDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace HomeKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IHMAccessoryDelegate" /> (for the protocol <c>HMAccessoryDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IHMAccessoryDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__HomeKit_HMAccessoryDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class HMAccessoryDelegate : NSObject, IHMAccessoryDelegate {
		/// <summary>Creates a new <see cref="HMAccessoryDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public HMAccessoryDelegate () : base (NSObjectFlag.Empty)
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
		protected HMAccessoryDelegate (NSObjectFlag t) : base (t)
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
		protected internal HMAccessoryDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="accessory">The accessory to which the profile was added.</param><param name="profile">The profile that was added.</param><summary>Method that is called when <paramref name="profile" /> was added to <paramref name="accessory" />.</summary><remarks>To be added.</remarks>
		[Export ("accessory:didAddProfile:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddProfile (HMAccessory accessory, HMAccessoryProfile profile)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="accessory">The accessory from which the profile was removed.</param><param name="profile">The profile that was removed.</param><summary>Method that is called when <paramref name="profile" /> was removed from <paramref name="accessory" />.</summary><remarks>To be added.</remarks>
		[Export ("accessory:didRemoveProfile:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveProfile (HMAccessory accessory, HMAccessoryProfile profile)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="accessory">To be added.</param><param name="service">To be added.</param><summary>The <paramref name="accessory" /> updated the service type for <paramref name="service" />.</summary><remarks>To be added.</remarks>
		[Export ("accessory:didUpdateAssociatedServiceTypeForService:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateAssociatedServiceType (HMAccessory accessory, HMService service)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="accessory">The accessory whose firmware version was updated.</param><param name="firmwareVersion">The new firmware version.</param><summary>Method that is called when the firmware version of <paramref name="accessory" /> is updated to <paramref name="firmwareVersion" />.</summary><remarks>To be added.</remarks>
		[Export ("accessory:didUpdateFirmwareVersion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateFirmwareVersion (HMAccessory accessory, string firmwareVersion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> updated its name.</summary><remarks>To be added.</remarks>
		[Export ("accessoryDidUpdateName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateName (HMAccessory accessory)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="accessory">To be added.</param><param name="service">To be added.</param><summary>The <paramref name="accessory" /> updated the name of <paramref name="service" />.</summary><remarks>To be added.</remarks>
		[Export ("accessory:didUpdateNameForService:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateNameForService (HMAccessory accessory, HMService service)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="accessory">To be added.</param><summary>Delegate method called by the system when the accessory's network visibility has changed.</summary><remarks>To be added.</remarks>
		[Export ("accessoryDidUpdateReachability:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateReachability (HMAccessory accessory)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> updated its services.</summary><remarks>To be added.</remarks>
		[Export ("accessoryDidUpdateServices:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateServices (HMAccessory accessory)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="accessory">To be added.</param><param name="service">To be added.</param><param name="characteristic">To be added.</param><summary>The <paramref name="accessory" /> updated the value of <paramref name="characteristic" /> on <paramref name="service" />.</summary><remarks>To be added.</remarks>
		[Export ("accessory:service:didUpdateValueForCharacteristic:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateValueForCharacteristic (HMAccessory accessory, HMService service, HMCharacteristic characteristic)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class HMAccessoryDelegate */
}
