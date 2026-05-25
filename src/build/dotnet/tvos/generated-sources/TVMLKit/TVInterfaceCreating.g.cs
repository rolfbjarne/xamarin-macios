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
namespace TVMLKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>TVInterfaceCreating</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[ObsoletedOSPlatform ("tvos18.0", "Use SwiftUI or UIKit instead.")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "TVInterfaceCreating", WrapperType = typeof (TVInterfaceCreatingWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetViewForElement", Selector = "viewForElement:existingView:", ReturnType = typeof (UIView), ParameterType = new Type [] { typeof (TVMLKit.TVViewElement), typeof (UIView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetViewControllerForElement", Selector = "viewControllerForElement:existingViewController:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (TVMLKit.TVViewElement), typeof (UIViewController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetUrlForResource", Selector = "URLForResource:", ReturnType = typeof (NSUrl), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetImageForResource", Selector = "imageForResource:", ReturnType = typeof (UIImage), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCollectionViewCellClass", Selector = "collectionViewCellClassForElement:", ReturnType = typeof (Class), ParameterType = new Type [] { typeof (TVMLKit.TVViewElement) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPlayerViewController", Selector = "playerViewControllerForPlayer:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (TVMLKit.TVPlayer) }, ParameterByRef = new bool [] { false })]
	public partial interface ITVInterfaceCreating : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("viewForElement:existingView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView? GetViewForElement (TVViewElement element, global::UIKit.UIView? existingView)
		{
			return _GetViewForElement (this, element, existingView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIView? _GetViewForElement (ITVInterfaceCreating This, TVViewElement element, global::UIKit.UIView? existingView)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			var existingView__handle__ = existingView.GetHandle ();
			global::UIKit.UIView? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("viewForElement:existingView:"), element__handle__, existingView__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (element);
			GC.KeepAlive (existingView);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("viewControllerForElement:existingViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIViewController? GetViewControllerForElement (TVViewElement element, global::UIKit.UIViewController? existingViewController)
		{
			return _GetViewControllerForElement (this, element, existingViewController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIViewController? _GetViewControllerForElement (ITVInterfaceCreating This, TVViewElement element, global::UIKit.UIViewController? existingViewController)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			var existingViewController__handle__ = existingViewController.GetHandle ();
			global::UIKit.UIViewController? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("viewControllerForElement:existingViewController:"), element__handle__, existingViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (element);
			GC.KeepAlive (existingViewController);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("URLForResource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? GetUrlForResource (string resourceName)
		{
			return _GetUrlForResource (this, resourceName);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSUrl? _GetUrlForResource (ITVInterfaceCreating This, string resourceName)
		{
			if (resourceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resourceName));
			var nsresourceName = CFString.CreateNative (resourceName);
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("URLForResource:"), nsresourceName), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsresourceName);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("imageForResource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImage? GetImageForResource (string resourceName)
		{
			return _GetImageForResource (this, resourceName);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIImage? _GetImageForResource (ITVInterfaceCreating This, string resourceName)
		{
			if (resourceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resourceName));
			var nsresourceName = CFString.CreateNative (resourceName);
			global::UIKit.UIImage? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("imageForResource:"), nsresourceName), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsresourceName);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("collectionViewCellClassForElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Class? GetCollectionViewCellClass (TVViewElement element)
		{
			return _GetCollectionViewCellClass (this, element);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static Class? _GetCollectionViewCellClass (ITVInterfaceCreating This, TVViewElement element)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			Class? ret;
			ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("collectionViewCellClassForElement:"), element__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (element);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewControllerForPlayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIViewController? GetPlayerViewController (TVPlayer player)
		{
			return _GetPlayerViewController (this, player);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIViewController? _GetPlayerViewController (ITVInterfaceCreating This, TVPlayer player)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			global::UIKit.UIViewController? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewControllerForPlayer:"), player__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetCollectionViewCellClass(TVMLKit.TVViewElement)")]
		[DynamicDependencyAttribute ("GetImageForResource(System.String)")]
		[DynamicDependencyAttribute ("GetPlayerViewController(TVMLKit.TVPlayer)")]
		[DynamicDependencyAttribute ("GetUrlForResource(System.String)")]
		[DynamicDependencyAttribute ("GetViewControllerForElement(TVMLKit.TVViewElement,UIKit.UIViewController)")]
		[DynamicDependencyAttribute ("GetViewForElement(TVMLKit.TVViewElement,UIKit.UIView)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TVInterfaceCreatingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ITVInterfaceCreating ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ITVInterfaceCreating" /> interface to support all the methods from the TVInterfaceCreating protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ITVInterfaceCreating" /> interface allow developers to treat instances of the interface as having all the optional methods of the original TVInterfaceCreating protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class TVInterfaceCreating_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIView? GetViewForElement (this ITVInterfaceCreating This, TVViewElement element, global::UIKit.UIView? existingView)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			var existingView__handle__ = existingView.GetHandle ();
			global::UIKit.UIView? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("viewForElement:existingView:"), element__handle__, existingView__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (element);
			GC.KeepAlive (existingView);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIViewController? GetViewControllerForElement (this ITVInterfaceCreating This, TVViewElement element, global::UIKit.UIViewController? existingViewController)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			var existingViewController__handle__ = existingViewController.GetHandle ();
			global::UIKit.UIViewController? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("viewControllerForElement:existingViewController:"), element__handle__, existingViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (element);
			GC.KeepAlive (existingViewController);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl? GetUrlForResource (this ITVInterfaceCreating This, string resourceName)
		{
			if (resourceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resourceName));
			var nsresourceName = CFString.CreateNative (resourceName);
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("URLForResource:"), nsresourceName), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsresourceName);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIImage? GetImageForResource (this ITVInterfaceCreating This, string resourceName)
		{
			if (resourceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resourceName));
			var nsresourceName = CFString.CreateNative (resourceName);
			global::UIKit.UIImage? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("imageForResource:"), nsresourceName), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsresourceName);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static Class? GetCollectionViewCellClass (this ITVInterfaceCreating This, TVViewElement element)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			Class? ret;
			ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("collectionViewCellClassForElement:"), element__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (element);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIViewController? GetPlayerViewController (this ITVInterfaceCreating This, TVPlayer player)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			global::UIKit.UIViewController? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewControllerForPlayer:"), player__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class TVInterfaceCreatingWrapper : BaseWrapper, ITVInterfaceCreating {
		public TVInterfaceCreatingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TVInterfaceCreatingWrapper))]
		static TVInterfaceCreatingWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
