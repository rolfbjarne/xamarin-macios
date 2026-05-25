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
	#pragma warning disable CS1573
	/// <summary>Interface defining the support for an accessibility identifier.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIAccessibilityIdentification", WrapperType = typeof (UIAccessibilityIdentificationWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityIdentifier", Selector = "accessibilityIdentifier", PropertyType = typeof (string), GetterSelector = "accessibilityIdentifier", SetterSelector = "setAccessibilityIdentifier:", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface IUIAccessibilityIdentification : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("AccessibilityIdentifier")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIAccessibilityIdentificationWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIAccessibilityIdentification ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Uniquely identifies <c>this</c> for the purposes of accessibility.</summary><value><see langword="string" /> uniquely identifying <c>this</c> for the purposes of accessibility.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? AccessibilityIdentifier {
			[Export ("accessibilityIdentifier", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityIdentifier (this);
			}
			[Export ("setAccessibilityIdentifier:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityIdentifier (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityIdentifier (IUIAccessibilityIdentification This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityIdentifier")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityIdentifier (IUIAccessibilityIdentification This, string? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityIdentifier:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIAccessibilityIdentificationWrapper : BaseWrapper, IUIAccessibilityIdentification {
		public UIAccessibilityIdentificationWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIAccessibilityIdentificationWrapper))]
		static UIAccessibilityIdentificationWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Uniquely identifies <c>this</c> for the purposes of accessibility.</summary><value><see langword="string" /> uniquely identifying <c>this</c> for the purposes of accessibility.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? AccessibilityIdentifier {
			[Export ("accessibilityIdentifier", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityIdentifier")), false)!;
				return ret;
			}
			[Export ("setAccessibilityIdentifier:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityIdentifier:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
	}
}
