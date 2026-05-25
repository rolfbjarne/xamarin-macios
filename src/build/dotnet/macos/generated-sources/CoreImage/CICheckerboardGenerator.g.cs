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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreImage {
	/// <summary>The CICheckerboardGenerator CoreImage filter</summary><remarks><para>The following example shows this filter in use</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// // Create the Two Colors for the Checkerboard
	/// var c0 = CIColor.FromRgb (1, 0, 0);
	/// var c1 = CIColor.FromRgb (0, 1, 0);
	/// var checker = new CICheckerboardGenerator ()
	/// {
	/// 	Color0 = c0,
	/// 	Color1 = c1,
	/// 	Center = new CIVector (new float[] { 10 , 10 }), // Default [80 80]
	/// 	Sharpness = 1F // Default 1
	/// };
	/// 
	/// // The Generator Filters need to be cropped before they can be displayed
	/// var crop = new CICrop() 
	/// {
	/// 	Image = checker.OutputImage,
	/// 	// Create the Bounds based on the Size of the application Window. (UIWindow)
	/// 	Rectangle = new CIVector(0, 0, window.Bounds.Width, window.Bounds.Height) 
	/// };
	/// 
	/// // Get the final Generated Image
	/// var output = crop.OutputImage;
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
	/// 			]]></code></example></remarks>
	public partial class CICheckerboardGenerator : CIFilter, ICICheckerboardGeneratorProtocol, ICIFilterProtocol {
		/// <summary>Creates a new <see cref="CICheckerboardGenerator" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CICheckerboardGenerator () : base ("CICheckerboardGenerator")
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
		protected internal CICheckerboardGenerator (NativeHandle handle) : base (handle)
		{
		}
		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CICheckerboardGenerator (NSObjectFlag t) : base (t)
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
		public CICheckerboardGenerator (NSCoder coder) : base (NSObjectFlag.Empty)
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
		// CICheckerboardGeneratorProtocol protocol members 
		/// <summary>Gets or sets the center of the checkerboard pattern.</summary>
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
		/// <summary>Gets or sets first square color</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColor Color0 {
			[Export ("color0", ArgumentSemantic.Retain)]
			get {
				return (ValueForKey ("inputColor0") as CIColor)!;
			}
			[Export ("setColor0:", ArgumentSemantic.Retain)]
			set {
				SetValue ("inputColor0", value);
			}
		}
		/// <summary>Gets or sets second square color</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColor Color1 {
			[Export ("color1", ArgumentSemantic.Retain)]
			get {
				return (ValueForKey ("inputColor1") as CIColor)!;
			}
			[Export ("setColor1:", ArgumentSemantic.Retain)]
			set {
				SetValue ("inputColor1", value);
			}
		}
		/// <summary>Gets or sets the length of the sides of the squares.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Width {
			[Export ("width")]
			get {
				return GetFloat ("inputWidth");
			}
			[Export ("setWidth:")]
			set {
				SetFloat ("inputWidth", value);
			}
		}
		/// <summary>Gets or sets the sharpness of the stripe pattern. 1 is sharp. 0 is maximally blurry.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Sharpness {
			[Export ("sharpness")]
			get {
				return GetFloat ("inputSharpness");
			}
			[Export ("setSharpness:")]
			set {
				SetFloat ("inputSharpness", value);
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
