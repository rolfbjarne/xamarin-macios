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
namespace HomeKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>HMHomeDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "HMHomeDelegate", WrapperType = typeof (HMHomeDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateNameForHome", Selector = "homeDidUpdateName:", ParameterType = new Type [] { typeof (HomeKit.HMHome) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateAccessControlForCurrentUser", Selector = "homeDidUpdateAccessControlForCurrentUser:", ParameterType = new Type [] { typeof (HomeKit.HMHome) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddAccessory", Selector = "home:didAddAccessory:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMAccessory) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveAccessory", Selector = "home:didRemoveAccessory:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMAccessory) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddUser", Selector = "home:didAddUser:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMUser) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveUser", Selector = "home:didRemoveUser:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMUser) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateRoom", Selector = "home:didUpdateRoom:forAccessory:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMRoom), typeof (HomeKit.HMAccessory) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddRoom", Selector = "home:didAddRoom:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMRoom) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveRoom", Selector = "home:didRemoveRoom:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMRoom) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateNameForRoom", Selector = "home:didUpdateNameForRoom:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMRoom) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddZone", Selector = "home:didAddZone:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMZone) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveZone", Selector = "home:didRemoveZone:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMZone) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateNameForZone", Selector = "home:didUpdateNameForZone:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMZone) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddRoomToZone", Selector = "home:didAddRoom:toZone:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMRoom), typeof (HomeKit.HMZone) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveRoomFromZone", Selector = "home:didRemoveRoom:fromZone:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMRoom), typeof (HomeKit.HMZone) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddServiceGroup", Selector = "home:didAddServiceGroup:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMServiceGroup) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveServiceGroup", Selector = "home:didRemoveServiceGroup:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMServiceGroup) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateNameForServiceGroup", Selector = "home:didUpdateNameForServiceGroup:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMServiceGroup) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddService", Selector = "home:didAddService:toServiceGroup:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMService), typeof (HomeKit.HMServiceGroup) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveService", Selector = "home:didRemoveService:fromServiceGroup:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMService), typeof (HomeKit.HMServiceGroup) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddActionSet", Selector = "home:didAddActionSet:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMActionSet) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveActionSet", Selector = "home:didRemoveActionSet:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMActionSet) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateNameForActionSet", Selector = "home:didUpdateNameForActionSet:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMActionSet) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateActionsForActionSet", Selector = "home:didUpdateActionsForActionSet:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMActionSet) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddTrigger", Selector = "home:didAddTrigger:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMTrigger) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveTrigger", Selector = "home:didRemoveTrigger:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMTrigger) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateNameForTrigger", Selector = "home:didUpdateNameForTrigger:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMTrigger) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateTrigger", Selector = "home:didUpdateTrigger:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMTrigger) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUnblockAccessory", Selector = "home:didUnblockAccessory:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMAccessory) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEncounterError", Selector = "home:didEncounterError:forAccessory:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (NSError), typeof (HomeKit.HMAccessory) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateHomeHubState", Selector = "home:didUpdateHomeHubState:", ParameterType = new Type [] { typeof (HomeKit.HMHome), typeof (HomeKit.HMHomeHubState) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateSupportedFeatures", Selector = "homeDidUpdateSupportedFeatures:", ParameterType = new Type [] { typeof (HomeKit.HMHome) }, ParameterByRef = new bool [] { false })]
	public partial interface IHMHomeDelegate : INativeObject, IDisposable
	{
		/// <param name="home">To be added.</param><summary>The name of the <paramref name="home" /> was updated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("homeDidUpdateName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateNameForHome (HMHome home)
		{
			_DidUpdateNameForHome (this, home);
		}
		/// <param name="home">To be added.</param><summary>The name of the <paramref name="home" /> was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateNameForHome (IHMHomeDelegate This, HMHome home)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("homeDidUpdateName:"), home__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
		}
		/// <param name="home">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("homeDidUpdateAccessControlForCurrentUser:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateAccessControlForCurrentUser (HMHome home)
		{
			_DidUpdateAccessControlForCurrentUser (this, home);
		}
		/// <param name="home">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateAccessControlForCurrentUser (IHMHomeDelegate This, HMHome home)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("homeDidUpdateAccessControlForCurrentUser:"), home__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
		}
		/// <param name="home">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didAddAccessory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddAccessory (HMHome home, HMAccessory accessory)
		{
			_DidAddAccessory (this, home, accessory);
		}
		/// <param name="home">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddAccessory (IHMHomeDelegate This, HMHome home, HMAccessory accessory)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didAddAccessory:"), home__handle__, accessory__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (accessory);
		}
		/// <param name="home">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didRemoveAccessory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveAccessory (HMHome home, HMAccessory accessory)
		{
			_DidRemoveAccessory (this, home, accessory);
		}
		/// <param name="home">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveAccessory (IHMHomeDelegate This, HMHome home, HMAccessory accessory)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didRemoveAccessory:"), home__handle__, accessory__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (accessory);
		}
		/// <param name="home">To be added.</param><param name="user">To be added.</param><summary>The <paramref name="user" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didAddUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddUser (HMHome home, HMUser user)
		{
			_DidAddUser (this, home, user);
		}
		/// <param name="home">To be added.</param><param name="user">To be added.</param><summary>The <paramref name="user" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddUser (IHMHomeDelegate This, HMHome home, HMUser user)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var user__handle__ = user!.GetNonNullHandle (nameof (user));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didAddUser:"), home__handle__, user__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (user);
		}
		/// <param name="home">To be added.</param><param name="user">To be added.</param><summary>The <paramref name="user" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didRemoveUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveUser (HMHome home, HMUser user)
		{
			_DidRemoveUser (this, home, user);
		}
		/// <param name="home">To be added.</param><param name="user">To be added.</param><summary>The <paramref name="user" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveUser (IHMHomeDelegate This, HMHome home, HMUser user)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var user__handle__ = user!.GetNonNullHandle (nameof (user));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didRemoveUser:"), home__handle__, user__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (user);
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> was assigned to <paramref name="room" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didUpdateRoom:forAccessory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateRoom (HMHome home, HMRoom room, HMAccessory accessory)
		{
			_DidUpdateRoom (this, home, room, accessory);
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> was assigned to <paramref name="room" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateRoom (IHMHomeDelegate This, HMHome home, HMRoom room, HMAccessory accessory)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didUpdateRoom:forAccessory:"), home__handle__, room__handle__, accessory__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (room);
			GC.KeepAlive (accessory);
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><summary>The <paramref name="room" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didAddRoom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddRoom (HMHome home, HMRoom room)
		{
			_DidAddRoom (this, home, room);
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><summary>The <paramref name="room" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddRoom (IHMHomeDelegate This, HMHome home, HMRoom room)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didAddRoom:"), home__handle__, room__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (room);
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><summary>The <paramref name="room" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didRemoveRoom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveRoom (HMHome home, HMRoom room)
		{
			_DidRemoveRoom (this, home, room);
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><summary>The <paramref name="room" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveRoom (IHMHomeDelegate This, HMHome home, HMRoom room)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didRemoveRoom:"), home__handle__, room__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (room);
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><summary>The name of the <paramref name="room" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didUpdateNameForRoom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateNameForRoom (HMHome home, HMRoom room)
		{
			_DidUpdateNameForRoom (this, home, room);
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><summary>The name of the <paramref name="room" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateNameForRoom (IHMHomeDelegate This, HMHome home, HMRoom room)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didUpdateNameForRoom:"), home__handle__, room__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (room);
		}
		/// <param name="home">To be added.</param><param name="zone">To be added.</param><summary>The <paramref name="zone" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didAddZone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddZone (HMHome home, HMZone zone)
		{
			_DidAddZone (this, home, zone);
		}
		/// <param name="home">To be added.</param><param name="zone">To be added.</param><summary>The <paramref name="zone" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddZone (IHMHomeDelegate This, HMHome home, HMZone zone)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var zone__handle__ = zone!.GetNonNullHandle (nameof (zone));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didAddZone:"), home__handle__, zone__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (zone);
		}
		/// <param name="home">To be added.</param><param name="zone">To be added.</param><summary>The <paramref name="zone" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didRemoveZone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveZone (HMHome home, HMZone zone)
		{
			_DidRemoveZone (this, home, zone);
		}
		/// <param name="home">To be added.</param><param name="zone">To be added.</param><summary>The <paramref name="zone" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveZone (IHMHomeDelegate This, HMHome home, HMZone zone)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var zone__handle__ = zone!.GetNonNullHandle (nameof (zone));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didRemoveZone:"), home__handle__, zone__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (zone);
		}
		/// <param name="home">To be added.</param><param name="zone">To be added.</param><summary>The name of the <paramref name="zone" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didUpdateNameForZone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateNameForZone (HMHome home, HMZone zone)
		{
			_DidUpdateNameForZone (this, home, zone);
		}
		/// <param name="home">To be added.</param><param name="zone">To be added.</param><summary>The name of the <paramref name="zone" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateNameForZone (IHMHomeDelegate This, HMHome home, HMZone zone)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var zone__handle__ = zone!.GetNonNullHandle (nameof (zone));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didUpdateNameForZone:"), home__handle__, zone__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (zone);
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><param name="zone">To be added.</param><summary>The <paramref name="room" /> was added to <paramref name="zone" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didAddRoom:toZone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddRoomToZone (HMHome home, HMRoom room, HMZone zone)
		{
			_DidAddRoomToZone (this, home, room, zone);
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><param name="zone">To be added.</param><summary>The <paramref name="room" /> was added to <paramref name="zone" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddRoomToZone (IHMHomeDelegate This, HMHome home, HMRoom room, HMZone zone)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var zone__handle__ = zone!.GetNonNullHandle (nameof (zone));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didAddRoom:toZone:"), home__handle__, room__handle__, zone__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (room);
			GC.KeepAlive (zone);
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><param name="zone">To be added.</param><summary>The <paramref name="room" /> was removed from <paramref name="zone" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didRemoveRoom:fromZone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveRoomFromZone (HMHome home, HMRoom room, HMZone zone)
		{
			_DidRemoveRoomFromZone (this, home, room, zone);
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><param name="zone">To be added.</param><summary>The <paramref name="room" /> was removed from <paramref name="zone" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveRoomFromZone (IHMHomeDelegate This, HMHome home, HMRoom room, HMZone zone)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var zone__handle__ = zone!.GetNonNullHandle (nameof (zone));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didRemoveRoom:fromZone:"), home__handle__, room__handle__, zone__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (room);
			GC.KeepAlive (zone);
		}
		/// <param name="home">To be added.</param><param name="group">To be added.</param><summary>The <paramref name="group" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didAddServiceGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddServiceGroup (HMHome home, HMServiceGroup group)
		{
			_DidAddServiceGroup (this, home, group);
		}
		/// <param name="home">To be added.</param><param name="group">To be added.</param><summary>The <paramref name="group" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddServiceGroup (IHMHomeDelegate This, HMHome home, HMServiceGroup group)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var group__handle__ = group!.GetNonNullHandle (nameof (group));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didAddServiceGroup:"), home__handle__, group__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (group);
		}
		/// <param name="home">To be added.</param><param name="group">To be added.</param><summary>The <paramref name="group" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didRemoveServiceGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveServiceGroup (HMHome home, HMServiceGroup group)
		{
			_DidRemoveServiceGroup (this, home, group);
		}
		/// <param name="home">To be added.</param><param name="group">To be added.</param><summary>The <paramref name="group" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveServiceGroup (IHMHomeDelegate This, HMHome home, HMServiceGroup group)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var group__handle__ = group!.GetNonNullHandle (nameof (group));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didRemoveServiceGroup:"), home__handle__, group__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (group);
		}
		/// <param name="home">To be added.</param><param name="group">To be added.</param><summary>The name of the <paramref name="group" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didUpdateNameForServiceGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateNameForServiceGroup (HMHome home, HMServiceGroup group)
		{
			_DidUpdateNameForServiceGroup (this, home, group);
		}
		/// <param name="home">To be added.</param><param name="group">To be added.</param><summary>The name of the <paramref name="group" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateNameForServiceGroup (IHMHomeDelegate This, HMHome home, HMServiceGroup group)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var group__handle__ = group!.GetNonNullHandle (nameof (group));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didUpdateNameForServiceGroup:"), home__handle__, group__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (group);
		}
		/// <param name="home">To be added.</param><param name="service">To be added.</param><param name="group">To be added.</param><summary>The <paramref name="service" /> was added to <paramref name="group" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didAddService:toServiceGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddService (HMHome home, HMService service, HMServiceGroup group)
		{
			_DidAddService (this, home, service, group);
		}
		/// <param name="home">To be added.</param><param name="service">To be added.</param><param name="group">To be added.</param><summary>The <paramref name="service" /> was added to <paramref name="group" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddService (IHMHomeDelegate This, HMHome home, HMService service, HMServiceGroup group)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			var group__handle__ = group!.GetNonNullHandle (nameof (group));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didAddService:toServiceGroup:"), home__handle__, service__handle__, group__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (service);
			GC.KeepAlive (group);
		}
		/// <param name="home">To be added.</param><param name="service">To be added.</param><param name="group">To be added.</param><summary>The <paramref name="service" /> was removed from <paramref name="group" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didRemoveService:fromServiceGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveService (HMHome home, HMService service, HMServiceGroup group)
		{
			_DidRemoveService (this, home, service, group);
		}
		/// <param name="home">To be added.</param><param name="service">To be added.</param><param name="group">To be added.</param><summary>The <paramref name="service" /> was removed from <paramref name="group" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveService (IHMHomeDelegate This, HMHome home, HMService service, HMServiceGroup group)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			var group__handle__ = group!.GetNonNullHandle (nameof (group));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didRemoveService:fromServiceGroup:"), home__handle__, service__handle__, group__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (service);
			GC.KeepAlive (group);
		}
		/// <param name="home">To be added.</param><param name="actionSet">To be added.</param><summary>The <paramref name="actionSet" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didAddActionSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddActionSet (HMHome home, HMActionSet actionSet)
		{
			_DidAddActionSet (this, home, actionSet);
		}
		/// <param name="home">To be added.</param><param name="actionSet">To be added.</param><summary>The <paramref name="actionSet" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddActionSet (IHMHomeDelegate This, HMHome home, HMActionSet actionSet)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var actionSet__handle__ = actionSet!.GetNonNullHandle (nameof (actionSet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didAddActionSet:"), home__handle__, actionSet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (actionSet);
		}
		/// <param name="home">To be added.</param><param name="actionSet">To be added.</param><summary>The <paramref name="actionSet" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didRemoveActionSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveActionSet (HMHome home, HMActionSet actionSet)
		{
			_DidRemoveActionSet (this, home, actionSet);
		}
		/// <param name="home">To be added.</param><param name="actionSet">To be added.</param><summary>The <paramref name="actionSet" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveActionSet (IHMHomeDelegate This, HMHome home, HMActionSet actionSet)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var actionSet__handle__ = actionSet!.GetNonNullHandle (nameof (actionSet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didRemoveActionSet:"), home__handle__, actionSet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (actionSet);
		}
		/// <param name="home">To be added.</param><param name="actionSet">To be added.</param><summary>The name of the <paramref name="actionSet" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didUpdateNameForActionSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateNameForActionSet (HMHome home, HMActionSet actionSet)
		{
			_DidUpdateNameForActionSet (this, home, actionSet);
		}
		/// <param name="home">To be added.</param><param name="actionSet">To be added.</param><summary>The name of the <paramref name="actionSet" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateNameForActionSet (IHMHomeDelegate This, HMHome home, HMActionSet actionSet)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var actionSet__handle__ = actionSet!.GetNonNullHandle (nameof (actionSet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didUpdateNameForActionSet:"), home__handle__, actionSet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (actionSet);
		}
		/// <param name="home">To be added.</param><param name="actionSet">To be added.</param><summary>The an action in <paramref name="actionSet" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didUpdateActionsForActionSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateActionsForActionSet (HMHome home, HMActionSet actionSet)
		{
			_DidUpdateActionsForActionSet (this, home, actionSet);
		}
		/// <param name="home">To be added.</param><param name="actionSet">To be added.</param><summary>The an action in <paramref name="actionSet" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateActionsForActionSet (IHMHomeDelegate This, HMHome home, HMActionSet actionSet)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var actionSet__handle__ = actionSet!.GetNonNullHandle (nameof (actionSet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didUpdateActionsForActionSet:"), home__handle__, actionSet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (actionSet);
		}
		/// <param name="home">To be added.</param><param name="trigger">To be added.</param><summary>The <paramref name="trigger" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didAddTrigger:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddTrigger (HMHome home, HMTrigger trigger)
		{
			_DidAddTrigger (this, home, trigger);
		}
		/// <param name="home">To be added.</param><param name="trigger">To be added.</param><summary>The <paramref name="trigger" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddTrigger (IHMHomeDelegate This, HMHome home, HMTrigger trigger)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var trigger__handle__ = trigger!.GetNonNullHandle (nameof (trigger));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didAddTrigger:"), home__handle__, trigger__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (trigger);
		}
		/// <param name="home">To be added.</param><param name="trigger">To be added.</param><summary>The <paramref name="trigger" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didRemoveTrigger:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveTrigger (HMHome home, HMTrigger trigger)
		{
			_DidRemoveTrigger (this, home, trigger);
		}
		/// <param name="home">To be added.</param><param name="trigger">To be added.</param><summary>The <paramref name="trigger" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveTrigger (IHMHomeDelegate This, HMHome home, HMTrigger trigger)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var trigger__handle__ = trigger!.GetNonNullHandle (nameof (trigger));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didRemoveTrigger:"), home__handle__, trigger__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (trigger);
		}
		/// <param name="home">To be added.</param><param name="trigger">To be added.</param><summary>The name of the <paramref name="trigger" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didUpdateNameForTrigger:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateNameForTrigger (HMHome home, HMTrigger trigger)
		{
			_DidUpdateNameForTrigger (this, home, trigger);
		}
		/// <param name="home">To be added.</param><param name="trigger">To be added.</param><summary>The name of the <paramref name="trigger" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateNameForTrigger (IHMHomeDelegate This, HMHome home, HMTrigger trigger)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var trigger__handle__ = trigger!.GetNonNullHandle (nameof (trigger));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didUpdateNameForTrigger:"), home__handle__, trigger__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (trigger);
		}
		/// <param name="home">To be added.</param><param name="trigger">To be added.</param><summary>The  <paramref name="trigger" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didUpdateTrigger:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateTrigger (HMHome home, HMTrigger trigger)
		{
			_DidUpdateTrigger (this, home, trigger);
		}
		/// <param name="home">To be added.</param><param name="trigger">To be added.</param><summary>The  <paramref name="trigger" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateTrigger (IHMHomeDelegate This, HMHome home, HMTrigger trigger)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var trigger__handle__ = trigger!.GetNonNullHandle (nameof (trigger));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didUpdateTrigger:"), home__handle__, trigger__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (trigger);
		}
		/// <param name="home">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="accessory" />, which belongs to <paramref name="home" />, was unblocked.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didUnblockAccessory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUnblockAccessory (HMHome home, HMAccessory accessory)
		{
			_DidUnblockAccessory (this, home, accessory);
		}
		/// <param name="home">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="accessory" />, which belongs to <paramref name="home" />, was unblocked.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUnblockAccessory (IHMHomeDelegate This, HMHome home, HMAccessory accessory)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didUnblockAccessory:"), home__handle__, accessory__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (accessory);
		}
		/// <param name="home">To be added.</param><param name="error">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="error" /> occurred in <paramref name="accessory" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didEncounterError:forAccessory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEncounterError (HMHome home, NSError error, HMAccessory accessory)
		{
			_DidEncounterError (this, home, error, accessory);
		}
		/// <param name="home">To be added.</param><param name="error">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="error" /> occurred in <paramref name="accessory" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEncounterError (IHMHomeDelegate This, HMHome home, NSError error, HMAccessory accessory)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didEncounterError:forAccessory:"), home__handle__, error__handle__, accessory__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (error);
			GC.KeepAlive (accessory);
		}
		/// <param name="home">To be added.</param><param name="homeHubState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("home:didUpdateHomeHubState:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateHomeHubState (HMHome home, HMHomeHubState homeHubState)
		{
			_DidUpdateHomeHubState (this, home, homeHubState);
		}
		/// <param name="home">To be added.</param><param name="homeHubState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateHomeHubState (IHMHomeDelegate This, HMHome home, HMHomeHubState homeHubState)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("home:didUpdateHomeHubState:"), home__handle__, (UIntPtr) (ulong) homeHubState);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
		}
		[global::Foundation.OptionalMember]
		[Export ("homeDidUpdateSupportedFeatures:")]
		[SupportedOSPlatform ("tvos13.2")]
		[SupportedOSPlatform ("ios13.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateSupportedFeatures (HMHome home)
		{
			_DidUpdateSupportedFeatures (this, home);
		}
		[SupportedOSPlatform ("tvos13.2")]
		[SupportedOSPlatform ("ios13.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateSupportedFeatures (IHMHomeDelegate This, HMHome home)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("homeDidUpdateSupportedFeatures:"), home__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
		}
		[DynamicDependencyAttribute ("DidAddAccessory(HomeKit.HMHome,HomeKit.HMAccessory)")]
		[DynamicDependencyAttribute ("DidAddActionSet(HomeKit.HMHome,HomeKit.HMActionSet)")]
		[DynamicDependencyAttribute ("DidAddRoom(HomeKit.HMHome,HomeKit.HMRoom)")]
		[DynamicDependencyAttribute ("DidAddRoomToZone(HomeKit.HMHome,HomeKit.HMRoom,HomeKit.HMZone)")]
		[DynamicDependencyAttribute ("DidAddService(HomeKit.HMHome,HomeKit.HMService,HomeKit.HMServiceGroup)")]
		[DynamicDependencyAttribute ("DidAddServiceGroup(HomeKit.HMHome,HomeKit.HMServiceGroup)")]
		[DynamicDependencyAttribute ("DidAddTrigger(HomeKit.HMHome,HomeKit.HMTrigger)")]
		[DynamicDependencyAttribute ("DidAddUser(HomeKit.HMHome,HomeKit.HMUser)")]
		[DynamicDependencyAttribute ("DidAddZone(HomeKit.HMHome,HomeKit.HMZone)")]
		[DynamicDependencyAttribute ("DidEncounterError(HomeKit.HMHome,Foundation.NSError,HomeKit.HMAccessory)")]
		[DynamicDependencyAttribute ("DidRemoveAccessory(HomeKit.HMHome,HomeKit.HMAccessory)")]
		[DynamicDependencyAttribute ("DidRemoveActionSet(HomeKit.HMHome,HomeKit.HMActionSet)")]
		[DynamicDependencyAttribute ("DidRemoveRoom(HomeKit.HMHome,HomeKit.HMRoom)")]
		[DynamicDependencyAttribute ("DidRemoveRoomFromZone(HomeKit.HMHome,HomeKit.HMRoom,HomeKit.HMZone)")]
		[DynamicDependencyAttribute ("DidRemoveService(HomeKit.HMHome,HomeKit.HMService,HomeKit.HMServiceGroup)")]
		[DynamicDependencyAttribute ("DidRemoveServiceGroup(HomeKit.HMHome,HomeKit.HMServiceGroup)")]
		[DynamicDependencyAttribute ("DidRemoveTrigger(HomeKit.HMHome,HomeKit.HMTrigger)")]
		[DynamicDependencyAttribute ("DidRemoveUser(HomeKit.HMHome,HomeKit.HMUser)")]
		[DynamicDependencyAttribute ("DidRemoveZone(HomeKit.HMHome,HomeKit.HMZone)")]
		[DynamicDependencyAttribute ("DidUnblockAccessory(HomeKit.HMHome,HomeKit.HMAccessory)")]
		[DynamicDependencyAttribute ("DidUpdateAccessControlForCurrentUser(HomeKit.HMHome)")]
		[DynamicDependencyAttribute ("DidUpdateActionsForActionSet(HomeKit.HMHome,HomeKit.HMActionSet)")]
		[DynamicDependencyAttribute ("DidUpdateHomeHubState(HomeKit.HMHome,HomeKit.HMHomeHubState)")]
		[DynamicDependencyAttribute ("DidUpdateNameForActionSet(HomeKit.HMHome,HomeKit.HMActionSet)")]
		[DynamicDependencyAttribute ("DidUpdateNameForHome(HomeKit.HMHome)")]
		[DynamicDependencyAttribute ("DidUpdateNameForRoom(HomeKit.HMHome,HomeKit.HMRoom)")]
		[DynamicDependencyAttribute ("DidUpdateNameForServiceGroup(HomeKit.HMHome,HomeKit.HMServiceGroup)")]
		[DynamicDependencyAttribute ("DidUpdateNameForTrigger(HomeKit.HMHome,HomeKit.HMTrigger)")]
		[DynamicDependencyAttribute ("DidUpdateNameForZone(HomeKit.HMHome,HomeKit.HMZone)")]
		[DynamicDependencyAttribute ("DidUpdateRoom(HomeKit.HMHome,HomeKit.HMRoom,HomeKit.HMAccessory)")]
		[DynamicDependencyAttribute ("DidUpdateSupportedFeatures(HomeKit.HMHome)")]
		[DynamicDependencyAttribute ("DidUpdateTrigger(HomeKit.HMHome,HomeKit.HMTrigger)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (HMHomeDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IHMHomeDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IHMHomeDelegate" /> interface to support all the methods from the HMHomeDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IHMHomeDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original HMHomeDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class HMHomeDelegate_Extensions {
		/// <param name="home">To be added.</param><summary>The name of the <paramref name="home" /> was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateNameForHome (this IHMHomeDelegate This, HMHome home)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("homeDidUpdateName:"), home__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
		}
		/// <param name="home">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateAccessControlForCurrentUser (this IHMHomeDelegate This, HMHome home)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("homeDidUpdateAccessControlForCurrentUser:"), home__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
		}
		/// <param name="home">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddAccessory (this IHMHomeDelegate This, HMHome home, HMAccessory accessory)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didAddAccessory:"), home__handle__, accessory__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (accessory);
		}
		/// <param name="home">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemoveAccessory (this IHMHomeDelegate This, HMHome home, HMAccessory accessory)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didRemoveAccessory:"), home__handle__, accessory__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (accessory);
		}
		/// <param name="home">To be added.</param><param name="user">To be added.</param><summary>The <paramref name="user" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddUser (this IHMHomeDelegate This, HMHome home, HMUser user)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var user__handle__ = user!.GetNonNullHandle (nameof (user));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didAddUser:"), home__handle__, user__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (user);
		}
		/// <param name="home">To be added.</param><param name="user">To be added.</param><summary>The <paramref name="user" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemoveUser (this IHMHomeDelegate This, HMHome home, HMUser user)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var user__handle__ = user!.GetNonNullHandle (nameof (user));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didRemoveUser:"), home__handle__, user__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (user);
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> was assigned to <paramref name="room" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateRoom (this IHMHomeDelegate This, HMHome home, HMRoom room, HMAccessory accessory)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didUpdateRoom:forAccessory:"), home__handle__, room__handle__, accessory__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (room);
			GC.KeepAlive (accessory);
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><summary>The <paramref name="room" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddRoom (this IHMHomeDelegate This, HMHome home, HMRoom room)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didAddRoom:"), home__handle__, room__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (room);
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><summary>The <paramref name="room" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemoveRoom (this IHMHomeDelegate This, HMHome home, HMRoom room)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didRemoveRoom:"), home__handle__, room__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (room);
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><summary>The name of the <paramref name="room" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateNameForRoom (this IHMHomeDelegate This, HMHome home, HMRoom room)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didUpdateNameForRoom:"), home__handle__, room__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (room);
		}
		/// <param name="home">To be added.</param><param name="zone">To be added.</param><summary>The <paramref name="zone" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddZone (this IHMHomeDelegate This, HMHome home, HMZone zone)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var zone__handle__ = zone!.GetNonNullHandle (nameof (zone));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didAddZone:"), home__handle__, zone__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (zone);
		}
		/// <param name="home">To be added.</param><param name="zone">To be added.</param><summary>The <paramref name="zone" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemoveZone (this IHMHomeDelegate This, HMHome home, HMZone zone)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var zone__handle__ = zone!.GetNonNullHandle (nameof (zone));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didRemoveZone:"), home__handle__, zone__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (zone);
		}
		/// <param name="home">To be added.</param><param name="zone">To be added.</param><summary>The name of the <paramref name="zone" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateNameForZone (this IHMHomeDelegate This, HMHome home, HMZone zone)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var zone__handle__ = zone!.GetNonNullHandle (nameof (zone));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didUpdateNameForZone:"), home__handle__, zone__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (zone);
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><param name="zone">To be added.</param><summary>The <paramref name="room" /> was added to <paramref name="zone" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddRoomToZone (this IHMHomeDelegate This, HMHome home, HMRoom room, HMZone zone)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var zone__handle__ = zone!.GetNonNullHandle (nameof (zone));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didAddRoom:toZone:"), home__handle__, room__handle__, zone__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (room);
			GC.KeepAlive (zone);
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><param name="zone">To be added.</param><summary>The <paramref name="room" /> was removed from <paramref name="zone" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemoveRoomFromZone (this IHMHomeDelegate This, HMHome home, HMRoom room, HMZone zone)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var zone__handle__ = zone!.GetNonNullHandle (nameof (zone));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didRemoveRoom:fromZone:"), home__handle__, room__handle__, zone__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (room);
			GC.KeepAlive (zone);
		}
		/// <param name="home">To be added.</param><param name="group">To be added.</param><summary>The <paramref name="group" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddServiceGroup (this IHMHomeDelegate This, HMHome home, HMServiceGroup group)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var group__handle__ = group!.GetNonNullHandle (nameof (group));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didAddServiceGroup:"), home__handle__, group__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (group);
		}
		/// <param name="home">To be added.</param><param name="group">To be added.</param><summary>The <paramref name="group" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemoveServiceGroup (this IHMHomeDelegate This, HMHome home, HMServiceGroup group)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var group__handle__ = group!.GetNonNullHandle (nameof (group));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didRemoveServiceGroup:"), home__handle__, group__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (group);
		}
		/// <param name="home">To be added.</param><param name="group">To be added.</param><summary>The name of the <paramref name="group" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateNameForServiceGroup (this IHMHomeDelegate This, HMHome home, HMServiceGroup group)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var group__handle__ = group!.GetNonNullHandle (nameof (group));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didUpdateNameForServiceGroup:"), home__handle__, group__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (group);
		}
		/// <param name="home">To be added.</param><param name="service">To be added.</param><param name="group">To be added.</param><summary>The <paramref name="service" /> was added to <paramref name="group" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddService (this IHMHomeDelegate This, HMHome home, HMService service, HMServiceGroup group)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			var group__handle__ = group!.GetNonNullHandle (nameof (group));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didAddService:toServiceGroup:"), home__handle__, service__handle__, group__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (service);
			GC.KeepAlive (group);
		}
		/// <param name="home">To be added.</param><param name="service">To be added.</param><param name="group">To be added.</param><summary>The <paramref name="service" /> was removed from <paramref name="group" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemoveService (this IHMHomeDelegate This, HMHome home, HMService service, HMServiceGroup group)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			var group__handle__ = group!.GetNonNullHandle (nameof (group));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didRemoveService:fromServiceGroup:"), home__handle__, service__handle__, group__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (service);
			GC.KeepAlive (group);
		}
		/// <param name="home">To be added.</param><param name="actionSet">To be added.</param><summary>The <paramref name="actionSet" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddActionSet (this IHMHomeDelegate This, HMHome home, HMActionSet actionSet)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var actionSet__handle__ = actionSet!.GetNonNullHandle (nameof (actionSet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didAddActionSet:"), home__handle__, actionSet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (actionSet);
		}
		/// <param name="home">To be added.</param><param name="actionSet">To be added.</param><summary>The <paramref name="actionSet" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemoveActionSet (this IHMHomeDelegate This, HMHome home, HMActionSet actionSet)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var actionSet__handle__ = actionSet!.GetNonNullHandle (nameof (actionSet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didRemoveActionSet:"), home__handle__, actionSet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (actionSet);
		}
		/// <param name="home">To be added.</param><param name="actionSet">To be added.</param><summary>The name of the <paramref name="actionSet" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateNameForActionSet (this IHMHomeDelegate This, HMHome home, HMActionSet actionSet)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var actionSet__handle__ = actionSet!.GetNonNullHandle (nameof (actionSet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didUpdateNameForActionSet:"), home__handle__, actionSet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (actionSet);
		}
		/// <param name="home">To be added.</param><param name="actionSet">To be added.</param><summary>The an action in <paramref name="actionSet" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateActionsForActionSet (this IHMHomeDelegate This, HMHome home, HMActionSet actionSet)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var actionSet__handle__ = actionSet!.GetNonNullHandle (nameof (actionSet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didUpdateActionsForActionSet:"), home__handle__, actionSet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (actionSet);
		}
		/// <param name="home">To be added.</param><param name="trigger">To be added.</param><summary>The <paramref name="trigger" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddTrigger (this IHMHomeDelegate This, HMHome home, HMTrigger trigger)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var trigger__handle__ = trigger!.GetNonNullHandle (nameof (trigger));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didAddTrigger:"), home__handle__, trigger__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (trigger);
		}
		/// <param name="home">To be added.</param><param name="trigger">To be added.</param><summary>The <paramref name="trigger" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemoveTrigger (this IHMHomeDelegate This, HMHome home, HMTrigger trigger)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var trigger__handle__ = trigger!.GetNonNullHandle (nameof (trigger));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didRemoveTrigger:"), home__handle__, trigger__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (trigger);
		}
		/// <param name="home">To be added.</param><param name="trigger">To be added.</param><summary>The name of the <paramref name="trigger" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateNameForTrigger (this IHMHomeDelegate This, HMHome home, HMTrigger trigger)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var trigger__handle__ = trigger!.GetNonNullHandle (nameof (trigger));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didUpdateNameForTrigger:"), home__handle__, trigger__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (trigger);
		}
		/// <param name="home">To be added.</param><param name="trigger">To be added.</param><summary>The  <paramref name="trigger" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateTrigger (this IHMHomeDelegate This, HMHome home, HMTrigger trigger)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var trigger__handle__ = trigger!.GetNonNullHandle (nameof (trigger));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didUpdateTrigger:"), home__handle__, trigger__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (trigger);
		}
		/// <param name="home">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="accessory" />, which belongs to <paramref name="home" />, was unblocked.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUnblockAccessory (this IHMHomeDelegate This, HMHome home, HMAccessory accessory)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didUnblockAccessory:"), home__handle__, accessory__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (accessory);
		}
		/// <param name="home">To be added.</param><param name="error">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="error" /> occurred in <paramref name="accessory" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEncounterError (this IHMHomeDelegate This, HMHome home, NSError error, HMAccessory accessory)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("home:didEncounterError:forAccessory:"), home__handle__, error__handle__, accessory__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
			GC.KeepAlive (error);
			GC.KeepAlive (accessory);
		}
		/// <param name="home">To be added.</param><param name="homeHubState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateHomeHubState (this IHMHomeDelegate This, HMHome home, HMHomeHubState homeHubState)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("home:didUpdateHomeHubState:"), home__handle__, (UIntPtr) (ulong) homeHubState);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
		}
		[SupportedOSPlatform ("tvos13.2")]
		[SupportedOSPlatform ("ios13.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateSupportedFeatures (this IHMHomeDelegate This, HMHome home)
		{
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("homeDidUpdateSupportedFeatures:"), home__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (home);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class HMHomeDelegateWrapper : BaseWrapper, IHMHomeDelegate {
		public HMHomeDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (HMHomeDelegateWrapper))]
		static HMHomeDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace HomeKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IHMHomeDelegate" /> (for the protocol <c>HMHomeDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IHMHomeDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__HomeKit_HMHomeDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class HMHomeDelegate : NSObject, IHMHomeDelegate {
		/// <summary>Creates a new <see cref="HMHomeDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public HMHomeDelegate () : base (NSObjectFlag.Empty)
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
		protected HMHomeDelegate (NSObjectFlag t) : base (t)
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
		protected internal HMHomeDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="home">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didAddAccessory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddAccessory (HMHome home, HMAccessory accessory)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="actionSet">To be added.</param><summary>The <paramref name="actionSet" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didAddActionSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddActionSet (HMHome home, HMActionSet actionSet)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><summary>The <paramref name="room" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didAddRoom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddRoom (HMHome home, HMRoom room)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><param name="zone">To be added.</param><summary>The <paramref name="room" /> was added to <paramref name="zone" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didAddRoom:toZone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddRoomToZone (HMHome home, HMRoom room, HMZone zone)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="service">To be added.</param><param name="group">To be added.</param><summary>The <paramref name="service" /> was added to <paramref name="group" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didAddService:toServiceGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddService (HMHome home, HMService service, HMServiceGroup group)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="group">To be added.</param><summary>The <paramref name="group" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didAddServiceGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddServiceGroup (HMHome home, HMServiceGroup group)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="trigger">To be added.</param><summary>The <paramref name="trigger" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didAddTrigger:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddTrigger (HMHome home, HMTrigger trigger)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="user">To be added.</param><summary>The <paramref name="user" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didAddUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddUser (HMHome home, HMUser user)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="zone">To be added.</param><summary>The <paramref name="zone" /> was added to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didAddZone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddZone (HMHome home, HMZone zone)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="error">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="error" /> occurred in <paramref name="accessory" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didEncounterError:forAccessory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEncounterError (HMHome home, NSError error, HMAccessory accessory)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didRemoveAccessory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveAccessory (HMHome home, HMAccessory accessory)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="actionSet">To be added.</param><summary>The <paramref name="actionSet" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didRemoveActionSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveActionSet (HMHome home, HMActionSet actionSet)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><summary>The <paramref name="room" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didRemoveRoom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveRoom (HMHome home, HMRoom room)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><param name="zone">To be added.</param><summary>The <paramref name="room" /> was removed from <paramref name="zone" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didRemoveRoom:fromZone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveRoomFromZone (HMHome home, HMRoom room, HMZone zone)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="service">To be added.</param><param name="group">To be added.</param><summary>The <paramref name="service" /> was removed from <paramref name="group" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didRemoveService:fromServiceGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveService (HMHome home, HMService service, HMServiceGroup group)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="group">To be added.</param><summary>The <paramref name="group" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didRemoveServiceGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveServiceGroup (HMHome home, HMServiceGroup group)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="trigger">To be added.</param><summary>The <paramref name="trigger" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didRemoveTrigger:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveTrigger (HMHome home, HMTrigger trigger)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="user">To be added.</param><summary>The <paramref name="user" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didRemoveUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveUser (HMHome home, HMUser user)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="zone">To be added.</param><summary>The <paramref name="zone" /> was removed from <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didRemoveZone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveZone (HMHome home, HMZone zone)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="accessory" />, which belongs to <paramref name="home" />, was unblocked.</summary><remarks>To be added.</remarks>
		[Export ("home:didUnblockAccessory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUnblockAccessory (HMHome home, HMAccessory accessory)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("homeDidUpdateAccessControlForCurrentUser:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateAccessControlForCurrentUser (HMHome home)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="actionSet">To be added.</param><summary>The an action in <paramref name="actionSet" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[Export ("home:didUpdateActionsForActionSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateActionsForActionSet (HMHome home, HMActionSet actionSet)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="homeHubState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("home:didUpdateHomeHubState:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateHomeHubState (HMHome home, HMHomeHubState homeHubState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="actionSet">To be added.</param><summary>The name of the <paramref name="actionSet" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[Export ("home:didUpdateNameForActionSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateNameForActionSet (HMHome home, HMActionSet actionSet)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><summary>The name of the <paramref name="home" /> was updated.</summary><remarks>To be added.</remarks>
		[Export ("homeDidUpdateName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateNameForHome (HMHome home)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><summary>The name of the <paramref name="room" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[Export ("home:didUpdateNameForRoom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateNameForRoom (HMHome home, HMRoom room)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="group">To be added.</param><summary>The name of the <paramref name="group" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[Export ("home:didUpdateNameForServiceGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateNameForServiceGroup (HMHome home, HMServiceGroup group)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="trigger">To be added.</param><summary>The name of the <paramref name="trigger" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[Export ("home:didUpdateNameForTrigger:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateNameForTrigger (HMHome home, HMTrigger trigger)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="zone">To be added.</param><summary>The name of the <paramref name="zone" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[Export ("home:didUpdateNameForZone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateNameForZone (HMHome home, HMZone zone)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="room">To be added.</param><param name="accessory">To be added.</param><summary>The <paramref name="accessory" /> was assigned to <paramref name="room" />, which belongs to <paramref name="home" />.</summary><remarks>To be added.</remarks>
		[Export ("home:didUpdateRoom:forAccessory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateRoom (HMHome home, HMRoom room, HMAccessory accessory)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("homeDidUpdateSupportedFeatures:")]
		[SupportedOSPlatform ("tvos13.2")]
		[SupportedOSPlatform ("ios13.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateSupportedFeatures (HMHome home)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="home">To be added.</param><param name="trigger">To be added.</param><summary>The  <paramref name="trigger" />, which belongs to <paramref name="home" />, was updated.</summary><remarks>To be added.</remarks>
		[Export ("home:didUpdateTrigger:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateTrigger (HMHome home, HMTrigger trigger)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class HMHomeDelegate */
}
