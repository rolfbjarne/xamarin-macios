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
namespace CoreImage {
	/// <summary>A filter that modifies the source pixels by applying a set of polynomial cross-products.</summary><remarks><para>The following example shows this filter in use</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// // Create the CIImage from a file
	/// CIImage flower = CIImage.FromCGImage (UIImage.FromFile ("flower.png").CGImage);
	/// 
	/// // Create a CIColorCrossPolynomial filter with the input image
	/// var color_cross_polynomial = new CIColorCrossPolynomial () {
	/// 	Image = flower,
	/// 	RedCoefficients = new CIVector (new float []{1, 0, 0, 0, 0, 0, 0, 0, 0, 0}),
	/// 	GreenCoefficients = new CIVector (new float []{0, 1, 0, 0, 0, 0, 0, 0, 0, 0}),
	/// 	BlueCoefficients = new CIVector (new float []{1, 0, 1, 0, -20, 0, 0, 0, 0, 0}),
	/// };
	/// 
	/// // Get the altered image from the filter
	/// var output = color_cross_polynomial.OutputImage;
	/// 
	/// // To render the results, we need to create a context, and then
	/// // use one of the context rendering APIs, in this case, we render the
	/// // result into a CoreGraphics image, which is merely a useful representation
	/// //
	/// var context = CIContext.FromOptions (null);
	/// 
	/// var cgimage = context.CreateCGImage (output, output.Extent);
	/// 
	/// // The above cgimage can be added to a screen view, for example, this
	/// // would add it to a UIImageView on the screen:
	/// myImageView.Image = UIImage.FromImage (cgimage);
	/// ]]></code></example><para>
	/// With the following image input:
	/// </para><para><img href="~/xml/CoreImage/_images/flower.png" alt="Photograph of a sunflower." /></para><para>
	/// Produces the following output:
	/// </para><para><img href="~/xml/CoreImage/_images/color_cross_polynomial.png" alt="Result of applying the filter." /></para><para>
	/// 	"Flower" © 2012 Milica Sekulic, used under a Creative Commons Attribution-ShareAlike license: https://creativecommons.org/licenses/by-sa/3.0/ 
	/// </para></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class CIColorCrossPolynomial : CIFilter, ICIColorCrossPolynomialProtocol, ICIFilterProtocol {
		/// <summary>Creates a new <see cref="CIColorCrossPolynomial" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColorCrossPolynomial () : base ("CIColorCrossPolynomial")
		{
		}
		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">A pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(ObjCRuntime.NativeHandle)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(ObjCRuntime.NativeHandle)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected internal CIColorCrossPolynomial (NativeHandle handle) : base (handle)
		{
		}
		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CIColorCrossPolynomial (NSObjectFlag t) : base (t)
		{
		}
		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public CIColorCrossPolynomial (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (coder is null)
				throw new ArgumentNullException (nameof (coder));
			NativeHandle h;
			if (IsDirectBinding) {
				h = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					h = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle);
					GC.KeepAlive (this);
				}
			}
			InitializeHandle (h, "initWithCoder:");
			GC.KeepAlive (coder);
		}
		/// <summary>Creates a new <see cref="CIColorCrossPolynomial" /> with the specified name.</summary>
		/// <param name="name">The name of the filter to create.</param>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public  CIColorCrossPolynomial (string name) : base (CreateFilter (name))
		{
		}
		// CIColorCrossPolynomialProtocol protocol members 
		/// <summary>Gets or sets an image to filter.</summary>
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage? InputImage {
			[Export ("inputImage", ArgumentSemantic.Retain)]
			get {
				return (ValueForKey ("inputImage") as CIImage)!;
			}
			[Export ("setInputImage:", ArgumentSemantic.Retain)]
			set {
				SetValue ("inputImage", value);
			}
		}
		/// <summary>A ten-element vector where the first nine values are cross product weights, and the final value in a bias.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIVector RedCoefficients {
			[Export ("redCoefficients", ArgumentSemantic.Retain)]
			get {
				return (ValueForKey ("inputRedCoefficients") as CIVector)!;
			}
			[Export ("setRedCoefficients:", ArgumentSemantic.Retain)]
			set {
				SetValue ("inputRedCoefficients", value);
			}
		}
		/// <summary>A ten-element vector where the first nine values are cross product weights, and the final value in a bias.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIVector GreenCoefficients {
			[Export ("greenCoefficients", ArgumentSemantic.Retain)]
			get {
				return (ValueForKey ("inputGreenCoefficients") as CIVector)!;
			}
			[Export ("setGreenCoefficients:", ArgumentSemantic.Retain)]
			set {
				SetValue ("inputGreenCoefficients", value);
			}
		}
		/// <summary>A ten-element vector where the first nine values are cross product weights, and the final value in a bias.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIVector BlueCoefficients {
			[Export ("blueCoefficients", ArgumentSemantic.Retain)]
			get {
				return (ValueForKey ("inputBlueCoefficients") as CIVector)!;
			}
			[Export ("setBlueCoefficients:", ArgumentSemantic.Retain)]
			set {
				SetValue ("inputBlueCoefficients", value);
			}
		}
		// CIFilterProtocol protocol members 
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage? OutputImage {
			[Export ("outputImage")]
			get {
				return (ValueForKey ("outputImage") as CIImage)!;
			}
		}
	}
}
