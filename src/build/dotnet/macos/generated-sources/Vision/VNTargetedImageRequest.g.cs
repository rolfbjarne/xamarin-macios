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
namespace Vision {
	/// <summary>Abstract <see cref="T:Vision.VNImageBasedRequest" /> for requests that operate on two images.</summary>
	[Register("VNTargetedImageRequest", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class VNTargetedImageRequest : VNImageBasedRequest {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedCGImage_Options_X = "initWithTargetedCGImage:options:";
		static readonly NativeHandle selInitWithTargetedCGImage_Options_XHandle = Selector.GetHandle ("initWithTargetedCGImage:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedCGImage_Options_CompletionHandler_X = "initWithTargetedCGImage:options:completionHandler:";
		static readonly NativeHandle selInitWithTargetedCGImage_Options_CompletionHandler_XHandle = Selector.GetHandle ("initWithTargetedCGImage:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedCGImage_Orientation_Options_X = "initWithTargetedCGImage:orientation:options:";
		static readonly NativeHandle selInitWithTargetedCGImage_Orientation_Options_XHandle = Selector.GetHandle ("initWithTargetedCGImage:orientation:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedCGImage_Orientation_Options_CompletionHandler_X = "initWithTargetedCGImage:orientation:options:completionHandler:";
		static readonly NativeHandle selInitWithTargetedCGImage_Orientation_Options_CompletionHandler_XHandle = Selector.GetHandle ("initWithTargetedCGImage:orientation:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedCIImage_Options_X = "initWithTargetedCIImage:options:";
		static readonly NativeHandle selInitWithTargetedCIImage_Options_XHandle = Selector.GetHandle ("initWithTargetedCIImage:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedCIImage_Options_CompletionHandler_X = "initWithTargetedCIImage:options:completionHandler:";
		static readonly NativeHandle selInitWithTargetedCIImage_Options_CompletionHandler_XHandle = Selector.GetHandle ("initWithTargetedCIImage:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedCIImage_Orientation_Options_X = "initWithTargetedCIImage:orientation:options:";
		static readonly NativeHandle selInitWithTargetedCIImage_Orientation_Options_XHandle = Selector.GetHandle ("initWithTargetedCIImage:orientation:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedCIImage_Orientation_Options_CompletionHandler_X = "initWithTargetedCIImage:orientation:options:completionHandler:";
		static readonly NativeHandle selInitWithTargetedCIImage_Orientation_Options_CompletionHandler_XHandle = Selector.GetHandle ("initWithTargetedCIImage:orientation:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedCMSampleBuffer_Options_X = "initWithTargetedCMSampleBuffer:options:";
		static readonly NativeHandle selInitWithTargetedCMSampleBuffer_Options_XHandle = Selector.GetHandle ("initWithTargetedCMSampleBuffer:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedCMSampleBuffer_Options_CompletionHandler_X = "initWithTargetedCMSampleBuffer:options:completionHandler:";
		static readonly NativeHandle selInitWithTargetedCMSampleBuffer_Options_CompletionHandler_XHandle = Selector.GetHandle ("initWithTargetedCMSampleBuffer:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedCMSampleBuffer_Orientation_Options_X = "initWithTargetedCMSampleBuffer:orientation:options:";
		static readonly NativeHandle selInitWithTargetedCMSampleBuffer_Orientation_Options_XHandle = Selector.GetHandle ("initWithTargetedCMSampleBuffer:orientation:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedCMSampleBuffer_Orientation_Options_CompletionHandler_X = "initWithTargetedCMSampleBuffer:orientation:options:completionHandler:";
		static readonly NativeHandle selInitWithTargetedCMSampleBuffer_Orientation_Options_CompletionHandler_XHandle = Selector.GetHandle ("initWithTargetedCMSampleBuffer:orientation:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedCVPixelBuffer_Options_X = "initWithTargetedCVPixelBuffer:options:";
		static readonly NativeHandle selInitWithTargetedCVPixelBuffer_Options_XHandle = Selector.GetHandle ("initWithTargetedCVPixelBuffer:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedCVPixelBuffer_Options_CompletionHandler_X = "initWithTargetedCVPixelBuffer:options:completionHandler:";
		static readonly NativeHandle selInitWithTargetedCVPixelBuffer_Options_CompletionHandler_XHandle = Selector.GetHandle ("initWithTargetedCVPixelBuffer:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedCVPixelBuffer_Orientation_Options_X = "initWithTargetedCVPixelBuffer:orientation:options:";
		static readonly NativeHandle selInitWithTargetedCVPixelBuffer_Orientation_Options_XHandle = Selector.GetHandle ("initWithTargetedCVPixelBuffer:orientation:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedCVPixelBuffer_Orientation_Options_CompletionHandler_X = "initWithTargetedCVPixelBuffer:orientation:options:completionHandler:";
		static readonly NativeHandle selInitWithTargetedCVPixelBuffer_Orientation_Options_CompletionHandler_XHandle = Selector.GetHandle ("initWithTargetedCVPixelBuffer:orientation:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedImageData_Options_X = "initWithTargetedImageData:options:";
		static readonly NativeHandle selInitWithTargetedImageData_Options_XHandle = Selector.GetHandle ("initWithTargetedImageData:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedImageData_Options_CompletionHandler_X = "initWithTargetedImageData:options:completionHandler:";
		static readonly NativeHandle selInitWithTargetedImageData_Options_CompletionHandler_XHandle = Selector.GetHandle ("initWithTargetedImageData:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedImageData_Orientation_Options_X = "initWithTargetedImageData:orientation:options:";
		static readonly NativeHandle selInitWithTargetedImageData_Orientation_Options_XHandle = Selector.GetHandle ("initWithTargetedImageData:orientation:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedImageData_Orientation_Options_CompletionHandler_X = "initWithTargetedImageData:orientation:options:completionHandler:";
		static readonly NativeHandle selInitWithTargetedImageData_Orientation_Options_CompletionHandler_XHandle = Selector.GetHandle ("initWithTargetedImageData:orientation:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedImageURL_Options_X = "initWithTargetedImageURL:options:";
		static readonly NativeHandle selInitWithTargetedImageURL_Options_XHandle = Selector.GetHandle ("initWithTargetedImageURL:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedImageURL_Options_CompletionHandler_X = "initWithTargetedImageURL:options:completionHandler:";
		static readonly NativeHandle selInitWithTargetedImageURL_Options_CompletionHandler_XHandle = Selector.GetHandle ("initWithTargetedImageURL:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedImageURL_Orientation_Options_X = "initWithTargetedImageURL:orientation:options:";
		static readonly NativeHandle selInitWithTargetedImageURL_Orientation_Options_XHandle = Selector.GetHandle ("initWithTargetedImageURL:orientation:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTargetedImageURL_Orientation_Options_CompletionHandler_X = "initWithTargetedImageURL:orientation:options:completionHandler:";
		static readonly NativeHandle selInitWithTargetedImageURL_Orientation_Options_CompletionHandler_XHandle = Selector.GetHandle ("initWithTargetedImageURL:orientation:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("VNTargetedImageRequest");
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
		protected VNTargetedImageRequest (NSObjectFlag t) : base (t)
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
		protected internal VNTargetedImageRequest (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithTargetedCVPixelBuffer:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (global::CoreVideo.CVPixelBuffer pixelBuffer, NSDictionary optionsDict)
			: base (NSObjectFlag.Empty)
		{
			var pixelBuffer__handle__ = pixelBuffer!.GetNonNullHandle (nameof (pixelBuffer));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithTargetedCVPixelBuffer_Options_XHandle, pixelBuffer__handle__, optionsDict__handle__), "initWithTargetedCVPixelBuffer:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithTargetedCVPixelBuffer_Options_XHandle, pixelBuffer__handle__, optionsDict__handle__), "initWithTargetedCVPixelBuffer:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pixelBuffer);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="pixelBuffer">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (global::CoreVideo.CVPixelBuffer pixelBuffer, VNImageOptions options)
			: this (pixelBuffer, options.GetDictionary ()!)
		{
		}
		[Export ("initWithTargetedCVPixelBuffer:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (global::CoreVideo.CVPixelBuffer pixelBuffer, NSDictionary optionsDict, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDVNRequestCompletionHandler))]VNRequestCompletionHandler? completionHandler)
			: base (NSObjectFlag.Empty)
		{
			var pixelBuffer__handle__ = pixelBuffer!.GetNonNullHandle (nameof (pixelBuffer));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			using var block_completionHandler = Trampolines.SDVNRequestCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithTargetedCVPixelBuffer_Options_CompletionHandler_XHandle, pixelBuffer__handle__, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedCVPixelBuffer:options:completionHandler:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithTargetedCVPixelBuffer_Options_CompletionHandler_XHandle, pixelBuffer__handle__, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedCVPixelBuffer:options:completionHandler:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pixelBuffer);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="pixelBuffer">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (global::CoreVideo.CVPixelBuffer pixelBuffer, VNImageOptions options, VNRequestCompletionHandler completionHandler)
			: this (pixelBuffer, options.GetDictionary ()!, completionHandler)
		{
		}
		[Export ("initWithTargetedCVPixelBuffer:orientation:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (global::CoreVideo.CVPixelBuffer pixelBuffer, global::ImageIO.CGImagePropertyOrientation orientation, NSDictionary optionsDict)
			: base (NSObjectFlag.Empty)
		{
			var pixelBuffer__handle__ = pixelBuffer!.GetNonNullHandle (nameof (pixelBuffer));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_NativeHandle (this.Handle, selInitWithTargetedCVPixelBuffer_Orientation_Options_XHandle, pixelBuffer__handle__, (int)orientation, optionsDict__handle__), "initWithTargetedCVPixelBuffer:orientation:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_int_NativeHandle (&__objc_super__, selInitWithTargetedCVPixelBuffer_Orientation_Options_XHandle, pixelBuffer__handle__, (int)orientation, optionsDict__handle__), "initWithTargetedCVPixelBuffer:orientation:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pixelBuffer);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="pixelBuffer">To be added.</param><param name="orientation">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (global::CoreVideo.CVPixelBuffer pixelBuffer, global::ImageIO.CGImagePropertyOrientation orientation, VNImageOptions options)
			: this (pixelBuffer, orientation, options.GetDictionary ()!)
		{
		}
		[Export ("initWithTargetedCVPixelBuffer:orientation:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (global::CoreVideo.CVPixelBuffer pixelBuffer, global::ImageIO.CGImagePropertyOrientation orientation, NSDictionary optionsDict, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDVNRequestCompletionHandler))]VNRequestCompletionHandler? completionHandler)
			: base (NSObjectFlag.Empty)
		{
			var pixelBuffer__handle__ = pixelBuffer!.GetNonNullHandle (nameof (pixelBuffer));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			using var block_completionHandler = Trampolines.SDVNRequestCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_NativeHandle_NativeHandle (this.Handle, selInitWithTargetedCVPixelBuffer_Orientation_Options_CompletionHandler_XHandle, pixelBuffer__handle__, (int)orientation, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedCVPixelBuffer:orientation:options:completionHandler:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_int_NativeHandle_NativeHandle (&__objc_super__, selInitWithTargetedCVPixelBuffer_Orientation_Options_CompletionHandler_XHandle, pixelBuffer__handle__, (int)orientation, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedCVPixelBuffer:orientation:options:completionHandler:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pixelBuffer);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="pixelBuffer">To be added.</param><param name="orientation">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (global::CoreVideo.CVPixelBuffer pixelBuffer, global::ImageIO.CGImagePropertyOrientation orientation, VNImageOptions options, VNRequestCompletionHandler completionHandler)
			: this (pixelBuffer, orientation, options.GetDictionary ()!, completionHandler)
		{
		}
		[Export ("initWithTargetedCGImage:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (CGImage cgImage, NSDictionary optionsDict)
			: base (NSObjectFlag.Empty)
		{
			var cgImage__handle__ = cgImage!.GetNonNullHandle (nameof (cgImage));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithTargetedCGImage_Options_XHandle, cgImage.Handle, optionsDict__handle__), "initWithTargetedCGImage:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithTargetedCGImage_Options_XHandle, cgImage.Handle, optionsDict__handle__), "initWithTargetedCGImage:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cgImage);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="cgImage">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (CGImage cgImage, VNImageOptions options)
			: this (cgImage, options.GetDictionary ()!)
		{
		}
		[Export ("initWithTargetedCGImage:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (CGImage cgImage, NSDictionary optionsDict, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDVNRequestCompletionHandler))]VNRequestCompletionHandler? completionHandler)
			: base (NSObjectFlag.Empty)
		{
			var cgImage__handle__ = cgImage!.GetNonNullHandle (nameof (cgImage));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			using var block_completionHandler = Trampolines.SDVNRequestCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithTargetedCGImage_Options_CompletionHandler_XHandle, cgImage.Handle, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedCGImage:options:completionHandler:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithTargetedCGImage_Options_CompletionHandler_XHandle, cgImage.Handle, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedCGImage:options:completionHandler:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cgImage);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="cgImage">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (CGImage cgImage, VNImageOptions options, VNRequestCompletionHandler completionHandler)
			: this (cgImage, options.GetDictionary ()!, completionHandler)
		{
		}
		[Export ("initWithTargetedCGImage:orientation:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (CGImage cgImage, global::ImageIO.CGImagePropertyOrientation orientation, NSDictionary optionsDict)
			: base (NSObjectFlag.Empty)
		{
			var cgImage__handle__ = cgImage!.GetNonNullHandle (nameof (cgImage));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_NativeHandle (this.Handle, selInitWithTargetedCGImage_Orientation_Options_XHandle, cgImage.Handle, (int)orientation, optionsDict__handle__), "initWithTargetedCGImage:orientation:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_int_NativeHandle (&__objc_super__, selInitWithTargetedCGImage_Orientation_Options_XHandle, cgImage.Handle, (int)orientation, optionsDict__handle__), "initWithTargetedCGImage:orientation:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cgImage);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="cgImage">To be added.</param><param name="orientation">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (CGImage cgImage, global::ImageIO.CGImagePropertyOrientation orientation, VNImageOptions options)
			: this (cgImage, orientation, options.GetDictionary ()!)
		{
		}
		[Export ("initWithTargetedCGImage:orientation:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (CGImage cgImage, global::ImageIO.CGImagePropertyOrientation orientation, NSDictionary optionsDict, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDVNRequestCompletionHandler))]VNRequestCompletionHandler? completionHandler)
			: base (NSObjectFlag.Empty)
		{
			var cgImage__handle__ = cgImage!.GetNonNullHandle (nameof (cgImage));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			using var block_completionHandler = Trampolines.SDVNRequestCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_NativeHandle_NativeHandle (this.Handle, selInitWithTargetedCGImage_Orientation_Options_CompletionHandler_XHandle, cgImage.Handle, (int)orientation, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedCGImage:orientation:options:completionHandler:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_int_NativeHandle_NativeHandle (&__objc_super__, selInitWithTargetedCGImage_Orientation_Options_CompletionHandler_XHandle, cgImage.Handle, (int)orientation, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedCGImage:orientation:options:completionHandler:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cgImage);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="cgImage">To be added.</param><param name="orientation">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (CGImage cgImage, global::ImageIO.CGImagePropertyOrientation orientation, VNImageOptions options, VNRequestCompletionHandler completionHandler)
			: this (cgImage, orientation, options.GetDictionary ()!, completionHandler)
		{
		}
		[Export ("initWithTargetedCIImage:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (global::CoreImage.CIImage ciImage, NSDictionary optionsDict)
			: base (NSObjectFlag.Empty)
		{
			var ciImage__handle__ = ciImage!.GetNonNullHandle (nameof (ciImage));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithTargetedCIImage_Options_XHandle, ciImage__handle__, optionsDict__handle__), "initWithTargetedCIImage:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithTargetedCIImage_Options_XHandle, ciImage__handle__, optionsDict__handle__), "initWithTargetedCIImage:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ciImage);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="ciImage">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (global::CoreImage.CIImage ciImage, VNImageOptions options)
			: this (ciImage, options.GetDictionary ()!)
		{
		}
		[Export ("initWithTargetedCIImage:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (global::CoreImage.CIImage ciImage, NSDictionary optionsDict, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDVNRequestCompletionHandler))]VNRequestCompletionHandler? completionHandler)
			: base (NSObjectFlag.Empty)
		{
			var ciImage__handle__ = ciImage!.GetNonNullHandle (nameof (ciImage));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			using var block_completionHandler = Trampolines.SDVNRequestCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithTargetedCIImage_Options_CompletionHandler_XHandle, ciImage__handle__, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedCIImage:options:completionHandler:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithTargetedCIImage_Options_CompletionHandler_XHandle, ciImage__handle__, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedCIImage:options:completionHandler:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ciImage);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="ciImage">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (global::CoreImage.CIImage ciImage, VNImageOptions options, VNRequestCompletionHandler completionHandler)
			: this (ciImage, options.GetDictionary ()!, completionHandler)
		{
		}
		[Export ("initWithTargetedCIImage:orientation:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (global::CoreImage.CIImage ciImage, global::ImageIO.CGImagePropertyOrientation orientation, NSDictionary optionsDict)
			: base (NSObjectFlag.Empty)
		{
			var ciImage__handle__ = ciImage!.GetNonNullHandle (nameof (ciImage));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_NativeHandle (this.Handle, selInitWithTargetedCIImage_Orientation_Options_XHandle, ciImage__handle__, (int)orientation, optionsDict__handle__), "initWithTargetedCIImage:orientation:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_int_NativeHandle (&__objc_super__, selInitWithTargetedCIImage_Orientation_Options_XHandle, ciImage__handle__, (int)orientation, optionsDict__handle__), "initWithTargetedCIImage:orientation:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ciImage);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="ciImage">To be added.</param><param name="orientation">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (global::CoreImage.CIImage ciImage, global::ImageIO.CGImagePropertyOrientation orientation, VNImageOptions options)
			: this (ciImage, orientation, options.GetDictionary ()!)
		{
		}
		[Export ("initWithTargetedCIImage:orientation:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (global::CoreImage.CIImage ciImage, global::ImageIO.CGImagePropertyOrientation orientation, NSDictionary optionsDict, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDVNRequestCompletionHandler))]VNRequestCompletionHandler? completionHandler)
			: base (NSObjectFlag.Empty)
		{
			var ciImage__handle__ = ciImage!.GetNonNullHandle (nameof (ciImage));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			using var block_completionHandler = Trampolines.SDVNRequestCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_NativeHandle_NativeHandle (this.Handle, selInitWithTargetedCIImage_Orientation_Options_CompletionHandler_XHandle, ciImage__handle__, (int)orientation, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedCIImage:orientation:options:completionHandler:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_int_NativeHandle_NativeHandle (&__objc_super__, selInitWithTargetedCIImage_Orientation_Options_CompletionHandler_XHandle, ciImage__handle__, (int)orientation, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedCIImage:orientation:options:completionHandler:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ciImage);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="ciImage">To be added.</param><param name="orientation">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (global::CoreImage.CIImage ciImage, global::ImageIO.CGImagePropertyOrientation orientation, VNImageOptions options, VNRequestCompletionHandler completionHandler)
			: this (ciImage, orientation, options.GetDictionary ()!, completionHandler)
		{
		}
		[Export ("initWithTargetedImageURL:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (NSUrl imageUrl, NSDictionary optionsDict)
			: base (NSObjectFlag.Empty)
		{
			var imageUrl__handle__ = imageUrl!.GetNonNullHandle (nameof (imageUrl));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithTargetedImageURL_Options_XHandle, imageUrl__handle__, optionsDict__handle__), "initWithTargetedImageURL:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithTargetedImageURL_Options_XHandle, imageUrl__handle__, optionsDict__handle__), "initWithTargetedImageURL:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (imageUrl);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="imageUrl">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (NSUrl imageUrl, VNImageOptions options)
			: this (imageUrl, options.GetDictionary ()!)
		{
		}
		[Export ("initWithTargetedImageURL:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (NSUrl imageUrl, NSDictionary optionsDict, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDVNRequestCompletionHandler))]VNRequestCompletionHandler? completionHandler)
			: base (NSObjectFlag.Empty)
		{
			var imageUrl__handle__ = imageUrl!.GetNonNullHandle (nameof (imageUrl));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			using var block_completionHandler = Trampolines.SDVNRequestCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithTargetedImageURL_Options_CompletionHandler_XHandle, imageUrl__handle__, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedImageURL:options:completionHandler:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithTargetedImageURL_Options_CompletionHandler_XHandle, imageUrl__handle__, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedImageURL:options:completionHandler:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (imageUrl);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="imageUrl">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (NSUrl imageUrl, VNImageOptions options, VNRequestCompletionHandler completionHandler)
			: this (imageUrl, options.GetDictionary ()!, completionHandler)
		{
		}
		[Export ("initWithTargetedImageURL:orientation:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (NSUrl imageUrl, global::ImageIO.CGImagePropertyOrientation orientation, NSDictionary optionsDict)
			: base (NSObjectFlag.Empty)
		{
			var imageUrl__handle__ = imageUrl!.GetNonNullHandle (nameof (imageUrl));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_NativeHandle (this.Handle, selInitWithTargetedImageURL_Orientation_Options_XHandle, imageUrl__handle__, (int)orientation, optionsDict__handle__), "initWithTargetedImageURL:orientation:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_int_NativeHandle (&__objc_super__, selInitWithTargetedImageURL_Orientation_Options_XHandle, imageUrl__handle__, (int)orientation, optionsDict__handle__), "initWithTargetedImageURL:orientation:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (imageUrl);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="imageUrl">To be added.</param><param name="orientation">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (NSUrl imageUrl, global::ImageIO.CGImagePropertyOrientation orientation, VNImageOptions options)
			: this (imageUrl, orientation, options.GetDictionary ()!)
		{
		}
		[Export ("initWithTargetedImageURL:orientation:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (NSUrl imageUrl, global::ImageIO.CGImagePropertyOrientation orientation, NSDictionary optionsDict, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDVNRequestCompletionHandler))]VNRequestCompletionHandler? completionHandler)
			: base (NSObjectFlag.Empty)
		{
			var imageUrl__handle__ = imageUrl!.GetNonNullHandle (nameof (imageUrl));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			using var block_completionHandler = Trampolines.SDVNRequestCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_NativeHandle_NativeHandle (this.Handle, selInitWithTargetedImageURL_Orientation_Options_CompletionHandler_XHandle, imageUrl__handle__, (int)orientation, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedImageURL:orientation:options:completionHandler:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_int_NativeHandle_NativeHandle (&__objc_super__, selInitWithTargetedImageURL_Orientation_Options_CompletionHandler_XHandle, imageUrl__handle__, (int)orientation, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedImageURL:orientation:options:completionHandler:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (imageUrl);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="imageUrl">To be added.</param><param name="orientation">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (NSUrl imageUrl, global::ImageIO.CGImagePropertyOrientation orientation, VNImageOptions options, VNRequestCompletionHandler completionHandler)
			: this (imageUrl, orientation, options.GetDictionary ()!, completionHandler)
		{
		}
		[Export ("initWithTargetedImageData:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (NSData imageData, NSDictionary optionsDict)
			: base (NSObjectFlag.Empty)
		{
			var imageData__handle__ = imageData!.GetNonNullHandle (nameof (imageData));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithTargetedImageData_Options_XHandle, imageData__handle__, optionsDict__handle__), "initWithTargetedImageData:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithTargetedImageData_Options_XHandle, imageData__handle__, optionsDict__handle__), "initWithTargetedImageData:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (imageData);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="imageData">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (NSData imageData, VNImageOptions options)
			: this (imageData, options.GetDictionary ()!)
		{
		}
		[Export ("initWithTargetedImageData:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (NSData imageData, NSDictionary optionsDict, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDVNRequestCompletionHandler))]VNRequestCompletionHandler? completionHandler)
			: base (NSObjectFlag.Empty)
		{
			var imageData__handle__ = imageData!.GetNonNullHandle (nameof (imageData));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			using var block_completionHandler = Trampolines.SDVNRequestCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithTargetedImageData_Options_CompletionHandler_XHandle, imageData__handle__, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedImageData:options:completionHandler:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithTargetedImageData_Options_CompletionHandler_XHandle, imageData__handle__, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedImageData:options:completionHandler:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (imageData);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="imageData">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (NSData imageData, VNImageOptions options, VNRequestCompletionHandler completionHandler)
			: this (imageData, options.GetDictionary ()!, completionHandler)
		{
		}
		[Export ("initWithTargetedImageData:orientation:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (NSData imageData, global::ImageIO.CGImagePropertyOrientation orientation, NSDictionary optionsDict)
			: base (NSObjectFlag.Empty)
		{
			var imageData__handle__ = imageData!.GetNonNullHandle (nameof (imageData));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_NativeHandle (this.Handle, selInitWithTargetedImageData_Orientation_Options_XHandle, imageData__handle__, (int)orientation, optionsDict__handle__), "initWithTargetedImageData:orientation:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_int_NativeHandle (&__objc_super__, selInitWithTargetedImageData_Orientation_Options_XHandle, imageData__handle__, (int)orientation, optionsDict__handle__), "initWithTargetedImageData:orientation:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (imageData);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="imageData">To be added.</param><param name="orientation">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (NSData imageData, global::ImageIO.CGImagePropertyOrientation orientation, VNImageOptions options)
			: this (imageData, orientation, options.GetDictionary ()!)
		{
		}
		[Export ("initWithTargetedImageData:orientation:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (NSData imageData, global::ImageIO.CGImagePropertyOrientation orientation, NSDictionary optionsDict, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDVNRequestCompletionHandler))]VNRequestCompletionHandler? completionHandler)
			: base (NSObjectFlag.Empty)
		{
			var imageData__handle__ = imageData!.GetNonNullHandle (nameof (imageData));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			using var block_completionHandler = Trampolines.SDVNRequestCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_NativeHandle_NativeHandle (this.Handle, selInitWithTargetedImageData_Orientation_Options_CompletionHandler_XHandle, imageData__handle__, (int)orientation, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedImageData:orientation:options:completionHandler:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_int_NativeHandle_NativeHandle (&__objc_super__, selInitWithTargetedImageData_Orientation_Options_CompletionHandler_XHandle, imageData__handle__, (int)orientation, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedImageData:orientation:options:completionHandler:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (imageData);
			GC.KeepAlive (optionsDict);
		}
		/// <param name="imageData">To be added.</param><param name="orientation">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (NSData imageData, global::ImageIO.CGImagePropertyOrientation orientation, VNImageOptions options, VNRequestCompletionHandler completionHandler)
			: this (imageData, orientation, options.GetDictionary ()!, completionHandler)
		{
		}
		[Export ("initWithTargetedCMSampleBuffer:options:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (global::CoreMedia.CMSampleBuffer sampleBuffer, NSDictionary optionsDict)
			: base (NSObjectFlag.Empty)
		{
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithTargetedCMSampleBuffer_Options_XHandle, sampleBuffer.Handle, optionsDict__handle__), "initWithTargetedCMSampleBuffer:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithTargetedCMSampleBuffer_Options_XHandle, sampleBuffer.Handle, optionsDict__handle__), "initWithTargetedCMSampleBuffer:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sampleBuffer);
			GC.KeepAlive (optionsDict);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (global::CoreMedia.CMSampleBuffer sampleBuffer, VNImageOptions options)
			: this (sampleBuffer, options.GetDictionary ()!)
		{
		}
		[Export ("initWithTargetedCMSampleBuffer:options:completionHandler:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (global::CoreMedia.CMSampleBuffer sampleBuffer, NSDictionary optionsDict, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDVNRequestCompletionHandler))]VNRequestCompletionHandler? completionHandler)
			: base (NSObjectFlag.Empty)
		{
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			using var block_completionHandler = Trampolines.SDVNRequestCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithTargetedCMSampleBuffer_Options_CompletionHandler_XHandle, sampleBuffer.Handle, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedCMSampleBuffer:options:completionHandler:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithTargetedCMSampleBuffer_Options_CompletionHandler_XHandle, sampleBuffer.Handle, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedCMSampleBuffer:options:completionHandler:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sampleBuffer);
			GC.KeepAlive (optionsDict);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (global::CoreMedia.CMSampleBuffer sampleBuffer, VNImageOptions options, VNRequestCompletionHandler completionHandler)
			: this (sampleBuffer, options.GetDictionary ()!, completionHandler)
		{
		}
		[Export ("initWithTargetedCMSampleBuffer:orientation:options:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (global::CoreMedia.CMSampleBuffer sampleBuffer, global::ImageIO.CGImagePropertyOrientation orientation, NSDictionary optionsDict)
			: base (NSObjectFlag.Empty)
		{
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_NativeHandle (this.Handle, selInitWithTargetedCMSampleBuffer_Orientation_Options_XHandle, sampleBuffer.Handle, (int)orientation, optionsDict__handle__), "initWithTargetedCMSampleBuffer:orientation:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_int_NativeHandle (&__objc_super__, selInitWithTargetedCMSampleBuffer_Orientation_Options_XHandle, sampleBuffer.Handle, (int)orientation, optionsDict__handle__), "initWithTargetedCMSampleBuffer:orientation:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sampleBuffer);
			GC.KeepAlive (optionsDict);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNTargetedImageRequest (global::CoreMedia.CMSampleBuffer sampleBuffer, global::ImageIO.CGImagePropertyOrientation orientation, VNImageOptions options)
			: this (sampleBuffer, orientation, options.GetDictionary ()!)
		{
		}
		[Export ("initWithTargetedCMSampleBuffer:orientation:options:completionHandler:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (global::CoreMedia.CMSampleBuffer sampleBuffer, global::ImageIO.CGImagePropertyOrientation orientation, NSDictionary optionsDict, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDVNRequestCompletionHandler))]VNRequestCompletionHandler? completionHandler)
			: base (NSObjectFlag.Empty)
		{
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			var optionsDict__handle__ = optionsDict!.GetNonNullHandle (nameof (optionsDict));
			using var block_completionHandler = Trampolines.SDVNRequestCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_NativeHandle_NativeHandle (this.Handle, selInitWithTargetedCMSampleBuffer_Orientation_Options_CompletionHandler_XHandle, sampleBuffer.Handle, (int)orientation, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedCMSampleBuffer:orientation:options:completionHandler:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_int_NativeHandle_NativeHandle (&__objc_super__, selInitWithTargetedCMSampleBuffer_Orientation_Options_CompletionHandler_XHandle, sampleBuffer.Handle, (int)orientation, optionsDict__handle__, (IntPtr) block_ptr_completionHandler), "initWithTargetedCMSampleBuffer:orientation:options:completionHandler:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sampleBuffer);
			GC.KeepAlive (optionsDict);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNTargetedImageRequest (global::CoreMedia.CMSampleBuffer sampleBuffer, global::ImageIO.CGImagePropertyOrientation orientation, VNImageOptions options, VNRequestCompletionHandler completionHandler)
			: this (sampleBuffer, orientation, options.GetDictionary ()!, completionHandler)
		{
		}
	} /* class VNTargetedImageRequest */
}
