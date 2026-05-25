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
namespace WebKit {
	#pragma warning disable CS1573
	/// <summary>Interface that provides access to the properties of the preview action item for a web view.</summary>
	[UnsupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("ios13.0", "Use 'TBD' instead.")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'TBD' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "WKPreviewActionItem", WrapperType = typeof (WKPreviewActionItemWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Identifier", Selector = "identifier", PropertyType = typeof (NSString), GetterSelector = "identifier", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface IWKPreviewActionItem : INativeObject, IDisposable, 
		UIKit.IUIPreviewActionItem
	{
		[DynamicDependencyAttribute ("Identifier")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKPreviewActionItemWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IWKPreviewActionItem ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the unique identifier of the preview action type.</summary><value>The unique identifier of the preview action type.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSString Identifier {
			[Export ("identifier", ArgumentSemantic.Copy)]
			get {
				return _GetIdentifier (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSString _GetIdentifier (IWKPreviewActionItem This)
		{
			NSString ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("identifier")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class WKPreviewActionItemWrapper : BaseWrapper, IWKPreviewActionItem {
		public WKPreviewActionItemWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKPreviewActionItemWrapper))]
		static WKPreviewActionItemWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the unique identifier of the preview action type.</summary><value>The unique identifier of the preview action type.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSString Identifier {
			[Export ("identifier", ArgumentSemantic.Copy)]
			get {
				NSString ret;
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("identifier")), false)!;
				return ret;
			}
		}
		/// <summary>Gets or sets the title of the preview action.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'TBD' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'TBD' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		public string Title {
			[Export ("title")]
			[UnsupportedOSPlatform ("macos")]
			[ObsoletedOSPlatform ("ios13.0", "Use 'TBD' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'TBD' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("title")), false)!;
				return ret;
			}
		}
	}
}
