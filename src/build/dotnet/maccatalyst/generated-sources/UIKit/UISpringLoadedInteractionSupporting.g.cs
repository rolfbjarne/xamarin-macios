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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>Interface for controlling whether spring-loading is enabled for drag and drop.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UISpringLoadedInteractionSupporting", WrapperType = typeof (UISpringLoadedInteractionSupportingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SpringLoaded", Selector = "springLoaded", PropertyType = typeof (bool), GetterSelector = "isSpringLoaded", SetterSelector = "setSpringLoaded:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUISpringLoadedInteractionSupporting : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("SpringLoaded")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISpringLoadedInteractionSupportingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUISpringLoadedInteractionSupporting ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets or sets a Boolean value that controls whether the object participates in spring-loaded interactions.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool SpringLoaded {
			[Export ("isSpringLoaded")]
			get {
				return _GetSpringLoaded (this);
			}
			[Export ("setSpringLoaded:")]
			set {
				_SetSpringLoaded (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSpringLoaded (IUISpringLoadedInteractionSupporting This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSpringLoaded"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSpringLoaded (IUISpringLoadedInteractionSupporting This, bool value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setSpringLoaded:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UISpringLoadedInteractionSupportingWrapper : BaseWrapper, IUISpringLoadedInteractionSupporting {
		public UISpringLoadedInteractionSupportingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISpringLoadedInteractionSupportingWrapper))]
		static UISpringLoadedInteractionSupportingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets or sets a Boolean value that controls whether the object participates in spring-loaded interactions.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool SpringLoaded {
			[Export ("isSpringLoaded")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSpringLoaded"));
				return ret != 0;
			}
			[Export ("setSpringLoaded:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSpringLoaded:"), value ? (byte) 1 : (byte) 0);
			}
		}
	}
}
