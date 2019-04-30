#if MONOMAC || __IOS__

using System;
using Foundation;

#if XAMCORE_2_0
using Metal;
#else
using MonoTouch.Metal;
#endif

using NUnit.Framework;

namespace MonoTouchFixtures.Metal {
	public class MTLDeviceTests {
		[SetUp]
		public void Setup ()
		{
			TestRuntime.AssertXcodeVersion (9, 0);
		}

#if MONOMAC
		[Test]
		public void GetAllDevicesTest ()
		{
			NSObject refObj = new NSObject();
			var devices = MTLDevice.GetAllDevices(ref refObj, (IMTLDevice device, NSString notifyName) => { });

#if __MACOS__
			// It's possible to run on a system that does not support metal,
			// in which case we'll get an empty array of devices.
			Assert.IsNotNull (devices, "MTLDevices.GetAllDevices not null");
#else
			Assert.That (devices, Is.Not.Empty, "MTLDevice.GetAllDevices");
#endif

			Assert.DoesNotThrow (() => {
				MTLDevice.RemoveObserver (refObj);
			});
		}
#endif // MONOMAC

		[Test]
		public void SystemDefault ()
		{
			for (int i = 0; i < 2000000; i++)
				Assert.DoesNotThrow (() => { var obj = MTLDevice.SystemDefault; }, "No exception");
		}

		[Test]
		public void CreateHeap ()
		{
			var device = MTLDevice.SystemDefault;

			using (var hd = new MTLHeapDescriptor ()) {
				hd.CpuCacheMode = MTLCpuCacheMode.DefaultCache;
				hd.StorageMode = MTLStorageMode.Private;
				using (var txt = MTLTextureDescriptor.CreateTexture2DDescriptor (MTLPixelFormat.RGBA8Unorm, 40, 40, false)) {
					var sa = device.GetHeapTextureSizeAndAlign (txt);
					hd.Size = sa.Size;
					using (var heap = device.CreateHeap (hd)) {
						Assert.IsNotNull (heap, $"NonNullHeap");
					}
				}
			}

			using (var queue = device.CreateCommandQueue ()) {
				Assert.IsNotNull (queue, "Queue: NonNull 1");
			}

			using (var queue = device.CreateCommandQueue (10)) {
				Assert.IsNotNull (queue, "Queue: NonNull 2");
			}
		}
	}
}
#endif
