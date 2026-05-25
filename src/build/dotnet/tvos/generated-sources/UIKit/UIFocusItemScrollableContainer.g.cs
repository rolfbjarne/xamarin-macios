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
	/// <summary>Abstraction for the viewable and and total size of scrollable content.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIFocusItemScrollableContainer", WrapperType = typeof (UIFocusItemScrollableContainerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ContentOffset", Selector = "contentOffset", PropertyType = typeof (CGPoint), GetterSelector = "contentOffset", SetterSelector = "setContentOffset:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ContentSize", Selector = "contentSize", PropertyType = typeof (CGSize), GetterSelector = "contentSize", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "VisibleSize", Selector = "visibleSize", PropertyType = typeof (CGSize), GetterSelector = "visibleSize", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIFocusItemScrollableContainer : INativeObject, IDisposable, 
		UIKit.IUIFocusItemContainer
	{
		[DynamicDependencyAttribute ("ContentOffset")]
		[DynamicDependencyAttribute ("ContentSize")]
		[DynamicDependencyAttribute ("VisibleSize")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIFocusItemScrollableContainerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIFocusItemScrollableContainer ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets or sets the offset into the scrollable content.</summary><value>The offset into the scrollable content.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGPoint ContentOffset {
			[Export ("contentOffset", ArgumentSemantic.Assign)]
			get {
				return _GetContentOffset (this);
			}
			[Export ("setContentOffset:", ArgumentSemantic.Assign)]
			set {
				_SetContentOffset (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _GetContentOffset (IUIFocusItemScrollableContainer This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (This.Handle, Selector.GetHandle ("contentOffset"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetContentOffset (IUIFocusItemScrollableContainer This, CGPoint value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("setContentOffset:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the total size of the scrollable content.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGSize ContentSize {
			[Export ("contentSize")]
			get {
				return _GetContentSize (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _GetContentSize (IUIFocusItemScrollableContainer This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (This.Handle, Selector.GetHandle ("contentSize"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the visible size of the scrollview container.</summary><value>The visible size of the scrollview container.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGSize VisibleSize {
			[Export ("visibleSize")]
			get {
				return _GetVisibleSize (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _GetVisibleSize (IUIFocusItemScrollableContainer This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (This.Handle, Selector.GetHandle ("visibleSize"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIFocusItemScrollableContainerWrapper : BaseWrapper, IUIFocusItemScrollableContainer {
		public UIFocusItemScrollableContainerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIFocusItemScrollableContainerWrapper))]
		static UIFocusItemScrollableContainerWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="rect">The rectangle whose focus items to get.</param><summary>Returns a list of all the child focus items within the specified rectangle.</summary><returns>The list of all the child focus items within the specified rectangle.</returns><remarks>To be added.</remarks>
		[Export ("focusItemsInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIFocusItem[] GetFocusItems (CGRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIFocusItem[] ret;
			ret = CFArray.ArrayFromHandle<IUIFocusItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("focusItemsInRect:"), rect), false)!;
			return ret;
		}
		/// <summary>Gets or sets the offset into the scrollable content.</summary><value>The offset into the scrollable content.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint ContentOffset {
			[Export ("contentOffset", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGPoint ret;
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("contentOffset"));
				return ret;
			}
			[Export ("setContentOffset:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setContentOffset:"), value);
			}
		}
		/// <summary>Gets or sets the total size of the scrollable content.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGSize ContentSize {
			[Export ("contentSize")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGSize ret;
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("contentSize"));
				return ret;
			}
		}
		/// <summary>Gets the visible size of the scrollview container.</summary><value>The visible size of the scrollview container.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGSize VisibleSize {
			[Export ("visibleSize")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGSize ret;
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("visibleSize"));
				return ret;
			}
		}
		/// <summary>Gets the coordinate space implementation.</summary><value>The coordinate space implementation.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public IUICoordinateSpace CoordinateSpace {
			[Export ("coordinateSpace")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUICoordinateSpace ret;
				ret =  Runtime.GetINativeObject<IUICoordinateSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("coordinateSpace")), false)!;
				return ret;
			}
		}
	}
}
