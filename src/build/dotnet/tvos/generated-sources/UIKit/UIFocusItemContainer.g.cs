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
	/// <summary>Manages spatial information for focus items in a focus environment.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIFocusItemContainer", WrapperType = typeof (UIFocusItemContainerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetFocusItems", Selector = "focusItemsInRect:", ReturnType = typeof (IUIFocusItem[]), ParameterType = new Type [] { typeof (CGRect) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CoordinateSpace", Selector = "coordinateSpace", PropertyType = typeof (IUICoordinateSpace), GetterSelector = "coordinateSpace", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIFocusItemContainer : INativeObject, IDisposable
	{
		/// <param name="rect">The rectangle whose focus items to get.</param><summary>Returns a list of all the child focus items within the specified rectangle.</summary><returns>The list of all the child focus items within the specified rectangle.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("focusItemsInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIFocusItem[] GetFocusItems (CGRect rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="rect">The rectangle whose focus items to get.</param><summary>Returns a list of all the child focus items within the specified rectangle.</summary><returns>The list of all the child focus items within the specified rectangle.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIFocusItem[] _GetFocusItems (IUIFocusItemContainer This, CGRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIFocusItem[] ret;
			ret = CFArray.ArrayFromHandle<IUIFocusItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (This.Handle, Selector.GetHandle ("focusItemsInRect:"), rect), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("CoordinateSpace")]
		[DynamicDependencyAttribute ("GetFocusItems(CoreGraphics.CGRect)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIFocusItemContainerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIFocusItemContainer ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the coordinate space implementation.</summary><value>The coordinate space implementation.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IUICoordinateSpace CoordinateSpace {
			[Export ("coordinateSpace")]
			get {
				return _GetCoordinateSpace (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUICoordinateSpace _GetCoordinateSpace (IUIFocusItemContainer This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUICoordinateSpace ret;
			ret =  Runtime.GetINativeObject<IUICoordinateSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("coordinateSpace")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIFocusItemContainerWrapper : BaseWrapper, IUIFocusItemContainer {
		public UIFocusItemContainerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIFocusItemContainerWrapper))]
		static UIFocusItemContainerWrapper ()
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
		/// <summary>Gets the coordinate space implementation.</summary><value>The coordinate space implementation.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUICoordinateSpace CoordinateSpace {
			[Export ("coordinateSpace")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUICoordinateSpace ret;
				ret =  Runtime.GetINativeObject<IUICoordinateSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("coordinateSpace")), false)!;
				return ret;
			}
		}
	}
}
