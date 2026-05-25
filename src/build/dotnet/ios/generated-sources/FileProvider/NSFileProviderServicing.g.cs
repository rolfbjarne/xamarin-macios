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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace FileProvider {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSFileProviderServicing</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSFileProviderServicing", WrapperType = typeof (NSFileProviderServicingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetSupportedServiceSources", Selector = "supportedServiceSourcesForItemIdentifier:completionHandler:", ReturnType = typeof (NSProgress), ParameterType = new Type [] { typeof (string), typeof (global::System.Action<global::FileProvider.INSFileProviderServiceSource[], NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V81) })]
	public partial interface INSFileProviderServicing : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("supportedServiceSourcesForItemIdentifier:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress GetSupportedServiceSources (string itemIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V81))]global::System.Action<INSFileProviderServiceSource[], NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSProgress _GetSupportedServiceSources (INSFileProviderServicing This, string itemIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V81))]global::System.Action<INSFileProviderServiceSource[], NSError> completionHandler)
		{
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			using var block_completionHandler = Trampolines.SDActionArity2V81.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("supportedServiceSourcesForItemIdentifier:completionHandler:"), nsitemIdentifier, (IntPtr) block_ptr_completionHandler), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsitemIdentifier);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetSupportedServiceSources(System.String,System.Action{FileProvider.INSFileProviderServiceSource[],Foundation.NSError})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderServicingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderServicing ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderServicingWrapper : BaseWrapper, INSFileProviderServicing {
		public NSFileProviderServicingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderServicingWrapper))]
		static NSFileProviderServicingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("supportedServiceSourcesForItemIdentifier:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSProgress GetSupportedServiceSources (string itemIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V81))]global::System.Action<INSFileProviderServiceSource[], NSError> completionHandler)
		{
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			using var block_completionHandler = Trampolines.SDActionArity2V81.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("supportedServiceSourcesForItemIdentifier:completionHandler:"), nsitemIdentifier, (IntPtr) block_ptr_completionHandler), false)!;
			CFString.ReleaseNative (nsitemIdentifier);
			return ret!;
		}
	}
}
