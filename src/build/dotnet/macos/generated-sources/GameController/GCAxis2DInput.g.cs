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
	/// <summary>This interface represents the Objective-C protocol <c>GCAxis2DInput</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos17.4")]
	[SupportedOSPlatform ("macos14.3")]
	[SupportedOSPlatform ("ios17.4")]
	[SupportedOSPlatform ("maccatalyst17.4")]
	[Protocol (Name = "GCAxis2DInput", WrapperType = typeof (GCAxis2DInputWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ValueDidChangeHandler", Selector = "valueDidChangeHandler", PropertyType = typeof (GameController.GCAxis2DInputValueDidChangeCallback), GetterSelector = "valueDidChangeHandler", SetterSelector = "setValueDidChangeHandler:", ArgumentSemantic = ArgumentSemantic.Copy, ParameterBlockProxy = new Type [] { typeof (ObjCRuntime.Trampolines.NIDGCAxis2DInputValueDidChangeCallback) }, ReturnTypeDelegateProxy = typeof (ObjCRuntime.Trampolines.SDGCAxis2DInputValueDidChangeCallback))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Value", Selector = "value", PropertyType = typeof (GameController.GCPoint2), GetterSelector = "value", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Analog", Selector = "analog", PropertyType = typeof (bool), GetterSelector = "isAnalog", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CanWrap", Selector = "canWrap", PropertyType = typeof (bool), GetterSelector = "canWrap", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LastValueTimestamp", Selector = "lastValueTimestamp", PropertyType = typeof (double), GetterSelector = "lastValueTimestamp", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LastValueLatency", Selector = "lastValueLatency", PropertyType = typeof (double), GetterSelector = "lastValueLatency", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Sources", Selector = "sources", PropertyType = typeof (global::Foundation.NSSet<global::GameController.IGCPhysicalInputSource>), GetterSelector = "sources", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface IGCAxis2DInput : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("Analog")]
		[DynamicDependencyAttribute ("CanWrap")]
		[DynamicDependencyAttribute ("LastValueLatency")]
		[DynamicDependencyAttribute ("LastValueTimestamp")]
		[DynamicDependencyAttribute ("Sources")]
		[DynamicDependencyAttribute ("Value")]
		[DynamicDependencyAttribute ("ValueDidChangeHandler")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GCAxis2DInputWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGCAxis2DInput ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public unsafe virtual GCAxis2DInputValueDidChangeCallback? ValueDidChangeHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDGCAxis2DInputValueDidChangeCallback))]
			[Export ("valueDidChangeHandler", ArgumentSemantic.Copy)]
			get {
				return _GetValueDidChangeHandler (this);
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGCAxis2DInputValueDidChangeCallback))]
			[Export ("setValueDidChangeHandler:", ArgumentSemantic.Copy)]
			set {
				_SetValueDidChangeHandler (this, value);
			}
		}
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDGCAxis2DInputValueDidChangeCallback))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static GCAxis2DInputValueDidChangeCallback _GetValueDidChangeHandler (IGCAxis2DInput This)
		{
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("valueDidChangeHandler"));
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDGCAxis2DInputValueDidChangeCallback.Create (ret)!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetValueDidChangeHandler (IGCAxis2DInput This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGCAxis2DInputValueDidChangeCallback))]GCAxis2DInputValueDidChangeCallback? value)
		{
			using var block_value = Trampolines.SDGCAxis2DInputValueDidChangeCallback.CreateNullableBlock (value);
			BlockLiteral *block_ptr_value = null;
			if (value is not null)
				block_ptr_value = &block_value;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setValueDidChangeHandler:"), (IntPtr) block_ptr_value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual GCPoint2 Value {
			[Export ("value")]
			get {
				return _GetValue (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static GCPoint2 _GetValue (IGCAxis2DInput This)
		{
			GCPoint2 ret;
			ret = global::ObjCRuntime.Messaging.GCPoint2_objc_msgSend (This.Handle, Selector.GetHandle ("value"));
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
		internal static bool _GetAnalog (IGCAxis2DInput This)
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
		internal static bool _GetCanWrap (IGCAxis2DInput This)
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
		internal static double _GetLastValueTimestamp (IGCAxis2DInput This)
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
		internal static double _GetLastValueLatency (IGCAxis2DInput This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("lastValueLatency"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSSet<IGCPhysicalInputSource> Sources {
			[Export ("sources", ArgumentSemantic.Copy)]
			get {
				return _GetSources (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSSet<IGCPhysicalInputSource> _GetSources (IGCAxis2DInput This)
		{
			NSSet<IGCPhysicalInputSource> ret;
			ret =  Runtime.GetNSObject<NSSet<IGCPhysicalInputSource>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("sources")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GCAxis2DInputWrapper : BaseWrapper, IGCAxis2DInput {
		public GCAxis2DInputWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GCAxis2DInputWrapper))]
		static GCAxis2DInputWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe GCAxis2DInputValueDidChangeCallback? ValueDidChangeHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDGCAxis2DInputValueDidChangeCallback))]
			[Export ("valueDidChangeHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("valueDidChangeHandler"));
				return global::ObjCRuntime.Trampolines.NIDGCAxis2DInputValueDidChangeCallback.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGCAxis2DInputValueDidChangeCallback))]
			[Export ("setValueDidChangeHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDGCAxis2DInputValueDidChangeCallback.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setValueDidChangeHandler:"), (IntPtr) block_ptr_value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GCPoint2 Value {
			[Export ("value")]
			get {
				GCPoint2 ret;
				ret = global::ObjCRuntime.Messaging.GCPoint2_objc_msgSend (this.Handle, Selector.GetHandle ("value"));
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
