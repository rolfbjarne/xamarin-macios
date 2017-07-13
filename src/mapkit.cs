//
// This file describes the API that the generator will produce
//
// Authors:
//   Geoff Norton
//   Miguel de Icaza
//
// Copyright 2009, Novell, Inc.
// Copyright 2011-2013 Xamarin Inc.
//
#if XAMCORE_2_0 || !MONOMAC
using XamCore.CoreFoundation;
using XamCore.ObjCRuntime;
using XamCore.Foundation;
using XamCore.CoreGraphics;
using XamCore.CoreLocation;
#if !MONOMAC
using XamCore.UIKit;
#endif
#if !TVOS && XAMCORE_2_0
using Contacts;
#endif
using System;

#if MONOMAC
using UIImage=XamCore.AppKit.NSImage;
using UIView=XamCore.AppKit.NSView;
using UIEdgeInsets=XamCore.AppKit.NSEdgeInsets;
using UIColor=XamCore.AppKit.NSColor;
#endif

namespace XamCore.MapKit {
	
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	[Mac (10,9, onlyOn64: true)]
	interface MKAnnotation {
		[Export ("coordinate")][Abstract]
		CLLocationCoordinate2D Coordinate { get;
#if !MONOMAC && !XAMCORE_2_0
			set;
#endif
		}

		[Export ("title", ArgumentSemantic.Copy)]
		string Title { get; }
	
		[Export ("subtitle", ArgumentSemantic.Copy)]
		string Subtitle { get; } 

#if MONOMAC || XAMCORE_2_0
		[Export ("setCoordinate:")]
		[Mac (10,9), iOS (4,0)]
		void SetCoordinate (CLLocationCoordinate2D value);
#endif
	}

	interface IMKAnnotation {}

#if !WATCH
	[BaseType (typeof (MKAnnotation))]
	[Model]
	[Protocol]
	[Mac (10,9, onlyOn64: true)]
	interface MKOverlay {
#if MONOMAC || XAMCORE_2_0
		[Abstract]
#endif
		[Export ("boundingMapRect")]
		MKMapRect BoundingMapRect { get; }

		[Export ("intersectsMapRect:")]
		bool Intersects (MKMapRect rect);

#if MONOMAC || XAMCORE_2_0
		// optional, not implemented by MKPolygon, MKPolyline and MKCircle
		// implemented by MKTileOverlay (and defined there)
		[OptionalImplementation]
		[Since (7,0), Export ("canReplaceMapContent")]
		bool CanReplaceMapContent { get; }
#endif
	}

	interface IMKOverlay {}
	
	[BaseType (typeof (UIView))]
	[NoWatch]
	[TV (9,2)]
	[Mac (10,9, onlyOn64 : true)]
	interface MKAnnotationView {
		[DesignatedInitializer]
		[Export ("initWithAnnotation:reuseIdentifier:")]
		[PostGet ("Annotation")]
#if XAMCORE_2_0
		IntPtr Constructor (IMKAnnotation annotation, [NullAllowed] string reuseIdentifier);
#else
		IntPtr Constructor (NSObject annotation, [NullAllowed] string reuseIdentifier);
#endif
	
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		[Export ("reuseIdentifier")]
		string ReuseIdentifier { get; }
	
		[Export ("prepareForReuse")]
		void PrepareForReuse ();
	
		[Export ("annotation", ArgumentSemantic.Retain)]
		[ThreadSafe] // Sometimes iOS will request the annotation from a non-UI thread (see https://bugzilla.xamarin.com/show_bug.cgi?27609)
#if XAMCORE_2_0
		IMKAnnotation Annotation { get; [NullAllowed] set; }
#else
		NSObject Annotation { get; [NullAllowed] set; }
#endif
	
		[Export ("image", ArgumentSemantic.Retain)]
		[NullAllowed]
		UIImage Image { get; set; }
	
		[Export ("centerOffset")]
		CGPoint CenterOffset { get; set; }
	
		[Export ("calloutOffset")]
		CGPoint CalloutOffset { get; set; }
	
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }
	
		[Export ("highlighted")]
		bool Highlighted { [Bind ("isHighlighted")] get; set; }
	
		[Export ("selected")]
		bool Selected { [Bind ("isSelected")] get; set; }
	
		[Export ("setSelected:animated:")]
		void SetSelected (bool selected, bool animated);
	
		[Export ("canShowCallout")]
		bool CanShowCallout { get; set; }
	
		[Export ("leftCalloutAccessoryView", ArgumentSemantic.Retain)]
		[NullAllowed]
		UIView LeftCalloutAccessoryView { get; set; }
	
		[Export ("rightCalloutAccessoryView", ArgumentSemantic.Retain)]
		[NullAllowed]
		UIView RightCalloutAccessoryView { get; set; }
	
		[NoTV]
		[Since (4,2)]
		[Export ("setDragState:animated:")]
		void SetDragState (MKAnnotationViewDragState newDragState, bool animated);

		[Export ("dragState")]
		[NoTV]
		[Since (4,0)]
		MKAnnotationViewDragState DragState { get; set;  }

		[NoTV]
		[Since (4,0)]
		[Export ("draggable")]
		bool Draggable { [Bind ("isDraggable")] get; set;  }

		[iOS (9,0), Mac(10,11)]
		[Export ("detailCalloutAccessoryView")]
		[NullAllowed]
		UIView DetailCalloutAccessoryView { get; set; }

#if MONOMAC
		[Export ("leftCalloutOffset")]
		CGPoint LeftCalloutOffset { get; set; }

		[Export ("rightCalloutOffset")]
		CGPoint RightCallpoutOffset { get; set; }
#endif

	}

	[ThreadSafe]
	[TV (9,2)]
	[Since (4,0)]
	[Mac (10,9, onlyOn64 : true)]
	[BaseType (typeof (MKShape))]
	interface MKCircle : MKOverlay {
		[Export ("radius")]
		double Radius { get;  }

		[Static]
		[Export ("circleWithCenterCoordinate:radius:")]
		MKCircle Circle (CLLocationCoordinate2D withcenterCoordinate, double radius);

		[Static]
		[Export ("circleWithMapRect:")]
		MKCircle CircleWithMapRect (MKMapRect mapRect);

		#region MKAnnotation
		[Export ("coordinate")]
		CLLocationCoordinate2D Coordinate { get; }
		// note: setCoordinate: is not mandatory and is not implemented for MKCircle
		#endregion
	}

#if !MONOMAC && !TVOS
	[BaseType (typeof (MKOverlayPathView))]
	[Availability (Introduced = Platform.iOS_4_0, Deprecated = Platform.iOS_7_0, Message = "Use MKCircleRenderer instead")]
	interface MKCircleView {
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		[Export ("circle")]
		MKCircle Circle { get;  }

		[Export ("initWithCircle:")]
		[PostGet ("Circle")]
		IntPtr Constructor (MKCircle circle);
	}
#endif
	
	[TV (9,2)]
	[Since (6,0)]
	[Mac (10,9, onlyOn64 : true)]
	[BaseType (typeof (NSObject))]
	interface MKDirectionsRequest {
		[NullAllowed] // by default this property is null
		[Export ("destination")]
		MKMapItem Destination { get; [Since (7,0)] set; }

		[NullAllowed] // by default this property is null
		[Export ("source")]
		MKMapItem Source { get; [Since (7,0)] set; }

		[Export ("initWithContentsOfURL:")]
		IntPtr Constructor (NSUrl url);

		[Static]
		[Export ("isDirectionsRequestURL:")]
		bool IsDirectionsRequestUrl (NSUrl url);

		[Since (7,0), Export ("transportType")]
		MKDirectionsTransportType TransportType { get; set; }

		[Since (7,0), Export ("requestsAlternateRoutes")]
		bool RequestsAlternateRoutes { get; set; }

		[NullAllowed] // by default this property is null
		[Since (7,0), Export ("departureDate", ArgumentSemantic.Copy)]
		NSDate DepartureDate { get; set; }

		[NullAllowed] // by default this property is null
		[Since (7,0), Export ("arrivalDate", ArgumentSemantic.Copy)]
		NSDate ArrivalDate { get; set; }
	}
#endif // !WATCH

	[BaseType (typeof (NSObject))]
	[Since (6,0)]
	[TV (9,2)]
	[Mac (10,9, onlyOn64 : true)]
	interface MKMapItem {
		[Export ("placemark", ArgumentSemantic.Retain)]
		MKPlacemark Placemark { get;  }

		[Export ("isCurrentLocation")]
		bool IsCurrentLocation { get;  }

		[NullAllowed] // it's null by default on iOS 6.1
		[Export ("name", ArgumentSemantic.Copy)]
		string Name { get; set;  }

		[NullAllowed] // by default this property is null
		[Export ("phoneNumber", ArgumentSemantic.Copy)]
		string PhoneNumber { get; set;  }

		[NullAllowed] // by default this property is null
		[Export ("url", ArgumentSemantic.Retain)]
		NSUrl Url { get; set;  }

		[Static]
		[Export ("mapItemForCurrentLocation")]
		MKMapItem MapItemForCurrentLocation ();

		[Export ("initWithPlacemark:")]
		IntPtr Constructor (MKPlacemark placemark);

		[NoTV]
		[Export ("openInMapsWithLaunchOptions:"), Internal]
		bool _OpenInMaps ([NullAllowed] NSDictionary  launchOptions);

		[NoTV]
		[Static]
		[Export ("openMapsWithItems:launchOptions:"), Internal]
		bool _OpenMaps ([NullAllowed] MKMapItem [] mapItems, [NullAllowed] NSDictionary launchOptions);

		[NoTV]
		[Field ("MKLaunchOptionsDirectionsModeKey"), Internal]
		NSString MKLaunchOptionsDirectionsModeKey { get; }

		[NoTV]
		[NoWatch]
		[Field ("MKLaunchOptionsMapTypeKey"), Internal]
		NSString MKLaunchOptionsMapTypeKey { get; }

		[NoTV]
		[Field ("MKLaunchOptionsMapCenterKey"), Internal]
		NSString MKLaunchOptionsMapCenterKey { get; }

		[NoTV]
		[Field ("MKLaunchOptionsMapSpanKey"), Internal]
		NSString MKLaunchOptionsMapSpanKey { get; }

		[NoTV]
		[NoWatch]
		[Field ("MKLaunchOptionsShowsTrafficKey"), Internal]
		NSString MKLaunchOptionsShowsTrafficKey { get; }

		[NoTV]
		[iOS (7,1)] // latest documentation says 7.1 and the field is not present in the simulator (7.0.3)
		[Mac (10,10)]
		[Field ("MKLaunchOptionsCameraKey"), Internal]
		NSString MKLaunchOptionsCameraKey { get; }

		[NoTV]
		[Field ("MKLaunchOptionsDirectionsModeDriving"), Internal]
		NSString MKLaunchOptionsDirectionsModeDriving { get; }

		[NoTV]
		[Field ("MKLaunchOptionsDirectionsModeWalking"), Internal]
		NSString MKLaunchOptionsDirectionsModeWalking { get; }

		[NoTV]
		[iOS (9,0)][Mac (10,11)]
		[Field ("MKLaunchOptionsDirectionsModeTransit"), Internal]
		NSString MKLaunchOptionsDirectionsModeTransit { get; }

		[NoTV]
		[iOS (10,0)][Mac (10,12)][Watch (3,0)]
		[Field ("MKLaunchOptionsDirectionsModeDefault"), Internal]
		NSString MKLaunchOptionsDirectionsModeDefault { get; }

		[Export ("timeZone")]
		[iOS (9,0), Mac(10,11)]
		[NullAllowed]
		NSTimeZone TimeZone { get; set; }
	}

#if !WATCH
	[TV (9,2)]
	[BaseType (typeof (UIView), Delegates=new string [] { "WeakDelegate" }, Events=new Type [] {typeof (MKMapViewDelegate)})]
	[Mac (10,9, onlyOn64 : true)]
	interface MKMapView {
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		[Export ("delegate", ArgumentSemantic.Weak)][NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Wrap ("WeakDelegate")]
		[Protocolize]
		MKMapViewDelegate Delegate { get; set; }
	
		[Export ("mapType")]
		MKMapType MapType { get; set; }
	
		[Export ("region")]
		MKCoordinateRegion Region { get; set; }
	
		[Export ("setRegion:animated:")]
		void SetRegion (MKCoordinateRegion region, bool animated);
	
		[Export ("centerCoordinate")]
		CLLocationCoordinate2D CenterCoordinate { get; set; }
	
		[Export ("setCenterCoordinate:animated:")]
		void SetCenterCoordinate (CLLocationCoordinate2D coordinate, bool animated);
	
		[Export ("regionThatFits:")]
		MKCoordinateRegion RegionThatFits (MKCoordinateRegion region);
	
		[Export ("convertCoordinate:toPointToView:")]
		CGPoint ConvertCoordinate (CLLocationCoordinate2D coordinate, [NullAllowed] UIView toPointToView);
	
		[Export ("convertPoint:toCoordinateFromView:")]
		CLLocationCoordinate2D ConvertPoint (CGPoint point, [NullAllowed] UIView toCoordinateFromView);
	
		[Export ("convertRegion:toRectToView:")]
		CGRect ConvertRegion (MKCoordinateRegion region, [NullAllowed] UIView toRectToView);
	
		[Export ("convertRect:toRegionFromView:")]
		MKCoordinateRegion ConvertRect (CGRect rect, [NullAllowed] UIView toRegionFromView);
	
		[Export ("zoomEnabled")]
		bool ZoomEnabled { [Bind ("isZoomEnabled")] get; set; }
	
		[Export ("scrollEnabled")]
		bool ScrollEnabled { [Bind ("isScrollEnabled")] get; set; }
	
		[Export ("showsUserLocation")]
		bool ShowsUserLocation { get; set; }
	
		[Export ("userLocation")]
		MKUserLocation UserLocation { get; }
	
		[Export ("userLocationVisible")]
		bool UserLocationVisible { [Bind ("isUserLocationVisible")] get; }
	
		[Export ("addAnnotation:")]
		[PostGet ("Annotations")]
#if XAMCORE_2_0
		void AddAnnotation (IMKAnnotation annotation);
#else
		void AddAnnotationObject (NSObject annotation);
#endif
	
		[Export ("addAnnotations:")]
		[PostGet ("Annotations")]
#if XAMCORE_2_0
		void AddAnnotations ([Params] IMKAnnotation [] annotations);
#else
		void AddAnnotationObjects ([Params] NSObject [] annotations);
#endif
	
		[Export ("removeAnnotation:")]
		[PostGet ("Annotations")]
#if XAMCORE_2_0
		void RemoveAnnotation (IMKAnnotation annotation);
#else
		void RemoveAnnotation (NSObject annotation);
#endif
	
		[Export ("removeAnnotations:")]
		[PostGet ("Annotations")]
#if XAMCORE_2_0
		void RemoveAnnotations ([Params] IMKAnnotation [] annotations);
#else
		void RemoveAnnotations ([Params] NSObject [] annotations);
#endif
	
		[Export ("annotations")]
#if XAMCORE_2_0
		IMKAnnotation [] Annotations { get; }
#else
		NSObject [] Annotations { get; }
#endif
	
		[Export ("viewForAnnotation:")]
#if XAMCORE_2_0
		MKAnnotationView ViewForAnnotation (IMKAnnotation annotation);
#else
		MKAnnotationView ViewForAnnotation (NSObject annotation);
#endif
	
		[Export ("dequeueReusableAnnotationViewWithIdentifier:")]
		MKAnnotationView DequeueReusableAnnotation (string withViewIdentifier);
	
		[Export ("selectAnnotation:animated:")]
		[PostGet ("SelectedAnnotations")]
#if XAMCORE_2_0
		void SelectAnnotation (IMKAnnotation annotation, bool animated);
#else
		void SelectAnnotation (NSObject annotation, bool animated);
#endif
	
		[Export ("deselectAnnotation:animated:")]
		[PostGet ("SelectedAnnotations")]
#if XAMCORE_2_0
		void DeselectAnnotation (IMKAnnotation annotation, bool animated);
#else
		void DeselectAnnotation (NSObject annotation, bool animated);
#endif
	
		[NullAllowed] // by default this property is null
		[Export ("selectedAnnotations", ArgumentSemantic.Copy)]
#if XAMCORE_2_0
		IMKAnnotation [] SelectedAnnotations { get; set;	}
#else
		NSObject [] SelectedAnnotations { get; set;	}
#endif
	
		[Export ("annotationVisibleRect")]
		CGRect AnnotationVisibleRect { get; }

		[Since (4,0)]
		[Export ("addOverlay:")][PostGet ("Overlays")]
#if XAMCORE_2_0
		void AddOverlay (IMKOverlay overlay);
#else
		void AddOverlay (NSObject overlay);
#endif

		[Since (4,0)]
		[Export ("addOverlays:")][PostGet ("Overlays")]
#if XAMCORE_2_0
		void AddOverlays (IMKOverlay [] overlays);
#else
		void AddOverlays (NSObject [] overlays);
#endif

		[Since (4,0)]
		[Export ("removeOverlay:")][PostGet ("Overlays")]
#if XAMCORE_2_0
		void RemoveOverlay (IMKOverlay overlay);
#else
		void RemoveOverlay (NSObject overlay);
#endif

		[Since (4,0)]
		[Export ("removeOverlays:")][PostGet ("Overlays")]
#if XAMCORE_2_0
		void RemoveOverlays ([Params] IMKOverlay [] overlays);
#else
		void RemoveOverlays ([Params] NSObject [] overlays);
#endif

		[Since (4,0)]
		[Export ("overlays")]
#if XAMCORE_2_0
		IMKOverlay [] Overlays { get;  }
#else
		NSObject [] Overlays { get;  }
#endif

		[Since (4,0)]
		[Export ("insertOverlay:atIndex:")][PostGet ("Overlays")]
#if XAMCORE_2_0
		void InsertOverlay (IMKOverlay overlay, nint index);
#else
		void InsertOverlay (NSObject overlay, nint index);
#endif

		[Since (4,0)]
		[Export ("insertOverlay:aboveOverlay:")][PostGet ("Overlays")]
#if XAMCORE_2_0
		void InsertOverlayAbove (IMKOverlay overlay, IMKOverlay sibling);
#else
		void InsertOverlayAbove (NSObject overlay, NSObject sibling);
#endif

		[Since (4,0)]
		[Export ("insertOverlay:belowOverlay:")][PostGet ("Overlays")]
#if XAMCORE_2_0
		void InsertOverlayBelow (IMKOverlay overlay, IMKOverlay sibling);
#else
		void InsertOverlayBelow (NSObject overlay, NSObject sibling);
#endif

		[Since (4,0)]
		[Export ("exchangeOverlayAtIndex:withOverlayAtIndex:")]
		void ExchangeOverlays (nint index1, nint index2);

		[Since (4,0)]
		[Export ("mapRectThatFits:")]
		MKMapRect MapRectThatFits (MKMapRect mapRect);

		[Since (4,0)]
		[Export ("setVisibleMapRect:edgePadding:animated:")]
		void SetVisibleMapRect (MKMapRect mapRect, UIEdgeInsets edgePadding, bool animate);

		[Since (4,0)]
		[Export ("setVisibleMapRect:animated:")]
		void SetVisibleMapRect (MKMapRect mapRect, bool animate);

		[Since (4,0)]
		[Export ("mapRectThatFits:edgePadding:")]
		MKMapRect MapRectThatFits (MKMapRect mapRect, UIEdgeInsets edgePadding);

#if !MONOMAC && !TVOS
		[Export ("viewForOverlay:")]
		[Availability (Introduced = Platform.iOS_4_0, Deprecated = Platform.iOS_7_0, Message = "Use MKOverlayRenderer.RendererForOverlay instead")]
#if XAMCORE_2_0
		MKOverlayView ViewForOverlay (IMKOverlay overlay);
#else
		MKOverlayView ViewForOverlay (NSObject overlay);
#endif
#endif // !MONOMAC && !TVOS

		[Since (4,0)]
		[Export ("visibleMapRect")]
		MKMapRect VisibleMapRect { get; set;  }

		[Since (4,2)]
		[Export ("annotationsInMapRect:")]
		NSSet GetAnnotations (MKMapRect mapRect);

#if !MONOMAC
		[Since (5,0)]
		[Export ("userTrackingMode")]
		MKUserTrackingMode UserTrackingMode { get; set; }
		
		[Since (5,0)]
		[Export ("setUserTrackingMode:animated:")]
		void SetUserTrackingMode (MKUserTrackingMode trackingMode, bool animated);
#endif

		[Since (7,0), Export ("camera", ArgumentSemantic.Copy)]
		MKMapCamera Camera { get; set; }

		[Since (7,0), Export ("setCamera:animated:")]
		void SetCamera (MKMapCamera camera, bool animated);

		[NoTV]
		[Since (7,0), Export ("rotateEnabled")]
		bool RotateEnabled { [Bind ("isRotateEnabled")] get; set; }

		[NoTV]
		[Since (7,0), Export ("pitchEnabled")]
		bool PitchEnabled { [Bind ("isPitchEnabled")] get; set; }

		[Since (7,0), Export ("showAnnotations:animated:")]
		void ShowAnnotations (IMKAnnotation [] annotations, bool animated);

		[Since (7,0), Export ("addOverlay:level:")]
		[PostGet ("Overlays")]
		void AddOverlay (IMKOverlay overlay, MKOverlayLevel level);

		[Since (7,0), Export ("addOverlays:level:")]
		[PostGet ("Overlays")]
		void AddOverlays (IMKOverlay [] overlays, MKOverlayLevel level);

		[Since (7,0), Export ("exchangeOverlay:withOverlay:")]
		[PostGet ("Overlays")]
		void ExchangeOverlay (IMKOverlay overlay1, IMKOverlay overlay2);

		[Since (7,0), Export ("insertOverlay:atIndex:level:")]
		[PostGet ("Overlays")]
		void InsertOverlay (IMKOverlay overlay, nuint index, MKOverlayLevel level);

		[Since (7,0), Export ("overlaysInLevel:")]
		IMKOverlay [] OverlaysInLevel (MKOverlayLevel level);

		[Since (7,0), Export ("rendererForOverlay:")]
		MKOverlayRenderer RendererForOverlay (IMKOverlay overlay);

		[Since (7,0)]
		[Export ("showsPointsOfInterest")]
		bool ShowsPointsOfInterest { get; set; }

		[Since (7,0)]
		[Export ("showsBuildings")]
		bool ShowsBuildings { get; set; }

		// MKMapView.h headers says "To be used in testing only" which means it's likely won't be accepted in the appstore
//		[iOS (9,0), Mac(10,11)]
//		[Export ("_handleSelectionAtPoint:")]
//		void _HandleSelectionAtPoint (CGPoint locationInView);

		[NoTV]
		[Mac(10,9), iOS(9,0)]
		[Export ("showsCompass")]
		bool ShowsCompass { get; set; }

		[Export ("showsScale")]
		[Mac (10,10), iOS(9,0)]
		bool ShowsScale { get; set; }

		[Export ("showsTraffic")]
		[Mac (10,11), iOS(9,0)]
		bool ShowsTraffic { get; set; }

#if MONOMAC
		[Export ("showsZoomControls")]
		bool ShowsZoomControls { get; set; }
#endif
	}

	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	[Mac (10,9, onlyOn64: true)]
	interface MKMapViewDelegate {
		[Export ("mapView:regionWillChangeAnimated:"), EventArgs ("MKMapViewChange")]
		void RegionWillChange (MKMapView mapView, bool animated);
	
		[Export ("mapView:regionDidChangeAnimated:"), EventArgs ("MKMapViewChange")]
		void RegionChanged (MKMapView mapView, bool animated);
	
		[Export ("mapViewWillStartLoadingMap:")]
		void WillStartLoadingMap (MKMapView mapView);
	
		[Export ("mapViewDidFinishLoadingMap:")]
		void MapLoaded (MKMapView mapView);
	
		[Export ("mapViewDidFailLoadingMap:withError:"), EventArgs ("NSError", true)]
		void LoadingMapFailed (MKMapView mapView, NSError error);
	
		[Export ("mapView:viewForAnnotation:"), DelegateName ("MKMapViewAnnotation"), DefaultValue (null)]
#if XAMCORE_2_0
		MKAnnotationView GetViewForAnnotation (MKMapView mapView, IMKAnnotation annotation);
#else
		MKAnnotationView GetViewForAnnotation (MKMapView mapView, NSObject annotation);
#endif // !XAMCORE_2_0
	
		[Export ("mapView:didAddAnnotationViews:"), EventArgs ("MKMapViewAnnotation")]
		void DidAddAnnotationViews (MKMapView mapView, MKAnnotationView [] views);
	
#if !MONOMAC
		[NoTV]
		[Export ("mapView:annotationView:calloutAccessoryControlTapped:"), EventArgs ("MKMapViewAccessoryTapped")]
		void CalloutAccessoryControlTapped (MKMapView mapView, MKAnnotationView view, UIControl control);
#endif // !MONOMAC

		[NoTV]
		[Since (4,0)]
		[Export ("mapView:annotationView:didChangeDragState:fromOldState:"), EventArgs ("MKMapViewDragState")]
		void ChangedDragState (MKMapView mapView, MKAnnotationView annotationView, MKAnnotationViewDragState newState, MKAnnotationViewDragState oldState);

#if !MONOMAC && !TVOS
		[Export ("mapView:viewForOverlay:"), DelegateName ("MKMapViewOverlay"), DefaultValue (null)]
		[Availability (Introduced = Platform.iOS_4_0, Deprecated = Platform.iOS_7_0, Message = "Use MKOverlayRenderer.RendererForOverlay instead")]
#if XAMCORE_2_0
		MKOverlayView GetViewForOverlay (MKMapView mapView, IMKOverlay overlay);
#else
		MKOverlayView GetViewForOverlay (MKMapView mapView, NSObject overlay);
#endif // XAMCORE_2_0

		[Export ("mapView:didAddOverlayViews:"), EventArgs ("MKOverlayViews")]
		[Availability (Introduced = Platform.iOS_4_0, Deprecated = Platform.iOS_7_0, Message = "Use DidAddOverlayRenderers instead")]
		void DidAddOverlayViews (MKMapView mapView, MKOverlayView overlayViews);
#endif // !MONOMAC && !TVOS

		[Since (4,0)]
		[Export ("mapView:didSelectAnnotationView:"), EventArgs ("MKAnnotationView")]
		void DidSelectAnnotationView (MKMapView mapView, MKAnnotationView view);

		[Since (4,0)]
		[Export ("mapView:didFailToLocateUserWithError:"), EventArgs ("NSError", true)]
		void DidFailToLocateUser (MKMapView mapView, NSError error);

		[Since (4,0)]
		[Export ("mapView:didDeselectAnnotationView:"), EventArgs ("MKAnnotationView")]
		void DidDeselectAnnotationView (MKMapView mapView, MKAnnotationView view);

		[Since (4,0)]
		[Export ("mapViewWillStartLocatingUser:")]
		void WillStartLocatingUser (MKMapView mapView);

		[Since (4,0)]
		[Export ("mapViewDidStopLocatingUser:")]
		void DidStopLocatingUser (MKMapView mapView);

		[Since (4,0)]
		[Export ("mapView:didUpdateUserLocation:"), EventArgs ("MKUserLocation")]
		void DidUpdateUserLocation (MKMapView mapView, MKUserLocation userLocation);

#if !MONOMAC
		[Since (5,0)]
		[Export ("mapView:didChangeUserTrackingMode:animated:"), EventArgs ("MMapViewUserTracking")]
#if XAMCORE_2_0
		void DidChangeUserTrackingMode (MKMapView mapView, MKUserTrackingMode mode, bool animated);
#else
		void DidChageUserTrackingMode (MKMapView mapView, MKUserTrackingMode mode, bool animated);
#endif // XAMCORE_2_0
#endif // !MONOMAC

		[Since (7,0), Export ("mapView:rendererForOverlay:"), DelegateName ("MKRendererForOverlayDelegate"), DefaultValue (null)]
		MKOverlayRenderer OverlayRenderer (MKMapView mapView, IMKOverlay overlay);

		[Since (7,0), Export ("mapView:didAddOverlayRenderers:"), EventArgs ("MKDidAddOverlayRenderers")]
		void DidAddOverlayRenderers (MKMapView mapView, MKOverlayRenderer [] renderers);

		[Since (7,0), Export ("mapViewWillStartRenderingMap:")]
		void WillStartRenderingMap (MKMapView mapView);

		[Since (7,0), Export ("mapViewDidFinishRenderingMap:fullyRendered:"), EventArgs ("MKDidFinishRenderingMap")]
		void DidFinishRenderingMap (MKMapView mapView, bool fullyRendered);
	}
		
	[BaseType (typeof (MKAnnotationView))]
	// crash on Dispose when created from 'init'
	[DisableDefaultCtor]
	[TV (9,2)]
	[Mac (10,9, onlyOn64 : true)]
	interface MKPinAnnotationView {
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		[Export ("initWithAnnotation:reuseIdentifier:")]
#if XAMCORE_2_0
		IntPtr Constructor ([NullAllowed] IMKAnnotation annotation, string reuseIdentifier);
#else
		IntPtr Constructor ([NullAllowed] NSObject annotation, string reuseIdentifier);
#endif

		[NoTV]
		[Export ("pinColor")]
		[Availability (Deprecated = Platform.iOS_9_0, Message = "Use PinTintColor instead")]
		MKPinAnnotationColor PinColor { get; set; }
	
		[Export ("animatesDrop")]
		bool AnimatesDrop { get; set; }

		[iOS(9,0), Mac(10,11)]
		[Appearance]
		[Export ("pinTintColor")]
		[NullAllowed]
		UIColor PinTintColor { get; set; }

		[iOS(9,0), Mac(10,11)]
		[Static, Export ("redPinColor")]
		UIColor RedPinColor { get; }

		[iOS(9,0), Mac(10,11)]
		[Static, Export ("greenPinColor")]
		UIColor GreenPinColor { get; }

		[iOS(9,0), Mac(10,11)]
		[Static, Export ("purplePinColor")]
		UIColor PurplePinColor { get; }
	}

#if IOS
	// This requires the AddressBook framework, which afaict isn't bound on Mac, tvOS and watchOS yet
	[StrongDictionary ("global::XamCore.AddressBook.ABPersonAddressKey")]
	interface MKPlacemarkAddress {
		[Export ("City")]
		string City { get; set; }
		[Export ("Country")]
		string Country { get; set; }
		[Export ("CountryCode")]
		string CountryCode { get; set; }
		[Export ("State")]
		string State { get; set; }
		[Export ("Street")]
		string Street { get; set; }
		[Export ("Zip")]
		string Zip { get; set; }
	}
#endif // !MONOMAC
#endif // !WATCH

	[BaseType (typeof (CLPlacemark))]
	// crash (at least) when calling 'description' when instance is created by 'init'
	[DisableDefaultCtor]
	[TV (9,2)]
	[Mac (10,9, onlyOn64 : true)]
	interface MKPlacemark : MKAnnotation, NSCopying {
		[Export ("initWithCoordinate:addressDictionary:")]
		IntPtr Constructor (CLLocationCoordinate2D coordinate, [NullAllowed] NSDictionary addressDictionary);

#if IOS
		// This requires the AddressBook framework, which afaict isn't bound on Mac, tvOS and watchOS yet
		[Wrap ("this (coordinate, addressDictionary == null ? null : addressDictionary.Dictionary)")]
		IntPtr Constructor (CLLocationCoordinate2D coordinate, MKPlacemarkAddress addressDictionary);
#endif // !MONOMAC && !WATCH

		[Watch (3,0)][TV (10,0)][iOS (10,0)]
		[NoMac]
		[Export ("initWithCoordinate:")]
		IntPtr Constructor (CLLocationCoordinate2D coordinate);

#if !TVOS && !MONOMAC && XAMCORE_2_0
		[Watch (3,0)][iOS (10,0)]
		[NoTV][NoMac]
		[Export ("initWithCoordinate:postalAddress:")]
		IntPtr Constructor (CLLocationCoordinate2D coordinate, CNPostalAddress postalAddress);
#endif
	
		[Export ("countryCode")]
		string CountryCode { get; }
	}
		
#if IOS
	[BaseType (typeof (NSObject))]
	[Availability (Introduced = Platform.iOS_3_0, Deprecated = Platform.iOS_5_0, Message = "Use CoreLocation.CLGeocoder instead")]
	// crash (at least) at Dispose time when instance is created by 'init'
	[DisableDefaultCtor]
	interface MKReverseGeocoder {
		[Export ("initWithCoordinate:")]
		IntPtr Constructor (CLLocationCoordinate2D coordinate);
	
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Wrap ("WeakDelegate")]
		[Protocolize]
		MKReverseGeocoderDelegate Delegate { get; set; }
	
		[Export ("coordinate")]
		CLLocationCoordinate2D coordinate { get; }
	
		[Export ("start")]
		void Start ();
	
		[Export ("querying")]
		bool Querying { [Bind ("isQuerying")] get; }
	
		[Export ("cancel")]
		void Cancel ();
	
		[Since (3,2)]
		[Export ("placemark")]
		MKPlacemark Placemark { get; }
	}

#pragma warning disable 618
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface MKReverseGeocoderDelegate {
		[Abstract]
		[Export ("reverseGeocoder:didFailWithError:")]
		void FailedWithError (MKReverseGeocoder geocoder, NSError error);

		[Abstract]
		[Export ("reverseGeocoder:didFindPlacemark:")]
		void FoundWithPlacemark (MKReverseGeocoder geocoder, MKPlacemark placemark);
	}
#pragma warning restore 618

	[Availability (Introduced = Platform.iOS_4_0, Deprecated = Platform.iOS_7_0, Message = "Use MKOverlayRenderer instead")]
	[BaseType (typeof (UIView))]
	interface MKOverlayView {
		[Export ("overlay")]
#if XAMCORE_2_0
		IMKOverlay Overlay { get; }
#else
		NSObject Overlay { get; }
#endif

		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		[DesignatedInitializer]
		[Export ("initWithOverlay:")]
#if XAMCORE_2_0
		IntPtr Constructor (IMKOverlay overlay);
#else
		IntPtr Constructor (NSObject overlay);
#endif

		[Export ("pointForMapPoint:")]
		[ThreadSafe]
		CGPoint PointForMapPoint (MKMapPoint mapPoint);

		[Export ("mapPointForPoint:")]
		[ThreadSafe]
		MKMapPoint MapPointForPoint (CGPoint point);

		[Export ("rectForMapRect:")]
		[ThreadSafe]
		CGRect RectForMapRect (MKMapRect mapRect);

		[Export ("mapRectForRect:")]
		[ThreadSafe]
		MKMapRect MapRectForRect (CGRect rect);

		[Export ("canDrawMapRect:zoomScale:")]
		bool CanDrawMapRect (MKMapRect mapRect, /* MKZoomScale */ nfloat zoomScale);

		[Export ("drawMapRect:zoomScale:inContext:")]
		[ThreadSafe]
		void DrawMapRect (MKMapRect mapRect, /* MKZoomScale */ nfloat zoomScale, CGContext context);

		[Export ("setNeedsDisplayInMapRect:")]
		void SetNeedsDisplay (MKMapRect mapRect);

		[Export ("setNeedsDisplayInMapRect:zoomScale:")]
		void SetNeedsDisplay (MKMapRect mapRect, /* MKZoomScale */ nfloat zoomScale);
	}

	[Availability (Introduced = Platform.iOS_4_0, Deprecated = Platform.iOS_7_0, Message = "Use MKOverlayPathRenderer instead")]
	[BaseType (typeof (MKOverlayView))]
	interface MKOverlayPathView {
		[Export ("initWithOverlay:")]
#if XAMCORE_2_0
		IntPtr Constructor (IMKOverlay overlay);
#else
		IntPtr Constructor (NSObject overlay);
#endif

		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		[NullAllowed] // by default this property is null
		[Export ("fillColor", ArgumentSemantic.Retain)]
		UIColor FillColor { get; set;  }

		[NullAllowed] // by default this property is null
		[Export ("strokeColor", ArgumentSemantic.Retain)]
		UIColor StrokeColor { get; set;  }

		[Export ("lineWidth")]
		nfloat LineWidth { get; set;  }

		[Export ("lineJoin")]
		CGLineJoin LineJoin { get; set;  }

		[Export ("lineCap")]
		CGLineCap Linecap { get; set;  }

		[Export ("miterLimit")]
		nfloat MiterLimit  { get; set;  }

		[Export ("lineDashPhase")]
		nfloat LineDashPhase { get; set;  }

		[NullAllowed] // by default this property is null
		[Export ("lineDashPattern", ArgumentSemantic.Copy)]
		NSNumber [] LineDashPattern { get; set;  }

		[NullAllowed]
		[Export ("path")]
		CGPath Path { get; set;  }

		[Export ("createPath")]
		void CreatePath ();

		[Export ("invalidatePath")]
		void InvalidatePath ();

		[Export ("applyStrokePropertiesToContext:atZoomScale:")]
		void ApplyStrokeProperties (CGContext context, /* MKZoomScale */ nfloat zoomScale);

		[Export ("applyFillPropertiesToContext:atZoomScale:")]
		void ApplyFillProperties (CGContext context, /* MKZoomScale */ nfloat zoomScale);

		[Export ("strokePath:inContext:")]
		void StrokePath (CGPath path, CGContext context);

		[Export ("fillPath:inContext:")]
		void FillPath (CGPath path, CGContext context);
	}
#endif // IOS

#if !WATCH
	[TV (9,2)]
	[Since (4,0)]
	[Mac (10,9, onlyOn64 : true)]
#if XAMCORE_2_0 || MONOMAC
	[BaseType (typeof (NSObject))]
	[Abstract]
	interface MKShape : MKAnnotation {
#else
	[BaseType (typeof (MKAnnotation))]
	interface MKShape {
#endif
		[NullAllowed] // by default this property is null
		[Export ("title", ArgumentSemantic.Copy)]
#if XAMCORE_2_0 || MONOMAC
		new
#endif
		string Title { get; set; }
	
		[NullAllowed] // by default this property is null
		[Export ("subtitle", ArgumentSemantic.Copy)]
#if XAMCORE_2_0 || MONOMAC
		new
#endif
		string Subtitle { get; set; } 
	}

	[TV (9,2)]
	[Mac (10,9, onlyOn64 : true)]
	[Since (4,0)]
	[BaseType (typeof (MKShape))]
	interface MKPointAnnotation {
		[Export ("coordinate")]
		CLLocationCoordinate2D Coordinate { get; set; }
}

#if !MONOMAC && !TVOS
	[Availability (Introduced = Platform.iOS_4_0, Deprecated = Platform.iOS_7_0, Message = "Use MKPolygonRenderer instead")]
	[BaseType (typeof (MKOverlayPathView))]
	interface MKPolygonView {
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		[Export ("initWithPolygon:")]
		[PostGet ("Polygon")]
		IntPtr Constructor (MKPolygon polygon);
		
		[Export ("polygon")]
		MKPolygon Polygon { get;  }
	}
#endif // !MONOMAC && !TVOS

	[ThreadSafe]
	[TV (9,2)]
	[Since (4,0)]
	[Mac (10,9, onlyOn64 : true)]
	[BaseType (typeof (MKMultiPoint))]
	interface MKPolygon : MKOverlay {
		[Export ("interiorPolygons")]
		MKPolygon [] InteriorPolygons { get;  }

		[Static]
		[Internal]
		[Export ("polygonWithPoints:count:")]
		MKPolygon _FromPoints (IntPtr points, nint count);

		[Static]
#if XAMCORE_2_0
		[Internal]
#endif
		[Export ("polygonWithPoints:count:interiorPolygons:")]
		MKPolygon _FromPoints (IntPtr points, nint count, MKPolygon [] interiorPolygons);

		[Static]
		[Export ("polygonWithCoordinates:count:"), Internal]
		MKPolygon _FromCoordinates (IntPtr coords, nint count);

		[Static]
		[Internal]
		[Export ("polygonWithCoordinates:count:interiorPolygons:")]
		MKPolygon _FromCoordinates (IntPtr coords, nint count, MKPolygon [] interiorPolygons);

		#region MKAnnotation
		[Export ("coordinate")]
		CLLocationCoordinate2D Coordinate { get; }
		// note: setCoordinate: is not mandatory and is not implemented for MKPolygon (see unit tests)
		#endregion
	}

	[ThreadSafe]
	[TV (9,2)]
	[Since (4,0)]
	[Mac (10,9, onlyOn64 : true)]
	[BaseType (typeof (MKMultiPoint))]
	interface MKPolyline : MKOverlay {
		[Static]
		[Export ("polylineWithCoordinates:count:")]
		[Internal]
		MKPolyline _FromCoordinates (IntPtr coords, nint count);
		
		[Static]
		[Internal]
		[Export ("polylineWithPoints:count:")]
		MKPolyline _FromPoints (IntPtr points, nint count);

		#region MKAnnotation
		[Export ("coordinate")]
		CLLocationCoordinate2D Coordinate { get; }
		// note: setCoordinate: is not mandatory and is not implemented for MKPolygon (see unit tests)
		#endregion
	}

#if !MONOMAC && !TVOS
	[Availability (Introduced = Platform.iOS_4_0, Deprecated = Platform.iOS_7_0, Message = "Use MKPolylineRenderer instead")]
	[BaseType (typeof (MKOverlayPathView))]
	interface MKPolylineView {
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		[Export ("initWithPolyline:")]
		[PostGet ("Polyline")]
		IntPtr Constructor (MKPolyline polyline);
		
		[Export ("polyline")]
		MKPolyline Polyline { get;  }
	}
#endif // !MONOMAC && !TVOS

	[BaseType (typeof (MKShape))]
	[TV (9,2)]
	[Since (4,0)]
	[Mac (10,9, onlyOn64 : true)]
	interface MKMultiPoint {
		[Export ("points"), Internal]
		IntPtr _Points { get;  }

		[Export ("pointCount")]
		nint PointCount { get; }

		[Export ("getCoordinates:range:"), Internal]
		void GetCoords (IntPtr dest, NSRange range);
	}

	[BaseType (typeof (NSObject))]
	[TV (9,2)]
	[Mac (10,9, onlyOn64 : true)]
	interface MKUserLocation : IMKAnnotation { // This is wrong. It should be MKAnnotation but we can't due to API compat. When you fix this remove hack in generator.cs to enable warning again
		[Export ("updating")]
		bool Updating { [Bind ("isUpdating")] get; }
		
		[Export ("coordinate")]
		CLLocationCoordinate2D Coordinate { get; set; }
		
		[Export ("location", ArgumentSemantic.Retain)]
		CLLocation Location { get; }

		[Export ("title", ArgumentSemantic.Copy)]
		string Title { get; set; }
		
		[NullAllowed] // by default this property is null
		[Export ("subtitle", ArgumentSemantic.Copy)]
		string Subtitle { get; set; }
		
		[NoTV]
		[Since (5,0)]
		[Export ("heading", ArgumentSemantic.Retain)]
		CLHeading Heading { get; }
	}

#if !MONOMAC
	[NoTV]
	[Since (5,0)]
	[BaseType (typeof (UIBarButtonItem))]
	interface MKUserTrackingBarButtonItem {
		[NullAllowed] // by default this property is null
		[Export ("mapView", ArgumentSemantic.Retain)]
		MKMapView MapView { get; set;  }

		[DesignatedInitializer]
		[Export ("initWithMapView:")]
		[PostGet ("MapView")]
		IntPtr Constructor (MKMapView mapView);
	}
#endif // !MONOMAC

	delegate void MKLocalSearchCompletionHandler (MKLocalSearchResponse response, NSError error);

	[TV (9,2)]
	[Since (6,1)]
	[Mac (10,9, onlyOn64 : true)]
	[BaseType (typeof (NSObject))]
	[ThreadSafe]
#if !XAMCORE_2_0 && !MONOMAC
	[Protocol] // This isn't right
#endif
	[DisableDefaultCtor] // crash on iOS8 beta
	interface MKLocalSearch {

		[DesignatedInitializer]
		[Export ("initWithRequest:")]
		IntPtr Constructor (MKLocalSearchRequest request);

		[Export ("startWithCompletionHandler:")]
		[Async]
		void Start (MKLocalSearchCompletionHandler completionHandler);

		[Export ("cancel")]
		void Cancel ();

		[Export ("searching")]
		bool IsSearching { [Bind ("isSearching")] get; }
	}

	[TV (9,2)]
	[Since (6,1)]
	[Mac (10,9, onlyOn64 : true)]
	[BaseType (typeof (NSObject))]
	[ThreadSafe]
#if !XAMCORE_2_0 && !MONOMAC
	[Protocol] // This isn't right
#endif
	interface MKLocalSearchRequest : NSCopying {

		[TV (9,2)][NoWatch][iOS (9,3)][Mac (10,11,4, onlyOn64 : true)]
		[Export ("initWithCompletion:")]
		IntPtr Constructor (MKLocalSearchCompletion completion);

		[Export ("naturalLanguageQuery", ArgumentSemantic.Copy)]
		[NullAllowed]
		string NaturalLanguageQuery { get; set; }

		[Export ("region", ArgumentSemantic.Assign)]
		MKCoordinateRegion Region { get; set; }
	}

	[TV (9,2)]
	[Since (6,1)]
	[Mac (10,9, onlyOn64 : true)]
	[BaseType (typeof (NSObject))]
	[ThreadSafe]
	// Objective-C exception thrown.  Name: NSInvalidArgumentException Reason: *** setObjectForKey: object cannot be nil (key: mapItems)
	[DisableDefaultCtor]
#if !XAMCORE_2_0 && !MONOMAC
	[Protocol] // This isn't right
#endif
	interface MKLocalSearchResponse {

		[Export ("boundingRegion")]
		MKCoordinateRegion Region { get; }

		[Export ("mapItems")]
		MKMapItem[] MapItems { get; }
	}

	[TV (9,2)]
	[Since (7,0), BaseType (typeof (MKOverlayPathRenderer))]
	[Mac (10,9, onlyOn64 : true)]
	partial interface MKCircleRenderer {

		[Export ("initWithCircle:")]
		IntPtr Constructor (MKCircle circle);

		[Export ("circle")]
		MKCircle Circle { get; }
	}

	[TV (9,2)]
	[Since (7,0), BaseType (typeof (NSObject))]
	[Mac (10,9, onlyOn64 : true)]
	[DisableDefaultCtor] // NSInvalidArgumentException Reason: Cannot initialize MKDirections with nil request
	partial interface MKDirections {

		[DesignatedInitializer]
		[Export ("initWithRequest:")]
		IntPtr Constructor (MKDirectionsRequest request);

		[Export ("calculateDirectionsWithCompletionHandler:")]
		[Async]
		void CalculateDirections (MKDirectionsHandler completionHandler);

		[Export ("cancel")]
		void Cancel ();

		[Export ("calculating")]
		bool Calculating { [Bind ("isCalculating")] get; }

		[Export ("calculateETAWithCompletionHandler:")]
		[Async]
		void CalculateETA (MKETAHandler completionHandler);
	}

	delegate void MKDirectionsHandler (MKDirectionsResponse response, NSError error);

	delegate void MKETAHandler (MKETAResponse response, NSError error);

	[TV (9,2)]
	[Since (7,0), BaseType (typeof (NSObject))]
	[Mac (10,9, onlyOn64 : true)]
	partial interface MKETAResponse {
		[Export ("source")]
		MKMapItem Source { get; }

		[Export ("destination")]
		MKMapItem Destination { get; }

		[Export ("expectedTravelTime")]
		double ExpectedTravelTime { get; }

		[iOS (9,0)][Mac (10,11)]
		[Export ("distance")]
		double /* CLLocationDistance */ Distance { get; }

		[Export ("transportType")]
		[iOS (9,0), Mac(10,11)]
		MKDirectionsTransportType TransportType { get; }

		[Export ("expectedArrivalDate")]
		[iOS (9,0), Mac(10,11)]
		NSDate ExpectedArrivalDate { get; }

		[Export ("expectedDepartureDate")]
		[iOS (9,0), Mac(10,11)]
		NSDate ExpectedDepartureDate { get; }
	}

	[TV (9,2)]
	[Since (7,0), BaseType (typeof (NSObject))]
	[Mac (10,9, onlyOn64 : true)]
	partial interface MKDirectionsResponse {

		[Export ("source")]
		MKMapItem Source { get; }

		[Export ("destination")]
		MKMapItem Destination { get; }

		[Export ("routes")]
		MKRoute [] Routes { get; }
	}

	[TV (9,2)]
	[Since (7,0), BaseType (typeof (NSObject))]
	[Mac (10,9, onlyOn64 : true)]
	partial interface MKRoute {

		[Export ("name")]
		string Name { get; }

		[Export ("advisoryNotices")]
		string [] AdvisoryNotices { get; }

		[Export ("distance")]
		double Distance { get; }

		[Export ("expectedTravelTime")]
		double ExpectedTravelTime { get; }

		[Export ("transportType")]
		MKDirectionsTransportType TransportType { get; }

		[Export ("polyline")]
		MKPolyline Polyline { get; }

		[Export ("steps")]
		MKRouteStep [] Steps { get; }
	}

	[TV (9,2)]
	[Since (7,0), BaseType (typeof (NSObject))]
	[Mac (10,9, onlyOn64 : true)]
	partial interface MKRouteStep {

		[Export ("instructions")]
		string Instructions { get; }

		[Export ("notice")]
		[NullAllowed]
		string Notice { get; }

		[Export ("polyline")]
		MKPolyline Polyline { get; }

		[Export ("distance")]
		double Distance { get; }

		[Export ("transportType")]
		MKDirectionsTransportType TransportType { get; }
	}
#endif // !WATCH

	[TV (9,2)]
	[Since (7,0), BaseType (typeof (NSFormatter))]
	[Mac (10,9, onlyOn64 : true)]
	partial interface MKDistanceFormatter {

		[Export ("stringFromDistance:")]
		string StringFromDistance (double distance);

		[Export ("distanceFromString:")]
		double DistanceFromString (string distance);

		[Export ("locale", ArgumentSemantic.Copy)]
		NSLocale Locale { get; set; }

		[Export ("units", ArgumentSemantic.Assign)]
		MKDistanceFormatterUnits Units { get; set; }

		[Export ("unitStyle", ArgumentSemantic.Assign)]
		MKDistanceFormatterUnitStyle UnitStyle { get; set; }
	}

#if !WATCH
	[TV (9,2)]
	[Since (7,0), BaseType (typeof (MKPolyline))]
	[Mac (10,9, onlyOn64 : true)]
	partial interface MKGeodesicPolyline {

		[Static, Export ("polylineWithPoints:count:")]
		[Internal]
		MKGeodesicPolyline PolylineWithPoints (IntPtr points, nint count);

		[Static, Export ("polylineWithCoordinates:count:")]
		[Internal]
		MKGeodesicPolyline PolylineWithCoordinates (IntPtr coords, nint count);
	}

	[TV (9,2)]
	[Since (7,0), BaseType (typeof (NSObject))]
	[Mac (10,9, onlyOn64 : true)]
	partial interface MKMapCamera : NSCopying, NSSecureCoding {

		[Export ("centerCoordinate")]
		CLLocationCoordinate2D CenterCoordinate { get; set; }

		[Export ("heading")]
		double Heading { get; set; }

		[Export ("pitch")]
		nfloat Pitch { get; set; }

		[Export ("altitude")]
		double Altitude { get; set; }

		[Static, Export ("camera")]
		MKMapCamera Camera { get; }

		[Static, Export ("cameraLookingAtCenterCoordinate:fromEyeCoordinate:eyeAltitude:")]
		MKMapCamera CameraLookingAtCenterCoordinate (CLLocationCoordinate2D centerCoordinate, CLLocationCoordinate2D eyeCoordinate, double eyeAltitude);

		[Static]
		[iOS(9,0)][Mac(10,11)]
		[Export ("cameraLookingAtCenterCoordinate:fromDistance:pitch:heading:")]
		MKMapCamera CameraLookingAtCenterCoordinate (CLLocationCoordinate2D centerCoordinate, double locationDistance, nfloat pitch, double locationDirectionHeading);
		
	}

	[TV (9,2)]
	[Since (7,0), BaseType (typeof (NSObject))]
	[Mac (10,9, onlyOn64 : true)]
	partial interface MKMapSnapshot {

		[Export ("image")]
		UIImage Image { get; }

		[Export ("pointForCoordinate:")]
		CGPoint PointForCoordinate (CLLocationCoordinate2D coordinate);
	}

	[TV (9,2)]
	[Since (7,0), BaseType (typeof (NSObject))]
	[Mac (10,9, onlyOn64 : true)]
	partial interface MKMapSnapshotOptions : NSCopying {

		[Export ("camera", ArgumentSemantic.Copy)]
		MKMapCamera Camera { get; set; }

		[Export ("mapRect", ArgumentSemantic.Assign)]
		MKMapRect MapRect { get; set; }

		[Export ("region", ArgumentSemantic.Assign)]
		MKCoordinateRegion Region { get; set; }

		[Export ("mapType", ArgumentSemantic.Assign)]
		MKMapType MapType { get; set; }

		[Export ("size", ArgumentSemantic.Assign)]
		CGSize Size { get; set; }

#if !MONOMAC
		[Export ("scale", ArgumentSemantic.Assign)]
		nfloat Scale { get; set; }
#endif

		[Export ("showsPointsOfInterest")]
		bool ShowsPointsOfInterest { get; set; }

		[Export ("showsBuildings")]
		bool ShowsBuildings { get; set; }
	}

	[TV (9,2)]
	[Since (7,0), BaseType (typeof (NSObject))]
	[Mac (10,9, onlyOn64 : true)]
	partial interface MKMapSnapshotter {

		[DesignatedInitializer]
		[Export ("initWithOptions:")]
		IntPtr Constructor (MKMapSnapshotOptions options);

		[Export ("startWithCompletionHandler:")]
		[Async]
		void Start (MKMapSnapshotCompletionHandler completionHandler);

		[Export ("startWithQueue:completionHandler:")]
		[Async]
		void Start (DispatchQueue queue, MKMapSnapshotCompletionHandler completionHandler);

		[Export ("cancel")]
		void Cancel ();

		[Export ("loading")]
		bool Loading { [Bind ("isLoading")] get; }
	}

	delegate void MKMapSnapshotCompletionHandler (MKMapSnapshot snapshot, NSError error);

	[TV (9,2)]
	[Since (7,0), BaseType (typeof (MKOverlayRenderer))]
	[Mac (10,9, onlyOn64 : true)]
	[ThreadSafe]
	partial interface MKOverlayPathRenderer {

		[Export ("initWithOverlay:")]
		IntPtr Constructor (IMKOverlay overlay);

		[NullAllowed] // by default this property is null
		[Export ("fillColor", ArgumentSemantic.Retain)]
		UIColor FillColor { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("strokeColor", ArgumentSemantic.Retain)]
		UIColor StrokeColor { get; set; }

		[Export ("lineWidth")]
		nfloat LineWidth { get; set; }

		[Export ("lineJoin")]
		CGLineJoin LineJoin { get; set; }

		[Export ("lineCap")]
		CGLineCap LineCap { get; set; }

		[Export ("miterLimit")]
		nfloat MiterLimit { get; set; }

		[Export ("lineDashPhase")]
		nfloat LineDashPhase { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("lineDashPattern", ArgumentSemantic.Copy)]
		NSNumber [] LineDashPattern { get; set; }

		[Export ("createPath")]
		void CreatePath ();

		[NullAllowed]
		[Export ("path")]
		CGPath Path { get; set; }

		[Export ("invalidatePath")]
		void InvalidatePath ();

		[Export ("applyStrokePropertiesToContext:atZoomScale:")]
		void ApplyStrokePropertiesToContext (CGContext context, /* MKZoomScale */ nfloat zoomScale);

		[Export ("applyFillPropertiesToContext:atZoomScale:")]
		void ApplyFillPropertiesToContext (CGContext context, /* MKZoomScale */ nfloat zoomScale);

		[Export ("strokePath:inContext:")]
		void StrokePath (CGPath path, CGContext context);

		[Export ("fillPath:inContext:")]
		void FillPath (CGPath path, CGContext context);
	}

	[TV (9,2)]
	[Since (7,0), BaseType (typeof (NSObject))]
	[Mac (10,9, onlyOn64 : true)]
	partial interface MKOverlayRenderer {

		[DesignatedInitializer]
		[Export ("initWithOverlay:")]
		IntPtr Constructor (IMKOverlay overlay);

		[Export ("overlay")]
		IMKOverlay Overlay { get; }

		[ThreadSafe]
		[Export ("pointForMapPoint:")]
		CGPoint PointForMapPoint (MKMapPoint mapPoint);

		[ThreadSafe]
		[Export ("mapPointForPoint:")]
		MKMapPoint MapPointForPoint (CGPoint point);

		[ThreadSafe]
		[Export ("rectForMapRect:")]
		CGRect RectForMapRect (MKMapRect mapRect);

		[ThreadSafe]
		[Export ("mapRectForRect:")]
		MKMapRect MapRectForRect (CGRect rect);

		[Export ("canDrawMapRect:zoomScale:")]
		bool CanDrawMapRect (MKMapRect mapRect, /* MKZoomScale */ nfloat zoomScale);

		[ThreadSafe]
		[Export ("drawMapRect:zoomScale:inContext:")]
		void DrawMapRect (MKMapRect mapRect, /* MKZoomScale */ nfloat zoomScale, CGContext context);

		[Export ("setNeedsDisplay")]
		void SetNeedsDisplay ();

		[Export ("setNeedsDisplayInMapRect:")]
		void SetNeedsDisplay (MKMapRect mapRect);

		[Export ("setNeedsDisplayInMapRect:zoomScale:")]
		void SetNeedsDisplay (MKMapRect mapRect, /* MKZoomScale */ nfloat zoomScale);

		[Export ("alpha")]
		nfloat Alpha { get; set; }

		[Export ("contentScaleFactor")]
		nfloat ContentScaleFactor { get; }
	}

	[TV (9,2)]
	[Since (7,0), BaseType (typeof (MKOverlayPathRenderer))]
	[Mac (10,9, onlyOn64 : true)]
	partial interface MKPolygonRenderer {

		[Export ("initWithPolygon:")]
		IntPtr Constructor (MKPolygon polygon);

		[Export ("polygon")]
		MKPolygon Polygon { get; }
	}

	[TV (9,2)]
	[Since (7,0), BaseType (typeof (MKOverlayPathRenderer))]
	[Mac (10,9, onlyOn64 : true)]
	partial interface MKPolylineRenderer {

		[Export ("initWithPolyline:")]
		IntPtr Constructor (MKPolyline polyline);

		[Export ("polyline")]
		MKPolyline Polyline { get; }
	}

	[ThreadSafe]
	[TV (9,2)]
	[Mac (10,9, onlyOn64 : true)]
#if XAMCORE_2_0 || MONOMAC
	[Since (7,0), BaseType (typeof (NSObject))]
	partial interface MKTileOverlay : MKOverlay {
#else
	[Since (7,0), BaseType (typeof (MKOverlay))]
	partial interface MKTileOverlay {
#endif
		[DesignatedInitializer]
		[Export ("initWithURLTemplate:")]
		IntPtr Constructor (string URLTemplate);

		[Export ("tileSize")]
		CGSize TileSize { get; set; }

		[Export ("geometryFlipped")]
		bool GeometryFlipped { [Bind ("isGeometryFlipped")] get; set; }

		[Export ("minimumZ")]
		nint MinimumZ { get; set; }

		[Export ("maximumZ")]
		nint MaximumZ { get; set; }

		[Export ("URLTemplate")]
		string URLTemplate { get; }

		[Export ("canReplaceMapContent")]
#if XAMCORE_2_0 || MONOMAC
		new
#endif
		bool CanReplaceMapContent { get; set; }

		[Export ("URLForTilePath:")]
		NSUrl URLForTilePath (MKTileOverlayPath path);

		[Export ("loadTileAtPath:result:")]
		void LoadTileAtPath (MKTileOverlayPath path, MKTileOverlayLoadTileCompletionHandler result);

#if MONOMAC || XAMCORE_2_0
		[Export ("coordinate")]
		CLLocationCoordinate2D Coordinate { get; }
#endif
	}

	delegate void MKTileOverlayLoadTileCompletionHandler (NSData tileData, NSError error);

	[TV (9,2)]
	[Since (7,0), BaseType (typeof (MKOverlayRenderer))]
	// Objective-C exception thrown.  Name: NSInvalidArgumentException Reason: Expected a MKTileOverlay but got (null)
	[DisableDefaultCtor] // throw in iOS8 beta 1 ^
	[Mac (10,9, onlyOn64 : true)]
	partial interface MKTileOverlayRenderer {
		// This ctor is not allowed: NSInvalidArgumentEception Expected a MKTileOverlay
//		[Export ("initWithOverlay:")]
//		IntPtr Constructor (IMKOverlay toverlay);

		[Export ("initWithTileOverlay:")]
		IntPtr Constructor (MKTileOverlay overlay);

		[Export ("reloadData")]
		void ReloadData ();
	}

	[TV (9,2)][NoWatch][iOS (9,3)][Mac(10,11,4)]
	[BaseType (typeof (NSObject))]
#if MONOMAC || XAMCORE_3_0 // Avoid breaking change in iOS
	[DisableDefaultCtor]
#endif
	interface MKLocalSearchCompleter {
		[Export ("queryFragment")]
		string QueryFragment { get; set; }

		[Export ("region", ArgumentSemantic.Assign)]
		MKCoordinateRegion Region { get; set; }

		[Export ("filterType", ArgumentSemantic.Assign)]
		MKSearchCompletionFilterType FilterType { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		[Protocolize]
		MKLocalSearchCompleterDelegate Delegate { get; set; }

		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		[Export ("results", ArgumentSemantic.Strong)]
		MKLocalSearchCompletion[] Results { get; }

		[Export ("searching")]
		bool Searching { [Bind ("isSearching")] get; }

		[Export ("cancel")]
		void Cancel ();
	}

	[TV (9,2)][NoWatch][iOS (9,3)]
	[Protocol]
	[Model]
	[BaseType (typeof (NSObject))]
	interface MKLocalSearchCompleterDelegate {
		[Export ("completerDidUpdateResults:")]
		void DidUpdateResults (MKLocalSearchCompleter completer);

		[Export ("completer:didFailWithError:")]
		void DidFail (MKLocalSearchCompleter completer, NSError error);
	}

	[TV (9,2)][NoWatch][iOS (9,3)]
	[BaseType (typeof(NSObject))]
#if MONOMAC || XAMCORE_3_0 // Avoid breaking change in iOS
	[DisableDefaultCtor]
#endif
	interface MKLocalSearchCompletion {
		[Export ("title", ArgumentSemantic.Strong)]
		string Title { get; }

		// NSValue-wrapped NSRanges
		[Export ("titleHighlightRanges", ArgumentSemantic.Strong)]
		NSValue[] TitleHighlightRanges { get; }

		[Export ("subtitle", ArgumentSemantic.Strong)]
		string Subtitle { get; }

		// NSValue-wrapped NSRanges
		[Export ("subtitleHighlightRanges", ArgumentSemantic.Strong)]
		NSValue[] SubtitleHighlightRanges { get; }
	}

#endif // !WATCH

	[Category]
	[BaseType (typeof (NSUserActivity))]
	interface NSUserActivity_MKMapItem {
		[Watch (3,0)][TV (10,0)][iOS (10,0)][Mac (10,12)]
		[Export ("mapItem")]
		MKMapItem GetMapItem ();

		[Watch (3,0)][TV (10,0)][iOS (10,0)][Mac (10,12)]
		[Export ("setMapItem:")]
		void SetMapItem (MKMapItem item);
	}
}
#endif // XAMCORE_2_0 || !MONOMAC
