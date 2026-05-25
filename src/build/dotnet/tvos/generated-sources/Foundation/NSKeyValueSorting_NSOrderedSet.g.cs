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
namespace Foundation {
	/// <summary>Defines an extension method for <see cref="T:Foundation.NSOrderedSet" /> objects, allowing sorting by <see cref="T:Foundation.NSSortDescriptor" /> objects.</summary><remarks>To be added.</remarks>
	public unsafe static partial class NSKeyValueSorting_NSOrderedSet  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSOrderedSet");
		/// <param name="This">The instance on which this method operates.</param><param name="sortDescriptors">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("sortedArrayUsingDescriptors:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject[] GetSortedArray (this NSOrderedSet This, NSSortDescriptor[] sortDescriptors)
		{
			if (sortDescriptors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sortDescriptors));
			using var nsa_sortDescriptors = NSArray.FromNSObjects (sortDescriptors);
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sortedArrayUsingDescriptors:"), nsa_sortDescriptors.Handle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	} /* class NSKeyValueSorting_NSOrderedSet */
}
