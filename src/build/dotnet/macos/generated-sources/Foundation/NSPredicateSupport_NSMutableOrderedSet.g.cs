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
	/// <summary>Defines an extension method for <see cref="T:Foundation.NSMutableOrderedSet" /> objects allowing them to be filtered using a <see cref="T:Foundation.NSPredicate" />.</summary><remarks>To be added.</remarks>
	public unsafe static partial class NSPredicateSupport_NSMutableOrderedSet  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterUsingPredicate_X = "filterUsingPredicate:";
		static readonly NativeHandle selFilterUsingPredicate_XHandle = Selector.GetHandle ("filterUsingPredicate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSMutableOrderedSet");
		/// <param name="This">The instance on which this method operates.</param><param name="p">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("filterUsingPredicate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FilterUsingPredicate (this NSMutableOrderedSet This, NSPredicate p)
		{
			var p__handle__ = p!.GetNonNullHandle (nameof (p));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selFilterUsingPredicate_XHandle, p__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (p);
		}
	} /* class NSPredicateSupport_NSMutableOrderedSet */
}
