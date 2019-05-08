#if MONOMAC || __IOS__

using System;
using System.IO;
using System.Runtime.InteropServices;

using CoreFoundation;
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
		public void MemTest1 ([Range (0, 40)] int test)
		{
			var device = MTLDevice.SystemDefault;
			IntPtr buffer_mem;
			int buffer_length;
			bool freed;
			byte [] buffer_bytes;

			const string metal_code = @"#include <metal_stdlib>
#include <simd/simd.h>

using namespace metal;

typedef struct
{
    float4 anArray [[position]];
    float4 aValue;

} SomeData;

fragment float4 fragmentShader(SomeData in [[stage_in]])
{
    return in.aValue;
}
";
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

#if __MACOS__
			case 2:
				using (var descriptor = MTLTextureDescriptor.CreateTexture2DDescriptor (MTLPixelFormat.RGBA8Unorm, 64, 64, false)) {
					using (var texture = device.CreateSharedTexture (descriptor)) {
						Assert.IsNotNull (texture, "CreateSharedTexture (MTLTextureDescriptor): NonNull");
					}
				}
				using (var descriptor = new MTLSharedTextureHandle ()) {
					using (var texture = device.CreateSharedTexture (descriptor)) {
						Assert.IsNotNull (texture, "CreateSharedTexture (MTLSharedTextureHandle): NonNull");
					}
				}
				break;
#endif
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
			case 15:
				using (var data = DispatchData.FromByteBuffer (File.ReadAllBytes (Path.Combine (NSBundle.MainBundle.BundlePath, "default.metallib")))) {
					using (var library = device.CreateLibrary (data, out var error)) {
						Assert.IsNotNull (library, "CreateLibrary: NonNull 2");
						Assert.IsNull (error, "CreateLibrary: NonNull error 2");
					}
				}
				break;
			case 16:
				using (var compile_options = new MTLCompileOptions ()) {
					using (var library = device.CreateLibrary (metal_code, compile_options, out var error)) {
						Assert.IsNotNull (library, "CreateLibrary: NonNull 3");
						Assert.IsNull (error, "CreateLibrary: NonNull error 3");
					}
				}
				break;
			case 17:
				using (var compile_options = new MTLCompileOptions ()) {
					device.CreateLibrary (metal_code, compile_options, (library, error) => {
						Assert.IsNotNull (library, "CreateLibrary: NonNull 4");
						Assert.IsNull (error, "CreateLibrary: NonNull error 4");
					});
				}
				break;
			case 18:
				using (var library = device.CreateDefaultLibrary (NSBundle.MainBundle, out var error)) {
					Assert.IsNotNull (library, "CreateDefaultLibrary: NonNull 2");
					Assert.IsNull (error, "CreateDefaultLibrary: NonNull error 2");
				}
				break;
			case 19:
				using (var descriptor = new MTLRenderPipelineDescriptor ()) {
					using (var rps = device.CreateRenderPipelineState (descriptor, out var error)) {
						Assert.IsNotNull (rps, "CreateRenderPipelineState: NonNull 1");
						Assert.IsNull (error, "CreateRenderPipelineState: NonNull error 1");
					}
				}
				break;
			case 20:
				using (var descriptor = new MTLRenderPipelineDescriptor ()) {
					using (var rps = device.CreateRenderPipelineState (descriptor, MTLPipelineOption.None, out var reflection, out var error)) {
						Assert.IsNotNull (rps, "CreateRenderPipelineState: NonNull 2");
						Assert.IsNull (error, "CreateRenderPipelineState: NonNull error 2");
						Assert.IsNotNull (reflection, "CreateRenderPipelineState: NonNull reflection 2");
					}
				}
				break;
			case 21:
				using (var library = device.CreateDefaultLibrary ()) {
					using (var func = library.CreateFunction ("CreateComputePipelineState1")) {
						using (var rps = device.CreateComputePipelineState (func, MTLPipelineOption.None, out var reflection, out var error)) {
							Assert.IsNotNull (rps, "CreateComputePipelineState: NonNull 1");
							Assert.IsNull (error, "CreateComputePipelineState: NonNull error 1");
							Assert.IsNotNull (reflection, "CreateComputePipelineState: NonNull reflection 1");
						}
					}
				}
				break;
			case 21:
				using (var library = device.CreateDefaultLibrary ()) {
					using (var func = library.CreateFunction ("CreateComputePipelineState2")) {
						using (var rps = device.CreateComputePipelineState (func, out var error)) {
							Assert.IsNotNull (rps, "CreateComputePipelineState: NonNull 2");
							Assert.IsNull (error, "CreateComputePipelineState: NonNull error 2");
							Assert.IsNotNull (reflection, "CreateComputePipelineState: NonNull reflection 2");
						}
					}
				}
				break;
			case 21:
				using (var func = new MTLComputePipelineDescriptor ()) {
					using (var rps = device.CreateComputePipelineState (func, out var error)) {
						Assert.IsNotNull (rps, "CreateComputePipelineState: NonNull 3");
						Assert.IsNull (error, "CreateComputePipelineState: NonNull error 3");
						Assert.IsNotNull (reflection, "CreateComputePipelineState: NonNull reflection 3");
					}
				}
				break;
			case 22:
				using (var fence = device.CreateFence ()) {
					Assert.IsNotNull (fence, "CreateFence 1: NonNull");
				}
				break;
			case 23:
				using (var library = device.CreateLibrary (new NSUrl ("file://" + Path.Combine (NSBundle.MainBundle.BundlePath, "default.metallib")), out var error)) {
					Assert.IsNotNull (library, "CreateLibrary (NSUrl, NSError): NonNull");
					Assert.IsNull (error, "CreateLibrary (NSUrl, NSError): NonNull error");
				}
				break;
			case 24:
				using (var library = device.CreateArgumentEncoder (new MTLArgumentDescriptor [] { })) {
					Assert.IsNotNull (library, "CreateArgumentEncoder (MTLArgumentDescriptor[]): NonNull");
				}
				break;
			case 25:
				using (var descriptor = new MTLIndirectCommandBufferDescriptor ()) {
					using (var library = device.CreateIndirectCommandBuffer (descriptor, 1, MTLResourceOptions.CpuCacheModeDefault)) {
						Assert.IsNotNull (library, "CreateIndirectCommandBuffer: NonNull");
					}
				}
				break;
			case 26:
				using (var evt = device.CreateEvent ()) {
					Assert.IsNotNull (evt, "CreateEvent: NonNull");
				}
				break;
			case 26:
				using (var evt = device.CreateSharedEvent ()) {
					Assert.IsNotNull (evt, "CreateSharedEvent: NonNull");
				}
				break;
			case 26:
				using (var evt_handle = new MTLSharedEventHandle ()) {
					using (var evt = device.CreateSharedEvent (evt_handle)) {
						Assert.IsNotNull (evt, "CreateSharedEvent (MTLSharedEventHandle): NonNull");
					}
				}
				break;
			case 27:
				using (var descriptor = new MTLTileRenderPipelineDescriptor ()) {
					using (var rps = device.CreateRenderPipelineState (descriptor, MTLPipelineOption.None, out var reflection, out var error)) {
						Assert.IsNotNull (rps, "CreateRenderPipelineState (MTLTileRenderPipelineDescriptor, MTLPipelineOption, MTLRenderPipelineReflection, NSError): NonNull");
						Assert.IsNull (error, "CreateRenderPipelineState (MTLTileRenderPipelineDescriptor, MTLPipelineOption, MTLRenderPipelineReflection, NSError: NonNull error");
						Assert.IsNotNull (reflection, "CreateRenderPipelineState (MTLTileRenderPipelineDescriptor, MTLPipelineOption, MTLRenderPipelineReflection, NSError): NonNull reflection");
					}
				}
				break;
			case 28:
				using (var buffer = device.CreateBuffer (1024, MTLResourceOptions.CpuCacheModeDefault)) {
					using (var texture = new MTLTextureDescriptor ()) {
						using (var texture = buffer.CreateTexture (descriptor, 0, 64)) {
							Assert.IsNotNull (buffer, "MTLBuffer.CreateTexture (MTLTextureDescriptor, nuint, nuint): NonNull");
						}
					}
				}
				break;
			case 29:
				using (var descriptor = MTLTextureDescriptor.CreateTexture2DDescriptor (MTLPixelFormat.RGBA8Unorm, 64, 64, false)) {
					using (var texture = device.CreateTexture (descriptor)) {
						using (var view = texture.CreateTextureView (MTLPixelFormat.RGBA8Unorm)) {
							Assert.IsNotNull (view, "MTLTexture.CreateTextureView (MTLPixelFormat): nonnull");
						}
						using (var view = texture.CreateTextureView (MTLPixelFormat.RGBA8Unorm, MTLTextureType.kTextureBuffer, new NSRange (0, 1), new NSRange (0, 1))) {
							Assert.IsNotNull (view, "MTLTexture.CreateTextureView (MTLPixelFormat, MTLTextureType, NSRange, NSRange): nonnull");
						}
#if __MACOS__
						using (var sth = texture.CreateSharedTextureHandle ()) {
							Assert.IsNotNull (view, "MTLTexture.CreateSharedTextureHandle (): nonnull");
						}
#endif
					}
				}
				break;
			case 30:
				using (var library = device.CreateDefaultLibrary ()) {
					using (var func = library.CreateFunction ("MTLFunction.CreateArgumentEncoder")) {
						using (var enc = func.CreateArgumentEncoder (0)) {
							Assert.IsNotNull (enc, "MTLFunction.CreateArgumentEncoder (nuint): NonNull");
						}
						using (var enc = func.CreateArgumentEncoder (0, out var reflection)) {
							Assert.IsNotNull (enc, "MTLFunction.CreateArgumentEncoder (nuint, MTLArgument): NonNull");
							Assert.IsNotNull (reflection, "MTLFunction.CreateArgumentEncoder (nuint, MTLArgument): NonNull reflection");
						}
					}
				}
				break;
			case 31:
				using (var library = device.CreateDefaultLibrary ()) {
					using (var func = library.CreateFunction ("MTLLibrary.CreateFunction1")) {
						Assert.IsNotNull (func, "CreateFunction (string): nonnull");
					}
					using (var constants = new MTLFunctionConstantValues ()) {
						using (var func = library.CreateFunction ("MTLLibrary.CreateFunction2", constants, out var error)) {
							Assert.IsNotNull (func, "CreateFunction (string, MTLFunctionConstantValues, NSError): nonnull");
							Assert.IsNotNull (error, "CreateFunction (string, MTLFunctionConstantValues, NSError): nonnull error");
						}
					}
				}
				break;
			case 32:
				using (var hd = new MTLHeapDescriptor ()) {
					hd.CpuCacheMode = MTLCpuCacheMode.DefaultCache;
					hd.StorageMode = MTLStorageMode.Private;
					using (var txt = MTLTextureDescriptor.CreateTexture2DDescriptor (MTLPixelFormat.RGBA8Unorm, 40, 40, false)) {
						var sa = device.GetHeapTextureSizeAndAlign (txt);
						hd.Size = sa.Size;
						using (var heap = device.CreateHeap (hd)) {
							using (var buffer = heap.CreateBuffer (0, MTLResourceOptions.CpuCacheModeDefault)) {
								Assert.IsNotNull (buffer, "MTLHeap.CreateBuffer (nuint, MTLResourceOptions): nonnull");
							}
							using (var texture = heap.CreateTexture (txt)) {
								Assert.IsNotNull (texture, "MTLHeap.CreateTexture (MTLTextureDescriptor): nonnull");
							}
						}
					}
				}
				break;
			case 33:
				using (var scope = MTLCaptureManager.Shared.CreateNewCaptureScope (device)) {
					Assert.IsNotNull (scope, "MTLCaptureManager.CreateNewCaptureScope (MTLDevice): nonnull");
				}
				break;
			case 34:
				using (var queue = device.CreateCommandQueue ()) {
					using (var scope = MTLCaptureManager.Shared.CreateNewCaptureScope (queue)) {
						Assert.IsNotNull (scope, "MTLCaptureManager.CreateNewCaptureScope (MTLCommandQueue): nonnull");
					}
				}
				break;
			case 35:
				using (var encoder = device.CreateArgumentEncoder ()) {
					using (var nested = encoder.CreateArgumentEncoder (0)) {
						Assert.IsNotNull (scope, "MTLArgumentEncoder.CreateArgumentEncoder (nuint): nonnull");

					}
				}
				break;
			case 36:
				using (var evt = device.CreateSharedEvent ()) {
					using (var shared = evt.CreateSharedEventHandle ()) {
						Assert.IsNotNull (library, "MTLSharedEvent.CreateSharedEvent: NonNull");
					}
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
