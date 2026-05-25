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
	[Register("CIRAWFilter", true)]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class CIRawFilter : CIFilter, ICIFilterProtocol {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBaselineExposureX = "baselineExposure";
		static readonly NativeHandle selBaselineExposureXHandle = Selector.GetHandle ("baselineExposure");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoostAmountX = "boostAmount";
		static readonly NativeHandle selBoostAmountXHandle = Selector.GetHandle ("boostAmount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoostShadowAmountX = "boostShadowAmount";
		static readonly NativeHandle selBoostShadowAmountXHandle = Selector.GetHandle ("boostShadowAmount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorNoiseReductionAmountX = "colorNoiseReductionAmount";
		static readonly NativeHandle selColorNoiseReductionAmountXHandle = Selector.GetHandle ("colorNoiseReductionAmount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContrastAmountX = "contrastAmount";
		static readonly NativeHandle selContrastAmountXHandle = Selector.GetHandle ("contrastAmount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomAttributesX = "customAttributes";
		static readonly NativeHandle selCustomAttributesXHandle = Selector.GetHandle ("customAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecoderVersionX = "decoderVersion";
		static readonly NativeHandle selDecoderVersionXHandle = Selector.GetHandle ("decoderVersion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDetailAmountX = "detailAmount";
		static readonly NativeHandle selDetailAmountXHandle = Selector.GetHandle ("detailAmount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExposureX = "exposure";
		static readonly NativeHandle selExposureXHandle = Selector.GetHandle ("exposure");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtendedDynamicRangeAmountX = "extendedDynamicRangeAmount";
		static readonly NativeHandle selExtendedDynamicRangeAmountXHandle = Selector.GetHandle ("extendedDynamicRangeAmount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterWithCVPixelBuffer_Properties_X = "filterWithCVPixelBuffer:properties:";
		static readonly NativeHandle selFilterWithCVPixelBuffer_Properties_XHandle = Selector.GetHandle ("filterWithCVPixelBuffer:properties:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterWithImageData_IdentifierHint_X = "filterWithImageData:identifierHint:";
		static readonly NativeHandle selFilterWithImageData_IdentifierHint_XHandle = Selector.GetHandle ("filterWithImageData:identifierHint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterWithImageURL_X = "filterWithImageURL:";
		static readonly NativeHandle selFilterWithImageURL_XHandle = Selector.GetHandle ("filterWithImageURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsColorNoiseReductionSupportedX = "isColorNoiseReductionSupported";
		static readonly NativeHandle selIsColorNoiseReductionSupportedXHandle = Selector.GetHandle ("isColorNoiseReductionSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsContrastSupportedX = "isContrastSupported";
		static readonly NativeHandle selIsContrastSupportedXHandle = Selector.GetHandle ("isContrastSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDetailSupportedX = "isDetailSupported";
		static readonly NativeHandle selIsDetailSupportedXHandle = Selector.GetHandle ("isDetailSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDraftModeEnabledX = "isDraftModeEnabled";
		static readonly NativeHandle selIsDraftModeEnabledXHandle = Selector.GetHandle ("isDraftModeEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsGamutMappingEnabledX = "isGamutMappingEnabled";
		static readonly NativeHandle selIsGamutMappingEnabledXHandle = Selector.GetHandle ("isGamutMappingEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsHighlightRecoveryEnabledX = "isHighlightRecoveryEnabled";
		static readonly NativeHandle selIsHighlightRecoveryEnabledXHandle = Selector.GetHandle ("isHighlightRecoveryEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsHighlightRecoverySupportedX = "isHighlightRecoverySupported";
		static readonly NativeHandle selIsHighlightRecoverySupportedXHandle = Selector.GetHandle ("isHighlightRecoverySupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsLensCorrectionEnabledX = "isLensCorrectionEnabled";
		static readonly NativeHandle selIsLensCorrectionEnabledXHandle = Selector.GetHandle ("isLensCorrectionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsLensCorrectionSupportedX = "isLensCorrectionSupported";
		static readonly NativeHandle selIsLensCorrectionSupportedXHandle = Selector.GetHandle ("isLensCorrectionSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsLocalToneMapSupportedX = "isLocalToneMapSupported";
		static readonly NativeHandle selIsLocalToneMapSupportedXHandle = Selector.GetHandle ("isLocalToneMapSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsLuminanceNoiseReductionSupportedX = "isLuminanceNoiseReductionSupported";
		static readonly NativeHandle selIsLuminanceNoiseReductionSupportedXHandle = Selector.GetHandle ("isLuminanceNoiseReductionSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsMoireReductionSupportedX = "isMoireReductionSupported";
		static readonly NativeHandle selIsMoireReductionSupportedXHandle = Selector.GetHandle ("isMoireReductionSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSharpnessSupportedX = "isSharpnessSupported";
		static readonly NativeHandle selIsSharpnessSupportedXHandle = Selector.GetHandle ("isSharpnessSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLinearSpaceFilterX = "linearSpaceFilter";
		static readonly NativeHandle selLinearSpaceFilterXHandle = Selector.GetHandle ("linearSpaceFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalToneMapAmountX = "localToneMapAmount";
		static readonly NativeHandle selLocalToneMapAmountXHandle = Selector.GetHandle ("localToneMapAmount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLuminanceNoiseReductionAmountX = "luminanceNoiseReductionAmount";
		static readonly NativeHandle selLuminanceNoiseReductionAmountXHandle = Selector.GetHandle ("luminanceNoiseReductionAmount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoireReductionAmountX = "moireReductionAmount";
		static readonly NativeHandle selMoireReductionAmountXHandle = Selector.GetHandle ("moireReductionAmount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNativeSizeX = "nativeSize";
		static readonly NativeHandle selNativeSizeXHandle = Selector.GetHandle ("nativeSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNeutralChromaticityX = "neutralChromaticity";
		static readonly NativeHandle selNeutralChromaticityXHandle = Selector.GetHandle ("neutralChromaticity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNeutralLocationX = "neutralLocation";
		static readonly NativeHandle selNeutralLocationXHandle = Selector.GetHandle ("neutralLocation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNeutralTemperatureX = "neutralTemperature";
		static readonly NativeHandle selNeutralTemperatureXHandle = Selector.GetHandle ("neutralTemperature");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNeutralTintX = "neutralTint";
		static readonly NativeHandle selNeutralTintXHandle = Selector.GetHandle ("neutralTint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrientationX = "orientation";
		static readonly NativeHandle selOrientationXHandle = Selector.GetHandle ("orientation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputImageX = "outputImage";
		static readonly NativeHandle selOutputImageXHandle = Selector.GetHandle ("outputImage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPortraitEffectsMatteX = "portraitEffectsMatte";
		static readonly NativeHandle selPortraitEffectsMatteXHandle = Selector.GetHandle ("portraitEffectsMatte");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreviewImageX = "previewImage";
		static readonly NativeHandle selPreviewImageXHandle = Selector.GetHandle ("previewImage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPropertiesX = "properties";
		static readonly NativeHandle selPropertiesXHandle = Selector.GetHandle ("properties");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleFactorX = "scaleFactor";
		static readonly NativeHandle selScaleFactorXHandle = Selector.GetHandle ("scaleFactor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSemanticSegmentationGlassesMatteX = "semanticSegmentationGlassesMatte";
		static readonly NativeHandle selSemanticSegmentationGlassesMatteXHandle = Selector.GetHandle ("semanticSegmentationGlassesMatte");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSemanticSegmentationHairMatteX = "semanticSegmentationHairMatte";
		static readonly NativeHandle selSemanticSegmentationHairMatteXHandle = Selector.GetHandle ("semanticSegmentationHairMatte");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSemanticSegmentationSkinMatteX = "semanticSegmentationSkinMatte";
		static readonly NativeHandle selSemanticSegmentationSkinMatteXHandle = Selector.GetHandle ("semanticSegmentationSkinMatte");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSemanticSegmentationSkyMatteX = "semanticSegmentationSkyMatte";
		static readonly NativeHandle selSemanticSegmentationSkyMatteXHandle = Selector.GetHandle ("semanticSegmentationSkyMatte");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSemanticSegmentationTeethMatteX = "semanticSegmentationTeethMatte";
		static readonly NativeHandle selSemanticSegmentationTeethMatteXHandle = Selector.GetHandle ("semanticSegmentationTeethMatte");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBaselineExposure_X = "setBaselineExposure:";
		static readonly NativeHandle selSetBaselineExposure_XHandle = Selector.GetHandle ("setBaselineExposure:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBoostAmount_X = "setBoostAmount:";
		static readonly NativeHandle selSetBoostAmount_XHandle = Selector.GetHandle ("setBoostAmount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBoostShadowAmount_X = "setBoostShadowAmount:";
		static readonly NativeHandle selSetBoostShadowAmount_XHandle = Selector.GetHandle ("setBoostShadowAmount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetColorNoiseReductionAmount_X = "setColorNoiseReductionAmount:";
		static readonly NativeHandle selSetColorNoiseReductionAmount_XHandle = Selector.GetHandle ("setColorNoiseReductionAmount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContrastAmount_X = "setContrastAmount:";
		static readonly NativeHandle selSetContrastAmount_XHandle = Selector.GetHandle ("setContrastAmount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDecoderVersion_X = "setDecoderVersion:";
		static readonly NativeHandle selSetDecoderVersion_XHandle = Selector.GetHandle ("setDecoderVersion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDetailAmount_X = "setDetailAmount:";
		static readonly NativeHandle selSetDetailAmount_XHandle = Selector.GetHandle ("setDetailAmount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDraftModeEnabled_X = "setDraftModeEnabled:";
		static readonly NativeHandle selSetDraftModeEnabled_XHandle = Selector.GetHandle ("setDraftModeEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetExposure_X = "setExposure:";
		static readonly NativeHandle selSetExposure_XHandle = Selector.GetHandle ("setExposure:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetExtendedDynamicRangeAmount_X = "setExtendedDynamicRangeAmount:";
		static readonly NativeHandle selSetExtendedDynamicRangeAmount_XHandle = Selector.GetHandle ("setExtendedDynamicRangeAmount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGamutMappingEnabled_X = "setGamutMappingEnabled:";
		static readonly NativeHandle selSetGamutMappingEnabled_XHandle = Selector.GetHandle ("setGamutMappingEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHighlightRecoveryEnabled_X = "setHighlightRecoveryEnabled:";
		static readonly NativeHandle selSetHighlightRecoveryEnabled_XHandle = Selector.GetHandle ("setHighlightRecoveryEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLensCorrectionEnabled_X = "setLensCorrectionEnabled:";
		static readonly NativeHandle selSetLensCorrectionEnabled_XHandle = Selector.GetHandle ("setLensCorrectionEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLinearSpaceFilter_X = "setLinearSpaceFilter:";
		static readonly NativeHandle selSetLinearSpaceFilter_XHandle = Selector.GetHandle ("setLinearSpaceFilter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLocalToneMapAmount_X = "setLocalToneMapAmount:";
		static readonly NativeHandle selSetLocalToneMapAmount_XHandle = Selector.GetHandle ("setLocalToneMapAmount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLuminanceNoiseReductionAmount_X = "setLuminanceNoiseReductionAmount:";
		static readonly NativeHandle selSetLuminanceNoiseReductionAmount_XHandle = Selector.GetHandle ("setLuminanceNoiseReductionAmount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMoireReductionAmount_X = "setMoireReductionAmount:";
		static readonly NativeHandle selSetMoireReductionAmount_XHandle = Selector.GetHandle ("setMoireReductionAmount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNeutralChromaticity_X = "setNeutralChromaticity:";
		static readonly NativeHandle selSetNeutralChromaticity_XHandle = Selector.GetHandle ("setNeutralChromaticity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNeutralLocation_X = "setNeutralLocation:";
		static readonly NativeHandle selSetNeutralLocation_XHandle = Selector.GetHandle ("setNeutralLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNeutralTemperature_X = "setNeutralTemperature:";
		static readonly NativeHandle selSetNeutralTemperature_XHandle = Selector.GetHandle ("setNeutralTemperature:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNeutralTint_X = "setNeutralTint:";
		static readonly NativeHandle selSetNeutralTint_XHandle = Selector.GetHandle ("setNeutralTint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOrientation_X = "setOrientation:";
		static readonly NativeHandle selSetOrientation_XHandle = Selector.GetHandle ("setOrientation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetScaleFactor_X = "setScaleFactor:";
		static readonly NativeHandle selSetScaleFactor_XHandle = Selector.GetHandle ("setScaleFactor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShadowBias_X = "setShadowBias:";
		static readonly NativeHandle selSetShadowBias_XHandle = Selector.GetHandle ("setShadowBias:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSharpnessAmount_X = "setSharpnessAmount:";
		static readonly NativeHandle selSetSharpnessAmount_XHandle = Selector.GetHandle ("setSharpnessAmount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShadowBiasX = "shadowBias";
		static readonly NativeHandle selShadowBiasXHandle = Selector.GetHandle ("shadowBias");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharpnessAmountX = "sharpnessAmount";
		static readonly NativeHandle selSharpnessAmountXHandle = Selector.GetHandle ("sharpnessAmount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedCameraModelsX = "supportedCameraModels";
		static readonly NativeHandle selSupportedCameraModelsXHandle = Selector.GetHandle ("supportedCameraModels");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedDecoderVersionsX = "supportedDecoderVersions";
		static readonly NativeHandle selSupportedDecoderVersionsXHandle = Selector.GetHandle ("supportedDecoderVersions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CIRAWFilter");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CIRawFilter" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CIRawFilter () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
			}
		}

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
		public CIRawFilter (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected CIRawFilter (NSObjectFlag t) : base (t)
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
		protected internal CIRawFilter (NativeHandle handle) : base (handle)
		{
		}

		[Export ("filterWithImageURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIRawFilter? Create (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			CIRawFilter? ret;
			ret =  Runtime.GetNSObject<CIRawFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFilterWithImageURL_XHandle, url__handle__), false)!;
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("filterWithImageData:identifierHint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIRawFilter? Create (NSData data, string? identifierHint)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var nsidentifierHint = CFString.CreateNative (identifierHint);
			CIRawFilter? ret;
			ret =  Runtime.GetNSObject<CIRawFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selFilterWithImageData_IdentifierHint_XHandle, data__handle__, nsidentifierHint), false)!;
			GC.KeepAlive (data);
			CFString.ReleaseNative (nsidentifierHint);
			return ret!;
		}
		[Export ("filterWithCVPixelBuffer:properties:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIRawFilter? Create (global::CoreVideo.CVPixelBuffer buffer, NSDictionary properties)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			var properties__handle__ = properties!.GetNonNullHandle (nameof (properties));
			CIRawFilter? ret;
			ret =  Runtime.GetNSObject<CIRawFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selFilterWithCVPixelBuffer_Properties_XHandle, buffer__handle__, properties__handle__), false)!;
			GC.KeepAlive (buffer);
			GC.KeepAlive (properties);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float BaselineExposure {
			[Export ("baselineExposure")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selBaselineExposureXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selBaselineExposureXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setBaselineExposure:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetBaselineExposure_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetBaselineExposure_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float BoostAmount {
			[Export ("boostAmount")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selBoostAmountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selBoostAmountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setBoostAmount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetBoostAmount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetBoostAmount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float BoostShadowAmount {
			[Export ("boostShadowAmount")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selBoostShadowAmountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selBoostShadowAmountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setBoostShadowAmount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetBoostShadowAmount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetBoostShadowAmount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ColorNoiseReductionAmount {
			[Export ("colorNoiseReductionAmount")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selColorNoiseReductionAmountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selColorNoiseReductionAmountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setColorNoiseReductionAmount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetColorNoiseReductionAmount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetColorNoiseReductionAmount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ColorNoiseReductionSupported {
			[Export ("isColorNoiseReductionSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsColorNoiseReductionSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsColorNoiseReductionSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ContrastAmount {
			[Export ("contrastAmount")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selContrastAmountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selContrastAmountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setContrastAmount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetContrastAmount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetContrastAmount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ContrastSupported {
			[Export ("isContrastSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsContrastSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsContrastSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSDictionary<NSString, NSObject>? CustomAttributes {
			[Export ("customAttributes")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				NSDictionary<NSString, NSObject>? ret;
				ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCustomAttributesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DecoderVersion {
			[Export ("decoderVersion", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDecoderVersionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDecoderVersionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDecoderVersion:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDecoderVersion_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDecoderVersion_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float DetailAmount {
			[Export ("detailAmount")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selDetailAmountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selDetailAmountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDetailAmount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetDetailAmount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetDetailAmount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DetailSupported {
			[Export ("isDetailSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDetailSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsDetailSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DraftModeEnabled {
			[Export ("isDraftModeEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDraftModeEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsDraftModeEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDraftModeEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDraftModeEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDraftModeEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Exposure {
			[Export ("exposure")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selExposureXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selExposureXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setExposure:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetExposure_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetExposure_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ExtendedDynamicRangeAmount {
			[Export ("extendedDynamicRangeAmount")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selExtendedDynamicRangeAmountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selExtendedDynamicRangeAmountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setExtendedDynamicRangeAmount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetExtendedDynamicRangeAmount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetExtendedDynamicRangeAmount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GamutMappingEnabled {
			[Export ("isGamutMappingEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsGamutMappingEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsGamutMappingEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setGamutMappingEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetGamutMappingEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetGamutMappingEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public virtual bool HighlightRecoveryEnabled {
			[Export ("isHighlightRecoveryEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsHighlightRecoveryEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsHighlightRecoveryEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHighlightRecoveryEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHighlightRecoveryEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetHighlightRecoveryEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public virtual bool HighlightRecoverySupported {
			[Export ("isHighlightRecoverySupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsHighlightRecoverySupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsHighlightRecoverySupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LensCorrectionEnabled {
			[Export ("isLensCorrectionEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLensCorrectionEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsLensCorrectionEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setLensCorrectionEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetLensCorrectionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetLensCorrectionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LensCorrectionSupported {
			[Export ("isLensCorrectionSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLensCorrectionSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsLensCorrectionSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIFilter? LinearSpaceFilter {
			[Export ("linearSpaceFilter", ArgumentSemantic.Retain)]
			get {
				CIFilter? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CIFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLinearSpaceFilterXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CIFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLinearSpaceFilterXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLinearSpaceFilter:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLinearSpaceFilter_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLinearSpaceFilter_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float LocalToneMapAmount {
			[Export ("localToneMapAmount")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selLocalToneMapAmountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selLocalToneMapAmountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLocalToneMapAmount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetLocalToneMapAmount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetLocalToneMapAmount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LocalToneMapSupported {
			[Export ("isLocalToneMapSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLocalToneMapSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsLocalToneMapSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float LuminanceNoiseReductionAmount {
			[Export ("luminanceNoiseReductionAmount")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selLuminanceNoiseReductionAmountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selLuminanceNoiseReductionAmountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLuminanceNoiseReductionAmount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetLuminanceNoiseReductionAmount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetLuminanceNoiseReductionAmount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LuminanceNoiseReductionSupported {
			[Export ("isLuminanceNoiseReductionSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLuminanceNoiseReductionSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsLuminanceNoiseReductionSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float MoireReductionAmount {
			[Export ("moireReductionAmount")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMoireReductionAmountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selMoireReductionAmountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMoireReductionAmount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMoireReductionAmount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetMoireReductionAmount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MoireReductionSupported {
			[Export ("isMoireReductionSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsMoireReductionSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsMoireReductionSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize NativeSize {
			[Export ("nativeSize")]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selNativeSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selNativeSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint NeutralChromaticity {
			[Export ("neutralChromaticity", ArgumentSemantic.Assign)]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, selNeutralChromaticityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, selNeutralChromaticityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setNeutralChromaticity:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, selSetNeutralChromaticity_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, selSetNeutralChromaticity_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint NeutralLocation {
			[Export ("neutralLocation", ArgumentSemantic.Assign)]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, selNeutralLocationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, selNeutralLocationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setNeutralLocation:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, selSetNeutralLocation_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, selSetNeutralLocation_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float NeutralTemperature {
			[Export ("neutralTemperature")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selNeutralTemperatureXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selNeutralTemperatureXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setNeutralTemperature:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetNeutralTemperature_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetNeutralTemperature_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float NeutralTint {
			[Export ("neutralTint")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selNeutralTintXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selNeutralTintXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setNeutralTint:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetNeutralTint_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetNeutralTint_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::ImageIO.CGImagePropertyOrientation Orientation {
			[Export ("orientation", ArgumentSemantic.Assign)]
			get {
				global::ImageIO.CGImagePropertyOrientation ret;
				if (IsDirectBinding) {
					ret = (global::ImageIO.CGImagePropertyOrientation) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selOrientationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (global::ImageIO.CGImagePropertyOrientation) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selOrientationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setOrientation:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetOrientation_XHandle, (int)value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selSetOrientation_XHandle, (int)value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual CIImage? OutputImage {
			[Export ("outputImage")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage? PortraitEffectsMatte {
			[Export ("portraitEffectsMatte")]
			get {
				CIImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPortraitEffectsMatteXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPortraitEffectsMatteXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage? PreviewImage {
			[Export ("previewImage")]
			get {
				CIImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreviewImageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreviewImageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary Properties {
			[Export ("properties")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPropertiesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPropertiesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ScaleFactor {
			[Export ("scaleFactor")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selScaleFactorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selScaleFactorXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setScaleFactor:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetScaleFactor_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetScaleFactor_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage? SemanticSegmentationGlassesMatte {
			[Export ("semanticSegmentationGlassesMatte")]
			get {
				CIImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSemanticSegmentationGlassesMatteXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSemanticSegmentationGlassesMatteXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage? SemanticSegmentationHairMatte {
			[Export ("semanticSegmentationHairMatte")]
			get {
				CIImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSemanticSegmentationHairMatteXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSemanticSegmentationHairMatteXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage? SemanticSegmentationSkinMatte {
			[Export ("semanticSegmentationSkinMatte")]
			get {
				CIImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSemanticSegmentationSkinMatteXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSemanticSegmentationSkinMatteXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage? SemanticSegmentationSkyMatte {
			[Export ("semanticSegmentationSkyMatte")]
			get {
				CIImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSemanticSegmentationSkyMatteXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSemanticSegmentationSkyMatteXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage? SemanticSegmentationTeethMatte {
			[Export ("semanticSegmentationTeethMatte")]
			get {
				CIImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSemanticSegmentationTeethMatteXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSemanticSegmentationTeethMatteXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ShadowBias {
			[Export ("shadowBias")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selShadowBiasXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selShadowBiasXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setShadowBias:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetShadowBias_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetShadowBias_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float SharpnessAmount {
			[Export ("sharpnessAmount")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selSharpnessAmountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selSharpnessAmountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSharpnessAmount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetSharpnessAmount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetSharpnessAmount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SharpnessSupported {
			[Export ("isSharpnessSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSharpnessSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsSharpnessSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] SupportedCameraModels {
			[Export ("supportedCameraModels")]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSupportedCameraModelsXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] SupportedDecoderVersions {
			[Export ("supportedDecoderVersions")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSupportedDecoderVersionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSupportedDecoderVersionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class CIRawFilter */
}
