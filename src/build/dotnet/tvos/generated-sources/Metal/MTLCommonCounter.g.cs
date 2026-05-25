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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Metal {
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum MTLCommonCounter : int {
		Timestamp = 0,
		TessellationInputPatches = 1,
		VertexInvocations = 2,
		PostTessellationVertexInvocations = 3,
		ClipperInvocations = 4,
		ClipperPrimitivesOut = 5,
		FragmentInvocations = 6,
		FragmentsPassed = 7,
		ComputeKernelInvocations = 8,
		TotalCycles = 9,
		VertexCycles = 10,
		TessellationCycles = 11,
		PostTessellationVertexCycles = 12,
		FragmentCycles = 13,
		RenderTargetWriteCycles = 14,
		SetTimestamp = 15,
		SetStageUtilization = 16,
		SetStatistic = 17,
	}
	/// <summary>Extension methods for the <see cref="global::Metal.MTLCommonCounter" /> enumeration.</summary>
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class MTLCommonCounterExtensions {
		static IntPtr[] values = new IntPtr [18];
		[Field ("MTLCommonCounterTimestamp", "Metal")]
		internal unsafe static IntPtr MTLCommonCounterTimestamp {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Metal.Handle, "MTLCommonCounterTimestamp", storage);
			}
		}
		[Field ("MTLCommonCounterTessellationInputPatches", "Metal")]
		internal unsafe static IntPtr MTLCommonCounterTessellationInputPatches {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Metal.Handle, "MTLCommonCounterTessellationInputPatches", storage);
			}
		}
		[Field ("MTLCommonCounterVertexInvocations", "Metal")]
		internal unsafe static IntPtr MTLCommonCounterVertexInvocations {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Metal.Handle, "MTLCommonCounterVertexInvocations", storage);
			}
		}
		[Field ("MTLCommonCounterPostTessellationVertexInvocations", "Metal")]
		internal unsafe static IntPtr MTLCommonCounterPostTessellationVertexInvocations {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Metal.Handle, "MTLCommonCounterPostTessellationVertexInvocations", storage);
			}
		}
		[Field ("MTLCommonCounterClipperInvocations", "Metal")]
		internal unsafe static IntPtr MTLCommonCounterClipperInvocations {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Metal.Handle, "MTLCommonCounterClipperInvocations", storage);
			}
		}
		[Field ("MTLCommonCounterClipperPrimitivesOut", "Metal")]
		internal unsafe static IntPtr MTLCommonCounterClipperPrimitivesOut {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Metal.Handle, "MTLCommonCounterClipperPrimitivesOut", storage);
			}
		}
		[Field ("MTLCommonCounterFragmentInvocations", "Metal")]
		internal unsafe static IntPtr MTLCommonCounterFragmentInvocations {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Metal.Handle, "MTLCommonCounterFragmentInvocations", storage);
			}
		}
		[Field ("MTLCommonCounterFragmentsPassed", "Metal")]
		internal unsafe static IntPtr MTLCommonCounterFragmentsPassed {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.Metal.Handle, "MTLCommonCounterFragmentsPassed", storage);
			}
		}
		[Field ("MTLCommonCounterComputeKernelInvocations", "Metal")]
		internal unsafe static IntPtr MTLCommonCounterComputeKernelInvocations {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.Metal.Handle, "MTLCommonCounterComputeKernelInvocations", storage);
			}
		}
		[Field ("MTLCommonCounterTotalCycles", "Metal")]
		internal unsafe static IntPtr MTLCommonCounterTotalCycles {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.Metal.Handle, "MTLCommonCounterTotalCycles", storage);
			}
		}
		[Field ("MTLCommonCounterVertexCycles", "Metal")]
		internal unsafe static IntPtr MTLCommonCounterVertexCycles {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.Metal.Handle, "MTLCommonCounterVertexCycles", storage);
			}
		}
		[Field ("MTLCommonCounterTessellationCycles", "Metal")]
		internal unsafe static IntPtr MTLCommonCounterTessellationCycles {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.Metal.Handle, "MTLCommonCounterTessellationCycles", storage);
			}
		}
		[Field ("MTLCommonCounterPostTessellationVertexCycles", "Metal")]
		internal unsafe static IntPtr MTLCommonCounterPostTessellationVertexCycles {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.Metal.Handle, "MTLCommonCounterPostTessellationVertexCycles", storage);
			}
		}
		[Field ("MTLCommonCounterFragmentCycles", "Metal")]
		internal unsafe static IntPtr MTLCommonCounterFragmentCycles {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.Metal.Handle, "MTLCommonCounterFragmentCycles", storage);
			}
		}
		[Field ("MTLCommonCounterRenderTargetWriteCycles", "Metal")]
		internal unsafe static IntPtr MTLCommonCounterRenderTargetWriteCycles {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.Metal.Handle, "MTLCommonCounterRenderTargetWriteCycles", storage);
			}
		}
		[Field ("MTLCommonCounterSetTimestamp", "Metal")]
		internal unsafe static IntPtr MTLCommonCounterSetTimestamp {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.Metal.Handle, "MTLCommonCounterSetTimestamp", storage);
			}
		}
		[Field ("MTLCommonCounterSetStageUtilization", "Metal")]
		internal unsafe static IntPtr MTLCommonCounterSetStageUtilization {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.Metal.Handle, "MTLCommonCounterSetStageUtilization", storage);
			}
		}
		[Field ("MTLCommonCounterSetStatistic", "Metal")]
		internal unsafe static IntPtr MTLCommonCounterSetStatistic {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.Metal.Handle, "MTLCommonCounterSetStatistic", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this MTLCommonCounter self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // MTLCommonCounter.Timestamp
				ptr = MTLCommonCounterTimestamp;
				break;
			case 1: // MTLCommonCounter.TessellationInputPatches
				ptr = MTLCommonCounterTessellationInputPatches;
				break;
			case 2: // MTLCommonCounter.VertexInvocations
				ptr = MTLCommonCounterVertexInvocations;
				break;
			case 3: // MTLCommonCounter.PostTessellationVertexInvocations
				ptr = MTLCommonCounterPostTessellationVertexInvocations;
				break;
			case 4: // MTLCommonCounter.ClipperInvocations
				ptr = MTLCommonCounterClipperInvocations;
				break;
			case 5: // MTLCommonCounter.ClipperPrimitivesOut
				ptr = MTLCommonCounterClipperPrimitivesOut;
				break;
			case 6: // MTLCommonCounter.FragmentInvocations
				ptr = MTLCommonCounterFragmentInvocations;
				break;
			case 7: // MTLCommonCounter.FragmentsPassed
				ptr = MTLCommonCounterFragmentsPassed;
				break;
			case 8: // MTLCommonCounter.ComputeKernelInvocations
				ptr = MTLCommonCounterComputeKernelInvocations;
				break;
			case 9: // MTLCommonCounter.TotalCycles
				ptr = MTLCommonCounterTotalCycles;
				break;
			case 10: // MTLCommonCounter.VertexCycles
				ptr = MTLCommonCounterVertexCycles;
				break;
			case 11: // MTLCommonCounter.TessellationCycles
				ptr = MTLCommonCounterTessellationCycles;
				break;
			case 12: // MTLCommonCounter.PostTessellationVertexCycles
				ptr = MTLCommonCounterPostTessellationVertexCycles;
				break;
			case 13: // MTLCommonCounter.FragmentCycles
				ptr = MTLCommonCounterFragmentCycles;
				break;
			case 14: // MTLCommonCounter.RenderTargetWriteCycles
				ptr = MTLCommonCounterRenderTargetWriteCycles;
				break;
			case 15: // MTLCommonCounter.SetTimestamp
				ptr = MTLCommonCounterSetTimestamp;
				break;
			case 16: // MTLCommonCounter.SetStageUtilization
				ptr = MTLCommonCounterSetStageUtilization;
				break;
			case 17: // MTLCommonCounter.SetStatistic
				ptr = MTLCommonCounterSetStatistic;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Metal.MTLCommonCounter" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static MTLCommonCounter GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (MTLCommonCounterTimestamp))
				return MTLCommonCounter.Timestamp;
			if (constant.IsEqualTo (MTLCommonCounterTessellationInputPatches))
				return MTLCommonCounter.TessellationInputPatches;
			if (constant.IsEqualTo (MTLCommonCounterVertexInvocations))
				return MTLCommonCounter.VertexInvocations;
			if (constant.IsEqualTo (MTLCommonCounterPostTessellationVertexInvocations))
				return MTLCommonCounter.PostTessellationVertexInvocations;
			if (constant.IsEqualTo (MTLCommonCounterClipperInvocations))
				return MTLCommonCounter.ClipperInvocations;
			if (constant.IsEqualTo (MTLCommonCounterClipperPrimitivesOut))
				return MTLCommonCounter.ClipperPrimitivesOut;
			if (constant.IsEqualTo (MTLCommonCounterFragmentInvocations))
				return MTLCommonCounter.FragmentInvocations;
			if (constant.IsEqualTo (MTLCommonCounterFragmentsPassed))
				return MTLCommonCounter.FragmentsPassed;
			if (constant.IsEqualTo (MTLCommonCounterComputeKernelInvocations))
				return MTLCommonCounter.ComputeKernelInvocations;
			if (constant.IsEqualTo (MTLCommonCounterTotalCycles))
				return MTLCommonCounter.TotalCycles;
			if (constant.IsEqualTo (MTLCommonCounterVertexCycles))
				return MTLCommonCounter.VertexCycles;
			if (constant.IsEqualTo (MTLCommonCounterTessellationCycles))
				return MTLCommonCounter.TessellationCycles;
			if (constant.IsEqualTo (MTLCommonCounterPostTessellationVertexCycles))
				return MTLCommonCounter.PostTessellationVertexCycles;
			if (constant.IsEqualTo (MTLCommonCounterFragmentCycles))
				return MTLCommonCounter.FragmentCycles;
			if (constant.IsEqualTo (MTLCommonCounterRenderTargetWriteCycles))
				return MTLCommonCounter.RenderTargetWriteCycles;
			if (constant.IsEqualTo (MTLCommonCounterSetTimestamp))
				return MTLCommonCounter.SetTimestamp;
			if (constant.IsEqualTo (MTLCommonCounterSetStageUtilization))
				return MTLCommonCounter.SetStageUtilization;
			if (constant.IsEqualTo (MTLCommonCounterSetStatistic))
				return MTLCommonCounter.SetStatistic;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Metal.MTLCommonCounter" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static MTLCommonCounter GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Metal.MTLCommonCounter" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static MTLCommonCounter? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Metal.MTLCommonCounter" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this MTLCommonCounter[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSString?> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (value.GetConstant ());
			}
			return rv.ToArray ();
		}
		/// <summary>Converts an array of <see cref="NSString" /> values into an array of their corresponding enum values.</summary>
		/// <param name="values">The array if <see cref="NSString" /> values to convert.</param>
		internal static MTLCommonCounter[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<MTLCommonCounter> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
