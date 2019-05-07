#if MONOMAC || __IOS__

using System;
using System.IO;
using System.Runtime.InteropServices;

using Foundation;

#if XAMCORE_2_0
using Metal;
#else
using MonoTouch.Metal;
#endif

using NUnit.Framework;

namespace ___MonoTouchFixtures.Metal {
	public class ____MTLDeviceTestsaaaaa {
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

		[DllImport (ObjCRuntime.Constants.libcLibrary)]
		static extern int getpagesize ();

		static IntPtr AllocHGlobalPageAligned (int pages, out int length)
		{
			length = pages * getpagesize ();
			return Marshal.AllocHGlobal (length);
		}

		[Test]
		public void MemTest1 ([Range (0, 20)] int test)
		{
			var device = MTLDevice.SystemDefault;
			IntPtr buffer_mem;
			int buffer_length;
			bool freed;
			byte [] buffer_bytes;

			switch (test) {
			case 0:
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
				break;
			case 1:
				using (var queue = device.CreateCommandQueue ()) {
					Assert.IsNotNull (queue, "Queue: NonNull 1");
				}
				break;
			case 3:
				using (var queue = device.CreateCommandQueue (10)) {
					Assert.IsNotNull (queue, "Queue: NonNull 2");
				}
				break;
			case 4:
				using (var buffer = device.CreateBuffer (1024, MTLResourceOptions.CpuCacheModeDefault)) {
					Assert.IsNotNull (buffer, "CreateBuffer: NonNull 1");
				}
				break;
			case 5:
				buffer_mem = AllocHGlobalPageAligned (1, out buffer_length);
				using (var buffer = device.CreateBuffer (buffer_mem, (nuint) buffer_length, MTLResourceOptions.CpuCacheModeDefault)) {
					Assert.IsNotNull (buffer, "CreateBuffer: NonNull 2");
				}
				Marshal.FreeHGlobal (buffer_mem);
				break;
			case 6:
				buffer_bytes = new byte [getpagesize ()];
				using (var buffer = device.CreateBuffer (buffer_bytes, MTLResourceOptions.CpuCacheModeDefault)) {
					Assert.IsNotNull (buffer, "CreateBuffer: NonNull 3");
				}

				break;
			case 7:
				buffer_mem = AllocHGlobalPageAligned (1, out buffer_length);
				freed = false;
				using (var buffer = device.CreateBufferNoCopy (buffer_mem, (nuint) buffer_length, MTLResourceOptions.CpuCacheModeDefault, (pointer, length) => { Marshal.FreeHGlobal (pointer); freed = true; })) {
					Assert.IsNotNull (buffer, "CreateBufferNoCopy: NonNull 1");
				}
				Assert.IsTrue (freed, "CreateBufferNoCopy: Freed 1");
				break;
			//case 8:
				//freed = false;
				//buffer_bytes = new byte [getpagesize ()];
				//using (var buffer = device.CreateBufferNoCopy (buffer_bytes, MTLResourceOptions.CpuCacheModeDefault, (pointer, length) => { freed = true; })) {
				//	Assert.IsNotNull (buffer, "CreateBufferNoCopy: NonNull 2");
				//}
				//Assert.IsTrue (freed, "CreateBufferNoCopy: Freed 2");
				//break;
			//case 9:
				//buffer_bytes = new byte [getpagesize ()];
				//using (var buffer = device.CreateBufferNoCopy (buffer_bytes, MTLResourceOptions.CpuCacheModeDefault)) {
				//	Assert.IsNotNull (buffer, "CreateBufferNoCopy: NonNull 3");
				//}
				//break;
			case 10:
				using (var descriptor = new MTLDepthStencilDescriptor ()) {
					using (var dss = device.CreateDepthStencilState (descriptor)) {
						Assert.IsNotNull (dss, "CreateDepthStencilState: NonNull 1");
					}
				}
				break;
			case 11:
				using (var descriptor = MTLTextureDescriptor.CreateTexture2DDescriptor (MTLPixelFormat.RGBA8Unorm, 64, 64, false)) {
					using (var texture = device.CreateTexture (descriptor)) {
						Assert.NotNull (texture, "CreateTexture: NonNull 1");
					}

					using (var surface = new IOSurface.IOSurface (new IOSurface.IOSurfaceOptions {
						Width = 64,
						Height = 64,
						BytesPerElement = 4,
					})) {
						using (var texture = device.CreateTexture (descriptor, surface, 0)) {
							Assert.NotNull (texture, "CreateTexture: NonNull 2");
						}
					}

#if __MACOS__
				using (var texture = device.CreateSharedTexture (descriptor)) {
					Assert.IsNotNull (texture, "CreateSharedTexture: NonNull 1");
				}
#endif
				}
				break;
			case 12:
				using (var descriptor = new MTLSamplerDescriptor ()) {
					using (var sampler = device.CreateSamplerState (descriptor)) {
						Assert.IsNotNull (sampler, "CreateSamplerState: NonNull 1");
					}
				}
				break;
			case 13:
				using (var library = device.CreateDefaultLibrary ()) {
					Assert.IsNotNull (library, "CreateDefaultLibrary: NonNull 1");
				}
				break;
			case 14:
				using (var library = device.CreateLibrary (Path.Combine (NSBundle.MainBundle.BundlePath, "default.metallib"), out var error)) {
					Assert.IsNotNull (library, "CreateLibrary: NonNull 1");
					Assert.IsNull (error, "CreateLibrary: NonNull error 1");
				}
				break;
			default:
				Assert.Ignore ($"Unknown test: {test}");
				break;
			}
		}
	}
}
#endif
