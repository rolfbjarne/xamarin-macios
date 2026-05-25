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
namespace CoreLocation {
	[Register("CLLocationManager", true)]
	public unsafe partial class CLLocationManager : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccuracyAuthorizationX = "accuracyAuthorization";
		static readonly NativeHandle selAccuracyAuthorizationXHandle = Selector.GetHandle ("accuracyAuthorization");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActivityTypeX = "activityType";
		static readonly NativeHandle selActivityTypeXHandle = Selector.GetHandle ("activityType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsBackgroundLocationUpdatesX = "allowsBackgroundLocationUpdates";
		static readonly NativeHandle selAllowsBackgroundLocationUpdatesXHandle = Selector.GetHandle ("allowsBackgroundLocationUpdates");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAuthorizationStatusX = "authorizationStatus";
		static readonly NativeHandle selAuthorizationStatusXHandle = Selector.GetHandle ("authorizationStatus");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeferredLocationUpdatesAvailableX = "deferredLocationUpdatesAvailable";
		static readonly NativeHandle selDeferredLocationUpdatesAvailableXHandle = Selector.GetHandle ("deferredLocationUpdatesAvailable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDesiredAccuracyX = "desiredAccuracy";
		static readonly NativeHandle selDesiredAccuracyXHandle = Selector.GetHandle ("desiredAccuracy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDismissHeadingCalibrationDisplayX = "dismissHeadingCalibrationDisplay";
		static readonly NativeHandle selDismissHeadingCalibrationDisplayXHandle = Selector.GetHandle ("dismissHeadingCalibrationDisplay");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDistanceFilterX = "distanceFilter";
		static readonly NativeHandle selDistanceFilterXHandle = Selector.GetHandle ("distanceFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHeadingX = "heading";
		static readonly NativeHandle selHeadingXHandle = Selector.GetHandle ("heading");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHeadingAvailableX = "headingAvailable";
		static readonly NativeHandle selHeadingAvailableXHandle = Selector.GetHandle ("headingAvailable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHeadingFilterX = "headingFilter";
		static readonly NativeHandle selHeadingFilterXHandle = Selector.GetHandle ("headingFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHeadingOrientationX = "headingOrientation";
		static readonly NativeHandle selHeadingOrientationXHandle = Selector.GetHandle ("headingOrientation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAuthorizedForWidgetUpdatesX = "isAuthorizedForWidgetUpdates";
		static readonly NativeHandle selIsAuthorizedForWidgetUpdatesXHandle = Selector.GetHandle ("isAuthorizedForWidgetUpdates");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsMonitoringAvailableForClass_X = "isMonitoringAvailableForClass:";
		static readonly NativeHandle selIsMonitoringAvailableForClass_XHandle = Selector.GetHandle ("isMonitoringAvailableForClass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsRangingAvailableX = "isRangingAvailable";
		static readonly NativeHandle selIsRangingAvailableXHandle = Selector.GetHandle ("isRangingAvailable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocationX = "location";
		static readonly NativeHandle selLocationXHandle = Selector.GetHandle ("location");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocationServicesEnabledX = "locationServicesEnabled";
		static readonly NativeHandle selLocationServicesEnabledXHandle = Selector.GetHandle ("locationServicesEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumRegionMonitoringDistanceX = "maximumRegionMonitoringDistance";
		static readonly NativeHandle selMaximumRegionMonitoringDistanceXHandle = Selector.GetHandle ("maximumRegionMonitoringDistance");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMonitoredRegionsX = "monitoredRegions";
		static readonly NativeHandle selMonitoredRegionsXHandle = Selector.GetHandle ("monitoredRegions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPausesLocationUpdatesAutomaticallyX = "pausesLocationUpdatesAutomatically";
		static readonly NativeHandle selPausesLocationUpdatesAutomaticallyXHandle = Selector.GetHandle ("pausesLocationUpdatesAutomatically");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPurposeX = "purpose";
		static readonly NativeHandle selPurposeXHandle = Selector.GetHandle ("purpose");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangedBeaconConstraintsX = "rangedBeaconConstraints";
		static readonly NativeHandle selRangedBeaconConstraintsXHandle = Selector.GetHandle ("rangedBeaconConstraints");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegionMonitoringAvailableX = "regionMonitoringAvailable";
		static readonly NativeHandle selRegionMonitoringAvailableXHandle = Selector.GetHandle ("regionMonitoringAvailable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegionMonitoringEnabledX = "regionMonitoringEnabled";
		static readonly NativeHandle selRegionMonitoringEnabledXHandle = Selector.GetHandle ("regionMonitoringEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestAlwaysAuthorizationX = "requestAlwaysAuthorization";
		static readonly NativeHandle selRequestAlwaysAuthorizationXHandle = Selector.GetHandle ("requestAlwaysAuthorization");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestLocationX = "requestLocation";
		static readonly NativeHandle selRequestLocationXHandle = Selector.GetHandle ("requestLocation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestStateForRegion_X = "requestStateForRegion:";
		static readonly NativeHandle selRequestStateForRegion_XHandle = Selector.GetHandle ("requestStateForRegion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestTemporaryFullAccuracyAuthorizationWithPurposeKey_X = "requestTemporaryFullAccuracyAuthorizationWithPurposeKey:";
		static readonly NativeHandle selRequestTemporaryFullAccuracyAuthorizationWithPurposeKey_XHandle = Selector.GetHandle ("requestTemporaryFullAccuracyAuthorizationWithPurposeKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestTemporaryFullAccuracyAuthorizationWithPurposeKey_Completion_X = "requestTemporaryFullAccuracyAuthorizationWithPurposeKey:completion:";
		static readonly NativeHandle selRequestTemporaryFullAccuracyAuthorizationWithPurposeKey_Completion_XHandle = Selector.GetHandle ("requestTemporaryFullAccuracyAuthorizationWithPurposeKey:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestWhenInUseAuthorizationX = "requestWhenInUseAuthorization";
		static readonly NativeHandle selRequestWhenInUseAuthorizationXHandle = Selector.GetHandle ("requestWhenInUseAuthorization");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetActivityType_X = "setActivityType:";
		static readonly NativeHandle selSetActivityType_XHandle = Selector.GetHandle ("setActivityType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsBackgroundLocationUpdates_X = "setAllowsBackgroundLocationUpdates:";
		static readonly NativeHandle selSetAllowsBackgroundLocationUpdates_XHandle = Selector.GetHandle ("setAllowsBackgroundLocationUpdates:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDesiredAccuracy_X = "setDesiredAccuracy:";
		static readonly NativeHandle selSetDesiredAccuracy_XHandle = Selector.GetHandle ("setDesiredAccuracy:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDistanceFilter_X = "setDistanceFilter:";
		static readonly NativeHandle selSetDistanceFilter_XHandle = Selector.GetHandle ("setDistanceFilter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHeadingFilter_X = "setHeadingFilter:";
		static readonly NativeHandle selSetHeadingFilter_XHandle = Selector.GetHandle ("setHeadingFilter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHeadingOrientation_X = "setHeadingOrientation:";
		static readonly NativeHandle selSetHeadingOrientation_XHandle = Selector.GetHandle ("setHeadingOrientation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPausesLocationUpdatesAutomatically_X = "setPausesLocationUpdatesAutomatically:";
		static readonly NativeHandle selSetPausesLocationUpdatesAutomatically_XHandle = Selector.GetHandle ("setPausesLocationUpdatesAutomatically:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPurpose_X = "setPurpose:";
		static readonly NativeHandle selSetPurpose_XHandle = Selector.GetHandle ("setPurpose:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsBackgroundLocationIndicator_X = "setShowsBackgroundLocationIndicator:";
		static readonly NativeHandle selSetShowsBackgroundLocationIndicator_XHandle = Selector.GetHandle ("setShowsBackgroundLocationIndicator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsBackgroundLocationIndicatorX = "showsBackgroundLocationIndicator";
		static readonly NativeHandle selShowsBackgroundLocationIndicatorXHandle = Selector.GetHandle ("showsBackgroundLocationIndicator");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSignificantLocationChangeMonitoringAvailableX = "significantLocationChangeMonitoringAvailable";
		static readonly NativeHandle selSignificantLocationChangeMonitoringAvailableXHandle = Selector.GetHandle ("significantLocationChangeMonitoringAvailable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartMonitoringForRegion_X = "startMonitoringForRegion:";
		static readonly NativeHandle selStartMonitoringForRegion_XHandle = Selector.GetHandle ("startMonitoringForRegion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartMonitoringSignificantLocationChangesX = "startMonitoringSignificantLocationChanges";
		static readonly NativeHandle selStartMonitoringSignificantLocationChangesXHandle = Selector.GetHandle ("startMonitoringSignificantLocationChanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartMonitoringVisitsX = "startMonitoringVisits";
		static readonly NativeHandle selStartMonitoringVisitsXHandle = Selector.GetHandle ("startMonitoringVisits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartRangingBeaconsSatisfyingConstraint_X = "startRangingBeaconsSatisfyingConstraint:";
		static readonly NativeHandle selStartRangingBeaconsSatisfyingConstraint_XHandle = Selector.GetHandle ("startRangingBeaconsSatisfyingConstraint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartUpdatingHeadingX = "startUpdatingHeading";
		static readonly NativeHandle selStartUpdatingHeadingXHandle = Selector.GetHandle ("startUpdatingHeading");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartUpdatingLocationX = "startUpdatingLocation";
		static readonly NativeHandle selStartUpdatingLocationXHandle = Selector.GetHandle ("startUpdatingLocation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopMonitoringForRegion_X = "stopMonitoringForRegion:";
		static readonly NativeHandle selStopMonitoringForRegion_XHandle = Selector.GetHandle ("stopMonitoringForRegion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopMonitoringSignificantLocationChangesX = "stopMonitoringSignificantLocationChanges";
		static readonly NativeHandle selStopMonitoringSignificantLocationChangesXHandle = Selector.GetHandle ("stopMonitoringSignificantLocationChanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopMonitoringVisitsX = "stopMonitoringVisits";
		static readonly NativeHandle selStopMonitoringVisitsXHandle = Selector.GetHandle ("stopMonitoringVisits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopRangingBeaconsSatisfyingConstraint_X = "stopRangingBeaconsSatisfyingConstraint:";
		static readonly NativeHandle selStopRangingBeaconsSatisfyingConstraint_XHandle = Selector.GetHandle ("stopRangingBeaconsSatisfyingConstraint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopUpdatingHeadingX = "stopUpdatingHeading";
		static readonly NativeHandle selStopUpdatingHeadingXHandle = Selector.GetHandle ("stopUpdatingHeading");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopUpdatingLocationX = "stopUpdatingLocation";
		static readonly NativeHandle selStopUpdatingLocationXHandle = Selector.GetHandle ("stopUpdatingLocation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CLLocationManager");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CLLocationManager" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CLLocationManager () : base (NSObjectFlag.Empty)
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
		protected CLLocationManager (NSObjectFlag t) : base (t)
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
		protected internal CLLocationManager (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>Removes the heading calibration view from the display.</summary><remarks>To be added.</remarks>
		[Export ("dismissHeadingCalibrationDisplay")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DismissHeadingCalibrationDisplay ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDismissHeadingCalibrationDisplayXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDismissHeadingCalibrationDisplayXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="regionClass">Objective-C class, must derive from CLRegion.</param><summary>Determines whether the device supports region monitoring for the specified kind of CLRegion.</summary><returns>True if the device supports it, false otherwise.</returns><remarks><para>
		/// This method merely determines whether region monitoring is
		/// available in the hardware, it does not determine whether the
		/// user has enabled location services or whether the
		/// application has been granted permission to use this.  You
		/// must request permission separately.
		/// </para><para>
		/// To determine whether you have permission to access
		/// location services, use <see cref="T:CoreLocation.CLLocationManager" />.
		/// </para><example><code lang="csharp lang-csharp"><![CDATA[
		/// var isAvail = CLLocationManager.IsMonitoringAvailable(typeof(CLCircularRegion));                
		/// ]]></code></example></remarks>
		[Export ("isMonitoringAvailableForClass:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsMonitoringAvailable (Class regionClass)
		{
			var regionClass__handle__ = regionClass!.GetNonNullHandle (nameof (regionClass));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, selIsMonitoringAvailableForClass_XHandle, regionClass.Handle);
			GC.KeepAlive (regionClass);
			return ret != 0;
		}
		/// <summary>Displays an interface to the user that requests authorization to use location services any time that the app is running.</summary><remarks>To be added.</remarks>
		[Export ("requestAlwaysAuthorization")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestAlwaysAuthorization ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRequestAlwaysAuthorizationXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRequestAlwaysAuthorizationXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Requests the current location.</summary><remarks>To be added.</remarks>
		[Export ("requestLocation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestLocation ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRequestLocationXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRequestLocationXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="region">The region whose state is being queried.</param><summary>Asynchronously requests information on the state of the <paramref name="region" />.</summary><remarks><para>Application developers must have assigned the <see cref="P:CoreLocation.CLLocationManager.Delegate" /> property to an object that implements <see cref="M:CoreLocation.CLLocationManagerDelegate.DidDetermineState(CoreLocation.CLLocationManager,CoreLocation.CLRegionState,CoreLocation.CLRegion)" /> prior to calling this method. The <see cref="M:CoreLocation.CLLocationManagerDelegate.DidDetermineState(CoreLocation.CLLocationManager,CoreLocation.CLRegionState,CoreLocation.CLRegion)" /> method will be called at some point subsequently.</para></remarks>
		[Export ("requestStateForRegion:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios17.0", "Use the class 'CLMonitor' instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use the class 'CLMonitor' instead.")]
		[ObsoletedOSPlatform ("macos14.0", "Use the class 'CLMonitor' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestState (CLRegion region)
		{
			var region__handle__ = region!.GetNonNullHandle (nameof (region));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRequestStateForRegion_XHandle, region__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRequestStateForRegion_XHandle, region__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (region);
		}
		[Export ("requestTemporaryFullAccuracyAuthorizationWithPurposeKey:completion:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestTemporaryFullAccuracyAuthorization (string purposeKey, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completion)
		{
			if (purposeKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (purposeKey));
			var nspurposeKey = CFString.CreateNative (purposeKey);
			using var block_completion = Trampolines.SDActionArity1V16.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRequestTemporaryFullAccuracyAuthorizationWithPurposeKey_Completion_XHandle, nspurposeKey, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRequestTemporaryFullAccuracyAuthorizationWithPurposeKey_Completion_XHandle, nspurposeKey, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspurposeKey);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task RequestTemporaryFullAccuracyAuthorizationAsync (string purposeKey)
		{
			var tcs = new TaskCompletionSource<bool> ();
			RequestTemporaryFullAccuracyAuthorization(purposeKey, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("requestTemporaryFullAccuracyAuthorizationWithPurposeKey:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestTemporaryFullAccuracyAuthorization (string purposeKey)
		{
			if (purposeKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (purposeKey));
			var nspurposeKey = CFString.CreateNative (purposeKey);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRequestTemporaryFullAccuracyAuthorizationWithPurposeKey_XHandle, nspurposeKey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRequestTemporaryFullAccuracyAuthorizationWithPurposeKey_XHandle, nspurposeKey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspurposeKey);
		}
		/// <summary>Displays an interface to the user that requests authorization to use location services any time that the app is in the foreground.</summary><remarks>To be added.</remarks>
		[Export ("requestWhenInUseAuthorization")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestWhenInUseAuthorization ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRequestWhenInUseAuthorizationXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRequestWhenInUseAuthorizationXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="region">The region to be monitored.</param><summary>Begins monitoring <paramref name="region" /> for entry and exit.</summary><remarks><para>An application may monitor up to 20 uniquely-named (defined by <see cref="P:CoreLocation.CLRegion.Identifier" />) regions. The speed with which region notifications are delivered is dependent on network connectivity.</para><para>Region entry/exit notifications typically arrive within 3-5 minutes. Regions of less than 400m radius work better on iPhone 4S and later devices. (Notification speed seems fastest on devices with M7 coprocessors.)</para></remarks>
		[Export ("startMonitoringForRegion:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios17.0", "Use 'void AddCondition (CLCondition condition, string identifier)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use 'void AddCondition (CLCondition condition, string identifier)' instead.")]
		[ObsoletedOSPlatform ("macos14.0", "Use 'void AddCondition (CLCondition condition, string identifier)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartMonitoring (CLRegion region)
		{
			var region__handle__ = region!.GetNonNullHandle (nameof (region));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStartMonitoringForRegion_XHandle, region__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selStartMonitoringForRegion_XHandle, region__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (region);
		}
		/// <summary>Starts monitoring for significant changes.</summary><remarks><para>This is the most energy-efficient monitoring mode and primarily relies on cellphone-tower changes. It is most appropriate for applications that do not have precise location-monitoring needs. </para></remarks>
		[Export ("startMonitoringSignificantLocationChanges")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartMonitoringSignificantLocationChanges ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStartMonitoringSignificantLocationChangesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStartMonitoringSignificantLocationChangesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Starts generating events in response to visits.</summary><remarks>To be added.</remarks>
		[Export ("startMonitoringVisits")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartMonitoringVisits ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStartMonitoringVisitsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStartMonitoringVisitsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("startRangingBeaconsSatisfyingConstraint:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartRangingBeacons (CLBeaconIdentityConstraint constraint)
		{
			var constraint__handle__ = constraint!.GetNonNullHandle (nameof (constraint));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStartRangingBeaconsSatisfyingConstraint_XHandle, constraint__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selStartRangingBeaconsSatisfyingConstraint_XHandle, constraint__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (constraint);
		}
		/// <summary>Starts updating the heading.</summary><remarks><para>Heading information is only available on devices with a hardware magnetometer. (See <see cref="P:CoreLocation.CLLocationManager.HeadingAvailable" />.)</para></remarks>
		[Export ("startUpdatingHeading")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartUpdatingHeading ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStartUpdatingHeadingXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStartUpdatingHeadingXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Starts updating the location</summary><remarks>To be added.</remarks>
		[Export ("startUpdatingLocation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartUpdatingLocation ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStartUpdatingLocationXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStartUpdatingLocationXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="region">To be added.</param><summary>Stops monitoring the <paramref name="region" />.</summary><remarks>To be added.</remarks>
		[Export ("stopMonitoringForRegion:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios17.0", "Use 'void RemoveCondition (string identifier)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use 'void RemoveCondition (string identifier)' instead.")]
		[ObsoletedOSPlatform ("macos14.0", "Use 'void RemoveCondition (string identifier)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopMonitoring (CLRegion region)
		{
			var region__handle__ = region!.GetNonNullHandle (nameof (region));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStopMonitoringForRegion_XHandle, region__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selStopMonitoringForRegion_XHandle, region__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (region);
		}
		/// <summary>Starts monitoring significant location changes.</summary><remarks>To be added.</remarks>
		[Export ("stopMonitoringSignificantLocationChanges")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopMonitoringSignificantLocationChanges ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopMonitoringSignificantLocationChangesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopMonitoringSignificantLocationChangesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Stops generating events in response to visits.</summary><remarks>To be added.</remarks>
		[Export ("stopMonitoringVisits")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopMonitoringVisits ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopMonitoringVisitsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopMonitoringVisitsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("stopRangingBeaconsSatisfyingConstraint:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopRangingBeacons (CLBeaconIdentityConstraint constraint)
		{
			var constraint__handle__ = constraint!.GetNonNullHandle (nameof (constraint));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStopRangingBeaconsSatisfyingConstraint_XHandle, constraint__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selStopRangingBeaconsSatisfyingConstraint_XHandle, constraint__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (constraint);
		}
		/// <summary>Stops updating the heading.</summary><remarks>To be added.</remarks>
		[Export ("stopUpdatingHeading")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopUpdatingHeading ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopUpdatingHeadingXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopUpdatingHeadingXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Stops updating the location.</summary><remarks>To be added.</remarks>
		[Export ("stopUpdatingLocation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopUpdatingLocation ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopUpdatingLocationXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopUpdatingLocationXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual CLAccuracyAuthorization AccuracyAuthorization {
			[Export ("accuracyAuthorization")]
			get {
				CLAccuracyAuthorization ret;
				if (IsDirectBinding) {
					ret = (CLAccuracyAuthorization) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAccuracyAuthorizationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CLAccuracyAuthorization) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAccuracyAuthorizationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Used to provide the operating system clues for better power consumption / accuracy.</summary><value>The default value is <see cref="F:CoreLocation.CLActivityType.Other" />.</value><remarks><para>Application developers should set this property when possible. It provides clues to the system about the application's need. For instance, if set to <see cref="F:CoreLocation.CLActivityType.AutomotiveNavigation" /> and the device has not moved for awhile, the system might power down updates until movement is detected.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual CLActivityType ActivityType {
			[Export ("activityType", ArgumentSemantic.Assign)]
			get {
				CLActivityType ret;
				if (IsDirectBinding) {
					ret = (CLActivityType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selActivityTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CLActivityType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selActivityTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setActivityType:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetActivityType_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetActivityType_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the application will respond to location updates while it is suspended.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AllowsBackgroundLocationUpdates {
			[Export ("allowsBackgroundLocationUpdates")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsBackgroundLocationUpdatesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsBackgroundLocationUpdatesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsBackgroundLocationUpdates:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsBackgroundLocationUpdates_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsBackgroundLocationUpdates_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual CLAuthorizationStatus AuthorizationStatus {
			[Export ("authorizationStatus")]
			get {
				CLAuthorizationStatus ret;
				if (IsDirectBinding) {
					ret = (CLAuthorizationStatus) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selAuthorizationStatusXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CLAuthorizationStatus) global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selAuthorizationStatusXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Whether background-generated deferred location data are available.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios13.0", "Not used anymore. It will always return 'false'.")]
		[ObsoletedOSPlatform ("macos10.15", "Not used anymore. It will always return 'false'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Not used anymore. It will always return 'false'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static bool DeferredLocationUpdatesAvailable {
			[Export ("deferredLocationUpdatesAvailable")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selDeferredLocationUpdatesAvailableXHandle);
				return ret != 0;
			}
		}
		/// <summary>An instance of the CoreLocation.ICLLocationManagerDelegate model class which acts as the class delegate.</summary><value>The instance of the CoreLocation.ICLLocationManagerDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ICLLocationManagerDelegate Delegate {
			get {
				return (WeakDelegate as ICLLocationManagerDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		/// <summary>The accuracy preferred by the app. (Coarser accuracies consume less power.)</summary><value>The default value is <see cref="P:CoreLocation.CLLocation.AccuracyBest" />.</value><remarks><para>Application developers should set this value to the coarsest resolution suitable to their needs.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double DesiredAccuracy {
			[Export ("desiredAccuracy")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selDesiredAccuracyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selDesiredAccuracyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDesiredAccuracy:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetDesiredAccuracy_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetDesiredAccuracy_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The minimum horizontal distance, in meters, the device has to move before issuing a location update.</summary><value>The default value is <see cref="P:CoreLocation.CLLocationDistance.FilterNone" />.</value><remarks><para>If this value is set to <see cref="P:CoreLocation.CLLocationDistance.FilterNone" />, the app will receive all location updates.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double DistanceFilter {
			[Export ("distanceFilter")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selDistanceFilterXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selDistanceFilterXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDistanceFilter:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetDistanceFilter_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetDistanceFilter_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The most recent heading (direction in which the device is traveling).</summary><value>This value may be <see langword="null" /> if heading updates have not been started.</value><remarks><para>Heading information is only available on devices with a hardware magnetometer. (See <see cref="P:CoreLocation.CLLocationManager.HeadingAvailable" />.)</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual CLHeading? Heading {
			[Export ("heading", ArgumentSemantic.Copy)]
			get {
				CLHeading? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CLHeading> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHeadingXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CLHeading> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHeadingXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Whether the <see cref="P:CoreLocation.CLLocationManager.Heading" /> property is not <see langword="null" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static bool HeadingAvailable {
			[Export ("headingAvailable")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selHeadingAvailableXHandle);
				return ret != 0;
			}
		}
		/// <summary>The minimum change in heading, in degrees, necessary to generate a location update.</summary><value>The default value is 1 (degree).</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual double HeadingFilter {
			[Export ("headingFilter")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selHeadingFilterXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selHeadingFilterXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setHeadingFilter:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetHeadingFilter_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetHeadingFilter_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The orientation used to determine heading calculations.</summary><value>The default value assumes that the app, in upright portrait mode, represents due North.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual CLDeviceOrientation HeadingOrientation {
			[Export ("headingOrientation", ArgumentSemantic.Assign)]
			get {
				CLDeviceOrientation ret;
				if (IsDirectBinding) {
					ret = (CLDeviceOrientation) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selHeadingOrientationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CLDeviceOrientation) global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selHeadingOrientationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setHeadingOrientation:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetHeadingOrientation_XHandle, (UInt32)value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (&__objc_super__, selSetHeadingOrientation_XHandle, (UInt32)value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool IsAuthorizedForWidgetUpdates {
			[Export ("isAuthorizedForWidgetUpdates")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAuthorizedForWidgetUpdatesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAuthorizedForWidgetUpdatesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the device can range Bluetooth beacons.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static bool IsRangingAvailable {
			[Export ("isRangingAvailable")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsRangingAvailableXHandle);
				return ret != 0;
			}
		}
		/// <summary>The most recently-retrieved <see cref="T:CoreLocation.CLLocation" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CLLocation? Location {
			[Export ("location", ArgumentSemantic.Copy)]
			get {
				CLLocation? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CLLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CLLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Whether location services are available.</summary><value><see langword="true" /> if the necessary hardware exists and the user has allowed the app's request for access.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool LocationServicesEnabled {
			[Export ("locationServicesEnabled")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selLocationServicesEnabledXHandle);
				return ret != 0;
			}
		}
		/// <summary>The largest boundary distance, in meters, that can be assigned to a region.</summary><value>A return value of -1 indicates that region monitoring is unavailable.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual double MaximumRegionMonitoringDistance {
			[Export ("maximumRegionMonitoringDistance")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selMaximumRegionMonitoringDistanceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selMaximumRegionMonitoringDistanceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>The set of <see cref="T:CoreLocation.CLRegion" />s being monitored by the app.</summary><value>To be added.</value><remarks><para>The <see cref="T:CoreLocation.CLRegion" />s objects returned by this method may be different than those created by the app. Application developers should use the <see cref="P:CoreLocation.CLRegion.Identifier" /> property to determine equality.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual NSSet MonitoredRegions {
			[Export ("monitoredRegions", ArgumentSemantic.Copy)]
			get {
				NSSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMonitoredRegionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMonitoredRegionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Whether the system is allowed to pause location updates (for instance, if the device has not moved in awhile).</summary><value>The default value is <see langword="true" />.</value><remarks><para>Application developers can make pauses more logical by assigning <see cref="P:CoreLocation.CLLocationManager.ActivityType" /> appropriately.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual bool PausesLocationUpdatesAutomatically {
			[Export ("pausesLocationUpdatesAutomatically")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPausesLocationUpdatesAutomaticallyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selPausesLocationUpdatesAutomaticallyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPausesLocationUpdatesAutomatically:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPausesLocationUpdatesAutomatically_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPausesLocationUpdatesAutomatically_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Developers should not use this deprecated property. </summary><value>To be added.</value><remarks><para>Application developers should not use this deprecated property.</para><para>Prior to iOS 6, this property was displayed to the user when they were prompted as to whether to allow location services.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0")]
		[ObsoletedOSPlatform ("macos11.0", "Set the purpose using the NSLocationUsageDescription key in the Info.plist instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual string? Purpose {
			[Export ("purpose")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPurposeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPurposeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPurpose:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPurpose_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPurpose_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSSet<CLBeaconIdentityConstraint> RangedBeaconConstraints {
			[Export ("rangedBeaconConstraints", ArgumentSemantic.Copy)]
			get {
				NSSet<CLBeaconIdentityConstraint>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<CLBeaconIdentityConstraint>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRangedBeaconConstraintsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<CLBeaconIdentityConstraint>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRangedBeaconConstraintsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Application developers should use <see cref="CoreLocation.CLLocationManager.IsMonitoringAvailable(System.Type)" /> rather than this deprecated method.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'IsMonitoringAvailable' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'IsMonitoringAvailable' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'IsMonitoringAvailable' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static bool RegionMonitoringAvailable {
			[Export ("regionMonitoringAvailable")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selRegionMonitoringAvailableXHandle);
				return ret != 0;
			}
		}
		/// <summary>Application developers should use <see cref="CoreLocation.CLLocationManager.IsMonitoringAvailable(System.Type)" /> rather than this deprecated method.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0", "Use 'IsMonitoringAvailable' and 'AuthorizationStatus' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'IsMonitoringAvailable' and 'AuthorizationStatus' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'IsMonitoringAvailable' and 'AuthorizationStatus' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static bool RegionMonitoringEnabled {
			[Export ("regionMonitoringEnabled")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selRegionMonitoringEnabledXHandle);
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual bool ShowsBackgroundLocationIndicator {
			[Export ("showsBackgroundLocationIndicator")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsBackgroundLocationIndicatorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsBackgroundLocationIndicatorXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsBackgroundLocationIndicator:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsBackgroundLocationIndicator_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsBackgroundLocationIndicator_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether "significant location change" monitoring (e.g., via cell tower switch) is available.</summary><value><see langword="true" /> if such monitoring is available.</value><remarks><para>"Significant location change" monitoring is the lowest-power location monitoring mode and is done primarily via tracking cellphone tower changes. This type of monitoring is primarily useful for applications that are satisfied by approximate location data. </para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static bool SignificantLocationChangeMonitoringAvailable {
			[Export ("significantLocationChangeMonitoringAvailable")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selSignificantLocationChangeMonitoringAvailableXHandle);
				return ret != 0;
			}
		}
		/// <summary>The authorization status of the app (e.g., if the app is denied access to location services).</summary><value>The value is determined by the user's interaction with the standard permissions dialog.</value><remarks><para>See the "Requesting Authorization" discussion in the class-level remarks: <see cref="T:CoreLocation.CLLocationManager" />.</para></remarks><altmember cref="CLLocationManager.AuthorizationChanged" />
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios14.0", "Use the instance property 'AuthorizationStatus' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use the instance 'AuthorizationStatus' property instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the instance property AuthorizationStatus' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use the instance property 'AuthorizationStatus' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static CLAuthorizationStatus Status {
			[Export ("authorizationStatus")]
			get {
				CLAuthorizationStatus ret;
				ret = (CLAuthorizationStatus) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (class_ptr, selAuthorizationStatusXHandle);
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		/// <summary>An object that can respond to the delegate protocol for this type</summary><value>The instance that will respond to events and data requests.</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
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
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
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
		/// <summary>Represents the value associated with the constant CLTimeInternalMax</summary><value></value><remarks>To be added.</remarks>
		[Field ("CLTimeIntervalMax",  "CoreLocation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static double MaxTimeInterval {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetDouble (Libraries.CoreLocation.Handle, "CLTimeIntervalMax");
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_CLLocationManagerDelegate); }
		}
		internal virtual _CLLocationManagerDelegate CreateInternalEventDelegateType ()
		{
			return (_CLLocationManagerDelegate)(new _CLLocationManagerDelegate());
		}
		internal _CLLocationManagerDelegate EnsureCLLocationManagerDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _CLLocationManagerDelegate;
			if (del is null){
				del = (_CLLocationManagerDelegate)CreateInternalEventDelegateType ();
				Delegate = (ICLLocationManagerDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _CLLocationManagerDelegate : NSObject, ICLLocationManagerDelegate { 
			public _CLLocationManagerDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_CLLocationManagerDelegate))]
			static _CLLocationManagerDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<CLAuthorizationChangedEventArgs>? authorizationChanged;
			[Export ("locationManager:didChangeAuthorizationStatus:")]
			public void AuthorizationChanged (CLLocationManager manager, CLAuthorizationStatus status)
			{
				var handler = authorizationChanged;
				if (handler is not null){
					var args = new CLAuthorizationChangedEventArgs (status);
					handler (manager, args);
				}
			}
			internal EventHandler<NSErrorEventArgs>? deferredUpdatesFinished;
			[Export ("locationManager:didFinishDeferredUpdatesWithError:")]
			public void DeferredUpdatesFinished (CLLocationManager manager, NSError? error)
			{
				var handler = deferredUpdatesFinished;
				if (handler is not null){
					var args = new NSErrorEventArgs (error);
					handler (manager, args);
				}
			}
			internal EventHandler? didChangeAuthorization;
			[Export ("locationManagerDidChangeAuthorization:")]
			public void DidChangeAuthorization (CLLocationManager manager)
			{
				var handler = didChangeAuthorization;
				if (handler is not null){
					handler (manager, EventArgs.Empty);
				}
			}
			internal EventHandler<CLRegionStateDeterminedEventArgs>? didDetermineState;
			[Export ("locationManager:didDetermineState:forRegion:")]
			public void DidDetermineState (CLLocationManager manager, CLRegionState state, CLRegion region)
			{
				var handler = didDetermineState;
				if (handler is not null){
					var args = new CLRegionStateDeterminedEventArgs (state, region);
					handler (manager, args);
				}
			}
			internal EventHandler<CLRegionBeaconsConstraintFailedEventArgs>? didFailRangingBeacons;
			[Export ("locationManager:didFailRangingBeaconsForConstraint:error:")]
			public void DidFailRangingBeacons (CLLocationManager manager, CLBeaconIdentityConstraint beaconConstraint, NSError error)
			{
				var handler = didFailRangingBeacons;
				if (handler is not null){
					var args = new CLRegionBeaconsConstraintFailedEventArgs (beaconConstraint, error);
					handler (manager, args);
				}
			}
			internal EventHandler<CLRegionBeaconsConstraintRangedEventArgs>? didRangeBeaconsSatisfyingConstraint;
			[Export ("locationManager:didRangeBeacons:satisfyingConstraint:")]
			public void DidRangeBeaconsSatisfyingConstraint (CLLocationManager manager, CLBeacon[] beacons, CLBeaconIdentityConstraint beaconConstraint)
			{
				var handler = didRangeBeaconsSatisfyingConstraint;
				if (handler is not null){
					var args = new CLRegionBeaconsConstraintRangedEventArgs (beacons, beaconConstraint);
					handler (manager, args);
				}
			}
			internal EventHandler<CLRegionEventArgs>? didStartMonitoringForRegion;
			[Export ("locationManager:didStartMonitoringForRegion:")]
			public void DidStartMonitoringForRegion (CLLocationManager manager, CLRegion region)
			{
				var handler = didStartMonitoringForRegion;
				if (handler is not null){
					var args = new CLRegionEventArgs (region);
					handler (manager, args);
				}
			}
			internal EventHandler<CLVisitedEventArgs>? didVisit;
			[Export ("locationManager:didVisit:")]
			public void DidVisit (CLLocationManager manager, CLVisit visit)
			{
				var handler = didVisit;
				if (handler is not null){
					var args = new CLVisitedEventArgs (visit);
					handler (manager, args);
				}
			}
			internal EventHandler<NSErrorEventArgs>? failed;
			[Export ("locationManager:didFailWithError:")]
			public void Failed (CLLocationManager manager, NSError error)
			{
				var handler = failed;
				if (handler is not null){
					var args = new NSErrorEventArgs (error);
					handler (manager, args);
				}
			}
			internal EventHandler? locationUpdatesPaused;
			[Export ("locationManagerDidPauseLocationUpdates:")]
			public void LocationUpdatesPaused (CLLocationManager manager)
			{
				var handler = locationUpdatesPaused;
				if (handler is not null){
					handler (manager, EventArgs.Empty);
				}
			}
			internal EventHandler? locationUpdatesResumed;
			[Export ("locationManagerDidResumeLocationUpdates:")]
			public void LocationUpdatesResumed (CLLocationManager manager)
			{
				var handler = locationUpdatesResumed;
				if (handler is not null){
					handler (manager, EventArgs.Empty);
				}
			}
			internal EventHandler<CLLocationsUpdatedEventArgs>? locationsUpdated;
			[Export ("locationManager:didUpdateLocations:")]
			public void LocationsUpdated (CLLocationManager manager, CLLocation[] locations)
			{
				var handler = locationsUpdated;
				if (handler is not null){
					var args = new CLLocationsUpdatedEventArgs (locations);
					handler (manager, args);
				}
			}
			internal EventHandler<CLRegionErrorEventArgs>? monitoringFailed;
			[Export ("locationManager:monitoringDidFailForRegion:withError:")]
			public void MonitoringFailed (CLLocationManager manager, CLRegion? region, NSError error)
			{
				var handler = monitoringFailed;
				if (handler is not null){
					var args = new CLRegionErrorEventArgs (region, error);
					handler (manager, args);
				}
			}
			internal EventHandler<CLRegionEventArgs>? regionEntered;
			[Export ("locationManager:didEnterRegion:")]
			public void RegionEntered (CLLocationManager manager, CLRegion region)
			{
				var handler = regionEntered;
				if (handler is not null){
					var args = new CLRegionEventArgs (region);
					handler (manager, args);
				}
			}
			internal EventHandler<CLRegionEventArgs>? regionLeft;
			[Export ("locationManager:didExitRegion:")]
			public void RegionLeft (CLLocationManager manager, CLRegion region)
			{
				var handler = regionLeft;
				if (handler is not null){
					var args = new CLRegionEventArgs (region);
					handler (manager, args);
				}
			}
			internal CLLocationManagerEventArgs? shouldDisplayHeadingCalibration;
			[Export ("locationManagerShouldDisplayHeadingCalibration:")]
			public bool ShouldDisplayHeadingCalibration (CLLocationManager manager)
			{
				var handler = shouldDisplayHeadingCalibration;
				if (handler is not null)
					return handler (manager);
				return true!;
			}
			internal EventHandler<CLHeadingUpdatedEventArgs>? updatedHeading;
			[Export ("locationManager:didUpdateHeading:")]
			public void UpdatedHeading (CLLocationManager manager, CLHeading newHeading)
			{
				var handler = updatedHeading;
				if (handler is not null){
					var args = new CLHeadingUpdatedEventArgs (newHeading);
					handler (manager, args);
				}
			}
			internal EventHandler<CLLocationUpdatedEventArgs>? updatedLocation;
			[Export ("locationManager:didUpdateToLocation:fromLocation:")]
			public void UpdatedLocation (CLLocationManager manager, CLLocation newLocation, CLLocation oldLocation)
			{
				var handler = updatedLocation;
				if (handler is not null){
					var args = new CLLocationUpdatedEventArgs (newLocation, oldLocation);
					handler (manager, args);
				}
			}
		}
		#pragma warning restore 672
		public event EventHandler<CLAuthorizationChangedEventArgs> AuthorizationChanged {
			add { EnsureCLLocationManagerDelegate ()!.authorizationChanged += value; }
			remove { EnsureCLLocationManagerDelegate ()!.authorizationChanged -= value; }
		}
		public event EventHandler<NSErrorEventArgs> DeferredUpdatesFinished {
			add { EnsureCLLocationManagerDelegate ()!.deferredUpdatesFinished += value; }
			remove { EnsureCLLocationManagerDelegate ()!.deferredUpdatesFinished -= value; }
		}
		public event EventHandler DidChangeAuthorization {
			add { EnsureCLLocationManagerDelegate ()!.didChangeAuthorization += value; }
			remove { EnsureCLLocationManagerDelegate ()!.didChangeAuthorization -= value; }
		}
		public event EventHandler<CLRegionStateDeterminedEventArgs> DidDetermineState {
			add { EnsureCLLocationManagerDelegate ()!.didDetermineState += value; }
			remove { EnsureCLLocationManagerDelegate ()!.didDetermineState -= value; }
		}
		public event EventHandler<CLRegionBeaconsConstraintFailedEventArgs> DidFailRangingBeacons {
			add { EnsureCLLocationManagerDelegate ()!.didFailRangingBeacons += value; }
			remove { EnsureCLLocationManagerDelegate ()!.didFailRangingBeacons -= value; }
		}
		public event EventHandler<CLRegionBeaconsConstraintRangedEventArgs> DidRangeBeaconsSatisfyingConstraint {
			add { EnsureCLLocationManagerDelegate ()!.didRangeBeaconsSatisfyingConstraint += value; }
			remove { EnsureCLLocationManagerDelegate ()!.didRangeBeaconsSatisfyingConstraint -= value; }
		}
		public event EventHandler<CLRegionEventArgs> DidStartMonitoringForRegion {
			add { EnsureCLLocationManagerDelegate ()!.didStartMonitoringForRegion += value; }
			remove { EnsureCLLocationManagerDelegate ()!.didStartMonitoringForRegion -= value; }
		}
		public event EventHandler<CLVisitedEventArgs> DidVisit {
			add { EnsureCLLocationManagerDelegate ()!.didVisit += value; }
			remove { EnsureCLLocationManagerDelegate ()!.didVisit -= value; }
		}
		public event EventHandler<NSErrorEventArgs> Failed {
			add { EnsureCLLocationManagerDelegate ()!.failed += value; }
			remove { EnsureCLLocationManagerDelegate ()!.failed -= value; }
		}
		public event EventHandler LocationUpdatesPaused {
			add { EnsureCLLocationManagerDelegate ()!.locationUpdatesPaused += value; }
			remove { EnsureCLLocationManagerDelegate ()!.locationUpdatesPaused -= value; }
		}
		public event EventHandler LocationUpdatesResumed {
			add { EnsureCLLocationManagerDelegate ()!.locationUpdatesResumed += value; }
			remove { EnsureCLLocationManagerDelegate ()!.locationUpdatesResumed -= value; }
		}
		public event EventHandler<CLLocationsUpdatedEventArgs> LocationsUpdated {
			add { EnsureCLLocationManagerDelegate ()!.locationsUpdated += value; }
			remove { EnsureCLLocationManagerDelegate ()!.locationsUpdated -= value; }
		}
		public event EventHandler<CLRegionErrorEventArgs> MonitoringFailed {
			add { EnsureCLLocationManagerDelegate ()!.monitoringFailed += value; }
			remove { EnsureCLLocationManagerDelegate ()!.monitoringFailed -= value; }
		}
		public event EventHandler<CLRegionEventArgs> RegionEntered {
			add { EnsureCLLocationManagerDelegate ()!.regionEntered += value; }
			remove { EnsureCLLocationManagerDelegate ()!.regionEntered -= value; }
		}
		public event EventHandler<CLRegionEventArgs> RegionLeft {
			add { EnsureCLLocationManagerDelegate ()!.regionLeft += value; }
			remove { EnsureCLLocationManagerDelegate ()!.regionLeft -= value; }
		}
		public CLLocationManagerEventArgs? ShouldDisplayHeadingCalibration {
			get { return EnsureCLLocationManagerDelegate ()!.shouldDisplayHeadingCalibration; }
			set { EnsureCLLocationManagerDelegate ()!.shouldDisplayHeadingCalibration = value; }
		}
		public event EventHandler<CLHeadingUpdatedEventArgs> UpdatedHeading {
			add { EnsureCLLocationManagerDelegate ()!.updatedHeading += value; }
			remove { EnsureCLLocationManagerDelegate ()!.updatedHeading -= value; }
		}
		public event EventHandler<CLLocationUpdatedEventArgs> UpdatedLocation {
			add { EnsureCLLocationManagerDelegate ()!.updatedLocation += value; }
			remove { EnsureCLLocationManagerDelegate ()!.updatedLocation -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class CLLocationManager */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class CLAuthorizationChangedEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="CLAuthorizationChangedEventArgs" /> with the specified event data.</summary>
		/// <param name="status">The value for the <see cref="Status" /> property.</param>
		public CLAuthorizationChangedEventArgs (CLAuthorizationStatus status)
		{
			this.Status = status;
		}
		public CLAuthorizationStatus Status { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class CLHeadingUpdatedEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="CLHeadingUpdatedEventArgs" /> with the specified event data.</summary>
		/// <param name="newHeading">The value for the <see cref="NewHeading" /> property.</param>
		public CLHeadingUpdatedEventArgs (CLHeading newHeading)
		{
			this.NewHeading = newHeading;
		}
		public CLHeading NewHeading { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class CLLocationUpdatedEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="CLLocationUpdatedEventArgs" /> with the specified event data.</summary>
		/// <param name="newLocation">The value for the <see cref="NewLocation" /> property.</param>
		/// <param name="oldLocation">The value for the <see cref="OldLocation" /> property.</param>
		public CLLocationUpdatedEventArgs (CLLocation newLocation, CLLocation oldLocation)
		{
			this.NewLocation = newLocation;
			this.OldLocation = oldLocation;
		}
		public CLLocation NewLocation { get; set; }
		public CLLocation OldLocation { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class CLLocationsUpdatedEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="CLLocationsUpdatedEventArgs" /> with the specified event data.</summary>
		/// <param name="locations">The value for the <see cref="Locations" /> property.</param>
		public CLLocationsUpdatedEventArgs (CLLocation[] locations)
		{
			this.Locations = locations;
		}
		public CLLocation[] Locations { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class CLRegionBeaconsConstraintFailedEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="CLRegionBeaconsConstraintFailedEventArgs" /> with the specified event data.</summary>
		/// <param name="beaconConstraint">The value for the <see cref="BeaconConstraint" /> property.</param>
		/// <param name="error">The value for the <see cref="Error" /> property.</param>
		public CLRegionBeaconsConstraintFailedEventArgs (CLBeaconIdentityConstraint beaconConstraint, NSError error)
		{
			this.BeaconConstraint = beaconConstraint;
			this.Error = error;
		}
		public CLBeaconIdentityConstraint BeaconConstraint { get; set; }
		public NSError Error { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class CLRegionBeaconsConstraintRangedEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="CLRegionBeaconsConstraintRangedEventArgs" /> with the specified event data.</summary>
		/// <param name="beacons">The value for the <see cref="Beacons" /> property.</param>
		/// <param name="beaconConstraint">The value for the <see cref="BeaconConstraint" /> property.</param>
		public CLRegionBeaconsConstraintRangedEventArgs (CLBeacon[] beacons, CLBeaconIdentityConstraint beaconConstraint)
		{
			this.BeaconConstraint = beaconConstraint;
			this.Beacons = beacons;
		}
		public CLBeaconIdentityConstraint BeaconConstraint { get; set; }
		public CLBeacon[] Beacons { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class CLRegionErrorEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="CLRegionErrorEventArgs" /> with the specified event data.</summary>
		/// <param name="region">The value for the <see cref="Region" /> property.</param>
		/// <param name="error">The value for the <see cref="Error" /> property.</param>
		public CLRegionErrorEventArgs (CLRegion? region, NSError error)
		{
			this.Error = error;
			this.Region = region;
		}
		public NSError Error { get; set; }
		public CLRegion? Region { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class CLRegionEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="CLRegionEventArgs" /> with the specified event data.</summary>
		/// <param name="region">The value for the <see cref="Region" /> property.</param>
		public CLRegionEventArgs (CLRegion region)
		{
			this.Region = region;
		}
		public CLRegion Region { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class CLRegionStateDeterminedEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="CLRegionStateDeterminedEventArgs" /> with the specified event data.</summary>
		/// <param name="state">The value for the <see cref="State" /> property.</param>
		/// <param name="region">The value for the <see cref="Region" /> property.</param>
		public CLRegionStateDeterminedEventArgs (CLRegionState state, CLRegion region)
		{
			this.Region = region;
			this.State = state;
		}
		public CLRegion Region { get; set; }
		public CLRegionState State { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class CLVisitedEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="CLVisitedEventArgs" /> with the specified event data.</summary>
		/// <param name="visit">The value for the <see cref="Visit" /> property.</param>
		public CLVisitedEventArgs (CLVisit visit)
		{
			this.Visit = visit;
		}
		public CLVisit Visit { get; set; }
	}
}
