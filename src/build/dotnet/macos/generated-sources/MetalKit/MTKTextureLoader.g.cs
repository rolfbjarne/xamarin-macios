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
namespace MetalKit {
	/// <summary>Creates <see cref="T:Metal.IMTLTexture" /> objects from common image formats.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MetalKit/Reference/MTKTextureLoader_ClassReference/index.html">Apple documentation for <c>MTKTextureLoader</c></related>
	[Register("MTKTextureLoader", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MTKTextureLoader : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceX = "device";
		static readonly NativeHandle selDeviceXHandle = Selector.GetHandle ("device");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDevice_X = "initWithDevice:";
		static readonly NativeHandle selInitWithDevice_XHandle = Selector.GetHandle ("initWithDevice:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewTextureWithCGImage_Options_CompletionHandler_X = "newTextureWithCGImage:options:completionHandler:";
		static readonly NativeHandle selNewTextureWithCGImage_Options_CompletionHandler_XHandle = Selector.GetHandle ("newTextureWithCGImage:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewTextureWithCGImage_Options_Error_X = "newTextureWithCGImage:options:error:";
		static readonly NativeHandle selNewTextureWithCGImage_Options_Error_XHandle = Selector.GetHandle ("newTextureWithCGImage:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewTextureWithContentsOfURL_Options_CompletionHandler_X = "newTextureWithContentsOfURL:options:completionHandler:";
		static readonly NativeHandle selNewTextureWithContentsOfURL_Options_CompletionHandler_XHandle = Selector.GetHandle ("newTextureWithContentsOfURL:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewTextureWithContentsOfURL_Options_Error_X = "newTextureWithContentsOfURL:options:error:";
		static readonly NativeHandle selNewTextureWithContentsOfURL_Options_Error_XHandle = Selector.GetHandle ("newTextureWithContentsOfURL:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewTextureWithData_Options_CompletionHandler_X = "newTextureWithData:options:completionHandler:";
		static readonly NativeHandle selNewTextureWithData_Options_CompletionHandler_XHandle = Selector.GetHandle ("newTextureWithData:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewTextureWithData_Options_Error_X = "newTextureWithData:options:error:";
		static readonly NativeHandle selNewTextureWithData_Options_Error_XHandle = Selector.GetHandle ("newTextureWithData:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewTextureWithMDLTexture_Options_CompletionHandler_X = "newTextureWithMDLTexture:options:completionHandler:";
		static readonly NativeHandle selNewTextureWithMDLTexture_Options_CompletionHandler_XHandle = Selector.GetHandle ("newTextureWithMDLTexture:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewTextureWithMDLTexture_Options_Error_X = "newTextureWithMDLTexture:options:error:";
		static readonly NativeHandle selNewTextureWithMDLTexture_Options_Error_XHandle = Selector.GetHandle ("newTextureWithMDLTexture:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewTextureWithName_ScaleFactor_Bundle_Options_CompletionHandler_X = "newTextureWithName:scaleFactor:bundle:options:completionHandler:";
		static readonly NativeHandle selNewTextureWithName_ScaleFactor_Bundle_Options_CompletionHandler_XHandle = Selector.GetHandle ("newTextureWithName:scaleFactor:bundle:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewTextureWithName_ScaleFactor_Bundle_Options_Error_X = "newTextureWithName:scaleFactor:bundle:options:error:";
		static readonly NativeHandle selNewTextureWithName_ScaleFactor_Bundle_Options_Error_XHandle = Selector.GetHandle ("newTextureWithName:scaleFactor:bundle:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewTextureWithName_ScaleFactor_DisplayGamut_Bundle_Options_CompletionHandler_X = "newTextureWithName:scaleFactor:displayGamut:bundle:options:completionHandler:";
		static readonly NativeHandle selNewTextureWithName_ScaleFactor_DisplayGamut_Bundle_Options_CompletionHandler_XHandle = Selector.GetHandle ("newTextureWithName:scaleFactor:displayGamut:bundle:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewTextureWithName_ScaleFactor_DisplayGamut_Bundle_Options_Error_X = "newTextureWithName:scaleFactor:displayGamut:bundle:options:error:";
		static readonly NativeHandle selNewTextureWithName_ScaleFactor_DisplayGamut_Bundle_Options_Error_XHandle = Selector.GetHandle ("newTextureWithName:scaleFactor:displayGamut:bundle:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewTexturesWithContentsOfURLs_Options_CompletionHandler_X = "newTexturesWithContentsOfURLs:options:completionHandler:";
		static readonly NativeHandle selNewTexturesWithContentsOfURLs_Options_CompletionHandler_XHandle = Selector.GetHandle ("newTexturesWithContentsOfURLs:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewTexturesWithContentsOfURLs_Options_Error_X = "newTexturesWithContentsOfURLs:options:error:";
		static readonly NativeHandle selNewTexturesWithContentsOfURLs_Options_Error_XHandle = Selector.GetHandle ("newTexturesWithContentsOfURLs:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewTexturesWithNames_ScaleFactor_Bundle_Options_CompletionHandler_X = "newTexturesWithNames:scaleFactor:bundle:options:completionHandler:";
		static readonly NativeHandle selNewTexturesWithNames_ScaleFactor_Bundle_Options_CompletionHandler_XHandle = Selector.GetHandle ("newTexturesWithNames:scaleFactor:bundle:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewTexturesWithNames_ScaleFactor_DisplayGamut_Bundle_Options_CompletionHandler_X = "newTexturesWithNames:scaleFactor:displayGamut:bundle:options:completionHandler:";
		static readonly NativeHandle selNewTexturesWithNames_ScaleFactor_DisplayGamut_Bundle_Options_CompletionHandler_XHandle = Selector.GetHandle ("newTexturesWithNames:scaleFactor:displayGamut:bundle:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MTKTextureLoader");
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
		protected MTKTextureLoader (NSObjectFlag t) : base (t)
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
		protected internal MTKTextureLoader (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithDevice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTKTextureLoader (global::Metal.IMTLDevice device)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithDevice_XHandle, device__handle__), "initWithDevice:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithDevice_XHandle, device__handle__), "initWithDevice:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
		}
		[Export ("newTextureWithCGImage:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual void FromCGImage (CGImage cgImage, NSDictionary? options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTKTextureLoaderCallback))]MTKTextureLoaderCallback completionHandler)
		{
			var cgImage__handle__ = cgImage!.GetNonNullHandle (nameof (cgImage));
			var options__handle__ = options.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTKTextureLoaderCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selNewTextureWithCGImage_Options_CompletionHandler_XHandle, cgImage.Handle, options__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selNewTextureWithCGImage_Options_CompletionHandler_XHandle, cgImage.Handle, options__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cgImage);
			GC.KeepAlive (options);
		}
		/// <param name="cgImage">A Core Graphics image.</param><param name="options">Options for loading the texture data.</param><param name="completionHandler">A handler to run after the texture is loaded.</param><summary>Creates and returns a Metal texture from the specified Core Graphics image and options, and runs a completion handler when it completes.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FromCGImage (CGImage cgImage, MTKTextureLoaderOptions? options, MTKTextureLoaderCallback completionHandler)
		{
			FromCGImage (cgImage, options.GetDictionary (), completionHandler);
		}
		/// <param name="cgImage">A Core Graphics image.</param>
		/// <param name="options">Options for loading the texture data.</param>
		/// <summary>Asynchronously creates a Metal texture from the specified Core Graphics image and options, and returns a task that provides the resulting image.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task<global::Metal.IMTLTexture> FromCGImageAsync (CGImage cgImage, MTKTextureLoaderOptions? options)
		{
			var tcs = new TaskCompletionSource<global::Metal.IMTLTexture> ();
			FromCGImage(cgImage, options, (texture_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (texture_!);
			});
			return tcs.Task;
		}
		[Export ("newTextureWithCGImage:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual global::Metal.IMTLTexture? FromCGImage (CGImage cgImage, NSDictionary? options, out NSError error)
		{
			var cgImage__handle__ = cgImage!.GetNonNullHandle (nameof (cgImage));
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			global::Metal.IMTLTexture? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selNewTextureWithCGImage_Options_Error_XHandle, cgImage.Handle, options__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selNewTextureWithCGImage_Options_Error_XHandle, cgImage.Handle, options__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cgImage);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="cgImage">A Core Graphics image.</param><param name="options">Options for loading the texture data.</param><param name="error">Contains the error, if one occurred.</param><summary>Creates and returns a Metal texture from the specified Core Graphics image and options.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe global::Metal.IMTLTexture? FromCGImage (CGImage cgImage, MTKTextureLoaderOptions? options, out NSError error)
		{
			return FromCGImage (cgImage, options.GetDictionary (), out error);
		}
		[Export ("newTextureWithData:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual void FromData (NSData data, NSDictionary? options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTKTextureLoaderCallback))]MTKTextureLoaderCallback completionHandler)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var options__handle__ = options.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTKTextureLoaderCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selNewTextureWithData_Options_CompletionHandler_XHandle, data__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selNewTextureWithData_Options_CompletionHandler_XHandle, data__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			GC.KeepAlive (options);
		}
		/// <param name="data">The texture data.</param><param name="options">Options for loading the texture data.</param><param name="completionHandler">A handler to run after the texture is loaded.</param><summary>Creates and returns a Metal texture from the specified image data and options, and runs a completion handler when it completes.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FromData (NSData data, MTKTextureLoaderOptions? options, MTKTextureLoaderCallback completionHandler)
		{
			FromData (data, options.GetDictionary (), completionHandler);
		}
		/// <param name="data">The texture data.</param>
		/// <param name="options">Options for loading the texture data.</param>
		/// <summary>Creates a Metal texture from the specified image data and options, returning a task that provides the resulting image.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task<global::Metal.IMTLTexture> FromDataAsync (NSData data, MTKTextureLoaderOptions? options)
		{
			var tcs = new TaskCompletionSource<global::Metal.IMTLTexture> ();
			FromData(data, options, (texture_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (texture_!);
			});
			return tcs.Task;
		}
		[Export ("newTextureWithData:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual global::Metal.IMTLTexture? FromData (NSData data, NSDictionary? options, out NSError error)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			global::Metal.IMTLTexture? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selNewTextureWithData_Options_Error_XHandle, data__handle__, options__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selNewTextureWithData_Options_Error_XHandle, data__handle__, options__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="data">The texture data.</param><param name="options">Options for loading the texture data.</param><param name="error">Contains the error, if one occurred.</param><summary>Creates and returns a Metal texture from the specified image data and options.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe global::Metal.IMTLTexture? FromData (NSData data, MTKTextureLoaderOptions? options, out NSError error)
		{
			return FromData (data, options.GetDictionary (), out error);
		}
		/// <param name="name">To be added.</param><param name="scaleFactor">To be added.</param><param name="bundle"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="options"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("newTextureWithName:scaleFactor:bundle:options:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FromName (string name, nfloat scaleFactor, NSBundle? bundle, NSDictionary? options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTKTextureLoaderCallback))]MTKTextureLoaderCallback completionHandler)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var bundle__handle__ = bundle.GetHandle ();
			var options__handle__ = options.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsname = CFString.CreateNative (name);
			using var block_completionHandler = Trampolines.SDMTKTextureLoaderCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat_NativeHandle_NativeHandle_NativeHandle (this.Handle, selNewTextureWithName_ScaleFactor_Bundle_Options_CompletionHandler_XHandle, nsname, scaleFactor, bundle__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_nfloat_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selNewTextureWithName_ScaleFactor_Bundle_Options_CompletionHandler_XHandle, nsname, scaleFactor, bundle__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (bundle);
			GC.KeepAlive (options);
			CFString.ReleaseNative (nsname);
		}
		/// <param name="name">To be added.</param>
		/// <param name="scaleFactor">To be added.</param>
		/// <param name="bundle">To be added.</param>
		/// <param name="options">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous FromName operation.   The value of the TResult parameter is a <see cref="nfloat" />.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<global::Metal.IMTLTexture> FromNameAsync (string name, nfloat scaleFactor, NSBundle? bundle, NSDictionary? options)
		{
			var tcs = new TaskCompletionSource<global::Metal.IMTLTexture> ();
			FromName(name, scaleFactor, bundle, options, (texture_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (texture_!);
			});
			return tcs.Task;
		}
		/// <param name="name">To be added.</param><param name="scaleFactor">To be added.</param><param name="bundle">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FromName (string name, nfloat scaleFactor, NSBundle? bundle, MTKTextureLoaderOptions? options, MTKTextureLoaderCallback completionHandler)
		{
			FromName (name, scaleFactor, bundle, options.GetDictionary (), completionHandler);
		}
		/// <param name="name">The asset catalog name of the image.</param>
		/// <param name="scaleFactor">The scale factor to use.</param>
		/// <param name="bundle">The bundle that contains the image data.</param>
		/// <param name="options">Options for loading the texture data.</param>
		/// <summary>Creates a new Metal texture with the specified name and options, returning a task that provides the resulting image.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task<global::Metal.IMTLTexture> FromNameAsync (string name, nfloat scaleFactor, NSBundle? bundle, MTKTextureLoaderOptions? options)
		{
			var tcs = new TaskCompletionSource<global::Metal.IMTLTexture> ();
			FromName(name, scaleFactor, bundle, options, (texture_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (texture_!);
			});
			return tcs.Task;
		}
		[Export ("newTextureWithName:scaleFactor:displayGamut:bundle:options:completionHandler:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FromName (string name, nfloat scaleFactor, global::AppKit.NSDisplayGamut displayGamut, NSBundle? bundle, NSDictionary? options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTKTextureLoaderCallback))]MTKTextureLoaderCallback completionHandler)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var bundle__handle__ = bundle.GetHandle ();
			var options__handle__ = options.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsname = CFString.CreateNative (name);
			using var block_completionHandler = Trampolines.SDMTKTextureLoaderCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat_IntPtr_NativeHandle_NativeHandle_NativeHandle (this.Handle, selNewTextureWithName_ScaleFactor_DisplayGamut_Bundle_Options_CompletionHandler_XHandle, nsname, scaleFactor, (IntPtr) (long) displayGamut, bundle__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_nfloat_IntPtr_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selNewTextureWithName_ScaleFactor_DisplayGamut_Bundle_Options_CompletionHandler_XHandle, nsname, scaleFactor, (IntPtr) (long) displayGamut, bundle__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (bundle);
			GC.KeepAlive (options);
			CFString.ReleaseNative (nsname);
		}
		/// <param name="name">To be added.</param>
		/// <param name="scaleFactor">To be added.</param>
		/// <param name="displayGamut">To be added.</param>
		/// <param name="bundle">To be added.</param>
		/// <param name="options">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<global::Metal.IMTLTexture> FromNameAsync (string name, nfloat scaleFactor, global::AppKit.NSDisplayGamut displayGamut, NSBundle? bundle, NSDictionary? options)
		{
			var tcs = new TaskCompletionSource<global::Metal.IMTLTexture> ();
			FromName(name, scaleFactor, displayGamut, bundle, options, (texture_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (texture_!);
			});
			return tcs.Task;
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FromName (string name, nfloat scaleFactor, global::AppKit.NSDisplayGamut displayGamut, NSBundle? bundle, MTKTextureLoaderOptions? options, MTKTextureLoaderCallback completionHandler)
		{
			FromName (name, scaleFactor, displayGamut, bundle, options.GetDictionary (), completionHandler);
		}
		/// <param name="name">To be added.</param>
		/// <param name="scaleFactor">To be added.</param>
		/// <param name="displayGamut">To be added.</param>
		/// <param name="bundle">To be added.</param>
		/// <param name="options">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task<global::Metal.IMTLTexture> FromNameAsync (string name, nfloat scaleFactor, global::AppKit.NSDisplayGamut displayGamut, NSBundle? bundle, MTKTextureLoaderOptions? options)
		{
			var tcs = new TaskCompletionSource<global::Metal.IMTLTexture> ();
			FromName(name, scaleFactor, displayGamut, bundle, options, (texture_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (texture_!);
			});
			return tcs.Task;
		}
		/// <param name="name">To be added.</param><param name="scaleFactor">To be added.</param><param name="bundle"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="options"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newTextureWithName:scaleFactor:bundle:options:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::Metal.IMTLTexture? FromName (string name, nfloat scaleFactor, NSBundle? bundle, NSDictionary? options, out NSError error)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var bundle__handle__ = bundle.GetHandle ();
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			var nsname = CFString.CreateNative (name);
			global::Metal.IMTLTexture? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selNewTextureWithName_ScaleFactor_Bundle_Options_Error_XHandle, nsname, scaleFactor, bundle__handle__, options__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_nfloat_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selNewTextureWithName_ScaleFactor_Bundle_Options_Error_XHandle, nsname, scaleFactor, bundle__handle__, options__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (bundle);
			GC.KeepAlive (options);
			CFString.ReleaseNative (nsname);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="name">To be added.</param><param name="scaleFactor">To be added.</param><param name="bundle">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe global::Metal.IMTLTexture? FromName (string name, nfloat scaleFactor, NSBundle? bundle, MTKTextureLoaderOptions? options, out NSError error)
		{
			return FromName (name, scaleFactor, bundle, options.GetDictionary (), out error);
		}
		[Export ("newTextureWithName:scaleFactor:displayGamut:bundle:options:error:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::Metal.IMTLTexture? FromName (string name, nfloat scaleFactor, global::AppKit.NSDisplayGamut displayGamut, NSBundle? bundle, NSDictionary? options, out NSError? error)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var bundle__handle__ = bundle.GetHandle ();
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			var nsname = CFString.CreateNative (name);
			global::Metal.IMTLTexture? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat_IntPtr_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selNewTextureWithName_ScaleFactor_DisplayGamut_Bundle_Options_Error_XHandle, nsname, scaleFactor, (IntPtr) (long) displayGamut, bundle__handle__, options__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_nfloat_IntPtr_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selNewTextureWithName_ScaleFactor_DisplayGamut_Bundle_Options_Error_XHandle, nsname, scaleFactor, (IntPtr) (long) displayGamut, bundle__handle__, options__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (bundle);
			GC.KeepAlive (options);
			CFString.ReleaseNative (nsname);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe global::Metal.IMTLTexture? FromName (string name, nfloat scaleFactor, global::AppKit.NSDisplayGamut displayGamut, NSBundle? bundle, MTKTextureLoaderOptions? options, out NSError? error)
		{
			return FromName (name, scaleFactor, displayGamut, bundle, options.GetDictionary (), out error);
		}
		/// <param name="names">To be added.</param><param name="scaleFactor">To be added.</param><param name="bundle"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="options"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("newTexturesWithNames:scaleFactor:bundle:options:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FromNames (string[] names, nfloat scaleFactor, NSBundle? bundle, NSDictionary? options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTKTextureLoaderArrayCallback))]MTKTextureLoaderArrayCallback completionHandler)
		{
			if (names is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (names));
			var bundle__handle__ = bundle.GetHandle ();
			var options__handle__ = options.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_names = NSArray.FromStrings (names);
			using var block_completionHandler = Trampolines.SDMTKTextureLoaderArrayCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat_NativeHandle_NativeHandle_NativeHandle (this.Handle, selNewTexturesWithNames_ScaleFactor_Bundle_Options_CompletionHandler_XHandle, nsa_names.Handle, scaleFactor, bundle__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_nfloat_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selNewTexturesWithNames_ScaleFactor_Bundle_Options_CompletionHandler_XHandle, nsa_names.Handle, scaleFactor, bundle__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (bundle);
			GC.KeepAlive (options);
		}
		/// <param name="names">To be added.</param>
		/// <param name="scaleFactor">To be added.</param>
		/// <param name="bundle">To be added.</param>
		/// <param name="options">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous FromNames operation.   The value of the TResult parameter is a <see cref="nfloat" />.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<global::Metal.IMTLTexture[]> FromNamesAsync (string[] names, nfloat scaleFactor, NSBundle? bundle, NSDictionary? options)
		{
			var tcs = new TaskCompletionSource<global::Metal.IMTLTexture[]> ();
			FromNames(names, scaleFactor, bundle, options, (textures_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (textures_!);
			});
			return tcs.Task;
		}
		/// <param name="names">To be added.</param><param name="scaleFactor">To be added.</param><param name="bundle">To be added.</param><param name="options">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FromNames (string[] names, nfloat scaleFactor, NSBundle? bundle, MTKTextureLoaderOptions? options, MTKTextureLoaderArrayCallback completionHandler)
		{
			FromNames (names, scaleFactor, bundle, options.GetDictionary (), completionHandler);
		}
		/// <param name="names">An array of asset catalog names for images to load.</param>
		/// <param name="scaleFactor">The scale factor to use.</param>
		/// <param name="bundle">The bundle that contains the image data.</param>
		/// <param name="options">Options for loading the texture data.</param>
		/// <summary>Creates an array of new Metal texture with the specified  and options, returning a task that provides the resulting array.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task<global::Metal.IMTLTexture[]> FromNamesAsync (string[] names, nfloat scaleFactor, NSBundle? bundle, MTKTextureLoaderOptions? options)
		{
			var tcs = new TaskCompletionSource<global::Metal.IMTLTexture[]> ();
			FromNames(names, scaleFactor, bundle, options, (textures_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (textures_!);
			});
			return tcs.Task;
		}
		[Export ("newTexturesWithNames:scaleFactor:displayGamut:bundle:options:completionHandler:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FromNames (string[] names, nfloat scaleFactor, global::AppKit.NSDisplayGamut displayGamut, NSBundle? bundle, NSDictionary? options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTKTextureLoaderArrayCallback))]MTKTextureLoaderArrayCallback completionHandler)
		{
			if (names is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (names));
			var bundle__handle__ = bundle.GetHandle ();
			var options__handle__ = options.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_names = NSArray.FromStrings (names);
			using var block_completionHandler = Trampolines.SDMTKTextureLoaderArrayCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat_IntPtr_NativeHandle_NativeHandle_NativeHandle (this.Handle, selNewTexturesWithNames_ScaleFactor_DisplayGamut_Bundle_Options_CompletionHandler_XHandle, nsa_names.Handle, scaleFactor, (IntPtr) (long) displayGamut, bundle__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_nfloat_IntPtr_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selNewTexturesWithNames_ScaleFactor_DisplayGamut_Bundle_Options_CompletionHandler_XHandle, nsa_names.Handle, scaleFactor, (IntPtr) (long) displayGamut, bundle__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (bundle);
			GC.KeepAlive (options);
		}
		/// <param name="names">To be added.</param>
		/// <param name="scaleFactor">To be added.</param>
		/// <param name="displayGamut">To be added.</param>
		/// <param name="bundle">To be added.</param>
		/// <param name="options">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<global::Metal.IMTLTexture[]> FromNamesAsync (string[] names, nfloat scaleFactor, global::AppKit.NSDisplayGamut displayGamut, NSBundle? bundle, NSDictionary? options)
		{
			var tcs = new TaskCompletionSource<global::Metal.IMTLTexture[]> ();
			FromNames(names, scaleFactor, displayGamut, bundle, options, (textures_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (textures_!);
			});
			return tcs.Task;
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FromNames (string[] names, nfloat scaleFactor, global::AppKit.NSDisplayGamut displayGamut, NSBundle? bundle, MTKTextureLoaderOptions? options, MTKTextureLoaderArrayCallback completionHandler)
		{
			FromNames (names, scaleFactor, displayGamut, bundle, options.GetDictionary (), completionHandler);
		}
		/// <param name="names">To be added.</param>
		/// <param name="scaleFactor">To be added.</param>
		/// <param name="displayGamut">To be added.</param>
		/// <param name="bundle">To be added.</param>
		/// <param name="options">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task<global::Metal.IMTLTexture[]> FromNamesAsync (string[] names, nfloat scaleFactor, global::AppKit.NSDisplayGamut displayGamut, NSBundle? bundle, MTKTextureLoaderOptions? options)
		{
			var tcs = new TaskCompletionSource<global::Metal.IMTLTexture[]> ();
			FromNames(names, scaleFactor, displayGamut, bundle, options, (textures_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (textures_!);
			});
			return tcs.Task;
		}
		[Export ("newTextureWithMDLTexture:options:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FromTexture (global::ModelIO.MDLTexture texture, NSDictionary? options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTKTextureLoaderCallback))]MTKTextureLoaderCallback completionHandler)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			var options__handle__ = options.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTKTextureLoaderCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selNewTextureWithMDLTexture_Options_CompletionHandler_XHandle, texture__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selNewTextureWithMDLTexture_Options_CompletionHandler_XHandle, texture__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (texture);
			GC.KeepAlive (options);
		}
		/// <param name="texture">The texture to load.</param>
		/// <param name="options">Options for loading the texture data.
		///           This parameter can be .</param>
		/// <summary>Creates a new Metal texture from the specified <paramref name="texture" />.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous FromTexture operation.   The value of the TResult parameter is a <see cref="MetalKit.MTKTextureLoaderCallback" />.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The FromTextureAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<global::Metal.IMTLTexture> FromTextureAsync (global::ModelIO.MDLTexture texture, NSDictionary? options)
		{
			var tcs = new TaskCompletionSource<global::Metal.IMTLTexture> ();
			FromTexture(texture, options, (texture_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (texture_!);
			});
			return tcs.Task;
		}
		/// <param name="texture">The texture to load.</param><param name="options">Options for loading the texture data.</param><param name="completionHandler">A handler to run after the texture is loaded.</param><summary>Creates a new Metal texture from the specified <paramref name="texture" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FromTexture (global::ModelIO.MDLTexture texture, MTKTextureLoaderOptions? options, MTKTextureLoaderCallback completionHandler)
		{
			FromTexture (texture, options.GetDictionary (), completionHandler);
		}
		/// <param name="texture">The texture to load.</param>
		/// <param name="options">Options for loading the texture data.</param>
		/// <summary>Creates a new Metal texture from the specified <paramref name="options" />, returning a task that provides the resulting texture.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task<global::Metal.IMTLTexture> FromTextureAsync (global::ModelIO.MDLTexture texture, MTKTextureLoaderOptions? options)
		{
			var tcs = new TaskCompletionSource<global::Metal.IMTLTexture> ();
			FromTexture(texture, options, (texture_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (texture_!);
			});
			return tcs.Task;
		}
		[Export ("newTextureWithMDLTexture:options:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::Metal.IMTLTexture? FromTexture (global::ModelIO.MDLTexture texture, NSDictionary? options, out NSError error)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			global::Metal.IMTLTexture? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selNewTextureWithMDLTexture_Options_Error_XHandle, texture__handle__, options__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selNewTextureWithMDLTexture_Options_Error_XHandle, texture__handle__, options__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (texture);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="texture">The texture to load.</param><param name="options">Options for loading the texture data.</param><param name="error">Contains the error, if one occurred.</param><summary>Creates a new Metal texture from the specified <paramref name="texture" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe global::Metal.IMTLTexture? FromTexture (global::ModelIO.MDLTexture texture, MTKTextureLoaderOptions? options, out NSError error)
		{
			return FromTexture (texture, options.GetDictionary (), out error);
		}
		[Export ("newTextureWithContentsOfURL:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual void FromUrl (NSUrl url, NSDictionary? options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTKTextureLoaderCallback))]MTKTextureLoaderCallback completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTKTextureLoaderCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selNewTextureWithContentsOfURL_Options_CompletionHandler_XHandle, url__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selNewTextureWithContentsOfURL_Options_CompletionHandler_XHandle, url__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (options);
		}
		/// <param name="url">The location of the image data to load.</param><param name="options">Options for loading the texture data.</param><param name="completionHandler">A handler to run after the texture is loaded.</param><summary>Creates a new Metal texture from the resource at the specified <paramref name="url" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FromUrl (NSUrl url, MTKTextureLoaderOptions? options, MTKTextureLoaderCallback completionHandler)
		{
			FromUrl (url, options.GetDictionary (), completionHandler);
		}
		/// <param name="url">The location of the image data to load.</param>
		/// <param name="options">Options for loading the texture data.</param>
		/// <summary>Creates a new Metal texture from the resource at the specified <paramref name="url" />, returning a task that provides the resulting texture.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task<global::Metal.IMTLTexture> FromUrlAsync (NSUrl url, MTKTextureLoaderOptions? options)
		{
			var tcs = new TaskCompletionSource<global::Metal.IMTLTexture> ();
			FromUrl(url, options, (texture_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (texture_!);
			});
			return tcs.Task;
		}
		[Export ("newTextureWithContentsOfURL:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual global::Metal.IMTLTexture? FromUrl (NSUrl url, NSDictionary? options, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			global::Metal.IMTLTexture? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selNewTextureWithContentsOfURL_Options_Error_XHandle, url__handle__, options__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selNewTextureWithContentsOfURL_Options_Error_XHandle, url__handle__, options__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="url">The location of the image data to load.</param><param name="options">Options for loading the texture data.</param><param name="error">Contains the error, if one occurred.</param><summary>Creates a new Metal texture from the resource at the specified <paramref name="url" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe global::Metal.IMTLTexture? FromUrl (NSUrl url, MTKTextureLoaderOptions? options, out NSError error)
		{
			return FromUrl (url, options.GetDictionary (), out error);
		}
		[Export ("newTexturesWithContentsOfURLs:options:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FromUrls (NSUrl[] urls, NSDictionary? options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTKTextureLoaderArrayCallback))]MTKTextureLoaderArrayCallback completionHandler)
		{
			if (urls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urls));
			var options__handle__ = options.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_urls = NSArray.FromNSObjects (urls);
			using var block_completionHandler = Trampolines.SDMTKTextureLoaderArrayCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selNewTexturesWithContentsOfURLs_Options_CompletionHandler_XHandle, nsa_urls.Handle, options__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selNewTexturesWithContentsOfURLs_Options_CompletionHandler_XHandle, nsa_urls.Handle, options__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
		}
		/// <param name="urls">The locations of the image data to load.</param>
		/// <param name="options">Options for loading the texture data.
		///           This parameter can be .</param>
		/// <summary>Creates an array of new Metal textures from the resources at the specified <paramref name="urls" />.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous FromUrls operation.   The value of the TResult parameter is a <see cref="MetalKit.MTKTextureLoaderArrayCallback" />.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<global::Metal.IMTLTexture[]> FromUrlsAsync (NSUrl[] urls, NSDictionary? options)
		{
			var tcs = new TaskCompletionSource<global::Metal.IMTLTexture[]> ();
			FromUrls(urls, options, (textures_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (textures_!);
			});
			return tcs.Task;
		}
		/// <param name="urls">The locations of the image data to load.</param><param name="options">Options for loading the texture data.</param><param name="completionHandler">A handler to run after the texture is loaded.</param><summary>Creates an array of new Metal textures from the resources at the specified <paramref name="urls" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FromUrls (NSUrl[] urls, MTKTextureLoaderOptions? options, MTKTextureLoaderArrayCallback completionHandler)
		{
			FromUrls (urls, options.GetDictionary (), completionHandler);
		}
		/// <param name="urls">The locations of the image data to load.</param>
		/// <param name="options">Options for loading the texture data.</param>
		/// <summary>Creates an array of new Metal textures from the resource sat the specified <paramref name="urls" />, returning a task that provides the resulting texture array.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task<global::Metal.IMTLTexture[]> FromUrlsAsync (NSUrl[] urls, MTKTextureLoaderOptions? options)
		{
			var tcs = new TaskCompletionSource<global::Metal.IMTLTexture[]> ();
			FromUrls(urls, options, (textures_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (textures_!);
			});
			return tcs.Task;
		}
		[Export ("newTexturesWithContentsOfURLs:options:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::Metal.IMTLTexture[] FromUrls (NSUrl[] urls, NSDictionary? options, out NSError error)
		{
			if (urls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urls));
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_urls = NSArray.FromNSObjects (urls);
			global::Metal.IMTLTexture[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<global::Metal.IMTLTexture>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selNewTexturesWithContentsOfURLs_Options_Error_XHandle, nsa_urls.Handle, options__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<global::Metal.IMTLTexture>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selNewTexturesWithContentsOfURLs_Options_Error_XHandle, nsa_urls.Handle, options__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="urls">The locations of the image data to load.</param><param name="options">Options for loading the texture data.</param><param name="error">Contains the error, if one occurred.</param><summary>Creates an array of new Metal textures from the resources at the specified <paramref name="urls" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe global::Metal.IMTLTexture[] FromUrls (NSUrl[] urls, MTKTextureLoaderOptions? options, out NSError error)
		{
			return FromUrls (urls, options.GetDictionary (), out error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLDevice Device {
			[Export ("device")]
			get {
				global::Metal.IMTLDevice? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDeviceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDeviceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class MTKTextureLoader */
}
