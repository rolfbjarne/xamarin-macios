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
namespace Foundation {
	/// <summary>Extension method for <see cref="T:Foundation.NSArray" /> objects, allowing them to be filtered with a <see cref="T:Foundation.NSPredicate" />.</summary><remarks>To be added.</remarks>
	public unsafe static partial class NSPredicateSupport_NSArray  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilteredArrayUsingPredicate_X = "filteredArrayUsingPredicate:";
		static readonly NativeHandle selFilteredArrayUsingPredicate_XHandle = Selector.GetHandle ("filteredArrayUsingPredicate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSArray");
		/// <param name="This">The instance on which this method operates.</param><param name="array">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("filteredArrayUsingPredicate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSArray FilterUsingPredicate (this NSArray This, NSArray array)
		{
			var array__handle__ = array!.GetNonNullHandle (nameof (array));
			NSArray? ret;
			ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, selFilteredArrayUsingPredicate_XHandle, array__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (array);
			return ret!;
		}
	} /* class NSPredicateSupport_NSArray */
}
