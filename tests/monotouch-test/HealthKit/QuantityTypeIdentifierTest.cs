﻿//
// Unit tests for HKQuantityTypeIdentifier
//
// Authors:
//	Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2014 Xamarin Inc. All rights reserved.
//

#if HAS_HEALTHKIT

using System;

using Foundation;
using HealthKit;
using UIKit;
using NUnit.Framework;

namespace MonoTouchFixtures.HealthKit {

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class QuantityTypeIdentifier {

		[Test]
		public void EnumValues_22351 ()
		{
			TestRuntime.AssertXcodeVersion (6, 0);

			foreach (HKQuantityTypeIdentifier value in Enum.GetValues (typeof (HKQuantityTypeIdentifier))) {

				// we need to have version checks for anything added after iOS 8.0
				switch (value) {
				case HKQuantityTypeIdentifier.BasalBodyTemperature:
				case HKQuantityTypeIdentifier.DietaryWater:
				case HKQuantityTypeIdentifier.UVExposure:
					if (!TestRuntime.CheckXcodeVersion (7, 0))
						continue;
					break;
				case HKQuantityTypeIdentifier.AppleExerciseTime:
					if (!TestRuntime.CheckXcodeVersion (7, 3))
						continue;
					break;
				case HKQuantityTypeIdentifier.DistanceWheelchair:
				case HKQuantityTypeIdentifier.PushCount:
				case HKQuantityTypeIdentifier.DistanceSwimming:
				case HKQuantityTypeIdentifier.SwimmingStrokeCount:
					if (!TestRuntime.CheckXcodeVersion (8, 0))
						continue;
					break;
				case HKQuantityTypeIdentifier.WaistCircumference:
				case HKQuantityTypeIdentifier.VO2Max:
				case HKQuantityTypeIdentifier.InsulinDelivery:
				case HKQuantityTypeIdentifier.RestingHeartRate:
				case HKQuantityTypeIdentifier.WalkingHeartRateAverage:
				case HKQuantityTypeIdentifier.HeartRateVariabilitySdnn:
					if (!TestRuntime.CheckXcodeVersion(9, 0))
						continue;
					break;
				case HKQuantityTypeIdentifier.DistanceDownhillSnowSports:
					if (!TestRuntime.CheckXcodeVersion (9, 2))
						continue;
					break;
				case HKQuantityTypeIdentifier.AppleStandTime:
				case HKQuantityTypeIdentifier.EnvironmentalAudioExposure:
				case HKQuantityTypeIdentifier.HeadphoneAudioExposure:
					if (!TestRuntime.CheckXcodeVersion(11, 0))
						continue;
					break;
				case HKQuantityTypeIdentifier.SixMinuteWalkTestDistance:
				case HKQuantityTypeIdentifier.StairAscentSpeed:
				case HKQuantityTypeIdentifier.StairDescentSpeed:
				case HKQuantityTypeIdentifier.WalkingAsymmetryPercentage:
				case HKQuantityTypeIdentifier.WalkingDoubleSupportPercentage:
				case HKQuantityTypeIdentifier.WalkingSpeed:
				case HKQuantityTypeIdentifier.WalkingStepLength:
					if (!TestRuntime.CheckXcodeVersion (12, TestRuntime.MinorXcode12APIMismatch))
						continue;
					break;
				case HKQuantityTypeIdentifier.AppleMoveTime:
					if (!TestRuntime.CheckXcodeVersion (12, 5))
						continue;
					break;
				}

				try {
					using (var ct = HKQuantityType.Create (value)) {
						Assert.That (ct.Handle, Is.Not.EqualTo (IntPtr.Zero), value.ToString ());
					}
				}
				catch (Exception e) {
					Assert.Fail ("{0} could not be created: {1}", value, e);
				}
			}
		}
	}
}

#endif // HAS_HEALTHKIT
