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
namespace CarPlay {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CPPlayableItem</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios26.4")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "CPPlayableItem", WrapperType = typeof (CPPlayableItemWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PlaybackConfiguration", Selector = "playbackConfiguration", PropertyType = typeof (CarPlay.CPPlaybackConfiguration), GetterSelector = "playbackConfiguration", SetterSelector = "setPlaybackConfiguration:", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface ICPPlayableItem : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("PlaybackConfiguration")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPPlayableItemWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICPPlayableItem ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CPPlaybackConfiguration PlaybackConfiguration {
			[Export ("playbackConfiguration", ArgumentSemantic.Copy)]
			get {
				return _GetPlaybackConfiguration (this);
			}
			[Export ("setPlaybackConfiguration:", ArgumentSemantic.Copy)]
			set {
				_SetPlaybackConfiguration (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CPPlaybackConfiguration _GetPlaybackConfiguration (ICPPlayableItem This)
		{
			CPPlaybackConfiguration ret;
			ret =  Runtime.GetNSObject<CPPlaybackConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("playbackConfiguration")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetPlaybackConfiguration (ICPPlayableItem This, CPPlaybackConfiguration value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setPlaybackConfiguration:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CPPlayableItemWrapper : BaseWrapper, ICPPlayableItem {
		public CPPlayableItemWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPPlayableItemWrapper))]
		static CPPlayableItemWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CPPlaybackConfiguration PlaybackConfiguration {
			[Export ("playbackConfiguration", ArgumentSemantic.Copy)]
			get {
				CPPlaybackConfiguration ret;
				ret =  Runtime.GetNSObject<CPPlaybackConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("playbackConfiguration")), false)!;
				return ret;
			}
			[Export ("setPlaybackConfiguration:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPlaybackConfiguration:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
	}
}
