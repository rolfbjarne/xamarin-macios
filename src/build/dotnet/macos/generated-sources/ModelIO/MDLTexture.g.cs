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
	/// <summary>Represents texel data for surface rendering.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLTexture_Class/index.html">Apple documentation for <c>MDLTexture</c></related>
	[Register("MDLTexture", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MDLTexture : NSObject, IMDLNamed {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChannelCountX = "channelCount";
		static readonly NativeHandle selChannelCountXHandle = Selector.GetHandle ("channelCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChannelEncodingX = "channelEncoding";
		static readonly NativeHandle selChannelEncodingXHandle = Selector.GetHandle ("channelEncoding");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDimensionsX = "dimensions";
		static readonly NativeHandle selDimensionsXHandle = Selector.GetHandle ("dimensions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasAlphaValuesX = "hasAlphaValues";
		static readonly NativeHandle selHasAlphaValuesXHandle = Selector.GetHandle ("hasAlphaValues");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageFromTextureX = "imageFromTexture";
		static readonly NativeHandle selImageFromTextureXHandle = Selector.GetHandle ("imageFromTexture");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageFromTextureAtLevel_X = "imageFromTextureAtLevel:";
		static readonly NativeHandle selImageFromTextureAtLevel_XHandle = Selector.GetHandle ("imageFromTextureAtLevel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitX = "init";
		static readonly NativeHandle selInitXHandle = Selector.GetHandle ("init");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_X = "initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:";
		static readonly NativeHandle selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_XHandle = Selector.GetHandle ("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIrradianceTextureCubeWithTexture_Name_Dimensions_X = "irradianceTextureCubeWithTexture:name:dimensions:";
		static readonly NativeHandle selIrradianceTextureCubeWithTexture_Name_Dimensions_XHandle = Selector.GetHandle ("irradianceTextureCubeWithTexture:name:dimensions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIrradianceTextureCubeWithTexture_Name_Dimensions_Roughness_X = "irradianceTextureCubeWithTexture:name:dimensions:roughness:";
		static readonly NativeHandle selIrradianceTextureCubeWithTexture_Name_Dimensions_Roughness_XHandle = Selector.GetHandle ("irradianceTextureCubeWithTexture:name:dimensions:roughness:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsCubeX = "isCube";
		static readonly NativeHandle selIsCubeXHandle = Selector.GetHandle ("isCube");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMipLevelCountX = "mipLevelCount";
		static readonly NativeHandle selMipLevelCountXHandle = Selector.GetHandle ("mipLevelCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNameX = "name";
		static readonly NativeHandle selNameXHandle = Selector.GetHandle ("name");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowStrideX = "rowStride";
		static readonly NativeHandle selRowStrideXHandle = Selector.GetHandle ("rowStride");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHasAlphaValues_X = "setHasAlphaValues:";
		static readonly NativeHandle selSetHasAlphaValues_XHandle = Selector.GetHandle ("setHasAlphaValues:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIsCube_X = "setIsCube:";
		static readonly NativeHandle selSetIsCube_XHandle = Selector.GetHandle ("setIsCube:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetName_X = "setName:";
		static readonly NativeHandle selSetName_XHandle = Selector.GetHandle ("setName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTexelDataWithBottomLeftOriginX = "texelDataWithBottomLeftOrigin";
		static readonly NativeHandle selTexelDataWithBottomLeftOriginXHandle = Selector.GetHandle ("texelDataWithBottomLeftOrigin");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTexelDataWithBottomLeftOriginAtMipLevel_Create_X = "texelDataWithBottomLeftOriginAtMipLevel:create:";
		static readonly NativeHandle selTexelDataWithBottomLeftOriginAtMipLevel_Create_XHandle = Selector.GetHandle ("texelDataWithBottomLeftOriginAtMipLevel:create:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTexelDataWithTopLeftOriginX = "texelDataWithTopLeftOrigin";
		static readonly NativeHandle selTexelDataWithTopLeftOriginXHandle = Selector.GetHandle ("texelDataWithTopLeftOrigin");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTexelDataWithTopLeftOriginAtMipLevel_Create_X = "texelDataWithTopLeftOriginAtMipLevel:create:";
		static readonly NativeHandle selTexelDataWithTopLeftOriginAtMipLevel_Create_XHandle = Selector.GetHandle ("texelDataWithTopLeftOriginAtMipLevel:create:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureCubeWithImagesNamed_X = "textureCubeWithImagesNamed:";
		static readonly NativeHandle selTextureCubeWithImagesNamed_XHandle = Selector.GetHandle ("textureCubeWithImagesNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureCubeWithImagesNamed_Bundle_X = "textureCubeWithImagesNamed:bundle:";
		static readonly NativeHandle selTextureCubeWithImagesNamed_Bundle_XHandle = Selector.GetHandle ("textureCubeWithImagesNamed:bundle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureNamed_X = "textureNamed:";
		static readonly NativeHandle selTextureNamed_XHandle = Selector.GetHandle ("textureNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureNamed_AssetResolver_X = "textureNamed:assetResolver:";
		static readonly NativeHandle selTextureNamed_AssetResolver_XHandle = Selector.GetHandle ("textureNamed:assetResolver:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureNamed_Bundle_X = "textureNamed:bundle:";
		static readonly NativeHandle selTextureNamed_Bundle_XHandle = Selector.GetHandle ("textureNamed:bundle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteToURL_X = "writeToURL:";
		static readonly NativeHandle selWriteToURL_XHandle = Selector.GetHandle ("writeToURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteToURL_Level_X = "writeToURL:level:";
		static readonly NativeHandle selWriteToURL_Level_XHandle = Selector.GetHandle ("writeToURL:level:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteToURL_Type_X = "writeToURL:type:";
		static readonly NativeHandle selWriteToURL_Type_XHandle = Selector.GetHandle ("writeToURL:type:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteToURL_Type_Level_X = "writeToURL:type:level:";
		static readonly NativeHandle selWriteToURL_Type_Level_XHandle = Selector.GetHandle ("writeToURL:type:level:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MDLTexture");
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
		protected MDLTexture (NSObjectFlag t) : base (t)
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
		protected internal MDLTexture (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>Default constructor, initializes a new instance of this class.</summary><remarks></remarks>
		[Export ("init")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLTexture ()
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInitXHandle), "init");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInitXHandle), "init");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="pixelData"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="topLeftOrigin">To be added.</param><param name="name"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="dimensions">To be added.</param><param name="rowStride">To be added.</param><param name="channelCount">To be added.</param><param name="channelEncoding">To be added.</param><param name="isCube">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLTexture (NSData? pixelData, bool topLeftOrigin, string? name, NVector2i dimensions, nint rowStride, nuint channelCount, MDLTextureChannelEncoding channelEncoding, bool isCube)
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
		/// <param name="texture">To be added.</param><param name="name"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="dimensions">To be added.</param><summary>Creates an cubical irradiance map from an environment map.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("irradianceTextureCubeWithTexture:name:dimensions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLTexture CreateIrradianceTextureCube (MDLTexture texture, string? name, NVector2i dimensions)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			var nsname = CFString.CreateNative (name);
			MDLTexture? ret;
			ret =  Runtime.GetNSObject<MDLTexture> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NVector2i (class_ptr, selIrradianceTextureCubeWithTexture_Name_Dimensions_XHandle, texture__handle__, nsname, dimensions), false)!;
			GC.KeepAlive (texture);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("irradianceTextureCubeWithTexture:name:dimensions:roughness:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLTexture CreateIrradianceTextureCube (MDLTexture reflectiveTexture, string? name, NVector2i dimensions, float roughness)
		{
			var reflectiveTexture__handle__ = reflectiveTexture!.GetNonNullHandle (nameof (reflectiveTexture));
			var nsname = CFString.CreateNative (name);
			MDLTexture? ret;
			ret =  Runtime.GetNSObject<MDLTexture> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NVector2i_float (class_ptr, selIrradianceTextureCubeWithTexture_Name_Dimensions_Roughness_XHandle, reflectiveTexture__handle__, nsname, dimensions, roughness), false)!;
			GC.KeepAlive (reflectiveTexture);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <summary>Creates a new texture from the specified texture in the default application bundle.</summary>
		[Export ("textureNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLTexture? CreateTexture (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			MDLTexture? ret;
			ret =  Runtime.GetNSObject<MDLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selTextureNamed_XHandle, nsname), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <summary>Creates a new texture from the specified texture in the specified application bundle.</summary>
		[Export ("textureNamed:bundle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLTexture? CreateTexture (string name, NSBundle? bundleOrNil)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var bundleOrNil__handle__ = bundleOrNil.GetHandle ();
			var nsname = CFString.CreateNative (name);
			MDLTexture? ret;
			ret =  Runtime.GetNSObject<MDLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selTextureNamed_Bundle_XHandle, nsname, bundleOrNil__handle__), false)!;
			GC.KeepAlive (bundleOrNil);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <param name="name">To be added.</param><param name="resolver">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textureNamed:assetResolver:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLTexture? CreateTexture (string name, IMDLAssetResolver resolver)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var resolver__handle__ = resolver!.GetNonNullHandle (nameof (resolver));
			var nsname = CFString.CreateNative (name);
			MDLTexture? ret;
			ret =  Runtime.GetNSObject<MDLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selTextureNamed_AssetResolver_XHandle, nsname, resolver__handle__), false)!;
			GC.KeepAlive (resolver);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <param name="imageNames">To be added.</param><summary>Creates a texture cube from the named images in the default application bundle.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textureCubeWithImagesNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLTexture? CreateTextureCube (string[] imageNames)
		{
			if (imageNames is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (imageNames));
			using var nsa_imageNames = NSArray.FromStrings (imageNames);
			MDLTexture ret;
			ret =  Runtime.GetNSObject<MDLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selTextureCubeWithImagesNamed_XHandle, nsa_imageNames.Handle), false)!;
			return ret;
		}
		/// <param name="imageNames">To be added.</param><param name="bundleOrNil"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a texture cube from the named images in the specified application bundle.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textureCubeWithImagesNamed:bundle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLTexture? CreateTextureCube (string[] imageNames, NSBundle? bundleOrNil)
		{
			if (imageNames is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (imageNames));
			var bundleOrNil__handle__ = bundleOrNil.GetHandle ();
			using var nsa_imageNames = NSArray.FromStrings (imageNames);
			MDLTexture? ret;
			ret =  Runtime.GetNSObject<MDLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selTextureCubeWithImagesNamed_Bundle_XHandle, nsa_imageNames.Handle, bundleOrNil__handle__), false)!;
			GC.KeepAlive (bundleOrNil);
			return ret!;
		}
		/// <summary>Returns an image created from the texture data.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageFromTexture")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGImage? GetImageFromTexture ()
		{
			CGImage ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selImageFromTextureXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selImageFromTextureXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="level">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageFromTextureAtLevel:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGImage? GetImageFromTexture (nuint level)
		{
			CGImage ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selImageFromTextureAtLevel_XHandle, level), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selImageFromTextureAtLevel_XHandle, level), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>Gets the texel data such that the first texel represents the bottom left corner of the texture.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("texelDataWithBottomLeftOrigin")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? GetTexelDataWithBottomLeftOrigin ()
		{
			NSData ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTexelDataWithBottomLeftOriginXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTexelDataWithBottomLeftOriginXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="mipLevel">To be added.</param><param name="create">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("texelDataWithBottomLeftOriginAtMipLevel:create:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? GetTexelDataWithBottomLeftOrigin (nint mipLevel, bool create)
		{
			NSData ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_bool (this.Handle, selTexelDataWithBottomLeftOriginAtMipLevel_Create_XHandle, mipLevel, create ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_bool (&__objc_super__, selTexelDataWithBottomLeftOriginAtMipLevel_Create_XHandle, mipLevel, create ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>Gets the texel data such that the first texel represents the top left corner of the texture.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("texelDataWithTopLeftOrigin")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? GetTexelDataWithTopLeftOrigin ()
		{
			NSData ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTexelDataWithTopLeftOriginXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTexelDataWithTopLeftOriginXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="mipLevel">To be added.</param><param name="create">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("texelDataWithTopLeftOriginAtMipLevel:create:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? GetTexelDataWithTopLeftOrigin (nint mipLevel, bool create)
		{
			NSData ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_bool (this.Handle, selTexelDataWithTopLeftOriginAtMipLevel_Create_XHandle, mipLevel, create ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_bool (&__objc_super__, selTexelDataWithTopLeftOriginAtMipLevel_Create_XHandle, mipLevel, create ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="url">To be added.</param><summary>Writes the texture data to the specified URL.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writeToURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteToUrl (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selWriteToURL_XHandle, url__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selWriteToURL_XHandle, url__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			return ret != 0;
		}
		/// <param name="url">To be added.</param><param name="level">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writeToURL:level:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteToUrl (NSUrl url, nuint level)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selWriteToURL_Level_XHandle, url__handle__, level);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selWriteToURL_Level_XHandle, url__handle__, level);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			return ret != 0;
		}
		/// <param name="url">To be added.</param><param name="type">To be added.</param><summary>Writes the texture data to the specified URL.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writeToURL:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteToUrl (NSUrl url, string type)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selWriteToURL_Type_XHandle, url__handle__, nstype);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selWriteToURL_Type_XHandle, url__handle__, nstype);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			CFString.ReleaseNative (nstype);
			return ret != 0;
		}
		/// <param name="nsurl">To be added.</param><param name="type">To be added.</param><param name="level">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writeToURL:type:level:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteToUrl (NSUrl nsurl, string type, nuint level)
		{
			var nsurl__handle__ = nsurl!.GetNonNullHandle (nameof (nsurl));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, selWriteToURL_Type_Level_XHandle, nsurl__handle__, nstype, level);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr (&__objc_super__, selWriteToURL_Type_Level_XHandle, nsurl__handle__, nstype, level);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (nsurl);
			CFString.ReleaseNative (nstype);
			return ret != 0;
		}
		/// <summary>Gets the number of channels per texel.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint ChannelCount {
			[Export ("channelCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selChannelCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selChannelCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets a value that represents the encoding for texels in the texture.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLTextureChannelEncoding ChannelEncoding {
			[Export ("channelEncoding")]
			get {
				MDLTextureChannelEncoding ret;
				if (IsDirectBinding) {
					ret = (MDLTextureChannelEncoding) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selChannelEncodingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MDLTextureChannelEncoding) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selChannelEncodingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the width and height of the texture, in texels.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NVector2i Dimensions {
			[Export ("dimensions")]
			get {
				NVector2i ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NVector2i_objc_msgSend (this.Handle, selDimensionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NVector2i_objc_msgSendSuper (&__objc_super__, selDimensionsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool HasAlphaValues {
			[Export ("hasAlphaValues")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasAlphaValuesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasAlphaValuesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHasAlphaValues:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHasAlphaValues_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetHasAlphaValues_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a value that determines whether the texture should be interpreted as a cube.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsCube {
			[Export ("isCube")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCubeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsCubeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setIsCube:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsCube_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetIsCube_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the maximum number of mipmap levels for the texture.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint MipLevelCount {
			[Export ("mipLevelCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMipLevelCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMipLevelCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets or sets the descriptive name of the named object.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string Name {
			[Export ("name")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
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
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
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
		/// <summary>Gets the row stride length in bytes.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RowStride {
			[Export ("rowStride")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRowStrideXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selRowStrideXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class MDLTexture */
}
