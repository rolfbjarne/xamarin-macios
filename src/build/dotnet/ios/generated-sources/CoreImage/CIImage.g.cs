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
	/// <summary>Represents a set of instructions to create an image for use by CoreImage.</summary><remarks><para>
	/// 	Unlike CoreGraphics images (<see cref="T:CoreGraphics.CGImage" />) that are objects
	/// 	that hold the actual image data to be processed, CIImages
	/// 	represents a set of instructions to obtain an image.  These
	/// 	recipes are used during the CoreImage filtering, analysis or rendering
	/// 	pipeline to actually create the bitmap representation.   
	/// 
	/// </para><para>
	/// 	CIImages are either the result of loading an image from disk,
	/// 	an NSData array, a CoreVideo buffer a CoreGraphics image, or
	/// 	the result of processing an image pipeline by CoreImage.
	/// 
	/// </para><para>
	/// 	CIImages for example are used when chaining various filters
	/// 	(<see cref="T:CoreImage.CIFilter" />) together and
	/// 	only their abstract representation is passed between the
	/// 	output of one filter and the input to another one.  The image
	/// 	might not even reside in the main memory, it could reside
	/// 	entirely on the GPU space as an intermediate step between two
	/// 	filters.
	/// 
	/// </para><format type="text/html"><h2>Auto Enhancement Filters</h2></format><para>
	/// 	The <see cref="CoreImage.CIImage.GetAutoAdjustmentFilters(CoreImage.CIAutoAdjustmentFilterOptions)" />
	/// 	method can be used to obtain a list of CIImage filters that
	/// 	can be used to correct various problems found in photos.
	/// 
	/// </para><para>
	/// 	These typically include:
	/// 
	/// 	<list type="bullet"><item><term>
	/// 	      Adjusts the shadow details (using the <see cref="T:CoreImage.CIHighlightShadowAdjust" /> filter).
	/// 	    </term></item><item><term>
	/// 	      Adjusts the image contrast (using the <see cref="T:CoreImage.CIToneCurve" /> filter).
	/// 	    </term></item><item><term>
	/// 	      Adjusts the image saturation (using the <see cref="T:CoreImage.CIVibrance" /> filter).
	/// 	    </term></item><item><term>
	/// 	      Adjusts the face color balance, adjust the tone of the skin (using the <see cref="T:CoreImage.CIFaceBalance" /> filter).
	/// 	    </term></item></list></para><para>
	/// 	You can configure which kind of filters you want to get or
	/// 	configure by setting the properties of an <see cref="CoreImage.CIAutoAdjustmentFilterOptions" />
	/// 	instance and then calling the appropriate method.
	/// 
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// void PrepareFixes (CIImage img)
	/// {
	/// var opt = new CIAutoAdjustmentFilterOptions () {
	/// 	RedEye = true,
	/// 	AutoAdjustCrop = true
	/// };
	/// foreach (var filter in img.GetAutoAdjustmentFilters (opt)) {
	/// 	filter.Image = img;
	/// 	img = filter.OutputImage;
	/// }
	/// }
	/// ]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIImage_Class/index.html">Apple documentation for <c>CIImage</c></related>
	[Register("CIImage", true)]
	public unsafe partial class CIImage : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CIImage");
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
		public CIImage (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
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
		protected CIImage (NSObjectFlag t) : base (t)
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
		protected internal CIImage (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="image">CoreGraphics image.</param><summary>Initializes a CoreImage Image from a CoreGraphics bitmap representation</summary><remarks></remarks>
		[Export ("initWithCGImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (CGImage image)
			: base (NSObjectFlag.Empty)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithCGImage:"), image.Handle), "initWithCGImage:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithCGImage:"), image.Handle), "initWithCGImage:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="image">CoreGraphics image.</param><param name="d"><para>Metadata to initialize with, as an NSDictionary.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Initializes a CoreImage Image from a CoreGraphics bitmap representation</summary><remarks></remarks>
		[Export ("initWithCGImage:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (CGImage image, NSDictionary? d)
			: base (NSObjectFlag.Empty)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var d__handle__ = d.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithCGImage:options:"), image.Handle, d__handle__), "initWithCGImage:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithCGImage:options:"), image.Handle, d__handle__), "initWithCGImage:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			GC.KeepAlive (d);
		}
		/// <param name="image">CoreGraphics image.</param><param name="options">Options to initialize the image with.</param><summary>Initializes a CoreImage Image from a CoreGraphics bitmap representation</summary><remarks></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (CGImage image, CIImageInitializationOptionsWithMetadata? options)
			: this (image, options.GetDictionary ())
		{
		}
		[Export ("initWithCGImageSource:index:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::ImageIO.CGImageSource source, nuint index, NSDictionary? options)
			: base (NSObjectFlag.Empty)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var options__handle__ = options.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("initWithCGImageSource:index:options:"), source.Handle, index, options__handle__), "initWithCGImageSource:index:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithCGImageSource:index:options:"), source.Handle, index, options__handle__), "initWithCGImageSource:index:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
			GC.KeepAlive (options);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::ImageIO.CGImageSource source, nuint index, CIImageInitializationOptionsWithMetadata options)
			: this (source, index, options.GetDictionary ())
		{
		}
		/// <param name="data">Image data, in a format supported by the system.</param><summary>Creates a new CIImage from the specified data.   The image data must be premultiplied.</summary><remarks></remarks>
		[Export ("initWithData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (NSData data)
			: base (NSObjectFlag.Empty)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithData:"), data__handle__), "initWithData:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithData:"), data__handle__), "initWithData:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
		}
		/// <param name="data">Image data, in a format supported by the system.</param><param name="d"><para>Extra configuration options, as an NSDictionary.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a new CIImage from the specified data.   The image data must be premultiplied.</summary><remarks></remarks>
		[Export ("initWithData:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (NSData data, NSDictionary? d)
			: base (NSObjectFlag.Empty)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var d__handle__ = d.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithData:options:"), data__handle__, d__handle__), "initWithData:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithData:options:"), data__handle__, d__handle__), "initWithData:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			GC.KeepAlive (d);
		}
		/// <param name="data">Image data, in a format supported by the system.</param><param name="options">Options to initialize the image with.</param><summary>Creates a new CIImage from the specified data.   The image data must be premultiplied.</summary><remarks></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (NSData data, CIImageInitializationOptionsWithMetadata? options)
			: this (data, options.GetDictionary ())
		{
		}
		/// <param name="d">To be added.</param><param name="bytesPerRow">To be added.</param><param name="size">To be added.</param><param name="pixelFormat">To be added.</param><param name="colorSpace"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithBitmapData:bytesPerRow:size:format:colorSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (NSData d, nint bytesPerRow, CGSize size, int pixelFormat, CGColorSpace? colorSpace)
			: base (NSObjectFlag.Empty)
		{
			var d__handle__ = d!.GetNonNullHandle (nameof (d));
			var colorSpace__handle__ = colorSpace.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_CGSize_int_NativeHandle (this.Handle, Selector.GetHandle ("initWithBitmapData:bytesPerRow:size:format:colorSpace:"), d__handle__, bytesPerRow, size, pixelFormat, colorSpace__handle__), "initWithBitmapData:bytesPerRow:size:format:colorSpace:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_CGSize_int_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithBitmapData:bytesPerRow:size:format:colorSpace:"), d__handle__, bytesPerRow, size, pixelFormat, colorSpace__handle__), "initWithBitmapData:bytesPerRow:size:format:colorSpace:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (d);
			GC.KeepAlive (colorSpace);
		}
		/// <param name="glTextureName">To be added.</param><param name="size">To be added.</param><param name="flipped">To be added.</param><param name="colorSpace"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithTexture:size:flipped:colorSpace:")]
		[ObsoletedOSPlatform ("ios12.0")]
		[ObsoletedOSPlatform ("macos10.14")]
		[ObsoletedOSPlatform ("tvos10.14")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (int glTextureName, CGSize size, bool flipped, CGColorSpace? colorSpace)
			: base (NSObjectFlag.Empty)
		{
			var colorSpace__handle__ = colorSpace.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_CGSize_bool_NativeHandle (this.Handle, Selector.GetHandle ("initWithTexture:size:flipped:colorSpace:"), glTextureName, size, flipped ? (byte) 1 : (byte) 0, colorSpace__handle__), "initWithTexture:size:flipped:colorSpace:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int_CGSize_bool_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithTexture:size:flipped:colorSpace:"), glTextureName, size, flipped ? (byte) 1 : (byte) 0, colorSpace__handle__), "initWithTexture:size:flipped:colorSpace:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (colorSpace);
		}
		/// <param name="url">Location of the image data.</param><summary>Initializes a CoreImage image from the contents of the file pointed by the specified url.</summary><remarks></remarks>
		[Export ("initWithContentsOfURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (NSUrl url)
			: base (NSObjectFlag.Empty)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithContentsOfURL:"), url__handle__), "initWithContentsOfURL:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithContentsOfURL:"), url__handle__), "initWithContentsOfURL:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		/// <param name="url">Location of the image data.</param><param name="d"><para>Extra configuration options, as an NSDictionary.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Initializes a CoreImage image from the contents of the file pointed by the specified url.</summary><remarks></remarks>
		[Export ("initWithContentsOfURL:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (NSUrl url, NSDictionary? d)
			: base (NSObjectFlag.Empty)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var d__handle__ = d.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithContentsOfURL:options:"), url__handle__, d__handle__), "initWithContentsOfURL:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithContentsOfURL:options:"), url__handle__, d__handle__), "initWithContentsOfURL:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (d);
		}
		/// <param name="url">Location of the image data.</param><param name="options">Options to initialize the image with.</param><summary>Initializes a CoreImage image from the contents of the file pointed by the specified url.</summary><remarks></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (NSUrl url, CIImageInitializationOptions? options)
			: this (url, options.GetDictionary ())
		{
		}
		/// <param name="surface">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithIOSurface:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::IOSurface.IOSurface surface)
			: base (NSObjectFlag.Empty)
		{
			var surface__handle__ = surface!.GetNonNullHandle (nameof (surface));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithIOSurface:"), surface__handle__), "initWithIOSurface:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithIOSurface:"), surface__handle__), "initWithIOSurface:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (surface);
		}
		/// <param name="surface">To be added.</param><param name="options"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithIOSurface:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::IOSurface.IOSurface surface, NSDictionary? options)
			: base (NSObjectFlag.Empty)
		{
			var surface__handle__ = surface!.GetNonNullHandle (nameof (surface));
			var options__handle__ = options.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithIOSurface:options:"), surface__handle__, options__handle__), "initWithIOSurface:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithIOSurface:options:"), surface__handle__, options__handle__), "initWithIOSurface:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (surface);
			GC.KeepAlive (options);
		}
		/// <param name="surface">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::IOSurface.IOSurface surface, CIImageInitializationOptions? options)
			: this (surface, options.GetDictionary ())
		{
		}
		/// <param name="imageBuffer">CoreVideo image buffer.</param><summary>Initializes a CoreImage image from the contents of the specified CoreVideo image buffer.</summary><remarks></remarks>
		[Export ("initWithCVImageBuffer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::CoreVideo.CVImageBuffer imageBuffer)
			: base (NSObjectFlag.Empty)
		{
			var imageBuffer__handle__ = imageBuffer!.GetNonNullHandle (nameof (imageBuffer));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithCVImageBuffer:"), imageBuffer__handle__), "initWithCVImageBuffer:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithCVImageBuffer:"), imageBuffer__handle__), "initWithCVImageBuffer:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (imageBuffer);
		}
		/// <param name="imageBuffer">Holds the data that is the basis of the image.</param><param name="dict">Dictionary of strings to objects, holding the options to be applied during construction. (See <see cref="T:CoreImage.CIImageInitializationOptions" />)<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Constructs a <see cref="T:CoreImage.CIImage" /> using the options in <paramref name="dict" />.</summary><remarks>To be added.</remarks>
		[Export ("initWithCVImageBuffer:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::CoreVideo.CVImageBuffer imageBuffer, NSDictionary<NSString, NSObject>? dict)
			: base (NSObjectFlag.Empty)
		{
			var imageBuffer__handle__ = imageBuffer!.GetNonNullHandle (nameof (imageBuffer));
			var dict__handle__ = dict.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithCVImageBuffer:options:"), imageBuffer__handle__, dict__handle__), "initWithCVImageBuffer:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithCVImageBuffer:options:"), imageBuffer__handle__, dict__handle__), "initWithCVImageBuffer:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (imageBuffer);
			GC.KeepAlive (dict);
		}
		/// <param name="imageBuffer">To be added.</param><param name="dict">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal CIImage (global::CoreVideo.CVImageBuffer imageBuffer, NSDictionary? dict)
			: base (NSObjectFlag.Empty)
		{
			var imageBuffer__handle__ = imageBuffer!.GetNonNullHandle (nameof (imageBuffer));
			var dict__handle__ = dict.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithCVImageBuffer:options:"), imageBuffer__handle__, dict__handle__), "initWithCVImageBuffer:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithCVImageBuffer:options:"), imageBuffer__handle__, dict__handle__), "initWithCVImageBuffer:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (imageBuffer);
			GC.KeepAlive (dict);
		}
		/// <param name="imageBuffer">CoreVideo image buffer.</param><param name="options">Options to initialize the image with.</param><summary>Initializes a CoreImage image from the contents of the specified CoreVideo image buffer.</summary><remarks></remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::CoreVideo.CVImageBuffer imageBuffer, CIImageInitializationOptions? options)
			: this (imageBuffer, options.GetDictionary ())
		{
		}
		/// <param name="buffer">The pixel buffer that supplies the data for the image.</param><summary>Constructs a <see cref="T:CoreImage.CIImage" /> with the supplied <paramref name="buffer" /> data.</summary><remarks>To be added.</remarks>
		[Export ("initWithCVPixelBuffer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::CoreVideo.CVPixelBuffer buffer)
			: base (NSObjectFlag.Empty)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithCVPixelBuffer:"), buffer__handle__), "initWithCVPixelBuffer:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithCVPixelBuffer:"), buffer__handle__), "initWithCVPixelBuffer:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (buffer);
		}
		/// <param name="buffer">The data that forms the basis of the image.</param><param name="dict"><para>A dictionary of strings to objects defining the options to be applied during construction. (See <see cref="T:CoreImage.CIImageInitializationOptions" />).</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Constructs a <see cref="T:CoreImage.CIImage" /> from the data in <paramref name="buffer" />, applying the options specified in <paramref name="dict" />.</summary><remarks>To be added.</remarks>
		[Export ("initWithCVPixelBuffer:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::CoreVideo.CVPixelBuffer buffer, NSDictionary? dict)
			: base (NSObjectFlag.Empty)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			var dict__handle__ = dict.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithCVPixelBuffer:options:"), buffer__handle__, dict__handle__), "initWithCVPixelBuffer:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithCVPixelBuffer:options:"), buffer__handle__, dict__handle__), "initWithCVPixelBuffer:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (buffer);
			GC.KeepAlive (dict);
		}
		/// <param name="buffer">Holds the data that is the basis of the image.</param><param name="options">The options to be applied during initialization.</param><summary>Constructs a <see cref="T:CoreImage.CIImage" /> using <paramref name="options" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::CoreVideo.CVPixelBuffer buffer, CIImageInitializationOptions? options)
			: this (buffer, options.GetDictionary ())
		{
		}
		/// <param name="color">Color to use for the image.</param><summary>Creates an image with infinite dimensions that is filled with the specified color.</summary><remarks></remarks>
		[Export ("initWithColor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (CIColor color)
			: base (NSObjectFlag.Empty)
		{
			var color__handle__ = color!.GetNonNullHandle (nameof (color));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithColor:"), color__handle__), "initWithColor:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithColor:"), color__handle__), "initWithColor:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (color);
		}
		/// <param name="texture">The <see cref="T:Metal.IMTLTexture" /> that is the basis for the <see cref="T:CoreImage.CIImage" />.</param><param name="options"><para>A dictionary of strings to objects that hold the configuration options.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Constructs a <see cref="T:CoreImage.CIImage" /> using the <paramref name="options" />.</summary><remarks>To be added.</remarks>
		[Export ("initWithMTLTexture:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::Metal.IMTLTexture texture, NSDictionary? options)
			: base (NSObjectFlag.Empty)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			var options__handle__ = options.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithMTLTexture:options:"), texture__handle__, options__handle__), "initWithMTLTexture:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithMTLTexture:options:"), texture__handle__, options__handle__), "initWithMTLTexture:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (texture);
			GC.KeepAlive (options);
		}
		/// <param name="image">UIKit image.</param><summary>Initializes a CoreImage image from a UIKit image.</summary><remarks></remarks>
		[Export ("initWithImage:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::UIKit.UIImage image)
			: base (NSObjectFlag.Empty)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithImage:"), image__handle__), "initWithImage:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithImage:"), image__handle__), "initWithImage:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="image">UIKit image.</param><param name="options"><para>Extra configuration options, as an NSDictionary.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Initializes a CoreImage image from a UIKit image.</summary><remarks></remarks>
		[Export ("initWithImage:options:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::UIKit.UIImage image, NSDictionary? options)
			: base (NSObjectFlag.Empty)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var options__handle__ = options.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithImage:options:"), image__handle__, options__handle__), "initWithImage:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithImage:options:"), image__handle__, options__handle__), "initWithImage:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			GC.KeepAlive (options);
		}
		/// <param name="image">UIKit image.</param><param name="options">Options to initialize the image with.</param><summary>Initializes a CoreImage image from a UIKit image.</summary><remarks></remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::UIKit.UIImage image, CIImageInitializationOptions? options)
			: this (image, options.GetDictionary ())
		{
		}
		[Export ("initWithImageProvider:size::format:colorSpace:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal CIImage (ICIImageProvider provider, nuint width, nuint height, int f, CGColorSpace? colorSpace, NSDictionary? options)
			: base (NSObjectFlag.Empty)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var colorSpace__handle__ = colorSpace.GetHandle ();
			var options__handle__ = options.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_int_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithImageProvider:size::format:colorSpace:options:"), provider__handle__, width, height, f, colorSpace__handle__, options__handle__), "initWithImageProvider:size::format:colorSpace:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr_int_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithImageProvider:size::format:colorSpace:options:"), provider__handle__, width, height, f, colorSpace__handle__, options__handle__), "initWithImageProvider:size::format:colorSpace:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (provider);
			GC.KeepAlive (colorSpace);
			GC.KeepAlive (options);
		}
		/// <param name="matte">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithPortaitEffectsMatte:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::AVFoundation.AVPortraitEffectsMatte matte, NSDictionary? options)
			: base (NSObjectFlag.Empty)
		{
			var matte__handle__ = matte!.GetNonNullHandle (nameof (matte));
			var options__handle__ = options.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithPortaitEffectsMatte:options:"), matte__handle__, options__handle__), "initWithPortaitEffectsMatte:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithPortaitEffectsMatte:options:"), matte__handle__, options__handle__), "initWithPortaitEffectsMatte:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (matte);
			GC.KeepAlive (options);
		}
		/// <param name="matte">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithPortaitEffectsMatte:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::AVFoundation.AVPortraitEffectsMatte matte)
			: base (NSObjectFlag.Empty)
		{
			var matte__handle__ = matte!.GetNonNullHandle (nameof (matte));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithPortaitEffectsMatte:"), matte__handle__), "initWithPortaitEffectsMatte:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithPortaitEffectsMatte:"), matte__handle__), "initWithPortaitEffectsMatte:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (matte);
		}
		[Export ("initWithSemanticSegmentationMatte:options:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::AVFoundation.AVSemanticSegmentationMatte matte, NSDictionary? options)
			: base (NSObjectFlag.Empty)
		{
			var matte__handle__ = matte!.GetNonNullHandle (nameof (matte));
			var options__handle__ = options.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithSemanticSegmentationMatte:options:"), matte__handle__, options__handle__), "initWithSemanticSegmentationMatte:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithSemanticSegmentationMatte:options:"), matte__handle__, options__handle__), "initWithSemanticSegmentationMatte:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (matte);
			GC.KeepAlive (options);
		}
		[Export ("initWithSemanticSegmentationMatte:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::AVFoundation.AVSemanticSegmentationMatte matte)
			: base (NSObjectFlag.Empty)
		{
			var matte__handle__ = matte!.GetNonNullHandle (nameof (matte));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithSemanticSegmentationMatte:"), matte__handle__), "initWithSemanticSegmentationMatte:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithSemanticSegmentationMatte:"), matte__handle__), "initWithSemanticSegmentationMatte:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (matte);
		}
		/// <param name="data">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDepthData:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::AVFoundation.AVDepthData data, NSDictionary? options)
			: base (NSObjectFlag.Empty)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var options__handle__ = options.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithDepthData:options:"), data__handle__, options__handle__), "initWithDepthData:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithDepthData:options:"), data__handle__, options__handle__), "initWithDepthData:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			GC.KeepAlive (options);
		}
		/// <param name="data">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDepthData:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage (global::AVFoundation.AVDepthData data)
			: base (NSObjectFlag.Empty)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithDepthData:"), data__handle__), "initWithDepthData:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithDepthData:"), data__handle__), "initWithDepthData:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
		}
		[Export ("imageByConvertingLabToWorkingSpace")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage ConvertLabToWorkingSpace ()
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("imageByConvertingLabToWorkingSpace")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("imageByConvertingLabToWorkingSpace")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("imageByConvertingWorkingSpaceToLab")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage ConvertWorkingSpaceToLab ()
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("imageByConvertingWorkingSpaceToLab")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("imageByConvertingWorkingSpaceToLab")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
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
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("imageByApplyingGainMap:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateByApplyingGainMap (CIImage gainMap)
		{
			var gainMap__handle__ = gainMap!.GetNonNullHandle (nameof (gainMap));
			CIImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("imageByApplyingGainMap:"), gainMap__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("imageByApplyingGainMap:"), gainMap__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (gainMap);
			return ret!;
		}
		[Export ("imageByApplyingGainMap:headroom:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateByApplyingGainMap (CIImage gainMap, float headroom)
		{
			var gainMap__handle__ = gainMap!.GetNonNullHandle (nameof (gainMap));
			CIImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_float (this.Handle, Selector.GetHandle ("imageByApplyingGainMap:headroom:"), gainMap__handle__, headroom), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_float (&__objc_super__, Selector.GetHandle ("imageByApplyingGainMap:headroom:"), gainMap__handle__, headroom), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (gainMap);
			return ret!;
		}
		/// <param name="sigma">The standard deviation defining the 2D Gaussian.</param><summary>Creates a new <see cref="T:CoreImage.CIImage" /> by applying a Gaussian blur with the provided <paramref name="sigma" />.</summary><returns>To be added.</returns><remarks><para>The 2D Gaussian is defined as:</para><para><img href="~/xml/CoreImage/_images/CoreImage.GaussianEq.png" alt="Result of applying the filter." /></para><para>Where zeta (<c>z</c>) is a vector holding the pixel coordinates and mu (μ) is a vector holding the mean of the Gaussian in either direction.</para><para>The <paramref name="sigma" /> defines the rate of falloff of the Gaussian. Smaller <paramref name="sigma" /> values blur over fewer pixels.</para></remarks>
		[Export ("imageByApplyingGaussianBlurWithSigma:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateByApplyingGaussianBlur (double sigma)
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (this.Handle, Selector.GetHandle ("imageByApplyingGaussianBlurWithSigma:"), sigma), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_Double (&__objc_super__, Selector.GetHandle ("imageByApplyingGaussianBlurWithSigma:"), sigma), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="orientation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageByApplyingCGOrientation:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateByApplyingOrientation (global::ImageIO.CGImagePropertyOrientation orientation)
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (this.Handle, Selector.GetHandle ("imageByApplyingCGOrientation:"), (int)orientation), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int (&__objc_super__, Selector.GetHandle ("imageByApplyingCGOrientation:"), (int)orientation), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="rect">The clipping rectangle.</param><summary>Creates a new <see cref="T:CoreImage.CIImage" /> of infinite extent by cropping this <see cref="T:CoreImage.CIImage" /> to the <paramref name="rect" /> and then extending the pixels at the edges to infinity.</summary><returns>A <see cref="T:CoreImage.CIImage" /> of infinite extent.</returns><remarks>To be added.</remarks>
		[Export ("imageByClampingToRect:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateByClamping (CGRect rect)
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("imageByClampingToRect:"), rect), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("imageByClampingToRect:"), rect), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>Creates a new image by clamping the current image to the rectangle that is defined by its <see cref="P:CoreImage.CIImage.Extent" /> property.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageByClampingToExtent")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateByClampingToExtent ()
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("imageByClampingToExtent")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("imageByClampingToExtent")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="colorSpace">The <see cref="T:CoreGraphics.CGColorSpace" /> to be matched from.</param><summary>Creates a new <see cref="T:CoreGraphics.CGImage" /> by matching colors from <paramref name="colorSpace" /> into the working color space.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageByColorMatchingColorSpaceToWorkingSpace:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage? CreateByColorMatchingColorSpaceToWorkingSpace (CGColorSpace colorSpace)
		{
			var colorSpace__handle__ = colorSpace!.GetNonNullHandle (nameof (colorSpace));
			CIImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("imageByColorMatchingColorSpaceToWorkingSpace:"), colorSpace.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("imageByColorMatchingColorSpaceToWorkingSpace:"), colorSpace.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (colorSpace);
			return ret!;
		}
		/// <param name="colorSpace">The <see cref="T:CoreGraphics.CGColorSpace" /> to be matched.</param><summary>Creates a new <see cref="T:CoreGraphics.CGImage" /> by matching colors from the working space into colors in the specified <paramref name="colorSpace" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageByColorMatchingWorkingSpaceToColorSpace:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage? CreateByColorMatchingWorkingSpaceToColorSpace (CGColorSpace colorSpace)
		{
			var colorSpace__handle__ = colorSpace!.GetNonNullHandle (nameof (colorSpace));
			CIImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("imageByColorMatchingWorkingSpaceToColorSpace:"), colorSpace.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("imageByColorMatchingWorkingSpaceToColorSpace:"), colorSpace.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (colorSpace);
			return ret!;
		}
		/// <param name="dest">To be added.</param><summary>Creates a new image by compositing this <see cref="T:CoreImage.CIImage" /> over <paramref name="dest" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageByCompositingOverImage:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateByCompositingOverImage (CIImage dest)
		{
			var dest__handle__ = dest!.GetNonNullHandle (nameof (dest));
			CIImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("imageByCompositingOverImage:"), dest__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("imageByCompositingOverImage:"), dest__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dest);
			return ret!;
		}
		/// <param name="filterName">To be added.</param><param name="inputParameters"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a new image by applying <paramref name="filterName" /> to this <see cref="T:CoreImage.CIImage" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageByApplyingFilter:withInputParameters:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateByFiltering (string filterName, NSDictionary? inputParameters)
		{
			if (filterName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filterName));
			var inputParameters__handle__ = inputParameters.GetHandle ();
			var nsfilterName = CFString.CreateNative (filterName);
			CIImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("imageByApplyingFilter:withInputParameters:"), nsfilterName, inputParameters__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("imageByApplyingFilter:withInputParameters:"), nsfilterName, inputParameters__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inputParameters);
			CFString.ReleaseNative (nsfilterName);
			return ret!;
		}
		/// <param name="filterName">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageByApplyingFilter:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateByFiltering (string filterName)
		{
			if (filterName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filterName));
			var nsfilterName = CFString.CreateNative (filterName);
			CIImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("imageByApplyingFilter:"), nsfilterName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("imageByApplyingFilter:"), nsfilterName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfilterName);
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageByInsertingIntermediate")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateByInsertingIntermediate ()
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("imageByInsertingIntermediate")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("imageByInsertingIntermediate")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="cache">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageByInsertingIntermediate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateByInsertingIntermediate (bool cache)
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool (this.Handle, Selector.GetHandle ("imageByInsertingIntermediate:"), cache ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("imageByInsertingIntermediate:"), cache ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("imageByInsertingTiledIntermediate")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateByInsertingTiledIntermediate ()
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("imageByInsertingTiledIntermediate")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("imageByInsertingTiledIntermediate")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>Creates a new image whose RGB values are created by multiplying this image's RGB values by this image's alpha value.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageByPremultiplyingAlpha")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateByPremultiplyingAlpha ()
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("imageByPremultiplyingAlpha")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("imageByPremultiplyingAlpha")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageBySamplingLinear")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateBySamplingLinear ()
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("imageBySamplingLinear")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("imageBySamplingLinear")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageBySamplingNearest")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateBySamplingNearest ()
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("imageBySamplingNearest")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("imageBySamplingNearest")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="extent">The area within the image to have alpha 1.0.</param><summary>Creates a new image by copying <c>this</c>, setting the alpha of pixels within <paramref name="extent" /> to 1.0 and setting those outside to 0.0.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageBySettingAlphaOneInExtent:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateBySettingAlphaOne (CGRect extent)
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("imageBySettingAlphaOneInExtent:"), extent), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("imageBySettingAlphaOneInExtent:"), extent), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("imageBySettingContentAverageLightLevel:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateBySettingContentAverageLightLevel (float average)
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float (this.Handle, Selector.GetHandle ("imageBySettingContentAverageLightLevel:"), average), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_float (&__objc_super__, Selector.GetHandle ("imageBySettingContentAverageLightLevel:"), average), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("imageBySettingContentHeadroom:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateBySettingContentHeadroom (float headroom)
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float (this.Handle, Selector.GetHandle ("imageBySettingContentHeadroom:"), headroom), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_float (&__objc_super__, Selector.GetHandle ("imageBySettingContentHeadroom:"), headroom), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="properties">To be added.</param><summary>Creates a new <see cref="T:CoreImage.CIImage" /> by copying <c>this</c>, and applying the <paramref name="properties" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageBySettingProperties:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateBySettingProperties (NSDictionary properties)
		{
			var properties__handle__ = properties!.GetNonNullHandle (nameof (properties));
			CIImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("imageBySettingProperties:"), properties__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("imageBySettingProperties:"), properties__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (properties);
			return ret!;
		}
		/// <summary>Creates a new image whose RGB values are created by dividing this image's RGB values by this image's alpha value.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageByUnpremultiplyingAlpha")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateByUnpremultiplyingAlpha ()
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("imageByUnpremultiplyingAlpha")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("imageByUnpremultiplyingAlpha")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="orientation">To be added.</param><summary>Creates a new image by applying the <paramref name="orientation" /> to this <see cref="T:CoreImage.CIImage" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageByApplyingOrientation:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage CreateWithOrientation (CIImageOrientation orientation)
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (this.Handle, Selector.GetHandle ("imageByApplyingOrientation:"), (int)orientation), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int (&__objc_super__, Selector.GetHandle ("imageByApplyingOrientation:"), (int)orientation), false)!;
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		/// <param name="image">CoreGraphics image.</param><summary>Creates an <see cref="T:CoreImage.CIImage" /> from a <see cref="T:CoreGraphics.CGImage" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithCGImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage FromCGImage (CGImage image)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("imageWithCGImage:"), image.Handle), false)!;
			GC.KeepAlive (image);
			return ret!;
		}
		/// <param name="image">CoreGraphics image.</param><param name="d"><para>Extra metadata, as an NSDictionary.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a <see cref="T:CoreImage.CIImage" />  from a <see cref="T:CoreGraphics.CGImage" /> with the specified metadata,  <paramref name="d" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithCGImage:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage FromCGImage (CGImage image, NSDictionary? d)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var d__handle__ = d.GetHandle ();
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("imageWithCGImage:options:"), image.Handle, d__handle__), false)!;
			GC.KeepAlive (image);
			GC.KeepAlive (d);
			return ret!;
		}
		/// <param name="image">CoreGraphics image.</param><param name="options">Options to initialize the image with.</param><summary>Creates a <see cref="T:CoreImage.CIImage" />  from a <see cref="T:CoreGraphics.CGImage" /> with the specified <paramref name="options" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage FromCGImage (CGImage image, CIImageInitializationOptionsWithMetadata? options)
		{
			return FromCGImage (image, options.GetDictionary ());
		}
		[Export ("imageWithCGImageSource:index:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage FromCGImageSource (global::ImageIO.CGImageSource source, nuint index, NSDictionary? options)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var options__handle__ = options.GetHandle ();
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (class_ptr, Selector.GetHandle ("imageWithCGImageSource:index:options:"), source.Handle, index, options__handle__), false)!;
			GC.KeepAlive (source);
			GC.KeepAlive (options);
			return ret!;
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage FromCGImageSource (global::ImageIO.CGImageSource source, nuint index, CIImageInitializationOptionsWithMetadata? options)
		{
			return FromCGImageSource (source, index, options.GetDictionary ());
		}
		[Export ("imageWithBitmapData:bytesPerRow:size:format:colorSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIImage FromData (NSData bitmapData, nint bytesPerRow, CGSize size, int pixelFormat, CGColorSpace? colorSpace)
		{
			var bitmapData__handle__ = bitmapData!.GetNonNullHandle (nameof (bitmapData));
			var colorSpace__handle__ = colorSpace.GetHandle ();
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_CGSize_int_NativeHandle (class_ptr, Selector.GetHandle ("imageWithBitmapData:bytesPerRow:size:format:colorSpace:"), bitmapData__handle__, bytesPerRow, size, pixelFormat, colorSpace__handle__), false)!;
			GC.KeepAlive (bitmapData);
			GC.KeepAlive (colorSpace);
			return ret!;
		}
		/// <param name="data">Image data, in a format supported by the system.</param><summary>Creates a new image from the specified <paramref name="data" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage? FromData (NSData data)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("imageWithData:"), data__handle__), false)!;
			GC.KeepAlive (data);
			return ret!;
		}
		/// <param name="data">Image data, in a format supported by the system.</param><param name="d"><para>Extra configuration options, as an NSDictionary.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a new image from the specified <paramref name="data" /> and <paramref name="d" /> options dictionary.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithData:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage? FromData (NSData data, NSDictionary? d)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var d__handle__ = d.GetHandle ();
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("imageWithData:options:"), data__handle__, d__handle__), false)!;
			GC.KeepAlive (data);
			GC.KeepAlive (d);
			return ret!;
		}
		/// <param name="data">Image data, in a format supported by the system.</param><param name="options">Options to initialize the image with.</param><summary>Creates a new image from the specified <paramref name="data" /> and <paramref name="options" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage? FromData (NSData data, CIImageInitializationOptionsWithMetadata? options)
		{
			return FromData (data, options.GetDictionary ());
		}
		/// <param name="data">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithDepthData:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage? FromDepthData (global::AVFoundation.AVDepthData data, NSDictionary? options)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var options__handle__ = options.GetHandle ();
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("imageWithDepthData:options:"), data__handle__, options__handle__), false)!;
			GC.KeepAlive (data);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="data">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithDepthData:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage? FromDepthData (global::AVFoundation.AVDepthData data)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("imageWithDepthData:"), data__handle__), false)!;
			GC.KeepAlive (data);
			return ret!;
		}
		/// <param name="imageBuffer">The source of the image.</param><summary>Creates a new <see cref="T:CoreImage.CIImage" /> based on the data in the <paramref name="imageBuffer" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithCVImageBuffer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage FromImageBuffer (global::CoreVideo.CVImageBuffer imageBuffer)
		{
			var imageBuffer__handle__ = imageBuffer!.GetNonNullHandle (nameof (imageBuffer));
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("imageWithCVImageBuffer:"), imageBuffer__handle__), false)!;
			GC.KeepAlive (imageBuffer);
			return ret!;
		}
		/// <param name="imageBuffer">To be added.</param><param name="dict">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithCVImageBuffer:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIImage FromImageBuffer (global::CoreVideo.CVImageBuffer imageBuffer, NSDictionary? dict)
		{
			var imageBuffer__handle__ = imageBuffer!.GetNonNullHandle (nameof (imageBuffer));
			var dict__handle__ = dict.GetHandle ();
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("imageWithCVImageBuffer:options:"), imageBuffer__handle__, dict__handle__), false)!;
			GC.KeepAlive (imageBuffer);
			GC.KeepAlive (dict);
			return ret!;
		}
		/// <param name="imageBuffer">Source of the data for the image.</param><param name="dict"><para>A dictionary of strings to objects, holding the options for image creation.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a new <see cref="T:CoreImage.CIImage" /> based on the data in <paramref name="imageBuffer" /> and applying the options in <paramref name="dict" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithCVImageBuffer:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage FromImageBuffer (global::CoreVideo.CVImageBuffer imageBuffer, NSDictionary<NSString, NSObject>? dict)
		{
			var imageBuffer__handle__ = imageBuffer!.GetNonNullHandle (nameof (imageBuffer));
			var dict__handle__ = dict.GetHandle ();
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("imageWithCVImageBuffer:options:"), imageBuffer__handle__, dict__handle__), false)!;
			GC.KeepAlive (imageBuffer);
			GC.KeepAlive (dict);
			return ret!;
		}
		/// <param name="imageBuffer">To be added.</param><param name="options">To be added.</param><summary>Creates a new <see cref="T:CoreImage.CIImage" /> based on the data in the <paramref name="imageBuffer" /> and with the specified <paramref name="options" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage FromImageBuffer (global::CoreVideo.CVImageBuffer imageBuffer, CIImageInitializationOptions options)
		{
			return FromImageBuffer (imageBuffer, options.GetDictionary ());
		}
		/// <param name="buffer">To be added.</param><summary>Creates a new image from the data that is contained in <paramref name="buffer" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithCVPixelBuffer:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage FromImageBuffer (global::CoreVideo.CVPixelBuffer buffer)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("imageWithCVPixelBuffer:"), buffer__handle__), false)!;
			GC.KeepAlive (buffer);
			return ret!;
		}
		/// <param name="buffer">To be added.</param><param name="dict"><para>Extra configuration options, as an NSDictionary.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a new image from the data that is contained in <paramref name="buffer" /> by using the options that are specified in <paramref name="dict" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithCVPixelBuffer:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage FromImageBuffer (global::CoreVideo.CVPixelBuffer buffer, NSDictionary? dict)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			var dict__handle__ = dict.GetHandle ();
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("imageWithCVPixelBuffer:options:"), buffer__handle__, dict__handle__), false)!;
			GC.KeepAlive (buffer);
			GC.KeepAlive (dict);
			return ret!;
		}
		/// <param name="buffer">To be added.</param><param name="options">Options to initialize the image with.</param><summary>Creates a new image from the data that is contained in <paramref name="buffer" /> by using the specified <paramref name="options" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage FromImageBuffer (global::CoreVideo.CVPixelBuffer buffer, CIImageInitializationOptions? options)
		{
			return FromImageBuffer (buffer, options.GetDictionary ());
		}
		/// <param name="texture">The texture providing the basis of hte <see cref="T:CoreImage.CIImage" />.</param><param name="options"><para>A dictionary of strings to objects, holding the creation options.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a new <see cref="T:CoreImage.CIImage" /> from <paramref name="texture" />, applying the creation options specified in <paramref name="options" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithMTLTexture:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage? FromMetalTexture (global::Metal.IMTLTexture texture, NSDictionary<NSString, NSObject>? options)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			var options__handle__ = options.GetHandle ();
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("imageWithMTLTexture:options:"), texture__handle__, options__handle__), false)!;
			GC.KeepAlive (texture);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="matte">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithPortaitEffectsMatte:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage? FromPortraitEffectsMatte (global::AVFoundation.AVPortraitEffectsMatte matte, NSDictionary? options)
		{
			var matte__handle__ = matte!.GetNonNullHandle (nameof (matte));
			var options__handle__ = options.GetHandle ();
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("imageWithPortaitEffectsMatte:options:"), matte__handle__, options__handle__), false)!;
			GC.KeepAlive (matte);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="matte">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithPortaitEffectsMatte:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage? FromPortraitEffectsMatte (global::AVFoundation.AVPortraitEffectsMatte matte)
		{
			var matte__handle__ = matte!.GetNonNullHandle (nameof (matte));
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("imageWithPortaitEffectsMatte:"), matte__handle__), false)!;
			GC.KeepAlive (matte);
			return ret!;
		}
		[Export ("imageWithImageProvider:size::format:colorSpace:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIImage FromProvider (ICIImageProvider provider, nuint width, nuint height, int format, CGColorSpace? colorSpace, NSDictionary? options)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var colorSpace__handle__ = colorSpace.GetHandle ();
			var options__handle__ = options.GetHandle ();
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_int_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("imageWithImageProvider:size::format:colorSpace:options:"), provider__handle__, width, height, format, colorSpace__handle__, options__handle__), false)!;
			GC.KeepAlive (provider);
			GC.KeepAlive (colorSpace);
			GC.KeepAlive (options);
			return ret!;
		}
		[Export ("imageWithSemanticSegmentationMatte:options:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage? FromSemanticSegmentationMatte (global::AVFoundation.AVSemanticSegmentationMatte matte, NSDictionary? options)
		{
			var matte__handle__ = matte!.GetNonNullHandle (nameof (matte));
			var options__handle__ = options.GetHandle ();
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("imageWithSemanticSegmentationMatte:options:"), matte__handle__, options__handle__), false)!;
			GC.KeepAlive (matte);
			GC.KeepAlive (options);
			return ret!;
		}
		[Export ("imageWithSemanticSegmentationMatte:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage? FromSemanticSegmentationMatte (global::AVFoundation.AVSemanticSegmentationMatte matte)
		{
			var matte__handle__ = matte!.GetNonNullHandle (nameof (matte));
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("imageWithSemanticSegmentationMatte:"), matte__handle__), false)!;
			GC.KeepAlive (matte);
			return ret!;
		}
		/// <param name="surface">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithIOSurface:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage FromSurface (global::IOSurface.IOSurface surface)
		{
			var surface__handle__ = surface!.GetNonNullHandle (nameof (surface));
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("imageWithIOSurface:"), surface__handle__), false)!;
			GC.KeepAlive (surface);
			return ret!;
		}
		/// <param name="surface">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithIOSurface:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage FromSurface (global::IOSurface.IOSurface surface, NSDictionary? options)
		{
			var surface__handle__ = surface!.GetNonNullHandle (nameof (surface));
			var options__handle__ = options.GetHandle ();
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("imageWithIOSurface:options:"), surface__handle__, options__handle__), false)!;
			GC.KeepAlive (surface);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="surface">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage FromSurface (global::IOSurface.IOSurface surface, CIImageInitializationOptions options)
		{
			return FromSurface (surface, options.GetDictionary ());
		}
		/// <param name="url">To be added.</param><summary>Creates a new <see cref="T:CoreImage.CIImage" /> from <paramref name="url" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithContentsOfURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage? FromUrl (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("imageWithContentsOfURL:"), url__handle__), false)!;
			GC.KeepAlive (url);
			return ret!;
		}
		/// <param name="url">To be added.</param><param name="d"><para>Extra configuration options, as an NSDictionary.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a new <see cref="T:CoreImage.CIImage" /> from <paramref name="url" /> by using the options that are specified in <paramref name="d" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithContentsOfURL:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage? FromUrl (NSUrl url, NSDictionary? d)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var d__handle__ = d.GetHandle ();
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("imageWithContentsOfURL:options:"), url__handle__, d__handle__), false)!;
			GC.KeepAlive (url);
			GC.KeepAlive (d);
			return ret!;
		}
		/// <param name="url">To be added.</param><param name="options">Options to initialize the image with.</param><summary>Creates a new <see cref="T:CoreImage.CIImage" /> from <paramref name="url" /> by using the the specified <paramref name="options" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage? FromUrl (NSUrl url, CIImageInitializationOptions? options)
		{
			return FromUrl (url, options.GetDictionary ());
		}
		/// <param name="orientation">To be added.</param><summary>Gets a transformation that results in <paramref name="orientation" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageTransformForOrientation:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGAffineTransform GetImageTransform (CIImageOrientation orientation)
		{
			CGAffineTransform ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_int (this.Handle, Selector.GetHandle ("imageTransformForOrientation:"), (int)orientation);
				} else {
					ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret_int (this.Handle, Selector.GetHandle ("imageTransformForOrientation:"), (int)orientation);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_int (&__objc_super__, Selector.GetHandle ("imageTransformForOrientation:"), (int)orientation);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_stret_int (&__objc_super__, Selector.GetHandle ("imageTransformForOrientation:"), (int)orientation);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="orientation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageTransformForCGOrientation:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGAffineTransform GetImageTransform (global::ImageIO.CGImagePropertyOrientation orientation)
		{
			CGAffineTransform ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_int (this.Handle, Selector.GetHandle ("imageTransformForCGOrientation:"), (int)orientation);
				} else {
					ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret_int (this.Handle, Selector.GetHandle ("imageTransformForCGOrientation:"), (int)orientation);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_int (&__objc_super__, Selector.GetHandle ("imageTransformForCGOrientation:"), (int)orientation);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_stret_int (&__objc_super__, Selector.GetHandle ("imageTransformForCGOrientation:"), (int)orientation);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="im">To be added.</param><param name="r">To be added.</param><summary>Gets a rectangle that describes the region in <paramref name="im" />, an image in the transformation list, that corresponds to <paramref name="r" /> in this <see cref="T:CoreImage.CIImage" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("regionOfInterestForImage:inRect:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetRegionOfInterest (CIImage im, CGRect r)
		{
			var im__handle__ = im!.GetNonNullHandle (nameof (im));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_CGRect (this.Handle, Selector.GetHandle ("regionOfInterestForImage:inRect:"), im__handle__, r);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_CGRect (this.Handle, Selector.GetHandle ("regionOfInterestForImage:inRect:"), im__handle__, r);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle_CGRect (&__objc_super__, Selector.GetHandle ("regionOfInterestForImage:inRect:"), im__handle__, r);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle_CGRect (&__objc_super__, Selector.GetHandle ("regionOfInterestForImage:inRect:"), im__handle__, r);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (im);
			return ret!;
		}
		/// <param name="matrix">To be added.</param><summary>Returns a new image that results from applying the affine transform <paramref name="matrix" /> to this <see cref="T:CoreImage.CIImage" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageByApplyingTransform:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage ImageByApplyingTransform (CGAffineTransform matrix)
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGAffineTransform (this.Handle, Selector.GetHandle ("imageByApplyingTransform:"), matrix), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGAffineTransform (&__objc_super__, Selector.GetHandle ("imageByApplyingTransform:"), matrix), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("imageByApplyingTransform:highQualityDownsample:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage ImageByApplyingTransform (CGAffineTransform matrix, bool highQualityDownsample)
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGAffineTransform_bool (this.Handle, Selector.GetHandle ("imageByApplyingTransform:highQualityDownsample:"), matrix, highQualityDownsample ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGAffineTransform_bool (&__objc_super__, Selector.GetHandle ("imageByApplyingTransform:highQualityDownsample:"), matrix, highQualityDownsample ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="r">To be added.</param><summary>Creates a new image by cropping this <see cref="T:CoreImage.CIImage" /> to the rectangle <paramref name="r" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageByCroppingToRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage ImageByCroppingToRect (CGRect r)
		{
			CIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("imageByCroppingToRect:"), r), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("imageByCroppingToRect:"), r), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="color">To be added.</param><summary>Creates a new single-color image.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithColor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage ImageWithColor (CIColor color)
		{
			var color__handle__ = color!.GetNonNullHandle (nameof (color));
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("imageWithColor:"), color__handle__), false)!;
			GC.KeepAlive (color);
			return ret!;
		}
		/// <param name="glTextureName">To be added.</param><param name="size">To be added.</param><param name="flipped">To be added.</param><param name="colorspace"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageWithTexture:size:flipped:colorSpace:")]
		[ObsoletedOSPlatform ("ios12.0")]
		[ObsoletedOSPlatform ("tvos12.0")]
		[ObsoletedOSPlatform ("macos10.14")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage ImageWithTexture (uint glTextureName, CGSize size, bool flipped, CGColorSpace? colorspace)
		{
			var colorspace__handle__ = colorspace.GetHandle ();
			CIImage? ret;
			ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32_CGSize_bool_NativeHandle (class_ptr, Selector.GetHandle ("imageWithTexture:size:flipped:colorSpace:"), glTextureName, size, flipped ? (byte) 1 : (byte) 0, colorspace__handle__), false)!;
			GC.KeepAlive (colorspace);
			return ret!;
		}
		[Export ("autoAdjustmentFiltersWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSArray _GetAutoAdjustmentFilters (NSDictionary? opts)
		{
			var opts__handle__ = opts.GetHandle ();
			NSArray? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("autoAdjustmentFiltersWithOptions:"), opts__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("autoAdjustmentFiltersWithOptions:"), opts__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (opts);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static CIImage BlackImage {
			[Export ("blackImage", ArgumentSemantic.Retain)]
			get {
				CIImage? ret;
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("blackImage")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static CIImage BlueImage {
			[Export ("blueImage", ArgumentSemantic.Retain)]
			get {
				CIImage? ret;
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("blueImage")), false)!;
				return ret!;
			}
		}
		/// <summary>Copies the <see cref="T:CoreImage.CIImage" /> into a new <see cref="T:CoreGraphics.CGImage" />.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CGImage? CGImage {
			[Export ("CGImage")]
			get {
				CGImage ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("CGImage")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("CGImage")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static CIImage ClearImage {
			[Export ("clearImage", ArgumentSemantic.Retain)]
			get {
				CIImage? ret;
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("clearImage")), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CGColorSpace? ColorSpace {
			[Export ("colorSpace")]
			get {
				CGColorSpace ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("colorSpace")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("colorSpace")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual float ContentAverageLightLevel {
			[Export ("contentAverageLightLevel")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("contentAverageLightLevel"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("contentAverageLightLevel"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual float ContentHeadroom {
			[Export ("contentHeadroom")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("contentHeadroom"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("contentHeadroom"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static CIImage CyanImage {
			[Export ("cyanImage", ArgumentSemantic.Retain)]
			get {
				CIImage? ret;
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("cyanImage")), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::AVFoundation.AVDepthData? DepthData {
			[Export ("depthData")]
			get {
				global::AVFoundation.AVDepthData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVDepthData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("depthData")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AVFoundation.AVDepthData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("depthData")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>The empty image.</summary><value></value><remarks></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIImage EmptyImage {
			[Export ("emptyImage")]
			get {
				CIImage? ret;
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("emptyImage")), false)!;
				return ret!;
			}
		}
		/// <summary>Returns the extent of the image.</summary><value></value><remarks></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect Extent {
			[Export ("extent")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("extent"));
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("extent"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("extent"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("extent"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static CIImage GrayImage {
			[Export ("grayImage", ArgumentSemantic.Retain)]
			get {
				CIImage? ret;
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("grayImage")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static CIImage GreenImage {
			[Export ("greenImage", ArgumentSemantic.Retain)]
			get {
				CIImage? ret;
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("greenImage")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static CIImage MagentaImage {
			[Export ("magentaImage", ArgumentSemantic.Retain)]
			get {
				CIImage? ret;
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("magentaImage")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual global::Metal.IMTLTexture? MetalTexture {
			[Export ("metalTexture")]
			get {
				global::Metal.IMTLTexture? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("metalTexture")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("metalTexture")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual bool Opaque {
			[Export ("isOpaque")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isOpaque"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isOpaque"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>The image data, as a <see cref="T:CoreVideo.CVPixelBuffer" />.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::CoreVideo.CVPixelBuffer? PixelBuffer {
			[Export ("pixelBuffer")]
			get {
				global::CoreVideo.CVPixelBuffer? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<CVPixelBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pixelBuffer")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<CVPixelBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("pixelBuffer")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::AVFoundation.AVPortraitEffectsMatte? PortraitEffectsMatte {
			[Export ("portraitEffectsMatte")]
			get {
				global::AVFoundation.AVPortraitEffectsMatte? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVPortraitEffectsMatte> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("portraitEffectsMatte")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AVFoundation.AVPortraitEffectsMatte> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("portraitEffectsMatte")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets a collection of metadata for this <see cref="T:CoreImage.CIImage" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGImageProperties Properties {
			get {
				var src = WeakProperties is not null ? new NSMutableDictionary (WeakProperties) : null;
				return src is null ? null! : new CGImageProperties(src);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static CIImage RedImage {
			[Export ("redImage", ArgumentSemantic.Retain)]
			get {
				CIImage? ret;
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("redImage")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual global::AVFoundation.AVSemanticSegmentationMatte? SemanticSegmentationMatte {
			[Export ("semanticSegmentationMatte")]
			get {
				global::AVFoundation.AVSemanticSegmentationMatte? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVSemanticSegmentationMatte> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("semanticSegmentationMatte")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AVFoundation.AVSemanticSegmentationMatte> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("semanticSegmentationMatte")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>If not <see langword="null" />, the URL from which the image was loaded.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSUrl? Url {
			[Export ("url")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("url")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("url")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSDictionary WeakProperties {
			[Export ("properties")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("properties")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("properties")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static CIImage WhiteImage {
			[Export ("whiteImage", ArgumentSemantic.Retain)]
			get {
				CIImage? ret;
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("whiteImage")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static CIImage YellowImage {
			[Export ("yellowImage", ArgumentSemantic.Retain)]
			get {
				CIImage? ret;
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("yellowImage")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AutoAdjustCrop;
		/// <summary>Represents the value associated with the constant 'kCIImageAutoAdjustCrop'.</summary>
		[Field ("kCIImageAutoAdjustCrop",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString AutoAdjustCrop {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AutoAdjustCrop is null)
					_AutoAdjustCrop = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageAutoAdjustCrop")!;
				return _AutoAdjustCrop;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AutoAdjustEnhanceKey;
		/// <summary>Represents the value associated with the constant 'kCIImageAutoAdjustEnhance'.</summary>
		[Field ("kCIImageAutoAdjustEnhance",  "CoreImage")]
		internal static NSString AutoAdjustEnhanceKey {
			get {
				if (_AutoAdjustEnhanceKey is null)
					_AutoAdjustEnhanceKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageAutoAdjustEnhance")!;
				return _AutoAdjustEnhanceKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AutoAdjustFeaturesKey;
		/// <summary>Represents the value associated with the constant 'kCIImageAutoAdjustFeatures'.</summary>
		[Field ("kCIImageAutoAdjustFeatures",  "CoreImage")]
		internal static NSString AutoAdjustFeaturesKey {
			get {
				if (_AutoAdjustFeaturesKey is null)
					_AutoAdjustFeaturesKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageAutoAdjustFeatures")!;
				return _AutoAdjustFeaturesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AutoAdjustLevel;
		/// <summary>Represents the value associated with the constant 'kCIImageAutoAdjustLevel'.</summary>
		[Field ("kCIImageAutoAdjustLevel",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString AutoAdjustLevel {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AutoAdjustLevel is null)
					_AutoAdjustLevel = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageAutoAdjustLevel")!;
				return _AutoAdjustLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AutoAdjustRedEyeKey;
		/// <summary>Represents the value associated with the constant 'kCIImageAutoAdjustRedEye'.</summary>
		[Field ("kCIImageAutoAdjustRedEye",  "CoreImage")]
		internal static NSString AutoAdjustRedEyeKey {
			get {
				if (_AutoAdjustRedEyeKey is null)
					_AutoAdjustRedEyeKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageAutoAdjustRedEye")!;
				return _AutoAdjustRedEyeKey;
			}
		}
		/// <summary>Represents the value associated with the constant kCIFormatA16.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.A16.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatA16",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatA16 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatA16");
			}
		}
		/// <summary>Represents the value associated with the constant kCIFormatA8.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.A8.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatA8",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatA8 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatA8");
			}
		}
		/// <summary>Represents the value associated with the constant kCIFormatABGR8.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.Abgr8.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatABGR8",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatABGR8 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatABGR8");
			}
		}
		/// <summary>Represents the value associated with the constant kCIFormatARGB8</summary><value></value><remarks>32-bit color in ARGB format.</remarks>
		[Obsolete ("Use 'CIFormat.Argb8.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatARGB8",  "CoreImage")]
		public static int FormatARGB8 {
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatARGB8");
			}
		}
		/// <summary>Represents the value associated with the constant kCIFormatAf.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.Af.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatAf",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatAf {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatAf");
			}
		}
		/// <summary>Represents the value associated with the constant kCIFormatAh.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.Ah.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatAh",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatAh {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatAh");
			}
		}
		/// <summary>Represents the value associated with the constant kCIFormatBGRA8</summary><value></value><remarks></remarks>
		[Obsolete ("Use 'CIFormat.Bgra8.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatBGRA8",  "CoreImage")]
		public static int FormatBGRA8 {
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatBGRA8");
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.L16.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatL16",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatL16 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatL16");
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.L8.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatL8",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatL8 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatL8");
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.LA16.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatLA16",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatLA16 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatLA16");
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.LA8.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatLA8",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatLA8 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatLA8");
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.LAf.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatLAf",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatLAf {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatLAf");
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.LAh.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatLAh",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatLAh {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatLAh");
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.Lf.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatLf",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatLf {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatLf");
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.Lh.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatLh",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatLh {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatLh");
			}
		}
		/// <summary>Represents the value associated with the constant kCIFormatR16.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.R16.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatR16",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatR16 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatR16");
			}
		}
		/// <summary>Represents the value associated with the constant kCIFormatR8.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.R8.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatR8",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatR8 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatR8");
			}
		}
		/// <summary>Represents the value associated with the constant kCIFormatRG16.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.RG16.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatRG16",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatRG16 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatRG16");
			}
		}
		/// <summary>Represents the value associated with the constant kCIFormatRG8.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.RG8.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatRG8",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatRG8 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatRG8");
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.Rgba16.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatRGBA16",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatRGBA16 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatRGBA16");
			}
		}
		/// <summary>Represents the value associated with the constant kCIFormatRGBA8</summary><value></value><remarks></remarks>
		[Obsolete ("Use 'CIFormat.Rgba8.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatRGBA8",  "CoreImage")]
		public static int FormatRGBA8 {
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatRGBA8");
			}
		}
		/// <summary>Represents the value associated with the constant kCIFormatRGBAf</summary><value></value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.Rgbaf.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatRGBAf",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatRGBAf {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatRGBAf");
			}
		}
		/// <summary>Represents the value associated with the constant kCIFormatRGBAh</summary><value></value><remarks></remarks>
		[Obsolete ("Use 'CIFormat.Rgbah.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatRGBAh",  "CoreImage")]
		public static int FormatRGBAh {
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatRGBAh");
			}
		}
		/// <summary>Represents the value associated with the constant kCIFormatRGf.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.RGf.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatRGf",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatRGf {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatRGf");
			}
		}
		/// <summary>Represents the value associated with the constant kCIFormatRGh.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.RGh.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatRGh",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatRGh {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatRGh");
			}
		}
		/// <summary>Represents the value associated with the constant kCIFormatRf.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.Rf.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatRf",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatRf {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatRf");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCIFormatRGB10'.</summary>
		[Obsolete ("Use 'CIFormat.Rgb10.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatRGB10",  "CoreImage")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public static int FormatRgb10 {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatRGB10");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCIFormatRGBX16'.</summary>
		[Obsolete ("Use 'CIFormat.RgbX16.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatRGBX16",  "CoreImage")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public static int FormatRgbX16 {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatRGBX16");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCIFormatRGBXf'.</summary>
		[Obsolete ("Use 'CIFormat.RgbXf.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatRGBXf",  "CoreImage")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public static int FormatRgbXf {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatRGBXf");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCIFormatRGBXh'.</summary>
		[Obsolete ("Use 'CIFormat.RgbXh.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatRGBXh",  "CoreImage")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public static int FormatRgbXh {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatRGBXh");
			}
		}
		/// <summary>Represents the value associated with the constant kCIFormatRh.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'CIFormat.Rh.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIFormatRh",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static int FormatRh {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetInt32 (Libraries.CoreImage.Handle, "kCIFormatRh");
			}
		}
	} /* class CIImage */
}
