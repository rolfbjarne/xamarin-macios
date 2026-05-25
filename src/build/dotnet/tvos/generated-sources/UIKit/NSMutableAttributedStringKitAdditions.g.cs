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
namespace UIKit {
	/// <summary>Provides an extension method for <see cref="T:Foundation.NSMutableAttributedString" /> that cleans up inconsistencies that develop after several edits.</summary><remarks>To be added.</remarks><altmember cref="T:Foundation.NSMutableAttributedString" />
	public unsafe static partial class NSMutableAttributedStringKitAdditions  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSMutableAttributedString");
		/// <param name="This">The instance on which this method operates.</param><param name="range">To be added.</param><summary>Cleans up inconsistencies that can accumulate over many edits.</summary><remarks><para>After edits, <see cref="T:Foundation.NSMutableAttributedString" />s may accumulate inconsistencies. For instance, paragraph styles must apply to entire paragraphs, scripts may be assigned to fonts that support them, and deleting attachment characters requires the corresponding attachment objects to be released. This method performs necessary cleanup.</para></remarks>
		[Export ("fixAttributesInRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FixAttributesInRange (this NSMutableAttributedString This, NSRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("fixAttributesInRange:"), range);
			GC.KeepAlive (This);
		}
	} /* class NSMutableAttributedStringKitAdditions */
}
