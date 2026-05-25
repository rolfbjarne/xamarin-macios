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
	/// <summary>This interface represents the Objective-C protocol <c>AVAssetReaderCaptionValidationHandling</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios18.0")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "AVAssetReaderCaptionValidationHandling", WrapperType = typeof (AVAssetReaderCaptionValidationHandlingWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidVendCaption", Selector = "captionAdaptor:didVendCaption:skippingUnsupportedSourceSyntaxElements:", ParameterType = new Type [] { typeof (AVAssetReaderOutputCaptionAdaptor), typeof (AVCaption), typeof (String[]) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IAVAssetReaderCaptionValidationHandling : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("captionAdaptor:didVendCaption:skippingUnsupportedSourceSyntaxElements:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidVendCaption (AVAssetReaderOutputCaptionAdaptor adaptor, AVCaption caption, string[] syntaxElements)
		{
			_DidVendCaption (this, adaptor, caption, syntaxElements);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidVendCaption (IAVAssetReaderCaptionValidationHandling This, AVAssetReaderOutputCaptionAdaptor adaptor, AVCaption caption, string[] syntaxElements)
		{
			var adaptor__handle__ = adaptor!.GetNonNullHandle (nameof (adaptor));
			var caption__handle__ = caption!.GetNonNullHandle (nameof (caption));
			if (syntaxElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (syntaxElements));
			using var nsa_syntaxElements = NSArray.FromStrings (syntaxElements);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captionAdaptor:didVendCaption:skippingUnsupportedSourceSyntaxElements:"), adaptor__handle__, caption__handle__, nsa_syntaxElements.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (adaptor);
			GC.KeepAlive (caption);
		}
		[DynamicDependencyAttribute ("DidVendCaption(AVFoundation.AVAssetReaderOutputCaptionAdaptor,AVFoundation.AVCaption,System.String[])")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVAssetReaderCaptionValidationHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVAssetReaderCaptionValidationHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVAssetReaderCaptionValidationHandling" /> interface to support all the methods from the AVAssetReaderCaptionValidationHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVAssetReaderCaptionValidationHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVAssetReaderCaptionValidationHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVAssetReaderCaptionValidationHandling_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidVendCaption (this IAVAssetReaderCaptionValidationHandling This, AVAssetReaderOutputCaptionAdaptor adaptor, AVCaption caption, string[] syntaxElements)
		{
			var adaptor__handle__ = adaptor!.GetNonNullHandle (nameof (adaptor));
			var caption__handle__ = caption!.GetNonNullHandle (nameof (caption));
			if (syntaxElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (syntaxElements));
			using var nsa_syntaxElements = NSArray.FromStrings (syntaxElements);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captionAdaptor:didVendCaption:skippingUnsupportedSourceSyntaxElements:"), adaptor__handle__, caption__handle__, nsa_syntaxElements.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (adaptor);
			GC.KeepAlive (caption);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVAssetReaderCaptionValidationHandlingWrapper : BaseWrapper, IAVAssetReaderCaptionValidationHandling {
		public AVAssetReaderCaptionValidationHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVAssetReaderCaptionValidationHandlingWrapper))]
		static AVAssetReaderCaptionValidationHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
