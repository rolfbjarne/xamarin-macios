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
	/// <summary>This interface represents the Objective-C protocol <c>NSFileProviderKnownFolderSupporting</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos15.0")]
	[Protocol (Name = "NSFileProviderKnownFolderSupporting", WrapperType = typeof (NSFileProviderKnownFolderSupportingWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetKnownFolderLocations", Selector = "getKnownFolderLocations:completionHandler:", ParameterType = new Type [] { typeof (NSFileProviderKnownFolders), typeof (NSFileProviderKnownFolderLocationCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDNSFileProviderKnownFolderLocationCallback) })]
	public partial interface INSFileProviderKnownFolderSupporting : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("getKnownFolderLocations:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetKnownFolderLocations (NSFileProviderKnownFolders knownFolders, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderKnownFolderLocationCallback))]NSFileProviderKnownFolderLocationCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GetKnownFolderLocations (INSFileProviderKnownFolderSupporting This, NSFileProviderKnownFolders knownFolders, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderKnownFolderLocationCallback))]NSFileProviderKnownFolderLocationCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSFileProviderKnownFolderLocationCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("getKnownFolderLocations:completionHandler:"), (UIntPtr) (ulong) knownFolders, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("GetKnownFolderLocations(FileProvider.NSFileProviderKnownFolders,FileProvider.NSFileProviderKnownFolderLocationCallback)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderKnownFolderSupportingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderKnownFolderSupporting ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderKnownFolderSupportingWrapper : BaseWrapper, INSFileProviderKnownFolderSupporting {
		public NSFileProviderKnownFolderSupportingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderKnownFolderSupportingWrapper))]
		static NSFileProviderKnownFolderSupportingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("getKnownFolderLocations:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void GetKnownFolderLocations (NSFileProviderKnownFolders knownFolders, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderKnownFolderLocationCallback))]NSFileProviderKnownFolderLocationCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSFileProviderKnownFolderLocationCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("getKnownFolderLocations:completionHandler:"), (UIntPtr) (ulong) knownFolders, (IntPtr) block_ptr_completionHandler);
		}
	}
}
