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
	/// <summary>Helper metohds for applying predicates to mutable arrays.</summary><remarks></remarks>
	public unsafe static partial class NSPredicateSupport_NSMutableArray  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterUsingPredicate_X = "filterUsingPredicate:";
		static readonly NativeHandle selFilterUsingPredicate_XHandle = Selector.GetHandle ("filterUsingPredicate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSMutableArray");
		/// <param name="This">The instance on which this method operates.</param><param name="predicate">The predicate used to filter the
		/// 	elements of the array.</param><summary>Filters the element of the array in place, by keeping
		/// 	only the elements that match.</summary><remarks></remarks>
		[Export ("filterUsingPredicate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FilterUsingPredicate (this NSMutableArray This, NSPredicate predicate)
		{
			var predicate__handle__ = predicate!.GetNonNullHandle (nameof (predicate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selFilterUsingPredicate_XHandle, predicate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (predicate);
		}
	} /* class NSPredicateSupport_NSMutableArray */
}
