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
namespace PassKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>PKPaymentInformationRequestHandling</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "PKPaymentInformationRequestHandling", WrapperType = typeof (PKPaymentInformationRequestHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleInformationRequest", Selector = "handleInformationRequest:completion:", ParameterType = new Type [] { typeof (PassKit.PKBarcodeEventMetadataRequest), typeof (PassKit.PKInformationRequestCompletionBlock) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDPKInformationRequestCompletionBlock) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleSignatureRequest", Selector = "handleSignatureRequest:completion:", ParameterType = new Type [] { typeof (PassKit.PKBarcodeEventSignatureRequest), typeof (PassKit.PKSignatureRequestCompletionBlock) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDPKSignatureRequestCompletionBlock) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleConfigurationRequest", Selector = "handleConfigurationRequest:completion:", ParameterType = new Type [] { typeof (PassKit.PKBarcodeEventConfigurationRequest), typeof (Action) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	public partial interface IPKPaymentInformationRequestHandling : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("handleInformationRequest:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleInformationRequest (PKBarcodeEventMetadataRequest infoRequest, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPKInformationRequestCompletionBlock))]PKInformationRequestCompletionBlock completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleInformationRequest (IPKPaymentInformationRequestHandling This, PKBarcodeEventMetadataRequest infoRequest, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPKInformationRequestCompletionBlock))]PKInformationRequestCompletionBlock completion)
		{
			var infoRequest__handle__ = infoRequest!.GetNonNullHandle (nameof (infoRequest));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDPKInformationRequestCompletionBlock.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleInformationRequest:completion:"), infoRequest__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (infoRequest);
		}
		[global::Foundation.RequiredMember]
		[Export ("handleSignatureRequest:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleSignatureRequest (PKBarcodeEventSignatureRequest signatureRequest, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPKSignatureRequestCompletionBlock))]PKSignatureRequestCompletionBlock completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleSignatureRequest (IPKPaymentInformationRequestHandling This, PKBarcodeEventSignatureRequest signatureRequest, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPKSignatureRequestCompletionBlock))]PKSignatureRequestCompletionBlock completion)
		{
			var signatureRequest__handle__ = signatureRequest!.GetNonNullHandle (nameof (signatureRequest));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDPKSignatureRequestCompletionBlock.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleSignatureRequest:completion:"), signatureRequest__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (signatureRequest);
		}
		[global::Foundation.RequiredMember]
		[Export ("handleConfigurationRequest:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleConfigurationRequest (PKBarcodeEventConfigurationRequest configurationRequest, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleConfigurationRequest (IPKPaymentInformationRequestHandling This, PKBarcodeEventConfigurationRequest configurationRequest, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			var configurationRequest__handle__ = configurationRequest!.GetNonNullHandle (nameof (configurationRequest));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleConfigurationRequest:completion:"), configurationRequest__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (configurationRequest);
		}
		[DynamicDependencyAttribute ("HandleConfigurationRequest(PassKit.PKBarcodeEventConfigurationRequest,System.Action)")]
		[DynamicDependencyAttribute ("HandleInformationRequest(PassKit.PKBarcodeEventMetadataRequest,PassKit.PKInformationRequestCompletionBlock)")]
		[DynamicDependencyAttribute ("HandleSignatureRequest(PassKit.PKBarcodeEventSignatureRequest,PassKit.PKSignatureRequestCompletionBlock)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKPaymentInformationRequestHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPKPaymentInformationRequestHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PKPaymentInformationRequestHandlingWrapper : BaseWrapper, IPKPaymentInformationRequestHandling {
		public PKPaymentInformationRequestHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKPaymentInformationRequestHandlingWrapper))]
		static PKPaymentInformationRequestHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("handleInformationRequest:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleInformationRequest (PKBarcodeEventMetadataRequest infoRequest, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPKInformationRequestCompletionBlock))]PKInformationRequestCompletionBlock completion)
		{
			var infoRequest__handle__ = infoRequest!.GetNonNullHandle (nameof (infoRequest));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDPKInformationRequestCompletionBlock.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleInformationRequest:completion:"), infoRequest__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (infoRequest);
		}
		[Export ("handleSignatureRequest:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleSignatureRequest (PKBarcodeEventSignatureRequest signatureRequest, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPKSignatureRequestCompletionBlock))]PKSignatureRequestCompletionBlock completion)
		{
			var signatureRequest__handle__ = signatureRequest!.GetNonNullHandle (nameof (signatureRequest));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDPKSignatureRequestCompletionBlock.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleSignatureRequest:completion:"), signatureRequest__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (signatureRequest);
		}
		[Export ("handleConfigurationRequest:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleConfigurationRequest (PKBarcodeEventConfigurationRequest configurationRequest, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			var configurationRequest__handle__ = configurationRequest!.GetNonNullHandle (nameof (configurationRequest));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleConfigurationRequest:completion:"), configurationRequest__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (configurationRequest);
		}
	}
}
