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
	/// <summary>Interface for text controls to respond to paste operations.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UITextPasteConfigurationSupporting", WrapperType = typeof (UITextPasteConfigurationSupportingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PasteDelegate", Selector = "pasteDelegate", PropertyType = typeof (IUITextPasteDelegate), GetterSelector = "pasteDelegate", SetterSelector = "setPasteDelegate:", ArgumentSemantic = ArgumentSemantic.Weak)]
	public partial interface IUITextPasteConfigurationSupporting : INativeObject, IDisposable, 
		UIKit.IUIPasteConfigurationSupporting
	{
		[DynamicDependencyAttribute ("PasteDelegate")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextPasteConfigurationSupportingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextPasteConfigurationSupporting ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the delegate for handling text pasting and text drops.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IUITextPasteDelegate? PasteDelegate {
			[Export ("pasteDelegate", ArgumentSemantic.Weak)]
			get {
				return _GetPasteDelegate (this);
			}
			[Export ("setPasteDelegate:", ArgumentSemantic.Weak)]
			set {
				_SetPasteDelegate (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUITextPasteDelegate _GetPasteDelegate (IUITextPasteConfigurationSupporting This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUITextPasteDelegate ret;
			ret =  Runtime.GetINativeObject<IUITextPasteDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("pasteDelegate")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetPasteDelegate (IUITextPasteConfigurationSupporting This, IUITextPasteDelegate? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setPasteDelegate:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextPasteConfigurationSupportingWrapper : BaseWrapper, IUITextPasteConfigurationSupporting {
		public UITextPasteConfigurationSupportingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextPasteConfigurationSupportingWrapper))]
		static UITextPasteConfigurationSupportingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the delegate for handling text pasting and text drops.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUITextPasteDelegate? PasteDelegate {
			[Export ("pasteDelegate", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUITextPasteDelegate ret;
				ret =  Runtime.GetINativeObject<IUITextPasteDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pasteDelegate")), false)!;
				return ret;
			}
			[Export ("setPasteDelegate:", ArgumentSemantic.Weak)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPasteDelegate:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>The <see cref="T:UIKit.UIPasteConfiguration" /> supported by <see langword="this" /> object.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public UIPasteConfiguration? PasteConfiguration {
			[Export ("pasteConfiguration", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIPasteConfiguration ret;
				ret =  Runtime.GetNSObject<UIPasteConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pasteConfiguration")), false)!;
				return ret;
			}
			[Export ("setPasteConfiguration:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPasteConfiguration:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
	}
}
