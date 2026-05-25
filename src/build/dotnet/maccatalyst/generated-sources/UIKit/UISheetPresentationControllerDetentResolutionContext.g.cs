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
	/// <summary>This interface represents the Objective-C protocol <c>UISheetPresentationControllerDetentResolutionContext</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[Protocol (Name = "UISheetPresentationControllerDetentResolutionContext", WrapperType = typeof (UISheetPresentationControllerDetentResolutionContextWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ContainerTraitCollection", Selector = "containerTraitCollection", PropertyType = typeof (UITraitCollection), GetterSelector = "containerTraitCollection", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaximumDetentValue", Selector = "maximumDetentValue", PropertyType = typeof (NFloat), GetterSelector = "maximumDetentValue", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUISheetPresentationControllerDetentResolutionContext : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("ContainerTraitCollection")]
		[DynamicDependencyAttribute ("MaximumDetentValue")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISheetPresentationControllerDetentResolutionContextWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUISheetPresentationControllerDetentResolutionContext ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UITraitCollection ContainerTraitCollection {
			[Export ("containerTraitCollection")]
			get {
				return _GetContainerTraitCollection (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITraitCollection _GetContainerTraitCollection (IUISheetPresentationControllerDetentResolutionContext This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("containerTraitCollection")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nfloat MaximumDetentValue {
			[Export ("maximumDetentValue")]
			get {
				return _GetMaximumDetentValue (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetMaximumDetentValue (IUISheetPresentationControllerDetentResolutionContext This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("maximumDetentValue"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UISheetPresentationControllerDetentResolutionContextWrapper : BaseWrapper, IUISheetPresentationControllerDetentResolutionContext {
		public UISheetPresentationControllerDetentResolutionContextWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISheetPresentationControllerDetentResolutionContextWrapper))]
		static UISheetPresentationControllerDetentResolutionContextWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITraitCollection ContainerTraitCollection {
			[Export ("containerTraitCollection")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITraitCollection ret;
				ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("containerTraitCollection")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nfloat MaximumDetentValue {
			[Export ("maximumDetentValue")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("maximumDetentValue"));
				return ret;
			}
		}
	}
}
