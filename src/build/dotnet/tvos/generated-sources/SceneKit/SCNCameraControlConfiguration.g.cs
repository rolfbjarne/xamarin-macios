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
namespace SceneKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>SCNCameraControlConfiguration</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "SCNCameraControlConfiguration", WrapperType = typeof (SCNCameraControlConfigurationWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AutoSwitchToFreeCamera", Selector = "autoSwitchToFreeCamera", PropertyType = typeof (bool), GetterSelector = "autoSwitchToFreeCamera", SetterSelector = "setAutoSwitchToFreeCamera:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AllowsTranslation", Selector = "allowsTranslation", PropertyType = typeof (bool), GetterSelector = "allowsTranslation", SetterSelector = "setAllowsTranslation:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "FlyModeVelocity", Selector = "flyModeVelocity", PropertyType = typeof (NFloat), GetterSelector = "flyModeVelocity", SetterSelector = "setFlyModeVelocity:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PanSensitivity", Selector = "panSensitivity", PropertyType = typeof (NFloat), GetterSelector = "panSensitivity", SetterSelector = "setPanSensitivity:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TruckSensitivity", Selector = "truckSensitivity", PropertyType = typeof (NFloat), GetterSelector = "truckSensitivity", SetterSelector = "setTruckSensitivity:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RotationSensitivity", Selector = "rotationSensitivity", PropertyType = typeof (NFloat), GetterSelector = "rotationSensitivity", SetterSelector = "setRotationSensitivity:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ISCNCameraControlConfiguration : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("AllowsTranslation")]
		[DynamicDependencyAttribute ("AutoSwitchToFreeCamera")]
		[DynamicDependencyAttribute ("FlyModeVelocity")]
		[DynamicDependencyAttribute ("PanSensitivity")]
		[DynamicDependencyAttribute ("RotationSensitivity")]
		[DynamicDependencyAttribute ("TruckSensitivity")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCNCameraControlConfigurationWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISCNCameraControlConfiguration ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AutoSwitchToFreeCamera {
			[Export ("autoSwitchToFreeCamera")]
			get {
				return _GetAutoSwitchToFreeCamera (this);
			}
			[Export ("setAutoSwitchToFreeCamera:")]
			set {
				_SetAutoSwitchToFreeCamera (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAutoSwitchToFreeCamera (ISCNCameraControlConfiguration This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("autoSwitchToFreeCamera"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAutoSwitchToFreeCamera (ISCNCameraControlConfiguration This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAutoSwitchToFreeCamera:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AllowsTranslation {
			[Export ("allowsTranslation")]
			get {
				return _GetAllowsTranslation (this);
			}
			[Export ("setAllowsTranslation:")]
			set {
				_SetAllowsTranslation (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAllowsTranslation (ISCNCameraControlConfiguration This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("allowsTranslation"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAllowsTranslation (ISCNCameraControlConfiguration This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAllowsTranslation:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nfloat FlyModeVelocity {
			[Export ("flyModeVelocity")]
			get {
				return _GetFlyModeVelocity (this);
			}
			[Export ("setFlyModeVelocity:")]
			set {
				_SetFlyModeVelocity (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetFlyModeVelocity (ISCNCameraControlConfiguration This)
		{
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("flyModeVelocity"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFlyModeVelocity (ISCNCameraControlConfiguration This, nfloat value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("setFlyModeVelocity:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nfloat PanSensitivity {
			[Export ("panSensitivity")]
			get {
				return _GetPanSensitivity (this);
			}
			[Export ("setPanSensitivity:")]
			set {
				_SetPanSensitivity (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetPanSensitivity (ISCNCameraControlConfiguration This)
		{
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("panSensitivity"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetPanSensitivity (ISCNCameraControlConfiguration This, nfloat value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("setPanSensitivity:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nfloat TruckSensitivity {
			[Export ("truckSensitivity")]
			get {
				return _GetTruckSensitivity (this);
			}
			[Export ("setTruckSensitivity:")]
			set {
				_SetTruckSensitivity (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetTruckSensitivity (ISCNCameraControlConfiguration This)
		{
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("truckSensitivity"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTruckSensitivity (ISCNCameraControlConfiguration This, nfloat value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("setTruckSensitivity:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nfloat RotationSensitivity {
			[Export ("rotationSensitivity")]
			get {
				return _GetRotationSensitivity (this);
			}
			[Export ("setRotationSensitivity:")]
			set {
				_SetRotationSensitivity (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetRotationSensitivity (ISCNCameraControlConfiguration This)
		{
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("rotationSensitivity"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRotationSensitivity (ISCNCameraControlConfiguration This, nfloat value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("setRotationSensitivity:"), value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SCNCameraControlConfigurationWrapper : BaseWrapper, ISCNCameraControlConfiguration {
		public SCNCameraControlConfigurationWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCNCameraControlConfigurationWrapper))]
		static SCNCameraControlConfigurationWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AutoSwitchToFreeCamera {
			[Export ("autoSwitchToFreeCamera")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("autoSwitchToFreeCamera"));
				return ret != 0;
			}
			[Export ("setAutoSwitchToFreeCamera:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutoSwitchToFreeCamera:"), value ? (byte) 1 : (byte) 0);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AllowsTranslation {
			[Export ("allowsTranslation")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsTranslation"));
				return ret != 0;
			}
			[Export ("setAllowsTranslation:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowsTranslation:"), value ? (byte) 1 : (byte) 0);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nfloat FlyModeVelocity {
			[Export ("flyModeVelocity")]
			get {
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("flyModeVelocity"));
				return ret;
			}
			[Export ("setFlyModeVelocity:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setFlyModeVelocity:"), value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nfloat PanSensitivity {
			[Export ("panSensitivity")]
			get {
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("panSensitivity"));
				return ret;
			}
			[Export ("setPanSensitivity:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setPanSensitivity:"), value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nfloat TruckSensitivity {
			[Export ("truckSensitivity")]
			get {
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("truckSensitivity"));
				return ret;
			}
			[Export ("setTruckSensitivity:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setTruckSensitivity:"), value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nfloat RotationSensitivity {
			[Export ("rotationSensitivity")]
			get {
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("rotationSensitivity"));
				return ret;
			}
			[Export ("setRotationSensitivity:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRotationSensitivity:"), value);
			}
		}
	}
}
