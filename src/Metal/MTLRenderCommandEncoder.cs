using System.ComponentModel;

#nullable enable

namespace Metal {
	/// <summary>Provides extension methods for <see cref="IMTLRenderCommandEncoder" />.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public static class IMTLRenderCommandEncoder_Extensions {
		/// <param name="This">The render command encoder.</param>
		/// <param name="viewports">The viewports.</param>
		/// <summary>Sets the viewports for the render command encoder.</summary>
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos14.5")]
		public unsafe static void SetViewports (this IMTLRenderCommandEncoder This, MTLViewport [] viewports)
		{
			fixed (void* handle = viewports)
				This.SetViewports ((IntPtr) handle, (nuint) (viewports?.Length ?? 0));
		}

		/// <param name="This">The render command encoder.</param>
		/// <param name="scissorRects">The scissor rects.</param>
		/// <summary>Sets the scissor rectangles for the render command encoder.</summary>
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos14.5")]
		public unsafe static void SetScissorRects (this IMTLRenderCommandEncoder This, MTLScissorRect [] scissorRects)
		{
			fixed (void* handle = scissorRects)
				This.SetScissorRects ((IntPtr) handle, (nuint) (scissorRects?.Length ?? 0));
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("macos")]
		public unsafe static void SetTileBuffers (this IMTLRenderCommandEncoder This, IMTLBuffer [] buffers, nuint [] offsets, NSRange range)
		{
			fixed (void* handle = offsets)
				This.SetTileBuffers (buffers, (IntPtr) handle, range);
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("macos")]
		public unsafe static void SetTileSamplerStates (this IMTLRenderCommandEncoder This, IMTLSamplerState [] samplers, float [] lodMinClamps, float [] lodMaxClamps, NSRange range)
		{
			fixed (void* minHandle = lodMinClamps) {
				fixed (void* maxHandle = lodMaxClamps) {
					This.SetTileSamplerStates (samplers, (IntPtr) minHandle, (IntPtr) maxHandle, range);
				}
			}
		}
	}
}
