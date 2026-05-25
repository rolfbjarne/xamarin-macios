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
	/// <summary>This interface represents the Objective-C protocol <c>GCSwitchPositionInput</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[Protocol (Name = "GCSwitchPositionInput", WrapperType = typeof (GCSwitchPositionInputWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PositionDidChangeHandler", Selector = "positionDidChangeHandler", PropertyType = typeof (global::System.Action<global::GameController.IGCPhysicalInputElement, global::GameController.IGCSwitchPositionInput, nint>), GetterSelector = "positionDidChangeHandler", SetterSelector = "setPositionDidChangeHandler:", ArgumentSemantic = ArgumentSemantic.Copy, ParameterBlockProxy = new Type [] { typeof (ObjCRuntime.Trampolines.NIDActionArity3V9) }, ReturnTypeDelegateProxy = typeof (ObjCRuntime.Trampolines.SDActionArity3V9))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Position", Selector = "position", PropertyType = typeof (IntPtr), GetterSelector = "position", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PositionRange", Selector = "positionRange", PropertyType = typeof (NSRange), GetterSelector = "positionRange", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Sequential", Selector = "sequential", PropertyType = typeof (bool), GetterSelector = "isSequential", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CanWrap", Selector = "canWrap", PropertyType = typeof (bool), GetterSelector = "canWrap", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LastPositionTimestamp", Selector = "lastPositionTimestamp", PropertyType = typeof (double), GetterSelector = "lastPositionTimestamp", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LastPositionLatency", Selector = "lastPositionLatency", PropertyType = typeof (double), GetterSelector = "lastPositionLatency", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Sources", Selector = "sources", PropertyType = typeof (global::Foundation.NSSet<global::GameController.IGCPhysicalInputSource>), GetterSelector = "sources", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface IGCSwitchPositionInput : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("CanWrap")]
		[DynamicDependencyAttribute ("LastPositionLatency")]
		[DynamicDependencyAttribute ("LastPositionTimestamp")]
		[DynamicDependencyAttribute ("Position")]
		[DynamicDependencyAttribute ("PositionDidChangeHandler")]
		[DynamicDependencyAttribute ("PositionRange")]
		[DynamicDependencyAttribute ("Sequential")]
		[DynamicDependencyAttribute ("Sources")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GCSwitchPositionInputWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGCSwitchPositionInput ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public unsafe virtual global::System.Action<IGCPhysicalInputElement, IGCSwitchPositionInput, nint>? PositionDidChangeHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity3V9))]
			[Export ("positionDidChangeHandler", ArgumentSemantic.Copy)]
			get {
				return _GetPositionDidChangeHandler (this);
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V9))]
			[Export ("setPositionDidChangeHandler:", ArgumentSemantic.Copy)]
			set {
				_SetPositionDidChangeHandler (this, value);
			}
		}
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity3V9))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static global::System.Action<IGCPhysicalInputElement, IGCSwitchPositionInput, nint> _GetPositionDidChangeHandler (IGCSwitchPositionInput This)
		{
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("positionDidChangeHandler"));
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDActionArity3V9.Create (ret)!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetPositionDidChangeHandler (IGCSwitchPositionInput This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V9))]global::System.Action<IGCPhysicalInputElement, IGCSwitchPositionInput, nint>? value)
		{
			using var block_value = Trampolines.SDActionArity3V9.CreateNullableBlock (value);
			BlockLiteral *block_ptr_value = null;
			if (value is not null)
				block_ptr_value = &block_value;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setPositionDidChangeHandler:"), (IntPtr) block_ptr_value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint Position {
			[Export ("position")]
			get {
				return _GetPosition (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetPosition (IGCSwitchPositionInput This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("position"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSRange PositionRange {
			[Export ("positionRange")]
			get {
				return _GetPositionRange (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSRange _GetPositionRange (IGCSwitchPositionInput This)
		{
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (This.Handle, Selector.GetHandle ("positionRange"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool Sequential {
			[Export ("isSequential")]
			get {
				return _GetSequential (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSequential (IGCSwitchPositionInput This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSequential"));
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
		internal static bool _GetCanWrap (IGCSwitchPositionInput This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("canWrap"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual double LastPositionTimestamp {
			[Export ("lastPositionTimestamp")]
			get {
				return _GetLastPositionTimestamp (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetLastPositionTimestamp (IGCSwitchPositionInput This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("lastPositionTimestamp"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual double LastPositionLatency {
			[Export ("lastPositionLatency")]
			get {
				return _GetLastPositionLatency (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetLastPositionLatency (IGCSwitchPositionInput This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("lastPositionLatency"));
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
		internal static NSSet<IGCPhysicalInputSource> _GetSources (IGCSwitchPositionInput This)
		{
			NSSet<IGCPhysicalInputSource> ret;
			ret =  Runtime.GetNSObject<NSSet<IGCPhysicalInputSource>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("sources")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GCSwitchPositionInputWrapper : BaseWrapper, IGCSwitchPositionInput {
		public GCSwitchPositionInputWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GCSwitchPositionInputWrapper))]
		static GCSwitchPositionInputWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe global::System.Action<IGCPhysicalInputElement, IGCSwitchPositionInput, nint>? PositionDidChangeHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity3V9))]
			[Export ("positionDidChangeHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("positionDidChangeHandler"));
				return global::ObjCRuntime.Trampolines.NIDActionArity3V9.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V9))]
			[Export ("setPositionDidChangeHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDActionArity3V9.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPositionDidChangeHandler:"), (IntPtr) block_ptr_value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint Position {
			[Export ("position")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("position"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSRange PositionRange {
			[Export ("positionRange")]
			get {
				NSRange ret;
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("positionRange"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Sequential {
			[Export ("isSequential")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSequential"));
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
		public double LastPositionTimestamp {
			[Export ("lastPositionTimestamp")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("lastPositionTimestamp"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public double LastPositionLatency {
			[Export ("lastPositionLatency")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("lastPositionLatency"));
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
