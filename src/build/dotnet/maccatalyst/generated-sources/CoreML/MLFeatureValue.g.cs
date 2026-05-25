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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreML {
	/// <summary>An immutable value and <see cref="T:CoreML.MLFeatureType" /> for a feature.</summary>
	[Register("MLFeatureValue", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MLFeatureValue : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MLFeatureValue");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MLFeatureValue" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MLFeatureValue () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
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
		public MLFeatureValue (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MLFeatureValue (NSObjectFlag t) : base (t)
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
		protected internal MLFeatureValue (NativeHandle handle) : base (handle)
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
		/// <param name="value">A pixel buffer with which to create and return a new feature value.</param><summary>Returns an MLFeatureValue that wraps a CVPixelBuffer.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("featureValueWithPixelBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLFeatureValue Create (global::CoreVideo.CVPixelBuffer value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			MLFeatureValue? ret;
			ret =  Runtime.GetNSObject<MLFeatureValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("featureValueWithPixelBuffer:"), value__handle__), false)!;
			GC.KeepAlive (value);
			return ret!;
		}
		/// <param name="sequence">A sequence of data.</param><summary>Returns a <see cref="T:CoreML.MLFeatureValue" /> representing the <paramref name="sequence" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("featureValueWithSequence:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLFeatureValue Create (MLSequence sequence)
		{
			var sequence__handle__ = sequence!.GetNonNullHandle (nameof (sequence));
			MLFeatureValue? ret;
			ret =  Runtime.GetNSObject<MLFeatureValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("featureValueWithSequence:"), sequence__handle__), false)!;
			GC.KeepAlive (sequence);
			return ret!;
		}
		/// <param name="value">A 64-bit integer with which to create and return a new feature value.</param><summary>Returns an MLFeatureValue that wraps a 64-bit integer.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("featureValueWithInt64:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLFeatureValue Create (long value)
		{
			MLFeatureValue ret;
			ret =  Runtime.GetNSObject<MLFeatureValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Int64 (class_ptr, Selector.GetHandle ("featureValueWithInt64:"), value), false)!;
			return ret;
		}
		/// <param name="value">A double with which to create and return a new feature value.</param><summary>Returns an MLFeatureValue that wraps a double.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("featureValueWithDouble:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLFeatureValue Create (double value)
		{
			MLFeatureValue ret;
			ret =  Runtime.GetNSObject<MLFeatureValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, Selector.GetHandle ("featureValueWithDouble:"), value), false)!;
			return ret;
		}
		/// <param name="value">A string with which to create and return a new feature value.</param><summary>Returns an MLFeatureValue that wraps a string.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("featureValueWithString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLFeatureValue Create (string value)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsvalue = CFString.CreateNative (value);
			MLFeatureValue? ret;
			ret =  Runtime.GetNSObject<MLFeatureValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("featureValueWithString:"), nsvalue), false)!;
			CFString.ReleaseNative (nsvalue);
			return ret!;
		}
		/// <param name="value">A multiarray with which to create and return a new feature value.</param><summary>Returns an MLFeatureValue that wraps an MLMultiArray.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("featureValueWithMultiArray:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLFeatureValue Create (MLMultiArray value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			MLFeatureValue? ret;
			ret =  Runtime.GetNSObject<MLFeatureValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("featureValueWithMultiArray:"), value__handle__), false)!;
			GC.KeepAlive (value);
			return ret!;
		}
		/// <param name="value">A dictionary with which to create and return a new feature value.</param><param name="error">If not <see langword="null" />, the error that occurred.</param><summary>Returns an MLFeatureValue that wraps a dictionary, and reports any errors in <paramref name="error" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("featureValueWithDictionary:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MLFeatureValue? Create (NSDictionary<NSObject, NSNumber> value, out NSError error)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			NativeHandle errorValue = IntPtr.Zero;
			MLFeatureValue? ret;
			ret =  Runtime.GetNSObject<MLFeatureValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("featureValueWithDictionary:error:"), value__handle__, &errorValue), false)!;
			GC.KeepAlive (value);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("featureValueWithImageAtURL:pixelsWide:pixelsHigh:pixelFormatType:options:error:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MLFeatureValue? Create (NSUrl url, nint pixelsWide, nint pixelsHigh, global::CoreVideo.CVPixelFormatType pixelFormatType, NSDictionary? options, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			MLFeatureValue? ret;
			ret =  Runtime.GetNSObject<MLFeatureValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr_UInt32_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("featureValueWithImageAtURL:pixelsWide:pixelsHigh:pixelFormatType:options:error:"), url__handle__, pixelsWide, pixelsHigh, (UInt32)pixelFormatType, options__handle__, &errorValue), false)!;
			GC.KeepAlive (url);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MLFeatureValue? Create (NSUrl url, nint pixelsWide, nint pixelsHigh, global::CoreVideo.CVPixelFormatType pixelFormatType, MLFeatureValueImageOption? imageOptions, out NSError? error)
		{
			return Create (url, pixelsWide, pixelsHigh, pixelFormatType, imageOptions.GetDictionary (), out error);
		}
		[Export ("featureValueWithImageAtURL:constraint:options:error:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MLFeatureValue? Create (NSUrl url, MLImageConstraint constraint, NSDictionary? options, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var constraint__handle__ = constraint!.GetNonNullHandle (nameof (constraint));
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			MLFeatureValue? ret;
			ret =  Runtime.GetNSObject<MLFeatureValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("featureValueWithImageAtURL:constraint:options:error:"), url__handle__, constraint__handle__, options__handle__, &errorValue), false)!;
			GC.KeepAlive (url);
			GC.KeepAlive (constraint);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MLFeatureValue? Create (NSUrl url, MLImageConstraint constraint, MLFeatureValueImageOption? imageOptions, out NSError? error)
		{
			return Create (url, constraint, imageOptions.GetDictionary (), out error);
		}
		[Export ("featureValueWithCGImage:pixelsWide:pixelsHigh:pixelFormatType:options:error:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MLFeatureValue? Create (CGImage image, nint pixelsWide, nint pixelsHigh, global::CoreVideo.CVPixelFormatType pixelFormatType, NSDictionary? options, out NSError? error)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			MLFeatureValue? ret;
			ret =  Runtime.GetNSObject<MLFeatureValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr_UInt32_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("featureValueWithCGImage:pixelsWide:pixelsHigh:pixelFormatType:options:error:"), image.Handle, pixelsWide, pixelsHigh, (UInt32)pixelFormatType, options__handle__, &errorValue), false)!;
			GC.KeepAlive (image);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MLFeatureValue? Create (CGImage image, nint pixelsWide, nint pixelsHigh, global::CoreVideo.CVPixelFormatType pixelFormatType, MLFeatureValueImageOption? imageOptions, out NSError? error)
		{
			return Create (image, pixelsWide, pixelsHigh, pixelFormatType, imageOptions.GetDictionary (), out error);
		}
		[Export ("featureValueWithCGImage:constraint:options:error:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MLFeatureValue? Create (CGImage image, MLImageConstraint constraint, NSDictionary? options, out NSError? error)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var constraint__handle__ = constraint!.GetNonNullHandle (nameof (constraint));
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			MLFeatureValue? ret;
			ret =  Runtime.GetNSObject<MLFeatureValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("featureValueWithCGImage:constraint:options:error:"), image.Handle, constraint__handle__, options__handle__, &errorValue), false)!;
			GC.KeepAlive (image);
			GC.KeepAlive (constraint);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MLFeatureValue? Create (CGImage image, MLImageConstraint constraint, MLFeatureValueImageOption? imageOptions, out NSError? error)
		{
			return Create (image, constraint, imageOptions.GetDictionary (), out error);
		}
		[Export ("featureValueWithImageAtURL:orientation:pixelsWide:pixelsHigh:pixelFormatType:options:error:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MLFeatureValue? Create (NSUrl url, global::ImageIO.CGImagePropertyOrientation orientation, nint pixelsWide, nint pixelsHigh, global::CoreVideo.CVPixelFormatType pixelFormatType, NSDictionary? options, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			MLFeatureValue? ret;
			ret =  Runtime.GetNSObject<MLFeatureValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_IntPtr_IntPtr_UInt32_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("featureValueWithImageAtURL:orientation:pixelsWide:pixelsHigh:pixelFormatType:options:error:"), url__handle__, (int)orientation, pixelsWide, pixelsHigh, (UInt32)pixelFormatType, options__handle__, &errorValue), false)!;
			GC.KeepAlive (url);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MLFeatureValue? Create (NSUrl url, global::ImageIO.CGImagePropertyOrientation orientation, nint pixelsWide, nint pixelsHigh, global::CoreVideo.CVPixelFormatType pixelFormatType, MLFeatureValueImageOption? imageOptions, out NSError? error)
		{
			return Create (url, orientation, pixelsWide, pixelsHigh, pixelFormatType, imageOptions.GetDictionary (), out error);
		}
		[Export ("featureValueWithImageAtURL:orientation:constraint:options:error:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MLFeatureValue? Create (NSUrl url, global::ImageIO.CGImagePropertyOrientation orientation, MLImageConstraint constraint, NSDictionary? options, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var constraint__handle__ = constraint!.GetNonNullHandle (nameof (constraint));
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			MLFeatureValue? ret;
			ret =  Runtime.GetNSObject<MLFeatureValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("featureValueWithImageAtURL:orientation:constraint:options:error:"), url__handle__, (int)orientation, constraint__handle__, options__handle__, &errorValue), false)!;
			GC.KeepAlive (url);
			GC.KeepAlive (constraint);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MLFeatureValue? Create (NSUrl url, global::ImageIO.CGImagePropertyOrientation orientation, MLImageConstraint constraint, MLFeatureValueImageOption? imageOptions, out NSError? error)
		{
			return Create (url, orientation, constraint, imageOptions.GetDictionary (), out error);
		}
		[Export ("featureValueWithCGImage:orientation:pixelsWide:pixelsHigh:pixelFormatType:options:error:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MLFeatureValue? Create (CGImage image, global::ImageIO.CGImagePropertyOrientation orientation, nint pixelsWide, nint pixelsHigh, global::CoreVideo.CVPixelFormatType pixelFormatType, NSDictionary? options, out NSError? error)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			MLFeatureValue? ret;
			ret =  Runtime.GetNSObject<MLFeatureValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_IntPtr_IntPtr_UInt32_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("featureValueWithCGImage:orientation:pixelsWide:pixelsHigh:pixelFormatType:options:error:"), image.Handle, (int)orientation, pixelsWide, pixelsHigh, (UInt32)pixelFormatType, options__handle__, &errorValue), false)!;
			GC.KeepAlive (image);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MLFeatureValue? Create (CGImage image, global::ImageIO.CGImagePropertyOrientation orientation, nint pixelsWide, nint pixelsHigh, global::CoreVideo.CVPixelFormatType pixelFormatType, MLFeatureValueImageOption? imageOptions, out NSError? error)
		{
			return Create (image, orientation, pixelsWide, pixelsHigh, pixelFormatType, imageOptions.GetDictionary (), out error);
		}
		[Export ("featureValueWithCGImage:orientation:constraint:options:error:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MLFeatureValue? Create (CGImage image, global::ImageIO.CGImagePropertyOrientation orientation, MLImageConstraint constraint, NSDictionary? options, out NSError? error)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var constraint__handle__ = constraint!.GetNonNullHandle (nameof (constraint));
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			MLFeatureValue? ret;
			ret =  Runtime.GetNSObject<MLFeatureValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("featureValueWithCGImage:orientation:constraint:options:error:"), image.Handle, (int)orientation, constraint__handle__, options__handle__, &errorValue), false)!;
			GC.KeepAlive (image);
			GC.KeepAlive (constraint);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MLFeatureValue? Create (CGImage image, global::ImageIO.CGImagePropertyOrientation orientation, MLImageConstraint constraint, MLFeatureValueImageOption? imageOptions, out NSError? error)
		{
			return Create (image, orientation, constraint, imageOptions.GetDictionary (), out error);
		}
		/// <param name="type">The kind of feature to create.</param><summary>Static factory method to create a <see cref="T:CoreML.MLFeatureValue" /> of the specified type but with an undefined value.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("undefinedFeatureValueWithType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLFeatureValue CreateUndefined (MLFeatureType type)
		{
			MLFeatureValue ret;
			ret =  Runtime.GetNSObject<MLFeatureValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("undefinedFeatureValueWithType:"), (IntPtr) (long) type), false)!;
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
		/// <param name="value">The value to compare against.</param><summary>Returns <see langword="true" /> if <paramref name="value" /> has the same <see cref="T:CoreML.MLFeatureType" /> and value as <c>this</c>.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isEqualToFeatureValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEqual (MLFeatureValue value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isEqualToFeatureValue:"), value__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("isEqualToFeatureValue:"), value__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			return ret != 0;
		}
		/// <summary>Gets the underlying <see cref="T:Foundation.NSDictionary" /> (Object-&gt;NSNumber) feature value.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSObject, NSNumber> DictionaryValue {
			[Export ("dictionaryValue")]
			get {
				NSDictionary<NSObject, NSNumber>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSObject, NSNumber>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("dictionaryValue")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSObject, NSNumber>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("dictionaryValue")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the underlying <see cref="T:System.Double" /> feature value.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double DoubleValue {
			[Export ("doubleValue")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("doubleValue"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("doubleValue"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Static factory method to create a <see cref="T:CoreML.MLFeatureValue" /> whose kind is <see cref="F:CoreML.MLFeatureType.Image" />.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreVideo.CVPixelBuffer? ImageBufferValue {
			[Export ("imageBufferValue")]
			get {
				global::CoreVideo.CVPixelBuffer? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<CVPixelBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("imageBufferValue")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<CVPixelBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("imageBufferValue")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the underlying <see cref="T:System.Int64" /> feature value.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual long Int64Value {
			[Export ("int64Value")]
			get {
				long ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("int64Value"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("int64Value"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the underlying <see cref="T:CoreML.MLMultiArray" /> feature value.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLMultiArray? MultiArrayValue {
			[Export ("multiArrayValue")]
			get {
				MLMultiArray? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MLMultiArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("multiArrayValue")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MLMultiArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("multiArrayValue")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the underlying <see cref="T:CoreML.MLSequence" /> value.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual MLSequence? SequenceValue {
			[Export ("sequenceValue")]
			get {
				MLSequence? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MLSequence> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sequenceValue")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MLSequence> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("sequenceValue")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the underlying <see cref="T:System.String" /> feature value.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string StringValue {
			[Export ("stringValue")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("stringValue")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("stringValue")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the <see cref="T:CoreML.MLFeatureType" /> kind of this <see cref="T:CoreML.MLFeatureValue" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLFeatureType Type {
			[Export ("type")]
			get {
				MLFeatureType ret;
				if (IsDirectBinding) {
					ret = (MLFeatureType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MLFeatureType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("type"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets whether the underlying value is undefined.</summary><value><see langword="true" /> if the value is undefined.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Undefined {
			[Export ("isUndefined")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isUndefined"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isUndefined"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
	} /* class MLFeatureValue */
}
