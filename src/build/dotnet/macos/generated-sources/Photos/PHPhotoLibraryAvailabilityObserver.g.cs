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
namespace Photos {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>PHPhotoLibraryAvailabilityObserver</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "PHPhotoLibraryAvailabilityObserver", WrapperType = typeof (PHPhotoLibraryAvailabilityObserverWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PhotoLibraryDidBecomeUnavailable", Selector = "photoLibraryDidBecomeUnavailable:", ParameterType = new Type [] { typeof (PHPhotoLibrary) }, ParameterByRef = new bool [] { false })]
	public partial interface IPHPhotoLibraryAvailabilityObserver : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("photoLibraryDidBecomeUnavailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PhotoLibraryDidBecomeUnavailable (PHPhotoLibrary photoLibrary)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PhotoLibraryDidBecomeUnavailable (IPHPhotoLibraryAvailabilityObserver This, PHPhotoLibrary photoLibrary)
		{
			var photoLibrary__handle__ = photoLibrary!.GetNonNullHandle (nameof (photoLibrary));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("photoLibraryDidBecomeUnavailable:"), photoLibrary__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (photoLibrary);
		}
		[DynamicDependencyAttribute ("PhotoLibraryDidBecomeUnavailable(Photos.PHPhotoLibrary)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PHPhotoLibraryAvailabilityObserverWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPHPhotoLibraryAvailabilityObserver ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PHPhotoLibraryAvailabilityObserverWrapper : BaseWrapper, IPHPhotoLibraryAvailabilityObserver {
		public PHPhotoLibraryAvailabilityObserverWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PHPhotoLibraryAvailabilityObserverWrapper))]
		static PHPhotoLibraryAvailabilityObserverWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("photoLibraryDidBecomeUnavailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PhotoLibraryDidBecomeUnavailable (PHPhotoLibrary photoLibrary)
		{
			var photoLibrary__handle__ = photoLibrary!.GetNonNullHandle (nameof (photoLibrary));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("photoLibraryDidBecomeUnavailable:"), photoLibrary__handle__);
			GC.KeepAlive (photoLibrary);
		}
	}
}
