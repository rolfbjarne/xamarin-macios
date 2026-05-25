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
	/// <summary>A <see cref="T:CoreImage.CITransitionFilter" /> that uses a mask to define the transition.</summary><remarks><para>The following example shows this filter in use</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// // Create the CIImage from a file
	/// CIImage clouds = CIImage.FromCGImage (UIImage.FromFile ("clouds.jpg").CGImage);
	/// CIImage flower = CIImage.FromCGImage (UIImage.FromFile ("flower.png").CGImage);
	/// CIImage xamarinCheck = CIImage.FromCGImage (UIImage.FromFile ("XamarinCheck.png").CGImage);
	/// 
	/// // Create a CIDisintegrateWithMaskTransition filter with the input image
	/// var disintegrate_with_mask_transition = new CIDisintegrateWithMaskTransition ()
	/// {
	/// 	Image = clouds, 
	/// 	TargetImage = flower,
	/// 	Mask = xamarinCheck
	/// };
	/// 
	/// // Get the altered image from the filter
	/// var output = disintegrate_with_mask_transition.OutputImage;
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
	/// With the following image inputs:
	/// </para><para><img href="~/xml/CoreImage/_images/clouds.jpg" alt="Photograph of clouds and sunbeams." /></para><para><img href="~/xml/CoreImage/_images/flower.png" alt="Photograph of a sunflower." /></para><para><img href="~/xml/CoreImage/_images/XamarinCheck.png" alt="Logo on a checkered background" /></para><para>
	/// Produces the following output:
	/// </para><para><img href="~/xml/CoreImage/_images/disintegrate_with_mask_transition.png" alt="Result of applying the filter." /></para><para>
	/// 	"Sunrise near Atkeison Plateau" © 2012 Charles Atkeison, used under a Creative Commons Attribution-ShareAlike license: https://creativecommons.org/licenses/by-sa/3.0/
	/// </para><para>
	/// 	"Flower" © 2012 Milica Sekulic, used under a Creative Commons Attribution-ShareAlike license: https://creativecommons.org/licenses/by-sa/3.0/ 
	/// </para></remarks>
	public partial class CIDisintegrateWithMaskTransition : CITransitionFilter, ICIDisintegrateWithMaskTransitionProtocol, ICIFilterProtocol {
		/// <summary>Creates a new <see cref="CIDisintegrateWithMaskTransition" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIDisintegrateWithMaskTransition () : base ("CIDisintegrateWithMaskTransition")
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
		protected internal CIDisintegrateWithMaskTransition (NativeHandle handle) : base (handle)
		{
		}
		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CIDisintegrateWithMaskTransition (NSObjectFlag t) : base (t)
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
		public CIDisintegrateWithMaskTransition (NSCoder coder) : base (NSObjectFlag.Empty)
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
		// CIDisintegrateWithMaskTransitionProtocol protocol members 
		/// <summary>Gets or sets the mask to use for the transition.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage? MaskImage {
			[Export ("maskImage", ArgumentSemantic.Retain)]
			get {
				return (ValueForKey ("inputMaskImage") as CIImage)!;
			}
			[Export ("setMaskImage:", ArgumentSemantic.Retain)]
			set {
				SetValue ("inputMaskImage", value);
			}
		}
		/// <summary>Gets or set the shadow radius.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float ShadowRadius {
			[Export ("shadowRadius")]
			get {
				return GetFloat ("inputShadowRadius");
			}
			[Export ("setShadowRadius:")]
			set {
				SetFloat ("inputShadowRadius", value);
			}
		}
		/// <summary>Gets or sets the density of the mask shadows.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float ShadowDensity {
			[Export ("shadowDensity")]
			get {
				return GetFloat ("inputShadowDensity");
			}
			[Export ("setShadowDensity:")]
			set {
				SetFloat ("inputShadowDensity", value);
			}
		}
		/// <summary>Gets or sets the offset of the mask shadows.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint InputShadowOffset {
			[Export ("shadowOffset", ArgumentSemantic.Assign)]
			get {
				return GetPoint ("inputShadowOffset");
			}
			[Export ("setShadowOffset:", ArgumentSemantic.Assign)]
			set {
				SetValue ("inputShadowOffset", value);
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
