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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace MapKit {
	[Register("MKMapView", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MKMapView : global::AppKit.NSView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddAnnotation_X = "addAnnotation:";
		static readonly NativeHandle selAddAnnotation_XHandle = Selector.GetHandle ("addAnnotation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddAnnotations_X = "addAnnotations:";
		static readonly NativeHandle selAddAnnotations_XHandle = Selector.GetHandle ("addAnnotations:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddOverlay_X = "addOverlay:";
		static readonly NativeHandle selAddOverlay_XHandle = Selector.GetHandle ("addOverlay:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddOverlay_Level_X = "addOverlay:level:";
		static readonly NativeHandle selAddOverlay_Level_XHandle = Selector.GetHandle ("addOverlay:level:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddOverlays_X = "addOverlays:";
		static readonly NativeHandle selAddOverlays_XHandle = Selector.GetHandle ("addOverlays:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddOverlays_Level_X = "addOverlays:level:";
		static readonly NativeHandle selAddOverlays_Level_XHandle = Selector.GetHandle ("addOverlays:level:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnnotationVisibleRectX = "annotationVisibleRect";
		static readonly NativeHandle selAnnotationVisibleRectXHandle = Selector.GetHandle ("annotationVisibleRect");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnnotationsX = "annotations";
		static readonly NativeHandle selAnnotationsXHandle = Selector.GetHandle ("annotations");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnnotationsInMapRect_X = "annotationsInMapRect:";
		static readonly NativeHandle selAnnotationsInMapRect_XHandle = Selector.GetHandle ("annotationsInMapRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCameraX = "camera";
		static readonly NativeHandle selCameraXHandle = Selector.GetHandle ("camera");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCameraBoundaryX = "cameraBoundary";
		static readonly NativeHandle selCameraBoundaryXHandle = Selector.GetHandle ("cameraBoundary");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCameraZoomRangeX = "cameraZoomRange";
		static readonly NativeHandle selCameraZoomRangeXHandle = Selector.GetHandle ("cameraZoomRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCenterCoordinateX = "centerCoordinate";
		static readonly NativeHandle selCenterCoordinateXHandle = Selector.GetHandle ("centerCoordinate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertCoordinate_ToPointToView_X = "convertCoordinate:toPointToView:";
		static readonly NativeHandle selConvertCoordinate_ToPointToView_XHandle = Selector.GetHandle ("convertCoordinate:toPointToView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertPoint_ToCoordinateFromView_X = "convertPoint:toCoordinateFromView:";
		static readonly NativeHandle selConvertPoint_ToCoordinateFromView_XHandle = Selector.GetHandle ("convertPoint:toCoordinateFromView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertRect_ToRegionFromView_X = "convertRect:toRegionFromView:";
		static readonly NativeHandle selConvertRect_ToRegionFromView_XHandle = Selector.GetHandle ("convertRect:toRegionFromView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertRegion_ToRectToView_X = "convertRegion:toRectToView:";
		static readonly NativeHandle selConvertRegion_ToRectToView_XHandle = Selector.GetHandle ("convertRegion:toRectToView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDequeueReusableAnnotationViewWithIdentifier_X = "dequeueReusableAnnotationViewWithIdentifier:";
		static readonly NativeHandle selDequeueReusableAnnotationViewWithIdentifier_XHandle = Selector.GetHandle ("dequeueReusableAnnotationViewWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDequeueReusableAnnotationViewWithIdentifier_ForAnnotation_X = "dequeueReusableAnnotationViewWithIdentifier:forAnnotation:";
		static readonly NativeHandle selDequeueReusableAnnotationViewWithIdentifier_ForAnnotation_XHandle = Selector.GetHandle ("dequeueReusableAnnotationViewWithIdentifier:forAnnotation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeselectAnnotation_Animated_X = "deselectAnnotation:animated:";
		static readonly NativeHandle selDeselectAnnotation_Animated_XHandle = Selector.GetHandle ("deselectAnnotation:animated:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExchangeOverlay_WithOverlay_X = "exchangeOverlay:withOverlay:";
		static readonly NativeHandle selExchangeOverlay_WithOverlay_XHandle = Selector.GetHandle ("exchangeOverlay:withOverlay:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExchangeOverlayAtIndex_WithOverlayAtIndex_X = "exchangeOverlayAtIndex:withOverlayAtIndex:";
		static readonly NativeHandle selExchangeOverlayAtIndex_WithOverlayAtIndex_XHandle = Selector.GetHandle ("exchangeOverlayAtIndex:withOverlayAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_X = "initWithFrame:";
		static readonly NativeHandle selInitWithFrame_XHandle = Selector.GetHandle ("initWithFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertOverlay_AboveOverlay_X = "insertOverlay:aboveOverlay:";
		static readonly NativeHandle selInsertOverlay_AboveOverlay_XHandle = Selector.GetHandle ("insertOverlay:aboveOverlay:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertOverlay_AtIndex_X = "insertOverlay:atIndex:";
		static readonly NativeHandle selInsertOverlay_AtIndex_XHandle = Selector.GetHandle ("insertOverlay:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertOverlay_AtIndex_Level_X = "insertOverlay:atIndex:level:";
		static readonly NativeHandle selInsertOverlay_AtIndex_Level_XHandle = Selector.GetHandle ("insertOverlay:atIndex:level:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertOverlay_BelowOverlay_X = "insertOverlay:belowOverlay:";
		static readonly NativeHandle selInsertOverlay_BelowOverlay_XHandle = Selector.GetHandle ("insertOverlay:belowOverlay:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPitchEnabledX = "isPitchEnabled";
		static readonly NativeHandle selIsPitchEnabledXHandle = Selector.GetHandle ("isPitchEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsRotateEnabledX = "isRotateEnabled";
		static readonly NativeHandle selIsRotateEnabledXHandle = Selector.GetHandle ("isRotateEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsScrollEnabledX = "isScrollEnabled";
		static readonly NativeHandle selIsScrollEnabledXHandle = Selector.GetHandle ("isScrollEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsUserLocationVisibleX = "isUserLocationVisible";
		static readonly NativeHandle selIsUserLocationVisibleXHandle = Selector.GetHandle ("isUserLocationVisible");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsZoomEnabledX = "isZoomEnabled";
		static readonly NativeHandle selIsZoomEnabledXHandle = Selector.GetHandle ("isZoomEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMapRectThatFits_X = "mapRectThatFits:";
		static readonly NativeHandle selMapRectThatFits_XHandle = Selector.GetHandle ("mapRectThatFits:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMapRectThatFits_EdgePadding_X = "mapRectThatFits:edgePadding:";
		static readonly NativeHandle selMapRectThatFits_EdgePadding_XHandle = Selector.GetHandle ("mapRectThatFits:edgePadding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMapTypeX = "mapType";
		static readonly NativeHandle selMapTypeXHandle = Selector.GetHandle ("mapType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOverlaysX = "overlays";
		static readonly NativeHandle selOverlaysXHandle = Selector.GetHandle ("overlays");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOverlaysInLevel_X = "overlaysInLevel:";
		static readonly NativeHandle selOverlaysInLevel_XHandle = Selector.GetHandle ("overlaysInLevel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPitchButtonVisibilityX = "pitchButtonVisibility";
		static readonly NativeHandle selPitchButtonVisibilityXHandle = Selector.GetHandle ("pitchButtonVisibility");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPointOfInterestFilterX = "pointOfInterestFilter";
		static readonly NativeHandle selPointOfInterestFilterXHandle = Selector.GetHandle ("pointOfInterestFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredConfigurationX = "preferredConfiguration";
		static readonly NativeHandle selPreferredConfigurationXHandle = Selector.GetHandle ("preferredConfiguration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegionX = "region";
		static readonly NativeHandle selRegionXHandle = Selector.GetHandle ("region");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegionThatFits_X = "regionThatFits:";
		static readonly NativeHandle selRegionThatFits_XHandle = Selector.GetHandle ("regionThatFits:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterClass_ForAnnotationViewWithReuseIdentifier_X = "registerClass:forAnnotationViewWithReuseIdentifier:";
		static readonly NativeHandle selRegisterClass_ForAnnotationViewWithReuseIdentifier_XHandle = Selector.GetHandle ("registerClass:forAnnotationViewWithReuseIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAnnotation_X = "removeAnnotation:";
		static readonly NativeHandle selRemoveAnnotation_XHandle = Selector.GetHandle ("removeAnnotation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAnnotations_X = "removeAnnotations:";
		static readonly NativeHandle selRemoveAnnotations_XHandle = Selector.GetHandle ("removeAnnotations:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveOverlay_X = "removeOverlay:";
		static readonly NativeHandle selRemoveOverlay_XHandle = Selector.GetHandle ("removeOverlay:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveOverlays_X = "removeOverlays:";
		static readonly NativeHandle selRemoveOverlays_XHandle = Selector.GetHandle ("removeOverlays:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRendererForOverlay_X = "rendererForOverlay:";
		static readonly NativeHandle selRendererForOverlay_XHandle = Selector.GetHandle ("rendererForOverlay:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectAnnotation_Animated_X = "selectAnnotation:animated:";
		static readonly NativeHandle selSelectAnnotation_Animated_XHandle = Selector.GetHandle ("selectAnnotation:animated:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedAnnotationsX = "selectedAnnotations";
		static readonly NativeHandle selSelectedAnnotationsXHandle = Selector.GetHandle ("selectedAnnotations");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCamera_X = "setCamera:";
		static readonly NativeHandle selSetCamera_XHandle = Selector.GetHandle ("setCamera:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCamera_Animated_X = "setCamera:animated:";
		static readonly NativeHandle selSetCamera_Animated_XHandle = Selector.GetHandle ("setCamera:animated:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCameraBoundary_X = "setCameraBoundary:";
		static readonly NativeHandle selSetCameraBoundary_XHandle = Selector.GetHandle ("setCameraBoundary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCameraBoundary_Animated_X = "setCameraBoundary:animated:";
		static readonly NativeHandle selSetCameraBoundary_Animated_XHandle = Selector.GetHandle ("setCameraBoundary:animated:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCameraZoomRange_X = "setCameraZoomRange:";
		static readonly NativeHandle selSetCameraZoomRange_XHandle = Selector.GetHandle ("setCameraZoomRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCameraZoomRange_Animated_X = "setCameraZoomRange:animated:";
		static readonly NativeHandle selSetCameraZoomRange_Animated_XHandle = Selector.GetHandle ("setCameraZoomRange:animated:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCenterCoordinate_X = "setCenterCoordinate:";
		static readonly NativeHandle selSetCenterCoordinate_XHandle = Selector.GetHandle ("setCenterCoordinate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCenterCoordinate_Animated_X = "setCenterCoordinate:animated:";
		static readonly NativeHandle selSetCenterCoordinate_Animated_XHandle = Selector.GetHandle ("setCenterCoordinate:animated:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMapType_X = "setMapType:";
		static readonly NativeHandle selSetMapType_XHandle = Selector.GetHandle ("setMapType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPitchButtonVisibility_X = "setPitchButtonVisibility:";
		static readonly NativeHandle selSetPitchButtonVisibility_XHandle = Selector.GetHandle ("setPitchButtonVisibility:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPitchEnabled_X = "setPitchEnabled:";
		static readonly NativeHandle selSetPitchEnabled_XHandle = Selector.GetHandle ("setPitchEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPointOfInterestFilter_X = "setPointOfInterestFilter:";
		static readonly NativeHandle selSetPointOfInterestFilter_XHandle = Selector.GetHandle ("setPointOfInterestFilter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferredConfiguration_X = "setPreferredConfiguration:";
		static readonly NativeHandle selSetPreferredConfiguration_XHandle = Selector.GetHandle ("setPreferredConfiguration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRegion_X = "setRegion:";
		static readonly NativeHandle selSetRegion_XHandle = Selector.GetHandle ("setRegion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRegion_Animated_X = "setRegion:animated:";
		static readonly NativeHandle selSetRegion_Animated_XHandle = Selector.GetHandle ("setRegion:animated:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRotateEnabled_X = "setRotateEnabled:";
		static readonly NativeHandle selSetRotateEnabled_XHandle = Selector.GetHandle ("setRotateEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetScrollEnabled_X = "setScrollEnabled:";
		static readonly NativeHandle selSetScrollEnabled_XHandle = Selector.GetHandle ("setScrollEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectedAnnotations_X = "setSelectedAnnotations:";
		static readonly NativeHandle selSetSelectedAnnotations_XHandle = Selector.GetHandle ("setSelectedAnnotations:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsBuildings_X = "setShowsBuildings:";
		static readonly NativeHandle selSetShowsBuildings_XHandle = Selector.GetHandle ("setShowsBuildings:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsCompass_X = "setShowsCompass:";
		static readonly NativeHandle selSetShowsCompass_XHandle = Selector.GetHandle ("setShowsCompass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsPitchControl_X = "setShowsPitchControl:";
		static readonly NativeHandle selSetShowsPitchControl_XHandle = Selector.GetHandle ("setShowsPitchControl:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsPointsOfInterest_X = "setShowsPointsOfInterest:";
		static readonly NativeHandle selSetShowsPointsOfInterest_XHandle = Selector.GetHandle ("setShowsPointsOfInterest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsScale_X = "setShowsScale:";
		static readonly NativeHandle selSetShowsScale_XHandle = Selector.GetHandle ("setShowsScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsTraffic_X = "setShowsTraffic:";
		static readonly NativeHandle selSetShowsTraffic_XHandle = Selector.GetHandle ("setShowsTraffic:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsUserLocation_X = "setShowsUserLocation:";
		static readonly NativeHandle selSetShowsUserLocation_XHandle = Selector.GetHandle ("setShowsUserLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsUserTrackingButton_X = "setShowsUserTrackingButton:";
		static readonly NativeHandle selSetShowsUserTrackingButton_XHandle = Selector.GetHandle ("setShowsUserTrackingButton:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsZoomControls_X = "setShowsZoomControls:";
		static readonly NativeHandle selSetShowsZoomControls_XHandle = Selector.GetHandle ("setShowsZoomControls:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUserTrackingMode_X = "setUserTrackingMode:";
		static readonly NativeHandle selSetUserTrackingMode_XHandle = Selector.GetHandle ("setUserTrackingMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUserTrackingMode_Animated_X = "setUserTrackingMode:animated:";
		static readonly NativeHandle selSetUserTrackingMode_Animated_XHandle = Selector.GetHandle ("setUserTrackingMode:animated:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVisibleMapRect_X = "setVisibleMapRect:";
		static readonly NativeHandle selSetVisibleMapRect_XHandle = Selector.GetHandle ("setVisibleMapRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVisibleMapRect_Animated_X = "setVisibleMapRect:animated:";
		static readonly NativeHandle selSetVisibleMapRect_Animated_XHandle = Selector.GetHandle ("setVisibleMapRect:animated:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVisibleMapRect_EdgePadding_Animated_X = "setVisibleMapRect:edgePadding:animated:";
		static readonly NativeHandle selSetVisibleMapRect_EdgePadding_Animated_XHandle = Selector.GetHandle ("setVisibleMapRect:edgePadding:animated:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetZoomEnabled_X = "setZoomEnabled:";
		static readonly NativeHandle selSetZoomEnabled_XHandle = Selector.GetHandle ("setZoomEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowAnnotations_Animated_X = "showAnnotations:animated:";
		static readonly NativeHandle selShowAnnotations_Animated_XHandle = Selector.GetHandle ("showAnnotations:animated:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsBuildingsX = "showsBuildings";
		static readonly NativeHandle selShowsBuildingsXHandle = Selector.GetHandle ("showsBuildings");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsCompassX = "showsCompass";
		static readonly NativeHandle selShowsCompassXHandle = Selector.GetHandle ("showsCompass");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsPitchControlX = "showsPitchControl";
		static readonly NativeHandle selShowsPitchControlXHandle = Selector.GetHandle ("showsPitchControl");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsPointsOfInterestX = "showsPointsOfInterest";
		static readonly NativeHandle selShowsPointsOfInterestXHandle = Selector.GetHandle ("showsPointsOfInterest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsScaleX = "showsScale";
		static readonly NativeHandle selShowsScaleXHandle = Selector.GetHandle ("showsScale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsTrafficX = "showsTraffic";
		static readonly NativeHandle selShowsTrafficXHandle = Selector.GetHandle ("showsTraffic");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsUserLocationX = "showsUserLocation";
		static readonly NativeHandle selShowsUserLocationXHandle = Selector.GetHandle ("showsUserLocation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsUserTrackingButtonX = "showsUserTrackingButton";
		static readonly NativeHandle selShowsUserTrackingButtonXHandle = Selector.GetHandle ("showsUserTrackingButton");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsZoomControlsX = "showsZoomControls";
		static readonly NativeHandle selShowsZoomControlsXHandle = Selector.GetHandle ("showsZoomControls");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserLocationX = "userLocation";
		static readonly NativeHandle selUserLocationXHandle = Selector.GetHandle ("userLocation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserTrackingModeX = "userTrackingMode";
		static readonly NativeHandle selUserTrackingModeXHandle = Selector.GetHandle ("userTrackingMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selViewForAnnotation_X = "viewForAnnotation:";
		static readonly NativeHandle selViewForAnnotation_XHandle = Selector.GetHandle ("viewForAnnotation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVisibleMapRectX = "visibleMapRect";
		static readonly NativeHandle selVisibleMapRectXHandle = Selector.GetHandle ("visibleMapRect");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MKMapView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MKMapView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MKMapView () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
			}
		}

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public MKMapView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected MKMapView (NSObjectFlag t) : base (t)
		{
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
		protected internal MKMapView (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="frame">Frame used by the view, expressed in iOS points.</param><summary>Initializes the MKMapView with the specified frame.</summary><remarks><para>This constructor is used to programmatically create a new instance of MKMapView with the specified dimension in the frame.   The object will only be displayed once it has been added to a view hierarchy by calling AddSubview in a containing view.</para><para>This constructor is not invoked when deserializing objects from storyboards or XIB files; instead, the constructor that takes an NSCoder parameter is invoked.</para></remarks>
		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MKMapView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selInitWithFrame_XHandle, frame), "initWithFrame:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selInitWithFrame_XHandle, frame), "initWithFrame:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("addAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnnotation (IMKAnnotation annotation)
		{
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddAnnotation_XHandle, annotation__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddAnnotation_XHandle, annotation__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (annotation);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("addAnnotations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnnotations (params IMKAnnotation[] annotations)
		{
			if (annotations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (annotations));
			using var nsa_annotations = NSArray.FromNSObjects (annotations);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddAnnotations_XHandle, nsa_annotations.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddAnnotations_XHandle, nsa_annotations.Handle);
					GC.KeepAlive (this);
				}
			}
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("addOverlay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddOverlay (IMKOverlay overlay)
		{
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddOverlay_XHandle, overlay__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddOverlay_XHandle, overlay__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("addOverlay:level:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddOverlay (IMKOverlay overlay, MKOverlayLevel level)
		{
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selAddOverlay_Level_XHandle, overlay__handle__, (IntPtr) (long) level);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selAddOverlay_Level_XHandle, overlay__handle__, (IntPtr) (long) level);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("addOverlays:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddOverlays (IMKOverlay[] overlays)
		{
			if (overlays is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (overlays));
			using var nsa_overlays = NSArray.FromNSObjects (overlays);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddOverlays_XHandle, nsa_overlays.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddOverlays_XHandle, nsa_overlays.Handle);
					GC.KeepAlive (this);
				}
			}
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("addOverlays:level:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddOverlays (IMKOverlay[] overlays, MKOverlayLevel level)
		{
			if (overlays is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (overlays));
			using var nsa_overlays = NSArray.FromNSObjects (overlays);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selAddOverlays_Level_XHandle, nsa_overlays.Handle, (IntPtr) (long) level);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selAddOverlays_Level_XHandle, nsa_overlays.Handle, (IntPtr) (long) level);
					GC.KeepAlive (this);
				}
			}
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("convertCoordinate:toPointToView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertCoordinate (global::CoreLocation.CLLocationCoordinate2D coordinate, global::AppKit.NSView? toPointToView)
		{
			var toPointToView__handle__ = toPointToView.GetHandle ();
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CLLocationCoordinate2D_NativeHandle (this.Handle, selConvertCoordinate_ToPointToView_XHandle, coordinate, toPointToView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CLLocationCoordinate2D_NativeHandle (&__objc_super__, selConvertCoordinate_ToPointToView_XHandle, coordinate, toPointToView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (toPointToView);
			return ret!;
		}
		[Export ("convertPoint:toCoordinateFromView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreLocation.CLLocationCoordinate2D ConvertPoint (CGPoint point, global::AppKit.NSView? toCoordinateFromView)
		{
			var toCoordinateFromView__handle__ = toCoordinateFromView.GetHandle ();
			global::CoreLocation.CLLocationCoordinate2D ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CLLocationCoordinate2D_objc_msgSend_CGPoint_NativeHandle (this.Handle, selConvertPoint_ToCoordinateFromView_XHandle, point, toCoordinateFromView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, selConvertPoint_ToCoordinateFromView_XHandle, point, toCoordinateFromView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (toCoordinateFromView);
			return ret!;
		}
		[Export ("convertRect:toRegionFromView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKCoordinateRegion ConvertRect (CGRect rect, global::AppKit.NSView? toRegionFromView)
		{
			var toRegionFromView__handle__ = toRegionFromView.GetHandle ();
			MKCoordinateRegion ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSend_CGRect_NativeHandle (this.Handle, selConvertRect_ToRegionFromView_XHandle, rect, toRegionFromView__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, selConvertRect_ToRegionFromView_XHandle, rect, toRegionFromView__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selConvertRect_ToRegionFromView_XHandle, rect, toRegionFromView__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSendSuper_stret_CGRect_NativeHandle (&__objc_super__, selConvertRect_ToRegionFromView_XHandle, rect, toRegionFromView__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (toRegionFromView);
			return ret!;
		}
		[Export ("convertRegion:toRectToView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConvertRegion (MKCoordinateRegion region, global::AppKit.NSView? toRectToView)
		{
			var toRectToView__handle__ = toRectToView.GetHandle ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_MKCoordinateRegion_NativeHandle (this.Handle, selConvertRegion_ToRectToView_XHandle, region, toRectToView__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_MKCoordinateRegion_NativeHandle (this.Handle, selConvertRegion_ToRectToView_XHandle, region, toRectToView__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_MKCoordinateRegion_NativeHandle (&__objc_super__, selConvertRegion_ToRectToView_XHandle, region, toRectToView__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_MKCoordinateRegion_NativeHandle (&__objc_super__, selConvertRegion_ToRectToView_XHandle, region, toRectToView__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (toRectToView);
			return ret!;
		}
		[Export ("dequeueReusableAnnotationViewWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKAnnotationView? DequeueReusableAnnotation (string withViewIdentifier)
		{
			if (withViewIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (withViewIdentifier));
			var nswithViewIdentifier = CFString.CreateNative (withViewIdentifier);
			MKAnnotationView? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MKAnnotationView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDequeueReusableAnnotationViewWithIdentifier_XHandle, nswithViewIdentifier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MKAnnotationView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDequeueReusableAnnotationViewWithIdentifier_XHandle, nswithViewIdentifier), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nswithViewIdentifier);
			return ret!;
		}
		[Export ("dequeueReusableAnnotationViewWithIdentifier:forAnnotation:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKAnnotationView DequeueReusableAnnotation (string identifier, IMKAnnotation annotation)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			var nsidentifier = CFString.CreateNative (identifier);
			MKAnnotationView? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MKAnnotationView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDequeueReusableAnnotationViewWithIdentifier_ForAnnotation_XHandle, nsidentifier, annotation__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MKAnnotationView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDequeueReusableAnnotationViewWithIdentifier_ForAnnotation_XHandle, nsidentifier, annotation__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (annotation);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("deselectAnnotation:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeselectAnnotation (IMKAnnotation? annotation, bool animated)
		{
			var annotation__handle__ = annotation.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selDeselectAnnotation_Animated_XHandle, annotation__handle__, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selDeselectAnnotation_Animated_XHandle, annotation__handle__, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (annotation);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("exchangeOverlay:withOverlay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExchangeOverlay (IMKOverlay overlay1, IMKOverlay overlay2)
		{
			var overlay1__handle__ = overlay1!.GetNonNullHandle (nameof (overlay1));
			var overlay2__handle__ = overlay2!.GetNonNullHandle (nameof (overlay2));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selExchangeOverlay_WithOverlay_XHandle, overlay1__handle__, overlay2__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selExchangeOverlay_WithOverlay_XHandle, overlay1__handle__, overlay2__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay1);
			GC.KeepAlive (overlay2);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		/// <param name="index1">The index of the first overlay.</param><param name="index2">The index of the second overlay.</param><summary>Swaps the index positions of two overlays.</summary><remarks>Changing the index positions of the overlays will swap their z-order on the map.</remarks>
		[Export ("exchangeOverlayAtIndex:withOverlayAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExchangeOverlays (nint index1, nint index2)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selExchangeOverlayAtIndex_WithOverlayAtIndex_XHandle, index1, index2);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selExchangeOverlayAtIndex_WithOverlayAtIndex_XHandle, index1, index2);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("annotationsInMapRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet GetAnnotations (MKMapRect mapRect)
		{
			NSSet ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_MKMapRect (this.Handle, selAnnotationsInMapRect_XHandle, mapRect), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_MKMapRect (&__objc_super__, selAnnotationsInMapRect_XHandle, mapRect), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="overlay">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("insertOverlay:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertOverlay (IMKOverlay overlay, nint index)
		{
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selInsertOverlay_AtIndex_XHandle, overlay__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selInsertOverlay_AtIndex_XHandle, overlay__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		/// <param name="overlay">To be added.</param><param name="index">To be added.</param><param name="level">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("insertOverlay:atIndex:level:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertOverlay (IMKOverlay overlay, nuint index, MKOverlayLevel level)
		{
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_IntPtr (this.Handle, selInsertOverlay_AtIndex_Level_XHandle, overlay__handle__, index, (IntPtr) (long) level);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr (&__objc_super__, selInsertOverlay_AtIndex_Level_XHandle, overlay__handle__, index, (IntPtr) (long) level);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("insertOverlay:aboveOverlay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertOverlayAbove (IMKOverlay overlay, IMKOverlay sibling)
		{
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			var sibling__handle__ = sibling!.GetNonNullHandle (nameof (sibling));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInsertOverlay_AboveOverlay_XHandle, overlay__handle__, sibling__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInsertOverlay_AboveOverlay_XHandle, overlay__handle__, sibling__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay);
			GC.KeepAlive (sibling);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("insertOverlay:belowOverlay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertOverlayBelow (IMKOverlay overlay, IMKOverlay sibling)
		{
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			var sibling__handle__ = sibling!.GetNonNullHandle (nameof (sibling));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInsertOverlay_BelowOverlay_XHandle, overlay__handle__, sibling__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInsertOverlay_BelowOverlay_XHandle, overlay__handle__, sibling__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay);
			GC.KeepAlive (sibling);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("mapRectThatFits:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKMapRect MapRectThatFits (MKMapRect mapRect)
		{
			MKMapRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend_MKMapRect (this.Handle, selMapRectThatFits_XHandle, mapRect);
				} else {
					ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend_stret_MKMapRect (this.Handle, selMapRectThatFits_XHandle, mapRect);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSendSuper_MKMapRect (&__objc_super__, selMapRectThatFits_XHandle, mapRect);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSendSuper_stret_MKMapRect (&__objc_super__, selMapRectThatFits_XHandle, mapRect);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("mapRectThatFits:edgePadding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKMapRect MapRectThatFits (MKMapRect mapRect, global::AppKit.NSEdgeInsets edgePadding)
		{
			MKMapRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend_MKMapRect_NSEdgeInsets (this.Handle, selMapRectThatFits_EdgePadding_XHandle, mapRect, edgePadding);
				} else {
					ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend_stret_MKMapRect_NSEdgeInsets (this.Handle, selMapRectThatFits_EdgePadding_XHandle, mapRect, edgePadding);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSendSuper_MKMapRect_NSEdgeInsets (&__objc_super__, selMapRectThatFits_EdgePadding_XHandle, mapRect, edgePadding);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSendSuper_stret_MKMapRect_NSEdgeInsets (&__objc_super__, selMapRectThatFits_EdgePadding_XHandle, mapRect, edgePadding);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("overlaysInLevel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMKOverlay[] OverlaysInLevel (MKOverlayLevel level)
		{
			IMKOverlay[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<IMKOverlay>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selOverlaysInLevel_XHandle, (IntPtr) (long) level), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<IMKOverlay>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selOverlaysInLevel_XHandle, (IntPtr) (long) level), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("regionThatFits:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKCoordinateRegion RegionThatFits (MKCoordinateRegion region)
		{
			MKCoordinateRegion ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSend_MKCoordinateRegion (this.Handle, selRegionThatFits_XHandle, region);
				} else {
					ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSend_stret_MKCoordinateRegion (this.Handle, selRegionThatFits_XHandle, region);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSendSuper_MKCoordinateRegion (&__objc_super__, selRegionThatFits_XHandle, region);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSendSuper_stret_MKCoordinateRegion (&__objc_super__, selRegionThatFits_XHandle, region);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("registerClass:forAnnotationViewWithReuseIdentifier:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Register (Class? viewClass, string identifier)
		{
			var viewClass__handle__ = viewClass.GetHandle ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRegisterClass_ForAnnotationViewWithReuseIdentifier_XHandle, viewClass__handle__, nsidentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRegisterClass_ForAnnotationViewWithReuseIdentifier_XHandle, viewClass__handle__, nsidentifier);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (viewClass);
			CFString.ReleaseNative (nsidentifier);
		}
		/// <param name="viewType">To be added.</param><param name="identifier">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Register (global::System.Type? viewType, string identifier)
		{
			Register (viewType is null ? null : new Class (viewType), identifier);
		}
		[Export ("removeAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnnotation (IMKAnnotation annotation)
		{
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveAnnotation_XHandle, annotation__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveAnnotation_XHandle, annotation__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (annotation);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("removeAnnotations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnnotations (params IMKAnnotation[] annotations)
		{
			if (annotations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (annotations));
			using var nsa_annotations = NSArray.FromNSObjects (annotations);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveAnnotations_XHandle, nsa_annotations.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveAnnotations_XHandle, nsa_annotations.Handle);
					GC.KeepAlive (this);
				}
			}
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("removeOverlay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveOverlay (IMKOverlay overlay)
		{
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveOverlay_XHandle, overlay__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveOverlay_XHandle, overlay__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("removeOverlays:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveOverlays (params IMKOverlay[] overlays)
		{
			if (overlays is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (overlays));
			using var nsa_overlays = NSArray.FromNSObjects (overlays);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveOverlays_XHandle, nsa_overlays.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveOverlays_XHandle, nsa_overlays.Handle);
					GC.KeepAlive (this);
				}
			}
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("rendererForOverlay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKOverlayRenderer? RendererForOverlay (IMKOverlay overlay)
		{
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			MKOverlayRenderer? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MKOverlayRenderer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selRendererForOverlay_XHandle, overlay__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MKOverlayRenderer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selRendererForOverlay_XHandle, overlay__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay);
			return ret!;
		}
		[Export ("selectAnnotation:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectAnnotation (IMKAnnotation annotation, bool animated)
		{
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selSelectAnnotation_Animated_XHandle, annotation__handle__, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selSelectAnnotation_Animated_XHandle, annotation__handle__, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (annotation);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("setCamera:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCamera (MKMapCamera camera, bool animated)
		{
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selSetCamera_Animated_XHandle, camera__handle__, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selSetCamera_Animated_XHandle, camera__handle__, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (camera);
		}
		[Export ("setCameraBoundary:animated:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCameraBoundary (MKMapCameraBoundary? cameraBoundary, bool animated)
		{
			var cameraBoundary__handle__ = cameraBoundary.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selSetCameraBoundary_Animated_XHandle, cameraBoundary__handle__, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selSetCameraBoundary_Animated_XHandle, cameraBoundary__handle__, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cameraBoundary);
		}
		[Export ("setCameraZoomRange:animated:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCameraZoomRange (MKMapCameraZoomRange? cameraZoomRange, bool animated)
		{
			var cameraZoomRange__handle__ = cameraZoomRange.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selSetCameraZoomRange_Animated_XHandle, cameraZoomRange__handle__, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selSetCameraZoomRange_Animated_XHandle, cameraZoomRange__handle__, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cameraZoomRange);
		}
		[Export ("setCenterCoordinate:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCenterCoordinate (global::CoreLocation.CLLocationCoordinate2D coordinate, bool animated)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CLLocationCoordinate2D_bool (this.Handle, selSetCenterCoordinate_Animated_XHandle, coordinate, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D_bool (&__objc_super__, selSetCenterCoordinate_Animated_XHandle, coordinate, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setRegion:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetRegion (MKCoordinateRegion region, bool animated)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_MKCoordinateRegion_bool (this.Handle, selSetRegion_Animated_XHandle, region, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MKCoordinateRegion_bool (&__objc_super__, selSetRegion_Animated_XHandle, region, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setUserTrackingMode:animated:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetUserTrackingMode (MKUserTrackingMode trackingMode, bool animated)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_bool (this.Handle, selSetUserTrackingMode_Animated_XHandle, (UIntPtr) (ulong) trackingMode, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_bool (&__objc_super__, selSetUserTrackingMode_Animated_XHandle, (UIntPtr) (ulong) trackingMode, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setVisibleMapRect:edgePadding:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVisibleMapRect (MKMapRect mapRect, global::AppKit.NSEdgeInsets edgePadding, bool animate)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_MKMapRect_NSEdgeInsets_bool (this.Handle, selSetVisibleMapRect_EdgePadding_Animated_XHandle, mapRect, edgePadding, animate ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MKMapRect_NSEdgeInsets_bool (&__objc_super__, selSetVisibleMapRect_EdgePadding_Animated_XHandle, mapRect, edgePadding, animate ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setVisibleMapRect:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVisibleMapRect (MKMapRect mapRect, bool animate)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_MKMapRect_bool (this.Handle, selSetVisibleMapRect_Animated_XHandle, mapRect, animate ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MKMapRect_bool (&__objc_super__, selSetVisibleMapRect_Animated_XHandle, mapRect, animate ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("showAnnotations:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowAnnotations (IMKAnnotation[] annotations, bool animated)
		{
			if (annotations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (annotations));
			using var nsa_annotations = NSArray.FromNSObjects (annotations);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selShowAnnotations_Animated_XHandle, nsa_annotations.Handle, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selShowAnnotations_Animated_XHandle, nsa_annotations.Handle, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("viewForAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKAnnotationView? ViewForAnnotation (IMKAnnotation annotation)
		{
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			MKAnnotationView? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MKAnnotationView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selViewForAnnotation_XHandle, annotation__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MKAnnotationView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selViewForAnnotation_XHandle, annotation__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (annotation);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect AnnotationVisibleRect {
			[Export ("annotationVisibleRect")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selAnnotationVisibleRectXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selAnnotationVisibleRectXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selAnnotationVisibleRectXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selAnnotationVisibleRectXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMKAnnotation[] Annotations {
			[Export ("annotations")]
			get {
				IMKAnnotation[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IMKAnnotation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAnnotationsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IMKAnnotation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAnnotationsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKMapCamera Camera {
			[Export ("camera", ArgumentSemantic.Copy)]
			get {
				MKMapCamera? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MKMapCamera> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCameraXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MKMapCamera> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCameraXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCamera:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCamera_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCamera_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual MKMapCameraBoundary? CameraBoundary {
			[Export ("cameraBoundary", ArgumentSemantic.Copy)]
			get {
				MKMapCameraBoundary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MKMapCameraBoundary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCameraBoundaryXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MKMapCameraBoundary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCameraBoundaryXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCameraBoundary:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCameraBoundary_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCameraBoundary_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual MKMapCameraZoomRange? CameraZoomRange {
			[Export ("cameraZoomRange", ArgumentSemantic.Copy)]
			get {
				MKMapCameraZoomRange? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MKMapCameraZoomRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCameraZoomRangeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MKMapCameraZoomRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCameraZoomRangeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCameraZoomRange:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCameraZoomRange_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCameraZoomRange_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreLocation.CLLocationCoordinate2D CenterCoordinate {
			[Export ("centerCoordinate")]
			get {
				global::CoreLocation.CLLocationCoordinate2D ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CLLocationCoordinate2D_objc_msgSend (this.Handle, selCenterCoordinateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CLLocationCoordinate2D_objc_msgSendSuper (&__objc_super__, selCenterCoordinateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCenterCoordinate:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CLLocationCoordinate2D (this.Handle, selSetCenterCoordinate_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D (&__objc_super__, selSetCenterCoordinate_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>An instance of the MapKit.IMKMapViewDelegate model class which acts as the class delegate.</summary><value>The instance of the MapKit.IMKMapViewDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMKMapViewDelegate Delegate {
			get {
				return (WeakDelegate as IMKMapViewDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKMapType MapType {
			[Export ("mapType")]
			get {
				MKMapType ret;
				if (IsDirectBinding) {
					ret = (MapKit.MKMapType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMapTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MapKit.MKMapType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMapTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMapType:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetMapType_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetMapType_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMKOverlay[] Overlays {
			[Export ("overlays")]
			get {
				IMKOverlay[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IMKOverlay>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOverlaysXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IMKOverlay>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOverlaysXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public virtual MKFeatureVisibility PitchButtonVisibility {
			[Export ("pitchButtonVisibility", ArgumentSemantic.Assign)]
			get {
				MKFeatureVisibility ret;
				if (IsDirectBinding) {
					ret = (MapKit.MKFeatureVisibility) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPitchButtonVisibilityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MapKit.MKFeatureVisibility) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selPitchButtonVisibilityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPitchButtonVisibility:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPitchButtonVisibility_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetPitchButtonVisibility_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether the view uses the angle defined by the <see cref="P:MapKit.MKMapView.Camera" />.</summary><value>The default value is <see langword="true" />.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual bool PitchEnabled {
			[Export ("isPitchEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPitchEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsPitchEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPitchEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPitchEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPitchEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual MKPointOfInterestFilter? PointOfInterestFilter {
			[Export ("pointOfInterestFilter", ArgumentSemantic.Copy)]
			get {
				MKPointOfInterestFilter? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MKPointOfInterestFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPointOfInterestFilterXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MKPointOfInterestFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPointOfInterestFilterXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPointOfInterestFilter:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPointOfInterestFilter_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPointOfInterestFilter_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		public virtual MKMapConfiguration PreferredConfiguration {
			[Export ("preferredConfiguration", ArgumentSemantic.Copy)]
			get {
				MKMapConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MKMapConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreferredConfigurationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MKMapConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreferredConfigurationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPreferredConfiguration:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPreferredConfiguration_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPreferredConfiguration_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKCoordinateRegion Region {
			[Export ("region")]
			get {
				MKCoordinateRegion ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSend (this.Handle, selRegionXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSend_stret (this.Handle, selRegionXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSendSuper (&__objc_super__, selRegionXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSendSuper_stret (&__objc_super__, selRegionXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setRegion:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_MKCoordinateRegion (this.Handle, selSetRegion_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MKCoordinateRegion (&__objc_super__, selSetRegion_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether the view uses the heading defined by the <see cref="P:MapKit.MKMapView.Camera" />.</summary><value>The default value is <see langword="true" />.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual bool RotateEnabled {
			[Export ("isRotateEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRotateEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsRotateEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setRotateEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRotateEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetRotateEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Control if the map can be scrolled with a pan gesture.</summary><value></value><remarks>Only controls interactive scrolling. The region can be changed in code regardless of this property.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ScrollEnabled {
			[Export ("isScrollEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsScrollEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsScrollEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setScrollEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetScrollEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetScrollEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMKAnnotation[] SelectedAnnotations {
			[Export ("selectedAnnotations", ArgumentSemantic.Copy)]
			get {
				IMKAnnotation[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IMKAnnotation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectedAnnotationsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IMKAnnotation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectedAnnotationsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSelectedAnnotations:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSelectedAnnotations_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSelectedAnnotations_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsBuildings {
			[Export ("showsBuildings")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsBuildingsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsBuildingsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsBuildings:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsBuildings_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsBuildings_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual bool ShowsCompass {
			[Export ("showsCompass")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsCompassXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsCompassXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsCompass:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsCompass_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsCompass_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual bool ShowsPitchControl {
			[Export ("showsPitchControl")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsPitchControlXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsPitchControlXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsPitchControl:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsPitchControl_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsPitchControl_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.15", "Use 'PointOfInterestFilter' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'PointOfInterestFilter' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'PointOfInterestFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'PointOfInterestFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool ShowsPointsOfInterest {
			[Export ("showsPointsOfInterest")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsPointsOfInterestXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsPointsOfInterestXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsPointsOfInterest:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsPointsOfInterest_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsPointsOfInterest_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool ShowsScale {
			[Export ("showsScale")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsScaleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsScaleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsScale:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsScale_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsScale_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool ShowsTraffic {
			[Export ("showsTraffic")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsTrafficXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsTrafficXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsTraffic:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsTraffic_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsTraffic_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsUserLocation {
			[Export ("showsUserLocation")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsUserLocationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsUserLocationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsUserLocation:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsUserLocation_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsUserLocation_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public virtual bool ShowsUserTrackingButton {
			[Export ("showsUserTrackingButton")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsUserTrackingButtonXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsUserTrackingButtonXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsUserTrackingButton:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsUserTrackingButton_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsUserTrackingButton_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool ShowsZoomControls {
			[Export ("showsZoomControls")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsZoomControlsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsZoomControlsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsZoomControls:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsZoomControls_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsZoomControls_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKUserLocation UserLocation {
			[Export ("userLocation")]
			get {
				MKUserLocation? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MKUserLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUserLocationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MKUserLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUserLocationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Returns if the user's location is currently visible on the map.</summary><value></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UserLocationVisible {
			[Export ("isUserLocationVisible")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsUserLocationVisibleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsUserLocationVisibleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual MKUserTrackingMode UserTrackingMode {
			[Export ("userTrackingMode")]
			get {
				MKUserTrackingMode ret;
				if (IsDirectBinding) {
					ret = (MapKit.MKUserTrackingMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selUserTrackingModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MapKit.MKUserTrackingMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selUserTrackingModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setUserTrackingMode:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetUserTrackingMode_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetUserTrackingMode_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKMapRect VisibleMapRect {
			[Export ("visibleMapRect")]
			get {
				MKMapRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend (this.Handle, selVisibleMapRectXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend_stret (this.Handle, selVisibleMapRectXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSendSuper (&__objc_super__, selVisibleMapRectXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSendSuper_stret (&__objc_super__, selVisibleMapRectXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setVisibleMapRect:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_MKMapRect (this.Handle, selSetVisibleMapRect_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MKMapRect (&__objc_super__, selSetVisibleMapRect_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		/// <summary>Controls if the user can zoom in and out of the map using a pinch gesture.</summary><value>Default is <see langword="true" />.</value><remarks>The default value of <see langword="true" /> allows zooming. This property only controls if the user can interactively zoom. It has no affect on zooming the map in code, which can be done by changing either the <see cref="P:MapKit.MKMapView.Region" /> or <see cref="P:MapKit.MKMapView.VisibleMapRect" /> properties.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ZoomEnabled {
			[Export ("isZoomEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsZoomEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsZoomEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setZoomEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetZoomEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetZoomEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_MKMapViewDelegate); }
		}
		internal virtual _MKMapViewDelegate CreateInternalEventDelegateType ()
		{
			return (_MKMapViewDelegate)(new _MKMapViewDelegate());
		}
		internal _MKMapViewDelegate EnsureMKMapViewDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _MKMapViewDelegate;
			if (del is null){
				del = (_MKMapViewDelegate)CreateInternalEventDelegateType ();
				Delegate = (IMKMapViewDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _MKMapViewDelegate : NSObject, IMKMapViewDelegate { 
			public _MKMapViewDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_MKMapViewDelegate))]
			static _MKMapViewDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<MKMapViewDragStateEventArgs>? changedDragState;
			[Export ("mapView:annotationView:didChangeDragState:fromOldState:")]
			public void ChangedDragState (MapKit.MKMapView mapView, MapKit.MKAnnotationView annotationView, MapKit.MKAnnotationViewDragState newState, MapKit.MKAnnotationViewDragState oldState)
			{
				var handler = changedDragState;
				if (handler is not null){
					var args = new MKMapViewDragStateEventArgs (annotationView, newState, oldState);
					handler (mapView, args);
				}
			}
			internal MKCreateClusterAnnotation? createClusterAnnotation;
			[Export ("mapView:clusterAnnotationForMemberAnnotations:")]
			public MapKit.MKClusterAnnotation CreateClusterAnnotation (MapKit.MKMapView mapView, MapKit.IMKAnnotation[] memberAnnotations)
			{
				var handler = createClusterAnnotation;
				if (handler is not null)
					return handler (mapView, memberAnnotations);
				return null!;
			}
			internal EventHandler<MKMapViewAnnotationEventArgs>? didAddAnnotationViews;
			[Export ("mapView:didAddAnnotationViews:")]
			public void DidAddAnnotationViews (MapKit.MKMapView mapView, MapKit.MKAnnotationView[] views)
			{
				var handler = didAddAnnotationViews;
				if (handler is not null){
					var args = new MKMapViewAnnotationEventArgs (views);
					handler (mapView, args);
				}
			}
			internal EventHandler<MKDidAddOverlayRenderersEventArgs>? didAddOverlayRenderers;
			[Export ("mapView:didAddOverlayRenderers:")]
			public void DidAddOverlayRenderers (MapKit.MKMapView mapView, MapKit.MKOverlayRenderer[] renderers)
			{
				var handler = didAddOverlayRenderers;
				if (handler is not null){
					var args = new MKDidAddOverlayRenderersEventArgs (renderers);
					handler (mapView, args);
				}
			}
			internal EventHandler<MMapViewUserTrackingEventArgs>? didChangeUserTrackingMode;
			[Export ("mapView:didChangeUserTrackingMode:animated:")]
			public void DidChangeUserTrackingMode (MapKit.MKMapView mapView, MapKit.MKUserTrackingMode mode, bool animated)
			{
				var handler = didChangeUserTrackingMode;
				if (handler is not null){
					var args = new MMapViewUserTrackingEventArgs (mode, animated);
					handler (mapView, args);
				}
			}
			internal EventHandler? didChangeVisibleRegion;
			[Export ("mapViewDidChangeVisibleRegion:")]
			public void DidChangeVisibleRegion (MapKit.MKMapView mapView)
			{
				var handler = didChangeVisibleRegion;
				if (handler is not null){
					handler (mapView, EventArgs.Empty);
				}
			}
			internal EventHandler<MKAnnotationViewEventArgs>? didDeselectAnnotationView;
			[Export ("mapView:didDeselectAnnotationView:")]
			public void DidDeselectAnnotationView (MapKit.MKMapView mapView, MapKit.MKAnnotationView view)
			{
				var handler = didDeselectAnnotationView;
				if (handler is not null){
					var args = new MKAnnotationViewEventArgs (view);
					handler (mapView, args);
				}
			}
			internal EventHandler<NSErrorEventArgs>? didFailToLocateUser;
			[Export ("mapView:didFailToLocateUserWithError:")]
			public void DidFailToLocateUser (MapKit.MKMapView mapView, NSError error)
			{
				var handler = didFailToLocateUser;
				if (handler is not null){
					var args = new NSErrorEventArgs (error);
					handler (mapView, args);
				}
			}
			internal EventHandler<MKDidFinishRenderingMapEventArgs>? didFinishRenderingMap;
			[Export ("mapViewDidFinishRenderingMap:fullyRendered:")]
			public void DidFinishRenderingMap (MapKit.MKMapView mapView, bool fullyRendered)
			{
				var handler = didFinishRenderingMap;
				if (handler is not null){
					var args = new MKDidFinishRenderingMapEventArgs (fullyRendered);
					handler (mapView, args);
				}
			}
			internal EventHandler<MKAnnotationViewEventArgs>? didSelectAnnotationView;
			[Export ("mapView:didSelectAnnotationView:")]
			public void DidSelectAnnotationView (MapKit.MKMapView mapView, MapKit.MKAnnotationView view)
			{
				var handler = didSelectAnnotationView;
				if (handler is not null){
					var args = new MKAnnotationViewEventArgs (view);
					handler (mapView, args);
				}
			}
			internal EventHandler? didStopLocatingUser;
			[Export ("mapViewDidStopLocatingUser:")]
			public void DidStopLocatingUser (MapKit.MKMapView mapView)
			{
				var handler = didStopLocatingUser;
				if (handler is not null){
					handler (mapView, EventArgs.Empty);
				}
			}
			internal EventHandler<MKUserLocationEventArgs>? didUpdateUserLocation;
			[Export ("mapView:didUpdateUserLocation:")]
			public void DidUpdateUserLocation (MapKit.MKMapView mapView, MapKit.MKUserLocation userLocation)
			{
				var handler = didUpdateUserLocation;
				if (handler is not null){
					var args = new MKUserLocationEventArgs (userLocation);
					handler (mapView, args);
				}
			}
			internal MKMapViewDelegateGetSelectionAccessory? getSelectionAccessory;
			[Export ("mapView:selectionAccessoryForAnnotation:")]
			public MapKit.MKSelectionAccessory? GetSelectionAccessory (MapKit.MKMapView mapView, MapKit.IMKAnnotation annotation)
			{
				var handler = getSelectionAccessory;
				if (handler is not null)
					return handler (mapView, annotation);
				return null!;
			}
			internal MKMapViewAnnotation? getViewForAnnotation;
			[Export ("mapView:viewForAnnotation:")]
			public MapKit.MKAnnotationView? GetViewForAnnotation (MapKit.MKMapView mapView, MapKit.IMKAnnotation annotation)
			{
				var handler = getViewForAnnotation;
				if (handler is not null)
					return handler (mapView, annotation);
				return null!;
			}
			internal EventHandler<NSErrorEventArgs>? loadingMapFailed;
			[Export ("mapViewDidFailLoadingMap:withError:")]
			public void LoadingMapFailed (MapKit.MKMapView mapView, NSError error)
			{
				var handler = loadingMapFailed;
				if (handler is not null){
					var args = new NSErrorEventArgs (error);
					handler (mapView, args);
				}
			}
			internal EventHandler? mapLoaded;
			[Export ("mapViewDidFinishLoadingMap:")]
			public void MapLoaded (MapKit.MKMapView mapView)
			{
				var handler = mapLoaded;
				if (handler is not null){
					handler (mapView, EventArgs.Empty);
				}
			}
			internal MKRendererForOverlayDelegate? overlayRenderer;
			[Export ("mapView:rendererForOverlay:")]
			public MapKit.MKOverlayRenderer OverlayRenderer (MapKit.MKMapView mapView, MapKit.IMKOverlay overlay)
			{
				var handler = overlayRenderer;
				if (handler is not null)
					return handler (mapView, overlay);
				return null!;
			}
			internal EventHandler<MKMapViewChangeEventArgs>? regionChanged;
			[Export ("mapView:regionDidChangeAnimated:")]
			public void RegionChanged (MapKit.MKMapView mapView, bool animated)
			{
				var handler = regionChanged;
				if (handler is not null){
					var args = new MKMapViewChangeEventArgs (animated);
					handler (mapView, args);
				}
			}
			internal EventHandler<MKMapViewChangeEventArgs>? regionWillChange;
			[Export ("mapView:regionWillChangeAnimated:")]
			public void RegionWillChange (MapKit.MKMapView mapView, bool animated)
			{
				var handler = regionWillChange;
				if (handler is not null){
					var args = new MKMapViewChangeEventArgs (animated);
					handler (mapView, args);
				}
			}
			internal EventHandler? willStartLoadingMap;
			[Export ("mapViewWillStartLoadingMap:")]
			public void WillStartLoadingMap (MapKit.MKMapView mapView)
			{
				var handler = willStartLoadingMap;
				if (handler is not null){
					handler (mapView, EventArgs.Empty);
				}
			}
			internal EventHandler? willStartLocatingUser;
			[Export ("mapViewWillStartLocatingUser:")]
			public void WillStartLocatingUser (MapKit.MKMapView mapView)
			{
				var handler = willStartLocatingUser;
				if (handler is not null){
					handler (mapView, EventArgs.Empty);
				}
			}
			internal EventHandler? willStartRenderingMap;
			[Export ("mapViewWillStartRenderingMap:")]
			public void WillStartRenderingMap (MapKit.MKMapView mapView)
			{
				var handler = willStartRenderingMap;
				if (handler is not null){
					handler (mapView, EventArgs.Empty);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKMapViewDragStateEventArgs> ChangedDragState {
			add { EnsureMKMapViewDelegate ()!.changedDragState += value; }
			remove { EnsureMKMapViewDelegate ()!.changedDragState -= value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public MKCreateClusterAnnotation? CreateClusterAnnotation {
			get { return EnsureMKMapViewDelegate ()!.createClusterAnnotation; }
			set { EnsureMKMapViewDelegate ()!.createClusterAnnotation = value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKMapViewAnnotationEventArgs> DidAddAnnotationViews {
			add { EnsureMKMapViewDelegate ()!.didAddAnnotationViews += value; }
			remove { EnsureMKMapViewDelegate ()!.didAddAnnotationViews -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKDidAddOverlayRenderersEventArgs> DidAddOverlayRenderers {
			add { EnsureMKMapViewDelegate ()!.didAddOverlayRenderers += value; }
			remove { EnsureMKMapViewDelegate ()!.didAddOverlayRenderers -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MMapViewUserTrackingEventArgs> DidChangeUserTrackingMode {
			add { EnsureMKMapViewDelegate ()!.didChangeUserTrackingMode += value; }
			remove { EnsureMKMapViewDelegate ()!.didChangeUserTrackingMode -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler DidChangeVisibleRegion {
			add { EnsureMKMapViewDelegate ()!.didChangeVisibleRegion += value; }
			remove { EnsureMKMapViewDelegate ()!.didChangeVisibleRegion -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKAnnotationViewEventArgs> DidDeselectAnnotationView {
			add { EnsureMKMapViewDelegate ()!.didDeselectAnnotationView += value; }
			remove { EnsureMKMapViewDelegate ()!.didDeselectAnnotationView -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<NSErrorEventArgs> DidFailToLocateUser {
			add { EnsureMKMapViewDelegate ()!.didFailToLocateUser += value; }
			remove { EnsureMKMapViewDelegate ()!.didFailToLocateUser -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKDidFinishRenderingMapEventArgs> DidFinishRenderingMap {
			add { EnsureMKMapViewDelegate ()!.didFinishRenderingMap += value; }
			remove { EnsureMKMapViewDelegate ()!.didFinishRenderingMap -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKAnnotationViewEventArgs> DidSelectAnnotationView {
			add { EnsureMKMapViewDelegate ()!.didSelectAnnotationView += value; }
			remove { EnsureMKMapViewDelegate ()!.didSelectAnnotationView -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler DidStopLocatingUser {
			add { EnsureMKMapViewDelegate ()!.didStopLocatingUser += value; }
			remove { EnsureMKMapViewDelegate ()!.didStopLocatingUser -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKUserLocationEventArgs> DidUpdateUserLocation {
			add { EnsureMKMapViewDelegate ()!.didUpdateUserLocation += value; }
			remove { EnsureMKMapViewDelegate ()!.didUpdateUserLocation -= value; }
		}
		public MKMapViewDelegateGetSelectionAccessory? GetSelectionAccessory {
			get { return EnsureMKMapViewDelegate ()!.getSelectionAccessory; }
			set { EnsureMKMapViewDelegate ()!.getSelectionAccessory = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public MKMapViewAnnotation? GetViewForAnnotation {
			get { return EnsureMKMapViewDelegate ()!.getViewForAnnotation; }
			set { EnsureMKMapViewDelegate ()!.getViewForAnnotation = value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<NSErrorEventArgs> LoadingMapFailed {
			add { EnsureMKMapViewDelegate ()!.loadingMapFailed += value; }
			remove { EnsureMKMapViewDelegate ()!.loadingMapFailed -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler MapLoaded {
			add { EnsureMKMapViewDelegate ()!.mapLoaded += value; }
			remove { EnsureMKMapViewDelegate ()!.mapLoaded -= value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public MKRendererForOverlayDelegate? OverlayRenderer {
			get { return EnsureMKMapViewDelegate ()!.overlayRenderer; }
			set { EnsureMKMapViewDelegate ()!.overlayRenderer = value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKMapViewChangeEventArgs> RegionChanged {
			add { EnsureMKMapViewDelegate ()!.regionChanged += value; }
			remove { EnsureMKMapViewDelegate ()!.regionChanged -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKMapViewChangeEventArgs> RegionWillChange {
			add { EnsureMKMapViewDelegate ()!.regionWillChange += value; }
			remove { EnsureMKMapViewDelegate ()!.regionWillChange -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler WillStartLoadingMap {
			add { EnsureMKMapViewDelegate ()!.willStartLoadingMap += value; }
			remove { EnsureMKMapViewDelegate ()!.willStartLoadingMap -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler WillStartLocatingUser {
			add { EnsureMKMapViewDelegate ()!.willStartLocatingUser += value; }
			remove { EnsureMKMapViewDelegate ()!.willStartLocatingUser -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler WillStartRenderingMap {
			add { EnsureMKMapViewDelegate ()!.willStartRenderingMap += value; }
			remove { EnsureMKMapViewDelegate ()!.willStartRenderingMap -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class MKMapView */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class MKAnnotationViewEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="MKAnnotationViewEventArgs" /> with the specified event data.</summary>
		/// <param name="view">The value for the <see cref="View" /> property.</param>
		public MKAnnotationViewEventArgs (MapKit.MKAnnotationView view)
		{
			this.View = view;
		}
		public MapKit.MKAnnotationView View { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class MKDidAddOverlayRenderersEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="MKDidAddOverlayRenderersEventArgs" /> with the specified event data.</summary>
		/// <param name="renderers">The value for the <see cref="Renderers" /> property.</param>
		public MKDidAddOverlayRenderersEventArgs (MapKit.MKOverlayRenderer[] renderers)
		{
			this.Renderers = renderers;
		}
		public MapKit.MKOverlayRenderer[] Renderers { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class MKDidFinishRenderingMapEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="MKDidFinishRenderingMapEventArgs" /> with the specified event data.</summary>
		/// <param name="fullyRendered">The value for the <see cref="FullyRendered" /> property.</param>
		public MKDidFinishRenderingMapEventArgs (bool fullyRendered)
		{
			this.FullyRendered = fullyRendered;
		}
		public bool FullyRendered { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class MKMapViewAnnotationEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="MKMapViewAnnotationEventArgs" /> with the specified event data.</summary>
		/// <param name="views">The value for the <see cref="Views" /> property.</param>
		public MKMapViewAnnotationEventArgs (MapKit.MKAnnotationView[] views)
		{
			this.Views = views;
		}
		public MapKit.MKAnnotationView[] Views { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class MKMapViewChangeEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="MKMapViewChangeEventArgs" /> with the specified event data.</summary>
		/// <param name="animated">The value for the <see cref="Animated" /> property.</param>
		public MKMapViewChangeEventArgs (bool animated)
		{
			this.Animated = animated;
		}
		public bool Animated { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class MKMapViewDragStateEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="MKMapViewDragStateEventArgs" /> with the specified event data.</summary>
		/// <param name="annotationView">The value for the <see cref="AnnotationView" /> property.</param>
		/// <param name="newState">The value for the <see cref="NewState" /> property.</param>
		/// <param name="oldState">The value for the <see cref="OldState" /> property.</param>
		public MKMapViewDragStateEventArgs (MapKit.MKAnnotationView annotationView, MapKit.MKAnnotationViewDragState newState, MapKit.MKAnnotationViewDragState oldState)
		{
			this.AnnotationView = annotationView;
			this.NewState = newState;
			this.OldState = oldState;
		}
		public MapKit.MKAnnotationView AnnotationView { get; set; }
		public MapKit.MKAnnotationViewDragState NewState { get; set; }
		public MapKit.MKAnnotationViewDragState OldState { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class MKUserLocationEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="MKUserLocationEventArgs" /> with the specified event data.</summary>
		/// <param name="userLocation">The value for the <see cref="UserLocation" /> property.</param>
		public MKUserLocationEventArgs (MapKit.MKUserLocation userLocation)
		{
			this.UserLocation = userLocation;
		}
		public MapKit.MKUserLocation UserLocation { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class MMapViewUserTrackingEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="MMapViewUserTrackingEventArgs" /> with the specified event data.</summary>
		/// <param name="mode">The value for the <see cref="Mode" /> property.</param>
		/// <param name="animated">The value for the <see cref="Animated" /> property.</param>
		public MMapViewUserTrackingEventArgs (MapKit.MKUserTrackingMode mode, bool animated)
		{
			this.Animated = animated;
			this.Mode = mode;
		}
		public bool Animated { get; set; }
		public MapKit.MKUserTrackingMode Mode { get; set; }
	}
}
