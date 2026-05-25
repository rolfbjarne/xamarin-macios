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
	/// <summary>A <see cref="T:CoreImage.CIFilter" /> that simulates lens flare.</summary><remarks><para>The following example shows this filter in use</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// // Create a CIStarShineGenerator filter with the input image
	/// var star_shine_generator = new CIStarShineGenerator () {
	/// 	Radius = 20,
	/// };
	/// 
	/// // Get the altered image from the filter
	/// var output = new CICrop {
	/// 	Image = star_shine_generator.OutputImage,
	/// 	Rectangle = new CIVector (0, 0, 400, 300)
	/// }.OutputImage;
	/// 
	/// // Give the image a black background
	/// output = new CISourceAtopCompositing {
	/// 	BackgroundImage = new CICrop {
	/// 		Image = new CIConstantColorGenerator {
	/// 			Color = new CIColor (UIColor.FromRGB (1, 1, 1)),
	/// 		}.OutputImage,
	/// 		Rectangle = new CIVector (0, 0, 400, 300),
	/// 	}.OutputImage,
	/// 	Image = output
	/// }.OutputImage;
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
	/// Produces the following output:
	/// </para><para><img href="~/xml/CoreImage/_images/star_shine_generator.png" alt="Result of applying the filter." /></para></remarks>
	public partial class CIStarShineGenerator : CIFilter, ICIStarShineGeneratorProtocol, ICIFilterProtocol {
		/// <summary>Creates a new <see cref="CIStarShineGenerator" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIStarShineGenerator () : base ("CIStarShineGenerator")
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
		protected internal CIStarShineGenerator (NativeHandle handle) : base (handle)
		{
		}
		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CIStarShineGenerator (NSObjectFlag t) : base (t)
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
		public CIStarShineGenerator (NSCoder coder) : base (NSObjectFlag.Empty)
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
		// CIStarShineGeneratorProtocol protocol members 
		/// <summary>Gets or sets the center of the star shine effect.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint InputCenter {
			[Export ("center", ArgumentSemantic.Assign)]
			get {
				return GetPoint ("inputCenter");
			}
			[Export ("setCenter:", ArgumentSemantic.Assign)]
			set {
				SetValue ("inputCenter", value);
			}
		}
		/// <summary>Gets or sets the color of the star shine filter.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColor Color {
			[Export ("color", ArgumentSemantic.Retain)]
			get {
				return (ValueForKey ("inputColor") as CIColor)!;
			}
			[Export ("setColor:", ArgumentSemantic.Retain)]
			set {
				SetValue ("inputColor", value);
			}
		}
		/// <summary>Gets or sets the radius of the entire flare.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Radius {
			[Export ("radius")]
			get {
				return GetFloat ("inputRadius");
			}
			[Export ("setRadius:")]
			set {
				SetFloat ("inputRadius", value);
			}
		}
		/// <summary>Gets or sets the ratio of the cross spike lengths to the radius of the center.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float CrossScale {
			[Export ("crossScale")]
			get {
				return GetFloat ("inputCrossScale");
			}
			[Export ("setCrossScale:")]
			set {
				SetFloat ("inputCrossScale", value);
			}
		}
		/// <summary>Gets or sets the angle that the cross of the star shine makes with the horizontal, in radians.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float CrossAngle {
			[Export ("crossAngle")]
			get {
				return GetFloat ("inputCrossAngle");
			}
			[Export ("setCrossAngle:")]
			set {
				SetFloat ("inputCrossAngle", value);
			}
		}
		/// <summary>Gets or sets a value that controls the thickness of the radial spikes of the star shine.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float CrossOpacity {
			[Export ("crossOpacity")]
			get {
				return GetFloat ("inputCrossOpacity");
			}
			[Export ("setCrossOpacity:")]
			set {
				SetFloat ("inputCrossOpacity", value);
			}
		}
		/// <summary>Gets or sets the thickness of the radial spikes of the star shine.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float CrossWidth {
			[Export ("crossWidth")]
			get {
				return GetFloat ("inputCrossWidth");
			}
			[Export ("setCrossWidth:")]
			set {
				SetFloat ("inputCrossWidth", value);
			}
		}
		/// <summary>Gets or sets the epsilon value for the star shine generator.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Epsilon {
			[Export ("epsilon")]
			get {
				return GetFloat ("inputEpsilon");
			}
			[Export ("setEpsilon:")]
			set {
				SetFloat ("inputEpsilon", value);
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
