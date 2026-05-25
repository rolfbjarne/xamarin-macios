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
namespace AppKit {
	[Register("NSBitmapImageRep", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSBitmapImageRep : NSImageRep, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCGImageX = "CGImage";
		static readonly NativeHandle selCGImageXHandle = Selector.GetHandle ("CGImage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTIFFRepresentationX = "TIFFRepresentation";
		static readonly NativeHandle selTIFFRepresentationXHandle = Selector.GetHandle ("TIFFRepresentation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTIFFRepresentationOfImageRepsInArray_X = "TIFFRepresentationOfImageRepsInArray:";
		static readonly NativeHandle selTIFFRepresentationOfImageRepsInArray_XHandle = Selector.GetHandle ("TIFFRepresentationOfImageRepsInArray:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTIFFRepresentationOfImageRepsInArray_UsingCompression_Factor_X = "TIFFRepresentationOfImageRepsInArray:usingCompression:factor:";
		static readonly NativeHandle selTIFFRepresentationOfImageRepsInArray_UsingCompression_Factor_XHandle = Selector.GetHandle ("TIFFRepresentationOfImageRepsInArray:usingCompression:factor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTIFFRepresentationUsingCompression_Factor_X = "TIFFRepresentationUsingCompression:factor:";
		static readonly NativeHandle selTIFFRepresentationUsingCompression_Factor_XHandle = Selector.GetHandle ("TIFFRepresentationUsingCompression:factor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBitmapDataX = "bitmapData";
		static readonly NativeHandle selBitmapDataXHandle = Selector.GetHandle ("bitmapData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBitmapFormatX = "bitmapFormat";
		static readonly NativeHandle selBitmapFormatXHandle = Selector.GetHandle ("bitmapFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBitmapImageRepByConvertingToColorSpace_RenderingIntent_X = "bitmapImageRepByConvertingToColorSpace:renderingIntent:";
		static readonly NativeHandle selBitmapImageRepByConvertingToColorSpace_RenderingIntent_XHandle = Selector.GetHandle ("bitmapImageRepByConvertingToColorSpace:renderingIntent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBitmapImageRepByRetaggingWithColorSpace_X = "bitmapImageRepByRetaggingWithColorSpace:";
		static readonly NativeHandle selBitmapImageRepByRetaggingWithColorSpace_XHandle = Selector.GetHandle ("bitmapImageRepByRetaggingWithColorSpace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBitsPerPixelX = "bitsPerPixel";
		static readonly NativeHandle selBitsPerPixelXHandle = Selector.GetHandle ("bitsPerPixel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBytesPerPlaneX = "bytesPerPlane";
		static readonly NativeHandle selBytesPerPlaneXHandle = Selector.GetHandle ("bytesPerPlane");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBytesPerRowX = "bytesPerRow";
		static readonly NativeHandle selBytesPerRowXHandle = Selector.GetHandle ("bytesPerRow");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanBeCompressedUsing_X = "canBeCompressedUsing:";
		static readonly NativeHandle selCanBeCompressedUsing_XHandle = Selector.GetHandle ("canBeCompressedUsing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorAtX_Y_X = "colorAtX:y:";
		static readonly NativeHandle selColorAtX_Y_XHandle = Selector.GetHandle ("colorAtX:y:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorSpaceX = "colorSpace";
		static readonly NativeHandle selColorSpaceXHandle = Selector.GetHandle ("colorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorizeByMappingGray_ToColor_BlackMapping_WhiteMapping_X = "colorizeByMappingGray:toColor:blackMapping:whiteMapping:";
		static readonly NativeHandle selColorizeByMappingGray_ToColor_BlackMapping_WhiteMapping_XHandle = Selector.GetHandle ("colorizeByMappingGray:toColor:blackMapping:whiteMapping:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetBitmapDataPlanes_X = "getBitmapDataPlanes:";
		static readonly NativeHandle selGetBitmapDataPlanes_XHandle = Selector.GetHandle ("getBitmapDataPlanes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetCompression_Factor_X = "getCompression:factor:";
		static readonly NativeHandle selGetCompression_Factor_XHandle = Selector.GetHandle ("getCompression:factor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageRepWithData_X = "imageRepWithData:";
		static readonly NativeHandle selImageRepWithData_XHandle = Selector.GetHandle ("imageRepWithData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageRepsWithData_X = "imageRepsWithData:";
		static readonly NativeHandle selImageRepsWithData_XHandle = Selector.GetHandle ("imageRepsWithData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIncrementalLoadFromData_Complete_X = "incrementalLoadFromData:complete:";
		static readonly NativeHandle selIncrementalLoadFromData_Complete_XHandle = Selector.GetHandle ("incrementalLoadFromData:complete:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithBitmapDataPlanes_PixelsWide_PixelsHigh_BitsPerSample_SamplesPerPixel_HasAlpha_IsPlanar_ColorSpaceName_BitmapFormat_BytesPerRow_BitsPerPixel_X = "initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bitmapFormat:bytesPerRow:bitsPerPixel:";
		static readonly NativeHandle selInitWithBitmapDataPlanes_PixelsWide_PixelsHigh_BitsPerSample_SamplesPerPixel_HasAlpha_IsPlanar_ColorSpaceName_BitmapFormat_BytesPerRow_BitsPerPixel_XHandle = Selector.GetHandle ("initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bitmapFormat:bytesPerRow:bitsPerPixel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithBitmapDataPlanes_PixelsWide_PixelsHigh_BitsPerSample_SamplesPerPixel_HasAlpha_IsPlanar_ColorSpaceName_BytesPerRow_BitsPerPixel_X = "initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bytesPerRow:bitsPerPixel:";
		static readonly NativeHandle selInitWithBitmapDataPlanes_PixelsWide_PixelsHigh_BitsPerSample_SamplesPerPixel_HasAlpha_IsPlanar_ColorSpaceName_BytesPerRow_BitsPerPixel_XHandle = Selector.GetHandle ("initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bytesPerRow:bitsPerPixel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCGImage_X = "initWithCGImage:";
		static readonly NativeHandle selInitWithCGImage_XHandle = Selector.GetHandle ("initWithCGImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCIImage_X = "initWithCIImage:";
		static readonly NativeHandle selInitWithCIImage_XHandle = Selector.GetHandle ("initWithCIImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithData_X = "initWithData:";
		static readonly NativeHandle selInitWithData_XHandle = Selector.GetHandle ("initWithData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFocusedViewRect_X = "initWithFocusedViewRect:";
		static readonly NativeHandle selInitWithFocusedViewRect_XHandle = Selector.GetHandle ("initWithFocusedViewRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPlanarX = "isPlanar";
		static readonly NativeHandle selIsPlanarXHandle = Selector.GetHandle ("isPlanar");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedNameForTIFFCompressionType_X = "localizedNameForTIFFCompressionType:";
		static readonly NativeHandle selLocalizedNameForTIFFCompressionType_XHandle = Selector.GetHandle ("localizedNameForTIFFCompressionType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfPlanesX = "numberOfPlanes";
		static readonly NativeHandle selNumberOfPlanesXHandle = Selector.GetHandle ("numberOfPlanes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRepresentationUsingType_Properties_X = "representationUsingType:properties:";
		static readonly NativeHandle selRepresentationUsingType_Properties_XHandle = Selector.GetHandle ("representationUsingType:properties:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSamplesPerPixelX = "samplesPerPixel";
		static readonly NativeHandle selSamplesPerPixelXHandle = Selector.GetHandle ("samplesPerPixel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetColor_AtX_Y_X = "setColor:atX:y:";
		static readonly NativeHandle selSetColor_AtX_Y_XHandle = Selector.GetHandle ("setColor:atX:y:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCompression_Factor_X = "setCompression:factor:";
		static readonly NativeHandle selSetCompression_Factor_XHandle = Selector.GetHandle ("setCompression:factor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSBitmapImageRep");
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
		public NSBitmapImageRep (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		protected NSBitmapImageRep (NSObjectFlag t) : base (t)
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
		protected internal NSBitmapImageRep (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFocusedViewRect:")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'NSView.CacheDisplay()' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSBitmapImageRep (CGRect rect)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selInitWithFocusedViewRect_XHandle, rect), "initWithFocusedViewRect:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selInitWithFocusedViewRect_XHandle, rect), "initWithFocusedViewRect:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bytesPerRow:bitsPerPixel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSBitmapImageRep (nint planes, nint width, nint height, nint bps, nint spp, bool alpha, bool isPlanar, string colorSpaceName, nint rBytes, nint pBits)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (colorSpaceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (colorSpaceName));
			var nscolorSpaceName = CFString.CreateNative (colorSpaceName);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool_bool_NativeHandle_IntPtr_IntPtr (this.Handle, selInitWithBitmapDataPlanes_PixelsWide_PixelsHigh_BitsPerSample_SamplesPerPixel_HasAlpha_IsPlanar_ColorSpaceName_BytesPerRow_BitsPerPixel_XHandle, planes, width, height, bps, spp, alpha ? (byte) 1 : (byte) 0, isPlanar ? (byte) 1 : (byte) 0, nscolorSpaceName, rBytes, pBits), "initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bytesPerRow:bitsPerPixel:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool_bool_NativeHandle_IntPtr_IntPtr (&__objc_super__, selInitWithBitmapDataPlanes_PixelsWide_PixelsHigh_BitsPerSample_SamplesPerPixel_HasAlpha_IsPlanar_ColorSpaceName_BytesPerRow_BitsPerPixel_XHandle, planes, width, height, bps, spp, alpha ? (byte) 1 : (byte) 0, isPlanar ? (byte) 1 : (byte) 0, nscolorSpaceName, rBytes, pBits), "initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bytesPerRow:bitsPerPixel:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscolorSpaceName);
		}
		[Export ("initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bitmapFormat:bytesPerRow:bitsPerPixel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSBitmapImageRep (nint planes, nint width, nint height, nint bps, nint spp, bool alpha, bool isPlanar, string colorSpaceName, NSBitmapFormat bitmapFormat, nint rBytes, nint pBits)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (colorSpaceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (colorSpaceName));
			var nscolorSpaceName = CFString.CreateNative (colorSpaceName);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool_bool_NativeHandle_UIntPtr_IntPtr_IntPtr (this.Handle, selInitWithBitmapDataPlanes_PixelsWide_PixelsHigh_BitsPerSample_SamplesPerPixel_HasAlpha_IsPlanar_ColorSpaceName_BitmapFormat_BytesPerRow_BitsPerPixel_XHandle, planes, width, height, bps, spp, alpha ? (byte) 1 : (byte) 0, isPlanar ? (byte) 1 : (byte) 0, nscolorSpaceName, (UIntPtr) (ulong) bitmapFormat, rBytes, pBits), "initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bitmapFormat:bytesPerRow:bitsPerPixel:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool_bool_NativeHandle_UIntPtr_IntPtr_IntPtr (&__objc_super__, selInitWithBitmapDataPlanes_PixelsWide_PixelsHigh_BitsPerSample_SamplesPerPixel_HasAlpha_IsPlanar_ColorSpaceName_BitmapFormat_BytesPerRow_BitsPerPixel_XHandle, planes, width, height, bps, spp, alpha ? (byte) 1 : (byte) 0, isPlanar ? (byte) 1 : (byte) 0, nscolorSpaceName, (UIntPtr) (ulong) bitmapFormat, rBytes, pBits), "initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bitmapFormat:bytesPerRow:bitsPerPixel:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscolorSpaceName);
		}
		[Export ("initWithCGImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSBitmapImageRep (CGImage cgImage)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var cgImage__handle__ = cgImage!.GetNonNullHandle (nameof (cgImage));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithCGImage_XHandle, cgImage.Handle), "initWithCGImage:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithCGImage_XHandle, cgImage.Handle), "initWithCGImage:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cgImage);
		}
		[Export ("initWithCIImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSBitmapImageRep (global::CoreImage.CIImage ciImage)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var ciImage__handle__ = ciImage!.GetNonNullHandle (nameof (ciImage));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithCIImage_XHandle, ciImage__handle__), "initWithCIImage:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithCIImage_XHandle, ciImage__handle__), "initWithCIImage:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ciImage);
		}
		[Export ("initWithData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSBitmapImageRep (NSData data)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithData_XHandle, data__handle__), "initWithData:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithData_XHandle, data__handle__), "initWithData:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
		}
		[Export ("canBeCompressedUsing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanBeCompressedUsing (NSTiffCompression compression)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (this.Handle, selCanBeCompressedUsing_XHandle, (UIntPtr) (ulong) compression);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_UIntPtr (&__objc_super__, selCanBeCompressedUsing_XHandle, (UIntPtr) (ulong) compression);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("colorAtX:y:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColor? ColorAt (nint x, nint y)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSColor ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr (this.Handle, selColorAtX_Y_XHandle, x, y), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selColorAtX_Y_XHandle, x, y), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("colorizeByMappingGray:toColor:blackMapping:whiteMapping:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Colorize (nfloat midPoint, NSColor? midPointColor, NSColor? shadowColor, NSColor? lightColor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var midPointColor__handle__ = midPointColor.GetHandle ();
			var shadowColor__handle__ = shadowColor.GetHandle ();
			var lightColor__handle__ = lightColor.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat_NativeHandle_NativeHandle_NativeHandle (this.Handle, selColorizeByMappingGray_ToColor_BlackMapping_WhiteMapping_XHandle, midPoint, midPointColor__handle__, shadowColor__handle__, lightColor__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selColorizeByMappingGray_ToColor_BlackMapping_WhiteMapping_XHandle, midPoint, midPointColor__handle__, shadowColor__handle__, lightColor__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (midPointColor);
			GC.KeepAlive (shadowColor);
			GC.KeepAlive (lightColor);
		}
		[Export ("bitmapImageRepByConvertingToColorSpace:renderingIntent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSBitmapImageRep? ConvertingToColorSpace (NSColorSpace targetSpace, NSColorRenderingIntent renderingIntent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var targetSpace__handle__ = targetSpace!.GetNonNullHandle (nameof (targetSpace));
			NSBitmapImageRep? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSBitmapImageRep> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, selBitmapImageRepByConvertingToColorSpace_RenderingIntent_XHandle, targetSpace__handle__, (IntPtr) (long) renderingIntent), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSBitmapImageRep> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selBitmapImageRepByConvertingToColorSpace_RenderingIntent_XHandle, targetSpace__handle__, (IntPtr) (long) renderingIntent), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (targetSpace);
			return ret!;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual void EncodeTo (NSCoder encoder)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		[Export ("getBitmapDataPlanes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GetBitmapDataPlanes (nint data)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selGetBitmapDataPlanes_XHandle, data);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selGetBitmapDataPlanes_XHandle, data);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("getCompression:factor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetCompressionFactor (out NSTiffCompression compression, out float factor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSTiffCompression* compression__pointer = &compression) {
			fixed (float* factor__pointer = &factor) {
			compression = default;
			factor = default;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_out_NSTiffCompression_out_Single (this.Handle, selGetCompression_Factor_XHandle, compression__pointer, factor__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_out_NSTiffCompression_out_Single (&__objc_super__, selGetCompression_Factor_XHandle, compression__pointer, factor__pointer);
					GC.KeepAlive (this);
				}
			}
			}
			}
		}
		[Export ("imageRepWithData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSImageRep? ImageRepFromData (NSData data)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			NSImageRep? ret;
			ret =  Runtime.GetNSObject<NSImageRep> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selImageRepWithData_XHandle, data__handle__), false)!;
			GC.KeepAlive (data);
			return ret!;
		}
		[Export ("imageRepsWithData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSImageRep[] ImageRepsWithData (NSData data)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			NSImageRep[]? ret;
			ret = CFArray.ArrayFromHandle<NSImageRep>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selImageRepsWithData_XHandle, data__handle__), false)!;
			GC.KeepAlive (data);
			return ret!;
		}
		[Export ("TIFFRepresentationOfImageRepsInArray:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData? ImagesAsTiff (NSImageRep[] imageReps)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (imageReps is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (imageReps));
			using var nsa_imageReps = NSArray.FromNSObjects (imageReps);
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selTIFFRepresentationOfImageRepsInArray_XHandle, nsa_imageReps.Handle), false)!;
			return ret;
		}
		[Export ("TIFFRepresentationOfImageRepsInArray:usingCompression:factor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData? ImagesAsTiff (NSImageRep[] imageReps, NSTiffCompression comp, float factor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (imageReps is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (imageReps));
			using var nsa_imageReps = NSArray.FromNSObjects (imageReps);
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_float (class_ptr, selTIFFRepresentationOfImageRepsInArray_UsingCompression_Factor_XHandle, nsa_imageReps.Handle, (UIntPtr) (ulong) comp, factor), false)!;
			return ret;
		}
		[Export ("incrementalLoadFromData:complete:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint IncrementalLoad (NSData data, bool complete)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_bool (this.Handle, selIncrementalLoadFromData_Complete_XHandle, data__handle__, complete ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selIncrementalLoadFromData_Complete_XHandle, data__handle__, complete ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			return ret!;
		}
		[Export ("localizedNameForTIFFCompressionType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? LocalizedNameForTiffCompressionType (NSTiffCompression compression)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (class_ptr, selLocalizedNameForTIFFCompressionType_XHandle, (UIntPtr) (ulong) compression), false)!;
			return ret;
		}
		[Export ("representationUsingType:properties:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? RepresentationUsingTypeProperties (NSBitmapImageFileType storageType, NSDictionary properties)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var properties__handle__ = properties!.GetNonNullHandle (nameof (properties));
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle (this.Handle, selRepresentationUsingType_Properties_XHandle, (UIntPtr) (ulong) storageType, properties__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, selRepresentationUsingType_Properties_XHandle, (UIntPtr) (ulong) storageType, properties__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (properties);
			return ret!;
		}
		[Export ("bitmapImageRepByRetaggingWithColorSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSBitmapImageRep? RetaggedWithColorSpace (NSColorSpace newSpace)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var newSpace__handle__ = newSpace!.GetNonNullHandle (nameof (newSpace));
			NSBitmapImageRep? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSBitmapImageRep> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selBitmapImageRepByRetaggingWithColorSpace_XHandle, newSpace__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSBitmapImageRep> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selBitmapImageRepByRetaggingWithColorSpace_XHandle, newSpace__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newSpace);
			return ret!;
		}
		[Export ("setColor:atX:y:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetColorAt (NSColor color, nint x, nint y)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var color__handle__ = color!.GetNonNullHandle (nameof (color));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr (this.Handle, selSetColor_AtX_Y_XHandle, color__handle__, x, y);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_IntPtr (&__objc_super__, selSetColor_AtX_Y_XHandle, color__handle__, x, y);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (color);
		}
		[Export ("setCompression:factor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCompressionFactor (NSTiffCompression compression, float factor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_float (this.Handle, selSetCompression_Factor_XHandle, (UIntPtr) (ulong) compression, factor);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_float (&__objc_super__, selSetCompression_Factor_XHandle, (UIntPtr) (ulong) compression, factor);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("TIFFRepresentationUsingCompression:factor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? TiffRepresentationUsingCompressionFactor (NSTiffCompression comp, float factor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSData ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_float (this.Handle, selTIFFRepresentationUsingCompression_Factor_XHandle, (UIntPtr) (ulong) comp, factor), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_float (&__objc_super__, selTIFFRepresentationUsingCompression_Factor_XHandle, (UIntPtr) (ulong) comp, factor), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint BitmapData {
			[Export ("bitmapData")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBitmapDataXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selBitmapDataXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSBitmapFormat BitmapFormat {
			[Export ("bitmapFormat")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSBitmapFormat ret;
				if (IsDirectBinding) {
					ret = (NSBitmapFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selBitmapFormatXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSBitmapFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selBitmapFormatXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint BitsPerPixel {
			[Export ("bitsPerPixel")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBitsPerPixelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selBitsPerPixelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint BytesPerPlane {
			[Export ("bytesPerPlane")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBytesPerPlaneXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selBytesPerPlaneXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint BytesPerRow {
			[Export ("bytesPerRow")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBytesPerRowXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selBytesPerRowXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGImage? CGImage {
			[Export ("CGImage")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
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
		public virtual NSColorSpace ColorSpace {
			[Export ("colorSpace")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSColorSpace? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selColorSpaceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selColorSpaceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsPlanar {
			[Export ("isPlanar")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPlanarXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsPlanarXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Planes {
			[Export ("numberOfPlanes")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfPlanesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfPlanesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SamplesPerPixel {
			[Export ("samplesPerPixel")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSamplesPerPixelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selSamplesPerPixelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? TiffRepresentation {
			[Export ("TIFFRepresentation")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTIFFRepresentationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTIFFRepresentationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColorSyncProfileData;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSImageColorSyncProfileData",  "AppKit")]
		public static NSString ColorSyncProfileData {
			get {
				if (_ColorSyncProfileData is null)
					_ColorSyncProfileData = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSImageColorSyncProfileData")!;
				return _ColorSyncProfileData;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CompressionFactor;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSImageCompressionFactor",  "AppKit")]
		public static NSString CompressionFactor {
			get {
				if (_CompressionFactor is null)
					_CompressionFactor = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSImageCompressionFactor")!;
				return _CompressionFactor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CompressionMethod;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSImageCompressionMethod",  "AppKit")]
		public static NSString CompressionMethod {
			get {
				if (_CompressionMethod is null)
					_CompressionMethod = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSImageCompressionMethod")!;
				return _CompressionMethod;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CurrentFrame;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSImageCurrentFrame",  "AppKit")]
		public static NSString CurrentFrame {
			get {
				if (_CurrentFrame is null)
					_CurrentFrame = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSImageCurrentFrame")!;
				return _CurrentFrame;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CurrentFrameDuration;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSImageCurrentFrameDuration",  "AppKit")]
		public static NSString CurrentFrameDuration {
			get {
				if (_CurrentFrameDuration is null)
					_CurrentFrameDuration = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSImageCurrentFrameDuration")!;
				return _CurrentFrameDuration;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DitherTransparency;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSImageDitherTransparency",  "AppKit")]
		public static NSString DitherTransparency {
			get {
				if (_DitherTransparency is null)
					_DitherTransparency = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSImageDitherTransparency")!;
				return _DitherTransparency;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EXIFData;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSImageEXIFData",  "AppKit")]
		public static NSString EXIFData {
			get {
				if (_EXIFData is null)
					_EXIFData = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSImageEXIFData")!;
				return _EXIFData;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FallbackBackgroundColor;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSImageFallbackBackgroundColor",  "AppKit")]
		public static NSString FallbackBackgroundColor {
			get {
				if (_FallbackBackgroundColor is null)
					_FallbackBackgroundColor = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSImageFallbackBackgroundColor")!;
				return _FallbackBackgroundColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FrameCount;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSImageFrameCount",  "AppKit")]
		public static NSString FrameCount {
			get {
				if (_FrameCount is null)
					_FrameCount = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSImageFrameCount")!;
				return _FrameCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Gamma;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSImageGamma",  "AppKit")]
		public static NSString Gamma {
			get {
				if (_Gamma is null)
					_Gamma = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSImageGamma")!;
				return _Gamma;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Interlaced;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSImageInterlaced",  "AppKit")]
		public static NSString Interlaced {
			get {
				if (_Interlaced is null)
					_Interlaced = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSImageInterlaced")!;
				return _Interlaced;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IptcData;
		/// <summary>Represents the value associated with the constant 'NSImageIPTCData'.</summary>
		[Field ("NSImageIPTCData",  "AppKit")]
		public static NSString IptcData {
			get {
				if (_IptcData is null)
					_IptcData = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSImageIPTCData")!;
				return _IptcData;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LoopCount;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSImageLoopCount",  "AppKit")]
		public static NSString LoopCount {
			get {
				if (_LoopCount is null)
					_LoopCount = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSImageLoopCount")!;
				return _LoopCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Progressive;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSImageProgressive",  "AppKit")]
		public static NSString Progressive {
			get {
				if (_Progressive is null)
					_Progressive = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSImageProgressive")!;
				return _Progressive;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RGBColorTable;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSImageRGBColorTable",  "AppKit")]
		public static NSString RGBColorTable {
			get {
				if (_RGBColorTable is null)
					_RGBColorTable = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSImageRGBColorTable")!;
				return _RGBColorTable;
			}
		}
	} /* class NSBitmapImageRep */
}
