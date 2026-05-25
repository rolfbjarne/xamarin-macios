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
	/// <summary>This interface represents the Objective-C protocol <c>UITextSelectionHandleView</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[Protocol (Name = "UITextSelectionHandleView", WrapperType = typeof (UITextSelectionHandleViewWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPreferredFrame", Selector = "preferredFrameForRect:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (CGRect) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Direction", Selector = "direction", PropertyType = typeof (NSDirectionalRectEdge), GetterSelector = "direction", SetterSelector = "setDirection:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Vertical", Selector = "vertical", PropertyType = typeof (bool), GetterSelector = "isVertical", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CustomShape", Selector = "customShape", PropertyType = typeof (UIBezierPath), GetterSelector = "customShape", SetterSelector = "setCustomShape:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IUITextSelectionHandleView : INativeObject, IDisposable, 
		UIKit.IUICoordinateSpace
	{
		[global::Foundation.RequiredMember]
		[Export ("preferredFrameForRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetPreferredFrame (CGRect rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetPreferredFrame (IUITextSelectionHandleView This, CGRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect (This.Handle, Selector.GetHandle ("preferredFrameForRect:"), rect);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect (This.Handle, Selector.GetHandle ("preferredFrameForRect:"), rect);
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[DynamicDependencyAttribute ("CustomShape")]
		[DynamicDependencyAttribute ("Direction")]
		[DynamicDependencyAttribute ("GetPreferredFrame(CoreGraphics.CGRect)")]
		[DynamicDependencyAttribute ("Vertical")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextSelectionHandleViewWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextSelectionHandleView ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSDirectionalRectEdge Direction {
			[Export ("direction", ArgumentSemantic.Assign)]
			get {
				return _GetDirection (this);
			}
			[Export ("setDirection:", ArgumentSemantic.Assign)]
			set {
				_SetDirection (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDirectionalRectEdge _GetDirection (IUITextSelectionHandleView This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSDirectionalRectEdge ret;
			ret = (NSDirectionalRectEdge) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("direction"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDirection (IUITextSelectionHandleView This, NSDirectionalRectEdge value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setDirection:"), (UIntPtr) (ulong) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool Vertical {
			[Export ("isVertical")]
			get {
				return _GetVertical (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetVertical (IUITextSelectionHandleView This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isVertical"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIBezierPath? CustomShape {
			[Export ("customShape", ArgumentSemantic.Retain)]
			get {
				return _GetCustomShape (this);
			}
			[Export ("setCustomShape:", ArgumentSemantic.Retain)]
			set {
				_SetCustomShape (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIBezierPath _GetCustomShape (IUITextSelectionHandleView This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIBezierPath ret;
			ret =  Runtime.GetNSObject<UIBezierPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("customShape")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetCustomShape (IUITextSelectionHandleView This, UIBezierPath? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setCustomShape:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextSelectionHandleViewWrapper : BaseWrapper, IUITextSelectionHandleView {
		public UITextSelectionHandleViewWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextSelectionHandleViewWrapper))]
		static UITextSelectionHandleViewWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("preferredFrameForRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetPreferredFrame (CGRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("preferredFrameForRect:"), rect);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect (this.Handle, Selector.GetHandle ("preferredFrameForRect:"), rect);
			}
			return ret!;
		}
		/// <param name="point">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertPoint:toCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint ConvertPointToCoordinateSpace (CGPoint point, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("convertPoint:toCoordinateSpace:"), point, coordinateSpace__handle__);
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		/// <param name="point">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertPoint:fromCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint ConvertPointFromCoordinateSpace (CGPoint point, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("convertPoint:fromCoordinateSpace:"), point, coordinateSpace__handle__);
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		/// <param name="rect">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertRect:toCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect ConvertRectToCoordinateSpace (CGRect rect, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:toCoordinateSpace:"), rect, coordinateSpace__handle__);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:toCoordinateSpace:"), rect, coordinateSpace__handle__);
			}
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		/// <param name="rect">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertRect:fromCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect ConvertRectFromCoordinateSpace (CGRect rect, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:fromCoordinateSpace:"), rect, coordinateSpace__handle__);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:fromCoordinateSpace:"), rect, coordinateSpace__handle__);
			}
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDirectionalRectEdge Direction {
			[Export ("direction", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDirectionalRectEdge ret;
				ret = (NSDirectionalRectEdge) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("direction"));
				return ret!;
			}
			[Export ("setDirection:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setDirection:"), (UIntPtr) (ulong) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Vertical {
			[Export ("isVertical")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isVertical"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIBezierPath? CustomShape {
			[Export ("customShape", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIBezierPath ret;
				ret =  Runtime.GetNSObject<UIBezierPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("customShape")), false)!;
				return ret;
			}
			[Export ("setCustomShape:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCustomShape:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets the bounding rectangle of the object in its own coordinate space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public CGRect Bounds {
			[Export ("bounds")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGRect ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("bounds"));
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("bounds"));
				}
				return ret!;
			}
		}
	}
}
