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
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>Interface for to support tracking whether fragments have been appended to a fragmented asset.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "AVFragmentMinding", WrapperType = typeof (AVFragmentMindingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "IsAssociatedWithFragmentMinder", Selector = "isAssociatedWithFragmentMinder", ReturnType = typeof (bool))]
	public partial interface IAVFragmentMinding : INativeObject, IDisposable
	{
		/// <summary>Return <see langword="true" /> if the implementation is associated with a <see cref="T:AVFoundation.AVFragmentedAssetMinder" />.</summary><returns><see langword="true" /> if the implementation is associated with a <see cref="T:AVFoundation.AVFragmentedAssetMinder" />.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("isAssociatedWithFragmentMinder")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAssociatedWithFragmentMinder ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Return <see langword="true" /> if the implementation is associated with a <see cref="T:AVFoundation.AVFragmentedAssetMinder" />.</summary><returns><see langword="true" /> if the implementation is associated with a <see cref="T:AVFoundation.AVFragmentedAssetMinder" />.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsAssociatedWithFragmentMinder (IAVFragmentMinding This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAssociatedWithFragmentMinder"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("IsAssociatedWithFragmentMinder()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVFragmentMindingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVFragmentMinding ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVFragmentMindingWrapper : BaseWrapper, IAVFragmentMinding {
		public AVFragmentMindingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVFragmentMindingWrapper))]
		static AVFragmentMindingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Return <see langword="true" /> if the implementation is associated with a <see cref="T:AVFoundation.AVFragmentedAssetMinder" />.</summary><returns><see langword="true" /> if the implementation is associated with a <see cref="T:AVFoundation.AVFragmentedAssetMinder" />.</returns><remarks>To be added.</remarks>
		[Export ("isAssociatedWithFragmentMinder")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool IsAssociatedWithFragmentMinder ()
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAssociatedWithFragmentMinder"));
			return ret != 0;
		}
	}
}
