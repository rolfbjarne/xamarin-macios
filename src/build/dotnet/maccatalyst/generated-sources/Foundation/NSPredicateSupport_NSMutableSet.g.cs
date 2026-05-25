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
namespace Foundation {
	/// <summary>Extension method for <see cref="T:Foundation.NSMutableSet" /> objects, allowing them to be filtered with a <see cref="T:Foundation.NSPredicate" />.</summary><remarks>To be added.</remarks>
	public unsafe static partial class NSPredicateSupport_NSMutableSet  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSMutableSet");
		/// <param name="This">The instance on which this method operates.</param><param name="predicate">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("filterUsingPredicate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FilterUsingPredicate (this NSMutableSet This, NSPredicate predicate)
		{
			var predicate__handle__ = predicate!.GetNonNullHandle (nameof (predicate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("filterUsingPredicate:"), predicate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (predicate);
		}
	} /* class NSPredicateSupport_NSMutableSet */
}
