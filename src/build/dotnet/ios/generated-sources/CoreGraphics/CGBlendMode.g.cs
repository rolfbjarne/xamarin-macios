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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreGraphics {
	/// <summary>Blending mode used during composition.</summary><remarks><para>The blend modes are used when composing images, the operations combine the color data with an alpha channel.   The operations are called the Porter-Duff blending operations.</para><para>
	/// For a detailed explanation see the PDF reference manual.
	/// </para><para>In the explanation below, the following variables are used:</para><para><list type="table"><listheader><term>Term</term><description>Description</description></listheader><item><term>R</term><description>Premultiplied result color</description></item><item><term>S</term><description>Source Color</description></item><item><term>D</term><description>Destination Color</description></item><item><term>Sa</term><description>Source alpha value</description></item><item><term>Da</term><description>Destination alpha value</description></item></list></para></remarks>
	public enum CGBlendMode : int {
		/// <summary>To be added.</summary>
		Normal = 0,
		/// <summary>To be added.</summary>
		Multiply = 1,
		/// <summary>To be added.</summary>
		Screen = 2,
		/// <summary>To be added.</summary>
		Overlay = 3,
		/// <summary>To be added.</summary>
		Darken = 4,
		/// <summary>To be added.</summary>
		Lighten = 5,
		/// <summary>To be added.</summary>
		ColorDodge = 6,
		/// <summary>To be added.</summary>
		ColorBurn = 7,
		/// <summary>To be added.</summary>
		SoftLight = 8,
		/// <summary>To be added.</summary>
		HardLight = 9,
		/// <summary>To be added.</summary>
		Difference = 10,
		/// <summary>To be added.</summary>
		Exclusion = 11,
		/// <summary>To be added.</summary>
		Hue = 12,
		/// <summary>To be added.</summary>
		Saturation = 13,
		/// <summary>To be added.</summary>
		Color = 14,
		/// <summary>To be added.</summary>
		Luminosity = 15,
		/// <summary>Clears the destination and makes it transparent (R=0).</summary>
		Clear = 16,
		/// <summary>Copies the source color with alpha to the target (R=S)</summary>
		Copy = 17,
		/// <summary>To be added.</summary>
		SourceIn = 18,
		/// <summary>To be added.</summary>
		SourceOut = 19,
		/// <summary>To be added.</summary>
		SourceAtop = 20,
		/// <summary>To be added.</summary>
		DestinationOver = 21,
		/// <summary>To be added.</summary>
		DestinationIn = 22,
		/// <summary>To be added.</summary>
		DestinationOut = 23,
		/// <summary>To be added.</summary>
		DestinationAtop = 24,
		/// <summary>To be added.</summary>
		XOR = 25,
		/// <summary>To be added.</summary>
		PlusDarker = 26,
		/// <summary>To be added.</summary>
		PlusLighter = 27,
	}
}
