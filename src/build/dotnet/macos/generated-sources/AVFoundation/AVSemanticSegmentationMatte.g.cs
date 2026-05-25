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
namespace AVFoundation {
	[Register("AVSemanticSegmentationMatte", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AVSemanticSegmentationMatte : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDictionaryRepresentationForAuxiliaryDataType_X = "dictionaryRepresentationForAuxiliaryDataType:";
		static readonly NativeHandle selDictionaryRepresentationForAuxiliaryDataType_XHandle = Selector.GetHandle ("dictionaryRepresentationForAuxiliaryDataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatteTypeX = "matteType";
		static readonly NativeHandle selMatteTypeXHandle = Selector.GetHandle ("matteType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMattingImageX = "mattingImage";
		static readonly NativeHandle selMattingImageXHandle = Selector.GetHandle ("mattingImage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPixelFormatTypeX = "pixelFormatType";
		static readonly NativeHandle selPixelFormatTypeXHandle = Selector.GetHandle ("pixelFormatType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSemanticSegmentationMatteByApplyingExifOrientation_X = "semanticSegmentationMatteByApplyingExifOrientation:";
		static readonly NativeHandle selSemanticSegmentationMatteByApplyingExifOrientation_XHandle = Selector.GetHandle ("semanticSegmentationMatteByApplyingExifOrientation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSemanticSegmentationMatteByReplacingSemanticSegmentationMatteWithPixelBuffer_Error_X = "semanticSegmentationMatteByReplacingSemanticSegmentationMatteWithPixelBuffer:error:";
		static readonly NativeHandle selSemanticSegmentationMatteByReplacingSemanticSegmentationMatteWithPixelBuffer_Error_XHandle = Selector.GetHandle ("semanticSegmentationMatteByReplacingSemanticSegmentationMatteWithPixelBuffer:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSemanticSegmentationMatteFromImageSourceAuxiliaryDataType_DictionaryRepresentation_Error_X = "semanticSegmentationMatteFromImageSourceAuxiliaryDataType:dictionaryRepresentation:error:";
		static readonly NativeHandle selSemanticSegmentationMatteFromImageSourceAuxiliaryDataType_DictionaryRepresentation_Error_XHandle = Selector.GetHandle ("semanticSegmentationMatteFromImageSourceAuxiliaryDataType:dictionaryRepresentation:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVSemanticSegmentationMatte");
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
		protected AVSemanticSegmentationMatte (NSObjectFlag t) : base (t)
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
		protected internal AVSemanticSegmentationMatte (NativeHandle handle) : base (handle)
		{
		}

		[Export ("semanticSegmentationMatteByApplyingExifOrientation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVSemanticSegmentationMatte ApplyExifOrientation (global::ImageIO.CGImagePropertyOrientation exifOrientation)
		{
			AVSemanticSegmentationMatte ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AVSemanticSegmentationMatte> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (this.Handle, selSemanticSegmentationMatteByApplyingExifOrientation_XHandle, (int)exifOrientation), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<AVSemanticSegmentationMatte> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int (&__objc_super__, selSemanticSegmentationMatteByApplyingExifOrientation_XHandle, (int)exifOrientation), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("semanticSegmentationMatteFromImageSourceAuxiliaryDataType:dictionaryRepresentation:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AVSemanticSegmentationMatte? Create (NSString imageSourceAuxiliaryDataType, NSDictionary imageSourceAuxiliaryDataInfoDictionary, out NSError outError)
		{
			var imageSourceAuxiliaryDataType__handle__ = imageSourceAuxiliaryDataType!.GetNonNullHandle (nameof (imageSourceAuxiliaryDataType));
			var imageSourceAuxiliaryDataInfoDictionary__handle__ = imageSourceAuxiliaryDataInfoDictionary!.GetNonNullHandle (nameof (imageSourceAuxiliaryDataInfoDictionary));
			NativeHandle outErrorValue = IntPtr.Zero;
			AVSemanticSegmentationMatte? ret;
			ret =  Runtime.GetNSObject<AVSemanticSegmentationMatte> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, selSemanticSegmentationMatteFromImageSourceAuxiliaryDataType_DictionaryRepresentation_Error_XHandle, imageSourceAuxiliaryDataType__handle__, imageSourceAuxiliaryDataInfoDictionary__handle__, &outErrorValue), false)!;
			GC.KeepAlive (imageSourceAuxiliaryDataType);
			GC.KeepAlive (imageSourceAuxiliaryDataInfoDictionary);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[Export ("dictionaryRepresentationForAuxiliaryDataType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDictionary? GetDictionaryRepresentation (out string? outAuxDataType)
		{
			NativeHandle outAuxDataTypeValue = IntPtr.Zero;
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (this.Handle, selDictionaryRepresentationForAuxiliaryDataType_XHandle, &outAuxDataTypeValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selDictionaryRepresentationForAuxiliaryDataType_XHandle, &outAuxDataTypeValue), false)!;
					GC.KeepAlive (this);
				}
			}
			outAuxDataType = CFString.FromHandle (outAuxDataTypeValue)!;
			return ret!;
		}
		[Export ("semanticSegmentationMatteByReplacingSemanticSegmentationMatteWithPixelBuffer:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual AVSemanticSegmentationMatte? ReplaceSemanticSegmentationMatte (global::CoreVideo.CVPixelBuffer pixelBuffer, out NSError outError)
		{
			var pixelBuffer__handle__ = pixelBuffer!.GetNonNullHandle (nameof (pixelBuffer));
			NativeHandle outErrorValue = IntPtr.Zero;
			AVSemanticSegmentationMatte? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AVSemanticSegmentationMatte> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selSemanticSegmentationMatteByReplacingSemanticSegmentationMatteWithPixelBuffer_Error_XHandle, pixelBuffer__handle__, &outErrorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<AVSemanticSegmentationMatte> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selSemanticSegmentationMatteByReplacingSemanticSegmentationMatteWithPixelBuffer_Error_XHandle, pixelBuffer__handle__, &outErrorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pixelBuffer);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (AVSemanticSegmentationMatteType), OriginalType = typeof (NSString))]
		public virtual global::AVFoundation.AVSemanticSegmentationMatteType MatteType {
			[Export ("matteType")]
			get {
				global::AVFoundation.AVSemanticSegmentationMatteType ret;
				if (IsDirectBinding) {
					ret = global::AVFoundation.AVSemanticSegmentationMatteTypeExtensions.GetValue (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMatteTypeXHandle));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::AVFoundation.AVSemanticSegmentationMatteTypeExtensions.GetValue (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMatteTypeXHandle));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreVideo.CVPixelBuffer MattingImage {
			[Export ("mattingImage")]
			get {
				global::CoreVideo.CVPixelBuffer? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<CVPixelBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMattingImageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<CVPixelBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMattingImageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreVideo.CVPixelFormatType PixelFormatType {
			[Export ("pixelFormatType")]
			get {
				global::CoreVideo.CVPixelFormatType ret;
				if (IsDirectBinding) {
					ret = (global::CoreVideo.CVPixelFormatType) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPixelFormatTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (global::CoreVideo.CVPixelFormatType) global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selPixelFormatTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class AVSemanticSegmentationMatte */
}
