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
	/// <summary>This interface represents the Objective-C protocol <c>UIPopoverPresentationControllerSourceItem</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[UnsupportedOSPlatform ("macos")]
	[Protocol (Name = "UIPopoverPresentationControllerSourceItem", WrapperType = typeof (UIPopoverPresentationControllerSourceItemWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetFrame", Selector = "frameInView:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (UIView) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIPopoverPresentationControllerSourceItem : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("frameInView:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFrame (UIView referenceView)
		{
			return _GetFrame (this, referenceView);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetFrame (IUIPopoverPresentationControllerSourceItem This, UIView referenceView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var referenceView__handle__ = referenceView!.GetNonNullHandle (nameof (referenceView));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("frameInView:"), referenceView__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("frameInView:"), referenceView__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (referenceView);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetFrame(UIKit.UIView)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPopoverPresentationControllerSourceItemWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIPopoverPresentationControllerSourceItem ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIPopoverPresentationControllerSourceItem" /> interface to support all the methods from the UIPopoverPresentationControllerSourceItem protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIPopoverPresentationControllerSourceItem" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIPopoverPresentationControllerSourceItem protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIPopoverPresentationControllerSourceItem_Extensions {
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect GetFrame (this IUIPopoverPresentationControllerSourceItem This, UIView referenceView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var referenceView__handle__ = referenceView!.GetNonNullHandle (nameof (referenceView));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("frameInView:"), referenceView__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("frameInView:"), referenceView__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (referenceView);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIPopoverPresentationControllerSourceItemWrapper : BaseWrapper, IUIPopoverPresentationControllerSourceItem {
		public UIPopoverPresentationControllerSourceItemWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPopoverPresentationControllerSourceItemWrapper))]
		static UIPopoverPresentationControllerSourceItemWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
