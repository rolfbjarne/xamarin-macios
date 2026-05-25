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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace HealthKit {
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[UnsupportedOSPlatform ("tvos")]
	public unsafe static partial class HKHealthStore_HKWorkoutRelationship  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("HKHealthStore");
		[Export ("relateWorkoutEffortSample:withWorkout:activity:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RelateWorkoutEffortSample (this HKHealthStore This, HKSample sample, HKWorkout workout, HKWorkoutActivity? activity, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKWorkoutRelationshipCallback))]HKWorkoutRelationshipCallback completion)
		{
			var sample__handle__ = sample!.GetNonNullHandle (nameof (sample));
			var workout__handle__ = workout!.GetNonNullHandle (nameof (workout));
			var activity__handle__ = activity.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDHKWorkoutRelationshipCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("relateWorkoutEffortSample:withWorkout:activity:completion:"), sample__handle__, workout__handle__, activity__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (sample);
			GC.KeepAlive (workout);
			GC.KeepAlive (activity);
		}
		[Export ("unrelateWorkoutEffortSample:fromWorkout:activity:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void UnrelateWorkoutEffortSample (this HKHealthStore This, HKSample sample, HKWorkout workout, HKWorkoutActivity? activity, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDHKWorkoutRelationshipCallback))]HKWorkoutRelationshipCallback completion)
		{
			var sample__handle__ = sample!.GetNonNullHandle (nameof (sample));
			var workout__handle__ = workout!.GetNonNullHandle (nameof (workout));
			var activity__handle__ = activity.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDHKWorkoutRelationshipCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("unrelateWorkoutEffortSample:fromWorkout:activity:completion:"), sample__handle__, workout__handle__, activity__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (sample);
			GC.KeepAlive (workout);
			GC.KeepAlive (activity);
		}
	} /* class HKHealthStore_HKWorkoutRelationship */
}
