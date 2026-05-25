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
namespace GameController {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>GCDevicePhysicalInputState</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[Protocol (Name = "GCDevicePhysicalInputState", WrapperType = typeof (GCDevicePhysicalInputStateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetObject", Selector = "objectForKeyedSubscript:", ReturnType = typeof (GameController.IGCPhysicalInputElement), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof (GameController.IGCDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LastEventTimestamp", Selector = "lastEventTimestamp", PropertyType = typeof (double), GetterSelector = "lastEventTimestamp", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LastEventLatency", Selector = "lastEventLatency", PropertyType = typeof (double), GetterSelector = "lastEventLatency", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Elements", Selector = "elements", PropertyType = typeof (global::GameController.GCPhysicalInputElementCollection<NSString, global::GameController.IGCPhysicalInputElement>), GetterSelector = "elements", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Buttons", Selector = "buttons", PropertyType = typeof (global::GameController.GCPhysicalInputElementCollection<NSString, global::GameController.IGCButtonElement>), GetterSelector = "buttons", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Axes", Selector = "axes", PropertyType = typeof (global::GameController.GCPhysicalInputElementCollection<NSString, global::GameController.IGCAxisElement>), GetterSelector = "axes", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Switches", Selector = "switches", PropertyType = typeof (global::GameController.GCPhysicalInputElementCollection<NSString, global::GameController.IGCSwitchElement>), GetterSelector = "switches", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Dpads", Selector = "dpads", PropertyType = typeof (global::GameController.GCPhysicalInputElementCollection<NSString, global::GameController.IGCDirectionPadElement>), GetterSelector = "dpads", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IGCDevicePhysicalInputState : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("objectForKeyedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IGCPhysicalInputElement? GetObject (string key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IGCPhysicalInputElement? _GetObject (IGCDevicePhysicalInputState This, string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			IGCPhysicalInputElement? ret;
			ret =  Runtime.GetINativeObject<IGCPhysicalInputElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("objectForKeyedSubscript:"), nskey), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[DynamicDependencyAttribute ("Axes")]
		[DynamicDependencyAttribute ("Buttons")]
		[DynamicDependencyAttribute ("Device")]
		[DynamicDependencyAttribute ("Dpads")]
		[DynamicDependencyAttribute ("Elements")]
		[DynamicDependencyAttribute ("GetObject(System.String)")]
		[DynamicDependencyAttribute ("LastEventLatency")]
		[DynamicDependencyAttribute ("LastEventTimestamp")]
		[DynamicDependencyAttribute ("Switches")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GCDevicePhysicalInputStateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGCDevicePhysicalInputState ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IGCDevice? Device {
			[Export ("device", ArgumentSemantic.Weak)]
			get {
				return _GetDevice (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IGCDevice _GetDevice (IGCDevicePhysicalInputState This)
		{
			IGCDevice ret;
			ret =  Runtime.GetINativeObject<IGCDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("device")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual double LastEventTimestamp {
			[Export ("lastEventTimestamp")]
			get {
				return _GetLastEventTimestamp (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetLastEventTimestamp (IGCDevicePhysicalInputState This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("lastEventTimestamp"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual double LastEventLatency {
			[Export ("lastEventLatency")]
			get {
				return _GetLastEventLatency (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetLastEventLatency (IGCDevicePhysicalInputState This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("lastEventLatency"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual GCPhysicalInputElementCollection<NSString, IGCPhysicalInputElement> Elements {
			[Export ("elements")]
			get {
				return _GetElements (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static GCPhysicalInputElementCollection<NSString, IGCPhysicalInputElement> _GetElements (IGCDevicePhysicalInputState This)
		{
			GCPhysicalInputElementCollection<NSString, IGCPhysicalInputElement> ret;
			ret =  Runtime.GetNSObject<GCPhysicalInputElementCollection<NSString, IGCPhysicalInputElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("elements")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual GCPhysicalInputElementCollection<NSString, IGCButtonElement> Buttons {
			[Export ("buttons")]
			get {
				return _GetButtons (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static GCPhysicalInputElementCollection<NSString, IGCButtonElement> _GetButtons (IGCDevicePhysicalInputState This)
		{
			GCPhysicalInputElementCollection<NSString, IGCButtonElement> ret;
			ret =  Runtime.GetNSObject<GCPhysicalInputElementCollection<NSString, IGCButtonElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("buttons")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual GCPhysicalInputElementCollection<NSString, IGCAxisElement> Axes {
			[Export ("axes")]
			get {
				return _GetAxes (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static GCPhysicalInputElementCollection<NSString, IGCAxisElement> _GetAxes (IGCDevicePhysicalInputState This)
		{
			GCPhysicalInputElementCollection<NSString, IGCAxisElement> ret;
			ret =  Runtime.GetNSObject<GCPhysicalInputElementCollection<NSString, IGCAxisElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("axes")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual GCPhysicalInputElementCollection<NSString, IGCSwitchElement> Switches {
			[Export ("switches")]
			get {
				return _GetSwitches (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static GCPhysicalInputElementCollection<NSString, IGCSwitchElement> _GetSwitches (IGCDevicePhysicalInputState This)
		{
			GCPhysicalInputElementCollection<NSString, IGCSwitchElement> ret;
			ret =  Runtime.GetNSObject<GCPhysicalInputElementCollection<NSString, IGCSwitchElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("switches")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual GCPhysicalInputElementCollection<NSString, IGCDirectionPadElement> Dpads {
			[Export ("dpads")]
			get {
				return _GetDpads (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static GCPhysicalInputElementCollection<NSString, IGCDirectionPadElement> _GetDpads (IGCDevicePhysicalInputState This)
		{
			GCPhysicalInputElementCollection<NSString, IGCDirectionPadElement> ret;
			ret =  Runtime.GetNSObject<GCPhysicalInputElementCollection<NSString, IGCDirectionPadElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("dpads")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GCDevicePhysicalInputStateWrapper : BaseWrapper, IGCDevicePhysicalInputState {
		public GCDevicePhysicalInputStateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GCDevicePhysicalInputStateWrapper))]
		static GCDevicePhysicalInputStateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("objectForKeyedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IGCPhysicalInputElement? GetObject (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			IGCPhysicalInputElement? ret;
			ret =  Runtime.GetINativeObject<IGCPhysicalInputElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("objectForKeyedSubscript:"), nskey), false)!;
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IGCDevice? Device {
			[Export ("device", ArgumentSemantic.Weak)]
			get {
				IGCDevice ret;
				ret =  Runtime.GetINativeObject<IGCDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public double LastEventTimestamp {
			[Export ("lastEventTimestamp")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("lastEventTimestamp"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public double LastEventLatency {
			[Export ("lastEventLatency")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("lastEventLatency"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GCPhysicalInputElementCollection<NSString, IGCPhysicalInputElement> Elements {
			[Export ("elements")]
			get {
				GCPhysicalInputElementCollection<NSString, IGCPhysicalInputElement> ret;
				ret =  Runtime.GetNSObject<GCPhysicalInputElementCollection<NSString, IGCPhysicalInputElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("elements")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GCPhysicalInputElementCollection<NSString, IGCButtonElement> Buttons {
			[Export ("buttons")]
			get {
				GCPhysicalInputElementCollection<NSString, IGCButtonElement> ret;
				ret =  Runtime.GetNSObject<GCPhysicalInputElementCollection<NSString, IGCButtonElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("buttons")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GCPhysicalInputElementCollection<NSString, IGCAxisElement> Axes {
			[Export ("axes")]
			get {
				GCPhysicalInputElementCollection<NSString, IGCAxisElement> ret;
				ret =  Runtime.GetNSObject<GCPhysicalInputElementCollection<NSString, IGCAxisElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("axes")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GCPhysicalInputElementCollection<NSString, IGCSwitchElement> Switches {
			[Export ("switches")]
			get {
				GCPhysicalInputElementCollection<NSString, IGCSwitchElement> ret;
				ret =  Runtime.GetNSObject<GCPhysicalInputElementCollection<NSString, IGCSwitchElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("switches")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GCPhysicalInputElementCollection<NSString, IGCDirectionPadElement> Dpads {
			[Export ("dpads")]
			get {
				GCPhysicalInputElementCollection<NSString, IGCDirectionPadElement> ret;
				ret =  Runtime.GetNSObject<GCPhysicalInputElementCollection<NSString, IGCDirectionPadElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("dpads")), false)!;
				return ret;
			}
		}
	}
}
