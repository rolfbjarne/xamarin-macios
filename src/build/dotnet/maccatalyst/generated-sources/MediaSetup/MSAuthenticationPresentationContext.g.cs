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
namespace MediaSetup {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MSAuthenticationPresentationContext</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[Protocol (Name = "MSAuthenticationPresentationContext", WrapperType = typeof (MSAuthenticationPresentationContextWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PresentationAnchor", Selector = "presentationAnchor", PropertyType = typeof (UIWindow), GetterSelector = "presentationAnchor", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMSAuthenticationPresentationContext : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("PresentationAnchor")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MSAuthenticationPresentationContextWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMSAuthenticationPresentationContext ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::UIKit.UIWindow? PresentationAnchor {
			[Export ("presentationAnchor")]
			get {
				return _GetPresentationAnchor (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIWindow _GetPresentationAnchor (IMSAuthenticationPresentationContext This)
		{
			global::UIKit.UIWindow ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("presentationAnchor")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MSAuthenticationPresentationContextWrapper : BaseWrapper, IMSAuthenticationPresentationContext {
		public MSAuthenticationPresentationContextWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MSAuthenticationPresentationContextWrapper))]
		static MSAuthenticationPresentationContextWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::UIKit.UIWindow? PresentationAnchor {
			[Export ("presentationAnchor")]
			get {
				global::UIKit.UIWindow ret;
				ret =  Runtime.GetNSObject<global::UIKit.UIWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("presentationAnchor")), false)!;
				return ret;
			}
		}
	}
}
