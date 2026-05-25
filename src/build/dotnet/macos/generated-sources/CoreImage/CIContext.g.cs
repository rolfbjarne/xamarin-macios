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
	/// <summary>Orchestrates the rendering of a CIFilter pipeline.</summary><remarks><para>
	/// 	The CIContext class is used to orchestrate the rendering of a
	/// 	pipeline of filters into one of the supported output surfaces.
	/// </para><para>
	/// 	The CGContext can render its results into a CoreGraphics
	/// 	CGImage, render directly into the screen with one of the
	/// 	various Draw methods, into a CoreVideo CVPixelBuffer or into a CoreGraphics context.
	/// </para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/QuartzCoreFramework/Classes/CIContext_Class/index.html">Apple documentation for <c>CIContext</c></related>
	[Register("CIContext", true)]
	public unsafe partial class CIContext : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenEXRRepresentationOfImage_Options_Error_X = "OpenEXRRepresentationOfImage:options:error:";
		static readonly NativeHandle selOpenEXRRepresentationOfImage_Options_Error_XHandle = Selector.GetHandle ("OpenEXRRepresentationOfImage:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCalculateHDRStatsForCGImage_X = "calculateHDRStatsForCGImage:";
		static readonly NativeHandle selCalculateHDRStatsForCGImage_XHandle = Selector.GetHandle ("calculateHDRStatsForCGImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCalculateHDRStatsForCVPixelBuffer_X = "calculateHDRStatsForCVPixelBuffer:";
		static readonly NativeHandle selCalculateHDRStatsForCVPixelBuffer_XHandle = Selector.GetHandle ("calculateHDRStatsForCVPixelBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCalculateHDRStatsForIOSurface_X = "calculateHDRStatsForIOSurface:";
		static readonly NativeHandle selCalculateHDRStatsForIOSurface_XHandle = Selector.GetHandle ("calculateHDRStatsForIOSurface:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCalculateHDRStatsForImage_X = "calculateHDRStatsForImage:";
		static readonly NativeHandle selCalculateHDRStatsForImage_XHandle = Selector.GetHandle ("calculateHDRStatsForImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClearCachesX = "clearCaches";
		static readonly NativeHandle selClearCachesXHandle = Selector.GetHandle ("clearCaches");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextX = "context";
		static readonly NativeHandle selContextXHandle = Selector.GetHandle ("context");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextForOfflineGPUAtIndex_X = "contextForOfflineGPUAtIndex:";
		static readonly NativeHandle selContextForOfflineGPUAtIndex_XHandle = Selector.GetHandle ("contextForOfflineGPUAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextWithCGContext_Options_X = "contextWithCGContext:options:";
		static readonly NativeHandle selContextWithCGContext_Options_XHandle = Selector.GetHandle ("contextWithCGContext:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextWithMTLCommandQueue_X = "contextWithMTLCommandQueue:";
		static readonly NativeHandle selContextWithMTLCommandQueue_XHandle = Selector.GetHandle ("contextWithMTLCommandQueue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextWithMTLCommandQueue_Options_X = "contextWithMTLCommandQueue:options:";
		static readonly NativeHandle selContextWithMTLCommandQueue_Options_XHandle = Selector.GetHandle ("contextWithMTLCommandQueue:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextWithMTLDevice_X = "contextWithMTLDevice:";
		static readonly NativeHandle selContextWithMTLDevice_XHandle = Selector.GetHandle ("contextWithMTLDevice:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextWithMTLDevice_Options_X = "contextWithMTLDevice:options:";
		static readonly NativeHandle selContextWithMTLDevice_Options_XHandle = Selector.GetHandle ("contextWithMTLDevice:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextWithOptions_X = "contextWithOptions:";
		static readonly NativeHandle selContextWithOptions_XHandle = Selector.GetHandle ("contextWithOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateCGImage_FromRect_X = "createCGImage:fromRect:";
		static readonly NativeHandle selCreateCGImage_FromRect_XHandle = Selector.GetHandle ("createCGImage:fromRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateCGImage_FromRect_Format_ColorSpace_X = "createCGImage:fromRect:format:colorSpace:";
		static readonly NativeHandle selCreateCGImage_FromRect_Format_ColorSpace_XHandle = Selector.GetHandle ("createCGImage:fromRect:format:colorSpace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateCGImage_FromRect_Format_ColorSpace_Deferred_X = "createCGImage:fromRect:format:colorSpace:deferred:";
		static readonly NativeHandle selCreateCGImage_FromRect_Format_ColorSpace_Deferred_XHandle = Selector.GetHandle ("createCGImage:fromRect:format:colorSpace:deferred:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateCGImage_FromRect_Format_ColorSpace_Deferred_CalculateHDRStats_X = "createCGImage:fromRect:format:colorSpace:deferred:calculateHDRStats:";
		static readonly NativeHandle selCreateCGImage_FromRect_Format_ColorSpace_Deferred_CalculateHDRStats_XHandle = Selector.GetHandle ("createCGImage:fromRect:format:colorSpace:deferred:calculateHDRStats:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateCGLayerWithSize_Info_X = "createCGLayerWithSize:info:";
		static readonly NativeHandle selCreateCGLayerWithSize_Info_XHandle = Selector.GetHandle ("createCGLayerWithSize:info:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawImage_AtPoint_FromRect_X = "drawImage:atPoint:fromRect:";
		static readonly NativeHandle selDrawImage_AtPoint_FromRect_XHandle = Selector.GetHandle ("drawImage:atPoint:fromRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawImage_InRect_FromRect_X = "drawImage:inRect:fromRect:";
		static readonly NativeHandle selDrawImage_InRect_FromRect_XHandle = Selector.GetHandle ("drawImage:inRect:fromRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitX = "init";
		static readonly NativeHandle selInitXHandle = Selector.GetHandle ("init");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithOptions_X = "initWithOptions:";
		static readonly NativeHandle selInitWithOptions_XHandle = Selector.GetHandle ("initWithOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOfflineGPUCountX = "offlineGPUCount";
		static readonly NativeHandle selOfflineGPUCountXHandle = Selector.GetHandle ("offlineGPUCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReclaimResourcesX = "reclaimResources";
		static readonly NativeHandle selReclaimResourcesXHandle = Selector.GetHandle ("reclaimResources");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRender_ToBitmap_RowBytes_Bounds_Format_ColorSpace_X = "render:toBitmap:rowBytes:bounds:format:colorSpace:";
		static readonly NativeHandle selRender_ToBitmap_RowBytes_Bounds_Format_ColorSpace_XHandle = Selector.GetHandle ("render:toBitmap:rowBytes:bounds:format:colorSpace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRender_ToCVPixelBuffer_X = "render:toCVPixelBuffer:";
		static readonly NativeHandle selRender_ToCVPixelBuffer_XHandle = Selector.GetHandle ("render:toCVPixelBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRender_ToCVPixelBuffer_Bounds_ColorSpace_X = "render:toCVPixelBuffer:bounds:colorSpace:";
		static readonly NativeHandle selRender_ToCVPixelBuffer_Bounds_ColorSpace_XHandle = Selector.GetHandle ("render:toCVPixelBuffer:bounds:colorSpace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRender_ToIOSurface_Bounds_ColorSpace_X = "render:toIOSurface:bounds:colorSpace:";
		static readonly NativeHandle selRender_ToIOSurface_Bounds_ColorSpace_XHandle = Selector.GetHandle ("render:toIOSurface:bounds:colorSpace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRender_ToMTLTexture_CommandBuffer_Bounds_ColorSpace_X = "render:toMTLTexture:commandBuffer:bounds:colorSpace:";
		static readonly NativeHandle selRender_ToMTLTexture_CommandBuffer_Bounds_ColorSpace_XHandle = Selector.GetHandle ("render:toMTLTexture:commandBuffer:bounds:colorSpace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWorkingColorSpaceX = "workingColorSpace";
		static readonly NativeHandle selWorkingColorSpaceXHandle = Selector.GetHandle ("workingColorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWorkingFormatX = "workingFormat";
		static readonly NativeHandle selWorkingFormatXHandle = Selector.GetHandle ("workingFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteOpenEXRRepresentationOfImage_ToURL_Options_Error_X = "writeOpenEXRRepresentationOfImage:toURL:options:error:";
		static readonly NativeHandle selWriteOpenEXRRepresentationOfImage_ToURL_Options_Error_XHandle = Selector.GetHandle ("writeOpenEXRRepresentationOfImage:toURL:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CIContext");
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
		protected CIContext (NSObjectFlag t) : base (t)
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
		protected internal CIContext (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("init")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIContext ()
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
		[Export ("initWithOptions:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal CIContext (NSDictionary? options)
			: base (NSObjectFlag.Empty)
		{
			var options__handle__ = options.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithOptions_XHandle, options__handle__), "initWithOptions:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithOptions_XHandle, options__handle__), "initWithOptions:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
		}
		[Export ("calculateHDRStatsForIOSurface:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CalculateHdrStats (global::IOSurface.IOSurface surface)
		{
			var surface__handle__ = surface!.GetNonNullHandle (nameof (surface));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCalculateHDRStatsForIOSurface_XHandle, surface__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCalculateHDRStatsForIOSurface_XHandle, surface__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (surface);
		}
		[Export ("calculateHDRStatsForCVPixelBuffer:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CalculateHdrStats (global::CoreVideo.CVPixelBuffer buffer)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCalculateHDRStatsForCVPixelBuffer_XHandle, buffer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCalculateHDRStatsForCVPixelBuffer_XHandle, buffer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (buffer);
		}
		[Export ("calculateHDRStatsForCGImage:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGImage CalculateHdrStats (CGImage cgimage)
		{
			var cgimage__handle__ = cgimage!.GetNonNullHandle (nameof (cgimage));
			CGImage? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCalculateHDRStatsForCGImage_XHandle, cgimage.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCalculateHDRStatsForCGImage_XHandle, cgimage.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cgimage);
			return ret!;
		}
		[Export ("calculateHDRStatsForImage:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage? CalculateHdrStats (CIImage image)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			CIImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCalculateHDRStatsForImage_XHandle, image__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCalculateHDRStatsForImage_XHandle, image__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			return ret!;
		}
		/// <summary>Frees data in the cache and runs the garbage collector.</summary><remarks>To be added.</remarks>
		[Export ("clearCaches")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClearCaches ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selClearCachesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selClearCachesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Creates a new <see cref="T:CoreImage.CIContext" /> with default options.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("context")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIContext Create ()
		{
			CIContext ret;
			ret =  Runtime.GetNSObject<CIContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selContextXHandle), false)!;
			return ret;
		}
		[Export ("contextWithMTLCommandQueue:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIContext Create (global::Metal.IMTLCommandQueue commandQueue)
		{
			var commandQueue__handle__ = commandQueue!.GetNonNullHandle (nameof (commandQueue));
			CIContext? ret;
			ret =  Runtime.GetNSObject<CIContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selContextWithMTLCommandQueue_XHandle, commandQueue__handle__), false)!;
			GC.KeepAlive (commandQueue);
			return ret!;
		}
		[Export ("contextWithMTLCommandQueue:options:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIContext Create (global::Metal.IMTLCommandQueue commandQueue, NSDictionary<NSString, NSObject>? options)
		{
			var commandQueue__handle__ = commandQueue!.GetNonNullHandle (nameof (commandQueue));
			var options__handle__ = options.GetHandle ();
			CIContext? ret;
			ret =  Runtime.GetNSObject<CIContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selContextWithMTLCommandQueue_Options_XHandle, commandQueue__handle__, options__handle__), false)!;
			GC.KeepAlive (commandQueue);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="image">To be added.</param><param name="fromRectangle">To be added.</param><summary>Creates a new <see cref="T:CoreGraphics.CGImage" /> from the <paramref name="fromRectangle" /> region of <paramref name="image" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("createCGImage:fromRect:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGImage? CreateCGImage (CIImage image, CGRect fromRectangle)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			CGImage? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGRect (this.Handle, selCreateCGImage_FromRect_XHandle, image__handle__, fromRectangle), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_CGRect (&__objc_super__, selCreateCGImage_FromRect_XHandle, image__handle__, fromRectangle), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			return ret!;
		}
		/// <param name="image">To be added.</param><param name="fromRect">To be added.</param><param name="ciImageFormat">To be added.</param><param name="colorSpace"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("createCGImage:fromRect:format:colorSpace:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGImage? CreateCGImage (CIImage image, CGRect fromRect, int ciImageFormat, CGColorSpace? colorSpace)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var colorSpace__handle__ = colorSpace.GetHandle ();
			CGImage? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGRect_int_NativeHandle (this.Handle, selCreateCGImage_FromRect_Format_ColorSpace_XHandle, image__handle__, fromRect, ciImageFormat, colorSpace__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_CGRect_int_NativeHandle (&__objc_super__, selCreateCGImage_FromRect_Format_ColorSpace_XHandle, image__handle__, fromRect, ciImageFormat, colorSpace__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			GC.KeepAlive (colorSpace);
			return ret!;
		}
		/// <param name="image">To be added.</param><param name="fromRect">To be added.</param><param name="format">To be added.</param><param name="colorSpace"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="deferred">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("createCGImage:fromRect:format:colorSpace:deferred:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGImage? CreateCGImage (CIImage image, CGRect fromRect, CIFormat format, CGColorSpace? colorSpace, bool deferred)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var colorSpace__handle__ = colorSpace.GetHandle ();
			CGImage? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGRect_int_NativeHandle_bool (this.Handle, selCreateCGImage_FromRect_Format_ColorSpace_Deferred_XHandle, image__handle__, fromRect, (int)format, colorSpace__handle__, deferred ? (byte) 1 : (byte) 0), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_CGRect_int_NativeHandle_bool (&__objc_super__, selCreateCGImage_FromRect_Format_ColorSpace_Deferred_XHandle, image__handle__, fromRect, (int)format, colorSpace__handle__, deferred ? (byte) 1 : (byte) 0), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			GC.KeepAlive (colorSpace);
			return ret!;
		}
		[Export ("createCGImage:fromRect:format:colorSpace:deferred:calculateHDRStats:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGImage? CreateCGImage (CIImage image, CGRect fromRect, int format, CGColorSpace? colorSpace, bool deferred, bool calculateHdrStats)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var colorSpace__handle__ = colorSpace.GetHandle ();
			CGImage? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGRect_int_NativeHandle_bool_bool (this.Handle, selCreateCGImage_FromRect_Format_ColorSpace_Deferred_CalculateHDRStats_XHandle, image__handle__, fromRect, format, colorSpace__handle__, deferred ? (byte) 1 : (byte) 0, calculateHdrStats ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_CGRect_int_NativeHandle_bool_bool (&__objc_super__, selCreateCGImage_FromRect_Format_ColorSpace_Deferred_CalculateHDRStats_XHandle, image__handle__, fromRect, format, colorSpace__handle__, deferred ? (byte) 1 : (byte) 0, calculateHdrStats ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			GC.KeepAlive (colorSpace);
			return ret!;
		}
		[Export ("createCGLayerWithSize:info:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual CGLayer? CreateCGLayer (CGSize size, NSDictionary? info)
		{
			var info__handle__ = info.GetHandle ();
			CGLayer? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<global::CoreGraphics.CGLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize_NativeHandle (this.Handle, selCreateCGLayerWithSize_Info_XHandle, size, info__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGSize_NativeHandle (&__objc_super__, selCreateCGLayerWithSize_Info_XHandle, size, info__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (info);
			return ret!;
		}
		/// <param name="image">To be added.</param><param name="atPoint">To be added.</param><param name="fromRect">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DrawImage (image, CGRect, CGRect)' instead.</summary><remarks>To be added.</remarks>
		[Export ("drawImage:atPoint:fromRect:")]
		[ObsoletedOSPlatform ("ios6.0", "Use 'DrawImage (image, CGRect, CGRect)' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'DrawImage (image, CGRect, CGRect)' instead.")]
		[ObsoletedOSPlatform ("macos10.8", "Use 'DrawImage (image, CGRect, CGRect)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DrawImage (image, CGRect, CGRect)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawImage (CIImage image, CGPoint atPoint, CGRect fromRect)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_CGRect (this.Handle, selDrawImage_AtPoint_FromRect_XHandle, image__handle__, atPoint, fromRect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGPoint_CGRect (&__objc_super__, selDrawImage_AtPoint_FromRect_XHandle, image__handle__, atPoint, fromRect);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="image">The image to draw.</param><param name="inRectangle">The rectangle where to draw the image.</param><param name="fromRectangle">The rectangle of the image to draw.</param><summary>Draws the <paramref name="fromRectangle" /> portion of <paramref name="image" /> into the rectangle specified by <paramref name="inRectangle" />.</summary><remarks>To be added.</remarks>
		[Export ("drawImage:inRect:fromRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawImage (CIImage image, CGRect inRectangle, CGRect fromRectangle)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGRect_CGRect (this.Handle, selDrawImage_InRect_FromRect_XHandle, image__handle__, inRectangle, fromRectangle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGRect_CGRect (&__objc_super__, selDrawImage_InRect_FromRect_XHandle, image__handle__, inRectangle, fromRectangle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		[Export ("contextWithCGContext:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIContext FromContext (CGContext ctx, NSDictionary? options)
		{
			var ctx__handle__ = ctx!.GetNonNullHandle (nameof (ctx));
			var options__handle__ = options.GetHandle ();
			CIContext? ret;
			ret =  Runtime.GetNSObject<CIContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selContextWithCGContext_Options_XHandle, ctx.Handle, options__handle__), false)!;
			GC.KeepAlive (ctx);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="device">To be added.</param><summary>Creates a new CIContext from the provided Metal device.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("contextWithMTLDevice:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIContext FromMetalDevice (global::Metal.IMTLDevice device)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			CIContext? ret;
			ret =  Runtime.GetNSObject<CIContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selContextWithMTLDevice_XHandle, device__handle__), false)!;
			GC.KeepAlive (device);
			return ret!;
		}
		[Export ("contextWithMTLDevice:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIContext FromMetalDevice (global::Metal.IMTLDevice device, NSDictionary? options)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var options__handle__ = options.GetHandle ();
			CIContext? ret;
			ret =  Runtime.GetNSObject<CIContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selContextWithMTLDevice_Options_XHandle, device__handle__, options__handle__), false)!;
			GC.KeepAlive (device);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <summary>Creates a new <see cref="T:CoreImage.CIContext" /> from the provided Metal <paramref name="device" />, applying the specified options.</summary><param name="device">The source <see cref="T:Metal.IMTLDevice" />.</param><param name="options">The desired options for the new <see cref="T:CoreImage.CIContext" />.</param><returns>A new <see cref="T:CoreImage.CIContext" />.</returns>
		[Export ("contextWithMTLDevice:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIContext FromMetalDevice (global::Metal.IMTLDevice device, NSDictionary<NSString, NSObject>? options)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var options__handle__ = options.GetHandle ();
			CIContext? ret;
			ret =  Runtime.GetNSObject<CIContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selContextWithMTLDevice_Options_XHandle, device__handle__, options__handle__), false)!;
			GC.KeepAlive (device);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="gpuIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("contextForOfflineGPUAtIndex:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos10.14")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIContext? FromOfflineGpu (int gpuIndex)
		{
			CIContext ret;
			ret =  Runtime.GetNSObject<CIContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (class_ptr, selContextForOfflineGPUAtIndex_XHandle, gpuIndex), false)!;
			return ret;
		}
		[Export ("contextWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIContext FromOptions (NSDictionary? dictionary)
		{
			var dictionary__handle__ = dictionary.GetHandle ();
			CIContext? ret;
			ret =  Runtime.GetNSObject<CIContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selContextWithOptions_XHandle, dictionary__handle__), false)!;
			GC.KeepAlive (dictionary);
			return ret!;
		}
		[Export ("OpenEXRRepresentationOfImage:options:error:")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSData? GetOpenEXRRepresentation (CIImage image, NSDictionary<NSString, NSObject> options, out NSError? errorPtr)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorPtrValue = IntPtr.Zero;
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selOpenEXRRepresentationOfImage_Options_Error_XHandle, image__handle__, options__handle__, &errorPtrValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selOpenEXRRepresentationOfImage_Options_Error_XHandle, image__handle__, options__handle__, &errorPtrValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			GC.KeepAlive (options);
			errorPtr = Runtime.GetNSObject<NSError> (errorPtrValue)!;
			return ret!;
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("reclaimResources")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReclaimResources ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReclaimResourcesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selReclaimResourcesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="image">To be added.</param><param name="buffer">To be added.</param><summary>Renders <paramref name="image" /> to <paramref name="buffer" />.</summary><remarks>To be added.</remarks>
		[Export ("render:toCVPixelBuffer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Render (CIImage image, global::CoreVideo.CVPixelBuffer buffer)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRender_ToCVPixelBuffer_XHandle, image__handle__, buffer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRender_ToCVPixelBuffer_XHandle, image__handle__, buffer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			GC.KeepAlive (buffer);
		}
		/// <param name="image">To be added.</param><param name="buffer">To be added.</param><param name="rectangle">To be added.</param><param name="cs"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("render:toCVPixelBuffer:bounds:colorSpace:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Render (CIImage image, global::CoreVideo.CVPixelBuffer buffer, CGRect rectangle, CGColorSpace? cs)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			var cs__handle__ = cs.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGRect_NativeHandle (this.Handle, selRender_ToCVPixelBuffer_Bounds_ColorSpace_XHandle, image__handle__, buffer__handle__, rectangle, cs__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_CGRect_NativeHandle (&__objc_super__, selRender_ToCVPixelBuffer_Bounds_ColorSpace_XHandle, image__handle__, buffer__handle__, rectangle, cs__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			GC.KeepAlive (buffer);
			GC.KeepAlive (cs);
		}
		/// <param name="image">To be added.</param><param name="surface">To be added.</param><param name="bounds">To be added.</param><param name="colorSpace"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("render:toIOSurface:bounds:colorSpace:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Render (CIImage image, global::IOSurface.IOSurface surface, CGRect bounds, CGColorSpace? colorSpace)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var surface__handle__ = surface!.GetNonNullHandle (nameof (surface));
			var colorSpace__handle__ = colorSpace.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGRect_NativeHandle (this.Handle, selRender_ToIOSurface_Bounds_ColorSpace_XHandle, image__handle__, surface__handle__, bounds, colorSpace__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_CGRect_NativeHandle (&__objc_super__, selRender_ToIOSurface_Bounds_ColorSpace_XHandle, image__handle__, surface__handle__, bounds, colorSpace__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			GC.KeepAlive (surface);
			GC.KeepAlive (colorSpace);
		}
		/// <param name="image">To be added.</param><param name="texture">To be added.</param><param name="commandBuffer"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="bounds">To be added.</param><param name="colorSpace"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("render:toMTLTexture:commandBuffer:bounds:colorSpace:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Render (CIImage image, global::Metal.IMTLTexture texture, global::Metal.IMTLCommandBuffer? commandBuffer, CGRect bounds, CGColorSpace colorSpace)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			var commandBuffer__handle__ = commandBuffer.GetHandle ();
			var colorSpace__handle__ = colorSpace!.GetNonNullHandle (nameof (colorSpace));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_CGRect_NativeHandle (this.Handle, selRender_ToMTLTexture_CommandBuffer_Bounds_ColorSpace_XHandle, image__handle__, texture__handle__, commandBuffer__handle__, bounds, colorSpace.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_CGRect_NativeHandle (&__objc_super__, selRender_ToMTLTexture_CommandBuffer_Bounds_ColorSpace_XHandle, image__handle__, texture__handle__, commandBuffer__handle__, bounds, colorSpace.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			GC.KeepAlive (texture);
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (colorSpace);
		}
		/// <param name="image">To be added.</param><param name="bitmapPtr">To be added.</param><param name="bytesPerRow">To be added.</param><param name="bounds">To be added.</param><param name="bitmapFormat">To be added.</param><param name="colorSpace"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("render:toBitmap:rowBytes:bounds:format:colorSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RenderToBitmap (CIImage image, nint bitmapPtr, nint bytesPerRow, CGRect bounds, int bitmapFormat, CGColorSpace? colorSpace)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var colorSpace__handle__ = colorSpace.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr_CGRect_int_NativeHandle (this.Handle, selRender_ToBitmap_RowBytes_Bounds_Format_ColorSpace_XHandle, image__handle__, bitmapPtr, bytesPerRow, bounds, bitmapFormat, colorSpace__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_IntPtr_CGRect_int_NativeHandle (&__objc_super__, selRender_ToBitmap_RowBytes_Bounds_Format_ColorSpace_XHandle, image__handle__, bitmapPtr, bytesPerRow, bounds, bitmapFormat, colorSpace__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			GC.KeepAlive (colorSpace);
		}
		[Export ("writeOpenEXRRepresentationOfImage:toURL:options:error:")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool WriteOpenExrRepresentation (CIImage image, NSUrl url, NSDictionary<NSString, NSObject> options, out NSError? errorPtr)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorPtrValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selWriteOpenEXRRepresentationOfImage_ToURL_Options_Error_XHandle, image__handle__, url__handle__, options__handle__, &errorPtrValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selWriteOpenEXRRepresentationOfImage_ToURL_Options_Error_XHandle, image__handle__, url__handle__, options__handle__, &errorPtrValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			GC.KeepAlive (url);
			GC.KeepAlive (options);
			errorPtr = Runtime.GetNSObject<NSError> (errorPtrValue)!;
			return ret != 0;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static int OfflineGPUCount {
			[Export ("offlineGPUCount")]
			get {
				int ret;
				ret = global::ObjCRuntime.Messaging.int_objc_msgSend (class_ptr, selOfflineGPUCountXHandle);
				return ret;
			}
		}
		/// <summary>The working <see cref="T:CoreGraphics.CGColorSpace" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CGColorSpace? WorkingColorSpace {
			[Export ("workingColorSpace")]
			get {
				CGColorSpace ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWorkingColorSpaceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWorkingColorSpaceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>The working pixel format.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CIFormat WorkingFormat {
			[Export ("workingFormat")]
			get {
				CIFormat ret;
				if (IsDirectBinding) {
					ret = (CIFormat) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selWorkingFormatXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CIFormat) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selWorkingFormatXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MemoryLimit;
		/// <summary>Represents the value associated with the constant 'kCIContextMemoryLimit'.</summary>
		[Obsolete ("Use 'CIContextOptions.MemoryLimit' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCIContextMemoryLimit",  "CoreImage")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString MemoryLimit {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_MemoryLimit is null)
					_MemoryLimit = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIContextMemoryLimit")!;
				return _MemoryLimit;
			}
		}
	} /* class CIContext */
}
