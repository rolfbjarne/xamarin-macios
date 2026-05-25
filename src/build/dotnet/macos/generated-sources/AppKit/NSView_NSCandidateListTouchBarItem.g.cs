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
namespace AppKit {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSView_NSCandidateListTouchBarItem  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCandidateListTouchBarItemX = "candidateListTouchBarItem";
		static readonly NativeHandle selCandidateListTouchBarItemXHandle = Selector.GetHandle ("candidateListTouchBarItem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSView");
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("candidateListTouchBarItem")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCandidateListTouchBarItem GetCandidateListTouchBarItem (this NSView This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSCandidateListTouchBarItem ret;
			ret =  Runtime.GetNSObject<NSCandidateListTouchBarItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, selCandidateListTouchBarItemXHandle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	} /* class NSView_NSCandidateListTouchBarItem */
}
