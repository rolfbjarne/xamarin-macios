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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UIPopoverBackgroundViewMethods</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIPopoverBackgroundViewMethods", WrapperType = typeof (UIPopoverBackgroundViewMethodsWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetArrowHeight", Selector = "arrowHeight", ReturnType = typeof (NFloat))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetArrowBase", Selector = "arrowBase", ReturnType = typeof (NFloat))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetContentViewInsets", Selector = "contentViewInsets", ReturnType = typeof (UIEdgeInsets))]
	public partial interface IUIPopoverBackgroundViewMethods : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("arrowHeight")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetArrowHeight<T> () where T: NSObject, IUIPopoverBackgroundViewMethods
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var class_ptr = Class.GetHandle (typeof (T));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (class_ptr, Selector.GetHandle ("arrowHeight"));
			return ret;
		}
		[global::Foundation.OptionalMember]
		[Export ("arrowBase")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetArrowBase<T> () where T: NSObject, IUIPopoverBackgroundViewMethods
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var class_ptr = Class.GetHandle (typeof (T));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (class_ptr, Selector.GetHandle ("arrowBase"));
			return ret;
		}
		[global::Foundation.OptionalMember]
		[Export ("contentViewInsets")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIEdgeInsets GetContentViewInsets<T> () where T: NSObject, IUIPopoverBackgroundViewMethods
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var class_ptr = Class.GetHandle (typeof (T));
			UIEdgeInsets ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend (class_ptr, Selector.GetHandle ("contentViewInsets"));
			} else {
				ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (class_ptr, Selector.GetHandle ("contentViewInsets"));
			}
			return ret!;
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPopoverBackgroundViewMethodsWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIPopoverBackgroundViewMethods ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIPopoverBackgroundViewMethodsWrapper : BaseWrapper, IUIPopoverBackgroundViewMethods {
		public UIPopoverBackgroundViewMethodsWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPopoverBackgroundViewMethodsWrapper))]
		static UIPopoverBackgroundViewMethodsWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
