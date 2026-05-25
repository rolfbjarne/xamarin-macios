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
namespace CoreText {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CTAdaptiveImageProviding</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[Protocol (Name = "CTAdaptiveImageProviding", WrapperType = typeof (CTAdaptiveImageProvidingWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetImage", Selector = "imageForProposedSize:scaleFactor:imageOffset:imageSize:", ReturnType = typeof (CGImage), ParameterType = new Type [] { typeof (CGSize), typeof (NFloat), typeof (CGPoint), typeof (CGSize) }, ParameterByRef = new bool [] { false, false, true, true })]
	public partial interface ICTAdaptiveImageProviding : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("imageForProposedSize:scaleFactor:imageOffset:imageSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual CGImage? GetImage (CGSize proposedSize, nfloat scaleFactor, out CGPoint imageOffset, out CGSize imageSize)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static CGImage? _GetImage (ICTAdaptiveImageProviding This, CGSize proposedSize, nfloat scaleFactor, out CGPoint imageOffset, out CGSize imageSize)
		{
			fixed (CGPoint* imageOffset__pointer = &imageOffset) {
			fixed (CGSize* imageSize__pointer = &imageSize) {
			imageOffset = default;
			imageSize = default;
			CGImage ret;
			ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize_nfloat_out_CGPoint_out_CGSize (This.Handle, Selector.GetHandle ("imageForProposedSize:scaleFactor:imageOffset:imageSize:"), proposedSize, scaleFactor, imageOffset__pointer, imageSize__pointer), false)!;
			GC.KeepAlive (This);
			return ret;
			}
			}
		}
		[DynamicDependencyAttribute ("GetImage(CoreGraphics.CGSize,System.Runtime.InteropServices.NFloat,CoreGraphics.CGPoint@,CoreGraphics.CGSize@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CTAdaptiveImageProvidingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICTAdaptiveImageProviding ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CTAdaptiveImageProvidingWrapper : BaseWrapper, ICTAdaptiveImageProviding {
		public CTAdaptiveImageProvidingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CTAdaptiveImageProvidingWrapper))]
		static CTAdaptiveImageProvidingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("imageForProposedSize:scaleFactor:imageOffset:imageSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe CGImage? GetImage (CGSize proposedSize, nfloat scaleFactor, out CGPoint imageOffset, out CGSize imageSize)
		{
			fixed (CGPoint* imageOffset__pointer = &imageOffset) {
			fixed (CGSize* imageSize__pointer = &imageSize) {
			imageOffset = default;
			imageSize = default;
			CGImage ret;
			ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize_nfloat_out_CGPoint_out_CGSize (this.Handle, Selector.GetHandle ("imageForProposedSize:scaleFactor:imageOffset:imageSize:"), proposedSize, scaleFactor, imageOffset__pointer, imageSize__pointer), false)!;
			return ret;
			}
			}
		}
	}
}
