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
namespace MediaPlayer {
	#pragma warning disable CS1573
	/// <summary>Protocol for playing videos with the Music app.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "MPSystemMusicPlayerController", WrapperType = typeof (MPSystemMusicPlayerControllerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OpenToPlay", Selector = "openToPlayQueueDescriptor:", ParameterType = new Type [] { typeof (MPMusicPlayerQueueDescriptor) }, ParameterByRef = new bool [] { false })]
	public partial interface IMPSystemMusicPlayerController : INativeObject, IDisposable
	{
		/// <param name="queueDescriptor">The queue descriptor for the media items to play.</param><summary>Opens the Music app and plays the specified items.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("openToPlayQueueDescriptor:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OpenToPlay (MPMusicPlayerQueueDescriptor queueDescriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="queueDescriptor">The queue descriptor for the media items to play.</param><summary>Opens the Music app and plays the specified items.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OpenToPlay (IMPSystemMusicPlayerController This, MPMusicPlayerQueueDescriptor queueDescriptor)
		{
			var queueDescriptor__handle__ = queueDescriptor!.GetNonNullHandle (nameof (queueDescriptor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("openToPlayQueueDescriptor:"), queueDescriptor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (queueDescriptor);
		}
		[DynamicDependencyAttribute ("OpenToPlay(MediaPlayer.MPMusicPlayerQueueDescriptor)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSystemMusicPlayerControllerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMPSystemMusicPlayerController ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MPSystemMusicPlayerControllerWrapper : BaseWrapper, IMPSystemMusicPlayerController {
		public MPSystemMusicPlayerControllerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSystemMusicPlayerControllerWrapper))]
		static MPSystemMusicPlayerControllerWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="queueDescriptor">The queue descriptor for the media items to play.</param><summary>Opens the Music app and plays the specified items.</summary><remarks>To be added.</remarks>
		[Export ("openToPlayQueueDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OpenToPlay (MPMusicPlayerQueueDescriptor queueDescriptor)
		{
			var queueDescriptor__handle__ = queueDescriptor!.GetNonNullHandle (nameof (queueDescriptor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("openToPlayQueueDescriptor:"), queueDescriptor__handle__);
			GC.KeepAlive (queueDescriptor);
		}
	}
}
