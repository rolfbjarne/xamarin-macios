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
	/// <summary>Generates a gradient between two colors as if reflected on a sphere.</summary><remarks><para>The following example shows this filter in use</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// var center = new CIVector(100, 100); // Default [150 150]
	/// var radGradient = new CIRadialGradient()
	/// {
	/// 	Center = center,
	/// 	Radius0 = 10F, // Default 5
	/// 	Radius1 = 150F, // Default 100
	/// 	Color0 = new CIColor(new CGColor(0, 255F, 0)), // Green
	/// 	Color1 = new CIColor(new CGColor(0, 0, 0)) // Black
	/// };
	/// 
	/// // The Generator Filters need to be cropped before they can be displayed
	/// var crop = new CICrop () 
	/// { 
	/// Image = radGradient.OutputImage,
	/// // Create the Bounds based on the Size of the application Window. (UIWindow)
	/// Rectangle = new CIVector (0, 0, window.Bounds.Width, window.Bounds.Height) 
	/// };		
	/// 
	/// // Get the Gradient image from the crop filter.
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
	/// ]]></code></example><para>
	/// Produces the following output:
	/// </para><para><img href="~/xml/CoreImage/_images/RadialGradient.png" alt="Result of applying the filter." /></para></remarks>
	public partial class CIRadialGradient : CIFilter, ICIRadialGradientProtocol, ICIFilterProtocol {
		/// <summary>Creates a new <see cref="CIRadialGradient" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIRadialGradient () : base ("CIRadialGradient")
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
		protected internal CIRadialGradient (NativeHandle handle) : base (handle)
		{
		}
		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CIRadialGradient (NSObjectFlag t) : base (t)
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
		public CIRadialGradient (NSCoder coder) : base (NSObjectFlag.Empty)
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
		// CIRadialGradientProtocol protocol members 
		/// <summary>Gets or sets the center of the gradient.</summary>
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
		/// <summary>Gets or sets the first radius of the gradient.</summary><value>To be added.</value><remarks>Application developers can set either of the two radii to be the larger. Swapping radii is equivalent to swapping colors.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Radius0 {
			[Export ("radius0")]
			get {
				return GetFloat ("inputRadius0");
			}
			[Export ("setRadius0:")]
			set {
				SetFloat ("inputRadius0", value);
			}
		}
		/// <summary>Gets or sets the second radius of the gradient.</summary><value>To be added.</value><remarks>Application developers can set either of the two radii to be the larger. Swapping radii is equivalent to swapping colors.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Radius1 {
			[Export ("radius1")]
			get {
				return GetFloat ("inputRadius1");
			}
			[Export ("setRadius1:")]
			set {
				SetFloat ("inputRadius1", value);
			}
		}
		/// <summary>Gets or sets the color at the <see cref="CIRadialGradient.Radius0" /> location in the gradient.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>Gets or sets the color at the <see cref="CIRadialGradient.Radius1" /> location in the gradient.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
