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

using Foundation;
using VideoToolbox;
using CoreMedia;
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

		VTDecompressionSession CreateSession (CMVideoFormatDescription formatDescriptor, VTDecompressionOutputCallback callback)
		{
			return VTDecompressionSession.Create (callback, formatDescriptor);
		}


		class SampleBufferEnumerator {
			public CMVideoFormatDescription FormatDescription;
			AVAssetTrack? videoTrack;

			public SampleBufferEnumerator (NSUrl url)
			{
				using var asset = AVAsset.FromUrl (url);
				Assert.That (asset, Is.Not.Null, "Asset");

				Exception? ex = null;
				var loaded = new TaskCompletionSource<CMVideoFormatDescription> ();

				asset.LoadTrackWithMediaCharacteristics (AVMediaCharacteristics.Visual.GetConstant (), (tracks, error) =>
				{
					try {
						Assert.NotNull (error, "Failed to load track");

						videoTrack = (AVAssetTrack) tracks.ToArray ().First ();

						loaded.SetResult (videoTrack.FormatDescriptions [0]);
					} catch (Exception e) {
						tcs.TrySetException (e)
					} finally {
						tcs.TrySetResult (true);
					}
				});

				Assert.IsTrue (loaded.Task.Wait (TimeSpan.FromSeconds (15)), "Timed out waiting for track to load");
				FormatDescriptions = loaded.Task.Result;
			}

			public void Enumerate (Action<CMSampleBuffer> iterator)
			{
				var cursor = videoTrack.MakeSampleCursorAtFirstSampleInDecodeOrder();
				var sampleBufferGenerator = new AVSampleBufferGenerator(asset, null);
				var request = new AVSampleBufferRequest(cursor);
				var sampleCount = 0L;

				do
				{
					using var buffer = sampleBufferGenerator.CreateSampleBuffer (request, out var sampleBufferError);
					Assert.NotNull (buffer, "Sample Buffer");
					Assert.Null (sampleBufferError, "Sample Buffer Error");

					Console.WriteLine ($"Got sample buffer: PresentationTimestamp: {buffer.PresentationTimeStamp} Duration:{buffer.Duration} TotalSampleSize:{buffer.TotalSampleSize}");

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
			using var session = CreateSession (bufferEnumerator.FormatDescription, (sourceFrame, status, flags, buffer, presentationTimeStamp, presentationDuration) => {
				Console.WriteLine ($"sourceFrame: 0x{sourceFrame:x} status: {status} flags: {flags} buffer: {buffer} presentationTimeStamp: {presentationTimeStamp} presentationDuration: {presentationDuration}");
				frameCallbackCounter++;
			});

			bufferEnumerator.Enumerate ((buffer) => {
				var status = session.DecodeFrame (buffer, VTDecodeFrameFlags.None, 0x0ee1f00d, out var infoFlags);
				Assert.That (status, Is.EqualTo (VTStatus.Ok), "DecodeFrame");
			});

			session.FinishDelayedFrames ();
			Assert.That (frameCallbackCounter, Is.GreaterThan (0), "Frame callback counter");
		}

		[Test]
		public void DecodeFrameMultiImageCallbackTest ()
		{
			TestRuntime.AssertXcodeVersion (16, 0);

			using var url = NSBundle.MainBundle.GetUrlForResource ("hummingbird", "mov");
			Assert.That (url, Is.Not.Null, "Url");

			var failures = new List<string> ();

			var bufferEnumerator = new SampleBufferEnumerator (url);

			var frameCallbackCounter = 0;
			var frameCallbackCounter2 = 0;
			using var session = CreateSession (bufferEnumerator.FormatDescription, (sourceFrame, status, flags, buffer, presentationTimeStamp, presentationDuration) => {
				Console.WriteLine ($"sourceFrame: 0x{sourceFrame:x} status: {status} flags: {flags} buffer: {buffer} presentationTimeStamp: {presentationTimeStamp} presentationDuration: {presentationDuration}");
				frameCallbackCounter++;
			});

			bufferEnumerator.Enumerate ((buffer) => {
				var status = session.DecodeFrame (buffer, VTDecodeFrameFlags.None, out var infoFlags, (
								VTStatus status,
								VTDecodeInfoFlags infoFlags,
								CVImageBuffer? imageBuffer,
								CMTaggedBufferGroup? taggedBufferGroup,
								CMTime presentationTimeStamp,
								CMTime presentationDuration) => {
								Console.WriteLine ($"status: {status} infoFlags: {infoFlags} imageBuffer: {imageBuffer} taggedBufferGroup: {taggedBufferGroup} presentationTimeStamp: {presentationTimeStamp} presentationDuration: {presentationDuration} ");
								frameCallbackCounter2++;
							});
				Assert.That (status, Is.EqualTo (VTStatus.Ok), "DecodeFrame");
			});

			session.FinishDelayedFrames ();
			Assert.That (frameCallbackCounter, Is.EqualTo (0), "Frame callback counter");
			Assert.That (frameCallbackCounter2, Is.GreaterThan (0), "Frame callback counter 2");
		}


		[Test]
		public void DecodeFrameCallbackTest ()
		{
			TestRuntime.AssertXcodeVersion (16, 0);

			using var url = NSBundle.MainBundle.GetUrlForResource ("hummingbird", "mov");
			Assert.That (url, Is.Not.Null, "Url");

			var failures = new List<string> ();

			var bufferEnumerator = new SampleBufferEnumerator (url);

			var frameCallbackCounter = 0;
			var frameCallbackCounter2 = 0;
			var frameCallbackCounter3 = 0;
			var frameCallbackCounter4 = 0;
			using var session = CreateSession (bufferEnumerator.FormatDescription, (sourceFrame, status, flags, buffer, presentationTimeStamp, presentationDuration) => {
				Console.WriteLine ($"1: sourceFrame: 0x{sourceFrame:x} status: {status} flags: {flags} buffer: {buffer} presentationTimeStamp: {presentationTimeStamp} presentationDuration: {presentationDuration}");
				frameCallbackCounter++;
			});

			var st = session.SetMultiImageCallback ((IntPtr outputMultiImageReference, IntPtr sourceFrameReference, VTStatus status, VTDecodeInfoFlags infoFlags, CMTaggedBufferGroup? taggedBufferGroup, CMTime presentationTimeStamp, CMTime presentationDuration) =>
			{
				Console.WriteLine ($"3: outputMultiImageReference: 0x{outputMultiImageReference:x} sourceFrameReference: 0x{sourceFrameReference:x} status: {status} infoFlags: {infoFlags} taggedBufferGroup: {taggedBufferGroup} presentationTimeStamp: {presentationTimeStamp} presentationDuration: {presentationDuration}");
				frameCallbackCounter3++;
			}, 0x0a1efeab);

			bufferEnumerator.Enumerate ((buffer) => {
				var status = session.DecodeFrame (buffer, VTDecodeFrameFlags.None, (NSDictionary?) null, out var infoFlags, (sourceFrame, status, flags, buffer, presentationTimeStamp, presentationDuration) => {
					Console.WriteLine ($"4: sourceFrame: 0x{sourceFrame:x} status: {status} flags: {flags} buffer: {buffer} presentationTimeStamp: {presentationTimeStamp} presentationDuration: {presentationDuration}");
					frameCallbackCounter4++;
				});
				Assert.That (status, Is.EqualTo (VTStatus.Ok), "DecodeFrame");
			});

			session.FinishDelayedFrames ();
			Assert.That (frameCallbackCounter, Is.EqualTo (0), "Frame callback counter");
			Assert.That (frameCallbackCounter2, Is.EqualTo (0), "Frame callback counter 2");
			Assert.That (frameCallbackCounter3, Is.EqualTo (0), "Frame callback counter 3");
			Assert.That (frameCallbackCounter4, Is.GreaterThan (0), "Frame callback counter 4");
		}
	}
}
