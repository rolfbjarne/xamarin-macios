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
namespace Foundation {
	/// <summary>Helper methods for applying predicates to sets.</summary><remarks>To be added.</remarks>
	public unsafe static partial class NSPredicateSupport_NSSet  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSSet");
		/// <param name="This">The instance on which this method operates.</param><param name="predicate">The predicate used to filter the
		/// 	elements of the set.</param><summary>Returns a new set that contains the elements that
		/// 	match the predicate.</summary><returns>A new immutable set.</returns><remarks></remarks>
		[Export ("filteredSetUsingPredicate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSSet FilterUsingPredicate (this NSSet This, NSPredicate predicate)
		{
			var predicate__handle__ = predicate!.GetNonNullHandle (nameof (predicate));
			NSSet? ret;
			ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("filteredSetUsingPredicate:"), predicate__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (predicate);
			return ret!;
		}
	} /* class NSPredicateSupport_NSSet */
}
