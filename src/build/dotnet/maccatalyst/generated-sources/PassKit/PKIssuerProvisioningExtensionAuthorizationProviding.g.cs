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
namespace PassKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>PKIssuerProvisioningExtensionAuthorizationProviding</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "PKIssuerProvisioningExtensionAuthorizationProviding", WrapperType = typeof (PKIssuerProvisioningExtensionAuthorizationProvidingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CompletionHandler", Selector = "completionHandler", PropertyType = typeof (global::System.Action<global::PassKit.PKIssuerProvisioningExtensionAuthorizationResult>), GetterSelector = "completionHandler", SetterSelector = "setCompletionHandler:", ArgumentSemantic = ArgumentSemantic.Copy, ParameterBlockProxy = new Type [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V213) }, ReturnTypeDelegateProxy = typeof (ObjCRuntime.Trampolines.SDActionArity1V213))]
	public partial interface IPKIssuerProvisioningExtensionAuthorizationProviding : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("CompletionHandler")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKIssuerProvisioningExtensionAuthorizationProvidingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPKIssuerProvisioningExtensionAuthorizationProviding ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public unsafe virtual global::System.Action<PKIssuerProvisioningExtensionAuthorizationResult>? CompletionHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity1V213))]
			[Export ("completionHandler", ArgumentSemantic.Copy)]
			get {
				return _GetCompletionHandler (this);
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V213))]
			[Export ("setCompletionHandler:", ArgumentSemantic.Copy)]
			set {
				_SetCompletionHandler (this, value);
			}
		}
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity1V213))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static global::System.Action<PKIssuerProvisioningExtensionAuthorizationResult> _GetCompletionHandler (IPKIssuerProvisioningExtensionAuthorizationProviding This)
		{
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("completionHandler"));
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDActionArity1V213.Create (ret)!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetCompletionHandler (IPKIssuerProvisioningExtensionAuthorizationProviding This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V213))]global::System.Action<PKIssuerProvisioningExtensionAuthorizationResult>? value)
		{
			using var block_value = Trampolines.SDActionArity1V213.CreateNullableBlock (value);
			BlockLiteral *block_ptr_value = null;
			if (value is not null)
				block_ptr_value = &block_value;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setCompletionHandler:"), (IntPtr) block_ptr_value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PKIssuerProvisioningExtensionAuthorizationProvidingWrapper : BaseWrapper, IPKIssuerProvisioningExtensionAuthorizationProviding {
		public PKIssuerProvisioningExtensionAuthorizationProvidingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKIssuerProvisioningExtensionAuthorizationProvidingWrapper))]
		static PKIssuerProvisioningExtensionAuthorizationProvidingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe global::System.Action<PKIssuerProvisioningExtensionAuthorizationResult>? CompletionHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity1V213))]
			[Export ("completionHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("completionHandler"));
				return global::ObjCRuntime.Trampolines.NIDActionArity1V213.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V213))]
			[Export ("setCompletionHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDActionArity1V213.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCompletionHandler:"), (IntPtr) block_ptr_value);
			}
		}
	}
}
