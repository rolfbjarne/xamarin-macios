#if MONOMAC || __IOS__

using System;
using System.Runtime.InteropServices;

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

			using (var buffer = device.CreateBuffer (1024, MTLResourceOptions.CpuCacheModeDefault)) {
				Assert.IsNotNull (buffer, "CreateBuffer: NonNull 1");
			}

			var buffer_mem = Marshal.AllocHGlobal (1024);
			using (var buffer = device.CreateBuffer (buffer_mem, 1024, MTLResourceOptions.CpuCacheModeDefault)) {
				Assert.IsNotNull (buffer, "CreateBuffer: NonNull 2");
			}
			Marshal.FreeHGlobal (buffer_mem);

			var buffer_bytes = new byte [1024];
			using (var buffer = device.CreateBuffer (buffer_bytes, MTLResourceOptions.CpuCacheModeDefault)) {
				Assert.IsNotNull (buffer, "CreateBuffer: NonNull 3");
			}

			buffer_mem = Marshal.AllocHGlobal (1024);
			bool freed = false;
			using (var buffer = device.CreateBufferNoCopy (buffer_mem, 1024, MTLResourceOptions.CpuCacheModeDefault, (pointer, length) => { Marshal.FreeHGlobal (pointer); freed = true; })) {
				Assert.IsNotNull (buffer, "CreateBufferNoCopy: NonNull 1");
			}
			Assert.IsTrue (freed, "CreateBufferNoCopy: Freed 1");

			freed = false;
			using (var buffer = device.CreateBufferNoCopy (buffer_bytes, MTLResourceOptions.CpuCacheModeDefault, (pointer, length) => { freed = true; })) {
				Assert.IsNotNull (buffer, "CreateBufferNoCopy: NonNull 2");
			}
			Assert.IsTrue (freed, "CreateBufferNoCopy: Freed 2");

			using (var buffer = device.CreateBufferNoCopy (buffer_bytes, MTLResourceOptions.CpuCacheModeDefault)) {
				Assert.IsNotNull (buffer, "CreateBufferNoCopy: NonNull 3");
			}

			using (var descriptor = new MTLDepthStencilDescriptor ()) {
				using (var dss = device.CreateDepthStencilState (descriptor)) {
					Assert.IsNotNull (dss, "CreateDepthStencilState: NonNull 1");
				}
			}

			using (var descriptor = new MTLTextureDescriptor ()) {
				using (var texture = device.CreateTexture (descriptor)) {
					Assert.NotNull (texture, "CreateTexture: NonNull 1");
				}

				using (var surface = new IOSurface.IOSurface ()) {
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

			using (var descriptor = new MTLSamplerDescriptor ()) {
				using (var sampler = device.CreateSamplerState (descriptor)) {
					Assert.IsNotNull (sampler, "CreateSamplerState: NonNull 1");
				}
			}

			using (var library = device.CreateDefaultLibrary ()) {
				Assert.IsNotNull (library, "CreateDefaultLibrary: NonNull 1");
			}


		}
	}
}
#endif
