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
namespace MetalPerformanceShaders {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MPSHeapProvider</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "MPSHeapProvider", WrapperType = typeof (MPSHeapProviderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNewHeap", Selector = "newHeapWithDescriptor:", ReturnType = typeof (IMTLHeap), ParameterType = new Type [] { typeof (MTLHeapDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RetireHeap", Selector = "retireHeap:cacheDelay:", ParameterType = new Type [] { typeof (IMTLHeap), typeof (double) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IMPSHeapProvider : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("newHeapWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLHeap? GetNewHeap (global::Metal.MTLHeapDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLHeap? _GetNewHeap (IMPSHeapProvider This, global::Metal.MTLHeapDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			global::Metal.IMTLHeap? ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLHeap> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newHeapWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("retireHeap:cacheDelay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RetireHeap (global::Metal.IMTLHeap heap, double seconds)
		{
			_RetireHeap (this, heap, seconds);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RetireHeap (IMPSHeapProvider This, global::Metal.IMTLHeap heap, double seconds)
		{
			var heap__handle__ = heap!.GetNonNullHandle (nameof (heap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (This.Handle, Selector.GetHandle ("retireHeap:cacheDelay:"), heap__handle__, seconds);
			GC.KeepAlive (This);
			GC.KeepAlive (heap);
		}
		[DynamicDependencyAttribute ("GetNewHeap(Metal.MTLHeapDescriptor)")]
		[DynamicDependencyAttribute ("RetireHeap(Metal.IMTLHeap,System.Double)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSHeapProviderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMPSHeapProvider ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMPSHeapProvider" /> interface to support all the methods from the MPSHeapProvider protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMPSHeapProvider" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MPSHeapProvider protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MPSHeapProvider_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RetireHeap (this IMPSHeapProvider This, global::Metal.IMTLHeap heap, double seconds)
		{
			var heap__handle__ = heap!.GetNonNullHandle (nameof (heap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (This.Handle, Selector.GetHandle ("retireHeap:cacheDelay:"), heap__handle__, seconds);
			GC.KeepAlive (This);
			GC.KeepAlive (heap);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MPSHeapProviderWrapper : BaseWrapper, IMPSHeapProvider {
		public MPSHeapProviderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSHeapProviderWrapper))]
		static MPSHeapProviderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("newHeapWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Metal.IMTLHeap? GetNewHeap (global::Metal.MTLHeapDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			global::Metal.IMTLHeap? ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLHeap> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newHeapWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
	}
}
