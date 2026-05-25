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
	/// <summary>Defines a static method for sorting <see cref="T:Foundation.NSMutableArray" /> objects using <see cref="T:Foundation.NSSortDescriptor" /> objects.</summary><remarks>To be added.</remarks>
	public unsafe static partial class NSSortDescriptorSorting_NSMutableArray  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSMutableArray");
		/// <param name="This">The instance on which this method operates.</param><param name="sortDescriptors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("sortUsingDescriptors:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SortUsingDescriptors (this NSMutableArray This, NSSortDescriptor[] sortDescriptors)
		{
			if (sortDescriptors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sortDescriptors));
			using var nsa_sortDescriptors = NSArray.FromNSObjects (sortDescriptors);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sortUsingDescriptors:"), nsa_sortDescriptors.Handle);
			GC.KeepAlive (This);
		}
	} /* class NSSortDescriptorSorting_NSMutableArray */
}
