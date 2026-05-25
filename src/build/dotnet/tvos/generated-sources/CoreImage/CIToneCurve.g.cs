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
namespace CoreImage {
	/// <summary>The CIToneCurve CoreImage filter</summary><remarks><para>The following example shows this filter in use</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// // Create a CIImage from a file.
	/// CIImage flower = CIImage.FromCGImage (UIImage.FromFile ("flower.png").CGImage);
	/// 
	/// // Create the points used to create the tone curve.
	/// var point0 = new CIVector(0,0); // Default [0 0]
	/// var point1 = new CIVector(.1F, .5F); // Default [.25 .25]
	/// var point2 = new CIVector(.3F, .15F); // Default [.3 .15]
	/// var point3 = new CIVector(.6F, .6F); // Default [.75 .75]
	/// var point4 = new CIVector(1.1F, 1F); // Default [1 1]
	/// 
	/// // Construct the ToneCurve filter
	/// var toneCurve = new CIToneCurve()
	/// {
	/// 	Image = flower,
	/// 	Point0 = point0,
	/// 	Point1 = point1,
	/// 	Point2 = point2,
	/// 	Point3 = point3,
	/// 	Point4 = point4,
	/// };
	/// 
	/// // Get the adjusted image from the filter.
	/// var output = toneCurve.OutputImage;
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
	/// 		With the following source:
	/// </para><para><img href="~/xml/CoreImage/_images/flower.png" alt="Photograph of a sunflower." /></para><para>
	/// Produces the following output:
	/// </para><para><img href="~/xml/CoreImage/_images/ToneCurve.png" alt="Result of applying the filter." /></para><para>
	/// 	"Flower" © 2012 Milica Sekulic, used under a Creative Commons Attribution-ShareAlike license: https://creativecommons.org/licenses/by-sa/3.0/ 
	/// </para></remarks>
	public partial class CIToneCurve : CIFilter, ICIToneCurveProtocol, ICIFilterProtocol {
		/// <summary>Creates a new <see cref="CIToneCurve" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIToneCurve () : base ("CIToneCurve")
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
		protected internal CIToneCurve (NativeHandle handle) : base (handle)
		{
		}
		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CIToneCurve (NSObjectFlag t) : base (t)
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
		public CIToneCurve (NSCoder coder) : base (NSObjectFlag.Empty)
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
		// CIToneCurveProtocol protocol members 
		/// <summary>Gets or sets an image to filter.</summary>
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
		/// <summary>Gets or sets tthe point in the zeroth index position through which to interpolate the tone curve.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint InputPoint0 {
			[Export ("point0", ArgumentSemantic.Assign)]
			get {
				return GetPoint ("inputPoint0");
			}
			[Export ("setPoint0:", ArgumentSemantic.Assign)]
			set {
				SetValue ("inputPoint0", value);
			}
		}
		/// <summary>Gets or sets the point in the first index position through which to interpolate the tone curve.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint InputPoint1 {
			[Export ("point1", ArgumentSemantic.Assign)]
			get {
				return GetPoint ("inputPoint1");
			}
			[Export ("setPoint1:", ArgumentSemantic.Assign)]
			set {
				SetValue ("inputPoint1", value);
			}
		}
		/// <summary>Gets or sets the point in the second index position through which to interpolate the tone curve.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint InputPoint2 {
			[Export ("point2", ArgumentSemantic.Assign)]
			get {
				return GetPoint ("inputPoint2");
			}
			[Export ("setPoint2:", ArgumentSemantic.Assign)]
			set {
				SetValue ("inputPoint2", value);
			}
		}
		/// <summary>Gets or sets the point in the third index position through which to interpolate the tone curve.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint InputPoint3 {
			[Export ("point3", ArgumentSemantic.Assign)]
			get {
				return GetPoint ("inputPoint3");
			}
			[Export ("setPoint3:", ArgumentSemantic.Assign)]
			set {
				SetValue ("inputPoint3", value);
			}
		}
		/// <summary>Gets or sets the point in the fourth index position through which to interpolate the tone curve.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint InputPoint4 {
			[Export ("point4", ArgumentSemantic.Assign)]
			get {
				return GetPoint ("inputPoint4");
			}
			[Export ("setPoint4:", ArgumentSemantic.Assign)]
			set {
				SetValue ("inputPoint4", value);
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Extrapolate {
			[Export ("extrapolate")]
			get {
				return GetBool ("inputExtrapolate");
			}
			[Export ("setExtrapolate:")]
			set {
				SetBool ("inputExtrapolate", value);
			}
		}
		// CIFilterProtocol protocol members 
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage? OutputImage {
			[Export ("outputImage")]
			get {
				return (ValueForKey ("outputImage") as CIImage)!;
			}
		}
	}
}
