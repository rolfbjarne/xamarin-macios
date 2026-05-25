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
namespace AVFoundation {
	[SupportedOSPlatform ("ios13.0")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class AVMutableMovieTrack_AVMutableMovieTrackTrackAssociations  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVMutableMovieTrack");
		/// <param name="This">The instance on which this method operates.</param><param name="movieTrack">To be added.</param><param name="trackAssociationType">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("addTrackAssociationToTrack:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddTrackAssociation (this AVMutableMovieTrack This, AVMovieTrack movieTrack, string trackAssociationType)
		{
			var movieTrack__handle__ = movieTrack!.GetNonNullHandle (nameof (movieTrack));
			if (trackAssociationType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (trackAssociationType));
			var nstrackAssociationType = CFString.CreateNative (trackAssociationType);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("addTrackAssociationToTrack:type:"), movieTrack__handle__, nstrackAssociationType);
			GC.KeepAlive (This);
			GC.KeepAlive (movieTrack);
			CFString.ReleaseNative (nstrackAssociationType);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="movieTrack">To be added.</param><param name="trackAssociationType">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeTrackAssociationToTrack:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveTrackAssociation (this AVMutableMovieTrack This, AVMovieTrack movieTrack, string trackAssociationType)
		{
			var movieTrack__handle__ = movieTrack!.GetNonNullHandle (nameof (movieTrack));
			if (trackAssociationType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (trackAssociationType));
			var nstrackAssociationType = CFString.CreateNative (trackAssociationType);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("removeTrackAssociationToTrack:type:"), movieTrack__handle__, nstrackAssociationType);
			GC.KeepAlive (This);
			GC.KeepAlive (movieTrack);
			CFString.ReleaseNative (nstrackAssociationType);
		}
	} /* class AVMutableMovieTrack_AVMutableMovieTrackTrackAssociations */
}
