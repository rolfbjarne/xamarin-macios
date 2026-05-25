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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace GLKit {
	/// <summary>Loads Image and cube maps into OpenGL textures.</summary><remarks><para>
	/// 	GLTextureLoader simplifies the process of loading textures and
	/// 	cube maps by providing a high-level API that can load images
	/// 	on a variety of graphic file formats (PNG, JPEG, TIFF and
	/// 	other formats supported by <see cref="N:ImageIO" />.
	/// 	The data can be loaded both synchronously and asynchrously from <see cref="T:CoreGraphics.CGImage" /> objects, in-memory
	/// 	binary data, files and arbitrary <see cref="T:Foundation.NSUrl" /> locations.
	/// 
	/// </para><para>
	/// 	You can control how textures are loaded by configuring the
	/// 	<see cref="GLKit.GLKTextureOperations" /> object.
	/// 	You can configure whether the texture will be premultiplied by
	/// 	their alpha channel or not, whether mipmaps should be created
	/// 	from the source image when the texture is loaded and whether
	/// 	the image should be flipped when it is loaded.
	/// 
	/// </para><para>
	/// 	To use the texture loader, make an <see cref="T:OpenGLES.EAGLContext" /> current, use one of
	/// 	the loading methods in this class and use the values in the
	/// 	returned <see cref="T:GLKit.GLKTextureInfo" /> which
	/// 	contains the OpenGL object name (an uint), properties such as
	/// 	width, heigh, alpha, origin and mipmapping.
	/// 	
	/// </para><para>
	/// 	To use the texture loaded asynchrously, create the context using the <see cref="T:OpenGLES.EAGLContext" />'s sharegroup.   Then you call one of the 
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// //
	/// // if myQueue is null, it dispatches into the main queue.
	/// void AsyncLoad (EAGLContext context, DispatchQueue myQueue)
	/// {
	/// var shareGroup = context.ShareGroup;
	/// var loader = new GLTextureLoader (shareGroup);
	/// var textureOperations = new GLKTextureOperations () {
	/// ApplyPremultiplication = true,
	/// GenerateMipmaps = true
	/// }
	/// 
	/// loader.BeginTextureLoad ("file.png", textureOperations, myQueue, TextureLoadedCallback);
	/// }
	/// 
	/// // 
	/// // Called on the specified queue.
	/// //
	/// void TextureLoadedCallback (GLKTextureInfo textureInfo, NSError error)
	/// {
	/// // Use texture info here.
	/// }
	/// ]]></code></example><para></para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GLKTextureLoader_ClassRef/index.html">Apple documentation for <c>GLKTextureLoader</c></related>
	[Register("GLKTextureLoader", true)]
	[ObsoletedOSPlatform ("ios12.0", "Use 'Metal' instead.")]
	[ObsoletedOSPlatform ("tvos12.0", "Use 'Metal' instead.")]
	[ObsoletedOSPlatform ("macos10.14", "Use 'Metal' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GLKTextureLoader : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GLKTextureLoader");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="GLKTextureLoader" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GLKTextureLoader () : base (NSObjectFlag.Empty)
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
		protected GLKTextureLoader (NSObjectFlag t) : base (t)
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
		protected internal GLKTextureLoader (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="sharegroup">Share context where the textures will be loaded.</param><summary>Creates a GLKTextureLoader for an EAGLSharegroup, used for asynchronous texture loading.</summary><remarks></remarks>
		[Export ("initWithSharegroup:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios12.2", "Use 'Metal' instead.")]
		[ObsoletedOSPlatform ("tvos12.2", "Use 'Metal' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'Metal' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GLKTextureLoader (global::OpenGLES.EAGLSharegroup sharegroup)
			: base (NSObjectFlag.Empty)
		{
			var sharegroup__handle__ = sharegroup!.GetNonNullHandle (nameof (sharegroup));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithSharegroup:"), sharegroup__handle__), "initWithSharegroup:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithSharegroup:"), sharegroup__handle__), "initWithSharegroup:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sharegroup);
		}
		[Export ("cubeMapWithContentsOfFiles:options:queue:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual void BeginLoadCubeMap (NSArray filePaths, NSDictionary? textureOperations, global::CoreFoundation.DispatchQueue? queue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGLKTextureLoaderCallback))]GLKTextureLoaderCallback onComplete)
		{
			var filePaths__handle__ = filePaths!.GetNonNullHandle (nameof (filePaths));
			var textureOperations__handle__ = textureOperations.GetHandle ();
			var queue__handle__ = queue.GetHandle ();
			if (onComplete is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (onComplete));
			using var block_onComplete = Trampolines.SDGLKTextureLoaderCallback.CreateBlock (onComplete);
			BlockLiteral *block_ptr_onComplete = &block_onComplete;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("cubeMapWithContentsOfFiles:options:queue:completionHandler:"), filePaths__handle__, textureOperations__handle__, queue__handle__, (IntPtr) block_ptr_onComplete);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("cubeMapWithContentsOfFiles:options:queue:completionHandler:"), filePaths__handle__, textureOperations__handle__, queue__handle__, (IntPtr) block_ptr_onComplete);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (filePaths);
			GC.KeepAlive (textureOperations);
			GC.KeepAlive (queue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual Task<GLKTextureInfo> BeginLoadCubeMapAsync (NSArray filePaths, NSDictionary? textureOperations, global::CoreFoundation.DispatchQueue? queue)
		{
			var tcs = new TaskCompletionSource<GLKTextureInfo> ();
			BeginLoadCubeMap(filePaths, textureOperations, queue, (textureInfo_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (textureInfo_!);
			});
			return tcs.Task;
		}
		/// <param name="fileName">File name where the data will be loaded from.</param><param name="textureOperations"><para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="queue"><para>The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="onComplete">Callback to invoke when the texture is loaded.   The callback receives a GLKTextureInfo and an NSError.</param><summary>Asynchronously loads a cube map.</summary><remarks></remarks>
		[Export ("cubeMapWithContentsOfFile:options:queue:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BeginLoadCubeMap (string fileName, NSDictionary? textureOperations, global::CoreFoundation.DispatchQueue? queue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGLKTextureLoaderCallback))]GLKTextureLoaderCallback onComplete)
		{
			if (fileName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileName));
			var textureOperations__handle__ = textureOperations.GetHandle ();
			var queue__handle__ = queue.GetHandle ();
			if (onComplete is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (onComplete));
			var nsfileName = CFString.CreateNative (fileName);
			using var block_onComplete = Trampolines.SDGLKTextureLoaderCallback.CreateBlock (onComplete);
			BlockLiteral *block_ptr_onComplete = &block_onComplete;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("cubeMapWithContentsOfFile:options:queue:completionHandler:"), nsfileName, textureOperations__handle__, queue__handle__, (IntPtr) block_ptr_onComplete);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("cubeMapWithContentsOfFile:options:queue:completionHandler:"), nsfileName, textureOperations__handle__, queue__handle__, (IntPtr) block_ptr_onComplete);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textureOperations);
			GC.KeepAlive (queue);
			CFString.ReleaseNative (nsfileName);
		}
		/// <param name="fileName">File name where the data will be loaded from.</param>
		/// <param name="textureOperations">An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.This parameter can be .</param>
		/// <param name="queue">The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.This parameter can be .</param>
		/// <summary>Asynchronously loads a cube map.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous BeginLoadCubeMap operation.   The value of the TResult parameter is a <see cref="GLKit.GLKTextureLoaderCallback" />.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GLKTextureInfo> BeginLoadCubeMapAsync (string fileName, NSDictionary? textureOperations, global::CoreFoundation.DispatchQueue? queue)
		{
			var tcs = new TaskCompletionSource<GLKTextureInfo> ();
			BeginLoadCubeMap(fileName, textureOperations, queue, (textureInfo_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (textureInfo_!);
			});
			return tcs.Task;
		}
		/// <param name="filePath">The file that contains the texture.</param><param name="textureOperations"><para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="queue"><para>The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="onComplete">Callback to invoke when the texture is loaded.   The callback receives a GLKTextureInfo and an NSError.</param><summary>Asynchronously loads a cube map.</summary><remarks></remarks>
		[Export ("cubeMapWithContentsOfURL:options:queue:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BeginLoadCubeMap (NSUrl filePath, NSDictionary? textureOperations, global::CoreFoundation.DispatchQueue? queue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGLKTextureLoaderCallback))]GLKTextureLoaderCallback onComplete)
		{
			var filePath__handle__ = filePath!.GetNonNullHandle (nameof (filePath));
			var textureOperations__handle__ = textureOperations.GetHandle ();
			var queue__handle__ = queue.GetHandle ();
			if (onComplete is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (onComplete));
			using var block_onComplete = Trampolines.SDGLKTextureLoaderCallback.CreateBlock (onComplete);
			BlockLiteral *block_ptr_onComplete = &block_onComplete;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("cubeMapWithContentsOfURL:options:queue:completionHandler:"), filePath__handle__, textureOperations__handle__, queue__handle__, (IntPtr) block_ptr_onComplete);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("cubeMapWithContentsOfURL:options:queue:completionHandler:"), filePath__handle__, textureOperations__handle__, queue__handle__, (IntPtr) block_ptr_onComplete);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (filePath);
			GC.KeepAlive (textureOperations);
			GC.KeepAlive (queue);
		}
		/// <param name="filePath">The file that contains the texture.</param>
		/// <param name="textureOperations">An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.This parameter can be .</param>
		/// <param name="queue">The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.This parameter can be .</param>
		/// <summary>Asynchronously loads a cube map.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous BeginLoadCubeMap operation.   The value of the TResult parameter is a <see cref="GLKit.GLKTextureLoaderCallback" />.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GLKTextureInfo> BeginLoadCubeMapAsync (NSUrl filePath, NSDictionary? textureOperations, global::CoreFoundation.DispatchQueue? queue)
		{
			var tcs = new TaskCompletionSource<GLKTextureInfo> ();
			BeginLoadCubeMap(filePath, textureOperations, queue, (textureInfo_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (textureInfo_!);
			});
			return tcs.Task;
		}
		/// <param name="file">The file that contains the texture.</param><param name="textureOperations"><para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="queue"><para>The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="onComplete">Callback to invoke when the texture is loaded.   The callback receives a GLKTextureInfo and an NSError.</param><summary>Asynchronously loads a texture.</summary><remarks></remarks>
		[Export ("textureWithContentsOfFile:options:queue:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BeginTextureLoad (string file, NSDictionary? textureOperations, global::CoreFoundation.DispatchQueue? queue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGLKTextureLoaderCallback))]GLKTextureLoaderCallback onComplete)
		{
			if (file is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (file));
			var textureOperations__handle__ = textureOperations.GetHandle ();
			var queue__handle__ = queue.GetHandle ();
			if (onComplete is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (onComplete));
			var nsfile = CFString.CreateNative (file);
			using var block_onComplete = Trampolines.SDGLKTextureLoaderCallback.CreateBlock (onComplete);
			BlockLiteral *block_ptr_onComplete = &block_onComplete;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textureWithContentsOfFile:options:queue:completionHandler:"), nsfile, textureOperations__handle__, queue__handle__, (IntPtr) block_ptr_onComplete);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("textureWithContentsOfFile:options:queue:completionHandler:"), nsfile, textureOperations__handle__, queue__handle__, (IntPtr) block_ptr_onComplete);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textureOperations);
			GC.KeepAlive (queue);
			CFString.ReleaseNative (nsfile);
		}
		/// <param name="file">The file that contains the texture.</param>
		/// <param name="textureOperations">An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.This parameter can be .</param>
		/// <param name="queue">The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.This parameter can be .</param>
		/// <summary>Asynchronously loads a texture.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous BeginTextureLoad operation.   The value of the TResult parameter is a <see cref="GLKit.GLKTextureLoaderCallback" />.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GLKTextureInfo> BeginTextureLoadAsync (string file, NSDictionary? textureOperations, global::CoreFoundation.DispatchQueue? queue)
		{
			var tcs = new TaskCompletionSource<GLKTextureInfo> ();
			BeginTextureLoad(file, textureOperations, queue, (textureInfo_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (textureInfo_!);
			});
			return tcs.Task;
		}
		/// <param name="filePath">The file that contains the texture.</param><param name="textureOperations"><para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="queue"><para>The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="onComplete">Callback to invoke when the texture is loaded.   The callback receives a GLKTextureInfo and an NSError.</param><summary>Asynchronously loads a texture.</summary><remarks></remarks>
		[Export ("textureWithContentsOfURL:options:queue:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BeginTextureLoad (NSUrl filePath, NSDictionary? textureOperations, global::CoreFoundation.DispatchQueue? queue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGLKTextureLoaderCallback))]GLKTextureLoaderCallback onComplete)
		{
			var filePath__handle__ = filePath!.GetNonNullHandle (nameof (filePath));
			var textureOperations__handle__ = textureOperations.GetHandle ();
			var queue__handle__ = queue.GetHandle ();
			if (onComplete is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (onComplete));
			using var block_onComplete = Trampolines.SDGLKTextureLoaderCallback.CreateBlock (onComplete);
			BlockLiteral *block_ptr_onComplete = &block_onComplete;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textureWithContentsOfURL:options:queue:completionHandler:"), filePath__handle__, textureOperations__handle__, queue__handle__, (IntPtr) block_ptr_onComplete);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("textureWithContentsOfURL:options:queue:completionHandler:"), filePath__handle__, textureOperations__handle__, queue__handle__, (IntPtr) block_ptr_onComplete);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (filePath);
			GC.KeepAlive (textureOperations);
			GC.KeepAlive (queue);
		}
		/// <param name="filePath">The file that contains the texture.</param>
		/// <param name="textureOperations">An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.This parameter can be .</param>
		/// <param name="queue">The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.This parameter can be .</param>
		/// <summary>Asynchronously loads a texture.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous BeginTextureLoad operation.   The value of the TResult parameter is a <see cref="GLKit.GLKTextureLoaderCallback" />.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GLKTextureInfo> BeginTextureLoadAsync (NSUrl filePath, NSDictionary? textureOperations, global::CoreFoundation.DispatchQueue? queue)
		{
			var tcs = new TaskCompletionSource<GLKTextureInfo> ();
			BeginTextureLoad(filePath, textureOperations, queue, (textureInfo_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (textureInfo_!);
			});
			return tcs.Task;
		}
		/// <param name="data">NSData object that contains the bitmap that will be loaded into the texture.</param><param name="textureOperations"><para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="queue"><para>The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="onComplete">Callback to invoke when the texture is loaded.   The callback receives a GLKTextureInfo and an NSError.</param><summary>Asynchronously loads a texture.</summary><remarks></remarks>
		[Export ("textureWithContentsOfData:options:queue:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BeginTextureLoad (NSData data, NSDictionary? textureOperations, global::CoreFoundation.DispatchQueue? queue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGLKTextureLoaderCallback))]GLKTextureLoaderCallback onComplete)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var textureOperations__handle__ = textureOperations.GetHandle ();
			var queue__handle__ = queue.GetHandle ();
			if (onComplete is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (onComplete));
			using var block_onComplete = Trampolines.SDGLKTextureLoaderCallback.CreateBlock (onComplete);
			BlockLiteral *block_ptr_onComplete = &block_onComplete;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textureWithContentsOfData:options:queue:completionHandler:"), data__handle__, textureOperations__handle__, queue__handle__, (IntPtr) block_ptr_onComplete);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("textureWithContentsOfData:options:queue:completionHandler:"), data__handle__, textureOperations__handle__, queue__handle__, (IntPtr) block_ptr_onComplete);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			GC.KeepAlive (textureOperations);
			GC.KeepAlive (queue);
		}
		/// <param name="data">NSData object that contains the bitmap that will be loaded into the texture.</param>
		/// <param name="textureOperations">An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.This parameter can be .</param>
		/// <param name="queue">The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.This parameter can be .</param>
		/// <summary>Asynchronously loads a texture.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous BeginTextureLoad operation.   The value of the TResult parameter is a <see cref="GLKit.GLKTextureLoaderCallback" />.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GLKTextureInfo> BeginTextureLoadAsync (NSData data, NSDictionary? textureOperations, global::CoreFoundation.DispatchQueue? queue)
		{
			var tcs = new TaskCompletionSource<GLKTextureInfo> ();
			BeginTextureLoad(data, textureOperations, queue, (textureInfo_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (textureInfo_!);
			});
			return tcs.Task;
		}
		/// <param name="image">CGImage that contains the image to be loaded into the texture.</param><param name="textureOperations"><para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="queue"><para>The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="onComplete">Callback to invoke when the texture is loaded.   The callback receives a GLKTextureInfo and an NSError.</param><summary>Asynchronously loads a texture.</summary><remarks></remarks>
		[Export ("textureWithCGImage:options:queue:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BeginTextureLoad (CGImage image, NSDictionary? textureOperations, global::CoreFoundation.DispatchQueue? queue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGLKTextureLoaderCallback))]GLKTextureLoaderCallback onComplete)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var textureOperations__handle__ = textureOperations.GetHandle ();
			var queue__handle__ = queue.GetHandle ();
			if (onComplete is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (onComplete));
			using var block_onComplete = Trampolines.SDGLKTextureLoaderCallback.CreateBlock (onComplete);
			BlockLiteral *block_ptr_onComplete = &block_onComplete;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textureWithCGImage:options:queue:completionHandler:"), image.Handle, textureOperations__handle__, queue__handle__, (IntPtr) block_ptr_onComplete);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("textureWithCGImage:options:queue:completionHandler:"), image.Handle, textureOperations__handle__, queue__handle__, (IntPtr) block_ptr_onComplete);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			GC.KeepAlive (textureOperations);
			GC.KeepAlive (queue);
		}
		/// <param name="image">CGImage that contains the image to be loaded into the texture.</param>
		/// <param name="textureOperations">An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.This parameter can be .</param>
		/// <param name="queue">The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.This parameter can be .</param>
		/// <summary>Asynchronously loads a texture.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous BeginTextureLoad operation.   The value of the TResult parameter is a <see cref="GLKit.GLKTextureLoaderCallback" />.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GLKTextureInfo> BeginTextureLoadAsync (CGImage image, NSDictionary? textureOperations, global::CoreFoundation.DispatchQueue? queue)
		{
			var tcs = new TaskCompletionSource<GLKTextureInfo> ();
			BeginTextureLoad(image, textureOperations, queue, (textureInfo_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (textureInfo_!);
			});
			return tcs.Task;
		}
		/// <param name="name">To be added.</param><param name="scaleFactor">To be added.</param><param name="bundle"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="options"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="queue"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="block">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("textureWithName:scaleFactor:bundle:options:queue:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BeginTextureLoad (string name, nfloat scaleFactor, NSBundle? bundle, NSDictionary<NSString, NSNumber>? options, global::CoreFoundation.DispatchQueue? queue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGLKTextureLoaderCallback))]GLKTextureLoaderCallback block)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var bundle__handle__ = bundle.GetHandle ();
			var options__handle__ = options.GetHandle ();
			var queue__handle__ = queue.GetHandle ();
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			var nsname = CFString.CreateNative (name);
			using var block_block = Trampolines.SDGLKTextureLoaderCallback.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textureWithName:scaleFactor:bundle:options:queue:completionHandler:"), nsname, scaleFactor, bundle__handle__, options__handle__, queue__handle__, (IntPtr) block_ptr_block);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_nfloat_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("textureWithName:scaleFactor:bundle:options:queue:completionHandler:"), nsname, scaleFactor, bundle__handle__, options__handle__, queue__handle__, (IntPtr) block_ptr_block);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (bundle);
			GC.KeepAlive (options);
			GC.KeepAlive (queue);
			CFString.ReleaseNative (nsname);
		}
		/// <param name="name">To be added.</param>
		/// <param name="scaleFactor">To be added.</param>
		/// <param name="bundle">To be added.</param>
		/// <param name="options">To be added.</param>
		/// <param name="queue">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous BeginTextureLoad operation.   The value of the TResult parameter is a <see cref="GLKit.GLKTextureLoaderCallback" />.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The BeginTextureLoadAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GLKTextureInfo> BeginTextureLoadAsync (string name, nfloat scaleFactor, NSBundle? bundle, NSDictionary<NSString, NSNumber>? options, global::CoreFoundation.DispatchQueue? queue)
		{
			var tcs = new TaskCompletionSource<GLKTextureInfo> ();
			BeginTextureLoad(name, scaleFactor, bundle, options, queue, (textureInfo_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (textureInfo_!);
			});
			return tcs.Task;
		}
		/// <param name="path">The file that contains the texture.</param><param name="textureOperations"><para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error">Error result.</param><summary>Loads a cube map synchronously.</summary><returns>On error, this will return null, the details of the error will be stored in the NSError parameter.   Otherwise the instance of the GLKTextureInfo.</returns><remarks>To be added.</remarks>
		[Export ("cubeMapWithContentsOfFile:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GLKTextureInfo? CubeMapFromFile (string path, NSDictionary? textureOperations, out NSError error)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var textureOperations__handle__ = textureOperations.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			var nspath = CFString.CreateNative (path);
			GLKTextureInfo? ret;
			ret =  Runtime.GetNSObject<GLKTextureInfo> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("cubeMapWithContentsOfFile:options:error:"), nspath, textureOperations__handle__, &errorValue), false)!;
			GC.KeepAlive (textureOperations);
			CFString.ReleaseNative (nspath);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("cubeMapWithContentsOfFiles:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static GLKTextureInfo? CubeMapFromFiles (NSArray paths, NSDictionary? textureOperations, out NSError error)
		{
			var paths__handle__ = paths!.GetNonNullHandle (nameof (paths));
			var textureOperations__handle__ = textureOperations.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			GLKTextureInfo? ret;
			ret =  Runtime.GetNSObject<GLKTextureInfo> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("cubeMapWithContentsOfFiles:options:error:"), paths__handle__, textureOperations__handle__, &errorValue), false)!;
			GC.KeepAlive (paths);
			GC.KeepAlive (textureOperations);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="url">URL pointing to the texture to load.</param><param name="textureOperations"><para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error">Error result.</param><summary>Loads a cube map synchronously.</summary><returns>On error, this will return null, the details of the error will be stored in the NSError parameter.   Otherwise the instance of the GLKTextureInfo.</returns><remarks>To be added.</remarks>
		[Export ("cubeMapWithContentsOfURL:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GLKTextureInfo? CubeMapFromUrl (NSUrl url, NSDictionary? textureOperations, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var textureOperations__handle__ = textureOperations.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			GLKTextureInfo? ret;
			ret =  Runtime.GetNSObject<GLKTextureInfo> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("cubeMapWithContentsOfURL:options:error:"), url__handle__, textureOperations__handle__, &errorValue), false)!;
			GC.KeepAlive (url);
			GC.KeepAlive (textureOperations);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="data">NSData object that contains the bitmap that will be loaded into the texture.</param><param name="textureOperations"><para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error">Error result.</param><summary>Loads a texture from an NSData source.</summary><returns>On error, this will return null, the details of the error will be stored in the NSError parameter.   Otherwise the instance of the GLKTextureInfo.</returns><remarks>To be added.</remarks>
		[Export ("textureWithContentsOfData:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GLKTextureInfo? FromData (NSData data, NSDictionary? textureOperations, out NSError error)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var textureOperations__handle__ = textureOperations.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			GLKTextureInfo? ret;
			ret =  Runtime.GetNSObject<GLKTextureInfo> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("textureWithContentsOfData:options:error:"), data__handle__, textureOperations__handle__, &errorValue), false)!;
			GC.KeepAlive (data);
			GC.KeepAlive (textureOperations);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="path">File name where the data will be loaded from.</param><param name="textureOperations"><para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error">Error result.</param><summary>Loads a texture from a file synchronously.</summary><returns>On error, this will return null, the details of the error will be stored in the NSError parameter.   Otherwise the instance of the GLKTextureInfo.</returns><remarks>To be added.</remarks>
		[Export ("textureWithContentsOfFile:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GLKTextureInfo? FromFile (string path, NSDictionary? textureOperations, out NSError error)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var textureOperations__handle__ = textureOperations.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			var nspath = CFString.CreateNative (path);
			GLKTextureInfo? ret;
			ret =  Runtime.GetNSObject<GLKTextureInfo> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("textureWithContentsOfFile:options:error:"), nspath, textureOperations__handle__, &errorValue), false)!;
			GC.KeepAlive (textureOperations);
			CFString.ReleaseNative (nspath);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="cgImage">CGImage that contains the image to be loaded into the texture.</param><param name="textureOperations"><para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error">Error result.</param><summary>Loads a texture from a CGImage.</summary><returns>On error, this will return null, the details of the error will be stored in the NSError parameter.   Otherwise the instance of the GLKTextureInfo be added.</returns><remarks></remarks>
		[Export ("textureWithCGImage:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GLKTextureInfo? FromImage (CGImage cgImage, NSDictionary? textureOperations, out NSError error)
		{
			var cgImage__handle__ = cgImage!.GetNonNullHandle (nameof (cgImage));
			var textureOperations__handle__ = textureOperations.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			GLKTextureInfo? ret;
			ret =  Runtime.GetNSObject<GLKTextureInfo> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("textureWithCGImage:options:error:"), cgImage.Handle, textureOperations__handle__, &errorValue), false)!;
			GC.KeepAlive (cgImage);
			GC.KeepAlive (textureOperations);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="name">To be added.</param><param name="scaleFactor">To be added.</param><param name="bundle"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="options"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textureWithName:scaleFactor:bundle:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GLKTextureInfo? FromName (string name, nfloat scaleFactor, NSBundle? bundle, NSDictionary<NSString, NSNumber>? options, out NSError outError)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var bundle__handle__ = bundle.GetHandle ();
			var options__handle__ = options.GetHandle ();
			NativeHandle outErrorValue = IntPtr.Zero;
			var nsname = CFString.CreateNative (name);
			GLKTextureInfo? ret;
			ret =  Runtime.GetNSObject<GLKTextureInfo> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("textureWithName:scaleFactor:bundle:options:error:"), nsname, scaleFactor, bundle__handle__, options__handle__, &outErrorValue), false)!;
			GC.KeepAlive (bundle);
			GC.KeepAlive (options);
			CFString.ReleaseNative (nsname);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		/// <param name="url">URL pointing to the texture to load.</param><param name="textureOperations"><para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error">Error result.</param><summary>Loads a texture from a file pointed to by the url.</summary><returns>On error, this will return null, the details of the error will be stored in the NSError parameter.   Otherwise the instance of the GLKTextureInfo.</returns><remarks>To be added.</remarks>
		[Export ("textureWithContentsOfURL:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GLKTextureInfo? FromUrl (NSUrl url, NSDictionary? textureOperations, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var textureOperations__handle__ = textureOperations.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			GLKTextureInfo? ret;
			ret =  Runtime.GetNSObject<GLKTextureInfo> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("textureWithContentsOfURL:options:error:"), url__handle__, textureOperations__handle__, &errorValue), false)!;
			GC.KeepAlive (url);
			GC.KeepAlive (textureOperations);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApplyPremultiplication;
		/// <summary>Represents the value associated with the constant GLKTextureLoaderApplyPremultiplication</summary><value></value><remarks>Used as a key for textureOperations if you are using the NSDictionary overloads instead of the strongly typed GLKTextureOperations class.</remarks>
		[Field ("GLKTextureLoaderApplyPremultiplication",  "GLKit")]
		public static NSString ApplyPremultiplication {
			get {
				if (_ApplyPremultiplication is null)
					_ApplyPremultiplication = Dlfcn.GetStringConstant (Libraries.GLKit.Handle, "GLKTextureLoaderApplyPremultiplication")!;
				return _ApplyPremultiplication;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ErrorDomain;
		/// <summary>Represents the value associated with the constant GLKTextureLoaderErrorDomain</summary><value></value><remarks></remarks>
		[Field ("GLKTextureLoaderErrorDomain",  "GLKit")]
		public static NSString ErrorDomain {
			get {
				if (_ErrorDomain is null)
					_ErrorDomain = Dlfcn.GetStringConstant (Libraries.GLKit.Handle, "GLKTextureLoaderErrorDomain")!;
				return _ErrorDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ErrorKey;
		/// <summary>Represents the value associated with the constant GLKTextureLoaderErrorKey</summary><value></value><remarks></remarks>
		[Field ("GLKTextureLoaderErrorKey",  "GLKit")]
		public static NSString ErrorKey {
			get {
				if (_ErrorKey is null)
					_ErrorKey = Dlfcn.GetStringConstant (Libraries.GLKit.Handle, "GLKTextureLoaderErrorKey")!;
				return _ErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GLErrorKey;
		/// <summary>Represents the value associated with the constant GLKTextureLoaderGLErrorKey</summary><value></value><remarks></remarks>
		[Field ("GLKTextureLoaderGLErrorKey",  "GLKit")]
		public static NSString GLErrorKey {
			get {
				if (_GLErrorKey is null)
					_GLErrorKey = Dlfcn.GetStringConstant (Libraries.GLKit.Handle, "GLKTextureLoaderGLErrorKey")!;
				return _GLErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GenerateMipmaps;
		/// <summary>Represents the value associated with the constant GLKTextureLoaderGenerateMipmaps</summary><value></value><remarks>Used as a key for textureOperations if you are using the NSDictionary overloads instead of the strongly typed GLKTextureOperations class.</remarks>
		[Field ("GLKTextureLoaderGenerateMipmaps",  "GLKit")]
		public static NSString GenerateMipmaps {
			get {
				if (_GenerateMipmaps is null)
					_GenerateMipmaps = Dlfcn.GetStringConstant (Libraries.GLKit.Handle, "GLKTextureLoaderGenerateMipmaps")!;
				return _GenerateMipmaps;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GrayscaleAsAlpha;
		/// <summary>Represents the value associated with the constant GLKTextureLoaderGrayscaleAsAlpha</summary><value></value><remarks>Used as a key for textureOperations if you are using the NSDictionary overloads instead of the strongly typed GLKTextureOperations class.</remarks>
		[Field ("GLKTextureLoaderGrayscaleAsAlpha",  "GLKit")]
		public static NSString GrayscaleAsAlpha {
			get {
				if (_GrayscaleAsAlpha is null)
					_GrayscaleAsAlpha = Dlfcn.GetStringConstant (Libraries.GLKit.Handle, "GLKTextureLoaderGrayscaleAsAlpha")!;
				return _GrayscaleAsAlpha;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OriginBottomLeft;
		/// <summary>Represents the value associated with the constant GLKTextureLoaderOriginBottomLeft</summary><value></value><remarks>Used as a key for textureOperations if you are using the NSDictionary overloads instead of the strongly typed GLKTextureOperations class.</remarks>
		[Field ("GLKTextureLoaderOriginBottomLeft",  "GLKit")]
		public static NSString OriginBottomLeft {
			get {
				if (_OriginBottomLeft is null)
					_OriginBottomLeft = Dlfcn.GetStringConstant (Libraries.GLKit.Handle, "GLKTextureLoaderOriginBottomLeft")!;
				return _OriginBottomLeft;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SRGB;
		/// <summary>Represents the value associated with the constant GLKTextureLoaderSRGB</summary><value></value><remarks>To be added.</remarks>
		[Field ("GLKTextureLoaderSRGB",  "GLKit")]
		public static NSString SRGB {
			get {
				if (_SRGB is null)
					_SRGB = Dlfcn.GetStringConstant (Libraries.GLKit.Handle, "GLKTextureLoaderSRGB")!;
				return _SRGB;
			}
		}
	} /* class GLKTextureLoader */
}
