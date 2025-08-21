// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using NUnit.Framework;

using Xamarin.Utils;

namespace MonoTouchFixtures.VideoToolbox;

[TestFixture]
[Preserve (AllMembers = true)]
public class VTMotionEstimationSessionTest {
	[Test]
	public void CreateTest ()
	{
		TestRuntime.AssertXcodeVersion (26, 0);

		var width = 120;
		var height = 120;
		using var session = VTMotionEstimationSession.Create ((NSDictionary?) null, width, height, out var status);
		Assert.That (status, Is.EqualTo (VTStatus.Ok), "Create status");
		Assert.That (session, Is.Not.Null, "Create");

		DoTest (session, width, height);
	}

	[Test]
	public void CreateStronglyTypedTest ()
	{
		TestRuntime.AssertXcodeVersion (26, 0);

		var width = 120;
		var height = 120;
		var options = new VTMotionEstimationSessionCreationOption () {
			Label = "Test session",
		};
		using var session = VTMotionEstimationSession.Create (options, width, height, out var status);
		Assert.That (status, Is.EqualTo (VTStatus.Ok), "Create status");
		Assert.That (session, Is.Not.Null, "Create");

		DoTest (session, width, height);
	}

	void DoTest (VTMotionEstimationSession session, int width, int height)
	{
		Assert.That (session.TryGetSourcePixelBufferAttributes (out var pixelBufferAttributes, out status), Is.EqualTo (true), "TryGetSourcePixelBufferAttributes");
		Assert.That (status, Is.EqualTo (VTStatus.Ok), "TryGetSourcePixelBufferAttributes: status");
		Assert.That (pixelBufferAttributes, Is.Not.Null, "TryGetSourcePixelBufferAttributes: pixel buffers");

		pixelBufferAttributes = session.SourcePixelBufferAttributes;
		Assert.That (pixelBufferAttributes, Is.Not.Null, "SourcePixelBufferAttributes: pixel buffers");

		var tcs = new TaskCompletionSource<bool> ();

		using var referenceImage = new CVPixelBuffer (width, height, pixelBufferAttributes.PixelFormatType);
		using var currentImage = new CVPixelBuffer (width, height, pixelBufferAttributes.PixelFormatType);
		var estimatedAnything = false;
		status = session.EstimateMotionVectors (referenceImage, currentImage, VTMotionEstimationFrameFlags.None, null, (VTStatus status, VTMotionEstimationInfoFlags infoFlags, NSDictionary? additionalInfo, CVPixelBuffer? motionVectors) => {
			try {
				estimatedAnything = true;
				Console.WriteLine ($"status: {status} infoFlags: {infoFlags} additionalInfo: {additionalInfo} motionVectors: {motionVectors}");
			} catch (Exception e) {
				tcs.TrySetException (e);
			} finally {
				tcs.TrySetResult (true);
			}
		});
		Assert.That (status, Is.EqualTo (VTStatus.Ok), "EstimateMotionVectors: status");

		status = session.CompleteFrames ();
		Assert.That (status, Is.EqualTo (VTStatus.Ok), "CompleteFrames: status");

		Assert.That (estimatedAnything, Is.EqualTo (true), "Estimated anything");
	}

	[Test]
	public void GetTypeId ()
	{
		TestRuntime.AssertXcodeVersion (26, 0);

		Assert.AreNotEqual (0, VTMotionEstimationSession.GetTypeId (), "GetTypeId");
	}
}
