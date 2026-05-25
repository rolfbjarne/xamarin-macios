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
namespace GameController {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>GCLinearInput</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[Protocol (Name = "GCLinearInput", WrapperType = typeof (GCLinearInputWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ValueDidChangeHandler", Selector = "valueDidChangeHandler", PropertyType = typeof (global::System.Action<global::GameController.IGCPhysicalInputElement, global::GameController.IGCLinearInput, float>), GetterSelector = "valueDidChangeHandler", SetterSelector = "setValueDidChangeHandler:", ArgumentSemantic = ArgumentSemantic.Copy, ParameterBlockProxy = new Type [] { typeof (ObjCRuntime.Trampolines.NIDActionArity3V8) }, ReturnTypeDelegateProxy = typeof (ObjCRuntime.Trampolines.SDActionArity3V8))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Value", Selector = "value", PropertyType = typeof (float), GetterSelector = "value", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Analog", Selector = "analog", PropertyType = typeof (bool), GetterSelector = "isAnalog", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CanWrap", Selector = "canWrap", PropertyType = typeof (bool), GetterSelector = "canWrap", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LastValueTimestamp", Selector = "lastValueTimestamp", PropertyType = typeof (double), GetterSelector = "lastValueTimestamp", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LastValueLatency", Selector = "lastValueLatency", PropertyType = typeof (double), GetterSelector = "lastValueLatency", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Sources", Selector = "sources", PropertyType = typeof (global::Foundation.NSSet<global::GameController.IGCPhysicalInputSource>), GetterSelector = "sources", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PhysicalExtents", Selector = "physicalExtents", PropertyType = typeof (IGCPhysicalInputExtents), GetterSelector = "physicalExtents", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IGCLinearInput : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("Analog")]
		[DynamicDependencyAttribute ("CanWrap")]
		[DynamicDependencyAttribute ("LastValueLatency")]
		[DynamicDependencyAttribute ("LastValueTimestamp")]
		[DynamicDependencyAttribute ("PhysicalExtents")]
		[DynamicDependencyAttribute ("Sources")]
		[DynamicDependencyAttribute ("Value")]
		[DynamicDependencyAttribute ("ValueDidChangeHandler")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GCLinearInputWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGCLinearInput ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public unsafe virtual global::System.Action<IGCPhysicalInputElement, IGCLinearInput, float>? ValueDidChangeHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity3V8))]
			[Export ("valueDidChangeHandler", ArgumentSemantic.Copy)]
			get {
				return _GetValueDidChangeHandler (this);
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V8))]
			[Export ("setValueDidChangeHandler:", ArgumentSemantic.Copy)]
			set {
				_SetValueDidChangeHandler (this, value);
			}
		}
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity3V8))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static global::System.Action<IGCPhysicalInputElement, IGCLinearInput, float> _GetValueDidChangeHandler (IGCLinearInput This)
		{
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("valueDidChangeHandler"));
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDActionArity3V8.Create (ret)!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetValueDidChangeHandler (IGCLinearInput This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V8))]global::System.Action<IGCPhysicalInputElement, IGCLinearInput, float>? value)
		{
			using var block_value = Trampolines.SDActionArity3V8.CreateNullableBlock (value);
			BlockLiteral *block_ptr_value = null;
			if (value is not null)
				block_ptr_value = &block_value;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setValueDidChangeHandler:"), (IntPtr) block_ptr_value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float Value {
			[Export ("value")]
			get {
				return _GetValue (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetValue (IGCLinearInput This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("value"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool Analog {
			[Export ("isAnalog")]
			get {
				return _GetAnalog (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAnalog (IGCLinearInput This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAnalog"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool CanWrap {
			[Export ("canWrap")]
			get {
				return _GetCanWrap (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetCanWrap (IGCLinearInput This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("canWrap"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual double LastValueTimestamp {
			[Export ("lastValueTimestamp")]
			get {
				return _GetLastValueTimestamp (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetLastValueTimestamp (IGCLinearInput This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("lastValueTimestamp"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual double LastValueLatency {
			[Export ("lastValueLatency")]
			get {
				return _GetLastValueLatency (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetLastValueLatency (IGCLinearInput This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("lastValueLatency"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[global::Foundation.RequiredMember]
		public virtual NSSet<IGCPhysicalInputSource> Sources {
			[Export ("sources", ArgumentSemantic.Copy)]
			get {
				return _GetSources (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSSet<IGCPhysicalInputSource> _GetSources (IGCLinearInput This)
		{
			NSSet<IGCPhysicalInputSource> ret;
			ret =  Runtime.GetNSObject<NSSet<IGCPhysicalInputSource>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("sources")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.2")]
		[SupportedOSPlatform ("macos26.2")]
		[SupportedOSPlatform ("ios26.2")]
		[SupportedOSPlatform ("maccatalyst26.2")]
		[global::Foundation.RequiredMember]
		public virtual IGCPhysicalInputExtents? PhysicalExtents {
			[Export ("physicalExtents")]
			get {
				return _GetPhysicalExtents (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IGCPhysicalInputExtents _GetPhysicalExtents (IGCLinearInput This)
		{
			IGCPhysicalInputExtents ret;
			ret =  Runtime.GetINativeObject<IGCPhysicalInputExtents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("physicalExtents")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GCLinearInputWrapper : BaseWrapper, IGCLinearInput {
		public GCLinearInputWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GCLinearInputWrapper))]
		static GCLinearInputWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe global::System.Action<IGCPhysicalInputElement, IGCLinearInput, float>? ValueDidChangeHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity3V8))]
			[Export ("valueDidChangeHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("valueDidChangeHandler"));
				return global::ObjCRuntime.Trampolines.NIDActionArity3V8.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V8))]
			[Export ("setValueDidChangeHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDActionArity3V8.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setValueDidChangeHandler:"), (IntPtr) block_ptr_value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Value {
			[Export ("value")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("value"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Analog {
			[Export ("isAnalog")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAnalog"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool CanWrap {
			[Export ("canWrap")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canWrap"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public double LastValueTimestamp {
			[Export ("lastValueTimestamp")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("lastValueTimestamp"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public double LastValueLatency {
			[Export ("lastValueLatency")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("lastValueLatency"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public NSSet<IGCPhysicalInputSource> Sources {
			[Export ("sources", ArgumentSemantic.Copy)]
			get {
				NSSet<IGCPhysicalInputSource> ret;
				ret =  Runtime.GetNSObject<NSSet<IGCPhysicalInputSource>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sources")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.2")]
		[SupportedOSPlatform ("macos26.2")]
		[SupportedOSPlatform ("ios26.2")]
		[SupportedOSPlatform ("maccatalyst26.2")]
		public IGCPhysicalInputExtents? PhysicalExtents {
			[Export ("physicalExtents")]
			get {
				IGCPhysicalInputExtents ret;
				ret =  Runtime.GetINativeObject<IGCPhysicalInputExtents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("physicalExtents")), false)!;
				return ret;
			}
		}
	}
}
