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
	/// <summary>Defines methods for images that can scale in reaction to accessibility requirements.</summary><remarks>To be added.</remarks>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIAccessibilityContentSizeCategoryImageAdjusting", WrapperType = typeof (UIAccessibilityContentSizeCategoryImageAdjustingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AdjustsImageSizeForAccessibilityContentSizeCategory", Selector = "adjustsImageSizeForAccessibilityContentSizeCategory", PropertyType = typeof (bool), GetterSelector = "adjustsImageSizeForAccessibilityContentSizeCategory", SetterSelector = "setAdjustsImageSizeForAccessibilityContentSizeCategory:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIAccessibilityContentSizeCategoryImageAdjusting : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("AdjustsImageSizeForAccessibilityContentSizeCategory")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIAccessibilityContentSizeCategoryImageAdjustingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIAccessibilityContentSizeCategoryImageAdjusting ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Returns <see langword="true" /> if the image can adjust size in reaction to accessibility requirements.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AdjustsImageSizeForAccessibilityContentSizeCategory {
			[Export ("adjustsImageSizeForAccessibilityContentSizeCategory")]
			get {
				return _GetAdjustsImageSizeForAccessibilityContentSizeCategory (this);
			}
			[Export ("setAdjustsImageSizeForAccessibilityContentSizeCategory:")]
			set {
				_SetAdjustsImageSizeForAccessibilityContentSizeCategory (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAdjustsImageSizeForAccessibilityContentSizeCategory (IUIAccessibilityContentSizeCategoryImageAdjusting This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("adjustsImageSizeForAccessibilityContentSizeCategory"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAdjustsImageSizeForAccessibilityContentSizeCategory (IUIAccessibilityContentSizeCategoryImageAdjusting This, bool value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAdjustsImageSizeForAccessibilityContentSizeCategory:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIAccessibilityContentSizeCategoryImageAdjustingWrapper : BaseWrapper, IUIAccessibilityContentSizeCategoryImageAdjusting {
		public UIAccessibilityContentSizeCategoryImageAdjustingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIAccessibilityContentSizeCategoryImageAdjustingWrapper))]
		static UIAccessibilityContentSizeCategoryImageAdjustingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Returns <see langword="true" /> if the image can adjust size in reaction to accessibility requirements.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AdjustsImageSizeForAccessibilityContentSizeCategory {
			[Export ("adjustsImageSizeForAccessibilityContentSizeCategory")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("adjustsImageSizeForAccessibilityContentSizeCategory"));
				return ret != 0;
			}
			[Export ("setAdjustsImageSizeForAccessibilityContentSizeCategory:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAdjustsImageSizeForAccessibilityContentSizeCategory:"), value ? (byte) 1 : (byte) 0);
			}
		}
	}
}
