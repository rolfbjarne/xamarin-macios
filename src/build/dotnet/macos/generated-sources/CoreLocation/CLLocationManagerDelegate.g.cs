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
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CLLocationManagerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "CLLocationManagerDelegate", WrapperType = typeof (CLLocationManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdatedLocation", Selector = "locationManager:didUpdateToLocation:fromLocation:", ParameterType = new Type [] { typeof (CLLocationManager), typeof (CLLocation), typeof (CLLocation) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdatedHeading", Selector = "locationManager:didUpdateHeading:", ParameterType = new Type [] { typeof (CLLocationManager), typeof (CLHeading) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldDisplayHeadingCalibration", Selector = "locationManagerShouldDisplayHeadingCalibration:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CLLocationManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Failed", Selector = "locationManager:didFailWithError:", ParameterType = new Type [] { typeof (CLLocationManager), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RegionEntered", Selector = "locationManager:didEnterRegion:", ParameterType = new Type [] { typeof (CLLocationManager), typeof (CLRegion) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RegionLeft", Selector = "locationManager:didExitRegion:", ParameterType = new Type [] { typeof (CLLocationManager), typeof (CLRegion) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MonitoringFailed", Selector = "locationManager:monitoringDidFailForRegion:withError:", ParameterType = new Type [] { typeof (CLLocationManager), typeof (CLRegion), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStartMonitoringForRegion", Selector = "locationManager:didStartMonitoringForRegion:", ParameterType = new Type [] { typeof (CLLocationManager), typeof (CLRegion) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDetermineState", Selector = "locationManager:didDetermineState:forRegion:", ParameterType = new Type [] { typeof (CLLocationManager), typeof (CLRegionState), typeof (CLRegion) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRangeBeaconsSatisfyingConstraint", Selector = "locationManager:didRangeBeacons:satisfyingConstraint:", ParameterType = new Type [] { typeof (CLLocationManager), typeof (CLBeacon[]), typeof (CLBeaconIdentityConstraint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailRangingBeacons", Selector = "locationManager:didFailRangingBeaconsForConstraint:error:", ParameterType = new Type [] { typeof (CLLocationManager), typeof (CLBeaconIdentityConstraint), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidVisit", Selector = "locationManager:didVisit:", ParameterType = new Type [] { typeof (CLLocationManager), typeof (CLVisit) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AuthorizationChanged", Selector = "locationManager:didChangeAuthorizationStatus:", ParameterType = new Type [] { typeof (CLLocationManager), typeof (CLAuthorizationStatus) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LocationsUpdated", Selector = "locationManager:didUpdateLocations:", ParameterType = new Type [] { typeof (CLLocationManager), typeof (CLLocation[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LocationUpdatesPaused", Selector = "locationManagerDidPauseLocationUpdates:", ParameterType = new Type [] { typeof (CLLocationManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LocationUpdatesResumed", Selector = "locationManagerDidResumeLocationUpdates:", ParameterType = new Type [] { typeof (CLLocationManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DeferredUpdatesFinished", Selector = "locationManager:didFinishDeferredUpdatesWithError:", ParameterType = new Type [] { typeof (CLLocationManager), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeAuthorization", Selector = "locationManagerDidChangeAuthorization:", ParameterType = new Type [] { typeof (CLLocationManager) }, ParameterByRef = new bool [] { false })]
	public partial interface ICLLocationManagerDelegate : INativeObject, IDisposable
	{
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="newLocation">To be added.</param><param name="oldLocation">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("locationManager:didUpdateToLocation:fromLocation:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedLocation (CLLocationManager manager, CLLocation newLocation, CLLocation oldLocation)
		{
			_UpdatedLocation (this, manager, newLocation, oldLocation);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="newLocation">To be added.</param><param name="oldLocation">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdatedLocation (ICLLocationManagerDelegate This, CLLocationManager manager, CLLocation newLocation, CLLocation oldLocation)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var newLocation__handle__ = newLocation!.GetNonNullHandle (nameof (newLocation));
			var oldLocation__handle__ = oldLocation!.GetNonNullHandle (nameof (oldLocation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didUpdateToLocation:fromLocation:"), manager__handle__, newLocation__handle__, oldLocation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (newLocation);
			GC.KeepAlive (oldLocation);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="newHeading">The new heading.</param><summary>The device's heading has been updated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("locationManager:didUpdateHeading:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedHeading (CLLocationManager manager, CLHeading newHeading)
		{
			_UpdatedHeading (this, manager, newHeading);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="newHeading">The new heading.</param><summary>The device's heading has been updated.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdatedHeading (ICLLocationManagerDelegate This, CLLocationManager manager, CLHeading newHeading)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var newHeading__handle__ = newHeading!.GetNonNullHandle (nameof (newHeading));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didUpdateHeading:"), manager__handle__, newHeading__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (newHeading);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><summary>The system believes that the magnetometer should be calibrated.</summary><returns>Return <see langword="true" /> to allow the calibration dialog.</returns><remarks><para>This method will be executed when the system believes that the magnetometer (compass) requires calibration, either because it has not been calibrated recently or because a large change in the local magnetic field was detected.</para><para>Application developers may override this method to return <see langword="false" />, in which case the calibration dialog will not appear.</para></remarks>
		[global::Foundation.OptionalMember]
		[Export ("locationManagerShouldDisplayHeadingCalibration:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDisplayHeadingCalibration (CLLocationManager manager)
		{
			return _ShouldDisplayHeadingCalibration (this, manager);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><summary>The system believes that the magnetometer should be calibrated.</summary><returns>Return <see langword="true" /> to allow the calibration dialog.</returns><remarks><para>This method will be executed when the system believes that the magnetometer (compass) requires calibration, either because it has not been calibrated recently or because a large change in the local magnetic field was detected.</para><para>Application developers may override this method to return <see langword="false" />, in which case the calibration dialog will not appear.</para></remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldDisplayHeadingCalibration (ICLLocationManagerDelegate This, CLLocationManager manager)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("locationManagerShouldDisplayHeadingCalibration:"), manager__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			return ret != 0;
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="error">The error that occurred.</param><summary>A failure occurred while updating locations.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("locationManager:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Failed (CLLocationManager manager, NSError error)
		{
			_Failed (this, manager, error);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="error">The error that occurred.</param><summary>A failure occurred while updating locations.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Failed (ICLLocationManagerDelegate This, CLLocationManager manager, NSError error)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didFailWithError:"), manager__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (error);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="region">The region entered.</param><summary>Called when the device enters a monitored region.</summary><remarks></remarks>
		[global::Foundation.OptionalMember]
		[Export ("locationManager:didEnterRegion:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegionEntered (CLLocationManager manager, CLRegion region)
		{
			_RegionEntered (this, manager, region);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="region">The region entered.</param><summary>Called when the device enters a monitored region.</summary><remarks></remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RegionEntered (ICLLocationManagerDelegate This, CLLocationManager manager, CLRegion region)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var region__handle__ = region!.GetNonNullHandle (nameof (region));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didEnterRegion:"), manager__handle__, region__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (region);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="region">The region left.</param><summary>Called when the device leaves a monitored region.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("locationManager:didExitRegion:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegionLeft (CLLocationManager manager, CLRegion region)
		{
			_RegionLeft (this, manager, region);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="region">The region left.</param><summary>Called when the device leaves a monitored region.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RegionLeft (ICLLocationManagerDelegate This, CLLocationManager manager, CLRegion region)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var region__handle__ = region!.GetNonNullHandle (nameof (region));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didExitRegion:"), manager__handle__, region__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (region);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="region">To be added.</param><param name="error">The cause of the failure.</param><summary>Monitoring <paramref name="region" /> failed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("locationManager:monitoringDidFailForRegion:withError:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MonitoringFailed (CLLocationManager manager, CLRegion? region, NSError error)
		{
			_MonitoringFailed (this, manager, region, error);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="region">To be added.</param><param name="error">The cause of the failure.</param><summary>Monitoring <paramref name="region" /> failed.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MonitoringFailed (ICLLocationManagerDelegate This, CLLocationManager manager, CLRegion? region, NSError error)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var region__handle__ = region.GetHandle ();
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:monitoringDidFailForRegion:withError:"), manager__handle__, region__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (region);
			GC.KeepAlive (error);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="region">To be added.</param><summary>Monitoring began for <paramref name="region" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("locationManager:didStartMonitoringForRegion:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStartMonitoringForRegion (CLLocationManager manager, CLRegion region)
		{
			_DidStartMonitoringForRegion (this, manager, region);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="region">To be added.</param><summary>Monitoring began for <paramref name="region" />.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStartMonitoringForRegion (ICLLocationManagerDelegate This, CLLocationManager manager, CLRegion region)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var region__handle__ = region!.GetNonNullHandle (nameof (region));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didStartMonitoringForRegion:"), manager__handle__, region__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (region);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="state">The new state of the region.</param><param name="region">To be added.</param><summary>The <paramref name="state" /> of the <paramref name="region" /> has changed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("locationManager:didDetermineState:forRegion:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDetermineState (CLLocationManager manager, CLRegionState state, CLRegion region)
		{
			_DidDetermineState (this, manager, state, region);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="state">The new state of the region.</param><param name="region">To be added.</param><summary>The <paramref name="state" /> of the <paramref name="region" /> has changed.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDetermineState (ICLLocationManagerDelegate This, CLLocationManager manager, CLRegionState state, CLRegion region)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var region__handle__ = region!.GetNonNullHandle (nameof (region));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didDetermineState:forRegion:"), manager__handle__, (IntPtr) (long) state, region__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (region);
		}
		[global::Foundation.OptionalMember]
		[Export ("locationManager:didRangeBeacons:satisfyingConstraint:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRangeBeaconsSatisfyingConstraint (CLLocationManager manager, CLBeacon[] beacons, CLBeaconIdentityConstraint beaconConstraint)
		{
			_DidRangeBeaconsSatisfyingConstraint (this, manager, beacons, beaconConstraint);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRangeBeaconsSatisfyingConstraint (ICLLocationManagerDelegate This, CLLocationManager manager, CLBeacon[] beacons, CLBeaconIdentityConstraint beaconConstraint)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			if (beacons is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (beacons));
			var beaconConstraint__handle__ = beaconConstraint!.GetNonNullHandle (nameof (beaconConstraint));
			using var nsa_beacons = NSArray.FromNSObjects (beacons);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didRangeBeacons:satisfyingConstraint:"), manager__handle__, nsa_beacons.Handle, beaconConstraint__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (beaconConstraint);
		}
		[global::Foundation.OptionalMember]
		[Export ("locationManager:didFailRangingBeaconsForConstraint:error:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailRangingBeacons (CLLocationManager manager, CLBeaconIdentityConstraint beaconConstraint, NSError error)
		{
			_DidFailRangingBeacons (this, manager, beaconConstraint, error);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailRangingBeacons (ICLLocationManagerDelegate This, CLLocationManager manager, CLBeaconIdentityConstraint beaconConstraint, NSError error)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var beaconConstraint__handle__ = beaconConstraint!.GetNonNullHandle (nameof (beaconConstraint));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didFailRangingBeaconsForConstraint:error:"), manager__handle__, beaconConstraint__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (beaconConstraint);
			GC.KeepAlive (error);
		}
		/// <param name="manager">To be added.</param><param name="visit">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("locationManager:didVisit:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidVisit (CLLocationManager manager, CLVisit visit)
		{
			_DidVisit (this, manager, visit);
		}
		/// <param name="manager">To be added.</param><param name="visit">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidVisit (ICLLocationManagerDelegate This, CLLocationManager manager, CLVisit visit)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var visit__handle__ = visit!.GetNonNullHandle (nameof (visit));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didVisit:"), manager__handle__, visit__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (visit);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="status">The new authorization status of the application.</param><summary>The authorization status of the application has changed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("locationManager:didChangeAuthorizationStatus:")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'DidChangeAuthorization' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'DidChangeAuthorization' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'DidChangeAuthorization' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'DidChangeAuthorization' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AuthorizationChanged (CLLocationManager manager, CLAuthorizationStatus status)
		{
			_AuthorizationChanged (this, manager, status);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="status">The new authorization status of the application.</param><summary>The authorization status of the application has changed.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios14.0", "Use 'DidChangeAuthorization' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'DidChangeAuthorization' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'DidChangeAuthorization' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'DidChangeAuthorization' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AuthorizationChanged (ICLLocationManagerDelegate This, CLLocationManager manager, CLAuthorizationStatus status)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt32 (This.Handle, Selector.GetHandle ("locationManager:didChangeAuthorizationStatus:"), manager__handle__, (UInt32)status);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="locations">To be added.</param><summary>The device has generated <paramref name="locations" /> updates.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("locationManager:didUpdateLocations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LocationsUpdated (CLLocationManager manager, CLLocation[] locations)
		{
			_LocationsUpdated (this, manager, locations);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="locations">To be added.</param><summary>The device has generated <paramref name="locations" /> updates.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _LocationsUpdated (ICLLocationManagerDelegate This, CLLocationManager manager, CLLocation[] locations)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			if (locations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (locations));
			using var nsa_locations = NSArray.FromNSObjects (locations);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didUpdateLocations:"), manager__handle__, nsa_locations.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><summary>Location updating has been paused.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("locationManagerDidPauseLocationUpdates:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LocationUpdatesPaused (CLLocationManager manager)
		{
			_LocationUpdatesPaused (this, manager);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><summary>Location updating has been paused.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _LocationUpdatesPaused (ICLLocationManagerDelegate This, CLLocationManager manager)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("locationManagerDidPauseLocationUpdates:"), manager__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><summary>Location updating has restarted after pausing.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("locationManagerDidResumeLocationUpdates:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LocationUpdatesResumed (CLLocationManager manager)
		{
			_LocationUpdatesResumed (this, manager);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><summary>Location updating has restarted after pausing.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _LocationUpdatesResumed (ICLLocationManagerDelegate This, CLLocationManager manager)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("locationManagerDidResumeLocationUpdates:"), manager__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="error">The reason deferred updates are no longer available.</param><summary>Location updates will no longer be deferred.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("locationManager:didFinishDeferredUpdatesWithError:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeferredUpdatesFinished (CLLocationManager manager, NSError? error)
		{
			_DeferredUpdatesFinished (this, manager, error);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="error">The reason deferred updates are no longer available.</param><summary>Location updates will no longer be deferred.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DeferredUpdatesFinished (ICLLocationManagerDelegate This, CLLocationManager manager, NSError? error)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didFinishDeferredUpdatesWithError:"), manager__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("locationManagerDidChangeAuthorization:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeAuthorization (CLLocationManager manager)
		{
			_DidChangeAuthorization (this, manager);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeAuthorization (ICLLocationManagerDelegate This, CLLocationManager manager)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("locationManagerDidChangeAuthorization:"), manager__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
		[DynamicDependencyAttribute ("AuthorizationChanged(CoreLocation.CLLocationManager,CoreLocation.CLAuthorizationStatus)")]
		[DynamicDependencyAttribute ("DeferredUpdatesFinished(CoreLocation.CLLocationManager,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidChangeAuthorization(CoreLocation.CLLocationManager)")]
		[DynamicDependencyAttribute ("DidDetermineState(CoreLocation.CLLocationManager,CoreLocation.CLRegionState,CoreLocation.CLRegion)")]
		[DynamicDependencyAttribute ("DidFailRangingBeacons(CoreLocation.CLLocationManager,CoreLocation.CLBeaconIdentityConstraint,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidRangeBeaconsSatisfyingConstraint(CoreLocation.CLLocationManager,CoreLocation.CLBeacon[],CoreLocation.CLBeaconIdentityConstraint)")]
		[DynamicDependencyAttribute ("DidStartMonitoringForRegion(CoreLocation.CLLocationManager,CoreLocation.CLRegion)")]
		[DynamicDependencyAttribute ("DidVisit(CoreLocation.CLLocationManager,CoreLocation.CLVisit)")]
		[DynamicDependencyAttribute ("Failed(CoreLocation.CLLocationManager,Foundation.NSError)")]
		[DynamicDependencyAttribute ("LocationsUpdated(CoreLocation.CLLocationManager,CoreLocation.CLLocation[])")]
		[DynamicDependencyAttribute ("LocationUpdatesPaused(CoreLocation.CLLocationManager)")]
		[DynamicDependencyAttribute ("LocationUpdatesResumed(CoreLocation.CLLocationManager)")]
		[DynamicDependencyAttribute ("MonitoringFailed(CoreLocation.CLLocationManager,CoreLocation.CLRegion,Foundation.NSError)")]
		[DynamicDependencyAttribute ("RegionEntered(CoreLocation.CLLocationManager,CoreLocation.CLRegion)")]
		[DynamicDependencyAttribute ("RegionLeft(CoreLocation.CLLocationManager,CoreLocation.CLRegion)")]
		[DynamicDependencyAttribute ("ShouldDisplayHeadingCalibration(CoreLocation.CLLocationManager)")]
		[DynamicDependencyAttribute ("UpdatedHeading(CoreLocation.CLLocationManager,CoreLocation.CLHeading)")]
		[DynamicDependencyAttribute ("UpdatedLocation(CoreLocation.CLLocationManager,CoreLocation.CLLocation,CoreLocation.CLLocation)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CLLocationManagerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICLLocationManagerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICLLocationManagerDelegate" /> interface to support all the methods from the CLLocationManagerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICLLocationManagerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CLLocationManagerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CLLocationManagerDelegate_Extensions {
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="newLocation">To be added.</param><param name="oldLocation">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdatedLocation (this ICLLocationManagerDelegate This, CLLocationManager manager, CLLocation newLocation, CLLocation oldLocation)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var newLocation__handle__ = newLocation!.GetNonNullHandle (nameof (newLocation));
			var oldLocation__handle__ = oldLocation!.GetNonNullHandle (nameof (oldLocation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didUpdateToLocation:fromLocation:"), manager__handle__, newLocation__handle__, oldLocation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (newLocation);
			GC.KeepAlive (oldLocation);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="newHeading">The new heading.</param><summary>The device's heading has been updated.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdatedHeading (this ICLLocationManagerDelegate This, CLLocationManager manager, CLHeading newHeading)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var newHeading__handle__ = newHeading!.GetNonNullHandle (nameof (newHeading));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didUpdateHeading:"), manager__handle__, newHeading__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (newHeading);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><summary>The system believes that the magnetometer should be calibrated.</summary><returns>Return <see langword="true" /> to allow the calibration dialog.</returns><remarks><para>This method will be executed when the system believes that the magnetometer (compass) requires calibration, either because it has not been calibrated recently or because a large change in the local magnetic field was detected.</para><para>Application developers may override this method to return <see langword="false" />, in which case the calibration dialog will not appear.</para></remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldDisplayHeadingCalibration (this ICLLocationManagerDelegate This, CLLocationManager manager)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("locationManagerShouldDisplayHeadingCalibration:"), manager__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			return ret != 0;
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="error">The error that occurred.</param><summary>A failure occurred while updating locations.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Failed (this ICLLocationManagerDelegate This, CLLocationManager manager, NSError error)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didFailWithError:"), manager__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (error);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="region">The region entered.</param><summary>Called when the device enters a monitored region.</summary><remarks></remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegionEntered (this ICLLocationManagerDelegate This, CLLocationManager manager, CLRegion region)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var region__handle__ = region!.GetNonNullHandle (nameof (region));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didEnterRegion:"), manager__handle__, region__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (region);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="region">The region left.</param><summary>Called when the device leaves a monitored region.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegionLeft (this ICLLocationManagerDelegate This, CLLocationManager manager, CLRegion region)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var region__handle__ = region!.GetNonNullHandle (nameof (region));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didExitRegion:"), manager__handle__, region__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (region);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="region">To be added.</param><param name="error">The cause of the failure.</param><summary>Monitoring <paramref name="region" /> failed.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MonitoringFailed (this ICLLocationManagerDelegate This, CLLocationManager manager, CLRegion? region, NSError error)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var region__handle__ = region.GetHandle ();
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:monitoringDidFailForRegion:withError:"), manager__handle__, region__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (region);
			GC.KeepAlive (error);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="region">To be added.</param><summary>Monitoring began for <paramref name="region" />.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStartMonitoringForRegion (this ICLLocationManagerDelegate This, CLLocationManager manager, CLRegion region)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var region__handle__ = region!.GetNonNullHandle (nameof (region));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didStartMonitoringForRegion:"), manager__handle__, region__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (region);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="state">The new state of the region.</param><param name="region">To be added.</param><summary>The <paramref name="state" /> of the <paramref name="region" /> has changed.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDetermineState (this ICLLocationManagerDelegate This, CLLocationManager manager, CLRegionState state, CLRegion region)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var region__handle__ = region!.GetNonNullHandle (nameof (region));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didDetermineState:forRegion:"), manager__handle__, (IntPtr) (long) state, region__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (region);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRangeBeaconsSatisfyingConstraint (this ICLLocationManagerDelegate This, CLLocationManager manager, CLBeacon[] beacons, CLBeaconIdentityConstraint beaconConstraint)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			if (beacons is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (beacons));
			var beaconConstraint__handle__ = beaconConstraint!.GetNonNullHandle (nameof (beaconConstraint));
			using var nsa_beacons = NSArray.FromNSObjects (beacons);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didRangeBeacons:satisfyingConstraint:"), manager__handle__, nsa_beacons.Handle, beaconConstraint__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (beaconConstraint);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailRangingBeacons (this ICLLocationManagerDelegate This, CLLocationManager manager, CLBeaconIdentityConstraint beaconConstraint, NSError error)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var beaconConstraint__handle__ = beaconConstraint!.GetNonNullHandle (nameof (beaconConstraint));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didFailRangingBeaconsForConstraint:error:"), manager__handle__, beaconConstraint__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (beaconConstraint);
			GC.KeepAlive (error);
		}
		/// <param name="manager">To be added.</param><param name="visit">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidVisit (this ICLLocationManagerDelegate This, CLLocationManager manager, CLVisit visit)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var visit__handle__ = visit!.GetNonNullHandle (nameof (visit));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didVisit:"), manager__handle__, visit__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (visit);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="status">The new authorization status of the application.</param><summary>The authorization status of the application has changed.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios14.0", "Use 'DidChangeAuthorization' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'DidChangeAuthorization' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'DidChangeAuthorization' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'DidChangeAuthorization' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AuthorizationChanged (this ICLLocationManagerDelegate This, CLLocationManager manager, CLAuthorizationStatus status)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt32 (This.Handle, Selector.GetHandle ("locationManager:didChangeAuthorizationStatus:"), manager__handle__, (UInt32)status);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="locations">To be added.</param><summary>The device has generated <paramref name="locations" /> updates.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LocationsUpdated (this ICLLocationManagerDelegate This, CLLocationManager manager, CLLocation[] locations)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			if (locations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (locations));
			using var nsa_locations = NSArray.FromNSObjects (locations);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didUpdateLocations:"), manager__handle__, nsa_locations.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><summary>Location updating has been paused.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LocationUpdatesPaused (this ICLLocationManagerDelegate This, CLLocationManager manager)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("locationManagerDidPauseLocationUpdates:"), manager__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><summary>Location updating has restarted after pausing.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LocationUpdatesResumed (this ICLLocationManagerDelegate This, CLLocationManager manager)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("locationManagerDidResumeLocationUpdates:"), manager__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="error">The reason deferred updates are no longer available.</param><summary>Location updates will no longer be deferred.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DeferredUpdatesFinished (this ICLLocationManagerDelegate This, CLLocationManager manager, NSError? error)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("locationManager:didFinishDeferredUpdatesWithError:"), manager__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (error);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeAuthorization (this ICLLocationManagerDelegate This, CLLocationManager manager)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("locationManagerDidChangeAuthorization:"), manager__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CLLocationManagerDelegateWrapper : BaseWrapper, ICLLocationManagerDelegate {
		public CLLocationManagerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CLLocationManagerDelegateWrapper))]
		static CLLocationManagerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace CoreLocation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="ICLLocationManagerDelegate" /> (for the protocol <c>CLLocationManagerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="ICLLocationManagerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__CoreLocation_CLLocationManagerDelegate", false)]
	[Model]
	public unsafe partial class CLLocationManagerDelegate : NSObject, ICLLocationManagerDelegate {
		/// <summary>Creates a new <see cref="CLLocationManagerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CLLocationManagerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected CLLocationManagerDelegate (NSObjectFlag t) : base (t)
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
		protected internal CLLocationManagerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="status">The new authorization status of the application.</param><summary>The authorization status of the application has changed.</summary><remarks>To be added.</remarks>
		[Export ("locationManager:didChangeAuthorizationStatus:")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'DidChangeAuthorization' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'DidChangeAuthorization' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'DidChangeAuthorization' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'DidChangeAuthorization' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AuthorizationChanged (CLLocationManager manager, CLAuthorizationStatus status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="error">The reason deferred updates are no longer available.</param><summary>Location updates will no longer be deferred.</summary><remarks>To be added.</remarks>
		[Export ("locationManager:didFinishDeferredUpdatesWithError:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeferredUpdatesFinished (CLLocationManager manager, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("locationManagerDidChangeAuthorization:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeAuthorization (CLLocationManager manager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="state">The new state of the region.</param><param name="region">To be added.</param><summary>The <paramref name="state" /> of the <paramref name="region" /> has changed.</summary><remarks>To be added.</remarks>
		[Export ("locationManager:didDetermineState:forRegion:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDetermineState (CLLocationManager manager, CLRegionState state, CLRegion region)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("locationManager:didFailRangingBeaconsForConstraint:error:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailRangingBeacons (CLLocationManager manager, CLBeaconIdentityConstraint beaconConstraint, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("locationManager:didRangeBeacons:satisfyingConstraint:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRangeBeaconsSatisfyingConstraint (CLLocationManager manager, CLBeacon[] beacons, CLBeaconIdentityConstraint beaconConstraint)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="region">To be added.</param><summary>Monitoring began for <paramref name="region" />.</summary><remarks>To be added.</remarks>
		[Export ("locationManager:didStartMonitoringForRegion:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStartMonitoringForRegion (CLLocationManager manager, CLRegion region)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="manager">To be added.</param><param name="visit">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("locationManager:didVisit:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidVisit (CLLocationManager manager, CLVisit visit)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="error">The error that occurred.</param><summary>A failure occurred while updating locations.</summary><remarks>To be added.</remarks>
		[Export ("locationManager:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Failed (CLLocationManager manager, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><summary>Location updating has been paused.</summary><remarks>To be added.</remarks>
		[Export ("locationManagerDidPauseLocationUpdates:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LocationUpdatesPaused (CLLocationManager manager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><summary>Location updating has restarted after pausing.</summary><remarks>To be added.</remarks>
		[Export ("locationManagerDidResumeLocationUpdates:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LocationUpdatesResumed (CLLocationManager manager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="locations">To be added.</param><summary>The device has generated <paramref name="locations" /> updates.</summary><remarks>To be added.</remarks>
		[Export ("locationManager:didUpdateLocations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LocationsUpdated (CLLocationManager manager, CLLocation[] locations)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="region">To be added.</param><param name="error">The cause of the failure.</param><summary>Monitoring <paramref name="region" /> failed.</summary><remarks>To be added.</remarks>
		[Export ("locationManager:monitoringDidFailForRegion:withError:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MonitoringFailed (CLLocationManager manager, CLRegion? region, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="region">The region entered.</param><summary>Called when the device enters a monitored region.</summary><remarks></remarks>
		[Export ("locationManager:didEnterRegion:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegionEntered (CLLocationManager manager, CLRegion region)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="region">The region left.</param><summary>Called when the device leaves a monitored region.</summary><remarks>To be added.</remarks>
		[Export ("locationManager:didExitRegion:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegionLeft (CLLocationManager manager, CLRegion region)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><summary>The system believes that the magnetometer should be calibrated.</summary><returns>Return <see langword="true" /> to allow the calibration dialog.</returns><remarks><para>This method will be executed when the system believes that the magnetometer (compass) requires calibration, either because it has not been calibrated recently or because a large change in the local magnetic field was detected.</para><para>Application developers may override this method to return <see langword="false" />, in which case the calibration dialog will not appear.</para></remarks>
		[Export ("locationManagerShouldDisplayHeadingCalibration:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDisplayHeadingCalibration (CLLocationManager manager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="newHeading">The new heading.</param><summary>The device's heading has been updated.</summary><remarks>To be added.</remarks>
		[Export ("locationManager:didUpdateHeading:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedHeading (CLLocationManager manager, CLHeading newHeading)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="manager">The <see cref="T:CoreLocation.CLLocationManager" /> for which <c>this</c> is the delegate object.</param><param name="newLocation">To be added.</param><param name="oldLocation">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[Export ("locationManager:didUpdateToLocation:fromLocation:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedLocation (CLLocationManager manager, CLLocation newLocation, CLLocation oldLocation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CLLocationManagerDelegate */
}
