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
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MTLTextureViewPool</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[Protocol (Name = "MTLTextureViewPool", WrapperType = typeof (MTLTextureViewPoolWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTextureView", Selector = "setTextureView:atIndex:", ReturnType = typeof (MTLResourceId), ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTextureView", Selector = "setTextureView:descriptor:atIndex:", ReturnType = typeof (MTLResourceId), ParameterType = new Type [] { typeof (IMTLTexture), typeof (MTLTextureViewDescriptor), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTextureViewFromBuffer", Selector = "setTextureViewFromBuffer:descriptor:offset:bytesPerRow:atIndex:", ReturnType = typeof (MTLResourceId), ParameterType = new Type [] { typeof (IMTLBuffer), typeof (MTLTextureDescriptor), typeof (UIntPtr), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	public partial interface IMTLTextureViewPool : INativeObject, IDisposable, 
		Metal.IMTLResourceViewPool
	{
		[global::Foundation.RequiredMember]
		[Export ("setTextureView:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLResourceId SetTextureView (IMTLTexture texture, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLResourceId _SetTextureView (IMTLTextureViewPool This, IMTLTexture texture, nuint index)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setTextureView:atIndex:"), texture__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("setTextureView:descriptor:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLResourceId SetTextureView (IMTLTexture texture, MTLTextureViewDescriptor descriptor, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLResourceId _SetTextureView (IMTLTextureViewPool This, IMTLTexture texture, MTLTextureViewDescriptor descriptor, nuint index)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setTextureView:descriptor:atIndex:"), texture__handle__, descriptor__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("setTextureViewFromBuffer:descriptor:offset:bytesPerRow:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLResourceId SetTextureViewFromBuffer (IMTLBuffer buffer, MTLTextureDescriptor descriptor, nuint offset, nuint bytesPerRow, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLResourceId _SetTextureViewFromBuffer (IMTLTextureViewPool This, IMTLBuffer buffer, MTLTextureDescriptor descriptor, nuint offset, nuint bytesPerRow, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setTextureViewFromBuffer:descriptor:offset:bytesPerRow:atIndex:"), buffer__handle__, descriptor__handle__, offset, bytesPerRow, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[DynamicDependencyAttribute ("SetTextureView(Metal.IMTLTexture,Metal.MTLTextureViewDescriptor,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetTextureView(Metal.IMTLTexture,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetTextureViewFromBuffer(Metal.IMTLBuffer,Metal.MTLTextureDescriptor,System.UIntPtr,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLTextureViewPoolWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLTextureViewPool ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLTextureViewPoolWrapper : BaseWrapper, IMTLTextureViewPool {
		public MTLTextureViewPoolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLTextureViewPoolWrapper))]
		static MTLTextureViewPoolWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("setTextureView:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLResourceId SetTextureView (IMTLTexture texture, nuint index)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setTextureView:atIndex:"), texture__handle__, index);
			GC.KeepAlive (texture);
			return ret!;
		}
		[Export ("setTextureView:descriptor:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLResourceId SetTextureView (IMTLTexture texture, MTLTextureViewDescriptor descriptor, nuint index)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setTextureView:descriptor:atIndex:"), texture__handle__, descriptor__handle__, index);
			GC.KeepAlive (texture);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("setTextureViewFromBuffer:descriptor:offset:bytesPerRow:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLResourceId SetTextureViewFromBuffer (IMTLBuffer buffer, MTLTextureDescriptor descriptor, nuint offset, nuint bytesPerRow, nuint index)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setTextureViewFromBuffer:descriptor:offset:bytesPerRow:atIndex:"), buffer__handle__, descriptor__handle__, offset, bytesPerRow, index);
			GC.KeepAlive (buffer);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("copyResourceViewsFromPool:sourceRange:destinationIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLResourceId CopyResourceViews (IMTLResourceViewPool sourcePool, NSRange sourceRange, nuint destinationIndex)
		{
			var sourcePool__handle__ = sourcePool!.GetNonNullHandle (nameof (sourcePool));
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend_NativeHandle_NSRange_UIntPtr (this.Handle, Selector.GetHandle ("copyResourceViewsFromPool:sourceRange:destinationIndex:"), sourcePool__handle__, sourceRange, destinationIndex);
			GC.KeepAlive (sourcePool);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public MTLResourceId BaseResourceId {
			[Export ("baseResourceID")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				MTLResourceId ret;
				ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend (this.Handle, Selector.GetHandle ("baseResourceID"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public nuint ResourceViewCount {
			[Export ("resourceViewCount")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("resourceViewCount"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public IMTLDevice Device {
			[Export ("device")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				IMTLDevice ret;
				ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public string? Label {
			[Export ("label")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
		}
	}
}
