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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace MetalPerformanceShaders {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MPSSVGFTextureAllocator</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "MPSSVGFTextureAllocator", WrapperType = typeof (MPSSvgfTextureAllocatorWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetTexture", Selector = "textureWithPixelFormat:width:height:", ReturnType = typeof (IMTLTexture), ParameterType = new Type [] { typeof (MTLPixelFormat), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReturnTexture", Selector = "returnTexture:", ParameterType = new Type [] { typeof (IMTLTexture) }, ParameterByRef = new bool [] { false })]
	public partial interface IMPSSvgfTextureAllocator : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("textureWithPixelFormat:width:height:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLTexture? GetTexture (global::Metal.MTLPixelFormat pixelFormat, nuint width, nuint height)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLTexture? _GetTexture (IMPSSvgfTextureAllocator This, global::Metal.MTLPixelFormat pixelFormat, nuint width, nuint height)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("textureWithPixelFormat:width:height:"), (UIntPtr) (ulong) pixelFormat, width, height), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("returnTexture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReturnTexture (global::Metal.IMTLTexture texture)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReturnTexture (IMPSSvgfTextureAllocator This, global::Metal.IMTLTexture texture)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("returnTexture:"), texture__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		[DynamicDependencyAttribute ("GetTexture(Metal.MTLPixelFormat,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("ReturnTexture(Metal.IMTLTexture)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSSvgfTextureAllocatorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMPSSvgfTextureAllocator ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MPSSvgfTextureAllocatorWrapper : BaseWrapper, IMPSSvgfTextureAllocator {
		public MPSSvgfTextureAllocatorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSSvgfTextureAllocatorWrapper))]
		static MPSSvgfTextureAllocatorWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("textureWithPixelFormat:width:height:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.IMTLTexture? GetTexture (global::Metal.MTLPixelFormat pixelFormat, nuint width, nuint height)
		{
			global::Metal.IMTLTexture ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("textureWithPixelFormat:width:height:"), (UIntPtr) (ulong) pixelFormat, width, height), false)!;
			return ret;
		}
		[Export ("returnTexture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ReturnTexture (global::Metal.IMTLTexture texture)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("returnTexture:"), texture__handle__);
			GC.KeepAlive (texture);
		}
	}
}
