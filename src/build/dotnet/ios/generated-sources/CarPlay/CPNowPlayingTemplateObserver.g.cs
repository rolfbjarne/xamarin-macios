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
	/// <summary>This interface represents the Objective-C protocol <c>CPNowPlayingTemplateObserver</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[Protocol (Name = "CPNowPlayingTemplateObserver", WrapperType = typeof (CPNowPlayingTemplateObserverWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpNextButtonTapped", Selector = "nowPlayingTemplateUpNextButtonTapped:", ParameterType = new Type [] { typeof (CarPlay.CPNowPlayingTemplate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AlbumArtistButtonTapped", Selector = "nowPlayingTemplateAlbumArtistButtonTapped:", ParameterType = new Type [] { typeof (CarPlay.CPNowPlayingTemplate) }, ParameterByRef = new bool [] { false })]
	public partial interface ICPNowPlayingTemplateObserver : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("nowPlayingTemplateUpNextButtonTapped:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpNextButtonTapped (CPNowPlayingTemplate nowPlayingTemplate)
		{
			_UpNextButtonTapped (this, nowPlayingTemplate);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpNextButtonTapped (ICPNowPlayingTemplateObserver This, CPNowPlayingTemplate nowPlayingTemplate)
		{
			var nowPlayingTemplate__handle__ = nowPlayingTemplate!.GetNonNullHandle (nameof (nowPlayingTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("nowPlayingTemplateUpNextButtonTapped:"), nowPlayingTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (nowPlayingTemplate);
		}
		[global::Foundation.OptionalMember]
		[Export ("nowPlayingTemplateAlbumArtistButtonTapped:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AlbumArtistButtonTapped (CPNowPlayingTemplate nowPlayingTemplate)
		{
			_AlbumArtistButtonTapped (this, nowPlayingTemplate);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AlbumArtistButtonTapped (ICPNowPlayingTemplateObserver This, CPNowPlayingTemplate nowPlayingTemplate)
		{
			var nowPlayingTemplate__handle__ = nowPlayingTemplate!.GetNonNullHandle (nameof (nowPlayingTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("nowPlayingTemplateAlbumArtistButtonTapped:"), nowPlayingTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (nowPlayingTemplate);
		}
		[DynamicDependencyAttribute ("AlbumArtistButtonTapped(CarPlay.CPNowPlayingTemplate)")]
		[DynamicDependencyAttribute ("UpNextButtonTapped(CarPlay.CPNowPlayingTemplate)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPNowPlayingTemplateObserverWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICPNowPlayingTemplateObserver ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICPNowPlayingTemplateObserver" /> interface to support all the methods from the CPNowPlayingTemplateObserver protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICPNowPlayingTemplateObserver" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CPNowPlayingTemplateObserver protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CPNowPlayingTemplateObserver_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpNextButtonTapped (this ICPNowPlayingTemplateObserver This, CPNowPlayingTemplate nowPlayingTemplate)
		{
			var nowPlayingTemplate__handle__ = nowPlayingTemplate!.GetNonNullHandle (nameof (nowPlayingTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("nowPlayingTemplateUpNextButtonTapped:"), nowPlayingTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (nowPlayingTemplate);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AlbumArtistButtonTapped (this ICPNowPlayingTemplateObserver This, CPNowPlayingTemplate nowPlayingTemplate)
		{
			var nowPlayingTemplate__handle__ = nowPlayingTemplate!.GetNonNullHandle (nameof (nowPlayingTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("nowPlayingTemplateAlbumArtistButtonTapped:"), nowPlayingTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (nowPlayingTemplate);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CPNowPlayingTemplateObserverWrapper : BaseWrapper, ICPNowPlayingTemplateObserver {
		public CPNowPlayingTemplateObserverWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPNowPlayingTemplateObserverWrapper))]
		static CPNowPlayingTemplateObserverWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
