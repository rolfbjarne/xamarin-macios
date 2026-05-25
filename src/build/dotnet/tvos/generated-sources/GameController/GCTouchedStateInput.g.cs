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
namespace GameController {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>GCTouchedStateInput</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[Protocol (Name = "GCTouchedStateInput", WrapperType = typeof (GCTouchedStateInputWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TouchedDidChangeHandler", Selector = "touchedDidChangeHandler", PropertyType = typeof (global::System.Action<global::GameController.IGCPhysicalInputElement, global::GameController.IGCTouchedStateInput, bool>), GetterSelector = "touchedDidChangeHandler", SetterSelector = "setTouchedDidChangeHandler:", ArgumentSemantic = ArgumentSemantic.Copy, ParameterBlockProxy = new Type [] { typeof (ObjCRuntime.Trampolines.NIDActionArity3V10) }, ReturnTypeDelegateProxy = typeof (ObjCRuntime.Trampolines.SDActionArity3V10))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Touched", Selector = "touched", PropertyType = typeof (bool), GetterSelector = "isTouched", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LastTouchedStateTimestamp", Selector = "lastTouchedStateTimestamp", PropertyType = typeof (double), GetterSelector = "lastTouchedStateTimestamp", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LastTouchedStateLatency", Selector = "lastTouchedStateLatency", PropertyType = typeof (double), GetterSelector = "lastTouchedStateLatency", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Sources", Selector = "sources", PropertyType = typeof (global::Foundation.NSSet<global::GameController.IGCPhysicalInputSource>), GetterSelector = "sources", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface IGCTouchedStateInput : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("LastTouchedStateLatency")]
		[DynamicDependencyAttribute ("LastTouchedStateTimestamp")]
		[DynamicDependencyAttribute ("Sources")]
		[DynamicDependencyAttribute ("Touched")]
		[DynamicDependencyAttribute ("TouchedDidChangeHandler")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GCTouchedStateInputWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGCTouchedStateInput ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public unsafe virtual global::System.Action<IGCPhysicalInputElement, IGCTouchedStateInput, bool>? TouchedDidChangeHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity3V10))]
			[Export ("touchedDidChangeHandler", ArgumentSemantic.Copy)]
			get {
				return _GetTouchedDidChangeHandler (this);
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V10))]
			[Export ("setTouchedDidChangeHandler:", ArgumentSemantic.Copy)]
			set {
				_SetTouchedDidChangeHandler (this, value);
			}
		}
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity3V10))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static global::System.Action<IGCPhysicalInputElement, IGCTouchedStateInput, bool> _GetTouchedDidChangeHandler (IGCTouchedStateInput This)
		{
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("touchedDidChangeHandler"));
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDActionArity3V10.Create (ret)!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetTouchedDidChangeHandler (IGCTouchedStateInput This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V10))]global::System.Action<IGCPhysicalInputElement, IGCTouchedStateInput, bool>? value)
		{
			using var block_value = Trampolines.SDActionArity3V10.CreateNullableBlock (value);
			BlockLiteral *block_ptr_value = null;
			if (value is not null)
				block_ptr_value = &block_value;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setTouchedDidChangeHandler:"), (IntPtr) block_ptr_value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool Touched {
			[Export ("isTouched")]
			get {
				return _GetTouched (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetTouched (IGCTouchedStateInput This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isTouched"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual double LastTouchedStateTimestamp {
			[Export ("lastTouchedStateTimestamp")]
			get {
				return _GetLastTouchedStateTimestamp (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetLastTouchedStateTimestamp (IGCTouchedStateInput This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("lastTouchedStateTimestamp"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual double LastTouchedStateLatency {
			[Export ("lastTouchedStateLatency")]
			get {
				return _GetLastTouchedStateLatency (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetLastTouchedStateLatency (IGCTouchedStateInput This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("lastTouchedStateLatency"));
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
		internal static NSSet<IGCPhysicalInputSource> _GetSources (IGCTouchedStateInput This)
		{
			NSSet<IGCPhysicalInputSource> ret;
			ret =  Runtime.GetNSObject<NSSet<IGCPhysicalInputSource>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("sources")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GCTouchedStateInputWrapper : BaseWrapper, IGCTouchedStateInput {
		public GCTouchedStateInputWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GCTouchedStateInputWrapper))]
		static GCTouchedStateInputWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe global::System.Action<IGCPhysicalInputElement, IGCTouchedStateInput, bool>? TouchedDidChangeHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity3V10))]
			[Export ("touchedDidChangeHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("touchedDidChangeHandler"));
				return global::ObjCRuntime.Trampolines.NIDActionArity3V10.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V10))]
			[Export ("setTouchedDidChangeHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDActionArity3V10.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTouchedDidChangeHandler:"), (IntPtr) block_ptr_value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Touched {
			[Export ("isTouched")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isTouched"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public double LastTouchedStateTimestamp {
			[Export ("lastTouchedStateTimestamp")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("lastTouchedStateTimestamp"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public double LastTouchedStateLatency {
			[Export ("lastTouchedStateLatency")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("lastTouchedStateLatency"));
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
	}
}
