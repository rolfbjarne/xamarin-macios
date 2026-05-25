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
namespace PdfKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>PDFPageOverlayViewProvider</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("tvos18.2")]
	[Protocol (Name = "PDFPageOverlayViewProvider", WrapperType = typeof (PdfPageOverlayViewProviderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetOverlayView", Selector = "pdfView:overlayViewForPage:", ReturnType = typeof (UIView), ParameterType = new Type [] { typeof (PdfKit.PdfView), typeof (PdfKit.PdfPage) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayOverlayView", Selector = "pdfView:willDisplayOverlayView:forPage:", ParameterType = new Type [] { typeof (PdfKit.PdfView), typeof (UIView), typeof (PdfKit.PdfPage) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEndDisplayingOverlayView", Selector = "pdfView:willEndDisplayingOverlayView:forPage:", ParameterType = new Type [] { typeof (PdfKit.PdfView), typeof (UIView), typeof (PdfKit.PdfPage) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IPdfPageOverlayViewProvider : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("pdfView:overlayViewForPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView? GetOverlayView (PdfView view, PdfPage page)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIView? _GetOverlayView (IPdfPageOverlayViewProvider This, PdfView view, PdfPage page)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			global::UIKit.UIView? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pdfView:overlayViewForPage:"), view__handle__, page__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (page);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("pdfView:willDisplayOverlayView:forPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayOverlayView (PdfView pdfView, global::UIKit.UIView overlayView, PdfPage page)
		{
			_WillDisplayOverlayView (this, pdfView, overlayView, page);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDisplayOverlayView (IPdfPageOverlayViewProvider This, PdfView pdfView, global::UIKit.UIView overlayView, PdfPage page)
		{
			var pdfView__handle__ = pdfView!.GetNonNullHandle (nameof (pdfView));
			var overlayView__handle__ = overlayView!.GetNonNullHandle (nameof (overlayView));
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pdfView:willDisplayOverlayView:forPage:"), pdfView__handle__, overlayView__handle__, page__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pdfView);
			GC.KeepAlive (overlayView);
			GC.KeepAlive (page);
		}
		[global::Foundation.OptionalMember]
		[Export ("pdfView:willEndDisplayingOverlayView:forPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEndDisplayingOverlayView (PdfView pdfView, global::UIKit.UIView overlayView, PdfPage page)
		{
			_WillEndDisplayingOverlayView (this, pdfView, overlayView, page);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillEndDisplayingOverlayView (IPdfPageOverlayViewProvider This, PdfView pdfView, global::UIKit.UIView overlayView, PdfPage page)
		{
			var pdfView__handle__ = pdfView!.GetNonNullHandle (nameof (pdfView));
			var overlayView__handle__ = overlayView!.GetNonNullHandle (nameof (overlayView));
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pdfView:willEndDisplayingOverlayView:forPage:"), pdfView__handle__, overlayView__handle__, page__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pdfView);
			GC.KeepAlive (overlayView);
			GC.KeepAlive (page);
		}
		[DynamicDependencyAttribute ("GetOverlayView(PdfKit.PdfView,PdfKit.PdfPage)")]
		[DynamicDependencyAttribute ("WillDisplayOverlayView(PdfKit.PdfView,UIKit.UIView,PdfKit.PdfPage)")]
		[DynamicDependencyAttribute ("WillEndDisplayingOverlayView(PdfKit.PdfView,UIKit.UIView,PdfKit.PdfPage)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PdfPageOverlayViewProviderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPdfPageOverlayViewProvider ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IPdfPageOverlayViewProvider" /> interface to support all the methods from the PDFPageOverlayViewProvider protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IPdfPageOverlayViewProvider" /> interface allow developers to treat instances of the interface as having all the optional methods of the original PDFPageOverlayViewProvider protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class PdfPageOverlayViewProvider_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDisplayOverlayView (this IPdfPageOverlayViewProvider This, PdfView pdfView, global::UIKit.UIView overlayView, PdfPage page)
		{
			var pdfView__handle__ = pdfView!.GetNonNullHandle (nameof (pdfView));
			var overlayView__handle__ = overlayView!.GetNonNullHandle (nameof (overlayView));
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pdfView:willDisplayOverlayView:forPage:"), pdfView__handle__, overlayView__handle__, page__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pdfView);
			GC.KeepAlive (overlayView);
			GC.KeepAlive (page);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillEndDisplayingOverlayView (this IPdfPageOverlayViewProvider This, PdfView pdfView, global::UIKit.UIView overlayView, PdfPage page)
		{
			var pdfView__handle__ = pdfView!.GetNonNullHandle (nameof (pdfView));
			var overlayView__handle__ = overlayView!.GetNonNullHandle (nameof (overlayView));
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pdfView:willEndDisplayingOverlayView:forPage:"), pdfView__handle__, overlayView__handle__, page__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pdfView);
			GC.KeepAlive (overlayView);
			GC.KeepAlive (page);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PdfPageOverlayViewProviderWrapper : BaseWrapper, IPdfPageOverlayViewProvider {
		public PdfPageOverlayViewProviderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PdfPageOverlayViewProviderWrapper))]
		static PdfPageOverlayViewProviderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("pdfView:overlayViewForPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::UIKit.UIView? GetOverlayView (PdfView view, PdfPage page)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			global::UIKit.UIView? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("pdfView:overlayViewForPage:"), view__handle__, page__handle__), false)!;
			GC.KeepAlive (view);
			GC.KeepAlive (page);
			return ret!;
		}
	}
}
