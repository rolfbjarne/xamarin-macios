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
namespace CarPlay {
	#pragma warning disable CS1573
	/// <summary>Default implementation of <see cref="T:CarPlay.ICPMapTemplateDelegate" />, providing the delegate object for <see cref="T:CarPlay.CPMapTemplate" /> objects.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "CPMapTemplateDelegate", WrapperType = typeof (CPMapTemplateDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldProvideNavigationMetadata", Selector = "mapTemplateShouldProvideNavigationMetadata:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldProvideRouteSharing", Selector = "mapTemplateShouldProvideRouteSharing:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRequestToInsertWaypoint", Selector = "mapTemplate:didRequestToInsertWaypoint:intoSegment:completion:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPNavigationWaypoint), typeof (CarPlay.CPRouteSegment), typeof (CarPlay.CPMapTemplateDidRequestToInsertWaypointHandler) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDCPMapTemplateDidRequestToInsertWaypointHandler) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapTemplateWaypoint", Selector = "mapTemplate:mapTemplateWaypoint:accepted:forSegment:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPNavigationWaypoint), typeof (bool), typeof (CarPlay.CPRouteSegment) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveUpdatedRouteSource", Selector = "mapTemplate:didReceiveUpdatedRouteSource:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPRouteSource) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveRequestForDestination", Selector = "mapTemplate:didReceiveRequestForDestination:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPNavigationWaypoint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillShareDestination", Selector = "mapTemplate:willShareDestinationForTrip:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPTrip) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToShareDestination", Selector = "mapTemplate:didFailToShareDestinationForTrip:error:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPTrip), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidShareDestination", Selector = "mapTemplate:didShareDestinationForTrip:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPTrip) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowNotificationForManeuver", Selector = "mapTemplate:shouldShowNotificationForManeuver:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPManeuver) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldUpdateNotificationForManeuver", Selector = "mapTemplate:shouldUpdateNotificationForManeuver:withTravelEstimates:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPManeuver), typeof (CarPlay.CPTravelEstimates) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowNotificationForNavigationAlert", Selector = "mapTemplate:shouldShowNotificationForNavigationAlert:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPNavigationAlert) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidShowPanningInterface", Selector = "mapTemplateDidShowPanningInterface:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDismissPanningInterface", Selector = "mapTemplateWillDismissPanningInterface:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismissPanningInterface", Selector = "mapTemplateDidDismissPanningInterface:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PanBegan", Selector = "mapTemplate:panBeganWithDirection:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPPanDirection) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PanEnded", Selector = "mapTemplate:panEndedWithDirection:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPPanDirection) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Pan", Selector = "mapTemplate:panWithDirection:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPPanDirection) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBeginPanGesture", Selector = "mapTemplateDidBeginPanGesture:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdatePanGesture", Selector = "mapTemplate:didUpdatePanGestureWithTranslation:velocity:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CGPoint), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndPanGesture", Selector = "mapTemplate:didEndPanGestureWithVelocity:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillShowNavigationAlert", Selector = "mapTemplate:willShowNavigationAlert:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPNavigationAlert) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidShowNavigationAlert", Selector = "mapTemplate:didShowNavigationAlert:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPNavigationAlert) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDismissNavigationAlert", Selector = "mapTemplate:willDismissNavigationAlert:dismissalContext:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPNavigationAlert), typeof (CarPlay.CPNavigationAlertDismissalContext) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismissNavigationAlert", Selector = "mapTemplate:didDismissNavigationAlert:dismissalContext:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPNavigationAlert), typeof (CarPlay.CPNavigationAlertDismissalContext) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectedPreview", Selector = "mapTemplate:selectedPreviewForTrip:usingRouteChoice:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPTrip), typeof (CarPlay.CPRouteChoice) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StartedTrip", Selector = "mapTemplate:startedTrip:usingRouteChoice:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPTrip), typeof (CarPlay.CPRouteChoice) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCancelNavigation", Selector = "mapTemplateDidCancelNavigation:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDisplayStyle", Selector = "mapTemplate:displayStyleForManeuver:", ReturnType = typeof (CarPlay.CPManeuverDisplayStyle), ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CarPlay.CPManeuver) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndZoomGesture", Selector = "mapTemplate:didEndZoomGestureWithVelocity:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (NFloat) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRotate", Selector = "mapTemplate:didRotateWithCenter:rotation:velocity:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CGPoint), typeof (NFloat), typeof (NFloat) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateZoomGesture", Selector = "mapTemplate:didUpdateZoomGestureWithCenter:scale:velocity:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CGPoint), typeof (NFloat), typeof (NFloat) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PitchEnded", Selector = "mapTemplate:pitchEndedWithCenter:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Pitch", Selector = "mapTemplate:pitchWithCenter:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RotationDidEnd", Selector = "mapTemplate:rotationDidEndWithVelocity:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate), typeof (NFloat) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBeginPitchGesture", Selector = "mapTemplateDidBeginPitchGesture:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBeginRotationGesture", Selector = "mapTemplateDidBeginRotationGesture:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBeginZoomGesture", Selector = "mapTemplateDidBeginZoomGesture:", ParameterType = new Type [] { typeof (CarPlay.CPMapTemplate) }, ParameterByRef = new bool [] { false })]
	public partial interface ICPMapTemplateDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("mapTemplateShouldProvideNavigationMetadata:")]
		[SupportedOSPlatform ("ios17.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProvideNavigationMetadata (CPMapTemplate mapTemplate)
		{
			return _ShouldProvideNavigationMetadata (this, mapTemplate);
		}
		[SupportedOSPlatform ("ios17.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldProvideNavigationMetadata (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateShouldProvideNavigationMetadata:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("mapTemplateShouldProvideRouteSharing:")]
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProvideRouteSharing (CPMapTemplate mapTemplate)
		{
			return _ShouldProvideRouteSharing (this, mapTemplate);
		}
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldProvideRouteSharing (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateShouldProvideRouteSharing:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:didRequestToInsertWaypoint:intoSegment:completion:")]
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidRequestToInsertWaypoint (CPMapTemplate mapTemplate, CPNavigationWaypoint waypoint, CPRouteSegment segment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCPMapTemplateDidRequestToInsertWaypointHandler))]CPMapTemplateDidRequestToInsertWaypointHandler completion)
		{
			_DidRequestToInsertWaypoint (this, mapTemplate, waypoint, segment, completion);
		}
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidRequestToInsertWaypoint (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPNavigationWaypoint waypoint, CPRouteSegment segment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCPMapTemplateDidRequestToInsertWaypointHandler))]CPMapTemplateDidRequestToInsertWaypointHandler completion)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var waypoint__handle__ = waypoint!.GetNonNullHandle (nameof (waypoint));
			var segment__handle__ = segment!.GetNonNullHandle (nameof (segment));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDCPMapTemplateDidRequestToInsertWaypointHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:didRequestToInsertWaypoint:intoSegment:completion:"), mapTemplate__handle__, waypoint__handle__, segment__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (waypoint);
			GC.KeepAlive (segment);
		}
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:mapTemplateWaypoint:accepted:forSegment:")]
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapTemplateWaypoint (CPMapTemplate mapTemplate, CPNavigationWaypoint waypoint, bool accepted, CPRouteSegment? segment)
		{
			_MapTemplateWaypoint (this, mapTemplate, waypoint, accepted, segment);
		}
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MapTemplateWaypoint (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPNavigationWaypoint waypoint, bool accepted, CPRouteSegment? segment)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var waypoint__handle__ = waypoint!.GetNonNullHandle (nameof (waypoint));
			var segment__handle__ = segment.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:mapTemplateWaypoint:accepted:forSegment:"), mapTemplate__handle__, waypoint__handle__, accepted ? (byte) 1 : (byte) 0, segment__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (waypoint);
			GC.KeepAlive (segment);
		}
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:didReceiveUpdatedRouteSource:")]
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveUpdatedRouteSource (CPMapTemplate mapTemplate, CPRouteSource routeSource)
		{
			_DidReceiveUpdatedRouteSource (this, mapTemplate, routeSource);
		}
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveUpdatedRouteSource (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPRouteSource routeSource)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("mapTemplate:didReceiveUpdatedRouteSource:"), mapTemplate__handle__, (UIntPtr) (ulong) routeSource);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:didReceiveRequestForDestination:")]
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveRequestForDestination (CPMapTemplate mapTemplate, CPNavigationWaypoint waypoint)
		{
			_DidReceiveRequestForDestination (this, mapTemplate, waypoint);
		}
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveRequestForDestination (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPNavigationWaypoint waypoint)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var waypoint__handle__ = waypoint!.GetNonNullHandle (nameof (waypoint));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:didReceiveRequestForDestination:"), mapTemplate__handle__, waypoint__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (waypoint);
		}
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:willShareDestinationForTrip:")]
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillShareDestination (CPMapTemplate mapTemplate, CPTrip trip)
		{
			_WillShareDestination (this, mapTemplate, trip);
		}
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillShareDestination (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPTrip trip)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var trip__handle__ = trip!.GetNonNullHandle (nameof (trip));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:willShareDestinationForTrip:"), mapTemplate__handle__, trip__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (trip);
		}
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:didFailToShareDestinationForTrip:error:")]
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToShareDestination (CPMapTemplate mapTemplate, CPTrip trip, NSError error)
		{
			_DidFailToShareDestination (this, mapTemplate, trip, error);
		}
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailToShareDestination (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPTrip trip, NSError error)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var trip__handle__ = trip!.GetNonNullHandle (nameof (trip));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:didFailToShareDestinationForTrip:error:"), mapTemplate__handle__, trip__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (trip);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:didShareDestinationForTrip:")]
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidShareDestination (CPMapTemplate mapTemplate, CPTrip trip)
		{
			_DidShareDestination (this, mapTemplate, trip);
		}
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidShareDestination (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPTrip trip)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var trip__handle__ = trip!.GetNonNullHandle (nameof (trip));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:didShareDestinationForTrip:"), mapTemplate__handle__, trip__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (trip);
		}
		/// <param name="mapTemplate">The template for the map to query.</param><param name="maneuver">The maneuver about which to query.</param><summary>Method that is called to determine whether a navigation maneuver notification should be shown when the app is running in the background.</summary><returns><see langword="true" /> if the notification should be shown. Otherwise, <see langword="false" />.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:shouldShowNotificationForManeuver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowNotificationForManeuver (CPMapTemplate mapTemplate, CPManeuver maneuver)
		{
			return _ShouldShowNotificationForManeuver (this, mapTemplate, maneuver);
		}
		/// <param name="mapTemplate">The template for the map to query.</param><param name="maneuver">The maneuver about which to query.</param><summary>Method that is called to determine whether a navigation maneuver notification should be shown when the app is running in the background.</summary><returns><see langword="true" /> if the notification should be shown. Otherwise, <see langword="false" />.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldShowNotificationForManeuver (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPManeuver maneuver)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var maneuver__handle__ = maneuver!.GetNonNullHandle (nameof (maneuver));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:shouldShowNotificationForManeuver:"), mapTemplate__handle__, maneuver__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (maneuver);
			return ret != 0;
		}
		/// <param name="mapTemplate">The template for the map to query.</param><param name="maneuver">To be added.</param><param name="travelEstimates">The travel estimates about which to query.</param><summary>Method that is called to determine whether the specified travel estimate updates should be shown when the app is running in the background.</summary><returns><see langword="true" /> if the specified travel estimate updates should be shown. Otherwise, <see langword="false" />.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:shouldUpdateNotificationForManeuver:withTravelEstimates:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldUpdateNotificationForManeuver (CPMapTemplate mapTemplate, CPManeuver maneuver, CPTravelEstimates travelEstimates)
		{
			return _ShouldUpdateNotificationForManeuver (this, mapTemplate, maneuver, travelEstimates);
		}
		/// <param name="mapTemplate">The template for the map to query.</param><param name="maneuver">To be added.</param><param name="travelEstimates">The travel estimates about which to query.</param><summary>Method that is called to determine whether the specified travel estimate updates should be shown when the app is running in the background.</summary><returns><see langword="true" /> if the specified travel estimate updates should be shown. Otherwise, <see langword="false" />.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldUpdateNotificationForManeuver (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPManeuver maneuver, CPTravelEstimates travelEstimates)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var maneuver__handle__ = maneuver!.GetNonNullHandle (nameof (maneuver));
			var travelEstimates__handle__ = travelEstimates!.GetNonNullHandle (nameof (travelEstimates));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:shouldUpdateNotificationForManeuver:withTravelEstimates:"), mapTemplate__handle__, maneuver__handle__, travelEstimates__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (maneuver);
			GC.KeepAlive (travelEstimates);
			return ret != 0;
		}
		/// <param name="mapTemplate">The template for the map to query.</param><param name="navigationAlert">The navigation alert about which to query.</param><summary>Method that is called to determine whether a navigation alert should be shown when the app is running in the background.</summary><returns><see langword="true" /> if the navigation alert should be shown. Otherwise, <see langword="false" />.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:shouldShowNotificationForNavigationAlert:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowNotificationForNavigationAlert (CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert)
		{
			return _ShouldShowNotificationForNavigationAlert (this, mapTemplate, navigationAlert);
		}
		/// <param name="mapTemplate">The template for the map to query.</param><param name="navigationAlert">The navigation alert about which to query.</param><summary>Method that is called to determine whether a navigation alert should be shown when the app is running in the background.</summary><returns><see langword="true" /> if the navigation alert should be shown. Otherwise, <see langword="false" />.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldShowNotificationForNavigationAlert (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var navigationAlert__handle__ = navigationAlert!.GetNonNullHandle (nameof (navigationAlert));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:shouldShowNotificationForNavigationAlert:"), mapTemplate__handle__, navigationAlert__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (navigationAlert);
			return ret != 0;
		}
		/// <param name="mapTemplate">The template for the map for which a panning interface was shown.</param><summary>Method that is called when a panning interface is shown.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplateDidShowPanningInterface:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidShowPanningInterface (CPMapTemplate mapTemplate)
		{
			_DidShowPanningInterface (this, mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map for which a panning interface was shown.</param><summary>Method that is called when a panning interface is shown.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidShowPanningInterface (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateDidShowPanningInterface:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map on which a panning interface will be dismissed.</param><summary>Method that is called just before a panning interface is dismissed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplateWillDismissPanningInterface:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissPanningInterface (CPMapTemplate mapTemplate)
		{
			_WillDismissPanningInterface (this, mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map on which a panning interface will be dismissed.</param><summary>Method that is called just before a panning interface is dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDismissPanningInterface (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateWillDismissPanningInterface:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map whose panning interface was dismissed.</param><summary>Method that is called when a panning interface is dismissed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplateDidDismissPanningInterface:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissPanningInterface (CPMapTemplate mapTemplate)
		{
			_DidDismissPanningInterface (this, mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map whose panning interface was dismissed.</param><summary>Method that is called when a panning interface is dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDismissPanningInterface (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateDidDismissPanningInterface:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map for which a pan was started.</param><param name="direction">The direction of the pan.</param><summary>Method that is called when a pan begins.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:panBeganWithDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PanBegan (CPMapTemplate mapTemplate, CPPanDirection direction)
		{
			_PanBegan (this, mapTemplate, direction);
		}
		/// <param name="mapTemplate">The template for the map for which a pan was started.</param><param name="direction">The direction of the pan.</param><summary>Method that is called when a pan begins.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PanBegan (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPPanDirection direction)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("mapTemplate:panBeganWithDirection:"), mapTemplate__handle__, (IntPtr) (long) direction);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map for which a pan was ended.</param><param name="direction">The direction of the pan.</param><summary>Method that is called when a pan ends.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:panEndedWithDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PanEnded (CPMapTemplate mapTemplate, CPPanDirection direction)
		{
			_PanEnded (this, mapTemplate, direction);
		}
		/// <param name="mapTemplate">The template for the map for which a pan was ended.</param><param name="direction">The direction of the pan.</param><summary>Method that is called when a pan ends.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PanEnded (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPPanDirection direction)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("mapTemplate:panEndedWithDirection:"), mapTemplate__handle__, (IntPtr) (long) direction);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map to pan.</param><param name="direction">The direction to pan.</param><summary>Pans the map.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:panWithDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Pan (CPMapTemplate mapTemplate, CPPanDirection direction)
		{
			_Pan (this, mapTemplate, direction);
		}
		/// <param name="mapTemplate">The template for the map to pan.</param><param name="direction">The direction to pan.</param><summary>Pans the map.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Pan (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPPanDirection direction)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("mapTemplate:panWithDirection:"), mapTemplate__handle__, (IntPtr) (long) direction);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map that is panning.</param><summary>Method that is called when a pan gesture starts.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplateDidBeginPanGesture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginPanGesture (CPMapTemplate mapTemplate)
		{
			_DidBeginPanGesture (this, mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map that is panning.</param><summary>Method that is called when a pan gesture starts.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBeginPanGesture (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateDidBeginPanGesture:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map whose pan gesture was updated.</param><param name="translation">To be added.</param><param name="velocity">The pan velocity.</param><summary>Method that is called when a pan gesture is updated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:didUpdatePanGestureWithTranslation:velocity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdatePanGesture (CPMapTemplate mapTemplate, CGPoint translation, CGPoint velocity)
		{
			_DidUpdatePanGesture (this, mapTemplate, translation, velocity);
		}
		/// <param name="mapTemplate">The template for the map whose pan gesture was updated.</param><param name="translation">To be added.</param><param name="velocity">The pan velocity.</param><summary>Method that is called when a pan gesture is updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdatePanGesture (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CGPoint translation, CGPoint velocity)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_CGPoint (This.Handle, Selector.GetHandle ("mapTemplate:didUpdatePanGestureWithTranslation:velocity:"), mapTemplate__handle__, translation, velocity);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map whose pan gesture ended.</param><param name="velocity">To be added.</param><summary>Method that is called when a panning interface ends.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:didEndPanGestureWithVelocity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndPanGesture (CPMapTemplate mapTemplate, CGPoint velocity)
		{
			_DidEndPanGesture (this, mapTemplate, velocity);
		}
		/// <param name="mapTemplate">The template for the map whose pan gesture ended.</param><param name="velocity">To be added.</param><summary>Method that is called when a panning interface ends.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEndPanGesture (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CGPoint velocity)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("mapTemplate:didEndPanGestureWithVelocity:"), mapTemplate__handle__, velocity);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map for which a navigation alert will be shown.</param><param name="navigationAlert">The navigation alert that will be shown.</param><summary>Method that is called just before a navigation alert is shown.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:willShowNavigationAlert:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillShowNavigationAlert (CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert)
		{
			_WillShowNavigationAlert (this, mapTemplate, navigationAlert);
		}
		/// <param name="mapTemplate">The template for the map for which a navigation alert will be shown.</param><param name="navigationAlert">The navigation alert that will be shown.</param><summary>Method that is called just before a navigation alert is shown.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillShowNavigationAlert (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var navigationAlert__handle__ = navigationAlert!.GetNonNullHandle (nameof (navigationAlert));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:willShowNavigationAlert:"), mapTemplate__handle__, navigationAlert__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (navigationAlert);
		}
		/// <param name="mapTemplate">The template for the map for which a navigation alert was shown.</param><param name="navigationAlert">The alert that was shown.</param><summary>Method that is called when a navigation alert is shown.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:didShowNavigationAlert:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidShowNavigationAlert (CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert)
		{
			_DidShowNavigationAlert (this, mapTemplate, navigationAlert);
		}
		/// <param name="mapTemplate">The template for the map for which a navigation alert was shown.</param><param name="navigationAlert">The alert that was shown.</param><summary>Method that is called when a navigation alert is shown.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidShowNavigationAlert (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var navigationAlert__handle__ = navigationAlert!.GetNonNullHandle (nameof (navigationAlert));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:didShowNavigationAlert:"), mapTemplate__handle__, navigationAlert__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (navigationAlert);
		}
		/// <param name="mapTemplate">The template for the map for which a navigation alert will be dismissed.</param><param name="navigationAlert">The alert that will be dismissed.</param><param name="dismissalContext">The reason the alert will be dismissed.</param><summary>Method that is called just before a navigation alert is dismissed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:willDismissNavigationAlert:dismissalContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissNavigationAlert (CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert, CPNavigationAlertDismissalContext dismissalContext)
		{
			_WillDismissNavigationAlert (this, mapTemplate, navigationAlert, dismissalContext);
		}
		/// <param name="mapTemplate">The template for the map for which a navigation alert will be dismissed.</param><param name="navigationAlert">The alert that will be dismissed.</param><param name="dismissalContext">The reason the alert will be dismissed.</param><summary>Method that is called just before a navigation alert is dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDismissNavigationAlert (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert, CPNavigationAlertDismissalContext dismissalContext)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var navigationAlert__handle__ = navigationAlert!.GetNonNullHandle (nameof (navigationAlert));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("mapTemplate:willDismissNavigationAlert:dismissalContext:"), mapTemplate__handle__, navigationAlert__handle__, (UIntPtr) (ulong) dismissalContext);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (navigationAlert);
		}
		/// <param name="mapTemplate">The template for the map whose navigation alert was canceled.</param><param name="navigationAlert">The alert that was canceled.</param><param name="dismissalContext">The reason the alert was dismissed.</param><summary>Method that is called when a navigation alert is canceled.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:didDismissNavigationAlert:dismissalContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissNavigationAlert (CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert, CPNavigationAlertDismissalContext dismissalContext)
		{
			_DidDismissNavigationAlert (this, mapTemplate, navigationAlert, dismissalContext);
		}
		/// <param name="mapTemplate">The template for the map whose navigation alert was canceled.</param><param name="navigationAlert">The alert that was canceled.</param><param name="dismissalContext">The reason the alert was dismissed.</param><summary>Method that is called when a navigation alert is canceled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDismissNavigationAlert (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert, CPNavigationAlertDismissalContext dismissalContext)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var navigationAlert__handle__ = navigationAlert!.GetNonNullHandle (nameof (navigationAlert));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("mapTemplate:didDismissNavigationAlert:dismissalContext:"), mapTemplate__handle__, navigationAlert__handle__, (UIntPtr) (ulong) dismissalContext);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (navigationAlert);
		}
		/// <param name="mapTemplate">To be added</param><param name="trip">To be added.</param><param name="routeChoice">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:selectedPreviewForTrip:usingRouteChoice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectedPreview (CPMapTemplate mapTemplate, CPTrip trip, CPRouteChoice routeChoice)
		{
			_SelectedPreview (this, mapTemplate, trip, routeChoice);
		}
		/// <param name="mapTemplate">To be added</param><param name="trip">To be added.</param><param name="routeChoice">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectedPreview (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPTrip trip, CPRouteChoice routeChoice)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var trip__handle__ = trip!.GetNonNullHandle (nameof (trip));
			var routeChoice__handle__ = routeChoice!.GetNonNullHandle (nameof (routeChoice));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:selectedPreviewForTrip:usingRouteChoice:"), mapTemplate__handle__, trip__handle__, routeChoice__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (trip);
			GC.KeepAlive (routeChoice);
		}
		/// <param name="mapTemplate">The template for the map on which a trip was started.</param><param name="trip">The trip that started.</param><param name="routeChoice">The route choice for the trip that started.</param><summary>Method that is called when a trip starts.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:startedTrip:usingRouteChoice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartedTrip (CPMapTemplate mapTemplate, CPTrip trip, CPRouteChoice routeChoice)
		{
			_StartedTrip (this, mapTemplate, trip, routeChoice);
		}
		/// <param name="mapTemplate">The template for the map on which a trip was started.</param><param name="trip">The trip that started.</param><param name="routeChoice">The route choice for the trip that started.</param><summary>Method that is called when a trip starts.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _StartedTrip (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPTrip trip, CPRouteChoice routeChoice)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var trip__handle__ = trip!.GetNonNullHandle (nameof (trip));
			var routeChoice__handle__ = routeChoice!.GetNonNullHandle (nameof (routeChoice));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:startedTrip:usingRouteChoice:"), mapTemplate__handle__, trip__handle__, routeChoice__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (trip);
			GC.KeepAlive (routeChoice);
		}
		/// <param name="mapTemplate">The template for the map whose navigation was canceled.</param><summary>Method that is called when navigation is canceled.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplateDidCancelNavigation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancelNavigation (CPMapTemplate mapTemplate)
		{
			_DidCancelNavigation (this, mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map whose navigation was canceled.</param><summary>Method that is called when navigation is canceled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCancelNavigation (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateDidCancelNavigation:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map that .</param><param name="maneuver">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:displayStyleForManeuver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CPManeuverDisplayStyle GetDisplayStyle (CPMapTemplate mapTemplate, CPManeuver maneuver)
		{
			return _GetDisplayStyle (this, mapTemplate, maneuver);
		}
		/// <param name="mapTemplate">The template for the map that .</param><param name="maneuver">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CPManeuverDisplayStyle _GetDisplayStyle (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPManeuver maneuver)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var maneuver__handle__ = maneuver!.GetNonNullHandle (nameof (maneuver));
			CPManeuverDisplayStyle ret;
			ret = (CarPlay.CPManeuverDisplayStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:displayStyleForManeuver:"), mapTemplate__handle__, maneuver__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (maneuver);
			return ret!;
		}
		/// <param name="mapTemplate">The template for the map whose zoom gesture ended.</param><param name="velocity">The zoom velocity at the end of the gesture.</param><summary>Method that is called when a zoom gesture ends.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:didEndZoomGestureWithVelocity:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndZoomGesture (CPMapTemplate mapTemplate, nfloat velocity)
		{
			_DidEndZoomGesture (this, mapTemplate, velocity);
		}
		/// <param name="mapTemplate">The template for the map whose zoom gesture ended.</param><param name="velocity">The zoom velocity at the end of the gesture.</param><summary>Method that is called when a zoom gesture ends.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEndZoomGesture (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, nfloat velocity)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat (This.Handle, Selector.GetHandle ("mapTemplate:didEndZoomGestureWithVelocity:"), mapTemplate__handle__, velocity);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map that was rotated.</param><param name="center">The center point of the rotation.</param><param name="rotation">The rotation angle in radians.</param><param name="velocity">The rotation velocity.</param><summary>Method that is called when the map is rotated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:didRotateWithCenter:rotation:velocity:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRotate (CPMapTemplate mapTemplate, CGPoint center, nfloat rotation, nfloat velocity)
		{
			_DidRotate (this, mapTemplate, center, rotation, velocity);
		}
		/// <param name="mapTemplate">The template for the map that was rotated.</param><param name="center">The center point of the rotation.</param><param name="rotation">The rotation angle in radians.</param><param name="velocity">The rotation velocity.</param><summary>Method that is called when the map is rotated.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRotate (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CGPoint center, nfloat rotation, nfloat velocity)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_nfloat_nfloat (This.Handle, Selector.GetHandle ("mapTemplate:didRotateWithCenter:rotation:velocity:"), mapTemplate__handle__, center, rotation, velocity);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map whose zoom gesture was updated.</param><param name="center">The center point of the zoom gesture.</param><param name="scale">The current zoom scale.</param><param name="velocity">The zoom velocity.</param><summary>Method that is called when a zoom gesture is updated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:didUpdateZoomGestureWithCenter:scale:velocity:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateZoomGesture (CPMapTemplate mapTemplate, CGPoint center, nfloat scale, nfloat velocity)
		{
			_DidUpdateZoomGesture (this, mapTemplate, center, scale, velocity);
		}
		/// <param name="mapTemplate">The template for the map whose zoom gesture was updated.</param><param name="center">The center point of the zoom gesture.</param><param name="scale">The current zoom scale.</param><param name="velocity">The zoom velocity.</param><summary>Method that is called when a zoom gesture is updated.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateZoomGesture (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CGPoint center, nfloat scale, nfloat velocity)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_nfloat_nfloat (This.Handle, Selector.GetHandle ("mapTemplate:didUpdateZoomGestureWithCenter:scale:velocity:"), mapTemplate__handle__, center, scale, velocity);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map whose pitch gesture ended.</param><param name="center">The center point of the pitch gesture.</param><summary>Method that is called when a pitch gesture ends.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:pitchEndedWithCenter:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PitchEnded (CPMapTemplate mapTemplate, CGPoint center)
		{
			_PitchEnded (this, mapTemplate, center);
		}
		/// <param name="mapTemplate">The template for the map whose pitch gesture ended.</param><param name="center">The center point of the pitch gesture.</param><summary>Method that is called when a pitch gesture ends.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PitchEnded (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CGPoint center)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("mapTemplate:pitchEndedWithCenter:"), mapTemplate__handle__, center);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map that is being pitched.</param><param name="center">The center point of the pitch gesture.</param><summary>Method that is called when the map is pitched.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:pitchWithCenter:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Pitch (CPMapTemplate mapTemplate, CGPoint center)
		{
			_Pitch (this, mapTemplate, center);
		}
		/// <param name="mapTemplate">The template for the map that is being pitched.</param><param name="center">The center point of the pitch gesture.</param><summary>Method that is called when the map is pitched.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Pitch (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CGPoint center)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("mapTemplate:pitchWithCenter:"), mapTemplate__handle__, center);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map whose rotation gesture ended.</param><param name="velocity">The rotation velocity at the end of the gesture.</param><summary>Method that is called when a rotation gesture ends.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplate:rotationDidEndWithVelocity:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RotationDidEnd (CPMapTemplate mapTemplate, nfloat velocity)
		{
			_RotationDidEnd (this, mapTemplate, velocity);
		}
		/// <param name="mapTemplate">The template for the map whose rotation gesture ended.</param><param name="velocity">The rotation velocity at the end of the gesture.</param><summary>Method that is called when a rotation gesture ends.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RotationDidEnd (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, nfloat velocity)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat (This.Handle, Selector.GetHandle ("mapTemplate:rotationDidEndWithVelocity:"), mapTemplate__handle__, velocity);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map that began a pitch gesture.</param><summary>Method that is called when a pitch gesture begins.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplateDidBeginPitchGesture:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginPitchGesture (CPMapTemplate mapTemplate)
		{
			_DidBeginPitchGesture (this, mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map that began a pitch gesture.</param><summary>Method that is called when a pitch gesture begins.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBeginPitchGesture (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateDidBeginPitchGesture:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map that began a rotation gesture.</param><summary>Method that is called when a rotation gesture begins.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplateDidBeginRotationGesture:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginRotationGesture (CPMapTemplate mapTemplate)
		{
			_DidBeginRotationGesture (this, mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map that began a rotation gesture.</param><summary>Method that is called when a rotation gesture begins.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBeginRotationGesture (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateDidBeginRotationGesture:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map that began a zoom gesture.</param><summary>Method that is called when a zoom gesture begins.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mapTemplateDidBeginZoomGesture:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginZoomGesture (CPMapTemplate mapTemplate)
		{
			_DidBeginZoomGesture (this, mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map that began a zoom gesture.</param><summary>Method that is called when a zoom gesture begins.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBeginZoomGesture (ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateDidBeginZoomGesture:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		[DynamicDependencyAttribute ("DidBeginPanGesture(CarPlay.CPMapTemplate)")]
		[DynamicDependencyAttribute ("DidBeginPitchGesture(CarPlay.CPMapTemplate)")]
		[DynamicDependencyAttribute ("DidBeginRotationGesture(CarPlay.CPMapTemplate)")]
		[DynamicDependencyAttribute ("DidBeginZoomGesture(CarPlay.CPMapTemplate)")]
		[DynamicDependencyAttribute ("DidCancelNavigation(CarPlay.CPMapTemplate)")]
		[DynamicDependencyAttribute ("DidDismissNavigationAlert(CarPlay.CPMapTemplate,CarPlay.CPNavigationAlert,CarPlay.CPNavigationAlertDismissalContext)")]
		[DynamicDependencyAttribute ("DidDismissPanningInterface(CarPlay.CPMapTemplate)")]
		[DynamicDependencyAttribute ("DidEndPanGesture(CarPlay.CPMapTemplate,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("DidEndZoomGesture(CarPlay.CPMapTemplate,System.Runtime.InteropServices.NFloat)")]
		[DynamicDependencyAttribute ("DidFailToShareDestination(CarPlay.CPMapTemplate,CarPlay.CPTrip,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidReceiveRequestForDestination(CarPlay.CPMapTemplate,CarPlay.CPNavigationWaypoint)")]
		[DynamicDependencyAttribute ("DidReceiveUpdatedRouteSource(CarPlay.CPMapTemplate,CarPlay.CPRouteSource)")]
		[DynamicDependencyAttribute ("DidRequestToInsertWaypoint(CarPlay.CPMapTemplate,CarPlay.CPNavigationWaypoint,CarPlay.CPRouteSegment,CarPlay.CPMapTemplateDidRequestToInsertWaypointHandler)")]
		[DynamicDependencyAttribute ("DidRotate(CarPlay.CPMapTemplate,CoreGraphics.CGPoint,System.Runtime.InteropServices.NFloat,System.Runtime.InteropServices.NFloat)")]
		[DynamicDependencyAttribute ("DidShareDestination(CarPlay.CPMapTemplate,CarPlay.CPTrip)")]
		[DynamicDependencyAttribute ("DidShowNavigationAlert(CarPlay.CPMapTemplate,CarPlay.CPNavigationAlert)")]
		[DynamicDependencyAttribute ("DidShowPanningInterface(CarPlay.CPMapTemplate)")]
		[DynamicDependencyAttribute ("DidUpdatePanGesture(CarPlay.CPMapTemplate,CoreGraphics.CGPoint,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("DidUpdateZoomGesture(CarPlay.CPMapTemplate,CoreGraphics.CGPoint,System.Runtime.InteropServices.NFloat,System.Runtime.InteropServices.NFloat)")]
		[DynamicDependencyAttribute ("GetDisplayStyle(CarPlay.CPMapTemplate,CarPlay.CPManeuver)")]
		[DynamicDependencyAttribute ("MapTemplateWaypoint(CarPlay.CPMapTemplate,CarPlay.CPNavigationWaypoint,System.Boolean,CarPlay.CPRouteSegment)")]
		[DynamicDependencyAttribute ("Pan(CarPlay.CPMapTemplate,CarPlay.CPPanDirection)")]
		[DynamicDependencyAttribute ("PanBegan(CarPlay.CPMapTemplate,CarPlay.CPPanDirection)")]
		[DynamicDependencyAttribute ("PanEnded(CarPlay.CPMapTemplate,CarPlay.CPPanDirection)")]
		[DynamicDependencyAttribute ("Pitch(CarPlay.CPMapTemplate,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("PitchEnded(CarPlay.CPMapTemplate,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("RotationDidEnd(CarPlay.CPMapTemplate,System.Runtime.InteropServices.NFloat)")]
		[DynamicDependencyAttribute ("SelectedPreview(CarPlay.CPMapTemplate,CarPlay.CPTrip,CarPlay.CPRouteChoice)")]
		[DynamicDependencyAttribute ("ShouldProvideNavigationMetadata(CarPlay.CPMapTemplate)")]
		[DynamicDependencyAttribute ("ShouldProvideRouteSharing(CarPlay.CPMapTemplate)")]
		[DynamicDependencyAttribute ("ShouldShowNotificationForManeuver(CarPlay.CPMapTemplate,CarPlay.CPManeuver)")]
		[DynamicDependencyAttribute ("ShouldShowNotificationForNavigationAlert(CarPlay.CPMapTemplate,CarPlay.CPNavigationAlert)")]
		[DynamicDependencyAttribute ("ShouldUpdateNotificationForManeuver(CarPlay.CPMapTemplate,CarPlay.CPManeuver,CarPlay.CPTravelEstimates)")]
		[DynamicDependencyAttribute ("StartedTrip(CarPlay.CPMapTemplate,CarPlay.CPTrip,CarPlay.CPRouteChoice)")]
		[DynamicDependencyAttribute ("WillDismissNavigationAlert(CarPlay.CPMapTemplate,CarPlay.CPNavigationAlert,CarPlay.CPNavigationAlertDismissalContext)")]
		[DynamicDependencyAttribute ("WillDismissPanningInterface(CarPlay.CPMapTemplate)")]
		[DynamicDependencyAttribute ("WillShareDestination(CarPlay.CPMapTemplate,CarPlay.CPTrip)")]
		[DynamicDependencyAttribute ("WillShowNavigationAlert(CarPlay.CPMapTemplate,CarPlay.CPNavigationAlert)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPMapTemplateDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICPMapTemplateDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICPMapTemplateDelegate" /> interface to support all the methods from the CPMapTemplateDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICPMapTemplateDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CPMapTemplateDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CPMapTemplateDelegate_Extensions {
		[SupportedOSPlatform ("ios17.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldProvideNavigationMetadata (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateShouldProvideNavigationMetadata:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			return ret != 0;
		}
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldProvideRouteSharing (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateShouldProvideRouteSharing:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			return ret != 0;
		}
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidRequestToInsertWaypoint (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPNavigationWaypoint waypoint, CPRouteSegment segment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCPMapTemplateDidRequestToInsertWaypointHandler))]CPMapTemplateDidRequestToInsertWaypointHandler completion)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var waypoint__handle__ = waypoint!.GetNonNullHandle (nameof (waypoint));
			var segment__handle__ = segment!.GetNonNullHandle (nameof (segment));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDCPMapTemplateDidRequestToInsertWaypointHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:didRequestToInsertWaypoint:intoSegment:completion:"), mapTemplate__handle__, waypoint__handle__, segment__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (waypoint);
			GC.KeepAlive (segment);
		}
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MapTemplateWaypoint (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPNavigationWaypoint waypoint, bool accepted, CPRouteSegment? segment)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var waypoint__handle__ = waypoint!.GetNonNullHandle (nameof (waypoint));
			var segment__handle__ = segment.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:mapTemplateWaypoint:accepted:forSegment:"), mapTemplate__handle__, waypoint__handle__, accepted ? (byte) 1 : (byte) 0, segment__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (waypoint);
			GC.KeepAlive (segment);
		}
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveUpdatedRouteSource (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPRouteSource routeSource)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("mapTemplate:didReceiveUpdatedRouteSource:"), mapTemplate__handle__, (UIntPtr) (ulong) routeSource);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveRequestForDestination (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPNavigationWaypoint waypoint)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var waypoint__handle__ = waypoint!.GetNonNullHandle (nameof (waypoint));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:didReceiveRequestForDestination:"), mapTemplate__handle__, waypoint__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (waypoint);
		}
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillShareDestination (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPTrip trip)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var trip__handle__ = trip!.GetNonNullHandle (nameof (trip));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:willShareDestinationForTrip:"), mapTemplate__handle__, trip__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (trip);
		}
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailToShareDestination (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPTrip trip, NSError error)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var trip__handle__ = trip!.GetNonNullHandle (nameof (trip));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:didFailToShareDestinationForTrip:error:"), mapTemplate__handle__, trip__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (trip);
			GC.KeepAlive (error);
		}
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidShareDestination (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPTrip trip)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var trip__handle__ = trip!.GetNonNullHandle (nameof (trip));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:didShareDestinationForTrip:"), mapTemplate__handle__, trip__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (trip);
		}
		/// <param name="mapTemplate">The template for the map to query.</param><param name="maneuver">The maneuver about which to query.</param><summary>Method that is called to determine whether a navigation maneuver notification should be shown when the app is running in the background.</summary><returns><see langword="true" /> if the notification should be shown. Otherwise, <see langword="false" />.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldShowNotificationForManeuver (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPManeuver maneuver)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var maneuver__handle__ = maneuver!.GetNonNullHandle (nameof (maneuver));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:shouldShowNotificationForManeuver:"), mapTemplate__handle__, maneuver__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (maneuver);
			return ret != 0;
		}
		/// <param name="mapTemplate">The template for the map to query.</param><param name="maneuver">To be added.</param><param name="travelEstimates">The travel estimates about which to query.</param><summary>Method that is called to determine whether the specified travel estimate updates should be shown when the app is running in the background.</summary><returns><see langword="true" /> if the specified travel estimate updates should be shown. Otherwise, <see langword="false" />.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldUpdateNotificationForManeuver (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPManeuver maneuver, CPTravelEstimates travelEstimates)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var maneuver__handle__ = maneuver!.GetNonNullHandle (nameof (maneuver));
			var travelEstimates__handle__ = travelEstimates!.GetNonNullHandle (nameof (travelEstimates));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:shouldUpdateNotificationForManeuver:withTravelEstimates:"), mapTemplate__handle__, maneuver__handle__, travelEstimates__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (maneuver);
			GC.KeepAlive (travelEstimates);
			return ret != 0;
		}
		/// <param name="mapTemplate">The template for the map to query.</param><param name="navigationAlert">The navigation alert about which to query.</param><summary>Method that is called to determine whether a navigation alert should be shown when the app is running in the background.</summary><returns><see langword="true" /> if the navigation alert should be shown. Otherwise, <see langword="false" />.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldShowNotificationForNavigationAlert (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var navigationAlert__handle__ = navigationAlert!.GetNonNullHandle (nameof (navigationAlert));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:shouldShowNotificationForNavigationAlert:"), mapTemplate__handle__, navigationAlert__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (navigationAlert);
			return ret != 0;
		}
		/// <param name="mapTemplate">The template for the map for which a panning interface was shown.</param><summary>Method that is called when a panning interface is shown.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidShowPanningInterface (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateDidShowPanningInterface:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map on which a panning interface will be dismissed.</param><summary>Method that is called just before a panning interface is dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDismissPanningInterface (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateWillDismissPanningInterface:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map whose panning interface was dismissed.</param><summary>Method that is called when a panning interface is dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismissPanningInterface (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateDidDismissPanningInterface:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map for which a pan was started.</param><param name="direction">The direction of the pan.</param><summary>Method that is called when a pan begins.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PanBegan (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPPanDirection direction)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("mapTemplate:panBeganWithDirection:"), mapTemplate__handle__, (IntPtr) (long) direction);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map for which a pan was ended.</param><param name="direction">The direction of the pan.</param><summary>Method that is called when a pan ends.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PanEnded (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPPanDirection direction)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("mapTemplate:panEndedWithDirection:"), mapTemplate__handle__, (IntPtr) (long) direction);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map to pan.</param><param name="direction">The direction to pan.</param><summary>Pans the map.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Pan (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPPanDirection direction)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("mapTemplate:panWithDirection:"), mapTemplate__handle__, (IntPtr) (long) direction);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map that is panning.</param><summary>Method that is called when a pan gesture starts.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBeginPanGesture (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateDidBeginPanGesture:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map whose pan gesture was updated.</param><param name="translation">To be added.</param><param name="velocity">The pan velocity.</param><summary>Method that is called when a pan gesture is updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdatePanGesture (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CGPoint translation, CGPoint velocity)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_CGPoint (This.Handle, Selector.GetHandle ("mapTemplate:didUpdatePanGestureWithTranslation:velocity:"), mapTemplate__handle__, translation, velocity);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map whose pan gesture ended.</param><param name="velocity">To be added.</param><summary>Method that is called when a panning interface ends.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEndPanGesture (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CGPoint velocity)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("mapTemplate:didEndPanGestureWithVelocity:"), mapTemplate__handle__, velocity);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map for which a navigation alert will be shown.</param><param name="navigationAlert">The navigation alert that will be shown.</param><summary>Method that is called just before a navigation alert is shown.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillShowNavigationAlert (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var navigationAlert__handle__ = navigationAlert!.GetNonNullHandle (nameof (navigationAlert));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:willShowNavigationAlert:"), mapTemplate__handle__, navigationAlert__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (navigationAlert);
		}
		/// <param name="mapTemplate">The template for the map for which a navigation alert was shown.</param><param name="navigationAlert">The alert that was shown.</param><summary>Method that is called when a navigation alert is shown.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidShowNavigationAlert (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var navigationAlert__handle__ = navigationAlert!.GetNonNullHandle (nameof (navigationAlert));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:didShowNavigationAlert:"), mapTemplate__handle__, navigationAlert__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (navigationAlert);
		}
		/// <param name="mapTemplate">The template for the map for which a navigation alert will be dismissed.</param><param name="navigationAlert">The alert that will be dismissed.</param><param name="dismissalContext">The reason the alert will be dismissed.</param><summary>Method that is called just before a navigation alert is dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDismissNavigationAlert (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert, CPNavigationAlertDismissalContext dismissalContext)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var navigationAlert__handle__ = navigationAlert!.GetNonNullHandle (nameof (navigationAlert));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("mapTemplate:willDismissNavigationAlert:dismissalContext:"), mapTemplate__handle__, navigationAlert__handle__, (UIntPtr) (ulong) dismissalContext);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (navigationAlert);
		}
		/// <param name="mapTemplate">The template for the map whose navigation alert was canceled.</param><param name="navigationAlert">The alert that was canceled.</param><param name="dismissalContext">The reason the alert was dismissed.</param><summary>Method that is called when a navigation alert is canceled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismissNavigationAlert (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert, CPNavigationAlertDismissalContext dismissalContext)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var navigationAlert__handle__ = navigationAlert!.GetNonNullHandle (nameof (navigationAlert));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("mapTemplate:didDismissNavigationAlert:dismissalContext:"), mapTemplate__handle__, navigationAlert__handle__, (UIntPtr) (ulong) dismissalContext);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (navigationAlert);
		}
		/// <param name="mapTemplate">To be added</param><param name="trip">To be added.</param><param name="routeChoice">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SelectedPreview (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPTrip trip, CPRouteChoice routeChoice)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var trip__handle__ = trip!.GetNonNullHandle (nameof (trip));
			var routeChoice__handle__ = routeChoice!.GetNonNullHandle (nameof (routeChoice));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:selectedPreviewForTrip:usingRouteChoice:"), mapTemplate__handle__, trip__handle__, routeChoice__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (trip);
			GC.KeepAlive (routeChoice);
		}
		/// <param name="mapTemplate">The template for the map on which a trip was started.</param><param name="trip">The trip that started.</param><param name="routeChoice">The route choice for the trip that started.</param><summary>Method that is called when a trip starts.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StartedTrip (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPTrip trip, CPRouteChoice routeChoice)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var trip__handle__ = trip!.GetNonNullHandle (nameof (trip));
			var routeChoice__handle__ = routeChoice!.GetNonNullHandle (nameof (routeChoice));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:startedTrip:usingRouteChoice:"), mapTemplate__handle__, trip__handle__, routeChoice__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (trip);
			GC.KeepAlive (routeChoice);
		}
		/// <param name="mapTemplate">The template for the map whose navigation was canceled.</param><summary>Method that is called when navigation is canceled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCancelNavigation (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateDidCancelNavigation:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map that .</param><param name="maneuver">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CPManeuverDisplayStyle GetDisplayStyle (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CPManeuver maneuver)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			var maneuver__handle__ = maneuver!.GetNonNullHandle (nameof (maneuver));
			CPManeuverDisplayStyle ret;
			ret = (CarPlay.CPManeuverDisplayStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplate:displayStyleForManeuver:"), mapTemplate__handle__, maneuver__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
			GC.KeepAlive (maneuver);
			return ret!;
		}
		/// <param name="mapTemplate">The template for the map whose zoom gesture ended.</param><param name="velocity">The zoom velocity at the end of the gesture.</param><summary>Method that is called when a zoom gesture ends.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEndZoomGesture (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, nfloat velocity)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat (This.Handle, Selector.GetHandle ("mapTemplate:didEndZoomGestureWithVelocity:"), mapTemplate__handle__, velocity);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map that was rotated.</param><param name="center">The center point of the rotation.</param><param name="rotation">The rotation angle in radians.</param><param name="velocity">The rotation velocity.</param><summary>Method that is called when the map is rotated.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRotate (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CGPoint center, nfloat rotation, nfloat velocity)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_nfloat_nfloat (This.Handle, Selector.GetHandle ("mapTemplate:didRotateWithCenter:rotation:velocity:"), mapTemplate__handle__, center, rotation, velocity);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map whose zoom gesture was updated.</param><param name="center">The center point of the zoom gesture.</param><param name="scale">The current zoom scale.</param><param name="velocity">The zoom velocity.</param><summary>Method that is called when a zoom gesture is updated.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateZoomGesture (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CGPoint center, nfloat scale, nfloat velocity)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_nfloat_nfloat (This.Handle, Selector.GetHandle ("mapTemplate:didUpdateZoomGestureWithCenter:scale:velocity:"), mapTemplate__handle__, center, scale, velocity);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map whose pitch gesture ended.</param><param name="center">The center point of the pitch gesture.</param><summary>Method that is called when a pitch gesture ends.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PitchEnded (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CGPoint center)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("mapTemplate:pitchEndedWithCenter:"), mapTemplate__handle__, center);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map that is being pitched.</param><param name="center">The center point of the pitch gesture.</param><summary>Method that is called when the map is pitched.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Pitch (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, CGPoint center)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("mapTemplate:pitchWithCenter:"), mapTemplate__handle__, center);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map whose rotation gesture ended.</param><param name="velocity">The rotation velocity at the end of the gesture.</param><summary>Method that is called when a rotation gesture ends.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RotationDidEnd (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate, nfloat velocity)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat (This.Handle, Selector.GetHandle ("mapTemplate:rotationDidEndWithVelocity:"), mapTemplate__handle__, velocity);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map that began a pitch gesture.</param><summary>Method that is called when a pitch gesture begins.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBeginPitchGesture (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateDidBeginPitchGesture:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map that began a rotation gesture.</param><summary>Method that is called when a rotation gesture begins.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBeginRotationGesture (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateDidBeginRotationGesture:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
		/// <param name="mapTemplate">The template for the map that began a zoom gesture.</param><summary>Method that is called when a zoom gesture begins.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBeginZoomGesture (this ICPMapTemplateDelegate This, CPMapTemplate mapTemplate)
		{
			var mapTemplate__handle__ = mapTemplate!.GetNonNullHandle (nameof (mapTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mapTemplateDidBeginZoomGesture:"), mapTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (mapTemplate);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CPMapTemplateDelegateWrapper : BaseWrapper, ICPMapTemplateDelegate {
		public CPMapTemplateDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPMapTemplateDelegateWrapper))]
		static CPMapTemplateDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace CarPlay {
	/// <summary>Default implementation of <see cref="T:CarPlay.ICPMapTemplateDelegate" />, providing the delegate object for <see cref="T:CarPlay.CPMapTemplate" /> objects.</summary>
	[Protocol()]
	[Register("Microsoft_iOS__CarPlay_CPMapTemplateDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class CPMapTemplateDelegate : NSObject, ICPMapTemplateDelegate {
		/// <summary>Creates a new <see cref="CPMapTemplateDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CPMapTemplateDelegate () : base (NSObjectFlag.Empty)
		{
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
		protected CPMapTemplateDelegate (NSObjectFlag t) : base (t)
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
		protected internal CPMapTemplateDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="mapTemplate">The template for the map that is panning.</param><summary>Method that is called when a pan gesture starts.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplateDidBeginPanGesture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginPanGesture (CPMapTemplate mapTemplate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map that began a pitch gesture.</param><summary>Method that is called when a pitch gesture begins.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplateDidBeginPitchGesture:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginPitchGesture (CPMapTemplate mapTemplate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map that began a rotation gesture.</param><summary>Method that is called when a rotation gesture begins.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplateDidBeginRotationGesture:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginRotationGesture (CPMapTemplate mapTemplate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map that began a zoom gesture.</param><summary>Method that is called when a zoom gesture begins.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplateDidBeginZoomGesture:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginZoomGesture (CPMapTemplate mapTemplate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map whose navigation was canceled.</param><summary>Method that is called when navigation is canceled.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplateDidCancelNavigation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancelNavigation (CPMapTemplate mapTemplate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map whose navigation alert was canceled.</param><param name="navigationAlert">The alert that was canceled.</param><param name="dismissalContext">The reason the alert was dismissed.</param><summary>Method that is called when a navigation alert is canceled.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplate:didDismissNavigationAlert:dismissalContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissNavigationAlert (CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert, CPNavigationAlertDismissalContext dismissalContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map whose panning interface was dismissed.</param><summary>Method that is called when a panning interface is dismissed.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplateDidDismissPanningInterface:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissPanningInterface (CPMapTemplate mapTemplate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map whose pan gesture ended.</param><param name="velocity">To be added.</param><summary>Method that is called when a panning interface ends.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplate:didEndPanGestureWithVelocity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndPanGesture (CPMapTemplate mapTemplate, CGPoint velocity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map whose zoom gesture ended.</param><param name="velocity">The zoom velocity at the end of the gesture.</param><summary>Method that is called when a zoom gesture ends.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplate:didEndZoomGestureWithVelocity:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndZoomGesture (CPMapTemplate mapTemplate, nfloat velocity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("mapTemplate:didFailToShareDestinationForTrip:error:")]
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToShareDestination (CPMapTemplate mapTemplate, CPTrip trip, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("mapTemplate:didReceiveRequestForDestination:")]
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveRequestForDestination (CPMapTemplate mapTemplate, CPNavigationWaypoint waypoint)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("mapTemplate:didReceiveUpdatedRouteSource:")]
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveUpdatedRouteSource (CPMapTemplate mapTemplate, CPRouteSource routeSource)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("mapTemplate:didRequestToInsertWaypoint:intoSegment:completion:")]
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidRequestToInsertWaypoint (CPMapTemplate mapTemplate, CPNavigationWaypoint waypoint, CPRouteSegment segment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCPMapTemplateDidRequestToInsertWaypointHandler))]CPMapTemplateDidRequestToInsertWaypointHandler completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map that was rotated.</param><param name="center">The center point of the rotation.</param><param name="rotation">The rotation angle in radians.</param><param name="velocity">The rotation velocity.</param><summary>Method that is called when the map is rotated.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplate:didRotateWithCenter:rotation:velocity:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRotate (CPMapTemplate mapTemplate, CGPoint center, nfloat rotation, nfloat velocity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("mapTemplate:didShareDestinationForTrip:")]
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidShareDestination (CPMapTemplate mapTemplate, CPTrip trip)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map for which a navigation alert was shown.</param><param name="navigationAlert">The alert that was shown.</param><summary>Method that is called when a navigation alert is shown.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplate:didShowNavigationAlert:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidShowNavigationAlert (CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map for which a panning interface was shown.</param><summary>Method that is called when a panning interface is shown.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplateDidShowPanningInterface:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidShowPanningInterface (CPMapTemplate mapTemplate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map whose pan gesture was updated.</param><param name="translation">To be added.</param><param name="velocity">The pan velocity.</param><summary>Method that is called when a pan gesture is updated.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplate:didUpdatePanGestureWithTranslation:velocity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdatePanGesture (CPMapTemplate mapTemplate, CGPoint translation, CGPoint velocity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map whose zoom gesture was updated.</param><param name="center">The center point of the zoom gesture.</param><param name="scale">The current zoom scale.</param><param name="velocity">The zoom velocity.</param><summary>Method that is called when a zoom gesture is updated.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplate:didUpdateZoomGestureWithCenter:scale:velocity:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateZoomGesture (CPMapTemplate mapTemplate, CGPoint center, nfloat scale, nfloat velocity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map that .</param><param name="maneuver">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("mapTemplate:displayStyleForManeuver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CPManeuverDisplayStyle GetDisplayStyle (CPMapTemplate mapTemplate, CPManeuver maneuver)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("mapTemplate:mapTemplateWaypoint:accepted:forSegment:")]
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MapTemplateWaypoint (CPMapTemplate mapTemplate, CPNavigationWaypoint waypoint, bool accepted, CPRouteSegment? segment)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map to pan.</param><param name="direction">The direction to pan.</param><summary>Pans the map.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplate:panWithDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Pan (CPMapTemplate mapTemplate, CPPanDirection direction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map for which a pan was started.</param><param name="direction">The direction of the pan.</param><summary>Method that is called when a pan begins.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplate:panBeganWithDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PanBegan (CPMapTemplate mapTemplate, CPPanDirection direction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map for which a pan was ended.</param><param name="direction">The direction of the pan.</param><summary>Method that is called when a pan ends.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplate:panEndedWithDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PanEnded (CPMapTemplate mapTemplate, CPPanDirection direction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map that is being pitched.</param><param name="center">The center point of the pitch gesture.</param><summary>Method that is called when the map is pitched.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplate:pitchWithCenter:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Pitch (CPMapTemplate mapTemplate, CGPoint center)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map whose pitch gesture ended.</param><param name="center">The center point of the pitch gesture.</param><summary>Method that is called when a pitch gesture ends.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplate:pitchEndedWithCenter:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PitchEnded (CPMapTemplate mapTemplate, CGPoint center)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map whose rotation gesture ended.</param><param name="velocity">The rotation velocity at the end of the gesture.</param><summary>Method that is called when a rotation gesture ends.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplate:rotationDidEndWithVelocity:")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RotationDidEnd (CPMapTemplate mapTemplate, nfloat velocity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">To be added</param><param name="trip">To be added.</param><param name="routeChoice">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplate:selectedPreviewForTrip:usingRouteChoice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectedPreview (CPMapTemplate mapTemplate, CPTrip trip, CPRouteChoice routeChoice)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("mapTemplateShouldProvideNavigationMetadata:")]
		[SupportedOSPlatform ("ios17.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProvideNavigationMetadata (CPMapTemplate mapTemplate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("mapTemplateShouldProvideRouteSharing:")]
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProvideRouteSharing (CPMapTemplate mapTemplate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map to query.</param><param name="maneuver">The maneuver about which to query.</param><summary>Method that is called to determine whether a navigation maneuver notification should be shown when the app is running in the background.</summary><returns><see langword="true" /> if the notification should be shown. Otherwise, <see langword="false" />.</returns><remarks>To be added.</remarks>
		[Export ("mapTemplate:shouldShowNotificationForManeuver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowNotificationForManeuver (CPMapTemplate mapTemplate, CPManeuver maneuver)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map to query.</param><param name="navigationAlert">The navigation alert about which to query.</param><summary>Method that is called to determine whether a navigation alert should be shown when the app is running in the background.</summary><returns><see langword="true" /> if the navigation alert should be shown. Otherwise, <see langword="false" />.</returns><remarks>To be added.</remarks>
		[Export ("mapTemplate:shouldShowNotificationForNavigationAlert:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowNotificationForNavigationAlert (CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map to query.</param><param name="maneuver">To be added.</param><param name="travelEstimates">The travel estimates about which to query.</param><summary>Method that is called to determine whether the specified travel estimate updates should be shown when the app is running in the background.</summary><returns><see langword="true" /> if the specified travel estimate updates should be shown. Otherwise, <see langword="false" />.</returns><remarks>To be added.</remarks>
		[Export ("mapTemplate:shouldUpdateNotificationForManeuver:withTravelEstimates:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldUpdateNotificationForManeuver (CPMapTemplate mapTemplate, CPManeuver maneuver, CPTravelEstimates travelEstimates)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map on which a trip was started.</param><param name="trip">The trip that started.</param><param name="routeChoice">The route choice for the trip that started.</param><summary>Method that is called when a trip starts.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplate:startedTrip:usingRouteChoice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartedTrip (CPMapTemplate mapTemplate, CPTrip trip, CPRouteChoice routeChoice)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map for which a navigation alert will be dismissed.</param><param name="navigationAlert">The alert that will be dismissed.</param><param name="dismissalContext">The reason the alert will be dismissed.</param><summary>Method that is called just before a navigation alert is dismissed.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplate:willDismissNavigationAlert:dismissalContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissNavigationAlert (CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert, CPNavigationAlertDismissalContext dismissalContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map on which a panning interface will be dismissed.</param><summary>Method that is called just before a panning interface is dismissed.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplateWillDismissPanningInterface:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissPanningInterface (CPMapTemplate mapTemplate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("mapTemplate:willShareDestinationForTrip:")]
		[SupportedOSPlatform ("ios26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillShareDestination (CPMapTemplate mapTemplate, CPTrip trip)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="mapTemplate">The template for the map for which a navigation alert will be shown.</param><param name="navigationAlert">The navigation alert that will be shown.</param><summary>Method that is called just before a navigation alert is shown.</summary><remarks>To be added.</remarks>
		[Export ("mapTemplate:willShowNavigationAlert:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillShowNavigationAlert (CPMapTemplate mapTemplate, CPNavigationAlert navigationAlert)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CPMapTemplateDelegate */
}
