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
	/// <summary>This interface represents the Objective-C protocol <c>GCRelativeInput</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[Protocol (Name = "GCRelativeInput", WrapperType = typeof (GCRelativeInputWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DeltaDidChangeHandler", Selector = "deltaDidChangeHandler", PropertyType = typeof (global::System.Action<global::GameController.IGCPhysicalInputElement, global::GameController.IGCRelativeInput, float>), GetterSelector = "deltaDidChangeHandler", SetterSelector = "setDeltaDidChangeHandler:", ArgumentSemantic = ArgumentSemantic.Copy, ParameterBlockProxy = new Type [] { typeof (ObjCRuntime.Trampolines.NIDActionArity3V10) }, ReturnTypeDelegateProxy = typeof (ObjCRuntime.Trampolines.SDActionArity3V10))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Delta", Selector = "delta", PropertyType = typeof (float), GetterSelector = "delta", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Analog", Selector = "analog", PropertyType = typeof (bool), GetterSelector = "isAnalog", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LastDeltaTimestamp", Selector = "lastDeltaTimestamp", PropertyType = typeof (double), GetterSelector = "lastDeltaTimestamp", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LastDeltaLatency", Selector = "lastDeltaLatency", PropertyType = typeof (double), GetterSelector = "lastDeltaLatency", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Sources", Selector = "sources", PropertyType = typeof (global::Foundation.NSSet<global::GameController.IGCPhysicalInputSource>), GetterSelector = "sources", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface IGCRelativeInput : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("Analog")]
		[DynamicDependencyAttribute ("Delta")]
		[DynamicDependencyAttribute ("DeltaDidChangeHandler")]
		[DynamicDependencyAttribute ("LastDeltaLatency")]
		[DynamicDependencyAttribute ("LastDeltaTimestamp")]
		[DynamicDependencyAttribute ("Sources")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GCRelativeInputWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGCRelativeInput ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public unsafe virtual global::System.Action<IGCPhysicalInputElement, IGCRelativeInput, float>? DeltaDidChangeHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity3V10))]
			[Export ("deltaDidChangeHandler", ArgumentSemantic.Copy)]
			get {
				return _GetDeltaDidChangeHandler (this);
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V10))]
			[Export ("setDeltaDidChangeHandler:", ArgumentSemantic.Copy)]
			set {
				_SetDeltaDidChangeHandler (this, value);
			}
		}
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity3V10))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static global::System.Action<IGCPhysicalInputElement, IGCRelativeInput, float> _GetDeltaDidChangeHandler (IGCRelativeInput This)
		{
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("deltaDidChangeHandler"));
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDActionArity3V10.Create (ret)!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetDeltaDidChangeHandler (IGCRelativeInput This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V10))]global::System.Action<IGCPhysicalInputElement, IGCRelativeInput, float>? value)
		{
			using var block_value = Trampolines.SDActionArity3V10.CreateNullableBlock (value);
			BlockLiteral *block_ptr_value = null;
			if (value is not null)
				block_ptr_value = &block_value;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setDeltaDidChangeHandler:"), (IntPtr) block_ptr_value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float Delta {
			[Export ("delta")]
			get {
				return _GetDelta (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetDelta (IGCRelativeInput This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("delta"));
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
		internal static bool _GetAnalog (IGCRelativeInput This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAnalog"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual double LastDeltaTimestamp {
			[Export ("lastDeltaTimestamp")]
			get {
				return _GetLastDeltaTimestamp (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetLastDeltaTimestamp (IGCRelativeInput This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("lastDeltaTimestamp"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual double LastDeltaLatency {
			[Export ("lastDeltaLatency")]
			get {
				return _GetLastDeltaLatency (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetLastDeltaLatency (IGCRelativeInput This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("lastDeltaLatency"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[global::Foundation.RequiredMember]
		public virtual NSSet<IGCPhysicalInputSource> Sources {
			[Export ("sources", ArgumentSemantic.Copy)]
			get {
				return _GetSources (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSSet<IGCPhysicalInputSource> _GetSources (IGCRelativeInput This)
		{
			NSSet<IGCPhysicalInputSource> ret;
			ret =  Runtime.GetNSObject<NSSet<IGCPhysicalInputSource>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("sources")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GCRelativeInputWrapper : BaseWrapper, IGCRelativeInput {
		public GCRelativeInputWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GCRelativeInputWrapper))]
		static GCRelativeInputWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe global::System.Action<IGCPhysicalInputElement, IGCRelativeInput, float>? DeltaDidChangeHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity3V10))]
			[Export ("deltaDidChangeHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("deltaDidChangeHandler"));
				return global::ObjCRuntime.Trampolines.NIDActionArity3V10.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V10))]
			[Export ("setDeltaDidChangeHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDActionArity3V10.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDeltaDidChangeHandler:"), (IntPtr) block_ptr_value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Delta {
			[Export ("delta")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("delta"));
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
		public double LastDeltaTimestamp {
			[Export ("lastDeltaTimestamp")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("lastDeltaTimestamp"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public double LastDeltaLatency {
			[Export ("lastDeltaLatency")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("lastDeltaLatency"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public NSSet<IGCPhysicalInputSource> Sources {
			[Export ("sources", ArgumentSemantic.Copy)]
			get {
				NSSet<IGCPhysicalInputSource> ret;
				ret =  Runtime.GetNSObject<NSSet<IGCPhysicalInputSource>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sources")), false)!;
				return ret;
			}
		}
	}
}
