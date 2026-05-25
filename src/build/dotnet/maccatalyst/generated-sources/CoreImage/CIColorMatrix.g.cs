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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreImage {
	/// <summary>The CIColorMatrix CoreImage filter.</summary><remarks><para>The following example shows this filter in use</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// // Create a CIImage from a file
	/// CIImage flower = CIImage.FromCGImage (UIImage.FromFile ("flower.png").CGImage);
	/// 
	/// // Setup our Vectors used by the CIColorMatrix Filter
	/// var rVector = new CIVector (.5F, 0F, 0F); // Multiple the Red Values by .5 (s.r = dot(s, rVector))
	/// var gVector = new CIVector (0F, 1.5F, 0F); // Multiple the Green Vector by 1.5 (s.g = dot(s, gVector))
	/// var bVector = new CIVector (0F, 0F, .75F); // Multiple the Blue Vector by .75 (s.b = dot(s, bVector))
	/// var aVector = new CIVector (0F, 0F, 0F, 1.25F); // Multiple the Alpha values by 1.25 (s.a = dot(s, bVector))
	/// var biasVector = new CIVector (0, 1, 0, 0); // A Bias to be Added to each Color Vector (s = s + bias)
	/// 
	/// // Constructor the CIColorMatrix Filter
	/// var colorMatrix = new CIColorMatrix ()
	/// {
	/// 	Image = flower,
	/// 	RVector = rVector,
	/// 	GVector = gVector,
	/// 	BVector = bVector,
	/// 	AVector = aVector,
	/// 	BiasVector = biasVector
	/// };
	/// 
	/// var output = colorMatrix.OutputImage;
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
	/// </para><para><img href="~/xml/CoreImage/_images/ColorMatrix.png" alt="Result of applying the filter." /></para><para>
	/// 	"Flower" © 2012 Milica Sekulic, used under a Creative Commons Attribution-ShareAlike license: https://creativecommons.org/licenses/by-sa/3.0/ 
	/// 		"Sunrise near Atkeison Plateau" © 2012 Charles Atkeison, used under a Creative Commons Attribution-ShareAlike license: https://creativecommons.org/licenses/by-sa/3.0/ 
	/// 		"canon" © 2012 cuatrok77 hernandez, used under a Creative Commons Attribution-ShareAlike license: https://creativecommons.org/licenses/by-sa/3.0/ 
	/// </para></remarks>
	public partial class CIColorMatrix : CIFilter, ICIColorMatrixProtocol, ICIFilterProtocol {
		/// <summary>Creates a new <see cref="CIColorMatrix" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColorMatrix () : base ("CIColorMatrix")
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
		protected internal CIColorMatrix (NativeHandle handle) : base (handle)
		{
		}
		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CIColorMatrix (NSObjectFlag t) : base (t)
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
		public CIColorMatrix (NSCoder coder) : base (NSObjectFlag.Empty)
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
		// CIColorMatrixProtocol protocol members 
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
		/// <summary>Weights to use to calculate the red value.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIVector RVector {
			[Export ("RVector", ArgumentSemantic.Retain)]
			get {
				return (ValueForKey ("inputRVector") as CIVector)!;
			}
			[Export ("setRVector:", ArgumentSemantic.Retain)]
			set {
				SetValue ("inputRVector", value);
			}
		}
		/// <summary>Weights to use to calculate the green value.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIVector GVector {
			[Export ("GVector", ArgumentSemantic.Retain)]
			get {
				return (ValueForKey ("inputGVector") as CIVector)!;
			}
			[Export ("setGVector:", ArgumentSemantic.Retain)]
			set {
				SetValue ("inputGVector", value);
			}
		}
		/// <summary>Weights to use to calculate the blue value.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIVector BVector {
			[Export ("BVector", ArgumentSemantic.Retain)]
			get {
				return (ValueForKey ("inputBVector") as CIVector)!;
			}
			[Export ("setBVector:", ArgumentSemantic.Retain)]
			set {
				SetValue ("inputBVector", value);
			}
		}
		/// <summary>Weights to use to calculate the alpha value.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIVector AVector {
			[Export ("AVector", ArgumentSemantic.Retain)]
			get {
				return (ValueForKey ("inputAVector") as CIVector)!;
			}
			[Export ("setAVector:", ArgumentSemantic.Retain)]
			set {
				SetValue ("inputAVector", value);
			}
		}
		/// <summary>Values to add to each component.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIVector BiasVector {
			[Export ("biasVector", ArgumentSemantic.Retain)]
			get {
				return (ValueForKey ("inputBiasVector") as CIVector)!;
			}
			[Export ("setBiasVector:", ArgumentSemantic.Retain)]
			set {
				SetValue ("inputBiasVector", value);
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
