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
namespace NearbyInteraction {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NIDeviceCapability</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[Protocol (Name = "NIDeviceCapability", WrapperType = typeof (NIDeviceCapabilityWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsPreciseDistanceMeasurement", Selector = "supportsPreciseDistanceMeasurement", PropertyType = typeof (bool), GetterSelector = "supportsPreciseDistanceMeasurement", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsDirectionMeasurement", Selector = "supportsDirectionMeasurement", PropertyType = typeof (bool), GetterSelector = "supportsDirectionMeasurement", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsCameraAssistance", Selector = "supportsCameraAssistance", PropertyType = typeof (bool), GetterSelector = "supportsCameraAssistance", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsExtendedDistanceMeasurement", Selector = "supportsExtendedDistanceMeasurement", PropertyType = typeof (bool), GetterSelector = "supportsExtendedDistanceMeasurement", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsDlTdoaMeasurement", Selector = "supportsDLTDOAMeasurement", PropertyType = typeof (bool), GetterSelector = "supportsDLTDOAMeasurement", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INIDeviceCapability : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("SupportsCameraAssistance")]
		[DynamicDependencyAttribute ("SupportsDirectionMeasurement")]
		[DynamicDependencyAttribute ("SupportsDlTdoaMeasurement")]
		[DynamicDependencyAttribute ("SupportsExtendedDistanceMeasurement")]
		[DynamicDependencyAttribute ("SupportsPreciseDistanceMeasurement")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NIDeviceCapabilityWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INIDeviceCapability ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsPreciseDistanceMeasurement {
			[Export ("supportsPreciseDistanceMeasurement")]
			get {
				return _GetSupportsPreciseDistanceMeasurement (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsPreciseDistanceMeasurement (INIDeviceCapability This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsPreciseDistanceMeasurement"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsDirectionMeasurement {
			[Export ("supportsDirectionMeasurement")]
			get {
				return _GetSupportsDirectionMeasurement (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsDirectionMeasurement (INIDeviceCapability This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsDirectionMeasurement"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsCameraAssistance {
			[Export ("supportsCameraAssistance")]
			get {
				return _GetSupportsCameraAssistance (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsCameraAssistance (INIDeviceCapability This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsCameraAssistance"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsExtendedDistanceMeasurement {
			[Export ("supportsExtendedDistanceMeasurement")]
			get {
				return _GetSupportsExtendedDistanceMeasurement (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsExtendedDistanceMeasurement (INIDeviceCapability This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsExtendedDistanceMeasurement"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios26.0")]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsDlTdoaMeasurement {
			[Export ("supportsDLTDOAMeasurement")]
			get {
				return _GetSupportsDlTdoaMeasurement (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsDlTdoaMeasurement (INIDeviceCapability This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsDLTDOAMeasurement"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INIDeviceCapability" /> interface to support all the methods from the NIDeviceCapability protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INIDeviceCapability" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NIDeviceCapability protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NIDeviceCapability_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSupportsExtendedDistanceMeasurement (this INIDeviceCapability This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsExtendedDistanceMeasurement"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NIDeviceCapabilityWrapper : BaseWrapper, INIDeviceCapability {
		public NIDeviceCapabilityWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NIDeviceCapabilityWrapper))]
		static NIDeviceCapabilityWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool SupportsPreciseDistanceMeasurement {
			[Export ("supportsPreciseDistanceMeasurement")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsPreciseDistanceMeasurement"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool SupportsDirectionMeasurement {
			[Export ("supportsDirectionMeasurement")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsDirectionMeasurement"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool SupportsCameraAssistance {
			[Export ("supportsCameraAssistance")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsCameraAssistance"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public bool SupportsExtendedDistanceMeasurement {
			[Export ("supportsExtendedDistanceMeasurement")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsExtendedDistanceMeasurement"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios26.0")]
		public bool SupportsDlTdoaMeasurement {
			[Export ("supportsDLTDOAMeasurement")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsDLTDOAMeasurement"));
				return ret != 0;
			}
		}
	}
}
