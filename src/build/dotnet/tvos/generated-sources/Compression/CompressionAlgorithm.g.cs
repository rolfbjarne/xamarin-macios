//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Compression {
	/// <summary>Specifies the algorithm to use to compress or decompress the underlying stream.</summary>
	public enum CompressionAlgorithm : int {
		/// <summary>The LZ4 compression format.</summary>
		LZ4 = 256,
		/// <summary>The <see cref="F:Compression.CompressionAlgorithm.LZ4">LZ4</see> compression format, without block headers.</summary>
		LZ4Raw = 257,
		/// <summary>The Lempel–Ziv Finite State Entropy (LZFSE) compression format. This is the format Apple recommends on Apple platforms.</summary>
		Lzfse = 2049,
		/// <summary>The Lempel–Ziv–Markov (LZMA) compression format. The encoder in the Compression framework only supports level 6. The decoder supports all compression levels.</summary>
		Lzma = 774,
		/// <summary>The zlib compression format. This is the compression format most compatible with other platforms. The encoder in the Compression framework only supports level 5. The decoder supports all compression levels.</summary>
		Zlib = 517,
		/// <summary>The Brotli compression format. The encoder in the Compression framework only supports the Brotli level 2 encoder. The decoder supports all compression levels.</summary>
		Brotli = 2818,
		/// <summary>The LZBitmap compression format. This compression algorithm is only available on Apple devices.</summary>
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		LZBitmap = 1794,
	}
}
