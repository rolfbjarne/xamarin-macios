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
	/// <summary>Defines an extension method for <see cref="T:Foundation.NSOrderedSet" /> objects allowing them to be filtered via an <see cref="T:Foundation.NSPredicate" />.</summary><remarks>To be added.</remarks>
	public unsafe static partial class NSPredicateSupport_NSOrderedSet  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilteredOrderedSetUsingPredicate_X = "filteredOrderedSetUsingPredicate:";
		static readonly NativeHandle selFilteredOrderedSetUsingPredicate_XHandle = Selector.GetHandle ("filteredOrderedSetUsingPredicate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSOrderedSet");
		/// <param name="This">The instance on which this method operates.</param><param name="p">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("filteredOrderedSetUsingPredicate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSOrderedSet FilterUsingPredicate (this NSOrderedSet This, NSPredicate p)
		{
			var p__handle__ = p!.GetNonNullHandle (nameof (p));
			NSOrderedSet? ret;
			ret =  Runtime.GetNSObject<NSOrderedSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, selFilteredOrderedSetUsingPredicate_XHandle, p__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (p);
			return ret!;
		}
	} /* class NSPredicateSupport_NSOrderedSet */
}
