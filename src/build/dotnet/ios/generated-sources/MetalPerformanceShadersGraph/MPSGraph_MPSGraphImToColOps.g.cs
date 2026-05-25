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
namespace MetalPerformanceShadersGraph {
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe static partial class MPSGraph_MPSGraphImToColOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("colToImWithSourceTensor:outputShape:descriptor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ColToIm (this MPSGraph This, MPSGraphTensor source, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] outputShape, MPSGraphImToColOpDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			if (outputShape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputShape));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			using var nsb_outputShape = NSArray.FromNSObjects (o => new NSNumber (o), outputShape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("colToImWithSourceTensor:outputShape:descriptor:name:"), source__handle__, nsb_outputShape.GetHandle (), descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("imToColWithSourceTensor:descriptor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ImToCol (this MPSGraph This, MPSGraphTensor source, MPSGraphImToColOpDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("imToColWithSourceTensor:descriptor:name:"), source__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphImToColOps */
}
