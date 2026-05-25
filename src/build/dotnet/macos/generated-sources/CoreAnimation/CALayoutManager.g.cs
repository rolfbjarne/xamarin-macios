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
namespace CoreAnimation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CALayoutManager</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "CALayoutManager", WrapperType = typeof (CALayoutManagerWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPreferredSize", Selector = "preferredSizeOfLayer:", ReturnType = typeof (CGSize), ParameterType = new Type [] { typeof (CALayer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InvalidateLayout", Selector = "invalidateLayoutOfLayer:", ParameterType = new Type [] { typeof (CALayer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LayoutSublayers", Selector = "layoutSublayersOfLayer:", ParameterType = new Type [] { typeof (CALayer) }, ParameterByRef = new bool [] { false })]
	public partial interface ICALayoutManager : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("preferredSizeOfLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetPreferredSize (CALayer layer)
		{
			return _GetPreferredSize (this, layer);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _GetPreferredSize (ICALayoutManager This, CALayer layer)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("preferredSizeOfLayer:"), layer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (layer);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("invalidateLayoutOfLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateLayout (CALayer layer)
		{
			_InvalidateLayout (this, layer);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InvalidateLayout (ICALayoutManager This, CALayer layer)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("invalidateLayoutOfLayer:"), layer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (layer);
		}
		[global::Foundation.OptionalMember]
		[Export ("layoutSublayersOfLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LayoutSublayers (CALayer layer)
		{
			_LayoutSublayers (this, layer);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _LayoutSublayers (ICALayoutManager This, CALayer layer)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("layoutSublayersOfLayer:"), layer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (layer);
		}
		[DynamicDependencyAttribute ("GetPreferredSize(CoreAnimation.CALayer)")]
		[DynamicDependencyAttribute ("InvalidateLayout(CoreAnimation.CALayer)")]
		[DynamicDependencyAttribute ("LayoutSublayers(CoreAnimation.CALayer)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CALayoutManagerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICALayoutManager ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CALayoutManagerWrapper : BaseWrapper, ICALayoutManager {
		public CALayoutManagerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CALayoutManagerWrapper))]
		static CALayoutManagerWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
