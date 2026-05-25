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
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class MPSGraph_MPSGraphArithmeticOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("absoluteWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Absolute (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("absoluteWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("absoluteSquareWithTensor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor AbsoluteSquare (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("absoluteSquareWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("acosWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Acos (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("acosWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("acoshWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Acosh (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("acoshWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("additionWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Addition (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("additionWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("asinWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Asin (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("asinWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("asinhWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Asinh (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("asinhWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("atanWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Atan (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("atanWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("atan2WithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Atan2 (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("atan2WithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("atanhWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Atanh (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("atanhWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("bitwiseANDWithPrimaryTensor:secondaryTensor:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BitwiseAnd (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("bitwiseANDWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("bitwiseLeftShiftWithPrimaryTensor:secondaryTensor:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BitwiseLeftShift (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("bitwiseLeftShiftWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("bitwiseNOTWithTensor:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BitwiseNot (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("bitwiseNOTWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("bitwiseORWithPrimaryTensor:secondaryTensor:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BitwiseOr (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("bitwiseORWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("bitwisePopulationCountWithTensor:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BitwisePopulationCount (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("bitwisePopulationCountWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("bitwiseRightShiftWithPrimaryTensor:secondaryTensor:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BitwiseRightShift (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("bitwiseRightShiftWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("bitwiseXORWithPrimaryTensor:secondaryTensor:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BitwiseXor (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("bitwiseXORWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("ceilWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Ceil (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("ceilWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("clampWithTensor:minValueTensor:maxValueTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Clamp (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor minValueTensor, MPSGraphTensor maxValueTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var minValueTensor__handle__ = minValueTensor!.GetNonNullHandle (nameof (minValueTensor));
			var maxValueTensor__handle__ = maxValueTensor!.GetNonNullHandle (nameof (maxValueTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("clampWithTensor:minValueTensor:maxValueTensor:name:"), tensor__handle__, minValueTensor__handle__, maxValueTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (minValueTensor);
			GC.KeepAlive (maxValueTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("complexTensorWithRealTensor:imaginaryTensor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ComplexTensor (this MPSGraph This, MPSGraphTensor realTensor, MPSGraphTensor imaginaryTensor, string? name)
		{
			var realTensor__handle__ = realTensor!.GetNonNullHandle (nameof (realTensor));
			var imaginaryTensor__handle__ = imaginaryTensor!.GetNonNullHandle (nameof (imaginaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("complexTensorWithRealTensor:imaginaryTensor:name:"), realTensor__handle__, imaginaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (realTensor);
			GC.KeepAlive (imaginaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("conjugateWithTensor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Conjugate (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("conjugateWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cosWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Cos (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cosWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("coshWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Cosh (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("coshWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("divisionWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Division (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("divisionWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("divisionNoNaNWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor DivisionNoNaN (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("divisionNoNaNWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("equalWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor EqualTo (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("equalWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("erfWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Erf (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("erfWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("exponentWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Exponent (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("exponentWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("exponentBase10WithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ExponentBase10 (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("exponentBase10WithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("exponentBase2WithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ExponentBase2 (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("exponentBase2WithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("floorWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Floor (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("floorWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("floorModuloWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor FloorModulo (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("floorModuloWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("greaterThanWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor GreaterThan (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("greaterThanWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("greaterThanOrEqualToWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor GreaterThanOrEqualTo (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("greaterThanOrEqualToWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("identityWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Identity (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("identityWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("imaginaryPartOfTensor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ImaginaryPart (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("imaginaryPartOfTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("isFiniteWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor IsFinite (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("isFiniteWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("isInfiniteWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor IsInfinite (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("isInfiniteWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("isNaNWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor IsNaN (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("isNaNWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("lessThanWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LessThan (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("lessThanWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("lessThanOrEqualToWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LessThanOrEqualTo (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("lessThanOrEqualToWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("logarithmWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Logarithm (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("logarithmWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("logarithmBase10WithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LogarithmBase10 (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("logarithmBase10WithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("logarithmBase2WithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LogarithmBase2 (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("logarithmBase2WithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("logicalANDWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LogicalAnd (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("logicalANDWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("logicalNANDWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LogicalNand (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("logicalNANDWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("logicalNORWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LogicalNor (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("logicalNORWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("logicalORWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LogicalOr (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("logicalORWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("logicalXNORWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LogicalXnor (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("logicalXNORWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("logicalXORWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LogicalXor (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("logicalXORWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("maximumWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Maximum (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("maximumWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("maximumWithNaNPropagationWithPrimaryTensor:secondaryTensor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor MaximumWithNaNPropagation (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("maximumWithNaNPropagationWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("minimumWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Minimum (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("minimumWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("minimumWithNaNPropagationWithPrimaryTensor:secondaryTensor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor MinimumWithNaNPropagation (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("minimumWithNaNPropagationWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("moduloWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Modulo (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("moduloWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("multiplicationWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Multiplication (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("multiplicationWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("negativeWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Negative (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("negativeWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("notWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Not (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("notWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("notEqualWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor NotEqualTo (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("notEqualWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <summary>Creates a planar tensor from a complex tensor, extracting the real and imaginary parts into a planar format.</summary>
		[Export ("planarTensorWithComplexTensor:name:")]
		[SupportedOSPlatform ("tvos26.3")]
		[SupportedOSPlatform ("macos26.3")]
		[SupportedOSPlatform ("ios26.3")]
		[SupportedOSPlatform ("maccatalyst26.3")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor PlanarTensor (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("planarTensorWithComplexTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("powerWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Power (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("powerWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("realPartOfTensor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor RealPart (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("realPartOfTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reciprocalWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Reciprocal (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reciprocalWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reciprocalSquareRootWithTensor:name:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReciprocalSquareRoot (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reciprocalSquareRootWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reverseSquareRootWithTensor:name:")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'ReciprocalSquareRoot' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'ReciprocalSquareRoot' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'ReciprocalSquareRoot' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'ReciprocalSquareRoot' instead.")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReverseSquareRoot (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reverseSquareRootWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("rintWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Rint (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("rintWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("roundWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Round (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("roundWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("selectWithPredicateTensor:truePredicateTensor:falsePredicateTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Select (this MPSGraph This, MPSGraphTensor predicateTensor, MPSGraphTensor truePredicateTensor, MPSGraphTensor falseSelectTensor, string? name)
		{
			var predicateTensor__handle__ = predicateTensor!.GetNonNullHandle (nameof (predicateTensor));
			var truePredicateTensor__handle__ = truePredicateTensor!.GetNonNullHandle (nameof (truePredicateTensor));
			var falseSelectTensor__handle__ = falseSelectTensor!.GetNonNullHandle (nameof (falseSelectTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("selectWithPredicateTensor:truePredicateTensor:falsePredicateTensor:name:"), predicateTensor__handle__, truePredicateTensor__handle__, falseSelectTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (predicateTensor);
			GC.KeepAlive (truePredicateTensor);
			GC.KeepAlive (falseSelectTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("signWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Sign (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("signWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("signbitWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Signbit (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("signbitWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sinWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Sin (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sinWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sinhWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Sinh (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sinhWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("squareWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Square (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("squareWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("squareRootWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SquareRoot (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("squareRootWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("subtractionWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Subtraction (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("subtractionWithPrimaryTensor:secondaryTensor:name:"), primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("tanWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Tan (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tanWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("tanhWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Tanh (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tanhWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("truncateWithTensor:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Truncate (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("truncateWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphArithmeticOps */
}
