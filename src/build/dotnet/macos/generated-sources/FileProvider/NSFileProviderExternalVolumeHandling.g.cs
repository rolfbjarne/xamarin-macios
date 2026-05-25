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
namespace FileProvider {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSFileProviderExternalVolumeHandling</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos15.0")]
	[Protocol (Name = "NSFileProviderExternalVolumeHandling", WrapperType = typeof (NSFileProviderExternalVolumeHandlingWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ShouldConnectExternalDomain", Selector = "shouldConnectExternalDomainWithCompletionHandler:", ParameterType = new Type [] { typeof (NSFileProviderExternalVolumeHandlingShouldConnectExternalDomainCallback) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDNSFileProviderExternalVolumeHandlingShouldConnectExternalDomainCallback) })]
	public partial interface INSFileProviderExternalVolumeHandling : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("shouldConnectExternalDomainWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ShouldConnectExternalDomain ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderExternalVolumeHandlingShouldConnectExternalDomainCallback))]NSFileProviderExternalVolumeHandlingShouldConnectExternalDomainCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ShouldConnectExternalDomain (INSFileProviderExternalVolumeHandling This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderExternalVolumeHandlingShouldConnectExternalDomainCallback))]NSFileProviderExternalVolumeHandlingShouldConnectExternalDomainCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSFileProviderExternalVolumeHandlingShouldConnectExternalDomainCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("shouldConnectExternalDomainWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("ShouldConnectExternalDomain(FileProvider.NSFileProviderExternalVolumeHandlingShouldConnectExternalDomainCallback)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderExternalVolumeHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderExternalVolumeHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderExternalVolumeHandlingWrapper : BaseWrapper, INSFileProviderExternalVolumeHandling {
		public NSFileProviderExternalVolumeHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderExternalVolumeHandlingWrapper))]
		static NSFileProviderExternalVolumeHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("shouldConnectExternalDomainWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ShouldConnectExternalDomain ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderExternalVolumeHandlingShouldConnectExternalDomainCallback))]NSFileProviderExternalVolumeHandlingShouldConnectExternalDomainCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSFileProviderExternalVolumeHandlingShouldConnectExternalDomainCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("shouldConnectExternalDomainWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
	}
}
