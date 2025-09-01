//
// Unit tests for VTDecompressionSession
//
// Authors:
//	Alex Soto <alex.soto@xamarin.com>
//	
//
// Copyright 2015 Xamarin Inc. All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Foundation;
using VideoToolbox;
using CoreMedia;
using CoreVideo;
using AVFoundation;
using CoreFoundation;
using ObjCRuntime;
using NUnit.Framework;
using Xamarin.Utils;

namespace MonoTouchFixtures.VideoToolbox {

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class VTDecompressionSessionTests {
		[Test]
		public void DecompressionSessionPropertiesTest ()
		{
			TestRuntime.AssertXcodeVersion (15, 0);

			Assert.That (VTDecompressionSession.IsStereoMvHevcDecodeSupported (), Is.EqualTo (false).Or.EqualTo (true), "IsStereoMvHevcDecodeSupported");
		}

		[Test]
		public void DecompressionSessionCreateTest ()
		{
			TestRuntime.AssertSystemVersion (ApplePlatform.iOS, 8, 0, throwIfOtherPlatform: false);
			TestRuntime.AssertSystemVersion (ApplePlatform.MacOSX, 10, 8, throwIfOtherPlatform: false);
			TestRuntime.AssertSystemVersion (ApplePlatform.TVOS, 10, 2, throwIfOtherPlatform: false);

			using (var asset = AVAsset.FromUrl (NSBundle.MainBundle.GetUrlForResource ("xamvideotest", "mp4")))
			using (var session = CreateSession (asset)) {
				Assert.IsNotNull (session, "Session should not be null");
			}
		}

		[Test]
		public void DecompressionSessionSetDecompressionPropertiesTest ()
		{
			TestRuntime.AssertSystemVersion (ApplePlatform.iOS, 8, 0, throwIfOtherPlatform: false);
			TestRuntime.AssertSystemVersion (ApplePlatform.MacOSX, 10, 10, throwIfOtherPlatform: false);
			TestRuntime.AssertSystemVersion (ApplePlatform.TVOS, 10, 2, throwIfOtherPlatform: false);

			using (var asset = AVAsset.FromUrl (NSBundle.MainBundle.GetUrlForResource ("xamvideotest", "mp4")))
			using (var session = CreateSession (asset)) {

				var result = session.SetDecompressionProperties (new VTDecompressionProperties {
					RealTime = true,
					OnlyTheseFrames = VTOnlyTheseFrames.AllFrames
				});

				Assert.AreEqual (VTStatus.Ok, result, "SetDecompressionProperties");
			}
		}

		[Test]
		public void DecompressionSessionSetPropertiesTest ()
		{
			TestRuntime.AssertSystemVersion (ApplePlatform.iOS, 8, 0, throwIfOtherPlatform: false);
			TestRuntime.AssertSystemVersion (ApplePlatform.MacOSX, 10, 8, throwIfOtherPlatform: false);
			TestRuntime.AssertSystemVersion (ApplePlatform.TVOS, 10, 2, throwIfOtherPlatform: false);

			using (var asset = AVAsset.FromUrl (NSBundle.MainBundle.GetUrlForResource ("xamvideotest", "mp4")))
			using (var session = CreateSession (asset)) {

				var result = session.SetProperties (new VTPropertyOptions {
					ReadWriteStatus = VTReadWriteStatus.ReadWrite,
					ShouldBeSerialized = true
				});

				Assert.AreEqual (VTStatus.Ok, result, "SetProperties");
			}
		}

		[Test]
		public void DecompressionSessionGetSupportedPropertiesTest ()
		{
			TestRuntime.AssertSystemVersion (ApplePlatform.iOS, 8, 0, throwIfOtherPlatform: false);
			TestRuntime.AssertSystemVersion (ApplePlatform.MacOSX, 10, 8, throwIfOtherPlatform: false);
			TestRuntime.AssertSystemVersion (ApplePlatform.TVOS, 10, 2, throwIfOtherPlatform: false);

			using (var asset = AVAsset.FromUrl (NSBundle.MainBundle.GetUrlForResource ("xamvideotest", "mp4")))
			using (var session = CreateSession (asset)) {
				var supportedProps = session.GetSupportedProperties ();
				Assert.NotNull (supportedProps, "GetSupportedProperties");
				Assert.That (supportedProps.Count, Is.GreaterThan ((nuint) 0), "GetSupportedProperties should be more than zero");
			}
		}
		VTDecompressionSession CreateSession (AVAsset asset)
		{
			var videoTracks = asset.TracksWithMediaType (AVMediaTypes.Video.GetConstant ());
			var track = videoTracks [0];
			var formatDescriptor = track.FormatDescriptions [0] as CMVideoFormatDescription;
			return CreateSession (formatDescriptor);
		}

		VTDecompressionSession CreateSession (CMVideoFormatDescription formatDescriptor)
		{
			return CreateSession (formatDescriptor, (sourceFrame, status, flags, buffer, presentationTimeStamp, presentationDuration) => { });
		}

		VTDecompressionSession CreateSession (CMVideoFormatDescription formatDescriptor, VTDecompressionSession.VTDecompressionOutputCallback? callback)
		{
			return VTDecompressionSession.Create (callback, formatDescriptor);
		}

		static string AsString (CMVideoFormatDescription? vd)
		{
			if (vd is null)
				return $"null";
			var tagCollections = vd.TagCollections;
			var rv = $"MediaType: {vd.MediaType} Dimensions: {vd.Dimensions} VideoCodecType: {vd.VideoCodecType} Extensions: {vd.GetExtensions ()} Tag Collections: {tagCollections?.Length ?? 0}";
			if (tagCollections is not null) {
				foreach (var tc in tagCollections) {
					rv += $"\n    {tc}";
				}
			}
			return rv;
		}

		public static string AsString (CVImageBuffer? buffer)
		{
			if (buffer is null)
				return "null";

			if (buffer is CVPixelBuffer pixelBuffer) {
				return $"Pixel buffer: {pixelBuffer}\n" +
					$"    IsPlanar: {pixelBuffer.IsPlanar}\n" +
					$"    PixelFormatTypex: {pixelBuffer.PixelFormatType}\n" +
					$"    GetAttributes: {pixelBuffer.GetAttributes (null)}\n" +
					$"    GetPixelBufferCreationAttributes: {pixelBuffer.GetPixelBufferCreationAttributes ()?.Dictionary}\n";
			} else {
				return $"Image buffer: {buffer} ({buffer.GetType ().Name})";
			}
		}

		class SampleBufferEnumerator {
			public CMVideoFormatDescription FormatDescription;
			AVAssetTrack? videoTrack;
			AVAsset? asset;

			public SampleBufferEnumerator (NSUrl url, AVMediaCharacteristics characteristic = AVMediaCharacteristics.Visual)
			{
				asset = AVAsset.FromUrl (url);
				Assert.That (asset, Is.Not.Null, "Asset");

				var loaded = new TaskCompletionSource<CMVideoFormatDescription> ();

				asset.LoadTrackWithMediaCharacteristics (characteristic.GetConstant (), (tracks, error) =>
				{
					try {
						Assert.Null (error, "Failed to load track");

						videoTrack = (AVAssetTrack) tracks.ToArray ().First ();

						var format = (CMVideoFormatDescription) videoTrack.FormatDescriptions [0];
						loaded.SetResult (format);

						var tr = tracks.ToArray ();
						TestRuntime.NSLog ($"Loaded {url} with {tr.Length} '{characteristic}' tracks.");
						for (var i = 0; i < tr.Length; i++) {
							TestRuntime.NSLog ($"    Track #{i+1}: {tr [i]}");
							var fd = tr [i].FormatDescriptions;
							for (var f = 0; f < fd.Length; f++) {
								var vd = (CMVideoFormatDescription) fd [f];
								TestRuntime.NSLog ($"        Format descriptor #{f + 1}/{fd.Length}: {fd [f]} ({AsString (vd)})");
							}
						}
					} catch (Exception e) {
						loaded.SetException (e);
					}
				});

				Assert.IsTrue (loaded.Task.Wait (TimeSpan.FromSeconds (15)), "Timed out waiting for track to load");
				FormatDescription = loaded.Task.Result;
			}

			public void Enumerate (Action<CMSampleBuffer> iterator)
			{
				var cursor = videoTrack.MakeSampleCursorAtFirstSampleInDecodeOrder ();
				var sampleBufferGenerator = new AVSampleBufferGenerator (asset, null);
				var request = new AVSampleBufferRequest (cursor);
				var sampleCount = 0L;

				do {
					using var buffer = sampleBufferGenerator.CreateSampleBuffer (request, out var sampleBufferError);
					Assert.NotNull (buffer, "Sample Buffer");
					Assert.Null (sampleBufferError, "Sample Buffer Error");

					TestRuntime.NSLog ($"Got sample buffer: PresentationTimestamp: {buffer.PresentationTimeStamp} Duration:{buffer.Duration} TotalSampleSize:{buffer.TotalSampleSize} NumSamples: {buffer.NumSamples}");
					TestRuntime.NSLog ($"    DataIsReady: {buffer.DataIsReady}");
					TestRuntime.NSLog ($"    Tagged buffer group: {buffer.TaggedBufferGroup}");
					TestRuntime.NSLog ($"    Video format description: {AsString (buffer.GetVideoFormatDescription ())}");
					var dataBuffer = buffer.GetDataBuffer ();
					TestRuntime.NSLog ($"    Data buffer: {dataBuffer} ({dataBuffer?.GetType ()?.Name})");
					var imageBuffer = buffer.GetImageBuffer ();
					TestRuntime.NSLog ($"    Image buffer: {AsString (imageBuffer)}");

					iterator (buffer);

					sampleCount = cursor.StepInDecodeOrder(1);
				} while (sampleCount == 1);
			}
		}

		[Test]
		public void DecodeFrameTest ()
		{
			using var url = NSBundle.MainBundle.GetUrlForResource ("xamvideotest", "mp4");
			Assert.That (url, Is.Not.Null, "Url");

			var failures = new List<string> ();

			var bufferEnumerator = new SampleBufferEnumerator (url);

			var frameCallbackCounter = 0;
			using var session = CreateSession (bufferEnumerator.FormatDescription,
				(sourceFrame, status, flags, buffer, presentationTimeStamp, presentationDuration) => {
					frameCallbackCounter++;
					TestRuntime.NSLog ($"DecodeFrameTest () callback #{frameCallbackCounter}: sourceFrame: 0x{sourceFrame:x} status: {status} flags: {flags} buffer: {buffer} presentationTimeStamp: {presentationTimeStamp} presentationDuration: {presentationDuration}\n{AsString (buffer)}");
					if (status != VTStatus.Ok)
						failures.Add ($"DecodeFrameTest #{frameCallbackCounter} failed. Expected status = Ok, got status = {status}");
				});

			bufferEnumerator.Enumerate ((buffer) => {
				var status = session.DecodeFrame (buffer, VTDecodeFrameFlags.EnableAsynchronousDecompression, 0x0ee1f00d, out var infoFlags);
				TestRuntime.NSLog ($"DecodeFrame result: {status}");
				Assert.That (status, Is.EqualTo (VTStatus.Ok), "DecodeFrame");
			});

			session.FinishDelayedFrames ();
			Assert.That (frameCallbackCounter, Is.GreaterThan (0), "Frame callback counter");
			Assert.That (failures, Is.Empty, "Failures");
		}

#if !__TVOS__
		[Test]
		public void DecodeFrameMultiImageCallbackTest ()
		{
			if (!VTDecompressionSession.IsStereoMvHevcDecodeSupported ())
				Assert.Ignore ("Stereo MV-HEVC decoding is not supported on the current system.");

			TestRuntime.AssertXcodeVersion (16, 0);

			using var url = NSBundle.MainBundle.GetUrlForResource ("hummingbird", "mov");
			Assert.That (url, Is.Not.Null, "Url");

			var failures = new List<string> ();

			var bufferEnumerator = new SampleBufferEnumerator (url, characteristic: AVMediaCharacteristics.ContainsStereoMultiviewVideo);

			var frameCallbackCounter = 0;

			using var session = CreateSession (bufferEnumerator.FormatDescription, null);

			bufferEnumerator.Enumerate ((buffer) => {
				var status = session.DecodeFrame (buffer, VTDecodeFrameFlags.EnableAsynchronousDecompression, out var infoFlags,
					(status, infoFlags, imageBuffer, taggedBufferGroup, presentationTimeStamp, presentationDuration) => {
						frameCallbackCounter++;
						TestRuntime.NSLog ($"DecodeFrameMultiImageCallbackTest decodeframe callback (#{frameCallbackCounter}): status: {status} infoFlags: {infoFlags} imageBuffer: {imageBuffer} taggedBufferGroup: {taggedBufferGroup} presentationTimeStamp: {presentationTimeStamp} presentationDuration: {presentationDuration}\n{AsString (imageBuffer)}");
						if (status != VTStatus.Ok)
							failures.Add ($"DecodeFrameMultiImageCallbackTest #{frameCallbackCounter} failed. Expected status = Ok, got status = {status}");
					});
				TestRuntime.NSLog ($"DecodeFrame result: {status}");
				Assert.That (status, Is.EqualTo (VTStatus.Ok), "DecodeFrame");
			});

			session.FinishDelayedFrames ();
			Assert.That (frameCallbackCounter, Is.GreaterThan (0), "Frame callback counter 2");
			Assert.That (failures, Is.Empty, "Failures");
		}

		[Test]
		public void DecodeFrameCallbackTest ()
		{
			TestRuntime.AssertXcodeVersion (16, 0);

			using var url = NSBundle.MainBundle.GetUrlForResource ("hummingbird", "mov");
			Assert.That (url, Is.Not.Null, "Url");

			var failures = new List<string> ();

			var bufferEnumerator = new SampleBufferEnumerator (url);

			var frameCallbackCounter3 = 0;
			var frameCallbackCounter4 = 0;
			using var session = CreateSession (bufferEnumerator.FormatDescription, null);

			TestRuntime.NSLog ($"Created session with format descriptor: {bufferEnumerator.FormatDescription}");

			var st = session.SetMultiImageCallback ((outputMultiImageReference, sourceFrameReference, status, infoFlags, taggedBufferGroup, presentationTimeStamp, presentationDuration) =>
			{
				TestRuntime.NSLog ($"DecodeFrameCallbackTest (): outputMultiImageReference: 0x{outputMultiImageReference:x} sourceFrameReference: 0x{sourceFrameReference:x} status: {status} infoFlags: {infoFlags} taggedBufferGroup: {taggedBufferGroup} presentationTimeStamp: {presentationTimeStamp} presentationDuration: {presentationDuration}");
				frameCallbackCounter3++;
			}, 0x0a1efeab);

			bufferEnumerator.Enumerate ((buffer) => {
				var status = session.DecodeFrame (buffer, VTDecodeFrameFlags.EnableAsynchronousDecompression, (NSDictionary?) null, out var infoFlags,
					(status, flags, buffer, presentationTimeStamp, presentationDuration) =>
					{
						TestRuntime.NSLog ($"DecodeFrameCallbackTest (): status: {status} flags: {flags} buffer: {buffer} presentationTimeStamp: {presentationTimeStamp} presentationDuration: {presentationDuration}\n{AsString (buffer)}");
						frameCallbackCounter4++;
					});
				Assert.That (status, Is.EqualTo (VTStatus.Ok), "DecodeFrame");
			});
			session.FinishDelayedFrames ();

			Assert.That (frameCallbackCounter3, Is.EqualTo (0), "Frame callback counter 3");
			Assert.That (frameCallbackCounter4, Is.GreaterThan (0), "Frame callback counter 4");
			Assert.That (failures, Is.Empty, "Failures");
		}
#endif // !__TVOS__
	}
}
