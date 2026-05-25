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
namespace CoreLocation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CLLocationPushServiceExtension</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios15.0")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("macos")]
	[Protocol (Name = "CLLocationPushServiceExtension", WrapperType = typeof (CLLocationPushServiceExtensionWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveLocationPushPayload", Selector = "didReceiveLocationPushPayload:completion:", ParameterType = new Type [] { typeof (global::Foundation.NSDictionary<NSString, NSObject>), typeof (Action) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ServiceExtensionWillTerminate", Selector = "serviceExtensionWillTerminate")]
	public partial interface ICLLocationPushServiceExtension : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("didReceiveLocationPushPayload:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveLocationPushPayload (NSDictionary<NSString, NSObject> payload, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidReceiveLocationPushPayload (ICLLocationPushServiceExtension This, NSDictionary<NSString, NSObject> payload, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			var payload__handle__ = payload!.GetNonNullHandle (nameof (payload));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didReceiveLocationPushPayload:completion:"), payload__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (payload);
		}
		[global::Foundation.OptionalMember]
		[Export ("serviceExtensionWillTerminate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ServiceExtensionWillTerminate ()
		{
			_ServiceExtensionWillTerminate (this);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ServiceExtensionWillTerminate (ICLLocationPushServiceExtension This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("serviceExtensionWillTerminate"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("DidReceiveLocationPushPayload(Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject},System.Action)")]
		[DynamicDependencyAttribute ("ServiceExtensionWillTerminate()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CLLocationPushServiceExtensionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICLLocationPushServiceExtension ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICLLocationPushServiceExtension" /> interface to support all the methods from the CLLocationPushServiceExtension protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICLLocationPushServiceExtension" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CLLocationPushServiceExtension protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CLLocationPushServiceExtension_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ServiceExtensionWillTerminate (this ICLLocationPushServiceExtension This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("serviceExtensionWillTerminate"));
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CLLocationPushServiceExtensionWrapper : BaseWrapper, ICLLocationPushServiceExtension {
		public CLLocationPushServiceExtensionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CLLocationPushServiceExtensionWrapper))]
		static CLLocationPushServiceExtensionWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("didReceiveLocationPushPayload:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DidReceiveLocationPushPayload (NSDictionary<NSString, NSObject> payload, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			var payload__handle__ = payload!.GetNonNullHandle (nameof (payload));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("didReceiveLocationPushPayload:completion:"), payload__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (payload);
		}
	}
}
