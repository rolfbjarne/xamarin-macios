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
namespace SpriteKit {
	#pragma warning disable CS1573
	/// <summary>Associates a <see cref="T:SpriteKit.SKWarpGeometry" /> and subdivision levels with an implementation.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "SKWarpable", WrapperType = typeof (SKWarpableWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "WarpGeometry", Selector = "warpGeometry", PropertyType = typeof (SKWarpGeometry), GetterSelector = "warpGeometry", SetterSelector = "setWarpGeometry:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SubdivisionLevels", Selector = "subdivisionLevels", PropertyType = typeof (IntPtr), GetterSelector = "subdivisionLevels", SetterSelector = "setSubdivisionLevels:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ISKWarpable : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("SubdivisionLevels")]
		[DynamicDependencyAttribute ("WarpGeometry")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SKWarpableWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISKWarpable ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual SKWarpGeometry? WarpGeometry {
			[Export ("warpGeometry", ArgumentSemantic.Assign)]
			get {
				return _GetWarpGeometry (this);
			}
			[Export ("setWarpGeometry:", ArgumentSemantic.Assign)]
			set {
				_SetWarpGeometry (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static SKWarpGeometry _GetWarpGeometry (ISKWarpable This)
		{
			SKWarpGeometry ret;
			ret =  Runtime.GetNSObject<SKWarpGeometry> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("warpGeometry")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetWarpGeometry (ISKWarpable This, SKWarpGeometry? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setWarpGeometry:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint SubdivisionLevels {
			[Export ("subdivisionLevels")]
			get {
				return _GetSubdivisionLevels (this);
			}
			[Export ("setSubdivisionLevels:")]
			set {
				_SetSubdivisionLevels (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetSubdivisionLevels (ISKWarpable This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("subdivisionLevels"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSubdivisionLevels (ISKWarpable This, nint value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSubdivisionLevels:"), value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SKWarpableWrapper : BaseWrapper, ISKWarpable {
		public SKWarpableWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SKWarpableWrapper))]
		static SKWarpableWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SKWarpGeometry? WarpGeometry {
			[Export ("warpGeometry", ArgumentSemantic.Assign)]
			get {
				SKWarpGeometry ret;
				ret =  Runtime.GetNSObject<SKWarpGeometry> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("warpGeometry")), false)!;
				return ret;
			}
			[Export ("setWarpGeometry:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setWarpGeometry:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint SubdivisionLevels {
			[Export ("subdivisionLevels")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("subdivisionLevels"));
				return ret;
			}
			[Export ("setSubdivisionLevels:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSubdivisionLevels:"), value);
			}
		}
	}
}
