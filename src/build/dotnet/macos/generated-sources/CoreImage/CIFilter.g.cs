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
	/// <summary>CoreImage image filter.</summary><remarks><para>
	/// On iOS 7.0, the following are the built-in filters:
	/// </para><para>
	/// Compositing Filters:
	/// <list type="bullet"><item><term><see cref="T:CoreImage.CIAdditionCompositing" /></term></item><item><term><see cref="T:CoreImage.CIMaximumCompositing" /></term></item><item><term><see cref="T:CoreImage.CIMinimumCompositing" /></term></item><item><term><see cref="T:CoreImage.CIMultiplyCompositing" /></term></item><item><term><see cref="T:CoreImage.CISourceAtopCompositing" /></term></item><item><term><see cref="T:CoreImage.CISourceInCompositing" /></term></item><item><term><see cref="T:CoreImage.CISourceOutCompositing" /></term></item><item><term><see cref="T:CoreImage.CISourceOverCompositing" /></term></item></list></para><para>
	/// Affine Filters (<see cref="T:CoreImage.CIAffineFilter" />):
	/// <list type="bullet"><item><term><see cref="T:CoreImage.CIAffineClamp" /></term></item><item><term><see cref="T:CoreImage.CIAffineTile" /></term></item><item><term><see cref="T:CoreImage.CIAffineTransform" /></term></item></list></para><para>
	/// Blend Filters (<see cref="T:CoreImage.CIBlendFilter" />):
	/// <list type="bullet"><item><term><see cref="T:CoreImage.CIBlendWithMask" /></term></item><item><term><see cref="T:CoreImage.CIColorBlendMode" /></term></item><item><term><see cref="T:CoreImage.CIColorBurnBlendMode" /></term></item><item><term><see cref="T:CoreImage.CIColorDodgeBlendMode" /></term></item><item><term><see cref="T:CoreImage.CIDarkenBlendMode" /></term></item><item><term><see cref="T:CoreImage.CIDifferenceBlendMode" /></term></item><item><term><see cref="T:CoreImage.CIExclusionBlendMode" /></term></item><item><term><see cref="T:CoreImage.CIHardLightBlendMode" /></term></item><item><term><see cref="T:CoreImage.CIHueBlendMode" /></term></item><item><term><see cref="T:CoreImage.CILightenBlendMode" /></term></item><item><term><see cref="T:CoreImage.CILuminosityBlendMode" /></term></item><item><term><see cref="T:CoreImage.CIMultiplyBlendMode" /></term></item><item><term><see cref="T:CoreImage.CIOverlayBlendMode" /></term></item><item><term><see cref="T:CoreImage.CISaturationBlendMode" /></term></item><item><term><see cref="T:CoreImage.CIScreenBlendMode" /></term></item><item><term><see cref="T:CoreImage.CISoftLightBlendMode" /></term></item></list></para><para>
	/// Compositing Filters (<see cref="T:CoreImage.CICompositingFilter" />):
	/// <list type="bullet"><item><term><see cref="T:CoreImage.CIAdditionCompositing" /></term></item><item><term><see cref="T:CoreImage.CIMaximumCompositing" /></term></item><item><term><see cref="T:CoreImage.CIMinimumCompositing" /></term></item><item><term><see cref="T:CoreImage.CIMultiplyCompositing" /></term></item><item><term><see cref="T:CoreImage.CISourceAtopCompositing" /></term></item><item><term><see cref="T:CoreImage.CISourceInCompositing" /></term></item><item><term><see cref="T:CoreImage.CISourceOutCompositing" /></term></item><item><term><see cref="T:CoreImage.CISourceOverCompositing" /></term></item></list></para><para>
	/// Convolution Filters (<see cref="T:CoreImage.CIConvolutionCore" />):
	/// <list type="bullet"><item><term><see cref="T:CoreImage.CIConvolution3X3" /></term></item><item><term><see cref="T:CoreImage.CIConvolution5X5" /></term></item><item><term><see cref="T:CoreImage.CIConvolution9Horizontal" /></term></item><item><term><see cref="T:CoreImage.CIConvolution9Vertical" /></term></item></list></para><para>
	/// Distortion Filters (<see cref="T:CoreImage.CIDistortionFilter" />):
	/// <list type="bullet"><item><term><see cref="T:CoreImage.CIBumpDistortion" /></term></item><item><term><see cref="T:CoreImage.CIBumpDistortionLinear" /></term></item><item><term><see cref="T:CoreImage.CICircleSplashDistortion" /></term></item><item><term><see cref="T:CoreImage.CIHoleDistortion" /></term></item><item><term><see cref="T:CoreImage.CIPinchDistortion" /></term></item><item><term><see cref="T:CoreImage.CITwirlDistortion" /></term></item><item><term><see cref="T:CoreImage.CIVortexDistortion" /></term></item></list></para><para>
	/// Photo Effects (<see cref="T:CoreImage.CIPhotoEffect" />):
	/// <list type="bullet"><item><term><see cref="T:CoreImage.CIPhotoEffectChrome" /></term></item><item><term><see cref="T:CoreImage.CIPhotoEffectFade" /></term></item><item><term><see cref="T:CoreImage.CIPhotoEffectInstant" /></term></item><item><term><see cref="T:CoreImage.CIPhotoEffectMono" /></term></item><item><term><see cref="T:CoreImage.CIPhotoEffectNoir" /></term></item><item><term><see cref="T:CoreImage.CIPhotoEffectProcess" /></term></item><item><term><see cref="T:CoreImage.CIPhotoEffectTonal" /></term></item><item><term><see cref="T:CoreImage.CIPhotoEffectTransfer" /></term></item></list></para><para>
	/// Transition Filters (<see cref="T:CoreImage.CITransitionFilter" />):
	/// <list type="bullet"><item><term><see cref="T:CoreImage.CIBarsSwipeTransition" /></term></item><item><term><see cref="T:CoreImage.CICopyMachineTransition" /></term></item><item><term><see cref="T:CoreImage.CIDisintegrateWithMaskTransition" /></term></item><item><term><see cref="T:CoreImage.CIDissolveTransition" /></term></item><item><term><see cref="T:CoreImage.CIFlashTransition" /></term></item><item><term><see cref="T:CoreImage.CIModTransition" /></term></item><item><term><see cref="T:CoreImage.CISwipeTransition" /></term></item></list></para><para>Specialized Filters:
	/// <list type="bullet"><item><term><see cref="T:CoreImage.CIBloom" /></term></item><item><term><see cref="T:CoreImage.CICheckerboardGenerator" /></term></item><item><term><see cref="T:CoreImage.CIColorClamp" /></term></item><item><term><see cref="T:CoreImage.CIColorControls" /></term></item><item><term><see cref="T:CoreImage.CIColorCrossPolynomial" /></term></item><item><term><see cref="T:CoreImage.CIColorCube" /></term></item><item><term><see cref="T:CoreImage.CIColorInvert" /></term></item><item><term><see cref="T:CoreImage.CIColorMap" /></term></item><item><term><see cref="T:CoreImage.CIColorMatrix" /></term></item><item><term><see cref="T:CoreImage.CIColorMonochrome" /></term></item><item><term><see cref="T:CoreImage.CIColorPosterize" /></term></item><item><term><see cref="T:CoreImage.CIConstantColorGenerator" /></term></item><item><term><see cref="T:CoreImage.CICrop" /></term></item><item><term><see cref="T:CoreImage.CIExposureAdjust" /></term></item><item><term><see cref="T:CoreImage.CIFaceBalance" /></term></item><item><term><see cref="T:CoreImage.CIFalseColor" /></term></item><item><term><see cref="T:CoreImage.CIGammaAdjust" /></term></item><item><term><see cref="T:CoreImage.CIGaussianBlur" /></term></item><item><term><see cref="T:CoreImage.CIGaussianGradient" /></term></item><item><term><see cref="T:CoreImage.CIGloom" /></term></item><item><term><see cref="T:CoreImage.CIHighlightShadowAdjust" /></term></item><item><term><see cref="T:CoreImage.CIHueAdjust" /></term></item><item><term><see cref="T:CoreImage.CILanczosScaleTransform" /></term></item><item><term><see cref="T:CoreImage.CILightTunnel" /></term></item><item><term><see cref="T:CoreImage.CILinearGradient" /></term></item><item><term><see cref="T:CoreImage.CILinearToSRGBToneCurve" /></term></item><item><term><see cref="T:CoreImage.CIMaskToAlpha" /></term></item><item><term><see cref="T:CoreImage.CIMaximumComponent" /></term></item><item><term><see cref="T:CoreImage.CIMinimumComponent" /></term></item><item><term><see cref="T:CoreImage.CIPerspectiveTile" /></term></item><item><term><see cref="T:CoreImage.CIPerspectiveTransform" /></term></item><item><term><see cref="T:CoreImage.CIPixellate" /></term></item><item><term><see cref="T:CoreImage.CIQRCodeGenerator" /></term></item><item><term><see cref="T:CoreImage.CIRadialGradient" /></term></item><item><term><see cref="T:CoreImage.CIRandomGenerator" /></term></item><item><term><see cref="T:CoreImage.CIScreenFilter" /></term></item><item><term><see cref="T:CoreImage.CISepiaTone" /></term></item><item><term><see cref="T:CoreImage.CISharpenLuminance" /></term></item><item><term><see cref="T:CoreImage.CISRGBToneCurveToLinear" /></term></item><item><term><see cref="T:CoreImage.CIStarShineGenerator" /></term></item><item><term><see cref="T:CoreImage.CIStraightenFilter" /></term></item><item><term><see cref="T:CoreImage.CIStripesGenerator" /></term></item><item><term><see cref="T:CoreImage.CITemperatureAndTint" /></term></item><item><term><see cref="T:CoreImage.CITileFilter" /></term></item><item><term><see cref="T:CoreImage.CIToneCurve" /></term></item><item><term><see cref="T:CoreImage.CITriangleKaleidoscope" /></term></item><item><term><see cref="T:CoreImage.CIUnsharpMask" /></term></item><item><term><see cref="T:CoreImage.CIVibrance" /></term></item><item><term><see cref="T:CoreImage.CIVignette" /></term></item><item><term><see cref="T:CoreImage.CIVignetteEffect" /></term></item><item><term><see cref="T:CoreImage.CIWhitePointAdjust" /></term></item></list></para><para>
	/// To create a filter of the specified type, instantiate an
	/// instance of one of the above types, assign values to their
	/// properties and extract the result by using the OutputImage
	/// property.
	/// 
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// var sepiaFilter = new CISepiaTone () {
	/// Image = mySourceImage,
	/// Intensity = 0.8f
	/// };
	/// ]]></code></example><para>
	/// You can chain your filters as well:
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// var sepiaFilter = new CISepiaTone () {
	/// Image = mySourceImage,
	/// Intensity = .8f
	/// };
	/// var invert = new CIColorInvert () {
	/// Image = sepia.OutputImage
	/// };
	/// ]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/QuartzCoreFramework/Classes/CIFilter_Class/index.html">Apple documentation for <c>CIFilter</c></related>
	[Register("CIFilter", true)]
	public unsafe partial class CIFilter : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApply_Arguments_Options_X = "apply:arguments:options:";
		static readonly NativeHandle selApply_Arguments_Options_XHandle = Selector.GetHandle ("apply:arguments:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributesX = "attributes";
		static readonly NativeHandle selAttributesXHandle = Selector.GetHandle ("attributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBlurredRectangleGeneratorFilterX = "blurredRectangleGeneratorFilter";
		static readonly NativeHandle selBlurredRectangleGeneratorFilterXHandle = Selector.GetHandle ("blurredRectangleGeneratorFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCannyEdgeDetectorFilterX = "cannyEdgeDetectorFilter";
		static readonly NativeHandle selCannyEdgeDetectorFilterXHandle = Selector.GetHandle ("cannyEdgeDetectorFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterNamesInCategories_X = "filterNamesInCategories:";
		static readonly NativeHandle selFilterNamesInCategories_XHandle = Selector.GetHandle ("filterNamesInCategories:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterNamesInCategory_X = "filterNamesInCategory:";
		static readonly NativeHandle selFilterNamesInCategory_XHandle = Selector.GetHandle ("filterNamesInCategory:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterWithCVPixelBuffer_Properties_Options_X = "filterWithCVPixelBuffer:properties:options:";
		static readonly NativeHandle selFilterWithCVPixelBuffer_Properties_Options_XHandle = Selector.GetHandle ("filterWithCVPixelBuffer:properties:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterWithImageData_Options_X = "filterWithImageData:options:";
		static readonly NativeHandle selFilterWithImageData_Options_XHandle = Selector.GetHandle ("filterWithImageData:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterWithImageURL_Options_X = "filterWithImageURL:options:";
		static readonly NativeHandle selFilterWithImageURL_Options_XHandle = Selector.GetHandle ("filterWithImageURL:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterWithName_X = "filterWithName:";
		static readonly NativeHandle selFilterWithName_XHandle = Selector.GetHandle ("filterWithName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterWithName_WithInputParameters_X = "filterWithName:withInputParameters:";
		static readonly NativeHandle selFilterWithName_WithInputParameters_XHandle = Selector.GetHandle ("filterWithName:withInputParameters:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInputKeysX = "inputKeys";
		static readonly NativeHandle selInputKeysXHandle = Selector.GetHandle ("inputKeys");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedDescriptionForFilterName_X = "localizedDescriptionForFilterName:";
		static readonly NativeHandle selLocalizedDescriptionForFilterName_XHandle = Selector.GetHandle ("localizedDescriptionForFilterName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedNameForCategory_X = "localizedNameForCategory:";
		static readonly NativeHandle selLocalizedNameForCategory_XHandle = Selector.GetHandle ("localizedNameForCategory:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedNameForFilterName_X = "localizedNameForFilterName:";
		static readonly NativeHandle selLocalizedNameForFilterName_XHandle = Selector.GetHandle ("localizedNameForFilterName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedReferenceDocumentationForFilterName_X = "localizedReferenceDocumentationForFilterName:";
		static readonly NativeHandle selLocalizedReferenceDocumentationForFilterName_XHandle = Selector.GetHandle ("localizedReferenceDocumentationForFilterName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNameX = "name";
		static readonly NativeHandle selNameXHandle = Selector.GetHandle ("name");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputImageX = "outputImage";
		static readonly NativeHandle selOutputImageXHandle = Selector.GetHandle ("outputImage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputKeysX = "outputKeys";
		static readonly NativeHandle selOutputKeysXHandle = Selector.GetHandle ("outputKeys");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterFilterName_Constructor_ClassAttributes_X = "registerFilterName:constructor:classAttributes:";
		static readonly NativeHandle selRegisterFilterName_Constructor_ClassAttributes_XHandle = Selector.GetHandle ("registerFilterName:constructor:classAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRoundedRectangleStrokeGeneratorFilterX = "roundedRectangleStrokeGeneratorFilter";
		static readonly NativeHandle selRoundedRectangleStrokeGeneratorFilterXHandle = Selector.GetHandle ("roundedRectangleStrokeGeneratorFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultsX = "setDefaults";
		static readonly NativeHandle selSetDefaultsXHandle = Selector.GetHandle ("setDefaults");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetName_X = "setName:";
		static readonly NativeHandle selSetName_XHandle = Selector.GetHandle ("setName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetValue_ForKey_X = "setValue:forKey:";
		static readonly NativeHandle selSetValue_ForKey_XHandle = Selector.GetHandle ("setValue:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSobelGradientsFilterX = "sobelGradientsFilter";
		static readonly NativeHandle selSobelGradientsFilterXHandle = Selector.GetHandle ("sobelGradientsFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueForKey_X = "valueForKey:";
		static readonly NativeHandle selValueForKey_XHandle = Selector.GetHandle ("valueForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selViewForUIConfiguration_ExcludedKeys_X = "viewForUIConfiguration:excludedKeys:";
		static readonly NativeHandle selViewForUIConfiguration_ExcludedKeys_XHandle = Selector.GetHandle ("viewForUIConfiguration:excludedKeys:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CIFilter");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public CIFilter (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CIFilter (NSObjectFlag t) : base (t)
		{
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CIFilter (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="k">To be added.</param><param name="args">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("apply:arguments:options:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage? Apply (CIKernel k, NSArray? args, NSDictionary? options)
		{
			var k__handle__ = k!.GetNonNullHandle (nameof (k));
			var args__handle__ = args.GetHandle ();
			var options__handle__ = options.GetHandle ();
			CIImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selApply_Arguments_Options_XHandle, k__handle__, args__handle__, options__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selApply_Arguments_Options_XHandle, k__handle__, args__handle__, options__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (k);
			GC.KeepAlive (args);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="category">To be added.</param><summary>Returns the localized name for the specified category.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("localizedNameForCategory:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string CategoryLocalizedName (string category)
		{
			if (category is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (category));
			var nscategory = CFString.CreateNative (category);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selLocalizedNameForCategory_XHandle, nscategory), false)!;
			CFString.ReleaseNative (nscategory);
			return ret!;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		/// <param name="url">The URL from which the RAW image data can be read.</param><param name="options">The RAW processing options.</param><summary>Creates a <see cref="T:CoreImage.CIFilter" /> that applies the <paramref name="options" /> to the RAW data read from <paramref name="url" />.</summary><returns>A RAW processing filter.</returns><remarks>To be added.</remarks>
		[Export ("filterWithImageURL:options:")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIFilter CreateRawFilter (NSUrl url, NSDictionary options)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			CIFilter? ret;
			ret =  Runtime.GetNSObject<CIFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selFilterWithImageURL_Options_XHandle, url__handle__, options__handle__), false)!;
			GC.KeepAlive (url);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="url">The URL from which the RAW image data can be read.</param><param name="options">The RAW processing options.</param><summary>Creates a <see cref="T:CoreImage.CIFilter" /> that applies the <paramref name="options" /> to the RAW data read from <paramref name="url" />.</summary><returns>A RAW processing filter.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIFilter CreateRawFilter (NSUrl url, CIRawFilterOptions options)
		{
			return CreateRawFilter (url, options.GetDictionary ()!);
		}
		/// <param name="data">The RAW image data.</param><param name="options">The RAW processing options.</param><summary>Creates a <see cref="T:CoreImage.CIFilter" /> that applies the <paramref name="options" /> to the RAW data in <paramref name="data" />.</summary><returns>A RAW processing filter.</returns><remarks>To be added.</remarks>
		[Export ("filterWithImageData:options:")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIFilter CreateRawFilter (NSData data, NSDictionary options)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			CIFilter? ret;
			ret =  Runtime.GetNSObject<CIFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selFilterWithImageData_Options_XHandle, data__handle__, options__handle__), false)!;
			GC.KeepAlive (data);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="data">The RAW image data.</param><param name="options">The RAW processing options.</param><summary>Creates a <see cref="T:CoreImage.CIFilter" /> that applies the <paramref name="options" /> to the RAW data in <paramref name="data" />.</summary><returns>A RAW processing filter.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIFilter CreateRawFilter (NSData data, CIRawFilterOptions options)
		{
			return CreateRawFilter (data, options.GetDictionary ()!);
		}
		/// <param name="pixelBuffer">The <see cref="T:CoreVideo.CVPixelBuffer" /> containing RAW data.</param><param name="properties">A dictionary of image data.</param><param name="options">The set of RAW processing options to be applied to the input image(s).</param><summary>Creates a RAW processing filter for converting the data in <paramref name="pixelBuffer" /> by applying the settings in <paramref name="options" />.</summary><returns>A RAW processing filter.</returns><remarks>To be added.</remarks>
		[Export ("filterWithCVPixelBuffer:properties:options:")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIFilter CreateRawFilter (global::CoreVideo.CVPixelBuffer pixelBuffer, NSDictionary properties, NSDictionary options)
		{
			var pixelBuffer__handle__ = pixelBuffer!.GetNonNullHandle (nameof (pixelBuffer));
			var properties__handle__ = properties!.GetNonNullHandle (nameof (properties));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			CIFilter? ret;
			ret =  Runtime.GetNSObject<CIFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selFilterWithCVPixelBuffer_Properties_Options_XHandle, pixelBuffer__handle__, properties__handle__, options__handle__), false)!;
			GC.KeepAlive (pixelBuffer);
			GC.KeepAlive (properties);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="pixelBuffer">The <see cref="T:CoreVideo.CVPixelBuffer" /> containing RAW data.</param><param name="properties">A dictionary of image data.</param><param name="options">The set of RAW processing options to be applied to the input image(s).</param><summary>Creates a RAW processing filter for converting the data in <paramref name="pixelBuffer" /> by applying the settings in <paramref name="options" />.</summary><returns>A RAW processing filter.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIFilter CreateRawFilter (global::CoreVideo.CVPixelBuffer pixelBuffer, NSDictionary properties, CIRawFilterOptions options)
		{
			return CreateRawFilter (pixelBuffer, properties, options.GetDictionary ()!);
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		/// <param name="filterName">To be added.</param><summary>Gets the localized description for the specified filter name.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("localizedDescriptionForFilterName:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? FilterLocalizedDescription (string filterName)
		{
			if (filterName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filterName));
			var nsfilterName = CFString.CreateNative (filterName);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selLocalizedDescriptionForFilterName_XHandle, nsfilterName), false)!;
			CFString.ReleaseNative (nsfilterName);
			return ret!;
		}
		/// <param name="filterName">To be added.</param><summary>Gets the localized name for the specified filter name.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("localizedNameForFilterName:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? FilterLocalizedName (string filterName)
		{
			if (filterName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filterName));
			var nsfilterName = CFString.CreateNative (filterName);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selLocalizedNameForFilterName_XHandle, nsfilterName), false)!;
			CFString.ReleaseNative (nsfilterName);
			return ret!;
		}
		/// <param name="filterName">To be added.</param><summary>Gets the localized reference documentation for the specified filter name.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("localizedReferenceDocumentationForFilterName:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl? FilterLocalizedReferenceDocumentation (string filterName)
		{
			if (filterName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filterName));
			var nsfilterName = CFString.CreateNative (filterName);
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selLocalizedReferenceDocumentationForFilterName_XHandle, nsfilterName), false)!;
			CFString.ReleaseNative (nsfilterName);
			return ret!;
		}
		/// <param name="category"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Returns an array of strings that specifies the filters that the system provides for the specified <paramref name="category" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("filterNamesInCategory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] FilterNamesInCategory (string? category)
		{
			var nscategory = CFString.CreateNative (category);
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFilterNamesInCategory_XHandle, nscategory), false)!;
			CFString.ReleaseNative (nscategory);
			return ret!;
		}
		/// <param name="name">The name of the CoreImage filter to instantiate.</param><summary>Returns a CIFilter for the specific effect.</summary><returns>To be added.</returns><remarks><para>
		/// On iOS 5.0, the following are the built-in filters:
		/// <see cref="P:CoreImage.CIFilterCategory.Blur" />, <see cref="P:CoreImage.CIFilterCategory.ColorEffect" />,
		/// <see cref="T:CoreImage.CIAdditionCompositing" />,
		/// <see cref="T:CoreImage.CIAffineTransform" />,
		/// <see cref="T:CoreImage.CICheckerboardGenerator" />,
		/// <see cref="T:CoreImage.CIColorBlendMode" />,
		/// <see cref="T:CoreImage.CIColorBurnBlendMode" />,
		/// <see cref="T:CoreImage.CIColorControls" />,
		/// <see cref="T:CoreImage.CIColorCube" />,
		/// <see cref="T:CoreImage.CIColorDodgeBlendMode" />,
		/// <see cref="T:CoreImage.CIColorInvert" />,
		/// <see cref="T:CoreImage.CIColorMatrix" />,
		/// <see cref="T:CoreImage.CIColorMonochrome" />,
		/// <see cref="T:CoreImage.CIConstantColorGenerator" />,
		/// <see cref="T:CoreImage.CICrop" />,
		/// <see cref="T:CoreImage.CIDarkenBlendMode" />,
		/// <see cref="T:CoreImage.CIDifferenceBlendMode" />,
		/// <see cref="T:CoreImage.CIExclusionBlendMode" />,
		/// <see cref="T:CoreImage.CIExposureAdjust" />,
		/// <see cref="T:CoreImage.CIFalseColor" />,
		/// <see cref="T:CoreImage.CIGammaAdjust" />,
		/// <see cref="T:CoreImage.CIGaussianGradient" />,
		/// <see cref="T:CoreImage.CIHardLightBlendMode" />,
		/// <see cref="T:CoreImage.CIHighlightShadowAdjust" />,
		/// <see cref="T:CoreImage.CIHueAdjust" />,
		/// <see cref="T:CoreImage.CIHueBlendMode" />,
		/// <see cref="T:CoreImage.CILightenBlendMode" />,
		/// <see cref="T:CoreImage.CILinearGradient" />,
		/// <see cref="T:CoreImage.CILuminosityBlendMode" />,
		/// <see cref="T:CoreImage.CIMaximumCompositing" />,
		/// <see cref="T:CoreImage.CIMinimumCompositing" />,
		/// <see cref="T:CoreImage.CIMultiplyBlendMode" />,
		/// <see cref="T:CoreImage.CIMultiplyCompositing" />,
		/// <see cref="T:CoreImage.CIOverlayBlendMode" />,
		/// <see cref="T:CoreImage.CIRadialGradient" />,
		/// <see cref="T:CoreImage.CISaturationBlendMode" />,
		/// <see cref="T:CoreImage.CIScreenBlendMode" />,
		/// <see cref="T:CoreImage.CISepiaTone" />,
		/// <see cref="T:CoreImage.CISoftLightBlendMode" />,
		/// <see cref="T:CoreImage.CISourceAtopCompositing" />,
		/// <see cref="T:CoreImage.CISourceInCompositing" />,
		/// <see cref="T:CoreImage.CISourceOutCompositing" />,
		/// <see cref="T:CoreImage.CISourceOverCompositing" />,
		/// <see cref="T:CoreImage.CIStraightenFilter" />,
		/// <see cref="T:CoreImage.CIStripesGenerator" />,
		/// <see cref="T:CoreImage.CITemperatureAndTint" />,
		/// <see cref="T:CoreImage.CIToneCurve" />,
		/// <see cref="T:CoreImage.CIVibrance" />,
		/// <see cref="T:CoreImage.CIVignette" /> and <see cref="T:CoreImage.CIWhitePointAdjust" />.
		/// 
		/// </para><para>
		/// To create a filter of the specified type, instantiate an
		/// instance of one of the above types, assign values to their
		/// properties and extract the result by using the OutputImage
		/// property.
		/// 
		/// </para><example><code lang="csharp lang-csharp"><![CDATA[
		/// var sepiaFilter = new CISepiaTone () {
		/// Image = mySourceImage,
		/// Intensity = 0.8f
		/// };
		/// ]]></code></example></remarks>
		[Export ("filterWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIFilter? FromName (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			CIFilter? ret;
			ret =  Runtime.GetNSObject<CIFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFilterWithName_XHandle, nsname), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <param name="name">To be added.</param><param name="inputParameters"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Returns a <see cref="T:CoreImage.CIFilter" /> that corresponds to <paramref name="name" /> and is initialized with the parameters that are named in <paramref name="inputParameters" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("filterWithName:withInputParameters:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIFilter? GetFilter (string name, NSDictionary? inputParameters)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var inputParameters__handle__ = inputParameters.GetHandle ();
			var nsname = CFString.CreateNative (name);
			CIFilter? ret;
			ret =  Runtime.GetNSObject<CIFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selFilterWithName_WithInputParameters_XHandle, nsname, inputParameters__handle__), false)!;
			GC.KeepAlive (inputParameters);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <param name="configurationOptions">To be added.</param><param name="excludedKeys">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("viewForUIConfiguration:excludedKeys:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::ImageKit.IKFilterUIView GetFilterUIView (NSDictionary configurationOptions, NSArray? excludedKeys)
		{
			var configurationOptions__handle__ = configurationOptions!.GetNonNullHandle (nameof (configurationOptions));
			var excludedKeys__handle__ = excludedKeys.GetHandle ();
			global::ImageKit.IKFilterUIView? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::ImageKit.IKFilterUIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selViewForUIConfiguration_ExcludedKeys_XHandle, configurationOptions__handle__, excludedKeys__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::ImageKit.IKFilterUIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selViewForUIConfiguration_ExcludedKeys_XHandle, configurationOptions__handle__, excludedKeys__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (configurationOptions);
			GC.KeepAlive (excludedKeys);
			return ret!;
		}
		/// <param name="name">An identifier for the filter type.</param><param name="constructorObject">The <see cref="T:CoreImage.ICIFilterConstructor" /> factory.</param><param name="classAttributes">The filter attributes.</param><summary>Registers the filter generated by the <paramref name="constructorObject" /> factory.</summary><remarks>To be added.</remarks>
		[Export ("registerFilterName:constructor:classAttributes:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterFilterName (string name, ICIFilterConstructor constructorObject, NSDictionary<NSString, NSObject> classAttributes)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var constructorObject__handle__ = constructorObject!.GetNonNullHandle (nameof (constructorObject));
			var classAttributes__handle__ = classAttributes!.GetNonNullHandle (nameof (classAttributes));
			var nsname = CFString.CreateNative (name);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selRegisterFilterName_Constructor_ClassAttributes_XHandle, nsname, constructorObject__handle__, classAttributes__handle__);
			GC.KeepAlive (constructorObject);
			GC.KeepAlive (classAttributes);
			CFString.ReleaseNative (nsname);
		}
		/// <summary>Sets all input values to their defaults.</summary><remarks>To be added.</remarks>
		[Export ("setDefaults")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDefaults ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSetDefaultsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSetDefaultsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setValue:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void SetValueForKey (NSObject? value, nint key)
		{
			var value__handle__ = value.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selSetValue_ForKey_XHandle, value__handle__, key);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selSetValue_ForKey_XHandle, value__handle__, key);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
		}
		[Export ("valueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSObject? ValueForKey (nint key)
		{
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selValueForKey_XHandle, key), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selValueForKey_XHandle, key), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("filterNamesInCategories:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _FilterNamesInCategories (string[]? categories)
		{
			using var nsa_categories = NSArray.FromNullableStrings (categories);
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFilterNamesInCategories_XHandle, nsa_categories.GetHandle ()), false)!;
			return ret;
		}
		/// <summary>Configurable attributes of the filter.</summary><value>To be added.</value><remarks><para>
		/// Each filter has a set of attributes that control it.  You can
		/// get this list by requesting the Attributes dictionary from the
		/// filter. Each filter, in addition to having a series of
		/// configurable properties always includes its name
		/// ("CIAttributeFilterName" key), a user friendly name
		/// ("CIAttributeFilterDisplayName" key) and a list of categories
		/// that this filter belongs to ("CIAttributeFilterCategories").   
		/// 
		/// </para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary Attributes {
			[Export ("attributes")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public static CIBlurredRectangleGenerator BlurredRectangleGeneratorFilter {
			[Export ("blurredRectangleGeneratorFilter")]
			get {
				CIBlurredRectangleGenerator? ret;
				ret =  Runtime.GetNSObject<CIBlurredRectangleGenerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selBlurredRectangleGeneratorFilterXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public static CICannyEdgeDetector CannyEdgeDetectorFilter {
			[Export ("cannyEdgeDetectorFilter")]
			get {
				CICannyEdgeDetector? ret;
				ret =  Runtime.GetNSObject<CICannyEdgeDetector> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCannyEdgeDetectorFilterXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>Gets an array that contains the names of the input keys for the filter.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] InputKeys {
			[Export ("inputKeys")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInputKeysXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInputKeysXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the filter name.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Name {
			[Export ("name")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setName:")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>Gets the image that results from applying the filter.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CIImage? OutputImage {
			[Export ("outputImage")]
			get {
				CIImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutputImageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutputImageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets an array that contains the names of the output keys for the filter.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] OutputKeys {
			[Export ("outputKeys")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutputKeysXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutputKeysXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public static CIRoundedRectangleStrokeGenerator RoundedRectangleStrokeGeneratorFilter {
			[Export ("roundedRectangleStrokeGeneratorFilter")]
			get {
				CIRoundedRectangleStrokeGenerator? ret;
				ret =  Runtime.GetNSObject<CIRoundedRectangleStrokeGenerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selRoundedRectangleStrokeGeneratorFilterXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public static CISobelGradients SobelGradientsFilter {
			[Export ("sobelGradientsFilter")]
			get {
				CISobelGradients? ret;
				ret =  Runtime.GetNSObject<CISobelGradients> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSobelGradientsFilterXHandle), false)!;
				return ret!;
			}
		}
	} /* class CIFilter */
}
