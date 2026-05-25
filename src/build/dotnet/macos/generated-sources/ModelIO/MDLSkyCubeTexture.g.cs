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
namespace ModelIO {
	/// <summary>A texture that represents a realistic sunlit sky.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLSkyCubeTexture_Class/index.html">Apple documentation for <c>MDLSkyCubeTexture</c></related>
	[Register("MDLSkyCubeTexture", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MDLSkyCubeTexture : MDLTexture {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBrightnessX = "brightness";
		static readonly NativeHandle selBrightnessXHandle = Selector.GetHandle ("brightness");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContrastX = "contrast";
		static readonly NativeHandle selContrastXHandle = Selector.GetHandle ("contrast");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExposureX = "exposure";
		static readonly NativeHandle selExposureXHandle = Selector.GetHandle ("exposure");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGammaX = "gamma";
		static readonly NativeHandle selGammaXHandle = Selector.GetHandle ("gamma");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGroundAlbedoX = "groundAlbedo";
		static readonly NativeHandle selGroundAlbedoXHandle = Selector.GetHandle ("groundAlbedo");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGroundColorX = "groundColor";
		static readonly NativeHandle selGroundColorXHandle = Selector.GetHandle ("groundColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHighDynamicRangeCompressionX = "highDynamicRangeCompression";
		static readonly NativeHandle selHighDynamicRangeCompressionXHandle = Selector.GetHandle ("highDynamicRangeCompression");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHorizonElevationX = "horizonElevation";
		static readonly NativeHandle selHorizonElevationXHandle = Selector.GetHandle ("horizonElevation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_X = "initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:";
		static readonly NativeHandle selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_XHandle = Selector.GetHandle ("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_ChannelEncoding_TextureDimensions_Turbidity_SunElevation_SunAzimuth_UpperAtmosphereScattering_GroundAlbedo_X = "initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:sunAzimuth:upperAtmosphereScattering:groundAlbedo:";
		static readonly NativeHandle selInitWithName_ChannelEncoding_TextureDimensions_Turbidity_SunElevation_SunAzimuth_UpperAtmosphereScattering_GroundAlbedo_XHandle = Selector.GetHandle ("initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:sunAzimuth:upperAtmosphereScattering:groundAlbedo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_ChannelEncoding_TextureDimensions_Turbidity_SunElevation_UpperAtmosphereScattering_GroundAlbedo_X = "initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:upperAtmosphereScattering:groundAlbedo:";
		static readonly NativeHandle selInitWithName_ChannelEncoding_TextureDimensions_Turbidity_SunElevation_UpperAtmosphereScattering_GroundAlbedo_XHandle = Selector.GetHandle ("initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:upperAtmosphereScattering:groundAlbedo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaturationX = "saturation";
		static readonly NativeHandle selSaturationXHandle = Selector.GetHandle ("saturation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBrightness_X = "setBrightness:";
		static readonly NativeHandle selSetBrightness_XHandle = Selector.GetHandle ("setBrightness:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContrast_X = "setContrast:";
		static readonly NativeHandle selSetContrast_XHandle = Selector.GetHandle ("setContrast:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetExposure_X = "setExposure:";
		static readonly NativeHandle selSetExposure_XHandle = Selector.GetHandle ("setExposure:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGamma_X = "setGamma:";
		static readonly NativeHandle selSetGamma_XHandle = Selector.GetHandle ("setGamma:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGroundAlbedo_X = "setGroundAlbedo:";
		static readonly NativeHandle selSetGroundAlbedo_XHandle = Selector.GetHandle ("setGroundAlbedo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGroundColor_X = "setGroundColor:";
		static readonly NativeHandle selSetGroundColor_XHandle = Selector.GetHandle ("setGroundColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHighDynamicRangeCompression_X = "setHighDynamicRangeCompression:";
		static readonly NativeHandle selSetHighDynamicRangeCompression_XHandle = Selector.GetHandle ("setHighDynamicRangeCompression:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHorizonElevation_X = "setHorizonElevation:";
		static readonly NativeHandle selSetHorizonElevation_XHandle = Selector.GetHandle ("setHorizonElevation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSaturation_X = "setSaturation:";
		static readonly NativeHandle selSetSaturation_XHandle = Selector.GetHandle ("setSaturation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSunAzimuth_X = "setSunAzimuth:";
		static readonly NativeHandle selSetSunAzimuth_XHandle = Selector.GetHandle ("setSunAzimuth:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSunElevation_X = "setSunElevation:";
		static readonly NativeHandle selSetSunElevation_XHandle = Selector.GetHandle ("setSunElevation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTurbidity_X = "setTurbidity:";
		static readonly NativeHandle selSetTurbidity_XHandle = Selector.GetHandle ("setTurbidity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUpperAtmosphereScattering_X = "setUpperAtmosphereScattering:";
		static readonly NativeHandle selSetUpperAtmosphereScattering_XHandle = Selector.GetHandle ("setUpperAtmosphereScattering:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSunAzimuthX = "sunAzimuth";
		static readonly NativeHandle selSunAzimuthXHandle = Selector.GetHandle ("sunAzimuth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSunElevationX = "sunElevation";
		static readonly NativeHandle selSunElevationXHandle = Selector.GetHandle ("sunElevation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTurbidityX = "turbidity";
		static readonly NativeHandle selTurbidityXHandle = Selector.GetHandle ("turbidity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateTextureX = "updateTexture";
		static readonly NativeHandle selUpdateTextureXHandle = Selector.GetHandle ("updateTexture");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpperAtmosphereScatteringX = "upperAtmosphereScattering";
		static readonly NativeHandle selUpperAtmosphereScatteringXHandle = Selector.GetHandle ("upperAtmosphereScattering");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MDLSkyCubeTexture");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected MDLSkyCubeTexture (NSObjectFlag t) : base (t)
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
		protected internal MDLSkyCubeTexture (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="pixelData"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="topLeftOrigin">To be added.</param><param name="name"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="dimensions">To be added.</param><param name="rowStride">To be added.</param><param name="channelCount">To be added.</param><param name="channelEncoding">To be added.</param><param name="isCube">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLSkyCubeTexture (NSData? pixelData, bool topLeftOrigin, string? name, NVector2i dimensions, nint rowStride, nuint channelCount, MDLTextureChannelEncoding channelEncoding, bool isCube)
			: base (NSObjectFlag.Empty)
		{
			var pixelData__handle__ = pixelData.GetHandle ();
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_bool_NativeHandle_NVector2i_IntPtr_UIntPtr_IntPtr_bool (this.Handle, selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_XHandle, pixelData__handle__, topLeftOrigin ? (byte) 1 : (byte) 0, nsname, dimensions, rowStride, channelCount, (IntPtr) (long) channelEncoding, isCube ? (byte) 1 : (byte) 0), "initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_NativeHandle_bool_NativeHandle_NVector2i_IntPtr_UIntPtr_IntPtr_bool (&__objc_super__, selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_XHandle, pixelData__handle__, topLeftOrigin ? (byte) 1 : (byte) 0, nsname, dimensions, rowStride, channelCount, (IntPtr) (long) channelEncoding, isCube ? (byte) 1 : (byte) 0), "initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pixelData);
			CFString.ReleaseNative (nsname);
		}
		/// <param name="name"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="channelEncoding">To be added.</param><param name="textureDimensions">To be added.</param><param name="turbidity">To be added.</param><param name="sunElevation">To be added.</param><param name="upperAtmosphereScattering">To be added.</param><param name="groundAlbedo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:upperAtmosphereScattering:groundAlbedo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLSkyCubeTexture (string? name, MDLTextureChannelEncoding channelEncoding, NVector2i textureDimensions, float turbidity, float sunElevation, float upperAtmosphereScattering, float groundAlbedo)
			: base (NSObjectFlag.Empty)
		{
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_IntPtr_NVector2i_float_float_float_float (this.Handle, selInitWithName_ChannelEncoding_TextureDimensions_Turbidity_SunElevation_UpperAtmosphereScattering_GroundAlbedo_XHandle, nsname, (IntPtr) (long) channelEncoding, textureDimensions, turbidity, sunElevation, upperAtmosphereScattering, groundAlbedo), "initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:upperAtmosphereScattering:groundAlbedo:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_NVector2i_float_float_float_float (&__objc_super__, selInitWithName_ChannelEncoding_TextureDimensions_Turbidity_SunElevation_UpperAtmosphereScattering_GroundAlbedo_XHandle, nsname, (IntPtr) (long) channelEncoding, textureDimensions, turbidity, sunElevation, upperAtmosphereScattering, groundAlbedo), "initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:upperAtmosphereScattering:groundAlbedo:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		/// <param name="name"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="channelEncoding">To be added.</param><param name="textureDimensions">To be added.</param><param name="turbidity">To be added.</param><param name="sunElevation">To be added.</param><param name="sunAzimuth">To be added.</param><param name="upperAtmosphereScattering">To be added.</param><param name="groundAlbedo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:sunAzimuth:upperAtmosphereScattering:groundAlbedo:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLSkyCubeTexture (string? name, MDLTextureChannelEncoding channelEncoding, NVector2i textureDimensions, float turbidity, float sunElevation, float sunAzimuth, float upperAtmosphereScattering, float groundAlbedo)
			: base (NSObjectFlag.Empty)
		{
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_IntPtr_NVector2i_float_float_float_float_float (this.Handle, selInitWithName_ChannelEncoding_TextureDimensions_Turbidity_SunElevation_SunAzimuth_UpperAtmosphereScattering_GroundAlbedo_XHandle, nsname, (IntPtr) (long) channelEncoding, textureDimensions, turbidity, sunElevation, sunAzimuth, upperAtmosphereScattering, groundAlbedo), "initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:sunAzimuth:upperAtmosphereScattering:groundAlbedo:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_NVector2i_float_float_float_float_float (&__objc_super__, selInitWithName_ChannelEncoding_TextureDimensions_Turbidity_SunElevation_SunAzimuth_UpperAtmosphereScattering_GroundAlbedo_XHandle, nsname, (IntPtr) (long) channelEncoding, textureDimensions, turbidity, sunElevation, sunAzimuth, upperAtmosphereScattering, groundAlbedo), "initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:sunAzimuth:upperAtmosphereScattering:groundAlbedo:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		/// <summary>Regenerates the sky to match the current property values of this MDLSkyCubeTexture object.</summary><remarks>To be added.</remarks>
		[Export ("updateTexture")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateTexture ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateTextureXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUpdateTextureXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Gets or sets a brightness multiplier to use when tone mapping.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Brightness {
			[Export ("brightness")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selBrightnessXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selBrightnessXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setBrightness:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetBrightness_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetBrightness_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a contrast multiplier to use when tone mapping.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Contrast {
			[Export ("contrast")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selContrastXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selContrastXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setContrast:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetContrast_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetContrast_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a the exposure to use when tone mapping.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>Gets or sets a gamma correction factor to use when tone mapping.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Gamma {
			[Export ("gamma")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selGammaXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selGammaXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setGamma:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetGamma_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetGamma_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the relative amount of light, from <c>0.0</c> to <c>10.0</c>, that reflects off the ground. Lower values produce an effect similar to a clear sky.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float GroundAlbedo {
			[Export ("groundAlbedo")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selGroundAlbedoXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selGroundAlbedoXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setGroundAlbedo:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetGroundAlbedo_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetGroundAlbedo_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the ground color.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGColor? GroundColor {
			[Export ("groundColor", ArgumentSemantic.Assign)]
			get {
				CGColor ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGroundColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGroundColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setGroundColor:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetGroundColor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetGroundColor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets a vector, that filters and clamps color values for HDR compression.</summary><value>To be added.</value><remarks>Color values that are below the X value of this property's vector value are ignored. Thos above the Y value are clamped to the maximum display brightness.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector2 HighDynamicRangeCompression {
			[Export ("highDynamicRangeCompression", ArgumentSemantic.Assign)]
			get {
				global::System.Numerics.Vector2 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector2_objc_msgSend (this.Handle, selHighDynamicRangeCompressionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector2_objc_msgSendSuper (&__objc_super__, selHighDynamicRangeCompressionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setHighDynamicRangeCompression:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Vector2 (this.Handle, selSetHighDynamicRangeCompression_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Vector2 (&__objc_super__, selSetHighDynamicRangeCompression_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the angular height, in radians, below which the ground color affects the rendering outcome.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float HorizonElevation {
			[Export ("horizonElevation")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selHorizonElevationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selHorizonElevationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setHorizonElevation:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetHorizonElevation_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetHorizonElevation_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the saturation to use when tone mapping.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Saturation {
			[Export ("saturation")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selSaturationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selSaturationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSaturation:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetSaturation_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetSaturation_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual float SunAzimuth {
			[Export ("sunAzimuth")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selSunAzimuthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selSunAzimuthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSunAzimuth:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetSunAzimuth_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetSunAzimuth_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the angular position, from the zenith, of the Sun's position.</summary><value>To be added.</value><remarks>To control the horizontal position of the sun, app developers should rotate the scene within the sky cube.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float SunElevation {
			[Export ("sunElevation")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selSunElevationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selSunElevationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSunElevation:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetSunElevation_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetSunElevation_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the haziness of the simulated sky, on a scale from <c>0.0</c> to <c>1.0</c>.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Turbidity {
			[Export ("turbidity")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selTurbidityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selTurbidityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTurbidity:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetTurbidity_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetTurbidity_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the scattering present in the upper regions of the simulated sky, on a scale from <c>0.0</c> (similar to illumination at dawn or dusk) to <c>1.0</c> (similar to midday illumination).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float UpperAtmosphereScattering {
			[Export ("upperAtmosphereScattering")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selUpperAtmosphereScatteringXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selUpperAtmosphereScatteringXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setUpperAtmosphereScattering:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetUpperAtmosphereScattering_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetUpperAtmosphereScattering_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class MDLSkyCubeTexture */
}
