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
namespace SpriteKit {
	/// <summary>An image that can be used with one or more <see cref="T:SpriteKit.SKSpriteNode" />s and particles.</summary><remarks><para>Sprite Kit attempts to be efficient with the memory associated with textures. Textures are lazy-loaded from their source files and in preparation for loading onto the graphics hardware. This lazy-loading can be overridden with the <c>Preload*</c> methods.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKTexture_Ref/index.html">Apple documentation for <c>SKTexture</c></related>
	[Register("SKTexture", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SKTexture : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCGImageX = "CGImage";
		static readonly NativeHandle selCGImageXHandle = Selector.GetHandle ("CGImage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilteringModeX = "filteringMode";
		static readonly NativeHandle selFilteringModeXHandle = Selector.GetHandle ("filteringMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreloadTextures_WithCompletionHandler_X = "preloadTextures:withCompletionHandler:";
		static readonly NativeHandle selPreloadTextures_WithCompletionHandler_XHandle = Selector.GetHandle ("preloadTextures:withCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreloadWithCompletionHandler_X = "preloadWithCompletionHandler:";
		static readonly NativeHandle selPreloadWithCompletionHandler_XHandle = Selector.GetHandle ("preloadWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFilteringMode_X = "setFilteringMode:";
		static readonly NativeHandle selSetFilteringMode_XHandle = Selector.GetHandle ("setFilteringMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesMipmaps_X = "setUsesMipmaps:";
		static readonly NativeHandle selSetUsesMipmaps_XHandle = Selector.GetHandle ("setUsesMipmaps:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSizeX = "size";
		static readonly NativeHandle selSizeXHandle = Selector.GetHandle ("size");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureByApplyingCIFilter_X = "textureByApplyingCIFilter:";
		static readonly NativeHandle selTextureByApplyingCIFilter_XHandle = Selector.GetHandle ("textureByApplyingCIFilter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureByGeneratingNormalMapX = "textureByGeneratingNormalMap";
		static readonly NativeHandle selTextureByGeneratingNormalMapXHandle = Selector.GetHandle ("textureByGeneratingNormalMap");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureByGeneratingNormalMapWithSmoothness_Contrast_X = "textureByGeneratingNormalMapWithSmoothness:contrast:";
		static readonly NativeHandle selTextureByGeneratingNormalMapWithSmoothness_Contrast_XHandle = Selector.GetHandle ("textureByGeneratingNormalMapWithSmoothness:contrast:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureNoiseWithSmoothness_Size_Grayscale_X = "textureNoiseWithSmoothness:size:grayscale:";
		static readonly NativeHandle selTextureNoiseWithSmoothness_Size_Grayscale_XHandle = Selector.GetHandle ("textureNoiseWithSmoothness:size:grayscale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureRectX = "textureRect";
		static readonly NativeHandle selTextureRectXHandle = Selector.GetHandle ("textureRect");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureVectorNoiseWithSmoothness_Size_X = "textureVectorNoiseWithSmoothness:size:";
		static readonly NativeHandle selTextureVectorNoiseWithSmoothness_Size_XHandle = Selector.GetHandle ("textureVectorNoiseWithSmoothness:size:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureWithCGImage_X = "textureWithCGImage:";
		static readonly NativeHandle selTextureWithCGImage_XHandle = Selector.GetHandle ("textureWithCGImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureWithData_Size_X = "textureWithData:size:";
		static readonly NativeHandle selTextureWithData_Size_XHandle = Selector.GetHandle ("textureWithData:size:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureWithData_Size_Flipped_X = "textureWithData:size:flipped:";
		static readonly NativeHandle selTextureWithData_Size_Flipped_XHandle = Selector.GetHandle ("textureWithData:size:flipped:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureWithData_Size_RowLength_Alignment_X = "textureWithData:size:rowLength:alignment:";
		static readonly NativeHandle selTextureWithData_Size_RowLength_Alignment_XHandle = Selector.GetHandle ("textureWithData:size:rowLength:alignment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureWithImage_X = "textureWithImage:";
		static readonly NativeHandle selTextureWithImage_XHandle = Selector.GetHandle ("textureWithImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureWithImageNamed_X = "textureWithImageNamed:";
		static readonly NativeHandle selTextureWithImageNamed_XHandle = Selector.GetHandle ("textureWithImageNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureWithNoiseMap_X = "textureWithNoiseMap:";
		static readonly NativeHandle selTextureWithNoiseMap_XHandle = Selector.GetHandle ("textureWithNoiseMap:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureWithRect_InTexture_X = "textureWithRect:inTexture:";
		static readonly NativeHandle selTextureWithRect_InTexture_XHandle = Selector.GetHandle ("textureWithRect:inTexture:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesMipmapsX = "usesMipmaps";
		static readonly NativeHandle selUsesMipmapsXHandle = Selector.GetHandle ("usesMipmaps");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SKTexture");
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
		public SKTexture (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected SKTexture (NSObjectFlag t) : base (t)
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
		protected internal SKTexture (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
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
		[Export ("textureByGeneratingNormalMap")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKTexture CreateTextureByGeneratingNormalMap ()
		{
			SKTexture ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextureByGeneratingNormalMapXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextureByGeneratingNormalMapXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="smoothness">To be added.</param><param name="contrast">To be added.</param><summary>Creates a new texture from the texture, smoothing the texture values before processing and magnifying the contrast of the resulting normal map.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textureByGeneratingNormalMapWithSmoothness:contrast:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKTexture CreateTextureByGeneratingNormalMap (nfloat smoothness, nfloat contrast)
		{
			SKTexture ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat (this.Handle, selTextureByGeneratingNormalMapWithSmoothness_Contrast_XHandle, smoothness, contrast), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat_nfloat (&__objc_super__, selTextureByGeneratingNormalMapWithSmoothness_Contrast_XHandle, smoothness, contrast), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
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
		[Export ("textureWithData:size:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTexture FromData (NSData pixelData, CGSize size)
		{
			var pixelData__handle__ = pixelData!.GetNonNullHandle (nameof (pixelData));
			SKTexture? ret;
			ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGSize (class_ptr, selTextureWithData_Size_XHandle, pixelData__handle__, size), false)!;
			GC.KeepAlive (pixelData);
			return ret!;
		}
		[Export ("textureWithData:size:rowLength:alignment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTexture FromData (NSData pixelData, CGSize size, uint rowLength, uint alignment)
		{
			var pixelData__handle__ = pixelData!.GetNonNullHandle (nameof (pixelData));
			SKTexture? ret;
			ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGSize_UInt32_UInt32 (class_ptr, selTextureWithData_Size_RowLength_Alignment_XHandle, pixelData__handle__, size, rowLength, alignment), false)!;
			GC.KeepAlive (pixelData);
			return ret!;
		}
		[Export ("textureWithData:size:flipped:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTexture FromData (NSData pixelData, CGSize size, bool flipped)
		{
			var pixelData__handle__ = pixelData!.GetNonNullHandle (nameof (pixelData));
			SKTexture? ret;
			ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGSize_bool (class_ptr, selTextureWithData_Size_Flipped_XHandle, pixelData__handle__, size, flipped ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (pixelData);
			return ret!;
		}
		[Export ("textureWithCGImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTexture FromImage (CGImage image)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			SKTexture? ret;
			ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selTextureWithCGImage_XHandle, image.Handle), false)!;
			GC.KeepAlive (image);
			return ret!;
		}
		[Export ("textureWithImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTexture FromImage (global::AppKit.NSImage image)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			SKTexture? ret;
			ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selTextureWithImage_XHandle, image__handle__), false)!;
			GC.KeepAlive (image);
			return ret!;
		}
		[Export ("textureWithImageNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTexture FromImageNamed (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			SKTexture? ret;
			ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selTextureWithImageNamed_XHandle, nsname), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <param name="noiseMap">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textureWithNoiseMap:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTexture FromNoiseMap (global::GameplayKit.GKNoiseMap noiseMap)
		{
			var noiseMap__handle__ = noiseMap!.GetNonNullHandle (nameof (noiseMap));
			SKTexture? ret;
			ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selTextureWithNoiseMap_XHandle, noiseMap__handle__), false)!;
			GC.KeepAlive (noiseMap);
			return ret!;
		}
		[Export ("textureWithRect:inTexture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTexture FromRectangle (CGRect rect, SKTexture texture)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			SKTexture? ret;
			ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_NativeHandle (class_ptr, selTextureWithRect_InTexture_XHandle, rect, texture__handle__), false)!;
			GC.KeepAlive (texture);
			return ret!;
		}
		/// <param name="smoothness">To be added.</param><param name="size">To be added.</param><param name="grayscale">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textureNoiseWithSmoothness:size:grayscale:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTexture FromTextureNoise (nfloat smoothness, CGSize size, bool grayscale)
		{
			SKTexture ret;
			ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_CGSize_bool (class_ptr, selTextureNoiseWithSmoothness_Size_Grayscale_XHandle, smoothness, size, grayscale ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		/// <param name="smoothness">To be added.</param><param name="size">To be added.</param><summary>Creates a texture that consists of randomized directional noise data, with the RGB values comprising a direction vector, and the alpha channel representing a magnitude.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textureVectorNoiseWithSmoothness:size:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTexture FromTextureVectorNoise (nfloat smoothness, CGSize size)
		{
			SKTexture ret;
			ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_CGSize (class_ptr, selTextureVectorNoiseWithSmoothness_Size_XHandle, smoothness, size), false)!;
			return ret;
		}
		[Export ("preloadWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Preload ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPreloadWithCompletionHandler_XHandle, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPreloadWithCompletionHandler_XHandle, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Asynchronously loads the texture into memory.</summary>
		/// <returns>A task that represents the asynchronous Preload operation</returns>
		/// <remarks>
		///           <para copied="true">The PreloadAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task PreloadAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			Preload(() => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("preloadTextures:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PreloadTextures (SKTexture[] textures, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (textures is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textures));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var nsa_textures = NSArray.FromNSObjects (textures);
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selPreloadTextures_WithCompletionHandler_XHandle, nsa_textures.Handle, (IntPtr) block_ptr_completion);
		}
		/// <param name="textures">To be added.</param>
		/// <summary>Asynchronously loads the textures into memory.</summary>
		/// <returns>A task that represents the asynchronous PreloadTextures operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task PreloadTexturesAsync (SKTexture[] textures)
		{
			var tcs = new TaskCompletionSource<bool> ();
			PreloadTextures(textures, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("textureByApplyingCIFilter:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKTexture TextureByApplyingCIFilter (global::CoreImage.CIFilter filter)
		{
			var filter__handle__ = filter!.GetNonNullHandle (nameof (filter));
			SKTexture? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selTextureByApplyingCIFilter_XHandle, filter__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selTextureByApplyingCIFilter_XHandle, filter__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (filter);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CGImage CGImage {
			[Export ("CGImage")]
			get {
				CGImage ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCGImageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCGImageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKTextureFilteringMode FilteringMode {
			[Export ("filteringMode")]
			get {
				SKTextureFilteringMode ret;
				if (IsDirectBinding) {
					ret = (SKTextureFilteringMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFilteringModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SKTextureFilteringMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selFilteringModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFilteringMode:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFilteringMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetFilteringMode_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize Size {
			[Export ("size")]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect TextureRect {
			[Export ("textureRect")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selTextureRectXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selTextureRectXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selTextureRectXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selTextureRectXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesMipmaps {
			[Export ("usesMipmaps")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesMipmapsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesMipmapsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesMipmaps:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesMipmaps_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesMipmaps_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class SKTexture */
}
