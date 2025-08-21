// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Foundation;

namespace VideoToolbox;

public partial class VTLowLatencyFrameInterpolationConfiguration {
	public static VTLowLatencyFrameInterpolationConfiguration CreateWithNumberOfInterpolatedFrames (nint frameWidth, nint frameHeight, nint numberOfInterpolatedFrames)
	{
		var rv = new VTLowLatencyFrameInterpolationConfiguration (NSObjectFlag.Empty);
		rv.InitializeHandle (rv._InitWithFrameWidthAndNumberOfInterpolatedFrames (frameWidth, frameHeight, numberOfInterpolatedFrames), "initWithFrameWidth:frameHeight:numberOfInterpolatedFrames:");
		return rv;
	}

	public static VTLowLatencyFrameInterpolationConfiguration CreateWithSpatialScaleFactor (nint frameWidth, nint frameHeight, nint spatialScaleFactor)
	{
		var rv = new VTLowLatencyFrameInterpolationConfiguration (NSObjectFlag.Empty);
		rv.InitializeHandle (rv._InitWithFrameWidthAndSpatialScaleFactor (frameWidth, frameHeight, spatialScaleFactor), "initWithFrameWidth:frameHeight:spatialScaleFactor:");
		return rv;
	}
}
