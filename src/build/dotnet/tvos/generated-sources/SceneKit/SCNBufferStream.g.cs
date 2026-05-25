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
namespace SceneKit {
	#pragma warning disable CS1573
	/// <summary>Interface for managing a custom shader's Metal buffer.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "SCNBufferStream", WrapperType = typeof (SCNBufferStreamWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Length", Selector = "writeBytes:length:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ISCNBufferStream : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("writeBytes:length:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Length (nint bytes, nuint length)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Length (ISCNBufferStream This, nint bytes, nuint length)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("writeBytes:length:"), bytes, length);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("Length(System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCNBufferStreamWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISCNBufferStream ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SCNBufferStreamWrapper : BaseWrapper, ISCNBufferStream {
		public SCNBufferStreamWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCNBufferStreamWrapper))]
		static SCNBufferStreamWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("writeBytes:length:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Length (nint bytes, nuint length)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("writeBytes:length:"), bytes, length);
		}
	}
}
