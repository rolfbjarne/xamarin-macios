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
namespace MapKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MKMapViewDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MKMapViewDelegate", WrapperType = typeof (MKMapViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RegionWillChange", Selector = "mapView:regionWillChangeAnimated:", ParameterType = new Type [] { typeof (MKMapView), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RegionChanged", Selector = "mapView:regionDidChangeAnimated:", ParameterType = new Type [] { typeof (MKMapView), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStartLoadingMap", Selector = "mapViewWillStartLoadingMap:", ParameterType = new Type [] { typeof (MKMapView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapLoaded", Selector = "mapViewDidFinishLoadingMap:", ParameterType = new Type [] { typeof (MKMapView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LoadingMapFailed", Selector = "mapViewDidFailLoadingMap:withError:", ParameterType = new Type [] { typeof (MKMapView), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetViewForAnnotation", Selector = "mapView:viewForAnnotation:", ReturnType = typeof (MKAnnotationView), ParameterType = new Type [] { typeof (MKMapView), typeof (IMKAnnotation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddAnnotationViews", Selector = "mapView:didAddAnnotationViews:", ParameterType = new Type [] { typeof (MKMapView), typeof (MKAnnotationView[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CalloutAccessoryControlTapped", Selector = "mapView:annotationView:calloutAccessoryControlTapped:", ParameterType = new Type [] { typeof (MKMapView), typeof (MKAnnotationView), typeof (UIControl) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChangedDragState", Selector = "mapView:annotationView:didChangeDragState:fromOldState:", ParameterType = new Type [] { typeof (MKMapView), typeof (MKAnnotationView), typeof (MKAnnotationViewDragState), typeof (MKAnnotationViewDragState) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetViewForOverlay", Selector = "mapView:viewForOverlay:", ReturnType = typeof (MKOverlayView), ParameterType = new Type [] { typeof (MKMapView), typeof (IMKOverlay) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddOverlayViews", Selector = "mapView:didAddOverlayViews:", ParameterType = new Type [] { typeof (MKMapView), typeof (MKOverlayView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectAnnotationView", Selector = "mapView:didSelectAnnotationView:", ParameterType = new Type [] { typeof (MKMapView), typeof (MKAnnotationView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToLocateUser", Selector = "mapView:didFailToLocateUserWithError:", ParameterType = new Type [] { typeof (MKMapView), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDeselectAnnotationView", Selector = "mapView:didDeselectAnnotationView:", ParameterType = new Type [] { typeof (MKMapView), typeof (MKAnnotationView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectAnnotation", Selector = "mapView:didSelectAnnotation:", ParameterType = new Type [] { typeof (MKMapView), typeof (IMKAnnotation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDeselectAnnotation", Selector = "mapView:didDeselectAnnotation:", ParameterType = new Type [] { typeof (MKMapView), typeof (IMKAnnotation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStartLocatingUser", Selector = "mapViewWillStartLocatingUser:", ParameterType = new Type [] { typeof (MKMapView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStopLocatingUser", Selector = "mapViewDidStopLocatingUser:", ParameterType = new Type [] { typeof (MKMapView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateUserLocation", Selector = "mapView:didUpdateUserLocation:", ParameterType = new Type [] { typeof (MKMapView), typeof (MKUserLocation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeUserTrackingMode", Selector = "mapView:didChangeUserTrackingMode:animated:", ParameterType = new Type [] { typeof (MKMapView), typeof (MKUserTrackingMode), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OverlayRenderer", Selector = "mapView:rendererForOverlay:", ReturnType = typeof (MKOverlayRenderer), ParameterType = new Type [] { typeof (MKMapView), typeof (IMKOverlay) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddOverlayRenderers", Selector = "mapView:didAddOverlayRenderers:", ParameterType = new Type [] { typeof (MKMapView), typeof (MKOverlayRenderer[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStartRenderingMap", Selector = "mapViewWillStartRenderingMap:", ParameterType = new Type [] { typeof (MKMapView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishRenderingMap", Selector = "mapViewDidFinishRenderingMap:fullyRendered:", ParameterType = new Type [] { typeof (MKMapView), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateClusterAnnotation", Selector = "mapView:clusterAnnotationForMemberAnnotations:", ReturnType = typeof (MKClusterAnnotation), ParameterType = new Type [] { typeof (MKMapView), typeof (IMKAnnotation[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeVisibleRegion", Selector = "mapViewDidChangeVisibleRegion:", ParameterType = new Type [] { typeof (MKMapView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSelectionAccessory", Selector = "mapView:selectionAccessoryForAnnotation:", ReturnType = typeof (MKSelectionAccessory), ParameterType = new Type [] { typeof (MKMapView), typeof (IMKAnnotation) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IMKMapViewDelegate : INativeObject, IDisposable
	{
		/// <param name="mapView">To be added.</param><param name="animated">To be added.</param><summary>Indicates the region displayed by <paramref name="mapView" /> is about to change.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapView:regionWillChangeAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegionWillChange (MKMapView mapView, bool animated)
		{
			_RegionWillChange (this, mapView, animated);
		}
		/// <param name="mapView">To be added.</param><param name="animated">To be added.</param><summary>Indicates the region displayed by <paramref name="mapView" /> is about to change.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RegionWillChange (IMKMapViewDelegate This, MKMapView mapView, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("mapView:regionWillChangeAnimated:"), mapView__handle__, animated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><param name="animated">To be added.</param><summary>Indicates the region displayed by <paramref name="mapView" /> has changed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapView:regionDidChangeAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegionChanged (MKMapView mapView, bool animated)
		{
			_RegionChanged (this, mapView, animated);
		}
		/// <param name="mapView">To be added.</param><param name="animated">To be added.</param><summary>Indicates the region displayed by <paramref name="mapView" /> has changed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RegionChanged (IMKMapViewDelegate This, MKMapView mapView, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("mapView:regionDidChangeAnimated:"), mapView__handle__, animated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><summary>Indicates that loading of map data is about to begin.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapViewWillStartLoadingMap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartLoadingMap (MKMapView mapView)
		{
			_WillStartLoadingMap (this, mapView);
		}
		/// <param name="mapView">To be added.</param><summary>Indicates that loading of map data is about to begin.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillStartLoadingMap (IMKMapViewDelegate This, MKMapView mapView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapViewWillStartLoadingMap:"), mapView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><summary>Indicates that loading of map data has completed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapViewDidFinishLoadingMap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapLoaded (MKMapView mapView)
		{
			_MapLoaded (this, mapView);
		}
		/// <param name="mapView">To be added.</param><summary>Indicates that loading of map data has completed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MapLoaded (IMKMapViewDelegate This, MKMapView mapView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapViewDidFinishLoadingMap:"), mapView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><param name="error">To be added.</param><summary>Indicates an <paramref name="error" /> caused loading to fail.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapViewDidFailLoadingMap:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadingMapFailed (MKMapView mapView, NSError error)
		{
			_LoadingMapFailed (this, mapView, error);
		}
		/// <param name="mapView">To be added.</param><param name="error">To be added.</param><summary>Indicates an <paramref name="error" /> caused loading to fail.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _LoadingMapFailed (IMKMapViewDelegate This, MKMapView mapView, NSError error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapViewDidFailLoadingMap:withError:"), mapView__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (error);
		}
		/// <param name="mapView">To be added.</param><param name="annotation">To be added.</param><summary>Returns the <see cref="T:MapKit.MKAnnotationView" /> associated with the <paramref name="annotation" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapView:viewForAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKAnnotationView? GetViewForAnnotation (MKMapView mapView, IMKAnnotation annotation)
		{
			return _GetViewForAnnotation (this, mapView, annotation);
		}
		/// <param name="mapView">To be added.</param><param name="annotation">To be added.</param><summary>Returns the <see cref="T:MapKit.MKAnnotationView" /> associated with the <paramref name="annotation" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MKAnnotationView? _GetViewForAnnotation (IMKMapViewDelegate This, MKMapView mapView, IMKAnnotation annotation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			MKAnnotationView? ret;
			ret =  Runtime.GetNSObject<MKAnnotationView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:viewForAnnotation:"), mapView__handle__, annotation__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (annotation);
			return ret!;
		}
		/// <param name="mapView">To be added.</param><param name="views">To be added.</param><summary>Called when an annotation view (or views) have been added to <paramref name="mapView" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapView:didAddAnnotationViews:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddAnnotationViews (MKMapView mapView, MKAnnotationView[] views)
		{
			_DidAddAnnotationViews (this, mapView, views);
		}
		/// <param name="mapView">To be added.</param><param name="views">To be added.</param><summary>Called when an annotation view (or views) have been added to <paramref name="mapView" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddAnnotationViews (IMKMapViewDelegate This, MKMapView mapView, MKAnnotationView[] views)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			if (views is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (views));
			using var nsa_views = NSArray.FromNSObjects (views);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:didAddAnnotationViews:"), mapView__handle__, nsa_views.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><param name="view">To be added.</param><param name="control">To be added.</param><summary>Called when the callout accessory <paramref name="control" /> has been tapped.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapView:annotationView:calloutAccessoryControlTapped:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CalloutAccessoryControlTapped (MKMapView mapView, MKAnnotationView view, global::UIKit.UIControl control)
		{
			_CalloutAccessoryControlTapped (this, mapView, view, control);
		}
		/// <param name="mapView">To be added.</param><param name="view">To be added.</param><param name="control">To be added.</param><summary>Called when the callout accessory <paramref name="control" /> has been tapped.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CalloutAccessoryControlTapped (IMKMapViewDelegate This, MKMapView mapView, MKAnnotationView view, global::UIKit.UIControl control)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var control__handle__ = control!.GetNonNullHandle (nameof (control));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:annotationView:calloutAccessoryControlTapped:"), mapView__handle__, view__handle__, control__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (view);
			GC.KeepAlive (control);
		}
		/// <param name="mapView">To be added.</param><param name="annotationView">To be added.</param><param name="newState">To be added.</param><param name="oldState">To be added.</param><summary>Called when the drag state has changed from <paramref name="oldState" /> to <paramref name="newState" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapView:annotationView:didChangeDragState:fromOldState:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangedDragState (MKMapView mapView, MKAnnotationView annotationView, MKAnnotationViewDragState newState, MKAnnotationViewDragState oldState)
		{
			_ChangedDragState (this, mapView, annotationView, newState, oldState);
		}
		/// <param name="mapView">To be added.</param><param name="annotationView">To be added.</param><param name="newState">To be added.</param><param name="oldState">To be added.</param><summary>Called when the drag state has changed from <paramref name="oldState" /> to <paramref name="newState" />.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ChangedDragState (IMKMapViewDelegate This, MKMapView mapView, MKAnnotationView annotationView, MKAnnotationViewDragState newState, MKAnnotationViewDragState oldState)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var annotationView__handle__ = annotationView!.GetNonNullHandle (nameof (annotationView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("mapView:annotationView:didChangeDragState:fromOldState:"), mapView__handle__, annotationView__handle__, (UIntPtr) (ulong) newState, (UIntPtr) (ulong) oldState);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (annotationView);
		}
		/// <param name="mapView">To be added.</param><param name="overlay">To be added.</param><summary>Use MKOverlayRenderer.RendererForOverlay instead</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapView:viewForOverlay:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'MKOverlayRenderer.RendererForOverlay' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'MKOverlayRenderer.RendererForOverlay' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKOverlayView GetViewForOverlay (MKMapView mapView, IMKOverlay overlay)
		{
			return _GetViewForOverlay (this, mapView, overlay);
		}
		/// <param name="mapView">To be added.</param><param name="overlay">To be added.</param><summary>Use MKOverlayRenderer.RendererForOverlay instead</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'MKOverlayRenderer.RendererForOverlay' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'MKOverlayRenderer.RendererForOverlay' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MKOverlayView _GetViewForOverlay (IMKMapViewDelegate This, MKMapView mapView, IMKOverlay overlay)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			MKOverlayView? ret;
			ret =  Runtime.GetNSObject<MKOverlayView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:viewForOverlay:"), mapView__handle__, overlay__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (overlay);
			return ret!;
		}
		/// <param name="mapView">To be added.</param><param name="overlayViews">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidAddOverlayRenderers' instead.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapView:didAddOverlayViews:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'DidAddOverlayRenderers' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidAddOverlayRenderers' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddOverlayViews (MKMapView mapView, MKOverlayView overlayViews)
		{
			_DidAddOverlayViews (this, mapView, overlayViews);
		}
		/// <param name="mapView">To be added.</param><param name="overlayViews">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidAddOverlayRenderers' instead.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'DidAddOverlayRenderers' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidAddOverlayRenderers' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddOverlayViews (IMKMapViewDelegate This, MKMapView mapView, MKOverlayView overlayViews)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var overlayViews__handle__ = overlayViews!.GetNonNullHandle (nameof (overlayViews));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:didAddOverlayViews:"), mapView__handle__, overlayViews__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (overlayViews);
		}
		/// <param name="mapView">To be added.</param><param name="view">To be added.</param><summary>Indicates that the specified <see cref="T:MapKit.MKAnnotationView" /> has been selected.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapView:didSelectAnnotationView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectAnnotationView (MKMapView mapView, MKAnnotationView view)
		{
			_DidSelectAnnotationView (this, mapView, view);
		}
		/// <param name="mapView">To be added.</param><param name="view">To be added.</param><summary>Indicates that the specified <see cref="T:MapKit.MKAnnotationView" /> has been selected.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectAnnotationView (IMKMapViewDelegate This, MKMapView mapView, MKAnnotationView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:didSelectAnnotationView:"), mapView__handle__, view__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (view);
		}
		/// <param name="mapView">To be added.</param><param name="error">To be added.</param><summary>Indicates that the attempt to locate the current user has failed due to <paramref name="error" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapView:didFailToLocateUserWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToLocateUser (MKMapView mapView, NSError error)
		{
			_DidFailToLocateUser (this, mapView, error);
		}
		/// <param name="mapView">To be added.</param><param name="error">To be added.</param><summary>Indicates that the attempt to locate the current user has failed due to <paramref name="error" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailToLocateUser (IMKMapViewDelegate This, MKMapView mapView, NSError error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:didFailToLocateUserWithError:"), mapView__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (error);
		}
		/// <param name="mapView">To be added.</param><param name="view">To be added.</param><summary>Indicates that <paramref name="view" /> has been deselected.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapView:didDeselectAnnotationView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDeselectAnnotationView (MKMapView mapView, MKAnnotationView view)
		{
			_DidDeselectAnnotationView (this, mapView, view);
		}
		/// <param name="mapView">To be added.</param><param name="view">To be added.</param><summary>Indicates that <paramref name="view" /> has been deselected.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDeselectAnnotationView (IMKMapViewDelegate This, MKMapView mapView, MKAnnotationView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:didDeselectAnnotationView:"), mapView__handle__, view__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (view);
		}
		[global::Foundation.OptionalMember]
		[Export ("mapView:didSelectAnnotation:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectAnnotation (MKMapView mapView, IMKAnnotation annotation)
		{
			_DidSelectAnnotation (this, mapView, annotation);
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectAnnotation (IMKMapViewDelegate This, MKMapView mapView, IMKAnnotation annotation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:didSelectAnnotation:"), mapView__handle__, annotation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (annotation);
		}
		[global::Foundation.OptionalMember]
		[Export ("mapView:didDeselectAnnotation:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDeselectAnnotation (MKMapView mapView, IMKAnnotation annotation)
		{
			_DidDeselectAnnotation (this, mapView, annotation);
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDeselectAnnotation (IMKMapViewDelegate This, MKMapView mapView, IMKAnnotation annotation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:didDeselectAnnotation:"), mapView__handle__, annotation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (annotation);
		}
		/// <param name="mapView">To be added.</param><summary>Indicates that the system will start attempting to locate the user.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapViewWillStartLocatingUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartLocatingUser (MKMapView mapView)
		{
			_WillStartLocatingUser (this, mapView);
		}
		/// <param name="mapView">To be added.</param><summary>Indicates that the system will start attempting to locate the user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillStartLocatingUser (IMKMapViewDelegate This, MKMapView mapView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapViewWillStartLocatingUser:"), mapView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><summary>Indicates the system has stopped attemptig to locate the user.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapViewDidStopLocatingUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStopLocatingUser (MKMapView mapView)
		{
			_DidStopLocatingUser (this, mapView);
		}
		/// <param name="mapView">To be added.</param><summary>Indicates the system has stopped attemptig to locate the user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStopLocatingUser (IMKMapViewDelegate This, MKMapView mapView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapViewDidStopLocatingUser:"), mapView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><param name="userLocation">To be added.</param><summary>Indicates the system has provided an update to the user's location.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapView:didUpdateUserLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateUserLocation (MKMapView mapView, MKUserLocation userLocation)
		{
			_DidUpdateUserLocation (this, mapView, userLocation);
		}
		/// <param name="mapView">To be added.</param><param name="userLocation">To be added.</param><summary>Indicates the system has provided an update to the user's location.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateUserLocation (IMKMapViewDelegate This, MKMapView mapView, MKUserLocation userLocation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var userLocation__handle__ = userLocation!.GetNonNullHandle (nameof (userLocation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:didUpdateUserLocation:"), mapView__handle__, userLocation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (userLocation);
		}
		/// <param name="mapView">To be added.</param><param name="mode">To be added.</param><param name="animated">To be added.</param><summary>Indicates a change in the active <see cref="T:MapKit.MKUserTrackingMode" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapView:didChangeUserTrackingMode:animated:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeUserTrackingMode (MKMapView mapView, MKUserTrackingMode mode, bool animated)
		{
			_DidChangeUserTrackingMode (this, mapView, mode, animated);
		}
		/// <param name="mapView">To be added.</param><param name="mode">To be added.</param><param name="animated">To be added.</param><summary>Indicates a change in the active <see cref="T:MapKit.MKUserTrackingMode" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeUserTrackingMode (IMKMapViewDelegate This, MKMapView mapView, MKUserTrackingMode mode, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_bool (This.Handle, Selector.GetHandle ("mapView:didChangeUserTrackingMode:animated:"), mapView__handle__, (UIntPtr) (ulong) mode, animated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">The <see cref="T:MapKit.MKMapView" /> being rendered.</param><param name="overlay">The overlay requiring a renderer.</param><summary>Calculates he <see cref="T:MapKit.MKOverlayRenderer" /> appropriate to the <paramref name="overlay" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapView:rendererForOverlay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKOverlayRenderer OverlayRenderer (MKMapView mapView, IMKOverlay overlay)
		{
			return _OverlayRenderer (this, mapView, overlay);
		}
		/// <param name="mapView">The <see cref="T:MapKit.MKMapView" /> being rendered.</param><param name="overlay">The overlay requiring a renderer.</param><summary>Calculates he <see cref="T:MapKit.MKOverlayRenderer" /> appropriate to the <paramref name="overlay" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MKOverlayRenderer _OverlayRenderer (IMKMapViewDelegate This, MKMapView mapView, IMKOverlay overlay)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			MKOverlayRenderer? ret;
			ret =  Runtime.GetNSObject<MKOverlayRenderer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:rendererForOverlay:"), mapView__handle__, overlay__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (overlay);
			return ret!;
		}
		/// <param name="mapView">To be added.</param><param name="renderers">To be added.</param><summary>Called when an overlay renderer (or renderers) have been added to <paramref name="mapView" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapView:didAddOverlayRenderers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddOverlayRenderers (MKMapView mapView, MKOverlayRenderer[] renderers)
		{
			_DidAddOverlayRenderers (this, mapView, renderers);
		}
		/// <param name="mapView">To be added.</param><param name="renderers">To be added.</param><summary>Called when an overlay renderer (or renderers) have been added to <paramref name="mapView" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddOverlayRenderers (IMKMapViewDelegate This, MKMapView mapView, MKOverlayRenderer[] renderers)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			if (renderers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (renderers));
			using var nsa_renderers = NSArray.FromNSObjects (renderers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:didAddOverlayRenderers:"), mapView__handle__, nsa_renderers.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><summary>Indicates that rendering of <paramref name="mapView" /> is about to begin.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapViewWillStartRenderingMap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartRenderingMap (MKMapView mapView)
		{
			_WillStartRenderingMap (this, mapView);
		}
		/// <param name="mapView">To be added.</param><summary>Indicates that rendering of <paramref name="mapView" /> is about to begin.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillStartRenderingMap (IMKMapViewDelegate This, MKMapView mapView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapViewWillStartRenderingMap:"), mapView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><param name="fullyRendered">To be added.</param><summary>Indicates that rendering of <paramref name="mapView" /> has completed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapViewDidFinishRenderingMap:fullyRendered:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishRenderingMap (MKMapView mapView, bool fullyRendered)
		{
			_DidFinishRenderingMap (this, mapView, fullyRendered);
		}
		/// <param name="mapView">To be added.</param><param name="fullyRendered">To be added.</param><summary>Indicates that rendering of <paramref name="mapView" /> has completed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishRenderingMap (IMKMapViewDelegate This, MKMapView mapView, bool fullyRendered)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("mapViewDidFinishRenderingMap:fullyRendered:"), mapView__handle__, fullyRendered ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><param name="memberAnnotations">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapView:clusterAnnotationForMemberAnnotations:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKClusterAnnotation CreateClusterAnnotation (MKMapView mapView, IMKAnnotation[] memberAnnotations)
		{
			return _CreateClusterAnnotation (this, mapView, memberAnnotations);
		}
		/// <param name="mapView">To be added.</param><param name="memberAnnotations">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MKClusterAnnotation _CreateClusterAnnotation (IMKMapViewDelegate This, MKMapView mapView, IMKAnnotation[] memberAnnotations)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			if (memberAnnotations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (memberAnnotations));
			using var nsa_memberAnnotations = NSArray.FromNSObjects (memberAnnotations);
			MKClusterAnnotation? ret;
			ret =  Runtime.GetNSObject<MKClusterAnnotation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:clusterAnnotationForMemberAnnotations:"), mapView__handle__, nsa_memberAnnotations.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			return ret!;
		}
		/// <param name="mapView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapViewDidChangeVisibleRegion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeVisibleRegion (MKMapView mapView)
		{
			_DidChangeVisibleRegion (this, mapView);
		}
		/// <param name="mapView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeVisibleRegion (IMKMapViewDelegate This, MKMapView mapView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapViewDidChangeVisibleRegion:"), mapView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		[global::Foundation.OptionalMember]
		[Export ("mapView:selectionAccessoryForAnnotation:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKSelectionAccessory? GetSelectionAccessory (MKMapView mapView, IMKAnnotation annotation)
		{
			return _GetSelectionAccessory (this, mapView, annotation);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MKSelectionAccessory? _GetSelectionAccessory (IMKMapViewDelegate This, MKMapView mapView, IMKAnnotation annotation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			MKSelectionAccessory? ret;
			ret =  Runtime.GetNSObject<MKSelectionAccessory> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:selectionAccessoryForAnnotation:"), mapView__handle__, annotation__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (annotation);
			return ret!;
		}
		[DynamicDependencyAttribute ("CalloutAccessoryControlTapped(MapKit.MKMapView,MapKit.MKAnnotationView,UIKit.UIControl)")]
		[DynamicDependencyAttribute ("ChangedDragState(MapKit.MKMapView,MapKit.MKAnnotationView,MapKit.MKAnnotationViewDragState,MapKit.MKAnnotationViewDragState)")]
		[DynamicDependencyAttribute ("CreateClusterAnnotation(MapKit.MKMapView,MapKit.IMKAnnotation[])")]
		[DynamicDependencyAttribute ("DidAddAnnotationViews(MapKit.MKMapView,MapKit.MKAnnotationView[])")]
		[DynamicDependencyAttribute ("DidAddOverlayRenderers(MapKit.MKMapView,MapKit.MKOverlayRenderer[])")]
		[DynamicDependencyAttribute ("DidAddOverlayViews(MapKit.MKMapView,MapKit.MKOverlayView)")]
		[DynamicDependencyAttribute ("DidChangeUserTrackingMode(MapKit.MKMapView,MapKit.MKUserTrackingMode,System.Boolean)")]
		[DynamicDependencyAttribute ("DidChangeVisibleRegion(MapKit.MKMapView)")]
		[DynamicDependencyAttribute ("DidDeselectAnnotation(MapKit.MKMapView,MapKit.IMKAnnotation)")]
		[DynamicDependencyAttribute ("DidDeselectAnnotationView(MapKit.MKMapView,MapKit.MKAnnotationView)")]
		[DynamicDependencyAttribute ("DidFailToLocateUser(MapKit.MKMapView,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidFinishRenderingMap(MapKit.MKMapView,System.Boolean)")]
		[DynamicDependencyAttribute ("DidSelectAnnotation(MapKit.MKMapView,MapKit.IMKAnnotation)")]
		[DynamicDependencyAttribute ("DidSelectAnnotationView(MapKit.MKMapView,MapKit.MKAnnotationView)")]
		[DynamicDependencyAttribute ("DidStopLocatingUser(MapKit.MKMapView)")]
		[DynamicDependencyAttribute ("DidUpdateUserLocation(MapKit.MKMapView,MapKit.MKUserLocation)")]
		[DynamicDependencyAttribute ("GetSelectionAccessory(MapKit.MKMapView,MapKit.IMKAnnotation)")]
		[DynamicDependencyAttribute ("GetViewForAnnotation(MapKit.MKMapView,MapKit.IMKAnnotation)")]
		[DynamicDependencyAttribute ("GetViewForOverlay(MapKit.MKMapView,MapKit.IMKOverlay)")]
		[DynamicDependencyAttribute ("LoadingMapFailed(MapKit.MKMapView,Foundation.NSError)")]
		[DynamicDependencyAttribute ("MapLoaded(MapKit.MKMapView)")]
		[DynamicDependencyAttribute ("OverlayRenderer(MapKit.MKMapView,MapKit.IMKOverlay)")]
		[DynamicDependencyAttribute ("RegionChanged(MapKit.MKMapView,System.Boolean)")]
		[DynamicDependencyAttribute ("RegionWillChange(MapKit.MKMapView,System.Boolean)")]
		[DynamicDependencyAttribute ("WillStartLoadingMap(MapKit.MKMapView)")]
		[DynamicDependencyAttribute ("WillStartLocatingUser(MapKit.MKMapView)")]
		[DynamicDependencyAttribute ("WillStartRenderingMap(MapKit.MKMapView)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MKMapViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMKMapViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMKMapViewDelegate" /> interface to support all the methods from the MKMapViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMKMapViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MKMapViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MKMapViewDelegate_Extensions {
		/// <param name="mapView">To be added.</param><param name="animated">To be added.</param><summary>Indicates the region displayed by <paramref name="mapView" /> is about to change.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegionWillChange (this IMKMapViewDelegate This, MKMapView mapView, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("mapView:regionWillChangeAnimated:"), mapView__handle__, animated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><param name="animated">To be added.</param><summary>Indicates the region displayed by <paramref name="mapView" /> has changed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegionChanged (this IMKMapViewDelegate This, MKMapView mapView, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("mapView:regionDidChangeAnimated:"), mapView__handle__, animated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><summary>Indicates that loading of map data is about to begin.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillStartLoadingMap (this IMKMapViewDelegate This, MKMapView mapView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapViewWillStartLoadingMap:"), mapView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><summary>Indicates that loading of map data has completed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapLoaded (this IMKMapViewDelegate This, MKMapView mapView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapViewDidFinishLoadingMap:"), mapView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><param name="error">To be added.</param><summary>Indicates an <paramref name="error" /> caused loading to fail.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LoadingMapFailed (this IMKMapViewDelegate This, MKMapView mapView, NSError error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapViewDidFailLoadingMap:withError:"), mapView__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (error);
		}
		/// <param name="mapView">To be added.</param><param name="annotation">To be added.</param><summary>Returns the <see cref="T:MapKit.MKAnnotationView" /> associated with the <paramref name="annotation" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MKAnnotationView? GetViewForAnnotation (this IMKMapViewDelegate This, MKMapView mapView, IMKAnnotation annotation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			MKAnnotationView? ret;
			ret =  Runtime.GetNSObject<MKAnnotationView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:viewForAnnotation:"), mapView__handle__, annotation__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (annotation);
			return ret!;
		}
		/// <param name="mapView">To be added.</param><param name="views">To be added.</param><summary>Called when an annotation view (or views) have been added to <paramref name="mapView" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddAnnotationViews (this IMKMapViewDelegate This, MKMapView mapView, MKAnnotationView[] views)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			if (views is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (views));
			using var nsa_views = NSArray.FromNSObjects (views);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:didAddAnnotationViews:"), mapView__handle__, nsa_views.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><param name="view">To be added.</param><param name="control">To be added.</param><summary>Called when the callout accessory <paramref name="control" /> has been tapped.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CalloutAccessoryControlTapped (this IMKMapViewDelegate This, MKMapView mapView, MKAnnotationView view, global::UIKit.UIControl control)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var control__handle__ = control!.GetNonNullHandle (nameof (control));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:annotationView:calloutAccessoryControlTapped:"), mapView__handle__, view__handle__, control__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (view);
			GC.KeepAlive (control);
		}
		/// <param name="mapView">To be added.</param><param name="annotationView">To be added.</param><param name="newState">To be added.</param><param name="oldState">To be added.</param><summary>Called when the drag state has changed from <paramref name="oldState" /> to <paramref name="newState" />.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ChangedDragState (this IMKMapViewDelegate This, MKMapView mapView, MKAnnotationView annotationView, MKAnnotationViewDragState newState, MKAnnotationViewDragState oldState)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var annotationView__handle__ = annotationView!.GetNonNullHandle (nameof (annotationView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("mapView:annotationView:didChangeDragState:fromOldState:"), mapView__handle__, annotationView__handle__, (UIntPtr) (ulong) newState, (UIntPtr) (ulong) oldState);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (annotationView);
		}
		/// <param name="mapView">To be added.</param><param name="overlay">To be added.</param><summary>Use MKOverlayRenderer.RendererForOverlay instead</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'MKOverlayRenderer.RendererForOverlay' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'MKOverlayRenderer.RendererForOverlay' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MKOverlayView GetViewForOverlay (this IMKMapViewDelegate This, MKMapView mapView, IMKOverlay overlay)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			MKOverlayView? ret;
			ret =  Runtime.GetNSObject<MKOverlayView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:viewForOverlay:"), mapView__handle__, overlay__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (overlay);
			return ret!;
		}
		/// <param name="mapView">To be added.</param><param name="overlayViews">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidAddOverlayRenderers' instead.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'DidAddOverlayRenderers' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidAddOverlayRenderers' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddOverlayViews (this IMKMapViewDelegate This, MKMapView mapView, MKOverlayView overlayViews)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var overlayViews__handle__ = overlayViews!.GetNonNullHandle (nameof (overlayViews));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:didAddOverlayViews:"), mapView__handle__, overlayViews__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (overlayViews);
		}
		/// <param name="mapView">To be added.</param><param name="view">To be added.</param><summary>Indicates that the specified <see cref="T:MapKit.MKAnnotationView" /> has been selected.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectAnnotationView (this IMKMapViewDelegate This, MKMapView mapView, MKAnnotationView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:didSelectAnnotationView:"), mapView__handle__, view__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (view);
		}
		/// <param name="mapView">To be added.</param><param name="error">To be added.</param><summary>Indicates that the attempt to locate the current user has failed due to <paramref name="error" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailToLocateUser (this IMKMapViewDelegate This, MKMapView mapView, NSError error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:didFailToLocateUserWithError:"), mapView__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (error);
		}
		/// <param name="mapView">To be added.</param><param name="view">To be added.</param><summary>Indicates that <paramref name="view" /> has been deselected.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDeselectAnnotationView (this IMKMapViewDelegate This, MKMapView mapView, MKAnnotationView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:didDeselectAnnotationView:"), mapView__handle__, view__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (view);
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectAnnotation (this IMKMapViewDelegate This, MKMapView mapView, IMKAnnotation annotation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:didSelectAnnotation:"), mapView__handle__, annotation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (annotation);
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDeselectAnnotation (this IMKMapViewDelegate This, MKMapView mapView, IMKAnnotation annotation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:didDeselectAnnotation:"), mapView__handle__, annotation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (annotation);
		}
		/// <param name="mapView">To be added.</param><summary>Indicates that the system will start attempting to locate the user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillStartLocatingUser (this IMKMapViewDelegate This, MKMapView mapView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapViewWillStartLocatingUser:"), mapView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><summary>Indicates the system has stopped attemptig to locate the user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStopLocatingUser (this IMKMapViewDelegate This, MKMapView mapView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapViewDidStopLocatingUser:"), mapView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><param name="userLocation">To be added.</param><summary>Indicates the system has provided an update to the user's location.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateUserLocation (this IMKMapViewDelegate This, MKMapView mapView, MKUserLocation userLocation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var userLocation__handle__ = userLocation!.GetNonNullHandle (nameof (userLocation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:didUpdateUserLocation:"), mapView__handle__, userLocation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (userLocation);
		}
		/// <param name="mapView">To be added.</param><param name="mode">To be added.</param><param name="animated">To be added.</param><summary>Indicates a change in the active <see cref="T:MapKit.MKUserTrackingMode" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeUserTrackingMode (this IMKMapViewDelegate This, MKMapView mapView, MKUserTrackingMode mode, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_bool (This.Handle, Selector.GetHandle ("mapView:didChangeUserTrackingMode:animated:"), mapView__handle__, (UIntPtr) (ulong) mode, animated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">The <see cref="T:MapKit.MKMapView" /> being rendered.</param><param name="overlay">The overlay requiring a renderer.</param><summary>Calculates he <see cref="T:MapKit.MKOverlayRenderer" /> appropriate to the <paramref name="overlay" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MKOverlayRenderer OverlayRenderer (this IMKMapViewDelegate This, MKMapView mapView, IMKOverlay overlay)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			MKOverlayRenderer? ret;
			ret =  Runtime.GetNSObject<MKOverlayRenderer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:rendererForOverlay:"), mapView__handle__, overlay__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (overlay);
			return ret!;
		}
		/// <param name="mapView">To be added.</param><param name="renderers">To be added.</param><summary>Called when an overlay renderer (or renderers) have been added to <paramref name="mapView" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddOverlayRenderers (this IMKMapViewDelegate This, MKMapView mapView, MKOverlayRenderer[] renderers)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			if (renderers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (renderers));
			using var nsa_renderers = NSArray.FromNSObjects (renderers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:didAddOverlayRenderers:"), mapView__handle__, nsa_renderers.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><summary>Indicates that rendering of <paramref name="mapView" /> is about to begin.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillStartRenderingMap (this IMKMapViewDelegate This, MKMapView mapView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapViewWillStartRenderingMap:"), mapView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><param name="fullyRendered">To be added.</param><summary>Indicates that rendering of <paramref name="mapView" /> has completed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishRenderingMap (this IMKMapViewDelegate This, MKMapView mapView, bool fullyRendered)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("mapViewDidFinishRenderingMap:fullyRendered:"), mapView__handle__, fullyRendered ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		/// <param name="mapView">To be added.</param><param name="memberAnnotations">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MKClusterAnnotation CreateClusterAnnotation (this IMKMapViewDelegate This, MKMapView mapView, IMKAnnotation[] memberAnnotations)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			if (memberAnnotations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (memberAnnotations));
			using var nsa_memberAnnotations = NSArray.FromNSObjects (memberAnnotations);
			MKClusterAnnotation? ret;
			ret =  Runtime.GetNSObject<MKClusterAnnotation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:clusterAnnotationForMemberAnnotations:"), mapView__handle__, nsa_memberAnnotations.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			return ret!;
		}
		/// <param name="mapView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeVisibleRegion (this IMKMapViewDelegate This, MKMapView mapView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapViewDidChangeVisibleRegion:"), mapView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MKSelectionAccessory? GetSelectionAccessory (this IMKMapViewDelegate This, MKMapView mapView, IMKAnnotation annotation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var mapView__handle__ = mapView!.GetNonNullHandle (nameof (mapView));
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			MKSelectionAccessory? ret;
			ret =  Runtime.GetNSObject<MKSelectionAccessory> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapView:selectionAccessoryForAnnotation:"), mapView__handle__, annotation__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (mapView);
			GC.KeepAlive (annotation);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MKMapViewDelegateWrapper : BaseWrapper, IMKMapViewDelegate {
		public MKMapViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MKMapViewDelegateWrapper))]
		static MKMapViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace MapKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IMKMapViewDelegate" /> (for the protocol <c>MKMapViewDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IMKMapViewDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__MapKit_MKMapViewDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MKMapViewDelegate : NSObject, IMKMapViewDelegate {
		/// <summary>Creates a new <see cref="MKMapViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MKMapViewDelegate () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
			}
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MKMapViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MKMapViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="mapView">To be added.</param><param name="view">To be added.</param><param name="control">To be added.</param><summary>Called when the callout accessory <paramref name="control" /> has been tapped.</summary><remarks>To be added.</remarks>
		[Export ("mapView:annotationView:calloutAccessoryControlTapped:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CalloutAccessoryControlTapped (MKMapView mapView, MKAnnotationView view, global::UIKit.UIControl control)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><param name="annotationView">To be added.</param><param name="newState">To be added.</param><param name="oldState">To be added.</param><summary>Called when the drag state has changed from <paramref name="oldState" /> to <paramref name="newState" />.</summary><remarks>To be added.</remarks>
		[Export ("mapView:annotationView:didChangeDragState:fromOldState:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangedDragState (MKMapView mapView, MKAnnotationView annotationView, MKAnnotationViewDragState newState, MKAnnotationViewDragState oldState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><param name="memberAnnotations">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("mapView:clusterAnnotationForMemberAnnotations:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKClusterAnnotation CreateClusterAnnotation (MKMapView mapView, IMKAnnotation[] memberAnnotations)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><param name="views">To be added.</param><summary>Called when an annotation view (or views) have been added to <paramref name="mapView" />.</summary><remarks>To be added.</remarks>
		[Export ("mapView:didAddAnnotationViews:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddAnnotationViews (MKMapView mapView, MKAnnotationView[] views)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><param name="renderers">To be added.</param><summary>Called when an overlay renderer (or renderers) have been added to <paramref name="mapView" />.</summary><remarks>To be added.</remarks>
		[Export ("mapView:didAddOverlayRenderers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddOverlayRenderers (MKMapView mapView, MKOverlayRenderer[] renderers)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><param name="overlayViews">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidAddOverlayRenderers' instead.</summary><remarks>To be added.</remarks>
		[Export ("mapView:didAddOverlayViews:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'DidAddOverlayRenderers' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidAddOverlayRenderers' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddOverlayViews (MKMapView mapView, MKOverlayView overlayViews)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><param name="mode">To be added.</param><param name="animated">To be added.</param><summary>Indicates a change in the active <see cref="T:MapKit.MKUserTrackingMode" />.</summary><remarks>To be added.</remarks>
		[Export ("mapView:didChangeUserTrackingMode:animated:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeUserTrackingMode (MKMapView mapView, MKUserTrackingMode mode, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("mapViewDidChangeVisibleRegion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeVisibleRegion (MKMapView mapView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("mapView:didDeselectAnnotation:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDeselectAnnotation (MKMapView mapView, IMKAnnotation annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><param name="view">To be added.</param><summary>Indicates that <paramref name="view" /> has been deselected.</summary><remarks>To be added.</remarks>
		[Export ("mapView:didDeselectAnnotationView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDeselectAnnotationView (MKMapView mapView, MKAnnotationView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><param name="error">To be added.</param><summary>Indicates that the attempt to locate the current user has failed due to <paramref name="error" />.</summary><remarks>To be added.</remarks>
		[Export ("mapView:didFailToLocateUserWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToLocateUser (MKMapView mapView, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><param name="fullyRendered">To be added.</param><summary>Indicates that rendering of <paramref name="mapView" /> has completed.</summary><remarks>To be added.</remarks>
		[Export ("mapViewDidFinishRenderingMap:fullyRendered:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishRenderingMap (MKMapView mapView, bool fullyRendered)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("mapView:didSelectAnnotation:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectAnnotation (MKMapView mapView, IMKAnnotation annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><param name="view">To be added.</param><summary>Indicates that the specified <see cref="T:MapKit.MKAnnotationView" /> has been selected.</summary><remarks>To be added.</remarks>
		[Export ("mapView:didSelectAnnotationView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectAnnotationView (MKMapView mapView, MKAnnotationView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><summary>Indicates the system has stopped attemptig to locate the user.</summary><remarks>To be added.</remarks>
		[Export ("mapViewDidStopLocatingUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStopLocatingUser (MKMapView mapView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><param name="userLocation">To be added.</param><summary>Indicates the system has provided an update to the user's location.</summary><remarks>To be added.</remarks>
		[Export ("mapView:didUpdateUserLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateUserLocation (MKMapView mapView, MKUserLocation userLocation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("mapView:selectionAccessoryForAnnotation:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKSelectionAccessory? GetSelectionAccessory (MKMapView mapView, IMKAnnotation annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><param name="annotation">To be added.</param><summary>Returns the <see cref="T:MapKit.MKAnnotationView" /> associated with the <paramref name="annotation" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("mapView:viewForAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKAnnotationView? GetViewForAnnotation (MKMapView mapView, IMKAnnotation annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><param name="overlay">To be added.</param><summary>Use MKOverlayRenderer.RendererForOverlay instead</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("mapView:viewForOverlay:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'MKOverlayRenderer.RendererForOverlay' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'MKOverlayRenderer.RendererForOverlay' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKOverlayView GetViewForOverlay (MKMapView mapView, IMKOverlay overlay)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><param name="error">To be added.</param><summary>Indicates an <paramref name="error" /> caused loading to fail.</summary><remarks>To be added.</remarks>
		[Export ("mapViewDidFailLoadingMap:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadingMapFailed (MKMapView mapView, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><summary>Indicates that loading of map data has completed.</summary><remarks>To be added.</remarks>
		[Export ("mapViewDidFinishLoadingMap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapLoaded (MKMapView mapView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">The <see cref="T:MapKit.MKMapView" /> being rendered.</param><param name="overlay">The overlay requiring a renderer.</param><summary>Calculates he <see cref="T:MapKit.MKOverlayRenderer" /> appropriate to the <paramref name="overlay" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("mapView:rendererForOverlay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKOverlayRenderer OverlayRenderer (MKMapView mapView, IMKOverlay overlay)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><param name="animated">To be added.</param><summary>Indicates the region displayed by <paramref name="mapView" /> has changed.</summary><remarks>To be added.</remarks>
		[Export ("mapView:regionDidChangeAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegionChanged (MKMapView mapView, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><param name="animated">To be added.</param><summary>Indicates the region displayed by <paramref name="mapView" /> is about to change.</summary><remarks>To be added.</remarks>
		[Export ("mapView:regionWillChangeAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegionWillChange (MKMapView mapView, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><summary>Indicates that loading of map data is about to begin.</summary><remarks>To be added.</remarks>
		[Export ("mapViewWillStartLoadingMap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartLoadingMap (MKMapView mapView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><summary>Indicates that the system will start attempting to locate the user.</summary><remarks>To be added.</remarks>
		[Export ("mapViewWillStartLocatingUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartLocatingUser (MKMapView mapView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapView">To be added.</param><summary>Indicates that rendering of <paramref name="mapView" /> is about to begin.</summary><remarks>To be added.</remarks>
		[Export ("mapViewWillStartRenderingMap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartRenderingMap (MKMapView mapView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MKMapViewDelegate */
}
